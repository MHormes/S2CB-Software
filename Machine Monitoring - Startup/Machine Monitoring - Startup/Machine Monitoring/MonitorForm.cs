using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Monitoring
{
    public partial class MonitorForm : Form
    {
        MachineManager MM;
 
        public MonitorForm()
        {
            InitializeComponent();
            MM = new MachineManager();
            FillMachinesListBox();
        }

        public void FillMachinesListBox()
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add($"Company: VDL assembling Mini Cooper with {MM.GetAllMachines().Count()} machines.");

            foreach(Machine m in MM.GetAllMachines())
            {
                lbInfo.Items.Add(m);
            }
        }

        public void CheckForWarnings()
        {
            lbWarnings.Items.Clear();
            foreach(string w in MM.GetWarnings())
            {
                lbWarnings.Items.Add(w);
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            var addMachine = MM.AddMachine(tbMachineName.Text, tbTemperature.Text, tbPressure.Text);
            if (addMachine != null)
            {
                MessageBox.Show(addMachine.Message);
                return;
            }
            FillMachinesListBox();
        }

        private void btnSimTemperature_Click(object sender, EventArgs e)
        {
            var changeTemp = MM.ChangeTemp(tbMachineName.Text, tbTemperature.Text);
            if(changeTemp != null)
            {
                MessageBox.Show(changeTemp.Message);
                return;
            }
            CheckForWarnings();
            FillMachinesListBox();
        }

        private void btnSimPressure_Click(object sender, EventArgs e)
        {
            var changePress = MM.ChangePress(tbMachineName.Text, tbPressure.Text);
            if (changePress != null)
            {
                MessageBox.Show(changePress.Message);
                return;
            }
            CheckForWarnings();
            FillMachinesListBox();
        }

        private void btnToggleLogging_Click(object sender, EventArgs e)
        {
            if(btnToggleLogging.Text == "Start logging")
            {
                btnToggleLogging.Text = "Stop logging";
                MM.Loggin = true;
                return;
            }
            if (btnToggleLogging.Text == "Stop logging")
            {
                btnToggleLogging.Text = "Start logging";
                MM.Loggin = false;
                return;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MM.ML.LoadFromFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MM.ML.SaveToFile();
        }
    }
}