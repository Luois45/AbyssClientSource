using System;
using System.IO;
using Newtonsoft.Json;

namespace ns105
{
	// Token: 0x0200008F RID: 143
	public class GClass48
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x00011524 File Offset: 0x0000F724
		internal static void smethod_0()
		{
			GClass48.smethod_2();
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00011538 File Offset: 0x0000F738
		internal static void smethod_1()
		{
			GClass48.smethod_3();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001154C File Offset: 0x0000F74C
		internal static void smethod_2()
		{
			GClass48.smethod_5();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00011560 File Offset: 0x0000F760
		internal static void smethod_3()
		{
			GClass48.smethod_4();
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000115EC File Offset: 0x0000F7EC
		internal static void smethod_4()
		{
			Directory.CreateDirectory("_Unreal/Logger");
			if (!File.Exists("_Unreal/Logger//config.json"))
			{
				GClass48.gclass48_0 = new GClass48();
				GClass48.smethod_0();
			}
			else
			{
				GClass48.gclass48_0 = JsonConvert.DeserializeObject<GClass48>(File.ReadAllText("_Unreal/Logger//config.json"));
				if (GClass48.gclass48_0 == null)
				{
					GClass48.gclass48_0 = new GClass48();
				}
				GClass48.smethod_0();
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00011654 File Offset: 0x0000F854
		internal static void smethod_5()
		{
			if (GClass48.gclass48_0 != null)
			{
				File.WriteAllText("_Unreal/Logger//config.json", JsonConvert.SerializeObject(GClass48.gclass48_0, 1));
			}
		}

		// Token: 0x04000306 RID: 774
		internal static GClass48 gclass48_0;

		// Token: 0x04000307 RID: 775
		[JsonProperty("bMutualLogEnabled")]
		public bool bool_0 = false;

		// Token: 0x04000308 RID: 776
		[JsonProperty("bAntiCrashLogEnabled")]
		public bool bool_1 = false;

		// Token: 0x04000309 RID: 777
		[JsonProperty("bJoinLeaveLogEnabled")]
		public bool bool_2 = false;

		// Token: 0x0400030A RID: 778
		[JsonProperty("bModerationLogEnabled")]
		public bool bool_3 = false;

		// Token: 0x0400030B RID: 779
		[JsonProperty("bAvatarsLogEnabled")]
		public bool bool_4 = false;

		// Token: 0x0400030C RID: 780
		[JsonProperty("bUdonLogEnabled")]
		public bool bool_5 = false;

		// Token: 0x0400030D RID: 781
		[JsonProperty("bGeneralLogEnabled")]
		public bool bool_6 = false;

		// Token: 0x0400030E RID: 782
		[JsonProperty("FontSize")]
		public int int_0 = 50;

		// Token: 0x0400030F RID: 783
		[JsonProperty("bLoggerEnabled")]
		public bool bool_7 = false;

		// Token: 0x04000310 RID: 784
		[JsonProperty("LoggerType")]
		public string string_0 = "LT_None";

		// Token: 0x04000311 RID: 785
		[JsonProperty("bLogger2Enabled")]
		public bool bool_8 = false;

		// Token: 0x04000312 RID: 786
		[JsonProperty("Logger2Type")]
		public string string_1 = "LT_None";

		// Token: 0x04000313 RID: 787
		[JsonProperty("bConsoleLogEnabled")]
		public bool bool_9 = true;
	}
}
