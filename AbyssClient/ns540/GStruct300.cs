using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns540
{
	// Token: 0x0200039B RID: 923
	[Attribute2(102)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct300
	{
		// Token: 0x04001D26 RID: 7462
		public const int int_0 = 102;

		// Token: 0x04001D27 RID: 7463
		public GEnum54 genum54_0;

		// Token: 0x04001D28 RID: 7464
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
