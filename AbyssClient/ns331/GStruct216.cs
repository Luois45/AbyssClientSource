using System;

namespace ns331
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public struct GStruct216 : IEquatable<GStruct216>, IComparable<GStruct216>
	{
		// Token: 0x06001DD8 RID: 7640 RVA: 0x00093FE0 File Offset: 0x000921E0
		public int vmethod_0(GStruct216 gstruct216_0)
		{
			return this.uint_0.CompareTo(gstruct216_0.uint_0);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00094000 File Offset: 0x00092200
		public static bool smethod_0(GStruct216 gstruct216_0, GStruct216 gstruct216_1)
		{
			return gstruct216_0.uint_0 == gstruct216_1.uint_0;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0009401C File Offset: 0x0009221C
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00094000 File Offset: 0x00092200
		public bool vmethod_2(GStruct216 gstruct216_0)
		{
			return this.uint_0 == gstruct216_0.uint_0;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00094030 File Offset: 0x00092230
		public static uint smethod_1(GStruct216 gstruct216_0)
		{
			return gstruct216_0.uint_0;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00094048 File Offset: 0x00092248
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0009405C File Offset: 0x0009225C
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct216 && GStruct216.smethod_0(this, (GStruct216)object_0);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00094088 File Offset: 0x00092288
		public int vmethod_4()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000940A4 File Offset: 0x000922A4
		public static bool smethod_2(GStruct216 gstruct216_0, GStruct216 gstruct216_1)
		{
			return !GStruct216.smethod_0(gstruct216_0, gstruct216_1);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000940BC File Offset: 0x000922BC
		public GStruct216(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000940D0 File Offset: 0x000922D0
		public static GStruct216 smethod_3(uint uint_1)
		{
			return new GStruct216(uint_1);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000940E8 File Offset: 0x000922E8
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x040011B2 RID: 4530
		public uint uint_0;
	}
}
