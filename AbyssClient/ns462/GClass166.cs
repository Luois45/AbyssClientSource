using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using MelonLoader;
using MelonLoader.TinyJSON;
using ns185;
using ns241;
using ns425;
using UnhollowerBaseLib;

namespace ns462
{
	// Token: 0x020002F6 RID: 758
	public class GClass166 : GClass130
	{
		// Token: 0x06004012 RID: 16402 RVA: 0x000F278C File Offset: 0x000F098C
		private void method_2()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				try
				{
					object obj = this.object_0;
					lock (obj)
					{
						File.WriteAllText(this.string_1, JSON.Dump(this.concurrentDictionary_0, 1));
					}
				}
				catch (IOException ex)
				{
					string[] array = new string[9];
					array[0] = "Exception";
					array[1] = " ";
					array[2] = "while";
					array[3] = " ";
					array[4] = "saving";
					array[5] = " ";
					array[6] = "PlayerPrefs";
					array[7] = ": ";
					int num = 8;
					IOException ex2 = ex;
					array[num] = ((ex2 != null) ? ex2.ToString() : null);
					MelonLogger.Warning(string.Concat(array));
				}
			}
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x000F2864 File Offset: 0x000F0A64
		private int method_3(IntPtr intptr_0, int int_0)
		{
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			object obj;
			if (this.concurrentDictionary_0.TryGetValue(key, out obj))
			{
				object obj2 = obj;
				object obj3 = obj2;
				if (obj3 is float)
				{
					float num = (float)obj3;
					return (int)num;
				}
				if (obj3 is int)
				{
					return (int)obj3;
				}
			}
			return int_0;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x000F28C4 File Offset: 0x000F0AC4
		private void method_4()
		{
			this.method_22();
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x000F28D8 File Offset: 0x000F0AD8
		private void method_5(IntPtr intptr_0)
		{
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			object obj;
			this.concurrentDictionary_0.TryRemove(key, out obj);
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x000F28FC File Offset: 0x000F0AFC
		private float method_6(IntPtr intptr_0, float float_0)
		{
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			object obj;
			if (this.concurrentDictionary_0.TryGetValue(key, out obj))
			{
				object obj2 = obj;
				object obj3 = obj2;
				if (obj3 is float)
				{
					return (float)obj3;
				}
				if (obj3 is int)
				{
					int num = (int)obj3;
					return (float)num;
				}
			}
			return float_0;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x000F295C File Offset: 0x000F0B5C
		private void method_7()
		{
			this.method_2();
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x000F2970 File Offset: 0x000F0B70
		private void method_8()
		{
			this.concurrentDictionary_0.Clear();
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x000F2988 File Offset: 0x000F0B88
		private IntPtr method_9(IntPtr intptr_0, IntPtr intptr_1)
		{
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			object obj;
			if (this.concurrentDictionary_0.TryGetValue(key, out obj))
			{
				string text = obj as string;
				if (text != null)
				{
					return IL2CPP.ManagedStringToIl2Cpp(text);
				}
			}
			return intptr_1;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000F29C8 File Offset: 0x000F0BC8
		private void method_10()
		{
			this.method_7();
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x000F2A1C File Offset: 0x000F0C1C
		private bool method_11(IntPtr intptr_0, float float_0)
		{
			this.bool_0 = true;
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			this.concurrentDictionary_0[key] = float_0;
			return true;
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x000F2A4C File Offset: 0x000F0C4C
		private bool method_12(IntPtr intptr_0, int int_0)
		{
			this.bool_0 = true;
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			this.concurrentDictionary_0[key] = int_0;
			return true;
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x000F2A7C File Offset: 0x000F0C7C
		internal void method_13(int int_0)
		{
			this.method_10();
			GClass70.smethod_38("Saved PlayerPrefs.json on level load", GClass70.Enum1.const_0);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000F2A9C File Offset: 0x000F0C9C
		private object method_14(string string_2, Variant variant_0)
		{
			object result;
			if (variant_0 == null)
			{
				result = null;
			}
			else
			{
				ProxyString proxyString = variant_0 as ProxyString;
				if (proxyString != null)
				{
					result = proxyString.ToString(CultureInfo.InvariantCulture);
				}
				else
				{
					ProxyNumber proxyNumber = variant_0 as ProxyNumber;
					if (proxyNumber == null)
					{
						string[] array = new string[13];
						array[0] = "Unknown";
						array[1] = " ";
						array[2] = "value";
						array[3] = " ";
						array[4] = "in";
						array[5] = " ";
						array[6] = "prefs";
						array[7] = ": ";
						array[8] = string_2;
						array[9] = " = ";
						int num = 10;
						string text;
						if (variant_0 != null)
						{
							Type type = variant_0.GetType();
							if (type != null)
							{
								text = type.ToString();
								goto IL_DA;
							}
						}
						text = null;
						IL_DA:
						array[num] = text;
						array[11] = " / ";
						array[12] = variant_0;
						throw new ArgumentException(string.Concat(array));
					}
					double num2 = proxyNumber.ToDouble(NumberFormatInfo.InvariantInfo);
					if ((double)((int)num2) == num2)
					{
						result = (int)num2;
					}
					else
					{
						result = (float)num2;
					}
				}
			}
			return result;
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x000F2BA4 File Offset: 0x000F0DA4
		private void method_15(IntPtr intptr_0)
		{
			this.method_20(intptr_0);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x000F2BB8 File Offset: 0x000F0DB8
		private unsafe void method_16<T>(string string_2, T gparam_0) where T : Delegate
		{
			IntPtr value = IL2CPP.il2cpp_resolve_icall(string.Concat(new string[]
			{
				"UnityEngine",
				".",
				"PlayerPrefs",
				"::",
				string_2
			}));
			if (value == IntPtr.Zero)
			{
				GClass70.smethod_51("ICall " + string_2 + " was not found, not patching", GClass70.Enum1.const_0);
			}
			else
			{
				this.list_0.Add(gparam_0);
				MelonUtils.NativeHookAttach((IntPtr)((void*)(&value)), Marshal.GetFunctionPointerForDelegate<T>(gparam_0));
			}
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000F2C44 File Offset: 0x000F0E44
		public override void vmethod_23()
		{
			this.method_17();
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x000F2C58 File Offset: 0x000F0E58
		internal void method_17()
		{
			this.method_23();
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x000F2C6C File Offset: 0x000F0E6C
		public override void vmethod_8(int int_0)
		{
			this.method_19(int_0);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x000F2C80 File Offset: 0x000F0E80
		private bool method_18(IntPtr intptr_0)
		{
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			return this.concurrentDictionary_0.ContainsKey(key);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x000F2CA0 File Offset: 0x000F0EA0
		internal void method_19(int int_0)
		{
			this.method_13(int_0);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x000F2CB4 File Offset: 0x000F0EB4
		private void method_20(IntPtr intptr_0)
		{
			this.method_5(intptr_0);
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x000F2CC8 File Offset: 0x000F0EC8
		private bool method_21(IntPtr intptr_0, IntPtr intptr_1)
		{
			this.bool_0 = true;
			string key = IL2CPP.Il2CppStringToManaged(intptr_0);
			this.concurrentDictionary_0[key] = IL2CPP.Il2CppStringToManaged(intptr_1);
			return true;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x000F2CF8 File Offset: 0x000F0EF8
		private void method_22()
		{
			this.method_8();
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x000F2D0C File Offset: 0x000F0F0C
		internal void method_23()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			try
			{
				if (File.Exists(this.string_1))
				{
					ProxyObject proxyObject = (ProxyObject)JSON.Load(File.ReadAllText(this.string_1));
					foreach (KeyValuePair<string, Variant> keyValuePair in proxyObject)
					{
						this.concurrentDictionary_0[keyValuePair.Key] = this.method_14(keyValuePair.Key, keyValuePair.Value);
					}
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Loaded",
						" ",
						proxyObject.Count.ToString(),
						" ",
						"prefs",
						" ",
						"from",
						" ",
						"PlayerPrefs",
						".json"
					}), GClass70.Enum1.const_0);
				}
			}
			catch (Exception ex)
			{
				string[] array = new string[10];
				array[0] = "Unable";
				array[1] = " ";
				array[2] = "to";
				array[3] = " ";
				array[4] = "load";
				array[5] = " ";
				array[6] = "PlayerPrefs";
				array[7] = ".json";
				array[8] = ": ";
				int num = 9;
				Exception ex2 = ex;
				array[num] = ((ex2 != null) ? ex2.ToString() : null);
				GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
			}
			this.method_16<GClass166.Delegate37>("TrySetFloat", new GClass166.Delegate37(this.method_11));
			this.method_16<GClass166.Delegate38>("TrySetInt", new GClass166.Delegate38(this.method_12));
			this.method_16<GClass166.Delegate39>("TrySetSetString", new GClass166.Delegate39(this.method_21));
			this.method_16<GClass166.Delegate41>("GetFloat", new GClass166.Delegate41(this.method_6));
			this.method_16<GClass166.Delegate40>("GetInt", new GClass166.Delegate40(this.method_3));
			this.method_16<GClass166.Delegate42>("GetString", new GClass166.Delegate42(this.method_9));
			this.method_16<GClass166.Delegate43>("HasKey", new GClass166.Delegate43(this.method_18));
			this.method_16<GClass166.Delegate44>("DeleteKey", new GClass166.Delegate44(this.method_15));
			this.method_16<GClass166.Delegate45>("DeleteAll", new GClass166.Delegate45(this.method_4));
			this.method_16<GClass166.Delegate45>("Save", new GClass166.Delegate45(this.method_10));
		}

		// Token: 0x040018D7 RID: 6359
		private string string_1 = "UserData/PlayerPrefs.json";

		// Token: 0x040018D8 RID: 6360
		private readonly List<Delegate> list_0 = new List<Delegate>();

		// Token: 0x040018D9 RID: 6361
		private readonly ConcurrentDictionary<string, object> concurrentDictionary_0 = new ConcurrentDictionary<string, object>();

		// Token: 0x040018DA RID: 6362
		private bool bool_0;

		// Token: 0x040018DB RID: 6363
		private readonly object object_0 = new object();

		// Token: 0x020002F7 RID: 759
		// (Invoke) Token: 0x0600402D RID: 16429
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool Delegate37(IntPtr intptr_0, float float_0);

		// Token: 0x020002F8 RID: 760
		// (Invoke) Token: 0x06004030 RID: 16432
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool Delegate38(IntPtr intptr_0, int int_0);

		// Token: 0x020002F9 RID: 761
		// (Invoke) Token: 0x06004034 RID: 16436
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool Delegate39(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x020002FA RID: 762
		// (Invoke) Token: 0x06004038 RID: 16440
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate40(IntPtr intptr_0, int int_0);

		// Token: 0x020002FB RID: 763
		// (Invoke) Token: 0x0600403B RID: 16443
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate float Delegate41(IntPtr intptr_0, float float_0);

		// Token: 0x020002FC RID: 764
		// (Invoke) Token: 0x0600403F RID: 16447
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate42(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x020002FD RID: 765
		// (Invoke) Token: 0x06004045 RID: 16453
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool Delegate43(IntPtr intptr_0);

		// Token: 0x020002FE RID: 766
		// (Invoke) Token: 0x06004048 RID: 16456
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate44(IntPtr intptr_0);

		// Token: 0x020002FF RID: 767
		// (Invoke) Token: 0x0600404C RID: 16460
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate45();
	}
}
