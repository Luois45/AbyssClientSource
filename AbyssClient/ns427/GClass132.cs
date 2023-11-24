using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using ns241;
using ns425;
using UnityEngine;
using VRC.SDKBase;

namespace ns427
{
	// Token: 0x02000008 RID: 8
	public class GClass132 : GClass130
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00003EDC File Offset: 0x000020DC
		internal void method_2()
		{
			this.method_22();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003EF0 File Offset: 0x000020F0
		public bool method_3(VRC_Pickup vrc_Pickup_0, float float_0)
		{
			bool result;
			if (!vrc_Pickup_0)
			{
				result = false;
			}
			else
			{
				this.method_21(vrc_Pickup_0);
				this.list_0.Add(new GClass132.GStruct2(vrc_Pickup_0, float_0));
				result = true;
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003F2C File Offset: 0x0000212C
		public bool method_4(List<VRC_Pickup> list_2, float float_0)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_3(list_2[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003F78 File Offset: 0x00002178
		public void method_5()
		{
			this.method_8();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003F8C File Offset: 0x0000218C
		public bool method_6(GameObject gameObject_0, bool bool_4)
		{
			return gameObject_0 && this.method_13(gameObject_0.GetComponent<VRC_Pickup>(), bool_4);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003FB8 File Offset: 0x000021B8
		public bool method_7(GameObject gameObject_0)
		{
			return gameObject_0 && this.method_21(gameObject_0.GetComponent<VRC_Pickup>());
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003FE4 File Offset: 0x000021E4
		internal void method_8()
		{
			this.method_12();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003FF8 File Offset: 0x000021F8
		private static HarmonyMethod smethod_0(string string_1)
		{
			return new HarmonyMethod(typeof(GClass132).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004020 File Offset: 0x00002220
		public bool method_9(Transform transform_0, float float_0)
		{
			return transform_0 && this.method_3(transform_0.GetComponent<VRC_Pickup>(), float_0);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000404C File Offset: 0x0000224C
		public void method_10(bool bool_4)
		{
			this.method_30(bool_4);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004060 File Offset: 0x00002260
		internal void method_11()
		{
			this.method_24();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004074 File Offset: 0x00002274
		internal void method_12()
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				GClass132.GStruct3 gstruct = this.list_1[i];
				VRC_Pickup vrc_Pickup_ = gstruct.vrc_Pickup_0;
				if (!vrc_Pickup_)
				{
					this.list_1.RemoveAt(i);
					i--;
				}
				else
				{
					vrc_Pickup_.DisallowTheft = gstruct.bool_0;
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000040D8 File Offset: 0x000022D8
		public override void vmethod_19()
		{
			this.method_2();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000040EC File Offset: 0x000022EC
		public bool method_13(VRC_Pickup vrc_Pickup_0, bool bool_4)
		{
			bool result;
			if (!vrc_Pickup_0)
			{
				result = false;
			}
			else
			{
				this.method_27(vrc_Pickup_0);
				this.list_1.Add(new GClass132.GStruct3(vrc_Pickup_0, bool_4));
				result = true;
			}
			return result;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004128 File Offset: 0x00002328
		internal void method_14()
		{
			this.method_37();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000413C File Offset: 0x0000233C
		public bool method_15(GameObject gameObject_0, float float_0)
		{
			return gameObject_0 && this.method_3(gameObject_0.GetComponent<VRC_Pickup>(), float_0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004168 File Offset: 0x00002368
		public bool method_16(Transform transform_0)
		{
			return transform_0 && this.method_27(transform_0.GetComponent<VRC_Pickup>());
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004194 File Offset: 0x00002394
		public bool method_17(Transform transform_0, bool bool_4)
		{
			return transform_0 && this.method_13(transform_0.GetComponent<VRC_Pickup>(), bool_4);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000041C0 File Offset: 0x000023C0
		public override void vmethod_23()
		{
			this.method_14();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000041D4 File Offset: 0x000023D4
		internal void method_18(bool bool_4)
		{
			this.bool_1 = bool_4;
			if (!bool_4)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i++)
				{
					this.method_21(this.list_0[i].vrc_Pickup_0);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004224 File Offset: 0x00002424
		internal void method_19(bool bool_4)
		{
			this.bool_2 = bool_4;
			if (!bool_4)
			{
				for (int i = this.list_1.Count - 1; i >= 0; i++)
				{
					this.method_27(this.list_1[i].vrc_Pickup_0);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004274 File Offset: 0x00002474
		internal void method_20(bool bool_4)
		{
			this.method_18(bool_4);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000042D0 File Offset: 0x000024D0
		public bool method_21(VRC_Pickup vrc_Pickup_0)
		{
			bool result;
			if (!vrc_Pickup_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < this.list_0.Count; i++)
				{
					GClass132.GStruct2 gstruct = this.list_0[i];
					VRC_Pickup vrc_Pickup_ = gstruct.vrc_Pickup_0;
					if (vrc_Pickup_ == vrc_Pickup_0)
					{
						vrc_Pickup_.proximity = gstruct.float_1;
						this.list_0.RemoveAt(i);
						i--;
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000434C File Offset: 0x0000254C
		internal void method_22()
		{
			if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304))
			{
				if (Input.GetKeyDown(105))
				{
					this.bool_0 = !this.bool_0;
				}
				if (Input.GetKeyDown(100))
				{
					this.bool_3 = !this.bool_3;
				}
			}
			if (this.bool_0)
			{
				this.method_32();
				this.method_5();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000043C0 File Offset: 0x000025C0
		public bool method_23(List<VRC_Pickup> list_2, bool bool_4)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_13(list_2[i], bool_4))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000440C File Offset: 0x0000260C
		internal void method_24()
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass132.GStruct2 gstruct = this.list_0[i];
				VRC_Pickup vrc_Pickup_ = gstruct.vrc_Pickup_0;
				if (!vrc_Pickup_)
				{
					this.list_0.RemoveAt(i);
					i--;
				}
				else
				{
					vrc_Pickup_.proximity = gstruct.float_0;
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004470 File Offset: 0x00002670
		private static bool smethod_1(VRC_Pickup vrc_Pickup_0, MethodBase methodBase_0)
		{
			return !GClass84.gclass132_0.bool_3;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004490 File Offset: 0x00002690
		public void method_25(bool bool_4)
		{
			this.method_20(bool_4);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000044A4 File Offset: 0x000026A4
		internal void method_26()
		{
			if (this.bool_1 && (this.list_0.Count == 0 || !this.list_0[0].vrc_Pickup_0))
			{
				this.list_0.Clear();
				List<VRC_Pickup> list = GClass84.smethod_540();
				for (int i = list.Count - 1; i >= 0; i--)
				{
					this.method_3(list[i], 1000f);
				}
			}
			if (this.bool_2 && (this.list_1.Count == 0 || !this.list_1[0].vrc_Pickup_0))
			{
				this.list_1.Clear();
				List<VRC_Pickup> list2 = GClass84.smethod_540();
				for (int j = list2.Count - 1; j >= 0; j--)
				{
					this.method_13(list2[j], false);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004594 File Offset: 0x00002794
		public bool method_27(VRC_Pickup vrc_Pickup_0)
		{
			bool result;
			if (!vrc_Pickup_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < this.list_1.Count; i++)
				{
					GClass132.GStruct3 gstruct = this.list_1[i];
					VRC_Pickup vrc_Pickup_ = gstruct.vrc_Pickup_0;
					if (vrc_Pickup_ == vrc_Pickup_0)
					{
						vrc_Pickup_.DisallowTheft = gstruct.bool_1;
						this.list_1.RemoveAt(i);
						i--;
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004610 File Offset: 0x00002810
		public bool method_28(List<Transform> list_2, float float_0)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_9(list_2[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000465C File Offset: 0x0000285C
		internal void method_29()
		{
			this.method_26();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004670 File Offset: 0x00002870
		internal void method_30(bool bool_4)
		{
			this.method_19(bool_4);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004684 File Offset: 0x00002884
		public bool method_31(GameObject gameObject_0)
		{
			return gameObject_0 && this.method_27(gameObject_0.GetComponent<VRC_Pickup>());
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000046B0 File Offset: 0x000028B0
		public void method_32()
		{
			this.method_11();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000046C4 File Offset: 0x000028C4
		public bool method_33(Transform transform_0)
		{
			return transform_0 && this.method_21(transform_0.GetComponent<VRC_Pickup>());
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000046F0 File Offset: 0x000028F0
		public bool method_34(List<GameObject> list_2, bool bool_4)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_6(list_2[i], bool_4))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000473C File Offset: 0x0000293C
		public bool method_35(List<GameObject> list_2, float float_0)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_15(list_2[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004788 File Offset: 0x00002988
		public override void vmethod_10()
		{
			this.method_29();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000479C File Offset: 0x0000299C
		public bool method_36(List<Transform> list_2, bool bool_4)
		{
			bool result;
			if (list_2.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_2.Count - 1; i >= 0; i--)
				{
					if (this.method_17(list_2[i], bool_4))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000047E8 File Offset: 0x000029E8
		internal void method_37()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.smethod_1447(typeof(VRC_Pickup), "Drop", GClass132.smethod_0("VRC_Pickup_Drop"), null, null);
		}

		// Token: 0x04000036 RID: 54
		public bool bool_0 = true;

		// Token: 0x04000037 RID: 55
		public List<GClass132.GStruct2> list_0 = new List<GClass132.GStruct2>();

		// Token: 0x04000038 RID: 56
		public bool bool_1 = false;

		// Token: 0x04000039 RID: 57
		public List<GClass132.GStruct3> list_1 = new List<GClass132.GStruct3>();

		// Token: 0x0400003A RID: 58
		public bool bool_2 = false;

		// Token: 0x0400003B RID: 59
		public bool bool_3 = false;

		// Token: 0x02000009 RID: 9
		public struct GStruct2
		{
			// Token: 0x060000C2 RID: 194 RVA: 0x00004844 File Offset: 0x00002A44
			public GStruct2(VRC_Pickup vrc_Pickup_1, float float_2)
			{
				this.vrc_Pickup_0 = vrc_Pickup_1;
				this.float_0 = float_2;
				this.float_1 = vrc_Pickup_1.proximity;
			}

			// Token: 0x0400003C RID: 60
			public VRC_Pickup vrc_Pickup_0;

			// Token: 0x0400003D RID: 61
			public float float_0;

			// Token: 0x0400003E RID: 62
			public float float_1;
		}

		// Token: 0x0200000A RID: 10
		public struct GStruct3
		{
			// Token: 0x060000C3 RID: 195 RVA: 0x0000486C File Offset: 0x00002A6C
			public GStruct3(VRC_Pickup vrc_Pickup_1, bool bool_2)
			{
				this.vrc_Pickup_0 = vrc_Pickup_1;
				this.bool_0 = bool_2;
				this.bool_1 = vrc_Pickup_1.DisallowTheft;
			}

			// Token: 0x0400003F RID: 63
			public VRC_Pickup vrc_Pickup_0;

			// Token: 0x04000040 RID: 64
			public bool bool_0;

			// Token: 0x04000041 RID: 65
			public bool bool_1;
		}
	}
}
