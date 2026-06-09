---
title: "KeyboardEventArgs Class"
sidebar_label: "KeyboardEventArgs"
---

# KeyboardEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Devices.UsbHost` · **Assembly:** `GHIElectronics.TinyCLR.Devices.UsbHost`

Event arguments for the keyboard events.

```csharp
public class KeyboardEventArgs : EventArgs
```

## Properties

### Which

```csharp
public Key Which { get; set; }
```

The Key associated with the event.

### ASCII

```csharp
public char ASCII { get; set; }
```

The ASCII representation of the key, if available. Otherwise, this value is 0.
