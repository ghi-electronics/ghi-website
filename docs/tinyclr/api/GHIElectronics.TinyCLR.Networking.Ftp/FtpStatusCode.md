---
title: "FtpStatusCode Enum"
sidebar_label: "FtpStatusCode"
---

# FtpStatusCode Enum

**Namespace:** `System.Net` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

_No description available._

```csharp
public enum FtpStatusCode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Undefined` | `0` |  |
| `OpeningData` | `150` |  |
| `CommandOK` | `200` |  |
| `FileStatus` | `213` |  |
| `ClosingData` | `226` |  |
| `EnteringPassive` | `227` |  |
| `FileActionOK` | `250` |  |
| `PathnameCreated` | `257` |  |
| `SendPasswordCommand` | `331` |  |
| `NeedLoginAccount` | `332` |  |
| `FileCommandPending` | `350` |  |
| `ActionAbortedLocalProcessingError` | `451` |  |
| `ArgumentSyntaxError` | `501` |  |
| `CommandNotImplemented` | `502` |  |
| `BadCommandSequence` | `503` |  |
| `NotLoggedIn` | `530` |  |
| `AccountNeeded` | `532` |  |
| `ActionNotTakenFileUnavailable` | `550` |  |
| `ActionAbortedUnknownPageType` | `551` |  |
| `FileActionAborted` | `552` |  |
| `ActionNotTakenFilenameNotAllowed` | `553` |  |
