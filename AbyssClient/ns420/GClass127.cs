using System;
using System.Runtime.InteropServices;
using ns151;
using ns189;
using ns226;
using ns297;
using ns370;
using ns387;
using ns537;
using ns54;
using ns558;

namespace ns420
{
	// Token: 0x0200032B RID: 811
	public static class GClass127
	{
		// Token: 0x0600417D RID: 16765 RVA: 0x000F964C File Offset: 0x000F784C
		public static void smethod_0(GEnum96 genum96_0)
		{
			GClass127.smethod_34(genum96_0);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000F9660 File Offset: 0x000F7860
		public static int smethod_1(GStruct66 gstruct66_0, uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1, uint uint_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_AddFavoriteGame(<Module>.smethod_6(), gstruct66_0, uint_0, ushort_0, ushort_1, uint_1, uint_2);
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x000F9688 File Offset: 0x000F7888
		public static void smethod_2(string string_0, string string_1, GEnum55 genum55_0)
		{
			GClass127.smethod_8(string_0, string_1, genum55_0);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x000F96A0 File Offset: 0x000F78A0
		public static bool smethod_3(GStruct22 gstruct22_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SetLobbyJoinable(<Module>.smethod_6(), gstruct22_0, bool_0);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x000F96C0 File Offset: 0x000F78C0
		internal static void smethod_4(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_LeaveLobby(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x000F96E0 File Offset: 0x000F78E0
		public static bool smethod_5(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit(<Module>.smethod_6(), gstruct22_0, int_0);
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000F9700 File Offset: 0x000F7900
		public static GStruct241 smethod_6(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamMatchmaking_JoinLobby(<Module>.smethod_6(), gstruct22_0));
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000F9724 File Offset: 0x000F7924
		internal static void smethod_7(GStruct22 gstruct22_0)
		{
			GClass127.smethod_4(gstruct22_0);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000F9738 File Offset: 0x000F7938
		internal static void smethod_8(string string_0, string string_1, GEnum55 genum55_0)
		{
			GClass127.smethod_61(string_0, string_1, genum55_0);
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000F9750 File Offset: 0x000F7950
		public static int smethod_9(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x000F9770 File Offset: 0x000F7970
		public static string smethod_10(GStruct22 gstruct22_0, GStruct22 gstruct22_1, string string_0)
		{
			return GClass127.smethod_13(gstruct22_0, gstruct22_1, string_0);
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000F9788 File Offset: 0x000F7988
		public static void smethod_11(GStruct22 gstruct22_0)
		{
			GClass127.smethod_25(gstruct22_0);
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000F979C File Offset: 0x000F799C
		internal static void smethod_12(GStruct22 gstruct22_0, string string_0, string string_1)
		{
			GClass127.smethod_14(gstruct22_0, string_0, string_1);
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000F97B4 File Offset: 0x000F79B4
		internal static string smethod_13(GStruct22 gstruct22_0, GStruct22 gstruct22_1, string string_0)
		{
			return GClass127.smethod_18(gstruct22_0, gstruct22_1, string_0);
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x000F97CC File Offset: 0x000F79CC
		internal static void smethod_14(GStruct22 gstruct22_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					Class177.SteamAPI_ISteamMatchmaking_SetLobbyMemberData(<Module>.smethod_6(), gstruct22_0, gclass, gclass2);
				}
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000F9830 File Offset: 0x000F7A30
		public static bool smethod_15(GStruct22 gstruct22_0, GEnum91 genum91_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SetLobbyType(<Module>.smethod_6(), gstruct22_0, genum91_0);
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x000F9850 File Offset: 0x000F7A50
		public static bool smethod_16(GStruct66 gstruct66_0, uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_RemoveFavoriteGame(<Module>.smethod_6(), gstruct66_0, uint_0, ushort_0, ushort_1, uint_1);
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x000F9874 File Offset: 0x000F7A74
		public static bool smethod_17(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SetLobbyOwner(<Module>.smethod_6(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x000F9894 File Offset: 0x000F7A94
		internal static string smethod_18(GStruct22 gstruct22_0, GStruct22 gstruct22_1, string string_0)
		{
			GClass78.smethod_1();
			string result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GClass78.smethod_0(Class177.SteamAPI_ISteamMatchmaking_GetLobbyMemberData(<Module>.smethod_6(), gstruct22_0, gstruct22_1, gclass));
			}
			return result;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000F98E0 File Offset: 0x000F7AE0
		public static bool smethod_19(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_InviteUserToLobby(<Module>.smethod_6(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x000F9900 File Offset: 0x000F7B00
		public static bool smethod_20(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMatchmaking_DeleteLobbyData(<Module>.smethod_6(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x000F9944 File Offset: 0x000F7B44
		public static void smethod_21(string string_0, int int_0, GEnum55 genum55_0)
		{
			GClass127.smethod_52(string_0, int_0, genum55_0);
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x000F995C File Offset: 0x000F7B5C
		public static bool smethod_22(int int_0, out GStruct66 gstruct66_0, out uint uint_0, out ushort ushort_0, out ushort ushort_1, out uint uint_1, out uint uint_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetFavoriteGame(<Module>.smethod_6(), int_0, out gstruct66_0, out uint_0, out ushort_0, out ushort_1, out uint_1, out uint_2);
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x000F9984 File Offset: 0x000F7B84
		public static bool smethod_23(GStruct22 gstruct22_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamMatchmaking_SetLobbyData(<Module>.smethod_6(), gstruct22_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x000F99E8 File Offset: 0x000F7BE8
		internal static void smethod_24(int int_0)
		{
			GClass127.smethod_28(int_0);
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000F99FC File Offset: 0x000F7BFC
		internal static void smethod_25(GStruct22 gstruct22_0)
		{
			GClass127.smethod_38(gstruct22_0);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000F9A10 File Offset: 0x000F7C10
		public static string smethod_26(GStruct22 gstruct22_0, string string_0)
		{
			return GClass127.smethod_46(gstruct22_0, string_0);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000F9A24 File Offset: 0x000F7C24
		public static void smethod_27(string string_0, int int_0)
		{
			GClass127.smethod_42(string_0, int_0);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000F9A38 File Offset: 0x000F7C38
		internal static void smethod_28(int int_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(<Module>.smethod_6(), int_0);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000F9A58 File Offset: 0x000F7C58
		public static GStruct241 smethod_29()
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamMatchmaking_RequestLobbyList(<Module>.smethod_6()));
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x000F9A7C File Offset: 0x000F7C7C
		internal static void smethod_30(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, GStruct22 gstruct22_1)
		{
			GClass127.smethod_32(gstruct22_0, uint_0, ushort_0, gstruct22_1);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x000F9A94 File Offset: 0x000F7C94
		public static void smethod_31(int int_0)
		{
			GClass127.smethod_36(int_0);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x000F9AA8 File Offset: 0x000F7CA8
		internal static void smethod_32(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_SetLobbyGameServer(<Module>.smethod_6(), gstruct22_0, uint_0, ushort_0, gstruct22_1);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x000F9AC8 File Offset: 0x000F7CC8
		public static int smethod_33(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetNumLobbyMembers(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x000F9AE8 File Offset: 0x000F7CE8
		internal static void smethod_34(GEnum96 genum96_0)
		{
			GClass127.smethod_50(genum96_0);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x000F9AFC File Offset: 0x000F7CFC
		internal static void smethod_35(int int_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter(<Module>.smethod_6(), int_0);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x000F9B1C File Offset: 0x000F7D1C
		internal static void smethod_36(int int_0)
		{
			GClass127.smethod_35(int_0);
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x000F9B30 File Offset: 0x000F7D30
		public static bool smethod_37(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_RequestLobbyData(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x000F9B50 File Offset: 0x000F7D50
		internal static void smethod_38(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x000F9B70 File Offset: 0x000F7D70
		public static int smethod_39()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(<Module>.smethod_6());
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x000F9B90 File Offset: 0x000F7D90
		public static void smethod_40(int int_0)
		{
			GClass127.smethod_24(int_0);
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x000F9BA4 File Offset: 0x000F7DA4
		public static bool smethod_41(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SetLinkedLobby(<Module>.smethod_6(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x000F9BC4 File Offset: 0x000F7DC4
		internal static void smethod_42(string string_0, int int_0)
		{
			GClass127.smethod_45(string_0, int_0);
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x000F9BD8 File Offset: 0x000F7DD8
		public static GStruct22 smethod_43(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex(<Module>.smethod_6(), gstruct22_0, int_0));
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x000F9C00 File Offset: 0x000F7E00
		public static bool smethod_44(GStruct22 gstruct22_0, out uint uint_0, out ushort ushort_0, out GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetLobbyGameServer(<Module>.smethod_6(), gstruct22_0, out uint_0, out ushort_0, out gstruct22_1);
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x000F9C20 File Offset: 0x000F7E20
		internal static void smethod_45(string string_0, int int_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter(<Module>.smethod_6(), gclass, int_0);
			}
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x000F9C64 File Offset: 0x000F7E64
		internal static string smethod_46(GStruct22 gstruct22_0, string string_0)
		{
			return GClass127.smethod_60(gstruct22_0, string_0);
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x000F9C78 File Offset: 0x000F7E78
		public static int smethod_47(GStruct22 gstruct22_0, int int_0, out GStruct22 gstruct22_1, byte[] byte_0, int int_1, out GEnum30 genum30_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetLobbyChatEntry(<Module>.smethod_6(), gstruct22_0, int_0, out gstruct22_1, byte_0, int_1, out genum30_0);
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x000F9CA0 File Offset: 0x000F7EA0
		public static bool smethod_48(GStruct22 gstruct22_0, int int_0, out string string_0, int int_1, out string string_1, int int_2)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_1);
			IntPtr intPtr2 = Marshal.AllocHGlobal(int_2);
			bool flag = Class177.SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex(<Module>.smethod_6(), gstruct22_0, int_0, intPtr, int_1, intPtr2, int_2);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			string_1 = (flag ? GClass78.smethod_0(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x000F9D00 File Offset: 0x000F7F00
		public static GStruct241 smethod_49(GEnum91 genum91_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamMatchmaking_CreateLobby(<Module>.smethod_6(), genum91_0, int_0));
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x000F9D28 File Offset: 0x000F7F28
		internal static void smethod_50(GEnum96 genum96_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter(<Module>.smethod_6(), genum96_0);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x000F9D48 File Offset: 0x000F7F48
		public static void smethod_51(GStruct22 gstruct22_0)
		{
			GClass127.smethod_7(gstruct22_0);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x000F9D5C File Offset: 0x000F7F5C
		internal static void smethod_52(string string_0, int int_0, GEnum55 genum55_0)
		{
			GClass127.smethod_54(string_0, int_0, genum55_0);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x000F9D74 File Offset: 0x000F7F74
		public static bool smethod_53(GStruct22 gstruct22_0, byte[] byte_0, int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_SendLobbyChatMsg(<Module>.smethod_6(), gstruct22_0, byte_0, int_0);
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x000F9D94 File Offset: 0x000F7F94
		internal static void smethod_54(string string_0, int int_0, GEnum55 genum55_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter(<Module>.smethod_6(), gclass, int_0, genum55_0);
			}
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x000F9DD8 File Offset: 0x000F7FD8
		public static int smethod_55(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMatchmaking_GetLobbyDataCount(<Module>.smethod_6(), gstruct22_0);
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x000F9DF8 File Offset: 0x000F7FF8
		public static void smethod_56(GStruct22 gstruct22_0, string string_0, string string_1)
		{
			GClass127.smethod_12(gstruct22_0, string_0, string_1);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x000F9E10 File Offset: 0x000F8010
		public static GStruct22 smethod_57(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamMatchmaking_GetLobbyOwner(<Module>.smethod_6(), gstruct22_0));
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000F9E34 File Offset: 0x000F8034
		public static void smethod_58(GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, GStruct22 gstruct22_1)
		{
			GClass127.smethod_30(gstruct22_0, uint_0, ushort_0, gstruct22_1);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000F9E4C File Offset: 0x000F804C
		public static GStruct22 smethod_59(int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamMatchmaking_GetLobbyByIndex(<Module>.smethod_6(), int_0));
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000F9E70 File Offset: 0x000F8070
		internal static string smethod_60(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			string result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GClass78.smethod_0(Class177.SteamAPI_ISteamMatchmaking_GetLobbyData(<Module>.smethod_6(), gstruct22_0, gclass));
			}
			return result;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000F9EBC File Offset: 0x000F80BC
		internal static void smethod_61(string string_0, string string_1, GEnum55 genum55_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					Class177.SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter(<Module>.smethod_6(), gclass, gclass2, genum55_0);
				}
			}
		}
	}
}
