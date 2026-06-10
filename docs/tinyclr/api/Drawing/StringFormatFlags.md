---
title: "StringFormatFlags Enum"
sidebar_label: "StringFormatFlags"
---

# StringFormatFlags Enum

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Bit flags that control text layout and rendering behavior.

```csharp
public enum StringFormatFlags
```

## Fields

| Name | Value | Description |
|---|---|---|
| `DirectionRightToLeft` | `0x00000001` | Text is laid out from right to left. |
| `DirectionVertical` | `0x00000002` | Text is laid out vertically. |
| `FitBlackBox` | `0x00000004` | Parts of characters are allowed to overhang the layout rectangle. |
| `DisplayFormatControl` | `0x00000020` | Control characters are shown with representative glyphs. |
| `NoFontFallback` | `0x00000400` | Fallback to alternate fonts for missing characters is disabled. |
| `MeasureTrailingSpaces` | `0x00000800` | Trailing spaces are included when measuring text. |
| `NoWrap` | `0x00001000` | Text wrapping between lines is disabled. |
| `LineLimit` | `0x00002000` | Only entire lines are laid out within the rectangle. |
| `NoClip` | `0x00004000` | Glyph overhangs and unwrapped text are not clipped. |
