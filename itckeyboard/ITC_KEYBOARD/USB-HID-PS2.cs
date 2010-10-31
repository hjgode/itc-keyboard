using System;
using System.Collections.Generic;
using System.Text;

namespace ITC_KEYBOARD
{
            #region enumUSBHID
        public enum USBHID :int{
            NoEvent = 0x00,
            OverrunError = 0x01,
            POSTFail = 0x02,
            ErrorUndefined = 0x03,
            a = 0x04,
            A = 0x04,
            b = 0x05,
            B = 0x05,
            c = 0x06,
            C = 0x06,
            d = 0x07,
            D = 0x07,
            e = 0x08,
            E = 0x08,
            f = 0x09,
            F = 0x09,
            g = 0x0A,
            G = 0x0A,
            h = 0x0B,
            H = 0x0B,
            i = 0x0C,
            I = 0x0C,
            j = 0x0D,
            J = 0x0D,
            k = 0x0E,
            K = 0x0E,
            l = 0x0F,
            L = 0x0F,
            m = 0x10,
            M = 0x10,
            n = 0x11,
            N = 0x11,
            o = 0x12,
            O = 0x12,
            p = 0x13,
            P = 0x13,
            q = 0x14,
            Q = 0x14,
            r = 0x15,
            R = 0x15,
            s = 0x16,
            S = 0x16,
            t = 0x17,
            T = 0x17,
            u = 0x18,
            U = 0x18,
            v = 0x19,
            V = 0x19,
            w = 0x1A,
            W = 0x1A,
            x = 0x1B,
            X = 0x1B,
            y = 0x1C,
            Y = 0x1C,
            z = 0x1D,
            Z = 0x1D,
            Exclamation = 0x1E,
            one = 0x1E,
            AT = 0x1F,
            two = 0x1F,
            Hash = 0x20,
            three = 0x20,
            Dollar = 0x21,
            four = 0x21,
            five = 0x22,
            Percent = 0x22,
            AccentGrave = 0x23,
            six = 0x23,
            Ampersand = 0x24,
            seven = 0x24,
            Asterisk = 0x25,
            eight = 0x25,
            BracketLeft = 0x26,
            nine = 0x26,
            BracketRight = 0x27,
            zero = 0x27,
            Return = 0x28,
            Escape = 0x29,
            Backspace = 0x2A,
            Tab = 0x2B,
            Space = 0x2C,
            Minus = 0x2D,
            underscore = 0x2D,
            Equal = 0x2E,
            plus = 0x2E,
            BraceLeft = 0x2F,
            SquareBracketLeft = 0x2F,
            BraceRight = 0x30,
            SquareBracketRight = 0x30,
            Backslash = 0x31,
            Pipe = 0x31,
            Europe1 = 0x32,
            Colon = 0x33,
            Semicolon = 0x33,
            //Backslash	 = 	0x34,
            AccentRight = 0x34,
            AccentLeft = 0x35,
            Tilde = 0x35,
            Comma = 0x36,
            LessThan = 0x36,
            Dot = 0x37,
            GreaterThan = 0x37,
            QuestionMark = 0x38,
            Slash = 0x38,
            CapsLock = 0x39,
            F1 = 0x3A,
            F2 = 0x3B,
            F3 = 0x3C,
            F4 = 0x3D,
            F5 = 0x3E,
            F6 = 0x3F,
            F7 = 0x40,
            F8 = 0x41,
            F9 = 0x42,
            F10 = 0x43,
            F11 = 0x44,
            F12 = 0x45,
            PrintScreen = 0x46,
            ScrollLock = 0x47,
            Break = 0x48,
            Pause = 0x48,
            Insert = 0x49,
            Home = 0x4A,
            PageUp = 0x4B,
            Delete = 0x4C,
            End = 0x4D,
            PageDown = 0x4E,
            RightArrow = 0x4F,
            LeftArrow = 0x50,
            DownArrow = 0x51,
            UpArrow = 0x52,
            NumLock = 0x53,
            KeypadSlash = 0x54,
            KeypadAsterisk = 0x55,
            KeypadDash = 0x56,
            KeypadPlus = 0x57,
            KeypadEnter = 0x58,
            Keypad1 = 0x59,
            Keypad2 = 0x5A,
            Keypad3 = 0x5B,
            Keypad4 = 0x5C,
            Keypad5 = 0x5D,
            Keypad6 = 0x5E,
            Keypad7 = 0x5F,
            Keypad8 = 0x60,
            Keypad9 = 0x61,
            Keypad0 = 0x62,
            KeypadDot = 0x63,
            Europe2 = 0x64,
            App = 0x65,
            KeyboardPower = 0x66,
            KeypadEqual = 0x67,
            F13 = 0x68,
            F14 = 0x69,
            F15 = 0x6A,
            F16 = 0x6B,
            F17 = 0x6C,
            F18 = 0x6D,
            F19 = 0x6E,
            F20 = 0x6F,
            F21 = 0x70,
            F22 = 0x71,
            F23 = 0x72,
            F24 = 0x73,
            KeyboardExecute = 0x74,
            KeyboardHelp = 0x75,
            KeyboardMenu = 0x76,
            KeyboardSelect = 0x77,
            KeyboardStop = 0x78,
            KeyboardAgain = 0x79,
            KeyboardUndo = 0x7A,
            KeyboardCut = 0x7B,
            KeyboardCopy = 0x7C,
            KeyboardPaste = 0x7D,
            KeyboardFind = 0x7E,
            KeyboardMute = 0x7F,
            KeyboardVolumeUp = 0x80,
            KeyboardVolumeDown = 0x81,
            SystemPower = 0x81,
            KeyboardLockingCapsLock = 0x82,
            SystemSleep = 0x82,
            KeyboardLockingNumLock = 0x83,
            SystemWake = 0x83,
            KeyboardLockingScrollLock = 0x84,
            KeypadComma = 0x85,
            KeyboardEqualSign = 0x86,
            KeyboardIntl1 = 0x87,
            KeyboardIntl2 = 0x88,
            KeyboardIntl3 = 0x89,
            Action = 0x8A,
            AquaPlane = 0x8B,
            KeyboardIntl5 = 0x8B,
            KeyboardIntl6 = 0x8C,
            KeyboardIntl7 = 0x8D,
            KeyboardIntl8 = 0x8E,
            KeyboardIntl9 = 0x8F,
            KeyboardLang1 = 0x90,
            KeyboardLang2 = 0x91,
            KeyboardLang3 = 0x92,
            KeyboardLang4 = 0x93,
            KeyboardLang5 = 0x94,
            KeyboardLang6 = 0x95,
            KeyboardLang7 = 0x96,
            KeyboardLang8 = 0x97,
            KeyboardLang9 = 0x98,
            KeyboardAlternateErase = 0x99,
            KeyboardSysReqAttention = 0x9A,
            KeyboardCancel = 0x9B,
            KeyboardClear = 0x9C,
            KeyboardPrior = 0x9D,
            KeyboardReturn = 0x9E,
            KeyboardSeparator = 0x9F,
            KeyboardOut = 0xA0,
            KeyboardOper = 0xA1,
            KeyboardClearAgain = 0xA2,
            KeyboardCrSelProps = 0xA3,
            KeyboardExSel = 0xA4,
            RESERVED = 0xA5,
            GreenPlane = 0xB6,
            RESERVEDxc000 = 0xc000,
            RESERVEDxDF = 0xDF,
            LeftControl = 0xE0,
            LeftShift = 0xE1,
            LeftAlt = 0xE2,
            LeftGUI = 0xE3,
            RightControl = 0xE4,
            RightShift = 0xE5,
            RightAlt = 0xE6,
            OK = 0xE7,
            RightGUI_OK = 0xE7,
            RESERVEDxE8 = 0xE8,
            OrangePlane = 0xE9,
        };
            #endregion
    public static class USBHIDlist
    {
    }
    /// <summary>
    /// class to manage USB HID and PS/2 key values, flags and names
    /// </summary>
    class CUSBPS2_vals
    {
        /// <summary>
        /// this class is used to get the name of PS/2 key value
        /// </summary>
        public class Cusbps2key
        {
		    string keyname;
		    byte HIDusagePage;
		    UInt32 HIDusageID;
		    UInt32 PS2set;
		    byte flag;
            /// <summary>
            /// constructor of a new USB/PS2 entry
            /// </summary>
            /// <param name="sKeyName"></param>
            /// <param name="bHIDusagePage"></param>
            /// <param name="dwHIDusageID"></param>
            /// <param name="dwPS2set"></param>
            /// <param name="bFlag"></param>
            public Cusbps2key(string sKeyName, byte bHIDusagePage, UInt32 dwHIDusageID, UInt32 dwPS2set, byte bFlag){
                this.keyname=sKeyName;
                this.HIDusagePage=bHIDusagePage;
                this.HIDusageID=dwHIDusageID;
                this.PS2set=dwPS2set;
                this.flag=bFlag;
            }

