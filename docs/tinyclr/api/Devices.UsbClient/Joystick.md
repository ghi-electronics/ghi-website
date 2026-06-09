---
title: "Joystick Class"
sidebar_label: "Joystick"
---

# Joystick Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

This device emulates a joystick. You can set the x, y, and z axis values, the z axis rotation, the state of 32 buttons, and 8 hat swtich directions.

```csharp
public class Joystick : RawDevice
```

## Constructors

### Joystick(UsbClientController usbClientController)

```csharp
public Joystick(UsbClientController usbClientController) : this(usbClientController, new UsbClientSetting()
```

Creates a new joystick with default parameters.

### Joystick(UsbClientController usbClientController, UsbClientSetting usbClientSetting)

```csharp
public Joystick(UsbClientController usbClientController, UsbClientSetting usbClientSetting) : base(usbClientController, usbClientSetting)
```

Creates a new joystick.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | UsbClient controller. |
| `usbClientSetting` | `UsbClientSetting` | UsbClient setting |

## Properties

### X

```csharp
public int X { get; set; }
```

Sets the x axis position. It must be between –32,768 to +32,767.

### Y

```csharp
public int Y { get; set; }
```

Sets the y axis position. It must be between –32,768 to +32,767.

### Z

```csharp
public int Z { get; set; }
```

Sets the z axis position. It must be between –32,768 to +32,767.

### ZRotation

```csharp
public int ZRotation { get; set; }
```

Sets the z rotation. It must be between –32,768 to +32,767.

### HatSwitch

```csharp
public HatSwitchDirection HatSwitch { get; set; }
```

Sets the hat switch direction.

## Methods

### SendRawData(int x, int y, int z, int zRotation, uint buttons, HatSwitchDirection hatSwitch)

```csharp
public void SendRawData(int x, int y, int z, int zRotation, uint buttons, HatSwitchDirection hatSwitch)
```

Sends the given raw data directly to the host..

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` | The new x position from -32,768 to 32,767. |
| `y` | `int` | The new y position from -32,768 to 32,767. |
| `z` | `int` | The new z position from -32,768 to 32,767. |
| `zRotation` | `int` | The new z rotation from -32,768 to 32,767. |
| `buttons` | `uint` | Sends the given uint as a bitfield where each 1 represents a button press for the button whose number is the bit number. |
| `hatSwitch` | `HatSwitchDirection` | The new direction of the hat switch. |

### IsButtonPressed(int index)

```csharp
public bool IsButtonPressed(int index)
```

Whether or not the given button has been pressed.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The button to query. |

**Returns** `bool` — The button state.

### PressButton(int index)

```csharp
public void PressButton(int index)
```

Presses the given button.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The button to press. |

### ReleaseButton(int index)

```csharp
public void ReleaseButton(int index)
```

Releases the given button.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The button to release. |

### ClickButton(int index)

```csharp
public void ClickButton(int index)
```

Presses then releases the given button.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The button to click. |

### ClickButton(int index, int delay)

```csharp
public void ClickButton(int index, int delay)
```

Presses then releases the given button with the given delay between the actions.

| Parameter | Type | Description |
|---|---|---|
| `index` | `int` | The button to click. |
| `delay` | `int` | The delay between the actions. |
