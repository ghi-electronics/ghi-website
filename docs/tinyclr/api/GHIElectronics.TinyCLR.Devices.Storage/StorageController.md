---
title: "StorageController Class"
sidebar_label: "StorageController"
---

# StorageController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Storage`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Storage`

Represents a block-storage device — internal flash, external SPI/SD flash, SD/MMC, or USB mass-storage. Use `Hdc` to mount the controller with the file-system stack, or call the provider's Read/Write/Erase methods directly for raw block access.

```csharp
public class StorageController : IDisposable
```

## Properties

### Provider

```csharp
public IStorageControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### Hdc

```csharp
public IntPtr Hdc { get; }
```

Native handle (HDC) of the underlying provider, for use with the file-system mount API.

### Descriptor

```csharp
public StorageDescriptor Descriptor { get; }
```

Reports the media's block layout and capabilities.

## Methods

### GetDefault()

```csharp
public static StorageController GetDefault()
```

Returns the default storage controller for this device.

**Returns** `StorageController`

### FromName(string name)

```csharp
public static StorageController FromName(string name)
```

Returns a storage controller identified by its native API name.

**Returns** `StorageController`

### FromProvider(IStorageControllerProvider provider)

```csharp
public static StorageController FromProvider(IStorageControllerProvider provider)
```

Creates a controller from a custom `IStorageControllerProvider`.

**Returns** `StorageController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Open()

```csharp
public void Open()
```

Powers on and initializes the underlying media.

### Close()

```csharp
public void Close()
```

Powers off the underlying media.
