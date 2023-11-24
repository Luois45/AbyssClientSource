using System;
using ns205;
using ns241;
using ns559;
using ns8;
using UnityEngine;
using UnityEngine.UI;

namespace ns9
{
	// Token: 0x0200004F RID: 79
	public class GClass3 : GClass2
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x000083E8 File Offset: 0x000065E8
		public GClass3(string string_3)
		{
			this.string_0 = string_3;
			this.method_17(string_3);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000840C File Offset: 0x0000660C
		private void method_17(string string_3)
		{
			this.method_18(string_3);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008420 File Offset: 0x00006620
		private void method_18(string string_3)
		{
			this.method_19(string_3);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008434 File Offset: 0x00006634
		private void method_19(string string_3)
		{
			this.string_1 = "LayoutGroup";
			this.gameObject_0 = Object.Instantiate<GameObject>(GClass73.smethod_10(), GClass73.smethod_2(GClass84.smethod_195().Find(this.string_0)), true);
			this.gridLayoutGroup_0 = this.gameObject_0.GetComponent<GridLayoutGroup>();
			base.method_6(true);
			GClass199.list_3.Add(this);
		}

		// Token: 0x04000130 RID: 304
		private GridLayoutGroup gridLayoutGroup_0;
	}
}
