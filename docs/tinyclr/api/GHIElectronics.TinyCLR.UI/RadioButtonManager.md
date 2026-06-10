---
title: "RadioButtonManager Class"
sidebar_label: "RadioButtonManager"
---

# RadioButtonManager Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Tracks radio button groups so only one button per group can be selected.

```csharp
public static class RadioButtonManager
```

## Methods

### GetValue(string groupName)

```csharp
public static string GetValue(string groupName)
```

Returns the value of the currently selected button in the named group, or an empty string if none is selected.

**Returns** `string`

### GetCount(string groupName)

```csharp
public static int GetCount(string groupName)
```

Returns the number of buttons in the named group.

**Returns** `int`
