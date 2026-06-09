---
title: "UartSetting Class"
sidebar_label: "UartSetting"
---

# UartSetting Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Uart` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Uart`

Aggregate configuration for a UART port — passed to `UartController.SetActiveSettings(UartSetting)`.

```csharp
public class UartSetting
```

## Properties

### BaudRate

```csharp
public int BaudRate { get; set; }
```

Bits per second.

### DataBits

```csharp
public int DataBits { get; set; }
```

Frame width in data bits (typically 7 or 8).

### Parity

```csharp
public UartParity Parity { get; set; }
```

Parity policy.

### StopBits

```csharp
public UartStopBitCount StopBits { get; set; }
```

Stop-bit policy.

### Handshaking

```csharp
public UartHandshake Handshaking { get; set; }
```

Flow-control mode.

### EnableDePin

```csharp
public bool EnableDePin { get; set; }
```

Drive the DE (driver-enable) line for RS-485 transceivers during TX.

### InvertTxPolarity

```csharp
public bool InvertTxPolarity { get; set; }
```

When true, the TX line is inverted on the wire.

### InvertRxPolarity

```csharp
public bool InvertRxPolarity { get; set; }
```

When true, the RX line is inverted on the wire.

### InvertBinaryData

```csharp
public bool InvertBinaryData { get; set; }
```

When true, the bit values themselves are inverted (idle low becomes idle high).

### SwapTxRxPin

```csharp
public bool SwapTxRxPin { get; set; }
```

When true, the TX and RX pin assignments are swapped.

### InvertDePolarity

```csharp
public bool InvertDePolarity { get; set; }
```

When true, the DE line is asserted low instead of high.
