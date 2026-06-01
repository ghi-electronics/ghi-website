---
slug: /
sidebar_position: 1
title: Endpoint Getting Started
---

# Getting Started with Endpoint

Endpoint is GHI Electronics' embedded Linux platform — a 650 MHz ARM running **.NET 8 or Python 3**, with mikroBUS expansion and an RT co-processor for hard real-time work. No toolchain pain. Just plug it in and write code.

## What you'll need

- An **Endpoint Domino** board (`EP-DOMINO-24-B`, $49.95 on Amazon)
- A USB-C cable for power and serial console
- An SSH client (Windows Terminal, PuTTY, or your IDE's terminal)

## Power up and connect

Plug the Domino into your PC via USB-C — it powers on automatically. A serial console appears as a COM port on Windows or `/dev/ttyACM0` on Linux/Mac. Press Enter to get the Endpoint login prompt.

Default credentials:

- User: `endpoint`
- Password: `endpoint`

## Hello, world

### In C# (.NET 8)

```bash
endpoint@domino:~$ mkdir hello && cd hello
endpoint@domino:~/hello$ dotnet new console
endpoint@domino:~/hello$ dotnet run
Hello, World!
```

### In Python 3

```bash
endpoint@domino:~$ python3 -c "print('Hello, World!')"
Hello, World!
```

That's it — modern .NET or Python on a Linux board with no cross-compile dance.

## Next steps

- Explore [Endpoint hardware](/endpoint/) — pinouts, peripherals, mikroBUS sockets
- Try a [mikroBUS Click peripheral](https://www.mikroe.com/click) — over 1,500 add-on boards
- Learn the **RT co-processor** for hard real-time control alongside Linux
