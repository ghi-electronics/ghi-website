---
title: "GHIElectronics.TinyCLR.Native"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Native

NuGet package containing **19** types.

## Classes

| Class | Summary |
|---|---|
| [DeviceInformation](./DeviceInformation.md) | Read-only metadata about the running device (name, manufacturer, firmware version) plus debug-interface and unique-ID controls. |
| [Flash](./Flash.md) | Controls how the firmware uses the device's flash storage. Most apps don't need this — call `EnableExtendDeployment` only on devices with external flash that should be used to extend the deployment region. |
| [Interop](./Interop.md) | Represents an interop module — a native C library whose methods are callable from managed code via `[MethodImpl(InternalCall)]`. Use `FindAll` to enumerate every interop module the firmware exposes. |
| [Interrupt](./Interrupt.md) | CPU interrupt mask. Wrap a tight critical section in `Disable`/`Enable` to prevent context switches and hardware interrupts from running during it. Keep the disabled window short — while interrupts are off, RTOS threads cannot preempt and ISR latencies grow. |
| [Memory](./Memory.md) | Allocator façade exposing both the managed (GC) heap and the unmanaged heap. Most apps don't touch this directly — use `UnmanagedBuffer` when you need a fixed-address byte buffer (for DMA, native interop, etc.). |
| [NativeApi](./NativeApi.md) | Handle to a native API surfaced by the firmware. Use `Find` to obtain a specific API by name, or `FindAll` to enumerate everything the firmware exposes. |
| [NativeEventDispatcher](./NativeEventDispatcher.md) | Marshals native ISR events to managed handlers. One dispatcher exists per well-known event name (e.g. `GHIElectronics.TinyCLR.NativeEventNames.Gpio.PinChanged`); retrieve the singleton with `GetDispatcher(string)` and subscribe to `OnInterrupt`. The first subscription enables the native interrupt; removing the last one disables it. |
| [Power](./Power.md) | Power-management entry points: `Reset` for a soft reset, `Sleep()` for low-power stop with wake-up, `Shutdown` for power-off with RTC/pin wake-up, and `SetSystemClock` for dynamic clock scaling. |
| [SystemTime](./SystemTime.md) | Reads and writes the system wall clock (separate from the `GHIElectronics.TinyCLR.Devices.Rtc.RtcController` chip register). Time zone is carried as a minutes-from-UTC offset. |
| [UnmanagedBuffer](./UnmanagedBuffer.md) | A fixed-address byte buffer suitable for DMA targets and native interop. The `Bytes` property exposes it as a regular byte[]. Dispose to release the underlying memory. |

## Interfaces

| Interface | Summary |
|---|---|
| [IApiImplementation](./IApiImplementation.md) | Implemented by managed wrappers that expose their underlying native handle. |

## Enums

| Enum | Summary |
|---|---|
| [DebugInterface](./DebugInterface.md) | Transport used by the debugger to attach to the device. |
| [NativeApiType](./NativeApiType.md) |  |
| [ResetSource](./ResetSource.md) | Reasons reported by `Power.GetResetSource`. |
| [SystemClock](./SystemClock.md) | Core-clock profile. |
| [UnmanagedBufferLocation](./UnmanagedBufferLocation.md) | Which heap an `UnmanagedBuffer` draws from. |
| [WakeupEdge](./WakeupEdge.md) | Polarity of the wake-up pin. |

## Delegates

| Delegate | Summary |
|---|---|
| [DefaultCreator](./DefaultCreator.md) | Factory used when a managed library asks for the "default" API of a given type. |
| [NativeEventHandler](./NativeEventHandler.md) | Handler signature for `NativeEventDispatcher.OnInterrupt`. |
