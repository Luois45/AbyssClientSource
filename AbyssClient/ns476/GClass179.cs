using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ns185;
using ns241;
using ns397;
using ns425;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Networking;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace ns476
{
	// Token: 0x02000330 RID: 816
	public class GClass179 : GClass130
	{
		// Token: 0x0600462A RID: 17962 RVA: 0x0010727C File Offset: 0x0010547C
		private static HarmonyMethod smethod_0(string string_1)
		{
			return new HarmonyMethod(typeof(GClass179).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x001072A4 File Offset: 0x001054A4
		internal void method_2(bool bool_7)
		{
			this.method_21(bool_7);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x001072B8 File Offset: 0x001054B8
		internal void method_3(string string_1, List<KeyCode> list_2, Text text_0)
		{
			this.method_19(string_1, list_2, text_0);
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x001072D0 File Offset: 0x001054D0
		private static void smethod_1(UdonBehaviour udonBehaviour_0, string string_1, Player player_0)
		{
			if (string_1.ToLower().Contains("fire") && GClass84.gclass141_0.bool_9)
			{
				VRC_Pickup[] array = Resources.FindObjectsOfTypeAll<VRC_Pickup>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null)
					{
						array[i].pickupable = true;
					}
				}
			}
			GClass84.gclass93_0.method_213(udonBehaviour_0, string_1, player_0);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x0010733C File Offset: 0x0010553C
		internal void method_4(bool bool_7)
		{
			this.method_34(bool_7);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00107350 File Offset: 0x00105550
		internal void method_5()
		{
			this.method_37();
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00107364 File Offset: 0x00105564
		internal void method_6(bool bool_7)
		{
			this.bool_1 = bool_7;
			if (bool_7)
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00107384 File Offset: 0x00105584
		internal static void smethod_2(string string_1)
		{
			GClass179.smethod_10(string_1);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00107398 File Offset: 0x00105598
		internal void method_7(bool bool_7)
		{
			this.method_35(bool_7);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001073AC File Offset: 0x001055AC
		internal void method_8(bool bool_7)
		{
			if (bool_7)
			{
				this.method_18(Clipboard.GetText().Trim());
			}
			Action<string, List<KeyCode>, Text> action_ = new Action<string, List<KeyCode>, Text>(this.method_3);
			GClass84.smethod_946("Custom event name", "_interact", 0, false, "Execute", action_, null, "Enter Valid Event Name", true, null, false);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00107400 File Offset: 0x00105600
		internal void method_9()
		{
			this.method_38();
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00107414 File Offset: 0x00105614
		internal void method_10(bool bool_7)
		{
			this.method_16(bool_7);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00107428 File Offset: 0x00105628
		internal void method_11(bool bool_7)
		{
			this.method_4(bool_7);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0010743C File Offset: 0x0010563C
		internal void method_12(bool bool_7)
		{
			this.method_2(bool_7);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00107450 File Offset: 0x00105650
		internal void method_13(bool bool_7)
		{
			GClass179.bool_4 = bool_7;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00107464 File Offset: 0x00105664
		public override void vmethod_8(int int_0)
		{
			this.method_29(int_0);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00107478 File Offset: 0x00105678
		private static bool smethod_3(UdonBehaviour udonBehaviour_0, string string_1, Player player_0)
		{
			bool result;
			if (GClass179.bool_2)
			{
				result = false;
			}
			else
			{
				string text = string_1.ToLower();
				if (GClass179.bool_4 && (text.Contains("kill") || text.Contains("penalty") || text.Contains("votedout") || text.Contains("freezeme") || text.Contains("synclock")) && player_0.Method_Internal_get_APIUser_0().displayName != GClass84.smethod_1178(GClass84.smethod_460(), ""))
				{
					result = false;
				}
				else
				{
					GClass84.gclass93_0.method_49(udonBehaviour_0, string_1, player_0);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00107520 File Offset: 0x00105720
		internal void method_14(int int_0)
		{
			this.method_23();
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00107534 File Offset: 0x00105734
		internal bool method_15(GClass179.GStruct261 gstruct261_0, bool bool_7)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				GClass179.GStruct261 gstruct = this.list_1[i];
				if (gstruct261_0.method_0(gstruct))
				{
					gstruct.bool_3 = bool_7;
					this.list_1[i] = gstruct;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x0010758C File Offset: 0x0010578C
		internal void method_16(bool bool_7)
		{
			this.method_13(bool_7);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x001075A0 File Offset: 0x001057A0
		internal bool method_17(UdonBehaviour udonBehaviour_0, string string_1, float float_0)
		{
			this.list_1.Add(new GClass179.GStruct261(udonBehaviour_0, string_1, float_0, this.bool_0, this.bool_1, false, this.vrcplayerApi_0));
			return true;
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x001075D4 File Offset: 0x001057D4
		public override void vmethod_19()
		{
			this.method_26();
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x001075E8 File Offset: 0x001057E8
		internal bool method_18(string string_1)
		{
			bool flag = GClass179.bool_2;
			if (GClass179.bool_3)
			{
				GClass179.bool_2 = false;
			}
			bool result = GClass84.smethod_1019(this.list_0, string_1);
			GClass179.bool_2 = flag;
			return result;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x0010761C File Offset: 0x0010581C
		internal void method_19(string string_1, List<KeyCode> list_2, Text text_0)
		{
			this.method_44(string_1, list_2, text_0);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00107634 File Offset: 0x00105834
		internal void method_20()
		{
			this.list_1.Clear();
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x0010764C File Offset: 0x0010584C
		internal void method_21(bool bool_7)
		{
			this.bool_0 = bool_7;
			if (bool_7)
			{
				this.bool_1 = false;
			}
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x0010766C File Offset: 0x0010586C
		internal void method_22(bool bool_7)
		{
			this.method_8(bool_7);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00107680 File Offset: 0x00105880
		internal void method_23()
		{
			this.method_9();
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x00107694 File Offset: 0x00105894
		private static void smethod_4(UdonBehaviour udonBehaviour_0, string string_1, Player player_0)
		{
			GClass179.smethod_1(udonBehaviour_0, string_1, player_0);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x001076AC File Offset: 0x001058AC
		internal void method_24(bool bool_7)
		{
			GClass179.bool_3 = bool_7;
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x001076C0 File Offset: 0x001058C0
		internal bool method_25(GClass179.GStruct261 gstruct261_0)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				if (gstruct261_0.method_0(this.list_1[i]))
				{
					this.list_1.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00107710 File Offset: 0x00105910
		internal void method_26()
		{
			this.method_48();
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00107724 File Offset: 0x00105924
		internal void method_27()
		{
			this.method_49();
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00107738 File Offset: 0x00105938
		private static void smethod_5(UdonBehaviour udonBehaviour_0, string string_1, Player player_0)
		{
			GClass179.smethod_4(udonBehaviour_0, string_1, player_0);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00107750 File Offset: 0x00105950
		internal void method_28()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass121.smethod_2();
			GClass84.gclass121_0 = GClass121.gclass121_0;
			this.bool_6 = GClass84.gclass121_0.bool_0;
			GClass84.smethod_1302("UdonManager", typeof(UdonBehaviour), "SendCustomNetworkEvent", GClass179.smethod_0("UdonBehaviour_SendCustomNetworkEvent"), null, null);
			GClass84.smethod_1302("UdonManager", typeof(UdonBehaviour), "SendCustomEvent", GClass179.smethod_0("UdonBehaviour_SendCustomEvent"), null, null);
			GClass84.smethod_1302("UdonManager", typeof(UdonSync), "UdonSyncRunProgramAsRPC", GClass179.smethod_0("PreUdonSyncRunProgramAsRPC"), GClass179.smethod_0("PostUdonSyncRunProgramAsRPC"), null);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00107828 File Offset: 0x00105A28
		internal void method_29(int int_0)
		{
			this.method_14(int_0);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x0010783C File Offset: 0x00105A3C
		internal IEnumerator method_30()
		{
			GClass179.Class187 @class = new GClass179.Class187(0);
			@class.gclass179_0 = this;
			return @class;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00107858 File Offset: 0x00105A58
		internal void method_31(bool bool_7)
		{
			this.method_42(bool_7);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x0010786C File Offset: 0x00105A6C
		internal void method_32()
		{
			this.method_5();
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00107880 File Offset: 0x00105A80
		private static bool smethod_6(UdonBehaviour udonBehaviour_0, NetworkEventTarget networkEventTarget_0, string string_1)
		{
			bool result;
			if (!udonBehaviour_0 || string_1 == null)
			{
				result = false;
			}
			else
			{
				if (GClass84.gclass179_0.bool_6 && (string_1 != null && GClass84.smethod_1428(string_1, 1) != "_"))
				{
					GClass179.smethod_7(string.Concat(new string[]
					{
						"UdonBehaviour_SendCustomNetworkEvent",
						": ",
						GClass84.smethod_118(udonBehaviour_0),
						", ",
						networkEventTarget_0.ToString(),
						", ",
						string_1
					}));
				}
				GClass84.gclass93_0.method_192(udonBehaviour_0, networkEventTarget_0, string_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00107928 File Offset: 0x00105B28
		internal void method_33(bool bool_7)
		{
			this.method_39(bool_7);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x0010793C File Offset: 0x00105B3C
		internal void method_34(bool bool_7)
		{
			GClass179.bool_2 = bool_7;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00107950 File Offset: 0x00105B50
		internal void method_35(bool bool_7)
		{
			this.bool_6 = bool_7;
			GClass84.gclass121_0.bool_0 = bool_7;
			GClass121.smethod_1();
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00107974 File Offset: 0x00105B74
		internal static void smethod_7(string string_1)
		{
			GClass179.smethod_2(string_1);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x00107988 File Offset: 0x00105B88
		internal void method_36(bool bool_7)
		{
			this.method_7(bool_7);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x0010799C File Offset: 0x00105B9C
		internal void method_37()
		{
			IEnumerator enumerator = this.method_30();
			MelonCoroutines.Start(enumerator);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001079B8 File Offset: 0x00105BB8
		private static bool smethod_8(UdonBehaviour udonBehaviour_0, string string_1, Il2CppReferenceArray<ValueTuple<string, Object>> il2CppReferenceArray_0)
		{
			return udonBehaviour_0 && string_1 != null && !GClass179.bool_2;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001079E8 File Offset: 0x00105BE8
		internal void method_38()
		{
			this.list_0.Clear();
			this.list_0.AddRange(Object.FindObjectsOfType<UdonBehaviour>());
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00107A5C File Offset: 0x00105C5C
		internal void method_39(bool bool_7)
		{
			this.method_24(bool_7);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00107A70 File Offset: 0x00105C70
		internal void method_40()
		{
			this.method_28();
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00107A84 File Offset: 0x00105C84
		public override void vmethod_23()
		{
			this.method_40();
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00107A98 File Offset: 0x00105C98
		private static bool smethod_9(UdonBehaviour udonBehaviour_0, string string_1)
		{
			bool result;
			if (!udonBehaviour_0 || string_1 == null)
			{
				result = false;
			}
			else
			{
				GClass84.gclass93_0.method_7(udonBehaviour_0, string_1);
				result = true;
			}
			return result;
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00107ACC File Offset: 0x00105CCC
		internal bool method_41(UdonBehaviour udonBehaviour_0, string string_1, bool bool_7 = false, bool bool_8 = false, VRCPlayerApi vrcplayerApi_1 = null)
		{
			bool flag = GClass179.bool_2;
			if (GClass179.bool_3)
			{
				GClass179.bool_2 = false;
			}
			bool result;
			if (bool_7)
			{
				result = GClass84.smethod_986(udonBehaviour_0, string_1, false);
			}
			else if (bool_8)
			{
				result = (vrcplayerApi_1 != null && GClass84.smethod_794(udonBehaviour_0, string_1, vrcplayerApi_1, false));
			}
			else
			{
				result = GClass84.smethod_1697(udonBehaviour_0, string_1);
			}
			GClass179.bool_2 = flag;
			return result;
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00107B28 File Offset: 0x00105D28
		internal void method_42(bool bool_7)
		{
			this.method_6(bool_7);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00107B3C File Offset: 0x00105D3C
		internal bool method_43(UdonBehaviour udonBehaviour_0 = null, string string_1 = "", float float_0 = 0f, bool bool_7 = false, bool bool_8 = false, bool bool_9 = false, VRCPlayerApi vrcplayerApi_1 = null)
		{
			this.list_1.Add(new GClass179.GStruct261(udonBehaviour_0, string_1, float_0, bool_7, bool_8, bool_9, vrcplayerApi_1));
			return true;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00107B68 File Offset: 0x00105D68
		internal void method_44(string string_1, List<KeyCode> list_2, Text text_0)
		{
			this.method_18(string_1);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00107B80 File Offset: 0x00105D80
		internal void method_45(bool bool_7 = false)
		{
			this.method_22(bool_7);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00107B94 File Offset: 0x00105D94
		internal bool method_46(GClass179.GStruct261 gstruct261_0)
		{
			return (!gstruct261_0.bool_1 || gstruct261_0.vrcplayerApi_0 != null) && this.method_41(gstruct261_0.udonBehaviour_0, gstruct261_0.string_0, gstruct261_0.bool_0, gstruct261_0.bool_1, gstruct261_0.vrcplayerApi_0);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00107BE0 File Offset: 0x00105DE0
		internal bool method_47(UdonBehaviour udonBehaviour_0, string string_1)
		{
			return this.method_41(udonBehaviour_0, string_1, this.bool_0, this.bool_1, this.vrcplayerApi_0);
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00107C08 File Offset: 0x00105E08
		internal void method_48()
		{
			if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304))
			{
				if (Input.GetKeyDown(101))
				{
					this.bool_5 = !this.bool_5;
				}
				if (Input.GetKeyDown(99))
				{
					this.method_27();
				}
				if (Input.GetKeyDown(117))
				{
					this.method_11(!GClass179.bool_2);
				}
			}
			if (this.bool_5)
			{
				try
				{
					int num = GClass84.smethod_841();
					for (int i = 0; i < this.list_1.Count; i++)
					{
						GClass179.GStruct261 gstruct = this.list_1[i];
						if (gstruct.bool_3)
						{
							if (!gstruct.bool_2 && (!gstruct.udonBehaviour_0 || (gstruct.bool_1 && gstruct.vrcplayerApi_0 == null)))
							{
								this.list_1.RemoveAt(i);
								i--;
							}
							else if ((float)num >= gstruct.float_1 + gstruct.float_0 * 1000f)
							{
								if (gstruct.bool_2)
								{
									if (this.method_18(gstruct.string_0))
									{
										gstruct.float_1 = (float)num;
										this.list_1[i] = gstruct;
									}
								}
								else if (this.method_46(gstruct))
								{
									gstruct.float_1 = (float)num;
									this.list_1[i] = gstruct;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00107DB8 File Offset: 0x00105FB8
		internal void method_49()
		{
			this.method_20();
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00107DCC File Offset: 0x00105FCC
		internal static void smethod_10(string string_1)
		{
			GClass70.smethod_38(string_1, GClass70.Enum1.const_6);
		}

		// Token: 0x04001A92 RID: 6802
		internal bool bool_0 = false;

		// Token: 0x04001A93 RID: 6803
		internal bool bool_1 = false;

		// Token: 0x04001A94 RID: 6804
		internal VRCPlayerApi vrcplayerApi_0 = null;

		// Token: 0x04001A95 RID: 6805
		internal List<UdonBehaviour> list_0 = new List<UdonBehaviour>();

		// Token: 0x04001A96 RID: 6806
		internal static bool bool_2;

		// Token: 0x04001A97 RID: 6807
		internal static bool bool_3;

		// Token: 0x04001A98 RID: 6808
		internal static bool bool_4;

		// Token: 0x04001A99 RID: 6809
		internal bool bool_5 = true;

		// Token: 0x04001A9A RID: 6810
		internal List<GClass179.GStruct261> list_1 = new List<GClass179.GStruct261>();

		// Token: 0x04001A9B RID: 6811
		internal bool bool_6 = false;

		// Token: 0x02000331 RID: 817
		public struct GStruct261
		{
			// Token: 0x06004669 RID: 18025 RVA: 0x00107DE0 File Offset: 0x00105FE0
			public bool method_0(GClass179.GStruct261 gstruct261_0)
			{
				return gstruct261_0.bool_0 == this.bool_0 && gstruct261_0.bool_1 == this.bool_1 && (!gstruct261_0.bool_1 || gstruct261_0.vrcplayerApi_0 == this.vrcplayerApi_0) && gstruct261_0.udonBehaviour_0 == this.udonBehaviour_0 && gstruct261_0.string_0 == this.string_0 && gstruct261_0.float_0 == this.float_0;
			}

			// Token: 0x0600466A RID: 18026 RVA: 0x00107E58 File Offset: 0x00106058
			public GStruct261(UdonBehaviour udonBehaviour_1, string string_1, float float_2, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, VRCPlayerApi vrcplayerApi_1 = null)
			{
				this.udonBehaviour_0 = udonBehaviour_1;
				this.string_0 = string_1;
				this.float_0 = float_2;
				this.bool_0 = bool_4;
				this.bool_1 = bool_5;
				this.bool_2 = bool_6;
				this.vrcplayerApi_0 = vrcplayerApi_1;
				this.float_1 = 0f;
				this.bool_3 = true;
			}

			// Token: 0x04001A9C RID: 6812
			public UdonBehaviour udonBehaviour_0;

			// Token: 0x04001A9D RID: 6813
			public string string_0;

			// Token: 0x04001A9E RID: 6814
			public float float_0;

			// Token: 0x04001A9F RID: 6815
			public bool bool_0;

			// Token: 0x04001AA0 RID: 6816
			public bool bool_1;

			// Token: 0x04001AA1 RID: 6817
			public bool bool_2;

			// Token: 0x04001AA2 RID: 6818
			public VRCPlayerApi vrcplayerApi_0;

			// Token: 0x04001AA3 RID: 6819
			public float float_1;

			// Token: 0x04001AA4 RID: 6820
			public bool bool_3;
		}
	}
}
