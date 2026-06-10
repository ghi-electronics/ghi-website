---
title: "IStorageControllerProvider Interface"
sidebar_label: "IStorageControllerProvider"
---

# IStorageControllerProvider Interface

**NuGet:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Storage.Provider`

Provider contract for a block-storage controller.

```csharp
public interface IStorageControllerProvider : IDisposable
```

## Properties

### Descriptor

```csharp
StorageDescriptor Descriptor { get; }
```

Media geometry and capabilities.

## Methods

### Open()

```csharp
void Open()
```

Powers on and initializes the media.

### Close()

```csharp
void Close()
```

Powers off the media.

### Read(long address, int count, byte[] buffer, int offset, TimeSpan timeout)

```csharp
int Read(long address, int count, byte[] buffer, int offset, TimeSpan timeout)
```

Reads `count` bytes from `address` into `buffer`+`offset`.

**Returns** `int`

### Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)

```csharp
int Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)
```

Writes `count` bytes from `buffer`+`offset` to `address`.

**Returns** `int`

### Erase(long address, int count, TimeSpan timeout)

```csharp
int Erase(long address, int count, TimeSpan timeout)
```

Erases `count` sectors starting at `address`.

**Returns** `int`

### IsErased(long address, int count)

```csharp
bool IsErased(long address, int count)
```

True when the addressed span is in its erased (all-0xFF) state.

**Returns** `bool`

### EraseAll(TimeSpan timeout)

```csharp
void EraseAll(TimeSpan timeout)
```

Erases every sector on the media.
