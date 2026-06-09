---
title: "SerialDataReceivedEventArgs Class"
sidebar_label: "SerialDataReceivedEventArgs"
---

# SerialDataReceivedEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `System.IO.Ports`<br/>**Namespace:** `System.IO.Ports`

Arguments for the data-received event.

```csharp
public class SerialDataReceivedEventArgs : EventArgs
```

## Constructors

### SerialDataReceivedEventArgs(SerialData eventType)

```csharp
public SerialDataReceivedEventArgs(SerialData eventType)
```

Creates the event arguments.

## Properties

### EventType

```csharp
public SerialData EventType { get; }
```

The kind of data that was received.
