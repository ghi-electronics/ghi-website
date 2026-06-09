---
title: "DispatcherFrame Class"
sidebar_label: "DispatcherFrame"
---

# DispatcherFrame Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Threading` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Representation of Dispatcher frame.

```csharp
public class DispatcherFrame
```

## Constructors

### DispatcherFrame()

```csharp
public DispatcherFrame() : this(true)
```

Constructs a new instance of the DispatcherFrame class.

### DispatcherFrame(bool exitWhenRequested)

```csharp
public DispatcherFrame(bool exitWhenRequested)
```

Constructs a new instance of the DispatcherFrame class.

| Parameter | Type | Description |
|---|---|---|
| `exitWhenRequested` | `bool` | Indicates whether or not this frame will exit when all frames are requested to exit. Dispatcher frames typically break down into two categories: 1) Long running, general purpose frames, that exit only when told to. These frames should exit when requested. 2) Short running, very specific frames that exit themselves when an important criteria is met. These frames may consider not exiting when requested in favor of waiting for their important criteria to be met. These frames should have a timeout associated with them. |

## Properties

### Continue

```csharp
public bool Continue { get; set; }
```

Indicates that this dispatcher frame should exit.
