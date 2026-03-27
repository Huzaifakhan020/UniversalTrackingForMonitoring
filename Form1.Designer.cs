using System.Drawing;

namespace UniversalTrackingForMonitoring
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.gpuCard = new System.Windows.Forms.Panel();
            this.lblGPUTitle = new System.Windows.Forms.Label();
            this.lblGPUName = new System.Windows.Forms.Label();
            this.lblPowerValue = new System.Windows.Forms.Label();
            this.lblPowerLabel = new System.Windows.Forms.Label();
            this.progressPower = new System.Windows.Forms.ProgressBar();
            this.lblTempValue = new System.Windows.Forms.Label();
            this.lblTempLabel = new System.Windows.Forms.Label();
            this.progressTemp = new System.Windows.Forms.ProgressBar();
            this.lblUsageValue = new System.Windows.Forms.Label();
            this.lblUsageLabel = new System.Windows.Forms.Label();
            this.cpuCard = new System.Windows.Forms.Panel();
            this.lblCPUTitle = new System.Windows.Forms.Label();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.lblCPUTempValue = new System.Windows.Forms.Label();
            this.lblCPUTempLabel = new System.Windows.Forms.Label();
            this.progressCPUTemp = new System.Windows.Forms.ProgressBar();
            this.lblCPUUsageValue = new System.Windows.Forms.Label();
            this.lblCPUUsageLabel = new System.Windows.Forms.Label();
            this.progressCPUUsage = new System.Windows.Forms.ProgressBar();
            this.efficiencyCard = new System.Windows.Forms.Panel();
            this.lblEfficiencyTitle = new System.Windows.Forms.Label();
            this.lblEfficiencyValue = new System.Windows.Forms.Label();
            this.lblEfficiencyRating = new System.Windows.Forms.Label();
            this.ramCard = new System.Windows.Forms.Panel();
            this.lblRAMTitle = new System.Windows.Forms.Label();
            this.lblTotalRAMLabel = new System.Windows.Forms.Label();
            this.lblTotalRAMValue = new System.Windows.Forms.Label();
            this.lblUsedRAMLabel = new System.Windows.Forms.Label();
            this.lblUsedRAMValue = new System.Windows.Forms.Label();
            this.lblRAMUsageLabel = new System.Windows.Forms.Label();
            this.lblRAMUsageValue = new System.Windows.Forms.Label();
            this.progressRAM = new System.Windows.Forms.ProgressBar();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnResetStats = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();

            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.gpuCard.SuspendLayout();
            this.cpuCard.SuspendLayout();
            this.efficiencyCard.SuspendLayout();
            this.ramCard.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.gpuCard);
            this.mainPanel.Controls.Add(this.cpuCard);
            this.mainPanel.Controls.Add(this.efficiencyCard);
            this.mainPanel.Controls.Add(this.ramCard);
            this.mainPanel.Controls.Add(this.btnGenerateReport);
            this.mainPanel.Controls.Add(this.btnExportData);
            this.mainPanel.Controls.Add(this.btnResetStats);
            this.mainPanel.Controls.Add(this.footerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.headerPanel.Controls.Add(this.button2);
            this.headerPanel.Controls.Add(this.button1);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblUserGreeting);
            this.headerPanel.Controls.Add(this.lblDigitalClock);
            this.headerPanel.Controls.Add(this.lblDate);
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Controls.Add(this.btnMinimize);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 100);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(875, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(849, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "─";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THERMALGUARD";
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.AutoSize = true;
            this.lblUserGreeting.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblUserGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblUserGreeting.Location = new System.Drawing.Point(30, 66);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(95, 25);
            this.lblUserGreeting.TabIndex = 1;
            this.lblUserGreeting.Text = "Welcome!";
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblDigitalClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblDigitalClock.Location = new System.Drawing.Point(688, 20);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(200, 55);
            this.lblDigitalClock.TabIndex = 2;
            this.lblDigitalClock.Text = "00:00:00";
            this.lblDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblDate.Location = new System.Drawing.Point(680, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Thursday, March 26, 2026";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(840, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(800, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "─";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // gpuCard
            // 
            this.gpuCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.gpuCard.Controls.Add(this.lblGPUTitle);
            this.gpuCard.Controls.Add(this.lblGPUName);
            this.gpuCard.Controls.Add(this.lblPowerValue);
            this.gpuCard.Controls.Add(this.lblPowerLabel);
            this.gpuCard.Controls.Add(this.progressPower);
            this.gpuCard.Controls.Add(this.lblTempValue);
            this.gpuCard.Controls.Add(this.lblTempLabel);
            this.gpuCard.Controls.Add(this.progressTemp);
            this.gpuCard.Controls.Add(this.lblUsageValue);
            this.gpuCard.Controls.Add(this.lblUsageLabel);
            this.gpuCard.Location = new System.Drawing.Point(20, 120);
            this.gpuCard.Name = "gpuCard";
            this.gpuCard.Size = new System.Drawing.Size(420, 312);
            this.gpuCard.TabIndex = 1;
            // 
            // lblGPUTitle
            // 
            this.lblGPUTitle.AutoSize = true;
            this.lblGPUTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGPUTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblGPUTitle.Location = new System.Drawing.Point(10, 15);
            this.lblGPUTitle.Name = "lblGPUTitle";
            this.lblGPUTitle.Size = new System.Drawing.Size(137, 25);
            this.lblGPUTitle.TabIndex = 0;
            this.lblGPUTitle.Text = "GPU METRICS";
            // 
            // lblGPUName
            // 
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGPUName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblGPUName.Location = new System.Drawing.Point(12, 45);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(67, 15);
            this.lblGPUName.TabIndex = 9;
            this.lblGPUName.Text = "Detecting...";
            // 
            // lblPowerValue
            // 
            this.lblPowerValue.AutoSize = true;
            this.lblPowerValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblPowerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblPowerValue.Location = new System.Drawing.Point(5, 70);
            this.lblPowerValue.Name = "lblPowerValue";
            this.lblPowerValue.Size = new System.Drawing.Size(93, 59);
            this.lblPowerValue.TabIndex = 1;
            this.lblPowerValue.Text = "0W";
            // 
            // lblPowerLabel
            // 
            this.lblPowerLabel.AutoSize = true;
            this.lblPowerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPowerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblPowerLabel.Location = new System.Drawing.Point(11, 134);
            this.lblPowerLabel.Name = "lblPowerLabel";
            this.lblPowerLabel.Size = new System.Drawing.Size(160, 19);
            this.lblPowerLabel.TabIndex = 2;
            this.lblPowerLabel.Text = "POWER CONSUMPTION";
            // 
            // progressPower
            // 
            this.progressPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.progressPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.progressPower.Location = new System.Drawing.Point(15, 164);
            this.progressPower.Maximum = 300;
            this.progressPower.Name = "progressPower";
            this.progressPower.Size = new System.Drawing.Size(390, 8);
            this.progressPower.TabIndex = 3;
            // 
            // lblTempValue
            // 
            this.lblTempValue.AutoSize = true;
            this.lblTempValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTempValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTempValue.Location = new System.Drawing.Point(12, 194);
            this.lblTempValue.Name = "lblTempValue";
            this.lblTempValue.Size = new System.Drawing.Size(93, 59);
            this.lblTempValue.TabIndex = 4;
            this.lblTempValue.Text = "0°C";
            // 
            // lblTempLabel
            // 
            this.lblTempLabel.AutoSize = true;
            this.lblTempLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblTempLabel.Location = new System.Drawing.Point(11, 263);
            this.lblTempLabel.Name = "lblTempLabel";
            this.lblTempLabel.Size = new System.Drawing.Size(99, 19);
            this.lblTempLabel.TabIndex = 5;
            this.lblTempLabel.Text = "TEMPERATURE";
            // 
            // progressTemp
            // 
            this.progressTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.progressTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressTemp.Location = new System.Drawing.Point(15, 285);
            this.progressTemp.Name = "progressTemp";
            this.progressTemp.Size = new System.Drawing.Size(390, 8);
            this.progressTemp.TabIndex = 6;
            // 
            // lblUsageValue
            // 
            this.lblUsageValue.AutoSize = true;
            this.lblUsageValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblUsageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.lblUsageValue.Location = new System.Drawing.Point(220, 70);
            this.lblUsageValue.Name = "lblUsageValue";
            this.lblUsageValue.Size = new System.Drawing.Size(87, 59);
            this.lblUsageValue.TabIndex = 7;
            this.lblUsageValue.Text = "0%";
            // 
            // lblUsageLabel
            // 
            this.lblUsageLabel.AutoSize = true;
            this.lblUsageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblUsageLabel.Location = new System.Drawing.Point(226, 134);
            this.lblUsageLabel.Name = "lblUsageLabel";
            this.lblUsageLabel.Size = new System.Drawing.Size(52, 19);
            this.lblUsageLabel.TabIndex = 8;
            this.lblUsageLabel.Text = "USAGE";
            // 
            // cpuCard
            // 
            this.cpuCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.cpuCard.Controls.Add(this.lblCPUTitle);
            this.cpuCard.Controls.Add(this.lblCPUName);
            this.cpuCard.Controls.Add(this.lblCPUTempValue);
            this.cpuCard.Controls.Add(this.lblCPUTempLabel);
            this.cpuCard.Controls.Add(this.progressCPUTemp);
            this.cpuCard.Controls.Add(this.lblCPUUsageValue);
            this.cpuCard.Controls.Add(this.lblCPUUsageLabel);
            this.cpuCard.Controls.Add(this.progressCPUUsage);
            this.cpuCard.Location = new System.Drawing.Point(460, 120);
            this.cpuCard.Name = "cpuCard";
            this.cpuCard.Size = new System.Drawing.Size(420, 312);
            this.cpuCard.TabIndex = 2;
            // 
            // lblCPUTitle
            // 
            this.lblCPUTitle.AutoSize = true;
            this.lblCPUTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCPUTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblCPUTitle.Location = new System.Drawing.Point(10, 15);
            this.lblCPUTitle.Name = "lblCPUTitle";
            this.lblCPUTitle.Size = new System.Drawing.Size(135, 25);
            this.lblCPUTitle.TabIndex = 0;
            this.lblCPUTitle.Text = "CPU METRICS";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCPUName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblCPUName.Location = new System.Drawing.Point(12, 45);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(67, 15);
            this.lblCPUName.TabIndex = 9;
            this.lblCPUName.Text = "Detecting...";
            // 
            // lblCPUTempValue
            // 
            this.lblCPUTempValue.AutoSize = true;
            this.lblCPUTempValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblCPUTempValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblCPUTempValue.Location = new System.Drawing.Point(8, 70);
            this.lblCPUTempValue.Name = "lblCPUTempValue";
            this.lblCPUTempValue.Size = new System.Drawing.Size(93, 59);
            this.lblCPUTempValue.TabIndex = 1;
            this.lblCPUTempValue.Text = "0°C";
            // 
            // lblCPUTempLabel
            // 
            this.lblCPUTempLabel.AutoSize = true;
            this.lblCPUTempLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCPUTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblCPUTempLabel.Location = new System.Drawing.Point(15, 134);
            this.lblCPUTempLabel.Name = "lblCPUTempLabel";
            this.lblCPUTempLabel.Size = new System.Drawing.Size(99, 19);
            this.lblCPUTempLabel.TabIndex = 2;
            this.lblCPUTempLabel.Text = "TEMPERATURE";
            // 
            // progressCPUTemp
            // 
            this.progressCPUTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.progressCPUTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.progressCPUTemp.Location = new System.Drawing.Point(15, 164);
            this.progressCPUTemp.Name = "progressCPUTemp";
            this.progressCPUTemp.Size = new System.Drawing.Size(390, 8);
            this.progressCPUTemp.TabIndex = 3;
            // 
            // lblCPUUsageValue
            // 
            this.lblCPUUsageValue.AutoSize = true;
            this.lblCPUUsageValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblCPUUsageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblCPUUsageValue.Location = new System.Drawing.Point(9, 194);
            this.lblCPUUsageValue.Name = "lblCPUUsageValue";
            this.lblCPUUsageValue.Size = new System.Drawing.Size(87, 59);
            this.lblCPUUsageValue.TabIndex = 4;
            this.lblCPUUsageValue.Text = "0%";
            // 
            // lblCPUUsageLabel
            // 
            this.lblCPUUsageLabel.AutoSize = true;
            this.lblCPUUsageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCPUUsageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblCPUUsageLabel.Location = new System.Drawing.Point(16, 263);
            this.lblCPUUsageLabel.Name = "lblCPUUsageLabel";
            this.lblCPUUsageLabel.Size = new System.Drawing.Size(52, 19);
            this.lblCPUUsageLabel.TabIndex = 5;
            this.lblCPUUsageLabel.Text = "USAGE";
            // 
            // progressCPUUsage
            // 
            this.progressCPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.progressCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.progressCPUUsage.Location = new System.Drawing.Point(15, 285);
            this.progressCPUUsage.Name = "progressCPUUsage";
            this.progressCPUUsage.Size = new System.Drawing.Size(390, 8);
            this.progressCPUUsage.TabIndex = 6;
            // 
            // efficiencyCard
            // 
            this.efficiencyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.efficiencyCard.Controls.Add(this.lblEfficiencyTitle);
            this.efficiencyCard.Controls.Add(this.lblEfficiencyValue);
            this.efficiencyCard.Controls.Add(this.lblEfficiencyRating);
            this.efficiencyCard.Location = new System.Drawing.Point(20, 447);
            this.efficiencyCard.Name = "efficiencyCard";
            this.efficiencyCard.Size = new System.Drawing.Size(420, 147);
            this.efficiencyCard.TabIndex = 3;
            // 
            // lblEfficiencyTitle
            // 
            this.lblEfficiencyTitle.AutoSize = true;
            this.lblEfficiencyTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEfficiencyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblEfficiencyTitle.Location = new System.Drawing.Point(15, 15);
            this.lblEfficiencyTitle.Name = "lblEfficiencyTitle";
            this.lblEfficiencyTitle.Size = new System.Drawing.Size(179, 25);
            this.lblEfficiencyTitle.TabIndex = 0;
            this.lblEfficiencyTitle.Text = "EFFICIENCY SCORE";
            // 
            // lblEfficiencyValue
            // 
            this.lblEfficiencyValue.AutoSize = true;
            this.lblEfficiencyValue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblEfficiencyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.lblEfficiencyValue.Location = new System.Drawing.Point(19, 40);
            this.lblEfficiencyValue.Name = "lblEfficiencyValue";
            this.lblEfficiencyValue.Size = new System.Drawing.Size(128, 86);
            this.lblEfficiencyValue.TabIndex = 1;
            this.lblEfficiencyValue.Text = "0.0";
            // 
            // lblEfficiencyRating
            // 
            this.lblEfficiencyRating.AutoSize = true;
            this.lblEfficiencyRating.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEfficiencyRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblEfficiencyRating.Location = new System.Drawing.Point(200, 80);
            this.lblEfficiencyRating.Name = "lblEfficiencyRating";
            this.lblEfficiencyRating.Size = new System.Drawing.Size(55, 25);
            this.lblEfficiencyRating.TabIndex = 2;
            this.lblEfficiencyRating.Text = "Poor";
            // 
            // ramCard
            // 
            this.ramCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ramCard.Controls.Add(this.lblRAMTitle);
            this.ramCard.Controls.Add(this.lblTotalRAMLabel);
            this.ramCard.Controls.Add(this.lblTotalRAMValue);
            this.ramCard.Controls.Add(this.lblUsedRAMLabel);
            this.ramCard.Controls.Add(this.lblUsedRAMValue);
            this.ramCard.Controls.Add(this.lblRAMUsageLabel);
            this.ramCard.Controls.Add(this.lblRAMUsageValue);
            this.ramCard.Controls.Add(this.progressRAM);
            this.ramCard.Location = new System.Drawing.Point(460, 447);
            this.ramCard.Name = "ramCard";
            this.ramCard.Size = new System.Drawing.Size(420, 147);
            this.ramCard.TabIndex = 4;
            // 
            // lblRAMTitle
            // 
            this.lblRAMTitle.AutoSize = true;
            this.lblRAMTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRAMTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblRAMTitle.Location = new System.Drawing.Point(15, 15);
            this.lblRAMTitle.Name = "lblRAMTitle";
            this.lblRAMTitle.Size = new System.Drawing.Size(170, 25);
            this.lblRAMTitle.TabIndex = 0;
            this.lblRAMTitle.Text = "MEMORY STATUS";
            // 
            // lblTotalRAMLabel
            // 
            this.lblTotalRAMLabel.AutoSize = true;
            this.lblTotalRAMLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalRAMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblTotalRAMLabel.Location = new System.Drawing.Point(15, 55);
            this.lblTotalRAMLabel.Name = "lblTotalRAMLabel";
            this.lblTotalRAMLabel.Size = new System.Drawing.Size(89, 20);
            this.lblTotalRAMLabel.TabIndex = 1;
            this.lblTotalRAMLabel.Text = "TOTAL RAM:";
            // 
            // lblTotalRAMValue
            // 
            this.lblTotalRAMValue.AutoSize = true;
            this.lblTotalRAMValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalRAMValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblTotalRAMValue.Location = new System.Drawing.Point(120, 52);
            this.lblTotalRAMValue.Name = "lblTotalRAMValue";
            this.lblTotalRAMValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalRAMValue.TabIndex = 2;
            this.lblTotalRAMValue.Text = "0";
            // 
            // lblUsedRAMLabel
            // 
            this.lblUsedRAMLabel.AutoSize = true;
            this.lblUsedRAMLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsedRAMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblUsedRAMLabel.Location = new System.Drawing.Point(15, 90);
            this.lblUsedRAMLabel.Name = "lblUsedRAMLabel";
            this.lblUsedRAMLabel.Size = new System.Drawing.Size(85, 20);
            this.lblUsedRAMLabel.TabIndex = 3;
            this.lblUsedRAMLabel.Text = "USED RAM:";
            // 
            // lblUsedRAMValue
            // 
            this.lblUsedRAMValue.AutoSize = true;
            this.lblUsedRAMValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsedRAMValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblUsedRAMValue.Location = new System.Drawing.Point(120, 87);
            this.lblUsedRAMValue.Name = "lblUsedRAMValue";
            this.lblUsedRAMValue.Size = new System.Drawing.Size(23, 25);
            this.lblUsedRAMValue.TabIndex = 4;
            this.lblUsedRAMValue.Text = "0";
            // 
            // lblRAMUsageLabel
            // 
            this.lblRAMUsageLabel.AutoSize = true;
            this.lblRAMUsageLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRAMUsageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lblRAMUsageLabel.Location = new System.Drawing.Point(15, 125);
            this.lblRAMUsageLabel.Name = "lblRAMUsageLabel";
            this.lblRAMUsageLabel.Size = new System.Drawing.Size(58, 20);
            this.lblRAMUsageLabel.TabIndex = 5;
            this.lblRAMUsageLabel.Text = "USAGE:";
            // 
            // lblRAMUsageValue
            // 
            this.lblRAMUsageValue.AutoSize = true;
            this.lblRAMUsageValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRAMUsageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.lblRAMUsageValue.Location = new System.Drawing.Point(120, 120);
            this.lblRAMUsageValue.Name = "lblRAMUsageValue";
            this.lblRAMUsageValue.Size = new System.Drawing.Size(39, 25);
            this.lblRAMUsageValue.TabIndex = 6;
            this.lblRAMUsageValue.Text = "0%";
            // 
            // progressRAM
            // 
            this.progressRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.progressRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.progressRAM.Location = new System.Drawing.Point(220, 130);
            this.progressRAM.Name = "progressRAM";
            this.progressRAM.Size = new System.Drawing.Size(180, 8);
            this.progressRAM.TabIndex = 7;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 600);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(180, 45);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "📊 GENERATE REPORT";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnExportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportData.ForeColor = System.Drawing.Color.White;
            this.btnExportData.Location = new System.Drawing.Point(220, 600);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(180, 45);
            this.btnExportData.TabIndex = 6;
            this.btnExportData.Text = "💾 EXPORT DATA";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnResetStats
            // 
            this.btnResetStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnResetStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetStats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnResetStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetStats.ForeColor = System.Drawing.Color.White;
            this.btnResetStats.Location = new System.Drawing.Point(420, 600);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(180, 45);
            this.btnResetStats.TabIndex = 7;
            this.btnResetStats.Text = "🔄 RESET STATS";
            this.btnResetStats.UseVisualStyleBackColor = false;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.footerPanel.Controls.Add(this.lblFooter);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 660);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(900, 40);
            this.footerPanel.TabIndex = 8;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(900, 40);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "ThermalGuard v1.0 | Free Hardware Monitoring Tool";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThermalGuard - Advanced Hardware Monitor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.gpuCard.ResumeLayout(false);
            this.gpuCard.PerformLayout();
            this.cpuCard.ResumeLayout(false);
            this.cpuCard.PerformLayout();
            this.efficiencyCard.ResumeLayout(false);
            this.efficiencyCard.PerformLayout();
            this.ramCard.ResumeLayout(false);
            this.ramCard.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserGreeting;
        private System.Windows.Forms.Label lblDigitalClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel gpuCard;
        private System.Windows.Forms.Label lblGPUTitle;
        private System.Windows.Forms.Label lblGPUName;
        private System.Windows.Forms.Label lblPowerValue;
        private System.Windows.Forms.Label lblPowerLabel;
        private System.Windows.Forms.ProgressBar progressPower;
        private System.Windows.Forms.Label lblTempValue;
        private System.Windows.Forms.Label lblTempLabel;
        private System.Windows.Forms.ProgressBar progressTemp;
        private System.Windows.Forms.Label lblUsageValue;
        private System.Windows.Forms.Label lblUsageLabel;
        private System.Windows.Forms.Panel cpuCard;
        private System.Windows.Forms.Label lblCPUTitle;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Label lblCPUTempValue;
        private System.Windows.Forms.Label lblCPUTempLabel;
        private System.Windows.Forms.ProgressBar progressCPUTemp;
        private System.Windows.Forms.Label lblCPUUsageValue;
        private System.Windows.Forms.Label lblCPUUsageLabel;
        private System.Windows.Forms.ProgressBar progressCPUUsage;
        private System.Windows.Forms.Panel efficiencyCard;
        private System.Windows.Forms.Label lblEfficiencyTitle;
        private System.Windows.Forms.Label lblEfficiencyValue;
        private System.Windows.Forms.Label lblEfficiencyRating;
        private System.Windows.Forms.Panel ramCard;
        private System.Windows.Forms.Label lblRAMTitle;
        private System.Windows.Forms.Label lblTotalRAMLabel;
        private System.Windows.Forms.Label lblTotalRAMValue;
        private System.Windows.Forms.Label lblUsedRAMLabel;
        private System.Windows.Forms.Label lblUsedRAMValue;
        private System.Windows.Forms.Label lblRAMUsageLabel;
        private System.Windows.Forms.Label lblRAMUsageValue;
        private System.Windows.Forms.ProgressBar progressRAM;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnResetStats;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label lblFooter;

        // Form dragging variables
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaximize;
    }
}