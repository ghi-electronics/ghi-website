---
title: "FtpStatusCode Enum"
sidebar_label: "FtpStatusCode"
---

# FtpStatusCode Enum

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `System.Net`

Specifies the status codes returned for a File Transfer Protocol (FTP) operation.

```csharp
public enum FtpStatusCode
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Undefined` | `0` | Included for completeness; this value is never returned by servers. |
| `OpeningData` | `150` | Specifies that the server is opening the data connection. |
| `CommandOK` | `200` | Specifies that the command completed successfully. |
| `FileStatus` | `213` | Specifies the status of a file. |
| `ClosingData` | `226` | Specifies that the server is closing the data connection and the requested file action was successful. |
| `EnteringPassive` | `227` | Specifies that the server is entering passive mode. |
| `FileActionOK` | `250` | Specifies that the requested file action completed successfully. |
| `PathnameCreated` | `257` | Specifies that the requested path name was created. |
| `SendPasswordCommand` | `331` | Specifies that the server expects a password to be supplied. |
| `NeedLoginAccount` | `332` | Specifies that the server requires a login account to be supplied. |
| `FileCommandPending` | `350` | Specifies that the requested file action requires additional information. |
| `ActionAbortedLocalProcessingError` | `451` | Specifies that an error occurred that prevented the request action from completing. |
| `ArgumentSyntaxError` | `501` | Specifies that one or more command arguments has a syntax error. |
| `CommandNotImplemented` | `502` | Specifies that the command is not implemented by the FTP server. |
| `BadCommandSequence` | `503` | Specifies that the sequence of commands is not in the correct order. |
| `NotLoggedIn` | `530` | Specifies that login information must be sent to the server. |
| `AccountNeeded` | `532` | Specifies that a user account on the server is required. |
| `ActionNotTakenFileUnavailable` | `550` | Specifies that the requested action cannot be performed because the file is not available. |
| `ActionAbortedUnknownPageType` | `551` | Specifies that the requested action cannot be taken because the specified page type is unknown. |
| `FileActionAborted` | `552` | Specifies that the requested action cannot be performed. |
| `ActionNotTakenFilenameNotAllowed` | `553` | Specifies that the requested action cannot be performed on the specified file. |
