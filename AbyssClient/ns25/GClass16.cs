using System;
using ns151;
using ns226;
using ns370;
using ns41;

namespace ns25
{
	// Token: 0x0200001D RID: 29
	public static class GClass16
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00005284 File Offset: 0x00003484
		public static bool smethod_0()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled(<Module>.smethod_22());
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000052A0 File Offset: 0x000034A0
		public static bool smethod_1(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsAppInBlockList(<Module>.smethod_22(), gstruct66_0);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000052C0 File Offset: 0x000034C0
		public static bool smethod_2(GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsAppBlocked(<Module>.smethod_22(), gstruct66_0);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000052E0 File Offset: 0x000034E0
		public static bool smethod_3(GEnum3 genum3_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsFeatureBlocked(<Module>.smethod_22(), genum3_0);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005300 File Offset: 0x00003500
		public static bool smethod_4()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsParentalLockLocked(<Module>.smethod_22());
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000531C File Offset: 0x0000351C
		public static bool smethod_5(GEnum3 genum3_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList(<Module>.smethod_22(), genum3_0);
		}
	}
}
