using System;
using UnityEngine;
using UnityEngine.UI;

namespace ns8
{
	// Token: 0x0200000F RID: 15
	public class GClass2
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000049D8 File Offset: 0x00002BD8
		internal void method_0()
		{
			try
			{
				Object.Destroy(this.gameObject_0);
			}
			catch
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004A08 File Offset: 0x00002C08
		internal void method_1(float float_0, float float_1)
		{
			this.method_5(float_0, float_1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004A20 File Offset: 0x00002C20
		internal string method_2()
		{
			return this.method_14();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004A34 File Offset: 0x00002C34
		internal string method_3()
		{
			return this.method_2();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004A48 File Offset: 0x00002C48
		internal void method_4(float float_0, float float_1)
		{
			this.method_1(float_0, float_1);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004A60 File Offset: 0x00002C60
		internal void method_5(float float_0, float float_1)
		{
			RectTransform component = this.gameObject_0.GetComponent<RectTransform>();
			component.anchoredPosition = Vector2.right * (128f + 256f * (float_0 + (float)this.int_0[0])) + Vector2.down * (128f + 256f * (float_1 + (float)this.int_0[1]));
			this.string_2 = string.Concat(new string[]
			{
				"(",
				float_0.ToString(),
				",",
				float_1.ToString(),
				")"
			});
			this.gameObject_0.name = this.string_0 + "/" + this.string_1 + this.string_2;
			Button component2 = this.gameObject_0.GetComponent<Button>();
			if (component2)
			{
				component2.name = this.string_1 + this.string_2;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004B58 File Offset: 0x00002D58
		internal void method_6(bool bool_0)
		{
			this.method_11(bool_0);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004B6C File Offset: 0x00002D6C
		internal bool method_7(string string_3)
		{
			bool result;
			if (this.uiTooltip_0)
			{
				this.uiTooltip_0.field_Public_String_1 = string_3;
				this.uiTooltip_0.field_Public_String_0 = string_3;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004BA8 File Offset: 0x00002DA8
		internal void method_8(bool bool_0)
		{
			this.method_15(bool_0);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004BBC File Offset: 0x00002DBC
		internal void method_9()
		{
			this.method_13();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004BD0 File Offset: 0x00002DD0
		internal void method_10(bool bool_0)
		{
			if (!bool_0)
			{
				new Color(0.5f, 0.5f, 0.5f, 1f);
				new Color(0.7f, 0.7f, 0.7f, 1f);
			}
			foreach (Button button in this.gameObject_0.GetComponents<Button>())
			{
				button.interactable = bool_0;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_0(Texture texture_0)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_1(Color color_2, bool bool_0 = true)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004C5C File Offset: 0x00002E5C
		internal void method_11(bool bool_0)
		{
			this.method_16(bool_0);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004C70 File Offset: 0x00002E70
		internal GameObject method_12()
		{
			return this.gameObject_0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004C88 File Offset: 0x00002E88
		internal void method_13()
		{
			this.method_0();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004C9C File Offset: 0x00002E9C
		internal string method_14()
		{
			return this.string_0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004CD4 File Offset: 0x00002ED4
		internal void method_15(bool bool_0)
		{
			this.method_10(bool_0);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_2(Color color_2, bool bool_0 = true)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004CE8 File Offset: 0x00002EE8
		internal void method_16(bool bool_0)
		{
			this.gameObject_0.SetActive(bool_0);
		}

		// Token: 0x04000058 RID: 88
		protected GameObject gameObject_0;

		// Token: 0x04000059 RID: 89
		protected string string_0;

		// Token: 0x0400005A RID: 90
		protected string string_1;

		// Token: 0x0400005B RID: 91
		protected string string_2;

		// Token: 0x0400005C RID: 92
		protected int[] int_0 = new int[2];

		// Token: 0x0400005D RID: 93
		protected Color color_0;

		// Token: 0x0400005E RID: 94
		protected Color color_1;

		// Token: 0x0400005F RID: 95
		protected UiTooltip uiTooltip_0;
	}
}
