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
            PS.Connect();
            label_CPUState.Text = PS.GetState().ToString();
            label_ScanMode.Text = PS.GetScanMode().ToString();

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = comboBox_CPUState.SelectedItem.ToString();
            PS.SetState(state);
            label_CPUState.Text = PS.GetState().ToString();
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
            label_ScanMode.Text = PS.GetScanMode().ToString();
        }
    }
}
