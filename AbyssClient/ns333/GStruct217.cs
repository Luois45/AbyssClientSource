using System;
using ns151;

namespace ns333
{
	// Token: 0x0200028D RID: 653
	[Serializable]
	public struct GStruct217 : IEquatable<GStruct217>, IComparable<GStruct217>
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x00094104 File Offset: 0x00092304
		public static bool smethod_0(GStruct217 gstruct217_0, GStruct217 gstruct217_1)
		{
			return !GStruct217.smethod_2(gstruct217_0, gstruct217_1);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0009411C File Offset: 0x0009231C
		public GStruct66 method_0()
		{
			return new GStruct66((uint)(this.ulong_0 & 16777215UL));
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00094144 File Offset: 0x00092344
		public GStruct217.GEnum63 method_1()
		{
			return (GStruct217.GEnum63)(this.ulong_0 >> 24 & 255UL);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00094168 File Offset: 0x00092368
		public bool method_2()
		{
			return this.method_1() == GStruct217.GEnum63.const_2;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00094180 File Offset: 0x00092380
		public bool method_3()
		{
			return this.method_1() == GStruct217.GEnum63.const_0;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00094198 File Offset: 0x00092398
		internal string method_4()
		{
			return this.method_19();
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000941AC File Offset: 0x000923AC
		public static ulong smethod_1(GStruct217 gstruct217_0)
		{
			return gstruct217_0.ulong_0;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000941C4 File Offset: 0x000923C4
		private void method_5(GStruct217.GEnum63 genum63_0)
		{
			this.ulong_0 = ((this.ulong_0 & 18446744069431361535UL) | (ulong)((ulong)((long)genum63_0 & 255L) << 24));
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000941F8 File Offset: 0x000923F8
		public GStruct217(GStruct66 gstruct66_0, uint uint_0)
		{
			this.ulong_0 = 0UL;
			this.method_22(gstruct66_0);
			this.method_9(GStruct217.GEnum63.const_1);
			this.method_14(uint_0);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0009422C File Offset: 0x0009242C
		public string vmethod_0()
		{
			return this.method_4();
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00094240 File Offset: 0x00092440
		internal void method_6(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00094254 File Offset: 0x00092454
		public int vmethod_1()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00094270 File Offset: 0x00092470
		private void method_7(uint uint_0)
		{
			this.method_11(uint_0);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00094284 File Offset: 0x00092484
		public uint method_8()
		{
			return (uint)(this.ulong_0 >> 32 & ulong.MaxValue);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000942A8 File Offset: 0x000924A8
		public bool vmethod_2(GStruct217 gstruct217_0)
		{
			return this.ulong_0 == gstruct217_0.ulong_0;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000942C4 File Offset: 0x000924C4
		private void method_9(GStruct217.GEnum63 genum63_0)
		{
			this.method_23(genum63_0);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000942D8 File Offset: 0x000924D8
		internal void method_10(ulong ulong_1)
		{
			this.method_6(ulong_1);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000942EC File Offset: 0x000924EC
		public GStruct217(GStruct66 gstruct66_0)
		{
			this.ulong_0 = 0UL;
			this.method_22(gstruct66_0);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00094310 File Offset: 0x00092510
		private void method_11(uint uint_0)
		{
			this.ulong_0 = ((this.ulong_0 & ulong.MaxValue) | ((ulong)uint_0 & ulong.MaxValue) << 32);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00094344 File Offset: 0x00092544
		private void method_12(GStruct66 gstruct66_0)
		{
			this.method_20(gstruct66_0);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00094358 File Offset: 0x00092558
		internal void method_13()
		{
			this.method_24();
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0009436C File Offset: 0x0009256C
		private void method_14(uint uint_0)
		{
			this.method_7(uint_0);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00094380 File Offset: 0x00092580
		public bool method_15()
		{
			return this.method_1() == GStruct217.GEnum63.const_1;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00094398 File Offset: 0x00092598
		public bool method_16()
		{
			return this.method_1() == GStruct217.GEnum63.const_3;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000943B0 File Offset: 0x000925B0
		public void method_17(ulong ulong_1)
		{
			this.method_10(ulong_1);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000943C4 File Offset: 0x000925C4
		public bool method_18()
		{
			bool result;
			switch (this.method_1())
			{
			case GStruct217.GEnum63.const_0:
				result = GStruct66.smethod_1(this.method_0(), GStruct66.gstruct66_0);
				break;
			case GStruct217.GEnum63.const_1:
				result = (GStruct66.smethod_1(this.method_0(), GStruct66.gstruct66_0) && (this.method_8() & 2147483648U) > 0U);
				break;
			case GStruct217.GEnum63.const_2:
				result = ((this.method_8() & 2147483648U) > 0U);
				break;
			case GStruct217.GEnum63.const_3:
				result = (GStruct66.smethod_0(this.method_0(), GStruct66.gstruct66_0) && (this.method_8() & 2147483648U) > 0U);
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00094468 File Offset: 0x00092668
		internal string method_19()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00094484 File Offset: 0x00092684
		private void method_20(GStruct66 gstruct66_0)
		{
			this.ulong_0 = ((this.ulong_0 & 18446744073692774400UL) | ((ulong)GStruct66.smethod_2(gstruct66_0) & 16777215UL));
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000944BC File Offset: 0x000926BC
		public int vmethod_3(GStruct217 gstruct217_0)
		{
			return this.ulong_0.CompareTo(gstruct217_0.ulong_0);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00094240 File Offset: 0x00092440
		public GStruct217(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x000944DC File Offset: 0x000926DC
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct217 && GStruct217.smethod_2(this, (GStruct217)object_0);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000942A8 File Offset: 0x000924A8
		public static bool smethod_2(GStruct217 gstruct217_0, GStruct217 gstruct217_1)
		{
			return gstruct217_0.ulong_0 == gstruct217_1.ulong_0;
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00094508 File Offset: 0x00092708
		public void method_21()
		{
			this.method_13();
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0009451C File Offset: 0x0009271C
		public static GStruct217 smethod_3(ulong ulong_1)
		{
			return new GStruct217(ulong_1);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00094534 File Offset: 0x00092734
		private void method_22(GStruct66 gstruct66_0)
		{
			this.method_12(gstruct66_0);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00094548 File Offset: 0x00092748
		private void method_23(GStruct217.GEnum63 genum63_0)
		{
			this.method_5(genum63_0);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0009455C File Offset: 0x0009275C
		internal void method_24()
		{
			this.ulong_0 = 0UL;
		}

		// Token: 0x040011BD RID: 4541
		public ulong ulong_0;

		// Token: 0x0200028E RID: 654
		public enum GEnum63
		{
			// Token: 0x040011BF RID: 4543
			const_0,
			// Token: 0x040011C0 RID: 4544
			const_1,
			// Token: 0x040011C1 RID: 4545
			const_2,
			// Token: 0x040011C2 RID: 4546
			const_3
		}
	}
}
