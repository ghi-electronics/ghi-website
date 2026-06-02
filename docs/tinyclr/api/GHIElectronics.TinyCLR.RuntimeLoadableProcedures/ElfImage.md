---
title: "ElfImage Class"
sidebar_label: "ElfImage"
---

# ElfImage Class

**Namespace:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` · **Assembly:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`

A loaded ELF binary. Construct with the ELF bytes, look up symbols by name, then build a `NativeFunction` from a function-symbol's address to call it.

```csharp
public sealed class ElfImage : IDisposable
```

## Constructors

### ElfImage(byte[] elfImageData)

```csharp
public ElfImage(byte[] elfImageData)
```

Loads an ELF image into device memory.

| Parameter | Type | Description |
|---|---|---|
| `elfImageData` | `byte[]` | ELF binary bytes. |

## Properties

### Size

```csharp
public uint Size { get; }
```

Total size of the loaded image.

### RegionCount

```csharp
public uint RegionCount { get; }
```

Number of distinct ELF regions loaded.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Unloads the image from device memory.

### FindSymbolAddress(string name, SymbolType type)

```csharp
public uint FindSymbolAddress(string name, SymbolType type)
```

Looks up a symbol by name and type.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` | Symbol name. |
| `type` | `SymbolType` | Symbol classification. |

**Returns** `uint` — Symbol's runtime address, or 0 if not found.

### FindFunction(string name)

```csharp
public NativeFunction FindFunction(string name)
```

Locates a function symbol and wraps it in a `NativeFunction`.

| Parameter | Type | Description |
|---|---|---|
| `name` | `string` |  |

**Returns** `NativeFunction`

### InitializeBssRegion()

```csharp
public void InitializeBssRegion()
```

Zero-initializes the loaded image's BSS region using the standard `__bss_start__`/`__bss_end__` symbols.

### InitializeBssRegion(string startSymbolName, string endSymbolName)

```csharp
public void InitializeBssRegion(string startSymbolName, string endSymbolName)
```

Zero-initializes the region delimited by two symbols.

| Parameter | Type | Description |
|---|---|---|
| `startSymbolName` | `string` | Symbol marking the start of the region. |
| `endSymbolName` | `string` | Symbol marking the end of the region. |

### ZeroRegion(uint address, uint length)

```csharp
public void ZeroRegion(uint address, uint length)
```

Zero-fills a span of `length` bytes starting at `address`.

| Parameter | Type | Description |
|---|---|---|
| `address` | `uint` |  |
| `length` | `uint` |  |
