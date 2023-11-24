using System;
using System.Reflection;
using ns241;
using ns425;

namespace ns465
{
	// Token: 0x02000318 RID: 792
	public class GClass168 : GClass130
	{
		// Token: 0x060040DD RID: 16605 RVA: 0x000F6770 File Offset: 0x000F4970
		internal void method_2()
		{
			this.method_3();
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x000F6784 File Offset: 0x000F4984
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x000F6798 File Offset: 0x000F4998
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
				for (int j = 0; j < 10; j--)
				{
					GClass84.gclass93_0.method_69();
				}
			}
			else
			{
				GClass84.bool_6 = true;
			}
		}
	}
}
