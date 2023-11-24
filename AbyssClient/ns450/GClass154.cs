using System;
using System.Collections.Generic;
using ns241;
using ns425;
using ns447;
using UnityEngine;

namespace ns450
{
	// Token: 0x02000242 RID: 578
	public class GClass154 : GClass130
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00088B24 File Offset: 0x00086D24
		internal void method_2(int int_7, List<int> list_7)
		{
			this.method_17(int_7, list_7);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00088B3C File Offset: 0x00086D3C
		internal List<Color> method_3()
		{
			Color item = default(Color);
			int num = 0;
			List<Color> result;
			if (this.gclass151_0 == null)
			{
				result = this.list_2;
			}
			else if (this.list_1.Count == this.int_1)
			{
				result = this.list_1;
			}
			else
			{
				if (this.gclass151_0.int_0 != this.int_0)
				{
					this.gclass151_0.method_5(this.int_0, this.method_14());
				}
				item.a = 255f;
				for (int i = this.list_1.Count; i < this.int_1; i++)
				{
					float num2 = this.gclass151_0.method_22((float)i / this.float_1, this.int_4);
					int num3 = (int)GClass84.smethod_910(num2, 1f);
					item.r = (float)num3;
					item.g = (float)num3;
					item.b = (float)num3;
					this.list_1.Add(item);
					if (this.int_6 > 0)
					{
						num++;
						if (num >= this.int_6)
						{
							return this.list_2;
						}
					}
				}
				result = this.list_2;
			}
			return result;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00088C70 File Offset: 0x00086E70
		internal void method_4(int int_7, float float_4, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14)
		{
			this.method_12(int_7, float_4, int_8, int_9, int_10, int_11, int_12, int_13, int_14);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00088D68 File Offset: 0x00086F68
		internal void method_5(int int_7)
		{
			this.int_5 = int_7;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00088D7C File Offset: 0x00086F7C
		internal List<GClass84.GStruct161> method_6()
		{
			int num = 0;
			List<GClass84.GStruct161> result;
			if (this.gclass151_0 == null)
			{
				result = this.list_6;
			}
			else if (this.list_5.Count == this.int_3)
			{
				result = this.list_5;
			}
			else
			{
				if (this.gclass151_0.int_0 != this.int_0)
				{
					this.gclass151_0.method_5(this.int_0, this.method_14());
				}
				Color item;
				item..ctor(0f, 0f, 0f, 1f);
				for (int i = this.list_5.Count; i < this.int_3; i++)
				{
					float num2 = (float)i / this.float_3;
					List<GClass84.GStruct160> list = new List<GClass84.GStruct160>(this.int_2);
					for (int j = 0; j < this.int_2; j++)
					{
						float num3 = (float)j / this.float_2;
						List<Color> list2 = new List<Color>();
						for (int k = 0; k < this.int_1; k++)
						{
							float num4 = this.gclass151_0.method_16((float)k / this.float_1, num3, num2, this.int_4);
							int num5 = (int)GClass84.smethod_910(num4, 1f);
							item.r = (float)num5;
							item.g = (float)num5;
							item.b = (float)num5;
							list2.Add(item);
						}
						list.Add(new GClass84.GStruct160(list2));
					}
					this.list_5.Add(new GClass84.GStruct161(list));
					if (this.int_6 > 0)
					{
						num++;
						if (num >= this.int_6)
						{
							return this.list_6;
						}
					}
				}
				result = this.list_6;
			}
			return result;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00088F3C File Offset: 0x0008713C
		internal void method_7()
		{
			this.method_13();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00088F50 File Offset: 0x00087150
		internal List<GClass84.GStruct160> method_8()
		{
			Color value = default(Color);
			int num = 0;
			List<GClass84.GStruct160> result;
			if (this.gclass151_0 == null)
			{
				result = this.list_4;
			}
			else if (this.list_3.Count == this.int_2)
			{
				result = this.list_3;
			}
			else
			{
				if (this.gclass151_0.int_0 != this.int_0)
				{
					this.gclass151_0.method_5(this.int_0, this.method_14());
				}
				value.a = 255f;
				for (int i = this.list_3.Count; i < this.int_2; i++)
				{
					float num2 = (float)i / this.float_2;
					List<Color> list = new List<Color>(this.int_1);
					for (int j = 0; j < this.int_1; j++)
					{
						float num3 = this.gclass151_0.method_13((float)j / this.float_1, num2, this.int_4);
						int num4 = (int)GClass84.smethod_910(num3, 1f);
						value.r = (float)num4;
						value.g = (float)num4;
						value.b = (float)num4;
						list[j] = value;
					}
					this.list_3.Add(new GClass84.GStruct160(list));
					if (this.int_6 > 0)
					{
						num++;
						if (num >= this.int_6)
						{
							return this.list_4;
						}
					}
				}
				result = this.list_4;
			}
			return result;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000890C8 File Offset: 0x000872C8
		internal void method_9()
		{
			this.method_20();
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000890DC File Offset: 0x000872DC
		internal void method_10(int int_7, List<int> list_7)
		{
			this.method_2(int_7, list_7);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x000890F4 File Offset: 0x000872F4
		internal void method_11(int int_7, float float_4, int int_8, int int_9, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0)
		{
			this.method_4(int_7, float_4, int_8, int_9, int_10, int_11, int_12, int_13, int_14);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00089124 File Offset: 0x00087324
		internal void method_12(int int_7, float float_4, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14)
		{
			this.float_0 = float_4;
			this.int_4 = int_8;
			this.int_1 = int_9;
			this.int_2 = int_10;
			this.int_3 = int_11;
			int_12 = GClass84.smethod_108<int>(int_12 <= 0, int_9, int_12);
			int_13 = GClass84.smethod_108<int>(int_13 <= 0, int_9, int_13);
			int_14 = GClass84.smethod_108<int>(int_14 <= 0, int_9, int_14);
			this.float_1 = (float)int_12 / this.float_0;
			this.float_2 = (float)int_13 / this.float_0;
			this.float_3 = (float)int_14 / this.float_0;
			this.int_6 = this.method_19();
			if (this.gclass151_0 == null)
			{
				this.gclass151_0 = new GClass151();
				this.vmethod_4(this.gclass151_0);
				if (this.gclass151_0 != null)
				{
					this.gclass151_0.method_2(int_7);
					this.method_10(int_7, this.gclass151_0.method_11());
					this.method_7();
				}
			}
			if (int_7 != this.int_0 && this.gclass151_0 != null)
			{
				this.gclass151_0.method_2(int_7);
				this.method_10(int_7, this.gclass151_0.method_11());
				this.method_7();
			}
			this.int_0 = int_7;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00089264 File Offset: 0x00087464
		internal void method_13()
		{
			this.method_16();
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00089278 File Offset: 0x00087478
		internal List<int> method_14()
		{
			List<int> list = new List<int>();
			list.AddRange(this.list_0);
			return list;
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0008929C File Offset: 0x0008749C
		internal void method_15(int int_7)
		{
			this.method_5(int_7);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000892B0 File Offset: 0x000874B0
		public override void vmethod_23()
		{
			this.method_9();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000892C4 File Offset: 0x000874C4
		internal void method_16()
		{
			this.list_1.Clear();
			this.list_3.Clear();
			this.list_5.Clear();
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000892F4 File Offset: 0x000874F4
		internal void method_17(int int_7, List<int> list_7)
		{
			int i;
			for (i = 0; i < GClass84.smethod_741(this.list_0.Count, list_7.Count); i++)
			{
				this.list_0[i] = list_7[i];
			}
			while (i < this.list_0.Count)
			{
				this.list_0[i] = 0;
				i++;
			}
			this.int_0 = int_7;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00089364 File Offset: 0x00087564
		internal void method_18(int int_7)
		{
			this.method_15(int_7);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00089378 File Offset: 0x00087578
		internal int method_19()
		{
			int num = 0;
			int i = 0;
			int result;
			if (this.int_5 <= 0)
			{
				result = 0;
			}
			else
			{
				if (this.int_1 > 0)
				{
					num = this.int_1;
					i++;
					if (this.int_2 > 0)
					{
						num *= this.int_2;
						i++;
						if (this.int_3 > 0)
						{
							num *= this.int_3;
							i++;
						}
					}
				}
				if (num > this.int_5)
				{
					if (i == 3)
					{
						i = num / this.int_3;
						int num2 = i;
						num = 1;
						int num3 = 1;
						while (i < this.int_5)
						{
							num = num3;
							i += num2;
							num3++;
						}
						result = num;
					}
					else if (i == 2)
					{
						i = num / this.int_2;
						int num4 = i;
						num = 1;
						int num5 = 1;
						while (i < this.int_5)
						{
							num = num5;
							i += num4;
							num5++;
						}
						result = num;
					}
					else
					{
						result = this.int_5;
					}
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00089468 File Offset: 0x00087668
		internal void method_20()
		{
			this.list_0.Clear();
			for (int i = 0; i < 512; i++)
			{
				this.list_0.Add(0);
			}
		}

		// Token: 0x04000F5A RID: 3930
		internal List<int> list_0 = new List<int>();

		// Token: 0x04000F5B RID: 3931
		internal List<Color> list_1 = new List<Color>();

		// Token: 0x04000F5C RID: 3932
		internal List<Color> list_2 = new List<Color>();

		// Token: 0x04000F5D RID: 3933
		internal List<GClass84.GStruct160> list_3 = new List<GClass84.GStruct160>();

		// Token: 0x04000F5E RID: 3934
		internal List<GClass84.GStruct160> list_4 = new List<GClass84.GStruct160>();

		// Token: 0x04000F5F RID: 3935
		internal List<GClass84.GStruct161> list_5 = new List<GClass84.GStruct161>();

		// Token: 0x04000F60 RID: 3936
		internal List<GClass84.GStruct161> list_6 = new List<GClass84.GStruct161>();

		// Token: 0x04000F61 RID: 3937
		internal int int_0 = 0;

		// Token: 0x04000F62 RID: 3938
		internal int int_1 = 0;

		// Token: 0x04000F63 RID: 3939
		internal int int_2 = 0;

		// Token: 0x04000F64 RID: 3940
		internal int int_3 = 0;

		// Token: 0x04000F65 RID: 3941
		internal float float_0 = 0f;

		// Token: 0x04000F66 RID: 3942
		internal float float_1 = 0f;

		// Token: 0x04000F67 RID: 3943
		internal float float_2 = 0f;

		// Token: 0x04000F68 RID: 3944
		internal float float_3 = 0f;

		// Token: 0x04000F69 RID: 3945
		internal int int_4 = 0;

		// Token: 0x04000F6A RID: 3946
		internal GClass151 gclass151_0 = null;

		// Token: 0x04000F6B RID: 3947
		internal int int_5 = 5000;

		// Token: 0x04000F6C RID: 3948
		internal int int_6 = 0;
	}
}
