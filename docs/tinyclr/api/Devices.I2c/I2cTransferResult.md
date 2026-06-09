---
title: "I2cTransferResult Struct"
sidebar_label: "I2cTransferResult"
---

# I2cTransferResult Struct

**Namespace:** `GHIElectronics.TinyCLR.Devices.I2c` · **Assembly:** `GHIElectronics.TinyCLR.Devices.I2c`

Outcome of a partial-transfer call (`I2cDevice.ReadPartial(byte[])` and friends).

```csharp
public struct I2cTransferResult
```

## Properties

### Status

```csharp
public I2cTransferStatus Status { get; }
```

Whether the transfer was full, partial, NAK'd, or timed out.

### BytesWritten

```csharp
public int BytesWritten { get; }
```

Bytes actually written.

### BytesRead

```csharp
public int BytesRead { get; }
```

Bytes actually read.

### BytesTransferred

```csharp
public int BytesTransferred { get; }
```

Sum of `BytesWritten` and `BytesRead`.
