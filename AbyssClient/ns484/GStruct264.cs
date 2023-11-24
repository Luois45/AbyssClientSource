using System;

namespace ns484
{
	// Token: 0x0200033B RID: 827
	[Serializable]
	public struct GStruct264 : IEquatable<GStruct264>, IComparable<GStruct264>
	{
		// Token: 0x060046AF RID: 18095 RVA: 0x00108FB8 File Offset: 0x001071B8
		public bool vmethod_0(GStruct264 gstruct264_1)
		{
			return this.ulong_0 == gstruct264_1.ulong_0;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x00108FD4 File Offset: 0x001071D4
		public bool vmethod_1(object object_0)
		{
			return object_0 is GStruct264 && GStruct264.smethod_0(this, (GStruct264)object_0);
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00109020 File Offset: 0x00107220
		public int vmethod_2()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x0010903C File Offset: 0x0010723C
		public int vmethod_3(GStruct264 gstruct264_1)
		{
			return this.ulong_0.CompareTo(gstruct264_1.ulong_0);
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x0010905C File Offset: 0x0010725C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00109070 File Offset: 0x00107270
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x00108FB8 File Offset: 0x001071B8
		public static bool smethod_0(GStruct264 gstruct264_1, GStruct264 gstruct264_2)
		{
			return gstruct264_1.ulong_0 == gstruct264_2.ulong_0;
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00109084 File Offset: 0x00107284
		public GStruct264(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x00109098 File Offset: 0x00107298
		public static GStruct264 smethod_1(ulong ulong_1)
		{
			return new GStruct264(ulong_1);
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x001090B0 File Offset: 0x001072B0
		public static bool smethod_2(GStruct264 gstruct264_1, GStruct264 gstruct264_2)
		{
			return !GStruct264.smethod_0(gstruct264_1, gstruct264_2);
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x001090C8 File Offset: 0x001072C8
		public static ulong smethod_3(GStruct264 gstruct264_1)
		{
			return gstruct264_1.ulong_0;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x001090E0 File Offset: 0x001072E0
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04001AD7 RID: 6871
		public static readonly GStruct264 gstruct264_0 = new GStruct264(0UL);

		// Token: 0x04001AD8 RID: 6872
		public ulong ulong_0;
	}
}
