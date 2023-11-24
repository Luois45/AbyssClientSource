using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;
using ns54;

namespace ns395
{
	// Token: 0x02000302 RID: 770
	[Attribute2(4703)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct247
	{
		// Token: 0x040018DF RID: 6367
		public const int int_0 = 4703;

		// Token: 0x040018E0 RID: 6368
		public GEnum54 genum54_0;

		// Token: 0x040018E1 RID: 6369
		public GStruct22 gstruct22_0;

		// Token: 0x040018E2 RID: 6370
		public int int_1;

		// Token: 0x040018E3 RID: 6371
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
