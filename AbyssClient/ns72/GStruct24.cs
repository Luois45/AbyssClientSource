using System;

namespace ns72
{
	// Token: 0x02000050 RID: 80
	[Serializable]
	public struct GStruct24 : IEquatable<GStruct24>, IComparable<GStruct24>
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00008498 File Offset: 0x00006698
		public int vmethod_0(GStruct24 gstruct24_1)
		{
			return this.ulong_0.CompareTo(gstruct24_1.ulong_0);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000084D8 File Offset: 0x000066D8
		public static ulong smethod_0(GStruct24 gstruct24_1)
		{
			return gstruct24_1.ulong_0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000084F0 File Offset: 0x000066F0
		public GStruct24(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008504 File Offset: 0x00006704
		public static bool smethod_1(GStruct24 gstruct24_1, GStruct24 gstruct24_2)
		{
			return gstruct24_1.ulong_0 == gstruct24_2.ulong_0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00008520 File Offset: 0x00006720
		public int vmethod_1()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00008504 File Offset: 0x00006704
		public bool vmethod_2(GStruct24 gstruct24_1)
		{
			return this.ulong_0 == gstruct24_1.ulong_0;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000853C File Offset: 0x0000673C
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00008550 File Offset: 0x00006750
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct24 && GStruct24.smethod_1(this, (GStruct24)object_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000857C File Offset: 0x0000677C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008590 File Offset: 0x00006790
		public static GStruct24 smethod_2(ulong ulong_1)
		{
			return new GStruct24(ulong_1);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000085A8 File Offset: 0x000067A8
		public static bool smethod_3(GStruct24 gstruct24_1, GStruct24 gstruct24_2)
		{
			return !GStruct24.smethod_1(gstruct24_1, gstruct24_2);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000085C0 File Offset: 0x000067C0
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04000131 RID: 305
		public static readonly GStruct24 gstruct24_0 = new GStruct24(ulong.MaxValue);

		// Token: 0x04000132 RID: 306
		public ulong ulong_0;
	}
}
