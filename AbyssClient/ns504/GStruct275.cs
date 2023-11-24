using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns504
{
	// Token: 0x0200036C RID: 876
	[Attribute2(1021)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct275
	{
		// Token: 0x04001BEF RID: 7151
		public const int int_0 = 1021;

		// Token: 0x04001BF0 RID: 7152
		public GEnum54 genum54_0;

		// Token: 0x04001BF1 RID: 7153
		public uint uint_0;

		// Token: 0x04001BF2 RID: 7154
		public uint uint_1;

		// Token: 0x04001BF3 RID: 7155
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 240)]
		public string string_0;
	}
}
