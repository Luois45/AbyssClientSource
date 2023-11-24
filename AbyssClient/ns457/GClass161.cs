using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ns185;
using ns241;
using ns375;
using ns425;
using ns429;
using ns443;
using ns449;
using ns459;
using ns461;
using ns465;
using ns474;
using ns479;
using ns480;
using ns60;
using TMPro;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Menus;

namespace ns457
{
	// Token: 0x020002CB RID: 715
	public class GClass161 : GClass130
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000A9588 File Offset: 0x000A7788
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x000A667C File Offset: 0x000A487C
		internal Color Color_9
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_11;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_9;
						}
					}
					result = this.color_11;
				}
				return result;
			}
			set
			{
				this.method_227(value);
			}
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000A6690 File Offset: 0x000A4890
		internal void method_2(float float_2)
		{
			this.method_224(float_2);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x000A66A4 File Offset: 0x000A48A4
		internal void method_3()
		{
			this.method_16();
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000A66B8 File Offset: 0x000A48B8
		internal void method_4(Color color_18)
		{
			this.method_116(color_18);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000A66CC File Offset: 0x000A48CC
		internal void method_5(string string_4)
		{
			this.string_2 = string_4;
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000A66E0 File Offset: 0x000A48E0
		internal void method_6(string string_4)
		{
			this.method_144(string_4);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000A66F4 File Offset: 0x000A48F4
		internal void method_7(float float_2)
		{
			this.method_107(float_2);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x000A6708 File Offset: 0x000A4908
		internal void method_8(Color color_18)
		{
			this.method_137(color_18);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x000A671C File Offset: 0x000A491C
		internal void method_9()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_13.Add(new Action(this.vmethod_12));
			GClass84.list_14.Add(new Action(this.vmethod_13));
			GClass84.list_32.Add(new Action<Object>(this.vmethod_21));
			this.bool_8 = GClass117.gclass117_0.bool_14;
			this.bool_9 = GClass117.gclass117_0.bool_15;
			this.bool_10 = GClass117.gclass117_0.bool_16;
			this.bool_11 = GClass117.gclass117_0.bool_17;
			this.bool_12 = GClass117.gclass117_0.bool_18;
			this.bool_13 = GClass117.gclass117_0.bool_19;
			this.bool_14 = GClass117.gclass117_0.bool_20;
			this.bool_15 = GClass117.gclass117_0.bool_21;
			this.bool_20 = GClass117.gclass117_0.bool_22;
			this.method_43(GClass117.gclass117_0.string_3, true);
			this.Color_0 = new Color(GClass117.gclass117_0.float_0, GClass117.gclass117_0.float_1, GClass117.gclass117_0.float_2, GClass117.gclass117_0.float_3);
			this.Boolean_0 = GClass117.gclass117_0.bool_23;
			this.Boolean_1 = GClass117.gclass117_0.bool_24;
			this.method_80(GClass117.gclass117_0.string_4, true);
			this.Color_1 = new Color(GClass117.gclass117_0.float_4, GClass117.gclass117_0.float_5, GClass117.gclass117_0.float_6, GClass117.gclass117_0.float_7);
			this.Color_2 = new Color(GClass117.gclass117_0.float_11, GClass117.gclass117_0.float_12, GClass117.gclass117_0.float_13);
			this.Color_3 = new Color(GClass117.gclass117_0.float_8, GClass117.gclass117_0.float_9, GClass117.gclass117_0.float_10);
			this.Color_4 = new Color(GClass117.gclass117_0.float_14, GClass117.gclass117_0.float_15, GClass117.gclass117_0.float_16);
			this.Color_5 = new Color(GClass117.gclass117_0.float_17, GClass117.gclass117_0.float_18, GClass117.gclass117_0.float_19);
			this.Color_7 = new Color(GClass117.gclass117_0.float_20, GClass117.gclass117_0.float_21, GClass117.gclass117_0.float_22);
			this.color_8 = new Color(GClass117.gclass117_0.float_23, GClass117.gclass117_0.float_24, GClass117.gclass117_0.float_25);
			this.color_9 = new Color(GClass117.gclass117_0.float_26, GClass117.gclass117_0.float_27, GClass117.gclass117_0.float_28);
			this.Color_6 = new Color(GClass117.gclass117_0.float_29, GClass117.gclass117_0.float_30, GClass117.gclass117_0.float_31);
			this.Color_8 = new Color(GClass117.gclass117_0.float_32, GClass117.gclass117_0.float_33, GClass117.gclass117_0.float_34);
			this.color_14 = new Color(GClass117.gclass117_0.float_35, GClass117.gclass117_0.float_36, GClass117.gclass117_0.float_37);
			this.color_15 = new Color(GClass117.gclass117_0.float_38, GClass117.gclass117_0.float_39, GClass117.gclass117_0.float_40);
			this.color_16 = new Color(GClass117.gclass117_0.float_41, GClass117.gclass117_0.float_42, GClass117.gclass117_0.float_43);
			this.color_17 = new Color(GClass117.gclass117_0.float_44, GClass117.gclass117_0.float_45, GClass117.gclass117_0.float_46);
			this.method_75();
			if (this.bool_1)
			{
				GClass84.gclass183_0 = new GClass183();
				this.vmethod_4(GClass84.gclass183_0);
			}
			if (this.bool_2)
			{
				GClass84.gclass147_0 = new GClass147();
				this.vmethod_4(GClass84.gclass147_0);
			}
			if (this.bool_3)
			{
				GClass84.gclass168_0 = new GClass168();
				this.vmethod_4(GClass84.gclass168_0);
			}
			if (this.bool_4)
			{
				GClass84.gclass177_0 = new GClass177();
				this.vmethod_4(GClass84.gclass177_0);
			}
			if (this.bool_5)
			{
				GClass84.gclass182_0 = new GClass182();
				this.vmethod_4(GClass84.gclass182_0);
			}
			if (this.bool_6)
			{
				GClass84.gclass165_0 = new GClass165();
				this.vmethod_4(GClass84.gclass165_0);
			}
			if (this.bool_16)
			{
				GClass84.gclass163_0 = new GClass163();
				this.vmethod_4(GClass84.gclass163_0);
			}
			if (this.bool_18)
			{
				GClass84.gclass133_0 = new GClass133();
				this.vmethod_4(GClass84.gclass133_0);
			}
			this.method_162(GClass117.gclass117_0.string_5, false, false, false);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000A6BDC File Offset: 0x000A4DDC
		internal void method_10(bool bool_23)
		{
			if (!bool_23)
			{
				if (this.gameObject_4)
				{
					this.gameObject_4.active = false;
				}
			}
			else
			{
				if (!this.gameObject_4)
				{
					GameObject gameObject = GameObject.Find("UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/InRoom");
					GameObject gameObject2 = GClass84.smethod_229();
					if (gameObject && gameObject2)
					{
						this.gameObject_4 = Object.Instantiate<GameObject>(gameObject, gameObject2.transform);
						RectTransform component = this.gameObject_4.GetComponent<RectTransform>();
						if (component)
						{
							component.anchoredPosition3D = new Vector3(999.2f, -699.75f, 0.0075f);
							component.localScale = new Vector3(0.0005f, 0.0005f, 0.0005f);
						}
						UiUserList component2 = this.gameObject_4.GetComponent<UiUserList>();
						if (component2)
						{
							component2.expandButton.image.enabled = false;
							component2.expandButton.GetComponentInChildren<Text>().GetComponent<RectTransform>().anchoredPosition = new Vector2(90f, -30f);
							component2.expandButton.interactable = false;
						}
						GridLayoutGroup componentInChildren = this.gameObject_4.GetComponentInChildren<GridLayoutGroup>(true);
						if (componentInChildren)
						{
							componentInChildren.constraint = 1;
							componentInChildren.constraintCount = 4;
							componentInChildren.startAxis = 1;
							componentInChildren.spacing = new Vector2(0f, 0f);
							componentInChildren.cellSize = new Vector2(248f, 138f);
						}
						Transform transform = this.gameObject_4.transform.Find("ViewPort");
						if (transform)
						{
							RectTransform component3 = transform.GetComponent<RectTransform>();
							if (component3)
							{
								component3.sizeDelta = new Vector2(1000f, 1000f);
								component3.anchoredPosition = new Vector2(510f, -60f);
							}
						}
					}
				}
				if (this.gameObject_4)
				{
					this.gameObject_4.active = true;
				}
			}
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000A6DD8 File Offset: 0x000A4FD8
		internal void method_11()
		{
			this.method_61();
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000A6DEC File Offset: 0x000A4FEC
		internal void method_12(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_34(string_4, list_8, text_0);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x000A89F8 File Offset: 0x000A6BF8
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x000A6E04 File Offset: 0x000A5004
		internal Color Color_3
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_3;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_2;
						}
					}
					result = this.color_3;
				}
				return result;
			}
			set
			{
				this.method_176(value);
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000A6E18 File Offset: 0x000A5018
		internal void method_13(bool bool_23)
		{
			this.bool_22 = bool_23;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000AB190 File Offset: 0x000A9390
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x000A6E2C File Offset: 0x000A502C
		internal Color Color_6
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_6;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_7;
						}
					}
					result = this.color_6;
				}
				return result;
			}
			set
			{
				this.method_18(value);
			}
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000A6E40 File Offset: 0x000A5040
		internal void method_14()
		{
			this.method_48();
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000A6E54 File Offset: 0x000A5054
		internal void method_15()
		{
			this.method_231();
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x000A6E68 File Offset: 0x000A5068
		internal void method_16()
		{
			try
			{
				this.method_237();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			try
			{
				this.method_167();
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
			this.method_204(false, true);
			if (this.bool_7)
			{
				this.method_41();
			}
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x000A6ED8 File Offset: 0x000A50D8
		internal void method_17()
		{
			this.method_229();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000A7460 File Offset: 0x000A5660
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x000A6EEC File Offset: 0x000A50EC
		internal string String_0
		{
			get
			{
				return this.method_109();
			}
			set
			{
				this.method_134(value);
			}
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x000A6F00 File Offset: 0x000A5100
		internal void method_18(Color color_18)
		{
			this.method_56(color_18);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000A6F14 File Offset: 0x000A5114
		internal void method_19(bool bool_23, Color? nullable_0)
		{
			if (this.bool_8)
			{
				if (nullable_0 == null)
				{
					nullable_0 = new Color?(this.Color_6);
				}
				Color value = nullable_0.Value;
				if (bool_23)
				{
					for (int i = 0; i < this.list_5.Count; i++)
					{
						if (this.list_5[i].gameObject_0.active)
						{
							for (int j = 0; j < this.list_5[i].list_0.Count; j++)
							{
								if (!this.list_5[i].list_0[j])
								{
									this.list_5[i].list_0.RemoveAt(j);
									j--;
								}
								else
								{
									this.list_5[i].list_0[j].color = value;
								}
							}
						}
					}
				}
				else
				{
					for (int k = 0; k < this.list_5.Count; k++)
					{
						for (int l = 0; l < this.list_5[k].list_0.Count; l++)
						{
							if (!this.list_5[k].list_0[l])
							{
								this.list_5[k].list_0.RemoveAt(l);
								l--;
							}
							else
							{
								this.list_5[k].list_0[l].color = value;
							}
						}
					}
				}
			}
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000A70D8 File Offset: 0x000A52D8
		private void method_20(ref GClass161.Struct30 struct30_0, Color? nullable_0)
		{
			this.method_218(ref struct30_0, nullable_0);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000A70F0 File Offset: 0x000A52F0
		internal void method_21(bool bool_23)
		{
			if (!bool_23 && this.gameObject_7)
			{
				this.gameObject_7.GetComponent<MeshRenderer>().material.SetTexture("_Tex", this.texture_4);
				this.gameObject_7.GetComponent<MeshRenderer>().material.SetColor("_Tint", Color.white);
			}
			this.bool_14 = bool_23;
			GClass117.gclass117_0.bool_20 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000A7168 File Offset: 0x000A5368
		internal void method_22(bool bool_23)
		{
			this.method_13(bool_23);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000A717C File Offset: 0x000A537C
		internal void method_23(string string_4)
		{
			this.method_5(string_4);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000A7584 File Offset: 0x000A5784
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x000A7190 File Offset: 0x000A5390
		internal bool Boolean_0
		{
			get
			{
				bool result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.bool_21;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].bool_1;
						}
					}
					result = this.bool_21;
				}
				return result;
			}
			set
			{
				this.method_30(value);
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000A71A4 File Offset: 0x000A53A4
		internal void method_24(Texture texture_5)
		{
			this.Texture_0 = texture_5;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000A71B8 File Offset: 0x000A53B8
		internal void method_25(Color color_18)
		{
			this.method_239(color_18);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000A71CC File Offset: 0x000A53CC
		internal void method_26(bool bool_23, Color? nullable_0)
		{
			if (this.bool_8)
			{
				if (nullable_0 == null)
				{
					nullable_0 = new Color?(this.Color_6);
				}
				this.method_93(bool_23, nullable_0);
				Color value = nullable_0.Value;
				if (bool_23)
				{
					for (int i = 0; i < this.list_3.Count; i++)
					{
						if (this.list_3[i].gameObject_0.active)
						{
							for (int j = 0; j < this.list_3[i].list_0.Count; j++)
							{
								if (!this.list_3[i].list_0[j])
								{
									this.list_3[i].list_0.RemoveAt(j);
									j--;
								}
								else
								{
									this.list_3[i].list_0[j].color = value;
								}
							}
						}
					}
				}
				else
				{
					for (int k = 0; k < this.list_3.Count; k++)
					{
						for (int l = 0; l < this.list_3[k].list_0.Count; l++)
						{
							if (!this.list_3[k].list_0[l])
							{
								this.list_3[k].list_0.RemoveAt(l);
								l--;
							}
							else
							{
								this.list_3[k].list_0[l].color = value;
							}
						}
					}
				}
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000A7398 File Offset: 0x000A5598
		internal void method_27(Color color_18)
		{
			this.color_10 = color_18;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000A73AC File Offset: 0x000A55AC
		internal void method_28()
		{
			this.method_163();
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000A73C0 File Offset: 0x000A55C0
		private void method_29()
		{
			this.method_146();
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000A73D4 File Offset: 0x000A55D4
		internal void method_30(bool bool_23)
		{
			this.method_84(bool_23);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000A73E8 File Offset: 0x000A55E8
		internal void method_31(float float_2)
		{
			Color color_ = this.Color_0;
			color_.r = float_2;
			this.method_96(color_);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000A740C File Offset: 0x000A560C
		internal void method_32()
		{
			this.method_70();
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000A7420 File Offset: 0x000A5620
		internal void method_33(Color color_18)
		{
			this.method_202(color_18);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000A7434 File Offset: 0x000A5634
		internal void method_34(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_172(string_4, list_8, text_0);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000A744C File Offset: 0x000A564C
		internal void method_35(bool bool_23)
		{
			this.method_205(bool_23);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x000A7474 File Offset: 0x000A5674
		internal void method_36(float float_2)
		{
			this.method_197(float_2);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000A7488 File Offset: 0x000A5688
		internal void method_37(bool bool_23)
		{
			this.method_195(bool_23);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000A749C File Offset: 0x000A569C
		internal void method_38()
		{
			GameObject gameObject = GClass84.smethod_1503();
			Image image = (gameObject != null) ? gameObject.GetComponent<Image>() : null;
			if (image)
			{
				Color color = image.color;
				color.r = 0.4f;
				color.g = 0f;
				color.b = 0f;
				image.color = color;
			}
			GameObject gameObject2 = GClass84.smethod_279();
			Image image2 = (gameObject2 != null) ? gameObject2.GetComponent<Image>() : null;
			if (image2)
			{
				Color color2 = image2.color;
				color2.r = 0.4f;
				color2.g = 0f;
				color2.b = 0f;
				image2.color = color2;
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000A7544 File Offset: 0x000A5744
		internal void method_39(Color color_18)
		{
			this.color_1 = color_18;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000A7558 File Offset: 0x000A5758
		internal void method_40(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_80(string_4, false);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000A7570 File Offset: 0x000A5770
		internal void method_41()
		{
			this.method_175();
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000A75FC File Offset: 0x000A57FC
		internal void method_42()
		{
			this.method_211();
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000A7610 File Offset: 0x000A5810
		internal void method_43(string string_4, bool bool_23 = false)
		{
			this.method_222(string_4, bool_23);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000A7628 File Offset: 0x000A5828
		internal void method_44(Color color_18)
		{
			this.method_101(color_18);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000A763C File Offset: 0x000A583C
		internal string method_45()
		{
			string result;
			if (string.IsNullOrEmpty(this.string_3))
			{
				result = this.string_1;
			}
			else
			{
				for (int i = 0; i < this.list_7.Count; i++)
				{
					if (this.list_7[i].string_0 == this.string_3)
					{
						return this.list_7[i].string_1;
					}
				}
				result = this.string_1;
			}
			return result;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000A76B4 File Offset: 0x000A58B4
		internal void method_46(bool bool_23)
		{
			this.bool_8 = bool_23;
			if (!bool_23)
			{
				this.method_81();
			}
			else
			{
				this.method_212(false, null);
			}
			GClass117.gclass117_0.bool_14 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000A76F8 File Offset: 0x000A58F8
		internal void method_47(bool bool_23)
		{
			this.method_169(bool_23);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000A770C File Offset: 0x000A590C
		internal void method_48()
		{
			this.method_149();
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000A7720 File Offset: 0x000A5920
		internal void method_49()
		{
			this.method_92();
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000A7734 File Offset: 0x000A5934
		internal void method_50(Color color_18)
		{
			this.method_148(color_18);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000A7748 File Offset: 0x000A5948
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x000AB5C8 File Offset: 0x000A97C8
		internal bool Boolean_1
		{
			get
			{
				bool result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.bool_22;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].bool_0;
						}
					}
					result = this.bool_22;
				}
				return result;
			}
			set
			{
				this.method_22(value);
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000A77C0 File Offset: 0x000A59C0
		internal GameObject method_51()
		{
			GameObject result;
			if (this.gameObject_0)
			{
				result = this.gameObject_0;
			}
			else
			{
				this.gameObject_0 = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
				if (this.gameObject_0)
				{
					Image component = this.gameObject_0.GetComponent<Image>();
					if (component)
					{
						Object.DestroyImmediate(component);
						this.texture_1 = GClass153.GClass87.texture2D_0;
						this.rawImage_0 = this.gameObject_0.AddComponent<RawImage>();
						this.rawImage_0.texture = this.texture_1;
						this.rawImage_0.color = new Color(0f, 0.5f, 0.75f, 0.33f);
					}
				}
				result = this.gameObject_0;
			}
			return result;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000A7878 File Offset: 0x000A5A78
		private void method_52(ref GClass161.Struct29 struct29_0, Color? nullable_0 = null)
		{
			this.method_189(ref struct29_0, nullable_0);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000A7890 File Offset: 0x000A5A90
		internal void method_53()
		{
			this.method_9();
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000A78A4 File Offset: 0x000A5AA4
		internal void method_54(bool bool_23)
		{
			this.bool_12 = bool_23;
			GClass117.gclass117_0.bool_18 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000A78C8 File Offset: 0x000A5AC8
		internal void method_55(bool bool_23)
		{
			this.method_10(bool_23);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000A78DC File Offset: 0x000A5ADC
		internal void method_56(Color color_18)
		{
			this.color_6 = color_18;
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000A78F0 File Offset: 0x000A5AF0
		private void method_57(ref GClass161.Struct28 struct28_0)
		{
			for (int i = 0; i < struct28_0.list_0.Count; i++)
			{
				if (!struct28_0.list_0[i])
				{
					struct28_0.list_0.RemoveAt(i);
				}
				else
				{
					struct28_0.list_0[i].colors = this.colorBlock_0;
				}
			}
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000A7950 File Offset: 0x000A5B50
		private void method_58()
		{
			this.method_69();
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000A7964 File Offset: 0x000A5B64
		internal void method_59()
		{
			this.method_191();
			for (int i = this.list_1.Count - 1; i >= 0; i--)
			{
				this.list_1[i].selectable_0.colors = this.list_1[i].colorBlock_0;
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000A79BC File Offset: 0x000A5BBC
		internal void method_60()
		{
			GameObject gameObject = GClass84.smethod_1272();
			if (gameObject)
			{
				Image[] array = gameObject.GetComponentsInChildren<Image>(true);
				for (int i = 0; i < array.Length; i++)
				{
					Selectable[] array2 = array[i].GetComponents<Selectable>();
					int num = 0;
					while (num < array2.Length && !(array2[num].targetGraphic == array[i]))
					{
						num++;
					}
					if (num >= array2.Length && !(array[i].name == "Bindings Image") && !(array[i].name == "Darkness"))
					{
						if (array[i].name == "Rectangle")
						{
							Color color = this.Color_9;
							color.a = array[i].color.a;
							array[i].color = color;
						}
						else if (array[i].name == "Panel")
						{
							Color color2 = this.Color_10;
							color2.a = array[i].color.a;
							array[i].color = color2;
						}
						else
						{
							Color color3 = this.Color_11;
							color3.a = array[i].color.a;
							array[i].color = color3;
						}
					}
				}
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000A7B10 File Offset: 0x000A5D10
		internal void method_61()
		{
			this.method_170();
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000ABBB4 File Offset: 0x000A9DB4
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x000A7B24 File Offset: 0x000A5D24
		internal Color Color_5
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_5;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_5;
						}
					}
					result = this.color_5;
				}
				return result;
			}
			set
			{
				this.method_44(value);
			}
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000A7B38 File Offset: 0x000A5D38
		internal void method_62()
		{
			this.method_139(false);
			this.method_212(false, null);
			this.method_178();
			this.method_194();
			this.method_14();
			this.method_17();
			this.method_125();
			this.method_11();
			this.method_210();
			this.method_42();
			this.method_236();
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000A7B94 File Offset: 0x000A5D94
		internal void method_63(float float_2)
		{
			Color color_ = this.Color_0;
			color_.g = float_2;
			this.method_96(color_);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000A7BB8 File Offset: 0x000A5DB8
		internal void method_64(bool bool_23)
		{
			this.method_168(bool_23);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000A7BCC File Offset: 0x000A5DCC
		internal void method_65()
		{
			this.method_171();
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000A7BE0 File Offset: 0x000A5DE0
		internal void method_66(bool bool_23)
		{
			this.method_200(bool_23);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000A7BF4 File Offset: 0x000A5DF4
		internal void method_67()
		{
			GameObject gameObject = GClass84.smethod_1095();
			if (gameObject)
			{
				GameObject[] array = GClass84.smethod_1034(gameObject);
				for (int i = 0; i < array.Length; i++)
				{
					GameObject[] array2 = GClass84.smethod_1034(array[i]);
					if (array2.Length >= 1)
					{
						for (int j = 0; j < array2.Length; j++)
						{
							if (array2[j].name == "QuickModeMenus")
							{
								GameObject[] array3 = GClass84.smethod_1034(array2[j]);
								for (int k = 0; k < array3.Length; k++)
								{
									List<TextMeshProUGUI> list = new List<TextMeshProUGUI>();
									Il2CppArrayBase<TextMeshProUGUI> componentsInChildren = array3[k].GetComponentsInChildren<TextMeshProUGUI>(true);
									for (int l = 0; l < componentsInChildren.Length; l++)
									{
										this.list_6.Add(new GClass161.Struct27(componentsInChildren[l], componentsInChildren[l].color));
										list.Add(componentsInChildren[l]);
									}
									if (list.Count > 0)
									{
										this.list_5.Add(new GClass161.Struct30(array3[k], list));
									}
								}
							}
							else
							{
								List<TextMeshProUGUI> list2 = new List<TextMeshProUGUI>();
								Il2CppArrayBase<TextMeshProUGUI> componentsInChildren2 = array2[j].GetComponentsInChildren<TextMeshProUGUI>(true);
								for (int m = 0; m < componentsInChildren2.Length; m++)
								{
									this.list_6.Add(new GClass161.Struct27(componentsInChildren2[m], componentsInChildren2[m].color));
									list2.Add(componentsInChildren2[m]);
								}
								if (list2.Count > 0)
								{
									this.list_5.Add(new GClass161.Struct30(array2[j], list2));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000A7DB4 File Offset: 0x000A5FB4
		internal void method_68(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_140(string_4, list_8, text_0);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000A7DCC File Offset: 0x000A5FCC
		private void method_69()
		{
			this.method_199();
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		internal void method_70()
		{
			GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Modal_QM_MoreActions");
			NotificationMoreActionsModal notificationMoreActionsModal = (gameObject != null) ? gameObject.GetComponent<NotificationMoreActionsModal>() : null;
			if (notificationMoreActionsModal)
			{
				NotificationElement field_Private_NotificationElement_ = notificationMoreActionsModal.field_Private_NotificationElement_0;
				if (!field_Private_NotificationElement_)
				{
				}
			}
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		internal void method_71()
		{
			GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Modal_QM_MoreActions");
			NotificationMoreActionsModal notificationMoreActionsModal = (gameObject != null) ? gameObject.GetComponent<NotificationMoreActionsModal>() : null;
			if (notificationMoreActionsModal)
			{
				NotificationElement field_Private_NotificationElement_ = notificationMoreActionsModal.field_Private_NotificationElement_0;
				if (!field_Private_NotificationElement_)
				{
				}
			}
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000A7E1C File Offset: 0x000A601C
		internal void method_72(bool bool_23)
		{
			this.bool_20 = bool_23;
			GClass117.gclass117_0.bool_22 = bool_23;
			GClass117.smethod_3();
			this.method_125();
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000A7E48 File Offset: 0x000A6048
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x000AAE18 File Offset: 0x000A9018
		internal Texture Texture_0
		{
			get
			{
				if (!string.IsNullOrEmpty(this.string_3))
				{
					int i = 0;
					while (i < this.list_7.Count)
					{
						if (!(this.list_7[i].string_0 == this.string_3))
						{
							i++;
						}
						else
						{
							if (this.list_7[i].texture_0)
							{
								return this.list_7[i].texture_0;
							}
							IL_7A:
							return this.texture_2;
						}
					}
					goto IL_7A;
				}
				return this.texture_2;
			}
			set
			{
				this.method_159(value);
			}
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		internal void method_73(float float_2)
		{
			this.method_31(float_2);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x000A92EC File Offset: 0x000A74EC
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x000A7EEC File Offset: 0x000A60EC
		internal Color Color_7
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_7;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_6;
						}
					}
					result = this.color_7;
				}
				return result;
			}
			set
			{
				this.method_33(value);
			}
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000A7F00 File Offset: 0x000A6100
		internal void method_74(bool bool_23)
		{
			this.method_54(bool_23);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000A7F14 File Offset: 0x000A6114
		internal void method_75()
		{
			this.method_173();
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000A7F28 File Offset: 0x000A6128
		internal void method_76(bool bool_23)
		{
			this.method_220(bool_23);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000A8C90 File Offset: 0x000A6E90
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x000A7F3C File Offset: 0x000A613C
		internal string String_1
		{
			get
			{
				return this.method_110();
			}
			set
			{
				this.method_23(value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x000A7F50 File Offset: 0x000A6150
		internal Color Color_0
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_0;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_0;
						}
					}
					result = this.color_0;
				}
				return result;
			}
			set
			{
				this.method_25(value);
			}
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000A7F64 File Offset: 0x000A6164
		internal void method_77(string string_4, bool bool_23)
		{
			this.method_135(null);
			this.String_0 = string_4;
			if (!bool_23)
			{
				GClass117.gclass117_0.string_3 = string_4;
				GClass117.smethod_3();
			}
			if (!(string_4 == string.Empty))
			{
				try
				{
					if (GClass84.smethod_1428(string_4, GClass84.smethod_593("http://")) == "http://" || GClass84.smethod_1428(string_4, GClass84.smethod_593("https://")) == "https://")
					{
						this.method_135(GClass84.smethod_1436(string_4));
					}
					else
					{
						this.method_135(GClass84.smethod_268(string_4));
					}
					this.method_125();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.Message, GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000A8020 File Offset: 0x000A6220
		internal void method_78(string string_4, bool bool_23)
		{
			this.method_233(null);
			this.String_1 = string_4;
			if (!bool_23)
			{
				GClass117.gclass117_0.string_4 = string_4;
				GClass117.smethod_3();
			}
			if (!(string_4 == string.Empty))
			{
				try
				{
					if (GClass84.smethod_1428(string_4, GClass84.smethod_593("http://")) == "http://" || GClass84.smethod_1428(string_4, GClass84.smethod_593("https://")) == "https://")
					{
						this.method_233(GClass84.smethod_1436(string_4));
					}
					else
					{
						this.method_233(GClass84.smethod_268(string_4));
					}
					this.method_11();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.Message, GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000A80DC File Offset: 0x000A62DC
		internal void method_79()
		{
			this.method_104();
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000A80F0 File Offset: 0x000A62F0
		internal void method_80(string string_4, bool bool_23 = false)
		{
			this.method_105(string_4, bool_23);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000A8108 File Offset: 0x000A6308
		internal void method_81()
		{
			this.method_188();
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000A811C File Offset: 0x000A631C
		internal void method_82(Texture texture_5)
		{
			this.texture_2 = texture_5;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000A8130 File Offset: 0x000A6330
		internal void method_83(bool bool_23)
		{
			this.bool_0 = bool_23;
			this.method_192(this.bool_0);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A8150 File Offset: 0x000A6350
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x000ABB8C File Offset: 0x000A9D8C
		internal Color Color_10
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_12;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_10;
						}
					}
					result = this.color_12;
				}
				return result;
			}
			set
			{
				this.method_186(value);
			}
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000A81C8 File Offset: 0x000A63C8
		internal void method_84(bool bool_23)
		{
			this.bool_21 = bool_23;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000A81DC File Offset: 0x000A63DC
		internal void method_85(Object object_0)
		{
			this.method_209(object_0);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000A81F0 File Offset: 0x000A63F0
		internal void method_86(string string_4)
		{
			this.method_6(string_4);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000A8204 File Offset: 0x000A6404
		internal void method_87(string string_4, bool bool_23, bool bool_24, bool bool_25)
		{
			this.string_3 = string_4;
			if (bool_23)
			{
				GClass117.gclass117_0.string_5 = this.string_3;
				GClass117.smethod_3();
			}
			this.method_204(bool_24, bool_25);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000A823C File Offset: 0x000A643C
		internal void method_88()
		{
			GameObject gameObject = GameObject.Find("/UserInterface/MenuContent/Popups/InputPopup");
			if (gameObject)
			{
				Transform transform = gameObject.transform.Find("Keyboard");
				if (transform)
				{
					Transform transform2 = transform.Find("Keys");
					if (transform2 && transform2.childCount > 0)
					{
						Transform child = transform2.GetChild(0);
						if (child && child.childCount > 0)
						{
							Transform child2 = child.GetChild(0);
							if (child2)
							{
								GameObject gameObject2 = Object.Instantiate<GameObject>(child2.gameObject);
								if (gameObject2)
								{
									gameObject2.name = "PasteButton";
									gameObject2.transform.SetParent(gameObject.transform);
									gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
									gameObject2.transform.rotation = default(Quaternion);
									RectTransform component = gameObject2.GetComponent<RectTransform>();
									if (component)
									{
										component.anchoredPosition3D = new Vector3(33.825f, -25.01f, 0f);
										component.sizeDelta = new Vector2(150f, 75f);
									}
									gameObject2.transform.localPosition = new Vector3(420f, 160f, 0f);
									Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
									if (componentInChildren)
									{
										componentInChildren.text = "Paste";
									}
									Button component2 = gameObject2.GetComponent<Button>();
									if (component2)
									{
										component2.onClick = new Button.ButtonClickedEvent();
										Transform transform3 = gameObject.transform.Find("InputField");
										if (transform3)
										{
											GClass161.Class176 @class = new GClass161.Class176();
											@class.inputField_0 = transform3.GetComponent<InputField>();
											if (@class.inputField_0)
											{
												Transform transform4 = transform3.Find("Placeholder");
												Transform transform5 = transform3.Find("Text");
												if (transform4 && transform5)
												{
													Text component3 = transform4.GetComponent<Text>();
													Text component4 = transform5.GetComponent<Text>();
													if (component3 && component4)
													{
														GClass84.smethod_243(component2, new Action(@class.method_0));
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000A84A0 File Offset: 0x000A66A0
		internal void method_89(Texture texture_5)
		{
			this.method_24(texture_5);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000A84B4 File Offset: 0x000A66B4
		internal void method_90(Texture texture_5)
		{
			this.method_160(texture_5);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000A84C8 File Offset: 0x000A66C8
		internal void method_91()
		{
			this.method_234();
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000A84DC File Offset: 0x000A66DC
		internal void method_92()
		{
			GameObject gameObject = GClass84.smethod_1095();
			if (gameObject)
			{
				GameObject[] array = GClass84.smethod_1034(gameObject);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					GameObject[] array2 = GClass84.smethod_1034(array[i]);
					if (array2.Length >= 1)
					{
						for (int j = array2.Length - 1; j >= 0; j--)
						{
							if (array2[j].name == "QuickModeMenus")
							{
								GameObject[] array3 = GClass84.smethod_1034(array2[j]);
								for (int k = array3.Length - 1; k >= 0; k--)
								{
									List<Selectable> list = new List<Selectable>();
									Il2CppArrayBase<Selectable> componentsInChildren = array3[k].GetComponentsInChildren<Selectable>(true);
									for (int l = componentsInChildren.Length - 1; l >= 0; l--)
									{
										this.list_1.Add(new GClass161.Struct24(componentsInChildren[l], componentsInChildren[l].colors));
										list.Add(componentsInChildren[l]);
									}
									if (list.Count > 0)
									{
										this.list_0.Add(new GClass161.Struct28(array3[k], list));
									}
								}
							}
							else
							{
								List<Selectable> list2 = new List<Selectable>();
								Il2CppArrayBase<Selectable> componentsInChildren2 = array2[j].GetComponentsInChildren<Selectable>(true);
								for (int m = componentsInChildren2.Length - 1; m >= 0; m--)
								{
									this.list_1.Add(new GClass161.Struct24(componentsInChildren2[m], componentsInChildren2[m].colors));
									list2.Add(componentsInChildren2[m]);
								}
								if (list2.Count > 0)
								{
									this.list_0.Add(new GClass161.Struct28(array2[j], list2));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000A86B4 File Offset: 0x000A68B4
		internal void method_93(bool bool_23 = false, Color? nullable_0 = null)
		{
			this.method_198(bool_23, nullable_0);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000A86CC File Offset: 0x000A68CC
		public override void vmethod_13()
		{
			this.method_3();
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000A86E0 File Offset: 0x000A68E0
		internal void method_94()
		{
			this.method_65();
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000A86F4 File Offset: 0x000A68F4
		internal void method_95(bool bool_23)
		{
			this.Boolean_0 = bool_23;
			GClass117.gclass117_0.bool_23 = bool_23;
			GClass117.smethod_3();
			this.method_11();
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000A8720 File Offset: 0x000A6920
		internal void method_96(Color color_18)
		{
			this.method_8(color_18);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000A8734 File Offset: 0x000A6934
		internal void method_97(float float_2)
		{
			this.method_147(float_2);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000A8748 File Offset: 0x000A6948
		private void method_98()
		{
			this.method_119();
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000A875C File Offset: 0x000A695C
		internal void method_99()
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				this.list_2[i].image_0.color = this.list_2[i].color_0;
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000A87A8 File Offset: 0x000A69A8
		private void method_100()
		{
			this.method_98();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000A87BC File Offset: 0x000A69BC
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x000ABDF4 File Offset: 0x000A9FF4
		internal Color Color_11
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_13;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_11;
						}
					}
					result = this.color_13;
				}
				return result;
			}
			set
			{
				this.method_4(value);
			}
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000A8834 File Offset: 0x000A6A34
		internal void method_101(Color color_18)
		{
			this.color_5 = color_18;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000A8848 File Offset: 0x000A6A48
		private void method_102(ref GClass161.Struct28 struct28_0)
		{
			this.method_57(ref struct28_0);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000A885C File Offset: 0x000A6A5C
		internal void method_103()
		{
			this.method_166();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x000AB244 File Offset: 0x000A9444
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x000A8870 File Offset: 0x000A6A70
		internal Color Color_2
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_2;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_3;
						}
					}
					result = this.color_2;
				}
				return result;
			}
			set
			{
				this.method_50(value);
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000A8884 File Offset: 0x000A6A84
		internal void method_104()
		{
			GameObject gameObject = this.method_51();
			if (gameObject)
			{
				if (gameObject.activeSelf == this.bool_20)
				{
					gameObject.SetActive(!this.bool_20);
				}
				if (this.bool_19 && !this.bool_20 && this.rawImage_0)
				{
					if (this.rawImage_0.color != this.Color_0)
					{
						this.rawImage_0.color = this.Color_0;
					}
					if (this.texture_0)
					{
						if (this.rawImage_0.texture != this.texture_0)
						{
							this.rawImage_0.texture = this.texture_0;
						}
					}
					else if (this.rawImage_0.texture != this.texture_1)
					{
						this.rawImage_0.texture = this.texture_1;
					}
				}
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000A897C File Offset: 0x000A6B7C
		internal void method_105(string string_4, bool bool_23)
		{
			this.method_78(string_4, bool_23);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000A8994 File Offset: 0x000A6B94
		private void method_106(ref GClass161.Struct29 struct29_0, Color? nullable_0)
		{
			if (this.bool_8)
			{
				if (nullable_0 == null)
				{
					nullable_0 = new Color?(this.Color_6);
				}
				Color value = nullable_0.Value;
				for (int i = 0; i < struct29_0.list_0.Count; i++)
				{
					struct29_0.list_0[i].color = value;
				}
			}
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000A8A70 File Offset: 0x000A6C70
		internal void method_107(float float_2)
		{
			this.float_0 = (this.float_0 + float_2 * 60f) % 360f;
			Color normalColor;
			normalColor..ctor(0f, 0f, 0f, 1f);
			if (this.float_0 < 60f)
			{
				normalColor.r = 1f;
				normalColor.g = this.float_0 / 60f;
				normalColor.b = 0f;
			}
			else if (this.float_0 < 120f)
			{
				normalColor.r = 1f - (this.float_0 - 60f) / 60f;
				normalColor.g = 1f;
				normalColor.b = 0f;
			}
			else if (this.float_0 < 180f)
			{
				normalColor.r = 0f;
				normalColor.g = 1f;
				normalColor.b = (this.float_0 - 120f) / 60f;
			}
			else if (this.float_0 < 240f)
			{
				normalColor.r = 0f;
				normalColor.g = 1f - (this.float_0 - 180f) / 60f;
				normalColor.b = 1f;
			}
			else if (this.float_0 < 300f)
			{
				normalColor.r = (this.float_0 - 240f) / 60f;
				normalColor.g = 0f;
				normalColor.b = 1f;
			}
			else if (this.float_0 < 360f)
			{
				normalColor.r = 1f;
				normalColor.g = 0f;
				normalColor.b = 1f - (this.float_0 - 300f) / 60f;
			}
			this.colorBlock_0.normalColor = normalColor;
			this.method_139(true);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000A8C68 File Offset: 0x000A6E68
		internal void method_108()
		{
			this.method_67();
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000A8C7C File Offset: 0x000A6E7C
		internal string method_109()
		{
			return this.method_45();
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x000A8CA4 File Offset: 0x000A6EA4
		internal string method_110()
		{
			return this.method_184();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000A9458 File Offset: 0x000A7658
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x000A8CB8 File Offset: 0x000A6EB8
		internal Color Color_8
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_10;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_8;
						}
					}
					result = this.color_10;
				}
				return result;
			}
			set
			{
				this.method_174(value);
			}
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000A8CCC File Offset: 0x000A6ECC
		internal void method_111()
		{
			for (int i = 0; i < this.list_6.Count; i++)
			{
				this.list_6[i].textMeshProUGUI_0.color = this.list_6[i].color_0;
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000A8D18 File Offset: 0x000A6F18
		internal void method_112(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_40(string_4, list_8, text_0);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000A8D30 File Offset: 0x000A6F30
		internal void method_113(bool bool_23)
		{
			this.method_37(bool_23);
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000A8D44 File Offset: 0x000A6F44
		internal void method_114()
		{
			this.method_161();
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000A8D58 File Offset: 0x000A6F58
		[CompilerGenerated]
		private void method_115()
		{
			this.method_100();
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000A8D6C File Offset: 0x000A6F6C
		internal void method_116(Color color_18)
		{
			this.color_13 = color_18;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x000A8D80 File Offset: 0x000A6F80
		internal void method_117(Color color_18)
		{
			this.color_12 = color_18;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000A8D94 File Offset: 0x000A6F94
		internal GameObject method_118()
		{
			GameObject result;
			if (this.gameObject_1)
			{
				result = this.gameObject_1;
			}
			else
			{
				if (!this.gameObject_2)
				{
					Transform transform = GClass84.smethod_195();
					GameObject gameObject;
					if (transform == null)
					{
						gameObject = null;
					}
					else
					{
						Transform transform2 = transform.Find("BackgroundLayer01");
						gameObject = ((transform2 != null) ? transform2.gameObject : null);
					}
					this.gameObject_2 = gameObject;
				}
				if (!this.gameObject_3)
				{
					Transform transform3 = GClass84.smethod_195();
					GameObject gameObject2;
					if (transform3 == null)
					{
						gameObject2 = null;
					}
					else
					{
						Transform transform4 = transform3.Find("BackgroundLayer02");
						gameObject2 = ((transform4 != null) ? transform4.gameObject : null);
					}
					this.gameObject_3 = gameObject2;
				}
				if (this.gameObject_2)
				{
					this.gameObject_1 = Object.Instantiate<GameObject>(this.gameObject_2, this.gameObject_2.transform.parent);
					if (this.gameObject_1)
					{
						this.gameObject_1.transform.SetSiblingIndex(this.gameObject_2.transform.GetSiblingIndex() + 1);
						Image component = this.gameObject_1.GetComponent<Image>();
						if (component)
						{
							Object.DestroyImmediate(component);
							this.texture_3 = GClass153.GClass87.texture2D_0;
							this.rawImage_1 = this.gameObject_1.AddComponent<RawImage>();
							this.rawImage_1.texture = this.texture_3;
							this.rawImage_1.color = this.Color_1;
							this.rawImage_1.enabled = false;
						}
					}
				}
				result = this.gameObject_1;
			}
			return result;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000A8EFC File Offset: 0x000A70FC
		internal void method_119()
		{
			this.method_190();
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x000A8F10 File Offset: 0x000A7110
		internal void method_120(Color color_18)
		{
			this.method_39(color_18);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000A8F24 File Offset: 0x000A7124
		internal void method_121(Color color_18)
		{
			this.method_180(color_18);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000A8F38 File Offset: 0x000A7138
		public override void vmethod_12()
		{
			this.method_114();
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000A8F4C File Offset: 0x000A714C
		internal void method_122()
		{
			this.method_99();
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000A8F60 File Offset: 0x000A7160
		internal void method_123(string string_4)
		{
			this.string_1 = string_4;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000A8F74 File Offset: 0x000A7174
		private void method_124()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				for (int j = this.list_0[i].list_0.Count - 1; j >= 0; j--)
				{
					if (!this.list_0[i].list_0[j])
					{
						return;
					}
					GameObject gameObject = this.list_0[i].list_0[j].gameObject;
					if (!gameObject)
					{
						return;
					}
					Image component = gameObject.GetComponent<Image>();
					if (component)
					{
						Sprite activeSprite = component.activeSprite;
						if (activeSprite && activeSprite.name == "GUI_Button_double_White")
						{
							Transform parent = gameObject.transform.parent;
							if (parent != null && parent.name == "ViewAvatarThreeToggle")
							{
								return;
							}
							GClass84.smethod_761(component);
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
						}
					}
				}
			}
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000A9128 File Offset: 0x000A7328
		internal void method_125()
		{
			this.method_79();
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000A913C File Offset: 0x000A733C
		internal void method_126()
		{
			this.colorBlock_0.colorMultiplier = 1f;
			this.colorBlock_0.disabledColor = this.Color_4;
			this.colorBlock_0.fadeDuration = 0f;
			this.colorBlock_0.highlightedColor = this.Color_5;
			this.colorBlock_0.normalColor = this.Color_2;
			this.colorBlock_0.pressedColor = this.Color_3;
			this.colorBlock_0.selectedColor = this.Color_2;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000A91C0 File Offset: 0x000A73C0
		internal void method_127(bool bool_23)
		{
			this.method_83(bool_23);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000A91D4 File Offset: 0x000A73D4
		internal GameObject method_128()
		{
			GameObject result;
			if (this.gameObject_7)
			{
				result = this.gameObject_7;
			}
			else
			{
				this.gameObject_7 = GClass84.smethod_1086();
				if (this.gameObject_7)
				{
					this.texture_4 = this.gameObject_7.GetComponent<MeshRenderer>().material.GetTexture("_Tex");
				}
				result = this.gameObject_7;
			}
			return result;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000A9238 File Offset: 0x000A7438
		internal void method_129(bool bool_23)
		{
			this.method_47(bool_23);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000A924C File Offset: 0x000A744C
		internal void method_130(Color color_18)
		{
			this.color_4 = color_18;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000A9260 File Offset: 0x000A7460
		internal void method_131(bool bool_23, bool bool_24)
		{
			this.method_150(bool_23, bool_24);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000A9278 File Offset: 0x000A7478
		internal void method_132(float float_2)
		{
			this.method_36(float_2);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000A928C File Offset: 0x000A748C
		internal void method_133(Color color_18)
		{
			this.color_3 = color_18;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000A92A0 File Offset: 0x000A74A0
		internal void method_134(string string_4)
		{
			this.method_123(string_4);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000A92B4 File Offset: 0x000A74B4
		internal void method_135(Texture texture_5)
		{
			this.method_90(texture_5);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000A92C8 File Offset: 0x000A74C8
		internal void method_136(float float_2)
		{
			Color color_ = this.Color_0;
			color_.a = float_2;
			this.method_96(color_);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000A9364 File Offset: 0x000A7564
		internal void method_137(Color color_18)
		{
			this.Color_0 = GClass84.smethod_1042(color_18, 0f, 1f);
			this.gclass31_0.method_22(this.Color_0.r, false);
			this.gclass31_1.method_22(this.Color_0.g, false);
			this.gclass31_2.method_22(this.Color_0.b, false);
			this.gclass31_3.method_22(this.Color_0.a, false);
			GClass117.gclass117_0.float_0 = this.Color_0.r;
			GClass117.gclass117_0.float_1 = this.Color_0.g;
			GClass117.gclass117_0.float_2 = this.Color_0.b;
			GClass117.gclass117_0.float_3 = this.Color_0.a;
			GClass117.smethod_3();
			this.method_125();
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000A9444 File Offset: 0x000A7644
		internal void method_138()
		{
			this.method_152();
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000A94D0 File Offset: 0x000A76D0
		internal void method_139(bool bool_23 = false)
		{
			this.method_193(bool_23);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000A94E4 File Offset: 0x000A76E4
		internal void method_140(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_43(string_4, false);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000A94FC File Offset: 0x000A76FC
		public override void vmethod_23()
		{
			this.method_53();
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000A9510 File Offset: 0x000A7710
		internal void method_141(float float_2)
		{
			this.method_7(float_2);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000A9524 File Offset: 0x000A7724
		internal void method_142(float float_2)
		{
			this.method_185(float_2);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000A9538 File Offset: 0x000A7738
		internal void method_143(bool bool_23)
		{
			this.method_95(bool_23);
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x000A954C File Offset: 0x000A774C
		internal void method_144(string string_4)
		{
			Transform transform = GClass84.smethod_496();
			Transform transform2 = (transform != null) ? transform.Find("MenuSettingsPopup/Popup/Background") : null;
			if (transform2)
			{
				transform2.GetComponentInChildren<Text>().text = string_4;
			}
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x000A9600 File Offset: 0x000A7800
		internal void method_145()
		{
			this.method_38();
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000A9614 File Offset: 0x000A7814
		private void method_146()
		{
			this.method_124();
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000A9628 File Offset: 0x000A7828
		internal void method_147(float float_2)
		{
			Color color_ = this.Color_0;
			color_.b = float_2;
			this.method_96(color_);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x000A9AE8 File Offset: 0x000A7CE8
		internal void method_148(Color color_18)
		{
			this.color_2 = color_18;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x000A9AFC File Offset: 0x000A7CFC
		internal void method_149()
		{
			if (this.bool_14)
			{
				GameObject gameObject = this.method_128();
				if (gameObject)
				{
					MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
					if (component)
					{
						component.material.SetTexture("_Tex", GClass153.GClass87.texture2D_0);
						component.material.SetColor("_Tint", this.color_14);
					}
				}
			}
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000A9B60 File Offset: 0x000A7D60
		internal void method_150(bool bool_23, bool bool_24)
		{
			this.method_75();
			if (bool_23 && this.bool_7)
			{
				this.method_41();
			}
			if (bool_24)
			{
				this.gameObject_8.SetActive(string.IsNullOrEmpty(this.string_3));
				GClass84.gclass163_0.method_2866(string.IsNullOrEmpty(this.string_3));
			}
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		[CompilerGenerated]
		private void method_151()
		{
			this.method_58();
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x000A9BCC File Offset: 0x000A7DCC
		internal void method_152()
		{
			this.method_59();
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x000A9BE0 File Offset: 0x000A7DE0
		internal void method_153(bool bool_23)
		{
			this.method_21(bool_23);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000A9BF4 File Offset: 0x000A7DF4
		internal void method_154(Color color_18)
		{
			this.method_130(color_18);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000A9C08 File Offset: 0x000A7E08
		internal void method_155()
		{
			if (this.bool_12)
			{
				VRCUiCursorManager vrcuiCursorManager = GClass84.smethod_615();
				if (vrcuiCursorManager)
				{
					VRCUiCursor field_Public_VRCUiCursor_ = vrcuiCursorManager.field_Public_VRCUiCursor_0;
					VRCUiCursor field_Public_VRCUiCursor_2 = vrcuiCursorManager.field_Public_VRCUiCursor_1;
					VRCUiCursor field_Public_VRCUiCursor_3 = vrcuiCursorManager.field_Public_VRCUiCursor_2;
					VRCUiCursor field_Public_VRCUiCursor_4 = vrcuiCursorManager.field_Public_VRCUiCursor_3;
					VRCUiCursor field_Public_VRCUiCursor_5 = vrcuiCursorManager.field_Public_VRCUiCursor_4;
					if (field_Public_VRCUiCursor_)
					{
						field_Public_VRCUiCursor_.field_Public_Color_2 = this.Color_7;
						field_Public_VRCUiCursor_.field_Public_Color_1 = this.color_8;
						field_Public_VRCUiCursor_.field_Public_Color_0 = this.color_9;
					}
					if (field_Public_VRCUiCursor_2)
					{
						field_Public_VRCUiCursor_2.field_Public_Color_2 = this.Color_7;
						field_Public_VRCUiCursor_2.field_Public_Color_1 = this.color_8;
						field_Public_VRCUiCursor_2.field_Public_Color_0 = this.color_9;
					}
					if (field_Public_VRCUiCursor_3)
					{
						field_Public_VRCUiCursor_3.field_Public_Color_2 = this.Color_7;
						field_Public_VRCUiCursor_3.field_Public_Color_1 = this.color_8;
						field_Public_VRCUiCursor_3.field_Public_Color_0 = this.color_9;
					}
					if (field_Public_VRCUiCursor_4)
					{
						field_Public_VRCUiCursor_4.field_Public_Color_2 = this.Color_7;
						field_Public_VRCUiCursor_4.field_Public_Color_1 = this.color_8;
						field_Public_VRCUiCursor_4.field_Public_Color_0 = this.color_9;
					}
					if (field_Public_VRCUiCursor_5)
					{
						field_Public_VRCUiCursor_5.field_Public_Color_2 = this.Color_7;
						field_Public_VRCUiCursor_5.field_Public_Color_1 = this.color_8;
						field_Public_VRCUiCursor_5.field_Public_Color_0 = this.color_9;
					}
					this.method_158();
				}
			}
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000A9D48 File Offset: 0x000A7F48
		internal void method_156()
		{
			this.method_28();
			for (int i = 0; i < this.list_4.Count; i++)
			{
				this.list_4[i].text_0.color = this.list_4[i].color_0;
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000A9D9C File Offset: 0x000A7F9C
		private void method_157(ref GClass161.Struct28 struct28_0)
		{
			this.method_102(ref struct28_0);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000A9DB0 File Offset: 0x000A7FB0
		internal void method_158()
		{
			this.method_91();
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000A9DC4 File Offset: 0x000A7FC4
		internal void method_159(Texture texture_5)
		{
			this.method_82(texture_5);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
		internal void method_160(Texture texture_5)
		{
			this.texture_0 = texture_5;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000A9DEC File Offset: 0x000A7FEC
		internal void method_161()
		{
			Transform transform = GClass84.smethod_195().Find("Modal_QM_MoreActions/MenuPanel/ScrollRect/Viewport/VerticalLayoutGroup/Button_ViewUserDetails");
			GameObject gameObject = (transform != null) ? transform.gameObject : null;
			if (gameObject)
			{
				this.gameObject_5 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
				this.gameObject_5.name = "DropPortalButton";
				TextMeshProUGUI componentInChildren = this.gameObject_5.GetComponentInChildren<TextMeshProUGUI>();
				if (componentInChildren)
				{
					componentInChildren.text = "Drop Portal";
				}
				Button component = this.gameObject_5.GetComponent<Button>();
				if (component)
				{
					GClass84.smethod_243(component, new Action(this.method_115));
				}
				this.gameObject_6 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
				this.gameObject_6.name = "CopyInstanceIDButton";
				TextMeshProUGUI componentInChildren2 = this.gameObject_6.GetComponentInChildren<TextMeshProUGUI>();
				if (componentInChildren2)
				{
					componentInChildren2.text = "Copy Instance ID";
				}
				Button component2 = this.gameObject_6.GetComponent<Button>();
				if (component2)
				{
					GClass84.smethod_243(component2, new Action(this.method_151));
				}
			}
			this.method_192(this.bool_0);
			GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress").transform.localPosition = new Vector3(0f, 17f, 0f);
			this.method_128();
			GameObject gameObject2 = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop");
			if (gameObject2)
			{
				RectTransform component3 = gameObject2.GetComponent<RectTransform>();
				if (component3)
				{
					component3.sizeDelta = new Vector2(1040f, 528.8f);
					Vector2 vector = component3.localPosition;
					vector.y -= 176.099991f;
					component3.localPosition = vector;
				}
			}
			try
			{
				this.method_94();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			try
			{
				this.method_177();
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000A9FF4 File Offset: 0x000A81F4
		internal void method_162(string string_4, bool bool_23 = true, bool bool_24 = true, bool bool_25 = true)
		{
			this.method_181(string_4, bool_23, bool_24, bool_25);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000AA010 File Offset: 0x000A8210
		internal void method_163()
		{
			this.method_111();
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000AA024 File Offset: 0x000A8224
		internal void method_164(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_112(string_4, list_8, text_0);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000AA03C File Offset: 0x000A823C
		internal void method_165(bool bool_23)
		{
			this.method_143(bool_23);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000AA050 File Offset: 0x000A8250
		internal void method_166()
		{
			this.method_17();
			if (this.bool_11)
			{
				this.method_141(GClass84.float_0);
			}
			if (this.bool_9)
			{
				this.method_132(GClass84.float_0);
			}
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000AA08C File Offset: 0x000A828C
		internal void method_167()
		{
			this.method_207();
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000AA0A0 File Offset: 0x000A82A0
		internal void method_168(bool bool_23)
		{
			this.method_214(bool_23);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000AA0B4 File Offset: 0x000A82B4
		internal void method_169(bool bool_23)
		{
			this.Boolean_1 = bool_23;
			GClass117.gclass117_0.bool_24 = bool_23;
			GClass117.smethod_3();
			this.method_11();
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000AA0E0 File Offset: 0x000A82E0
		internal void method_170()
		{
			GameObject gameObject = this.method_118();
			if (gameObject)
			{
				if (this.Boolean_1)
				{
					if (this.gameObject_1 && this.gameObject_1.activeSelf == this.Boolean_1)
					{
						this.gameObject_1.SetActive(!this.Boolean_1);
					}
					if (this.gameObject_2 && this.gameObject_2.activeSelf == this.Boolean_1)
					{
						this.gameObject_2.SetActive(!this.Boolean_1);
					}
					if (this.gameObject_3 && this.gameObject_3.activeSelf == this.Boolean_1)
					{
						this.gameObject_3.SetActive(!this.Boolean_1);
					}
				}
				else if (!this.Boolean_0)
				{
					if (this.gameObject_2 && !this.gameObject_2.activeSelf)
					{
						this.gameObject_2.SetActive(true);
					}
					if (this.gameObject_3 && !this.gameObject_3.activeSelf)
					{
						this.gameObject_3.SetActive(true);
					}
					if (this.gameObject_1 && this.gameObject_1.activeSelf)
					{
						this.gameObject_1.SetActive(false);
					}
				}
				else if (!this.Boolean_1 && this.rawImage_1)
				{
					if (this.gameObject_2 && this.gameObject_2.activeSelf)
					{
						this.gameObject_2.SetActive(false);
					}
					if (this.gameObject_3 && this.gameObject_3.activeSelf)
					{
						this.gameObject_3.SetActive(false);
					}
					if (this.gameObject_1 && !this.gameObject_1.activeSelf)
					{
						this.gameObject_1.SetActive(true);
					}
					if (this.rawImage_1.color != this.Color_1)
					{
						this.rawImage_1.color = this.Color_1;
					}
					if (this.Texture_0)
					{
						if (this.rawImage_1.texture != this.Texture_0)
						{
							this.rawImage_1.texture = this.Texture_0;
						}
					}
					else if (this.rawImage_1.texture != this.texture_3)
					{
						this.rawImage_1.texture = this.texture_3;
					}
				}
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000AA380 File Offset: 0x000A8580
		internal void method_171()
		{
			GClass161.Class175 @class = new GClass161.Class175();
			@class.gclass161_0 = this;
			@class.transform_0 = GClass84.smethod_496();
			if (@class.transform_0)
			{
				Transform transform = @class.transform_0.Find("MenuSettingsButton");
				if (transform)
				{
					Object.DestroyImmediate(transform.gameObject);
				}
				Material material = new Material(Shader.Find("VRChat/UI/Default"));
				material.renderQueue = 4900;
				this.gameObject_8 = Object.Instantiate<Transform>(@class.transform_0.Find("Button_EditBindings"), @class.transform_0).gameObject;
				this.gameObject_8.name = "MenuSettingsButton";
				Object.DestroyImmediate(this.gameObject_8.transform.Find("Image_NEW").gameObject);
				Object.DestroyImmediate(this.gameObject_8.GetComponent<Image>());
				RawImage rawImage = this.gameObject_8.AddComponent<RawImage>();
				rawImage.material = material;
				rawImage.texture = GClass153.GClass87.texture2D_5;
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
				this.gameObject_8.GetComponentInChildren<Text>().text = "Menu Settings";
				RectTransform component = this.gameObject_8.GetComponent<RectTransform>();
				vector = component.anchorMin;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMin = vector;
				vector = component.anchorMax;
				vector.x = 0f;
				vector.y = 1f;
				component.anchorMax = vector;
				component.sizeDelta = new Vector2(187.5f, 72f);
				component.localPosition = new Vector2(-185f, 374.425f);
				Button component2 = this.gameObject_8.GetComponent<Button>();
				component2.targetGraphic = rawImage;
				GClass84.smethod_243(component2, new Action(@class.method_3));
				Transform transform2 = @class.transform_0.Find("MenuSettingsPopup");
				if (transform2)
				{
					Object.DestroyImmediate(transform2.gameObject);
				}
				GameObject gameObject = Object.Instantiate<Transform>(GClass84.smethod_1282().Find("ControllerBindingsPopup"), @class.transform_0).gameObject;
				gameObject.name = "MenuSettingsPopup";
				Object.DestroyImmediate(gameObject.GetComponent<PopupControllerBindings>());
				Object.DestroyImmediate(gameObject.GetComponent<CanvasGroup>());
				Object.DestroyImmediate(gameObject.transform.Find("Popup/PageButtons").gameObject);
				Object.DestroyImmediate(gameObject.transform.Find("Popup/Pages").gameObject);
				GameObject gameObject2 = gameObject.transform.Find("Darkness").gameObject;
				GameObject gameObject3 = gameObject.transform.Find("Popup/ExitButton").gameObject;
				Button component3 = gameObject3.GetComponent<Button>();
				GClass84.smethod_243(component3, new Action(@class.method_0));
				GameObject gameObject4 = gameObject.transform.Find("Popup/TitleText").gameObject;
				Text component4 = gameObject4.GetComponent<Text>();
				component4.text = "Menu Settings";
				GameObject gameObject5 = Object.Instantiate<GameObject>(this.gameObject_8, gameObject.transform.Find("Popup")).gameObject;
				gameObject5.name = "SetButton";
				gameObject5.GetComponentInChildren<Text>().text = "Set";
				component = gameObject5.GetComponent<RectTransform>();
				component.sizeDelta = new Vector2(180f, 60f);
				component.localPosition = new Vector2(400f, 250f);
				GameObject gameObject6 = Object.Instantiate<GameObject>(gameObject5, gameObject5.transform.parent).gameObject;
				gameObject6.name = "ResetButton";
				gameObject6.GetComponentInChildren<Text>().text = "Reset";
				component = gameObject6.GetComponent<RectTransform>();
				component.localPosition = new Vector2(580f, 250f);
				@class.gameObject_0 = Object.Instantiate<GameObject>(gameObject6, gameObject6.transform.parent).gameObject;
				@class.gameObject_0.name = "Background";
				RawImage component5 = @class.gameObject_0.GetComponent<RawImage>();
				component5.texture = GClass153.GClass87.texture2D_0;
				component5.color = new Color(0.25f, 0.25f, 0.25f, 1f);
				@class.gameObject_0.GetComponentInChildren<Text>().text = GClass84.smethod_108<string>(this.String_0 != string.Empty, this.String_0, "Enter path or link...");
				GClass84.smethod_243(@class.gameObject_0.GetComponent<Button>(), new Action(@class.method_1));
				component = @class.gameObject_0.GetComponent<RectTransform>();
				component.sizeDelta = new Vector2(835f, 60f);
				component.localPosition = new Vector2(-107f, 250f);
				GameObject gameObject7 = Object.Instantiate<GameObject>(gameObject5, gameObject5.transform.parent).gameObject;
				Object.DestroyImmediate(gameObject7.GetComponent<Button>());
				Object.DestroyImmediate(gameObject7.GetComponent<RawImage>());
				gameObject7.name = "BackgroundText";
				gameObject7.GetComponentInChildren<Text>().text = "Background:";
				component = gameObject7.GetComponent<RectTransform>();
				component.sizeDelta = new Vector2(150f, 60f);
				component.localPosition = new Vector2(-600f, 250f);
				GClass84.smethod_243(gameObject5.GetComponent<Button>(), new Action(@class.method_2));
				GClass84.smethod_243(gameObject6.GetComponent<Button>(), new Action(@class.method_4));
				this.gclass31_0 = new GClass31(string.Empty, 0f, 0f, 4f, 1f, new Action<float>(this.method_215), new Color?(Color.Lerp(Color.red, Color.black, 0.8f)), new Color?(Color.Lerp(Color.red, Color.black, 0.5f)), false, 0f, null);
				this.gclass31_0.method_22(this.Color_0.r, false);
				this.gclass31_0.method_3().transform.SetParent(gameObject.transform.Find("Popup"));
				RectTransform component6 = this.gclass31_0.method_3().GetComponent<RectTransform>();
				component6.sizeDelta = new Vector2(1340f, 60f);
				component6.localPosition = new Vector2(0f, 190f);
				component6.localRotation = default(Quaternion);
				component6.localScale = new Vector3(1f, 1f, 1f);
				this.gclass31_1 = new GClass31(string.Empty, 0f, 0f, 4f, 1f, new Action<float>(this.method_142), new Color?(Color.Lerp(Color.green, Color.black, 0.8f)), new Color?(Color.Lerp(Color.green, Color.black, 0.5f)), false, 0f, null);
				this.gclass31_1.method_22(this.Color_0.g, false);
				this.gclass31_1.method_3().transform.SetParent(gameObject.transform.Find("Popup"));
				RectTransform component7 = this.gclass31_1.method_3().GetComponent<RectTransform>();
				component7.sizeDelta = new Vector2(1340f, 60f);
				component7.localPosition = new Vector2(0f, 130f);
				component7.localRotation = default(Quaternion);
				component7.localScale = new Vector3(1f, 1f, 1f);
				this.gclass31_2 = new GClass31(string.Empty, 0f, 0f, 4f, 1f, new Action<float>(this.method_232), new Color?(Color.Lerp(Color.blue, Color.black, 0.8f)), new Color?(Color.Lerp(Color.blue, Color.black, 0.5f)), false, 0f, null);
				this.gclass31_2.method_22(this.Color_0.b, false);
				this.gclass31_2.method_3().transform.SetParent(gameObject.transform.Find("Popup"));
				RectTransform component8 = this.gclass31_2.method_3().GetComponent<RectTransform>();
				component8.sizeDelta = new Vector2(1340f, 60f);
				component8.localPosition = new Vector2(0f, 70f);
				component8.localRotation = default(Quaternion);
				component8.localScale = new Vector3(1f, 1f, 1f);
				this.gclass31_3 = new GClass31(string.Empty, 0f, 0f, 4f, 1f, new Action<float>(this.method_2), new Color?(Color.Lerp(Color.white, Color.black, 0.8f)), new Color?(Color.Lerp(Color.white, Color.black, 0.5f)), false, 0f, null);
				this.gclass31_3.method_22(this.Color_0.a, false);
				this.gclass31_3.method_3().transform.SetParent(gameObject.transform.Find("Popup"));
				RectTransform component9 = this.gclass31_3.method_3().GetComponent<RectTransform>();
				component9.sizeDelta = new Vector2(1340f, 60f);
				component9.localPosition = new Vector2(0f, 10f);
				component9.localRotation = default(Quaternion);
				component9.localScale = new Vector3(1f, 1f, 1f);
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000AADB4 File Offset: 0x000A8FB4
		internal void method_172(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_86(string_4);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000AADC8 File Offset: 0x000A8FC8
		internal void method_173()
		{
			this.method_126();
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000AADDC File Offset: 0x000A8FDC
		internal void method_174(Color color_18)
		{
			this.method_27(color_18);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000AADF0 File Offset: 0x000A8FF0
		internal void method_175()
		{
			this.method_62();
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000AAE04 File Offset: 0x000A9004
		internal void method_176(Color color_18)
		{
			this.method_133(color_18);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000AAE2C File Offset: 0x000A902C
		internal void method_177()
		{
			this.method_238();
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000AAE40 File Offset: 0x000A9040
		internal void method_178()
		{
			this.method_225();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000AB104 File Offset: 0x000A9304
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x000AAE54 File Offset: 0x000A9054
		internal Color Color_4
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_4;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_4;
						}
					}
					result = this.color_4;
				}
				return result;
			}
			set
			{
				this.method_154(value);
			}
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000AAE68 File Offset: 0x000A9068
		internal void method_179(Color color_18)
		{
			this.method_121(color_18);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000AAE7C File Offset: 0x000A907C
		internal void method_180(Color color_18)
		{
			this.Color_1 = GClass84.smethod_1042(color_18, 0f, 1f);
			GClass117.gclass117_0.float_4 = this.Color_1.r;
			GClass117.gclass117_0.float_5 = this.Color_1.g;
			GClass117.gclass117_0.float_6 = this.Color_1.b;
			GClass117.gclass117_0.float_7 = this.Color_1.a;
			GClass117.smethod_3();
			this.method_11();
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000AAF00 File Offset: 0x000A9100
		internal void method_181(string string_4, bool bool_23, bool bool_24, bool bool_25)
		{
			this.method_87(string_4, bool_23, bool_24, bool_25);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000AAF1C File Offset: 0x000A911C
		internal List<string> method_182()
		{
			List<string> list = new List<string>
			{
				string.Empty
			};
			for (int i = 0; i < this.list_7.Count; i++)
			{
				list.Add(this.list_7[i].string_0);
			}
			return list;
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000AAF6C File Offset: 0x000A916C
		public override void vmethod_19()
		{
			this.method_103();
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000AAF80 File Offset: 0x000A9180
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x000ABC2C File Offset: 0x000A9E2C
		internal Color Color_1
		{
			get
			{
				Color result;
				if (string.IsNullOrEmpty(this.string_3))
				{
					result = this.color_1;
				}
				else
				{
					for (int i = 0; i < this.list_7.Count; i++)
					{
						if (this.list_7[i].string_0 == this.string_3)
						{
							return this.list_7[i].color_1;
						}
					}
					result = this.color_1;
				}
				return result;
			}
			set
			{
				this.method_120(value);
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000AAFF8 File Offset: 0x000A91F8
		internal void method_183(bool bool_23, Color? nullable_0)
		{
			this.method_26(bool_23, nullable_0);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x000AB010 File Offset: 0x000A9210
		internal string method_184()
		{
			string result;
			if (string.IsNullOrEmpty(this.string_3))
			{
				result = this.string_2;
			}
			else
			{
				for (int i = 0; i < this.list_7.Count; i++)
				{
					if (this.list_7[i].string_0 == this.string_3)
					{
						return this.list_7[i].string_2;
					}
				}
				result = this.string_2;
			}
			return result;
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000AB088 File Offset: 0x000A9288
		internal void method_185(float float_2)
		{
			this.method_63(float_2);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x000AB09C File Offset: 0x000A929C
		internal void method_186(Color color_18)
		{
			this.method_117(color_18);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x000AB0B0 File Offset: 0x000A92B0
		internal void method_187(bool bool_23)
		{
			this.method_153(bool_23);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x000AB0C4 File Offset: 0x000A92C4
		internal void method_188()
		{
			this.method_156();
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000AB0D8 File Offset: 0x000A92D8
		private void method_189(ref GClass161.Struct29 struct29_0, Color? nullable_0)
		{
			this.method_106(ref struct29_0, nullable_0);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x000AB0F0 File Offset: 0x000A92F0
		internal void method_190()
		{
			this.method_71();
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000AB17C File Offset: 0x000A937C
		internal void method_191()
		{
			this.method_122();
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000AB208 File Offset: 0x000A9408
		internal void method_192(bool bool_23 = true)
		{
			this.method_55(bool_23);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000AB21C File Offset: 0x000A941C
		internal void method_193(bool bool_23)
		{
			this.method_226(bool_23);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000AB230 File Offset: 0x000A9430
		internal void method_194()
		{
			this.method_196();
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000AB2BC File Offset: 0x000A94BC
		internal void method_195(bool bool_23)
		{
			this.bool_11 = bool_23;
			this.method_75();
			this.method_139(false);
			GClass117.gclass117_0.bool_17 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000AB2F0 File Offset: 0x000A94F0
		internal void method_196()
		{
			this.method_203();
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000AB304 File Offset: 0x000A9504
		internal void method_197(float float_2)
		{
			this.float_1 = (this.float_1 + float_2 * 60f) % 360f;
			Color value;
			value..ctor(0f, 0f, 0f, 1f);
			if (this.float_1 < 60f)
			{
				value.r = 1f;
				value.g = this.float_1 / 60f;
				value.b = 0f;
			}
			else if (this.float_1 < 120f)
			{
				value.r = 1f - (this.float_1 - 60f) / 60f;
				value.g = 1f;
				value.b = 0f;
			}
			else if (this.float_1 < 180f)
			{
				value.r = 0f;
				value.g = 1f;
				value.b = (this.float_1 - 120f) / 60f;
			}
			else if (this.float_1 < 240f)
			{
				value.r = 0f;
				value.g = 1f - (this.float_1 - 180f) / 60f;
				value.b = 1f;
			}
			else if (this.float_1 < 300f)
			{
				value.r = (this.float_1 - 240f) / 60f;
				value.g = 0f;
				value.b = 1f;
			}
			else if (this.float_1 < 360f)
			{
				value.r = 1f;
				value.g = 0f;
				value.b = 1f - (this.float_1 - 300f) / 60f;
			}
			this.method_212(true, new Color?(value));
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000AB570 File Offset: 0x000A9770
		internal void method_198(bool bool_23, Color? nullable_0)
		{
			this.method_19(bool_23, nullable_0);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000AB588 File Offset: 0x000A9788
		internal void method_199()
		{
			this.method_32();
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000AB59C File Offset: 0x000A979C
		internal void method_200(bool bool_23)
		{
			this.method_72(bool_23);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000AB5B0 File Offset: 0x000A97B0
		private void method_201(ref GClass161.Struct30 struct30_0, Color? nullable_0 = null)
		{
			this.method_20(ref struct30_0, nullable_0);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x000AB5DC File Offset: 0x000A97DC
		public override void vmethod_21(Object object_0)
		{
			this.method_85(object_0);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x000AB5F0 File Offset: 0x000A97F0
		internal void method_202(Color color_18)
		{
			this.color_7 = color_18;
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x000AB604 File Offset: 0x000A9804
		internal void method_203()
		{
			if (this.bool_13)
			{
				GClass84.smethod_73(this.Color_8);
			}
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x000AB628 File Offset: 0x000A9828
		internal void method_204(bool bool_23 = true, bool bool_24 = true)
		{
			this.method_131(bool_23, bool_24);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x000AB640 File Offset: 0x000A9840
		internal void method_205(bool bool_23)
		{
			this.bool_13 = bool_23;
			GClass117.gclass117_0.bool_19 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000AB664 File Offset: 0x000A9864
		internal void method_206(bool bool_23)
		{
			this.method_127(bool_23);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000AB678 File Offset: 0x000A9878
		internal void method_207()
		{
			this.method_228();
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x000AB68C File Offset: 0x000A988C
		internal void method_208()
		{
			if (this.bool_15 && GClass84.smethod_1424() == null && GClass84.smethod_813() == null)
			{
				GameObject gameObject = GClass84.smethod_1578();
				if (gameObject && gameObject.activeInHierarchy)
				{
					Image component = gameObject.GetComponent<Image>();
					if (component)
					{
						float num = component.fillAmount;
						if ((double)num < 0.5)
						{
							num *= 2f;
							component.color = this.color_15 + (this.color_16 - this.color_15) * num;
						}
						else
						{
							num = (num - 0.5f) * 2f;
							component.color = this.color_16 + (this.color_17 - this.color_16) * num;
						}
					}
				}
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000AB778 File Offset: 0x000A9978
		internal void method_209(Object object_0)
		{
			if (object_0)
			{
				GameObject gameObject = object_0.TryCast<GameObject>();
				if (gameObject && gameObject.layer == 19)
				{
					List<Selectable> list = new List<Selectable>();
					Il2CppArrayBase<Selectable> componentsInChildren = gameObject.GetComponentsInChildren<Selectable>(true);
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						this.list_1.Add(new GClass161.Struct24(componentsInChildren[i], componentsInChildren[i].colors));
						list.Add(componentsInChildren[i]);
					}
					if (list.Count > 0)
					{
						GClass161.Struct28 item = new GClass161.Struct28(gameObject, list);
						this.method_157(ref item);
						this.list_0.Add(item);
					}
					List<Text> list2 = new List<Text>();
					Il2CppArrayBase<Text> componentsInChildren2 = gameObject.GetComponentsInChildren<Text>(true);
					for (int j = 0; j < componentsInChildren2.Length; j++)
					{
						this.list_4.Add(new GClass161.Struct26(componentsInChildren2[j], componentsInChildren2[j].color));
						list2.Add(componentsInChildren2[j]);
					}
					if (list2.Count > 0)
					{
						for (int k = 0; k < list2.Count; k++)
						{
							Outline[] array = list2[k].GetComponents<Outline>();
							for (int l = 0; l < array.Length; l++)
							{
								array[l].effectColor = new Color(0f, 0f, 0f, 0.5f);
							}
						}
						GClass161.Struct29 item2 = new GClass161.Struct29(gameObject, list2);
						this.method_52(ref item2, null);
						this.list_3.Add(item2);
					}
					List<TextMeshProUGUI> list3 = new List<TextMeshProUGUI>();
					Il2CppArrayBase<TextMeshProUGUI> componentsInChildren3 = gameObject.GetComponentsInChildren<TextMeshProUGUI>(true);
					for (int m = 0; m < componentsInChildren3.Length; m++)
					{
						this.list_6.Add(new GClass161.Struct27(componentsInChildren3[m], componentsInChildren3[m].color));
						list3.Add(componentsInChildren3[m]);
					}
					if (list3.Count > 0)
					{
						GClass161.Struct30 item3 = new GClass161.Struct30(gameObject, list3);
						this.method_201(ref item3, null);
						this.list_5.Add(item3);
					}
				}
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000AB9D0 File Offset: 0x000A9BD0
		internal void method_210()
		{
			this.method_145();
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000AB9E4 File Offset: 0x000A9BE4
		internal void method_211()
		{
			this.method_60();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000AB9F8 File Offset: 0x000A9BF8
		internal void method_212(bool bool_23 = false, Color? nullable_0 = null)
		{
			this.method_183(bool_23, nullable_0);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000ABA10 File Offset: 0x000A9C10
		internal void method_213(string string_4, List<KeyCode> list_8, Text text_0)
		{
			this.method_68(string_4, list_8, text_0);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000ABA28 File Offset: 0x000A9C28
		internal void method_214(bool bool_23)
		{
			this.bool_10 = bool_23;
			if (!bool_23)
			{
				this.method_138();
			}
			else
			{
				this.method_139(false);
			}
			GClass117.gclass117_0.bool_16 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000ABA64 File Offset: 0x000A9C64
		internal void method_215(float float_2)
		{
			this.method_73(float_2);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000ABA78 File Offset: 0x000A9C78
		internal void method_216(bool bool_23)
		{
			this.method_35(bool_23);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000ABA8C File Offset: 0x000A9C8C
		internal void method_217(bool bool_23)
		{
			this.method_223(bool_23);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		private void method_218(ref GClass161.Struct30 struct30_0, Color? nullable_0)
		{
			if (this.bool_8)
			{
				if (nullable_0 == null)
				{
					nullable_0 = new Color?(this.Color_6);
				}
				Color value = nullable_0.Value;
				for (int i = 0; i < struct30_0.list_0.Count; i++)
				{
					struct30_0.list_0[i].color = value;
				}
			}
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000ABB04 File Offset: 0x000A9D04
		internal void method_219(bool bool_23)
		{
			this.bool_9 = bool_23;
			this.method_212(false, null);
			GClass117.gclass117_0.bool_15 = bool_23;
			GClass117.smethod_3();
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000ABB38 File Offset: 0x000A9D38
		internal void method_220(bool bool_23)
		{
			this.method_46(bool_23);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x000ABB4C File Offset: 0x000A9D4C
		internal void method_221(bool bool_23)
		{
			this.method_74(bool_23);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x000ABB60 File Offset: 0x000A9D60
		internal void method_222(string string_4, bool bool_23)
		{
			this.method_77(string_4, bool_23);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000ABB78 File Offset: 0x000A9D78
		internal void method_223(bool bool_23)
		{
			this.method_219(bool_23);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x000ABBA0 File Offset: 0x000A9DA0
		internal void method_224(float float_2)
		{
			this.method_136(float_2);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000ABC40 File Offset: 0x000A9E40
		internal void method_225()
		{
			this.method_155();
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000ABC54 File Offset: 0x000A9E54
		internal void method_226(bool bool_23)
		{
			if (this.bool_10)
			{
				if (bool_23)
				{
					for (int i = 0; i < this.list_0.Count; i++)
					{
						if (this.list_0[i].gameObject_0.active)
						{
							for (int j = 0; j < this.list_0[i].list_0.Count; j++)
							{
								if (!this.list_0[i].list_0[j])
								{
									this.list_0[i].list_0.RemoveAt(j);
								}
								else
								{
									this.list_0[i].list_0[j].colors = this.colorBlock_0;
								}
							}
						}
					}
				}
				else
				{
					for (int k = 0; k < this.list_0.Count; k++)
					{
						for (int l = 0; l < this.list_0[k].list_0.Count; l++)
						{
							if (!this.list_0[k].list_0[l])
							{
								this.list_0[k].list_0.RemoveAt(l);
							}
							else
							{
								this.list_0[k].list_0[l].colors = this.colorBlock_0;
							}
						}
					}
				}
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000ABE08 File Offset: 0x000AA008
		internal void method_227(Color color_18)
		{
			this.method_230(color_18);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000ABE1C File Offset: 0x000AA01C
		internal void method_228()
		{
			try
			{
				this.method_235();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			GameObject gameObject = GClass84.smethod_1095();
			if (gameObject)
			{
				GameObject[] array = GClass84.smethod_1034(gameObject);
				for (int i = 0; i < array.Length; i++)
				{
					GameObject[] array2 = GClass84.smethod_1034(array[i]);
					if (array2.Length >= 1)
					{
						for (int j = 0; j < array2.Length; j++)
						{
							if (array2[j].name == "QuickModeMenus")
							{
								GameObject[] array3 = GClass84.smethod_1034(array2[j]);
								for (int k = 0; k < array3.Length; k++)
								{
									List<Text> list = new List<Text>();
									Il2CppArrayBase<Text> componentsInChildren = array3[k].GetComponentsInChildren<Text>(true);
									for (int l = 0; l < componentsInChildren.Length; l++)
									{
										this.list_4.Add(new GClass161.Struct26(componentsInChildren[l], componentsInChildren[l].color));
										list.Add(componentsInChildren[l]);
									}
									if (list.Count > 0)
									{
										this.list_3.Add(new GClass161.Struct29(array3[k], list));
									}
								}
							}
							else
							{
								List<Text> list2 = new List<Text>();
								Il2CppArrayBase<Text> componentsInChildren2 = array2[j].GetComponentsInChildren<Text>(true);
								for (int m = 0; m < componentsInChildren2.Length; m++)
								{
									this.list_4.Add(new GClass161.Struct26(componentsInChildren2[m], componentsInChildren2[m].color));
									list2.Add(componentsInChildren2[m]);
								}
								if (list2.Count > 0)
								{
									for (int n = 0; n < list2.Count; n++)
									{
										Outline[] array4 = list2[n].GetComponents<Outline>();
										for (int num = 0; num < array4.Length; num++)
										{
											array4[num].effectColor = new Color(0f, 0f, 0f, 0.5f);
										}
									}
									this.list_3.Add(new GClass161.Struct29(array2[j], list2));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000AC06C File Offset: 0x000AA26C
		internal void method_229()
		{
			this.method_208();
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000AC080 File Offset: 0x000AA280
		internal void method_230(Color color_18)
		{
			this.color_11 = color_18;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x000AC094 File Offset: 0x000AA294
		internal void method_231()
		{
			Transform transform = GClass84.smethod_292();
			Transform transform2 = (transform != null) ? transform.Find("TitlePanel (1)") : null;
			if (transform2)
			{
				Image component = transform2.GetComponent<Image>();
				if (component)
				{
					Color color = component.color;
					color.r = 0.05f;
					color.g = 0.05f;
					color.b = 0.05f;
					component.color = color;
				}
			}
			Transform transform3 = GClass84.smethod_496();
			transform2 = ((transform3 != null) ? transform3.Find("TitlePanel") : null);
			if (transform2)
			{
				Image component2 = transform2.GetComponent<Image>();
				if (component2)
				{
					Color color2 = component2.color;
					color2.r = 0.05f;
					color2.g = 0.05f;
					color2.b = 0.05f;
					component2.color = color2;
				}
			}
			transform2 = GClass84.smethod_496();
			if (transform2)
			{
				List<Transform> list = GClass84.smethod_1495(transform2);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].name == "Panel_Header" || list[i].name == "Panel_Header (1)" || list[i].name == "Panel_Header Top")
					{
						Image component3 = list[i].GetComponent<Image>();
						if (component3)
						{
							Color color3 = component3.color;
							color3.r = 0.1f;
							color3.g = 0.1f;
							color3.b = 0.1f;
							component3.color = color3;
						}
						component3 = list[i].parent.GetComponent<Image>();
						if (component3)
						{
							Color color4 = component3.color;
							color4.r = 0.05f;
							color4.g = 0.05f;
							color4.b = 0.05f;
							component3.color = color4;
						}
					}
					else if (list[i].name == "Checkmark")
					{
						Image component4 = list[i].GetComponent<Image>();
						if (component4)
						{
							Color color5 = component4.color;
							color5.r = 0.4f;
							color5.g = 0f;
							color5.b = 0f;
							component4.color = color5;
						}
						Image component5 = list[i].parent.GetComponent<Image>();
						if (component5)
						{
							Color color6 = component5.color;
							color6.r = 0.1f;
							color6.g = 0.1f;
							color6.b = 0.1f;
							component5.color = color6;
						}
					}
				}
				Slider[] array = transform2.GetComponentsInChildren<Slider>(true);
				for (int j = 0; j < array.Length; j++)
				{
					Image component6 = array[j].GetComponent<Image>();
					if (component6)
					{
						Color color7 = component6.color;
						color7.r = 0.05f;
						color7.g = 0.05f;
						color7.b = 0.05f;
						component6.color = color7;
					}
					RectTransform fillRect = array[j].fillRect;
					Image image = (fillRect != null) ? fillRect.GetComponent<Image>() : null;
					if (image)
					{
						Color color8 = image.color;
						color8.r = 0.4f;
						color8.g = 0f;
						color8.b = 0f;
						image.color = color8;
					}
					RectTransform handleRect = array[j].handleRect;
					Image image2 = (handleRect != null) ? handleRect.GetComponent<Image>() : null;
					if (image2)
					{
						Color color9 = image2.color;
						color9.r = 0.4f;
						color9.g = 0f;
						color9.b = 0f;
						image2.color = color9;
					}
				}
			}
			Transform transform4 = GClass84.smethod_1518();
			transform2 = ((transform4 != null) ? transform4.Find("_Buttons_SafetyLevel") : null);
			if (transform2)
			{
				List<Transform> list2 = GClass84.smethod_1495(transform2);
				for (int k = 0; k < list2.Count; k++)
				{
					if (list2[k].name == "TopPanel_SafetyLevel")
					{
						Image component7 = list2[k].GetComponent<Image>();
						if (component7)
						{
							Color color10 = component7.color;
							color10.r = 0.1f;
							color10.g = 0.1f;
							color10.b = 0.1f;
							component7.color = color10;
						}
						component7 = list2[k].parent.GetComponent<Image>();
						if (component7)
						{
							Color color11 = component7.color;
							color11.r = 0.05f;
							color11.g = 0.05f;
							color11.b = 0.05f;
							component7.color = color11;
						}
					}
				}
			}
			Transform transform5 = GClass84.smethod_1518();
			transform2 = ((transform5 != null) ? transform5.Find("_Description_SafetyLevel") : null);
			if (transform2)
			{
				Image component8 = transform2.GetComponent<Image>();
				if (component8)
				{
					Color color12 = component8.color;
					color12.r = 0.05f;
					color12.g = 0.05f;
					color12.b = 0.05f;
					component8.color = color12;
				}
			}
			Transform transform6 = GClass84.smethod_496();
			transform2 = ((transform6 != null) ? transform6.Find("ComfortSafetyPanel/StreamerModeToggle/InfoButton") : null);
			if (transform2)
			{
				Image component9 = transform2.GetComponent<Image>();
				if (component9)
				{
					Color color13 = component9.color;
					color13.r = 1f;
					color13.g = 0f;
					color13.b = 0f;
					component9.color = color13;
				}
			}
			transform2 = GClass84.smethod_1518();
			if (transform2)
			{
				MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerClickHandlerObStCoToCoStImRaCoStUnique[] array2 = transform2.GetComponentsInChildren<MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerClickHandlerObStCoToCoStImRaCoStUnique>(true);
				for (int l = 0; l < array2.Length; l++)
				{
					Color field_Private_Color_ = array2[l].field_Private_Color_0;
					field_Private_Color_.r = 0.4f;
					field_Private_Color_.g = 0f;
					field_Private_Color_.b = 0f;
					array2[l].field_Private_Color_0 = field_Private_Color_;
				}
			}
			Transform transform7 = GClass84.smethod_496();
			transform2 = ((transform7 != null) ? transform7.Find("VolumePanel/Panel_Header Side") : null);
			if (transform2)
			{
				Image component10 = transform2.GetComponent<Image>();
				if (component10)
				{
					Color color14 = component10.color;
					color14.r = 0.4f;
					color14.g = 0f;
					color14.b = 0f;
					component10.color = color14;
				}
			}
			Transform transform8 = GClass84.smethod_496();
			transform2 = ((transform8 != null) ? transform8.Find("MousePanel/SensitivitySlider/Background") : null);
			if (transform2)
			{
				Image component11 = transform2.GetComponent<Image>();
				if (component11)
				{
					Color color15 = component11.color;
					color15.r = 0.1f;
					color15.g = 0.1f;
					color15.b = 0.1f;
					component11.color = color15;
				}
			}
			Transform transform9 = GClass84.smethod_496();
			transform2 = ((transform9 != null) ? transform9.Find("AudioDevicePanel/VolumeDisplay/Background") : null);
			if (transform2)
			{
				Image component12 = transform2.GetComponent<Image>();
				if (component12)
				{
					Color color16 = component12.color;
					color16.r = 0.1f;
					color16.g = 0.1f;
					color16.b = 0.1f;
					component12.color = color16;
				}
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000AC7F4 File Offset: 0x000AA9F4
		internal void method_232(float float_2)
		{
			this.method_97(float_2);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000AC808 File Offset: 0x000AAA08
		internal void method_233(Texture texture_5)
		{
			this.method_89(texture_5);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x000AC81C File Offset: 0x000AAA1C
		internal void method_234()
		{
			VRCUiCursorManager vrcuiCursorManager = GClass84.smethod_615();
			if (vrcuiCursorManager)
			{
				Transform transform = vrcuiCursorManager.transform.Find("MouseArrow");
				if (transform)
				{
					Transform transform2 = transform.Find("VRCUICursorIcon");
					if (transform2)
					{
						SpriteRenderer component = transform2.GetComponent<SpriteRenderer>();
						if (component)
						{
							component.color = this.Color_7;
						}
					}
				}
				Transform transform3 = vrcuiCursorManager.transform.Find("DotLeftHand");
				if (transform3)
				{
					HandDotCursor component2 = transform3.GetComponent<HandDotCursor>();
					if (component2)
					{
						component2.field_Public_Color_0 = new Color(0.3f, 0f, 0f);
						component2.field_Public_Color_1 = new Color(1f, 0f, 0f);
					}
					Transform transform4 = transform3.Find("VRCUICursorIcon");
					if (transform4)
					{
						SpriteRenderer component3 = transform4.GetComponent<SpriteRenderer>();
						if (component3)
						{
							component3.color = this.Color_7;
						}
					}
				}
				Transform transform5 = vrcuiCursorManager.transform.Find("DotRightHand");
				if (transform5)
				{
					HandDotCursor component4 = transform5.GetComponent<HandDotCursor>();
					if (component4)
					{
						component4.field_Public_Color_0 = new Color(0.3f, 0f, 0f);
						component4.field_Public_Color_1 = new Color(1f, 0f, 0f);
					}
					Transform transform6 = transform5.Find("VRCUICursorIcon");
					if (transform6)
					{
						SpriteRenderer component5 = transform6.GetComponent<SpriteRenderer>();
						if (component5)
						{
							component5.color = this.Color_7;
						}
					}
				}
				Transform transform7 = vrcuiCursorManager.transform.Find("LeftHandBeam");
				if (transform7)
				{
					LineRenderer component6 = transform7.GetComponent<LineRenderer>();
					if (component6)
					{
						for (int i = 0; i < component6.materials.Count; i++)
						{
							Material material = component6.materials[i];
							if (material)
							{
								try
								{
									material.mainTexture = GClass153.GClass88.texture2D_26;
								}
								catch (Exception ex)
								{
									GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
								}
							}
						}
					}
					Transform transform8 = transform7.Find("plasma_beam_muzzle_blue");
					if (transform8)
					{
						ParticleSystemRenderer component7 = transform8.GetComponent<ParticleSystemRenderer>();
						if (component7)
						{
							for (int j = 0; j < component7.materials.Count; j++)
							{
								Material material2 = component7.materials[j];
								if (material2)
								{
									try
									{
										material2.mainTexture = GClass153.GClass88.texture2D_26;
									}
									catch (Exception ex2)
									{
										GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
									}
								}
							}
						}
					}
					Transform transform9 = transform7.Find("plasma_beam_flare_blue");
					if (transform9)
					{
						ParticleSystemRenderer component8 = transform9.GetComponent<ParticleSystemRenderer>();
						if (component8)
						{
							for (int k = 0; k < component8.materials.Count; k++)
							{
								Material material3 = component8.materials[k];
								if (material3)
								{
									try
									{
										material3.mainTexture = GClass153.GClass88.texture2D_22;
									}
									catch (Exception ex3)
									{
										GClass70.smethod_36(ex3.ToString(), GClass70.Enum1.const_0);
									}
								}
							}
						}
						Transform transform10 = transform9.Find("plasma_beam_spark_002");
						if (transform10)
						{
							ParticleSystemRenderer component9 = transform10.GetComponent<ParticleSystemRenderer>();
							if (component9)
							{
								for (int l = 0; l < component9.materials.Count; l++)
								{
									Material material4 = component9.materials[l];
									if (material4)
									{
										try
										{
											material4.mainTexture = GClass153.GClass88.texture2D_24;
										}
										catch (Exception ex4)
										{
											GClass70.smethod_36(ex4.ToString(), GClass70.Enum1.const_0);
										}
									}
								}
							}
						}
					}
				}
				Transform transform11 = vrcuiCursorManager.transform.Find("RightHandBeam");
				if (transform11)
				{
					LineRenderer component10 = transform11.GetComponent<LineRenderer>();
					if (component10)
					{
						for (int m = 0; m < component10.materials.Count; m++)
						{
							Material material5 = component10.materials[m];
							if (material5)
							{
								try
								{
									material5.mainTexture = GClass153.GClass88.texture2D_26;
								}
								catch (Exception ex5)
								{
									GClass70.smethod_36(ex5.ToString(), GClass70.Enum1.const_0);
								}
							}
						}
					}
					Transform transform12 = transform11.Find("plasma_beam_muzzle_blue");
					if (transform12)
					{
						ParticleSystemRenderer component11 = transform12.GetComponent<ParticleSystemRenderer>();
						if (component11)
						{
							for (int n = 0; n < component11.materials.Count; n++)
							{
								Material material6 = component11.materials[n];
								if (material6)
								{
									try
									{
										material6.mainTexture = GClass153.GClass88.texture2D_22;
									}
									catch (Exception ex6)
									{
										GClass70.smethod_36(ex6.ToString(), GClass70.Enum1.const_0);
									}
								}
							}
						}
					}
					Transform transform13 = transform11.Find("plasma_beam_flare_blue");
					if (transform13)
					{
						ParticleSystemRenderer component12 = transform13.GetComponent<ParticleSystemRenderer>();
						if (component12)
						{
							for (int num = 0; num < component12.materials.Count; num++)
							{
								Material material7 = component12.materials[num];
								if (material7)
								{
									try
									{
										material7.mainTexture = GClass153.GClass88.texture2D_22;
									}
									catch (Exception ex7)
									{
										GClass70.smethod_36(ex7.ToString(), GClass70.Enum1.const_0);
									}
								}
							}
						}
						Transform transform14 = transform13.Find("plasma_beam_spark_002");
						if (transform14)
						{
							ParticleSystemRenderer component13 = transform14.GetComponent<ParticleSystemRenderer>();
							if (component13)
							{
								for (int num2 = 0; num2 < component13.materials.Count; num2++)
								{
									Material material8 = component13.materials[num2];
									if (material8)
									{
										try
										{
											material8.mainTexture = GClass153.GClass88.texture2D_24;
										}
										catch (Exception ex8)
										{
											GClass70.smethod_36(ex8.ToString(), GClass70.Enum1.const_0);
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x000ACE28 File Offset: 0x000AB028
		internal void method_235()
		{
			this.method_108();
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000ACE3C File Offset: 0x000AB03C
		internal void method_236()
		{
			this.method_15();
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000ACE50 File Offset: 0x000AB050
		internal void method_237()
		{
			this.method_49();
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000ACE64 File Offset: 0x000AB064
		internal void method_238()
		{
			this.method_88();
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000ACE78 File Offset: 0x000AB078
		internal void method_239(Color color_18)
		{
			this.color_0 = color_18;
		}

		// Token: 0x040012CD RID: 4813
		internal bool bool_0 = false;

		// Token: 0x040012CE RID: 4814
		internal bool bool_1 = true;

		// Token: 0x040012CF RID: 4815
		internal bool bool_2 = true;

		// Token: 0x040012D0 RID: 4816
		internal bool bool_3 = true;

		// Token: 0x040012D1 RID: 4817
		internal bool bool_4 = true;

		// Token: 0x040012D2 RID: 4818
		internal bool bool_5 = true;

		// Token: 0x040012D3 RID: 4819
		internal bool bool_6 = true;

		// Token: 0x040012D4 RID: 4820
		internal bool bool_7 = true;

		// Token: 0x040012D5 RID: 4821
		internal bool bool_8 = true;

		// Token: 0x040012D6 RID: 4822
		internal bool bool_9 = false;

		// Token: 0x040012D7 RID: 4823
		internal bool bool_10 = true;

		// Token: 0x040012D8 RID: 4824
		internal bool bool_11 = false;

		// Token: 0x040012D9 RID: 4825
		internal bool bool_12 = true;

		// Token: 0x040012DA RID: 4826
		internal bool bool_13 = true;

		// Token: 0x040012DB RID: 4827
		internal bool bool_14 = false;

		// Token: 0x040012DC RID: 4828
		internal bool bool_15 = false;

		// Token: 0x040012DD RID: 4829
		internal bool bool_16 = true;

		// Token: 0x040012DE RID: 4830
		internal bool bool_17 = true;

		// Token: 0x040012DF RID: 4831
		internal bool bool_18 = true;

		// Token: 0x040012E0 RID: 4832
		internal bool bool_19 = true;

		// Token: 0x040012E1 RID: 4833
		internal bool bool_20 = false;

		// Token: 0x040012E2 RID: 4834
		private Color color_0 = new Color(0f, 0.5f, 0.75f, 0.33f);

		// Token: 0x040012E3 RID: 4835
		private string string_1 = string.Empty;

		// Token: 0x040012E4 RID: 4836
		internal Texture texture_0;

		// Token: 0x040012E5 RID: 4837
		internal GameObject gameObject_0;

		// Token: 0x040012E6 RID: 4838
		internal RawImage rawImage_0;

		// Token: 0x040012E7 RID: 4839
		internal Texture texture_1;

		// Token: 0x040012E8 RID: 4840
		private bool bool_21 = false;

		// Token: 0x040012E9 RID: 4841
		private bool bool_22 = false;

		// Token: 0x040012EA RID: 4842
		private Color color_1 = new Color(0.1f, 0.1f, 0.1f, 0.5f);

		// Token: 0x040012EB RID: 4843
		private string string_2 = string.Empty;

		// Token: 0x040012EC RID: 4844
		private Texture texture_2;

		// Token: 0x040012ED RID: 4845
		internal GameObject gameObject_1;

		// Token: 0x040012EE RID: 4846
		internal GameObject gameObject_2;

		// Token: 0x040012EF RID: 4847
		internal GameObject gameObject_3;

		// Token: 0x040012F0 RID: 4848
		internal RawImage rawImage_1;

		// Token: 0x040012F1 RID: 4849
		internal Texture texture_3;

		// Token: 0x040012F2 RID: 4850
		private Color color_2 = Color.Lerp(Color.white, Color.blue, 0.5f);

		// Token: 0x040012F3 RID: 4851
		internal float float_0 = 0f;

		// Token: 0x040012F4 RID: 4852
		private Color color_3 = Color.gray;

		// Token: 0x040012F5 RID: 4853
		private Color color_4 = Color.gray / 2f;

		// Token: 0x040012F6 RID: 4854
		private Color color_5 = Color.Lerp(Color.white, Color.green, 0.75f);

		// Token: 0x040012F7 RID: 4855
		private Color color_6 = Color.Lerp(Color.white, Color.cyan, 0.5f);

		// Token: 0x040012F8 RID: 4856
		internal float float_1 = 0f;

		// Token: 0x040012F9 RID: 4857
		private Color color_7 = Color.Lerp(Color.blue, Color.magenta, 0.5f);

		// Token: 0x040012FA RID: 4858
		internal Color color_8 = Color.Lerp(Color.blue, Color.magenta, 0.5f);

		// Token: 0x040012FB RID: 4859
		internal Color color_9 = Color.Lerp(Color.blue, Color.magenta, 0.5f);

		// Token: 0x040012FC RID: 4860
		private Color color_10 = Color.green;

		// Token: 0x040012FD RID: 4861
		private Color color_11 = new Color(0.1f, 0.05f, 0.2f);

		// Token: 0x040012FE RID: 4862
		private Color color_12 = new Color(0.2f, 0.05f, 0.25f);

		// Token: 0x040012FF RID: 4863
		private Color color_13 = new Color(0.05f, 0.05f, 0.05f);

		// Token: 0x04001300 RID: 4864
		internal Color color_14 = new Color(0.25f, 0.5f, 1f);

		// Token: 0x04001301 RID: 4865
		internal Color color_15 = new Color(1f, 0f, 0f);

		// Token: 0x04001302 RID: 4866
		internal Color color_16 = new Color(1f, 1f, 0f);

		// Token: 0x04001303 RID: 4867
		internal Color color_17 = new Color(0f, 1f, 0f);

		// Token: 0x04001304 RID: 4868
		internal ColorBlock colorBlock_0;

		// Token: 0x04001305 RID: 4869
		internal GameObject gameObject_4;

		// Token: 0x04001306 RID: 4870
		internal GameObject gameObject_5;

		// Token: 0x04001307 RID: 4871
		internal GameObject gameObject_6;

		// Token: 0x04001308 RID: 4872
		internal GameObject gameObject_7;

		// Token: 0x04001309 RID: 4873
		internal Texture texture_4;

		// Token: 0x0400130A RID: 4874
		internal GameObject gameObject_8;

		// Token: 0x0400130B RID: 4875
		internal GClass31 gclass31_0;

		// Token: 0x0400130C RID: 4876
		internal GClass31 gclass31_1;

		// Token: 0x0400130D RID: 4877
		internal GClass31 gclass31_2;

		// Token: 0x0400130E RID: 4878
		internal GClass31 gclass31_3;

		// Token: 0x0400130F RID: 4879
		private List<GClass161.Struct28> list_0 = new List<GClass161.Struct28>();

		// Token: 0x04001310 RID: 4880
		private List<GClass161.Struct24> list_1 = new List<GClass161.Struct24>();

		// Token: 0x04001311 RID: 4881
		private List<GClass161.Struct25> list_2 = new List<GClass161.Struct25>();

		// Token: 0x04001312 RID: 4882
		private List<GClass161.Struct29> list_3 = new List<GClass161.Struct29>();

		// Token: 0x04001313 RID: 4883
		private List<GClass161.Struct26> list_4 = new List<GClass161.Struct26>();

		// Token: 0x04001314 RID: 4884
		private List<GClass161.Struct30> list_5 = new List<GClass161.Struct30>();

		// Token: 0x04001315 RID: 4885
		private List<GClass161.Struct27> list_6 = new List<GClass161.Struct27>();

		// Token: 0x04001316 RID: 4886
		internal List<GClass161.Struct31> list_7 = new List<GClass161.Struct31>
		{
			new GClass161.Struct31
			{
				string_0 = "Abyss",
				string_1 = string.Empty,
				color_0 = new Color(0.05f, 0.05f, 0.05f, 0.66f),
				bool_0 = false,
				bool_1 = true,
				string_2 = string.Empty,
				texture_0 = GClass153.GClass88.texture2D_0,
				color_1 = new Color(1f, 1f, 1f, 1f),
				color_2 = new Color(0.75f, 0.1f, 0.1f),
				color_3 = new Color(0.1f, 0.1f, 0.1f),
				color_4 = new Color(0f, 0f, 0f),
				color_5 = new Color(0.25f, 0.1f, 0.1f),
				color_6 = new Color(1f, 0f, 0f),
				color_7 = new Color(0.5f, 0f, 0f),
				color_8 = new Color(1f, 0f, 0f),
				color_9 = new Color(0.05f, 0.05f, 0.05f),
				color_10 = new Color(0.1f, 0.1f, 0.1f),
				color_11 = new Color(0.05f, 0.05f, 0.05f)
			}
		};

		// Token: 0x04001317 RID: 4887
		internal string string_3 = "Abyss";

		// Token: 0x020002CC RID: 716
		private struct Struct24
		{
			// Token: 0x060021CE RID: 8654 RVA: 0x000ACE8C File Offset: 0x000AB08C
			public Struct24(Selectable selectable_1, ColorBlock colorBlock_1)
			{
				this.selectable_0 = selectable_1;
				this.colorBlock_0 = colorBlock_1;
			}

			// Token: 0x04001318 RID: 4888
			public Selectable selectable_0;

			// Token: 0x04001319 RID: 4889
			public ColorBlock colorBlock_0;
		}

		// Token: 0x020002CD RID: 717
		private struct Struct25
		{
			// Token: 0x060021CF RID: 8655 RVA: 0x000ACEA8 File Offset: 0x000AB0A8
			public Struct25(Image image_1, Color color_1)
			{
				this.image_0 = image_1;
				this.color_0 = color_1;
			}

			// Token: 0x0400131A RID: 4890
			public Image image_0;

			// Token: 0x0400131B RID: 4891
			public Color color_0;
		}

		// Token: 0x020002CE RID: 718
		private struct Struct26
		{
			// Token: 0x060021D0 RID: 8656 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
			public Struct26(Text text_1, Color color_1)
			{
				this.text_0 = text_1;
				this.color_0 = color_1;
			}

			// Token: 0x0400131C RID: 4892
			public Text text_0;

			// Token: 0x0400131D RID: 4893
			public Color color_0;
		}

		// Token: 0x020002CF RID: 719
		private struct Struct27
		{
			// Token: 0x060021D1 RID: 8657 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
			public Struct27(TextMeshProUGUI textMeshProUGUI_1, Color color_1)
			{
				this.textMeshProUGUI_0 = textMeshProUGUI_1;
				this.color_0 = color_1;
			}

			// Token: 0x0400131E RID: 4894
			public TextMeshProUGUI textMeshProUGUI_0;

			// Token: 0x0400131F RID: 4895
			public Color color_0;
		}

		// Token: 0x020002D0 RID: 720
		private struct Struct28
		{
			// Token: 0x060021D2 RID: 8658 RVA: 0x000ACEFC File Offset: 0x000AB0FC
			public Struct28(GameObject gameObject_1, List<Selectable> list_1)
			{
				this.gameObject_0 = gameObject_1;
				this.list_0 = list_1;
			}

			// Token: 0x04001320 RID: 4896
			public GameObject gameObject_0;

			// Token: 0x04001321 RID: 4897
			public List<Selectable> list_0;
		}

		// Token: 0x020002D1 RID: 721
		private struct Struct29
		{
			// Token: 0x060021D3 RID: 8659 RVA: 0x000ACF18 File Offset: 0x000AB118
			public Struct29(GameObject gameObject_1, List<Text> list_1)
			{
				this.gameObject_0 = gameObject_1;
				this.list_0 = list_1;
			}

			// Token: 0x04001322 RID: 4898
			public GameObject gameObject_0;

			// Token: 0x04001323 RID: 4899
			public List<Text> list_0;
		}

		// Token: 0x020002D2 RID: 722
		private struct Struct30
		{
			// Token: 0x060021D4 RID: 8660 RVA: 0x000ACF34 File Offset: 0x000AB134
			public Struct30(GameObject gameObject_1, List<TextMeshProUGUI> list_1)
			{
				this.gameObject_0 = gameObject_1;
				this.list_0 = list_1;
			}

			// Token: 0x04001324 RID: 4900
			public GameObject gameObject_0;

			// Token: 0x04001325 RID: 4901
			public List<TextMeshProUGUI> list_0;
		}

		// Token: 0x020002D3 RID: 723
		internal struct Struct31
		{
			// Token: 0x04001326 RID: 4902
			public string string_0;

			// Token: 0x04001327 RID: 4903
			public string string_1;

			// Token: 0x04001328 RID: 4904
			public Color color_0;

			// Token: 0x04001329 RID: 4905
			public bool bool_0;

			// Token: 0x0400132A RID: 4906
			public bool bool_1;

			// Token: 0x0400132B RID: 4907
			public string string_2;

			// Token: 0x0400132C RID: 4908
			public Texture texture_0;

			// Token: 0x0400132D RID: 4909
			public Color color_1;

			// Token: 0x0400132E RID: 4910
			public Color color_2;

			// Token: 0x0400132F RID: 4911
			public Color color_3;

			// Token: 0x04001330 RID: 4912
			public Color color_4;

			// Token: 0x04001331 RID: 4913
			public Color color_5;

			// Token: 0x04001332 RID: 4914
			public Color color_6;

			// Token: 0x04001333 RID: 4915
			public Color color_7;

			// Token: 0x04001334 RID: 4916
			public Color color_8;

			// Token: 0x04001335 RID: 4917
			public Color color_9;

			// Token: 0x04001336 RID: 4918
			public Color color_10;

			// Token: 0x04001337 RID: 4919
			public Color color_11;
		}

		// Token: 0x020002D4 RID: 724
		[CompilerGenerated]
		private sealed class Class175
		{
			// Token: 0x060021D5 RID: 8661 RVA: 0x000ACF50 File Offset: 0x000AB150
			internal void method_0()
			{
				GameObject gameObject = this.transform_0.Find("MenuSettingsPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(false);
				}
			}

			// Token: 0x060021D7 RID: 8663 RVA: 0x000ACF84 File Offset: 0x000AB184
			internal void method_1()
			{
				Action<string, List<KeyCode>, Text> action_ = new Action<string, List<KeyCode>, Text>(this.gclass161_0.method_12);
				GClass84.smethod_946("New Background Texture", this.gameObject_0.GetComponentInChildren<Text>().text, 0, false, "Enter", action_, null, "Enter path or link...", true, null, false);
			}

			// Token: 0x060021D8 RID: 8664 RVA: 0x000ACFD4 File Offset: 0x000AB1D4
			internal void method_2()
			{
				this.gclass161_0.method_43(this.gameObject_0.GetComponentInChildren<Text>().text, false);
			}

			// Token: 0x060021D9 RID: 8665 RVA: 0x000AD000 File Offset: 0x000AB200
			internal void method_3()
			{
				GClass31 gclass31_ = this.gclass161_0.gclass31_0;
				if ((gclass31_ != null) ? gclass31_.method_3() : null)
				{
					this.gclass161_0.gclass31_0.method_22(this.gclass161_0.Color_0.r, false);
				}
				GClass31 gclass31_2 = this.gclass161_0.gclass31_1;
				if ((gclass31_2 != null) ? gclass31_2.method_3() : null)
				{
					this.gclass161_0.gclass31_1.method_22(this.gclass161_0.Color_0.g, false);
				}
				GClass31 gclass31_3 = this.gclass161_0.gclass31_2;
				if ((gclass31_3 != null) ? gclass31_3.method_3() : null)
				{
					this.gclass161_0.gclass31_2.method_22(this.gclass161_0.Color_0.b, false);
				}
				GClass31 gclass31_4 = this.gclass161_0.gclass31_3;
				if ((gclass31_4 != null) ? gclass31_4.method_3() : null)
				{
					this.gclass161_0.gclass31_3.method_22(this.gclass161_0.Color_0.a, false);
				}
				GameObject gameObject = this.transform_0.Find("MenuSettingsPopup").gameObject;
				if (gameObject)
				{
					gameObject.SetActive(true);
				}
			}

			// Token: 0x060021DA RID: 8666 RVA: 0x000AD130 File Offset: 0x000AB330
			internal void method_4()
			{
				this.gameObject_0.GetComponentInChildren<Text>().text = "Enter path or link...";
				this.gclass161_0.method_43(string.Empty, false);
			}

			// Token: 0x04001338 RID: 4920
			public GClass161 gclass161_0;

			// Token: 0x04001339 RID: 4921
			public Transform transform_0;

			// Token: 0x0400133A RID: 4922
			public GameObject gameObject_0;
		}

		// Token: 0x020002D5 RID: 725
		[CompilerGenerated]
		private sealed class Class176
		{
			// Token: 0x060021DC RID: 8668 RVA: 0x000AD164 File Offset: 0x000AB364
			internal void method_0()
			{
				InputField inputField = this.inputField_0;
				InputField inputField2 = this.inputField_0;
				inputField.SetText(inputField2.text += Clipboard.GetText(), true);
			}

			// Token: 0x0400133B RID: 4923
			public InputField inputField_0;
		}
	}
}
