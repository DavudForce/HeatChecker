namespace HeatChecker
{
    partial class Settings
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
            rdbtnBtryNotCHarging = new RadioButton();
            rdbtnBtryChrgLow = new RadioButton();
            trackbrUpdateInterval = new TrackBar();
            label14 = new Label();
            label13 = new Label();
            label4 = new Label();
            chckPlySounds = new CheckBox();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label2 = new Label();
            chckBtrySleepPc = new CheckBox();
            chckSystemtray = new CheckBox();
            chckAutoStart = new CheckBox();
            pictureBox1 = new PictureBox();
            rdbtnBatteryChargeDisabled = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)trackbrUpdateInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rdbtnBtryNotCHarging
            // 
            rdbtnBtryNotCHarging.AutoSize = true;
            rdbtnBtryNotCHarging.Checked = true;
            rdbtnBtryNotCHarging.Location = new Point(73, 150);
            rdbtnBtryNotCHarging.Name = "rdbtnBtryNotCHarging";
            rdbtnBtryNotCHarging.Size = new Size(95, 19);
            rdbtnBtryNotCHarging.TabIndex = 8;
            rdbtnBtryNotCHarging.TabStop = true;
            rdbtnBtryNotCHarging.Text = "Not charging";
            rdbtnBtryNotCHarging.UseVisualStyleBackColor = true;
            // 
            // rdbtnBtryChrgLow
            // 
            rdbtnBtryChrgLow.AutoSize = true;
            rdbtnBtryChrgLow.Location = new Point(73, 175);
            rdbtnBtryChrgLow.Name = "rdbtnBtryChrgLow";
            rdbtnBtryChrgLow.Size = new Size(96, 19);
            rdbtnBtryChrgLow.TabIndex = 8;
            rdbtnBtryChrgLow.Text = "Charge is low";
            rdbtnBtryChrgLow.UseVisualStyleBackColor = true;
            // 
            // trackbrUpdateInterval
            // 
            trackbrUpdateInterval.Location = new Point(518, 175);
            trackbrUpdateInterval.Maximum = 20;
            trackbrUpdateInterval.Name = "trackbrUpdateInterval";
            trackbrUpdateInterval.Size = new Size(203, 45);
            trackbrUpdateInterval.TabIndex = 12;
            trackbrUpdateInterval.Value = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(680, 157);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 9;
            label14.Text = "slowest";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(518, 157);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 10;
            label13.Text = "fastest";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 177);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 11;
            label4.Text = "Default update interval:";
            // 
            // chckPlySounds
            // 
            chckPlySounds.AutoSize = true;
            chckPlySounds.Checked = true;
            chckPlySounds.CheckState = CheckState.Checked;
            chckPlySounds.Location = new Point(12, 12);
            chckPlySounds.Name = "chckPlySounds";
            chckPlySounds.Size = new Size(89, 19);
            chckPlySounds.TabIndex = 5;
            chckPlySounds.Text = "Play sounds";
            chckPlySounds.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 11;
            label1.Text = "Warm me when my PC heat is";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Enabled = false;
            checkBox3.Location = new Point(73, 52);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(67, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Below 0";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Enabled = false;
            checkBox4.Location = new Point(73, 77);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(75, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Above 70";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Enabled = false;
            checkBox5.Location = new Point(73, 102);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(75, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Above 90";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 132);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 11;
            label2.Text = "Warm me when my PC";
            // 
            // chckBtrySleepPc
            // 
            chckBtrySleepPc.AutoSize = true;
            chckBtrySleepPc.Location = new Point(73, 224);
            chckBtrySleepPc.Name = "chckBtrySleepPc";
            chckBtrySleepPc.Size = new Size(289, 19);
            chckBtrySleepPc.TabIndex = 5;
            chckBtrySleepPc.Text = "Automatically sleep computer when charge is low";
            chckBtrySleepPc.UseVisualStyleBackColor = true;
            // 
            // chckSystemtray
            // 
            chckSystemtray.AutoSize = true;
            chckSystemtray.Checked = true;
            chckSystemtray.CheckState = CheckState.Checked;
            chckSystemtray.Location = new Point(394, 12);
            chckSystemtray.Name = "chckSystemtray";
            chckSystemtray.Size = new Size(243, 19);
            chckSystemtray.TabIndex = 5;
            chckSystemtray.Text = "Minimize to system tray when minimized";
            chckSystemtray.UseVisualStyleBackColor = true;
            // 
            // chckAutoStart
            // 
            chckAutoStart.AutoSize = true;
            chckAutoStart.Enabled = false;
            chckAutoStart.Location = new Point(394, 37);
            chckAutoStart.Name = "chckAutoStart";
            chckAutoStart.Size = new Size(297, 19);
            chckAutoStart.TabIndex = 5;
            chckAutoStart.Text = "Automatically start application on Windows startup";
            chckAutoStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(372, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1, 234);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // rdbtnBatteryChargeDisabled
            // 
            rdbtnBatteryChargeDisabled.AutoSize = true;
            rdbtnBatteryChargeDisabled.Location = new Point(73, 200);
            rdbtnBatteryChargeDisabled.Name = "rdbtnBatteryChargeDisabled";
            rdbtnBatteryChargeDisabled.Size = new Size(70, 19);
            rdbtnBatteryChargeDisabled.TabIndex = 8;
            rdbtnBatteryChargeDisabled.Text = "Disabled";
            rdbtnBatteryChargeDisabled.UseVisualStyleBackColor = true;
            rdbtnBatteryChargeDisabled.CheckedChanged += rdbtnBatteryChargeDisabled_CheckedChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 254);
            Controls.Add(pictureBox1);
            Controls.Add(trackbrUpdateInterval);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(rdbtnBatteryChargeDisabled);
            Controls.Add(rdbtnBtryChrgLow);
            Controls.Add(rdbtnBtryNotCHarging);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(chckAutoStart);
            Controls.Add(chckSystemtray);
            Controls.Add(chckPlySounds);
            Controls.Add(chckBtrySleepPc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            FormClosing += Settings_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackbrUpdateInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbtnBtryNotCHarging;
        private RadioButton rdbtnBtryChrgLow;
        private TrackBar trackbrUpdateInterval;
        private Label label14;
        private Label label13;
        private Label label4;
        private CheckBox chckPlySounds;
        private Label label1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label2;
        private CheckBox chckBtrySleepPc;
        private CheckBox chckSystemtray;
        private CheckBox chckAutoStart;
        private PictureBox pictureBox1;
        private RadioButton rdbtnBatteryChargeDisabled;
    }
}