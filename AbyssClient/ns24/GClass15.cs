using System;
using System.Runtime.InteropServices;
using ns151;
using ns226;
using ns370;
using ns54;

namespace ns24
{
	// Token: 0x0200001C RID: 28
	public static class GClass15
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000515C File Offset: 0x0000335C
		public static bool smethod_0(byte[] byte_0, uint uint_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_BIsTicketForApp(byte_0, uint_0, gstruct66_0);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005178 File Offset: 0x00003378
		public static uint smethod_1(byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_GetTicketAppID(byte_0, uint_0);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005194 File Offset: 0x00003394
		public static bool smethod_2(byte[] byte_0, uint uint_0, byte[] byte_1, ref uint uint_1, byte[] byte_2, int int_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_BDecryptTicket(byte_0, uint_0, byte_1, ref uint_1, byte_2, int_0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000051B4 File Offset: 0x000033B4
		public static bool smethod_3(byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_BUserIsVacBanned(byte_0, uint_0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000051D0 File Offset: 0x000033D0
		public static void smethod_4(byte[] byte_0, uint uint_0, out GStruct22 gstruct22_0)
		{
			GClass15.smethod_7(byte_0, uint_0, ref gstruct22_0);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000051E8 File Offset: 0x000033E8
		public static byte[] smethod_5(byte[] byte_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_5();
			IntPtr source = Class177.SteamEncryptedAppTicket_GetUserVariableData(byte_0, uint_0, out uint_1);
			byte[] array = new byte[uint_1];
			Marshal.Copy(source, array, 0, (int)uint_1);
			return array;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005218 File Offset: 0x00003418
		public static uint smethod_6(byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_GetTicketIssueTime(byte_0, uint_0);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005234 File Offset: 0x00003434
		internal static void smethod_7(byte[] byte_0, uint uint_0, ref GStruct22 gstruct22_0)
		{
			GClass15.smethod_9(byte_0, uint_0, ref gstruct22_0);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000524C File Offset: 0x0000344C
		public static bool smethod_8(byte[] byte_0, uint uint_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_5();
			return Class177.SteamEncryptedAppTicket_BUserOwnsAppInTicket(byte_0, uint_0, gstruct66_0);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005268 File Offset: 0x00003468
		internal static void smethod_9(byte[] byte_0, uint uint_0, ref GStruct22 gstruct22_0)
		{
			GClass78.smethod_5();
			Class177.SteamEncryptedAppTicket_GetTicketSteamID(byte_0, uint_0, out gstruct22_0);
		}
	}
}
