---
title: "Uri Class"
sidebar_label: "Uri"
---

# Uri Class

**Namespace:** `System` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.

```csharp
public class Uri
```

## Constructors

### Uri(string uriString)

```csharp
public Uri(string uriString)
```

Initializes a new instance of the `System.Uri` class with the specified URI.

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | A URI. |

### Uri(string uriString, UriKind kind)

```csharp
public Uri(string uriString, UriKind kind)
```

Constructs Uri from string and enumeration that tell what is the type of Uri.

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | String to construct Uri from |
| `kind` | `UriKind` | Type of Uri to construct |

## Properties

### HostNameType

```csharp
public UriHostNameType HostNameType { get; }
```

Gets the type of the host name specified in the URI.

### Port

```csharp
public int Port { get; }
```

Gets the port number of this URI.

### IsAbsoluteUri

```csharp
public bool IsAbsoluteUri { get; }
```

Gets whether the `System.Uri` instance is absolute.

### IsUnc

```csharp
public bool IsUnc { get; }
```

Gets whether the specified `System.Uri` is a universal naming convention (UNC) path.

### AbsolutePath

```csharp
public string AbsolutePath { get; }
```

Gets a local operating-system representation of a file name.

### PathAndQuery

```csharp
public string PathAndQuery { get; }
```

The `AbsolutePath` and `Query` properties joined by '?'. Matches the BCL property of the same name. Meant for callers that need the path-plus-query part to send on the wire (HTTP request line, etc.).

### Query

```csharp
public string Query { get; }
```

Gets any query information included in the specified URI, including the leading '?' character. Returns an empty string if no query is present.

### Fragment

```csharp
public string Fragment { get; }
```

Gets any URI fragment, including the leading '#' character. Returns an empty string if no fragment is present.

### OriginalString

```csharp
public string OriginalString { get; }
```

Gets the original URI string that was passed to the Uri constructor.

### AbsoluteUri

```csharp
public string AbsoluteUri { get; }
```

Gets a string containing the absolute uri or entire uri of this instance.

### Scheme

```csharp
public string Scheme { get; }
```

Gets the scheme name for this URI.

### Host

```csharp
public string Host { get; }
```

Gets the host component of this instance.

### IsLoopback

```csharp
public bool IsLoopback { get; }
```

Gets whether the specified `System.Uri` refers to the local host.

## Methods

### ConstructAbsoluteUri(string uriString)

```csharp
protected void ConstructAbsoluteUri(string uriString)
```

Constructs an absolute Uri from a URI string.

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | A URI. |

### ValidateUriPart(string uriString, int startIndex)

```csharp
protected void ValidateUriPart(string uriString, int startIndex)
```

Validates that part of Uri after sheme is valid for unknown Uri scheme

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | Uri string |
| `startIndex` | `int` | Index in the string where Uri part ( after scheme ) starts |

### ParseUriString(string uriString)

```csharp
protected void ParseUriString(string uriString)
```

Internal method parses a URI string into Uri variables

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | A Uri. |

### ParseSchemeSpecificPart(string sUri, int iStart)

```csharp
protected bool ParseSchemeSpecificPart(string sUri, int iStart)
```

Parse Scheme-specific part of uri for host, port and absolute path Briefed syntax abstracted from .NET FX: Group 1 - http, https, ftp, file, gopher, nntp, telnet, ldap, net.tcp and net.pipe Must be rooted. The 1st segment is authority. Empty path should be replace as '/' Group 2 - file Reminder: Treat all '\' as '/' If it starts with only one '/', host should be empty Otherwise, all leading '/' should be ignored before searching for 1st segment. The 1st segment is host Group 3 - news and uuid Authority always be empty. Everything goes to path. Group 4 - mailto and all other shemes The 1st segment is authority iff it was not rooted. Group 5 - all other schemes The 1st segment is authority iff it was rooted. Empty path should be replace as '/'

| Parameter | Type | Description |
|---|---|---|
| `sUri` | `string` |  |
| `iStart` | `int` |  |

**Returns** `bool`

### Split(string sUri, int iStart, out string sAuthority, out string sPath, bool bReplaceEmptyPath)

```csharp
protected void Split(string sUri, int iStart, out string sAuthority, out string sPath, bool bReplaceEmptyPath)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `sUri` | `string` |  |
| `iStart` | `int` |  |
| `sAuthority` | `out string` |  |
| `sPath` | `out string` |  |
| `bReplaceEmptyPath` | `bool` |  |

### IsIPv4(String host)

```csharp
protected bool IsIPv4(String host)
```

Returns if host name is IP adress 4 bytes. Like 192.1.1.1

| Parameter | Type | Description |
|---|---|---|
| `host` | `String` | string with host name |

**Returns** `bool` — True if name is string with IPv4 address

### IsIPv6(string host)

```csharp
protected bool IsIPv6(string host)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `host` | `string` |  |

