using System;
using System.Runtime.CompilerServices;
using ns205;
using ns241;
using ns559;
using ns8;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Tooltips;

namespace ns11
{
	// Token: 0x02000224 RID: 548
	public class GClass5 : GClass2
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x0008071C File Offset: 0x0007E91C
		internal void method_17(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00080738 File Offset: 0x0007E938
		internal void method_18(string string_3)
		{
			this.method_32(string_3);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0008074C File Offset: 0x0007E94C
		public GClass5(string string_3, string string_4, string string_5, Transform transform_0 = null, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_31(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00080770 File Offset: 0x0007E970
		private void method_19(string string_3, string string_4, string string_5, Transform transform_0, Color? nullable_0, Texture texture_0)
		{
			this.method_38(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00080794 File Offset: 0x0007E994
		internal void method_20(Color color_2, bool bool_0)
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

		// Token: 0x060018CA RID: 6346 RVA: 0x00080818 File Offset: 0x0007EA18
		internal void method_21(string string_3)
		{
			this.gameObject_0.GetComponentInChildren<Text>().text = string_3;
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00080838 File Offset: 0x0007EA38
		internal override void vmethod_1(Color color_2, bool bool_0 = true)
		{
			this.method_34(color_2, bool_0);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00080850 File Offset: 0x0007EA50
		internal void method_22(Action action_0)
		{
			this.method_35(action_0);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00080864 File Offset: 0x0007EA64
		[CompilerGenerated]
		private void method_23()
		{
			this.method_26();
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00080878 File Offset: 0x0007EA78
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_25(texture_0);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0008088C File Offset: 0x0007EA8C
		internal void method_24(Action action_0)
		{
			this.method_22(action_0);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x000808A0 File Offset: 0x0007EAA0
		internal void method_25(Texture texture_0)
		{
			this.method_30(texture_0);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x000808B4 File Offset: 0x0007EAB4
		private void method_26()
		{
			this.method_33();
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x000808C8 File Offset: 0x0007EAC8
		internal void method_27(Color color_2, bool bool_0)
		{
			this.method_29(color_2, bool_0);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000808E0 File Offset: 0x0007EAE0
		internal void method_28(Action action_0)
		{
			this.method_37(action_0);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000808F4 File Offset: 0x0007EAF4
		internal void method_29(Color color_2, bool bool_0)
		{
			this.gameObject_0.GetComponentInChildren<Text>().color = color_2;
			if (bool_0)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_30(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0008091C File Offset: 0x0007EB1C
		private void method_31(string string_3, string string_4, string string_5, Transform transform_0 = null, Color? nullable_0 = null, Texture texture_0 = null)
		{
			this.method_19(string_3, string_4, string_5, transform_0, nullable_0, texture_0);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00080940 File Offset: 0x0007EB40
		internal void method_32(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00080954 File Offset: 0x0007EB54
		private void method_33()
		{
			this.menuTab_0.GetComponent<StyleElement>().field_Private_Selectable_0 = this.button_0;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00080978 File Offset: 0x0007EB78
		internal void method_34(Color color_2, bool bool_0)
		{
			this.method_20(color_2, bool_0);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00080990 File Offset: 0x0007EB90
		internal void method_35(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000809AC File Offset: 0x0007EBAC
		internal override void vmethod_2(Color color_2, bool bool_0 = true)
		{
			this.method_27(color_2, bool_0);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000809C4 File Offset: 0x0007EBC4
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

		// Token: 0x060018DD RID: 6365 RVA: 0x000809F4 File Offset: 0x0007EBF4
		internal void method_37(Action action_0)
		{
			this.method_17(action_0);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00080A08 File Offset: 0x0007EC08
		private void method_38(string string_3, string string_4, string string_5, Transform transform_0, Color? nullable_0, Texture texture_0)
		{
			this.string_1 = "PageButton";
			if (transform_0 == null)
			{
				transform_0 = GClass73.smethod_15().transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
			}
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_5(), transform_0);
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
			this.method_28(new Action(this.method_23));
			this.uiTooltip_1 = this.gameObject_0.GetComponent<UiTooltip>();
			this.method_36(string_5);
			base.method_6(true);
			GClass199.list_5.Add(this);
		}

		// Token: 0x04000EB1 RID: 3761
		private MenuTab menuTab_0;

		// Token: 0x04000EB2 RID: 3762
		private RawImage rawImage_0;

		// Token: 0x04000EB3 RID: 3763
		private GameObject gameObject_1;

		// Token: 0x04000EB4 RID: 3764
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04000EB5 RID: 3765
		private Button button_0;

		// Token: 0x04000EB6 RID: 3766
		private UiTooltip uiTooltip_1;
	}
}
