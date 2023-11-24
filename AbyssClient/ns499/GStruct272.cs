using System;
using System.Runtime.InteropServices;
using ns417;
using ns54;

namespace ns499
{
	// Token: 0x02000362 RID: 866
	[Attribute2(208)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct272
	{
		// Token: 0x04001BD7 RID: 7127
		public const int int_0 = 208;

		// Token: 0x04001BD8 RID: 7128
		public GStruct22 gstruct22_0;

		// Token: 0x04001BD9 RID: 7129
		public GStruct22 gstruct22_1;

		// Token: 0x04001BDA RID: 7130
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x04001BDB RID: 7131
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_1;
	}
}
