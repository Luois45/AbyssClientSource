using System;
using ns241;
using ns425;
using UnityEngine;

namespace ns458
{
	// Token: 0x020002D7 RID: 727
	public class GClass162 : GClass130
	{
		// Token: 0x060021E1 RID: 8673 RVA: 0x000AD19C File Offset: 0x000AB39C
		internal void method_2()
		{
			this.method_23();
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000AD1B0 File Offset: 0x000AB3B0
		internal void method_3(float float_3)
		{
			this.float_1 = float_3;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000AD1C4 File Offset: 0x000AB3C4
		internal void method_4(float float_3)
		{
			this.method_27(this.float_2 + float_3);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000AD1E0 File Offset: 0x000AB3E0
		internal void method_5()
		{
			this.method_21();
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000AD1F4 File Offset: 0x000AB3F4
		internal void method_6()
		{
			this.method_22();
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000AD208 File Offset: 0x000AB408
		internal void method_7(float float_3)
		{
			this.method_19(this.float_0 + float_3);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000AD224 File Offset: 0x000AB424
		internal void method_8(bool bool_1)
		{
			this.method_9(bool_1);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000AD238 File Offset: 0x000AB438
		internal void method_9(bool bool_1)
		{
			this.method_13(bool_1);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000AD24C File Offset: 0x000AB44C
		internal void method_10(float float_3)
		{
			this.method_7(float_3);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000AD260 File Offset: 0x000AB460
		public override void vmethod_23()
		{
			this.method_17();
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000AD274 File Offset: 0x000AB474
		private static float smethod_0()
		{
			return 10f;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000AD288 File Offset: 0x000AB488
		internal void method_11(float float_3)
		{
			this.method_32(float_3);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000AD29C File Offset: 0x000AB49C
		internal void method_12()
		{
			Light light = this.method_33();
			if (light)
			{
				light.enabled = this.bool_0;
				if (this.bool_0)
				{
					light.color = this.color_0;
					light.intensity = this.float_0;
					light.spotAngle = this.float_1;
					light.range = this.float_2;
				}
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000AD2FC File Offset: 0x000AB4FC
		internal void method_13(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000AD310 File Offset: 0x000AB510
		internal void method_14(float float_3)
		{
			this.method_10(float_3);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000AD324 File Offset: 0x000AB524
		internal void method_15(Color color_1)
		{
			this.method_28(color_1);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000AD338 File Offset: 0x000AB538
		internal void method_16(float float_3)
		{
			this.method_29(float_3);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000AD34C File Offset: 0x000AB54C
		internal void method_17()
		{
			this.method_39();
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000AD360 File Offset: 0x000AB560
		internal void method_18(float float_3)
		{
			this.method_24(float_3);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000AD374 File Offset: 0x000AB574
		internal void method_19(float float_3)
		{
			this.method_18(float_3);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000AD388 File Offset: 0x000AB588
		internal void method_20(float float_3)
		{
			this.method_16(float_3);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000AD39C File Offset: 0x000AB59C
		internal void method_21()
		{
			this.method_30();
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
		internal void method_22()
		{
			this.method_19(GClass162.smethod_2());
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000AD3C8 File Offset: 0x000AB5C8
		internal void method_23()
		{
			this.method_27(GClass162.smethod_0());
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000AD3E0 File Offset: 0x000AB5E0
		internal void method_24(float float_3)
		{
			this.float_0 = float_3;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000AD3F4 File Offset: 0x000AB5F4
		internal void method_25(Color color_1)
		{
			this.color_0 = color_1;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000AD408 File Offset: 0x000AB608
		internal void method_26(float float_3)
		{
			this.method_38(float_3);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000AD41C File Offset: 0x000AB61C
		internal void method_27(float float_3)
		{
			this.method_11(float_3);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000AD430 File Offset: 0x000AB630
		private static float smethod_1()
		{
			return 30f;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x000AD444 File Offset: 0x000AB644
		internal void method_28(Color color_1)
		{
			this.method_25(color_1);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000AD458 File Offset: 0x000AB658
		internal void method_29(float float_3)
		{
			this.method_26(this.float_1 + float_3);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000AD474 File Offset: 0x000AB674
		internal void method_30()
		{
			this.method_26(GClass162.smethod_1());
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000AD48C File Offset: 0x000AB68C
		internal void method_31()
		{
			this.method_12();
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000AD4A0 File Offset: 0x000AB6A0
		internal void method_32(float float_3)
		{
			this.float_2 = float_3;
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000AD4B4 File Offset: 0x000AB6B4
		private Light method_33()
		{
			if (!this.light_0)
			{
				VRCVrCamera field_Private_Static_VRCVrCamera_ = VRCVrCamera.field_Private_Static_VRCVrCamera_0;
				if (!field_Private_Static_VRCVrCamera_)
				{
					return null;
				}
				this.light_0 = field_Private_Static_VRCVrCamera_.GetComponentInChildren<Camera>().gameObject.AddComponent<Light>();
				this.light_0.type = 0;
			}
			return this.light_0;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000AD510 File Offset: 0x000AB710
		internal void method_34()
		{
			this.method_2();
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000AD524 File Offset: 0x000AB724
		internal void method_35(float float_3)
		{
			this.method_36(float_3);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000AD538 File Offset: 0x000AB738
		private static float smethod_2()
		{
			return 1f;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000AD59C File Offset: 0x000AB79C
		public override void vmethod_19()
		{
			this.method_31();
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000AD5B0 File Offset: 0x000AB7B0
		internal void method_36(float float_3)
		{
			this.method_4(float_3);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000AD5C4 File Offset: 0x000AB7C4
		internal void method_37()
		{
			this.method_6();
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000AD5D8 File Offset: 0x000AB7D8
		internal void method_38(float float_3)
		{
			this.method_3(float_3);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0004D888 File Offset: 0x0004BA88
		internal void method_39()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
		}

		// Token: 0x0400133C RID: 4924
		private Light light_0 = null;

		// Token: 0x0400133D RID: 4925
		internal Color color_0 = Color.white;

		// Token: 0x0400133E RID: 4926
		internal float float_0 = GClass162.smethod_2();

		// Token: 0x0400133F RID: 4927
		internal float float_1 = GClass162.smethod_1();

		// Token: 0x04001340 RID: 4928
		internal float float_2 = GClass162.smethod_0();

		// Token: 0x04001341 RID: 4929
		internal bool bool_0 = false;
	}
}
