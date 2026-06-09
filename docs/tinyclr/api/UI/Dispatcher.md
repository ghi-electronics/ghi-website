---
title: "Dispatcher Class"
sidebar_label: "Dispatcher"
---

# Dispatcher Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Threading`

Provides UI services for a thread.

```csharp
public sealed class Dispatcher
```

## Properties

### CurrentDispatcher

```csharp
public static Dispatcher CurrentDispatcher { get; }
```

Returns the Dispatcher for the current thread.

### Thread

```csharp
public Thread Thread { get; }
```

Thread for the dispatcher.

### HasShutdownStarted

```csharp
public bool HasShutdownStarted { get; }
```

Whether or not the dispatcher is shutting down.

### HasShutdownFinished

```csharp
public bool HasShutdownFinished { get; }
```

Whether or not the dispatcher has been shut down.

## Methods

### FromThread(Thread thread)

```csharp
public static Dispatcher FromThread(Thread thread)
```

Returns the Dispatcher for the specified thread.

| Parameter | Type | Description |
|---|---|---|
| `thread` | `Thread` |  |

**Returns** `Dispatcher`

### CheckAccess()

```csharp
public bool CheckAccess()
```

Checks that the calling thread has access to this object.

**Returns** `bool` — True if the calling thread has access to this object.

### VerifyAccess()

```csharp
public void VerifyAccess()
```

Verifies that the calling thread has access to this object.

### InvokeShutdown()

```csharp
public void InvokeShutdown()
```

Begins the process of shutting down the dispatcher, synchronously. The process may complete asynchronously, since we may be nested in dispatcher frames.

### Run()

```csharp
public static void Run()
```

Push the main execution frame.

### PushFrame(DispatcherFrame frame)

```csharp
public static void PushFrame(DispatcherFrame frame)
```

Push an execution frame.

| Parameter | Type | Description |
|---|---|---|
| `frame` | `DispatcherFrame` | The frame for the dispatcher to process. |

### BeginInvoke(DispatcherOperationCallback method, object args)

```csharp
public DispatcherOperation BeginInvoke(DispatcherOperationCallback method, object args)
```

Executes the specified delegate asynchronously with the specified arguments, on the thread that the Dispatcher was created on.

| Parameter | Type | Description |
|---|---|---|
| `method` | `DispatcherOperationCallback` | A delegate to a method that takes parameters of the same number and type that are contained in the args parameter. |
| `args` | `object` | An object to pass as the argument to the given method. This can be null if no arguments are needed. |

**Returns** `DispatcherOperation` — A DispatcherOperation object that represents the result of the BeginInvoke operation. null if the operation could not be queued.

### Invoke(TimeSpan timeout, DispatcherOperationCallback method, object args)

```csharp
public object Invoke(TimeSpan timeout, DispatcherOperationCallback method, object args)
```

Executes the specified delegate synchronously with the specified arguments, on the thread that the Dispatcher was created on.

| Parameter | Type | Description |
|---|---|---|
| `timeout` | `TimeSpan` | The maximum amount of time to wait for the operation to complete. |
| `method` | `DispatcherOperationCallback` | A delegate to a method that takes parameters of the same number and type that are contained in the args parameter. |
| `args` | `object` | An object to pass as the argument to the given method. This can be null if no arguments are needed. |

**Returns** `object` — The return value from the delegate being invoked, or null if the delegate has no return value or if the operation was aborted.

## Events

### ShutdownStarted

```csharp
public event EventHandler ShutdownStarted
```

Raised when the dispatcher starts shutting down.

### ShutdownFinished

```csharp
public event EventHandler ShutdownFinished
```

Raised when the dispatcher is shut down.
