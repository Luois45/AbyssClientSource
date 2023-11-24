using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns241;
using ns425;
using ns449;
using ns466;
using UnityEngine;
using UnityEngine.UI;

namespace ns452
{
	// Token: 0x0200028F RID: 655
	public class GClass156 : GClass130
	{
		// Token: 0x06001E09 RID: 7689 RVA: 0x00094578 File Offset: 0x00092778
		internal void method_2(byte byte_0, byte byte_1, byte byte_2, byte byte_3 = 0)
		{
			this.method_31(byte_0, byte_1, byte_2, byte_3);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00094594 File Offset: 0x00092794
		internal void method_3(int int_4, float float_8)
		{
			float num = this.float_6;
			float num2 = this.float_7;
			switch (int_4)
			{
			case 0:
				this.float_7 -= float_8;
				this.method_161(this.float_6, float_8);
				break;
			case 1:
				this.method_161(this.float_6, float_8);
				break;
			case 2:
				this.float_6 -= float_8;
				this.method_19(this.float_7, float_8);
				break;
			case 3:
				this.method_19(this.float_7, float_8);
				break;
			}
			this.float_6 = num;
			this.float_7 = num2;
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00094630 File Offset: 0x00092830
		private bool method_4(GameObject gameObject_1)
		{
			bool result;
			if (!this.list_3.Contains(gameObject_1))
			{
				this.method_33(gameObject_1);
				this.method_55(gameObject_1);
				this.method_219(gameObject_1);
				this.list_3.Add(gameObject_1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0009467C File Offset: 0x0009287C
		internal GameObject method_5(float float_8, float float_9, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_1)
		{
			this.method_61(float_8 - 1f, float_9 - 1f);
			return this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, enum10_0);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x000946CC File Offset: 0x000928CC
		internal void method_6(string string_1, ref float float_8, ref float float_9)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			bool flag = false;
			float_8 = 0f;
			float_9 = 0f;
			string text = GClass84.smethod_1428(string_1, 1);
			while (text != string.Empty)
			{
				if (text == " ")
				{
					float_8 += (float)this.int_3;
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
					flag = false;
				}
				else
				{
					if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
					{
						if (flag)
						{
							float_8 += (float)this.int_2;
						}
						float_8 += (float)num3 * this.float_0 * this.method_151();
						float_9 = GClass84.smethod_359(float_9, (float)num4 * this.float_1 * this.method_105());
						flag = true;
					}
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
				}
				text = GClass84.smethod_1428(string_1, 1);
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000947A0 File Offset: 0x000929A0
		internal void method_7(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_213(list_6, int_4, int_5);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000947B8 File Offset: 0x000929B8
		private bool method_8(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_4(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x000947EC File Offset: 0x000929EC
		internal void method_9(List<Color> list_6)
		{
			this.method_101(list_6);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00094800 File Offset: 0x00092A00
		internal void method_10(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61(0f, (float)(i * int_4));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_4, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000948A0 File Offset: 0x00092AA0
		internal bool method_11(GameObject gameObject_1, Texture texture_0, Color color_1)
		{
			RawImage component = gameObject_1.GetComponent<RawImage>();
			bool result;
			if (component)
			{
				component.texture = texture_0;
				component.color = color_1;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x000948D4 File Offset: 0x00092AD4
		internal void method_12(float float_8, float float_9)
		{
			this.float_6 = float_8;
			this.float_7 = float_9;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x000948F0 File Offset: 0x00092AF0
		internal GameObject method_13(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4, int int_5, int int_6)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString(),
				"_",
				int_5.ToString(),
				"_",
				int_6.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				int num = (int_6 + 1) / 2 + 1;
				int num2 = int_6 - 1;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i] + int_4 - num), (float)(list_7[i] + int_5 - num), list_8[i] + num2, list_9[i] + num2, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00094D38 File Offset: 0x00092F38
		internal void method_14(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_231(list_6, int_4);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00094E30 File Offset: 0x00093030
		private bool method_15(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_219(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00094E64 File Offset: 0x00093064
		internal void method_16(float float_8, float float_9)
		{
			this.method_172(float_8, float_9);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00094E7C File Offset: 0x0009307C
		internal void method_17()
		{
			this.gameObject_0 = new GameObject("UICanvas");
			Object.DontDestroyOnLoad(this.gameObject_0);
			this.gameObject_0.AddComponent<Canvas>().renderMode = 0;
			this.gameObject_0.transform.position = new Vector3(0f, 0f, 0f);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00094EDC File Offset: 0x000930DC
		internal void method_18(List<Color> list_6, int int_4)
		{
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				this.method_61((float)(i + int_4), 0f);
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00094F48 File Offset: 0x00093148
		internal void method_19(float float_8, float float_9)
		{
			this.method_16(float_8, float_9);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00094F60 File Offset: 0x00093160
		internal void method_20(List<Color> list_6)
		{
			int count = list_6.Count;
			this.method_61(0f, 0f);
			for (int i = 0; i < count; i++)
			{
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00094FCC File Offset: 0x000931CC
		internal GameObject method_21(int int_4, int int_5, int int_6, int int_7, GClass169 gclass169_0, Vector3 vector3_0, Quaternion quaternion_0, int int_8 = 0, bool bool_0 = false)
		{
			if (int_8 <= 0)
			{
				int_8 = 60;
			}
			if (bool_0)
			{
				this.method_232(false, true);
			}
			string string_ = string.Concat(new string[]
			{
				"Temp",
				"Portal",
				"_",
				int_4.ToString(),
				"_",
				int_5.ToString(),
				"_",
				int_6.ToString(),
				"_",
				int_7.ToString()
			});
			GameObject gameObject = this.method_196(string_, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				RawImage[] array = gameObject.GetComponentsInChildren<RawImage>();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					array[i].color = this.color_0;
				}
				Camera[] array2 = gameObject.GetComponentsInChildren<Camera>();
				for (int j = array2.Length - 1; j >= 0; j--)
				{
					array2[j].transform.position = vector3_0;
					array2[j].transform.rotation = quaternion_0;
					array2[j].fieldOfView = (float)int_8;
					array2[j].Render();
				}
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				string string_2 = string.Concat(new string[]
				{
					"Temp",
					"Camera",
					"_",
					int_6.ToString(),
					"_",
					int_7.ToString()
				});
				GameObject gameObject2 = this.method_75(string_2, GClass156.Enum10.const_3);
				gameObject2.transform.position = vector3_0;
				gameObject2.transform.rotation = quaternion_0;
				RenderTexture renderTexture = new RenderTexture(int_6, int_7, 24, 0);
				this.list_5.Add(new GClass156.Struct22(renderTexture, gameObject2));
				Camera camera = gameObject2.AddComponent<Camera>();
				camera.enabled = false;
				if (int_6 != int_7)
				{
					Rect rect = camera.rect;
					rect.x = 0f;
					rect.y = 0f;
					if (int_6 > int_7)
					{
						rect.width = 1f;
						rect.height = (float)int_7 / (float)int_6;
					}
					else if (int_6 < int_7)
					{
						rect.width = (float)int_6 / (float)int_7;
						rect.height = 1f;
					}
					camera.rect = rect;
				}
				camera.fieldOfView = (float)int_8;
				camera.targetTexture = renderTexture;
				camera.nearClipPlane = 0.01f;
				camera.Render();
				list.Add(gameObject2);
				this.method_61((float)int_4, (float)int_5);
				list.Add(this.method_227(renderTexture, (float)int_6, (float)int_7, 0f, 0f, (float)renderTexture.width, (float)renderTexture.height, GClass156.Enum10.const_3));
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject3 = this.method_75(string_, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject3);
					list.Clear();
					result = gameObject3;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000952C8 File Offset: 0x000934C8
		internal float method_22()
		{
			return this.float_6 - this.float_4 / 2f;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000952EC File Offset: 0x000934EC
		internal void method_23(Texture texture_0, float float_8, float float_9, float float_10)
		{
			this.method_35(texture_0, float_8, float_9, float_10);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00095308 File Offset: 0x00093508
		internal void method_24(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_93(list_6, int_4, int_5);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00095320 File Offset: 0x00093520
		internal void method_25(float float_8, float float_9)
		{
			this.method_199(float_8, float_9);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00095338 File Offset: 0x00093538
		internal void method_26()
		{
			this.method_200();
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0009534C File Offset: 0x0009354C
		internal static Color smethod_0(byte byte_0, byte byte_1, byte byte_2, byte byte_3 = 0)
		{
			return new Color((float)byte_0 / 255f, (float)byte_1 / 255f, (float)byte_2 / 255f, GClass84.smethod_108<float>(byte_3 == 0, 1f, (float)byte_3 / 255f));
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00095390 File Offset: 0x00093590
		internal void method_27(Texture texture_0, float float_8, float float_9)
		{
			this.method_91(texture_0, float_8, float_9);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x000953A8 File Offset: 0x000935A8
		internal void method_28(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_198(list_6, int_4, int_5);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000953C0 File Offset: 0x000935C0
		internal GameObject method_29(Texture texture_0, float float_8, float float_9)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				string string_ = string.Concat(new string[]
				{
					"Temp",
					"Tile",
					"Stretched",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString()
				});
				List<GameObject> list = new List<GameObject>();
				float num = this.float_6;
				float num2 = this.float_7;
				if (float_8 == (float)texture_0.width)
				{
					if (float_9 == (float)texture_0.height)
					{
						list.Add(this.method_174(texture_0, float_8, float_9, 0f, 0f, (float)texture_0.width, (float)texture_0.height));
					}
					else if (float_9 < (float)texture_0.height)
					{
						float num3 = float_9 / 2f;
						list.Add(this.method_174(texture_0, float_8, num3, 0f, 0f, float_8, num3));
						this.method_61(num, num2 + num3);
						list.Add(this.method_174(texture_0, float_8, num3, 0f, (float)texture_0.height - num3, float_8, num3));
					}
					else
					{
						float num4 = (float)(texture_0.height / 2);
						list.Add(this.method_174(texture_0, num4, float_9, 0f, 0f, float_8, num4));
						this.method_61(num, num2 + num4);
						list.Add(this.method_174(texture_0, float_8, float_9 - (float)texture_0.height, 0f, num4, float_8, 0f));
						this.method_61(num, num2 + num4 + (float_9 - (float)texture_0.height));
						list.Add(this.method_174(texture_0, float_8, num4, 0f, num4, float_8, num4));
					}
				}
				else if (float_9 == (float)texture_0.height)
				{
					if (float_8 < (float)texture_0.width)
					{
						float num5 = float_8 / 2f;
						list.Add(this.method_174(texture_0, num5, float_9, 0f, 0f, num5, float_9));
						this.method_61(num + num5, num2);
						list.Add(this.method_174(texture_0, num5, float_9, (float)texture_0.width - num5, 0f, num5, float_9));
					}
					else
					{
						float num6 = (float)(texture_0.width / 2);
						list.Add(this.method_174(texture_0, num6, float_9, 0f, 0f, num6, float_9));
						this.method_61(num + num6, num2);
						list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, float_9, num6, 0f, 0f, float_9));
						this.method_61(num + num6 + (float_8 - (float)texture_0.width), num2);
						list.Add(this.method_174(texture_0, num6, float_9, num6, 0f, num6, float_9));
					}
				}
				else if (float_8 < (float)texture_0.width)
				{
					if (float_9 < (float)texture_0.height)
					{
						float num7 = float_8 / 2f;
						float num8 = float_9 / 2f;
						list.Add(this.method_174(texture_0, num7, num8, 0f, 0f, num7, num8));
						this.method_61(num + num7, num2);
						list.Add(this.method_174(texture_0, num7, num8, (float)texture_0.width - num7, 0f, num7, num8));
						this.method_61(num, num2 + num8);
						list.Add(this.method_174(texture_0, num7, num8, 0f, (float)texture_0.height - num8, num7, num8));
						this.method_61(num + num7, num2 + num8);
						list.Add(this.method_174(texture_0, num7, num8, (float)texture_0.width - num7, (float)texture_0.height - num8, num7, num8));
					}
					else
					{
						float num9 = float_8 / 2f;
						float num10 = (float)(texture_0.height / 2);
						list.Add(this.method_174(texture_0, num9, num10, 0f, 0f, num9, num10));
						this.method_61(num + num9, num2);
						list.Add(this.method_174(texture_0, num9, num10, (float)texture_0.width - num9, 0f, num9, num10));
						this.method_61(num, num2 + num10);
						list.Add(this.method_174(texture_0, num9, num10, 0f, num10, num9, 0f));
						this.method_61(num + num9, num2 + num10);
						list.Add(this.method_174(texture_0, num9, num10, (float)texture_0.width - num9, num10, num9, 0f));
						this.method_61(num, num2 + num10);
						list.Add(this.method_174(texture_0, num9, num10, 0f, num10, num9, num10));
						this.method_61(num + num9, num2 + num10);
						list.Add(this.method_174(texture_0, num9, num10, (float)texture_0.width - num9, num10, num9, num10));
					}
				}
				else if (float_9 < (float)texture_0.height)
				{
					float num11 = (float)(texture_0.width / 2);
					float num12 = float_9 / 2f;
					list.Add(this.method_174(texture_0, num11, num12, 0f, 0f, num11, num12));
					this.method_61(num + num11, num2);
					list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, num12, num11, 0f, 0f, num12));
					this.method_61(num + num11 + (float_8 - (float)texture_0.width), num2);
					list.Add(this.method_174(texture_0, num11, num12, num11, 0f, num11, num12));
					this.method_61(num, num2 + num12);
					list.Add(this.method_174(texture_0, num11, num12, 0f, (float)texture_0.height - num12, num11, num12));
					this.method_61(num + num11, num2 + num12);
					list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, num12, num11, (float)texture_0.height - num12, 0f, num12));
					this.method_61(num + num11 + (float_8 - (float)texture_0.width), num2 + num12);
					list.Add(this.method_174(texture_0, num11, num12, num11, (float)texture_0.height - num12, num11, num12));
				}
				else
				{
					float num13 = (float)(texture_0.width / 2);
					float num14 = (float)(texture_0.height / 2);
					list.Add(this.method_174(texture_0, num13, num14, 0f, 0f, num13, num14));
					this.method_61(num + num13, num2);
					list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, num14, 0f, 0f, 0f, num14));
					this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2);
					list.Add(this.method_174(texture_0, num13 + (float_8 - (float)texture_0.width), num14, 0f, 0f, num13, num14));
					this.method_61(num, num2 + num14);
					list.Add(this.method_174(texture_0, num13, float_9 - (float)texture_0.height, 0f, 0f, num13, 0f));
					this.method_61(num + num13, num2 + num14);
					list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, float_9 - (float)texture_0.height, 0f, 0f, 0f, 0f));
					this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2 + num14);
					list.Add(this.method_174(texture_0, num13, float_9 - (float)texture_0.height, 0f, 0f, num13, 0f));
					this.method_61(num, num2 + num14 + (float_9 - (float)texture_0.height));
					list.Add(this.method_174(texture_0, num13, num14, 0f, 0f, num13, num14));
					this.method_61(num + num13, num2 + num14 + (float_9 - (float)texture_0.height));
					list.Add(this.method_174(texture_0, float_8 - (float)texture_0.width, num14, 0f, 0f, 0f, num14));
					this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2 + num14 + (float_9 - (float)texture_0.height));
					list.Add(this.method_174(texture_0, num13, num14, 0f, 0f, num13, num14));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject = this.method_168(string_);
					GClass84.smethod_1477(list, gameObject);
					list.Clear();
					result = gameObject;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00095C5C File Offset: 0x00093E5C
		internal void method_30(string string_1, float float_8, float float_9, GClass84.GEnum46 genum46_0)
		{
			this.method_94(string_1, float_8, float_9, genum46_0);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00095C78 File Offset: 0x00093E78
		internal void method_31(byte byte_0, byte byte_1, byte byte_2, byte byte_3)
		{
			this.method_103(byte_0, byte_1, byte_2, byte_3);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00095C94 File Offset: 0x00093E94
		private GameObject method_32(string string_1)
		{
			GClass156.Class165 @class = new GClass156.Class165();
			@class.string_0 = string_1;
			return this.list_3.Find(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00095CC8 File Offset: 0x00093EC8
		private bool method_33(GameObject gameObject_1)
		{
			bool result;
			if (!this.list_0.Contains(gameObject_1))
			{
				this.list_0.Add(gameObject_1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00095CFC File Offset: 0x00093EFC
		internal void method_34(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_224(list_6, int_4, int_5);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00095D14 File Offset: 0x00093F14
		internal void method_35(Texture texture_0, float float_8, float float_9, float float_10)
		{
			this.method_237(texture_0, float_8, float_9, float_10);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00095D30 File Offset: 0x00093F30
		private void method_36()
		{
			this.method_108();
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00095D44 File Offset: 0x00093F44
		internal void method_37(GClass169 gclass169_0, bool bool_0, bool bool_1, float float_8)
		{
			this.method_214(gclass169_0, bool_0, bool_1, float_8);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00095D60 File Offset: 0x00093F60
		internal void method_38(List<Color> list_6, int int_4)
		{
			this.method_178(list_6, int_4);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00095D78 File Offset: 0x00093F78
		internal void method_39(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			this.method_169(list_6, int_4, int_5, int_6);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00095D94 File Offset: 0x00093F94
		internal void method_40(float float_8, float float_9)
		{
			this.float_4 = float_8;
			this.float_5 = float_9;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00095DB0 File Offset: 0x00093FB0
		internal void method_41(List<Color> list_6, int int_4)
		{
			this.method_54(list_6, int_4);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00095DC8 File Offset: 0x00093FC8
		private bool method_42(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_33(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00095DFC File Offset: 0x00093FFC
		internal GameObject method_43(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4, int int_5, int int_6)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString(),
				"_",
				int_5.ToString(),
				"_",
				int_6.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			int num = (int_6 + 1) / 2 + 1;
			int num2 = int_6 - 1;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i] + int_4 - num), (float)(list_7[i] + int_5 - num), list_8[i] + num2, list_9[i] + num2));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00096204 File Offset: 0x00094404
		internal void method_44()
		{
			this.method_126();
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00096218 File Offset: 0x00094418
		internal GameObject method_45(float float_8, float float_9, int int_4, int int_5)
		{
			this.method_61(float_8 - 1f, float_9 - 1f);
			return this.method_174(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_5, 0f, 0f, 1f, 1f);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00096260 File Offset: 0x00094460
		internal void method_46(Texture texture_0, float float_8)
		{
			this.method_144(texture_0, float_8);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00096278 File Offset: 0x00094478
		internal void method_47(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j + int_4), (float)(i + int_5));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0009631C File Offset: 0x0009451C
		internal void method_48(float float_8, float float_9)
		{
			this.method_152(float_8, float_9);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00096334 File Offset: 0x00094534
		internal GameObject method_49(GClass84.GStruct169 gstruct169_0, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Offset",
				"Thickness",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")",
				"_",
				int_4.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < gstruct169_0.list_0.Count; i++)
			{
				list.Add(this.method_45((float)(gstruct169_0.list_0[i].int_0 + gstruct163_0.int_0 - (int_4 + 1) / 2 + 1), (float)(gstruct169_0.list_0[i].int_1 + gstruct163_0.int_0 - (int_4 + 1) / 2 + 1), gstruct169_0.list_1[i].int_0 + int_4 - 1, gstruct169_0.list_1[i].int_1 + int_4 - 1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00096678 File Offset: 0x00094878
		internal GameObject method_50(string string_1, bool bool_0 = false)
		{
			GameObject result;
			if (this.float_0 == 0f || this.float_1 == 0f)
			{
				result = null;
			}
			else
			{
				string string_2 = string.Concat(new string[]
				{
					"Temp",
					"Text",
					"Clipped",
					"_",
					string_1,
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					this.float_0.ToString(),
					"_",
					this.float_1.ToString()
				});
				GameObject gameObject = this.method_196(string_2, GClass156.Enum10.const_2);
				if (gameObject)
				{
					gameObject.tag = "Untagged";
					RawImage[] array = gameObject.GetComponentsInChildren<RawImage>();
					for (int i = array.Length - 1; i >= 0; i--)
					{
						array[i].color = this.color_0;
					}
					result = gameObject;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					bool flag = false;
					float num6 = this.float_6;
					float float_ = this.float_7;
					List<GameObject> list = new List<GameObject>();
					bool flag2 = false;
					bool flag3 = false;
					string text = GClass84.smethod_1428(string_1, 1);
					while (text != string.Empty)
					{
						if (bool_0 && !flag2 && text == "&")
						{
							flag2 = true;
							flag3 = true;
							text = "_";
						}
						if (text == " ")
						{
							num5 += (int)((float)this.int_3 * this.float_0);
							string_1 = GClass84.smethod_1204(string_1, 1, -1);
							flag = false;
							flag2 = false;
						}
						else
						{
							if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
							{
								if (flag && (!flag2 || flag3))
								{
									num5 += this.int_2;
								}
								this.method_61(num6 + (float)num5, float_);
								list.Add(this.method_122(GClass153.GClass87.texture2D_6, (float)num3 * this.float_0, (float)num4 * this.float_1, (float)num, (float)num2, (float)num3, (float)num4, GClass156.Enum10.const_3));
								if (!flag3)
								{
									num5 += (int)((float)num3 * this.float_0 * this.method_151());
								}
								flag = true;
							}
							if (!flag3)
							{
								flag2 = false;
							}
							string_1 = GClass84.smethod_1204(string_1, 1, -1);
							flag3 = false;
						}
						text = GClass84.smethod_1428(string_1, 1);
					}
					GClass84.smethod_1233<GameObject>(list);
					if (list.Count > 0)
					{
						GameObject gameObject2 = this.method_75(string_2, GClass156.Enum10.const_2);
						GClass84.smethod_1477(list, gameObject2);
						list.Clear();
						result = gameObject2;
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00096924 File Offset: 0x00094B24
		internal float method_51()
		{
			return this.float_5 / 2f - this.float_7;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00096948 File Offset: 0x00094B48
		private bool method_52(List<GameObject> list_6, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_0)
		{
			bool result;
			switch (enum10_0)
			{
			case GClass156.Enum10.const_0:
				result = this.method_42(list_6);
				break;
			case GClass156.Enum10.const_1:
				result = this.method_207(list_6);
				break;
			case GClass156.Enum10.const_2:
				result = this.method_135(list_6);
				break;
			case GClass156.Enum10.const_3:
				result = this.method_8(list_6);
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0009699C File Offset: 0x00094B9C
		internal GameObject method_53(float float_8, float float_9, int int_4, int int_5)
		{
			this.method_61(float_8 - (float)((int_4 + 1) / 2), float_9 - (float)((int_5 + 1) / 2));
			return this.method_174(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_5, 0f, 0f, 1f, 1f);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000969E8 File Offset: 0x00094BE8
		internal void method_54(List<Color> list_6, int int_4)
		{
			int count = list_6.Count;
			this.method_61((float)int_4, 0f);
			for (int i = 0; i < count; i++)
			{
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00096A50 File Offset: 0x00094C50
		private bool method_55(GameObject gameObject_1)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				if (this.list_1[i] == gameObject_1)
				{
					this.list_1.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00096A9C File Offset: 0x00094C9C
		private GameObject method_56(GameObject gameObject_1)
		{
			GameObject result;
			if (!gameObject_1)
			{
				result = null;
			}
			else
			{
				gameObject_1.transform.SetParent(this.gameObject_0.transform, false);
				result = gameObject_1;
			}
			return result;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00096AD4 File Offset: 0x00094CD4
		internal GameObject method_57(List<GClass84.GStruct163> list_6, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < list_6.Count; i++)
			{
				list.Add(this.method_65((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_1)));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00096C8C File Offset: 0x00094E8C
		internal void method_58(float float_8, float float_9, float float_10, float float_11)
		{
			this.method_137(float_8, float_9, float_10, float_11);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00096CA8 File Offset: 0x00094EA8
		internal GameObject method_59(List<GClass84.GStruct163> list_6, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_6.Count; i++)
				{
					list.Add(this.method_125((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_1), int_4, int_4, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00096EA8 File Offset: 0x000950A8
		internal void method_60(List<Color> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			this.method_61((float)int_4, 0f);
			for (int i = 0; i < count; i++)
			{
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00096F0C File Offset: 0x0009510C
		internal void method_61(float float_8, float float_9)
		{
			this.method_185(float_8, float_9);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00096F24 File Offset: 0x00095124
		internal GameObject method_62(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_0), list_7[i].int_0, list_7[i].int_1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000971D0 File Offset: 0x000953D0
		internal GameObject method_63(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)list_6[i], (float)list_7[i], list_8[i], list_9[i]));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00097558 File Offset: 0x00095758
		internal void method_64()
		{
			if (!this.gameObject_0)
			{
				this.method_44();
			}
			if (this.list_1.Count > 0)
			{
				for (int i = this.list_1.Count - 1; i >= 0; i--)
				{
					if (this.list_1[i])
					{
						this.list_1[i].tag = "Finish";
					}
				}
			}
			if (this.list_2.Count > 0)
			{
				for (int j = this.list_2.Count - 1; j >= 0; j--)
				{
					if (this.list_2[j])
					{
						this.list_2[j].tag = "Finish";
					}
				}
			}
			if (this.gameObject_0)
			{
				this.int_0 = Screen.width;
				this.int_1 = Screen.height;
				this.method_76((float)this.int_0, (float)this.int_1);
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00097664 File Offset: 0x00095864
		internal GameObject method_65(float float_8, float float_9)
		{
			this.method_61(float_8 - 1f, float_9 - 1f);
			return this.method_174(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000976B0 File Offset: 0x000958B0
		internal GameObject method_66(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			int num9 = (int_4 + 1) / 2 + 1;
			int num10 = int_4 - 1;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i].int_0 - num9), (float)(list_6[i].int_1 - num9), list_7[i].int_0 + num10, list_7[i].int_1 + num10));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00097938 File Offset: 0x00095B38
		internal void method_67(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_173(list_6, int_4, int_5);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00097950 File Offset: 0x00095B50
		internal bool method_68(GameObject gameObject_1, Texture texture_0, Color color_1)
		{
			RawImage componentInChildren = gameObject_1.GetComponentInChildren<RawImage>();
			bool result;
			if (!componentInChildren)
			{
				result = false;
			}
			else if (componentInChildren.texture == texture_0 && componentInChildren.color == color_1)
			{
				result = true;
			}
			else
			{
				bool flag = false;
				RawImage[] array = gameObject_1.GetComponentsInChildren<RawImage>();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					array[i].texture = texture_0;
					array[i].color = color_1;
					flag = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000979DC File Offset: 0x00095BDC
		internal GameObject method_69(GClass84.GStruct169 gstruct169_0, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Offset",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < gstruct169_0.list_0.Count; i++)
				{
					list.Add(this.method_222((float)(gstruct169_0.list_0[i].int_0 + gstruct163_0.int_0), (float)(gstruct169_0.list_0[i].int_1 + gstruct163_0.int_1), gstruct169_0.list_1[i].int_0, gstruct169_0.list_1[i].int_1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00097D24 File Offset: 0x00095F24
		private GameObject method_70(GameObject gameObject_1, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_0)
		{
			GameObject result;
			if (!gameObject_1)
			{
				result = null;
			}
			else
			{
				gameObject_1.transform.SetParent(this.gameObject_0.transform, false);
				this.method_229(gameObject_1, enum10_0);
				result = gameObject_1;
			}
			return result;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00097D64 File Offset: 0x00095F64
		internal void method_71(List<GClass84.GStruct160> list_6)
		{
			this.method_184(list_6);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00097D78 File Offset: 0x00095F78
		internal void method_72(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_209(list_6, int_4);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00097D90 File Offset: 0x00095F90
		internal void method_73(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j * int_5 + int_4), (float)(i * int_5));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00097E30 File Offset: 0x00096030
		internal void method_74(List<Color> list_6, int int_4)
		{
			this.method_234(list_6, int_4);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00097E48 File Offset: 0x00096048
		private GameObject method_75(string string_1, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_0)
		{
			GameObject gameObject = new GameObject(string_1);
			gameObject.transform.SetParent(this.gameObject_0.transform, false);
			this.method_229(gameObject, enum10_0);
			return gameObject;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00097E80 File Offset: 0x00096080
		internal void method_76(float float_8, float float_9)
		{
			this.method_130(float_8, float_9);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00097E98 File Offset: 0x00096098
		internal void method_77(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_14(list_6, int_4);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00097EB0 File Offset: 0x000960B0
		internal bool method_78(GameObject gameObject_1, Texture texture_0)
		{
			RawImage component = gameObject_1.GetComponent<RawImage>();
			bool result;
			if (component)
			{
				component.texture = texture_0;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00097EDC File Offset: 0x000960DC
		internal GameObject method_79(List<GClass84.GStruct163> list_6, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_6.Count; i++)
				{
					list.Add(this.method_5((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_1), GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000980D0 File Offset: 0x000962D0
		internal bool method_80(GameObject gameObject_1, Color color_1)
		{
			RawImage component = gameObject_1.GetComponent<RawImage>();
			bool result;
			if (component)
			{
				component.color = color_1;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000980FC File Offset: 0x000962FC
		private bool method_81(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_114(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00098130 File Offset: 0x00096330
		internal void method_82(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_123(list_6, int_4);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00098148 File Offset: 0x00096348
		private List<GameObject> method_83(string string_1)
		{
			GClass156.Class168 @class = new GClass156.Class168();
			@class.string_0 = string_1;
			return this.list_2.FindAll(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0009817C File Offset: 0x0009637C
		internal GameObject method_84(List<GClass84.GStruct163> list_6)
		{
			string text = "Temp" + "Vectors" + "_" + list_6.Count.ToString();
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_6.Count; i++)
				{
					list.Add(this.method_5((float)list_6[i].int_0, (float)list_6[i].int_1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00098304 File Offset: 0x00096504
		internal void method_85(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_195(list_6, int_4);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0009831C File Offset: 0x0009651C
		internal void method_86(float float_8, float float_9, float float_10)
		{
			float_8 = GClass84.smethod_359(float_8, 5f);
			float_9 = GClass84.smethod_359(float_9, 5f);
			float num = this.float_6;
			float num2 = this.float_7;
			this.method_19(this.float_7, float_10);
			this.method_19(this.float_7 + float_9, float_10);
			this.method_161(this.float_6, float_10);
			this.method_161(this.float_6 + float_8, float_10);
			this.float_7 = num2 + float_9 - float_10;
			this.method_161(this.float_6, float_10);
			this.method_161(this.float_6 + float_8, float_10);
			this.float_6 = num + float_8 - float_10;
			this.method_19(num2, float_10);
			this.method_19(num2 + float_9, float_10);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000983D0 File Offset: 0x000965D0
		internal GameObject method_87(List<GClass84.GStruct163> list_6, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < list_6.Count; i++)
			{
				list.Add(this.method_53((float)list_6[i].int_0, (float)list_6[i].int_1, int_4, int_4));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0009854C File Offset: 0x0009674C
		internal GClass84.GStruct163 method_88(Vector3 vector3_0)
		{
			Camera main = Camera.main;
			GClass84.GStruct163 result;
			if (!main)
			{
				result = new GClass84.GStruct163(0, 0);
			}
			else
			{
				Vector3 vector = main.WorldToScreenPoint(vector3_0);
				result = new GClass84.GStruct163((int)vector.x, (int)vector.y);
			}
			return result;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00098594 File Offset: 0x00096794
		private GameObject method_89(string string_1)
		{
			GClass156.Class164 @class = new GClass156.Class164();
			@class.string_0 = string_1;
			return this.list_2.Find(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000985C8 File Offset: 0x000967C8
		internal GameObject method_90(List<GClass84.GStruct163> list_6, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_6.Count; i++)
				{
					list.Add(this.method_125((float)list_6[i].int_0, (float)list_6[i].int_1, int_4, int_4, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0009877C File Offset: 0x0009697C
		internal void method_91(Texture texture_0, float float_8, float float_9)
		{
			this.method_162(texture_0, float_8, float_9);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00098794 File Offset: 0x00096994
		internal GameObject method_92(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")",
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			int num9 = (int_4 + 1) / 2 + 1;
			int num10 = int_4 - 1;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i].int_0 + gstruct163_0.int_0 - num9), (float)(list_6[i].int_1 + gstruct163_0.int_0 - num9), list_7[i].int_0 + num10, list_7[i].int_1 + num10));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00098A78 File Offset: 0x00096C78
		public override void vmethod_23()
		{
			this.method_138();
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00098A8C File Offset: 0x00096C8C
		internal void method_93(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_158(list_6, int_4, int_5);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00098AA4 File Offset: 0x00096CA4
		internal void method_94(string string_1, float float_8, float float_9, GClass84.GEnum46 genum46_0)
		{
			this.method_149(string_1, float_8, float_9, genum46_0);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00098AC0 File Offset: 0x00096CC0
		internal void method_95(ref Vector3 vector3_0, ref Quaternion quaternion_0)
		{
			Camera main = Camera.main;
			if (!main)
			{
				vector3_0 = default(Vector3);
				quaternion_0 = default(Quaternion);
			}
			else
			{
				vector3_0 = main.transform.position;
				quaternion_0 = main.transform.rotation;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00098B10 File Offset: 0x00096D10
		internal void method_96(float float_8, float float_9)
		{
			this.method_25(float_8, float_9);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00098B28 File Offset: 0x00096D28
		internal void method_97(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61(0f, (float)(i + int_4));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00098BD0 File Offset: 0x00096DD0
		private List<GameObject> method_98(string string_1)
		{
			GClass156.Class167 @class = new GClass156.Class167();
			@class.string_0 = string_1;
			return this.list_1.FindAll(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00098C04 File Offset: 0x00096E04
		internal void method_99(List<Color> list_6, int int_4)
		{
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				this.method_61((float)(i * int_4), 0f);
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_4, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00098C68 File Offset: 0x00096E68
		internal void method_100(GClass169 gclass169_0, bool bool_0, bool bool_1 = false, float float_8 = 0f)
		{
			this.method_37(gclass169_0, bool_0, bool_1, float_8);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00098C84 File Offset: 0x00096E84
		internal void method_101(List<Color> list_6)
		{
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				this.method_61((float)i, 0f);
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00098CEC File Offset: 0x00096EEC
		public override void vmethod_15()
		{
			this.method_26();
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00098D00 File Offset: 0x00096F00
		internal void method_102(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_129(list_6, int_4);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00098D18 File Offset: 0x00096F18
		internal void method_103(byte byte_0, byte byte_1, byte byte_2, byte byte_3)
		{
			this.color_0 = new Color((float)byte_0 / 255f, (float)byte_1 / 255f, (float)byte_2 / 255f, GClass84.smethod_108<float>(byte_3 == 0, 1f, (float)byte_3 / 255f));
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00098D60 File Offset: 0x00096F60
		internal void method_104(float float_8, float float_9)
		{
			this.float_2 = float_8;
			this.float_3 = float_9;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00098D7C File Offset: 0x00096F7C
		private float method_105()
		{
			return this.float_5 / (float)this.int_1;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00098D9C File Offset: 0x00096F9C
		internal void method_106(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61((float)int_4, (float)i);
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00098E40 File Offset: 0x00097040
		internal GameObject method_107(Texture texture_0, float float_8, float float_9, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_2)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				string string_ = string.Concat(new string[]
				{
					"Temp",
					"Tile",
					"Stretched",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString()
				});
				GameObject gameObject = this.method_196(string_, enum10_0);
				if (gameObject)
				{
					gameObject.tag = "Untagged";
					this.method_11(gameObject, texture_0, this.color_0);
					result = gameObject;
				}
				else
				{
					List<GameObject> list = new List<GameObject>();
					float num = this.float_6;
					float num2 = this.float_7;
					if (float_8 == (float)texture_0.width)
					{
						if (float_9 == (float)texture_0.height)
						{
							list.Add(this.method_227(texture_0, float_8, float_9, 0f, 0f, (float)texture_0.width, (float)texture_0.height, GClass156.Enum10.const_3));
						}
						else if (float_9 < (float)texture_0.height)
						{
							float num3 = float_9 / 2f;
							list.Add(this.method_227(texture_0, float_8, num3, 0f, 0f, float_8, num3, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num3);
							list.Add(this.method_227(texture_0, float_8, num3, 0f, (float)texture_0.height - num3, float_8, num3, GClass156.Enum10.const_3));
						}
						else
						{
							float num4 = (float)(texture_0.height / 2);
							list.Add(this.method_227(texture_0, num4, float_9, 0f, 0f, float_8, num4, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num4);
							list.Add(this.method_227(texture_0, float_8, float_9 - (float)texture_0.height, 0f, num4, float_8, 0f, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num4 + (float_9 - (float)texture_0.height));
							list.Add(this.method_227(texture_0, float_8, num4, 0f, num4, float_8, num4, GClass156.Enum10.const_3));
						}
					}
					else if (float_9 == (float)texture_0.height)
					{
						if (float_8 < (float)texture_0.width)
						{
							float num5 = float_8 / 2f;
							list.Add(this.method_227(texture_0, num5, float_9, 0f, 0f, num5, float_9, GClass156.Enum10.const_3));
							this.method_61(num + num5, num2);
							list.Add(this.method_227(texture_0, num5, float_9, (float)texture_0.width - num5, 0f, num5, float_9, GClass156.Enum10.const_3));
						}
						else
						{
							float num6 = (float)(texture_0.width / 2);
							list.Add(this.method_227(texture_0, num6, float_9, 0f, 0f, num6, float_9, GClass156.Enum10.const_3));
							this.method_61(num + num6, num2);
							list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, float_9, num6, 0f, 0f, float_9, GClass156.Enum10.const_3));
							this.method_61(num + num6 + (float_8 - (float)texture_0.width), num2);
							list.Add(this.method_227(texture_0, num6, float_9, num6, 0f, num6, float_9, GClass156.Enum10.const_3));
						}
					}
					else if (float_8 < (float)texture_0.width)
					{
						if (float_9 < (float)texture_0.height)
						{
							float num7 = float_8 / 2f;
							float num8 = float_9 / 2f;
							list.Add(this.method_227(texture_0, num7, num8, 0f, 0f, num7, num8, GClass156.Enum10.const_3));
							this.method_61(num + num7, num2);
							list.Add(this.method_227(texture_0, num7, num8, (float)texture_0.width - num7, 0f, num7, num8, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num8);
							list.Add(this.method_227(texture_0, num7, num8, 0f, (float)texture_0.height - num8, num7, num8, GClass156.Enum10.const_3));
							this.method_61(num + num7, num2 + num8);
							list.Add(this.method_227(texture_0, num7, num8, (float)texture_0.width - num7, (float)texture_0.height - num8, num7, num8, GClass156.Enum10.const_3));
						}
						else
						{
							float num9 = float_8 / 2f;
							float num10 = (float)(texture_0.height / 2);
							list.Add(this.method_227(texture_0, num9, num10, 0f, 0f, num9, num10, GClass156.Enum10.const_3));
							this.method_61(num + num9, num2);
							list.Add(this.method_227(texture_0, num9, num10, (float)texture_0.width - num9, 0f, num9, num10, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num10);
							list.Add(this.method_227(texture_0, num9, num10, 0f, num10, num9, 0f, GClass156.Enum10.const_3));
							this.method_61(num + num9, num2 + num10);
							list.Add(this.method_227(texture_0, num9, num10, (float)texture_0.width - num9, num10, num9, 0f, GClass156.Enum10.const_3));
							this.method_61(num, num2 + num10);
							list.Add(this.method_227(texture_0, num9, num10, 0f, num10, num9, num10, GClass156.Enum10.const_3));
							this.method_61(num + num9, num2 + num10);
							list.Add(this.method_227(texture_0, num9, num10, (float)texture_0.width - num9, num10, num9, num10, GClass156.Enum10.const_3));
						}
					}
					else if (float_9 < (float)texture_0.height)
					{
						float num11 = (float)(texture_0.width / 2);
						float num12 = float_9 / 2f;
						list.Add(this.method_227(texture_0, num11, num12, 0f, 0f, num11, num12, GClass156.Enum10.const_3));
						this.method_61(num + num11, num2);
						list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, num12, num11, 0f, 0f, num12, GClass156.Enum10.const_3));
						this.method_61(num + num11 + (float_8 - (float)texture_0.width), num2);
						list.Add(this.method_227(texture_0, num11, num12, num11, 0f, num11, num12, GClass156.Enum10.const_3));
						this.method_61(num, num2 + num12);
						list.Add(this.method_227(texture_0, num11, num12, 0f, (float)texture_0.height - num12, num11, num12, GClass156.Enum10.const_3));
						this.method_61(num + num11, num2 + num12);
						list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, num12, num11, (float)texture_0.height - num12, 0f, num12, GClass156.Enum10.const_3));
						this.method_61(num + num11 + (float_8 - (float)texture_0.width), num2 + num12);
						list.Add(this.method_227(texture_0, num11, num12, num11, (float)texture_0.height - num12, num11, num12, GClass156.Enum10.const_3));
					}
					else
					{
						float num13 = (float)(texture_0.width / 2);
						float num14 = (float)(texture_0.height / 2);
						list.Add(this.method_227(texture_0, num13, num14, 0f, 0f, num13, num14, GClass156.Enum10.const_3));
						this.method_61(num + num13, num2);
						list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, num14, 0f, 0f, 0f, num14, GClass156.Enum10.const_3));
						this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2);
						list.Add(this.method_227(texture_0, num13 + (float_8 - (float)texture_0.width), num14, 0f, 0f, num13, num14, GClass156.Enum10.const_3));
						this.method_61(num, num2 + num14);
						list.Add(this.method_227(texture_0, num13, float_9 - (float)texture_0.height, 0f, 0f, num13, 0f, GClass156.Enum10.const_3));
						this.method_61(num + num13, num2 + num14);
						list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, float_9 - (float)texture_0.height, 0f, 0f, 0f, 0f, GClass156.Enum10.const_3));
						this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2 + num14);
						list.Add(this.method_227(texture_0, num13, float_9 - (float)texture_0.height, 0f, 0f, num13, 0f, GClass156.Enum10.const_3));
						this.method_61(num, num2 + num14 + (float_9 - (float)texture_0.height));
						list.Add(this.method_227(texture_0, num13, num14, 0f, 0f, num13, num14, GClass156.Enum10.const_3));
						this.method_61(num + num13, num2 + num14 + (float_9 - (float)texture_0.height));
						list.Add(this.method_227(texture_0, float_8 - (float)texture_0.width, num14, 0f, 0f, 0f, num14, GClass156.Enum10.const_3));
						this.method_61(num + num13 + (float_8 - (float)texture_0.width), num2 + num14 + (float_9 - (float)texture_0.height));
						list.Add(this.method_227(texture_0, num13, num14, 0f, 0f, num13, num14, GClass156.Enum10.const_3));
					}
					GClass84.smethod_1233<GameObject>(list);
					if (list.Count > 0)
					{
						GameObject gameObject2 = this.method_75(string_, enum10_0);
						GClass84.smethod_1477(list, gameObject2);
						list.Clear();
						result = gameObject2;
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00099754 File Offset: 0x00097954
		private void method_108()
		{
			this.method_121();
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00099768 File Offset: 0x00097968
		internal void method_109()
		{
			this.list_4.Add(new GClass156.Struct21("a", 148, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("b", 159, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("c", 170, 83, 7, 16));
			this.list_4.Add(new GClass156.Struct21("d", 180, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("e", 191, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("f", 201, 83, 5, 16));
			this.list_4.Add(new GClass156.Struct21("g", 208, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("h", 219, 83, 7, 16));
			this.list_4.Add(new GClass156.Struct21("i", 229, 83, 2, 16));
			this.list_4.Add(new GClass156.Struct21("j", 233, 83, 4, 16));
			this.list_4.Add(new GClass156.Struct21("k", 240, 83, 8, 16));
			this.list_4.Add(new GClass156.Struct21("l", 250, 83, 2, 16));
			this.list_4.Add(new GClass156.Struct21("m", 1, 103, 12, 16));
			this.list_4.Add(new GClass156.Struct21("n", 16, 103, 7, 16));
			this.list_4.Add(new GClass156.Struct21("o", 26, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("p", 37, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("q", 48, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("r", 59, 103, 5, 16));
			this.list_4.Add(new GClass156.Struct21("s", 66, 103, 7, 16));
			this.list_4.Add(new GClass156.Struct21("t", 75, 103, 5, 16));
			this.list_4.Add(new GClass156.Struct21("u", 82, 103, 7, 16));
			this.list_4.Add(new GClass156.Struct21("v", 91, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("w", 100, 103, 12, 16));
			this.list_4.Add(new GClass156.Struct21("x", 113, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("y", 122, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("z", 131, 103, 8, 16));
			this.list_4.Add(new GClass156.Struct21("A", 19, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("B", 32, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("C", 45, 63, 11, 16));
			this.list_4.Add(new GClass156.Struct21("D", 59, 63, 11, 16));
			this.list_4.Add(new GClass156.Struct21("E", 73, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("F", 86, 63, 9, 16));
			this.list_4.Add(new GClass156.Struct21("G", 98, 63, 11, 16));
			this.list_4.Add(new GClass156.Struct21("H", 112, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("I", 125, 63, 2, 16));
			this.list_4.Add(new GClass156.Struct21("J", 130, 63, 7, 16));
			this.list_4.Add(new GClass156.Struct21("K", 140, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("L", 153, 63, 8, 16));
			this.list_4.Add(new GClass156.Struct21("M", 164, 63, 12, 16));
			this.list_4.Add(new GClass156.Struct21("N", 179, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("O", 192, 63, 11, 16));
			this.list_4.Add(new GClass156.Struct21("P", 206, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("Q", 219, 63, 11, 16));
			this.list_4.Add(new GClass156.Struct21("R", 233, 63, 10, 16));
			this.list_4.Add(new GClass156.Struct21("S", 1, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("T", 13, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("U", 25, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("V", 38, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("W", 50, 83, 16, 16));
			this.list_4.Add(new GClass156.Struct21("X", 67, 83, 12, 16));
			this.list_4.Add(new GClass156.Struct21("Y", 80, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("Z", 91, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("0", 77, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("1", 89, 43, 5, 16));
			this.list_4.Add(new GClass156.Struct21("2", 99, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("3", 110, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("4", 120, 43, 9, 16));
			this.list_4.Add(new GClass156.Struct21("5", 132, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("6", 143, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("7", 154, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("8", 165, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("9", 176, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21(".", 66, 43, 2, 16));
			this.list_4.Add(new GClass156.Struct21(",", 53, 43, 2, 16));
			this.list_4.Add(new GClass156.Struct21("!", 204, 23, 2, 16));
			this.list_4.Add(new GClass156.Struct21("?", 232, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("%", 240, 23, 13, 16));
			this.list_4.Add(new GClass156.Struct21("_", 129, 83, 10, 16));
			this.list_4.Add(new GClass156.Struct21("{", 140, 103, 6, 16));
			this.list_4.Add(new GClass156.Struct21("}", 152, 103, 6, 16));
			this.list_4.Add(new GClass156.Struct21("|", 148, 103, 2, 16));
			this.list_4.Add(new GClass156.Struct21("~", 159, 103, 9, 16));
			this.list_4.Add(new GClass156.Struct21("<", 199, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21(">", 221, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("=", 210, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("\"", 210, 23, 5, 16));
			this.list_4.Add(new GClass156.Struct21("#", 217, 23, 10, 16));
			this.list_4.Add(new GClass156.Struct21("$", 229, 23, 8, 16));
			this.list_4.Add(new GClass156.Struct21("(", 19, 43, 4, 16));
			this.list_4.Add(new GClass156.Struct21(")", 26, 43, 4, 16));
			this.list_4.Add(new GClass156.Struct21("*", 32, 43, 4, 16));
			this.list_4.Add(new GClass156.Struct21("+", 41, 43, 8, 16));
			this.list_4.Add(new GClass156.Struct21("-", 57, 43, 5, 16));
			this.list_4.Add(new GClass156.Struct21("'", 14, 43, 2, 16));
			this.list_4.Add(new GClass156.Struct21("«", 228, 143, 7, 16));
			this.list_4.Add(new GClass156.Struct21("»", 123, 163, 7, 16));
			this.list_4.Add(new GClass156.Struct21("®", 7, 163, 13, 16));
			this.list_4.Add(new GClass156.Struct21("±", 41, 163, 8, 16));
			this.list_4.Add(new GClass156.Struct21("¶", 83, 163, 10, 16));
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0009A1DC File Offset: 0x000983DC
		internal void method_110(string string_1, ref float float_8, ref float float_9)
		{
			this.method_6(string_1, ref float_8, ref float_9);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0009A1F4 File Offset: 0x000983F4
		internal void method_111(List<GClass84.GStruct160> list_6)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)j, (float)i);
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0009A294 File Offset: 0x00098494
		internal void method_112(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_208(list_6, int_4);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0009A2AC File Offset: 0x000984AC
		internal void method_113()
		{
			this.method_64();
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0009A2C0 File Offset: 0x000984C0
		private bool method_114(GameObject gameObject_1)
		{
			for (int i = 0; i < this.list_3.Count; i++)
			{
				if (this.list_3[i] == gameObject_1)
				{
					this.list_3.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0009A30C File Offset: 0x0009850C
		internal void method_115(List<Color> list_6, int int_4, int int_5)
		{
			this.method_194(list_6, int_4, int_5);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0009A324 File Offset: 0x00098524
		internal void method_116(string string_1, ref float float_8, ref float float_9)
		{
			this.method_180(string_1, ref float_8, ref float_9);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0009A33C File Offset: 0x0009853C
		internal GameObject method_117(List<GClass84.GStruct163> list_6, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < list_6.Count; i++)
			{
				list.Add(this.method_53((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_1), int_4, int_4));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0009A4FC File Offset: 0x000986FC
		private bool method_118(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_55(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0009A530 File Offset: 0x00098730
		internal void method_119(List<GClass84.GStruct160> list_6)
		{
			this.method_154(list_6);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0009A544 File Offset: 0x00098744
		internal GameObject method_120(GClass84.GStruct169 gstruct169_0, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Offset",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < gstruct169_0.list_0.Count; i++)
			{
				list.Add(this.method_45((float)(gstruct169_0.list_0[i].int_0 + gstruct163_0.int_0), (float)(gstruct169_0.list_0[i].int_1 + gstruct163_0.int_1), gstruct169_0.list_1[i].int_0, gstruct169_0.list_1[i].int_1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0009A850 File Offset: 0x00098A50
		private void method_121()
		{
			GClass84.smethod_1233<GameObject>(this.list_0);
			GClass84.smethod_1233<GameObject>(this.list_1);
			GClass84.smethod_1233<GameObject>(this.list_2);
			GClass84.smethod_1233<GameObject>(this.list_3);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0009A88C File Offset: 0x00098A8C
		internal GameObject method_122(Texture texture_0, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_1)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					"Temp",
					"Tile",
					"Clipped",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString(),
					"_",
					float_10.ToString(),
					"_",
					float_11.ToString(),
					"_",
					float_12.ToString(),
					"_",
					float_13.ToString()
				});
				GameObject gameObject = this.method_196(text, enum10_0);
				if (gameObject)
				{
					gameObject.tag = "Untagged";
					this.method_11(gameObject, texture_0, this.color_0);
					result = gameObject;
				}
				else
				{
					GameObject gameObject2 = new GameObject(text);
					gameObject2.AddComponent<CanvasRenderer>();
					RawImage rawImage = gameObject2.AddComponent<RawImage>();
					gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(float_8 * this.method_151(), float_9 * this.method_105());
					gameObject2.GetComponent<RectTransform>().position = new Vector2(this.method_22() + float_8 * this.method_151() / 2f, this.method_51() + float_9 * this.method_105() / 2f);
					this.method_61(this.float_6 + float_8 * this.method_151(), this.float_7 - float_9 * this.method_151());
					gameObject2.transform.SetParent(this.gameObject_0.transform, false);
					rawImage.texture = texture_0;
					rawImage.color = this.color_0;
					Rect uvRect = rawImage.uvRect;
					Vector2 vector = rawImage.uvRect.position;
					vector.x = float_10 / (float)texture_0.width;
					vector.y = float_11 / (float)texture_0.height;
					uvRect.position = vector;
					vector = rawImage.uvRect.size;
					vector.x = float_12 / (float)texture_0.width;
					vector.y = float_13 / (float)texture_0.height;
					uvRect.size = vector;
					rawImage.uvRect = uvRect;
					this.method_229(gameObject2, enum10_0);
					result = gameObject2;
				}
			}
			return result;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0009AB2C File Offset: 0x00098D2C
		internal void method_123(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_145(list_6, int_4);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0009AB44 File Offset: 0x00098D44
		private bool method_124(GameObject gameObject_1)
		{
			bool result;
			if (!this.list_2.Contains(gameObject_1))
			{
				this.method_33(gameObject_1);
				this.method_55(gameObject_1);
				this.method_114(gameObject_1);
				this.list_2.Add(gameObject_1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0009AB90 File Offset: 0x00098D90
		internal GameObject method_125(float float_8, float float_9, int int_4, int int_5, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_1)
		{
			this.method_61(float_8 - (float)((int_4 + 1) / 2), float_9 - (float)((int_5 + 1) / 2));
			return this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_5, 0f, 0f, 1f, 1f, enum10_0);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0009ABDC File Offset: 0x00098DDC
		internal void method_126()
		{
			this.method_17();
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0009ABF0 File Offset: 0x00098DF0
		internal void method_127(List<Color> list_6, int int_4, int int_5)
		{
			this.method_228(list_6, int_4, int_5);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0009AC08 File Offset: 0x00098E08
		internal void method_128(float float_8, float float_9, float float_10, float float_11 = 0f)
		{
			this.method_58(float_8, float_9, float_10, float_11);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0009AC24 File Offset: 0x00098E24
		internal void method_129(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_177(list_6, int_4);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0009AC3C File Offset: 0x00098E3C
		internal void method_130(float float_8, float float_9)
		{
			this.method_40(float_8, float_9);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0009AC54 File Offset: 0x00098E54
		private GameObject method_131(string string_1)
		{
			GClass156.Class162 @class = new GClass156.Class162();
			@class.string_0 = string_1;
			return this.list_0.Find(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0009AC88 File Offset: 0x00098E88
		private bool method_132(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_240(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0009ACBC File Offset: 0x00098EBC
		internal void method_133(List<Color> list_6)
		{
			this.method_9(list_6);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0009ACD0 File Offset: 0x00098ED0
		internal void method_134(string string_1, ref float float_8, ref float float_9)
		{
			this.method_116(string_1, ref float_8, ref float_9);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0009ACE8 File Offset: 0x00098EE8
		private bool method_135(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_124(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0009AD1C File Offset: 0x00098F1C
		internal void method_136(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_73(list_6, int_4, int_5);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0009AD34 File Offset: 0x00098F34
		internal void method_137(float float_8, float float_9, float float_10, float float_11)
		{
			this.color_0 = new Color(float_8, float_9, float_10, GClass84.smethod_108<float>(float_11 == 0f, 1f, float_11));
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0009AD64 File Offset: 0x00098F64
		internal void method_138()
		{
			this.method_241();
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0009AD78 File Offset: 0x00098F78
		internal void method_139(List<Color> list_6, int int_4)
		{
			this.method_41(list_6, int_4);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0009AD90 File Offset: 0x00098F90
		internal GameObject method_140(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)list_6[i].int_0, (float)list_6[i].int_1, list_7[i].int_0, list_7[i].int_1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0009AFE4 File Offset: 0x000991E4
		internal void method_141(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61(0f, (float)(i * int_5 + int_4));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0009B088 File Offset: 0x00099288
		internal GameObject method_142(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"Offset",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")",
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				int num9 = (int_4 + 1) / 2 + 1;
				int num10 = int_4 - 1;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i].int_0 + gstruct163_0.int_0 - num9), (float)(list_6[i].int_1 + gstruct163_0.int_0 - num9), list_7[i].int_0 + num10, list_7[i].int_1 + num10, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0009B3AC File Offset: 0x000995AC
		internal GameObject method_143(GClass84.GStruct169 gstruct169_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Thickness",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < gstruct169_0.list_0.Count; i++)
			{
				list.Add(this.method_45((float)(gstruct169_0.list_0[i].int_0 - (int_4 + 1) / 2 + 1), (float)(gstruct169_0.list_0[i].int_1 - (int_4 + 1) / 2 + 1), gstruct169_0.list_1[i].int_0 + int_4 - 1, gstruct169_0.list_1[i].int_1 + int_4 - 1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x0009B694 File Offset: 0x00099894
		internal void method_144(Texture texture_0, float float_8)
		{
			this.method_239(texture_0, float_8);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0009B6AC File Offset: 0x000998AC
		internal void method_145(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j + int_4), (float)i);
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0009B74C File Offset: 0x0009994C
		internal GameObject method_146(string string_1, bool bool_0 = false)
		{
			GameObject result;
			if (this.float_0 == 0f || this.float_1 == 0f)
			{
				result = null;
			}
			else
			{
				string string_2 = string.Concat(new string[]
				{
					"Temp",
					"Text",
					"_",
					string_1,
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					this.float_0.ToString(),
					"_",
					this.float_1.ToString()
				});
				GameObject gameObject = this.method_196(string_2, GClass156.Enum10.const_2);
				if (gameObject)
				{
					gameObject.tag = "Untagged";
					RawImage[] array = gameObject.GetComponentsInChildren<RawImage>();
					for (int i = array.Length - 1; i >= 0; i--)
					{
						array[i].color = this.color_0;
					}
					result = gameObject;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					bool flag = false;
					float num6 = this.float_6;
					float float_ = this.float_7;
					List<GameObject> list = new List<GameObject>();
					string text = GClass84.smethod_1428(string_1, 1);
					while (text != string.Empty)
					{
						if (text == " ")
						{
							num5 += (int)((float)this.int_3 * this.float_0);
							string_1 = GClass84.smethod_1204(string_1, 1, -1);
							flag = false;
						}
						else
						{
							if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
							{
								if (flag)
								{
									num5 += this.int_2;
								}
								this.method_61(num6 + (float)num5, float_);
								list.Add(this.method_227(GClass153.GClass87.texture2D_6, (float)num3 * this.float_0, (float)num4 * this.float_1, (float)num, (float)num2, (float)num3, (float)num4, GClass156.Enum10.const_3));
								num5 += (int)((float)num3 * this.float_0);
								flag = true;
							}
							string_1 = GClass84.smethod_1204(string_1, 1, -1);
						}
						text = GClass84.smethod_1428(string_1, 1);
					}
					if (bool_0)
					{
						this.method_61(num6, float_);
					}
					GClass84.smethod_1233<GameObject>(list);
					if (list.Count > 0)
					{
						GameObject gameObject2 = this.method_75(string_2, GClass156.Enum10.const_2);
						GClass84.smethod_1477(list, gameObject2);
						list.Clear();
						result = gameObject2;
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0009B9A4 File Offset: 0x00099BA4
		internal void method_147(float float_8, float float_9)
		{
			this.method_179(float_8, float_9);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0009B9BC File Offset: 0x00099BBC
		internal GameObject method_148(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, GClass84.GStruct163 gstruct163_0)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")"
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i].int_0 + gstruct163_0.int_0), (float)(list_6[i].int_1 + gstruct163_0.int_0), list_7[i].int_0, list_7[i].int_1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0009BCA8 File Offset: 0x00099EA8
		internal void method_149(string string_1, float float_8, float float_9, GClass84.GEnum46 genum46_0)
		{
			float num = 0f;
			float num2 = 0f;
			float_8 *= (float)this.int_0;
			float_9 *= (float)this.int_1;
			this.method_236(string_1, ref num, ref num2);
			int num3 = (int)num;
			int num4 = (int)num2;
			switch (genum46_0)
			{
			case GClass84.GEnum46.const_1:
				float_8 -= (float)(num3 / 2);
				break;
			case GClass84.GEnum46.const_2:
				float_8 -= (float)num3;
				break;
			case GClass84.GEnum46.const_3:
				float_8 -= (float)num3;
				float_9 -= (float)(num4 / 2);
				break;
			case GClass84.GEnum46.const_4:
				float_8 -= (float)num3;
				float_9 -= (float)num4;
				break;
			case GClass84.GEnum46.const_5:
				float_8 -= (float)(num3 / 2);
				float_9 -= (float)num4;
				break;
			case GClass84.GEnum46.const_6:
				float_9 -= (float)num4;
				break;
			case GClass84.GEnum46.const_7:
				float_9 -= (float)(num4 / 2);
				break;
			case GClass84.GEnum46.const_8:
				float_8 -= (float)(num3 / 2);
				float_9 -= (float)(num4 / 2);
				break;
			}
			this.method_61(float_8, float_9);
			this.method_50(string_1, false);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x0009BD90 File Offset: 0x00099F90
		internal void method_150(GameObject gameObject_1, bool bool_0, bool bool_1, float float_8)
		{
			this.method_192(gameObject_1, bool_0, bool_1, float_8);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0009BDAC File Offset: 0x00099FAC
		private float method_151()
		{
			return this.float_4 / (float)this.int_0;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0009BDCC File Offset: 0x00099FCC
		internal void method_152(float float_8, float float_9)
		{
			this.method_104(float_8, float_9);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0009BDE4 File Offset: 0x00099FE4
		internal GameObject method_153(List<GClass84.GStruct163> list_6)
		{
			string text = "Vectors" + "Offset" + "_" + list_6.Count.ToString();
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < list_6.Count; i++)
			{
				list.Add(this.method_65((float)list_6[i].int_0, (float)list_6[i].int_1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0009BF3C File Offset: 0x0009A13C
		internal void method_154(List<GClass84.GStruct160> list_6)
		{
			this.method_165(list_6);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0009BF50 File Offset: 0x0009A150
		private List<GameObject> method_155(string string_1)
		{
			GClass156.Class166 @class = new GClass156.Class166();
			@class.string_0 = string_1;
			return this.list_0.FindAll(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0009BF84 File Offset: 0x0009A184
		internal void method_156(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_67(list_6, int_4, int_5);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0009BF9C File Offset: 0x0009A19C
		internal GameObject method_157(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				int num = (int_4 + 1) / 2 + 1;
				int num2 = int_4 - 1;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i] - num), (float)(list_7[i] - num), list_8[i] + num2, list_9[i] + num2, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		internal void method_158(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61((float)int_4, (float)(i + int_5));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0009C454 File Offset: 0x0009A654
		internal void method_159(ref Vector3 vector3_0, ref Quaternion quaternion_0)
		{
			this.method_201(ref vector3_0, ref quaternion_0);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0009C46C File Offset: 0x0009A66C
		internal void method_160()
		{
			this.method_109();
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0009C480 File Offset: 0x0009A680
		internal void method_161(float float_8, float float_9)
		{
			this.method_147(float_8, float_9);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0009C498 File Offset: 0x0009A698
		internal void method_162(Texture texture_0, float float_8, float float_9)
		{
			this.method_227(texture_0, float_8, float_9, 0f, 0f, (float)texture_0.width, (float)texture_0.height, GClass156.Enum10.const_1);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0009C4C8 File Offset: 0x0009A6C8
		internal void method_163(List<Color> list_6)
		{
			this.method_235(list_6);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0009C4DC File Offset: 0x0009A6DC
		internal void method_164(float float_8, float float_9, float float_10)
		{
			this.method_186(float_8, float_9, float_10);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0009C4F4 File Offset: 0x0009A6F4
		internal void method_165(List<GClass84.GStruct160> list_6)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61(0f, (float)i);
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0009C598 File Offset: 0x0009A798
		internal bool method_166(GameObject gameObject_1, Color color_1)
		{
			RawImage componentInChildren = gameObject_1.GetComponentInChildren<RawImage>();
			bool result;
			if (!componentInChildren)
			{
				result = false;
			}
			else if (componentInChildren.color == color_1)
			{
				result = true;
			}
			else
			{
				bool flag = false;
				RawImage[] array = gameObject_1.GetComponentsInChildren<RawImage>();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					array[i].color = color_1;
					flag = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0009C608 File Offset: 0x0009A808
		internal void method_167(List<Color> list_6, int int_4)
		{
			this.method_74(list_6, int_4);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0009C620 File Offset: 0x0009A820
		private GameObject method_168(string string_1)
		{
			GameObject gameObject = new GameObject(string_1);
			gameObject.transform.SetParent(this.gameObject_0.transform, false);
			return gameObject;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0009C650 File Offset: 0x0009A850
		internal void method_169(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j * int_6 + int_4), (float)(i * int_6 + int_5));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_6, (float)int_6, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0009C6F4 File Offset: 0x0009A8F4
		private bool method_170(string string_1, ref int int_4, ref int int_5, ref int int_6, ref int int_7)
		{
			GClass156.Class161 @class = new GClass156.Class161();
			@class.string_0 = string_1;
			int num = this.list_4.FindIndex(new Predicate<GClass156.Struct21>(@class.method_0));
			bool result;
			if (num != -1)
			{
				GClass156.Struct21 @struct = this.list_4[num];
				int_4 = @struct.int_0;
				int_5 = @struct.int_1;
				int_6 = @struct.int_2;
				int_7 = @struct.int_3;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0009C768 File Offset: 0x0009A968
		internal GameObject method_171(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				int num9 = (int_4 + 1) / 2 + 1;
				int num10 = int_4 - 1;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i].int_0 - num9), (float)(list_6[i].int_1 - num9), list_7[i].int_0 + num10, list_7[i].int_1 + num10, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0009CA30 File Offset: 0x0009AC30
		internal void method_172(float float_8, float float_9)
		{
			float num = this.float_6;
			float num2 = this.float_7;
			this.float_7 = float_8;
			this.method_227(GClass153.GClass87.texture2D_0, float_9, 2f, 0f, 0f, 2f, 2f, GClass156.Enum10.const_1);
			this.float_6 = num;
			this.float_7 = num2;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0009CA88 File Offset: 0x0009AC88
		internal void method_173(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61((float)int_4, (float)(i * int_5));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0009CB28 File Offset: 0x0009AD28
		internal GameObject method_174(Texture texture_0, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				float_11 = 1f - float_11 - float_13;
				string text = string.Concat(new string[]
				{
					"Tile",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString(),
					"_",
					float_10.ToString(),
					"_",
					float_11.ToString(),
					"_",
					float_12.ToString(),
					"_",
					float_13.ToString()
				});
				GameObject gameObject = new GameObject(text);
				gameObject.AddComponent<CanvasRenderer>();
				RawImage rawImage = gameObject.AddComponent<RawImage>();
				RectTransform component = gameObject.GetComponent<RectTransform>();
				component.sizeDelta = new Vector2(float_8, float_9);
				component.position = new Vector2(this.method_22() + float_8 / 2f, this.method_51() - float_9 / 2f);
				this.method_61(this.float_6 + float_8, this.float_7);
				gameObject.transform.SetParent(this.gameObject_0.transform, false);
				rawImage.texture = texture_0;
				rawImage.color = this.color_0;
				Rect uvRect = rawImage.uvRect;
				Vector2 vector = rawImage.uvRect.position;
				vector.x = float_10 / (float)texture_0.width;
				vector.y = float_11 / (float)texture_0.height;
				uvRect.position = vector;
				vector = rawImage.uvRect.size;
				vector.x = float_12 / (float)texture_0.width;
				vector.y = float_13 / (float)texture_0.height;
				uvRect.size = vector;
				rawImage.uvRect = uvRect;
				result = gameObject;
			}
			return result;
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0009CD54 File Offset: 0x0009AF54
		internal GameObject method_175(string string_1, bool bool_0 = false)
		{
			GameObject result;
			if (this.float_0 == 0f || this.float_1 == 0f)
			{
				result = null;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				bool flag = false;
				float num6 = this.float_6;
				float float_ = this.float_7;
				string string_2 = string.Concat(new string[]
				{
					"Text",
					"_",
					string_1,
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					this.float_0.ToString(),
					"_",
					this.float_1.ToString()
				});
				List<GameObject> list = new List<GameObject>();
				string text = GClass84.smethod_1428(string_1, 1);
				while (text != string.Empty)
				{
					if (text == " ")
					{
						num5 += this.int_3;
						string_1 = GClass84.smethod_1204(string_1, 1, -1);
						flag = false;
					}
					else
					{
						if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
						{
							if (flag)
							{
								num5 += this.int_2;
							}
							this.method_61(num6 + (float)num5, float_);
							list.Add(this.method_174(GClass153.GClass87.texture2D_6, (float)num3 * this.float_0, (float)num4 * this.float_1, (float)num, (float)num2, (float)num3, (float)num4));
							num5 += (int)((float)num3 * this.float_0);
							flag = true;
						}
						string_1 = GClass84.smethod_1204(string_1, 1, -1);
					}
					text = GClass84.smethod_1428(string_1, 1);
				}
				if (bool_0)
				{
					this.method_61(num6, float_);
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject = this.method_168(string_2);
					GClass84.smethod_1477(list, gameObject);
					list.Clear();
					result = gameObject;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0009CF38 File Offset: 0x0009B138
		internal GameObject method_176(GClass84.GStruct169 gstruct169_0)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < gstruct169_0.list_0.Count; i++)
			{
				list.Add(this.method_45((float)gstruct169_0.list_0[i].int_0, (float)gstruct169_0.list_0[i].int_1, gstruct169_0.list_1[i].int_0, gstruct169_0.list_1[i].int_1));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0009D1E8 File Offset: 0x0009B3E8
		internal void method_177(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j * int_4), (float)(i * int_4));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_4, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0009D284 File Offset: 0x0009B484
		internal void method_178(List<Color> list_6, int int_4)
		{
			this.method_18(list_6, int_4);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0009D29C File Offset: 0x0009B49C
		internal void method_179(float float_8, float float_9)
		{
			float num = this.float_6;
			float num2 = this.float_7;
			this.float_6 = float_8;
			this.method_227(GClass153.GClass87.texture2D_0, 2f, float_9, 0f, 0f, 2f, 2f, GClass156.Enum10.const_1);
			this.float_6 = num;
			this.float_7 = num2;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0009D2F4 File Offset: 0x0009B4F4
		internal void method_180(string string_1, ref float float_8, ref float float_9)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			bool flag = false;
			float_8 = 0f;
			float_9 = 0f;
			string text = GClass84.smethod_1428(string_1, 1);
			while (text != string.Empty)
			{
				if (text == " ")
				{
					float_8 += (float)this.int_3;
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
					flag = false;
				}
				else
				{
					if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
					{
						if (flag)
						{
							float_8 += (float)this.int_2;
						}
						float_8 += (float)num3 * this.float_0;
						float_9 = GClass84.smethod_359(float_9, (float)num4 * this.float_1);
						flag = true;
					}
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
				}
				text = GClass84.smethod_1428(string_1, 1);
			}
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0009D3BC File Offset: 0x0009B5BC
		internal void method_181(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_136(list_6, int_4, int_5);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0009D3D4 File Offset: 0x0009B5D4
		internal GameObject method_182(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)list_6[i], (float)list_7[i], list_8[i], list_9[i], GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0009D7AC File Offset: 0x0009B9AC
		private bool method_183(GameObject gameObject_1)
		{
			bool result;
			if (!this.list_1.Contains(gameObject_1))
			{
				this.method_33(gameObject_1);
				this.method_219(gameObject_1);
				this.method_114(gameObject_1);
				this.list_1.Add(gameObject_1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0009D7F8 File Offset: 0x0009B9F8
		internal void method_184(List<GClass84.GStruct160> list_6)
		{
			this.method_111(list_6);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0009D80C File Offset: 0x0009BA0C
		internal void method_185(float float_8, float float_9)
		{
			this.method_12(float_8, float_9);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0009D824 File Offset: 0x0009BA24
		internal void method_186(float float_8, float float_9, float float_10)
		{
			this.method_86(float_8, float_9, float_10);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0009D83C File Offset: 0x0009BA3C
		internal void method_187(bool bool_0, bool bool_1)
		{
			GL.Clear(bool_1, bool_0, Color.clear);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0009D858 File Offset: 0x0009BA58
		internal void method_188(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			this.method_189(list_6, int_4, int_5, int_6);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0009D874 File Offset: 0x0009BA74
		internal void method_189(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					this.method_61((float)int_4, (float)(i * int_6 + int_5));
					List<Color> list = list_6[i].list_0;
					for (int j = 0; j < count2; j++)
					{
						this.color_0 = list[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_6, (float)int_6, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0009D918 File Offset: 0x0009BB18
		internal void method_190(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			this.method_39(list_6, int_4, int_5, int_6);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0009D934 File Offset: 0x0009BB34
		private GameObject method_191(string string_1)
		{
			GClass156.Class163 @class = new GClass156.Class163();
			@class.string_0 = string_1;
			return this.list_1.Find(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0009D968 File Offset: 0x0009BB68
		internal void method_192(GameObject gameObject_1, bool bool_0, bool bool_1, float float_8)
		{
			if (!(gameObject_1 == null))
			{
				if (bool_1)
				{
					this.method_232(false, true);
				}
				bool wireframe = GL.wireframe;
				GL.wireframe = bool_0;
				List<MeshFilter> list = gameObject_1.GetComponents<MeshFilter>().ToList<MeshFilter>();
				list.AddRange(gameObject_1.GetComponentsInChildren<MeshFilter>());
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] && list[i].mesh)
					{
						Graphics.DrawMeshNow(list[i].mesh, list[i].transform.position, list[i].transform.rotation);
					}
				}
				List<SkinnedMeshRenderer> list2 = gameObject_1.GetComponents<SkinnedMeshRenderer>().ToList<SkinnedMeshRenderer>();
				list2.AddRange(gameObject_1.GetComponentsInChildren<SkinnedMeshRenderer>());
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j] && list2[j].sharedMesh)
					{
						Graphics.DrawMeshNow(list2[j].sharedMesh, list2[j].transform.position, list2[j].transform.rotation);
					}
				}
				GL.wireframe = wireframe;
			}
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0009DAB0 File Offset: 0x0009BCB0
		internal void method_193(int int_4, float float_8)
		{
			this.method_3(int_4, float_8);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0009DAC8 File Offset: 0x0009BCC8
		internal void method_194(List<Color> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				this.method_61((float)(i * int_5 + int_4), 0f);
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0009DB30 File Offset: 0x0009BD30
		internal void method_195(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_106(list_6, int_4);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0009DB48 File Offset: 0x0009BD48
		private GameObject method_196(string string_1, GClass156.Enum10 enum10_0)
		{
			GameObject result;
			switch (enum10_0)
			{
			case GClass156.Enum10.const_0:
				result = this.method_131(string_1);
				break;
			case GClass156.Enum10.const_1:
				result = this.method_191(string_1);
				break;
			case GClass156.Enum10.const_2:
				result = this.method_89(string_1);
				break;
			case GClass156.Enum10.const_3:
				result = this.method_32(string_1);
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0009DB9C File Offset: 0x0009BD9C
		internal void method_197()
		{
			this.method_160();
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0009DBB0 File Offset: 0x0009BDB0
		internal void method_198(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_141(list_6, int_4, int_5);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0009DBC8 File Offset: 0x0009BDC8
		internal void method_199(float float_8, float float_9)
		{
			this.method_19(this.float_7, float_8);
			this.method_19(this.float_7 + float_9, float_8);
			this.method_161(this.float_6, float_9);
			this.method_161(this.float_6 + float_8, float_9);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0009DC10 File Offset: 0x0009BE10
		internal void method_200()
		{
			if (this.list_0.Count > 0)
			{
				List<GameObject> list = this.method_220("Finish", GClass156.Enum10.const_1);
				list.AddRange(this.method_220("Finish", GClass156.Enum10.const_2));
				for (int i = list.Count - 1; i >= 0; i--)
				{
					this.method_240(list[i]);
					this.method_132(GClass84.smethod_94(list[i]));
					Object.DestroyImmediate(list[i], true);
				}
			}
			if (this.list_5.Count > 0)
			{
				for (int j = this.list_5.Count - 1; j >= 0; j--)
				{
					if (!this.list_5[j].gameObject_0)
					{
						if (this.list_5[j].renderTexture_0)
						{
							this.list_5[j].renderTexture_0.Release();
							Object.DestroyImmediate(this.list_5[j].renderTexture_0, true);
						}
						this.list_5.RemoveAt(j);
						j--;
					}
				}
			}
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0009DD40 File Offset: 0x0009BF40
		internal void method_201(ref Vector3 vector3_0, ref Quaternion quaternion_0)
		{
			this.method_95(ref vector3_0, ref quaternion_0);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0009DD58 File Offset: 0x0009BF58
		internal GameObject method_202(Texture texture_0, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					"Tile",
					"Clipped",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString(),
					"_",
					float_10.ToString(),
					"_",
					float_11.ToString(),
					"_",
					float_12.ToString(),
					"_",
					float_13.ToString()
				});
				GameObject gameObject = new GameObject(text);
				gameObject.AddComponent<CanvasRenderer>();
				RawImage rawImage = gameObject.AddComponent<RawImage>();
				gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(float_8 * this.method_151(), float_9 * this.method_105());
				gameObject.GetComponent<RectTransform>().position = new Vector2(this.method_22() + float_8 * this.method_151() / 2f, this.method_51() + float_9 * this.method_105() / 2f);
				this.method_61(this.float_6 + float_8 * this.method_151(), this.float_7 - float_9 * this.method_151());
				gameObject.transform.SetParent(this.gameObject_0.transform, false);
				rawImage.texture = texture_0;
				rawImage.color = this.color_0;
				Rect uvRect = rawImage.uvRect;
				Vector2 vector = rawImage.uvRect.position;
				vector.x = float_10 / (float)texture_0.width;
				vector.y = float_11 / (float)texture_0.height;
				uvRect.position = vector;
				vector = rawImage.uvRect.size;
				vector.x = float_12 / (float)texture_0.width;
				vector.y = float_13 / (float)texture_0.height;
				uvRect.size = vector;
				rawImage.uvRect = uvRect;
				result = gameObject;
			}
			return result;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0009DFB0 File Offset: 0x0009C1B0
		private List<GameObject> method_203(string string_1)
		{
			GClass156.Class169 @class = new GClass156.Class169();
			@class.string_0 = string_1;
			return this.list_3.FindAll(new Predicate<GameObject>(@class.method_0));
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0009DFE4 File Offset: 0x0009C1E4
		internal void method_204(bool bool_0, bool bool_1)
		{
			this.method_187(bool_0, bool_1);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0009DFFC File Offset: 0x0009C1FC
		internal void method_205(GameObject gameObject_1, bool bool_0, bool bool_1 = false, float float_8 = 0f)
		{
			this.method_150(gameObject_1, bool_0, bool_1, float_8);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0009E018 File Offset: 0x0009C218
		internal GameObject method_206(GClass84.GStruct169 gstruct169_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Thickness",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < gstruct169_0.list_0.Count; i++)
				{
					list.Add(this.method_222((float)(gstruct169_0.list_0[i].int_0 - (int_4 + 1) / 2 + 1), (float)(gstruct169_0.list_0[i].int_1 - (int_4 + 1) / 2 + 1), gstruct169_0.list_1[i].int_0 + int_4 - 1, gstruct169_0.list_1[i].int_1 + int_4 - 1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0009E33C File Offset: 0x0009C53C
		private bool method_207(List<GameObject> list_6)
		{
			bool result = false;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (this.method_183(list_6[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0009E370 File Offset: 0x0009C570
		internal void method_208(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_10(list_6, int_4);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0009E388 File Offset: 0x0009C588
		internal void method_209(List<GClass84.GStruct160> list_6, int int_4)
		{
			this.method_97(list_6, int_4);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
		internal GameObject method_210(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Thickness",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			int num = (int_4 + 1) / 2 + 1;
			int num2 = int_4 - 1;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i] - num), (float)(list_7[i] - num), list_8[i] + num2, list_9[i] + num2));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0009E774 File Offset: 0x0009C974
		internal bool method_211(GameObject gameObject_1, Texture texture_0)
		{
			RawImage componentInChildren = gameObject_1.GetComponentInChildren<RawImage>();
			bool result;
			if (!componentInChildren)
			{
				result = false;
			}
			else if (componentInChildren.texture == texture_0)
			{
				result = true;
			}
			else
			{
				bool flag = false;
				RawImage[] array = gameObject_1.GetComponentsInChildren<RawImage>();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					array[i].texture = texture_0;
					flag = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0009E7E4 File Offset: 0x0009C9E4
		internal void method_212(List<Color> list_6, int int_4)
		{
			this.method_233(list_6, int_4);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0009E7FC File Offset: 0x0009C9FC
		internal void method_213(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_223(list_6, int_4, int_5);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0009E814 File Offset: 0x0009CA14
		internal void method_214(GClass169 gclass169_0, bool bool_0, bool bool_1, float float_8)
		{
			if (gclass169_0 != null)
			{
				if (bool_1)
				{
					this.method_232(false, true);
				}
				bool wireframe = GL.wireframe;
				GL.wireframe = bool_0;
				Mesh mesh = null;
				GClass169.GEnum79 genum79_ = gclass169_0.genum79_0;
				GClass169.GEnum79 genum = genum79_;
				if (genum != GClass169.GEnum79.const_2)
				{
					if (genum == GClass169.GEnum79.const_8)
					{
						mesh = gclass169_0.mesh_0;
					}
				}
				else
				{
					mesh = gclass169_0.mesh_1;
				}
				if (mesh)
				{
					Graphics.DrawMesh(mesh, gclass169_0.vector3_1, gclass169_0.quaternion_0, gclass169_0.vmethod_30(), 0);
				}
				GL.wireframe = wireframe;
			}
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0009E890 File Offset: 0x0009CA90
		internal GameObject method_215(GClass84.GStruct169 gstruct169_0)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < gstruct169_0.list_0.Count; i++)
				{
					list.Add(this.method_222((float)gstruct169_0.list_0[i].int_0, (float)gstruct169_0.list_0[i].int_1, gstruct169_0.list_1[i].int_0, gstruct169_0.list_1[i].int_1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0009EB7C File Offset: 0x0009CD7C
		internal void method_216(List<GClass84.GStruct160> list_6, int int_4, int int_5, int int_6)
		{
			this.method_188(list_6, int_4, int_5, int_6);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0009EB98 File Offset: 0x0009CD98
		internal GameObject method_217(GClass84.GStruct169 gstruct169_0, GClass84.GStruct163 gstruct163_0, int int_4)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Offset",
				"Thickness",
				"_",
				gstruct169_0.list_0.Count.ToString(),
				"_",
				gstruct169_0.list_1.Count.ToString(),
				"_",
				"(",
				gstruct163_0.int_0.ToString(),
				",",
				gstruct163_0.int_1.ToString(),
				")",
				"_",
				int_4.ToString()
			});
			if (gstruct169_0.list_0.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_0[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = gstruct169_0.list_0[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = gstruct169_0.list_0[gstruct169_0.list_0.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (gstruct169_0.list_1.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = gstruct169_0.list_1[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = gstruct169_0.list_1[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = gstruct169_0.list_1[gstruct169_0.list_1.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < gstruct169_0.list_0.Count; i++)
				{
					list.Add(this.method_222((float)(gstruct169_0.list_0[i].int_0 + gstruct163_0.int_0 - (int_4 + 1) / 2 + 1), (float)(gstruct169_0.list_0[i].int_1 + gstruct163_0.int_0 - (int_4 + 1) / 2 + 1), gstruct169_0.list_1[i].int_0 + int_4 - 1, gstruct169_0.list_1[i].int_1 + int_4 - 1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0009EF1C File Offset: 0x0009D11C
		internal GameObject method_218(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4, int int_5)
		{
			string text = string.Concat(new string[]
			{
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString(),
				"_",
				int_5.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			List<GameObject> list = new List<GameObject>();
			int count = list_6.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(this.method_45((float)(list_6[i] + int_4), (float)(list_7[i] + int_5), list_8[i], list_9[i]));
			}
			GClass84.smethod_1233<GameObject>(list);
			GameObject result;
			if (list.Count > 0)
			{
				GameObject gameObject = this.method_168(text);
				GClass84.smethod_1477(list, gameObject);
				list.Clear();
				result = gameObject;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0009F2DC File Offset: 0x0009D4DC
		private bool method_219(GameObject gameObject_1)
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				if (this.list_2[i] == gameObject_1)
				{
					this.list_2.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0009F328 File Offset: 0x0009D528
		private List<GameObject> method_220(string string_1, GClass156.Enum10 enum10_0)
		{
			List<GameObject> result;
			switch (enum10_0)
			{
			case GClass156.Enum10.const_0:
				result = this.method_155(string_1);
				break;
			case GClass156.Enum10.const_1:
				result = this.method_98(string_1);
				break;
			case GClass156.Enum10.const_2:
				result = this.method_83(string_1);
				break;
			case GClass156.Enum10.const_3:
				result = this.method_203(string_1);
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0009F37C File Offset: 0x0009D57C
		internal GameObject method_221(List<int> list_6, List<int> list_7, List<int> list_8, List<int> list_9, int int_4, int int_5)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"X",
				"Y",
				"Offset",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString(),
				"_",
				list_8.Count.ToString(),
				"_",
				list_9.Count.ToString(),
				"_",
				int_4.ToString(),
				"_",
				int_5.ToString()
			});
			if (list_6.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_6[0].ToString(),
					"_",
					list_6[0].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString(),
					"_",
					list_6[list_6.Count - 1].ToString()
				});
			}
			if (list_7.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_7[0].ToString(),
					"_",
					list_7[0].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString(),
					"_",
					list_7[list_7.Count - 1].ToString()
				});
			}
			if (list_8.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_8[0].ToString(),
					"_",
					list_8[0].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString(),
					"_",
					list_8[list_8.Count - 1].ToString()
				});
			}
			if (list_9.Count > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"_",
					list_9[0].ToString(),
					"_",
					list_9[0].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString(),
					"_",
					list_9[list_9.Count - 1].ToString()
				});
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)(list_6[i] + int_4), (float)(list_7[i] + int_5), list_8[i], list_9[i], GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0009F78C File Offset: 0x0009D98C
		internal GameObject method_222(float float_8, float float_9, int int_4, int int_5, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_1)
		{
			this.method_61(float_8 - 1f, float_9 - 1f);
			return this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_5, 0f, 0f, 1f, 1f, enum10_0);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		internal void method_223(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)(j * int_5), (float)(i * int_5 + int_4));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0009F878 File Offset: 0x0009DA78
		internal void method_224(List<GClass84.GStruct160> list_6, int int_4, int int_5)
		{
			this.method_47(list_6, int_4, int_5);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0009F890 File Offset: 0x0009DA90
		internal GameObject method_225(List<GClass84.GStruct163> list_6, List<GClass84.GStruct163> list_7)
		{
			string text = string.Concat(new string[]
			{
				"Temp",
				"Vectors",
				"Optimize",
				"Fix",
				"_",
				list_6.Count.ToString(),
				"_",
				list_7.Count.ToString()
			});
			if (list_6.Count > 0)
			{
				string[] array = new string[9];
				array[0] = text;
				array[1] = "_";
				int num = 2;
				GClass84.GStruct163 gstruct = list_6[0];
				array[num] = gstruct.int_0.ToString();
				array[3] = "_";
				int num2 = 4;
				gstruct = list_6[0];
				array[num2] = gstruct.int_0.ToString();
				array[5] = "_";
				int num3 = 6;
				gstruct = list_6[list_6.Count - 1];
				array[num3] = gstruct.int_0.ToString();
				array[7] = "_";
				int num4 = 8;
				gstruct = list_6[list_6.Count - 1];
				array[num4] = gstruct.int_0.ToString();
				text = string.Concat(array);
			}
			if (list_7.Count > 0)
			{
				string[] array2 = new string[9];
				array2[0] = text;
				array2[1] = "_";
				int num5 = 2;
				GClass84.GStruct163 gstruct = list_7[0];
				array2[num5] = gstruct.int_0.ToString();
				array2[3] = "_";
				int num6 = 4;
				gstruct = list_7[0];
				array2[num6] = gstruct.int_0.ToString();
				array2[5] = "_";
				int num7 = 6;
				gstruct = list_7[list_7.Count - 1];
				array2[num7] = gstruct.int_0.ToString();
				array2[7] = "_";
				int num8 = 8;
				gstruct = list_7[list_7.Count - 1];
				array2[num8] = gstruct.int_0.ToString();
				text = string.Concat(array2);
			}
			GameObject gameObject = this.method_196(text, GClass156.Enum10.const_2);
			GameObject result;
			if (gameObject)
			{
				gameObject.tag = "Untagged";
				this.method_166(gameObject, this.color_0);
				result = gameObject;
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int count = list_6.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.method_222((float)list_6[i].int_0, (float)list_6[i].int_1, list_7[i].int_0, list_7[i].int_1, GClass156.Enum10.const_3));
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject2 = this.method_75(text, GClass156.Enum10.const_2);
					GClass84.smethod_1477(list, gameObject2);
					list.Clear();
					result = gameObject2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0009FB20 File Offset: 0x0009DD20
		internal void method_226(List<Color> list_6, int int_4, int int_5)
		{
			this.method_115(list_6, int_4, int_5);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0009FB38 File Offset: 0x0009DD38
		internal GameObject method_227(Texture texture_0, float float_8, float float_9, float float_10, float float_11, float float_12, float float_13, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_1)
		{
			GameObject result;
			if (!this.gameObject_0)
			{
				result = null;
			}
			else if (!texture_0 || float_8 == 0f || float_9 == 0f)
			{
				result = null;
			}
			else
			{
				string text = string.Concat(new string[]
				{
					"Temp",
					"Tile",
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					float_8.ToString(),
					"_",
					float_9.ToString(),
					"_",
					float_10.ToString(),
					"_",
					float_11.ToString(),
					"_",
					float_12.ToString(),
					"_",
					float_13.ToString()
				});
				GameObject gameObject = this.method_196(text, enum10_0);
				if (gameObject)
				{
					gameObject.tag = "Untagged";
					this.method_11(gameObject, texture_0, this.color_0);
					result = gameObject;
				}
				else
				{
					float_11 = 1f - float_11 - float_13;
					GameObject gameObject2 = new GameObject(text);
					gameObject2.AddComponent<CanvasRenderer>();
					RawImage rawImage = gameObject2.AddComponent<RawImage>();
					RectTransform component = gameObject2.GetComponent<RectTransform>();
					component.sizeDelta = new Vector2(float_8, float_9);
					component.position = new Vector2(this.method_22() + float_8 / 2f, this.method_51() - float_9 / 2f);
					this.method_61(this.float_6 + float_8, this.float_7);
					gameObject2.transform.SetParent(this.gameObject_0.transform, false);
					rawImage.texture = texture_0;
					rawImage.color = this.color_0;
					Rect uvRect = rawImage.uvRect;
					Vector2 vector = rawImage.uvRect.position;
					vector.x = float_10 / (float)texture_0.width;
					vector.y = float_11 / (float)texture_0.height;
					uvRect.position = vector;
					vector = rawImage.uvRect.size;
					vector.x = float_12 / (float)texture_0.width;
					vector.y = float_13 / (float)texture_0.height;
					uvRect.size = vector;
					rawImage.uvRect = uvRect;
					this.method_229(gameObject2, enum10_0);
					result = gameObject2;
				}
			}
			return result;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0009FDB0 File Offset: 0x0009DFB0
		internal void method_228(List<Color> list_6, int int_4, int int_5)
		{
			this.method_60(list_6, int_4, int_5);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0009FDC8 File Offset: 0x0009DFC8
		private bool method_229(GameObject gameObject_1, GClass156.Enum10 enum10_0 = GClass156.Enum10.const_0)
		{
			bool result;
			switch (enum10_0)
			{
			case GClass156.Enum10.const_0:
				result = this.method_33(gameObject_1);
				break;
			case GClass156.Enum10.const_1:
				result = this.method_183(gameObject_1);
				break;
			case GClass156.Enum10.const_2:
				result = this.method_124(gameObject_1);
				break;
			case GClass156.Enum10.const_3:
				result = this.method_4(gameObject_1);
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0009FE1C File Offset: 0x0009E01C
		internal GameObject method_230(string string_1, bool bool_0 = false)
		{
			GameObject result;
			if (this.float_0 == 0f || this.float_1 == 0f)
			{
				result = null;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				bool flag = false;
				float num6 = this.float_6;
				float float_ = this.float_7;
				List<GameObject> list = new List<GameObject>();
				string string_2 = string.Concat(new string[]
				{
					"Text",
					"Clipped",
					"_",
					string_1,
					"_",
					this.float_6.ToString(),
					"_",
					this.float_7.ToString(),
					"_",
					this.float_0.ToString(),
					"_",
					this.float_1.ToString()
				});
				bool flag2 = false;
				bool flag3 = false;
				string text = GClass84.smethod_1428(string_1, 1);
				while (text != string.Empty)
				{
					if (bool_0 && !flag2 && text == "&")
					{
						flag2 = true;
						flag3 = true;
						text = "_";
					}
					if (text == " ")
					{
						num5 += (int)((float)this.int_3 * this.float_0);
						string_1 = GClass84.smethod_1204(string_1, 1, -1);
						flag = false;
						flag2 = false;
					}
					else
					{
						if (this.method_170(text, ref num, ref num2, ref num3, ref num4))
						{
							if (flag && (!flag2 || flag3))
							{
								num5 += this.int_2;
							}
							this.method_61(num6 + (float)num5, float_);
							list.Add(this.method_202(GClass153.GClass87.texture2D_6, (float)num3 * this.float_0, (float)num4 * this.float_1, (float)num, (float)num2, (float)num3, (float)num4));
							if (!flag3)
							{
								num5 += (int)((float)num3 * this.float_0 * this.method_151());
							}
							flag = true;
						}
						if (!flag3)
						{
							flag2 = false;
						}
						string_1 = GClass84.smethod_1204(string_1, 1, -1);
						flag3 = false;
					}
					text = GClass84.smethod_1428(string_1, 1);
				}
				GClass84.smethod_1233<GameObject>(list);
				if (list.Count > 0)
				{
					GameObject gameObject = this.method_168(string_2);
					GClass84.smethod_1477(list, gameObject);
					list.Clear();
					result = gameObject;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000A005C File Offset: 0x0009E25C
		internal void method_231(List<GClass84.GStruct160> list_6, int int_4)
		{
			int count = list_6.Count;
			if (count > 0)
			{
				int count2 = list_6[0].list_0.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < count2; j++)
					{
						this.method_61((float)j, (float)(i + int_4));
						this.color_0 = list_6[i].list_0[j];
						this.method_227(GClass153.GClass87.texture2D_0, 1f, 1f, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
					}
				}
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000A00FC File Offset: 0x0009E2FC
		internal void method_232(bool bool_0 = false, bool bool_1 = false)
		{
			this.method_204(bool_0, bool_1);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000A0114 File Offset: 0x0009E314
		public override void vmethod_9()
		{
			this.method_113();
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000A0128 File Offset: 0x0009E328
		internal void method_233(List<Color> list_6, int int_4)
		{
			this.method_99(list_6, int_4);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000A0140 File Offset: 0x0009E340
		internal void method_234(List<Color> list_6, int int_4)
		{
			int count = list_6.Count;
			this.method_61(0f, 0f);
			for (int i = 0; i < count; i++)
			{
				this.color_0 = list_6[i];
				this.method_227(GClass153.GClass87.texture2D_0, (float)int_4, (float)int_4, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000A01A4 File Offset: 0x0009E3A4
		internal void method_235(List<Color> list_6)
		{
			this.method_20(list_6);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000A01B8 File Offset: 0x0009E3B8
		internal void method_236(string string_1, ref float float_8, ref float float_9)
		{
			this.method_110(string_1, ref float_8, ref float_9);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000A01D0 File Offset: 0x0009E3D0
		internal void method_237(Texture texture_0, float float_8, float float_9, float float_10)
		{
			this.method_227(texture_0, float_8, float_9, (this.float_6 - this.float_2) * float_10, (this.float_7 - this.float_3) * float_10, float_8 * float_10, float_9 * float_10, GClass156.Enum10.const_1);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000A0210 File Offset: 0x0009E410
		internal void method_238(int int_4, float float_8)
		{
			this.method_193(int_4, float_8);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000A0228 File Offset: 0x0009E428
		internal void method_239(Texture texture_0, float float_8)
		{
			if (texture_0 != null)
			{
				this.method_227(texture_0, (float)texture_0.width * float_8, (float)texture_0.height * float_8, 0f, 0f, (float)texture_0.width, (float)texture_0.height, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000A0274 File Offset: 0x0009E474
		internal static Color smethod_1(float float_8, float float_9, float float_10, float float_11 = 0f)
		{
			return new Color(float_8, float_9, float_10, GClass84.smethod_108<float>(float_11 == 0f, 1f, float_11));
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000A02A0 File Offset: 0x0009E4A0
		private bool method_240(GameObject gameObject_1)
		{
			this.method_55(gameObject_1);
			this.method_219(gameObject_1);
			this.method_114(gameObject_1);
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i] == gameObject_1)
				{
					this.list_0.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000A0304 File Offset: 0x0009E504
		internal void method_241()
		{
			GClass84.list_5.Add(new Action(this.vmethod_9));
			GClass84.list_7.Add(new Action(this.vmethod_15));
			this.method_197();
		}

		// Token: 0x040011C3 RID: 4547
		internal float float_0 = 1f;

		// Token: 0x040011C4 RID: 4548
		internal float float_1 = 1f;

		// Token: 0x040011C5 RID: 4549
		internal float float_2 = 0f;

		// Token: 0x040011C6 RID: 4550
		internal float float_3 = 0f;

		// Token: 0x040011C7 RID: 4551
		internal float float_4 = (float)Screen.width;

		// Token: 0x040011C8 RID: 4552
		internal float float_5 = (float)Screen.height;

		// Token: 0x040011C9 RID: 4553
		internal int int_0 = Screen.width;

		// Token: 0x040011CA RID: 4554
		internal int int_1 = Screen.height;

		// Token: 0x040011CB RID: 4555
		internal float float_6 = 0f;

		// Token: 0x040011CC RID: 4556
		internal float float_7 = 0f;

		// Token: 0x040011CD RID: 4557
		internal Color color_0 = Color.white;

		// Token: 0x040011CE RID: 4558
		private int int_2 = 1;

		// Token: 0x040011CF RID: 4559
		private int int_3 = 4;

		// Token: 0x040011D0 RID: 4560
		internal GameObject gameObject_0;

		// Token: 0x040011D1 RID: 4561
		private List<GameObject> list_0 = new List<GameObject>();

		// Token: 0x040011D2 RID: 4562
		private List<GameObject> list_1 = new List<GameObject>();

		// Token: 0x040011D3 RID: 4563
		private List<GameObject> list_2 = new List<GameObject>();

		// Token: 0x040011D4 RID: 4564
		private List<GameObject> list_3 = new List<GameObject>();

		// Token: 0x040011D5 RID: 4565
		private List<GClass156.Struct21> list_4 = new List<GClass156.Struct21>();

		// Token: 0x040011D6 RID: 4566
		private List<GClass156.Struct22> list_5 = new List<GClass156.Struct22>();

		// Token: 0x02000290 RID: 656
		internal enum Enum10
		{
			// Token: 0x040011D8 RID: 4568
			const_0,
			// Token: 0x040011D9 RID: 4569
			const_1,
			// Token: 0x040011DA RID: 4570
			const_2,
			// Token: 0x040011DB RID: 4571
			const_3
		}

		// Token: 0x02000291 RID: 657
		private struct Struct21
		{
			// Token: 0x06001EFF RID: 7935 RVA: 0x000A0348 File Offset: 0x0009E548
			public Struct21(string string_1, int int_4, int int_5, int int_6, int int_7)
			{
				this.string_0 = string_1;
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
			}

			// Token: 0x040011DC RID: 4572
			public string string_0;

			// Token: 0x040011DD RID: 4573
			public int int_0;

			// Token: 0x040011DE RID: 4574
			public int int_1;

			// Token: 0x040011DF RID: 4575
			public int int_2;

			// Token: 0x040011E0 RID: 4576
			public int int_3;
		}

		// Token: 0x02000292 RID: 658
		private struct Struct22
		{
			// Token: 0x06001F00 RID: 7936 RVA: 0x000A037C File Offset: 0x0009E57C
			public Struct22(RenderTexture renderTexture_1, GameObject gameObject_1)
			{
				this.renderTexture_0 = renderTexture_1;
				this.gameObject_0 = gameObject_1;
			}

			// Token: 0x040011E1 RID: 4577
			public RenderTexture renderTexture_0;

			// Token: 0x040011E2 RID: 4578
			public GameObject gameObject_0;
		}

		// Token: 0x02000293 RID: 659
		[CompilerGenerated]
		private sealed class Class161
		{
			// Token: 0x06001F02 RID: 7938 RVA: 0x000A0398 File Offset: 0x0009E598
			internal bool method_0(GClass156.Struct21 struct21_0)
			{
				return struct21_0.string_0 == this.string_0;
			}

			// Token: 0x040011E3 RID: 4579
			public string string_0;
		}

		// Token: 0x02000294 RID: 660
		[CompilerGenerated]
		private sealed class Class162
		{
			// Token: 0x06001F04 RID: 7940 RVA: 0x000A03B8 File Offset: 0x0009E5B8
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.name == this.string_0;
			}

			// Token: 0x040011E4 RID: 4580
			public string string_0;
		}

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		private sealed class Class163
		{
			// Token: 0x06001F06 RID: 7942 RVA: 0x000A03E4 File Offset: 0x0009E5E4
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.name == this.string_0;
			}

			// Token: 0x040011E5 RID: 4581
			public string string_0;
		}

		// Token: 0x02000296 RID: 662
		[CompilerGenerated]
		private sealed class Class164
		{
			// Token: 0x06001F08 RID: 7944 RVA: 0x000A0410 File Offset: 0x0009E610
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.name == this.string_0;
			}

			// Token: 0x040011E6 RID: 4582
			public string string_0;
		}

		// Token: 0x02000297 RID: 663
		[CompilerGenerated]
		private sealed class Class165
		{
			// Token: 0x06001F0A RID: 7946 RVA: 0x000A043C File Offset: 0x0009E63C
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.name == this.string_0;
			}

			// Token: 0x040011E7 RID: 4583
			public string string_0;
		}

		// Token: 0x02000298 RID: 664
		[CompilerGenerated]
		private sealed class Class166
		{
			// Token: 0x06001F0C RID: 7948 RVA: 0x000A0468 File Offset: 0x0009E668
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.tag == this.string_0;
			}

			// Token: 0x040011E8 RID: 4584
			public string string_0;
		}

		// Token: 0x02000299 RID: 665
		[CompilerGenerated]
		private sealed class Class167
		{
			// Token: 0x06001F0E RID: 7950 RVA: 0x000A0494 File Offset: 0x0009E694
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.tag == this.string_0;
			}

			// Token: 0x040011E9 RID: 4585
			public string string_0;
		}

		// Token: 0x0200029A RID: 666
		[CompilerGenerated]
		private sealed class Class168
		{
			// Token: 0x06001F10 RID: 7952 RVA: 0x000A04C0 File Offset: 0x0009E6C0
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.tag == this.string_0;
			}

			// Token: 0x040011EA RID: 4586
			public string string_0;
		}

		// Token: 0x0200029B RID: 667
		[CompilerGenerated]
		private sealed class Class169
		{
			// Token: 0x06001F12 RID: 7954 RVA: 0x000A04EC File Offset: 0x0009E6EC
			internal bool method_0(GameObject gameObject_0)
			{
				return gameObject_0 != null && gameObject_0.tag == this.string_0;
			}

			// Token: 0x040011EB RID: 4587
			public string string_0;
		}
	}
}
