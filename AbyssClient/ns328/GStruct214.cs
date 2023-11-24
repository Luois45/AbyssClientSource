using System;
using System.Runtime.InteropServices;
using ns311;
using ns417;
using ns54;

namespace ns328
{
	// Token: 0x02000288 RID: 648
	[Attribute2(202)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct GStruct214
	{
		// Token: 0x040011AC RID: 4524
		public const int int_0 = 202;

		// Token: 0x040011AD RID: 4525
		public GStruct22 gstruct22_0;

		// Token: 0x040011AE RID: 4526
		public GEnum58 genum58_0;

		// Token: 0x040011AF RID: 4527
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;
	}
}
