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

namespace ns244
{
	// Token: 0x02000220 RID: 544
	public class GClass89
	{
		// Token: 0x060018B9 RID: 6329 RVA: 0x000801FC File Offset: 0x0007E3FC
		internal void method_0(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5, bool bool_6)
		{
			this.method_5(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5, bool_6);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00080238 File Offset: 0x0007E438
		internal string method_1()
		{
			return this.string_0;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00080250 File Offset: 0x0007E450
		public GClass89(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false)
		{
			this.method_3(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5, bool_6);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00080280 File Offset: 0x0007E480
		public GClass89(string string_2, string string_3, GClass99 gclass99_0, bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_4 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false)
		{
			this.method_3(string_2, string_3, gclass99_0.method_0(), bool_1, bool_2, bool_3, action_0, string_4, sprite_0, bool_4, bool_5, bool_6);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000802B4 File Offset: 0x0007E4B4
		internal string method_2()
		{
			return this.method_4();
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000802C8 File Offset: 0x0007E4C8
		internal void method_3(string string_2, string string_3, string string_4 = "", bool bool_1 = true, bool bool_2 = false, bool bool_3 = false, Action action_0 = null, string string_5 = "", Sprite sprite_0 = null, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false)
		{
			this.method_0(string_2, string_3, string_4, bool_1, bool_2, bool_3, action_0, string_5, sprite_0, bool_4, bool_5, bool_6);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00080304 File Offset: 0x0007E504
		internal string method_4()
		{
			return this.method_1();
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00080318 File Offset: 0x0007E518
		internal void method_5(string string_2, string string_3, string string_4, bool bool_1, bool bool_2, bool bool_3, Action action_0, string string_5, Sprite sprite_0, bool bool_4, bool bool_5, bool bool_6)
		{
			GClass89.Class127 @class = new GClass89.Class127();
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
			this.gameObject_0.transform.Find("Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup").localPosition = new Vector3(0f, 420f, 0f);
			if (bool_6)
			{
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().enabled = false;
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().verticalScrollbar.gameObject.SetActive(false);
			}
			else
			{
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().enabled = true;
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().verticalScrollbar = this.gameObject_0.transform.Find("Panel_QM_ScrollRect/Scrollbar").GetComponent<Scrollbar>();
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().verticalScrollbarVisibility = 1;
				this.gameObject_0.transform.Find("Panel_QM_ScrollRect").GetComponent<ScrollRect>().m_MovementType = (bool_5 ? 0 : 2);
			}
		}

		// Token: 0x04000EA2 RID: 3746
		private UIPage uipage_0;

		// Token: 0x04000EA3 RID: 3747
		private GameObject gameObject_0;

		// Token: 0x04000EA4 RID: 3748
		public Transform transform_0;

		// Token: 0x04000EA5 RID: 3749
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04000EA6 RID: 3750
		private GameObject gameObject_1;

		// Token: 0x04000EA7 RID: 3751
		private GameObject gameObject_2;

		// Token: 0x04000EA8 RID: 3752
		private GameObject gameObject_3;

		// Token: 0x04000EA9 RID: 3753
		private bool bool_0;

		// Token: 0x04000EAA RID: 3754
		public RectMask2D rectMask2D_0;

		// Token: 0x04000EAB RID: 3755
		public string string_0;

		// Token: 0x04000EAC RID: 3756
		public string string_1;

		// Token: 0x02000221 RID: 545
		[CompilerGenerated]
		private sealed class Class127
		{
			// Token: 0x060018C2 RID: 6338 RVA: 0x00080704 File Offset: 0x0007E904
			internal void method_0()
			{
				GClass124.smethod_24(this.string_0);
			}

			// Token: 0x04000EAD RID: 3757
			public string string_0;
		}
	}
}
