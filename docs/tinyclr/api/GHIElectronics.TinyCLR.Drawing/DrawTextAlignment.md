---
title: "DrawTextAlignment Enum"
sidebar_label: "DrawTextAlignment"
---

# DrawTextAlignment Enum

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Bit flags that control how text is aligned, wrapped, and trimmed within a rectangle.

```csharp
public enum DrawTextAlignment : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0x00000000` | No special alignment behavior. |
| `WordWrap` | `0x00000001` | Text wraps to the next line when it does not fit. |
| `TruncateAtBottom` | `0x00000004` | Text that overflows the bottom of the rectangle is truncated. |
| `Ellipsis` | `0x00000008` | Overflowing text is replaced with an ellipsis. |
| `IgnoreHeight` | `0x00000010` | The available height is ignored during layout. |
| `AlignmentLeft` | `0x00000000` | Text is aligned to the left edge. |
| `AlignmentCenter` | `0x00000002` | Text is centered horizontally. |
| `AlignmentRight` | `0x00000020` | Text is aligned to the right edge. |
| `AlignmentMask` | `0x00000022` | Bit mask for the horizontal alignment flags. |
| `TrimmingNone` | `0x00000000` | Text is not trimmed. |
| `TrimmingWordEllipsis` | `0x00000008` | Text is trimmed at a word boundary with an ellipsis. |
| `TrimmingCharacterEllipsis` | `0x00000040` | Text is trimmed at a character boundary with an ellipsis. |
| `TrimmingMask` | `0x00000048` | Bit mask for the trimming flags. |
