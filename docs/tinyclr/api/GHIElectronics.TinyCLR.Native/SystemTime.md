---
title: "SystemTime Class"
sidebar_label: "SystemTime"
---

# SystemTime Class

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

Reads and writes the system wall clock (separate from the `GHIElectronics.TinyCLR.Devices.Rtc.RtcController` chip register). Time zone is carried as a minutes-from-UTC offset.

```csharp
public static class SystemTime
```

## Methods

### SetTime(long utcTime, int timeZoneOffset)

```csharp
public static extern void SetTime(long utcTime, int timeZoneOffset)
```

Sets the system clock from raw 100 ns ticks (UTC).

| Parameter | Type | Description |
|---|---|---|
| `utcTime` | `long` |  |
| `timeZoneOffset` | `int` |  |

### GetTime(out long utcTime, out int timeZoneOffset)

```csharp
public static extern void GetTime(out long utcTime, out int timeZoneOffset)
```

Reads the system clock as raw 100 ns ticks (UTC).

| Parameter | Type | Description |
|---|---|---|
| `utcTime` | `out long` |  |
| `timeZoneOffset` | `out int` |  |

### SetTime(DateTime utcTime)

```csharp
public static void SetTime(DateTime utcTime)
```

Sets the system clock from a UTC `DateTime`.

| Parameter | Type | Description |
|---|---|---|
| `utcTime` | `DateTime` |  |

### SetTime(DateTime utcTime, int timeZoneOffset)

```csharp
public static void SetTime(DateTime utcTime, int timeZoneOffset)
```

Sets the system clock from a UTC `DateTime` with a time-zone offset.

| Parameter | Type | Description |
|---|---|---|
| `utcTime` | `DateTime` |  |
| `timeZoneOffset` | `int` |  |

### GetTime()

```csharp
public static DateTime GetTime()
```

Reads the system clock as a UTC `DateTime`.

**Returns** `DateTime`

### GetTime(out DateTime utcTime, out int timeZoneOffset)

```csharp
public static void GetTime(out DateTime utcTime, out int timeZoneOffset)
```

Reads the system clock as a UTC `DateTime` together with the local time-zone offset.

| Parameter | Type | Description |
|---|---|---|
| `utcTime` | `out DateTime` |  |
| `timeZoneOffset` | `out int` |  |
