using System;

namespace ns151
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public struct GStruct66 : IEquatable<GStruct66>, IComparable<GStruct66>
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x0002192C File Offset: 0x0001FB2C
		public bool vmethod_0(GStruct66 gstruct66_1)
		{
			return this.uint_0 == gstruct66_1.uint_0;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00021948 File Offset: 0x0001FB48
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002195C File Offset: 0x0001FB5C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00021970 File Offset: 0x0001FB70
		public int vmethod_2(GStruct66 gstruct66_1)
		{
			return this.uint_0.CompareTo(gstruct66_1.uint_0);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002192C File Offset: 0x0001FB2C
		public static bool smethod_0(GStruct66 gstruct66_1, GStruct66 gstruct66_2)
		{
			return gstruct66_1.uint_0 == gstruct66_2.uint_0;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00021990 File Offset: 0x0001FB90
		public static bool smethod_1(GStruct66 gstruct66_1, GStruct66 gstruct66_2)
		{
			return !GStruct66.smethod_0(gstruct66_1, gstruct66_2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000219A8 File Offset: 0x0001FBA8
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct66 && GStruct66.smethod_0(this, (GStruct66)object_0);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000219D4 File Offset: 0x0001FBD4
		public static uint smethod_2(GStruct66 gstruct66_1)
		{
			return gstruct66_1.uint_0;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00021A04 File Offset: 0x0001FC04
		public int vmethod_4()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00021A20 File Offset: 0x0001FC20
		public GStruct66(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00021A34 File Offset: 0x0001FC34
		public static GStruct66 smethod_3(uint uint_1)
		{
			return new GStruct66(uint_1);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00021A4C File Offset: 0x0001FC4C
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04000654 RID: 1620
		public static readonly GStruct66 gstruct66_0 = new GStruct66(0U);

		// Token: 0x04000655 RID: 1621
		public uint uint_0;
	}
}
