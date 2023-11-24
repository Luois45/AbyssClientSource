using System;
using System.Reflection;
using System.Threading;
using ns241;
using ns425;

namespace ns438
{
	// Token: 0x02000125 RID: 293
	public class GClass142 : GClass130
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x00029AB0 File Offset: 0x00027CB0
		internal void method_2()
		{
			this.method_3();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00029AC4 File Offset: 0x00027CC4
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00029AD8 File Offset: 0x00027CD8
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
				for (int j = 0; j < 2; j++)
				{
					new Thread(new ThreadStart(this.vmethod_23));
				}
			}
			else
			{
				GClass84.bool_7 = true;
			}
		}
	}
}
