---
title: "ObjectListStruct Struct"
sidebar_label: "ObjectListStruct"
---

# ObjectListStruct Struct

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary`

Holds the list of object classes supported by the target's Message Router.

```csharp
public struct ObjectListStruct
```

## Fields

### Number

```csharp
public ushort Number
```

The number of class codes in the list.

### Classes

```csharp
public ushort[] Classes
```

The supported object class codes.
