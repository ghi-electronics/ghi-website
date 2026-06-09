---
title: "INotifyBindablePropertyChanged Interface"
sidebar_label: "INotifyBindablePropertyChanged"
---

# INotifyBindablePropertyChanged Interface

**Namespace:** `GHIElectronics.TinyCLR.UI` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Implement on view-models; raise `BindablePropertyChanged` with the property name (or null / empty to refresh all bindings on the object).

```csharp
public interface INotifyBindablePropertyChanged
```

## Events

### BindablePropertyChanged

```csharp
event BindablePropertyChangedEventHandler BindablePropertyChanged
```

_No description available._
