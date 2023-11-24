using System;
using System.Runtime.InteropServices;
using ns417;
using ns54;

namespace ns198
{
	// Token: 0x0200013F RID: 319
	[Attribute2(340)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct91
	{
		// Token: 0x040008B2 RID: 2226
		public const int int_0 = 340;

		// Token: 0x040008B3 RID: 2227
		public GStruct22 gstruct22_0;

		// Token: 0x040008B4 RID: 2228
		public GStruct22 gstruct22_1;

		// Token: 0x040008B5 RID: 2229
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x040008B6 RID: 2230
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_1;
	}
}
