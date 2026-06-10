---
title: "DispatcherObject Class"
sidebar_label: "DispatcherObject"
---

# DispatcherObject Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Threading`

A DispatcherObject is an object associated with a `Dispatcher`. A DispatcherObject instance should only be access by the dispatcher's thread.

```csharp
public abstract class DispatcherObject
```

## Constructors

### DispatcherObject()

```csharp
protected DispatcherObject()
```

Instantiate this object associated with the current Dispatcher.

## Methods

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

## Fields

### Dispatcher

```csharp
public readonly Dispatcher Dispatcher
```

The `Dispatcher` that this `DispatcherObject` is associated with.
