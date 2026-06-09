---
title: "DispatcherOperation Class"
sidebar_label: "DispatcherOperation"
---

# DispatcherOperation Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Threading` · **Assembly:** `GHIElectronics.TinyCLR.UI`

DispatcherOperation represents a delegate that has been posted to the Dispatcher queue.

```csharp
public sealed class DispatcherOperation
```

## Properties

### Dispatcher

```csharp
public Dispatcher Dispatcher { get; }
```

Returns the Dispatcher that this operation was posted to.

### Status

```csharp
public DispatcherOperationStatus Status { get; set; }
```

The status of this operation.

### Result

```csharp
public object Result { get; }
```

Returns the result of the operation if it has completed.

## Methods

### Wait()

```csharp
public DispatcherOperationStatus Wait()
```

_No description available._

**Returns** `DispatcherOperationStatus`

### Wait(TimeSpan timeout)

```csharp
public DispatcherOperationStatus Wait(TimeSpan timeout)
```

Waits for this operation to complete.

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `TimeSpan` | The maximum amount of time to wait. |

**Returns** `DispatcherOperationStatus` — The status of the operation. To obtain the return value of the invoked delegate, use the the Result property.

### Abort()

```csharp
public bool Abort()
```

Aborts this operation.

**Returns** `bool` — False if the operation could not be aborted (because the operation was already in progress)

## Events

### Aborted

```csharp
public event EventHandler Aborted
```

An event that is raised when the operation is aborted.

### Completed

```csharp
public event EventHandler Completed
```

An event that is raised when the operation completes.
