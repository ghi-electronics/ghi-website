---
title: "MessageRouterObject Class"
sidebar_label: "MessageRouterObject"
---

# MessageRouterObject Class

**Namespace:** `GHIElectronics.TinyCLR.EthernetIP.Scanner.ObjectLibrary` · **Assembly:** `GHIElectronics.TinyCLR.EthernetIP.Scanner`

_No description available._

```csharp
public class MessageRouterObject
```

## Properties

### ObjectList

```csharp
public ObjectListStruct ObjectList { get; }
```

gets the Object List / Read "Message Router Object" Class Code 0x02 - Attribute ID 1

### NumberAvailable

```csharp
public ushort NumberAvailable { get; }
```

gets the Maximum of connections supported / Read "Message Router Object" Class Code 0x02 - Attribute ID 2

### NumberActive

```csharp
public ushort NumberActive { get; }
```

gets the number of active connections / Read "Message Router Object" Class Code 0x02 - Attribute ID 3

### ActiveConnections

```csharp
public ushort[] ActiveConnections { get; }
```

gets the active connections / Read "Message Router Object" Class Code 0x02 - Attribute ID 4
