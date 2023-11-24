using System;

namespace ns35
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public struct GStruct16 : IEquatable<GStruct16>, IComparable<GStruct16>
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00005514 File Offset: 0x00003714
		public int vmethod_0(GStruct16 gstruct16_1)
		{
			return this.ulong_0.CompareTo(gstruct16_1.ulong_0);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005534 File Offset: 0x00003734
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00005548 File Offset: 0x00003748
		public static bool smethod_0(GStruct16 gstruct16_1, GStruct16 gstruct16_2)
		{
			return gstruct16_1.ulong_0 == gstruct16_2.ulong_0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005564 File Offset: 0x00003764
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005578 File Offset: 0x00003778
		public static GStruct16 smethod_1(ulong ulong_1)
		{
			return new GStruct16(ulong_1);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005590 File Offset: 0x00003790
		public static bool smethod_2(GStruct16 gstruct16_1, GStruct16 gstruct16_2)
		{
			return !GStruct16.smethod_0(gstruct16_1, gstruct16_2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005548 File Offset: 0x00003748
		public bool vmethod_2(GStruct16 gstruct16_1)
		{
			return this.ulong_0 == gstruct16_1.ulong_0;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000055A8 File Offset: 0x000037A8
		public static ulong smethod_3(GStruct16 gstruct16_1)
		{
			return gstruct16_1.ulong_0;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000055C0 File Offset: 0x000037C0
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct16 && GStruct16.smethod_0(this, (GStruct16)object_0);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000055EC File Offset: 0x000037EC
		public int vmethod_4()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005628 File Offset: 0x00003828
		public GStruct16(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000563C File Offset: 0x0000383C
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04000099 RID: 153
		public static readonly GStruct16 gstruct16_0 = new GStruct16(ulong.MaxValue);

		// Token: 0x0400009A RID: 154
		public ulong ulong_0;
	}
}
