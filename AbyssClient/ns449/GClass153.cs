using System;
using System.Collections.Generic;
using System.IO;
using ns241;
using ns425;
using UnityEngine;

namespace ns449
{
	// Token: 0x0200021B RID: 539
	public class GClass153 : GClass130
	{
		// Token: 0x060018B2 RID: 6322 RVA: 0x0007F8F4 File Offset: 0x0007DAF4
		private void method_2()
		{
			this.method_4();
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0007F908 File Offset: 0x0007DB08
		internal void method_3()
		{
			this.method_6();
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0007F91C File Offset: 0x0007DB1C
		private void method_4()
		{
			this.method_5();
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0007F930 File Offset: 0x0007DB30
		private void method_5()
		{
			if (!Directory.Exists(this.string_1))
			{
				Directory.CreateDirectory(this.string_1);
			}
			if (!Directory.Exists(Path.Combine(this.string_1, "HUD")))
			{
				Directory.CreateDirectory(Path.Combine(this.string_1, "HUD"));
			}
			if (!Directory.Exists(Path.Combine(this.string_1, "Textures")))
			{
				Directory.CreateDirectory(Path.Combine(this.string_1, "Textures"));
			}
			if (!Directory.Exists(Path.Combine(Path.Combine(this.string_1, "Textures"), "HUD")))
			{
				Directory.CreateDirectory(Path.Combine(Path.Combine(this.string_1, "Textures"), "HUD"));
			}
			if (!Directory.Exists(Path.Combine(this.string_1, "UI")))
			{
				Directory.CreateDirectory(Path.Combine(this.string_1, "UI"));
			}
			List<GClass84.Struct17> list = new List<GClass84.Struct17>();
			list.Add(new GClass84.Struct17(0, 0, 256, 61, new Color32(14, 14, 14, 192)));
			list.Add(new GClass84.Struct17(0, 61, 256, 1, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 224)));
			list.Add(new GClass84.Struct17(0, 62, 256, 706, new Color32(0, 0, 0, 0)));
			GClass153.GClass86.texture2D_0 = GClass84.smethod_53(256, 768, list);
			list.Clear();
			list.Add(new GClass84.Struct17(0, 0, 256, 61, new Color32(14, 14, 14, 192)));
			list.Add(new GClass84.Struct17(0, 61, 256, 1, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 224)));
			list.Add(new GClass84.Struct17(0, 62, 256, 706, new Color32(14, 14, 14, 224)));
			GClass153.GClass86.texture2D_1 = GClass84.smethod_53(256, 768, list);
			list.Clear();
			list.Add(new GClass84.Struct17(0, 0, 4, 4, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue)));
			GClass153.GClass87.texture2D_0 = GClass84.smethod_53(4, 4, list);
			list.Clear();
			list.Add(new GClass84.Struct17(0, 0, 4, 4, new Color32(0, 0, 0, byte.MaxValue)));
			GClass153.GClass87.texture2D_1 = GClass84.smethod_53(4, 4, list);
			list.Clear();
			list.Add(new GClass84.Struct17(0, 0, 4, 4, new Color32(127, 127, 127, byte.MaxValue)));
			GClass153.GClass87.texture2D_2 = GClass84.smethod_53(4, 4, list);
			GClass153.GClass87.texture2D_3 = GClass84.smethod_254(128, 128, 2, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), new Color32(0, 0, 0, byte.MaxValue));
			GClass153.GClass87.texture2D_4 = GClass84.smethod_254(128, 128, 2, new Color32(0, 0, 0, byte.MaxValue), new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			GClass153.GClass87.texture2D_5 = GClass84.smethod_254(128, 64, 2, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 178), new Color32(0, 0, 0, 178));
			GClass153.GClass87.texture2D_6 = GClass84.smethod_456(this.string_1 + "\\Textures\\ROArial12DS_PageA.png");
			list.Clear();
			list.Add(new GClass84.Struct17(0, 0, 64, 64, new Color32(0, 0, 0, 0)));
			list.Add(new GClass84.Struct17(24, 0, 16, 64, new Color32(247, 0, 0, byte.MaxValue)));
			list.Add(new GClass84.Struct17(0, 24, 64, 16, new Color32(247, 0, 0, byte.MaxValue)));
			list.Add(new GClass84.Struct17(26, 2, 12, 60, new Color32(115, 25, 33, byte.MaxValue)));
			list.Add(new GClass84.Struct17(2, 26, 60, 12, new Color32(115, 25, 33, byte.MaxValue)));
			list.Add(new GClass84.Struct17(28, 4, 8, 56, new Color32(222, 56, 57, byte.MaxValue)));
			list.Add(new GClass84.Struct17(4, 28, 56, 8, new Color32(222, 56, 57, byte.MaxValue)));
			GClass153.GClass87.gstruct177_0.texture2D_0 = GClass84.smethod_53(64, 64, list);
			GClass153.GClass87.gstruct177_0.texture2D_1 = GClass84.smethod_456(this.string_1 + "\\Textures\\HUD\\Hud_Shield.png");
			GClass153.GClass88.texture2D_0 = GClass84.smethod_456(this.string_1 + "\\UI\\AbyssQuickMenuBackground.png");
			GClass153.GClass88.texture2D_1 = GClass84.smethod_456(this.string_1 + "\\UI\\Background_Alert_Streamer.png");
			GClass153.GClass88.texture2D_2 = GClass84.smethod_456(this.string_1 + "\\UI\\Button_Default.png");
			GClass153.GClass88.texture2D_3 = GClass84.smethod_456(this.string_1 + "\\UI\\Button_Hover.png");
			GClass153.GClass88.texture2D_4 = GClass84.smethod_456(this.string_1 + "\\UI\\Button_Purple.png");
			GClass153.GClass88.texture2D_5 = GClass84.smethod_456(this.string_1 + "\\UI\\Button02_Default.png");
			GClass153.GClass88.texture2D_6 = GClass84.smethod_456(this.string_1 + "\\UI\\Button02_Hover.png");
			GClass153.GClass88.texture2D_7 = GClass84.smethod_456(this.string_1 + "\\UI\\Checkbox.png");
			GClass153.GClass88.texture2D_8 = GClass84.smethod_456(this.string_1 + "\\UI\\Checkmark.png");
			GClass153.GClass88.texture2D_9 = GClass84.smethod_456(this.string_1 + "\\UI\\GUI_Button_double_White.png");
			GClass153.GClass88.texture2D_10 = GClass84.smethod_456(this.string_1 + "\\UI\\Icon_Beta_Badge.png");
			GClass153.GClass88.texture2D_11 = GClass84.smethod_456(this.string_1 + "\\UI\\Icon_Microphone_OFF.png");
			GClass153.GClass88.texture2D_12 = GClass84.smethod_456(this.string_1 + "\\UI\\Icon_Microphone_ON.png");
			GClass153.GClass88.texture2D_13 = GClass84.smethod_456(this.string_1 + "\\UI\\Icon_New.png");
			GClass153.GClass88.texture2D_14 = GClass84.smethod_456(this.string_1 + "\\UI\\mic_off_circle3.png");
			GClass153.GClass88.texture2D_15 = GClass84.smethod_456(this.string_1 + "\\UI\\Mic_On_Circle.png");
			GClass153.GClass88.texture2D_16 = GClass84.smethod_456(this.string_1 + "\\UI\\Mic_On_Circle_White.png");
			GClass153.GClass88.texture2D_17 = GClass84.smethod_456(this.string_1 + "\\UI\\NamePlate_round_Silent.png");
			GClass153.GClass88.texture2D_18 = GClass84.smethod_456(this.string_1 + "\\UI\\NamePlate_round_Silent_V3_0.png");
			GClass153.GClass88.texture2D_19 = GClass84.smethod_456(this.string_1 + "\\UI\\NamePlate_round_Talk.png");
			GClass153.GClass88.texture2D_20 = GClass84.smethod_456(this.string_1 + "\\UI\\NamePlate_round_Talk_v3_0.png");
			GClass153.GClass88.texture2D_21 = GClass84.smethod_456(this.string_1 + "\\UI\\plasma_beam_hit_blue.png");
			GClass153.GClass88.texture2D_22 = GClass84.smethod_1668<Texture2D>(GClass153.GClass88.texture2D_21);
			GClass84.smethod_1514(GClass153.GClass88.texture2D_22, 240f);
			GClass153.GClass88.texture2D_23 = GClass84.smethod_456(this.string_1 + "\\UI\\plasma_beamflare_blue.png");
			GClass153.GClass88.texture2D_24 = GClass84.smethod_1668<Texture2D>(GClass153.GClass88.texture2D_23);
			GClass84.smethod_1514(GClass153.GClass88.texture2D_24, 240f);
			GClass153.GClass88.texture2D_25 = GClass84.smethod_456(this.string_1 + "\\UI\\sniper_beam_blue.png");
			GClass153.GClass88.texture2D_26 = GClass84.smethod_1668<Texture2D>(GClass153.GClass88.texture2D_25);
			GClass84.smethod_1514(GClass153.GClass88.texture2D_26, 240f);
			GClass153.GClass88.texture2D_27 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ArrowDown_Bifrost.png");
			GClass153.GClass88.texture2D_28 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ArrowNext_Bifrost.png");
			GClass153.GClass88.texture2D_29 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ArrowUp_Bifrost.png");
			GClass153.GClass88.texture2D_30 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ButtonToggleBottom_Bifrost.png");
			GClass153.GClass88.texture2D_31 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ButtonToggleOn_Bifrost.png");
			GClass153.GClass88.texture2D_32 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ButtonToggleTop_Fifrost.png");
			GClass153.GClass88.texture2D_33 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ToggleOff_Bifrost.png");
			GClass153.GClass88.texture2D_34 = GClass84.smethod_456(this.string_1 + "\\UI\\UI_ToggleOn_Bifrost.png");
			GClass153.GClass88.texture2D_35 = GClass84.smethod_456(this.string_1 + "\\UI\\AbyssLogo.png");
			GClass153.GClass88.texture2D_36 = GClass84.smethod_770(GClass84.smethod_1668<Texture2D>(GClass153.GClass88.texture2D_35), GClass153.GClass88.texture2D_9, true, true);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000801D4 File Offset: 0x0007E3D4
		public override void vmethod_23()
		{
			this.method_3();
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000801E8 File Offset: 0x0007E3E8
		internal void method_6()
		{
			this.method_2();
		}

		// Token: 0x04000E70 RID: 3696
		internal string string_1 = Path.Combine(Environment.CurrentDirectory, "_Unreal/Resources");

		// Token: 0x0200021C RID: 540
		public static class GClass86
		{
			// Token: 0x04000E71 RID: 3697
			public static Texture2D texture2D_0;

			// Token: 0x04000E72 RID: 3698
			public static Texture2D texture2D_1;
		}

		// Token: 0x0200021D RID: 541
		public static class GClass87
		{
			// Token: 0x04000E73 RID: 3699
			public static GClass153.GClass87.GStruct177 gstruct177_0;

			// Token: 0x04000E74 RID: 3700
			public static Texture2D texture2D_0;

			// Token: 0x04000E75 RID: 3701
			public static Texture2D texture2D_1;

			// Token: 0x04000E76 RID: 3702
			public static Texture2D texture2D_2;

			// Token: 0x04000E77 RID: 3703
			public static Texture2D texture2D_3;

			// Token: 0x04000E78 RID: 3704
			public static Texture2D texture2D_4;

			// Token: 0x04000E79 RID: 3705
			public static Texture2D texture2D_5;

			// Token: 0x04000E7A RID: 3706
			public static Texture2D texture2D_6;

			// Token: 0x0200021E RID: 542
			public struct GStruct177
			{
				// Token: 0x04000E7B RID: 3707
				public Texture2D texture2D_0;

				// Token: 0x04000E7C RID: 3708
				public Texture2D texture2D_1;
			}
		}

		// Token: 0x0200021F RID: 543
		public static class GClass88
		{
			// Token: 0x04000E7D RID: 3709
			public static Texture2D texture2D_0;

			// Token: 0x04000E7E RID: 3710
			public static Texture2D texture2D_1;

			// Token: 0x04000E7F RID: 3711
			public static Texture2D texture2D_2;

			// Token: 0x04000E80 RID: 3712
			public static Texture2D texture2D_3;

			// Token: 0x04000E81 RID: 3713
			public static Texture2D texture2D_4;

			// Token: 0x04000E82 RID: 3714
			public static Texture2D texture2D_5;

			// Token: 0x04000E83 RID: 3715
			public static Texture2D texture2D_6;

			// Token: 0x04000E84 RID: 3716
			public static Texture2D texture2D_7;

			// Token: 0x04000E85 RID: 3717
			public static Texture2D texture2D_8;

			// Token: 0x04000E86 RID: 3718
			public static Texture2D texture2D_9;

			// Token: 0x04000E87 RID: 3719
			public static Texture2D texture2D_10;

			// Token: 0x04000E88 RID: 3720
			public static Texture2D texture2D_11;

			// Token: 0x04000E89 RID: 3721
			public static Texture2D texture2D_12;

			// Token: 0x04000E8A RID: 3722
			public static Texture2D texture2D_13;

			// Token: 0x04000E8B RID: 3723
			public static Texture2D texture2D_14;

			// Token: 0x04000E8C RID: 3724
			public static Texture2D texture2D_15;

			// Token: 0x04000E8D RID: 3725
			public static Texture2D texture2D_16;

			// Token: 0x04000E8E RID: 3726
			public static Texture2D texture2D_17;

			// Token: 0x04000E8F RID: 3727
			public static Texture2D texture2D_18;

			// Token: 0x04000E90 RID: 3728
			public static Texture2D texture2D_19;

			// Token: 0x04000E91 RID: 3729
			public static Texture2D texture2D_20;

			// Token: 0x04000E92 RID: 3730
			public static Texture2D texture2D_21;

			// Token: 0x04000E93 RID: 3731
			public static Texture2D texture2D_22;

			// Token: 0x04000E94 RID: 3732
			public static Texture2D texture2D_23;

			// Token: 0x04000E95 RID: 3733
			public static Texture2D texture2D_24;

			// Token: 0x04000E96 RID: 3734
			public static Texture2D texture2D_25;

			// Token: 0x04000E97 RID: 3735
			public static Texture2D texture2D_26;

			// Token: 0x04000E98 RID: 3736
			public static Texture2D texture2D_27;

			// Token: 0x04000E99 RID: 3737
			public static Texture2D texture2D_28;

			// Token: 0x04000E9A RID: 3738
			public static Texture2D texture2D_29;

			// Token: 0x04000E9B RID: 3739
			public static Texture2D texture2D_30;

			// Token: 0x04000E9C RID: 3740
			public static Texture2D texture2D_31;

			// Token: 0x04000E9D RID: 3741
			public static Texture2D texture2D_32;

			// Token: 0x04000E9E RID: 3742
			public static Texture2D texture2D_33;

			// Token: 0x04000E9F RID: 3743
			public static Texture2D texture2D_34;

			// Token: 0x04000EA0 RID: 3744
			public static Texture2D texture2D_35;

			// Token: 0x04000EA1 RID: 3745
			public static Texture2D texture2D_36;
		}
	}
}
