---
title: "ScannerController Class"
sidebar_label: "ScannerController"
---

# ScannerController Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Runs the device as an EtherNet/IP Scanner (the client/originator side — the role that talks to PLCs, motor drives, or other EIP adapters). Pure C# implementation, no native interop.

```csharp
public class ScannerController : IDisposable
```

## Properties

### TCPPort

```csharp
public ushort TCPPort { get; set; }
```

TCP-Port of the Server

### TargetUDPPort

```csharp
public ushort TargetUDPPort { get; set; }
```

UDP-Port of the IO-Adapter - Standard is 0xAF12

### OriginatorUDPPort

```csharp
public ushort OriginatorUDPPort { get; set; }
```

UDP-Port of the Scanner - Standard is 0xAF12

### IPAddress

```csharp
public string IPAddress { get; set; }
```

IPAddress of the Ethernet/IP Device

### RequestedPacketRate_O_T

```csharp
public uint RequestedPacketRate_O_T { get; set; }
```

Requested Packet Rate (RPI) in Microseconds Originator -> Target for Implicit-Messaging (Default 0x7A120 -> 500ms)

### RequestedPacketRate_T_O

```csharp
public uint RequestedPacketRate_T_O { get; set; }
```

Requested Packet Rate (RPI) in Microseconds Target -> Originator for Implicit-Messaging (Default 0x7A120 -> 500ms)

### O_T_OwnerRedundant

```csharp
public bool O_T_OwnerRedundant { get; set; }
```

"1" Indicates that multiple connections are allowed Originator -> Target for Implicit-Messaging (Default: TRUE)

### T_O_OwnerRedundant

```csharp
public bool T_O_OwnerRedundant { get; set; }
```

"1" Indicates that multiple connections are allowed Target -> Originator for Implicit-Messaging (Default: TRUE)

### O_T_VariableLength

```csharp
public bool O_T_VariableLength { get; set; }
```

With a fixed size connection, the amount of data shall be the size of specified in the "Connection Size" Parameter. With a variable size, the amount of data could be up to the size specified in the "Connection Size" Parameter Originator -> Target for Implicit Messaging (Default: True (Variable length))

### T_O_VariableLength

```csharp
public bool T_O_VariableLength { get; set; }
```

With a fixed size connection, the amount of data shall be the size of specified in the "Connection Size" Parameter. With a variable size, the amount of data could be up to the size specified in the "Connection Size" Parameter Target -> Originator for Implicit Messaging (Default: True (Variable length))

### O_T_Length

```csharp
public ushort O_T_Length { get; }
```

The maximum size in bytes (only pure data without sequence count and 32-Bit Real Time Header (if present)) from Originator -> Target for Implicit Messaging (Default: 505)

### T_O_Length

```csharp
public ushort T_O_Length { get; }
```

The maximum size in bytes (only pure data woithout sequence count and 32-Bit Real Time Header (if present)) from Target -> Originator for Implicit Messaging (Default: 505)

### O_T_ConnectionType

```csharp
public ConnectionType O_T_ConnectionType { get; set; }
```

Connection Type Originator -> Target for Implicit Messaging (Default: ConnectionType.Point_to_Point)

### T_O_ConnectionType

```csharp
public ConnectionType T_O_ConnectionType { get; set; }
```

Connection Type Target -> Originator for Implicit Messaging (Default: ConnectionType.Multicast)

### O_T_Priority

```csharp
public Priority O_T_Priority { get; set; }
```

Priority Originator -> Target for Implicit Messaging (Default: Priority.Scheduled) Could be: Priority.Scheduled; Priority.High; Priority.Low; Priority.Urgent

### T_O_Priority

```csharp
public Priority T_O_Priority { get; set; }
```

Priority Target -> Originator for Implicit Messaging (Default: Priority.Scheduled) Could be: Priority.Scheduled; Priority.High; Priority.Low; Priority.Urgent

### O_T_InstanceID

```csharp
public byte O_T_InstanceID { get; set; }
```

Class Assembly (Consuming IO-Path - Outputs) Originator -> Target for Implicit Messaging

### T_O_InstanceID

```csharp
public byte T_O_InstanceID { get; set; }
```

Class Assembly (Producing IO-Path - Inputs) Target -> Originator for Implicit Messaging

### O_T_IOData

```csharp
public byte[] O_T_IOData { get; set; }
```

Provides Access to the Class 1 Real-Time IO-Data Originator -> Target for Implicit Messaging

### T_O_IOData

```csharp
public byte[] T_O_IOData { get; set; }
```

