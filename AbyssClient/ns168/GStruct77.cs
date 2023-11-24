using System;
using System.Runtime.InteropServices;
using ns169;
using ns291;
using ns417;

namespace ns168
{
	// Token: 0x02000112 RID: 274
	[Attribute2(1314)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct77
	{
		// Token: 0x040006A2 RID: 1698
		public const int int_0 = 1314;

		// Token: 0x040006A3 RID: 1699
		public GEnum54 genum54_0;

		// Token: 0x040006A4 RID: 1700
		public int int_1;

		// Token: 0x040006A5 RID: 1701
		public int int_2;

		// Token: 0x040006A6 RID: 1702
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct78[] gstruct78_0;

		// Token: 0x040006A7 RID: 1703
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] uint_0;
	}
}
