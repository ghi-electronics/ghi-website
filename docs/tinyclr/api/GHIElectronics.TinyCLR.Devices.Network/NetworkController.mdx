---
title: "NetworkController Class"
sidebar_label: "NetworkController"
---

# NetworkController Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Network`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Network`

Represents a network interface — Ethernet, WiFi (station or AP), or PPP. Configure the interface settings, optionally the underlying communication interface (built-in MAC, SPI, or UART), then `Enable` the controller. Subscribe to `NetworkLinkConnectedChanged` and `NetworkAddressChanged` for status. Use `SetAsDefaultController` to choose which interface handles outbound traffic when multiple are up.

```csharp
public class NetworkController : IDisposable
```

## Properties

### DefaultController

```csharp
public static NetworkController DefaultController { get; set; }
```

The controller most recently selected via `SetAsDefaultController`.

### Provider

```csharp
public INetworkControllerProvider Provider { get; }
```

The low-level provider backing this controller.

### ActiveInterfaceSettings

```csharp
public NetworkInterfaceSettings ActiveInterfaceSettings { get; set; }
```

The settings most recently applied via `SetInterfaceSettings`.

### ActiveCommunicationInterfaceSettings

```csharp
public NetworkCommunicationInterfaceSettings ActiveCommunicationInterfaceSettings { get; set; }
```

The settings most recently applied via `SetCommunicationInterfaceSettings`.

### InterfaceType

```csharp
public NetworkInterfaceType InterfaceType { get; }
```

Interface type — Ethernet, WiFi, or PPP.

### CommunicationInterface

```csharp
public NetworkCommunicationInterface CommunicationInterface { get; }
```

Physical bus carrying the interface — built-in MAC, SPI, or UART.

### IsEnable

```csharp
public bool IsEnable { get; }
```

True once `Enable` has been called and the controller is still enabled.

## Methods

### GetDefault()

```csharp
public static NetworkController GetDefault()
```

Returns the default network controller for this device.

**Returns** `NetworkController`

### FromName(string name)

```csharp
public static NetworkController FromName(string name)
```

Returns a network controller identified by its native API name.

**Returns** `NetworkController`

### FromProvider(INetworkControllerProvider provider)

```csharp
public static NetworkController FromProvider(INetworkControllerProvider provider)
```

Creates a controller from a custom `INetworkControllerProvider`.

**Returns** `NetworkController`

### Dispose()

```csharp
public void Dispose()
```

Releases the underlying provider.

### Enable()

```csharp
public void Enable()
```

Brings the interface up synchronously. Blocks until the PHY/WiFi firmware is ready; for non-blocking bring-up use `EnableAsync`.

### EnableAsync()

```csharp
public void EnableAsync()
```

Non-blocking variant of `Enable`. Returns immediately while the slow PHY autonegotiation / WiFi firmware boot runs in a native RTOS task. The interface is NOT ready when this returns — subscribe to `NetworkLinkConnectedChanged` (link becomes physical-up) and `NetworkAddressChanged` (DHCP / static IP assigned) to learn when it is. Call at most once per controller per boot.

### Disable()

```csharp
public void Disable()
```

Brings the interface down.

### Suspend()

```csharp
public void Suspend()
```

Suspends the interface (low-power state with state preserved).

### Resume()

```csharp
public void Resume()
```

Resumes a previously `Suspend`ed interface.

### GetLinkConnected()

```csharp
public bool GetLinkConnected()
```

True when the physical link is currently up.

**Returns** `bool`

### GetIPProperties()

```csharp
public NetworkIPProperties GetIPProperties()
```

Returns the current IP address, subnet, gateway, and DNS servers.

**Returns** `NetworkIPProperties`

### GetInterfaceProperties()

```csharp
public NetworkInterfaceProperties GetInterfaceProperties()
```

Returns interface-specific properties (MAC address and friends).

**Returns** `NetworkInterfaceProperties`

### SetInterfaceSettings(NetworkInterfaceSettings settings)

```csharp
public void SetInterfaceSettings(NetworkInterfaceSettings settings)
```

Applies `NetworkInterfaceSettings` (IP address, DHCP, DNS).

### SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)

```csharp
public void SetCommunicationInterfaceSettings(NetworkCommunicationInterfaceSettings settings)
```

Applies the underlying physical-bus settings (built-in MAC, SPI, or UART).

### SetAsDefaultController()

```csharp
public void SetAsDefaultController()
```

Makes this controller the default across all layers — managed `DefaultController`, `Sockets.Socket.DefaultProvider`, and lwIP's netif_default. The lwIP-level update only fires when the controller is already enabled, so call after `Enable` to make this interface own the default route.

## Events

### NetworkLinkConnectedChanged

```csharp
public event NetworkLinkConnectedChangedEventHandler NetworkLinkConnectedChanged
```

Raised when the physical link goes up or down.

### NetworkAddressChanged

```csharp
public event NetworkAddressChangedEventHandler NetworkAddressChanged
```

Raised when the IP address, gateway, or DNS servers change (e.g. on DHCP lease assignment).
