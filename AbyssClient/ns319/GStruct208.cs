using System;

namespace ns319
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public struct GStruct208 : IEquatable<GStruct208>, IComparable<GStruct208>
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00093510 File Offset: 0x00091710
		public static bool smethod_0(GStruct208 gstruct208_0, GStruct208 gstruct208_1)
		{
			return !GStruct208.smethod_2(gstruct208_0, gstruct208_1);
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00093528 File Offset: 0x00091728
		public static GStruct208 smethod_1(uint uint_1)
		{
			return new GStruct208(uint_1);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00093540 File Offset: 0x00091740
		public int vmethod_0(GStruct208 gstruct208_0)
		{
			return this.uint_0.CompareTo(gstruct208_0.uint_0);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00093560 File Offset: 0x00091760
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00093574 File Offset: 0x00091774
		public bool vmethod_1(GStruct208 gstruct208_0)
		{
			return this.uint_0 == gstruct208_0.uint_0;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00093590 File Offset: 0x00091790
		public int vmethod_2()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00093574 File Offset: 0x00091774
		public static bool smethod_2(GStruct208 gstruct208_0, GStruct208 gstruct208_1)
		{
			return gstruct208_0.uint_0 == gstruct208_1.uint_0;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000935AC File Offset: 0x000917AC
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct208 && GStruct208.smethod_2(this, (GStruct208)object_0);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000935D8 File Offset: 0x000917D8
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000935EC File Offset: 0x000917EC
		public static uint smethod_3(GStruct208 gstruct208_0)
		{
			return gstruct208_0.uint_0;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00093604 File Offset: 0x00091804
		public GStruct208(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00093618 File Offset: 0x00091818
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x0400118E RID: 4494
		public uint uint_0;
	}
}
