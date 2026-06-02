---
title: "Brush Class"
sidebar_label: "Brush"
---

# Brush Class

**Namespace:** `System.Drawing` · **Assembly:** `GHIElectronics.TinyCLR.Drawing`

Abstract base for objects that fill graphics shapes (rectangles, ellipses, paths).

```csharp
public abstract class Brush : MarshalByRefObject, ICloneable, IDisposable
```

## Methods

### Clone()

```csharp
public abstract object Clone()
```

Creates a new object that is a copy of the current instance. _(inherited)_

**Returns** `object`

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
