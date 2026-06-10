---
title: "FileStream Class"
sidebar_label: "FileStream"
---

# FileStream Class

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `System.IO`

A read/write stream backed by a file on a mounted file system. Construct via `File.OpenRead(string)` / `File.OpenWrite(string)` / `File.Create(string)`.

```csharp
public class FileStream : Stream
```

## Constructors

### FileStream(string path, FileMode mode)

```csharp
public FileStream(string path, FileMode mode) : this(path, mode, (mode == FileMode.Append ? FileAccess.Write : FileAccess.ReadWrite), FileShare.Read, FileStream.BufferSizeDefault)
```

Opens the file at the path with the given mode.

### FileStream(string path, FileMode mode, FileAccess access)

```csharp
public FileStream(string path, FileMode mode, FileAccess access) : this(path, mode, access, FileShare.Read, FileStream.BufferSizeDefault)
```

Opens the file at the path with the given mode and access.

### FileStream(string path, FileMode mode, FileAccess access, FileShare share)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share) : this(path, mode, access, share, FileStream.BufferSizeDefault)
```

Opens the file at the path with the given mode, access, and sharing.

### FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
```

Opens the file at the path with the given mode, access, sharing, and buffer size.

## Properties

### CanRead

```csharp
public override bool CanRead { get; }
```

Whether the stream supports reading.

### CanWrite

```csharp
public override bool CanWrite { get; }
```

Whether the stream supports writing.

### CanSeek

```csharp
public override bool CanSeek { get; }
```

Whether the stream supports seeking.

### IsAsync

```csharp
public virtual bool IsAsync { get; }
```

Whether the stream operates asynchronously; always false.

### Length

```csharp
public override long Length { get; }
```

The length of the file in bytes.

### Name

```csharp
public string Name { get; }
```

The full path of the file the stream was opened on.

### Position

```csharp
public override long Position { get; set; }
```

The current byte position within the file.

## Methods

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Closes the file and releases the stream's resources.

### Flush()

```csharp
public override void Flush()
```

Flushes buffered data to the file.

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

Sets the length of the file.

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

Reads bytes from the file into the buffer.

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

Moves the file position.

**Returns** `long`

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

Writes bytes from the buffer to the file.
