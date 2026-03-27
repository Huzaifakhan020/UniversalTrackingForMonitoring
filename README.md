ThermalGuard Universal Moniotoring 

A lightweight, beautifully designed hardware monitoring tool for Windows. Built in C# (WinForms), ThermalGuard provides highly accurate, real-time metrics for your CPU, GPU, and RAM. 

Unlike many custom monitors, ThermalGuard directly hooks into Windows OS-level diagnostics to ensure CPU usage perfectly mirrors Task Manager, while utilizing `LibreHardwareMonitorLib` for deep-level temperature and power readings.

Key Features

OS-Synced CPU Monitoring: Bypasses standard hardware polling to sync directly with Windows for 100% accurate "CPU Utility" readings (matching Task Manager).
Deep GPU Metrics: Real-time tracking of GPU Power Consumption (Watts), Temperature, and Core Load.
Memory Tracking: Live tracking of Total, Used, and Available RAM with color-coded threshold alerts.
Efficiency Scoring: Calculates a real-time system efficiency rating based on power draw vs. computing load.
Data Export & Logging: Automatically logs hardware telemetry to a background CSV file and can generate professional `.txt` system health reports on demand.
Custom Dark UI: Clean, borderless window design with draggable physics and dynamic progress bars.
Installation

You do not need to compile the code yourself to use ThermalGuard. 

1. Go to the [Releases](../../releases) tab on the right side of this page.
2. Download the latest `UniversalThermalGuardSetup.msi` and `setup.exe` files.
3. Run the installer to set up the app on your PC.
4. **IMPORTANT:** Right-click the desktop shortcut and select **Run as Administrator**. (Hardware temperature sensors require elevated privileges to be read by Windows).

Known Quirks & Troubleshooting

Blank CPU Temperatures? Make sure you are running the app as an Administrator. Motherboard-routed CPU sensors (SuperIO chips) hide their data from standard user accounts.
Anti-Cheat Interference: Aggressive kernel-level anti-cheat software (like Riot Vanguard) occasionally blocks the open-source hardware drivers `LibreHardwareMonitor` uses to read temperatures. If temps are blank, try exiting Vanguard from your system tray and relaunching ThermalGuard.

Tech Stack
* C# / .NET Framework
* Windows Forms (WinForms)
* [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (Hardware Polling)
* Windows PerformanceCounters (OS-level CPU Utility)
