---
slug: /
sidebar_position: 1
title: TinyCLR Getting Started
---

# Getting Started with TinyCLR

You're about to write C# that runs on real embedded hardware. This guide takes you from *"I just got a SITCore board"* to your first blinking LED.

## What you'll need

- A SITCore board — any SoC, SoM, SBC, or Dev Board
- A Windows PC with **Visual Studio 2022** (Community edition is fine)
- A USB cable

## Install the TinyCLR SDK

The TinyCLR SDK ships as a NuGet package — no separate installer.

1. Open Visual Studio and create a new **TinyCLR Application** project
2. Right-click the project → **Manage NuGet Packages**
3. Search for `GHIElectronics.TinyCLR.Core` and install the latest version

:::tip TinyCLR v3 is in beta
v3 brings generics and modern .NET features. Beta packages are tagged `-preview` on NuGet — install those to try v3 today.
:::

## Connect your board

Plug your SITCore board into your PC over USB. Windows recognizes it as a TinyCLR device automatically, and it appears in Visual Studio's **Device Explorer**.

## Your first program

```csharp
using GHIElectronics.TinyCLR.Devices.Gpio;
using System.Threading;

class Program {
    static void Main() {
        var gpio = GpioController.GetDefault();
        var led = gpio.OpenPin(SC20100.GpioPin.PE11);
        led.SetDriveMode(GpioPinDriveMode.Output);

        while (true) {
            led.Write(GpioPinValue.High);
            Thread.Sleep(500);
            led.Write(GpioPinValue.Low);
            Thread.Sleep(500);
        }
    }
}
```

Hit **F5** to deploy and debug. The on-board LED blinks at 1 Hz, and you can set breakpoints anywhere in your code — real step-through debugging on real hardware.

## Next steps

- Find your board's [pinout reference](/docs/tinyclr/) (coming soon)
- Read about [TinyCLR and the hardware it runs on](/tinyclr/) on the main site
- Browse [SITCore hardware options](/tinyclr/#choose-your-hardware)
