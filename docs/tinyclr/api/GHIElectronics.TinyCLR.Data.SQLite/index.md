---
title: "GHIElectronics.TinyCLR.Data.SQLite"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Data.SQLite</h1>

**NuGet:** `GHIElectronics.TinyCLR.Data.SQLite`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [OpenException](./OpenException.md) | `GHIElectronics.TinyCLR.Data.SQLite` | Thrown when a database file cannot be opened. |
| [QueryExecutionException](./QueryExecutionException.md) | `GHIElectronics.TinyCLR.Data.SQLite` | Thrown when SQLite returns an error during query execution. |
| [QueryFinalizationException](./QueryFinalizationException.md) | `GHIElectronics.TinyCLR.Data.SQLite` | Thrown when SQLite fails to finalize (release) a prepared statement. |
| [QueryPrepareException](./QueryPrepareException.md) | `GHIElectronics.TinyCLR.Data.SQLite` | Thrown when SQLite cannot prepare (compile) a query. |
| [ResultSet](./ResultSet.md) | `GHIElectronics.TinyCLR.Data.SQLite` | Result of a SQL SELECT — rows × columns plus column-name metadata. Index by `this[row]` for an ArrayList of cells in that row, or `this[row, column]` for an individual cell. |
| [SQLiteDatabase](./SQLiteDatabase.md) | `GHIElectronics.TinyCLR.Data.SQLite` | SQLite database handle. Open an in-memory database with the parameterless constructor or a file-backed database via the path constructor. Use `ExecuteNonQuery` for inserts/updates and `ExecuteQuery` for SELECTs that return a `ResultSet`. |
