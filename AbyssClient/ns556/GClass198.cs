using System;
using System.IO;
using Newtonsoft.Json;

namespace ns556
{
	// Token: 0x020003B4 RID: 948
	public class GClass198
	{
		// Token: 0x06004A7B RID: 19067 RVA: 0x0011C138 File Offset: 0x0011A338
		internal static void smethod_0()
		{
			Directory.CreateDirectory(GClass198.string_0);
			if (!File.Exists(GClass198.string_0 + "//" + "config.json"))
			{
				GClass198.gclass198_0 = new GClass198();
				GClass198.smethod_4();
			}
			else
			{
				GClass198.gclass198_0 = JsonConvert.DeserializeObject<GClass198>(File.ReadAllText(GClass198.string_0 + "//" + "config.json"));
				if (GClass198.gclass198_0 == null)
				{
					GClass198.gclass198_0 = new GClass198();
				}
				GClass198.smethod_4();
			}
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x0011C1BC File Offset: 0x0011A3BC
		internal static void smethod_1()
		{
			GClass198.smethod_5();
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x0011C1F4 File Offset: 0x0011A3F4
		internal static void smethod_2()
		{
			GClass198.smethod_3();
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x0011C208 File Offset: 0x0011A408
		internal static void smethod_3()
		{
			GClass198.smethod_0();
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x0011C21C File Offset: 0x0011A41C
		internal static void smethod_4()
		{
			GClass198.smethod_1();
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x0011C274 File Offset: 0x0011A474
		internal static void smethod_5()
		{
			if (GClass198.gclass198_0 != null)
			{
				File.WriteAllText(GClass198.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass198.gclass198_0, 1));
			}
		}

		// Token: 0x04001DB0 RID: 7600
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/VRCPlusHandler_Config");

		// Token: 0x04001DB1 RID: 7601
		internal static GClass198 gclass198_0;

		// Token: 0x04001DB2 RID: 7602
		[JsonProperty("bHideVRCPlusMiniBanner")]
		public bool bool_0 = false;

		// Token: 0x04001DB3 RID: 7603
		[JsonProperty("bDestroyVRCPlusMiniBanner")]
		public bool bool_1 = true;

		// Token: 0x04001DB4 RID: 7604
		[JsonProperty("bHideVRCPlusPageTab")]
		public bool bool_2 = false;

		// Token: 0x04001DB5 RID: 7605
		[JsonProperty("bDestroyVRCPlusPageTab")]
		public bool bool_3 = true;

		// Token: 0x04001DB6 RID: 7606
		[JsonProperty("bDestroyVRCPlusUserIconButtonHoverOver")]
		public bool bool_4 = true;

		// Token: 0x04001DB7 RID: 7607
		[JsonProperty("bHideVRCPlusGetMoreFavorites")]
		public bool bool_5 = false;

		// Token: 0x04001DB8 RID: 7608
		[JsonProperty("bDestroyVRCPlusGetMoreFavorites")]
		public bool bool_6 = true;
	}
}
