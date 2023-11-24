using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;
using ns54;

namespace ns287
{
	// Token: 0x0200024F RID: 591
	[Attribute2(345)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GStruct194
	{
		// Token: 0x04000FAF RID: 4015
		public const int int_0 = 345;

		// Token: 0x04000FB0 RID: 4016
		public GEnum54 genum54_0;

		// Token: 0x04000FB1 RID: 4017
		public GStruct22 gstruct22_0;

		// Token: 0x04000FB2 RID: 4018
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
