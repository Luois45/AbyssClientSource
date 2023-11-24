using System;
using ns117;
using ns140;
using ns226;
using ns236;
using ns336;
using ns370;
using ns381;

namespace ns313
{
	// Token: 0x02000277 RID: 631
	public static class GClass100
	{
		// Token: 0x06001CA0 RID: 7328 RVA: 0x00090868 File Offset: 0x0008EA68
		public static GStruct58 smethod_0(out GStruct128 gstruct128_0, GEnum65 genum65_0)
		{
			GClass78.smethod_2();
			return GStruct58.smethod_3(Class177.SteamAPI_ISteamClient_CreateLocalUser(Class180.smethod_10(), out gstruct128_0, genum65_0));
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00090890 File Offset: 0x0008EA90
		public static IntPtr smethod_1(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMusicRemote(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000908D8 File Offset: 0x0008EAD8
		public static IntPtr smethod_2(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamHTMLSurface(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00090920 File Offset: 0x0008EB20
		internal static void smethod_3(uint uint_0, ushort ushort_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamClient_SetLocalIPBinding(Class180.smethod_10(), uint_0, ushort_0);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00090940 File Offset: 0x0008EB40
		public static IntPtr smethod_4(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMatchmakingServers(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00090988 File Offset: 0x0008EB88
		public static IntPtr smethod_5(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamController(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000909D0 File Offset: 0x0008EBD0
		public static bool smethod_6()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamClient_BShutdownIfAllPipesClosed(Class180.smethod_10());
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x000909EC File Offset: 0x0008EBEC
		public static IntPtr smethod_7(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamVideo(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00090A34 File Offset: 0x0008EC34
		public static IntPtr smethod_8(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamFriends(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00090A7C File Offset: 0x0008EC7C
		public static IntPtr smethod_9(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGameServerStats(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00090AC4 File Offset: 0x0008ECC4
		public static IntPtr smethod_10(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamApps(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00090B0C File Offset: 0x0008ED0C
		public static IntPtr smethod_11(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGameServer(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00090B54 File Offset: 0x0008ED54
		public static IntPtr smethod_12(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUser(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00090B9C File Offset: 0x0008ED9C
		public static GStruct128 smethod_13()
		{
			GClass78.smethod_2();
			return GStruct128.smethod_0(Class177.SteamAPI_ISteamClient_CreateSteamPipe(Class180.smethod_10()));
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00090BC0 File Offset: 0x0008EDC0
		public static void smethod_14(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass100.smethod_24(gstruct128_0, gstruct58_0);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00090BD4 File Offset: 0x0008EDD4
		public static void smethod_15(GDelegate17 gdelegate17_0)
		{
			GClass100.smethod_18(gdelegate17_0);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00090BE8 File Offset: 0x0008EDE8
		public static IntPtr smethod_16(GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUtils(Class180.smethod_10(), gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00090C30 File Offset: 0x0008EE30
		public static IntPtr smethod_17(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUserStats(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00090C78 File Offset: 0x0008EE78
		internal static void smethod_18(GDelegate17 gdelegate17_0)
		{
			GClass100.smethod_28(gdelegate17_0);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00090C8C File Offset: 0x0008EE8C
		public static IntPtr smethod_19(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamAppList(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00090CD4 File Offset: 0x0008EED4
		public static GStruct58 smethod_20(GStruct128 gstruct128_0)
		{
			GClass78.smethod_2();
			return GStruct58.smethod_3(Class177.SteamAPI_ISteamClient_ConnectToGlobalUser(Class180.smethod_10(), gstruct128_0));
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00090CF8 File Offset: 0x0008EEF8
		public static IntPtr smethod_21(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUGC(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00090D40 File Offset: 0x0008EF40
		public static bool smethod_22(GStruct128 gstruct128_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamClient_BReleaseSteamPipe(Class180.smethod_10(), gstruct128_0);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00090D60 File Offset: 0x0008EF60
		public static IntPtr smethod_23(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMusic(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00090DA8 File Offset: 0x0008EFA8
		internal static void smethod_24(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass100.smethod_37(gstruct128_0, gstruct58_0);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00090DBC File Offset: 0x0008EFBC
		public static IntPtr smethod_25(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamHTTP(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00090E04 File Offset: 0x0008F004
		public static IntPtr smethod_26(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamParentalSettings(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00090E4C File Offset: 0x0008F04C
		public static IntPtr smethod_27(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMatchmaking(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00090E94 File Offset: 0x0008F094
		internal static void smethod_28(GDelegate17 gdelegate17_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamClient_SetWarningMessageHook(Class180.smethod_10(), gdelegate17_0);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00090EB4 File Offset: 0x0008F0B4
		internal static void smethod_29(uint uint_0, ushort ushort_0)
		{
			GClass100.smethod_3(uint_0, ushort_0);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00090EC8 File Offset: 0x0008F0C8
		public static uint smethod_30()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamClient_GetIPCCallCount(Class180.smethod_10());
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00090EE8 File Offset: 0x0008F0E8
		public static IntPtr smethod_31(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamInventory(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00090F30 File Offset: 0x0008F130
		public static IntPtr smethod_32(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamScreenshots(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00090F78 File Offset: 0x0008F178
		public static IntPtr smethod_33(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGenericInterface(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00090FC0 File Offset: 0x0008F1C0
		public static IntPtr smethod_34(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamNetworking(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00091008 File Offset: 0x0008F208
		public static void smethod_35(uint uint_0, ushort ushort_0)
		{
			GClass100.smethod_29(uint_0, ushort_0);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0009101C File Offset: 0x0008F21C
		public static IntPtr smethod_36(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_2();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamRemoteStorage(Class180.smethod_10(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00091064 File Offset: 0x0008F264
		internal static void smethod_37(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamClient_ReleaseUser(Class180.smethod_10(), gstruct128_0, gstruct58_0);
		}
	}
}
