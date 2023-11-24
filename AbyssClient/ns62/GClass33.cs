using System;
using ns241;
using ns410;
using ns53;
using ns55;
using TMPro;
using UnityEngine;

namespace ns62
{
	// Token: 0x020002B2 RID: 690
	public class GClass33 : GClass26
	{
		// Token: 0x06001FF0 RID: 8176 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
		internal void method_17(Color color_2)
		{
			this.method_23(color_2);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000A4AC8 File Offset: 0x000A2CC8
		internal void method_18(Color color_2)
		{
			this.textMeshProUGUI_0.color = color_2;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000A4AE4 File Offset: 0x000A2CE4
		internal void method_19(string string_3)
		{
			this.method_20(string_3);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000A4AF8 File Offset: 0x000A2CF8
		internal void method_20(string string_3)
		{
			this.method_32(string_3);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000A4B0C File Offset: 0x000A2D0C
		internal void method_21(Color color_2)
		{
			this.method_30(color_2);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000A4B20 File Offset: 0x000A2D20
		internal void method_22(Color color_2)
		{
			this.method_17(color_2);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000A4B34 File Offset: 0x000A2D34
		internal void method_23(Color color_2)
		{
			this.textMeshProUGUI_1.color = color_2;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000A4B50 File Offset: 0x000A2D50
		private void method_24(Transform transform_0, string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.string_1 = "Header";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_21(), transform_0, true);
			this.gameObject_1 = this.gameObject_0.transform.Find("LeftItemContainer/Text_Title").gameObject;
			this.textMeshProUGUI_0 = this.gameObject_1.GetComponent<TextMeshProUGUI>();
			this.method_25(string_4);
			if (nullable_0 != null)
			{
				this.method_21(nullable_0.Value);
			}
			if (nullable_1 != null)
			{
				this.method_22(nullable_1.Value);
			}
			base.method_11(true);
			GClass25.list_4.Add(this);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		internal void method_25(string string_3)
		{
			this.method_31(string_3);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000A4C04 File Offset: 0x000A2E04
		public GClass33(string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.string_0 = string_3;
			this.method_28(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000A4C2C File Offset: 0x000A2E2C
		private void method_26(Transform transform_0, string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.method_33(transform_0, string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000A4C50 File Offset: 0x000A2E50
		private void method_27(string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_34(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000A4C70 File Offset: 0x000A2E70
		private void method_28(string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.method_27(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000A4C90 File Offset: 0x000A2E90
		internal void method_29(string string_3)
		{
			this.textMeshProUGUI_0.text = string_3;
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000A4CAC File Offset: 0x000A2EAC
		internal void method_30(Color color_2)
		{
			this.method_18(color_2);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000A4CC0 File Offset: 0x000A2EC0
		internal void method_31(string string_3)
		{
			this.method_29(string_3);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000A4CD4 File Offset: 0x000A2ED4
		internal void method_32(string string_3)
		{
			this.textMeshProUGUI_1.text = string_3;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000A4CF0 File Offset: 0x000A2EF0
		private void method_33(Transform transform_0, string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_24(transform_0, string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000A4D14 File Offset: 0x000A2F14
		private void method_34(string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_26(GClass124.smethod_8(GClass84.smethod_195().Find(this.string_0)), string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x0400127A RID: 4730
		private GameObject gameObject_1;

		// Token: 0x0400127B RID: 4731
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x0400127C RID: 4732
		private GameObject gameObject_2;

		// Token: 0x0400127D RID: 4733
		private TextMeshProUGUI textMeshProUGUI_1;
	}
}
