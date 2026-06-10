---
title: "SslStream Class"
sidebar_label: "SslStream"
---

# SslStream Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net.Security`

Provides a stream used for client-server communication that uses SSL/TLS to secure the connection.

```csharp
public class SslStream : NetworkStream
```

## Constructors

### SslStream(Socket socket)

```csharp
public SslStream(Socket socket) : base(socket, false)
```

Initializes a new instance over the specified connected socket.

## Properties

### IsServer

```csharp
public bool IsServer { get; }
```

Whether this stream is acting as the server side of the connection.

### Length

```csharp
public override long Length { get; }
```

Not supported; always throws NotSupportedException.

### DataAvailable

```csharp
public override bool DataAvailable { get; }
```

Whether decrypted data is available to be read.

## Methods

### AuthenticateAsClient(string targetHost)

```csharp
public void AuthenticateAsClient(string targetHost)
```

Performs the client side of the SSL/TLS handshake for the specified host.

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate)
```

Performs the client side of the handshake, validating against the specified CA certificate.

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate)
```

Performs the client side of the handshake using the specified CA and client certificates.

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols)
```

Performs the client side of the handshake using the specified certificates and protocols.

### AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)

```csharp
public void AuthenticateAsClient(string targetHost, X509Certificate caCertificate, X509Certificate clientCertificate, SslProtocols sslProtocols, SslVerification sslVerification)
```

Performs the client side of the handshake using the specified certificates, protocols, and verification mode.

### AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)

```csharp
public void AuthenticateAsServer(X509Certificate caCertificate, SslProtocols sslProtocols)
```

Performs the server side of the SSL/TLS handshake using the specified certificate and protocols.

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Releases the resources used by the stream and closes the secure connection.

### Read(byte[] buffer, int offset, int size)

```csharp
public override int Read(byte[] buffer, int offset, int size)
```

Reads decrypted data from the secure stream and returns the number of bytes read.

**Returns** `int`

### Write(byte[] buffer, int offset, int size)

```csharp
public override void Write(byte[] buffer, int offset, int size)
```

Encrypts and writes the specified data to the secure stream.
