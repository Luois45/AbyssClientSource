using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns520;
using VRC.Core;

namespace ns127
{
	// Token: 0x020000C4 RID: 196
	public class GClass56
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x000198E4 File Offset: 0x00017AE4
		internal void method_0(ApiWorld apiWorld_0, ApiWorldInstance apiWorldInstance_0)
		{
			this.method_10(apiWorld_0, apiWorldInstance_0);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000198FC File Offset: 0x00017AFC
		internal void method_1()
		{
			this.method_4();
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00019910 File Offset: 0x00017B10
		internal void method_2(GClass192 gclass192_0)
		{
			int num = GClass192.smethod_3(this.list_0, gclass192_0);
			bool flag = false;
			if (num == -1)
			{
				this.list_0.Insert(0, gclass192_0);
				flag = true;
			}
			else if (num > 0)
			{
				GClass192.smethod_7(this.list_0, gclass192_0, false);
				this.list_0.Insert(0, gclass192_0);
				flag = true;
			}
			if (this.list_0.Count > this.int_0)
			{
				this.list_0.RemoveRange(this.int_0, this.list_0.Count - this.int_0);
				flag = true;
			}
			if (flag)
			{
				this.method_1();
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000199AC File Offset: 0x00017BAC
		internal void method_3()
		{
			Directory.CreateDirectory(GClass56.string_0);
			if (!File.Exists(GClass56.string_2))
			{
				this.method_1();
			}
			else
			{
				this.list_0 = JsonConvert.DeserializeObject<List<GClass192>>(File.ReadAllText(GClass56.string_2));
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000199F0 File Offset: 0x00017BF0
		internal void method_4()
		{
			this.method_8();
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00019A04 File Offset: 0x00017C04
		internal void method_5(GClass192 gclass192_0)
		{
			this.method_2(gclass192_0);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00019A18 File Offset: 0x00017C18
		internal void method_6(GClass192 gclass192_0)
		{
			this.method_5(gclass192_0);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00019A2C File Offset: 0x00017C2C
		internal void method_7()
		{
			this.method_3();
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00019A40 File Offset: 0x00017C40
		internal void method_8()
		{
			if (this.list_0.Count > 0)
			{
				this.list_0.RemoveAll(new Predicate<GClass192>(GClass56.Class49.class49_0.method_0));
				File.WriteAllText(GClass56.string_2, JsonConvert.SerializeObject(this.list_0, 1));
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00019B18 File Offset: 0x00017D18
		internal void method_9()
		{
			this.method_7();
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00019B2C File Offset: 0x00017D2C
		internal void method_10(ApiWorld apiWorld_0, ApiWorldInstance apiWorldInstance_0)
		{
			this.method_11(apiWorld_0, apiWorldInstance_0);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00019B44 File Offset: 0x00017D44
		internal void method_11(ApiWorld apiWorld_0, ApiWorldInstance apiWorldInstance_0)
		{
			if (apiWorld_0 != null && apiWorldInstance_0 != null)
			{
				this.method_6(new GClass192(apiWorld_0, apiWorldInstance_0));
			}
		}

		// Token: 0x040004F0 RID: 1264
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/SavedWorlds");

		// Token: 0x040004F1 RID: 1265
		internal static string string_1 = GClass56.string_0 + "/" + "config" + ".txt";

		// Token: 0x040004F2 RID: 1266
		internal static string string_2 = string.Concat(new string[]
		{
			GClass56.string_0,
			"/",
			"Last",
			"Worlds",
			".json"
		});

		// Token: 0x040004F3 RID: 1267
		public List<GClass192> list_0 = new List<GClass192>();

		// Token: 0x040004F4 RID: 1268
		public int int_0 = 100;

		// Token: 0x020000C5 RID: 197
		[CompilerGenerated]
		[Serializable]
		private sealed class Class49
		{
			// Token: 0x060005F8 RID: 1528 RVA: 0x00019B84 File Offset: 0x00017D84
			internal bool method_0(GClass192 gclass192_0)
			{
				return gclass192_0.string_2 == string.Empty;
			}

			// Token: 0x040004F5 RID: 1269
			public static readonly GClass56.Class49 class49_0 = new GClass56.Class49();

			// Token: 0x040004F6 RID: 1270
			public static Predicate<GClass192> predicate_0;
		}
	}
}
