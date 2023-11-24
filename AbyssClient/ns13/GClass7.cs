using System;
using ns205;
using ns241;
using ns559;
using ns8;
using ns9;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Tooltips;

namespace ns13
{
	// Token: 0x02000324 RID: 804
	public class GClass7 : GClass2
	{
		// Token: 0x0600411C RID: 16668 RVA: 0x000F72B0 File Offset: 0x000F54B0
		internal bool method_17(string string_3)
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

		// Token: 0x0600411D RID: 16669 RVA: 0x000F72E0 File Offset: 0x000F54E0
		private void method_18(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "NewButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_22(), transform_0, true);
			this.button_0 = this.gameObject_0.GetComponent<Button>();
			this.textMeshProUGUI_0 = this.gameObject_0.GetComponentInChildren<TextMeshProUGUI>();
			this.gameObject_1 = this.gameObject_0.transform.Find("Icon").gameObject;
			this.uiTooltip_1 = this.gameObject_0.GetComponent<UiTooltip>();
			Object.DestroyImmediate(this.gameObject_1.GetComponent<Image>());
			this.rawImage_0 = this.gameObject_1.AddComponent<RawImage>();
			this.rawImage_0.color = new Color(1f, 1f, 1f);
			Rect uvRect = this.rawImage_0.uvRect;
			Vector2 vector = uvRect.position;
			vector.x = 0f;
			vector.y = 0f;
			uvRect.position = vector;
			vector = uvRect.size;
			vector.x = 1f;
			vector.y = 1f;
			uvRect.size = vector;
			this.rawImage_0.uvRect = uvRect;
			this.method_39(texture_0);
			this.method_19(string_3);
			this.method_27(action_0);
			this.method_17(string_4);
			if (nullable_1 != null)
			{
				this.method_26(nullable_1.Value);
			}
			base.method_6(true);
			GClass199.list_2.Add(this);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000F744C File Offset: 0x000F564C
		internal void method_19(string string_3)
		{
			this.method_38(string_3);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x000F7460 File Offset: 0x000F5660
		internal void method_20(string string_3)
		{
			this.textMeshProUGUI_0.text = string_3;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x000F747C File Offset: 0x000F567C
		internal void method_21(Action action_0)
		{
			this.method_23(action_0);
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x000F7490 File Offset: 0x000F5690
		internal void method_22(Action action_0)
		{
			this.method_37(action_0);
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x000F74A4 File Offset: 0x000F56A4
		internal void method_23(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x000F74C0 File Offset: 0x000F56C0
		internal void method_24(Color color_2)
		{
			this.method_31(color_2);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x000F74D4 File Offset: 0x000F56D4
		internal void method_25(Texture texture_0)
		{
			this.method_32(texture_0);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x000F74E8 File Offset: 0x000F56E8
		internal void method_26(Color color_2)
		{
			this.method_24(color_2);
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x000F74FC File Offset: 0x000F56FC
		internal void method_27(Action action_0)
		{
			this.method_21(action_0);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x000F7510 File Offset: 0x000F5710
		private void method_28(string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_36(string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x000F7534 File Offset: 0x000F5734
		private void method_29(string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_28(string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x000F7558 File Offset: 0x000F5758
		private void method_30(GClass3 gclass3_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_41(gclass3_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x000F7580 File Offset: 0x000F5780
		internal void method_31(Color color_2)
		{
			this.textMeshProUGUI_0.color = color_2;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x000F759C File Offset: 0x000F579C
		internal void method_32(Texture texture_0)
		{
			if (texture_0)
			{
				this.rawImage_0.texture = texture_0;
			}
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x000F75C0 File Offset: 0x000F57C0
		private void method_33(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_18(transform_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x000F75E8 File Offset: 0x000F57E8
		public GClass7(string string_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_29(string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x000F7614 File Offset: 0x000F5814
		public GClass7(Transform transform_0, string string_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_35(transform_0, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x000F7640 File Offset: 0x000F5840
		internal void method_34(Action action_0)
		{
			this.method_22(action_0);
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x000F7654 File Offset: 0x000F5854
		private void method_35(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_33(transform_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x000F767C File Offset: 0x000F587C
		private void method_36(string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_35(GClass73.smethod_2(GClass84.smethod_195().Find(this.string_0)), string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000F76B0 File Offset: 0x000F58B0
		internal void method_37(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x000F76CC File Offset: 0x000F58CC
		public GClass7(GClass3 gclass3_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass3_0.method_12().name;
			this.method_40(gclass3_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x000F7704 File Offset: 0x000F5904
		internal void method_38(string string_3)
		{
			this.method_20(string_3);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x000F7718 File Offset: 0x000F5918
		internal void method_39(Texture texture_0)
		{
			this.method_25(texture_0);
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x000F772C File Offset: 0x000F592C
		private void method_40(GClass3 gclass3_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_30(gclass3_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x000F7754 File Offset: 0x000F5954
		private void method_41(GClass3 gclass3_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_35(gclass3_0.method_12().transform, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x0400198C RID: 6540
		private Button button_0;

		// Token: 0x0400198D RID: 6541
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x0400198E RID: 6542
		private GameObject gameObject_1;

		// Token: 0x0400198F RID: 6543
		private UiTooltip uiTooltip_1;

		// Token: 0x04001990 RID: 6544
		private RawImage rawImage_0;
	}
}
