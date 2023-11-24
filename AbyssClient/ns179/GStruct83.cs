using System;

namespace ns179
{
	// Token: 0x02000122 RID: 290
	[Serializable]
	public struct GStruct83 : IEquatable<GStruct83>, IComparable<GStruct83>
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00028FB8 File Offset: 0x000271B8
		public int vmethod_0(GStruct83 gstruct83_0)
		{
			return this.ulong_0.CompareTo(gstruct83_0.ulong_0);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00028FD8 File Offset: 0x000271D8
		public static GStruct83 smethod_0(ulong ulong_1)
		{
			return new GStruct83(ulong_1);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00028FF0 File Offset: 0x000271F0
		public static ulong smethod_1(GStruct83 gstruct83_0)
		{
			return gstruct83_0.ulong_0;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00029008 File Offset: 0x00027208
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002901C File Offset: 0x0002721C
		public GStruct83(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00029030 File Offset: 0x00027230
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00029044 File Offset: 0x00027244
		public static bool smethod_2(GStruct83 gstruct83_0, GStruct83 gstruct83_1)
		{
			return gstruct83_0.ulong_0 == gstruct83_1.ulong_0;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00029060 File Offset: 0x00027260
		public static bool smethod_3(GStruct83 gstruct83_0, GStruct83 gstruct83_1)
		{
			return !GStruct83.smethod_2(gstruct83_0, gstruct83_1);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00029044 File Offset: 0x00027244
		public bool vmethod_2(GStruct83 gstruct83_0)
		{
			return this.ulong_0 == gstruct83_0.ulong_0;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00029078 File Offset: 0x00027278
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct83 && GStruct83.smethod_2(this, (GStruct83)object_0);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000290A4 File Offset: 0x000272A4
		public int vmethod_4()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000290C0 File Offset: 0x000272C0
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04000733 RID: 1843
		public ulong ulong_0;
	}
}
