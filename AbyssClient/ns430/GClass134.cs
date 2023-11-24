using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using ns185;
using ns241;
using ns425;
using ns451;
using UnityEngine;
using VRC;
using VRC.SDKBase;

namespace ns430
{
	// Token: 0x0200006C RID: 108
	public class GClass134 : GClass130
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		internal void method_2()
		{
			this.method_23();
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		internal bool method_3(GClass134.GStruct32 gstruct32_0)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (gstruct32_0.method_0(this.list_0[i]))
				{
					this.list_0.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000DF08 File Offset: 0x0000C108
		internal bool method_4(VRC_EventHandler.VrcEvent vrcEvent_0, float float_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, int int_1, float float_2)
		{
			this.list_0.Add(new GClass134.GStruct32(vrcEvent_0, float_1, vrcBroadcastType_1, int_1, float_2));
			return true;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000DF30 File Offset: 0x0000C130
		internal bool method_5(VRC_EventHandler.VrcEvent vrcEvent_0, float float_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, float float_2)
		{
			this.list_0.Add(new GClass134.GStruct32(vrcEvent_0, float_1, vrcBroadcastType_1, gameObject_1, float_2));
			return true;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000DF58 File Offset: 0x0000C158
		internal bool method_6(string string_1)
		{
			this.method_18(string_1, this.vrcBroadcastType_0, this.gameObject_0, this.int_0, this.float_0);
			return true;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_0(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, int int_1, float float_1)
		{
			return true;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		internal bool method_7(VRC_EventHandler.VrcEvent vrcEvent_0)
		{
			if (this.gameObject_0)
			{
				this.method_21(vrcEvent_0, this.vrcBroadcastType_0, this.gameObject_0, this.float_0);
			}
			this.method_22(vrcEvent_0, this.vrcBroadcastType_0, this.int_0, this.float_0);
			return true;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000E044 File Offset: 0x0000C244
		internal bool method_8(GClass134.GStruct32 gstruct32_0)
		{
			try
			{
				if (gstruct32_0.vrcEvent_0 != null)
				{
					if (gstruct32_0.gameObject_0)
					{
						return this.method_21(gstruct32_0.vrcEvent_0, gstruct32_0.vrcBroadcastType_0, gstruct32_0.gameObject_0, gstruct32_0.float_1);
					}
					return this.method_22(gstruct32_0.vrcEvent_0, gstruct32_0.vrcBroadcastType_0, gstruct32_0.int_0, gstruct32_0.float_1);
				}
				else if (gstruct32_0.string_0 != string.Empty)
				{
					if (gstruct32_0.float_1 != 0f)
					{
						return this.method_18(gstruct32_0.string_0, gstruct32_0.vrcBroadcastType_0, gstruct32_0.gameObject_0, gstruct32_0.int_0, gstruct32_0.float_1);
					}
					return this.method_19(gstruct32_0.string_0, gstruct32_0.vrcBroadcastType_0, gstruct32_0.gameObject_0, gstruct32_0.int_0);
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
			return false;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000E144 File Offset: 0x0000C344
		internal bool method_9(VRC_EventHandler.VrcEvent vrcEvent_0, float float_1)
		{
			if (this.gameObject_0)
			{
				this.list_0.Add(new GClass134.GStruct32(vrcEvent_0, float_1, this.vrcBroadcastType_0, this.gameObject_0, this.float_0));
			}
			this.list_0.Add(new GClass134.GStruct32(vrcEvent_0, float_1, this.vrcBroadcastType_0, this.int_0, this.float_0));
			return true;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		internal bool method_10(string string_1, float float_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1, float float_2)
		{
			this.list_0.Add(new GClass134.GStruct32(string_1, float_1, vrcBroadcastType_1, gameObject_1, int_1, float_2));
			return true;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		internal void method_11()
		{
			this.method_12();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		internal void method_12()
		{
			this.list_0.Clear();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_1(string string_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1, float float_1)
		{
			return true;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		private static HarmonyMethod smethod_2(string string_1)
		{
			return new HarmonyMethod(typeof(GClass134).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000E224 File Offset: 0x0000C424
		internal void method_13()
		{
			if (this.bool_0)
			{
				if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304))
				{
					if (Input.GetKeyDown(98))
					{
						this.bool_3 = !this.bool_3;
					}
					if (Input.GetKeyDown(110))
					{
						this.method_14();
					}
				}
				if (this.bool_3)
				{
					int num = GClass84.smethod_841();
					for (int i = 0; i < this.list_0.Count; i++)
					{
						GClass134.GStruct32 gstruct = this.list_0[i];
						if (gstruct.bool_0)
						{
							if (gstruct.string_0 != string.Empty)
							{
								if (!gstruct.gameObject_0)
								{
									this.list_0.RemoveAt(i);
									i--;
									goto IL_128;
								}
							}
							else if (gstruct.vrcEvent_0 == null)
							{
								this.list_0.RemoveAt(i);
								i--;
								goto IL_128;
							}
							if ((float)num >= gstruct.float_2 + gstruct.float_0 * 1000f && this.method_8(gstruct))
							{
								gstruct.float_2 = (float)num;
								this.list_0[i] = gstruct;
							}
						}
						IL_128:;
					}
				}
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000E374 File Offset: 0x0000C574
		public override void vmethod_23()
		{
			this.method_2();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000E388 File Offset: 0x0000C588
		internal void method_14()
		{
			this.method_11();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000E39C File Offset: 0x0000C59C
		internal void method_15()
		{
			this.method_13();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		internal bool method_16(string string_1, float float_1)
		{
			this.list_0.Add(new GClass134.GStruct32(string_1, float_1, this.vrcBroadcastType_0, this.gameObject_0, this.int_0, this.float_0));
			return true;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		private static bool smethod_3(ref VRC_EventHandler.VrcEvent vrcEvent_0, ref VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, ref int int_1, ref float float_1)
		{
			Player player = GClass84.smethod_703(int_1);
			string text = GClass84.smethod_643(player, "Someone");
			bool result;
			if ((GClass84.smethod_593(vrcEvent_0.Name) > 100 || GClass84.smethod_593(vrcEvent_0.ParameterString) > 100) && player != GClass84.smethod_1010())
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					text,
					" ",
					"Trying",
					" ",
					"To",
					" ",
					"Trigger",
					" ",
					"Malicious",
					" ",
					"Events"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				if (GClass84.gclass134_0.bool_1 && (vrcEvent_0.EventType == 14 || !GClass84.gclass134_0.bool_2))
				{
					string text2 = vrcEvent_0.EventType.ToString();
					if (vrcEvent_0.ParameterString != null && vrcEvent_0.ParameterString != string.Empty)
					{
						text2 = text2 + ", " + vrcEvent_0.ParameterString;
					}
					text2 = text2 + ", " + vrcEvent_0.ParameterBoolOp.ToString();
					text2 = text2 + ", " + vrcEvent_0.ParameterBool.ToString();
					text2 = text2 + ", " + vrcEvent_0.ParameterFloat.ToString();
					text2 = text2 + ", " + vrcEvent_0.ParameterInt.ToString();
					if (vrcEvent_0.ParameterObject)
					{
						text2 = text2 + ", " + GClass84.smethod_1324(vrcEvent_0.ParameterObject);
					}
					if (vrcEvent_0.ParameterObjects != null && vrcEvent_0.ParameterObjects.Length > 0)
					{
						text2 += ", (";
						bool flag = false;
						foreach (GameObject gameObject_ in vrcEvent_0.ParameterObjects)
						{
							if (flag)
							{
								text2 += ", ";
							}
							else
							{
								flag = true;
							}
							text2 += GClass84.smethod_1324(gameObject_);
						}
						text2 += ")";
					}
					if (vrcEvent_0.ParameterBytes != null && vrcEvent_0.ParameterBytes.Length > 0)
					{
						text2 += ", (";
						bool flag2 = false;
						foreach (byte b in vrcEvent_0.ParameterBytes)
						{
							if (flag2)
							{
								text2 += ", ";
							}
							else
							{
								flag2 = true;
							}
							text2 += b.ToString();
						}
						text2 += ")";
					}
					GClass70.smethod_38(string.Concat(new string[]
					{
						"VRC_EventHandler_InternalTriggerEvent",
						": (",
						text2,
						"), ",
						vrcBroadcastType_1.ToString(),
						", ",
						int_1.ToString(),
						", ",
						float_1.ToString()
					}), GClass70.Enum1.const_0);
				}
				try
				{
					if ((vrcBroadcastType_1 == 0 || vrcBroadcastType_1 == 4 || vrcBroadcastType_1 == 7) && player && GClass84.smethod_28(player).playerId != GClass84.smethod_739().playerId && GClass84.gclass137_0.bool_2)
					{
						return false;
					}
					if (GClass84.gclass137_0.bool_3 && vrcBroadcastType_1 != 0 && vrcBroadcastType_1 != 7 && vrcBroadcastType_1 != 4)
					{
						vrcBroadcastType_1 = 0;
					}
				}
				catch
				{
				}
				GClass84.gclass93_0.method_143(vrcEvent_0, vrcBroadcastType_1, int_1, float_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000E804 File Offset: 0x0000CA04
		private static bool smethod_4(VRC_EventHandler vrc_EventHandler_0, VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, int int_1, float float_1)
		{
			return vrcEvent_0.EventType != 14 || (vrcEvent_0.ParameterString == null || !(vrcEvent_0.ParameterString == "SendStrokeRPC")) || !GClass155.bool_24;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000E848 File Offset: 0x0000CA48
		internal bool method_17(GClass134.GStruct32 gstruct32_0, bool bool_4)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass134.GStruct32 gstruct = this.list_0[i];
				if (gstruct32_0.method_0(gstruct))
				{
					gstruct.bool_0 = bool_4;
					this.list_0[i] = gstruct;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		internal bool method_18(string string_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1, float float_1)
		{
			bool result;
			if (string_1 == string.Empty || !gameObject_1)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_578(string_1, vrcBroadcastType_1, gameObject_1, int_1, float_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000E8DC File Offset: 0x0000CADC
		internal bool method_19(string string_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1)
		{
			bool result;
			if (string_1 == string.Empty || !gameObject_1)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_1610(string_1, vrcBroadcastType_1, gameObject_1, int_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_5(string string_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1)
		{
			return true;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000E918 File Offset: 0x0000CB18
		public override void vmethod_19()
		{
			this.method_15();
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000E92C File Offset: 0x0000CB2C
		internal bool method_20(string string_1, float float_1, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1)
		{
			this.list_0.Add(new GClass134.GStruct32(string_1, float_1, vrcBroadcastType_1, gameObject_1, int_1));
			return true;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000E954 File Offset: 0x0000CB54
		internal bool method_21(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, float float_1)
		{
			bool result;
			if (vrcEvent_0 == null)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_1236(vrcEvent_0, vrcBroadcastType_1, gameObject_1, float_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000E97C File Offset: 0x0000CB7C
		internal bool method_22(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, int int_1, float float_1)
		{
			bool result;
			if (vrcEvent_0 == null)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_1212(vrcEvent_0, vrcBroadcastType_1, int_1, float_1);
				result = true;
			}
			return result;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_6(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, float float_1)
		{
			return true;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		internal void method_23()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.smethod_1302("EventsManager", typeof(VRC_EventHandler), "InternalTriggerEvent", GClass134.smethod_2("VRC_EventHandler_InternalTriggerEvent"), null, null);
		}

		// Token: 0x04000272 RID: 626
		internal bool bool_0 = true;

		// Token: 0x04000273 RID: 627
		internal bool bool_1 = false;

		// Token: 0x04000274 RID: 628
		internal bool bool_2 = false;

		// Token: 0x04000275 RID: 629
		internal VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0 = 0;

		// Token: 0x04000276 RID: 630
		internal GameObject gameObject_0 = null;

		// Token: 0x04000277 RID: 631
		internal int int_0 = 0;

		// Token: 0x04000278 RID: 632
		internal float float_0 = 0f;

		// Token: 0x04000279 RID: 633
		internal bool bool_3 = true;

		// Token: 0x0400027A RID: 634
		internal List<GClass134.GStruct32> list_0 = new List<GClass134.GStruct32>();

		// Token: 0x0200006D RID: 109
		public struct GStruct32
		{
			// Token: 0x0600040C RID: 1036 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
			public GStruct32(VRC_EventHandler.VrcEvent vrcEvent_1, float float_3, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, float float_4)
			{
				this.vrcEvent_0 = vrcEvent_1;
				this.string_0 = string.Empty;
				this.float_0 = float_3;
				this.vrcBroadcastType_0 = vrcBroadcastType_1;
				this.gameObject_0 = gameObject_1;
				this.int_0 = 0;
				this.float_1 = float_4;
				this.float_2 = 0f;
				this.bool_0 = true;
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x0000EA48 File Offset: 0x0000CC48
			public bool method_0(GClass134.GStruct32 gstruct32_0)
			{
				return gstruct32_0.vrcEvent_0 == this.vrcEvent_0 && gstruct32_0.string_0 == this.string_0 && gstruct32_0.vrcBroadcastType_0 == this.vrcBroadcastType_0 && gstruct32_0.gameObject_0 == this.gameObject_0 && gstruct32_0.int_0 == this.int_0 && gstruct32_0.float_1 == this.float_1;
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
			public GStruct32(string string_1, float float_3, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1, float float_4)
			{
				this.vrcEvent_0 = null;
				this.string_0 = string_1;
				this.float_0 = float_3;
				this.vrcBroadcastType_0 = vrcBroadcastType_1;
				this.gameObject_0 = gameObject_1;
				this.int_0 = int_1;
				this.float_1 = float_4;
				this.float_2 = 0f;
				this.bool_0 = true;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x0000EB0C File Offset: 0x0000CD0C
			public GStruct32(string string_1, float float_3, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, GameObject gameObject_1, int int_1)
			{
				this.vrcEvent_0 = null;
				this.string_0 = string_1;
				this.float_0 = float_3;
				this.vrcBroadcastType_0 = vrcBroadcastType_1;
				this.gameObject_0 = gameObject_1;
				this.int_0 = int_1;
				this.float_1 = 0f;
				this.float_2 = 0f;
				this.bool_0 = true;
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000EB64 File Offset: 0x0000CD64
			public GStruct32(VRC_EventHandler.VrcEvent vrcEvent_1, float float_3, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_1, int int_1, float float_4)
			{
				this.vrcEvent_0 = vrcEvent_1;
				this.string_0 = string.Empty;
				this.float_0 = float_3;
				this.vrcBroadcastType_0 = vrcBroadcastType_1;
				this.gameObject_0 = null;
				this.int_0 = int_1;
				this.float_1 = float_4;
				this.float_2 = 0f;
				this.bool_0 = true;
			}

			// Token: 0x0400027B RID: 635
			public VRC_EventHandler.VrcEvent vrcEvent_0;

			// Token: 0x0400027C RID: 636
			public string string_0;

			// Token: 0x0400027D RID: 637
			public float float_0;

			// Token: 0x0400027E RID: 638
			public VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0;

			// Token: 0x0400027F RID: 639
			public GameObject gameObject_0;

			// Token: 0x04000280 RID: 640
			public int int_0;

			// Token: 0x04000281 RID: 641
			public float float_1;

			// Token: 0x04000282 RID: 642
			public float float_2;

			// Token: 0x04000283 RID: 643
			public bool bool_0;
		}
	}
}
