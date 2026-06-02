---
title: "GHIElectronics.TinyCLR.Collections"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Collections

NuGet package containing **3** types.

## Classes

| Class | Summary |
|---|---|
| [HashSet&lt;T>](./HashSet.md) | Hash-table-based generic set. Mirrors the .NET BCL surface for the subset we ship. Same chained-collision layout and prime-table sizing as `Dictionary{TKey, TValue}`; the entry holds the element directly instead of a key/value pair. null IS a valid element when T is a reference type — the comparer (`EqualityComparer{T}.Default`) treats null consistently (GetHashCode(null) = 0, Equals(null, null) = true). |

## Structs

| Struct | Summary |
|---|---|
| [Enumerator](./Enumerator.md) |  |

## Interfaces

| Interface | Summary |
|---|---|
| [ISet&lt;T>](./ISet.md) | Generic set abstraction. Mirrors the .NET BCL `System.Collections.Generic.ISet&lt;T&gt;` shape so HashSet&lt;T&gt; and future set implementations interop cleanly with portable BCL-using code. |