            /// <summary>
            /// the name of the key
            /// </summary>
            /// <param name="theEntry"></param>
            /// <returns></returns>
            public string getName(Cusbps2key theEntry){
                return theEntry.keyname;
            }
            /// <summary>
            /// Get the PS2 name of a USB key
            /// </summary>
            /// <param name="ID">HID value of key</param>
            /// <returns></returns>
            public static string getName(int ID)
            {
                for (int i = 0; i < usbps2table.Length; i++)
                {
                    if (usbps2table[i].PS2set==ID) //HIDusageID == ID)
                        return usbps2table[i].keyname;
                }
                return "n/a";
            }

            /// <summary>
            /// get the name of a USB HID Hardware key scan code
            /// </summary>
            /// <param name="ID">one of the known USB HID HWkey values</param>
            /// <returns></returns>
            public static string getNameUSBHID(CUsbKeyTypes.HWkeys ID)
            {
                for (int i = 0; i < usbps2table.Length; i++)
                {
                    if (usbps2table[i].HIDusageID==(int)ID) //HIDusageID == ID)
                        return usbps2table[i].keyname;
                }
                return "n/a";
            }
            
            /// <summary>
            /// get the name of a USB HID Hardware key scan code
            /// </summary>
            /// <param name="ID">numeric index into the usbPS2table</param>
            /// <returns></returns>
            public static string getNameUSBHID(int ID)
            {
                for (int i = 0; i < usbps2table.Length; i++)
                {
                    if (usbps2table[i].HIDusageID==ID) //HIDusageID == ID)
                        return usbps2table[i].keyname;
                }
                return "n/a";
            }
        }
        /// <summary>
        /// flag for PS/2 hardware key
        /// </summary>
        public const byte EXTENDED = 0xE0;
        /// <summary>
        /// flag for PS/2 hardware key
        /// </summary>
        public const byte NORMAL	= 0x00;
        /// <summary>
        /// flag for PS/2 hardware key
        /// </summary>
        public const byte SHIFTED	= 0x01;
        /// <summary>
        /// flag for VKEY meaning
        /// </summary>
        public const byte VKEY		= 0x10;


