using System;

namespace ns515
{
	// Token: 0x02000382 RID: 898
	[Serializable]
	public struct GStruct285 : IEquatable<GStruct285>, IComparable<GStruct285>
	{
		// Token: 0x060049CC RID: 18892 RVA: 0x00118EC0 File Offset: 0x001170C0
		public static bool smethod_0(GStruct285 gstruct285_1, GStruct285 gstruct285_2)
		{
			return !GStruct285.smethod_3(gstruct285_1, gstruct285_2);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00118ED8 File Offset: 0x001170D8
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00118EEC File Offset: 0x001170EC
		public static ulong smethod_1(GStruct285 gstruct285_1)
		{
			return gstruct285_1.ulong_0;
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00118F04 File Offset: 0x00117104
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00118F18 File Offset: 0x00117118
		public bool vmethod_1(object object_0)
		{
			return object_0 is GStruct285 && GStruct285.smethod_3(this, (GStruct285)object_0);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00118F44 File Offset: 0x00117144
		public static GStruct285 smethod_2(ulong ulong_1)
		{
			return new GStruct285(ulong_1);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00118F5C File Offset: 0x0011715C
		public int vmethod_2(GStruct285 gstruct285_1)
		{
			return this.ulong_0.CompareTo(gstruct285_1.ulong_0);
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x00118F7C File Offset: 0x0011717C
		public static bool smethod_3(GStruct285 gstruct285_1, GStruct285 gstruct285_2)
		{
			return gstruct285_1.ulong_0 == gstruct285_2.ulong_0;
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00118F7C File Offset: 0x0011717C
		public bool vmethod_3(GStruct285 gstruct285_1)
		{
			return this.ulong_0 == gstruct285_1.ulong_0;
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00118FB8 File Offset: 0x001171B8
		public GStruct285(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x00118FCC File Offset: 0x001171CC
		public int vmethod_4()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00118FE8 File Offset: 0x001171E8
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04001CA2 RID: 7330
		public static readonly GStruct285 gstruct285_0 = new GStruct285(ulong.MaxValue);

		// Token: 0x04001CA3 RID: 7331
		public ulong ulong_0;
	}
}
