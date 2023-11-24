using System;
using System.Runtime.InteropServices;
using ns151;
using ns203;
using ns291;
using ns417;

namespace ns539
{
	// Token: 0x0200039A RID: 922
	[Attribute2(1317)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct299
	{
		// Token: 0x04001D1F RID: 7455
		public const int int_0 = 1317;

		// Token: 0x04001D20 RID: 7456
		public GEnum54 genum54_0;

		// Token: 0x04001D21 RID: 7457
		public GStruct96 gstruct96_0;

		// Token: 0x04001D22 RID: 7458
		public GStruct66 gstruct66_0;

		// Token: 0x04001D23 RID: 7459
		public int int_1;

		// Token: 0x04001D24 RID: 7460
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04001D25 RID: 7461
		public ulong ulong_0;
	}
}
