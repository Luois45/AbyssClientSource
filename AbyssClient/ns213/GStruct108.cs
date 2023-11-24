using System;

namespace ns213
{
	// Token: 0x02000185 RID: 389
	[Serializable]
	public struct GStruct108 : IEquatable<GStruct108>, IComparable<GStruct108>
	{
		// Token: 0x06000F33 RID: 3891 RVA: 0x00050618 File Offset: 0x0004E818
		public bool vmethod_0(object object_0)
		{
			return object_0 is GStruct108 && GStruct108.smethod_2(this, (GStruct108)object_0);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00050644 File Offset: 0x0004E844
		public static GStruct108 smethod_0(uint uint_1)
		{
			return new GStruct108(uint_1);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0005065C File Offset: 0x0004E85C
		public int vmethod_1(GStruct108 gstruct108_1)
		{
			return this.uint_0.CompareTo(gstruct108_1.uint_0);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0005067C File Offset: 0x0004E87C
		public static bool smethod_1(GStruct108 gstruct108_1, GStruct108 gstruct108_2)
		{
			return !GStruct108.smethod_2(gstruct108_1, gstruct108_2);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00050694 File Offset: 0x0004E894
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000506A8 File Offset: 0x0004E8A8
		public GStruct108(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000506BC File Offset: 0x0004E8BC
		public static bool smethod_2(GStruct108 gstruct108_1, GStruct108 gstruct108_2)
		{
			return gstruct108_1.uint_0 == gstruct108_2.uint_0;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000506BC File Offset: 0x0004E8BC
		public bool vmethod_2(GStruct108 gstruct108_1)
		{
			return this.uint_0 == gstruct108_1.uint_0;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000506D8 File Offset: 0x0004E8D8
		public int vmethod_3()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000506F4 File Offset: 0x0004E8F4
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00050708 File Offset: 0x0004E908
		public static uint smethod_3(GStruct108 gstruct108_1)
		{
			return gstruct108_1.uint_0;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00050738 File Offset: 0x0004E938
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04000AE2 RID: 2786
		public static readonly GStruct108 gstruct108_0 = new GStruct108(0U);

		// Token: 0x04000AE3 RID: 2787
		public uint uint_0;
	}
}
