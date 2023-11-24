using System;
using System.IO;
using Newtonsoft.Json;

namespace ns275
{
	// Token: 0x02000233 RID: 563
	public class GClass91
	{
		// Token: 0x06001931 RID: 6449 RVA: 0x00082540 File Offset: 0x00080740
		internal static void smethod_0()
		{
			GClass91.smethod_3();
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00082570 File Offset: 0x00080770
		internal static void smethod_1()
		{
			GClass91.smethod_4();
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00082584 File Offset: 0x00080784
		internal static void smethod_2()
		{
			Directory.CreateDirectory(GClass91.string_0);
			if (!File.Exists(GClass91.string_0 + "//" + "config.json"))
			{
				GClass91.gclass91_0 = new GClass91();
				GClass91.smethod_0();
			}
			else
			{
				GClass91.gclass91_0 = JsonConvert.DeserializeObject<GClass91>(File.ReadAllText(GClass91.string_0 + "//" + "config.json"));
				if (GClass91.gclass91_0 == null)
				{
					GClass91.gclass91_0 = new GClass91();
				}
				GClass91.smethod_0();
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00082608 File Offset: 0x00080808
		internal static void smethod_3()
		{
			GClass91.smethod_5();
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0008261C File Offset: 0x0008081C
		internal static void smethod_4()
		{
			GClass91.smethod_2();
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00082630 File Offset: 0x00080830
		internal static void smethod_5()
		{
			if (GClass91.gclass91_0 != null)
			{
				File.WriteAllText(GClass91.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass91.gclass91_0, 1));
			}
		}

		// Token: 0x04000EEF RID: 3823
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/TimeManager_Config");

		// Token: 0x04000EF0 RID: 3824
		internal static GClass91 gclass91_0;

		// Token: 0x04000EF1 RID: 3825
		[JsonProperty("bRestartGameEveryHour")]
		public bool bool_0 = false;
	}
}
