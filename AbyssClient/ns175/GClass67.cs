using System;
using System.Reflection;

namespace ns175
{
	// Token: 0x0200011D RID: 285
	public static class GClass67
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00028640 File Offset: 0x00026840
		internal static void smethod_0()
		{
			GClass67.smethod_1();
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00028654 File Offset: 0x00026854
		internal static void smethod_1()
		{
			GClass67.smethod_2();
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00028668 File Offset: 0x00026868
		internal static void smethod_2()
		{
			bool? flag = null;
			bool? flag2;
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				flag2 = flag;
				if (!flag2.GetValueOrDefault() & flag2 != null)
				{
					if (assembly.GetName().Name == "AbyssLoader_Step2")
					{
						flag = new bool?(true);
					}
				}
				else if (assembly.GetName().Name == "AbyssLoader")
				{
					flag = new bool?(false);
				}
			}
			flag2 = flag;
			if (!(flag2.GetValueOrDefault() & flag2 != null))
			{
				GClass67.smethod_0();
			}
		}
	}
}
