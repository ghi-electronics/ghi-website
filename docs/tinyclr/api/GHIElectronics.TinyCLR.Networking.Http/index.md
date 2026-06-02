---
title: "GHIElectronics.TinyCLR.Networking.Http"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Networking.Http

NuGet package containing **25** types across **2** namespaces (`System`, `System.Net`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [HttpKnownHeaderNames](./HttpKnownHeaderNames.md) | `System.Net` | Contains known HTTP header names. |
| [HttpListener](./HttpListener.md) | `System.Net` | Provides a simple, programmatically controlled HTTP protocol listener. This class cannot be inherited. |
| [HttpListenerContext](./HttpListenerContext.md) | `System.Net` | Provides access to the request and response objects used by the HttpListener class. This class cannot be inherited. |
| [HttpListenerRequest](./HttpListenerRequest.md) | `System.Net` | Describes an incoming HTTP request to an `System.Net.HttpListener` object. |
| [HttpListenerResponse](./HttpListenerResponse.md) | `System.Net` | Represents a response to a request being handled by an `System.Net.HttpListener` object. |
| [HttpVersion](./HttpVersion.md) | `System.Net` | Defines the HTTP version numbers that are supported by the `System.Net.HttpWebRequest` and `System.Net.HttpWebResponse` classes. |
| [HttpWebRequest](./HttpWebRequest.md) | `System.Net` | Provides an HTTP-specific implementation of the `System.Net.WebRequest` class. |
| [HttpWebResponse](./HttpWebResponse.md) | `System.Net` | Handles retrieval of HTTP Response headers, and handles data reads. |
| [NetworkCredential](./NetworkCredential.md) | `System.Net` | Class that keeps user name and password. |
| [ProtocolViolationException](./ProtocolViolationException.md) | `System.Net` | The exception that is thrown when an error is made while using a network protocol. |
| [Uri](./Uri.md) | `System` | Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI. |
| [WebException](./WebException.md) | `System.Net` | Defines the exception that is thrown by `System.Net.WebRequest` instances when an error occurs. |
| [WebProxy](./WebProxy.md) | `System.Net` | Contains HTTP proxy settings for the `System.Net.WebRequest` class. |
| [WebRequest](./WebRequest.md) | `System.Net` | Makes a request to a Uniform Resource Identifier (URI). This is an abstract class. |
| [WebResponse](./WebResponse.md) | `System.Net` | Provides a response from a Uniform Resource Identifier (URI). This is an abstract class. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IWebProxy](./IWebProxy.md) | `System.Net` | Provides the base interface for implementing proxy access for the `System.Net.WebRequest` class. |
| [IWebRequestCreate](./IWebRequestCreate.md) | `System.Net` | The interface for creating `System.Net.WebRequest` class objects. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [AuthenticationSchemes](./AuthenticationSchemes.md) | `System.Net` |  |
| [AuthenticationType](./AuthenticationType.md) | `System.Net` | Network authentication type. Currently supports: Basic Authentication Microsoft Live Id Delegate Authentication |
| [Flags](./Flags.md) | `System` | Defines flags kept in m_Flags variable. |
| [HttpStatusCode](./HttpStatusCode.md) | `System.Net` | Contains the values of status codes defined for HTTP. |
| [UriHostNameType](./UriHostNameType.md) | `System` | Defines host name types for the http and https protocols. method. |
| [UriKind](./UriKind.md) | `System` | Defines the kinds of `System.Uri`s for the `System.Uri.IsWellFormedUriString` method and several `System.Uri` methods. |
| [WebExceptionStatus](./WebExceptionStatus.md) | `System.Net` | Defines status codes for the `System.Net.WebException` class. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [HttpContinueDelegate](./HttpContinueDelegate.md) | `System.Net` | Represents the method that notifies callers when a continue response is received by the client. |
