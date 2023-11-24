using System;
using System.Runtime.InteropServices;
using ns151;
using ns169;
using ns291;
using ns417;

namespace ns211
{
	// Token: 0x02000183 RID: 387
	[Attribute2(1319)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct GStruct107
	{
		// Token: 0x04000AD7 RID: 2775
		public const int int_0 = 1319;

		// Token: 0x04000AD8 RID: 2776
		public GEnum54 genum54_0;

		// Token: 0x04000AD9 RID: 2777
		public int int_1;

		// Token: 0x04000ADA RID: 2778
		public int int_2;

		// Token: 0x04000ADB RID: 2779
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public GStruct78[] gstruct78_0;

		// Token: 0x04000ADC RID: 2780
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public float[] float_0;

		// Token: 0x04000ADD RID: 2781
		public GStruct66 gstruct66_0;

		// Token: 0x04000ADE RID: 2782
		public uint uint_0;
	}
}
