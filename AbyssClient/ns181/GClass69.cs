using System;
using System.Runtime.InteropServices;
using ns152;
using ns203;
using ns226;
using ns266;
using ns286;
using ns323;
using ns370;
using ns387;
using ns489;
using ns52;
using ns54;
using ns554;

namespace ns181
{
	// Token: 0x02000124 RID: 292
	public static class GClass69
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x000290DC File Offset: 0x000272DC
		public static bool smethod_0(string string_0, out float float_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetAchievementAchievedPercent(<Module>.smethod_7(), gclass, out float_0);
			}
			return result;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00029120 File Offset: 0x00027320
		public static bool smethod_1(string string_0, out bool bool_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetAchievement(<Module>.smethod_7(), gclass, out bool_0);
			}
			return result;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00029164 File Offset: 0x00027364
		public static string smethod_2(GStruct305 gstruct305_0)
		{
			return GClass69.smethod_28(gstruct305_0);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00029178 File Offset: 0x00027378
		public static int smethod_3(string string_0, long[] long_0, uint uint_0)
		{
			GClass78.smethod_1();
			int result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetGlobalStatHistory(<Module>.smethod_7(), gclass, long_0, uint_0);
			}
			return result;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000291C0 File Offset: 0x000273C0
		public static bool smethod_4(string string_0, int int_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_SetStat(<Module>.smethod_7(), gclass, int_0);
			}
			return result;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00029204 File Offset: 0x00027404
		public static bool smethod_5()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_StoreStats(<Module>.smethod_7());
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00029220 File Offset: 0x00027420
		public static bool smethod_6(string string_0, out long long_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetGlobalStat(<Module>.smethod_7(), gclass, out long_0);
			}
			return result;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00029264 File Offset: 0x00027464
		public static GStruct241 smethod_7(GStruct305 gstruct305_0, GEnum24 genum24_0, int int_0, int int_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_DownloadLeaderboardEntries(<Module>.smethod_7(), gstruct305_0, genum24_0, int_0, int_1));
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0002928C File Offset: 0x0002748C
		public static int smethod_8(string string_0)
		{
			GClass78.smethod_1();
			int result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetAchievementIcon(<Module>.smethod_7(), gclass);
			}
			return result;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000292D0 File Offset: 0x000274D0
		public static bool smethod_9(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_ResetAllStats(<Module>.smethod_7(), bool_0);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000292F0 File Offset: 0x000274F0
		public static uint smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_GetNumAchievements(<Module>.smethod_7());
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00029310 File Offset: 0x00027510
		internal static string smethod_11(uint uint_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUserStats_GetAchievementName(<Module>.smethod_7(), uint_0));
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00029334 File Offset: 0x00027534
		public static bool smethod_12(GStruct22 gstruct22_0, string string_0, out int int_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetUserStat(<Module>.smethod_7(), gstruct22_0, gclass, out int_0);
			}
			return result;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00029378 File Offset: 0x00027578
		public static GStruct241 smethod_13(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_RequestUserStats(<Module>.smethod_7(), gstruct22_0));
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002939C File Offset: 0x0002759C
		public static string smethod_14(uint uint_0)
		{
			return GClass69.smethod_21(uint_0);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000293B0 File Offset: 0x000275B0
		public static int smethod_15(string string_0, double[] double_0, uint uint_0)
		{
			GClass78.smethod_1();
			int result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetGlobalStatHistory0(<Module>.smethod_7(), gclass, double_0, uint_0);
			}
			return result;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000293F8 File Offset: 0x000275F8
		public static GEnum61 smethod_16(GStruct305 gstruct305_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_GetLeaderboardSortMethod(<Module>.smethod_7(), gstruct305_0);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00029418 File Offset: 0x00027618
		public static bool smethod_17(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_ClearAchievement(<Module>.smethod_7(), gclass);
			}
			return result;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002945C File Offset: 0x0002765C
		public static string smethod_18(string string_0, string string_1)
		{
			return GClass69.smethod_30(string_0, string_1);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00029470 File Offset: 0x00027670
		public static GEnum49 smethod_19(GStruct305 gstruct305_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_GetLeaderboardDisplayType(<Module>.smethod_7(), gstruct305_0);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00029490 File Offset: 0x00027690
		public static GStruct241 smethod_20(int int_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_RequestGlobalStats(<Module>.smethod_7(), int_0));
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000294B4 File Offset: 0x000276B4
		internal static string smethod_21(uint uint_0)
		{
			return GClass69.smethod_11(uint_0);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000294C8 File Offset: 0x000276C8
		public static int smethod_22(int int_0, out string string_0, uint uint_0, out float float_0, out bool bool_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			int num = Class177.SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo(<Module>.smethod_7(), int_0, intPtr, uint_0, out float_0, out bool_0);
			string_0 = ((num != -1) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002950C File Offset: 0x0002770C
		internal static string smethod_23(GStruct305 gstruct305_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamUserStats_GetLeaderboardName(<Module>.smethod_7(), gstruct305_0));
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00029530 File Offset: 0x00027730
		public static int smethod_24(out string string_0, uint uint_0, out float float_0, out bool bool_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			int num = Class177.SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo(<Module>.smethod_7(), intPtr, uint_0, out float_0, out bool_0);
			string_0 = ((num != -1) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00029570 File Offset: 0x00027770
		public static int smethod_25(GStruct305 gstruct305_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_GetLeaderboardEntryCount(<Module>.smethod_7(), gstruct305_0);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00029590 File Offset: 0x00027790
		public static bool smethod_26(GStruct22 gstruct22_0, string string_0, out float float_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetUserStat0(<Module>.smethod_7(), gstruct22_0, gclass, out float_0);
			}
			return result;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000295D4 File Offset: 0x000277D4
		public static bool smethod_27(string string_0, out bool bool_0, out uint uint_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(<Module>.smethod_7(), gclass, out bool_0, out uint_0);
			}
			return result;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00029618 File Offset: 0x00027818
		internal static string smethod_28(GStruct305 gstruct305_0)
		{
			return GClass69.smethod_23(gstruct305_0);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002962C File Offset: 0x0002782C
		public static bool smethod_29(GStruct22 gstruct22_0, string string_0, out bool bool_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetUserAchievement(<Module>.smethod_7(), gstruct22_0, gclass, out bool_0);
			}
			return result;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00029670 File Offset: 0x00027870
		internal static string smethod_30(string string_0, string string_1)
		{
			return GClass69.smethod_48(string_0, string_1);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00029684 File Offset: 0x00027884
		public static GStruct241 smethod_31(GStruct305 gstruct305_0, GEnum83 genum83_0, int int_0, int[] int_1, int int_2)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_UploadLeaderboardScore(<Module>.smethod_7(), gstruct305_0, genum83_0, int_0, int_1, int_2));
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000296B0 File Offset: 0x000278B0
		public static bool smethod_32(string string_0, float float_0, double double_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_UpdateAvgRateStat(<Module>.smethod_7(), gclass, float_0, double_0);
			}
			return result;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000296F4 File Offset: 0x000278F4
		public static bool smethod_33(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_SetAchievement(<Module>.smethod_7(), gclass);
			}
			return result;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00029738 File Offset: 0x00027938
		public static bool smethod_34(string string_0, uint uint_0, uint uint_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_IndicateAchievementProgress(<Module>.smethod_7(), gclass, uint_0, uint_1);
			}
			return result;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002977C File Offset: 0x0002797C
		public static bool smethod_35(string string_0, out float float_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetStat0(<Module>.smethod_7(), gclass, out float_0);
			}
			return result;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000297C0 File Offset: 0x000279C0
		public static bool smethod_36(string string_0, out int int_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetStat(<Module>.smethod_7(), gclass, out int_0);
			}
			return result;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00029804 File Offset: 0x00027A04
		public static GStruct241 smethod_37(GStruct305 gstruct305_0, GStruct96 gstruct96_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_AttachLeaderboardUGC(<Module>.smethod_7(), gstruct305_0, gstruct96_0));
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002982C File Offset: 0x00027A2C
		public static bool smethod_38(GStruct22 gstruct22_0, string string_0, out bool bool_0, out uint uint_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime(<Module>.smethod_7(), gstruct22_0, gclass, out bool_0, out uint_0);
			}
			return result;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00029874 File Offset: 0x00027A74
		public static bool smethod_39(string string_0, float float_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_SetStat0(<Module>.smethod_7(), gclass, float_0);
			}
			return result;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000298B8 File Offset: 0x00027AB8
		public static GStruct241 smethod_40(string string_0, GEnum61 genum61_0, GEnum49 genum49_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_FindOrCreateLeaderboard(<Module>.smethod_7(), gclass, genum61_0, genum49_0));
			}
			return result;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00029904 File Offset: 0x00027B04
		public static GStruct241 smethod_41(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_FindLeaderboard(<Module>.smethod_7(), gclass));
			}
			return result;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00029950 File Offset: 0x00027B50
		public static GStruct241 smethod_42(GStruct305 gstruct305_0, GStruct22[] gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers(<Module>.smethod_7(), gstruct305_0, gstruct22_0, int_0));
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00029978 File Offset: 0x00027B78
		public static bool smethod_43(string string_0, out double double_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUserStats_GetGlobalStat0(<Module>.smethod_7(), gclass, out double_0);
			}
			return result;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000299BC File Offset: 0x00027BBC
		public static GStruct241 smethod_44()
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers(<Module>.smethod_7()));
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000299E0 File Offset: 0x00027BE0
		public static bool smethod_45(GStruct193 gstruct193_0, int int_0, out GStruct21 gstruct21_0, int[] int_1, int int_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry(<Module>.smethod_7(), gstruct193_0, int_0, out gstruct21_0, int_1, int_2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00029A04 File Offset: 0x00027C04
		public static bool smethod_46()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUserStats_RequestCurrentStats(<Module>.smethod_7());
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00029A20 File Offset: 0x00027C20
		public static GStruct241 smethod_47()
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages(<Module>.smethod_7()));
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00029A44 File Offset: 0x00027C44
		internal static string smethod_48(string string_0, string string_1)
		{
			GClass78.smethod_1();
			string result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = GClass78.smethod_0(Class177.SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(<Module>.smethod_7(), gclass, gclass2));
				}
			}
			return result;
		}
	}
}
