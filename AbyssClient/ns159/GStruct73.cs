using System;
using System.Runtime.InteropServices;
using ns417;

namespace ns159
{
	// Token: 0x02000108 RID: 264
	[Attribute2(206)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct73
	{
		// Token: 0x0400067B RID: 1659
		public const int int_0 = 206;

		// Token: 0x0400067C RID: 1660
		public ulong ulong_0;

		// Token: 0x0400067D RID: 1661
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		// Token: 0x0400067E RID: 1662
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
