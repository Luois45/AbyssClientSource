using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns174;
using ns205;
using ns241;
using ns290;
using ns49;
using ns559;
using ns8;
using UnityEngine;
using UnityEngine.UI;

namespace ns15
{
	// Token: 0x02000350 RID: 848
	public class GClass9 : GClass2
	{
		// Token: 0x06004720 RID: 18208 RVA: 0x0010D664 File Offset: 0x0010B864
		internal void method_17(bool bool_1, bool bool_2)
		{
			this.gameObject_1.SetActive(bool_1);
			this.gameObject_2.SetActive(!bool_1);
			try
			{
				if (bool_1 && bool_2)
				{
					this.action_0();
					this.list_0.ForEach(new Action<GClass2>(GClass9.Class202.class202_0.method_0));
					this.list_1.ForEach(new Action<GClass2>(GClass9.Class202.class202_0.method_1));
				}
				else if (!bool_1 && bool_2)
				{
					this.action_1();
					this.list_0.ForEach(new Action<GClass2>(GClass9.Class202.class202_0.method_2));
					this.list_1.ForEach(new Action<GClass2>(GClass9.Class202.class202_0.method_3));
				}
			}
			catch
			{
			}
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x0010D778 File Offset: 0x0010B978
		private void method_18()
		{
			this.method_28(true, true);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x0010D790 File Offset: 0x0010B990
		internal void method_19(string string_3)
		{
			this.method_41(string_3);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x0010D7A4 File Offset: 0x0010B9A4
		public GClass9(GClass24 gclass24_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_24(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x0010D814 File Offset: 0x0010BA14
		public GClass9(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_24(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x0010D880 File Offset: 0x0010BA80
		public GClass9(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_24(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0010D8EC File Offset: 0x0010BAEC
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_45(transform_0, float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0010D934 File Offset: 0x0010BB34
		private void method_21()
		{
			this.method_18();
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0010D948 File Offset: 0x0010BB48
		public GClass9(GClass95 gclass95_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_24(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0010D9B8 File Offset: 0x0010BBB8
		public GClass9(GClass66 gclass66_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_24(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0010DA28 File Offset: 0x0010BC28
		internal void method_22(string string_3)
		{
			this.method_19(string_3);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0010DA3C File Offset: 0x0010BC3C
		public GClass9(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, Action action_2, string string_5, Action action_3, string string_6, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_24(float_0, float_1, float_2, float_3, string_4, action_2, string_5, action_3, string_6, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		internal void method_23(Action action_2, Action action_3)
		{
			this.method_26(action_2, action_3);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0010DABC File Offset: 0x0010BCBC
		private void method_24(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_38(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0010DB00 File Offset: 0x0010BD00
		internal string method_25()
		{
			return this.method_46();
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0010DB14 File Offset: 0x0010BD14
		internal void method_26(Action action_2, Action action_3)
		{
			this.action_0 = action_2;
			this.action_1 = action_3;
			GClass84.smethod_243(this.gameObject_1.GetComponent<Button>(), new Action(this.method_47));
			GClass84.smethod_243(this.gameObject_2.GetComponent<Button>(), new Action(this.method_37));
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0010DB68 File Offset: 0x0010BD68
		internal override void vmethod_2(Color color_2, bool bool_1 = true)
		{
			this.method_40(color_2, bool_1);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0010DB80 File Offset: 0x0010BD80
		internal bool method_27(string string_3)
		{
			bool flag = false;
			UiTooltip component = this.gameObject_1.GetComponent<UiTooltip>();
			while (component)
			{
				component.field_Public_String_1 = string_3;
				component.field_Public_String_0 = string_3;
				if (flag)
				{
					break;
				}
				flag = true;
				component = this.gameObject_2.GetComponent<UiTooltip>();
			}
			return flag;
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0010DBC8 File Offset: 0x0010BDC8
		internal void method_28(bool bool_1, bool bool_2 = false)
		{
			this.method_33(bool_1, bool_2);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0010DBE0 File Offset: 0x0010BDE0
		private void method_29()
		{
			this.method_43();
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0010DBF4 File Offset: 0x0010BDF4
		internal void method_30(Action action_2, Action action_3)
		{
			this.method_23(action_2, action_3);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0010DC0C File Offset: 0x0010BE0C
		internal void method_31(Color color_2, bool bool_1)
		{
			this.method_35(color_2, bool_1);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0010DC24 File Offset: 0x0010BE24
		internal string method_32()
		{
			return this.gameObject_1.GetComponentsInChildren<Text>()[0].text;
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0010DC4C File Offset: 0x0010BE4C
		internal void method_33(bool bool_1, bool bool_2)
		{
			this.method_17(bool_1, bool_2);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0010DC64 File Offset: 0x0010BE64
		internal void method_34(Color color_2, bool bool_1)
		{
			if (bool_1)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0010DC7C File Offset: 0x0010BE7C
		internal void method_35(Color color_2, bool bool_1)
		{
			if (bool_1)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0010DC94 File Offset: 0x0010BE94
		internal void method_36(string string_3)
		{
			this.method_44(string_3);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x0010DCA8 File Offset: 0x0010BEA8
		[CompilerGenerated]
		private void method_37()
		{
			this.method_21();
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0010DCBC File Offset: 0x0010BEBC
		private void method_38(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_48(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0010DD00 File Offset: 0x0010BF00
		private void method_39(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.string_1 = "ToggleButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_6(), transform_0, true);
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
			this.gameObject_1 = this.gameObject_0.transform.Find("ON").gameObject;
			this.gameObject_2 = this.gameObject_0.transform.Find("OFF").gameObject;
			this.int_0[0] = -1;
			this.int_0[1] = 0;
			base.method_4(float_0, float_1);
			this.method_36(string_3);
			this.method_22(string_4);
			Text[] array = this.gameObject_1.GetComponentsInChildren<Text>();
			array[0].name = "Text_ON";
			array[0].resizeTextForBestFit = true;
			array[1].name = "Text_OFF";
			array[1].resizeTextForBestFit = true;
			Text[] array2 = this.gameObject_2.GetComponentsInChildren<Text>();
			array2[0].name = "Text_ON";
			array2[0].resizeTextForBestFit = true;
			array2[1].name = "Text_OFF";
			array2[1].resizeTextForBestFit = true;
			this.method_27(string_5);
			this.method_30(action_2, action_3);
			this.gameObject_1.SetActive(false);
			this.gameObject_2.SetActive(true);
			if (nullable_0 != null)
			{
				this.vmethod_1(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_1.GetComponentsInChildren<Text>().First<Text>().color;
			}
			if (nullable_1 != null)
			{
				this.vmethod_2(nullable_1.Value, true);
			}
			else
			{
				this.color_1 = this.gameObject_1.GetComponentsInChildren<RawImage>().First<RawImage>().color;
			}
			base.method_6(true);
			this.bool_0 = bool_1;
			if (bool_2)
			{
				this.method_28(true, false);
			}
			GClass199.list_10.Add(this);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0010DF20 File Offset: 0x0010C120
		internal void method_40(Color color_2, bool bool_1)
		{
			this.method_34(color_2, bool_1);
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0010DF38 File Offset: 0x0010C138
		internal void method_41(string string_3)
		{
			Text[] array = this.gameObject_1.GetComponentsInChildren<Text>();
			array[1].text = string_3;
			Text[] array2 = this.gameObject_2.GetComponentsInChildren<Text>();
			array2[1].text = string_3;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0010DF7C File Offset: 0x0010C17C
		internal void method_42(string string_3)
		{
			Text[] array = this.gameObject_1.GetComponentsInChildren<Text>();
			array[0].text = string_3;
			Text[] array2 = this.gameObject_2.GetComponentsInChildren<Text>();
			array2[0].text = string_3;
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0010DFC0 File Offset: 0x0010C1C0
		private void method_43()
		{
			this.method_28(false, true);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0010DFD8 File Offset: 0x0010C1D8
		public GClass9(string string_3, float float_0, float float_1, string string_4, Action action_2, string string_5, Action action_3, string string_6, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_24(float_0, float_1, 1f, 1f, string_4, action_2, string_5, action_3, string_6, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x0010E044 File Offset: 0x0010C244
		internal void method_44(string string_3)
		{
			this.method_42(string_3);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x0010E058 File Offset: 0x0010C258
		public GClass9(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_24(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x0010E0C4 File Offset: 0x0010C2C4
		private void method_45(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_39(transform_0, float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0010E10C File Offset: 0x0010C30C
		internal override void vmethod_1(Color color_2, bool bool_1 = true)
		{
			this.method_31(color_2, bool_1);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x0010E124 File Offset: 0x0010C324
		internal string method_46()
		{
			return this.method_32();
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0010E138 File Offset: 0x0010C338
		[CompilerGenerated]
		private void method_47()
		{
			this.method_29();
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0010E14C File Offset: 0x0010C34C
		private void method_48(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_20(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, this.bool_0, bool_2, texture_0);
		}

		// Token: 0x04001B85 RID: 7045
		internal GameObject gameObject_1;

		// Token: 0x04001B86 RID: 7046
		internal GameObject gameObject_2;

		// Token: 0x04001B87 RID: 7047
		internal List<GClass2> list_0 = new List<GClass2>();

		// Token: 0x04001B88 RID: 7048
		internal List<GClass2> list_1 = new List<GClass2>();

		// Token: 0x04001B89 RID: 7049
		internal bool bool_0 = false;

		// Token: 0x04001B8A RID: 7050
		private Action action_0 = null;

		// Token: 0x04001B8B RID: 7051
		private Action action_1 = null;

		// Token: 0x02000351 RID: 849
		[CompilerGenerated]
		[Serializable]
		private sealed class Class202
		{
			// Token: 0x0600474A RID: 18250 RVA: 0x00058574 File Offset: 0x00056774
			internal void method_0(GClass2 gclass2_0)
			{
				gclass2_0.method_6(true);
			}

			// Token: 0x0600474B RID: 18251 RVA: 0x00058588 File Offset: 0x00056788
			internal void method_1(GClass2 gclass2_0)
			{
				gclass2_0.method_6(false);
			}

			// Token: 0x0600474C RID: 18252 RVA: 0x00058588 File Offset: 0x00056788
			internal void method_2(GClass2 gclass2_0)
			{
				gclass2_0.method_6(false);
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x00058574 File Offset: 0x00056774
			internal void method_3(GClass2 gclass2_0)
			{
				gclass2_0.method_6(true);
			}

			// Token: 0x04001B8C RID: 7052
			public static readonly GClass9.Class202 class202_0 = new GClass9.Class202();

			// Token: 0x04001B8D RID: 7053
			public static Action<GClass2> action_0;

			// Token: 0x04001B8E RID: 7054
			public static Action<GClass2> action_1;

			// Token: 0x04001B8F RID: 7055
			public static Action<GClass2> action_2;

			// Token: 0x04001B90 RID: 7056
			public static Action<GClass2> action_3;
		}
	}
}
