using System;

namespace ns118
{
	// Token: 0x020000BB RID: 187
	[Serializable]
	public struct GStruct43 : IEquatable<GStruct43>, IComparable<GStruct43>
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x00019020 File Offset: 0x00017220
		public int vmethod_0(GStruct43 gstruct43_1)
		{
			return this.uint_0.CompareTo(gstruct43_1.uint_0);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00019040 File Offset: 0x00017240
		public GStruct43(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00019054 File Offset: 0x00017254
		public static GStruct43 smethod_0(uint uint_1)
		{
			return new GStruct43(uint_1);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001906C File Offset: 0x0001726C
		public bool vmethod_1(GStruct43 gstruct43_1)
		{
			return this.uint_0 == gstruct43_1.uint_0;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00019088 File Offset: 0x00017288
		public static uint smethod_1(GStruct43 gstruct43_1)
		{
			return gstruct43_1.uint_0;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001906C File Offset: 0x0001726C
		public static bool smethod_2(GStruct43 gstruct43_1, GStruct43 gstruct43_2)
		{
			return gstruct43_1.uint_0 == gstruct43_2.uint_0;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000190B8 File Offset: 0x000172B8
		public string vmethod_2()
		{
			return this.method_0();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000190CC File Offset: 0x000172CC
		public static bool smethod_3(GStruct43 gstruct43_1, GStruct43 gstruct43_2)
		{
			return !GStruct43.smethod_2(gstruct43_1, gstruct43_2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000190E4 File Offset: 0x000172E4
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000190F8 File Offset: 0x000172F8
		public int vmethod_3()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00019114 File Offset: 0x00017314
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct43 && GStruct43.smethod_2(this, (GStruct43)object_0);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00019140 File Offset: 0x00017340
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x040004C0 RID: 1216
		public static readonly GStruct43 gstruct43_0 = new GStruct43(0U);

		// Token: 0x040004C1 RID: 1217
		public uint uint_0;
	}
}
