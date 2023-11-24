using System;

namespace ns317
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public struct GStruct207 : IEquatable<GStruct207>, IComparable<GStruct207>
	{
		// Token: 0x06001D10 RID: 7440 RVA: 0x00091E3C File Offset: 0x0009003C
		public int vmethod_0(GStruct207 gstruct207_1)
		{
			return this.uint_0.CompareTo(gstruct207_1.uint_0);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00091E5C File Offset: 0x0009005C
		public static bool smethod_0(GStruct207 gstruct207_1, GStruct207 gstruct207_2)
		{
			return !GStruct207.smethod_2(gstruct207_1, gstruct207_2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00091E74 File Offset: 0x00090074
		public bool vmethod_1(GStruct207 gstruct207_1)
		{
			return this.uint_0 == gstruct207_1.uint_0;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00091E90 File Offset: 0x00090090
		public static uint smethod_1(GStruct207 gstruct207_1)
		{
			return gstruct207_1.uint_0;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00091EA8 File Offset: 0x000900A8
		public int vmethod_2()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00091EC4 File Offset: 0x000900C4
		public GStruct207(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00091ED8 File Offset: 0x000900D8
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00091EEC File Offset: 0x000900EC
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct207 && GStruct207.smethod_2(this, (GStruct207)object_0);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00091E74 File Offset: 0x00090074
		public static bool smethod_2(GStruct207 gstruct207_1, GStruct207 gstruct207_2)
		{
			return gstruct207_1.uint_0 == gstruct207_2.uint_0;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00091F18 File Offset: 0x00090118
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00091F2C File Offset: 0x0009012C
		public static GStruct207 smethod_3(uint uint_1)
		{
			return new GStruct207(uint_1);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00091F5C File Offset: 0x0009015C
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04001155 RID: 4437
		public static readonly GStruct207 gstruct207_0 = new GStruct207(0U);

		// Token: 0x04001156 RID: 4438
		public uint uint_0;
	}
}
