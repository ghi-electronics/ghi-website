---
title: "SQLiteDatabase Class"
sidebar_label: "SQLiteDatabase"
---

# SQLiteDatabase Class

**NuGet:** `GHIElectronics.TinyCLR.Data.SQLite`<br/>**Assembly:** `GHIElectronics.TinyCLR.Data.SQLite`<br/>**Namespace:** `GHIElectronics.TinyCLR.Data.SQLite`

SQLite database handle. Open an in-memory database with the parameterless constructor or a file-backed database via the path constructor. Use `ExecuteNonQuery` for inserts/updates and `ExecuteQuery` for SELECTs that return a `ResultSet`.

```csharp
public class SQLiteDatabase : IDisposable
```

## Constructors

### SQLiteDatabase(string file)

```csharp
public SQLiteDatabase(string file)
```

_No description available._

## Methods

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### ExecuteNonQuery(string query)

```csharp
public void ExecuteNonQuery(string query)
```

_No description available._

### ExecuteQuery(string query)

```csharp
public ResultSet ExecuteQuery(string query)
```

_No description available._

**Returns** `ResultSet`

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes a response stream, if present. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `disposing` | `bool` | Not used. |
