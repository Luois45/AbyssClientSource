using System;
using System.Runtime.InteropServices;
using ns151;
using ns226;
using ns370;

namespace ns149
{
	// Token: 0x020000FB RID: 251
	public static class GClass60
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0002183C File Offset: 0x0001FA3C
		internal static void smethod_0(GStruct66 gstruct66_0)
		{
			GClass60.smethod_2(gstruct66_0);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00021850 File Offset: 0x0001FA50
		public static bool smethod_1(out int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamVideo_IsBroadcasting(<Module>.smethod_21(), out int_0);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00021870 File Offset: 0x0001FA70
		internal static void smethod_2(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamVideo_GetOPFSettings(<Module>.smethod_21(), gstruct66_0);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00021890 File Offset: 0x0001FA90
		public static void smethod_3(GStruct66 gstruct66_0)
		{
			GClass60.smethod_4(gstruct66_0);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000218A4 File Offset: 0x0001FAA4
		internal static void smethod_4(GStruct66 gstruct66_0)
		{
			GClass60.smethod_7(gstruct66_0);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000218B8 File Offset: 0x0001FAB8
		public static bool smethod_5(GStruct66 gstruct66_0, out string string_0, ref int int_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_0);
			bool flag = Class177.SteamAPI_ISteamVideo_GetOPFStringForApp(<Module>.smethod_21(), gstruct66_0, intPtr, ref int_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000218F8 File Offset: 0x0001FAF8
		public static void smethod_6(GStruct66 gstruct66_0)
		{
			GClass60.smethod_0(gstruct66_0);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002190C File Offset: 0x0001FB0C
		internal static void smethod_7(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamVideo_GetVideoURL(<Module>.smethod_21(), gstruct66_0);
		}
	}
}
