---
title: "NetworkCommunicationInterface Enum"
sidebar_label: "NetworkCommunicationInterface"
---

# NetworkCommunicationInterface Enum

**Namespace:** `GHIElectronics.TinyCLR.Devices.Network` · **Assembly:** `GHIElectronics.TinyCLR.Devices.Network`

Underlying physical bus carrying the network interface.

```csharp
public enum NetworkCommunicationInterface
```

## Fields

| Name | Value | Description |
|---|---|---|
| `BuiltIn` | `0` | Built-in MAC peripheral. |
| `Spi` | `1` | External controller over SPI (e.g. ENC28J60, WINC1500). |
| `Uart` | `2` | External controller over UART. |
