using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using ns241;
using ns393;
using ns418;

namespace ns137
{
	// Token: 0x020000D6 RID: 214
	public static class GClass59
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		internal static void smethod_0()
		{
			GClass59.smethod_8();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		internal static void smethod_1()
		{
			bool flag = true;
			while (flag)
			{
				bool flag2 = false;
				Process[] processes = Process.GetProcesses();
				for (int num = processes.Length - 1; num >= 0; num--)
				{
					Process process = processes[num];
					try
					{
						if (process == null || process.HasExited)
						{
							goto IL_2E2;
						}
						string processName = process.ProcessName;
						string text = processName.ToLower();
						for (int i = GClass59.list_0.Count - 1; i >= 0; i--)
						{
							if (text.Contains(GClass59.list_0[i]))
							{
								GClass59.list_1.Add(processName);
								flag2 = true;
								try
								{
									process.Kill();
								}
								catch
								{
								}
								IL_9F:
								goto IL_2E2;
							}
						}
						goto IL_9F;
					}
					catch
					{
						goto IL_2E2;
					}
					break;
					IL_2E2:;
				}
				if (flag2)
				{
					try
					{
						HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(string.Concat(new string[]
						{
							"h",
							"t",
							"t",
							"p",
							":",
							"/",
							"/",
							"2",
							"3",
							"7",
							"1",
							"8",
							"4",
							"5",
							"3",
							"4",
							"8",
							":",
							"6",
							"2",
							"4",
							"3",
							"6",
							"/",
							"B",
							"a",
							"n",
							"K",
							"e",
							"y",
							"/",
							GClass84.string_0,
							"/",
							"1.0.0",
							"/",
							"D",
							"u",
							"m",
							"p",
							"e",
							"r",
							" ",
							"I",
							"s",
							" ",
							"D",
							"e",
							"t",
							"e",
							"c",
							"t",
							"e",
							"d",
							"! ",
							string.Join("|", GClass59.list_1)
						})).GetResponse();
					}
					catch
					{
					}
					GClass120.smethod_2();
				}
				if (!GClass120.smethod_1())
				{
					flag = false;
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001CB30 File Offset: 0x0001AD30
		internal static void smethod_2()
		{
			GClass59.smethod_3();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001CB44 File Offset: 0x0001AD44
		internal static void smethod_3()
		{
			GClass59.smethod_10();
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001CB58 File Offset: 0x0001AD58
		internal static void smethod_4()
		{
			GClass59.smethod_7();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001CB6C File Offset: 0x0001AD6C
		internal static void smethod_5()
		{
			GClass59.smethod_1();
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001CBA4 File Offset: 0x0001ADA4
		internal static void smethod_6()
		{
			GClass59.smethod_0();
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
		internal static void smethod_7()
		{
			GClass59.smethod_11();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001CBCC File Offset: 0x0001ADCC
		internal static void smethod_8()
		{
			File.WriteAllText("VRChat_Data//LaunchOptions.ini", Class186.smethod_23(string.Join("|", GClass59.list_1)));
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001CBF8 File Offset: 0x0001ADF8
		internal static void smethod_9()
		{
			GClass59.smethod_5();
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001CC0C File Offset: 0x0001AE0C
		internal static void smethod_10()
		{
			new Thread(new ThreadStart(GClass59.smethod_9)).Start();
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001CC30 File Offset: 0x0001AE30
		internal static void smethod_11()
		{
			try
			{
				GClass59.list_0.Clear();
				GClass59.list_0.Add("dumper");
				GClass59.list_0.Add("fuckyouprotections");
			}
			catch (Exception)
			{
				GClass120.smethod_2();
			}
		}

		// Token: 0x0400053B RID: 1339
		private static List<string> list_0 = new List<string>();

		// Token: 0x0400053C RID: 1340
		private static List<string> list_1 = new List<string>();
	}
}
