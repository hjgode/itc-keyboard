using System;
using System.Collections.Generic;
using System.Text;

using ITC_KEYBOARD;

namespace FunctionKeys2ControlKeysCF2
{
    class MapFKeys2CtrlKeysClass
    {
        ITC_KEYBOARD.CUSBkeys _cusbKeys = new CUSBkeys();

        /// <summary>
        /// map the function keys:
        /// F1 would send out CONTROLQ instead of F1 .
        /// F2 would send out CONTROLX
        /// F3 would send out CONTROLE
        /// F4 would send out CONTROLP
        /// </summary>
        public void mapFKeysToControlKeys()
        {
            //struct to hold key definition
            CUSBkeys.usbKeyStruct usbKey = new CUSBkeys.usbKeyStruct();

            //NORMAL Plane = 0x00
            //orange plane = 0x01
            //green/aqua plane = 0x02
            int iCount = _cusbKeys.getNumPlanes();
            for (int iPlane = 0; iPlane < iCount; iPlane++) //do for all planes
            {
                //remap F1 to NOOP
                //new use: _cusbKeys.getKeyStruct(iPlane, HardwareKeys.CK70Keys.ITC_Standard_UpperRight_Btn, ref usbKey);
                _cusbKeys.getKeyStruct(iPlane, ITC_KEYBOARD.CUsbKeyTypes.HWkeys.F1, ref usbKey);
                usbKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                usbKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
                usbKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.MultiKeyIndex;
                usbKey.bIntScan = 1;
                _cusbKeys.setKey(iPlane, CUsbKeyTypes.HWkeys.F1, usbKey);
            }
        }

        /// <summary>
        /// create multikey entries with Ctrl + Letters
        /// Control is 08,02,01,14
        /// </summary>
        public void createMultiKeys()
        {
            //get Ctrl Modifier Key
            int iCtrlIdx = findCtrlModifier();

            //read the multikeys
            string[] multikeys = _cusbKeys.getMultiKeys();

            //Multi3    = 00 00 08 02;                     00 08 00 14
            //          = NoFlag,NoFlag,ModIdx, 0x02;      NoFlag,VKey,NormalKey,0x14 (VK_CAPITAL)
            //Mod2      = 00 02 08 58
            //          = NoFlag,NoRepeat,ModIdx,0x58

            //new
            //########### Multi4    = 00 08 00 11                       00 00 00 15
            //          = NoFlag,VKey,NormalKey,VK_CONTROL  NoFlag,NoFlag,NormalKey,Q-Key
            //          = 00 00 00 15

            //F1 key:   = 07 3A 00 00 00 05
            // ########## as multi4 key:        07,3a,00,02,04,04

            //map to Control Modifier Index
            CMultiKeys.MultiKeyStruct[] uKey = new CMultiKeys.MultiKeyStruct[2];

            uKey[0].bFlagHigh =(byte) CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[0].bFlagMid = (byte)CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[0].bFlagLow = (byte)CUsbKeyTypes.usbFlagsLow.ModifierIndex;
            uKey[0].bIntScan = (byte)iCtrlIdx;

            //map to 'Q'
            uKey[1].bFlagHigh =(byte) CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[1].bFlagMid = (byte)CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[1].bFlagLow = (byte)CUsbKeyTypes.usbFlagsLow.NormalKey;
            uKey[1].bIntScan = 15;

            CMultiKeys cmulti = new CMultiKeys();
            int iMax = cmulti.getMultiKeyCount();

            //try to find existing MultiKey
            int iFound = cmulti.findMultiKey(uKey);
            if (iFound == -1)//if there was no existing entry, create a new one
            {
                iFound = cmulti.addMultiKey(uKey);
            }

            //now map the key in question to the new/existing MultiKeyEntry in all planes
            CUSBkeys.usbKeyStruct remapKey = new CUSBkeys.usbKeyStruct();
            for (int iPlane = 0; iPlane < _cusbKeys.getNumPlanes(); iPlane++)
            {
                if (_cusbKeys.getKeyStruct(iPlane, CUsbKeyTypes.HWkeys.F1, ref remapKey) != -1)
                {
                    remapKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                    remapKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NoRepeat;
                    remapKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.MultiKeyIndex;
                    remapKey.bIntScan = (byte)iFound;

                    _cusbKeys.setKey(iPlane, CUsbKeyTypes.HWkeys.F1, remapKey);
                }
            }
            _cusbKeys.writeKeyTables();
        }

        /// <summary>
        /// find the Modifiers Entry for the "Control Key"
        /// creates a new Modifier Entry if no entry is found
        /// </summary>
        /// <returns>-1 if not found
        /// pos value is index of found/created entry</returns>
        private int findCtrlModifier()
        {
            //  08,02,01,14 'Left Control'
            CUSBkeys.usbKeyStructShort uKey = CUSBkeys.controlModKey;// new CUSBkeys.usbKeyStructShort();
            int iFound = -1;
            CModifiersKeys cModis = new CModifiersKeys();
            iFound = cModis.findModifierKey(uKey);

            if (iFound == -1)
                iFound = cModis.addModifierKey(uKey);

            return iFound;
        }

        public void restoreDefaultMappings()
        {
            CUSBkeys cusb = new CUSBkeys();
            cusb.resetKeyDefaults();
        }
    }
}
