---
title: "Group Class"
sidebar_label: "Group"
---

# Group Class

**NuGet:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Assembly:** `GHIElectronics.TinyCLR.RegularExpressions`<br/>**Namespace:** `System.Text.RegularExpressions`

Represents the results from a single capturing group.

```csharp
public class Group : Capture
```

## Properties

### Success

```csharp
public bool Success { get; }
```

Gets a value indicating whether the match was successful.

## Methods

### Synchronized(Group inner)

```csharp
public static Group Synchronized(Group inner)
```

Returns a thread-safe wrapper around the specified group.

**Returns** `Group`
