---
title: "DeviceEvents Class"
sidebar_label: "DeviceEvents"
---

# DeviceEvents Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public class DeviceEvents : DispatcherObject
```

## Events

### PreProcessInput

```csharp
public event PreProcessInputEventHandler PreProcessInput
```

Subscribe for all input before it is processed

### PreNotifyInput

```csharp
public event NotifyInputEventHandler PreNotifyInput
```

Subscribe for all input before it is notified

### PostNotifyInput

```csharp
public event NotifyInputEventHandler PostNotifyInput
```

Subscribe to all input after it is notified

### PostProcessInput

```csharp
public event ProcessInputEventHandler PostProcessInput
```

subscribe to all input after it is processed
