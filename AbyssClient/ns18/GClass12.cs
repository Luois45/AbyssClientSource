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

namespace ns18
{
	// Token: 0x020003B3 RID: 947
	public class GClass12 : GClass2
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x000F777C File Offset: 0x000F597C
		internal void method_17(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_0)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0011BC5C File Offset: 0x00119E5C
		private void method_18(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "Text";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_0(), transform_0, true);
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
			this.method_23(float_0, float_1);
			this.method_27(string_3);
			if (nullable_0 != null)
			{
				this.vmethod_1(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<RawImage>().color;
			}
			if (nullable_1 != null)
			{
				this.vmethod_2(nullable_1.Value, true);
			}
			else
			{
				this.color_1 = this.gameObject_0.GetComponentInChildren<Text>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_0(texture_0);
			}
			base.method_6(true);
			GClass199.list_6.Add(this);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0011BD94 File Offset: 0x00119F94
		public GClass12(string string_3, float float_0, float float_1, string string_4, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_30(float_0, float_1, 1f, 1f, string_4, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x0011BDCC File Offset: 0x00119FCC
		internal void method_19(Color color_2, bool bool_0)
		{
			this.method_33(color_2, bool_0);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x0011BDE4 File Offset: 0x00119FE4
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_18(transform_0, float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00080818 File Offset: 0x0007EA18
		internal void method_21(string string_3)
		{
			this.gameObject_0.GetComponentInChildren<Text>().text = string_3;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0011BE18 File Offset: 0x0011A018
		public GClass12(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_30(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0011B8B4 File Offset: 0x00119AB4
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

		// Token: 0x06004A66 RID: 19046 RVA: 0x0011BE50 File Offset: 0x0011A050
		internal void method_23(float float_0, float float_1)
		{
			this.method_29(float_0, float_1);
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x0011BE68 File Offset: 0x0011A068
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_24(texture_0);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0011BE7C File Offset: 0x0011A07C
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_32(color_2, bool_0);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0011BE94 File Offset: 0x0011A094
		public GClass12(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_30(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0011BECC File Offset: 0x0011A0CC
		internal void method_24(Texture texture_0)
		{
			this.method_25(texture_0);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0011BEE0 File Offset: 0x0011A0E0
		internal override void vmethod_2(Color color_2, bool bool_0 = true)
		{
			this.method_19(color_2, bool_0);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_25(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
		public GClass12(GClass66 gclass66_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_30(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x0011BF34 File Offset: 0x0011A134
		private void method_26(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_34(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0011BF64 File Offset: 0x0011A164
		internal void method_27(string string_3)
		{
			this.method_28(string_3);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0011BF78 File Offset: 0x0011A178
		internal void method_28(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x0011BF8C File Offset: 0x0011A18C
		public GClass12(GClass24 gclass24_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_30(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x0011BFC8 File Offset: 0x0011A1C8
		internal void method_29(float float_0, float float_1)
		{
			this.method_22(float_0, float_1);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0011BFE0 File Offset: 0x0011A1E0
		private void method_30(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_26(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0011C010 File Offset: 0x0011A210
		private void method_31(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_20(transform_0, float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0011C044 File Offset: 0x0011A244
		public GClass12(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_30(float_0, float_1, float_2, float_3, string_4, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x0011C074 File Offset: 0x0011A274
		public GClass12(GClass95 gclass95_0, float float_0, float float_1, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_30(float_0, float_1, 1f, 1f, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x0011C0B0 File Offset: 0x0011A2B0
		public GClass12(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0 = false, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_30(float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x0011C0E8 File Offset: 0x0011A2E8
		internal void method_32(Color color_2, bool bool_0)
		{
			this.method_17(color_2, bool_0);
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x000808F4 File Offset: 0x0007EAF4
		internal void method_33(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponentInChildren<Text>().color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x0011C100 File Offset: 0x0011A300
		private void method_34(float float_0, float float_1, float float_2, float float_3, string string_3, bool bool_0, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_31(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, bool_0, nullable_0, nullable_1, texture_0);
		}
	}
}
