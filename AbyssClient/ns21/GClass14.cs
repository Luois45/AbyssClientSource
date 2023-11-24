using System;
using System.Reflection;

namespace ns21
{
	// Token: 0x02000019 RID: 25
	public class GClass14
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00004F44 File Offset: 0x00003144
		internal void method_0()
		{
			this.method_1();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004F58 File Offset: 0x00003158
		internal void method_1()
		{
			this.method_2();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004F6C File Offset: 0x0000316C
		internal void method_2()
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
				this.method_0();
			}
		}
	}
}
