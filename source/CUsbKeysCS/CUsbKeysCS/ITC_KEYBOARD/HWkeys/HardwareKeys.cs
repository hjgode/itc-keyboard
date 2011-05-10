using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using EventNamespace;

namespace ITC_KEYBOARD
{
    public static class HardwareKeys
    {
        public enum CN50Keys
        {
            ITC_Standard_A_Key = 0x04,            // A
            ITC_Standard_B_Key = 0x05,            // B
            ITC_Standard_C_Key = 0x06,            // C
            ITC_Standard_D_Key = 0x07,            // D
            ITC_Standard_E_Key = 0x08,            // E
            ITC_Standard_F_Key = 0x09,            // F
            ITC_Standard_G_Key = 0x0A,            // G
            ITC_Standard_H_Key = 0x0B,            // H
            ITC_Standard_I_Key = 0x0C,            // I
            ITC_Standard_J_Key = 0x0D,            // J
            ITC_Standard_K_Key = 0x0E,            // K
            ITC_Standard_L_Key = 0x0F,            // L
            ITC_Standard_M_Key = 0x10,            // M
            ITC_Standard_N_Key = 0x11,            // N
            ITC_Standard_O_Key = 0x12,            // O
            ITC_Standard_P_Key = 0x13,            // P
            ITC_Standard_Q_Key = 0x14,            // Q
            ITC_Standard_R_Key = 0x15,            // R
            ITC_Standard_S_Key = 0x16,            // S
            ITC_Standard_T_Key = 0x17,            // T
            ITC_Standard_U_Key = 0x18,            // U
            ITC_Standard_V_Key = 0x19,            // V
            ITC_Standard_W_Key = 0x1A,            // W
            ITC_Standard_X_Key = 0x1B,            // X
            ITC_Standard_Y_Key = 0x1C,            // Y
            ITC_Standard_Z_Key = 0x1D,            // Z
            ITC_Standard_1_Key = 0x1E,            // 1
            ITC_Standard_2_Key = 0x1F,            // 2
            ITC_Standard_3_Key = 0x20,            // 3
            ITC_Standard_4_Key = 0x21,            // 4
            ITC_Standard_5_Key = 0x22,            // 5
            ITC_Standard_6_Key = 0x23,            // 6
            ITC_Standard_7_Key = 0x24,            // 7
            ITC_Standard_8_Key = 0x25,            // 8
            ITC_Standard_9_Key = 0x26,            // 9
            ITC_Standard_0_Key = 0x27,			// 0
            ITC_Standard_Enter_Key = 0x28,    // Enter
            ITC_Standard_Escape_Key = 0x29,    // Escape
            ITC_Standard_Backspace_Key = 0x2A,    // Backspace
            ITC_Standard_Tab_Key = 0x2B,    // Tab
            ITC_Standard_Space_Key = 0x2C,    // Space
            ITC_Standard_Shift_Key = 0xE1,    // Shift
            ITC_Standard_Period_Key = 0x37,    // Period
            ITC_Standard_Soft1_Key = 0x3A,    // Soft 1 (<)
            ITC_Standard_Soft2_Key = 0x3B,    // Soft 2 (>)
            ITC_Standard_Send_Key = 0x3C,    // Phone Send Key
            ITC_Standard_Star_Key = 0x41,    // Phone Star Key
            ITC_Standard_DArrow_Key = 0x51,    // Down Arrow
            ITC_Standard_UArrow_Key = 0x52,    // Up Arrow
            ITC_Standard_UpperLeft_Btn = 0x43,    // Upper Left Side Button
            ITC_Standard_LowerLeft_Btn = 0x91,    // Lower Left Side Button
            ITC_Standard_UpperRight_Btn = 0x3f,    // Upper Right Side Button
            ITC_Standard_LowerRight_Btn = 0x40,    // Lower Right Side Button
	
        }
        public enum CK70Keys
        {
            ITC_Standard_A_Key = 0x04,            // A
            ITC_Standard_B_Key = 0x05,            // B
            ITC_Standard_C_Key = 0x06,            // C
            ITC_Standard_D_Key = 0x07,            // D
            ITC_Standard_E_Key = 0x08,            // E
            ITC_Standard_F_Key = 0x09,            // F
            ITC_Standard_G_Key = 0x0A,            // G
            ITC_Standard_H_Key = 0x0B,            // H
            ITC_Standard_I_Key = 0x0C,            // I
            ITC_Standard_J_Key = 0x0D,            // J
            ITC_Standard_K_Key = 0x0E,            // K
            ITC_Standard_L_Key = 0x0F,            // L
            ITC_Standard_M_Key = 0x10,            // M
            ITC_Standard_N_Key = 0x11,            // N
            ITC_Standard_O_Key = 0x12,            // O
            ITC_Standard_P_Key = 0x13,            // P
            ITC_Standard_Q_Key = 0x14,            // Q
            ITC_Standard_R_Key = 0x15,            // R
            ITC_Standard_S_Key = 0x16,            // S
            ITC_Standard_T_Key = 0x17,            // T
            ITC_Standard_U_Key = 0x18,            // U
            ITC_Standard_V_Key = 0x19,            // V
            ITC_Standard_W_Key = 0x1A,            // W
            ITC_Standard_X_Key = 0x1B,            // X
            ITC_Standard_Y_Key = 0x1C,            // Y
            ITC_Standard_Z_Key = 0x1D,            // Z
            //### numeric keys are on second plane ###
            /*
            ITC_Standard_1_Key = 0x1E,            // 1
            ITC_Standard_2_Key = 0x1F,            // 2
            ITC_Standard_3_Key = 0x20,            // 3
            ITC_Standard_4_Key = 0x21,            // 4
            ITC_Standard_5_Key = 0x22,            // 5
            ITC_Standard_6_Key = 0x23,            // 6
            ITC_Standard_7_Key = 0x24,            // 7
            ITC_Standard_8_Key = 0x25,            // 8
            ITC_Standard_9_Key = 0x26,            // 9
            ITC_Standard_0_Key = 0x27,			  // 0
            */
            //========================================
            ITC_Standard_Enter_Key = 0x28,    // Enter
            ITC_Standard_Escape_Key = 0x29,    // Escape
            ITC_Standard_Backspace_Key = 0x2A,    // Backspace
            ITC_Standard_Tab_Key = 0x2B,    // Tab
            ITC_Standard_Space_Key = 0x2C,    // Space
            ITC_Standard_Shift_Key = 0xE1,    // Shift
            ITC_Standard_Period_Key = 0x37,    // Period
            //========================================
            //### soft 1 and 2 are on plane green
            //ITC_Standard_Soft1_Key      = 0x3A,    // Soft 1 (<)
            //ITC_Standard_Soft2_Key      = 0x3B,    // Soft 2 (>)
            //### no send and star key
            //ITC_Standard_Send_Key       = 0x3C,    // Phone Send Key
            //ITC_Standard_Star_Key       = 0x41,    // Phone Star Key
            //========================================
            ITC_Standard_RArrow_Key = 0x4F,    // Right Arrow
            ITC_Standard_LArrow_Key = 0x50,    // Left Arrow
            ITC_Standard_DArrow_Key = 0x51,    // Down Arrow
            ITC_Standard_UArrow_Key = 0x52,    // Up Arrow
            //### side buttons
            ITC_Standard_UpperLeft_Btn = 0x43,    // Upper Left Side Button
            ITC_Standard_LowerLeft_Btn = 0x91,    // Lower Left Side Button
            ITC_Standard_UpperRight_Btn = 0x3f,    // Upper Right Side Button
            ITC_Standard_LowerRight_Btn = 0x40,    // Lower Right Side Button
            //### Scan button
            ITC_Standard_Scan_Btn = 0x90,           // Center Scan Button
            //### plane keys
            ITC_Standard_OrangePlane_Btn = 0xE9,    // Orange plane Button
            ITC_Standard_Aqua_Btn = 0x8B,           // Aqua plane Button
            //### Left GUI or LWIN key
            ITC_Standard_LWIN_Btn = 0xE3,           // WINDOWS Button
        }
        public enum AllKeys{
            //  These values represent the physical keys (Scancode) on intermec computer keyboards
            //  KEYBOARD Key Identifiers
            ITC_3170_LAqua_Key	 = 	0xE0,            // Left Aqua
            ITC_3170_LGold_Key	 = 	0xE2,            // Left Gold
            ITC_3170_RAqua_Key	 = 	0xE4,            // Right Aqua
            ITC_3170_RGold_Key	 = 	0xE6,            // Right Gold
            ITC_3250_LAqua_Key	 = 	0xE0,            // Left Aqua
            ITC_3250_LGold_Key	 = 	0xE2,            // Left Gold
            ITC_3250_RAqua_Key	 = 	0xE4,            // Right Aqua
            ITC_3250_RGold_Key	 = 	0xE6,            // Right Gold
            ITC_Standard_0_Key	 = 	0x27,            // 0
            ITC_Standard_1_Key	 = 	0x1E,            // 1
            ITC_Standard_2_Key	 = 	0x1F,            // 2
            ITC_Standard_3_Key	 = 	0x20,            // 3
            ITC_Standard_4_Key	 = 	0x21,            // 4
            ITC_Standard_5_Key	 = 	0x22,            // 5
            ITC_Standard_6_Key	 = 	0x23,            // 6
            ITC_Standard_7_Key	 = 	0x24,            // 7
            ITC_Standard_8_Key	 = 	0x25,            // 8
            ITC_Standard_9_Key	 = 	0x26,            // 9
            ITC_Standard_A_Key	 = 	0x04,            // A
            ITC_Standard_Apostrophe_Key	 = 	0x34,   // '
            ITC_Standard_App_Key	 = 	0x65,          // App
            ITC_Standard_Astrix_Key   	 = 	0x41,    // *
            ITC_Standard_B_Key	 = 	0x05,            // B
            ITC_Standard_Backlight_Key	 = 	0x87,    // Backlight
            ITC_Standard_BackSlash_Key	 = 	0x31,    // Backslash
            ITC_Standard_Backspace_Key 	 = 	0x2A,    // Backspace
            ITC_Standard_Break_Key	 = 	0x48,        // Pause/Break
            ITC_Standard_C_Key	 = 	0x06,            // C
            ITC_Standard_CapLock_Key	 = 	0x39,      // CAP Lock
            ITC_Standard_Comma_Key	 = 	0x36,        // Comma
            ITC_Standard_D_Key	 = 	0x07,            // D
            ITC_Standard_DArrow_Key    	 = 	0x51,    // Down Arrow
            ITC_Standard_Dash_Key	 = 	0x2d,         // -
            ITC_Standard_Del_Key	 = 	0x4C,          // Del
            ITC_Standard_E_Key	 = 	0x08,            // E
            ITC_Standard_End_Key	 = 	0x4D,          // End
            ITC_Standard_Enter_Key     	 = 	0x28,    // Enter
            ITC_Standard_Equal_Key	 = 	0x2e,        // =
            ITC_Standard_Escape_Key    	 = 	0x29,    // Escape
            ITC_Standard_F10_Key      	 = 	0x43,   // F10
            ITC_Standard_F11_Key      	 = 	0x44,   // F11
            ITC_Standard_F12_Key      	 = 	0x45,   // F12
            ITC_Standard_F1_Key       	 = 	0x3A,   // F1
            ITC_Standard_F2_Key       	 = 	0x3B,   // F2
            ITC_Standard_F3_Key       	 = 	0x3C,   // F3
            ITC_Standard_F4_Key       	 = 	0x3D,   // F4
            ITC_Standard_F5_Key       	 = 	0x3E,   // F5
            ITC_Standard_F6_Key       	 = 	0x3F,   // F6
            ITC_Standard_F7_Key       	 = 	0x40,   // F7
            ITC_Standard_F8_Key       	 = 	0x41,   // F8
            ITC_Standard_F9_Key       	 = 	0x42,   // F9
            ITC_Standard_F_Key	 = 	0x09,            // F
            ITC_Standard_FieldExit_Key	 = 	0x58,    // FldExit
            ITC_Standard_G_Key	 = 	0x0A,            // G
            ITC_Standard_H_Key	 = 	0x0B,            // H
            ITC_Standard_Hash_Key     	 = 	0x42,    // #
            ITC_Standard_Home_Key	 = 	0x4A,         // Home
            ITC_Standard_I_Key	 = 	0x0C,            // I
            ITC_Standard_Insert_Key	 = 	0x49,       // Ins
            ITC_Standard_J_Key	 = 	0x0D,            // J
            ITC_Standard_K_Key	 = 	0x0E,            // K
            ITC_Standard_L_Key	 = 	0x0F,            // L
            ITC_Standard_LAlt_Key	 = 	0xE2,         // Left Alt
            ITC_Standard_LArrow_Key   	 = 	0x50,    // Left Arrow
            ITC_Standard_LBracket_Key	 = 	0x2f,     // [
            ITC_Standard_LCtrl_Key    	 = 	0xE0,    // Left Control
            ITC_Standard_LowerLeft_Btn 	 = 	0x91,    // Lower Left Side Button
            ITC_Standard_LowerRight_Btn	 = 	0x40,    // Lower Right Side Button
            ITC_Standard_LShift_Key   	 = 	0xE1,    // Left Shift
            ITC_Standard_M_Key	 = 	0x10,            // M
            ITC_Standard_Menu_Key	 = 	0x45,         // Menu(F12)
            ITC_Standard_N_Key	 = 	0x11,            // N
            ITC_Standard_NumLk_Key	 = 	0x53,        // NumLk
            ITC_Standard_Numpad_0_Key	 = 	0x62,     // Numpad 0
            ITC_Standard_Numpad_1_Key	 = 	0x59,     // Numpad 1
            ITC_Standard_Numpad_2_Key	 = 	0x5A,     // Numpad 2
            ITC_Standard_Numpad_3_Key	 = 	0x5B,     // Numpad 3
            ITC_Standard_Numpad_4_Key	 = 	0x5C,     // Numpad 4
            ITC_Standard_Numpad_5_Key	 = 	0x5D,     // Numpad 5
            ITC_Standard_Numpad_6_Key	 = 	0x5E,     // Numpad 6
            ITC_Standard_Numpad_7_Key	 = 	0x5F,     // Numpad 7
            ITC_Standard_Numpad_8_Key	 = 	0x60,     // Numpad 8
            ITC_Standard_Numpad_9_Key	 = 	0x61,     // Numpad 9
            ITC_Standard_Numpad_Add_Key	 = 	0x57,   // Numpad +
            ITC_Standard_Numpad_Dec_Key	 = 	0x63,   // Numpad .
            ITC_Standard_Numpad_Div_Key	 = 	0x54,   // Numpad /
            ITC_Standard_Numpad_Minus_Key	 = 	0x56, // Numpad -
            ITC_Standard_Numpad_Mult_Key	 = 	0x55,  // Numpad *
            ITC_Standard_O_Key	 = 	0x12,            // O
            ITC_Standard_P_Key	 = 	0x13,            // P
            ITC_Standard_Period_Key    	 = 	0x37,    // Period
            ITC_Standard_PgDn_Key	 = 	0x4B,         // PgDn
            ITC_Standard_PgUp_Key	 = 	0x4E,         // PgUp
            ITC_Standard_PrtScrn_Key	 = 	0x46,      // PrtSc/SysRq
            ITC_Standard_Q_Key	 = 	0x14,            // Q
            ITC_Standard_Quote_Key	 = 	0x35,        // `
            ITC_Standard_R_Key	 = 	0x15,            // R
            ITC_Standard_RAlt_Key	 = 	0xE6,         // Right Alt
            ITC_Standard_RArrow_Key   	 = 	0x4F,    // Right Arrow
            ITC_Standard_RBracket_Key	 = 	0x30,     // ]
            ITC_Standard_RCtrl_Key	 = 	0xE4,        // Right Control
            ITC_Standard_Return_Key	 = 	0x44,       // Return(F11)
            ITC_Standard_RShift_Key	 = 	0xE5,       // Right Shift
            ITC_Standard_S_Key	 = 	0x16,            // S
            ITC_Standard_ScrLck_Key	 = 	0x47,       // ScrLk
            ITC_Standard_Semicolon_Key	 = 	0x33,    // ,
            ITC_Standard_Send_Key      	 = 	0x3C,    // Phone Send Key
            ITC_Standard_Shift_Key     	 = 	0xE1,    // Shift
            ITC_Standard_Slash_Key	 = 	0x38,        // Slash
            ITC_Standard_Soft1_Key     	 = 	0x3A,    // Soft 1 (<)
            ITC_Standard_Soft2_Key     	 = 	0x3B,    // Soft 2 (>)
            ITC_Standard_Space_Key     	 = 	0x2C,    // Space
            ITC_Standard_Star_Key      	 = 	0x41,    // Phone Star Key
            ITC_Standard_T_Key	 = 	0x17,            // T
            ITC_Standard_Tab_Key       	 = 	0x2B,    // Tab
            ITC_Standard_U_Key	 = 	0x18,            // U
            ITC_Standard_UArrow_Key    	 = 	0x52,    // Up Arrow
            ITC_Standard_UpperLeft_Btn 	 = 	0x43,    // Upper Left Side Button
            ITC_Standard_UpperRight_Btn	 = 	0x3f,    // Upper Right Side Button
            ITC_Standard_V_Key	 = 	0x19,            // V
            ITC_Standard_W_Key	 = 	0x1A,            // W
            ITC_Standard_Windows_Key  	 = 	0xE3,    // Windows
            ITC_Standard_X_Key	 = 	0x1B,            // X
            ITC_Standard_Y_Key	 = 	0x1C,            // Y
            ITC_Standard_Z_Key	 = 	0x1D,            // Z
            ITC_740_0Key         	 = 	0x17,
            ITC_740_1Key         	 = 	0x0f,
            ITC_740_2Key         	 = 	0x15,
            ITC_740_3Key         	 = 	0x1b,
            ITC_740_4Key         	 = 	0x06,
            ITC_740_5Key         	 = 	0x18,
            ITC_740_6Key         	 = 	0x1e,
            ITC_740_7Key         	 = 	0x10,
            ITC_740_8Key         	 = 	0x16,
            ITC_740_9Key         	 = 	0x1c,
            ITC_740_ActionKey    	 = 	0x1a,
            ITC_740_ALPHAKey     	 = 	0x11,
            ITC_740_BackspaceKey 	 = 	0x0a,
            ITC_740_DownKey      	 = 	0x0e,
            ITC_740_EnterKey     	 = 	0x1d,
            ITC_740_ESCKey       	 = 	0x0d,
            ITC_740_GOLDKey      	 = 	0x0b,
            ITC_740_IOKey        	 = 	0x01,
            ITC_740_LeftKey      	 = 	0x08,
            ITC_740_LScanButton  	 = 	0x03,
            ITC_740_PeriodKey    	 = 	0x05,
            ITC_740_RightKey     	 = 	0x14,
            ITC_740_RScanButton  	 = 	0x04,
            ITC_740_ScanTrigger  	 = 	0x02,
            ITC_740_UpKey        	 = 	0x13,
            ITC_740a_ActionKey    	 = 	0x0c,
            ITC_740a_AKey         	 = 	0x05,
            ITC_740a_ALPHAKey     	 = 	0x26,
            ITC_740a_BackspaceKey 	 = 	0x20,
            ITC_740a_BKey         	 = 	0x06,
            ITC_740a_CAPSKey      	 = 	0x1f,
            ITC_740a_CKey         	 = 	0x10,
            ITC_740a_DKey         	 = 	0x12,
            ITC_740a_DownKey      	 = 	0x09,
            ITC_740a_EKey         	 = 	0x0d,
            ITC_740a_EnterKey     	 = 	0x29,
            ITC_740a_ESCKey       	 = 	0x07,
            ITC_740a_FKey         	 = 	0x0e,
            ITC_740a_GKey         	 = 	0x0f,
            ITC_740a_GOLDKey      	 = 	0x25,
            ITC_740a_HKey         	 = 	0x11,
            ITC_740a_IKey         	 = 	0x18,
            ITC_740a_IOKey        	 = 	0x01,
            ITC_740a_JKey         	 = 	0x13,
            ITC_740a_KKey         	 = 	0x14,
            ITC_740a_LeftKey      	 = 	0x08,
            ITC_740a_LKey         	 = 	0x15,
            ITC_740a_LScanButton  	 = 	0x03,
            ITC_740a_MKey         	 = 	0x16,
            ITC_740a_NKey         	 = 	0x17,
            ITC_740a_OKey         	 = 	0x1e,
            ITC_740a_PKey         	 = 	0x19,
            ITC_740a_QKey         	 = 	0x1a,
            ITC_740a_RightKey     	 = 	0x0b,
            ITC_740a_RKey         	 = 	0x1b,
            ITC_740a_RScanButton  	 = 	0x04,
            ITC_740a_ScanTrigger  	 = 	0x02,
            ITC_740a_SKey         	 = 	0x1c,
            ITC_740a_SPACEKey     	 = 	0x27,
            ITC_740a_TKey         	 = 	0x1d,
            ITC_740a_UKey         	 = 	0x24,
            ITC_740a_UpKey        	 = 	0x0a,
            ITC_740a_VKey         	 = 	0x21,
            ITC_740a_WKey         	 = 	0x22,
            ITC_740a_XKey         	 = 	0x23,
            ITC_740a_YKey         	 = 	0x2a,
            ITC_740a_ZKey         	 = 	0x28,
            ITC_CK60_0_0Key          	 = 	0x16,
            ITC_CK60_0_1Key          	 = 	0x67,
            ITC_CK60_0_2Key          	 = 	0x77,
            ITC_CK60_0_3Key          	 = 	0x06,
            ITC_CK60_0_4Key          	 = 	0x37,
            ITC_CK60_0_5Key          	 = 	0x47,
            ITC_CK60_0_6Key          	 = 	0x57,
            ITC_CK60_0_7Key          	 = 	0x07,
            ITC_CK60_0_8Key          	 = 	0x17,
            ITC_CK60_0_9Key          	 = 	0x27,
            ITC_CK60_0_ActionKey     	 = 	0x42,
            ITC_CK60_0_AquaKey       	 = 	0x36,
            ITC_CK60_0_BackLightKey  	 = 	0x51,
            ITC_CK60_0_BackspaceKey  	 = 	0x46,
            ITC_CK60_0_DownKey       	 = 	0x31,
            ITC_CK60_0_EnterKey      	 = 	0x01,
            ITC_CK60_0_ESCKey        	 = 	0x72,
            ITC_CK60_0_GoldKey       	 = 	0x26,
            ITC_CK60_0_LBlueButton   	 = 	0x30,
            ITC_CK60_0_LeftKey       	 = 	0x41,
            ITC_CK60_0_PeriodKey     	 = 	0x03,
            ITC_CK60_0_RBlueButton   	 = 	0x20,
            ITC_CK60_0_RightKey      	 = 	0x11,
            ITC_CK60_0_RoundBlankKey 	 = 	0x25,
            ITC_CK60_0_Soft1Key      	 = 	0x62,
            ITC_CK60_0_Soft2Key      	 = 	0x61,
            ITC_CK60_0_Soft3Key      	 = 	0x05,
            ITC_CK60_0_Soft4Key      	 = 	0x71,
            ITC_CK60_0_Soft5Key      	 = 	0x52,
            ITC_CK60_0_SquareBlankKey	 = 	0x15,
            ITC_CK60_0_UpKey         	 = 	0x21,
            ITC_CK60_1_0Key          	 = 	0x16,
            ITC_CK60_1_1Key          	 = 	0x67,
            ITC_CK60_1_2Key          	 = 	0x77,
            ITC_CK60_1_3Key          	 = 	0x06,
            ITC_CK60_1_4Key          	 = 	0x37,
            ITC_CK60_1_5Key          	 = 	0x47,
            ITC_CK60_1_6Key          	 = 	0x57,
            ITC_CK60_1_7Key          	 = 	0x07,
            ITC_CK60_1_8Key          	 = 	0x17,
            ITC_CK60_1_9Key          	 = 	0x27,
            ITC_CK60_1_ActionKey     	 = 	0x42,
            ITC_CK60_1_AquaKey       	 = 	0x36,
            ITC_CK60_1_BackLightKey  	 = 	0x51,
            ITC_CK60_1_BackspaceKey  	 = 	0x46,
            ITC_CK60_1_DashKey       	 = 	0x15,
            ITC_CK60_1_DownKey       	 = 	0x31,
            ITC_CK60_1_EnterKey      	 = 	0x01,
            ITC_CK60_1_ESCKey        	 = 	0x72,
            ITC_CK60_1_GoldKey       	 = 	0x26,
            ITC_CK60_1_LBlueButton   	 = 	0x30,
            ITC_CK60_1_LeftKey       	 = 	0x41,
            ITC_CK60_1_PeriodKey     	 = 	0x03,
            ITC_CK60_1_RBlueButton   	 = 	0x20,
            ITC_CK60_1_RightKey      	 = 	0x11,
            ITC_CK60_1_Soft1Key      	 = 	0x62,
            ITC_CK60_1_Soft2Key      	 = 	0x61,
            ITC_CK60_1_Soft3Key      	 = 	0x05,
            ITC_CK60_1_Soft4Key      	 = 	0x71,
            ITC_CK60_1_Soft5Key      	 = 	0x52,
            ITC_CK60_1_TabKey        	 = 	0x56,
            ITC_CK60_1_UpKey         	 = 	0x21,
            ITC_CK60_2_0Key          	 = 	0x16,
            ITC_CK60_2_1Key          	 = 	0x67,
            ITC_CK60_2_2Key          	 = 	0x77,
            ITC_CK60_2_3Key          	 = 	0x06,
            ITC_CK60_2_4Key          	 = 	0x37,
            ITC_CK60_2_5Key          	 = 	0x47,
            ITC_CK60_2_6Key          	 = 	0x57,
            ITC_CK60_2_7Key          	 = 	0x07,
            ITC_CK60_2_8Key          	 = 	0x17,
            ITC_CK60_2_9Key          	 = 	0x27,
            ITC_CK60_2_ActionKey     	 = 	0x42,
            ITC_CK60_2_AKey          	 = 	0x05,
            ITC_CK60_2_AquaKey       	 = 	0x36,
            ITC_CK60_2_BackLightKey  	 = 	0x51,
            ITC_CK60_2_BackspaceKey  	 = 	0x46,
            ITC_CK60_2_BKey          	 = 	0x15,
            ITC_CK60_2_CKey          	 = 	0x25,
            ITC_CK60_2_CTLKey        	 = 	0x22,
            ITC_CK60_2_DKey          	 = 	0x35,
            ITC_CK60_2_DownKey       	 = 	0x31,
            ITC_CK60_2_EKey          	 = 	0x45,
            ITC_CK60_2_EnterKey      	 = 	0x01,
            ITC_CK60_2_ESCKey        	 = 	0x72,
            ITC_CK60_2_FKey          	 = 	0x55,
            ITC_CK60_2_GKey          	 = 	0x65,
            ITC_CK60_2_GoldKey       	 = 	0x26,
            ITC_CK60_2_HKey          	 = 	0x75,
            ITC_CK60_2_IKey          	 = 	0x04,
            ITC_CK60_2_JKey          	 = 	0x14,
            ITC_CK60_2_KKey          	 = 	0x24,
            ITC_CK60_2_LBlueButton   	 = 	0x30,
            ITC_CK60_2_LeftKey       	 = 	0x41,
            ITC_CK60_2_LKey          	 = 	0x34,
            ITC_CK60_2_MKey          	 = 	0x44,
            ITC_CK60_2_NKey          	 = 	0x54,
            ITC_CK60_2_OKey          	 = 	0x64,
            ITC_CK60_2_PKey          	 = 	0x74,
            ITC_CK60_2_QKey          	 = 	0x03,
            ITC_CK60_2_RBlueButton   	 = 	0x20,
            ITC_CK60_2_RightKey      	 = 	0x11,
            ITC_CK60_2_RKey          	 = 	0x13,
            ITC_CK60_2_ShiftKey      	 = 	0x66,
            ITC_CK60_2_SKey          	 = 	0x23,
            ITC_CK60_2_Soft1Key      	 = 	0x62,
            ITC_CK60_2_Soft2Key      	 = 	0x61,
            ITC_CK60_2_Soft3Key      	 = 	0x71,
            ITC_CK60_2_Soft4Key      	 = 	0x52,
            ITC_CK60_2_SpaceKey      	 = 	0x32,
            ITC_CK60_2_TabKey        	 = 	0x56,
            ITC_CK60_2_TKey          	 = 	0x33,
            ITC_CK60_2_UKey          	 = 	0x43,
            ITC_CK60_2_UpKey         	 = 	0x21,
            ITC_CK60_2_VKey          	 = 	0x53,
            ITC_CK60_2_WKey          	 = 	0x63,
            ITC_CK60_2_XKey          	 = 	0x73,
            ITC_CK60_2_YKey          	 = 	0x02,
            ITC_CK60_2_ZKey          	 = 	0x12,
            //### Scan button
            ITC_Standard_Scan_Btn        =  0x90,           // Center Scan Button
            //### plane keys
            ITC_Standard_OrangePlane_Btn =  0xE9,           // Orange plane Button
            ITC_Standard_Aqua_Btn        =  0x8B,           // Aqua plane Button
        }
    }
}
