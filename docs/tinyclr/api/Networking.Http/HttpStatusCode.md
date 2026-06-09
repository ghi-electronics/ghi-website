---
title: "HttpStatusCode Enum"
sidebar_label: "HttpStatusCode"
---

# HttpStatusCode Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

Contains the values of status codes defined for HTTP.

```csharp
public enum HttpStatusCode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Continue` | `100` | Equivalent to HTTP status 100. Indicates that the client can continue with its request. |
| `SwitchingProtocols` | `101` | Equivalent to HTTP status 101. Indicates that the protocol version or protocol is being changed. |
| `OK` | `200` | Equivalent to HTTP status 200. Indicates that the request succeeded and that the requested information is in the response. This is the most common status code to receive. |
| `Created` | `201` | Equivalent to HTTP status 201. Indicates that the request resulted in a new resource created before the response was sent. |
| `Accepted` | `202` | Equivalent to HTTP status 202. Indicates that the request has been accepted for further processing. |
| `NonAuthoritativeInformation` | `203` | Equivalent to HTTP status 203. Indicates that the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect. |
| `NoContent` | `204` | Equivalent to HTTP status 204. Indicates that the request has been successfully processed and that the response is intentionally blank. |
| `ResetContent` | `205` | Equivalent to HTTP status 205. Indicates that the client should reset (not reload) the current resource. |
| `PartialContent` | `206` | Equivalent to HTTP status 206. Indicates that the response is a partial response as requested by a GET request that includes a byte range. |
| `MultipleChoices` | `300` | Equivalent to HTTP status 300. Indicates that the requested information has multiple representations. The default action is to treat this status as a redirect and follow the contents of the Location header associated with this response. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , MultipleChoices will cause an exception to be thrown. MultipleChoices is a synonym for Ambiguous . |
| `Ambiguous` | `300` | Equivalent to HTTP status 300. Indicates that the requested information has multiple representations. The default action is to treat this status as a redirect and follow the contents of the Location header associated with this response. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , Ambiguous will cause an exception to be thrown. Ambiguous is a synonym for MultipleChoices . |
| `MovedPermanently` | `301` | Equivalent to HTTP status 301. Indicates that the requested information has been moved to the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. MovedPermanently is a synonym for Moved . |
| `Moved` | `301` | Equivalent to HTTP status 301. Indicates that the requested information has been moved to the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. When the original request method was POST, the redirected request will use the GET method. Moved is a synonym for MovedPermanently . |
| `Found` | `302` | Equivalent to HTTP status 302. Indicates that the requested information is located at the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. When the original request method was POST, the redirected request will use the GET method. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , Found will cause an exception to be thrown. Found is a synonym for Redirect . |
| `Redirect` | `302` | Equivalent to HTTP status 302. Indicates that the requested information is located at the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. When the original request method was POST, the redirected request will use the GET method. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , Redirect will cause an exception to be thrown. Redirect is a synonym for Found . |
| `SeeOther` | `303` | Equivalent to HTTP status 303. Automatically redirects the client to the URI specified in the Location header as the result of a POST. The request to the resource specified by the Location header will be made with a GET. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , SeeOther will cause an exception to be thrown. SeeOther is a synonym for RedirectMethod . |
| `RedirectMethod` | `303` | Equivalent to HTTP status 303. Automatically redirects the client to the URI specified in the Location header as the result of a POST. The request to the resource specified by the Location header will be made with a GET. If the `HttpWebRequest.AllowAutoRedirect` property is false , RedirectMethod will cause an exception to be thrown. RedirectMethod is a synonym for SeeOther . |
| `NotModified` | `304` | Equivalent to HTTP status 304. Indicates that the client's cached copy is up-to-date. The contents of the resource are not transferred. |
| `UseProxy` | `305` | Equivalent to HTTP status 305. Indicates that the request should use the proxy server at the URI specified in the Location header. |
| `Unused` | `306` | Equivalent to HTTP status 306. This value is a proposed extension to the HTTP/1.1 specification that is not fully specified. |
| `TemporaryRedirect` | `307` | Equivalent to HTTP status 307. Indicates that the request information is located at the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. When the original request method was POST, the redirected request will also use the POST method. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , TemporaryRedirect will cause an exception to be thrown. TemporaryRedirect is a synonym for RedirectKeepVerb . |
| `RedirectKeepVerb` | `307` | Equivalent to HTTP status 307. Indicates that the request information is located at the URI specified in the Location header. The default action when this status is received is to follow the Location header associated with the response. When the original request method was POST, the redirected request will also use the POST method. If the `System.Net.HttpWebRequest.AllowAutoRedirect` property is false , RedirectKeepVerb will cause an exception to be thrown. RedirectKeepVerb is a synonym for TemporaryRedirect . |
| `BadRequest` | `400` | Equivalent to HTTP status 400. Indicates that the request could not be understood by the server. BadRequest is sent when no other error is applicable, or if the exact error is unknown or does not have its own error code. |
| `Unauthorized` | `401` | Equivalent to HTTP status 401. Indicates that the requested resource requires authentication. The WWW-Authenticate header contains the details of how to perform the authentication. |
| `PaymentRequired` | `402` | Equivalent to HTTP status 402. Reserved for future use. |
| `Forbidden` | `403` | Equivalent to HTTP status 403. Indicates that the server refuses to fulfill the request. |
| `NotFound` | `404` | Equivalent to HTTP status 404. Indicates that the requested resource does not exist on the server. |
| `MethodNotAllowed` | `405` | Equivalent to HTTP status 405. Indicates that the request method (POST or GET) is not allowed on the requested resource. |
| `NotAcceptable` | `406` | Equivalent to HTTP status 406. Indicates that the client has indicated with Accept headers that it will not accept any of the available representations of the resource. |
| `ProxyAuthenticationRequired` | `407` | Equivalent to HTTP status 407. Indicates that the requested proxy requires authentication. The Proxy-authenticate header contains the details of how to perform the authentication. |
| `RequestTimeout` | `408` | Equivalent to HTTP status 408. Indicates that the client did not send a request within the time the server was expecting the request. |
| `Conflict` | `409` | Equivalent to HTTP status 409. Indicates that the request could not be carried out because of a conflict on the server. |
| `Gone` | `410` | Equivalent to HTTP status 410. Indicates that the requested resource is no longer available. |
| `LengthRequired` | `411` | Equivalent to HTTP status 411. Indicates that the required Content-length header is missing. |
| `PreconditionFailed` | `412` | Equivalent to HTTP status 412. Indicates that a condition set for this request failed, and the request cannot be carried out. Conditions are set with conditional request headers like If-Match, If-None-Match, or If-Unmodified-Since. |
| `RequestEntityTooLarge` | `413` | Equivalent to HTTP status 413. Indicates that the request is too large for the server to process. |
| `RequestUriTooLong` | `414` | Equivalent to HTTP status 414. Indicates that the URI is too long. |
| `UnsupportedMediaType` | `415` | Equivalent to HTTP status 415. Indicates that the request is an unsupported type. |
| `RequestedRangeNotSatisfiable` | `416` | Equivalent to HTTP status 416. Indicates that the range of data requested from the resource cannot be returned, either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource. |
| `ExpectationFailed` | `417` | Equivalent to HTTP status 417. Indicates that an expectation given in an Expect header could not be met by the server. |
| `InternalServerError` | `500` | Equivalent to HTTP status 500. Indicates that a generic error has occurred on the server. |
| `NotImplemented` | `501` | Equivalent to HTTP status 501. Indicates that the server does not support the requested function. |
| `BadGateway` | `502` | Equivalent to HTTP status 502. Indicates that an intermediate proxy server received a bad response from another proxy or the origin server. |
| `ServiceUnavailable` | `503` | Equivalent to HTTP status 503. Indicates that the server is temporarily unavailable, usually due to high load or maintenance. |
| `GatewayTimeout` | `504` | Equivalent to HTTP status 504. Indicates that an intermediate proxy server timed out while waiting for a response from another proxy or the origin server. |
| `HttpVersionNotSupported` | `505` | Equivalent to HTTP status 505. Indicates that the requested HTTP version is not supported by the server. |
