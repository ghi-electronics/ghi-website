---
title: "StateEnum Enum"
sidebar_label: "StateEnum"
---

# StateEnum Enum

**NuGet:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`<br/>**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary`

The operational state reported by the Identity Object (attribute 8).

```csharp
public enum StateEnum
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Nonexistent` | `0` | The device or instance does not exist. |
| `DeviceSelfTesting` | `1` | The device is performing self-test. |
| `Standby` | `2` | The device is in standby (not yet configured). |
| `Operational` | `3` | The device is operational. |
| `MajorRecoverableFault` | `4` | The device has a major recoverable fault. |
| `MajorUnrecoverableFault` | `5` | The device has a major unrecoverable fault. |
| `DefaultforGet_Attributes_All_service` | `255` | Default value returned by the Get_Attributes_All service. |
