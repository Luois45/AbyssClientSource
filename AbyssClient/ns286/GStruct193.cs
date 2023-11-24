using System;

namespace ns286
{
	// Token: 0x0200024D RID: 589
	[Serializable]
	public struct GStruct193 : IEquatable<GStruct193>, IComparable<GStruct193>
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x0008AB50 File Offset: 0x00088D50
		public int vmethod_0(GStruct193 gstruct193_0)
		{
			return this.ulong_0.CompareTo(gstruct193_0.ulong_0);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0008AB70 File Offset: 0x00088D70
		public bool vmethod_1(GStruct193 gstruct193_0)
		{
			return this.ulong_0 == gstruct193_0.ulong_0;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0008AB8C File Offset: 0x00088D8C
		public static bool smethod_0(GStruct193 gstruct193_0, GStruct193 gstruct193_1)
		{
			return !GStruct193.smethod_2(gstruct193_0, gstruct193_1);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0008ABA4 File Offset: 0x00088DA4
		public static ulong smethod_1(GStruct193 gstruct193_0)
		{
			return gstruct193_0.ulong_0;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0008ABBC File Offset: 0x00088DBC
		public int vmethod_2()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0008AB70 File Offset: 0x00088D70
		public static bool smethod_2(GStruct193 gstruct193_0, GStruct193 gstruct193_1)
		{
			return gstruct193_0.ulong_0 == gstruct193_1.ulong_0;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0008ABD8 File Offset: 0x00088DD8
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct193 && GStruct193.smethod_2(this, (GStruct193)object_0);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0008AC04 File Offset: 0x00088E04
		public string vmethod_4()
		{
			return this.method_0();
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0008AC18 File Offset: 0x00088E18
		public static GStruct193 smethod_3(ulong ulong_1)
		{
			return new GStruct193(ulong_1);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0008AC30 File Offset: 0x00088E30
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0008AC44 File Offset: 0x00088E44
		public GStruct193(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0008AC58 File Offset: 0x00088E58
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04000FAA RID: 4010
		public ulong ulong_0;
	}
}
