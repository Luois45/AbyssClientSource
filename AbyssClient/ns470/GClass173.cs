using System;
using System.Collections.Generic;
using System.IO;
using ns241;
using ns466;
using ns469;
using UnityEngine;

namespace ns470
{
	// Token: 0x0200027D RID: 637
	public class GClass173 : GClass172
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x00091F78 File Offset: 0x00090178
		public virtual void vmethod_37(float float_38)
		{
			this.method_47(float_38);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00091F8C File Offset: 0x0009018C
		public override void vmethod_9()
		{
			this.method_92();
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00091FA0 File Offset: 0x000901A0
		internal void method_46(float float_38)
		{
			if (this.float_7 >= this.float_10)
			{
				this.int_3 = 0;
			}
			else if (this.float_5 <= this.float_15)
			{
				this.int_3 = 1;
			}
			if (this.int_3 == 0)
			{
				float num = GClass84.smethod_910(float_38 / 3f, this.float_5 - this.float_15);
				this.float_5 -= num * this.float_5 / this.float_7;
				this.float_7 -= num;
			}
			else
			{
				float num = GClass84.smethod_910(float_38 / 3f, this.float_10 - this.float_7);
				this.float_5 += num;
				this.float_7 += num;
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0009206C File Offset: 0x0009026C
		internal void method_47(float float_38)
		{
			this.method_77(float_38);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00092080 File Offset: 0x00090280
		internal void method_48()
		{
			this.method_97();
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00092094 File Offset: 0x00090294
		internal void method_49(float float_38)
		{
			if (this.bool_9)
			{
				this.vmethod_50(float_38);
				this.vmethod_44(float_38);
			}
			if (this.bool_10)
			{
				this.float_20 = this.float_23;
			}
			this.vmethod_42(float_38);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000920D4 File Offset: 0x000902D4
		internal void method_50()
		{
			this.method_80();
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000920E8 File Offset: 0x000902E8
		public override int vmethod_36(int int_5)
		{
			return base.vmethod_36(int_5);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00092100 File Offset: 0x00090300
		internal void method_51(float float_38)
		{
			this.method_70(float_38);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00092114 File Offset: 0x00090314
		public virtual void vmethod_38()
		{
			this.method_106();
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00092128 File Offset: 0x00090328
		internal void method_52()
		{
			this.method_75();
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0009213C File Offset: 0x0009033C
		internal void method_53()
		{
			this.method_62();
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00092150 File Offset: 0x00090350
		internal void method_54(float float_38)
		{
			float num = 0f;
			if (this.bool_6)
			{
				float num2 = this.float_5;
				float num3 = this.float_8;
				float num4 = this.float_11;
				float num5 = this.float_12;
				float num6 = this.float_13;
				float num7 = this.float_14;
				if (num2 < num3)
				{
					if (num2 < num4)
					{
						if (num2 < num5)
						{
							num += num7;
						}
						else
						{
							num += num6 + (num7 - num6) * ((num2 - num4) / (num5 - num4));
						}
					}
					else
					{
						num += num6 * ((num2 - num3) / (num4 - num3));
					}
				}
			}
			float num8 = this.float_20;
			float num9 = GClass84.smethod_359(this.float_26 + num, 0f);
			float num10 = GClass84.smethod_359(this.float_24 + num, 0f);
			float num11 = GClass84.smethod_359(this.float_27 + num, 0f);
			float num12 = GClass84.smethod_359(this.float_25 + num, 0f);
			if (this.float_35 <= this.gclass176_0.Single_0)
			{
				if (num8 >= num10)
				{
					if (num8 >= num12)
					{
						this.vmethod_33(GClass84.smethod_1690(this.int_2, this.int_0), this);
						this.float_35 = this.gclass176_0.Single_0 + 0.5f;
					}
					else
					{
						this.vmethod_33((int)(100f * ((num8 - num10) / (num12 - num10))), this);
						this.float_35 = this.gclass176_0.Single_0 + 0.5f;
					}
				}
				else if (num8 <= num9)
				{
					if (num8 <= num11)
					{
						this.vmethod_33(GClass84.smethod_1690(this.int_2, this.int_0), this);
						this.float_35 = this.gclass176_0.Single_0 + 0.5f;
					}
					else
					{
						this.vmethod_33((int)(100f * ((num8 - num9) / (num11 - num9))), this);
						this.float_35 = this.gclass176_0.Single_0 + 0.5f;
					}
				}
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00092344 File Offset: 0x00090544
		public override void vmethod_25()
		{
			this.method_68();
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00092358 File Offset: 0x00090558
		internal void method_55()
		{
			base.vmethod_25();
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0009236C File Offset: 0x0009056C
		internal void method_56(int int_5, GClass169 gclass169_0)
		{
			base.vmethod_33(int_5, gclass169_0);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00092384 File Offset: 0x00090584
		internal void method_57(float float_38)
		{
			this.method_49(float_38);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00092398 File Offset: 0x00090598
		public override void vmethod_24()
		{
			this.method_86();
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000923AC File Offset: 0x000905AC
		internal void method_58()
		{
			this.method_72();
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000923C0 File Offset: 0x000905C0
		public override void vmethod_12()
		{
			this.method_100();
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000923D4 File Offset: 0x000905D4
		internal void method_59(float float_38)
		{
			if (this.list_1.Count > 1 && this.gclass176_0.Single_0 - this.float_37 >= 60f / this.float_20 / (float)this.list_1.Count)
			{
				if (this.int_4 + 1 >= this.list_1.Count)
				{
					this.int_4 = 0;
				}
				else
				{
					this.int_4++;
				}
				this.float_37 = this.gclass176_0.Single_0;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00092468 File Offset: 0x00090668
		internal void method_60(float float_38)
		{
			this.method_46(float_38);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0009247C File Offset: 0x0009067C
		public override void vmethod_33(int int_5, GClass169 gclass169_0)
		{
			this.method_105(int_5, gclass169_0);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00092494 File Offset: 0x00090694
		public virtual void vmethod_39()
		{
			this.method_82();
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000924A8 File Offset: 0x000906A8
		internal void method_61(float float_38)
		{
			this.method_59(float_38);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000924BC File Offset: 0x000906BC
		public virtual float vmethod_40()
		{
			float num = this.float_21;
			float num2 = this.float_22;
			float result;
			if (num >= num2)
			{
				result = num;
			}
			else
			{
				float num3 = num + (float)GClass84.smethod_1673((int)GClass84.smethod_359(num2 - num + 1f, 1f));
				if (num3 > num && num3 < num2)
				{
					num3 += (float)((double)((GClass84.smethod_1673(2) * 2 - 1) * GClass84.smethod_1673(10)) * 0.1);
				}
				else if (num3 > num)
				{
					num3 -= (float)((double)GClass84.smethod_1673(10) * 0.1);
				}
				else if (num3 < num2)
				{
					num3 += (float)((double)GClass84.smethod_1673(10) * 0.1);
				}
				result = GClass84.smethod_415(num3, num, num2);
			}
			return result;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0009257C File Offset: 0x0009077C
		internal void method_62()
		{
			base.vmethod_28();
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00092590 File Offset: 0x00090790
		public virtual void vmethod_41()
		{
			this.method_89();
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000925A4 File Offset: 0x000907A4
		internal void method_63(int int_5)
		{
			this.method_103(int_5);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000925B8 File Offset: 0x000907B8
		internal void method_64(float float_38)
		{
			float num = this.float_5;
			float num2 = 1f;
			if (this.Boolean_0)
			{
				num2 *= this.float_17;
			}
			num2 *= this.float_16;
			this.float_5 = GClass84.smethod_359(num - float_38 / this.float_19 * num2, 0f);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00092610 File Offset: 0x00090810
		public override void vmethod_8(int int_5)
		{
			this.method_102(int_5);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00092624 File Offset: 0x00090824
		public override void vmethod_19()
		{
			this.method_48();
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00092638 File Offset: 0x00090838
		internal void method_65()
		{
			base.vmethod_29();
			this.bool_1 = true;
			this.bool_2 = false;
			this.bool_3 = true;
			this.float_4 = 0.33f;
			this.float_2 = 1f;
			this.float_8 = 1f;
			this.float_9 = 1f;
			this.float_10 = 1f;
			this.float_11 = 0.2f;
			this.float_12 = 0f;
			this.float_13 = -10f;
			this.float_14 = -50f;
			this.float_15 = 0.3f;
			this.float_16 = 1f;
			this.float_17 = 2f;
			this.float_19 = 30f;
			this.bool_4 = true;
			this.bool_5 = false;
			this.bool_6 = true;
			this.bool_9 = true;
			this.bool_10 = false;
			this.bool_11 = true;
			this.float_21 = 65f;
			this.float_22 = 75f;
			this.float_24 = 120f;
			this.float_25 = 200f;
			this.float_26 = 30f;
			this.float_27 = 0f;
			this.float_28 = 65f;
			this.float_29 = 75f;
			this.float_30 = 1f;
			this.float_31 = 1f;
			this.float_32 = 130f;
			this.float_33 = 10f;
			this.float_34 = 1f;
			this.string_1 = string.Concat(new string[]
			{
				Path.Combine(Environment.CurrentDirectory, "_Unreal/Resources"),
				"/",
				"Textures",
				"/",
				"Heart"
			});
			this.list_0.Add("Heart_0");
			this.list_0.Add("Heart_1");
			this.list_0.Add("Heart_2");
			this.list_0.Add("Heart_3");
			this.list_0.Add("Heart_4");
			this.list_0.Add("Heart_5");
			this.list_0.Add("Heart_6");
			this.list_0.Add("Heart_7");
			this.list_0.Add("Heart_8");
			this.list_0.Add("Heart_9");
			this.list_0.Add("Heart_a");
			this.list_0.Add("Heart_b");
			this.list_0.Add("Heart_c");
			this.list_0.Add("Heart_d");
			this.list_0.Add("Heart_e");
			this.vmethod_38();
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000928E4 File Offset: 0x00090AE4
		internal void method_66(float float_38)
		{
			this.method_79(float_38);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000928F8 File Offset: 0x00090AF8
		internal void method_67()
		{
			this.method_65();
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0009290C File Offset: 0x00090B0C
		public override void vmethod_27(int int_5)
		{
			this.method_63(int_5);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00092920 File Offset: 0x00090B20
		internal void method_68()
		{
			this.method_55();
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00092934 File Offset: 0x00090B34
		internal void method_69()
		{
			base.vmethod_9();
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00092948 File Offset: 0x00090B48
		internal void method_70(float float_38)
		{
			float num = this.float_5;
			float num2 = this.float_11;
			float num3 = this.float_12;
			if (this.float_18 <= this.gclass176_0.Single_0 && num <= num2)
			{
				if (num <= num3)
				{
					this.vmethod_33(GClass84.smethod_1690(this.int_2, this.int_0), this);
					this.float_18 = this.gclass176_0.Single_0 + 0.5f;
				}
				else
				{
					this.vmethod_33((int)(100f * ((num - num2) / (num3 - num2))), this);
					this.float_18 = this.gclass176_0.Single_0 + 0.5f;
				}
			}
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000929F4 File Offset: 0x00090BF4
		internal void method_71()
		{
			base.vmethod_11();
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00092A08 File Offset: 0x00090C08
		internal void method_72()
		{
			base.vmethod_34();
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00092A1C File Offset: 0x00090C1C
		internal void method_73(float float_38)
		{
			this.method_54(float_38);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00092A30 File Offset: 0x00090C30
		public virtual void vmethod_42(float float_38)
		{
			this.method_61(float_38);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00092A44 File Offset: 0x00090C44
		public virtual void vmethod_43(float float_38)
		{
			this.method_51(float_38);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00092A58 File Offset: 0x00090C58
		internal void method_74(float float_38)
		{
			this.method_101(float_38);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00092A6C File Offset: 0x00090C6C
		internal void method_75()
		{
			base.vmethod_15();
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00092A80 File Offset: 0x00090C80
		internal void method_76()
		{
			base.vmethod_12();
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00092A94 File Offset: 0x00090C94
		internal void method_77(float float_38)
		{
			if (this.bool_8)
			{
				this.bool_7 = false;
			}
			else
			{
				this.bool_7 = true;
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00092ABC File Offset: 0x00090CBC
		public override void vmethod_23()
		{
			this.method_83();
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00092AD0 File Offset: 0x00090CD0
		internal void method_78()
		{
			base.vmethod_22();
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00092AE4 File Offset: 0x00090CE4
		public virtual void vmethod_44(float float_38)
		{
			this.method_66(float_38);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00092AF8 File Offset: 0x00090CF8
		internal void method_79(float float_38)
		{
			float num = 0f;
			if (this.bool_6)
			{
				float num2 = this.float_5;
				float num3 = this.float_8;
				float num4 = this.float_11;
				float num5 = this.float_12;
				float num6 = this.float_13;
				float num7 = this.float_14;
				if (num2 < num3)
				{
					if (num2 < num4)
					{
						if (num2 < num5)
						{
							num += num7;
						}
						else
						{
							num += num6 + (num7 - num6) * ((num2 - num4) / (num5 - num4));
						}
					}
					else
					{
						num += num6 * ((num2 - num3) / (num4 - num3));
					}
				}
			}
			float num8 = this.float_20;
			float num9 = GClass84.smethod_359(this.float_23 + num, 0f);
			float num10 = this.float_32;
			float num11 = this.float_33;
			if (this.float_36 <= this.gclass176_0.Single_0)
			{
				if (this.Boolean_0 && num8 < num10)
				{
					this.float_20 = GClass84.smethod_910(num8 + (num10 - this.vmethod_40()) / num11 * 0.2f, num10);
					this.float_36 = this.gclass176_0.Single_0 + 0.2f;
				}
				else if (num8 != num9)
				{
					float num12 = 1f;
					if (num9 >= this.float_21 && num9 <= this.float_22)
					{
						num12 *= this.float_30;
					}
					num12 *= this.float_31;
					this.float_20 = GClass84.smethod_415(num8 + (num9 - num8) * 0.025f * num12, GClass84.smethod_910(num8, num9), GClass84.smethod_359(num8, num9));
					this.float_36 = this.gclass176_0.Single_0 + 0.2f;
				}
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00092CA0 File Offset: 0x00090EA0
		internal void method_80()
		{
			base.vmethod_26();
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00092CB4 File Offset: 0x00090EB4
		internal void method_81()
		{
			this.method_104();
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00092CC8 File Offset: 0x00090EC8
		public override void vmethod_15()
		{
			this.method_52();
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00092F08 File Offset: 0x00091108
		internal void method_82()
		{
			this.method_91();
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00092F1C File Offset: 0x0009111C
		public static bool smethod_0(GClass173 gclass173_0, GClass169 gclass169_0)
		{
			bool result;
			if (gclass169_0 == null)
			{
				result = (gclass173_0 != null && gclass173_0.gameObject_0 != null);
			}
			else
			{
				result = (gclass173_0 == gclass169_0);
			}
			return result;
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00092F50 File Offset: 0x00091150
		public virtual void vmethod_45(float float_38)
		{
			this.method_74(float_38);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00092F64 File Offset: 0x00091164
		internal void method_83()
		{
			this.method_109();
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00092F78 File Offset: 0x00091178
		public virtual void vmethod_46(float float_38 = 0f)
		{
			this.method_85(float_38);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00092F8C File Offset: 0x0009118C
		internal void method_84()
		{
			this.method_93();
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00092FA0 File Offset: 0x000911A0
		internal void method_85(float float_38)
		{
			this.method_108(float_38);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00092FB4 File Offset: 0x000911B4
		public override void vmethod_31()
		{
			this.method_84();
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00092FC8 File Offset: 0x000911C8
		internal void method_86()
		{
			this.method_90();
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00092FDC File Offset: 0x000911DC
		internal void method_87(float float_38)
		{
			this.method_64(float_38);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00092FF0 File Offset: 0x000911F0
		internal bool Boolean_0
		{
			get
			{
				return Input.GetKey(306);
			}
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00093008 File Offset: 0x00091208
		internal void method_88()
		{
			foreach (string str in this.list_0)
			{
				this.list_1.Add(GClass84.smethod_268((this.string_1 + "\\" + str + ".png").Replace("/", "\\")));
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0009308C File Offset: 0x0009128C
		public override void vmethod_29()
		{
			this.method_67();
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000930A0 File Offset: 0x000912A0
		public override void vmethod_28()
		{
			this.method_53();
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000930B4 File Offset: 0x000912B4
		public override void vmethod_35()
		{
			this.method_81();
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000930C8 File Offset: 0x000912C8
		internal void method_89()
		{
			this.method_94();
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000930DC File Offset: 0x000912DC
		public virtual void vmethod_47(float float_38)
		{
			this.method_57(float_38);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000930F0 File Offset: 0x000912F0
		public static bool smethod_1(GClass173 gclass173_0, GClass169 gclass169_0)
		{
			bool result;
			if (gclass169_0 == null)
			{
				result = (gclass173_0 == null || gclass173_0.gameObject_0 == null);
			}
			else
			{
				result = (gclass173_0 == gclass169_0);
			}
			return result;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00093124 File Offset: 0x00091324
		public override void vmethod_22()
		{
			this.method_95();
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00093138 File Offset: 0x00091338
		public virtual void vmethod_48(float float_38)
		{
			this.method_87(float_38);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0009314C File Offset: 0x0009134C
		internal void method_90()
		{
			base.vmethod_24();
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00093160 File Offset: 0x00091360
		internal void method_91()
		{
			this.float_6 = GClass84.smethod_359(this.float_7 - this.float_5, 0f);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0009318C File Offset: 0x0009138C
		internal void method_92()
		{
			this.method_69();
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000931A0 File Offset: 0x000913A0
		internal void method_93()
		{
			base.vmethod_31();
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x000931B4 File Offset: 0x000913B4
		internal void method_94()
		{
			if (!this.gameObject_0)
			{
				this.gameObject_0 = GClass84.smethod_461();
			}
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000931DC File Offset: 0x000913DC
		public override void vmethod_26()
		{
			this.method_50();
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000931F0 File Offset: 0x000913F0
		internal void method_95()
		{
			this.method_78();
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00093204 File Offset: 0x00091404
		internal void method_96()
		{
			this.method_98();
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00093218 File Offset: 0x00091418
		internal void method_97()
		{
			base.vmethod_19();
			if (!GClass173.smethod_1(this, null))
			{
				if (this.bool_11)
				{
					this.vmethod_47(GClass84.float_0);
				}
				if (this.bool_6)
				{
					this.vmethod_45(GClass84.float_0);
				}
				if (this.bool_3)
				{
					this.vmethod_46(GClass84.float_0);
				}
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00093270 File Offset: 0x00091470
		public override void vmethod_11()
		{
			this.method_99();
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00093284 File Offset: 0x00091484
		internal void method_98()
		{
			base.vmethod_10();
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00093298 File Offset: 0x00091498
		internal void method_99()
		{
			this.method_71();
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000932AC File Offset: 0x000914AC
		public override void vmethod_34()
		{
			this.method_58();
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000932C0 File Offset: 0x000914C0
		internal void method_100()
		{
			this.method_76();
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000932D4 File Offset: 0x000914D4
		internal void method_101(float float_38)
		{
			if (this.bool_4)
			{
				this.vmethod_37(float_38);
				this.vmethod_43(float_38);
				this.vmethod_48(float_38);
				if (this.bool_7)
				{
					this.vmethod_49(float_38);
				}
				this.vmethod_39();
			}
			if (this.bool_5)
			{
				this.float_7 = this.float_9;
				this.float_5 = GClass84.smethod_910(this.float_8, this.float_7);
				this.vmethod_39();
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00093344 File Offset: 0x00091544
		internal void method_102(int int_5)
		{
			this.method_107(int_5);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00093358 File Offset: 0x00091558
		internal void method_103(int int_5)
		{
			base.vmethod_27(int_5);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0009336C File Offset: 0x0009156C
		internal void method_104()
		{
			base.vmethod_35();
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00093380 File Offset: 0x00091580
		internal void method_105(int int_5, GClass169 gclass169_0)
		{
			this.method_56(int_5, gclass169_0);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00093398 File Offset: 0x00091598
		internal void method_106()
		{
			this.method_88();
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000933AC File Offset: 0x000915AC
		public virtual void vmethod_49(float float_38)
		{
			this.method_60(float_38);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000933C0 File Offset: 0x000915C0
		internal void method_107(int int_5)
		{
			base.vmethod_8(int_5);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x000933D4 File Offset: 0x000915D4
		internal void method_108(float float_38)
		{
			if (this.bool_1)
			{
				if (this.float_2 <= 0f)
				{
					this.float_3 = this.gclass176_0.Single_0 + this.float_4;
					this.float_2 = 1f;
					this.bool_0 = false;
				}
				if (this.gclass176_0.Single_0 >= this.float_3)
				{
					if (!this.bool_0)
					{
						this.bool_0 = true;
					}
					this.float_2 = GClass84.smethod_359(this.float_2 - float_38 / 5f, 0f);
				}
			}
			if (this.bool_2)
			{
				this.float_2 = 1f;
			}
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00093484 File Offset: 0x00091684
		public override void vmethod_10()
		{
			this.method_96();
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00093498 File Offset: 0x00091698
		public virtual void vmethod_50(float float_38)
		{
			this.method_73(float_38);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000934AC File Offset: 0x000916AC
		internal void method_109()
		{
			base.vmethod_23();
			if (this.bool_11)
			{
				this.float_23 = this.vmethod_40();
				this.float_20 = this.float_23;
			}
			if (this.bool_6)
			{
				this.float_7 = this.float_9;
				this.float_5 = GClass84.smethod_910(this.float_8, this.float_7);
				this.vmethod_39();
			}
		}

		// Token: 0x04001158 RID: 4440
		internal float float_2 = 0f;

		// Token: 0x04001159 RID: 4441
		internal float float_3 = 0f;

		// Token: 0x0400115A RID: 4442
		internal bool bool_0 = false;

		// Token: 0x0400115B RID: 4443
		internal float float_4 = 0f;

		// Token: 0x0400115C RID: 4444
		internal bool bool_1 = false;

		// Token: 0x0400115D RID: 4445
		internal bool bool_2 = false;

		// Token: 0x0400115E RID: 4446
		internal bool bool_3 = false;

		// Token: 0x0400115F RID: 4447
		internal bool bool_4 = false;

		// Token: 0x04001160 RID: 4448
		internal bool bool_5 = false;

		// Token: 0x04001161 RID: 4449
		internal bool bool_6 = false;

		// Token: 0x04001162 RID: 4450
		internal float float_5 = 0f;

		// Token: 0x04001163 RID: 4451
		internal float float_6 = 0f;

		// Token: 0x04001164 RID: 4452
		internal float float_7 = 0f;

		// Token: 0x04001165 RID: 4453
		internal float float_8 = 0f;

		// Token: 0x04001166 RID: 4454
		internal float float_9 = 0f;

		// Token: 0x04001167 RID: 4455
		internal float float_10 = 0f;

		// Token: 0x04001168 RID: 4456
		internal int int_3 = 0;

		// Token: 0x04001169 RID: 4457
		internal float float_11 = 0f;

		// Token: 0x0400116A RID: 4458
		internal float float_12 = 0f;

		// Token: 0x0400116B RID: 4459
		internal float float_13 = 0f;

		// Token: 0x0400116C RID: 4460
		internal float float_14 = 0f;

		// Token: 0x0400116D RID: 4461
		internal float float_15 = 0f;

		// Token: 0x0400116E RID: 4462
		internal float float_16 = 0f;

		// Token: 0x0400116F RID: 4463
		internal float float_17 = 0f;

		// Token: 0x04001170 RID: 4464
		internal float float_18 = 0f;

		// Token: 0x04001171 RID: 4465
		internal float float_19 = 0f;

		// Token: 0x04001172 RID: 4466
		internal bool bool_7 = false;

		// Token: 0x04001173 RID: 4467
		internal bool bool_8 = false;

		// Token: 0x04001174 RID: 4468
		internal bool bool_9 = false;

		// Token: 0x04001175 RID: 4469
		internal bool bool_10 = false;

		// Token: 0x04001176 RID: 4470
		internal bool bool_11 = false;

		// Token: 0x04001177 RID: 4471
		internal float float_20 = 0f;

		// Token: 0x04001178 RID: 4472
		internal float float_21 = 0f;

		// Token: 0x04001179 RID: 4473
		internal float float_22 = 0f;

		// Token: 0x0400117A RID: 4474
		internal float float_23 = 0f;

		// Token: 0x0400117B RID: 4475
		internal float float_24 = 0f;

		// Token: 0x0400117C RID: 4476
		internal float float_25 = 0f;

		// Token: 0x0400117D RID: 4477
		internal float float_26 = 0f;

		// Token: 0x0400117E RID: 4478
		internal float float_27 = 0f;

		// Token: 0x0400117F RID: 4479
		internal float float_28 = 0f;

		// Token: 0x04001180 RID: 4480
		internal float float_29 = 0f;

		// Token: 0x04001181 RID: 4481
		internal float float_30 = 0f;

		// Token: 0x04001182 RID: 4482
		internal float float_31 = 0f;

		// Token: 0x04001183 RID: 4483
		internal float float_32 = 0f;

		// Token: 0x04001184 RID: 4484
		internal float float_33 = 0f;

		// Token: 0x04001185 RID: 4485
		internal float float_34 = 0f;

		// Token: 0x04001186 RID: 4486
		internal float float_35 = 0f;

		// Token: 0x04001187 RID: 4487
		internal float float_36 = 0f;

		// Token: 0x04001188 RID: 4488
		internal string string_1 = string.Empty;

		// Token: 0x04001189 RID: 4489
		internal List<string> list_0 = new List<string>();

		// Token: 0x0400118A RID: 4490
		internal List<Texture> list_1 = new List<Texture>();

		// Token: 0x0400118B RID: 4491
		internal int int_4 = 0;

		// Token: 0x0400118C RID: 4492
		internal float float_37 = 0f;

		// Token: 0x0400118D RID: 4493
		internal bool bool_12 = false;
	}
}
