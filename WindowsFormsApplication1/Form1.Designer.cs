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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label_CPUState = new MetroFramework.Controls.MetroLabel();
            this.label_ScanMode = new MetroFramework.Controls.MetroLabel();
            this.comboBox_CPUState = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxScanMode = new MetroFramework.Controls.MetroComboBox();
            this.checkBoxInput = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxMem = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxOutput = new MetroFramework.Controls.MetroCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(95, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CPU State:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(88, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Scan Mode:";
            // 
            // label_CPUState
            // 
            this.label_CPUState.AutoSize = true;
            this.label_CPUState.Location = new System.Drawing.Point(172, 83);
            this.label_CPUState.Name = "label_CPUState";
            this.label_CPUState.Size = new System.Drawing.Size(64, 19);
            this.label_CPUState.TabIndex = 3;
            this.label_CPUState.Text = "pendente";
            this.label_CPUState.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // label_ScanMode
            // 
            this.label_ScanMode.AutoSize = true;
            this.label_ScanMode.Location = new System.Drawing.Point(172, 105);
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
            this.comboBox_CPUState.Location = new System.Drawing.Point(88, 151);
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
            this.comboBoxScanMode.Location = new System.Drawing.Point(88, 186);
            this.comboBoxScanMode.Name = "comboBoxScanMode";
            this.comboBoxScanMode.Size = new System.Drawing.Size(148, 29);
            this.comboBoxScanMode.TabIndex = 6;
            this.comboBoxScanMode.UseSelectable = true;
            this.comboBoxScanMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxScanMode_SelectedIndexChanged);
            // 
            // checkBoxInput
            // 
            this.checkBoxInput.AutoSize = true;
            this.checkBoxInput.Location = new System.Drawing.Point(88, 243);
            this.checkBoxInput.Name = "checkBoxInput";
            this.checkBoxInput.Size = new System.Drawing.Size(41, 15);
            this.checkBoxInput.TabIndex = 7;
            this.checkBoxInput.Text = "I0.0";
            this.checkBoxInput.UseSelectable = true;
            this.checkBoxInput.CheckedChanged += new System.EventHandler(this.checkBoxInput_CheckedChanged);
            // 
            // checkBoxMem
            // 
            this.checkBoxMem.AutoSize = true;
            this.checkBoxMem.Location = new System.Drawing.Point(88, 265);
            this.checkBoxMem.Name = "checkBoxMem";
            this.checkBoxMem.Size = new System.Drawing.Size(49, 15);
            this.checkBoxMem.TabIndex = 8;
            this.checkBoxMem.Text = "M0.0";
            this.checkBoxMem.UseSelectable = true;
            this.checkBoxMem.CheckedChanged += new System.EventHandler(this.checkBoxMem_CheckedChanged);
            // 
            // checkBoxOutput
            // 
            this.checkBoxOutput.AutoSize = true;
            this.checkBoxOutput.Enabled = false;
            this.checkBoxOutput.Location = new System.Drawing.Point(88, 287);
            this.checkBoxOutput.Name = "checkBoxOutput";
            this.checkBoxOutput.Size = new System.Drawing.Size(47, 15);
            this.checkBoxOutput.TabIndex = 9;
            this.checkBoxOutput.Text = "Q0.0";
            this.checkBoxOutput.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 346);
            this.Controls.Add(this.checkBoxOutput);
            this.Controls.Add(this.checkBoxMem);
            this.Controls.Add(this.checkBoxInput);
            this.Controls.Add(this.comboBoxScanMode);
            this.Controls.Add(this.comboBox_CPUState);
            this.Controls.Add(this.label_ScanMode);
            this.Controls.Add(this.label_CPUState);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "AGV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label_CPUState;
        private MetroFramework.Controls.MetroLabel label_ScanMode;
        private MetroFramework.Controls.MetroComboBox comboBox_CPUState;
        private MetroFramework.Controls.MetroComboBox comboBoxScanMode;
        private MetroFramework.Controls.MetroCheckBox checkBoxInput;
        private MetroFramework.Controls.MetroCheckBox checkBoxMem;
        private MetroFramework.Controls.MetroCheckBox checkBoxOutput;
        private System.Windows.Forms.Timer timer1;
    }
}

