using System;

namespace ns236
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public struct GStruct128 : IEquatable<GStruct128>, IComparable<GStruct128>
	{
		// Token: 0x0600106B RID: 4203 RVA: 0x000571AC File Offset: 0x000553AC
		public static GStruct128 smethod_0(int int_1)
		{
			return new GStruct128(int_1);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000571C4 File Offset: 0x000553C4
		public bool vmethod_0(GStruct128 gstruct128_0)
		{
			return this.int_0 == gstruct128_0.int_0;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000571E0 File Offset: 0x000553E0
		public int vmethod_1(GStruct128 gstruct128_0)
		{
			return this.int_0.CompareTo(gstruct128_0.int_0);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00057200 File Offset: 0x00055400
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct128 && GStruct128.smethod_2(this, (GStruct128)object_0);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005722C File Offset: 0x0005542C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00057240 File Offset: 0x00055440
		public static int smethod_1(GStruct128 gstruct128_0)
		{
			return gstruct128_0.int_0;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00057258 File Offset: 0x00055458
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000571C4 File Offset: 0x000553C4
		public static bool smethod_2(GStruct128 gstruct128_0, GStruct128 gstruct128_1)
		{
			return gstruct128_0.int_0 == gstruct128_1.int_0;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005726C File Offset: 0x0005546C
		public GStruct128(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00057280 File Offset: 0x00055480
		public int vmethod_4()
		{
			return this.int_0.GetHashCode();
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005729C File Offset: 0x0005549C
		public static bool smethod_3(GStruct128 gstruct128_0, GStruct128 gstruct128_1)
		{
			return !GStruct128.smethod_2(gstruct128_0, gstruct128_1);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x000572B4 File Offset: 0x000554B4
		internal string method_1()
		{
			return this.int_0.ToString();
		}

		// Token: 0x04000C24 RID: 3108
		public int int_0;
	}
}
