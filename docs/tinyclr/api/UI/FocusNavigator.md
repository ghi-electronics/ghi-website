---
title: "FocusNavigator Class"
sidebar_label: "FocusNavigator"
---

# FocusNavigator Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

PC-style tab order over the logical tree. Call from hardware mappings (e.g. next/previous) via `InputProvider.RaiseFocusNavigation`.

```csharp
public static class FocusNavigator
```

## Methods

### TryMoveFocus(bool forward)

```csharp
public static bool TryMoveFocus(bool forward)
```

Moves keyboard focus to the next or previous tab stop under `Application.MainWindow`.

| Parameter | Type | Description |
|---|---|---|
| `forward` | `bool` |  |

**Returns** `bool` — True if focus was moved or already on a valid target.

### TryMoveFocus(bool forward, UIElement scope)

```csharp
public static bool TryMoveFocus(bool forward, UIElement scope)
```

Moves focus within the subtree rooted at `scope`.

| Parameter | Type | Description |
|---|---|---|
| `forward` | `bool` |  |
| `scope` | `UIElement` |  |

**Returns** `bool`
