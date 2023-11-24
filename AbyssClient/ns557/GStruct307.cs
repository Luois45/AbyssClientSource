using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns557
{
	// Token: 0x020003B5 RID: 949
	[Attribute2(347)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct307
	{
		// Token: 0x04001DB9 RID: 7609
		public const int int_0 = 347;

		// Token: 0x04001DBA RID: 7610
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x04001DBB RID: 7611
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_1;

		// Token: 0x04001DBC RID: 7612
		public GEnum54 genum54_0;
	}
}
