---
title: "Mouse Class"
sidebar_label: "Mouse"
---

# Mouse Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

This device emulates a mouse. You can move the cursor, scroll the wheel, and press buttons.

```csharp
public class Mouse : RawDevice
```

## Constructors

### Mouse(UsbClientController usbClientController, bool absolutePositon)

```csharp
public Mouse(UsbClientController usbClientController, bool absolutePositon = false) : this(usbClientController, new UsbClientSetting()
```

Creates a new mouse.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | UsbClient controller. |
| `absolutePositon` | `bool` | true for absolute position, false for relative |

### Mouse(UsbClientController usbClientController, UsbClientSetting usbClientSetting, bool absolutePositon)

```csharp
public Mouse(UsbClientController usbClientController, UsbClientSetting usbClientSetting, bool absolutePositon = false) : base(usbClientController, usbClientSetting)
```

Creates a new mouse.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | UsbClient controller. |
| `usbClientSetting` | `UsbClientSetting` | UsbClient setting |
| `absolutePositon` | `bool` | true for absolute position, false for relative |

## Properties

### MaxRange

```csharp
public static int MaxRange { get; }
```

The maximum range for movement.

### MinRange

```csharp
public static int MinRange { get; }
```

The minimum range for movement.

### ClickButtonDelay

```csharp
public int ClickButtonDelay { get; set; }
```

The mouse click delay in millisecond.

### AbsolutePosition

```csharp
public bool AbsolutePosition { get; set; }
```

Return true for absolute, false for relative mode.

## Methods

### IsPressedButton(Buttons button)

```csharp
public bool IsPressedButton(Buttons button)
```

Whether or not the given button is pressed.

| Parameter | Type | Description |
|---|---|---|
| `button` | `Buttons` | The button to check. |

**Returns** `bool` — If it is pressed or not.

### PressButton(Buttons button)

```csharp
public void PressButton(Buttons button)
```

Presses the given button.

| Parameter | Type | Description |
|---|---|---|
| `button` | `Buttons` | The button to press. |

### ReleaseButton(Buttons button)

```csharp
public void ReleaseButton(Buttons button)
```

Releases the given button.

| Parameter | Type | Description |
|---|---|---|
| `button` | `Buttons` | The button to release. |

### Click(Buttons button)

```csharp
public void Click(Buttons button)
```

Presses then releases the given button with the given delay between the actions.

| Parameter | Type | Description |
|---|---|---|
| `button` | `Buttons` | The button to click. |

### MoveWheel(int position)

```csharp
public void MoveWheel(int position)
```

Moves the wheel to the given position.

| Parameter | Type | Description |
|---|---|---|
| `position` | `int` | The new position. |

### MoveCursor(int x, int y)

```csharp
public void MoveCursor(int x, int y)
```

Moves the cursor's x and y coordinate to the given position.

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` | The new x position. |
| `y` | `int` | The new p position. |
