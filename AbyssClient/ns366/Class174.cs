using System;
using System.Runtime.InteropServices;
using ns307;

namespace ns366
{
	// Token: 0x020002CA RID: 714
	internal static class Class174
	{
		// Token: 0x060020B4 RID: 8372
		[DllImport("Comdlg32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool GetOpenFileName(ref Struct20 struct20_0);

		// Token: 0x060020B5 RID: 8373 RVA: 0x000A65B0 File Offset: 0x000A47B0
		internal static string smethod_0()
		{
			return Class174.smethod_1();
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000A65C4 File Offset: 0x000A47C4
		internal static string smethod_1()
		{
			return Class174.smethod_2();
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000A65D8 File Offset: 0x000A47D8
		internal static string smethod_2()
		{
			Struct20 @struct = default(Struct20);
			@struct.int_0 = Marshal.SizeOf<Struct20>();
			@struct.string_0 = "All files(*.*)\0\0";
			@struct.string_2 = new string(new char[256]);
			@struct.int_3 = @struct.string_2.Length;
			@struct.string_3 = new string(new char[64]);
			@struct.int_4 = @struct.string_3.Length;
			@struct.string_5 = "Open File Dialog...";
			string result;
			if (!Class174.GetOpenFileName(ref @struct))
			{
				result = string.Empty;
			}
			else
			{
				result = @struct.string_2;
			}
			return result;
		}
	}
}
