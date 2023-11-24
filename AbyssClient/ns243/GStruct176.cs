using System;

namespace ns243
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public struct GStruct176 : IEquatable<GStruct176>, IComparable<GStruct176>
	{
		// Token: 0x060018A1 RID: 6305 RVA: 0x0007F2C4 File Offset: 0x0007D4C4
		public static bool smethod_0(GStruct176 gstruct176_1, GStruct176 gstruct176_2)
		{
			return !GStruct176.smethod_1(gstruct176_1, gstruct176_2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0007F2DC File Offset: 0x0007D4DC
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
		public static bool smethod_1(GStruct176 gstruct176_1, GStruct176 gstruct176_2)
		{
			return gstruct176_1.uint_0 == gstruct176_2.uint_0;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0007F30C File Offset: 0x0007D50C
		public int vmethod_0()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0007F328 File Offset: 0x0007D528
		public static GStruct176 smethod_2(uint uint_1)
		{
			return new GStruct176(uint_1);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0007F358 File Offset: 0x0007D558
		public static uint smethod_3(GStruct176 gstruct176_1)
		{
			return gstruct176_1.uint_0;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0007F370 File Offset: 0x0007D570
		public string vmethod_1()
		{
			return this.method_0();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0007F384 File Offset: 0x0007D584
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct176 && GStruct176.smethod_1(this, (GStruct176)object_0);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
		public bool vmethod_3(GStruct176 gstruct176_1)
		{
			return this.uint_0 == gstruct176_1.uint_0;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		public int vmethod_4(GStruct176 gstruct176_1)
		{
			return this.uint_0.CompareTo(gstruct176_1.uint_0);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0007F3D0 File Offset: 0x0007D5D0
		public GStruct176(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0007F3E4 File Offset: 0x0007D5E4
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04000E62 RID: 3682
		public static readonly GStruct176 gstruct176_0 = new GStruct176(0U);

		// Token: 0x04000E63 RID: 3683
		public uint uint_0;
	}
}
