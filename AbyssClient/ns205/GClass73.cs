using System;
using System.Collections.Generic;
using System.Linq;
using ns185;
using ns241;
using ns290;
using ns449;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace ns205
{
	// Token: 0x0200014B RID: 331
	public class GClass73
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0002FF38 File Offset: 0x0002E138
		internal static GameObject smethod_0()
		{
			if (GClass73.gameObject_6 == null)
			{
				GClass73.gameObject_6 = new GameObject("TextReference");
				GClass73.gameObject_6.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass73.gameObject_6.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass88.texture2D_9;
				rawImage.color = new Color(1f, 1f, 1f);
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
				RectTransform component = GClass73.gameObject_6.GetComponent<RectTransform>();
				GClass73.gameObject_6.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(-384f, 384f);
				component.localRotation = default(Quaternion);
				GameObject gameObject = new GameObject("Text");
				gameObject.AddComponent<CanvasRenderer>();
				Text text = gameObject.AddComponent<Text>();
				text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text.resizeTextMaxSize = 40;
				text.resizeTextMinSize = 3;
				text.fontSize = 40;
				text.alignment = 4;
				GClass84.smethod_626(text);
				RectTransform component2 = gameObject.GetComponent<RectTransform>();
				gameObject.transform.SetParent(GClass73.gameObject_6.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass73.gameObject_6.SetActive(false);
			}
			return GClass73.gameObject_6;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000301A0 File Offset: 0x0002E3A0
		internal static void smethod_1(string string_0)
		{
			GClass73.smethod_16(string_0);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000301B4 File Offset: 0x0002E3B4
		internal static Transform smethod_2(Transform transform_0)
		{
			return (transform_0 != null) ? transform_0.Find("ScrollRect/Viewport/VerticalLayoutGroup") : null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000301D4 File Offset: 0x0002E3D4
		internal static GameObject smethod_3()
		{
			if (GClass73.gameObject_11 == null)
			{
				GClass73.gameObject_11 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Settings").gameObject);
				List<Component> list = GClass73.gameObject_11.GetComponents<Component>().ToList<Component>();
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (!(list[i].GetType() == typeof(RectTransform)) && !(list[i].GetType() == typeof(CanvasGroup)))
					{
						Object.DestroyImmediate(list[i]);
					}
				}
				List<Transform> list2 = GClass84.smethod_152(GClass73.gameObject_11);
				for (int j = list2.Count - 1; j >= 0; j--)
				{
					if (list2[j].name == "QMHeader_H1")
					{
						List<Transform> list3 = GClass84.smethod_403(list2[j]);
						for (int k = list3.Count - 1; k >= 0; k--)
						{
							if (list3[k].name == "HeaderBackground")
							{
								List<Transform> list4 = GClass84.smethod_403(list3[k]);
								for (int l = list4.Count - 1; l >= 0; l--)
								{
									Object.DestroyImmediate(list4[l].gameObject);
								}
							}
							else if (list3[k].name == "LeftItemContainer")
							{
								List<Transform> list5 = GClass84.smethod_403(list3[k]);
								for (int m = list5.Count - 1; m >= 0; m--)
								{
									if (list5[m].name == "Button_Back")
									{
										List<Transform> list6 = GClass84.smethod_403(list5[m]);
										for (int n = list6.Count - 1; n >= 0; n--)
										{
											if (list6[n].name == "Icon")
											{
												List<Transform> list7 = GClass84.smethod_403(list6[n]);
												for (int num = list7.Count - 1; num >= 0; num--)
												{
													Object.DestroyImmediate(list7[num].gameObject);
												}
											}
											else if (list6[n].name == "Badge_UnfinishedFeature")
											{
												List<Transform> list8 = GClass84.smethod_403(list6[n]);
												for (int num2 = list8.Count - 1; num2 >= 0; num2--)
												{
													Object.DestroyImmediate(list8[num2].gameObject);
												}
											}
											else
											{
												Object.DestroyImmediate(list6[n].gameObject);
											}
										}
									}
									else if (list5[m].name == "Text_Title")
									{
										List<Transform> list9 = GClass84.smethod_403(list5[m]);
										for (int num3 = list9.Count - 1; num3 >= 0; num3--)
										{
											Object.DestroyImmediate(list9[num3].gameObject);
										}
									}
									else
									{
										Object.DestroyImmediate(list5[m].gameObject);
									}
								}
							}
							else if (list3[k].name == "RightItemContainer")
							{
								List<Transform> list10 = GClass84.smethod_403(list3[k]);
								for (int num4 = list10.Count - 1; num4 >= 0; num4--)
								{
									if (list10[num4].name == "Button_QM_Exit")
									{
										List<Transform> list11 = GClass84.smethod_403(list10[num4]);
										for (int num5 = list11.Count - 1; num5 >= 0; num5--)
										{
											if (list11[num5].name == "Icon")
											{
												List<Transform> list12 = GClass84.smethod_403(list11[num5]);
												for (int num6 = list12.Count - 1; num6 >= 0; num6--)
												{
													Object.DestroyImmediate(list12[num6].gameObject);
												}
											}
											else if (list11[num5].name == "Badge_UnfinishedFeature")
											{
												List<Transform> list13 = GClass84.smethod_403(list11[num5]);
												for (int num7 = list13.Count - 1; num7 >= 0; num7--)
												{
													Object.DestroyImmediate(list13[num7].gameObject);
												}
											}
											else
											{
												Object.DestroyImmediate(list11[num5].gameObject);
											}
										}
									}
									else if (list10[num4].name == "Button_QM_Expand")
									{
										List<Transform> list14 = GClass84.smethod_403(list10[num4]);
										for (int num8 = list14.Count - 1; num8 >= 0; num8--)
										{
											if (list14[num8].name == "Icon")
											{
												List<Transform> list15 = GClass84.smethod_403(list14[num8]);
												for (int num9 = list15.Count - 1; num9 >= 0; num9--)
												{
													Object.DestroyImmediate(list15[num9].gameObject);
												}
											}
											else if (list14[num8].name == "Badge_UnfinishedFeature")
											{
												List<Transform> list16 = GClass84.smethod_403(list14[num8]);
												for (int num10 = list16.Count - 1; num10 >= 0; num10--)
												{
													Object.DestroyImmediate(list16[num10].gameObject);
												}
											}
											else
											{
												Object.DestroyImmediate(list14[num8].gameObject);
											}
										}
									}
									else
									{
										Object.DestroyImmediate(list10[num4].gameObject);
									}
								}
							}
							else
							{
								Object.DestroyImmediate(list3[k].gameObject);
							}
						}
					}
					else if (list2[j].name == "Panel_QM_ScrollRect")
					{
						List<Transform> list17 = GClass84.smethod_403(list2[j]);
						for (int num11 = list17.Count - 1; num11 >= 0; num11--)
						{
							if (list17[num11].name == "Viewport")
							{
								List<Transform> list18 = GClass84.smethod_403(list17[num11]);
								for (int num12 = list18.Count - 1; num12 >= 0; num12--)
								{
									if (list18[num12].name == "VerticalLayoutGroup")
									{
										ContentSizeFitter component = list18[num12].GetComponent<ContentSizeFitter>();
										if (component)
										{
											component.enabled = false;
										}
										VerticalLayoutGroup component2 = list18[num12].GetComponent<VerticalLayoutGroup>();
										if (component2)
										{
											component2.enabled = false;
										}
										List<Transform> list19 = GClass84.smethod_403(list18[num12]);
										for (int num13 = list19.Count - 1; num13 >= 0; num13--)
										{
											Object.DestroyImmediate(list19[num13].gameObject);
										}
									}
									else
									{
										Object.DestroyImmediate(list18[num12].gameObject);
									}
								}
							}
							else if (list17[num11].name == "Scrollbar")
							{
								List<Transform> list20 = GClass84.smethod_403(list17[num11]);
								for (int num14 = list20.Count - 1; num14 >= 0; num14--)
								{
									if (list20[num14].name == "Sliding Area")
									{
										List<Transform> list21 = GClass84.smethod_403(list20[num14]);
										for (int num15 = list21.Count - 1; num15 >= 0; num15--)
										{
											if (list21[num15].name == "Handle")
											{
												List<Transform> list22 = GClass84.smethod_403(list21[num14]);
												for (int num16 = list22.Count - 1; num16 >= 0; num16--)
												{
													Object.DestroyImmediate(list22[num16].gameObject);
												}
											}
											else
											{
												Object.DestroyImmediate(list21[num15].gameObject);
											}
										}
									}
									else
									{
										Object.DestroyImmediate(list20[num14].gameObject);
									}
								}
							}
							else
							{
								Object.DestroyImmediate(list17[num11].gameObject);
							}
						}
					}
					else
					{
						Object.DestroyImmediate(list2[j].gameObject);
					}
				}
				GClass73.gameObject_11.AddComponent<UIPage>();
				GClass73.gameObject_11.SetActive(false);
			}
			return GClass73.gameObject_11;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		internal static string smethod_4(string string_0, float float_0, float float_1)
		{
			return string.Concat(new string[]
			{
				"AbyssClient_",
				string_0,
				"_",
				float_0.ToString(),
				"_",
				float_1.ToString()
			});
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00030AFC File Offset: 0x0002ECFC
		internal static GameObject smethod_5()
		{
			if (GClass73.gameObject_5 == null)
			{
				GClass73.gameObject_5 = Object.Instantiate<GameObject>(GClass73.smethod_15().transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard").gameObject);
				GameObject gameObject = GClass84.smethod_138(GClass73.gameObject_5, "Icon");
				Image component = gameObject.GetComponent<Image>();
				Object.DestroyImmediate(component);
				RawImage rawImage = gameObject.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass88.texture2D_9;
				rawImage.color = new Color(1f, 1f, 1f);
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
				GClass73.gameObject_5.SetActive(false);
			}
			return GClass73.gameObject_5;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00030C00 File Offset: 0x0002EE00
		internal static GameObject smethod_6()
		{
			if (GClass73.gameObject_10 == null)
			{
				GClass73.gameObject_10 = new GameObject("SingleButtonReference");
				GClass73.gameObject_10.AddComponent<CanvasRenderer>();
				RectTransform rectTransform = GClass73.gameObject_10.AddComponent<RectTransform>();
				GClass73.gameObject_10.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				Vector2 vector = rectTransform.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				rectTransform.anchorMin = vector;
				vector = rectTransform.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				rectTransform.anchorMax = vector;
				rectTransform.sizeDelta = new Vector2(256f, 256f);
				rectTransform.localPosition = new Vector2(-384f, 384f);
				rectTransform.localRotation = default(Quaternion);
				GameObject gameObject = new GameObject("ON");
				gameObject.AddComponent<CanvasRenderer>();
				RawImage rawImage = gameObject.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass88.texture2D_32;
				rawImage.color = new Color(1f, 1f, 1f);
				Rect uvRect = rawImage.uvRect;
				vector = uvRect.position;
				vector.x = 0f;
				vector.y = 0f;
				uvRect.position = vector;
				vector = uvRect.size;
				vector.x = 1f;
				vector.y = 1f;
				uvRect.size = vector;
				rawImage.uvRect = uvRect;
				RectTransform component = gameObject.GetComponent<RectTransform>();
				gameObject.transform.SetParent(GClass73.gameObject_10.transform, false);
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(0f, 0f);
				component.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				gameObject.AddComponent<Button>();
				GameObject gameObject2 = new GameObject("Text_ON");
				gameObject2.AddComponent<CanvasRenderer>();
				Text text = gameObject2.AddComponent<Text>();
				text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text.resizeTextMaxSize = 40;
				text.resizeTextMinSize = 3;
				text.fontSize = 40;
				text.alignment = 4;
				GClass84.smethod_626(text);
				RectTransform component2 = gameObject2.GetComponent<RectTransform>();
				gameObject2.transform.SetParent(gameObject.transform, false);
				component2.sizeDelta = new Vector2(-40f, -158f);
				component2.localPosition = new Vector2(0f, 52f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GameObject gameObject3 = new GameObject("Text_OFF");
				gameObject3.AddComponent<CanvasRenderer>();
				Text text2 = gameObject3.AddComponent<Text>();
				text2.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text2.resizeTextMaxSize = 40;
				text2.resizeTextMinSize = 3;
				text2.fontSize = 40;
				text2.alignment = 4;
				GClass84.smethod_626(text2);
				text2.color = Color.grey;
				RectTransform component3 = gameObject3.GetComponent<RectTransform>();
				gameObject3.transform.SetParent(gameObject.transform, false);
				component3.sizeDelta = new Vector2(-40f, -158f);
				component3.localPosition = new Vector2(0f, -52f);
				component3.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GameObject gameObject4 = new GameObject("OFF");
				gameObject4.AddComponent<CanvasRenderer>();
				RawImage rawImage2 = gameObject4.AddComponent<RawImage>();
				rawImage2.texture = GClass153.GClass88.texture2D_30;
				rawImage2.color = new Color(1f, 1f, 1f);
				Rect uvRect2 = rawImage2.uvRect;
				vector = uvRect2.position;
				vector.x = 0f;
				vector.y = 0f;
				uvRect2.position = vector;
				vector = uvRect2.size;
				vector.x = 1f;
				vector.y = 1f;
				uvRect2.size = vector;
				rawImage2.uvRect = uvRect2;
				RectTransform component4 = gameObject4.GetComponent<RectTransform>();
				gameObject4.transform.SetParent(GClass73.gameObject_10.transform, false);
				component4.sizeDelta = new Vector2(256f, 256f);
				component4.localPosition = new Vector2(0f, 0f);
				component4.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				gameObject4.AddComponent<Button>();
				GameObject gameObject5 = new GameObject("Text_ON");
				gameObject5.AddComponent<CanvasRenderer>();
				Text text3 = gameObject5.AddComponent<Text>();
				text3.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text3.resizeTextMaxSize = 40;
				text3.resizeTextMinSize = 3;
				text3.fontSize = 40;
				text3.alignment = 4;
				GClass84.smethod_626(text3);
				text3.color = Color.grey;
				RectTransform component5 = gameObject5.GetComponent<RectTransform>();
				gameObject5.transform.SetParent(gameObject4.transform, false);
				component5.sizeDelta = new Vector2(-40f, -158f);
				component5.localPosition = new Vector2(0f, 52f);
				component5.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GameObject gameObject6 = new GameObject("Text_OFF");
				gameObject6.AddComponent<CanvasRenderer>();
				Text text4 = gameObject6.AddComponent<Text>();
				text4.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text4.resizeTextMaxSize = 40;
				text4.resizeTextMinSize = 3;
				text4.fontSize = 40;
				text4.alignment = 4;
				GClass84.smethod_626(text4);
				RectTransform component6 = gameObject6.GetComponent<RectTransform>();
				gameObject6.transform.SetParent(gameObject4.transform, false);
				component6.sizeDelta = new Vector2(-40f, -158f);
				component6.localPosition = new Vector2(0f, -52f);
				component6.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass73.gameObject_10.SetActive(false);
			}
			return GClass73.gameObject_10;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0003126C File Offset: 0x0002F46C
		internal static string smethod_7(GClass95 gclass95_0, string string_0)
		{
			return "AbyssClient_" + gclass95_0.method_7() + "_" + string_0;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00031294 File Offset: 0x0002F494
		internal static GameObject smethod_8()
		{
			if (GClass73.gameObject_4 == null)
			{
				GClass73.gameObject_4 = Object.Instantiate<GameObject>(GClass84.smethod_317().transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Header_DevTools").gameObject);
				Object.DestroyImmediate(GClass73.gameObject_4.GetComponentInChildren<AvatarHiddenReasonLabel>());
				GClass73.gameObject_4.SetActive(false);
			}
			return GClass73.gameObject_4;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000312F4 File Offset: 0x0002F4F4
		internal static BoxCollider smethod_9()
		{
			if (GClass73.boxCollider_0 == null)
			{
				GClass73.boxCollider_0 = GClass73.smethod_15().GetComponent<BoxCollider>();
			}
			return GClass73.boxCollider_0;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00031324 File Offset: 0x0002F524
		internal static GameObject smethod_10()
		{
			if (GClass73.gameObject_3 == null)
			{
				GClass73.gameObject_3 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks").gameObject);
				List<Transform> list = GClass84.smethod_152(GClass73.gameObject_3);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					Object.DestroyImmediate(list[i].gameObject);
				}
				GClass73.gameObject_3.SetActive(false);
			}
			return GClass73.gameObject_3;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000313A4 File Offset: 0x0002F5A4
		internal static void smethod_11(string string_0)
		{
			try
			{
				MenuStateController menuStateController = GClass84.smethod_257();
				if (menuStateController)
				{
					UIPage uipage = null;
					foreach (string text in menuStateController.field_Private_Dictionary_2_String_UIPage_0.Keys)
					{
						if (text == string_0)
						{
							uipage = menuStateController.field_Private_Dictionary_2_String_UIPage_0[text];
							IL_51:
							if (uipage)
							{
								for (int i = 0; i < menuStateController.field_Public_ArrayOf_UIPage_0.Count; i++)
								{
									if (menuStateController.field_Public_ArrayOf_UIPage_0[i] == uipage)
									{
										menuStateController.ShowTabContent(i, false, false);
										break;
									}
								}
								goto IL_96;
							}
							goto IL_96;
						}
					}
					goto IL_51;
				}
				IL_96:;
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0003146C File Offset: 0x0002F66C
		internal static string smethod_12(string string_0, string string_1)
		{
			return GClass73.smethod_21(string_0, string_1);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00031480 File Offset: 0x0002F680
		internal static GameObject smethod_13()
		{
			if (GClass73.gameObject_7 == null)
			{
				GClass73.gameObject_7 = new GameObject("CheckBoxButtonReference");
				GClass73.gameObject_7.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass73.gameObject_7.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass87.texture2D_0;
				rawImage.color = new Color(1f, 1f, 1f);
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
				RectTransform component = GClass73.gameObject_7.GetComponent<RectTransform>();
				GClass73.gameObject_7.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(-384f, 384f);
				component.localRotation = default(Quaternion);
				GClass73.gameObject_7.AddComponent<Button>();
				GameObject gameObject = new GameObject("Checkmark");
				gameObject.AddComponent<CanvasRenderer>();
				RawImage rawImage2 = gameObject.AddComponent<RawImage>();
				rawImage2.texture = GClass153.GClass88.texture2D_8;
				rawImage2.color = new Color(1f, 1f, 1f);
				Rect uvRect2 = rawImage.uvRect;
				vector = uvRect2.position;
				vector.x = 0f;
				vector.y = 0f;
				uvRect2.position = vector;
				vector = uvRect2.size;
				vector.x = 1f;
				vector.y = 1f;
				uvRect2.size = vector;
				rawImage.uvRect = uvRect2;
				RectTransform component2 = gameObject.GetComponent<RectTransform>();
				gameObject.transform.SetParent(GClass73.gameObject_7.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass73.gameObject_7.SetActive(false);
			}
			return GClass73.gameObject_7;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00031744 File Offset: 0x0002F944
		internal static Transform smethod_14(string string_0, string string_1, bool bool_0 = true, bool bool_1 = true, bool bool_2 = false, Action action_0 = null, string string_2 = "", Sprite sprite_0 = null, bool bool_3 = false)
		{
			return null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00031754 File Offset: 0x0002F954
		internal static QuickMenu smethod_15()
		{
			return GClass84.smethod_728();
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00031768 File Offset: 0x0002F968
		internal static void smethod_16(string string_0)
		{
			GClass73.smethod_11(string_0);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0003177C File Offset: 0x0002F97C
		internal static string smethod_17(string string_0, float float_0, float float_1)
		{
			return GClass73.smethod_24(string_0, float_0, float_1);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00031794 File Offset: 0x0002F994
		internal static string smethod_18(GClass95 gclass95_0, float float_0, float float_1)
		{
			return GClass73.smethod_31(gclass95_0, float_0, float_1);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000317AC File Offset: 0x0002F9AC
		internal static VRCUiManager smethod_19()
		{
			if (GClass73.vrcuiManager_0 == null)
			{
				GClass73.vrcuiManager_0 = VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
			}
			return GClass73.vrcuiManager_0;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000317D8 File Offset: 0x0002F9D8
		internal static string smethod_20(string string_0, string string_1)
		{
			return "AbyssClient_" + string_0 + "_" + string_1;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000317F8 File Offset: 0x0002F9F8
		internal static string smethod_21(string string_0, string string_1)
		{
			return GClass73.smethod_20(string_0, string_1);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0003180C File Offset: 0x0002FA0C
		internal static GameObject smethod_22()
		{
			if (GClass73.gameObject_2 == null)
			{
				GClass73.gameObject_2 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn").gameObject);
				GClass73.gameObject_2.SetActive(false);
			}
			return GClass73.gameObject_2;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00031858 File Offset: 0x0002FA58
		internal static string smethod_23(GClass95 gclass95_0, string string_0)
		{
			return GClass73.smethod_7(gclass95_0, string_0);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0003186C File Offset: 0x0002FA6C
		internal static string smethod_24(string string_0, float float_0, float float_1)
		{
			return GClass73.smethod_4(string_0, float_0, float_1);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00031884 File Offset: 0x0002FA84
		internal static Transform smethod_25(Transform transform_0)
		{
			return (transform_0 != null) ? transform_0.Find("Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup") : null;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000318A4 File Offset: 0x0002FAA4
		internal static string smethod_26(GClass95 gclass95_0, float float_0, float float_1)
		{
			return GClass73.smethod_18(gclass95_0, float_0, float_1);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000318BC File Offset: 0x0002FABC
		internal static GameObject smethod_27()
		{
			if (GClass73.gameObject_1 == null)
			{
				GClass73.gameObject_1 = new GameObject("SingleButtonReference");
				GClass73.gameObject_1.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass73.gameObject_1.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass88.texture2D_9;
				rawImage.color = new Color(1f, 1f, 1f);
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
				RectTransform component = GClass73.gameObject_1.GetComponent<RectTransform>();
				GClass73.gameObject_1.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(-384f, 384f);
				component.localRotation = default(Quaternion);
				GClass73.gameObject_1.AddComponent<Button>();
				GameObject gameObject = new GameObject("Text");
				gameObject.AddComponent<CanvasRenderer>();
				Text text = gameObject.AddComponent<Text>();
				text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text.resizeTextMaxSize = 40;
				text.resizeTextMinSize = 3;
				text.fontSize = 40;
				text.alignment = 4;
				GClass84.smethod_626(text);
				RectTransform component2 = gameObject.GetComponent<RectTransform>();
				gameObject.transform.SetParent(GClass73.gameObject_1.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass73.gameObject_1.SetActive(false);
			}
			return GClass73.gameObject_1;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00031B30 File Offset: 0x0002FD30
		internal static string smethod_28(GClass95 gclass95_0, string string_0)
		{
			return GClass73.smethod_23(gclass95_0, string_0);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00031B44 File Offset: 0x0002FD44
		internal static GameObject smethod_29()
		{
			if (GClass73.gameObject_9 == null)
			{
				GClass73.gameObject_9 = new GameObject("ColorImageReference");
				RawImage rawImage = GClass73.gameObject_9.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass87.texture2D_0;
				rawImage.color = new Color(1f, 1f, 1f);
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
				RectTransform component = GClass73.gameObject_9.GetComponent<RectTransform>();
				GClass73.gameObject_9.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(-384f, 384f);
				component.localRotation = default(Quaternion);
				GClass73.gameObject_9.SetActive(false);
			}
			return GClass73.gameObject_9;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00031CD0 File Offset: 0x0002FED0
		internal static GameObject smethod_30()
		{
			if (GClass73.gameObject_8 == null)
			{
				GClass73.gameObject_8 = new GameObject("SliderButtonReference");
				Slider slider = GClass73.gameObject_8.AddComponent<Slider>();
				GClass73.gameObject_8.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass73.gameObject_8.AddComponent<RawImage>();
				rawImage.texture = GClass153.GClass87.texture2D_0;
				rawImage.color = new Color(1f, 1f, 1f);
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
				RectTransform component = GClass73.gameObject_8.GetComponent<RectTransform>();
				GClass73.gameObject_8.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(256f, 256f);
				component.localPosition = new Vector2(-384f, 384f);
				component.localRotation = default(Quaternion);
				GameObject gameObject = new GameObject("FillArea");
				RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(GClass73.gameObject_8.transform, false);
				slider.m_FillContainerRect = rectTransform;
				vector = rectTransform.anchorMin;
				vector.x = 0f;
				vector.y = 0f;
				rectTransform.anchorMin = vector;
				vector = rectTransform.anchorMax;
				vector.x = 1f;
				vector.y = 1f;
				rectTransform.anchorMax = vector;
				vector = rectTransform.offsetMin;
				vector.x = 6f;
				vector.y = 6f;
				rectTransform.offsetMin = vector;
				vector = rectTransform.offsetMax;
				vector.x = -6f;
				vector.y = -6f;
				rectTransform.offsetMax = vector;
				rectTransform.sizeDelta = new Vector2(-12f, -12f);
				rectTransform.localPosition = new Vector2(0f, 0f);
				rectTransform.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GameObject gameObject2 = new GameObject("Fill");
				RawImage rawImage2 = gameObject2.AddComponent<RawImage>();
				rawImage2.texture = GClass153.GClass87.texture2D_0;
				rawImage2.color = new Color(1f, 1f, 1f);
				uvRect = rawImage2.uvRect;
				vector = uvRect.position;
				vector.x = 0f;
				vector.y = 0f;
				uvRect.position = vector;
				vector = uvRect.size;
				vector.x = 1f;
				vector.y = 1f;
				uvRect.size = vector;
				rawImage2.uvRect = uvRect;
				RectTransform component2 = gameObject2.GetComponent<RectTransform>();
				slider.fillRect = component2;
				slider.m_FillTransform = component2;
				gameObject2.transform.SetParent(gameObject.transform, false);
				vector = component2.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component2.anchorMin = vector;
				vector = component2.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component2.anchorMax = vector;
				component2.sizeDelta = new Vector2(256f, 256f);
				component2.localPosition = new Vector2(0f, 0f);
				vector = component2.offsetMin;
				vector.x = 0f;
				vector.y = 0f;
				component2.offsetMin = vector;
				vector = component2.offsetMax;
				vector.x = 0f;
				vector.y = 0f;
				component2.offsetMax = vector;
				component2.localRotation = default(Quaternion);
				GameObject gameObject3 = new GameObject("SliderLabel");
				gameObject3.AddComponent<CanvasRenderer>();
				Text text = gameObject3.AddComponent<Text>();
				text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				text.resizeTextMaxSize = 40;
				text.resizeTextMinSize = 3;
				text.fontSize = 40;
				text.alignment = 4;
				GClass84.smethod_626(text);
				RectTransform component3 = gameObject3.GetComponent<RectTransform>();
				gameObject3.transform.SetParent(GClass73.gameObject_8.transform, false);
				component3.sizeDelta = new Vector2(0f, 0f);
				component3.localPosition = new Vector2(0f, 0f);
				vector = component3.offsetMin;
				vector.x = 0f;
				vector.y = 0f;
				component3.offsetMin = vector;
				vector = component3.offsetMax;
				vector.x = 0f;
				vector.y = 0f;
				component3.offsetMax = vector;
				component3.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass73.gameObject_8.SetActive(false);
			}
			return GClass73.gameObject_8;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00032280 File Offset: 0x00030480
		internal static string smethod_31(GClass95 gclass95_0, float float_0, float float_1)
		{
			return string.Concat(new string[]
			{
				"AbyssClient_",
				gclass95_0.method_7(),
				"_",
				float_0.ToString(),
				"_",
				float_1.ToString()
			});
		}

		// Token: 0x040008EC RID: 2284
		private static BoxCollider boxCollider_0;

		// Token: 0x040008ED RID: 2285
		private static GameObject gameObject_0;

		// Token: 0x040008EE RID: 2286
		private static GameObject gameObject_1;

		// Token: 0x040008EF RID: 2287
		private static GameObject gameObject_2;

		// Token: 0x040008F0 RID: 2288
		private static GameObject gameObject_3;

		// Token: 0x040008F1 RID: 2289
		private static GameObject gameObject_4;

		// Token: 0x040008F2 RID: 2290
		private static GameObject gameObject_5;

		// Token: 0x040008F3 RID: 2291
		private static GameObject gameObject_6;

		// Token: 0x040008F4 RID: 2292
		private static GameObject gameObject_7;

		// Token: 0x040008F5 RID: 2293
		private static GameObject gameObject_8;

		// Token: 0x040008F6 RID: 2294
		private static GameObject gameObject_9;

		// Token: 0x040008F7 RID: 2295
		private static GameObject gameObject_10;

		// Token: 0x040008F8 RID: 2296
		private static GameObject gameObject_11;

		// Token: 0x040008F9 RID: 2297
		private static VRCUiManager vrcuiManager_0;
	}
}
