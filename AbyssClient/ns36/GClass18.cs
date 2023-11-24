using System;
using ns170;
using ns173;
using ns226;
using ns26;
using ns319;
using ns353;
using ns370;
using ns54;

namespace ns36
{
	// Token: 0x02000028 RID: 40
	public static class GClass18
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00005658 File Offset: 0x00003858
		public static bool smethod_0(GStruct229 gstruct229_0, out uint uint_0, out GStruct208 gstruct208_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_IsDataAvailable(<Module>.smethod_10(), gstruct229_0, out uint_0, out gstruct208_0);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005678 File Offset: 0x00003878
		public static bool smethod_1(GStruct22 gstruct22_0, byte[] byte_0, uint uint_0, GEnum26 genum26_0, int int_0 = 0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_SendP2PPacket(<Module>.smethod_10(), gstruct22_0, byte_0, uint_0, genum26_0, int_0);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000569C File Offset: 0x0000389C
		public static bool smethod_2(GStruct208 gstruct208_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_IsDataAvailableOnSocket(<Module>.smethod_10(), gstruct208_0, out uint_0);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000056BC File Offset: 0x000038BC
		public static bool smethod_3(GStruct208 gstruct208_0, out GStruct22 gstruct22_0, out int int_0, out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_GetSocketInfo(<Module>.smethod_10(), gstruct208_0, out gstruct22_0, out int_0, out uint_0, out ushort_0);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000056E0 File Offset: 0x000038E0
		public static bool smethod_4(GStruct22 gstruct22_0, out GStruct9 gstruct9_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_GetP2PSessionState(<Module>.smethod_10(), gstruct22_0, out gstruct9_0);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005700 File Offset: 0x00003900
		public static bool smethod_5(out uint uint_0, int int_0 = 0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_IsP2PPacketAvailable(<Module>.smethod_10(), out uint_0, int_0);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005720 File Offset: 0x00003920
		public static GStruct208 smethod_6(uint uint_0, ushort ushort_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct208.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateConnectionSocket(<Module>.smethod_10(), uint_0, ushort_0, int_0));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005748 File Offset: 0x00003948
		public static bool smethod_7(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(<Module>.smethod_10(), gstruct22_0);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005768 File Offset: 0x00003968
		public static bool smethod_8(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(<Module>.smethod_10(), gstruct22_0);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005788 File Offset: 0x00003988
		public static bool smethod_9(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_AllowP2PPacketRelay(<Module>.smethod_10(), bool_0);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000057A8 File Offset: 0x000039A8
		public static bool smethod_10(GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_SendDataOnSocket(<Module>.smethod_10(), gstruct208_0, byte_0, uint_0, bool_0);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000057C8 File Offset: 0x000039C8
		public static bool smethod_11(GStruct229 gstruct229_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_DestroyListenSocket(<Module>.smethod_10(), gstruct229_0, bool_0);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000057E8 File Offset: 0x000039E8
		public static bool smethod_12(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_CloseP2PChannelWithUser(<Module>.smethod_10(), gstruct22_0, int_0);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005808 File Offset: 0x00003A08
		public static GStruct229 smethod_13(int int_0, uint uint_0, ushort ushort_0, bool bool_0)
		{
			GClass78.smethod_1();
			return GStruct229.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateListenSocket(<Module>.smethod_10(), int_0, uint_0, ushort_0, bool_0));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005830 File Offset: 0x00003A30
		public static bool smethod_14(GStruct208 gstruct208_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_DestroySocket(<Module>.smethod_10(), gstruct208_0, bool_0);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005850 File Offset: 0x00003A50
		public static bool smethod_15(GStruct229 gstruct229_0, byte[] byte_0, uint uint_0, out uint uint_1, out GStruct208 gstruct208_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_RetrieveData(<Module>.smethod_10(), gstruct229_0, byte_0, uint_0, out uint_1, out gstruct208_0);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005874 File Offset: 0x00003A74
		public static GStruct208 smethod_16(GStruct22 gstruct22_0, int int_0, int int_1, bool bool_0)
		{
			GClass78.smethod_1();
			return GStruct208.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateP2PConnectionSocket(<Module>.smethod_10(), gstruct22_0, int_0, int_1, bool_0));
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000589C File Offset: 0x00003A9C
		public static GEnum27 smethod_17(GStruct208 gstruct208_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_GetSocketConnectionType(<Module>.smethod_10(), gstruct208_0);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000058BC File Offset: 0x00003ABC
		public static bool smethod_18(GStruct229 gstruct229_0, out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_GetListenSocketInfo(<Module>.smethod_10(), gstruct229_0, out uint_0, out ushort_0);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000058DC File Offset: 0x00003ADC
		public static bool smethod_19(GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_RetrieveDataFromSocket(<Module>.smethod_10(), gstruct208_0, byte_0, uint_0, out uint_1);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000058FC File Offset: 0x00003AFC
		public static bool smethod_20(byte[] byte_0, uint uint_0, out uint uint_1, out GStruct22 gstruct22_0, int int_0 = 0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_ReadP2PPacket(<Module>.smethod_10(), byte_0, uint_0, out uint_1, out gstruct22_0, int_0);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005920 File Offset: 0x00003B20
		public static int smethod_21(GStruct208 gstruct208_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamNetworking_GetMaxPacketSize(<Module>.smethod_10(), gstruct208_0);
		}
	}
}
