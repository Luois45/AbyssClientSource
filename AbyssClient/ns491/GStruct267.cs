using System;
using System.Runtime.InteropServices;
using ns169;
using ns288;
using ns291;
using ns417;

namespace ns491
{
	// Token: 0x02000354 RID: 852
	[Attribute2(1328)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct267
	{
		// Token: 0x04001B9C RID: 7068
		public const int int_0 = 1328;

		// Token: 0x04001B9D RID: 7069
		public GEnum54 genum54_0;

		// Token: 0x04001B9E RID: 7070
		public GEnum53 genum53_0;

		// Token: 0x04001B9F RID: 7071
		public int int_1;

		// Token: 0x04001BA0 RID: 7072
		public int int_2;

		// Token: 0x04001BA1 RID: 7073
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct78[] gstruct78_0;

		// Token: 0x04001BA2 RID: 7074
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] uint_0;
	}
}
