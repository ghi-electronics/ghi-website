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

Bits per second. _(inherited)_

### Parity

```csharp
public Parity Parity { get; set; }
```

Parity policy. _(inherited)_

### DataBits

```csharp
public int DataBits { get; set; }
```

Frame width in data bits (typically 7 or 8). _(inherited)_

### StopBits

```csharp
public StopBits StopBits { get; set; }
```

Stop-bit policy. _(inherited)_

### Handshake

```csharp
public Handshake Handshake { get; set; }
```

_No description available._

### ReadTimeout

```csharp
public int ReadTimeout { get; set; }
```

How long to wait before timing out a read operation. _(inherited)_

### WriteTimeout

```csharp
public int WriteTimeout { get; set; }
```

How long to wait before timing out a write operation. _(inherited)_

### ReadBufferSize

```csharp
public int ReadBufferSize { get; set; }
```

Size in bytes of the receive buffer. _(inherited)_

### WriteBufferSize

```csharp
public int WriteBufferSize { get; set; }
```

Size in bytes of the transmit buffer. _(inherited)_

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

The number of bytes available to read. _(inherited)_

### BytesToWrite

```csharp
public int BytesToWrite { get; }
```

The number of bytes that are in the process of being written. _(inherited)_

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

Powers on and initializes the media. _(inherited)_

### Close()

```csharp
public void Close()
```

When overridden by a descendant class, closes the response stream. _(inherited)_

### Dispose()

```csharp
public void Dispose()
```

Releases buffered memory (the unmanaged firmware/application buffers). _(inherited)_

### Read(byte[] buffer, int offset, int count)

```csharp
public int Read(byte[] buffer, int offset, int count)
```

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array at which read bytes will be placed. |
| `count` | `int` | The maximun number of bytes to read. |

**Returns** `int`

### ReadByte()

```csharp
public int ReadByte()
```

Reads a single byte (drives 0xFF on the bus to sample the slave). _(inherited)_

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

Reads a block of bytes from the stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `offset` | `int` | The byte offset in the array at which read bytes will be placed. |
| `count` | `int` | The maximun number of bytes to read. |

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

Read data the file stream provided in the paramenter _(inherited)_

**Returns** `string`

### Write(string text)

```csharp
public void Write(string text)
```

Write a fileinfo or directoryinfo to the socket _(inherited)_

### WriteLine(string text)

```csharp
public void WriteLine(string text)
```

_No description available._

### Write(byte[] buffer, int offset, int count)

```csharp
public void Write(byte[] buffer, int offset, int count)
```

Writes a block of bytes to the file stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `byte[]` |  |
| `offset` | `int` | The byte offset in the array from which to start writing bytes to the stream. |
| `count` | `int` | The number of bytes to write. |

### Write(char[] buffer, int offset, int count)

```csharp
public void Write(char[] buffer, int offset, int count)
```

Writes a block of bytes to the file stream. _(inherited)_

| Parameter | Type | Description |
|---|---|---|
| `buffer` | `char[]` |  |
| `offset` | `int` | The byte offset in the array from which to start writing bytes to the stream. |
| `count` | `int` | The number of bytes to write. |

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

Raised when receive data becomes available. _(inherited)_

### ErrorReceived

```csharp
public event SerialErrorReceivedEventHandler ErrorReceived
```

Raised when a frame/parity/overrun error is detected. _(inherited)_

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
