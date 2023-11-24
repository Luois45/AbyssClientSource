using System;
using ns226;
using ns348;
using ns370;

namespace ns115
{
	// Token: 0x020000B8 RID: 184
	public static class GClass54
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00018E50 File Offset: 0x00017050
		internal static void smethod_0()
		{
			GClass54.smethod_3();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00018E64 File Offset: 0x00017064
		public static void smethod_1()
		{
			GClass54.smethod_13();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00018E78 File Offset: 0x00017078
		internal static void smethod_2()
		{
			GClass54.smethod_14();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00018E8C File Offset: 0x0001708C
		internal static void smethod_3()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMusic_PlayNext(<Module>.smethod_17());
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00018EA8 File Offset: 0x000170A8
		public static void smethod_4()
		{
			GClass54.smethod_0();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00018EBC File Offset: 0x000170BC
		public static void smethod_5(float float_0)
		{
			GClass54.smethod_6(float_0);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00018ED0 File Offset: 0x000170D0
		internal static void smethod_6(float float_0)
		{
			GClass54.smethod_7(float_0);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00018EE4 File Offset: 0x000170E4
		internal static void smethod_7(float float_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMusic_SetVolume(<Module>.smethod_17(), float_0);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00018F04 File Offset: 0x00017104
		public static bool smethod_8()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusic_BIsPlaying(<Module>.smethod_17());
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00018F20 File Offset: 0x00017120
		public static bool smethod_9()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusic_BIsEnabled(<Module>.smethod_17());
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00018F3C File Offset: 0x0001713C
		public static float smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusic_GetVolume(<Module>.smethod_17());
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00018F5C File Offset: 0x0001715C
		public static void smethod_11()
		{
			GClass54.smethod_12();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00018F70 File Offset: 0x00017170
		internal static void smethod_12()
		{
			GClass54.smethod_16();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00018F84 File Offset: 0x00017184
		internal static void smethod_13()
		{
			GClass54.smethod_18();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00018F98 File Offset: 0x00017198
		internal static void smethod_14()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMusic_Pause(<Module>.smethod_17());
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00018FB4 File Offset: 0x000171B4
		public static GEnum68 smethod_15()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusic_GetPlaybackStatus(<Module>.smethod_17());
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018FD4 File Offset: 0x000171D4
		internal static void smethod_16()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMusic_PlayPrevious(<Module>.smethod_17());
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00018FF0 File Offset: 0x000171F0
		public static void smethod_17()
		{
			GClass54.smethod_2();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00019004 File Offset: 0x00017204
		internal static void smethod_18()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMusic_Play(<Module>.smethod_17());
		}
	}
}
