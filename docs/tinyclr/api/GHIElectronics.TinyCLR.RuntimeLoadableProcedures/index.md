---
title: "GHIElectronics.TinyCLR.RuntimeLoadableProcedures"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">RuntimeLoadableProcedures Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [ElfImage](./ElfImage.md) | `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` | A loaded ELF binary. Construct with the ELF bytes, look up symbols by name, then build a `NativeFunction` from a function-symbol's address to call it. |
| [NativeFunction](./NativeFunction.md) | `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` | Wraps a native function located at a known address. The first call to `Invoke` fixes the argument count and types; subsequent calls must match. Supported argument types: 8/16/32/64-bit integers (signed and unsigned), float, double, bool, and arrays of those types. |
| [RuntimeLoadableProcedures](./RuntimeLoadableProcedures.md) | `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` | Runtime Loadable Procedures (RLP) — load a compiled ELF blob onto the device at runtime, look up symbols by name, and call native C functions from managed code. Useful for shipping hardware-accelerated routines (DSP, image processing) without rebuilding the firmware. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [SymbolType](./SymbolType.md) | `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` | Classification of an ELF symbol. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [NativeEventHandler](./NativeEventHandler.md) | `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` | Handler signature for `NativeEvent`. The argument is whatever the native code passed to `RLP_PostManagedEvent`. |
