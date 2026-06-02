---
title: "WebProxy Class"
sidebar_label: "WebProxy"
---

# WebProxy Class

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Contains HTTP proxy settings for the `System.Net.WebRequest` class.

```csharp
public class WebProxy : IWebProxy
```

## Constructors

### WebProxy()

```csharp
public WebProxy() : this((Uri)null, false)
```

Initializes an empty instance of the WebProxy class.

### WebProxy(Uri Address)

```csharp
public WebProxy(Uri Address) : this(Address, false)
```

Initializes a new instance of the WebProxy class from the specified `System.Uri` instance.

| Parameter | Type | Description |
|---|---|---|
| `Address` | `Uri` | A Uri instance that contains the address of the proxy server. |

### WebProxy(Uri Address, bool BypassOnLocal)

```csharp
public WebProxy(Uri Address, bool BypassOnLocal)
```

Initializes a new instance of the WebProxy class with the specified `System.Uri` instance and bypass setting.

| Parameter | Type | Description |
|---|---|---|
| `Address` | `Uri` | A Uri instance that contains the address of the proxy server. |
| `BypassOnLocal` | `bool` | Indicates whether to bypass the WebProxy on local network addresses. |

### WebProxy(string Host, int Port)

```csharp
public WebProxy(string Host, int Port) : this(new Uri( + Host + + Port.ToString()), false)
```

Initializes a new instance of the WebProxy class with the specified host and port number.

| Parameter | Type | Description |
|---|---|---|
| `Host` | `string` | The name of the proxy host, such as: contoso |
| `Port` | `int` | The port number on the host to use, such as: 80 |

### WebProxy(string Address)

```csharp
public WebProxy(string Address) : this(CreateProxyUri(Address), false)
```

Initializes a new instance of the WebProxy class with the specified URI.

| Parameter | Type | Description |
|---|---|---|
| `Address` | `string` | The URI address of the proxy server. |

### WebProxy(string Address, bool BypassOnLocal)

```csharp
public WebProxy(string Address, bool BypassOnLocal) : this(CreateProxyUri(Address), BypassOnLocal)
```

Initializes a new instance of the WebProxy class with the specified URI and bypass setting.

| Parameter | Type | Description |
|---|---|---|
| `Address` | `string` | The URI of the proxy server. |
| `BypassOnLocal` | `bool` | Indicates whether to bypass the proxy when accessing local addresses. |

## Properties

### Address

```csharp
public Uri Address { get; set; }
```

Gets or sets the address of the proxy server.

### BypassProxyOnLocal

```csharp
public bool BypassProxyOnLocal { get; set; }
```

Gets or sets whether to bypass the proxy server for local addresses.

## Methods

### GetProxy(Uri destination)

```csharp
public Uri GetProxy(Uri destination)
```

Returns the proxied URI for a request.

| Parameter | Type | Description |
|---|---|---|
| `destination` | `Uri` | The Uri instance of the requested Internet resource. |

**Returns** `Uri` — The Uri instance of the Internet resource, if the resource is on the bypass list; otherwise, the Uri instance of the proxy.

### IsBypassed(Uri host)

```csharp
public bool IsBypassed(Uri host)
```

Indicates whether to use the proxy server for the specified host.

| Parameter | Type | Description |
|---|---|---|
| `host` | `Uri` | The Uri instance of the host to check for proxy use. |

**Returns** `bool` — true if the proxy server should not be used for the host; otherwise, false .
