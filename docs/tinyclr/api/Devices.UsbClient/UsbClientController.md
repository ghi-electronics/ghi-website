---
title: "UsbClientController Class"
sidebar_label: "UsbClientController"
---

# UsbClientController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

_No description available._

```csharp
public class UsbClientController : IDisposable
```

## Properties

### Provider

```csharp
public IUsbClientControllerProvider Provider { get; }
```

_No description available._

## Methods

### GetDefault()

```csharp
public static UsbClientController GetDefault()
```

_No description available._

**Returns** `UsbClientController`

### FromName(string name)

```csharp
public static UsbClientController FromName(string name)
```

_No description available._

**Returns** `UsbClientController`

### FromProvider(IUsbClientControllerProvider provider)

```csharp
public static UsbClientController FromProvider(IUsbClientControllerProvider provider)
```

_No description available._

**Returns** `UsbClientController`

### Dispose()

```csharp
public void Dispose()
```

_No description available._
