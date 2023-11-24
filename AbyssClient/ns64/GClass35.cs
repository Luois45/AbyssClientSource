using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns241;
using ns295;
using ns30;
using ns302;
using ns410;
using ns53;
using ns55;
using UnityEngine;
using UnityEngine.UI;

namespace ns64
{
	// Token: 0x02000340 RID: 832
	public class GClass35 : GClass26
	{
		// Token: 0x060046D7 RID: 18135 RVA: 0x001097E8 File Offset: 0x001079E8
		[CompilerGenerated]
		private void method_17()
		{
			this.method_33();
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0002302C File Offset: 0x0002122C
		internal void method_18(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x001097FC File Offset: 0x001079FC
		internal override void vmethod_2(Texture texture_0)
		{
			this.method_31(texture_0);
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00109810 File Offset: 0x00107A10
		public GClass35(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_19(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00109874 File Offset: 0x00107A74
		private void method_19(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_29(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x001098A8 File Offset: 0x00107AA8
		public GClass35(GClass99 gclass99_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_19(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00109910 File Offset: 0x00107B10
		public GClass35(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_19(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00109974 File Offset: 0x00107B74
		public GClass35(GClass17 gclass17_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_19(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x001099DC File Offset: 0x00107BDC
		public GClass35(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_19(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00109A40 File Offset: 0x00107C40
		public GClass35(string string_3, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_19(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00109AA0 File Offset: 0x00107CA0
		internal void method_20(Color color_2, bool bool_1)
		{
			Selectable component = this.gameObject_0.GetComponent<Button>();
			ColorBlock colors = default(ColorBlock);
			colors.colorMultiplier = 1f;
			colors.disabledColor = Color.grey;
			colors.highlightedColor = color_2 * 1.5f;
			colors.normalColor = color_2 / 1.5f;
			colors.pressedColor = Color.grey * 1.5f;
			component.colors = colors;
			if (bool_1)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00109B24 File Offset: 0x00107D24
		public GClass35(string string_3, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_19(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00109B88 File Offset: 0x00107D88
		internal void method_21(bool bool_1, bool bool_2)
		{
			this.gameObject_1.SetActive(bool_1);
			try
			{
				if (bool_1 && bool_2)
				{
					this.action_0();
					this.list_0.ForEach(new Action<GClass26>(GClass35.Class190.class190_0.method_1));
					this.list_1.ForEach(new Action<GClass26>(GClass35.Class190.class190_0.method_0));
				}
				else if (!bool_1 && bool_2)
				{
					this.action_1();
					this.list_0.ForEach(new Action<GClass26>(GClass35.Class190.class190_0.method_2));
					this.list_1.ForEach(new Action<GClass26>(GClass35.Class190.class190_0.method_3));
				}
			}
			catch
			{
			}
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00109C8C File Offset: 0x00107E8C
		private void method_22(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_34(transform_0, float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x00109CC4 File Offset: 0x00107EC4
		internal void method_23(Action action_2, Action action_3)
		{
			this.method_26(action_2, action_3);
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00109CDC File Offset: 0x00107EDC
		private void method_24(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_22(transform_0, float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x00109D14 File Offset: 0x00107F14
		internal void method_25(Color color_2, bool bool_1)
		{
			this.method_20(color_2, bool_1);
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x00109D2C File Offset: 0x00107F2C
		internal void method_26(Action action_2, Action action_3)
		{
			this.method_32(action_2, action_3);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00109D44 File Offset: 0x00107F44
		public GClass35(GClass97 gclass97_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_19(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00109DAC File Offset: 0x00107FAC
		private void method_27()
		{
			if (this.gameObject_1.activeSelf)
			{
				this.method_28(false, true);
			}
			else
			{
				this.method_28(true, true);
			}
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x00109DD8 File Offset: 0x00107FD8
		internal void method_28(bool bool_1, bool bool_2 = false)
		{
			this.method_30(bool_1, bool_2);
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x00109DF0 File Offset: 0x00107FF0
		private void method_29(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_35(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00109E24 File Offset: 0x00108024
		internal void method_30(bool bool_1, bool bool_2)
		{
			this.method_21(bool_1, bool_2);
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00109E3C File Offset: 0x0010803C
		internal void method_31(Texture texture_0)
		{
			this.method_18(texture_0);
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00109E50 File Offset: 0x00108050
		internal void method_32(Action action_2, Action action_3)
		{
			this.action_0 = action_2;
			this.action_1 = action_3;
			GClass84.smethod_243(this.gameObject_0.GetComponent<Button>(), new Action(this.method_17));
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00109E88 File Offset: 0x00108088
		private void method_33()
		{
			this.method_27();
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x00109E9C File Offset: 0x0010809C
		private void method_34(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.string_1 = "CheckBoxButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_14(), transform_0, true);
			this.gameObject_1 = this.gameObject_0.transform.Find("Checkmark").gameObject;
			if (float_2 != 1f || float_3 != 1f)
			{
				RectTransform component = this.gameObject_0.GetComponent<RectTransform>();
				if (component)
				{
					Vector2 sizeDelta = component.sizeDelta;
					sizeDelta.x *= float_2;
					sizeDelta.y *= float_3;
					component.sizeDelta = sizeDelta;
					if (this.gameObject_1)
					{
						RectTransform component2 = this.gameObject_1.GetComponent<RectTransform>();
						if (component2)
						{
							component2.localScale = new Vector3(component.localScale.x, component.localScale.y, component.localScale.z);
							component2.sizeDelta = new Vector2(component.sizeDelta.x, component.sizeDelta.y);
						}
					}
				}
			}
			this.int_0[0] = -1;
			this.int_0[1] = 0;
			base.method_15(float_0, float_1);
			this.method_23(action_2, action_3);
			this.gameObject_1.SetActive(false);
			if (nullable_0 != null)
			{
				this.vmethod_0(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<Image>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_2(texture_0);
			}
			base.method_11(true);
			this.bool_0 = bool_1;
			if (bool_2)
			{
				this.method_28(true, false);
			}
			GClass25.list_7.Add(this);
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x0010A04C File Offset: 0x0010824C
		internal override void vmethod_0(Color color_2, bool bool_1 = true)
		{
			this.method_25(color_2, bool_1);
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x0010A064 File Offset: 0x00108264
		private void method_35(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_24(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, this.bool_0, bool_2, texture_0);
		}

		// Token: 0x04001AED RID: 6893
		internal GameObject gameObject_1;

		// Token: 0x04001AEE RID: 6894
		internal List<GClass26> list_0 = new List<GClass26>();

		// Token: 0x04001AEF RID: 6895
		internal List<GClass26> list_1 = new List<GClass26>();

		// Token: 0x04001AF0 RID: 6896
		internal bool bool_0 = false;

		// Token: 0x04001AF1 RID: 6897
		private Action action_0 = null;

		// Token: 0x04001AF2 RID: 6898
		private Action action_1 = null;

		// Token: 0x02000341 RID: 833
		[CompilerGenerated]
		[Serializable]
		private sealed class Class190
		{
			// Token: 0x060046F4 RID: 18164 RVA: 0x0004E3DC File Offset: 0x0004C5DC
			internal void method_0(GClass26 gclass26_0)
			{
				gclass26_0.method_11(false);
			}

			// Token: 0x060046F6 RID: 18166 RVA: 0x0004E408 File Offset: 0x0004C608
			internal void method_1(GClass26 gclass26_0)
			{
				gclass26_0.method_11(true);
			}

			// Token: 0x060046F7 RID: 18167 RVA: 0x0004E3DC File Offset: 0x0004C5DC
			internal void method_2(GClass26 gclass26_0)
			{
				gclass26_0.method_11(false);
			}

			// Token: 0x060046F9 RID: 18169 RVA: 0x0004E408 File Offset: 0x0004C608
			internal void method_3(GClass26 gclass26_0)
			{
				gclass26_0.method_11(true);
			}

			// Token: 0x04001AF3 RID: 6899
			public static readonly GClass35.Class190 class190_0 = new GClass35.Class190();

			// Token: 0x04001AF4 RID: 6900
			public static Action<GClass26> action_0;

			// Token: 0x04001AF5 RID: 6901
			public static Action<GClass26> action_1;

			// Token: 0x04001AF6 RID: 6902
			public static Action<GClass26> action_2;

			// Token: 0x04001AF7 RID: 6903
			public static Action<GClass26> action_3;
		}
	}
}
