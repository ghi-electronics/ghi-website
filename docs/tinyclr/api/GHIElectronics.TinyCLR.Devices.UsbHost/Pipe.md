---
title: "Pipe Class"
sidebar_label: "Pipe"
---

# Pipe Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost`

A USB communication pipe.

```csharp
public class Pipe : IDisposable
```

## Properties

### Endpoint

```csharp
public Descriptors.Endpoint Endpoint { get; set; }
```

Endpoint associated with this pipe.

## Methods

### Transfer(byte[] buffer)

```csharp
public int Transfer(byte[] buffer)
```

Transfers data to/from the endpoint.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The transfer buffer. |

**Returns** `int` — The number of bytes successfully transferred.

### Transfer(byte[] buffer, int offset, int count)

```csharp
public int Transfer(byte[] buffer, int offset, int count)
```

Transfers data to/from the endpoint.

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` | The transfer buffer. |
| `offset` | `int` | The offset into the buffer. |
| `count` | `int` | The amount to transfer starting at offset from the buffer. |

**Returns** `int` — The number of bytes successfully transferred.

### Dispose()

```csharp
public void Dispose()
```

Disconnects and disposes the device.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Disconnects and disposes the device.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Whether or not this is called from Dispose. |
