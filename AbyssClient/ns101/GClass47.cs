using System;
using System.Runtime.InteropServices;
using ns151;
using ns213;
using ns226;
using ns370;
using ns387;
using ns54;

namespace ns101
{
	// Token: 0x02000088 RID: 136
	public static class GClass47
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x000105F8 File Offset: 0x0000E7F8
		internal static string smethod_0()
		{
			return GClass47.smethod_39();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001060C File Offset: 0x0000E80C
		public static bool smethod_1(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsAppInstalled(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001062C File Offset: 0x0000E82C
		public static uint smethod_2(GStruct66 gstruct66_0, GStruct108[] gstruct108_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_GetInstalledDepots(<Module>.smethod_8(), gstruct66_0, gstruct108_0, uint_0);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00010650 File Offset: 0x0000E850
		public static string smethod_3()
		{
			return GClass47.smethod_0();
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00010664 File Offset: 0x0000E864
		public static void smethod_4(GStruct66 gstruct66_0)
		{
			GClass47.smethod_21(gstruct66_0);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00010678 File Offset: 0x0000E878
		public static bool smethod_5(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_MarkContentCorrupt(<Module>.smethod_8(), bool_0);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00010698 File Offset: 0x0000E898
		public static int smethod_6()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_GetAppBuildId(<Module>.smethod_8());
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000106B8 File Offset: 0x0000E8B8
		internal static void smethod_7(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamApps_UninstallDLC(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000106D8 File Offset: 0x0000E8D8
		public static string smethod_8()
		{
			return GClass47.smethod_12();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000106EC File Offset: 0x0000E8EC
		public static int smethod_9()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_GetDLCCount(<Module>.smethod_8());
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001070C File Offset: 0x0000E90C
		public static bool smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsCybercafe(<Module>.smethod_8());
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00010728 File Offset: 0x0000E928
		public static bool smethod_11(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsSubscribedApp(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00010748 File Offset: 0x0000E948
		internal static string smethod_12()
		{
			return GClass47.smethod_22();
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001075C File Offset: 0x0000E95C
		public static string smethod_13(string string_0)
		{
			return GClass47.smethod_14(string_0);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00010770 File Offset: 0x0000E970
		internal static string smethod_14(string string_0)
		{
			return GClass47.smethod_29(string_0);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00010784 File Offset: 0x0000E984
		internal static void smethod_15()
		{
			GClass47.smethod_35();
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00010798 File Offset: 0x0000E998
		public static bool smethod_16()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsSubscribed(<Module>.smethod_8());
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000107B4 File Offset: 0x0000E9B4
		public static GStruct241 smethod_17(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamApps_GetFileDetails(<Module>.smethod_8(), gclass));
			}
			return result;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00010800 File Offset: 0x0000EA00
		internal static void smethod_18(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00010820 File Offset: 0x0000EA20
		public static bool smethod_19(int int_0, out GStruct66 gstruct66_0, out bool bool_0, out string string_0, int int_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_1);
			bool flag = Class177.SteamAPI_ISteamApps_BGetDLCDataByIndex(<Module>.smethod_8(), int_0, out gstruct66_0, out bool_0, intPtr, int_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00010860 File Offset: 0x0000EA60
		public static bool smethod_20(GStruct66 gstruct66_0, out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_GetDlcDownloadProgress(<Module>.smethod_8(), gstruct66_0, out ulong_0, out ulong_1);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00010880 File Offset: 0x0000EA80
		internal static void smethod_21(GStruct66 gstruct66_0)
		{
			GClass47.smethod_28(gstruct66_0);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00010894 File Offset: 0x0000EA94
		internal static string smethod_22()
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamApps_GetAvailableGameLanguages(<Module>.smethod_8()));
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000108B8 File Offset: 0x0000EAB8
		internal static void smethod_23(GStruct66 gstruct66_0)
		{
			GClass47.smethod_7(gstruct66_0);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000108CC File Offset: 0x0000EACC
		public static uint smethod_24(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000108EC File Offset: 0x0000EAEC
		public static bool smethod_25()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend(<Module>.smethod_8());
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00010908 File Offset: 0x0000EB08
		internal static void smethod_26(GStruct66 gstruct66_0)
		{
			GClass47.smethod_18(gstruct66_0);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001091C File Offset: 0x0000EB1C
		public static bool smethod_27(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsDlcInstalled(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001093C File Offset: 0x0000EB3C
		internal static void smethod_28(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamApps_InstallDLC(<Module>.smethod_8(), gstruct66_0);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001095C File Offset: 0x0000EB5C
		internal static string smethod_29(string string_0)
		{
			GClass78.smethod_1();
			string result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GClass78.smethod_0(Class177.SteamAPI_ISteamApps_GetLaunchQueryParam(<Module>.smethod_8(), gclass));
			}
			return result;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000109A8 File Offset: 0x0000EBA8
		public static bool smethod_30()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsVACBanned(<Module>.smethod_8());
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public static bool smethod_31(out string string_0, int int_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_0);
			bool flag = Class177.SteamAPI_ISteamApps_GetCurrentBetaName(<Module>.smethod_8(), intPtr, int_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00010A00 File Offset: 0x0000EC00
		public static void smethod_32(GStruct66 gstruct66_0)
		{
			GClass47.smethod_23(gstruct66_0);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00010A14 File Offset: 0x0000EC14
		public static void smethod_33()
		{
			GClass47.smethod_15();
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00010A28 File Offset: 0x0000EC28
		public static GStruct22 smethod_34()
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamApps_GetAppOwner(<Module>.smethod_8()));
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00010A4C File Offset: 0x0000EC4C
		internal static void smethod_35()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys(<Module>.smethod_8());
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00010A68 File Offset: 0x0000EC68
		public static void smethod_36(GStruct66 gstruct66_0)
		{
			GClass47.smethod_26(gstruct66_0);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00010A7C File Offset: 0x0000EC7C
		public static bool smethod_37()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamApps_BIsLowViolence(<Module>.smethod_8());
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00010A98 File Offset: 0x0000EC98
		public static uint smethod_38(GStruct66 gstruct66_0, out string string_0, uint uint_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			uint num = Class177.SteamAPI_ISteamApps_GetAppInstallDir(<Module>.smethod_8(), gstruct66_0, intPtr, uint_0);
			string_0 = ((num != 0U) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		internal static string smethod_39()
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamApps_GetCurrentGameLanguage(<Module>.smethod_8()));
		}
	}
}
