using System;
using System.Collections.Generic;
using ns241;
using ns425;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ns435
{
	// Token: 0x02000101 RID: 257
	public class GClass139 : GClass130
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00021FD4 File Offset: 0x000201D4
		internal void method_2(int int_0)
		{
			this.method_4();
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00021FE8 File Offset: 0x000201E8
		internal void method_3(int int_0)
		{
			this.method_2(int_0);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00021FFC File Offset: 0x000201FC
		public override void vmethod_8(int int_0)
		{
			this.method_3(int_0);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00022010 File Offset: 0x00020210
		public override void vmethod_23()
		{
			this.method_7();
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00022024 File Offset: 0x00020224
		internal void method_4()
		{
			this.method_5();
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00022068 File Offset: 0x00020268
		internal void method_5()
		{
			this.method_6();
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0002207C File Offset: 0x0002027C
		internal void method_6()
		{
			this.list_0.Clear();
			this.list_0.AddRange(GClass84.smethod_1230());
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000220A4 File Offset: 0x000202A4
		internal void method_7()
		{
			this.method_8();
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000220B8 File Offset: 0x000202B8
		internal void method_8()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			GClass84.list_6.Add(new Action(this.vmethod_19));
		}

		// Token: 0x04000660 RID: 1632
		internal List<GameObject> list_0 = new List<GameObject>();

		// Token: 0x04000661 RID: 1633
		internal bool bool_0 = true;

		// Token: 0x04000662 RID: 1634
		internal List<GClass139.GStruct67> list_1 = new List<GClass139.GStruct67>();

		// Token: 0x02000102 RID: 258
		public struct GStruct67
		{
			// Token: 0x06000861 RID: 2145 RVA: 0x000220F4 File Offset: 0x000202F4
			public bool method_0(GClass139.GStruct67 gstruct67_0)
			{
				return gstruct67_0.bool_0 == this.bool_0 && gstruct67_0.bool_1 == this.bool_1 && (!gstruct67_0.bool_1 || gstruct67_0.vrcplayerApi_0 == this.vrcplayerApi_0) && gstruct67_0.udonBehaviour_0 == this.udonBehaviour_0 && gstruct67_0.string_0 == this.string_0 && gstruct67_0.float_0 == this.float_0;
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x0002216C File Offset: 0x0002036C
			public GStruct67(UdonBehaviour udonBehaviour_1, string string_1, float float_2, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, VRCPlayerApi vrcplayerApi_1 = null)
			{
				this.udonBehaviour_0 = udonBehaviour_1;
				this.string_0 = string_1;
				this.float_0 = float_2;
				this.bool_0 = bool_4;
				this.bool_1 = bool_5;
				this.bool_2 = bool_6;
				this.vrcplayerApi_0 = vrcplayerApi_1;
				this.float_1 = 0f;
				this.bool_3 = true;
			}

			// Token: 0x04000663 RID: 1635
			public UdonBehaviour udonBehaviour_0;

			// Token: 0x04000664 RID: 1636
			public string string_0;

			// Token: 0x04000665 RID: 1637
			public float float_0;

			// Token: 0x04000666 RID: 1638
			public bool bool_0;

			// Token: 0x04000667 RID: 1639
			public bool bool_1;

			// Token: 0x04000668 RID: 1640
			public bool bool_2;

			// Token: 0x04000669 RID: 1641
			public VRCPlayerApi vrcplayerApi_0;

			// Token: 0x0400066A RID: 1642
			public float float_1;

			// Token: 0x0400066B RID: 1643
			public bool bool_3;
		}
	}
}
