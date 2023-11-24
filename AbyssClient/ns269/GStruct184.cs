using System;

namespace ns269
{
	// Token: 0x0200022C RID: 556
	[Serializable]
	public struct GStruct184
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x00081994 File Offset: 0x0007FB94
		public static bool smethod_0(GStruct184 gstruct184_0, GStruct184 gstruct184_1)
		{
			return !GStruct184.smethod_4(gstruct184_0, gstruct184_1);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000819AC File Offset: 0x0007FBAC
		public void method_0(uint uint_1)
		{
			this.method_12(uint_1);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000819C0 File Offset: 0x0007FBC0
		internal void method_1(ushort ushort_2)
		{
			this.ushort_1 = ushort_2;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000819D4 File Offset: 0x0007FBD4
		internal string method_2()
		{
			return this.method_8();
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000819E8 File Offset: 0x0007FBE8
		public void method_3(uint uint_1, ushort ushort_2, ushort ushort_3)
		{
			this.method_18(uint_1, ushort_2, ushort_3);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00081A00 File Offset: 0x0007FC00
		public bool method_4(GStruct184 gstruct184_0)
		{
			return this.uint_0 == gstruct184_0.uint_0 && this.ushort_1 == gstruct184_0.ushort_1 && this.ushort_0 == gstruct184_0.ushort_0;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00081A3C File Offset: 0x0007FC3C
		public static bool smethod_1(GStruct184 gstruct184_0, GStruct184 gstruct184_1)
		{
			return gstruct184_0.uint_0 > gstruct184_1.uint_0 || (gstruct184_0.uint_0 == gstruct184_1.uint_0 && gstruct184_0.ushort_1 > gstruct184_1.ushort_1);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00081A7C File Offset: 0x0007FC7C
		public ushort method_5()
		{
			return this.ushort_0;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00081A94 File Offset: 0x0007FC94
		public void method_6(ushort ushort_2)
		{
			this.method_13(ushort_2);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00081AA8 File Offset: 0x0007FCA8
		internal string method_7()
		{
			return this.method_11();
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00081ABC File Offset: 0x0007FCBC
		public static string smethod_2(uint uint_1, ushort ushort_2)
		{
			return GStruct184.smethod_5(uint_1, ushort_2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00081AD0 File Offset: 0x0007FCD0
		internal string method_8()
		{
			return GStruct184.smethod_2(this.uint_0, this.ushort_0);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00081AF0 File Offset: 0x0007FCF0
		public void method_9(ushort ushort_2)
		{
			this.method_21(ushort_2);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00081B04 File Offset: 0x0007FD04
		public ushort method_10()
		{
			return this.ushort_1;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00081B1C File Offset: 0x0007FD1C
		internal string method_11()
		{
			return GStruct184.smethod_2(this.uint_0, this.ushort_1);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00081B3C File Offset: 0x0007FD3C
		internal static string smethod_3(uint uint_1, ushort ushort_2)
		{
			return string.Format("{0}.{1}.{2}.{3}:{4}", new object[]
			{
				(ulong)(uint_1 >> 24) & 255UL,
				(ulong)(uint_1 >> 16) & 255UL,
				(ulong)(uint_1 >> 8) & 255UL,
				(ulong)uint_1 & 255UL,
				ushort_2
			});
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00081BBC File Offset: 0x0007FDBC
		internal void method_12(uint uint_1)
		{
			this.method_14(uint_1);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00081BD0 File Offset: 0x0007FDD0
		internal void method_13(ushort ushort_2)
		{
			this.method_1(ushort_2);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00081BE4 File Offset: 0x0007FDE4
		internal void method_14(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00081BF8 File Offset: 0x0007FDF8
		public uint method_15()
		{
			return this.uint_0;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00081A00 File Offset: 0x0007FC00
		public static bool smethod_4(GStruct184 gstruct184_0, GStruct184 gstruct184_1)
		{
			return gstruct184_0.uint_0 == gstruct184_1.uint_0 && gstruct184_0.ushort_1 == gstruct184_1.ushort_1 && gstruct184_0.ushort_0 == gstruct184_1.ushort_0;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00081C10 File Offset: 0x0007FE10
		public string method_16()
		{
			return this.method_7();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00081C24 File Offset: 0x0007FE24
		public bool vmethod_0(object object_0)
		{
			return object_0 is GStruct184 && GStruct184.smethod_4(this, (GStruct184)object_0);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00081C50 File Offset: 0x0007FE50
		internal static string smethod_5(uint uint_1, ushort ushort_2)
		{
			return GStruct184.smethod_3(uint_1, ushort_2);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00081C64 File Offset: 0x0007FE64
		public int vmethod_1()
		{
			return this.uint_0.GetHashCode() + this.ushort_1.GetHashCode() + this.ushort_0.GetHashCode();
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00081C98 File Offset: 0x0007FE98
		public string method_17()
		{
			return this.method_2();
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00081CAC File Offset: 0x0007FEAC
		public static bool smethod_6(GStruct184 gstruct184_0, GStruct184 gstruct184_1)
		{
			return gstruct184_0.uint_0 < gstruct184_1.uint_0 || (gstruct184_0.uint_0 == gstruct184_1.uint_0 && gstruct184_0.ushort_1 < gstruct184_1.ushort_1);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00081CEC File Offset: 0x0007FEEC
		internal void method_18(uint uint_1, ushort ushort_2, ushort ushort_3)
		{
			this.method_22(uint_1, ushort_2, ushort_3);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00081D04 File Offset: 0x0007FF04
		public int method_19(GStruct184 gstruct184_0)
		{
			return this.uint_0.CompareTo(gstruct184_0.uint_0) + this.ushort_1.CompareTo(gstruct184_0.ushort_1) + this.ushort_0.CompareTo(gstruct184_0.ushort_0);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00081D48 File Offset: 0x0007FF48
		internal void method_20(ushort ushort_2)
		{
			this.ushort_0 = ushort_2;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00081D5C File Offset: 0x0007FF5C
		internal void method_21(ushort ushort_2)
		{
			this.method_20(ushort_2);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00081D70 File Offset: 0x0007FF70
		internal void method_22(uint uint_1, ushort ushort_2, ushort ushort_3)
		{
			this.uint_0 = uint_1;
			this.ushort_1 = ushort_2;
			this.ushort_0 = ushort_3;
		}

		// Token: 0x04000ECF RID: 3791
		private ushort ushort_0;

		// Token: 0x04000ED0 RID: 3792
		private ushort ushort_1;

		// Token: 0x04000ED1 RID: 3793
		private uint uint_0;
	}
}
