using System;
using ns170;
using ns173;
using ns226;
using ns26;
using ns319;
using ns353;
using ns370;
using ns381;
using ns54;

namespace ns327
{
	// Token: 0x02000287 RID: 647
	public static class GClass105
	{
		// Token: 0x06001DB5 RID: 7605 RVA: 0x00093BB4 File Offset: 0x00091DB4
		public static bool smethod_0(bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_AllowP2PPacketRelay(Class180.smethod_7(), bool_0);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00093BD4 File Offset: 0x00091DD4
		public static bool smethod_1(GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_RetrieveDataFromSocket(Class180.smethod_7(), gstruct208_0, byte_0, uint_0, out uint_1);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00093BF4 File Offset: 0x00091DF4
		public static bool smethod_2(GStruct229 gstruct229_0, out uint uint_0, out GStruct208 gstruct208_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_IsDataAvailable(Class180.smethod_7(), gstruct229_0, out uint_0, out gstruct208_0);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00093C14 File Offset: 0x00091E14
		public static bool smethod_3(GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_SendDataOnSocket(Class180.smethod_7(), gstruct208_0, byte_0, uint_0, bool_0);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00093C34 File Offset: 0x00091E34
		public static bool smethod_4(GStruct22 gstruct22_0, byte[] byte_0, uint uint_0, GEnum26 genum26_0, int int_0 = 0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_SendP2PPacket(Class180.smethod_7(), gstruct22_0, byte_0, uint_0, genum26_0, int_0);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00093C58 File Offset: 0x00091E58
		public static GStruct208 smethod_5(GStruct22 gstruct22_0, int int_0, int int_1, bool bool_0)
		{
			GClass78.smethod_2();
			return GStruct208.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateP2PConnectionSocket(Class180.smethod_7(), gstruct22_0, int_0, int_1, bool_0));
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00093C80 File Offset: 0x00091E80
		public static bool smethod_6(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(Class180.smethod_7(), gstruct22_0);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00093CA0 File Offset: 0x00091EA0
		public static bool smethod_7(GStruct208 gstruct208_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_DestroySocket(Class180.smethod_7(), gstruct208_0, bool_0);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00093CC0 File Offset: 0x00091EC0
		public static bool smethod_8(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_CloseP2PChannelWithUser(Class180.smethod_7(), gstruct22_0, int_0);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00093CE0 File Offset: 0x00091EE0
		public static bool smethod_9(GStruct22 gstruct22_0, out GStruct9 gstruct9_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_GetP2PSessionState(Class180.smethod_7(), gstruct22_0, out gstruct9_0);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00093D00 File Offset: 0x00091F00
		public static bool smethod_10(GStruct229 gstruct229_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_DestroyListenSocket(Class180.smethod_7(), gstruct229_0, bool_0);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00093D20 File Offset: 0x00091F20
		public static GEnum27 smethod_11(GStruct208 gstruct208_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_GetSocketConnectionType(Class180.smethod_7(), gstruct208_0);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00093D40 File Offset: 0x00091F40
		public static bool smethod_12(GStruct229 gstruct229_0, byte[] byte_0, uint uint_0, out uint uint_1, out GStruct208 gstruct208_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_RetrieveData(Class180.smethod_7(), gstruct229_0, byte_0, uint_0, out uint_1, out gstruct208_0);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00093D64 File Offset: 0x00091F64
		public static bool smethod_13(GStruct229 gstruct229_0, out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_GetListenSocketInfo(Class180.smethod_7(), gstruct229_0, out uint_0, out ushort_0);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00093D84 File Offset: 0x00091F84
		public static bool smethod_14(byte[] byte_0, uint uint_0, out uint uint_1, out GStruct22 gstruct22_0, int int_0 = 0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_ReadP2PPacket(Class180.smethod_7(), byte_0, uint_0, out uint_1, out gstruct22_0, int_0);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00093DA8 File Offset: 0x00091FA8
		public static bool smethod_15(GStruct208 gstruct208_0, out GStruct22 gstruct22_0, out int int_0, out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_GetSocketInfo(Class180.smethod_7(), gstruct208_0, out gstruct22_0, out int_0, out uint_0, out ushort_0);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00093DCC File Offset: 0x00091FCC
		public static GStruct208 smethod_16(uint uint_0, ushort ushort_0, int int_0)
		{
			GClass78.smethod_2();
			return GStruct208.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateConnectionSocket(Class180.smethod_7(), uint_0, ushort_0, int_0));
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00093DF4 File Offset: 0x00091FF4
		public static GStruct229 smethod_17(int int_0, uint uint_0, ushort ushort_0, bool bool_0)
		{
			GClass78.smethod_2();
			return GStruct229.smethod_1(Class177.SteamAPI_ISteamNetworking_CreateListenSocket(Class180.smethod_7(), int_0, uint_0, ushort_0, bool_0));
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00093E1C File Offset: 0x0009201C
		public static bool smethod_18(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(Class180.smethod_7(), gstruct22_0);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00093E3C File Offset: 0x0009203C
		public static bool smethod_19(GStruct208 gstruct208_0, out uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_IsDataAvailableOnSocket(Class180.smethod_7(), gstruct208_0, out uint_0);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00093E5C File Offset: 0x0009205C
		public static bool smethod_20(out uint uint_0, int int_0 = 0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_IsP2PPacketAvailable(Class180.smethod_7(), out uint_0, int_0);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00093E7C File Offset: 0x0009207C
		public static int smethod_21(GStruct208 gstruct208_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamNetworking_GetMaxPacketSize(Class180.smethod_7(), gstruct208_0);
		}
	}
}
