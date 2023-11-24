using System;
using System.Runtime.InteropServices;
using ns169;
using ns291;
using ns417;

namespace ns221
{
	// Token: 0x0200019B RID: 411
	[Attribute2(1312)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct119
	{
		// Token: 0x04000B97 RID: 2967
		public const int int_0 = 1312;

		// Token: 0x04000B98 RID: 2968
		public GEnum54 genum54_0;

		// Token: 0x04000B99 RID: 2969
		public int int_1;

		// Token: 0x04000B9A RID: 2970
		public int int_2;

		// Token: 0x04000B9B RID: 2971
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct78[] gstruct78_0;
	}
}
