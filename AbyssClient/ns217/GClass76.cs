using System;
using System.Collections.Generic;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json;
using ns241;
using VRC.Core;

namespace ns217
{
	// Token: 0x02000196 RID: 406
	public class GClass76
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x0005085C File Offset: 0x0004EA5C
		internal static int smethod_0(List<GClass76> list_0, string string_10, int int_0)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				while (int_0 < list_0.Count)
				{
					if (GClass84.smethod_1611(list_0[int_0].string_2.ToUpper(), string_10) != -1)
					{
						return int_0;
					}
					int_0++;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000508B4 File Offset: 0x0004EAB4
		internal static int smethod_1(List<GClass76> list_0, GClass76 gclass76_0)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					if (list_0[i].string_2 == gclass76_0.string_2)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00050900 File Offset: 0x0004EB00
		internal static bool smethod_2(List<GClass76> list_0, GClass76 gclass76_0, bool bool_0 = false)
		{
			bool result;
			if (list_0 == null)
			{
				result = false;
			}
			else
			{
				int num = GClass76.smethod_1(list_0, gclass76_0);
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
							num = GClass76.smethod_25(list_0, gclass76_0, num);
						}
					}
					else
					{
						list_0.RemoveAt(num);
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00050954 File Offset: 0x0004EB54
		public GClass76(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.string_0 = apiAvatar_0.name;
				this.string_1 = apiAvatar_0.description;
				this.string_2 = apiAvatar_0.id;
				this.string_3 = apiAvatar_0.authorName;
				this.string_4 = apiAvatar_0.authorId;
				this.string_5 = apiAvatar_0.releaseStatus;
				this.string_6 = apiAvatar_0.assetUrl;
				this.string_7 = apiAvatar_0.imageUrl;
				this.string_8 = apiAvatar_0.thumbnailImageUrl;
				this.string_9 = apiAvatar_0.platform;
				if (this.string_0 == null)
				{
					this.string_0 = string.Empty;
				}
				if (this.string_1 == null)
				{
					this.string_1 = string.Empty;
				}
				if (this.string_2 == null)
				{
					this.string_2 = string.Empty;
				}
				if (this.string_3 == null)
				{
					this.string_3 = string.Empty;
				}
				if (this.string_4 == null)
				{
					this.string_4 = string.Empty;
				}
				if (this.string_5 == null)
				{
					this.string_5 = string.Empty;
				}
				if (this.string_6 == null)
				{
					this.string_6 = string.Empty;
				}
				if (this.string_7 == null)
				{
					this.string_7 = string.Empty;
				}
				if (this.string_8 == null)
				{
					this.string_8 = string.Empty;
				}
				if (this.string_9 == null)
				{
					this.string_9 = string.Empty;
				}
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00050B34 File Offset: 0x0004ED34
		internal static List<ApiAvatar> smethod_3(List<GClass76> list_0)
		{
			List<ApiAvatar> result;
			if (list_0 == null || list_0.Count == 0)
			{
				result = new List<ApiAvatar>();
			}
			else
			{
				List<ApiAvatar> list = new List<ApiAvatar>();
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(GClass76.smethod_7(list_0[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00050B88 File Offset: 0x0004ED88
		internal static List<GClass76> smethod_4(List<ApiAvatar> list_0)
		{
			List<GClass76> result;
			if (list_0.Count == 0)
			{
				result = new List<GClass76>();
			}
			else
			{
				List<GClass76> list = new List<GClass76>();
				foreach (ApiAvatar apiAvatar_ in list_0)
				{
					list.Add(new GClass76(apiAvatar_));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00050BFC File Offset: 0x0004EDFC
		public static bool smethod_5(GClass76 gclass76_0, GClass76 gclass76_1)
		{
			bool result;
			if (gclass76_0 == null)
			{
				result = (gclass76_1 == null);
			}
			else
			{
				result = (gclass76_1 != null && (gclass76_0.string_0 == gclass76_1.string_0 && gclass76_0.string_1 == gclass76_1.string_1 && gclass76_0.string_2 == gclass76_1.string_2 && gclass76_0.string_3 == gclass76_1.string_3 && gclass76_0.string_4 == gclass76_1.string_4 && gclass76_0.string_5 == gclass76_1.string_5 && gclass76_0.string_6 == gclass76_1.string_6 && gclass76_0.string_7 == gclass76_1.string_7 && gclass76_0.string_8 == gclass76_1.string_8) && gclass76_0.string_9 == gclass76_1.string_9);
			}
			return result;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00050D04 File Offset: 0x0004EF04
		internal static List<ApiAvatar> smethod_6(List<GClass76> list_0)
		{
			List<ApiAvatar> result;
			if (list_0 == null || list_0.Count == 0)
			{
				result = new List<ApiAvatar>();
			}
			else
			{
				List<ApiAvatar> list = new List<ApiAvatar>();
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(GClass76.smethod_15(list_0[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00050D58 File Offset: 0x0004EF58
		internal static ApiAvatar smethod_7(GClass76 gclass76_0)
		{
			ApiAvatar result;
			if (GClass76.smethod_5(gclass76_0, null))
			{
				result = new ApiAvatar();
			}
			else
			{
				ApiAvatar apiAvatar = new ApiAvatar
				{
					name = gclass76_0.string_0,
					description = gclass76_0.string_1,
					id = gclass76_0.string_2,
					authorName = gclass76_0.string_3,
					authorId = gclass76_0.string_4,
					releaseStatus = gclass76_0.string_5,
					assetUrl = gclass76_0.string_6,
					imageUrl = gclass76_0.string_7,
					thumbnailImageUrl = gclass76_0.string_7,
					platform = gclass76_0.string_9
				};
				result = apiAvatar;
			}
			return result;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00050DFC File Offset: 0x0004EFFC
		internal static List<GClass76> smethod_8(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00050EA4 File Offset: 0x0004F0A4
		internal static List<GClass76> smethod_9(List<GClass76> list_0, string string_10, bool bool_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_3.ToUpper() == string_10)
						{
							list.Add(list_0[i]);
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[j]);
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00050F5C File Offset: 0x0004F15C
		internal static int smethod_10(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							return int_0;
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							return int_0;
						}
						int_0++;
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		internal static List<int> smethod_11(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00051090 File Offset: 0x0004F290
		public static bool smethod_12(GClass76 gclass76_0, GClass76 gclass76_1)
		{
			bool result;
			if (gclass76_0 == null)
			{
				result = (gclass76_1 != null);
			}
			else
			{
				result = (gclass76_1 == null || (!(gclass76_0.string_0 == gclass76_1.string_0) || !(gclass76_0.string_1 == gclass76_1.string_1) || !(gclass76_0.string_2 == gclass76_1.string_2) || !(gclass76_0.string_3 == gclass76_1.string_3) || !(gclass76_0.string_4 == gclass76_1.string_4) || !(gclass76_0.string_5 == gclass76_1.string_5) || !(gclass76_0.string_6 == gclass76_1.string_6) || !(gclass76_0.string_7 == gclass76_1.string_7) || !(gclass76_0.string_8 == gclass76_1.string_8) || !(gclass76_0.string_9 == gclass76_1.string_9)));
			}
			return result;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00051198 File Offset: 0x0004F398
		internal static bool smethod_13(List<GClass76> list_0, string string_10, bool bool_0 = false)
		{
			bool result;
			if (list_0 == null)
			{
				result = false;
			}
			else
			{
				int num = GClass76.smethod_24(list_0, string_10);
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
							num = GClass76.smethod_0(list_0, string_10, num);
						}
					}
					else
					{
						list_0.RemoveAt(num);
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000511EC File Offset: 0x0004F3EC
		internal static List<ApiAvatar> smethod_14(List<GClass76> list_0)
		{
			List<ApiAvatar> result;
			if (list_0 == null || list_0.Count == 0)
			{
				result = new List<ApiAvatar>();
			}
			else
			{
				List<ApiAvatar> list = new List<ApiAvatar>();
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(GClass76.smethod_20(list_0[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00051240 File Offset: 0x0004F440
		internal static ApiAvatar smethod_15(GClass76 gclass76_0)
		{
			ApiAvatar result;
			if (GClass76.smethod_5(gclass76_0, null))
			{
				result = new ApiAvatar();
			}
			else
			{
				ApiAvatar apiAvatar = new ApiAvatar
				{
					name = gclass76_0.string_0,
					description = gclass76_0.string_1,
					id = gclass76_0.string_2,
					authorName = gclass76_0.string_3,
					authorId = gclass76_0.string_4,
					releaseStatus = gclass76_0.string_5,
					assetUrl = gclass76_0.string_6,
					imageUrl = gclass76_0.string_7,
					thumbnailImageUrl = (string.IsNullOrEmpty(gclass76_0.string_8) ? gclass76_0.string_7 : gclass76_0.string_8),
					platform = gclass76_0.string_9
				};
				result = apiAvatar;
			}
			return result;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000512F8 File Offset: 0x0004F4F8
		internal static List<int> smethod_16(List<GClass76> list_0, string string_10, bool bool_0)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_0.ToUpper() == string_10)
						{
							list.Add(i);
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(j);
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000513A4 File Offset: 0x0004F5A4
		internal static List<GClass76> smethod_17(List<GClass76> list_0, string string_10, bool bool_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[i]);
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[j]);
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0005145C File Offset: 0x0004F65C
		internal static List<GClass76> smethod_18(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_3.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00051510 File Offset: 0x0004F710
		internal static List<int> smethod_19(List<GClass76> list_0, string string_10, bool bool_0)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_3.ToUpper() == string_10)
						{
							list.Add(i);
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(j);
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000515BC File Offset: 0x0004F7BC
		internal static ApiAvatar smethod_20(GClass76 gclass76_0)
		{
			ApiAvatar result;
			if (GClass76.smethod_5(gclass76_0, null))
			{
				result = new ApiAvatar();
			}
			else
			{
				ApiAvatar apiAvatar = new ApiAvatar
				{
					name = gclass76_0.string_0,
					description = gclass76_0.string_1,
					id = gclass76_0.string_2,
					authorName = gclass76_0.string_3,
					authorId = gclass76_0.string_4,
					releaseStatus = gclass76_0.string_5,
					assetUrl = gclass76_0.string_6,
					imageUrl = gclass76_0.string_7,
					thumbnailImageUrl = gclass76_0.string_8,
					platform = gclass76_0.string_9
				};
				result = apiAvatar;
			}
			return result;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00051660 File Offset: 0x0004F860
		internal static List<GClass76> smethod_21(List<GClass76> list_0, string string_10, bool bool_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[i]);
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[j]);
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00051718 File Offset: 0x0004F918
		internal static List<GClass76> smethod_22(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000517CC File Offset: 0x0004F9CC
		internal static List<GClass76> smethod_23(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00051880 File Offset: 0x0004FA80
		internal static int smethod_24(List<GClass76> list_0, string string_10)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				for (int i = 0; i < list_0.Count; i++)
				{
					if (GClass84.smethod_1611(list_0[i].string_2.ToUpper(), string_10) != -1)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000518D8 File Offset: 0x0004FAD8
		internal static int smethod_25(List<GClass76> list_0, GClass76 gclass76_0, int int_0)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				while (int_0 < list_0.Count)
				{
					if (list_0[int_0].string_2 == gclass76_0.string_2)
					{
						return int_0;
					}
					int_0++;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00051920 File Offset: 0x0004FB20
		internal static List<int> smethod_26(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000519BC File Offset: 0x0004FBBC
		internal static List<int> smethod_27(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_3.ToUpper() == string_10)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00051A58 File Offset: 0x0004FC58
		internal static void smethod_28(ref List<GClass76> list_0, bool bool_0)
		{
			GClass76.smethod_37(ref list_0, bool_0);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00051A6C File Offset: 0x0004FC6C
		internal static int smethod_29(List<GClass76> list_0, string string_10, bool bool_0)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				if (bool_0)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						if (list_0[i].string_0.ToUpper() == string_10)
						{
							return i;
						}
					}
				}
				else
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						if (GClass84.smethod_1611(list_0[j].string_0.ToUpper(), string_10) != -1)
						{
							return j;
						}
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00051B00 File Offset: 0x0004FD00
		internal static int smethod_30(List<GClass76> list_0, GClass76 gclass76_0, int int_0, int int_1)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				while (int_0 < int_1)
				{
					if (list_0[int_0].string_2 == gclass76_0.string_2)
					{
						return int_0;
					}
					int_0++;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00051B54 File Offset: 0x0004FD54
		internal static void smethod_31(ref List<GClass76> list_0, bool bool_0 = false)
		{
			GClass76.smethod_28(ref list_0, bool_0);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00051B68 File Offset: 0x0004FD68
		internal static List<GClass76> smethod_32(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00051C10 File Offset: 0x0004FE10
		internal static List<int> smethod_33(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			List<int> result;
			if (list_0 == null)
			{
				result = new List<int>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<int> list = new List<int>();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_3.ToUpper() == string_10)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(int_0);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00051CB8 File Offset: 0x0004FEB8
		internal static List<GClass76> smethod_34(List<GClass76> list_0, string string_10, bool bool_0, int int_0)
		{
			List<GClass76> result;
			if (list_0 == null)
			{
				result = new List<GClass76>();
			}
			else
			{
				string_10 = string_10.ToUpper();
				List<GClass76> list = new List<GClass76>();
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_3.ToUpper() == string_10)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < list_0.Count)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_3.ToUpper(), string_10) != -1)
						{
							list.Add(list_0[int_0]);
						}
						int_0++;
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00051D60 File Offset: 0x0004FF60
		internal static int smethod_35(List<GClass76> list_0, string string_10, int int_0, int int_1)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				while (int_0 < int_1)
				{
					if (GClass84.smethod_1611(list_0[int_0].string_2.ToUpper(), string_10) != -1)
					{
						return int_0;
					}
					int_0++;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		internal static int smethod_36(List<GClass76> list_0, string string_10, bool bool_0, int int_0, int int_1)
		{
			int result;
			if (list_0 == null)
			{
				result = -1;
			}
			else
			{
				string_10 = string_10.ToUpper();
				int_1 = GClass84.smethod_741(int_1, list_0.Count);
				if (bool_0)
				{
					while (int_0 < list_0.Count)
					{
						if (list_0[int_0].string_0.ToUpper() == string_10)
						{
							return int_0;
						}
						int_0++;
					}
				}
				else
				{
					while (int_0 < int_1)
					{
						if (GClass84.smethod_1611(list_0[int_0].string_0.ToUpper(), string_10) != -1)
						{
							return int_0;
						}
						int_0++;
					}
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00051E54 File Offset: 0x00050054
		internal static void smethod_37(ref List<GClass76> list_0, bool bool_0)
		{
			if (list_0 != null)
			{
				if (bool_0)
				{
					int i = 0;
					IL_52:
					while (i < list_0.Count)
					{
						for (int j = 0; j < i; j++)
						{
							if (list_0[i].string_2 == list_0[j].string_2)
							{
								list_0.RemoveAt(i);
								i--;
								IL_4E:
								i++;
								goto IL_52;
							}
						}
						goto IL_4E;
					}
				}
				else
				{
					int k = 0;
					IL_A8:
					while (k < list_0.Count)
					{
						for (int l = 0; l < k; l++)
						{
							if (GClass76.smethod_5(list_0[k], list_0[l]))
							{
								list_0.RemoveAt(k);
								k--;
								IL_A2:
								k++;
								goto IL_A8;
							}
						}
						goto IL_A2;
					}
				}
			}
		}

		// Token: 0x04000B5D RID: 2909
		[JsonProperty("name")]
		public string string_0 = string.Empty;

		// Token: 0x04000B5E RID: 2910
		[JsonProperty("description")]
		public string string_1 = string.Empty;

		// Token: 0x04000B5F RID: 2911
		[JsonProperty("id")]
		public string string_2 = string.Empty;

		// Token: 0x04000B60 RID: 2912
		[JsonProperty("authorName")]
		public string string_3 = string.Empty;

		// Token: 0x04000B61 RID: 2913
		[JsonProperty("authorId")]
		public string string_4 = string.Empty;

		// Token: 0x04000B62 RID: 2914
		[JsonProperty("releaseStatus")]
		public string string_5 = string.Empty;

		// Token: 0x04000B63 RID: 2915
		[JsonProperty("assetUrl")]
		public string string_6 = string.Empty;

		// Token: 0x04000B64 RID: 2916
		[JsonProperty("imageUrl")]
		public string string_7 = string.Empty;

		// Token: 0x04000B65 RID: 2917
		[JsonProperty("thumbnailImageUrl")]
		public string string_8 = string.Empty;

		// Token: 0x04000B66 RID: 2918
		[JsonProperty("platform")]
		public string string_9 = string.Empty;
	}
}
