---
title: "SymbolType Enum"
sidebar_label: "SymbolType"
---

# SymbolType Enum

**Namespace:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures` · **Assembly:** `GHIElectronics.TinyCLR.RuntimeLoadableProcedures`

Classification of an ELF symbol.

```csharp
public enum SymbolType
```

## Fields

| Name | Value | Description |
|---|---|---|
| `None` | `0` | Untyped or section symbol. |
| `Object` | `1` | Data symbol (variable, array). |
| `Function` | `2` | Code symbol (function). |
| `Section` | `3` | Section symbol. |
