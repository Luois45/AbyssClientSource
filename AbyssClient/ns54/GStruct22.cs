using System;
using System.Runtime.InteropServices;
using ns331;
using ns336;
using ns403;

namespace ns54
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GStruct22 : IEquatable<GStruct22>, IComparable<GStruct22>
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00007518 File Offset: 0x00005718
		internal void method_0()
		{
			this.ulong_0 = 0UL;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007534 File Offset: 0x00005734
		public uint method_1()
		{
			return (uint)(this.ulong_0 >> 32 & 1048575UL);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007558 File Offset: 0x00005758
		internal void method_2()
		{
			this.method_0();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000756C File Offset: 0x0000576C
		public void method_3(GStruct216 gstruct216_0, uint uint_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_41(gstruct216_0, uint_0, genum77_0, genum65_0);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00007588 File Offset: 0x00005788
		internal void method_4(GStruct216 gstruct216_0, uint uint_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_15(gstruct216_0);
			this.method_39(genum77_0);
			this.method_26(genum65_0);
			this.method_38(uint_0);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000075B4 File Offset: 0x000057B4
		public string vmethod_0()
		{
			return this.method_16();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000075C8 File Offset: 0x000057C8
		public int vmethod_1()
		{
			return this.ulong_0.GetHashCode();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000075E4 File Offset: 0x000057E4
		public GEnum77 method_5()
		{
			return (GEnum77)(this.ulong_0 >> 56 & 255UL);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00007608 File Offset: 0x00005808
		internal void method_6(GStruct216 gstruct216_0)
		{
			this.ulong_0 = ((this.ulong_0 & 18446744069414584320UL) | ((ulong)GStruct216.smethod_1(gstruct216_0) & ulong.MaxValue));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00007640 File Offset: 0x00005840
		internal void method_7(GEnum65 genum65_0)
		{
			this.ulong_0 = ((this.ulong_0 & 18379190079298994175UL) | (ulong)((ulong)((long)genum65_0 & 15L) << 52));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007674 File Offset: 0x00005874
		public void method_8(GEnum77 genum77_0)
		{
			this.method_10(genum77_0);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007688 File Offset: 0x00005888
		public bool method_9()
		{
			return this.method_23() == GEnum65.const_7;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000076A0 File Offset: 0x000058A0
		internal void method_10(GEnum77 genum77_0)
		{
			this.method_12(genum77_0);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007718 File Offset: 0x00005918
		public GStruct22(GStruct216 gstruct216_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.ulong_0 = 0UL;
			this.method_30(gstruct216_0, genum77_0, genum65_0);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007740 File Offset: 0x00005940
		public bool method_11()
		{
			return this.method_23() == GEnum65.const_1 || this.method_23() == GEnum65.const_9;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00007764 File Offset: 0x00005964
		internal void method_12(GEnum77 genum77_0)
		{
			this.method_15(new GStruct216(0U));
			this.method_39(genum77_0);
			this.method_26(GEnum65.const_4);
			this.method_38(0U);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00007794 File Offset: 0x00005994
		internal void method_13(GStruct216 gstruct216_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_49(gstruct216_0, genum77_0, genum65_0);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000077AC File Offset: 0x000059AC
		public void method_14()
		{
			this.method_2();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000077C0 File Offset: 0x000059C0
		public void method_15(GStruct216 gstruct216_0)
		{
			this.method_43(gstruct216_0);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000077D4 File Offset: 0x000059D4
		internal string method_16()
		{
			return this.method_48();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000077E8 File Offset: 0x000059E8
		public bool vmethod_2(GStruct22 gstruct22_5)
		{
			return this.ulong_0 == gstruct22_5.ulong_0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00007804 File Offset: 0x00005A04
		internal void method_17()
		{
			this.method_46();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00007818 File Offset: 0x00005A18
		public bool method_18()
		{
			return this.method_23() == GEnum65.const_8 && (this.method_1() & 262144U) > 0U;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00007840 File Offset: 0x00005A40
		internal void method_19(GEnum77 genum77_0)
		{
			this.ulong_0 = ((this.ulong_0 & 72057594037927935UL) | (ulong)((ulong)((long)genum77_0 & 255L) << 56));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00007874 File Offset: 0x00005A74
		internal void method_20(uint uint_0)
		{
			this.ulong_0 = ((this.ulong_0 & 18442240478377148415UL) | ((ulong)uint_0 & 1048575UL) << 32);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000078A8 File Offset: 0x00005AA8
		public GStruct22(GStruct216 gstruct216_0, uint uint_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.ulong_0 = 0UL;
			this.method_3(gstruct216_0, uint_0, genum77_0, genum65_0);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000078D0 File Offset: 0x00005AD0
		public bool method_21()
		{
			return this.method_11() && this.method_1() == 0U;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000078F4 File Offset: 0x00005AF4
		internal void method_22(GEnum77 genum77_0)
		{
			this.method_47(genum77_0);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007908 File Offset: 0x00005B08
		public GEnum65 method_23()
		{
			return (GEnum65)(this.ulong_0 >> 52 & 15UL);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000792C File Offset: 0x00005B2C
		public bool method_24()
		{
			return this.method_23() == GEnum65.const_6;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007944 File Offset: 0x00005B44
		public void method_25()
		{
			this.method_17();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007958 File Offset: 0x00005B58
		public void method_26(GEnum65 genum65_0)
		{
			this.method_40(genum65_0);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000796C File Offset: 0x00005B6C
		public static GStruct22 smethod_0(ulong ulong_1)
		{
			return new GStruct22(ulong_1);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007984 File Offset: 0x00005B84
		public bool method_27()
		{
			return this.method_23() == GEnum65.const_3 || this.method_23() == GEnum65.const_4;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000079A8 File Offset: 0x00005BA8
		public bool method_28()
		{
			return this.method_23() == GEnum65.const_8;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000079C0 File Offset: 0x00005BC0
		public bool method_29()
		{
			return this.method_23() == GEnum65.const_3;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000079D8 File Offset: 0x00005BD8
		public void method_30(GStruct216 gstruct216_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_13(gstruct216_0, genum77_0, genum65_0);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000079F0 File Offset: 0x00005BF0
		public GStruct216 method_31()
		{
			return new GStruct216((uint)(this.ulong_0 & ulong.MaxValue));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007A18 File Offset: 0x00005C18
		public bool method_32()
		{
			return this.method_23() == GEnum65.const_4;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007A30 File Offset: 0x00005C30
		public bool method_33()
		{
			return GStruct216.smethod_0(this.method_31(), new GStruct216(0U)) && this.method_45() && this.method_1() == 0U;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007A64 File Offset: 0x00005C64
		public void method_34(GEnum77 genum77_0)
		{
			this.method_22(genum77_0);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007A78 File Offset: 0x00005C78
		internal void method_35(uint uint_0)
		{
			this.method_20(uint_0);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007A8C File Offset: 0x00005C8C
		internal void method_36(GEnum77 genum77_0)
		{
			this.method_19(genum77_0);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007AA0 File Offset: 0x00005CA0
		public int vmethod_3(GStruct22 gstruct22_5)
		{
			return this.ulong_0.CompareTo(gstruct22_5.ulong_0);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007AC0 File Offset: 0x00005CC0
		public static ulong smethod_1(GStruct22 gstruct22_5)
		{
			return gstruct22_5.ulong_0;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007AD8 File Offset: 0x00005CD8
		public static bool smethod_2(GStruct22 gstruct22_5, GStruct22 gstruct22_6)
		{
			return !GStruct22.smethod_3(gstruct22_5, gstruct22_6);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00007AF0 File Offset: 0x00005CF0
		public bool method_37()
		{
			return this.method_23() > GEnum65.const_0 && this.method_23() < GEnum65.const_11 && this.method_5() > GEnum77.const_0 && this.method_5() < GEnum77.const_5 && (this.method_23() != GEnum65.const_1 || (!GStruct216.smethod_0(this.method_31(), new GStruct216(0U)) && this.method_1() <= 4U)) && (this.method_23() != GEnum65.const_7 || (!GStruct216.smethod_0(this.method_31(), new GStruct216(0U)) && this.method_1() == 0U)) && (this.method_23() != GEnum65.const_3 || !GStruct216.smethod_0(this.method_31(), new GStruct216(0U)));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00007B94 File Offset: 0x00005D94
		public void method_38(uint uint_0)
		{
			this.method_35(uint_0);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00007BA8 File Offset: 0x00005DA8
		public void method_39(GEnum77 genum77_0)
		{
			this.method_36(genum77_0);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00007BBC File Offset: 0x00005DBC
		internal void method_40(GEnum65 genum65_0)
		{
			this.method_7(genum65_0);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007BD0 File Offset: 0x00005DD0
		internal void method_41(GStruct216 gstruct216_0, uint uint_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_4(gstruct216_0, uint_0, genum77_0, genum65_0);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007BEC File Offset: 0x00005DEC
		public bool method_42()
		{
			return this.method_23() == GEnum65.const_10;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007C04 File Offset: 0x00005E04
		public bool vmethod_4(object object_0)
		{
			return object_0 is GStruct22 && GStruct22.smethod_3(this, (GStruct22)object_0);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00007C30 File Offset: 0x00005E30
		internal void method_43(GStruct216 gstruct216_0)
		{
			this.method_6(gstruct216_0);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007C44 File Offset: 0x00005E44
		public bool method_44()
		{
			return this.method_23() == GEnum65.const_9;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00007C5C File Offset: 0x00005E5C
		public bool method_45()
		{
			return this.method_23() == GEnum65.const_10 || this.method_23() == GEnum65.const_4;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007C80 File Offset: 0x00005E80
		public GStruct22(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000077E8 File Offset: 0x000059E8
		public static bool smethod_3(GStruct22 gstruct22_5, GStruct22 gstruct22_6)
		{
			return gstruct22_5.ulong_0 == gstruct22_6.ulong_0;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00007C94 File Offset: 0x00005E94
		internal void method_46()
		{
			if (this.method_11())
			{
				this.method_38(0U);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00007CB0 File Offset: 0x00005EB0
		internal void method_47(GEnum77 genum77_0)
		{
			this.method_15(new GStruct216(0U));
			this.method_39(genum77_0);
			this.method_26(GEnum65.const_10);
			this.method_38(0U);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00007CE0 File Offset: 0x00005EE0
		internal string method_48()
		{
			return this.ulong_0.ToString();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00007CFC File Offset: 0x00005EFC
		internal void method_49(GStruct216 gstruct216_0, GEnum77 genum77_0, GEnum65 genum65_0)
		{
			this.method_15(gstruct216_0);
			this.method_39(genum77_0);
			this.method_26(genum65_0);
			if (genum65_0 == GEnum65.const_7 || genum65_0 == GEnum65.const_3)
			{
				this.method_38(0U);
			}
			else
			{
				this.method_38(1U);
			}
		}

		// Token: 0x04000104 RID: 260
		public static readonly GStruct22 gstruct22_0 = default(GStruct22);

		// Token: 0x04000105 RID: 261
		public static readonly GStruct22 gstruct22_1 = new GStruct22(new GStruct216(0U), 0U, GEnum77.const_0, GEnum65.const_0);

		// Token: 0x04000106 RID: 262
		public static readonly GStruct22 gstruct22_2 = new GStruct22(new GStruct216(0U), 0U, GEnum77.const_1, GEnum65.const_0);

		// Token: 0x04000107 RID: 263
		public static readonly GStruct22 gstruct22_3 = new GStruct22(new GStruct216(1U), 0U, GEnum77.const_0, GEnum65.const_0);

		// Token: 0x04000108 RID: 264
		public static readonly GStruct22 gstruct22_4 = new GStruct22(new GStruct216(2U), 0U, GEnum77.const_0, GEnum65.const_0);

		// Token: 0x04000109 RID: 265
		public ulong ulong_0;
	}
}
