using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ns185;
using ns241;
using ns425;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

namespace ns433
{
	// Token: 0x020000D2 RID: 210
	public class GClass137 : GClass130
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x0001BA10 File Offset: 0x00019C10
		internal bool method_2(GClass137.GStruct54 gstruct54_0)
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				if (gstruct54_0.method_0(this.list_2[i]))
				{
					this.list_2.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001BA60 File Offset: 0x00019C60
		internal bool method_3(VRC_Interactable vrc_Interactable_0)
		{
			bool result;
			if (!vrc_Interactable_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < this.list_0.Count; i++)
				{
					GClass137.GStruct53 gstruct = this.list_0[i];
					VRC_Interactable vrc_Interactable_ = gstruct.vrc_Interactable_0;
					if (vrc_Interactable_ == vrc_Interactable_0)
					{
						vrc_Interactable_.proximity = gstruct.float_1;
						this.list_0.RemoveAt(i);
						i--;
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001BADC File Offset: 0x00019CDC
		internal void method_4()
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass137.GStruct53 gstruct = this.list_0[i];
				VRC_Interactable vrc_Interactable_ = gstruct.vrc_Interactable_0;
				if (!vrc_Interactable_)
				{
					this.list_0.RemoveAt(i);
					i--;
				}
				else
				{
					vrc_Interactable_.proximity = gstruct.float_0;
				}
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001BB40 File Offset: 0x00019D40
		internal void method_5(bool bool_9)
		{
			this.method_21(bool_9);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001BB54 File Offset: 0x00019D54
		internal void method_6(bool bool_9)
		{
			this.bool_6 = bool_9;
			if (bool_9)
			{
				this.bool_7 = false;
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001BB74 File Offset: 0x00019D74
		internal void method_7()
		{
			this.method_50();
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001BB88 File Offset: 0x00019D88
		internal bool method_8(string string_1)
		{
			return GClass84.smethod_1138(this.list_1, string_1);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		public override void vmethod_23()
		{
			this.method_7();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		internal void method_9()
		{
			if (this.bool_0)
			{
				this.method_49();
				if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304))
				{
					if (Input.GetKeyDown(122))
					{
						this.bool_8 = !this.bool_8;
					}
					if (Input.GetKeyDown(120))
					{
						this.method_25();
					}
				}
				if (this.bool_8)
				{
					int num = GClass84.smethod_841();
					for (int i = 0; i < this.list_2.Count; i++)
					{
						GClass137.GStruct54 gstruct = this.list_2[i];
						if (gstruct.bool_3)
						{
							if (!gstruct.bool_2 && (!gstruct.vrc_Trigger_0 || (gstruct.bool_1 && gstruct.vrcplayerApi_0 == null)))
							{
								this.list_2.RemoveAt(i);
								i--;
							}
							else if ((float)num >= gstruct.float_1 + gstruct.float_0 * 1000f)
							{
								if (gstruct.bool_2)
								{
									if (this.method_8(gstruct.string_0))
									{
										gstruct.float_1 = (float)num;
										this.list_2[i] = gstruct;
									}
								}
								else if (this.method_17(gstruct))
								{
									gstruct.float_1 = (float)num;
									this.list_2[i] = gstruct;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001BD30 File Offset: 0x00019F30
		internal void method_10(bool bool_9)
		{
			this.method_13(bool_9);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001BD44 File Offset: 0x00019F44
		private static bool smethod_0(VRC_Trigger vrc_Trigger_0, IEnumerable<VRC_Trigger.TriggerEvent> ienumerable_0)
		{
			bool result;
			if (!vrc_Trigger_0 || ienumerable_0 == null)
			{
				result = false;
			}
			else
			{
				if (GClass84.gclass137_0.bool_4)
				{
					string text = string.Empty;
					foreach (VRC_Trigger.TriggerEvent triggerEvent in ienumerable_0)
					{
						string str = text;
						string str2 = ", ";
						VRC_Trigger.TriggerEvent triggerEvent2 = triggerEvent;
						text = str + str2 + ((triggerEvent2 != null) ? triggerEvent2.ToString() : null);
					}
					if (text != string.Empty)
					{
						text = GClass84.smethod_1428(text, 2) + "(" + GClass84.smethod_1204(text, 2, -1) + ")";
					}
					GClass70.smethod_38("VRC_Trigger_ExecuteTriggers" + ": " + GClass84.smethod_118(vrc_Trigger_0) + text, GClass70.Enum1.const_0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001BE20 File Offset: 0x0001A020
		internal void method_11(string string_1, List<KeyCode> list_3, Text text_0)
		{
			this.method_19(string_1, list_3, text_0);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001BE38 File Offset: 0x0001A038
		internal bool method_12(Transform transform_0)
		{
			return transform_0 && this.method_3(transform_0.GetComponent<VRC_Interactable>());
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001BE64 File Offset: 0x0001A064
		public override void vmethod_19()
		{
			this.method_15();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001BE78 File Offset: 0x0001A078
		internal void method_13(bool bool_9)
		{
			this.bool_1 = bool_9;
			if (!bool_9)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i++)
				{
					this.method_3(this.list_0[i].vrc_Interactable_0);
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
		internal bool method_14(VRC_Interactable vrc_Interactable_0, float float_0)
		{
			bool result;
			if (!vrc_Interactable_0)
			{
				result = false;
			}
			else
			{
				this.method_3(vrc_Interactable_0);
				this.list_0.Add(new GClass137.GStruct53(vrc_Interactable_0, float_0));
				result = true;
			}
			return result;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001BF04 File Offset: 0x0001A104
		internal void method_15()
		{
			this.method_9();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001BF18 File Offset: 0x0001A118
		internal bool method_16(GClass137.GStruct54 gstruct54_0, bool bool_9)
		{
			for (int i = 0; i < this.list_2.Count; i++)
			{
				GClass137.GStruct54 gstruct = this.list_2[i];
				if (gstruct54_0.method_0(gstruct))
				{
					gstruct.bool_3 = bool_9;
					this.list_2[i] = gstruct;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001BF70 File Offset: 0x0001A170
		public override void vmethod_8(int int_0)
		{
			this.method_23(int_0);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001BF84 File Offset: 0x0001A184
		internal bool method_17(GClass137.GStruct54 gstruct54_0)
		{
			return (!gstruct54_0.bool_1 || gstruct54_0.vrcplayerApi_0 != null) && this.method_48(gstruct54_0.vrc_Trigger_0, gstruct54_0.string_0, gstruct54_0.bool_0, gstruct54_0.bool_1, gstruct54_0.vrcplayerApi_0);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		internal bool method_18(Transform transform_0, float float_0)
		{
			return transform_0 && this.method_14(transform_0.GetComponent<VRC_Interactable>(), float_0);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		internal void method_19(string string_1, List<KeyCode> list_3, Text text_0)
		{
			this.method_8(string_1);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001C014 File Offset: 0x0001A214
		internal void method_20(bool bool_9)
		{
			this.method_10(bool_9);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		internal void method_21(bool bool_9)
		{
			this.bool_7 = bool_9;
			if (bool_9)
			{
				this.bool_6 = false;
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001C0C4 File Offset: 0x0001A2C4
		internal void method_22()
		{
			this.method_39();
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		internal void method_23(int int_0)
		{
			this.method_26(int_0);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001C0EC File Offset: 0x0001A2EC
		internal bool method_24(GameObject gameObject_0, float float_0)
		{
			return gameObject_0 && this.method_14(gameObject_0.GetComponent<VRC_Interactable>(), float_0);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001C118 File Offset: 0x0001A318
		internal void method_25()
		{
			this.method_35();
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001C12C File Offset: 0x0001A32C
		internal void method_26(int int_0)
		{
			this.method_46();
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001C140 File Offset: 0x0001A340
		internal void method_27(bool bool_9)
		{
			this.method_5(bool_9);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001C154 File Offset: 0x0001A354
		internal bool method_28(List<GameObject> list_3, float float_0)
		{
			bool result;
			if (list_3.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < list_3.Count; i++)
				{
					if (this.method_24(list_3[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001C19C File Offset: 0x0001A39C
		internal bool method_29(VRC_Trigger vrc_Trigger_0, string string_1, float float_0)
		{
			this.list_2.Add(new GClass137.GStruct54(vrc_Trigger_0, string_1, float_0, this.bool_6, this.bool_7, false, this.vrcplayerApi_0));
			return true;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		internal bool method_30(VRC_Trigger vrc_Trigger_0, string string_1)
		{
			return this.method_48(vrc_Trigger_0, string_1, this.bool_6, this.bool_7, this.vrcplayerApi_0);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		internal void method_31(bool bool_9)
		{
			this.method_40(bool_9);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001C20C File Offset: 0x0001A40C
		internal bool method_32(List<VRC_Interactable> list_3, float float_0)
		{
			bool result;
			if (list_3.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < list_3.Count; i++)
				{
					if (this.method_14(list_3[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001C254 File Offset: 0x0001A454
		internal bool method_33(List<Transform> list_3, float float_0)
		{
			bool result;
			if (list_3.Count == 0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < list_3.Count; i++)
				{
					if (this.method_18(list_3[i], float_0))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001C29C File Offset: 0x0001A49C
		internal void method_34()
		{
			this.list_2.Clear();
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		internal void method_35()
		{
			this.method_34();
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
		private static bool smethod_1(VRC_Trigger vrc_Trigger_0, string string_1)
		{
			bool result;
			if (!vrc_Trigger_0 || string_1 == null)
			{
				result = false;
			}
			else
			{
				if (GClass84.gclass137_0.bool_4)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"VRC_Trigger_ExecuteCustomTrigger",
						": ",
						GClass84.smethod_118(vrc_Trigger_0),
						", ",
						string_1
					}), GClass70.Enum1.const_0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001C330 File Offset: 0x0001A530
		internal void method_36(bool bool_9 = false)
		{
			this.method_31(bool_9);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001C344 File Offset: 0x0001A544
		internal void method_37(string string_1, List<KeyCode> list_3, Text text_0)
		{
			this.method_11(string_1, list_3, text_0);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001C35C File Offset: 0x0001A55C
		private static bool smethod_2(VRC_Trigger vrc_Trigger_0, VRC_Trigger.TriggerType triggerType_0)
		{
			bool result;
			if (!vrc_Trigger_0)
			{
				result = false;
			}
			else
			{
				bool flag;
				if ((flag = GClass84.gclass137_0.bool_4) && triggerType_0 == 23)
				{
					flag = GClass84.gclass137_0.bool_5;
				}
				if (flag)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"VRC_Trigger_ExecuteTriggerType",
						": ",
						GClass84.smethod_118(vrc_Trigger_0),
						", ",
						triggerType_0.ToString()
					}), GClass70.Enum1.const_0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		internal void method_38(bool bool_9)
		{
			this.method_6(bool_9);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		internal void method_39()
		{
			if (this.bool_1 && (this.list_0.Count == 0 || !this.list_0[0].vrc_Interactable_0))
			{
				this.list_0.Clear();
				List<VRC_Interactable> list = GClass84.smethod_1090();
				for (int i = 0; i < list.Count; i++)
				{
					this.method_14(list[i], 1000f);
				}
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001C46C File Offset: 0x0001A66C
		internal void method_40(bool bool_9)
		{
			if (bool_9)
			{
				this.method_8(Clipboard.GetText().Trim());
			}
			Action<string, List<KeyCode>, Text> action_ = new Action<string, List<KeyCode>, Text>(this.method_37);
			GClass84.smethod_946("Custom event name", "OnInteract", 0, false, "Execute", action_, null, "Enter Valid Event Name", true, null, false);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		public override void vmethod_10()
		{
			this.method_22();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		internal void method_41()
		{
			this.method_4();
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		internal bool method_42(VRC_Trigger vrc_Trigger_0 = null, string string_1 = "", float float_0 = 0f, bool bool_9 = false, bool bool_10 = false, bool bool_11 = false, VRCPlayerApi vrcplayerApi_1 = null)
		{
			this.list_2.Add(new GClass137.GStruct54(vrc_Trigger_0, string_1, float_0, bool_9, bool_10, bool_11, vrcplayerApi_1));
			return true;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001C514 File Offset: 0x0001A714
		private static HarmonyMethod smethod_3(string string_1)
		{
			return new HarmonyMethod(typeof(GClass137).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001C53C File Offset: 0x0001A73C
		internal void method_43()
		{
			this.method_44();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001C550 File Offset: 0x0001A750
		internal void method_44()
		{
			this.list_1.Clear();
			this.list_1.AddRange(Object.FindObjectsOfType<VRC_Trigger>());
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001C578 File Offset: 0x0001A778
		internal bool method_45(GameObject gameObject_0)
		{
			return gameObject_0 && this.method_3(gameObject_0.GetComponent<VRC_Interactable>());
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001C5A4 File Offset: 0x0001A7A4
		internal void method_46()
		{
			this.method_43();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
		internal void method_47(bool bool_9)
		{
			this.method_38(bool_9);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		internal bool method_48(VRC_Trigger vrc_Trigger_0, string string_1, bool bool_9 = false, bool bool_10 = false, VRCPlayerApi vrcplayerApi_1 = null)
		{
			bool result;
			if (bool_9)
			{
				result = GClass84.smethod_844(vrc_Trigger_0, string_1);
			}
			else if (bool_10)
			{
				result = (vrcplayerApi_1 != null && GClass84.smethod_1509(vrc_Trigger_0, string_1, vrcplayerApi_1));
			}
			else
			{
				result = GClass84.smethod_489(vrc_Trigger_0, string_1);
			}
			return result;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001C60C File Offset: 0x0001A80C
		internal void method_49()
		{
			this.method_41();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001C620 File Offset: 0x0001A820
		internal void method_50()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.smethod_1302("TriggersManager", typeof(VRC_Trigger), "ExecuteCustomTrigger", GClass137.smethod_3("VRC_Trigger_ExecuteCustomTrigger"), null, null);
			GClass84.smethod_1302("TriggersManager", typeof(VRC_Trigger), "ExecuteTriggers", GClass137.smethod_3("VRC_Trigger_ExecuteTriggers"), null, null);
			GClass84.smethod_1302("TriggersManager", typeof(VRC_Trigger), "ExecuteTriggerType", GClass137.smethod_3("VRC_Trigger_ExecuteTriggerType"), null, null);
		}

		// Token: 0x0400051A RID: 1306
		internal bool bool_0 = true;

		// Token: 0x0400051B RID: 1307
		internal List<GClass137.GStruct53> list_0 = new List<GClass137.GStruct53>();

		// Token: 0x0400051C RID: 1308
		internal bool bool_1 = false;

		// Token: 0x0400051D RID: 1309
		internal bool bool_2 = false;

		// Token: 0x0400051E RID: 1310
		internal bool bool_3 = false;

		// Token: 0x0400051F RID: 1311
		internal bool bool_4 = false;

		// Token: 0x04000520 RID: 1312
		internal bool bool_5 = false;

		// Token: 0x04000521 RID: 1313
		internal bool bool_6 = false;

		// Token: 0x04000522 RID: 1314
		internal bool bool_7 = false;

		// Token: 0x04000523 RID: 1315
		internal VRCPlayerApi vrcplayerApi_0 = null;

		// Token: 0x04000524 RID: 1316
		internal List<VRC_Trigger> list_1 = new List<VRC_Trigger>();

		// Token: 0x04000525 RID: 1317
		internal bool bool_8 = true;

		// Token: 0x04000526 RID: 1318
		internal List<GClass137.GStruct54> list_2 = new List<GClass137.GStruct54>();

		// Token: 0x020000D3 RID: 211
		public struct GStruct53
		{
			// Token: 0x06000704 RID: 1796 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
			public GStruct53(VRC_Interactable vrc_Interactable_1, float float_2)
			{
				this.vrc_Interactable_0 = vrc_Interactable_1;
				this.float_0 = float_2;
				this.float_1 = vrc_Interactable_1.proximity;
			}

			// Token: 0x04000527 RID: 1319
			public VRC_Interactable vrc_Interactable_0;

			// Token: 0x04000528 RID: 1320
			public float float_0;

			// Token: 0x04000529 RID: 1321
			public float float_1;
		}

		// Token: 0x020000D4 RID: 212
		public struct GStruct54
		{
			// Token: 0x06000705 RID: 1797 RVA: 0x0001C70C File Offset: 0x0001A90C
			public bool method_0(GClass137.GStruct54 gstruct54_0)
			{
				return gstruct54_0.bool_0 == this.bool_0 && gstruct54_0.bool_1 == this.bool_1 && (!gstruct54_0.bool_1 || gstruct54_0.vrcplayerApi_0 == this.vrcplayerApi_0) && gstruct54_0.vrc_Trigger_0 == this.vrc_Trigger_0 && gstruct54_0.string_0 == this.string_0 && gstruct54_0.float_0 == this.float_0;
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x0001C784 File Offset: 0x0001A984
			public GStruct54(VRC_Trigger vrc_Trigger_1, string string_1, float float_2, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, VRCPlayerApi vrcplayerApi_1 = null)
			{
				this.vrc_Trigger_0 = vrc_Trigger_1;
				this.string_0 = string_1;
				this.float_0 = float_2;
				this.bool_0 = bool_4;
				this.bool_1 = bool_5;
				this.bool_2 = bool_6;
				this.vrcplayerApi_0 = vrcplayerApi_1;
				this.float_1 = 0f;
				this.bool_3 = true;
			}

			// Token: 0x0400052A RID: 1322
			public VRC_Trigger vrc_Trigger_0;

			// Token: 0x0400052B RID: 1323
			public string string_0;

			// Token: 0x0400052C RID: 1324
			public float float_0;

			// Token: 0x0400052D RID: 1325
			public bool bool_0;

			// Token: 0x0400052E RID: 1326
			public bool bool_1;

			// Token: 0x0400052F RID: 1327
			public bool bool_2;

			// Token: 0x04000530 RID: 1328
			public VRCPlayerApi vrcplayerApi_0;

			// Token: 0x04000531 RID: 1329
			public float float_1;

			// Token: 0x04000532 RID: 1330
			public bool bool_3;
		}
	}
}
