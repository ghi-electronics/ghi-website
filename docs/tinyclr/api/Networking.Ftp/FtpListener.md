---
title: "FtpListener Class"
sidebar_label: "FtpListener"
---

# FtpListener Class

**Namespace:** `GHIElectronics.TinyCLR.Networking` · **Assembly:** `GHIElectronics.TinyCLR.Networking.Ftp`

The base class for all Ftp listeners implemented all basic functionalities like context queue management, authentication events

```csharp
public class FtpListener : IDisposable
```

## Constructors

### FtpListener()

```csharp
public FtpListener() : this(true)
```

_No description available._

## Properties

### Prefixes

```csharp
public ArrayList Prefixes { get; }
```

List of prefixes that the listener is listening to

### IsListening

```csharp
public bool IsListening { get; }
```

Flag indicates whether the listener is listening to contexts or not

## Methods

### AutoResetEvent( false)

```csharp
protected AutoResetEvent m_ContextQueueLock = new AutoResetEvent(false)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `false` | `` |  |

**Returns** `AutoResetEvent m_ContextQueueLock = new`

### Start()

```csharp
public virtual void Start()
```

Start the listener

### Stop()

```csharp
public virtual void Stop()
```

Stop the listener

### GetContext()

```csharp
public FtpListenerContext GetContext()
```

Get the oldest context from the context queue the method would be block until there is a pending context

**Returns** `FtpListenerContext`

## Events

### AuthenticationEvent

```csharp
public static event UserAuthenticator AuthenticationEvent
```

_No description available._

## Fields

### m_ContextQueue

```csharp
protected Queue m_ContextQueue
```

_No description available._

### m_Prefixes

```csharp
protected ArrayList m_Prefixes
```

_No description available._
