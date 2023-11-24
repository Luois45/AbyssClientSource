using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppSystem.Collections.Generic;
using ns205;
using ns241;
using ns290;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements;
using VRC.UI.Elements.Tooltips;

namespace ns237
{
	// Token: 0x020001B3 RID: 435
	public class GClass83
	{
		// Token: 0x06001077 RID: 4215 RVA: 0x000572D0 File Offset: 0x000554D0
		public GClass83(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_1(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000572FC File Offset: 0x000554FC
		internal string method_0()
		{
			return this.method_4();
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00057310 File Offset: 0x00055510
		internal void method_1(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_2(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00057348 File Offset: 0x00055548
		internal void method_2(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5)
		{
			this.method_5(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00057380 File Offset: 0x00055580
		public GClass83(string string_2, string string_3, GClass95 gclass95_0, bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_4 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_1(string_2, string_3, gclass95_0.method_9(), bool_1, bool_2, bool_3, action_0, string_4, sprite_0, bool_4, bool_5);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000573B4 File Offset: 0x000555B4
		internal string method_3()
		{
			return this.string_0;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000573CC File Offset: 0x000555CC
		internal string method_4()
		{
			return this.method_3();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000573E0 File Offset: 0x000555E0
		internal void method_5(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5)
		{
			GClass83.Class95 @class = new GClass83.Class95();
			@class.string_0 = string_4;
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_3(), GClass84.smethod_195());
			this.gameObject_0.name = string_2;
			this.gameObject_0.transform.SetSiblingIndex(5);
			this.uipage_0 = this.gameObject_0.GetComponent<UIPage>();
			this.uipage_0.field_Public_String_0 = string_2;
			this.uipage_0.field_Private_Boolean_1 = true;
			MenuStateController menuStateController = GClass84.smethod_257();
			this.uipage_0.field_Protected_MenuStateController_0 = menuStateController;
			this.uipage_0.field_Private_List_1_UIPage_0 = new List<UIPage>();
			this.uipage_0.field_Private_List_1_UIPage_0.Add(this.uipage_0);
			menuStateController.field_Private_Dictionary_2_String_UIPage_0.Add(string_2, this.uipage_0);
			this.string_0 = string_2;
			this.string_1 = (string.IsNullOrEmpty(@class.string_0) ? "QuickMenuDashboard" : @class.string_0);
			List<UIPage> list = menuStateController.field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
			list.Add(this.uipage_0);
			menuStateController.field_Public_ArrayOf_UIPage_0 = list.ToArray();
			this.transform_0 = this.gameObject_0.transform.Find("Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup");
			this.textMeshProUGUI_0 = this.gameObject_0.GetComponentInChildren<TextMeshProUGUI>(true);
			this.textMeshProUGUI_0.text = string_3;
			this.gameObject_1 = this.gameObject_0.transform.GetChild(0).Find("LeftItemContainer/Button_Back").gameObject;
			this.gameObject_2 = this.gameObject_0.transform.GetChild(0).Find("RightItemContainer/Button_QM_Expand").gameObject;
			this.gameObject_3 = this.gameObject_0.transform.GetChild(0).Find("RightItemContainer/Button_QM_Exit").gameObject;
			this.gameObject_1.SetActive(bool_1);
			GClass84.smethod_243(this.gameObject_1.GetComponent<Button>(), new Action(@class.method_0));
			this.gameObject_3.SetActive(bool_3);
			this.gameObject_2.SetActive(bool_2);
			GClass84.smethod_823(this.gameObject_2.GetComponent<Button>());
			if (action_0 != null)
			{
				this.gameObject_2.GetComponent<Button>().onClick.AddListener(action_0);
			}
			this.gameObject_2.GetComponent<UiTooltip>().field_Public_String_0 = string_5;
			if (sprite_0 != null)
			{
				this.gameObject_2.GetComponentInChildren<Image>().sprite = sprite_0;
				this.gameObject_2.GetComponentInChildren<Image>().overrideSprite = sprite_0;
				if (bool_4)
				{
					this.gameObject_2.GetComponentInChildren<Image>().color = Color.white;
					this.gameObject_2.GetComponentInChildren<StyleElement>(true).enabled = false;
				}
			}
			this.bool_0 = bool_4;
			this.rectMask2D_0 = this.transform_0.parent.gameObject.GetComponent<RectMask2D>();
			this.rectMask2D_0.enabled = true;
			this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().enabled = true;
			this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().verticalScrollbar = this.gameObject_0.transform.Find("Panel_QM_ScrollRect/Scrollbar").GetComponent<Scrollbar>();
			this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().verticalScrollbarVisibility = 1;
			this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().m_MovementType = (bool_5 ? 0 : 2);
		}

		// Token: 0x04000C25 RID: 3109
		private UIPage uipage_0;

		// Token: 0x04000C26 RID: 3110
		private GameObject gameObject_0;

		// Token: 0x04000C27 RID: 3111
		public Transform transform_0;

		// Token: 0x04000C28 RID: 3112
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04000C29 RID: 3113
		private GameObject gameObject_1;

		// Token: 0x04000C2A RID: 3114
		private GameObject gameObject_2;

		// Token: 0x04000C2B RID: 3115
		private GameObject gameObject_3;

		// Token: 0x04000C2C RID: 3116
		private bool bool_0;

		// Token: 0x04000C2D RID: 3117
		public RectMask2D rectMask2D_0;

		// Token: 0x04000C2E RID: 3118
		public string string_0;

		// Token: 0x04000C2F RID: 3119
		public string string_1;

		// Token: 0x020001B4 RID: 436
		[CompilerGenerated]
		private sealed class Class95
		{
			// Token: 0x06001080 RID: 4224 RVA: 0x0005774C File Offset: 0x0005594C
			internal void method_0()
			{
				GClass73.smethod_1(this.string_0);
			}

			// Token: 0x04000C30 RID: 3120
			public string string_0;
		}
	}
}
