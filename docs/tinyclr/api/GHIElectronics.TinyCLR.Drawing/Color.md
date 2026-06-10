---
title: "Color Struct"
sidebar_label: "Color"
---

# Color Struct

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

32-bit ARGB color value. Construct via `FromArgb(int, int, int)` / `FromArgb(int, int, int, int)`, or use one of the named static constants.

```csharp
public struct Color
```

## Properties

### Transparent

```csharp
public static Color Transparent { get; }
```

Gets a fully transparent color.

### Black

```csharp
public static Color Black { get; }
```

Gets the color black.

### White

```csharp
public static Color White { get; }
```

Gets the color white.

### Gray

```csharp
public static Color Gray { get; }
```

Gets the color gray.

### Red

```csharp
public static Color Red { get; }
```

Gets the color red.

### Green

```csharp
public static Color Green { get; }
```

Gets the color green.

### Blue

```csharp
public static Color Blue { get; }
```

Gets the color blue.

### Yellow

```csharp
public static Color Yellow { get; }
```

Gets the color yellow.

### Purple

```csharp
public static Color Purple { get; }
```

Gets the color purple.

### Teal

```csharp
public static Color Teal { get; }
```

Gets the color teal.

### R

```csharp
public byte R { get; }
```

Gets the red component of this color.

### G

```csharp
public byte G { get; }
```

Gets the green component of this color.

### B

```csharp
public byte B { get; }
```

Gets the blue component of this color.

### A

```csharp
public byte A { get; }
```

Gets the alpha component of this color.

### IsEmpty

```csharp
public bool IsEmpty { get; }
```

Gets a value indicating whether this color is empty.

### Name

```csharp
public string Name { get; }
```

Gets the hexadecimal string representation of this color's value.

## Methods

### Color()

```csharp
public static readonly Color Empty = new Color()
```

Represents a color that is null or uninitialized.

**Returns** `Color Empty = new`

### FromArgb(int argb)

```csharp
public static Color FromArgb(int argb)
```

Creates a color from a 32-bit ARGB value.

**Returns** `Color`

### FromArgb(int red, int green, int blue)

```csharp
public static Color FromArgb(int red, int green, int blue)
```

Creates an opaque color from the given red, green, and blue components.

**Returns** `Color`

### FromArgb(int alpha, int red, int green, int blue)

```csharp
public static Color FromArgb(int alpha, int red, int green, int blue)
```

Creates a color from the given alpha, red, green, and blue components.

**Returns** `Color`

### FromArgb(int alpha, Color baseColor)

```csharp
public static Color FromArgb(int alpha, Color baseColor)
```

Creates a color from an existing color with the given alpha value.

**Returns** `Color`

### GetBrightness()

```csharp
public float GetBrightness()
```

Gets the brightness (lightness) of this color as a value from 0 to 1.

**Returns** `float`

### GetHue()

```csharp
public float GetHue()
```

Gets the hue of this color in degrees (0 to 360).

**Returns** `float`

### GetSaturation()

```csharp
public float GetSaturation()
```

Gets the saturation of this color as a value from 0 to 1.

**Returns** `float`

### ToArgb()

```csharp
public int ToArgb()
```

Gets the 32-bit ARGB value of this color.

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

Returns a string describing this color's ARGB components.

**Returns** `string`

### ==(Color left, Color right)

```csharp
public static bool operator ==(Color left, Color right)
```

Determines whether two colors have the same ARGB value.

**Returns** `bool operator`

### !=(Color left, Color right)

```csharp
public static bool operator !=(Color left, Color right)
```

Determines whether two colors have different ARGB values.

**Returns** `bool operator`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Returns a hash code for this color.

**Returns** `int`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Determines whether the specified object is a color with the same ARGB value.

**Returns** `bool`

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat)
```

Converts color data from one format to another.

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat)
```

Converts color data using the specified color and channel formats.

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha)
```

Converts color data using the specified formats and alpha value.

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha, byte[] colorTable)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha, byte[] colorTable)
```

Converts color data using the specified formats, alpha value, and color table.

### ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width)

```csharp
public static void ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width)
```

Converts color data to a 1-bit-per-pixel monochrome representation.

### ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width, BitFormat bitFormat)

```csharp
public static void ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width, BitFormat bitFormat)
```

Converts color data to a 1-bit-per-pixel monochrome representation using the given bit format.
