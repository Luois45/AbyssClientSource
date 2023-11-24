using System;
using System.Runtime.InteropServices;
using ns417;

namespace ns148
{
	// Token: 0x020000E1 RID: 225
	[Attribute2(165)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct64
	{
		// Token: 0x04000587 RID: 1415
		public const int int_0 = 165;

		// Token: 0x04000588 RID: 1416
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string string_0;
	}
}
