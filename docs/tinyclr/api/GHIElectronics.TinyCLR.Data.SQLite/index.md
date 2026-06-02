---
title: "GHIElectronics.TinyCLR.Data.SQLite"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Data.SQLite

NuGet package containing **6** types.

## Classes

| Class | Summary |
|---|---|
| [OpenException](./OpenException.md) | Thrown when a database file cannot be opened. |
| [QueryExecutionException](./QueryExecutionException.md) | Thrown when SQLite returns an error during query execution. |
| [QueryFinalizationException](./QueryFinalizationException.md) | Thrown when SQLite fails to finalize (release) a prepared statement. |
| [QueryPrepareException](./QueryPrepareException.md) | Thrown when SQLite cannot prepare (compile) a query. |
| [ResultSet](./ResultSet.md) | Result of a SQL SELECT — rows × columns plus column-name metadata. Index by `this[row]` for an ArrayList of cells in that row, or `this[row, column]` for an individual cell. |
| [SQLiteDatabase](./SQLiteDatabase.md) | SQLite database handle. Open an in-memory database with the parameterless constructor or a file-backed database via the path constructor. Use `ExecuteNonQuery` for inserts/updates and `ExecuteQuery` for SELECTs that return a `ResultSet`. |
