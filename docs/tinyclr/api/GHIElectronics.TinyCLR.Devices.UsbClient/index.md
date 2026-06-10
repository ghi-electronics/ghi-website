---
title: "GHIElectronics.TinyCLR.Devices.UsbClient"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">Devices.UsbClient Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Cdc](./Cdc.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a CDC virtual COM port. |
| [CdcStream](./CdcStream.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Stream for reading and writing data over a CDC connection. |
| [ClassDescriptor](./ClassDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A class-specific descriptor. |
| [Configuration](./Configuration.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Holds the set of USB descriptors that define a device. |
| [ConfigurationDescriptor](./ConfigurationDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A USB configuration descriptor. |
| [Descriptor](./Descriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Base class for all USB descriptors. |
| [DeviceDescriptor](./DeviceDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | The USB device descriptor. |
| [Endpoint](./Endpoint.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A USB endpoint descriptor. |
| [GenericDescriptor](./GenericDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A generic descriptor returned in response to a control request. |
| [Joystick](./Joystick.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a joystick. You can set the x, y, and z axis values, the z axis rotation, the state of 32 buttons, and 8 hat swtich directions. |
| [Keyboard](./Keyboard.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a keyboard. You can set the state of any key, but only seven keys can be pressed at once. |
| [MassStorage](./MassStorage.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a mass storage. Your Micro Framework device will appear as a virtual mass storage device similar to a USB Drive. This works by exposing the storage connected to this device, such as SD card or USB sticks, to the host. |
| [Mouse](./Mouse.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a mouse. You can move the cursor, scroll the wheel, and press buttons. |
| [RawDevice](./RawDevice.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Represent a USB device. |
| [RawStream](./RawStream.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | USB stream for reading and writing data through two endpoints. |
| [StringDescriptor](./StringDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A USB string descriptor. |
| [UsbClientController](./UsbClientController.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Provides access to a USB client controller. |
| [UsbClientControllerApiWrapper](./UsbClientControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.UsbClient.Provider` | The native implementation of a USB client controller provider. |
| [UsbClientSetting](./UsbClientSetting.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | The settings used to configure a USB client device. |
| [UsbInterface](./UsbInterface.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | A USB interface descriptor. |
| [WinUsb](./WinUsb.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | This device emulates a WinUsb device for vendor-specific bulk communication with a host. |
| [WinUsbStream](./WinUsbStream.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Stream for reading and writing data over a CDC connection. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IUsbClientControllerProvider](./IUsbClientControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.UsbClient.Provider` | Provides the low-level interface for a USB client controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DeviceState](./DeviceState.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | The possible states of a USB device. |
| [PID](./PID.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | The default product ids for each built-in device type. |
| [UsbClientMode](./UsbClientMode.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | The type of device to emulate. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [DataReceivedEventHandler](./DataReceivedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Represents the method that handles a data received event. |
| [DeviceStateChangedEventHandler](./DeviceStateChangedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbClient` | Represents the method that handles a device state changed event. |
