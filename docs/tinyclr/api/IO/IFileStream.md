---
title: "IFileStream Interface"
sidebar_label: "IFileStream"
---

# IFileStream Interface

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

A low-level file stream supplied by a drive provider.

```csharp
public interface IFileStream
```

## Properties

### CanWrite

```csharp
bool CanWrite { get; }
```

Whether the stream supports writing.

### CanRead

```csharp
bool CanRead { get; }
```

Whether the stream supports reading.

### CanSeek

```csharp
bool CanSeek { get; }
```

Whether the stream supports seeking.

### Length

```csharp
long Length { get; set; }
```

The length of the stream in bytes.

## Methods

### Read(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Read(byte[] buffer, int offset, int count, TimeSpan timeout)
```

Reads up to count bytes into the buffer, returning the number read.

**Returns** `int`

### Write(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Write(byte[] buffer, int offset, int count, TimeSpan timeout)
```

Writes count bytes from the buffer, returning the number written.

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
long Seek(long offset, SeekOrigin origin)
```

Moves the stream position relative to the given origin and returns the new position.

**Returns** `long`

### Flush()

```csharp
void Flush()
```

Flushes any buffered data to the underlying store.

### Close()

```csharp
void Close()
```

Closes the stream.
