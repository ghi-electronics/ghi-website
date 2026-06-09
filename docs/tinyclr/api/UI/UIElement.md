---
title: "UIElement Class"
sidebar_label: "UIElement"
---

# UIElement Class

**NuGet:** `GHIElectronics.TinyCLR.UI`<br/>**Assembly:** `GHIElectronics.TinyCLR.UI`<br/>**Namespace:** `GHIElectronics.TinyCLR.UI`

_No description available._

```csharp
public abstract class UIElement : DispatcherObject
```

## Constructors

### UIElement()

```csharp
protected UIElement()
```

_No description available._

## Properties

### ActualWidth

```csharp
public int ActualWidth { get; }
```

_No description available._

### ActualHeight

```csharp
public int ActualHeight { get; }
```

_No description available._

### Height

```csharp
public int Height { get; set; }
```

Frame height in pixels. _(inherited)_

### Width

```csharp
public int Width { get; set; }
```

Column width in pixels. _(inherited)_

### LogicalChildren

```csharp
protected internal UIElementCollection LogicalChildren { get; }
```

_No description available._

### IsFocused

```csharp
public bool IsFocused { get; }
```

A property indicating if the button is focused on this element or not.

### IsMeasureValid

```csharp
public bool IsMeasureValid { get; }
```

Determines if the DesiredSize is valid.

### IsArrangeValid

```csharp
public bool IsArrangeValid { get; }
```

Determines if the RenderSize and position of child elements is valid.

### Parent

```csharp
public UIElement Parent { get; }
```

_No description available._

### RootUIElement

```csharp
public UIElement RootUIElement { get; }
```

_No description available._

### HorizontalAlignment

```csharp
public HorizontalAlignment HorizontalAlignment { get; set; }
```

_No description available._

### VerticalAlignment

```csharp
public VerticalAlignment VerticalAlignment { get; set; }
```

_No description available._

### Visibility

```csharp
public Visibility Visibility { get; set; }
```

Visibility accessor

### IsVisible

```csharp
public bool IsVisible { get; }
```

A property indicating if this element is Visible or not.

### IsEnabled

```csharp
public bool IsEnabled { get; set; }
```

Fetches the value of the IsEnabled property

## Methods

### OnGenericEvent(GenericEventArgs e)

```csharp
protected virtual void OnGenericEvent(GenericEventArgs e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `GenericEventArgs` |  |

### OnTouchDown(TouchEventArgs e)

```csharp
protected virtual void OnTouchDown(TouchEventArgs e)
```

Handles the touch down event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchUp(TouchEventArgs e)

```csharp
protected virtual void OnTouchUp(TouchEventArgs e)
```

Handles the touch up event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchMove(TouchEventArgs e)

```csharp
protected virtual void OnTouchMove(TouchEventArgs e)
```

Handles the touch move event. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchEventArgs` | Touch event arguments. |

### OnTouchGestureStarted(TouchGestureEventArgs e)

```csharp
protected virtual void OnTouchGestureStarted(TouchGestureEventArgs e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchGestureEventArgs` |  |

### OnTouchGestureChanged(TouchGestureEventArgs e)

```csharp
protected virtual void OnTouchGestureChanged(TouchGestureEventArgs e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchGestureEventArgs` |  |

### OnTouchGestureEnded(TouchGestureEventArgs e)

