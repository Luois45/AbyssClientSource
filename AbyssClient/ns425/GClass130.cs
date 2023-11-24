using System;
using System.Collections.Generic;
using ns185;
using ns241;
using UnityEngine;
using VRC.SDKBase;

namespace ns425
{
	// Token: 0x02000339 RID: 825
	public abstract class GClass130
	{
		// Token: 0x0600468A RID: 18058 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_0(string string_1, string string_2, GameObject gameObject_0)
		{
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_1()
		{
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_2(string string_1, string string_2)
		{
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_3(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_0, float float_0)
		{
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x00108D74 File Offset: 0x00106F74
		public virtual bool vmethod_4(GClass130 gclass130_0)
		{
			return GClass84.gclass93_0.method_206(gclass130_0);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_5(string string_1, string string_2)
		{
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_6(GameObject gameObject_0, GameObject gameObject_1)
		{
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_7(string string_1, string string_2)
		{
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_8(int int_0)
		{
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00108D8C File Offset: 0x00106F8C
		internal void method_0(string string_1, List<string> list_0)
		{
			this.method_1(string_1, list_0);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_9()
		{
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_10()
		{
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_11()
		{
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_12()
		{
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_13()
		{
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_14()
		{
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_15()
		{
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_16()
		{
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x00108DA4 File Offset: 0x00106FA4
		public virtual void vmethod_17(string string_1, List<string> list_0)
		{
			this.method_0(string_1, list_0);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_18()
		{
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_19()
		{
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_20(string string_1, string string_2)
		{
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_21(Object object_0)
		{
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_22()
		{
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x00108DDC File Offset: 0x00106FDC
		internal void method_1(string string_1, List<string> list_0)
		{
			if (!(GClass84.smethod_362(string_1) != GClass84.smethod_362(this.string_0)) && list_0 != null)
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					try
					{
						string text = list_0[i];
					}
					catch (Exception ex)
					{
						GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x060046A4 RID: 18084
		public abstract void vmethod_23();

		// Token: 0x060046A5 RID: 18085 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_24()
		{
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_25()
		{
		}

		// Token: 0x04001AC4 RID: 6852
		public string string_0 = string.Empty;
	}
}
