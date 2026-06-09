---
title: "TapCellEventArgs Class"
sidebar_label: "TapCellEventArgs"
---

# TapCellEventArgs Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI.Controls`

Tap cell event arguments.

```csharp
public class TapCellEventArgs
```

## Constructors

### TapCellEventArgs(int columnIndex, int rowIndex)

```csharp
public TapCellEventArgs(int columnIndex, int rowIndex)
```

Creates a new TapCellEventArgs.

| Parameter | Type | Description |
|---|---|---|
| `columnIndex` | `int` | X coordinate |
| `rowIndex` | `int` | Y coordinate |

## Properties

### ColumnIndex

```csharp
public int ColumnIndex { get; }
```

Column index.

### RowIndex

```csharp
public int RowIndex { get; }
```

Row index.

## Methods

### ToString()

```csharp
public override string ToString()
```

ToString

**Returns** `string` — Tap cell event properties.
