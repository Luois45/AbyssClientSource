using System;
using System.IO;
using Newtonsoft.Json;
using ns421;

namespace ns6
{
	// Token: 0x0200000D RID: 13
	public class GClass1
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00004894 File Offset: 0x00002A94
		internal static void smethod_0()
		{
			GClass1.smethod_5();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000048F4 File Offset: 0x00002AF4
		internal static void smethod_1()
		{
			GClass1.smethod_4();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004918 File Offset: 0x00002B18
		internal static void smethod_2()
		{
			GClass1.smethod_0();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000492C File Offset: 0x00002B2C
		internal static void smethod_3()
		{
			GClass1.smethod_1();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004940 File Offset: 0x00002B40
		internal static void smethod_4()
		{
			GClass128.smethod_0();
			Directory.CreateDirectory("_Unreal/Quality_Config");
			if (!File.Exists("_Unreal/Quality_Config//config.json"))
			{
				GClass1.gclass1_0 = new GClass1();
				GClass1.smethod_2();
			}
			else
			{
				GClass1.gclass1_0 = JsonConvert.DeserializeObject<GClass1>(File.ReadAllText("_Unreal/Quality_Config//config.json"));
				if (GClass1.gclass1_0 == null)
				{
					GClass1.gclass1_0 = new GClass1();
				}
				GClass1.smethod_2();
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000049AC File Offset: 0x00002BAC
		internal static void smethod_5()
		{
			if (GClass1.gclass1_0 != null)
			{
				File.WriteAllText("_Unreal/Quality_Config//config.json", JsonConvert.SerializeObject(GClass1.gclass1_0, 1));
			}
		}

		// Token: 0x0400004D RID: 77
		internal static GClass1 gclass1_0;

		// Token: 0x0400004E RID: 78
		[JsonProperty("MSAALevel")]
		public int int_0 = 0;

		// Token: 0x0400004F RID: 79
		[JsonProperty("anisotropicFiltering")]
		public int int_1 = 2;

		// Token: 0x04000050 RID: 80
		[JsonProperty("TextureSizeLimit")]
		public int int_2 = 0;

		// Token: 0x04000051 RID: 81
		[JsonProperty("PixelLightCount")]
		public int int_3 = 8;

		// Token: 0x04000052 RID: 82
		[JsonProperty("HardwareGraphicsTier")]
		public int int_4 = 0;

		// Token: 0x04000053 RID: 83
		[JsonProperty("shadowResolution")]
		public int int_5 = 0;

		// Token: 0x04000054 RID: 84
		[JsonProperty("qualityLevel")]
		public int int_6 = 0;

		// Token: 0x04000055 RID: 85
		[JsonProperty("shadowQuality")]
		public int int_7 = 0;
	}
}
