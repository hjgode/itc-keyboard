using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using EventNamespace;

namespace ITC_KEYBOARD
{
    public partial class CUsbHwKeys
    {
        private static class cn50Keys
        {
            public static vkPair[] vkPairs = new vkPair[]{
                new vkPair ( 0x3C,	"SEND" ), //F3 
                new vkPair ( 0x3D,	"END" ),  //F4 added for compatibility
                new vkPair ( 0x51,	"CURSOR DOWN" ),
                new vkPair ( 0x2B,	"TAB" ),
                new vkPair ( 0x41,	"*" ),
                new vkPair ( 0x3A,	"Softkey 1" ),
                new vkPair ( 0x1E,	"1" ),
                new vkPair ( 0x21,	"4" ),
                new vkPair ( 0x24,	"7" ),
                new vkPair ( 0x3B,	"Softkey 2" ),
                new vkPair ( 0x1F,	"2" ),
                new vkPair ( 0x22,	"5" ),
                new vkPair ( 0x25,	"8" ),
                new vkPair ( 0x52,	"CURSOR UP" ),
                new vkPair ( 0x37,	"." ),
                new vkPair ( 0x20,	"3" ),
                new vkPair ( 0x23,	"6" ),
                new vkPair ( 0x26,	"9" ),
                new vkPair ( 0x28,	"ENTER" ),
                new vkPair ( 0x29,	"ESC" ),
                new vkPair ( 0x42,	"#" ),
                new vkPair ( 0x91,	"lower left side button" ),
                new vkPair ( 0x40,	"lower right side button" ),
                new vkPair ( 0x2A,	"BACKSPACE" ),
                new vkPair ( 0x43,	"upper left side button" ),
                new vkPair ( 0x3F,	"upper right side button" ),
                new vkPair ( 0x27,	"0" ),
                new vkPair ( 0x8b,  "Green Shift Button" ),
                new vkPair ( 0x90,  "Front Scan Button" ),
                new vkPair ( 0xE9,  "Orange Shift Button" ),
                new vkPair ( 0xB6,  "Aqua Shift Button" ), //not verified
                new vkPair ( 0x81,  "Power Button" ) //not verified
            };
        }
    }
}