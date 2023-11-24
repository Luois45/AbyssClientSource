using System;
using System.Runtime.InteropServices;
using ns117;
using ns132;
using ns151;
using ns226;
using ns279;
using ns370;
using ns381;
using ns383;
using ns387;
using ns403;
using ns419;

namespace ns501
{
	// Token: 0x02000365 RID: 869
	public static class GClass190
	{
		// Token: 0x060047F4 RID: 18420 RVA: 0x00110478 File Offset: 0x0010E678
		internal static void smethod_0()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUtils_StartVRDashboard(Class180.smethod_0());
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x00110494 File Offset: 0x0010E694
		internal static void smethod_1(int int_0, int int_1)
		{
			GClass190.smethod_24(int_0, int_1);
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x001104A8 File Offset: 0x0010E6A8
		internal static string smethod_2()
		{
			GClass78.smethod_2();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUtils_GetSteamUILanguage(Class180.smethod_0()));
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x001104CC File Offset: 0x0010E6CC
		internal static void smethod_3(GDelegate17 gdelegate17_0)
		{
			GClass190.smethod_14(gdelegate17_0);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x001104E0 File Offset: 0x0010E6E0
		public static bool smethod_4(out string string_0, uint uint_0)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool flag = Class177.SteamAPI_ISteamUtils_GetEnteredGamepadTextInput(Class180.smethod_0(), intPtr, uint_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x0011051C File Offset: 0x0010E71C
		public static string smethod_5()
		{
			return GClass190.smethod_38();
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x00110530 File Offset: 0x0010E730
		public static uint smethod_6()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetServerRealTime(Class180.smethod_0());
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x00110550 File Offset: 0x0010E750
		public static bool smethod_7()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_IsSteamInBigPictureMode(Class180.smethod_0());
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x0011056C File Offset: 0x0010E76C
		public static bool smethod_8()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_BOverlayNeedsPresent(Class180.smethod_0());
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x00110588 File Offset: 0x0010E788
		internal static string smethod_9()
		{
			return GClass190.smethod_42();
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x0011059C File Offset: 0x0010E79C
		public static bool smethod_10(int int_0, byte[] byte_0, int int_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetImageRGBA(Class180.smethod_0(), int_0, byte_0, int_1);
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x001105BC File Offset: 0x0010E7BC
		public static uint smethod_11()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetSecondsSinceAppActive(Class180.smethod_0());
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x001105DC File Offset: 0x0010E7DC
		public static uint smethod_12()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetEnteredGamepadTextLength(Class180.smethod_0());
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x001105FC File Offset: 0x0010E7FC
		public static uint smethod_13()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetSecondsSinceComputerActive(Class180.smethod_0());
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x0011061C File Offset: 0x0010E81C
		internal static void smethod_14(GDelegate17 gdelegate17_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUtils_SetWarningMessageHook(Class180.smethod_0(), gdelegate17_0);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x0011063C File Offset: 0x0010E83C
		internal static void smethod_15(GEnum73 genum73_0)
		{
			GClass190.smethod_36(genum73_0);
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00110650 File Offset: 0x0010E850
		public static void smethod_16(GDelegate17 gdelegate17_0)
		{
			GClass190.smethod_3(gdelegate17_0);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00110664 File Offset: 0x0010E864
		public static void smethod_17(int int_0, int int_1)
		{
			GClass190.smethod_1(int_0, int_1);
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x00110678 File Offset: 0x0010E878
		public static bool smethod_18(int int_0, out uint uint_0, out uint uint_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetImageSize(Class180.smethod_0(), int_0, out uint_0, out uint_1);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x00110698 File Offset: 0x0010E898
		public static bool smethod_19(GStruct241 gstruct241_0, out bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_IsAPICallCompleted(Class180.smethod_0(), gstruct241_0, out bool_0);
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x001106B8 File Offset: 0x0010E8B8
		public static bool smethod_20()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled(Class180.smethod_0());
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x001106D4 File Offset: 0x0010E8D4
		internal static void smethod_21(bool bool_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled(Class180.smethod_0(), bool_0);
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x001106F4 File Offset: 0x0010E8F4
		public static void smethod_22(bool bool_0)
		{
			GClass190.smethod_37(bool_0);
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x00110708 File Offset: 0x0010E908
		public static string smethod_23()
		{
			return GClass190.smethod_9();
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0011071C File Offset: 0x0010E91C
		internal static void smethod_24(int int_0, int int_1)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUtils_SetOverlayNotificationInset(Class180.smethod_0(), int_0, int_1);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0011073C File Offset: 0x0010E93C
		public static GEnum77 smethod_25()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetConnectedUniverse(Class180.smethod_0());
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x0011075C File Offset: 0x0010E95C
		public static void smethod_26()
		{
			GClass190.smethod_40();
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x00110770 File Offset: 0x0010E970
		public static GStruct66 smethod_27()
		{
			GClass78.smethod_2();
			return GStruct66.smethod_3(Class177.SteamAPI_ISteamUtils_GetAppID(Class180.smethod_0()));
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x00110794 File Offset: 0x0010E994
		public static void smethod_28(GEnum73 genum73_0)
		{
			GClass190.smethod_15(genum73_0);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x001107A8 File Offset: 0x0010E9A8
		public static GEnum81 smethod_29(GStruct241 gstruct241_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetAPICallFailureReason(Class180.smethod_0(), gstruct241_0);
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x001107C8 File Offset: 0x0010E9C8
		public static byte smethod_30()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetCurrentBatteryPower(Class180.smethod_0());
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x001107E8 File Offset: 0x0010E9E8
		public static bool smethod_31()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_IsSteamRunningInVR(Class180.smethod_0());
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x00110804 File Offset: 0x0010EA04
		public static bool smethod_32(GStruct241 gstruct241_0, IntPtr intptr_0, int int_0, int int_1, out bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetAPICallResult(Class180.smethod_0(), gstruct241_0, intptr_0, int_0, int_1, out bool_0);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00110828 File Offset: 0x0010EA28
		public static bool smethod_33(GEnum21 genum21_0, GEnum51 genum51_0, string string_0, uint uint_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUtils_ShowGamepadTextInput(Class180.smethod_0(), genum21_0, genum51_0, gclass, uint_0, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x00110890 File Offset: 0x0010EA90
		public static GStruct241 smethod_34(string string_0)
		{
			GClass78.smethod_2();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUtils_CheckFileSignature(Class180.smethod_0(), gclass));
			}
			return result;
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x001108DC File Offset: 0x0010EADC
		public static bool smethod_35(out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetCSERIPPort(Class180.smethod_0(), out uint_0, out ushort_0);
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x001108FC File Offset: 0x0010EAFC
		internal static void smethod_36(GEnum73 genum73_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUtils_SetOverlayNotificationPosition(Class180.smethod_0(), genum73_0);
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x0011091C File Offset: 0x0010EB1C
		internal static void smethod_37(bool bool_0)
		{
			GClass190.smethod_21(bool_0);
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x00110930 File Offset: 0x0010EB30
		internal static string smethod_38()
		{
			return GClass190.smethod_2();
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x00110944 File Offset: 0x0010EB44
		public static uint smethod_39()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_GetIPCCallCount(Class180.smethod_0());
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00110964 File Offset: 0x0010EB64
		internal static void smethod_40()
		{
			GClass190.smethod_0();
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00110978 File Offset: 0x0010EB78
		public static bool smethod_41()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUtils_IsOverlayEnabled(Class180.smethod_0());
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x00110994 File Offset: 0x0010EB94
		internal static string smethod_42()
		{
			GClass78.smethod_2();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUtils_GetIPCountry(Class180.smethod_0()));
		}
	}
}
