---
title: "HttpContinueDelegate Delegate"
sidebar_label: "HttpContinueDelegate"
---

# HttpContinueDelegate Delegate

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Represents the method that notifies callers when a continue response is received by the client.

```csharp
public delegate void HttpContinueDelegate(int StatusCode, WebHeaderCollection httpHeaders);
```

## Parameters

| Parameter | Type | Description |
|---|---|---|
| `StatusCode` | `int` | The numeric value of the HTTP status from the server. |
| `httpHeaders` | `WebHeaderCollection` | The headers returned with the 100-continue response from the server. |
