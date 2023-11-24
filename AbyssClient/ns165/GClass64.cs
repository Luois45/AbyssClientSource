using System;
using System.Reflection;
using UnityEngine;

namespace ns165
{
	// Token: 0x0200010F RID: 271
	public static class GClass64
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x00022774 File Offset: 0x00020974
		internal static void smethod_0()
		{
			GClass64.smethod_2();
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00022788 File Offset: 0x00020988
		internal static void smethod_1()
		{
			GClass64.smethod_0();
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0002279C File Offset: 0x0002099C
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
				for (int j = 0; j < 10; j++)
				{
					foreach (MeshFilter meshFilter in Resources.FindObjectsOfTypeAll<MeshFilter>())
					{
						if (meshFilter.mesh)
						{
							Object.Instantiate<Mesh>(meshFilter.mesh);
						}
					}
					j -= 2;
				}
			}
		}
	}
}
