using System;
using System.Runtime.CompilerServices;
using ns241;
using ns410;
using ns53;
using ns55;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Tooltips;

namespace ns61
{
	// Token: 0x02000282 RID: 642
	public class GClass32 : GClass26
	{
		// Token: 0x06001D90 RID: 7568 RVA: 0x00093634 File Offset: 0x00091834
		internal void method_17(Action action_0)
		{
			this.method_35(action_0);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00093648 File Offset: 0x00091848
		[CompilerGenerated]
		private void method_18()
		{
			this.method_33();
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0009365C File Offset: 0x0009185C
		internal void method_19(Texture texture_0)
		{
			this.method_31(texture_0);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00093670 File Offset: 0x00091870
		public GClass32(string string_3, string string_4, string string_5, Transform transform_0 = null, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_27(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00093694 File Offset: 0x00091894
		internal void method_20(Color color_2, bool bool_0)
		{
			this.method_26(color_2, bool_0);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000936AC File Offset: 0x000918AC
		private void method_21()
		{
			this.menuTab_0.GetComponent<StyleElement>().field_Private_Selectable_0 = this.button_0;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000936D0 File Offset: 0x000918D0
		internal override void vmethod_0(Color color_2, bool bool_0 = true)
		{
			this.method_20(color_2, bool_0);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000936E8 File Offset: 0x000918E8
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_32(color_2, bool_0);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00093700 File Offset: 0x00091900
		internal void method_22(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0009371C File Offset: 0x0009191C
		internal void method_23(string string_3)
		{
			this.method_34(string_3);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00093730 File Offset: 0x00091930
		internal void method_24(Action action_0)
		{
			this.method_28(action_0);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00093744 File Offset: 0x00091944
		internal void method_25(string string_3)
		{
			this.method_23(string_3);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00093758 File Offset: 0x00091958
		internal void method_26(Color color_2, bool bool_0)
		{
			if (bool_0)
			{
				this.color_0 = color_2;
			}
			Selectable componentInChildren = this.gameObject_0.GetComponentInChildren<Button>();
			ColorBlock colors = default(ColorBlock);
			colors.colorMultiplier = 1f;
			colors.disabledColor = Color.grey;
			colors.highlightedColor = color_2 * 1.5f;
			colors.normalColor = color_2 / 1.5f;
			colors.pressedColor = Color.grey * 1.5f;
			componentInChildren.colors = colors;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000937DC File Offset: 0x000919DC
		private void method_27(string string_3, string string_4, string string_5, Transform transform_0 = null, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_30(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00093800 File Offset: 0x00091A00
		internal void method_28(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0009381C File Offset: 0x00091A1C
		internal void method_29(Action action_0)
		{
			this.method_24(action_0);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00093830 File Offset: 0x00091A30
		private void method_30(string string_3, string string_4, string string_5, Transform transform_0, Color? nullable_0, Texture texture_0)
		{
			this.method_38(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_31(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00093854 File Offset: 0x00091A54
		internal void method_32(Color color_2, bool bool_0)
		{
			this.method_37(color_2, bool_0);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0009386C File Offset: 0x00091A6C
		private void method_33()
		{
			this.method_21();
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00022D48 File Offset: 0x00020F48
		internal void method_34(string string_3)
		{
			this.gameObject_0.GetComponentInChildren<Text>().text = string_3;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00093880 File Offset: 0x00091A80
		internal void method_35(Action action_0)
		{
			this.method_22(action_0);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00093894 File Offset: 0x00091A94
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_19(texture_0);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000938A8 File Offset: 0x00091AA8
		internal bool method_36(string string_3)
		{
			bool result;
			if (this.uiTooltip_1)
			{
				this.uiTooltip_1.field_Public_String_0 = string_3;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00022FBC File Offset: 0x000211BC
		internal void method_37(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponentInChildren<Text>().color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000938D8 File Offset: 0x00091AD8
		private void method_38(string string_3, string string_4, string string_5, Transform transform_0, Color? nullable_0, Texture texture_0)
		{
			this.string_1 = "PageButton";
			if (transform_0 == null)
			{
				transform_0 = GClass84.smethod_1421().Find("Page_Buttons_QM/HorizontalLayoutGroup");
			}
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_0(), transform_0);
			this.gameObject_0.name = string_4 + "Tab";
			this.menuTab_0 = this.gameObject_0.GetComponent<MenuTab>();
			this.menuTab_0.field_Private_MenuStateController_0 = GClass84.smethod_257();
			this.menuTab_0.field_Public_String_0 = string_3;
			this.rawImage_0 = this.gameObject_0.transform.Find("Icon").GetComponent<RawImage>();
			this.rawImage_0.texture = texture_0;
			this.gameObject_1 = this.gameObject_0.transform.GetChild(0).gameObject;
			this.textMeshProUGUI_0 = this.gameObject_1.GetComponentInChildren<TextMeshProUGUI>();
			this.button_0 = this.menuTab_0.GetComponent<Button>();
			this.menuTab_0.GetComponent<StyleElement>().field_Private_Selectable_0 = this.button_0;
			this.method_29(new Action(this.method_18));
			this.uiTooltip_1 = this.gameObject_0.GetComponent<UiTooltip>();
			this.method_36(string_5);
			base.method_11(true);
			GClass25.list_5.Add(this);
		}

		// Token: 0x0400119C RID: 4508
		private MenuTab menuTab_0;

		// Token: 0x0400119D RID: 4509
		private RawImage rawImage_0;

		// Token: 0x0400119E RID: 4510
		private GameObject gameObject_1;

		// Token: 0x0400119F RID: 4511
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x040011A0 RID: 4512
		private Button button_0;

		// Token: 0x040011A1 RID: 4513
		private UiTooltip uiTooltip_1;
	}
}
