---
title: "UsbHostControllerApiWrapper Class"
sidebar_label: "UsbHostControllerApiWrapper"
---

# UsbHostControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost.Provider`

_No description available._

```csharp
public sealed class UsbHostControllerApiWrapper : IUsbHostControllerProvider
```

## Constructors

### UsbHostControllerApiWrapper(NativeApi api)

```csharp
public UsbHostControllerApiWrapper(NativeApi api)
```

_No description available._

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Enable()

```csharp
public extern void Enable()
```

_No description available._

### Disable()

```csharp
public extern void Disable()
```

_No description available._

## Events

### OnConnectionChangedEvent

```csharp
public event OnConnectionChanged OnConnectionChangedEvent
```

_No description available._
