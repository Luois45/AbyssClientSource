using System;

namespace ns350
{
	// Token: 0x020002B7 RID: 695
	[Serializable]
	public struct GStruct227 : IEquatable<GStruct227>, IComparable<GStruct227>
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x000A5148 File Offset: 0x000A3348
		public string vmethod_0()
		{
			return this.method_0();
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000A515C File Offset: 0x000A335C
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000A5170 File Offset: 0x000A3370
		public static bool smethod_0(GStruct227 gstruct227_1, GStruct227 gstruct227_2)
		{
			return gstruct227_1.ulong_0 == gstruct227_2.ulong_0;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x000A518C File Offset: 0x000A338C
		public static ulong smethod_1(GStruct227 gstruct227_1)
		{
			return gstruct227_1.ulong_0;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000A5170 File Offset: 0x000A3370
		public bool vmethod_1(GStruct227 gstruct227_1)
		{
			return this.ulong_0 == gstruct227_1.ulong_0;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000A51A4 File Offset: 0x000A33A4
		public static bool smethod_2(GStruct227 gstruct227_1, GStruct227 gstruct227_2)
		{
			return !GStruct227.smethod_0(gstruct227_1, gstruct227_2);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x000A51BC File Offset: 0x000A33BC
		public GStruct227(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000A51F0 File Offset: 0x000A33F0
		public static GStruct227 smethod_3(ulong ulong_1)
		{
			return new GStruct227(ulong_1);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x000A5208 File Offset: 0x000A3408
		public bool vmethod_2(object object_0)
		{
			return object_0 is GStruct227 && GStruct227.smethod_0(this, (GStruct227)object_0);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x000A5234 File Offset: 0x000A3434
		public int vmethod_3()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x000A5250 File Offset: 0x000A3450
		public int vmethod_4(GStruct227 gstruct227_1)
		{
			return this.ulong_0.CompareTo(gstruct227_1.ulong_0);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x000A5270 File Offset: 0x000A3470
		internal string method_1()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x04001291 RID: 4753
		public static readonly GStruct227 gstruct227_0 = new GStruct227(ulong.MaxValue);

		// Token: 0x04001292 RID: 4754
		public ulong ulong_0;
	}
}
