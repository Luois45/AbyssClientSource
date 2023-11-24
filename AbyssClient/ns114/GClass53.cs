using System;
using ns120;
using ns226;
using ns274;
using ns317;
using ns370;
using ns387;

namespace ns114
{
	// Token: 0x020000B7 RID: 183
	public static class GClass53
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x0001897C File Offset: 0x00016B7C
		public static bool smethod_0(GStruct188 gstruct188_0, string string_0, out uint uint_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize(<Module>.smethod_13(), gstruct188_0, gclass, out uint_0);
			}
			return result;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000189C0 File Offset: 0x00016BC0
		public static bool smethod_1(GStruct188 gstruct188_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(<Module>.smethod_13(), gstruct188_0, uint_0);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000189E0 File Offset: 0x00016BE0
		public static bool smethod_2(GStruct188 gstruct188_0, out GStruct241 gstruct241_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SendHTTPRequest(<Module>.smethod_13(), gstruct188_0, out gstruct241_0);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00018A00 File Offset: 0x00016C00
		public static bool smethod_3(GStruct188 gstruct188_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPResponseBodyData(<Module>.smethod_13(), gstruct188_0, byte_0, uint_0);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00018A20 File Offset: 0x00016C20
		public static bool smethod_4(GStruct188 gstruct188_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPResponseBodySize(<Module>.smethod_13(), gstruct188_0, out uint_0);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00018A40 File Offset: 0x00016C40
		public static bool smethod_5(GStruct188 gstruct188_0, ulong ulong_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestContextValue(<Module>.smethod_13(), gstruct188_0, ulong_0);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00018A60 File Offset: 0x00016C60
		public static bool smethod_6(GStruct188 gstruct188_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_PrioritizeHTTPRequest(<Module>.smethod_13(), gstruct188_0);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00018A80 File Offset: 0x00016C80
		public static bool smethod_7(GStruct188 gstruct188_0, bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(<Module>.smethod_13(), gstruct188_0, bool_0);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public static GStruct207 smethod_8(bool bool_0)
		{
			GClass78.smethod_1();
			return GStruct207.smethod_3(Class177.SteamAPI_ISteamHTTP_CreateCookieContainer(<Module>.smethod_13(), bool_0));
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00018AC4 File Offset: 0x00016CC4
		public static bool smethod_9(GStruct188 gstruct188_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_DeferHTTPRequest(<Module>.smethod_13(), gstruct188_0);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00018AE4 File Offset: 0x00016CE4
		public static bool smethod_10(GStruct188 gstruct188_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo(<Module>.smethod_13(), gstruct188_0, gclass);
			}
			return result;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00018B28 File Offset: 0x00016D28
		public static bool smethod_11(GStruct188 gstruct188_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(<Module>.smethod_13(), gstruct188_0, uint_0);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00018B48 File Offset: 0x00016D48
		public static bool smethod_12(GStruct207 gstruct207_0, string string_0, string string_1, string string_2)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					using (GClass78.GClass79 gclass3 = new GClass78.GClass79(string_2))
					{
						result = Class177.SteamAPI_ISteamHTTP_SetCookie(<Module>.smethod_13(), gstruct207_0, gclass, gclass2, gclass3);
					}
				}
			}
			return result;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00018BCC File Offset: 0x00016DCC
		public static bool smethod_13(GStruct188 gstruct188_0, uint uint_0, byte[] byte_0, uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData(<Module>.smethod_13(), gstruct188_0, uint_0, byte_0, uint_1);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018BEC File Offset: 0x00016DEC
		public static bool smethod_14(GStruct207 gstruct207_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_ReleaseCookieContainer(<Module>.smethod_13(), gstruct207_0);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00018C0C File Offset: 0x00016E0C
		public static bool smethod_15(GStruct188 gstruct188_0, out float float_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct(<Module>.smethod_13(), gstruct188_0, out float_0);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00018C2C File Offset: 0x00016E2C
		public static bool smethod_16(GStruct188 gstruct188_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_ReleaseHTTPRequest(<Module>.smethod_13(), gstruct188_0);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00018C4C File Offset: 0x00016E4C
		public static bool smethod_17(GStruct188 gstruct188_0, string string_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue(<Module>.smethod_13(), gstruct188_0, gclass, byte_0, uint_0);
			}
			return result;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00018C94 File Offset: 0x00016E94
		public static bool smethod_18(GStruct188 gstruct188_0, out GStruct241 gstruct241_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse(<Module>.smethod_13(), gstruct188_0, out gstruct241_0);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00018CB4 File Offset: 0x00016EB4
		public static bool smethod_19(GStruct188 gstruct188_0, GStruct207 gstruct207_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer(<Module>.smethod_13(), gstruct188_0, gstruct207_0);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00018CD4 File Offset: 0x00016ED4
		public static bool smethod_20(GStruct188 gstruct188_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue(<Module>.smethod_13(), gstruct188_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00018D38 File Offset: 0x00016F38
		public static bool smethod_21(GStruct188 gstruct188_0, string string_0, byte[] byte_0, uint uint_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody(<Module>.smethod_13(), gstruct188_0, gclass, byte_0, uint_0);
			}
			return result;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00018D80 File Offset: 0x00016F80
		public static GStruct188 smethod_22(GEnum18 genum18_0, string string_0)
		{
			GClass78.smethod_1();
			GStruct188 result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = GStruct188.smethod_1(Class177.SteamAPI_ISteamHTTP_CreateHTTPRequest(<Module>.smethod_13(), genum18_0, gclass));
			}
			return result;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00018DCC File Offset: 0x00016FCC
		public static bool smethod_23(GStruct188 gstruct188_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter(<Module>.smethod_13(), gstruct188_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00018E30 File Offset: 0x00017030
		public static bool smethod_24(GStruct188 gstruct188_0, out bool bool_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut(<Module>.smethod_13(), gstruct188_0, out bool_0);
		}
	}
}
