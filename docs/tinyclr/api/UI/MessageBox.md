---
title: "MessageBox Class"
sidebar_label: "MessageBox"
---

# MessageBox Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

WinForms-style modal message box. Usage: `MessageBox.DefaultFont = myFont; // once at app start var r = MessageBox.Show("Erase all data?", "Confirm", MessageBoxButtons.YesNo); if (r == DialogResult.Yes) { ... }` Show() is synchronous: it nests a dispatcher frame so the UI keeps painting and dispatching input while the box is up, and returns when the user picks a button (or Esc cancels). Safe to call from any UI-thread event handler.

```csharp
public static class MessageBox
```

## Properties

### DefaultFont

```csharp
public static Font DefaultFont { get; set; }
```

Optional default font. Set this once at startup so callers don't have to pass a Font on every call. Each Show overload that omits a Font uses this value.

## Methods

### Show(string message, string caption, MessageBoxButtons buttons)

```csharp
public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` |  |
| `caption` | `string` |  |
| `buttons` | `MessageBoxButtons` |  |

**Returns** `DialogResult`

### Show(string message, string caption, MessageBoxButtons buttons, Font font)

```csharp
public static DialogResult Show(string message, string caption, MessageBoxButtons buttons, Font font)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `message` | `string` |  |
| `caption` | `string` |  |
| `buttons` | `MessageBoxButtons` |  |
| `font` | `Font` |  |

**Returns** `DialogResult`

### Show(UIElement owner, string message, string caption, MessageBoxButtons buttons, Font font)

```csharp
public static DialogResult Show(UIElement owner, string message, string caption, MessageBoxButtons buttons, Font font)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `owner` | `UIElement` |  |
| `message` | `string` |  |
| `caption` | `string` |  |
| `buttons` | `MessageBoxButtons` |  |
| `font` | `Font` |  |

**Returns** `DialogResult`
