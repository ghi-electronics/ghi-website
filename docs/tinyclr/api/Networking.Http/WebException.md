---
title: "WebException Class"
sidebar_label: "WebException"
---

# WebException Class

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Http`

Defines the exception that is thrown by `System.Net.WebRequest` instances when an error occurs.

```csharp
public class WebException : InvalidOperationException
```

## Constructors

### WebException()

```csharp
public WebException()
```

The default constructor.

### WebException(string message)

```csharp
public WebException(string message) : base(message)
```

Constructs a WebException based on the specified message string.

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | The message string for the exception. |

### WebException(string message, Exception innerException)

```csharp
public WebException(string message, Exception innerException) : base(message, innerException)
```

Constructs a WebException based on the specified message string and inner exception.

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | The message string for the exception. |
| `innerException` | `Exception` | The exception that caused this exception. |

### WebException(string message, WebExceptionStatus status)

```csharp
public WebException(string message, WebExceptionStatus status) : base(message)
```

Constructs a WebException based on the specified message string and WebExceptionStatus .

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | The message string for the exception. |
| `status` | `WebExceptionStatus` | The network status of the exception. |

### WebException(string message, Exception inner, WebExceptionStatus status, WebResponse response)

```csharp
public WebException(string message, Exception inner, WebExceptionStatus status, WebResponse response) : base(message, inner)
```

Constructs a WebException based on the specified message string, inner exception, `System.Net.WebExceptionStatus`, and `System.Net.WebResponse`.

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` | Message string for exception. |
| `inner` | `Exception` | The exception that caused this exception. |
| `status` | `WebExceptionStatus` | The network status of the exception. |
| `response` | `WebResponse` | The WebResponse we have. |

## Properties

### Status

```csharp
public WebExceptionStatus Status { get; }
```

Gets the WebExceptionStatus code.

### Response

```csharp
public WebResponse Response { get; }
```

Gets the response that the remote host returned.
