---
title: "SizeF Struct"
sidebar_label: "SizeF"
---

# SizeF Struct

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

A floating-point width × height size.

```csharp
public struct SizeF
```

## Constructors

### SizeF(SizeF size)

```csharp
public SizeF(SizeF size)
```

Initializes a new size as a copy of an existing size.

### SizeF(float width, float height)

```csharp
public SizeF(float width, float height)
```

Initializes a new size with the given width and height.

## Properties

### IsEmpty

```csharp
public bool IsEmpty { get; }
```

Gets a value indicating whether both width and height are zero.

### Width

```csharp
public float Width { get; set; }
```

Gets or sets the width.

### Height

```csharp
public float Height { get; set; }
```

Gets or sets the height.

## Methods

### SizeF()

```csharp
public static readonly SizeF Empty = new SizeF()
```

Represents a size with zero width and height.

**Returns** `SizeF Empty = new`
