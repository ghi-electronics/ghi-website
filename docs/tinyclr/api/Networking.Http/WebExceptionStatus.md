---
title: "WebExceptionStatus Enum"
sidebar_label: "WebExceptionStatus"
---

# WebExceptionStatus Enum

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Defines status codes for the `System.Net.WebException` class.

```csharp
public enum WebExceptionStatus
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Success` | `0` | No error was encountered. |
| `NameResolutionFailure` | `1` | The name resolver service could not resolve the host name. |
| `ConnectFailure` | `2` | The remote service point could not be contacted at the transport level. |
| `ReceiveFailure` | `3` | A complete response was not received from the remote server. |
| `SendFailure` | `4` | A complete request could not be sent to the remote server. |
| `PipelineFailure` | `5` | The request was a piplined request and the connection was closed before the response was received. |
| `RequestCanceled` | `6` | The request was canceled or an unclassifiable error occurred. This is the default value for `System.Net.WebException.Status`. |
| `ProtocolError` | `7` | The response received from the server was complete but indicated a protocol-level error. For example, an HTTP protocol error such as 401 Access Denied would use this status. |
| `ConnectionClosed` | `8` | The connection was prematurely closed. |
| `TrustFailure` | `9` | A server certificate could not be validated. |
| `SecureChannelFailure` | `10` | An error occurred while establishing a connection using SSL. |
| `ServerProtocolViolation` | `11` | The server response was not a valid HTTP response. |
| `KeepAliveFailure` | `12` | The connection for a request that specifies the Keep-alive header was closed unexpectedly. |
| `Pending` | `13` | An internal asynchronous request is pending. |
| `Timeout` | `14` | No response was received during the time-out period for a request. |
| `ProxyNameResolutionFailure` | `15` | The name resolver service could not resolve the proxy host name. |
