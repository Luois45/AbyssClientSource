using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

namespace ns493
{
	// Token: 0x02000356 RID: 854
	internal class Class203
	{
		// Token: 0x0600475D RID: 18269 RVA: 0x0010E620 File Offset: 0x0010C820
		internal static void smethod_0(string string_0, MethodBase methodBase_0, HarmonyMethod harmonyMethod_0, HarmonyMethod harmonyMethod_1, HarmonyMethod harmonyMethod_2)
		{
			Class203.smethod_3(string_0, methodBase_0, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x0010E63C File Offset: 0x0010C83C
		internal static bool smethod_1(string string_0, MethodBase methodBase_0, MethodInfo methodInfo_0)
		{
			bool result;
			if (Class203.dictionary_0.ContainsKey(string_0))
			{
				Class203.dictionary_0[string_0].Unpatch(methodBase_0, methodInfo_0);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x0010E670 File Offset: 0x0010C870
		internal static void smethod_2(string string_0, MethodBase methodBase_0, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			Class203.smethod_0(string_0, methodBase_0, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x0010E6A4 File Offset: 0x0010C8A4
		internal static void smethod_3(string string_0, MethodBase methodBase_0, HarmonyMethod harmonyMethod_0, HarmonyMethod harmonyMethod_1, HarmonyMethod harmonyMethod_2)
		{
			if (!Class203.dictionary_0.ContainsKey(string_0))
			{
				Class203.dictionary_0.Add(string_0, new Harmony(string_0));
			}
			Class203.dictionary_0[string_0].Patch(methodBase_0, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2, null, null);
		}

		// Token: 0x04001BA6 RID: 7078
		internal static Dictionary<string, Harmony> dictionary_0 = new Dictionary<string, Harmony>();
	}
}
