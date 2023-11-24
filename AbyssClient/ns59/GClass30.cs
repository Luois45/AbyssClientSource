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

namespace ns59
{
	// Token: 0x02000231 RID: 561
	public class GClass30 : GClass26
	{
		// Token: 0x06001903 RID: 6403 RVA: 0x00081D94 File Offset: 0x0007FF94
		public GClass30(GClass17 gclass17_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_34(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		internal void method_17(Action action_0)
		{
			this.method_27(action_0);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		internal void method_18(Texture texture_0)
		{
			this.method_36(texture_0);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00081DFC File Offset: 0x0007FFFC
		internal void method_19(Action action_0)
		{
			this.method_32(action_0);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00081E10 File Offset: 0x00080010
		internal void method_20(Action action_0)
		{
			this.method_17(action_0);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00081E24 File Offset: 0x00080024
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_18(texture_0);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00081E38 File Offset: 0x00080038
		public GClass30(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_34(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00081E70 File Offset: 0x00080070
		public GClass30(GClass99 gclass99_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_34(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00081EB0 File Offset: 0x000800B0
		internal void method_21(string string_3)
		{
			this.text_0.text = string_3;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00081ECC File Offset: 0x000800CC
		private void method_22(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_28(transform_0, float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00081F04 File Offset: 0x00080104
		private void method_23(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_22(transform_0, float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00081F3C File Offset: 0x0008013C
		internal void method_24(Color color_2, bool bool_0)
		{
			this.method_31(color_2, bool_0);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00081F54 File Offset: 0x00080154
		internal void method_25(Color color_2, bool bool_0)
		{
			this.text_0.color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00081F78 File Offset: 0x00080178
		private void method_26(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_37(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00081FAC File Offset: 0x000801AC
		internal void method_27(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00081FC8 File Offset: 0x000801C8
		private void method_28(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "SingleButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_31(), transform_0, true);
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
			base.method_15(float_0, float_1);
			this.method_30(string_3);
			base.method_10(string_4);
			this.method_20(action_0);
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
			GClass25.list_0.Add(this);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00082134 File Offset: 0x00080334
		public GClass30(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_34(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0008216C File Offset: 0x0008036C
		public GClass30(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_34(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000821A4 File Offset: 0x000803A4
		public GClass30(GClass97 gclass97_0, float float_0, float float_1, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_34(float_0, float_1, 1f, 1f, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000821E4 File Offset: 0x000803E4
		internal void method_29(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000821F8 File Offset: 0x000803F8
		internal void method_30(string string_3)
		{
			this.method_29(string_3);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0008220C File Offset: 0x0008040C
		internal void method_31(Color color_2, bool bool_0)
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

		// Token: 0x06001919 RID: 6425 RVA: 0x0008228C File Offset: 0x0008048C
		internal void method_32(Action action_0)
		{
			this.method_33(action_0);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000822A0 File Offset: 0x000804A0
		internal override void vmethod_0(Color color_2, bool bool_0 = true)
		{
			this.method_24(color_2, bool_0);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000822B8 File Offset: 0x000804B8
		internal void method_33(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000822D4 File Offset: 0x000804D4
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_35(color_2, bool_0);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000822EC File Offset: 0x000804EC
		private void method_34(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_26(float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00082320 File Offset: 0x00080520
		public GClass30(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_34(float_0, float_1, float_2, float_3, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00082354 File Offset: 0x00080554
		public GClass30(string string_3, float float_0, float float_1, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_34(float_0, float_1, 1f, 1f, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0008238C File Offset: 0x0008058C
		internal void method_35(Color color_2, bool bool_0)
		{
			this.method_25(color_2, bool_0);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_36(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000823A4 File Offset: 0x000805A4
		private void method_37(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_23(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x04000EEB RID: 3819
		private Text text_0;

		// Token: 0x04000EEC RID: 3820
		private Button button_0;
	}
}
