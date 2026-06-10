---
title: "GHIElectronics.TinyCLR.EthernetIP.Scanner"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.EthernetIP.Scanner</h1>

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [AssemblyObject](./AssemblyObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Provides explicit-message access to the Assembly Object (Class Code 0x04) on the target. |
| [CIPException](./CIPException.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Thrown when the target returns a non-success CIP general status code. |
| [CIPIdentityItem](./CIPIdentityItem.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Table 2-4.4 CIP Identity Item |
| [CommonPacketFormat](./CommonPacketFormat.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Represents the EtherNet/IP Common Packet Format used to wrap CIP request/response data. |
| [ConnectionManagerObject](./ConnectionManagerObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Connection Manager Object - Class Code: 06 Hex |
| [Encapsulation](./Encapsulation.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Represents an EtherNet/IP encapsulation packet header plus its command-specific data. |
| [IdentityObject](./IdentityObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Identity Object - Class Code: 01 Hex |
| [MessageRouterObject](./MessageRouterObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Provides explicit-message access to the Message Router Object (Class Code 0x02) on the target. |
| [ScannerController](./ScannerController.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Runs the device as an EtherNet/IP Scanner (the client/originator side — the role that talks to PLCs, motor drives, or other EIP adapters). Pure C# implementation, no native interop. |
| [SocketAddress](./SocketAddress.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Socket Address (see section 2-6.3.2) |
| [TcpIpInterfaceObject](./TcpIpInterfaceObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Provides explicit-message access to the TCP/IP Interface Object (Class Code 0xF5) on the target. |
| [UdpState](./UdpState.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Holds the UDP client and endpoint used by an asynchronous receive operation. |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [ClassAttributesStruct](./ClassAttributesStruct.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Holds the class-level attributes of the Identity Object. |
| [InstanceAttributesStruct](./InstanceAttributesStruct.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Holds the instance-level attributes of the Identity Object. |
| [InterfaceCapabilityFlags](./InterfaceCapabilityFlags.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Chapter 5-3.2.2.2 Volume 2 |
| [InterfaceControlFlags](./InterfaceControlFlags.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Chapter 5-3.2.2.3 Volume 2 |
| [InterfaceStatus](./InterfaceStatus.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Chapter 5-3.2.2.1 Volume 2 |
| [NetworkInterfaceConfiguration](./NetworkInterfaceConfiguration.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Chapter 5-3.2.2.5 Volume 2 |
| [ObjectListStruct](./ObjectListStruct.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Holds the list of object classes supported by the target's Message Router. |
| [PhysicalLink](./PhysicalLink.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Page 5.5 Volume 2 |
| [Revison](./Revison.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | Holds a device revision as a major and minor number. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [CIPCommonServices](./CIPCommonServices.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Table A-3.1 Volume 1 Chapter A-3 |
| [CommandsEnum](./CommandsEnum.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Table 2-3.2 Encapsulation Commands |
| [ConnectionType](./ConnectionType.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | The connection type for one direction of a Class-1 implicit connection. |
| [Priority](./Priority.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | The transport priority for one direction of a Class-1 implicit connection. |
| [RealTimeFormat](./RealTimeFormat.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | The real-time data format used for one direction of a Class-1 implicit connection. |
| [StateEnum](./StateEnum.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` | The operational state reported by the Identity Object (attribute 8). |
| [StatusEnum](./StatusEnum.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Table 2-3.3 Error Codes |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [EipEventHandler](./EipEventHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Handler for scanner lifecycle events (connection established/lost, RPI violated). |
| [ImplicitDataReceivedHandler](./ImplicitDataReceivedHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Scanner` | Handler for `ImplicitDataReceived`; receives a race-free snapshot of each Class-1 payload. |
