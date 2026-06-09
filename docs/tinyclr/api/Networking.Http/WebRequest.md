---
title: "WebRequest Class"
sidebar_label: "WebRequest"
---

# WebRequest Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

Makes a request to a Uniform Resource Identifier (URI). This is an abstract class.

```csharp
public abstract class WebRequest : MarshalByRefObject, IDisposable
```

## Constructors

### WebRequest()

```csharp
protected WebRequest()
```

Initializes a new instance of the `System.Net.WebRequest` class.

## Properties

### Method

```csharp
public virtual string Method { get; set; }
```

When overridden in a descendant class, gets or sets the protocol method to use in this request.

### RequestUri

```csharp
public virtual Uri RequestUri { get; }
```

When overridden in a descendant class, gets the URI of the Internet resource associated with the request.

### ConnectionGroupName

```csharp
public virtual string ConnectionGroupName { get; set; }
```

When overridden in a descendant class, gets or sets the name of the connection group for the request.

### Headers

```csharp
public virtual WebHeaderCollection Headers { get; set; }
```

When overridden in a descendant class, gets or sets the collection of header name/value pairs associated with the request.

### ContentLength

```csharp
public virtual long ContentLength { get; set; }
```

When overridden in a descendant class, gets or sets the content length of the request data being sent.

### ContentType

```csharp
public virtual string ContentType { get; set; }
```

When overridden in a descendant class, gets or sets the content type of the request data being sent.

### Timeout

```csharp
public virtual int Timeout { get; set; }
```

Gets or sets the length of time, in milliseconds, before the request times out.

### DefaultWebProxy

```csharp
public static IWebProxy DefaultWebProxy { get; set; }
```

Gets or sets the global HTTP proxy. The DefaultWebProxy property determines the default proxy that all WebRequest instances use if the request supports proxies and no proxy is set explicitly using the Proxy property. Proxies are currently supported by HttpWebRequest.

### Proxy

```csharp
public virtual IWebProxy Proxy { get; set; }
```

When overridden in a descendant class, gets or sets the network proxy to use to access this Internet resource.

## Methods

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

_No description available._

### Abort()

```csharp
public virtual void Abort()
```

When overridden in a descendant class, aborts the request.

### GetRequestStream()

```csharp
public virtual Stream GetRequestStream()
```

When overridden in a descendant class, returns a Stream for writing data to the Internet resource.

**Returns** `Stream` — A Stream for writing data to the Internet resource.

### GetResponse()

```csharp
public virtual WebResponse GetResponse()
```

When overridden in a descendant class, returns a response to an Internet request.

**Returns** `WebResponse` — A WebResponse containing the response to the Internet request.

### Create(string requestUriString)

```csharp
public static WebRequest Create(string requestUriString)
```

Initializes a new WebRequest instance for the specified URI scheme, such as http://, https://, or file://.

| Parameter | Type | Description |
|---|---|---|
| `requestUriString` | `string` | The URI that identifies the Internet resource. |

**Returns** `WebRequest`

### Create(Uri requestUri)

```csharp
public static WebRequest Create(Uri requestUri)
```

Creates a WebRequest .

| Parameter | Type | Description |
|---|---|---|
| `requestUri` | `Uri` | A `System.Uri` containing the URI of the requested resource. |

**Returns** `WebRequest`

### RegisterPrefix(string prefix, IWebRequestCreate creator)

```csharp
public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
```

Registers a WebRequest descendant for the specified URI.

| Parameter | Type | Description |
|---|---|---|
| `prefix` | `string` | The complete URI or URI prefix that the WebRequest descendant services. |
| `creator` | `IWebRequestCreate` | The create method that the WebRequest calls to create the WebRequest descendant. |

**Returns** `bool` — true .
