---
title: "PreProcessInputEventArgs Class"
sidebar_label: "PreProcessInputEventArgs"
---

# PreProcessInputEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Input`

Allows the handler to cancel the processing of an input event.

```csharp
public sealed class PreProcessInputEventArgs : ProcessInputEventArgs
```

## Properties

### Canceled

```csharp
public bool Canceled { get; }
```

Whether or not the input event processing was canceled.

## Methods

### Cancel()

```csharp
public void Cancel()
```

Cancels the processing of the input event.
