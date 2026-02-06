# Framework Assembly Conflict Handling in MSBuild

## Question
**"I know that this task will not consider it a conflict if an assembly is part of the framework. Can you show me where this is handled?"**

## Answer

The task you're referring to is the **ResolveAssemblyReference (RAR)** task in MSBuild. When RAR detects assembly conflicts (multiple versions of the same assembly being referenced), it has special logic to handle framework assemblies differently.

## Where This is Handled

### Source Code Location

The logic for handling framework assemblies and preventing them from being treated as conflicts is primarily implemented in:

**Repository**: [`dotnet/msbuild`](https://github.com/dotnet/msbuild)

**Primary Files**:

1. **[`src/Tasks/AssemblyDependency/ResolveAssemblyReference.cs`](https://github.com/dotnet/msbuild/blob/main/src/Tasks/AssemblyDependency/ResolveAssemblyReference.cs)**
   - Main task implementation
   - Contains the `NotCopyLocalBecauseFrameworksFiles` string constant
   - Coordinates framework assembly resolution

2. **[`src/Tasks/RedistList.cs`](https://github.com/dotnet/msbuild/blob/main/src/Tasks/RedistList.cs)**
   - **THIS IS THE KEY FILE** for framework assembly handling
   - Defines the `IsRedistRoot` property
   - Reads and parses `FrameworkList.xml` files
   - Determines which assemblies are part of the framework

3. **`src/Tasks/AssemblyDependency/ReferenceTable.cs`**
   - Manages reference resolution and conflict detection
   - Uses redist information to make CopyLocal decisions

### How It Works

#### 1. **IsRedistRoot Property**

Framework assemblies are identified using the **`IsRedistRoot`** metadata property. This property indicates that an assembly is part of the framework's redistribution list and should be treated differently during conflict resolution.

```xml
<!-- Example of metadata set by RAR -->
<ResolvedFiles Include="System.Runtime.dll">
  <IsRedistRoot>true</IsRedistRoot>
  <CopyLocal>false</CopyLocal>
</ResolvedFiles>
```

#### 2. **FrameworkList.xml**

RAR consults `FrameworkList.xml` files from the targeting pack to determine which assemblies are part of the framework. These files are located in the .NET reference assemblies directories.

Example path: `C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.0\data\FrameworkList.xml`

(Replace `8.0.0` with your actual .NET version)

#### 3. **Conflict Resolution Logic**

When RAR detects a potential conflict:

1. **Checks if the assembly is a framework assembly** (IsRedistRoot = true)
2. **If it is a framework assembly**:
   - It is NOT treated as a conflict
   - `CopyLocal` is set to `false` (won't be copied to output directory)
   - The framework version takes precedence
   - No conflict warning is generated
3. **If it is NOT a framework assembly**:
   - Standard conflict resolution applies
   - May generate MSB3277 warning for unresolved conflicts
   - Higher version typically wins
   - May require binding redirects

### Key Code Snippets

Here are the critical pieces of code from the MSBuild source:

#### 1. **IsRedistRoot Property Check (RedistList.cs)**

```csharp
/// <summary>
/// Determines whether or not the specified assembly is a redist root.
/// </summary>
internal bool? IsRedistRoot(string assemblyName)
{
    AssemblyEntry entry = GetUnifiedAssemblyEntry(assemblyName);
    return entry?.IsRedistRoot;
}
```

This method checks if an assembly is a "redist root" (part of the framework). When this returns `true`, the assembly:
- Is NOT treated as a conflict
- Has `CopyLocal` set to `false`
- Does not generate conflict warnings

#### 2. **Framework Assembly Detection (RedistList.cs)**

```csharp
/// <summary>
/// Determines whether or not the specified assembly is part of the Framework.
/// Assemblies from a previous version of the Framework will be
/// correctly identified.
/// </summary>
public bool IsFrameworkAssembly(string assemblyName)
{
    AssemblyEntry entry = GetUnifiedAssemblyEntry(assemblyName);
    if (!String.IsNullOrEmpty(entry?.RedistName))
    {
        AssemblyNameExtension assembly = GetAssemblyNameExtension(assemblyName);

        // The version of the checking assembly should be lower than the one of the unified assembly
        if (assembly.Version <= entry.AssemblyNameExtension.Version)
        {
            return entry.RedistName.StartsWith("Microsoft-Windows-CLRCoreComp", StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }
    return false;
}
```

This method identifies framework assemblies by checking the `RedistName` from the `FrameworkList.xml` entries.

#### 3. **Not CopyLocal Message (ResolveAssemblyReference.cs)**

```csharp
NotCopyLocalBecauseFrameworksFiles = GetResourceFourSpaces("ResolveAssemblyReference.NotCopyLocalBecauseFrameworksFiles");
```

This constant defines the log message shown when an assembly is not copied because it's part of the framework.

### Documentation

Official documentation on the RAR task:
- [ResolveAssemblyReference Task](https://learn.microsoft.com/en-us/visualstudio/msbuild/resolveassemblyreference-task)
- [MSBuild ResolveAssemblyReference Wiki](https://github.com/dotnet/msbuild/blob/main/documentation/wiki/ResolveAssemblyReference.md)

### Example Behavior

```plaintext
# Scenario: Project references both:
# - System.Text.Json version 6.0.0 (from NuGet)
# - System.Text.Json version 7.0.0 (from .NET 7 framework)

# Result:
# - The framework version (7.0.0) is used
# - No conflict warning is generated
# - System.Text.Json is NOT copied to output (it's in the framework)
# - This is because System.Text.Json is identified as IsRedistRoot=true
```

### Related Parameters

The RAR task has several parameters that affect this behavior:

- **`TargetFrameworkDirectories`**: Paths to framework reference assemblies
- **`InstalledAssemblyTables`**: Lists of installed assemblies (RedistList)
- **`IgnoreDefaultInstalledAssemblyTables`**: Whether to ignore default framework lists
- **`CopyLocalDependenciesWhenParentReferenceInGac`**: Affects copying decisions

## Summary

**The framework assembly conflict handling is primarily in the `RedistList.cs` file in the dotnet/msbuild repository**, with coordination in `ResolveAssemblyReference.cs`. Framework assemblies are identified via the redist list (`FrameworkList.xml`) and marked with `IsRedistRoot=true`, which causes RAR to:

1. Not treat them as conflicts
2. Not copy them locally
3. Prefer the framework version over package versions
4. Not generate conflict warnings

This prevents unnecessary warnings and output folder bloat when framework assemblies are involved in what would otherwise be version conflicts.
