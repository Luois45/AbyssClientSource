using System;
using ns425;
using ns471;
using ns473;
using UnityEngine;

namespace ns466
{
	// Token: 0x0200031F RID: 799
	public class GClass169 : GClass130
	{
		// Token: 0x060040FF RID: 16639 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_26()
		{
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_27(int int_0)
		{
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x000F7000 File Offset: 0x000F5200
		public override void vmethod_9()
		{
			this.method_3();
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x000F7014 File Offset: 0x000F5214
		internal void method_2()
		{
			this.method_6();
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_28()
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x000F7028 File Offset: 0x000F5228
		public virtual void vmethod_29()
		{
			this.method_2();
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_25()
		{
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_15()
		{
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x000F703C File Offset: 0x000F523C
		internal void method_3()
		{
			this.method_4();
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_22()
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x000F7050 File Offset: 0x000F5250
		public virtual Material vmethod_30()
		{
			Material result;
			if (this.material_0)
			{
				result = this.material_0;
			}
			else
			{
				this.material_0 = new Material("Standard");
				this.material_0.SetTexture("_MainTex", this.texture2D_0);
				result = this.material_0;
			}
			return result;
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_19()
		{
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x000F70A4 File Offset: 0x000F52A4
		internal void method_4()
		{
			this.vector3_2 = this.vector3_1 - this.vector3_0;
			this.vector3_0 = this.vector3_1;
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x000F70D4 File Offset: 0x000F52D4
		public override void vmethod_23()
		{
			this.method_5();
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_11()
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_12()
		{
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x000F70E8 File Offset: 0x000F52E8
		internal void method_5()
		{
			this.method_7();
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00004908 File Offset: 0x00002B08
		public virtual void vmethod_31()
		{
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_24()
		{
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x000F70FC File Offset: 0x000F52FC
		internal void method_6()
		{
			this.float_0 = 1f;
			this.genum80_0 = GClass169.GEnum80.const_1;
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x000F711C File Offset: 0x000F531C
		public virtual bool vmethod_32(GClass169 gclass169_0)
		{
			if (gclass169_0 != null)
			{
				gclass169_0.gclass174_0 = this.gclass174_0;
				gclass169_0.gclass176_0 = this.gclass176_0;
			}
			return base.vmethod_4(gclass169_0);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_8(int int_0)
		{
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00004908 File Offset: 0x00002B08
		public override void vmethod_10()
		{
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x000F71E0 File Offset: 0x000F53E0
		internal void method_7()
		{
			this.vmethod_29();
		}

		// Token: 0x0400195D RID: 6493
		internal GClass174 gclass174_0 = null;

		// Token: 0x0400195E RID: 6494
		internal GClass176 gclass176_0 = null;

		// Token: 0x0400195F RID: 6495
		internal GameObject gameObject_0 = null;

		// Token: 0x04001960 RID: 6496
		internal GClass169.GEnum79 genum79_0 = GClass169.GEnum79.const_0;

		// Token: 0x04001961 RID: 6497
		internal Mesh mesh_0 = null;

		// Token: 0x04001962 RID: 6498
		internal Mesh mesh_1 = null;

		// Token: 0x04001963 RID: 6499
		internal Texture2D texture2D_0 = null;

		// Token: 0x04001964 RID: 6500
		private Material material_0 = null;

		// Token: 0x04001965 RID: 6501
		internal float float_0 = 0f;

		// Token: 0x04001966 RID: 6502
		private Vector3 vector3_0 = default(Vector3);

		// Token: 0x04001967 RID: 6503
		internal Vector3 vector3_1 = default(Vector3);

		// Token: 0x04001968 RID: 6504
		internal Quaternion quaternion_0 = default(Quaternion);

		// Token: 0x04001969 RID: 6505
		internal Vector3 vector3_2 = default(Vector3);

		// Token: 0x0400196A RID: 6506
		internal GClass169.GEnum80 genum80_0 = GClass169.GEnum80.const_0;

		// Token: 0x02000320 RID: 800
		public enum GEnum79
		{
			// Token: 0x0400196C RID: 6508
			const_0,
			// Token: 0x0400196D RID: 6509
			const_1,
			// Token: 0x0400196E RID: 6510
			const_2,
			// Token: 0x0400196F RID: 6511
			const_3,
			// Token: 0x04001970 RID: 6512
			const_4,
			// Token: 0x04001971 RID: 6513
			const_5,
			// Token: 0x04001972 RID: 6514
			const_6,
			// Token: 0x04001973 RID: 6515
			const_7,
			// Token: 0x04001974 RID: 6516
			const_8,
			// Token: 0x04001975 RID: 6517
			const_9,
			// Token: 0x04001976 RID: 6518
			const_10,
			// Token: 0x04001977 RID: 6519
			const_11,
			// Token: 0x04001978 RID: 6520
			const_12
		}

		// Token: 0x02000321 RID: 801
		public enum GEnum80
		{
			// Token: 0x0400197A RID: 6522
			const_0,
			// Token: 0x0400197B RID: 6523
			const_1,
			// Token: 0x0400197C RID: 6524
			const_2,
			// Token: 0x0400197D RID: 6525
			const_3,
			// Token: 0x0400197E RID: 6526
			const_4,
			// Token: 0x0400197F RID: 6527
			const_5,
			// Token: 0x04001980 RID: 6528
			const_6,
			// Token: 0x04001981 RID: 6529
			const_7,
			// Token: 0x04001982 RID: 6530
			const_8,
			// Token: 0x04001983 RID: 6531
			const_9
		}

		// Token: 0x02000322 RID: 802
		public struct GStruct259
		{
			// Token: 0x06004118 RID: 16664 RVA: 0x000F71F4 File Offset: 0x000F53F4
			public GStruct259(int int_4, int int_5)
			{
				this.int_0 = 0;
				this.int_1 = 0;
				this.int_2 = int_4;
				this.int_3 = int_5;
			}

			// Token: 0x06004119 RID: 16665 RVA: 0x000F7220 File Offset: 0x000F5420
			public GStruct259(int int_4, int int_5, int int_6, int int_7)
			{
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
			}

			// Token: 0x04001984 RID: 6532
			public int int_0;

			// Token: 0x04001985 RID: 6533
			public int int_1;

			// Token: 0x04001986 RID: 6534
			public int int_2;

			// Token: 0x04001987 RID: 6535
			public int int_3;
		}

		// Token: 0x02000323 RID: 803
		public struct GStruct260
		{
			// Token: 0x0600411A RID: 16666 RVA: 0x000F724C File Offset: 0x000F544C
			public GStruct260(int int_0, int int_1, int int_2, int int_3)
			{
				this.float_0 = (float)int_0;
				this.float_1 = (float)int_1;
				this.float_2 = (float)int_2;
				this.float_3 = (float)int_3;
			}

			// Token: 0x0600411B RID: 16667 RVA: 0x000F727C File Offset: 0x000F547C
			public GStruct260(int int_0, int int_1)
			{
				this.float_0 = 0f;
				this.float_1 = 0f;
				this.float_2 = (float)int_0;
				this.float_3 = (float)int_1;
			}

			// Token: 0x04001988 RID: 6536
			public float float_0;

			// Token: 0x04001989 RID: 6537
			public float float_1;

			// Token: 0x0400198A RID: 6538
			public float float_2;

			// Token: 0x0400198B RID: 6539
			public float float_3;
		}
	}
}
