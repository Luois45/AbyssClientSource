using System;
using System.Runtime.CompilerServices;
using ns241;
using ns244;
using ns295;
using ns30;
using ns410;
using ns53;
using ns59;
using UnityEngine;
using UnityEngine.UI;

namespace ns302
{
	// Token: 0x0200026C RID: 620
	public class GClass99
	{
		// Token: 0x06001C88 RID: 7304 RVA: 0x00090428 File Offset: 0x0008E628
		internal string method_0()
		{
			return this.method_1();
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0009043C File Offset: 0x0008E63C
		public GClass99(GClass97 gclass97_0, float float_0, float float_1, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass97_0.method_12();
			this.method_3(float_0, float_1, 1f, 1f, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00090480 File Offset: 0x0008E680
		public GClass99(string string_3, float float_0, float float_1, string string_4, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = string_3;
			this.method_3(float_0, float_1, 1f, 1f, string_4, string_5, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x000904BC File Offset: 0x0008E6BC
		internal string method_1()
		{
			return this.method_6();
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000904D0 File Offset: 0x0008E6D0
		internal void method_2(float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Color? nullable_2, Color? nullable_3, Texture texture_0, bool bool_0)
		{
			this.method_15(float_0, float_1, float_2, float_3, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0009050C File Offset: 0x0008E70C
		internal void method_3(float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_2(float_0, float_1, float_2, float_3, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00090548 File Offset: 0x0008E748
		internal string method_4()
		{
			return this.method_10();
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0009055C File Offset: 0x0008E75C
		public GClass99(GClass99 gclass99_0, float float_0, float float_1, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass99_0.method_0();
			this.method_3(float_0, float_1, 1f, 1f, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000905A0 File Offset: 0x0008E7A0
		internal void method_5()
		{
			this.method_8();
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000905B4 File Offset: 0x0008E7B4
		internal string method_6()
		{
			return this.string_0;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000905CC File Offset: 0x0008E7CC
		private void method_7()
		{
			GClass124.smethod_24(this.string_0);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000905E4 File Offset: 0x0008E7E4
		public GClass99(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass17_0.method_1();
			this.method_3(float_0, float_1, float_2, float_3, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00090620 File Offset: 0x0008E820
		internal void method_8()
		{
			this.method_13();
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00090634 File Offset: 0x0008E834
		public GClass99(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = string_3;
			this.method_3(float_0, float_1, float_2, float_3, string_4, string_5, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0009066C File Offset: 0x0008E86C
		public GClass99(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass97_0.method_12();
			this.method_3(float_0, float_1, float_2, float_3, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000906A8 File Offset: 0x0008E8A8
		[CompilerGenerated]
		private void method_9()
		{
			this.method_14();
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000906BC File Offset: 0x0008E8BC
		internal string method_10()
		{
			return this.string_1;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000906D4 File Offset: 0x0008E8D4
		public GClass99(GClass17 gclass17_0, float float_0, float float_1, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass17_0.method_1();
			this.method_3(float_0, float_1, 1f, 1f, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00090718 File Offset: 0x0008E918
		internal string method_11()
		{
			return this.method_4();
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0009072C File Offset: 0x0008E92C
		internal GClass30 method_12()
		{
			return this.gclass30_0;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00090744 File Offset: 0x0008E944
		internal void method_13()
		{
			this.gclass30_0.method_0();
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0009075C File Offset: 0x0008E95C
		public GClass99(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Color? nullable_2 = null, Color? nullable_3 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass99_0.method_0();
			this.method_3(float_0, float_1, float_2, float_3, string_3, string_4, nullable_0, nullable_1, nullable_2, nullable_3, texture_0, bool_0);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00090798 File Offset: 0x0008E998
		private void method_14()
		{
			this.method_7();
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000907AC File Offset: 0x0008E9AC
		internal void method_15(float float_0, float float_1, float float_2, float float_3, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Color? nullable_2, Color? nullable_3, Texture texture_0, bool bool_0)
		{
			this.string_2 = "NestedButton";
			this.string_0 = GClass124.smethod_3(this.string_1 + string_3, float_0, float_1);
			new GClass89(this.string_0, string_3, this.string_1, true, false, false, null, "", null, false, bool_0, true);
			this.gclass30_0 = new GClass30(this.string_1, float_0, float_1, float_2, float_3, string_3, null, string_4, nullable_0, nullable_1, texture_0);
			GClass84.smethod_243(this.gclass30_0.method_3().GetComponent<Button>(), new Action(this.method_9));
			if (nullable_3 == null)
			{
				nullable_3 = new Color?(Color.yellow);
			}
			GClass25.list_11.Add(this);
		}

		// Token: 0x040010D6 RID: 4310
		protected GClass30 gclass30_0;

		// Token: 0x040010D7 RID: 4311
		protected string string_0;

		// Token: 0x040010D8 RID: 4312
		protected string string_1;

		// Token: 0x040010D9 RID: 4313
		protected string string_2;
	}
}
