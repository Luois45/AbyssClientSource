using System;
using System.Collections.Generic;
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

namespace ns10
{
	// Token: 0x020001BC RID: 444
	public class GClass4 : GClass2
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x00057C98 File Offset: 0x00055E98
		[CompilerGenerated]
		private void method_17()
		{
			this.method_22();
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00057CAC File Offset: 0x00055EAC
		internal void method_18(bool bool_1, bool bool_2)
		{
			this.method_25(bool_1, bool_2);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00057CC4 File Offset: 0x00055EC4
		internal void method_19(Texture texture_0)
		{
			this.method_26(texture_0);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00057CD8 File Offset: 0x00055ED8
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_27(transform_0, float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00057D10 File Offset: 0x00055F10
		internal void method_21(Color color_2, bool bool_1)
		{
			this.method_31(color_2, bool_1);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00057D28 File Offset: 0x00055F28
		public GClass4(GClass66 gclass66_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_33(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00057D90 File Offset: 0x00055F90
		private void method_22()
		{
			this.method_24();
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00057DA4 File Offset: 0x00055FA4
		private void method_23(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_35(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00057DD8 File Offset: 0x00055FD8
		public GClass4(string string_3, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_33(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00057E38 File Offset: 0x00056038
		public GClass4(GClass66 gclass66_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass66_0.method_8();
			this.method_33(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00057E9C File Offset: 0x0005609C
		public GClass4(GClass24 gclass24_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_33(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00057F00 File Offset: 0x00056100
		public GClass4(GClass24 gclass24_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass24_0.method_7();
			this.method_33(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00057F68 File Offset: 0x00056168
		private void method_24()
		{
			if (this.gameObject_1.activeSelf)
			{
				this.method_32(false, true);
			}
			else
			{
				this.method_32(true, true);
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00057F94 File Offset: 0x00056194
		public GClass4(string string_3, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_33(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00057FF8 File Offset: 0x000561F8
		public GClass4(GClass95 gclass95_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_33(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0005805C File Offset: 0x0005625C
		internal void method_25(bool bool_1, bool bool_2)
		{
			this.gameObject_1.SetActive(bool_1);
			try
			{
				if (bool_1 && bool_2)
				{
					this.action_0();
					this.list_0.ForEach(new Action<GClass2>(GClass4.Class97.class97_0.method_0));
					this.list_1.ForEach(new Action<GClass2>(GClass4.Class97.class97_0.method_1));
				}
				else if (!bool_1 && bool_2)
				{
					this.action_1();
					this.list_0.ForEach(new Action<GClass2>(GClass4.Class97.class97_0.method_2));
					this.list_1.ForEach(new Action<GClass2>(GClass4.Class97.class97_0.method_3));
				}
			}
			catch
			{
			}
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00058160 File Offset: 0x00056360
		public GClass4(GClass95 gclass95_0, float float_0, float float_1, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass95_0.method_9();
			this.method_33(float_0, float_1, 1f, 1f, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000581C8 File Offset: 0x000563C8
		internal void method_26(Texture texture_0)
		{
			this.gameObject_0.GetComponent<RawImage>().texture = texture_0;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000581E8 File Offset: 0x000563E8
		private void method_27(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_34(transform_0, float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00058220 File Offset: 0x00056420
		internal void method_28(Action action_2, Action action_3)
		{
			this.method_29(action_2, action_3);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00058238 File Offset: 0x00056438
		internal override void vmethod_1(Color color_2, bool bool_1 = true)
		{
			this.method_21(color_2, bool_1);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00058250 File Offset: 0x00056450
		internal override void vmethod_0(Texture texture_0)
		{
			this.method_19(texture_0);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00058264 File Offset: 0x00056464
		internal void method_29(Action action_2, Action action_3)
		{
			this.method_30(action_2, action_3);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0005827C File Offset: 0x0005647C
		internal void method_30(Action action_2, Action action_3)
		{
			this.action_0 = action_2;
			this.action_1 = action_3;
			GClass84.smethod_243(this.gameObject_0.GetComponent<Button>(), new Action(this.method_17));
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x000582B4 File Offset: 0x000564B4
		internal void method_31(Color color_2, bool bool_1)
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

		// Token: 0x060010C7 RID: 4295 RVA: 0x00058338 File Offset: 0x00056538
		internal void method_32(bool bool_1, bool bool_2 = false)
		{
			this.method_18(bool_1, bool_2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00058350 File Offset: 0x00056550
		private void method_33(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_23(float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, bool_1, bool_2, texture_0);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00058384 File Offset: 0x00056584
		private void method_34(Transform transform_0, float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.string_1 = "CheckBoxButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_13(), transform_0, true);
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
			base.method_4(float_0, float_1);
			this.method_28(action_2, action_3);
			this.gameObject_1.SetActive(false);
			if (nullable_0 != null)
			{
				this.vmethod_1(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_0.GetComponent<Image>().color;
			}
			if (texture_0 != null)
			{
				this.vmethod_0(texture_0);
			}
			base.method_6(true);
			this.bool_0 = bool_1;
			if (bool_2)
			{
				this.method_32(true, false);
			}
			GClass199.list_7.Add(this);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00058534 File Offset: 0x00056734
		private void method_35(float float_0, float float_1, float float_2, float float_3, Action action_2, Action action_3, Color? nullable_0, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_20(GClass73.smethod_25(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, action_2, action_3, nullable_0, this.bool_0, bool_2, texture_0);
		}

		// Token: 0x04000C43 RID: 3139
		internal GameObject gameObject_1;

		// Token: 0x04000C44 RID: 3140
		internal List<GClass2> list_0 = new List<GClass2>();

		// Token: 0x04000C45 RID: 3141
		internal List<GClass2> list_1 = new List<GClass2>();

		// Token: 0x04000C46 RID: 3142
		internal bool bool_0 = false;

		// Token: 0x04000C47 RID: 3143
		private Action action_0 = null;

		// Token: 0x04000C48 RID: 3144
		private Action action_1 = null;

		// Token: 0x020001BD RID: 445
		[CompilerGenerated]
		[Serializable]
		private sealed class Class97
		{
			// Token: 0x060010CB RID: 4299 RVA: 0x00058574 File Offset: 0x00056774
			internal void method_0(GClass2 gclass2_0)
			{
				gclass2_0.method_6(true);
			}

			// Token: 0x060010CC RID: 4300 RVA: 0x00058588 File Offset: 0x00056788
			internal void method_1(GClass2 gclass2_0)
			{
				gclass2_0.method_6(false);
			}

			// Token: 0x060010CD RID: 4301 RVA: 0x00058588 File Offset: 0x00056788
			internal void method_2(GClass2 gclass2_0)
			{
				gclass2_0.method_6(false);
			}

			// Token: 0x060010D0 RID: 4304 RVA: 0x00058574 File Offset: 0x00056774
			internal void method_3(GClass2 gclass2_0)
			{
				gclass2_0.method_6(true);
			}

			// Token: 0x04000C49 RID: 3145
			public static readonly GClass4.Class97 class97_0 = new GClass4.Class97();

			// Token: 0x04000C4A RID: 3146
			public static Action<GClass2> action_0;

			// Token: 0x04000C4B RID: 3147
			public static Action<GClass2> action_1;

			// Token: 0x04000C4C RID: 3148
			public static Action<GClass2> action_2;

			// Token: 0x04000C4D RID: 3149
			public static Action<GClass2> action_3;
		}
	}
}
