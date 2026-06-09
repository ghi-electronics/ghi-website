---
title: "DispatcherTimer Class"
sidebar_label: "DispatcherTimer"
---

# DispatcherTimer Class

**Namespace:** `GHIElectronics.TinyCLR.UI.Threading` · **Assembly:** `GHIElectronics.TinyCLR.UI`

A timer that is integrated into the Dispatcher queues, and will be processed after a given amount of time

```csharp
public class DispatcherTimer : IDisposable
```

## Constructors

### DispatcherTimer()

```csharp
public DispatcherTimer() : this(Dispatcher.CurrentDispatcher)
```

Creates a timer that uses the current thread's Dispatcher to process the timer event

### DispatcherTimer(Dispatcher dispatcher)

```csharp
public DispatcherTimer(Dispatcher dispatcher)
```

Creates a timer that uses the specified Dispatcher to process the timer event.

| Parameter | Type | Description |
|---|---|---|
| `dispatcher` | `Dispatcher` | The dispatcher to use to process the timer. |

## Properties

### Dispatcher

```csharp
public Dispatcher Dispatcher { get; }
```

Gets the dispatcher this timer is associated with.

### IsEnabled

```csharp
public bool IsEnabled { get; set; }
```

Gets or sets whether the timer is running.

### Interval

```csharp
public TimeSpan Interval { get; set; }
```

Gets or sets the time between timer ticks.

### Tag

```csharp
public object Tag { get; set; }
```

Any data that the caller wants to pass along with the timer.

## Methods

### Start()

```csharp
public void Start()
```

Starts the timer.

### Stop()

```csharp
public void Stop()
```

Stops the timer.

### Close()

```csharp
public virtual void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |

## Events

### Tick

```csharp
public event EventHandler Tick
```

Occurs when the specified timer interval has elapsed and the timer is enabled.
