using System;

namespace ns330
{
	// Token: 0x0200028A RID: 650
	[Serializable]
	public struct GStruct215 : IEquatable<GStruct215>, IComparable<GStruct215>
	{
		// Token: 0x06001DCB RID: 7627 RVA: 0x00093E9C File Offset: 0x0009209C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00093EB0 File Offset: 0x000920B0
		public static bool smethod_0(GStruct215 gstruct215_1, GStruct215 gstruct215_2)
		{
			return gstruct215_1.ulong_0 == gstruct215_2.ulong_0;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00093EEC File Offset: 0x000920EC
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00093F00 File Offset: 0x00092100
		public static ulong smethod_1(GStruct215 gstruct215_1)
		{
			return gstruct215_1.ulong_0;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00093F18 File Offset: 0x00092118
		public static GStruct215 smethod_2(ulong ulong_1)
		{
			return new GStruct215(ulong_1);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00093F30 File Offset: 0x00092130
		public int vmethod_1(GStruct215 gstruct215_1)
		{
			return this.ulong_0.CompareTo(gstruct215_1.ulong_0);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00093F50 File Offset: 0x00092150
		public GStruct215(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00093EB0 File Offset: 0x000920B0
		public bool vmethod_2(GStruct215 gstruct215_1)
		{
			return this.ulong_0 == gstruct215_1.ulong_0;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00093F64 File Offset: 0x00092164
		public static bool smethod_3(GStruct215 gstruct215_1, GStruct215 gstruct215_2)
		{
			return !GStruct215.smethod_0(gstruct215_1, gstruct215_2);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00093F7C File Offset: 0x0009217C
		public bool vmethod_3(object object_0)
		{
			return object_0 is GStruct215 && GStruct215.smethod_0(this, (GStruct215)object_0);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00093FA8 File Offset: 0x000921A8
		public int vmethod_4()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00093FC4 File Offset: 0x000921C4
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x040011B0 RID: 4528
		public static readonly GStruct215 gstruct215_0 = new GStruct215(ulong.MaxValue);

		// Token: 0x040011B1 RID: 4529
		public ulong ulong_0;
	}
}
