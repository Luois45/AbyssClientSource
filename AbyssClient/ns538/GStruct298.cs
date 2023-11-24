using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;
using ns54;

namespace ns538
{
	// Token: 0x02000399 RID: 921
	[Attribute2(346)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GStruct298
	{
		// Token: 0x04001D1A RID: 7450
		public const int int_0 = 346;

		// Token: 0x04001D1B RID: 7451
		public GEnum54 genum54_0;

		// Token: 0x04001D1C RID: 7452
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct22[] gstruct22_0;

		// Token: 0x04001D1D RID: 7453
		public int int_1;

		// Token: 0x04001D1E RID: 7454
		public int int_2;
	}
}
