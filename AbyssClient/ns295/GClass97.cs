using System;
using System.Runtime.CompilerServices;
using ns241;
using ns244;
using ns410;
using ns53;
using ns56;
using ns65;
using UnityEngine;
using UnityEngine.UI;

namespace ns295
{
	// Token: 0x0200025F RID: 607
	public class GClass97
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x0008E6A0 File Offset: 0x0008C8A0
		internal void method_0()
		{
			this.method_4();
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0008E6B4 File Offset: 0x0008C8B4
		private void method_1(string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_13(string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0008E6D8 File Offset: 0x0008C8D8
		private void method_2(GClass27 gclass27_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_8(gclass27_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0008E700 File Offset: 0x0008C900
		internal GClass36 method_3()
		{
			return this.gclass36_0;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0008E718 File Offset: 0x0008C918
		internal void method_4()
		{
			this.gclass36_0.method_0();
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0008E730 File Offset: 0x0008C930
		public GClass97(GClass27 gclass27_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = gclass27_0.method_14();
			this.method_2(gclass27_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0008E760 File Offset: 0x0008C960
		private void method_5()
		{
			GClass124.smethod_24(this.string_0);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0008E778 File Offset: 0x0008C978
		internal string method_6()
		{
			return this.string_0;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0008E790 File Offset: 0x0008C990
		internal void method_7()
		{
			this.method_0();
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0008E7A4 File Offset: 0x0008C9A4
		private void method_8(GClass27 gclass27_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_21(gclass27_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0008E7CC File Offset: 0x0008C9CC
		private void method_9(Transform transform_0, string string_3, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.method_15(transform_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0008E7F4 File Offset: 0x0008C9F4
		public GClass97(string string_3, string string_4, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null, bool bool_0 = false)
		{
			this.string_1 = string_3;
			this.method_1(string_4, string_5, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0008E820 File Offset: 0x0008CA20
		internal string method_10()
		{
			return this.method_11();
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0008E834 File Offset: 0x0008CA34
		internal string method_11()
		{
			return this.string_1;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0008E84C File Offset: 0x0008CA4C
		internal string method_12()
		{
			return this.method_18();
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0008E860 File Offset: 0x0008CA60
		private void method_13(string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_19(string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0008E884 File Offset: 0x0008CA84
		[CompilerGenerated]
		private void method_14()
		{
			this.method_20();
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0008E898 File Offset: 0x0008CA98
		private void method_15(Transform transform_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_17(transform_0, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0008E8C0 File Offset: 0x0008CAC0
		internal string method_16()
		{
			return this.method_10();
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0008E8D4 File Offset: 0x0008CAD4
		private void method_17(Transform transform_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.string_2 = "NestedButton";
			this.string_0 = GClass124.smethod_3(this.string_1 + string_3, 0f, 0f);
			new GClass89(this.string_0, string_3, this.string_1, true, false, false, null, "", null, false, bool_0, true);
			this.gclass36_0 = new GClass36(transform_0, this.string_1, string_3, null, string_4, nullable_0, nullable_1, texture_0);
			GClass84.smethod_243(this.gclass36_0.method_3().GetComponent<Button>(), new Action(this.method_14));
			GClass25.list_1.Add(this);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0008E978 File Offset: 0x0008CB78
		internal string method_18()
		{
			return this.method_6();
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0008E98C File Offset: 0x0008CB8C
		private void method_19(string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_9(GClass124.smethod_8(GClass84.smethod_195().Find(this.string_1)), string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0008E9C0 File Offset: 0x0008CBC0
		private void method_20()
		{
			this.method_5();
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
		private void method_21(GClass27 gclass27_0, string string_3, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0, bool bool_0)
		{
			this.method_9(gclass27_0.method_3().transform, string_3, string_4, nullable_0, nullable_1, texture_0, bool_0);
		}

		// Token: 0x0400107D RID: 4221
		protected GClass36 gclass36_0;

		// Token: 0x0400107E RID: 4222
		protected string string_0;

		// Token: 0x0400107F RID: 4223
		protected string string_1;

		// Token: 0x04001080 RID: 4224
		protected string string_2;
	}
}
