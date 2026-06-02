---
title: "RtcControllerApiWrapper Class"
sidebar_label: "RtcControllerApiWrapper"
---

# RtcControllerApiWrapper Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Rtc.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Rtc`

Concrete `IRtcControllerProvider` backed by the native TinyCLR RTC HAL.

```csharp
public sealed class RtcControllerApiWrapper : IRtcControllerProvider
```

## Constructors

### RtcControllerApiWrapper(NativeApi api)

```csharp
public RtcControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

| Parameter | Type | Description |
|---|---|---|
| `api` | `NativeApi` | The native RTC API to bind to. |

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### IsValid

```csharp
public extern bool IsValid { get; }
```

True when the RTC has been initialized with a valid time at least once. _(inherited)_

### InternalRC

```csharp
public extern bool InternalRC { get; }
```

True when clocked from the internal RC oscillator. _(inherited)_

### BackupMemorySize

```csharp
public extern uint BackupMemorySize { get; }
```

Size in bytes of the battery-backed memory region. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### GetTime()

```csharp
public extern RtcDateTime GetTime()
```

Reads the system clock as a UTC `DateTime`. _(inherited)_

**Returns** `RtcDateTime`

### SetTime(RtcDateTime value)

```csharp
public extern void SetTime(RtcDateTime value)
```

Sets the system clock from a UTC `DateTime`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `value` | `RtcDateTime` |  |

### WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)

```csharp
public extern void WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)
```

Writes a slice of bytes to backup memory. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `sourceData` | `byte[]` | Source buffer. |
| `sourceOffset` | `uint` | Starting offset within `sourceData`. |
| `destinationOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to write. |

### ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)

```csharp
public extern int ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)
```

Reads a slice from backup memory. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `destinationData` | `byte[]` | Destination buffer. |
| `destinationOffset` | `uint` | Starting offset within `destinationData`. |
| `sourceOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to read. |

**Returns** `int` — Number of bytes read.

### SetChargeMode(BatteryChargeMode chargeMode)

```csharp
public extern void SetChargeMode(BatteryChargeMode chargeMode)
```

Configures the backup-battery trickle charger. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `chargeMode` | `BatteryChargeMode` | Charging policy. |

### Calibrate(int pulse)

```csharp
public extern void Calibrate(int pulse)
```

Applies a frequency calibration pulse. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `pulse` | `int` | Platform-specific calibration value. |
