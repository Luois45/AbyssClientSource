using System;
using ns241;
using ns295;
using ns30;
using ns302;
using ns410;
using ns53;
using ns55;
using UnityEngine;
using UnityEngine.UI;

namespace ns60
{
	// Token: 0x02000254 RID: 596
	public class GClass31 : GClass26
	{
		// Token: 0x06001B80 RID: 7040 RVA: 0x0008B2D0 File Offset: 0x000894D0
		public GClass31(GClass97 gclass97_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_35(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0008B31C File Offset: 0x0008951C
		public GClass31(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_35(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0008B364 File Offset: 0x00089564
		public GClass31(string string_3, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_35(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0008B3A4 File Offset: 0x000895A4
		internal void method_17(float float_0, bool bool_1)
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

		// Token: 0x06001B84 RID: 7044 RVA: 0x0008B418 File Offset: 0x00089618
		internal void method_18(float float_0, float float_1)
		{
			this.method_27(float_0, float_1);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0008B430 File Offset: 0x00089630
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_21(texture_0);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0008B444 File Offset: 0x00089644
		private void method_19(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.string_1 = "SliderButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_19(), transform_0, true);
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
			this.method_18(float_0, float_1);
			this.method_26(action_1);
			if (nullable_0 != null)
			{
				this.vmethod_0(nullable_0.Value, true);
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
				this.vmethod_2(texture_0);
			}
			base.method_11(true);
			this.bool_0 = bool_1;
			this.method_22(float_4, false);
			GClass25.list_8.Add(this);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0008B5AC File Offset: 0x000897AC
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_19(transform_0, float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0008B5E4 File Offset: 0x000897E4
		internal void method_21(Texture texture_0)
		{
			this.method_29(texture_0);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0008B5F8 File Offset: 0x000897F8
		internal void method_22(float float_0, bool bool_1)
		{
			this.method_36(float_0, bool_1);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0008B610 File Offset: 0x00089810
		private void method_23(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.method_20(transform_0, float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0008B648 File Offset: 0x00089848
		public GClass31(GClass17 gclass17_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_35(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0008B694 File Offset: 0x00089894
		internal void method_24(float float_0)
		{
			this.method_28(float_0);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0008B6A8 File Offset: 0x000898A8
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

		// Token: 0x06001B8E RID: 7054 RVA: 0x0008B794 File Offset: 0x00089994
		internal void method_26(Action<float> action_1)
		{
			this.method_37(action_1);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0008B7A8 File Offset: 0x000899A8
		internal void method_27(float float_0, float float_1)
		{
			this.method_25(float_0, float_1);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0008B7C0 File Offset: 0x000899C0
		public GClass31(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_35(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0008B808 File Offset: 0x00089A08
		internal void method_28(float float_0)
		{
			this.method_30(float_0);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_29(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0008B81C File Offset: 0x00089A1C
		public GClass31(string string_3, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_35(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0008B864 File Offset: 0x00089A64
		internal void method_30(float float_0)
		{
			this.method_22(float_0, true);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0008B87C File Offset: 0x00089A7C
		internal void method_31(Color color_2, bool bool_1)
		{
			this.method_34(color_2, bool_1);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0008B894 File Offset: 0x00089A94
		private void method_32(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_38(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0008B8C8 File Offset: 0x00089AC8
		internal void method_33(Action<float> action_1)
		{
			this.action_0 = action_1;
			GClass84.smethod_1308(this.gameObject_0.GetComponent<Slider>(), new Action<float>(this.method_24));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00023248 File Offset: 0x00021448
		internal void method_34(Color color_2, bool bool_1)
		{
			this.gameObject_0.GetComponent<RawImage>().color = color_2;
			if (bool_1)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0008B900 File Offset: 0x00089B00
		private void method_35(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.method_32(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0008B934 File Offset: 0x00089B34
		public GClass31(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_4 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_35(float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, bool_1, float_4, texture_0);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0008B97C File Offset: 0x00089B7C
		internal override void vmethod_0(Color color_2, bool bool_1 = true)
		{
			this.method_31(color_2, bool_1);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0008B994 File Offset: 0x00089B94
		public GClass31(GClass99 gclass99_0, float float_0, float float_1, Action<float> action_1, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, float float_2 = 0f, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_35(float_0, float_1, 1f, 1f, action_1, nullable_0, nullable_1, bool_1, float_2, texture_0);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0008B9E0 File Offset: 0x00089BE0
		internal void method_36(float float_0, bool bool_1)
		{
			this.method_17(float_0, bool_1);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0008B9F8 File Offset: 0x00089BF8
		internal void method_37(Action<float> action_1)
		{
			this.method_33(action_1);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0008BA0C File Offset: 0x00089C0C
		private void method_38(float float_0, float float_1, float float_2, float float_3, Action<float> action_1, Color? nullable_0, Color? nullable_1, bool bool_1, float float_4, Texture texture_0)
		{
			this.method_23(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, action_1, nullable_0, nullable_1, this.bool_0, float_4, texture_0);
		}

		// Token: 0x0400102F RID: 4143
		internal GameObject gameObject_1;

		// Token: 0x04001030 RID: 4144
		internal GameObject gameObject_2;

		// Token: 0x04001031 RID: 4145
		internal bool bool_0 = false;

		// Token: 0x04001032 RID: 4146
		private Action<float> action_0 = null;
	}
}
