---
title: "GHIElectronics.TinyCLR.Update"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.Update

NuGet package containing **3** types.

## Classes

| Class | Summary |
|---|---|
| [ApplicationUpdate](./ApplicationUpdate.md) | Applies an over-the-air application update from a stream. Verifies the signature against `key`, then flashes and reboots into the new app. |
| [InFieldUpdate](./InFieldUpdate.md) | In-Field Update — feed firmware and/or application bytes in chunks, verify the signatures, then flash and reboot. Supports caching the chunks in RAM (faster) or to an external `StorageController` (handles images larger than free RAM). |

## Enums

| Enum | Summary |
|---|---|
| [CacheMode](./CacheMode.md) | Where the updater caches incoming chunks before flashing. |
