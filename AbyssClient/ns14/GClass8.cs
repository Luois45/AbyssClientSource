using System;
using ns174;
using ns205;
using ns241;
using ns290;
using ns49;
using ns559;
using ns8;
using UnityEngine;
using UnityEngine.UI;

namespace ns14
{
	// Token: 0x02000325 RID: 805
	public class GClass8 : GClass2
	{
		// Token: 0x06004138 RID: 16696 RVA: 0x000F777C File Offset: 0x000F597C
		internal void method_17(Color color_2, bool bool_1)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_1)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x000F77A4 File Offset: 0x000F59A4
		private void method_18(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.method_32(transform_0, float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x000F77DC File Offset: 0x000F59DC
		public GClass8(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_29(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x000F7824 File Offset: 0x000F5A24
		public GClass8(string string_3, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_29(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x000F7864 File Offset: 0x000F5A64
		internal void method_19(Action<float> action_1)
		{
			this.action_0 = action_1;
			GClass84.smethod_1308(this.gameObject_0.GetComponent<Slider>(), new Action<float>(this.method_33));
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000F789C File Offset: 0x000F5A9C
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.string_1 = "SliderButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_30(), transform_0, true);
			this.gameObject_1 = this.gameObject_0.transform.Find("SliderLabel").gameObject;
			this.gameObject_2 = this.gameObject_0.transform.Find("FillArea/Fill").gameObject;
			if (float_2 != 1f || float_3 != 1f)
			{
				RectTransform component = this.gameObject_0.GetComponent<RectTransform>();
				if (component)
				{
					Vector2 sizeDelta = component.sizeDelta;
					sizeDelta.x *= float_2;
					sizeDelta.y *= float_3;
					component.sizeDelta = sizeDelta;
				}
			}
			this.int_0[0] = -1;
			this.int_0[1] = 0;
			this.method_26(float_0, float_1);
			this.method_21(action_1);
			if (nullable_0 != null)
			{
				this.vmethod_1(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<RawImage>().color;
			}
			if (nullable_1 != null)
			{
				this.gameObject_2.GetComponent<RawImage>().color = nullable_1.Value;
			}
			if (texture_0 != null)
			{
				this.vmethod_0(texture_0);
			}
			base.method_6(true);
			this.bool_0 = bool_1;
			this.method_34(float_4, false);
			GClass199.list_8.Add(this);
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000F7A04 File Offset: 0x000F5C04
		internal void method_21(Action<float> action_1)
		{
			this.method_22(action_1);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000F7A18 File Offset: 0x000F5C18
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_37(texture_0);
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x000F7A2C File Offset: 0x000F5C2C
		internal void method_22(Action<float> action_1)
		{
			this.method_19(action_1);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x000F7A40 File Offset: 0x000F5C40
		internal void method_23(float float_0)
		{
			this.method_34(float_0, true);
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x000F7A58 File Offset: 0x000F5C58
		public GClass8(GClass66 gclass66_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_29(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x000F7AA4 File Offset: 0x000F5CA4
		internal void method_24(float float_0, bool bool_1)
		{
			this.gameObject_0.GetComponent<Slider>().m_Value = float_0;
			this.gameObject_1.GetComponent<Text>().text = ((int)(float_0 * 100f)).ToString() + "%";
			try
			{
				if (bool_1)
				{
					this.action_0(float_0);
				}
			}
			catch
			{
			}
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000F7B18 File Offset: 0x000F5D18
		internal void method_25(float float_0, float float_1)
		{
			this.gameObject_0.GetComponent<RectTransform>().anchoredPosition = Vector2.right * (128f + 256f * (float_0 + (float)this.int_0[0])) + Vector2.down * (128f + 256f * (float_1 + (float)this.int_0[1]));
			this.string_2 = string.Concat(new string[]
			{
				"(",
				float_0.ToString(),
				",",
				float_1.ToString(),
				")"
			});
			this.gameObject_0.name = this.string_0 + "/" + this.string_1 + this.string_2;
			this.gameObject_0.GetComponent<Slider>().name = this.string_1 + this.string_2;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000F7C04 File Offset: 0x000F5E04
		internal void method_26(float float_0, float float_1)
		{
			this.method_28(float_0, float_1);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x000F7C1C File Offset: 0x000F5E1C
		private void method_27(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_38(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x000F7C50 File Offset: 0x000F5E50
		internal void method_28(float float_0, float float_1)
		{
			this.method_25(float_0, float_1);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x000F7C68 File Offset: 0x000F5E68
		public GClass8(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_29(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x000F7CB0 File Offset: 0x000F5EB0
		private void method_29(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.method_27(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_30(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x000F7CE4 File Offset: 0x000F5EE4
		internal void method_31(float float_0)
		{
			this.method_23(float_0);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x000F7CF8 File Offset: 0x000F5EF8
		private void method_32(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_20(transform_0, float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000F7D30 File Offset: 0x000F5F30
		public GClass8(GClass24 gclass24_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_29(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x000F7D7C File Offset: 0x000F5F7C
		internal void method_33(float float_0)
		{
			this.method_31(float_0);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000F7D90 File Offset: 0x000F5F90
		public GClass8(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_29(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000F7DD8 File Offset: 0x000F5FD8
		public GClass8(GClass95 gclass95_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_29(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000F7E24 File Offset: 0x000F6024
		internal void method_34(float float_0, bool bool_1)
		{
			this.method_35(float_0, bool_1);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000F7E3C File Offset: 0x000F603C
		internal void method_35(float float_0, bool bool_1)
		{
			this.method_24(float_0, bool_1);
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000F7E54 File Offset: 0x000F6054
		internal override void vmethod_1(Color color_2, bool bool_1 = true)
		{
			this.method_36(color_2, bool_1);
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000F7E6C File Offset: 0x000F606C
		internal void method_36(Color color_2, bool bool_1)
		{
			this.method_17(color_2, bool_1);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000F7E84 File Offset: 0x000F6084
		public GClass8(string string_3, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_29(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x000F7ECC File Offset: 0x000F60CC
		internal void method_37(Texture texture_0)
		{
			this.method_30(texture_0);
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x000F7EE0 File Offset: 0x000F60E0
		private void method_38(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_18(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, this.bool_0, float_4, texture_0);
		}

		// Token: 0x04001991 RID: 6545
		internal GameObject gameObject_1;

		// Token: 0x04001992 RID: 6546
		internal GameObject gameObject_2;

		// Token: 0x04001993 RID: 6547
		internal bool bool_0 = false;

		// Token: 0x04001994 RID: 6548
		private Action<float> action_0 = null;
	}
}
