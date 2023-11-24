using System;
using System.Reflection;

namespace ns368
{
	// Token: 0x020002D8 RID: 728
	public class GClass116
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x000AD5EC File Offset: 0x000AB7EC
		internal void method_0()
		{
			this.method_1();
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000AD600 File Offset: 0x000AB800
		internal void method_1()
		{
			this.method_2();
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000AD614 File Offset: 0x000AB814
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
