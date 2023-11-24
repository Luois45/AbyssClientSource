using System;
using ns226;
using ns370;
using ns381;
using ns387;
using ns54;

namespace ns100
{
	// Token: 0x02000085 RID: 133
	public static class GClass46
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x0000FE08 File Offset: 0x0000E008
		public static bool smethod_0(GStruct22 gstruct22_0, string string_0, out int int_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_GetUserStat(Class180.smethod_8(), gstruct22_0, gclass, out int_0);
			}
			return result;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public static GStruct241 smethod_1(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamGameServerStats_RequestUserStats(Class180.smethod_8(), gstruct22_0));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000FE70 File Offset: 0x0000E070
		public static bool smethod_2(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_ClearUserAchievement(Class180.smethod_8(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		public static bool smethod_3(GStruct22 gstruct22_0, string string_0, int int_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_SetUserStat(Class180.smethod_8(), gstruct22_0, gclass, int_0);
			}
			return result;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		public static bool smethod_4(GStruct22 gstruct22_0, string string_0, out bool bool_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_GetUserAchievement(Class180.smethod_8(), gstruct22_0, gclass, out bool_0);
			}
			return result;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000FF3C File Offset: 0x0000E13C
		public static bool smethod_5(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_SetUserAchievement(Class180.smethod_8(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000FF80 File Offset: 0x0000E180
		public static bool smethod_6(GStruct22 gstruct22_0, string string_0, float float_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_SetUserStat0(Class180.smethod_8(), gstruct22_0, gclass, float_0);
			}
			return result;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
		public static bool smethod_7(GStruct22 gstruct22_0, string string_0, float float_0, double double_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat(Class180.smethod_8(), gstruct22_0, gclass, float_0, double_0);
			}
			return result;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001000C File Offset: 0x0000E20C
		public static bool smethod_8(GStruct22 gstruct22_0, string string_0, out float float_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServerStats_GetUserStat0(Class180.smethod_8(), gstruct22_0, gclass, out float_0);
			}
			return result;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00010050 File Offset: 0x0000E250
		public static GStruct241 smethod_9(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamGameServerStats_StoreUserStats(Class180.smethod_8(), gstruct22_0));
		}
	}
}
