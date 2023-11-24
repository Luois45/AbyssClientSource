using System;
using System.Runtime.InteropServices;
using ns203;
using ns291;
using ns417;

namespace ns416
{
	// Token: 0x0200031E RID: 798
	[Attribute2(1307)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct258
	{
		// Token: 0x04001959 RID: 6489
		public const int int_0 = 1307;

		// Token: 0x0400195A RID: 6490
		public GEnum54 genum54_0;

		// Token: 0x0400195B RID: 6491
		public GStruct96 gstruct96_0;

		// Token: 0x0400195C RID: 6492
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;
	}
}
