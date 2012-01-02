using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace F1toTABS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F1toTABSTABS mapKeys = new F1toTABSTABS();
            mapKeys.mapF1toTABTABS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ITC_KEYBOARD.CUSBkeys cusb = new ITC_KEYBOARD.CUSBkeys();
            if (cusb.resetKeyDefaults() != 0)
                MessageBox.Show("You must reboot befor the changes become active");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}