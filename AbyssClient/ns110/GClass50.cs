using System;
using ns142;
using ns179;
using ns195;
using ns226;
using ns280;
using ns3;
using ns304;
using ns370;
using ns50;
using ns528;
using ns552;
using ns74;

namespace ns110
{
	// Token: 0x02000094 RID: 148
	public static class GClass50
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00011B78 File Offset: 0x0000FD78
		public static void smethod_0()
		{
			GClass50.smethod_12();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public static bool smethod_1(GStruct83 gstruct83_0, GStruct189 gstruct189_0, float float_0, float float_1, float float_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_ShowAnalogActionOrigins(<Module>.smethod_14(), gstruct83_0, gstruct189_0, float_0, float_1, float_2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		public static GStruct189 smethod_2(string string_0)
		{
			GClass78.smethod_1();
			GStruct189 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct189.smethod_3(Class177.SteamAPI_ISteamController_GetAnalogActionHandle(<Module>.smethod_14(), gclass));
			}
			return result;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00011BFC File Offset: 0x0000FDFC
		public static string smethod_3(GEnum33 genum33_0)
		{
			return GClass50.smethod_18(genum33_0);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00011C10 File Offset: 0x0000FE10
		internal static void smethod_4(GStruct83 gstruct83_0, byte byte_0, byte byte_1, byte byte_2, uint uint_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_SetLEDColor(<Module>.smethod_14(), gstruct83_0, byte_0, byte_1, byte_2, uint_0);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00011C34 File Offset: 0x0000FE34
		internal static void smethod_5(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_13(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00011C48 File Offset: 0x0000FE48
		public static int smethod_6(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetGamepadIndexForController(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00011C68 File Offset: 0x0000FE68
		public static void smethod_7(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_41(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00011C7C File Offset: 0x0000FE7C
		public static void smethod_8(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0)
		{
			GClass50.smethod_36(gstruct83_0, genum22_0, ushort_0);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00011C94 File Offset: 0x0000FE94
		public static void smethod_9(GStruct83 gstruct83_0, GStruct189 gstruct189_0)
		{
			GClass50.smethod_34(gstruct83_0, gstruct189_0);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		internal static void smethod_10(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, uint uint_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_TriggerRepeatedHapticPulse(<Module>.smethod_14(), gstruct83_0, genum22_0, ushort_0, ushort_1, ushort_2, uint_0);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00011CCC File Offset: 0x0000FECC
		public static GStruct202 smethod_11(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetMotionData(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00011CEC File Offset: 0x0000FEEC
		internal static void smethod_12()
		{
			GClass50.smethod_54();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00011D00 File Offset: 0x0000FF00
		internal static void smethod_13(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_ActivateActionSet(<Module>.smethod_14(), gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00011D20 File Offset: 0x0000FF20
		internal static void smethod_14(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_DeactivateActionSetLayer(<Module>.smethod_14(), gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00011D40 File Offset: 0x0000FF40
		public static GStruct290 smethod_15(string string_0)
		{
			GClass78.smethod_1();
			GStruct290 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct290.smethod_0(Class177.SteamAPI_ISteamController_GetActionSetHandle(<Module>.smethod_14(), gclass));
			}
			return result;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00011D8C File Offset: 0x0000FF8C
		internal static string smethod_16(GEnum33 genum33_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamController_GetGlyphForActionOrigin(<Module>.smethod_14(), genum33_0));
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public static bool smethod_17()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_Init(<Module>.smethod_14());
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00011DCC File Offset: 0x0000FFCC
		internal static string smethod_18(GEnum33 genum33_0)
		{
			return GClass50.smethod_16(genum33_0);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public static void smethod_19(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, uint uint_0)
		{
			GClass50.smethod_30(gstruct83_0, genum22_0, ushort_0, ushort_1, ushort_2, uint_0);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00011E00 File Offset: 0x00010000
		public static int smethod_20(GStruct83 gstruct83_0, GStruct290 gstruct290_0, GStruct189 gstruct189_0, GEnum33[] genum33_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetAnalogActionOrigins(<Module>.smethod_14(), gstruct83_0, gstruct290_0, gstruct189_0, genum33_0);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00011E24 File Offset: 0x00010024
		public static bool smethod_21(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_ShowBindingPanel(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00011E44 File Offset: 0x00010044
		public static string smethod_22(GEnum33 genum33_0)
		{
			return GClass50.smethod_48(genum33_0);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00011E58 File Offset: 0x00010058
		internal static void smethod_23(GStruct83 gstruct83_0)
		{
			GClass50.smethod_52(gstruct83_0);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00011E6C File Offset: 0x0001006C
		internal static void smethod_24(GStruct83 gstruct83_0, GStruct189 gstruct189_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_StopAnalogActionMomentum(<Module>.smethod_14(), gstruct83_0, gstruct189_0);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00011E8C File Offset: 0x0001008C
		public static bool smethod_25(GStruct83 gstruct83_0, GStruct20 gstruct20_0, float float_0, float float_1, float float_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_ShowDigitalActionOrigins(<Module>.smethod_14(), gstruct83_0, gstruct20_0, float_0, float_1, float_2);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00011EB0 File Offset: 0x000100B0
		internal static string smethod_26(GEnum33 genum33_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamController_GetStringForActionOrigin(<Module>.smethod_14(), genum33_0));
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00011ED4 File Offset: 0x000100D4
		public static int smethod_27(GStruct83 gstruct83_0, GStruct290 gstruct290_0, GStruct20 gstruct20_0, GEnum33[] genum33_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetDigitalActionOrigins(<Module>.smethod_14(), gstruct83_0, gstruct290_0, gstruct20_0, genum33_0);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00011EF8 File Offset: 0x000100F8
		public static GStruct304 smethod_28(GStruct83 gstruct83_0, GStruct20 gstruct20_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetDigitalActionData(<Module>.smethod_14(), gstruct83_0, gstruct20_0);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00011F18 File Offset: 0x00010118
		public static GStruct290 smethod_29(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			return GStruct290.smethod_0(Class177.SteamAPI_ISteamController_GetCurrentActionSet(<Module>.smethod_14(), gstruct83_0));
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00011F3C File Offset: 0x0001013C
		internal static void smethod_30(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, uint uint_0)
		{
			GClass50.smethod_10(gstruct83_0, genum22_0, ushort_0, ushort_1, ushort_2, uint_0);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00011F5C File Offset: 0x0001015C
		public static int smethod_31(GStruct83[] gstruct83_0)
		{
			GClass78.smethod_1();
			if (gstruct83_0.Length != 16)
			{
				throw new ArgumentException("handlesOut must be the same size as Constants.STEAM_CONTROLLER_MAX_COUNT!");
			}
			return Class177.SteamAPI_ISteamController_GetConnectedControllers(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00011F94 File Offset: 0x00010194
		public static GStruct83 smethod_32(int int_0)
		{
			GClass78.smethod_1();
			return GStruct83.smethod_0(Class177.SteamAPI_ISteamController_GetControllerForGamepadIndex(<Module>.smethod_14(), int_0));
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00011FB8 File Offset: 0x000101B8
		public static GStruct1 smethod_33(GStruct83 gstruct83_0, GStruct189 gstruct189_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetAnalogActionData(<Module>.smethod_14(), gstruct83_0, gstruct189_0);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00011FD8 File Offset: 0x000101D8
		internal static void smethod_34(GStruct83 gstruct83_0, GStruct189 gstruct189_0)
		{
			GClass50.smethod_24(gstruct83_0, gstruct189_0);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00011FEC File Offset: 0x000101EC
		public static bool smethod_35()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_Shutdown(<Module>.smethod_14());
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00012008 File Offset: 0x00010208
		internal static void smethod_36(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0)
		{
			GClass50.smethod_43(gstruct83_0, genum22_0, ushort_0);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00012020 File Offset: 0x00010220
		internal static void smethod_37(GStruct83 gstruct83_0, ushort ushort_0, ushort ushort_1)
		{
			GClass50.smethod_40(gstruct83_0, ushort_0, ushort_1);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00012038 File Offset: 0x00010238
		internal static void smethod_38(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_ActivateActionSetLayer(<Module>.smethod_14(), gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00012058 File Offset: 0x00010258
		public static void smethod_39(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_44(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001206C File Offset: 0x0001026C
		internal static void smethod_40(GStruct83 gstruct83_0, ushort ushort_0, ushort ushort_1)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_TriggerVibration(<Module>.smethod_14(), gstruct83_0, ushort_0, ushort_1);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001208C File Offset: 0x0001028C
		internal static void smethod_41(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_38(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000120A0 File Offset: 0x000102A0
		internal static void smethod_42(GStruct83 gstruct83_0, byte byte_0, byte byte_1, byte byte_2, uint uint_0)
		{
			GClass50.smethod_4(gstruct83_0, byte_0, byte_1, byte_2, uint_0);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000120BC File Offset: 0x000102BC
		internal static void smethod_43(GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_TriggerHapticPulse(<Module>.smethod_14(), gstruct83_0, genum22_0, ushort_0);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000120DC File Offset: 0x000102DC
		internal static void smethod_44(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_14(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000120F0 File Offset: 0x000102F0
		public static void smethod_45(GStruct83 gstruct83_0)
		{
			GClass50.smethod_23(gstruct83_0);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00012104 File Offset: 0x00010304
		public static void smethod_46(GStruct83 gstruct83_0, ushort ushort_0, ushort ushort_1)
		{
			GClass50.smethod_37(gstruct83_0, ushort_0, ushort_1);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001211C File Offset: 0x0001031C
		public static GStruct20 smethod_47(string string_0)
		{
			GClass78.smethod_1();
			GStruct20 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct20.smethod_1(Class177.SteamAPI_ISteamController_GetDigitalActionHandle(<Module>.smethod_14(), gclass));
			}
			return result;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00012168 File Offset: 0x00010368
		internal static string smethod_48(GEnum33 genum33_0)
		{
			return GClass50.smethod_26(genum33_0);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001217C File Offset: 0x0001037C
		public static void smethod_49(GStruct83 gstruct83_0, GStruct290 gstruct290_0)
		{
			GClass50.smethod_5(gstruct83_0, gstruct290_0);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00012190 File Offset: 0x00010390
		public static int smethod_50(GStruct83 gstruct83_0, out GStruct290 gstruct290_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetActiveActionSetLayers(<Module>.smethod_14(), gstruct83_0, out gstruct290_0);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000121B0 File Offset: 0x000103B0
		public static void smethod_51(GStruct83 gstruct83_0, byte byte_0, byte byte_1, byte byte_2, uint uint_0)
		{
			GClass50.smethod_42(gstruct83_0, byte_0, byte_1, byte_2, uint_0);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000121CC File Offset: 0x000103CC
		internal static void smethod_52(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_DeactivateAllActionSetLayers(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000121EC File Offset: 0x000103EC
		public static GEnum6 smethod_53(GStruct83 gstruct83_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamController_GetInputTypeForHandle(<Module>.smethod_14(), gstruct83_0);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001220C File Offset: 0x0001040C
		internal static void smethod_54()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamController_RunFrame(<Module>.smethod_14());
		}
	}
}
