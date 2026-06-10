---
title: "Text Class"
sidebar_label: "Text"
---

# Text Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

A lightweight element that draws a single string in a given font.

```csharp
public class Text : UIElement
```

## Constructors

### Text()

```csharp
public Text() : this(null, null)
```

Initializes a new empty text element.

### Text(string content)

```csharp
public Text(string content) : this(null, content)
```

Initializes a new text element with the given content and no font.

### Text(System.Drawing.Font font, string content)

```csharp
public Text(System.Drawing.Font font, string content)
```

Initializes a new text element with the given font and content.

## Properties

### Font

```csharp
public System.Drawing.Font Font { get; set; }
```

The font used to draw the text.

### ForeColor

```csharp
public Color ForeColor { get; set; }
```

The color used to draw the text.

### TextContent

```csharp
public string TextContent { get; set; }
```

The string of text to display.

### Trimming

```csharp
public TextTrimming Trimming { get; set; }
```

How text that does not fit is trimmed (for example, with an ellipsis).

### TextAlignment

```csharp
public TextAlignment TextAlignment { get; set; }
```

The horizontal alignment of the text.

### LineHeight

```csharp
public int LineHeight { get; }
```

The height of a single line of text, including external leading.

### TextWrap

```csharp
public bool TextWrap { get; set; }
```

Whether text wraps onto multiple lines when it exceeds the available width.

## Methods

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected override void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measures the size needed to draw the text in the available width.

### OnRender(DrawingContext dc)

```csharp
public override void OnRender(DrawingContext dc)
```

Draws the text using the current font, color, alignment, and trimming.

## Fields

### _font

```csharp
protected System.Drawing.Font _font
```

The font used to render the text.

### _text

```csharp
protected string _text
```

The text content to render.
