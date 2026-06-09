---
title: "RtcController Class"
sidebar_label: "RtcController"
---

# RtcController Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Rtc` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Rtc`

Real-time clock controller. Tracks calendar time across power cycles when backed by a coin cell, and exposes a small region of battery-backed RAM via `WriteBackupMemory(byte[])` / `ReadBackupMemory(byte[])`.

```csharp
public class RtcController : IDisposable
```

## Properties

### Provider

```csharp
public IRtcControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### IsValid

```csharp
public bool IsValid { get; }
```

True when the RTC has been initialized with a valid time at least once.

### InternalRC

```csharp
public bool InternalRC { get; }
```

True when the RTC is clocked from the internal RC oscillator rather than an external crystal.

### Now

```csharp
public DateTime Now { get; set; }
```

Convenience accessor that returns/accepts a managed `DateTime`.

### BackupMemorySize

```csharp
public uint BackupMemorySize { get; }
```

Size in bytes of the battery-backed memory region.

## Methods

### GetDefault()

```csharp
public static RtcController GetDefault()
```

Returns the default RTC controller for this device.

**Returns** `RtcController`

### FromName(string name)

```csharp
public static RtcController FromName(string name)
```

Returns an RTC controller identified by its native API name.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Native API name. |

**Returns** `RtcController`

### FromProvider(IRtcControllerProvider provider)

```csharp
public static RtcController FromProvider(IRtcControllerProvider provider)
```

Creates a controller from a custom `IRtcControllerProvider`.

| Parameter | Type | Description |
|---|---|---|
| `provider` | `IRtcControllerProvider` | Provider implementing the clock operations. |

**Returns** `RtcController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### GetTime()

```csharp
public RtcDateTime GetTime()
```

Returns the current RTC time.

**Returns** `RtcDateTime`

### SetTime(RtcDateTime value)

```csharp
public void SetTime(RtcDateTime value)
```

Sets the RTC time. After a successful call, `IsValid` becomes true.

| Parameter | Type | Description |
|---|---|---|
| `value` | `RtcDateTime` | Calendar time to write. |

### WriteBackupMemory(byte[] sourceData)

```csharp
public void WriteBackupMemory(byte[] sourceData)
```

Writes the entire `sourceData` array to backup memory starting at offset 0.

| Parameter | Type | Description |
|---|---|---|
| `sourceData` | `byte[]` | Bytes to write. |

### WriteBackupMemory(byte[] sourceData, uint destinationOffset)

```csharp
public void WriteBackupMemory(byte[] sourceData, uint destinationOffset)
```

Writes the entire `sourceData` array to backup memory at `destinationOffset`.

| Parameter | Type | Description |
|---|---|---|
| `sourceData` | `byte[]` | Bytes to write. |
| `destinationOffset` | `uint` | Offset in backup memory where the write begins. |

### WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)

```csharp
public void WriteBackupMemory(byte[] sourceData, uint sourceOffset, uint destinationOffset, int count)
```

Writes a slice of `sourceData` to backup memory.

| Parameter | Type | Description |
|---|---|---|
| `sourceData` | `byte[]` | Source buffer. |
| `sourceOffset` | `uint` | Starting offset within `sourceData`. |
| `destinationOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to write. |

### ReadBackupMemory(byte[] destinationData)

```csharp
public int ReadBackupMemory(byte[] destinationData)
```

Reads `destinationData`.Length bytes from backup memory starting at offset 0.

| Parameter | Type | Description |
|---|---|---|
| `destinationData` | `byte[]` | Destination buffer. |

**Returns** `int` — Number of bytes read.

### ReadBackupMemory(byte[] destinationData, uint sourceOffset)

```csharp
public int ReadBackupMemory(byte[] destinationData, uint sourceOffset)
```

Reads `destinationData`.Length bytes from backup memory starting at `sourceOffset`.

| Parameter | Type | Description |
|---|---|---|
| `destinationData` | `byte[]` | Destination buffer. |
| `sourceOffset` | `uint` | Starting offset in backup memory. |

**Returns** `int` — Number of bytes read.

### ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)

```csharp
public int ReadBackupMemory(byte[] destinationData, uint destinationOffset, uint sourceOffset, int count)
```

Reads a slice from backup memory into `destinationData`.

| Parameter | Type | Description |
|---|---|---|
| `destinationData` | `byte[]` | Destination buffer. |
| `destinationOffset` | `uint` | Starting offset within `destinationData`. |
| `sourceOffset` | `uint` | Starting offset in backup memory. |
| `count` | `int` | Number of bytes to read. |

**Returns** `int` — Number of bytes read.

### SetChargeMode(BatteryChargeMode chargeMode)

```csharp
public void SetChargeMode(BatteryChargeMode chargeMode)
```

Configures the backup-battery trickle charger.

| Parameter | Type | Description |
|---|---|---|
| `chargeMode` | `BatteryChargeMode` | Charging policy. |

### Calibrate(int pulse)

```csharp
public void Calibrate(int pulse)
```

Applies a frequency calibration pulse to compensate crystal drift.

| Parameter | Type | Description |
|---|---|---|
| `pulse` | `int` | Platform-specific calibration value. |
