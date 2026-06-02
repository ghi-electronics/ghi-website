---
title: "SslStream Class"
sidebar_label: "SslStream"
---

# SslStream Class

**Namespace:** `System.Net.Security` · **Assembly:** `GHIElectronics.TinyCLR.Networking`

_No description available._

```csharp
public class SslStream : NetworkStream
```

## Constructors

### SslStream(Socket socket)

```csharp
public SslStream(Socket socket) : base(socket, false)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `socket` | `Socket` |  |

## Properties

### IsServer

```csharp
public bool IsServer { get; }
```

_No description available._

### Length

```csharp
public override long Length { get; }
```

Gets length of bytes in the stream. _(inherited)_

### DataAvailable

```csharp
public override bool DataAvailable { get; }
```

_No description available._

## Methods

### AuthenticateAsClient(string targetHost)

```csharp
public void AuthenticateAsClient(string targetHost)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `targetHost` | `string` |  |

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `targetHost` | `string` |  |
| `caCertificate` | `X509Certificate` |  |

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `targetHost` | `string` |  |
| `caCertificate` | `X509Certificate` |  |
| `clientCertificate` | `X509Certificate` |  |

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `targetHost` | `string` |  |
| `caCertificate` | `X509Certificate` |  |
| `clientCertificate` | `X509Certificate` |  |
| `sslProtocols` | `SslProtocols` |  |

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `targetHost` | `string` |  |
| `caCertificate` | `X509Certificate` |  |
| `clientCertificate` | `X509Certificate` |  |
| `sslProtocols` | `SslProtocols` |  |
| `sslVerification` | `SslVerification` |  |

### AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `caCertificate` | `X509Certificate` |  |
| `sslProtocols` | `SslProtocols` |  |

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

### Read(byte[] buffer, int offset, int size)

```csharp
public override int Read(byte[] buffer, int offset, int size)
```

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array at which read bytes will be placed. |
| `size` | `int` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int size)

```csharp
public override void Write(byte[] buffer, int offset, int size)
```

Writes a block of bytes to the file stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array from which to start writing bytes to the stream. |
| `size` | `int` |  |
