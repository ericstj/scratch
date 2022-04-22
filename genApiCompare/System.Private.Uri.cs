// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System
{
    public partial class FileStyleUriParser : System.UriParser
    {
        public FileStyleUriParser() { }
    }
    public partial class FtpStyleUriParser : System.UriParser
    {
        public FtpStyleUriParser() { }
    }
    public partial class GenericUriParser : System.UriParser
    {
        public GenericUriParser(System.GenericUriParserOptions options) { }
    }
    [System.FlagsAttribute]
    public enum GenericUriParserOptions
    {
        Default = 0,
        GenericAuthority = 1,
        AllowEmptyAuthority = 2,
        NoUserInfo = 4,
        NoPort = 8,
        NoQuery = 16,
        NoFragment = 32,
        DontConvertPathBackslashes = 64,
        DontCompressPath = 128,
        DontUnescapePathDotsAndSlashes = 256,
        Idn = 512,
        IriParsing = 1024,
    }
    public partial class GopherStyleUriParser : System.UriParser
    {
        public GopherStyleUriParser() { }
    }
    public partial class HttpStyleUriParser : System.UriParser
    {
        public HttpStyleUriParser() { }
    }
    public partial class LdapStyleUriParser : System.UriParser
    {
        public LdapStyleUriParser() { }
    }
    public partial class NetPipeStyleUriParser : System.UriParser
    {
        public NetPipeStyleUriParser() { }
    }
    public partial class NetTcpStyleUriParser : System.UriParser
    {
        public NetTcpStyleUriParser() { }
    }
    public partial class NewsStyleUriParser : System.UriParser
    {
        public NewsStyleUriParser() { }
    }
    public partial class Uri : System.Runtime.Serialization.ISerializable
    {
        public static readonly string SchemeDelimiter;
        public static readonly string UriSchemeFile;
        public static readonly string UriSchemeFtp;
        public static readonly string UriSchemeFtps;
        public static readonly string UriSchemeGopher;
        public static readonly string UriSchemeHttp;
        public static readonly string UriSchemeHttps;
        public static readonly string UriSchemeMailto;
        public static readonly string UriSchemeNetPipe;
        public static readonly string UriSchemeNetTcp;
        public static readonly string UriSchemeNews;
        public static readonly string UriSchemeNntp;
        public static readonly string UriSchemeSftp;
        public static readonly string UriSchemeSsh;
        public static readonly string UriSchemeTelnet;
        public static readonly string UriSchemeWs;
        public static readonly string UriSchemeWss;
        protected Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public Uri([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri")] string uriString) { }
        [System.ObsoleteAttribute("This constructor has been deprecated; the dontEscape parameter is always false. Use Uri(string) instead.")]
        public Uri([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri")] string uriString, bool dontEscape) { }
        public Uri([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri")] string uriString, in System.UriCreationOptions creationOptions) { }
        public Uri([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri", new object[]{ "uriKind"})] string uriString, System.UriKind uriKind) { }
        public Uri(System.Uri baseUri, string? relativeUri) { }
        [System.ObsoleteAttribute("This constructor has been deprecated; the dontEscape parameter is always false. Use Uri(Uri, string) instead.")]
        public Uri(System.Uri baseUri, string? relativeUri, bool dontEscape) { }
        public Uri(System.Uri baseUri, System.Uri relativeUri) { }
        public string AbsolutePath { get { throw null; } }
        public string AbsoluteUri { get { throw null; } }
        public string Authority { get { throw null; } }
        public string DnsSafeHost { get { throw null; } }
        public string Fragment { get { throw null; } }
        public string Host { get { throw null; } }
        public System.UriHostNameType HostNameType { get { throw null; } }
        public string IdnHost { get { throw null; } }
        public bool IsAbsoluteUri { get { throw null; } }
        public bool IsDefaultPort { get { throw null; } }
        public bool IsFile { get { throw null; } }
        public bool IsLoopback { get { throw null; } }
        public bool IsUnc { get { throw null; } }
        public string LocalPath { get { throw null; } }
        public string OriginalString { get { throw null; } }
        public string PathAndQuery { get { throw null; } }
        public int Port { get { throw null; } }
        public string Query { get { throw null; } }
        public string Scheme { get { throw null; } }
        public string[] Segments { get { throw null; } }
        public bool UserEscaped { get { throw null; } }
        public string UserInfo { get { throw null; } }
        [System.ObsoleteAttribute("Uri.Canonicalize has been deprecated and is not supported.")]
        protected virtual void Canonicalize() { }
        public static System.UriHostNameType CheckHostName(string? name) { throw null; }
        public static bool CheckSchemeName([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] string? schemeName) { throw null; }
        [System.ObsoleteAttribute("Uri.CheckSecurity has been deprecated and is not supported.")]
        protected virtual void CheckSecurity() { }
        public static int Compare(System.Uri? uri1, System.Uri? uri2, System.UriComponents partsToCompare, System.UriFormat compareFormat, System.StringComparison comparisonType) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? comparand) { throw null; }
        [System.ObsoleteAttribute("Uri.Escape has been deprecated and is not supported.")]
        protected virtual void Escape() { }
        public static string EscapeDataString(string stringToEscape) { throw null; }
        [System.ObsoleteAttribute("Uri.EscapeString has been deprecated. Use GetComponents() or Uri.EscapeDataString to escape a Uri component or a string.")]
        protected static string EscapeString(string? str) { throw null; }
        [System.ObsoleteAttribute("Uri.EscapeUriString can corrupt the Uri string in some cases. Consider using Uri.EscapeDataString for query string components instead.", DiagnosticId="SYSLIB0013", UrlFormat="https://aka.ms/dotnet-warnings/{0}")]
        public static string EscapeUriString(string stringToEscape) { throw null; }
        public static int FromHex(char digit) { throw null; }
        public string GetComponents(System.UriComponents components, System.UriFormat format) { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetLeftPart(System.UriPartial part) { throw null; }
        protected void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public static string HexEscape(char character) { throw null; }
        public static char HexUnescape(string pattern, ref int index) { throw null; }
        [System.ObsoleteAttribute("Uri.IsBadFileSystemCharacter has been deprecated and is not supported.")]
        protected virtual bool IsBadFileSystemCharacter(char character) { throw null; }
        public bool IsBaseOf(System.Uri uri) { throw null; }
        [System.ObsoleteAttribute("Uri.IsExcludedCharacter has been deprecated and is not supported.")]
        protected static bool IsExcludedCharacter(char character) { throw null; }
        public static bool IsHexDigit(char character) { throw null; }
        public static bool IsHexEncoding(string pattern, int index) { throw null; }
        [System.ObsoleteAttribute("Uri.IsReservedCharacter has been deprecated and is not supported.")]
        protected virtual bool IsReservedCharacter(char character) { throw null; }
        public bool IsWellFormedOriginalString() { throw null; }
        public static bool IsWellFormedUriString([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true), System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri", new object[]{ "uriKind"})] string? uriString, System.UriKind uriKind) { throw null; }
        [System.ObsoleteAttribute("Uri.MakeRelative has been deprecated. Use MakeRelativeUri(Uri uri) instead.")]
        public string MakeRelative(System.Uri toUri) { throw null; }
        public System.Uri MakeRelativeUri(System.Uri uri) { throw null; }
        public static bool operator ==(System.Uri? uri1, System.Uri? uri2) { throw null; }
        public static bool operator !=(System.Uri? uri1, System.Uri? uri2) { throw null; }
        [System.ObsoleteAttribute("Uri.Parse has been deprecated and is not supported.")]
        protected virtual void Parse() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ToString() { throw null; }
        public static bool TryCreate([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true), System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri")] string? uriString, in System.UriCreationOptions creationOptions, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Uri? result) { throw null; }
        public static bool TryCreate([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true), System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri", new object[]{ "uriKind"})] string? uriString, System.UriKind uriKind, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Uri? result) { throw null; }
        public static bool TryCreate(System.Uri? baseUri, string? relativeUri, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Uri? result) { throw null; }
        public static bool TryCreate(System.Uri? baseUri, System.Uri? relativeUri, [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out System.Uri? result) { throw null; }
        [System.ObsoleteAttribute("Uri.Unescape has been deprecated. Use GetComponents() or Uri.UnescapeDataString() to unescape a Uri component or a string.")]
        protected virtual string Unescape(string path) { throw null; }
        public static string UnescapeDataString(string stringToUnescape) { throw null; }
    }
    public partial class UriBuilder
    {
        public UriBuilder() { }
        public UriBuilder([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("Uri")] string uri) { }
        public UriBuilder(string? schemeName, string? hostName) { }
        public UriBuilder(string? scheme, string? host, int portNumber) { }
        public UriBuilder(string? scheme, string? host, int port, string? pathValue) { }
        public UriBuilder(string? scheme, string? host, int port, string? path, string? extraValue) { }
        public UriBuilder(System.Uri uri) { }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Fragment { get { throw null; } set { } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Host { get { throw null; } set { } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Password { get { throw null; } set { } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Path { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Query { get { throw null; } set { } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string Scheme { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } }
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute]
        public string UserName { get { throw null; } set { } }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? rparam) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum UriComponents
    {
        SerializationInfoString = -2147483648,
        Scheme = 1,
        UserInfo = 2,
        Host = 4,
        Port = 8,
        SchemeAndServer = 13,
        Path = 16,
        Query = 32,
        PathAndQuery = 48,
        HttpRequestUrl = 61,
        Fragment = 64,
        AbsoluteUri = 127,
        StrongPort = 128,
        HostAndPort = 132,
        StrongAuthority = 134,
        NormalizedHost = 256,
        KeepDelimiter = 1073741824,
    }
    public partial struct UriCreationOptions
    {
        private int _dummyPrimitive;
        public bool DangerousDisablePathAndQueryCanonicalization { readonly get { throw null; } set { } }
    }
    public enum UriFormat
    {
        UriEscaped = 1,
        Unescaped = 2,
        SafeUnescaped = 3,
    }
    public partial class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        public UriFormatException() { }
        protected UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public UriFormatException(string? textString) { }
        public UriFormatException(string? textString, System.Exception? e) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum UriHostNameType
    {
        Unknown = 0,
        Basic = 1,
        Dns = 2,
        IPv4 = 3,
        IPv6 = 4,
    }
    public enum UriKind
    {
        RelativeOrAbsolute = 0,
        Absolute = 1,
        Relative = 2,
    }
    public abstract partial class UriParser
    {
        protected UriParser() { }
        protected virtual string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { throw null; }
        protected virtual void InitializeAndValidate(System.Uri uri, out System.UriFormatException? parsingError) { throw null; }
        protected virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { throw null; }
        public static bool IsKnownScheme(string schemeName) { throw null; }
        protected virtual bool IsWellFormedOriginalString(System.Uri uri) { throw null; }
        protected virtual System.UriParser OnNewUri() { throw null; }
        protected virtual void OnRegister(string schemeName, int defaultPort) { }
        public static void Register(System.UriParser uriParser, string schemeName, int defaultPort) { }
        protected virtual string? Resolve(System.Uri baseUri, System.Uri? relativeUri, out System.UriFormatException? parsingError) { throw null; }
    }
    public enum UriPartial
    {
        Scheme = 0,
        Authority = 1,
        Path = 2,
        Query = 3,
    }
}
