---
title: "GHIElectronics.TinyCLR.EthernetIP.Adapter"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.EthernetIP.Adapter</h1>

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [AdapterController](./AdapterController.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Runs the device as an EtherNet/IP Adapter (the server side of EIP — what a PLC scanner connects to). Wraps the native OpENer stack with a managed-C# API. |
| [AssemblyObject](./AssemblyObject.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Describes a CIP Assembly (Class 4) instance that a scanner can read or write. |
| [CipAttribute](./CipAttribute.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Represents a single attribute of a CIP object instance. |
| [CIPClass](./CIPClass.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Describes a CIP object class to be registered with the adapter. |
| [CipInstance](./CipInstance.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Represents a single instance of a CIP object class. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [CipAttributeDecodeFromMessage](./CipAttributeDecodeFromMessage.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Selects the native function used to decode an attribute value from a received message. |
| [CipAttributeEncodeInMessage](./CipAttributeEncodeInMessage.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Selects the native function used to encode an attribute value into an outgoing message. |
| [CIPAttributeFlag](./CIPAttributeFlag.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Access and callback flags applied to a CIP attribute. |
| [CIPDataType](./CIPDataType.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | The CIP data type codes used to encode attribute values on the wire. |
| [CIPServiceCode](./CIPServiceCode.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | CIP service codes for the common and object-specific services. |
| [ClassId](./ClassId.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Standard CIP object class codes. |
| [EncapsulationCommand](./EncapsulationCommand.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | EtherNet/IP encapsulation command codes reported by the explicit-data events. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [AfterAssemblyDataReceivedHandler](./AfterAssemblyDataReceivedHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles assembly data having been received into an assembly instance. |
| [BeforeAssemblyDataSendHandler](./BeforeAssemblyDataSendHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles the moment just before assembly data is sent from an assembly instance. |
| [ForwardCloseHandler](./ForwardCloseHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles a Forward Close tearing down a CIP connection. |
| [ForwardOpenHandler](./ForwardOpenHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles a successful Forward Open opening a CIP connection. |
| [NotifyClassHandler](./NotifyClassHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles notification that a scanner accessed a CIP class, instance, and attribute. |
| [ReceivedExplicitTcpDataHandler](./ReceivedExplicitTcpDataHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles an explicit TCP encapsulation command received from a scanner. |
| [ReceivedExplicitUdpDataHandler](./ReceivedExplicitUdpDataHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles an explicit UDP encapsulation command received from a scanner. |
| [RegisterSessionHandler](./RegisterSessionHandler.md) | `GHIElectronics.TinyCLR.EthernetIP.Adapter` | Handles a scanner registering or unregistering an encapsulation session. |
