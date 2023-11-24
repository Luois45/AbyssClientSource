using System;
using System.Runtime.InteropServices;
using ns151;
using ns180;
using ns189;
using ns225;
using ns226;
using ns301;
using ns370;
using ns371;
using ns372;
using ns387;
using ns54;
using ns92;

namespace ns42
{
	// Token: 0x0200002E RID: 46
	public static class GClass19
	{
		// Token: 0x0600015B RID: 347 RVA: 0x0000595C File Offset: 0x00003B5C
		public static bool smethod_0(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_CloseClanChatWindowInSteam(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000597C File Offset: 0x00003B7C
		public static int smethod_1(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetSmallFriendAvatar(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000599C File Offset: 0x00003B9C
		public static GEnum71 smethod_2(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendRelationship(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000059BC File Offset: 0x00003BBC
		public static GStruct241 smethod_3(string string_0)
		{
			GClass78.smethod_1();
			GStruct241 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_SetPersonaName(<Module>.smethod_4(), gclass));
			}
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005A08 File Offset: 0x00003C08
		internal static void smethod_4(GStruct235 gstruct235_0, GStruct22[] gstruct22_0, int int_0)
		{
			GClass19.smethod_13(gstruct235_0, gstruct22_0, int_0);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005A20 File Offset: 0x00003C20
		public static string smethod_5(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_33(gstruct22_0);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005A34 File Offset: 0x00003C34
		public static GStruct22 smethod_6(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetClanOfficerByIndex(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005A5C File Offset: 0x00003C5C
		public static bool smethod_7(GStruct22 gstruct22_0, out int int_0, out int int_1, out int int_2)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetClanActivityCounts(<Module>.smethod_4(), gstruct22_0, out int_0, out int_1, out int_2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005A7C File Offset: 0x00003C7C
		public static void smethod_8(GStruct22 gstruct22_0)
		{
			GClass19.smethod_32(gstruct22_0);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005A90 File Offset: 0x00003C90
		public static int smethod_9()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetClanCount(<Module>.smethod_4());
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public static int smethod_10(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendCountFromSource(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005AD0 File Offset: 0x00003CD0
		internal static void smethod_11(string string_0, GStruct22 gstruct22_0)
		{
			GClass19.smethod_84(string_0, gstruct22_0);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public static string smethod_12(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_76(gstruct22_0);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005AF8 File Offset: 0x00003CF8
		internal static void smethod_13(GStruct235 gstruct235_0, GStruct22[] gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_GetFriendsGroupMembersList(<Module>.smethod_4(), gstruct235_0, gstruct22_0, int_0);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005B18 File Offset: 0x00003D18
		public static void smethod_14(GStruct22 gstruct22_0, bool bool_0)
		{
			GClass19.smethod_25(gstruct22_0, bool_0);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005B2C File Offset: 0x00003D2C
		public static GStruct241 smethod_15(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_JoinClanChatRoom(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005B50 File Offset: 0x00003D50
		internal static void smethod_16(string string_0)
		{
			GClass19.smethod_60(string_0);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005B64 File Offset: 0x00003D64
		public static int smethod_17(GStruct235 gstruct235_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendsGroupMembersCount(<Module>.smethod_4(), gstruct235_0);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005B84 File Offset: 0x00003D84
		public static GEnum56 smethod_18(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendPersonaState(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public static bool smethod_19(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_IsClanChatAdmin(<Module>.smethod_4(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005BC4 File Offset: 0x00003DC4
		public static int smethod_20(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005BE4 File Offset: 0x00003DE4
		internal static string smethod_21(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005C0C File Offset: 0x00003E0C
		public static bool smethod_22(GStruct22 gstruct22_0, GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_IsUserInSource(<Module>.smethod_4(), gstruct22_0, gstruct22_1);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005C2C File Offset: 0x00003E2C
		internal static string smethod_23(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetClanName(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005C50 File Offset: 0x00003E50
		public static GStruct22 smethod_24(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetChatMemberByIndex(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005C78 File Offset: 0x00003E78
		internal static void smethod_25(GStruct22 gstruct22_0, bool bool_0)
		{
			GClass19.smethod_46(gstruct22_0, bool_0);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005C8C File Offset: 0x00003E8C
		internal static void smethod_26(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_RequestFriendRichPresence(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005CAC File Offset: 0x00003EAC
		public static int smethod_27(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetClanOfficerCount(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005CCC File Offset: 0x00003ECC
		internal static void smethod_28(GStruct66 gstruct66_0, GEnum11 genum11_0)
		{
			GClass19.smethod_56(gstruct66_0, genum11_0);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005CE0 File Offset: 0x00003EE0
		internal static void smethod_29(GStruct22 gstruct22_0)
		{
			GClass19.smethod_26(gstruct22_0);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005CF4 File Offset: 0x00003EF4
		internal static string smethod_30(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendPersonaName(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005D18 File Offset: 0x00003F18
		public static void smethod_31(string string_0)
		{
			GClass19.smethod_77(string_0);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005D2C File Offset: 0x00003F2C
		internal static void smethod_32(GStruct22 gstruct22_0)
		{
			GClass19.smethod_79(gstruct22_0);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005D40 File Offset: 0x00003F40
		internal static string smethod_33(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_30(gstruct22_0);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005D54 File Offset: 0x00003F54
		public static GStruct241 smethod_34(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_GetFollowerCount(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005D78 File Offset: 0x00003F78
		public static bool smethod_35(GStruct22 gstruct22_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_RequestUserInformation(<Module>.smethod_4(), gstruct22_0, bool_0);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005D98 File Offset: 0x00003F98
		public static int smethod_36(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetClanChatMemberCount(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public static void smethod_37(GStruct22 gstruct22_0)
		{
			GClass19.smethod_87(gstruct22_0);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005DCC File Offset: 0x00003FCC
		public static int smethod_38(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetLargeFriendAvatar(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005DEC File Offset: 0x00003FEC
		public static void smethod_39()
		{
			GClass19.smethod_92();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005E00 File Offset: 0x00004000
		public static GStruct22 smethod_40(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetClanOwner(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005E24 File Offset: 0x00004024
		internal static string smethod_41(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_55(gstruct22_0);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005E38 File Offset: 0x00004038
		public static int smethod_42(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendSteamLevel(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005E58 File Offset: 0x00004058
		internal static string smethod_43(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetPlayerNickname(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005E7C File Offset: 0x0000407C
		public static bool smethod_44(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_SetListenForFriendsMessages(<Module>.smethod_4(), bool_0);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005E9C File Offset: 0x0000409C
		internal static string smethod_45(GStruct22 gstruct22_0, string string_0)
		{
			return GClass19.smethod_81(gstruct22_0, string_0);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005EB0 File Offset: 0x000040B0
		internal static void smethod_46(GStruct22 gstruct22_0, bool bool_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_SetInGameVoiceSpeaking(<Module>.smethod_4(), gstruct22_0, bool_0);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005ED0 File Offset: 0x000040D0
		public static bool smethod_47(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_OpenClanChatWindowInSteam(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005EF0 File Offset: 0x000040F0
		internal static string smethod_48(GStruct22 gstruct22_0, int int_0)
		{
			return GClass19.smethod_21(gstruct22_0, int_0);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005F04 File Offset: 0x00004104
		public static int smethod_49(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetMediumFriendAvatar(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005F24 File Offset: 0x00004124
		public static bool smethod_50(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_IsClanOfficialGameGroup(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005F44 File Offset: 0x00004144
		public static int smethod_51(GStruct22 gstruct22_0, int int_0, out string string_0, int int_1, out GEnum30 genum30_0, out GStruct22 gstruct22_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_1);
			int num = Class177.SteamAPI_ISteamFriends_GetClanChatMessage(<Module>.smethod_4(), gstruct22_0, int_0, intPtr, int_1, out genum30_0, out gstruct22_1);
			string_0 = ((num != 0) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005F88 File Offset: 0x00004188
		public static int smethod_52(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendCoplayTime(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005FA8 File Offset: 0x000041A8
		internal static string smethod_53(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_23(gstruct22_0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005FBC File Offset: 0x000041BC
		public static GStruct22 smethod_54(int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetCoplayFriend(<Module>.smethod_4(), int_0));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005FE0 File Offset: 0x000041E0
		internal static string smethod_55(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetClanTag(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006004 File Offset: 0x00004204
		internal static void smethod_56(GStruct66 gstruct66_0, GEnum11 genum11_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_ActivateGameOverlayToStore(<Module>.smethod_4(), gstruct66_0, genum11_0);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006024 File Offset: 0x00004224
		public static GStruct241 smethod_57(uint uint_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_EnumerateFollowingList(<Module>.smethod_4(), uint_0));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006048 File Offset: 0x00004248
		public static bool smethod_58(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_IsClanPublic(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006068 File Offset: 0x00004268
		public static void smethod_59(string string_0)
		{
			GClass19.smethod_16(string_0);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000607C File Offset: 0x0000427C
		internal static void smethod_60(string string_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage(<Module>.smethod_4(), gclass);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000060BC File Offset: 0x000042BC
		internal static void smethod_61()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_ClearRichPresence(<Module>.smethod_4());
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000060D8 File Offset: 0x000042D8
		public static uint smethod_62()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetUserRestrictions(<Module>.smethod_4());
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000060F8 File Offset: 0x000042F8
		public static void smethod_63(GStruct66 gstruct66_0, GEnum11 genum11_0)
		{
			GClass19.smethod_28(gstruct66_0, genum11_0);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000610C File Offset: 0x0000430C
		internal static string smethod_64(GStruct22 gstruct22_0, int int_0)
		{
			return GClass19.smethod_90(gstruct22_0, int_0);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006120 File Offset: 0x00004320
		public static int smethod_65()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendsGroupCount(<Module>.smethod_4());
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00006140 File Offset: 0x00004340
		public static bool smethod_66(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamFriends_SendClanChatMessage(<Module>.smethod_4(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006184 File Offset: 0x00004384
		internal static string smethod_67(GStruct235 gstruct235_0)
		{
			return GClass19.smethod_72(gstruct235_0);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006198 File Offset: 0x00004398
		public static bool smethod_68(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000061B8 File Offset: 0x000043B8
		public static void smethod_69(GStruct235 gstruct235_0, GStruct22[] gstruct22_0, int int_0)
		{
			GClass19.smethod_4(gstruct235_0, gstruct22_0, int_0);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000061D0 File Offset: 0x000043D0
		public static bool smethod_70(GStruct22 gstruct22_0, GEnum28 genum28_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_HasFriend(<Module>.smethod_4(), gstruct22_0, genum28_0);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000061F0 File Offset: 0x000043F0
		internal static void smethod_71(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_SetPlayedWith(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006210 File Offset: 0x00004410
		internal static string smethod_72(GStruct235 gstruct235_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendsGroupName(<Module>.smethod_4(), gstruct235_0));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006234 File Offset: 0x00004434
		public static bool smethod_73(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_LeaveClanChatRoom(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006254 File Offset: 0x00004454
		public static string smethod_74(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_53(gstruct22_0);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006268 File Offset: 0x00004468
		public static int smethod_75(GEnum28 genum28_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendCount(<Module>.smethod_4(), genum28_0);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006288 File Offset: 0x00004488
		internal static string smethod_76(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_43(gstruct22_0);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000629C File Offset: 0x0000449C
		internal static void smethod_77(string string_0)
		{
			GClass19.smethod_101(string_0);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000062B0 File Offset: 0x000044B0
		public static GStruct22 smethod_78(int int_0, GEnum28 genum28_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendByIndex(<Module>.smethod_4(), int_0, genum28_0));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000062D8 File Offset: 0x000044D8
		internal static void smethod_79(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog(<Module>.smethod_4(), gstruct22_0);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000062F8 File Offset: 0x000044F8
		public static GStruct235 smethod_80(int int_0)
		{
			GClass78.smethod_1();
			return GStruct235.smethod_3(Class177.SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex(<Module>.smethod_4(), int_0));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000631C File Offset: 0x0000451C
		internal static string smethod_81(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			string result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendRichPresence(<Module>.smethod_4(), gstruct22_0, gclass));
			}
			return result;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006368 File Offset: 0x00004568
		public static string smethod_82(GStruct22 gstruct22_0)
		{
			return GClass19.smethod_41(gstruct22_0);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000637C File Offset: 0x0000457C
		internal static string smethod_83()
		{
			return GClass19.smethod_109();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006390 File Offset: 0x00004590
		internal static void smethod_84(string string_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamFriends_ActivateGameOverlayToUser(<Module>.smethod_4(), gclass, gstruct22_0);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000063D4 File Offset: 0x000045D4
		public static GStruct22 smethod_85(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendFromSourceByIndex(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000063FC File Offset: 0x000045FC
		public static void smethod_86(string string_0, GStruct22 gstruct22_0)
		{
			GClass19.smethod_11(string_0, gstruct22_0);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006410 File Offset: 0x00004610
		internal static void smethod_87(GStruct22 gstruct22_0)
		{
			GClass19.smethod_71(gstruct22_0);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006424 File Offset: 0x00004624
		public static bool smethod_88(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamFriends_ReplyToFriendMessage(<Module>.smethod_4(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006468 File Offset: 0x00004668
		public static GStruct66 smethod_89(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct66.smethod_3(Class177.SteamAPI_ISteamFriends_GetFriendCoplayGame(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000648C File Offset: 0x0000468C
		internal static string smethod_90(GStruct22 gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetFriendPersonaNameHistory(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000064B4 File Offset: 0x000046B4
		public static void smethod_91(GStruct22 gstruct22_0)
		{
			GClass19.smethod_29(gstruct22_0);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000064C8 File Offset: 0x000046C8
		internal static void smethod_92()
		{
			GClass19.smethod_61();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000064DC File Offset: 0x000046DC
		public static string smethod_93(GStruct235 gstruct235_0)
		{
			return GClass19.smethod_67(gstruct235_0);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000064F0 File Offset: 0x000046F0
		public static GEnum56 smethod_94()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetPersonaState(<Module>.smethod_4());
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006510 File Offset: 0x00004710
		public static string smethod_95(GStruct22 gstruct22_0, string string_0)
		{
			return GClass19.smethod_45(gstruct22_0, string_0);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006524 File Offset: 0x00004724
		public static GStruct241 smethod_96(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_RequestClanOfficerList(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006548 File Offset: 0x00004748
		public static bool smethod_97(string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamFriends_SetRichPresence(<Module>.smethod_4(), gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000065AC File Offset: 0x000047AC
		public static string smethod_98()
		{
			return GClass19.smethod_83();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000065C0 File Offset: 0x000047C0
		public static bool smethod_99(GStruct22 gstruct22_0, out GStruct122 gstruct122_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetFriendGamePlayed(<Module>.smethod_4(), gstruct22_0, out gstruct122_0);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000065E0 File Offset: 0x000047E0
		public static string smethod_100(GStruct22 gstruct22_0, int int_0)
		{
			return GClass19.smethod_48(gstruct22_0, int_0);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000065F4 File Offset: 0x000047F4
		internal static void smethod_101(string string_0)
		{
			GClass78.smethod_1();
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				Class177.SteamAPI_ISteamFriends_ActivateGameOverlay(<Module>.smethod_4(), gclass);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00006634 File Offset: 0x00004834
		public static GStruct22 smethod_102(int int_0)
		{
			GClass78.smethod_1();
			return GStruct22.smethod_0(Class177.SteamAPI_ISteamFriends_GetClanByIndex(<Module>.smethod_4(), int_0));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00006658 File Offset: 0x00004858
		public static bool smethod_103(GStruct22 gstruct22_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamFriends_InviteUserToGame(<Module>.smethod_4(), gstruct22_0, gclass);
			}
			return result;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000669C File Offset: 0x0000489C
		public static GStruct241 smethod_104(GStruct22[] gstruct22_0, int int_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_DownloadClanActivityCounts(<Module>.smethod_4(), gstruct22_0, int_0));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000066C4 File Offset: 0x000048C4
		public static GStruct241 smethod_105(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamFriends_IsFollowing(<Module>.smethod_4(), gstruct22_0));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000066E8 File Offset: 0x000048E8
		public static string smethod_106(GStruct22 gstruct22_0, int int_0)
		{
			return GClass19.smethod_64(gstruct22_0, int_0);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000066FC File Offset: 0x000048FC
		public static int smethod_107()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamFriends_GetCoplayFriendCount(<Module>.smethod_4());
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000671C File Offset: 0x0000491C
		public static int smethod_108(GStruct22 gstruct22_0, int int_0, out string string_0, int int_1, out GEnum30 genum30_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal(int_1);
			int num = Class177.SteamAPI_ISteamFriends_GetFriendMessage(<Module>.smethod_4(), gstruct22_0, int_0, intPtr, int_1, out genum30_0);
			string_0 = ((num != 0) ? GClass78.smethod_0(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00006760 File Offset: 0x00004960
		internal static string smethod_109()
		{
			GClass78.smethod_1();
			return GClass78.smethod_0(Class177.SteamAPI_ISteamFriends_GetPersonaName(<Module>.smethod_4()));
		}
	}
}
