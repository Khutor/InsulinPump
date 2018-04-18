using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tyler Clark
//Alexander Marquette

namespace InsulinPump
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }

        private void needleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEEDLE HAS BEEN REMOVED; INSERT NEEDLE AND RESTART DEVICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).reset();
            }
        }

        private void lowBattBtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).battery = 6;
            }

        }

        private void insulinFailureBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AN ISSUE HAS OCCURRED WITH THE INSULIN RESERVOIR; ATTEMPT TO FIX/REPLACE AND/OR RESTART THE DEVICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).resetInsulin();
            }
        }

        private void needleFailBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NEEDLE DELIVERY NOT RESPONDING CORRECTLY; ATTEMPT TO FIX/REPLACE AND/OR RESTART THE DEVICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).reset();
            }
        }

        private void sensorFailureBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SENSOR NOT RESPONDING CORRECTLY; ATTEMPT TO FIX/REPLACE AND/OR RESTART THE DEVICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).reset();
            }
        }

        private void insulinMissingBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INSULIN MISSING FROM DEVICE; REPLACE IMMEDIATELY AND RESTART DEVICE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).resetInsulin();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).resetAll();
            }
        }
    }
}
