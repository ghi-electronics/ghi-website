---
title: "GHIElectronics.TinyCLR.Networking"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">Networking Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Dns](./Dns.md) | `System.Net` | Provides simple host name resolution functionality. |
| [EndPoint](./EndPoint.md) | `System.Net` | Identifies a network address. |
| [IPAddress](./IPAddress.md) | `System.Net` | Provides an internet protocol (IP) address. |
| [IPEndPoint](./IPEndPoint.md) | `System.Net` | Represents a network endpoint as an IP address and a port number. |
| [IPHostEntry](./IPHostEntry.md) | `System.Net` | Holds the host name, aliases, and IP addresses associated with a host. |
| [MulticastDns](./MulticastDns.md) | `System.Net` | Provides multicast DNS (mDNS) host name advertisement. |
| [MulticastOption](./MulticastOption.md) | `System.Net.Sockets` | Contains IP address values for setting IP multicast options. |
| [NetworkStream](./NetworkStream.md) | `System.Net.Sockets` | Provides the underlying stream of data for network access. |
| [SocketAddress](./SocketAddress.md) | `System.Net` | Stores serialized information from an endpoint. |
| [SocketException](./SocketException.md) | `System.Net.Sockets` | The exception that is thrown when a socket error occurs. |
| [SslStream](./SslStream.md) | `System.Net.Security` | Provides a stream used for client-server communication that uses SSL/TLS to secure the connection. |
| [TcpClient](./TcpClient.md) | `System.Net.Sockets` | Provides client connections for TCP network services. |
| [TcpListener](./TcpListener.md) | `System.Net.Sockets` | Listens for connections from TCP network clients. |
| [UdpClient](./UdpClient.md) | `System.Net.Sockets` | Provides User Datagram Protocol (UDP) network services. |
| [WebUtility](./WebUtility.md) | `System.Net` | Provides methods for encoding and decoding URLs and HTML text. |
| [X509Certificate](./X509Certificate.md) | `System.Security.Cryptography.X509Certificates` | Represents an X.509 certificate. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [INetworkProvider](./INetworkProvider.md) | `GHIElectronics.TinyCLR.Networking` | Defines the low-level operations a network stack must implement to back sockets. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [AddressFamily](./AddressFamily.md) | `System.Net.Sockets` | Specifies the address families that an instance of the class can use. |
| [CipherAlgorithmType](./CipherAlgorithmType.md) | `System.Security.Authentication` | Specifies the cipher algorithm used to encrypt data. |
| [ExchangeAlgorithmType](./ExchangeAlgorithmType.md) | `System.Security.Authentication` | Specifies the algorithm used to create keys shared by the client and server. |
| [HashAlgorithmType](./HashAlgorithmType.md) | `System.Security.Authentication` | Specifies the hash algorithm used for message authentication. |
| [ProtocolFamily](./ProtocolFamily.md) | `System.Net.Sockets` | Specifies the type of protocol that an instance of the class can use. |
| [ProtocolType](./ProtocolType.md) | `System.Net.Sockets` | Specifies the protocols that the class supports. |
| [SelectMode](./SelectMode.md) | `System.Net.Sockets` | Specifies the mode for polling the status of a socket. |
| [SocketError](./SocketError.md) | `System.Net.Sockets` | Defines socket error constants. |
| [SocketFlags](./SocketFlags.md) | `System.Net.Sockets` | Provides constant values for socket messages. |
| [SocketOptionLevel](./SocketOptionLevel.md) | `System.Net.Sockets` | Defines socket option levels for the class. |
| [SocketOptionName](./SocketOptionName.md) | `System.Net.Sockets` | Defines socket option names for the class. |
| [SocketShutdown](./SocketShutdown.md) | `System.Net.Sockets` | Specifies which socket operations to disable when shutting down a socket. |
| [SocketType](./SocketType.md) | `System.Net.Sockets` | Specifies the type of socket an instance of the class represents. |
| [SslProtocols](./SslProtocols.md) | `System.Security.Authentication` | Defines the SSL and TLS protocol versions that can be used. |
| [SslVerification](./SslVerification.md) | `System.Security.Authentication` | Specifies how the remote certificate is verified during the SSL handshake. |
