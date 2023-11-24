using System;
using System.IO;
using Newtonsoft.Json;

namespace ns153
{
	// Token: 0x02000100 RID: 256
	public class GClass61
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00021EC8 File Offset: 0x000200C8
		internal static void smethod_0()
		{
			GClass61.smethod_5();
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00021EDC File Offset: 0x000200DC
		internal static void smethod_1()
		{
			GClass61.smethod_3();
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00021EF0 File Offset: 0x000200F0
		internal static void smethod_2()
		{
			Directory.CreateDirectory("_Unreal/BotsManager_Config");
			if (!File.Exists("_Unreal/BotsManager_Config//config.json"))
			{
				GClass61.gclass61_0 = new GClass61();
				GClass61.smethod_4();
			}
			else
			{
				GClass61.gclass61_0 = JsonConvert.DeserializeObject<GClass61>(File.ReadAllText("_Unreal/BotsManager_Config//config.json"));
				if (GClass61.gclass61_0 == null)
				{
					GClass61.gclass61_0 = new GClass61();
				}
				GClass61.smethod_4();
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00021F80 File Offset: 0x00020180
		internal static void smethod_3()
		{
			GClass61.smethod_2();
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00021F94 File Offset: 0x00020194
		internal static void smethod_4()
		{
			GClass61.smethod_0();
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00021FA8 File Offset: 0x000201A8
		internal static void smethod_5()
		{
			if (GClass61.gclass61_0 != null)
			{
				File.WriteAllText("_Unreal/BotsManager_Config//config.json", JsonConvert.SerializeObject(GClass61.gclass61_0, 1));
			}
		}

		// Token: 0x0400065D RID: 1629
		internal static GClass61 gclass61_0;

		// Token: 0x0400065E RID: 1630
		[JsonProperty("OwnerID")]
		public string string_0 = string.Empty;

		// Token: 0x0400065F RID: 1631
		[JsonProperty("bFollowOwner")]
		public bool bool_0 = true;
	}
}
