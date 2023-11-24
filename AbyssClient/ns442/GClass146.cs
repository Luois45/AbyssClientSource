using System;
using ns241;
using ns425;
using VRC.Core;

namespace ns442
{
	// Token: 0x02000178 RID: 376
	public class GClass146 : GClass130
	{
		// Token: 0x06000E88 RID: 3720 RVA: 0x0004D4CC File Offset: 0x0004B6CC
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0004D4E0 File Offset: 0x0004B6E0
		internal void method_2()
		{
			this.method_5();
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0004D4F4 File Offset: 0x0004B6F4
		internal void method_3()
		{
			this.method_4();
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0004D508 File Offset: 0x0004B708
		public override void vmethod_10()
		{
			this.method_3();
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0004D51C File Offset: 0x0004B71C
		internal void method_4()
		{
			ApiWorld apiWorld = GClass84.smethod_1424();
			ApiWorldInstance apiWorldInstance = GClass84.smethod_813();
			if (apiWorld != null && apiWorldInstance != null && GClass84.gclass56_0 != null)
			{
				GClass84.gclass56_0.method_0(apiWorld, apiWorldInstance);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004D558 File Offset: 0x0004B758
		internal void method_5()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			if (GClass84.gclass56_0 != null)
			{
				GClass84.gclass56_0.method_9();
			}
		}
	}
}
