---
title: "SpiConnectionSettings Class"
sidebar_label: "SpiConnectionSettings"
---

# SpiConnectionSettings Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Spi`<br/>**Assembly:** `System.Device.Spi`<br/>**Namespace:** `System.Device.Spi`

Per-device SPI settings in the standard `System.Device.Spi` shape. TinyCLR maps these onto its native SPI driver via `SpiDevice.Create(SpiConnectionSettings)`.

```csharp
public sealed class SpiConnectionSettings
```

## Constructors

### SpiConnectionSettings(int busId, int chipSelectLine)

```csharp
public SpiConnectionSettings(int busId, int chipSelectLine)
```

_No description available._

## Properties

### BusId

```csharp
public int BusId { get; }
```

_No description available._

### ChipSelectLine

```csharp
public int ChipSelectLine { get; set; }
```

_No description available._

### ClockFrequency

```csharp
public int ClockFrequency { get; set; }
```

_No description available._

### DataBitLength

```csharp
public int DataBitLength { get; set; }
```

_No description available._

### DataFlow

```csharp
public DataFlow DataFlow { get; set; }
```

_No description available._

### Mode

```csharp
public SpiMode Mode { get; set; }
```

_No description available._
