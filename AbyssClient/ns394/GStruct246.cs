using System;
using System.Runtime.InteropServices;
using ns417;

namespace ns394
{
	// Token: 0x02000301 RID: 769
	[Attribute2(332)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct246
	{
		// Token: 0x040018DC RID: 6364
		public const int int_0 = 332;

		// Token: 0x040018DD RID: 6365
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string string_0;

		// Token: 0x040018DE RID: 6366
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string string_1;
	}
}
