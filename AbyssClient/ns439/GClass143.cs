using System;
using System.Reflection;
using ns241;
using ns425;

namespace ns439
{
	// Token: 0x02000139 RID: 313
	public class GClass143 : GClass130
	{
		// Token: 0x06000B28 RID: 2856 RVA: 0x0002E4F4 File Offset: 0x0002C6F4
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002E508 File Offset: 0x0002C708
		internal void method_2()
		{
			this.method_3();
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0002E51C File Offset: 0x0002C71C
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
				GClass84.gclass93_0.method_190();
			}
			else
			{
				GClass84.bool_5 = true;
			}
		}
	}
}
