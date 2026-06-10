---
title: "UInt16Array Class"
sidebar_label: "UInt16Array"
---

# UInt16Array Class

**NuGet:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Assembly:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`<br/>**Namespace:** `GHIElectronics.TinyCLR.IO.TinyFileSystem`

Dynamically growing array of UInt16 (ushort) elements.

```csharp
public class UInt16Array
```

## Properties

### index]

```csharp
public ushort this[int index] { get; set; }
```

Gets or sets the element at the specified index.

### Count

```csharp
public int Count { get; set; }
```

Gets the number of elements contained in the array.

## Methods

### Add(ushort value)

```csharp
public int Add(ushort value)
```

Adds an element to the end of the collection.

| Parameter | Type | Description |
|---|---|---|
| `value` | `ushort` | Value of the element to add. |

**Returns** `int` — The new count of items in the array.

### SetLength(int length)

```csharp
public void SetLength(int length)
```

Adjusts the length of the array. This can be used to trim the end of the array.

| Parameter | Type | Description |
|---|---|---|
| `length` | `int` | New length of the array. |
