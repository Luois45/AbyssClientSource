using System;
using System.Collections.Generic;
using ns241;
using ns425;

namespace ns447
{
	// Token: 0x020001A5 RID: 421
	public class GClass151 : GClass130
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x000547C8 File Offset: 0x000529C8
		internal void method_2(int int_1)
		{
			this.method_24(int_1);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000547DC File Offset: 0x000529DC
		internal void method_3()
		{
			this.method_25();
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000547F0 File Offset: 0x000529F0
		internal void method_4(int int_1, List<int> list_1)
		{
			int i;
			for (i = 0; i < GClass84.smethod_741(this.list_0.Count, list_1.Count); i++)
			{
				this.list_0[i] = list_1[i];
			}
			while (i < this.list_0.Count)
			{
				this.list_0[i] = 0;
				i++;
			}
			this.int_0 = int_1;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00054860 File Offset: 0x00052A60
		internal void method_5(int int_1, List<int> list_1)
		{
			this.method_14(int_1, list_1);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000548A0 File Offset: 0x00052AA0
		public float method_6(float float_0)
		{
			return float_0 * float_0 * float_0 * (float_0 * (float_0 * 6f - 15f) + 10f);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000548CC File Offset: 0x00052ACC
		internal float method_7(int int_1, float float_0, float float_1, float float_2)
		{
			int num = int_1 & 15;
			float num2 = GClass84.smethod_108<float>(num < 8, float_0, float_1);
			float num3 = GClass84.smethod_108<float>(num < 4, float_1, GClass84.smethod_108<float>(num == 12 || num == 14, float_0, float_2));
			return GClass84.smethod_108<float>((num & 1) == 0, num2, -num2) + GClass84.smethod_108<float>((num & 2) == 0, num3, -num3);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0005492C File Offset: 0x00052B2C
		internal float method_8(float float_0)
		{
			return this.method_21(float_0, 0f, 0f);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0005494C File Offset: 0x00052B4C
		internal float method_9(float float_0, float float_1, int int_1)
		{
			float num = 0f;
			float num2 = 1f;
			for (int i = 0; i < int_1; i++)
			{
				num += this.method_18(float_0, float_1) * num2;
				float_0 *= 2f;
				float_1 *= 2f;
				num2 *= 0.5f;
			}
			return num;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000549A0 File Offset: 0x00052BA0
		internal float method_10(float float_0)
		{
			return this.method_8(float_0) * 0.5f + 0.5f;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000549C4 File Offset: 0x00052BC4
		internal List<int> method_11()
		{
			List<int> list = new List<int>();
			list.AddRange(this.list_0);
			return list;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000549E8 File Offset: 0x00052BE8
		internal float method_12(float float_0, int int_1)
		{
			float num = 0f;
			float num2 = 1f;
			for (int i = 0; i < int_1; i++)
			{
				num += this.method_8(float_0) * num2;
				float_0 *= 2f;
				num2 *= 0.5f;
			}
			return num;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00054A34 File Offset: 0x00052C34
		internal float method_13(float float_0, float float_1, int int_1)
		{
			return this.method_9(float_0, float_1, int_1) * 0.5f + 0.5f;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00054A58 File Offset: 0x00052C58
		internal void method_14(int int_1, List<int> list_1)
		{
			this.method_4(int_1, list_1);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00054A70 File Offset: 0x00052C70
		internal float method_15(float float_0, float float_1)
		{
			return this.method_18(float_0, float_1) * 0.5f + 0.5f;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00054A94 File Offset: 0x00052C94
		internal float method_16(float float_0, float float_1, float float_2, int int_1)
		{
			return this.method_19(float_0, float_1, float_2, int_1) * 0.5f + 0.5f;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00054ABC File Offset: 0x00052CBC
		internal void method_17(int int_1)
		{
			for (int i = 0; i < 256; i++)
			{
				this.list_0[i] = GClass84.smethod_1673(256);
			}
			for (int j = 0; j < 256; j++)
			{
				this.list_0[256 + j] = this.list_0[j];
			}
			this.int_0 = int_1;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00054B28 File Offset: 0x00052D28
		internal float method_18(float float_0, float float_1)
		{
			return this.method_21(float_0, float_1, 0f);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00054B44 File Offset: 0x00052D44
		internal float method_19(float float_0, float float_1, float float_2, int int_1)
		{
			float num = 0f;
			float num2 = 1f;
			for (int i = 0; i < int_1; i++)
			{
				num += this.method_21(float_0, float_1, float_2) * num2;
				float_0 *= 2f;
				float_1 *= 2f;
				float_2 *= 2f;
				num2 *= 0.5f;
			}
			return num;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00054BA4 File Offset: 0x00052DA4
		internal float method_20(float float_0, float float_1, float float_2)
		{
			return this.method_21(float_0, float_1, float_2) * 0.5f + 0.5f;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00054BC8 File Offset: 0x00052DC8
		internal float method_21(float float_0, float float_1, float float_2)
		{
			int num = (int)float_0 & 255;
			int num2 = (int)float_1 & 255;
			int num3 = (int)float_2 & 255;
			float_0 -= (float)this.method_23(float_0);
			float_1 -= (float)this.method_23(float_1);
			float_2 -= (float)this.method_23(float_2);
			float float_3 = this.method_6(float_0);
			float float_4 = this.method_6(float_1);
			float float_5 = this.method_6(float_2);
			int num4 = this.list_0[num] + num2;
			int num5 = this.list_0[num4] + num3;
			int num6 = this.list_0[num4 + 1] + num3;
			int num7 = this.list_0[num + 1] + num2;
			int num8 = this.list_0[num7] + num3;
			int num9 = this.list_0[num7 + 1] + num3;
			return GClass84.smethod_802(float_5, GClass84.smethod_802(float_4, GClass84.smethod_802(float_3, this.method_7(this.list_0[num5], float_0, float_1, float_2), this.method_7(this.list_0[num8], float_0 - 1f, float_1, float_2)), GClass84.smethod_802(float_3, this.method_7(this.list_0[num6], float_0, float_1 - 1f, float_2), this.method_7(this.list_0[num9], float_0 - 1f, float_1 - 1f, float_2))), GClass84.smethod_802(float_4, GClass84.smethod_802(float_3, this.method_7(this.list_0[num5 + 1], float_0, float_1, float_2 - 1f), this.method_7(this.list_0[num8 + 1], float_0 - 1f, float_1, float_2 - 1f)), GClass84.smethod_802(float_3, this.method_7(this.list_0[num6 + 1], float_0, float_1 - 1f, float_2 - 1f), this.method_7(this.list_0[num9 + 1], float_0 - 1f, float_1 - 1f, float_2 - 1f))));
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00054DCC File Offset: 0x00052FCC
		internal float method_22(float float_0, int int_1)
		{
			return this.method_12(float_0, int_1) * 0.5f + 0.5f;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00054DF0 File Offset: 0x00052FF0
		internal int method_23(float float_0)
		{
			int result;
			if ((float)((int)float_0) > float_0)
			{
				result = (int)float_0 - 1;
			}
			else
			{
				result = (int)float_0;
			}
			return result;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00054E10 File Offset: 0x00053010
		public override void vmethod_23()
		{
			this.method_3();
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00054E24 File Offset: 0x00053024
		internal void method_24(int int_1)
		{
			this.method_17(int_1);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00054E38 File Offset: 0x00053038
		internal void method_25()
		{
			this.list_0.Clear();
			for (int i = 0; i < 512; i++)
			{
				this.list_0.Add(0);
			}
		}

		// Token: 0x04000BBA RID: 3002
		internal List<int> list_0 = new List<int>();

		// Token: 0x04000BBB RID: 3003
		internal int int_0 = 0;
	}
}
