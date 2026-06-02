---
title: "GHIElectronics.TinyCLR.Devices.Network"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Devices.Network

NuGet package containing **26** types across **2** namespaces (`GHIElectronics.TinyCLR.Devices.Network`, `GHIElectronics.TinyCLR.Devices.Network.Provider`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [BuiltInNetworkCommunicationInterfaceSettings](./BuiltInNetworkCommunicationInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Built-in MAC — no extra wiring required. |
| [EthernetNetworkInterfaceProperties](./EthernetNetworkInterfaceProperties.md) | `GHIElectronics.TinyCLR.Devices.Network` | Ethernet-specific interface properties. |
| [EthernetNetworkInterfaceSettings](./EthernetNetworkInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Ethernet interface settings. |
| [NetworkAddressChangedEventArgs](./NetworkAddressChangedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Network` | Arguments for `NetworkController.NetworkAddressChanged`. |
| [NetworkCommunicationInterfaceSettings](./NetworkCommunicationInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Base class for transport-bus settings. |
| [NetworkController](./NetworkController.md) | `GHIElectronics.TinyCLR.Devices.Network` | Represents a network interface — Ethernet, WiFi (station or AP), or PPP. Configure the interface settings, optionally the underlying communication interface (built-in MAC, SPI, or UART), then `Enable` the controller. Subscribe to `NetworkLinkConnectedChanged` and `NetworkAddressChanged` for status. Use `SetAsDefaultController` to choose which interface handles outbound traffic when multiple are up. |
| [NetworkControllerApiWrapper](./NetworkControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.Network.Provider` | Concrete `INetworkControllerProvider` backed by the native TinyCLR network HAL (lwIP + mbedTLS). |
| [NetworkInterfaceProperties](./NetworkInterfaceProperties.md) | `GHIElectronics.TinyCLR.Devices.Network` | Common interface properties. Cast via `GetEthernetProperties` / `GetWiFiProperties` / `GetPppProperties` for transport-specific fields. |
| [NetworkInterfaceSettings](./NetworkInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Common interface settings — IP/DHCP/DNS/MAC. Subclass per transport for additional fields. |
| [NetworkIPProperties](./NetworkIPProperties.md) | `GHIElectronics.TinyCLR.Devices.Network` | IP-level interface properties. |
| [NetworkLinkConnectedChangedEventArgs](./NetworkLinkConnectedChangedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.Network` | Arguments for `NetworkController.NetworkLinkConnectedChanged`. |
| [PppNetworkInterfaceProperties](./PppNetworkInterfaceProperties.md) | `GHIElectronics.TinyCLR.Devices.Network` | PPP-specific interface properties. |
| [PppNetworkInterfaceSettings](./PppNetworkInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | PPP-specific interface settings (cellular modems, dial-up). |
| [SpiNetworkCommunicationInterfaceSettings](./SpiNetworkCommunicationInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Settings for an external SPI-attached network controller (chip select, reset, interrupt pins, SPI mode). |
| [UartNetworkCommunicationInterfaceSettings](./UartNetworkCommunicationInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | Settings for an external UART-attached network controller (cellular modem, etc.). |
| [WiFiNetworkInterfaceProperties](./WiFiNetworkInterfaceProperties.md) | `GHIElectronics.TinyCLR.Devices.Network` | WiFi-specific interface properties. |
| [WiFiNetworkInterfaceSettings](./WiFiNetworkInterfaceSettings.md) | `GHIElectronics.TinyCLR.Devices.Network` | WiFi-specific interface settings. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [INetworkControllerProvider](./INetworkControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.Network.Provider` | Provider contract for a network controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [NetworkCommunicationInterface](./NetworkCommunicationInterface.md) | `GHIElectronics.TinyCLR.Devices.Network` | Underlying physical bus carrying the network interface. |
| [NetworkInterfaceType](./NetworkInterfaceType.md) | `GHIElectronics.TinyCLR.Devices.Network` | Transport type of a network interface. |
| [PppAuthenticationType](./PppAuthenticationType.md) | `GHIElectronics.TinyCLR.Devices.Network` | PPP authentication protocol. |
| [WiFiMode](./WiFiMode.md) | `GHIElectronics.TinyCLR.Devices.Network` | WiFi role for a WiFi interface. |
| [WiFiSecurityMode](./WiFiSecurityMode.md) | `GHIElectronics.TinyCLR.Devices.Network` | WiFi security protocol. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [AccessPointClientConnectionChangedEventHandler](./AccessPointClientConnectionChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Network` | Handler signature for `AccessPointClientConnectionChanged`. |
| [NetworkAddressChangedEventHandler](./NetworkAddressChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Network` | Handler signature for `NetworkController.NetworkAddressChanged`. |
| [NetworkLinkConnectedChangedEventHandler](./NetworkLinkConnectedChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.Network` | Handler signature for `NetworkController.NetworkLinkConnectedChanged`. |
