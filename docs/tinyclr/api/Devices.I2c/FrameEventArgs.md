---
title: "FrameEventArgs Class"
sidebar_label: "FrameEventArgs"
---

# FrameEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Arguments for `I2cDevice.FrameReceived`.

```csharp
public sealed class FrameEventArgs
```

## Properties

### Timestamp

```csharp
public DateTime Timestamp { get; }
```

Driver-captured time of the frame.

### DataCount

```csharp
public uint DataCount { get; }
```

Number of bytes associated with this frame.

### Address

```csharp
public uint Address { get; }
```

The address that was acknowledged.

### Event

```csharp
public I2cTransaction Event { get; }
```

The kind of master-initiated transaction observed.
