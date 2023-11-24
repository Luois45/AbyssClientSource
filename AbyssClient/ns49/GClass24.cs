using System;
using System.Runtime.CompilerServices;
using ns13;
using ns205;
using ns237;
using ns241;
using ns559;
using ns9;
using UnityEngine;
using UnityEngine.UI;

namespace ns49
{
	// Token: 0x02000041 RID: 65
	public class GClass24
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00006FA8 File Offset: 0x000051A8
		internal string method_0()
		{
			return this.method_17();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00006FBC File Offset: 0x000051BC
		private void method_1()
		{
			this.method_9();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00006FD0 File Offset: 0x000051D0
		internal GClass7 method_2()
		{
			return this.gclass7_0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00006FE8 File Offset: 0x000051E8
		internal string method_3()
		{
			return this.string_0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007000 File Offset: 0x00005200
		public GClass24(string string_3, string string_4, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = string_3;
			this.method_19(string_4, string_5, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000702C File Offset: 0x0000522C
		private void method_4(string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_18(GClass73.smethod_2(GClass84.smethod_195().Find(this.string_1)), string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00007060 File Offset: 0x00005260
		private void method_5(string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_4(string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007084 File Offset: 0x00005284
		private void method_6(Transform transform_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.string_2 = "NestedButton";
			this.string_0 = GClass73.smethod_17(this.string_1 + string_3, 0f, 0f);
			new GClass83(this.string_0, string_3, this.string_1, true, false, false, null, "", null, false, bool_0);
			this.gclass7_0 = new GClass7(transform_0, this.string_1, string_3, null, string_4, nullable_0, nullable_1, texture_0);
			GClass84.smethod_243(this.gclass7_0.method_12().GetComponent<Button>(), new Action(this.method_11));
			GClass199.list_1.Add(this);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007124 File Offset: 0x00005324
		internal string method_7()
		{
			return this.method_15();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007138 File Offset: 0x00005338
		private void method_8(GClass3 gclass3_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_21(gclass3_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00007160 File Offset: 0x00005360
		public GClass24(GClass3 gclass3_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass3_0.method_3();
			this.method_14(gclass3_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007190 File Offset: 0x00005390
		private void method_9()
		{
			GClass73.smethod_1(this.string_0);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000071A8 File Offset: 0x000053A8
		internal void method_10()
		{
			this.method_12();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000071BC File Offset: 0x000053BC
		[CompilerGenerated]
		private void method_11()
		{
			this.method_1();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000071D0 File Offset: 0x000053D0
		internal void method_12()
		{
			this.method_13();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000071E4 File Offset: 0x000053E4
		internal void method_13()
		{
			this.gclass7_0.method_9();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000071FC File Offset: 0x000053FC
		private void method_14(GClass3 gclass3_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_8(gclass3_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007224 File Offset: 0x00005424
		internal string method_15()
		{
			return this.method_3();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00007238 File Offset: 0x00005438
		internal string method_16()
		{
			return this.method_0();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000724C File Offset: 0x0000544C
		internal string method_17()
		{
			return this.string_1;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00007264 File Offset: 0x00005464
		private void method_18(Transform transform_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_20(transform_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000728C File Offset: 0x0000548C
		private void method_19(string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_5(string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000072B0 File Offset: 0x000054B0
		private void method_20(Transform transform_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_6(transform_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000072D8 File Offset: 0x000054D8
		private void method_21(GClass3 gclass3_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_18(gclass3_0.method_12().transform, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x040000E9 RID: 233
		protected GClass7 gclass7_0;

		// Token: 0x040000EA RID: 234
		protected string string_0;

		// Token: 0x040000EB RID: 235
		protected string string_1;

		// Token: 0x040000EC RID: 236
		protected string string_2;
	}
}