        #region usbps2table
        /// <summary>
        /// a list with known USB HID scan codes, there flags and there names
        /// </summary>
        public static Cusbps2key[] usbps2table = new Cusbps2key[]{
            //            text   CP USBHID  PS2 Flags
            new Cusbps2key("System Power", 0x01, 0x81, 0xE037, EXTENDED),
            new Cusbps2key("System Sleep", 0x01, 0x82, 0xE03F, EXTENDED),
            new Cusbps2key("System Wake", 0x01, 0x83, 0xE05E, EXTENDED),
            new Cusbps2key("No Event", 0x07, 0x00, 0xa000, NORMAL),
            new Cusbps2key("Overrun Error", 0x07, 0x01, 0x00, NORMAL),
            new Cusbps2key("POST Fail", 0x07, 0x02, 0xFC, NORMAL),
            new Cusbps2key("Error Undefined", 0x07, 0x03, 0xc000, NORMAL),

            new Cusbps2key("a", 0x07, 0x04, 0x1C, NORMAL),
            new Cusbps2key("b", 0x07, 0x05, 0x32, NORMAL),
            new Cusbps2key("c", 0x07, 0x06, 0x21, NORMAL),
            new Cusbps2key("d", 0x07, 0x07, 0x23, NORMAL),
            new Cusbps2key("e", 0x07, 0x08, 0x24, NORMAL),
            new Cusbps2key("f", 0x07, 0x09, 0x2B, NORMAL),
            new Cusbps2key("g", 0x07, 0x0A, 0x34, NORMAL),
            new Cusbps2key("h", 0x07, 0x0B, 0x33, NORMAL),
            new Cusbps2key("i", 0x07, 0x0C, 0x43, NORMAL),
            new Cusbps2key("j", 0x07, 0x0D, 0x3B, NORMAL),
            new Cusbps2key("k", 0x07, 0x0E, 0x42, NORMAL),
            new Cusbps2key("l", 0x07, 0x0F, 0x4B, NORMAL),
            new Cusbps2key("m", 0x07, 0x10, 0x3A, NORMAL),
            new Cusbps2key("n", 0x07, 0x11, 0x31, NORMAL),
            new Cusbps2key("o", 0x07, 0x12, 0x44, NORMAL),
            new Cusbps2key("p", 0x07, 0x13, 0x4D, NORMAL),
            new Cusbps2key("q", 0x07, 0x14, 0x15, NORMAL),
            new Cusbps2key("r", 0x07, 0x15, 0x2D, NORMAL),
            new Cusbps2key("s", 0x07, 0x16, 0x1B, NORMAL),
            new Cusbps2key("t", 0x07, 0x17, 0x2C, NORMAL),
            new Cusbps2key("u", 0x07, 0x18, 0x3C, NORMAL),
            new Cusbps2key("v", 0x07, 0x19, 0x2A, NORMAL),
            new Cusbps2key("w", 0x07, 0x1A, 0x1D, NORMAL),
            new Cusbps2key("x", 0x07, 0x1B, 0x22, NORMAL),
            new Cusbps2key("y", 0x07, 0x1C, 0x35, NORMAL),
            new Cusbps2key("z", 0x07, 0x1D, 0x1A, NORMAL),
            new Cusbps2key("1", 0x07, 0x1E, 0x16, NORMAL),
            new Cusbps2key("2", 0x07, 0x1F, 0x1E, NORMAL),
            new Cusbps2key("3", 0x07, 0x20, 0x26, NORMAL),
            new Cusbps2key("4", 0x07, 0x21, 0x25, NORMAL),
            new Cusbps2key("5", 0x07, 0x22, 0x2E, NORMAL),
            new Cusbps2key("6", 0x07, 0x23, 0x36, NORMAL),
            new Cusbps2key("7", 0x07, 0x24, 0x3D, NORMAL),
            new Cusbps2key("8", 0x07, 0x25, 0x3E, NORMAL),
            new Cusbps2key("9", 0x07, 0x26, 0x46, NORMAL),
            new Cusbps2key("0", 0x07, 0x27, 0x45, NORMAL),

	        new Cusbps2key("Return", 0x07, 0x28, 0x5A, NORMAL),
            new Cusbps2key("Escape", 0x07, 0x29, 0x76, NORMAL),
            new Cusbps2key("Backspace", 0x07, 0x2A, 0x66, NORMAL),
            new Cusbps2key("Tab", 0x07, 0x2B, 0x0D, NORMAL),
            new Cusbps2key("Space", 0x07, 0x2C, 0x29, NORMAL),
            new Cusbps2key("Europe 1", 0x07, 0x32, 0x5D, NORMAL),

	        new Cusbps2key("A", 0x07, 0x04, 0x1C, SHIFTED),
            new Cusbps2key("B", 0x07, 0x05, 0x32, SHIFTED),
            new Cusbps2key("C", 0x07, 0x06, 0x21, SHIFTED),
            new Cusbps2key("D", 0x07, 0x07, 0x23, SHIFTED),
            new Cusbps2key("E", 0x07, 0x08, 0x24, SHIFTED),
            new Cusbps2key("F", 0x07, 0x09, 0x2B, SHIFTED),
            new Cusbps2key("G", 0x07, 0x0A, 0x34, SHIFTED),
            new Cusbps2key("H", 0x07, 0x0B, 0x33, SHIFTED),
            new Cusbps2key("I", 0x07, 0x0C, 0x43, SHIFTED),
            new Cusbps2key("J", 0x07, 0x0D, 0x3B, SHIFTED),
            new Cusbps2key("K", 0x07, 0x0E, 0x42, SHIFTED),
            new Cusbps2key("L", 0x07, 0x0F, 0x4B, SHIFTED),
            new Cusbps2key("M", 0x07, 0x10, 0x3A, SHIFTED),
            new Cusbps2key("N", 0x07, 0x11, 0x31, SHIFTED),
            new Cusbps2key("O", 0x07, 0x12, 0x44, SHIFTED),
            new Cusbps2key("P", 0x07, 0x13, 0x4D, SHIFTED),
            new Cusbps2key("Q", 0x07, 0x14, 0x15, SHIFTED),
            new Cusbps2key("R", 0x07, 0x15, 0x2D, SHIFTED),
            new Cusbps2key("S", 0x07, 0x16, 0x1B, SHIFTED),
            new Cusbps2key("T", 0x07, 0x17, 0x2C, SHIFTED),
            new Cusbps2key("U", 0x07, 0x18, 0x3C, SHIFTED),
            new Cusbps2key("V", 0x07, 0x19, 0x2A, SHIFTED),
            new Cusbps2key("W", 0x07, 0x1A, 0x1D, SHIFTED),
            new Cusbps2key("X", 0x07, 0x1B, 0x22, SHIFTED),
            new Cusbps2key("Y", 0x07, 0x1C, 0x35, SHIFTED),
            new Cusbps2key("Z", 0x07, 0x1D, 0x1A, SHIFTED),
            new Cusbps2key("!", 0x07, 0x1E, 0x16, SHIFTED),
            new Cusbps2key("@", 0x07, 0x1F, 0x1E, SHIFTED),
            new Cusbps2key("#", 0x07, 0x20, 0x26, SHIFTED),
            new Cusbps2key("$", 0x07, 0x21, 0x25, SHIFTED),
            new Cusbps2key("%", 0x07, 0x22, 0x2E, SHIFTED),
            new Cusbps2key("^", 0x07, 0x23, 0x36, SHIFTED),
            new Cusbps2key("&", 0x07, 0x24, 0x3D, SHIFTED),
            new Cusbps2key("*", 0x07, 0x25, 0x3E, SHIFTED),
            new Cusbps2key("(", 0x07, 0x26, 0x46, SHIFTED),
            new Cusbps2key(")", 0x07, 0x27, 0x45, SHIFTED),

            new Cusbps2key("-", 0x07, 0x2D, 0x4E, NORMAL),
            new Cusbps2key("=", 0x07, 0x2E, 0x55, NORMAL),
            new Cusbps2key("[", 0x07, 0x2F, 0x54, NORMAL),
            new Cusbps2key("]", 0x07, 0x30, 0x5B, NORMAL),
            new Cusbps2key("\\", 0x07, 0x31, 0x5D, NORMAL),
            new Cusbps2key(";", 0x07, 0x33, 0x4C, NORMAL),
            new Cusbps2key("�", 0x07, 0x34, 0x52, NORMAL),
            new Cusbps2key("`", 0x07, 0x35, 0x0E, NORMAL),
            new Cusbps2key(",", 0x07, 0x36, 0x41, NORMAL),
            new Cusbps2key(".", 0x07, 0x37, 0x49, NORMAL),
            new Cusbps2key("/", 0x07, 0x38, 0x4A, NORMAL),

            new Cusbps2key("_", 0x07, 0x2D, 0x4E, SHIFTED),
            new Cusbps2key("+", 0x07, 0x2E, 0x55, SHIFTED),
            new Cusbps2key("{", 0x07, 0x2F, 0x54, SHIFTED),
            new Cusbps2key("}", 0x07, 0x30, 0x5B, SHIFTED),
            new Cusbps2key("|", 0x07, 0x31, 0x5D, SHIFTED),
            new Cusbps2key(":", 0x07, 0x33, 0x4C, SHIFTED),
            new Cusbps2key("\"", 0x07, 0x34, 0x52, SHIFTED),
            new Cusbps2key("~", 0x07, 0x35, 0x0E, SHIFTED),
            new Cusbps2key("<", 0x07, 0x36, 0x41, SHIFTED),
            new Cusbps2key(">", 0x07, 0x37, 0x49, SHIFTED),
            new Cusbps2key("?", 0x07, 0x38, 0x4A, SHIFTED),

            new Cusbps2key("Caps Lock", 0x07, 0x39, 0x58, NORMAL),
            new Cusbps2key("F1", 0x07, 0x3A, 0x05, NORMAL),
            new Cusbps2key("F2", 0x07, 0x3B, 0x06, NORMAL),
            new Cusbps2key("F3", 0x07, 0x3C, 0x04, NORMAL),
            new Cusbps2key("F4", 0x07, 0x3D, 0x0C, NORMAL),
            new Cusbps2key("F5", 0x07, 0x3E, 0x03, NORMAL),
            new Cusbps2key("F6", 0x07, 0x3F, 0x0B, NORMAL),
            new Cusbps2key("F7", 0x07, 0x40, 0x83, NORMAL),
            new Cusbps2key("F8", 0x07, 0x41, 0x0A, NORMAL),
            new Cusbps2key("F9", 0x07, 0x42, 0x01, NORMAL),
            new Cusbps2key("F10", 0x07, 0x43, 0x09, NORMAL),
            new Cusbps2key("F11", 0x07, 0x44, 0x78, NORMAL),
            new Cusbps2key("F12", 0x07, 0x45, 0x07, NORMAL),
            new Cusbps2key("Print Screen", 0x07, 0x46, 0xE07C, EXTENDED),
            new Cusbps2key("Scroll Lock", 0x07, 0x47, 0x7E, NORMAL),
        	
            new Cusbps2key("Break", 0x07, 0x48, 0xE07E, EXTENDED),
            new Cusbps2key("Insert", 0x07, 0x49, 0xE070, EXTENDED),
            new Cusbps2key("Home", 0x07, 0x4A, 0xE06C, EXTENDED),
            new Cusbps2key("Page Up", 0x07, 0x4B, 0xE07D, EXTENDED),
            new Cusbps2key("Delete", 0x07, 0x4C, 0xE071, EXTENDED),
            new Cusbps2key("End", 0x07, 0x4D, 0xE069, EXTENDED),
            new Cusbps2key("Page Down", 0x07, 0x4E, 0xE07A, EXTENDED),
            new Cusbps2key("Right Arrow", 0x07, 0x4F, 0xE074, EXTENDED),
            new Cusbps2key("Left Arrow", 0x07, 0x50, 0xE06B, EXTENDED),
            new Cusbps2key("Down Arrow", 0x07, 0x51, 0xE072, EXTENDED),
            new Cusbps2key("Up Arrow", 0x07, 0x52, 0xE075, EXTENDED),
            new Cusbps2key("Keypad /", 0x07, 0x54, 0xE04A, EXTENDED),
            new Cusbps2key("Keypad *", 0x07, 0x55, 0xE07C, EXTENDED),
            new Cusbps2key("Keypad -", 0x07, 0x56, 0xE07B, EXTENDED),
            
            new Cusbps2key("Pause", 0x07, 0x48, 0x1000, NORMAL),
            new Cusbps2key("Num Lock", 0x07, 0x53, 0x77, NORMAL),
	        new Cusbps2key("Keypad +", 0x07, 0x57, 0x79, NORMAL),
        	
            new Cusbps2key("Keypad Enter", 0x07, 0x58, 0xE05A, EXTENDED),
        	
            new Cusbps2key("Keypad 1", 0x07, 0x59, 0x69, NORMAL),
	        new Cusbps2key("Keypad 2", 0x07, 0x5A, 0x72, NORMAL),
            new Cusbps2key("Keypad 3", 0x07, 0x5B, 0x7A, NORMAL),
            new Cusbps2key("Keypad 4", 0x07, 0x5C, 0x79, NORMAL),
            new Cusbps2key("Keypad 5", 0x07, 0x5D, 0x73, NORMAL),
            new Cusbps2key("Keypad 6", 0x07, 0x5E, 0x74, NORMAL),
            new Cusbps2key("Keypad 7", 0x07, 0x5F, 0x6C, NORMAL),
            new Cusbps2key("Keypad 8", 0x07, 0x60, 0x75, NORMAL),
            new Cusbps2key("Keypad 9", 0x07, 0x61, 0x7D, NORMAL),
            new Cusbps2key("Keypad 0", 0x07, 0x62, 0x70, NORMAL),
            new Cusbps2key("Keypad .", 0x07, 0x63, 0x71, NORMAL),
            new Cusbps2key("Europe 2", 0x07, 0x64, 0x61, NORMAL),
        	
            new Cusbps2key("App", 0x07, 0x65, 0xE02F, EXTENDED),
	        new Cusbps2key("Keyboard Power", 0x07, 0x66, 0xE037, EXTENDED),

            new Cusbps2key("Keypad =", 0x07, 0x67, 0x0F, NORMAL),
            new Cusbps2key("F13", 0x07, 0x68, 0xD000, VKEY),
            new Cusbps2key("F14", 0x07, 0x69, 0xD000, VKEY),
            new Cusbps2key("F15", 0x07, 0x6A, 0xD000, VKEY),
            new Cusbps2key("F16", 0x07, 0x6B, 0xD000, VKEY),
            new Cusbps2key("F17", 0x07, 0x6C, 0xD000, VKEY),
            new Cusbps2key("F18", 0x07, 0x6D, 0xD000, VKEY),
            new Cusbps2key("F19", 0x07, 0x6E, 0xD000, VKEY),
            new Cusbps2key("F20", 0x07, 0x6F, 0xD000, VKEY),
            new Cusbps2key("F21", 0x07, 0x70, 0xD000, VKEY),
            new Cusbps2key("F22", 0x07, 0x71, 0xD000, VKEY),
            new Cusbps2key("F23", 0x07, 0x72, 0xD000, VKEY),
            new Cusbps2key("F24", 0x07, 0x73, 0xD000, VKEY),
        	
            new Cusbps2key("Keyboard Execute", 0x07, 0x74, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Help", 0x07, 0x75, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Menu", 0x07, 0x76, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Select", 0x07, 0x77, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Stop", 0x07, 0x78, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Again", 0x07, 0x79, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Undo", 0x07, 0x7A, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Cut", 0x07, 0x7B, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Copy", 0x07, 0x7C, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Paste", 0x07, 0x7D, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Find", 0x07, 0x7E, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Mute", 0x07, 0x7F, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Volume Up", 0x07, 0x80, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Volume Down", 0x07, 0x81, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Locking Caps Lock", 0x07, 0x82, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Locking Num Lock", 0x07, 0x83, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Locking Scroll Lock", 0x07, 0x84, 0xc000, NORMAL),
            new Cusbps2key("Keypad ,", 0x07, 0x85, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Equal Sign", 0x07, 0x86, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 1", 0x07, 0x87, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 2", 0x07, 0x88, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 3", 0x07, 0x89, 0xc000, NORMAL),
            new Cusbps2key("Action" /*"Keyboard Int�l 4"*/, 0x07, 0x8A, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 5", 0x07, 0x8B, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 6", 0x07, 0x8C, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 7", 0x07, 0x8D, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 8", 0x07, 0x8E, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Int�l 9", 0x07, 0x8F, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 1", 0x07, 0x90, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 2", 0x07, 0x91, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 3", 0x07, 0x92, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 4", 0x07, 0x93, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 5", 0x07, 0x94, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 6", 0x07, 0x95, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 7", 0x07, 0x96, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 8", 0x07, 0x97, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Lang 9", 0x07, 0x98, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Alternate Erase", 0x07, 0x99, 0xc000, NORMAL),
            new Cusbps2key("Keyboard SysReq/Attention", 0x07, 0x9A, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Cancel", 0x07, 0x9B, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Clear", 0x07, 0x9C, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Prior", 0x07, 0x9D, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Return", 0x07, 0x9E, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Separator", 0x07, 0x9F, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Out", 0x07, 0xA0, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Oper", 0x07, 0xA1, 0xc000, NORMAL),
            new Cusbps2key("Keyboard Clear/Again", 0x07, 0xA2, 0xc000, NORMAL),
            new Cusbps2key("Keyboard CrSel/Props", 0x07, 0xA3, 0xc000, NORMAL),
            new Cusbps2key("Keyboard ExSel", 0x07, 0xA4, 0xc000, NORMAL),
            new Cusbps2key("RESERVED", 0x07, 0xA5, 0xb000, NORMAL),
            //
            new Cusbps2key("RESERVED", 0x07, 0xDF, 0xb000, NORMAL),
            new Cusbps2key("Left Control", 0x07, 0xE0, 0x14, NORMAL),
            new Cusbps2key("Left Shift", 0x07, 0xE1, 0x12, NORMAL),
            new Cusbps2key("Left Alt", 0x07, 0xE2, 0x11, NORMAL),
        	
            new Cusbps2key("Left GUI", 0x07, 0xE3, 0xE01F, EXTENDED),
            new Cusbps2key("Right Control", 0x07, 0xE4, 0xE014, EXTENDED),
            
	        new Cusbps2key("Right Shift", 0x07, 0xE5, 0x59, NORMAL),
        	
            new Cusbps2key("Right Alt", 0x07, 0xE6, 0xE011, EXTENDED),
            new Cusbps2key("Right GUI(OK)", 0x07, 0xE7, 0xE027, EXTENDED), //also known as (OK)

            new Cusbps2key("Aqua Plane", 0x07, 0x8B, 0xE002, EXTENDED),  //not verified
            new Cusbps2key("Green Plane", 0x07, 0xB6, 0xE002, EXTENDED), //not verified
            new Cusbps2key("Orange Plane", 0x07, 0xE9, 0xE001, EXTENDED),//not verified
        	
            new Cusbps2key("RESERVED", 0x07, 0xE8, 0xb000, NORMAL),
	        new Cusbps2key("RESERVED", 0x07, 0xc000, 0xb000, NORMAL),
	        new Cusbps2key(null, 0x00, 0x00, 0x00, NORMAL) //last marker
        };
#endregion
    }
}