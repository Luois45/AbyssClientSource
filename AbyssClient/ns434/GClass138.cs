using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ns113;
using ns185;
using ns241;
using ns366;
using ns424;
using ns425;
using ns75;
using UnityEngine;
using VRC;
using VRC.Core;

namespace ns434
{
	// Token: 0x020000E3 RID: 227
	public class GClass138 : GClass130
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x0001CE54 File Offset: 0x0001B054
		internal void method_2()
		{
			GClass138.Class53 @class = new GClass138.Class53();
			@class.apiAvatar_0 = GClass84.smethod_1122();
			if (@class.apiAvatar_0 != null && !(@class.apiAvatar_0.authorId != GClass84.smethod_1645()))
			{
				CursorLockMode lockState = Cursor.lockState;
				bool visible = Cursor.visible;
				Console.Write("Select new image: ");
				Cursor.lockState = 0;
				Cursor.visible = true;
				string text = Class174.smethod_0();
				if (string.IsNullOrEmpty(text))
				{
					while (string.IsNullOrEmpty(text))
					{
						Console.Write("New image url: ");
						GClass84.smethod_733();
						text = Console.ReadLine();
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					Cursor.lockState = lockState;
					Cursor.visible = visible;
					GClass70.smethod_38(text, GClass70.Enum1.const_0);
					string name = @class.apiAvatar_0.name;
					string text2 = @class.apiAvatar_0.unityVersion.ToLower();
					string text3 = @class.apiAvatar_0.platform.ToLower();
					string text4 = ApiWorld.VERSION.ApiVersion.ToString().ToLower();
					if (string.IsNullOrEmpty(text4))
					{
						text4 = "4";
					}
					string text5 = string.Concat(new string[]
					{
						"Avatar",
						" - ",
						name,
						" - ",
						"Image",
						" - ",
						text2,
						"_",
						text4,
						"_",
						text3,
						"_",
						"Release"
					});
					string value = ApiFile.ParseFileIdFromFileAPIUrl(@class.apiAvatar_0.imageUrl);
					if (!string.IsNullOrEmpty(value))
					{
						GClass52.smethod_29(text, value, text5, new GClass52.Delegate6(@class.method_0), new GClass52.Delegate7(GClass138.Class51.class51_0.method_1), new GClass52.Delegate8(GClass138.Class51.class51_0.method_30), new GClass52.Delegate9(GClass138.Class51.class51_0.method_19));
					}
				}
				else
				{
					GClass70.smethod_36("Couldn't open filedialog or path was null", GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001D070 File Offset: 0x0001B270
		internal void method_3()
		{
			this.method_83();
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001D084 File Offset: 0x0001B284
		private void method_4(ApiContainer apiContainer_0)
		{
			this.method_75(apiContainer_0);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001D098 File Offset: 0x0001B298
		internal void method_5(string string_8)
		{
			this.method_73(string_8);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		internal void method_6(bool bool_5)
		{
			this.method_29(bool_5);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		internal void method_7(bool bool_5)
		{
			this.bool_4 = bool_5;
			this.gclass129_0.bool_3 = bool_5;
			GClass40.smethod_1();
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
		internal void method_8()
		{
			this.method_94();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		internal void method_9(string string_8)
		{
			this.method_118(new ApiAvatar
			{
				assetUrl = string_8
			});
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001D11C File Offset: 0x0001B31C
		[CompilerGenerated]
		private void method_10(ApiContainer apiContainer_0)
		{
			this.method_38(apiContainer_0);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0001D130 File Offset: 0x0001B330
		internal void method_11()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1122();
			if (apiAvatar != null && apiAvatar.authorId == GClass84.smethod_1645())
			{
				Console.Write("Enter new avatar name: ");
				GClass84.smethod_733();
				string name = Console.ReadLine();
				GClass84.smethod_1024();
				apiAvatar.name = name;
				apiAvatar.Save(new Action<ApiContainer>(GClass138.Class51.class51_0.method_17), new Action<ApiContainer>(GClass138.Class51.class51_0.method_12));
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001D1CC File Offset: 0x0001B3CC
		private void method_12(ApiFile apiFile_2, string string_8)
		{
			this.method_25(apiFile_2, string_8);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
		private void method_13(ApiContainer apiContainer_0)
		{
			this.method_91(apiContainer_0);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
		internal void method_14(bool bool_5)
		{
			this.bool_0 = bool_5;
			this.gclass129_0.bool_0 = bool_5;
			GClass40.smethod_1();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001D220 File Offset: 0x0001B420
		[DebuggerStepThrough]
		private Task<string> method_15(ApiWorld apiWorld_2)
		{
			GClass138.Class70 @class = new GClass138.Class70();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@class.gclass138_0 = this;
			@class.apiWorld_0 = apiWorld_2;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class70>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001D26C File Offset: 0x0001B46C
		private string method_16()
		{
			return this.method_17();
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001D280 File Offset: 0x0001B480
		private string method_17()
		{
			return "avtr_" + Guid.NewGuid().ToString();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		internal void method_18(string string_8)
		{
			this.method_118(new ApiAvatar
			{
				assetUrl = string_8
			});
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		internal void method_19(string string_8)
		{
			this.method_52(string_8);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001D2C0 File Offset: 0x0001B4C0
		private void method_20(ApiFile apiFile_2, string string_8)
		{
			this.method_57(apiFile_2, string_8);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
		internal void method_21()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1122();
			if (apiAvatar != null && apiAvatar.authorId == GClass84.smethod_1645())
			{
				GClass70.smethod_38("Enter new avatar description:", GClass70.Enum1.const_0);
				GClass84.smethod_733();
				string description = Console.ReadLine();
				GClass84.smethod_1024();
				apiAvatar.description = description;
				apiAvatar.Save(new Action<ApiContainer>(GClass138.Class51.class51_0.method_23), new Action<ApiContainer>(GClass138.Class51.class51_0.method_18));
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001D374 File Offset: 0x0001B574
		private void method_22(ApiFile apiFile_2, string string_8)
		{
			GClass138.Class60 @class = new GClass138.Class60();
			@class.gclass138_0 = this;
			@class.apiFile_0 = apiFile_2;
			GClass70.smethod_38("OnUploadVrcaAsynSuccess", GClass70.Enum1.const_0);
			if (this.bool_2)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Original",
					" ",
					"name",
					": ",
					this.apiAvatar_0.name
				}), GClass70.Enum1.const_0);
				@class.string_0 = string.Empty;
			}
			else
			{
				@class.string_0 = this.apiAvatar_0.name;
			}
			while (string.IsNullOrEmpty(@class.string_0))
			{
				Console.Write("New name: ");
				GClass84.smethod_733();
				@class.string_0 = Console.ReadLine();
			}
			if (this.bool_3)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Original",
					" ",
					"description",
					": ",
					this.apiAvatar_0.description
				}), GClass70.Enum1.const_0);
				@class.string_1 = string.Empty;
			}
			else
			{
				@class.string_1 = this.apiAvatar_0.description;
			}
			while (string.IsNullOrEmpty(@class.string_1))
			{
				Console.Write("New description: ");
				GClass84.smethod_733();
				@class.string_1 = Console.ReadLine();
			}
			this.method_99(new Action(@class.method_0));
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
		internal void method_23(ApiAvatar apiAvatar_2)
		{
			GClass138.Class54 @class = new GClass138.Class54();
			@class.gclass138_0 = this;
			@class.apiAvatar_0 = apiAvatar_2;
			if (@class.apiAvatar_0 == null)
			{
				GClass70.smethod_36("AA is null", GClass70.Enum1.const_0);
			}
			else
			{
				this.apiAvatar_0 = @class.apiAvatar_0;
				this.string_1 = this.method_92();
				API.Fetch<ApiAvatar>(this.string_1, new Action<ApiContainer>(@class.method_2), new Action<ApiContainer>(@class.method_3), false);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001D550 File Offset: 0x0001B750
		private void method_24(ApiContainer apiContainer_0)
		{
			this.apiWorld_1 = apiContainer_0.Model.Cast<ApiWorld>();
			if (this.apiWorld_1 == null)
			{
				GClass70.smethod_36("Couldn't fetch ApiWorld", GClass70.Enum1.const_0);
			}
			else
			{
				this.method_72(this.apiWorld_1);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001D594 File Offset: 0x0001B794
		private void method_25(ApiFile apiFile_2, string string_8)
		{
			GClass70.smethod_38("OnUploadVrcwAsyncFailure", GClass70.Enum1.const_0);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001D5AC File Offset: 0x0001B7AC
		internal void method_26(ApiWorld apiWorld_2)
		{
			this.method_74(apiWorld_2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		internal void method_27(string string_8)
		{
			this.method_18(string_8);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
		public override void vmethod_23()
		{
			this.method_120();
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
		private void method_28(ApiContainer apiContainer_0)
		{
			this.method_13(apiContainer_0);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		internal void method_29(bool bool_5)
		{
			this.method_116(bool_5);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001D68C File Offset: 0x0001B88C
		internal void method_30()
		{
			ApiWorld apiWorld = GClass84.smethod_585();
			if (apiWorld != null)
			{
				this.method_84(apiWorld.id);
			}
			else
			{
				GClass70.smethod_36("Couldn't fetch APIWorld", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		private string method_31(string string_8)
		{
			return this.method_60(string_8);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
		private void method_32(ApiContainer apiContainer_0)
		{
			this.method_104(apiContainer_0);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		private void method_33(ApiFile apiFile_2, string string_8)
		{
			this.method_80(apiFile_2, string_8);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001D700 File Offset: 0x0001B900
		internal void method_34(Action action_0)
		{
			this.method_85(action_0);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0001D714 File Offset: 0x0001B914
		internal void method_35()
		{
			this.method_62();
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001D728 File Offset: 0x0001B928
		private void method_36(ApiFile apiFile_2, string string_8)
		{
			this.method_45(apiFile_2, string_8);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001D740 File Offset: 0x0001B940
		internal void method_37(bool bool_5)
		{
			this.method_14(bool_5);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001D754 File Offset: 0x0001B954
		private void method_38(ApiContainer apiContainer_0)
		{
			this.method_24(apiContainer_0);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001D768 File Offset: 0x0001B968
		internal void method_39(string string_8)
		{
			this.method_128(string_8);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001D77C File Offset: 0x0001B97C
		internal void method_40(string string_8)
		{
			this.method_19(string_8);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001D790 File Offset: 0x0001B990
		internal void method_41()
		{
			this.method_130();
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001D7A4 File Offset: 0x0001B9A4
		private void method_42(ApiContainer apiContainer_0)
		{
			this.method_76(apiContainer_0);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001D7B8 File Offset: 0x0001B9B8
		private bool method_43()
		{
			foreach (string text in Directory.EnumerateFiles(GClass138.string_3))
			{
				if (!text.EndsWith("UBPU.exe"))
				{
					try
					{
						File.Delete(text);
					}
					catch (Exception)
					{
					}
				}
			}
			foreach (string text2 in Directory.EnumerateDirectories(GClass138.string_3))
			{
				if (!text2.EndsWith("VrcaStore"))
				{
					try
					{
						Directory.Delete(text2, true);
					}
					catch (Exception)
					{
					}
				}
			}
			return Directory.EnumerateFiles(GClass138.string_3).Count<string>() == 1 && Directory.EnumerateDirectories(GClass138.string_3).Count<string>() == 1;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001D924 File Offset: 0x0001BB24
		internal void method_44(bool bool_5)
		{
			this.method_101(bool_5);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001D938 File Offset: 0x0001BB38
		private void method_45(ApiFile apiFile_2, string string_8)
		{
			this.method_22(apiFile_2, string_8);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001D950 File Offset: 0x0001BB50
		private void method_46(ApiFile apiFile_2, string string_8)
		{
			GClass138.Class67 @class = new GClass138.Class67();
			@class.gclass138_0 = this;
			@class.apiFile_0 = apiFile_2;
			GClass70.smethod_38("OnUploadVrcwAsynSuccess", GClass70.Enum1.const_0);
			this.method_99(new Action(@class.method_0));
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001D990 File Offset: 0x0001BB90
		internal void method_47()
		{
			this.apiAvatar_0 = GClass84.smethod_1157();
			if (this.apiAvatar_0 != null)
			{
				this.method_118(this.apiAvatar_0);
			}
			else
			{
				GClass70.smethod_36("Couldn't fetch ApiAvatar", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001D9CC File Offset: 0x0001BBCC
		private void method_48(ApiContainer apiContainer_0)
		{
			GClass70.smethod_38("OnApiWorldPostSuccess", GClass70.Enum1.const_0);
			this.method_43();
			GClass70.smethod_38("Check Your Worlds, Upload Completed!", GClass70.Enum1.const_0);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
		private string method_49()
		{
			return this.method_113();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001DA0C File Offset: 0x0001BC0C
		[DebuggerStepThrough]
		private Task<string> method_50(string string_8)
		{
			GClass138.Class71 @class = new GClass138.Class71();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@class.gclass138_0 = this;
			@class.string_0 = string_8;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class71>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001DA58 File Offset: 0x0001BC58
		private void method_51(ApiFile apiFile_2, string string_8)
		{
			this.method_56(apiFile_2, string_8);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001DA70 File Offset: 0x0001BC70
		internal void method_52(string string_8)
		{
			if (GClass84.smethod_1428(string_8, GClass84.smethod_593("avtr_")) == "avtr_")
			{
				if (GClass84.smethod_591(string_8, "avtr_********-****-****-****-************", GClass84.smethod_1307()))
				{
					this.method_121(string_8);
					return;
				}
			}
			else if (GClass84.smethod_1428(string_8, GClass84.smethod_593("wrld_")) == "wrld_" && GClass84.smethod_591(string_8, "wrld_********-****-****-****-************", GClass84.smethod_1307()))
			{
				this.method_84(string_8);
				return;
			}
			GClass70.smethod_36("Wrong ID!", GClass70.Enum1.const_0);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
		private bool method_53(string string_8, ref string string_9)
		{
			try
			{
				string[] array = File.ReadAllLines(string_8);
				int int_ = 0;
				foreach (string text in array)
				{
					int num = GClass84.smethod_1198(text, "avtr_", int_);
					bool flag = false;
					if (num == -1)
					{
						num = GClass84.smethod_1198(text, "wrld_", int_);
					}
					else
					{
						flag = true;
					}
					if (num != -1)
					{
						string text2 = GClass84.smethod_1204(text, num, GClass84.smethod_593("avtr_749445a8-d9bf-4d48-b077-d18b776f66f7"));
						if (GClass84.smethod_591(text2, flag ? "avtr_********-****-****-****-************" : "wrld_********-****-****-****-************", GClass84.smethod_1307()))
						{
							string_9 = text2;
							return true;
						}
						int_ = num + 1;
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			return false;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		internal void method_54()
		{
			this.method_2();
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		internal void method_55()
		{
			this.method_93();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		private void method_56(ApiFile apiFile_2, string string_8)
		{
			this.method_46(apiFile_2, string_8);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001DC04 File Offset: 0x0001BE04
		private void method_57(ApiFile apiFile_2, string string_8)
		{
			this.method_90(apiFile_2, string_8);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001DC1C File Offset: 0x0001BE1C
		[DebuggerStepThrough]
		private Task<bool> method_58(string string_8, string string_9, string string_10)
		{
			GClass138.Class68 @class = new GClass138.Class68();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
			@class.gclass138_0 = this;
			@class.string_0 = string_8;
			@class.string_1 = string_9;
			@class.string_2 = string_10;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class68>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001DC78 File Offset: 0x0001BE78
		internal void method_59(bool bool_5)
		{
			this.bool_2 = bool_5;
			this.gclass129_0.bool_1 = bool_5;
			GClass40.smethod_1();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		private string method_60(string string_8)
		{
			string text = string.Empty;
			IEnumerable<string> enumerable = Directory.EnumerateFiles(string_8 + "_" + "dump").Select(new Func<string, FileInfo>(GClass138.Class51.class51_0.method_10)).OrderBy(new Func<FileInfo, DateTime>(GClass138.Class51.class51_0.method_13)).Select(new Func<FileInfo, string>(GClass138.Class51.class51_0.method_11));
			string result;
			if (enumerable.Count<string>() != 1)
			{
				foreach (string text2 in enumerable)
				{
					if (string.IsNullOrEmpty(Path.GetExtension(text2)))
					{
						text = text2;
					}
				}
				result = text;
			}
			else
			{
				result = enumerable.ElementAt(0);
			}
			return result;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001DD9C File Offset: 0x0001BF9C
		internal void method_61()
		{
			this.method_11();
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		internal void method_62()
		{
			this.method_117();
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		[DebuggerStepThrough]
		private Task<string> method_63(ApiAvatar apiAvatar_2)
		{
			GClass138.Class69 @class = new GClass138.Class69();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@class.gclass138_0 = this;
			@class.apiAvatar_0 = apiAvatar_2;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class69>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001DE10 File Offset: 0x0001C010
		internal void method_64(string string_8)
		{
			GClass70.smethod_117(ConsoleColor.DarkYellow, string_8, GClass70.Enum1.const_0);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001DE28 File Offset: 0x0001C028
		private string method_65()
		{
			string text = string.Empty;
			IEnumerable<string> enumerable = Directory.EnumerateFiles(GClass138.string_3).Select(new Func<string, FileInfo>(GClass138.Class51.class51_0.method_7)).OrderBy(new Func<FileInfo, DateTime>(GClass138.Class51.class51_0.method_9)).Select(new Func<FileInfo, string>(GClass138.Class51.class51_0.method_15));
			string result;
			if (enumerable.Any<string>())
			{
				foreach (string text2 in enumerable)
				{
					if (text2.EndsWith(".LZ4HC"))
					{
						text = text2;
					}
				}
				result = text;
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001DF0C File Offset: 0x0001C10C
		internal void method_66()
		{
			this.method_95();
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001DF20 File Offset: 0x0001C120
		internal void method_67(string string_8)
		{
			this.method_125(string_8);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001DF34 File Offset: 0x0001C134
		internal void method_68(ApiAvatar apiAvatar_2)
		{
			this.method_23(apiAvatar_2);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001DF48 File Offset: 0x0001C148
		private string method_69()
		{
			return this.method_115();
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001DF5C File Offset: 0x0001C15C
		private void method_70(ApiFile apiFile_2, string string_8)
		{
			this.method_71(apiFile_2, string_8);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001DF74 File Offset: 0x0001C174
		private void method_71(ApiFile apiFile_2, string string_8)
		{
			this.method_126(apiFile_2, string_8);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001DF8C File Offset: 0x0001C18C
		internal void method_72(ApiWorld apiWorld_2)
		{
			this.method_26(apiWorld_2);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		internal void method_73(string string_8)
		{
			this.method_64(string_8);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001DFB4 File Offset: 0x0001C1B4
		internal void method_74(ApiWorld apiWorld_2)
		{
			GClass138.Class61 @class = new GClass138.Class61();
			@class.gclass138_0 = this;
			@class.apiWorld_0 = apiWorld_2;
			if (@class.apiWorld_0 == null)
			{
				GClass70.smethod_36("AW is null", GClass70.Enum1.const_0);
			}
			else
			{
				this.apiWorld_1 = @class.apiWorld_0;
				this.string_2 = this.method_100();
				API.Fetch<ApiAvatar>(this.string_2, new Action<ApiContainer>(@class.method_0), new Action<ApiContainer>(@class.method_3), false);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001E034 File Offset: 0x0001C234
		private void method_75(ApiContainer apiContainer_0)
		{
			this.method_48(apiContainer_0);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001E048 File Offset: 0x0001C248
		private void method_76(ApiContainer apiContainer_0)
		{
			this.apiAvatar_0 = apiContainer_0.Model.Cast<ApiAvatar>();
			if (this.apiAvatar_0 == null)
			{
				GClass70.smethod_36("Couldn't fetch ApiAvatar", GClass70.Enum1.const_0);
			}
			else
			{
				this.method_118(this.apiAvatar_0);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001E08C File Offset: 0x0001C28C
		internal void method_77(bool bool_5)
		{
			this.method_7(bool_5);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		private void method_78(ApiContainer apiContainer_0)
		{
			GClass70.smethod_38("OnApiAvatarPostSuccess", GClass70.Enum1.const_0);
			this.method_43();
			GClass70.smethod_38("Check Your Avatar, Upload Completed!", GClass70.Enum1.const_0);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001E0CC File Offset: 0x0001C2CC
		internal void method_79()
		{
			this.method_54();
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		private void method_80(ApiFile apiFile_2, string string_8)
		{
			this.method_96(apiFile_2, string_8);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001E0F8 File Offset: 0x0001C2F8
		private void method_81(ApiFile apiFile_2, string string_8)
		{
			this.method_136(apiFile_2, string_8);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001E110 File Offset: 0x0001C310
		private void method_82(ApiContainer apiContainer_0)
		{
			this.method_134(apiContainer_0);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001E124 File Offset: 0x0001C324
		internal void method_83()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1122();
			if (apiAvatar != null && !(apiAvatar.authorId != GClass84.smethod_1645()))
			{
				apiAvatar.Delete(new Action<ApiContainer>(GClass138.Class51.class51_0.method_2), new Action<ApiContainer>(GClass138.Class51.class51_0.method_6));
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001E1A0 File Offset: 0x0001C3A0
		internal void method_84(string string_8)
		{
			this.method_67(string_8);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		internal void method_85(Action action_0)
		{
			List<Action> obj = this.list_0;
			lock (obj)
			{
				this.list_0.Add(action_0);
				this.bool_1 = true;
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001E204 File Offset: 0x0001C404
		public override void vmethod_19()
		{
			this.method_66();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001E218 File Offset: 0x0001C418
		internal void method_86(string string_8)
		{
			if (string.IsNullOrEmpty(string_8))
			{
				GClass70.smethod_36("AvatarId was empty", GClass70.Enum1.const_0);
			}
			else
			{
				API.Fetch<ApiAvatar>(string_8, new Action<ApiContainer>(this.method_105), new Action<ApiContainer>(GClass138.Class51.class51_0.method_22), false);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001E278 File Offset: 0x0001C478
		internal void method_87()
		{
			this.method_61();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001E28C File Offset: 0x0001C48C
		internal void method_88()
		{
			this.method_55();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		internal void method_89()
		{
			this.method_131();
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001E2B4 File Offset: 0x0001C4B4
		private void method_90(ApiFile apiFile_2, string string_8)
		{
			GClass138.Class64 @class = new GClass138.Class64();
			@class.gclass138_0 = this;
			@class.string_0 = string_8;
			GClass70.smethod_38("OnUploadVrcwAsyncSuccess", GClass70.Enum1.const_0);
			this.apiFile_0 = apiFile_2;
			this.method_5("WorldAssetBundle" + ": " + apiFile_2.GetFileURL());
			Task.Run(new Func<Task>(@class.method_0));
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001E314 File Offset: 0x0001C514
		private void method_91(ApiContainer apiContainer_0)
		{
			GClass70.smethod_38("OnApiWorldPostFailure", GClass70.Enum1.const_0);
			if (!this.method_43())
			{
				GClass70.smethod_51("Error while cleaning up the AssetBundles directory, you can probably ignore this.", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001E344 File Offset: 0x0001C544
		private string method_92()
		{
			return this.method_16();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001E358 File Offset: 0x0001C558
		internal void method_93()
		{
			GClass138.Class52 @class = new GClass138.Class52();
			@class.apiuser_0 = GClass84.smethod_1623();
			if (@class.apiuser_0 != null)
			{
				this.player_0 = GClass84.smethod_1677().FirstOrDefault(new Func<Player, bool>(@class.method_0));
				if (!this.player_0)
				{
					GClass70.smethod_36("Couldn't fetch Player", GClass70.Enum1.const_0);
				}
				else
				{
					this.apiuser_0 = this.player_0.Method_Internal_get_APIUser_0();
					if (this.apiuser_0 != null)
					{
						this.apiAvatar_0 = GClass84.smethod_1075(this.player_0);
						if (this.apiAvatar_0 != null)
						{
							this.method_118(this.apiAvatar_0);
						}
						else
						{
							GClass70.smethod_36("Couldn't fetch ApiAvatar", GClass70.Enum1.const_0);
						}
					}
					else
					{
						GClass70.smethod_36("Couldn't fetch APIUser", GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001E41C File Offset: 0x0001C61C
		internal void method_94()
		{
			this.method_119();
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001E430 File Offset: 0x0001C630
		internal void method_95()
		{
			if (this.bool_1)
			{
				List<Action> obj = this.list_0;
				lock (obj)
				{
					List<Action> list = this.list_1;
					this.list_1 = this.list_0;
					this.list_0 = list;
					this.bool_1 = false;
				}
				foreach (Action action in this.list_1)
				{
					action();
					this.list_0.Remove(action);
				}
				this.list_1.Clear();
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		private void method_96(ApiFile apiFile_2, string string_8)
		{
			GClass70.smethod_38("OnUploadVrcaAsyncFailure", GClass70.Enum1.const_0);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001E510 File Offset: 0x0001C710
		internal void method_97(string string_8)
		{
			this.method_86(string_8);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001E524 File Offset: 0x0001C724
		private void method_98(ApiContainer apiContainer_0)
		{
			GClass70.smethod_38("OnApiAvatarPostFailure", GClass70.Enum1.const_0);
			if (!this.method_43())
			{
				GClass70.smethod_51("Error while cleaning up the AssetBundles directory, you can probably ignore this.", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001E554 File Offset: 0x0001C754
		internal void method_99(Action action_0)
		{
			this.method_34(action_0);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001E568 File Offset: 0x0001C768
		private string method_100()
		{
			return this.method_129();
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001E57C File Offset: 0x0001C77C
		internal void method_101(bool bool_5)
		{
			this.method_59(bool_5);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001E590 File Offset: 0x0001C790
		internal void method_102()
		{
			this.method_3();
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
		internal void method_103(bool bool_5)
		{
			this.method_37(bool_5);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		private void method_104(ApiContainer apiContainer_0)
		{
			this.method_78(apiContainer_0);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001E5CC File Offset: 0x0001C7CC
		[CompilerGenerated]
		private void method_105(ApiContainer apiContainer_0)
		{
			this.method_42(apiContainer_0);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		private string method_106()
		{
			return this.method_69();
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		[DebuggerStepThrough]
		private Task<string> method_107(string string_8)
		{
			GClass138.Class73 @class = new GClass138.Class73();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@class.gclass138_0 = this;
			@class.string_0 = string_8;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class73>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001E640 File Offset: 0x0001C840
		private string method_108()
		{
			return "wrld_" + Guid.NewGuid().ToString();
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0001E66C File Offset: 0x0001C86C
		internal void method_109(bool bool_5)
		{
			this.method_77(bool_5);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0001E680 File Offset: 0x0001C880
		internal void method_110(string[] string_8)
		{
			try
			{
				MethodInfo methodInfo = this.methodInfo_0;
				if (methodInfo != null)
				{
					methodInfo.Invoke(null, new object[]
					{
						string_8
					});
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		private void method_111(ApiFile apiFile_2, string string_8)
		{
			this.method_12(apiFile_2, string_8);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		[DebuggerStepThrough]
		private Task<string> method_112(string string_8)
		{
			GClass138.Class72 @class = new GClass138.Class72();
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@class.gclass138_0 = this;
			@class.string_0 = string_8;
			@class.int_0 = -1;
			@class.asyncTaskMethodBuilder_0.Start<GClass138.Class72>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001E730 File Offset: 0x0001C930
		private string method_113()
		{
			return this.method_65();
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001E744 File Offset: 0x0001C944
		internal void method_114(string[] string_8)
		{
			this.method_110(string_8);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0001E758 File Offset: 0x0001C958
		private string method_115()
		{
			string text = string.Empty;
			GClass70.smethod_24(GClass138.string_3, GClass70.Enum1.const_0);
			IEnumerable<string> enumerable = Directory.EnumerateFiles(GClass138.string_3).Select(new Func<string, FileInfo>(GClass138.Class51.class51_0.method_20)).OrderBy(new Func<FileInfo, DateTime>(GClass138.Class51.class51_0.method_5)).Select(new Func<FileInfo, string>(GClass138.Class51.class51_0.method_16));
			string result;
			if (enumerable.Any<string>())
			{
				foreach (string text2 in enumerable)
				{
					GClass70.smethod_24(text2, GClass70.Enum1.const_0);
					if (text2.EndsWith(".xml"))
					{
						text = text2;
					}
				}
				result = text;
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0001E850 File Offset: 0x0001CA50
		internal void method_116(bool bool_5)
		{
			this.bool_3 = bool_5;
			this.gclass129_0.bool_2 = bool_5;
			GClass40.smethod_1();
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0001E878 File Offset: 0x0001CA78
		internal void method_117()
		{
			GClass129.smethod_3();
			this.gclass129_0 = GClass129.gclass129_0;
			this.bool_0 = this.gclass129_0.bool_0;
			this.bool_2 = this.gclass129_0.bool_1;
			this.bool_3 = this.gclass129_0.bool_2;
			this.bool_4 = this.gclass129_0.bool_3;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001E8DC File Offset: 0x0001CADC
		internal void method_118(ApiAvatar apiAvatar_2)
		{
			this.method_68(apiAvatar_2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001E8F0 File Offset: 0x0001CAF0
		internal void method_119()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1122();
			if (apiAvatar != null)
			{
				this.method_118(apiAvatar);
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001E910 File Offset: 0x0001CB10
		internal void method_120()
		{
			this.method_137();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001E924 File Offset: 0x0001CB24
		internal void method_121(string string_8)
		{
			this.method_97(string_8);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001E938 File Offset: 0x0001CB38
		internal void method_122()
		{
			this.method_47();
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0001E94C File Offset: 0x0001CB4C
		private void method_123(ApiFile apiFile_2, string string_8)
		{
			GClass138.Class57 @class = new GClass138.Class57();
			@class.gclass138_0 = this;
			@class.apiFile_0 = apiFile_2;
			GClass70.smethod_38("OnUploadVrcaAsyncSuccess", GClass70.Enum1.const_0);
			this.apiFile_1 = @class.apiFile_0;
			this.method_5("AvatarAssetBundle" + ": " + @class.apiFile_0.GetFileURL());
			Task.Run(new Func<Task>(@class.method_1));
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		internal void method_124()
		{
			this.method_122();
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		internal void method_125(string string_8)
		{
			if (string.IsNullOrEmpty(string_8))
			{
				GClass70.smethod_36("WorldID was empty", GClass70.Enum1.const_0);
			}
			else
			{
				API.Fetch<ApiWorld>(string_8, new Action<ApiContainer>(this.method_10), new Action<ApiContainer>(GClass138.Class51.class51_0.method_24), false);
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001EA2C File Offset: 0x0001CC2C
		private void method_126(ApiFile apiFile_2, string string_8)
		{
			GClass70.smethod_38("OnUploadImageAsyncFailure", GClass70.Enum1.const_0);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001EA44 File Offset: 0x0001CC44
		internal void method_127(string[] string_8)
		{
			this.method_114(string_8);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001EA58 File Offset: 0x0001CC58
		internal void method_128(string string_8)
		{
			this.method_9(string_8);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001EA6C File Offset: 0x0001CC6C
		private string method_129()
		{
			return this.method_108();
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001EA80 File Offset: 0x0001CC80
		internal void method_130()
		{
			this.method_30();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001EA94 File Offset: 0x0001CC94
		internal void method_131()
		{
			this.method_21();
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
		internal void method_132(string string_8)
		{
			this.method_27(string_8);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001EABC File Offset: 0x0001CCBC
		private string method_133(string string_8)
		{
			return this.method_31(string_8);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
		private void method_134(ApiContainer apiContainer_0)
		{
			this.method_98(apiContainer_0);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
		private int method_135(byte[] byte_0, byte[] byte_1)
		{
			int i = 0;
			IL_30:
			while (i < byte_0.Length - byte_1.Length)
			{
				bool flag = true;
				int j = 0;
				while (j < byte_1.Length)
				{
					if (byte_0[i + j] == byte_1[j])
					{
						j++;
					}
					else
					{
						flag = false;
						IL_29:
						if (!flag)
						{
							i++;
							goto IL_30;
						}
						return i;
					}
				}
				goto IL_29;
			}
			return -1;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001EB3C File Offset: 0x0001CD3C
		private void method_136(ApiFile apiFile_2, string string_8)
		{
			this.method_123(apiFile_2, string_8);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0001EB54 File Offset: 0x0001CD54
		internal void method_137()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			this.method_35();
			try
			{
				foreach (string text in Assembly.GetExecutingAssembly().GetManifestResourceNames())
				{
					if (GClass84.smethod_360(text, GClass84.smethod_593(".dll")) == ".dll" || GClass84.smethod_360(text, GClass84.smethod_593(".exe")) == ".exe")
					{
						using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text))
						{
							using (MemoryStream memoryStream = new MemoryStream((int)manifestResourceStream.Length))
							{
								manifestResourceStream.CopyTo(memoryStream);
								Assembly assembly = Assembly.Load(memoryStream.ToArray());
								if (text.EndsWith("UBPU.exe"))
								{
									this.assembly_0 = assembly;
								}
							}
						}
					}
				}
				this.type_0 = this.assembly_0.GetTypes().First(new Func<Type, bool>(GClass138.Class51.class51_0.method_25));
				this.methodInfo_0 = this.type_0.GetMethods(BindingFlags.Static | BindingFlags.NonPublic).First(new Func<MethodInfo, bool>(GClass138.Class51.class51_0.method_28));
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			if (Directory.Exists(GClass138.string_3))
			{
				Directory.EnumerateDirectories(GClass138.string_3).ToList<string>().ForEach(new Action<string>(GClass138.Class51.class51_0.method_26));
				Directory.EnumerateFiles(GClass138.string_3).ToList<string>().ForEach(new Action<string>(GClass138.Class51.class51_0.method_3));
				if (Directory.Exists(GClass138.string_4))
				{
					Directory.EnumerateFiles(GClass138.string_4).ToList<string>().ForEach(new Action<string>(GClass138.Class51.class51_0.method_8));
				}
				else
				{
					Directory.CreateDirectory(GClass138.string_4);
				}
			}
			else
			{
				Directory.CreateDirectory(GClass138.string_3);
				Directory.CreateDirectory(GClass138.string_4);
			}
		}

		// Token: 0x0400058A RID: 1418
		internal GClass129 gclass129_0;

		// Token: 0x0400058B RID: 1419
		internal bool bool_0 = true;

		// Token: 0x0400058C RID: 1420
		internal volatile bool bool_1;

		// Token: 0x0400058D RID: 1421
		internal List<Action> list_0 = new List<Action>(10);

		// Token: 0x0400058E RID: 1422
		internal List<Action> list_1 = new List<Action>(10);

		// Token: 0x0400058F RID: 1423
		private string string_1 = string.Empty;

		// Token: 0x04000590 RID: 1424
		private Player player_0;

		// Token: 0x04000591 RID: 1425
		private APIUser apiuser_0;

		// Token: 0x04000592 RID: 1426
		private ApiAvatar apiAvatar_0;

		// Token: 0x04000593 RID: 1427
		private ApiAvatar apiAvatar_1;

		// Token: 0x04000594 RID: 1428
		private ApiWorld apiWorld_0;

		// Token: 0x04000595 RID: 1429
		private string string_2 = string.Empty;

		// Token: 0x04000596 RID: 1430
		private ApiWorld apiWorld_1;

		// Token: 0x04000597 RID: 1431
		private ApiFile apiFile_0;

		// Token: 0x04000598 RID: 1432
		private ApiFile apiFile_1;

		// Token: 0x04000599 RID: 1433
		private static string string_3 = Path.Combine(Path.GetDirectoryName(Application.dataPath), "AssetBundles");

		// Token: 0x0400059A RID: 1434
		private static string string_4 = Path.Combine(GClass138.string_3, "VrcaStore");

		// Token: 0x0400059B RID: 1435
		private static string string_5 = Path.Combine(GClass138.string_3, "UBPU.exe");

		// Token: 0x0400059C RID: 1436
		private static string string_6 = Path.Combine(Path.GetDirectoryName(Application.dataPath), "ReuploaderModData");

		// Token: 0x0400059D RID: 1437
		private static string string_7 = Path.Combine(GClass138.string_6, "name.txt");

		// Token: 0x0400059E RID: 1438
		private Assembly assembly_0;

		// Token: 0x0400059F RID: 1439
		private Type type_0;

		// Token: 0x040005A0 RID: 1440
		private MethodInfo methodInfo_0;

		// Token: 0x040005A1 RID: 1441
		internal bool bool_2 = false;

		// Token: 0x040005A2 RID: 1442
		internal bool bool_3 = false;

		// Token: 0x040005A3 RID: 1443
		internal bool bool_4 = false;

		// Token: 0x020000E4 RID: 228
		[CompilerGenerated]
		[Serializable]
		private sealed class Class51
		{
			// Token: 0x060007B0 RID: 1968 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_0(ApiFile apiFile_0)
			{
				return false;
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
			internal void method_1(ApiFile apiFile_0, string string_0)
			{
				GClass70.smethod_36("Couldn't change avatar image (UPLOAD)" + ", " + string_0, GClass70.Enum1.const_0);
			}

			// Token: 0x060007B3 RID: 1971 RVA: 0x0001EE18 File Offset: 0x0001D018
			internal void method_2(ApiContainer apiContainer_0)
			{
				GClass70.smethod_38("Successfully deleted avatar", GClass70.Enum1.const_0);
			}

			// Token: 0x060007B4 RID: 1972 RVA: 0x0001EE30 File Offset: 0x0001D030
			internal void method_3(string string_0)
			{
				try
				{
					File.Delete(string_0);
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x060007B5 RID: 1973 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_4(ApiFile apiFile_0)
			{
				return false;
			}

			// Token: 0x060007B7 RID: 1975 RVA: 0x0001EE74 File Offset: 0x0001D074
			internal DateTime method_5(FileInfo fileInfo_0)
			{
				return fileInfo_0.CreationTime;
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x0001EE88 File Offset: 0x0001D088
			internal void method_6(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't delete avatar", GClass70.Enum1.const_0);
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
			internal FileInfo method_7(string string_0)
			{
				return new FileInfo(string_0);
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x0001EE30 File Offset: 0x0001D030
			internal void method_8(string string_0)
			{
				try
				{
					File.Delete(string_0);
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x0001EE74 File Offset: 0x0001D074
			internal DateTime method_9(FileInfo fileInfo_0)
			{
				return fileInfo_0.CreationTime;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
			internal FileInfo method_10(string string_0)
			{
				return new FileInfo(string_0);
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			internal string method_11(FileInfo fileInfo_0)
			{
				return fileInfo_0.FullName;
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
			internal void method_12(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't change avatar name", GClass70.Enum1.const_0);
			}

			// Token: 0x060007BF RID: 1983 RVA: 0x0001EE74 File Offset: 0x0001D074
			internal DateTime method_13(FileInfo fileInfo_0)
			{
				return fileInfo_0.CreationTime;
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_14(ApiFile apiFile_0)
			{
				return false;
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			internal string method_15(FileInfo fileInfo_0)
			{
				return fileInfo_0.FullName;
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			internal string method_16(FileInfo fileInfo_0)
			{
				return fileInfo_0.FullName;
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
			internal void method_17(ApiContainer apiContainer_0)
			{
				GClass70.smethod_38("Successfully changed avatar name", GClass70.Enum1.const_0);
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
			internal void method_18(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't change avatar description", GClass70.Enum1.const_0);
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_19(ApiFile apiFile_0)
			{
				return false;
			}

			// Token: 0x060007C6 RID: 1990 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
			internal FileInfo method_20(string string_0)
			{
				return new FileInfo(string_0);
			}

			// Token: 0x060007C7 RID: 1991 RVA: 0x0001EF10 File Offset: 0x0001D110
			internal void method_21(ApiContainer apiContainer_0)
			{
				GClass70.smethod_38("Successfully changed avatar image", GClass70.Enum1.const_0);
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x0001EF28 File Offset: 0x0001D128
			internal void method_22(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't fetch avatar (API)", GClass70.Enum1.const_0);
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x0001EF40 File Offset: 0x0001D140
			internal void method_23(ApiContainer apiContainer_0)
			{
				GClass70.smethod_38("Successfully changed avatar description", GClass70.Enum1.const_0);
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x0001EF58 File Offset: 0x0001D158
			internal void method_24(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't fetch World (API)", GClass70.Enum1.const_0);
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x0001EF70 File Offset: 0x0001D170
			internal bool method_25(Type type_0)
			{
				return type_0.Name.Equals("Program");
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x0001EF90 File Offset: 0x0001D190
			internal void method_26(string string_0)
			{
				try
				{
					if (string_0.EndsWith("_dump"))
					{
						Directory.Delete(string_0, true);
					}
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
			internal void method_27(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36("Couldn't change avatar image (POST)", GClass70.Enum1.const_0);
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
			internal bool method_28(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name.Equals("Main");
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_29(ApiFile apiFile_0)
			{
				return false;
			}

			// Token: 0x060007D0 RID: 2000 RVA: 0x00004908 File Offset: 0x00002B08
			internal void method_30(ApiFile apiFile_0, string string_0, string string_1, float float_0)
			{
			}

			// Token: 0x040005A4 RID: 1444
			public static readonly GClass138.Class51 class51_0 = new GClass138.Class51();

			// Token: 0x040005A5 RID: 1445
			public static Func<Type, bool> func_0;

			// Token: 0x040005A6 RID: 1446
			public static Func<MethodInfo, bool> func_1;

			// Token: 0x040005A7 RID: 1447
			public static Action<string> action_0;

			// Token: 0x040005A8 RID: 1448
			public static Action<string> action_1;

			// Token: 0x040005A9 RID: 1449
			public static Action<string> action_2;

			// Token: 0x040005AA RID: 1450
			public static Action<ApiContainer> action_3;

			// Token: 0x040005AB RID: 1451
			public static Action<ApiContainer> action_4;

			// Token: 0x040005AC RID: 1452
			public static Action<ApiContainer> action_5;

			// Token: 0x040005AD RID: 1453
			public static Action<ApiContainer> action_6;

			// Token: 0x040005AE RID: 1454
			public static GClass52.Delegate7 delegate7_0;

			// Token: 0x040005AF RID: 1455
			public static GClass52.Delegate8 delegate8_0;

			// Token: 0x040005B0 RID: 1456
			public static GClass52.Delegate9 delegate9_0;

			// Token: 0x040005B1 RID: 1457
			public static Action<ApiContainer> action_7;

			// Token: 0x040005B2 RID: 1458
			public static Action<ApiContainer> action_8;

			// Token: 0x040005B3 RID: 1459
			public static Action<ApiContainer> action_9;

			// Token: 0x040005B4 RID: 1460
			public static Action<ApiContainer> action_10;

			// Token: 0x040005B5 RID: 1461
			public static Action<ApiContainer> action_11;

			// Token: 0x040005B6 RID: 1462
			public static GClass52.Delegate9 delegate9_1;

			// Token: 0x040005B7 RID: 1463
			public static GClass52.Delegate9 delegate9_2;

			// Token: 0x040005B8 RID: 1464
			public static Action<ApiContainer> action_12;

			// Token: 0x040005B9 RID: 1465
			public static GClass52.Delegate9 delegate9_3;

			// Token: 0x040005BA RID: 1466
			public static GClass52.Delegate9 delegate9_4;

			// Token: 0x040005BB RID: 1467
			public static Func<string, FileInfo> func_2;

			// Token: 0x040005BC RID: 1468
			public static Func<FileInfo, DateTime> func_3;

			// Token: 0x040005BD RID: 1469
			public static Func<FileInfo, string> func_4;

			// Token: 0x040005BE RID: 1470
			public static Func<string, FileInfo> func_5;

			// Token: 0x040005BF RID: 1471
			public static Func<FileInfo, DateTime> func_6;

			// Token: 0x040005C0 RID: 1472
			public static Func<FileInfo, string> func_7;

			// Token: 0x040005C1 RID: 1473
			public static Func<string, FileInfo> func_8;

			// Token: 0x040005C2 RID: 1474
			public static Func<FileInfo, DateTime> func_9;

			// Token: 0x040005C3 RID: 1475
			public static Func<FileInfo, string> func_10;
		}

		// Token: 0x020000E5 RID: 229
		[CompilerGenerated]
		private sealed class Class52
		{
			// Token: 0x060007D2 RID: 2002 RVA: 0x0001F000 File Offset: 0x0001D200
			internal bool method_0(Player player_0)
			{
				return player_0.Method_Internal_get_APIUser_0() != null && player_0.Method_Internal_get_APIUser_0().id.Equals(this.apiuser_0.id);
			}

			// Token: 0x040005C4 RID: 1476
			public APIUser apiuser_0;
		}

		// Token: 0x020000E6 RID: 230
		[CompilerGenerated]
		private sealed class Class53
		{
			// Token: 0x060007D4 RID: 2004 RVA: 0x0001F034 File Offset: 0x0001D234
			internal void method_0(ApiFile apiFile_0, string string_0)
			{
				this.apiAvatar_0.imageUrl = apiFile_0.GetFileURL();
				this.apiAvatar_0.Save(new Action<ApiContainer>(GClass138.Class51.class51_0.method_21), new Action<ApiContainer>(GClass138.Class51.class51_0.method_27));
			}

			// Token: 0x040005C5 RID: 1477
			public ApiAvatar apiAvatar_0;
		}

		// Token: 0x020000E7 RID: 231
		[CompilerGenerated]
		private sealed class Class54
		{
			// Token: 0x060007D5 RID: 2005 RVA: 0x0001F0A8 File Offset: 0x0001D2A8
			[DebuggerStepThrough]
			internal Task method_0()
			{
				GClass138.Class54.Class55 @class = new GClass138.Class54.Class55();
				@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@class.class54_0 = this;
				@class.int_0 = -1;
				@class.asyncTaskMethodBuilder_0.Start<GClass138.Class54.Class55>(ref @class);
				return @class.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x0001F0EC File Offset: 0x0001D2EC
			internal void method_1(ApiFile apiFile_0, string string_0, string string_1, float float_0)
			{
				this.gclass138_0.method_5("VRCA Uploading Progress" + ": " + float_0.ToString());
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x0001F11C File Offset: 0x0001D31C
			internal void method_2(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Avatar",
					"Id",
					" ",
					this.gclass138_0.string_1,
					" ",
					"already in use!"
				}), GClass70.Enum1.const_0);
				this.gclass138_0.method_118(this.apiAvatar_0);
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x0001F184 File Offset: 0x0001D384
			internal void method_3(ApiContainer apiContainer_0)
			{
				Task.Run(new Func<Task>(this.method_0));
			}

			// Token: 0x040005C6 RID: 1478
			public GClass138 gclass138_0;

			// Token: 0x040005C7 RID: 1479
			public ApiAvatar apiAvatar_0;

			// Token: 0x020000E8 RID: 232
			private sealed class Class55 : IAsyncStateMachine
			{
				// Token: 0x060007DA RID: 2010 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						if (num > 3)
						{
							GClass70.smethod_38(string.Concat(new string[]
							{
								"Avatar",
								"Id",
								": ",
								this.class54_0.gclass138_0.apiAvatar_0.id,
								" | ",
								"Asset",
								"Url",
								": ",
								this.class54_0.gclass138_0.apiAvatar_0.assetUrl,
								" | ",
								"Author",
								": ",
								this.class54_0.gclass138_0.apiAvatar_0.authorName
							}), GClass70.Enum1.const_0);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							TaskAwaiter<string> awaiter2;
							TaskAwaiter<bool> awaiter3;
							TaskAwaiter<string> awaiter4;
							switch (num)
							{
							case 0:
								awaiter = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								break;
							case 1:
								awaiter2 = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								goto IL_1EC;
							case 2:
								awaiter3 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter<bool>);
								this.int_0 = -1;
								goto IL_535;
							case 3:
								awaiter4 = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								goto IL_5C2;
							default:
								awaiter = this.class54_0.gclass138_0.method_63(this.class54_0.gclass138_0.apiAvatar_0).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter;
									GClass138.Class54.Class55 @class = this;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class54.Class55>(ref awaiter, ref @class);
									return;
								}
								break;
							}
							this.string_1 = awaiter.GetResult();
							this.string_0 = this.string_1;
							this.string_1 = null;
							if (string.IsNullOrEmpty(this.string_0))
							{
								goto IL_65B;
							}
							GClass70.smethod_38("DownloadAvatarSuccess", GClass70.Enum1.const_0);
							awaiter2 = this.class54_0.gclass138_0.method_112(this.string_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter2;
								GClass138.Class54.Class55 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class54.Class55>(ref awaiter2, ref @class);
								return;
							}
							IL_1EC:
							this.string_3 = awaiter2.GetResult();
							this.string_2 = this.string_3;
							this.string_3 = null;
							GClass70.smethod_38("AssetBundle created", GClass70.Enum1.const_0);
							this.class54_0.gclass138_0.method_5("UncompressedVRCA Path is set to" + ": " + this.string_2);
							if (string.IsNullOrEmpty(this.string_2))
							{
								goto IL_654;
							}
							this.class56_0 = new GClass138.Class56();
							this.class56_0.class54_0 = this.class54_0;
							this.string_4 = this.class54_0.gclass138_0.apiAvatar_0.unityVersion.ToLower();
							this.string_5 = this.class54_0.gclass138_0.apiAvatar_0.platform.ToLower();
							this.string_6 = ApiWorld.VERSION.ApiVersion.ToString().ToLower();
							if (string.IsNullOrEmpty(this.string_6))
							{
								this.string_6 = "4";
							}
							this.string_7 = string.Concat(new string[]
							{
								"Avatar",
								" - ",
								this.class54_0.gclass138_0.apiAvatar_0.name,
								" - ",
								"Image",
								" - ",
								this.string_4,
								"_",
								this.string_6,
								"_",
								this.string_5,
								"_",
								"Release"
							});
							this.class56_0.string_1 = string.Concat(new string[]
							{
								"Avatar",
								" - ",
								this.class54_0.gclass138_0.apiAvatar_0.name,
								" - ",
								"Asset",
								" ",
								"bundle",
								" - ",
								this.string_4,
								"_",
								this.string_6,
								"_",
								this.string_5,
								"_",
								"Release"
							});
							GClass70.smethod_38("AvatarNames generated!", GClass70.Enum1.const_0);
							GClass70.smethod_38(this.string_7, GClass70.Enum1.const_0);
							GClass70.smethod_38(this.class56_0.string_1, GClass70.Enum1.const_0);
							this.string_8 = string.Empty;
							if (string.IsNullOrEmpty(this.class54_0.gclass138_0.apiAvatar_0.id))
							{
								if (!this.class54_0.gclass138_0.method_53(this.string_2, ref this.string_8))
								{
									GClass70.smethod_36("Failed to get ID!", GClass70.Enum1.const_0);
									goto IL_69C;
								}
							}
							else
							{
								this.string_8 = this.class54_0.gclass138_0.apiAvatar_0.id;
							}
							awaiter3 = this.class54_0.gclass138_0.method_58(this.string_2, this.class54_0.gclass138_0.string_1, this.string_8).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.int_0 = 2;
								this.taskAwaiter_1 = awaiter3;
								GClass138.Class54.Class55 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass138.Class54.Class55>(ref awaiter3, ref @class);
								return;
							}
							IL_535:
							this.bool_0 = awaiter3.GetResult();
							if (!this.bool_0)
							{
								GClass70.smethod_36("Failed to set AvatarId!", GClass70.Enum1.const_0);
							}
							awaiter4 = this.class54_0.gclass138_0.method_107(this.string_2).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								this.int_0 = 3;
								this.taskAwaiter_0 = awaiter4;
								GClass138.Class54.Class55 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class54.Class55>(ref awaiter4, ref @class);
								return;
							}
							IL_5C2:
							this.string_9 = awaiter4.GetResult();
							this.class56_0.string_0 = this.string_9;
							this.string_9 = null;
							if (!string.IsNullOrEmpty(this.class56_0.string_0))
							{
								this.class54_0.gclass138_0.method_99(new Action(this.class56_0.method_0));
							}
							else
							{
								GClass70.smethod_36("Failed to recompress AssetBundle!", GClass70.Enum1.const_0);
							}
							this.class56_0 = null;
							this.string_4 = null;
							this.string_5 = null;
							this.string_6 = null;
							this.string_7 = null;
							this.string_8 = null;
							IL_654:
							this.string_2 = null;
							IL_65B:
							this.string_0 = null;
						}
						catch (Exception exception)
						{
							this.exception_0 = exception;
							GClass70.smethod_36(this.exception_0.ToString(), GClass70.Enum1.const_0);
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					IL_69C:
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x040005C8 RID: 1480
				public int int_0;

				// Token: 0x040005C9 RID: 1481
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040005CA RID: 1482
				public GClass138.Class54 class54_0;

				// Token: 0x040005CB RID: 1483
				private string string_0;

				// Token: 0x040005CC RID: 1484
				private string string_1;

				// Token: 0x040005CD RID: 1485
				private string string_2;

				// Token: 0x040005CE RID: 1486
				private string string_3;

				// Token: 0x040005CF RID: 1487
				private GClass138.Class56 class56_0;

				// Token: 0x040005D0 RID: 1488
				private string string_4;

				// Token: 0x040005D1 RID: 1489
				private string string_5;

				// Token: 0x040005D2 RID: 1490
				private string string_6;

				// Token: 0x040005D3 RID: 1491
				private string string_7;

				// Token: 0x040005D4 RID: 1492
				private string string_8;

				// Token: 0x040005D5 RID: 1493
				private bool bool_0;

				// Token: 0x040005D6 RID: 1494
				private string string_9;

				// Token: 0x040005D7 RID: 1495
				private Exception exception_0;

				// Token: 0x040005D8 RID: 1496
				private TaskAwaiter<string> taskAwaiter_0;

				// Token: 0x040005D9 RID: 1497
				private TaskAwaiter<bool> taskAwaiter_1;
			}
		}

		// Token: 0x020000E9 RID: 233
		[CompilerGenerated]
		private sealed class Class56
		{
			// Token: 0x060007DC RID: 2012 RVA: 0x0001F894 File Offset: 0x0001DA94
			internal void method_0()
			{
				GClass70.smethod_38("Uploading vrca", GClass70.Enum1.const_0);
				GClass52.smethod_29(this.string_0, null, this.string_1, new GClass52.Delegate6(this.class54_0.gclass138_0.method_81), new GClass52.Delegate7(this.class54_0.gclass138_0.method_33), new GClass52.Delegate8(this.class54_0.method_1), new GClass52.Delegate9(GClass138.Class51.class51_0.method_29));
			}

			// Token: 0x040005DA RID: 1498
			public string string_0;

			// Token: 0x040005DB RID: 1499
			public string string_1;

			// Token: 0x040005DC RID: 1500
			public GClass138.Class54 class54_0;
		}

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		private sealed class Class57
		{
			// Token: 0x060007DE RID: 2014 RVA: 0x0001F91C File Offset: 0x0001DB1C
			internal void method_0(ApiFile apiFile_1, string string_0, string string_1, float float_0)
			{
				this.gclass138_0.method_5("Uploading Avatar Image Progress" + ": " + float_0.ToString());
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x0001F94C File Offset: 0x0001DB4C
			[DebuggerStepThrough]
			internal Task method_1()
			{
				GClass138.Class57.Class58 @class = new GClass138.Class57.Class58();
				@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@class.class57_0 = this;
				@class.int_0 = -1;
				@class.asyncTaskMethodBuilder_0.Start<GClass138.Class57.Class58>(ref @class);
				return @class.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x040005DD RID: 1501
			public GClass138 gclass138_0;

			// Token: 0x040005DE RID: 1502
			public ApiFile apiFile_0;

			// Token: 0x020000EB RID: 235
			private sealed class Class58 : IAsyncStateMachine
			{
				// Token: 0x060007E1 RID: 2017 RVA: 0x0001F990 File Offset: 0x0001DB90
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							this.class59_0 = new GClass138.Class59();
							this.class59_0.class57_0 = this.class57_0;
							awaiter = this.class57_0.gclass138_0.method_50(this.class57_0.gclass138_0.apiAvatar_0.imageUrl).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								GClass138.Class57.Class58 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class57.Class58>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<string>);
							this.int_0 = -1;
						}
						this.string_0 = awaiter.GetResult();
						this.class59_0.string_0 = this.string_0;
						this.string_0 = null;
						if (!string.IsNullOrEmpty(this.class59_0.string_0))
						{
							GClass70.smethod_38("DownloadAvatarImageSuccess", GClass70.Enum1.const_0);
							this.class57_0.gclass138_0.method_99(new Action(this.class59_0.method_0));
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.class59_0 = null;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.class59_0 = null;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x040005DF RID: 1503
				public int int_0;

				// Token: 0x040005E0 RID: 1504
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040005E1 RID: 1505
				public GClass138.Class57 class57_0;

				// Token: 0x040005E2 RID: 1506
				private GClass138.Class59 class59_0;

				// Token: 0x040005E3 RID: 1507
				private string string_0;

				// Token: 0x040005E4 RID: 1508
				private TaskAwaiter<string> taskAwaiter_0;
			}
		}

		// Token: 0x020000EC RID: 236
		[CompilerGenerated]
		private sealed class Class59
		{
			// Token: 0x060007E3 RID: 2019 RVA: 0x0001FAEC File Offset: 0x0001DCEC
			internal void method_0()
			{
				GClass70.smethod_38("Uploading image", GClass70.Enum1.const_0);
				GClass52.smethod_29(this.string_0, null, this.class57_0.apiFile_0.GetFileURL(), new GClass52.Delegate6(this.class57_0.gclass138_0.method_36), new GClass52.Delegate7(this.class57_0.gclass138_0.method_70), new GClass52.Delegate8(this.class57_0.method_0), new GClass52.Delegate9(GClass138.Class51.class51_0.method_4));
			}

			// Token: 0x040005E5 RID: 1509
			public string string_0;

			// Token: 0x040005E6 RID: 1510
			public GClass138.Class57 class57_0;
		}

		// Token: 0x020000ED RID: 237
		[CompilerGenerated]
		private sealed class Class60
		{
			// Token: 0x060007E6 RID: 2022 RVA: 0x0001FB7C File Offset: 0x0001DD7C
			internal void method_0()
			{
				this.gclass138_0.apiAvatar_1 = new ApiAvatar
				{
					id = this.gclass138_0.string_1,
					authorName = APIUser.CurrentUser.username,
					authorId = GClass84.smethod_1645(),
					name = this.string_0,
					imageUrl = this.apiFile_0.GetFileURL(),
					assetUrl = this.gclass138_0.apiFile_1.GetFileURL(),
					description = this.string_1,
					releaseStatus = (this.gclass138_0.bool_0 ? "private" : "public")
				};
				this.gclass138_0.apiAvatar_1.Post(new Action<ApiContainer>(this.gclass138_0.method_32), new Action<ApiContainer>(this.gclass138_0.method_82), null);
			}

			// Token: 0x040005E7 RID: 1511
			public GClass138 gclass138_0;

			// Token: 0x040005E8 RID: 1512
			public string string_0;

			// Token: 0x040005E9 RID: 1513
			public ApiFile apiFile_0;

			// Token: 0x040005EA RID: 1514
			public string string_1;
		}

		// Token: 0x020000EE RID: 238
		[CompilerGenerated]
		private sealed class Class61
		{
			// Token: 0x060007E8 RID: 2024 RVA: 0x0001FC60 File Offset: 0x0001DE60
			internal void method_0(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"World",
					"ID",
					" ",
					this.gclass138_0.string_2,
					" ",
					"already in use!"
				}), GClass70.Enum1.const_0);
				this.gclass138_0.method_72(this.apiWorld_0);
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
			internal void method_1(ApiFile apiFile_0, string string_0, string string_1, float float_0)
			{
				this.gclass138_0.method_5("World Uploading Progress" + ": " + float_0.ToString());
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
			[DebuggerStepThrough]
			internal Task method_2()
			{
				GClass138.Class61.Class62 @class = new GClass138.Class61.Class62();
				@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@class.class61_0 = this;
				@class.int_0 = -1;
				@class.asyncTaskMethodBuilder_0.Start<GClass138.Class61.Class62>(ref @class);
				return @class.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x0001FD3C File Offset: 0x0001DF3C
			internal void method_3(ApiContainer apiContainer_0)
			{
				Task.Run(new Func<Task>(this.method_2));
			}

			// Token: 0x040005EB RID: 1515
			public GClass138 gclass138_0;

			// Token: 0x040005EC RID: 1516
			public ApiWorld apiWorld_0;

			// Token: 0x020000EF RID: 239
			private sealed class Class62 : IAsyncStateMachine
			{
				// Token: 0x060007EC RID: 2028 RVA: 0x0001FD5C File Offset: 0x0001DF5C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						if (num > 3)
						{
							GClass70.smethod_38(string.Concat(new string[]
							{
								"World",
								"Id",
								": ",
								this.class61_0.gclass138_0.apiWorld_1.id,
								" | ",
								"Asset",
								"Url",
								": ",
								this.class61_0.gclass138_0.apiWorld_1.assetUrl,
								" | ",
								"Author",
								": ",
								this.class61_0.gclass138_0.apiWorld_1.authorName
							}), GClass70.Enum1.const_0);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							TaskAwaiter<string> awaiter2;
							TaskAwaiter<bool> awaiter3;
							TaskAwaiter<string> awaiter4;
							switch (num)
							{
							case 0:
								awaiter = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								break;
							case 1:
								awaiter2 = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								goto IL_1EC;
							case 2:
								awaiter3 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter<bool>);
								this.int_0 = -1;
								goto IL_540;
							case 3:
								awaiter4 = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter<string>);
								this.int_0 = -1;
								goto IL_5CD;
							default:
								awaiter = this.class61_0.gclass138_0.method_15(this.class61_0.gclass138_0.apiWorld_1).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter;
									GClass138.Class61.Class62 @class = this;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class61.Class62>(ref awaiter, ref @class);
									return;
								}
								break;
							}
							this.string_1 = awaiter.GetResult();
							this.string_0 = this.string_1;
							this.string_1 = null;
							if (string.IsNullOrEmpty(this.string_0))
							{
								goto IL_666;
							}
							GClass70.smethod_38("DownloadWorldSuccess", GClass70.Enum1.const_0);
							awaiter2 = this.class61_0.gclass138_0.method_112(this.string_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter2;
								GClass138.Class61.Class62 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class61.Class62>(ref awaiter2, ref @class);
								return;
							}
							IL_1EC:
							this.string_3 = awaiter2.GetResult();
							this.string_2 = this.string_3;
							this.string_3 = null;
							GClass70.smethod_38("AssetBundle created", GClass70.Enum1.const_0);
							this.class61_0.gclass138_0.method_5("UncompressedVRCW Path is set to" + ": " + this.string_2);
							if (string.IsNullOrEmpty(this.string_2))
							{
								goto IL_65F;
							}
							this.class63_0 = new GClass138.Class63();
							this.class63_0.class61_0 = this.class61_0;
							this.string_4 = this.class61_0.gclass138_0.apiWorld_1.unityVersion.ToLower();
							this.string_5 = this.class61_0.gclass138_0.apiWorld_1.platform.ToLower();
							this.string_6 = this.class61_0.gclass138_0.apiWorld_1.apiVersion.ToString().ToLower();
							if (string.IsNullOrEmpty(this.string_6))
							{
								this.string_6 = "4";
							}
							this.string_7 = string.Concat(new string[]
							{
								"World",
								" - ",
								this.class61_0.gclass138_0.apiWorld_1.name,
								" - ",
								"Image",
								" - ",
								this.string_4,
								"_",
								this.string_6,
								"_",
								this.string_5,
								"_",
								"Release"
							});
							this.class63_0.string_1 = string.Concat(new string[]
							{
								"World",
								" - ",
								this.class61_0.gclass138_0.apiWorld_1.name,
								" - ",
								"Asset",
								" ",
								"bundle",
								" - ",
								this.string_4,
								"_",
								this.string_6,
								"_",
								this.string_5,
								"_",
								"Release"
							});
							GClass70.smethod_38("WorldNames generated!", GClass70.Enum1.const_0);
							GClass70.smethod_38(this.string_7, GClass70.Enum1.const_0);
							GClass70.smethod_38(this.class63_0.string_1, GClass70.Enum1.const_0);
							this.string_8 = string.Empty;
							if (string.IsNullOrEmpty(this.class61_0.gclass138_0.apiWorld_1.id))
							{
								if (!this.class61_0.gclass138_0.method_53(this.string_2, ref this.string_8))
								{
									GClass70.smethod_36("Failed to get ID!", GClass70.Enum1.const_0);
									goto IL_6A7;
								}
							}
							else
							{
								this.string_8 = this.class61_0.gclass138_0.apiWorld_1.id;
							}
							awaiter3 = this.class61_0.gclass138_0.method_58(this.string_2, this.class61_0.gclass138_0.string_2, this.string_8).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.int_0 = 2;
								this.taskAwaiter_1 = awaiter3;
								GClass138.Class61.Class62 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass138.Class61.Class62>(ref awaiter3, ref @class);
								return;
							}
							IL_540:
							this.bool_0 = awaiter3.GetResult();
							if (!this.bool_0)
							{
								GClass70.smethod_36("Failed to set WorldID!", GClass70.Enum1.const_0);
							}
							awaiter4 = this.class61_0.gclass138_0.method_107(this.string_2).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								this.int_0 = 3;
								this.taskAwaiter_0 = awaiter4;
								GClass138.Class61.Class62 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class61.Class62>(ref awaiter4, ref @class);
								return;
							}
							IL_5CD:
							this.string_9 = awaiter4.GetResult();
							this.class63_0.string_0 = this.string_9;
							this.string_9 = null;
							if (!string.IsNullOrEmpty(this.class63_0.string_0))
							{
								this.class61_0.gclass138_0.method_99(new Action(this.class63_0.method_0));
							}
							else
							{
								GClass70.smethod_36("Failed to recompress AssetBundle!", GClass70.Enum1.const_0);
							}
							this.class63_0 = null;
							this.string_4 = null;
							this.string_5 = null;
							this.string_6 = null;
							this.string_7 = null;
							this.string_8 = null;
							IL_65F:
							this.string_2 = null;
							IL_666:
							this.string_0 = null;
						}
						catch (Exception exception)
						{
							this.exception_0 = exception;
							GClass70.smethod_36(this.exception_0.ToString(), GClass70.Enum1.const_0);
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					IL_6A7:
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x040005ED RID: 1517
				public int int_0;

				// Token: 0x040005EE RID: 1518
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040005EF RID: 1519
				public GClass138.Class61 class61_0;

				// Token: 0x040005F0 RID: 1520
				private string string_0;

				// Token: 0x040005F1 RID: 1521
				private string string_1;

				// Token: 0x040005F2 RID: 1522
				private string string_2;

				// Token: 0x040005F3 RID: 1523
				private string string_3;

				// Token: 0x040005F4 RID: 1524
				private GClass138.Class63 class63_0;

				// Token: 0x040005F5 RID: 1525
				private string string_4;

				// Token: 0x040005F6 RID: 1526
				private string string_5;

				// Token: 0x040005F7 RID: 1527
				private string string_6;

				// Token: 0x040005F8 RID: 1528
				private string string_7;

				// Token: 0x040005F9 RID: 1529
				private string string_8;

				// Token: 0x040005FA RID: 1530
				private bool bool_0;

				// Token: 0x040005FB RID: 1531
				private string string_9;

				// Token: 0x040005FC RID: 1532
				private Exception exception_0;

				// Token: 0x040005FD RID: 1533
				private TaskAwaiter<string> taskAwaiter_0;

				// Token: 0x040005FE RID: 1534
				private TaskAwaiter<bool> taskAwaiter_1;
			}
		}

		// Token: 0x020000F0 RID: 240
		[CompilerGenerated]
		private sealed class Class63
		{
			// Token: 0x060007EE RID: 2030 RVA: 0x00020458 File Offset: 0x0001E658
			internal void method_0()
			{
				GClass70.smethod_38("Uploading vrcw", GClass70.Enum1.const_0);
				GClass52.smethod_29(this.string_0, null, this.string_1, new GClass52.Delegate6(this.class61_0.gclass138_0.method_20), new GClass52.Delegate7(this.class61_0.gclass138_0.method_111), new GClass52.Delegate8(this.class61_0.method_1), new GClass52.Delegate9(GClass138.Class51.class51_0.method_14));
			}

			// Token: 0x040005FF RID: 1535
			public string string_0;

			// Token: 0x04000600 RID: 1536
			public string string_1;

			// Token: 0x04000601 RID: 1537
			public GClass138.Class61 class61_0;
		}

		// Token: 0x020000F1 RID: 241
		[CompilerGenerated]
		private sealed class Class64
		{
			// Token: 0x060007F0 RID: 2032 RVA: 0x000204E0 File Offset: 0x0001E6E0
			[DebuggerStepThrough]
			internal Task method_0()
			{
				GClass138.Class64.Class65 @class = new GClass138.Class64.Class65();
				@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@class.class64_0 = this;
				@class.int_0 = -1;
				@class.asyncTaskMethodBuilder_0.Start<GClass138.Class64.Class65>(ref @class);
				return @class.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x00020524 File Offset: 0x0001E724
			internal void method_1(ApiFile apiFile_0, string string_1, string string_2, float float_0)
			{
				this.gclass138_0.method_5("World Image Uploading" + ": " + float_0.ToString());
			}

			// Token: 0x04000602 RID: 1538
			public GClass138 gclass138_0;

			// Token: 0x04000603 RID: 1539
			public string string_0;

			// Token: 0x020000F2 RID: 242
			private sealed class Class65 : IAsyncStateMachine
			{
				// Token: 0x060007F3 RID: 2035 RVA: 0x00020554 File Offset: 0x0001E754
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							this.class66_0 = new GClass138.Class66();
							this.class66_0.class64_0 = this.class64_0;
							awaiter = this.class64_0.gclass138_0.method_50(this.class64_0.gclass138_0.apiWorld_1.imageUrl).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								GClass138.Class64.Class65 @class = this;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass138.Class64.Class65>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<string>);
							this.int_0 = -1;
						}
						this.string_0 = awaiter.GetResult();
						this.class66_0.string_0 = this.string_0;
						this.string_0 = null;
						if (!string.IsNullOrEmpty(this.class66_0.string_0))
						{
							GClass70.smethod_38("OnUploadVrcwAsyncSuccess", GClass70.Enum1.const_0);
							this.class64_0.gclass138_0.method_99(new Action(this.class66_0.method_0));
						}
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.class66_0 = null;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.class66_0 = null;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x04000604 RID: 1540
				public int int_0;

				// Token: 0x04000605 RID: 1541
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04000606 RID: 1542
				public GClass138.Class64 class64_0;

				// Token: 0x04000607 RID: 1543
				private GClass138.Class66 class66_0;

				// Token: 0x04000608 RID: 1544
				private string string_0;

				// Token: 0x04000609 RID: 1545
				private TaskAwaiter<string> taskAwaiter_0;
			}
		}

		// Token: 0x020000F3 RID: 243
		[CompilerGenerated]
		private sealed class Class66
		{
			// Token: 0x060007F6 RID: 2038 RVA: 0x000206B0 File Offset: 0x0001E8B0
			internal void method_0()
			{
				GClass70.smethod_38("Uploading image", GClass70.Enum1.const_0);
				GClass52.smethod_29(this.string_0, null, this.class64_0.string_0, new GClass52.Delegate6(this.class64_0.gclass138_0.method_51), new GClass52.Delegate7(this.class64_0.gclass138_0.method_70), new GClass52.Delegate8(this.class64_0.method_1), new GClass52.Delegate9(GClass138.Class51.class51_0.method_0));
			}

			// Token: 0x0400060A RID: 1546
			public string string_0;

			// Token: 0x0400060B RID: 1547
			public GClass138.Class64 class64_0;
		}

		// Token: 0x020000F4 RID: 244
		[CompilerGenerated]
		private sealed class Class67
		{
			// Token: 0x060007F8 RID: 2040 RVA: 0x0002073C File Offset: 0x0001E93C
			internal void method_0()
			{
				this.gclass138_0.apiWorld_0 = new ApiWorld
				{
					id = this.gclass138_0.string_2,
					authorName = APIUser.CurrentUser.username,
					authorId = GClass84.smethod_1645(),
					name = this.gclass138_0.apiWorld_1.name,
					imageUrl = this.apiFile_0.GetFileURL(),
					assetUrl = this.gclass138_0.apiFile_0.GetFileURL(),
					description = this.gclass138_0.apiWorld_1.description,
					releaseStatus = (this.gclass138_0.bool_0 ? "private" : "public")
				};
				this.gclass138_0.apiWorld_0.Post(new Action<ApiContainer>(this.gclass138_0.method_4), new Action<ApiContainer>(this.gclass138_0.method_28), null);
			}

			// Token: 0x0400060C RID: 1548
			public GClass138 gclass138_0;

			// Token: 0x0400060D RID: 1549
			public ApiFile apiFile_0;
		}
	}
}
