using System;
using ns140;
using ns226;
using ns236;
using ns370;
using ns381;
using ns54;
using ns96;

namespace ns232
{
	// Token: 0x020001AA RID: 426
	public static class GClass82
	{
		// Token: 0x06001001 RID: 4097 RVA: 0x000551C0 File Offset: 0x000533C0
		internal static void smethod_0()
		{
			GClass78.smethod_5();
			Class177.SteamGameServer_ReleaseCurrentThreadMemory();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000551D8 File Offset: 0x000533D8
		public static GStruct58 smethod_1()
		{
			GClass78.smethod_5();
			return GStruct58.smethod_3(Class177.SteamGameServer_GetHSteamUser());
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000551F8 File Offset: 0x000533F8
		internal static void smethod_2()
		{
			GClass82.smethod_8();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0005520C File Offset: 0x0005340C
		internal static void smethod_3()
		{
			GClass82.smethod_0();
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00055220 File Offset: 0x00053420
		public static bool smethod_4(uint uint_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, GEnum14 genum14_0, string string_0)
		{
			GClass78.smethod_5();
			bool flag;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				flag = Class177.SteamGameServer_InitSafe(uint_0, ushort_0, ushort_1, ushort_2, genum14_0, gclass);
			}
			if (flag)
			{
				flag = Class180.smethod_1();
			}
			return flag;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00055270 File Offset: 0x00053470
		public static void smethod_5()
		{
			GClass82.smethod_6();
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00055284 File Offset: 0x00053484
		internal static void smethod_6()
		{
			GClass82.smethod_13();
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00055298 File Offset: 0x00053498
		public static GStruct22 smethod_7()
		{
			GClass78.smethod_5();
			return GStruct22.smethod_0(Class177.SteamGameServer_GetSteamID());
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000552B8 File Offset: 0x000534B8
		internal static void smethod_8()
		{
			GClass78.smethod_5();
			Class177.SteamGameServer_RunCallbacks();
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000552D0 File Offset: 0x000534D0
		public static void smethod_9()
		{
			GClass82.smethod_2();
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000552E4 File Offset: 0x000534E4
		public static GStruct128 smethod_10()
		{
			GClass78.smethod_5();
			return GStruct128.smethod_0(Class177.SteamGameServer_GetHSteamPipe());
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00055304 File Offset: 0x00053504
		public static void smethod_11()
		{
			GClass82.smethod_3();
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00055318 File Offset: 0x00053518
		public static bool smethod_12()
		{
			GClass78.smethod_5();
			return Class177.SteamGameServer_BSecure();
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00055330 File Offset: 0x00053530
		internal static void smethod_13()
		{
			GClass78.smethod_5();
			Class177.SteamGameServer_Shutdown();
			Class180.smethod_2();
		}
	}
}
