---
title: "Keyboard Class"
sidebar_label: "Keyboard"
---

# Keyboard Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.UsbClient`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbClient`

This device emulates a keyboard. You can set the state of any key, but only seven keys can be pressed at once.

```csharp
public class Keyboard : RawDevice
```

## Constructors

### Keyboard(UsbClientController usbClientController)

```csharp
public Keyboard(UsbClientController usbClientController) : this(usbClientController, new UsbClientSetting()
```

Creates a new keyboard with default parameters.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` |  |

### Keyboard(UsbClientController usbClientController, UsbClientSetting usbClientSetting)

```csharp
public Keyboard(UsbClientController usbClientController, UsbClientSetting usbClientSetting) : base(usbClientController, usbClientSetting)
```

Creates a new keyboard.

| Parameter | Type | Description |
|---|---|---|
| `usbClientController` | `UsbClientController` | UsbClient controller. |
| `usbClientSetting` | `UsbClientSetting` | UsbClient setting |

## Methods

### Stroke(Key key)

```csharp
public void Stroke(Key key)
```

Presses and then releases the key.

| Parameter | Type | Description |
|---|---|---|
| `key` | `Key` | The key to press and release. |

### Stroke(Key key, int delay)

```csharp
public void Stroke(Key key, int delay)
```

Presses and then releases the key.

| Parameter | Type | Description |
|---|---|---|
| `key` | `Key` | The key to press and release. |
| `delay` | `int` | How long to wait after the press before releasing. |

### Release(Key key)

```csharp
public void Release(Key key)
```

Releases the given key.

| Parameter | Type | Description |
|---|---|---|
| `key` | `Key` | The key to release. |

### Press(Key key)

```csharp
public void Press(Key key)
```

Presses the given key.

| Parameter | Type | Description |
|---|---|---|
| `key` | `Key` | The key to press. |
