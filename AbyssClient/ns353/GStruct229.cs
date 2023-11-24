using System;

namespace ns353
{
	// Token: 0x020002BA RID: 698
	[Serializable]
	public struct GStruct229 : IEquatable<GStruct229>, IComparable<GStruct229>
	{
		// Token: 0x06002033 RID: 8243 RVA: 0x000A52CC File Offset: 0x000A34CC
		public static uint smethod_0(GStruct229 gstruct229_0)
		{
			return gstruct229_0.uint_0;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000A52E4 File Offset: 0x000A34E4
		public GStruct229(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000A52F8 File Offset: 0x000A34F8
		public int vmethod_0(GStruct229 gstruct229_0)
		{
			return this.uint_0.CompareTo(gstruct229_0.uint_0);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000A5318 File Offset: 0x000A3518
		public bool vmethod_1(object object_0)
		{
			return object_0 is GStruct229 && GStruct229.smethod_3(this, (GStruct229)object_0);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000A5344 File Offset: 0x000A3544
		public string vmethod_2()
		{
			return this.method_0();
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000A5358 File Offset: 0x000A3558
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000A536C File Offset: 0x000A356C
		public bool vmethod_3(GStruct229 gstruct229_0)
		{
			return this.uint_0 == gstruct229_0.uint_0;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000A5388 File Offset: 0x000A3588
		public static GStruct229 smethod_1(uint uint_1)
		{
			return new GStruct229(uint_1);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x000A53A0 File Offset: 0x000A35A0
		public static bool smethod_2(GStruct229 gstruct229_0, GStruct229 gstruct229_1)
		{
			return !GStruct229.smethod_3(gstruct229_0, gstruct229_1);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000A53B8 File Offset: 0x000A35B8
		public int vmethod_4()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000A536C File Offset: 0x000A356C
		public static bool smethod_3(GStruct229 gstruct229_0, GStruct229 gstruct229_1)
		{
			return gstruct229_0.uint_0 == gstruct229_1.uint_0;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000A53D4 File Offset: 0x000A35D4
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04001296 RID: 4758
		public uint uint_0;
	}
}
