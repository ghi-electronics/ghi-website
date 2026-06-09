---
title: "GHIElectronics.TinyCLR.Native"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Native NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [DeviceInformation](./DeviceInformation.md) | `GHIElectronics.TinyCLR.Native` | Read-only metadata about the running device (name, manufacturer, firmware version) plus debug-interface and unique-ID controls. |
| [Flash](./Flash.md) | `GHIElectronics.TinyCLR.Native` | Controls how the firmware uses the device's flash storage. Most apps don't need this — call `EnableExtendDeployment` only on devices with external flash that should be used to extend the deployment region. |
| [Interop](./Interop.md) | `GHIElectronics.TinyCLR.Native` | Represents an interop module — a native C library whose methods are callable from managed code via `[MethodImpl(InternalCall)]`. Use `FindAll` to enumerate every interop module the firmware exposes. |
| [Interrupt](./Interrupt.md) | `GHIElectronics.TinyCLR.Native` | CPU interrupt mask. Wrap a tight critical section in `Disable`/`Enable` to prevent context switches and hardware interrupts from running during it. Keep the disabled window short — while interrupts are off, RTOS threads cannot preempt and ISR latencies grow. |
| [Memory](./Memory.md) | `GHIElectronics.TinyCLR.Native` | Allocator façade exposing both the managed (GC) heap and the unmanaged heap. Most apps don't touch this directly — use `UnmanagedBuffer` when you need a fixed-address byte buffer (for DMA, native interop, etc.). |
| [NativeApi](./NativeApi.md) | `GHIElectronics.TinyCLR.Native` | Handle to a native API surfaced by the firmware. Use `Find` to obtain a specific API by name, or `FindAll` to enumerate everything the firmware exposes. |
| [NativeEventDispatcher](./NativeEventDispatcher.md) | `GHIElectronics.TinyCLR.Native` | Marshals native ISR events to managed handlers. One dispatcher exists per well-known event name (e.g. `GHIElectronics.TinyCLR.NativeEventNames.Gpio.PinChanged`); retrieve the singleton with `GetDispatcher(string)` and subscribe to `OnInterrupt`. The first subscription enables the native interrupt; removing the last one disables it. |
| [Power](./Power.md) | `GHIElectronics.TinyCLR.Native` | Power-management entry points: `Reset` for a soft reset, `Sleep()` for low-power stop with wake-up, `Shutdown` for power-off with RTC/pin wake-up, and `SetSystemClock` for dynamic clock scaling. |
| [SystemTime](./SystemTime.md) | `GHIElectronics.TinyCLR.Native` | Reads and writes the system wall clock (separate from the `GHIElectronics.TinyCLR.Devices.Rtc.RtcController` chip register). Time zone is carried as a minutes-from-UTC offset. |
| [UnmanagedBuffer](./UnmanagedBuffer.md) | `GHIElectronics.TinyCLR.Native` | A fixed-address byte buffer suitable for DMA targets and native interop. The `Bytes` property exposes it as a regular byte[]. Dispose to release the underlying memory. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IApiImplementation](./IApiImplementation.md) | `GHIElectronics.TinyCLR.Native` | Implemented by managed wrappers that expose their underlying native handle. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DebugInterface](./DebugInterface.md) | `GHIElectronics.TinyCLR.Native` | Transport used by the debugger to attach to the device. |
| [NativeApiType](./NativeApiType.md) | `GHIElectronics.TinyCLR.Native` |  |
| [ResetSource](./ResetSource.md) | `GHIElectronics.TinyCLR.Native` | Reasons reported by `Power.GetResetSource`. |
| [SystemClock](./SystemClock.md) | `GHIElectronics.TinyCLR.Native` | Core-clock profile. |
| [UnmanagedBufferLocation](./UnmanagedBufferLocation.md) | `GHIElectronics.TinyCLR.Native` | Which heap an `UnmanagedBuffer` draws from. |
| [WakeupEdge](./WakeupEdge.md) | `GHIElectronics.TinyCLR.Native` | Polarity of the wake-up pin. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [DefaultCreator](./DefaultCreator.md) | `GHIElectronics.TinyCLR.Native` | Factory used when a managed library asks for the "default" API of a given type. |
| [NativeEventHandler](./NativeEventHandler.md) | `GHIElectronics.TinyCLR.Native` | Handler signature for `NativeEventDispatcher.OnInterrupt`. |
