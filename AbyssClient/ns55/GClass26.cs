using System;
using UnityEngine;
using UnityEngine.UI;

namespace ns55
{
	// Token: 0x02000047 RID: 71
	public class GClass26
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_0(Color color_2, bool bool_0 = true)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00007D3C File Offset: 0x00005F3C
		internal void method_0()
		{
			this.method_6();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00007D50 File Offset: 0x00005F50
		internal void method_1(bool bool_0)
		{
			this.method_16(bool_0);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007D64 File Offset: 0x00005F64
		internal string method_2()
		{
			return this.method_13();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00007D78 File Offset: 0x00005F78
		internal GameObject method_3()
		{
			return this.gameObject_0;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00007DB0 File Offset: 0x00005FB0
		internal void method_4(float float_0, float float_1)
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
			Button component = this.gameObject_0.GetComponent<Button>();
			if (component)
			{
				component.name = this.string_1 + this.string_2;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00007EA4 File Offset: 0x000060A4
		internal void method_5(bool bool_0)
		{
			this.method_8(bool_0);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00007EB8 File Offset: 0x000060B8
		internal void method_6()
		{
			this.method_12();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00007ECC File Offset: 0x000060CC
		internal void method_7(float float_0, float float_1)
		{
			this.method_4(float_0, float_1);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00007EE4 File Offset: 0x000060E4
		internal void method_8(bool bool_0)
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

		// Token: 0x0600028B RID: 651 RVA: 0x00007F70 File Offset: 0x00006170
		internal void method_9(bool bool_0)
		{
			this.method_5(bool_0);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007F84 File Offset: 0x00006184
		internal bool method_10(string string_3)
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

		// Token: 0x0600028D RID: 653 RVA: 0x00007FC0 File Offset: 0x000061C0
		internal void method_11(bool bool_0)
		{
			this.method_1(bool_0);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00007FD4 File Offset: 0x000061D4
		internal void method_12()
		{
			try
			{
				Object.Destroy(this.gameObject_0);
			}
			catch
			{
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_1(Color color_2, bool bool_0 = true)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008004 File Offset: 0x00006204
		internal string method_13()
		{
			return this.string_0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000801C File Offset: 0x0000621C
		internal string method_14()
		{
			return this.method_2();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual void vmethod_2(Texture texture_0)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008030 File Offset: 0x00006230
		internal void method_15(float float_0, float float_1)
		{
			this.method_7(float_0, float_1);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008048 File Offset: 0x00006248
		internal void method_16(bool bool_0)
		{
			this.gameObject_0.SetActive(bool_0);
		}

		// Token: 0x0400010A RID: 266
		protected GameObject gameObject_0;

		// Token: 0x0400010B RID: 267
		protected string string_0;

		// Token: 0x0400010C RID: 268
		protected string string_1;

		// Token: 0x0400010D RID: 269
		protected string string_2;

		// Token: 0x0400010E RID: 270
		protected int[] int_0 = new int[2];

		// Token: 0x0400010F RID: 271
		protected Color color_0;

		// Token: 0x04000110 RID: 272
		protected Color color_1;

		// Token: 0x04000111 RID: 273
		protected UiTooltip uiTooltip_0;
	}
}
