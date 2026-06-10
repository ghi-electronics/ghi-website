---
title: "WebUtility Class"
sidebar_label: "WebUtility"
---

# WebUtility Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

Provides methods for encoding and decoding URLs and HTML text.

```csharp
public static class WebUtility
```

## Methods

### UrlEncode(string value)

```csharp
public static string UrlEncode(string value)
```

URL-encodes the specified string.

**Returns** `string`

### UrlDecode(string encodedValue)

```csharp
public static string UrlDecode(string encodedValue)
```

Decodes a URL-encoded string.

**Returns** `string`

### HtmlEncode(string value)

```csharp
public static string HtmlEncode(string value)
```

HTML-encodes the specified string.

**Returns** `string`

### HtmlDecode(string value)

```csharp
public static string HtmlDecode(string value)
```

Decodes an HTML-encoded string.

**Returns** `string`
