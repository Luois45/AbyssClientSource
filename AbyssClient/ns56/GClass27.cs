using System;
using ns241;
using ns410;
using ns53;
using ns55;
using UnityEngine;
using UnityEngine.UI;

namespace ns56
{
	// Token: 0x020000E2 RID: 226
	public class GClass27 : GClass26
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x0001CDA4 File Offset: 0x0001AFA4
		public GClass27(string string_3)
		{
			this.string_0 = string_3;
			this.method_17(string_3);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
		private void method_17(string string_3)
		{
			this.method_18(string_3);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		private void method_18(string string_3)
		{
			this.method_19(string_3);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
		private void method_19(string string_3)
		{
			this.string_1 = "LayoutGroup";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass124.smethod_30(), GClass124.smethod_8(GClass84.smethod_195().Find(this.string_0)), true);
			this.gridLayoutGroup_0 = this.gameObject_0.GetComponent<GridLayoutGroup>();
			base.method_11(true);
			GClass25.list_3.Add(this);
		}

		// Token: 0x04000589 RID: 1417
		private GridLayoutGroup gridLayoutGroup_0;
	}
}
