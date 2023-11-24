using System;
using ns241;
using ns410;
using ns53;
using ns55;
using ns56;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Tooltips;

namespace ns65
{
	// Token: 0x02000364 RID: 868
	public class GClass36 : GClass26
	{
		// Token: 0x060047D8 RID: 18392 RVA: 0x0010FF40 File Offset: 0x0010E140
		internal void method_17(Action action_0)
		{
			GClass84.smethod_0(this.button_0, action_0);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0010FF5C File Offset: 0x0010E15C
		internal bool method_18(string string_3)
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

		// Token: 0x060047DA RID: 18394 RVA: 0x0010FF8C File Offset: 0x0010E18C
		private void method_19(GClass27 gclass27_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_41(gclass27_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0010FFB4 File Offset: 0x0010E1B4
		private void method_20(string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_40(string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0010FFD8 File Offset: 0x0010E1D8
		internal void method_21(string string_3)
		{
			this.textMeshProUGUI_0.text = string_3;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0010FFF4 File Offset: 0x0010E1F4
		internal void method_22(Action action_0)
		{
			this.method_30(action_0);
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00110008 File Offset: 0x0010E208
		public GClass36(GClass27 gclass27_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = gclass27_0.method_3().name;
			this.method_23(gclass27_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x00110040 File Offset: 0x0010E240
		private void method_23(GClass27 gclass27_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_19(gclass27_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x00110068 File Offset: 0x0010E268
		private void method_24(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_25(transform_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00110090 File Offset: 0x0010E290
		private void method_25(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.string_1 = "NewButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_23(), transform_0, true);
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
			this.method_33(texture_0);
			this.method_29(string_3);
			this.method_38(action_0);
			this.method_18(string_4);
			if (nullable_1 != null)
			{
				this.method_34(nullable_1.Value);
			}
			base.method_11(true);
			GClass25.list_2.Add(this);
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x001101FC File Offset: 0x0010E3FC
		internal void method_26(Color color_2)
		{
			this.method_32(color_2);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x00110210 File Offset: 0x0010E410
		private void method_27(Transform transform_0, string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_24(transform_0, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x00110238 File Offset: 0x0010E438
		internal void method_28(Action action_0)
		{
			GClass84.smethod_243(this.button_0, action_0);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x00110254 File Offset: 0x0010E454
		internal void method_29(string string_3)
		{
			this.method_39(string_3);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x00110268 File Offset: 0x0010E468
		internal void method_30(Action action_0)
		{
			this.method_17(action_0);
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x0011027C File Offset: 0x0010E47C
		private void method_31(string string_3, Action action_0, string string_4, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.method_20(string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x001102A0 File Offset: 0x0010E4A0
		internal void method_32(Color color_2)
		{
			this.textMeshProUGUI_0.color = color_2;
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x001102BC File Offset: 0x0010E4BC
		internal void method_33(Texture texture_0)
		{
			this.method_37(texture_0);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x001102D0 File Offset: 0x0010E4D0
		internal void method_34(Color color_2)
		{
			this.method_26(color_2);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x001102E4 File Offset: 0x0010E4E4
		internal void method_35(Action action_0)
		{
			this.method_28(action_0);
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x001102F8 File Offset: 0x0010E4F8
		internal void method_36(Texture texture_0)
		{
			if (texture_0)
			{
				this.rawImage_0.texture = texture_0;
				this.textMeshProUGUI_0.transform.localPosition = new Vector3(0f, -76f, 0f);
				this.rawImage_0.gameObject.SetActive(true);
			}
			else
			{
				this.textMeshProUGUI_0.transform.localPosition = new Vector3(0f, -38f, 0f);
				this.rawImage_0.gameObject.SetActive(false);
			}
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00110388 File Offset: 0x0010E588
		internal void method_37(Texture texture_0)
		{
			this.method_36(texture_0);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0011039C File Offset: 0x0010E59C
		internal void method_38(Action action_0)
		{
			this.method_35(action_0);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x001103B0 File Offset: 0x0010E5B0
		internal void method_39(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x001103C4 File Offset: 0x0010E5C4
		public GClass36(Transform transform_0, string string_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_27(transform_0, string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x001103F0 File Offset: 0x0010E5F0
		public GClass36(string string_3, string string_4, Action action_0, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_31(string_4, action_0, string_5, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x0011041C File Offset: 0x0010E61C
		private void method_40(string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_27(GClass124.smethod_8(GClass84.smethod_195().Find(this.string_0)), string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00110450 File Offset: 0x0010E650
		private void method_41(GClass27 gclass27_0, string string_3, Action action_0, string string_4, Color? nullable_0, Color? nullable_1, Texture texture_0)
		{
			this.method_27(gclass27_0.method_3().transform, string_3, action_0, string_4, nullable_0, nullable_1, texture_0);
		}

		// Token: 0x04001BDF RID: 7135
		private Button button_0;

		// Token: 0x04001BE0 RID: 7136
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04001BE1 RID: 7137
		private GameObject gameObject_1;

		// Token: 0x04001BE2 RID: 7138
		private UiTooltip uiTooltip_1;

		// Token: 0x04001BE3 RID: 7139
		private RawImage rawImage_0;
	}
}
