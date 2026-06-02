---
title: "IStorageControllerProvider Interface"
sidebar_label: "IStorageControllerProvider"
---

# IStorageControllerProvider Interface

**Namespace:** `GHIElectronics.TinyCLR.Devices.Storage.Provider` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Storage`

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

| Parameter | Type | Description |
|---|---|---|
| `address` | `long` |  |
| `count` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `timeout` | `TimeSpan` |  |

**Returns** `int`

### Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)

```csharp
int Write(long address, int count, byte[] buffer, int offset, TimeSpan timeout)
```

Writes `count` bytes from `buffer`+`offset` to `address`.

| Parameter | Type | Description |
|---|---|---|
| `address` | `long` |  |
| `count` | `int` |  |
| `buffer` | `byte[]` |  |
| `offset` | `int` |  |
| `timeout` | `TimeSpan` |  |

**Returns** `int`

### Erase(long address, int count, TimeSpan timeout)

```csharp
int Erase(long address, int count, TimeSpan timeout)
```

Erases `count` sectors starting at `address`.

| Parameter | Type | Description |
|---|---|---|
| `address` | `long` |  |
| `count` | `int` |  |
| `timeout` | `TimeSpan` |  |

**Returns** `int`

### IsErased(long address, int count)

```csharp
bool IsErased(long address, int count)
```

True when the addressed span is in its erased (all-0xFF) state.

| Parameter | Type | Description |
|---|---|---|
| `address` | `long` |  |
| `count` | `int` |  |

**Returns** `bool`

### EraseAll(TimeSpan timeout)

```csharp
void EraseAll(TimeSpan timeout)
```

Erases every sector on the media.

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `TimeSpan` |  |
