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

namespace ns63
{
	// Token: 0x0200033F RID: 831
	public class GClass34 : GClass26
	{
		// Token: 0x060046C0 RID: 18112 RVA: 0x00109410 File Offset: 0x00107610
		public GClass34(string string_3, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_26(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x0010943C File Offset: 0x0010763C
		public GClass34(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_26(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x0010946C File Offset: 0x0010766C
		internal void method_17(float float_0, float float_1)
		{
			this.method_28(float_0, float_1);
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x00023248 File Offset: 0x00021448
		internal void method_18(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_0)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x00109484 File Offset: 0x00107684
		private void method_19(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_23(transform_0, float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x001094AC File Offset: 0x001076AC
		internal void method_20(Texture texture_0)
		{
			this.method_27(texture_0);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x001094C0 File Offset: 0x001076C0
		internal void method_21(Color color_2, bool bool_0)
		{
			this.method_18(color_2, bool_0);
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x001094D8 File Offset: 0x001076D8
		public GClass34(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_26(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x00109508 File Offset: 0x00107708
		private void method_22(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.string_1 = "ColorImage";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_13(), transform_0, true);
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
			this.method_17(float_0, float_1);
			if (nullable_0 != null)
			{
				this.vmethod_0(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<RawImage>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_2(texture_0);
			}
			base.method_11(true);
			GClass25.list_9.Add(this);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x001095F8 File Offset: 0x001077F8
		private void method_23(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_22(transform_0, float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x00109620 File Offset: 0x00107820
		public GClass34(GClass99 gclass99_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_26(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x00022D68 File Offset: 0x00020F68
		internal void method_24(float float_0, float float_1)
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

		// Token: 0x060046CC RID: 18124 RVA: 0x00109658 File Offset: 0x00107858
		private void method_25(float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_29(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0010967C File Offset: 0x0010787C
		private void method_26(float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_25(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x001096A0 File Offset: 0x001078A0
		public GClass34(GClass97 gclass97_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_26(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_27(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x001096D8 File Offset: 0x001078D8
		public GClass34(string string_3, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_26(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00109708 File Offset: 0x00107908
		public GClass34(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_26(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x00109738 File Offset: 0x00107938
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_20(texture_0);
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x0010974C File Offset: 0x0010794C
		internal override void vmethod_0(Color color_2, bool bool_0 = true)
		{
			this.method_21(color_2, bool_0);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x00109764 File Offset: 0x00107964
		public GClass34(GClass17 gclass17_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_26(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0010979C File Offset: 0x0010799C
		internal void method_28(float float_0, float float_1)
		{
			this.method_24(float_0, float_1);
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x001097B4 File Offset: 0x001079B4
		private void method_29(float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_19(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}
	}
}
