using System;
using System.Runtime.InteropServices;
using ns117;
using ns132;
using ns151;
using ns226;
using ns279;
using ns370;
using ns383;
using ns387;
using ns403;
using ns419;

namespace ns178
{
	// Token: 0x02000121 RID: 289
	public static class GClass68
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x00028A78 File Offset: 0x00026C78
		internal static void smethod_0(GDelegate17 gdelegate17_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUtils_SetWarningMessageHook(<Module>.smethod_5(), gdelegate17_0);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00028A98 File Offset: 0x00026C98
		public static GStruct66 smethod_1()
		{
			GClass78.smethod_1();
			return GStruct66.smethod_3(Class177.SteamAPI_ISteamUtils_GetAppID(<Module>.smethod_5()));
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00028ABC File Offset: 0x00026CBC
		public static void smethod_2(GEnum73 genum73_0)
		{
			GClass68.smethod_7(genum73_0);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00028AD0 File Offset: 0x00026CD0
		internal static void smethod_3(GEnum73 genum73_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUtils_SetOverlayNotificationPosition(<Module>.smethod_5(), genum73_0);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00028AF0 File Offset: 0x00026CF0
		public static uint smethod_4()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetIPCCallCount(<Module>.smethod_5());
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00028B10 File Offset: 0x00026D10
		public static bool smethod_5(GEnum21 genum21_0, GEnum51 genum51_0, string string_0, uint uint_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUtils_ShowGamepadTextInput(<Module>.smethod_5(), genum21_0, genum51_0, gclass, uint_0, gclass2);
				}
			}
			return result;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00028B78 File Offset: 0x00026D78
		public static bool smethod_6()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled(<Module>.smethod_5());
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00028B94 File Offset: 0x00026D94
		internal static void smethod_7(GEnum73 genum73_0)
		{
			GClass68.smethod_3(genum73_0);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00028BA8 File Offset: 0x00026DA8
		public static bool smethod_8(GStruct241 gstruct241_0, IntPtr intptr_0, int int_0, int int_1, out bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetAPICallResult(<Module>.smethod_5(), gstruct241_0, intptr_0, int_0, int_1, out bool_0);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00028BCC File Offset: 0x00026DCC
		internal static string smethod_9()
		{
			return GClass68.smethod_42();
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00028BE0 File Offset: 0x00026DE0
		internal static string smethod_10()
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUtils_GetSteamUILanguage(<Module>.smethod_5()));
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00028C04 File Offset: 0x00026E04
		internal static void smethod_11()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUtils_StartVRDashboard(<Module>.smethod_5());
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00028C20 File Offset: 0x00026E20
		public static uint smethod_12()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetSecondsSinceComputerActive(<Module>.smethod_5());
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00028C40 File Offset: 0x00026E40
		public static void smethod_13()
		{
			GClass68.smethod_21();
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00028C54 File Offset: 0x00026E54
		public static bool smethod_14()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_IsOverlayEnabled(<Module>.smethod_5());
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00028C70 File Offset: 0x00026E70
		internal static void smethod_15(bool bool_0)
		{
			GClass68.smethod_29(bool_0);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00028C84 File Offset: 0x00026E84
		public static GStruct241 smethod_16(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUtils_CheckFileSignature(<Module>.smethod_5(), gclass));
			}
			return result;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00028CD0 File Offset: 0x00026ED0
		public static bool smethod_17(int int_0, out uint uint_0, out uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetImageSize(<Module>.smethod_5(), int_0, out uint_0, out uint_1);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00028CF0 File Offset: 0x00026EF0
		public static void smethod_18(int int_0, int int_1)
		{
			GClass68.smethod_34(int_0, int_1);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00028D04 File Offset: 0x00026F04
		public static GEnum81 smethod_19(GStruct241 gstruct241_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetAPICallFailureReason(<Module>.smethod_5(), gstruct241_0);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00028D24 File Offset: 0x00026F24
		public static byte smethod_20()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetCurrentBatteryPower(<Module>.smethod_5());
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00028D44 File Offset: 0x00026F44
		internal static void smethod_21()
		{
			GClass68.smethod_11();
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00028D58 File Offset: 0x00026F58
		public static string smethod_22()
		{
			return GClass68.smethod_9();
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00028D6C File Offset: 0x00026F6C
		public static void smethod_23(bool bool_0)
		{
			GClass68.smethod_15(bool_0);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00028D80 File Offset: 0x00026F80
		public static bool smethod_24()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_BOverlayNeedsPresent(<Module>.smethod_5());
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00028D9C File Offset: 0x00026F9C
		public static void smethod_25(GDelegate17 gdelegate17_0)
		{
			GClass68.smethod_35(gdelegate17_0);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00028DB0 File Offset: 0x00026FB0
		public static uint smethod_26()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetServerRealTime(<Module>.smethod_5());
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public static bool smethod_27(GStruct241 gstruct241_0, out bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_IsAPICallCompleted(<Module>.smethod_5(), gstruct241_0, out bool_0);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00028DF0 File Offset: 0x00026FF0
		public static string smethod_28()
		{
			return GClass68.smethod_40();
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00028E04 File Offset: 0x00027004
		internal static void smethod_29(bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled(<Module>.smethod_5(), bool_0);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00028E24 File Offset: 0x00027024
		internal static void smethod_30(int int_0, int int_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUtils_SetOverlayNotificationInset(<Module>.smethod_5(), int_0, int_1);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00028E44 File Offset: 0x00027044
		public static uint smethod_31()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetSecondsSinceAppActive(<Module>.smethod_5());
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00028E64 File Offset: 0x00027064
		public static uint smethod_32()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetEnteredGamepadTextLength(<Module>.smethod_5());
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00028E84 File Offset: 0x00027084
		public static bool smethod_33()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_IsSteamRunningInVR(<Module>.smethod_5());
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00028EA0 File Offset: 0x000270A0
		internal static void smethod_34(int int_0, int int_1)
		{
			GClass68.smethod_30(int_0, int_1);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00028EB4 File Offset: 0x000270B4
		internal static void smethod_35(GDelegate17 gdelegate17_0)
		{
			GClass68.smethod_0(gdelegate17_0);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00028EC8 File Offset: 0x000270C8
		public static bool smethod_36(out string string_0, uint uint_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool flag = Class177.SteamAPI_ISteamUtils_GetEnteredGamepadTextInput(<Module>.smethod_5(), intPtr, uint_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00028F04 File Offset: 0x00027104
		public static bool smethod_37()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_IsSteamInBigPictureMode(<Module>.smethod_5());
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00028F20 File Offset: 0x00027120
		public static bool smethod_38(out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetCSERIPPort(<Module>.smethod_5(), out uint_0, out ushort_0);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00028F40 File Offset: 0x00027140
		public static bool smethod_39(int int_0, byte[] byte_0, int int_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetImageRGBA(<Module>.smethod_5(), int_0, byte_0, int_1);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00028F60 File Offset: 0x00027160
		internal static string smethod_40()
		{
			return GClass68.smethod_10();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00028F74 File Offset: 0x00027174
		public static GEnum77 smethod_41()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUtils_GetConnectedUniverse(<Module>.smethod_5());
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00028F94 File Offset: 0x00027194
		internal static string smethod_42()
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUtils_GetIPCountry(<Module>.smethod_5()));
		}
	}
}
