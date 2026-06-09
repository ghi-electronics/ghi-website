---
title: "NetworkCredential Class"
sidebar_label: "NetworkCredential"
---

# NetworkCredential Class

**NuGet:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Assembly:** `GHIElectronics.TinyCLR.Networking.Http`<br/>**Namespace:** `System.Net`

Class that keeps user name and password.

```csharp
public class NetworkCredential
```

## Constructors

### NetworkCredential()

```csharp
public NetworkCredential()
```

Construct class with empty user name and password

### NetworkCredential(string userName, string password)

```csharp
public NetworkCredential(string userName, string password) : this(userName, password, AuthenticationType.Basic)
```

Constructs credientials and initializes them by provided user name and pssword

| Parameter | Type | Description |
|---|---|---|
| `userName` | `string` |  |
| `password` | `string` |  |

### NetworkCredential(string userName, string password, AuthenticationType authenticationType)

```csharp
public NetworkCredential(string userName, string password, AuthenticationType authenticationType)
```

Initializes a new instance of the `NetworkCredential` class.

| Parameter | Type | Description |
|---|---|---|
| `userName` | `string` | Name of the user. |
| `password` | `string` | The password. |
| `authenticationType` | `AuthenticationType` | Type of the authentication. |

## Properties

### UserName

```csharp
public string UserName { get; set; }
```

Set or get user name.

### Password

```csharp
public string Password { get; set; }
```

Set or get password.

### AuthenticationType

```csharp
public AuthenticationType AuthenticationType { get; set; }
```

Gets or sets the type of the authentication.
