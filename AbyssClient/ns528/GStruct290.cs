using System;

namespace ns528
{
	// Token: 0x0200038F RID: 911
	[Serializable]
	public struct GStruct290 : IEquatable<GStruct290>, IComparable<GStruct290>
	{
		// Token: 0x060049FF RID: 18943 RVA: 0x00119B78 File Offset: 0x00117D78
		public bool vmethod_0(object object_0)
		{
			return object_0 is GStruct290 && GStruct290.smethod_1(this, (GStruct290)object_0);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00119BA4 File Offset: 0x00117DA4
		public static GStruct290 smethod_0(ulong ulong_1)
		{
			return new GStruct290(ulong_1);
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00119BBC File Offset: 0x00117DBC
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00119BD0 File Offset: 0x00117DD0
		public static bool smethod_1(GStruct290 gstruct290_0, GStruct290 gstruct290_1)
		{
			return gstruct290_0.ulong_0 == gstruct290_1.ulong_0;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00119BEC File Offset: 0x00117DEC
		public int vmethod_1(GStruct290 gstruct290_0)
		{
			return this.ulong_0.CompareTo(gstruct290_0.ulong_0);
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00119C0C File Offset: 0x00117E0C
		public static bool smethod_2(GStruct290 gstruct290_0, GStruct290 gstruct290_1)
		{
			return !GStruct290.smethod_1(gstruct290_0, gstruct290_1);
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00119C24 File Offset: 0x00117E24
		public int vmethod_2()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00119BD0 File Offset: 0x00117DD0
		public bool vmethod_3(GStruct290 gstruct290_0)
		{
			return this.ulong_0 == gstruct290_0.ulong_0;
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00119C40 File Offset: 0x00117E40
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00119C54 File Offset: 0x00117E54
		public GStruct290(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00119C68 File Offset: 0x00117E68
		public static ulong smethod_3(GStruct290 gstruct290_0)
		{
			return gstruct290_0.ulong_0;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00119C80 File Offset: 0x00117E80
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04001CF3 RID: 7411
		public ulong ulong_0;
	}
}
