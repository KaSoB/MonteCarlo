namespace MonteCarlo {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MeasurementErrorTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfPointsToExecuteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.WynikGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecutionTimeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EstimatedPIValueTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NumberOfPointsInCircleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NumberOfPointsTextBox = new System.Windows.Forms.TextBox();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.WynikGroupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 400);
            this.MainPanel.TabIndex = 0;
            // 
            // MeasurementErrorTextBox
            // 
            this.MeasurementErrorTextBox.Location = new System.Drawing.Point(121, 142);
            this.MeasurementErrorTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.MeasurementErrorTextBox.Name = "MeasurementErrorTextBox";
            this.MeasurementErrorTextBox.ReadOnly = true;
            this.MeasurementErrorTextBox.Size = new System.Drawing.Size(110, 20);
            this.MeasurementErrorTextBox.TabIndex = 10;
            this.MeasurementErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Measurement error";
            // 
            // NumberOfPointsToExecuteTextBox
            // 
            this.NumberOfPointsToExecuteTextBox.Location = new System.Drawing.Point(121, 19);
            this.NumberOfPointsToExecuteTextBox.Name = "NumberOfPointsToExecuteTextBox";
            this.NumberOfPointsToExecuteTextBox.Size = new System.Drawing.Size(110, 20);
            this.NumberOfPointsToExecuteTextBox.TabIndex = 10;
            this.NumberOfPointsToExecuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberOfPointsToExecuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPointsToExecuteTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of points";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(568, 389);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(95, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // WynikGroupBox
            // 
            this.WynikGroupBox.Controls.Add(this.label1);
            this.WynikGroupBox.Controls.Add(this.MeasurementErrorTextBox);
            this.WynikGroupBox.Controls.Add(this.ExecutionTimeTextBox);
            this.WynikGroupBox.Controls.Add(this.label6);
            this.WynikGroupBox.Controls.Add(this.label8);
            this.WynikGroupBox.Controls.Add(this.EstimatedPIValueTextBox);
            this.WynikGroupBox.Controls.Add(this.label10);
            this.WynikGroupBox.Controls.Add(this.label11);
            this.WynikGroupBox.Controls.Add(this.NumberOfPointsInCircleTextBox);
            this.WynikGroupBox.Controls.Add(this.label12);
            this.WynikGroupBox.Controls.Add(this.NumberOfPointsTextBox);
            this.WynikGroupBox.Location = new System.Drawing.Point(418, 156);
            this.WynikGroupBox.Name = "WynikGroupBox";
            this.WynikGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.WynikGroupBox.Size = new System.Drawing.Size(245, 227);
            this.WynikGroupBox.TabIndex = 13;
            this.WynikGroupBox.TabStop = false;
            this.WynikGroupBox.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Format [mm:ss:ffffff]";
            // 
            // ExecutionTimeTextBox
            // 
            this.ExecutionTimeTextBox.Location = new System.Drawing.Point(121, 102);
            this.ExecutionTimeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.ExecutionTimeTextBox.Name = "ExecutionTimeTextBox";
            this.ExecutionTimeTextBox.ReadOnly = true;
            this.ExecutionTimeTextBox.Size = new System.Drawing.Size(110, 20);
            this.ExecutionTimeTextBox.TabIndex = 12;
            this.ExecutionTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Execution time";
            // 
            // EstimatedPIValueTextBox
            // 
            this.EstimatedPIValueTextBox.Location = new System.Drawing.Point(121, 182);
            this.EstimatedPIValueTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.EstimatedPIValueTextBox.Name = "EstimatedPIValueTextBox";
            this.EstimatedPIValueTextBox.ReadOnly = true;
            this.EstimatedPIValueTextBox.Size = new System.Drawing.Size(110, 20);
            this.EstimatedPIValueTextBox.TabIndex = 8;
            this.EstimatedPIValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Estimated PI value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Points in the circle";
            // 
            // NumberOfPointsInCircleTextBox
            // 
            this.NumberOfPointsInCircleTextBox.Location = new System.Drawing.Point(121, 62);
            this.NumberOfPointsInCircleTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.NumberOfPointsInCircleTextBox.Name = "NumberOfPointsInCircleTextBox";
            this.NumberOfPointsInCircleTextBox.ReadOnly = true;
            this.NumberOfPointsInCircleTextBox.Size = new System.Drawing.Size(110, 20);
            this.NumberOfPointsInCircleTextBox.TabIndex = 3;
            this.NumberOfPointsInCircleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Number of points";
            // 
            // NumberOfPointsTextBox
            // 
            this.NumberOfPointsTextBox.Location = new System.Drawing.Point(121, 22);
            this.NumberOfPointsTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.NumberOfPointsTextBox.Name = "NumberOfPointsTextBox";
            this.NumberOfPointsTextBox.ReadOnly = true;
            this.NumberOfPointsTextBox.Size = new System.Drawing.Size(110, 20);
            this.NumberOfPointsTextBox.TabIndex = 1;
            this.NumberOfPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.NumberOfPointsToExecuteTextBox);
            this.SettingsGroupBox.Controls.Add(this.label5);
            this.SettingsGroupBox.Location = new System.Drawing.Point(418, 12);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(245, 59);
            this.SettingsGroupBox.TabIndex = 3;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 422);
            this.Controls.Add(this.WynikGroupBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estimating Pi using the Monte Carlo Method";
            this.WynikGroupBox.ResumeLayout(false);
            this.WynikGroupBox.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox NumberOfPointsToExecuteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MeasurementErrorTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox WynikGroupBox;
        private System.Windows.Forms.TextBox ExecutionTimeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EstimatedPIValueTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NumberOfPointsInCircleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NumberOfPointsTextBox;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label label1;
    }
}

