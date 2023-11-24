using System;
using ns174;
using ns205;
using ns241;
using ns290;
using ns49;
using ns559;
using ns8;
using UnityEngine;
using UnityEngine.UI;

namespace ns17
{
	// Token: 0x020003B0 RID: 944
	public class GClass11 : GClass2
	{
		// Token: 0x06004A3B RID: 19003 RVA: 0x0011B698 File Offset: 0x00119898
		internal void method_17(float float_0, float float_1)
		{
			this.method_22(float_0, float_1);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0011B6B0 File Offset: 0x001198B0
		public GClass11(string string_3, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_24(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0011B6E0 File Offset: 0x001198E0
		public GClass11(string string_3, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_24(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0011B70C File Offset: 0x0011990C
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_23(color_2, bool_0);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0011B724 File Offset: 0x00119924
		private void method_18(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_26(transform_0, float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0011B74C File Offset: 0x0011994C
		public GClass11(GClass95 gclass95_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_24(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0011B784 File Offset: 0x00119984
		private void method_19(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.string_1 = "ColorImage";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_29(), transform_0, true);
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
			this.method_20(float_0, float_1);
			if (nullable_0 != null)
			{
				this.vmethod_1(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<RawImage>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_0(texture_0);
			}
			base.method_6(true);
			GClass199.list_9.Add(this);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0011B874 File Offset: 0x00119A74
		internal void method_20(float float_0, float float_1)
		{
			this.method_17(float_0, float_1);
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0011B88C File Offset: 0x00119A8C
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_21(texture_0);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x0011B8A0 File Offset: 0x00119AA0
		internal void method_21(Texture texture_0)
		{
			this.method_27(texture_0);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0011B8B4 File Offset: 0x00119AB4
		internal void method_22(float float_0, float float_1)
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

		// Token: 0x06004A46 RID: 19014 RVA: 0x0011B97C File Offset: 0x00119B7C
		public GClass11(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_24(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0011B9AC File Offset: 0x00119BAC
		public GClass11(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_24(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0011B9DC File Offset: 0x00119BDC
		public GClass11(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_24(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0011BA0C File Offset: 0x00119C0C
		internal void method_23(Color color_2, bool bool_0)
		{
			this.method_28(color_2, bool_0);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0011BA24 File Offset: 0x00119C24
		private void method_24(float float_0, float float_1, float float_2, float float_3, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_25(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0011BA48 File Offset: 0x00119C48
		private void method_25(float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_29(float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x0011BA6C File Offset: 0x00119C6C
		private void method_26(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_19(transform_0, float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_27(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x0011BA94 File Offset: 0x00119C94
		public GClass11(GClass24 gclass24_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_24(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x000F777C File Offset: 0x000F597C
		internal void method_28(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_0)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x0011BACC File Offset: 0x00119CCC
		public GClass11(GClass66 gclass66_0, float float_0, float float_1, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_24(float_0, float_1, 1f, 1f, nullable_0, texture_0);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x0011BB04 File Offset: 0x00119D04
		private void method_29(float float_0, float float_1, float float_2, float float_3, Color? nullable_0, Texture texture_0)
		{
			this.method_18(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, nullable_0, texture_0);
		}
	}
}
