---
title: "CIPClass Class"
sidebar_label: "CIPClass"
---

# CIPClass Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Adapter`

_No description available._

```csharp
public class CIPClass
```

## Constructors

### CIPClass()

```csharp
public CIPClass()
```

_No description available._

### CIPClass(ClassId classCode, int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision, bool defaultInitialize)

```csharp
public CIPClass(ClassId classCode, int numberClassAttributes, uint highestClassAttributeNumber, int numberClassServices, int numberInstanceAttributes, uint highestInstanceAttributeNumber, int numberInstanceServices, uint numberInstances, string name, ushort revision, bool defaultInitialize = true)
```

_No description available._

## Properties

### Impl

```csharp
public IntPtr Impl { get; set; }
```

_No description available._

### ClassCode

```csharp
public ClassId ClassCode { get; }
```

_No description available._

### NumberClassAttributes

```csharp
public int NumberClassAttributes { get; }
```

_No description available._

### HighestClassAttributeNumber

```csharp
public uint HighestClassAttributeNumber { get; }
```

_No description available._

### NumberClassServices

```csharp
public int NumberClassServices { get; }
```

_No description available._

### NumberInstanceAttributes

```csharp
public int NumberInstanceAttributes { get; }
```

_No description available._

### HighestInstanceAttributeNumber

```csharp
public uint HighestInstanceAttributeNumber { get; }
```

_No description available._

### NumberInstanceServices

```csharp
public int NumberInstanceServices { get; }
```

_No description available._

### NumberInstances

```csharp
public uint NumberInstances { get; }
```

_No description available._

### Name

```csharp
public string Name { get; }
```

_No description available._

### Revision

```csharp
public ushort Revision { get; }
```

_No description available._

### DefaultInitialize

```csharp
public bool DefaultInitialize { get; }
```

_No description available._
