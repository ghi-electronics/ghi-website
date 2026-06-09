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

_No description available._

### FileStream(string path, FileMode mode, FileAccess access)

```csharp
public FileStream(string path, FileMode mode, FileAccess access) : this(path, mode, access, FileShare.Read, FileStream.BufferSizeDefault)
```

_No description available._

### FileStream(string path, FileMode mode, FileAccess access, FileShare share)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share) : this(path, mode, access, share, FileStream.BufferSizeDefault)
```

_No description available._

### FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)

```csharp
public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
```

_No description available._

## Properties

### CanRead

```csharp
public override bool CanRead { get; }
```

_No description available._

### CanWrite

```csharp
public override bool CanWrite { get; }
```

_No description available._

### CanSeek

```csharp
public override bool CanSeek { get; }
```

_No description available._

### IsAsync

```csharp
public virtual bool IsAsync { get; }
```

_No description available._

### Length

```csharp
public override long Length { get; }
```

_No description available._

### Name

```csharp
public string Name { get; }
```

_No description available._

### Position

```csharp
public override long Position { get; set; }
```

_No description available._

## Methods

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

_No description available._

### Flush()

```csharp
public override void Flush()
```

_No description available._

### SetLength(long value)

```csharp
public override void SetLength(long value)
```

_No description available._

### Read(byte[] buffer, int offset, int count)

```csharp
public override int Read(byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
public override long Seek(long offset, SeekOrigin origin)
```

_No description available._

**Returns** `long`

### Write(byte[] buffer, int offset, int count)

```csharp
public override void Write(byte[] buffer, int offset, int count)
```

_No description available._
