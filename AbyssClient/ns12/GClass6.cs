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

namespace ns12
{
	// Token: 0x02000244 RID: 580
	public class GClass6 : GClass2
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x000894A0 File Offset: 0x000876A0
		private void method_17(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_19(transform_0, float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000894D8 File Offset: 0x000876D8
		public GClass6(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_23(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00089510 File Offset: 0x00087710
		internal void method_18(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0008952C File Offset: 0x0008772C
		private void method_19(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "SingleButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_27(), transform_0, true);
			this.text_0 = this.gameObject_0.GetComponentInChildren<Text>(true);
			this.button_0 = this.gameObject_0.GetComponent<Button>();
			this.uiTooltip_0 = this.gameObject_0.GetComponent<UiTooltip>();
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
			base.method_4(float_0, float_1);
			this.method_20(string_3);
			base.method_7(string_4);
			this.method_22(action_0);
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
			GClass199.list_0.Add(this);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00089698 File Offset: 0x00087898
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_28(texture_0);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000896AC File Offset: 0x000878AC
		internal void method_20(string string_3)
		{
			this.method_36(string_3);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000896C0 File Offset: 0x000878C0
		internal void method_21(Action action_0)
		{
			this.method_25(action_0);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000896D4 File Offset: 0x000878D4
		internal void method_22(Action action_0)
		{
			this.method_21(action_0);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000896E8 File Offset: 0x000878E8
		public GClass6(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_23(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00089720 File Offset: 0x00087920
		public GClass6(string string_3, float float_0, float float_1, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_23(float_0, float_1, 1f, 1f, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00089758 File Offset: 0x00087958
		private void method_23(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_29(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0008978C File Offset: 0x0008798C
		internal void method_24(Color color_2, bool bool_0)
		{
			if (bool_0)
			{
				this.color_0 = color_2;
			}
			Selectable selectable = this.button_0;
			ColorBlock colors = default(ColorBlock);
			colors.colorMultiplier = 1f;
			colors.disabledColor = Color.grey;
			colors.highlightedColor = color_2 * 1.5f;
			colors.normalColor = color_2 / 1.5f;
			colors.pressedColor = Color.grey * 1.5f;
			selectable.colors = colors;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0008980C File Offset: 0x00087A0C
		internal void method_25(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00089828 File Offset: 0x00087A28
		internal void method_26(string string_3)
		{
			this.text_0.text = string_3;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00089844 File Offset: 0x00087A44
		internal override void vmethod_2(Color color_2, bool bool_0 = true)
		{
			this.method_31(color_2, bool_0);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_27(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0008985C File Offset: 0x00087A5C
		internal void method_28(Texture texture_0)
		{
			this.method_27(texture_0);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00089870 File Offset: 0x00087A70
		private void method_29(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_37(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000898A4 File Offset: 0x00087AA4
		public GClass6(GClass95 gclass95_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_23(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000898E4 File Offset: 0x00087AE4
		internal void method_30(Color color_2, bool bool_0)
		{
			this.method_24(color_2, bool_0);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000898FC File Offset: 0x00087AFC
		internal void method_31(Color color_2, bool bool_0)
		{
			this.method_35(color_2, bool_0);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00089914 File Offset: 0x00087B14
		public GClass6(GClass66 gclass66_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_23(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00089954 File Offset: 0x00087B54
		private void method_32(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_17(transform_0, float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0008998C File Offset: 0x00087B8C
		internal void method_33(Action action_0)
		{
			this.method_18(action_0);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000899A0 File Offset: 0x00087BA0
		public GClass6(GClass24 gclass24_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_23(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000899E0 File Offset: 0x00087BE0
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_30(color_2, bool_0);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000899F8 File Offset: 0x00087BF8
		public GClass6(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_23(float_0, float_1, float_2, float_3, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00089A2C File Offset: 0x00087C2C
		internal void method_34(Action action_0)
		{
			this.method_33(action_0);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00089A40 File Offset: 0x00087C40
		internal void method_35(Color color_2, bool bool_0)
		{
			this.text_0.color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00089A64 File Offset: 0x00087C64
		public GClass6(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_23(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00089A9C File Offset: 0x00087C9C
		internal void method_36(string string_3)
		{
			this.method_26(string_3);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00089AB0 File Offset: 0x00087CB0
		private void method_37(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_32(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x04000F70 RID: 3952
		private Text text_0;

		// Token: 0x04000F71 RID: 3953
		private Button button_0;
	}
}
