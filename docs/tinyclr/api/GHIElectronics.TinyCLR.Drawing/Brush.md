---
title: "Brush Class"
sidebar_label: "Brush"
---

# Brush Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `System.Drawing`

Abstract base for objects that fill graphics shapes (rectangles, ellipses, paths).

```csharp
public abstract class Brush : MarshalByRefObject, ICloneable, IDisposable
```

## Methods

### Clone()

```csharp
public abstract object Clone()
```

Creates an exact copy of this brush.

**Returns** `object`

### Dispose()

```csharp
public void Dispose()
```

Releases the resources used by this brush.

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Releases the resources used by this brush.
