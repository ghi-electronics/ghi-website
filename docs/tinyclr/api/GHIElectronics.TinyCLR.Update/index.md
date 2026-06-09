---
title: "GHIElectronics.TinyCLR.Update"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Update NuGet</h1>

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [ApplicationUpdate](./ApplicationUpdate.md) | `GHIElectronics.TinyCLR.Update` | Applies an over-the-air application update from a stream. Verifies the signature against `key`, then flashes and reboots into the new app. |
| [InFieldUpdate](./InFieldUpdate.md) | `GHIElectronics.TinyCLR.Update` | In-Field Update — feed firmware and/or application bytes in chunks, verify the signatures, then flash and reboot. Supports caching the chunks in RAM (faster) or to an external `StorageController` (handles images larger than free RAM). |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [CacheMode](./CacheMode.md) | `GHIElectronics.TinyCLR.Update` | Where the updater caches incoming chunks before flashing. |
