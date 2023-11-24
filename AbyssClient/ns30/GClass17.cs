using System;
using ns244;
using ns410;
using ns53;
using ns59;
using ns61;
using UnityEngine;

namespace ns30
{
	// Token: 0x02000022 RID: 34
	public class GClass17
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0000533C File Offset: 0x0000353C
		internal void method_0()
		{
			this.method_10();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005350 File Offset: 0x00003550
		internal string method_1()
		{
			return this.method_9();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005364 File Offset: 0x00003564
		internal string method_2()
		{
			return this.method_3();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005378 File Offset: 0x00003578
		internal string method_3()
		{
			return this.method_7();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000538C File Offset: 0x0000358C
		internal string method_4()
		{
			return this.string_0;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000053A4 File Offset: 0x000035A4
		internal void method_5(string string_3, string string_4, Color? nullable_0 = null, Texture texture_0 = null, bool bool_0 = true, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			this.method_11(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000053D0 File Offset: 0x000035D0
		internal GClass32 method_6()
		{
			return this.gclass32_0;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000053E8 File Offset: 0x000035E8
		internal string method_7()
		{
			return this.string_1;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005400 File Offset: 0x00003600
		public GClass17(string string_3, string string_4, Color? nullable_0 = null, Texture texture_0 = null, bool bool_0 = true, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			this.string_1 = "HorizontalLayoutGroup";
			this.method_5(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00005434 File Offset: 0x00003634
		internal void method_8()
		{
			this.method_0();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005448 File Offset: 0x00003648
		internal string method_9()
		{
			return this.method_4();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000545C File Offset: 0x0000365C
		internal void method_10()
		{
			this.gclass32_0.method_0();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005474 File Offset: 0x00003674
		internal void method_11(string string_3, string string_4, Color? nullable_0, Texture texture_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			this.method_12(string_3, string_4, nullable_0, texture_0, bool_0, bool_1, bool_2, bool_3);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000054A0 File Offset: 0x000036A0
		internal void method_12(string string_3, string string_4, Color? nullable_0, Texture texture_0, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
		{
			this.string_2 = "NestedPageButton";
			this.string_0 = GClass124.smethod_3(string_3, 0f, 0f);
			new GClass89(this.string_0, string_3, "", bool_0, bool_1, bool_2, null, "", null, false, bool_3, true);
			this.gclass32_0 = new GClass32(this.string_0, string_3, string_4, null, nullable_0, texture_0);
			GClass25.list_12.Add(this);
		}

		// Token: 0x0400007E RID: 126
		protected GClass32 gclass32_0;

		// Token: 0x0400007F RID: 127
		protected GClass30 gclass30_0;

		// Token: 0x04000080 RID: 128
		protected string string_0;

		// Token: 0x04000081 RID: 129
		protected string string_1;

		// Token: 0x04000082 RID: 130
		protected string string_2;
	}
}
