---
title: "Theme Class"
sidebar_label: "Theme"
---

# Theme Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

Central palette for TinyCLR.UI. Brushes are shared instances; change `WindowBackground` etc. then replace the corresponding brush field if you need live updates.

```csharp
public static class Theme
```

## Properties

### WindowBackground

```csharp
public static Color WindowBackground { get; set; }
```

_No description available._

### ControlSurface

```csharp
public static Color ControlSurface { get; set; }
```

_No description available._

### TextBoxFill

```csharp
public static Color TextBoxFill { get; set; }
```

_No description available._

### TextPrimary

```csharp
public static Color TextPrimary { get; set; }
```

_No description available._

### Border

```csharp
public static Color Border { get; set; }
```

Legacy alias for `RadiusBorder`. Will be removed. _(inherited)_

### FocusRing

```csharp
public static Color FocusRing { get; set; }
```

_No description available._

### SelectionHighlight

```csharp
public static Color SelectionHighlight { get; set; }
```

_No description available._

### DefaultAlpha

```csharp
public static ushort DefaultAlpha { get; set; }
```

Default Scale9Image alpha for surface-rendered controls (Button, CheckBox, RadioButton, ProgressBar, Dropdown, Slider). ~78% opacity.

### DefaultRadiusBorder

```csharp
public static int DefaultRadiusBorder { get; set; }
```

Default corner radius (in pixels) for Scale9Image-rendered surfaces.

## Methods

### SolidColorBrush( Colors.White)

```csharp
public static readonly SolidColorBrush WindowBackgroundBrush = new SolidColorBrush(Colors.White)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `Colors.White` | `` |  |

**Returns** `SolidColorBrush WindowBackgroundBrush = new`

### SolidColorBrush( Colors.LightGray)

```csharp
public static readonly SolidColorBrush ControlSurfaceBrush = new SolidColorBrush(Colors.LightGray)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `Colors.LightGray` | `` |  |

**Returns** `SolidColorBrush ControlSurfaceBrush = new`

### SolidColorBrush( Colors.White)

```csharp
public static readonly SolidColorBrush TextBoxFillBrush = new SolidColorBrush(Colors.White)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `Colors.White` | `` |  |

**Returns** `SolidColorBrush TextBoxFillBrush = new`

### SolidColorBrush( Colors.Black)

```csharp
public static readonly SolidColorBrush TextPrimaryBrush = new SolidColorBrush(Colors.Black)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `Colors.Black` | `` |  |

**Returns** `SolidColorBrush TextPrimaryBrush = new`

### SolidColorBrush( Colors.Teal)

```csharp
public static readonly SolidColorBrush SelectionBrush = new SolidColorBrush(Colors.Teal)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `Colors.Teal` | `` |  |

**Returns** `SolidColorBrush SelectionBrush = new`

### RefreshBrushesFromColors()

```csharp
public static void RefreshBrushesFromColors()
```

Call after mutating color fields if you need brushes to match.
