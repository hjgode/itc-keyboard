using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ITC_KEYBOARD;

namespace AllSideScan2
{
    public partial class AllSideScan2 : Form
    {
        public AllSideScan2()
        {
            InitializeComponent();
            mapAllSide2NOOP();
        }
        private void mapAllSide2NOOP()
        {
            //init the class
            ITC_KEYBOARD.CUSBkeys _cusbKeys = new ITC_KEYBOARD.CUSBkeys();

            //struct to hold key definition
            CUSBkeys.usbKeyStruct usbKey = new CUSBkeys.usbKeyStruct();

            //NORMAL Plane = 0x00
            //orange plane = 0x01
            //green/aqua plane = 0x02
            for (int iPlane = 0; 0 < 0x3; iPlane++) //do for all planes
            {
                //remap F6 to NOOP
                _cusbKeys.getKeyStruct(iPlane, ITC_KEYBOARD.CUsbKeyTypes.HWkeys.F6_VOL_UP, ref usbKey);
                usbKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                usbKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NOOP;
                usbKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
                _cusbKeys.setKey(iPlane, CUsbKeyTypes.HWkeys.F6_VOL_UP, usbKey);

                // F7
                _cusbKeys.getKeyStruct(iPlane, ITC_KEYBOARD.CUsbKeyTypes.HWkeys.F7_VOL_DN, ref usbKey);
                usbKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                usbKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NOOP;
                usbKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
                _cusbKeys.setKey(iPlane, CUsbKeyTypes.HWkeys.F7_VOL_DN, usbKey);

                //Side Scan button: dec145, 0x91
                _cusbKeys.getKeyStruct(iPlane, 0x91, ref usbKey);
                usbKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                usbKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NOOP;
                usbKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
                _cusbKeys.setKey(iPlane, 0x91, usbKey);

                //APP key: dec67, 0x43
                _cusbKeys.getKeyStruct(iPlane, 0x43, ref usbKey);
                usbKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                usbKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NOOP;
                usbKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
                _cusbKeys.setKey(iPlane, 0x43, usbKey);

            }
            _cusbKeys.writeKeyTables();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}