---
title: "Joystick Class"
sidebar_label: "Joystick"
---

# Joystick Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Allows a usb device to be used as a joystick.

```csharp
public class Joystick : BaseDevice
```

## Constructors

### Joystick(uint id, byte interfaceIndex)

```csharp
public Joystick(uint id, byte interfaceIndex) : base(id, interfaceIndex, DeviceType.Joystick)
```

Creates a new joystick.

| Parameter | Type | Description |
|---|---|---|
| `id` | `uint` | The device id. |
| `interfaceIndex` | `byte` | The device interface index. |

## Properties

### Capabilities

```csharp
public DeviceCapabilities Capabilities { get; }
```

The capabilities of the joystick.

### CursorPosition

```csharp
public Position CursorPosition { get; }
```

The current position of the first cursor.

### Cursor2Position

```csharp
public Position Cursor2Position { get; }
```

The current position of the second cursor.

### CurrentHatSwitchDirection

```csharp
public HatSwitchDirection CurrentHatSwitchDirection { get; }
```

The current direction of the hat switch.

### byte

```csharp
public enum DeviceCapabilities : byte { }
```

Joystick capabilities.

## Methods

### SetCursorBounds(Cursor cursor, int minX, int maxX, int minY, int maxY)

```csharp
public void SetCursorBounds(Cursor cursor, int minX, int maxX, int minY, int maxY)
```

Sets the bounds for given cursor.

| Parameter | Type | Description |
|---|---|---|
| `cursor` | `Cursor` | The cursor for which to set the bounds. |
| `minX` | `int` | The minimum X value. |
| `maxX` | `int` | The maximum X value. |
| `minY` | `int` | The minimum Y value. |
| `maxY` | `int` | The maximum Y value. |

### GetButtonState(int buttonNumber)

```csharp
public ButtonState GetButtonState(int buttonNumber)
```

Gets the current button state.

| Parameter | Type | Description |
|---|---|---|
| `buttonNumber` | `int` | The button number to query. |

**Returns** `ButtonState` — The state of the button.

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Disposes the joystick.

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Whether or not this is called from Dispose. |

### CheckEvents(object sender)

```csharp
protected override void CheckEvents(object sender)
```

Repeatedly called with a period defined by WorkerInterval. Used to poll the device for data and raise any desired events.

| Parameter | Type | Description |
|---|---|---|
| `sender` | `object` | Always null. |

## Events

### ButtonChanged

```csharp
public event ButtonChangedEventHandler ButtonChanged
```

The event fired when one of the joystick's buttons is pressed or released.

### CursorMoved

```csharp
public event CursorMovedEventHandler CursorMoved
```

The event fired when the joystick's cursor has moved.

### HatSwitchPressed

```csharp
public event HatSwitchPressedEventHandler HatSwitchPressed
```

The event fired when the joystick's hat switch has been pressed.
