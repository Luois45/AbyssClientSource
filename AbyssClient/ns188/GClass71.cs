using System;
using System.Runtime.InteropServices;
using ns103;
using ns22;
using ns226;
using ns291;
using ns343;
using ns370;
using ns387;
using ns54;
using ns72;
using ns89;

namespace ns188
{
	// Token: 0x0200012F RID: 303
	public static class GClass71
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		public static bool smethod_0(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GenerateItems(<Module>.smethod_20(), out gstruct31_0, gstruct36_0, uint_0, uint_1);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002CB04 File Offset: 0x0002AD04
		internal static void smethod_1()
		{
			GClass71.smethod_7();
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0002CB18 File Offset: 0x0002AD18
		public static GStruct24 smethod_2()
		{
			GClass78.smethod_1();
			return GStruct24.smethod_2(Class177.SteamAPI_ISteamInventory_StartUpdateProperties(<Module>.smethod_20()));
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		public static bool smethod_3(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1, GStruct7[] gstruct7_0, uint[] uint_2, uint uint_3)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_ExchangeItems(<Module>.smethod_20(), out gstruct31_0, gstruct36_0, uint_0, uint_1, gstruct7_0, uint_2, uint_3);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0002CB64 File Offset: 0x0002AD64
		public static bool smethod_4(GStruct36 gstruct36_0, string string_0, out string string_1, ref uint uint_0)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_0);
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				bool flag = Class177.SteamAPI_ISteamInventory_GetItemDefinitionProperty(<Module>.smethod_20(), gstruct36_0, gclass, intPtr, ref uint_0);
				string_1 = (flag ? GClass78.smethod_0(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		public static bool smethod_5(out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_ConsumeItem(<Module>.smethod_20(), out gstruct31_0, gstruct7_0, uint_0);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		public static bool smethod_6(out GStruct31 gstruct31_0, GStruct7[] gstruct7_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetItemsByID(<Module>.smethod_20(), out gstruct31_0, gstruct7_0, uint_0);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0002CC08 File Offset: 0x0002AE08
		internal static void smethod_7()
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamInventory_SendItemDropHeartbeat(<Module>.smethod_20());
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0002CC24 File Offset: 0x0002AE24
		public static bool smethod_8(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_RemoveProperty(<Module>.smethod_20(), gstruct24_0, gstruct7_0, gclass);
			}
			return result;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002CC68 File Offset: 0x0002AE68
		public static GEnum54 smethod_9(GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetResultStatus(<Module>.smethod_20(), gstruct31_0);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002CC88 File Offset: 0x0002AE88
		public static void smethod_10()
		{
			GClass71.smethod_1();
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		public static bool smethod_11(out GStruct31 gstruct31_0, GStruct36[] gstruct36_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_AddPromoItems(<Module>.smethod_20(), out gstruct31_0, gstruct36_0, uint_0);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002CCBC File Offset: 0x0002AEBC
		public static bool smethod_12(out GStruct31 gstruct31_0, GStruct22 gstruct22_0, GStruct7[] gstruct7_0, uint[] uint_0, uint uint_1, GStruct7[] gstruct7_1, uint[] uint_2, uint uint_3)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_TradeItems(<Module>.smethod_20(), out gstruct31_0, gstruct22_0, gstruct7_0, uint_0, uint_1, gstruct7_1, uint_2, uint_3);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		public static GStruct241 smethod_13(GStruct36[] gstruct36_0, uint[] uint_0, uint uint_1)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_StartPurchase(<Module>.smethod_20(), gstruct36_0, uint_0, uint_1));
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002CD0C File Offset: 0x0002AF0C
		public static void smethod_14(GStruct31 gstruct31_0)
		{
			GClass71.smethod_21(gstruct31_0);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002CD20 File Offset: 0x0002AF20
		public static uint smethod_15(GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetResultTimestamp(<Module>.smethod_20(), gstruct31_0);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002CD40 File Offset: 0x0002AF40
		public static bool smethod_16(GStruct31 gstruct31_0, uint uint_0, string string_0, out string string_1, ref uint uint_1)
		{
			GClass78.smethod_1();
			IntPtr intPtr = Marshal.AllocHGlobal((int)uint_1);
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				bool flag = Class177.SteamAPI_ISteamInventory_GetResultItemProperty(<Module>.smethod_20(), gstruct31_0, uint_0, gclass, intPtr, ref uint_1);
				string_1 = (flag ? GClass78.smethod_0(intPtr) : null);
				Marshal.FreeHGlobal(intPtr);
				result = flag;
			}
			return result;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		public static bool smethod_17(out GStruct31 gstruct31_0, GStruct36 gstruct36_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_AddPromoItem(<Module>.smethod_20(), out gstruct31_0, gstruct36_0);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0002CDC8 File Offset: 0x0002AFC8
		public static bool smethod_18(GStruct36[] gstruct36_0, ulong[] ulong_0, uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetItemsWithPrices(<Module>.smethod_20(), gstruct36_0, ulong_0, uint_0);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		public static bool smethod_19(GStruct31 gstruct31_0, GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_CheckResultSteamID(<Module>.smethod_20(), gstruct31_0, gstruct22_0);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002CE08 File Offset: 0x0002B008
		public static bool smethod_20(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, long long_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty1(<Module>.smethod_20(), gstruct24_0, gstruct7_0, gclass, long_0);
			}
			return result;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002CE50 File Offset: 0x0002B050
		internal static void smethod_21(GStruct31 gstruct31_0)
		{
			GClass71.smethod_40(gstruct31_0);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002CE64 File Offset: 0x0002B064
		public static bool smethod_22(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, string string_1)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				using (GClass78.GClass79 gclass2 = new GClass78.GClass79(string_1))
				{
					result = Class177.SteamAPI_ISteamInventory_SetProperty(<Module>.smethod_20(), gstruct24_0, gstruct7_0, gclass, gclass2);
				}
			}
			return result;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		public static bool smethod_23()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_LoadItemDefinitions(<Module>.smethod_20());
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		public static uint smethod_24()
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetNumItemsWithPrices(<Module>.smethod_20());
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002CF04 File Offset: 0x0002B104
		public static bool smethod_25(out GStruct31 gstruct31_0, GStruct36 gstruct36_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_TriggerItemDrop(<Module>.smethod_20(), out gstruct31_0, gstruct36_0);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002CF24 File Offset: 0x0002B124
		public static bool smethod_26(out GStruct31 gstruct31_0, GStruct7 gstruct7_0, uint uint_0, GStruct7 gstruct7_1)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_TransferItemQuantity(<Module>.smethod_20(), out gstruct31_0, gstruct7_0, uint_0, gstruct7_1);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0002CF44 File Offset: 0x0002B144
		public static bool smethod_27(GStruct31 gstruct31_0, byte[] byte_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_SerializeResult(<Module>.smethod_20(), gstruct31_0, byte_0, out uint_0);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0002CF64 File Offset: 0x0002B164
		public static bool smethod_28(out GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GrantPromoItems(<Module>.smethod_20(), out gstruct31_0);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002CF84 File Offset: 0x0002B184
		public static bool smethod_29(GStruct31 gstruct31_0, GStruct226[] gstruct226_0, ref uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetResultItems(<Module>.smethod_20(), gstruct31_0, gstruct226_0, ref uint_0);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public static bool smethod_30(GStruct36[] gstruct36_0, out uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetItemDefinitionIDs(<Module>.smethod_20(), gstruct36_0, out uint_0);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		public static bool smethod_31(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, bool bool_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty0(<Module>.smethod_20(), gstruct24_0, gstruct7_0, gclass, bool_0);
			}
			return result;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002D00C File Offset: 0x0002B20C
		public static bool smethod_32(GStruct36 gstruct36_0, out ulong ulong_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetItemPrice(<Module>.smethod_20(), gstruct36_0, out ulong_0);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002D02C File Offset: 0x0002B22C
		public static GStruct241 smethod_33()
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_RequestPrices(<Module>.smethod_20()));
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002D050 File Offset: 0x0002B250
		public static bool smethod_34(GStruct22 gstruct22_0, GStruct36[] gstruct36_0, ref uint uint_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs(<Module>.smethod_20(), gstruct22_0, gstruct36_0, ref uint_0);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002D070 File Offset: 0x0002B270
		public static bool smethod_35(GStruct24 gstruct24_0, out GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_SubmitUpdateProperties(<Module>.smethod_20(), gstruct24_0, out gstruct31_0);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002D090 File Offset: 0x0002B290
		public static bool smethod_36(out GStruct31 gstruct31_0, byte[] byte_0, uint uint_0, bool bool_0 = false)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_DeserializeResult(<Module>.smethod_20(), out gstruct31_0, byte_0, uint_0, bool_0);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		public static bool smethod_37(GStruct24 gstruct24_0, GStruct7 gstruct7_0, string string_0, float float_0)
		{
			GClass78.smethod_1();
			bool result;
			using (GClass78.GClass79 gclass = new GClass78.GClass79(string_0))
			{
				result = Class177.SteamAPI_ISteamInventory_SetProperty2(<Module>.smethod_20(), gstruct24_0, gstruct7_0, gclass, float_0);
			}
			return result;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		public static GStruct241 smethod_38(GStruct22 gstruct22_0)
		{
			GClass78.smethod_1();
			return GStruct241.smethod_0(Class177.SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(<Module>.smethod_20(), gstruct22_0));
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002D11C File Offset: 0x0002B31C
		public static bool smethod_39(out GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			return Class177.SteamAPI_ISteamInventory_GetAllItems(<Module>.smethod_20(), out gstruct31_0);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0002D13C File Offset: 0x0002B33C
		internal static void smethod_40(GStruct31 gstruct31_0)
		{
			GClass78.smethod_1();
			Class177.SteamAPI_ISteamInventory_DestroyResult(<Module>.smethod_20(), gstruct31_0);
		}
	}
}
