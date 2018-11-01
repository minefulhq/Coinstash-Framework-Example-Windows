namespace Coinstash_Sample
{
    partial class CoinstashSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.hashRateLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.cpuLimitSpinner = new System.Windows.Forms.NumericUpDown();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.minerComboBox = new System.Windows.Forms.ComboBox();
            this.amdRadio = new System.Windows.Forms.RadioButton();
            this.nvidiaRadio = new System.Windows.Forms.RadioButton();
            this.noneRadio = new System.Windows.Forms.RadioButton();
            this.detectRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.cpuLimitSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.onStart);
            // 
            // hashRateLabel
            // 
            this.hashRateLabel.AutoSize = true;
            this.hashRateLabel.Location = new System.Drawing.Point(141, 49);
            this.hashRateLabel.Name = "hashRateLabel";
            this.hashRateLabel.Size = new System.Drawing.Size(61, 13);
            this.hashRateLabel.TabIndex = 1;
            this.hashRateLabel.Text = "Hash Rate:";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(290, 49);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(66, 13);
            this.cpuUsageLabel.TabIndex = 2;
            this.cpuUsageLabel.Text = "CPU Usage:";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "Monero",
            "Graft",
            "Electroneum",
            "Sumokoin",
            "Karbo",
            "Intense"});
            this.currencyComboBox.Location = new System.Drawing.Point(12, 46);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.currencyComboBox.TabIndex = 3;
            this.currencyComboBox.Text = "Monero";
            // 
            // cpuLimitSpinner
            // 
            this.cpuLimitSpinner.Location = new System.Drawing.Point(12, 86);
            this.cpuLimitSpinner.Name = "cpuLimitSpinner";
            this.cpuLimitSpinner.Size = new System.Drawing.Size(120, 20);
            this.cpuLimitSpinner.TabIndex = 4;
            this.cpuLimitSpinner.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Items.AddRange(new object[] {
            "3333",
            "5555",
            "7777"});
            this.portComboBox.Location = new System.Drawing.Point(12, 121);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 7;
            this.portComboBox.Text = "3333";
            // 
            // minerComboBox
            // 
            this.minerComboBox.FormattingEnabled = true;
            this.minerComboBox.Items.AddRange(new object[] {
            "xmr-stak",
            "cp-cpu-miner"});
            this.minerComboBox.Location = new System.Drawing.Point(12, 12);
            this.minerComboBox.Name = "minerComboBox";
            this.minerComboBox.Size = new System.Drawing.Size(344, 21);
            this.minerComboBox.TabIndex = 8;
            this.minerComboBox.Text = "xmr-stak";
            // 
            // amdRadio
            // 
            this.amdRadio.AutoSize = true;
            this.amdRadio.Location = new System.Drawing.Point(144, 123);
            this.amdRadio.Name = "amdRadio";
            this.amdRadio.Size = new System.Drawing.Size(49, 17);
            this.amdRadio.TabIndex = 9;
            this.amdRadio.Text = "AMD";
            this.amdRadio.UseVisualStyleBackColor = true;
            // 
            // nvidiaRadio
            // 
            this.nvidiaRadio.AutoSize = true;
            this.nvidiaRadio.Location = new System.Drawing.Point(199, 123);
            this.nvidiaRadio.Name = "nvidiaRadio";
            this.nvidiaRadio.Size = new System.Drawing.Size(61, 17);
            this.nvidiaRadio.TabIndex = 10;
            this.nvidiaRadio.Text = "NVIDIA";
            this.nvidiaRadio.UseVisualStyleBackColor = true;
            // 
            // noneRadio
            // 
            this.noneRadio.AutoSize = true;
            this.noneRadio.Checked = true;
            this.noneRadio.Location = new System.Drawing.Point(266, 123);
            this.noneRadio.Name = "noneRadio";
            this.noneRadio.Size = new System.Drawing.Size(56, 17);
            this.noneRadio.TabIndex = 11;
            this.noneRadio.TabStop = true;
            this.noneRadio.Text = "NONE";
            this.noneRadio.UseVisualStyleBackColor = true;
            // 
            // detectRadio
            // 
            this.detectRadio.AutoSize = true;
            this.detectRadio.Location = new System.Drawing.Point(328, 122);
            this.detectRadio.Name = "detectRadio";
            this.detectRadio.Size = new System.Drawing.Size(68, 17);
            this.detectRadio.TabIndex = 12;
            this.detectRadio.Text = "DETECT";
            this.detectRadio.UseVisualStyleBackColor = true;
            // 
            // CoinstashSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 192);
            this.Controls.Add(this.detectRadio);
            this.Controls.Add(this.noneRadio);
            this.Controls.Add(this.nvidiaRadio);
            this.Controls.Add(this.amdRadio);
            this.Controls.Add(this.minerComboBox);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.cpuLimitSpinner);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.hashRateLabel);
            this.Controls.Add(this.startButton);
            this.Name = "CoinstashSample";
            this.Text = "Windows Coinstash Sample";
            ((System.ComponentModel.ISupportInitialize)(this.cpuLimitSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label hashRateLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.NumericUpDown cpuLimitSpinner;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox minerComboBox;
        private System.Windows.Forms.RadioButton amdRadio;
        private System.Windows.Forms.RadioButton nvidiaRadio;
        private System.Windows.Forms.RadioButton noneRadio;
        private System.Windows.Forms.RadioButton detectRadio;
    }
}

