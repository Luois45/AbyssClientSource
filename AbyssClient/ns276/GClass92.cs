using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text.RegularExpressions;
using MelonLoader;
using ns185;
using ns238;
using ns414;

namespace ns276
{
	// Token: 0x02000234 RID: 564
	public static class GClass92
	{
		// Token: 0x06001939 RID: 6457 RVA: 0x00082688 File Offset: 0x00080888
		internal static void smethod_0()
		{
			GClass92.smethod_2();
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0008269C File Offset: 0x0008089C
		private static void smethod_1()
		{
			GClass92.smethod_6();
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000826B0 File Offset: 0x000808B0
		internal static void smethod_2()
		{
			GClass125 gclass = GClass92.gclass125_0;
			if (gclass != null)
			{
				gclass.Dispose();
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000826D0 File Offset: 0x000808D0
		public static void smethod_3()
		{
			GClass92.smethod_0();
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000826E4 File Offset: 0x000808E4
		internal static void smethod_4()
		{
			GClass92.smethod_9();
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000826F8 File Offset: 0x000808F8
		public static void smethod_5()
		{
			GClass92.smethod_4();
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0008270C File Offset: 0x0008090C
		private static void smethod_6()
		{
			string text = Path.Combine(MelonUtils.UserDataDirectory, "BundleVerifier");
			Directory.CreateDirectory(text);
			GClass92.string_0 = Path.Combine(text, "BundleVerifier.exe");
			string path = Path.Combine(text, "version.txt");
			if (File.Exists(path))
			{
				string a = File.ReadAllText(path);
				if (a == "1.1-2019.4.31")
				{
					return;
				}
			}
			File.Copy(Path.Combine(MelonUtils.GameDirectory, "UnityPlayer.dll"), Path.Combine(text, "UnityPlayer.dll"), true);
			using (ZipArchive zipArchive = new ZipArchive(Assembly.GetExecutingAssembly().GetManifestResourceStream("AbyssClient.Resources.BundleVerifier.zip"), ZipArchiveMode.Read, false))
			{
				foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
				{
					string text2 = Path.Combine(text, zipArchiveEntry.FullName);
					bool flag;
					Directory.CreateDirectory((flag = (Path.GetFileName(text2).Length == 0)) ? text2 : Path.GetDirectoryName(text2));
					if (!flag)
					{
						zipArchiveEntry.ExtractToFile(text2, true);
					}
				}
				File.WriteAllText(path, "1.1-2019.4.31");
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0008284C File Offset: 0x00080A4C
		internal static ValueTuple<string, string> smethod_7(string string_3)
		{
			Match match = GClass92.regex_0.Match(string_3);
			ValueTuple<string, string> result;
			if (!match.Success)
			{
				result = new ValueTuple<string, string>(string.Empty, string_3);
			}
			else
			{
				char[] array = match.Groups[1].Value.ToCharArray();
				Array.Reverse(array);
				result = new ValueTuple<string, string>(new string(array), match.Groups[2].Value);
			}
			return result;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000828BC File Offset: 0x00080ABC
		private static void smethod_8()
		{
			GClass92.smethod_1();
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000828D0 File Offset: 0x00080AD0
		internal static void smethod_9()
		{
			GClass92.gclass125_0 = new GClass125(Path.Combine(MelonUtils.UserDataDirectory, "BadBundleHashes.bin"));
			GClass92.gclass125_1 = new GClass125(null);
			if (Class96.smethod_3())
			{
				try
				{
					GClass92.smethod_8();
				}
				catch (IOException ex)
				{
					GClass70.smethod_36("Unable to extract bundle verifier app, the mod will not work", GClass70.Enum1.const_0);
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x04000EF2 RID: 3826
		internal static GClass125 gclass125_0;

		// Token: 0x04000EF3 RID: 3827
		internal static GClass125 gclass125_1;

		// Token: 0x04000EF4 RID: 3828
		internal static string string_0;

		// Token: 0x04000EF5 RID: 3829
		private const string string_1 = "1.1-2019.4.31";

		// Token: 0x04000EF6 RID: 3830
		internal const string string_2 = "ASBundleVerifier";

		// Token: 0x04000EF7 RID: 3831
		private static readonly Regex regex_0 = new Regex("file_([^/]+)/([^/]+)");
	}
}
