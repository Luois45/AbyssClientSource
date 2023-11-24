using System;
using System.Runtime.InteropServices;
using ns417;
using ns54;

namespace ns206
{
	// Token: 0x0200014C RID: 332
	[Attribute2(337)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct98
	{
		// Token: 0x040008FA RID: 2298
		public const int int_0 = 337;

		// Token: 0x040008FB RID: 2299
		public GStruct22 gstruct22_0;

		// Token: 0x040008FC RID: 2300
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;
	}
}
