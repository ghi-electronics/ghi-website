---
title: "UsbHostController Class"
sidebar_label: "UsbHostController"
---

# UsbHostController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

_No description available._

```csharp
public class UsbHostController : IDisposable
```

## Properties

### Provider

```csharp
public IUsbHostControllerProvider Provider { get; }
```

_No description available._

## Methods

### GetDefault()

```csharp
public static UsbHostController GetDefault()
```

_No description available._

**Returns** `UsbHostController`

### FromName(string name)

```csharp
public static UsbHostController FromName(string name)
```

_No description available._

**Returns** `UsbHostController`

### FromProvider(IUsbHostControllerProvider provider)

```csharp
public static UsbHostController FromProvider(IUsbHostControllerProvider provider)
```

_No description available._

**Returns** `UsbHostController`

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Enable()

```csharp
public void Enable()
```

_No description available._

### Disable()

```csharp
public void Disable()
```

_No description available._

### GetConnectedDevices()

```csharp
public static BaseDevice[] GetConnectedDevices()
```

_No description available._

**Returns** `BaseDevice[]`

## Events

### OnConnectionChangedEvent

```csharp
public event OnConnectionChanged OnConnectionChangedEvent
```

_No description available._
