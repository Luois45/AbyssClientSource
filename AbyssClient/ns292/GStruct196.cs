using System;
using System.Runtime.InteropServices;
using ns151;
using ns169;
using ns291;
using ns417;

namespace ns292
{
	// Token: 0x02000255 RID: 597
	[Attribute2(3416)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct196
	{
		// Token: 0x04001033 RID: 4147
		public const int int_0 = 3416;

		// Token: 0x04001034 RID: 4148
		public GEnum54 genum54_0;

		// Token: 0x04001035 RID: 4149
		public GStruct78 gstruct78_0;

		// Token: 0x04001036 RID: 4150
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public GStruct66[] gstruct66_0;

		// Token: 0x04001037 RID: 4151
		public uint uint_0;

		// Token: 0x04001038 RID: 4152
		public uint uint_1;
	}
}
