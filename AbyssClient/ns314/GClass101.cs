using System;
using ns140;
using ns151;
using ns226;
using ns236;
using ns370;

namespace ns314
{
	// Token: 0x02000278 RID: 632
	public static class GClass101
	{
		// Token: 0x06001CC6 RID: 7366 RVA: 0x00091084 File Offset: 0x0008F284
		public static void smethod_0()
		{
			GClass101.smethod_13();
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00091098 File Offset: 0x0008F298
		internal static void smethod_1()
		{
			GClass78.smethod_5();
			Class177.SteamAPI_ReleaseCurrentThreadMemory();
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000910B0 File Offset: 0x0008F2B0
		public static void smethod_2()
		{
			GClass101.smethod_5();
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000910C4 File Offset: 0x0008F2C4
		public static bool smethod_3()
		{
			GClass78.smethod_5();
			return Class177.SteamAPI_IsSteamRunning();
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000910DC File Offset: 0x0008F2DC
		public static bool smethod_4(GStruct66 gstruct66_0)
		{
			GClass78.smethod_5();
			return Class177.SteamAPI_RestartAppIfNecessary(gstruct66_0);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000910F4 File Offset: 0x0008F2F4
		internal static void smethod_5()
		{
			GClass101.smethod_9();
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00091108 File Offset: 0x0008F308
		public static bool smethod_6()
		{
			GClass78.smethod_5();
			bool result;
			if (result = Class177.SteamAPI_Init())
			{
				result = <Module>.smethod_1();
			}
			return result;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0009112C File Offset: 0x0008F32C
		public static GStruct58 smethod_7()
		{
			GClass78.smethod_5();
			return GStruct58.smethod_3(Class177.Steam_GetHSteamUserCurrent());
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0009114C File Offset: 0x0008F34C
		internal static void smethod_8()
		{
			GClass101.smethod_14();
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00091160 File Offset: 0x0008F360
		internal static void smethod_9()
		{
			GClass78.smethod_5();
			Class177.SteamAPI_RunCallbacks();
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00091178 File Offset: 0x0008F378
		public static void smethod_10()
		{
			GClass101.smethod_8();
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0009118C File Offset: 0x0008F38C
		public static GStruct128 smethod_11()
		{
			GClass78.smethod_5();
			return GStruct128.smethod_0(Class177.SteamAPI_GetHSteamPipe());
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000911AC File Offset: 0x0008F3AC
		public static GStruct58 smethod_12()
		{
			GClass78.smethod_5();
			return GStruct58.smethod_3(Class177.SteamAPI_GetHSteamUser());
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000911CC File Offset: 0x0008F3CC
		internal static void smethod_13()
		{
			GClass101.smethod_1();
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000911E0 File Offset: 0x0008F3E0
		internal static void smethod_14()
		{
			GClass78.smethod_5();
			Class177.SteamAPI_Shutdown();
		}
	}
}
