using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using ns208;
using ns238;
using ns276;
using ns401;

namespace ns349
{
	// Token: 0x020002B6 RID: 694
	internal static class Class172
	{
		// Token: 0x06002012 RID: 8210 RVA: 0x000A4E70 File Offset: 0x000A3070
		internal static void smethod_0(Class184 class184_0)
		{
			Class172.smethod_13(class184_0);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000A4E84 File Offset: 0x000A3084
		internal static IntPtr smethod_1(IntPtr intptr_0, long long_0)
		{
			Class172.smethod_11(intptr_0);
			return Class96.smethod_10(intptr_0, long_0);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000A4EA0 File Offset: 0x000A30A0
		internal static void smethod_2(IntPtr intptr_0)
		{
			Class172.smethod_12(intptr_0);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000A4EB4 File Offset: 0x000A30B4
		internal unsafe static int smethod_3(IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			Class184 @class;
			int result;
			if (!Class172.concurrentDictionary_0.TryGetValue(intptr_0, out @class))
			{
				result = Class96.smethod_5(intptr_0, intptr_1, int_0);
			}
			else if (!@class.method_9())
			{
				Class172.smethod_11(intptr_0);
				result = Class96.smethod_5(intptr_0, intptr_1, int_0);
			}
			else
			{
				if (Class172.byte_0 == null || Class172.byte_0.Length < int_0)
				{
					Class172.byte_0 = new byte[int_0];
				}
				Marshal.Copy(intptr_1, Class172.byte_0, 0, int_0);
				int num = @class.method_0(Class172.byte_0, 0, int_0);
				IntPtr intPtr = *(IntPtr*)((void*)(intptr_0 + 128));
				if (intPtr != IntPtr.Zero)
				{
					*(long*)((void*)(intptr_0 + 64)) = @class.method_7();
					*(float*)((void*)(intPtr + 1072)) = (float)@class.method_7() / (float)Class172.smethod_9(intptr_0);
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		internal unsafe static void smethod_4(IntPtr intptr_0, Class80.Struct2* pStruct2_0)
		{
			Class172.smethod_15(intptr_0, pStruct2_0);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000A4FCC File Offset: 0x000A31CC
		internal static int smethod_5(IntPtr intptr_0)
		{
			Class184 @class;
			int result;
			if (Class172.concurrentDictionary_0.TryGetValue(intptr_0, out @class) && @class.bool_0)
			{
				GClass92.smethod_7(@class.string_0);
				Marshal.WriteInt32(intptr_0 + 144, 1);
				result = 1;
			}
			else
			{
				result = Class96.smethod_0(intptr_0);
			}
			return result;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000A501C File Offset: 0x000A321C
		private static void smethod_6(IntPtr intptr_0)
		{
			Class184 @class;
			if (Class172.concurrentDictionary_0.TryRemove(intptr_0, out @class))
			{
				@class.Dispose();
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000A5040 File Offset: 0x000A3240
		internal static void smethod_7(IntPtr intptr_0)
		{
			Class184 @class;
			if (Class172.concurrentDictionary_0.TryGetValue(intptr_0, out @class))
			{
				@class.method_3();
			}
			else
			{
				Class96.smethod_8(intptr_0);
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000A506C File Offset: 0x000A326C
		internal static void smethod_8(Class184 class184_0)
		{
			Class172.smethod_0(class184_0);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000A5080 File Offset: 0x000A3280
		internal unsafe static int smethod_9(IntPtr intptr_0)
		{
			return *(int*)((void*)(intptr_0 + 72));
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000A509C File Offset: 0x000A329C
		internal unsafe static void smethod_10(IntPtr intptr_0, Class80.Struct2* pStruct2_0)
		{
			Class172.smethod_4(intptr_0, pStruct2_0);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000A50B0 File Offset: 0x000A32B0
		private static void smethod_11(IntPtr intptr_0)
		{
			Class172.smethod_14(intptr_0);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000A50C4 File Offset: 0x000A32C4
		internal static void smethod_12(IntPtr intptr_0)
		{
			Class172.smethod_7(intptr_0);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000A50D8 File Offset: 0x000A32D8
		internal static void smethod_13(Class184 class184_0)
		{
			Class172.smethod_11(class184_0.intptr_0);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x000A50F0 File Offset: 0x000A32F0
		private static void smethod_14(IntPtr intptr_0)
		{
			Class172.smethod_6(intptr_0);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000A5104 File Offset: 0x000A3304
		internal unsafe static void smethod_15(IntPtr intptr_0, Class80.Struct2* pStruct2_0)
		{
			if (Class172.bool_0)
			{
				string text = Class96.smethod_1(pStruct2_0);
				GClass92.smethod_7(text);
				if (!GClass92.gclass125_1.method_4(text))
				{
					Class172.concurrentDictionary_0[intptr_0] = new Class184(intptr_0, text);
				}
			}
		}

		// Token: 0x0400128E RID: 4750
		internal static volatile bool bool_0 = false;

		// Token: 0x0400128F RID: 4751
		private static readonly ConcurrentDictionary<IntPtr, Class184> concurrentDictionary_0 = new ConcurrentDictionary<IntPtr, Class184>();

		// Token: 0x04001290 RID: 4752
		[ThreadStatic]
		private static byte[] byte_0;
	}
}
