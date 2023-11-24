using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using ns185;
using ns241;
using ns382;

namespace ns190
{
	// Token: 0x02000131 RID: 305
	internal class Class74
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x0002D15C File Offset: 0x0002B35C
		internal static void smethod_0(bool bool_4, bool bool_5, string string_0, string string_1)
		{
			Class74.smethod_16(bool_4, bool_5, string_0, string_1);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0002D174 File Offset: 0x0002B374
		internal static void smethod_1()
		{
			Class74.smethod_10();
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002D188 File Offset: 0x0002B388
		internal static bool smethod_2()
		{
			return Class74.bool_1;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002D19C File Offset: 0x0002B39C
		[DebuggerStepThrough]
		internal static void smethod_3(string string_0)
		{
			Class74.smethod_13(string_0);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		internal static void smethod_4(byte byte_0, Action<byte, bool> action_0)
		{
			Class74.smethod_11(byte_0, action_0);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
		[DebuggerStepThrough]
		internal static void smethod_5()
		{
			Class74.smethod_1();
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
		private static void smethod_6(byte byte_0, Action<byte, bool> action_0)
		{
			Class74.smethod_8(byte_0, action_0);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002D1EC File Offset: 0x0002B3EC
		internal static void smethod_7(string string_0)
		{
			Class74.Class78 @class = new Class74.Class78();
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.string_0 = string_0;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0.Start<Class74.Class78>(ref @class);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002D228 File Offset: 0x0002B428
		private static void smethod_8(byte byte_0, Action<byte, bool> action_0)
		{
			Class74.Class77 @class = new Class74.Class77();
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.byte_0 = byte_0;
			@class.action_0 = action_0;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0.Start<Class74.Class77>(ref @class);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002D268 File Offset: 0x0002B468
		internal static void smethod_9(bool bool_4, bool bool_5, string string_0, string string_1)
		{
			Class74.smethod_0(bool_4, bool_5, string_0, string_1);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002D280 File Offset: 0x0002B480
		internal static void smethod_10()
		{
			Class74.Class76 @class = new Class74.Class76();
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0.Start<Class74.Class76>(ref @class);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
		internal static void smethod_11(byte byte_0, Action<byte, bool> action_0)
		{
			if (Class74.bool_1)
			{
				Class74.smethod_15(byte_0, action_0);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		internal static void smethod_12(byte byte_0, Action<byte, bool> action_0 = null)
		{
			Class74.smethod_4(byte_0, action_0);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002D338 File Offset: 0x0002B538
		internal static void smethod_13(string string_0)
		{
			Class74.smethod_7(string_0);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002D34C File Offset: 0x0002B54C
		private static IEnumerator smethod_14()
		{
			return new Class74.Class79(0);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002D360 File Offset: 0x0002B560
		[DebuggerStepThrough]
		private static void smethod_15(byte byte_0, Action<byte, bool> action_0 = null)
		{
			Class74.smethod_6(byte_0, action_0);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002D374 File Offset: 0x0002B574
		internal static void smethod_16(bool bool_4, bool bool_5, string string_0, string string_1)
		{
			Class74.bool_0 = bool_4;
			Class74.bool_1 = bool_5;
			ConcurrentQueue<GClass84.Class99> concurrentQueue_ = GClass84.concurrentQueue_0;
			GClass84.Class99 @class = new GClass84.Class99();
			@class.action_0 = new Action(Class74.Class75.class75_0.method_2);
			@class.enum4_0 = GClass84.Enum4.const_3;
			concurrentQueue_.Enqueue(@class);
			GClass70.smethod_9(ConsoleColor.Red, "Lovense", string_0, GClass70.Enum1.const_8);
		}

		// Token: 0x0400079C RID: 1948
		private static readonly HttpClient httpClient_0 = new HttpClient();

		// Token: 0x0400079D RID: 1949
		private static readonly Class181 class181_0 = new Class181();

		// Token: 0x0400079E RID: 1950
		private static bool bool_0 = false;

		// Token: 0x0400079F RID: 1951
		private static bool bool_1 = false;

		// Token: 0x040007A0 RID: 1952
		private static bool bool_2 = false;

		// Token: 0x040007A1 RID: 1953
		private static float float_0 = 0f;

		// Token: 0x040007A2 RID: 1954
		private static bool bool_3 = false;

		// Token: 0x040007A3 RID: 1955
		private static float float_1 = 0f;

		// Token: 0x02000132 RID: 306
		[CompilerGenerated]
		[Serializable]
		private sealed class Class75
		{
			// Token: 0x06000B17 RID: 2839 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_0()
			{
			}

			// Token: 0x06000B18 RID: 2840 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_1()
			{
			}

			// Token: 0x06000B1B RID: 2843 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_2()
			{
			}

			// Token: 0x06000B1C RID: 2844 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_3()
			{
			}

			// Token: 0x040007A4 RID: 1956
			public static readonly Class74.Class75 class75_0 = new Class74.Class75();

			// Token: 0x040007A5 RID: 1957
			public static Action action_0;

			// Token: 0x040007A6 RID: 1958
			public static Action action_1;

			// Token: 0x040007A7 RID: 1959
			public static Action action_2;

			// Token: 0x040007A8 RID: 1960
			public static Action action_3;
		}
	}
}