```csharp
protected virtual void OnTouchGestureEnded(TouchGestureEventArgs e)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `e` | `TouchGestureEventArgs` |  |

### OnPreviewButtonDown(ButtonEventArgs e)

```csharp
protected virtual void OnPreviewButtonDown(ButtonEventArgs e)
```

An event reporting a button was pressed.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### OnButtonDown(ButtonEventArgs e)

```csharp
protected virtual void OnButtonDown(ButtonEventArgs e)
```

An event reporting a button was pressed.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### OnPreviewButtonUp(ButtonEventArgs e)

```csharp
protected virtual void OnPreviewButtonUp(ButtonEventArgs e)
```

An event reporting a button was released.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### OnButtonUp(ButtonEventArgs e)

```csharp
protected virtual void OnButtonUp(ButtonEventArgs e)
```

An event reporting a button was released.

| Parameter | Type | Description |
|---|---|---|
| `e` | `ButtonEventArgs` |  |

### OnGotFocus(FocusChangedEventArgs e)

```csharp
protected virtual void OnGotFocus(FocusChangedEventArgs e)
```

An event announcing that the buttons are focused on this element.

| Parameter | Type | Description |
|---|---|---|
| `e` | `FocusChangedEventArgs` |  |

### OnLostFocus(FocusChangedEventArgs e)

```csharp
protected virtual void OnLostFocus(FocusChangedEventArgs e)
```

An event announcing that the buttons is no longer focused on this element

| Parameter | Type | Description |
|---|---|---|
| `e` | `FocusChangedEventArgs` |  |

### GetDesiredSize(out int width, out int height)

```csharp
public void GetDesiredSize(out int width, out int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `out int` |  |
| `height` | `out int` |  |

### GetMargin(out int left, out int top, out int right, out int bottom)

```csharp
public void GetMargin(out int left, out int top, out int right, out int bottom)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `left` | `out int` |  |
| `top` | `out int` |  |
| `right` | `out int` |  |
| `bottom` | `out int` |  |

### SetMargin(int length)

```csharp
public void SetMargin(int length)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `length` | `int` |  |

### SetMargin(int left, int top, int right, int bottom)

```csharp
public void SetMargin(int left, int top, int right, int bottom)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `left` | `int` |  |
| `top` | `int` |  |
| `right` | `int` |  |
| `bottom` | `int` |  |

### IsHeightSet(out int height)

```csharp
protected internal bool IsHeightSet(out int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `height` | `out int` |  |

**Returns** `bool`

### IsWidthSet(out int width)

```csharp
protected internal bool IsWidthSet(out int width)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `out int` |  |

**Returns** `bool`

### GetLayoutOffset(out int x, out int y)

```csharp
public void GetLayoutOffset(out int x, out int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `out int` |  |
| `y` | `out int` |  |

### GetRenderSize(out int width, out int height)

```csharp
public void GetRenderSize(out int width, out int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `out int` |  |
| `height` | `out int` |  |

### OnChildrenChanged(UIElement added, UIElement removed, int indexAffected)

```csharp
protected internal virtual void OnChildrenChanged( UIElement added, UIElement removed, int indexAffected)
```

OnChildrenChanged is called when the UIElementCollection of the UIElement is edited.

| Parameter | Type | Description |
|---|---|---|
| `added` | `UIElement` |  |
| `removed` | `UIElement` |  |
| `indexAffected` | `int` |  |

### Measure(int availableWidth, int availableHeight)

```csharp
public void Measure(int availableWidth, int availableHeight)
```

Updates DesiredSize of the UIElement. Must be called by parents from their MeasureOverride, to form recursive update. This is first pass of layout update.

| Parameter | Type | Description |
|---|---|---|
| `availableWidth` | `int` | Available width that parent can give to the child. May be MaxValue (when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |
| `availableHeight` | `int` | Available height that parent can give to the child. May be MaxValue (when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |

### Arrange(int finalRectX, int finalRectY, int finalRectWidth, int finalRectHeight)

```csharp
public void Arrange(int finalRectX, int finalRectY, int finalRectWidth, int finalRectHeight)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `finalRectX` | `int` |  |
| `finalRectY` | `int` |  |
| `finalRectWidth` | `int` |  |
| `finalRectHeight` | `int` |  |

### MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)

```csharp
protected virtual void MeasureOverride(int availableWidth, int availableHeight, out int desiredWidth, out int desiredHeight)
```

Measurement override. Implement your size-to-content logic here.

| Parameter | Type | Description |
|---|---|---|
| `availableWidth` | `int` | Available size that parent can give to the child. May be MaxValue(when parent wants to measure to content). This is soft constraint. Child can return bigger size to indicate that it wants bigger space and hope that parent can throw in scrolling... |
| `availableHeight` | `int` |  |
| `desiredWidth` | `out int` |  |
| `desiredHeight` | `out int` |  |

### ArrangeOverride(int arrangeWidth, int arrangeHeight)

```csharp
protected virtual void ArrangeOverride(int arrangeWidth, int arrangeHeight)
```

ArrangeOverride allows for the customization of the final sizing and positioning of children.

| Parameter | Type | Description |
|---|---|---|
| `arrangeWidth` | `int` | Final width |
| `arrangeHeight` | `int` | Final height |

### UpdateLayout()

```csharp
public void UpdateLayout()
```

Call this method to ensure that the whoel subtree of elements that includes this UIElement is properly updated.

### ChildElementFromPoint(int x, int y)

```csharp
public UIElement ChildElementFromPoint(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `UIElement`

### GetUnclippedSize(out int width, out int height)

```csharp
public void GetUnclippedSize(out int width, out int height)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `width` | `out int` |  |
| `height` | `out int` |  |

### ContainsPoint(int x, int y)

```csharp
public bool ContainsPoint(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `bool`

### GetPointerTarget(int x, int y)

```csharp
public UIElement GetPointerTarget(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `UIElement`

### PointToScreen(ref int x, ref int y)

```csharp
public void PointToScreen(ref int x, ref int y)
```

We are deviating little from their desktop counter parts, mostly for simplicity and perf.

| Parameter | Type | Description |
|---|---|---|
| `x` | `ref int` |  |
| `y` | `ref int` |  |

### PointToClient(ref int x, ref int y)

```csharp
public void PointToClient(ref int x, ref int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `ref int` |  |
| `y` | `ref int` |  |

### InvalidateMeasure()

```csharp
public void InvalidateMeasure()
```

Invalidates the measurement state for the UIElement. This has the effect of also invalidating the arrange state for the UIElement. The UIElement will be queued for an update layout that will occur asynchronously.

### InvalidateArrange()

```csharp
public void InvalidateArrange()
```

Invalidates the arrange state for the UIElement. The UIElement will be queued for an update layout that will occur asynchronously. MeasureOverride will not be called unless InvalidateMeasure is also called - or that something else caused the measure state to be invalidated.

### OnChildDesiredSizeChanged(UIElement child)

```csharp
protected virtual void OnChildDesiredSizeChanged(UIElement child)
```

Notification that is called by Measure of a child when it ends up with different desired size for the child.

| Parameter | Type | Description |
|---|---|---|
| `child` | `UIElement` |  |

### OnRender(DrawingContext dc)

```csharp
public virtual void OnRender(DrawingContext dc)
```

Renders the DataGrid onto it's parent container's graphics. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

### RenderRecursive(DrawingContext dc)

```csharp
protected internal virtual void RenderRecursive(DrawingContext dc)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `dc` | `DrawingContext` |  |

### InvalidateRect(int x, int y, int w, int h)

```csharp
public void InvalidateRect(int x, int y, int w, int h)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |
| `w` | `int` |  |
| `h` | `int` |  |

### Invalidate()

```csharp
public void Invalidate()
```

_No description available._

### AddToEventRoute(EventRoute route, RoutedEventArgs args)

```csharp
public void AddToEventRoute(EventRoute route, RoutedEventArgs args)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `route` | `EventRoute` |  |
| `args` | `RoutedEventArgs` |  |

### AddHandler(RoutedEvent routedEvent, RoutedEventHandler handler, bool handledEventsToo)

```csharp
public void AddHandler( RoutedEvent routedEvent, RoutedEventHandler handler, bool handledEventsToo)
```

Adds a routed event handler for the particular `RoutedEvent`

| Parameter | Type | Description |
|---|---|---|
| `routedEvent` | `RoutedEvent` | `RoutedEvent` for which the handler is attached |
| `handler` | `RoutedEventHandler` | The handler that will be invoked on this object when the RoutedEvent is raised |
| `handledEventsToo` | `bool` | Flag indicating whether or not the listener wants to hear about events that have already been handled |

### PrintSize(int x, int y)

```csharp
public static string PrintSize(int x, int y)
```

_No description available._

| Parameter | Type | Description |
|---|---|---|
| `x` | `int` |  |
| `y` | `int` |  |

**Returns** `string`

## Events

### TouchUp

```csharp
public event TouchEventHandler TouchUp
```

_No description available._

### TouchMove

```csharp
public event TouchEventHandler TouchMove
```

_No description available._

### TouchGestureStart

```csharp
public event TouchGestureEventHandler TouchGestureStart
```

_No description available._

### TouchGestureChanged

```csharp
public event TouchGestureEventHandler TouchGestureChanged
```

_No description available._

### TouchGestureEnd

```csharp
public event TouchGestureEventHandler TouchGestureEnd
```

_No description available._

### IsVisibleChanged

```csharp
public event PropertyChangedEventHandler IsVisibleChanged
```

_No description available._

### IsEnabledChanged

```csharp
public event PropertyChangedEventHandler IsEnabledChanged
```

_No description available._

## Fields

### _horizontalAlignment

```csharp
protected HorizontalAlignment _horizontalAlignment
```

_No description available._

### _verticalAlignment

```csharp
protected VerticalAlignment _verticalAlignment
```

_No description available._
