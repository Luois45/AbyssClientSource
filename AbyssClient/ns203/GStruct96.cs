using System;

namespace ns203
{
	// Token: 0x02000149 RID: 329
	[Serializable]
	public struct GStruct96 : IEquatable<GStruct96>, IComparable<GStruct96>
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x0002FDF4 File Offset: 0x0002DFF4
		public int vmethod_0(GStruct96 gstruct96_1)
		{
			return this.ulong_0.CompareTo(gstruct96_1.ulong_0);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002FE14 File Offset: 0x0002E014
		public bool vmethod_1(object object_0)
		{
			return object_0 is GStruct96 && GStruct96.smethod_2(this, (GStruct96)object_0);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002FE40 File Offset: 0x0002E040
		public GStruct96(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002FE54 File Offset: 0x0002E054
		public int vmethod_2()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002FE70 File Offset: 0x0002E070
		public static ulong smethod_0(GStruct96 gstruct96_1)
		{
			return gstruct96_1.ulong_0;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002FE88 File Offset: 0x0002E088
		public static GStruct96 smethod_1(ulong ulong_1)
		{
			return new GStruct96(ulong_1);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		public static bool smethod_2(GStruct96 gstruct96_1, GStruct96 gstruct96_2)
		{
			return gstruct96_1.ulong_0 == gstruct96_2.ulong_0;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0002FF04 File Offset: 0x0002E104
		public static bool smethod_3(GStruct96 gstruct96_1, GStruct96 gstruct96_2)
		{
			return !GStruct96.smethod_2(gstruct96_1, gstruct96_2);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		public bool vmethod_4(GStruct96 gstruct96_1)
		{
			return this.ulong_0 == gstruct96_1.ulong_0;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0002FF1C File Offset: 0x0002E11C
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x040008E6 RID: 2278
		public static readonly GStruct96 gstruct96_0 = new GStruct96(ulong.MaxValue);

		// Token: 0x040008E7 RID: 2279
		public ulong ulong_0;
	}
}
