using System;

namespace ns50
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public struct GStruct20 : IEquatable<GStruct20>, IComparable<GStruct20>
	{
		// Token: 0x06000230 RID: 560 RVA: 0x00007300 File Offset: 0x00005500
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007314 File Offset: 0x00005514
		public int vmethod_1(GStruct20 gstruct20_0)
		{
			return this.ulong_0.CompareTo(gstruct20_0.ulong_0);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007334 File Offset: 0x00005534
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct20 && GStruct20.smethod_2(this, (GStruct20)object_0);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007360 File Offset: 0x00005560
		public static bool smethod_0(GStruct20 gstruct20_0, GStruct20 gstruct20_1)
		{
			return !GStruct20.smethod_2(gstruct20_0, gstruct20_1);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007378 File Offset: 0x00005578
		public bool vmethod_3(GStruct20 gstruct20_0)
		{
			return this.ulong_0 == gstruct20_0.ulong_0;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007394 File Offset: 0x00005594
		public static GStruct20 smethod_1(ulong ulong_1)
		{
			return new GStruct20(ulong_1);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007378 File Offset: 0x00005578
		public static bool smethod_2(GStruct20 gstruct20_0, GStruct20 gstruct20_1)
		{
			return gstruct20_0.ulong_0 == gstruct20_1.ulong_0;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000073AC File Offset: 0x000055AC
		public int vmethod_4()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000073C8 File Offset: 0x000055C8
		public GStruct20(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000073DC File Offset: 0x000055DC
		public static ulong smethod_3(GStruct20 gstruct20_0)
		{
			return gstruct20_0.ulong_0;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000073F4 File Offset: 0x000055F4
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00007408 File Offset: 0x00005608
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x040000ED RID: 237
		public ulong ulong_0;
	}
}
