using System;
using ns117;
using ns140;
using ns226;
using ns236;
using ns336;
using ns370;

namespace ns133
{
	// Token: 0x020000CC RID: 204
	public static class GClass57
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x0001A03C File Offset: 0x0001823C
		public static bool smethod_0(GStruct128 gstruct128_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamClient_BReleaseSteamPipe(<Module>.smethod_2(), gstruct128_0);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001A05C File Offset: 0x0001825C
		public static IntPtr smethod_1(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGameServerStats(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001A0A4 File Offset: 0x000182A4
		public static IntPtr smethod_2(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamHTMLSurface(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001A0EC File Offset: 0x000182EC
		public static void smethod_3(uint uint_0, ushort ushort_0)
		{
			GClass57.smethod_20(uint_0, ushort_0);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001A100 File Offset: 0x00018300
		public static GStruct58 smethod_4(GStruct128 gstruct128_0)
		{
			GClass78.smethod_1();
			return GStruct58.smethod_3(Class177.SteamAPI_ISteamClient_ConnectToGlobalUser(<Module>.smethod_2(), gstruct128_0));
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001A124 File Offset: 0x00018324
		public static IntPtr smethod_5(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGameServer(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001A16C File Offset: 0x0001836C
		public static IntPtr smethod_6(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUser(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001A1B4 File Offset: 0x000183B4
		public static IntPtr smethod_7(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMusicRemote(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001A1FC File Offset: 0x000183FC
		public static IntPtr smethod_8(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamApps(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001A244 File Offset: 0x00018444
		public static IntPtr smethod_9(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUGC(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001A28C File Offset: 0x0001848C
		public static IntPtr smethod_10(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamAppList(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001A2D4 File Offset: 0x000184D4
		public static IntPtr smethod_11(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMusic(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001A31C File Offset: 0x0001851C
		public static bool smethod_12()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamClient_BShutdownIfAllPipesClosed(<Module>.smethod_2());
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001A338 File Offset: 0x00018538
		public static uint smethod_13()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamClient_GetIPCCallCount(<Module>.smethod_2());
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001A358 File Offset: 0x00018558
		public static GStruct128 smethod_14()
		{
			GClass78.smethod_1();
			return GStruct128.smethod_0(Class177.SteamAPI_ISteamClient_CreateSteamPipe(<Module>.smethod_2()));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001A37C File Offset: 0x0001857C
		public static GStruct58 smethod_15(out GStruct128 gstruct128_0, GEnum65 genum65_0)
		{
			GClass78.smethod_1();
			return GStruct58.smethod_3(Class177.SteamAPI_ISteamClient_CreateLocalUser(<Module>.smethod_2(), out gstruct128_0, genum65_0));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001A3A4 File Offset: 0x000185A4
		public static IntPtr smethod_16(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamHTTP(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001A3EC File Offset: 0x000185EC
		internal static void smethod_17(GDelegate17 gdelegate17_0)
		{
			GClass57.smethod_30(gdelegate17_0);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001A400 File Offset: 0x00018600
		internal static void smethod_18(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass57.smethod_37(gstruct128_0, gstruct58_0);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001A414 File Offset: 0x00018614
		public static void smethod_19(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass57.smethod_18(gstruct128_0, gstruct58_0);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001A428 File Offset: 0x00018628
		internal static void smethod_20(uint uint_0, ushort ushort_0)
		{
			GClass57.smethod_28(uint_0, ushort_0);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001A43C File Offset: 0x0001863C
		public static IntPtr smethod_21(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMatchmakingServers(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001A484 File Offset: 0x00018684
		public static IntPtr smethod_22(GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUtils(<Module>.smethod_2(), gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001A4CC File Offset: 0x000186CC
		public static IntPtr smethod_23(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamParentalSettings(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001A514 File Offset: 0x00018714
		public static IntPtr smethod_24(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamVideo(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001A55C File Offset: 0x0001875C
		public static IntPtr smethod_25(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamMatchmaking(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001A5A4 File Offset: 0x000187A4
		public static IntPtr smethod_26(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamFriends(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001A5EC File Offset: 0x000187EC
		public static IntPtr smethod_27(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamNetworking(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001A634 File Offset: 0x00018834
		internal static void smethod_28(uint uint_0, ushort ushort_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamClient_SetLocalIPBinding(<Module>.smethod_2(), uint_0, ushort_0);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001A654 File Offset: 0x00018854
		public static IntPtr smethod_29(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamScreenshots(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001A69C File Offset: 0x0001889C
		internal static void smethod_30(GDelegate17 gdelegate17_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamClient_SetWarningMessageHook(<Module>.smethod_2(), gdelegate17_0);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001A6BC File Offset: 0x000188BC
		public static IntPtr smethod_31(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamUserStats(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001A704 File Offset: 0x00018904
		public static IntPtr smethod_32(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamGenericInterface(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001A74C File Offset: 0x0001894C
		public static void smethod_33(GDelegate17 gdelegate17_0)
		{
			GClass57.smethod_17(gdelegate17_0);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001A760 File Offset: 0x00018960
		public static IntPtr smethod_34(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamRemoteStorage(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001A7A8 File Offset: 0x000189A8
		public static IntPtr smethod_35(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamInventory(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001A7F0 File Offset: 0x000189F0
		public static IntPtr smethod_36(GStruct58 gstruct58_0, GStruct128 gstruct128_0, string string_0)
		{
			GClass78.smethod_1();
			IntPtr result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamClient_GetISteamController(<Module>.smethod_2(), gstruct58_0, gstruct128_0, gclass);
			}
			return result;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001A838 File Offset: 0x00018A38
		internal static void smethod_37(GStruct128 gstruct128_0, GStruct58 gstruct58_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamClient_ReleaseUser(<Module>.smethod_2(), gstruct128_0, gstruct58_0);
		}
	}
}
