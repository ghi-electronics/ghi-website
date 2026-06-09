---
title: "IFileStream Interface"
sidebar_label: "IFileStream"
---

# IFileStream Interface

**Namespace:** `GHIElectronics.TinyCLR.IO` · **Assembly:** `GHIElectronics.TinyCLR.IO`

_No description available._

```csharp
public interface IFileStream
```

## Properties

### CanWrite

```csharp
bool CanWrite { get; }
```

Gets a value indicating whether the current stream supports writing. _(inherited)_

### CanRead

```csharp
bool CanRead { get; }
```

Gets a value indicating whether the current stream supports reading. _(inherited)_

### CanSeek

```csharp
bool CanSeek { get; }
```

Gets a value indicating whether the current stream supports seeking. _(inherited)_

### Length

```csharp
long Length { get; set; }
```

Gets length of bytes in the stream. _(inherited)_

## Methods

### Read(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Read(byte[] buffer, int offset, int count, TimeSpan timeout)
```

Captures a slice of inter-edge intervals after waiting for `waitForState`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `timeout` | `TimeSpan` |  |

**Returns** `int`

### Write(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Write(byte[] buffer, int offset, int count, TimeSpan timeout)
```

Writes `length` bytes; optional trailing break of `breakDuration`. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `count` | `int` |  |
| `timeout` | `TimeSpan` |  |

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
long Seek(long offset, SeekOrigin origin)
```

Sets the current position of this stream to a given value. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `offset` | `long` | The offset of the positon relative to the origin. |
| `origin` | `SeekOrigin` | Specified the beginning, end or current postion as a reference point to apply the offset. |

**Returns** `long` — The new postion in the stream.

### Flush()

```csharp
void Flush()
```

Writes unwritten data to the file. _(inherited)_

### Close()

```csharp
void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_
