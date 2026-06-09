---
title: "IWebProxy Interface"
sidebar_label: "IWebProxy"
---

# IWebProxy Interface

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Provides the base interface for implementing proxy access for the `System.Net.WebRequest` class.

```csharp
public interface IWebProxy
```

## Methods

### GetProxy(Uri destination)

```csharp
Uri GetProxy(Uri destination)
```

Returns the URI of a proxy.

| Parameter | Type | Description |
|---|---|---|
| `destination` | `Uri` | The destination URI. |

**Returns** `Uri` — A Uri instance that contains the URI of the proxy used to contact `destination`.

### IsBypassed(Uri host)

```csharp
bool IsBypassed(Uri host)
```

Indicates whether the proxy should not be used for the specified host.

| Parameter | Type | Description |
|---|---|---|
| `host` | `Uri` | The host to check, to determine whether the proxy is needed to access it. |

**Returns** `bool` — Whether the proxy should not be used for the specified host.
