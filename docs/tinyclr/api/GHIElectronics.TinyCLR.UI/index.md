---
title: "GHIElectronics.TinyCLR.UI"
sidebar_label: Overview
---

# GHIElectronics.TinyCLR.UI

NuGet package containing **165** types across **7** namespaces (`GHIElectronics.TinyCLR.UI`, `GHIElectronics.TinyCLR.UI.Controls`, `GHIElectronics.TinyCLR.UI.Input`, `GHIElectronics.TinyCLR.UI.Media`, `GHIElectronics.TinyCLR.UI.Media.Imaging`, `GHIElectronics.TinyCLR.UI.Shapes`, `GHIElectronics.TinyCLR.UI.Threading`).

## Classes

| Class | Namespace | Summary |
|---|---|---|
| [BaseEvent](./BaseEvent.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [BindingErrorEventArgs](./BindingErrorEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` | Reported by controls (currently `TextBox`) when a reflection- based binding read or write fails. Subscribing is optional — the framework defaults to silent so a misspelled property name doesn't crash the UI, but a subscriber can log or surface the error. |
| [BitmapImage](./BitmapImage.md) | `GHIElectronics.TinyCLR.UI.Media.Imaging` |  |
| [BitmapSource](./BitmapSource.md) | `GHIElectronics.TinyCLR.UI.Media.Imaging` |  |
| [Border](./Border.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Brush](./Brush.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [Button](./Button.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ButtonDevice](./ButtonDevice.md) | `GHIElectronics.TinyCLR.UI.Input` | The ButtonDevice class represents the button device to the members of a context. |
| [ButtonEventArgs](./ButtonEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | The ButtonEventArgs class contains information about button states. |
| [Buttons](./Buttons.md) | `GHIElectronics.TinyCLR.UI.Input` | The Button class represents the button device to the members of a context. |
| [CancelEventArgs](./CancelEventArgs.md) | `GHIElectronics.TinyCLR.UI` |  |
| [Canvas](./Canvas.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Chart](./Chart.md) | `GHIElectronics.TinyCLR.UI.Controls` | Simple line / bar chart. The rendered surface is cached and only rebuilt when `Refresh` is called or the control's render size changes — so calling Invalidate on the parent each frame does not redo the chart math. |
| [ChartPoint](./ChartPoint.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ChartPointModel](./ChartPointModel.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [CheckBox](./CheckBox.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Colors](./Colors.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [Constants](./Constants.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [ContentControl](./ContentControl.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Control](./Control.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [DataGrid](./DataGrid.md) | `GHIElectronics.TinyCLR.UI.Controls` | The DataGrid component is a list-based component that provides a grid of rows and columns. |
| [DataGridColumn](./DataGridColumn.md) | `GHIElectronics.TinyCLR.UI.Controls` | Column descriptor for `DataGrid`. |
| [DataGridItem](./DataGridItem.md) | `GHIElectronics.TinyCLR.UI.Controls` | The DataGridItem class describes an item in a DataGrid component. |
| [DataGridItemComparer](./DataGridItemComparer.md) | `GHIElectronics.TinyCLR.UI.Controls` | The DataGridItemComparer class allows comparison between DataGridItems. |
| [DataItem](./DataItem.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [DeviceEvents](./DeviceEvents.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [Dispatcher](./Dispatcher.md) | `GHIElectronics.TinyCLR.UI.Threading` | Provides UI services for a thread. |
| [DispatcherFrame](./DispatcherFrame.md) | `GHIElectronics.TinyCLR.UI.Threading` | Representation of Dispatcher frame. |
| [DispatcherObject](./DispatcherObject.md) | `GHIElectronics.TinyCLR.UI.Threading` | A DispatcherObject is an object associated with a `Dispatcher`. A DispatcherObject instance should only be access by the dispatcher's thread. |
| [DispatcherOperation](./DispatcherOperation.md) | `GHIElectronics.TinyCLR.UI.Threading` | DispatcherOperation represents a delegate that has been posted to the Dispatcher queue. |
| [DispatcherTimer](./DispatcherTimer.md) | `GHIElectronics.TinyCLR.UI.Threading` | A timer that is integrated into the Dispatcher queues, and will be processed after a given amount of time |
| [DrawingContext](./DrawingContext.md) | `GHIElectronics.TinyCLR.UI.Media` | Drawing Context. |
| [Dropdown](./Dropdown.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Ellipse](./Ellipse.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [EventRoute](./EventRoute.md) | `GHIElectronics.TinyCLR.UI` | Container for the route to be followed by a RoutedEvent when raised |
| [FocusChangedEventArgs](./FocusChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | The FocusChangedEventArgs class contains information about focus states |
| [FocusNavigator](./FocusNavigator.md) | `GHIElectronics.TinyCLR.UI.Input` | PC-style tab order over the logical tree. Call from hardware mappings (e.g. next/previous) via `InputProvider.RaiseFocusNavigation`. |
| [Gauge](./Gauge.md) | `GHIElectronics.TinyCLR.UI.Controls` | Analog gauge with calibrated tick marks, optional threshold arc, optional seven-segment digital readout, dial label, and pointer needle. Always square — pass the side length to the constructor. Rendering is cached: the static background (dial face, calibration, threshold, digital number, label) is drawn once into a backing bitmap; only the pointer is redrawn each paint. Any property change marks the background dirty. |
| [GenericDevice](./GenericDevice.md) | `GHIElectronics.TinyCLR.UI.Input` | The GenericDevice class represents the Generic device to the members of a context. |
| [GenericEvent](./GenericEvent.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [GenericEventArgs](./GenericEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [GenericEvents](./GenericEvents.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [Grid](./Grid.md) | `GHIElectronics.TinyCLR.UI.Controls` | Row/column layout with pixel, auto, and star sizing (WPF-style subset). Use `GetRow` / `SetRow` and `GetColumn` / `SetColumn` on children. |
| [GridLengthCollection](./GridLengthCollection.md) | `GHIElectronics.TinyCLR.UI.Controls` | Notifying GridLength collection. Every mutation invalidates the owning Grid's measure pass so layout stays in sync without callers having to remember to call InvalidateMeasure() manually. |
| [Image](./Image.md) | `GHIElectronics.TinyCLR.UI.Controls` | Summary description for Image. |
| [ImageBrush](./ImageBrush.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [ImageSource](./ImageSource.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [InputDevice](./InputDevice.md) | `GHIElectronics.TinyCLR.UI.Input` | Provides the base class for all input devices. |
| [InputEventArgs](./InputEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [InputManager](./InputManager.md) | `GHIElectronics.TinyCLR.UI.Input` | The InputManager class is responsible for coordinating all of the input system in TinyCore. The input manager exists per Dispatcher |
| [InputProvider](./InputProvider.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [InputProviderSite](./InputProviderSite.md) | `GHIElectronics.TinyCLR.UI.Input` | The object which input providers use to report input to the input manager. |
| [InputReport](./InputReport.md) | `GHIElectronics.TinyCLR.UI.Input` | The InputReport is an abstract base class for all input that is reported to the InputManager. |
| [InputReportArgs](./InputReportArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | report arguments |
| [InputReportEventArgs](./InputReportEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | The InputReportEventArgs class contains information about an input report that is being processed. |
| [Line](./Line.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [LinearGradientBrush](./LinearGradientBrush.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [ListBox](./ListBox.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ListBoxItem](./ListBoxItem.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ListBoxItemCollection](./ListBoxItemCollection.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ListBoxItemHighlightable](./ListBoxItemHighlightable.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [MessageBox](./MessageBox.md) | `GHIElectronics.TinyCLR.UI.Controls` | WinForms-style modal message box. Usage: `MessageBox.DefaultFont = myFont; // once at app start var r = MessageBox.Show("Erase all data?", "Confirm", MessageBoxButtons.YesNo); if (r == DialogResult.Yes) { ... }` Show() is synchronous: it nests a dispatcher frame so the UI keeps painting and dispatching input while the box is up, and returns when the user picks a button (or Esc cancels). Safe to call from any UI-thread event handler. |
| [NotifyInputEventArgs](./NotifyInputEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | Provides information about an input event being processed by the input manager. |
| [OnScreenKeyboard](./OnScreenKeyboard.md) | `GHIElectronics.TinyCLR.UI` |  |
| [Panel](./Panel.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Pen](./Pen.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [Polygon](./Polygon.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [PreProcessInputEventArgs](./PreProcessInputEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | Allows the handler to cancel the processing of an input event. |
| [PresentationSource](./PresentationSource.md) | `GHIElectronics.TinyCLR.UI` | Presentation source is our connection to the rest of the managed system. |
| [ProcessInputEventArgs](./ProcessInputEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` | Provides access to the input manager's staging area. |
| [ProgressBar](./ProgressBar.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [PropertyChangedEventArgs](./PropertyChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI` | Provides data for the various property changed events. |
| [RadioButton](./RadioButton.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [RadioButtonManager](./RadioButtonManager.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [RawButtonInputReport](./RawButtonInputReport.md) | `GHIElectronics.TinyCLR.UI.Input` | The RawButtonInputReport class encapsulates the raw input provided from a keyboard. |
| [RawGenericInputReport](./RawGenericInputReport.md) | `GHIElectronics.TinyCLR.UI.Input` | The RawGenericInputReport class encapsulates the raw input provided from a keyboard. |
| [RawTouchInputReport](./RawTouchInputReport.md) | `GHIElectronics.TinyCLR.UI.Input` | The RawTouchInputReport class encapsulates the raw input provided from a multitouch source. |
| [Rectangle](./Rectangle.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [RoutedEvent](./RoutedEvent.md) | `GHIElectronics.TinyCLR.UI` | RoutedEvent is a unique identifier for any registered RoutedEvent |
| [RoutedEventArgs](./RoutedEventArgs.md) | `GHIElectronics.TinyCLR.UI` | The container for all state associated with a RoutedEvent |
| [RoutedEventHandlerInfo](./RoutedEventHandlerInfo.md) | `GHIElectronics.TinyCLR.UI` | Container for handler instance and other invocation preferences for this handler instance |
| [ScrollChangedEventArgs](./ScrollChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ScrollViewer](./ScrollViewer.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [SelectionChangedEventArgs](./SelectionChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Shape](./Shape.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [Slider](./Slider.md) | `GHIElectronics.TinyCLR.UI.Controls` | Horizontal or vertical value slider with optional tick marks and snap-to intervals. The knob is rendered with the shared Scale9 Button bitmaps so it picks up the theme's surface styling automatically. |
| [SolidColorBrush](./SolidColorBrush.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [StackPanel](./StackPanel.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [StagingAreaInputItem](./StagingAreaInputItem.md) | `GHIElectronics.TinyCLR.UI.Input` | This class encapsulates an input event while it is being processed by the input manager. |
| [TapCellEventArgs](./TapCellEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` | Tap cell event arguments. |
| [Text](./Text.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextBox](./TextBox.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextChangedEventArgs](./TextChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextFlow](./TextFlow.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextRun](./TextRun.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextRunCollection](./TextRunCollection.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Theme](./Theme.md) | `GHIElectronics.TinyCLR.UI` | Central palette for TinyCLR.UI. Brushes are shared instances; change `WindowBackground` etc. then replace the corresponding brush field if you need live updates. |
| [TouchCapture](./TouchCapture.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchDevice](./TouchDevice.md) | `GHIElectronics.TinyCLR.UI.Input` | The TouchDevice class represents the stylus/touch device to the members of a context. |
| [TouchEvent](./TouchEvent.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchEventArgs](./TouchEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchEvents](./TouchEvents.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchGestureEventArgs](./TouchGestureEventArgs.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchInput](./TouchInput.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [UIElement](./UIElement.md) | `GHIElectronics.TinyCLR.UI` |  |
| [UIElementCollection](./UIElementCollection.md) | `GHIElectronics.TinyCLR.UI` | A UIElementCollection is a ordered collection of UIElements. |
| [ValueChangedEventArgs](./ValueChangedEventArgs.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [VirtualizingListBox](./VirtualizingListBox.md) | `GHIElectronics.TinyCLR.UI.Controls` | Large homogeneous lists: recycles a small pool of rows while preserving full scroll extent. Set `ItemsSource` to an `IList` (e.g. `ArrayList`); each item is shown via `ToString()`. |
| [Window](./Window.md) | `GHIElectronics.TinyCLR.UI` |  |
| [WindowManager](./WindowManager.md) | `GHIElectronics.TinyCLR.UI` |  |

## Structs

| Struct | Namespace | Summary |
|---|---|---|
| [Color](./Color.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [Enumerator](./Enumerator.md) | `GHIElectronics.TinyCLR.UI` | This is a simple UIElementCollection enumerator that is based on the ArrayListEnumeratorSimple that is used for ArrayLists. The following comment is from the CLR people: For a straightforward enumeration of the entire ArrayList, this is faster, because it's smaller. Benchmarks showed this. |
| [GridLength](./GridLength.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |

## Interfaces

| Interface | Namespace | Summary |
|---|---|---|
| [INotifyBindablePropertyChanged](./INotifyBindablePropertyChanged.md) | `GHIElectronics.TinyCLR.UI` | Implement on view-models; raise `BindablePropertyChanged` with the property name (or null / empty to refresh all bindings on the object). |

## Enums

| Enum | Namespace | Summary |
|---|---|---|
| [BindingErrorDirection](./BindingErrorDirection.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [BrushMappingMode](./BrushMappingMode.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [ButtonState](./ButtonState.md) | `GHIElectronics.TinyCLR.UI.Input` | The ButtonState enumeration describes the state that buttons can be in. |
| [CaptureMode](./CaptureMode.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [ChartMode](./ChartMode.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [DialogResult](./DialogResult.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Direction](./Direction.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Direction](./Direction_2.md) | `GHIElectronics.TinyCLR.UI.Shapes` |  |
| [DispatcherOperationStatus](./DispatcherOperationStatus.md) | `GHIElectronics.TinyCLR.UI.Threading` | An enumeration describing the status of a DispatcherOperation. |
| [GridUnitType](./GridUnitType.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [HardwareButton](./HardwareButton.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [HorizontalAlignment](./HorizontalAlignment.md) | `GHIElectronics.TinyCLR.UI` |  |
| [InputDeviceType](./InputDeviceType.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [MessageBoxButtons](./MessageBoxButtons.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [Order](./Order.md) | `GHIElectronics.TinyCLR.UI.Controls` | The order in which rows are sorted. |
| [Orientation](./Orientation.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [RawButtonActions](./RawButtonActions.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [RawTouchActions](./RawTouchActions.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [RoutingStrategy](./RoutingStrategy.md) | `GHIElectronics.TinyCLR.UI` | Routing Strategy can be either of Tunnel or Bubble |
| [ScrollingStyle](./ScrollingStyle.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [SizeToContent](./SizeToContent.md) | `GHIElectronics.TinyCLR.UI` | SizeToContent |
| [Stretch](./Stretch.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [TextAlignment](./TextAlignment.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [TextTrimming](./TextTrimming.md) | `GHIElectronics.TinyCLR.UI.Media` |  |
| [TouchGesture](./TouchGesture.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchMessages](./TouchMessages.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [VerticalAlignment](./VerticalAlignment.md) | `GHIElectronics.TinyCLR.UI` |  |
| [Visibility](./Visibility.md) | `GHIElectronics.TinyCLR.UI` | Visibility - Enum which describes 3 possible visibility options. |

## Delegates

| Delegate | Namespace | Summary |
|---|---|---|
| [BindablePropertyChangedEventHandler](./BindablePropertyChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI` | PC-style change notification for simple MVVM binding (TinyCLR subset). |
| [BindingErrorEventHandler](./BindingErrorEventHandler.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [ButtonEventHandler](./ButtonEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | The delegate to use for handlers that receive ButtonEventArgs. |
| [CancelEventHandler](./CancelEventHandler.md) | `GHIElectronics.TinyCLR.UI` |  |
| [DispatcherOperationCallback](./DispatcherOperationCallback.md) | `GHIElectronics.TinyCLR.UI.Threading` | A convenient delegate to use for dispatcher operations. |
| [EventHandler](./EventHandler.md) | `GHIElectronics.TinyCLR.UI` |  |
| [FocusChangedEventHandler](./FocusChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | The delegate to use for handlers that receive FocusChangedEventArgs. |
| [GenericEventHandler](./GenericEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [InputEventHandler](./InputEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | The delegate to use for handlers that receive InputEventArgs. |
| [InputReportEventHandler](./InputReportEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | The delegate to use for handlers that receive InputReportEventArgs |
| [NotifyInputEventHandler](./NotifyInputEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | Delegate type for handles of events that use `NotifyInputEventArgs`. |
| [OnTapCell](./OnTapCell.md) | `GHIElectronics.TinyCLR.UI.Controls` | Tap cell event handler. |
| [PostRenderEventHandler](./PostRenderEventHandler.md) | `GHIElectronics.TinyCLR.UI` |  |
| [PreProcessInputEventHandler](./PreProcessInputEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | Delegate type for handles of events that use `PreProcessInputEventArgs`. |
| [ProcessInputEventHandler](./ProcessInputEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` | Delegate type for handles of events that use `ProcessInputEventArgs`. |
| [PropertyChangedEventHandler](./PropertyChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI` | Represents the method that will handle the event raised when a Property is changed |
| [RoutedEventHandler](./RoutedEventHandler.md) | `GHIElectronics.TinyCLR.UI` | RoutedEventHandler Definition |
| [ScrollChangedEventHandler](./ScrollChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [SelectionChangedEventHandler](./SelectionChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TextChangedEventHandler](./TextChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
| [TouchEventHandler](./TouchEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [TouchGestureEventHandler](./TouchGestureEventHandler.md) | `GHIElectronics.TinyCLR.UI.Input` |  |
| [ValueChangedEventHandler](./ValueChangedEventHandler.md) | `GHIElectronics.TinyCLR.UI.Controls` |  |
