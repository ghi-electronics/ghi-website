---
title: "BindingErrorDirection Enum"
sidebar_label: "BindingErrorDirection"
---

# BindingErrorDirection Enum

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Direction of a binding operation that failed.

```csharp
public enum BindingErrorDirection
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Pull` |  | Source → control. The control couldn't read the bound property. |
| `Push` |  | Control → source. The control couldn't write the bound property. |
