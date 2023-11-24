using System;
using System.Collections.Generic;
using ns105;
using ns241;
using ns449;
using ns550;
using UnityEngine;
using UnityEngine.UI;

namespace ns185
{
	// Token: 0x02000129 RID: 297
	public static class GClass70
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x00029BA8 File Offset: 0x00027DA8
		internal static void smethod_0(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_67(enum1_2);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00029BBC File Offset: 0x00027DBC
		internal static void smethod_1(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_17(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00029BD4 File Offset: 0x00027DD4
		internal static void smethod_2(bool bool_10)
		{
			GClass70.bool_8 = bool_10;
			GClass84.gclass48_0.bool_8 = bool_10;
			GClass48.smethod_0();
			if (GClass70.gameObject_2)
			{
				GClass70.gameObject_2.active = bool_10;
				GClass70.smethod_84();
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00029C14 File Offset: 0x00027E14
		internal static void smethod_3(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(string.Concat(new string[]
				{
					"[",
					string_1,
					"] ",
					string_0,
					"\n"
				}));
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=red>",
					"[",
					string_1,
					"] ",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00029D18 File Offset: 0x00027F18
		internal static void smethod_4()
		{
			if (GClass70.text_0)
			{
				GClass70.text_0.text = string.Join("\n", GClass70.smethod_20(GClass70.enum1_0));
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00029D50 File Offset: 0x00027F50
		internal static void smethod_5(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_83(enum1_2);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00029D64 File Offset: 0x00027F64
		internal static void smethod_6(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_106(string_0, enum1_2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00029D78 File Offset: 0x00027F78
		internal static void smethod_7(bool bool_10)
		{
			GClass70.smethod_85(bool_10);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00029D8C File Offset: 0x00027F8C
		internal static void smethod_8(string string_0, string string_1, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_1);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_1,
					"</color>",
					"] ",
					string_0
				}), enum1_2);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00029EB4 File Offset: 0x000280B4
		internal static void smethod_9(ConsoleColor consoleColor_0, string string_0, string string_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_53(consoleColor_0, string_0, string_1, enum1_2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00029ECC File Offset: 0x000280CC
		internal static void smethod_10(int int_1)
		{
			GClass70.smethod_70(int_1);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00029EE0 File Offset: 0x000280E0
		internal static void smethod_11(bool bool_10)
		{
			GClass70.bool_9 = bool_10;
			GClass84.gclass48_0.bool_9 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00029F04 File Offset: 0x00028104
		internal static void smethod_12(GClass70.Enum1 enum1_2)
		{
			GClass70.enum1_0 = enum1_2;
			GClass84.gclass48_0.string_0 = GClass70.smethod_89(enum1_2);
			GClass48.smethod_0();
			GClass70.smethod_29();
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00029F34 File Offset: 0x00028134
		internal static void smethod_13(bool bool_10)
		{
			GClass70.smethod_98(bool_10);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00029F48 File Offset: 0x00028148
		internal static void smethod_14()
		{
			try
			{
				GClass70.gameObject_0 = new GameObject("LoggerBackground");
				GClass70.gameObject_0.active = GClass70.bool_7;
				GClass70.gameObject_0.AddComponent<CanvasRenderer>();
				GClass70.rawImage_0 = GClass70.gameObject_0.AddComponent<RawImage>();
				GClass70.gameObject_0.GetComponent<RectTransform>().sizeDelta = new Vector2(0.5f, 0.5f);
				GClass70.gameObject_0.GetComponent<RectTransform>().anchoredPosition = new Vector2(-0.5f, 0f);
				GClass70.gameObject_0.transform.SetParent(GClass84.smethod_1421(), false);
				GClass70.rawImage_0.texture = GClass153.GClass87.texture2D_0;
				GClass70.rawImage_0.color = new Color(0.05490196f, 0.05490196f, 0.05490196f, 0.8784314f);
				GClass70.gameObject_1 = new GameObject("Text");
				GClass70.gameObject_1.AddComponent<CanvasRenderer>();
				GClass70.gameObject_1.transform.SetParent(GClass70.gameObject_0.transform, false);
				GClass70.text_0 = GClass70.gameObject_1.AddComponent<Text>();
				GClass70.text_0.alignment = 0;
				GClass70.text_0.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				GClass70.text_0.fontSize = GClass70.int_0;
				GClass70.text_0.text = string.Empty;
				GClass70.gameObject_1.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);
				GClass70.gameObject_2 = new GameObject("LoggerBackground2");
				GClass70.gameObject_2.active = GClass70.bool_8;
				GClass70.gameObject_2.AddComponent<CanvasRenderer>();
				GClass70.rawImage_1 = GClass70.gameObject_2.AddComponent<RawImage>();
				GClass70.gameObject_2.GetComponent<RectTransform>().sizeDelta = new Vector2(0.5f, 0.5f);
				GClass70.gameObject_2.GetComponent<RectTransform>().anchoredPosition = new Vector2(0.5f, 0f);
				GClass70.gameObject_2.transform.SetParent(GClass84.smethod_1421(), false);
				GClass70.rawImage_1.texture = GClass153.GClass87.texture2D_0;
				GClass70.rawImage_1.color = new Color(0.05490196f, 0.05490196f, 0.05490196f, 0.8784314f);
				GClass70.gameObject_3 = new GameObject("Text");
				GClass70.gameObject_3.AddComponent<CanvasRenderer>();
				GClass70.gameObject_3.transform.SetParent(GClass70.gameObject_2.transform, false);
				GClass70.text_1 = GClass70.gameObject_3.AddComponent<Text>();
				GClass70.text_1.alignment = 0;
				GClass70.text_1.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				GClass70.text_1.fontSize = GClass70.int_0;
				GClass70.text_1.text = string.Empty;
				GClass70.gameObject_3.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002A238 File Offset: 0x00028438
		internal static void smethod_15(bool bool_10)
		{
			GClass70.smethod_27(bool_10);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002A24C File Offset: 0x0002844C
		internal static void smethod_16(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_59(string_0, enum1_2);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002A260 File Offset: 0x00028460
		internal static void smethod_17(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write(string.Concat(new string[]
				{
					"[",
					string_1,
					"] ",
					string_0,
					"\n"
				}));
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=yellow>",
					"[",
					string_1,
					"] ",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002A364 File Offset: 0x00028564
		internal static void smethod_18(bool bool_10)
		{
			GClass70.smethod_73(bool_10);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002A378 File Offset: 0x00028578
		internal static void smethod_19(ConsoleColor consoleColor_0, string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(string_1);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=cyan>",
					string_1,
					"</color>",
					"] ",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002A4B4 File Offset: 0x000286B4
		private static List<string> smethod_20(GClass70.Enum1 enum1_2)
		{
			List<string> result;
			switch (enum1_2)
			{
			case GClass70.Enum1.const_1:
				result = GClass70.list_0;
				break;
			case GClass70.Enum1.const_2:
				result = GClass70.list_2;
				break;
			case GClass70.Enum1.const_3:
				result = GClass70.list_4;
				break;
			case GClass70.Enum1.const_4:
				result = GClass70.list_6;
				break;
			case GClass70.Enum1.const_5:
				result = GClass70.list_8;
				break;
			case GClass70.Enum1.const_6:
				result = GClass70.list_10;
				break;
			case GClass70.Enum1.const_7:
				result = GClass70.list_12;
				break;
			case GClass70.Enum1.const_8:
				result = GClass70.list_14;
				break;
			default:
				result = new List<string>();
				break;
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002A534 File Offset: 0x00028734
		internal static void smethod_21()
		{
			GClass70.smethod_4();
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002A548 File Offset: 0x00028748
		internal static void smethod_22(string string_0, List<string> list_16)
		{
			GClass70.smethod_99(string_0, list_16);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002A55C File Offset: 0x0002875C
		internal static void smethod_23(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write(string.Concat(new string[]
				{
					"[",
					"Abyss Client",
					"] ",
					string_0,
					"\n"
				}));
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=yellow>",
					"[",
					"Abyss Client",
					"] ",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002A668 File Offset: 0x00028868
		internal static void smethod_24(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_28(string_0, enum1_2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002A67C File Offset: 0x0002887C
		internal static void smethod_25(bool bool_10)
		{
			GClass70.smethod_77(bool_10);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002A690 File Offset: 0x00028890
		internal static void smethod_26(string string_0, string string_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_1(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002A6A8 File Offset: 0x000288A8
		internal static void smethod_27(bool bool_10)
		{
			GClass70.bool_2 = bool_10;
			GClass84.gclass48_0.bool_2 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002A6CC File Offset: 0x000288CC
		internal static void smethod_28(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_64(string_0, enum1_2);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002A6E0 File Offset: 0x000288E0
		internal static void smethod_29()
		{
			GClass70.smethod_21();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002A6F4 File Offset: 0x000288F4
		internal static void smethod_30(bool bool_10)
		{
			GClass70.smethod_66(bool_10);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002A708 File Offset: 0x00028908
		internal static void smethod_31(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_23(string_0, enum1_2);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002A71C File Offset: 0x0002891C
		internal static void smethod_32(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_65(string_0, enum1_2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002A730 File Offset: 0x00028930
		internal static void smethod_33(bool bool_10)
		{
			GClass70.bool_7 = bool_10;
			GClass84.gclass48_0.bool_7 = bool_10;
			GClass48.smethod_0();
			if (GClass70.gameObject_0)
			{
				GClass70.gameObject_0.active = bool_10;
				GClass70.smethod_29();
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002A770 File Offset: 0x00028970
		internal static void smethod_34(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=yellow>",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002A840 File Offset: 0x00028A40
		internal static void smethod_35(string string_0, string string_1, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_8(string_0, string_1, consoleColor_0, enum1_2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002A858 File Offset: 0x00028A58
		internal static void smethod_36(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_96(string_0, enum1_2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002A86C File Offset: 0x00028A6C
		internal static void smethod_37(string string_0, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = consoleColor_0;
				Console.Write("Abyss Client");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] " + string_0 + "\n");
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=",
					consoleColor_0.ToString(),
					">",
					"Abyss Client",
					"</color>",
					"] ",
					string_0
				}), enum1_2);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002A988 File Offset: 0x00028B88
		internal static void smethod_38(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_6(string_0, enum1_2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002A99C File Offset: 0x00028B9C
		internal static string smethod_39(GClass70.Enum1 enum1_2)
		{
			string result;
			switch (enum1_2)
			{
			case GClass70.Enum1.const_0:
				result = "LT_None";
				break;
			case GClass70.Enum1.const_1:
				result = "LT_Mutual";
				break;
			case GClass70.Enum1.const_2:
				result = "LT_AntiCrash";
				break;
			case GClass70.Enum1.const_3:
				result = "LT_JoinLeave";
				break;
			case GClass70.Enum1.const_4:
				result = "LT_Moderation";
				break;
			case GClass70.Enum1.const_5:
				result = "LT_Avatars";
				break;
			case GClass70.Enum1.const_6:
				result = "LT_Udon";
				break;
			case GClass70.Enum1.const_7:
				result = "LT_General";
				break;
			case GClass70.Enum1.const_8:
				result = "LT_Lovense";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002AA28 File Offset: 0x00028C28
		internal static bool smethod_40()
		{
			return GClass70.gameObject_2 ? GClass70.gameObject_2.activeSelf : GClass70.bool_8;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002AA54 File Offset: 0x00028C54
		internal static void smethod_41(int int_1)
		{
			GClass70.int_0 = int_1;
			if (GClass70.text_0)
			{
				GClass70.text_0.fontSize = int_1;
			}
			if (GClass70.text_1)
			{
				GClass70.text_1.fontSize = int_1;
			}
			GClass84.gclass48_0.int_0 = int_1;
			GClass48.smethod_0();
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002AAA8 File Offset: 0x00028CA8
		internal static void smethod_42(bool bool_10)
		{
			GClass70.smethod_78(bool_10);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002AABC File Offset: 0x00028CBC
		internal static GClass70.Enum1 smethod_43(string string_0)
		{
			uint num = Class217.smethod_0(string_0);
			if (num <= 1570762154U)
			{
				if (num <= 600509308U)
				{
					if (num != 117763422U)
					{
						if (num == 600509308U)
						{
							if (string_0 == "LT_None")
							{
								return GClass70.Enum1.const_0;
							}
						}
					}
					else if (string_0 == "LT_General")
					{
						return GClass70.Enum1.const_7;
					}
				}
				else if (num != 1095536610U)
				{
					if (num == 1570762154U)
					{
						if (string_0 == "LT_Mutual")
						{
							return GClass70.Enum1.const_1;
						}
					}
				}
				else if (string_0 == "LT_Udon")
				{
					return GClass70.Enum1.const_6;
				}
			}
			else if (num <= 2845302908U)
			{
				if (num != 2596636261U)
				{
					if (num == 2845302908U)
					{
						if (string_0 == "LT_Avatars")
						{
							return GClass70.Enum1.const_5;
						}
					}
				}
				else if (string_0 == "LT_AntiCrash")
				{
					return GClass70.Enum1.const_2;
				}
			}
			else if (num != 3666827590U)
			{
				if (num != 3670716921U)
				{
					if (num == 4032231076U)
					{
						if (string_0 == "LT_Lovense")
						{
							return GClass70.Enum1.const_8;
						}
					}
				}
				else if (string_0 == "LT_JoinLeave")
				{
					return GClass70.Enum1.const_3;
				}
			}
			else if (string_0 == "LT_Moderation")
			{
				return GClass70.Enum1.const_4;
			}
			return GClass70.Enum1.const_0;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002ABFC File Offset: 0x00028DFC
		internal static void smethod_44(string string_0, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_37(string_0, consoleColor_0, enum1_2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002AC14 File Offset: 0x00028E14
		internal static void smethod_45(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(string_1);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=cyan>",
					string_1,
					"</color>",
					"] ",
					string_0
				}), enum1_2);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002AD20 File Offset: 0x00028F20
		internal static void smethod_46(bool bool_10)
		{
			GClass70.smethod_113(bool_10);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002AD34 File Offset: 0x00028F34
		internal static void smethod_47(string string_0, string string_1, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_35(string_0, string_1, consoleColor_0, enum1_2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002AD4C File Offset: 0x00028F4C
		internal static void smethod_48()
		{
			GClass70.smethod_103();
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002AD60 File Offset: 0x00028F60
		internal static void smethod_49(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002AE48 File Offset: 0x00029048
		internal static void smethod_50(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_5(enum1_2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002AE5C File Offset: 0x0002905C
		internal static void smethod_51(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_95(string_0, enum1_2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002AE70 File Offset: 0x00029070
		internal static void smethod_52(ConsoleColor consoleColor_0, string string_0, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_74(consoleColor_0, string_0, consoleColor_1, enum1_2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002AE88 File Offset: 0x00029088
		internal static void smethod_53(ConsoleColor consoleColor_0, string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_19(consoleColor_0, string_0, string_1, enum1_2);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002AEA0 File Offset: 0x000290A0
		internal static void smethod_54(bool bool_10)
		{
			GClass70.smethod_123(bool_10);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002AEB4 File Offset: 0x000290B4
		internal static void smethod_55(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002AF28 File Offset: 0x00029128
		internal static void smethod_56(bool bool_10)
		{
			GClass70.bool_1 = bool_10;
			GClass84.gclass48_0.bool_1 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002AF4C File Offset: 0x0002914C
		internal static void smethod_57(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_82(list_16, enum1_2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002AF60 File Offset: 0x00029160
		internal static void smethod_58(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_102(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002AF78 File Offset: 0x00029178
		internal static void smethod_59(string string_0, GClass70.Enum1 enum1_2)
		{
			switch (enum1_2)
			{
			case GClass70.Enum1.const_2:
				if (GClass70.bool_1)
				{
					GClass70.list_2.Insert(0, string_0);
					while (GClass70.list_2.Count > 0 && GClass70.list_2.Count > 250)
					{
						GClass70.list_2.RemoveAt(GClass70.list_2.Count - 1);
					}
					for (int i = 0; i < GClass70.list_3.Count; i++)
					{
						GClass70.list_3[i]();
					}
				}
				break;
			case GClass70.Enum1.const_3:
				if (GClass70.bool_2)
				{
					GClass70.list_4.Insert(0, string_0);
					while (GClass70.list_4.Count > 0 && GClass70.list_4.Count > 250)
					{
						GClass70.list_4.RemoveAt(GClass70.list_4.Count - 1);
					}
					for (int j = 0; j < GClass70.list_5.Count; j++)
					{
						GClass70.list_5[j]();
					}
				}
				break;
			case GClass70.Enum1.const_4:
				if (GClass70.bool_3)
				{
					GClass70.list_6.Insert(0, string_0);
					while (GClass70.list_6.Count > 0 && GClass70.list_6.Count > 250)
					{
						GClass70.list_6.RemoveAt(GClass70.list_6.Count - 1);
					}
					for (int k = 0; k < GClass70.list_7.Count; k++)
					{
						GClass70.list_7[k]();
					}
				}
				break;
			case GClass70.Enum1.const_5:
				if (GClass70.bool_4)
				{
					GClass70.list_8.Insert(0, string_0);
					while (GClass70.list_8.Count > 0 && GClass70.list_8.Count > 250)
					{
						GClass70.list_8.RemoveAt(GClass70.list_8.Count - 1);
					}
					for (int l = 0; l < GClass70.list_9.Count; l++)
					{
						GClass70.list_9[l]();
					}
				}
				break;
			case GClass70.Enum1.const_6:
				if (GClass70.bool_5)
				{
					GClass70.list_10.Insert(0, string_0);
					while (GClass70.list_10.Count > 0 && GClass70.list_10.Count > 250)
					{
						GClass70.list_10.RemoveAt(GClass70.list_10.Count - 1);
					}
					for (int m = 0; m < GClass70.list_11.Count; m++)
					{
						GClass70.list_11[m]();
					}
				}
				break;
			case GClass70.Enum1.const_7:
				if (GClass70.bool_6)
				{
					GClass70.list_12.Insert(0, string_0);
					while (GClass70.list_12.Count > 0 && GClass70.list_12.Count > 250)
					{
						GClass70.list_12.RemoveAt(GClass70.list_12.Count - 1);
					}
					for (int n = 0; n < GClass70.list_13.Count; n++)
					{
						GClass70.list_13[n]();
					}
				}
				break;
			}
			if (enum1_2 > GClass70.Enum1.const_0 && GClass70.bool_0)
			{
				GClass70.list_0.Insert(0, string_0);
				while (GClass70.list_0.Count > 0 && GClass70.list_0.Count > 250)
				{
					GClass70.list_0.RemoveAt(GClass70.list_0.Count - 1);
				}
				for (int num = 0; num < GClass70.list_1.Count; num++)
				{
					GClass70.list_1[num]();
				}
				GClass70.smethod_50(GClass70.Enum1.const_1);
			}
			if (enum1_2 != GClass70.Enum1.const_1)
			{
				GClass70.smethod_50(enum1_2);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002B368 File Offset: 0x00029568
		internal static void smethod_60(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_3(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002B380 File Offset: 0x00029580
		internal static void smethod_61(bool bool_10)
		{
			GClass70.bool_3 = bool_10;
			GClass84.gclass48_0.bool_3 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002B3A4 File Offset: 0x000295A4
		internal static void smethod_62(bool bool_10)
		{
			GClass70.smethod_15(bool_10);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002B3B8 File Offset: 0x000295B8
		internal static void smethod_63(bool bool_10)
		{
			GClass70.bool_4 = bool_10;
			GClass84.gclass48_0.bool_4 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002B3DC File Offset: 0x000295DC
		internal static void smethod_64(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string_0, enum1_2);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002B41C File Offset: 0x0002961C
		internal static void smethod_65(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(string.Concat(new string[]
				{
					"[",
					"Abyss Client",
					"] ",
					string_0,
					"\n"
				}));
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=red>",
					"[",
					"Abyss Client",
					"] ",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002B528 File Offset: 0x00029728
		internal static void smethod_66(bool bool_10)
		{
			GClass70.smethod_121(bool_10);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002B53C File Offset: 0x0002973C
		internal static void smethod_67(GClass70.Enum1 enum1_2)
		{
			GClass70.enum1_1 = enum1_2;
			GClass84.gclass48_0.string_1 = GClass70.smethod_89(enum1_2);
			GClass48.smethod_0();
			GClass70.smethod_84();
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002B56C File Offset: 0x0002976C
		internal static void smethod_68(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_12(enum1_2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002B580 File Offset: 0x00029780
		internal static void smethod_69(bool bool_10)
		{
			GClass70.bool_5 = bool_10;
			GClass84.gclass48_0.bool_5 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002B5A4 File Offset: 0x000297A4
		internal static void smethod_70(int int_1)
		{
			GClass70.smethod_41(int_1);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002B5B8 File Offset: 0x000297B8
		internal static bool smethod_71()
		{
			return GClass70.gameObject_0 ? GClass70.gameObject_0.activeSelf : GClass70.bool_7;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002B5E4 File Offset: 0x000297E4
		internal static void smethod_72(string string_0, string string_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_60(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002B5FC File Offset: 0x000297FC
		internal static void smethod_73(bool bool_10)
		{
			GClass70.smethod_11(bool_10);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002B610 File Offset: 0x00029810
		internal static void smethod_74(ConsoleColor consoleColor_0, string string_0, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_90(consoleColor_0, string_0, consoleColor_1, enum1_2);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002B724 File Offset: 0x00029924
		internal static void smethod_75(ConsoleColor consoleColor_0, string string_0, string string_1, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_79(consoleColor_0, string_0, string_1, consoleColor_1, enum1_2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002B740 File Offset: 0x00029940
		internal static void smethod_76(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_0(enum1_2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002B754 File Offset: 0x00029954
		internal static void smethod_77(bool bool_10)
		{
			GClass70.smethod_33(bool_10);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002B768 File Offset: 0x00029968
		internal static void smethod_78(bool bool_10)
		{
			GClass70.smethod_2(bool_10);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002B77C File Offset: 0x0002997C
		internal static void smethod_79(ConsoleColor consoleColor_0, string string_0, string string_1, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_120(consoleColor_0, string_0, string_1, consoleColor_1, enum1_2);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0002B798 File Offset: 0x00029998
		internal static void smethod_80(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_49(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002B7B0 File Offset: 0x000299B0
		internal static void smethod_81(bool bool_10)
		{
			GClass70.smethod_56(bool_10);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002B7C4 File Offset: 0x000299C4
		internal static void smethod_82(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				for (int i = 0; i < list_16.Count; i++)
				{
					Console.ForegroundColor = list_16[i].consoleColor_0;
					Console.Write(list_16[i].string_0);
				}
				Console.Write("\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				string text = string.Empty;
				for (int j = 0; j < list_16.Count; j++)
				{
					text = string.Concat(new string[]
					{
						text,
						"<color=",
						list_16[j].consoleColor_0.ToString(),
						">",
						list_16[j].string_0,
						"</color>"
					});
				}
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					text
				}), enum1_2);
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0002B928 File Offset: 0x00029B28
		internal static void smethod_83(GClass70.Enum1 enum1_2)
		{
			if (enum1_2 != GClass70.Enum1.const_0)
			{
				if (GClass70.enum1_0 == enum1_2)
				{
					GClass70.smethod_29();
				}
				if (GClass70.enum1_1 == enum1_2)
				{
					GClass70.smethod_84();
				}
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0002B95C File Offset: 0x00029B5C
		internal static void smethod_84()
		{
			GClass70.smethod_48();
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002B970 File Offset: 0x00029B70
		internal static void smethod_85(bool bool_10)
		{
			GClass70.smethod_61(bool_10);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002B984 File Offset: 0x00029B84
		internal static void smethod_86(bool bool_10)
		{
			GClass70.smethod_81(bool_10);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002B998 File Offset: 0x00029B98
		internal static void smethod_87(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_31(string_0, enum1_2);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0002B9AC File Offset: 0x00029BAC
		internal static void smethod_88(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write("Abyss Client");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=cyan>",
					"Abyss Client",
					"</color>",
					"] ",
					string_0
				}), enum1_2);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		internal static string smethod_89(GClass70.Enum1 enum1_2)
		{
			return GClass70.smethod_114(enum1_2);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		internal static void smethod_90(ConsoleColor consoleColor_0, string string_0, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = consoleColor_1;
				Console.Write("Abyss Client");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=",
					consoleColor_1.ToString(),
					">",
					"Abyss Client",
					"</color>",
					"] ",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002BC30 File Offset: 0x00029E30
		internal static void smethod_91(string string_0, List<string> list_16)
		{
			if (!(GClass84.smethod_362(string_0) != GClass84.smethod_362("Logger")) && list_16 != null)
			{
				for (int i = 0; i < list_16.Count; i++)
				{
					try
					{
						string text = list_16[i];
					}
					catch (Exception ex)
					{
						GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002BC98 File Offset: 0x00029E98
		internal static void smethod_92(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write("Abyss Client");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=cyan>",
					"Abyss Client",
					"</color>",
					"] ",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002BDDC File Offset: 0x00029FDC
		internal static void smethod_93()
		{
			GClass70.smethod_100();
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002BDF0 File Offset: 0x00029FF0
		internal static void smethod_94(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				for (int i = 0; i < list_16.Count; i++)
				{
					Console.ForegroundColor = list_16[i].consoleColor_0;
					Console.Write(list_16[i].string_0);
				}
				Console.Write("\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				string text = string.Empty;
				for (int j = 0; j < list_16.Count; j++)
				{
					text = string.Concat(new string[]
					{
						text,
						"<color=",
						list_16[j].consoleColor_0.ToString(),
						">",
						list_16[j].string_0,
						"</color>"
					});
				}
				GClass70.smethod_104(text, enum1_2);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002BED0 File Offset: 0x0002A0D0
		internal static void smethod_95(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_34(string_0, enum1_2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
		internal static void smethod_96(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_105(string_0, enum1_2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002BEF8 File Offset: 0x0002A0F8
		internal static void smethod_97(string string_0, ConsoleColor consoleColor_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_44(string_0, consoleColor_0, enum1_2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002BF10 File Offset: 0x0002A110
		internal static void smethod_98(bool bool_10)
		{
			GClass70.smethod_69(bool_10);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002BF24 File Offset: 0x0002A124
		internal static void smethod_99(string string_0, List<string> list_16)
		{
			GClass70.smethod_91(string_0, list_16);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002BF38 File Offset: 0x0002A138
		internal static void smethod_100()
		{
			GClass70.smethod_128();
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002BF4C File Offset: 0x0002A14C
		internal static void smethod_101(bool bool_10)
		{
			GClass70.smethod_46(bool_10);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002BF60 File Offset: 0x0002A160
		internal static void smethod_102(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_55(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002BF78 File Offset: 0x0002A178
		internal static void smethod_103()
		{
			if (GClass70.text_1)
			{
				GClass70.text_1.text = string.Join("\n", GClass70.smethod_20(GClass70.enum1_1));
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		internal static void smethod_104(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_16(string_0, enum1_2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		internal static void smethod_105(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					"<color=red>",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002C094 File Offset: 0x0002A294
		internal static void smethod_106(string string_0, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] ",
					string_0
				}), enum1_2);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002C154 File Offset: 0x0002A354
		internal static void smethod_107(GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_68(enum1_2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002C168 File Offset: 0x0002A368
		internal static void smethod_108(string string_0, string string_1, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_45(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002C180 File Offset: 0x0002A380
		internal static void smethod_109(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_32(string_0, enum1_2);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0002C194 File Offset: 0x0002A394
		internal static void smethod_110(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_126(list_16, enum1_2);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		internal static GClass70.Enum1 smethod_111()
		{
			return GClass70.enum1_0;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0002C1BC File Offset: 0x0002A3BC
		internal static void smethod_112(string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_88(string_0, enum1_2);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
		internal static void smethod_113(bool bool_10)
		{
			GClass70.bool_6 = bool_10;
			GClass84.gclass48_0.bool_6 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0002C1F4 File Offset: 0x0002A3F4
		internal static string smethod_114(GClass70.Enum1 enum1_2)
		{
			return GClass70.smethod_39(enum1_2);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0002C208 File Offset: 0x0002A408
		internal static void smethod_115(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_57(list_16, enum1_2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002C21C File Offset: 0x0002A41C
		internal static GClass70.Enum1 smethod_116()
		{
			return GClass70.enum1_1;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002C230 File Offset: 0x0002A430
		internal static void smethod_117(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_80(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002C248 File Offset: 0x0002A448
		internal static void smethod_118()
		{
			GClass70.smethod_14();
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0002C25C File Offset: 0x0002A45C
		internal static void smethod_119(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_92(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0002C274 File Offset: 0x0002A474
		internal static void smethod_120(ConsoleColor consoleColor_0, string string_0, string string_1, ConsoleColor consoleColor_1, GClass70.Enum1 enum1_2)
		{
			if (GClass70.bool_9)
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("[");
				Console.ForegroundColor = consoleColor_1;
				Console.Write(string_1);
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.Write("] ");
				Console.ForegroundColor = consoleColor_0;
				Console.Write(string_0 + "\n");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			if (enum1_2 > GClass70.Enum1.const_0)
			{
				GClass70.smethod_104(string.Concat(new string[]
				{
					"[",
					"<color=lime>",
					DateTime.Now.ToString("HH:mm:ss.fff"),
					"</color>",
					"] [",
					"<color=",
					consoleColor_1.ToString(),
					">",
					string_1,
					"</color>",
					"] ",
					"<color=",
					consoleColor_0.ToString(),
					">",
					string_0,
					"</color>"
				}), enum1_2);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		internal static void smethod_121(bool bool_10)
		{
			GClass70.bool_0 = bool_10;
			GClass84.gclass48_0.bool_0 = bool_10;
			GClass48.smethod_0();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
		internal static void smethod_122()
		{
			GClass70.smethod_118();
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0002C404 File Offset: 0x0002A604
		internal static void smethod_123(bool bool_10)
		{
			GClass70.smethod_63(bool_10);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002C418 File Offset: 0x0002A618
		internal static void smethod_124(ConsoleColor consoleColor_0, string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_119(consoleColor_0, string_0, enum1_2);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002C430 File Offset: 0x0002A630
		internal static void smethod_125(string string_0, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_112(string_0, enum1_2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0002C444 File Offset: 0x0002A644
		internal static void smethod_126(List<GClass84.GStruct172> list_16, GClass70.Enum1 enum1_2)
		{
			GClass70.smethod_94(list_16, enum1_2);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002C458 File Offset: 0x0002A658
		internal static void smethod_127(string string_0, string string_1, GClass70.Enum1 enum1_2 = GClass70.Enum1.const_0)
		{
			GClass70.smethod_108(string_0, string_1, enum1_2);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002C470 File Offset: 0x0002A670
		internal static void smethod_128()
		{
			GClass84.list_13.Add(new Action(GClass70.smethod_122));
			GClass84.list_15.Add(new Action<string, List<string>>(GClass70.smethod_22));
			GClass48.smethod_1();
			GClass84.gclass48_0 = GClass48.gclass48_0;
			GClass70.bool_0 = GClass84.gclass48_0.bool_0;
			GClass70.bool_1 = GClass84.gclass48_0.bool_1;
			GClass70.bool_2 = GClass84.gclass48_0.bool_2;
			GClass70.bool_3 = GClass84.gclass48_0.bool_3;
			GClass70.bool_4 = GClass84.gclass48_0.bool_4;
			GClass70.bool_5 = GClass84.gclass48_0.bool_5;
			GClass70.bool_6 = GClass84.gclass48_0.bool_6;
			GClass70.int_0 = GClass84.gclass48_0.int_0;
			GClass70.bool_7 = GClass84.gclass48_0.bool_7;
			GClass70.enum1_0 = GClass70.smethod_43(GClass84.gclass48_0.string_0);
			GClass70.bool_8 = GClass84.gclass48_0.bool_8;
			GClass70.enum1_1 = GClass70.smethod_43(GClass84.gclass48_0.string_1);
			GClass70.bool_9 = GClass84.gclass48_0.bool_9;
		}

		// Token: 0x0400074F RID: 1871
		internal static bool bool_0 = false;

		// Token: 0x04000750 RID: 1872
		internal static List<string> list_0 = new List<string>();

		// Token: 0x04000751 RID: 1873
		internal static List<Action> list_1 = new List<Action>();

		// Token: 0x04000752 RID: 1874
		internal static bool bool_1 = false;

		// Token: 0x04000753 RID: 1875
		internal static List<string> list_2 = new List<string>();

		// Token: 0x04000754 RID: 1876
		internal static List<Action> list_3 = new List<Action>();

		// Token: 0x04000755 RID: 1877
		internal static bool bool_2 = false;

		// Token: 0x04000756 RID: 1878
		internal static List<string> list_4 = new List<string>();

		// Token: 0x04000757 RID: 1879
		internal static List<Action> list_5 = new List<Action>();

		// Token: 0x04000758 RID: 1880
		internal static bool bool_3 = false;

		// Token: 0x04000759 RID: 1881
		internal static List<string> list_6 = new List<string>();

		// Token: 0x0400075A RID: 1882
		internal static List<Action> list_7 = new List<Action>();

		// Token: 0x0400075B RID: 1883
		internal static bool bool_4 = false;

		// Token: 0x0400075C RID: 1884
		internal static List<string> list_8 = new List<string>();

		// Token: 0x0400075D RID: 1885
		internal static List<Action> list_9 = new List<Action>();

		// Token: 0x0400075E RID: 1886
		internal static bool bool_5 = false;

		// Token: 0x0400075F RID: 1887
		internal static List<string> list_10 = new List<string>();

		// Token: 0x04000760 RID: 1888
		internal static List<Action> list_11 = new List<Action>();

		// Token: 0x04000761 RID: 1889
		internal static bool bool_6 = false;

		// Token: 0x04000762 RID: 1890
		internal static List<string> list_12 = new List<string>();

		// Token: 0x04000763 RID: 1891
		internal static List<Action> list_13 = new List<Action>();

		// Token: 0x04000764 RID: 1892
		internal static List<string> list_14 = new List<string>();

		// Token: 0x04000765 RID: 1893
		internal static List<Action> list_15 = new List<Action>();

		// Token: 0x04000766 RID: 1894
		internal static int int_0 = 50;

		// Token: 0x04000767 RID: 1895
		private static GameObject gameObject_0;

		// Token: 0x04000768 RID: 1896
		private static RawImage rawImage_0;

		// Token: 0x04000769 RID: 1897
		private static GameObject gameObject_1;

		// Token: 0x0400076A RID: 1898
		private static Text text_0;

		// Token: 0x0400076B RID: 1899
		private static bool bool_7 = false;

		// Token: 0x0400076C RID: 1900
		private static GClass70.Enum1 enum1_0 = GClass70.Enum1.const_0;

		// Token: 0x0400076D RID: 1901
		private static GameObject gameObject_2;

		// Token: 0x0400076E RID: 1902
		private static RawImage rawImage_1;

		// Token: 0x0400076F RID: 1903
		private static GameObject gameObject_3;

		// Token: 0x04000770 RID: 1904
		private static Text text_1;

		// Token: 0x04000771 RID: 1905
		private static bool bool_8 = false;

		// Token: 0x04000772 RID: 1906
		private static GClass70.Enum1 enum1_1 = GClass70.Enum1.const_0;

		// Token: 0x04000773 RID: 1907
		internal static bool bool_9 = true;

		// Token: 0x0200012A RID: 298
		internal enum Enum1
		{
			// Token: 0x04000775 RID: 1909
			const_0,
			// Token: 0x04000776 RID: 1910
			const_1,
			// Token: 0x04000777 RID: 1911
			const_2,
			// Token: 0x04000778 RID: 1912
			const_3,
			// Token: 0x04000779 RID: 1913
			const_4,
			// Token: 0x0400077A RID: 1914
			const_5,
			// Token: 0x0400077B RID: 1915
			const_6,
			// Token: 0x0400077C RID: 1916
			const_7,
			// Token: 0x0400077D RID: 1917
			const_8
		}
	}
}
