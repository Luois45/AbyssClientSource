using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ns151;
using ns169;
using ns191;
using ns213;
using ns226;
using ns273;
using ns312;
using ns331;
using ns332;
using ns338;
using ns35;
using ns370;
using ns381;
using ns387;
using ns396;
using ns503;
using ns515;
using ns547;
using ns549;
using ns79;

namespace ns84
{
	// Token: 0x0200005D RID: 93
	public static class GClass43
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0000AC68 File Offset: 0x00008E68
		public static bool smethod_0(GStruct16 gstruct16_0, IList<string> ilist_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetItemTags(Class180.smethod_5(), gstruct16_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)));
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000AC90 File Offset: 0x00008E90
		public static bool smethod_1(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetAllowCachedResponse(Class180.smethod_5(), gstruct285_0, uint_0);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public static GStruct241 smethod_2(GStruct66 gstruct66_0, GEnum66 genum66_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_CreateItem(Class180.smethod_5(), gstruct66_0, genum66_0));
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		public static GStruct241 smethod_3(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_UnsubscribeItem(Class180.smethod_5(), gstruct78_0));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000ACFC File Offset: 0x00008EFC
		public static bool smethod_4(GStruct285 gstruct285_0, uint uint_0, GStruct78[] gstruct78_0, uint uint_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCChildren(Class180.smethod_5(), gstruct285_0, uint_0, gstruct78_0, uint_1);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public static bool smethod_5(GStruct78 gstruct78_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_DownloadItem(Class180.smethod_5(), gstruct78_0, bool_0);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000AD3C File Offset: 0x00008F3C
		public static bool smethod_6(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnOnlyIDs(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000AD5C File Offset: 0x00008F5C
		public static GStruct285 smethod_7(GEnum93 genum93_0, GEnum7 genum7_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryAllUGCRequest(Class180.smethod_5(), genum93_0, genum7_0, gstruct66_0, gstruct66_1, uint_0));
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000AD88 File Offset: 0x00008F88
		public static bool smethod_8(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnLongDescription(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		public static bool smethod_9(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnTotalOnly(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		public static bool smethod_10(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemDescription(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000AE0C File Offset: 0x0000900C
		public static bool smethod_11(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnKeyValueTags(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000AE2C File Offset: 0x0000902C
		public static bool smethod_12(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetRankedByTrendDays(Class180.smethod_5(), gstruct285_0, uint_0);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000AE4C File Offset: 0x0000904C
		public static GStruct16 smethod_13(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct16.smethod_1(Class177.SteamAPI_ISteamUGC_StartItemUpdate(Class180.smethod_5(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000AE74 File Offset: 0x00009074
		public static bool smethod_14(GStruct16 gstruct16_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_RemoveItemPreview(Class180.smethod_5(), gstruct16_0, uint_0);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000AE94 File Offset: 0x00009094
		public static bool smethod_15(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemMetadata(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000AED8 File Offset: 0x000090D8
		public static uint smethod_16(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetSubscribedItems(Class180.smethod_5(), gstruct78_0, uint_0);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000AEF8 File Offset: 0x000090F8
		public static bool smethod_17(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnPlaytimeStats(Class180.smethod_5(), gstruct285_0, uint_0);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000AF18 File Offset: 0x00009118
		public static bool smethod_18(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetMatchAnyTag(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000AF38 File Offset: 0x00009138
		public static bool smethod_19(GStruct108 gstruct108_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_BInitWorkshopForGameServer(Class180.smethod_5(), gstruct108_0, gclass);
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000AF7C File Offset: 0x0000917C
		public static bool smethod_20(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddExcludedTag(Class180.smethod_5(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public static bool smethod_21(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemUpdateLanguage(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B004 File Offset: 0x00009204
		public static GStruct241 smethod_22(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddItemToFavorites(Class180.smethod_5(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B02C File Offset: 0x0000922C
		public static bool smethod_23(GStruct285 gstruct285_0, uint uint_0, out string string_0, uint uint_1)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCMetadata(Class180.smethod_5(), gstruct285_0, uint_0, intPtr, uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B06C File Offset: 0x0000926C
		public static GStruct241 smethod_24(GStruct78 gstruct78_0, GStruct78 gstruct78_1)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveDependency(Class180.smethod_5(), gstruct78_0, gstruct78_1));
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B094 File Offset: 0x00009294
		public static bool smethod_25(GStruct285 gstruct285_0, uint uint_0, out GStruct303 gstruct303_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCResult(Class180.smethod_5(), gstruct285_0, uint_0, out gstruct303_0);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public static bool smethod_26(GStruct285 gstruct285_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_ReleaseQueryUGCRequest(Class180.smethod_5(), gstruct285_0);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public static bool smethod_27(GStruct78 gstruct78_0, out ulong ulong_0, out string string_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool flag = Class177.SteamAPI_ISteamUGC_GetItemInstallInfo(Class180.smethod_5(), gstruct78_0, out ulong_0, intPtr, uint_0, out uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000B114 File Offset: 0x00009314
		public static GStruct241 smethod_28(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_GetUserItemVote(Class180.smethod_5(), gstruct78_0));
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000B138 File Offset: 0x00009338
		public static GStruct241 smethod_29(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_GetAppDependencies(Class180.smethod_5(), gstruct78_0));
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000B15C File Offset: 0x0000935C
		public static bool smethod_30(GStruct78 gstruct78_0, out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetItemDownloadInfo(Class180.smethod_5(), gstruct78_0, out ulong_0, out ulong_1);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000B17C File Offset: 0x0000937C
		public static uint smethod_31()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetNumSubscribedItems(Class180.smethod_5());
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000B19C File Offset: 0x0000939C
		public static bool smethod_32(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnAdditionalPreviews(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000B1BC File Offset: 0x000093BC
		public static GStruct241 smethod_33(GStruct78 gstruct78_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddAppDependency(Class180.smethod_5(), gstruct78_0, gstruct66_0));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public static GStruct241 smethod_34(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveItemFromFavorites(Class180.smethod_5(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B20C File Offset: 0x0000940C
		public static GEnum75 smethod_35(GStruct16 gstruct16_0, out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetItemUpdateProgress(Class180.smethod_5(), gstruct16_0, out ulong_0, out ulong_1);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000B230 File Offset: 0x00009430
		public static bool smethod_36(GStruct285 gstruct285_0, uint uint_0, GEnum50 genum50_0, out ulong ulong_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCStatistic(Class180.smethod_5(), gstruct285_0, uint_0, genum50_0, out ulong_0);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000B250 File Offset: 0x00009450
		public static bool smethod_37(GStruct285 gstruct285_0, uint uint_0, out string string_0, uint uint_1)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCPreviewURL(Class180.smethod_5(), gstruct285_0, uint_0, intPtr, uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B290 File Offset: 0x00009490
		public static bool smethod_38(GStruct285 gstruct285_0, string string_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUGC_AddRequiredKeyValueTag(Class180.smethod_5(), gstruct285_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public static bool smethod_39(GStruct16 gstruct16_0, uint uint_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_UpdateItemPreviewVideo(Class180.smethod_5(), gstruct16_0, uint_0, gclass);
			}
			return result;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000B338 File Offset: 0x00009538
		public static GStruct241 smethod_40(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SubscribeItem(Class180.smethod_5(), gstruct78_0));
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000B35C File Offset: 0x0000955C
		public static bool smethod_41(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemTitle(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public static uint smethod_42(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags(Class180.smethod_5(), gstruct285_0, uint_0);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000B3C0 File Offset: 0x000095C0
		public static GStruct241 smethod_43(GStruct78 gstruct78_0, bool bool_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SetUserItemVote(Class180.smethod_5(), gstruct78_0, bool_0));
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000B3E8 File Offset: 0x000095E8
		public static bool smethod_44(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetLanguage(Class180.smethod_5(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000B42C File Offset: 0x0000962C
		public static uint smethod_45(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews(Class180.smethod_5(), gstruct285_0, uint_0);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000B44C File Offset: 0x0000964C
		public static GStruct285 smethod_46(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest(Class180.smethod_5(), gstruct78_0, uint_0));
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000B474 File Offset: 0x00009674
		public static GStruct241 smethod_47(GStruct285 gstruct285_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SendQueryUGCRequest(Class180.smethod_5(), gstruct285_0));
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000B498 File Offset: 0x00009698
		public static bool smethod_48(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnMetadata(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public static GStruct241 smethod_49(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StopPlaytimeTracking(Class180.smethod_5(), gstruct78_0, uint_0));
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public static bool smethod_50(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetReturnChildren(Class180.smethod_5(), gstruct285_0, bool_0);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000B500 File Offset: 0x00009700
		public static bool smethod_51(GStruct16 gstruct16_0, string string_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUGC_AddItemKeyValueTag(Class180.smethod_5(), gstruct16_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000B564 File Offset: 0x00009764
		internal static void smethod_52(bool bool_0)
		{
			GClass43.smethod_75(bool_0);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000B578 File Offset: 0x00009778
		public static GStruct241 smethod_53()
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems(Class180.smethod_5()));
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000B59C File Offset: 0x0000979C
		public static GStruct241 smethod_54(GStruct78 gstruct78_0, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RequestUGCDetails(Class180.smethod_5(), gstruct78_0, uint_0));
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public static bool smethod_55(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddItemPreviewVideo(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000B608 File Offset: 0x00009808
		public static void smethod_56(bool bool_0)
		{
			GClass43.smethod_52(bool_0);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000B61C File Offset: 0x0000981C
		public static bool smethod_57(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddRequiredTag(Class180.smethod_5(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B660 File Offset: 0x00009860
		public static bool smethod_58(GStruct285 gstruct285_0, uint uint_0, uint uint_1, out string string_0, uint uint_2, out string string_1, uint uint_3, out GEnum59 genum59_0)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_2);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)uint_3);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview(Class180.smethod_5(), gstruct285_0, uint_0, uint_1, intPtr, uint_2, intPtr2, uint_3, out genum59_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			string_1 = (flag ? GClass78.smethod_0(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public static bool smethod_59(GStruct16 gstruct16_0, string string_0, GEnum59 genum59_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddItemPreviewFile(Class180.smethod_5(), gstruct16_0, gclass, genum59_0);
			}
			return result;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000B708 File Offset: 0x00009908
		public static GStruct241 smethod_60(GStruct78 gstruct78_0, GStruct78 gstruct78_1)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddDependency(Class180.smethod_5(), gstruct78_0, gstruct78_1));
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B730 File Offset: 0x00009930
		public static GStruct285 smethod_61(GStruct216 gstruct216_0, GEnum62 genum62_0, GEnum7 genum7_0, GEnum31 genum31_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryUserUGCRequest(Class180.smethod_5(), gstruct216_0, genum62_0, genum7_0, genum31_0, gstruct66_0, gstruct66_1, uint_0));
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000B760 File Offset: 0x00009960
		public static GStruct241 smethod_62(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StartPlaytimeTracking(Class180.smethod_5(), gstruct78_0, uint_0));
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000B788 File Offset: 0x00009988
		public static uint smethod_63(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_GetItemState(Class180.smethod_5(), gstruct78_0);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B7A8 File Offset: 0x000099A8
		public static GStruct241 smethod_64(GStruct78 gstruct78_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveAppDependency(Class180.smethod_5(), gstruct78_0, gstruct66_0));
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B7D0 File Offset: 0x000099D0
		public static bool smethod_65(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemPreview(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000B814 File Offset: 0x00009A14
		public static bool smethod_66(GStruct285 gstruct285_0, uint uint_0, uint uint_1, out string string_0, uint uint_2, out string string_1, uint uint_3)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_2);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)uint_3);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag(Class180.smethod_5(), gstruct285_0, uint_0, uint_1, intPtr, uint_2, intPtr2, uint_3);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			string_1 = (flag ? GClass78.smethod_0(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B874 File Offset: 0x00009A74
		public static GStruct241 smethod_67(GStruct78 gstruct78_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_DeleteItem(Class180.smethod_5(), gstruct78_0));
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000B898 File Offset: 0x00009A98
		public static bool smethod_68(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetCloudFileNameFilter(Class180.smethod_5(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000B8DC File Offset: 0x00009ADC
		public static bool smethod_69(GStruct16 gstruct16_0, GEnum86 genum86_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamUGC_SetItemVisibility(Class180.smethod_5(), gstruct16_0, genum86_0);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000B8FC File Offset: 0x00009AFC
		public static bool smethod_70(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_RemoveItemKeyValueTags(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000B940 File Offset: 0x00009B40
		public static bool smethod_71(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetSearchText(Class180.smethod_5(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000B984 File Offset: 0x00009B84
		public static bool smethod_72(GStruct16 gstruct16_0, uint uint_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_UpdateItemPreviewFile(Class180.smethod_5(), gstruct16_0, uint_0, gclass);
			}
			return result;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public static bool smethod_73(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemContent(Class180.smethod_5(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BA0C File Offset: 0x00009C0C
		public static GStruct241 smethod_74(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_2();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SubmitItemUpdate(Class180.smethod_5(), gstruct16_0, gclass));
			}
			return result;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BA58 File Offset: 0x00009C58
		internal static void smethod_75(bool bool_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamUGC_SuspendDownloads(Class180.smethod_5(), bool_0);
		}
	}
}
