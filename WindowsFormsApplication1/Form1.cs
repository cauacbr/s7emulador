using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        S7PROSIMLib.S7ProSimClass PS = new S7PROSIMLib.S7ProSimClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = comboBox_CPUState.SelectedItem.ToString();
            PS.SetState(state);
            //label_CPUState.Text = PS.GetState().ToString();
        }

        private void comboBoxScanMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = comboBoxScanMode.SelectedItem.ToString();
            if (mode == "Single Scan")
            {
                PS.SetScanMode(S7PROSIMLib.ScanModeConstants.SingleScan);
            }
            else if (mode == "Continuous Scan")
            {
                PS.SetScanMode(S7PROSIMLib.ScanModeConstants.ContinuousScan);
            }
            //label_ScanMode.Text = PS.GetScanMode().ToString();
        }

        private void checkBoxInput_CheckedChanged(object sender, EventArgs e)
        {
            object IO_O = checkBoxInput.Checked;
            PS.WriteInputPoint(0, 0, ref IO_O);
        }

        private void checkBoxMem_CheckedChanged(object sender, EventArgs e)
        {
            object MO_O = checkBoxMem.Checked;
            PS.WriteFlagValue(0, 0, ref MO_O);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string state = PS.GetState().ToString();
            if (state == "ERROR")
            {
                PS.Connect();
            }

            else if (state != "ERROR")
            {
                label_CPUState.Text = state;
                label_ScanMode.Text = PS.GetScanMode().ToString();

                object QO_O = false;
                PS.ReadOutputPoint(0, 0, S7PROSIMLib.PointDataTypeConstants.S7_Bit, ref QO_O);
                checkBoxOutput.Checked = (bool)QO_O;
            }
            if (PS.GetState().ToString() == "ERROR")
            {
                label_CPUState.Text = "desconectado";
                label_ScanMode.Text = "desconectado";
            }

        }
    }
}
