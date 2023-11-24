using System;
using System.Collections.Generic;
using System.Linq;
using ns185;
using ns241;
using ns302;
using ns449;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace ns410
{
	// Token: 0x02000314 RID: 788
	public class GClass124
	{
		// Token: 0x060040B7 RID: 16567 RVA: 0x000F44A4 File Offset: 0x000F26A4
		internal static GameObject smethod_0()
		{
			if (GClass124.gameObject_5 == null)
			{
				GClass124.gameObject_5 = Object.Instantiate<GameObject>(GClass124.smethod_26().transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard").gameObject);
				GameObject gameObject = GClass84.smethod_138(GClass124.gameObject_5, "Icon");
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
				GClass124.gameObject_5.SetActive(false);
			}
			return GClass124.gameObject_5;
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x000317D8 File Offset: 0x0002F9D8
		internal static string smethod_1(string string_0, string string_1)
		{
			return "AbyssClient_" + string_0 + "_" + string_1;
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x000F45A8 File Offset: 0x000F27A8
		internal static string smethod_2(GClass99 gclass99_0, float float_0, float float_1)
		{
			return GClass124.smethod_32(gclass99_0, float_0, float_1);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x000F45C0 File Offset: 0x000F27C0
		internal static string smethod_3(string string_0, float float_0, float float_1)
		{
			return GClass124.smethod_11(string_0, float_0, float_1);
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x000F45D8 File Offset: 0x000F27D8
		internal static GameObject smethod_4()
		{
			if (GClass124.gameObject_6 == null)
			{
				GClass124.gameObject_6 = new GameObject("TextReference");
				GClass124.gameObject_6.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass124.gameObject_6.AddComponent<RawImage>();
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
				RectTransform component = GClass124.gameObject_6.GetComponent<RectTransform>();
				GClass124.gameObject_6.transform.SetParent(GClass84.smethod_195().Find("/Menu_Dashboard"), false);
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
				gameObject.transform.SetParent(GClass124.gameObject_6.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass124.gameObject_6.SetActive(false);
			}
			return GClass124.gameObject_6;
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00031744 File Offset: 0x0002F944
		internal static Transform smethod_5(string string_0, string string_1, bool bool_0 = true, bool bool_1 = true, bool bool_2 = false, Action action_0 = null, string string_2 = "", Sprite sprite_0 = null, bool bool_3 = false)
		{
			return null;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x000F4840 File Offset: 0x000F2A40
		internal static GameObject smethod_6()
		{
			if (GClass124.gameObject_11 == null)
			{
				GClass124.gameObject_11 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Settings").gameObject);
				List<Component> list = GClass124.gameObject_11.GetComponents<Component>().ToList<Component>();
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (!(list[i].GetType() == typeof(RectTransform)) && !(list[i].GetType() == typeof(CanvasGroup)))
					{
						Object.DestroyImmediate(list[i]);
					}
				}
				List<Transform> list2 = GClass84.smethod_152(GClass124.gameObject_11);
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
				GClass124.gameObject_11.AddComponent<UIPage>();
				GClass124.gameObject_11.SetActive(false);
			}
			return GClass124.gameObject_11;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x000F511C File Offset: 0x000F331C
		internal static string smethod_7(GClass99 gclass99_0, string string_0)
		{
			return GClass124.smethod_28(gclass99_0, string_0);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x000F5130 File Offset: 0x000F3330
		internal static Transform smethod_8(Transform transform_0)
		{
			Transform result;
			if (transform_0 != null)
			{
				if ((result = transform_0.Find("ScrollRect/Viewport/VerticalLayoutGroup")) != null)
				{
					return result;
				}
			}
			result = ((transform_0 != null) ? transform_0.Find("Scrollrect/Viewport/VerticalLayoutGroup") : null);
			return result;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x000F5168 File Offset: 0x000F3368
		internal static BoxCollider smethod_9()
		{
			if (GClass124.boxCollider_0 == null)
			{
				GClass124.boxCollider_0 = GClass124.smethod_26().GetComponent<BoxCollider>();
			}
			return GClass124.boxCollider_0;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		internal static string smethod_10(string string_0, float float_0, float float_1)
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

		// Token: 0x060040C3 RID: 16579 RVA: 0x000F5198 File Offset: 0x000F3398
		internal static string smethod_11(string string_0, float float_0, float float_1)
		{
			return GClass124.smethod_10(string_0, float_0, float_1);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000F51B0 File Offset: 0x000F33B0
		internal static string smethod_12(GClass99 gclass99_0, string string_0)
		{
			return GClass124.smethod_7(gclass99_0, string_0);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x000F51C4 File Offset: 0x000F33C4
		internal static GameObject smethod_13()
		{
			if (GClass124.gameObject_9 == null)
			{
				GClass124.gameObject_9 = new GameObject("ColorImageReference");
				RawImage rawImage = GClass124.gameObject_9.AddComponent<RawImage>();
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
				RectTransform component = GClass124.gameObject_9.GetComponent<RectTransform>();
				GClass124.gameObject_9.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
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
				GClass124.gameObject_9.SetActive(false);
			}
			return GClass124.gameObject_9;
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x000F5350 File Offset: 0x000F3550
		internal static GameObject smethod_14()
		{
			if (GClass124.gameObject_7 == null)
			{
				GClass124.gameObject_7 = new GameObject("CheckBoxButtonReference");
				GClass124.gameObject_7.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass124.gameObject_7.AddComponent<RawImage>();
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
				RectTransform component = GClass124.gameObject_7.GetComponent<RectTransform>();
				GClass124.gameObject_7.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
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
				GClass124.gameObject_7.AddComponent<Button>();
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
				gameObject.transform.SetParent(GClass124.gameObject_7.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass124.gameObject_7.SetActive(false);
			}
			return GClass124.gameObject_7;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x000F5614 File Offset: 0x000F3814
		internal static string smethod_15(string string_0, string string_1)
		{
			return GClass124.smethod_1(string_0, string_1);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00031884 File Offset: 0x0002FA84
		internal static Transform smethod_16(Transform transform_0)
		{
			return (transform_0 != null) ? transform_0.Find("Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup") : null;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x000F5628 File Offset: 0x000F3828
		internal static string smethod_17(string string_0, string string_1)
		{
			return GClass124.smethod_15(string_0, string_1);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x000F563C File Offset: 0x000F383C
		internal static void smethod_18(string string_0)
		{
			GClass124.smethod_20(string_0);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000F5650 File Offset: 0x000F3850
		internal static GameObject smethod_19()
		{
			if (GClass124.gameObject_8 == null)
			{
				GClass124.gameObject_8 = new GameObject("SliderButtonReference");
				Slider slider = GClass124.gameObject_8.AddComponent<Slider>();
				GClass124.gameObject_8.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass124.gameObject_8.AddComponent<RawImage>();
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
				RectTransform component = GClass124.gameObject_8.GetComponent<RectTransform>();
				GClass124.gameObject_8.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
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
				gameObject.transform.SetParent(GClass124.gameObject_8.transform, false);
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
				gameObject3.transform.SetParent(GClass124.gameObject_8.transform, false);
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
				GClass124.gameObject_8.SetActive(false);
			}
			return GClass124.gameObject_8;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x000313A4 File Offset: 0x0002F5A4
		internal static void smethod_20(string string_0)
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

		// Token: 0x060040CD RID: 16589 RVA: 0x000F5C00 File Offset: 0x000F3E00
		internal static GameObject smethod_21()
		{
			if (GClass124.gameObject_4 == null)
			{
				GClass124.gameObject_4 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions").gameObject);
				GClass124.gameObject_4.SetActive(false);
			}
			return GClass124.gameObject_4;
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x000F5C4C File Offset: 0x000F3E4C
		internal static VRCUiManager smethod_22()
		{
			if (GClass124.vrcuiManager_0 == null)
			{
				GClass124.vrcuiManager_0 = VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
			}
			return GClass124.vrcuiManager_0;
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x000F5C78 File Offset: 0x000F3E78
		internal static GameObject smethod_23()
		{
			if (GClass124.gameObject_2 == null)
			{
				GClass124.gameObject_2 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn").gameObject);
				GClass124.gameObject_2.SetActive(false);
			}
			return GClass124.gameObject_2;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x000F5CC4 File Offset: 0x000F3EC4
		internal static void smethod_24(string string_0)
		{
			GClass124.smethod_18(string_0);
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x000F5CD8 File Offset: 0x000F3ED8
		internal static string smethod_25(GClass99 gclass99_0, float float_0, float float_1)
		{
			return GClass124.smethod_2(gclass99_0, float_0, float_1);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00031754 File Offset: 0x0002F954
		internal static QuickMenu smethod_26()
		{
			return GClass84.smethod_728();
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x000F5CF0 File Offset: 0x000F3EF0
		internal static GameObject smethod_27()
		{
			if (GClass124.gameObject_12 == null)
			{
				GClass124.gameObject_12 = new GameObject();
				GClass124.gameObject_12.AddComponent<RectTransform>();
				GameObject gameObject = GClass84.smethod_1095();
				if (gameObject)
				{
					GClass124.gameObject_12.layer = gameObject.layer;
				}
				else
				{
					GClass124.gameObject_12.layer = 19;
				}
			}
			return GClass124.gameObject_12;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x000F5D54 File Offset: 0x000F3F54
		internal static string smethod_28(GClass99 gclass99_0, string string_0)
		{
			return "AbyssClient_" + gclass99_0.method_11() + "_" + string_0;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x000F5D7C File Offset: 0x000F3F7C
		internal static GameObject smethod_29()
		{
			if (GClass124.gameObject_10 == null)
			{
				GClass124.gameObject_10 = new GameObject("SingleButtonReference");
				GClass124.gameObject_10.AddComponent<CanvasRenderer>();
				RectTransform rectTransform = GClass124.gameObject_10.AddComponent<RectTransform>();
				GClass124.gameObject_10.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
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
				gameObject.transform.SetParent(GClass124.gameObject_10.transform, false);
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
				gameObject4.transform.SetParent(GClass124.gameObject_10.transform, false);
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
				GClass124.gameObject_10.SetActive(false);
			}
			return GClass124.gameObject_10;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x000F63E8 File Offset: 0x000F45E8
		internal static GameObject smethod_30()
		{
			if (GClass124.gameObject_3 == null)
			{
				GClass124.gameObject_3 = Object.Instantiate<GameObject>(GClass84.smethod_195().Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks").gameObject);
				List<Transform> list = GClass84.smethod_152(GClass124.gameObject_3);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					Object.DestroyImmediate(list[i].gameObject);
				}
				GClass124.gameObject_3.SetActive(false);
			}
			return GClass124.gameObject_3;
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x000F6468 File Offset: 0x000F4668
		internal static GameObject smethod_31()
		{
			if (GClass124.gameObject_1 == null)
			{
				GClass124.gameObject_1 = new GameObject("SingleButtonReference");
				GClass124.gameObject_1.AddComponent<CanvasRenderer>();
				RawImage rawImage = GClass124.gameObject_1.AddComponent<RawImage>();
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
				RectTransform component = GClass124.gameObject_1.GetComponent<RectTransform>();
				GClass124.gameObject_1.transform.SetParent(GClass84.smethod_195().Find("Menu_Dashboard"), false);
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
				GClass124.gameObject_1.AddComponent<Button>();
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
				gameObject.transform.SetParent(GClass124.gameObject_1.transform, false);
				component2.sizeDelta = new Vector2(0f, 0f);
				component2.localPosition = new Vector2(0f, 0f);
				component2.localRotation = new Quaternion(0f, 0f, 0f, 1f);
				GClass124.gameObject_1.SetActive(false);
			}
			return GClass124.gameObject_1;
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x000F66DC File Offset: 0x000F48DC
		internal static string smethod_32(GClass99 gclass99_0, float float_0, float float_1)
		{
			return string.Concat(new string[]
			{
				"AbyssClient_",
				gclass99_0.method_11(),
				"_",
				float_0.ToString(),
				"_",
				float_1.ToString()
			});
		}

		// Token: 0x04001921 RID: 6433
		private static BoxCollider boxCollider_0;

		// Token: 0x04001922 RID: 6434
		private static GameObject gameObject_0;

		// Token: 0x04001923 RID: 6435
		private static GameObject gameObject_1;

		// Token: 0x04001924 RID: 6436
		private static GameObject gameObject_2;

		// Token: 0x04001925 RID: 6437
		private static GameObject gameObject_3;

		// Token: 0x04001926 RID: 6438
		private static GameObject gameObject_4;

		// Token: 0x04001927 RID: 6439
		private static GameObject gameObject_5;

		// Token: 0x04001928 RID: 6440
		private static GameObject gameObject_6;

		// Token: 0x04001929 RID: 6441
		private static GameObject gameObject_7;

		// Token: 0x0400192A RID: 6442
		private static GameObject gameObject_8;

		// Token: 0x0400192B RID: 6443
		private static GameObject gameObject_9;

		// Token: 0x0400192C RID: 6444
		private static GameObject gameObject_10;

		// Token: 0x0400192D RID: 6445
		private static GameObject gameObject_11;

		// Token: 0x0400192E RID: 6446
		private static GameObject gameObject_12;

		// Token: 0x0400192F RID: 6447
		private static VRCUiManager vrcuiManager_0;
	}
}
