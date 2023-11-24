using System;
using System.IO;
using Newtonsoft.Json;

namespace ns397
{
	// Token: 0x02000304 RID: 772
	public class GClass121
	{
		// Token: 0x06004054 RID: 16468 RVA: 0x000F2FF8 File Offset: 0x000F11F8
		internal static void smethod_0()
		{
			Directory.CreateDirectory(GClass121.string_0);
			if (!File.Exists(GClass121.string_0 + "//" + "config.json"))
			{
				GClass121.gclass121_0 = new GClass121();
				GClass121.smethod_1();
			}
			else
			{
				GClass121.gclass121_0 = JsonConvert.DeserializeObject<GClass121>(File.ReadAllText(GClass121.string_0 + "//" + "config.json"));
				if (GClass121.gclass121_0 == null)
				{
					GClass121.gclass121_0 = new GClass121();
				}
				GClass121.smethod_1();
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000F307C File Offset: 0x000F127C
		internal static void smethod_1()
		{
			GClass121.smethod_4();
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x000F3090 File Offset: 0x000F1290
		internal static void smethod_2()
		{
			GClass121.smethod_3();
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x000F30A4 File Offset: 0x000F12A4
		internal static void smethod_3()
		{
			GClass121.smethod_0();
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000F30DC File Offset: 0x000F12DC
		internal static void smethod_4()
		{
			GClass121.smethod_5();
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000F30F0 File Offset: 0x000F12F0
		internal static void smethod_5()
		{
			if (GClass121.gclass121_0 != null)
			{
				File.WriteAllText(GClass121.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass121.gclass121_0, 1));
			}
		}

		// Token: 0x040018EB RID: 6379
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/UdonManager_Config");

		// Token: 0x040018EC RID: 6380
		internal static GClass121 gclass121_0;

		// Token: 0x040018ED RID: 6381
		[JsonProperty("bLogEvents")]
		public bool bool_0 = false;
	}
}
