using System;
using System.IO;
using Newtonsoft.Json;

namespace ns365
{
	// Token: 0x020002C9 RID: 713
	public class GClass115
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x000A6430 File Offset: 0x000A4630
		internal static void smethod_0()
		{
			GClass115.smethod_3();
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000A6444 File Offset: 0x000A4644
		internal static void smethod_1()
		{
			GClass115.smethod_5();
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000A64C8 File Offset: 0x000A46C8
		internal static void smethod_2()
		{
			Directory.CreateDirectory(GClass115.string_0);
			if (!File.Exists(GClass115.string_0 + "//" + "config.json"))
			{
				GClass115.gclass115_0 = new GClass115();
				GClass115.smethod_4();
			}
			else
			{
				GClass115.gclass115_0 = JsonConvert.DeserializeObject<GClass115>(File.ReadAllText(GClass115.string_0 + "//" + "config.json"));
				if (GClass115.gclass115_0 == null)
				{
					GClass115.gclass115_0 = new GClass115();
				}
				GClass115.smethod_4();
			}
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000A654C File Offset: 0x000A474C
		internal static void smethod_3()
		{
			GClass115.smethod_2();
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000A6560 File Offset: 0x000A4760
		internal static void smethod_4()
		{
			GClass115.smethod_1();
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000A6574 File Offset: 0x000A4774
		internal static void smethod_5()
		{
			if (GClass115.gclass115_0 != null)
			{
				File.WriteAllText(GClass115.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass115.gclass115_0, 1));
			}
		}

		// Token: 0x040012C5 RID: 4805
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/ReplicationManager_Config");

		// Token: 0x040012C6 RID: 4806
		internal static GClass115 gclass115_0;

		// Token: 0x040012C7 RID: 4807
		[JsonProperty("bUseServer")]
		public bool bool_0 = false;

		// Token: 0x040012C8 RID: 4808
		[JsonProperty("UsingPort")]
		public int int_0 = 30651;

		// Token: 0x040012C9 RID: 4809
		[JsonProperty("bUseDedicatedServer")]
		public bool bool_1 = false;

		// Token: 0x040012CA RID: 4810
		[JsonProperty("DedicatedServer")]
		public string string_1 = string.Empty;

		// Token: 0x040012CB RID: 4811
		[JsonProperty("GroupID")]
		public string string_2 = string.Empty;

		// Token: 0x040012CC RID: 4812
		[JsonProperty("bIsBot")]
		public bool bool_2 = false;
	}
}
