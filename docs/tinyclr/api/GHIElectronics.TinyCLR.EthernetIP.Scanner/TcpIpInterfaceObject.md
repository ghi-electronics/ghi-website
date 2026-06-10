---
title: "TcpIpInterfaceObject Class"
sidebar_label: "TcpIpInterfaceObject"
---

# TcpIpInterfaceObject Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary`

Provides explicit-message access to the TCP/IP Interface Object (Class Code 0xF5) on the target.

```csharp
public class TcpIpInterfaceObject
```

## Properties

### Status

```csharp
public InterfaceStatus Status { get; }
```

gets the Status / Read "TCP/IP Interface Object" Class Code 0xF5 - Attribute ID 1

### ConfigurationCapability

```csharp
public InterfaceCapabilityFlags ConfigurationCapability { get; }
```

gets the Configuration capability / Read "TCP/IP Interface Object" Class Code 0xF5 - Attribute ID 2

### PhysicalLinkObject

```csharp
public PhysicalLink PhysicalLinkObject { get; }
```

gets the Path to the Physical Link object / Read "TCP/IP Interface Object" Class Code 0xF5 - Attribute ID 4

### ConfigurationControl

```csharp
public InterfaceControlFlags ConfigurationControl { set; }
```

sets the Configuration control attribute / Write "TCP/IP Interface Object" Class Code 0xF5 - Attribute ID 3

### InterfaceConfiguration

```csharp
public NetworkInterfaceConfiguration InterfaceConfiguration { set; }
```

sets the TCP/IP Network interface Configuration / Write "TCP/IP Interface Object" Class Code 0xF5 - Attribute ID 5
