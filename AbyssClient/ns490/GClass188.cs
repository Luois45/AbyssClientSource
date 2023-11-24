using System;
using System.IO;
using Newtonsoft.Json;

namespace ns490
{
	// Token: 0x02000352 RID: 850
	public class GClass188
	{
		// Token: 0x06004750 RID: 18256 RVA: 0x0010E1AC File Offset: 0x0010C3AC
		internal static void smethod_0()
		{
			Directory.CreateDirectory(GClass188.string_0);
			if (!File.Exists(GClass188.string_0 + "//" + "config.json"))
			{
				GClass188.gclass188_0 = new GClass188();
				GClass188.smethod_2();
			}
			else
			{
				GClass188.gclass188_0 = JsonConvert.DeserializeObject<GClass188>(File.ReadAllText(GClass188.string_0 + "//" + "config.json"));
				if (GClass188.gclass188_0 == null)
				{
					GClass188.gclass188_0 = new GClass188();
				}
				GClass188.smethod_2();
			}
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x0010E254 File Offset: 0x0010C454
		internal static void smethod_1()
		{
			GClass188.smethod_0();
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x0010E268 File Offset: 0x0010C468
		internal static void smethod_2()
		{
			GClass188.smethod_3();
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0010E2A0 File Offset: 0x0010C4A0
		internal static void smethod_3()
		{
			GClass188.smethod_5();
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x0010E2B4 File Offset: 0x0010C4B4
		internal static void smethod_4()
		{
			GClass188.smethod_1();
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x0010E2C8 File Offset: 0x0010C4C8
		internal static void smethod_5()
		{
			if (GClass188.gclass188_0 != null)
			{
				File.WriteAllText(GClass188.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass188.gclass188_0, 1));
			}
		}

		// Token: 0x04001B91 RID: 7057
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/Optimization");

		// Token: 0x04001B92 RID: 7058
		internal static GClass188 gclass188_0;

		// Token: 0x04001B93 RID: 7059
		[JsonProperty("bAllowPerformanceScanner")]
		public bool bool_0 = false;

		// Token: 0x04001B94 RID: 7060
		[JsonProperty("bAutoHideParticlesOnPortals")]
		public bool bool_1 = true;
	}
}
