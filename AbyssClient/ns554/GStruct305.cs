using System;

namespace ns554
{
	// Token: 0x020003B1 RID: 945
	[Serializable]
	public struct GStruct305 : IEquatable<GStruct305>, IComparable<GStruct305>
	{
		// Token: 0x06004A52 RID: 19026 RVA: 0x0011BB38 File Offset: 0x00119D38
		public static ulong smethod_0(GStruct305 gstruct305_0)
		{
			return gstruct305_0.ulong_0;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0011BB50 File Offset: 0x00119D50
		public static bool smethod_1(GStruct305 gstruct305_0, GStruct305 gstruct305_1)
		{
			return !GStruct305.smethod_3(gstruct305_0, gstruct305_1);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x0011BB68 File Offset: 0x00119D68
		public bool vmethod_0(GStruct305 gstruct305_0)
		{
			return this.ulong_0 == gstruct305_0.ulong_0;
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0011BB84 File Offset: 0x00119D84
		public GStruct305(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x0011BB98 File Offset: 0x00119D98
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0011BBAC File Offset: 0x00119DAC
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0011BBC0 File Offset: 0x00119DC0
		public static GStruct305 smethod_2(ulong ulong_1)
		{
			return new GStruct305(ulong_1);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0011BBD8 File Offset: 0x00119DD8
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct305 && GStruct305.smethod_3(this, (GStruct305)object_0);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x0011BC04 File Offset: 0x00119E04
		public int vmethod_3()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x0011BC20 File Offset: 0x00119E20
		public int vmethod_4(GStruct305 gstruct305_0)
		{
			return this.ulong_0.CompareTo(gstruct305_0.ulong_0);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x0011BB68 File Offset: 0x00119D68
		public static bool smethod_3(GStruct305 gstruct305_0, GStruct305 gstruct305_1)
		{
			return gstruct305_0.ulong_0 == gstruct305_1.ulong_0;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x0011BC40 File Offset: 0x00119E40
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04001DAD RID: 7597
		public ulong ulong_0;
	}
}
