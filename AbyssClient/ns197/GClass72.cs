using System;
using System.Runtime.InteropServices;
using ns151;
using ns226;
using ns370;

namespace ns197
{
	// Token: 0x0200013E RID: 318
	public static class GClass72
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		public static uint smethod_0(GStruct66[] gstruct66_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamAppList_GetInstalledApps(<Module>.smethod_16(), gstruct66_0, uint_0);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		public static uint smethod_1()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamAppList_GetNumInstalledApps(<Module>.smethod_16());
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002E614 File Offset: 0x0002C814
		public static int smethod_2(GStruct66 gstruct66_0, out string string_0, int int_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_0);
			int num = Class177.SteamAPI_ISteamAppList_GetAppInstallDir(<Module>.smethod_16(), gstruct66_0, intPtr, int_0);
			string_0 = ((num != -1) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0002E654 File Offset: 0x0002C854
		public static int smethod_3(GStruct66 gstruct66_0, out string string_0, int int_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_0);
			int num = Class177.SteamAPI_ISteamAppList_GetAppName(<Module>.smethod_16(), gstruct66_0, intPtr, int_0);
			string_0 = ((num != -1) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0002E694 File Offset: 0x0002C894
		public static int smethod_4(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamAppList_GetAppBuildId(<Module>.smethod_16(), gstruct66_0);
		}
	}
}
