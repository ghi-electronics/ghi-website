---
title: "Color Struct"
sidebar_label: "Color"
---

# Color Struct

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Media`

Represents an ARGB color.

```csharp
public struct Color
```

## Properties

### A

```csharp
public byte A { get; set; }
```

The alpha (opacity) component of the color.

### R

```csharp
public byte R { get; set; }
```

The red component of the color.

### G

```csharp
public byte G { get; set; }
```

The green component of the color.

### B

```csharp
public byte B { get; set; }
```

The blue component of the color.

## Methods

### FromArgb(byte a, byte r, byte g, byte b)

```csharp
public static Color FromArgb(byte a, byte r, byte g, byte b)
```

Creates a color from alpha, red, green and blue components.

**Returns** `Color`

### FromRgb(byte r, byte g, byte b)

```csharp
public static Color FromRgb(byte r, byte g, byte b)
```

Creates an opaque color from red, green and blue components.

**Returns** `Color`
