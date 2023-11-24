using System;

namespace ns398
{
	// Token: 0x02000305 RID: 773
	[Serializable]
	public struct GStruct248 : IEquatable<GStruct248>, IComparable<GStruct248>
	{
		// Token: 0x0600405C RID: 16476 RVA: 0x000F3144 File Offset: 0x000F1344
		public static int smethod_0(GStruct248 gstruct248_1)
		{
			return gstruct248_1.int_0;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x000F315C File Offset: 0x000F135C
		public bool vmethod_0(object object_0)
		{
			return object_0 is GStruct248 && GStruct248.smethod_2(this, (GStruct248)object_0);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x000F3188 File Offset: 0x000F1388
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x000F319C File Offset: 0x000F139C
		public int vmethod_1()
		{
			return this.int_0.GetHashCode();
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x000F31B8 File Offset: 0x000F13B8
		public static bool smethod_1(GStruct248 gstruct248_1, GStruct248 gstruct248_2)
		{
			return !GStruct248.smethod_2(gstruct248_1, gstruct248_2);
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x000F31D0 File Offset: 0x000F13D0
		public static bool smethod_2(GStruct248 gstruct248_1, GStruct248 gstruct248_2)
		{
			return gstruct248_1.int_0 == gstruct248_2.int_0;
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x000F31D0 File Offset: 0x000F13D0
		public bool vmethod_2(GStruct248 gstruct248_1)
		{
			return this.int_0 == gstruct248_1.int_0;
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x000F31EC File Offset: 0x000F13EC
		public static GStruct248 smethod_3(int int_1)
		{
			return new GStruct248(int_1);
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x000F3204 File Offset: 0x000F1404
		public string vmethod_3()
		{
			return this.method_0();
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x000F3218 File Offset: 0x000F1418
		public GStruct248(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x000F322C File Offset: 0x000F142C
		public int vmethod_4(GStruct248 gstruct248_1)
		{
			return this.int_0.CompareTo(gstruct248_1.int_0);
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x000F324C File Offset: 0x000F144C
		internal string method_1()
		{
			return this.int_0.ToString();
		}

		// Token: 0x040018EE RID: 6382
		public static readonly GStruct248 gstruct248_0 = new GStruct248(-1);

		// Token: 0x040018EF RID: 6383
		public int int_0;
	}
}
