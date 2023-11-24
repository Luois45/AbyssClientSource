using System;
using ns120;
using ns226;
using ns274;
using ns317;
using ns370;
using ns381;
using ns387;

namespace ns76
{
	// Token: 0x02000055 RID: 85
	public static class GClass41
	{
		// Token: 0x0600031F RID: 799 RVA: 0x0000A568 File Offset: 0x00008768
		public static bool smethod_0(GStruct188 gstruct188_0, string string_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody(Class180.smethod_9(), gstruct188_0, gclass, byte_0, uint_0);
			}
			return result;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000A5B0 File Offset: 0x000087B0
		public static bool smethod_1(GStruct188 gstruct188_0, out float float_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct(Class180.smethod_9(), gstruct188_0, out float_0);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A5D0 File Offset: 0x000087D0
		public static bool smethod_2(GStruct188 gstruct188_0, ulong ulong_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestContextValue(Class180.smethod_9(), gstruct188_0, ulong_0);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A5F0 File Offset: 0x000087F0
		public static bool smethod_3(GStruct188 gstruct188_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(Class180.smethod_9(), gstruct188_0, uint_0);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000A610 File Offset: 0x00008810
		public static bool smethod_4(GStruct188 gstruct188_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_ReleaseHTTPRequest(Class180.smethod_9(), gstruct188_0);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000A630 File Offset: 0x00008830
		public static bool smethod_5(GStruct188 gstruct188_0, string string_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter(Class180.smethod_9(), gstruct188_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A694 File Offset: 0x00008894
		public static bool smethod_6(GStruct188 gstruct188_0, string string_0, out uint uint_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize(Class180.smethod_9(), gstruct188_0, gclass, out uint_0);
			}
			return result;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public static bool smethod_7(GStruct188 gstruct188_0, uint uint_0, byte[] byte_0, uint uint_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData(Class180.smethod_9(), gstruct188_0, uint_0, byte_0, uint_1);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public static GStruct207 smethod_8(bool bool_0)
		{
			GClass78.smethod_2();
			return GStruct207.smethod_3(Class177.SteamAPI_ISteamHTTP_CreateCookieContainer(Class180.smethod_9(), bool_0));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000A71C File Offset: 0x0000891C
		public static bool smethod_9(GStruct188 gstruct188_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_DeferHTTPRequest(Class180.smethod_9(), gstruct188_0);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000A73C File Offset: 0x0000893C
		public static bool smethod_10(GStruct188 gstruct188_0, string string_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue(Class180.smethod_9(), gstruct188_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000A7A0 File Offset: 0x000089A0
		public static bool smethod_11(GStruct188 gstruct188_0, string string_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue(Class180.smethod_9(), gstruct188_0, gclass, byte_0, uint_0);
			}
			return result;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000A7E8 File Offset: 0x000089E8
		public static bool smethod_12(GStruct207 gstruct207_0, string string_0, string string_1, string string_2)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					using (GClass78.GClass79 gclass3 = new GClass78.GClass79(string_2))
					{
						result = Class177.SteamAPI_ISteamHTTP_SetCookie(Class180.smethod_9(), gstruct207_0, gclass, gclass2, gclass3);
					}
				}
			}
			return result;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000A86C File Offset: 0x00008A6C
		public static bool smethod_13(GStruct188 gstruct188_0, GStruct207 gstruct207_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer(Class180.smethod_9(), gstruct188_0, gstruct207_0);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000A88C File Offset: 0x00008A8C
		public static bool smethod_14(GStruct188 gstruct188_0, out uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPResponseBodySize(Class180.smethod_9(), gstruct188_0, out uint_0);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000A8AC File Offset: 0x00008AAC
		public static bool smethod_15(GStruct188 gstruct188_0, bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(Class180.smethod_9(), gstruct188_0, bool_0);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000A8CC File Offset: 0x00008ACC
		public static bool smethod_16(GStruct188 gstruct188_0, out GStruct241 gstruct241_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SendHTTPRequest(Class180.smethod_9(), gstruct188_0, out gstruct241_0);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public static bool smethod_17(GStruct188 gstruct188_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_PrioritizeHTTPRequest(Class180.smethod_9(), gstruct188_0);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000A90C File Offset: 0x00008B0C
		public static bool smethod_18(GStruct188 gstruct188_0, out GStruct241 gstruct241_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse(Class180.smethod_9(), gstruct188_0, out gstruct241_0);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000A92C File Offset: 0x00008B2C
		public static bool smethod_19(GStruct188 gstruct188_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPResponseBodyData(Class180.smethod_9(), gstruct188_0, byte_0, uint_0);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000A94C File Offset: 0x00008B4C
		public static bool smethod_20(GStruct188 gstruct188_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(Class180.smethod_9(), gstruct188_0, uint_0);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000A96C File Offset: 0x00008B6C
		public static bool smethod_21(GStruct188 gstruct188_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo(Class180.smethod_9(), gstruct188_0, gclass);
			}
			return result;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public static bool smethod_22(GStruct207 gstruct207_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_ReleaseCookieContainer(Class180.smethod_9(), gstruct207_0);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		public static GStruct188 smethod_23(GEnum18 genum18_0, string string_0)
		{
			GClass78.smethod_2();
			GStruct188 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct188.smethod_1(Class177.SteamAPI_ISteamHTTP_CreateHTTPRequest(Class180.smethod_9(), genum18_0, gclass));
			}
			return result;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public static bool smethod_24(GStruct188 gstruct188_0, out bool bool_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut(Class180.smethod_9(), gstruct188_0, out bool_0);
		}
	}
}
