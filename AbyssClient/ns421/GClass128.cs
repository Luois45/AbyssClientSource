using System;
using System.IO;
using UnityEngine;

namespace ns421
{
	// Token: 0x02000333 RID: 819
	public static class GClass128
	{
		// Token: 0x06004672 RID: 18034 RVA: 0x001080A4 File Offset: 0x001062A4
		internal static void smethod_0()
		{
			GClass128.smethod_1();
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x001080B8 File Offset: 0x001062B8
		internal static void smethod_1()
		{
			GClass128.smethod_2();
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x001080CC File Offset: 0x001062CC
		internal static void smethod_2()
		{
			if (!Directory.Exists("AbyssKey"))
			{
				Application.ForceCrash(0);
			}
		}
	}
}
