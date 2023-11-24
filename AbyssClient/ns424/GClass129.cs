using System;
using System.IO;
using Newtonsoft.Json;

namespace ns424
{
	// Token: 0x02000338 RID: 824
	public class GClass129
	{
		// Token: 0x06004684 RID: 18052 RVA: 0x00108C64 File Offset: 0x00106E64
		internal static void smethod_0()
		{
			Directory.CreateDirectory(GClass129.string_0);
			if (!File.Exists(GClass129.string_0 + "//" + "config.json"))
			{
				GClass129.gclass129_0 = new GClass129();
				GClass129.smethod_1();
			}
			else
			{
				GClass129.gclass129_0 = JsonConvert.DeserializeObject<GClass129>(File.ReadAllText(GClass129.string_0 + "//" + "config.json"));
				if (GClass129.gclass129_0 == null)
				{
					GClass129.gclass129_0 = new GClass129();
				}
				GClass129.smethod_1();
			}
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00108CE8 File Offset: 0x00106EE8
		internal static void smethod_1()
		{
			GClass129.smethod_2();
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00108CFC File Offset: 0x00106EFC
		internal static void smethod_2()
		{
			GClass129.smethod_5();
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00108D10 File Offset: 0x00106F10
		internal static void smethod_3()
		{
			GClass129.smethod_4();
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x00108D24 File Offset: 0x00106F24
		internal static void smethod_4()
		{
			GClass129.smethod_0();
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00108D38 File Offset: 0x00106F38
		internal static void smethod_5()
		{
			if (GClass129.gclass129_0 != null)
			{
				File.WriteAllText(GClass129.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass129.gclass129_0, 1));
			}
		}

		// Token: 0x04001ABE RID: 6846
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/Reuploader");

		// Token: 0x04001ABF RID: 6847
		internal static GClass129 gclass129_0;

		// Token: 0x04001AC0 RID: 6848
		[JsonProperty("isPrivate")]
		public bool bool_0 = true;

		// Token: 0x04001AC1 RID: 6849
		[JsonProperty("bUseCustomName")]
		public bool bool_1 = false;

		// Token: 0x04001AC2 RID: 6850
		[JsonProperty("bUseCustomDescription")]
		public bool bool_2 = false;

		// Token: 0x04001AC3 RID: 6851
		[JsonProperty("bUseCustomImage")]
		public bool bool_3 = false;
	}
}
