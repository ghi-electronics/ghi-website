---
title: "IPHostEntry Class"
sidebar_label: "IPHostEntry"
---

# IPHostEntry Class

**NuGet:** `GHIElectronics.TinyCLR.Networking`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking`<br/>**Namespace:** `System.Net`

Holds the host name, aliases, and IP addresses associated with a host.

```csharp
public class IPHostEntry
```

## Properties

### HostName

```csharp
public string HostName { get; set; }
```

The DNS name of the host.

### AddressList

```csharp
public IPAddress[] AddressList { get; set; }
```

The list of IP addresses associated with the host.

### Aliases

```csharp
public string[] Aliases { get; set; }
```

The list of aliases associated with the host.
