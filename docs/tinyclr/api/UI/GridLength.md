---
title: "GridLength Struct"
sidebar_label: "GridLength"
---

# GridLength Struct

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public struct GridLength
```

## Methods

### Auto()

```csharp
public static GridLength Auto()
```

_No description available._

**Returns** `GridLength`

### Pixel(int pixels)

```csharp
public static GridLength Pixel(int pixels)
```

_No description available._

**Returns** `GridLength`

### Star(int weight)

```csharp
public static GridLength Star(int weight = 1)
```

_No description available._

**Returns** `GridLength`

## Fields

### Unit

```csharp
public GridUnitType Unit
```

_No description available._

### Value

```csharp
public int Value
```

Pixel size, or star weight when `Unit` is `GridUnitType.Star`.
