using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UniversalTrackingForMonitoring
{
    public partial class Form1 : Form
    {
        Computer myPC;
        IGpuProvider gpuProvider = null;
        bool isRunning = true;
        List<float> efficiencyHistory = new List<float>();
        string gpuName = "Detecting...";
        string cpuName = "Detecting...";
        DateTime startTime;
        System.Windows.Forms.Timer timerDateTime;
        private PerformanceCounter cpuUtilityCounter;

        // RAM variables
        private float totalRAMGB = 0;
        private float usedRAMGB = 0;
        private float ramUsagePercent = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "ThermalGuard - Live Monitoring System";

            startTime = DateTime.Now;
            InitializeTimer();

            lblUserGreeting.Text = "Welcome!";

            // ADD THIS TO WAKE UP THE WINDOWS UTILITY SENSOR
            try
            {
                cpuUtilityCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
                cpuUtilityCounter.NextValue(); // First read is always 0, so we do a throwaway read
            }
            catch { }
        }

        private void InitializeTimer()
        {
            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += (s, e) =>
            {
                if (!IsDisposed && IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        UpdateDigitalClock();

                        string timeRunning = $" | Running: {(DateTime.Now - startTime).Hours}h {(DateTime.Now - startTime).Minutes}m";
                        lblFooter.Text = $"ThermalGuard v1.0 | {DateTime.Now:dddd, MMMM dd, yyyy} | {DateTime.Now:HH:mm:ss}{timeRunning} | Free Hardware Monitoring Tool";
                    });
                }
            };
            timerDateTime.Start();
        }

        private void UpdateDigitalClock()
        {
            if (!IsDisposed && IsHandleCreated)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
                    lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
                });
            }
        }

        private void GetRAMInfo()
        {
            try
            {
                // Get total installed RAM
                ulong totalInstalledRAM = 0;
                using (var searcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        totalInstalledRAM += Convert.ToUInt64(obj["Capacity"]);
                    }
                }

                // Get available/free RAM
                using (var searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        ulong totalVisibleMemory = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);
                        ulong freeMemory = Convert.ToUInt64(obj["FreePhysicalMemory"]);

                        totalRAMGB = (float)(totalInstalledRAM / (1024.0 * 1024.0 * 1024.0));
                        float totalVisibleGB = (float)(totalVisibleMemory / (1024 * 1024));
                        float freeRAMGB = (float)(freeMemory / (1024 * 1024));
                        usedRAMGB = totalVisibleGB - freeRAMGB;
                        ramUsagePercent = (usedRAMGB / totalVisibleGB) * 100;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"RAM Info Error: {ex.Message}");
                totalRAMGB = 0;
                usedRAMGB = 0;
                ramUsagePercent = 0;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(() => HardwareEngineLoop(), TaskCreationOptions.LongRunning);
        }

        private void UpdateUI(float gpuPower, float gpuTemp, float gpuLoad, float cpuTemp, float cpuUsage,
                              float efficiency, float totalRAM, float usedRAM, float ramPercent)
        {
            if (!IsDisposed && IsHandleCreated)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    try
                    {
                        // Update GPU metrics
                        lblPowerValue.Text = $"{gpuPower:F0}W";
                        lblTempValue.Text = $"{gpuTemp:F0}°C";
                        lblUsageValue.Text = $"{gpuLoad:F0}%";
                        progressPower.Value = Math.Min((int)gpuPower, 300);
                        progressTemp.Value = Math.Min((int)gpuTemp, 100);

                        // Update GPU Name
                        lblGPUName.Text = gpuName;

                        // Update CPU metrics
                        lblCPUTempValue.Text = $"{cpuTemp:F0}°C";
                        lblCPUUsageValue.Text = $"{cpuUsage:F0}%";
                        progressCPUTemp.Value = Math.Min((int)cpuTemp, 100);
                        progressCPUUsage.Value = Math.Min((int)cpuUsage, 100);

                        // Update CPU Name
                        lblCPUName.Text = cpuName;

                        // Update RAM metrics
                        lblTotalRAMValue.Text = $"{totalRAM:F1} GB";
                        lblUsedRAMValue.Text = $"{usedRAM:F1} GB";
                        lblRAMUsageValue.Text = $"{ramPercent:F0}%";
                        progressRAM.Value = Math.Min((int)ramPercent, 100);

                        // RAM usage color coding
                        if (ramPercent > 90)
                        {
                            progressRAM.ForeColor = Color.Red;
                            lblRAMUsageValue.ForeColor = Color.Red;
                        }
                        else if (ramPercent > 75)
                        {
                            progressRAM.ForeColor = Color.Orange;
                            lblRAMUsageValue.ForeColor = Color.Orange;
                        }
                        else
                        {
                            progressRAM.ForeColor = Color.FromArgb(100, 255, 100);
                            lblRAMUsageValue.ForeColor = Color.FromArgb(100, 255, 100);
                        }

                        // Update efficiency
                        lblEfficiencyValue.Text = $"{efficiency:F1}";
                        string rating = efficiency > 7 ? "EXCELLENT" :
                                       efficiency > 5 ? "GOOD" :
                                       efficiency > 3 ? "FAIR" : "POOR";
                        lblEfficiencyRating.Text = rating;

                        // Efficiency color coding
                        if (efficiency > 7)
                            lblEfficiencyValue.ForeColor = Color.FromArgb(100, 255, 100);
                        else if (efficiency > 5)
                            lblEfficiencyValue.ForeColor = Color.FromArgb(255, 255, 100);
                        else if (efficiency > 3)
                            lblEfficiencyValue.ForeColor = Color.FromArgb(255, 200, 100);
                        else
                            lblEfficiencyValue.ForeColor = Color.FromArgb(255, 100, 100);

                        // Temperature color coding
                        if (gpuTemp > 85)
                        {
                            progressTemp.ForeColor = Color.Red;
                            lblTempValue.ForeColor = Color.Red;
                        }
                        else if (gpuTemp > 75)
                        {
                            progressTemp.ForeColor = Color.Orange;
                            lblTempValue.ForeColor = Color.Orange;
                        }
                        else
                        {
                            progressTemp.ForeColor = Color.FromArgb(255, 100, 100);
                            lblTempValue.ForeColor = Color.FromArgb(255, 100, 100);
                        }

                        if (cpuTemp > 85)
                        {
                            progressCPUTemp.ForeColor = Color.Red;
                            lblCPUTempValue.ForeColor = Color.Red;
                        }
                        else if (cpuTemp > 75)
                        {
                            progressCPUTemp.ForeColor = Color.Orange;
                            lblCPUTempValue.ForeColor = Color.Orange;
                        }
                        else
                        {
                            progressCPUTemp.ForeColor = Color.FromArgb(100, 200, 255);
                            lblCPUTempValue.ForeColor = Color.FromArgb(100, 200, 255);
                        }

                        // Power color coding
                        if (gpuPower > 200)
                            lblPowerValue.ForeColor = Color.Red;
                        else if (gpuPower > 150)
                            lblPowerValue.ForeColor = Color.Orange;
                        else
                            lblPowerValue.ForeColor = Color.FromArgb(0, 191, 255);

                        // Usage color coding
                        if (gpuLoad > 90)
                            lblUsageValue.ForeColor = Color.Red;
                        else if (gpuLoad > 75)
                            lblUsageValue.ForeColor = Color.Orange;
                        else
                            lblUsageValue.ForeColor = Color.FromArgb(100, 255, 100);

                        if (cpuUsage > 90)
                            lblCPUUsageValue.ForeColor = Color.Red;
                        else if (cpuUsage > 75)
                            lblCPUUsageValue.ForeColor = Color.Orange;
                        else
                            lblCPUUsageValue.ForeColor = Color.FromArgb(255, 200, 100);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"UI Update Error: {ex.Message}");
                    }
                });
            }
        }

        private float CalculateEfficiency(float power, float load)
        {
            try
            {
                if (power <= 0.1f) return 0;
                float efficiency = (load / (power + 0.1f)) * 10;
                efficiency = Math.Max(0, Math.Min(10, efficiency));
                return efficiency;
            }
            catch
            {
                return 0;
            }
        }

        private void HardwareEngineLoop()
        {
            try
            {
                myPC = new Computer
                {
                    IsCpuEnabled = true,
                    IsGpuEnabled = true,
                    IsMemoryEnabled = true,
                    IsMotherboardEnabled = true,
                    IsControllerEnabled = false,
                    IsNetworkEnabled = false,
                    IsStorageEnabled = false
                };
                myPC.Open();
                Thread.Sleep(2000);

                while (isRunning)
                {
                    try
                    {
                        // Get RAM information
                        GetRAMInfo();

                        foreach (IHardware hardware in myPC.Hardware)
                        {
                            hardware.Update();
                            foreach (var sub in hardware.SubHardware)
                                sub.Update();

                            // Get GPU Name
                            if (gpuName == "Detecting..." && (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd))
                            {
                                gpuName = hardware.Name;
                                if (!IsDisposed && IsHandleCreated)
                                {
                                    this.BeginInvoke((MethodInvoker)delegate
                                    {
                                        lblGPUName.Text = gpuName;
                                    });
                                }
                            }

                            // Get CPU Name
                            if (cpuName == "Detecting..." && hardware.HardwareType == HardwareType.Cpu)
                            {
                                cpuName = hardware.Name;
                                if (!IsDisposed && IsHandleCreated)
                                {
                                    this.BeginInvoke((MethodInvoker)delegate
                                    {
                                        lblCPUName.Text = cpuName;
                                    });
                                }
                            }
                        }

                        if (gpuProvider == null)
                        {
                            var rawGpu = myPC.Hardware.FirstOrDefault(h =>
                                h.HardwareType == HardwareType.GpuNvidia ||
                                h.HardwareType == HardwareType.GpuAmd);

                            if (rawGpu != null)
                            {
                                gpuProvider = rawGpu.HardwareType == HardwareType.GpuNvidia
                                    ? (IGpuProvider)new NvidiaGpuProvider(rawGpu)
                                    : new UniversalGpuProvider(rawGpu);
                            }
                        }

                        // ==========================================
                        // STRICT CPU USAGE GRABBER
                        // ==========================================
                        // ==========================================
                        // STRICT CPU UTILITY GRABBER (MATCHES OS & HWINFO UTILITY)
                        // ==========================================
                        float cpuTemp = 0, cpuUsage = 0;
                        var cpu = myPC.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.Cpu);

                        if (cpu != null)
                        {
                            cpu.Update();

                            // 1. Get Temperature (Still use LibreHardwareMonitor for this)
                            var tempSensors = cpu.Sensors.Where(s => s.SensorType == SensorType.Temperature && s.Value.HasValue).ToList();
                            if (tempSensors.Any())
                            {
                                cpuTemp = tempSensors.Max(s => s.Value.Value);
                            }
                        }

                        // 2. Get Utility directly from Windows Task Manager's engine!
                        if (cpuUtilityCounter != null)
                        {
                            try
                            {
                                cpuUsage = cpuUtilityCounter.NextValue();

                                // Windows utility can sometimes report > 100% when your Ryzen 5600X turbo boosts hard.
                                // We cap it at 100% so the progress bar doesn't crash.
                                if (cpuUsage > 100f) cpuUsage = 100f;
                            }
                            catch
                            {
                                cpuUsage = 0;
                            }
                        }
                        // ==========================================
                        // ==========================================

                        float gpuTemp = 0, gpuLoad = 0, gpuPower = 0;
                        if (gpuProvider != null)
                        {
                            gpuTemp = gpuProvider.GetTemperature();
                            gpuLoad = gpuProvider.GetLoad();
                            gpuPower = gpuProvider.GetPower();
                        }

                        float efficiency = CalculateEfficiency(gpuPower, gpuLoad);

                        efficiencyHistory.Add(efficiency);
                        if (efficiencyHistory.Count > 10)
                            efficiencyHistory.RemoveAt(0);

                        float smoothedEfficiency = efficiency;
                        if (efficiencyHistory.Count >= 3)
                        {
                            smoothedEfficiency = efficiencyHistory.Skip(efficiencyHistory.Count - 3).Average();
                        }

                        // Update UI
                        UpdateUI(gpuPower, gpuTemp, gpuLoad, cpuTemp, cpuUsage, smoothedEfficiency,
                                 totalRAMGB, usedRAMGB, ramUsagePercent);

                        // Log data to CSV
                        string logFile = "hardware_eco_data.csv";
                        try
                        {
                            bool fileExists = File.Exists(logFile);
                            using (var stream = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                            using (var writer = new StreamWriter(stream))
                            {
                                if (!fileExists)
                                {
                                    writer.WriteLine("Timestamp,PowerWatts,GPULoad,GPUTemp,CPUTemp,CPUUsage,RAMUsage,Efficiency");
                                }
                                writer.WriteLine(string.Format(CultureInfo.InvariantCulture,
                                    "{0},{1:F1},{2:F1},{3:F1},{4:F1},{5:F1},{6:F1},{7:F2}",
                                    DateTime.Now.ToString("HH:mm:ss"),
                                    gpuPower, gpuLoad, gpuTemp, cpuTemp, cpuUsage, ramUsagePercent, efficiency));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Logging Error: {ex.Message}");
                        }

                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Loop Error: {ex.Message}");
                        Thread.Sleep(2000);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hardware Engine Error: {ex.Message}");
            }
            finally
            {
                if (myPC != null)
                    myPC.Close();
            }
        }

        // Form dragging methods
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Window controls
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Button handlers
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                string logFile = "hardware_eco_data.csv";
                if (!File.Exists(logFile))
                {
                    MessageBox.Show($"No data logged yet! Please wait for data collection.",
                        "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lines = File.ReadAllLines(logFile).Skip(1).ToList();
                if (lines.Count == 0)
                {
                    MessageBox.Show("No data records found!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var powerValues = new List<float>();
                var gpuLoadValues = new List<float>();
                var gpuTempValues = new List<float>();
                var cpuTempValues = new List<float>();
                var cpuUsageValues = new List<float>();
                var ramUsageValues = new List<float>();
                var efficiencyValues = new List<float>();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 8)
                    {
                        try
                        {
                            powerValues.Add(float.Parse(parts[1], CultureInfo.InvariantCulture));
                            gpuLoadValues.Add(float.Parse(parts[2], CultureInfo.InvariantCulture));
                            gpuTempValues.Add(float.Parse(parts[3], CultureInfo.InvariantCulture));
                            cpuTempValues.Add(float.Parse(parts[4], CultureInfo.InvariantCulture));
                            cpuUsageValues.Add(float.Parse(parts[5], CultureInfo.InvariantCulture));
                            ramUsageValues.Add(float.Parse(parts[6], CultureInfo.InvariantCulture));
                            efficiencyValues.Add(float.Parse(parts[7], CultureInfo.InvariantCulture));
                        }
                        catch { }
                    }
                }

                if (powerValues.Count == 0)
                {
                    MessageBox.Show("No valid data found in log file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                System.Text.StringBuilder reportBuilder = new System.Text.StringBuilder();

                reportBuilder.AppendLine("═══════════════════════════════════════════════════════════════");
                reportBuilder.AppendLine($"              THERMALGUARD - HEALTH MONITORING REPORT              ");
                reportBuilder.AppendLine($"                        Hardware Monitor Report");
                reportBuilder.AppendLine("═══════════════════════════════════════════════════════════════");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine($"Generated: {DateTime.Now:dddd, MMMM dd, yyyy HH:mm:ss}");
                reportBuilder.AppendLine($"Session Started: {startTime:dddd, MMMM dd, yyyy HH:mm:ss}");
                reportBuilder.AppendLine($"Total Readings: {lines.Count}");
                reportBuilder.AppendLine($"Monitoring Duration: {(DateTime.Now - startTime).Hours}h {(DateTime.Now - startTime).Minutes}m");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine($"Hardware Information:");
                reportBuilder.AppendLine($"  • GPU: {gpuName}");
                reportBuilder.AppendLine($"  • CPU: {cpuName}");
                reportBuilder.AppendLine($"  • RAM: {totalRAMGB:F1} GB Total | {usedRAMGB:F1} GB Used ({ramUsagePercent:F0}%)");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                reportBuilder.AppendLine("│                         GPU STATISTICS                        │");
                reportBuilder.AppendLine("└─────────────────────────────────────────────────────────────┘");
                reportBuilder.AppendLine($"  Power Consumption:");
                reportBuilder.AppendLine($"    • Average: {powerValues.Average():F1} W");
                reportBuilder.AppendLine($"    • Peak:     {powerValues.Max():F1} W");
                reportBuilder.AppendLine($"    • Minimum:  {powerValues.Min():F1} W");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine($"  Load & Temperature:");
                reportBuilder.AppendLine($"    • Average Load:  {gpuLoadValues.Average():F1}%");
                reportBuilder.AppendLine($"    • Peak Load:     {gpuLoadValues.Max():F1}%");
                reportBuilder.AppendLine($"    • Average Temp:  {gpuTempValues.Average():F1}°C");
                reportBuilder.AppendLine($"    • Peak Temp:     {gpuTempValues.Max():F1}°C");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                reportBuilder.AppendLine("│                         CPU STATISTICS                        │");
                reportBuilder.AppendLine("└─────────────────────────────────────────────────────────────┘");
                reportBuilder.AppendLine($"  Temperature:");
                reportBuilder.AppendLine($"    • Average: {cpuTempValues.Average():F1}°C");
                reportBuilder.AppendLine($"    • Peak:    {cpuTempValues.Max():F1}°C");
                reportBuilder.AppendLine($"    • Minimum: {cpuTempValues.Min():F1}°C");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine($"  Usage:");
                reportBuilder.AppendLine($"    • Average: {cpuUsageValues.Average():F1}%");
                reportBuilder.AppendLine($"    • Peak:    {cpuUsageValues.Max():F1}%");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                reportBuilder.AppendLine("│                      MEMORY STATISTICS                        │");
                reportBuilder.AppendLine("└─────────────────────────────────────────────────────────────┘");
                reportBuilder.AppendLine($"  • Average RAM Usage: {ramUsageValues.Average():F1}%");
                reportBuilder.AppendLine($"  • Peak RAM Usage:    {ramUsageValues.Max():F1}%");
                reportBuilder.AppendLine($"  • Minimum RAM Usage: {ramUsageValues.Min():F1}%");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                reportBuilder.AppendLine("│                     EFFICIENCY ANALYSIS                       │");
                reportBuilder.AppendLine("└─────────────────────────────────────────────────────────────┘");
                reportBuilder.AppendLine($"  • Average Efficiency: {efficiencyValues.Average():F2}");
                reportBuilder.AppendLine($"  • Peak Efficiency:    {efficiencyValues.Max():F2}");
                reportBuilder.AppendLine($"  • Minimum Efficiency: {efficiencyValues.Min():F2}");
                reportBuilder.AppendLine();

                string efficiencyRating = efficiencyValues.Average() > 7 ? "EXCELLENT" :
                                         efficiencyValues.Average() > 5 ? "GOOD" :
                                         efficiencyValues.Average() > 3 ? "FAIR" : "POOR";
                reportBuilder.AppendLine($"  Efficiency Rating: {efficiencyRating}");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                reportBuilder.AppendLine("│                      SYSTEM STATUS                           │");
                reportBuilder.AppendLine("└─────────────────────────────────────────────────────────────┘");
                reportBuilder.AppendLine($"  Status: OPERATIONAL");

                string healthScore = (powerValues.Average() < 100 && cpuTempValues.Average() < 75 && ramUsageValues.Average() < 85) ? "GOOD" : "MONITOR";
                reportBuilder.AppendLine($"  Health Score: {healthScore}");
                reportBuilder.AppendLine();
                reportBuilder.AppendLine("═══════════════════════════════════════════════════════════════");
                reportBuilder.AppendLine("Report generated by ThermalGuard Monitoring System");
                reportBuilder.AppendLine("═══════════════════════════════════════════════════════════════");

                string report = reportBuilder.ToString();
                string reportFile = $"ThermalGuard_Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                File.WriteAllText(reportFile, report);

                MessageBox.Show($"Report saved successfully!\n\nFile: {reportFile}\nLocation: {Application.StartupPath}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    sfd.FileName = $"ThermalGuard_Data_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string logFile = "hardware_eco_data.csv";
                        if (File.Exists(logFile))
                        {
                            File.Copy(logFile, sfd.FileName, true);
                            MessageBox.Show($"Data exported successfully!\n\nFile saved to:\n{sfd.FileName}",
                                "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No data to export. Please wait for data collection.",
                                "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to reset all statistics?\n\nThis will clear all collected data.",
                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string logFile = "hardware_eco_data.csv";
                    if (File.Exists(logFile))
                    {
                        File.Delete(logFile);
                    }

                    efficiencyHistory.Clear();

                    MessageBox.Show($"All statistics have been reset!",
                        "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error resetting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isRunning = false;
            if (timerDateTime != null)
                timerDateTime.Stop();
            if (myPC != null)
            {
                try
                {
                    myPC.Close();
                }
                catch { }
            }
            base.OnFormClosing(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    // GPU Provider Interfaces and Implementations
    public interface IGpuProvider
    {
        float GetTemperature();
        float GetLoad();
        float GetPower();
    }

    public class NvidiaGpuProvider : IGpuProvider
    {
        private IHardware gpu;

        public NvidiaGpuProvider(IHardware gpu)
        {
            this.gpu = gpu;
        }

        public float GetTemperature()
        {
            var sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Temperature);
            return sensor?.Value ?? 0;
        }

        public float GetLoad()
        {
            // Try to get GPU Core Load (most accurate for usage)
            var sensor = gpu.Sensors.FirstOrDefault(s =>
                s.SensorType == SensorType.Load &&
                (s.Name.Contains("Core") || s.Name.Contains("GPU")));

            if (sensor == null)
            {
                // Fallback: get any load sensor
                sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Load);
            }

            return sensor?.Value ?? 0;
        }

        public float GetPower()
        {
            var sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Power);
            return sensor?.Value ?? 0;
        }
    }

    public class UniversalGpuProvider : IGpuProvider
    {
        private IHardware gpu;

        public UniversalGpuProvider(IHardware gpu)
        {
            this.gpu = gpu;
        }

        public float GetTemperature()
        {
            var sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Temperature);
            return sensor?.Value ?? 0;
        }

        public float GetLoad()
        {
            // Try multiple ways to get GPU load
            var sensor = gpu.Sensors.FirstOrDefault(s =>
                s.SensorType == SensorType.Load &&
                (s.Name.Contains("Core") || s.Name.Contains("GPU") || s.Name.Contains("Load")));

            if (sensor == null)
            {
                sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Load);
            }

            // If still null, try to get from SubHardware
            if (sensor == null && gpu.SubHardware.Any())
            {
                foreach (var sub in gpu.SubHardware)
                {
                    sensor = sub.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Load);
                    if (sensor != null) break;
                }
            }

            return sensor?.Value ?? 0;
        }

        public float GetPower()
        {
            var sensor = gpu.Sensors.FirstOrDefault(s => s.SensorType == SensorType.Power);
            return sensor?.Value ?? 0;
        }
    }
}