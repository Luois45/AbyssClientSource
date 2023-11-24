using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ns478;

namespace ns45
{
	// Token: 0x02000036 RID: 54
	public class GClass21
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00006978 File Offset: 0x00004B78
		internal static void smethod_0()
		{
			Directory.CreateDirectory(GClass21.string_0);
			if (!File.Exists(GClass21.string_0 + "//" + "config.json"))
			{
				GClass21.gclass21_0 = new GClass21();
				GClass21.smethod_3();
			}
			else
			{
				GClass21.gclass21_0 = JsonConvert.DeserializeObject<GClass21>(File.ReadAllText(GClass21.string_0 + "//" + "config.json"));
				if (GClass21.gclass21_0 == null)
				{
					GClass21.gclass21_0 = new GClass21();
				}
				GClass21.smethod_3();
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000069FC File Offset: 0x00004BFC
		internal static void smethod_1()
		{
			GClass21.smethod_4();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00006A34 File Offset: 0x00004C34
		internal static void smethod_2()
		{
			GClass21.smethod_5();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006A48 File Offset: 0x00004C48
		internal static void smethod_3()
		{
			GClass21.smethod_2();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006A5C File Offset: 0x00004C5C
		internal static void smethod_4()
		{
			GClass21.smethod_0();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00006A70 File Offset: 0x00004C70
		internal static void smethod_5()
		{
			if (GClass21.gclass21_0 != null)
			{
				File.WriteAllText(GClass21.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass21.gclass21_0, 1));
			}
		}

		// Token: 0x040000D0 RID: 208
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/PortalsHandler_Config");

		// Token: 0x040000D1 RID: 209
		internal static GClass21 gclass21_0;

		// Token: 0x040000D2 RID: 210
		[JsonProperty("SavedWorlds")]
		public List<GClass181.GStruct270> list_0 = new List<GClass181.GStruct270>();
	}
}
