using System;
using System.Diagnostics;

namespace ns393
{
	// Token: 0x02000300 RID: 768
	public static class GClass120
	{
		// Token: 0x0600404F RID: 16463 RVA: 0x000F2F84 File Offset: 0x000F1184
		internal static void smethod_0()
		{
			GClass120.smethod_3();
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x000F2F98 File Offset: 0x000F1198
		internal static bool smethod_1()
		{
			return Process.GetCurrentProcess() != null;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x000F2FB0 File Offset: 0x000F11B0
		internal static void smethod_2()
		{
			GClass120.smethod_0();
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x000F2FC4 File Offset: 0x000F11C4
		internal static void smethod_3()
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
