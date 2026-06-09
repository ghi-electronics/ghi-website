---
title: "Canvas Class"
sidebar_label: "Canvas"
---

# Canvas Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

_No description available._

```csharp
public class Canvas : Panel
```

## Constructors

### Canvas()

```csharp
public Canvas()
```

_No description available._

## Methods

### GetBottom(UIElement e)

```csharp
public static int GetBottom(UIElement e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |

**Returns** `int`

### SetBottom(UIElement e, int bottom)

```csharp
public static void SetBottom(UIElement e, int bottom)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |
| `bottom` | `int` |  |

### GetLeft(UIElement e)

```csharp
public static int GetLeft(UIElement e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |

**Returns** `int`

### SetLeft(UIElement e, int left)

```csharp
public static void SetLeft(UIElement e, int left)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |
| `left` | `int` |  |

### GetRight(UIElement e)

```csharp
public static int GetRight(UIElement e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |

**Returns** `int`

### SetRight(UIElement e, int right)

```csharp
public static void SetRight(UIElement e, int right)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |
| `right` | `int` |  |

### GetTop(UIElement e)

```csharp
public static int GetTop(UIElement e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |

**Returns** `int`

### SetTop(UIElement e, int top)

```csharp
public static void SetTop(UIElement e, int top)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `UIElement` |  |
| `top` | `int` |  |

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected override void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

ArrangeOverride allows for the customization of the positioning of children. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `arrangeWidth` | `int` |  |
| `arrangeHeight` | `int` |  |

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measurement override. Implement your size-to-content logic here. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `availableWidth` | `int` | Available size that parent can give to the child. May be MaxValue(when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |
| `availableHeight` | `int` |  |
| `desiredWidth` | `out int` |  |
| `desiredHeight` | `out int` |  |
