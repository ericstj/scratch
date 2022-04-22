// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Composition
{
    public static partial class CompositionContextExtensions
    {
        public static void SatisfyImports(this System.Composition.CompositionContext compositionContext, object objectWithLooseImports) { }
        public static void SatisfyImports(this System.Composition.CompositionContext compositionContext, object objectWithLooseImports, System.Composition.Convention.AttributedModelProvider conventions) { }
    }
}
namespace System.Composition.Hosting
{
    public partial class ContainerConfiguration
    {
        public ContainerConfiguration() { }
        public System.Composition.Hosting.CompositionHost CreateContainer() { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithAssemblies(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies, System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithAssembly(System.Reflection.Assembly assembly) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithAssembly(System.Reflection.Assembly assembly, System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithDefaultConventions(System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithExport(System.Type contractType, object exportedInstance) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithExport(System.Type contractType, object exportedInstance, string contractName = null, System.Collections.Generic.IDictionary<string, object> metadata = null) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithExport<TExport>(TExport exportedInstance) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithExport<TExport>(TExport exportedInstance, string contractName = null, System.Collections.Generic.IDictionary<string, object> metadata = null) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithPart(System.Type partType) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithPart(System.Type partType, System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithParts(System.Collections.Generic.IEnumerable<System.Type> partTypes) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithParts(System.Collections.Generic.IEnumerable<System.Type> partTypes, System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithParts(params System.Type[] partTypes) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithPart<TPart>() { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithPart<TPart>(System.Composition.Convention.AttributedModelProvider conventions) { throw null; }
        public System.Composition.Hosting.ContainerConfiguration WithProvider(System.Composition.Hosting.Core.ExportDescriptorProvider exportDescriptorProvider) { throw null; }
    }
}
