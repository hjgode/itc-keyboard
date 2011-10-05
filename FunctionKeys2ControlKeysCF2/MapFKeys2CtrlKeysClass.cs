using System;
using System.Collections.Generic;
using System.Text;

using ITC_KEYBOARD;

namespace FunctionKeys2ControlKeys
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
            createMultiKeys();
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

            //prepare a new multikey entry
            CUSBkeys.usbKeyStructShort[] uKey = new CUSBkeys.usbKeyStructShort[2];

            uKey[0].bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[0].bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[0].bFlagLow = CUsbKeyTypes.usbFlagsLow.ModifierIndex;
            uKey[0].bIntScan = (byte)iCtrlIdx;  //points to control modifier key index

            //map to 'Q'
            uKey[1].bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[1].bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[1].bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
            uKey[1].bIntScan = (byte)ITC_KEYBOARD.PS2KEYS.Q;

            //try to find existing MultiKey
            CMultiKeys cmulti = new CMultiKeys();
            int iMax = cmulti.getMultiKeyCount();
            int iFound = cmulti.findMultiKey(uKey);
            if (iFound == -1)//if there was no existing entry, create a new one
            {
                iFound = cmulti.addMultiKey(uKey);
            }

            //now map the key in question to the new/existing MultiKeyEntry in all planes
            //CUSBkeys.usbKeyStruct remapKey = new CUSBkeys.usbKeyStruct();

            //map 1 key in orange or aqua/green plane to new multikey
            setKeyToMultiKey((int)CUsbKeyTypes.HWkeys.one, (byte)iFound, cPlanes.plane.orange);

            //############### do the same with 2 key #####################

            //map to 'X', the first part of uKey remains the same
            uKey[1].bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[1].bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[1].bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
            uKey[1].bIntScan = (int)ITC_KEYBOARD.PS2KEYS.X; // 0x22; 
            //is this key sequence (Ctrl + X) already defined
            iFound = cmulti.findMultiKey(uKey);
            if (iFound == -1)//if there was no existing entry, create a new one
            {
                iFound = cmulti.addMultiKey(uKey);
            }
            //map 2 key in ornage or aqua/green plane to new multikey
            setKeyToMultiKey((int)CUsbKeyTypes.HWkeys.two, (byte)iFound, cPlanes.plane.orange);

            //############### do the same with F key #####################

            //map to 'E', the first part of uKey remains the same
            uKey[1].bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[1].bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[1].bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
            uKey[1].bIntScan = (int)ITC_KEYBOARD.PS2KEYS.E; 
            //is this key sequence (Ctrl + E) already defined
            iFound = cmulti.findMultiKey(uKey);
            if (iFound == -1)//if there was no existing entry, create a new one
            {
                iFound = cmulti.addMultiKey(uKey);
            }

            //map 3 key in ornage or aqua/green plane to new multikey
            setKeyToMultiKey((int)CUsbKeyTypes.HWkeys.three, (byte)iFound, cPlanes.plane.orange);

            //############### do the same with 4 key #####################

            //map to 'P', the first part of uKey remains the same
            uKey[1].bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
            uKey[1].bFlagMid = CUsbKeyTypes.usbFlagsMid.NoFlag;
            uKey[1].bFlagLow = CUsbKeyTypes.usbFlagsLow.NormalKey;
            uKey[1].bIntScan = (int)ITC_KEYBOARD.PS2KEYS.P; 
            //is this key sequence (Ctrl + X) already defined
            iFound = cmulti.findMultiKey(uKey);
            if (iFound == -1)//if there was no existing entry, create a new one
            {
                iFound = cmulti.addMultiKey(uKey);
            }
            //map 4 key in orange or aqua/green plane to new multikey
            setKeyToMultiKey((int)CUsbKeyTypes.HWkeys.four, (byte)iFound, cPlanes.plane.orange);

            _cusbKeys.writeKeyTables();
        }

        private void setKeyToMultiKey(int iKey, byte iMultiIndex, cPlanes.plane cPlane)
        {
            CUSBkeys.usbKeyStruct remapKey = new CUSBkeys.usbKeyStruct();

            if (_cusbKeys.getKeyStruct((int)cPlane, iKey, ref remapKey) != -1)
            {   //key exists
                remapKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                remapKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NoRepeat;
                remapKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.MultiKeyIndex;
                remapKey.bIntScan = (byte)iMultiIndex;

                _cusbKeys.setKey((int)cPlane, iKey, remapKey);
            }
            else
            {
                //add key
                remapKey.bHID = 0x07;
                remapKey.bScanKey = (CUsbKeyTypes.HWkeys)iKey;
                remapKey.bFlagHigh = CUsbKeyTypes.usbFlagsHigh.NoFlag;
                remapKey.bFlagMid = CUsbKeyTypes.usbFlagsMid.NoRepeat;
                remapKey.bFlagLow = CUsbKeyTypes.usbFlagsLow.MultiKeyIndex;
                remapKey.bIntScan = (byte)iMultiIndex;
                _cusbKeys.addKey(cPlane, remapKey);
            }
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
