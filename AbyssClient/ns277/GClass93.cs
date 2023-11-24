using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using ns127;
using ns185;
using ns241;
using ns355;
using ns375;
using ns399;
using ns418;
using ns425;
using ns426;
using ns427;
using ns428;
using ns430;
using ns431;
using ns432;
using ns433;
using ns436;
using ns437;
using ns439;
using ns440;
using ns441;
using ns442;
using ns444;
using ns445;
using ns446;
using ns448;
using ns449;
using ns451;
using ns453;
using ns454;
using ns455;
using ns456;
using ns457;
using ns460;
using ns462;
using ns471;
using ns475;
using ns476;
using ns478;
using ns481;
using ns482;
using ns526;
using ns73;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace ns277
{
	// Token: 0x02000235 RID: 565
	public class GClass93
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x00082940 File Offset: 0x00080B40
		public static void smethod_0(int int_5)
		{
			GClass93.smethod_52(int_5);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00082954 File Offset: 0x00080B54
		private void method_0(string string_4, string string_5)
		{
			this.method_79(string_4, string_5);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0008296C File Offset: 0x00080B6C
		internal void method_1(int int_5)
		{
			if (int_5 <= 1 || int_5 >= 65535)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"[",
					"Error",
					"]",
					" ",
					"Can",
					"'",
					"t",
					" ",
					"start",
					" ",
					"server",
					", ",
					"port",
					" ",
					"should",
					" ",
					"be",
					" ",
					"greater",
					" ",
					"than",
					" ",
					"1",
					" ",
					"and",
					" ",
					"less",
					" ",
					"than",
					" ",
					"6",
					"5",
					"5",
					"3",
					"5",
					". ",
					"Current",
					" ",
					"port",
					" ",
					"is",
					" ",
					int_5.ToString()
				}), GClass70.Enum1.const_0);
			}
			else if (this.class173_0 == null)
			{
				this.class173_0 = new Class173(int_5);
			}
			else
			{
				this.class173_0.method_1(int_5);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00082B48 File Offset: 0x00080D48
		internal static void smethod_1()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_30();
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00082B6C File Offset: 0x00080D6C
		internal void method_2()
		{
			this.method_138();
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00082B80 File Offset: 0x00080D80
		internal void method_3(UdonBehaviour udonBehaviour_0, NetworkEventTarget networkEventTarget_0, string string_4)
		{
			this.method_105(udonBehaviour_0, networkEventTarget_0, string_4);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00082B98 File Offset: 0x00080D98
		internal void method_4(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			for (int i = 0; i < GClass84.list_22.Count; i++)
			{
				GClass84.list_22[i](udonBehaviour_0, string_4, player_0);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00082BD0 File Offset: 0x00080DD0
		private void method_5(string string_4)
		{
			this.method_200(string_4);
		}

		// Token: 0x0600194B RID: 6475
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
		private static extern bool SetProcessAffinityMask(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x0600194C RID: 6476 RVA: 0x00082BE4 File Offset: 0x00080DE4
		internal void method_6(bool bool_26)
		{
			this.method_242(bool_26);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00082BF8 File Offset: 0x00080DF8
		internal void method_7(UdonBehaviour udonBehaviour_0, string string_4)
		{
			this.method_77(udonBehaviour_0, string_4);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00082C10 File Offset: 0x00080E10
		internal void method_8(Object object_2)
		{
			for (int i = 0; i < GClass84.list_32.Count; i++)
			{
				GClass84.list_32[i](object_2);
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00082C48 File Offset: 0x00080E48
		internal void method_9()
		{
			GClass93.smethod_7();
			GClass84.smethod_625();
			GClass84.gclass93_0 = this;
			GClass84.thread_0 = Thread.CurrentThread;
			GClass84.smethod_598();
			this.method_20();
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00082C7C File Offset: 0x00080E7C
		private static void smethod_2()
		{
			GClass93.smethod_11();
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00082C90 File Offset: 0x00080E90
		internal static void smethod_3(IntPtr intptr_0)
		{
			GClass93.smethod_39(intptr_0);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00082CA4 File Offset: 0x00080EA4
		internal void method_10(bool bool_26)
		{
			this.method_173(bool_26);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00082CB8 File Offset: 0x00080EB8
		internal void method_11(int int_5)
		{
			for (int i = 0; i < GClass84.list_27.Count; i++)
			{
				GClass84.list_27[i](int_5);
			}
			try
			{
				Player player = GClass84.smethod_703(int_5);
				if (player)
				{
					string text = GClass84.smethod_643(player, "");
					if (!string.IsNullOrEmpty(text))
					{
						string string_ = string.Concat(new string[]
						{
							text,
							" ",
							"Un",
							"blocked",
							" ",
							"You"
						});
						GClass84.smethod_1609(GClass84.smethod_1111(player, false, false, true), string_);
						GClass70.smethod_117(GClass84.smethod_1571(GClass84.smethod_518(player), true), string_, GClass70.Enum1.const_4);
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00082D98 File Offset: 0x00080F98
		internal void method_12()
		{
			this.method_2();
		}

		// Token: 0x06001955 RID: 6485
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, out UIntPtr uintptr_0);

		// Token: 0x06001956 RID: 6486 RVA: 0x00082DAC File Offset: 0x00080FAC
		internal void method_13(bool bool_26)
		{
			this.method_187(bool_26);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00082DC0 File Offset: 0x00080FC0
		internal void method_14(bool bool_26)
		{
			this.bool_5 = bool_26;
			GClass84.gclass117_0.bool_0 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00082DE4 File Offset: 0x00080FE4
		internal void method_15()
		{
			if (!this.bool_10)
			{
				try
				{
					NetworkManager networkManager = GClass84.smethod_645();
					if (networkManager)
					{
						VRCEventDelegate<Player> field_Internal_VRCEventDelegate_1_Player_ = networkManager.field_Internal_VRCEventDelegate_1_Player_0;
						VRCEventDelegate<Player> field_Internal_VRCEventDelegate_1_Player_2 = networkManager.field_Internal_VRCEventDelegate_1_Player_1;
						this.method_78(field_Internal_VRCEventDelegate_1_Player_, new Action<Player>(this.method_52));
						this.method_78(field_Internal_VRCEventDelegate_1_Player_2, new Action<Player>(this.method_96));
						this.Event_0 += this.method_48;
						this.Event_1 += this.method_38;
						this.bool_10 = true;
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00082E90 File Offset: 0x00081090
		internal void method_16(bool bool_26)
		{
			this.method_251(bool_26);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00082EA4 File Offset: 0x000810A4
		internal void method_17()
		{
			for (int i = 0; i < GClass84.list_10.Count; i++)
			{
				GClass84.list_10[i]();
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00082ED8 File Offset: 0x000810D8
		internal void method_18()
		{
			GClass84.dateTime_0 = DateTime.Now;
			int num = GClass84.smethod_841();
			if (this.int_1 == 0)
			{
				this.int_1 = num;
			}
			float num2 = (float)(num - this.int_1) / 1000f;
			this.int_1 = num;
			if (num2 < 0f)
			{
				num2 = 0f;
			}
			GClass84.float_0 = num2;
			if (this.bool_21)
			{
				int num3 = GClass84.smethod_749();
				int num4 = (num3 - 1) % 60;
				int num5 = GClass84.smethod_1097();
				int i = this.list_2.Count;
				while (i != 0)
				{
					if (this.list_2[0].int_0 == num4)
					{
						if (this.list_2[0].int_1 > num5)
						{
							break;
						}
						this.list_2.RemoveAt(0);
						i--;
					}
					else
					{
						if (this.list_2[0].int_0 == num3)
						{
							break;
						}
						this.list_2.RemoveAt(0);
						i--;
					}
				}
				this.list_2.Add(new GClass84.GStruct132(num3, num5));
				GClass84.float_1 = (float)i;
				if (GClass84.float_1 < 20f)
				{
					GClass84.float_1 = 1f / num2;
				}
			}
			else
			{
				long num6 = GClass84.smethod_985();
				if (this.long_0 == num6)
				{
					GClass84.float_1 = 0f;
				}
				else
				{
					GClass84.float_1 = (float)(1000000000L / (num6 - this.long_0));
				}
				this.long_0 = num6;
			}
			GClass84.bool_0 = false;
			if (this.int_2 > num)
			{
				this.int_2 = num;
			}
			else if (num - this.int_2 > 500)
			{
				this.int_2 = num;
				GClass84.bool_0 = true;
			}
			GClass84.bool_1 = false;
			if (this.int_3 > num)
			{
				this.int_3 = num;
			}
			else if (num - this.int_3 > 1000)
			{
				this.int_3 = num;
				GClass84.bool_1 = true;
			}
			this.method_63();
			for (int j = 0; j < GClass84.list_6.Count; j++)
			{
				GClass84.list_6[j]();
			}
			if (this.bool_4)
			{
				this.method_33();
			}
			if (GClass84.bool_0)
			{
				this.method_127();
			}
			if (GClass84.bool_1)
			{
				this.method_129();
			}
			this.method_225();
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00083124 File Offset: 0x00081324
		internal static void smethod_4()
		{
			foreach (object obj in Process.GetCurrentProcess().Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				try
				{
					if (GClass93.smethod_10(processModule.ModuleName))
					{
						GClass93.smethod_3(processModule.BaseAddress);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x000831A4 File Offset: 0x000813A4
		internal void method_19(bool bool_26)
		{
			this.method_25(bool_26);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000831B8 File Offset: 0x000813B8
		internal void method_20()
		{
			this.method_98();
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000831CC File Offset: 0x000813CC
		internal unsafe void method_21()
		{
			MelonCoroutines.Start(this.method_134());
			MelonCoroutines.Start(this.method_112());
			try
			{
				GClass84.smethod_721();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			this.list_1.Add(new GClass93.Struct18("", "", "okay"));
			try
			{
				GClass117.smethod_2();
				GClass84.gclass117_0 = GClass117.gclass117_0;
				this.bool_5 = GClass84.gclass117_0.bool_0;
				this.bool_6 = GClass84.gclass117_0.bool_1;
				this.bool_9 = GClass84.gclass117_0.bool_2;
				this.bool_13 = GClass84.gclass117_0.bool_3;
				this.string_1 = GClass84.gclass117_0.string_1;
				this.string_2 = GClass84.gclass117_0.string_2;
				this.bool_17 = GClass84.gclass117_0.bool_4;
				this.bool_18 = GClass84.gclass117_0.bool_5;
				this.bool_19 = GClass84.gclass117_0.bool_6;
				this.bool_20 = GClass84.gclass117_0.bool_7;
				this.bool_8 = GClass84.gclass117_0.bool_8;
				this.bool_0 = GClass84.gclass117_0.bool_9;
				this.bool_21 = GClass84.gclass117_0.bool_10;
				GClass84.bool_4 = GClass84.gclass117_0.bool_11;
				this.bool_25 = GClass84.gclass117_0.bool_12;
				this.bool_24 = GClass84.gclass117_0.bool_13;
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Failed",
					" ",
					"loading",
					" ",
					"main",
					" ",
					"config",
					": ",
					ex2.ToString()
				}), GClass70.Enum1.const_0);
				return;
			}
			try
			{
				GClass84.gclass39_0 = new GClass39();
				GClass84.gclass39_0.method_40();
				GClass84.gclass39_0.method_35();
				GClass84.gclass39_0.method_31();
				GClass84.gclass39_0.method_1();
				GClass84.gclass39_0.method_32();
				GClass84.gclass39_0.method_78();
				GClass84.gclass39_0.method_12();
			}
			catch (Exception ex3)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Failed",
					" ",
					"loading",
					" ",
					"saved",
					" ",
					"avatars",
					": ",
					ex3.ToString()
				}), GClass70.Enum1.const_0);
			}
			try
			{
				GClass70.smethod_93();
			}
			catch (Exception ex4)
			{
				GClass70.smethod_36(ex4.ToString(), GClass70.Enum1.const_0);
			}
			try
			{
				Class186.smethod_17();
			}
			catch (Exception ex5)
			{
				GClass70.smethod_36(ex5.ToString(), GClass70.Enum1.const_0);
			}
			GClass84.class188_0 = new Class188();
			this.method_206(GClass84.class188_0);
			GClass84.gclass153_0 = new GClass153();
			this.method_206(GClass84.gclass153_0);
			GClass84.gclass140_0 = new GClass140();
			this.method_206(GClass84.gclass140_0);
			GClass84.gclass174_0 = new GClass174();
			this.method_206(GClass84.gclass174_0);
			GClass84.gclass56_0 = new GClass56();
			GClass84.gclass56_0.method_9();
			GClass84.gclass179_0 = new GClass179();
			this.method_206(GClass84.gclass179_0);
			GClass84.gclass144_0 = new GClass144();
			this.method_206(GClass84.gclass144_0);
			GClass84.gclass132_0 = new GClass132();
			this.method_206(GClass84.gclass132_0);
			GClass84.gclass137_0 = new GClass137();
			this.method_206(GClass84.gclass137_0);
			GClass84.gclass134_0 = new GClass134();
			this.method_206(GClass84.gclass134_0);
			GClass84.gclass185_0 = new GClass185();
			this.method_206(GClass84.gclass185_0);
			GClass84.gclass136_0 = new GClass136();
			this.method_206(GClass84.gclass136_0);
			GClass84.gclass157_0 = new GClass157();
			this.method_206(GClass84.gclass157_0);
			GClass84.gclass160_0 = new GClass160();
			this.method_206(GClass84.gclass160_0);
			GClass84.gclass143_0 = new GClass143();
			this.method_206(GClass84.gclass143_0);
			GClass84.gclass131_0 = new GClass131();
			this.method_206(GClass84.gclass131_0);
			GClass84.gclass145_0 = new GClass145();
			this.method_206(GClass84.gclass145_0);
			GClass84.gclass184_0 = new GClass184();
			this.method_206(GClass84.gclass184_0);
			GClass84.gclass135_0 = new GClass135();
			this.method_206(GClass84.gclass135_0);
			GClass84.gclass178_0 = new GClass178();
			this.method_206(GClass84.gclass178_0);
			GClass84.gclass181_0 = new GClass181();
			this.method_206(GClass84.gclass181_0);
			GClass84.gclass141_0 = new GClass141();
			this.method_206(GClass84.gclass141_0);
			GClass84.gclass155_0 = new GClass155();
			this.method_206(GClass84.gclass155_0);
			GClass84.gclass158_0 = new GClass158();
			this.method_206(GClass84.gclass158_0);
			GClass84.gclass146_0 = new GClass146();
			this.method_206(GClass84.gclass146_0);
			GClass84.gclass149_0 = new GClass149();
			this.method_206(GClass84.gclass149_0);
			GClass84.gclass148_0 = new GClass148();
			this.method_206(GClass84.gclass148_0);
			GClass84.gclass152_0 = new GClass152();
			this.method_206(GClass84.gclass152_0);
			GClass84.gclass150_0 = new GClass150();
			this.method_206(GClass84.gclass150_0);
			GClass84.gclass159_0 = new GClass159();
			this.method_206(GClass84.gclass159_0);
			if (this.bool_0)
			{
				try
				{
					GClass70.smethod_127(string.Concat(new string[]
					{
						"Have",
						" ",
						Environment.ProcessorCount.ToString(),
						" ",
						"processor",
						" ",
						"cores"
					}), "CoreLimiter", GClass70.Enum1.const_0);
					GClass93.smethod_14();
				}
				catch (Exception ex6)
				{
					GClass70.smethod_36(ex6.ToString(), GClass70.Enum1.const_0);
				}
			}
			if (this.bool_3)
			{
				GClass84.gclass164_0 = new GClass164();
				this.method_206(GClass84.gclass164_0);
			}
			GClass84.gclass161_0 = new GClass161();
			this.method_206(GClass84.gclass161_0);
			if (this.bool_8)
			{
				GClass84.gclass166_0 = new GClass166();
				this.method_206(GClass84.gclass166_0);
			}
			if (this.bool_1)
			{
				try
				{
					Application.targetFrameRate = GClass84.gclass117_0.int_0;
					this.delegate_0 = new Action<bool>(GClass93.Class145.class145_0.method_0);
					Application.focusChanged = Delegate.Combine(Application.focusChanged, this.delegate_0).Cast<Action<bool>>();
					GClass70.smethod_38(string.Concat(new string[]
					{
						"New",
						" ",
						"FPS",
						": ",
						GClass84.gclass117_0.int_0.ToString(),
						" (",
						GClass84.gclass117_0.int_1.ToString(),
						")"
					}), GClass70.Enum1.const_0);
				}
				catch (Exception ex7)
				{
					GClass70.smethod_36(ex7.ToString(), GClass70.Enum1.const_0);
				}
			}
			if (this.bool_6)
			{
				try
				{
					IntPtr intPtr = GClass93.LoadLibrary("VRChat_Data\\Plugins\\x86_64\\steam_api64.dll");
					if (intPtr == IntPtr.Zero)
					{
						GClass70.smethod_36("Steam library load failed", GClass70.Enum1.const_0);
						return;
					}
					List<string> list = new List<string>
					{
						"SteamAPI_Init",
						"SteamAPI_RestartAppIfNecessary",
						"SteamAPI_Shutdown"
					};
					foreach (string text in list)
					{
						IntPtr procAddress = GClass93.GetProcAddress(intPtr, text);
						if (procAddress == IntPtr.Zero)
						{
							GClass70.smethod_36(string.Concat(new string[]
							{
								"Procedure",
								" ",
								text,
								" ",
								"not",
								" ",
								"found"
							}), GClass70.Enum1.const_0);
							return;
						}
						MelonUtils.NativeHookAttach((IntPtr)((void*)(&procAddress)), AccessTools.Method(typeof(GClass93), "InitFail", null, null).MethodHandle.GetFunctionPointer());
					}
				}
				catch (Exception ex8)
				{
					GClass70.smethod_36(ex8.ToString(), GClass70.Enum1.const_0);
				}
			}
			GClass84.stringBuilder_0 = new StringBuilder();
			GClass84.gclass194_0 = new GClass194(new StringWriter(GClass84.stringBuilder_0))
			{
				InteractiveBaseClass = typeof(GClass122)
			};
			for (int i = 0; i < GClass84.string_2.Length; i++)
			{
				GClass84.smethod_683(GClass84.string_2[i]);
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00083B10 File Offset: 0x00081D10
		internal void method_22()
		{
			this.method_159();
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00083B24 File Offset: 0x00081D24
		private static void smethod_5(ref int int_5)
		{
			try
			{
				int_5 = 0;
			}
			catch
			{
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00083B4C File Offset: 0x00081D4C
		internal static void smethod_6()
		{
			GClass93.smethod_35();
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00083B60 File Offset: 0x00081D60
		internal void method_23()
		{
			this.method_126();
		}

		// Token: 0x06001964 RID: 6500
		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string string_4);

		// Token: 0x06001965 RID: 6501 RVA: 0x00083B74 File Offset: 0x00081D74
		internal void method_24()
		{
			this.method_181();
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00083B88 File Offset: 0x00081D88
		internal void method_25(bool bool_26)
		{
			this.bool_17 = bool_26;
			GClass84.gclass117_0.bool_4 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00083BAC File Offset: 0x00081DAC
		internal static void smethod_7()
		{
			GClass93.smethod_29();
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00083BC0 File Offset: 0x00081DC0
		private void method_26()
		{
			object obj = this.object_0;
			lock (obj)
			{
				if (this.list_4.Count > 0)
				{
					foreach (string string_ in this.list_4)
					{
						this.method_172(string_);
					}
					this.list_4.Clear();
				}
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00083C5C File Offset: 0x00081E5C
		public static void smethod_8()
		{
			GClass93.smethod_31();
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00083C70 File Offset: 0x00081E70
		internal void method_27(int int_5)
		{
			this.method_210(int_5);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00083C84 File Offset: 0x00081E84
		private void method_28(string string_4, List<string> list_7)
		{
			this.method_217(string_4, list_7);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00083C9C File Offset: 0x00081E9C
		internal void method_29()
		{
			this.method_156();
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00083CB0 File Offset: 0x00081EB0
		internal void method_30()
		{
			this.method_158();
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00083CC4 File Offset: 0x00081EC4
		internal void method_31(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			this.method_4(udonBehaviour_0, string_4, player_0);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00083CDC File Offset: 0x00081EDC
		internal void method_32()
		{
			for (int i = 0; i < GClass84.list_14.Count; i++)
			{
				GClass84.list_14[i]();
			}
			if (this.bool_18)
			{
				this.method_177(this.string_2);
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00083D24 File Offset: 0x00081F24
		internal void method_33()
		{
			this.method_71();
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00083D38 File Offset: 0x00081F38
		internal void method_34(int int_5)
		{
			for (int i = 0; i < GClass84.list_26.Count; i++)
			{
				GClass84.list_26[i](int_5);
			}
			try
			{
				Player player = GClass84.smethod_703(int_5);
				if (player)
				{
					string text = GClass84.smethod_643(player, "");
					if (!string.IsNullOrEmpty(text))
					{
						string string_ = string.Concat(new string[]
						{
							text,
							" ",
							"Blocked",
							" ",
							"You"
						});
						GClass84.smethod_1609(GClass84.smethod_1111(player, false, false, true), string_);
						GClass70.smethod_117(GClass84.smethod_1571(GClass84.smethod_518(player), true), string_, GClass70.Enum1.const_4);
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00083E10 File Offset: 0x00082010
		internal void method_35(bool bool_26)
		{
			this.method_14(bool_26);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00083E24 File Offset: 0x00082024
		internal static void smethod_9()
		{
			GClass93.smethod_7();
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00083E38 File Offset: 0x00082038
		internal void method_36(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_5, float float_0)
		{
			this.method_214(vrcEvent_0, vrcBroadcastType_0, int_5, float_0);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00083E54 File Offset: 0x00082054
		internal static bool smethod_10(string string_4)
		{
			return string_4.ToLower().Contains("Abyss".ToLower());
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00083E78 File Offset: 0x00082078
		private static void smethod_11()
		{
			int processorCount = Environment.ProcessorCount;
			long num = 0L;
			int num2 = 4;
			int num3 = processorCount - 1;
			int num4 = (processorCount <= 4) ? 1 : 2;
			int num5 = 0;
			while (num5 < num2 && num3 > 0)
			{
				num |= 1L << num3;
				num3 -= num4;
				num5++;
			}
			if (num5 < num2 && num4 > 1)
			{
				num3 = processorCount - 2;
				int num6 = 0;
				while (num5 < num2 && num3 > 0)
				{
					num |= 1L << num3;
					num3 -= num4;
					num5++;
					num6++;
				}
			}
			IntPtr handle = Process.GetCurrentProcess().Handle;
			GClass70.smethod_127(string.Concat(new string[]
			{
				"Assigning",
				" ",
				"affinity",
				" ",
				"mask",
				": ",
				num.ToString()
			}), "CoreLimiter", GClass70.Enum1.const_0);
			GClass93.SetProcessAffinityMask(handle, new IntPtr(num));
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00083F90 File Offset: 0x00082190
		internal static void smethod_12()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_151();
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00083FB4 File Offset: 0x000821B4
		internal void method_37(bool bool_26)
		{
			this.method_46(bool_26);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00083FC8 File Offset: 0x000821C8
		internal void method_38(Player player_0)
		{
			this.method_201(player_0);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00083FDC File Offset: 0x000821DC
		private void method_39(List<string> list_7)
		{
			this.method_147(list_7);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00083FF0 File Offset: 0x000821F0
		internal void method_40(string string_4)
		{
			if (this.audioSource_0)
			{
				if (this.audioSource_0.isPlaying)
				{
					return;
				}
				try
				{
					this.method_111();
					this.method_114(string_4);
					if (this.audioSource_0)
					{
						this.audioSource_0.Play();
					}
					return;
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
					return;
				}
			}
			try
			{
				this.gameObject_0 = new GameObject("AbyssClientLoading");
				GClass84.smethod_281(this.gameObject_0);
				this.gameObject_0.layer = 5;
				this.audioSource_0 = this.gameObject_0.AddComponent<AudioSource>();
				AssetBundle assetBundle = this.method_47();
				AudioClip audioClip = null;
				if (!string.IsNullOrEmpty(string_4))
				{
					audioClip = GClass84.smethod_280(string_4, GClass84.smethod_400(string_4));
					this.string_3 = string_4;
					this.bool_16 = false;
				}
				if (audioClip == null)
				{
					if (assetBundle)
					{
						audioClip = assetBundle.LoadAsset_Internal("Assets/MySounds/AbyssClientLoading.ogg", Il2CppType.Of<AudioClip>()).Cast<AudioClip>();
					}
					this.string_3 = string.Empty;
					this.bool_16 = true;
				}
				this.audioSource_0.clip = audioClip;
				this.audioSource_0.minDistance = 1000000f;
				this.audioSource_0.maxDistance = 1000000f;
				this.method_111();
				this.audioSource_0.Play();
				this.gameObject_1 = GClass84.smethod_23();
				if (this.gameObject_1)
				{
					this.gameObject_1.SetActive(!this.bool_20);
					this.audioSource_1 = this.gameObject_1.GetComponent<AudioSource>();
				}
				this.gameObject_2 = GClass84.smethod_1500();
				if (this.gameObject_2)
				{
					this.gameObject_2.SetActive(!this.bool_20);
					this.audioSource_2 = this.gameObject_2.GetComponent<AudioSource>();
					if (this.audioSource_2)
					{
						this.audioSource_0.outputAudioMixerGroup = this.audioSource_2.outputAudioMixerGroup;
					}
				}
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00084224 File Offset: 0x00082424
		internal void method_41(Player player_0)
		{
			this.method_221(player_0);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00084238 File Offset: 0x00082438
		internal void method_42()
		{
			this.method_191();
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0008424C File Offset: 0x0008244C
		internal void method_43()
		{
			this.method_55();
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00084260 File Offset: 0x00082460
		internal void method_44(GameObject gameObject_3, GameObject gameObject_4)
		{
			for (int i = 0; i < GClass84.list_16.Count; i++)
			{
				GClass84.list_16[i](gameObject_3, gameObject_4);
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00084298 File Offset: 0x00082498
		internal void method_45(bool bool_26)
		{
			this.method_178(bool_26);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000842AC File Offset: 0x000824AC
		internal void method_46(bool bool_26)
		{
			this.method_155(bool_26);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000842C0 File Offset: 0x000824C0
		internal AssetBundle method_47()
		{
			AssetBundle result;
			if (this.assetBundle_0)
			{
				result = this.assetBundle_0;
			}
			else
			{
				using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AbyssClient.Resources.Audio.AbyssClientLoading"))
				{
					using (MemoryStream memoryStream = new MemoryStream((int)manifestResourceStream.Length))
					{
						manifestResourceStream.CopyTo(memoryStream);
						this.assetBundle_0 = AssetBundle.LoadFromMemory_Internal(memoryStream.ToArray(), 0U);
						this.assetBundle_0.hideFlags |= 32;
					}
				}
				result = this.assetBundle_0;
			}
			return result;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00084370 File Offset: 0x00082570
		internal void method_48(Player player_0)
		{
			this.method_176(player_0);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00084384 File Offset: 0x00082584
		internal void method_49(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			this.method_207(udonBehaviour_0, string_4, player_0);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0008439C File Offset: 0x0008259C
		private static void smethod_13(ref CursorLockMode cursorLockMode_0)
		{
			try
			{
				if (GClass84.gclass93_0.bool_7 && GClass84.smethod_1424() == null)
				{
					cursorLockMode_0 = 0;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000843D8 File Offset: 0x000825D8
		internal void method_50()
		{
			for (int i = 0; i < GClass84.list_12.Count; i++)
			{
				GClass84.list_12[i]();
			}
			if (this.bool_0)
			{
				try
				{
					GClass93.smethod_14();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0008443C File Offset: 0x0008263C
		private static void smethod_14()
		{
			GClass93.smethod_2();
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00084450 File Offset: 0x00082650
		internal void method_51(bool bool_26)
		{
			this.method_62(bool_26);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00084464 File Offset: 0x00082664
		internal void method_52(Player player_0)
		{
			this.method_212(player_0);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00084478 File Offset: 0x00082678
		private void method_53(string string_4)
		{
			if (GClass84.gclass152_0 != null)
			{
				object obj = this.object_0;
				lock (obj)
				{
					this.list_4.Add(string_4);
				}
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000844C8 File Offset: 0x000826C8
		private static void smethod_15(ref CursorLockMode cursorLockMode_0)
		{
			GClass93.smethod_13(ref cursorLockMode_0);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000844DC File Offset: 0x000826DC
		internal void method_54(bool bool_26)
		{
			this.method_247(bool_26);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000844F0 File Offset: 0x000826F0
		internal static void smethod_16(int int_5)
		{
			GClass93.smethod_30(int_5);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00084504 File Offset: 0x00082704
		internal void method_55()
		{
			for (int i = 0; i < GClass84.list_3.Count; i++)
			{
				GClass84.list_3[i]();
			}
			if (this.bool_25)
			{
				this.method_186();
			}
			this.method_205();
			this.method_250();
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00084554 File Offset: 0x00082754
		internal void method_56(bool bool_26)
		{
			this.method_35(bool_26);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060019D2 RID: 6610 RVA: 0x00084F60 File Offset: 0x00083160
		// (remove) Token: 0x06001990 RID: 6544 RVA: 0x00084568 File Offset: 0x00082768
		internal event Action<Player> Event_1
		{
			[CompilerGenerated]
			add
			{
				this.method_110(value);
			}
			[CompilerGenerated]
			remove
			{
				this.method_92(value);
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0008457C File Offset: 0x0008277C
		internal void method_57()
		{
			this.method_102();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00084590 File Offset: 0x00082790
		internal void method_58()
		{
			this.method_125();
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000845A4 File Offset: 0x000827A4
		internal void method_59()
		{
			if (this.class173_0 != null)
			{
				this.class173_0.method_3();
			}
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000845C8 File Offset: 0x000827C8
		internal static void smethod_17()
		{
			GClass93.smethod_12();
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000845DC File Offset: 0x000827DC
		internal void method_60(string string_4)
		{
			this.string_1 = string_4;
			GClass84.gclass117_0.string_1 = string_4;
			GClass117.smethod_3();
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00084600 File Offset: 0x00082800
		internal void method_61()
		{
			this.method_18();
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00084614 File Offset: 0x00082814
		internal void method_62(bool bool_26)
		{
			if (this.gameObject_1)
			{
				this.gameObject_1.SetActive(!bool_26);
			}
			if (this.gameObject_2)
			{
				this.gameObject_2.SetActive(!bool_26);
			}
			this.bool_20 = bool_26;
			GClass84.gclass117_0.bool_7 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00084670 File Offset: 0x00082870
		internal void method_63()
		{
			this.method_252();
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00084684 File Offset: 0x00082884
		private void method_64(string string_4, List<string> list_7)
		{
			this.method_28(string_4, list_7);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0008469C File Offset: 0x0008289C
		internal void method_65(bool bool_26)
		{
			this.method_170(bool_26);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000846B0 File Offset: 0x000828B0
		internal void method_66(bool bool_26)
		{
			this.method_116(bool_26);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000846C4 File Offset: 0x000828C4
		internal void method_67(Player player_0)
		{
			try
			{
				if (player_0)
				{
					if (this.bool_9)
					{
						APIUser apiuser = GClass84.smethod_518(player_0);
						VRCPlayer vrcplayer = GClass84.smethod_367(player_0);
						if (apiuser != null && vrcplayer)
						{
							if (this.method_93())
							{
								string text = GClass84.smethod_828(apiuser, "!null!");
								GClass70.smethod_117(GClass84.smethod_1571(apiuser, true), text + " " + "Left", GClass70.Enum1.const_3);
								string string_ = string.Concat(new string[]
								{
									text,
									" ",
									"has",
									" ",
									"left",
									"."
								});
								if (GClass84.float_2 < 0f || GClass84.float_2 > 10f)
								{
									GClass84.smethod_1609(GClass84.smethod_204(apiuser, false, false, true), string_);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000847D8 File Offset: 0x000829D8
		internal void method_68()
		{
			this.method_42();
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000847EC File Offset: 0x000829EC
		internal void method_69()
		{
			this.method_61();
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00084800 File Offset: 0x00082A00
		internal void method_70(bool bool_26)
		{
			this.method_13(bool_26);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00084814 File Offset: 0x00082A14
		internal static void smethod_18()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_76();
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00084838 File Offset: 0x00082A38
		internal void method_71()
		{
			this.method_15();
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0008484C File Offset: 0x00082A4C
		internal void method_72(int int_5)
		{
			this.method_209(int_5);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00084860 File Offset: 0x00082A60
		public static void smethod_19()
		{
			GClass93.smethod_28();
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00084874 File Offset: 0x00082A74
		private void method_73(string string_4, string string_5)
		{
			this.method_121(string_4, string_5);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0008488C File Offset: 0x00082A8C
		internal void method_74(string string_4)
		{
			this.method_171(string_4);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000848A0 File Offset: 0x00082AA0
		private void method_75(string string_4)
		{
			this.method_164(string_4);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000848B4 File Offset: 0x00082AB4
		internal void method_76()
		{
			this.method_24();
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000848C8 File Offset: 0x00082AC8
		internal void method_77(UdonBehaviour udonBehaviour_0, string string_4)
		{
			this.method_197(udonBehaviour_0, string_4);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000848E0 File Offset: 0x00082AE0
		internal void method_78(VRCEventDelegate<Player> vrceventDelegate_0, Action<Player> action_2)
		{
			this.method_241(vrceventDelegate_0, action_2);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000848F8 File Offset: 0x00082AF8
		private void method_79(string string_4, string string_5)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"On",
				"User",
				"Connected",
				"(",
				string_4,
				", ",
				string_5,
				")"
			}), GClass70.Enum1.const_0);
			for (int i = 0; i < GClass84.list_17.Count; i++)
			{
				GClass84.list_17[i](string_4, string_5);
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00084978 File Offset: 0x00082B78
		internal void method_80(bool bool_26)
		{
			this.bool_21 = bool_26;
			GClass84.gclass117_0.bool_10 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0008499C File Offset: 0x00082B9C
		internal void method_81(Action<Player> action_2)
		{
			this.method_183(action_2);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000849B0 File Offset: 0x00082BB0
		private void method_82(string string_4, string string_5)
		{
			this.method_248(string_4, string_5);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000849C8 File Offset: 0x00082BC8
		internal void method_83(GameObject gameObject_3, GameObject gameObject_4)
		{
			this.method_44(gameObject_3, gameObject_4);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000849E0 File Offset: 0x00082BE0
		internal void method_84()
		{
			this.method_149();
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000849F4 File Offset: 0x00082BF4
		internal void method_85(int int_5)
		{
			this.method_1(int_5);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00084A08 File Offset: 0x00082C08
		internal static void smethod_20()
		{
			GClass93.smethod_27();
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00084A1C File Offset: 0x00082C1C
		private void method_86()
		{
			this.method_232();
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00084A30 File Offset: 0x00082C30
		private void method_87()
		{
			this.method_132();
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00084A44 File Offset: 0x00082C44
		internal bool method_88()
		{
			return this.class173_0 != null && this.class173_0.method_12();
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00084A70 File Offset: 0x00082C70
		internal void method_89(int int_5)
		{
			this.method_184(int_5);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00084A84 File Offset: 0x00082C84
		public static void smethod_21()
		{
			GClass93.smethod_36();
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00084A98 File Offset: 0x00082C98
		[DebuggerStepThrough]
		internal Task method_90()
		{
			GClass93.Class148 @class = new GClass93.Class148();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.gclass93_0 = this;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass93.Class148>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00084ADC File Offset: 0x00082CDC
		internal static void smethod_22(IntPtr intptr_0)
		{
			byte[] byte_ = new byte[4];
			byte[] byte_2 = new byte[120];
			byte[] byte_3 = new byte[264];
			UIntPtr uintPtr = (UIntPtr)0UL;
			IntPtr intptr_ = GClass93.OpenProcess(2035711, false, Process.GetCurrentProcess().Id);
			IntPtr intptr_2 = new IntPtr(intptr_0.ToInt32() + 60);
			IntPtr zero = IntPtr.Zero;
			GClass93.ReadProcessMemory(intptr_, intptr_2, byte_, 4, out zero);
			UIntPtr uintPtr2;
			if (GClass93.WriteProcessMemory(intptr_, intptr_0, byte_2, 120U, out uintPtr) && GClass93.WriteProcessMemory(intptr_, intptr_0, byte_3, 256U, out uintPtr2))
			{
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00084B74 File Offset: 0x00082D74
		internal void method_91(string string_4, string string_5, GameObject gameObject_3)
		{
			this.method_123(string_4, string_5, gameObject_3);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060019BA RID: 6586 RVA: 0x00084B8C File Offset: 0x00082D8C
		// (remove) Token: 0x060019F7 RID: 6647 RVA: 0x00085814 File Offset: 0x00083A14
		internal event Action<Player> Event_0
		{
			[CompilerGenerated]
			add
			{
				this.method_135(value);
			}
			[CompilerGenerated]
			remove
			{
				this.method_81(value);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00084BA0 File Offset: 0x00082DA0
		internal void method_92(Action<Player> action_2)
		{
			this.method_119(action_2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00084BB4 File Offset: 0x00082DB4
		internal bool method_93()
		{
			ApiWorldInstance apiWorldInstance = GClass84.smethod_813();
			InstanceAccessType? instanceAccessType = (apiWorldInstance != null) ? new InstanceAccessType?(apiWorldInstance.type) : null;
			return instanceAccessType != null;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00084BF4 File Offset: 0x00082DF4
		public static void smethod_23()
		{
			GClass93.smethod_45();
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00084C08 File Offset: 0x00082E08
		internal void method_94(bool bool_26)
		{
			this.bool_19 = bool_26;
			GClass84.gclass117_0.bool_6 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00084C2C File Offset: 0x00082E2C
		internal void method_95(bool bool_26)
		{
			this.method_166(bool_26);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00084C40 File Offset: 0x00082E40
		internal void method_96(Player player_0)
		{
			this.method_41(player_0);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00084C54 File Offset: 0x00082E54
		internal void method_97()
		{
			this.method_208();
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00084C68 File Offset: 0x00082E68
		internal static void smethod_24()
		{
			GClass93.smethod_18();
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00084C7C File Offset: 0x00082E7C
		internal static void smethod_25()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_117();
			}
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00084CA0 File Offset: 0x00082EA0
		internal void method_98()
		{
			this.method_21();
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00084CB4 File Offset: 0x00082EB4
		internal void method_99(bool bool_26)
		{
			this.method_131(bool_26);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00084CC8 File Offset: 0x00082EC8
		internal void method_100()
		{
			this.method_233();
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00084CDC File Offset: 0x00082EDC
		private void method_101(string string_4, string string_5)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"On",
				"User",
				"Changed",
				"Instance",
				"(",
				string_4,
				", ",
				string_5,
				")"
			}), GClass70.Enum1.const_0);
			for (int i = 0; i < GClass84.list_20.Count; i++)
			{
				GClass84.list_20[i](string_4, string_5);
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00084D64 File Offset: 0x00082F64
		internal void method_102()
		{
			for (int i = 0; i < GClass84.list_7.Count; i++)
			{
				GClass84.list_7[i]();
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00084D98 File Offset: 0x00082F98
		internal void method_103(bool bool_26)
		{
			this.method_179(bool_26);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00084DAC File Offset: 0x00082FAC
		internal void method_104(string string_4, string string_5)
		{
			this.method_113(string_4, string_5);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00084DC4 File Offset: 0x00082FC4
		internal void method_105(UdonBehaviour udonBehaviour_0, NetworkEventTarget networkEventTarget_0, string string_4)
		{
			for (int i = 0; i < GClass84.list_23.Count; i++)
			{
				GClass84.list_23[i](udonBehaviour_0, networkEventTarget_0, string_4);
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00084DFC File Offset: 0x00082FFC
		private void method_106(string string_4, string string_5)
		{
			this.method_101(string_4, string_5);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00084E14 File Offset: 0x00083014
		public static void smethod_26(int int_5)
		{
			GClass93.smethod_16(int_5);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00084E28 File Offset: 0x00083028
		internal void method_107(Player player_0)
		{
			if (!this.bool_11)
			{
				this.bool_12 = true;
				this.bool_11 = true;
			}
			Action<Player> action;
			if (!this.bool_12)
			{
				if ((action = this.action_1) != null)
				{
					goto IL_38;
				}
			}
			else if ((action = this.action_0) != null)
			{
				goto IL_38;
			}
			return;
			IL_38:
			action(player_0);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00084E74 File Offset: 0x00083074
		internal void method_108()
		{
			this.method_145();
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00084E88 File Offset: 0x00083088
		internal void method_109(string string_4)
		{
			if (this.audioSource_0)
			{
				if (!string.IsNullOrEmpty(string_4))
				{
					if (this.bool_16 || this.string_3 != string_4)
					{
						AudioClip clip = GClass84.smethod_280(string_4, GClass84.smethod_400(string_4));
						this.string_3 = string_4;
						this.bool_16 = false;
						this.audioSource_0.clip = clip;
					}
				}
				else if (!this.bool_16)
				{
					AssetBundle assetBundle = this.method_47();
					AudioClip clip2 = null;
					if (assetBundle)
					{
						clip2 = assetBundle.LoadAsset_Internal("Assets/MySounds/AbyssClientLoading.ogg", Il2CppType.Of<AudioClip>()).Cast<AudioClip>();
					}
					this.string_3 = string.Empty;
					this.bool_16 = true;
					this.audioSource_0.clip = clip2;
				}
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00084F4C File Offset: 0x0008314C
		internal void method_110(Action<Player> action_2)
		{
			this.method_167(action_2);
		}

		// Token: 0x060019D3 RID: 6611
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_4);

		// Token: 0x060019D4 RID: 6612 RVA: 0x00084F74 File Offset: 0x00083174
		internal void method_111()
		{
			this.method_227();
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00084F88 File Offset: 0x00083188
		internal IEnumerator method_112()
		{
			GClass93.Class146 @class = new GClass93.Class146(0);
			@class.gclass93_0 = this;
			return @class;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00084FA4 File Offset: 0x000831A4
		internal void method_113(string string_4, string string_5)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Receive",
				"Request",
				"(",
				string_5,
				")"
			}), GClass70.Enum1.const_0);
			string string_6 = GClass84.smethod_1204(string_5, 1, -1);
			try
			{
				if (GClass84.smethod_1428(string_6, GClass84.smethod_593("Command: ")) == "Command: ")
				{
					this.method_5(GClass84.smethod_1204(string_6, GClass84.smethod_593("Command: "), -1));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00085038 File Offset: 0x00083238
		internal void method_114(string string_4 = "")
		{
			this.method_245(string_4);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0008504C File Offset: 0x0008324C
		internal void method_115(int int_5)
		{
			for (int i = 0; i < GClass84.list_1.Count; i++)
			{
				GClass84.list_1[i](int_5);
			}
			if (this.bool_24)
			{
				GameObject gameObject = GameObject.Find("AdminTool");
				if (gameObject)
				{
					Object.DestroyImmediate(gameObject, true);
				}
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000850A4 File Offset: 0x000832A4
		internal void method_116(bool bool_26)
		{
			this.method_199(bool_26);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000850B8 File Offset: 0x000832B8
		internal void method_117()
		{
			this.method_144();
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000850CC File Offset: 0x000832CC
		private void method_118(string string_4, string string_5)
		{
			this.method_0(string_4, string_5);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000850E4 File Offset: 0x000832E4
		internal void method_119(Action<Player> action_2)
		{
			Action<Player> action = this.action_1;
			Action<Player> action2;
			do
			{
				action2 = action;
				Action<Player> value = (Action<Player>)Delegate.Remove(action2, action_2);
				action = Interlocked.CompareExchange<Action<Player>>(ref this.action_1, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00085274 File Offset: 0x00083474
		private void method_120(string string_4, string string_5)
		{
			this.method_106(string_4, string_5);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0008528C File Offset: 0x0008348C
		private void method_121(string string_4, string string_5)
		{
			this.method_237(string_4, string_5);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000852A4 File Offset: 0x000834A4
		internal static void smethod_27()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_69();
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000852C8 File Offset: 0x000834C8
		internal bool method_122(GameObject gameObject_3)
		{
			bool result;
			if (!gameObject_3)
			{
				result = false;
			}
			else
			{
				Transform transform = gameObject_3.transform;
				for (int i = transform.childCount - 1; i >= 0; i--)
				{
					if (transform.GetChild(i).name == this.string_0)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00085324 File Offset: 0x00083524
		internal void method_123(string string_4, string string_5, GameObject gameObject_3)
		{
			for (int i = 0; i < GClass84.list_33.Count; i++)
			{
				GClass84.list_33[i](string_4, string_5, gameObject_3);
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0008535C File Offset: 0x0008355C
		private void method_124(Player player_0)
		{
			try
			{
				this.method_180(player_0);
			}
			catch
			{
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00085388 File Offset: 0x00083588
		internal void method_125()
		{
			this.method_32();
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0008539C File Offset: 0x0008359C
		internal void method_126()
		{
			this.method_59();
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x000853B0 File Offset: 0x000835B0
		internal void method_127()
		{
			this.method_43();
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000853C4 File Offset: 0x000835C4
		internal void method_128(VRCEventDelegate<Player> vrceventDelegate_0, Action<Player> action_2)
		{
			vrceventDelegate_0.field_Private_HashSet_1_UnityAction_1_T_0.Add(action_2);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000853E4 File Offset: 0x000835E4
		internal void method_129()
		{
			this.method_163();
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000853F8 File Offset: 0x000835F8
		internal static void smethod_28()
		{
			GClass93.smethod_40();
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0008540C File Offset: 0x0008360C
		internal void method_130(int int_5)
		{
			this.method_222(int_5);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00085420 File Offset: 0x00083620
		internal static void smethod_29()
		{
			GClass93.smethod_4();
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00085434 File Offset: 0x00083634
		internal void method_131(bool bool_26)
		{
			this.method_80(bool_26);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00085448 File Offset: 0x00083648
		private void method_132()
		{
			for (int i = GClass93.list_3.Count - 1; i >= 0; i--)
			{
				if (!GClass93.list_3[i].vrcplayer_0 || !GClass93.list_3[i].textMeshProUGUI_0 || !GClass93.list_3[i].textMeshProUGUI_1 || !GClass93.list_3[i].textMeshProUGUI_2)
				{
					GClass93.list_3.RemoveAt(i);
				}
				else
				{
					int num = GClass84.smethod_1395() - GClass93.list_3[i].int_1;
					if (num >= 0 && num < 5000)
					{
						if (num < 1000)
						{
							GClass93.list_3[i].textMeshProUGUI_2.text = "Stable";
							GClass93.list_3[i].textMeshProUGUI_2.color = Color.green;
						}
						else
						{
							GClass93.list_3[i].textMeshProUGUI_2.text = "Lagging";
							GClass93.list_3[i].textMeshProUGUI_2.color = Color.yellow;
						}
					}
					else
					{
						GClass93.list_3[i].textMeshProUGUI_2.text = "Crashed";
						GClass93.list_3[i].textMeshProUGUI_2.color = Color.red;
					}
					int num2 = GClass84.smethod_657(GClass93.list_3[i].vrcplayer_0);
					GClass93.list_3[i].textMeshProUGUI_0.text = "FPS" + ": " + num2.ToString();
					GClass93.list_3[i].textMeshProUGUI_0.color = GClass84.smethod_1669(num2);
					short short_ = GClass84.smethod_506(GClass93.list_3[i].vrcplayer_0);
					GClass93.list_3[i].textMeshProUGUI_1.text = "Ping" + ": " + short_.ToString();
					GClass93.list_3[i].textMeshProUGUI_1.color = GClass84.smethod_539(short_);
				}
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00085674 File Offset: 0x00083874
		internal void method_133(bool bool_26)
		{
			this.method_45(bool_26);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00085688 File Offset: 0x00083888
		private IEnumerator method_134()
		{
			GClass93.Class144 @class = new GClass93.Class144(0);
			@class.gclass93_0 = this;
			return @class;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000856A4 File Offset: 0x000838A4
		internal void method_135(Action<Player> action_2)
		{
			this.method_255(action_2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000856B8 File Offset: 0x000838B8
		internal static void smethod_30(int int_5)
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_27(int_5);
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x000856DC File Offset: 0x000838DC
		private void method_136()
		{
			this.method_26();
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000856F0 File Offset: 0x000838F0
		private void method_137(string string_4, string string_5)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"On",
				"User",
				"In",
				"Load",
				"Screen",
				"(",
				string_4,
				", ",
				string_5,
				")"
			}), GClass70.Enum1.const_0);
			for (int i = 0; i < GClass84.list_19.Count; i++)
			{
				GClass84.list_19[i](string_4, string_5);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00085784 File Offset: 0x00083984
		internal void method_138()
		{
			for (int i = 0; i < GClass84.list_28.Count; i++)
			{
				GClass84.list_28[i]();
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000857B8 File Offset: 0x000839B8
		internal static void smethod_31()
		{
			GClass93.smethod_47();
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000857CC File Offset: 0x000839CC
		private void method_139(List<string> list_7)
		{
			object obj = this.object_1;
			lock (obj)
			{
				this.list_5.AddRange(list_7);
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00085828 File Offset: 0x00083A28
		[CompilerGenerated]
		private void method_140(Player player_0)
		{
			this.method_203(player_0);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0008583C File Offset: 0x00083A3C
		private void method_141(string string_4)
		{
			this.method_230(string_4);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00085850 File Offset: 0x00083A50
		internal void method_142(string string_4)
		{
			this.method_246(string_4);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00085864 File Offset: 0x00083A64
		internal void method_143(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_5, float float_0)
		{
			this.method_36(vrcEvent_0, vrcBroadcastType_0, int_5, float_0);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00085880 File Offset: 0x00083A80
		internal void method_144()
		{
			this.method_17();
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00085894 File Offset: 0x00083A94
		internal void method_145()
		{
			this.method_202();
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000858A8 File Offset: 0x00083AA8
		internal void method_146()
		{
			for (int i = 0; i < GClass84.list_8.Count; i++)
			{
				GClass84.list_8[i]();
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000858DC File Offset: 0x00083ADC
		private void method_147(List<string> list_7)
		{
			this.method_139(list_7);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000858F0 File Offset: 0x00083AF0
		internal void method_148()
		{
			this.method_9();
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00085904 File Offset: 0x00083B04
		internal void method_149()
		{
			this.method_185();
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00085918 File Offset: 0x00083B18
		internal void method_150(bool bool_26)
		{
			this.bool_8 = bool_26;
			GClass84.gclass117_0.bool_8 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0008593C File Offset: 0x00083B3C
		internal void method_151()
		{
			this.method_153();
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00085950 File Offset: 0x00083B50
		internal void method_152()
		{
			if (this.bool_14)
			{
				try
				{
					if (GClass84.smethod_1424() != null)
					{
						if (this.bool_19)
						{
							this.method_108();
						}
					}
					else if (this.bool_15 && this.bool_17)
					{
						this.method_177(this.string_1);
					}
					this.method_111();
				}
				catch (Exception ex)
				{
					this.method_108();
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000859D0 File Offset: 0x00083BD0
		internal void method_153()
		{
			this.method_215();
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000859E4 File Offset: 0x00083BE4
		internal void method_154(string string_4, string string_5, GameObject gameObject_3)
		{
			this.method_91(string_4, string_5, gameObject_3);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000859FC File Offset: 0x00083BFC
		internal void method_155(bool bool_26)
		{
			this.bool_22 = bool_26;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00085A10 File Offset: 0x00083C10
		internal void method_156()
		{
			Transform transform = GClass84.smethod_1025();
			GameObject gameObject;
			if (transform == null)
			{
				gameObject = null;
			}
			else
			{
				Transform transform2 = transform.Find("Container/Window/Toggle_SafeMode");
				gameObject = ((transform2 != null) ? transform2.gameObject : null);
			}
			GameObject gameObject2 = gameObject;
			if (gameObject2)
			{
				gameObject2.SetActive(!this.bool_13);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00085A58 File Offset: 0x00083C58
		internal void method_157()
		{
			this.method_218();
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00085A6C File Offset: 0x00083C6C
		internal void method_158()
		{
			this.method_50();
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00085A80 File Offset: 0x00083C80
		internal void method_159()
		{
			this.method_235();
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00085A94 File Offset: 0x00083C94
		internal void method_160(Object object_2)
		{
			this.method_8(object_2);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00085AA8 File Offset: 0x00083CA8
		private IEnumerator method_161(Action<Player> action_2, float float_0)
		{
			GClass93.Class147 @class = new GClass93.Class147(0);
			@class.gclass93_0 = this;
			@class.action_0 = action_2;
			@class.float_0 = float_0;
			return @class;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00085AD0 File Offset: 0x00083CD0
		internal void method_162(Object object_2)
		{
			this.method_160(object_2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00085AE4 File Offset: 0x00083CE4
		internal void method_163()
		{
			this.method_224();
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00085AF8 File Offset: 0x00083CF8
		private void method_164(string string_4)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Receive",
				"Command",
				"(",
				string_4,
				")"
			}), GClass70.Enum1.const_0);
			if (!(GClass84.smethod_1428(string_4, 1) != "["))
			{
				string_4 = GClass84.smethod_1204(string_4, 1, -1);
				int num = GClass84.smethod_1611(string_4, "]");
				if (num != -1)
				{
					string string_5 = GClass84.smethod_1428(string_4, num);
					string_4 = GClass84.smethod_1204(string_4, num + 1, -1);
					while (GClass84.smethod_1428(string_4, 1) == " ")
					{
						string_4 = GClass84.smethod_1204(string_4, 1, -1);
					}
					num = GClass84.smethod_1611(string_4, "{");
					if (num != -1)
					{
						string text = GClass84.smethod_1204(string_4, num + 1, -1);
						num = GClass84.smethod_1611(string_4, "}");
						if (num != -1)
						{
							text = GClass84.smethod_1428(text, num);
							if (text != string.Empty)
							{
								List<string> list = new List<string>();
								for (num = GClass84.smethod_1611(text, ";"); num != -1; num = GClass84.smethod_1611(text, ";"))
								{
									string text2 = GClass84.smethod_1428(text, num + 1);
									while (GClass84.smethod_1428(text2, 1) == " ")
									{
										text2 = GClass84.smethod_1204(text2, 1, -1);
									}
									list.Add(text2);
									text = GClass84.smethod_1204(text, num + 1, -1);
								}
								this.method_64(string_5, list);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00085C60 File Offset: 0x00083E60
		internal void method_165(string string_4)
		{
			this.method_40(string_4);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00085C74 File Offset: 0x00083E74
		internal void method_166(bool bool_26)
		{
			this.method_228(bool_26);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00085C88 File Offset: 0x00083E88
		internal void method_167(Action<Player> action_2)
		{
			Action<Player> action = this.action_1;
			Action<Player> action2;
			do
			{
				action2 = action;
				Action<Player> value = (Action<Player>)Delegate.Combine(action2, action_2);
				action = Interlocked.CompareExchange<Action<Player>>(ref this.action_1, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00085CC0 File Offset: 0x00083EC0
		internal void method_168(GameObject gameObject_3)
		{
			this.method_223(gameObject_3);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00085CD4 File Offset: 0x00083ED4
		internal void method_169(GameObject gameObject_3)
		{
			if (gameObject_3)
			{
				new GameObject(this.string_0)
				{
					transform = 
					{
						parent = gameObject_3.transform,
						localPosition = new Vector3(0f, 0f, 0f),
						localRotation = new Quaternion(0f, 0f, 0f, 0f)
					}
				}.SetActive(false);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00085D54 File Offset: 0x00083F54
		internal void method_170(bool bool_26)
		{
			this.bool_9 = bool_26;
			GClass84.gclass117_0.bool_2 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00085D78 File Offset: 0x00083F78
		internal void method_171(string string_4)
		{
			this.method_60(string_4);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00085D8C File Offset: 0x00083F8C
		public static void smethod_32()
		{
			GClass93.smethod_33();
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00085DA0 File Offset: 0x00083FA0
		private void method_172(string string_4)
		{
			this.method_75(string_4);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00085DB4 File Offset: 0x00083FB4
		internal void method_173(bool bool_26)
		{
			this.method_150(bool_26);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00085DC8 File Offset: 0x00083FC8
		internal void method_174(string string_4, string string_5)
		{
			this.method_104(string_4, string_5);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00085DE0 File Offset: 0x00083FE0
		internal static void smethod_33()
		{
			GClass93.smethod_1();
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00085DF4 File Offset: 0x00083FF4
		internal void method_175(bool bool_26)
		{
			this.method_65(bool_26);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00085E08 File Offset: 0x00084008
		internal void method_176(Player player_0)
		{
			this.method_238(player_0);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00085E1C File Offset: 0x0008401C
		public static void smethod_34()
		{
			GClass93.smethod_6();
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00085E30 File Offset: 0x00084030
		internal static void smethod_35()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_84();
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00085E54 File Offset: 0x00084054
		internal void method_177(string string_4 = "")
		{
			this.method_165(string_4);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00085E68 File Offset: 0x00084068
		internal void method_178(bool bool_26)
		{
			this.bool_25 = bool_26;
			GClass84.gclass117_0.bool_12 = bool_26;
			GClass117.smethod_3();
			foreach (GClass93.Struct19 @struct in GClass93.list_3)
			{
				if (@struct.gameObject_0)
				{
					@struct.gameObject_0.SetActive(bool_26);
				}
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00085EE4 File Offset: 0x000840E4
		internal static void smethod_36()
		{
			GClass93.smethod_9();
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00085EF8 File Offset: 0x000840F8
		internal void method_179(bool bool_26)
		{
			this.method_94(bool_26);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00085F0C File Offset: 0x0008410C
		private void method_180(Player player_0)
		{
			this.method_243(player_0);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00085F20 File Offset: 0x00084120
		internal void method_181()
		{
			for (int i = 0; i < GClass84.list_9.Count; i++)
			{
				GClass84.list_9[i]();
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00085F54 File Offset: 0x00084154
		internal void method_182()
		{
			for (int i = 0; i < GClass84.list_31.Count; i++)
			{
				GClass84.list_31[i]();
			}
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00085F88 File Offset: 0x00084188
		internal void method_183(Action<Player> action_2)
		{
			Action<Player> action = this.action_0;
			Action<Player> action2;
			do
			{
				action2 = action;
				Action<Player> value = (Action<Player>)Delegate.Remove(action2, action_2);
				action = Interlocked.CompareExchange<Action<Player>>(ref this.action_0, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00085FC0 File Offset: 0x000841C0
		internal void method_184(int int_5)
		{
			this.method_34(int_5);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00085FD4 File Offset: 0x000841D4
		internal void method_185()
		{
			for (int i = 0; i < GClass84.list_0.Count; i++)
			{
				GClass84.list_0[i]();
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00086008 File Offset: 0x00084208
		private void method_186()
		{
			this.method_87();
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0008601C File Offset: 0x0008421C
		internal void method_187(bool bool_26)
		{
			GClass84.bool_4 = bool_26;
			GClass84.gclass117_0.bool_11 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00086040 File Offset: 0x00084240
		internal void method_188()
		{
			if (this.audioSource_0)
			{
				this.audioSource_0.volume = (this.bool_15 ? ((GClass84.smethod_1424() != null) ? 0.3f : 0.3f) : 0.15f);
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0008608C File Offset: 0x0008428C
		internal static HarmonyMethod smethod_37(string string_4)
		{
			return new HarmonyMethod(typeof(GClass93).GetMethod(string_4, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000860B4 File Offset: 0x000842B4
		internal void method_189(bool bool_26)
		{
			this.method_19(bool_26);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000860C8 File Offset: 0x000842C8
		internal void method_190()
		{
			this.method_148();
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000860DC File Offset: 0x000842DC
		internal void method_191()
		{
			Player[] array = GClass84.smethod_870();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_28(array[i]);
				APIUser apiuser = GClass84.smethod_518(array[i]);
				if (vrcplayerApi != null && apiuser != null)
				{
					GameObject gameObject = GClass84.smethod_969(vrcplayerApi);
					if (gameObject && !this.method_122(gameObject))
					{
						PipelineManager component = gameObject.GetComponent<PipelineManager>();
						if (component && component.blueprintId == "avtr_749445a8-d9bf-4d48-b077-d18b776f66f7")
						{
							this.method_168(gameObject);
							return;
						}
						ApiAvatar apiAvatar = GClass84.smethod_1075(array[i]);
						if (apiAvatar != null)
						{
							string text = apiuser.displayName ?? "!null!";
							GClass70.smethod_117(GClass84.smethod_1571(apiuser, true), string.Concat(new string[]
							{
								text,
								" ",
								"Has",
								" ",
								"Avatar",
								": ",
								apiAvatar.id,
								" (",
								apiAvatar.name,
								")"
							}), GClass70.Enum1.const_5);
							if (APIUser.IsFriendsWith(apiuser.id))
							{
								GClass84.gclass39_0.method_52(apiAvatar);
							}
							else if (vrcplayerApi.isLocal)
							{
								GClass84.gclass39_0.method_36(apiAvatar);
							}
						}
						this.method_168(gameObject);
					}
				}
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00086248 File Offset: 0x00084448
		internal void method_192(UdonBehaviour udonBehaviour_0, NetworkEventTarget networkEventTarget_0, string string_4)
		{
			this.method_3(udonBehaviour_0, networkEventTarget_0, string_4);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00086260 File Offset: 0x00084460
		internal void method_193(GameObject gameObject_3, GameObject gameObject_4)
		{
			this.method_83(gameObject_3, gameObject_4);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00086278 File Offset: 0x00084478
		internal void method_194()
		{
			this.method_182();
		}

		// Token: 0x06001A35 RID: 6709
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, int int_5, out IntPtr intptr_2);

		// Token: 0x06001A36 RID: 6710 RVA: 0x0008628C File Offset: 0x0008448C
		internal void method_195(bool bool_26)
		{
			this.method_6(bool_26);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000862A0 File Offset: 0x000844A0
		internal void method_196(bool bool_26)
		{
			this.method_16(bool_26);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000862B4 File Offset: 0x000844B4
		internal void method_197(UdonBehaviour udonBehaviour_0, string string_4)
		{
			for (int i = 0; i < GClass84.list_24.Count; i++)
			{
				GClass84.list_24[i](udonBehaviour_0, string_4);
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000862EC File Offset: 0x000844EC
		internal void method_198()
		{
			this.method_157();
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00086300 File Offset: 0x00084500
		internal void method_199(bool bool_26)
		{
			this.bool_13 = bool_26;
			GClass84.gclass117_0.bool_3 = bool_26;
			GClass117.smethod_3();
			this.method_234();
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0008632C File Offset: 0x0008452C
		private void method_200(string string_4)
		{
			this.method_53(string_4);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00086340 File Offset: 0x00084540
		public static void smethod_38()
		{
			GClass93.smethod_48();
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00086354 File Offset: 0x00084554
		internal void method_201(Player player_0)
		{
			this.method_67(player_0);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00086368 File Offset: 0x00084568
		internal void method_202()
		{
			if (this.audioSource_0 && this.audioSource_0.isPlaying)
			{
				this.audioSource_0.Stop();
			}
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000863A0 File Offset: 0x000845A0
		private void method_203(Player player_0)
		{
			this.method_124(player_0);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000863B4 File Offset: 0x000845B4
		internal static void smethod_39(IntPtr intptr_0)
		{
			GClass93.smethod_22(intptr_0);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000863C8 File Offset: 0x000845C8
		internal void method_204(bool bool_26)
		{
			this.method_51(bool_26);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000863DC File Offset: 0x000845DC
		private void method_205()
		{
			this.method_136();
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00086414 File Offset: 0x00084614
		internal static void smethod_40()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_190();
			}
			else
			{
				new GClass93().method_190();
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00086444 File Offset: 0x00084644
		internal bool method_206(GClass130 gclass130_0)
		{
			bool result;
			if (gclass130_0 == null)
			{
				result = false;
			}
			else
			{
				this.list_0.Add(gclass130_0);
				try
				{
					gclass130_0.vmethod_23();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
				if (this.bool_14)
				{
					try
					{
						gclass130_0.vmethod_12();
					}
					catch (Exception ex2)
					{
						GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000864C0 File Offset: 0x000846C0
		private static void smethod_41(ref CursorLockMode cursorLockMode_0)
		{
			GClass93.smethod_15(ref cursorLockMode_0);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000864D4 File Offset: 0x000846D4
		internal void method_207(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			this.method_216(udonBehaviour_0, string_4, player_0);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000864EC File Offset: 0x000846EC
		private static void smethod_42(ref int int_5)
		{
			GClass93.smethod_5(ref int_5);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00086500 File Offset: 0x00084700
		internal void method_208()
		{
			this.method_146();
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00086514 File Offset: 0x00084714
		internal void method_209(int int_5)
		{
			this.int_0 = GClass84.smethod_841();
			for (int i = 0; i < GClass84.list_2.Count; i++)
			{
				GClass84.list_2[i](int_5);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00086554 File Offset: 0x00084754
		internal void method_210(int int_5)
		{
			this.method_115(int_5);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00086568 File Offset: 0x00084768
		internal void method_211()
		{
			this.method_152();
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0008657C File Offset: 0x0008477C
		internal void method_212(Player player_0)
		{
			this.method_107(player_0);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00086590 File Offset: 0x00084790
		internal void method_213(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			this.method_31(udonBehaviour_0, string_4, player_0);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000865A8 File Offset: 0x000847A8
		internal void method_214(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_5, float float_0)
		{
			for (int i = 0; i < GClass84.list_25.Count; i++)
			{
				GClass84.list_25[i](vrcEvent_0, vrcBroadcastType_0, int_5, float_0);
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x000865E4 File Offset: 0x000847E4
		internal void method_215()
		{
			for (int i = 0; i < GClass84.list_13.Count; i++)
			{
				GClass84.list_13[i]();
			}
			try
			{
				this.method_234();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			this.bool_14 = true;
			try
			{
				this.method_58();
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
			if (this.bool_5)
			{
				Console.WriteLine("Press any button to continue");
				Console.ReadKey();
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00086684 File Offset: 0x00084884
		internal void method_216(UdonBehaviour udonBehaviour_0, string string_4, Player player_0)
		{
			for (int i = 0; i < GClass84.list_21.Count; i++)
			{
				GClass84.list_21[i](udonBehaviour_0, string_4, player_0);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000866BC File Offset: 0x000848BC
		private void method_217(string string_4, List<string> list_7)
		{
			GClass70.smethod_38("Receive" + "Commands" + ": " + string_4, GClass70.Enum1.const_0);
			for (int i = 0; i < list_7.Count; i++)
			{
				GClass70.smethod_24(list_7[i], GClass70.Enum1.const_0);
			}
			for (int j = 0; j < GClass84.list_15.Count; j++)
			{
				GClass84.list_15[j](string_4, list_7);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00086730 File Offset: 0x00084930
		internal void method_218()
		{
			for (int i = 0; i < GClass84.list_30.Count; i++)
			{
				GClass84.list_30[i]();
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00086764 File Offset: 0x00084964
		public static void smethod_43()
		{
			GClass93.smethod_17();
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00086778 File Offset: 0x00084978
		public static void smethod_44()
		{
			GClass93.smethod_24();
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0008678C File Offset: 0x0008498C
		internal static void smethod_45()
		{
			GClass93.smethod_25();
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000867A0 File Offset: 0x000849A0
		internal void method_219(bool bool_26)
		{
			this.bool_24 = bool_26;
			GClass84.gclass117_0.bool_13 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000867C4 File Offset: 0x000849C4
		internal void method_220(int int_5)
		{
			this.method_85(int_5);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000867D8 File Offset: 0x000849D8
		internal void method_221(Player player_0)
		{
			if (!this.bool_11)
			{
				this.bool_12 = false;
				this.bool_11 = true;
			}
			Action<Player> action;
			if (!this.bool_12)
			{
				if ((action = this.action_0) != null)
				{
					goto IL_38;
				}
			}
			else if ((action = this.action_1) != null)
			{
				goto IL_38;
			}
			return;
			IL_38:
			action(player_0);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00086824 File Offset: 0x00084A24
		internal void method_222(int int_5)
		{
			this.method_11(int_5);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00086838 File Offset: 0x00084A38
		internal void method_223(GameObject gameObject_3)
		{
			this.method_169(gameObject_3);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0008684C File Offset: 0x00084A4C
		internal void method_224()
		{
			for (int i = 0; i < GClass84.list_4.Count; i++)
			{
				GClass84.list_4[i]();
			}
			try
			{
				if (!this.bool_15 && (GClass84.smethod_1424() != null && GClass84.smethod_813() != null))
				{
					this.bool_15 = true;
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			try
			{
				this.method_68();
				this.int_4++;
				if (this.int_4 >= GClass84.gclass39_0.int_4)
				{
					GClass84.gclass39_0.method_34();
					this.int_4 = 0;
				}
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00086928 File Offset: 0x00084B28
		internal void method_225()
		{
			this.method_57();
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0008693C File Offset: 0x00084B3C
		internal void method_226(int int_5)
		{
			this.method_72(int_5);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00086950 File Offset: 0x00084B50
		internal void method_227()
		{
			this.method_188();
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00086964 File Offset: 0x00084B64
		internal void method_228(bool bool_26)
		{
			this.bool_18 = bool_26;
			GClass84.gclass117_0.bool_5 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00086988 File Offset: 0x00084B88
		internal void method_229(string string_4)
		{
			this.string_2 = string_4;
			GClass84.gclass117_0.string_2 = string_4;
			GClass117.smethod_3();
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x000869AC File Offset: 0x00084BAC
		private void method_230(string string_4)
		{
			this.method_239(string_4);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000869C0 File Offset: 0x00084BC0
		private float[] method_231(byte[] byte_0)
		{
			float[] array = new float[byte_0.Length / 4];
			for (int i = 0; i < array.Length; i++)
			{
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(byte_0, i * 4, 4);
				}
				array[i] = BitConverter.ToSingle(byte_0, i * 4) / 2.14748365E+09f;
			}
			return array;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00086A10 File Offset: 0x00084C10
		public static void smethod_46()
		{
			GClass93.smethod_20();
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00086A24 File Offset: 0x00084C24
		private void method_232()
		{
			if (GClass84.gclass152_0 != null && GClass84.gclass152_0.bool_7)
			{
				List<string> list = null;
				object obj = this.object_1;
				lock (obj)
				{
					if (this.list_5.Count > 0)
					{
						list = new List<string>();
						list.AddRange(this.list_5);
						this.list_5.Clear();
					}
				}
				if (list != null)
				{
					foreach (string string_ in list)
					{
						this.method_141(string_);
					}
				}
			}
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00086AF0 File Offset: 0x00084CF0
		internal void method_233()
		{
			this.method_249();
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00086B04 File Offset: 0x00084D04
		internal void method_234()
		{
			this.method_29();
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00086B18 File Offset: 0x00084D18
		internal static void smethod_47()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_22();
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00086B3C File Offset: 0x00084D3C
		internal void method_235()
		{
			for (int i = 0; i < GClass84.list_11.Count; i++)
			{
				GClass84.list_11[i]();
			}
			if (GClass84.gclass39_0 != null)
			{
				try
				{
					GClass84.gclass39_0.method_34();
					GClass84.gclass39_0.method_29();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
			try
			{
				this.method_23();
			}
			catch (Exception ex2)
			{
				GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
			}
			if (this.bool_2)
			{
				try
				{
					this.method_90().GetAwaiter().GetResult();
				}
				catch (Exception ex3)
				{
					GClass70.smethod_36(ex3.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00086C14 File Offset: 0x00084E14
		internal void method_236()
		{
			this.method_194();
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00086C28 File Offset: 0x00084E28
		private void method_237(string string_4, string string_5)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"On",
				"User",
				"Disconnected",
				"(",
				string_4,
				", ",
				string_5,
				")"
			}), GClass70.Enum1.const_0);
			for (int i = 0; i < GClass84.list_18.Count; i++)
			{
				GClass84.list_18[i](string_4, string_5);
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00086CA8 File Offset: 0x00084EA8
		internal void method_238(Player player_0)
		{
			try
			{
				if (player_0)
				{
					APIUser apiuser = GClass84.smethod_518(player_0);
					VRCPlayer vrcplayer = GClass84.smethod_367(player_0);
					if (apiuser != null && vrcplayer)
					{
						GameObject gameObject = player_0.gameObject;
						if (gameObject)
						{
							GameObject gameObject2 = GClass84.smethod_138(gameObject, "Player Nameplate/Canvas/Nameplate/Contents/Quick Stats");
							if (gameObject2)
							{
								GameObject gameObject3 = null;
								GameObject gameObject4 = null;
								GameObject gameObject5 = Object.Instantiate<GameObject>(gameObject2, gameObject2.transform.parent);
								gameObject5.name = "Info";
								gameObject5.transform.localPosition = new Vector3(0f, -85f, 0f);
								gameObject5.SetActive(this.bool_25);
								GameObject[] array = GClass84.smethod_1034(gameObject5);
								GameObject gameObject6 = null;
								for (int i = array.Length - 1; i >= 0; i--)
								{
									if (array[i])
									{
										if (array[i].name == "Trust Text")
										{
											array[i].name = "FPSInfoText";
											gameObject3 = array[i];
											GClass84.smethod_31(array[i]);
											gameObject6 = Object.Instantiate<GameObject>(array[i], array[i].transform.parent);
											array[i].name = "CrashInfoText";
											GClass84.smethod_31(gameObject6);
											gameObject6.transform.SetAsFirstSibling();
										}
										else if (array[i].name == "Performance Text")
										{
											array[i].name = "PingInfoText";
											gameObject4 = array[i];
											GClass84.smethod_31(array[i]);
										}
										else
										{
											GClass84.smethod_890(array[i], false);
										}
									}
								}
								if (gameObject3 && gameObject4 && gameObject6)
								{
									TextMeshProUGUI component = gameObject3.GetComponent<TextMeshProUGUI>();
									TextMeshProUGUI component2 = gameObject4.GetComponent<TextMeshProUGUI>();
									TextMeshProUGUI component3 = gameObject6.GetComponent<TextMeshProUGUI>();
									if (component && component2)
									{
										component.text = string.Empty;
										component2.text = string.Empty;
										GClass93.list_3.Add(new GClass93.Struct19(vrcplayer, gameObject5, gameObject3, gameObject4, gameObject6, component, component2, component3, GClass84.smethod_301(GClass84.smethod_1422(vrcplayer))));
									}
									else
									{
										GClass84.smethod_890(gameObject5, false);
									}
								}
								else
								{
									GClass84.smethod_890(gameObject5, false);
								}
							}
							GameObject gameObject7 = GClass84.smethod_138(gameObject, "Player Nameplate/Canvas/Nameplate/Contents/Main/Background");
							if (gameObject7)
							{
								ImageThreeSlice component4 = gameObject7.GetComponent<ImageThreeSlice>();
								if (component4)
								{
									Color color = GClass84.smethod_204(apiuser, true, true, false);
									color.a = component4.color.a;
									component4.color = color;
								}
							}
							GameObject gameObject8 = GClass84.smethod_138(gameObject, "Player Nameplate/Canvas/Nameplate/Contents/Icon/Background");
							if (gameObject8)
							{
								Image component5 = gameObject8.GetComponent<Image>();
								if (component5)
								{
									Color color2 = GClass84.smethod_204(apiuser, true, true, false);
									color2.a = component5.color.a;
									component5.color = color2;
								}
							}
						}
						if (this.bool_9)
						{
							if (!(GClass84.smethod_1372().id == apiuser.id))
							{
								if (this.method_93())
								{
									string text = GClass84.smethod_828(apiuser, "!null!");
									string text2 = text + " " + "Joined";
									if (GClass84.float_2 < 0f || GClass84.float_2 > 10f)
									{
										string string_ = string.Concat(new string[]
										{
											text,
											" ",
											"has",
											" ",
											"joined",
											"."
										});
										GClass84.smethod_1609(GClass84.smethod_204(apiuser, false, false, true), string_);
									}
									for (int j = 0; j < this.list_1.Count; j++)
									{
										GClass93.Struct18 @struct = this.list_1[j];
										if (@struct.bool_0)
										{
											string text3 = @struct.string_0;
											if (!(text3 != string.Empty) || !(text == text3))
											{
												if (!vrcplayer)
												{
													goto IL_41D;
												}
												string text4 = @struct.string_1;
												if (!(text4 != string.Empty) || !(GClass84.smethod_385(vrcplayer) == text4))
												{
													goto IL_41D;
												}
												GClass84.smethod_521(player_0);
												@struct.bool_0 = false;
												this.list_1[j] = @struct;
											}
											else
											{
												GClass84.smethod_521(player_0);
												@struct.bool_0 = false;
												this.list_1[j] = @struct;
											}
											IL_475:
											ApiAvatar apiAvatar = GClass84.smethod_1468(vrcplayer);
											if (apiAvatar != null)
											{
												string id = apiAvatar.id;
												if (id != string.Empty)
												{
													string text5 = apiAvatar.name;
													if (text5 != string.Empty)
													{
														text5 = " (" + text5 + ")" + ")";
													}
													else
													{
														text5 = ")";
													}
													text2 = string.Concat(new string[]
													{
														text2,
														" (",
														"Avatar",
														": ",
														id,
														text5
													});
												}
											}
											GClass70.smethod_117(GClass84.smethod_1571(apiuser, true), text2, GClass70.Enum1.const_3);
											return;
										}
										IL_41D:;
									}
									goto IL_475;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00087200 File Offset: 0x00085400
		private void method_239(string string_4)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Do",
				"Event",
				"(",
				string_4,
				")"
			}), GClass70.Enum1.const_0);
			if (GClass84.smethod_1428(string_4, GClass84.smethod_593("OnUserConnected(")) == "OnUserConnected(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("OnUserConnected("), -1);
				int num = GClass84.smethod_1611(string_4, ");");
				if (num != -1 && GClass84.smethod_1204(string_4, num + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num);
					num = GClass84.smethod_1611(string_4, ",");
					if (num != -1)
					{
						string string_5 = GClass84.smethod_1428(string_4, num);
						string string_6 = GClass84.smethod_1204(string_4, num + 1, -1);
						this.method_118(string_5, string_6);
					}
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("OnUserDisconnected(")) == "OnUserDisconnected(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("OnUserDisconnected("), -1);
				int num2 = GClass84.smethod_1611(string_4, ");");
				if (num2 != -1 && GClass84.smethod_1204(string_4, num2 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num2);
					num2 = GClass84.smethod_1611(string_4, ",");
					if (num2 != -1)
					{
						string string_7 = GClass84.smethod_1428(string_4, num2);
						string string_8 = GClass84.smethod_1204(string_4, num2 + 1, -1);
						this.method_73(string_7, string_8);
					}
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("OnUserInLoadScreen(")) == "OnUserInLoadScreen(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("OnUserInLoadScreen("), -1);
				int num3 = GClass84.smethod_1611(string_4, ");");
				if (num3 != -1 && GClass84.smethod_1204(string_4, num3 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num3);
					num3 = GClass84.smethod_1611(string_4, ",");
					if (num3 != -1)
					{
						string string_9 = GClass84.smethod_1428(string_4, num3);
						string string_10 = GClass84.smethod_1204(string_4, num3 + 1, -1);
						this.method_82(string_9, string_10);
					}
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("OnUserChangedInstance(")) == "OnUserChangedInstance(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("OnUserChangedInstance("), -1);
				int num4 = GClass84.smethod_1611(string_4, ");");
				if (num4 != -1 && GClass84.smethod_1204(string_4, num4 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num4);
					num4 = GClass84.smethod_1611(string_4, ",");
					if (num4 != -1)
					{
						string string_11 = GClass84.smethod_1428(string_4, num4);
						string string_12 = GClass84.smethod_1204(string_4, num4 + 1, -1);
						this.method_120(string_11, string_12);
					}
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("Command: ")) == "Command: ")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("Command: "), -1);
				if (!(GClass84.smethod_1428(string_4, 1) != "["))
				{
					string_4 = GClass84.smethod_1204(string_4, 1, -1);
					int num5 = GClass84.smethod_1611(string_4, "]");
					if (num5 != -1)
					{
						string string_13 = GClass84.smethod_1428(string_4, num5);
						string text = GClass84.smethod_1204(string_4, num5 + 1, -1);
						if (text != string.Empty)
						{
							this.method_64(string_13, new List<string>
							{
								text
							});
						}
					}
				}
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000875B8 File Offset: 0x000857B8
		internal void method_240()
		{
			try
			{
				if (GClass84.bool_3)
				{
					if (GClass84.smethod_1424() != null)
					{
						GClass84.float_2 += GClass84.float_0;
					}
					else
					{
						GClass84.bool_3 = false;
						GClass84.float_2 = 0f;
					}
				}
				else if (GClass84.smethod_1424() != null)
				{
					GClass84.bool_3 = true;
					GClass84.float_2 = 0f;
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			for (int i = 0; i < GClass84.list_5.Count; i++)
			{
				GClass84.list_5[i]();
			}
			this.method_253();
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00087668 File Offset: 0x00085868
		internal void method_241(VRCEventDelegate<Player> vrceventDelegate_0, Action<Player> action_2)
		{
			this.method_128(vrceventDelegate_0, action_2);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00087680 File Offset: 0x00085880
		internal void method_242(bool bool_26)
		{
			this.bool_0 = bool_26;
			GClass84.gclass117_0.bool_9 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000876A4 File Offset: 0x000858A4
		internal static void smethod_48()
		{
			GClass93.smethod_50();
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000876B8 File Offset: 0x000858B8
		private void method_243(Player player_0)
		{
			this.method_254(player_0);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000876CC File Offset: 0x000858CC
		internal int method_244(string string_4)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Receive",
				"Events",
				"(",
				string_4,
				")"
			}), GClass70.Enum1.const_0);
			try
			{
				if (GClass84.smethod_1428(string_4, 1) != "{" || GClass84.smethod_360(string_4, 1) != "}")
				{
					return 0;
				}
				string_4 = GClass84.smethod_1204(string_4, 1, GClass84.smethod_593(string_4) - 2);
				if (string_4 != string.Empty)
				{
					List<string> list = new List<string>();
					for (int num = GClass84.smethod_1611(string_4, ";"); num != -1; num = GClass84.smethod_1611(string_4, ";"))
					{
						string text = GClass84.smethod_1428(string_4, num + 1);
						while (GClass84.smethod_1428(text, 1) == " ")
						{
							text = GClass84.smethod_1204(text, 1, -1);
						}
						list.Add(text);
						string_4 = GClass84.smethod_1204(string_4, num + 1, -1);
					}
					this.method_39(list);
					return list.Count;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000877F4 File Offset: 0x000859F4
		internal void method_245(string string_4)
		{
			this.method_109(string_4);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00087808 File Offset: 0x00085A08
		internal void method_246(string string_4)
		{
			this.method_229(string_4);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0008781C File Offset: 0x00085A1C
		private static void smethod_49(ref int int_5)
		{
			GClass93.smethod_42(ref int_5);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00087830 File Offset: 0x00085A30
		internal void method_247(bool bool_26)
		{
			this.method_219(bool_26);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00087844 File Offset: 0x00085A44
		private void method_248(string string_4, string string_5)
		{
			this.method_137(string_4, string_5);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0008785C File Offset: 0x00085A5C
		internal static void smethod_50()
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_97();
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00087880 File Offset: 0x00085A80
		internal void method_249()
		{
			for (int i = 0; i < GClass84.list_29.Count; i++)
			{
				GClass84.list_29[i]();
			}
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000878B4 File Offset: 0x00085AB4
		internal static void smethod_51(int int_5)
		{
			if (GClass84.gclass93_0 != null)
			{
				GClass84.gclass93_0.method_226(int_5);
			}
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000878D8 File Offset: 0x00085AD8
		internal static void smethod_52(int int_5)
		{
			GClass93.smethod_51(int_5);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000878EC File Offset: 0x00085AEC
		private void method_250()
		{
			this.method_86();
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00087900 File Offset: 0x00085B00
		internal void method_251(bool bool_26)
		{
			this.bool_6 = bool_26;
			GClass84.gclass117_0.bool_1 = bool_26;
			GClass117.smethod_3();
		}

		// Token: 0x06001A7F RID: 6783
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int int_5, bool bool_26, int int_6);

		// Token: 0x06001A80 RID: 6784 RVA: 0x00087924 File Offset: 0x00085B24
		internal void method_252()
		{
			this.method_240();
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00087938 File Offset: 0x00085B38
		internal void method_253()
		{
			this.method_211();
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0008794C File Offset: 0x00085B4C
		private void method_254(Player player_0)
		{
			if (this.bool_22 && GClass84.smethod_1725(player_0))
			{
				if (!GClass93.list_6.Contains(GClass84.smethod_684(player_0)))
				{
					GClass93.list_6.Add(GClass84.smethod_684(player_0));
					player_0.smethod_1435();
				}
			}
			else if (GClass84.smethod_1725(player_0) && !this.bool_22 && GClass93.list_6.Contains(GClass84.smethod_684(player_0)))
			{
				GClass93.list_6.Remove(GClass84.smethod_684(player_0));
				player_0.smethod_70();
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000879D8 File Offset: 0x00085BD8
		internal void method_255(Action<Player> action_2)
		{
			Action<Player> action = this.action_0;
			Action<Player> action2;
			do
			{
				action2 = action;
				Action<Player> value = (Action<Player>)Delegate.Combine(action2, action_2);
				action = Interlocked.CompareExchange<Action<Player>>(ref this.action_0, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x04000EF8 RID: 3832
		internal bool bool_0 = true;

		// Token: 0x04000EF9 RID: 3833
		internal bool bool_1 = true;

		// Token: 0x04000EFA RID: 3834
		internal bool bool_2 = true;

		// Token: 0x04000EFB RID: 3835
		internal bool bool_3 = true;

		// Token: 0x04000EFC RID: 3836
		internal bool bool_4 = true;

		// Token: 0x04000EFD RID: 3837
		internal bool bool_5 = false;

		// Token: 0x04000EFE RID: 3838
		internal bool bool_6 = true;

		// Token: 0x04000EFF RID: 3839
		internal bool bool_7 = true;

		// Token: 0x04000F00 RID: 3840
		internal bool bool_8 = false;

		// Token: 0x04000F01 RID: 3841
		private List<GClass130> list_0 = new List<GClass130>();

		// Token: 0x04000F02 RID: 3842
		internal bool bool_9 = true;

		// Token: 0x04000F03 RID: 3843
		internal bool bool_10 = false;

		// Token: 0x04000F04 RID: 3844
		internal bool bool_11 = false;

		// Token: 0x04000F05 RID: 3845
		internal bool bool_12;

		// Token: 0x04000F06 RID: 3846
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Player> action_0;

		// Token: 0x04000F07 RID: 3847
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Player> action_1;

		// Token: 0x04000F08 RID: 3848
		internal int int_0 = 0;

		// Token: 0x04000F09 RID: 3849
		internal bool bool_13 = false;

		// Token: 0x04000F0A RID: 3850
		internal List<GClass93.Struct18> list_1 = new List<GClass93.Struct18>();

		// Token: 0x04000F0B RID: 3851
		private int int_1;

		// Token: 0x04000F0C RID: 3852
		private int int_2;

		// Token: 0x04000F0D RID: 3853
		private int int_3;

		// Token: 0x04000F0E RID: 3854
		internal Delegate delegate_0;

		// Token: 0x04000F0F RID: 3855
		internal int int_4 = 0;

		// Token: 0x04000F10 RID: 3856
		internal string string_0 = "CheckedAlready_";

		// Token: 0x04000F11 RID: 3857
		internal bool bool_14 = false;

		// Token: 0x04000F12 RID: 3858
		internal bool bool_15 = false;

		// Token: 0x04000F13 RID: 3859
		internal GameObject gameObject_0;

		// Token: 0x04000F14 RID: 3860
		internal AudioSource audioSource_0;

		// Token: 0x04000F15 RID: 3861
		internal GameObject gameObject_1;

		// Token: 0x04000F16 RID: 3862
		internal AudioSource audioSource_1;

		// Token: 0x04000F17 RID: 3863
		internal GameObject gameObject_2;

		// Token: 0x04000F18 RID: 3864
		internal AudioSource audioSource_2;

		// Token: 0x04000F19 RID: 3865
		internal string string_1 = string.Empty;

		// Token: 0x04000F1A RID: 3866
		internal string string_2 = string.Empty;

		// Token: 0x04000F1B RID: 3867
		private bool bool_16 = true;

		// Token: 0x04000F1C RID: 3868
		private string string_3 = string.Empty;

		// Token: 0x04000F1D RID: 3869
		internal bool bool_17 = true;

		// Token: 0x04000F1E RID: 3870
		internal bool bool_18 = true;

		// Token: 0x04000F1F RID: 3871
		internal bool bool_19 = true;

		// Token: 0x04000F20 RID: 3872
		internal bool bool_20 = true;

		// Token: 0x04000F21 RID: 3873
		internal bool bool_21 = true;

		// Token: 0x04000F22 RID: 3874
		private List<GClass84.GStruct132> list_2 = new List<GClass84.GStruct132>();

		// Token: 0x04000F23 RID: 3875
		private long long_0;

		// Token: 0x04000F24 RID: 3876
		internal bool bool_22 = false;

		// Token: 0x04000F25 RID: 3877
		internal bool bool_23 = false;

		// Token: 0x04000F26 RID: 3878
		internal bool bool_24 = false;

		// Token: 0x04000F27 RID: 3879
		internal static List<GClass93.Struct19> list_3 = new List<GClass93.Struct19>();

		// Token: 0x04000F28 RID: 3880
		internal bool bool_25 = true;

		// Token: 0x04000F29 RID: 3881
		private Class173 class173_0 = null;

		// Token: 0x04000F2A RID: 3882
		private AssetBundle assetBundle_0 = null;

		// Token: 0x04000F2B RID: 3883
		private object object_0 = new object();

		// Token: 0x04000F2C RID: 3884
		private List<string> list_4 = new List<string>();

		// Token: 0x04000F2D RID: 3885
		private object object_1 = new object();

		// Token: 0x04000F2E RID: 3886
		private List<string> list_5 = new List<string>();

		// Token: 0x04000F2F RID: 3887
		private static List<string> list_6 = new List<string>();

		// Token: 0x02000236 RID: 566
		internal struct Struct18
		{
			// Token: 0x06001A84 RID: 6788 RVA: 0x00087A10 File Offset: 0x00085C10
			public Struct18(string string_3 = "", string string_4 = "", string string_5 = "")
			{
				this.string_0 = string_3;
				this.string_1 = string_4;
				this.string_2 = string_5;
				this.bool_0 = true;
			}

			// Token: 0x04000F30 RID: 3888
			public string string_0;

			// Token: 0x04000F31 RID: 3889
			public string string_1;

			// Token: 0x04000F32 RID: 3890
			public string string_2;

			// Token: 0x04000F33 RID: 3891
			public bool bool_0;
		}

		// Token: 0x02000237 RID: 567
		internal struct Struct19
		{
			// Token: 0x06001A85 RID: 6789 RVA: 0x00087A3C File Offset: 0x00085C3C
			internal Struct19(VRCPlayer vrcplayer_1, GameObject gameObject_4, GameObject gameObject_5, GameObject gameObject_6, GameObject gameObject_7, TextMeshProUGUI textMeshProUGUI_3, TextMeshProUGUI textMeshProUGUI_4, TextMeshProUGUI textMeshProUGUI_5, int int_2)
			{
				this.vrcplayer_0 = vrcplayer_1;
				this.gameObject_0 = gameObject_4;
				this.gameObject_1 = gameObject_5;
				this.gameObject_2 = gameObject_6;
				this.gameObject_3 = gameObject_7;
				this.textMeshProUGUI_0 = textMeshProUGUI_3;
				this.textMeshProUGUI_1 = textMeshProUGUI_4;
				this.textMeshProUGUI_2 = textMeshProUGUI_5;
				this.int_0 = int_2;
				this.int_1 = 0;
			}

			// Token: 0x04000F34 RID: 3892
			internal VRCPlayer vrcplayer_0;

			// Token: 0x04000F35 RID: 3893
			internal GameObject gameObject_0;

			// Token: 0x04000F36 RID: 3894
			internal GameObject gameObject_1;

			// Token: 0x04000F37 RID: 3895
			internal GameObject gameObject_2;

			// Token: 0x04000F38 RID: 3896
			internal GameObject gameObject_3;

			// Token: 0x04000F39 RID: 3897
			internal TextMeshProUGUI textMeshProUGUI_0;

			// Token: 0x04000F3A RID: 3898
			internal TextMeshProUGUI textMeshProUGUI_1;

			// Token: 0x04000F3B RID: 3899
			internal TextMeshProUGUI textMeshProUGUI_2;

			// Token: 0x04000F3C RID: 3900
			internal int int_0;

			// Token: 0x04000F3D RID: 3901
			internal int int_1;
		}

		// Token: 0x02000239 RID: 569
		[CompilerGenerated]
		[Serializable]
		private sealed class Class145
		{
			// Token: 0x06001A8D RID: 6797 RVA: 0x00087B6C File Offset: 0x00085D6C
			internal void method_0(bool bool_0)
			{
				if (bool_0)
				{
					GClass84.smethod_663(GClass84.gclass117_0.int_0);
				}
				else
				{
					GClass84.smethod_663(GClass84.gclass117_0.int_1);
				}
			}

			// Token: 0x04000F41 RID: 3905
			public static readonly GClass93.Class145 class145_0 = new GClass93.Class145();

			// Token: 0x04000F42 RID: 3906
			public static Action<bool> action_0;
		}
	}
}
