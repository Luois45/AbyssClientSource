using System;
using ns169;
using ns207;
using ns226;
using ns370;
using ns506;
using ns54;

namespace ns81
{
	// Token: 0x0200005A RID: 90
	public static class GClass42
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000AA3C File Offset: 0x00008C3C
		public static bool smethod_0(GStruct277 gstruct277_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamScreenshots_SetLocation(<Module>.smethod_12(), gstruct277_0, gclass);
			}
			return result;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000AA80 File Offset: 0x00008C80
		public static GStruct277 smethod_1(GEnum37 genum37_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			GStruct277 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = GStruct277.smethod_3(Class177.SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary(<Module>.smethod_12(), genum37_0, gclass, gclass2));
				}
			}
			return result;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public static bool smethod_2(GStruct277 gstruct277_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamScreenshots_TagPublishedFile(<Module>.smethod_12(), gstruct277_0, gstruct78_0);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000AB0C File Offset: 0x00008D0C
		public static GStruct277 smethod_3(byte[] byte_0, uint uint_0, int int_0, int int_1)
		{
			GClass78.smethod_1();
			return GStruct277.smethod_3(Class177.SteamAPI_ISteamScreenshots_WriteScreenshot(<Module>.smethod_12(), byte_0, uint_0, int_0, int_1));
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000AB34 File Offset: 0x00008D34
		public static bool smethod_4(GStruct277 gstruct277_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamScreenshots_TagUser(<Module>.smethod_12(), gstruct277_0, gstruct22_0);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000AB54 File Offset: 0x00008D54
		public static GStruct277 smethod_5(string string_0, string string_1, int int_0, int int_1)
		{
			GClass78.smethod_1();
			GStruct277 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = GStruct277.smethod_3(Class177.SteamAPI_ISteamScreenshots_AddScreenshotToLibrary(<Module>.smethod_12(), gclass, gclass2, int_0, int_1));
				}
			}
			return result;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public static void smethod_6()
		{
			GClass42.smethod_11();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		internal static void smethod_7(bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamScreenshots_HookScreenshots(<Module>.smethod_12(), bool_0);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		public static void smethod_8(bool bool_0)
		{
			GClass42.smethod_9(bool_0);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000AC08 File Offset: 0x00008E08
		internal static void smethod_9(bool bool_0)
		{
			GClass42.smethod_7(bool_0);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000AC1C File Offset: 0x00008E1C
		public static bool smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamScreenshots_IsScreenshotsHooked(<Module>.smethod_12());
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000AC38 File Offset: 0x00008E38
		internal static void smethod_11()
		{
			GClass42.smethod_12();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000AC4C File Offset: 0x00008E4C
		internal static void smethod_12()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamScreenshots_TriggerScreenshot(<Module>.smethod_12());
		}
	}
}