Provides Access to the Class 1 Real-Time IO-Data Target -> Originator for Implicit Messaging

### O_T_RealTimeFormat

```csharp
public RealTimeFormat O_T_RealTimeFormat { get; set; }
```

Used Real-Time Format Originator -> Target for Implicit Messaging (Default: RealTimeFormat.Header32Bit) Possible Values: RealTimeFormat.Header32Bit; RealTimeFormat.Heartbeat; RealTimeFormat.ZeroLength; RealTimeFormat.Modeless

### T_O_RealTimeFormat

```csharp
public RealTimeFormat T_O_RealTimeFormat { get; set; }
```

Used Real-Time Format Target -> Originator for Implicit Messaging (Default: RealTimeFormat.Modeless) Possible Values: RealTimeFormat.Header32Bit; RealTimeFormat.Heartbeat; RealTimeFormat.ZeroLength; RealTimeFormat.Modeless

### AssemblyObjectClass

```csharp
public byte AssemblyObjectClass { get; set; }
```

AssemblyObject for the Configuration Path in case of Implicit Messaging (Standard: 0x04)

### ConfigurationAssemblyInstanceID

```csharp
public byte ConfigurationAssemblyInstanceID { get; set; }
```

ConfigurationAssemblyInstanceID is the InstanceID of the configuration Instance in the Assembly Object Class (Standard: 0x01)

### ConfigurationAssembly_Data

```csharp
public byte[] ConfigurationAssembly_Data { get; set; }
```

ConfigurationAssemblyInstanceID is the InstanceID of the configuration Instance in the Assembly Object Class (Standard: 0x01)

### ConfigurationAssemblyData_Length

```csharp
public ushort ConfigurationAssemblyData_Length { get; }
```

ConfigurationAssemblyDataLength max 500

### WriteConfiguration

```csharp
public bool WriteConfiguration { get; set; }
```

ConfigurationAssemblyDataLength max 500

### LastReceivedImplicitMessage

```csharp
public DateTime LastReceivedImplicitMessage { get; set; }
```

Returns the Date and Time when the last Implicit Message has been received fŕom The Target Device Could be used to determine a Timeout. NOTE: this is a wall-clock timestamp (DateTime.Now) and breaks if the system clock jumps (NTP sync, DST, manual set). For timeout detection that must survive clock changes, read `LastReceivedImplicitMessageTickCount` instead and compare against `Environment.TickCount`.

### LastReceivedImplicitMessageTickCount

```csharp
public int LastReceivedImplicitMessageTickCount { get; set; }
```

Monotonic (clock-jump-safe) counterpart of `LastReceivedImplicitMessage`. Stores `Environment.TickCount` at the moment the last Class-1 packet was received from the target. Compare against a fresh `Environment.TickCount` read to compute elapsed-since-last-implicit, e.g. `(Environment.TickCount - scanner.LastReceivedImplicitMessageTickCount) > 5000` for a 5-second watchdog. Unlike `LastReceivedImplicitMessage`, this value is not affected by NTP sync, DST changes, or manual clock adjustment.

### IdentityObject

```csharp
public ObjectLibrary.IdentityObject IdentityObject { get; }
```

Implementation of the identity Object (Class Code: 0x01) - Required Object according to CIP-Specification

### MessageRouterObject

```csharp
public ObjectLibrary.MessageRouterObject MessageRouterObject { get; }
```

Implementation of the Message Router Object (Class Code: 0x02) - Required Object according to CIP-Specification

### AssemblyObject

```csharp
public ObjectLibrary.AssemblyObject AssemblyObject { get; }
```

Implementation of the Assembly Object (Class Code: 0x04)

### TcpIpInterfaceObject

```csharp
public ObjectLibrary.TcpIpInterfaceObject TcpIpInterfaceObject { get; }
```

Implementation of the TCP/IP Object (Class Code: 0xF5) - Required Object according to CIP-Specification

## Methods

### ListIdentity(NetworkController networkController, TimeSpan timeout)

```csharp
public Encapsulation.CIPIdentityItem[] ListIdentity(NetworkController networkController, TimeSpan timeout)
```

Broadcasts an EIP List Identity command and collects responses from every EtherNet/IP device on the local subnet during the timeout window.

| Parameter | Type | Description |
|---|---|---|
| `networkController` | `NetworkController` | The TinyCLR `NetworkController` whose IP/mask is used to compute the broadcast address. |
| `timeout` | `TimeSpan` | How long to listen for responses. Spec says devices reply within a random 0–2 s delay window, so use ≥ 2 s for reliable discovery. Pass `TimeSpan.Zero` to wait indefinitely (not recommended). |

