using System;
using ns241;
using ns295;
using ns30;
using ns302;
using ns410;
using ns53;
using ns55;
using UnityEngine;
using UnityEngine.UI;

namespace ns57
{
	// Token: 0x02000115 RID: 277
	public class GClass28 : GClass26
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x00022CF8 File Offset: 0x00020EF8
		internal override void vmethod_0(Color color_2, bool bool_0 = true)
		{
			this.method_23(color_2, bool_0);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00022D10 File Offset: 0x00020F10
		public GClass28(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_27(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00022D48 File Offset: 0x00020F48
		internal void method_17(string string_3)
		{
			this.gameObject_0.GetComponentInChildren<Text>().text = string_3;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00022D68 File Offset: 0x00020F68
		internal void method_18(float float_0, float float_1)
		{
			this.gameObject_0.GetComponent<RectTransform>().anchoredPosition = Vector2.right * (128f + 256f * (float_0 + (float)this.int_0[0])) + Vector2.down * (128f + 256f * (float_1 + (float)this.int_0[1]));
			this.string_2 = string.Concat(new string[]
			{
				"(",
				float_0.ToString(),
				",",
				float_1.ToString(),
				")"
			});
			this.gameObject_0.name = this.string_0 + "/" + this.string_1 + this.string_2;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00022E30 File Offset: 0x00021030
		internal void method_19(float float_0, float float_1)
		{
			this.method_18(float_0, float_1);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00022E48 File Offset: 0x00021048
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "Text";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_4(), transform_0, true);
			this.gameObject_0.GetComponent<RawImage>().enabled = bool_0;
			if (float_2 != 1f || float_3 != 1f)
			{
				RectTransform component = this.gameObject_0.GetComponent<RectTransform>();
				if (component)
				{
					Vector2 sizeDelta = component.sizeDelta;
					sizeDelta.x *= float_2;
					sizeDelta.y *= float_3;
					component.sizeDelta = sizeDelta;
				}
			}
			this.int_0[0] = -1;
			this.int_0[1] = 0;
			this.method_29(float_0, float_1);
			this.method_28(string_3);
			if (nullable_0 != null)
			{
				this.vmethod_0(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<RawImage>().color;
			}
			if (nullable_1 != null)
			{
				this.vmethod_1(nullable_1.Value, true);
			}
			else
			{
				this.color_1 = this.gameObject_0.GetComponentInChildren<Text>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_2(texture_0);
			}
			base.method_11(true);
			GClass25.list_6.Add(this);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00022F80 File Offset: 0x00021180
		public GClass28(GClass17 gclass17_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_27(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00022FBC File Offset: 0x000211BC
		internal void method_21(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponentInChildren<Text>().color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00022FE4 File Offset: 0x000211E4
		private void method_22(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_34(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00023014 File Offset: 0x00021214
		internal void method_23(Color color_2, bool bool_0)
		{
			this.method_32(color_2, bool_0);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_24(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0002304C File Offset: 0x0002124C
		public GClass28(string string_3, float float_0, float float_1, string string_4, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_27(float_0, float_1, 1f, 1f, string_4, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00023084 File Offset: 0x00021284
		internal void method_25(Texture texture_0)
		{
			this.method_24(texture_0);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00023098 File Offset: 0x00021298
		public GClass28(GClass99 gclass99_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_27(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000230D4 File Offset: 0x000212D4
		private void method_26(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_20(transform_0, float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00023108 File Offset: 0x00021308
		public GClass28(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_27(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00023140 File Offset: 0x00021340
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_25(texture_0);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00023154 File Offset: 0x00021354
		private void method_27(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_22(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00023184 File Offset: 0x00021384
		internal void method_28(string string_3)
		{
			this.method_31(string_3);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00023198 File Offset: 0x00021398
		public GClass28(GClass97 gclass97_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_27(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000231D4 File Offset: 0x000213D4
		internal void method_29(float float_0, float float_1)
		{
			this.method_19(float_0, float_1);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000231EC File Offset: 0x000213EC
		public GClass28(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_27(float_0, float_1, float_2, float_3, string_4, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0002321C File Offset: 0x0002141C
		internal void method_30(Color color_2, bool bool_0)
		{
			this.method_21(color_2, bool_0);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00023234 File Offset: 0x00021434
		internal void method_31(string string_3)
		{
			this.method_17(string_3);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00023248 File Offset: 0x00021448
		internal void method_32(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_0)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00023270 File Offset: 0x00021470
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_30(color_2, bool_0);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00023288 File Offset: 0x00021488
		private void method_33(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_26(transform_0, float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000232BC File Offset: 0x000214BC
		public GClass28(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_27(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000232F4 File Offset: 0x000214F4
		private void method_34(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_33(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}
	}
}
