using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ns241;
using VRC.Core;

namespace ns520
{
	// Token: 0x02000387 RID: 903
	public class GClass192
	{
		// Token: 0x060049DD RID: 18909 RVA: 0x00119218 File Offset: 0x00117418
		public static bool smethod_0(GClass192 gclass192_0, GClass192 gclass192_1)
		{
			bool result;
			if (gclass192_0 == null)
			{
				result = (gclass192_1 == null);
			}
			else
			{
				result = (gclass192_1 != null && (gclass192_0.string_0 == gclass192_1.string_0 && gclass192_0.string_1 == gclass192_1.string_1 && gclass192_0.string_2 == gclass192_1.string_2 && gclass192_0.string_3 == gclass192_1.string_3 && gclass192_0.string_4 == gclass192_1.string_4) && gclass192_0.string_5 == gclass192_1.string_5);
			}
			return result;
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001192C8 File Offset: 0x001174C8
		internal static int smethod_1(List<GClass192> list_0, string string_6, string string_7, int int_0)
		{
			string_6 = string_6.ToUpper();
			string_7 = string_7.ToUpper();
			while (int_0 < list_0.Count)
			{
				if (list_0[int_0].string_2.ToUpper() == string_6 && list_0[int_0].string_3.ToUpper() == string_7)
				{
					return int_0;
				}
				int_0++;
			}
			return -1;
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00119334 File Offset: 0x00117534
		internal static int smethod_2(List<GClass192> list_0, GClass192 gclass192_0, int int_0)
		{
			while (int_0 < list_0.Count)
			{
				if (list_0[int_0].string_2 == gclass192_0.string_2 && list_0[int_0].string_3 == gclass192_0.string_3)
				{
					return int_0;
				}
				int_0++;
			}
			return -1;
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00119390 File Offset: 0x00117590
		internal static int smethod_3(List<GClass192> list_0, GClass192 gclass192_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].string_2 == gclass192_0.string_2 && list_0[i].string_3 == gclass192_0.string_3)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x001193EC File Offset: 0x001175EC
		public GClass192(ApiWorld apiWorld_0, ApiWorldInstance apiWorldInstance_0)
		{
			if (apiWorld_0 != null)
			{
				this.string_0 = apiWorld_0.name;
				this.string_1 = apiWorld_0.description;
				this.string_2 = apiWorld_0.id;
				this.string_3 = apiWorldInstance_0.instanceId;
				this.string_4 = apiWorld_0.thumbnailImageUrl;
				this.string_5 = apiWorld_0.platform;
			}
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00119490 File Offset: 0x00117690
		internal static int smethod_4(List<GClass192> list_0, string string_6, string string_7, int int_0, int int_1)
		{
			string_6 = string_6.ToUpper();
			string_7 = string_7.ToUpper();
			int_1 = GClass84.smethod_741(int_1, list_0.Count);
			while (int_0 < int_1)
			{
				if (list_0[int_0].string_2.ToUpper() == string_6 && list_0[int_0].string_3.ToUpper() == string_7)
				{
					return int_0;
				}
				int_0++;
			}
			return -1;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x00119508 File Offset: 0x00117708
		internal static int smethod_5(List<GClass192> list_0, string string_6, string string_7)
		{
			string_6 = string_6.ToUpper();
			string_7 = string_7.ToUpper();
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].string_2.ToUpper() == string_6 && list_0[i].string_3.ToUpper() == string_7)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x00119574 File Offset: 0x00117774
		internal static int smethod_6(List<GClass192> list_0, GClass192 gclass192_0, int int_0, int int_1)
		{
			int_1 = GClass84.smethod_741(int_1, list_0.Count);
			while (int_0 < int_1)
			{
				if (list_0[int_0].string_2 == gclass192_0.string_2 && list_0[int_0].string_3 == gclass192_0.string_3)
				{
					return int_0;
				}
				int_0++;
			}
			return -1;
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001195D8 File Offset: 0x001177D8
		internal static bool smethod_7(List<GClass192> list_0, GClass192 gclass192_0, bool bool_0 = false)
		{
			int num = GClass192.smethod_3(list_0, gclass192_0);
			bool result;
			if (num == -1)
			{
				result = false;
			}
			else
			{
				if (bool_0)
				{
					while (num != -1)
					{
						list_0.RemoveAt(num);
						num = GClass192.smethod_2(list_0, gclass192_0, num);
					}
				}
				else
				{
					list_0.RemoveAt(num);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00119624 File Offset: 0x00117824
		public static bool smethod_8(GClass192 gclass192_0, GClass192 gclass192_1)
		{
			bool result;
			if (gclass192_0 == null)
			{
				result = (gclass192_1 != null);
			}
			else
			{
				result = (gclass192_1 == null || (!(gclass192_0.string_0 == gclass192_1.string_0) || !(gclass192_0.string_1 == gclass192_1.string_1) || !(gclass192_0.string_2 == gclass192_1.string_2) || !(gclass192_0.string_3 == gclass192_1.string_3) || !(gclass192_0.string_4 == gclass192_1.string_4) || !(gclass192_0.string_5 == gclass192_1.string_5)));
			}
			return result;
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x001196D4 File Offset: 0x001178D4
		internal static List<GClass192> smethod_9(List<ApiWorld> list_0, List<ApiWorldInstance> list_1)
		{
			List<GClass192> result;
			if (list_0.Count == 0 || list_0.Count != list_1.Count)
			{
				result = new List<GClass192>();
			}
			else
			{
				List<GClass192> list = new List<GClass192>();
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(new GClass192(list_0[i], list_1[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x0011973C File Offset: 0x0011793C
		internal static bool smethod_10(List<GClass192> list_0, string string_6, string string_7, bool bool_0 = false)
		{
			int num = GClass192.smethod_5(list_0, string_6, string_7);
			bool result;
			if (num == -1)
			{
				result = false;
			}
			else
			{
				if (bool_0)
				{
					while (num != -1)
					{
						list_0.RemoveAt(num);
						num = GClass192.smethod_1(list_0, string_6, string_7, num);
					}
				}
				else
				{
					list_0.RemoveAt(num);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x04001CB3 RID: 7347
		[JsonProperty("name")]
		public string string_0 = string.Empty;

		// Token: 0x04001CB4 RID: 7348
		[JsonProperty("description")]
		public string string_1 = string.Empty;

		// Token: 0x04001CB5 RID: 7349
		[JsonProperty("id")]
		public string string_2 = string.Empty;

		// Token: 0x04001CB6 RID: 7350
		[JsonProperty("currentInstanceIdWithTags")]
		public string string_3 = string.Empty;

		// Token: 0x04001CB7 RID: 7351
		[JsonProperty("thumbnailImageUrl")]
		public string string_4 = string.Empty;

		// Token: 0x04001CB8 RID: 7352
		[JsonProperty("platform")]
		public string string_5 = string.Empty;
	}
}
