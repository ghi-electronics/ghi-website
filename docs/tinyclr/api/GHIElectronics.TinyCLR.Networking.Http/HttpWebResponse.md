---
title: "HttpWebResponse Class"
sidebar_label: "HttpWebResponse"
---

# HttpWebResponse Class

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Handles retrieval of HTTP Response headers, and handles data reads.

```csharp
public class HttpWebResponse : WebResponse
```

## Properties

### Headers

```csharp
public override WebHeaderCollection Headers { get; }
```

Retrieves a response header object.

### ContentLength

```csharp
public override long ContentLength { get; }
```

Gets the length of the content returned by the request.

### ContentEncoding

```csharp
public String ContentEncoding { get; }
```

Gets the method that is used to encode the body of the response.

### ContentType

```csharp
public override string ContentType { get; }
```

Gets the content type of the response.

### Server

```csharp
public string Server { get; }
```

Gets the name of the server that sent the response.

### LastModified

```csharp
public DateTime LastModified { get; }
```

Gets the value of the Last-Modified header, which indicates the last time the document was modified.

### StatusCode

```csharp
public HttpStatusCode StatusCode { get; }
```

Gets the status of the HTTP response, as a number.

### StatusDescription

```csharp
public string StatusDescription { get; }
```

Gets the status description returned with the response.

### ProtocolVersion

```csharp
public Version ProtocolVersion { get; set; }
```

Gets the version of the HTTP protocol that is used in the response.

### ResponseUri

```csharp
public override Uri ResponseUri { get; }
```

Gets the final Response URI, that includes any changes that may have transpired from the orginal Request.

### Method

```csharp
public string Method { get; }
```

Gets the method that is used to return the response.

## Methods

### GetResponseStream()

```csharp
public override Stream GetResponseStream()
```

Gets the stream used for reading the body of the response from the server.

**Returns** `Stream` — A network stream to read body of the message.

### GetResponseHeader(string headerName)

```csharp
public string GetResponseHeader(string headerName)
```

Gets the contents of a header that was returned with the response.

| Parameter | Type | Description |
|---|---|---|
| `headerName` | `string` | HTTP header to search for matching header on. |

**Returns** `string` — The matched entry, if found.

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Closes a response stream, if present.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |
