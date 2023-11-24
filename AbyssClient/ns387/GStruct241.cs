using System;

namespace ns387
{
	// Token: 0x020002ED RID: 749
	[Serializable]
	public struct GStruct241 : IEquatable<GStruct241>, IComparable<GStruct241>
	{
		// Token: 0x06003F83 RID: 16259 RVA: 0x000EFD7C File Offset: 0x000EDF7C
		public static GStruct241 smethod_0(ulong ulong_1)
		{
			return new GStruct241(ulong_1);
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x000EFDB4 File Offset: 0x000EDFB4
		public static ulong smethod_1(GStruct241 gstruct241_1)
		{
			return gstruct241_1.ulong_0;
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000EFDCC File Offset: 0x000EDFCC
		public static bool smethod_2(GStruct241 gstruct241_1, GStruct241 gstruct241_2)
		{
			return gstruct241_1.ulong_0 == gstruct241_2.ulong_0;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x000EFDE8 File Offset: 0x000EDFE8
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x000EFDFC File Offset: 0x000EDFFC
		public GStruct241(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x000EFE10 File Offset: 0x000EE010
		public static bool smethod_3(GStruct241 gstruct241_1, GStruct241 gstruct241_2)
		{
			return !GStruct241.smethod_2(gstruct241_1, gstruct241_2);
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x000EFE28 File Offset: 0x000EE028
		public int vmethod_1()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x000EFE44 File Offset: 0x000EE044
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct241 && GStruct241.smethod_2(this, (GStruct241)object_0);
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x000EFE70 File Offset: 0x000EE070
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x000EFDCC File Offset: 0x000EDFCC
		public bool vmethod_3(GStruct241 gstruct241_1)
		{
			return this.ulong_0 == gstruct241_1.ulong_0;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x000EFE84 File Offset: 0x000EE084
		public int vmethod_4(GStruct241 gstruct241_1)
		{
			return this.ulong_0.CompareTo(gstruct241_1.ulong_0);
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x000EFEA4 File Offset: 0x000EE0A4
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x0400187E RID: 6270
		public static readonly GStruct241 gstruct241_0 = new GStruct241(0UL);

		// Token: 0x0400187F RID: 6271
		public ulong ulong_0;
	}
}
