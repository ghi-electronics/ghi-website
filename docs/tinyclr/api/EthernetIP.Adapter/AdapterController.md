---
title: "AdapterController Class"
sidebar_label: "AdapterController"
---

# AdapterController Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

Runs the device as an EtherNet/IP Adapter (the server side of EIP — what a PLC scanner connects to). Wraps the native OpENer stack with a managed-C# API.

```csharp
public class AdapterController : IDisposable
```

## Constructors

### AdapterController(string deviceName, ushort deviceVendorID, ushort deviceType, ushort deviceProductCode, uint deviceSerialNumber, byte deviceMajorRevision, byte deviceMinorRevision)

```csharp
public AdapterController(string deviceName, ushort deviceVendorID, ushort deviceType, ushort deviceProductCode, uint deviceSerialNumber, byte deviceMajorRevision, byte deviceMinorRevision)
```

Construct the adapter. Identity values are set on the underlying CIP Identity object but the network stack isn't started yet — call `Enable` after wiring up assemblies and connection points.

| Parameter | Type | Description |
|---|---|---|
| `deviceName` | `string` | Human-readable product name (Identity attr 7). Must match the `ProdName` field in your EDS file. |
| `deviceVendorID` | `ushort` | ODVA-assigned vendor ID (CIP UINT). Must match the `VendCode` field in your EDS file. ODVA values 1–99 are reserved for specific companies. |
| `deviceType` | `ushort` | CIP device type per Vol 1 Appendix A (e.g. 0x000C = Generic Device). |
| `deviceProductCode` | `ushort` | Vendor-assigned product code (Identity attr 3). |
| `deviceSerialNumber` | `uint` | 32-bit serial number (Identity attr 6). Should be unique per physical device — typically read from non-volatile storage. |
| `deviceMajorRevision` | `byte` | Major revision (USINT, 0–255). |
| `deviceMinorRevision` | `byte` | Minor revision (USINT, 0–255). |

## Methods

### AddCipClass(CIPClass cipClass)

```csharp
public void AddCipClass(CIPClass cipClass)
```

Registers a CIP object class with the adapter, creating it on the native stack.

### AddAssemblyObject(AssemblyObject asmObject)

```csharp
public void AddAssemblyObject(AssemblyObject asmObject)
```

Register a Class 4 (Assembly) instance the scanner can read or write via implicit (Class 1) or explicit messaging. Auto-creates the Assembly class itself on first call if not already present.

| Parameter | Type | Description |
|---|---|---|
| `asmObject` | `AssemblyObject` | Assembly description. The backing `Data` byte[] is held by raw pointer on the native side — keep it alive (static or long-lived field) for the controller's lifetime, otherwise the GC may free it and the next Class-1 send reads garbage. |

### ConfigureExclusiveOwnerConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)

```csharp
public void ConfigureExclusiveOwnerConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)
```

Register an Exclusive Owner connection point — the standard bidirectional Class-1 I/O connection. Scanner writes the output assembly, reads the input assembly, configures via the configuration assembly.

| Parameter | Type | Description |
|---|---|---|
| `connectionNumber` | `uint` | 0-based slot index. Up to `OPENER_CIP_NUM_EXLUSIVE_OWNER_CONNS` exclusive-owner connections can be defined (currently 1). |
| `outputAssemblyId` | `uint` | Instance ID of the O→T (output) assembly (scanner writes here). |
| `inputAssemblyId` | `uint` | Instance ID of the T→O (input) assembly (target produces here). |
| `configurationAssemblyId` | `uint` | Instance ID of the configuration assembly, sent during Forward Open. |

### ConfigureInputOnlyConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)

```csharp
public void ConfigureInputOnlyConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)
```

Register an Input Only connection point — scanner just reads the input assembly with no outputs (a "heartbeat" connection sized 0 for O→T).

### ConfigureListenOnlyConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)

```csharp
public void ConfigureListenOnlyConnectionPoint(uint connectionNumber, uint outputAssemblyId, uint inputAssemblyId, uint configurationAssemblyId)
```

Register a Listen Only connection point — a secondary scanner subscribes to the same multicast input data the Exclusive Owner is receiving, without owning the connection.

### InsertService(CIPClass cipClass, CIPServiceCode serviceCode, CIPServiceCode handlerCode, string serviceName)

```csharp
public void InsertService(CIPClass cipClass, CIPServiceCode serviceCode, CIPServiceCode handlerCode, string serviceName)
```

Adds a service to a CIP class, binding the given handler to the service slot.

### InsertAttribute(CipInstance cipInstance, ushort attributeNumber, CIPDataType cipType, CipAttributeEncodeInMessage encodeFunctionCode, CipAttributeDecodeFromMessage decodeFunctionCode, byte[] data, CIPAttributeFlag cipFlags)

```csharp
public void InsertAttribute(CipInstance cipInstance, ushort attributeNumber, CIPDataType cipType, CipAttributeEncodeInMessage encodeFunctionCode, CipAttributeDecodeFromMessage decodeFunctionCode, byte[] data, CIPAttributeFlag cipFlags)
```

Adds an attribute to a CIP instance, with its data type, encode/decode functions, data, and access flags.

### CreateAssemblyClass(int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision)

```csharp
public CIPClass CreateAssemblyClass(int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision)
```

Creates and registers the Assembly (Class 4) object class with the given attribute/service counts.

**Returns** `CIPClass`

### Enable()

```csharp
public void Enable()
```

