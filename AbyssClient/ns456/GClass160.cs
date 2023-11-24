using System;
using ns241;
using ns425;
using UnityEngine;

namespace ns456
{
	// Token: 0x020002BF RID: 703
	public class GClass160 : GClass130
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x000A5EA0 File Offset: 0x000A40A0
		internal void method_2()
		{
			GL.wireframe = this.bool_0;
			if (this.bool_0)
			{
				GL.Clear(true, true, Color.black);
			}
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000A5ECC File Offset: 0x000A40CC
		internal void method_3()
		{
			this.method_5();
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		public override void vmethod_19()
		{
			this.method_4();
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		internal void method_4()
		{
			this.method_2();
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000A5F08 File Offset: 0x000A4108
		public override void vmethod_23()
		{
			this.method_3();
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0004D888 File Offset: 0x0004BA88
		internal void method_5()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
		}

		// Token: 0x0400129D RID: 4765
		internal bool bool_0 = false;
	}
}
