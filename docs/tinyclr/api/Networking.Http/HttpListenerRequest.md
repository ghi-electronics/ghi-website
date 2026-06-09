---
title: "HttpListenerRequest Class"
sidebar_label: "HttpListenerRequest"
---

# HttpListenerRequest Class

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Describes an incoming HTTP request to an `System.Net.HttpListener` object.

```csharp
public class HttpListenerRequest
```

## Properties

### HttpMethod

```csharp
public string HttpMethod { get; }
```

Gets the HTTP method specified by the client.

### RawUrl

```csharp
public string RawUrl { get; }
```

Gets the URL information (without the host and port) requested by the client.

### AcceptTypes

```csharp
public string[] AcceptTypes { get; }
```

Gets the MIME types accepted by the client.

### ContentLength64

```csharp
public long ContentLength64 { get; }
```

Gets the length of the body data included in the request.

### ContentType

```csharp
public string ContentType { get; }
```

Gets the MIME type of the body data included in the request.

### Headers

```csharp
public WebHeaderCollection Headers { get; }
```

Gets the collection of header name/value pairs sent in the request.

### InputStream

```csharp
public Stream InputStream { get; }
```

Gets a stream that contains the body data sent by the client.

### IsAuthenticated

```csharp
public bool IsAuthenticated { get; }
```

Gets a Boolean value that indicates whether the client sending this request is authenticated.

### KeepAlive

```csharp
public bool KeepAlive { get; }
```

Gets a `System.Boolean` value that indicates whether the client requests a persistent connection.

### LocalEndPoint

```csharp
public IPEndPoint LocalEndPoint { get; }
```

Gets the server IP address and port number to which the request is directed. Not currently supported.

### ProtocolVersion

```csharp
public Version ProtocolVersion { get; }
```

Gets the HTTP version used by the requesting client.

### RemoteEndPoint

```csharp
public IPEndPoint RemoteEndPoint { get; }
```

Gets the client IP address and port number from which the request originated.

### Url

```csharp
public Uri Url { get; }
```

Gets the Uri object requested by the client. Built from the request's scheme + Host header + raw URL, matching .NET BCL's HttpListenerRequest.Url shape (absolute URI).

### UserAgent

```csharp
public string UserAgent { get; }
```

Gets the user agent presented by the client.

### UserHostAddress

```csharp
public string UserHostAddress { get; }
```

Gets the server IP address and port number to which the request is directed.

### UserHostName

```csharp
public string UserHostName { get; }
```

Gets the DNS name and, if provided, the port number specified by the client.

### Credentials

```csharp
public NetworkCredential Credentials { get; }
```

Return NetworkCredential if user have send user name and password.

### UserLanguages

```csharp
public string[] UserLanguages { get; }
```

Gets the natural languages that are preferred for the response.

## Methods

### Reset()

```csharp
public void Reset()
```

Sets the enumerator to its initial position, which is before the first element in the collection. _(inherited)_