**Returns** `Encapsulation.CIPIdentityItem[]` — One `Encapsulation.CIPIdentityItem` per responding device, or `null` if no device responded.

### RegisterSession(uint address, ushort port)

```csharp
public uint RegisterSession(uint address, ushort port)
```

Opens a TCP connection to the target on port 44818 (0xAF12) and sends an EIP RegisterSession command to establish an encapsulation session. Required before any explicit-messaging service (GetAttributeSingle, ForwardOpen, etc.) can be sent.

| Parameter | Type | Description |
|---|---|---|
| `address` | `uint` | Target IP as a packed 32-bit value: top byte is the first IPv4 octet (e.g. 192.168.1.1 = 0xC0A80101). Use the string overload if you have a dotted-quad string. |
| `port` | `ushort` | TCP port — typically 0xAF12 (44818, EIP standard). Pass a non-standard port only if the target listens elsewhere. |

**Returns** `uint` — The 32-bit session handle assigned by the target. Stored internally; you typically don't need to inspect it.

### UnRegisterSession()

```csharp
public void UnRegisterSession()
```

Sends an EIP UnregisterSession command to gracefully close the encapsulation session, then closes the TCP connection. Idempotent — safe to call even if the target has already dropped. `Dispose` calls this for you.

### Dispose()

```csharp
public void Dispose()
```

Tears down the scanner cleanly: closes the Class-1 connection (ForwardClose), unregisters the encapsulation session, closes all sockets. Each sub-step swallows its own exceptions so Dispose itself never throws (per the `IDisposable` contract). Idempotent and safe to call from a `using` block on any code path including before `ForwardOpen()`.

### ForwardOpen()

```csharp
public void ForwardOpen()
```

Opens a Class-1 (implicit / cyclic I/O) connection to the target using regular Forward Open (service 0x54). Configure all connection-related properties (`IPAddress`, `O_T_InstanceID`, `T_O_InstanceID`, `RequestedPacketRate_O_T`, `O_T_RealTimeFormat`, etc.) before calling.

### ForwardOpen(bool largeForwardOpen)

```csharp
public void ForwardOpen(bool largeForwardOpen)
```

Opens a Class-1 implicit connection, choosing between regular Forward Open (service 0x54) and Large Forward Open (service 0x5B) based on the `largeForwardOpen` flag. Large form is required when either direction's payload exceeds ~500 bytes.

| Parameter | Type | Description |
|---|---|---|
| `largeForwardOpen` | `bool` | true → use Large Forward Open (32-bit connection parameters, allows up to ~65 KB per direction); false → use regular Forward Open. |

### LargeForwardOpen()

```csharp
public void LargeForwardOpen()
```

Opens a Class-1 implicit connection using Large Forward Open (service 0x5B), for payloads larger than ~500 bytes.

### Detect_O_T_Length()

```csharp
public ushort Detect_O_T_Length ()
```

Detects the Length of the data Originator -> Target. The Method uses an Explicit Message to detect the length. The IP-Address, Port and the Instance ID has to be defined before

**Returns** `ushort`

### Detect_T_O_Length()

```csharp
public ushort Detect_T_O_Length()
```

Detects the Length of the data Target -> Originator. The Method uses an Explicit Message to detect the length. The IP-Address, Port and the Instance ID has to be defined before

**Returns** `ushort`

### ForwardClose()

```csharp
public void ForwardClose()
```

Sends a Forward Close to tear down the Class-1 implicit connection, stops the producer thread, waits for the producer to exit, then sends the close request and closes the UDP receive socket. Safe to call from a `using` block via `Dispose`.

### RegisterSession(string address, ushort port)

```csharp
public uint RegisterSession(string address, ushort port)
```

Sends a RegisterSession command to a target to initiate session

| Parameter | Type | Description |
|---|---|---|
| `address` | `string` | IP-Address of the target device |
| `port` | `ushort` | Port of the target device (default should be 0xAF12) |

**Returns** `uint` — Session Handle

### RegisterSession(string address)

```csharp
public uint RegisterSession(string address)
```

Sends a RegisterSession command to a target to initiate session with the Standard or predefined Port (Standard: 0xAF12)

| Parameter | Type | Description |
|---|---|---|
| `address` | `string` | IP-Address of the target device |

**Returns** `uint` — Session Handle

### RegisterSession()

```csharp
public uint RegisterSession()
```

Sends a RegisterSession command to a target to initiate session with the Standard or predefined Port and Predefined IPAddress (Standard-Port: 0xAF12)

