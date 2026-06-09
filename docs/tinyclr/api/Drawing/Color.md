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

_No description available._

### Black

```csharp
public static Color Black { get; }
```

_No description available._

### White

```csharp
public static Color White { get; }
```

_No description available._

### Gray

```csharp
public static Color Gray { get; }
```

_No description available._

### Red

```csharp
public static Color Red { get; }
```

_No description available._

### Green

```csharp
public static Color Green { get; }
```

_No description available._

### Blue

```csharp
public static Color Blue { get; }
```

_No description available._

### Yellow

```csharp
public static Color Yellow { get; }
```

_No description available._

### Purple

```csharp
public static Color Purple { get; }
```

_No description available._

### Teal

```csharp
public static Color Teal { get; }
```

_No description available._

### R

```csharp
public byte R { get; }
```

_No description available._

### G

```csharp
public byte G { get; }
```

_No description available._

### B

```csharp
public byte B { get; }
```

_No description available._

### A

```csharp
public byte A { get; }
```

_No description available._

### IsEmpty

```csharp
public bool IsEmpty { get; }
```

_No description available._

### Name

```csharp
public string Name { get; }
```

The native API name. _(inherited)_

## Methods

### Color()

```csharp
public static readonly Color Empty = new Color()
```

_No description available._

**Returns** `Color Empty = new`

### FromArgb(int argb)

```csharp
public static Color FromArgb(int argb)
```

_No description available._

**Returns** `Color`

### FromArgb(int red, int green, int blue)

```csharp
public static Color FromArgb(int red, int green, int blue)
```

_No description available._

**Returns** `Color`

### FromArgb(int alpha, int red, int green, int blue)

```csharp
public static Color FromArgb(int alpha, int red, int green, int blue)
```

_No description available._

**Returns** `Color`

### FromArgb(int alpha, Color baseColor)

```csharp
public static Color FromArgb(int alpha, Color baseColor)
```

_No description available._

**Returns** `Color`

### GetBrightness()

```csharp
public float GetBrightness()
```

_No description available._

**Returns** `float`

### GetHue()

```csharp
public float GetHue()
```

_No description available._

**Returns** `float`

### GetSaturation()

```csharp
public float GetSaturation()
```

_No description available._

**Returns** `float`

### ToArgb()

```csharp
public int ToArgb()
```

_No description available._

**Returns** `int`

### ToString()

```csharp
public override string ToString()
```

String representation _(inherited)_

**Returns** `string`

### ==(Color left, Color right)

```csharp
public static bool operator ==(Color left, Color right)
```

Equals operator overload _(inherited)_

**Returns** `bool operator`

### !=(Color left, Color right)

```csharp
public static bool operator !=(Color left, Color right)
```

NotEquals operator overload _(inherited)_

**Returns** `bool operator`

### GetHashCode()

```csharp
public override int GetHashCode()
```

Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table _(inherited)_

**Returns** `int`

### Equals(object obj)

```csharp
public override bool Equals(object obj)
```

Is the given RoutedEventHandlerInfo equals the current _(inherited)_

**Returns** `bool`

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat)
```

_No description available._

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat)
```

_No description available._

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha)
```

_No description available._

### Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha, byte[] colorTable)

```csharp
public static void Convert(byte[] inArray, byte[] outArray, ColorFormat colorFormat, RgbFormat rgbFormat, byte alpha, byte[] colorTable)
```

_No description available._

### ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width)

```csharp
public static void ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width)
```

_No description available._

### ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width, BitFormat bitFormat)

```csharp
public static void ConvertTo1Bpp(byte[] inArray, byte[] outArray, uint width, BitFormat bitFormat)
```

_No description available._
