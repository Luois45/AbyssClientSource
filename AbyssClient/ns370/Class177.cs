using System;
using System.Runtime.InteropServices;
using System.Security;
using ns103;
using ns117;
using ns118;
using ns120;
using ns125;
using ns132;
using ns140;
using ns142;
using ns151;
using ns152;
using ns169;
using ns170;
using ns173;
using ns179;
using ns180;
using ns189;
using ns191;
using ns195;
using ns203;
using ns207;
using ns212;
using ns213;
using ns22;
using ns225;
using ns226;
using ns236;
using ns243;
using ns26;
using ns266;
using ns273;
using ns274;
using ns279;
using ns280;
using ns286;
using ns288;
using ns291;
using ns297;
using ns3;
using ns301;
using ns304;
using ns312;
using ns317;
using ns319;
using ns323;
using ns330;
using ns331;
using ns332;
using ns333;
using ns336;
using ns338;
using ns343;
using ns346;
using ns348;
using ns35;
using ns350;
using ns353;
using ns364;
using ns371;
using ns372;
using ns383;
using ns386;
using ns387;
using ns39;
using ns396;
using ns398;
using ns403;
using ns41;
using ns419;
using ns489;
using ns50;
using ns503;
using ns506;
using ns507;
using ns515;
using ns52;
using ns528;
using ns530;
using ns537;
using ns54;
using ns547;
using ns548;
using ns549;
using ns552;
using ns554;
using ns558;
using ns72;
using ns74;
using ns79;
using ns89;
using ns92;
using ns96;
using ns98;

