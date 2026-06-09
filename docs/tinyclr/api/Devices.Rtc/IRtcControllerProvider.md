---
title: "IRtcControllerProvider Interface"
sidebar_label: "IRtcControllerProvider"
---

# IRtcControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Rtc.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Rtc`

Provider contract for an RTC controller.

```csharp
public interface IRtcControllerProvider : IDisposable
```

## Properties

### IsValid

```csharp
bool IsValid { get; }
```

True when the RTC has been initialized with a valid time at least once.

### InternalRC

```csharp
bool InternalRC { get; }
```

True when clocked from the internal RC oscillator.

### BackupMemorySize

```csharp
uint BackupMemorySize { get; }
```

Size in bytes of the battery-backed memory region.

## Methods

### GetTime()

```csharp
RtcDateTime GetTime()
```

Reads the current calendar time.

**Returns** `RtcDateTime`

### SetTime(RtcDateTime value)

```csharp
void SetTime(RtcDateTime value)
```

Sets the RTC time.

| Parameter | Type | Description |
|---|---|---|
| `value` | `RtcDateTime` | Calendar time to write. |

### WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)

```csharp
void WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)
```

Writes a slice of bytes to backup memory.

| Parameter | Type | Description |
|---|---|---|
| `sourceData` | `byte[]` | Source buffer. |
| `sourceOffset` | `uint` | Starting offset within `sourceData`. |
| `destinationOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to write. |

### ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)

```csharp
int ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)
```

Reads a slice from backup memory.

| Parameter | Type | Description |
|---|---|---|
| `destinationData` | `byte[]` | Destination buffer. |
| `destinationOffset` | `uint` | Starting offset within `destinationData`. |
| `sourceOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to read. |

**Returns** `int` — Number of bytes read.

### SetChargeMode(BatteryChargeMode chargeMode)

```csharp
void SetChargeMode(BatteryChargeMode chargeMode)
```

Configures the backup-battery trickle charger.

| Parameter | Type | Description |
|---|---|---|
| `chargeMode` | `BatteryChargeMode` | Charging policy. |

### Calibrate(int pulse)

```csharp
void Calibrate(int pulse)
```

Applies a frequency calibration pulse.

| Parameter | Type | Description |
|---|---|---|
| `pulse` | `int` | Platform-specific calibration value. |
