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
using ns387;
using ns396;
using ns503;
using ns515;
using ns547;
using ns549;
using ns79;

namespace ns494
{
	// Token: 0x02000358 RID: 856
	public static class GClass189
	{
		// Token: 0x06004762 RID: 18274 RVA: 0x0010E6EC File Offset: 0x0010C8EC
		public static bool smethod_0(GStruct78 gstruct78_0, out ulong ulong_0, out string string_0, uint uint_0, out uint uint_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool flag = Class177.SteamAPI_ISteamUGC_GetItemInstallInfo(<Module>.smethod_15(), gstruct78_0, out ulong_0, intPtr, uint_0, out uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x0010E72C File Offset: 0x0010C92C
		public static GStruct241 smethod_1(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StartPlaytimeTracking(<Module>.smethod_15(), gstruct78_0, uint_0));
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0010E754 File Offset: 0x0010C954
		public static bool smethod_2(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetSearchText(<Module>.smethod_15(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x0010E798 File Offset: 0x0010C998
		public static bool smethod_3(GStruct16 gstruct16_0, uint uint_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_UpdateItemPreviewFile(<Module>.smethod_15(), gstruct16_0, uint_0, gclass);
			}
			return result;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x0010E7DC File Offset: 0x0010C9DC
		public static bool smethod_4(GStruct16 gstruct16_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUGC_AddItemKeyValueTag(<Module>.smethod_15(), gstruct16_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x0010E840 File Offset: 0x0010CA40
		public static bool smethod_5(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnChildren(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0010E860 File Offset: 0x0010CA60
		public static bool smethod_6(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnPlaytimeStats(<Module>.smethod_15(), gstruct285_0, uint_0);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0010E880 File Offset: 0x0010CA80
		public static uint smethod_7(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetItemState(<Module>.smethod_15(), gstruct78_0);
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0010E8A0 File Offset: 0x0010CAA0
		public static bool smethod_8(GStruct78 gstruct78_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_DownloadItem(<Module>.smethod_15(), gstruct78_0, bool_0);
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0010E8C0 File Offset: 0x0010CAC0
		public static bool smethod_9(GStruct285 gstruct285_0, uint uint_0, GStruct78[] gstruct78_0, uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCChildren(<Module>.smethod_15(), gstruct285_0, uint_0, gstruct78_0, uint_1);
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0010E8E0 File Offset: 0x0010CAE0
		public static uint smethod_10()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetNumSubscribedItems(<Module>.smethod_15());
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x0010E900 File Offset: 0x0010CB00
		public static bool smethod_11(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetCloudFileNameFilter(<Module>.smethod_15(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x0010E944 File Offset: 0x0010CB44
		public static bool smethod_12(GStruct285 gstruct285_0, uint uint_0, out string string_0, uint uint_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCMetadata(<Module>.smethod_15(), gstruct285_0, uint_0, intPtr, uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x0010E984 File Offset: 0x0010CB84
		public static GStruct241 smethod_13(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StopPlaytimeTracking(<Module>.smethod_15(), gstruct78_0, uint_0));
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x0010E9AC File Offset: 0x0010CBAC
		public static bool smethod_14(GStruct285 gstruct285_0, uint uint_0, uint uint_1, out string string_0, uint uint_2, out string string_1, uint uint_3)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_2);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)uint_3);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag(<Module>.smethod_15(), gstruct285_0, uint_0, uint_1, intPtr, uint_2, intPtr2, uint_3);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			string_1 = (flag ? GClass78.smethod_0(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x0010EA0C File Offset: 0x0010CC0C
		public static uint smethod_15(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetSubscribedItems(<Module>.smethod_15(), gstruct78_0, uint_0);
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x0010EA2C File Offset: 0x0010CC2C
		public static bool smethod_16(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnTotalOnly(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x0010EA4C File Offset: 0x0010CC4C
		public static GStruct241 smethod_17(GStruct285 gstruct285_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SendQueryUGCRequest(<Module>.smethod_15(), gstruct285_0));
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x0010EA70 File Offset: 0x0010CC70
		public static uint smethod_18(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags(<Module>.smethod_15(), gstruct285_0, uint_0);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x0010EA90 File Offset: 0x0010CC90
		public static GStruct241 smethod_19(GStruct78 gstruct78_0, GStruct78 gstruct78_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddDependency(<Module>.smethod_15(), gstruct78_0, gstruct78_1));
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x0010EAB8 File Offset: 0x0010CCB8
		public static bool smethod_20(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_RemoveItemKeyValueTags(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x0010EAFC File Offset: 0x0010CCFC
		public static GStruct241 smethod_21(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SubmitItemUpdate(<Module>.smethod_15(), gstruct16_0, gclass));
			}
			return result;
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x0010EB48 File Offset: 0x0010CD48
		public static GStruct241 smethod_22(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddItemToFavorites(<Module>.smethod_15(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x0010EB70 File Offset: 0x0010CD70
		public static bool smethod_23(GStruct285 gstruct285_0, uint uint_0, uint uint_1, out string string_0, uint uint_2, out string string_1, uint uint_3, out GEnum59 genum59_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_2);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)uint_3);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview(<Module>.smethod_15(), gstruct285_0, uint_0, uint_1, intPtr, uint_2, intPtr2, uint_3, out genum59_0);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			string_1 = (flag ? GClass78.smethod_0(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0010EBD4 File Offset: 0x0010CDD4
		public static bool smethod_24(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnOnlyIDs(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x0010EBF4 File Offset: 0x0010CDF4
		public static uint smethod_25(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews(<Module>.smethod_15(), gstruct285_0, uint_0);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0010EC14 File Offset: 0x0010CE14
		public static bool smethod_26(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddItemPreviewVideo(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0010EC58 File Offset: 0x0010CE58
		public static GStruct241 smethod_27(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_DeleteItem(<Module>.smethod_15(), gstruct78_0));
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0010EC7C File Offset: 0x0010CE7C
		public static bool smethod_28(GStruct285 gstruct285_0, uint uint_0, GEnum50 genum50_0, out ulong ulong_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCStatistic(<Module>.smethod_15(), gstruct285_0, uint_0, genum50_0, out ulong_0);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0010EC9C File Offset: 0x0010CE9C
		public static GStruct241 smethod_29(GStruct78 gstruct78_0, GStruct78 gstruct78_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveDependency(<Module>.smethod_15(), gstruct78_0, gstruct78_1));
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0010ECC4 File Offset: 0x0010CEC4
		public static GStruct241 smethod_30(GStruct78 gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RequestUGCDetails(<Module>.smethod_15(), gstruct78_0, uint_0));
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0010ECEC File Offset: 0x0010CEEC
		public static bool smethod_31(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddExcludedTag(<Module>.smethod_15(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0010ED30 File Offset: 0x0010CF30
		public static GStruct241 smethod_32(GStruct78 gstruct78_0, bool bool_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SetUserItemVote(<Module>.smethod_15(), gstruct78_0, bool_0));
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0010ED58 File Offset: 0x0010CF58
		public static GStruct241 smethod_33(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_GetAppDependencies(<Module>.smethod_15(), gstruct78_0));
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0010ED7C File Offset: 0x0010CF7C
		public static void smethod_34(bool bool_0)
		{
			GClass189.smethod_70(bool_0);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0010ED90 File Offset: 0x0010CF90
		public static bool smethod_35(GStruct16 gstruct16_0, uint uint_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_UpdateItemPreviewVideo(<Module>.smethod_15(), gstruct16_0, uint_0, gclass);
			}
			return result;
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0010EDD4 File Offset: 0x0010CFD4
		public static GStruct285 smethod_36(GStruct78[] gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest(<Module>.smethod_15(), gstruct78_0, uint_0));
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0010EDFC File Offset: 0x0010CFFC
		public static bool smethod_37(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnAdditionalPreviews(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0010EE1C File Offset: 0x0010D01C
		public static bool smethod_38(GStruct108 gstruct108_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_BInitWorkshopForGameServer(<Module>.smethod_15(), gstruct108_0, gclass);
			}
			return result;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0010EE60 File Offset: 0x0010D060
		public static GStruct241 smethod_39(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_GetUserItemVote(<Module>.smethod_15(), gstruct78_0));
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x0010EE84 File Offset: 0x0010D084
		public static GStruct241 smethod_40(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveItemFromFavorites(<Module>.smethod_15(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0010EEAC File Offset: 0x0010D0AC
		public static bool smethod_41(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnMetadata(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0010EECC File Offset: 0x0010D0CC
		public static GStruct241 smethod_42(GStruct66 gstruct66_0, GEnum66 genum66_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_CreateItem(<Module>.smethod_15(), gstruct66_0, genum66_0));
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0010EEF4 File Offset: 0x0010D0F4
		public static bool smethod_43(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemMetadata(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x0010EF38 File Offset: 0x0010D138
		public static bool smethod_44(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetRankedByTrendDays(<Module>.smethod_15(), gstruct285_0, uint_0);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x0010EF58 File Offset: 0x0010D158
		public static bool smethod_45(GStruct285 gstruct285_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_ReleaseQueryUGCRequest(<Module>.smethod_15(), gstruct285_0);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0010EF78 File Offset: 0x0010D178
		public static bool smethod_46(GStruct78 gstruct78_0, out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetItemDownloadInfo(<Module>.smethod_15(), gstruct78_0, out ulong_0, out ulong_1);
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0010EF98 File Offset: 0x0010D198
		public static bool smethod_47(GStruct285 gstruct285_0, uint uint_0, out string string_0, uint uint_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool flag = Class177.SteamAPI_ISteamUGC_GetQueryUGCPreviewURL(<Module>.smethod_15(), gstruct285_0, uint_0, intPtr, uint_1);
			string_0 = (flag ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0010EFD8 File Offset: 0x0010D1D8
		public static GStruct241 smethod_48(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_UnsubscribeItem(<Module>.smethod_15(), gstruct78_0));
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0010EFFC File Offset: 0x0010D1FC
		public static bool smethod_49(GStruct16 gstruct16_0, IList<string> ilist_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetItemTags(<Module>.smethod_15(), gstruct16_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)));
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x0010F024 File Offset: 0x0010D224
		public static bool smethod_50(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetLanguage(<Module>.smethod_15(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x0010F068 File Offset: 0x0010D268
		public static bool smethod_51(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnLongDescription(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x0010F088 File Offset: 0x0010D288
		public static bool smethod_52(GStruct16 gstruct16_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_RemoveItemPreview(<Module>.smethod_15(), gstruct16_0, uint_0);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x0010F0A8 File Offset: 0x0010D2A8
		public static bool smethod_53(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetMatchAnyTag(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x0010F0C8 File Offset: 0x0010D2C8
		public static bool smethod_54(GStruct285 gstruct285_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetReturnKeyValueTags(<Module>.smethod_15(), gstruct285_0, bool_0);
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0010F0E8 File Offset: 0x0010D2E8
		public static GStruct241 smethod_55(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_SubscribeItem(<Module>.smethod_15(), gstruct78_0));
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x0010F10C File Offset: 0x0010D30C
		public static bool smethod_56(GStruct16 gstruct16_0, string string_0, GEnum59 genum59_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddItemPreviewFile(<Module>.smethod_15(), gstruct16_0, gclass, genum59_0);
			}
			return result;
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x0010F150 File Offset: 0x0010D350
		public static GStruct285 smethod_57(GEnum93 genum93_0, GEnum7 genum7_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryAllUGCRequest(<Module>.smethod_15(), genum93_0, genum7_0, gstruct66_0, gstruct66_1, uint_0));
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x0010F17C File Offset: 0x0010D37C
		public static bool smethod_58(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemTitle(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x0010F1C0 File Offset: 0x0010D3C0
		public static bool smethod_59(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemContent(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x0010F204 File Offset: 0x0010D404
		public static bool smethod_60(GStruct285 gstruct285_0, uint uint_0, out GStruct303 gstruct303_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetQueryUGCResult(<Module>.smethod_15(), gstruct285_0, uint_0, out gstruct303_0);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x0010F224 File Offset: 0x0010D424
		public static bool smethod_61(GStruct285 gstruct285_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamUGC_AddRequiredKeyValueTag(<Module>.smethod_15(), gstruct285_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0010F288 File Offset: 0x0010D488
		public static GStruct16 smethod_62(GStruct66 gstruct66_0, GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct16.smethod_1(Class177.SteamAPI_ISteamUGC_StartItemUpdate(<Module>.smethod_15(), gstruct66_0, gstruct78_0));
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0010F2B0 File Offset: 0x0010D4B0
		public static GStruct241 smethod_63(GStruct78 gstruct78_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_RemoveAppDependency(<Module>.smethod_15(), gstruct78_0, gstruct66_0));
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0010F2D8 File Offset: 0x0010D4D8
		public static bool smethod_64(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemDescription(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x0010F31C File Offset: 0x0010D51C
		public static bool smethod_65(GStruct285 gstruct285_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetAllowCachedResponse(<Module>.smethod_15(), gstruct285_0, uint_0);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0010F33C File Offset: 0x0010D53C
		public static bool smethod_66(GStruct16 gstruct16_0, GEnum86 genum86_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_SetItemVisibility(<Module>.smethod_15(), gstruct16_0, genum86_0);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x0010F35C File Offset: 0x0010D55C
		public static GStruct241 smethod_67(GStruct78 gstruct78_0, GStruct66 gstruct66_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_AddAppDependency(<Module>.smethod_15(), gstruct78_0, gstruct66_0));
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x0010F384 File Offset: 0x0010D584
		public static bool smethod_68(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemUpdateLanguage(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x0010F3C8 File Offset: 0x0010D5C8
		public static bool smethod_69(GStruct16 gstruct16_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_SetItemPreview(<Module>.smethod_15(), gstruct16_0, gclass);
			}
			return result;
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x0010F40C File Offset: 0x0010D60C
		internal static void smethod_70(bool bool_0)
		{
			GClass189.smethod_75(bool_0);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x0010F420 File Offset: 0x0010D620
		public static bool smethod_71(GStruct285 gstruct285_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamUGC_AddRequiredTag(<Module>.smethod_15(), gstruct285_0, gclass);
			}
			return result;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0010F464 File Offset: 0x0010D664
		public static GStruct285 smethod_72(GStruct216 gstruct216_0, GEnum62 genum62_0, GEnum7 genum7_0, GEnum31 genum31_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct285.smethod_2(Class177.SteamAPI_ISteamUGC_CreateQueryUserUGCRequest(<Module>.smethod_15(), gstruct216_0, genum62_0, genum7_0, genum31_0, gstruct66_0, gstruct66_1, uint_0));
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0010F494 File Offset: 0x0010D694
		public static GStruct241 smethod_73()
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems(<Module>.smethod_15()));
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0010F4B8 File Offset: 0x0010D6B8
		public static GEnum75 smethod_74(GStruct16 gstruct16_0, out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamUGC_GetItemUpdateProgress(<Module>.smethod_15(), gstruct16_0, out ulong_0, out ulong_1);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0010F4DC File Offset: 0x0010D6DC
		internal static void smethod_75(bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamUGC_SuspendDownloads(<Module>.smethod_15(), bool_0);
		}
	}
}
