using System;
using System.IO;
using Newtonsoft.Json;

namespace ns216
{
	// Token: 0x02000195 RID: 405
	public class GClass75
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x00050754 File Offset: 0x0004E954
		internal static void smethod_0()
		{
			GClass75.smethod_3();
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00050768 File Offset: 0x0004E968
		internal static void smethod_1()
		{
			GClass75.smethod_0();
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000507A0 File Offset: 0x0004E9A0
		internal static void smethod_2()
		{
			GClass75.smethod_4();
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000507B4 File Offset: 0x0004E9B4
		internal static void smethod_3()
		{
			Directory.CreateDirectory("_Unreal/HUDOverlay");
			if (!File.Exists("_Unreal/HUDOverlay//config.json"))
			{
				GClass75.gclass75_0 = new GClass75();
				GClass75.smethod_2();
			}
			else
			{
				GClass75.gclass75_0 = JsonConvert.DeserializeObject<GClass75>(File.ReadAllText("_Unreal/HUDOverlay//config.json"));
				if (GClass75.gclass75_0 == null)
				{
					GClass75.gclass75_0 = new GClass75();
				}
				GClass75.smethod_2();
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0005081C File Offset: 0x0004EA1C
		internal static void smethod_4()
		{
			GClass75.smethod_5();
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00050830 File Offset: 0x0004EA30
		internal static void smethod_5()
		{
			if (GClass75.gclass75_0 != null)
			{
				File.WriteAllText("_Unreal/HUDOverlay//config.json", JsonConvert.SerializeObject(GClass75.gclass75_0, 1));
			}
		}

		// Token: 0x04000B5A RID: 2906
		internal static GClass75 gclass75_0;

		// Token: 0x04000B5B RID: 2907
		[JsonProperty("FontSize")]
		public int int_0 = 13;

		// Token: 0x04000B5C RID: 2908
		[JsonProperty("bShowSettings")]
		public bool bool_0 = true;
	}
}
