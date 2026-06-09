---
title: "BufferDrawTarget Class"
sidebar_label: "BufferDrawTarget"
---

# BufferDrawTarget Class

**NuGet:** `GHIElectronics.TinyCLR.Drawing`<br/>**Assembly:** `GHIElectronics.TinyCLR.Drawing`<br/>**Namespace:** `GHIElectronics.TinyCLR.Drawing`

_No description available._

```csharp
public abstract class BufferDrawTarget : IDrawTarget
```

## Constructors

### BufferDrawTarget(int width, int height, int bpp)

```csharp
protected BufferDrawTarget(int width, int height, int bpp)
```

_No description available._

## Properties

### Width

```csharp
public int Width { get; }
```

_No description available._

### Height

```csharp
public int Height { get; }
```

_No description available._

## Methods

### GetData()

```csharp
public byte[] GetData()
```

_No description available._

**Returns** `byte[]`

### Clear(Color color)

```csharp
public void Clear(Color color)
```

_No description available._

### Dispose()

```csharp
public virtual void Dispose()
```

_No description available._

### Flush()

```csharp
public virtual void Flush()
```

_No description available._

### GetPixel(int x, int y)

```csharp
public abstract Color GetPixel(int x, int y)
```

_No description available._

**Returns** `Color`

### SetPixel(int x, int y, Color color)

```csharp
public abstract void SetPixel(int x, int y, Color color)
```

_No description available._

## Fields

### buffer

```csharp
protected readonly byte[] buffer
```

_No description available._
