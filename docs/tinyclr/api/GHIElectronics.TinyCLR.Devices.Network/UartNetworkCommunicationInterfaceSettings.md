---
title: "UartNetworkCommunicationInterfaceSettings Class"
sidebar_label: "UartNetworkCommunicationInterfaceSettings"
---

# UartNetworkCommunicationInterfaceSettings Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.Network` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Network`

Settings for an external UART-attached network controller (cellular modem, etc.).

```csharp
public class UartNetworkCommunicationInterfaceSettings : NetworkCommunicationInterfaceSettings
```

## Properties

### ApiName

```csharp
public string ApiName { get; set; }
```

Native API name of the UART controller to use.

### BaudRate

```csharp
public int BaudRate { get; set; }
```

UART baud rate.

### DataBits

```csharp
public int DataBits { get; set; }
```

UART data bits.

### Parity

```csharp
public UartParity Parity { get; set; }
```

UART parity.

### StopBits

```csharp
public UartStopBitCount StopBits { get; set; }
```

UART stop bits.

### Handshaking

```csharp
public UartHandshake Handshaking { get; set; }
```

UART flow control.
