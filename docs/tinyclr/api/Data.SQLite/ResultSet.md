---
title: "ResultSet Class"
sidebar_label: "ResultSet"
---

# ResultSet Class

**NuGet:** `GHIElectronics.TinyCLR.Data.SQLite`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.SQLite`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.SQLite`

Result of a SQL SELECT — rows × columns plus column-name metadata. Index by `this[row]` for an ArrayList of cells in that row, or `this[row, column]` for an individual cell.

```csharp
public class ResultSet
```

## Properties

### RowCount

```csharp
public int RowCount { get; }
```

Number of rows displayed. _(inherited)_

### ColumnCount

```csharp
public int ColumnCount { get; }
```

_No description available._

### ColumnNames

```csharp
public string[] ColumnNames { get; }
```

_No description available._

### Data

```csharp
public ArrayList Data { get; }
```

The payload buffer. Up to 64 bytes for CAN-FD, 8 for classic CAN. _(inherited)_

### row]

```csharp
public ArrayList this[int row] { get; }
```

_No description available._

### column]

```csharp
public object this[int row, int column] { get; }
```

_No description available._
