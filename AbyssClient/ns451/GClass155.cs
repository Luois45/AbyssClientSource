using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using BestHTTP;
using BestHTTP.Forms;
using BestHTTP.JSON;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ns185;
using ns241;
using ns246;
using ns247;
using ns248;
using ns249;
using ns250;
using ns251;
using ns252;
using ns253;
using ns254;
using ns255;
using ns256;
using ns257;
using ns258;
using ns259;
using ns260;
using ns425;
using ns483;
using ns487;
using RenderHeads.Media.AVProVideo;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDK.Internal.MeetingBunker;
using VRC.SDK.Internal.MeetingBunker.VRC_Presentation_Utils;
using VRC.SDK.Internal.Whiteboard.VRC_Presentation_Utils;
using VRC.SDK3.Video.Components.AVPro;
using VRC.SDKBase;
using VRC.UI;
using VRCSDK2;

namespace ns451
{
	// Token: 0x02000257 RID: 599
	public class GClass155 : GClass130
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0008BBD4 File Offset: 0x00089DD4
		internal void method_2(bool bool_25)
		{
			this.method_50(bool_25);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0008BBE8 File Offset: 0x00089DE8
		internal void method_3(bool bool_25)
		{
			this.method_5(bool_25);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0008BBFC File Offset: 0x00089DFC
		internal void method_4(bool bool_25)
		{
			this.method_28(bool_25);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0008BC10 File Offset: 0x00089E10
		private static bool smethod_0(string string_2, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, API.CredentialsBundle credentialsBundle_0)
		{
			if (GClass155.bool_23)
			{
			}
			return true;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0008BC28 File Offset: 0x00089E28
		private static void smethod_1()
		{
			GClass155.smethod_80();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0008BC3C File Offset: 0x00089E3C
		private static void smethod_2(APIUser apiuser_0, ref APIUser.DeveloperType developerType_0)
		{
			GClass155.smethod_85(apiuser_0, ref developerType_0);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0008BC50 File Offset: 0x00089E50
		private static bool smethod_3(Player player_0)
		{
			GClass84.smethod_1717();
			return true;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0008BC64 File Offset: 0x00089E64
		private static void smethod_4(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_28(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0008BC78 File Offset: 0x00089E78
		private static void smethod_5(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_4(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0008BC8C File Offset: 0x00089E8C
		private static void smethod_6(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_81(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0008BCA0 File Offset: 0x00089EA0
		internal void method_5(bool bool_25)
		{
			GClass186.gclass186_0.bool_1 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_10 = bool_25;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0008BCC4 File Offset: 0x00089EC4
		internal void method_6(bool bool_25)
		{
			GClass186.gclass186_0.bool_10 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_18 = bool_25;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0008BCE8 File Offset: 0x00089EE8
		private static void smethod_7(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_33(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0008BCFC File Offset: 0x00089EFC
		private static void smethod_8(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_13(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0008BD10 File Offset: 0x00089F10
		private static void smethod_9()
		{
			GClass155.smethod_25();
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0008BD24 File Offset: 0x00089F24
		internal void method_7(bool bool_25)
		{
			this.method_19(bool_25);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0008BD38 File Offset: 0x00089F38
		private static void smethod_10()
		{
			GClass84.gclass93_0.method_236();
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0008BD50 File Offset: 0x00089F50
		private static void smethod_11(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_93(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0008BD64 File Offset: 0x00089F64
		private static void smethod_12(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_48(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0008BD78 File Offset: 0x00089F78
		public override void vmethod_23()
		{
			this.method_18();
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0008BD8C File Offset: 0x00089F8C
		internal void method_8(bool bool_25)
		{
			this.method_26(bool_25);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0008BDA0 File Offset: 0x00089FA0
		private static void smethod_13(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_53(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0008BDB4 File Offset: 0x00089FB4
		internal void method_9(bool bool_25)
		{
			this.method_34(bool_25);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0008BDC8 File Offset: 0x00089FC8
		private static bool smethod_14(VRCPlayer vrcplayer_0, int int_0, Player player_0)
		{
			bool result;
			if (!vrcplayer_0 || !player_0)
			{
				result = false;
			}
			else
			{
				VRCPlayer vrcplayer = GClass84.smethod_367(player_0);
				if (!vrcplayer)
				{
					result = false;
				}
				else
				{
					GClass84.smethod_1178(vrcplayer_0, "Someone");
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0008BE18 File Offset: 0x0008A018
		internal void method_10(bool bool_25)
		{
			GClass186.gclass186_0.bool_6 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_14 = bool_25;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0008BE3C File Offset: 0x0008A03C
		private static bool smethod_15(Player player_0, VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_0, float float_1)
		{
			APIUser apiuser = GClass84.smethod_518(player_0);
			GameObject parameterObject = vrcEvent_0.ParameterObject;
			string text = string.Empty;
			Transform transform = null;
			if (parameterObject)
			{
				text = parameterObject.name;
				transform = parameterObject.transform;
			}
			string text2 = text.ToLower();
			string a = text2;
			bool result;
			if (a == "indicator" && parameterObject && (apiuser.id != GClass84.smethod_1372().id && (GClass84.smethod_555(transform.position) || GClass84.smethod_1136(transform.position))))
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					apiuser.displayName,
					" ",
					"tried",
					" ",
					"to",
					" ",
					"camera",
					" ",
					"crash",
					" ",
					"you"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0008BF4C File Offset: 0x0008A14C
		public override void vmethod_8(int int_0)
		{
			this.method_22(int_0);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0008BF60 File Offset: 0x0008A160
		internal void method_11(bool bool_25)
		{
			GClass186.gclass186_0.bool_11 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_19 = bool_25;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0008BF84 File Offset: 0x0008A184
		internal void method_12(bool bool_25)
		{
			this.method_38(bool_25);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0008BF98 File Offset: 0x0008A198
		internal void method_13(bool bool_25)
		{
			this.method_35(bool_25);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0008BFAC File Offset: 0x0008A1AC
		private static void smethod_16()
		{
			GClass155.smethod_70();
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
		private IEnumerator method_14()
		{
			GClass155.Class155 @class = new GClass155.Class155(0);
			@class.gclass155_0 = this;
			return @class;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0008BFDC File Offset: 0x0008A1DC
		internal void method_15(bool bool_25)
		{
			this.method_42(bool_25);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0008BFF0 File Offset: 0x0008A1F0
		private static bool smethod_17(string string_2)
		{
			if (string.IsNullOrEmpty(string_2))
			{
				GClass70.smethod_38("AddURL1()", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"AddURL",
					"1",
					"(",
					string_2,
					")"
				}), GClass70.Enum1.const_0);
			}
			try
			{
				if (GClass155.smethod_50(string_2))
				{
					return false;
				}
				if (GClass155.bool_6 && !GClass155.smethod_56(string_2))
				{
					return false;
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0008C088 File Offset: 0x0008A288
		internal static void smethod_18(bool bool_25)
		{
			GClass155.smethod_88(bool_25);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0008C09C File Offset: 0x0008A29C
		private static void smethod_19(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_15)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0008C0E8 File Offset: 0x0008A2E8
		internal void method_16(bool bool_25)
		{
			GClass186.gclass186_0.bool_12 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_20 = bool_25;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0008C10C File Offset: 0x0008A30C
		internal static HarmonyMethod smethod_20(string string_2)
		{
			return new HarmonyMethod(typeof(GClass155).GetMethod(string_2, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0008C134 File Offset: 0x0008A334
		internal void method_17(bool bool_25)
		{
			this.method_39(bool_25);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0008C148 File Offset: 0x0008A348
		private static void smethod_21()
		{
			GClass155.smethod_41();
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0008C15C File Offset: 0x0008A35C
		internal void method_18()
		{
			this.method_51();
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0008C170 File Offset: 0x0008A370
		internal static void smethod_22(string string_2, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, bool bool_25, float float_1, API.CredentialsBundle credentialsBundle_0)
		{
			GClass155.bool_23 = true;
			API.SendGetRequest(string_2, apiContainer_0, ireadOnlyDictionary_0, bool_25, float_1, credentialsBundle_0);
			GClass155.bool_23 = false;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0008C198 File Offset: 0x0008A398
		private static string smethod_23()
		{
			return GClass155.smethod_57();
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0008C1AC File Offset: 0x0008A3AC
		private static bool smethod_24(PortalInternal portalInternal_0, MethodBase methodBase_0)
		{
			GClass155.Class154 @class = new GClass155.Class154();
			@class.methodBase_0 = methodBase_0;
			@class.portalInternal_0 = portalInternal_0;
			bool result;
			if (GClass155.bool_1 || @class.portalInternal_0 == null || @class.portalInternal_0.field_Private_ApiWorld_0 == null)
			{
				result = false;
			}
			else if (!GClass155.bool_8 && GClass155.bool_2)
			{
				Player player = GClass84.smethod_703(@class.portalInternal_0.field_Private_Int32_0);
				GClass84.smethod_1304("Portal Confirmation", string.Concat(new string[]
				{
					"Would",
					" ",
					"you",
					" ",
					"like",
					" ",
					"to",
					" ",
					"enter",
					" ",
					"this",
					" ",
					"world",
					"?",
					"\n",
					"Name",
					": ",
					@class.portalInternal_0.field_Private_ApiWorld_0.name,
					"\n",
					"Author",
					": ",
					@class.portalInternal_0.field_Private_ApiWorld_0.authorName,
					"\n",
					"Player",
					": ",
					(player != null) ? GClass84.smethod_518(player).displayName : "No Player"
				}), "Yes", new Action(@class.method_0), "No", new Action(GClass155.Class152.class152_0.method_2));
				result = false;
			}
			else
			{
				GClass155.bool_8 = false;
				result = true;
			}
			return result;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0008C38C File Offset: 0x0008A58C
		internal void method_19(bool bool_25)
		{
			GClass186.gclass186_0.bool_14 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_22 = bool_25;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0008C3B0 File Offset: 0x0008A5B0
		private static void smethod_25()
		{
			GClass84.gclass93_0.method_12();
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0008C3C8 File Offset: 0x0008A5C8
		private static bool smethod_26(string string_2, string string_3, string string_4, string string_5, Action<ApiModelContainer<APIUser>> action_0, Action<string> action_1)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"APIUser_Register",
				"(",
				string_2,
				", ",
				string_3,
				", ",
				string_4,
				", ",
				string_5,
				", "
			}), GClass70.Enum1.const_0);
			return true;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0008C42C File Offset: 0x0008A62C
		private static void smethod_27(ApiContainer apiContainer_0, bool bool_25, int int_0, string string_2, Func<Il2CppStructArray<byte>> func_0, Func<string> func_1, float float_1)
		{
			GClass155.smethod_44(apiContainer_0, bool_25, int_0, string_2, func_0, func_1, float_1);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0008C450 File Offset: 0x0008A650
		private static void smethod_28(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_19)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0008C49C File Offset: 0x0008A69C
		private static bool smethod_29(VRC_SyncVideoPlayer vrc_SyncVideoPlayer_0)
		{
			if (vrc_SyncVideoPlayer_0.Videos.Count<VRC_SyncVideoPlayer.VideoEntry>() > 0)
			{
				string url = vrc_SyncVideoPlayer_0.Videos.First<VRC_SyncVideoPlayer.VideoEntry>().URL;
				if (string.IsNullOrEmpty(url))
				{
					GClass70.smethod_38("Play1()", GClass70.Enum1.const_0);
				}
				else
				{
					GClass70.smethod_38("Play" + "1" + ": " + url, GClass70.Enum1.const_0);
					if (GClass155.smethod_50(url))
					{
						return false;
					}
					if (!GClass155.smethod_56(url))
					{
						return !GClass155.bool_6;
					}
				}
			}
			return true;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0008C524 File Offset: 0x0008A724
		internal void method_20(int int_0)
		{
			if (int_0 == -1 && GClass155.bool_22)
			{
				MelonCoroutines.Start(this.method_14());
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0008C54C File Offset: 0x0008A74C
		internal void method_21(bool bool_25)
		{
			this.method_46(bool_25);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0008C560 File Offset: 0x0008A760
		internal void method_22(int int_0)
		{
			this.method_20(int_0);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0008C574 File Offset: 0x0008A774
		private static void smethod_30(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_87(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0008C588 File Offset: 0x0008A788
		internal void method_23(bool bool_25)
		{
			this.method_6(bool_25);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0008C59C File Offset: 0x0008A79C
		private static void smethod_31(ref string string_2)
		{
			GClass155.smethod_43(ref string_2);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		internal void method_24(bool bool_25)
		{
			this.method_3(bool_25);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0008C5C4 File Offset: 0x0008A7C4
		private static void smethod_32()
		{
			GClass155.smethod_9();
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		private static void smethod_33(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_83(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0008C5EC File Offset: 0x0008A7EC
		private static bool smethod_34(MediaPlayer mediaPlayer_0)
		{
			string videoPath = mediaPlayer_0.m_VideoPath;
			if (string.IsNullOrEmpty(videoPath))
			{
				GClass70.smethod_38("Play3()", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38("Play" + "3" + ": " + videoPath, GClass70.Enum1.const_0);
				if (GClass155.smethod_50(videoPath))
				{
					return false;
				}
				if (!GClass155.smethod_56(videoPath))
				{
					return !GClass155.bool_6;
				}
			}
			return true;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0008C658 File Offset: 0x0008A858
		private static void smethod_35(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_14)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0008C6A4 File Offset: 0x0008A8A4
		private static void smethod_36(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_38(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0008C6B8 File Offset: 0x0008A8B8
		internal void method_25(bool bool_25)
		{
			GClass186.gclass186_0.bool_5 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_13 = bool_25;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0008C6DC File Offset: 0x0008A8DC
		internal void method_26(bool bool_25)
		{
			this.method_43(bool_25);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		private static bool smethod_37(string string_2)
		{
			if (string.IsNullOrEmpty(string_2))
			{
				GClass70.smethod_38("AddURL2()", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"AddURL",
					"2",
					"(",
					string_2,
					")"
				}), GClass70.Enum1.const_0);
			}
			try
			{
				if (GClass155.smethod_50(string_2))
				{
					return false;
				}
				if (GClass155.bool_6 && !GClass155.smethod_56(string_2))
				{
					return false;
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0008C788 File Offset: 0x0008A988
		internal void method_27(bool bool_25)
		{
			this.method_40(bool_25);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0008C79C File Offset: 0x0008A99C
		private static void smethod_38(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_19(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0008C7B0 File Offset: 0x0008A9B0
		internal void method_28(bool bool_25)
		{
			this.method_48(bool_25);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0008C7C4 File Offset: 0x0008A9C4
		private static void smethod_39(ApiContainer apiContainer_0, bool bool_25, int int_0, string string_2, Func<Il2CppStructArray<byte>> func_0, Func<string> func_1, float float_1)
		{
			GClass155.smethod_27(apiContainer_0, bool_25, int_0, string_2, func_0, func_1, float_1);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0008C7E8 File Offset: 0x0008A9E8
		internal void method_29(bool bool_25)
		{
			this.method_7(bool_25);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0008C7FC File Offset: 0x0008A9FC
		private static void smethod_40(string string_2)
		{
			GClass186.gclass186_0.string_0 = string_2;
			GClass186.smethod_0();
			GClass155.string_1 = string_2;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0008C820 File Offset: 0x0008AA20
		private static void smethod_41()
		{
			GClass84.gclass93_0.method_100();
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0008C838 File Offset: 0x0008AA38
		internal void method_30(bool bool_25)
		{
			GClass186.gclass186_0.bool_9 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_17 = bool_25;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0008C85C File Offset: 0x0008AA5C
		private static bool smethod_42(VRCAvatarManager vrcavatarManager_0, ApiAvatar apiAvatar_0, GameObject gameObject_0)
		{
			GClass84.gclass93_0.method_154(vrcavatarManager_0.field_Private_VRCPlayer_0.Method_Public_get_Player_0().Method_Internal_get_APIUser_0().id, vrcavatarManager_0.field_Private_VRCPlayer_0.Method_Public_get_Player_0().Method_Internal_get_APIUser_0().displayName, gameObject_0);
			return true;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0008C8A0 File Offset: 0x0008AAA0
		private static void smethod_43(ref string string_2)
		{
			GClass155.smethod_51(ref string_2);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0008C8B4 File Offset: 0x0008AAB4
		private static void smethod_44(ApiContainer apiContainer_0, bool bool_25, int int_0, string string_2, Func<Il2CppStructArray<byte>> func_0, Func<string> func_1, float float_1)
		{
			object obj = GClass84.smethod_308<object>(apiContainer_0.Data);
			if (obj != null)
			{
				List<object> list = obj as List<object>;
				if (list != null)
				{
					bool flag = false;
					using (List<object>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							Class132 gparam_;
							Class131 gparam_2;
							Class140 gparam_3;
							Class134 gparam_4;
							Class136 gparam_5;
							Class143 gparam_6;
							Class129 gparam_7;
							Class137 gparam_8;
							Class133 gparam_9;
							Class142 gparam_10;
							Class130 gparam_11;
							Class139 gparam_12;
							Class135 @class;
							Class141 class2;
							Class138 gparam_13;
							if (Class132.smethod_0(obj2, out gparam_))
							{
								Class191.smethod_0<Class132>(GClass155.list_1, gparam_);
							}
							else if (Class131.smethod_0(obj2, out gparam_2))
							{
								Class191.smethod_0<Class131>(GClass155.list_2, gparam_2);
							}
							else if (Class140.smethod_0(obj2, out gparam_3))
							{
								Class191.smethod_0<Class140>(GClass155.list_3, gparam_3);
							}
							else if (Class134.smethod_0(obj2, out gparam_4))
							{
								Class191.smethod_0<Class134>(GClass155.list_4, gparam_4);
							}
							else if (Class136.smethod_0(obj2, out gparam_5))
							{
								Class191.smethod_0<Class136>(GClass155.list_5, gparam_5);
							}
							else if (Class143.smethod_0(obj2, out gparam_6))
							{
								Class191.smethod_0<Class143>(GClass155.list_6, gparam_6);
							}
							else if (Class129.smethod_0(obj2, out gparam_7))
							{
								Class191.smethod_0<Class129>(GClass155.list_7, gparam_7);
							}
							else if (Class137.smethod_0(obj2, out gparam_8))
							{
								Class191.smethod_0<Class137>(GClass155.list_8, gparam_8);
							}
							else if (Class133.smethod_0(obj2, out gparam_9))
							{
								Class191.smethod_0<Class133>(GClass155.list_9, gparam_9);
							}
							else if (Class142.smethod_0(obj2, out gparam_10))
							{
								Class191.smethod_0<Class142>(GClass155.list_10, gparam_10);
							}
							else if (Class130.smethod_0(obj2, out gparam_11))
							{
								Class191.smethod_0<Class130>(GClass155.list_11, gparam_11);
							}
							else if (Class139.smethod_0(obj2, out gparam_12))
							{
								Class191.smethod_0<Class139>(GClass155.list_12, gparam_12);
							}
							else if (Class135.smethod_0(obj2, out @class))
							{
								GClass155.class135_0 = @class;
							}
							else if (Class141.smethod_0(obj2, out class2))
							{
								GClass155.class141_0 = class2;
							}
							else if (Class138.smethod_0(obj2, out gparam_13))
							{
								Class191.smethod_0<Class138>(GClass155.list_14, gparam_13);
							}
							else
							{
								string text = obj2 as string;
								if (text != null)
								{
									if (GClass155.list_13 == null || text == null)
									{
										break;
									}
									for (int i = 0; i < GClass155.list_13.Count; i++)
									{
										if (GClass155.list_13[i] == text)
										{
											GClass155.list_13[i] = text;
											return;
										}
									}
									GClass155.list_13.Add(text);
								}
								else
								{
									if (!flag)
									{
										GClass70.smethod_38("ApiContainer_OnComplete_Post:", GClass70.Enum1.const_0);
										flag = true;
									}
									GClass70.smethod_24(GeneralExtensions.Join<string>(GClass84.smethod_46<object>(obj2, 0, 2, false, true, true, true, false), null, "\n"), GClass70.Enum1.const_0);
								}
							}
						}
						return;
					}
				}
				Class132 gparam_14;
				Class131 gparam_15;
				Class140 gparam_16;
				Class134 gparam_17;
				Class136 gparam_18;
				Class143 gparam_19;
				Class129 gparam_20;
				Class137 gparam_21;
				Class133 gparam_22;
				Class142 gparam_23;
				Class130 gparam_24;
				Class139 gparam_25;
				Class135 class3;
				Class141 class4;
				Class138 gparam_26;
				if (Class132.smethod_0(obj, out gparam_14))
				{
					Class191.smethod_0<Class132>(GClass155.list_1, gparam_14);
				}
				else if (Class131.smethod_0(obj, out gparam_15))
				{
					Class191.smethod_0<Class131>(GClass155.list_2, gparam_15);
				}
				else if (Class140.smethod_0(obj, out gparam_16))
				{
					Class191.smethod_0<Class140>(GClass155.list_3, gparam_16);
				}
				else if (Class134.smethod_0(obj, out gparam_17))
				{
					Class191.smethod_0<Class134>(GClass155.list_4, gparam_17);
				}
				else if (Class136.smethod_0(obj, out gparam_18))
				{
					Class191.smethod_0<Class136>(GClass155.list_5, gparam_18);
				}
				else if (Class143.smethod_0(obj, out gparam_19))
				{
					Class191.smethod_0<Class143>(GClass155.list_6, gparam_19);
				}
				else if (Class129.smethod_0(obj, out gparam_20))
				{
					Class191.smethod_0<Class129>(GClass155.list_7, gparam_20);
				}
				else if (Class137.smethod_0(obj, out gparam_21))
				{
					Class191.smethod_0<Class137>(GClass155.list_8, gparam_21);
				}
				else if (Class133.smethod_0(obj, out gparam_22))
				{
					Class191.smethod_0<Class133>(GClass155.list_9, gparam_22);
				}
				else if (Class142.smethod_0(obj, out gparam_23))
				{
					Class191.smethod_0<Class142>(GClass155.list_10, gparam_23);
				}
				else if (Class130.smethod_0(obj, out gparam_24))
				{
					Class191.smethod_0<Class130>(GClass155.list_11, gparam_24);
				}
				else if (Class139.smethod_0(obj, out gparam_25))
				{
					Class191.smethod_0<Class139>(GClass155.list_12, gparam_25);
				}
				else if (Class135.smethod_0(obj, out class3))
				{
					GClass155.class135_0 = class3;
				}
				else if (Class141.smethod_0(obj, out class4))
				{
					GClass155.class141_0 = class4;
				}
				else if (Class138.smethod_0(obj, out gparam_26))
				{
					Class191.smethod_0<Class138>(GClass155.list_14, gparam_26);
				}
				else
				{
					string text2 = obj as string;
					if (text2 != null)
					{
						if (GClass155.list_13 != null && text2 != null)
						{
							for (int j = 0; j < GClass155.list_13.Count; j++)
							{
								if (GClass155.list_13[j] == text2)
								{
									GClass155.list_13[j] = text2;
									return;
								}
							}
							GClass155.list_13.Add(text2);
						}
					}
					else
					{
						GClass70.smethod_38("ApiContainer_OnComplete_Post:", GClass70.Enum1.const_0);
						Object data = apiContainer_0.Data;
						GClass70.smethod_24(GeneralExtensions.Join<string>(GClass84.smethod_46<Object>(data, 0, 2, false, true, true, true, false), null, "\n"), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
		internal void method_31(bool bool_25)
		{
			this.method_45(bool_25);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0008CDC8 File Offset: 0x0008AFC8
		internal void method_32(bool bool_25)
		{
			this.method_27(bool_25);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_45(HighlightsFX highlightsFX_0, Renderer renderer_0, bool bool_25)
		{
			return true;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0008CDDC File Offset: 0x0008AFDC
		private static void smethod_46(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_11(apiuser_0, ref bool_25);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0008CDF0 File Offset: 0x0008AFF0
		internal void method_33(bool bool_25)
		{
			this.method_31(bool_25);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0008CE04 File Offset: 0x0008B004
		private static bool smethod_47(string string_2, string string_3, Action action_0, Action<string> action_1)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"APIUser_SetStatus",
				": ",
				string_2,
				", ",
				string_3,
				", "
			}), GClass70.Enum1.const_0);
			return true;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0008CE4C File Offset: 0x0008B04C
		private static void smethod_48(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_11)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0008CE98 File Offset: 0x0008B098
		private static bool smethod_49(string string_2, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, API.CredentialsBundle credentialsBundle_0)
		{
			return !GClass155.bool_20 || (!(string_2 == "visits") && !(string_2 == "joins"));
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		internal static bool smethod_50(string string_2)
		{
			return string_2.Contains("herokuapp.com");
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0008CEF8 File Offset: 0x0008B0F8
		private static void smethod_51(ref string string_2)
		{
			try
			{
				if (GClass155.float_0 > 1f)
				{
					GClass84.smethod_1394(AccessTools.Property(typeof(Tools), "Platform").GetMethod, GClass155.smethod_20("PlatformSpoof"));
				}
				else
				{
					GClass155.float_0 += GClass84.float_0;
					if (GClass155.bool_9)
					{
						string_2 = "android";
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0008CF74 File Offset: 0x0008B174
		internal static void smethod_52(bool bool_25)
		{
			GClass155.smethod_18(bool_25);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0008CF88 File Offset: 0x0008B188
		private static void smethod_53(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_18)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0008CFD4 File Offset: 0x0008B1D4
		private static IEnumerator smethod_54(GameObject gameObject_0)
		{
			GClass155.Class153 @class = new GClass155.Class153(0);
			@class.gameObject_0 = gameObject_0;
			return @class;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0008CFF0 File Offset: 0x0008B1F0
		internal void method_34(bool bool_25)
		{
			this.method_44(bool_25);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0008D004 File Offset: 0x0008B204
		private static string smethod_55()
		{
			return GClass155.smethod_23();
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0008D018 File Offset: 0x0008B218
		internal void method_35(bool bool_25)
		{
			this.method_10(bool_25);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0008D02C File Offset: 0x0008B22C
		internal static bool smethod_56(string string_2)
		{
			return string_2.Contains("youtube.com") || string_2.Contains("youtu.be") || string_2.Contains("twitch.tv");
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0008D070 File Offset: 0x0008B270
		internal void method_36(bool bool_25)
		{
			this.method_23(bool_25);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0008D084 File Offset: 0x0008B284
		private static string smethod_57()
		{
			if (GClass155.string_1 == null || GClass155.string_1 == string.Empty || GClass155.string_1.Length != SystemInfo.deviceUniqueIdentifier.Length)
			{
				Random random = new Random(Environment.TickCount);
				byte[] array = new byte[SystemInfo.deviceUniqueIdentifier.Length / 2];
				random.NextBytes(array);
				GClass155.smethod_58(string.Join(string.Empty, array.Select(new Func<byte, string>(GClass155.Class152.class152_0.method_0))));
			}
			return GClass155.string_1;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0008D128 File Offset: 0x0008B328
		private static void smethod_58(string string_2)
		{
			GClass155.smethod_66(string_2);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0008D13C File Offset: 0x0008B33C
		private static void smethod_59(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_17)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = false;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0008D188 File Offset: 0x0008B388
		private static bool smethod_60(VRCAVProVideoPlayer vrcavproVideoPlayer_0)
		{
			string url = vrcavproVideoPlayer_0.VideoURL.url;
			if (string.IsNullOrEmpty(url))
			{
				GClass70.smethod_38("Play2()", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38("Play" + "2" + ": " + url, GClass70.Enum1.const_0);
				if (GClass155.smethod_50(url))
				{
					return false;
				}
				if (!GClass155.smethod_56(url))
				{
					return !GClass155.bool_6;
				}
			}
			return true;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		private static void smethod_61(IntPtr intptr_0, IntPtr intptr_1, Vector3 vector3_0, Quaternion quaternion_0, int int_0, IntPtr intptr_2)
		{
			GClass155.smethod_68(intptr_0, intptr_1, vector3_0, quaternion_0, int_0, intptr_2);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0008D218 File Offset: 0x0008B418
		private static bool smethod_62(string string_2, Dictionary<string, Object> dictionary_0, Action<string, ApiModelContainer<APIUser>> action_0, Action<ApiModelContainer<APIUser>> action_1)
		{
			GClass70.smethod_38("ThirdPartyLogin" + "(" + string_2 + ", ", GClass70.Enum1.const_0);
			List<string> list = GClass84.smethod_46<Dictionary<string, Object>>(dictionary_0, 0, 0, false, true, true, true, false);
			foreach (string string_3 in list)
			{
				GClass70.smethod_24(string_3, GClass70.Enum1.const_0);
			}
			return true;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0008D294 File Offset: 0x0008B494
		private static void smethod_63(VRCPlayerApi vrcplayerApi_0, ref bool bool_25)
		{
			GClass155.smethod_91(vrcplayerApi_0, ref bool_25);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0008D40C File Offset: 0x0008B60C
		private static void smethod_64(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_12(apiuser_0, ref bool_25);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0008D420 File Offset: 0x0008B620
		private static IntPtr smethod_65()
		{
			return GClass155.object_0.Pointer;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0008D438 File Offset: 0x0008B638
		private static void smethod_66(string string_2)
		{
			GClass155.smethod_40(string_2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0008D44C File Offset: 0x0008B64C
		private static bool smethod_67(InkStroke inkStroke_0)
		{
			GClass70.smethod_38("DrawingManager_SendStrokeRPC", GClass70.Enum1.const_0);
			return !GClass155.bool_24;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0008D46C File Offset: 0x0008B66C
		private static void smethod_68(IntPtr intptr_0, IntPtr intptr_1, Vector3 vector3_0, Quaternion quaternion_0, int int_0, IntPtr intptr_2)
		{
			try
			{
				GClass155.delegate36_0(intptr_0, intptr_1, vector3_0, quaternion_0, int_0, intptr_2);
				Player player = new Player(intptr_2);
				string a = IL2CPP.Il2CppStringToManaged(intptr_1);
				if (!(a != "Portals/PortalInternalDynamic"))
				{
					APIUser apiuser = player.Method_Internal_get_APIUser_0();
					if (apiuser != null)
					{
						if (GClass155.bool_3)
						{
							GClass70.smethod_117(GClass84.smethod_1571(apiuser, true), string.Concat(new string[]
							{
								apiuser.displayName,
								" ",
								"Dropped",
								" ",
								"A",
								" ",
								"Portal"
							}), GClass70.Enum1.const_0);
						}
						APIUser apiuser2 = GClass84.smethod_1372();
						if (apiuser2 == null || !(apiuser2.id == apiuser.id))
						{
							string text = string.Empty;
							VRCPlayer vrcplayer = GClass84.smethod_367(player);
							VRCPlayer vrcplayer2 = GClass84.smethod_460();
							if (GClass155.bool_4 && vrcplayer2 != null && GClass84.smethod_743(vector3_0 - vrcplayer2.transform.position) < 2f)
							{
								text = string.Format("{0} ({1}) Dropped Portal Too Close ({2} Meters). Destroying", apiuser.displayName, apiuser.id, GClass84.smethod_743(vector3_0 - vrcplayer2.transform.position)) + "...";
							}
							else if (GClass155.bool_5 && vrcplayer != null && GClass84.smethod_743(vector3_0 - vrcplayer.transform.position) > 2.5f)
							{
								text = string.Format("{0} ({1}) Dropped Portal Too Far From Themselves ({2} Meters). Destroying", apiuser.displayName, apiuser.id, GClass84.smethod_743(vector3_0 - vrcplayer.transform.position)) + "...";
							}
							if (text != string.Empty)
							{
								ObjectInstantiator objectInstantiator = new ObjectInstantiator(intptr_0);
								Dictionary<int, ObjectInstantiator.ObjectInfo> field_Private_Dictionary_2_Int32_ObjectInfo_ = objectInstantiator.field_Private_Dictionary_2_Int32_ObjectInfo_0;
								if (field_Private_Dictionary_2_Int32_ObjectInfo_.ContainsKey(int_0))
								{
									ObjectInstantiator.ObjectInfo objectInfo = field_Private_Dictionary_2_Int32_ObjectInfo_[int_0];
									GClass70.smethod_38(text, GClass70.Enum1.const_0);
									MelonCoroutines.Start(GClass155.smethod_54(objectInfo.field_Public_GameObject_0));
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				string str = "Exception In InstantiateObjectPatch";
				string str2 = ": ";
				Exception ex2 = ex;
				GClass70.smethod_36(str + str2 + ((ex2 != null) ? ex2.ToString() : null), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0008D6CC File Offset: 0x0008B8CC
		private static string smethod_69<T>(string string_2) where T : HashAlgorithm
		{
			byte[] array = GClass155.smethod_86<T>(Encoding.UTF8.GetBytes(string_2));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0008D724 File Offset: 0x0008B924
		private static void smethod_70()
		{
			GClass155.smethod_10();
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0008D738 File Offset: 0x0008B938
		private static void smethod_71(IntPtr intptr_0, IntPtr intptr_1, Vector3 vector3_0, Quaternion quaternion_0, int int_0, IntPtr intptr_2)
		{
			GClass155.smethod_61(intptr_0, intptr_1, vector3_0, quaternion_0, int_0, intptr_2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0008D758 File Offset: 0x0008B958
		internal void method_37(bool bool_25)
		{
			this.method_47(bool_25);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0008D76C File Offset: 0x0008B96C
		internal void method_38(bool bool_25)
		{
			GClass186.gclass186_0.bool_0 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_9 = bool_25;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0008D790 File Offset: 0x0008B990
		private static void smethod_72(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_16)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0008D7DC File Offset: 0x0008B9DC
		internal void method_39(bool bool_25)
		{
			this.method_11(bool_25);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0008D7F0 File Offset: 0x0008B9F0
		private static bool smethod_73(PortalInternal portalInternal_0, string string_2, string string_3, int int_0, Player player_0)
		{
			bool result;
			if (!portalInternal_0)
			{
				result = false;
			}
			else
			{
				string text;
				if (player_0)
				{
					text = GClass84.smethod_643(player_0, "");
				}
				else
				{
					text = "Null!";
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"PortalInternal_ConfigurePortal",
					": ",
					GClass84.smethod_118(portalInternal_0),
					", ",
					string_2,
					", ",
					string_3,
					", ",
					int_0.ToString(),
					", ",
					text
				}), GClass70.Enum1.const_0);
				result = true;
			}
			return result;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0008D894 File Offset: 0x0008BA94
		internal static void smethod_74(string string_2, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, bool bool_25, float float_1, API.CredentialsBundle credentialsBundle_0)
		{
			GClass155.smethod_22(string_2, apiContainer_0, ireadOnlyDictionary_0, bool_25, float_1, credentialsBundle_0);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0008D8B4 File Offset: 0x0008BAB4
		internal void method_40(bool bool_25)
		{
			GClass186.gclass186_0.bool_7 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_15 = bool_25;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0008D8D8 File Offset: 0x0008BAD8
		private static void smethod_75(APIUser apiuser_0, ref APIUser.DeveloperType developerType_0)
		{
			GClass155.smethod_2(apiuser_0, ref developerType_0);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0008D8EC File Offset: 0x0008BAEC
		internal void method_41(bool bool_25)
		{
			this.method_12(bool_25);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0008D900 File Offset: 0x0008BB00
		private static void smethod_76(VRCPlayerApi vrcplayerApi_0, ref bool bool_25)
		{
			GClass155.smethod_63(vrcplayerApi_0, ref bool_25);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008D914 File Offset: 0x0008BB14
		internal void method_42(bool bool_25)
		{
			GClass186.gclass186_0.bool_4 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_12 = bool_25;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0008D938 File Offset: 0x0008BB38
		private static bool smethod_77()
		{
			return !GClass155.bool_7;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_78(string string_2, HTTPMethods httpmethods_0, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, bool bool_25 = true, bool bool_26 = false, float float_1 = 0f, int int_0 = 0, API.CredentialsBundle credentialsBundle_0 = null, HTTPFormBase httpformBase_0 = null)
		{
			return true;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0008D950 File Offset: 0x0008BB50
		private static bool smethod_79(string string_2)
		{
			try
			{
				if (!string_2.Contains("vrchat.cloud"))
				{
					return !GClass155.bool_0;
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0008D994 File Offset: 0x0008BB94
		private static void smethod_80()
		{
			GClass84.gclass93_0.method_198();
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0008D9AC File Offset: 0x0008BBAC
		private static void smethod_81(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_72(apiuser_0, ref bool_25);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0008D9C0 File Offset: 0x0008BBC0
		internal void method_43(bool bool_25)
		{
			GClass186.gclass186_0.bool_8 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_16 = bool_25;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
		private static void smethod_82(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_90(apiuser_0, ref bool_25);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0008D9F8 File Offset: 0x0008BBF8
		internal void method_44(bool bool_25)
		{
			GClass186.gclass186_0.bool_13 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_21 = bool_25;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0008DA1C File Offset: 0x0008BC1C
		internal void method_45(bool bool_25)
		{
			GClass186.gclass186_0.bool_2 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_7 = bool_25;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0008DA40 File Offset: 0x0008BC40
		internal void method_46(bool bool_25)
		{
			this.method_25(bool_25);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0008DA54 File Offset: 0x0008BC54
		private static void smethod_83(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_13)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0008DAA0 File Offset: 0x0008BCA0
		private static void smethod_84()
		{
			GClass155.smethod_1();
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0008DAB4 File Offset: 0x0008BCB4
		private static void smethod_85(APIUser apiuser_0, ref APIUser.DeveloperType developerType_0)
		{
			try
			{
				APIUser apiuser = GClass84.smethod_1372();
				if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
				{
					developerType_0 = 3;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0008DAFC File Offset: 0x0008BCFC
		internal void method_47(bool bool_25)
		{
			this.method_16(bool_25);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0008DB10 File Offset: 0x0008BD10
		private static byte[] smethod_86<T>(byte[] byte_0) where T : HashAlgorithm
		{
			T t = typeof(T).GetMethod("Create", new Type[0]).Invoke(null, null) as T;
			byte[] result;
			try
			{
				result = t.ComputeHash(byte_0);
			}
			finally
			{
				if (t != null)
				{
					((IDisposable)((object)t)).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0008DB88 File Offset: 0x0008BD88
		private static void smethod_87(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_59(apiuser_0, ref bool_25);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0008DB9C File Offset: 0x0008BD9C
		internal void method_48(bool bool_25)
		{
			GClass186.gclass186_0.bool_3 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_11 = bool_25;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0008DBC0 File Offset: 0x0008BDC0
		internal static void smethod_88(bool bool_25)
		{
			GClass186.gclass186_0.bool_15 = bool_25;
			GClass186.smethod_0();
			GClass155.bool_2 = bool_25;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0008DBE4 File Offset: 0x0008BDE4
		internal static void smethod_89(string string_2, ApiContainer apiContainer_0, IReadOnlyDictionary<string, Json.Token> ireadOnlyDictionary_0, bool bool_25 = false, float float_1 = 0f, API.CredentialsBundle credentialsBundle_0 = null)
		{
			GClass155.smethod_74(string_2, apiContainer_0, ireadOnlyDictionary_0, bool_25, float_1, credentialsBundle_0);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0008DC04 File Offset: 0x0008BE04
		private static void smethod_90(APIUser apiuser_0, ref bool bool_25)
		{
			GClass155.smethod_35(apiuser_0, ref bool_25);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0008DC18 File Offset: 0x0008BE18
		internal void method_49(bool bool_25)
		{
			this.method_15(bool_25);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0008DC2C File Offset: 0x0008BE2C
		private static void smethod_91(VRCPlayerApi vrcplayerApi_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_21)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_538(vrcplayerApi_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0008DC78 File Offset: 0x0008BE78
		private static void smethod_92()
		{
			GClass155.smethod_21();
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0008DC8C File Offset: 0x0008BE8C
		internal void method_50(bool bool_25)
		{
			this.method_30(bool_25);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0008DCA0 File Offset: 0x0008BEA0
		private static void smethod_93(APIUser apiuser_0, ref bool bool_25)
		{
			try
			{
				if (GClass155.bool_12)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && GClass84.smethod_653(apiuser) == GClass84.smethod_653(apiuser_0))
					{
						bool_25 = true;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0008DCEC File Offset: 0x0008BEEC
		internal unsafe void method_51()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			GClass186.smethod_4();
			GClass155.bool_9 = GClass186.gclass186_0.bool_0;
			GClass155.bool_10 = GClass186.gclass186_0.bool_1;
			GClass155.string_1 = GClass186.gclass186_0.string_0;
			GClass155.bool_7 = GClass186.gclass186_0.bool_2;
			GClass155.bool_11 = GClass186.gclass186_0.bool_3;
			GClass155.bool_12 = GClass186.gclass186_0.bool_4;
			GClass155.bool_13 = GClass186.gclass186_0.bool_5;
			GClass155.bool_14 = GClass186.gclass186_0.bool_6;
			GClass155.bool_15 = GClass186.gclass186_0.bool_7;
			GClass155.bool_16 = GClass186.gclass186_0.bool_8;
			GClass155.bool_17 = GClass186.gclass186_0.bool_9;
			GClass155.bool_18 = GClass186.gclass186_0.bool_10;
			GClass155.bool_19 = GClass186.gclass186_0.bool_11;
			GClass155.bool_20 = GClass186.gclass186_0.bool_12;
			GClass155.bool_21 = GClass186.gclass186_0.bool_13;
			GClass155.bool_22 = GClass186.gclass186_0.bool_14;
			GClass155.bool_2 = GClass186.gclass186_0.bool_15;
			try
			{
				GClass84.smethod_1302("Custom_Extras", typeof(VRC_SyncVideoPlayer), "AddURL", GClass155.smethod_20("VRC_SyncVideoPlayer_AddURL"), null, null);
				GClass84.smethod_1302("Custom_Extras", typeof(VRC_SyncVideoPlayer), "Play", GClass155.smethod_20("VRC_SyncVideoPlayer_Play"), null, null);
				GClass84.smethod_1302("Custom_Extras", typeof(VRCAVProVideoPlayer), "Play", GClass155.smethod_20("VRCAVProVideoPlayer_Play"), null, null);
				GClass84.smethod_1302("Custom_Extras", typeof(MediaPlayer), "Play", GClass155.smethod_20("MediaPlayer_Play"), null, null);
				GClass84.smethod_405(typeof(Tools), "Platform", null, GClass155.smethod_20("PlatformSpoof"), null);
				GClass84.smethod_405(typeof(APIUser), "canSetStatusOffline", null, GClass155.smethod_20("APIUser_canSetStatusOffline"), null);
				GClass84.smethod_405(typeof(APIUser), "canSeeAllUsersStatus", null, GClass155.smethod_20("APIUser_canSeeAllUsersStatus"), null);
				GClass84.smethod_405(typeof(APIUser), "hasModerationPowers", null, GClass155.smethod_20("APIUser_hasModerationPowers"), null);
				GClass84.smethod_405(typeof(APIUser), "hasScriptingAccess", null, GClass155.smethod_20("APIUser_hasScriptingAccess"), null);
				GClass84.smethod_405(typeof(APIUser), "hasNoPowers", null, GClass155.smethod_20("APIUser_hasNoPowers"), null);
				GClass84.smethod_405(typeof(APIUser), "hasSuperPowers", null, GClass155.smethod_20("APIUser_hasSuperPowers"), null);
				GClass84.smethod_405(typeof(APIUser), "hasVIPAccess", null, GClass155.smethod_20("APIUser_hasVIPAccess"), null);
				GClass84.smethod_405(typeof(APIUser), "isEarlyAdopter", null, GClass155.smethod_20("APIUser_isEarlyAdopter"), null);
				GClass84.smethod_405(typeof(APIUser), "isSupporter", null, GClass155.smethod_20("APIUser_isSupporter"), null);
				GClass84.smethod_405(typeof(VRCPlayerApi), "isMaster", null, GClass155.smethod_20("VRCPlayerApi_isMaster"), null);
				GClass84.smethod_799(typeof(PortalInternal), "ConfigurePortal", GClass155.smethod_20("PortalInternal_ConfigurePortal"), null, null);
				GClass84.smethod_799(typeof(DrawingManager), "SendStrokeRPC", GClass155.smethod_20("DrawingManager_SendStrokeRPC"), null, null);
				GClass84.smethod_799(typeof(DrawingManager), "SendStrokeRPC", GClass155.smethod_20("DrawingManager_SendStrokeRPC"), null, null);
				GClass84.smethod_799(typeof(API), "SendGetRequest", GClass155.smethod_20("API_SendGetRequestPatch"), GClass155.smethod_20("API_SendGetRequestPatch_Post"), null);
				GClass84.smethod_799(typeof(API), "SendPutRequest", GClass155.smethod_20("API_SendPutRequestPatch"), GClass155.smethod_20("API_SendPutRequestPatch_Post"), null);
				GClass84.smethod_799(typeof(API), "SendRequest", GClass155.smethod_20("API_SendRequestPatch"), GClass155.smethod_20("API_SendRequestPatch_Post"), null);
				GClass84.smethod_208(typeof(VRCAvatarManager).GetMethod("Method_Private_Boolean_ApiAvatar_GameObject_0"), GClass155.smethod_20("OnAvatarInitializedPatch"), null, null);
				try
				{
					GClass84.smethod_799(typeof(UIManagerImpl), "Method_Public_Void_Boolean_0", null, GClass155.smethod_20("OnQuickMenuClose"), null);
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
				try
				{
					GClass84.smethod_799(typeof(UIManagerImpl), "Method_Private_Void_Boolean_2", null, GClass155.smethod_20("OnQuickMenuOpen"), null);
				}
				catch (Exception ex2)
				{
					GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
				}
				GClass84.smethod_799(typeof(NetworkManager), "OnJoinedRoom", GClass155.smethod_20("OnJoinedRoom"), null, null);
				GClass84.smethod_799(typeof(NetworkManager), "OnLeftRoom", GClass155.smethod_20("OnLeftRoom"), null, null);
				if (GClass155.bool_10)
				{
					try
					{
						string text = "UnityEngine.SystemInfo::GetDeviceUniqueIdentifier";
						IntPtr value = IL2CPP.il2cpp_resolve_icall(text);
						if (value != IntPtr.Zero)
						{
							MethodInfo method = typeof(GClass155).GetMethod("GetDeviceIdPatch", BindingFlags.Static | BindingFlags.NonPublic);
							if (method != null)
							{
								GClass155.object_0 = new Object(IL2CPP.ManagedStringToIl2Cpp(GClass155.smethod_55()));
								MelonUtils.NativeHookAttach((IntPtr)((void*)(&value)), method.MethodHandle.GetFunctionPointer());
							}
						}
					}
					catch (Exception ex3)
					{
						GClass70.smethod_36(ex3.ToString(), GClass70.Enum1.const_0);
					}
				}
				try
				{
					foreach (MethodInfo methodBase_ in typeof(PortalInternal).GetMethods().ToList<MethodInfo>().FindAll(new Predicate<MethodInfo>(GClass155.Class152.class152_0.method_1)))
					{
						GClass84.smethod_1123("Custom_Extras", methodBase_, GClass155.smethod_20("EnterConfirm"), null, null);
					}
				}
				catch (Exception ex4)
				{
					GClass70.smethod_36(ex4.ToString(), GClass70.Enum1.const_0);
				}
				try
				{
					IntPtr ptr = *(IntPtr*)((void*)((IntPtr)UnhollowerUtils.GetIl2CppMethodInfoPointerFieldForGeneratedMethod(typeof(ObjectInstantiator).GetMethod("_InstantiateObject")).GetValue(null)));
					MethodInfo method2 = typeof(GClass155).GetMethod("InstantiateObjectPatch", BindingFlags.Static | BindingFlags.NonPublic);
					if (method2 != null)
					{
						MelonUtils.NativeHookAttach((IntPtr)((void*)(&ptr)), method2.MethodHandle.GetFunctionPointer());
					}
					GClass155.delegate36_0 = Marshal.GetDelegateForFunctionPointer<GClass155.Delegate36>(ptr);
				}
				catch (Exception ex5)
				{
					GClass70.smethod_36(ex5.ToString(), GClass70.Enum1.const_0);
				}
			}
			catch (Exception ex6)
			{
				GClass70.smethod_36(ex6.ToString(), GClass70.Enum1.const_0);
			}
			finally
			{
				GClass70.smethod_38("All Patches have been applied successfully.", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0400103B RID: 4155
		internal static bool bool_0 = false;

		// Token: 0x0400103C RID: 4156
		internal static bool bool_1 = false;

		// Token: 0x0400103D RID: 4157
		internal static bool bool_2 = true;

		// Token: 0x0400103E RID: 4158
		internal static bool bool_3 = true;

		// Token: 0x0400103F RID: 4159
		internal static bool bool_4 = true;

		// Token: 0x04001040 RID: 4160
		internal static bool bool_5 = true;

		// Token: 0x04001041 RID: 4161
		internal static bool bool_6 = false;

		// Token: 0x04001042 RID: 4162
		internal static bool bool_7 = false;

		// Token: 0x04001043 RID: 4163
		private static List<string> list_0 = new List<string>();

		// Token: 0x04001044 RID: 4164
		internal static bool bool_8 = false;

		// Token: 0x04001045 RID: 4165
		private static GClass155.Delegate36 delegate36_0;

		// Token: 0x04001046 RID: 4166
		internal static bool bool_9 = false;

		// Token: 0x04001047 RID: 4167
		internal static bool bool_10 = false;

		// Token: 0x04001048 RID: 4168
		internal static string string_1 = "";

		// Token: 0x04001049 RID: 4169
		private static Object object_0;

		// Token: 0x0400104A RID: 4170
		internal static bool bool_11 = true;

		// Token: 0x0400104B RID: 4171
		internal static bool bool_12 = true;

		// Token: 0x0400104C RID: 4172
		internal static bool bool_13 = true;

		// Token: 0x0400104D RID: 4173
		internal static bool bool_14 = false;

		// Token: 0x0400104E RID: 4174
		internal static bool bool_15 = false;

		// Token: 0x0400104F RID: 4175
		internal static bool bool_16 = false;

		// Token: 0x04001050 RID: 4176
		internal static bool bool_17 = false;

		// Token: 0x04001051 RID: 4177
		internal static bool bool_18 = false;

		// Token: 0x04001052 RID: 4178
		internal static bool bool_19 = false;

		// Token: 0x04001053 RID: 4179
		internal static bool bool_20 = false;

		// Token: 0x04001054 RID: 4180
		internal static bool bool_21 = false;

		// Token: 0x04001055 RID: 4181
		internal static bool bool_22 = true;

		// Token: 0x04001056 RID: 4182
		private static bool bool_23 = false;

		// Token: 0x04001057 RID: 4183
		internal static bool bool_24 = false;

		// Token: 0x04001058 RID: 4184
		internal static List<Class132> list_1 = new List<Class132>();

		// Token: 0x04001059 RID: 4185
		internal static List<Class131> list_2 = new List<Class131>();

		// Token: 0x0400105A RID: 4186
		internal static List<Class140> list_3 = new List<Class140>();

		// Token: 0x0400105B RID: 4187
		internal static List<Class134> list_4 = new List<Class134>();

		// Token: 0x0400105C RID: 4188
		internal static List<Class136> list_5 = new List<Class136>();

		// Token: 0x0400105D RID: 4189
		internal static List<Class143> list_6 = new List<Class143>();

		// Token: 0x0400105E RID: 4190
		internal static List<Class129> list_7 = new List<Class129>();

		// Token: 0x0400105F RID: 4191
		internal static List<Class137> list_8 = new List<Class137>();

		// Token: 0x04001060 RID: 4192
		internal static List<Class133> list_9 = new List<Class133>();

		// Token: 0x04001061 RID: 4193
		internal static List<Class142> list_10 = new List<Class142>();

		// Token: 0x04001062 RID: 4194
		internal static List<Class130> list_11 = new List<Class130>();

		// Token: 0x04001063 RID: 4195
		internal static List<Class139> list_12 = new List<Class139>();

		// Token: 0x04001064 RID: 4196
		internal static Class135 class135_0 = new Class135();

		// Token: 0x04001065 RID: 4197
		internal static Class141 class141_0 = new Class141();

		// Token: 0x04001066 RID: 4198
		internal static List<string> list_13 = new List<string>();

		// Token: 0x04001067 RID: 4199
		internal static List<Class138> list_14 = new List<Class138>();

		// Token: 0x04001068 RID: 4200
		private static List<GClass84.GStruct134> list_15 = new List<GClass84.GStruct134>();

		// Token: 0x04001069 RID: 4201
		private static float float_0;

		// Token: 0x02000258 RID: 600
		internal enum Enum9
		{
			// Token: 0x0400106B RID: 4203
			const_0,
			// Token: 0x0400106C RID: 4204
			const_1,
			// Token: 0x0400106D RID: 4205
			const_2
		}

		// Token: 0x02000259 RID: 601
		// (Invoke) Token: 0x06001C39 RID: 7225
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate36(IntPtr intptr_0, IntPtr intptr_1, Vector3 vector3_0, Quaternion quaternion_0, int int_0, IntPtr intptr_2);

		// Token: 0x0200025A RID: 602
		[CompilerGenerated]
		[Serializable]
		private sealed class Class152
		{
			// Token: 0x06001C3C RID: 7228 RVA: 0x0008E454 File Offset: 0x0008C654
			internal string method_0(byte byte_0)
			{
				return byte_0.ToString("x2");
			}

			// Token: 0x06001C3E RID: 7230 RVA: 0x0008E488 File Offset: 0x0008C688
			internal bool method_1(MethodInfo methodInfo_0)
			{
				if (GClass84.smethod_1611(methodInfo_0.Name, "Method_Public_Void_") != -1)
				{
					try
					{
						if (XrefScanner.XrefScan(methodInfo_0).Any(new Func<XrefInstance, bool>(GClass155.Class152.class152_0.method_3)))
						{
							return true;
						}
					}
					catch
					{
						return false;
					}
				}
				return false;
			}

			// Token: 0x06001C40 RID: 7232 RVA: 0x0008E4F8 File Offset: 0x0008C6F8
			internal void method_2()
			{
				GClass84.smethod_762();
			}

			// Token: 0x06001C41 RID: 7233 RVA: 0x0008E50C File Offset: 0x0008C70C
			internal bool method_3(XrefInstance xrefInstance_0)
			{
				return xrefInstance_0.Type == null && xrefInstance_0.ReadAsObject() != null && xrefInstance_0.ReadAsObject().ToString() == " was at capacity, cannot enter.";
			}

			// Token: 0x0400106E RID: 4206
			public static readonly GClass155.Class152 class152_0 = new GClass155.Class152();

			// Token: 0x0400106F RID: 4207
			public static Func<XrefInstance, bool> func_0;

			// Token: 0x04001070 RID: 4208
			public static Predicate<MethodInfo> predicate_0;

			// Token: 0x04001071 RID: 4209
			public static Func<byte, string> func_1;

			// Token: 0x04001072 RID: 4210
			public static Action action_0;
		}

		// Token: 0x0200025C RID: 604
		[CompilerGenerated]
		private sealed class Class154
		{
			// Token: 0x06001C48 RID: 7240 RVA: 0x0008E5EC File Offset: 0x0008C7EC
			internal void method_0()
			{
				GClass155.bool_8 = true;
				this.methodBase_0.Invoke(this.portalInternal_0, null);
			}

			// Token: 0x04001076 RID: 4214
			public MethodBase methodBase_0;

			// Token: 0x04001077 RID: 4215
			public PortalInternal portalInternal_0;
		}
	}
}
