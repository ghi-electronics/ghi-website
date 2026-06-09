---
title: "Webcam Class"
sidebar_label: "Webcam"
---

# Webcam Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Allows a USB webcam (UVC class, YUY2 uncompressed) to be used.

```csharp
public class Webcam : BaseDevice
```

## Constructors

### Webcam(uint id, byte interfaceIndex)

```csharp
public Webcam(uint id, byte interfaceIndex) : base(id, interfaceIndex, DeviceType.Webcam)
```

Constructs a webcam wrapper for a connected UVC camera.

| Parameter | Type | Description |
|---|---|---|
| `id` | `uint` | Device id from the connection event. |
| `interfaceIndex` | `byte` | VideoControl interface index from the connection event. |

## Properties

### IsStreaming

```csharp
public bool IsStreaming { get; }
```

True while the camera is streaming.

### IsMjpeg

```csharp
public bool IsMjpeg { get; }
```

True if the active stream is MJPEG (caller must JPEG-decode); false for YUY2 (use `ConvertYuy2ToRgb565`).

### Width

```csharp
public int Width { get; }
```

The negotiated frame width in pixels (valid while streaming).

### Height

```csharp
public int Height { get; }
```

The negotiated frame height in pixels (valid while streaming).

### FrameSize

```csharp
public int FrameSize { get; }
```

Bytes per frame, RGB565 (= Width * Height * 2). Valid while streaming.

### SupportedFormats

```csharp
public Format[] SupportedFormats { get; }
```

The camera's supported YUY2 formats (queried at construction).

## Methods

### StartStreaming(Format format, int fps)

```csharp
public void StartStreaming(Format format, int fps = 15)
```

Starts streaming the chosen format. Allocates the device-side double buffer.

| Parameter | Type | Description |
|---|---|---|
| `format` | `Format` | One of the entries from `SupportedFormats`. |
| `fps` | `int` | Requested frame rate. Default is `15` — the slowest rate that virtually every UVC camera supports, so it's the broadest-compatibility starting point. Pass `0` to use the camera's own default rate (typically 30 fps) from the frame descriptor. Any other value asks the camera for that rate; the camera rounds to its nearest supported value (visible in the PROBE GET_CUR exchange). Use this to throttle a camera that produces faster than your application can consume: cheap UVC cameras often have an internal FIFO and produce at their max rate regardless. If you can render at 10 fps but the camera produces at 30, 20 fps of frames pile up in its FIFO per second, manifesting as a several-second "playback delayed behind reality" lag. Setting `fps` to match your app's processing rate keeps producer and consumer aligned and eliminates the lag. When the camera refuses to go below its minimum supported rate, use `Resync` periodically to flush its internal FIFO instead. |

### Resync(bool soft)

```csharp
public void Resync(bool soft = false)
```

Flushes any frames the camera has queued in its internal sensor->encoder FIFO.

| Parameter | Type | Description |
|---|---|---|
| `soft` | `bool` | `false` (default) — hard flush via streaming alt-setting toggle. Definitive on every UVC camera but ~500-1000 ms blackout because the camera reboots its sensor pipeline. `true` — soft flush, replays the previously negotiated SET_CUR (Commit) only. ~20 ms blackout. Camera-dependent: some cameras flush their FIFO on commit-during-streaming, others ignore it and the call is effectively a no-op. Try once on your specific camera and fall back to `false` if the lag doesn't drop. |

### StopStreaming()

```csharp
public void StopStreaming()
```

Stops streaming and frees device-side buffers.

### IsNewFrameAvailable()

```csharp
public bool IsNewFrameAvailable()
```

Returns true and clears the flag if a new frame is ready since the last call.

**Returns** `bool`

### GetFrame(byte[] buffer)

```csharp
public int GetFrame(byte[] buffer)
```

Copies the most recently completed frame into `buffer` as raw bytes.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | Destination buffer. Must be at least `FrameSize` bytes (which is the upper bound; actual size returned). |

**Returns** `int` — Actual number of bytes written. For YUY2 always `Width*Height*2`. For MJPEG, varies per frame.

### ConvertYuy2ToRgb565(byte[] yuy2, byte[] rgb565)

```csharp
public static void ConvertYuy2ToRgb565(byte[] yuy2, byte[] rgb565)
```

Converts a YUY2 (YUYV-packed) buffer to RGB565 in place into `rgb565`.

| Parameter | Type | Description |
|---|---|---|
| `yuy2` | `byte[]` | Source buffer with YUY2-packed pixels (Y1 U Y2 V tuples). |
| `rgb565` | `byte[]` | Destination buffer for RGB565 pixels (2 bytes per pixel). |

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Disposes the webcam, stopping any active stream.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` |  |

### CheckEvents(object sender)

```csharp
protected override void CheckEvents(object sender)
```

Polled by BaseDevice's worker; raises FrameAvailable when a new frame lands.

| Parameter | Type | Description |
|---|---|---|
| `sender` | `object` |  |

## Events

### FrameAvailable

```csharp
public event FrameAvailableEventHandler FrameAvailable
```

Raised on the BaseDevice worker thread when a new frame is available.
