using System;
using ns466;
using ns468;
using ns473;

namespace ns471
{
	// Token: 0x0200012D RID: 301
	public class GClass174 : GClass169
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x0002CA70 File Offset: 0x0002AC70
		public override void vmethod_23()
		{
			this.method_8();
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0002CA84 File Offset: 0x0002AC84
		internal void method_8()
		{
			this.method_9();
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0002CA98 File Offset: 0x0002AC98
		internal void method_9()
		{
			this.gclass174_0 = this;
			if (this.bool_0)
			{
				this.gclass176_0 = new GClass176();
				this.vmethod_32(this.gclass176_0);
				this.gclass171_0 = new GClass171();
				this.vmethod_32(this.gclass171_0);
			}
		}

		// Token: 0x0400078A RID: 1930
		internal bool bool_0 = false;

		// Token: 0x0400078B RID: 1931
		internal GClass171 gclass171_0 = null;
	}
}
