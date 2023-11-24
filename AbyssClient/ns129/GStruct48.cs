using System;
using System.Runtime.InteropServices;
using ns333;
using ns417;

namespace ns129
{
	// Token: 0x020000C7 RID: 199
	[Attribute2(1109)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct48
	{
		// Token: 0x040004F8 RID: 1272
		public const int int_0 = 1109;

		// Token: 0x040004F9 RID: 1273
		public GStruct217 gstruct217_0;

		// Token: 0x040004FA RID: 1274
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		// Token: 0x040004FB RID: 1275
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x040004FC RID: 1276
		public int int_1;
	}
}
