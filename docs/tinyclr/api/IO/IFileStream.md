---
title: "IFileStream Interface"
sidebar_label: "IFileStream"
---

# IFileStream Interface

**NuGet:** `GHIElectronics.TinyCLR.IO`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO`

_No description available._

```csharp
public interface IFileStream
```

## Properties

### CanWrite

```csharp
bool CanWrite { get; }
```

_No description available._

### CanRead

```csharp
bool CanRead { get; }
```

_No description available._

### CanSeek

```csharp
bool CanSeek { get; }
```

_No description available._

### Length

```csharp
long Length { get; set; }
```

_No description available._

## Methods

### Read(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Read(byte[] buffer, int offset, int count, TimeSpan timeout)
```

_No description available._

**Returns** `int`

### Write(byte[] buffer, int offset, int count, TimeSpan timeout)

```csharp
int Write(byte[] buffer, int offset, int count, TimeSpan timeout)
```

_No description available._

**Returns** `int`

### Seek(long offset, SeekOrigin origin)

```csharp
long Seek(long offset, SeekOrigin origin)
```

_No description available._

**Returns** `long`

### Flush()

```csharp
void Flush()
```

_No description available._

### Close()

```csharp
void Close()
```

_No description available._
