using System;
using System.Collections.Generic;
using ns241;
using ns375;
using ns425;
using UnityEngine;
using VRC;

namespace ns460
{
	// Token: 0x020002EE RID: 750
	public class GClass164 : GClass130
	{
		// Token: 0x06003F90 RID: 16272 RVA: 0x000EFEC0 File Offset: 0x000EE0C0
		internal void method_2(bool bool_9)
		{
			this.method_31(bool_9);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x000EFED4 File Offset: 0x000EE0D4
		internal void method_3(Color color_8)
		{
			this.method_50(color_8);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000EFEE8 File Offset: 0x000EE0E8
		internal void method_4()
		{
			this.method_63();
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000EFEFC File Offset: 0x000EE0FC
		internal void method_5()
		{
			this.method_51();
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000EFF10 File Offset: 0x000EE110
		internal void method_6(Color color_8)
		{
			this.method_14(color_8);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000EFF24 File Offset: 0x000EE124
		internal void method_7(bool bool_9)
		{
			this.bool_0 = bool_9;
			GClass84.gclass117_0.bool_25 = bool_9;
			GClass117.smethod_3();
			if (bool_9)
			{
				this.method_5();
			}
			else
			{
				this.method_32();
			}
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000EFF5C File Offset: 0x000EE15C
		internal void method_8(bool bool_9)
		{
			this.method_21(bool_9);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x000EFF70 File Offset: 0x000EE170
		internal void method_9(Color color_8)
		{
			this.method_40(color_8);
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x000EFF84 File Offset: 0x000EE184
		internal void method_10(Color color_8)
		{
			this.method_43(color_8);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x000EFF98 File Offset: 0x000EE198
		internal void method_11(Color color_8)
		{
			this.method_15(color_8);
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x000EFFAC File Offset: 0x000EE1AC
		internal void method_12(bool bool_9)
		{
			this.bool_7 = bool_9;
			GClass84.gclass117_0.bool_32 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x000EFFD8 File Offset: 0x000EE1D8
		internal void method_13(Color color_8)
		{
			this.method_10(color_8);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x000EFFEC File Offset: 0x000EE1EC
		internal void method_14(Color color_8)
		{
			this.method_56(color_8);
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000F0000 File Offset: 0x000EE200
		public override void vmethod_23()
		{
			this.method_16();
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000F0014 File Offset: 0x000EE214
		internal void method_15(Color color_8)
		{
			this.method_36(color_8);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x000F0028 File Offset: 0x000EE228
		internal void method_16()
		{
			this.method_73();
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x000F003C File Offset: 0x000EE23C
		internal void method_17()
		{
			this.method_62();
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x000F0050 File Offset: 0x000EE250
		internal void method_18()
		{
			if (this.list_0.Count > 0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					if (this.list_0[i])
					{
						GClass84.smethod_590(this.list_0[i], false, ref this.highlightsFXStandalone_0);
					}
				}
				this.list_0.Clear();
			}
			if (this.list_1.Count > 0)
			{
				for (int j = this.list_1.Count - 1; j >= 0; j--)
				{
					if (this.list_1[j])
					{
						GClass84.smethod_590(this.list_1[j], false, ref this.highlightsFXStandalone_1);
					}
				}
				this.list_1.Clear();
			}
			if (this.list_2.Count > 0)
			{
				for (int k = this.list_2.Count - 1; k >= 0; k--)
				{
					if (this.list_2[k])
					{
						GClass84.smethod_590(this.list_2[k], false, ref this.highlightsFXStandalone_2);
					}
				}
				this.list_2.Clear();
			}
			if (this.list_3.Count > 0)
			{
				for (int l = this.list_3.Count - 1; l >= 0; l--)
				{
					if (this.list_3[l])
					{
						GClass84.smethod_590(this.list_3[l], false, ref this.highlightsFXStandalone_3);
					}
				}
				this.list_3.Clear();
			}
			if (this.list_4.Count > 0)
			{
				for (int m = this.list_4.Count - 1; m >= 0; m--)
				{
					if (this.list_4[m])
					{
						GClass84.smethod_590(this.list_4[m], false, ref this.highlightsFXStandalone_4);
					}
				}
				this.list_4.Clear();
			}
			if (this.list_5.Count > 0)
			{
				for (int n = this.list_5.Count - 1; n >= 0; n--)
				{
					if (this.list_5[n])
					{
						GClass84.smethod_590(this.list_5[n], false, ref this.highlightsFXStandalone_5);
					}
				}
				this.list_5.Clear();
			}
			if (this.list_6.Count > 0)
			{
				for (int num = this.list_6.Count - 1; num >= 0; num--)
				{
					if (this.list_6[num])
					{
						GClass84.smethod_590(this.list_6[num], false, ref this.highlightsFXStandalone_6);
					}
				}
				this.list_6.Clear();
			}
			if (this.list_7.Count > 0)
			{
				for (int num2 = this.list_7.Count - 1; num2 >= 0; num2--)
				{
					if (this.list_7[num2])
					{
						GClass84.smethod_590(this.list_7[num2], false, ref this.highlightsFXStandalone_7);
					}
				}
				this.list_7.Clear();
			}
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000F03A0 File Offset: 0x000EE5A0
		internal Color method_19(ref float float_8, float float_9)
		{
			float_8 = (float_8 + float_9 * 60f) % 360f;
			Color result;
			if (float_8 < 60f)
			{
				result = new Color(1f, float_8 / 60f, 0f, 1f);
			}
			else if (float_8 < 120f)
			{
				result = new Color(1f - (float_8 - 60f) / 60f, 1f, 0f, 1f);
			}
			else if (float_8 < 180f)
			{
				result = new Color(0f, 1f, (float_8 - 120f) / 60f, 1f);
			}
			else if (float_8 < 240f)
			{
				result = new Color(0f, 1f - (float_8 - 180f) / 60f, 1f, 1f);
			}
			else if (float_8 < 300f)
			{
				result = new Color((float_8 - 240f) / 60f, 0f, 1f, 1f);
			}
			else if (float_8 < 360f)
			{
				result = new Color(1f, 0f, 1f - (float_8 - 300f) / 60f, 1f);
			}
			else
			{
				result = new Color(0f, 0f, 0f, 1f);
			}
			return result;
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000F0514 File Offset: 0x000EE714
		internal void method_20()
		{
			Player[] array = GClass84.smethod_870();
			for (int i = 0; i < array.Length; i++)
			{
				Transform transform = array[i].transform.Find("SelectRegion");
				if (transform)
				{
					MeshRenderer component = transform.GetComponent<MeshRenderer>();
					if (!(component == null))
					{
						switch (GClass84.smethod_1387(GClass84.smethod_518(array[i]), true))
						{
						case GClass84.Enum5.const_0:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_0, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_0);
								this.list_0.Add(component);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_1:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_1, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_1);
								this.list_1.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_2:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_2, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_2);
								this.list_2.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_3:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_3, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_3);
								this.list_3.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_4:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_4, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_4);
								this.list_4.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_5:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_5, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_5);
								this.list_5.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_6:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_6, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_6);
								this.list_6.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_7, component, ref this.highlightsFXStandalone_7);
							}
							break;
						case GClass84.Enum5.const_7:
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_7, component))
							{
								GClass84.smethod_590(component, true, ref this.highlightsFXStandalone_7);
								this.list_7.Add(component);
								this.method_45(this.list_0, component, ref this.highlightsFXStandalone_0);
								this.method_45(this.list_1, component, ref this.highlightsFXStandalone_1);
								this.method_45(this.list_2, component, ref this.highlightsFXStandalone_2);
								this.method_45(this.list_3, component, ref this.highlightsFXStandalone_3);
								this.method_45(this.list_4, component, ref this.highlightsFXStandalone_4);
								this.method_45(this.list_5, component, ref this.highlightsFXStandalone_5);
								this.method_45(this.list_6, component, ref this.highlightsFXStandalone_6);
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000F0B9C File Offset: 0x000EED9C
		internal void method_21(bool bool_9)
		{
			this.method_7(bool_9);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000F0BB0 File Offset: 0x000EEDB0
		internal void method_22(bool bool_9)
		{
			this.method_34(bool_9);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000F0BC4 File Offset: 0x000EEDC4
		internal void method_23(bool bool_9)
		{
			this.method_60(bool_9);
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000F0BD8 File Offset: 0x000EEDD8
		internal void method_24(List<MeshRenderer> list_8, MeshRenderer meshRenderer_0, ref HighlightsFXStandalone highlightsFXStandalone_8)
		{
			this.method_47(list_8, meshRenderer_0, ref highlightsFXStandalone_8);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x000F0BF0 File Offset: 0x000EEDF0
		internal void method_25(bool bool_9)
		{
			this.method_38(bool_9);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x000F0C04 File Offset: 0x000EEE04
		internal void method_26(Color color_8)
		{
			this.color_5 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_62 = this.color_5.r;
			GClass84.gclass117_0.float_63 = this.color_5.g;
			GClass84.gclass117_0.float_64 = this.color_5.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000F0C74 File Offset: 0x000EEE74
		internal void method_27(Color color_8)
		{
			this.color_0 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_47 = this.color_0.r;
			GClass84.gclass117_0.float_48 = this.color_0.g;
			GClass84.gclass117_0.float_49 = this.color_0.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x000F0CE4 File Offset: 0x000EEEE4
		internal void method_28()
		{
			if (!this.bool_0)
			{
				this.method_32();
			}
			else
			{
				this.method_5();
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000F0D0C File Offset: 0x000EEF0C
		internal void method_29(bool bool_9)
		{
			this.method_54(bool_9);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000F0D20 File Offset: 0x000EEF20
		public override void vmethod_24()
		{
			this.method_69();
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x000F0D34 File Offset: 0x000EEF34
		internal void method_30(bool bool_9)
		{
			this.method_33(bool_9);
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x000F0D48 File Offset: 0x000EEF48
		internal void method_31(bool bool_9)
		{
			this.method_37(bool_9);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x000F0D5C File Offset: 0x000EEF5C
		internal void method_32()
		{
			this.method_48();
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x000F0D70 File Offset: 0x000EEF70
		internal void method_33(bool bool_9)
		{
			this.bool_3 = bool_9;
			GClass84.gclass117_0.bool_28 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000F0D9C File Offset: 0x000EEF9C
		internal void method_34(bool bool_9)
		{
			this.bool_2 = bool_9;
			GClass84.gclass117_0.bool_27 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x000F0DC8 File Offset: 0x000EEFC8
		internal void method_35(Color color_8)
		{
			this.method_27(color_8);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000F0DDC File Offset: 0x000EEFDC
		internal void method_36(Color color_8)
		{
			this.color_4 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_59 = this.color_4.r;
			GClass84.gclass117_0.float_60 = this.color_4.g;
			GClass84.gclass117_0.float_61 = this.color_4.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x000F0E4C File Offset: 0x000EF04C
		internal void method_37(bool bool_9)
		{
			this.bool_5 = bool_9;
			GClass84.gclass117_0.bool_30 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x000F0E78 File Offset: 0x000EF078
		internal void method_38(bool bool_9)
		{
			this.method_12(bool_9);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x000F0E8C File Offset: 0x000EF08C
		internal void method_39(bool bool_9)
		{
			this.method_30(bool_9);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000F0EA0 File Offset: 0x000EF0A0
		internal void method_40(Color color_8)
		{
			this.method_57(color_8);
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x000F0EB4 File Offset: 0x000EF0B4
		internal void method_41(bool bool_9)
		{
			this.method_70(bool_9);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x000F0EC8 File Offset: 0x000EF0C8
		internal void method_42(Color color_8)
		{
			this.method_26(color_8);
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x000F0EDC File Offset: 0x000EF0DC
		internal void method_43(Color color_8)
		{
			this.color_7 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_68 = this.color_7.r;
			GClass84.gclass117_0.float_69 = this.color_7.g;
			GClass84.gclass117_0.float_70 = this.color_7.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x000F0F4C File Offset: 0x000EF14C
		internal void method_44(Color color_8)
		{
			this.method_58(color_8);
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000F0F60 File Offset: 0x000EF160
		internal void method_45(List<MeshRenderer> list_8, MeshRenderer meshRenderer_0, ref HighlightsFXStandalone highlightsFXStandalone_8)
		{
			this.method_24(list_8, meshRenderer_0, ref highlightsFXStandalone_8);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x000F0F78 File Offset: 0x000EF178
		internal void method_46(Color color_8)
		{
			this.method_3(color_8);
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x000F0F8C File Offset: 0x000EF18C
		internal void method_47(List<MeshRenderer> list_8, MeshRenderer meshRenderer_0, ref HighlightsFXStandalone highlightsFXStandalone_8)
		{
			if (GClass84.smethod_1688<MeshRenderer>(list_8, meshRenderer_0))
			{
				GClass84.smethod_590(meshRenderer_0, false, ref highlightsFXStandalone_8);
			}
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000F0FAC File Offset: 0x000EF1AC
		internal void method_48()
		{
			this.method_18();
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x000F0FC0 File Offset: 0x000EF1C0
		internal void method_49(bool bool_9)
		{
			this.method_29(bool_9);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x000F0FD4 File Offset: 0x000EF1D4
		internal void method_50(Color color_8)
		{
			this.color_1 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_50 = this.color_1.r;
			GClass84.gclass117_0.float_51 = this.color_1.g;
			GClass84.gclass117_0.float_52 = this.color_1.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x000F1044 File Offset: 0x000EF244
		internal void method_51()
		{
			this.method_20();
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x000F1058 File Offset: 0x000EF258
		internal void method_52()
		{
			if (this.bool_0)
			{
				if (this.bool_1)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_0, this.method_19(ref this.float_0, GClass84.float_0));
				}
				if (this.bool_2)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_1, this.method_19(ref this.float_1, GClass84.float_0));
				}
				if (this.bool_3)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_2, this.method_19(ref this.float_2, GClass84.float_0));
				}
				if (this.bool_4)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_3, this.method_19(ref this.float_3, GClass84.float_0));
				}
				if (this.bool_5)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_4, this.method_19(ref this.float_4, GClass84.float_0));
				}
				if (this.bool_6)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_5, this.method_19(ref this.float_5, GClass84.float_0));
				}
				if (this.bool_7)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_6, this.method_19(ref this.float_6, GClass84.float_0));
				}
				if (this.bool_8)
				{
					GClass84.smethod_1683(ref this.highlightsFXStandalone_7, this.method_19(ref this.float_7, GClass84.float_0));
				}
			}
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x000F1194 File Offset: 0x000EF394
		internal void method_53(Color color_8)
		{
			this.method_35(color_8);
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x000F11A8 File Offset: 0x000EF3A8
		internal void method_54(bool bool_9)
		{
			this.bool_4 = bool_9;
			GClass84.gclass117_0.bool_29 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000F11D4 File Offset: 0x000EF3D4
		public override void vmethod_13()
		{
			this.method_65();
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000F11E8 File Offset: 0x000EF3E8
		internal void method_55(bool bool_9)
		{
			this.method_66(bool_9);
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000F11FC File Offset: 0x000EF3FC
		internal void method_56(Color color_8)
		{
			this.color_2 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_53 = this.color_2.r;
			GClass84.gclass117_0.float_54 = this.color_2.g;
			GClass84.gclass117_0.float_55 = this.color_2.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x000F126C File Offset: 0x000EF46C
		internal void method_57(Color color_8)
		{
			this.color_6 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_65 = this.color_6.r;
			GClass84.gclass117_0.float_66 = this.color_6.g;
			GClass84.gclass117_0.float_67 = this.color_6.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x000F12DC File Offset: 0x000EF4DC
		internal void method_58(Color color_8)
		{
			this.method_72(color_8);
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x000F12F0 File Offset: 0x000EF4F0
		public override void vmethod_19()
		{
			this.method_71();
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x000F1304 File Offset: 0x000EF504
		internal void method_59(bool bool_9)
		{
			this.method_22(bool_9);
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x000F1318 File Offset: 0x000EF518
		internal void method_60(bool bool_9)
		{
			this.bool_6 = bool_9;
			GClass84.gclass117_0.bool_31 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x000F1344 File Offset: 0x000EF544
		internal void method_61(bool bool_9)
		{
			this.method_55(bool_9);
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x000F1358 File Offset: 0x000EF558
		internal void method_62()
		{
			this.method_4();
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x000F136C File Offset: 0x000EF56C
		internal void method_63()
		{
			GClass84.smethod_1683(ref this.highlightsFXStandalone_0, this.color_0);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_1, this.color_1);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_2, this.color_2);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_3, this.color_3);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_4, this.color_4);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_5, this.color_5);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_6, this.color_6);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_7, this.color_7);
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x000F1404 File Offset: 0x000EF604
		internal void method_64(Color color_8)
		{
			this.method_42(color_8);
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x000F1418 File Offset: 0x000EF618
		internal void method_65()
		{
			this.method_17();
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x000F142C File Offset: 0x000EF62C
		internal void method_66(bool bool_9)
		{
			this.bool_1 = bool_9;
			GClass84.gclass117_0.bool_26 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x000F1458 File Offset: 0x000EF658
		internal void method_67(bool bool_9)
		{
			this.method_41(bool_9);
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x000F146C File Offset: 0x000EF66C
		internal void method_68(bool bool_9)
		{
			this.method_23(bool_9);
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x000F1480 File Offset: 0x000EF680
		internal void method_69()
		{
			this.method_28();
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x000F1494 File Offset: 0x000EF694
		internal void method_70(bool bool_9)
		{
			this.bool_8 = bool_9;
			GClass84.gclass117_0.bool_33 = bool_9;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x000F1668 File Offset: 0x000EF868
		internal void method_71()
		{
			this.method_52();
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x000F167C File Offset: 0x000EF87C
		internal void method_72(Color color_8)
		{
			this.color_3 = GClass84.smethod_1042(color_8, 0f, 1f);
			GClass84.gclass117_0.float_56 = this.color_3.r;
			GClass84.gclass117_0.float_57 = this.color_3.g;
			GClass84.gclass117_0.float_58 = this.color_3.b;
			GClass117.smethod_3();
			this.method_62();
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x000F16EC File Offset: 0x000EF8EC
		internal void method_73()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_14.Add(new Action(this.vmethod_13));
			this.bool_0 = GClass84.gclass117_0.bool_25;
			this.color_0.r = GClass84.gclass117_0.float_47;
			this.color_0.g = GClass84.gclass117_0.float_48;
			this.color_0.b = GClass84.gclass117_0.float_49;
			this.bool_1 = GClass84.gclass117_0.bool_26;
			this.color_1.r = GClass84.gclass117_0.float_50;
			this.color_1.g = GClass84.gclass117_0.float_51;
			this.color_1.b = GClass84.gclass117_0.float_52;
			this.bool_2 = GClass84.gclass117_0.bool_27;
			this.color_2.r = GClass84.gclass117_0.float_53;
			this.color_2.g = GClass84.gclass117_0.float_54;
			this.color_2.b = GClass84.gclass117_0.float_55;
			this.bool_3 = GClass84.gclass117_0.bool_28;
			this.color_3.r = GClass84.gclass117_0.float_56;
			this.color_3.g = GClass84.gclass117_0.float_57;
			this.color_3.b = GClass84.gclass117_0.float_58;
			this.bool_4 = GClass84.gclass117_0.bool_29;
			this.color_4.r = GClass84.gclass117_0.float_59;
			this.color_4.g = GClass84.gclass117_0.float_60;
			this.color_4.b = GClass84.gclass117_0.float_61;
			this.bool_5 = GClass84.gclass117_0.bool_30;
			this.color_5.r = GClass84.gclass117_0.float_62;
			this.color_5.g = GClass84.gclass117_0.float_63;
			this.color_5.b = GClass84.gclass117_0.float_64;
			this.bool_6 = GClass84.gclass117_0.bool_31;
			this.color_6.r = GClass84.gclass117_0.float_65;
			this.color_6.g = GClass84.gclass117_0.float_66;
			this.color_6.b = GClass84.gclass117_0.float_67;
			this.bool_7 = GClass84.gclass117_0.bool_32;
			this.color_7.r = GClass84.gclass117_0.float_68;
			this.color_7.g = GClass84.gclass117_0.float_69;
			this.color_7.b = GClass84.gclass117_0.float_70;
			this.bool_8 = GClass84.gclass117_0.bool_33;
		}

		// Token: 0x04001880 RID: 6272
		internal bool bool_0 = false;

		// Token: 0x04001881 RID: 6273
		internal HighlightsFXStandalone highlightsFXStandalone_0;

		// Token: 0x04001882 RID: 6274
		internal Color color_0 = Color.white;

		// Token: 0x04001883 RID: 6275
		internal bool bool_1 = false;

		// Token: 0x04001884 RID: 6276
		internal float float_0 = 0f;

		// Token: 0x04001885 RID: 6277
		internal HighlightsFXStandalone highlightsFXStandalone_1;

		// Token: 0x04001886 RID: 6278
		internal Color color_1 = new Color(0.09f, 0.47f, 1f);

		// Token: 0x04001887 RID: 6279
		internal bool bool_2 = false;

		// Token: 0x04001888 RID: 6280
		internal float float_1 = 0f;

		// Token: 0x04001889 RID: 6281
		internal HighlightsFXStandalone highlightsFXStandalone_2;

		// Token: 0x0400188A RID: 6282
		internal Color color_2 = new Color(0.17f, 0.81f, 0.36f);

		// Token: 0x0400188B RID: 6283
		internal bool bool_3 = false;

		// Token: 0x0400188C RID: 6284
		internal float float_2 = 0f;

		// Token: 0x0400188D RID: 6285
		internal HighlightsFXStandalone highlightsFXStandalone_3;

		// Token: 0x0400188E RID: 6286
		internal Color color_3 = new Color(1f, 0.48f, 0.26f);

		// Token: 0x0400188F RID: 6287
		internal bool bool_4 = false;

		// Token: 0x04001890 RID: 6288
		internal float float_3 = 0f;

		// Token: 0x04001891 RID: 6289
		internal HighlightsFXStandalone highlightsFXStandalone_4;

		// Token: 0x04001892 RID: 6290
		internal Color color_4 = new Color(0.5f, 0.26f, 0.9f);

		// Token: 0x04001893 RID: 6291
		internal bool bool_5 = false;

		// Token: 0x04001894 RID: 6292
		internal float float_4 = 0f;

		// Token: 0x04001895 RID: 6293
		internal HighlightsFXStandalone highlightsFXStandalone_5;

		// Token: 0x04001896 RID: 6294
		internal Color color_5 = Color.yellow;

		// Token: 0x04001897 RID: 6295
		internal bool bool_6 = false;

		// Token: 0x04001898 RID: 6296
		internal float float_5 = 0f;

		// Token: 0x04001899 RID: 6297
		internal HighlightsFXStandalone highlightsFXStandalone_6;

		// Token: 0x0400189A RID: 6298
		internal Color color_6 = new Color(1f, 0.41f, 0.7f);

		// Token: 0x0400189B RID: 6299
		internal bool bool_7 = false;

		// Token: 0x0400189C RID: 6300
		internal float float_6 = 0f;

		// Token: 0x0400189D RID: 6301
		internal HighlightsFXStandalone highlightsFXStandalone_7;

		// Token: 0x0400189E RID: 6302
		internal Color color_7 = Color.yellow;

		// Token: 0x0400189F RID: 6303
		internal bool bool_8 = true;

		// Token: 0x040018A0 RID: 6304
		internal float float_7 = 0f;

		// Token: 0x040018A1 RID: 6305
		internal List<MeshRenderer> list_0 = new List<MeshRenderer>();

		// Token: 0x040018A2 RID: 6306
		internal List<MeshRenderer> list_1 = new List<MeshRenderer>();

		// Token: 0x040018A3 RID: 6307
		internal List<MeshRenderer> list_2 = new List<MeshRenderer>();

		// Token: 0x040018A4 RID: 6308
		internal List<MeshRenderer> list_3 = new List<MeshRenderer>();

		// Token: 0x040018A5 RID: 6309
		internal List<MeshRenderer> list_4 = new List<MeshRenderer>();

		// Token: 0x040018A6 RID: 6310
		internal List<MeshRenderer> list_5 = new List<MeshRenderer>();

		// Token: 0x040018A7 RID: 6311
		internal List<MeshRenderer> list_6 = new List<MeshRenderer>();

		// Token: 0x040018A8 RID: 6312
		internal List<MeshRenderer> list_7 = new List<MeshRenderer>();
	}
}