**Returns** `bool`

### ValidateUrn(string uri)

```csharp
protected void ValidateUrn(string uri)
```

Parses urn string into Uri variables. Parsing is restricted to basic urn:NamespaceID, urn:uuid formats only.

| Parameter | Type | Description |
|---|---|---|
| `uri` | `string` | A Uri. |

### ValidateRelativePath(string uri)

```csharp
protected void ValidateRelativePath(string uri)
```

Parses relative Uri into variables.

| Parameter | Type | Description |
|---|---|---|
| `uri` | `string` | A Uri. |

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### Equals(object o)

```csharp
public override bool Equals(object o)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `o` | `object` |  |

**Returns** `bool`

### ==(Uri lhs, Uri rhs)

```csharp
public static bool operator ==(Uri lhs, Uri rhs)
```

Equals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `lhs` | `Uri` |  |
| `rhs` | `Uri` |  |

**Returns** `bool operator`

### !=(Uri lhs, Uri rhs)

```csharp
public static bool operator !=(Uri lhs, Uri rhs)
```

NotEquals operator overload _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `lhs` | `Uri` |  |
| `rhs` | `Uri` |  |

**Returns** `bool operator`

### IsAlpha(char testChar)

```csharp
protected bool IsAlpha(char testChar)
```

Checks to see if the character value is an alpha character.

| Parameter | Type | Description |
|---|---|---|
| `testChar` | `char` | The character to evaluate. |

**Returns** `bool` — true if the character is Alpha; otherwise, false .

### IsAlphaNumeric(char testChar)

```csharp
protected bool IsAlphaNumeric(char testChar)
```

Checks to see if the character value is an alpha or numeric.

| Parameter | Type | Description |
|---|---|---|
| `testChar` | `char` | The character to evaluate. |

**Returns** `bool` — true if the character is Alpha or numeric; otherwise, false .

### IsHex(char testChar)

```csharp
protected bool IsHex(char testChar)
```

Checks to see if the character value is Hex.

| Parameter | Type | Description |
|---|---|---|
| `testChar` | `char` | The character to evaluate. |

**Returns** `bool` — true if the character is a valid Hex character; otherwise, false .

### CheckHostName(string name)

```csharp
public static UriHostNameType CheckHostName(string name)
```

Determines whether the specified host name is a valid DNS name, an IPv4 address, an IPv6 address, or otherwise unknown. Matches .NET BCL shape.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `UriHostNameType`

### IsWellFormedUriString(string uriString, UriKind uriKind)

```csharp
public static bool IsWellFormedUriString(string uriString, UriKind uriKind)
```

Indicates whether the string is well-formed by attempting to construct a URI with the string.

| Parameter | Type | Description |
|---|---|---|
| `uriString` | `string` | A URI. |
| `uriKind` | `UriKind` | The type of the URI in `uriString`. |

**Returns** `bool` — true if the string was well-formed in accordance with RFC 2396 and RFC 2732; otherwise false .

## Fields

### UnknownPort

```csharp
protected const int UnknownPort
```

Constant to indicate that port for this protocol is unknown

### m_hostNameType

```csharp
protected UriHostNameType m_hostNameType
```

Type of the host.

### m_port

```csharp
protected int m_port
```

Member variable that keeps port used by this uri.

### m_Flags

```csharp
protected int m_Flags
```

Member variable that keeps internal flags/

### m_AbsolutePath

```csharp
protected string m_AbsolutePath
```

Member varialbe that keeps absolute path.

### m_OriginalUriString

```csharp
protected string m_OriginalUriString
```

Member varialbe that keeps original string passed to Uri constructor.

### m_scheme

```csharp
protected string m_scheme
```

Member varialbe that keeps scheme of Uri.

### m_host

```csharp
protected string m_host
```

Member varialbe that keeps host name ( http and https ).

### m_isAbsoluteUri

```csharp
protected bool m_isAbsoluteUri
```

Member varialbe that keeps boolean if Uri is absolute.

### m_isUnc

```csharp
protected bool m_isUnc
```

Member varialbe that tells if path is UNC ( Universal Naming Convention ) In this class it is always false, but can be changed in derived classes.

### m_absoluteUri

```csharp
protected string m_absoluteUri
```

Member variable that keeps absolute uri (generated in method ParseUriString)
