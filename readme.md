RestartDisplayDriver (Win+Ctrl+Shift+B Hotkey Wrapper)
====================================================

Overview
--------
Small .NET 8 console utility that programmatically sends the Windows hotkey Win + Ctrl + Shift + B which instructs Windows to reset / restart the graphics (display) driver. This is sometimes useful when the display becomes unresponsive, flickers, or after recovering from a graphics-related crash.

How It Works
------------
The program uses the InputSimulator library to synthesize a modified keystroke:
  LWIN + CONTROL + SHIFT + B
This is the same as physically pressing the keys. Windows handles the sequence and performs the display driver reset (you may hear a beep and the screen may briefly flash).

Prerequisites
-------------
- Windows 10 or Windows 11 desktop environment
- .NET 8 SDK (if building from source)

Build
-----
1. Clone repository
2. Navigate to RestartDisplayDriver directory
3. Run: dotnet build -c Release
4. The executable will be in: bin/Release/net8.0/

Run
---
From a terminal in the output directory:
  dotnet RestartDisplayDriver.dll
(or run the generated .exe directly). The process exits immediately after sending the hotkey.

Use Cases
---------
- Rapid shortcut / scriptable trigger to restart display driver
- Adding to automation, PowerShell scripts, or a custom recovery batch
- Pinning a shortcut to taskbar / Start for quick manual access

Notes & Safety
--------------
- This does NOT forcibly kill GPU processes; it just invokes the standard Windows mechanism.
- A brief screen flicker and system beep are normal.
- No elevated permissions normally required.
- Use at your own risk; frequent resets are not a substitute for fixing underlying driver or hardware problems.

Customization Ideas
-------------------
- Add logging / console output
- Add delay or retry logic
- Wrap in a tray app with a button
- Global hotkey registration instead of immediate fire on launch

Dependencies
------------
- NuGet: InputSimulator (1.0.4)

Code Summary
------------
Program.cs creates an InputSimulator instance and sends the modified keystroke, then exits.

Uninstall / Removal
-------------------
Delete the compiled files or the project folder. No registry keys or external state are created.

License
-------
Add a license of your choice (e.g., MIT) if distributing. (Not provided here by default.)

Disclaimer
----------
Provided as-is for convenience. No warranties. Use at your own risk.
