using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns136
{
	// Token: 0x020000D5 RID: 213
	[Attribute2(209)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct55
	{
		// Token: 0x04000533 RID: 1331
		public const int int_0 = 209;

		// Token: 0x04000534 RID: 1332
		public GEnum54 genum54_0;

		// Token: 0x04000535 RID: 1333
		public uint uint_0;

		// Token: 0x04000536 RID: 1334
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x04000537 RID: 1335
		public uint uint_1;

		// Token: 0x04000538 RID: 1336
		public ushort ushort_0;

		// Token: 0x04000539 RID: 1337
		public ulong ulong_0;

		// Token: 0x0400053A RID: 1338
		public uint uint_2;
	}
}
