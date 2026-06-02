---
title: "ListBoxItem Class"
sidebar_label: "ListBoxItem"
---

# ListBoxItem Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class ListBoxItem : ContentControl
```

## Properties

### IsSelected

```csharp
public bool IsSelected { get; }
```

_No description available._

### IsSelectable

```csharp
public bool IsSelectable { get; set; }
```

_No description available._

## Methods

### OnIsSelectedChanged(bool isSelected)

```csharp
protected internal virtual void OnIsSelectedChanged(bool isSelected)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `isSelected` | `bool` |  |

### OnTouchUp(TouchEventArgs e)

```csharp
protected override void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |
