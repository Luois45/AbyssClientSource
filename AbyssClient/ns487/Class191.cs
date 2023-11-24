using System;
using System.Collections.Generic;
using ns245;

namespace ns487
{
	// Token: 0x02000342 RID: 834
	internal static class Class191
	{
		// Token: 0x060046FA RID: 18170 RVA: 0x0010A0BC File Offset: 0x001082BC
		internal static void smethod_0<T>(List<T> list_0, T gparam_0) where T : Class128
		{
			if (list_0 != null && gparam_0 != null)
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					if (Class191.smethod_1<T>(list_0[i], gparam_0))
					{
						list_0[i] = gparam_0;
						return;
					}
				}
				list_0.Add(gparam_0);
			}
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x0010A110 File Offset: 0x00108310
		internal static bool smethod_1<T>(T gparam_0, T gparam_1) where T : Class128
		{
			bool result;
			if (gparam_0 == null)
			{
				result = (gparam_1 == null);
			}
			else
			{
				result = (gparam_0.vmethod_0() == gparam_1.vmethod_0());
			}
			return result;
		}
	}
}
