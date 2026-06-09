---
title: "UserAuthenticatorArgs Class"
sidebar_label: "UserAuthenticatorArgs"
---

# UserAuthenticatorArgs Class

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

_No description available._

```csharp
public class UserAuthenticatorArgs : EventArgs
```

## Constructors

### UserAuthenticatorArgs(string user, string pass)

```csharp
public UserAuthenticatorArgs(string user, string pass)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `user` | `string` |  |
| `pass` | `string` |  |

## Properties

### Result

```csharp
public UserAuthenticationResult Result { get; set; }
```

Returns the result of the operation if it has completed. _(inherited)_

## Fields

### User

```csharp
public string User
```

_No description available._

### Password

```csharp
public string Password
```

_No description available._
