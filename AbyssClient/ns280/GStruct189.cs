using System;

namespace ns280
{
	// Token: 0x0200023F RID: 575
	[Serializable]
	public struct GStruct189 : IEquatable<GStruct189>, IComparable<GStruct189>
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x00088A00 File Offset: 0x00086C00
		public static bool smethod_0(GStruct189 gstruct189_0, GStruct189 gstruct189_1)
		{
			return gstruct189_0.ulong_0 == gstruct189_1.ulong_0;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00088A1C File Offset: 0x00086C1C
		public static bool smethod_1(GStruct189 gstruct189_0, GStruct189 gstruct189_1)
		{
			return !GStruct189.smethod_0(gstruct189_0, gstruct189_1);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00088A34 File Offset: 0x00086C34
		public static ulong smethod_2(GStruct189 gstruct189_0)
		{
			return gstruct189_0.ulong_0;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00088A4C File Offset: 0x00086C4C
		public static GStruct189 smethod_3(ulong ulong_1)
		{
			return new GStruct189(ulong_1);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00088A00 File Offset: 0x00086C00
		public bool vmethod_0(GStruct189 gstruct189_0)
		{
			return this.ulong_0 == gstruct189_0.ulong_0;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00088A64 File Offset: 0x00086C64
		public bool vmethod_1(object object_0)
		{
			return object_0 is GStruct189 && GStruct189.smethod_0(this, (GStruct189)object_0);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00088A90 File Offset: 0x00086C90
		public GStruct189(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00088AA4 File Offset: 0x00086CA4
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00088AB8 File Offset: 0x00086CB8
		public string vmethod_2()
		{
			return this.method_0();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00088ACC File Offset: 0x00086CCC
		public int vmethod_3()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00088AE8 File Offset: 0x00086CE8
		public int vmethod_4(GStruct189 gstruct189_0)
		{
			return this.ulong_0.CompareTo(gstruct189_0.ulong_0);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00088B08 File Offset: 0x00086D08
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04000F54 RID: 3924
		public ulong ulong_0;
	}
}
