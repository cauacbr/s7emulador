namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label_CPUState = new MetroFramework.Controls.MetroLabel();
            this.label_ScanMode = new MetroFramework.Controls.MetroLabel();
            this.comboBox_CPUState = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxScanMode = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(130, 308);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Connect";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(101, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CPU State:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(94, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Scan Mode:";
            // 
            // label_CPUState
            // 
            this.label_CPUState.AutoSize = true;
            this.label_CPUState.Location = new System.Drawing.Point(178, 84);
            this.label_CPUState.Name = "label_CPUState";
            this.label_CPUState.Size = new System.Drawing.Size(64, 19);
            this.label_CPUState.TabIndex = 3;
            this.label_CPUState.Text = "pendente";
            this.label_CPUState.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // label_ScanMode
            // 
            this.label_ScanMode.AutoSize = true;
            this.label_ScanMode.Location = new System.Drawing.Point(178, 106);
            this.label_ScanMode.Name = "label_ScanMode";
            this.label_ScanMode.Size = new System.Drawing.Size(64, 19);
            this.label_ScanMode.TabIndex = 4;
            this.label_ScanMode.Text = "pendente";
            // 
            // comboBox_CPUState
            // 
            this.comboBox_CPUState.FormattingEnabled = true;
            this.comboBox_CPUState.ItemHeight = 23;
            this.comboBox_CPUState.Items.AddRange(new object[] {
            "RUN_P",
            "RUN",
            "STOP"});
            this.comboBox_CPUState.Location = new System.Drawing.Point(94, 152);
            this.comboBox_CPUState.Name = "comboBox_CPUState";
            this.comboBox_CPUState.Size = new System.Drawing.Size(148, 29);
            this.comboBox_CPUState.TabIndex = 5;
            this.comboBox_CPUState.UseSelectable = true;
            this.comboBox_CPUState.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // comboBoxScanMode
            // 
            this.comboBoxScanMode.FormattingEnabled = true;
            this.comboBoxScanMode.ItemHeight = 23;
            this.comboBoxScanMode.Items.AddRange(new object[] {
            "Single Scan",
            "Continuous Scan"});
            this.comboBoxScanMode.Location = new System.Drawing.Point(94, 187);
            this.comboBoxScanMode.Name = "comboBoxScanMode";
            this.comboBoxScanMode.Size = new System.Drawing.Size(148, 29);
            this.comboBoxScanMode.TabIndex = 6;
            this.comboBoxScanMode.UseSelectable = true;
            this.comboBoxScanMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxScanMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 409);
            this.Controls.Add(this.comboBoxScanMode);
            this.Controls.Add(this.comboBox_CPUState);
            this.Controls.Add(this.label_ScanMode);
            this.Controls.Add(this.label_CPUState);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "AGV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label_CPUState;
        private MetroFramework.Controls.MetroLabel label_ScanMode;
        private MetroFramework.Controls.MetroComboBox comboBox_CPUState;
        private MetroFramework.Controls.MetroComboBox comboBoxScanMode;
    }
}

