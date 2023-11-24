using System;
using System.Runtime.InteropServices;
using ns417;

namespace ns543
{
	// Token: 0x0200039F RID: 927
	[Attribute2(1103)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct302
	{
		// Token: 0x04001D44 RID: 7492
		public const int int_0 = 1103;

		// Token: 0x04001D45 RID: 7493
		public ulong ulong_0;

		// Token: 0x04001D46 RID: 7494
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x04001D47 RID: 7495
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		// Token: 0x04001D48 RID: 7496
		public uint uint_0;

		// Token: 0x04001D49 RID: 7497
		public uint uint_1;
	}
}
