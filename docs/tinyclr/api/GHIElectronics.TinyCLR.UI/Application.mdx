---
title: "Application Class"
sidebar_label: "Application"
---

# Application Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

Application base class

```csharp
public class Application : DispatcherObject
```

## Constructors

### Application()

```csharp
public Application() : this(DisplayController.GetDefault())
```

Initializes a new application using the default display controller.

### Application(int width, int height)

```csharp
public Application(int width, int height)
```

Application constructor

### Application(DisplayController display)

```csharp
public Application(DisplayController display)
```

Application constructor

## Properties

### InputProvider

```csharp
public InputProvider InputProvider { get; set; }
```

Gets the input provider that feeds touch and button events into the application.

### Current

```csharp
static public Application Current { get; }
```

The Current property enables the developer to always get to the application in AppDomain in which they are running.

### Windows

```csharp
public WindowCollection Windows { get; }
```

The Windows property exposes a WindowCollection object, from which a developer can iterate over all the windows that have been opened in the current application.

### MainWindow

```csharp
public Window MainWindow { get; set; }
```

The MainWindow property indicates the primary window of the application.

### ShutdownMode

```csharp
public ShutdownMode ShutdownMode { get; set; }
```

The ShutdownMode property is called to set the shutdown specific mode of the application. Setting this property controls the way in which an application will shutdown. The three values for the ShutdownMode enum are : OnLastWindowClose OnMainWindowClose OnExplicitShutdown OnLastWindowClose - this mode will shutdown the application when the last window is closed, or an explicit call is made to Application.Shutdown(). This is the default mode. OnMainWindowClose - this mode will shutdown the application when the main window has been closed, or Application.Shutdown() is called. Note that if the MainWindow property has not been set - this mode is equivalent to OnExplicitOnly. OnExplicitShutdown- this mode will shutdown the application only when an explicit call to OnShutdown() has been made.

## Methods

### Run()

```csharp
public void Run()
```

Run is called to start an application. Typically a developer will do some setting of properties/attaching to events after instantiating an application object, and then call Run() to start the application.

### Run(Window window)

```csharp
public void Run(Window window)
```

Run is called to start an application. Typically a developer will do some setting of properties/attaching to events after instantiating an application object, and then call Run() to start the application.

| Parameter | Type | Description |
|---|---|---|
| `window` | `Window` | Window that will be added to the Windows property and made the MainWindow of the Applcation. The passed Window must be created on the same thread as the Application object. Furthermore, this Window is shown once the Application is run. |

### Shutdown()

```csharp
public void Shutdown()
```

Shutdown is called to programmatically shutdown an application. Once shutdown() is called, the application gets called with the OnShutdown method to raise the Shutdown event.

### InitializeForEventSource()

```csharp
public void InitializeForEventSource()
```

Registers the application as an input source so it can receive and report input.

### OnEvent(BaseEvent ev)

```csharp
public bool OnEvent(BaseEvent ev)
```

Routes a raw input event to the appropriate target window and queues it for processing.

**Returns** `bool`

### OnStartup(EventArgs e)

```csharp
protected virtual void OnStartup(EventArgs e)
```

OnStartup is called to raise the Startup event. The developer will typically override this method if they want to take action at startup time ( or they may choose to attach an event). This method will be called once when the application begins, once that application's Run() method has been called.

| Parameter | Type | Description |
|---|---|---|
| `e` | `EventArgs` | The event args that will be passed to the Startup event |

### OnExit(EventArgs e)

```csharp
protected virtual void OnExit(EventArgs e)
```

OnExit is called to raise the Exit event. The developer will typically override this method if they want to take action when the application exits ( or they may choose to attach an event).

| Parameter | Type | Description |
|---|---|---|
| `e` | `EventArgs` | The event args that will be passed to the Exit event |

## Events

### Startup

```csharp
public event EventHandler Startup
```

The Startup event is fired when an application is starting. This event is raised by the OnStartup method.

### Exit

```csharp
public event EventHandler Exit
```

The Exit event is fired when an application is shutting down. This event is raised by the OnExit method.
