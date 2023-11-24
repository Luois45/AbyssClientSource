using System;
using ns185;
using ns425;
using ns6;
using UnityEngine;
using UnityEngine.Rendering;

namespace ns431
{
	// Token: 0x02000086 RID: 134
	public class GClass135 : GClass130
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x00010074 File Offset: 0x0000E274
		internal void method_2(GClass135.GEnum16 genum16_0)
		{
			this.method_13(genum16_0);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00010088 File Offset: 0x0000E288
		internal void method_3()
		{
			this.method_14();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001009C File Offset: 0x0000E29C
		internal void method_4()
		{
			this.method_10();
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000100B0 File Offset: 0x0000E2B0
		internal void method_5()
		{
			this.method_8();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000100C4 File Offset: 0x0000E2C4
		internal void method_6()
		{
			GClass1.gclass1_0.int_0 = this.int_0;
			GClass1.gclass1_0.int_1 = this.anisotropicFiltering_0;
			GClass1.gclass1_0.int_2 = this.int_1;
			GClass1.gclass1_0.int_3 = this.int_2;
			GClass1.gclass1_0.int_4 = this.graphicsTier_0;
			GClass1.gclass1_0.int_7 = this.shadowQuality_0;
			GClass1.gclass1_0.int_5 = this.shadowResolution_0;
			GClass1.gclass1_0.int_6 = this.qualityLevel_0;
			GClass1.smethod_2();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00010158 File Offset: 0x0000E358
		public override void vmethod_23()
		{
			this.method_9();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001016C File Offset: 0x0000E36C
		internal void method_7(GClass135.GEnum16 genum16_0)
		{
			switch (genum16_0)
			{
			case GClass135.GEnum16.const_0:
				this.int_0 = 0;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 0;
				this.shadowQuality_0 = 0;
				this.shadowResolution_0 = 0;
				this.qualityLevel_0 = 0;
				break;
			case GClass135.GEnum16.const_1:
				this.int_0 = 0;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 0;
				this.shadowQuality_0 = 0;
				this.shadowResolution_0 = 0;
				this.qualityLevel_0 = 1;
				break;
			case GClass135.GEnum16.const_2:
				this.int_0 = 2;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 1;
				this.shadowQuality_0 = 1;
				this.shadowResolution_0 = 1;
				this.qualityLevel_0 = 2;
				break;
			case GClass135.GEnum16.const_3:
				this.int_0 = 4;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 2;
				this.shadowQuality_0 = 2;
				this.shadowResolution_0 = 2;
				this.qualityLevel_0 = 3;
				break;
			case GClass135.GEnum16.const_4:
				this.int_0 = 8;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 2;
				this.shadowQuality_0 = 2;
				this.shadowResolution_0 = 3;
				this.qualityLevel_0 = 4;
				break;
			case GClass135.GEnum16.const_5:
				this.int_0 = 8;
				this.anisotropicFiltering_0 = 2;
				this.int_1 = 0;
				this.int_2 = 8;
				this.graphicsTier_0 = 2;
				this.shadowQuality_0 = 2;
				this.shadowResolution_0 = 3;
				this.qualityLevel_0 = 5;
				break;
			}
			this.method_5();
			this.method_3();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00010310 File Offset: 0x0000E510
		internal void method_8()
		{
			this.method_6();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00010324 File Offset: 0x0000E524
		internal void method_9()
		{
			this.method_15();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00010338 File Offset: 0x0000E538
		internal void method_10()
		{
			this.method_12();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001034C File Offset: 0x0000E54C
		internal void method_11()
		{
			QualitySettings.antiAliasing = this.int_0;
			QualitySettings.anisotropicFiltering = this.anisotropicFiltering_0;
			QualitySettings.masterTextureLimit = this.int_1;
			QualitySettings.pixelLightCount = this.int_2;
			Graphics.activeTier = this.graphicsTier_0;
			QualitySettings.shadows = this.shadowQuality_0;
			QualitySettings.shadowResolution = this.shadowResolution_0;
			QualitySettings.currentLevel = this.qualityLevel_0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000103B4 File Offset: 0x0000E5B4
		internal void method_12()
		{
			GClass70.smethod_38("antiAliasing" + ": " + QualitySettings.antiAliasing.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("anisotropicFiltering" + ": " + QualitySettings.anisotropicFiltering.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("masterTextureLimit" + ": " + QualitySettings.masterTextureLimit.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("pixelLightCount" + ": " + QualitySettings.pixelLightCount.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("activeTier" + ": " + Graphics.activeTier.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("shadows" + ": " + QualitySettings.shadows.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("shadowResolution" + ": " + QualitySettings.shadowResolution.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("currentLevel" + ": " + QualitySettings.currentLevel.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("maxQueuedFrames" + ": " + QualitySettings.maxQueuedFrames.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_38("shadowDistance" + ": " + QualitySettings.shadowDistance.ToString(), GClass70.Enum1.const_0);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00010538 File Offset: 0x0000E738
		internal void method_13(GClass135.GEnum16 genum16_0)
		{
			this.method_7(genum16_0);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001054C File Offset: 0x0000E74C
		internal void method_14()
		{
			this.method_11();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00010560 File Offset: 0x0000E760
		internal void method_15()
		{
			GClass1.smethod_3();
			this.int_0 = GClass1.gclass1_0.int_0;
			this.anisotropicFiltering_0 = GClass1.gclass1_0.int_1;
			this.int_1 = GClass1.gclass1_0.int_2;
			this.int_2 = GClass1.gclass1_0.int_3;
			this.graphicsTier_0 = GClass1.gclass1_0.int_4;
			this.shadowResolution_0 = GClass1.gclass1_0.int_5;
			this.qualityLevel_0 = GClass1.gclass1_0.int_6;
			this.shadowQuality_0 = GClass1.gclass1_0.int_7;
			this.method_3();
		}

		// Token: 0x040002DA RID: 730
		internal int int_0;

		// Token: 0x040002DB RID: 731
		internal AnisotropicFiltering anisotropicFiltering_0;

		// Token: 0x040002DC RID: 732
		internal int int_1;

		// Token: 0x040002DD RID: 733
		internal int int_2;

		// Token: 0x040002DE RID: 734
		internal GraphicsTier graphicsTier_0;

		// Token: 0x040002DF RID: 735
		internal ShadowResolution shadowResolution_0;

		// Token: 0x040002E0 RID: 736
		internal QualityLevel qualityLevel_0;

		// Token: 0x040002E1 RID: 737
		internal ShadowQuality shadowQuality_0;

		// Token: 0x02000087 RID: 135
		public enum GEnum16
		{
			// Token: 0x040002E3 RID: 739
			const_0,
			// Token: 0x040002E4 RID: 740
			const_1,
			// Token: 0x040002E5 RID: 741
			const_2,
			// Token: 0x040002E6 RID: 742
			const_3,
			// Token: 0x040002E7 RID: 743
			const_4,
			// Token: 0x040002E8 RID: 744
			const_5
		}
	}
}
