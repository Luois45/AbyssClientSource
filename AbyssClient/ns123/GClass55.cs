using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ns318;

namespace ns123
{
	// Token: 0x020000C0 RID: 192
	public class GClass55
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x000197D8 File Offset: 0x000179D8
		internal static void smethod_0()
		{
			GClass55.smethod_5();
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000197EC File Offset: 0x000179EC
		internal static void smethod_1()
		{
			GClass55.smethod_0();
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00019800 File Offset: 0x00017A00
		internal static void smethod_2()
		{
			Directory.CreateDirectory("_Unreal/Logger");
			if (!File.Exists("_Unreal/Logger//config.json"))
			{
				GClass55.gclass55_0 = new GClass55();
				GClass55.smethod_1();
			}
			else
			{
				GClass55.gclass55_0 = JsonConvert.DeserializeObject<GClass55>(File.ReadAllText("_Unreal/Logger//config.json"));
				if (GClass55.gclass55_0 == null)
				{
					GClass55.gclass55_0 = new GClass55();
				}
				GClass55.smethod_1();
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00019868 File Offset: 0x00017A68
		internal static void smethod_3()
		{
			GClass55.smethod_4();
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001987C File Offset: 0x00017A7C
		internal static void smethod_4()
		{
			GClass55.smethod_2();
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00019890 File Offset: 0x00017A90
		internal static void smethod_5()
		{
			if (GClass55.gclass55_0 != null)
			{
				File.WriteAllText("_Unreal/Logger//config.json", JsonConvert.SerializeObject(GClass55.gclass55_0, 1));
			}
		}

		// Token: 0x040004CE RID: 1230
		internal static GClass55 gclass55_0;

		// Token: 0x040004CF RID: 1231
		[JsonProperty("ConfigVersion")]
		public int int_0 = 1;

		// Token: 0x040004D0 RID: 1232
		[JsonProperty("PlayerPermissions")]
		public Dictionary<string, GClass103> dictionary_0 = new Dictionary<string, GClass103>();
	}
}
