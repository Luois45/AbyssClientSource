using System;

namespace ns103
{
	// Token: 0x0200008D RID: 141
	[Serializable]
	public struct GStruct36 : IEquatable<GStruct36>, IComparable<GStruct36>
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00011400 File Offset: 0x0000F600
		public int vmethod_0()
		{
			return this.int_0.GetHashCode();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001141C File Offset: 0x0000F61C
		public GStruct36(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00011430 File Offset: 0x0000F630
		public bool vmethod_1(GStruct36 gstruct36_0)
		{
			return this.int_0 == gstruct36_0.int_0;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001144C File Offset: 0x0000F64C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00011460 File Offset: 0x0000F660
		public static bool smethod_0(GStruct36 gstruct36_0, GStruct36 gstruct36_1)
		{
			return !GStruct36.smethod_2(gstruct36_0, gstruct36_1);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00011478 File Offset: 0x0000F678
		public static GStruct36 smethod_1(int int_1)
		{
			return new GStruct36(int_1);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00011430 File Offset: 0x0000F630
		public static bool smethod_2(GStruct36 gstruct36_0, GStruct36 gstruct36_1)
		{
			return gstruct36_0.int_0 == gstruct36_1.int_0;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00011490 File Offset: 0x0000F690
		public static int smethod_3(GStruct36 gstruct36_0)
		{
			return gstruct36_0.int_0;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct36 && GStruct36.smethod_2(this, (GStruct36)object_0);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000114D4 File Offset: 0x0000F6D4
		public int vmethod_3(GStruct36 gstruct36_0)
		{
			return this.int_0.CompareTo(gstruct36_0.int_0);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000114F4 File Offset: 0x0000F6F4
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00011508 File Offset: 0x0000F708
		internal string method_1()
		{
			return this.int_0.ToString();
		}

		// Token: 0x04000302 RID: 770
		public int int_0;
	}
}
