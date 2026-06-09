---
title: "SslStream Class"
sidebar_label: "SslStream"
---

# SslStream Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Security`

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

_No description available._

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

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate)
```

_No description available._

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)
```

_No description available._

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)
```

_No description available._

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

_No description available._

### AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)
```

_No description available._

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

_No description available._

### Read(byte[] buffer, int offset, int size)

```csharp
public override int Read(byte[] buffer, int offset, int size)
```

_No description available._

**Returns** `int`

### Write(byte[] buffer, int offset, int size)

```csharp
public override void Write(byte[] buffer, int offset, int size)
```

_No description available._