**Returns** `uint` — Session Handle

### GetAttributeSingle(int classID, int instanceID, int attributeID)

```csharp
public byte[] GetAttributeSingle(int classID, int instanceID, int attributeID)
```

Sends a CIP Get_Attribute_Single (service 0x0E) to read one attribute from the target. Auto-registers a session if not already open. Blocks until the target replies or the underlying TCP read times out.

| Parameter | Type | Description |
|---|---|---|
| `classID` | `int` | CIP class code (e.g. 0x01 = Identity). |
| `instanceID` | `int` | Instance number, 1-based. |
| `attributeID` | `int` | Attribute ID within the instance. |

**Returns** `byte[]` — Raw attribute bytes. Endianness and structure depend on the attribute's CIP type — use the `ToUshort`/`ToUint` helpers or the strongly-typed accessors on `ObjectLibrary.IdentityObject` etc. for common cases.

### GetAttributeAll(int classID, int instanceID)

```csharp
public byte[] GetAttributeAll(int classID, int instanceID)
```

Implementation of Common Service "Get_Attribute_All" - Service Code: 0x01

| Parameter | Type | Description |
|---|---|---|
| `classID` | `int` | Class id of requested Attributes |
| `instanceID` | `int` | Instance of Requested Attributes (0 for class Attributes) |

**Returns** `byte[]` — Session Handle

### SetAttributeSingle(int classID, int instanceID, int attributeID, byte[] value)

```csharp
public byte[] SetAttributeSingle(int classID, int instanceID, int attributeID, byte[] value)
```

Sends a CIP Set_Attribute_Single (service 0x10) to write one attribute on the target. Auto-registers a session if not already open.

| Parameter | Type | Description |
|---|---|---|
| `classID` | `int` | CIP class code. |
| `instanceID` | `int` | Instance number, 1-based. |
| `attributeID` | `int` | Attribute ID within the instance. |
| `value` | `byte[]` | Raw bytes to write. Must match the attribute's CIP type width and endianness — most types are little-endian on the wire. |

**Returns** `byte[]` — Any reply bytes the target included. Usually empty.

### GetAttributeAll(int classID)

```csharp
public byte[] GetAttributeAll(int classID)
```

Implementation of Common Service "Get_Attribute_All" - Service Code: 0x01

| Parameter | Type | Description |
|---|---|---|
| `classID` | `int` | Class id of requested Attributes |

**Returns** `byte[]`

### ToUshort(byte[] byteArray)

```csharp
public static ushort ToUshort(byte[] byteArray)
```

Converts a bytearray (received e.g. via getAttributeSingle) to ushort

| Parameter | Type | Description |
|---|---|---|
| `byteArray` | `byte[]` | bytearray to convert |

**Returns** `ushort`

### ToUint(byte[] byteArray)

```csharp
public static uint ToUint(byte[] byteArray)
```

Converts a bytearray (received e.g. via getAttributeSingle) to uint

| Parameter | Type | Description |
|---|---|---|
| `byteArray` | `byte[]` | bytearray to convert |

**Returns** `uint`

### ToBool(byte inputbyte, int bitposition)

```csharp
public static bool ToBool(byte inputbyte, int bitposition)
```

Returns the "Bool" State of a byte Received via getAttributeSingle

| Parameter | Type | Description |
|---|---|---|
| `inputbyte` | `byte` | byte to convert |
| `bitposition` | `int` | bitposition to convert (First bit = bitposition 0) |

**Returns** `bool` — Converted bool value

## Events

### ConnectionEstablished

```csharp
public event EipEventHandler ConnectionEstablished
```

Fired once after a successful ForwardOpen / LargeForwardOpen.

### ConnectionLost

```csharp
public event EipEventHandler ConnectionLost
```

Fired when the implicit producer (sendUDP) repeatedly fails to send, or when the target stops producing for longer than the RPI watchdog. Not fired on a user-initiated ForwardClose / Dispose.

### ImplicitDataReceived

```csharp
public event ImplicitDataReceivedHandler ImplicitDataReceived
```

Fired on every Class-1 packet received from the target. The byte[] argument is a freshly-allocated snapshot of the payload — safe to retain, safe to read off-thread. T_O_IOData is also updated, but the snapshot is the race-free way to consume implicit input.

### RpiViolated

```csharp
public event EipEventHandler RpiViolated
```

Fired when an implicit packet arrives later than the negotiated RPI tolerance (currently fires when the inter-arrival gap exceeds 4 * RPI). Diagnostic only; the connection is not automatically closed.
