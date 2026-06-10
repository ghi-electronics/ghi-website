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

Opens or creates a file-backed SQLite database at the given path.

## Methods

### Dispose()

```csharp
public void Dispose()
```

Closes the database and releases its native resources.

### ExecuteNonQuery(string query)

```csharp
public void ExecuteNonQuery(string query)
```

Executes a SQL statement that does not return a result set, such as an INSERT or UPDATE.

### ExecuteQuery(string query)

```csharp
public ResultSet ExecuteQuery(string query)
```

Executes a SQL query and returns the result set.

**Returns** `ResultSet`

### Dispose(bool disposing)

```csharp
protected virtual void Dispose(bool disposing)
```

Closes the underlying database; releases resources when disposing.
