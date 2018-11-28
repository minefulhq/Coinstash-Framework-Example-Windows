namespace Mineful_Sample
{
    partial class MinefulSample
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
            this.cpuLimitSpinner = new System.Windows.Forms.NumericUpDown();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.amdRadio = new System.Windows.Forms.RadioButton();
            this.nvidiaRadio = new System.Windows.Forms.RadioButton();
            this.noneRadio = new System.Windows.Forms.RadioButton();
            this.detectRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuLimitSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(114, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(203, 32);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.onStart);
            // 
            // hashRateLabel
            // 
            this.hashRateLabel.AutoSize = true;
            this.hashRateLabel.Location = new System.Drawing.Point(12, 56);
            this.hashRateLabel.Name = "hashRateLabel";
            this.hashRateLabel.Size = new System.Drawing.Size(61, 13);
            this.hashRateLabel.TabIndex = 1;
            this.hashRateLabel.Text = "Hash Rate:";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(265, 56);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(66, 13);
            this.cpuUsageLabel.TabIndex = 2;
            this.cpuUsageLabel.Text = "CPU Usage:";
            // 
            // cpuLimitSpinner
            // 
            this.cpuLimitSpinner.Location = new System.Drawing.Point(79, 16);
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
            "3334",
            "5556",
            "7778",
            "Detect"});
            this.portComboBox.Location = new System.Drawing.Point(300, 16);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 7;
            this.portComboBox.Text = "3334";
            // 
            // amdRadio
            // 
            this.amdRadio.AutoSize = true;
            this.amdRadio.Location = new System.Drawing.Point(102, 94);
            this.amdRadio.Name = "amdRadio";
            this.amdRadio.Size = new System.Drawing.Size(49, 17);
            this.amdRadio.TabIndex = 9;
            this.amdRadio.Text = "AMD";
            this.amdRadio.UseVisualStyleBackColor = true;
            // 
            // nvidiaRadio
            // 
            this.nvidiaRadio.AutoSize = true;
            this.nvidiaRadio.Location = new System.Drawing.Point(157, 94);
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
            this.noneRadio.Location = new System.Drawing.Point(224, 94);
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
            this.detectRadio.Location = new System.Drawing.Point(286, 94);
            this.detectRadio.Name = "detectRadio";
            this.detectRadio.Size = new System.Drawing.Size(68, 17);
            this.detectRadio.TabIndex = 12;
            this.detectRadio.Text = "DETECT";
            this.detectRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPU Limit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port:";
            // 
            // MinefulSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detectRadio);
            this.Controls.Add(this.noneRadio);
            this.Controls.Add(this.nvidiaRadio);
            this.Controls.Add(this.amdRadio);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.cpuLimitSpinner);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.hashRateLabel);
            this.Controls.Add(this.startButton);
            this.Name = "MinefulSample";
            this.Text = "Windows Mineful Sample";
            ((System.ComponentModel.ISupportInitialize)(this.cpuLimitSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label hashRateLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.NumericUpDown cpuLimitSpinner;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.RadioButton amdRadio;
        private System.Windows.Forms.RadioButton nvidiaRadio;
        private System.Windows.Forms.RadioButton noneRadio;
        private System.Windows.Forms.RadioButton detectRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

