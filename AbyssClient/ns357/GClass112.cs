using System;
using System.Runtime.InteropServices;
using ns103;
using ns22;
using ns226;
using ns291;
using ns343;
using ns370;
using ns381;
using ns387;
using ns54;
using ns72;
using ns89;

namespace ns357
{
	// Token: 0x020002BE RID: 702
	public static class GClass112
	{
		// Token: 0x06002056 RID: 8278 RVA: 0x000A5828 File Offset: 0x000A3A28
		public static bool smethod_0(out GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetAllItems(Class180.smethod_6(), out gstruct31_0);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000A5848 File Offset: 0x000A3A48
		public static GStruct241 smethod_1(GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(Class180.smethod_6(), gstruct22_0));
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000A586C File Offset: 0x000A3A6C
		public static bool smethod_2(out GStruct31 gstruct31_0, GStruct36 gstruct36_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_TriggerItemDrop(Class180.smethod_6(), out gstruct31_0, gstruct36_0);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000A588C File Offset: 0x000A3A8C
		public static void smethod_3()
		{
			GClass112.smethod_7();
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000A58A0 File Offset: 0x000A3AA0
		public static bool smethod_4(GStruct31 gstruct31_0, GStruct226[] gstruct226_0, ref uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetResultItems(Class180.smethod_6(), gstruct31_0, gstruct226_0, ref uint_0);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000A58C0 File Offset: 0x000A3AC0
		public static bool smethod_5(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_AddPromoItems(Class180.smethod_6(), out gstruct31_0, gstruct36_0, uint_0);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000A58E0 File Offset: 0x000A3AE0
		public static bool smethod_6(out GStruct31 gstruct31_0, GStruct22 gstruct22_0, GStruct7[] gstruct7_0, uint[] uint_0, uint uint_1, GStruct7[] gstruct7_1, uint[] uint_2, uint uint_3)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_TradeItems(Class180.smethod_6(), out gstruct31_0, gstruct22_0, gstruct7_0, uint_0, uint_1, gstruct7_1, uint_2, uint_3);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000A5908 File Offset: 0x000A3B08
		internal static void smethod_7()
		{
			GClass112.smethod_16();
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000A591C File Offset: 0x000A3B1C
		public static bool smethod_8(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, float float_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty2(Class180.smethod_6(), gstruct24_0, gstruct7_0, gclass, float_0);
			}
			return result;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000A5964 File Offset: 0x000A3B64
		public static bool smethod_9(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, long long_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty1(Class180.smethod_6(), gstruct24_0, gstruct7_0, gclass, long_0);
			}
			return result;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000A59AC File Offset: 0x000A3BAC
		public static bool smethod_10(GStruct22 gstruct22_0, GStruct36[] gstruct36_0, ref uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs(Class180.smethod_6(), gstruct22_0, gstruct36_0, ref uint_0);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000A59CC File Offset: 0x000A3BCC
		public static bool smethod_11()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_LoadItemDefinitions(Class180.smethod_6());
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000A59E8 File Offset: 0x000A3BE8
		public static bool smethod_12(out GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GrantPromoItems(Class180.smethod_6(), out gstruct31_0);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000A5A08 File Offset: 0x000A3C08
		public static bool smethod_13(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, bool bool_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty0(Class180.smethod_6(), gstruct24_0, gstruct7_0, gclass, bool_0);
			}
			return result;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000A5A50 File Offset: 0x000A3C50
		public static void smethod_14(GStruct31 gstruct31_0)
		{
			GClass112.smethod_20(gstruct31_0);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000A5A64 File Offset: 0x000A3C64
		public static GStruct241 smethod_15(GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1)
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_StartPurchase(Class180.smethod_6(), gstruct36_0, uint_0, uint_1));
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000A5A8C File Offset: 0x000A3C8C
		internal static void smethod_16()
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamInventory_SendItemDropHeartbeat(Class180.smethod_6());
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000A5AA8 File Offset: 0x000A3CA8
		public static bool smethod_17(GStruct36[] gstruct36_0, ulong[] ulong_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetItemsWithPrices(Class180.smethod_6(), gstruct36_0, ulong_0, uint_0);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
		public static bool smethod_18(GStruct36 gstruct36_0, string string_0, out string string_1, ref uint uint_0)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				bool flag = Class177.SteamAPI_ISteamInventory_GetItemDefinitionProperty(Class180.smethod_6(), gstruct36_0, gclass, intPtr, ref uint_0);
				string_1 = (flag ? GClass78.smethod_0(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000A5B2C File Offset: 0x000A3D2C
		public static bool smethod_19(out GStruct31 gstruct31_0, byte[] byte_0, uint uint_0, bool bool_0 = false)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_DeserializeResult(Class180.smethod_6(), out gstruct31_0, byte_0, uint_0, bool_0);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000A5B4C File Offset: 0x000A3D4C
		internal static void smethod_20(GStruct31 gstruct31_0)
		{
			GClass112.smethod_40(gstruct31_0);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000A5B60 File Offset: 0x000A3D60
		public static bool smethod_21(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GenerateItems(Class180.smethod_6(), out gstruct31_0, gstruct36_0, uint_0, uint_1);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000A5B80 File Offset: 0x000A3D80
		public static bool smethod_22(GStruct24 gstruct24_0, out GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_SubmitUpdateProperties(Class180.smethod_6(), gstruct24_0, out gstruct31_0);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000A5BA0 File Offset: 0x000A3DA0
		public static uint smethod_23()
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetNumItemsWithPrices(Class180.smethod_6());
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000A5BC0 File Offset: 0x000A3DC0
		public static bool smethod_24(GStruct36[] gstruct36_0, out uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetItemDefinitionIDs(Class180.smethod_6(), gstruct36_0, out uint_0);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000A5BE0 File Offset: 0x000A3DE0
		public static bool smethod_25(GStruct31 gstruct31_0, uint uint_0, string string_0, out string string_1, ref uint uint_1)
		{
			GClass78.smethod_2();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				bool flag = Class177.SteamAPI_ISteamInventory_GetResultItemProperty(Class180.smethod_6(), gstruct31_0, uint_0, gclass, intPtr, ref uint_1);
				string_1 = (flag ? GClass78.smethod_0(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000A5C48 File Offset: 0x000A3E48
		public static bool smethod_26(GStruct31 gstruct31_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_CheckResultSteamID(Class180.smethod_6(), gstruct31_0, gstruct22_0);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000A5C68 File Offset: 0x000A3E68
		public static bool smethod_27(out GStruct31 gstruct31_0, GStruct7[] gstruct7_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetItemsByID(Class180.smethod_6(), out gstruct31_0, gstruct7_0, uint_0);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000A5C88 File Offset: 0x000A3E88
		public static bool smethod_28(GStruct31 gstruct31_0, byte[] byte_0, out uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_SerializeResult(Class180.smethod_6(), gstruct31_0, byte_0, out uint_0);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000A5CA8 File Offset: 0x000A3EA8
		public static GStruct241 smethod_29()
		{
			GClass78.smethod_2();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_RequestPrices(Class180.smethod_6()));
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000A5CCC File Offset: 0x000A3ECC
		public static bool smethod_30(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, string string_1)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamInventory_SetProperty(Class180.smethod_6(), gstruct24_0, gstruct7_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000A5D30 File Offset: 0x000A3F30
		public static GStruct24 smethod_31()
		{
			GClass78.smethod_2();
			return GStruct24.smethod_2(Class177.SteamAPI_ISteamInventory_StartUpdateProperties(Class180.smethod_6()));
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000A5D54 File Offset: 0x000A3F54
		public static bool smethod_32(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1, GStruct7[] gstruct7_0, uint[] uint_2, uint uint_3)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_ExchangeItems(Class180.smethod_6(), out gstruct31_0, gstruct36_0, uint_0, uint_1, gstruct7_0, uint_2, uint_3);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000A5D7C File Offset: 0x000A3F7C
		public static bool smethod_33(GStruct36 gstruct36_0, out ulong ulong_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetItemPrice(Class180.smethod_6(), gstruct36_0, out ulong_0);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000A5D9C File Offset: 0x000A3F9C
		public static bool smethod_34(out GStruct31 gstruct31_0, GStruct36 gstruct36_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_AddPromoItem(Class180.smethod_6(), out gstruct31_0, gstruct36_0);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000A5DBC File Offset: 0x000A3FBC
		public static bool smethod_35(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0)
		{
			GClass78.smethod_2();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_RemoveProperty(Class180.smethod_6(), gstruct24_0, gstruct7_0, gclass);
			}
			return result;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000A5E00 File Offset: 0x000A4000
		public static bool smethod_36(out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0, GStruct7 gstruct7_1)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_TransferItemQuantity(Class180.smethod_6(), out gstruct31_0, gstruct7_0, uint_0, gstruct7_1);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000A5E20 File Offset: 0x000A4020
		public static GEnum54 smethod_37(GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetResultStatus(Class180.smethod_6(), gstruct31_0);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000A5E40 File Offset: 0x000A4040
		public static bool smethod_38(out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_ConsumeItem(Class180.smethod_6(), out gstruct31_0, gstruct7_0, uint_0);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000A5E60 File Offset: 0x000A4060
		public static uint smethod_39(GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			return Class177.SteamAPI_ISteamInventory_GetResultTimestamp(Class180.smethod_6(), gstruct31_0);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000A5E80 File Offset: 0x000A4080
		internal static void smethod_40(GStruct31 gstruct31_0)
		{
			GClass78.smethod_2();
			Class177.SteamAPI_ISteamInventory_DestroyResult(Class180.smethod_6(), gstruct31_0);
		}
	}
}
