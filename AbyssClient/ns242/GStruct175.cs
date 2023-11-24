using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns242
{
	// Token: 0x02000218 RID: 536
	[Attribute2(4705)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct175
	{
		// Token: 0x04000E5F RID: 3679
		public const int int_0 = 4705;

		// Token: 0x04000E60 RID: 3680
		public GEnum54 genum54_0;

		// Token: 0x04000E61 RID: 3681
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string string_0;
	}
}
