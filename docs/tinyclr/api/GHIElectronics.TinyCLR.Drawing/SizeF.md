---
title: "SizeF Struct"
sidebar_label: "SizeF"
---

# SizeF Struct

**Namespace:** `System.Drawing` · **Assembly:** `GHIElectronics.TinyCLR.Drawing`

A floating-point width × height size.

```csharp
public struct SizeF
```

## Constructors

### SizeF(SizeF size)

```csharp
public SizeF(SizeF size)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `size` | `SizeF` |  |

### SizeF(float width, float height)

```csharp
public SizeF(float width, float height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `float` |  |
| `height` | `float` |  |

## Properties

### IsEmpty

```csharp
public bool IsEmpty { get; }
```

_No description available._

### Width

```csharp
public float Width { get; set; }
```

Column width in pixels. _(inherited)_

### Height

```csharp
public float Height { get; set; }
```

Frame height in pixels. _(inherited)_

## Methods

### SizeF()

```csharp
public static readonly SizeF Empty = new SizeF()
```

_No description available._

**Returns** `SizeF Empty = new`
