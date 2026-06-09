---
title: "Mouse Class"
sidebar_label: "Mouse"
---

# Mouse Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Allows a usb device to be used a mouse.

```csharp
public class Mouse : BaseDevice
```

## Constructors

### Mouse(uint id, byte interfaceIndex, bool absolutePosition)

```csharp
public Mouse(uint id, byte interfaceIndex, bool absolutePosition = false) : base(id, interfaceIndex, DeviceType.Mouse)
```

Creates a new mouse.

| Parameter | Type | Description |
|---|---|---|
| `id` | `uint` | The device id. |
| `interfaceIndex` | `byte` | The device interface index. |
| `absolutePosition` | `bool` |  |

## Properties

### LeftButtonState

```csharp
public ButtonState LeftButtonState { get; }
```

The current state of the mouse's left button.

### RightButtonState

```csharp
public ButtonState RightButtonState { get; }
```

The current state of the mouse's right button.

### MiddleButtonState

```csharp
public ButtonState MiddleButtonState { get; }
```

The current state of the mouse's middle button.

### Extended1ButtonState

```csharp
public ButtonState Extended1ButtonState { get; }
```

The current state of the mouse's first extended button.

### Extended2ButtonState

```csharp
public ButtonState Extended2ButtonState { get; }
```

The current state of the mouse's second extended button.

### CursorPosition

```csharp
public Position CursorPosition { get; }
```

The current position of the cursor.

### WheelPosition

```csharp
public int WheelPosition { get; }
```

The current position of the mouse wheel.

### AbsolutePosition

```csharp
public bool AbsolutePosition { get; }
```

Return true for absolute, false for relative mode.

## Methods

### SetScale(float scale)

```csharp
public void SetScale(float scale)
```

Scales the x, y, and wheel delta values.

| Parameter | Type | Description |
|---|---|---|
| `scale` | `float` | The value by which to scale the data. |

### SetCursorBounds(Position minimum, Position maximum)

```csharp
public void SetCursorBounds(Position minimum, Position maximum)
```

Sets the cursor bounds.

| Parameter | Type | Description |
|---|---|---|
| `minimum` | `Position` | The minimum bound. |
| `maximum` | `Position` | The maximum bound. |

### SetCursorPosition(Position newPosition)

```csharp
public void SetCursorPosition(Position newPosition)
```

Sets the cursor position.

| Parameter | Type | Description |
|---|---|---|
| `newPosition` | `Position` | The new position of the cursor. |

### Dispose(bool disposing)

```csharp
protected override void Dispose(bool disposing)
```

Disposes the mouse.

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

The event fired when one of the mouse's buttons is pressed or released.

### WheelMoved

```csharp
public event WheelMovedEventHandler WheelMoved
```

The event fired when the mouse's wheel has moved.

### CursorMoved

```csharp
public event CursorMovedEventHandler CursorMoved
```

The event fired when the mouse's cursor has moved.
