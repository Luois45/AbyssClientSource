using System;
using ns185;
using ns241;
using ns425;
using ns556;
using UnityEngine;
using UnityEngine.UI;

namespace ns454
{
	// Token: 0x020002A3 RID: 675
	public class GClass158 : GClass130
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x000A273C File Offset: 0x000A093C
		internal void method_2(bool bool_7)
		{
			this.method_7(bool_7);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x000A2750 File Offset: 0x000A0950
		internal void method_3(bool bool_7)
		{
			this.method_15(bool_7);
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000A2764 File Offset: 0x000A0964
		internal void method_4()
		{
			try
			{
				this.method_17();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000A279C File Offset: 0x000A099C
		internal void method_5(bool bool_7)
		{
			this.bool_0 = bool_7;
			GClass198.gclass198_0.bool_0 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000A27C0 File Offset: 0x000A09C0
		internal void method_6(bool bool_7)
		{
			this.bool_2 = bool_7;
			GClass198.gclass198_0.bool_2 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000A27E4 File Offset: 0x000A09E4
		internal void method_7(bool bool_7)
		{
			this.bool_6 = bool_7;
			GClass198.gclass198_0.bool_6 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x000A2808 File Offset: 0x000A0A08
		internal void method_8(bool bool_7)
		{
			this.method_25(bool_7);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000A281C File Offset: 0x000A0A1C
		internal void method_9(bool bool_7)
		{
			this.bool_4 = bool_7;
			GClass198.gclass198_0.bool_4 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000A2840 File Offset: 0x000A0A40
		internal void method_10(bool bool_7)
		{
			this.method_23(bool_7);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000A2854 File Offset: 0x000A0A54
		internal void method_11(bool bool_7)
		{
			this.method_26(bool_7);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000A2868 File Offset: 0x000A0A68
		internal void method_12(bool bool_7)
		{
			this.bool_3 = bool_7;
			GClass198.gclass198_0.bool_3 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000A288C File Offset: 0x000A0A8C
		internal void method_13(bool bool_7)
		{
			this.method_9(bool_7);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000A28A0 File Offset: 0x000A0AA0
		internal void method_14(bool bool_7)
		{
			this.method_27(bool_7);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000A28B4 File Offset: 0x000A0AB4
		internal void method_15(bool bool_7)
		{
			this.method_12(bool_7);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000A28C8 File Offset: 0x000A0AC8
		internal void method_16()
		{
			this.method_24();
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000A2920 File Offset: 0x000A0B20
		internal void method_17()
		{
			this.method_16();
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000A2934 File Offset: 0x000A0B34
		internal void method_18()
		{
			this.method_29();
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000A2948 File Offset: 0x000A0B48
		internal void method_19(bool bool_7)
		{
			this.method_13(bool_7);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000A295C File Offset: 0x000A0B5C
		internal void method_20(bool bool_7)
		{
			this.bool_5 = bool_7;
			GClass198.gclass198_0.bool_5 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000A2980 File Offset: 0x000A0B80
		internal void method_21()
		{
			this.method_4();
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000A2994 File Offset: 0x000A0B94
		internal void method_22(bool bool_7)
		{
			this.method_2(bool_7);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000A29A8 File Offset: 0x000A0BA8
		internal void method_23(bool bool_7)
		{
			this.method_6(bool_7);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000A29BC File Offset: 0x000A0BBC
		internal void method_24()
		{
			if (!GClass84.Boolean_0)
			{
				Transform transform = GClass84.smethod_195();
				GameObject gameObject;
				if (transform == null)
				{
					gameObject = null;
				}
				else
				{
					Transform transform2 = transform.Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners");
					gameObject = ((transform2 != null) ? transform2.gameObject : null);
				}
				GameObject gameObject2 = gameObject;
				Transform transform3 = GClass84.smethod_195();
				GameObject gameObject3;
				if (transform3 == null)
				{
					gameObject3 = null;
				}
				else
				{
					Transform transform4 = transform3.Find("Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners");
					gameObject3 = ((transform4 != null) ? transform4.gameObject : null);
				}
				GameObject gameObject4 = gameObject3;
				if (this.bool_1)
				{
					if (gameObject2)
					{
						Object.DestroyImmediate(gameObject2, true);
					}
					if (gameObject4)
					{
						Object.DestroyImmediate(gameObject4, true);
					}
				}
				else if (this.bool_0)
				{
					if (gameObject2)
					{
						gameObject2.SetActive(false);
					}
					if (gameObject4)
					{
						gameObject4.SetActive(false);
					}
				}
			}
			if (this.bool_4)
			{
				GameObject gameObject5 = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/UserIconButton/Hover Over");
				if (gameObject5)
				{
					Object.DestroyImmediate(gameObject5, true);
				}
			}
			GameObject gameObject6 = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Favorite Avatar List/GetMoreFavorites");
			if (gameObject6)
			{
				if (this.bool_6)
				{
					Object.DestroyImmediate(gameObject6, true);
				}
				else if (this.bool_5)
				{
					gameObject6.SetActive(false);
				}
			}
			GameObject gameObject7 = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab");
			if (gameObject7)
			{
				bool flag = false;
				if (this.bool_3)
				{
					Object.DestroyImmediate(gameObject7, true);
					flag = true;
				}
				else if (this.bool_2)
				{
					gameObject7.SetActive(false);
					flag = true;
				}
				if (flag)
				{
					GameObject gameObject8 = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content");
					if (gameObject8)
					{
						HorizontalLayoutGroup component = gameObject8.GetComponent<HorizontalLayoutGroup>();
						if (component)
						{
							component.childForceExpandWidth = true;
						}
					}
				}
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000A2B38 File Offset: 0x000A0D38
		internal void method_25(bool bool_7)
		{
			this.method_28(bool_7);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000A2B4C File Offset: 0x000A0D4C
		internal void method_26(bool bool_7)
		{
			this.method_20(bool_7);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000A2B60 File Offset: 0x000A0D60
		internal void method_27(bool bool_7)
		{
			this.method_5(bool_7);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x000A2B74 File Offset: 0x000A0D74
		public override void vmethod_12()
		{
			this.method_21();
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x000A2B88 File Offset: 0x000A0D88
		public override void vmethod_23()
		{
			this.method_18();
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000A2B9C File Offset: 0x000A0D9C
		internal void method_28(bool bool_7)
		{
			this.bool_1 = bool_7;
			GClass198.gclass198_0.bool_1 = bool_7;
			GClass198.smethod_4();
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000A2BC0 File Offset: 0x000A0DC0
		internal void method_29()
		{
			GClass84.list_13.Add(new Action(this.vmethod_12));
			GClass198.smethod_2();
			this.bool_0 = GClass198.gclass198_0.bool_0;
			this.bool_1 = GClass198.gclass198_0.bool_1;
			this.bool_2 = GClass198.gclass198_0.bool_2;
			this.bool_3 = GClass198.gclass198_0.bool_3;
			this.bool_4 = GClass198.gclass198_0.bool_4;
			this.bool_5 = GClass198.gclass198_0.bool_5;
			this.bool_6 = GClass198.gclass198_0.bool_6;
		}

		// Token: 0x04001222 RID: 4642
		internal bool bool_0 = false;

		// Token: 0x04001223 RID: 4643
		internal bool bool_1 = true;

		// Token: 0x04001224 RID: 4644
		internal bool bool_2 = false;

		// Token: 0x04001225 RID: 4645
		internal bool bool_3 = true;

		// Token: 0x04001226 RID: 4646
		internal bool bool_4 = true;

		// Token: 0x04001227 RID: 4647
		internal bool bool_5 = false;

		// Token: 0x04001228 RID: 4648
		internal bool bool_6 = true;
	}
}
