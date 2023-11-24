using System;
using System.Collections.Generic;
using ns137;
using ns241;

namespace ns418
{
	// Token: 0x02000327 RID: 807
	internal static class Class186
	{
		// Token: 0x0600415D RID: 16733 RVA: 0x000F7F8C File Offset: 0x000F618C
		internal static string smethod_0(char char_0, Class186.Struct33 struct33_0, string string_0)
		{
			return Class186.smethod_7(char_0, struct33_0, string_0);
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x000F7FA4 File Offset: 0x000F61A4
		internal static string smethod_1(ref string string_0, Class186.Struct33 struct33_0, ref int int_0, string string_1)
		{
			return Class186.smethod_25(ref string_0, struct33_0, ref int_0, string_1);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x000F7FBC File Offset: 0x000F61BC
		internal static string smethod_2(string string_0, string string_1, bool bool_0)
		{
			return Class186.smethod_19(string_0, string_1, bool_0);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x000F7FD4 File Offset: 0x000F61D4
		internal static string smethod_3(string string_0)
		{
			return Class186.smethod_27(string_0);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x000F7FE8 File Offset: 0x000F61E8
		internal static void smethod_4()
		{
			Class186.smethod_29();
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x000F7FFC File Offset: 0x000F61FC
		internal static string smethod_5(string string_0)
		{
			return Class186.smethod_22(string_0);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x000F8010 File Offset: 0x000F6210
		internal static string smethod_6()
		{
			return Class186.smethod_16();
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x000F8024 File Offset: 0x000F6224
		internal static string smethod_7(char char_0, Class186.Struct33 struct33_0, string string_0)
		{
			return Class186.smethod_26(char_0, struct33_0, string_0);
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x000F803C File Offset: 0x000F623C
		internal static string smethod_8(string string_0)
		{
			return Class186.smethod_18(string_0);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000F8050 File Offset: 0x000F6250
		internal static string smethod_9(string string_0, string string_1, bool bool_0)
		{
			return Class186.smethod_2(string_0, string_1, bool_0);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000F8068 File Offset: 0x000F6268
		internal static string smethod_10(string string_0)
		{
			string string_ = GClass84.smethod_1566(ref string_0, " ");
			return Class186.smethod_9(string_0, string_, false);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x000F80B0 File Offset: 0x000F62B0
		internal static string smethod_11(string string_0, string string_1, bool bool_0)
		{
			return Class186.smethod_20(string_0, string_1, bool_0);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x000F80C8 File Offset: 0x000F62C8
		internal static string smethod_12(string string_0, string string_1, bool bool_0)
		{
			string result;
			if (string_0 == string.Empty || string_1 == string.Empty)
			{
				result = string.Empty;
			}
			else
			{
				List<Class186.Struct33> list = new List<Class186.Struct33>();
				string text = string.Empty;
				if (!bool_0)
				{
					string_1 = Class186.smethod_15(string_1);
				}
				int num = 0;
				while (string_1 != string.Empty && num < Class186.list_0.Count)
				{
					if (GClass84.smethod_1428(string_1, 1) == "1" && !Class186.list_0[num].bool_0)
					{
						list.Add(Class186.list_0[num]);
					}
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
					num++;
				}
				if (list.Count == 0)
				{
					result = string_0;
				}
				else
				{
					int num2 = 0;
					for (int i = 0; i < GClass84.smethod_593(string_0); i++)
					{
						text += Class186.smethod_0(string_0[i], list[num2], text);
						num2++;
						if (num2 >= list.Count)
						{
							num2 = 0;
						}
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x000F81EC File Offset: 0x000F63EC
		internal static string smethod_13(string string_0)
		{
			return Class186.smethod_10(string_0);
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x000F8200 File Offset: 0x000F6400
		internal static string smethod_14()
		{
			return Class186.smethod_6();
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x000F8214 File Offset: 0x000F6414
		internal static string smethod_15(string string_0)
		{
			return Class186.smethod_3(string_0);
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x000F8228 File Offset: 0x000F6428
		internal static string smethod_16()
		{
			string text = string.Empty;
			for (int i = 0; i < Class186.list_0.Count; i++)
			{
				text += GClass84.smethod_108<char>(Class186.list_0[i].bool_0, '-', '+').ToString();
			}
			return text;
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x000F8280 File Offset: 0x000F6480
		internal static void smethod_17()
		{
			Class186.smethod_4();
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x000F8294 File Offset: 0x000F6494
		internal static string smethod_18(string string_0)
		{
			string text = string.Empty;
			int num = 10000;
			int num2 = 99999;
			while (!(GClass84.smethod_1528(GClass84.smethod_1428(string_0, GClass84.smethod_593("\\BreakLoop"))) == GClass84.smethod_1528("\\BreakLoop")))
			{
				if (GClass84.smethod_1528(GClass84.smethod_1428(string_0, GClass84.smethod_593("\\MinMask="))) == GClass84.smethod_1528("\\MinMask="))
				{
					string string_ = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\MinMask="), -1);
					int num3 = GClass84.smethod_1611(string_, " ");
					string_ = GClass84.smethod_1428(string_, num3);
					string_0 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\MinMask=") + num3 + 1, -1);
					int num4;
					if (GClass84.smethod_1238(string_, out num4) && num4 > 0)
					{
						num = num4;
					}
				}
				else if (GClass84.smethod_1528(GClass84.smethod_1428(string_0, GClass84.smethod_593("\\MaxMask="))) == GClass84.smethod_1528("\\MaxMask="))
				{
					string string_2 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\MaxMask="), -1);
					int num5 = GClass84.smethod_1611(string_2, " ");
					string_2 = GClass84.smethod_1428(string_2, num5);
					string_0 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\MaxMask=") + num5 + 1, -1);
					int num6;
					if (GClass84.smethod_1238(string_2, out num6) && num6 > 0)
					{
						num2 = num6;
					}
				}
				else if (GClass84.smethod_1528(GClass84.smethod_1428(string_0, GClass84.smethod_593("\\Mask="))) == GClass84.smethod_1528("\\Mask="))
				{
					string text2 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\Mask="), -1);
					int num7 = GClass84.smethod_1611(text2, " ");
					text2 = GClass84.smethod_1428(text2, num7);
					string_0 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\Mask=") + num7 + 1, -1);
					text = "0" + " " + text2;
				}
				else
				{
					if (!(GClass84.smethod_1528(GClass84.smethod_1428(string_0, GClass84.smethod_593("\\BinMask="))) == GClass84.smethod_1528("\\BinMask=")))
					{
						IL_266:
						if (text == string.Empty)
						{
							text = "0" + " " + (num + GClass84.smethod_1673(num2 - num + 1)).ToString();
						}
						return GClass84.smethod_108<string>(GClass84.smethod_1428(text, 1) == "1", Class186.smethod_28(GClass84.smethod_1204(text, 2, -1)), GClass84.smethod_1204(text, 2, -1)) + " " + Class186.smethod_11(string_0, GClass84.smethod_1204(text, 2, -1), GClass84.smethod_1428(text, 1) == "1");
					}
					string text3 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\BinMask="), -1);
					int num8 = GClass84.smethod_1611(text3, " ");
					text3 = GClass84.smethod_1428(text3, num8);
					string_0 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\BinMask=") + num8 + 1, -1);
					text = "1" + " " + text3;
				}
			}
			string_0 = GClass84.smethod_1204(string_0, GClass84.smethod_593("\\BreakLoop") + 1, -1);
			goto IL_266;
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x000F8594 File Offset: 0x000F6794
		internal static string smethod_19(string string_0, string string_1, bool bool_0)
		{
			string result;
			if (string_0 == string.Empty || string_1 == string.Empty)
			{
				result = string.Empty;
			}
			else
			{
				List<Class186.Struct33> list = new List<Class186.Struct33>();
				string text = string.Empty;
				if (!bool_0)
				{
					string_1 = Class186.smethod_15(string_1);
				}
				int num = 0;
				while (string_1 != string.Empty && num < Class186.list_0.Count)
				{
					if (GClass84.smethod_1428(string_1, 1) == "1" && !Class186.list_0[num].bool_0)
					{
						list.Add(Class186.list_0[num]);
					}
					string_1 = GClass84.smethod_1204(string_1, 1, -1);
					num++;
				}
				if (list.Count == 0)
				{
					result = string_0;
				}
				else
				{
					num = 0;
					string text2 = string_0;
					int i = 0;
					int num2 = 0;
					while (i < GClass84.smethod_593(text2))
					{
						text += Class186.smethod_24(ref string_0, list[num], ref i, text);
						if (i == num2)
						{
							return text2;
						}
						num++;
						if (num >= list.Count)
						{
							num = 0;
						}
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x000F86B8 File Offset: 0x000F68B8
		internal static string smethod_20(string string_0, string string_1, bool bool_0)
		{
			return Class186.smethod_12(string_0, string_1, bool_0);
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x000F86D0 File Offset: 0x000F68D0
		internal static string smethod_21(string string_0)
		{
			return Class186.smethod_13(string_0);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x000F86E4 File Offset: 0x000F68E4
		internal static string smethod_22(string string_0)
		{
			int num = 0;
			string_0 = GClass84.smethod_1572(string_0);
			while (string_0 != string.Empty)
			{
				int num2 = GClass84.smethod_183(string_0);
				int num3 = GClass84.smethod_593(string_0);
				string_0 = GClass84.smethod_1204(string_0, 1, -1);
				if (num2 == 1)
				{
					for (int i = 1; i < num3; i++)
					{
						num2 *= 2;
					}
					num += num2;
				}
			}
			return num.ToString();
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x000F8750 File Offset: 0x000F6950
		internal static string smethod_23(string string_0)
		{
			return Class186.smethod_8(string_0);
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x000F8764 File Offset: 0x000F6964
		internal static string smethod_24(ref string string_0, Class186.Struct33 struct33_0, ref int int_0, string string_1)
		{
			return Class186.smethod_1(ref string_0, struct33_0, ref int_0, string_1);
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x000F877C File Offset: 0x000F697C
		internal static string smethod_25(ref string string_0, Class186.Struct33 struct33_0, ref int int_0, string string_1)
		{
			string text = string.Empty;
			int i = 0;
			while (i < Class186.list_1.Count && string_0[int_0] != Class186.list_1[i])
			{
				i++;
			}
			string result;
			if (i >= Class186.list_1.Count)
			{
				text = GClass84.smethod_1428(string_0, 1);
				int_0++;
				result = text;
			}
			else if (struct33_0.int_0 <= 0)
			{
				result = string.Empty;
			}
			else if (struct33_0.enum11_0 == Class186.Enum11.const_0)
			{
				if (struct33_0.int_0 > GClass84.smethod_593(string_0) - int_0)
				{
					result = string.Empty;
				}
				else
				{
					char c = string_0[int_0];
					for (i = 1; i < struct33_0.int_0; i++)
					{
						if (c != string_0[int_0 + i])
						{
							return string.Empty;
						}
					}
					int_0 += struct33_0.int_0;
					result = c.ToString();
				}
			}
			else
			{
				if (struct33_0.enum11_0 == Class186.Enum11.const_1)
				{
					if (struct33_0.int_0 > GClass84.smethod_593(string_0) - int_0)
					{
						return string.Empty;
					}
					int j = 0;
					for (i = 0; i < struct33_0.int_0; i++)
					{
						for (int k = 0; k < Class186.list_1.Count; k++)
						{
							if (Class186.list_1[k] == string_0[int_0 + i])
							{
								j += k;
							}
						}
					}
					while (j < 0)
					{
						j += Class186.list_1.Count;
					}
					while (j >= Class186.list_1.Count)
					{
						j -= Class186.list_1.Count;
					}
					text += Class186.list_1[j].ToString();
					int_0 += struct33_0.int_0;
				}
				else if (struct33_0.enum11_0 == Class186.Enum11.const_2)
				{
					if (struct33_0.int_0 > GClass84.smethod_593(string_0) - int_0)
					{
						return string.Empty;
					}
					int l = 0;
					for (i = 0; i < struct33_0.int_0; i++)
					{
						for (int m = 0; m < Class186.list_1.Count; m++)
						{
							if (Class186.list_1[m] == string_0[int_0 + i])
							{
								l -= m;
							}
						}
					}
					while (l < 0)
					{
						l += Class186.list_1.Count;
					}
					while (l >= Class186.list_1.Count)
					{
						l -= Class186.list_1.Count;
					}
					text += Class186.list_1[l].ToString();
					int_0 += struct33_0.int_0;
				}
				else if (struct33_0.enum11_0 == Class186.Enum11.const_3)
				{
					if (struct33_0.int_0 > GClass84.smethod_593(string_0))
					{
						return string.Empty;
					}
					int n = 0;
					int num = 0;
					i = GClass84.smethod_1690(int_0 - struct33_0.int_0 + 1, 0);
					IL_357:
					while (i < int_0)
					{
						for (int num2 = 0; num2 < Class186.list_1.Count; num2++)
						{
							if (Class186.list_1[num2] == string_0[i])
							{
								n += num2;
								IL_34D:
								num++;
								i++;
								goto IL_357;
							}
						}
						goto IL_34D;
					}
					int num3 = 0;
					for (i = 0; i < struct33_0.int_0 - num; i++)
					{
						for (int num4 = 0; num4 < Class186.list_1.Count; num4++)
						{
							if (Class186.list_1[num4] == string_0[int_0 + i])
							{
								n += num4;
							}
						}
						num3++;
					}
					while (n < 0)
					{
						n += Class186.list_1.Count;
					}
					while (n >= Class186.list_1.Count)
					{
						n -= Class186.list_1.Count;
					}
					text += Class186.list_1[n].ToString();
					int_0 += num3;
				}
				else if (struct33_0.enum11_0 == Class186.Enum11.const_4)
				{
					if (struct33_0.int_0 > GClass84.smethod_593(string_0))
					{
						return string.Empty;
					}
					int num5 = 0;
					int num6 = 0;
					i = GClass84.smethod_1690(int_0 - struct33_0.int_0 + 1, 0);
					IL_4A9:
					while (i < int_0)
					{
						for (int num7 = 0; num7 < Class186.list_1.Count; num7++)
						{
							if (Class186.list_1[num7] == string_0[i])
							{
								num5 -= num7;
								IL_49F:
								num6++;
								i++;
								goto IL_4A9;
							}
						}
						goto IL_49F;
					}
					int num8 = 0;
					for (i = 0; i < struct33_0.int_0 - num6; i++)
					{
						for (int num9 = 0; num9 < Class186.list_1.Count; num9++)
						{
							if (Class186.list_1[num9] == string_0[int_0 + i])
							{
								num5 -= num9;
							}
						}
						num8++;
					}
					while (num5 < 0)
					{
						num5 += Class186.list_1.Count;
					}
					while (num5 >= Class186.list_1.Count)
					{
						num5 -= Class186.list_1.Count;
					}
					text += Class186.list_1[num5].ToString();
					int_0 += num8;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x000F8CFC File Offset: 0x000F6EFC
		internal static string smethod_26(char char_0, Class186.Struct33 struct33_0, string string_0)
		{
			string result;
			if (char_0.ToString() == string.Empty || struct33_0.int_0 <= 1)
			{
				result = char_0.ToString();
			}
			else
			{
				string text = string.Empty;
				int i = 0;
				while (i < Class186.list_1.Count && char_0 != Class186.list_1[i])
				{
					i++;
				}
				if (i >= Class186.list_1.Count)
				{
					result = char_0.ToString();
				}
				else if (struct33_0.enum11_0 == Class186.Enum11.const_0)
				{
					for (i = 0; i < struct33_0.int_0; i++)
					{
						text += char_0.ToString();
					}
					result = text;
				}
				else
				{
					if (struct33_0.enum11_0 == Class186.Enum11.const_1)
					{
						for (i = 1; i < struct33_0.int_0; i++)
						{
							text += Class186.list_1[GClass84.smethod_1673(Class186.list_1.Count)].ToString();
						}
						int j = 0;
						int k;
						for (i = 0; i < GClass84.smethod_593(text); i++)
						{
							k = 0;
							while (Class186.list_1[k] != text[i])
							{
								k++;
							}
							j += k;
						}
						k = 0;
						while (k < Class186.list_1.Count && char_0 != Class186.list_1[k])
						{
							k++;
						}
						while (j < 0)
						{
							j += Class186.list_1.Count;
						}
						while (j >= Class186.list_1.Count)
						{
							j -= Class186.list_1.Count;
						}
						while (j > k)
						{
							k += Class186.list_1.Count;
						}
						for (i = k - j; i < 0; i += Class186.list_1.Count)
						{
						}
						while (i >= Class186.list_1.Count)
						{
							i -= Class186.list_1.Count;
						}
						text += Class186.list_1[i].ToString();
					}
					else if (struct33_0.enum11_0 == Class186.Enum11.const_2)
					{
						for (i = 1; i < struct33_0.int_0; i++)
						{
							text += Class186.list_1[GClass84.smethod_1673(Class186.list_1.Count)].ToString();
						}
						int l = 0;
						int k;
						for (i = 0; i < GClass84.smethod_593(text); i++)
						{
							k = 0;
							while (Class186.list_1[k] != text[i])
							{
								k++;
							}
							l -= k;
						}
						k = 0;
						while (k < Class186.list_1.Count && char_0 != Class186.list_1[k])
						{
							k++;
						}
						while (l < 0)
						{
							l += Class186.list_1.Count;
						}
						while (l >= Class186.list_1.Count)
						{
							l -= Class186.list_1.Count;
						}
						while (l < k)
						{
							k -= Class186.list_1.Count;
						}
						for (i = l - k; i < 0; i += Class186.list_1.Count)
						{
						}
						while (i >= Class186.list_1.Count)
						{
							i -= Class186.list_1.Count;
						}
						text += Class186.list_1[i].ToString();
					}
					else if (struct33_0.enum11_0 == Class186.Enum11.const_3)
					{
						string text2 = string.Empty;
						for (i = GClass84.smethod_1690(GClass84.smethod_593(string_0) - struct33_0.int_0 + 1, 0); i < GClass84.smethod_593(string_0); i++)
						{
							text2 += string_0[i].ToString();
						}
						for (i = GClass84.smethod_593(text2) + 1; i < struct33_0.int_0; i++)
						{
							char c = Class186.list_1[GClass84.smethod_1673(Class186.list_1.Count)];
							text += c.ToString();
							text2 += c.ToString();
						}
						int m = 0;
						i = 0;
						IL_45F:
						int k;
						while (i < GClass84.smethod_593(text2))
						{
							for (k = 0; k < Class186.list_1.Count; k++)
							{
								if (Class186.list_1[k] == text2[i])
								{
									m += k;
									IL_45B:
									i++;
									goto IL_45F;
								}
							}
							goto IL_45B;
						}
						k = 0;
						while (k < Class186.list_1.Count && char_0 != Class186.list_1[k])
						{
							k++;
						}
						while (m < 0)
						{
							m += Class186.list_1.Count;
						}
						while (m >= Class186.list_1.Count)
						{
							m -= Class186.list_1.Count;
						}
						while (m > k)
						{
							k += Class186.list_1.Count;
						}
						for (i = k - m; i < 0; i += Class186.list_1.Count)
						{
						}
						while (i >= Class186.list_1.Count)
						{
							i -= Class186.list_1.Count;
						}
						text += Class186.list_1[i].ToString();
					}
					else if (struct33_0.enum11_0 == Class186.Enum11.const_4)
					{
						string text3 = string.Empty;
						for (i = GClass84.smethod_1690(GClass84.smethod_593(string_0) - struct33_0.int_0 + 1, 0); i < GClass84.smethod_593(string_0); i++)
						{
							text3 += string_0[i].ToString();
						}
						for (i = GClass84.smethod_593(text3) + 1; i < struct33_0.int_0; i++)
						{
							char c2 = Class186.list_1[GClass84.smethod_1673(Class186.list_1.Count)];
							text += c2.ToString();
							text3 += c2.ToString();
						}
						int n = 0;
						i = 0;
						IL_62F:
						int k;
						while (i < GClass84.smethod_593(text3))
						{
							for (k = 0; k < Class186.list_1.Count; k++)
							{
								if (Class186.list_1[k] == text3[i])
								{
									n -= k;
									IL_62B:
									i++;
									goto IL_62F;
								}
							}
							goto IL_62B;
						}
						k = 0;
						while (k < Class186.list_1.Count && char_0 != Class186.list_1[k])
						{
							k++;
						}
						while (n < 0)
						{
							n += Class186.list_1.Count;
						}
						while (n >= Class186.list_1.Count)
						{
							n -= Class186.list_1.Count;
						}
						while (n < k)
						{
							k -= Class186.list_1.Count;
						}
						for (i = n - k; i < 0; i += Class186.list_1.Count)
						{
						}
						while (i >= Class186.list_1.Count)
						{
							i -= Class186.list_1.Count;
						}
						text += Class186.list_1[i].ToString();
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000F9420 File Offset: 0x000F7620
		internal static string smethod_27(string string_0)
		{
			string result;
			if (string_0 == "0")
			{
				result = "0";
			}
			else
			{
				int i = 0;
				int num = 0;
				int j = 0;
				string text = string.Empty;
				while (string_0 != string.Empty)
				{
					int k;
					if (!GClass84.smethod_1238(string_0, out k))
					{
						return "0";
					}
					int num2 = k;
					if (num2 > 0)
					{
						num2 = 1;
						while (k >= num2)
						{
							num = num2;
							num2 *= 2;
						}
						i = num;
						while (j > i * 2)
						{
							text += "0";
							i *= 2;
						}
						j = num;
						i = 1;
						text += "1";
						k -= num;
						num = num2;
						if (k == 0)
						{
							num = 1;
							while (num * 2 < num2)
							{
								text += "0";
								num *= 2;
							}
							string_0 = string.Empty;
						}
						else
						{
							string_0 = k.ToString();
						}
					}
				}
				int num3 = 1;
				while (i > num3)
				{
					text += "0";
					num3++;
				}
				result = GClass84.smethod_1572(text);
			}
			return result;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x000F953C File Offset: 0x000F773C
		internal static string smethod_28(string string_0)
		{
			return Class186.smethod_5(string_0);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x000F9550 File Offset: 0x000F7750
		internal static void smethod_29()
		{
			GClass59.smethod_2();
			Class186.list_0.Clear();
			Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_0, 1, false));
			for (int i = 2; i <= 50; i++)
			{
				Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_0, i, false));
				Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_1, i, false));
				Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_2, i, false));
				Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_3, i, false));
				Class186.list_0.Add(new Class186.Struct33(Class186.Enum11.const_4, i, false));
			}
			Class186.list_1.Clear();
			for (int j = 32; j <= 126; j++)
			{
				if (j != 39 && j != 96)
				{
					Class186.list_1.Add(GClass84.smethod_1544(j));
				}
			}
		}

		// Token: 0x04001996 RID: 6550
		internal static List<Class186.Struct33> list_0 = new List<Class186.Struct33>();

		// Token: 0x04001997 RID: 6551
		internal static List<char> list_1 = new List<char>();

		// Token: 0x02000328 RID: 808
		internal enum Enum11
		{
			// Token: 0x04001999 RID: 6553
			const_0,
			// Token: 0x0400199A RID: 6554
			const_1,
			// Token: 0x0400199B RID: 6555
			const_2,
			// Token: 0x0400199C RID: 6556
			const_3,
			// Token: 0x0400199D RID: 6557
			const_4
		}

		// Token: 0x02000329 RID: 809
		internal struct Struct33
		{
			// Token: 0x0600417C RID: 16764 RVA: 0x000F9628 File Offset: 0x000F7828
			internal Struct33(Class186.Enum11 enum11_1, int int_1, bool bool_1 = false)
			{
				this.enum11_0 = enum11_1;
				this.int_0 = int_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x0400199E RID: 6558
			internal Class186.Enum11 enum11_0;

			// Token: 0x0400199F RID: 6559
			internal int int_0;

			// Token: 0x040019A0 RID: 6560
			internal bool bool_0;
		}
	}
}
