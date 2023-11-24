using System;
using System.IO;
using Newtonsoft.Json;
using ns137;

namespace ns375
{
	// Token: 0x020002DF RID: 735
	public class GClass117
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x000AD854 File Offset: 0x000ABA54
		internal static void smethod_0()
		{
			GClass117.smethod_1();
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000ADED0 File Offset: 0x000AC0D0
		internal static void smethod_1()
		{
			GClass59.smethod_4();
			Directory.CreateDirectory(GClass117.string_0);
			if (!File.Exists(GClass117.string_0 + "//" + "config.json"))
			{
				GClass117.gclass117_0 = new GClass117();
				GClass117.smethod_3();
			}
			else
			{
				GClass117.gclass117_0 = JsonConvert.DeserializeObject<GClass117>(File.ReadAllText(GClass117.string_0 + "//" + "config.json"));
				if (GClass117.gclass117_0 == null)
				{
					GClass117.gclass117_0 = new GClass117();
				}
				GClass117.smethod_3();
			}
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000ADF58 File Offset: 0x000AC158
		internal static void smethod_2()
		{
			GClass117.smethod_0();
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000ADF90 File Offset: 0x000AC190
		internal static void smethod_3()
		{
			GClass117.smethod_4();
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000ADFA4 File Offset: 0x000AC1A4
		internal static void smethod_4()
		{
			GClass117.smethod_5();
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000ADFB8 File Offset: 0x000AC1B8
		internal static void smethod_5()
		{
			if (GClass117.gclass117_0 != null)
			{
				File.WriteAllText(GClass117.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass117.gclass117_0, 1));
			}
		}

		// Token: 0x04001354 RID: 4948
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/Main_Config");

		// Token: 0x04001355 RID: 4949
		internal static GClass117 gclass117_0;

		// Token: 0x04001356 RID: 4950
		[JsonProperty("bWaitForUserActionBeforeStart")]
		public bool bool_0 = false;

		// Token: 0x04001357 RID: 4951
		[JsonProperty("bDisableSteam")]
		public bool bool_1 = true;

		// Token: 0x04001358 RID: 4952
		[JsonProperty("bJoinNotifier_Enabled")]
		public bool bool_2 = true;

		// Token: 0x04001359 RID: 4953
		[JsonProperty("bHideSafeModeButton")]
		public bool bool_3 = false;

		// Token: 0x0400135A RID: 4954
		[JsonProperty("LoadingMusicPath")]
		public string string_1 = string.Empty;

		// Token: 0x0400135B RID: 4955
		[JsonProperty("FirstLoadingMusicPath")]
		public string string_2 = string.Empty;

		// Token: 0x0400135C RID: 4956
		[JsonProperty("bStartAbyssClientLoadingOnLoadingScreen")]
		public bool bool_4 = true;

		// Token: 0x0400135D RID: 4957
		[JsonProperty("bStartAbyssClientLoadingOnFirstLoadingScreen")]
		public bool bool_5 = true;

		// Token: 0x0400135E RID: 4958
		[JsonProperty("bStopAbyssClientLoadingOnJoinWorld")]
		public bool bool_6 = true;

		// Token: 0x0400135F RID: 4959
		[JsonProperty("bDisableOriginalLoadingSound")]
		public bool bool_7 = true;

		// Token: 0x04001360 RID: 4960
		[JsonProperty("bUseLocalPlayerPrefs")]
		public bool bool_8 = false;

		// Token: 0x04001361 RID: 4961
		[JsonProperty("bUseCoreLimiter")]
		public bool bool_9 = true;

		// Token: 0x04001362 RID: 4962
		[JsonProperty("bUseSmoothFPSCounter")]
		public bool bool_10 = true;

		// Token: 0x04001363 RID: 4963
		[JsonProperty("TargetedFPS")]
		public int int_0 = 90;

		// Token: 0x04001364 RID: 4964
		[JsonProperty("TabbedOutFPS")]
		public int int_1 = 30;

		// Token: 0x04001365 RID: 4965
		[JsonProperty("bKeybinds")]
		public bool bool_11 = true;

		// Token: 0x04001366 RID: 4966
		[JsonProperty("bNameplatesInfo")]
		public bool bool_12 = true;

		// Token: 0x04001367 RID: 4967
		[JsonProperty("bAntiAdminPanel")]
		public bool bool_13 = false;

		// Token: 0x04001368 RID: 4968
		[JsonProperty("bChangeColorsOfText")]
		public bool bool_14 = true;

		// Token: 0x04001369 RID: 4969
		[JsonProperty("bRainbowColorsOfText")]
		public bool bool_15 = false;

		// Token: 0x0400136A RID: 4970
		[JsonProperty("bChangeColorsOfButtons")]
		public bool bool_16 = true;

		// Token: 0x0400136B RID: 4971
		[JsonProperty("bRainbowColorsOfButtons")]
		public bool bool_17 = false;

		// Token: 0x0400136C RID: 4972
		[JsonProperty("bChangeColorsOfCursor")]
		public bool bool_18 = true;

		// Token: 0x0400136D RID: 4973
		[JsonProperty("bChangeColorsOfHighlights")]
		public bool bool_19 = true;

		// Token: 0x0400136E RID: 4974
		[JsonProperty("bChangeColorOfLoadingBackground")]
		public bool bool_20 = false;

		// Token: 0x0400136F RID: 4975
		[JsonProperty("bChangeColorOfLoadingBar")]
		public bool bool_21 = true;

		// Token: 0x04001370 RID: 4976
		[JsonProperty("bHideMenuBackground")]
		public bool bool_22 = false;

		// Token: 0x04001371 RID: 4977
		[JsonProperty("NewMenuBackgroundTextureLink")]
		public string string_3 = string.Empty;

		// Token: 0x04001372 RID: 4978
		[JsonProperty("ColorOfMenuBackground_r")]
		public float float_0 = 0f;

		// Token: 0x04001373 RID: 4979
		[JsonProperty("ColorOfMenuBackground_g")]
		public float float_1 = 0.5f;

		// Token: 0x04001374 RID: 4980
		[JsonProperty("ColorOfMenuBackground_b")]
		public float float_2 = 0.75f;

		// Token: 0x04001375 RID: 4981
		[JsonProperty("ColorOfMenuBackground_a")]
		public float float_3 = 0.33f;

		// Token: 0x04001376 RID: 4982
		[JsonProperty("bChangeQuickMenuBackground")]
		public bool bool_23 = false;

		// Token: 0x04001377 RID: 4983
		[JsonProperty("bHideQuickMenuBackground")]
		public bool bool_24 = false;

		// Token: 0x04001378 RID: 4984
		[JsonProperty("NewQuickMenuBackgroundTextureLink")]
		public string string_4 = string.Empty;

		// Token: 0x04001379 RID: 4985
		[JsonProperty("ColorOfQuickMenuBackground_r")]
		public float float_4 = 0.1f;

		// Token: 0x0400137A RID: 4986
		[JsonProperty("ColorOfQuickMenuBackground_g")]
		public float float_5 = 0.1f;

		// Token: 0x0400137B RID: 4987
		[JsonProperty("ColorOfQuickMenuBackground_b")]
		public float float_6 = 0.1f;

		// Token: 0x0400137C RID: 4988
		[JsonProperty("ColorOfQuickMenuBackground_a")]
		public float float_7 = 0.5f;

		// Token: 0x0400137D RID: 4989
		[JsonProperty("PressedColorOfButtons_r")]
		public float float_8 = 0.5f;

		// Token: 0x0400137E RID: 4990
		[JsonProperty("PressedColorOfButtons_g")]
		public float float_9 = 0.5f;

		// Token: 0x0400137F RID: 4991
		[JsonProperty("PressedColorOfButtons_b")]
		public float float_10 = 0.5f;

		// Token: 0x04001380 RID: 4992
		[JsonProperty("ColorOfButtons_r")]
		public float float_11 = 0.5f;

		// Token: 0x04001381 RID: 4993
		[JsonProperty("ColorOfButtons_g")]
		public float float_12 = 0.5f;

		// Token: 0x04001382 RID: 4994
		[JsonProperty("ColorOfButtons_b")]
		public float float_13 = 1f;

		// Token: 0x04001383 RID: 4995
		[JsonProperty("DisabledColorOfButtons_r")]
		public float float_14 = 0.25f;

		// Token: 0x04001384 RID: 4996
		[JsonProperty("DisabledColorOfButtons_g")]
		public float float_15 = 0.25f;

		// Token: 0x04001385 RID: 4997
		[JsonProperty("DisabledColorOfButtons_b")]
		public float float_16 = 0.25f;

		// Token: 0x04001386 RID: 4998
		[JsonProperty("HighlightedColorOfButtons_r")]
		public float float_17 = 0.25f;

		// Token: 0x04001387 RID: 4999
		[JsonProperty("HighlightedColorOfButtons_g")]
		public float float_18 = 1f;

		// Token: 0x04001388 RID: 5000
		[JsonProperty("HighlightedColorOfButtons_b")]
		public float float_19 = 0.25f;

		// Token: 0x04001389 RID: 5001
		[JsonProperty("ColorOfCursor_r")]
		public float float_20 = 0.5f;

		// Token: 0x0400138A RID: 5002
		[JsonProperty("ColorOfCursor_g")]
		public float float_21 = 0f;

		// Token: 0x0400138B RID: 5003
		[JsonProperty("ColorOfCursor_b")]
		public float float_22 = 1f;

		// Token: 0x0400138C RID: 5004
		[JsonProperty("ColorOfUICursor_r")]
		public float float_23 = 0.5f;

		// Token: 0x0400138D RID: 5005
		[JsonProperty("ColorOfUICursor_g")]
		public float float_24 = 0f;

		// Token: 0x0400138E RID: 5006
		[JsonProperty("ColorOfUICursor_b")]
		public float float_25 = 1f;

		// Token: 0x0400138F RID: 5007
		[JsonProperty("ColorOfInteractiveCursor_r")]
		public float float_26 = 0.5f;

		// Token: 0x04001390 RID: 5008
		[JsonProperty("ColorOfInteractiveCursor_g")]
		public float float_27 = 0f;

		// Token: 0x04001391 RID: 5009
		[JsonProperty("ColorOfInteractiveCursor_b")]
		public float float_28 = 1f;

		// Token: 0x04001392 RID: 5010
		[JsonProperty("ColorOfText_r")]
		public float float_29 = 0.5f;

		// Token: 0x04001393 RID: 5011
		[JsonProperty("ColorOfText_g")]
		public float float_30 = 1f;

		// Token: 0x04001394 RID: 5012
		[JsonProperty("ColorOfText_b")]
		public float float_31 = 1f;

		// Token: 0x04001395 RID: 5013
		[JsonProperty("ColorOfHighlights_r")]
		public float float_32 = 0f;

		// Token: 0x04001396 RID: 5014
		[JsonProperty("ColorOfHighlights_g")]
		public float float_33 = 1f;

		// Token: 0x04001397 RID: 5015
		[JsonProperty("ColorOfHighlights_b")]
		public float float_34 = 0f;

		// Token: 0x04001398 RID: 5016
		[JsonProperty("ColorOfLoadingBackground_r")]
		public float float_35 = 0.25f;

		// Token: 0x04001399 RID: 5017
		[JsonProperty("ColorOfLoadingBackground_g")]
		public float float_36 = 0.5f;

		// Token: 0x0400139A RID: 5018
		[JsonProperty("ColorOfLoadingBackground_b")]
		public float float_37 = 1f;

		// Token: 0x0400139B RID: 5019
		[JsonProperty("ColorOfLoadingBar_Min_r")]
		public float float_38 = 1f;

		// Token: 0x0400139C RID: 5020
		[JsonProperty("ColorOfLoadingBar_Min_g")]
		public float float_39 = 0f;

		// Token: 0x0400139D RID: 5021
		[JsonProperty("ColorOfLoadingBar_Min_b")]
		public float float_40 = 0f;

		// Token: 0x0400139E RID: 5022
		[JsonProperty("ColorOfLoadingBar_Medium_r")]
		public float float_41 = 1f;

		// Token: 0x0400139F RID: 5023
		[JsonProperty("ColorOfLoadingBar_Medium_g")]
		public float float_42 = 1f;

		// Token: 0x040013A0 RID: 5024
		[JsonProperty("ColorOfLoadingBar_Medium_b")]
		public float float_43 = 0f;

		// Token: 0x040013A1 RID: 5025
		[JsonProperty("ColorOfLoadingBar_Max_r")]
		public float float_44 = 0f;

		// Token: 0x040013A2 RID: 5026
		[JsonProperty("ColorOfLoadingBar_Max_g")]
		public float float_45 = 1f;

		// Token: 0x040013A3 RID: 5027
		[JsonProperty("ColorOfLoadingBar_Max_b")]
		public float float_46 = 0f;

		// Token: 0x040013A4 RID: 5028
		[JsonProperty("CurrentTheme")]
		public string string_5 = "Abyss";

		// Token: 0x040013A5 RID: 5029
		[JsonProperty("ESP_bEnabled")]
		public bool bool_25 = false;

		// Token: 0x040013A6 RID: 5030
		[JsonProperty("ColorOfESP_Players_Visitors_r")]
		public float float_47 = 1f;

		// Token: 0x040013A7 RID: 5031
		[JsonProperty("ColorOfESP_Players_Visitors_g")]
		public float float_48 = 1f;

		// Token: 0x040013A8 RID: 5032
		[JsonProperty("ColorOfESP_Players_Visitors_b")]
		public float float_49 = 1f;

		// Token: 0x040013A9 RID: 5033
		[JsonProperty("bRainbowColorsOfESP_Players_Visitors")]
		public bool bool_26 = false;

		// Token: 0x040013AA RID: 5034
		[JsonProperty("ColorOfESP_Players_NewUsers_r")]
		public float float_50 = 0.09f;

		// Token: 0x040013AB RID: 5035
		[JsonProperty("ColorOfESP_Players_NewUsers_g")]
		public float float_51 = 0.47f;

		// Token: 0x040013AC RID: 5036
		[JsonProperty("ColorOfESP_Players_NewUsers_b")]
		public float float_52 = 1f;

		// Token: 0x040013AD RID: 5037
		[JsonProperty("bRainbowColorsOfESP_Players_NewUsers")]
		public bool bool_27 = false;

		// Token: 0x040013AE RID: 5038
		[JsonProperty("ColorOfESP_Players_Users_r")]
		public float float_53 = 0.17f;

		// Token: 0x040013AF RID: 5039
		[JsonProperty("ColorOfESP_Players_Users_g")]
		public float float_54 = 0.81f;

		// Token: 0x040013B0 RID: 5040
		[JsonProperty("ColorOfESP_Players_Users_b")]
		public float float_55 = 0.36f;

		// Token: 0x040013B1 RID: 5041
		[JsonProperty("bRainbowColorsOfESP_Players_Users")]
		public bool bool_28 = false;

		// Token: 0x040013B2 RID: 5042
		[JsonProperty("ColorOfESP_Players_KnownUsers_r")]
		public float float_56 = 1f;

		// Token: 0x040013B3 RID: 5043
		[JsonProperty("ColorOfESP_Players_KnownUsers_g")]
		public float float_57 = 0.48f;

		// Token: 0x040013B4 RID: 5044
		[JsonProperty("ColorOfESP_Players_KnownUsers_b")]
		public float float_58 = 0.26f;

		// Token: 0x040013B5 RID: 5045
		[JsonProperty("bRainbowColorsOfESP_Players_KnownUsers")]
		public bool bool_29 = false;

		// Token: 0x040013B6 RID: 5046
		[JsonProperty("ColorOfESP_Players_TrustedUsers_r")]
		public float float_59 = 0.5f;

		// Token: 0x040013B7 RID: 5047
		[JsonProperty("ColorOfESP_Players_TrustedUsers_g")]
		public float float_60 = 0.26f;

		// Token: 0x040013B8 RID: 5048
		[JsonProperty("ColorOfESP_Players_TrustedUsers_b")]
		public float float_61 = 0.9f;

		// Token: 0x040013B9 RID: 5049
		[JsonProperty("bRainbowColorsOfESP_Players_TrustedUsers")]
		public bool bool_30 = false;

		// Token: 0x040013BA RID: 5050
		[JsonProperty("ColorOfESP_Players_VeteranUsers_r")]
		public float float_62 = 1f;

		// Token: 0x040013BB RID: 5051
		[JsonProperty("ColorOfESP_Players_VeteranUsers_g")]
		public float float_63 = 1f;

		// Token: 0x040013BC RID: 5052
		[JsonProperty("ColorOfESP_Players_VeteranUsers_b")]
		public float float_64 = 0f;

		// Token: 0x040013BD RID: 5053
		[JsonProperty("bRainbowColorsOfESP_Players_VeteranUsers")]
		public bool bool_31 = false;

		// Token: 0x040013BE RID: 5054
		[JsonProperty("ColorOfESP_Players_LegendaryUsers_r")]
		public float float_65 = 1f;

		// Token: 0x040013BF RID: 5055
		[JsonProperty("ColorOfESP_Players_LegendaryUsers_g")]
		public float float_66 = 0.41f;

		// Token: 0x040013C0 RID: 5056
		[JsonProperty("ColorOfESP_Players_LegendaryUsers_b")]
		public float float_67 = 0.7f;

		// Token: 0x040013C1 RID: 5057
		[JsonProperty("bRainbowColorsOfESP_Players_LegendaryUsers")]
		public bool bool_32 = false;

		// Token: 0x040013C2 RID: 5058
		[JsonProperty("ColorOfESP_Players_Friends_r")]
		public float float_68 = 1f;

		// Token: 0x040013C3 RID: 5059
		[JsonProperty("ColorOfESP_Players_Friends_g")]
		public float float_69 = 1f;

		// Token: 0x040013C4 RID: 5060
		[JsonProperty("ColorOfESP_Players_Friends_b")]
		public float float_70 = 0f;

		// Token: 0x040013C5 RID: 5061
		[JsonProperty("bRainbowColorsOfESP_Players_Friends")]
		public bool bool_33 = true;

		// Token: 0x040013C6 RID: 5062
		[JsonProperty("ColorOfESP_Hacks_Murder2_r")]
		public float float_71 = 0f;

		// Token: 0x040013C7 RID: 5063
		[JsonProperty("ColorOfESP_Hacks_Murder2_g")]
		public float float_72 = 1f;

		// Token: 0x040013C8 RID: 5064
		[JsonProperty("ColorOfESP_Hacks_Murder2_b")]
		public float float_73 = 1f;

		// Token: 0x040013C9 RID: 5065
		[JsonProperty("ColorOfESP_Hacks_r")]
		public float float_74 = 1f;

		// Token: 0x040013CA RID: 5066
		[JsonProperty("ColorOfESP_Hacks_g")]
		public float float_75 = 0f;

		// Token: 0x040013CB RID: 5067
		[JsonProperty("ColorOfESP_Hacks_b")]
		public float float_76 = 1f;

		// Token: 0x040013CC RID: 5068
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Crewmates_r")]
		public float float_77 = 0f;

		// Token: 0x040013CD RID: 5069
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Crewmates_g")]
		public float float_78 = 1f;

		// Token: 0x040013CE RID: 5070
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Crewmates_b")]
		public float float_79 = 1f;

		// Token: 0x040013CF RID: 5071
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Imposters_r")]
		public float float_80 = 1f;

		// Token: 0x040013D0 RID: 5072
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Imposters_g")]
		public float float_81 = 0f;

		// Token: 0x040013D1 RID: 5073
		[JsonProperty("ColorOfESP_Hacks_AmongUs_Imposters_b")]
		public float float_82 = 1f;

		// Token: 0x040013D2 RID: 5074
		[JsonProperty("ColorOfESP_Hacks_Murder4_Clues_r")]
		public float float_83 = 1f;

		// Token: 0x040013D3 RID: 5075
		[JsonProperty("ColorOfESP_Hacks_Murder4_Clues_g")]
		public float float_84 = 1f;

		// Token: 0x040013D4 RID: 5076
		[JsonProperty("ColorOfESP_Hacks_Murder4_Clues_b")]
		public float float_85 = 1f;

		// Token: 0x040013D5 RID: 5077
		[JsonProperty("ColorOfESP_Hacks_Murder4_WithoutRole_r")]
		public float float_86 = 1f;

		// Token: 0x040013D6 RID: 5078
		[JsonProperty("ColorOfESP_Hacks_Murder4_WithoutRole_g")]
		public float float_87 = 1f;

		// Token: 0x040013D7 RID: 5079
		[JsonProperty("ColorOfESP_Hacks_Murder4_WithoutRole_b")]
		public float float_88 = 1f;

		// Token: 0x040013D8 RID: 5080
		[JsonProperty("ColorOfESP_Hacks_Murder4_Bystanders_r")]
		public float float_89 = 0f;

		// Token: 0x040013D9 RID: 5081
		[JsonProperty("ColorOfESP_Hacks_Murder4_Bystanders_g")]
		public float float_90 = 1f;

		// Token: 0x040013DA RID: 5082
		[JsonProperty("ColorOfESP_Hacks_Murder4_Bystanders_b")]
		public float float_91 = 1f;

		// Token: 0x040013DB RID: 5083
		[JsonProperty("ColorOfESP_Hacks_Murder4_Murderers_r")]
		public float float_92 = 1f;

		// Token: 0x040013DC RID: 5084
		[JsonProperty("ColorOfESP_Hacks_Murder4_Murderers_g")]
		public float float_93 = 0f;

		// Token: 0x040013DD RID: 5085
		[JsonProperty("ColorOfESP_Hacks_Murder4_Murderers_b")]
		public float float_94 = 1f;

		// Token: 0x040013DE RID: 5086
		[JsonProperty("ColorOfESP_Hacks_Murder4_Detectives_r")]
		public float float_95 = 0f;

		// Token: 0x040013DF RID: 5087
		[JsonProperty("ColorOfESP_Hacks_Murder4_Detectives_g")]
		public float float_96 = 0f;

		// Token: 0x040013E0 RID: 5088
		[JsonProperty("ColorOfESP_Hacks_Murder4_Detectives_b")]
		public float float_97 = 1f;

		// Token: 0x040013E1 RID: 5089
		[JsonProperty("ColorOfESP_Hacks_Murder4_Knives_r")]
		public float float_98 = 1f;

		// Token: 0x040013E2 RID: 5090
		[JsonProperty("ColorOfESP_Hacks_Murder4_Knives_g")]
		public float float_99 = 0f;

		// Token: 0x040013E3 RID: 5091
		[JsonProperty("ColorOfESP_Hacks_Murder4_Knives_b")]
		public float float_100 = 0f;

		// Token: 0x040013E4 RID: 5092
		[JsonProperty("ColorOfESP_Hacks_Murder4_BearTraps_r")]
		public float float_101 = 1f;

		// Token: 0x040013E5 RID: 5093
		[JsonProperty("ColorOfESP_Hacks_Murder4_BearTraps_g")]
		public float float_102 = 0f;

		// Token: 0x040013E6 RID: 5094
		[JsonProperty("ColorOfESP_Hacks_Murder4_BearTraps_b")]
		public float float_103 = 0f;

		// Token: 0x040013E7 RID: 5095
		[JsonProperty("ColorOfESP_Hacks_Murder4_Revolvers_r")]
		public float float_104 = 0f;

		// Token: 0x040013E8 RID: 5096
		[JsonProperty("ColorOfESP_Hacks_Murder4_Revolvers_g")]
		public float float_105 = 0f;

		// Token: 0x040013E9 RID: 5097
		[JsonProperty("ColorOfESP_Hacks_Murder4_Revolvers_b")]
		public float float_106 = 1f;

		// Token: 0x040013EA RID: 5098
		[JsonProperty("ColorOfESP_Hacks_Murder4_UnlockableWeapons_r")]
		public float float_107 = 0f;

		// Token: 0x040013EB RID: 5099
		[JsonProperty("ColorOfESP_Hacks_Murder4_UnlockableWeapons_g")]
		public float float_108 = 1f;

		// Token: 0x040013EC RID: 5100
		[JsonProperty("ColorOfESP_Hacks_Murder4_UnlockableWeapons_b")]
		public float float_109 = 1f;

		// Token: 0x040013ED RID: 5101
		[JsonProperty("ColorOfESP_Hacks_Murder4_Polaroids_r")]
		public float float_110 = 1f;

		// Token: 0x040013EE RID: 5102
		[JsonProperty("ColorOfESP_Hacks_Murder4_Polaroids_g")]
		public float float_111 = 1f;

		// Token: 0x040013EF RID: 5103
		[JsonProperty("ColorOfESP_Hacks_Murder4_Polaroids_b")]
		public float float_112 = 1f;

		// Token: 0x040013F0 RID: 5104
		[JsonProperty("ColorOfESP_Hacks_Murder4_SnakeDispensers_r")]
		public float float_113 = 1f;

		// Token: 0x040013F1 RID: 5105
		[JsonProperty("ColorOfESP_Hacks_Murder4_SnakeDispensers_g")]
		public float float_114 = 0f;

		// Token: 0x040013F2 RID: 5106
		[JsonProperty("ColorOfESP_Hacks_Murder4_SnakeDispensers_b")]
		public float float_115 = 1f;

		// Token: 0x040013F3 RID: 5107
		[JsonProperty("ColorOfESP_Hacks_Murder4_Snakes_r")]
		public float float_116 = 1f;

		// Token: 0x040013F4 RID: 5108
		[JsonProperty("ColorOfESP_Hacks_Murder4_Snakes_g")]
		public float float_117 = 0f;

		// Token: 0x040013F5 RID: 5109
		[JsonProperty("ColorOfESP_Hacks_Murder4_Snakes_b")]
		public float float_118 = 0f;
	}
}
