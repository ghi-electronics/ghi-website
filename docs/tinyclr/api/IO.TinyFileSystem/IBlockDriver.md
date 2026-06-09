---
title: "IBlockDriver Interface"
sidebar_label: "IBlockDriver"
---

# IBlockDriver Interface

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

Interface to abstract the file system from the physical device.

```csharp
public interface IBlockDriver : IDisposable
```

## Properties

### DeviceSize

```csharp
int DeviceSize { get; }
```

Full capacity of the device in bytes.

### SectorSize

```csharp
int SectorSize { get; }
```

The size in bytes of a sector on the device.

### ClusterSize

```csharp
ushort ClusterSize { get; }
```

The cluster size in bytes.

## Methods

### EraseChip()

```csharp
void EraseChip()
```

Completely erases the memory chip (fills it with 0xFF, in reality, as it is a Flash memory).

### EraseSector(int sectorId)

```csharp
void EraseSector(int sectorId)
```

Erases a sector on the device.

| Parameter | Type | Description |
|---|---|---|
| `sectorId` | `int` | Sector to be erased. |

### Read(ushort clusterId, int clusterOffset, byte[] data, int index, int count)

```csharp
void Read(ushort clusterId, int clusterOffset, byte[] data, int index, int count)
```

Read a block of data from a cluster.

| Parameter | Type | Description |
|---|---|---|
| `clusterId` | `ushort` | The cluster to read from. |
| `clusterOffset` | `int` | The offset into the cluster to start reading from. |
| `data` | `byte[]` | The byte array to fill with the data read from the device. |
| `index` | `int` | The index into the array to start filling the data. |
| `count` | `int` | The maximum number of bytes to read. |

### Write(ushort clusterId, int clusterOffset, byte[] data, int index, int count)

```csharp
void Write(ushort clusterId, int clusterOffset, byte[] data, int index, int count)
```

Write a block of data to a cluster.

| Parameter | Type | Description |
|---|---|---|
| `clusterId` | `ushort` | The cluster to write to. |
| `clusterOffset` | `int` | The offset into the cluster to start writting to. |
| `data` | `byte[]` | The byte array containing the data to be written. |
| `index` | `int` | The index into the array to start writting from |
| `count` | `int` | The number of bytes to write. |
