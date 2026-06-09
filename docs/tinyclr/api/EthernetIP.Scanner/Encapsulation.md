---
title: "Encapsulation Class"
sidebar_label: "Encapsulation"
---

# Encapsulation Class

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

_No description available._

```csharp
public class Encapsulation
```

## Properties

### Command

```csharp
public CommandsEnum Command { get; set; }
```

_No description available._

### Length

```csharp
public ushort Length { get; set; }
```

_No description available._

### SessionHandle

```csharp
public uint SessionHandle { get; set; }
```

_No description available._

### Status

```csharp
public StatusEnum Status { get; }
```

_No description available._

## Methods

### ArrayList()

```csharp
public ArrayList CommandSpecificData = new ArrayList()
```

_No description available._

**Returns** `ArrayList CommandSpecificData = new`

### Tobytes()

```csharp
public byte[] Tobytes()
```

_No description available._

**Returns** `byte[]`
