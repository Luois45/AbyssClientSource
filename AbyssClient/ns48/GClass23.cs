using System;
using System.Text;
using Il2CppSystem.Collections.Generic;
using ns234;
using VRC.Core;

namespace ns48
{
	// Token: 0x02000040 RID: 64
	public class GClass23
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public GClass23(ApiAvatar apiAvatar_0)
		{
			this.string_1 = apiAvatar_0.id;
			this.string_0 = apiAvatar_0.name;
			this.string_2 = apiAvatar_0.assetUrl;
			this.string_4 = apiAvatar_0.authorId;
			this.string_6 = apiAvatar_0.authorName;
			this.string_5 = string.Empty;
			this.string_3 = apiAvatar_0.thumbnailImageUrl;
			this.int_1 = apiAvatar_0.supportedPlatforms;
			this.int_0 = ((apiAvatar_0.releaseStatus != "private") ? ((apiAvatar_0.releaseStatus == "public") ? 1 : 255) : 0);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006DF8 File Offset: 0x00004FF8
		internal ApiAvatar method_0()
		{
			return new ApiAvatar
			{
				name = Encoding.UTF8.GetString(Convert.FromBase64String(this.string_0)),
				id = this.string_1,
				assetUrl = this.string_2,
				thumbnailImageUrl = this.string_3,
				authorId = this.string_4,
				authorName = Encoding.UTF8.GetString(Convert.FromBase64String(this.string_6)),
				description = Encoding.UTF8.GetString(Convert.FromBase64String(this.string_0)),
				releaseStatus = (Class94.class94_0.bool_2 ? "public" : ((this.int_0 == 0) ? "private" : ((this.int_0 == 1) ? "public" : "unavailable"))),
				unityVersion = "2018.4.20f1",
				version = 1,
				apiVersion = 1,
				Endpoint = "avatars",
				Populated = true,
				assetVersion = new AssetVersion("2018.4.20f1", 0),
				tags = this.List_0
			};
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006F14 File Offset: 0x00005114
		public GClass23()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00006F84 File Offset: 0x00005184
		public List<string> List_0
		{
			get
			{
				List<string> list = new List<string>();
				list.Add("avatar");
				return list;
			}
		}

		// Token: 0x040000E0 RID: 224
		public string string_0 = string.Empty;

		// Token: 0x040000E1 RID: 225
		public string string_1 = string.Empty;

		// Token: 0x040000E2 RID: 226
		public string string_2 = string.Empty;

		// Token: 0x040000E3 RID: 227
		public string string_3 = string.Empty;

		// Token: 0x040000E4 RID: 228
		public string string_4 = string.Empty;

		// Token: 0x040000E5 RID: 229
		public string string_5 = string.Empty;

		// Token: 0x040000E6 RID: 230
		public string string_6 = string.Empty;

		// Token: 0x040000E7 RID: 231
		public int int_0 = 1;

		// Token: 0x040000E8 RID: 232
		public int int_1 = 3;
	}
}
