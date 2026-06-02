---
title: "ProcessInputEventArgs Class"
sidebar_label: "ProcessInputEventArgs"
---

# ProcessInputEventArgs Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Input` · **Assembly:** `GHIElectronics.TinyCLR.UI`

Provides access to the input manager's staging area.

```csharp
public class ProcessInputEventArgs : NotifyInputEventArgs
```

## Methods

### PushInput(InputEventArgs input, StagingAreaInputItem promote)

```csharp
public StagingAreaInputItem PushInput(InputEventArgs input, StagingAreaInputItem promote)
```

Pushes an input event onto the top of the staging area.

| Parameter | Type | Description |
|---|---|---|
| `input` | `InputEventArgs` | The input event to place on the staging area. This may not be null, and may not already exist in the staging area. |
| `promote` | `StagingAreaInputItem` | An existing staging area item to promote the state from. |

**Returns** `StagingAreaInputItem` — The staging area input item that wraps the specified input.

### PushInput(StagingAreaInputItem input)

```csharp
public StagingAreaInputItem PushInput(StagingAreaInputItem input)
```

Pushes an input event onto the top of the staging area.

| Parameter | Type | Description |
|---|---|---|
| `input` | `StagingAreaInputItem` | The input event to place on the staging area. This may not be null, and may not already exist in the staging area. |

**Returns** `StagingAreaInputItem` — The specified staging area input item.

### PopInput()

```csharp
public StagingAreaInputItem PopInput()
```

Pops off the input event on the top of the staging area.

**Returns** `StagingAreaInputItem` — The input event that was on the top of the staging area. This can be null, if the staging area was empty.

### PeekInput()

```csharp
public StagingAreaInputItem PeekInput()
```

Returns the input event on the top of the staging area.

**Returns** `StagingAreaInputItem` — The input event that is on the top of the staging area. This can be null, if the staging area is empty.
