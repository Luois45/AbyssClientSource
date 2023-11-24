using System;

namespace ns386
{
	// Token: 0x020002EC RID: 748
	[Serializable]
	public struct GStruct240 : IEquatable<GStruct240>
	{
		// Token: 0x06003F77 RID: 16247 RVA: 0x000EFC58 File Offset: 0x000EDE58
		public static bool smethod_0(GStruct240 gstruct240_1, GStruct240 gstruct240_2)
		{
			return !GStruct240.smethod_1(gstruct240_1, gstruct240_2);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x000EFC70 File Offset: 0x000EDE70
		public static bool smethod_1(GStruct240 gstruct240_1, GStruct240 gstruct240_2)
		{
			return gstruct240_1.intptr_0 == gstruct240_2.intptr_0;
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x000EFC90 File Offset: 0x000EDE90
		public GStruct240(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x000EFCC0 File Offset: 0x000EDEC0
		public static GStruct240 smethod_2(IntPtr intptr_1)
		{
			return new GStruct240(intptr_1);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000EFC70 File Offset: 0x000EDE70
		public bool vmethod_0(GStruct240 gstruct240_1)
		{
			return this.intptr_0 == gstruct240_1.intptr_0;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x000EFCD8 File Offset: 0x000EDED8
		public static IntPtr smethod_3(GStruct240 gstruct240_1)
		{
			return gstruct240_1.intptr_0;
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x000EFCF0 File Offset: 0x000EDEF0
		public int vmethod_1()
		{
			return this.intptr_0.GetHashCode();
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x000EFD0C File Offset: 0x000EDF0C
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct240 && GStruct240.smethod_1(this, (GStruct240)object_0);
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x000EFD38 File Offset: 0x000EDF38
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x000EFD4C File Offset: 0x000EDF4C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x000EFD60 File Offset: 0x000EDF60
		internal string method_1()
		{
			return this.intptr_0.ToString();
		}

		// Token: 0x0400187C RID: 6268
		public static readonly GStruct240 gstruct240_0 = new GStruct240(IntPtr.Zero);

		// Token: 0x0400187D RID: 6269
		public IntPtr intptr_0;
	}
}
