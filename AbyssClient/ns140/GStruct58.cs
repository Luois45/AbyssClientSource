using System;

namespace ns140
{
	// Token: 0x020000D9 RID: 217
	[Serializable]
	public struct GStruct58 : IEquatable<GStruct58>, IComparable<GStruct58>
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x0001CC80 File Offset: 0x0001AE80
		public static int smethod_0(GStruct58 gstruct58_0)
		{
			return gstruct58_0.int_0;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001CC98 File Offset: 0x0001AE98
		public bool vmethod_0(object object_0)
		{
			return object_0 is GStruct58 && GStruct58.smethod_2(this, (GStruct58)object_0);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001CCC4 File Offset: 0x0001AEC4
		public int vmethod_1()
		{
			return this.int_0.GetHashCode();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		public GStruct58(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		public static bool smethod_1(GStruct58 gstruct58_0, GStruct58 gstruct58_1)
		{
			return !GStruct58.smethod_2(gstruct58_0, gstruct58_1);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001CD0C File Offset: 0x0001AF0C
		public static bool smethod_2(GStruct58 gstruct58_0, GStruct58 gstruct58_1)
		{
			return gstruct58_0.int_0 == gstruct58_1.int_0;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001CD28 File Offset: 0x0001AF28
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		public int vmethod_2(GStruct58 gstruct58_0)
		{
			return this.int_0.CompareTo(gstruct58_0.int_0);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001CD0C File Offset: 0x0001AF0C
		public bool vmethod_4(GStruct58 gstruct58_0)
		{
			return this.int_0 == gstruct58_0.int_0;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public static GStruct58 smethod_3(int int_1)
		{
			return new GStruct58(int_1);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001CD88 File Offset: 0x0001AF88
		internal string method_1()
		{
			return this.int_0.ToString();
		}

		// Token: 0x04000543 RID: 1347
		public int int_0;
	}
}
