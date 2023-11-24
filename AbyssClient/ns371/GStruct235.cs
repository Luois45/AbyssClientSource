using System;

namespace ns371
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	public struct GStruct235 : IEquatable<GStruct235>, IComparable<GStruct235>
	{
		// Token: 0x060024E8 RID: 9448 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
		public bool vmethod_0(GStruct235 gstruct235_1)
		{
			return this.short_0 == gstruct235_1.short_0;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		public GStruct235(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x000AD6F0 File Offset: 0x000AB8F0
		public int vmethod_1()
		{
			return this.short_0.GetHashCode();
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x000AD70C File Offset: 0x000AB90C
		public static bool smethod_0(GStruct235 gstruct235_1, GStruct235 gstruct235_2)
		{
			return !GStruct235.smethod_2(gstruct235_1, gstruct235_2);
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x000AD724 File Offset: 0x000AB924
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x000AD738 File Offset: 0x000AB938
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct235 && GStruct235.smethod_2(this, (GStruct235)object_0);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x000AD764 File Offset: 0x000AB964
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000AD778 File Offset: 0x000AB978
		public static short smethod_1(GStruct235 gstruct235_1)
		{
			return gstruct235_1.short_0;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
		public static bool smethod_2(GStruct235 gstruct235_1, GStruct235 gstruct235_2)
		{
			return gstruct235_1.short_0 == gstruct235_2.short_0;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000AD7A8 File Offset: 0x000AB9A8
		public static GStruct235 smethod_3(short short_1)
		{
			return new GStruct235(short_1);
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000AD7C0 File Offset: 0x000AB9C0
		public int vmethod_4(GStruct235 gstruct235_1)
		{
			return this.short_0.CompareTo(gstruct235_1.short_0);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x000AD7E0 File Offset: 0x000AB9E0
		internal string method_1()
		{
			return this.short_0.ToString();
		}

		// Token: 0x04001347 RID: 4935
		public static readonly GStruct235 gstruct235_0 = new GStruct235(-1);

		// Token: 0x04001348 RID: 4936
		public short short_0;
	}
}
