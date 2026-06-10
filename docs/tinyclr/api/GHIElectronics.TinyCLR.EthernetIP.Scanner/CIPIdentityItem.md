---
title: "CIPIdentityItem Class"
sidebar_label: "CIPIdentityItem"
---

# CIPIdentityItem Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Table 2-4.4 CIP Identity Item

```csharp
public class CIPIdentityItem
```

## Methods

### SocketAddress()

```csharp
public SocketAddress SocketAddress = new SocketAddress()
```

The device's socket address (IP, port, family).

**Returns** `SocketAddress SocketAddress = new`

### GetCIPIdentityItem(int startingbyte, byte[] receivedData)

```csharp
public static CIPIdentityItem GetCIPIdentityItem(int startingbyte, byte[] receivedData)
```

Parses a CIP Identity item from a received ListIdentity response buffer.

**Returns** `CIPIdentityItem`

### GetIPAddress(uint address)

```csharp
public static string GetIPAddress(uint address)
```

Converts an IP-Address in UIint32 Format (Received by Device)

**Returns** `string`

## Fields

### ItemTypeCode

```csharp
public ushort ItemTypeCode
```

Code indicating the item type of CIP Identity (0x0C).

### ItemLength

```csharp
public ushort ItemLength
```

Number of bytes in the item that follow (varies with the product name length).

### EncapsulationProtocolVersion

```csharp
public ushort EncapsulationProtocolVersion
```

Encapsulation protocol version supported by the device.

### VendorID1

```csharp
public ushort VendorID1
```

The device manufacturer's CIP vendor ID.

### DeviceType1

```csharp
public ushort DeviceType1
```

The CIP device type of the product.

### ProductCode1

```csharp
public ushort ProductCode1
```

The product code assigned with respect to the device type.

### Revision1

```csharp
public byte[] Revision1
```

The device revision (major, minor).

### Status1

```csharp
public ushort Status1
```

The current status word of the device.

### SerialNumber1

```csharp
public uint SerialNumber1
```

The device's serial number.

### ProductNameLength

```csharp
public byte ProductNameLength
```

The length in bytes of the product name string.

### ProductName1

```csharp
public string ProductName1
```

The human-readable product name of the device.

### State1

```csharp
public byte State1
```

The current operational state of the device.
