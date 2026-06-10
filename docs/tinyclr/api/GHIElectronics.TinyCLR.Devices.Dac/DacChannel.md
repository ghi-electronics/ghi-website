---
title: "DacChannel Class"
sidebar_label: "DacChannel"
---

# DacChannel Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Dac`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Dac`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Dac`

A single DAC channel opened from a `DacController`. Call `WriteValue(int)` for raw codes or `WriteValue(double)` for a 0.0–1.0 ratio of the output range.

```csharp
public class DacChannel : IDisposable
```

## Properties

### ChannelNumber

```csharp
public int ChannelNumber { get; }
```

Controller-relative channel index this object represents.

### Controller

```csharp
public DacController Controller { get; }
```

The `DacController` that owns this channel.

### LastWrittenValue

```csharp
public int LastWrittenValue { get; set; }
```

The most recent raw value written through `WriteValue(int)`.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the channel so another caller can open it.

### WriteValue(int value)

```csharp
public void WriteValue(int value)
```

Drives the channel to a raw output code.

| Parameter | Type | Description |
|---|---|---|
| `value` | `int` | Code in [`DacController.MinValue`, `DacController.MaxValue`]. |

### WriteValue(double ratio)

```csharp
public void WriteValue(double ratio)
```

Drives the channel using a 0.0..1.0 fraction of the full output range.

| Parameter | Type | Description |
|---|---|---|
| `ratio` | `double` | Normalized output level; 0.0 maps to `DacController.MinValue` and 1.0 to `DacController.MaxValue`. |
