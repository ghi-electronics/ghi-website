---
title: "HttpListenerContext Class"
sidebar_label: "HttpListenerContext"
---

# HttpListenerContext Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

Provides access to the request and response objects used by the HttpListener class. This class cannot be inherited.

```csharp
public class HttpListenerContext
```

## Properties

### Request

```csharp
public HttpListenerRequest Request { get; }
```

Gets the HttpListenerRequest that represents a client's request for a resource.

### Response

```csharp
public HttpListenerResponse Response { get; }
```

Gets the HttpListenerResponse object that will be sent to the client in response to the client's request.

## Methods

### Reset()

```csharp
public void Reset()
```

_No description available._
