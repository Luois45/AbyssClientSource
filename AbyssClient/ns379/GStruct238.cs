using System;
using System.Runtime.InteropServices;
using ns291;
using ns417;

namespace ns379
{
	// Token: 0x020002E5 RID: 741
	[Attribute2(1023)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct238
	{
		// Token: 0x04001855 RID: 6229
		public const int int_0 = 1023;

		// Token: 0x04001856 RID: 6230
		public GEnum54 genum54_0;

		// Token: 0x04001857 RID: 6231
		public ulong ulong_0;

		// Token: 0x04001858 RID: 6232
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] byte_0;

		// Token: 0x04001859 RID: 6233
		public uint uint_0;
	}
}
