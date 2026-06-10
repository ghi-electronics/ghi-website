---
title: "ReadState Enum"
sidebar_label: "ReadState"
---

# ReadState Enum

**NuGet:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Assembly:** `GHIElectronics.TinyCLR.System.Xml`<br/>**Namespace:** `System.Xml`

Reader lifecycle state.

```csharp
public enum ReadState
```

## Fields

| Name | Value | Description |
|---|---|---|
| `Initial` | `0` | The Read method has not been called yet. |
| `Interactive` | `1` | The Read method has been called and more can be read. |
| `Error` | `2` | An error occurred that prevents further reading. |
| `EndOfFile` | `3` | The end of the file has been reached. |
| `Closed` | `4` | The reader has been closed. |
