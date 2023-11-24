using System;
using ns205;
using ns241;
using ns559;
using ns8;
using TMPro;
using UnityEngine;

namespace ns16
{
	// Token: 0x0200039D RID: 925
	public class GClass10 : GClass2
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x0011A618 File Offset: 0x00118818
		internal void method_17(Color color_2)
		{
			this.method_27(color_2);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x0011A62C File Offset: 0x0011882C
		internal void method_18(string string_3)
		{
			this.method_32(string_3);
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x0011A640 File Offset: 0x00118840
		internal void method_19(Color color_2)
		{
			this.method_17(color_2);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x0011A654 File Offset: 0x00118854
		internal void method_20(string string_3)
		{
			this.method_30(string_3);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x0011A668 File Offset: 0x00118868
		internal void method_21(string string_3)
		{
			this.textMeshProUGUI_0.text = string_3;
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x0011A684 File Offset: 0x00118884
		internal void method_22(Color color_2)
		{
			this.method_28(color_2);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x0011A698 File Offset: 0x00118898
		internal void method_23(Color color_2)
		{
			this.textMeshProUGUI_0.color = color_2;
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x0011A6B4 File Offset: 0x001188B4
		private void method_24(Transform transform_0, string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.string_1 = "Header";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_8(), transform_0, true);
			this.gameObject_1 = this.gameObject_0.transform.Find("LeftItemContainer/Text_Title").gameObject;
			this.textMeshProUGUI_0 = this.gameObject_1.GetComponent<TextMeshProUGUI>();
			this.method_18(string_4);
			if (nullable_0 != null)
			{
				this.method_22(nullable_0.Value);
			}
			if (nullable_1 != null)
			{
				this.method_19(nullable_1.Value);
			}
			base.method_6(true);
			GClass199.list_4.Add(this);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x0011A754 File Offset: 0x00118954
		private void method_25(string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.method_26(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x0011A774 File Offset: 0x00118974
		private void method_26(string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_34(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x0011A794 File Offset: 0x00118994
		internal void method_27(Color color_2)
		{
			this.textMeshProUGUI_1.color = color_2;
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x0011A7B0 File Offset: 0x001189B0
		internal void method_28(Color color_2)
		{
			this.method_23(color_2);
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x0011A7C4 File Offset: 0x001189C4
		private void method_29(Transform transform_0, string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.method_33(transform_0, string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x0011A7E8 File Offset: 0x001189E8
		internal void method_30(string string_3)
		{
			this.textMeshProUGUI_1.text = string_3;
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x0011A804 File Offset: 0x00118A04
		public GClass10(string string_3, string string_4, string string_5 = "", Color? nullable_0 = null, Color? nullable_1 = null)
		{
			this.string_0 = string_3;
			this.method_25(string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x0011A82C File Offset: 0x00118A2C
		internal void method_31(string string_3)
		{
			this.method_20(string_3);
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x0011A840 File Offset: 0x00118A40
		internal void method_32(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x0011A854 File Offset: 0x00118A54
		private void method_33(Transform transform_0, string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_24(transform_0, string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x0011A878 File Offset: 0x00118A78
		private void method_34(string string_3, string string_4, string string_5, Color? nullable_0, Color? nullable_1)
		{
			this.method_29(GClass73.smethod_2(GClass84.smethod_195().Find(this.string_0)), string_3, string_4, string_5, nullable_0, nullable_1);
		}

		// Token: 0x04001D3E RID: 7486
		private GameObject gameObject_1;

		// Token: 0x04001D3F RID: 7487
		private TextMeshProUGUI textMeshProUGUI_0;

		// Token: 0x04001D40 RID: 7488
		private GameObject gameObject_2;

		// Token: 0x04001D41 RID: 7489
		private TextMeshProUGUI textMeshProUGUI_1;
	}
}
