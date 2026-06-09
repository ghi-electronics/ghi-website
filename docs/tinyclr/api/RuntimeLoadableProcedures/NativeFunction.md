---
title: "NativeFunction Class"
sidebar_label: "NativeFunction"
---

# NativeFunction Class

**NuGet:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`<br/>**Assembly:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`<br/>**Namespace:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`

Wraps a native function located at a known address. The first call to `Invoke` fixes the argument count and types; subsequent calls must match. Supported argument types: 8/16/32/64-bit integers (signed and unsigned), float, double, bool, and arrays of those types.

```csharp
public sealed class NativeFunction : IDisposable
```

## Constructors

### NativeFunction(uint address)

```csharp
public NativeFunction(uint address)
```

Constructs a `NativeFunction` pointing at the given address.

| Parameter | Type | Description |
|---|---|---|
| `address` | `uint` |  |

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases interop resources associated with this function.

### Invoke(params object[] arguments)

```csharp
public int Invoke(params object[] arguments)
```

Calls the native function with the given arguments and returns its 32-bit return value. The first invocation locks the argument count; subsequent calls must pass the same number of arguments.

| Parameter | Type | Description |
|---|---|---|
| `arguments` | `params object[]` | Arguments to pass. Supported types: integer (any width, signed or unsigned), float, double, bool, and arrays of those. |

**Returns** `int` — The function's int return value.
