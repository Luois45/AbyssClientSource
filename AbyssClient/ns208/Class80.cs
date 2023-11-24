using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using HarmonyLib;
using MelonLoader;
using ns356;
using ns38;
using UnhollowerBaseLib;

namespace ns208
{
	// Token: 0x0200014E RID: 334
	[Attribute0(1)]
	[Attribute1(0)]
	internal static class Class80
	{
		// Token: 0x06000B9C RID: 2972 RVA: 0x000322F4 File Offset: 0x000304F4
		internal static void smethod_0<[Attribute1(0)] T>(MethodInfo methodInfo_0, out T gparam_0, MethodInfo methodInfo_1) where T : MulticastDelegate
		{
			T gparam_ = (T)((object)Delegate.CreateDelegate(typeof(T), methodInfo_1));
			Class80.smethod_5<T>(methodInfo_0, out gparam_0, gparam_);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00032320 File Offset: 0x00030520
		internal unsafe static void smethod_1<[Attribute1(0)] T>(IntPtr intptr_0, out T gparam_0, T gparam_1, [Attribute1(2)] string string_0 = null) where T : MulticastDelegate
		{
			Class80.list_0.Add(gparam_1);
			IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate<T>(gparam_1);
			MelonUtils.NativeHookAttach((IntPtr)((void*)(&intptr_0)), functionPointerForDelegate);
			Class80.dictionary_0[intptr_0] = functionPointerForDelegate;
			gparam_0 = Marshal.GetDelegateForFunctionPointer<T>(intptr_0);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0003236C File Offset: 0x0003056C
		internal static void smethod_2()
		{
			Class80.smethod_3();
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00032380 File Offset: 0x00030580
		internal static void smethod_3()
		{
			Class80.smethod_6();
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00032394 File Offset: 0x00030594
		internal static void smethod_4<[Attribute1(0)] T>(IntPtr intptr_0, out T gparam_0, MethodInfo methodInfo_0, [Attribute1(2)] string string_0 = null) where T : MulticastDelegate
		{
			T gparam_ = (T)((object)Delegate.CreateDelegate(typeof(T), methodInfo_0));
			Class80.smethod_1<T>(intptr_0, out gparam_0, gparam_, string_0);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000323C0 File Offset: 0x000305C0
		internal unsafe static void smethod_5<[Attribute1(0)] T>(MethodInfo methodInfo_0, out T gparam_0, T gparam_1) where T : MulticastDelegate
		{
			if (methodInfo_0 == null)
			{
				throw new ArgumentNullException("original");
			}
			IntPtr intptr_ = *(IntPtr*)((void*)((IntPtr)UnhollowerUtils.GetIl2CppMethodInfoPointerFieldForGeneratedMethod(methodInfo_0).GetValue(null)));
			Class80.smethod_1<T>(intptr_, out gparam_0, gparam_1, GeneralExtensions.FullDescription(methodInfo_0));
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00032408 File Offset: 0x00030608
		internal unsafe static void smethod_6()
		{
			foreach (KeyValuePair<IntPtr, IntPtr> keyValuePair in Class80.dictionary_0)
			{
				IntPtr key = keyValuePair.Key;
				MelonUtils.NativeHookDetach((IntPtr)((void*)(&key)), keyValuePair.Value);
			}
			Class80.dictionary_0.Clear();
			Class80.list_0.Clear();
		}

		// Token: 0x04000904 RID: 2308
		private static readonly List<Delegate> list_0 = new List<Delegate>();

		// Token: 0x04000905 RID: 2309
		private static readonly Dictionary<IntPtr, IntPtr> dictionary_0 = new Dictionary<IntPtr, IntPtr>();

		// Token: 0x0200014F RID: 335
		[Attribute0(0)]
		internal struct Struct2
		{
			// Token: 0x04000906 RID: 2310
			public IntPtr intptr_0;

			// Token: 0x04000907 RID: 2311
			public long long_0;

			// Token: 0x04000908 RID: 2312
			public long long_1;

			// Token: 0x04000909 RID: 2313
			public long long_2;

			// Token: 0x0400090A RID: 2314
			public int int_0;
		}
	}
}
