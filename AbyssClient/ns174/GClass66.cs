using System;
using ns11;
using ns12;
using ns205;
using ns237;
using ns559;
using UnityEngine;

namespace ns174
{
	// Token: 0x0200011C RID: 284
	public class GClass66
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x00028468 File Offset: 0x00026668
		internal string method_0()
		{
			return this.string_0;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00028480 File Offset: 0x00026680
		internal void method_1()
		{
			this.gclass5_0.method_9();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00028498 File Offset: 0x00026698
		internal string method_2()
		{
			return this.string_1;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000284B0 File Offset: 0x000266B0
		internal void method_3(string string_3, string string_4, Color? nullable_0, Texture texture_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			this.method_12(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000284DC File Offset: 0x000266DC
		internal string method_4()
		{
			return this.method_5();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000284F0 File Offset: 0x000266F0
		public GClass66(string string_3, string string_4, Color? nullable_0 = null, Texture texture_0 = null, bool bool_0 = true, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			this.string_1 = "HorizontalLayoutGroup";
			this.method_11(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00028524 File Offset: 0x00026724
		internal string method_5()
		{
			return this.method_2();
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00028538 File Offset: 0x00026738
		internal void method_6()
		{
			this.method_10();
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002854C File Offset: 0x0002674C
		internal string method_7()
		{
			return this.method_0();
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00028560 File Offset: 0x00026760
		internal string method_8()
		{
			return this.method_7();
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00028574 File Offset: 0x00026774
		internal GClass5 method_9()
		{
			return this.gclass5_0;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002858C File Offset: 0x0002678C
		internal void method_10()
		{
			this.method_1();
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000285A0 File Offset: 0x000267A0
		internal void method_11(string string_3, string string_4, Color? nullable_0 = null, Texture texture_0 = null, bool bool_0 = true, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			this.method_3(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000285CC File Offset: 0x000267CC
		internal void method_12(string string_3, string string_4, Color? nullable_0, Texture texture_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			this.string_2 = "NestedPageButton";
			this.string_0 = GClass73.smethod_17(string_3, 0f, 0f);
			new GClass83(this.string_0, string_3, string.Empty, bool_0, bool_1, bool_2, null, "", null, false, bool_3);
			this.gclass5_0 = new GClass5(this.string_0, string_3, string_4, null, nullable_0, texture_0);
			GClass199.list_12.Add(this);
		}

		// Token: 0x0400071F RID: 1823
		protected GClass5 gclass5_0;

		// Token: 0x04000720 RID: 1824
		protected GClass6 gclass6_0;

		// Token: 0x04000721 RID: 1825
		protected string string_0;

		// Token: 0x04000722 RID: 1826
		protected string string_1;

		// Token: 0x04000723 RID: 1827
		protected string string_2;
	}
}
