using System;

namespace ns22
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public struct GStruct7 : IEquatable<GStruct7>, IComparable<GStruct7>
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00005018 File Offset: 0x00003218
		public static bool smethod_0(GStruct7 gstruct7_1, GStruct7 gstruct7_2)
		{
			return !GStruct7.smethod_1(gstruct7_1, gstruct7_2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005030 File Offset: 0x00003230
		public bool vmethod_0(GStruct7 gstruct7_1)
		{
			return this.ulong_0 == gstruct7_1.ulong_0;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000504C File Offset: 0x0000324C
		public int vmethod_1(GStruct7 gstruct7_1)
		{
			return this.ulong_0.CompareTo(gstruct7_1.ulong_0);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005030 File Offset: 0x00003230
		public static bool smethod_1(GStruct7 gstruct7_1, GStruct7 gstruct7_2)
		{
			return gstruct7_1.ulong_0 == gstruct7_2.ulong_0;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000506C File Offset: 0x0000326C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000050A0 File Offset: 0x000032A0
		public int vmethod_2()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000050BC File Offset: 0x000032BC
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000050D0 File Offset: 0x000032D0
		public GStruct7(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000050E4 File Offset: 0x000032E4
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct7 && GStruct7.smethod_1(this, (GStruct7)object_0);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005110 File Offset: 0x00003310
		public static ulong smethod_2(GStruct7 gstruct7_1)
		{
			return gstruct7_1.ulong_0;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005128 File Offset: 0x00003328
		public static GStruct7 smethod_3(ulong ulong_1)
		{
			return new GStruct7(ulong_1);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005140 File Offset: 0x00003340
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x0400006C RID: 108
		public static readonly GStruct7 gstruct7_0 = new GStruct7(ulong.MaxValue);

		// Token: 0x0400006D RID: 109
		public ulong ulong_0;
	}
}
