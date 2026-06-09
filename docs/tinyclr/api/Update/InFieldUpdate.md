---
title: "InFieldUpdate Class"
sidebar_label: "InFieldUpdate"
---

# InFieldUpdate Class

**NuGet:** `GHIElectronics.TinyCLR.Update`<br/>**Assembly:** `GHIElectronics.TinyCLR.Update`<br/>**Namespace:** `GHIElectronics.TinyCLR.Update`

In-Field Update — feed firmware and/or application bytes in chunks, verify the signatures, then flash and reboot. Supports caching the chunks in RAM (faster) or to an external `StorageController` (handles images larger than free RAM).

```csharp
public class InFieldUpdate : IDisposable
```

## Constructors

### InFieldUpdate()

```csharp
public InFieldUpdate()
```

Creates a RAM-cached updater.

### InFieldUpdate(StorageController storageController)

```csharp
public InFieldUpdate(StorageController storageController)
```

Creates a flash-cached updater backed by an external storage device. Use for images that don't fit in RAM.

## Properties

### ActivityPin

```csharp
public GpioPin ActivityPin { get; set; }
```

Optional pin to toggle during long-running update operations (visual progress LED).

## Methods

### LoadApplicationKey(byte[] key)

```csharp
public void LoadApplicationKey(byte[] key)
```

Loads the public key used to verify the application image.

### LoadApplicationChunk(byte[] data, int offset, int size)

```csharp
public int LoadApplicationChunk(byte[] data, int offset, int size)
```

Appends a chunk of bytes to the buffered application image.

**Returns** `int` — Number of bytes accepted.

### LoadFirmwareChunk(byte[] data, int offset, int size)

```csharp
public int LoadFirmwareChunk(byte[] data, int offset, int size)
```

Appends a chunk of bytes to the buffered firmware image.

**Returns** `int` — Number of bytes accepted.

### VerifyApplication()

```csharp
public string VerifyApplication()
```

Verifies the application signature without flashing. Returns the embedded version string, or "Invalid." on failure.

**Returns** `string`

### VerifyFirmware()

```csharp
public string VerifyFirmware()
```

Verifies the firmware signature without flashing. Returns the embedded version string, or "Invalid." on failure.

**Returns** `string`

### ResetChunks()

```csharp
public void ResetChunks()
```

Discards every buffered chunk and rewinds both write indices to zero.

### FlashAndReset()

```csharp
public void FlashAndReset()
```

Verifies any buffered images, writes them to their destination regions, and resets the device. Does not return on success.

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers).

### VersionConvertToString(uint version)

```csharp
public static string VersionConvertToString(uint version)
```

Formats a packed 32-bit version (major.minor.build.revision) as a dotted string.

**Returns** `string`
