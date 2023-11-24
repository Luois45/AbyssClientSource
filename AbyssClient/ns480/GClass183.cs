using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json;
using ns185;
using ns217;
using ns241;
using ns425;
using ns449;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using VRC.UI;

namespace ns480
{
	// Token: 0x02000370 RID: 880
	public class GClass183 : GClass130
	{
		// Token: 0x06004898 RID: 18584 RVA: 0x00112048 File Offset: 0x00110248
		internal void method_2()
		{
			GClass183.list_0.Clear();
			this.method_69(GClass183.uiAvatarList_0, false);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x0011206C File Offset: 0x0011026C
		internal void method_3(string string_1, List<KeyCode> list_1, Text text_7)
		{
			this.method_36(string_1, list_1, text_7);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00112084 File Offset: 0x00110284
		internal void method_4(UiAvatarList uiAvatarList_7, bool bool_1)
		{
			this.method_70(uiAvatarList_7, bool_1);
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x0011209C File Offset: 0x0011029C
		internal string method_5(object object_0)
		{
			try
			{
				string text = "2371845348:30652";
				if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
				{
					text = "http" + "://" + text;
				}
				string requestUriString = text + "/" + ((object_0 != null) ? object_0.ToString() : null);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				return streamReader.ReadToEnd();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"while",
					" ",
					"searching",
					" ",
					"avatars",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
			return string.Empty;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x001121AC File Offset: 0x001103AC
		[CompilerGenerated]
		private void method_6()
		{
			this.method_52();
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x001121C0 File Offset: 0x001103C0
		internal void method_7()
		{
			this.method_89();
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x001121D4 File Offset: 0x001103D4
		internal void method_8(string string_1)
		{
			this.method_48(string_1);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x001121E8 File Offset: 0x001103E8
		private void method_9()
		{
			List<GClass76> list = GClass84.gclass39_0.method_27(GClass84.gclass39_0.int_0);
			this.text_1.text = string.Concat(new string[]
			{
				"Random",
				" ",
				"Avatars",
				": ",
				list.Count.ToString(),
				"/",
				GClass84.gclass39_0.int_0.ToString()
			});
			this.uiAvatarList_1.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_1, true);
			this.method_20(this.uiAvatarList_1, GClass76.smethod_14(list).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_1.scrollRect.movementType = 1;
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x001122B4 File Offset: 0x001104B4
		private void method_10()
		{
			this.method_72();
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x001122C8 File Offset: 0x001104C8
		internal void method_11(ref UiAvatarList uiAvatarList_7, ref GameObject gameObject_15, ref Text text_7, string string_1, string string_2, Action action_0, int int_0, Vector2 vector2_0, float float_0, Image.Type type_0, bool bool_1, string string_3, Action action_1, bool bool_2)
		{
			try
			{
				Transform transform = GClass84.smethod_102().field_Public_GameObject_3.transform;
				if (!GClass183.gameObject_8)
				{
					GClass183.gameObject_8 = transform.Find("Screens/Avatar").gameObject;
				}
				GameObject gameObject = transform.Find("Screens/Avatar/Vertical Scroll View/Viewport/Content/Legacy Avatar List").gameObject;
				gameObject_15 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
				gameObject_15.transform.SetSiblingIndex(int_0);
				if (!GClass183.gameObject_7)
				{
					GClass183.gameObject_7 = transform.Find("Screens/Avatar/Change Button").gameObject;
				}
				GameObject gameObject2 = gameObject_15.transform.Find("Button").gameObject;
				text_7 = gameObject2.GetComponentInChildren<Text>();
				text_7.text = string_1;
				if (!GClass183.pageAvatar_0)
				{
					GClass183.pageAvatar_0 = GClass183.gameObject_8.GetComponent<PageAvatar>();
				}
				uiAvatarList_7 = gameObject_15.GetComponent<UiAvatarList>();
				uiAvatarList_7.clearUnseenListOnCollapse = false;
				uiAvatarList_7.field_Public_Category_0 = 4;
				GameObject gameObject3 = Object.Instantiate<GameObject>(GClass183.gameObject_7, gameObject2.transform.parent);
				Image component = gameObject3.GetComponent<Image>();
				component.type = type_0;
				gameObject3.GetComponentInChildren<Text>().text = string_2;
				Transform transform2 = gameObject3.transform.Find("PlatformAnyIcon");
				if (transform2)
				{
					Object.DestroyImmediate(transform2.gameObject, true);
				}
				Button component2 = gameObject3.GetComponent<Button>();
				GClass84.smethod_243(component2, action_0);
				RectTransform component3 = gameObject3.GetComponent<RectTransform>();
				component3.sizeDelta *= vector2_0;
				gameObject3.transform.SetParent(gameObject2.transform, true);
				component3.anchoredPosition = gameObject2.transform.Find("ToggleIcon").GetComponent<RectTransform>().anchoredPosition + new Vector2(float_0, 0f);
				if (bool_1)
				{
					GameObject gameObject4 = Object.Instantiate<GameObject>(gameObject3, gameObject3.transform.parent);
					gameObject4.name = string_3 + "Button";
					gameObject4.GetComponentInChildren<Text>().text = string_3;
					Transform transform3 = gameObject4.transform.Find("PlatformAnyIcon");
					if (transform3)
					{
						Object.DestroyImmediate(transform3.gameObject, true);
					}
					Button component4 = gameObject4.GetComponent<Button>();
					GClass84.smethod_243(component4, action_1);
					RectTransform component5 = gameObject4.GetComponent<RectTransform>();
					gameObject4.transform.SetParent(gameObject2.transform, true);
					Vector2 anchoredPosition = component5.anchoredPosition;
					anchoredPosition.x -= component5.sizeDelta.x;
					component5.anchoredPosition = anchoredPosition;
				}
				if (bool_2)
				{
					this.method_20(uiAvatarList_7, null, false);
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00112584 File Offset: 0x00110784
		internal void method_12(string string_1, List<KeyCode> list_1, Text text_7)
		{
			this.method_3(string_1, list_1, text_7);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0011259C File Offset: 0x0011079C
		[CompilerGenerated]
		private void method_13()
		{
			this.method_38();
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x001125B0 File Offset: 0x001107B0
		internal void method_14()
		{
			this.method_67();
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x001125C4 File Offset: 0x001107C4
		internal void method_15(string string_1, List<KeyCode> list_1, Text text_7)
		{
			if (string_1 != string.Empty && string_1.Length >= 1)
			{
				this.method_8(string_1);
			}
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x001125F8 File Offset: 0x001107F8
		internal void method_16(ref UiAvatarList uiAvatarList_7, ref GameObject gameObject_15, ref Text text_7, string string_1, string string_2, Action action_0, int int_0, Vector2 vector2_0, float float_0, Image.Type type_0, bool bool_1, string string_3, Action action_1, bool bool_2)
		{
			this.method_11(ref uiAvatarList_7, ref gameObject_15, ref text_7, string_1, string_2, action_0, int_0, vector2_0, float_0, type_0, bool_1, string_3, action_1, bool_2);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x0011263C File Offset: 0x0011083C
		internal void method_17(string string_1)
		{
			this.method_28();
			try
			{
				List<GClass76> list = JsonConvert.DeserializeObject<List<GClass76>>(this.method_61(string.Concat(new string[]
				{
					"Search",
					"/",
					GClass84.string_0,
					"//",
					string_1
				})));
				for (int i = 0; i < list.Count; i++)
				{
					GClass183.list_0.Add(GClass76.smethod_15(list[i]));
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"while",
					" ",
					"searching",
					" ",
					"avatars",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
			GClass183.text_0.text = string.Concat(new string[]
			{
				"(",
				GClass183.list_0.Count.ToString(),
				") ",
				"Result",
				"(",
				"s",
				")",
				": ",
				string_1
			});
			GClass183.uiAvatarList_0.scrollRect.movementType = 0;
			this.method_20(GClass183.uiAvatarList_0, GClass183.list_0, false);
			GClass183.uiAvatarList_0.scrollRect.movementType = 1;
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x001127BC File Offset: 0x001109BC
		private void method_18()
		{
			this.text_5.text = GClass84.gclass39_0.string_8;
			this.method_69(this.uiAvatarList_5, false);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x001127EC File Offset: 0x001109EC
		[CompilerGenerated]
		private void method_19()
		{
			this.method_56();
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00112800 File Offset: 0x00110A00
		internal void method_20(UiVRCList uiVRCList_0, List<ApiAvatar> list_1, bool bool_1 = false)
		{
			this.method_24(uiVRCList_0, list_1, bool_1);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x00112818 File Offset: 0x00110A18
		private void method_21()
		{
			this.text_2.text = "Last Avatars";
			this.method_69(this.uiAvatarList_2, false);
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00112844 File Offset: 0x00110A44
		internal void method_22()
		{
			this.method_77();
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00112858 File Offset: 0x00110A58
		[CompilerGenerated]
		private void method_23()
		{
			this.method_33();
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x0011286C File Offset: 0x00110A6C
		internal void method_24(UiVRCList uiVRCList_0, List<ApiAvatar> list_1, bool bool_1)
		{
			this.method_55(uiVRCList_0, list_1, bool_1);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x00112884 File Offset: 0x00110A84
		[CompilerGenerated]
		private void method_25()
		{
			this.method_81();
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x00112898 File Offset: 0x00110A98
		[CompilerGenerated]
		private void method_26()
		{
			this.method_63();
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x001128AC File Offset: 0x00110AAC
		private void method_27()
		{
			this.method_21();
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x001128C0 File Offset: 0x00110AC0
		internal void method_28()
		{
			this.method_39();
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x001128D4 File Offset: 0x00110AD4
		[CompilerGenerated]
		private void method_29()
		{
			this.method_59();
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x001128E8 File Offset: 0x00110AE8
		internal string method_30(object object_0)
		{
			return this.method_5(object_0);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x001128FC File Offset: 0x00110AFC
		internal void method_31()
		{
			this.method_32();
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00112910 File Offset: 0x00110B10
		internal void method_32()
		{
			this.method_66();
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00112924 File Offset: 0x00110B24
		private void method_33()
		{
			this.method_73();
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00112938 File Offset: 0x00110B38
		internal void method_34(string string_1, List<KeyCode> list_1, Text text_7)
		{
			this.method_15(string_1, list_1, text_7);
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00112950 File Offset: 0x00110B50
		private void method_35()
		{
			this.text_1.text = "Random Avatars";
			this.method_69(this.uiAvatarList_1, false);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0011297C File Offset: 0x00110B7C
		internal void method_36(string string_1, List<KeyCode> list_1, Text text_7)
		{
			ApiAvatar apiAvatar = new ApiAvatar
			{
				id = string_1
			};
			Action<ApiContainer> action = new Action<ApiContainer>(GClass183.Class210.class210_0.method_2);
			Action<ApiContainer> action2 = new Action<ApiContainer>(GClass183.Class210.class210_0.method_3);
			apiAvatar.Get(action, action2, null, false);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x001129EC File Offset: 0x00110BEC
		private void method_37()
		{
			this.method_35();
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x00112A00 File Offset: 0x00110C00
		private void method_38()
		{
			this.method_49();
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00112A14 File Offset: 0x00110C14
		public override void vmethod_23()
		{
			this.method_7();
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00112A28 File Offset: 0x00110C28
		internal void method_39()
		{
			this.method_2();
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00112A3C File Offset: 0x00110C3C
		internal void method_40(UiVRCList uiVRCList_0, bool bool_1)
		{
			this.method_64(uiVRCList_0, bool_1);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00112A54 File Offset: 0x00110C54
		private void method_41()
		{
			this.text_2.text = string.Concat(new string[]
			{
				"Last",
				" ",
				"Avatars",
				": ",
				GClass84.gclass39_0.list_1.Count.ToString(),
				"/",
				GClass84.gclass39_0.int_1.ToString()
			});
			this.uiAvatarList_2.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_2, true);
			this.method_20(this.uiAvatarList_2, GClass76.smethod_14(GClass84.gclass39_0.list_1).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_2.scrollRect.movementType = 1;
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00112B1C File Offset: 0x00110D1C
		private void method_42()
		{
			Action<string, List<KeyCode>, Text> action_ = new Action<string, List<KeyCode>, Text>(this.method_12);
			GClass84.smethod_946("Add Avatar", string.Empty, 0, false, "Add", action_, null, "Enter Valid ID", true, null, false);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00112B5C File Offset: 0x00110D5C
		[CompilerGenerated]
		private void method_43()
		{
			this.method_27();
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00112B70 File Offset: 0x00110D70
		internal void method_44()
		{
			if (GClass84.gclass39_0 != null)
			{
				GClass183.gameObject_0 = this.method_82(GClass84.gclass39_0.string_10, -581f, 374f, 200f, 72f, GClass84.gclass39_0.string_10, new Action(this.method_23), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			}
			GClass183.gameObject_1 = this.method_82("Show Author", -381f, 374f, 200f, 72f, "Show Author", new Action(GClass183.Class210.class210_0.method_8), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			GClass183.gameObject_2 = this.method_82("Download", -181f, 374f, 200f, 72f, "Download", new Action(GClass183.Class210.class210_0.method_4), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			GClass183.gameObject_4 = this.method_82("Force Change", 175f, 374f, 175f, 72f, "Force Change", new Action(GClass183.Class210.class210_0.method_1), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			if (GClass84.gclass138_0 != null)
			{
				this.method_68();
			}
			GClass183.gameObject_5 = this.method_82("Copy ID", 525f, 374f, 150f, 72f, "Copy ID", new Action(GClass183.Class210.class210_0.method_0), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			if (GClass84.gclass39_0 != null)
			{
				GClass183.gameObject_3 = this.method_82("Add By ID", 675f, 374f, 150f, 72f, "Add By ID", new Action(this.method_26), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
			}
			if (GClass84.gclass39_0 != null)
			{
				this.method_50(ref this.uiAvatarList_1, ref this.gameObject_9, ref this.text_1, "Random Avatars", "Update", new Action(this.method_75), 1, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_87), true);
				this.method_50(ref this.uiAvatarList_2, ref this.gameObject_10, ref this.text_2, "Last Avatars", "Update", new Action(this.method_86), 2, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_43), true);
				this.method_50(ref this.uiAvatarList_3, ref this.gameObject_11, ref this.text_3, "Last Friend Avatars", "Update", new Action(this.method_13), 3, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_6), true);
				this.method_50(ref this.uiAvatarList_4, ref this.gameObject_12, ref this.text_4, "Last Own Avatars", "Update", new Action(this.method_62), 4, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_71), true);
				this.method_50(ref this.uiAvatarList_5, ref this.gameObject_13, ref this.text_5, GClass84.gclass39_0.string_8, "Update", new Action(this.method_29), 5, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_19), true);
				this.method_50(ref this.uiAvatarList_6, ref this.gameObject_14, ref this.text_6, GClass84.gclass39_0.string_9, "Update", new Action(this.method_45), 6, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_25), true);
			}
			if (this.bool_0)
			{
				this.method_50(ref GClass183.uiAvatarList_0, ref GClass183.gameObject_6, ref GClass183.text_0, "Avatar Search", "Search", new Action(this.method_51), 1, new Vector2(0.4f, 0.75f), 925f, 3, true, "Clear", new Action(this.method_60), true);
			}
			GClass183.list_0 = new List<ApiAvatar>();
			if (GClass183.pageAvatar_0)
			{
				GClass183.pageAvatar_0.field_Public_SimpleAvatarPedestal_0.field_Public_Single_0 *= 0.9f;
			}
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00113074 File Offset: 0x00111274
		[CompilerGenerated]
		private void method_45()
		{
			this.method_74();
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00113088 File Offset: 0x00111288
		private void method_46()
		{
			this.method_85();
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x0011309C File Offset: 0x0011129C
		private void method_47()
		{
			this.text_3.text = "Last Friend Avatars";
			this.method_69(this.uiAvatarList_3, false);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001130C8 File Offset: 0x001112C8
		internal void method_48(string string_1)
		{
			this.method_17(string_1);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x001130DC File Offset: 0x001112DC
		private void method_49()
		{
			this.text_3.text = string.Concat(new string[]
			{
				"Last",
				" ",
				"Friend",
				" ",
				"Avatars",
				": ",
				GClass84.gclass39_0.list_2.Count.ToString(),
				"/",
				GClass84.gclass39_0.int_3.ToString()
			});
			this.uiAvatarList_3.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_3, true);
			this.method_20(this.uiAvatarList_3, GClass76.smethod_14(GClass84.gclass39_0.list_2).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_3.scrollRect.movementType = 1;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00113254 File Offset: 0x00111454
		internal void method_50(ref UiAvatarList uiAvatarList_7, ref GameObject gameObject_15, ref Text text_7, string string_1, string string_2, Action action_0, int int_0, Vector2 vector2_0, float float_0 = 900f, Image.Type type_0 = 1, bool bool_1 = false, string string_3 = "", Action action_1 = null, bool bool_2 = false)
		{
			this.method_16(ref uiAvatarList_7, ref gameObject_15, ref text_7, string_1, string_2, action_0, int_0, vector2_0, float_0, type_0, bool_1, string_3, action_1, bool_2);
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00113298 File Offset: 0x00111498
		[CompilerGenerated]
		private void method_51()
		{
			this.method_58();
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001132AC File Offset: 0x001114AC
		private void method_52()
		{
			this.method_47();
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x001132C0 File Offset: 0x001114C0
		internal void method_53()
		{
			this.method_44();
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x001132D4 File Offset: 0x001114D4
		private void method_54()
		{
			this.text_6.text = GClass84.gclass39_0.string_9;
			this.method_69(this.uiAvatarList_6, false);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00113304 File Offset: 0x00111504
		internal void method_55(UiVRCList uiVRCList_0, List<ApiAvatar> list_1, bool bool_1)
		{
			if (uiVRCList_0)
			{
				GClass84.smethod_1612(uiVRCList_0, list_1);
				if (!bool_1)
				{
					this.method_40(uiVRCList_0, list_1 != null && list_1.Count > 0);
				}
			}
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00113340 File Offset: 0x00111540
		private void method_56()
		{
			this.method_18();
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00113354 File Offset: 0x00111554
		private void method_57()
		{
			Action<string, List<KeyCode>, Text> action_ = new Action<string, List<KeyCode>, Text>(this.method_84);
			GClass84.smethod_946("Search", string.Empty, 0, false, "OK", action_, null, "Search...", true, null, false);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00113394 File Offset: 0x00111594
		private void method_58()
		{
			this.method_57();
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x001133A8 File Offset: 0x001115A8
		private void method_59()
		{
			this.method_79();
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x001133BC File Offset: 0x001115BC
		[CompilerGenerated]
		private void method_60()
		{
			this.method_78();
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x001133D0 File Offset: 0x001115D0
		internal string method_61(object object_0)
		{
			return this.method_30(object_0);
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x001133E4 File Offset: 0x001115E4
		[CompilerGenerated]
		private void method_62()
		{
			this.method_10();
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x001133F8 File Offset: 0x001115F8
		private void method_63()
		{
			this.method_42();
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0011340C File Offset: 0x0011160C
		internal void method_64(UiVRCList uiVRCList_0, bool bool_1)
		{
			this.method_88(uiVRCList_0, bool_1);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00113424 File Offset: 0x00111624
		private void method_65()
		{
			this.method_41();
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00113438 File Offset: 0x00111638
		internal void method_66()
		{
			this.method_14();
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x0011344C File Offset: 0x0011164C
		internal void method_67()
		{
			if (!(GClass183.gameObject_0 == null) && GClass183.gameObject_0.activeInHierarchy && GClass84.gclass39_0 != null)
			{
				ApiAvatar apiAvatar = GClass84.smethod_1122();
				if (apiAvatar != null)
				{
					foreach (Text text in GClass183.gameObject_0.GetComponentsInChildren<Text>())
					{
						if (apiAvatar.releaseStatus != "private")
						{
							if (GClass76.smethod_24(GClass84.gclass39_0.list_4, apiAvatar.id) != -1)
							{
								text.text = GClass84.gclass39_0.string_11;
							}
							else
							{
								text.text = GClass84.gclass39_0.string_10;
							}
						}
						else if (GClass76.smethod_24(GClass84.gclass39_0.list_5, apiAvatar.id) != -1)
						{
							text.text = GClass84.gclass39_0.string_11;
						}
						else
						{
							text.text = GClass84.gclass39_0.string_10;
						}
					}
				}
			}
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x0011356C File Offset: 0x0011176C
		internal void method_68()
		{
			this.method_22();
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00113580 File Offset: 0x00111780
		internal void method_69(UiAvatarList uiAvatarList_7, bool bool_1 = false)
		{
			this.method_4(uiAvatarList_7, bool_1);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00113598 File Offset: 0x00111798
		internal void method_70(UiAvatarList uiAvatarList_7, bool bool_1)
		{
			if (uiAvatarList_7)
			{
				GClass84.smethod_717(uiAvatarList_7);
				if (!bool_1)
				{
					this.method_40(uiAvatarList_7, false);
				}
			}
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001135C4 File Offset: 0x001117C4
		[CompilerGenerated]
		private void method_71()
		{
			this.method_46();
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x001135D8 File Offset: 0x001117D8
		private void method_72()
		{
			this.text_4.text = string.Concat(new string[]
			{
				"Last",
				" ",
				"Own",
				" ",
				"Avatars",
				": ",
				GClass84.gclass39_0.list_3.Count.ToString(),
				"/",
				GClass84.gclass39_0.int_2.ToString()
			});
			this.uiAvatarList_4.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_4, true);
			this.method_20(this.uiAvatarList_4, GClass76.smethod_14(GClass84.gclass39_0.list_3).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_4.scrollRect.movementType = 1;
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x001136B0 File Offset: 0x001118B0
		private void method_73()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1122();
			if (apiAvatar != null)
			{
				if (apiAvatar.releaseStatus != "private")
				{
					if (GClass76.smethod_24(GClass84.gclass39_0.list_4, apiAvatar.id) != -1)
					{
						GClass84.gclass39_0.method_13(apiAvatar.id);
						this.method_66();
					}
					else
					{
						GClass84.gclass39_0.method_38(apiAvatar);
						this.method_66();
					}
				}
				else if (GClass76.smethod_24(GClass84.gclass39_0.list_5, apiAvatar.id) != -1)
				{
					GClass84.gclass39_0.method_47(apiAvatar.id);
					this.method_66();
				}
				else
				{
					GClass84.gclass39_0.method_44(apiAvatar);
					this.method_66();
				}
			}
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00113770 File Offset: 0x00111970
		private void method_74()
		{
			this.method_76();
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00113784 File Offset: 0x00111984
		[CompilerGenerated]
		private void method_75()
		{
			this.method_80();
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00113798 File Offset: 0x00111998
		private void method_76()
		{
			this.text_6.text = GClass84.gclass39_0.string_9 + ": " + GClass84.gclass39_0.list_5.Count.ToString();
			this.uiAvatarList_6.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_6, true);
			this.method_20(this.uiAvatarList_6, GClass76.smethod_14(GClass84.gclass39_0.list_5).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_6.scrollRect.movementType = 1;
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x0011382C File Offset: 0x00111A2C
		internal void method_77()
		{
			GClass183.Class209 @class = new GClass183.Class209();
			@class.transform_0 = GClass84.smethod_292();
			if (@class.transform_0)
			{
				Transform transform = @class.transform_0.Find("ReuploaderButton");
				if (transform)
				{
					Object.DestroyImmediate(transform.gameObject);
				}
				Material material = new Material(Shader.Find("VRChat/UI/Default"));
				material.renderQueue = 4900;
				GameObject gameObject = this.method_82("ReuploaderButton", 356.25f, 374f, 187.5f, 72f, "Reuploader", null, GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				gameObject.name = "ReuploaderButton";
				gameObject.GetComponentInChildren<Text>().text = "Reuploader";
				Button component = gameObject.GetComponent<Button>();
				GClass84.smethod_243(component, new Action(@class.method_0));
				Transform transform2 = @class.transform_0.Find("ReuploaderPopup");
				if (transform2)
				{
					Object.DestroyImmediate(transform2.gameObject);
				}
				GameObject gameObject2 = Object.Instantiate<Transform>(GClass84.smethod_1282().Find("ControllerBindingsPopup"), @class.transform_0).gameObject;
				gameObject2.name = "ReuploaderPopup";
				Object.DestroyImmediate(gameObject2.GetComponent<PopupControllerBindings>());
				Object.DestroyImmediate(gameObject2.GetComponent<CanvasGroup>());
				Object.DestroyImmediate(gameObject2.transform.Find("Popup/PageButtons").gameObject);
				Object.DestroyImmediate(gameObject2.transform.Find("Popup/Pages").gameObject);
				GameObject gameObject3 = gameObject2.transform.Find("Darkness").gameObject;
				GameObject gameObject4 = gameObject2.transform.Find("Popup/ExitButton").gameObject;
				Button component2 = gameObject4.GetComponent<Button>();
				GClass84.smethod_243(component2, new Action(@class.method_1));
				GameObject gameObject5 = gameObject2.transform.Find("Popup/TitleText").gameObject;
				Text component3 = gameObject5.GetComponent<Text>();
				component3.text = "Reuploader";
				Transform transform3 = gameObject2.transform.Find("Popup");
				GameObject gameObject6 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject6.name = "ReuploadButton";
				gameObject6.GetComponentInChildren<Text>().text = "Reupload";
				RectTransform component4 = gameObject6.GetComponent<RectTransform>();
				component4.sizeDelta = new Vector2(250f, 60f);
				component4.localPosition = new Vector2(0f, 250f);
				GameObject gameObject7 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject7.name = "ChangeImageButton";
				gameObject7.GetComponentInChildren<Text>().text = "Change Image";
				component4 = gameObject7.GetComponent<RectTransform>();
				component4.sizeDelta = new Vector2(250f, 60f);
				component4.localPosition = new Vector2(0f, 190f);
				GameObject gameObject8 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject8.name = "ChangeNameButton";
				gameObject8.GetComponentInChildren<Text>().text = "Change Name";
				component4 = gameObject8.GetComponent<RectTransform>();
				component4.sizeDelta = new Vector2(250f, 60f);
				component4.localPosition = new Vector2(0f, 130f);
				GameObject gameObject9 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject9.name = "ChangeDescriptionButton";
				gameObject9.GetComponentInChildren<Text>().text = "Change Description";
				component4 = gameObject9.GetComponent<RectTransform>();
				component4.sizeDelta = new Vector2(250f, 60f);
				component4.localPosition = new Vector2(0f, 70f);
				GClass84.smethod_243(gameObject6.GetComponent<Button>(), new Action(GClass183.Class210.class210_0.method_7));
				GClass84.smethod_243(gameObject7.GetComponent<Button>(), new Action(GClass183.Class210.class210_0.method_9));
				GClass84.smethod_243(gameObject8.GetComponent<Button>(), new Action(GClass183.Class210.class210_0.method_5));
				GClass84.smethod_243(gameObject9.GetComponent<Button>(), new Action(GClass183.Class210.class210_0.method_6));
			}
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00113C84 File Offset: 0x00111E84
		private void method_78()
		{
			this.method_83();
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00113C98 File Offset: 0x00111E98
		private void method_79()
		{
			this.text_5.text = GClass84.gclass39_0.string_8 + ": " + GClass84.gclass39_0.list_4.Count.ToString();
			this.uiAvatarList_5.scrollRect.movementType = 0;
			this.method_69(this.uiAvatarList_5, true);
			this.method_20(this.uiAvatarList_5, GClass76.smethod_14(GClass84.gclass39_0.list_4).smethod_121<ApiAvatar>(), false);
			this.uiAvatarList_5.scrollRect.movementType = 1;
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00113D2C File Offset: 0x00111F2C
		private void method_80()
		{
			this.method_9();
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00113D40 File Offset: 0x00111F40
		private void method_81()
		{
			this.method_54();
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00113D54 File Offset: 0x00111F54
		internal GameObject method_82(string string_1, float float_0, float float_1, float float_2, float float_3, string string_2, Action action_0, Texture texture_0 = null, Color? nullable_0 = null, Color? nullable_1 = null)
		{
			GameObject gameObject = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Change Button");
			GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
			gameObject2.name = string_1;
			Object.DestroyImmediate(gameObject.transform.Find("PlatformAnyIcon"));
			Image component = gameObject2.GetComponent<Image>();
			if (texture_0)
			{
				Material material = component.material;
				Object.DestroyImmediate(component);
				RawImage rawImage = gameObject2.AddComponent<RawImage>();
				rawImage.material = material;
				rawImage.texture = texture_0;
				rawImage.color = Color.white;
				Rect uvRect = rawImage.uvRect;
				Vector2 vector = uvRect.position;
				vector.x = 0f;
				vector.y = 0f;
				uvRect.position = vector;
				vector = uvRect.size;
				vector.x = 1f;
				vector.y = 1f;
				uvRect.size = vector;
				rawImage.uvRect = uvRect;
			}
			else
			{
				component.type = 3;
			}
			if (nullable_1 != null)
			{
				Graphic component2 = gameObject2.GetComponent<Graphic>();
				if (component2)
				{
					component2.color = nullable_1.Value;
				}
			}
			gameObject2.transform.localPosition = new Vector3(float_0, float_1);
			RectTransform component3 = gameObject2.GetComponent<RectTransform>();
			component3.sizeDelta = new Vector2(float_2, float_3);
			GClass84.smethod_243(gameObject2.GetComponent<Button>(), action_0);
			foreach (Text text in gameObject2.GetComponentsInChildren<Text>())
			{
				text.text = string_2;
				GClass84.smethod_1625(text);
				if (nullable_0 != null)
				{
					text.color = nullable_0.Value;
				}
			}
			return gameObject2;
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00113F1C File Offset: 0x0011211C
		private void method_83()
		{
			GClass183.text_0.text = "Avatar Search";
			this.method_69(GClass183.uiAvatarList_0, false);
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00113F44 File Offset: 0x00112144
		internal void method_84(string string_1, List<KeyCode> list_1, Text text_7)
		{
			this.method_34(string_1, list_1, text_7);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00113F5C File Offset: 0x0011215C
		private void method_85()
		{
			this.text_4.text = "Last Own Avatars";
			this.method_69(this.uiAvatarList_4, false);
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00113F88 File Offset: 0x00112188
		public override void vmethod_12()
		{
			this.method_53();
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x00113F9C File Offset: 0x0011219C
		public override void vmethod_10()
		{
			this.method_31();
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00113FB0 File Offset: 0x001121B0
		[CompilerGenerated]
		private void method_86()
		{
			this.method_65();
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00113FC4 File Offset: 0x001121C4
		[CompilerGenerated]
		private void method_87()
		{
			this.method_37();
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00113FD8 File Offset: 0x001121D8
		internal void method_88(UiVRCList uiVRCList_0, bool bool_1)
		{
			Transform transform = uiVRCList_0.transform.Find("Button");
			if (transform)
			{
				Button component = transform.GetComponent<Button>();
				ButtonReaction component2 = transform.GetComponent<ButtonReaction>();
				Transform transform2 = transform.Find("ToggleIcon");
				Transform transform3 = transform.Find("ClearButton");
				Transform transform4 = transform.Find("TitleText");
				if (bool_1)
				{
					if (transform4)
					{
						Vector3 localPosition = transform4.localPosition;
						localPosition.x = 217.85f;
						transform4.localPosition = localPosition;
					}
					if (transform2)
					{
						transform2.gameObject.SetActive(true);
					}
					if (transform3)
					{
						transform3.gameObject.SetActive(true);
					}
					if (component)
					{
						component.enabled = true;
					}
					if (component2)
					{
						component2.enabled = true;
					}
				}
				else
				{
					if (transform4)
					{
						Vector3 localPosition2 = transform4.localPosition;
						localPosition2.x = 0f;
						transform4.localPosition = localPosition2;
					}
					if (transform2)
					{
						transform2.gameObject.SetActive(false);
					}
					if (transform3)
					{
						transform3.gameObject.SetActive(false);
					}
					if (component)
					{
						component.enabled = false;
					}
					if (component2)
					{
						component2.enabled = false;
					}
				}
			}
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00114120 File Offset: 0x00112320
		internal void method_89()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x04001BFE RID: 7166
		internal static GameObject gameObject_0;

		// Token: 0x04001BFF RID: 7167
		internal static GameObject gameObject_1;

		// Token: 0x04001C00 RID: 7168
		internal static GameObject gameObject_2;

		// Token: 0x04001C01 RID: 7169
		internal static GameObject gameObject_3;

		// Token: 0x04001C02 RID: 7170
		internal static GameObject gameObject_4;

		// Token: 0x04001C03 RID: 7171
		internal static GameObject gameObject_5;

		// Token: 0x04001C04 RID: 7172
		internal bool bool_0 = true;

		// Token: 0x04001C05 RID: 7173
		internal static Text text_0;

		// Token: 0x04001C06 RID: 7174
		internal static GameObject gameObject_6;

		// Token: 0x04001C07 RID: 7175
		internal static GameObject gameObject_7;

		// Token: 0x04001C08 RID: 7176
		internal static UiAvatarList uiAvatarList_0;

		// Token: 0x04001C09 RID: 7177
		internal static UiInputField uiInputField_0;

		// Token: 0x04001C0A RID: 7178
		internal static GameObject gameObject_8;

		// Token: 0x04001C0B RID: 7179
		internal static PageAvatar pageAvatar_0;

		// Token: 0x04001C0C RID: 7180
		internal static List<ApiAvatar> list_0;

		// Token: 0x04001C0D RID: 7181
		internal UiAvatarList uiAvatarList_1;

		// Token: 0x04001C0E RID: 7182
		internal GameObject gameObject_9 = new GameObject();

		// Token: 0x04001C0F RID: 7183
		internal Text text_1 = new Text();

		// Token: 0x04001C10 RID: 7184
		internal UiAvatarList uiAvatarList_2;

		// Token: 0x04001C11 RID: 7185
		internal GameObject gameObject_10 = new GameObject();

		// Token: 0x04001C12 RID: 7186
		internal Text text_2 = new Text();

		// Token: 0x04001C13 RID: 7187
		internal UiAvatarList uiAvatarList_3;

		// Token: 0x04001C14 RID: 7188
		internal GameObject gameObject_11 = new GameObject();

		// Token: 0x04001C15 RID: 7189
		internal Text text_3 = new Text();

		// Token: 0x04001C16 RID: 7190
		internal UiAvatarList uiAvatarList_4;

		// Token: 0x04001C17 RID: 7191
		internal GameObject gameObject_12 = new GameObject();

		// Token: 0x04001C18 RID: 7192
		internal Text text_4 = new Text();

		// Token: 0x04001C19 RID: 7193
		internal UiAvatarList uiAvatarList_5;

		// Token: 0x04001C1A RID: 7194
		internal GameObject gameObject_13 = new GameObject();

		// Token: 0x04001C1B RID: 7195
		internal Text text_5 = new Text();

		// Token: 0x04001C1C RID: 7196
		internal UiAvatarList uiAvatarList_6;

		// Token: 0x04001C1D RID: 7197
		internal GameObject gameObject_14 = new GameObject();

		// Token: 0x04001C1E RID: 7198
		internal Text text_6 = new Text();

		// Token: 0x02000371 RID: 881
		[CompilerGenerated]
		private sealed class Class209
		{
			// Token: 0x060048F5 RID: 18677 RVA: 0x0011415C File Offset: 0x0011235C
			internal void method_0()
			{
				GameObject gameObject = this.transform_0.Find("ReuploaderPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(true);
				}
			}

			// Token: 0x060048F7 RID: 18679 RVA: 0x00114190 File Offset: 0x00112390
			internal void method_1()
			{
				GameObject gameObject = this.transform_0.Find("ReuploaderPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(false);
				}
			}

			// Token: 0x04001C1F RID: 7199
			public Transform transform_0;
		}

		// Token: 0x02000372 RID: 882
		[CompilerGenerated]
		[Serializable]
		private sealed class Class210
		{
			// Token: 0x060048F8 RID: 18680 RVA: 0x001141C4 File Offset: 0x001123C4
			internal void method_0()
			{
				ApiAvatar apiAvatar = GClass84.smethod_1122();
				if (apiAvatar != null)
				{
					Clipboard.SetText(apiAvatar.id);
				}
			}

			// Token: 0x060048FA RID: 18682 RVA: 0x00114200 File Offset: 0x00112400
			internal void method_1()
			{
				GClass84.smethod_1098(GClass84.smethod_1122());
			}

			// Token: 0x060048FB RID: 18683 RVA: 0x00114218 File Offset: 0x00112418
			internal void method_2(ApiContainer apiContainer_0)
			{
				ApiAvatar apiAvatar = apiContainer_0.Model.Cast<ApiAvatar>();
				GClass76 gclass76_ = new GClass76(apiAvatar);
				if (apiAvatar.releaseStatus == "private")
				{
					if (GClass76.smethod_1(GClass84.gclass39_0.list_5, gclass76_) == -1)
					{
						GClass84.gclass39_0.method_44(apiAvatar);
						GClass84.smethod_1065("Add Favorited.", string.Concat(new string[]
						{
							"Added",
							" ",
							"avatar",
							". ",
							apiAvatar.name
						}));
					}
					else
					{
						GClass84.smethod_1065("Add Favorite Error.", "This avatar is already favorited.");
					}
				}
				if (GClass76.smethod_1(GClass84.gclass39_0.list_4, gclass76_) == -1)
				{
					GClass84.gclass39_0.method_38(apiAvatar);
					GClass84.smethod_1065("Add Favorited.", string.Concat(new string[]
					{
						"Added",
						" ",
						"avatar",
						". ",
						apiAvatar.name
					}));
				}
				else
				{
					GClass84.smethod_1065("Add Favorite Error.", "This avatar is already favorited.");
				}
			}

			// Token: 0x060048FD RID: 18685 RVA: 0x00114328 File Offset: 0x00112528
			internal void method_3(ApiContainer apiContainer_0)
			{
				GClass84.smethod_1065("Add Favorite Error.", "Avatar Not found.");
			}

			// Token: 0x060048FE RID: 18686 RVA: 0x00114344 File Offset: 0x00112544
			internal void method_4()
			{
				GClass84.smethod_648(GClass84.smethod_1122());
			}

			// Token: 0x060048FF RID: 18687 RVA: 0x0011435C File Offset: 0x0011255C
			internal void method_5()
			{
				GClass84.gclass138_0.method_87();
			}

			// Token: 0x06004900 RID: 18688 RVA: 0x00114374 File Offset: 0x00112574
			internal void method_6()
			{
				GClass84.gclass138_0.method_89();
			}

			// Token: 0x06004901 RID: 18689 RVA: 0x0011438C File Offset: 0x0011258C
			internal void method_7()
			{
				GClass84.gclass138_0.method_8();
			}

			// Token: 0x06004902 RID: 18690 RVA: 0x001143A4 File Offset: 0x001125A4
			internal void method_8()
			{
				GClass84.smethod_1070(GClass84.smethod_1122().authorId);
			}

			// Token: 0x06004903 RID: 18691 RVA: 0x001143C0 File Offset: 0x001125C0
			internal void method_9()
			{
				GClass84.gclass138_0.method_79();
			}

			// Token: 0x04001C20 RID: 7200
			public static readonly GClass183.Class210 class210_0 = new GClass183.Class210();

			// Token: 0x04001C21 RID: 7201
			public static Action action_0;

			// Token: 0x04001C22 RID: 7202
			public static Action action_1;

			// Token: 0x04001C23 RID: 7203
			public static Action action_2;

			// Token: 0x04001C24 RID: 7204
			public static Action action_3;

			// Token: 0x04001C25 RID: 7205
			public static Action action_4;

			// Token: 0x04001C26 RID: 7206
			public static Action action_5;

			// Token: 0x04001C27 RID: 7207
			public static Action action_6;

			// Token: 0x04001C28 RID: 7208
			public static Action action_7;

			// Token: 0x04001C29 RID: 7209
			public static Action<ApiContainer> action_8;

			// Token: 0x04001C2A RID: 7210
			public static Action<ApiContainer> action_9;
		}
	}
}
