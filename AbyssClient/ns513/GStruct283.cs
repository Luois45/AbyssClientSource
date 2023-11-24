using System;
using System.Runtime.InteropServices;
using ns151;
using ns417;

namespace ns513
{
	// Token: 0x02000379 RID: 889
	[Attribute2(1303)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct283
	{
		// Token: 0x04001C3F RID: 7231
		public const int int_0 = 1303;

		// Token: 0x04001C40 RID: 7232
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04001C41 RID: 7233
		public GStruct66 gstruct66_0;

		// Token: 0x04001C42 RID: 7234
		public uint uint_0;

		// Token: 0x04001C43 RID: 7235
		public double double_0;

		// Token: 0x04001C44 RID: 7236
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
