using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using MoPhoGames.USpeak.Core;
using Newtonsoft.Json;
using ns161;
using ns185;
using ns241;
using ns277;
using ns425;
using ns451;
using ns459;
using Photon.Pun;
using Photon.Realtime;
using RealisticEyeMovements;
using RootMotion.FinalIK;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using VRC.Networking;
using VRC.SDKBase;

namespace ns482
{
	// Token: 0x0200037B RID: 891
	public class GClass185 : GClass130
	{
		// Token: 0x06004936 RID: 18742 RVA: 0x001150A8 File Offset: 0x001132A8
		private static bool smethod_0(LoadBalancingClient loadBalancingClient_0, ref byte byte_0, ref object object_0, ref RaiseEventOptions raiseEventOptions_0, ref SendOptions sendOptions_0)
		{
			if (byte_0 == 202)
			{
				if (GClass185.bool_9)
				{
					raiseEventOptions_0.field_Public_ReceiverGroup_0 = 2;
				}
				else
				{
					raiseEventOptions_0.field_Public_ReceiverGroup_0 = 0;
				}
			}
			bool flag = false;
			if (byte_0 == 4)
			{
				if (!GClass185.bool_3)
				{
					return !GClass185.bool_11;
				}
				flag = GClass185.bool_11;
			}
			else if (byte_0 == 5)
			{
				if (!GClass185.bool_3)
				{
					return !GClass185.bool_11;
				}
				flag = GClass185.bool_11;
			}
			else if (byte_0 == 7)
			{
				if (!GClass185.bool_3)
				{
					return !GClass185.bool_12;
				}
				flag = GClass185.bool_12;
			}
			else if (byte_0 == 201)
			{
				if (!GClass185.bool_3)
				{
					return !GClass185.bool_12;
				}
				flag = GClass185.bool_12;
			}
			else if (byte_0 == 206)
			{
				if (!GClass185.bool_3)
				{
					return !GClass185.bool_12;
				}
				flag = GClass185.bool_12;
			}
			bool result;
			if (!GClass185.bool_3)
			{
				result = !flag;
			}
			else
			{
				List<string> list;
				if (object_0 != null)
				{
					list = GClass84.smethod_46<object>(object_0, 0, 1, false, false, true, false, true);
				}
				else
				{
					list = new List<string>();
				}
				if (list.Count > 0)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Op",
						"Raise",
						"Event",
						"_",
						": ",
						byte_0.ToString(),
						", ("
					}), GClass70.Enum1.const_0);
					for (int i = 0; i < list.Count; i++)
					{
						GClass70.smethod_24(list[i], GClass70.Enum1.const_0);
					}
					GClass70.smethod_24("), " + raiseEventOptions_0.field_Public_ReceiverGroup_0.ToString() + ", " + sendOptions_0.DeliveryMode.ToString(), GClass70.Enum1.const_0);
				}
				else
				{
					string[] array = new string[11];
					array[0] = "Op";
					array[1] = "Raise";
					array[2] = "Event";
					array[3] = ": ";
					array[4] = byte_0.ToString();
					array[5] = ", (";
					int num = 6;
					List<string> list2 = list;
					array[num] = ((list2 != null) ? list2.ToString() : null);
					array[7] = "), ";
					array[8] = raiseEventOptions_0.field_Public_ReceiverGroup_0.ToString();
					array[9] = ", ";
					array[10] = sendOptions_0.DeliveryMode.ToString();
					GClass70.smethod_38(string.Concat(array), GClass70.Enum1.const_0);
				}
				result = !flag;
			}
			return result;
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00115330 File Offset: 0x00113530
		internal void method_2(bool bool_21)
		{
			this.method_10(bool_21);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00115344 File Offset: 0x00113544
		internal void method_3()
		{
			this.method_54();
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00115358 File Offset: 0x00113558
		internal void method_4()
		{
			this.method_3();
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x0011536C File Offset: 0x0011356C
		internal int method_5()
		{
			return this.list_3.Count;
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00115388 File Offset: 0x00113588
		private static bool smethod_1(LoadBalancingClient loadBalancingClient_0, ref int int_1, ref Hashtable hashtable_0, ref Hashtable hashtable_1, ref WebFlags webFlags_0)
		{
			return true;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00115398 File Offset: 0x00113598
		internal void method_6()
		{
			this.method_29();
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x001153AC File Offset: 0x001135AC
		internal void method_7(bool bool_21)
		{
			this.method_72(bool_21);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001153C0 File Offset: 0x001135C0
		internal void method_8(bool bool_21)
		{
			GClass62.gclass62_0.bool_1 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_5 = bool_21;
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x001153E4 File Offset: 0x001135E4
		private static void smethod_2(ref float float_6)
		{
			GClass185.float_5 = float_6;
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x001153F8 File Offset: 0x001135F8
		internal void method_9(short short_4)
		{
			this.method_35(short_4);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x0011540C File Offset: 0x0011360C
		private static bool smethod_3(ref int int_1)
		{
			bool result;
			try
			{
				if (GClass185.bool_4)
				{
					int_1 = (int)GClass185.short_1;
					GClass185.int_0 = int_1;
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00115450 File Offset: 0x00113650
		internal void method_10(bool bool_21)
		{
			GClass62.gclass62_0.bool_5 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_14 = bool_21;
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00115474 File Offset: 0x00113674
		internal void method_11(short short_4)
		{
			this.method_33(short_4);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x00115488 File Offset: 0x00113688
		internal void method_12(short short_4)
		{
			this.method_25(short_4);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x0011549C File Offset: 0x0011369C
		private static bool smethod_4(LoadBalancingClient loadBalancingClient_0, ref bool bool_21, ref bool bool_22)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"LoadBalancingClient",
				"_",
				"Op",
				"Leave",
				"Room",
				": ",
				bool_21.ToString(),
				", ",
				bool_22.ToString()
			}), GClass70.Enum1.const_0);
			return true;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x00115508 File Offset: 0x00113708
		internal void method_13(bool bool_21)
		{
			GClass185.bool_13 = bool_21;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0011551C File Offset: 0x0011371C
		internal void method_14(bool bool_21)
		{
			this.method_39(bool_21);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00115530 File Offset: 0x00113730
		internal void method_15(bool bool_21)
		{
			GClass62.gclass62_0.bool_9 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_19 = bool_21;
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00115554 File Offset: 0x00113754
		private static bool smethod_5(ref float float_6)
		{
			bool result;
			try
			{
				if (GClass185.bool_6)
				{
					GClass185.float_4 = ((float_6 == 0f) ? 0f : (1f / float_6));
					float_6 = ((GClass185.float_1 == 0f) ? 0f : (1f / GClass185.float_1));
					GClass185.float_5 = float_6;
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x001155CC File Offset: 0x001137CC
		internal void method_16(bool bool_21)
		{
			GClass62.gclass62_0.bool_0 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_4 = bool_21;
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001155F0 File Offset: 0x001137F0
		internal void method_17()
		{
			this.method_89();
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00115604 File Offset: 0x00113804
		internal IEnumerator method_18(float? nullable_0 = null, float float_6 = 1f)
		{
			GClass185.Class212 @class = new GClass185.Class212(0);
			@class.gclass185_0 = this;
			@class.nullable_0 = nullable_0;
			@class.float_0 = float_6;
			return @class;
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x0011562C File Offset: 0x0011382C
		internal void method_19(string string_1)
		{
			this.method_45(string_1);
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00115674 File Offset: 0x00113874
		internal void method_20(bool bool_21)
		{
			GClass62.gclass62_0.bool_3 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_7 = bool_21;
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00115698 File Offset: 0x00113898
		internal void method_21(bool bool_21)
		{
			GClass62.gclass62_0.bool_4 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_8 = bool_21;
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001156BC File Offset: 0x001138BC
		internal void method_22(short short_4)
		{
			this.method_88(short_4);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x001156D0 File Offset: 0x001138D0
		internal void method_23(bool bool_21)
		{
			this.method_31(bool_21);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x001156E4 File Offset: 0x001138E4
		internal void method_24(bool bool_21)
		{
			this.method_91(bool_21);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x001156F8 File Offset: 0x001138F8
		internal void method_25(short short_4)
		{
			this.method_55(short_4);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x0011570C File Offset: 0x0011390C
		internal void method_26()
		{
			GClass185.dateTime_0 = DateTime.Now;
			if (GClass84.bool_4)
			{
				if (Input.GetKey(305) && Input.GetKey(303))
				{
					if (Input.GetKeyDown(49))
					{
						GClass185.bool_0 = !GClass185.bool_0;
					}
					else if (Input.GetKeyDown(50))
					{
						GClass185.bool_16 = !GClass185.bool_16;
					}
					else if (Input.GetKeyDown(51))
					{
						GClass185.bool_17 = !GClass185.bool_17;
					}
					else if (Input.GetKeyDown(52))
					{
						GClass185.bool_3 = !GClass185.bool_3;
					}
					else if (Input.GetKeyDown(53))
					{
						GClass185.bool_1 = !GClass185.bool_1;
					}
					else if (Input.GetKeyDown(54))
					{
						GClass185.bool_2 = !GClass185.bool_2;
					}
				}
				if (Input.GetKeyDown(96) && (!Input.GetKey(306) && !Input.GetKey(304)))
				{
					try
					{
						GClass163.gclass29_245.method_39(!GClass185.bool_12, true);
					}
					catch
					{
						this.method_99(!GClass185.bool_12);
					}
				}
			}
			if (GClass185.bool_12)
			{
				FlatBufferNetworkSerializer flatBufferNetworkSerializer = GClass84.smethod_682();
				if (flatBufferNetworkSerializer)
				{
					flatBufferNetworkSerializer.enabled = false;
				}
			}
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00115858 File Offset: 0x00113A58
		internal void method_27(bool bool_21)
		{
			this.method_2(bool_21);
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x0011586C File Offset: 0x00113A6C
		private static bool smethod_6(LoadBalancingClient loadBalancingClient_0, ref string string_1, ref object object_0, ref bool bool_21)
		{
			string text = string.Concat(new string[]
			{
				"LoadBalancingClient",
				"_",
				"Op",
				"Web",
				"Rpc",
				": ",
				string_1,
				", "
			});
			if (object_0 != null)
			{
				string str = text;
				object obj = object_0;
				GClass70.smethod_38(str + ((obj != null) ? obj.ToString() : null) + ", " + bool_21.ToString(), GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38(text + "null" + ", " + bool_21.ToString(), GClass70.Enum1.const_0);
			}
			return true;
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00115910 File Offset: 0x00113B10
		internal IEnumerator method_28(float? nullable_0 = null, float float_6 = 1f)
		{
			GClass185.Class214 @class = new GClass185.Class214(0);
			@class.gclass185_0 = this;
			@class.nullable_0 = nullable_0;
			@class.float_0 = float_6;
			return @class;
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00115938 File Offset: 0x00113B38
		private static void smethod_7(ref int int_1)
		{
			GClass185.smethod_10(ref int_1);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x0011594C File Offset: 0x00113B4C
		internal void method_29()
		{
			for (int i = this.list_5.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(this.list_5[i]);
			}
			this.list_5.Clear();
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00115994 File Offset: 0x00113B94
		internal void method_30()
		{
			this.method_59();
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x001159A8 File Offset: 0x00113BA8
		internal void method_31(bool bool_21)
		{
			GClass62.gclass62_0.bool_10 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_20 = bool_21;
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001159CC File Offset: 0x00113BCC
		internal void method_32()
		{
			this.method_30();
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x001159E0 File Offset: 0x00113BE0
		internal void method_33(short short_4)
		{
			this.method_97(short_4);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x001159F4 File Offset: 0x00113BF4
		private static void smethod_8(ref float float_6)
		{
			GClass185.smethod_2(ref float_6);
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00115A08 File Offset: 0x00113C08
		internal void method_34(bool bool_21)
		{
			this.method_84(bool_21);
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00115A1C File Offset: 0x00113C1C
		internal void method_35(short short_4)
		{
			this.method_60(short_4);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00115A30 File Offset: 0x00113C30
		internal void method_36(bool bool_21)
		{
			this.method_86(bool_21);
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00115A44 File Offset: 0x00113C44
		internal void method_37()
		{
			for (int i = this.list_3.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(this.list_3[i]);
			}
			this.list_3.Clear();
			GClass155.bool_24 = false;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00115A90 File Offset: 0x00113C90
		internal void method_38(bool bool_21)
		{
			this.method_70(bool_21);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00115AA4 File Offset: 0x00113CA4
		public override void vmethod_9()
		{
			this.method_17();
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00115AB8 File Offset: 0x00113CB8
		internal void method_39(bool bool_21)
		{
			GClass62.gclass62_0.bool_6 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_15 = bool_21;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00115ADC File Offset: 0x00113CDC
		internal void method_40(bool bool_21)
		{
			this.method_13(bool_21);
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00115AF0 File Offset: 0x00113CF0
		internal void method_41(bool bool_21)
		{
			this.method_20(bool_21);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00115B04 File Offset: 0x00113D04
		internal void method_42(short short_4)
		{
			this.method_87(short_4);
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00115B18 File Offset: 0x00113D18
		internal IEnumerator method_43(float? nullable_0 = null, float float_6 = 1f)
		{
			GClass185.Class213 @class = new GClass185.Class213(0);
			@class.gclass185_0 = this;
			@class.nullable_0 = nullable_0;
			@class.float_0 = float_6;
			return @class;
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00115B40 File Offset: 0x00113D40
		internal void method_44(bool bool_21)
		{
			this.method_23(bool_21);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x0011667C File Offset: 0x0011487C
		internal void method_45(string string_1)
		{
			if (string.IsNullOrEmpty(string_1))
			{
				string_1 = GClass84.smethod_979();
			}
			if (GClass84.smethod_939(string_1))
			{
				GClass70.smethod_38("Invalid Instance ID!", GClass70.Enum1.const_0);
			}
			try
			{
				string text = "2371845348:34592";
				if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
				{
					text = "http" + "://" + text;
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(string.Concat(new string[]
				{
					text,
					"/",
					"Send",
					"Photon",
					"Bots",
					"/",
					GClass84.string_0,
					"/",
					string_1
				})).GetResponse();
				string text2 = string.Empty;
				try
				{
					if (httpWebResponse.StatusCode == HttpStatusCode.OK)
					{
						StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
						try
						{
							try
							{
								text2 = streamReader.ReadToEnd();
							}
							catch
							{
								GClass70.smethod_36(string.Concat(new string[]
								{
									"Error",
									" ",
									"While",
									" ",
									"Sending",
									" ",
									"Photon",
									" ",
									"Bots",
									": ",
									text2
								}), GClass70.Enum1.const_0);
							}
							goto IL_1FF;
						}
						finally
						{
							streamReader.Close();
						}
					}
					GClass70.smethod_36(string.Concat(new string[]
					{
						"Error",
						" ",
						"While",
						" ",
						"Sending",
						" ",
						"Photon",
						" ",
						"Bots",
						": ",
						httpWebResponse.StatusCode.ToString(),
						" ",
						new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()
					}), GClass70.Enum1.const_0);
					IL_1FF:;
				}
				catch
				{
					GClass70.smethod_36(string.Concat(new string[]
					{
						"Error",
						" ",
						"While",
						" ",
						"Sending",
						" ",
						"Photon",
						" ",
						"Bots",
						": ",
						text2
					}), GClass70.Enum1.const_0);
				}
				finally
				{
					httpWebResponse.Close();
				}
				if (!string.IsNullOrEmpty(text2))
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Photon",
						" ",
						"Bots",
						" ",
						"Response",
						": ",
						text2
					}), GClass70.Enum1.const_0);
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"While",
					" ",
					"Sending",
					" ",
					"Photon",
					" ",
					"Bots",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00116A44 File Offset: 0x00114C44
		private static bool smethod_9(LoadBalancingClient loadBalancingClient_0, ref AppSettings appSettings_0)
		{
			if (appSettings_0 != null)
			{
				GClass70.smethod_38("LoadBalancingClient_ConnectUsingSettings:", GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"App",
					"Id",
					"Voice",
					": ",
					appSettings_0.AppIdVoice
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("App" + "Version" + ": " + appSettings_0.AppVersion, GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Use",
					"Name",
					"Server",
					": ",
					appSettings_0.UseNameServer.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("Fixed" + "Region" + ": " + appSettings_0.FixedRegion, GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Best",
					"Region",
					"Summary",
					"From",
					"Storage",
					": ",
					appSettings_0.BestRegionSummaryFromStorage
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("Server" + ": " + appSettings_0.Server, GClass70.Enum1.const_0);
				GClass70.smethod_24("Port" + ": " + appSettings_0.Port.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("Proxy" + "Server" + ": " + appSettings_0.ProxyServer, GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Enable",
					"Protocol",
					"Fallback",
					": ",
					appSettings_0.EnableProtocolFallback.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("Auth" + "Mode" + ": " + appSettings_0.AuthMode.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Enable",
					"Lobby",
					"Statistics",
					": ",
					appSettings_0.EnableLobbyStatistics.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("Network" + "Logging" + ": " + appSettings_0.NetworkLogging.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Is",
					"Master",
					"Server",
					"Address",
					": ",
					appSettings_0.IsMasterServerAddress.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Is",
					"Best",
					"Region",
					": ",
					appSettings_0.IsBestRegion.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24("Protocol" + ": " + appSettings_0.Protocol.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"App",
					"Id",
					"Chat",
					": ",
					appSettings_0.AppIdChat
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Is",
					"Default",
					"Port",
					": ",
					appSettings_0.IsDefaultPort.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"Is",
					"Default",
					"Name",
					"Server",
					": ",
					appSettings_0.IsDefaultNameServer.ToString()
				}), GClass70.Enum1.const_0);
				GClass70.smethod_24(string.Concat(new string[]
				{
					"App",
					"Id",
					"Realtime",
					": ",
					appSettings_0.AppIdRealtime
				}), GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38("LoadBalancingClient_ConnectUsingSettings()", GClass70.Enum1.const_0);
			}
			return true;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00116E70 File Offset: 0x00115070
		internal void method_46()
		{
			this.method_37();
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00116E84 File Offset: 0x00115084
		public override void vmethod_10()
		{
			this.method_78();
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00116E98 File Offset: 0x00115098
		internal void method_47(string string_1)
		{
			this.method_79(string_1);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00116EAC File Offset: 0x001150AC
		internal void method_48(bool bool_21)
		{
			GClass185.bool_12 = bool_21;
			FlatBufferNetworkSerializer flatBufferNetworkSerializer = GClass84.smethod_682();
			if (flatBufferNetworkSerializer)
			{
				flatBufferNetworkSerializer.enabled = !bool_21;
			}
			if (this.gameObject_0)
			{
				Object.DestroyImmediate(this.gameObject_0, true);
			}
			GameObject gameObject = GClass84.smethod_1476();
			if (gameObject)
			{
				if (bool_21)
				{
					this.gameObject_0 = Object.Instantiate<GameObject>(gameObject);
					if (this.gameObject_0)
					{
						this.gameObject_0.SetActive(true);
						this.gameObject_0.transform.position = gameObject.transform.position;
						this.gameObject_0.transform.rotation = gameObject.transform.rotation;
						VRIK component = this.gameObject_0.GetComponent<VRIK>();
						if (component)
						{
							Object.DestroyImmediate(component);
						}
						FullBodyBipedIK component2 = this.gameObject_0.GetComponent<FullBodyBipedIK>();
						if (component2)
						{
							Object.DestroyImmediate(component2);
						}
						LimbIK component3 = this.gameObject_0.GetComponent<LimbIK>();
						if (component3)
						{
							Object.DestroyImmediate(component3);
						}
						EyeAndHeadAnimator component4 = this.gameObject_0.GetComponent<EyeAndHeadAnimator>();
						if (component4)
						{
							Object.DestroyImmediate(component4);
						}
						GameObject gameObject2 = GClass84.smethod_435(this.gameObject_0, "HmdPivot");
						if (gameObject2)
						{
							Transform transform = gameObject2.transform;
							if ((transform != null) ? transform.parent : null)
							{
								gameObject2.transform.parent.localScale = new Vector3(1f, 1f, 1f);
							}
						}
						GClass84.smethod_281(this.gameObject_0);
					}
				}
				gameObject.SetActive(!bool_21);
			}
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00117048 File Offset: 0x00115248
		internal void method_49()
		{
			GClass155.bool_24 = true;
			this.list_3.Add(MelonCoroutines.Start(this.method_18(null, 1f)));
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00117080 File Offset: 0x00115280
		internal void method_50(short short_4)
		{
			GClass62.gclass62_0.short_1 = short_4;
			GClass62.smethod_2();
			GClass185.short_2 = short_4;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x001170A4 File Offset: 0x001152A4
		internal void method_51()
		{
			this.method_100();
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x001170B8 File Offset: 0x001152B8
		private static void smethod_10(ref int int_1)
		{
			GClass185.int_0 = int_1;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x001170CC File Offset: 0x001152CC
		internal void method_52(bool bool_21)
		{
			this.method_98(bool_21);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x001170E0 File Offset: 0x001152E0
		internal void method_53(bool bool_21)
		{
			this.method_75(bool_21);
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x001170F4 File Offset: 0x001152F4
		internal void method_54()
		{
			this.list_5.Add(MelonCoroutines.Start(this.method_28(null, 1f)));
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00117128 File Offset: 0x00115328
		internal void method_55(short short_4)
		{
			GClass62.gclass62_0.float_1 = (float)short_4;
			GClass62.smethod_2();
			GClass185.float_2 = (float)short_4;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00117150 File Offset: 0x00115350
		internal void method_56()
		{
			this.method_6();
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00117164 File Offset: 0x00115364
		public override void vmethod_8(int int_1)
		{
			this.method_63(int_1);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x00117178 File Offset: 0x00115378
		internal void method_57()
		{
			this.method_26();
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0011718C File Offset: 0x0011538C
		internal void method_58(bool bool_21)
		{
			this.method_83(bool_21);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001171A0 File Offset: 0x001153A0
		private static bool smethod_11(LoadBalancingClient loadBalancingClient_0, ref EventData eventData_0)
		{
			bool result;
			if (eventData_0 == null)
			{
				result = false;
			}
			else
			{
				object obj = GClass84.smethod_308<object>(eventData_0.CustomData);
				bool flag = false;
				if (GClass185.bool_15)
				{
					if (eventData_0.Code != 2 && eventData_0.Code != 33 && eventData_0.Code != 202 && eventData_0.Code != 254 && eventData_0.Code != 255 && (DateTime.Now - GClass185.dateTime_0).TotalMilliseconds > (double)1000f)
					{
						if (!GClass185.bool_0)
						{
							return false;
						}
						flag = true;
					}
					if (!flag && obj != null)
					{
						byte[] array = obj as byte[];
						if (array != null)
						{
							for (int i = 0; i < GClass185.list_1.Count; i++)
							{
								if (eventData_0.Code == GClass185.list_1[i].byte_0 && array.Length == GClass185.list_1[i].int_0)
								{
									if (GClass185.list_1[i].int_0 == GClass185.list_1[i].byte_1.Length)
									{
										int num = 0;
										while (num < GClass185.list_1[i].byte_1.Length && array[num] == GClass185.list_1[i].byte_1[num])
										{
											num++;
										}
										if (num == GClass185.list_1[i].byte_1.Length)
										{
											return false;
										}
									}
									else
									{
										int num = GClass185.list_1[i].byte_1.Length;
										while (num > 0 && array[array.Length - num] == GClass185.list_1[i].byte_1[GClass185.list_1[i].byte_1.Length - num])
										{
											num--;
										}
										if (num == 0)
										{
											return false;
										}
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (eventData_0.Code != 1)
					{
						for (int j = 0; j < GClass93.list_3.Count; j++)
						{
							if (GClass93.list_3[j].int_0 == eventData_0.Sender)
							{
								GClass93.Struct19 value = GClass93.list_3[j];
								value.int_1 = GClass84.smethod_1395();
								GClass93.list_3[j] = value;
								break;
							}
						}
					}
					if (GClass185.bool_17)
					{
						if (!GClass185.bool_0)
						{
							return false;
						}
						flag = true;
					}
					else if (eventData_0.Code == 1)
					{
						if (!string.IsNullOrEmpty(GClass84.gclass148_0.string_5) && GClass84.smethod_538(GClass84.smethod_1430(eventData_0.Sender)) == GClass84.gclass148_0.string_5 && obj != null)
						{
							byte[] array2 = obj as byte[];
							if (array2 != null)
							{
								byte[] bytes = BitConverter.GetBytes(Networking.LocalPlayer.playerId);
								Buffer.BlockCopy(bytes, 0, array2, 0, 4);
								GClass84.smethod_1375(1, array2, new RaiseEventOptions
								{
									field_Public_ReceiverGroup_0 = 0,
									field_Public_Byte_0 = 1,
									field_Public_Byte_1 = 1
								}, SendOptions.SendUnreliable);
							}
						}
						if (GClass185.bool_10)
						{
							if (!GClass185.bool_0)
							{
								return false;
							}
							flag = true;
						}
						if (GClass185.bool_19 && GClass185.smethod_16(eventData_0))
						{
							if (!GClass185.bool_0)
							{
								return false;
							}
							flag = true;
						}
					}
					else if (eventData_0.Code == 6)
					{
						if (GClass185.bool_14)
						{
							if (!GClass185.bool_0)
							{
								return false;
							}
							flag = true;
						}
					}
					else if (eventData_0.Code == 7)
					{
						if (!string.IsNullOrEmpty(GClass84.gclass148_0.string_6) && GClass84.smethod_538(GClass84.smethod_1430(eventData_0.Sender)) == GClass84.gclass148_0.string_6 && obj != null)
						{
							byte[] array3 = obj as byte[];
							if (array3 != null && array3.Length > 60)
							{
								int value2 = int.Parse(Networking.LocalPlayer.playerId.ToString() + "00001");
								byte[] bytes2 = BitConverter.GetBytes(value2);
								Buffer.BlockCopy(bytes2, 0, array3, 0, 4);
								byte[] array4 = new byte[12];
								Transform transform = GClass84.smethod_981();
								Buffer.BlockCopy(BitConverter.GetBytes(transform.position.x), 0, array4, 0, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(transform.position.y), 0, array4, 4, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(transform.position.z), 0, array4, 8, 4);
								Buffer.BlockCopy(array4, 0, array3, 48, 12);
								GClass84.smethod_1375(7, array3, new RaiseEventOptions
								{
									field_Public_ReceiverGroup_0 = 0,
									field_Public_EventCaching_0 = 0
								}, default(SendOptions));
							}
						}
						if (GClass185.bool_13)
						{
							if (!GClass185.bool_0)
							{
								return false;
							}
							flag = true;
						}
						if (!flag && GClass185.bool_20 && obj != null)
						{
							byte[] array5 = obj as byte[];
							if (array5 != null)
							{
								if (array5.Length == 44)
								{
									Vector3 vector = GClass84.smethod_1388(array5, 24);
									if (vector.x > 1000000f || vector.y > 1000000f || vector.z > 1000000f)
									{
										Buffer.BlockCopy(GClass84.smethod_1253(new Vector3(0f, 0f, 0f)), 0, array5, 24, 12);
										eventData_0.customData = GClass84.smethod_917<Object>(array5);
									}
								}
								else if (array5.Length == 204)
								{
									Vector3 vector2 = GClass84.smethod_1388(array5, 48);
									if (vector2.x > 1000000f || vector2.y > 1000000f || vector2.z > 1000000f)
									{
										Buffer.BlockCopy(GClass84.smethod_1253(new Vector3(0f, 0f, 0f)), 0, array5, 48, 12);
										eventData_0.customData = GClass84.smethod_917<Object>(array5);
									}
								}
							}
						}
					}
					if (eventData_0.Code == 33)
					{
						try
						{
							if (obj != null)
							{
								byte? b = null;
								int? num2 = null;
								bool? flag2 = null;
								bool flag3 = false;
								bool flag4 = false;
								Dictionary<byte, object> dictionary = obj as Dictionary<byte, object>;
								if (dictionary != null)
								{
									foreach (byte b2 in dictionary.Keys)
									{
										if (b2 == 0)
										{
											object obj2 = dictionary[b2];
											byte b3;
											bool flag5;
											if (obj2 is byte)
											{
												b3 = (byte)obj2;
												flag5 = true;
											}
											else
											{
												flag5 = false;
											}
											if (flag5 && b3 == 21)
											{
												b = new byte?(b3);
											}
										}
										else if (b2 == 1)
										{
											object obj3 = dictionary[b2];
											int value3;
											bool flag6;
											if (obj3 is int)
											{
												value3 = (int)obj3;
												flag6 = true;
											}
											else
											{
												flag6 = false;
											}
											if (flag6)
											{
												num2 = new int?(value3);
											}
										}
										else if (b2 == 10)
										{
											object obj4 = dictionary[b2];
											bool flag7;
											bool flag8;
											if (obj4 is bool)
											{
												flag7 = (bool)obj4;
												flag8 = true;
											}
											else
											{
												flag8 = false;
											}
											if (flag8)
											{
												if (flag7)
												{
													flag3 = true;
												}
												else
												{
													flag4 = true;
												}
											}
										}
										else if (b2 == 11)
										{
											object obj5 = dictionary[b2];
											bool value4;
											bool flag9;
											if (obj5 is bool)
											{
												value4 = (bool)obj5;
												flag9 = true;
											}
											else
											{
												flag9 = false;
											}
											if (flag9)
											{
												flag2 = new bool?(value4);
											}
										}
									}
								}
								if (num2 != null)
								{
									bool flag11;
									if (b != null)
									{
										byte? b4 = b;
										int? num3 = (b4 != null) ? new int?((int)b4.GetValueOrDefault()) : null;
										if ((num3.GetValueOrDefault() == 21 & num3 != null) && flag2 != null)
										{
											bool? flag10 = flag2;
											flag11 = (!flag10.GetValueOrDefault() & flag10 != null);
											goto IL_81A;
										}
									}
									flag11 = false;
									IL_81A:
									if (flag11)
									{
										if (flag3)
										{
											GClass84.gclass93_0.method_89(num2.Value);
											if (GClass185.bool_18)
											{
												return false;
											}
										}
										else if (flag4)
										{
											GClass84.gclass93_0.method_130(num2.Value);
										}
									}
								}
							}
						}
						catch
						{
						}
					}
				}
				if (!GClass185.bool_0)
				{
				}
				if (!GClass185.bool_0)
				{
					for (int k = 0; k < GClass185.list_0.Count; k++)
					{
						if (eventData_0.Code == GClass185.list_0[k])
						{
							return !flag;
						}
					}
					if (eventData_0.Code == 255)
					{
						return !flag;
					}
					if (eventData_0.Code == 254)
					{
						return !flag;
					}
					if (eventData_0.Code == 3)
					{
						return !flag;
					}
					if (eventData_0.Code == 4)
					{
						return !flag;
					}
					if (eventData_0.Code == 5)
					{
						return !flag;
					}
					if (eventData_0.Code == 6)
					{
						if (!GClass185.bool_1)
						{
							return !flag;
						}
					}
					else if (eventData_0.Code == 42)
					{
						return !flag;
					}
				}
				if (GClass185.bool_2)
				{
					string text;
					if (obj != null)
					{
						text = obj.ToString();
					}
					else
					{
						text = string.Empty;
					}
					GClass70.smethod_38(string.Concat(new string[]
					{
						"On",
						"Event",
						": (",
						eventData_0.Code.ToString(),
						", "
					}), GClass70.Enum1.const_0);
					GClass70.smethod_24(JsonConvert.SerializeObject(obj, 1), GClass70.Enum1.const_0);
					GClass70.smethod_24(string.Concat(new string[]
					{
						", ",
						eventData_0.SenderKey.ToString(),
						", ",
						eventData_0.sender.ToString(),
						", ",
						eventData_0.CustomDataKey.ToString(),
						", ",
						text,
						")"
					}), GClass70.Enum1.const_0);
				}
				else
				{
					List<string> list;
					if (obj != null)
					{
						list = GClass84.smethod_46<object>(obj, 0, 1, false, false, true, false, true);
					}
					else
					{
						list = new List<string>();
					}
					string text2;
					if (obj != null)
					{
						text2 = obj.ToString();
					}
					else
					{
						text2 = string.Empty;
					}
					if (list.Count > 0)
					{
						GClass70.smethod_38(string.Concat(new string[]
						{
							"On",
							"Event",
							": (",
							eventData_0.Code.ToString(),
							", "
						}), GClass70.Enum1.const_0);
						for (int l = 0; l < list.Count; l++)
						{
							GClass70.smethod_24(list[l], GClass70.Enum1.const_0);
						}
						GClass70.smethod_24(string.Concat(new string[]
						{
							", ",
							eventData_0.SenderKey.ToString(),
							", ",
							eventData_0.sender.ToString(),
							", ",
							eventData_0.CustomDataKey.ToString(),
							", ",
							eventData_0.Sender.ToString(),
							", ",
							text2,
							")"
						}), GClass70.Enum1.const_0);
					}
					else
					{
						GClass70.smethod_38(string.Concat(new string[]
						{
							"On",
							"Event",
							": (",
							eventData_0.Code.ToString(),
							", ",
							"Null",
							", ",
							eventData_0.SenderKey.ToString(),
							", ",
							eventData_0.sender.ToString(),
							", ",
							eventData_0.CustomDataKey.ToString(),
							", ",
							eventData_0.Sender.ToString(),
							", ",
							text2,
							")"
						}), GClass70.Enum1.const_0);
					}
				}
				result = !flag;
			}
			return result;
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00117E54 File Offset: 0x00116054
		internal void method_59()
		{
			for (int i = this.list_4.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(this.list_4[i]);
			}
			this.list_4.Clear();
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00117E9C File Offset: 0x0011609C
		internal void method_60(short short_4)
		{
			GClass62.gclass62_0.float_2 = (float)short_4;
			GClass62.smethod_2();
			GClass185.float_3 = (float)short_4;
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00117EC4 File Offset: 0x001160C4
		internal void method_61(short short_4)
		{
			this.method_82(short_4);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x00117ED8 File Offset: 0x001160D8
		public virtual void vmethod_26(string string_1)
		{
			this.method_47(string_1);
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00117EEC File Offset: 0x001160EC
		internal void method_62(string string_1 = "")
		{
			this.method_19(string_1);
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00117F00 File Offset: 0x00116100
		internal void method_63(int int_1)
		{
			this.method_81(int_1);
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00117F14 File Offset: 0x00116114
		internal void method_64(short short_4)
		{
			GClass62.gclass62_0.short_2 = short_4;
			GClass62.smethod_2();
			GClass185.short_3 = short_4;
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00117F38 File Offset: 0x00116138
		internal void method_65(bool bool_21)
		{
			this.method_24(bool_21);
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00117F4C File Offset: 0x0011614C
		internal void method_66(bool bool_21)
		{
			GClass185.bool_11 = bool_21;
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x00117F60 File Offset: 0x00116160
		internal void method_67()
		{
			this.method_76();
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x00117F74 File Offset: 0x00116174
		private static bool smethod_12(LoadBalancingClient loadBalancingClient_0, ref string string_1, ref int int_1, ref bool bool_21, ref Hashtable hashtable_0)
		{
			return true;
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00117F84 File Offset: 0x00116184
		internal void method_68()
		{
			this.method_67();
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00117F98 File Offset: 0x00116198
		internal void method_69(bool bool_21)
		{
			this.method_14(bool_21);
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00117FAC File Offset: 0x001161AC
		internal void method_70(bool bool_21)
		{
			this.method_16(bool_21);
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00117FC0 File Offset: 0x001161C0
		internal int method_71()
		{
			return this.list_5.Count;
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00117FDC File Offset: 0x001161DC
		internal void method_72(bool bool_21)
		{
			GClass62.gclass62_0.bool_7 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_18 = bool_21;
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x00118000 File Offset: 0x00116200
		internal void method_73()
		{
			this.method_85();
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00118014 File Offset: 0x00116214
		internal void method_74()
		{
			this.method_46();
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00118028 File Offset: 0x00116228
		internal void method_75(bool bool_21)
		{
			this.method_93(bool_21);
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x0011803C File Offset: 0x0011623C
		private static void smethod_13(ref float float_6)
		{
			GClass185.smethod_8(ref float_6);
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00118050 File Offset: 0x00116250
		internal void method_76()
		{
			this.list_4.Add(MelonCoroutines.Start(this.method_43(null, 1f)));
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00118084 File Offset: 0x00116284
		internal void method_77()
		{
			if (GClass185.bool_4)
			{
				if (GClass185.bool_5)
				{
					GClass185.short_1 = (short)((int)GClass185.short_2 + GClass84.smethod_1673((int)(GClass185.short_3 - GClass185.short_2)));
				}
				else
				{
					GClass185.short_1 = GClass185.short_0;
				}
			}
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x001180C8 File Offset: 0x001162C8
		private static void smethod_14(ref int int_1)
		{
			GClass185.smethod_7(ref int_1);
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x001180DC File Offset: 0x001162DC
		internal void method_78()
		{
			this.method_77();
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00055450 File Offset: 0x00053650
		internal void method_79(string string_1)
		{
			if (!(string_1 == string.Empty))
			{
			}
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x001180F0 File Offset: 0x001162F0
		internal void method_80(bool bool_21)
		{
			this.method_7(bool_21);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00118104 File Offset: 0x00116304
		internal void method_81(int int_1)
		{
			if (this.gameObject_0)
			{
				Object.DestroyImmediate(this.gameObject_0, true);
			}
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x0011812C File Offset: 0x0011632C
		internal void method_82(short short_4)
		{
			this.method_50(short_4);
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00118140 File Offset: 0x00116340
		internal void method_83(bool bool_21)
		{
			this.method_21(bool_21);
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00118154 File Offset: 0x00116354
		internal void method_84(bool bool_21)
		{
			this.method_15(bool_21);
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00118168 File Offset: 0x00116368
		internal void method_85()
		{
			this.method_49();
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x0011817C File Offset: 0x0011637C
		internal void method_86(bool bool_21)
		{
			this.method_66(bool_21);
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00118190 File Offset: 0x00116390
		private static HarmonyMethod smethod_15(string string_1)
		{
			return new HarmonyMethod(typeof(GClass185).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x001181B8 File Offset: 0x001163B8
		internal void method_87(short short_4)
		{
			this.method_64(short_4);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x001181CC File Offset: 0x001163CC
		internal void method_88(short short_4)
		{
			this.method_90(short_4);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x001181E0 File Offset: 0x001163E0
		internal void method_89()
		{
			if (GClass185.bool_6)
			{
				if (GClass185.bool_7)
				{
					if (GClass185.bool_8)
					{
						GClass185.float_1 = GClass185.float_2 + (GClass185.float_3 - GClass185.float_2) * GClass84.smethod_790() + GClass185.float_4 * 0.2f;
					}
					else
					{
						GClass185.float_1 = GClass185.float_2 + (GClass185.float_3 - GClass185.float_2) * GClass84.smethod_790();
					}
				}
				else if (GClass185.bool_8)
				{
					GClass185.float_1 = GClass185.float_0 + GClass185.float_4 * 0.2f;
				}
				else
				{
					GClass185.float_1 = GClass185.float_0;
				}
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00118274 File Offset: 0x00116474
		public override void vmethod_23()
		{
			this.method_51();
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00118288 File Offset: 0x00116488
		internal void method_90(short short_4)
		{
			GClass62.gclass62_0.float_0 = (float)short_4;
			GClass62.smethod_2();
			GClass185.float_0 = (float)short_4;
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x001182B0 File Offset: 0x001164B0
		internal void method_91(bool bool_21)
		{
			GClass62.gclass62_0.bool_8 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_10 = bool_21;
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x001182D4 File Offset: 0x001164D4
		public override void vmethod_19()
		{
			this.method_57();
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x001182E8 File Offset: 0x001164E8
		internal static bool smethod_16(EventData eventData_0)
		{
			byte[] array = Il2CppArrayBase<byte>.WrapNativeGenericArrayPointer(eventData_0.CustomData.Pointer);
			int num = BitConverter.ToInt32(array, 0);
			bool result;
			if (num != eventData_0.Sender)
			{
				result = true;
			}
			else
			{
				int i = 4;
				byte[] array2 = array.Skip(4).ToArray<byte>();
				while (i < array2.Length)
				{
					USpeakFrameContainer uspeakFrameContainer = new USpeakFrameContainer();
					int num2 = GClass185.delegate46_0(uspeakFrameContainer, array2, i);
					if (num2 == -1)
					{
						return true;
					}
					uspeakFrameContainer.Method_Public_Virtual_Final_New_Void_0();
					i += num2;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00118378 File Offset: 0x00116578
		internal void method_92(bool bool_21)
		{
			this.method_40(bool_21);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x0011838C File Offset: 0x0011658C
		internal void method_93(bool bool_21)
		{
			GClass62.gclass62_0.bool_2 = bool_21;
			GClass62.smethod_2();
			GClass185.bool_6 = bool_21;
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001183B0 File Offset: 0x001165B0
		internal void method_94(bool bool_21)
		{
			this.method_41(bool_21);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x001183C4 File Offset: 0x001165C4
		internal int method_95()
		{
			return this.list_4.Count;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x001183E0 File Offset: 0x001165E0
		internal void method_96(bool bool_21)
		{
			this.method_48(bool_21);
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x001183F4 File Offset: 0x001165F4
		internal void method_97(short short_4)
		{
			GClass62.gclass62_0.short_0 = short_4;
			GClass62.smethod_2();
			GClass185.short_0 = short_4;
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00118418 File Offset: 0x00116618
		internal void method_98(bool bool_21)
		{
			this.method_8(bool_21);
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x0011842C File Offset: 0x0011662C
		internal void method_99(bool bool_21)
		{
			this.method_96(bool_21);
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00118440 File Offset: 0x00116640
		internal void method_100()
		{
			GClass84.list_1.Add(new Action<int>(this.vmethod_8));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_5.Add(new Action(this.vmethod_9));
			GClass84.list_15.Add(new Action<string, List<string>>(this.vmethod_17));
			try
			{
				GClass62.smethod_4();
				GClass185.bool_4 = GClass62.gclass62_0.bool_0;
				GClass185.bool_5 = GClass62.gclass62_0.bool_1;
				GClass185.short_0 = GClass62.gclass62_0.short_0;
				GClass185.short_2 = GClass62.gclass62_0.short_1;
				GClass185.short_3 = GClass62.gclass62_0.short_2;
				GClass185.short_1 = GClass185.short_0;
				GClass185.bool_6 = GClass62.gclass62_0.bool_2;
				GClass185.bool_7 = GClass62.gclass62_0.bool_3;
				GClass185.bool_8 = GClass62.gclass62_0.bool_4;
				GClass185.float_0 = GClass62.gclass62_0.float_0;
				GClass185.float_2 = GClass62.gclass62_0.float_1;
				GClass185.float_3 = GClass62.gclass62_0.float_2;
				GClass185.float_1 = GClass185.float_0;
				GClass185.bool_14 = GClass62.gclass62_0.bool_5;
				GClass185.bool_15 = GClass62.gclass62_0.bool_6;
				GClass185.bool_18 = GClass62.gclass62_0.bool_7;
				GClass185.bool_10 = GClass62.gclass62_0.bool_8;
				GClass185.bool_19 = GClass62.gclass62_0.bool_9;
				GClass185.bool_20 = GClass62.gclass62_0.bool_10;
				GClass185.delegate46_0 = (GClass185.Delegate46)Delegate.CreateDelegate(typeof(GClass185.Delegate46), typeof(USpeakFrameContainer).GetMethods().Single(new Func<MethodInfo, bool>(GClass185.Class211.class211_0.method_4)));
				GClass84.smethod_405(typeof(PhotonPeer), "RoundTripTime", GClass185.smethod_15("FakePingPatch"), GClass185.smethod_15("FakePingPatch_Post"), null);
				GClass84.smethod_405(typeof(Time), "smoothDeltaTime", GClass185.smethod_15("FakeFPSPatch"), GClass185.smethod_15("FakeFPSPatch_Post"), null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "Method_Public_Virtual_New_Boolean_AppSettings_0", GClass185.smethod_15("LoadBalancingClient_ConnectUsingSettings"), null, null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "Method_Public_Boolean_Boolean_Boolean_0", GClass185.smethod_15("LoadBalancingClient_OpLeaveRoom"), null, null);
				GClass84.smethod_799(typeof(PhotonNetwork), "Method_Public_Static_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0", GClass185.smethod_15("LoadBalancingClient_OpRaiseEvent"), null, null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "Method_FamOrAssem_Virtual_New_Player_String_Int32_Boolean_Hashtable_0", GClass185.smethod_15("LoadBalancingClient_CreatePlayer"), null, null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "Method_FamOrAssem_Boolean_Int32_Hashtable_Hashtable_WebFlags_0", GClass185.smethod_15("LoadBalancingClient_OpSetPropertiesOfActor"), null, null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "Method_Public_Boolean_String_Object_Boolean_PDM_0", GClass185.smethod_15("LoadBalancingClient_OpWebRpc"), null, null);
				GClass84.smethod_799(typeof(LoadBalancingClient), "OnEvent", GClass185.smethod_15("LoadBalancingClient_OnEvent"), null, null);
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x04001C4B RID: 7243
		internal static bool bool_0 = false;

		// Token: 0x04001C4C RID: 7244
		internal static bool bool_1 = false;

		// Token: 0x04001C4D RID: 7245
		internal static bool bool_2 = false;

		// Token: 0x04001C4E RID: 7246
		internal static bool bool_3 = false;

		// Token: 0x04001C4F RID: 7247
		internal static bool bool_4 = false;

		// Token: 0x04001C50 RID: 7248
		internal static bool bool_5 = true;

		// Token: 0x04001C51 RID: 7249
		internal static short short_0 = 600;

		// Token: 0x04001C52 RID: 7250
		internal static short short_1 = 0;

		// Token: 0x04001C53 RID: 7251
		internal static short short_2 = 600;

		// Token: 0x04001C54 RID: 7252
		internal static short short_3 = 800;

		// Token: 0x04001C55 RID: 7253
		internal static bool bool_6 = false;

		// Token: 0x04001C56 RID: 7254
		internal static bool bool_7 = true;

		// Token: 0x04001C57 RID: 7255
		internal static bool bool_8 = true;

		// Token: 0x04001C58 RID: 7256
		internal static float float_0 = 100f;

		// Token: 0x04001C59 RID: 7257
		internal static float float_1 = 0f;

		// Token: 0x04001C5A RID: 7258
		internal static float float_2 = 100f;

		// Token: 0x04001C5B RID: 7259
		internal static float float_3 = 180f;

		// Token: 0x04001C5C RID: 7260
		internal static float float_4 = 0f;

		// Token: 0x04001C5D RID: 7261
		internal static bool bool_9 = false;

		// Token: 0x04001C5E RID: 7262
		internal static bool bool_10 = false;

		// Token: 0x04001C5F RID: 7263
		internal static bool bool_11 = false;

		// Token: 0x04001C60 RID: 7264
		internal static bool bool_12 = false;

		// Token: 0x04001C61 RID: 7265
		private GameObject gameObject_0;

		// Token: 0x04001C62 RID: 7266
		internal static bool bool_13 = false;

		// Token: 0x04001C63 RID: 7267
		internal static bool bool_14 = false;

		// Token: 0x04001C64 RID: 7268
		internal static bool bool_15 = true;

		// Token: 0x04001C65 RID: 7269
		internal static bool bool_16 = false;

		// Token: 0x04001C66 RID: 7270
		internal static bool bool_17 = false;

		// Token: 0x04001C67 RID: 7271
		private static DateTime dateTime_0 = DateTime.Now;

		// Token: 0x04001C68 RID: 7272
		internal static bool bool_18 = false;

		// Token: 0x04001C69 RID: 7273
		internal static bool bool_19 = true;

		// Token: 0x04001C6A RID: 7274
		internal static bool bool_20 = true;

		// Token: 0x04001C6B RID: 7275
		internal static Dictionary<byte, string> dictionary_0 = new Dictionary<byte, string>
		{
			{
				0,
				"OpRemoveCache etc..."
			},
			{
				1,
				"USpeaker Voice Data"
			},
			{
				2,
				"Disconnect Message"
			},
			{
				4,
				"Cached Events"
			},
			{
				5,
				"Master allowing player to join"
			},
			{
				6,
				"RPC"
			},
			{
				7,
				"Unreliable"
			},
			{
				9,
				"Reliable"
			},
			{
				33,
				"Moderations"
			},
			{
				200,
				"OpCleanRpcBuffer (int actorNumber)"
			},
			{
				202,
				"Instantiation of VRCPlayer"
			},
			{
				203,
				"CloseConnection(PhotonPlayer kickPlayer)"
			},
			{
				204,
				"Destroy ??"
			},
			{
				206,
				"Movement?"
			},
			{
				207,
				"SendDestroy all Or Player ?"
			},
			{
				208,
				"SetMasterClient(int playerId, bool sync)"
			},
			{
				209,
				"Request Ownership"
			},
			{
				210,
				"Transfer Ownership"
			},
			{
				254,
				"Leaving World"
			},
			{
				byte.MaxValue,
				"Joining World"
			}
		};

		// Token: 0x04001C6C RID: 7276
		internal static Dictionary<byte, string> dictionary_1 = new Dictionary<byte, string>
		{
			{
				210,
				"AzureNodeInfo"
			},
			{
				223,
				"AuthEvent"
			},
			{
				224,
				"LobbyStats"
			},
			{
				226,
				"AppStats"
			},
			{
				227,
				"Match"
			},
			{
				228,
				"QueueState"
			},
			{
				229,
				"GameListUpdate"
			},
			{
				230,
				"GameList"
			},
			{
				250,
				"CacheSliceChanged"
			},
			{
				251,
				"ErrorInfo"
			},
			{
				253,
				"PropertiesChanged"
			},
			{
				254,
				"Leave"
			},
			{
				byte.MaxValue,
				"Join"
			}
		};

		// Token: 0x04001C6D RID: 7277
		internal static Dictionary<byte, string> dictionary_2 = new Dictionary<byte, string>
		{
			{
				217,
				"GetGameList"
			},
			{
				218,
				"ServerSettings"
			},
			{
				219,
				"WebRpc"
			},
			{
				220,
				"GetRegions"
			},
			{
				221,
				"GetLobbyStats"
			},
			{
				222,
				"FindFriends"
			},
			{
				225,
				"JoinRandomGame"
			},
			{
				226,
				"JoinGame"
			},
			{
				227,
				"CreateGame"
			},
			{
				228,
				"LeaveLobby"
			},
			{
				229,
				"JoinLobby"
			},
			{
				230,
				"Authenticate"
			},
			{
				231,
				"AuthenticateOnce"
			},
			{
				248,
				"ChangeGroups"
			},
			{
				250,
				"ExchangeKeysForEncryption"
			},
			{
				251,
				"GetProperties"
			},
			{
				252,
				"SetProperties"
			},
			{
				253,
				"RaiseEvent"
			},
			{
				254,
				"Leave"
			},
			{
				byte.MaxValue,
				"Join"
			}
		};

		// Token: 0x04001C6E RID: 7278
		internal static Dictionary<string, byte> dictionary_3 = new Dictionary<string, byte>
		{
			{
				"SuppressRoomEvents",
				237
			},
			{
				"EmptyRoomTTL",
				236
			},
			{
				"PlayerTTL",
				235
			},
			{
				"EventForward",
				234
			},
			{
				"IsComingBack",
				233
			},
			{
				"IsInactive",
				233
			},
			{
				"CheckUserOnJoin",
				232
			},
			{
				"ExpectedValues",
				231
			},
			{
				"Address",
				230
			},
			{
				"PeerCount",
				229
			},
			{
				"GameCount",
				228
			},
			{
				"MasterPeerCount",
				227
			},
			{
				"UserId",
				225
			},
			{
				"ApplicationId",
				224
			},
			{
				"Position",
				223
			},
			{
				"GameList",
				222
			},
			{
				"Secret",
				221
			},
			{
				"AppVersion",
				220
			},
			{
				"AzureNodeInfo",
				210
			},
			{
				"AzureLocalNodeId",
				209
			},
			{
				"AzureMasterNodeId",
				208
			},
			{
				"RoomName",
				byte.MaxValue
			},
			{
				"Broadcast",
				250
			},
			{
				"ActorList",
				252
			},
			{
				"ActorNr",
				254
			},
			{
				"PlayerProperties",
				249
			},
			{
				"CustomEventContent",
				245
			},
			{
				"Data",
				245
			},
			{
				"Code",
				244
			},
			{
				"GameProperties",
				248
			},
			{
				"Properties",
				251
			},
			{
				"TargetActorNr",
				253
			},
			{
				"ReceiverGroup",
				246
			},
			{
				"Cache",
				247
			},
			{
				"CleanupCacheOnLeave",
				241
			},
			{
				"Group",
				240
			},
			{
				"Remove",
				239
			},
			{
				"PublishUserId",
				239
			},
			{
				"Add",
				238
			},
			{
				"Info",
				218
			},
			{
				"ClientAuthenticationType",
				217
			},
			{
				"ClientAuthenticationParams",
				216
			},
			{
				"JoinMode",
				215
			},
			{
				"ClientAuthenticationData",
				214
			},
			{
				"MasterClientId",
				203
			},
			{
				"FindFriendsRequestList",
				1
			},
			{
				"FindFriendsOptions",
				2
			},
			{
				"FindFriendsResponseOnlineList",
				1
			},
			{
				"FindFriendsResponseRoomIdList",
				2
			},
			{
				"LobbyName",
				213
			},
			{
				"LobbyType",
				212
			},
			{
				"LobbyStats",
				211
			},
			{
				"Region",
				210
			},
			{
				"UriPath",
				209
			},
			{
				"WebRpcParameters",
				208
			},
			{
				"WebRpcReturnCode",
				207
			},
			{
				"WebRpcReturnMessage",
				206
			},
			{
				"CacheSliceIndex",
				205
			},
			{
				"Plugins",
				204
			},
			{
				"NickName",
				202
			},
			{
				"PluginName",
				201
			},
			{
				"PluginVersion",
				200
			},
			{
				"Cluster",
				196
			},
			{
				"ExpectedProtocol",
				195
			},
			{
				"CustomInitData",
				194
			},
			{
				"EncryptionMode",
				193
			},
			{
				"EncryptionData",
				192
			},
			{
				"RoomOptionFlags",
				191
			}
		};

		// Token: 0x04001C6F RID: 7279
		internal static Dictionary<string, byte> dictionary_4 = new Dictionary<string, byte>
		{
			{
				"ClientKey",
				1
			},
			{
				"ModeKey",
				2
			},
			{
				"ServerKey",
				1
			},
			{
				"InitEncryption",
				0
			},
			{
				"Ping",
				1
			},
			{
				"Ok",
				0
			}
		};

		// Token: 0x04001C70 RID: 7280
		private static GClass185.Delegate46 delegate46_0;

		// Token: 0x04001C71 RID: 7281
		private static List<byte> list_0 = new List<byte>
		{
			1,
			7,
			8,
			9,
			33,
			35,
			60,
			202,
			209,
			210,
			223,
			226,
			253
		};

		// Token: 0x04001C72 RID: 7282
		private static List<GClass185.Struct35> list_1 = new List<GClass185.Struct35>
		{
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 52,
				byte_1 = new byte[]
				{
					byte.MaxValue,
					50,
					47,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					9,
					0,
					0,
					0,
					13,
					0,
					69,
					110,
					97,
					98,
					108,
					101,
					77,
					101,
					115,
					104,
					82,
					80,
					67,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					2
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 52,
				byte_1 = new byte[]
				{
					0,
					0,
					0,
					7,
					0,
					58,
					24,
					120,
					239,
					191,
					189,
					239,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					9,
					0,
					0,
					0,
					13,
					0,
					83,
					112,
					97,
					119,
					110,
					69,
					109,
					111,
					106,
					105,
					82,
					80,
					67,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					2
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 62,
				byte_1 = new byte[]
				{
					49,
					47,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					13,
					0,
					83,
					112,
					97,
					119,
					110,
					69,
					109,
					111,
					106,
					105,
					82,
					80,
					67,
					80,
					67,
					0,
					0,
					4,
					8,
					0,
					2,
					10,
					1,
					0,
					5,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					0
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 62,
				byte_1 = new byte[]
				{
					49,
					47,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					10,
					0,
					97,
					97,
					97,
					97,
					97,
					97,
					97,
					97,
					97,
					97,
					106,
					105,
					82,
					80,
					4,
					8,
					0,
					2,
					10,
					1,
					0,
					5,
					49,
					0,
					0,
					0,
					5,
					49,
					0,
					0,
					0
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 62,
				byte_1 = new byte[]
				{
					49,
					47,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					13,
					0,
					83,
					112,
					97,
					119,
					110,
					69,
					109,
					111,
					106,
					105,
					82,
					80,
					67,
					80,
					67,
					0,
					0,
					4,
					8,
					0,
					2,
					10,
					1,
					0,
					5,
					49,
					0,
					0,
					0,
					0,
					0
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 6,
				int_0 = 78,
				byte_1 = new byte[]
				{
					106,
					159,
					142,
					10,
					204,
					1,
					0,
					0,
					0,
					36,
					0,
					58,
					49,
					56,
					54,
					65,
					49,
					47,
					85,
					115,
					101,
					114,
					67,
					97,
					109,
					101,
					114,
					97,
					73,
					110,
					100,
					105,
					99,
					97,
					116,
					111,
					114,
					47,
					73,
					110,
					100,
					105,
					99,
					97,
					116,
					111,
					114,
					14,
					0,
					byte.MaxValue,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					10,
					0,
					84,
					105,
					109,
					101,
					114,
					66,
					108,
					111,
					111,
					112,
					0,
					0,
					0,
					0,
					4,
					0,
					0,
					10
				}
			},
			new GClass185.Struct35
			{
				byte_0 = 9,
				int_0 = 8,
				byte_1 = new byte[4]
			}
		};

		// Token: 0x04001C73 RID: 7283
		private static List<byte> list_2 = new List<byte>
		{
			1,
			7,
			8,
			9,
			33,
			202,
			210
		};

		// Token: 0x04001C74 RID: 7284
		private static float float_5 = 0f;

		// Token: 0x04001C75 RID: 7285
		private static int int_0 = 0;

		// Token: 0x04001C76 RID: 7286
		private List<object> list_3 = new List<object>();

		// Token: 0x04001C77 RID: 7287
		private List<object> list_4 = new List<object>();

		// Token: 0x04001C78 RID: 7288
		private List<object> list_5 = new List<object>();

		// Token: 0x0200037C RID: 892
		// (Invoke) Token: 0x060049B2 RID: 18866
		private delegate int Delegate46(USpeakFrameContainer uspeakFrameContainer_0, Il2CppStructArray<byte> il2CppStructArray_0, int int_0);

		// Token: 0x0200037D RID: 893
		private struct Struct35
		{
			// Token: 0x04001C79 RID: 7289
			internal byte byte_0;

			// Token: 0x04001C7A RID: 7290
			internal int int_0;

			// Token: 0x04001C7B RID: 7291
			internal byte[] byte_1;
		}

		// Token: 0x0200037E RID: 894
		[CompilerGenerated]
		[Serializable]
		private sealed class Class211
		{
			// Token: 0x060049B6 RID: 18870 RVA: 0x0011878C File Offset: 0x0011698C
			internal void method_0(GClass84.GStruct153 gstruct153_0)
			{
				GClass70.smethod_24(gstruct153_0.string_0 + ": " + gstruct153_0.string_1, GClass70.Enum1.const_0);
			}

			// Token: 0x060049B7 RID: 18871 RVA: 0x001187B8 File Offset: 0x001169B8
			internal bool method_1(XrefInstance xrefInstance_0)
			{
				return xrefInstance_0.Type == 1 && xrefInstance_0.TryResolve() != null;
			}

			// Token: 0x060049B8 RID: 18872 RVA: 0x0011878C File Offset: 0x0011698C
			internal void method_2(GClass84.GStruct153 gstruct153_0)
			{
				GClass70.smethod_24(gstruct153_0.string_0 + ": " + gstruct153_0.string_1, GClass70.Enum1.const_0);
			}

			// Token: 0x060049B9 RID: 18873 RVA: 0x0011878C File Offset: 0x0011698C
			internal void method_3(GClass84.GStruct153 gstruct153_0)
			{
				GClass70.smethod_24(gstruct153_0.string_0 + ": " + gstruct153_0.string_1, GClass70.Enum1.const_0);
			}

			// Token: 0x060049BA RID: 18874 RVA: 0x001187E0 File Offset: 0x001169E0
			internal bool method_4(MethodInfo methodInfo_0)
			{
				bool result;
				if (!methodInfo_0.Name.StartsWith("Method_Public_Int32_ArrayOf_Byte_Int32_") || methodInfo_0.Name.Contains("_PDM_"))
				{
					result = false;
				}
				else
				{
					result = (XrefScanner.XrefScan(methodInfo_0).Count(new Func<XrefInstance, bool>(GClass185.Class211.class211_0.method_1)) == 4);
				}
				return result;
			}

			// Token: 0x04001C7C RID: 7292
			public static readonly GClass185.Class211 class211_0 = new GClass185.Class211();

			// Token: 0x04001C7D RID: 7293
			public static Func<XrefInstance, bool> func_0;

			// Token: 0x04001C7E RID: 7294
			public static Func<MethodInfo, bool> func_1;

			// Token: 0x04001C7F RID: 7295
			public static Action<GClass84.GStruct153> action_0;

			// Token: 0x04001C80 RID: 7296
			public static Action<GClass84.GStruct153> action_1;

			// Token: 0x04001C81 RID: 7297
			public static Action<GClass84.GStruct153> action_2;
		}
	}
}
