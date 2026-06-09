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

_No description available._

**Returns** `SocketAddress SocketAddress = new`

### GetCIPIdentityItem(int startingbyte, byte[] receivedData)

```csharp
public static CIPIdentityItem GetCIPIdentityItem(int startingbyte, byte[] receivedData)
```

_No description available._

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

_No description available._

### ItemLength

```csharp
public ushort ItemLength
```

_No description available._

### EncapsulationProtocolVersion

```csharp
public ushort EncapsulationProtocolVersion
```

_No description available._

### VendorID1

```csharp
public ushort VendorID1
```

_No description available._

### DeviceType1

```csharp
public ushort DeviceType1
```

_No description available._

### ProductCode1

```csharp
public ushort ProductCode1
```

_No description available._

### Revision1

```csharp
public byte[] Revision1
```

_No description available._

### Status1

```csharp
public ushort Status1
```

_No description available._

### SerialNumber1

```csharp
public uint SerialNumber1
```

_No description available._

### ProductNameLength

```csharp
public byte ProductNameLength
```

_No description available._

### ProductName1

```csharp
public string ProductName1
```

_No description available._

### State1

```csharp
public byte State1
```

_No description available._
