using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using EventNamespace;

namespace ITC_KEYBOARD
{
    public partial class CUsbHwKeys
    {
        private static class ck70Keys
        {
            public static vkPair[] vkPairs = new vkPair[]{
                new vkPair ( 0x04, "a" ), //"VK_A"
                new vkPair ( 0x05, "b" ), //"VK_B"
                new vkPair ( 0x06, "c" ), //"VK_C"
                new vkPair ( 0x07, "d" ), //"VK_D"
                new vkPair ( 0x08, "e" ), //"VK_E"
                new vkPair ( 0x09, "f" ), //"VK_F"
                new vkPair ( 0x0A, "g" ), //"VK_G"
                new vkPair ( 0x0B, "h" ), //"VK_H"
                new vkPair ( 0x0C, "i" ), //"VK_I"
                new vkPair ( 0x0D, "j" ), //"VK_J"
                new vkPair ( 0x0E, "k" ), //"VK_K"
                new vkPair ( 0x0F, "l" ), //"VK_L"
                new vkPair ( 0x10, "m" ), //"VK_M"
                new vkPair ( 0x11, "n" ), //"VK_N"
                new vkPair ( 0x12, "o" ), //"VK_O"
                new vkPair ( 0x13, "p" ), //"VK_P"
                new vkPair ( 0x14, "q" ), //"VK_Q"
                new vkPair ( 0x15, "r" ), //"VK_R"
                new vkPair ( 0x16, "s" ), //"VK_S"
                new vkPair ( 0x17, "t" ), //"VK_T"
                new vkPair ( 0x18, "u" ), //"VK_U"
                new vkPair ( 0x19, "v" ), //"VK_V"
                new vkPair ( 0x1A, "w" ), //"VK_W"
                new vkPair ( 0x1B, "x" ), //"VK_X"
                new vkPair ( 0x1C, "y" ), //"VK_Y"
                new vkPair ( 0x1D, "z" ), //"VK_Z"
                new vkPair ( 0x1E, "1" ),
                new vkPair ( 0x1F, "2" ),
                new vkPair ( 0x20, "3" ),
                new vkPair ( 0x21, "4" ),
                new vkPair ( 0x22, "5" ),
                new vkPair ( 0x23, "6" ),
                new vkPair ( 0x24, "7" ),
                new vkPair ( 0x25, "8" ),
                new vkPair ( 0x26, "9" ),
                new vkPair ( 0x27, "0" ),
                new vkPair ( 0x28, "Enter" ), //"VK_RETURN"
                new vkPair ( 0x29, "ESC" ),
                new vkPair ( 0x29, "Escape" ), //"VK_ESCAPE"
                new vkPair ( 0x2A, "Backspace" ), //"VK_BACK"
                new vkPair ( 0x2B, "Tab" ), //"VK_TAB"
                new vkPair ( 0x2C, "Space" ), //"VK_SPACE"
                new vkPair ( 0x37, "." ),
                /*
                 * Normally, USB HID values are used, but the CK71 uses different values for function keys !!!!!
                 * 
                    07,EC,00,00,00,04 'n/a' [NoFlag,NoFlag,NormalKey,] 'F3'
                    07,ED,00,00,00,0C 'n/a' [NoFlag,NoFlag,NormalKey,] 'F4'
                    07,EE,00,00,00,03 'n/a' [NoFlag,NoFlag,NormalKey,] 'F5'
                    07,3F,00,02,00,0B 'F6' [NoFlag,NoRepeat,NormalKey,] 'F6'
                    07,40,00,02,00,83 'F7' [NoFlag,NoRepeat,NormalKey,] 'F7'
                    07,EA,00,00,00,05 'n/a' [NoFlag,NoFlag,NormalKey,] 'F1'
                    07,EB,00,00,00,06 'n/a' [NoFlag,NoFlag,NormalKey,] 'F2'
                    07,43,00,0A,10,C1 'F10' [NoFlag,NoRepeat, VKEY,AppLaunchKey,] 'VK_APP1' 'AppLaunch'
                    07,91,00,02,02,01 'Keyboard Lang 2' [NoFlag,NoRepeat,NamedEventIndex,] 'F9' 'EventIndex'|'StateLeftScan'|'DeltaLeftScan
                    07,90,00,02,02,01 'Keyboard Lang 1 (<SCAN>)' [NoFlag,NoRepeat,NamedEventIndex,] 'F9' 'EventIndex'|'StateLeftScan'|'DeltaLeftScan
                    0C,E9,00,02,01,01 'Orange Plane' [NoFlag,NoRepeat,ShiftKeyIndex,] 'F9' 'ShiftIndex'->01,02,24,01 'F9' | 
                    07,8B,00,02,01,02 'Aqua Plane' [NoFlag,NoRepeat,ShiftKeyIndex,] 'n/a' 'ShiftIndex'->01,02,44,02 'n/a' | 
                */
                new vkPair ( 0xEA, "F1 (Soft1)" ), //"VK_F1"
                new vkPair ( 0xEB, "F2 (Soft2)" ), //"VK_F2"
                new vkPair ( 0xEC, "F3 (Send)" ), //"VK_F3"
                new vkPair ( 0xED, "F4 (Send)" ), //"VK_F4"
                new vkPair ( 0xEE, "F5 (Send)" ), //"VK_F5"
                
                new vkPair ( 0x3D, "END" ), //F4 added for compatibility
                new vkPair ( 0x3F, "upper right side button" ),
                new vkPair ( 0x40, "lower right side button" ),
                new vkPair ( 0x41, "*" ),
                new vkPair ( 0x42, "#" ),
                new vkPair ( 0x43, "upper left side button" ),
                new vkPair ( 0x51, "CURSOR DOWN" ),
                new vkPair ( 0x52, "CURSOR UP" ),
                new vkPair ( 0x81, "Power Button?" ), //not verified
                new vkPair ( 0x87, "light/zero" ), //"undef 0x9C-light"
                new vkPair ( 0x8b, "Green Shift Button" ),
                new vkPair ( 0x90, "Front Scan Button" ),
                new vkPair ( 0x91, "lower left side button" ),
                new vkPair ( 0xB6, "Aqua Shift Button" ), //not verified
                new vkPair ( 0xE1, "Left Shift" ), //"VK_SHIFT"
                new vkPair ( 0xE9, "Orange Plane" ) //"undef 0x99"      
            };
        }
    }
}
