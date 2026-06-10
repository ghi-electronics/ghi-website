---
title: "GHIElectronics.TinyCLR.Networking.Ftp"
hide_title: true
sidebar_label: Overview
---

<h1 className="api-package-heading">GHIElectronics.TinyCLR.Networking.Ftp</h1>

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [Ftp](./Ftp.md) | `System.Net` | Represents the types of FTP protocol methods that can be used with an FTP request. |
| [Ftp](./Ftp_2.md) | `GHIElectronics.TinyCLR.Networking` | FTP protocol method names used by the server's command handling. |
| [FTPCommand](./FTPCommand.md) | `System.Net` | Ftp command class |
| [FtpDefaultListener](./FtpDefaultListener.md) | `GHIElectronics.TinyCLR.Networking.Ftp` | The fallback FTP listener that serves contexts not claimed by any other listener. |
| [FtpFilesystemListener](./FtpFilesystemListener.md) | `GHIElectronics.TinyCLR.Networking.Ftp` | An FTP listener that serves files from a real filesystem directory under a virtual root. |
| [FtpListener](./FtpListener.md) | `GHIElectronics.TinyCLR.Networking` | The base class for all Ftp listeners implemented all basic functionalities like context queue management, authentication events |
| [FtpListenerContext](./FtpListenerContext.md) | `GHIElectronics.TinyCLR.Networking` | A Context containing an ftp request and a response scratch that should be completed by listeners |
| [FtpListenerRequest](./FtpListenerRequest.md) | `GHIElectronics.TinyCLR.Networking` | The ftp request |
| [FtpListenerResponse](./FtpListenerResponse.md) | `GHIElectronics.TinyCLR.Networking` | The ftp response |
| [FtpMemoryListener](./FtpMemoryListener.md) | `GHIElectronics.TinyCLR.Networking.Ftp` | An FTP listener that serves a fixed in-memory set of files and an activity log. |
| [FtpResponseStream](./FtpResponseStream.md) | `GHIElectronics.TinyCLR.Networking` | A virtual stream to do the read / write job from / to sockets |
| [FtpWebRequest](./FtpWebRequest.md) | `System.Net` | FtpWebRequest - first implement Active mode |
| [FtpWebResponse](./FtpWebResponse.md) | `System.Net` | Only contains a stream to write data |
| [PrefixList](./PrefixList.md) | `GHIElectronics.TinyCLR.Networking` | A list to store prefixes |
| [UserAuthenticatorArgs](./UserAuthenticatorArgs.md) | `GHIElectronics.TinyCLR.Networking` | Provides the user name and password for an authentication request and carries back the result. |
| [UserInfo](./UserInfo.md) | `GHIElectronics.TinyCLR.Networking.Ftp` | User information containing username and password |
| [WebRequestMethods](./WebRequestMethods.md) | `System.Net` | Container for the FTP protocol method names that can be used with a web request. |
| [WebRequestMethodsEx](./WebRequestMethodsEx.md) | `GHIElectronics.TinyCLR.Networking` | Additional FTP protocol method names used internally by the server. |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [FtpStatusCode](./FtpStatusCode.md) | `System.Net` | Specifies the status codes returned for a File Transfer Protocol (FTP) operation. |
| [UserAuthenticationResult](./UserAuthenticationResult.md) | `GHIElectronics.TinyCLR.Networking` | User anthentication result |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [UserAuthenticator](./UserAuthenticator.md) | `GHIElectronics.TinyCLR.Networking` | Represents the method that handles user authentication for the FTP server. |
