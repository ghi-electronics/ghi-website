---
title: "SerialPort Class"
sidebar_label: "SerialPort"
---

# SerialPort Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Uart`<br/>**Assembly:** `System.IO.Ports`<br/>**Namespace:** `System.IO.Ports`

_No description available._

```csharp
public class SerialPort : IDisposable
```

## Constructors

### SerialPort()

```csharp
public SerialPort() : this( )
```

_No description available._

### SerialPort(string portName)

```csharp
public SerialPort(string portName)
```

_No description available._

### SerialPort(string portName, int baudRate)

```csharp
public SerialPort(string portName, int baudRate) : this(portName)
```

_No description available._

### SerialPort(string portName, int baudRate, Parity parity)

```csharp
public SerialPort(string portName, int baudRate, Parity parity) : this(portName, baudRate)
```

_No description available._

### SerialPort(string portName, int baudRate, Parity parity, int dataBits)

```csharp
public SerialPort(string portName, int baudRate, Parity parity, int dataBits) : this(portName, baudRate, parity)
```

_No description available._

### SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)

```csharp
public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : this(portName, baudRate, parity, dataBits)
```

_No description available._

## Properties

### PortName

```csharp
public string PortName { get; set; }
```

_No description available._

### BaudRate

```csharp
public int BaudRate { get; set; }
```

_No description available._

### Parity

```csharp
public Parity Parity { get; set; }
```

_No description available._

### DataBits

```csharp
public int DataBits { get; set; }
```

_No description available._

### StopBits

```csharp
public StopBits StopBits { get; set; }
```

_No description available._

### Handshake

```csharp
public Handshake Handshake { get; set; }
```

_No description available._

### ReadTimeout

```csharp
public int ReadTimeout { get; set; }
```

_No description available._

### WriteTimeout

```csharp
public int WriteTimeout { get; set; }
```

_No description available._

### ReadBufferSize

```csharp
public int ReadBufferSize { get; set; }
```

_No description available._

### WriteBufferSize

```csharp
public int WriteBufferSize { get; set; }
```

_No description available._

### ReceivedBytesThreshold

```csharp
public int ReceivedBytesThreshold { get; set; }
```

_No description available._

### NewLine

```csharp
public string NewLine { get; set; }
```

_No description available._

### Encoding

```csharp
public Encoding Encoding { get; set; }
```

_No description available._

### IsOpen

```csharp
public bool IsOpen { get; }
```

_No description available._

### BytesToRead

```csharp
public int BytesToRead { get; }
```

_No description available._

### BytesToWrite

```csharp
public int BytesToWrite { get; }
```

_No description available._

### CtsHolding

```csharp
public bool CtsHolding { get; }
```

_No description available._

### CDHolding

```csharp
public bool CDHolding { get; }
```

_No description available._

### DsrHolding

```csharp
public bool DsrHolding { get; }
```

_No description available._

### BreakState

```csharp
public bool BreakState { get; set; }
```

_No description available._

### DtrEnable

```csharp
public bool DtrEnable { get; set; }
```

_No description available._

### RtsEnable

```csharp
public bool RtsEnable { get; set; }
```

_No description available._

## Methods

### Open()

```csharp
public void Open()
```

_No description available._

### Close()

```csharp
public void Close()
```

_No description available._

### Dispose()

```csharp
public void Dispose()
```

_No description available._

### Read(byte[] buffer, int offset, int count)

```csharp
public int Read(byte[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### ReadByte()

```csharp
public int ReadByte()
```

_No description available._

**Returns** `int`

### ReadChar()

```csharp
public int ReadChar()
```

_No description available._

**Returns** `int`

### Read(char[] buffer, int offset, int count)

```csharp
public int Read(char[] buffer, int offset, int count)
```

_No description available._

**Returns** `int`

### ReadExisting()

```csharp
public string ReadExisting()
```

_No description available._

**Returns** `string`

### ReadLine()

```csharp
public string ReadLine()
```

_No description available._

**Returns** `string`

### ReadTo(string value)

```csharp
public string ReadTo(string value)
```

_No description available._

**Returns** `string`

### Write(string text)

```csharp
public void Write(string text)
```

_No description available._

### WriteLine(string text)

```csharp
public void WriteLine(string text)
```

_No description available._

### Write(byte[] buffer, int offset, int count)

```csharp
public void Write(byte[] buffer, int offset, int count)
```

_No description available._

### Write(char[] buffer, int offset, int count)

```csharp
public void Write(char[] buffer, int offset, int count)
```

_No description available._

### DiscardInBuffer()

```csharp
public void DiscardInBuffer()
```

_No description available._

### DiscardOutBuffer()

```csharp
public void DiscardOutBuffer()
```

_No description available._

### GetPortNames()

```csharp
public static string[] GetPortNames()
```

_No description available._

**Returns** `string[]`

## Events

### DataReceived

```csharp
public event SerialDataReceivedEventHandler DataReceived
```

_No description available._

### ErrorReceived

```csharp
public event SerialErrorReceivedEventHandler ErrorReceived
```

_No description available._

### PinChanged

```csharp
public event SerialPinChangedEventHandler PinChanged
```

_No description available._

## Fields

### InfiniteTimeout

```csharp
public const int InfiniteTimeout
```

_No description available._
