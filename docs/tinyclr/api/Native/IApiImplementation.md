---
title: "IApiImplementation Interface"
sidebar_label: "IApiImplementation"
---

# IApiImplementation Interface

**Namespace:** `GHIElectronics.TinyCLR.Native` · **Assembly:** `GHIElectronics.TinyCLR.Native`

Implemented by managed wrappers that expose their underlying native handle.

```csharp
public interface IApiImplementation
```

## Properties

### Implementation

```csharp
IntPtr Implementation { get; }
```

Pointer to the native implementation struct.
