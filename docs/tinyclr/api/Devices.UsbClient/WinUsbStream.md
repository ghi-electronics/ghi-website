---
title: "WinUsbStream Class"
sidebar_label: "WinUsbStream"
---

# WinUsbStream Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

Stream for reading and writing data over a CDC connection.

```csharp
public class WinUsbStream : RawDevice.RawStream
```

## Properties

### DataAvailable

```csharp
public override bool DataAvailable { get; }
```

_No description available._

## Methods

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

Writes data to the stream.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The buffer from which to write. |
| `offset` | `int` | The offset into the buffer at which to begin writing. |
| `count` | `int` | The number of bytes to write. |
