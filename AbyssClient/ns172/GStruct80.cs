using System;

namespace ns172
{
	// Token: 0x02000117 RID: 279
	[Serializable]
	public struct GStruct80 : IEquatable<GStruct80>, IComparable<GStruct80>
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x0002332C File Offset: 0x0002152C
		public GStruct80(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00023340 File Offset: 0x00021540
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00023374 File Offset: 0x00021574
		public bool vmethod_1(GStruct80 gstruct80_1)
		{
			return this.ulong_0 == gstruct80_1.ulong_0;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00023374 File Offset: 0x00021574
		public static bool smethod_0(GStruct80 gstruct80_1, GStruct80 gstruct80_2)
		{
			return gstruct80_1.ulong_0 == gstruct80_2.ulong_0;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00023390 File Offset: 0x00021590
		public static ulong smethod_1(GStruct80 gstruct80_1)
		{
			return gstruct80_1.ulong_0;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000233A8 File Offset: 0x000215A8
		public static bool smethod_2(GStruct80 gstruct80_1, GStruct80 gstruct80_2)
		{
			return !GStruct80.smethod_0(gstruct80_1, gstruct80_2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000233C0 File Offset: 0x000215C0
		public int vmethod_2(GStruct80 gstruct80_1)
		{
			return this.ulong_0.CompareTo(gstruct80_1.ulong_0);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000233E0 File Offset: 0x000215E0
		public int vmethod_3()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000233FC File Offset: 0x000215FC
		public static GStruct80 smethod_3(ulong ulong_1)
		{
			return new GStruct80(ulong_1);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00023414 File Offset: 0x00021614
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct80 && GStruct80.smethod_0(this, (GStruct80)object_0);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00023440 File Offset: 0x00021640
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00023454 File Offset: 0x00021654
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x040006B3 RID: 1715
		public static readonly GStruct80 gstruct80_0 = new GStruct80(0UL);

		// Token: 0x040006B4 RID: 1716
		public ulong ulong_0;
	}
}
