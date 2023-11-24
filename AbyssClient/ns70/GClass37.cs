using System;
using System.Diagnostics;
using ns325;

namespace ns70
{
	// Token: 0x0200004D RID: 77
	public sealed class GClass37 : IDisposable
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000081C4 File Offset: 0x000063C4
		public int? method_0(TimeSpan timeSpan_0)
		{
			return this.gclass104_0.method_2(timeSpan_0);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000081E0 File Offset: 0x000063E0
		internal void method_1()
		{
			this.method_2();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000081F4 File Offset: 0x000063F4
		public void Dispose()
		{
			this.method_1();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008208 File Offset: 0x00006408
		public GClass37(string string_0, string string_1, TimeSpan timeSpan_0, ulong ulong_0, int int_0, int int_1)
		{
			int id = Process.GetCurrentProcess().Id;
			this.gclass104_0 = new GClass104(string_0, string.Format("-batchmode -nolog -nographics {0} {1} {2} {3}", new object[]
			{
				int_1,
				id,
				string_1,
				int_0
			}));
			this.gclass104_0.method_5(new TimeSpan?(timeSpan_0), new ulong?(ulong_0), false, false, false);
			this.gclass104_0.method_4();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000828C File Offset: 0x0000648C
		internal void method_2()
		{
			this.gclass104_0.Dispose();
		}

		// Token: 0x0400012D RID: 301
		private readonly GClass104 gclass104_0;
	}
}
