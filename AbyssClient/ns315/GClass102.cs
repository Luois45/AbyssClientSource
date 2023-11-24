using System;
using System.Collections.Generic;
using ns151;
using ns169;
using ns203;
using ns212;
using ns226;
using ns288;
using ns330;
using ns338;
using ns350;
using ns370;
using ns387;
using ns39;
using ns503;
using ns530;
using ns54;
using ns98;

namespace ns315
{
	// Token: 0x02000279 RID: 633
	public static class GClass102
	{
		// Token: 0x06001CD5 RID: 7381 RVA: 0x000911F8 File Offset: 0x0008F3F8
		public static GStruct241 smethod_0(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0009121C File Offset: 0x0008F41C
		public static GStruct227 smethod_1(string string_0)
		{
			GClass78.smethod_1();
			GStruct227 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct227.smethod_3(Class177.SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen(<Module>.smethod_11(), gclass));
			}
			return result;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00091268 File Offset: 0x0008F468
		public static GStruct241 smethod_2(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_FileShare(<Module>.smethod_11(), gclass));
			}
			return result;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000912B4 File Offset: 0x0008F4B4
		public static GStruct241 smethod_3(GStruct78 gstruct78_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails(<Module>.smethod_11(), gstruct78_0, uint_0));
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000912DC File Offset: 0x0008F4DC
		public static GEnum2 smethod_4(string string_0)
		{
			GClass78.smethod_1();
			GEnum2 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_GetSyncPlatforms(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00091320 File Offset: 0x0008F520
		public static int smethod_5()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_GetCachedUGCCount(<Module>.smethod_11());
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00091340 File Offset: 0x0008F540
		public static bool smethod_6(string string_0, byte[] byte_0, int int_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FileWrite(<Module>.smethod_11(), gclass, byte_0, int_0);
			}
			return result;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00091384 File Offset: 0x0008F584
		public static bool smethod_7(GStruct215 gstruct215_0, IList<string> ilist_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags(<Module>.smethod_11(), gstruct215_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)));
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000913AC File Offset: 0x0008F5AC
		public static GStruct241 smethod_8(GStruct22 gstruct22_0, uint uint_0, IList<string> ilist_0, IList<string> ilist_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(<Module>.smethod_11(), gstruct22_0, uint_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)), GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_1))));
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000913E8 File Offset: 0x0008F5E8
		public static GStruct241 smethod_9(string string_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_FileWriteAsync(<Module>.smethod_11(), gclass, byte_0, uint_0));
			}
			return result;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00091434 File Offset: 0x0008F634
		public static bool smethod_10(GStruct241 gstruct241_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete(<Module>.smethod_11(), gstruct241_0, byte_0, uint_0);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00091454 File Offset: 0x0008F654
		public static long smethod_11(string string_0)
		{
			GClass78.smethod_1();
			long result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_GetFileTimestamp(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00091498 File Offset: 0x0008F698
		public static GStruct241 smethod_12(GStruct215 gstruct215_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate(<Module>.smethod_11(), gstruct215_0));
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000914BC File Offset: 0x0008F6BC
		public static int smethod_13(string string_0)
		{
			GClass78.smethod_1();
			int result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_GetFileSize(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00091500 File Offset: 0x0008F700
		public static GStruct241 smethod_14(GEnum38 genum38_0, string string_0, string string_1, string string_2, GStruct66 gstruct66_0, string string_3, string string_4, GEnum86 genum86_0, IList<string> ilist_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					using (GClass78.GClass79 gclass3 = new GClass78.GClass79(string_2))
					{
						using (GClass78.GClass79 gclass4 = new GClass78.GClass79(string_3))
						{
							using (GClass78.GClass79 gclass5 = new GClass78.GClass79(string_4))
							{
								result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_PublishVideo(<Module>.smethod_11(), genum38_0, gclass, gclass2, gclass3, gstruct66_0, gclass4, gclass5, genum86_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0))));
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x000915E8 File Offset: 0x0008F7E8
		internal static string smethod_15(int int_0, ref int int_1)
		{
			return GClass102.smethod_58(int_0, ref int_1);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000915FC File Offset: 0x0008F7FC
		public static GStruct241 smethod_16(uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles(<Module>.smethod_11(), uint_0));
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00091620 File Offset: 0x0008F820
		public static GStruct241 smethod_17(uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles(<Module>.smethod_11(), uint_0));
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00091644 File Offset: 0x0008F844
		internal static void smethod_18(bool bool_0)
		{
			GClass102.smethod_21(bool_0);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00091658 File Offset: 0x0008F858
		public static GStruct241 smethod_19(string string_0, string string_1, GStruct66 gstruct66_0, string string_2, string string_3, GEnum86 genum86_0, IList<string> ilist_0, GEnum66 genum66_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					using (GClass78.GClass79 gclass3 = new GClass78.GClass79(string_2))
					{
						using (GClass78.GClass79 gclass4 = new GClass78.GClass79(string_3))
						{
							result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_PublishWorkshopFile(<Module>.smethod_11(), gclass, gclass2, gstruct66_0, gclass3, gclass4, genum86_0, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)), genum66_0));
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0009171C File Offset: 0x0008F91C
		public static GStruct241 smethod_20(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00091740 File Offset: 0x0008F940
		internal static void smethod_21(bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp(<Module>.smethod_11(), bool_0);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00091760 File Offset: 0x0008F960
		public static GStruct241 smethod_22(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_SubscribePublishedFile(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00091784 File Offset: 0x0008F984
		public static bool smethod_23(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FileForget(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000917C8 File Offset: 0x0008F9C8
		public static int smethod_24(GStruct96 gstruct96_0, byte[] byte_0, int int_0, uint uint_0, GEnum15 genum15_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_UGCRead(<Module>.smethod_11(), gstruct96_0, byte_0, int_0, uint_0, genum15_0);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000917EC File Offset: 0x0008F9EC
		public static bool smethod_25(GStruct227 gstruct227_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_FileWriteStreamClose(<Module>.smethod_11(), gstruct227_0);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0009180C File Offset: 0x0008FA0C
		public static bool smethod_26(GStruct215 gstruct215_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle(<Module>.smethod_11(), gstruct215_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00091850 File Offset: 0x0008FA50
		public static GStruct241 smethod_27(GStruct96 gstruct96_0, string string_0, uint uint_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation(<Module>.smethod_11(), gstruct96_0, gclass, uint_0));
			}
			return result;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0009189C File Offset: 0x0008FA9C
		public static GStruct241 smethod_28(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000918C0 File Offset: 0x0008FAC0
		public static bool smethod_29(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FileDelete(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00091904 File Offset: 0x0008FB04
		public static GStruct241 smethod_30(string string_0, uint uint_0, uint uint_1)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_FileReadAsync(<Module>.smethod_11(), gclass, uint_0, uint_1));
			}
			return result;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00091950 File Offset: 0x0008FB50
		public static void smethod_31(bool bool_0)
		{
			GClass102.smethod_18(bool_0);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00091964 File Offset: 0x0008FB64
		public static bool smethod_32(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FilePersisted(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000919A8 File Offset: 0x0008FBA8
		public static GStruct241 smethod_33(GEnum90 genum90_0, uint uint_0, uint uint_1, uint uint_2, IList<string> ilist_0, IList<string> ilist_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(<Module>.smethod_11(), genum90_0, uint_0, uint_1, uint_2, GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_0)), GClass78.GClass80.smethod_0(new GClass78.GClass80(ilist_1))));
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000919E8 File Offset: 0x0008FBE8
		public static bool smethod_34(GStruct215 gstruct215_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile(<Module>.smethod_11(), gstruct215_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00091A2C File Offset: 0x0008FC2C
		public static bool smethod_35(GStruct227 gstruct227_0, byte[] byte_0, int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk(<Module>.smethod_11(), gstruct227_0, byte_0, int_0);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00091A4C File Offset: 0x0008FC4C
		public static bool smethod_36(GStruct215 gstruct215_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription(<Module>.smethod_11(), gstruct215_0, gclass);
			}
			return result;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00091A90 File Offset: 0x0008FC90
		public static bool smethod_37(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FileExists(<Module>.smethod_11(), gclass);
			}
			return result;
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00091AD4 File Offset: 0x0008FCD4
		public static string smethod_38(int int_0, out int int_1)
		{
			return GClass102.smethod_15(int_0, ref int_1);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00091AE8 File Offset: 0x0008FCE8
		public static int smethod_39()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_GetFileCount(<Module>.smethod_11());
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00091B08 File Offset: 0x0008FD08
		public static GStruct241 smethod_40(GStruct96 gstruct96_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_UGCDownload(<Module>.smethod_11(), gstruct96_0, uint_0));
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00091B30 File Offset: 0x0008FD30
		public static bool smethod_41()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount(<Module>.smethod_11());
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00091B4C File Offset: 0x0008FD4C
		public static GStruct241 smethod_42(GStruct78 gstruct78_0, GEnum53 genum53_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction(<Module>.smethod_11(), gstruct78_0, genum53_0));
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00091B74 File Offset: 0x0008FD74
		public static bool smethod_43()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp(<Module>.smethod_11());
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00091B90 File Offset: 0x0008FD90
		public static GStruct241 smethod_44(GStruct78 gstruct78_0, bool bool_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote(<Module>.smethod_11(), gstruct78_0, bool_0));
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00091BB8 File Offset: 0x0008FDB8
		public static int smethod_45(string string_0, byte[] byte_0, int int_0)
		{
			GClass78.smethod_1();
			int result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_FileRead(<Module>.smethod_11(), gclass, byte_0, int_0);
			}
			return result;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00091C00 File Offset: 0x0008FE00
		public static bool smethod_46(GStruct227 gstruct227_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel(<Module>.smethod_11(), gstruct227_0);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00091C20 File Offset: 0x0008FE20
		public static bool smethod_47(GStruct96 gstruct96_0, out GStruct66 gstruct66_0, out string string_0, out int int_0, out GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			IntPtr intptr_;
			bool flag = Class177.SteamAPI_ISteamRemoteStorage_GetUGCDetails(<Module>.smethod_11(), gstruct96_0, out gstruct66_0, out intptr_, out int_0, out gstruct22_0);
			string_0 = (flag ? GClass78.smethod_0(intptr_) : null);
			return flag;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00091C54 File Offset: 0x0008FE54
		public static GStruct96 smethod_48(int int_0)
		{
			GClass78.smethod_1();
			return GStruct96.smethod_1(Class177.SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle(<Module>.smethod_11(), int_0));
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00091C78 File Offset: 0x0008FE78
		public static bool smethod_49(GStruct215 gstruct215_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile(<Module>.smethod_11(), gstruct215_0, gclass);
			}
			return result;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00091CBC File Offset: 0x0008FEBC
		public static bool smethod_50(GStruct96 gstruct96_0, out int int_0, out int int_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress(<Module>.smethod_11(), gstruct96_0, out int_0, out int_1);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00091CDC File Offset: 0x0008FEDC
		public static GStruct215 smethod_51(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct215.smethod_2(Class177.SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00091D00 File Offset: 0x0008FF00
		public static bool smethod_52(GStruct215 gstruct215_0, GEnum86 genum86_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility(<Module>.smethod_11(), gstruct215_0, genum86_0);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00091D20 File Offset: 0x0008FF20
		public static GStruct241 smethod_53(GStruct78 gstruct78_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_DeletePublishedFile(<Module>.smethod_11(), gstruct78_0));
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00091D44 File Offset: 0x0008FF44
		public static bool smethod_54(string string_0, GEnum2 genum2_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_SetSyncPlatforms(<Module>.smethod_11(), gclass, genum2_0);
			}
			return result;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00091D88 File Offset: 0x0008FF88
		public static bool smethod_55(out ulong ulong_0, out ulong ulong_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamRemoteStorage_GetQuota(<Module>.smethod_11(), out ulong_0, out ulong_1);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00091DA8 File Offset: 0x0008FFA8
		public static GStruct241 smethod_56(GEnum53 genum53_0, uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(<Module>.smethod_11(), genum53_0, uint_0));
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00091DD0 File Offset: 0x0008FFD0
		public static bool smethod_57(GStruct215 gstruct215_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(<Module>.smethod_11(), gstruct215_0, gclass);
			}
			return result;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00091E14 File Offset: 0x00090014
		internal static string smethod_58(int int_0, ref int int_1)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamRemoteStorage_GetFileNameAndSize(<Module>.smethod_11(), int_0, out int_1));
		}
	}
}
