---
title: "GHIElectronics.TinyCLR.Collections"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">Collections Library</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [HashSet&lt;T>](./HashSet.md) | `System.Collections.Generic` | Hash-table-based generic set. Mirrors the .NET BCL surface for the subset we ship. Same chained-collision layout and prime-table sizing as `Dictionary{TKey, TValue}`; the entry holds the element directly instead of a key/value pair. null IS a valid element when T is a reference type — the comparer (`EqualityComparer{T}.Default`) treats null consistently (GetHashCode(null) = 0, Equals(null, null) = true). |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [Enumerator](./Enumerator.md) | `System.Collections.Generic` |  |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [ISet&lt;T>](./ISet.md) | `System.Collections.Generic` | Generic set abstraction. Mirrors the .NET BCL `System.Collections.Generic.ISet<T>` shape so HashSet&lt;T> and future set implementations interop cleanly with portable BCL-using code. |
