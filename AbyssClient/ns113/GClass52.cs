using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using BestHTTP.JSON;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ns185;
using ns241;
using UnhollowerBaseLib;
using VRC;
using VRC.Core;

namespace ns113
{
	// Token: 0x02000097 RID: 151
	public class GClass52
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00012228 File Offset: 0x00010428
		private IEnumerator method_0(ApiFile apiFile_0, ApiFile.Version.FileDescriptor.Type type_0, string string_0, string string_1, long long_0, Action<ApiFile> action_0, Action<string> action_1, Action<long, long> action_2, GClass52.Delegate9 delegate9_0)
		{
			GClass52.Class43 @class = new GClass52.Class43(0);
			@class.gclass52_0 = this;
			@class.apiFile_0 = apiFile_0;
			@class.type_0 = type_0;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.long_0 = long_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.action_2 = action_2;
			@class.delegate9_0 = delegate9_0;
			return @class;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00012288 File Offset: 0x00010488
		internal static void smethod_0(GClass52.Delegate8 delegate8_0, ApiFile apiFile_0, string string_0, string string_1 = "", float float_5 = 0f)
		{
			GClass52.smethod_11(delegate8_0, apiFile_0, string_0, string_1, float_5);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000122A4 File Offset: 0x000104A4
		internal static string smethod_1(string string_0)
		{
			return GClass52.smethod_30(string_0);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000122B8 File Offset: 0x000104B8
		internal static void smethod_2(string string_0)
		{
			GClass52.smethod_3(string_0);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000122CC File Offset: 0x000104CC
		internal static void smethod_3(string string_0)
		{
			GClass52.smethod_5(string_0);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000122E0 File Offset: 0x000104E0
		internal static void smethod_4(string string_0)
		{
			GClass52.smethod_12(string_0);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000122F4 File Offset: 0x000104F4
		internal static void smethod_5(string string_0)
		{
			MelonLogger.Log(string.Concat(new string[]
			{
				"[",
				"API",
				"File",
				" ",
				"Debug",
				"]",
				" : ",
				string_0
			}));
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00012350 File Offset: 0x00010550
		internal static string smethod_6(string string_0)
		{
			string result;
			if (string_0 == ".vrcw")
			{
				result = "application/x-world";
			}
			else if (string_0 == ".vrca")
			{
				result = "application/x-avatar";
			}
			else if (string_0 == ".dll")
			{
				result = "application/x-msdownload";
			}
			else if (string_0 == ".unitypackage")
			{
				result = "application/gzip";
			}
			else if (string_0 == ".gz")
			{
				result = "application/gzip";
			}
			else if (string_0 == ".jpg")
			{
				result = "image/jpg";
			}
			else if (string_0 == ".png")
			{
				result = "image/png";
			}
			else if (string_0 == ".sig")
			{
				result = "application/x-rsync-signature";
			}
			else if (string_0 == ".delta")
			{
				result = "application/x-rsync-delta";
			}
			else
			{
				MelonLogger.LogWarning("Unknown file extension for mime-type" + ": " + string_0);
				result = "application/octet-stream";
			}
			return result;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00012444 File Offset: 0x00010644
		private bool method_1(ApiFile apiFile_0, string string_0, string string_1, long long_0, ApiFile.Version.FileDescriptor fileDescriptor_0, Action<ApiFile> action_0, Action<string> action_1)
		{
			bool result;
			long num;
			string text;
			if (fileDescriptor_0.status != 1)
			{
				GClass52.smethod_2("UploadFileComponent: (file record not in waiting status, done)");
				if (action_0 != null)
				{
					action_0(apiFile_0);
				}
				result = false;
			}
			else if (long_0 != (long)fileDescriptor_0.sizeInBytes)
			{
				if (action_1 != null)
				{
					action_1("File size does not match version descriptor");
				}
				result = false;
			}
			else if (string.Compare(string_1, fileDescriptor_0.md5) != 0)
			{
				if (action_1 != null)
				{
					action_1("File MD5 does not match version descriptor");
				}
				result = false;
			}
			else if (!Tools.GetFileSize(string_0, ref num, ref text))
			{
				if (action_1 != null)
				{
					action_1("Couldn't get file size");
				}
				result = false;
			}
			else if (num != long_0)
			{
				if (action_1 != null)
				{
					action_1("File size does not match input size");
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001250C File Offset: 0x0001070C
		internal static void smethod_7(string string_0)
		{
			GClass52.smethod_31(string_0);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00012520 File Offset: 0x00010720
		private static void smethod_8(ApiFile apiFile_0, bool bool_1, bool bool_2)
		{
			GClass52.smethod_19(apiFile_0, bool_1, bool_2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00012538 File Offset: 0x00010738
		private IEnumerator method_2(ApiFile apiFile_0, ApiFile.Version.FileDescriptor.Type type_0, string string_0, string string_1, long long_0, Action<ApiFile> action_0, Action<string> action_1, Action<long, long> action_2, GClass52.Delegate9 delegate9_0)
		{
			GClass52.Class47 @class = new GClass52.Class47(0);
			@class.gclass52_0 = this;
			@class.apiFile_0 = apiFile_0;
			@class.type_0 = type_0;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.long_0 = long_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.action_2 = action_2;
			@class.delegate9_0 = delegate9_0;
			return @class;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00012598 File Offset: 0x00010798
		internal static void smethod_9(GClass52.Delegate6 delegate6_0, ApiFile apiFile_0, string string_0)
		{
			if (apiFile_0 == null)
			{
				apiFile_0 = new ApiFile();
			}
			GClass52.smethod_2(string.Concat(new string[]
			{
				"Api",
				"File",
				" ",
				apiFile_0.ToStringBrief(),
				": ",
				"Operation Succeeded",
				"!"
			}));
			if (delegate6_0 != null)
			{
				delegate6_0(apiFile_0, string_0);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00012608 File Offset: 0x00010808
		internal static void smethod_10(GClass52.Delegate7 delegate7_0, ApiFile apiFile_0, string string_0, string string_1)
		{
			if (apiFile_0 == null)
			{
				apiFile_0 = new ApiFile();
			}
			GClass52.smethod_4(string.Concat(new string[]
			{
				"Api",
				"File",
				" ",
				apiFile_0.ToStringBrief(),
				": ",
				"Error",
				": ",
				string_0,
				"\n",
				string_1
			}));
			if (delegate7_0 != null)
			{
				delegate7_0(apiFile_0, string_0);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00012688 File Offset: 0x00010888
		internal static void smethod_11(GClass52.Delegate8 delegate8_0, ApiFile apiFile_0, string string_0, string string_1, float float_5)
		{
			GClass52.smethod_13(delegate8_0, apiFile_0, string_0, string_1, float_5);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000126A4 File Offset: 0x000108A4
		internal static void smethod_12(string string_0)
		{
			GClass52.smethod_14(string_0);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000126B8 File Offset: 0x000108B8
		private IEnumerator method_3(ApiFile apiFile_0, ApiFile.Version.FileDescriptor.Type type_0, string string_0, string string_1, long long_0, Action<ApiFile> action_0, Action<string> action_1, Action<long, long> action_2, GClass52.Delegate9 delegate9_0)
		{
			GClass52.Class36 @class = new GClass52.Class36(0);
			@class.gclass52_0 = this;
			@class.apiFile_0 = apiFile_0;
			@class.type_0 = type_0;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.long_0 = long_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.action_2 = action_2;
			@class.delegate9_0 = delegate9_0;
			return @class;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00012718 File Offset: 0x00010918
		internal static void smethod_13(GClass52.Delegate8 delegate8_0, ApiFile apiFile_0, string string_0, string string_1, float float_5)
		{
			if (apiFile_0 == null)
			{
				apiFile_0 = new ApiFile();
			}
			if (delegate8_0 != null)
			{
				delegate8_0(apiFile_0, string_0, string_1, float_5);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00012740 File Offset: 0x00010940
		public GClass52()
		{
			GClass52.remoteConfig_0 = new RemoteConfig();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000127E8 File Offset: 0x000109E8
		internal IEnumerator method_4(string string_0, string string_1, Action<GClass52.GEnum17> action_0, Action<string> action_1)
		{
			GClass52.Class28 @class = new GClass52.Class28(0);
			@class.gclass52_0 = this;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			return @class;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00012820 File Offset: 0x00010A20
		private float method_5(int int_2)
		{
			return this.float_1;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00012838 File Offset: 0x00010A38
		internal static void smethod_14(string string_0)
		{
			MelonLogger.LogError(string.Concat(new string[]
			{
				"[",
				"API",
				"File",
				" ",
				"Debug",
				"]",
				" : ",
				string_0
			}));
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00012894 File Offset: 0x00010A94
		internal static void smethod_15(string string_0, string string_1, string string_2, GClass52.Delegate6 delegate6_0, GClass52.Delegate7 delegate7_0, GClass52.Delegate8 delegate8_0, GClass52.Delegate9 delegate9_0)
		{
			GClass52.smethod_23(string_0, string_1, string_2, delegate6_0, delegate7_0, delegate8_0, delegate9_0);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000128B8 File Offset: 0x00010AB8
		protected IEnumerator method_6(string string_0)
		{
			GClass52.Class31 @class = new GClass52.Class31(0);
			@class.gclass52_0 = this;
			@class.string_0 = string_0;
			return @class;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000128DC File Offset: 0x00010ADC
		static void smethod_16(string string_0)
		{
			GClass52.smethod_24(string_0);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000128F0 File Offset: 0x00010AF0
		internal static bool smethod_17(GClass52.Delegate9 delegate9_0, GClass52.Delegate7 delegate7_0, ApiFile apiFile_0)
		{
			bool result;
			if (apiFile_0 == null)
			{
				GClass52.smethod_4("apiFile was null");
				result = true;
			}
			else if (delegate9_0 != null && delegate9_0(apiFile_0))
			{
				GClass52.smethod_2(string.Concat(new string[]
				{
					"Api",
					"File",
					" ",
					apiFile_0.ToStringBrief(),
					": ",
					"Operation cancelled"
				}));
				if (delegate7_0 != null)
				{
					delegate7_0(apiFile_0, "Cancelled by user.");
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00012978 File Offset: 0x00010B78
		internal static void smethod_18(GClass52.Delegate7 delegate7_0, ApiFile apiFile_0, string string_0, string string_1)
		{
			GClass52.smethod_10(delegate7_0, apiFile_0, string_0, string_1);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00012990 File Offset: 0x00010B90
		private static void smethod_19(ApiFile apiFile_0, bool bool_1, bool bool_2)
		{
			if (apiFile_0 == null || !apiFile_0.IsInitialized)
			{
				MelonLogger.LogWarning("<color=yellow>apiFile not initialized</color>");
			}
			else if (bool_2)
			{
				GClass52.smethod_2(string.Concat(new string[]
				{
					"< color = yellow > Processing { 3}: { 0}, { 1}, { 2}</ color > ",
					apiFile_0.IsWaitingForUpload() ? "waiting for upload" : "upload complete",
					apiFile_0.HasExistingOrPendingVersion() ? "has existing or pending version" : "no previous version",
					apiFile_0.IsLatestVersionQueued(bool_1) ? "latest version queued" : "latest version not queued",
					apiFile_0.name
				}));
			}
			if (apiFile_0 != null && apiFile_0.IsInitialized && bool_2)
			{
				Dictionary<string, Json.Token> dictionary = apiFile_0.ExtractApiFields();
				if (dictionary != null)
				{
					GClass52.smethod_2("<color=yellow>{0}</color>" + Tools.JsonEncode(dictionary));
				}
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00012A58 File Offset: 0x00010C58
		private IEnumerator method_7(ApiFile apiFile_0, ApiFile.Version.FileDescriptor.Type type_0, string string_0, string string_1, long long_0, ApiFile.Version.FileDescriptor fileDescriptor_0, Action<ApiFile> action_0, Action<string> action_1, Action<long, long> action_2, GClass52.Delegate9 delegate9_0)
		{
			GClass52.Class46 @class = new GClass52.Class46(0);
			@class.gclass52_0 = this;
			@class.apiFile_0 = apiFile_0;
			@class.type_0 = type_0;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.long_0 = long_0;
			@class.fileDescriptor_0 = fileDescriptor_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.action_2 = action_2;
			@class.delegate9_0 = delegate9_0;
			return @class;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00012AC0 File Offset: 0x00010CC0
		internal IEnumerator method_8(string string_0, string string_1, string string_2, Action action_0, Action<string> action_1)
		{
			GClass52.Class30 @class = new GClass52.Class30(0);
			@class.gclass52_0 = this;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.string_2 = string_2;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			return @class;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00012B00 File Offset: 0x00010D00
		internal static void smethod_20(GClass52.Delegate7 delegate7_0, ApiFile apiFile_0, string string_0, string string_1 = "")
		{
			GClass52.smethod_18(delegate7_0, apiFile_0, string_0, string_1);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		internal bool Boolean_0
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00012B18 File Offset: 0x00010D18
		internal static void smethod_21(GClass52.Delegate6 delegate6_0, ApiFile apiFile_0, string string_0)
		{
			GClass52.smethod_9(delegate6_0, apiFile_0, string_0);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00012B30 File Offset: 0x00010D30
		internal IEnumerator method_9(string string_0, string string_1, string string_2, GClass52.Delegate6 delegate6_0, GClass52.Delegate7 delegate7_0, GClass52.Delegate8 delegate8_0, GClass52.Delegate9 delegate9_0)
		{
			GClass52.Class25 @class = new GClass52.Class25(0);
			@class.gclass52_0 = this;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.string_2 = string_2;
			@class.delegate6_0 = delegate6_0;
			@class.delegate7_0 = delegate7_0;
			@class.delegate8_0 = delegate8_0;
			@class.delegate9_0 = delegate9_0;
			return @class;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00012B80 File Offset: 0x00010D80
		private static void smethod_22(ApiFile apiFile_0, bool bool_1, bool bool_2 = false)
		{
			GClass52.smethod_8(apiFile_0, bool_1, bool_2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00012B98 File Offset: 0x00010D98
		internal static void smethod_23(string string_0, string string_1, string string_2, GClass52.Delegate6 delegate6_0, GClass52.Delegate7 delegate7_0, GClass52.Delegate8 delegate8_0, GClass52.Delegate9 delegate9_0)
		{
			try
			{
				string extension = Path.GetExtension(string_0);
				MelonLogger.Log("Uploading" + " " + extension + "..");
			}
			catch (Exception ex)
			{
				MelonLogger.LogError(ex.ToString());
			}
			MelonCoroutines.Start(GClass84.GClass52_0.method_9(string_0, string_1, string_2, delegate6_0, delegate7_0, delegate8_0, delegate9_0));
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00012C04 File Offset: 0x00010E04
		static void smethod_24(string string_0)
		{
			MelonCoroutines.Start(GClass84.GClass52_0.method_6(string_0));
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00012C24 File Offset: 0x00010E24
		internal static void smethod_25(string string_0)
		{
			GClass52.smethod_7(string_0);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00012C38 File Offset: 0x00010E38
		internal static bool smethod_26(string string_0)
		{
			return GClass52.smethod_1(Path.GetExtension(string_0)) == "application/gzip";
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00012C5C File Offset: 0x00010E5C
		internal static void smethod_27(GClass52.Delegate6 delegate6_0, ApiFile apiFile_0, string string_0)
		{
			GClass52.smethod_21(delegate6_0, apiFile_0, string_0);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00012C74 File Offset: 0x00010E74
		internal IEnumerator method_10(string string_0, string string_1, Action action_0, Action<string> action_1)
		{
			GClass52.Class29 @class = new GClass52.Class29(0);
			@class.gclass52_0 = this;
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			return @class;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00012CAC File Offset: 0x00010EAC
		protected static void smethod_28(string string_0)
		{
			GClass52.smethod_16(string_0);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00012CC0 File Offset: 0x00010EC0
		internal static void smethod_29(string string_0, string string_1, string string_2, GClass52.Delegate6 delegate6_0, GClass52.Delegate7 delegate7_0, GClass52.Delegate8 delegate8_0, GClass52.Delegate9 delegate9_0)
		{
			GClass52.smethod_15(string_0, string_1, string_2, delegate6_0, delegate7_0, delegate8_0, delegate9_0);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00012CE4 File Offset: 0x00010EE4
		internal static string smethod_30(string string_0)
		{
			return GClass52.smethod_6(string_0);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00012CF8 File Offset: 0x00010EF8
		internal static void smethod_31(string string_0)
		{
			MelonLogger.LogWarning(string.Concat(new string[]
			{
				"[",
				"API",
				"File",
				" ",
				"Debug",
				"]",
				" : ",
				string_0
			}));
		}

		// Token: 0x040003B6 RID: 950
		private readonly int int_0 = 10485760;

		// Token: 0x040003B7 RID: 951
		private readonly int int_1 = 52428800;

		// Token: 0x040003B8 RID: 952
		private readonly float float_0 = 120f;

		// Token: 0x040003B9 RID: 953
		private readonly float float_1 = 600f;

		// Token: 0x040003BA RID: 954
		private readonly float float_2 = 2f;

		// Token: 0x040003BB RID: 955
		private readonly float float_3 = 10f;

		// Token: 0x040003BC RID: 956
		internal bool bool_0 = false;

		// Token: 0x040003BD RID: 957
		private readonly Regex[] regex_0 = new Regex[]
		{
			new Regex("/LightingData\\.asset$"),
			new Regex("/Lightmap-.*(\\.png|\\.exr)$"),
			new Regex("/ReflectionProbe-.*(\\.exr|\\.png)$"),
			new Regex("/Editor/Data/UnityExtensions/")
		};

		// Token: 0x040003BE RID: 958
		internal static RemoteConfig remoteConfig_0;

		// Token: 0x040003BF RID: 959
		private const float float_4 = 0.75f;

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600051E RID: 1310
		internal delegate void Delegate6(ApiFile apiFile_0, string string_0);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000523 RID: 1315
		internal delegate void Delegate7(ApiFile apiFile_0, string string_0);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000525 RID: 1317
		internal delegate void Delegate8(ApiFile apiFile_0, string string_0, string string_1, float float_0);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000529 RID: 1321
		internal delegate bool Delegate9(ApiFile apiFile_0);

		// Token: 0x0200009C RID: 156
		public enum GEnum17
		{
			// Token: 0x040003C1 RID: 961
			const_0,
			// Token: 0x040003C2 RID: 962
			const_1
		}

		// Token: 0x0200009D RID: 157
		[CompilerGenerated]
		private sealed class Class22
		{
			// Token: 0x0600052D RID: 1325 RVA: 0x00012D54 File Offset: 0x00010F54
			internal void method_0(long long_0, long long_1)
			{
				GClass52.smethod_0(this.delegate8_0, this.apiFile_0, "Preparing file for upload...", "Downloading previous version signature", Tools.DivideSafe((float)long_0, (float)long_1));
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00012D88 File Offset: 0x00010F88
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.bool_0 = false;
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x00012D9C File Offset: 0x00010F9C
			internal void method_2(GClass52.GEnum17 genum17_0)
			{
				if (genum17_0 == GClass52.GEnum17.const_1)
				{
					this.string_1 = this.string_2;
				}
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00012DBC File Offset: 0x00010FBC
			internal void method_3(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to optimize file for upload.", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00012DF8 File Offset: 0x00010FF8
			internal void method_4(ApiContainer apiContainer_0)
			{
				this.apiFile_0 = apiContainer_0.Model.Cast<ApiFile>();
				this.bool_0 = false;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00012E20 File Offset: 0x00011020
			internal void method_5(Il2CppStructArray<byte> il2CppStructArray_0)
			{
				this.string_3 = Tools.GetTempFileName(".sig", ref this.string_0, this.apiFile_0.id, true);
				if (!string.IsNullOrEmpty(this.string_3))
				{
					try
					{
						File.WriteAllBytes(this.string_3, il2CppStructArray_0);
					}
					catch (Exception ex)
					{
						this.string_3 = null;
						this.string_0 = string.Concat(new string[]
						{
							"Failed",
							" ",
							"to",
							" ",
							"write",
							" ",
							"signature",
							" ",
							"temp",
							" ",
							"file",
							":",
							"\n",
							ex.Message
						});
					}
					this.bool_0 = false;
				}
				else
				{
					this.string_0 = string.Concat(new string[]
					{
						"Failed",
						" ",
						"to",
						" ",
						"create",
						" ",
						"temp",
						" ",
						"file",
						": ",
						"\n",
						this.string_0
					});
					this.bool_0 = false;
				}
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00012FA4 File Offset: 0x000111A4
			internal void method_6(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to upload file.", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00012FE0 File Offset: 0x000111E0
			internal void method_7(ApiFile apiFile_1)
			{
				GClass52.smethod_2("Successfully uploaded file.");
				this.apiFile_0 = apiFile_1;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00013000 File Offset: 0x00011200
			internal void method_8(ApiContainer apiContainer_0)
			{
				this.string_0 = apiContainer_0.Error;
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = true;
				}
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00013038 File Offset: 0x00011238
			internal void method_9(ApiFile apiFile_1)
			{
				GClass52.smethod_2("Successfully uploaded file signature.");
				this.apiFile_0 = apiFile_1;
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x00013058 File Offset: 0x00011258
			internal void method_10(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to upload file signature.", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00013094 File Offset: 0x00011294
			internal void method_11(long long_0, long long_1)
			{
				GClass52.smethod_0(this.delegate8_0, this.apiFile_0, "Uploading file...", string.Empty, Tools.DivideSafe((float)long_0, (float)long_1));
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x000130C8 File Offset: 0x000112C8
			internal void method_12(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to upload file delta.", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x00013104 File Offset: 0x00011304
			internal void method_13(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to create file delta for upload.", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x00013140 File Offset: 0x00011340
			internal void method_14(long long_0, long long_1)
			{
				GClass52.smethod_0(this.delegate8_0, this.apiFile_0, "Uploading file delta...", string.Empty, Tools.DivideSafe((float)long_0, (float)long_1));
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x00013174 File Offset: 0x00011374
			internal void method_15(string string_4)
			{
				this.string_0 = string_4;
				this.bool_0 = false;
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x00013190 File Offset: 0x00011390
			internal void method_16(long long_0, long long_1)
			{
				GClass52.smethod_0(this.delegate8_0, this.apiFile_0, "Uploading file signature...", string.Empty, Tools.DivideSafe((float)long_0, (float)long_1));
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x000131C4 File Offset: 0x000113C4
			internal void method_17(ApiFile apiFile_1)
			{
				GClass52.smethod_2("Successfully uploaded file delta.");
				this.apiFile_0 = apiFile_1;
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x000131E4 File Offset: 0x000113E4
			internal void method_18(string string_4)
			{
				GClass52.smethod_20(this.delegate7_0, this.apiFile_0, "Failed to generate file signature!", string_4);
				GClass52.smethod_28(this.apiFile_0.id);
				this.bool_2 = true;
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x00012D88 File Offset: 0x00010F88
			internal void method_19(ApiContainer apiContainer_0)
			{
				this.bool_0 = false;
			}

			// Token: 0x040003C3 RID: 963
			public ApiFile apiFile_0;

			// Token: 0x040003C4 RID: 964
			public bool bool_0;

			// Token: 0x040003C5 RID: 965
			public string string_0;

			// Token: 0x040003C6 RID: 966
			public bool bool_1;

			// Token: 0x040003C7 RID: 967
			public string string_1;

			// Token: 0x040003C8 RID: 968
			public string string_2;

			// Token: 0x040003C9 RID: 969
			public GClass52.Delegate7 delegate7_0;

			// Token: 0x040003CA RID: 970
			public bool bool_2;

			// Token: 0x040003CB RID: 971
			public string string_3;

			// Token: 0x040003CC RID: 972
			public GClass52.Delegate8 delegate8_0;
		}

		// Token: 0x0200009E RID: 158
		[CompilerGenerated]
		private sealed class Class23
		{
			// Token: 0x06000543 RID: 1347 RVA: 0x00013220 File Offset: 0x00011420
			internal void method_0()
			{
				this.bool_0 = true;
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00013220 File Offset: 0x00011420
			internal void method_1()
			{
				this.bool_0 = true;
			}

			// Token: 0x040003CD RID: 973
			public bool bool_0;
		}

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		[Serializable]
		private sealed class Class24
		{
			// Token: 0x06000546 RID: 1350 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_0()
			{
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_1()
			{
			}

			// Token: 0x040003CE RID: 974
			public static readonly GClass52.Class24 class24_0 = new GClass52.Class24();

			// Token: 0x040003CF RID: 975
			public static Action action_0;

			// Token: 0x040003D0 RID: 976
			public static Action action_1;
		}

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		private sealed class Class26
		{
			// Token: 0x0600054F RID: 1359 RVA: 0x0001590C File Offset: 0x00013B0C
			internal bool method_0(Regex regex_0)
			{
				return regex_0.IsMatch(this.string_0);
			}

			// Token: 0x040003F7 RID: 1015
			public string string_0;
		}

		// Token: 0x020000A2 RID: 162
		[CompilerGenerated]
		private sealed class Class27
		{
			// Token: 0x06000551 RID: 1361 RVA: 0x00015928 File Offset: 0x00013B28
			internal bool method_0(string string_1)
			{
				return string.Compare(string_1, this.string_0) == 0;
			}

			// Token: 0x040003F8 RID: 1016
			public string string_0;
		}

		// Token: 0x020000A7 RID: 167
		[CompilerGenerated]
		private sealed class Class32
		{
			// Token: 0x06000566 RID: 1382 RVA: 0x00016C3C File Offset: 0x00014E3C
			internal void method_0(ApiFile apiFile_1, string string_1)
			{
				Action<string> action = this.action_0;
				if (action != null)
				{
					action(string_1);
				}
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x00016C5C File Offset: 0x00014E5C
			internal void method_1(long long_0, long long_1)
			{
				Action<long, long> action = this.action_1;
				if (action != null)
				{
					action(long_0, long_1);
				}
			}

			// Token: 0x04000440 RID: 1088
			public Action<string> action_0;

			// Token: 0x04000441 RID: 1089
			public string string_0;

			// Token: 0x04000442 RID: 1090
			public Action<long, long> action_1;

			// Token: 0x04000443 RID: 1091
			public ApiFile apiFile_0;
		}

		// Token: 0x020000A8 RID: 168
		[CompilerGenerated]
		private sealed class Class33
		{
			// Token: 0x06000569 RID: 1385 RVA: 0x00016C7C File Offset: 0x00014E7C
			internal void method_0(ApiContainer apiContainer_0)
			{
				this.class32_0.string_0 = IL2CPP.Il2CppStringToManaged(apiContainer_0.Cast<ApiDictContainer>().ResponseDictionary["url"].Pointer);
				this.bool_0 = false;
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x00016CBC File Offset: 0x00014EBC
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"start",
					" ",
					"upload",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = true;
				}
			}

			// Token: 0x04000444 RID: 1092
			public bool bool_0;

			// Token: 0x04000445 RID: 1093
			public string string_0;

			// Token: 0x04000446 RID: 1094
			public bool bool_1;

			// Token: 0x04000447 RID: 1095
			public GClass52.Class32 class32_0;
		}

		// Token: 0x020000A9 RID: 169
		[CompilerGenerated]
		private sealed class Class34
		{
			// Token: 0x0600056D RID: 1389 RVA: 0x00016D44 File Offset: 0x00014F44
			internal void method_0(string string_1)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"upload",
					" ",
					"file",
					": ",
					string_1
				});
				this.bool_0 = false;
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00016DB0 File Offset: 0x00014FB0
			internal void method_1()
			{
				this.bool_0 = false;
			}

			// Token: 0x04000448 RID: 1096
			public bool bool_0;

			// Token: 0x04000449 RID: 1097
			public string string_0;
		}

		// Token: 0x020000AA RID: 170
		[CompilerGenerated]
		private sealed class Class35
		{
			// Token: 0x06000570 RID: 1392 RVA: 0x00016DC4 File Offset: 0x00014FC4
			internal void method_0(ApiContainer apiContainer_0)
			{
				MelonLogger.LogWarning("YOU CAN IGNORE THE FOLLOWING CASTING ERROR!");
				this.class32_0.apiFile_0 = apiContainer_0.Model.Cast<ApiFile>();
				this.bool_0 = false;
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00016DF8 File Offset: 0x00014FF8
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"finish",
					" ",
					"upload",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = false;
				}
			}

			// Token: 0x0400044A RID: 1098
			public bool bool_0;

			// Token: 0x0400044B RID: 1099
			public string string_0;

			// Token: 0x0400044C RID: 1100
			public bool bool_1;

			// Token: 0x0400044D RID: 1101
			public GClass52.Class32 class32_0;
		}

		// Token: 0x020000AC RID: 172
		[CompilerGenerated]
		private sealed class Class37
		{
			// Token: 0x06000578 RID: 1400 RVA: 0x0001737C File Offset: 0x0001557C
			internal void method_0(ApiFile apiFile_1, string string_0)
			{
				if (this.fileStream_0 != null)
				{
					this.fileStream_0.Close();
				}
				Action<string> action = this.action_0;
				if (action != null)
				{
					action(string_0);
				}
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x000173B4 File Offset: 0x000155B4
			internal void method_1(long long_2, long long_3)
			{
				Action<long, long> action = this.action_1;
				if (action != null)
				{
					action(this.long_0 + long_2, this.long_1);
				}
			}

			// Token: 0x04000460 RID: 1120
			public FileStream fileStream_0;

			// Token: 0x04000461 RID: 1121
			public Action<string> action_0;

			// Token: 0x04000462 RID: 1122
			public ApiFile.UploadStatus uploadStatus_0;

			// Token: 0x04000463 RID: 1123
			public List<string> list_0;

			// Token: 0x04000464 RID: 1124
			public long long_0;

			// Token: 0x04000465 RID: 1125
			public Action<long, long> action_1;

			// Token: 0x04000466 RID: 1126
			public long long_1;

			// Token: 0x04000467 RID: 1127
			public ApiFile apiFile_0;

			// Token: 0x04000468 RID: 1128
			public Action<long, long> action_2;
		}

		// Token: 0x020000AD RID: 173
		[CompilerGenerated]
		private sealed class Class38
		{
			// Token: 0x0600057A RID: 1402 RVA: 0x000173E0 File Offset: 0x000155E0
			internal void method_0(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed to query multipart upload",
					" ",
					"status",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = true;
				}
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00017444 File Offset: 0x00015644
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.class37_0.uploadStatus_0 = apiContainer_0.Model.Cast<ApiFile.UploadStatus>();
				this.bool_0 = false;
				GClass52.smethod_2(string.Concat(new string[]
				{
					"Found existing multipart upload status (",
					"next",
					" ",
					"part",
					" = ",
					this.class37_0.uploadStatus_0.nextPartNumber.ToString(),
					")"
				}));
			}

			// Token: 0x04000469 RID: 1129
			public bool bool_0;

			// Token: 0x0400046A RID: 1130
			public string string_0;

			// Token: 0x0400046B RID: 1131
			public bool bool_1;

			// Token: 0x0400046C RID: 1132
			public GClass52.Class37 class37_0;
		}

		// Token: 0x020000AE RID: 174
		[CompilerGenerated]
		private sealed class Class39
		{
			// Token: 0x0400046D RID: 1133
			public string string_0;

			// Token: 0x0400046E RID: 1134
			public int int_0;

			// Token: 0x0400046F RID: 1135
			public GClass52.Class37 class37_0;
		}

		// Token: 0x020000AF RID: 175
		[CompilerGenerated]
		private sealed class Class40
		{
			// Token: 0x0600057E RID: 1406 RVA: 0x000174CC File Offset: 0x000156CC
			internal void method_0(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"start",
					" ",
					"part",
					" ",
					"upload",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x00017550 File Offset: 0x00015750
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.class39_0.string_0 = IL2CPP.Il2CppStringToManaged(apiContainer_0.Cast<ApiDictContainer>().ResponseDictionary["url"].Pointer);
				this.bool_0 = false;
			}

			// Token: 0x04000470 RID: 1136
			public bool bool_0;

			// Token: 0x04000471 RID: 1137
			public string string_0;

			// Token: 0x04000472 RID: 1138
			public GClass52.Class39 class39_0;
		}

		// Token: 0x020000B0 RID: 176
		[CompilerGenerated]
		private sealed class Class41
		{
			// Token: 0x06000581 RID: 1409 RVA: 0x00017590 File Offset: 0x00015790
			internal void method_0(string string_1)
			{
				if (!string.IsNullOrEmpty(string_1))
				{
					this.class39_0.class37_0.list_0.Add(string_1);
				}
				this.class39_0.class37_0.long_0 = this.class39_0.class37_0.long_0 + (long)this.class39_0.int_0;
				this.bool_0 = false;
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x000175F4 File Offset: 0x000157F4
			internal void method_1(string string_1)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"upload",
					" ",
					"data",
					": ",
					string_1
				});
				this.bool_0 = false;
			}

			// Token: 0x04000473 RID: 1139
			public bool bool_0;

			// Token: 0x04000474 RID: 1140
			public string string_0;

			// Token: 0x04000475 RID: 1141
			public GClass52.Class39 class39_0;
		}

		// Token: 0x020000B1 RID: 177
		[CompilerGenerated]
		private sealed class Class42
		{
			// Token: 0x06000584 RID: 1412 RVA: 0x00017660 File Offset: 0x00015860
			internal void method_0(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Failed",
					" ",
					"to",
					" ",
					"finish",
					" ",
					"upload",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = true;
				}
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x000176E8 File Offset: 0x000158E8
			internal void method_1(ApiContainer apiContainer_0)
			{
				GClass70.smethod_117(ConsoleColor.DarkYellow, "YOU CAN IGNORE THE FOLLOWING CASTING ERROR!", GClass70.Enum1.const_0);
				this.class37_0.apiFile_0 = apiContainer_0.Model.Cast<ApiFile>();
				this.bool_0 = false;
			}

			// Token: 0x04000476 RID: 1142
			public bool bool_0;

			// Token: 0x04000477 RID: 1143
			public string string_0;

			// Token: 0x04000478 RID: 1144
			public bool bool_1;

			// Token: 0x04000479 RID: 1145
			public GClass52.Class37 class37_0;
		}

		// Token: 0x020000B3 RID: 179
		[CompilerGenerated]
		private sealed class Class44
		{
			// Token: 0x0600058D RID: 1421 RVA: 0x00018208 File Offset: 0x00016408
			internal void method_0(ApiFile apiFile_0, string string_0)
			{
				Action<string> action = this.action_0;
				if (action != null)
				{
					action(string_0);
				}
			}

			// Token: 0x04000495 RID: 1173
			public Action<string> action_0;
		}

		// Token: 0x020000B4 RID: 180
		[CompilerGenerated]
		private sealed class Class45
		{
			// Token: 0x0600058E RID: 1422 RVA: 0x00018228 File Offset: 0x00016428
			internal void method_0(ApiContainer apiContainer_0)
			{
				this.string_0 = string.Concat(new string[]
				{
					"Couldn't",
					" ",
					"verify",
					" ",
					"upload",
					" ",
					"status",
					": ",
					apiContainer_0.Error
				});
				this.bool_0 = false;
				if (apiContainer_0.Code == 400)
				{
					this.bool_1 = true;
				}
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x000182B0 File Offset: 0x000164B0
			internal void method_1(ApiContainer apiContainer_0)
			{
				this.bool_0 = false;
			}

			// Token: 0x04000496 RID: 1174
			public bool bool_0;

			// Token: 0x04000497 RID: 1175
			public string string_0;

			// Token: 0x04000498 RID: 1176
			public bool bool_1;
		}
	}
}
