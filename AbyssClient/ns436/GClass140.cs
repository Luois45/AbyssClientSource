using System;
using ns241;
using ns425;
using ns452;
using ns464;

namespace ns436
{
	// Token: 0x0200010D RID: 269
	public class GClass140 : GClass130
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00022710 File Offset: 0x00020910
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00022724 File Offset: 0x00020924
		internal void method_2()
		{
			this.method_3();
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00022738 File Offset: 0x00020938
		internal void method_3()
		{
			this.gclass156_0 = new GClass156();
			this.vmethod_4(this.gclass156_0);
			GClass84.gclass167_0 = new GClass167();
			this.vmethod_4(GClass84.gclass167_0);
		}

		// Token: 0x04000698 RID: 1688
		public GClass156 gclass156_0;
	}
}
