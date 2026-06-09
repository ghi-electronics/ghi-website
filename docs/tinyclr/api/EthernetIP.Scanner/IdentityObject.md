---
title: "IdentityObject Class"
sidebar_label: "IdentityObject"
---

# IdentityObject Class

**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` · **Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

Identity Object - Class Code: 01 Hex

```csharp
public class IdentityObject
```

## Properties

### VendorID

```csharp
public ushort VendorID { get; }
```

gets the Vendor ID / Read "Identity Object" Class Code 0x01 - Attribute ID 1

### DeviceType

```csharp
public ushort DeviceType { get; }
```

gets the Device Type / Read "Identity Object" Class Code 0x01 - Attribute ID 2

### ProductCode

```csharp
public ushort ProductCode { get; }
```

gets the Product code / Read "Identity Object" Class Code 0x01 - Attribute ID 3

### Revision

```csharp
public Revison Revision { get; }
```

gets the Revision / Read "Identity Object" Class Code 0x01 - Attribute ID 4

### Status

```csharp
public ushort Status { get; }
```

gets the Status / Read "Identity Object" Class Code 0x01 - Attribute ID 5

### SerialNumber

```csharp
public uint SerialNumber { get; }
```

gets the Serial number / Read "Identity Object" Class Code 0x01 - Attribute ID 6

### ProductName

```csharp
public string ProductName { get; }
```

gets the Product Name / Read "Identity Object" Class Code 0x01 - Attribute ID 7

### State

```csharp
public StateEnum State { get; }
```

gets the State / Read "Identity Object" Class Code 0x01 - Attribute ID 8

### ConfigurationConsistencyValue

```csharp
public ushort ConfigurationConsistencyValue { get; }
```

gets the State / Read "Identity Object" Class Code 0x01 - Attribute ID 9

### HeartbeatInterval

```csharp
public byte HeartbeatInterval { get; }
```

gets the Heartbeat intervall / Read "Identity Object" Class Code 0x01 - Attribute ID 10

### SupportedLanguageList

```csharp
public string[] SupportedLanguageList { get; }
```

gets the Supported Language List / Read "Identity Object" Class Code 0x01 - Attribute ID 12

### ClassAttributes

```csharp
public ClassAttributesStruct ClassAttributes { get; }
```

gets all class attributes

### InstanceAttributes

```csharp
public InstanceAttributesStruct InstanceAttributes { get; }
```

gets all instance attributes
