using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns175;
using ns185;
using ns241;
using ns425;
using ns449;
using ns520;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;

namespace ns461
{
	// Token: 0x020002F2 RID: 754
	public class GClass165 : GClass130
	{
		// Token: 0x06003FDD RID: 16349 RVA: 0x000F19C8 File Offset: 0x000EFBC8
		private void method_2()
		{
			this.method_37();
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x000F19DC File Offset: 0x000EFBDC
		private void method_3()
		{
			this.method_30();
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x000F19F0 File Offset: 0x000EFBF0
		private void method_4()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			if (apiWorld != null)
			{
				string id = apiWorld.id;
				Clipboard.SetText(id);
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x000F1A18 File Offset: 0x000EFC18
		internal void method_5()
		{
			this.method_42();
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x000F1A2C File Offset: 0x000EFC2C
		private void method_6()
		{
			this.method_27();
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x000F1A40 File Offset: 0x000EFC40
		private void method_7()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			ApiWorldInstance apiWorldInstance = GClass84.smethod_326();
			if (apiWorld != null && apiWorldInstance != null)
			{
				string text = apiWorld.id + ":" + apiWorldInstance.instanceId;
				GClass84.gclass148_0.method_66(string.Concat(new string[]
				{
					"[] {",
					"Join",
					"Room",
					"(",
					text,
					");}"
				}));
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x000F1AC0 File Offset: 0x000EFCC0
		public override void vmethod_12()
		{
			this.method_5();
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x000F1AD4 File Offset: 0x000EFCD4
		internal void method_8()
		{
			if (this.bool_0)
			{
				try
				{
					ApiWorld apiWorld = GClass84.smethod_585();
					if (apiWorld != null)
					{
						if (this.gameObject_8.activeInHierarchy)
						{
							string text = GClass84.smethod_1204(this.textMeshProUGUI_1.text, 1, -1);
							text = GClass84.smethod_911(apiWorld, text);
							int num = GClass192.smethod_5(GClass84.gclass56_0.list_0, apiWorld.id, text);
							if (num != -1)
							{
								this.textMeshProUGUI_0.text = this.method_13(num);
								this.gameObject_7.SetActive(true);
							}
							else
							{
								this.gameObject_7.SetActive(false);
							}
							foreach (GameObject gameObject in GClass84.smethod_1034(this.gameObject_11))
							{
								if (gameObject.activeSelf)
								{
									GameObject gameObject2 = GClass84.smethod_138(gameObject, "RoomImageShape/RoomImage/Panel - Instance");
									GameObject gameObject_ = gameObject;
									string[] array2 = new string[10];
									array2[0] = "Room";
									array2[1] = "Image";
									array2[2] = "Shape";
									array2[3] = "/";
									array2[4] = "Room";
									array2[5] = "Image";
									array2[6] = "/";
									int num2 = 7;
									TextMeshProUGUI textMeshProUGUI = this.textMeshProUGUI_0;
									array2[num2] = ((textMeshProUGUI != null) ? textMeshProUGUI.ToString() : null);
									array2[8] = " - ";
									array2[9] = "Instance";
									GameObject gameObject3 = GClass84.smethod_138(gameObject_, string.Concat(array2));
									Text text2 = null;
									Text text3 = null;
									if (!gameObject3)
									{
										if (gameObject2)
										{
											gameObject3 = Object.Instantiate<GameObject>(gameObject2, gameObject2.transform.parent);
											Object @object = gameObject3;
											TextMeshProUGUI textMeshProUGUI2 = this.textMeshProUGUI_0;
											@object.name = ((textMeshProUGUI2 != null) ? textMeshProUGUI2.ToString() : null) + " - " + "Instance";
											RectTransform component = gameObject3.GetComponent<RectTransform>();
											Vector3 localPosition = component.localPosition;
											localPosition.y -= component.sizeDelta.y;
											component.localPosition = localPosition;
											text2 = gameObject2.GetComponentInChildren<Text>(true);
											text3 = gameObject3.GetComponentInChildren<Text>(true);
											if (!text2 || !text3)
											{
												GClass84.smethod_890(gameObject3, false);
											}
										}
									}
									else
									{
										text2 = gameObject2.GetComponentInChildren<Text>(true);
										text3 = gameObject3.GetComponentInChildren<Text>(true);
									}
									if (gameObject3 && text2 && text3)
									{
										int num3 = GClass84.smethod_1611(text2.text, " ");
										if (num3 != -1)
										{
											text = GClass84.smethod_1428(text2.text, num3);
										}
										else
										{
											text = text2.text;
										}
										text = GClass84.smethod_911(apiWorld, GClass84.smethod_1204(text, 1, -1));
										num = GClass192.smethod_5(GClass84.gclass56_0.list_0, apiWorld.id, text);
										if (num != -1)
										{
											text3.text = this.method_13(num);
											gameObject3.SetActive(true);
										}
										else
										{
											gameObject3.SetActive(false);
										}
									}
								}
							}
						}
						else
						{
							this.gameObject_7.SetActive(false);
						}
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x000F1E04 File Offset: 0x000F0004
		private string method_9(int int_0)
		{
			return "History" + ": " + int_0.ToString();
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x000F1E2C File Offset: 0x000F002C
		private void method_10()
		{
			this.method_44();
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x000F1E40 File Offset: 0x000F0040
		[CompilerGenerated]
		private void method_11()
		{
			this.method_28();
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x000F1E54 File Offset: 0x000F0054
		[CompilerGenerated]
		private void method_12()
		{
			this.method_3();
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x000F1E68 File Offset: 0x000F0068
		private string method_13(int int_0)
		{
			return this.method_24(int_0);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x000F1E7C File Offset: 0x000F007C
		private void method_14()
		{
			this.method_39();
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x000F1E90 File Offset: 0x000F0090
		public override void vmethod_23()
		{
			this.method_23();
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x000F1EA4 File Offset: 0x000F00A4
		private void method_15()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			ApiWorldInstance apiWorldInstance = GClass84.smethod_326();
			if (apiWorld != null && apiWorldInstance != null)
			{
				string text = apiWorld.id + ":" + apiWorldInstance.instanceId;
				Clipboard.SetText(text);
			}
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x000F1EE8 File Offset: 0x000F00E8
		private void method_16()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			if (apiWorld != null)
			{
				GClass84.gclass181_0.method_9(apiWorld.name, apiWorld.id);
			}
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x000F1F18 File Offset: 0x000F0118
		private void method_17()
		{
			this.method_4();
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x000F1F2C File Offset: 0x000F012C
		private void method_18()
		{
			this.method_2();
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x000F1F40 File Offset: 0x000F0140
		private void method_19()
		{
			this.method_15();
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x000F1F54 File Offset: 0x000F0154
		private void method_20()
		{
			this.method_7();
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x000F1F68 File Offset: 0x000F0168
		private void method_21()
		{
			this.method_14();
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x000F1F7C File Offset: 0x000F017C
		private void method_22()
		{
			this.method_29();
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x000F1F90 File Offset: 0x000F0190
		internal void method_23()
		{
			this.method_47();
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000F1FA4 File Offset: 0x000F01A4
		private string method_24(int int_0)
		{
			return this.method_9(int_0);
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x000F1FB8 File Offset: 0x000F01B8
		private void method_25()
		{
			this.method_18();
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x000F1FCC File Offset: 0x000F01CC
		internal void method_26()
		{
			this.method_8();
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x000F1FE0 File Offset: 0x000F01E0
		private void method_27()
		{
			this.method_46();
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x000F1FF4 File Offset: 0x000F01F4
		private void method_28()
		{
			this.method_31();
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x000F2008 File Offset: 0x000F0208
		private void method_29()
		{
			this.method_16();
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x000F201C File Offset: 0x000F021C
		private void method_30()
		{
			this.method_22();
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x000F204C File Offset: 0x000F024C
		private void method_31()
		{
			this.method_41();
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000F2060 File Offset: 0x000F0260
		[CompilerGenerated]
		private void method_32()
		{
			this.method_6();
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x000F2074 File Offset: 0x000F0274
		private void method_33()
		{
			this.method_45();
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x000F2088 File Offset: 0x000F0288
		[CompilerGenerated]
		private void method_34()
		{
			this.method_36();
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000F209C File Offset: 0x000F029C
		[CompilerGenerated]
		private void method_35()
		{
			this.method_33();
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000F20B0 File Offset: 0x000F02B0
		private void method_36()
		{
			this.method_10();
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x000F20C4 File Offset: 0x000F02C4
		private void method_37()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			if (apiWorld != null)
			{
				string assetUrl = apiWorld.assetUrl;
				Clipboard.SetText(assetUrl);
				GClass70.smethod_38(assetUrl, GClass70.Enum1.const_0);
				Process.Start(assetUrl);
			}
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x000F20F8 File Offset: 0x000F02F8
		private GameObject method_38(string string_1, float float_0, float float_1, float float_2, float float_3, string string_2, Action action_0, Texture texture_0 = null, Color? nullable_0 = null, Color? nullable_1 = null)
		{
			GameObject gameObject = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Back Button");
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
			Text[] array = gameObject2.GetComponentsInChildren<Text>();
			GClass84.smethod_243(gameObject2.GetComponent<Button>(), action_0);
			foreach (Text text in array)
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

		// Token: 0x06004005 RID: 16389 RVA: 0x000F2294 File Offset: 0x000F0494
		private void method_39()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			ApiWorldInstance apiWorldInstance = GClass84.smethod_326();
			if (apiWorld != null && apiWorldInstance != null)
			{
				GClass84.gclass181_0.method_4(apiWorld.name, apiWorld.id, apiWorldInstance.instanceId);
			}
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x000F22D8 File Offset: 0x000F04D8
		[CompilerGenerated]
		private void method_40()
		{
			this.method_43();
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x000F22EC File Offset: 0x000F04EC
		public override void vmethod_24()
		{
			this.method_26();
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x000F2300 File Offset: 0x000F0500
		private void method_41()
		{
			this.method_19();
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x000F2314 File Offset: 0x000F0514
		internal void method_42()
		{
			try
			{
				this.gameObject_0 = this.method_38("AddInstanceToListButton", 8f, -135f, 240f, 70f, "Add Instance To List", new Action(this.method_35), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				this.gameObject_1 = this.method_38("AddWorldToListButton", 8f, -205f, 240f, 70f, "Add World To List", new Action(this.method_12), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				this.gameObject_2 = this.method_38("DownloadWorldButton", 8f, -275f, 240f, 70f, "Download World", new Action(this.method_40), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				this.gameObject_3 = this.method_38("CopyWorldIDButton", 248f, -135f, 240f, 70f, "Copy World ID", new Action(this.method_34), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				this.gameObject_4 = this.method_38("CopyInstanceIDButton", 248f, -205f, 240f, 70f, "Copy Instance ID", new Action(this.method_11), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				this.gameObject_6 = this.method_38("Join_BotButton", 248f, -275f, 240f, 70f, "Join (Bot)", new Action(this.method_32), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				if (GClass84.gclass138_0 != null)
				{
					this.gameObject_5 = this.method_38("ReuploadButton", 488f, -135f, 240f, 70f, "Reupload World", new Action(GClass165.Class183.class183_0.method_0), GClass153.GClass87.texture2D_5, new Color?(Color.white), null);
				}
				this.gameObject_9 = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceNameBackground");
				this.textMeshProUGUI_1 = this.gameObject_9.GetComponentInChildren<TextMeshProUGUI>();
				this.gameObject_10 = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceTypeBackground");
				this.textMeshProUGUI_2 = this.gameObject_10.GetComponentInChildren<TextMeshProUGUI>();
				this.gameObject_11 = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/ViewPort/Content");
				this.transform_1 = this.gameObject_11.transform;
				this.gameObject_7 = Object.Instantiate<GameObject>(this.gameObject_10, this.gameObject_10.transform.parent);
				Object @object = this.gameObject_7;
				string str = "Instance";
				TextMeshProUGUI textMeshProUGUI = this.textMeshProUGUI_0;
				@object.name = str + ((textMeshProUGUI != null) ? textMeshProUGUI.ToString() : null) + "Background";
				this.rectTransform_0 = this.gameObject_7.GetComponent<RectTransform>();
				this.transform_0 = this.rectTransform_0.parent;
				this.gameObject_8 = this.transform_0.gameObject;
				Vector3 localPosition = this.rectTransform_0.localPosition;
				localPosition.y -= this.rectTransform_0.sizeDelta.y;
				this.rectTransform_0.localPosition = localPosition;
				this.textMeshProUGUI_0 = this.gameObject_7.GetComponentInChildren<TextMeshProUGUI>();
				this.gameObject_7.SetActive(false);
				GClass67.smethod_0();
				this.bool_0 = true;
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x000F26D0 File Offset: 0x000F08D0
		private void method_43()
		{
			this.method_25();
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x000F26E4 File Offset: 0x000F08E4
		private void method_44()
		{
			this.method_17();
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x000F26F8 File Offset: 0x000F08F8
		private void method_45()
		{
			this.method_21();
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x000F270C File Offset: 0x000F090C
		private void method_46()
		{
			this.method_20();
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x000F2720 File Offset: 0x000F0920
		internal void method_47()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x040018AF RID: 6319
		private GameObject gameObject_0;

		// Token: 0x040018B0 RID: 6320
		private GameObject gameObject_1;

		// Token: 0x040018B1 RID: 6321
		private GameObject gameObject_2;

		// Token: 0x040018B2 RID: 6322
		private GameObject gameObject_3;

		// Token: 0x040018B3 RID: 6323
		private GameObject gameObject_4;

		// Token: 0x040018B4 RID: 6324
		private GameObject gameObject_5;

		// Token: 0x040018B5 RID: 6325
		private GameObject gameObject_6;

		// Token: 0x040018B6 RID: 6326
		private GameObject gameObject_7;

		// Token: 0x040018B7 RID: 6327
		private GameObject gameObject_8;

		// Token: 0x040018B8 RID: 6328
		private RectTransform rectTransform_0;

		// Token: 0x040018B9 RID: 6329
		private Transform transform_0;

		// Token: 0x040018BA RID: 6330
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x040018BB RID: 6331
		private GameObject gameObject_9;

		// Token: 0x040018BC RID: 6332
		private TextMeshProUGUI textMeshProUGUI_1;

		// Token: 0x040018BD RID: 6333
		private GameObject gameObject_10;

		// Token: 0x040018BE RID: 6334
		private TextMeshProUGUI textMeshProUGUI_2;

		// Token: 0x040018BF RID: 6335
		private GameObject gameObject_11;

		// Token: 0x040018C0 RID: 6336
		private Transform transform_1;

		// Token: 0x040018C1 RID: 6337
		private bool bool_0 = false;

		// Token: 0x020002F3 RID: 755
		[CompilerGenerated]
		[Serializable]
		private sealed class Class183
		{
			// Token: 0x06004011 RID: 16401 RVA: 0x000F2774 File Offset: 0x000F0974
			internal void method_0()
			{
				GClass84.gclass138_0.method_41();
			}

			// Token: 0x040018C2 RID: 6338
			public static readonly GClass165.Class183 class183_0 = new GClass165.Class183();

			// Token: 0x040018C3 RID: 6339
			public static Action action_0;
		}
	}
}
