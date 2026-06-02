---
title: "IDacControllerProvider Interface"
sidebar_label: "IDacControllerProvider"
---

# IDacControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Dac.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Dac`

Provider contract for a DAC controller. Most users call `DacController` / `DacChannel` directly; implement this interface only when supplying a custom or virtual DAC.

```csharp
public interface IDacControllerProvider : IDisposable
```

## Properties

### ChannelCount

```csharp
int ChannelCount { get; }
```

Total number of channels exposed by this controller.

### ResolutionInBits

```csharp
int ResolutionInBits { get; }
```

Sample width in bits.

### MinValue

```csharp
int MinValue { get; }
```

Smallest raw value accepted by `Write(int, int)`.

### MaxValue

```csharp
int MaxValue { get; }
```

Largest raw value accepted by `Write(int, int)`.

## Methods

### OpenChannel(int channel)

```csharp
void OpenChannel(int channel)
```

Acquires exclusive access to the specified channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### CloseChannel(int channel)

```csharp
void CloseChannel(int channel)
```

Releases a previously opened channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |

### Write(int channel, int value)

```csharp
void Write(int channel, int value)
```

Writes a raw code to the channel.

| Parameter | Type | Description |
|---|---|---|
| `channel` | `int` | Controller-relative channel index. |
| `value` | `int` | Output code. |
