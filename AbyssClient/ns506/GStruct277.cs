using System;

namespace ns506
{
	// Token: 0x0200036E RID: 878
	[Serializable]
	public struct GStruct277 : IEquatable<GStruct277>, IComparable<GStruct277>
	{
		// Token: 0x0600488C RID: 18572 RVA: 0x00111F24 File Offset: 0x00110124
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00111F38 File Offset: 0x00110138
		public int vmethod_0()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00111F54 File Offset: 0x00110154
		public static bool smethod_0(GStruct277 gstruct277_1, GStruct277 gstruct277_2)
		{
			return gstruct277_1.uint_0 == gstruct277_2.uint_0;
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00111F70 File Offset: 0x00110170
		public static uint smethod_1(GStruct277 gstruct277_1)
		{
			return gstruct277_1.uint_0;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00111F88 File Offset: 0x00110188
		public GStruct277(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00111F9C File Offset: 0x0011019C
		public static bool smethod_2(GStruct277 gstruct277_1, GStruct277 gstruct277_2)
		{
			return !GStruct277.smethod_0(gstruct277_1, gstruct277_2);
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x00111F54 File Offset: 0x00110154
		public bool vmethod_1(GStruct277 gstruct277_1)
		{
			return this.uint_0 == gstruct277_1.uint_0;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00111FB4 File Offset: 0x001101B4
		public int vmethod_2(GStruct277 gstruct277_1)
		{
			return this.uint_0.CompareTo(gstruct277_1.uint_0);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x00111FD4 File Offset: 0x001101D4
		public static GStruct277 smethod_3(uint uint_1)
		{
			return new GStruct277(uint_1);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00111FEC File Offset: 0x001101EC
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct277 && GStruct277.smethod_0(this, (GStruct277)object_0);
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00112018 File Offset: 0x00110218
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x0011202C File Offset: 0x0011022C
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04001BF8 RID: 7160
		public static readonly GStruct277 gstruct277_0 = new GStruct277(0U);

		// Token: 0x04001BF9 RID: 7161
		public uint uint_0;
	}
}
