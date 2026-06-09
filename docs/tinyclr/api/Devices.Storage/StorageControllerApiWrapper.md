---
title: "StorageControllerApiWrapper Class"
sidebar_label: "StorageControllerApiWrapper"
---

# StorageControllerApiWrapper Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Storage.Provider`

Concrete `IStorageControllerProvider` backed by the native TinyCLR storage HAL.

```csharp
public sealed class StorageControllerApiWrapper : IStorageControllerProvider, IApiImplementation
```

## Constructors

### StorageControllerApiWrapper(NativeApi api)

```csharp
public StorageControllerApiWrapper(NativeApi api)
```

Wraps the given native API as a provider.

## Properties

### Api

```csharp
public NativeApi Api { get; }
```

The underlying native API descriptor.

### Descriptor

```csharp
public extern StorageDescriptor Descriptor { get; }
```

Media geometry and capabilities. _(inherited)_

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases the native controller.

### Open()

```csharp
public extern void Open()
```

Powers on and initializes the media. _(inherited)_

### Close()

```csharp
public extern void Close()
```

Powers off the media. _(inherited)_

### Read(long address, int count, byte[] buffer, int offset, TimeSpan timeout)

```csharp
public extern int Read(long address, int count, byte[] buffer, int offset, TimeSpan timeout)
```

Reads `count` bytes from `address` into `buffer`+`offset`. _(inherited)_

**Returns** `int`

### Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)

```csharp
public extern int Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)
```

Writes `count` bytes from `buffer`+`offset` to `address`. _(inherited)_

**Returns** `int`

### Erase(long sector, int count, TimeSpan timeout)

```csharp
public extern int Erase(long sector, int count, TimeSpan timeout)
```

Erases `count` sectors starting at `address`. _(inherited)_

**Returns** `int`

### IsErased(long address, int count)

```csharp
public extern bool IsErased(long address, int count)
```

True when the addressed span is in its erased (all-0xFF) state. _(inherited)_

**Returns** `bool`

### EraseAll(TimeSpan timeout)

```csharp
public extern void EraseAll(TimeSpan timeout)
```

Erases every sector on the media. _(inherited)_
