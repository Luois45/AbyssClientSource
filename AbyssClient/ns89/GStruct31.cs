using System;

namespace ns89
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public struct GStruct31 : IEquatable<GStruct31>, IComparable<GStruct31>
	{
		// Token: 0x06000391 RID: 913 RVA: 0x0000BA78 File Offset: 0x00009C78
		public static int smethod_0(GStruct31 gstruct31_1)
		{
			return gstruct31_1.int_0;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000BA90 File Offset: 0x00009C90
		public static bool smethod_1(GStruct31 gstruct31_1, GStruct31 gstruct31_2)
		{
			return gstruct31_1.int_0 == gstruct31_2.int_0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BA90 File Offset: 0x00009C90
		public bool vmethod_0(GStruct31 gstruct31_1)
		{
			return this.int_0 == gstruct31_1.int_0;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BAAC File Offset: 0x00009CAC
		public int vmethod_1(GStruct31 gstruct31_1)
		{
			return this.int_0.CompareTo(gstruct31_1.int_0);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000BACC File Offset: 0x00009CCC
		public static bool smethod_2(GStruct31 gstruct31_1, GStruct31 gstruct31_2)
		{
			return !GStruct31.smethod_1(gstruct31_1, gstruct31_2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		public GStruct31(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct31 && GStruct31.smethod_1(this, (GStruct31)object_0);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000BB3C File Offset: 0x00009D3C
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000BB50 File Offset: 0x00009D50
		public static GStruct31 smethod_3(int int_1)
		{
			return new GStruct31(int_1);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000BB68 File Offset: 0x00009D68
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BB7C File Offset: 0x00009D7C
		public int vmethod_4()
		{
			return this.int_0.GetHashCode();
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000BB98 File Offset: 0x00009D98
		internal string method_1()
		{
			return this.int_0.ToString();
		}

		// Token: 0x04000226 RID: 550
		public static readonly GStruct31 gstruct31_0 = new GStruct31(-1);

		// Token: 0x04000227 RID: 551
		public int int_0;
	}
}
