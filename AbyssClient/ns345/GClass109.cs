using System;
using ns226;
using ns348;
using ns370;

namespace ns345
{
	// Token: 0x020002B1 RID: 689
	public static class GClass109
	{
		// Token: 0x06001FD0 RID: 8144 RVA: 0x000A4628 File Offset: 0x000A2828
		public static bool smethod_0(float float_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdateVolume(<Module>.smethod_18(), float_0);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x000A4648 File Offset: 0x000A2848
		public static bool smethod_1()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote(<Module>.smethod_18());
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000A4664 File Offset: 0x000A2864
		public static bool smethod_2(int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry(<Module>.smethod_18(), int_0);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000A4684 File Offset: 0x000A2884
		public static bool smethod_3(int int_0, int int_1, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMusicRemote_SetQueueEntry(<Module>.smethod_18(), int_0, int_1, gclass);
			}
			return result;
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000A46C8 File Offset: 0x000A28C8
		public static bool smethod_4(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote(<Module>.smethod_18(), gclass);
			}
			return result;
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000A470C File Offset: 0x000A290C
		public static bool smethod_5(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnablePlayNext(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000A472C File Offset: 0x000A292C
		public static bool smethod_6(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdateShuffled(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000A474C File Offset: 0x000A294C
		public static bool smethod_7(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnablePlayPrevious(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000A476C File Offset: 0x000A296C
		public static bool smethod_8()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_ResetQueueEntries(<Module>.smethod_18());
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000A4788 File Offset: 0x000A2988
		public static bool smethod_9()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_QueueWillChange(<Module>.smethod_18());
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000A47A4 File Offset: 0x000A29A4
		public static bool smethod_10(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnablePlaylists(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000A47C4 File Offset: 0x000A29C4
		public static bool smethod_11()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_ResetPlaylistEntries(<Module>.smethod_18());
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000A47E0 File Offset: 0x000A29E0
		public static bool smethod_12(int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(<Module>.smethod_18(), int_0);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000A4800 File Offset: 0x000A2A00
		public static bool smethod_13(GEnum68 genum68_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus(<Module>.smethod_18(), genum68_0);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000A4820 File Offset: 0x000A2A20
		public static bool smethod_14()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_PlaylistWillChange(<Module>.smethod_18());
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000A483C File Offset: 0x000A2A3C
		public static bool smethod_15(int int_0, int int_1, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMusicRemote_SetPlaylistEntry(<Module>.smethod_18(), int_0, int_1, gclass);
			}
			return result;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000A4880 File Offset: 0x000A2A80
		public static bool smethod_16(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnableQueue(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000A48A0 File Offset: 0x000A2AA0
		public static bool smethod_17()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_CurrentEntryWillChange(<Module>.smethod_18());
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x000A48BC File Offset: 0x000A2ABC
		public static bool smethod_18(byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt(<Module>.smethod_18(), byte_0, uint_0);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000A48DC File Offset: 0x000A2ADC
		public static bool smethod_19(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText(<Module>.smethod_18(), gclass);
			}
			return result;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000A4920 File Offset: 0x000A2B20
		public static bool smethod_20()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_QueueDidChange(<Module>.smethod_18());
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000A493C File Offset: 0x000A2B3C
		public static bool smethod_21()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_CurrentEntryDidChange(<Module>.smethod_18());
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000A4958 File Offset: 0x000A2B58
		public static bool smethod_22(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnableLooped(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000A4978 File Offset: 0x000A2B78
		public static bool smethod_23(int int_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry(<Module>.smethod_18(), int_0);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000A4998 File Offset: 0x000A2B98
		public static bool smethod_24(byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64(<Module>.smethod_18(), byte_0, uint_0);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000A49B8 File Offset: 0x000A2BB8
		public static bool smethod_25(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		public static bool smethod_26(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_UpdateLooped(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000A49F8 File Offset: 0x000A2BF8
		public static bool smethod_27(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_BActivationSuccess(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x000A4A18 File Offset: 0x000A2C18
		public static bool smethod_28(bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_EnableShuffled(<Module>.smethod_18(), bool_0);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000A4A38 File Offset: 0x000A2C38
		public static bool smethod_29()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote(<Module>.smethod_18());
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000A4A54 File Offset: 0x000A2C54
		public static bool smethod_30(string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamMusicRemote_SetDisplayName(<Module>.smethod_18(), gclass);
			}
			return result;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000A4A98 File Offset: 0x000A2C98
		public static bool smethod_31()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamMusicRemote_PlaylistDidChange(<Module>.smethod_18());
		}
	}
}
