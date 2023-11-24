using System;
using System.Collections.Generic;
using ns245;

namespace ns258
{
	// Token: 0x02000343 RID: 835
	internal class Class141 : Class128
	{
		// Token: 0x060046FC RID: 18172 RVA: 0x0010A158 File Offset: 0x00108358
		internal bool method_0(string string_40, object object_0)
		{
			if (string_40 == "VoiceEnableDegradation")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_40 == "VoiceEnableReceiverLimiting")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_1 = (bool)object_0;
					return true;
				}
				this.bool_1 = false;
			}
			else if (string_40 == "accountLimitChurnColliderFeed")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_2 = (bool)object_0;
					return true;
				}
				this.bool_2 = false;
			}
			else if (string_40 == "announcements")
			{
				List<object> list = object_0 as List<object>;
				if (list != null)
				{
					this.list_0 = new List<Class141.Class195>();
					foreach (object object_ in list)
					{
						Class141.Class195 item;
						if (!Class141.Class195.smethod_0(object_, out item))
						{
							return false;
						}
						this.list_0.Add(item);
					}
					return true;
				}
				this.list_0 = null;
			}
			else if (string_40 == "address")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_40 == "apiHeadpat")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_40 == "apiKey")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_40 == "apiNameDefault")
			{
				if (Class141.Class193.smethod_0(object_0, out this.class193_0))
				{
					return true;
				}
				this.class193_0 = null;
			}
			else if (string_40 == "appName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_40 == "avatarDisableAsset")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_1 = (List<object>)object_0;
					return true;
				}
				this.list_1 = new List<object>();
			}
			else if (string_40 == "buildVersionTag")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_40 == "chumpMobileTrustedGender")
			{
				if (Class141.Class194.smethod_0(object_0, out this.class194_0))
				{
					return true;
				}
				this.class194_0 = null;
			}
			else if (string_40 == "clientApiKey")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_40 == "clientBPSCeiling")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_1 = (double)object_0;
					return true;
				}
				this.double_1 = 0.0;
			}
			else if (string_40 == "clientDisconnectTimeout")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_2 = (double)object_0;
					return true;
				}
				this.double_2 = 0.0;
			}
			else if (string_40 == "clientReservedPlayerBPS")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_3 = (double)object_0;
					return true;
				}
				this.double_3 = 0.0;
			}
			else if (string_40 == "clientSentCountAllowance")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_4 = (double)object_0;
					return true;
				}
				this.double_4 = 0.0;
			}
			else if (string_40 == "contactEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_40 == "copyrightEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_40 == "currentTOSVersion")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_5 = (double)object_0;
					return true;
				}
				this.double_5 = 0.0;
			}
			else if (string_40 == "defaultAvatar")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_40 == "delayModeration")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_3 = (bool)object_0;
					return true;
				}
				this.bool_3 = false;
			}
			else if (string_40 == "deploymentGroup")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_40 == "devAppVersionStandalone")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_40 == "devDownloadLinkWindows")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_40 == "devSdkUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			else if (string_40 == "devSdkVersion")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_12 = (string)object_0;
					return true;
				}
				this.string_12 = string.Empty;
			}
			else if (string_40 == "devServerVersionStandalone")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_13 = (string)object_0;
					return true;
				}
				this.string_13 = string.Empty;
			}
			else if (string_40 == "dis-countdown")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_14 = (string)object_0;
					return true;
				}
				this.string_14 = string.Empty;
			}
			else if (string_40 == "disableAvatarCopying")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_4 = (bool)object_0;
					return true;
				}
				this.bool_4 = false;
			}
			else if (string_40 == "disableAvatarGating")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_5 = (bool)object_0;
					return true;
				}
				this.bool_5 = false;
			}
			else if (string_40 == "disableCommunityLabs")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_6 = (bool)object_0;
					return true;
				}
				this.bool_6 = false;
			}
			else if (string_40 == "disableCommunityLabsPromotion")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_7 = (bool)object_0;
					return true;
				}
				this.bool_7 = false;
			}
			else if (string_40 == "disableEmail")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_8 = (bool)object_0;
					return true;
				}
				this.bool_8 = false;
			}
			else if (string_40 == "disableEventStream")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_9 = (bool)object_0;
					return true;
				}
				this.bool_9 = false;
			}
			else if (string_40 == "disableFeedbackGating")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_10 = (bool)object_0;
					return true;
				}
				this.bool_10 = false;
			}
			else if (string_40 == "disableHello")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_11 = (bool)object_0;
					return true;
				}
				this.bool_11 = false;
			}
			else if (string_40 == "disableRegistration")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_12 = (bool)object_0;
					return true;
				}
				this.bool_12 = false;
			}
			else if (string_40 == "disableSteamNetworking")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_13 = (bool)object_0;
					return true;
				}
				this.bool_13 = false;
			}
			else if (string_40 == "disableTwoFactorAuth")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_14 = (bool)object_0;
					return true;
				}
				this.bool_14 = false;
			}
			else if (string_40 == "disableUdon")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_15 = (bool)object_0;
					return true;
				}
				this.bool_15 = false;
			}
			else if (string_40 == "disableUpgradeAccount")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_16 = (bool)object_0;
					return true;
				}
				this.bool_16 = false;
			}
			else if (string_40 == "downloadLinkWindows")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_15 = (string)object_0;
					return true;
				}
				this.string_15 = string.Empty;
			}
			else if (string_40 == "downloadUrls")
			{
				if (Class141.Class196.smethod_0(object_0, out this.class196_0))
				{
					return true;
				}
				this.class196_0 = null;
			}
			else if (string_40 == "dynamicWorldRows")
			{
				List<object> list2 = object_0 as List<object>;
				if (list2 != null)
				{
					this.list_2 = new List<Class141.Class197>();
					foreach (object object_2 in list2)
					{
						Class141.Class197 item2;
						if (!Class141.Class197.smethod_0(object_2, out item2))
						{
							return false;
						}
						this.list_2.Add(item2);
					}
					return true;
				}
				this.list_2 = null;
			}
			else if (string_40 == "errorOnly")
			{
				if (Class141.Class199.smethod_0(object_0, out this.class199_0))
				{
					return true;
				}
				this.class199_0 = null;
			}
			else if (string_40 == "events")
			{
				if (Class141.Class200.smethod_0(object_0, out this.class200_0))
				{
					return true;
				}
				this.class200_0 = null;
			}
			else if (string_40 == "favoriteShaderAvatarGender")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_3 = (List<object>)object_0;
					return true;
				}
				this.list_3 = new List<object>();
			}
			else if (string_40 == "gearDemoRoomId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_16 = (string)object_0;
					return true;
				}
				this.string_16 = string.Empty;
			}
			else if (string_40 == "genderHeadpat")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_6 = (double)object_0;
					return true;
				}
				this.double_6 = 0.0;
			}
			else if (string_40 == "heightLoss")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_17 = (bool)object_0;
					return true;
				}
				this.bool_17 = false;
			}
			else if (string_40 == "hiddenThresholdVerificationTrend")
			{
				if (Class141.Class198.smethod_0(object_0, out this.class198_0))
				{
					return true;
				}
				this.class198_0 = null;
			}
			else if (string_40 == "headpatSdkOffsetPacketRate")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_8 = (double)object_0;
					return true;
				}
				this.double_8 = 0.0;
			}
			else if (string_40 == "generatorProfile")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_7 = (double)object_0;
					return true;
				}
				this.double_7 = 0.0;
			}
			else if (string_40 == "handlerSystemHash")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_18 = (bool)object_0;
					return true;
				}
				this.bool_18 = false;
			}
			else if (string_40 == "homeWorldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_17 = (string)object_0;
					return true;
				}
				this.string_17 = string.Empty;
			}
			else if (string_40 == "homepageRedirectTarget")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_18 = (string)object_0;
					return true;
				}
				this.string_18 = string.Empty;
			}
			else if (string_40 == "hubWorldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_19 = (string)object_0;
					return true;
				}
				this.string_19 = string.Empty;
			}
			else if (string_40 == "jobsEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_20 = (string)object_0;
					return true;
				}
				this.string_20 = string.Empty;
			}
			else if (string_40 == "labelMinimumVerificationFormatNetwork")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_19 = (bool)object_0;
					return true;
				}
				this.bool_19 = false;
			}
			else if (string_40 == "macChurnLocalizationApi")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_9 = (double)object_0;
					return true;
				}
				this.double_9 = 0.0;
			}
			else if (string_40 == "keywordListInstanceFilter")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_10 = (double)object_0;
					return true;
				}
				this.double_10 = 0.0;
			}
			else if (string_40 == "messageOfTheDay")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_21 = (string)object_0;
					return true;
				}
				this.string_21 = string.Empty;
			}
			else if (string_40 == "minimumLossEmbed")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_11 = (double)object_0;
					return true;
				}
				this.double_11 = 0.0;
			}
			else if (string_40 == "mobileSync")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_12 = (double)object_0;
					return true;
				}
				this.double_12 = 0.0;
			}
			else if (string_40 == "moderationEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_22 = (string)object_0;
					return true;
				}
				this.string_22 = string.Empty;
			}
			else if (string_40 == "moderationQueryPeriod")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_13 = (double)object_0;
					return true;
				}
				this.double_13 = 0.0;
			}
			else if (string_40 == "notAllowedToSelectAvatarInPrivateWorldMessage")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_23 = (string)object_0;
					return true;
				}
				this.string_23 = string.Empty;
			}
			else if (string_40 == "pipelineAlignmentObjectCheckRate")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_14 = (double)object_0;
					return true;
				}
				this.double_14 = 0.0;
			}
			else if (string_40 == "offsetOnlyOwnership")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_15 = (double)object_0;
					return true;
				}
				this.double_15 = 0.0;
			}
			else if (string_40 == "packageJumpLabelBonesDeployment")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_20 = (bool)object_0;
					return true;
				}
				this.bool_20 = false;
			}
			else if (string_40 == "plugin")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_24 = (string)object_0;
					return true;
				}
				this.string_24 = string.Empty;
			}
			else if (string_40 == "queryStack")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_16 = (double)object_0;
					return true;
				}
				this.double_16 = 0.0;
			}
			else if (string_40 == "plusTimestampFormatThroughputHidden")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_17 = (double)object_0;
					return true;
				}
				this.double_17 = 0.0;
			}
			else if (string_40 == "profileErrorMessageBytes")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_18 = (double)object_0;
					return true;
				}
				this.double_18 = 0.0;
			}
			else if (string_40 == "queryRateReferenceRegion")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_21 = (bool)object_0;
					return true;
				}
				this.bool_21 = false;
			}
			else if (string_40 == "releaseAppVersionStandalone")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_25 = (string)object_0;
					return true;
				}
				this.string_25 = string.Empty;
			}
			else if (string_40 == "releaseSdkUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_26 = (string)object_0;
					return true;
				}
				this.string_26 = string.Empty;
			}
			else if (string_40 == "releaseSdkVersion")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_27 = (string)object_0;
					return true;
				}
				this.string_27 = string.Empty;
			}
			else if (string_40 == "releaseServerVersionStandalone")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_28 = (string)object_0;
					return true;
				}
				this.string_28 = string.Empty;
			}
			else if (string_40 == "sdkDeveloperFaqUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_29 = (string)object_0;
					return true;
				}
				this.string_29 = string.Empty;
			}
			else if (string_40 == "sdkDiscordUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_30 = (string)object_0;
					return true;
				}
				this.string_30 = string.Empty;
			}
			else if (string_40 == "sdkNotAllowedToPublishMessage")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_31 = (string)object_0;
					return true;
				}
				this.string_31 = string.Empty;
			}
			else if (string_40 == "sdkUnityVersion")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_32 = (string)object_0;
					return true;
				}
				this.string_32 = string.Empty;
			}
			else if (string_40 == "serverName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_33 = (string)object_0;
					return true;
				}
				this.string_33 = string.Empty;
			}
			else if (string_40 == "shaderFeedSegment")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_4 = (List<object>)object_0;
					return true;
				}
				this.list_4 = new List<object>();
			}
			else if (string_40 == "supportEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_34 = (string)object_0;
					return true;
				}
				this.string_34 = string.Empty;
			}
			else if (string_40 == "timeOutWorldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_35 = (string)object_0;
					return true;
				}
				this.string_35 = string.Empty;
			}
			else if (string_40 == "trackingHandlerLabel")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_5 = (List<object>)object_0;
					return true;
				}
				this.list_5 = new List<object>();
			}
			else if (string_40 == "trendRoomHeightAccountLabel")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_19 = (double)object_0;
					return true;
				}
				this.double_19 = 0.0;
			}
			else if (string_40 == "timestampPluginInstanceClip")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_20 = (double)object_0;
					return true;
				}
				this.double_20 = 0.0;
			}
			else if (string_40 == "tutorialWorldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_36 = (string)object_0;
					return true;
				}
				this.string_36 = string.Empty;
			}
			else if (string_40 == "unitySdk")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_21 = (double)object_0;
					return true;
				}
				this.double_21 = 0.0;
			}
			else if (string_40 == "updateRateMsMaximum")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_22 = (double)object_0;
					return true;
				}
				this.double_22 = 0.0;
			}
			else if (string_40 == "updateRateMsMinimum")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_23 = (double)object_0;
					return true;
				}
				this.double_23 = 0.0;
			}
			else if (string_40 == "updateRateMsNormal")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_24 = (double)object_0;
					return true;
				}
				this.double_24 = 0.0;
			}
			else if (string_40 == "updateRateMsUdonManual")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_25 = (double)object_0;
					return true;
				}
				this.double_25 = 0.0;
			}
			else if (string_40 == "uploadAnalysisPercent")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_26 = (double)object_0;
					return true;
				}
				this.double_26 = 0.0;
			}
			else if (string_40 == "urlList")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_6 = (List<object>)object_0;
					return true;
				}
				this.list_6 = new List<object>();
			}
			else if (string_40 == "useReliableUdpForVoice")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_22 = (bool)object_0;
					return true;
				}
				this.bool_22 = false;
			}
			else if (string_40 == "userUpdatePeriod")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_27 = (double)object_0;
					return true;
				}
				this.double_27 = 0.0;
			}
			else if (string_40 == "userVerificationDelay")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_28 = (double)object_0;
					return true;
				}
				this.double_28 = 0.0;
			}
			else if (string_40 == "userVerificationRetry")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_29 = (double)object_0;
					return true;
				}
				this.double_29 = 0.0;
			}
			else if (string_40 == "userVerificationTimeout")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_30 = (double)object_0;
					return true;
				}
				this.double_30 = 0.0;
			}
			else if (string_40 == "vectorApiPrototype")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_31 = (double)object_0;
					return true;
				}
				this.double_31 = 0.0;
			}
			else if (string_40 == "viveWindowsUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_37 = (string)object_0;
					return true;
				}
				this.string_37 = string.Empty;
			}
			else if (string_40 == "voiceHeadpatFeedback")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_32 = (double)object_0;
					return true;
				}
				this.double_32 = 0.0;
			}
			else if (string_40 == "voiceWaffleWorld")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_23 = (bool)object_0;
					return true;
				}
				this.bool_23 = false;
			}
			else if (string_40 == "waffleMacVoiceLoss")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_7 = (List<object>)object_0;
					return true;
				}
				this.list_7 = new List<object>();
			}
			else if (string_40 == "whiteListedAssetUrls")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_8 = (List<object>)object_0;
					return true;
				}
				this.list_8 = new List<object>();
			}
			else if (string_40 == "worldEventsClip")
			{
				if (Class141.Class192.smethod_0(object_0, out this.class192_0))
				{
					return true;
				}
				this.class192_0 = null;
			}
			else if (string_40 == "worldUpdatePeriod")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_33 = (double)object_0;
					return true;
				}
				this.double_33 = 0.0;
			}
			else if (string_40 == "youtubedl-hash")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_38 = (string)object_0;
					return true;
				}
				this.string_38 = string.Empty;
			}
			else if (string_40 == "youtubedl-version")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_39 = (string)object_0;
					return true;
				}
				this.string_39 = string.Empty;
			}
			return false;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x0010C634 File Offset: 0x0010A834
		internal static bool smethod_0(object object_0, out Class141 class141_0)
		{
			bool result;
			if (object_0 == null)
			{
				class141_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class141_0 = new Class141();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class141_0.method_0(text, dictionary[text]))
							{
								return false;
							}
						}
						catch
						{
							return false;
						}
					}
					result = true;
				}
				else
				{
					class141_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0010C6DC File Offset: 0x0010A8DC
		internal override object vmethod_0()
		{
			return this.string_2;
		}

		// Token: 0x04001AF8 RID: 6904
		internal bool bool_0 = false;

		// Token: 0x04001AF9 RID: 6905
		internal bool bool_1 = false;

		// Token: 0x04001AFA RID: 6906
		internal bool bool_2 = false;

		// Token: 0x04001AFB RID: 6907
		internal List<Class141.Class195> list_0 = new List<Class141.Class195>();

		// Token: 0x04001AFC RID: 6908
		internal string string_0 = string.Empty;

		// Token: 0x04001AFD RID: 6909
		internal double double_0 = 0.0;

		// Token: 0x04001AFE RID: 6910
		internal string string_1 = string.Empty;

		// Token: 0x04001AFF RID: 6911
		public Class141.Class193 class193_0 = new Class141.Class193();

		// Token: 0x04001B00 RID: 6912
		internal string string_2 = string.Empty;

		// Token: 0x04001B01 RID: 6913
		internal List<object> list_1 = new List<object>();

		// Token: 0x04001B02 RID: 6914
		internal string string_3 = string.Empty;

		// Token: 0x04001B03 RID: 6915
		public Class141.Class194 class194_0 = new Class141.Class194();

		// Token: 0x04001B04 RID: 6916
		internal string string_4 = string.Empty;

		// Token: 0x04001B05 RID: 6917
		internal double double_1 = 0.0;

		// Token: 0x04001B06 RID: 6918
		internal double double_2 = 0.0;

		// Token: 0x04001B07 RID: 6919
		internal double double_3 = 0.0;

		// Token: 0x04001B08 RID: 6920
		internal double double_4 = 0.0;

		// Token: 0x04001B09 RID: 6921
		internal string string_5 = string.Empty;

		// Token: 0x04001B0A RID: 6922
		internal string string_6 = string.Empty;

		// Token: 0x04001B0B RID: 6923
		internal double double_5 = 0.0;

		// Token: 0x04001B0C RID: 6924
		internal string string_7 = string.Empty;

		// Token: 0x04001B0D RID: 6925
		internal bool bool_3 = false;

		// Token: 0x04001B0E RID: 6926
		internal string string_8 = string.Empty;

		// Token: 0x04001B0F RID: 6927
		internal string string_9 = string.Empty;

		// Token: 0x04001B10 RID: 6928
		internal string string_10 = string.Empty;

		// Token: 0x04001B11 RID: 6929
		internal string string_11 = string.Empty;

		// Token: 0x04001B12 RID: 6930
		internal string string_12 = string.Empty;

		// Token: 0x04001B13 RID: 6931
		internal string string_13 = string.Empty;

		// Token: 0x04001B14 RID: 6932
		internal string string_14 = string.Empty;

		// Token: 0x04001B15 RID: 6933
		internal bool bool_4 = false;

		// Token: 0x04001B16 RID: 6934
		internal bool bool_5 = false;

		// Token: 0x04001B17 RID: 6935
		internal bool bool_6 = false;

		// Token: 0x04001B18 RID: 6936
		internal bool bool_7 = false;

		// Token: 0x04001B19 RID: 6937
		internal bool bool_8 = false;

		// Token: 0x04001B1A RID: 6938
		internal bool bool_9 = false;

		// Token: 0x04001B1B RID: 6939
		internal bool bool_10 = false;

		// Token: 0x04001B1C RID: 6940
		internal bool bool_11 = false;

		// Token: 0x04001B1D RID: 6941
		internal bool bool_12 = false;

		// Token: 0x04001B1E RID: 6942
		internal bool bool_13 = false;

		// Token: 0x04001B1F RID: 6943
		internal bool bool_14 = false;

		// Token: 0x04001B20 RID: 6944
		internal bool bool_15 = false;

		// Token: 0x04001B21 RID: 6945
		internal bool bool_16 = false;

		// Token: 0x04001B22 RID: 6946
		internal string string_15 = string.Empty;

		// Token: 0x04001B23 RID: 6947
		public Class141.Class196 class196_0 = new Class141.Class196();

		// Token: 0x04001B24 RID: 6948
		internal List<Class141.Class197> list_2 = new List<Class141.Class197>();

		// Token: 0x04001B25 RID: 6949
		public Class141.Class199 class199_0 = new Class141.Class199();

		// Token: 0x04001B26 RID: 6950
		public Class141.Class200 class200_0 = new Class141.Class200();

		// Token: 0x04001B27 RID: 6951
		internal List<object> list_3 = new List<object>();

		// Token: 0x04001B28 RID: 6952
		internal string string_16 = string.Empty;

		// Token: 0x04001B29 RID: 6953
		internal double double_6 = 0.0;

		// Token: 0x04001B2A RID: 6954
		internal bool bool_17 = false;

		// Token: 0x04001B2B RID: 6955
		public Class141.Class198 class198_0 = new Class141.Class198();

		// Token: 0x04001B2C RID: 6956
		internal double double_7 = 0.0;

		// Token: 0x04001B2D RID: 6957
		internal double double_8 = 0.0;

		// Token: 0x04001B2E RID: 6958
		internal bool bool_18 = false;

		// Token: 0x04001B2F RID: 6959
		internal string string_17 = string.Empty;

		// Token: 0x04001B30 RID: 6960
		internal string string_18 = string.Empty;

		// Token: 0x04001B31 RID: 6961
		internal string string_19 = string.Empty;

		// Token: 0x04001B32 RID: 6962
		internal string string_20 = string.Empty;

		// Token: 0x04001B33 RID: 6963
		internal bool bool_19 = false;

		// Token: 0x04001B34 RID: 6964
		internal double double_9 = 0.0;

		// Token: 0x04001B35 RID: 6965
		internal double double_10 = 0.0;

		// Token: 0x04001B36 RID: 6966
		internal string string_21 = string.Empty;

		// Token: 0x04001B37 RID: 6967
		internal double double_11 = 0.0;

		// Token: 0x04001B38 RID: 6968
		internal double double_12 = 0.0;

		// Token: 0x04001B39 RID: 6969
		internal string string_22 = string.Empty;

		// Token: 0x04001B3A RID: 6970
		internal double double_13 = 0.0;

		// Token: 0x04001B3B RID: 6971
		internal string string_23 = string.Empty;

		// Token: 0x04001B3C RID: 6972
		internal double double_14 = 0.0;

		// Token: 0x04001B3D RID: 6973
		internal double double_15 = 0.0;

		// Token: 0x04001B3E RID: 6974
		internal bool bool_20 = false;

		// Token: 0x04001B3F RID: 6975
		internal string string_24 = string.Empty;

		// Token: 0x04001B40 RID: 6976
		internal double double_16 = 0.0;

		// Token: 0x04001B41 RID: 6977
		internal double double_17 = 0.0;

		// Token: 0x04001B42 RID: 6978
		internal double double_18 = 0.0;

		// Token: 0x04001B43 RID: 6979
		internal bool bool_21 = false;

		// Token: 0x04001B44 RID: 6980
		internal string string_25 = string.Empty;

		// Token: 0x04001B45 RID: 6981
		internal string string_26 = string.Empty;

		// Token: 0x04001B46 RID: 6982
		internal string string_27 = string.Empty;

		// Token: 0x04001B47 RID: 6983
		internal string string_28 = string.Empty;

		// Token: 0x04001B48 RID: 6984
		internal string string_29 = string.Empty;

		// Token: 0x04001B49 RID: 6985
		internal string string_30 = string.Empty;

		// Token: 0x04001B4A RID: 6986
		internal string string_31 = string.Empty;

		// Token: 0x04001B4B RID: 6987
		internal string string_32 = string.Empty;

		// Token: 0x04001B4C RID: 6988
		internal string string_33 = string.Empty;

		// Token: 0x04001B4D RID: 6989
		internal List<object> list_4 = new List<object>();

		// Token: 0x04001B4E RID: 6990
		internal string string_34 = string.Empty;

		// Token: 0x04001B4F RID: 6991
		internal string string_35 = string.Empty;

		// Token: 0x04001B50 RID: 6992
		internal List<object> list_5 = new List<object>();

		// Token: 0x04001B51 RID: 6993
		internal double double_19 = 0.0;

		// Token: 0x04001B52 RID: 6994
		internal double double_20 = 0.0;

		// Token: 0x04001B53 RID: 6995
		internal string string_36 = string.Empty;

		// Token: 0x04001B54 RID: 6996
		internal double double_21 = 0.0;

		// Token: 0x04001B55 RID: 6997
		internal double double_22 = 0.0;

		// Token: 0x04001B56 RID: 6998
		internal double double_23 = 0.0;

		// Token: 0x04001B57 RID: 6999
		internal double double_24 = 0.0;

		// Token: 0x04001B58 RID: 7000
		internal double double_25 = 0.0;

		// Token: 0x04001B59 RID: 7001
		internal double double_26 = 0.0;

		// Token: 0x04001B5A RID: 7002
		internal List<object> list_6 = new List<object>();

		// Token: 0x04001B5B RID: 7003
		internal bool bool_22 = false;

		// Token: 0x04001B5C RID: 7004
		internal double double_27 = 0.0;

		// Token: 0x04001B5D RID: 7005
		internal double double_28 = 0.0;

		// Token: 0x04001B5E RID: 7006
		internal double double_29 = 0.0;

		// Token: 0x04001B5F RID: 7007
		internal double double_30 = 0.0;

		// Token: 0x04001B60 RID: 7008
		internal double double_31 = 0.0;

		// Token: 0x04001B61 RID: 7009
		internal string string_37 = string.Empty;

		// Token: 0x04001B62 RID: 7010
		internal double double_32 = 0.0;

		// Token: 0x04001B63 RID: 7011
		internal bool bool_23 = false;

		// Token: 0x04001B64 RID: 7012
		internal List<object> list_7 = new List<object>();

		// Token: 0x04001B65 RID: 7013
		internal List<object> list_8 = new List<object>();

		// Token: 0x04001B66 RID: 7014
		public Class141.Class192 class192_0 = new Class141.Class192();

		// Token: 0x04001B67 RID: 7015
		internal double double_33 = 0.0;

		// Token: 0x04001B68 RID: 7016
		internal string string_38 = string.Empty;

		// Token: 0x04001B69 RID: 7017
		internal string string_39 = string.Empty;

		// Token: 0x02000344 RID: 836
		internal class Class192
		{
			// Token: 0x06004700 RID: 18176 RVA: 0x0010C6F4 File Offset: 0x0010A8F4
			internal static bool smethod_0(object object_0, out Class141.Class192 class192_0)
			{
				bool result;
				if (object_0 == null)
				{
					class192_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class192_0 = new Class141.Class192();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class192_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class192_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06004701 RID: 18177 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}
		}

		// Token: 0x02000345 RID: 837
		internal class Class193
		{
			// Token: 0x06004703 RID: 18179 RVA: 0x0010C79C File Offset: 0x0010A99C
			internal static bool smethod_0(object object_0, out Class141.Class193 class193_0)
			{
				bool result;
				if (object_0 == null)
				{
					class193_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class193_0 = new Class141.Class193();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class193_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class193_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06004704 RID: 18180 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}
		}

		// Token: 0x02000346 RID: 838
		internal class Class194
		{
			// Token: 0x06004706 RID: 18182 RVA: 0x0010C844 File Offset: 0x0010AA44
			internal static bool smethod_0(object object_0, out Class141.Class194 class194_0)
			{
				bool result;
				if (object_0 == null)
				{
					class194_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class194_0 = new Class141.Class194();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class194_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class194_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06004707 RID: 18183 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}
		}

		// Token: 0x02000347 RID: 839
		internal class Class195
		{
			// Token: 0x06004709 RID: 18185 RVA: 0x0010C8EC File Offset: 0x0010AAEC
			internal bool method_0(string string_2, object object_0)
			{
				if (string_2 == "name")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_2 == "text")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				return false;
			}

			// Token: 0x0600470A RID: 18186 RVA: 0x0010C97C File Offset: 0x0010AB7C
			internal static bool smethod_0(object object_0, out Class141.Class195 class195_0)
			{
				bool result;
				if (object_0 == null)
				{
					class195_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class195_0 = new Class141.Class195();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class195_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class195_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x04001B6A RID: 7018
			internal string string_0 = string.Empty;

			// Token: 0x04001B6B RID: 7019
			internal string string_1 = string.Empty;
		}

		// Token: 0x02000348 RID: 840
		internal class Class196
		{
			// Token: 0x0600470C RID: 18188 RVA: 0x0010CA50 File Offset: 0x0010AC50
			internal static bool smethod_0(object object_0, out Class141.Class196 class196_0)
			{
				bool result;
				if (object_0 == null)
				{
					class196_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class196_0 = new Class141.Class196();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class196_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class196_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x0600470D RID: 18189 RVA: 0x0010CAF8 File Offset: 0x0010ACF8
			internal bool method_0(string string_3, object object_0)
			{
				if (string_3 == "sdk2")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_3 == "sdk3-worlds")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_3 == "sdk3-avatars")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				return false;
			}

			// Token: 0x04001B6C RID: 7020
			internal string string_0 = string.Empty;

			// Token: 0x04001B6D RID: 7021
			internal string string_1 = string.Empty;

			// Token: 0x04001B6E RID: 7022
			internal string string_2 = string.Empty;
		}

		// Token: 0x02000349 RID: 841
		internal class Class197
		{
			// Token: 0x0600470F RID: 18191 RVA: 0x0010CC04 File Offset: 0x0010AE04
			internal static bool smethod_0(object object_0, out Class141.Class197 class197_0)
			{
				bool result;
				if (object_0 == null)
				{
					class197_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class197_0 = new Class141.Class197();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class197_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class197_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06004710 RID: 18192 RVA: 0x0010CCAC File Offset: 0x0010AEAC
			internal bool method_0(string string_6, object object_0)
			{
				if (string_6 == "name")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_6 == "sortHeading")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_6 == "sortOwnership")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				else if (string_6 == "sortOrder")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_3 = (string)object_0;
						return true;
					}
					this.string_3 = string.Empty;
				}
				else if (string_6 == "platform")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_4 = (string)object_0;
						return true;
					}
					this.string_4 = string.Empty;
				}
				else if (string_6 == "tag")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_5 = (string)object_0;
						return true;
					}
					this.string_5 = string.Empty;
				}
				else if (string_6 == "index")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				return false;
			}

			// Token: 0x04001B6F RID: 7023
			internal string string_0 = string.Empty;

			// Token: 0x04001B70 RID: 7024
			internal string string_1 = string.Empty;

			// Token: 0x04001B71 RID: 7025
			internal string string_2 = string.Empty;

			// Token: 0x04001B72 RID: 7026
			internal string string_3 = string.Empty;

			// Token: 0x04001B73 RID: 7027
			internal string string_4 = string.Empty;

			// Token: 0x04001B74 RID: 7028
			internal string string_5 = string.Empty;

			// Token: 0x04001B75 RID: 7029
			internal double double_0 = 0.0;
		}

		// Token: 0x0200034A RID: 842
		internal class Class198
		{
			// Token: 0x06004712 RID: 18194 RVA: 0x0010CF08 File Offset: 0x0010B108
			internal static bool smethod_0(object object_0, out Class141.Class198 class198_0)
			{
				bool result;
				if (object_0 == null)
				{
					class198_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class198_0 = new Class141.Class198();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class198_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class198_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06004713 RID: 18195 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}
		}

		// Token: 0x0200034B RID: 843
		internal class Class199
		{
			// Token: 0x06004715 RID: 18197 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x06004716 RID: 18198 RVA: 0x0010CFB0 File Offset: 0x0010B1B0
			internal static bool smethod_0(object object_0, out Class141.Class199 class199_0)
			{
				bool result;
				if (object_0 == null)
				{
					class199_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class199_0 = new Class141.Class199();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class199_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class199_0 = null;
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x0200034C RID: 844
		internal class Class200
		{
			// Token: 0x06004719 RID: 18201 RVA: 0x0010D104 File Offset: 0x0010B304
			internal bool method_0(string string_0, object object_0)
			{
				if (string_0 == "distanceClose")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_0 == "distanceFactor")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_1 = (double)object_0;
						return true;
					}
					this.double_1 = 0.0;
				}
				else if (string_0 == "distanceFar")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_2 = (double)object_0;
						return true;
					}
					this.double_2 = 0.0;
				}
				else if (string_0 == "groupDistance")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_3 = (double)object_0;
						return true;
					}
					this.double_3 = 0.0;
				}
				else if (string_0 == "maximumBunchSize")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_4 = (double)object_0;
						return true;
					}
					this.double_4 = 0.0;
				}
				else if (string_0 == "notVisibleFactor")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_5 = (double)object_0;
						return true;
					}
					this.double_5 = 0.0;
				}
				else if (string_0 == "playerOrderBucketSize")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_6 = (double)object_0;
						return true;
					}
					this.double_6 = 0.0;
				}
				else if (string_0 == "playerOrderFactor")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_7 = (double)object_0;
						return true;
					}
					this.double_7 = 0.0;
				}
				else if (string_0 == "slowUpdateFactorThreshold")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_8 = (double)object_0;
						return true;
					}
					this.double_8 = 0.0;
				}
				else if (string_0 == "viewSegmentLength")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_9 = (double)object_0;
						return true;
					}
					this.double_9 = 0.0;
				}
				return false;
			}

			// Token: 0x0600471A RID: 18202 RVA: 0x0010D3F4 File Offset: 0x0010B5F4
			internal static bool smethod_0(object object_0, out Class141.Class200 class200_0)
			{
				bool result;
				if (object_0 == null)
				{
					class200_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class200_0 = new Class141.Class200();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class200_0.method_0(text, dictionary[text]))
								{
									return false;
								}
							}
							catch
							{
								return false;
							}
						}
						result = true;
					}
					else
					{
						class200_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x04001B76 RID: 7030
			internal double double_0 = 0.0;

			// Token: 0x04001B77 RID: 7031
			internal double double_1 = 0.0;

			// Token: 0x04001B78 RID: 7032
			internal double double_2 = 0.0;

			// Token: 0x04001B79 RID: 7033
			internal double double_3 = 0.0;

			// Token: 0x04001B7A RID: 7034
			internal double double_4 = 0.0;

			// Token: 0x04001B7B RID: 7035
			internal double double_5 = 0.0;

			// Token: 0x04001B7C RID: 7036
			internal double double_6 = 0.0;

			// Token: 0x04001B7D RID: 7037
			internal double double_7 = 0.0;

			// Token: 0x04001B7E RID: 7038
			internal double double_8 = 0.0;

			// Token: 0x04001B7F RID: 7039
			internal double double_9 = 0.0;
		}
	}
}
