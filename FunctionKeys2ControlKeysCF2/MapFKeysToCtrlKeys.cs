using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FunctionKeys2ControlKeysCF2
{
    public partial class MapFKeysToCtrlKeys : Form
    {
        public MapFKeysToCtrlKeys()
        {
            InitializeComponent();
        }

        private void btnMapKeys_Click(object sender, EventArgs e)
        {
            MapFKeys2CtrlKeysClass mypClass = new MapFKeys2CtrlKeysClass();
            mypClass.createMultiKeys();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            ITC_KEYBOARD.CUSBkeys _usbKeys = new ITC_KEYBOARD.CUSBkeys();
            _usbKeys.resetKeyDefaults();
            _usbKeys.writeKeyTables();
        }

        private void mnuDump_Click(object sender, EventArgs e)
        {
            ITC_KEYBOARD.DumpForm frm = new ITC_KEYBOARD.DumpForm();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}