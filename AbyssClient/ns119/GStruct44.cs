using System;
using System.Runtime.InteropServices;

namespace ns119
{
	// Token: 0x020000BC RID: 188
	public struct GStruct44
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x0001915C File Offset: 0x0001735C
		private GStruct44(string string_2, string string_3)
		{
			this.string_0 = string_2;
			this.string_1 = string_3;
		}

		// Token: 0x040004C2 RID: 1218
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		// Token: 0x040004C3 RID: 1219
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_1;
	}
}
