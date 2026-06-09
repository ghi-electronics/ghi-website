---
title: "FtpWebResponse Class"
sidebar_label: "FtpWebResponse"
---

# FtpWebResponse Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`<br/>**Namespace:** `System.Net`

Only contains a stream to write data

```csharp
public class FtpWebResponse : WebResponse
```

## Methods

### GetResponseStream()

```csharp
public override Stream GetResponseStream()
```

When overridden in a descendant class, returns the data stream from the Internet resource. _(inherited)_

**Returns** `Stream` — An instance of the `System.IO.Stream` class for reading data from the Internet resource.

### Close()

```csharp
public override void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_
