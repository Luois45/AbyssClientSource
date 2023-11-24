using System;
using System.Runtime.InteropServices;
using ns118;
using ns417;

namespace ns135
{
	// Token: 0x020000CE RID: 206
	[Attribute2(4512)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct51
	{
		// Token: 0x04000507 RID: 1287
		public const int int_0 = 4512;

		// Token: 0x04000508 RID: 1288
		public GStruct43 gstruct43_0;

		// Token: 0x04000509 RID: 1289
		public uint uint_0;

		// Token: 0x0400050A RID: 1290
		public uint uint_1;

		// Token: 0x0400050B RID: 1291
		public float float_0;

		// Token: 0x0400050C RID: 1292
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x0400050D RID: 1293
		public uint uint_2;
	}
}
