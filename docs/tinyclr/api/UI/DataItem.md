---
title: "DataItem Class"
sidebar_label: "DataItem"
---

# DataItem Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Controls` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class DataItem
```

## Properties

### Value

```csharp
public double Value { get; set; }
```

Current needle position. Only this property doesn't dirty the background — the pointer is repainted every frame. _(inherited)_

### Name

```csharp
public string Name { get; set; }
```

The native API name. _(inherited)_
