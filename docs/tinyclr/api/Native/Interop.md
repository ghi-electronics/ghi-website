---
title: "Interop Class"
sidebar_label: "Interop"
---

# Interop Class

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

Represents an interop module — a native C library whose methods are callable from managed code via `[MethodImpl(InternalCall)]`. Use `FindAll` to enumerate every interop module the firmware exposes.

```csharp
public sealed class Interop
```

## Properties

### Name

```csharp
public string Name { get; }
```

The interop module's assembly name.

### Checksum

```csharp
public uint Checksum { get; }
```

CRC of the module's interop table — must match the managed assembly.

### Methods

```csharp
public IntPtr Methods { get; }
```

Pointer to the module's method-dispatch table.

## Methods

### FindAll()

```csharp
public static extern Interop[] FindAll()
```

Returns every interop module registered with the runtime.

**Returns** `Interop[]`
