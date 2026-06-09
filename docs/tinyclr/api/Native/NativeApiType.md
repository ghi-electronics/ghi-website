---
title: "NativeApiType Enum"
sidebar_label: "NativeApiType"
---

# NativeApiType Enum

**NuGet:** `GHIElectronics.TinyCLR.Native`<br/>**Assembly:** `GHIElectronics.TinyCLR.Native`<br/>**Namespace:** `GHIElectronics.TinyCLR.Native`

_No description available._

```csharp
public enum NativeApiType : uint
```

## Fields

| Name | Value | Description |
|---|---|---|
| `ApiManager` | `0` | API manager itself. |
| `DebuggerManager` | `1` | Debugger transport manager. |
| `InteropManager` | `2` | Interop / extern-call manager. |
| `MemoryManager` | `3` | Managed heap / allocator manager. |
| `TimeManager` | `4` | System-time manager (DateTime, ticks). |
| `AdcController` | `0 \| 0x40000000` | ADC controller. |
| `CanController` | `1 \| 0x40000000` | CAN controller. |
| `DacController` | `2 \| 0x40000000` | DAC controller. |
| `DcmiController` | `3 \| 0x40000000` | DCMI / parallel camera controller. |
| `DisplayController` | `4 \| 0x40000000` | Display controller. |
| `GpioController` | `5 \| 0x40000000` | GPIO controller. |
| `I2cController` | `6 \| 0x40000000` | I²C controller. |
| `I2sController` | `7 \| 0x40000000` | I²S audio controller. |
| `NetworkController` | `8 \| 0x40000000` | Network controller. |
| `OneWireController` | `9 \| 0x40000000` | 1-Wire controller. |
| `PowerController` | `10 \| 0x40000000` | Power-management controller. |
| `PwmController` | `11 \| 0x40000000` | PWM controller. |
| `RtcController` | `12 \| 0x40000000` | RTC controller. |
| `SaiController` | `13 \| 0x40000000` | SAI audio controller. |
| `SpiController` | `14 \| 0x40000000` | SPI controller. |
| `StorageController` | `15 \| 0x40000000` | Block-storage controller (internal flash, SD, etc.). |
| `TaskController` | `16 \| 0x40000000` | Task / RTOS controller. |
| `TouchController` | `17 \| 0x40000000` | Touch controller. |
| `UartController` | `18 \| 0x40000000` | UART controller. |
| `UsbClientController` | `19 \| 0x40000000` | USB device controller. |
| `UsbHostController` | `20 \| 0x40000000` | USB host controller. |
| `WatchdogController` | `21 \| 0x40000000` | Watchdog timer. |
| `Custom` | `0 \| 0x80000000` | Custom / out-of-tree API. |
