---
title: "Position Struct"
sidebar_label: "Position"
---

# Position Struct

**NuGet:** `GHIElectronics.TinyCLR.Devices.Usb`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Usb`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Usb`

Represents the a generic position.

```csharp
public struct Position
```

## Properties

### X

```csharp
public int X { get; set; }
```

The X coordinate.

### Y

```csharp
public int Y { get; set; }
```

The Y coordinate.

### Z

```csharp
public int Z { get; set; }
```

The Z coordinate.

## Methods

### -(Position lhs, Position rhs)

```csharp
public static Position operator -(Position lhs, Position rhs)
```

Subtracts one position from another.

| Parameter | Type | Description |
|---|---|---|
| `lhs` | `Position` | The position from which to subtract. |
| `rhs` | `Position` | The position to subtract. |

**Returns** `Position operator` — The new positon.

### ToString()

```csharp
public override string ToString()
```

Returns a string representation of the position.

**Returns** `string` — The position.
