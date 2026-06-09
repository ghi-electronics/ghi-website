---
title: "SpiMode Enum"
sidebar_label: "SpiMode"
---

# SpiMode Enum

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Spi`

Standard SPI modes — combinations of clock polarity (CPOL) and clock phase (CPHA). Mode 0 (CPOL=0, CPHA=0) is the most common.

```csharp
public enum SpiMode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Mode0` | `0` | CPOL=0, CPHA=0. |
| `Mode1` | `1` | CPOL=0, CPHA=1. |
| `Mode2` | `2` | CPOL=1, CPHA=0. |
| `Mode3` | `3` | CPOL=1, CPHA=1. |
