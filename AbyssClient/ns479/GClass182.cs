using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns185;
using ns241;
using ns425;
using ns449;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;

namespace ns479
{
	// Token: 0x02000367 RID: 871
	public class GClass182 : GClass130
	{
		// Token: 0x0600484E RID: 18510 RVA: 0x00110C40 File Offset: 0x0010EE40
		private void method_2()
		{
			this.method_21();
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00110C54 File Offset: 0x0010EE54
		private void method_3()
		{
			GClass84.gclass148_0.method_68(GClass84.smethod_1601());
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x00110C74 File Offset: 0x0010EE74
		private void method_4()
		{
			this.method_38();
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x00110C88 File Offset: 0x0010EE88
		private void method_5()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			GClass70.smethod_38(string.Concat(new string[]
			{
				apiuser.displayName,
				" ",
				"has",
				" ",
				"user",
				" ",
				"ID",
				" ",
				GClass84.smethod_1601()
			}), GClass70.Enum1.const_0);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x00110D08 File Offset: 0x0010EF08
		private GameObject method_6(string string_1, float float_0, float float_1, float float_2, float float_3, string string_2, Action action_0, Texture texture_0 = null, Color? nullable_0 = null, Color? nullable_1 = null)
		{
			GameObject gameObject = GameObject.Find(GClass84.smethod_277() + "/" + "Back" + "Button");
			GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
			gameObject2.name = string_1;
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
				text.fontSize = (int)((double)text.fontSize / 1.5);
				if (nullable_0 != null)
				{
					text.color = nullable_0.Value;
				}
			}
			return gameObject2;
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x00110EE8 File Offset: 0x0010F0E8
		public override void vmethod_12()
		{
			this.method_10();
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x00110EFC File Offset: 0x0010F0FC
		private void method_7()
		{
			this.method_23();
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00110F10 File Offset: 0x0010F110
		private void method_8()
		{
			this.method_4();
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00110F24 File Offset: 0x0010F124
		private void method_9()
		{
			this.method_20();
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00110F38 File Offset: 0x0010F138
		internal void method_10()
		{
			this.method_24();
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00110F4C File Offset: 0x0010F14C
		private void method_11()
		{
			this.method_14();
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00110F60 File Offset: 0x0010F160
		private void method_12()
		{
			VRCPlayer vrcplayer = GClass84.smethod_551(GClass84.smethod_1601());
			if (vrcplayer)
			{
				GClass84.smethod_1195(vrcplayer, false);
			}
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00110F88 File Offset: 0x0010F188
		private void method_13()
		{
			this.method_12();
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00110F9C File Offset: 0x0010F19C
		private void method_14()
		{
			this.method_3();
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00110FB0 File Offset: 0x0010F1B0
		private void method_15()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"]",
				" ",
				"{",
				"Set",
				"Owner",
				"(",
				GClass84.smethod_1601(),
				");}"
			}));
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x00111030 File Offset: 0x0010F230
		private void method_16()
		{
			this.method_13();
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00111044 File Offset: 0x0010F244
		private void method_17()
		{
			this.method_40();
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00111058 File Offset: 0x0010F258
		private void method_18()
		{
			this.method_30();
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x0011106C File Offset: 0x0010F26C
		private void method_19()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			GClass84.smethod_1145(GClass84.smethod_1601(), apiuser.displayName, true);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x001110A4 File Offset: 0x0010F2A4
		private void method_20()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			GClass70.smethod_38(string.Concat(new string[]
			{
				apiuser.displayName,
				" ",
				"has",
				" ",
				"ID",
				" ",
				GClass84.smethod_1520(apiuser)
			}), GClass70.Enum1.const_0);
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00111114 File Offset: 0x0010F314
		private void method_21()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser != null)
			{
				GClass84.smethod_383(apiuser);
			}
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00111134 File Offset: 0x0010F334
		internal void method_22()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser != null)
			{
				Transform transform = GClass84.smethod_292();
				if (transform)
				{
					GClass84.smethod_116(transform.GetComponent<VRCUiPage>());
				}
				GClass84.gclass183_0.method_8(GClass84.smethod_828(apiuser, ""));
			}
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x0011117C File Offset: 0x0010F37C
		private void method_23()
		{
			GClass84.gclass148_0.method_64(GClass84.smethod_1601());
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0011119C File Offset: 0x0010F39C
		internal void method_24()
		{
			this.method_8();
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x001111B0 File Offset: 0x0010F3B0
		private void method_25()
		{
			this.method_9();
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x001111C4 File Offset: 0x0010F3C4
		private void method_26()
		{
			this.method_15();
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x001111D8 File Offset: 0x0010F3D8
		private void method_27()
		{
			this.method_32();
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x001111EC File Offset: 0x0010F3EC
		internal void method_28()
		{
			this.method_42();
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00111200 File Offset: 0x0010F400
		private void method_29()
		{
			this.method_7();
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00111214 File Offset: 0x0010F414
		private void method_30()
		{
			this.method_19();
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00111228 File Offset: 0x0010F428
		private void method_31()
		{
			this.method_33();
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x0011123C File Offset: 0x0010F43C
		private void method_32()
		{
			this.method_5();
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00111250 File Offset: 0x0010F450
		private void method_33()
		{
			GClass84.gclass148_0.method_15(GClass84.smethod_1601());
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x00111270 File Offset: 0x0010F470
		internal void method_34()
		{
			this.method_36();
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00111284 File Offset: 0x0010F484
		private void method_35()
		{
			this.method_2();
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00111298 File Offset: 0x0010F498
		public override void vmethod_23()
		{
			this.method_28();
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x001112AC File Offset: 0x0010F4AC
		internal void method_36()
		{
			this.method_22();
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x001112C0 File Offset: 0x0010F4C0
		private void method_37()
		{
			this.method_31();
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x001112D4 File Offset: 0x0010F4D4
		private void method_38()
		{
			GClass182.Class207 @class = new GClass182.Class207();
			@class.gclass182_0 = this;
			@class.transform_0 = GClass84.smethod_1719();
			if (@class.transform_0)
			{
				Transform transform = @class.transform_0.Find("FunctionsButton");
				if (transform)
				{
					Object.DestroyImmediate(transform.gameObject);
				}
				Material material = new Material(Shader.Find("VRChat/UI/Default"));
				material.renderQueue = 4900;
				GameObject gameObject = this.method_6("FunctionsButton", 608f, -60f, 200f, 80f, "Functions", null, GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				gameObject.name = "FunctionsButton";
				gameObject.GetComponentInChildren<Text>().text = "Functions";
				Button component = gameObject.GetComponent<Button>();
				GClass84.smethod_243(component, new Action(@class.method_5));
				Transform transform2 = @class.transform_0.Find("FunctionsPopup");
				if (transform2)
				{
					Object.DestroyImmediate(transform2.gameObject);
				}
				GameObject gameObject2 = Object.Instantiate<Transform>(GClass84.smethod_1282().Find("ControllerBindingsPopup"), @class.transform_0).gameObject;
				gameObject2.name = "FunctionsPopup";
				Object.DestroyImmediate(gameObject2.GetComponent<PopupControllerBindings>());
				Object.DestroyImmediate(gameObject2.GetComponent<CanvasGroup>());
				Object.DestroyImmediate(gameObject2.transform.Find("Popup/PageButtons").gameObject);
				Object.DestroyImmediate(gameObject2.transform.Find("Popup/Pages").gameObject);
				GameObject gameObject3 = gameObject2.transform.Find("Darkness").gameObject;
				GameObject gameObject4 = gameObject2.transform.Find("Popup/ExitButton").gameObject;
				Button component2 = gameObject4.GetComponent<Button>();
				GClass84.smethod_243(component2, new Action(@class.method_8));
				GameObject gameObject5 = gameObject2.transform.Find("Popup/TitleText").gameObject;
				Text component3 = gameObject5.GetComponent<Text>();
				component3.text = "Functions";
				Transform transform3 = gameObject2.transform.Find("Popup");
				if (GClass84.gclass138_0 != null)
				{
					GameObject gameObject6 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
					gameObject6.name = "ReuploadAvatarButton";
					gameObject6.GetComponentInChildren<Text>().text = "Reupload Avatar";
					RectTransform component4 = gameObject6.GetComponent<RectTransform>();
					component4.sizeDelta = new Vector2(250f, 60f);
					component4.localPosition = new Vector2(-375f, 250f);
					GClass84.smethod_243(gameObject6.GetComponent<Button>(), new Action(GClass182.Class208.class208_0.method_0));
				}
				GameObject gameObject7 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject7.name = "TeleportToButton";
				gameObject7.GetComponentInChildren<Text>().text = "Teleport To";
				RectTransform component5 = gameObject7.GetComponent<RectTransform>();
				component5.sizeDelta = new Vector2(250f, 60f);
				component5.localPosition = new Vector2(-125f, 250f);
				GClass84.smethod_243(gameObject7.GetComponent<Button>(), new Action(@class.method_0));
				GameObject gameObject8 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject8.name = "SetOwnerBotButton";
				gameObject8.GetComponentInChildren<Text>().text = "Set Owner (Bot)";
				RectTransform component6 = gameObject8.GetComponent<RectTransform>();
				component6.sizeDelta = new Vector2(250f, 60f);
				component6.localPosition = new Vector2(125f, 250f);
				GClass84.smethod_243(gameObject8.GetComponent<Button>(), new Action(@class.method_11));
				GameObject gameObject9 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject9.name = "SearchAvatarsButton";
				gameObject9.GetComponentInChildren<Text>().text = "Search Avatars";
				RectTransform component7 = gameObject9.GetComponent<RectTransform>();
				component7.sizeDelta = new Vector2(250f, 60f);
				component7.localPosition = new Vector2(375f, 250f);
				GClass84.smethod_243(gameObject9.GetComponent<Button>(), new Action(@class.method_3));
				GameObject gameObject10 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject10.name = "GetIDButton";
				gameObject10.GetComponentInChildren<Text>().text = "Get ID";
				RectTransform component8 = gameObject10.GetComponent<RectTransform>();
				component8.sizeDelta = new Vector2(250f, 60f);
				component8.localPosition = new Vector2(-375f, 190f);
				GClass84.smethod_243(gameObject10.GetComponent<Button>(), new Action(@class.method_2));
				GameObject gameObject11 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject11.name = "GetTagsButton";
				gameObject11.GetComponentInChildren<Text>().text = "Get Tags";
				RectTransform component9 = gameObject11.GetComponent<RectTransform>();
				component9.sizeDelta = new Vector2(250f, 60f);
				component9.localPosition = new Vector2(-125f, 190f);
				GClass84.smethod_243(gameObject11.GetComponent<Button>(), new Action(@class.method_6));
				GameObject gameObject12 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject12.name = "DropPortalButton";
				gameObject12.GetComponentInChildren<Text>().text = "Drop Portal";
				RectTransform component10 = gameObject12.GetComponent<RectTransform>();
				component10.sizeDelta = new Vector2(250f, 60f);
				component10.localPosition = new Vector2(125f, 190f);
				GClass84.smethod_243(gameObject12.GetComponent<Button>(), new Action(@class.method_10));
				GameObject gameObject13 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject13.name = "AddBotButton";
				gameObject13.GetComponentInChildren<Text>().text = "Add Bot";
				RectTransform component11 = gameObject13.GetComponent<RectTransform>();
				component11.sizeDelta = new Vector2(250f, 60f);
				component11.localPosition = new Vector2(375f, 190f);
				GClass84.smethod_243(gameObject13.GetComponent<Button>(), new Action(@class.method_7));
				GameObject gameObject14 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject14.name = "GetUserIDButton";
				gameObject14.GetComponentInChildren<Text>().text = "Get User ID";
				RectTransform component12 = gameObject14.GetComponent<RectTransform>();
				component12.sizeDelta = new Vector2(250f, 60f);
				component12.localPosition = new Vector2(-375f, 130f);
				GClass84.smethod_243(gameObject14.GetComponent<Button>(), new Action(@class.method_1));
				if (GClass84.gclass93_0.bool_23)
				{
					GameObject gameObject15 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
					gameObject15.name = "CheckForEmmVRCButton";
					gameObject15.GetComponentInChildren<Text>().text = "Check For emmVRC";
					RectTransform component13 = gameObject15.GetComponent<RectTransform>();
					component13.sizeDelta = new Vector2(250f, 60f);
					component13.localPosition = new Vector2(-125f, 130f);
					GClass84.smethod_243(gameObject15.GetComponent<Button>(), new Action(@class.method_4));
				}
				GameObject gameObject16 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject16.name = "SetOwnerButton";
				gameObject16.GetComponentInChildren<Text>().text = "Set Owner";
				RectTransform component14 = gameObject16.GetComponent<RectTransform>();
				component14.sizeDelta = new Vector2(250f, 60f);
				component14.localPosition = new Vector2(125f, 130f);
				GClass84.smethod_243(gameObject16.GetComponent<Button>(), new Action(@class.method_9));
				GameObject gameObject17 = Object.Instantiate<GameObject>(gameObject, transform3).gameObject;
				gameObject17.name = "RemoveBotButton";
				gameObject17.GetComponentInChildren<Text>().text = "Remove Bot";
				RectTransform component15 = gameObject17.GetComponent<RectTransform>();
				component15.sizeDelta = new Vector2(250f, 60f);
				component15.localPosition = new Vector2(375f, 130f);
				GClass84.smethod_243(gameObject17.GetComponent<Button>(), new Action(@class.method_12));
			}
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00111B04 File Offset: 0x0010FD04
		private void method_39()
		{
			this.method_17();
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00111B18 File Offset: 0x0010FD18
		private void method_40()
		{
			APIUser apiuser = GClass84.smethod_1623();
			if (apiuser != null)
			{
				if (apiuser.id == APIUser.CurrentUser.id)
				{
					GClass84.smethod_1065("Error", "You cannot drop a portal to yourself!");
				}
				else if (string.IsNullOrEmpty(apiuser.location))
				{
					GClass84.smethod_1065("Error", string.Concat(new string[]
					{
						apiuser.displayName,
						" ",
						"has",
						" ",
						"no",
						" ",
						"valid",
						" ",
						"location",
						"!"
					}));
				}
				else if (apiuser.location.ToLower() == "private")
				{
					GClass84.smethod_1065("Error", string.Concat(new string[]
					{
						apiuser.displayName,
						" ",
						"is",
						" ",
						"in",
						" ",
						"a",
						" ",
						"private",
						" ",
						"world",
						"!"
					}));
				}
				else if (apiuser.location.ToLower() == "offline")
				{
					GClass84.smethod_1065("Error", string.Concat(new string[]
					{
						apiuser.displayName,
						" ",
						"is",
						" ",
						"offline",
						"!"
					}));
				}
				else
				{
					List<string> list = GClass84.smethod_659(apiuser.location, ":");
					Transform transform = GClass84.smethod_981();
					if (transform && list.Count == 2)
					{
						GClass84.smethod_1510(list[0], transform.position + transform.forward * 2f, transform.rotation, list[1], 1);
					}
				}
			}
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00111D34 File Offset: 0x0010FF34
		private void method_41()
		{
			this.method_26();
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00111D48 File Offset: 0x0010FF48
		internal void method_42()
		{
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x02000368 RID: 872
		[CompilerGenerated]
		private sealed class Class207
		{
			// Token: 0x0600487A RID: 18554 RVA: 0x00111D6C File Offset: 0x0010FF6C
			internal void method_0()
			{
				this.gclass182_0.method_16();
			}

			// Token: 0x0600487B RID: 18555 RVA: 0x00111D84 File Offset: 0x0010FF84
			internal void method_1()
			{
				this.gclass182_0.method_27();
			}

			// Token: 0x0600487C RID: 18556 RVA: 0x00111D9C File Offset: 0x0010FF9C
			internal void method_2()
			{
				this.gclass182_0.method_25();
			}

			// Token: 0x0600487D RID: 18557 RVA: 0x00111DB4 File Offset: 0x0010FFB4
			internal void method_3()
			{
				this.gclass182_0.method_34();
			}

			// Token: 0x0600487E RID: 18558 RVA: 0x00111DCC File Offset: 0x0010FFCC
			internal void method_4()
			{
				this.gclass182_0.method_18();
			}

			// Token: 0x0600487F RID: 18559 RVA: 0x00111DE4 File Offset: 0x0010FFE4
			internal void method_5()
			{
				GameObject gameObject = this.transform_0.Find("FunctionsPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(true);
				}
			}

			// Token: 0x06004880 RID: 18560 RVA: 0x00111E18 File Offset: 0x00110018
			internal void method_6()
			{
				this.gclass182_0.method_35();
			}

			// Token: 0x06004881 RID: 18561 RVA: 0x00111E30 File Offset: 0x00110030
			internal void method_7()
			{
				this.gclass182_0.method_11();
			}

			// Token: 0x06004882 RID: 18562 RVA: 0x00111E48 File Offset: 0x00110048
			internal void method_8()
			{
				GameObject gameObject = this.transform_0.Find("FunctionsPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(false);
				}
			}

			// Token: 0x06004883 RID: 18563 RVA: 0x00111E7C File Offset: 0x0011007C
			internal void method_9()
			{
				this.gclass182_0.method_29();
			}

			// Token: 0x06004885 RID: 18565 RVA: 0x00111E94 File Offset: 0x00110094
			internal void method_10()
			{
				this.gclass182_0.method_39();
			}

			// Token: 0x06004886 RID: 18566 RVA: 0x00111EAC File Offset: 0x001100AC
			internal void method_11()
			{
				this.gclass182_0.method_41();
			}

			// Token: 0x06004887 RID: 18567 RVA: 0x00111EC4 File Offset: 0x001100C4
			internal void method_12()
			{
				this.gclass182_0.method_37();
			}

			// Token: 0x04001BE4 RID: 7140
			public Transform transform_0;

			// Token: 0x04001BE5 RID: 7141
			public GClass182 gclass182_0;
		}

		// Token: 0x02000369 RID: 873
		[CompilerGenerated]
		[Serializable]
		private sealed class Class208
		{
			// Token: 0x0600488A RID: 18570 RVA: 0x00111EF4 File Offset: 0x001100F4
			internal void method_0()
			{
				GClass84.gclass138_0.method_88();
			}

			// Token: 0x04001BE6 RID: 7142
			public static readonly GClass182.Class208 class208_0 = new GClass182.Class208();

			// Token: 0x04001BE7 RID: 7143
			public static Action action_0;
		}
	}
}