Start the EtherNet/IP stack: opens the four CIP sockets (TCP 44818, UDP 44818 unicast + broadcast, UDP 2222 for Class 1), spawns the OpENer processing thread, and auto-creates any standard CIP class (Identity, Message Router, Connection Manager, Assembly, QoS) that user code didn't already register via `AddCipClass`.

### Disable()

```csharp
public void Disable()
```

Stop the EtherNet/IP stack. Equivalent to `Dispose`. Idempotent — safe to call multiple times. Resets the singleton flag so a fresh controller can be constructed afterwards.

### Dispose()

```csharp
public void Dispose()
```

Tear down all native state cleanly: signals `g_end_stack=1`, polls up to 1 s for the OpENer thread to terminate (during which it calls `ShutdownCipStack` to close all CIP connections and delete every registered class), frees the 8 KB thread stack, and resets the singleton flags so a fresh `AdapterController` can be constructed. Idempotent. Suitable for use in a `using` block.

### AddCipInstance(CIPClass cipClass, uint instanceId)

```csharp
public void AddCipInstance(CIPClass cipClass, uint instanceId)
```

Adds a single instance with the given instance ID to a CIP class.

### AddCipInstances(CIPClass cipClass, uint instanceId)

```csharp
public void AddCipInstances(CIPClass cipClass, uint instanceId)
```

Adds the configured number of instances starting at the given instance ID to a CIP class.

### AllocateAttributeMasks(CIPClass targetClass)

```csharp
public void AllocateAttributeMasks(CIPClass targetClass)
```

Allocates the get/set attribute bit masks for the given CIP class.

### CalculateIndex(ushort attributeNumber)

```csharp
public void CalculateIndex(ushort attributeNumber)
```

Calculates the internal index for the given attribute number.

### GetCipAttribute(CipInstance cipInstance, ushort attributeNumber)

```csharp
public CipAttribute GetCipAttribute(CipInstance cipInstance, ushort attributeNumber)
```

Gets the attribute with the given number from a CIP instance.

**Returns** `CipAttribute`

### GetCipClass(ushort classId)

```csharp
public CIPClass GetCipClass(ushort classId)
```

Gets the registered CIP class with the given class ID.

**Returns** `CIPClass`

### GetCipInstance(CIPClass cipClass, uint instanceNumber)

```csharp
public CipInstance GetCipInstance(CIPClass cipClass, uint instanceNumber)
```

Gets the instance with the given number from a CIP class, or null if it does not exist.

**Returns** `CipInstance`

### EnableHeaderO2T(bool on)

```csharp
public void EnableHeaderO2T(bool on)
```

Toggle the 32-bit Run/Idle header on O→T (output) Class-1 data. Must be true when talking to Allen-Bradley ControlLogix/CompactLogix scanners — they always prepend a Run/Idle header. False for most other scanner brands (HMS Anybus, Codesys). Default: false. Symptom of wrong setting: the first 4 bytes of your output assembly oscillate between 0x00000000 and 0x00000001 every cycle instead of holding real scanner-written data.

### EnableHeaderT2O(bool on)

```csharp
public void EnableHeaderT2O(bool on)
```

Toggle the 32-bit Run/Idle header on T→O (input) Class-1 data. Less commonly required than O2T; defaults to false. Enable if your scanner's configuration expects it.

## Events

### ReceivedExplicitTcpData

```csharp
public event ReceivedExplicitTcpDataHandler ReceivedExplicitTcpData
```

Fires for every explicit TCP encapsulation command received (RegisterSession, UnregisterSession, SendRRData, SendUnitData, etc.). Argument `commandCode` is an `EncapsulationCommand` value. Mostly diagnostic; for real connection state, use the lifecycle-specific events below.

### ReceivedExplicitUdpData

```csharp
public event ReceivedExplicitUdpDataHandler ReceivedExplicitUdpData
```

Fires for every explicit UDP encapsulation command received (ListIdentity, ListServices, ListInterfaces). `unicast` is true if the request came via UDP unicast vs broadcast.

### NotifyClass

```csharp
public event NotifyClassHandler NotifyClass
```

Fires when any CIP class on this device is accessed by a scanner. Diagnostic — lets you log which class/instance/attribute the scanner touched.

### AfterAssemblyDataReceived

```csharp
public event AfterAssemblyDataReceivedHandler AfterAssemblyDataReceived
```

Fires after a Class-1 implicit packet has been received and copied into the assembly's data buffer. Use this hook to react to scanner-written output values.

### BeforeAssemblyDataSend

```csharp
public event BeforeAssemblyDataSendHandler BeforeAssemblyDataSend
```

Fires immediately before a Class-1 implicit packet is sent. Hook to refresh input-assembly values from your application state just before the wire goes out.

### RegisterSessionDetected

```csharp
public event RegisterSessionHandler RegisterSessionDetected
```

Fires when a scanner successfully registers an encapsulation session (TCP RegisterSession command). Argument is the originator's IP.

### UnregisterSessionDetected

```csharp
public event RegisterSessionHandler UnregisterSessionDetected
```

Fires when a scanner closes its encapsulation session (UnregisterSession command). Argument is the originator's IP.

### ForwardOpenDetected

```csharp
public event ForwardOpenHandler ForwardOpenDetected
```

Fires when a Forward Open (regular or large) succeeds — a CIP connection is now open. `large` argument is true for Large Forward Open (service 0x5B), false for regular (service 0x54). As of Phase 3.5 this only fires on successful Forward Opens; failed attempts (resource exhaustion, electronic key mismatch, etc.) no longer trigger a phantom event.

### ForwardCloseDetected

```csharp
public event ForwardCloseHandler ForwardCloseDetected
```

Fires when a Forward Close completes — the named CIP connection is being torn down.
