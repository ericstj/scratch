// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Runtime.Serialization
{
    public abstract partial class DataContractResolver
    {
        protected DataContractResolver() { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract System.Type? ResolveName(string typeName, string? typeNamespace, System.Type? declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract bool TryResolveType(System.Type type, System.Type? declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString? typeName, out System.Xml.XmlDictionaryString? typeNamespace);
    }
    public sealed partial class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer
    {
        public DataContractSerializer(System.Type type) { }
        public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        public DataContractSerializer(System.Type type, System.Runtime.Serialization.DataContractSerializerSettings? settings) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        public System.Runtime.Serialization.DataContractResolver? DataContractResolver { get { throw null; } }
        public bool IgnoreExtensionDataObject { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public bool PreserveObjectReferences { get { throw null; } }
        public bool SerializeReadOnlyTypes { get { throw null; } }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public object? ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver? dataContractResolver) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteEndObject(System.Xml.XmlWriter writer) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public void WriteObject(System.Xml.XmlDictionaryWriter writer, object? graph, System.Runtime.Serialization.DataContractResolver? dataContractResolver) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObject(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObjectContent(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteStartObject(System.Xml.XmlWriter writer, object? graph) { }
    }
    public static partial class DataContractSerializerExtensions
    {
        public static System.Runtime.Serialization.ISerializationSurrogateProvider? GetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer) { throw null; }
        public static void SetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.ISerializationSurrogateProvider? provider) { }
    }
    public partial class DataContractSerializerSettings
    {
        public DataContractSerializerSettings() { }
        public System.Runtime.Serialization.DataContractResolver? DataContractResolver { get { throw null; } set { } }
        public bool IgnoreExtensionDataObject { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.Type>? KnownTypes { get { throw null; } set { } }
        public int MaxItemsInObjectGraph { get { throw null; } set { } }
        public bool PreserveObjectReferences { get { throw null; } set { } }
        public System.Xml.XmlDictionaryString? RootName { get { throw null; } set { } }
        public System.Xml.XmlDictionaryString? RootNamespace { get { throw null; } set { } }
        public bool SerializeReadOnlyTypes { get { throw null; } set { } }
    }
    public partial class DateTimeFormat
    {
        public DateTimeFormat(string formatString) { }
        public DateTimeFormat(string formatString, System.IFormatProvider formatProvider) { }
        public System.Globalization.DateTimeStyles DateTimeStyles { get { throw null; } set { } }
        public System.IFormatProvider FormatProvider { get { throw null; } }
        public string FormatString { get { throw null; } }
    }
    public enum EmitTypeInformation
    {
        AsNeeded = 0,
        Always = 1,
        Never = 2,
    }
    public partial class ExportOptions
    {
        public ExportOptions() { }
        public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { throw null; } }
    }
    public sealed partial class ExtensionDataObject
    {
        internal ExtensionDataObject() { }
    }
    public partial interface IExtensibleDataObject
    {
        System.Runtime.Serialization.ExtensionDataObject? ExtensionData { get; set; }
    }
    public static partial class JsonFormatGeneratorStatics
    {
        public static System.Reflection.MethodInfo BoxPointer { get { throw null; } }
        public static System.Reflection.PropertyInfo CollectionItemNameProperty { get { throw null; } }
        public static System.Reflection.ConstructorInfo ExtensionDataObjectCtor { get { throw null; } }
        public static System.Reflection.PropertyInfo ExtensionDataProperty { get { throw null; } }
        public static System.Reflection.MethodInfo GetCurrentMethod { get { throw null; } }
        public static System.Reflection.MethodInfo GetItemContractMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo GetJsonDataContractMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo GetJsonMemberIndexMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo GetJsonMemberNameMethod { get { throw null; } }
        public static System.Reflection.MethodInfo GetRevisedItemContractMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo GetUninitializedObjectMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo IsStartElementMethod0 { get { throw null; } }
        public static System.Reflection.MethodInfo IsStartElementMethod2 { get { throw null; } }
        public static System.Reflection.PropertyInfo LocalNameProperty { get { throw null; } }
        public static System.Reflection.MethodInfo MoveNextMethod { get { throw null; } }
        public static System.Reflection.MethodInfo MoveToContentMethod { get { throw null; } }
        public static System.Reflection.PropertyInfo NamespaceProperty { get { throw null; } }
        public static System.Reflection.PropertyInfo NodeTypeProperty { get { throw null; } }
        public static System.Reflection.MethodInfo OnDeserializationMethod { get { throw null; } }
        public static System.Reflection.MethodInfo ParseEnumMethod { get { throw null; } }
        public static System.Reflection.MethodInfo ReadJsonValueMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.ConstructorInfo SerializationExceptionCtor { get { throw null; } }
        public static System.Type[] SerInfoCtorArgs { get { throw null; } }
        public static System.Reflection.MethodInfo ThrowDuplicateMemberExceptionMethod { get { throw null; } }
        public static System.Reflection.MethodInfo ThrowMissingRequiredMembersMethod { get { throw null; } }
        public static System.Reflection.PropertyInfo TypeHandleProperty { get { throw null; } }
        public static System.Reflection.MethodInfo UnboxPointer { get { throw null; } }
        public static System.Reflection.PropertyInfo UseSimpleDictionaryFormatReadProperty { get { throw null; } }
        public static System.Reflection.PropertyInfo UseSimpleDictionaryFormatWriteProperty { get { throw null; } }
        public static System.Reflection.MethodInfo WriteAttributeStringMethod { get { throw null; } }
        public static System.Reflection.MethodInfo WriteEndElementMethod { get { throw null; } }
        public static System.Reflection.MethodInfo WriteJsonISerializableMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo WriteJsonNameWithMappingMethod { get { throw null; } }
        public static System.Reflection.MethodInfo WriteJsonValueMethod { [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")] get { throw null; } }
        public static System.Reflection.MethodInfo WriteStartElementMethod { get { throw null; } }
        public static System.Reflection.MethodInfo WriteStartElementStringMethod { get { throw null; } }
    }
    public abstract partial class XmlObjectSerializer
    {
        protected XmlObjectSerializer() { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract bool IsStartObject(System.Xml.XmlDictionaryReader reader);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual object? ReadObject(System.IO.Stream stream) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual object? ReadObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract object? ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual object? ReadObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual object? ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteEndObject(System.Xml.XmlWriter writer) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteObject(System.IO.Stream stream, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteObject(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteObject(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object? graph);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteObjectContent(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public abstract void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object? graph);
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public virtual void WriteStartObject(System.Xml.XmlWriter writer, object? graph) { }
    }
    public static partial class XmlSerializableServices
    {
        public static void AddDefaultSchema(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeQName) { }
        public static System.Xml.XmlNode[] ReadNodes(System.Xml.XmlReader xmlReader) { throw null; }
        public static void WriteNodes(System.Xml.XmlWriter xmlWriter, System.Xml.XmlNode?[]? nodes) { }
    }
    public static partial class XPathQueryGenerator
    {
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public static string CreateFromDataContractSerializer(System.Type type, System.Reflection.MemberInfo[] pathToMember, System.Text.StringBuilder? rootElementXpath, out System.Xml.XmlNamespaceManager namespaces) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public static string CreateFromDataContractSerializer(System.Type type, System.Reflection.MemberInfo[] pathToMember, out System.Xml.XmlNamespaceManager namespaces) { throw null; }
    }
    public partial class XsdDataContractExporter
    {
        public XsdDataContractExporter() { }
        public XsdDataContractExporter(System.Xml.Schema.XmlSchemaSet? schemas) { }
        public System.Runtime.Serialization.ExportOptions? Options { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSet Schemas { get { throw null; } }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public bool CanExport(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public bool CanExport(System.Collections.Generic.ICollection<System.Type> types) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public bool CanExport(System.Type type) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public void Export(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public void Export(System.Collections.Generic.ICollection<System.Type> types) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public void Export(System.Type type) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public System.Xml.XmlQualifiedName? GetRootElementName(System.Type type) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public System.Xml.Schema.XmlSchemaType? GetSchemaType(System.Type type) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public System.Xml.XmlQualifiedName GetSchemaTypeName(System.Type type) { throw null; }
    }
}
namespace System.Runtime.Serialization.Json
{
    public sealed partial class DataContractJsonSerializer : System.Runtime.Serialization.XmlObjectSerializer
    {
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, System.Runtime.Serialization.Json.DataContractJsonSerializerSettings? settings) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, string? rootName) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, string? rootName, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString? rootName) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString? rootName, System.Collections.Generic.IEnumerable<System.Type>? knownTypes) { }
        public System.Runtime.Serialization.DateTimeFormat? DateTimeFormat { get { throw null; } }
        public System.Runtime.Serialization.EmitTypeInformation EmitTypeInformation { get { throw null; } }
        public bool IgnoreExtensionDataObject { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public bool SerializeReadOnlyTypes { get { throw null; } }
        public bool UseSimpleDictionaryFormat { get { throw null; } }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.IO.Stream stream) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlReader reader) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override object? ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteEndObject(System.Xml.XmlWriter writer) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObject(System.IO.Stream stream, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObject(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObject(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteObjectContent(System.Xml.XmlWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object? graph) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Data Contract Serialization and Deserialization might require types that cannot be statically analyzed. Make sure all of the required types are preserved.")]
        public override void WriteStartObject(System.Xml.XmlWriter writer, object? graph) { }
    }
    public partial class DataContractJsonSerializerSettings
    {
        public DataContractJsonSerializerSettings() { }
        public System.Runtime.Serialization.DateTimeFormat? DateTimeFormat { get { throw null; } set { } }
        public System.Runtime.Serialization.EmitTypeInformation EmitTypeInformation { get { throw null; } set { } }
        public bool IgnoreExtensionDataObject { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.Type>? KnownTypes { get { throw null; } set { } }
        public int MaxItemsInObjectGraph { get { throw null; } set { } }
        public string? RootName { get { throw null; } set { } }
        public bool SerializeReadOnlyTypes { get { throw null; } set { } }
        public bool UseSimpleDictionaryFormat { get { throw null; } set { } }
    }
    public partial interface IXmlJsonReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose);
    }
    public partial interface IXmlJsonWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
    }
    public static partial class JsonReaderWriterFactory
    {
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent, string? indentChars) { throw null; }
    }
}
namespace System.Xml
{
    public partial interface IFragmentCapableXmlDictionaryWriter
    {
        bool CanFragment { get; }
        void EndFragment();
        void StartFragment(System.IO.Stream stream, bool generateSelfContainedTextFragment);
        void WriteFragment(byte[] buffer, int offset, int count);
    }
    public partial interface IStreamProvider
    {
        System.IO.Stream GetStream();
        void ReleaseStream(System.IO.Stream stream);
    }
    public partial interface IXmlBinaryReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session, System.Xml.OnXmlDictionaryReaderClose? onClose);
        void SetInput(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session, System.Xml.OnXmlDictionaryReaderClose? onClose);
    }
    public partial interface IXmlBinaryWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlBinaryWriterSession? session, bool ownsStream);
    }
    public partial interface IXmlDictionary
    {
        bool TryLookup(int key, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result);
        bool TryLookup(string value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result);
        bool TryLookup(System.Xml.XmlDictionaryString value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result);
    }
    public partial interface IXmlTextReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose);
    }
    public partial interface IXmlTextWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
    }
    public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);
    public partial class UniqueId
    {
        public UniqueId() { }
        public UniqueId(byte[] guid) { }
        public UniqueId(byte[] guid, int offset) { }
        public UniqueId(char[] chars, int offset, int count) { }
        public UniqueId(System.Guid guid) { }
        public UniqueId(string value) { }
        public int CharArrayLength { get { throw null; } }
        public bool IsGuid { get { throw null; } }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.UniqueId? id1, System.Xml.UniqueId? id2) { throw null; }
        public static bool operator !=(System.Xml.UniqueId? id1, System.Xml.UniqueId? id2) { throw null; }
        public int ToCharArray(char[] chars, int offset) { throw null; }
        public override string ToString() { throw null; }
        public bool TryGetGuid(byte[] buffer, int offset) { throw null; }
        public bool TryGetGuid(out System.Guid guid) { throw null; }
    }
    public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary
    {
        public XmlBinaryReaderSession() { }
        public System.Xml.XmlDictionaryString Add(int id, string value) { throw null; }
        public void Clear() { }
        public bool TryLookup(int key, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
        public bool TryLookup(string value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
        public bool TryLookup(System.Xml.XmlDictionaryString value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
    }
    public partial class XmlBinaryWriterSession
    {
        public XmlBinaryWriterSession() { }
        public void Reset() { }
        public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { throw null; }
    }
    public partial class XmlDictionary : System.Xml.IXmlDictionary
    {
        public XmlDictionary() { }
        public XmlDictionary(int capacity) { }
        public static System.Xml.IXmlDictionary Empty { get { throw null; } }
        public virtual System.Xml.XmlDictionaryString Add(string value) { throw null; }
        public virtual bool TryLookup(int key, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
        public virtual bool TryLookup(string value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
        public virtual bool TryLookup(System.Xml.XmlDictionaryString value, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? result) { throw null; }
    }
    public abstract partial class XmlDictionaryReader : System.Xml.XmlReader
    {
        protected XmlDictionaryReader() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { throw null; } }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession? session, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string? contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string? contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string? contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string? contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding? encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose? onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual string? GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void GetNonAtomizedNames(out string localName, out string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(string[] localNames, string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsLocalName(string localName) { throw null; }
        public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { throw null; }
        public virtual bool IsNamespaceUri(string namespaceUri) { throw null; }
        public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsStartArray([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Type? type) { throw null; }
        public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { throw null; }
        public virtual void MoveToStartElement() { }
        public virtual void MoveToStartElement(string name) { }
        public virtual void MoveToStartElement(string localName, string namespaceUri) { }
        public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual bool[] ReadBooleanArray(string localName, string namespaceUri) { throw null; }
        public virtual bool[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver? namespaceResolver) { throw null; }
        public virtual byte[] ReadContentAsBase64() { throw null; }
        public virtual byte[] ReadContentAsBinHex() { throw null; }
        protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { throw null; }
        public virtual int ReadContentAsChars(char[] chars, int offset, int count) { throw null; }
        public override decimal ReadContentAsDecimal() { throw null; }
        public override float ReadContentAsFloat() { throw null; }
        public virtual System.Guid ReadContentAsGuid() { throw null; }
        public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { throw null; }
        public override string ReadContentAsString() { throw null; }
        protected string ReadContentAsString(int maxStringContentLength) { throw null; }
        public virtual string ReadContentAsString(string[] strings, out int index) { throw null; }
        public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { throw null; }
        public virtual System.TimeSpan ReadContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadContentAsUniqueId() { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(string localName, string namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual byte[] ReadElementContentAsBase64() { throw null; }
        public virtual byte[] ReadElementContentAsBinHex() { throw null; }
        public override bool ReadElementContentAsBoolean() { throw null; }
        public override System.DateTime ReadElementContentAsDateTime() { throw null; }
        public override decimal ReadElementContentAsDecimal() { throw null; }
        public override double ReadElementContentAsDouble() { throw null; }
        public override float ReadElementContentAsFloat() { throw null; }
        public virtual System.Guid ReadElementContentAsGuid() { throw null; }
        public override int ReadElementContentAsInt() { throw null; }
        public override long ReadElementContentAsLong() { throw null; }
        public override string ReadElementContentAsString() { throw null; }
        public virtual System.TimeSpan ReadElementContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { throw null; }
        public virtual void ReadFullStartElement() { }
        public virtual void ReadFullStartElement(string name) { }
        public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
        public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { throw null; }
        public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(string localName, string namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(string localName, string namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(string localName, string namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(string localName, string namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public override string ReadString() { throw null; }
        protected string ReadString(int maxStringContentLength) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count) { throw null; }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[]? inclusivePrefixes) { }
        public virtual bool TryGetArrayLength(out int count) { throw null; }
        public virtual bool TryGetBase64ContentLength(out int length) { throw null; }
        public virtual bool TryGetLocalNameAsDictionaryString([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? localName) { throw null; }
        public virtual bool TryGetNamespaceUriAsDictionaryString([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? namespaceUri) { throw null; }
        public virtual bool TryGetValueAsDictionaryString([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Xml.XmlDictionaryString? value) { throw null; }
    }
    public sealed partial class XmlDictionaryReaderQuotas
    {
        public XmlDictionaryReaderQuotas() { }
        public static System.Xml.XmlDictionaryReaderQuotas Max { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxArrayLength { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(4096)]
        public int MaxBytesPerRead { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(32)]
        public int MaxDepth { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxNameTableCharCount { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(8192)]
        public int MaxStringContentLength { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotaTypes ModifiedQuotas { get { throw null; } }
        public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas) { }
    }
    [System.FlagsAttribute]
    public enum XmlDictionaryReaderQuotaTypes
    {
        MaxDepth = 1,
        MaxStringContentLength = 2,
        MaxArrayLength = 4,
        MaxBytesPerRead = 8,
        MaxNameTableCharCount = 16,
    }
    public partial class XmlDictionaryString
    {
        public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
        public System.Xml.IXmlDictionary Dictionary { get { throw null; } }
        public static System.Xml.XmlDictionaryString Empty { get { throw null; } }
        public int Key { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter
    {
        protected XmlDictionaryWriter() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public override void Close() { }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlBinaryWriterSession? session) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary? dictionary, System.Xml.XmlBinaryWriterSession? session, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string? boundary, string? startUri, bool writeMessageHeaders, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
        protected override void Dispose(bool disposing) { }
        public virtual void EndCanonicalization() { }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[]? inclusivePrefixes) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, string localName, string? namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public void WriteAttributeString(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, string? value) { }
        public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, string? value) { }
        public override System.Threading.Tasks.Task WriteBase64Async(byte[] buffer, int index, int count) { throw null; }
        public void WriteElementString(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, string? value) { }
        public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri, string? value) { }
        public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
        public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri) { }
        public virtual void WriteStartAttribute(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri) { }
        public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri) { }
        public virtual void WriteStartElement(string? prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri) { }
        public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? namespaceUri) { }
        public virtual void WriteString(System.Xml.XmlDictionaryString? value) { }
        protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
        public virtual void WriteValue(System.Guid value) { }
        public virtual void WriteValue(System.TimeSpan value) { }
        public virtual void WriteValue(System.Xml.IStreamProvider value) { }
        public virtual void WriteValue(System.Xml.UniqueId value) { }
        public virtual void WriteValue(System.Xml.XmlDictionaryString? value) { }
        public virtual System.Threading.Tasks.Task WriteValueAsync(System.Xml.IStreamProvider value) { throw null; }
        public virtual void WriteXmlAttribute(string localName, string? value) { }
        public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString? value) { }
        public virtual void WriteXmlnsAttribute(string? prefix, string namespaceUri) { }
        public virtual void WriteXmlnsAttribute(string? prefix, System.Xml.XmlDictionaryString namespaceUri) { }
    }
}