namespace ns370
{
	// Token: 0x020002DA RID: 730
	[SuppressUnmanagedCodeSecurity]
	internal static class Class177
	{
		// Token: 0x06002211 RID: 8721
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SetProperty0(IntPtr intptr_0, GStruct24 gstruct24_0, GStruct7 gstruct7_0, GClass78.GClass79 gclass79_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002212 RID: 8722
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_IsAPICallCompleted(IntPtr intptr_0, GStruct241 gstruct241_0, out bool bool_0);

		// Token: 0x06002213 RID: 8723
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_GetP2PSessionState(IntPtr intptr_0, GStruct22 gstruct22_0, out GStruct9 gstruct9_0);

		// Token: 0x06002214 RID: 8724
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_AddAppDependency(IntPtr intptr_0, GStruct78 gstruct78_0, GStruct66 gstruct66_0);

		// Token: 0x06002215 RID: 8725
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_ExecuteJavascript(IntPtr intptr_0, GStruct43 gstruct43_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002216 RID: 8726
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_SetAchievement(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002217 RID: 8727
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetAchievementAchievedPercent(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out float float_0);

		// Token: 0x06002218 RID: 8728
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_PublishVideo(IntPtr intptr_0, GEnum38 genum38_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GClass78.GClass79 gclass79_2, GStruct66 gstruct66_0, GClass78.GClass79 gclass79_3, GClass78.GClass79 gclass79_4, GEnum86 genum86_0, IntPtr intptr_1);

		// Token: 0x06002219 RID: 8729
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600221A RID: 8730
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_AddFavoriteGame(IntPtr intptr_0, GStruct66 gstruct66_0, uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1, uint uint_2);

		// Token: 0x0600221B RID: 8731
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetGameTags(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600221C RID: 8732
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetSpectatorPort(IntPtr intptr_0, ushort ushort_0);

		// Token: 0x0600221D RID: 8733
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600221E RID: 8734
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamController_Init(IntPtr intptr_0);

		// Token: 0x0600221F RID: 8735
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddExcludedTag(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002220 RID: 8736
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_DestroySocket(IntPtr intptr_0, GStruct208 gstruct208_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002221 RID: 8737
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamRemoteStorage_GetCachedUGCCount(IntPtr intptr_0);

		// Token: 0x06002222 RID: 8738
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_MouseMove(IntPtr intptr_0, GStruct43 gstruct43_0, int int_0, int int_1);

		// Token: 0x06002223 RID: 8739
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GStruct1 SteamAPI_ISteamController_GetAnalogActionData(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct189 gstruct189_0);

		// Token: 0x06002224 RID: 8740
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr intptr_0, GClass78.GClass79 gclass79_0, int int_0);

		// Token: 0x06002225 RID: 8741
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMusic_PlayNext(IntPtr intptr_0);

		// Token: 0x06002226 RID: 8742
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetClanOfficerByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002227 RID: 8743
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetMaxPlayerCount(IntPtr intptr_0, int int_0);

		// Token: 0x06002228 RID: 8744
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendSteamLevel(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002229 RID: 8745
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamScreenshots(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600222A RID: 8746
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_ResetPlaylistEntries(IntPtr intptr_0);

		// Token: 0x0600222B RID: 8747
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsParentalLockLocked(IntPtr intptr_0);

		// Token: 0x0600222C RID: 8748
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RunCallbacks(GStruct128 gstruct128_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600222D RID: 8749
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamRemoteStorage_FileRead(IntPtr intptr_0, GClass78.GClass79 gclass79_0, byte[] byte_0, int int_0);

		// Token: 0x0600222E RID: 8750
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamApps_GetCurrentGameLanguage(IntPtr intptr_0);

		// Token: 0x0600222F RID: 8751
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002230 RID: 8752
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_AllowP2PPacketRelay(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002231 RID: 8753
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToUser(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GStruct22 gstruct22_0);

		// Token: 0x06002232 RID: 8754
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetPasswordProtected(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002233 RID: 8755
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID(byte[] byte_0, uint uint_0);

		// Token: 0x06002234 RID: 8756
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr intptr_0);

		// Token: 0x06002235 RID: 8757
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamScreenshots_IsScreenshotsHooked(IntPtr intptr_0);

		// Token: 0x06002236 RID: 8758
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamScreenshots_WriteScreenshot(IntPtr intptr_0, byte[] byte_0, uint uint_0, int int_0, int int_1);

		// Token: 0x06002237 RID: 8759
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamRemoteStorage_UGCRead(IntPtr intptr_0, GStruct96 gstruct96_0, byte[] byte_0, int int_0, uint uint_0, GEnum15 genum15_0);

		// Token: 0x06002238 RID: 8760
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamUGC(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002239 RID: 8761
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_CreateItem(IntPtr intptr_0, GStruct66 gstruct66_0, GEnum66 genum66_0);

		// Token: 0x0600223A RID: 8762
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_SetStat0(IntPtr intptr_0, GClass78.GClass79 gclass79_0, float float_0);

		// Token: 0x0600223B RID: 8763
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetHorizontalScroll(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0);

		// Token: 0x0600223C RID: 8764
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600223D RID: 8765
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_QueueDidChange(IntPtr intptr_0);

		// Token: 0x0600223E RID: 8766
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_IsClanOfficialGameGroup(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600223F RID: 8767
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendCount(IntPtr intptr_0, GEnum28 genum28_0);

		// Token: 0x06002240 RID: 8768
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_RestartAppIfNecessary(GStruct66 gstruct66_0);

		// Token: 0x06002241 RID: 8769
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x06002242 RID: 8770
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_IndicateAchievementProgress(IntPtr intptr_0, GClass78.GClass79 gclass79_0, uint uint_0, uint uint_1);

		// Token: 0x06002243 RID: 8771
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum49 SteamAPI_ISteamUserStats_GetLeaderboardDisplayType(IntPtr intptr_0, GStruct305 gstruct305_0);

		// Token: 0x06002244 RID: 8772
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr intptr_0, GStruct188 gstruct188_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002245 RID: 8773
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_GoBack(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x06002246 RID: 8774
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BLoggedOn(IntPtr intptr_0);

		// Token: 0x06002247 RID: 8775
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamInventory_StartUpdateProperties(IntPtr intptr_0);

		// Token: 0x06002248 RID: 8776
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_ReleaseQueryUGCRequest(IntPtr intptr_0, GStruct285 gstruct285_0);

		// Token: 0x06002249 RID: 8777
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetCoplayFriend(IntPtr intptr_0, int int_0);

		// Token: 0x0600224A RID: 8778
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_MarkContentCorrupt(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600224B RID: 8779
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemUpdateLanguage(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600224C RID: 8780
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetClanChatMemberCount(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600224D RID: 8781
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnKeyValueTags(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600224E RID: 8782
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUser_RequestEncryptedAppTicket(IntPtr intptr_0, byte[] byte_0, int int_0);

		// Token: 0x0600224F RID: 8783
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamRemoteStorage_GetFileNameAndSize(IntPtr intptr_0, int int_0, out int int_1);

		// Token: 0x06002250 RID: 8784
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUser_GetHSteamUser(IntPtr intptr_0);

		// Token: 0x06002251 RID: 8785
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsSubscribed(IntPtr intptr_0);

		// Token: 0x06002252 RID: 8786
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_RemoveBrowser(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x06002253 RID: 8787
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp(byte[] byte_0, uint uint_0, GStruct66 gstruct66_0);

		// Token: 0x06002254 RID: 8788
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamClient_BShutdownIfAllPipesClosed(IntPtr intptr_0);

		// Token: 0x06002255 RID: 8789
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnAdditionalPreviews(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002256 RID: 8790
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetAchievementIcon(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002257 RID: 8791
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetChatMemberByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002258 RID: 8792
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamController_Shutdown(IntPtr intptr_0);

		// Token: 0x06002259 RID: 8793
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600225A RID: 8794
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_GetUserItemVote(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600225B RID: 8795
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMusic_Pause(IntPtr intptr_0);

		// Token: 0x0600225C RID: 8796
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPResponseBodySize(IntPtr intptr_0, GStruct188 gstruct188_0, out uint uint_0);

		// Token: 0x0600225D RID: 8797
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_PrioritizeHTTPRequest(IntPtr intptr_0, GStruct188 gstruct188_0);

		// Token: 0x0600225E RID: 8798
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_TriggerItemDrop(IntPtr intptr_0, out GStruct31 gstruct31_0, GStruct36 gstruct36_0);

		// Token: 0x0600225F RID: 8799
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetItemPrice(IntPtr intptr_0, GStruct36 gstruct36_0, out ulong ulong_0);

		// Token: 0x06002260 RID: 8800
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetFriendByIndex(IntPtr intptr_0, int int_0, GEnum28 genum28_0);

		// Token: 0x06002261 RID: 8801
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendCountFromSource(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002262 RID: 8802
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetSecondsSinceComputerActive(IntPtr intptr_0);

		// Token: 0x06002263 RID: 8803
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_GetLinkAtPosition(IntPtr intptr_0, GStruct43 gstruct43_0, int int_0, int int_1);

		// Token: 0x06002264 RID: 8804
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamVideo_GetOPFSettings(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002265 RID: 8805
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_GetLobbyDataCount(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002266 RID: 8806
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamUserStats_GetAchievementName(IntPtr intptr_0, uint uint_0);

		// Token: 0x06002267 RID: 8807
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCMetadata(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, IntPtr intptr_1, uint uint_1);

		// Token: 0x06002268 RID: 8808
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_SetPersonaName(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002269 RID: 8809
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateVolume(IntPtr intptr_0, float float_0);

		// Token: 0x0600226A RID: 8810
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamApps_GetAppBuildId(IntPtr intptr_0);

		// Token: 0x0600226B RID: 8811
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_TriggerVibration(IntPtr intptr_0, GStruct83 gstruct83_0, ushort ushort_0, ushort ushort_1);

		// Token: 0x0600226C RID: 8812
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr intptr_0, GStruct227 gstruct227_0, byte[] byte_0, int int_0);

		// Token: 0x0600226D RID: 8813
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetSpectatorServerName(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600226E RID: 8814
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr intptr_0, uint uint_0);

		// Token: 0x0600226F RID: 8815
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMusic_Play(IntPtr intptr_0);

		// Token: 0x06002270 RID: 8816
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemPreview(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002271 RID: 8817
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_BActivationSuccess(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002272 RID: 8818
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_HandleIncomingPacket(IntPtr intptr_0, byte[] byte_0, int int_0, uint uint_0, ushort ushort_0);

		// Token: 0x06002273 RID: 8819
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetAllItems(IntPtr intptr_0, out GStruct31 gstruct31_0);

		// Token: 0x06002274 RID: 8820
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_CloseP2PSessionWithUser(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002275 RID: 8821
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_DeactivateActionSetLayer(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct290 gstruct290_0);

		// Token: 0x06002276 RID: 8822
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_UpdateItemPreviewVideo(IntPtr intptr_0, GStruct16 gstruct16_0, uint uint_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002277 RID: 8823
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_RequestCurrentStats(IntPtr intptr_0);

		// Token: 0x06002278 RID: 8824
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetClanName(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002279 RID: 8825
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetGlobalStat(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out long long_0);

		// Token: 0x0600227A RID: 8826
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetEnteredGamepadTextLength(IntPtr intptr_0);

		// Token: 0x0600227B RID: 8827
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCChildren(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, [In] [Out] GStruct78[] gstruct78_0, uint uint_1);

		// Token: 0x0600227C RID: 8828
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum54 SteamAPI_ISteamInventory_GetResultStatus(IntPtr intptr_0, GStruct31 gstruct31_0);

		// Token: 0x0600227D RID: 8829
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr intptr_0, GStruct215 gstruct215_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600227E RID: 8830
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLobbyData(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600227F RID: 8831
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse(IntPtr intptr_0, GStruct43 gstruct43_0, IntPtr intptr_1);

		// Token: 0x06002280 RID: 8832
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum87 SteamAPI_ISteamGameServer_UserHasLicenseForApp(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct66 gstruct66_0);

		// Token: 0x06002281 RID: 8833
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetUserStat0(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out float float_0);

		// Token: 0x06002282 RID: 8834
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmakingServers_IsRefreshing(IntPtr intptr_0, GStruct240 gstruct240_0);

		// Token: 0x06002283 RID: 8835
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamUtils_GetSteamUILanguage(IntPtr intptr_0);

		// Token: 0x06002284 RID: 8836
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetItemDefinitionProperty(IntPtr intptr_0, GStruct36 gstruct36_0, GClass78.GClass79 gclass79_0, IntPtr intptr_1, ref uint uint_0);

		// Token: 0x06002285 RID: 8837
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum67 SteamAPI_ISteamUser_GetVoice(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0, byte[] byte_0, uint uint_0, out uint uint_1, [MarshalAs(UnmanagedType.I1)] bool bool_1, IntPtr intptr_1, uint uint_2, IntPtr intptr_2, uint uint_3);

		// Token: 0x06002286 RID: 8838
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnablePlayPrevious(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002287 RID: 8839
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_IsSteamInBigPictureMode(IntPtr intptr_0);

		// Token: 0x06002288 RID: 8840
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_FileWriteAsync(IntPtr intptr_0, GClass78.GClass79 gclass79_0, byte[] byte_0, uint uint_0);

		// Token: 0x06002289 RID: 8841
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetProduct(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600228A RID: 8842
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_StopVoiceRecording(IntPtr intptr_0);

		// Token: 0x0600228B RID: 8843
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUser_GetPlayerSteamLevel(IntPtr intptr_0);

		// Token: 0x0600228C RID: 8844
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_ActivateActionSet(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct290 gstruct290_0);

		// Token: 0x0600228D RID: 8845
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600228E RID: 8846
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallResult(IntPtr intptr_0, ulong ulong_0);

		// Token: 0x0600228F RID: 8847
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetClanByIndex(IntPtr intptr_0, int int_0);

		// Token: 0x06002290 RID: 8848
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamFriends_GetFriendCoplayGame(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002291 RID: 8849
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_SetLobbyMemberData(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x06002292 RID: 8850
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x06002293 RID: 8851
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002294 RID: 8852
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamHTTP(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002295 RID: 8853
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamApps(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002296 RID: 8854
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_GetLobbyChatEntry(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0, out GStruct22 gstruct22_1, byte[] byte_0, int int_1, out GEnum30 genum30_0);

		// Token: 0x06002297 RID: 8855
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_RemoveItemKeyValueTags(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002298 RID: 8856
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_SetLobbyGameServer(IntPtr intptr_0, GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, GStruct22 gstruct22_1);

		// Token: 0x06002299 RID: 8857
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServerStats_RequestUserStats(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600229A RID: 8858
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_ResetAllStats(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600229B RID: 8859
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum67 SteamAPI_ISteamUser_GetAvailableVoice(IntPtr intptr_0, out uint uint_0, IntPtr intptr_1, uint uint_1);

		// Token: 0x0600229C RID: 8860
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetItemInstallInfo(IntPtr intptr_0, GStruct78 gstruct78_0, out ulong ulong_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

		// Token: 0x0600229D RID: 8861
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetSmallFriendAvatar(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600229E RID: 8862
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled(IntPtr intptr_0);

		// Token: 0x0600229F RID: 8863
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamVideo_IsBroadcasting(IntPtr intptr_0, out int int_0);

		// Token: 0x060022A0 RID: 8864
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendMessage(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0, IntPtr intptr_1, int int_1, out GEnum30 genum30_0);

		// Token: 0x060022A1 RID: 8865
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_PasteFromClipboard(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x060022A2 RID: 8866
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetRegion(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022A3 RID: 8867
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnPlaytimeStats(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0);

		// Token: 0x060022A4 RID: 8868
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetFriendPersonaNameHistory(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x060022A5 RID: 8869
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SerializeResult(IntPtr intptr_0, GStruct31 gstruct31_0, byte[] byte_0, out uint uint_0);

		// Token: 0x060022A6 RID: 8870
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_CreateQueryAllUGCRequest(IntPtr intptr_0, GEnum93 genum93_0, GEnum7 genum7_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0);

		// Token: 0x060022A7 RID: 8871
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemDescription(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022A8 RID: 8872
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemTags(IntPtr intptr_0, GStruct16 gstruct16_0, IntPtr intptr_1);

		// Token: 0x060022A9 RID: 8873
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr intptr_0, GEnum90 genum90_0, uint uint_0, uint uint_1, uint uint_2, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x060022AA RID: 8874
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamClient_ConnectToGlobalUser(IntPtr intptr_0, GStruct128 gstruct128_0);

		// Token: 0x060022AB RID: 8875
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_RequestUGCDetails(IntPtr intptr_0, GStruct78 gstruct78_0, uint uint_0);

		// Token: 0x060022AC RID: 8876
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_IsDataAvailableOnSocket(IntPtr intptr_0, GStruct208 gstruct208_0, out uint uint_0);

		// Token: 0x060022AD RID: 8877
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_ReleaseCookieContainer(IntPtr intptr_0, GStruct207 gstruct207_0);

		// Token: 0x060022AE RID: 8878
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_LogOnAnonymous(IntPtr intptr_0);

		// Token: 0x060022AF RID: 8879
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_RemoveItemPreview(IntPtr intptr_0, GStruct16 gstruct16_0, uint uint_0);

		// Token: 0x060022B0 RID: 8880
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_RequestClanOfficerList(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022B1 RID: 8881
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetVerticalScroll(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0);

		// Token: 0x060022B2 RID: 8882
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMusic_SetVolume(IntPtr intptr_0, float float_0);

		// Token: 0x060022B3 RID: 8883
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SetProperty(IntPtr intptr_0, GStruct24 gstruct24_0, GStruct7 gstruct7_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x060022B4 RID: 8884
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060022B5 RID: 8885
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamFriends(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022B6 RID: 8886
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, out float float_0, out bool bool_0);

		// Token: 0x060022B7 RID: 8887
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out bool bool_0, out uint uint_0);

		// Token: 0x060022B8 RID: 8888
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamApps_GetFileDetails(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022B9 RID: 8889
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamGenericInterface(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022BA RID: 8890
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetMapName(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022BB RID: 8891
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, float float_0, double double_0);

		// Token: 0x060022BC RID: 8892
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamVideo_GetVideoURL(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060022BD RID: 8893
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr intptr_0);

		// Token: 0x060022BE RID: 8894
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetHeartbeatInterval(IntPtr intptr_0, int int_0);

		// Token: 0x060022BF RID: 8895
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_DeserializeResult(IntPtr intptr_0, out GStruct31 gstruct31_0, byte[] byte_0, uint uint_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060022C0 RID: 8896
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_AddItemToFavorites(IntPtr intptr_0, GStruct66 gstruct66_0, GStruct78 gstruct78_0);

		// Token: 0x060022C1 RID: 8897
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_SubmitItemUpdate(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022C2 RID: 8898
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr intptr_0);

		// Token: 0x060022C3 RID: 8899
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateShuffled(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060022C4 RID: 8900
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList(IntPtr intptr_0, GEnum3 genum3_0);

		// Token: 0x060022C5 RID: 8901
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_SetUserStat0(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, float float_0);

		// Token: 0x060022C6 RID: 8902
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_CheckResultSteamID(IntPtr intptr_0, GStruct31 gstruct31_0, GStruct22 gstruct22_0);

		// Token: 0x060022C7 RID: 8903
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_JSDialogResponse(IntPtr intptr_0, GStruct43 gstruct43_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060022C8 RID: 8904
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_GetLobbyByIndex(IntPtr intptr_0, int int_0);

		// Token: 0x060022C9 RID: 8905
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamInventory_GetResultTimestamp(IntPtr intptr_0, GStruct31 gstruct31_0);

		// Token: 0x060022CA RID: 8906
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamHTMLSurface(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022CB RID: 8907
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_GetGameplayStats(IntPtr intptr_0);

		// Token: 0x060022CC RID: 8908
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr intptr_0, [In] [Out] GStruct78[] gstruct78_0, uint uint_0);

		// Token: 0x060022CD RID: 8909
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SteamAPI_ISteamUtils_GetCurrentBatteryPower(IntPtr intptr_0);

		// Token: 0x060022CE RID: 8910
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_SubscribePublishedFile(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x060022CF RID: 8911
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_GetUserAchievement(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out bool bool_0);

		// Token: 0x060022D0 RID: 8912
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_BSecure(IntPtr intptr_0);

		// Token: 0x060022D1 RID: 8913
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetItemDefinitionIDs(IntPtr intptr_0, [In] [Out] GStruct36[] gstruct36_0, out uint uint_0);

		// Token: 0x060022D2 RID: 8914
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, uint uint_1, IntPtr intptr_1, uint uint_2, IntPtr intptr_2, uint uint_3);

		// Token: 0x060022D3 RID: 8915
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_EnumerateFollowingList(IntPtr intptr_0, uint uint_0);

		// Token: 0x060022D4 RID: 8916
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0, IntPtr intptr_1, int int_1, IntPtr intptr_2, int int_2);

		// Token: 0x060022D5 RID: 8917
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallback(IntPtr intptr_0);

		// Token: 0x060022D6 RID: 8918
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern long SteamAPI_ISteamRemoteStorage_GetFileTimestamp(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022D7 RID: 8919
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamVideo(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022D8 RID: 8920
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum56 SteamAPI_ISteamFriends_GetFriendPersonaState(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022D9 RID: 8921
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTMLSurface_Init(IntPtr intptr_0);

		// Token: 0x060022DA RID: 8922
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUser_GetVoiceOptimalSampleRate(IntPtr intptr_0);

		// Token: 0x060022DB RID: 8923
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr intptr_0, uint uint_0, byte[] byte_0, uint uint_1, out GStruct22 gstruct22_0);

		// Token: 0x060022DC RID: 8924
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_Shutdown();

		// Token: 0x060022DD RID: 8925
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileWrite(IntPtr intptr_0, GClass78.GClass79 gclass79_0, byte[] byte_0, int int_0);

		// Token: 0x060022DE RID: 8926
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr intptr_0, GStruct78 gstruct78_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060022DF RID: 8927
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamController(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022E0 RID: 8928
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLobbyType(IntPtr intptr_0, GStruct22 gstruct22_0, GEnum91 genum91_0);

		// Token: 0x060022E1 RID: 8929
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamAppList_GetAppBuildId(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060022E2 RID: 8930
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		// Token: 0x060022E3 RID: 8931
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum87 SteamAPI_ISteamUser_UserHasLicenseForApp(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct66 gstruct66_0);

		// Token: 0x060022E4 RID: 8932
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x060022E5 RID: 8933
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUser_GetAuthSessionTicket(IntPtr intptr_0, byte[] byte_0, int int_0, out uint uint_0);

		// Token: 0x060022E6 RID: 8934
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_CreateInterface(GClass78.GClass79 gclass79_0);

		// Token: 0x060022E7 RID: 8935
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr intptr_0, GStruct188 gstruct188_0, out GStruct241 gstruct241_0);

		// Token: 0x060022E8 RID: 8936
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_DestroyListenSocket(IntPtr intptr_0, GStruct229 gstruct229_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060022E9 RID: 8937
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_IsSteamRunning();

		// Token: 0x060022EA RID: 8938
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr intptr_0, GEnum96 genum96_0);

		// Token: 0x060022EB RID: 8939
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetBotPlayerCount(IntPtr intptr_0, int int_0);

		// Token: 0x060022EC RID: 8940
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_InitSafe(uint uint_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, GEnum14 genum14_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022ED RID: 8941
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetSize(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0, uint uint_1);

		// Token: 0x060022EE RID: 8942
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr intptr_0);

		// Token: 0x060022EF RID: 8943
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetClanOfficerCount(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022F0 RID: 8944
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum61 SteamAPI_ISteamUserStats_GetLeaderboardSortMethod(IntPtr intptr_0, GStruct305 gstruct305_0);

		// Token: 0x060022F1 RID: 8945
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileForget(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060022F2 RID: 8946
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_UpdateAvgRateStat(IntPtr intptr_0, GClass78.GClass79 gclass79_0, float float_0, double double_0);

		// Token: 0x060022F3 RID: 8947
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_GetLobbyOwner(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022F4 RID: 8948
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_GetUserStat(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out int int_0);

		// Token: 0x060022F5 RID: 8949
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_GetNumLobbyMembers(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022F6 RID: 8950
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsCybercafe(IntPtr intptr_0);

		// Token: 0x060022F7 RID: 8951
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x060022F8 RID: 8952
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel(IntPtr intptr_0, GStruct227 gstruct227_0);

		// Token: 0x060022F9 RID: 8953
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022FA RID: 8954
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022FB RID: 8955
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr intptr_0, GStruct188 gstruct188_0, uint uint_0);

		// Token: 0x060022FC RID: 8956
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServer_AssociateWithClan(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060022FD RID: 8957
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamScreenshots_AddScreenshotToLibrary(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, int int_0, int int_1);

		// Token: 0x060022FE RID: 8958
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID(byte[] byte_0, uint uint_0, out GStruct22 gstruct22_0);

		// Token: 0x060022FF RID: 8959
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemVisibility(IntPtr intptr_0, GStruct16 gstruct16_0, GEnum86 genum86_0);

		// Token: 0x06002300 RID: 8960
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_DeferHTTPRequest(IntPtr intptr_0, GStruct188 gstruct188_0);

		// Token: 0x06002301 RID: 8961
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_GetDlcDownloadProgress(IntPtr intptr_0, GStruct66 gstruct66_0, out ulong ulong_0, out ulong ulong_1);

		// Token: 0x06002302 RID: 8962
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_CurrentEntryWillChange(IntPtr intptr_0);

		// Token: 0x06002303 RID: 8963
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr intptr_0, GStruct78 gstruct78_0, GEnum53 genum53_0);

		// Token: 0x06002304 RID: 8964
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_CloseClanChatWindowInSteam(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002305 RID: 8965
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_LeaveLobby(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002306 RID: 8966
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamNetworking_CreateListenSocket(IntPtr intptr_0, int int_0, uint uint_0, ushort ushort_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002307 RID: 8967
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_TransferItemQuantity(IntPtr intptr_0, out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0, GStruct7 gstruct7_1);

		// Token: 0x06002308 RID: 8968
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetMediumFriendAvatar(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002309 RID: 8969
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileDelete(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600230A RID: 8970
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetGameData(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600230B RID: 8971
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetClanOwner(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600230C RID: 8972
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamGameServer(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600230D RID: 8973
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddRequiredTag(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600230E RID: 8974
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamScreenshots_HookScreenshots(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600230F RID: 8975
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamUtils_GetIPCountry(IntPtr intptr_0);

		// Token: 0x06002310 RID: 8976
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_IsOverlayEnabled(IntPtr intptr_0);

		// Token: 0x06002311 RID: 8977
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsDlcInstalled(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002312 RID: 8978
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_SetUserItemVote(IntPtr intptr_0, GStruct78 gstruct78_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002313 RID: 8979
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_JoinClanChatRoom(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002314 RID: 8980
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUtils_StartVRDashboard(IntPtr intptr_0);

		// Token: 0x06002315 RID: 8981
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetCloudFileNameFilter(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002316 RID: 8982
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetGlobalStat0(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out double double_0);

		// Token: 0x06002317 RID: 8983
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_GetUserStat0(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out float float_0);

		// Token: 0x06002318 RID: 8984
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamUser();

		// Token: 0x06002319 RID: 8985
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData(byte[] byte_0, uint uint_0, out uint uint_1);

		// Token: 0x0600231A RID: 8986
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr intptr_0, int int_0);

		// Token: 0x0600231B RID: 8987
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_GetClanActivityCounts(IntPtr intptr_0, GStruct22 gstruct22_0, out int int_0, out int int_1, out int int_2);

		// Token: 0x0600231C RID: 8988
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_RequestLobbyList(IntPtr intptr_0);

		// Token: 0x0600231D RID: 8989
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUGC_GetSubscribedItems(IntPtr intptr_0, [In] [Out] GStruct78[] gstruct78_0, uint uint_0);

		// Token: 0x0600231E RID: 8990
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestInternetServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x0600231F RID: 8991
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamInventory(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002320 RID: 8992
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_WriteMiniDump(uint uint_0, IntPtr intptr_0, uint uint_1);

		// Token: 0x06002321 RID: 8993
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0);

		// Token: 0x06002322 RID: 8994
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RunCallbacks();

		// Token: 0x06002323 RID: 8995
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetUserStat(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out int int_0);

		// Token: 0x06002324 RID: 8996
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetStat(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out int int_0);

		// Token: 0x06002325 RID: 8997
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamMatchmaking(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002326 RID: 8998
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr intptr_0, byte[] byte_0, uint uint_0);

		// Token: 0x06002327 RID: 8999
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002328 RID: 9000
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x06002329 RID: 9001
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600232A RID: 9002
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_ActivateActionSetLayer(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct290 gstruct290_0);

		// Token: 0x0600232B RID: 9003
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_MouseWheel(IntPtr intptr_0, GStruct43 gstruct43_0, int int_0);

		// Token: 0x0600232C RID: 9004
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_EnableHeartbeats(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600232D RID: 9005
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamController_ShowAnalogActionOrigins(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct189 gstruct189_0, float float_0, float float_1, float float_2);

		// Token: 0x0600232E RID: 9006
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_RemoveDependency(IntPtr intptr_0, GStruct78 gstruct78_0, GStruct78 gstruct78_1);

		// Token: 0x0600232F RID: 9007
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002330 RID: 9008
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BIsPhoneRequiringVerification(IntPtr intptr_0);

		// Token: 0x06002331 RID: 9009
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_KeyChar(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0);

		// Token: 0x06002332 RID: 9010
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetAchievement(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out bool bool_0);

		// Token: 0x06002333 RID: 9011
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GEnum55 genum55_0);

		// Token: 0x06002334 RID: 9012
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetResultItems(IntPtr intptr_0, GStruct31 gstruct31_0, [In] [Out] GStruct226[] gstruct226_0, ref uint uint_0);

		// Token: 0x06002335 RID: 9013
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetBreakpadAppID(uint uint_0);

		// Token: 0x06002336 RID: 9014
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_TriggerHapticPulse(IntPtr intptr_0, GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0);

		// Token: 0x06002337 RID: 9015
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned(byte[] byte_0, uint uint_0);

		// Token: 0x06002338 RID: 9016
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_GetFavoriteGame(IntPtr intptr_0, int int_0, out GStruct66 gstruct66_0, out uint uint_0, out ushort ushort_0, out ushort ushort_1, out uint uint_1, out uint uint_2);

		// Token: 0x06002339 RID: 9017
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr intptr_0, GStruct22 gstruct22_0, [In] [Out] GStruct36[] gstruct36_0, ref uint uint_0);

		// Token: 0x0600233A RID: 9018
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_PlaylistWillChange(IntPtr intptr_0);

		// Token: 0x0600233B RID: 9019
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GenerateItems(IntPtr intptr_0, out GStruct31 gstruct31_0, [In] [Out] GStruct36[] gstruct36_0, [In] [Out] uint[] uint_0, uint uint_1);

		// Token: 0x0600233C RID: 9020
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_UpdateItemPreviewFile(IntPtr intptr_0, GStruct16 gstruct16_0, uint uint_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600233D RID: 9021
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr intptr_0, GStruct215 gstruct215_0, GEnum86 genum86_0);

		// Token: 0x0600233E RID: 9022
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern short SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex(IntPtr intptr_0, int int_0);

		// Token: 0x0600233F RID: 9023
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetUserAchievement(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, out bool bool_0);

		// Token: 0x06002340 RID: 9024
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr intptr_0, int int_0);

		// Token: 0x06002341 RID: 9025
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_SendDataOnSocket(IntPtr intptr_0, GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002342 RID: 9026
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamUserStats_GetLeaderboardName(IntPtr intptr_0, GStruct305 gstruct305_0);

		// Token: 0x06002343 RID: 9027
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr intptr_0);

		// Token: 0x06002344 RID: 9028
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMusic_PlayPrevious(IntPtr intptr_0);

		// Token: 0x06002345 RID: 9029
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetClanTag(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002346 RID: 9030
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_TrackAppUsageEvent(IntPtr intptr_0, GStruct217 gstruct217_0, int int_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002347 RID: 9031
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr intptr_0);

		// Token: 0x06002348 RID: 9032
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_RequestGlobalStats(IntPtr intptr_0, int int_0);

		// Token: 0x06002349 RID: 9033
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_DeactivateAllActionSetLayers(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x0600234A RID: 9034
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr intptr_0, GStruct305 gstruct305_0, [In] [Out] GStruct22[] gstruct22_0, int int_0);

		// Token: 0x0600234B RID: 9035
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_AddHeader(IntPtr intptr_0, GStruct43 gstruct43_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600234C RID: 9036
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetClanChatMessage(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0, IntPtr intptr_1, int int_1, out GEnum30 genum30_0, out GStruct22 gstruct22_1);

		// Token: 0x0600234D RID: 9037
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_EndAuthSession(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600234E RID: 9038
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600234F RID: 9039
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamClient_SetLocalIPBinding(IntPtr intptr_0, uint uint_0, ushort ushort_0);

		// Token: 0x06002350 RID: 9040
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0, out uint uint_0);

		// Token: 0x06002351 RID: 9041
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamMusic(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002352 RID: 9042
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_StartPlaytimeTracking(IntPtr intptr_0, [In] [Out] GStruct78[] gstruct78_0, uint uint_0);

		// Token: 0x06002353 RID: 9043
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetLeaderboardEntryCount(IntPtr intptr_0, GStruct305 gstruct305_0);

		// Token: 0x06002354 RID: 9044
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails(IntPtr intptr_0, GStruct78 gstruct78_0, uint uint_0);

		// Token: 0x06002355 RID: 9045
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_CloseP2PChannelWithUser(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002356 RID: 9046
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SendHTTPRequest(IntPtr intptr_0, GStruct188 gstruct188_0, out GStruct241 gstruct241_0);

		// Token: 0x06002357 RID: 9047
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusic_BIsPlaying(IntPtr intptr_0);

		// Token: 0x06002358 RID: 9048
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetCookie(IntPtr intptr_0, GStruct207 gstruct207_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GClass78.GClass79 gclass79_2);

		// Token: 0x06002359 RID: 9049
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_GetCurrentBetaName(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		// Token: 0x0600235A RID: 9050
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmakingServers_CancelQuery(IntPtr intptr_0, GStruct240 gstruct240_0);

		// Token: 0x0600235B RID: 9051
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr intptr_0, GStruct188 gstruct188_0, GStruct207 gstruct207_0);

		// Token: 0x0600235C RID: 9052
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_Reload(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x0600235D RID: 9053
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetFriendFromSourceByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x0600235E RID: 9054
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BIsBehindNAT(IntPtr intptr_0);

		// Token: 0x0600235F RID: 9055
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_CreateLobby(IntPtr intptr_0, GEnum91 genum91_0, int int_0);

		// Token: 0x06002360 RID: 9056
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamUser();

		// Token: 0x06002361 RID: 9057
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsFeatureBlocked(IntPtr intptr_0, GEnum3 genum3_0);

		// Token: 0x06002362 RID: 9058
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamNetworking(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002363 RID: 9059
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_AdvertiseGame(IntPtr intptr_0, GStruct22 gstruct22_0, uint uint_0, ushort ushort_0);

		// Token: 0x06002364 RID: 9060
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_TriggerRepeatedHapticPulse(IntPtr intptr_0, GStruct83 gstruct83_0, GEnum22 genum22_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, uint uint_0);

		// Token: 0x06002365 RID: 9061
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002366 RID: 9062
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_GetListenSocketInfo(IntPtr intptr_0, GStruct229 gstruct229_0, out uint uint_0, out ushort ushort_0);

		// Token: 0x06002367 RID: 9063
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamApps_InstallDLC(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002368 RID: 9064
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum68 SteamAPI_ISteamMusic_GetPlaybackStatus(IntPtr intptr_0);

		// Token: 0x06002369 RID: 9065
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCStatistic(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, GEnum50 genum50_0, out ulong ulong_0);

		// Token: 0x0600236A RID: 9066
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600236B RID: 9067
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnablePlaylists(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600236C RID: 9068
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamInventory_DestroyResult(IntPtr intptr_0, GStruct31 gstruct31_0);

		// Token: 0x0600236D RID: 9069
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_OpenClanChatWindowInSteam(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600236E RID: 9070
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0, byte[] byte_0, uint uint_0);

		// Token: 0x0600236F RID: 9071
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GStruct202 SteamAPI_ISteamController_GetMotionData(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x06002370 RID: 9072
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_GetQuota(IntPtr intptr_0, out ulong ulong_0, out ulong ulong_1);

		// Token: 0x06002371 RID: 9073
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_ReleaseHTTPRequest(IntPtr intptr_0, GStruct188 gstruct188_0);

		// Token: 0x06002372 RID: 9074
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetItemsByID(IntPtr intptr_0, out GStruct31 gstruct31_0, [In] [Out] GStruct7[] gstruct7_0, uint uint_0);

		// Token: 0x06002373 RID: 9075
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_SetLEDColor(IntPtr intptr_0, GStruct83 gstruct83_0, byte byte_0, byte byte_1, byte byte_2, uint uint_0);

		// Token: 0x06002374 RID: 9076
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr intptr_0, GEnum53 genum53_0, uint uint_0);

		// Token: 0x06002375 RID: 9077
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002376 RID: 9078
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr intptr_0, GStruct215 gstruct215_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002377 RID: 9079
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamController_GetDigitalActionHandle(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002378 RID: 9080
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetAppID(IntPtr intptr_0);

		// Token: 0x06002379 RID: 9081
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetItemsWithPrices(IntPtr intptr_0, [In] [Out] GStruct36[] gstruct36_0, [In] [Out] ulong[] ulong_0, uint uint_0);

		// Token: 0x0600237A RID: 9082
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetQueueEntry(IntPtr intptr_0, int int_0, int int_1, GClass78.GClass79 gclass79_0);

		// Token: 0x0600237B RID: 9083
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamParentalSettings(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600237C RID: 9084
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_UnsubscribeItem(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600237D RID: 9085
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLobbyJoinable(IntPtr intptr_0, GStruct22 gstruct22_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600237E RID: 9086
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SendUserDisconnect(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600237F RID: 9087
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_AddPromoItems(IntPtr intptr_0, out GStruct31 gstruct31_0, [In] [Out] GStruct36[] gstruct36_0, uint uint_0);

		// Token: 0x06002380 RID: 9088
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr intptr_0, int int_0);

		// Token: 0x06002381 RID: 9089
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle(IntPtr intptr_0, int int_0);

		// Token: 0x06002382 RID: 9090
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_RemoveAppDependency(IntPtr intptr_0, GStruct78 gstruct78_0, GStruct66 gstruct66_0);

		// Token: 0x06002383 RID: 9091
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamUtils(IntPtr intptr_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002384 RID: 9092
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_ClearAchievement(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002385 RID: 9093
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsAppInstalled(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002386 RID: 9094
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendsGroupMembersCount(IntPtr intptr_0, GStruct235 gstruct235_0);

		// Token: 0x06002387 RID: 9095
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddItemPreviewFile(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0, GEnum59 genum59_0);

		// Token: 0x06002388 RID: 9096
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnChildren(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002389 RID: 9097
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_ReadP2PPacket(IntPtr intptr_0, byte[] byte_0, uint uint_0, out uint uint_1, out GStruct22 gstruct22_0, int int_0);

		// Token: 0x0600238A RID: 9098
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUserStats_GetNumAchievements(IntPtr intptr_0);

		// Token: 0x0600238B RID: 9099
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUGC_GetItemState(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600238C RID: 9100
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_SendP2PPacket(IntPtr intptr_0, GStruct22 gstruct22_0, byte[] byte_0, uint uint_0, GEnum26 genum26_0, int int_0);

		// Token: 0x0600238D RID: 9101
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr intptr_0);

		// Token: 0x0600238E RID: 9102
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileExists(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600238F RID: 9103
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_BSecure();

		// Token: 0x06002390 RID: 9104
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry(IntPtr intptr_0, int int_0);

		// Token: 0x06002391 RID: 9105
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetBackgroundMode(IntPtr intptr_0, GStruct43 gstruct43_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002392 RID: 9106
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_GetAppDependencies(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x06002393 RID: 9107
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetMatchAnyTag(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002394 RID: 9108
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUser_GetSteamID(IntPtr intptr_0);

		// Token: 0x06002395 RID: 9109
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum71 SteamAPI_ISteamFriends_GetFriendRelationship(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002396 RID: 9110
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x06002397 RID: 9111
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum77 SteamAPI_ISteamUtils_GetConnectedUniverse(IntPtr intptr_0);

		// Token: 0x06002398 RID: 9112
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr intptr_0, GStruct215 gstruct215_0);

		// Token: 0x06002399 RID: 9113
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_GetAPICallResult(IntPtr intptr_0, GStruct241 gstruct241_0, IntPtr intptr_1, int int_0, int int_1, out bool bool_0);

		// Token: 0x0600239A RID: 9114
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamMatchmakingServers(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600239B RID: 9115
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamController_GetCurrentActionSet(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x0600239C RID: 9116
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddItemPreviewVideo(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600239D RID: 9117
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_MouseUp(IntPtr intptr_0, GStruct43 gstruct43_0, GEnum94 genum94_0);

		// Token: 0x0600239E RID: 9118
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_GetEncryptedAppTicket(IntPtr intptr_0, byte[] byte_0, int int_0, out uint uint_0);

		// Token: 0x0600239F RID: 9119
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamClient_BReleaseSteamPipe(IntPtr intptr_0, GStruct128 gstruct128_0);

		// Token: 0x060023A0 RID: 9120
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum70 SteamAPI_ISteamGameServer_BeginAuthSession(IntPtr intptr_0, byte[] byte_0, int int_0, GStruct22 gstruct22_0);

		// Token: 0x060023A1 RID: 9121
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_FindOrCreateLeaderboard(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GEnum61 genum61_0, GEnum49 genum49_0);

		// Token: 0x060023A2 RID: 9122
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetHSteamPipe();

		// Token: 0x060023A3 RID: 9123
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_RetrieveDataFromSocket(IntPtr intptr_0, GStruct208 gstruct208_0, byte[] byte_0, uint uint_0, out uint uint_1);

		// Token: 0x060023A4 RID: 9124
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_JoinLobby(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060023A5 RID: 9125
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_GoForward(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x060023A6 RID: 9126
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddItemKeyValueTag(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x060023A7 RID: 9127
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SetProperty2(IntPtr intptr_0, GStruct24 gstruct24_0, GStruct7 gstruct7_0, GClass78.GClass79 gclass79_0, float float_0);

		// Token: 0x060023A8 RID: 9128
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamUser(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023A9 RID: 9129
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmakingServers_PlayerDetails(IntPtr intptr_0, uint uint_0, ushort ushort_0, IntPtr intptr_1);

		// Token: 0x060023AA RID: 9130
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetAllowCachedResponse(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0);

		// Token: 0x060023AB RID: 9131
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamAppList(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023AC RID: 9132
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_RequestUserInformation(IntPtr intptr_0, GStruct22 gstruct22_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060023AD RID: 9133
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_RetrieveData(IntPtr intptr_0, GStruct229 gstruct229_0, byte[] byte_0, uint uint_0, out uint uint_1, out GStruct208 gstruct208_0);

		// Token: 0x060023AE RID: 9134
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLobbyOwner(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x060023AF RID: 9135
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_HasFriend(IntPtr intptr_0, GStruct22 gstruct22_0, GEnum28 genum28_0);

		// Token: 0x060023B0 RID: 9136
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_ExchangeItems(IntPtr intptr_0, out GStruct31 gstruct31_0, [In] [Out] GStruct36[] gstruct36_0, [In] [Out] uint[] uint_0, uint uint_1, [In] [Out] GStruct7[] gstruct7_0, [In] [Out] uint[] uint_2, uint uint_3);

		// Token: 0x060023B1 RID: 9137
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SendLobbyChatMsg(IntPtr intptr_0, GStruct22 gstruct22_0, byte[] byte_0, int int_0);

		// Token: 0x060023B2 RID: 9138
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestContextValue(IntPtr intptr_0, GStruct188 gstruct188_0, ulong ulong_0);

		// Token: 0x060023B3 RID: 9139
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr intptr_0, GStruct188 gstruct188_0, uint uint_0);

		// Token: 0x060023B4 RID: 9140
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemContent(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023B5 RID: 9141
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_GetServerDetails(IntPtr intptr_0, GStruct240 gstruct240_0, int int_0);

		// Token: 0x060023B6 RID: 9142
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamClient_SetWarningMessageHook(IntPtr intptr_0, GDelegate17 gdelegate17_0);

		// Token: 0x060023B7 RID: 9143
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamApps_UninstallDLC(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060023B8 RID: 9144
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_SetSyncPlatforms(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GEnum2 genum2_0);

		// Token: 0x060023B9 RID: 9145
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_RemoveFavoriteGame(IntPtr intptr_0, GStruct66 gstruct66_0, uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1);

		// Token: 0x060023BA RID: 9146
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr intptr_0, GStruct188 gstruct188_0, out float float_0);

		// Token: 0x060023BB RID: 9147
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_FindLeaderboard(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023BC RID: 9148
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamUserStats(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023BD RID: 9149
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamScreenshots_TagPublishedFile(IntPtr intptr_0, GStruct277 gstruct277_0, GStruct78 gstruct78_0);

		// Token: 0x060023BE RID: 9150
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_CopyToClipboard(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x060023BF RID: 9151
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetMiniDumpComment(GClass78.GClass79 gclass79_0);

		// Token: 0x060023C0 RID: 9152
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetPersonaName(IntPtr intptr_0);

		// Token: 0x060023C1 RID: 9153
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_LeaveClanChatRoom(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060023C2 RID: 9154
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetItemDownloadInfo(IntPtr intptr_0, GStruct78 gstruct78_0, out ulong ulong_0, out ulong ulong_1);

		// Token: 0x060023C3 RID: 9155
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_IsP2PPacketAvailable(IntPtr intptr_0, out uint uint_0, int int_0);

		// Token: 0x060023C4 RID: 9156
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_RunFrame(IntPtr intptr_0);

		// Token: 0x060023C5 RID: 9157
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamController_GetActiveActionSetLayers(IntPtr intptr_0, GStruct83 gstruct83_0, out GStruct290 gstruct290_0);

		// Token: 0x060023C6 RID: 9158
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_UGCDownload(IntPtr intptr_0, GStruct96 gstruct96_0, uint uint_0);

		// Token: 0x060023C7 RID: 9159
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ActivateGameOverlay(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023C8 RID: 9160
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern float SteamAPI_ISteamMusic_GetVolume(IntPtr intptr_0);

		// Token: 0x060023C9 RID: 9161
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamController_GetGlyphForActionOrigin(IntPtr intptr_0, GEnum33 genum33_0);

		// Token: 0x060023CA RID: 9162
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsAppBlocked(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060023CB RID: 9163
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_ViewSource(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x060023CC RID: 9164
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetCookie(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GClass78.GClass79 gclass79_2, GClass78.GClass79 gclass79_3, uint uint_0, [MarshalAs(UnmanagedType.I1)] bool bool_0, [MarshalAs(UnmanagedType.I1)] bool bool_1);

		// Token: 0x060023CD RID: 9165
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPResponseBodyData(IntPtr intptr_0, GStruct188 gstruct188_0, byte[] byte_0, uint uint_0);

		// Token: 0x060023CE RID: 9166
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemTitle(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023CF RID: 9167
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmakingServers_RefreshServer(IntPtr intptr_0, GStruct240 gstruct240_0, int int_0);

		// Token: 0x060023D0 RID: 9168
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamHTMLSurface_CreateBrowser(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x060023D1 RID: 9169
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum56 SteamAPI_ISteamFriends_GetPersonaState(IntPtr intptr_0);

		// Token: 0x060023D2 RID: 9170
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_FileShare(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023D3 RID: 9171
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUGC_GetNumSubscribedItems(IntPtr intptr_0);

		// Token: 0x060023D4 RID: 9172
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileWriteStreamClose(IntPtr intptr_0, GStruct227 gstruct227_0);

		// Token: 0x060023D5 RID: 9173
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_DeleteItem(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x060023D6 RID: 9174
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamAppList_GetNumInstalledApps(IntPtr intptr_0);

		// Token: 0x060023D7 RID: 9175
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_PublishWorkshopFile(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GStruct66 gstruct66_0, GClass78.GClass79 gclass79_2, GClass78.GClass79 gclass79_3, GEnum86 genum86_0, IntPtr intptr_1, GEnum66 genum66_0);

		// Token: 0x060023D8 RID: 9176
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023D9 RID: 9177
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_CancelAuthTicket(IntPtr intptr_0, GStruct176 gstruct176_0);

		// Token: 0x060023DA RID: 9178
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_StopLoad(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x060023DB RID: 9179
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr intptr_0, int int_0);

		// Token: 0x060023DC RID: 9180
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SetProperty1(IntPtr intptr_0, GStruct24 gstruct24_0, GStruct7 gstruct7_0, GClass78.GClass79 gclass79_0, long long_0);

		// Token: 0x060023DD RID: 9181
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayToStore(IntPtr intptr_0, GStruct66 gstruct66_0, GEnum11 genum11_0);

		// Token: 0x060023DE RID: 9182
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsSubscribedApp(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x060023DF RID: 9183
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUser_RequestStoreAuthURL(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023E0 RID: 9184
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BIsTwoFactorEnabled(IntPtr intptr_0);

		// Token: 0x060023E1 RID: 9185
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamInventory_RequestPrices(IntPtr intptr_0);

		// Token: 0x060023E2 RID: 9186
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamRemoteStorage_GetFileCount(IntPtr intptr_0);

		// Token: 0x060023E3 RID: 9187
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamController_GetActionSetHandle(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023E4 RID: 9188
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmaking_GetLobbyMemberData(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1, GClass78.GClass79 gclass79_0);

		// Token: 0x060023E5 RID: 9189
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamRemoteStorage_GetFileSize(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023E6 RID: 9190
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetPlayerNickname(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060023E7 RID: 9191
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamRemoteStorage(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023E8 RID: 9192
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmakingServers_ReleaseRequest(IntPtr intptr_0, GStruct240 gstruct240_0);

		// Token: 0x060023E9 RID: 9193
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket(byte[] byte_0, uint uint_0, byte[] byte_1, ref uint uint_1, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] byte_2, int int_0);

		// Token: 0x060023EA RID: 9194
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamApps_GetLaunchQueryParam(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023EB RID: 9195
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64(IntPtr intptr_0, byte[] byte_0, uint uint_0);

		// Token: 0x060023EC RID: 9196
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetClanCount(IntPtr intptr_0);

		// Token: 0x060023ED RID: 9197
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0);

		// Token: 0x060023EE RID: 9198
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete(IntPtr intptr_0, GStruct241 gstruct241_0, byte[] byte_0, uint uint_0);

		// Token: 0x060023EF RID: 9199
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamController_GetStringForActionOrigin(IntPtr intptr_0, GEnum33 genum33_0);

		// Token: 0x060023F0 RID: 9200
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamGameServer_GetHSteamPipe();

		// Token: 0x060023F1 RID: 9201
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum81 SteamAPI_ISteamUtils_GetAPICallFailureReason(IntPtr intptr_0, GStruct241 gstruct241_0);

		// Token: 0x060023F2 RID: 9202
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr intptr_0);

		// Token: 0x060023F3 RID: 9203
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmakingServers_PingServer(IntPtr intptr_0, uint uint_0, ushort ushort_0, IntPtr intptr_1);

		// Token: 0x060023F4 RID: 9204
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetServerName(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060023F5 RID: 9205
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUser_InitiateGameConnection(IntPtr intptr_0, byte[] byte_0, int int_0, GStruct22 gstruct22_0, uint uint_0, ushort ushort_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060023F6 RID: 9206
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum67 SteamAPI_ISteamUser_DecompressVoice(IntPtr intptr_0, byte[] byte_0, uint uint_0, byte[] byte_1, uint uint_1, out uint uint_2, uint uint_3);

		// Token: 0x060023F7 RID: 9207
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_Find(IntPtr intptr_0, GStruct43 gstruct43_0, GClass78.GClass79 gclass79_0, [MarshalAs(UnmanagedType.I1)] bool bool_0, [MarshalAs(UnmanagedType.I1)] bool bool_1);

		// Token: 0x060023F8 RID: 9208
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime(byte[] byte_0, uint uint_0);

		// Token: 0x060023F9 RID: 9209
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendCoplayTime(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060023FA RID: 9210
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamApps_GetAvailableGameLanguages(IntPtr intptr_0);

		// Token: 0x060023FB RID: 9211
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetIPCCallCount(IntPtr intptr_0);

		// Token: 0x060023FC RID: 9212
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_MouseDown(IntPtr intptr_0, GStruct43 gstruct43_0, GEnum94 genum94_0);

		// Token: 0x060023FD RID: 9213
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetPageScaleFactor(IntPtr intptr_0, GStruct43 gstruct43_0, float float_0, int int_0, int int_1);

		// Token: 0x060023FE RID: 9214
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BGetDLCDataByIndex(IntPtr intptr_0, int int_0, out GStruct66 gstruct66_0, out bool bool_0, IntPtr intptr_1, int int_1);

		// Token: 0x060023FF RID: 9215
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002400 RID: 9216
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_MouseDoubleClick(IntPtr intptr_0, GStruct43 gstruct43_0, GEnum94 genum94_0);

		// Token: 0x06002401 RID: 9217
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr intptr_0, GStruct215 gstruct215_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002402 RID: 9218
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr intptr_0, ulong ulong_0);

		// Token: 0x06002403 RID: 9219
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0, byte[] byte_0, uint uint_0);

		// Token: 0x06002404 RID: 9220
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamApps_GetAppInstallDir(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0);

		// Token: 0x06002405 RID: 9221
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnOnlyIDs(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002406 RID: 9222
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr intptr_0, GStruct96 gstruct96_0, out int int_0, out int int_1);

		// Token: 0x06002407 RID: 9223
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnTotalOnly(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002408 RID: 9224
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetItemMetadata(IntPtr intptr_0, GStruct16 gstruct16_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002409 RID: 9225
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600240A RID: 9226
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsVACBanned(IntPtr intptr_0);

		// Token: 0x0600240B RID: 9227
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerClient();

		// Token: 0x0600240C RID: 9228
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_GetUGCDetails(IntPtr intptr_0, GStruct96 gstruct96_0, out GStruct66 gstruct66_0, out IntPtr intptr_1, out int int_0, out GStruct22 gstruct22_0);

		// Token: 0x0600240D RID: 9229
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr intptr_0, GStruct215 gstruct215_0, IntPtr intptr_1);

		// Token: 0x0600240E RID: 9230
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_InviteUserToGame(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600240F RID: 9231
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamParentalSettings_BIsAppInBlockList(IntPtr intptr_0, GStruct66 gstruct66_0);

		// Token: 0x06002410 RID: 9232
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamController_GetDigitalActionOrigins(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct290 gstruct290_0, GStruct20 gstruct20_0, [In] [Out] GEnum33[] genum33_0);

		// Token: 0x06002411 RID: 9233
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamGameServer_RunCallbacks();

		// Token: 0x06002412 RID: 9234
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr intptr_0, GStruct215 gstruct215_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002413 RID: 9235
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_AddRequiredKeyValueTag(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x06002414 RID: 9236
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnMetadata(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002415 RID: 9237
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_IsSteamRunningInVR(IntPtr intptr_0);

		// Token: 0x06002416 RID: 9238
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamClient_CreateLocalUser(IntPtr intptr_0, out GStruct128 gstruct128_0, GEnum65 genum65_0);

		// Token: 0x06002417 RID: 9239
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetFriendPersonaName(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002418 RID: 9240
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_LogOff(IntPtr intptr_0);

		// Token: 0x06002419 RID: 9241
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamInventory_SendItemDropHeartbeat(IntPtr intptr_0);

		// Token: 0x0600241A RID: 9242
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr intptr_0, GEnum37 genum37_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x0600241B RID: 9243
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_AddDependency(IntPtr intptr_0, GStruct78 gstruct78_0, GStruct78 gstruct78_1);

		// Token: 0x0600241C RID: 9244
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetGlobalStatHistory0(IntPtr intptr_0, GClass78.GClass79 gclass79_0, [In] [Out] double[] double_0, uint uint_0);

		// Token: 0x0600241D RID: 9245
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		// Token: 0x0600241E RID: 9246
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_UseBreakpadCrashHandler(GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1, GClass78.GClass79 gclass79_2, [MarshalAs(UnmanagedType.I1)] bool bool_0, IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x0600241F RID: 9247
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_RequestUserGroupStatus(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x06002420 RID: 9248
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum2 SteamAPI_ISteamRemoteStorage_GetSyncPlatforms(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002421 RID: 9249
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetModDir(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002422 RID: 9250
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_StartVoiceRecording(IntPtr intptr_0);

		// Token: 0x06002423 RID: 9251
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Steam_GetHSteamUserCurrent();

		// Token: 0x06002424 RID: 9252
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_SetTryCatchCallbacks([MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002425 RID: 9253
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnableShuffled(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002426 RID: 9254
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_RemoveProperty(IntPtr intptr_0, GStruct24 gstruct24_0, GStruct7 gstruct7_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002427 RID: 9255
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GStruct304 SteamAPI_ISteamController_GetDigitalActionData(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct20 gstruct20_0);

		// Token: 0x06002428 RID: 9256
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUtils_SetWarningMessageHook(IntPtr intptr_0, GDelegate17 gdelegate17_0);

		// Token: 0x06002429 RID: 9257
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_DeletePublishedFile(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600242A RID: 9258
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_IsFollowing(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600242B RID: 9259
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamAppList_GetAppInstallDir(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, int int_0);

		// Token: 0x0600242C RID: 9260
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_AllowStartRequest(IntPtr intptr_0, GStruct43 gstruct43_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600242D RID: 9261
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_ConsumeItem(IntPtr intptr_0, out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0);

		// Token: 0x0600242E RID: 9262
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamController_GetAnalogActionHandle(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600242F RID: 9263
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCResult(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, out GStruct303 gstruct303_0);

		// Token: 0x06002430 RID: 9264
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr intptr_0, uint uint_0);

		// Token: 0x06002431 RID: 9265
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_StartItemUpdate(IntPtr intptr_0, GStruct66 gstruct66_0, GStruct78 gstruct78_0);

		// Token: 0x06002432 RID: 9266
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamNetworking_CreateConnectionSocket(IntPtr intptr_0, uint uint_0, ushort ushort_0, int int_0);

		// Token: 0x06002433 RID: 9267
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetStat0(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out float float_0);

		// Token: 0x06002434 RID: 9268
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_AddPromoItem(IntPtr intptr_0, out GStruct31 gstruct31_0, GStruct36 gstruct36_0);

		// Token: 0x06002435 RID: 9269
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, uint uint_1, IntPtr intptr_1, uint uint_2, IntPtr intptr_2, uint uint_3, out GEnum59 genum59_0);

		// Token: 0x06002436 RID: 9270
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_SetStat(IntPtr intptr_0, GClass78.GClass79 gclass79_0, int int_0);

		// Token: 0x06002437 RID: 9271
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_GetEnteredGamepadTextInput(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

		// Token: 0x06002438 RID: 9272
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr intptr_0, GStruct188 gstruct188_0, out bool bool_0);

		// Token: 0x06002439 RID: 9273
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation(IntPtr intptr_0, GStruct96 gstruct96_0, GClass78.GClass79 gclass79_0, uint uint_0);

		// Token: 0x0600243A RID: 9274
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetFriendRichPresence(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600243B RID: 9275
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUtils_SetOverlayNotificationInset(IntPtr intptr_0, int int_0, int int_1);

		// Token: 0x0600243C RID: 9276
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_UploadLeaderboardScore(IntPtr intptr_0, GStruct305 gstruct305_0, GEnum83 genum83_0, int int_0, [In] [Out] int[] int_1, int int_2);

		// Token: 0x0600243D RID: 9277
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_SubscribeItem(IntPtr intptr_0, GStruct78 gstruct78_0);

		// Token: 0x0600243E RID: 9278
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_RemoveItemFromFavorites(IntPtr intptr_0, GStruct66 gstruct66_0, GStruct78 gstruct78_0);

		// Token: 0x0600243F RID: 9279
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_IsUserInSource(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x06002440 RID: 9280
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_SetUserAchievement(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002441 RID: 9281
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_GetFollowerCount(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002442 RID: 9282
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_CreateQueryUserUGCRequest(IntPtr intptr_0, GStruct216 gstruct216_0, GEnum62 genum62_0, GEnum7 genum7_0, GEnum31 genum31_0, GStruct66 gstruct66_0, GStruct66 gstruct66_1, uint uint_0);

		// Token: 0x06002443 RID: 9283
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamController_GetGamepadIndexForController(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x06002444 RID: 9284
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_GetCSERIPPort(IntPtr intptr_0, out uint uint_0, out ushort ushort_0);

		// Token: 0x06002445 RID: 9285
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

		// Token: 0x06002446 RID: 9286
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_DeleteLobbyData(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002447 RID: 9287
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_SubmitUpdateProperties(IntPtr intptr_0, GStruct24 gstruct24_0, out GStruct31 gstruct31_0);

		// Token: 0x06002448 RID: 9288
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_AttachLeaderboardUGC(IntPtr intptr_0, GStruct305 gstruct305_0, GStruct96 gstruct96_0);

		// Token: 0x06002449 RID: 9289
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_IsClanChatAdmin(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x0600244A RID: 9290
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetPlaylistEntry(IntPtr intptr_0, int int_0, int int_1, GClass78.GClass79 gclass79_0);

		// Token: 0x0600244B RID: 9291
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamApps_GetAppOwner(IntPtr intptr_0);

		// Token: 0x0600244C RID: 9292
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamClient_GetIPCCallCount(IntPtr intptr_0);

		// Token: 0x0600244D RID: 9293
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_FileReadAsync(IntPtr intptr_0, GClass78.GClass79 gclass79_0, uint uint_0, uint uint_1);

		// Token: 0x0600244E RID: 9294
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor(IntPtr intptr_0, GStruct43 gstruct43_0, float float_0);

		// Token: 0x0600244F RID: 9295
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002450 RID: 9296
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmakingServers_GetServerCount(IntPtr intptr_0, GStruct240 gstruct240_0);

		// Token: 0x06002451 RID: 9297
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamClient_ReleaseUser(IntPtr intptr_0, GStruct128 gstruct128_0, GStruct58 gstruct58_0);

		// Token: 0x06002452 RID: 9298
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_ForceHeartbeat(IntPtr intptr_0);

		// Token: 0x06002453 RID: 9299
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamGameServer_GetPublicIP(IntPtr intptr_0);

		// Token: 0x06002454 RID: 9300
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr intptr_0);

		// Token: 0x06002455 RID: 9301
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamNetworking_CreateP2PConnectionSocket(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0, int int_1, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002456 RID: 9302
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_InviteUserToLobby(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x06002457 RID: 9303
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamController_GetControllerForGamepadIndex(IntPtr intptr_0, int int_0);

		// Token: 0x06002458 RID: 9304
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_IsDataAvailable(IntPtr intptr_0, GStruct229 gstruct229_0, out uint uint_0, out GStruct208 gstruct208_0);

		// Token: 0x06002459 RID: 9305
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamScreenshots_TriggerScreenshot(IntPtr intptr_0);

		// Token: 0x0600245A RID: 9306
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_DownloadItem(IntPtr intptr_0, GStruct78 gstruct78_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x0600245B RID: 9307
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr intptr_0, GStruct22 gstruct22_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x0600245C RID: 9308
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GetResultItemProperty(IntPtr intptr_0, GStruct31 gstruct31_0, uint uint_0, GClass78.GClass79 gclass79_0, IntPtr intptr_1, ref uint uint_1);

		// Token: 0x0600245D RID: 9309
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_FilePersisted(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600245E RID: 9310
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BIsPhoneVerified(IntPtr intptr_0);

		// Token: 0x0600245F RID: 9311
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr intptr_0);

		// Token: 0x06002460 RID: 9312
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamGameServer_GetNextOutgoingPacket(IntPtr intptr_0, byte[] byte_0, int int_0, out uint uint_0, out ushort ushort_0);

		// Token: 0x06002461 RID: 9313
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamApps_GetInstalledDepots(IntPtr intptr_0, GStruct66 gstruct66_0, [In] [Out] GStruct108[] gstruct108_0, uint uint_0);

		// Token: 0x06002462 RID: 9314
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServerStats_StoreUserStats(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002463 RID: 9315
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamHTTP_CreateCookieContainer(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002464 RID: 9316
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamGameServerStats(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002465 RID: 9317
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamController_ShowBindingPanel(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x06002466 RID: 9318
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(byte[] byte_0, uint uint_0, GStruct66 gstruct66_0);

		// Token: 0x06002467 RID: 9319
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_RequestUserStats(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002468 RID: 9320
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_SetRichPresence(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x06002469 RID: 9321
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_GetUserDataFolder(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		// Token: 0x0600246A RID: 9322
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_GetImageRGBA(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1);

		// Token: 0x0600246B RID: 9323
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_TerminateGameConnection(IntPtr intptr_0, uint uint_0, ushort ushort_0);

		// Token: 0x0600246C RID: 9324
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_SetPlayedWith(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600246D RID: 9325
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamNetworking_GetMaxPacketSize(IntPtr intptr_0, GStruct208 gstruct208_0);

		// Token: 0x0600246E RID: 9326
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamInventory_GetNumItemsWithPrices(IntPtr intptr_0);

		// Token: 0x0600246F RID: 9327
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetSearchText(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002470 RID: 9328
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetGameDescription(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002471 RID: 9329
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_BInitWorkshopForGameServer(IntPtr intptr_0, GStruct108 gstruct108_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002472 RID: 9330
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_TradeItems(IntPtr intptr_0, out GStruct31 gstruct31_0, GStruct22 gstruct22_0, [In] [Out] GStruct7[] gstruct7_0, [In] [Out] uint[] uint_0, uint uint_1, [In] [Out] GStruct7[] gstruct7_1, [In] [Out] uint[] uint_2, uint uint_3);

		// Token: 0x06002473 RID: 9331
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmaking_GetFavoriteGameCount(IntPtr intptr_0);

		// Token: 0x06002474 RID: 9332
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_SetDisplayName(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002475 RID: 9333
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServer_GetServerReputation(IntPtr intptr_0);

		// Token: 0x06002476 RID: 9334
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_SetKeyFocus(IntPtr intptr_0, GStruct43 gstruct43_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002477 RID: 9335
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr intptr_0, GStruct188 gstruct188_0, uint uint_0, byte[] byte_0, uint uint_1);

		// Token: 0x06002478 RID: 9336
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmaking_GetLobbyData(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002479 RID: 9337
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamNetworking_GetSocketInfo(IntPtr intptr_0, GStruct208 gstruct208_0, out GStruct22 gstruct22_0, out int int_0, out uint uint_0, out ushort ushort_0);

		// Token: 0x0600247A RID: 9338
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamMatchmakingServers_RequestLANServerList(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1);

		// Token: 0x0600247B RID: 9339
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr intptr_0, GStruct188 gstruct188_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600247C RID: 9340
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr intptr_0);

		// Token: 0x0600247D RID: 9341
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr intptr_0, GStruct193 gstruct193_0, int int_0, out GStruct21 gstruct21_0, [In] [Out] int[] int_1, int int_2);

		// Token: 0x0600247E RID: 9342
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_SendClanChatMessage(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600247F RID: 9343
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamGameServer_GetSteamID();

		// Token: 0x06002480 RID: 9344
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetLargeFriendAvatar(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002481 RID: 9345
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUGC_SuspendDownloads(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002482 RID: 9346
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_ClearAllKeyValues(IntPtr intptr_0);

		// Token: 0x06002483 RID: 9347
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamController_StopAnalogActionMomentum(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct189 gstruct189_0);

		// Token: 0x06002484 RID: 9348
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus(IntPtr intptr_0, GEnum68 genum68_0);

		// Token: 0x06002485 RID: 9349
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_CurrentEntryDidChange(IntPtr intptr_0);

		// Token: 0x06002486 RID: 9350
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamController_ShowDigitalActionOrigins(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct20 gstruct20_0, float float_0, float float_1, float float_2);

		// Token: 0x06002487 RID: 9351
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_QueueWillChange(IntPtr intptr_0);

		// Token: 0x06002488 RID: 9352
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr intptr_0, GStruct22 gstruct22_0, int int_0);

		// Token: 0x06002489 RID: 9353
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_Shutdown();

		// Token: 0x0600248A RID: 9354
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_GetFriendGamePlayed(IntPtr intptr_0, GStruct22 gstruct22_0, out GStruct122 gstruct122_0);

		// Token: 0x0600248B RID: 9355
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUtils_SetOverlayNotificationPosition(IntPtr intptr_0, GEnum73 genum73_0);

		// Token: 0x0600248C RID: 9356
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_ClearRichPresence(IntPtr intptr_0);

		// Token: 0x0600248D RID: 9357
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_GrantPromoItems(IntPtr intptr_0, out GStruct31 gstruct31_0);

		// Token: 0x0600248E RID: 9358
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUser_BIsPhoneIdentifying(IntPtr intptr_0);

		// Token: 0x0600248F RID: 9359
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamHTTP_CreateHTTPRequest(IntPtr intptr_0, GEnum18 genum18_0, GClass78.GClass79 gclass79_0);

		// Token: 0x06002490 RID: 9360
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x06002491 RID: 9361
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x06002492 RID: 9362
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamFriends_GetFriendsGroupName(IntPtr intptr_0, GStruct235 gstruct235_0);

		// Token: 0x06002493 RID: 9363
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_SetLinkedLobby(IntPtr intptr_0, GStruct22 gstruct22_0, GStruct22 gstruct22_1);

		// Token: 0x06002494 RID: 9364
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamMatchmakingServers_ServerRules(IntPtr intptr_0, uint uint_0, ushort ushort_0, IntPtr intptr_1);

		// Token: 0x06002495 RID: 9365
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamController_GetConnectedControllers(IntPtr intptr_0, [In] [Out] GStruct83[] gstruct83_0);

		// Token: 0x06002496 RID: 9366
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_WasRestartRequested(IntPtr intptr_0);

		// Token: 0x06002497 RID: 9367
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_CancelAuthTicket(IntPtr intptr_0, GStruct176 gstruct176_0);

		// Token: 0x06002498 RID: 9368
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetKeyValue(IntPtr intptr_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x06002499 RID: 9369
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_IsClanPublic(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x0600249A RID: 9370
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_SendQueryUGCRequest(IntPtr intptr_0, GStruct285 gstruct285_0);

		// Token: 0x0600249B RID: 9371
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmakingServers_CancelServerQuery(IntPtr intptr_0, GStruct248 gstruct248_0);

		// Token: 0x0600249C RID: 9372
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamScreenshots_SetLocation(IntPtr intptr_0, GStruct277 gstruct277_0, GClass78.GClass79 gclass79_0);

		// Token: 0x0600249D RID: 9373
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr intptr_0, int int_0, IntPtr intptr_1, uint uint_0, out float float_0, out bool bool_0);

		// Token: 0x0600249E RID: 9374
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_StopFind(IntPtr intptr_0, GStruct43 gstruct43_0);

		// Token: 0x0600249F RID: 9375
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamInternal_GameServer_Init(uint uint_0, ushort ushort_0, ushort ushort_1, ushort ushort_2, GEnum14 genum14_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024A0 RID: 9376
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum70 SteamAPI_ISteamUser_BeginAuthSession(IntPtr intptr_0, byte[] byte_0, int int_0, GStruct22 gstruct22_0);

		// Token: 0x060024A1 RID: 9377
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_StoreStats(IntPtr intptr_0);

		// Token: 0x060024A2 RID: 9378
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr intptr_0);

		// Token: 0x060024A3 RID: 9379
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_SetDedicatedServer(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024A4 RID: 9380
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamInventory_StartPurchase(IntPtr intptr_0, [In] [Out] GStruct36[] gstruct36_0, [In] [Out] uint[] uint_0, uint uint_1);

		// Token: 0x060024A5 RID: 9381
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAPI_ISteamClient_GetISteamMusicRemote(IntPtr intptr_0, GStruct58 gstruct58_0, GStruct128 gstruct128_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024A6 RID: 9382
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr intptr_0);

		// Token: 0x060024A7 RID: 9383
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUserStats_GetGlobalStatHistory(IntPtr intptr_0, GClass78.GClass79 gclass79_0, [In] [Out] long[] long_0, uint uint_0);

		// Token: 0x060024A8 RID: 9384
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamAppList_GetInstalledApps(IntPtr intptr_0, [In] [Out] GStruct66[] gstruct66_0, uint uint_0);

		// Token: 0x060024A9 RID: 9385
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamInventory_LoadItemDefinitions(IntPtr intptr_0);

		// Token: 0x060024AA RID: 9386
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_SetInGameVoiceSpeaking(IntPtr intptr_0, GStruct22 gstruct22_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024AB RID: 9387
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamFriends_GetUserRestrictions(IntPtr intptr_0);

		// Token: 0x060024AC RID: 9388
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetSecondsSinceAppActive(IntPtr intptr_0);

		// Token: 0x060024AD RID: 9389
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_BUpdateUserData(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, uint uint_0);

		// Token: 0x060024AE RID: 9390
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusic_BIsEnabled(IntPtr intptr_0);

		// Token: 0x060024AF RID: 9391
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_LoadURL(IntPtr intptr_0, GStruct43 gstruct43_0, GClass78.GClass79 gclass79_0, GClass78.GClass79 gclass79_1);

		// Token: 0x060024B0 RID: 9392
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnablePlayNext(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024B1 RID: 9393
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_ClearUserAchievement(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024B2 RID: 9394
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_PlaylistDidChange(IntPtr intptr_0);

		// Token: 0x060024B3 RID: 9395
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUGC_StopPlaytimeTracking(IntPtr intptr_0, [In] [Out] GStruct78[] gstruct78_0, uint uint_0);

		// Token: 0x060024B4 RID: 9396
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamApps_BIsLowViolence(IntPtr intptr_0);

		// Token: 0x060024B5 RID: 9397
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamClient_CreateSteamPipe(IntPtr intptr_0);

		// Token: 0x060024B6 RID: 9398
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr intptr_0, GClass78.GClass79 gclass79_0, int int_0, GEnum55 genum55_0);

		// Token: 0x060024B7 RID: 9399
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_GetImageSize(IntPtr intptr_0, int int_0, out uint uint_0, out uint uint_1);

		// Token: 0x060024B8 RID: 9400
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_KeyUp(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0);

		// Token: 0x060024B9 RID: 9401
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamHTMLSurface_KeyDown(IntPtr intptr_0, GStruct43 gstruct43_0, uint uint_0, GEnum19 genum19_0);

		// Token: 0x060024BA RID: 9402
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_RegisterCallback(IntPtr intptr_0, int int_0);

		// Token: 0x060024BB RID: 9403
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamApps_GetDLCCount(IntPtr intptr_0);

		// Token: 0x060024BC RID: 9404
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUserStats_DownloadLeaderboardEntries(IntPtr intptr_0, GStruct305 gstruct305_0, GEnum24 genum24_0, int int_0, int int_1);

		// Token: 0x060024BD RID: 9405
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamGameServer_GetAuthSessionTicket(IntPtr intptr_0, byte[] byte_0, int int_0, out uint uint_0);

		// Token: 0x060024BE RID: 9406
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_UpdateLooped(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024BF RID: 9407
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum6 SteamAPI_ISteamController_GetInputTypeForHandle(IntPtr intptr_0, GStruct83 gstruct83_0);

		// Token: 0x060024C0 RID: 9408
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_BLoggedOn(IntPtr intptr_0);

		// Token: 0x060024C1 RID: 9409
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_SetListenForFriendsMessages(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024C2 RID: 9410
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_GetSteamInstallPath();

		// Token: 0x060024C3 RID: 9411
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetRankedByTrendDays(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0);

		// Token: 0x060024C4 RID: 9412
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetFriendsGroupCount(IntPtr intptr_0);

		// Token: 0x060024C5 RID: 9413
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamController_GetAnalogActionOrigins(IntPtr intptr_0, GStruct83 gstruct83_0, GStruct290 gstruct290_0, GStruct189 gstruct189_0, [In] [Out] GEnum33[] genum33_0);

		// Token: 0x060024C6 RID: 9414
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum27 SteamAPI_ISteamNetworking_GetSocketConnectionType(IntPtr intptr_0, GStruct208 gstruct208_0);

		// Token: 0x060024C7 RID: 9415
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamUser_EndAuthSession(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060024C8 RID: 9416
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetReturnLongDescription(IntPtr intptr_0, GStruct285 gstruct285_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024C9 RID: 9417
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServerStats_SetUserStat(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0, int int_0);

		// Token: 0x060024CA RID: 9418
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_GetFriendsGroupMembersList(IntPtr intptr_0, GStruct235 gstruct235_0, [In] [Out] GStruct22[] gstruct22_0, int int_0);

		// Token: 0x060024CB RID: 9419
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamFriends_GetCoplayFriendCount(IntPtr intptr_0);

		// Token: 0x060024CC RID: 9420
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_ResetQueueEntries(IntPtr intptr_0);

		// Token: 0x060024CD RID: 9421
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamFriends_DownloadClanActivityCounts(IntPtr intptr_0, [In] [Out] GStruct22[] gstruct22_0, int int_0);

		// Token: 0x060024CE RID: 9422
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamUser_GetGameBadgeLevel(IntPtr intptr_0, int int_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024CF RID: 9423
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamFriends_RequestFriendRichPresence(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060024D0 RID: 9424
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime(IntPtr intptr_0, GClass78.GClass79 gclass79_0, out bool bool_0, out uint uint_0);

		// Token: 0x060024D1 RID: 9425
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnableLooped(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024D2 RID: 9426
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_RequestLobbyData(IntPtr intptr_0, GStruct22 gstruct22_0);

		// Token: 0x060024D3 RID: 9427
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMusicRemote_EnableQueue(IntPtr intptr_0, [MarshalAs(UnmanagedType.I1)] bool bool_0);

		// Token: 0x060024D4 RID: 9428
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamUtils_CheckFileSignature(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024D5 RID: 9429
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_BOverlayNeedsPresent(IntPtr intptr_0);

		// Token: 0x060024D6 RID: 9430
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr intptr_0, GStruct215 gstruct215_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024D7 RID: 9431
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong SteamAPI_ISteamGameServer_GetSteamID(IntPtr intptr_0);

		// Token: 0x060024D8 RID: 9432
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern GEnum75 SteamAPI_ISteamUGC_GetItemUpdateProgress(IntPtr intptr_0, GStruct16 gstruct16_0, out ulong ulong_0, out ulong ulong_1);

		// Token: 0x060024D9 RID: 9433
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamMatchmakingServers_RefreshQuery(IntPtr intptr_0, GStruct240 gstruct240_0);

		// Token: 0x060024DA RID: 9434
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamGameServer_InitGameServer(IntPtr intptr_0, uint uint_0, ushort ushort_0, ushort ushort_1, uint uint_1, GStruct66 gstruct66_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024DB RID: 9435
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamHTMLSurface_Shutdown(IntPtr intptr_0);

		// Token: 0x060024DC RID: 9436
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint SteamAPI_ISteamUtils_GetServerRealTime(IntPtr intptr_0);

		// Token: 0x060024DD RID: 9437
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamFriends_ReplyToFriendMessage(IntPtr intptr_0, GStruct22 gstruct22_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024DE RID: 9438
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_GetQueryUGCPreviewURL(IntPtr intptr_0, GStruct285 gstruct285_0, uint uint_0, IntPtr intptr_1, uint uint_1);

		// Token: 0x060024DF RID: 9439
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamMatchmaking_GetLobbyGameServer(IntPtr intptr_0, GStruct22 gstruct22_0, out uint uint_0, out ushort ushort_0, out GStruct22 gstruct22_1);

		// Token: 0x060024E0 RID: 9440
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUtils_ShowGamepadTextInput(IntPtr intptr_0, GEnum21 genum21_0, GEnum51 genum51_0, GClass78.GClass79 gclass79_0, uint uint_0, GClass78.GClass79 gclass79_1);

		// Token: 0x060024E1 RID: 9441
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamClient();

		// Token: 0x060024E2 RID: 9442
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SteamAPI_ISteamGameServer_LogOn(IntPtr intptr_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024E3 RID: 9443
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamUGC_SetLanguage(IntPtr intptr_0, GStruct285 gstruct285_0, GClass78.GClass79 gclass79_0);

		// Token: 0x060024E4 RID: 9444
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_Init();

		// Token: 0x060024E5 RID: 9445
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SteamAPI_ISteamAppList_GetAppName(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, int int_0);

		// Token: 0x060024E6 RID: 9446
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamScreenshots_TagUser(IntPtr intptr_0, GStruct277 gstruct277_0, GStruct22 gstruct22_0);

		// Token: 0x060024E7 RID: 9447
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_ISteamVideo_GetOPFStringForApp(IntPtr intptr_0, GStruct66 gstruct66_0, IntPtr intptr_1, ref int int_0);

		// Token: 0x04001345 RID: 4933
		internal const string string_0 = "steam_api64";

		// Token: 0x04001346 RID: 4934
		internal const string string_1 = "sdkencryptedappticket64";
	}
}
