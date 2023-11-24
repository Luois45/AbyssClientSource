using System;
using ns118;
using ns125;
using ns226;
using ns370;
using ns387;
using ns548;

namespace ns278
{
	// Token: 0x0200023D RID: 573
	public static class GClass94
	{
		// Token: 0x06001A9A RID: 6810 RVA: 0x00087E4C File Offset: 0x0008604C
		public static void smethod_0(string string_0, string string_1, string string_2, string string_3 = "/", uint uint_0 = 0U, bool bool_0 = false, bool bool_1 = false)
		{
			GClass94.smethod_12(string_0, string_1, string_2, string_3, uint_0, bool_0, bool_1);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00087E70 File Offset: 0x00086070
		public static void smethod_1(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_90(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00087E88 File Offset: 0x00086088
		internal static void smethod_2(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_GoBack(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00087EA8 File Offset: 0x000860A8
		public static void smethod_3(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass94.smethod_40(gstruct43_0, uint_0);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00087EBC File Offset: 0x000860BC
		public static void smethod_4(GStruct43 gstruct43_0, uint uint_0, uint uint_1)
		{
			GClass94.smethod_89(gstruct43_0, uint_0, uint_1);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00087ED4 File Offset: 0x000860D4
		public static void smethod_5(GStruct43 gstruct43_0)
		{
			GClass94.smethod_18(gstruct43_0);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00087EE8 File Offset: 0x000860E8
		public static void smethod_6(GStruct43 gstruct43_0)
		{
			GClass94.smethod_96(gstruct43_0);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00087EFC File Offset: 0x000860FC
		internal static void smethod_7(GStruct43 gstruct43_0)
		{
			GClass94.smethod_101(gstruct43_0);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00087F10 File Offset: 0x00086110
		internal static void smethod_8(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass94.smethod_21(gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00087F28 File Offset: 0x00086128
		public static void smethod_9(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass94.smethod_65(gstruct43_0, string_0, string_1);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00087F40 File Offset: 0x00086140
		internal static void smethod_10(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_54(gstruct43_0, bool_0);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00087F54 File Offset: 0x00086154
		internal static void smethod_11(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_PasteFromClipboard(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00087F74 File Offset: 0x00086174
		internal static void smethod_12(string string_0, string string_1, string string_2, string string_3, uint uint_0, bool bool_0, bool bool_1)
		{
			GClass94.smethod_30(string_0, string_1, string_2, string_3, uint_0, bool_0, bool_1);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00087F98 File Offset: 0x00086198
		public static bool smethod_13()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTMLSurface_Init(<Module>.smethod_19());
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00087FB4 File Offset: 0x000861B4
		public static void smethod_14(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_62(gstruct43_0, genum94_0);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00087FC8 File Offset: 0x000861C8
		internal static void smethod_15(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_KeyChar(<Module>.smethod_19(), gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00087FE8 File Offset: 0x000861E8
		internal static void smethod_16(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_KeyDown(<Module>.smethod_19(), gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00088008 File Offset: 0x00086208
		public static void smethod_17(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_67(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00088020 File Offset: 0x00086220
		internal static void smethod_18(GStruct43 gstruct43_0)
		{
			GClass94.smethod_56(gstruct43_0);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00088034 File Offset: 0x00086234
		public static void smethod_19(GStruct43 gstruct43_0)
		{
			GClass94.smethod_69(gstruct43_0);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00088048 File Offset: 0x00086248
		internal static void smethod_20(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass94.smethod_61(gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00088060 File Offset: 0x00086260
		internal static void smethod_21(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_MouseMove(<Module>.smethod_19(), gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00088080 File Offset: 0x00086280
		public static void smethod_22(GStruct43 gstruct43_0, float float_0)
		{
			GClass94.smethod_52(gstruct43_0, float_0);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00088094 File Offset: 0x00086294
		internal static void smethod_23(GStruct43 gstruct43_0, int int_0)
		{
			GClass94.smethod_27(gstruct43_0, int_0);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000880A8 File Offset: 0x000862A8
		internal static void smethod_24(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_CopyToClipboard(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000880C8 File Offset: 0x000862C8
		internal static void smethod_25(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetHorizontalScroll(<Module>.smethod_19(), gstruct43_0, uint_0);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000880E8 File Offset: 0x000862E8
		internal static void smethod_26(GStruct43 gstruct43_0, float float_0, int int_0, int int_1)
		{
			GClass94.smethod_29(gstruct43_0, float_0, int_0, int_1);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00088100 File Offset: 0x00086300
		internal static void smethod_27(GStruct43 gstruct43_0, int int_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_MouseWheel(<Module>.smethod_19(), gstruct43_0, int_0);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00088120 File Offset: 0x00086320
		internal static void smethod_28(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_87(gstruct43_0, bool_0);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00088134 File Offset: 0x00086334
		internal static void smethod_29(GStruct43 gstruct43_0, float float_0, int int_0, int int_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetPageScaleFactor(<Module>.smethod_19(), gstruct43_0, float_0, int_0, int_1);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00088154 File Offset: 0x00086354
		internal static void smethod_30(string string_0, string string_1, string string_2, string string_3, uint uint_0, bool bool_0, bool bool_1)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					using (GClass78.GClass79 gclass3 = new GClass78.GClass79(string_2))
					{
						using (GClass78.GClass79 gclass4 = new GClass78.GClass79(string_3))
						{
							Class177.SteamAPI_ISteamHTMLSurface_SetCookie(<Module>.smethod_19(), gclass, gclass2, gclass3, gclass4, uint_0, bool_0, bool_1);
						}
					}
				}
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000881FC File Offset: 0x000863FC
		public static void smethod_31(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_10(gstruct43_0, bool_0);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00088210 File Offset: 0x00086410
		internal static void smethod_32(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_MouseUp(<Module>.smethod_19(), gstruct43_0, genum94_0);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00088230 File Offset: 0x00086430
		public static void smethod_33(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_77(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00088248 File Offset: 0x00086448
		internal static void smethod_34(GStruct43 gstruct43_0)
		{
			GClass94.smethod_2(gstruct43_0);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0008825C File Offset: 0x0008645C
		internal static void smethod_35(GStruct43 gstruct43_0, string string_0, bool bool_0, bool bool_1)
		{
			GClass94.smethod_53(gstruct43_0, string_0, bool_0, bool_1);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00088274 File Offset: 0x00086474
		public static bool smethod_36()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTMLSurface_Shutdown(<Module>.smethod_19());
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00088290 File Offset: 0x00086490
		public static void smethod_37(GStruct43 gstruct43_0, int int_0)
		{
			GClass94.smethod_23(gstruct43_0, int_0);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000882A4 File Offset: 0x000864A4
		public static void smethod_38(GStruct43 gstruct43_0, string string_0)
		{
			GClass94.smethod_93(gstruct43_0, string_0);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000882B8 File Offset: 0x000864B8
		internal static void smethod_39(GStruct43 gstruct43_0)
		{
			GClass94.smethod_11(gstruct43_0);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000882CC File Offset: 0x000864CC
		internal static void smethod_40(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass94.smethod_25(gstruct43_0, uint_0);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000882E0 File Offset: 0x000864E0
		public static void smethod_41(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_66(gstruct43_0, bool_0);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000882F4 File Offset: 0x000864F4
		public static void smethod_42(GStruct43 gstruct43_0)
		{
			GClass94.smethod_7(gstruct43_0);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00088308 File Offset: 0x00086508
		public static void smethod_43(GStruct43 gstruct43_0)
		{
			GClass94.smethod_34(gstruct43_0);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0008831C File Offset: 0x0008651C
		internal static void smethod_44(GStruct43 gstruct43_0)
		{
			GClass94.smethod_83(gstruct43_0);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00088330 File Offset: 0x00086530
		public static void smethod_45(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_49(gstruct43_0, genum94_0);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00088344 File Offset: 0x00086544
		public static void smethod_46(GStruct43 gstruct43_0)
		{
			GClass94.smethod_39(gstruct43_0);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00088358 File Offset: 0x00086558
		internal static void smethod_47(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_MouseDoubleClick(<Module>.smethod_19(), gstruct43_0, genum94_0);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00088378 File Offset: 0x00086578
		internal static void smethod_48(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_StopLoad(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00088398 File Offset: 0x00086598
		internal static void smethod_49(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_32(gstruct43_0, genum94_0);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000883AC File Offset: 0x000865AC
		public static void smethod_50(GStruct43 gstruct43_0)
		{
			GClass94.smethod_60(gstruct43_0);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000883C0 File Offset: 0x000865C0
		internal static void smethod_51(GStruct43 gstruct43_0, IntPtr intptr_0)
		{
			GClass94.smethod_82(gstruct43_0, intptr_0);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000883D4 File Offset: 0x000865D4
		internal static void smethod_52(GStruct43 gstruct43_0, float float_0)
		{
			GClass94.smethod_58(gstruct43_0, float_0);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000883E8 File Offset: 0x000865E8
		internal static void smethod_53(GStruct43 gstruct43_0, string string_0, bool bool_0, bool bool_1)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamHTMLSurface_Find(<Module>.smethod_19(), gstruct43_0, gclass, bool_0, bool_1);
			}
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0008842C File Offset: 0x0008662C
		internal static void smethod_54(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetKeyFocus(<Module>.smethod_19(), gstruct43_0, bool_0);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0008844C File Offset: 0x0008664C
		internal static void smethod_55(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_99(gstruct43_0, bool_0);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00088460 File Offset: 0x00086660
		internal static void smethod_56(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_Reload(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00088480 File Offset: 0x00086680
		public static void smethod_57(GStruct43 gstruct43_0)
		{
			GClass94.smethod_86(gstruct43_0);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00088494 File Offset: 0x00086694
		internal static void smethod_58(GStruct43 gstruct43_0, float float_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor(<Module>.smethod_19(), gstruct43_0, float_0);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000884B4 File Offset: 0x000866B4
		internal static void smethod_59(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_JSDialogResponse(<Module>.smethod_19(), gstruct43_0, bool_0);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000884D4 File Offset: 0x000866D4
		internal static void smethod_60(GStruct43 gstruct43_0)
		{
			GClass94.smethod_97(gstruct43_0);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000884E8 File Offset: 0x000866E8
		internal static void smethod_61(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_GetLinkAtPosition(<Module>.smethod_19(), gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00088508 File Offset: 0x00086708
		internal static void smethod_62(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_47(gstruct43_0, genum94_0);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0008851C File Offset: 0x0008671C
		internal static void smethod_63(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_72(gstruct43_0, genum94_0);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00088530 File Offset: 0x00086730
		public static void smethod_64(GStruct43 gstruct43_0)
		{
			GClass94.smethod_44(gstruct43_0);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00088544 File Offset: 0x00086744
		internal static void smethod_65(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass94.smethod_68(gstruct43_0, string_0, string_1);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0008855C File Offset: 0x0008675C
		internal static void smethod_66(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_59(gstruct43_0, bool_0);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00088570 File Offset: 0x00086770
		internal static void smethod_67(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_15(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00088588 File Offset: 0x00086788
		internal static void smethod_68(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					Class177.SteamAPI_ISteamHTMLSurface_LoadURL(<Module>.smethod_19(), gstruct43_0, gclass, gclass2);
				}
			}
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x000885EC File Offset: 0x000867EC
		internal static void smethod_69(GStruct43 gstruct43_0)
		{
			GClass94.smethod_98(gstruct43_0);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00088600 File Offset: 0x00086800
		internal static void smethod_70(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					Class177.SteamAPI_ISteamHTMLSurface_AddHeader(<Module>.smethod_19(), gstruct43_0, gclass, gclass2);
				}
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00088664 File Offset: 0x00086864
		internal static void smethod_71(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass94.smethod_91(gstruct43_0, uint_0);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00088678 File Offset: 0x00086878
		internal static void smethod_72(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_MouseDown(<Module>.smethod_19(), gstruct43_0, genum94_0);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00088698 File Offset: 0x00086898
		public static void smethod_73(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_55(gstruct43_0, bool_0);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000886AC File Offset: 0x000868AC
		public static void smethod_74(GStruct43 gstruct43_0, GEnum94 genum94_0)
		{
			GClass94.smethod_63(gstruct43_0, genum94_0);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000886C0 File Offset: 0x000868C0
		public static void smethod_75(GStruct43 gstruct43_0, string string_0, bool bool_0, bool bool_1)
		{
			GClass94.smethod_35(gstruct43_0, string_0, bool_0, bool_1);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000886D8 File Offset: 0x000868D8
		internal static void smethod_76(GStruct43 gstruct43_0, uint uint_0, uint uint_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetSize(<Module>.smethod_19(), gstruct43_0, uint_0, uint_1);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000886F8 File Offset: 0x000868F8
		internal static void smethod_77(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_16(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00088710 File Offset: 0x00086910
		public static void smethod_78(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass94.smethod_28(gstruct43_0, bool_0);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00088724 File Offset: 0x00086924
		public static void smethod_79(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass94.smethod_20(gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0008873C File Offset: 0x0008693C
		public static void smethod_80(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass94.smethod_71(gstruct43_0, uint_0);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00088750 File Offset: 0x00086950
		public static void smethod_81(GStruct43 gstruct43_0, int int_0, int int_1)
		{
			GClass94.smethod_8(gstruct43_0, int_0, int_1);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00088768 File Offset: 0x00086968
		internal static void smethod_82(GStruct43 gstruct43_0, IntPtr intptr_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse(<Module>.smethod_19(), gstruct43_0, intptr_0);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00088788 File Offset: 0x00086988
		internal static void smethod_83(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_GoForward(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000887A8 File Offset: 0x000869A8
		public static GStruct241 smethod_84(string string_0, string string_1)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = GStruct241.smethod_0(Class177.SteamAPI_ISteamHTMLSurface_CreateBrowser(<Module>.smethod_19(), gclass, gclass2));
				}
			}
			return result;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00088814 File Offset: 0x00086A14
		internal static void smethod_85(GStruct43 gstruct43_0, string string_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamHTMLSurface_ExecuteJavascript(<Module>.smethod_19(), gstruct43_0, gclass);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00088858 File Offset: 0x00086A58
		internal static void smethod_86(GStruct43 gstruct43_0)
		{
			GClass94.smethod_48(gstruct43_0);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0008886C File Offset: 0x00086A6C
		internal static void smethod_87(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_AllowStartRequest(<Module>.smethod_19(), gstruct43_0, bool_0);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0008888C File Offset: 0x00086A8C
		public static void smethod_88(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass94.smethod_100(gstruct43_0, string_0, string_1);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000888A4 File Offset: 0x00086AA4
		internal static void smethod_89(GStruct43 gstruct43_0, uint uint_0, uint uint_1)
		{
			GClass94.smethod_76(gstruct43_0, uint_0, uint_1);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000888BC File Offset: 0x00086ABC
		internal static void smethod_90(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass94.smethod_94(gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000888D4 File Offset: 0x00086AD4
		internal static void smethod_91(GStruct43 gstruct43_0, uint uint_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetVerticalScroll(<Module>.smethod_19(), gstruct43_0, uint_0);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000888F4 File Offset: 0x00086AF4
		public static void smethod_92(GStruct43 gstruct43_0, float float_0, int int_0, int int_1)
		{
			GClass94.smethod_26(gstruct43_0, float_0, int_0, int_1);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0008890C File Offset: 0x00086B0C
		internal static void smethod_93(GStruct43 gstruct43_0, string string_0)
		{
			GClass94.smethod_85(gstruct43_0, string_0);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00088920 File Offset: 0x00086B20
		internal static void smethod_94(GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_KeyUp(<Module>.smethod_19(), gstruct43_0, uint_0, genum19_0);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00088940 File Offset: 0x00086B40
		public static void smethod_95(GStruct43 gstruct43_0, IntPtr intptr_0)
		{
			GClass94.smethod_51(gstruct43_0, intptr_0);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00088954 File Offset: 0x00086B54
		internal static void smethod_96(GStruct43 gstruct43_0)
		{
			GClass94.smethod_24(gstruct43_0);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00088968 File Offset: 0x00086B68
		internal static void smethod_97(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_ViewSource(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00088988 File Offset: 0x00086B88
		internal static void smethod_98(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_StopFind(<Module>.smethod_19(), gstruct43_0);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000889A8 File Offset: 0x00086BA8
		internal static void smethod_99(GStruct43 gstruct43_0, bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_SetBackgroundMode(<Module>.smethod_19(), gstruct43_0, bool_0);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000889C8 File Offset: 0x00086BC8
		internal static void smethod_100(GStruct43 gstruct43_0, string string_0, string string_1)
		{
			GClass94.smethod_70(gstruct43_0, string_0, string_1);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000889E0 File Offset: 0x00086BE0
		internal static void smethod_101(GStruct43 gstruct43_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamHTMLSurface_RemoveBrowser(<Module>.smethod_19(), gstruct43_0);
		}
	}
}
