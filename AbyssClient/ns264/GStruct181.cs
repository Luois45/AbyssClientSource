using System;
using System.Runtime.InteropServices;
using ns118;
using ns417;

namespace ns264
{
	// Token: 0x02000227 RID: 551
	[Attribute2(4503)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct181
	{
		// Token: 0x04000EBF RID: 3775
		public const int int_0 = 4503;

		// Token: 0x04000EC0 RID: 3776
		public GStruct43 gstruct43_0;

		// Token: 0x04000EC1 RID: 3777
		public string string_0;

		// Token: 0x04000EC2 RID: 3778
		public string string_1;

		// Token: 0x04000EC3 RID: 3779
		public string string_2;

		// Token: 0x04000EC4 RID: 3780
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;
	}
}
