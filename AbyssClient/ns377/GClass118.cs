using System;
using System.Runtime.InteropServices;
using ns140;
using ns151;
using ns226;
using ns243;
using ns333;
using ns346;
using ns364;
using ns370;
using ns387;
using ns507;
using ns54;

namespace ns377
{
	// Token: 0x020002E1 RID: 737
	public static class GClass118
	{
		// Token: 0x060024FF RID: 9471 RVA: 0x000ADFF4 File Offset: 0x000AC1F4
		public static bool smethod_0(byte[] byte_0, int int_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetEncryptedAppTicket(<Module>.smethod_3(), byte_0, int_0, out uint_0);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000AE014 File Offset: 0x000AC214
		public static bool smethod_1(out string string_0, int int_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_0);
			bool flag = Class177.SteamAPI_ISteamUser_GetUserDataFolder(<Module>.smethod_3(), intPtr, int_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000AE050 File Offset: 0x000AC250
		public static bool smethod_2()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BLoggedOn(<Module>.smethod_3());
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000AE06C File Offset: 0x000AC26C
		internal static void smethod_3()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_StartVoiceRecording(<Module>.smethod_3());
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000AE088 File Offset: 0x000AC288
		internal static void smethod_4(GStruct176 gstruct176_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_CancelAuthTicket(<Module>.smethod_3(), gstruct176_0);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000AE0A8 File Offset: 0x000AC2A8
		public static int smethod_5(int int_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetGameBadgeLevel(<Module>.smethod_3(), int_0, bool_0);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000AE0C8 File Offset: 0x000AC2C8
		internal static void smethod_6(GStruct22 gstruct22_0)
		{
			GClass118.smethod_9(gstruct22_0);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000AE0DC File Offset: 0x000AC2DC
		public static GStruct176 smethod_7(byte[] byte_0, int int_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct176.smethod_2(Class177.SteamAPI_ISteamUser_GetAuthSessionTicket(<Module>.smethod_3(), byte_0, int_0, out uint_0));
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000AE104 File Offset: 0x000AC304
		public static void smethod_8()
		{
			GClass118.smethod_30();
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000AE118 File Offset: 0x000AC318
		internal static void smethod_9(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_EndAuthSession(<Module>.smethod_3(), gstruct22_0);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000AE138 File Offset: 0x000AC338
		public static bool smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BIsTwoFactorEnabled(<Module>.smethod_3());
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000AE154 File Offset: 0x000AC354
		public static GStruct22 smethod_11()
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamUser_GetSteamID(<Module>.smethod_3()));
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000AE178 File Offset: 0x000AC378
		internal static void smethod_12(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_AdvertiseGame(<Module>.smethod_3(), gstruct22_0, uint_0, ushort_0);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000AE198 File Offset: 0x000AC398
		public static GStruct58 smethod_13()
		{
			GClass78.smethod_1();
			return GStruct58.smethod_3(Class177.SteamAPI_ISteamUser_GetHSteamUser(<Module>.smethod_3()));
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		public static bool smethod_14()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BIsPhoneIdentifying(<Module>.smethod_3());
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000AE1D8 File Offset: 0x000AC3D8
		public static GEnum87 smethod_15(GStruct22 gstruct22_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_UserHasLicenseForApp(<Module>.smethod_3(), gstruct22_0, gstruct66_0);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000AE1F8 File Offset: 0x000AC3F8
		public static void smethod_16(GStruct217 gstruct217_0, int int_0, string string_0 = "")
		{
			GClass118.smethod_38(gstruct217_0, int_0, string_0);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000AE210 File Offset: 0x000AC410
		internal static void smethod_17()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_StopVoiceRecording(<Module>.smethod_3());
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000AE22C File Offset: 0x000AC42C
		public static GStruct241 smethod_18(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUser_RequestStoreAuthURL(<Module>.smethod_3(), gclass));
			}
			return result;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000AE278 File Offset: 0x000AC478
		public static bool smethod_19()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BIsBehindNAT(<Module>.smethod_3());
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000AE294 File Offset: 0x000AC494
		public static GEnum67 smethod_20(out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetAvailableVoice(<Module>.smethod_3(), out uint_0, IntPtr.Zero, 0U);
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000AE2BC File Offset: 0x000AC4BC
		internal static void smethod_21(uint uint_0, ushort ushort_0)
		{
			GClass118.smethod_42(uint_0, ushort_0);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000AE2D0 File Offset: 0x000AC4D0
		internal static void smethod_22(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0)
		{
			GClass118.smethod_12(gstruct22_0, uint_0, ushort_0);
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		public static void smethod_23(GStruct22 gstruct22_0)
		{
			GClass118.smethod_6(gstruct22_0);
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000AE2FC File Offset: 0x000AC4FC
		public static void smethod_24(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0)
		{
			GClass118.smethod_22(gstruct22_0, uint_0, ushort_0);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000AE314 File Offset: 0x000AC514
		public static void smethod_25()
		{
			GClass118.smethod_33();
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000AE328 File Offset: 0x000AC528
		public static bool smethod_26()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BIsPhoneRequiringVerification(<Module>.smethod_3());
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000AE344 File Offset: 0x000AC544
		public static bool smethod_27()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BIsPhoneVerified(<Module>.smethod_3());
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000AE360 File Offset: 0x000AC560
		public static int smethod_28(byte[] byte_0, int int_0, GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_InitiateGameConnection(<Module>.smethod_3(), byte_0, int_0, gstruct22_0, uint_0, ushort_0, bool_0);
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000AE388 File Offset: 0x000AC588
		public static void smethod_29(GStruct176 gstruct176_0)
		{
			GClass118.smethod_39(gstruct176_0);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000AE39C File Offset: 0x000AC59C
		internal static void smethod_30()
		{
			GClass118.smethod_17();
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000AE3B0 File Offset: 0x000AC5B0
		public static GEnum67 smethod_31(byte[] byte_0, uint uint_0, byte[] byte_1, uint uint_1, out uint uint_2, uint uint_3)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_DecompressVoice(<Module>.smethod_3(), byte_0, uint_0, byte_1, uint_1, out uint_2, uint_3);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000AE3D8 File Offset: 0x000AC5D8
		public static uint smethod_32()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(<Module>.smethod_3());
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000AE3F8 File Offset: 0x000AC5F8
		internal static void smethod_33()
		{
			GClass118.smethod_3();
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000AE40C File Offset: 0x000AC60C
		public static int smethod_34()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetPlayerSteamLevel(<Module>.smethod_3());
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000AE42C File Offset: 0x000AC62C
		internal static void smethod_35(GStruct217 gstruct217_0, int int_0, string string_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamUser_TrackAppUsageEvent(<Module>.smethod_3(), gstruct217_0, int_0, gclass);
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000AE470 File Offset: 0x000AC670
		public static GEnum67 smethod_36(bool bool_0, byte[] byte_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_GetVoice(<Module>.smethod_3(), bool_0, byte_0, uint_0, out uint_1, false, IntPtr.Zero, 0U, IntPtr.Zero, 0U);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000AE4A0 File Offset: 0x000AC6A0
		public static void smethod_37(uint uint_0, ushort ushort_0)
		{
			GClass118.smethod_21(uint_0, ushort_0);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000AE4B4 File Offset: 0x000AC6B4
		internal static void smethod_38(GStruct217 gstruct217_0, int int_0, string string_0)
		{
			GClass118.smethod_35(gstruct217_0, int_0, string_0);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000AE4CC File Offset: 0x000AC6CC
		internal static void smethod_39(GStruct176 gstruct176_0)
		{
			GClass118.smethod_4(gstruct176_0);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000AE4E0 File Offset: 0x000AC6E0
		public static GEnum70 smethod_40(byte[] byte_0, int int_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUser_BeginAuthSession(<Module>.smethod_3(), byte_0, int_0, gstruct22_0);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000AE504 File Offset: 0x000AC704
		public static GStruct241 smethod_41(byte[] byte_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUser_RequestEncryptedAppTicket(<Module>.smethod_3(), byte_0, int_0));
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000AE52C File Offset: 0x000AC72C
		internal static void smethod_42(uint uint_0, ushort ushort_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUser_TerminateGameConnection(<Module>.smethod_3(), uint_0, ushort_0);
		}
	}
}
