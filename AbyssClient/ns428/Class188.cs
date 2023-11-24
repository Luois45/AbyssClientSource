using System;
using System.Reflection;
using ns241;
using ns347;
using ns425;

namespace ns428
{
	// Token: 0x02000048 RID: 72
	internal class Class188 : GClass130
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00008078 File Offset: 0x00006278
		internal void method_2()
		{
			this.method_3();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000808C File Offset: 0x0000628C
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000080A0 File Offset: 0x000062A0
		internal void method_3()
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
				GClass110.smethod_2();
			}
			else
			{
				GClass84.bool_2 = true;
			}
		}
	}
}
