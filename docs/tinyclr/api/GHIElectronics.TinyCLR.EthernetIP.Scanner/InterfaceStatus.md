---
title: "InterfaceStatus Struct"
sidebar_label: "InterfaceStatus"
---

# InterfaceStatus Struct

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary`

Chapter 5-3.2.2.1 Volume 2

```csharp
public struct InterfaceStatus
```

## Fields

### NotConfigured

```csharp
public bool NotConfigured
```

The interface configuration has not been set.

### ValidConfiguration

```csharp
public bool ValidConfiguration
```

The interface holds a valid (e.g. BootP/DHCP) configuration.

### ValidManualConfiguration

```csharp
public bool ValidManualConfiguration
```

The interface holds a valid manually-entered configuration.

### McastPending

```csharp
public bool McastPending
```

A multicast address reconfiguration is pending.
