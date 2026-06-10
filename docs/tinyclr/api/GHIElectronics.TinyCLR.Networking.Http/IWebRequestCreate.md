---
title: "IWebRequestCreate Interface"
sidebar_label: "IWebRequestCreate"
---

# IWebRequestCreate Interface

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

The interface for creating `System.Net.WebRequest` class objects.

```csharp
public interface IWebRequestCreate
```

## Methods

### Create(Uri uri)

```csharp
WebRequest Create(Uri uri)
```

Creates an instance of a class derived from WebRequest .

| Parameter | Type | Description |
|---|---|---|
| `uri` | `Uri` | The URI for initialization of the class that is derived from WebRequest . |

**Returns** `WebRequest` — An instance of the class that is derived from WebRequest .
