using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppSystem.Collections.Generic;
using ns241;
using ns302;
using ns410;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements;
using VRC.UI.Elements.Tooltips;

namespace ns344
{
	// Token: 0x020002AF RID: 687
	public class GClass108
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x000A4194 File Offset: 0x000A2394
		internal void method_0(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5)
		{
			this.method_5(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000A41CC File Offset: 0x000A23CC
		internal void method_1(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_0(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000A4204 File Offset: 0x000A2404
		public GClass108(string string_2, string string_3, GClass99 gclass99_0, bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_4 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_1(string_2, string_3, gclass99_0.method_0(), bool_1, bool_2, bool_3, action_0, string_4, sprite_0, bool_4, bool_5);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000A4238 File Offset: 0x000A2438
		internal string method_2()
		{
			return this.string_0;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000A4250 File Offset: 0x000A2450
		internal string method_3()
		{
			return this.method_2();
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000A4264 File Offset: 0x000A2464
		public GClass108(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false)
		{
			this.method_1(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x000A4290 File Offset: 0x000A2490
		internal string method_4()
		{
			return this.method_3();
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000A42A4 File Offset: 0x000A24A4
		internal void method_5(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5)
		{
			GClass108.Class171 @class = new GClass108.Class171();
			@class.string_0 = string_4;
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_6(), GClass84.smethod_195());
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

		// Token: 0x0400126E RID: 4718
		private UIPage uipage_0;

		// Token: 0x0400126F RID: 4719
		private GameObject gameObject_0;

		// Token: 0x04001270 RID: 4720
		public Transform transform_0;

		// Token: 0x04001271 RID: 4721
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04001272 RID: 4722
		private GameObject gameObject_1;

		// Token: 0x04001273 RID: 4723
		private GameObject gameObject_2;

		// Token: 0x04001274 RID: 4724
		private GameObject gameObject_3;

		// Token: 0x04001275 RID: 4725
		private bool bool_0;

		// Token: 0x04001276 RID: 4726
		public RectMask2D rectMask2D_0;

		// Token: 0x04001277 RID: 4727
		public string string_0;

		// Token: 0x04001278 RID: 4728
		public string string_1;

		// Token: 0x020002B0 RID: 688
		[CompilerGenerated]
		private sealed class Class171
		{
			// Token: 0x06001FCF RID: 8143 RVA: 0x000A4610 File Offset: 0x000A2810
			internal void method_0()
			{
				GClass124.smethod_24(this.string_0);
			}

			// Token: 0x04001279 RID: 4729
			public string string_0;
		}
	}
}
