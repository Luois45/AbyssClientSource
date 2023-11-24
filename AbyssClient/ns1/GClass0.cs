using System;
using System.Runtime.InteropServices;
using ns119;
using ns151;
using ns19;
using ns226;
using ns229;
using ns370;
using ns386;
using ns398;
using ns43;
using ns46;
using ns71;
using ns91;

namespace ns1
{
	// Token: 0x02000002 RID: 2
	public static class GClass0
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002864 File Offset: 0x00000A64
		public static void smethod_0(GStruct240 gstruct240_0)
		{
			GClass0.smethod_16(gstruct240_0);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002878 File Offset: 0x00000A78
		public static void smethod_1(GStruct248 gstruct248_0)
		{
			GClass0.smethod_18(gstruct248_0);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000288C File Offset: 0x00000A8C
		internal static void smethod_2(GStruct240 gstruct240_0)
		{
			GClass0.smethod_14(gstruct240_0);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000028A0 File Offset: 0x00000AA0
		public static GStruct240 smethod_3(GStruct66 gstruct66_0, GStruct44[] gstruct44_0, uint uint_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList(<Module>.smethod_9(), gstruct66_0, GClass38.smethod_0(new GClass38(gstruct44_0)), uint_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000028D8 File Offset: 0x00000AD8
		public static void smethod_4(GStruct240 gstruct240_0)
		{
			GClass0.smethod_13(gstruct240_0);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000028EC File Offset: 0x00000AEC
		public static GStruct240 smethod_5(GStruct66 gstruct66_0, GStruct44[] gstruct44_0, uint uint_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList(<Module>.smethod_9(), gstruct66_0, GClass38.smethod_0(new GClass38(gstruct44_0)), uint_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002924 File Offset: 0x00000B24
		public static GStruct248 smethod_6(uint uint_0, ushort ushort_0, GClass13 gclass13_0)
		{
			GClass78.smethod_1();
			return GStruct248.smethod_3(Class177.SteamAPI_ISteamMatchmakingServers_PlayerDetails(<Module>.smethod_9(), uint_0, ushort_0, GClass13.smethod_0(gclass13_0)));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002950 File Offset: 0x00000B50
		public static GStruct248 smethod_7(uint uint_0, ushort ushort_0, GClass20 gclass20_0)
		{
			GClass78.smethod_1();
			return GStruct248.smethod_3(Class177.SteamAPI_ISteamMatchmakingServers_PingServer(<Module>.smethod_9(), uint_0, ushort_0, GClass20.smethod_0(gclass20_0)));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000297C File Offset: 0x00000B7C
		internal static void smethod_8(GStruct248 gstruct248_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmakingServers_CancelServerQuery(<Module>.smethod_9(), gstruct248_0);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000299C File Offset: 0x00000B9C
		public static GStruct240 smethod_9(GStruct66 gstruct66_0, GStruct44[] gstruct44_0, uint uint_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList(<Module>.smethod_9(), gstruct66_0, GClass38.smethod_0(new GClass38(gstruct44_0)), uint_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000029D4 File Offset: 0x00000BD4
		public static GStruct240 smethod_10(GStruct66 gstruct66_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestLANServerList(<Module>.smethod_9(), gstruct66_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A00 File Offset: 0x00000C00
		public static GStruct240 smethod_11(GStruct66 gstruct66_0, GStruct44[] gstruct44_0, uint uint_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList(<Module>.smethod_9(), gstruct66_0, GClass38.smethod_0(new GClass38(gstruct44_0)), uint_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002A38 File Offset: 0x00000C38
		public static bool smethod_12(GStruct240 gstruct240_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmakingServers_IsRefreshing(<Module>.smethod_9(), gstruct240_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A58 File Offset: 0x00000C58
		internal static void smethod_13(GStruct240 gstruct240_0)
		{
			GClass0.smethod_23(gstruct240_0);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A6C File Offset: 0x00000C6C
		internal static void smethod_14(GStruct240 gstruct240_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmakingServers_CancelQuery(<Module>.smethod_9(), gstruct240_0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002A8C File Offset: 0x00000C8C
		public static GStruct248 smethod_15(uint uint_0, ushort ushort_0, GClass44 gclass44_0)
		{
			GClass78.smethod_1();
			return GStruct248.smethod_3(Class177.SteamAPI_ISteamMatchmakingServers_ServerRules(<Module>.smethod_9(), uint_0, ushort_0, GClass44.smethod_0(gclass44_0)));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002AB8 File Offset: 0x00000CB8
		internal static void smethod_16(GStruct240 gstruct240_0)
		{
			GClass0.smethod_26(gstruct240_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002ACC File Offset: 0x00000CCC
		public static void smethod_17(GStruct240 gstruct240_0)
		{
			GClass0.smethod_2(gstruct240_0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002AE0 File Offset: 0x00000CE0
		internal static void smethod_18(GStruct248 gstruct248_0)
		{
			GClass0.smethod_8(gstruct248_0);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002AF4 File Offset: 0x00000CF4
		internal static void smethod_19(GStruct240 gstruct240_0, int int_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmakingServers_RefreshServer(<Module>.smethod_9(), gstruct240_0, int_0);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002B14 File Offset: 0x00000D14
		internal static void smethod_20(GStruct240 gstruct240_0, int int_0)
		{
			GClass0.smethod_19(gstruct240_0, int_0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002B28 File Offset: 0x00000D28
		public static GClass81 smethod_21(GStruct240 gstruct240_0, int int_0)
		{
			GClass78.smethod_1();
			return (GClass81)Marshal.PtrToStructure(Class177.SteamAPI_ISteamMatchmakingServers_GetServerDetails(<Module>.smethod_9(), gstruct240_0, int_0), typeof(GClass81));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B5C File Offset: 0x00000D5C
		public static int smethod_22(GStruct240 gstruct240_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmakingServers_GetServerCount(<Module>.smethod_9(), gstruct240_0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B7C File Offset: 0x00000D7C
		internal static void smethod_23(GStruct240 gstruct240_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmakingServers_RefreshQuery(<Module>.smethod_9(), gstruct240_0);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B9C File Offset: 0x00000D9C
		public static void smethod_24(GStruct240 gstruct240_0, int int_0)
		{
			GClass0.smethod_20(gstruct240_0, int_0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public static GStruct240 smethod_25(GStruct66 gstruct66_0, GStruct44[] gstruct44_0, uint uint_0, GClass22 gclass22_0)
		{
			GClass78.smethod_1();
			return GStruct240.smethod_2(Class177.SteamAPI_ISteamMatchmakingServers_RequestInternetServerList(<Module>.smethod_9(), gstruct66_0, GClass38.smethod_0(new GClass38(gstruct44_0)), uint_0, GClass22.smethod_0(gclass22_0)));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002BE8 File Offset: 0x00000DE8
		internal static void smethod_26(GStruct240 gstruct240_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmakingServers_ReleaseRequest(<Module>.smethod_9(), gstruct240_0);
		}
	}
}
