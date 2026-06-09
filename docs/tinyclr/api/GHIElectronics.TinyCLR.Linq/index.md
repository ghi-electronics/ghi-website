---
title: "GHIElectronics.TinyCLR.Linq"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Linq NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Enumerable](./Enumerable.md) | `System.Linq` | LINQ to Objects on top of `IEnumerable{T}`. Subset of the .NET BCL surface picked for embedded use - covers the common filter / project / aggregate / order / group / convert operators. Lazy operators (Where, Select, etc.) use iterator state machines; terminal operators (ToArray, Sum, OrderBy, etc.) are eager. |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [IGrouping&lt;TKey, TElement>](./IGrouping.md) | `System.Linq` | Represents a collection of objects that have a common key. Returned by `GroupBy`. |
| [IOrderedEnumerable&lt;TElement>](./IOrderedEnumerable.md) | `System.Linq` | Represents a sorted sequence. Used as the chain link between `OrderBy`/`OrderByDescending` and `ThenBy`/`ThenByDescending`. |
