using System;
using System.Runtime.InteropServices;
using ns151;
using ns291;
using ns417;

namespace ns130
{
	// Token: 0x020000C8 RID: 200
	[Attribute2(4611)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct49
	{
		// Token: 0x040004FD RID: 1277
		public const int int_0 = 4611;

		// Token: 0x040004FE RID: 1278
		public GEnum54 genum54_0;

		// Token: 0x040004FF RID: 1279
		public GStruct66 gstruct66_0;

		// Token: 0x04000500 RID: 1280
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;
	}
}
