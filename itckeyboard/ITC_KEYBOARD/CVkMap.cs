using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ITC_KEYBOARD
{
    /// <summary>
    /// a struct to hold hardware key values (USB scancodes) and there names as strings
    /// or hardware direct key indexes and the name of the hardware key
    /// </summary>
    public struct vkPair
    {
        /// <summary>
        /// iVal is the USB HID hardware scancode
        /// </summary>
        public int iVal;
        /// <summary>
        /// sKey is a string describing the USB HID hardware key
        /// </summary>
        public string sKey;

        /// <summary>
        /// constructor for new vkPair
        /// </summary>
        /// <param name="i">key value</param>
        /// <param name="s">string name</param>
        public vkPair(byte i, string s)
        {
            this.iVal = i;
            this.sKey = s;
        }
        /// <summary>
        /// get string name of key
        /// </summary>
        /// <returns>a key name</returns>
        public override string ToString()
        {
            return this.sKey;
        }
        /// <summary>
        /// find the name of a key
        /// </summary>
        /// <param name="b">value of key</param>
        /// <param name="vkPairs">the vkPairs list to search</param>
        /// <returns>the string name of the found key</returns>
        public string ToString(byte b, vkPair[] vkPairs)
        {
            //find name for key value
            foreach (vkPair vkPar in vkPairs)
            {
                if (vkPar.iVal == b)
                    return vkPar.sKey;
            }
            return "undef";
        }

    }

    /// <summary>
    /// provide access to VKEY values, strings and enumerations
    /// </summary>
    public class CvkMap
    {
        /// <summary>
        /// byte value of the key
        /// </summary>
        public byte b;
        /// <summary>
        /// the name of the key
        /// </summary>
        public string s;
        /// <summary>
        /// construct a new vkMap
        /// </summary>
        /// <param name="b">value of key</param>
        /// <param name="s">name of key</param>
        public CvkMap(byte b, string s)
        {
            this.b = b;
            this.s = s;
        }
        /// <summary>
        /// get the name of the key
        /// </summary>
        /// <returns>a string with the name</returns>
        public override string ToString()
        {
            return this.s;// base.ToString();
        }
        /// <summary>
        /// get the value of the key
        /// </summary>
        /// <returns>the value of the key</returns>
        public int getByte()
        {
            return this.b;
        }
        /// <summary>
        /// get the name of a key
        /// </summary>
        /// <param name="b">key value of the key</param>
        /// <returns>a string with the name of the key</returns>
        public static string getName(byte b)
        {
            for (int i = 0; i < vkValues.Length; i++)
            {
                if (vkValues[i].b == b)
                    return vkValues[i].s;
            }
            return "n/a";
        }
        /// <summary>
        /// a list of VKEY values and there string names
        /// </summary>
        /*!< F1 is equal to SoftKey1 on SmartPhone (see winuserm.h)!*/
        /*!< F2 is equal to SoftKey2 on SmartPhone (see winuserm.h)!*/
        /*!< F3 is equal to the Phone key (green key, start phone call) on SmartPhone (see winuserm.h)!*/
        /*!< F4 is equal to Phone End key (red key, hangup) on SmartPhone (see winuserm.h)!*/
        /*!< F5 is equal to Volume Down key on SmartPhone (see winuserm.h)!*/
        /*!< F6 is equal to Volume Up key on SmartPhone (see winuserm.h)!*/	
        public static CvkMap[] vkValues = {
                new CvkMap ( 0x00, "VK_NOTDEF"), 
                new CvkMap ( 0x01, "VK_LBUTTON" ),
                new CvkMap ( 0x02,"VK_RBUTTON" ),
                new CvkMap ( 0x03,"VK_CANCEL" ),
                new CvkMap ( 0x04,"VK_MBUTTON" ),
                new CvkMap ( 0x05,"undef 0x05" ),
                new CvkMap ( 0x06,"undef 0x06" ),
                new CvkMap ( 0x07,"undef 0x07" ),
                new CvkMap ( 0x08,"VK_BACK" ),
                new CvkMap ( 0x09,"VK_TAB" ),
                new CvkMap ( 0x0A,"undef 0x0A" ),
                new CvkMap ( 0x0B,"undef 0x0B" ),
                new CvkMap ( 0x0C,"VK_CLEAR" ),
                new CvkMap ( 0x0D,"VK_RETURN" ),
                new CvkMap ( 0x0E,"undef 0x0E" ),
                new CvkMap ( 0x0F,"undef 0x0F" ),
                new CvkMap ( 0x10,"VK_SHIFT" ),
                new CvkMap ( 0x11,"VK_CONTROL" ),
                new CvkMap ( 0x12,"VK_MENU" ),
                new CvkMap ( 0x13,"VK_PAUSE" ),
                new CvkMap ( 0x14,"VK_CAPITAL" ),
                new CvkMap ( 0x15,"VK_HANGUL" ),
                new CvkMap ( 0x16,"undef 0x16" ),
                new CvkMap ( 0x17,"VK_JUNJA" ),
                new CvkMap ( 0x18,"VK_FINAL" ),
                new CvkMap ( 0x19,"VK_KANJI" ),
                new CvkMap ( 0x1A,"undef 0x1A" ),
                new CvkMap ( 0x1B,"VK_ESCAPE" ),
                new CvkMap ( 0x1C,"VK_CONVERT" ),
                new CvkMap ( 0x1D,"VK_NOCONVERT" ),
                new CvkMap ( 0x1E,"undef 0x1E" ),
                new CvkMap ( 0x1F,"undef 0x1F" ),
                new CvkMap ( 0x20,"VK_SPACE" ),
                new CvkMap ( 0x21,"VK_PRIOR" ),
                new CvkMap ( 0x22,"VK_NEXT" ),
                new CvkMap ( 0x23,"VK_END" ),
                new CvkMap ( 0x24,"VK_HOME" ),
                new CvkMap ( 0x25,"VK_LEFT" ),
                new CvkMap ( 0x26,"VK_UP" ),
                new CvkMap ( 0x27,"VK_RIGHT" ),
                new CvkMap ( 0x28,"VK_DOWN" ),
                new CvkMap ( 0x29,"VK_SELECT" ),
                new CvkMap ( 0x2A,"VK_PRINT" ),
                new CvkMap ( 0x2B,"VK_EXECUTE" ),
                new CvkMap ( 0x2C,"VK_SNAPSHOT" ),
                new CvkMap ( 0x2D,"VK_INSERT" ),
                new CvkMap ( 0x2E,"VK_DELETE" ),
                new CvkMap ( 0x2F,"VK_HELP" ),
                new CvkMap ( 0x30,"VK_0" ),
                new CvkMap ( 0x31,"VK_1" ),
                new CvkMap ( 0x32,"VK_2" ),
                new CvkMap ( 0x33,"VK_3" ),
                new CvkMap ( 0x34,"VK_4" ),
                new CvkMap ( 0x35,"VK_5" ),
                new CvkMap ( 0x36,"VK_6" ),
                new CvkMap ( 0x37,"VK_7" ),
                new CvkMap ( 0x38,"VK_8" ),
                new CvkMap ( 0x39,"VK_9" ),
                new CvkMap ( 0x3A,"undef 0x3A" ),
                new CvkMap ( 0x3B,"undef 0x3B" ),
                new CvkMap ( 0x3C,"undef 0x3C" ),
                new CvkMap ( 0x3D,"undef 0x3D" ),
                new CvkMap ( 0x3E,"undef 0x3E" ),
                new CvkMap ( 0x3F,"undef 0x3F" ),
                new CvkMap ( 0x40,"undef 0x40" ),
                new CvkMap ( 0x41,"VK_A" ),
                new CvkMap ( 0x42,"VK_B" ),
                new CvkMap ( 0x43,"VK_C" ),
                new CvkMap ( 0x44,"VK_D" ),
                new CvkMap ( 0x45,"VK_E" ),
                new CvkMap ( 0x46,"VK_F" ),
                new CvkMap ( 0x47,"VK_G" ),
                new CvkMap ( 0x48,"VK_H" ),
                new CvkMap ( 0x49,"VK_I" ),
                new CvkMap ( 0x4A,"VK_J" ),
                new CvkMap ( 0x4B,"VK_K" ),
                new CvkMap ( 0x4C,"VK_L" ),
                new CvkMap ( 0x4D,"VK_M" ),
                new CvkMap ( 0x4E,"VK_N" ),
                new CvkMap ( 0x4F,"VK_O" ),
                new CvkMap ( 0x50,"VK_P" ),
                new CvkMap ( 0x51,"VK_Q" ),
                new CvkMap ( 0x52,"VK_R" ),
                new CvkMap ( 0x53,"VK_S" ),
                new CvkMap ( 0x54,"VK_T" ),
                new CvkMap ( 0x55,"VK_U" ),
                new CvkMap ( 0x56,"VK_V" ),
                new CvkMap ( 0x57,"VK_W" ),
                new CvkMap ( 0x58,"VK_X" ),
                new CvkMap ( 0x59,"VK_Y" ),
                new CvkMap ( 0x5A,"VK_Z" ),
                new CvkMap ( 0x5B,"VK_LWIN" ),
                new CvkMap ( 0x5C,"VK_RWIN" ),
                new CvkMap ( 0x5D,"VK_APPS" ),
                new CvkMap ( 0x5E,"undef 0x5E" ),
                new CvkMap ( 0x5F,"VK_SLEEP" ),
                new CvkMap ( 0x60,"VK_NUMPAD0" ),
                new CvkMap ( 0x61,"VK_NUMPAD1" ),
                new CvkMap ( 0x62,"VK_NUMPAD2" ),
                new CvkMap ( 0x63,"VK_NUMPAD3" ),
                new CvkMap ( 0x64,"VK_NUMPAD4" ),
                new CvkMap ( 0x65,"VK_NUMPAD5" ),
                new CvkMap ( 0x66,"VK_NUMPAD6" ),
                new CvkMap ( 0x67,"VK_NUMPAD7" ),
                new CvkMap ( 0x68,"VK_NUMPAD8" ),
                new CvkMap ( 0x69,"VK_NUMPAD9" ),
                new CvkMap ( 0x6A,"VK_MULTIPLY" ),
                new CvkMap ( 0x6B,"VK_ADD" ),
                new CvkMap ( 0x6C,"VK_SEPARATOR" ),
                new CvkMap ( 0x6D,"VK_SUBTRACT" ),
                new CvkMap ( 0x6E,"VK_DECIMAL" ),
                new CvkMap ( 0x6F,"VK_DIVIDE" ),
                new CvkMap ( 0x70,"VK_F1" ),
                new CvkMap ( 0x71,"VK_F2" ),
                new CvkMap ( 0x72,"VK_F3" ),
                new CvkMap ( 0x73,"VK_F4" ),
                new CvkMap ( 0x74,"VK_F5" ),
                new CvkMap ( 0x75,"VK_F6" ),
                new CvkMap ( 0x76,"VK_F7" ),
                new CvkMap ( 0x77,"VK_F8" ),
                new CvkMap ( 0x78,"VK_F9" ),
                new CvkMap ( 0x79,"VK_F10" ),
                new CvkMap ( 0x7A,"VK_F11" ),
                new CvkMap ( 0x7B,"VK_F12" ),
                new CvkMap ( 0x7C,"VK_F13" ),
                new CvkMap ( 0x7D,"VK_F14" ),
                new CvkMap ( 0x7E,"VK_F15" ),
                new CvkMap ( 0x7F,"VK_F16" ),
                new CvkMap ( 0x80,"VK_F17" ),
                new CvkMap ( 0x81,"VK_F18" ),
                new CvkMap ( 0x82,"VK_F19" ),
                new CvkMap ( 0x83,"VK_F20" ),
                new CvkMap ( 0x84,"VK_F21" ),
                new CvkMap ( 0x85,"VK_F22" ),
                new CvkMap ( 0x86,"VK_F23" ),
                new CvkMap ( 0x87,"VK_F24" ),
                new CvkMap ( 0x88,"undef 0x88" ),
                new CvkMap ( 0x89,"undef 0x89" ),
                new CvkMap ( 0x8A,"undef 0x8A" ),
                new CvkMap ( 0x8B,"undef 0x8B" ),
                new CvkMap ( 0x8C,"undef 0x8C" ),
                new CvkMap ( 0x8D,"undef 0x8D" ),
                new CvkMap ( 0x8E,"undef 0x8E" ),
                new CvkMap ( 0x8F,"undef 0x8F" ),
                new CvkMap ( 0x90,"VK_NUMLOCK" ),
                new CvkMap ( 0x91,"VK_SCROLL" ),
                new CvkMap ( 0x92,"undef 0x92" ),
                new CvkMap ( 0x93,"undef 0x93" ),
                new CvkMap ( 0x94,"undef 0x94" ),
                new CvkMap ( 0x95,"undef 0x95" ),
                new CvkMap ( 0x96,"undef 0x96" ),
                new CvkMap ( 0x97,"undef 0x97" ),
                new CvkMap ( 0x98,"undef 0x98" ),
                new CvkMap ( 0x99,"undef 0x99" ),
                new CvkMap ( 0x9A,"undef 0x9A" ),
                new CvkMap ( 0x9B,"undef 0x9B" ),
                new CvkMap ( 0x9C,"undef 0x9C" ),
                new CvkMap ( 0x9D,"undef 0x9D" ),
                new CvkMap ( 0x9E,"undef 0x9E" ),
                new CvkMap ( 0x9F,"undef 0x9F" ),
                new CvkMap ( 0xA0,"VK_LSHIFT" ),
                new CvkMap ( 0xA1,"VK_RSHIFT" ),
                new CvkMap ( 0xA2,"VK_LCONTROL" ),
                new CvkMap ( 0xA3,"VK_RCONTROL" ),
                new CvkMap ( 0xA4,"VK_LMENU" ),
                new CvkMap ( 0xA5,"VK_RMENU" ),
                new CvkMap ( 0xA6,"VK_BROWSER_BACK" ),
                new CvkMap ( 0xA7,"VK_BROWSER_FORWARD" ),
                new CvkMap ( 0xA8,"VK_BROWSER_REFRESH" ),
                new CvkMap ( 0xA9,"VK_BROWSER_STOP" ),
                new CvkMap ( 0xAA,"VK_BROWSER_SEARCH" ),
                new CvkMap ( 0xAB,"VK_BROWSER_FAVORITES" ),
                new CvkMap ( 0xAC,"VK_BROWSER_HOME" ),
                new CvkMap ( 0xAD,"VK_VOLUME_MUTE" ),
                new CvkMap ( 0xAE,"VK_VOLUME_DOWN" ),
                new CvkMap ( 0xAF,"VK_VOLUME_UP" ),
                new CvkMap ( 0xB0,"VK_MEDIA_NEXT_TRACK" ),
                new CvkMap ( 0xB1,"VK_MEDIA_PREV_TRACK" ),
                new CvkMap ( 0xB2,"VK_MEDIA_STOP" ),
                new CvkMap ( 0xB3,"VK_MEDIA_PLAY_PAUSE" ),
                new CvkMap ( 0xB4,"VK_LAUNCH_MAIL" ),
                new CvkMap ( 0xB5,"VK_LAUNCH_MEDIA_SELECT" ),
                new CvkMap ( 0xB6,"VK_LAUNCH_APP1" ),
                new CvkMap ( 0xB7,"VK_LAUNCH_APP2" ),
                new CvkMap ( 0xB8,"undef 0xB8" ),
                new CvkMap ( 0xB9,"undef 0xB9" ),
                new CvkMap ( 0xBA,"VK_SEMICOLON" ),
                new CvkMap ( 0xBB,"VK_EQUAL" ),
                new CvkMap ( 0xBC,"VK_COMMA" ),
                new CvkMap ( 0xBD,"VK_HYPHEN" ),
                new CvkMap ( 0xBE,"VK_PERIOD" ),
                new CvkMap ( 0xBF,"VK_SLASH" ),
                new CvkMap ( 0xC0,"VK_BACKQUOTE" ),
                new CvkMap ( 0xC1,"VK_APP1" ),
                new CvkMap ( 0xC2,"VK_APP2" ),
                new CvkMap ( 0xC3,"VK_APP3" ),
                new CvkMap ( 0xC4,"VK_APP4" ),
                new CvkMap ( 0xC5,"VK_APP5" ),
                new CvkMap ( 0xC6,"VK_APP6" ),
                new CvkMap ( 0xC7,"undef 0xC7" ),
                new CvkMap ( 0xC8,"undef 0xC8" ),
                new CvkMap ( 0xC9,"undef 0xC9" ),
                new CvkMap ( 0xC0,"undef 0xC0" ),
                new CvkMap ( 0xCA,"undef 0xCA" ),
                new CvkMap ( 0xCB,"undef 0xCB" ),
                new CvkMap ( 0xCC,"undef 0xCC" ),
                new CvkMap ( 0xCD,"undef 0xCD" ),
                new CvkMap ( 0xCE,"undef 0xCE" ),
                new CvkMap ( 0xCF,"undef 0xCF" ),
                new CvkMap ( 0xD0,"undef 0xD0" ),
                new CvkMap ( 0xD1,"undef 0xD1" ),
                new CvkMap ( 0xD2,"undef 0xD2" ),
                new CvkMap ( 0xD3,"undef 0xD3" ),
                new CvkMap ( 0xD4,"undef 0xD4" ),
                new CvkMap ( 0xD5,"undef 0xD5" ),
                new CvkMap ( 0xD6,"undef 0xD6" ),
                new CvkMap ( 0xD7,"undef 0xD7" ),
                new CvkMap ( 0xD8,"undef 0xD8" ),
                new CvkMap ( 0xD9,"undef 0xD9" ),
                new CvkMap ( 0xDA,"undef 0xDA" ),
                new CvkMap ( 0xDB,"VK_LBRACKET" ),
                new CvkMap ( 0xDC,"VK_BACKSLASH" ),
                new CvkMap ( 0xDD,"VK_RBRACKET" ),
                new CvkMap ( 0xDE,"VK_APOSTROPHE" ),
                new CvkMap ( 0xDF,"VK_OFF" ),
                new CvkMap ( 0xE0,"undef 0xE0" ),
                new CvkMap ( 0xE1,"undef 0xE1" ),
                new CvkMap ( 0xE2,"VK_EXTEND_BSLASH" ),
                new CvkMap ( 0xE3,"undef 0xE3" ),
                new CvkMap ( 0xE4,"undef 0xE4" ),
                new CvkMap ( 0xE5,"VK_PROCESSKEY" ),
                new CvkMap ( 0xE6,"undef 0xE6" ),
                new CvkMap ( 0xE7,"undef 0xE7" ),
                new CvkMap ( 0xE8,"undef 0xE8" ),
                new CvkMap ( 0xE9,"undef 0xE9" ),
                new CvkMap ( 0xEA,"undef 0xEA" ),
                new CvkMap ( 0xEB,"undef 0xEB" ),
                new CvkMap ( 0xEC,"undef 0xEC" ),
                new CvkMap ( 0xED,"undef 0xED" ),
                new CvkMap ( 0xEE,"undef 0xEE" ),
                new CvkMap ( 0xEF,"undef 0xEF" ),
                new CvkMap ( 0xF0,"undef 0xF0" ),
                new CvkMap ( 0xF1,"undef 0xF1" ),
                new CvkMap ( 0xF2,"undef 0xF2" ),
                new CvkMap ( 0xF3,"undef 0xF3" ),
                new CvkMap ( 0xF4,"undef 0xF4" ),
                new CvkMap ( 0xF5,"undef 0xF5" ),
                new CvkMap ( 0xF6,"VK_ATTN" ),
                new CvkMap ( 0xF7,"VK_CRSEL" ),
                new CvkMap ( 0xF8,"VK_EXSEL" ),
                new CvkMap ( 0xF9,"VK_EREOF" ),
                new CvkMap ( 0xFA,"VK_PLAY" ),
                new CvkMap ( 0xFB,"VK_ZOOM" ),
                new CvkMap ( 0xFC,"VK_NONAME" ),
                new CvkMap ( 0xFD,"VK_PA1" ),
                new CvkMap ( 0xFE,"VK_OEM_CLEAR" ),
                new CvkMap ( 0xFF,"VK_undef" ),
        };
    }
    /// <summary>
    /// a list of known VKEY values as enumeration
    /// </summary>
        public enum VKEY : byte
        {
            VK_NOTDEF,
            VK_LBUTTON,
            VK_RBUTTON,
            VK_CANCEL,
            VK_MBUTTON,
            undef_0x05,
            undef_0x06,
            undef_0x07,
            VK_BACK,
            VK_TAB,
            undef_0x0A,
            undef_0x0B,
            VK_CLEAR,
            VK_RETURN,
            undef_0x0E,
            undef_0x0F,
            VK_SHIFT,
            VK_CONTROL,
            VK_MENU,
            VK_PAUSE,
            VK_CAPITAL,
            VK_HANGUL,
            undef_0x16,
            VK_JUNJA,
            VK_FINAL,
            VK_KANJI,
            undef_0x1A,
            VK_ESCAPE,
            VK_CONVERT,
            VK_NOCONVERT,
            undef_0x1E,
            undef_0x1F,
            VK_SPACE,
            VK_PRIOR,
            VK_NEXT,
            VK_END,
            VK_HOME,
            VK_LEFT,
            VK_UP,
            VK_RIGHT,
            VK_DOWN,
            VK_SELECT,
            VK_PRINT,
            VK_EXECUTE,
            VK_SNAPSHOT,
            VK_INSERT,
            VK_DELETE,
            VK_HELP,
            VK_0,
            VK_1,
            VK_2,
            VK_3,
            VK_4,
            VK_5,
            VK_6,
            VK_7,
            VK_8,
            VK_9,
            undef_0x3A,
            undef_0x3B,
            undef_0x3C,
            undef_0x3D,
            undef_0x3E,
            undef_0x3F,
            undef_0x40,
            VK_A,
            VK_B,
            VK_C,
            VK_D,
            VK_E,
            VK_F,
            VK_G,
            VK_H,
            VK_I,
            VK_J,
            VK_K,
            VK_L,
            VK_M,
            VK_N,
            VK_O,
            VK_P,
            VK_Q,
            VK_R,
            VK_S,
            VK_T,
            VK_U,
            VK_V,
            VK_W,
            VK_X,
            VK_Y,
            VK_Z,
            VK_LWIN,
            VK_RWIN,
            VK_APPS,
            undef_0x5E,
            VK_SLEEP,
            VK_NUMPAD0,
            VK_NUMPAD1,
            VK_NUMPAD2,
            VK_NUMPAD3,
            VK_NUMPAD4,
            VK_NUMPAD5,
            VK_NUMPAD6,
            VK_NUMPAD7,
            VK_NUMPAD8,
            VK_NUMPAD9,
            VK_MULTIPLY,
            VK_ADD,
            VK_SEPARATOR,
            VK_SUBTRACT,
            VK_DECIMAL,
            VK_DIVIDE,
            VK_F1,
            VK_F2,
            VK_F3,
            VK_F4,
            VK_F5,
            VK_F6,
            VK_F7,
            VK_F8,
            VK_F9,
            VK_F10,
            VK_F11,
            VK_F12,
            VK_F13,
            VK_F14,
            VK_F15,
            VK_F16,
            VK_F17,
            VK_F18,
            VK_F19,
            VK_F20,
            VK_F21,
            VK_F22,
            VK_F23,
            VK_F24,
            undef_0x88,
            undef_0x89,
            undef_0x8A,
            undef_0x8B,
            undef_0x8C,
            undef_0x8D,
            undef_0x8E,
            undef_0x8F,
            VK_NUMLOCK,
            VK_SCROLL,
            undef_0x92,
            undef_0x93,
            undef_0x94,
            undef_0x95,
            undef_0x96,
            undef_0x97,
            undef_0x98,
            undef_0x99,
            undef_0x9A,
            undef_0x9B,
            undef_0x9C,
            undef_0x9D,
            undef_0x9E,
            undef_0x9F,
            VK_LSHIFT,
            VK_RSHIFT,
            VK_LCONTROL,
            VK_RCONTROL,
            VK_LMENU,
            VK_RMENU,
            VK_BROWSER_BACK,
            VK_BROWSER_FORWARD,
            VK_BROWSER_REFRESH,
            VK_BROWSER_STOP,
            VK_BROWSER_SEARCH,
            VK_BROWSER_FAVORITES,
            VK_BROWSER_HOME,
            VK_VOLUME_MUTE,
            VK_VOLUME_DOWN,
            VK_VOLUME_UP,
            VK_MEDIA_NEXT_TRACK,
            VK_MEDIA_PREV_TRACK,
            VK_MEDIA_STOP,
            VK_MEDIA_PLAY_PAUSE,
            VK_LAUNCH_MAIL,
            VK_LAUNCH_MEDIA_SELECT,
            VK_LAUNCH_APP1,
            VK_LAUNCH_APP2,
            undef_0xB8,
            undef_0xB9,
            VK_SEMICOLON,
            VK_EQUAL,
            VK_COMMA,
            VK_HYPHEN,
            VK_PERIOD,
            VK_SLASH,
            VK_BACKQUOTE,
            VK_APP1,
            VK_APP2,
            VK_APP3,
            VK_APP4,
            VK_APP5,
            VK_APP6,
            undef_0xC7,
            undef_0xC8,
            undef_0xC9,
            undef_0xCA,
            undef_0xCB,
            undef_0xCC,
            undef_0xCD,
            undef_0xCE,
            undef_0xCF,
            undef_0xD0,
            undef_0xD1,
            undef_0xD2,
            undef_0xD3,
            undef_0xD4,
            undef_0xD5,
            undef_0xD6,
            undef_0xD7,
            undef_0xD8,
            undef_0xD9,
            undef_0xDA,
            VK_LBRACKET,
            VK_BACKSLASH,
            VK_RBRACKET,
            VK_APOSTROPHE,
            VK_OFF,
            undef_0xE0,
            undef_0xE1,
            VK_EXTEND_BSLASH,
            undef_0xE3,
            undef_0xE4,
            VK_PROCESSKEY,
            undef_0xE6,
            undef_0xE7,
            undef_0xE8,
            undef_0xE9,
            undef_0xEA,
            undef_0xEB,
            undef_0xEC,
            undef_0xED,
            undef_0xEE,
            undef_0xEF,
            undef_0xF0,
            undef_0xF1,
            undef_0xF2,
            undef_0xF3,
            undef_0xF4,
            undef_0xF5,
            VK_ATTN,
            VK_CRSEL,
            VK_EXSEL,
            VK_EREOF,
            VK_PLAY,
            VK_ZOOM,
            VK_NONAME,
            VK_PA1,
            VK_OEM_CLEAR,
            VK_undef_0xff
        }
}
