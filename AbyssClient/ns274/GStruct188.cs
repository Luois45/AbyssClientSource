using System;

namespace ns274
{
	// Token: 0x02000232 RID: 562
	[Serializable]
	public struct GStruct188 : IEquatable<GStruct188>, IComparable<GStruct188>
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x000823E0 File Offset: 0x000805E0
		public static bool smethod_0(GStruct188 gstruct188_1, GStruct188 gstruct188_2)
		{
			return gstruct188_1.uint_0 == gstruct188_2.uint_0;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000823FC File Offset: 0x000805FC
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00082410 File Offset: 0x00080610
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00082424 File Offset: 0x00080624
		public int vmethod_1(GStruct188 gstruct188_1)
		{
			return this.uint_0.CompareTo(gstruct188_1.uint_0);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000823E0 File Offset: 0x000805E0
		public bool vmethod_2(GStruct188 gstruct188_1)
		{
			return this.uint_0 == gstruct188_1.uint_0;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0008245C File Offset: 0x0008065C
		public int vmethod_3()
		{
			return this.uint_0.GetHashCode();
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00082478 File Offset: 0x00080678
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct188 && GStruct188.smethod_0(this, (GStruct188)object_0);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000824A4 File Offset: 0x000806A4
		public static GStruct188 smethod_1(uint uint_1)
		{
			return new GStruct188(uint_1);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000824BC File Offset: 0x000806BC
		public static bool smethod_2(GStruct188 gstruct188_1, GStruct188 gstruct188_2)
		{
			return !GStruct188.smethod_0(gstruct188_1, gstruct188_2);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000824D4 File Offset: 0x000806D4
		public static uint smethod_3(GStruct188 gstruct188_1)
		{
			return gstruct188_1.uint_0;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000824EC File Offset: 0x000806EC
		public GStruct188(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00082500 File Offset: 0x00080700
		internal string method_1()
		{
			return this.uint_0.ToString();
		}

		// Token: 0x04000EED RID: 3821
		public static readonly GStruct188 gstruct188_0 = new GStruct188(0U);

		// Token: 0x04000EEE RID: 3822
		public uint uint_0;
	}
}
