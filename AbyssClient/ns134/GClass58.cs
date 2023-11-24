using System;
using ns151;
using ns226;
using ns243;
using ns364;
using ns370;
using ns381;
using ns387;
using ns507;
using ns54;

namespace ns134
{
	// Token: 0x020000CD RID: 205
	public static class GClass58
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x0001A858 File Offset: 0x00018A58
		internal static void smethod_0(string string_0)
		{
			GClass58.smethod_40(string_0);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001A86C File Offset: 0x00018A6C
		public static GEnum87 smethod_1(GStruct22 gstruct22_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_UserHasLicenseForApp(Class180.smethod_11(), gstruct22_0, gstruct66_0);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001A88C File Offset: 0x00018A8C
		public static void smethod_2(bool bool_0)
		{
			GClass58.smethod_12(bool_0);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		public static GStruct241 smethod_3(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility(Class180.smethod_11(), gstruct22_0));
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		public static GStruct241 smethod_4()
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamGameServer_GetServerReputation(Class180.smethod_11()));
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001A8E8 File Offset: 0x00018AE8
		internal static void smethod_5(int int_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetBotPlayerCount(Class180.smethod_11(), int_0);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001A908 File Offset: 0x00018B08
		public static bool smethod_6(uint uint_0, byte[] byte_0, uint uint_1, out GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate(Class180.smethod_11(), uint_0, byte_0, uint_1, out gstruct22_0);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001A928 File Offset: 0x00018B28
		public static void smethod_7(GStruct22 gstruct22_0)
		{
			GClass58.smethod_64(gstruct22_0);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001A93C File Offset: 0x00018B3C
		public static GStruct176 smethod_8(byte[] byte_0, int int_0, out uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct176.smethod_2(Class177.SteamAPI_ISteamGameServer_GetAuthSessionTicket(Class180.smethod_11(), byte_0, int_0, out uint_0));
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001A964 File Offset: 0x00018B64
		public static GStruct22 smethod_9()
		{
			GClass78.smethod_2();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamGameServer_GetSteamID(Class180.smethod_11()));
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001A988 File Offset: 0x00018B88
		internal static void smethod_10(ushort ushort_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetSpectatorPort(Class180.smethod_11(), ushort_0);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		internal static void smethod_11(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetModDir(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		internal static void smethod_12(bool bool_0)
		{
			GClass58.smethod_84(bool_0);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001A9FC File Offset: 0x00018BFC
		internal static void smethod_13(GStruct22 gstruct22_0)
		{
			GClass58.smethod_15(gstruct22_0);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001AA10 File Offset: 0x00018C10
		public static void smethod_14(string string_0)
		{
			GClass58.smethod_22(string_0);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001AA24 File Offset: 0x00018C24
		internal static void smethod_15(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SendUserDisconnect(Class180.smethod_11(), gstruct22_0);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001AA44 File Offset: 0x00018C44
		public static void smethod_16(int int_0)
		{
			GClass58.smethod_50(int_0);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001AA58 File Offset: 0x00018C58
		public static int smethod_17(byte[] byte_0, int int_0, out uint uint_0, out ushort ushort_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_GetNextOutgoingPacket(Class180.smethod_11(), byte_0, int_0, out uint_0, out ushort_0);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001AA7C File Offset: 0x00018C7C
		internal static void smethod_18(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetGameDescription(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001AABC File Offset: 0x00018CBC
		public static void smethod_19(int int_0)
		{
			GClass58.smethod_70(int_0);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001AAD0 File Offset: 0x00018CD0
		public static bool smethod_20(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_RequestUserGroupStatus(Class180.smethod_11(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		public static void smethod_21(string string_0)
		{
			GClass58.smethod_56(string_0);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001AB04 File Offset: 0x00018D04
		internal static void smethod_22(string string_0)
		{
			GClass58.smethod_80(string_0);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001AB18 File Offset: 0x00018D18
		internal static void smethod_23(string string_0)
		{
			GClass58.smethod_43(string_0);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001AB2C File Offset: 0x00018D2C
		internal static void smethod_24(bool bool_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_EnableHeartbeats(Class180.smethod_11(), bool_0);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001AB4C File Offset: 0x00018D4C
		internal static void smethod_25()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_LogOnAnonymous(Class180.smethod_11());
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001AB68 File Offset: 0x00018D68
		public static GStruct241 smethod_26(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamGameServer_AssociateWithClan(Class180.smethod_11(), gstruct22_0));
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001AB8C File Offset: 0x00018D8C
		internal static void smethod_27(string string_0)
		{
			GClass58.smethod_95(string_0);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001ABA0 File Offset: 0x00018DA0
		internal static void smethod_28(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetGameTags(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		internal static void smethod_29(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetGameData(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001AC20 File Offset: 0x00018E20
		public static bool smethod_30(uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1, GStruct66 gstruct66_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServer_InitGameServer(Class180.smethod_11(), uint_0, ushort_0, ushort_1, uint_1, gstruct66_0, gclass);
			}
			return result;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001AC6C File Offset: 0x00018E6C
		internal static void smethod_31()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_ForceHeartbeat(Class180.smethod_11());
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001AC88 File Offset: 0x00018E88
		internal static void smethod_32(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_EndAuthSession(Class180.smethod_11(), gstruct22_0);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		internal static void smethod_33()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_LogOff(Class180.smethod_11());
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		public static void smethod_34(string string_0)
		{
			GClass58.smethod_91(string_0);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		public static bool smethod_35(GStruct22 gstruct22_0, string string_0, uint uint_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamGameServer_BUpdateUserData(Class180.smethod_11(), gstruct22_0, gclass, uint_0);
			}
			return result;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001AD1C File Offset: 0x00018F1C
		public static void smethod_36()
		{
			GClass58.smethod_92();
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001AD30 File Offset: 0x00018F30
		public static GStruct22 smethod_37()
		{
			GClass78.smethod_2();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection(Class180.smethod_11()));
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001AD54 File Offset: 0x00018F54
		public static bool smethod_38(byte[] byte_0, int int_0, uint uint_0, ushort ushort_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_HandleIncomingPacket(Class180.smethod_11(), byte_0, int_0, uint_0, ushort_0);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0001AD74 File Offset: 0x00018F74
		public static void smethod_39(string string_0)
		{
			GClass58.smethod_79(string_0);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001AD88 File Offset: 0x00018F88
		internal static void smethod_40(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetRegion(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		internal static void smethod_41(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_LogOn(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001AE08 File Offset: 0x00019008
		public static void smethod_42(bool bool_0)
		{
			GClass58.smethod_59(bool_0);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001AE1C File Offset: 0x0001901C
		internal static void smethod_43(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetMapName(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001AE5C File Offset: 0x0001905C
		public static void smethod_44(string string_0)
		{
			GClass58.smethod_0(string_0);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001AE70 File Offset: 0x00019070
		internal static void smethod_45(string string_0)
		{
			GClass58.smethod_41(string_0);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001AE84 File Offset: 0x00019084
		public static void smethod_46()
		{
			GClass58.smethod_71();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001AE98 File Offset: 0x00019098
		internal static void smethod_47(bool bool_0)
		{
			GClass58.smethod_24(bool_0);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001AEAC File Offset: 0x000190AC
		public static void smethod_48(string string_0)
		{
			GClass58.smethod_27(string_0);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001AEC0 File Offset: 0x000190C0
		public static bool smethod_49()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_WasRestartRequested(Class180.smethod_11());
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001AEDC File Offset: 0x000190DC
		internal static void smethod_50(int int_0)
		{
			GClass58.smethod_58(int_0);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001AEF0 File Offset: 0x000190F0
		public static void smethod_51(GStruct22 gstruct22_0)
		{
			GClass58.smethod_13(gstruct22_0);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001AF04 File Offset: 0x00019104
		public static void smethod_52(int int_0)
		{
			GClass58.smethod_93(int_0);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001AF18 File Offset: 0x00019118
		public static void smethod_53()
		{
			GClass58.smethod_65();
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001AF2C File Offset: 0x0001912C
		public static void smethod_54(string string_0)
		{
			GClass58.smethod_88(string_0);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001AF40 File Offset: 0x00019140
		internal static void smethod_55(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetSpectatorServerName(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001AF80 File Offset: 0x00019180
		internal static void smethod_56(string string_0)
		{
			GClass58.smethod_11(string_0);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001AF94 File Offset: 0x00019194
		internal static void smethod_57(string string_0, string string_1)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					Class177.SteamAPI_ISteamGameServer_SetKeyValue(Class180.smethod_11(), gclass, gclass2);
				}
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001AFF4 File Offset: 0x000191F4
		internal static void smethod_58(int int_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetHeartbeatInterval(Class180.smethod_11(), int_0);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001B014 File Offset: 0x00019214
		internal static void smethod_59(bool bool_0)
		{
			GClass58.smethod_77(bool_0);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001B028 File Offset: 0x00019228
		internal static void smethod_60(GStruct176 gstruct176_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_CancelAuthTicket(Class180.smethod_11(), gstruct176_0);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001B048 File Offset: 0x00019248
		public static void smethod_61(string string_0)
		{
			GClass58.smethod_23(string_0);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001B05C File Offset: 0x0001925C
		internal static void smethod_62()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_GetGameplayStats(Class180.smethod_11());
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001B078 File Offset: 0x00019278
		internal static void smethod_63(int int_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetMaxPlayerCount(Class180.smethod_11(), int_0);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001B098 File Offset: 0x00019298
		internal static void smethod_64(GStruct22 gstruct22_0)
		{
			GClass58.smethod_32(gstruct22_0);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001B0AC File Offset: 0x000192AC
		internal static void smethod_65()
		{
			GClass58.smethod_62();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001B0C0 File Offset: 0x000192C0
		internal static void smethod_66()
		{
			GClass58.smethod_33();
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public static void smethod_67(string string_0)
		{
			GClass58.smethod_45(string_0);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001B0E8 File Offset: 0x000192E8
		public static void smethod_68(string string_0)
		{
			GClass58.smethod_87(string_0);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001B0FC File Offset: 0x000192FC
		public static GEnum70 smethod_69(byte[] byte_0, int int_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_BeginAuthSession(Class180.smethod_11(), byte_0, int_0, gstruct22_0);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001B120 File Offset: 0x00019320
		internal static void smethod_70(int int_0)
		{
			GClass58.smethod_5(int_0);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001B134 File Offset: 0x00019334
		internal static void smethod_71()
		{
			GClass58.smethod_25();
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001B148 File Offset: 0x00019348
		public static void smethod_72(GStruct176 gstruct176_0)
		{
			GClass58.smethod_78(gstruct176_0);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001B15C File Offset: 0x0001935C
		public static bool smethod_73()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_BSecure(Class180.smethod_11());
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001B178 File Offset: 0x00019378
		public static void smethod_74(string string_0, string string_1)
		{
			GClass58.smethod_81(string_0, string_1);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001B18C File Offset: 0x0001938C
		internal static void smethod_75()
		{
			GClass58.smethod_31();
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001B1A0 File Offset: 0x000193A0
		public static void smethod_76(bool bool_0)
		{
			GClass58.smethod_47(bool_0);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001B1B4 File Offset: 0x000193B4
		internal static void smethod_77(bool bool_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetPasswordProtected(Class180.smethod_11(), bool_0);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001B1D4 File Offset: 0x000193D4
		internal static void smethod_78(GStruct176 gstruct176_0)
		{
			GClass58.smethod_60(gstruct176_0);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001B1E8 File Offset: 0x000193E8
		internal static void smethod_79(string string_0)
		{
			GClass58.smethod_18(string_0);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001B1FC File Offset: 0x000193FC
		internal static void smethod_80(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetServerName(Class180.smethod_11(), gclass);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001B23C File Offset: 0x0001943C
		internal static void smethod_81(string string_0, string string_1)
		{
			GClass58.smethod_57(string_0, string_1);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001B250 File Offset: 0x00019450
		public static void smethod_82(ushort ushort_0)
		{
			GClass58.smethod_86(ushort_0);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001B264 File Offset: 0x00019464
		public static void smethod_83()
		{
			GClass58.smethod_75();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001B278 File Offset: 0x00019478
		internal static void smethod_84(bool bool_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_SetDedicatedServer(Class180.smethod_11(), bool_0);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001B298 File Offset: 0x00019498
		public static void smethod_85()
		{
			GClass58.smethod_66();
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001B2AC File Offset: 0x000194AC
		internal static void smethod_86(ushort ushort_0)
		{
			GClass58.smethod_10(ushort_0);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001B2C0 File Offset: 0x000194C0
		internal static void smethod_87(string string_0)
		{
			GClass58.smethod_55(string_0);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001B2D4 File Offset: 0x000194D4
		internal static void smethod_88(string string_0)
		{
			GClass58.smethod_28(string_0);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001B2E8 File Offset: 0x000194E8
		internal static void smethod_89()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamGameServer_ClearAllKeyValues(Class180.smethod_11());
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001B304 File Offset: 0x00019504
		public static uint smethod_90()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_GetPublicIP(Class180.smethod_11());
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001B324 File Offset: 0x00019524
		internal static void smethod_91(string string_0)
		{
			GClass58.smethod_29(string_0);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001B338 File Offset: 0x00019538
		internal static void smethod_92()
		{
			GClass58.smethod_89();
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001B34C File Offset: 0x0001954C
		internal static void smethod_93(int int_0)
		{
			GClass58.smethod_63(int_0);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001B360 File Offset: 0x00019560
		public static bool smethod_94()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamGameServer_BLoggedOn(Class180.smethod_11());
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001B37C File Offset: 0x0001957C
		internal static void smethod_95(string string_0)
		{
			GClass78.smethod_2();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamGameServer_SetProduct(Class180.smethod_11(), gclass);
			}
		}
	}
}
