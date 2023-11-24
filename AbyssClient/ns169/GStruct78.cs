using System;

namespace ns169
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public struct GStruct78 : IEquatable<GStruct78>, IComparable<GStruct78>
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00022BB4 File Offset: 0x00020DB4
		public static GStruct78 smethod_0(ulong ulong_1)
		{
			return new GStruct78(ulong_1);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00022BEC File Offset: 0x00020DEC
		public int vmethod_0()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00022C08 File Offset: 0x00020E08
		public GStruct78(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00022C1C File Offset: 0x00020E1C
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00022C30 File Offset: 0x00020E30
		public static bool smethod_1(GStruct78 gstruct78_1, GStruct78 gstruct78_2)
		{
			return gstruct78_1.ulong_0 == gstruct78_2.ulong_0;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00022C4C File Offset: 0x00020E4C
		public static ulong smethod_2(GStruct78 gstruct78_1)
		{
			return gstruct78_1.ulong_0;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00022C30 File Offset: 0x00020E30
		public bool vmethod_2(GStruct78 gstruct78_1)
		{
			return this.ulong_0 == gstruct78_1.ulong_0;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00022C64 File Offset: 0x00020E64
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00022C78 File Offset: 0x00020E78
		public int vmethod_3(GStruct78 gstruct78_1)
		{
			return this.ulong_0.CompareTo(gstruct78_1.ulong_0);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00022C98 File Offset: 0x00020E98
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct78 && GStruct78.smethod_1(this, (GStruct78)object_0);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00022CC4 File Offset: 0x00020EC4
		public static bool smethod_3(GStruct78 gstruct78_1, GStruct78 gstruct78_2)
		{
			return !GStruct78.smethod_1(gstruct78_1, gstruct78_2);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00022CDC File Offset: 0x00020EDC
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x040006A8 RID: 1704
		public static readonly GStruct78 gstruct78_0 = new GStruct78(0UL);

		// Token: 0x040006A9 RID: 1705
		public ulong ulong_0;
	}
}
