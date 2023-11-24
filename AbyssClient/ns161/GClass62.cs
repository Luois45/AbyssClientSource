using System;
using System.IO;
using Newtonsoft.Json;

namespace ns161
{
	// Token: 0x0200010A RID: 266
	public class GClass62
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x000221C0 File Offset: 0x000203C0
		internal static void smethod_0()
		{
			GClass62.smethod_5();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000221D4 File Offset: 0x000203D4
		internal static void smethod_1()
		{
			Directory.CreateDirectory(GClass62.string_0);
			if (!File.Exists(GClass62.string_0 + "//" + "config.json"))
			{
				GClass62.gclass62_0 = new GClass62();
				GClass62.smethod_2();
			}
			else
			{
				GClass62.gclass62_0 = JsonConvert.DeserializeObject<GClass62>(File.ReadAllText(GClass62.string_0 + "//" + "config.json"));
				if (GClass62.gclass62_0 == null)
				{
					GClass62.gclass62_0 = new GClass62();
				}
				GClass62.smethod_2();
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00022258 File Offset: 0x00020458
		internal static void smethod_2()
		{
			GClass62.smethod_0();
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002226C File Offset: 0x0002046C
		internal static void smethod_3()
		{
			GClass62.smethod_1();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00022324 File Offset: 0x00020524
		internal static void smethod_4()
		{
			GClass62.smethod_3();
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0002235C File Offset: 0x0002055C
		internal static void smethod_5()
		{
			if (GClass62.gclass62_0 != null)
			{
				File.WriteAllText(GClass62.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass62.gclass62_0, 1));
			}
		}

		// Token: 0x04000680 RID: 1664
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/PhotonManager_Config");

		// Token: 0x04000681 RID: 1665
		internal static GClass62 gclass62_0;

		// Token: 0x04000682 RID: 1666
		[JsonProperty("bFakePing")]
		public bool bool_0 = false;

		// Token: 0x04000683 RID: 1667
		[JsonProperty("bFakePing_UseRandom")]
		public bool bool_1 = true;

		// Token: 0x04000684 RID: 1668
		[JsonProperty("FakePing")]
		public short short_0 = 600;

		// Token: 0x04000685 RID: 1669
		[JsonProperty("FakePing_Min")]
		public short short_1 = 600;

		// Token: 0x04000686 RID: 1670
		[JsonProperty("FakePing_Max")]
		public short short_2 = 800;

		// Token: 0x04000687 RID: 1671
		[JsonProperty("bFakeFPS")]
		public bool bool_2 = false;

		// Token: 0x04000688 RID: 1672
		[JsonProperty("bFakeFPS_UseRandom")]
		public bool bool_3 = true;

		// Token: 0x04000689 RID: 1673
		[JsonProperty("bFakeFPS_UseDependenceOfRealFPS")]
		public bool bool_4 = true;

		// Token: 0x0400068A RID: 1674
		[JsonProperty("FakeFPS")]
		public float float_0 = 100f;

		// Token: 0x0400068B RID: 1675
		[JsonProperty("FakeFPS_Min")]
		public float float_1 = 100f;

		// Token: 0x0400068C RID: 1676
		[JsonProperty("FakeFPS_Max")]
		public float float_2 = 180f;

		// Token: 0x0400068D RID: 1677
		[JsonProperty("bBlockAllRPC")]
		public bool bool_5 = false;

		// Token: 0x0400068E RID: 1678
		[JsonProperty("bAntiPhotonExploit")]
		public bool bool_6 = true;

		// Token: 0x0400068F RID: 1679
		[JsonProperty("bAntiBlock")]
		public bool bool_7 = false;

		// Token: 0x04000690 RID: 1680
		[JsonProperty("bForceMute")]
		public bool bool_8 = false;

		// Token: 0x04000691 RID: 1681
		[JsonProperty("bAntiEarRape")]
		public bool bool_9 = true;

		// Token: 0x04000692 RID: 1682
		[JsonProperty("bAntiPositionExploit")]
		public bool bool_10 = true;
	}
}
