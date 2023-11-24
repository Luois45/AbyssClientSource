using System;
using System.Runtime.InteropServices;
using ns169;
using ns291;
using ns417;

namespace ns240
{
	// Token: 0x020001BF RID: 447
	[Attribute2(1326)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct130
	{
		// Token: 0x04000C52 RID: 3154
		public const int int_0 = 1326;

		// Token: 0x04000C53 RID: 3155
		public GEnum54 genum54_0;

		// Token: 0x04000C54 RID: 3156
		public int int_1;

		// Token: 0x04000C55 RID: 3157
		public int int_2;

		// Token: 0x04000C56 RID: 3158
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct78[] gstruct78_0;
	}
}
