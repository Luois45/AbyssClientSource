using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;
using ns54;

namespace ns204
{
	// Token: 0x0200014A RID: 330
	[Attribute2(1101)]
	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	public struct GStruct97
	{
		// Token: 0x040008E8 RID: 2280
		public const int int_0 = 1101;

		// Token: 0x040008E9 RID: 2281
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040008EA RID: 2282
		[FieldOffset(8)]
		public GEnum54 genum54_0;

		// Token: 0x040008EB RID: 2283
		[FieldOffset(12)]
		public GStruct22 gstruct22_0;
	}
}
