---
title: "Text Class"
sidebar_label: "Text"
---

# Text Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class Text : UIElement
```

## Constructors

### Text()

```csharp
public Text() : this(null, null)
```

_No description available._

### Text(string content)

```csharp
public Text(string content) : this(null, content)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `content` | `string` |  |

### Text(System.Drawing.Font font, string content)

```csharp
public Text(System.Drawing.Font font, string content)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `font` | `System.Drawing.Font` |  |
| `content` | `string` |  |

## Properties

### Font

```csharp
public System.Drawing.Font Font { get; set; }
```

Font used by the text. _(inherited)_

### ForeColor

```csharp
public Color ForeColor { get; set; }
```

_No description available._

### TextContent

```csharp
public string TextContent { get; set; }
```

_No description available._

### Trimming

```csharp
public TextTrimming Trimming { get; set; }
```

_No description available._

### TextAlignment

```csharp
public TextAlignment TextAlignment { get; set; }
```

_No description available._

### LineHeight

```csharp
public int LineHeight { get; }
```

_No description available._

### TextWrap

```csharp
public bool TextWrap { get; set; }
```

_No description available._

## Methods

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

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

## Fields

### _text

```csharp
protected string _text
```

_No description available._
