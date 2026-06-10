---
title: "CanBitTiming Class"
sidebar_label: "CanBitTiming"
---

# CanBitTiming Class

**NuGet:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Assembly:** `GHIElectronics.TinyCLR.Devices.Can`<br/>**Namespace:** `GHIElectronics.TinyCLR.Devices.Can`

Bit-timing parameters for one phase (arbitration or data) of a CAN frame.

```csharp
public class CanBitTiming
```

## Constructors

### CanBitTiming()

```csharp
public CanBitTiming() : this(0, 0, 0, 0, false)
```

Constructs an uninitialized bit-timing object.

### CanBitTiming(int propagationPhase1, int phase2, int baudratePrescaler, int synchronizationJumpWidth)

```csharp
public CanBitTiming(int propagationPhase1, int phase2, int baudratePrescaler, int synchronizationJumpWidth) : this(propagationPhase1, phase2, baudratePrescaler, synchronizationJumpWidth, false)
```

Constructs a bit-timing object without multi-bit sampling.

### CanBitTiming(int propagationPhase1, int phase2, int baudratePrescaler, int synchronizationJumpWidth, bool useMultiBitSampling)

```csharp
public CanBitTiming(int propagationPhase1, int phase2, int baudratePrescaler, int synchronizationJumpWidth, bool useMultiBitSampling)
```

Constructs a fully specified bit-timing object.

## Properties

### Phase1

```csharp
public int Phase1 { get; set; }
```

Time segment 1 (propagation + phase 1) in time quanta.

### Phase2

```csharp
public int Phase2 { get; set; }
```

Time segment 2 (phase 2) in time quanta.

### BaudratePrescaler

```csharp
public int BaudratePrescaler { get; set; }
```

Clock divider applied to the controller's source clock to produce the time-quantum frequency.

### SynchronizationJumpWidth

```csharp
public int SynchronizationJumpWidth { get; set; }
```

Synchronization Jump Width (SJW), in time quanta.

### UseMultiBitSampling

```csharp
public bool UseMultiBitSampling { get; set; }
```

If true, the controller samples each bit three times and takes the majority value.
