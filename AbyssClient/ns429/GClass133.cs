using System;
using ns185;
using ns241;
using ns425;
using ns476;
using ns482;
using UnityEngine;
using VRC.Core;
using VRC.SDKBase;

namespace ns429
{
	// Token: 0x02000064 RID: 100
	public class GClass133 : GClass130
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		internal void method_2()
		{
			this.method_22();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		internal void method_3(bool bool_4)
		{
			this.method_27(bool_4);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BBDC File Offset: 0x00009DDC
		internal void method_4(bool bool_4)
		{
			this.method_42(bool_4);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		internal void method_5()
		{
			if (this.bool_0 && (this.bool_1 && this.bool_2))
			{
				this.method_13();
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000BC20 File Offset: 0x00009E20
		private void method_6()
		{
			this.float_2 = 20f;
			this.float_3 = 70f;
			GUI.contentColor = (GClass84.gclass131_0.bool_0 ? Color.green : Color.red);
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), GClass84.gclass131_0.bool_0 ? "Fly enabled" : "Fly disabled"))
			{
				GClass84.gclass131_0.method_5(!GClass84.gclass131_0.bool_0);
			}
			GUI.contentColor = (GClass84.gclass164_0.bool_0 ? Color.green : Color.red);
			this.float_3 += 30f;
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), GClass84.gclass164_0.bool_0 ? "ESP enabled" : "ESP disabled"))
			{
				GClass84.gclass164_0.method_8(!GClass84.gclass164_0.bool_0);
			}
			GUI.contentColor = Color.white;
			this.float_3 += 30f;
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), "Respawn"))
			{
				GClass84.smethod_251();
			}
			this.float_3 += 30f;
			GUI.contentColor = (GClass185.bool_14 ? Color.green : Color.red);
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), "Block All RPC"))
			{
				GClass84.gclass185_0.method_27(!GClass185.bool_14);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000BDDC File Offset: 0x00009FDC
		private void method_7()
		{
			this.method_25();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		private void method_8()
		{
			this.method_10();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000BE04 File Offset: 0x0000A004
		public override void vmethod_19()
		{
			this.method_11();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000BE18 File Offset: 0x0000A018
		private void method_9()
		{
			this.method_33();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000BE2C File Offset: 0x0000A02C
		private void method_10()
		{
			this.float_2 = 20f;
			this.float_3 = 70f;
			GUI.contentColor = (GClass84.gclass145_0.bool_0 ? Color.green : Color.red);
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), GClass84.gclass145_0.bool_0 ? "AntiCrash enabled" : "AntiCrash disabled"))
			{
				GClass84.gclass145_0.method_335(!GClass84.gclass145_0.bool_0);
			}
			GUI.contentColor = Color.white;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		internal void method_11()
		{
			this.method_16();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		public override void vmethod_24()
		{
			this.method_24();
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		internal void method_12(bool bool_4)
		{
			this.method_14(bool_4);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000BF04 File Offset: 0x0000A104
		private void method_13()
		{
			this.method_41();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000BF18 File Offset: 0x0000A118
		internal void method_14(bool bool_4)
		{
			this.bool_2 = bool_4;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000BF2C File Offset: 0x0000A12C
		internal void method_15(bool bool_4)
		{
			this.method_3(bool_4);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000BF40 File Offset: 0x0000A140
		internal void method_16()
		{
			try
			{
				if (Input.GetKeyDown(277))
				{
					this.method_15(!this.bool_3);
				}
				if (this.bool_0)
				{
					if ((Input.GetKey(306) || Input.GetKey(305)) && !Input.GetKey(304))
					{
						if (Input.GetKeyDown(113))
						{
							this.method_4(!this.bool_1);
						}
						if (Input.GetKeyDown(101))
						{
							this.method_23(!this.bool_2);
						}
					}
					if (this.bool_1 && this.bool_2)
					{
						this.method_26();
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000C008 File Offset: 0x0000A208
		internal void method_17()
		{
			this.method_48();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000C01C File Offset: 0x0000A21C
		private void method_18()
		{
			GUI.BeginGroup(new Rect((float)(Screen.width / 2 - 250), (float)(Screen.height / 2 - 350), 500f, 700f));
			GUI.contentColor = Color.red;
			GUI.Box(new Rect(0f, 0f, 500f, 700f), "Abyss Client");
			GUI.contentColor = Color.white;
			if (GUI.Button(new Rect(20f, 40f, 50f, 20f), (this.int_2 == 0) ? "[Main]" : "Main"))
			{
				this.int_2 = 0;
			}
			if (GUI.Button(new Rect(70f, 40f, 50f, 20f), (this.int_2 == 1) ? "[Udon]" : "Udon"))
			{
				this.int_2 = 1;
			}
			if (GUI.Button(new Rect(120f, 40f, 65f, 20f), (this.int_2 == 2) ? "[Loading]" : "Loading"))
			{
				this.int_2 = 2;
			}
			if (GUI.Button(new Rect(185f, 40f, 80f, 20f), (this.int_2 == 3) ? "[AntiCrash]" : "AntiCrash"))
			{
				this.int_2 = 3;
			}
			if (GUI.Button(new Rect(265f, 40f, 70f, 20f), (this.int_2 == 4) ? "[Exploits]" : "Exploits"))
			{
				this.int_2 = 4;
			}
			switch (this.int_2)
			{
			case 0:
				this.method_31();
				break;
			case 1:
				this.method_9();
				break;
			case 3:
				this.method_35();
				break;
			case 4:
				this.method_49();
				break;
			}
			GUI.EndGroup();
			this.method_37();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C210 File Offset: 0x0000A410
		internal void method_19(bool bool_4)
		{
			this.bool_1 = bool_4;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000C224 File Offset: 0x0000A424
		private void method_20()
		{
			this.method_34();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C238 File Offset: 0x0000A438
		public override void vmethod_25()
		{
			this.method_21();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C24C File Offset: 0x0000A44C
		internal void method_21()
		{
			this.method_32();
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C260 File Offset: 0x0000A460
		internal void method_22()
		{
			this.method_29();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C274 File Offset: 0x0000A474
		internal void method_23(bool bool_4)
		{
			this.method_12(bool_4);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C288 File Offset: 0x0000A488
		internal void method_24()
		{
			this.method_5();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C29C File Offset: 0x0000A49C
		private void method_25()
		{
			this.method_18();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		private void method_26()
		{
			this.method_36();
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		internal void method_27(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		private void method_28()
		{
			this.method_30();
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		internal void method_29()
		{
			GUI.BeginGroup(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height));
			GUI.Label(new Rect(0f, 0f, (float)Screen.width, this.float_0), "'CTRL+Q' to hide | 'CTRL+E'" + (this.bool_2 ? " to close" : " to open") + " | FPS: " + GClass84.float_1.ToString());
			if (this.bool_2)
			{
				float num = this.float_1;
				if (this.string_1 != string.Empty)
				{
					GUI.Label(new Rect(0f, num, (float)Screen.width, this.float_0), this.string_1);
					num += this.float_1;
				}
				if (this.string_2 != string.Empty)
				{
					GUI.Label(new Rect(0f, num, (float)Screen.width, this.float_0), this.string_2);
					num += this.float_1;
				}
				if (this.string_3 != string.Empty)
				{
					GUI.Label(new Rect(0f, num, (float)Screen.width, this.float_0), this.string_3);
					num += this.float_1;
				}
				Color color = GUI.color;
				if (this.int_1 != -1)
				{
					GUI.color = this.gstruct173_0[this.int_1].color_0;
					GUI.Label(new Rect(0f, num + (float)this.int_1 * this.float_1, 20f, this.float_0), "[M]");
				}
				for (int i = 0; i < this.int_0; i++)
				{
					GUI.color = this.gstruct173_0[i].color_0;
					GUI.Label(new Rect(20f, num, (float)(Screen.width - 20), this.float_0), this.gstruct173_0[i].string_0);
					num += this.float_1;
				}
				GUI.color = color;
			}
			GUI.EndGroup();
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000C500 File Offset: 0x0000A700
		private void method_30()
		{
			this.float_2 = 20f;
			this.float_3 = 70f;
			GUI.contentColor = Color.white;
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), "Photon Crash"))
			{
				GClass84.gclass185_0.method_62("");
			}
			GUI.contentColor = Color.white;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000C570 File Offset: 0x0000A770
		private void method_31()
		{
			this.method_43();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000C584 File Offset: 0x0000A784
		internal void method_32()
		{
			if (this.bool_3)
			{
				try
				{
					this.method_7();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
			if (this.bool_0 && this.bool_1)
			{
				try
				{
					this.method_2();
				}
				catch (Exception ex2)
				{
					GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		private void method_33()
		{
			this.method_44();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000C60C File Offset: 0x0000A80C
		private void method_34()
		{
			Cursor.lockState = (this.bool_3 ? 0 : Cursor.lockState);
			Cursor.visible = this.bool_3;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C63C File Offset: 0x0000A83C
		private void method_35()
		{
			this.method_8();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C650 File Offset: 0x0000A850
		private void method_36()
		{
			this.method_39();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C664 File Offset: 0x0000A864
		private void method_37()
		{
			this.method_20();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C678 File Offset: 0x0000A878
		private void method_38()
		{
			ApiWorld apiWorld = GClass84.smethod_1424();
			if (apiWorld != null)
			{
				this.string_1 = apiWorld.name + " | " + apiWorld.authorName;
			}
			else
			{
				this.string_1 = string.Empty;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		private void method_39()
		{
			Transform transform = GClass84.smethod_981();
			if (transform)
			{
				Vector3 position = transform.position;
				this.string_2 = string.Concat(new string[]
				{
					"X: ",
					position.x.ToString(),
					" | Y: ",
					position.y.ToString(),
					" | Z: ",
					position.z.ToString()
				});
			}
			else
			{
				this.string_2 = string.Empty;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C744 File Offset: 0x0000A944
		public override void vmethod_10()
		{
			this.method_17();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000C758 File Offset: 0x0000A958
		internal void method_40()
		{
			this.method_50();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000C76C File Offset: 0x0000A96C
		private void method_41()
		{
			this.method_46();
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000C780 File Offset: 0x0000A980
		internal void method_42(bool bool_4)
		{
			this.method_19(bool_4);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000C794 File Offset: 0x0000A994
		private void method_43()
		{
			this.method_6();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		private void method_44()
		{
			this.float_2 = 20f;
			this.float_3 = 70f;
			GUI.contentColor = (GClass179.bool_2 ? Color.green : Color.red);
			if (GUI.Button(new Rect(this.float_2, this.float_3, 200f, 20f), GClass179.bool_2 ? "Anti-Udon enabled" : "Anti-Udon disabled"))
			{
				GClass84.gclass179_0.method_11(!GClass179.bool_2);
			}
			GUI.contentColor = Color.white;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000C834 File Offset: 0x0000AA34
		private void method_45()
		{
			this.method_38();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000C848 File Offset: 0x0000AA48
		private void method_46()
		{
			this.int_1 = -1;
			this.int_0 = 0;
			if (GClass84.smethod_1424() == null || GClass84.smethod_813() == null)
			{
				this.string_3 = string.Empty;
			}
			else
			{
				foreach (VRCPlayerApi vrcplayerApi_ in GClass84.smethod_1239())
				{
					if (this.int_0 == 40)
					{
						break;
					}
					VRCPlayer vrcplayer = GClass84.smethod_840(vrcplayerApi_);
					APIUser apiuser = GClass84.smethod_856(vrcplayer);
					if (apiuser != null && vrcplayer)
					{
						if (GClass84.smethod_764(vrcplayerApi_))
						{
							this.int_1 = this.int_0;
						}
						this.gstruct173_0[this.int_0] = new GClass84.GStruct173(GClass84.smethod_1084(apiuser), string.Concat(new string[]
						{
							apiuser.displayName,
							" - ",
							GClass84.smethod_506(vrcplayer).ToString(),
							"ms ",
							GClass84.smethod_657(vrcplayer).ToString()
						}));
						this.int_0++;
					}
				}
				this.string_3 = "Users in room (" + this.int_0.ToString() + "):";
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		public override void vmethod_23()
		{
			this.method_40();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		private void method_47()
		{
			this.method_45();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		internal void method_48()
		{
			if (this.bool_0 && (this.bool_1 && this.bool_2))
			{
				this.method_47();
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		private void method_49()
		{
			this.method_28();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000CA90 File Offset: 0x0000AC90
		internal void method_50()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_10.Add(new Action(this.vmethod_25));
		}

		// Token: 0x04000237 RID: 567
		internal bool bool_0 = false;

		// Token: 0x04000238 RID: 568
		internal bool bool_1 = true;

		// Token: 0x04000239 RID: 569
		internal bool bool_2 = false;

		// Token: 0x0400023A RID: 570
		private string string_1;

		// Token: 0x0400023B RID: 571
		private string string_2;

		// Token: 0x0400023C RID: 572
		private GClass84.GStruct173[] gstruct173_0 = new GClass84.GStruct173[40];

		// Token: 0x0400023D RID: 573
		private int int_0 = 0;

		// Token: 0x0400023E RID: 574
		private string string_3;

		// Token: 0x0400023F RID: 575
		private int int_1 = -1;

		// Token: 0x04000240 RID: 576
		private float float_0 = 20f;

		// Token: 0x04000241 RID: 577
		private float float_1 = 15f;

		// Token: 0x04000242 RID: 578
		internal bool bool_3 = false;

		// Token: 0x04000243 RID: 579
		internal int int_2 = 0;

		// Token: 0x04000244 RID: 580
		private float float_2 = 0f;

		// Token: 0x04000245 RID: 581
		private float float_3 = 0f;
	}
}
