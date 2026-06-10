---
title: "GHIElectronics.TinyCLR.Devices.UsbHost"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Devices.UsbHost</h1>

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbHost`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Auxiliary](./Auxiliary.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | Represents additional auxiliary descriptors. |
| [BaseDescriptor](./BaseDescriptor.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | The base USB descriptor. |
| [BaseDevice](./BaseDevice.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Represents a USB device connected. |
| [ButtonChangedEventArgs](./ButtonChangedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the ButtonPressed and ButtonReleased events. |
| [ButtonChangedEventArgs](./ButtonChangedEventArgs_2.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the ButtonPressed and ButtonReleased events. |
| [Configuration](./Configuration.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | Configuration descriptor. |
| [CursorMovedEventArgs](./CursorMovedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the CursorMoved event. |
| [CursorMovedEventArgs](./CursorMovedEventArgs_2.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the CursorMoved event. |
| [Device](./Device.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | Device descriptor. |
| [DeviceConnectionEventArgs](./DeviceConnectionEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The event arguments for a device connection change. |
| [Endpoint](./Endpoint.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | Endpoint descriptor. |
| [Format](./Format.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | A camera-supported video format / resolution combination. |
| [HatSwitchPressedEventArgs](./HatSwitchPressedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the HatSwitchPressed event. |
| [Interface](./Interface.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | Interface descriptor. |
| [Joystick](./Joystick.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Allows a usb device to be used as a joystick. |
| [Keyboard](./Keyboard.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Allows a usb device to be used as a keyboard. |
| [KeyboardEventArgs](./KeyboardEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Event arguments for the keyboard events. |
| [Mouse](./Mouse.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Allows a usb device to be used a mouse. |
| [Pipe](./Pipe.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | A USB communication pipe. |
| [RawDevice](./RawDevice.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Provides low level access functionalities for the connected USB device. This is useful if there is not already a predefined driver for that device. |
| [UsbHostController](./UsbHostController.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Represents the USB host controller used to manage connected USB devices. |
| [UsbHostControllerApiWrapper](./UsbHostControllerApiWrapper.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Provider` | The native API wrapper that implements the USB host controller provider. |
| [Webcam](./Webcam.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Allows a USB webcam (UVC class, YUY2 uncompressed) to be used. |
| [WheelMovedEventArgs](./WheelMovedEventArgs.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The events args for the WheelMoved event. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IUsbHostControllerProvider](./IUsbHostControllerProvider.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Provider` | Provides the underlying implementation for a USB host controller. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [DescriptorType](./DescriptorType.md) | `GHIElectronics.TinyCLR.Devices.UsbHost.Descriptors` | The possible types of descriptors. |
| [DeviceConnectionStatus](./DeviceConnectionStatus.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The connection status of a USB device. |
| [DeviceType](./DeviceType.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Possible device types. |
| [FormatKind](./FormatKind.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The on-the-wire pixel encoding for a UVC stream. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [CursorMovedEventHandler](./CursorMovedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The delegate for when one of the joystick's cursors moves. |
| [CursorMovedEventHandler](./CursorMovedEventHandler_2.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The delegate for when the mouse's cursor moves. |
| [DisconnectedEventHandler](./DisconnectedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The event handler type for when the device disconnects. |
| [FrameAvailableEventHandler](./FrameAvailableEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | Delegate fired when a new frame is ready. |
| [HatSwitchPressedEventHandler](./HatSwitchPressedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The delegate for when the joystick's hat switch is pressed. |
| [OnConnectionChanged](./OnConnectionChanged.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The delegate for when a device's connection status changes. |
| [WheelMovedEventHandler](./WheelMovedEventHandler.md) | `GHIElectronics.TinyCLR.Devices.UsbHost` | The delegate for when the mouse's wheel moves. |
