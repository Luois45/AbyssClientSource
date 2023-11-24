using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ns58
{
	// Token: 0x0200017A RID: 378
	public class GClass29 : GClass26
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x0004D8AC File Offset: 0x0004BAAC
		internal override void vmethod_1(Color color_2, bool bool_1 = true)
		{
			this.method_25(color_2, bool_1);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
		public GClass29(GClass97 gclass97_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_32(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0004D934 File Offset: 0x0004BB34
		internal void method_17(string string_3)
		{
			Text[] array = this.gameObject_1.GetComponentsInChildren<Text>();
			array[0].text = string_3;
			Text[] array2 = this.gameObject_2.GetComponentsInChildren<Text>();
			array2[0].text = string_3;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0004D978 File Offset: 0x0004BB78
		public GClass29(string string_3, float float_0, float float_1, float float_2, float float_3, string string_4, Action action_2, string string_5, Action action_3, string string_6, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_32(float_0, float_1, float_2, float_3, string_4, action_2, string_5, action_3, string_6, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0004D9E0 File Offset: 0x0004BBE0
		internal bool method_18(string string_3)
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

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0004DA28 File Offset: 0x0004BC28
		public GClass29(GClass17 gclass17_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_32(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0004DA94 File Offset: 0x0004BC94
		internal void method_19(Action action_2, Action action_3)
		{
			this.method_29(action_2, action_3);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0004DAAC File Offset: 0x0004BCAC
		private void method_20(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.string_1 = "ToggleButton";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_29(), transform_0, true);
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
			base.method_15(float_0, float_1);
			this.method_30(string_3);
			this.method_26(string_4);
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
			this.method_18(string_5);
			this.method_47(action_2, action_3);
			this.gameObject_1.SetActive(false);
			this.gameObject_2.SetActive(true);
			if (nullable_0 != null)
			{
				this.vmethod_0(nullable_0.Value, true);
			}
			else
			{
				this.color_0 = this.gameObject_1.GetComponentsInChildren<Text>().First<Text>().color;
			}
			if (nullable_1 != null)
			{
				this.vmethod_1(nullable_1.Value, true);
			}
			else
			{
				this.color_1 = this.gameObject_1.GetComponentsInChildren<RawImage>().First<RawImage>().color;
			}
			base.method_11(true);
			this.bool_0 = bool_1;
			if (bool_2)
			{
				this.method_39(true, false);
			}
			GClass25.list_10.Add(this);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0004DCCC File Offset: 0x0004BECC
		internal void method_21(string string_3)
		{
			this.method_36(string_3);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		internal string method_22()
		{
			return this.method_37();
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004DCF4 File Offset: 0x0004BEF4
		private void method_23(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_48(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0004DD38 File Offset: 0x0004BF38
		private void method_24(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_43(transform_0, float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0004DD80 File Offset: 0x0004BF80
		internal void method_25(Color color_2, bool bool_1)
		{
			this.method_46(color_2, bool_1);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0004DD98 File Offset: 0x0004BF98
		public GClass29(GClass99 gclass99_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_32(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0004DE04 File Offset: 0x0004C004
		internal void method_26(string string_3)
		{
			this.method_21(string_3);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0004DE18 File Offset: 0x0004C018
		public GClass29(GClass99 gclass99_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass99_0.method_0();
			this.method_32(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0004DE88 File Offset: 0x0004C088
		public GClass29(string string_3, float float_0, float float_1, string string_4, Action action_2, string string_5, Action action_3, string string_6, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = string_3;
			this.method_32(float_0, float_1, 1f, 1f, string_4, action_2, string_5, action_3, string_6, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		private void method_27()
		{
			this.method_39(false, true);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0004DF0C File Offset: 0x0004C10C
		internal void method_28(bool bool_1, bool bool_2)
		{
			this.gameObject_1.SetActive(bool_1);
			this.gameObject_2.SetActive(!bool_1);
			try
			{
				if (bool_1 && bool_2)
				{
					this.action_0();
					this.list_0.ForEach(new Action<GClass26>(GClass29.Class87.class87_0.method_2));
					this.list_1.ForEach(new Action<GClass26>(GClass29.Class87.class87_0.method_1));
				}
				else if (!bool_1 && bool_2)
				{
					this.action_1();
					this.list_0.ForEach(new Action<GClass26>(GClass29.Class87.class87_0.method_0));
					this.list_1.ForEach(new Action<GClass26>(GClass29.Class87.class87_0.method_3));
				}
			}
			catch
			{
			}
			if (!this.bool_0)
			{
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0004E020 File Offset: 0x0004C220
		internal void method_29(Action action_2, Action action_3)
		{
			this.action_0 = action_2;
			this.action_1 = action_3;
			GClass84.smethod_243(this.gameObject_1.GetComponent<Button>(), new Action(this.method_41));
			GClass84.smethod_243(this.gameObject_2.GetComponent<Button>(), new Action(this.method_33));
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0004E074 File Offset: 0x0004C274
		internal void method_30(string string_3)
		{
			this.method_38(string_3);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0004E088 File Offset: 0x0004C288
		private void method_31()
		{
			this.method_39(true, true);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
		private void method_32(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.method_23(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
		[CompilerGenerated]
		private void method_33()
		{
			this.method_45();
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
		internal void method_34(Color color_2, bool bool_1)
		{
			this.method_40(color_2, bool_1);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0004E110 File Offset: 0x0004C310
		private void method_35()
		{
			this.method_27();
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0004E124 File Offset: 0x0004C324
		internal override void vmethod_0(Color color_2, bool bool_1 = true)
		{
			this.method_34(color_2, bool_1);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0004E13C File Offset: 0x0004C33C
		internal void method_36(string string_3)
		{
			Text[] array = this.gameObject_1.GetComponentsInChildren<Text>();
			array[1].text = string_3;
			Text[] array2 = this.gameObject_2.GetComponentsInChildren<Text>();
			array2[1].text = string_3;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0004E180 File Offset: 0x0004C380
		public GClass29(GClass97 gclass97_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass97_0.method_12();
			this.method_32(float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0004E1EC File Offset: 0x0004C3EC
		internal string method_37()
		{
			return this.gameObject_1.GetComponentsInChildren<Text>()[0].text;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0004E214 File Offset: 0x0004C414
		internal void method_38(string string_3)
		{
			this.method_17(string_3);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0004E228 File Offset: 0x0004C428
		internal void method_39(bool bool_1, bool bool_2 = false)
		{
			this.method_44(bool_1, bool_2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0004E240 File Offset: 0x0004C440
		internal void method_40(Color color_2, bool bool_1)
		{
			if (bool_1)
			{
				this.color_0 = color_2;
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0004E258 File Offset: 0x0004C458
		[CompilerGenerated]
		private void method_41()
		{
			this.method_35();
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0004E26C File Offset: 0x0004C46C
		public GClass29(GClass17 gclass17_0, float float_0, float float_1, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0 = null, Color? nullable_1 = null, bool bool_1 = false, bool bool_2 = false, Texture texture_0 = null)
		{
			this.string_0 = gclass17_0.method_1();
			this.method_32(float_0, float_1, 1f, 1f, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		internal string method_42()
		{
			return this.method_22();
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
		private void method_43(Transform transform_0, float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_20(transform_0, float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, bool_1, bool_2, texture_0);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0004E338 File Offset: 0x0004C538
		internal void method_44(bool bool_1, bool bool_2)
		{
			this.method_28(bool_1, bool_2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0004E350 File Offset: 0x0004C550
		private void method_45()
		{
			this.method_31();
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0004E364 File Offset: 0x0004C564
		internal void method_46(Color color_2, bool bool_1)
		{
			if (bool_1)
			{
				this.color_1 = color_2;
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0004E37C File Offset: 0x0004C57C
		internal void method_47(Action action_2, Action action_3)
		{
			this.method_19(action_2, action_3);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0004E394 File Offset: 0x0004C594
		private void method_48(float float_0, float float_1, float float_2, float float_3, string string_3, Action action_2, string string_4, Action action_3, string string_5, Color? nullable_0, Color? nullable_1, bool bool_1, bool bool_2, Texture texture_0)
		{
			this.method_24(GClass124.smethod_16(GClass84.smethod_195().Find(this.string_0)), float_0, float_1, float_2, float_3, string_3, action_2, string_4, action_3, string_5, nullable_0, nullable_1, this.bool_0, bool_2, texture_0);
		}

		// Token: 0x04000A8F RID: 2703
		internal GameObject gameObject_1;

		// Token: 0x04000A90 RID: 2704
		internal GameObject gameObject_2;

		// Token: 0x04000A91 RID: 2705
		internal List<GClass26> list_0 = new List<GClass26>();

		// Token: 0x04000A92 RID: 2706
		internal List<GClass26> list_1 = new List<GClass26>();

		// Token: 0x04000A93 RID: 2707
		internal bool bool_0 = false;

		// Token: 0x04000A94 RID: 2708
		private Action action_0 = null;

		// Token: 0x04000A95 RID: 2709
		private Action action_1 = null;

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		[Serializable]
		private sealed class Class87
		{
			// Token: 0x06000EC6 RID: 3782 RVA: 0x0004E3DC File Offset: 0x0004C5DC
			internal void method_0(GClass26 gclass26_0)
			{
				gclass26_0.method_11(false);
			}

			// Token: 0x06000EC9 RID: 3785 RVA: 0x0004E3DC File Offset: 0x0004C5DC
			internal void method_1(GClass26 gclass26_0)
			{
				gclass26_0.method_11(false);
			}

			// Token: 0x06000ECA RID: 3786 RVA: 0x0004E408 File Offset: 0x0004C608
			internal void method_2(GClass26 gclass26_0)
			{
				gclass26_0.method_11(true);
			}

			// Token: 0x06000ECB RID: 3787 RVA: 0x0004E408 File Offset: 0x0004C608
			internal void method_3(GClass26 gclass26_0)
			{
				gclass26_0.method_11(true);
			}

			// Token: 0x04000A96 RID: 2710
			public static readonly GClass29.Class87 class87_0 = new GClass29.Class87();

			// Token: 0x04000A97 RID: 2711
			public static Action<GClass26> action_0;

			// Token: 0x04000A98 RID: 2712
			public static Action<GClass26> action_1;

			// Token: 0x04000A99 RID: 2713
			public static Action<GClass26> action_2;

			// Token: 0x04000A9A RID: 2714
			public static Action<GClass26> action_3;
		}
	}
}
