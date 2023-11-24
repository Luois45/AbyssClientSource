using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExitGames.Client.Photon;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;
using MelonLoader;
using MelonLoader.TinyJSON;
using Microsoft.Win32;
using Mono.CSharp;
using ns105;
using ns113;
using ns127;
using ns185;
using ns216;
using ns26;
using ns277;
using ns339;
using ns36;
using ns375;
using ns397;
using ns426;
using ns427;
using ns428;
using ns429;
using ns430;
using ns431;
using ns432;
using ns433;
using ns434;
using ns436;
using ns437;
using ns439;
using ns440;
using ns441;
using ns442;
using ns443;
using ns444;
using ns445;
using ns446;
using ns448;
using ns449;
using ns451;
using ns452;
using ns453;
using ns454;
using ns455;
using ns456;
using ns457;
using ns458;
using ns459;
using ns460;
using ns461;
using ns462;
using ns464;
using ns465;
using ns471;
using ns474;
using ns475;
using ns476;
using ns477;
using ns478;
using ns479;
using ns480;
using ns481;
using ns482;
using ns488;
using ns493;
using ns51;
using ns523;
using ns526;
using ns54;
using ns550;
using ns73;
using Photon.Pun;
using Photon.Realtime;
using RootMotion.FinalIK;
using Transmtn.DTO.Notifications;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using VRC;
using VRC.Animation;
using VRC.Core;
using VRC.DataModel;
using VRC.DataModel.Core;
using VRC.Management;
using VRC.Networking;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.SDKBase.Validation.Performance.Stats;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using VRC.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;
using VRCSDK2;

namespace ns241
{
	// Token: 0x020001C0 RID: 448
	public static class GClass84
	{
		// Token: 0x060010D1 RID: 4305 RVA: 0x000585B4 File Offset: 0x000567B4
		internal static void smethod_0(Button button_0, Action action_0)
		{
			GClass84.smethod_857(button_0, action_0);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000585C8 File Offset: 0x000567C8
		internal static List<VRCPlayer> smethod_1(bool bool_10 = true)
		{
			List<VRCPlayer> result;
			if (bool_10)
			{
				result = GClass84.smethod_1549();
			}
			else
			{
				List<VRCPlayer> list = new List<VRCPlayer>();
				VRCPlayer vrcplayer = GClass84.smethod_460();
				Player[] array = GClass84.smethod_870();
				for (int i = 0; i < array.Length; i++)
				{
					VRCPlayer vrcplayer2 = GClass84.smethod_367(array[i]);
					if (vrcplayer2 && vrcplayer2 != vrcplayer)
					{
						list.Add(vrcplayer2);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00058634 File Offset: 0x00056834
		internal static bool smethod_2(GameObject gameObject_39, GameObject gameObject_40)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_497(gameObject_39.transform, gameObject_40.transform);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00058670 File Offset: 0x00056870
		internal static int smethod_3()
		{
			return GClass84.list_49.Count;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0005868C File Offset: 0x0005688C
		internal static bool smethod_4(GameObject gameObject_39, Transform transform_0, bool bool_10 = false, bool bool_11 = false)
		{
			return gameObject_39 && transform_0 && GClass84.smethod_1022(gameObject_39.transform, transform_0, bool_10, bool_11);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000586C4 File Offset: 0x000568C4
		internal static List<GameObject> smethod_5(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<IK>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00058718 File Offset: 0x00056918
		internal static void smethod_6(Renderer renderer_0)
		{
			GClass84.smethod_812(renderer_0);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_7(Collider collider_0)
		{
			if (collider_0)
			{
				Object.DestroyImmediate(collider_0, true);
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0005874C File Offset: 0x0005694C
		internal static string smethod_8()
		{
			return GClass84.smethod_135();
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00058760 File Offset: 0x00056960
		internal static void smethod_9(string string_4, string string_5, InputField.InputType inputType_0, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7 = "Enter text....", bool bool_10 = true, Action<VRCUiPopup> action_2 = null)
		{
			GClass84.smethod_548(string_4, string_5, inputType_0, string_6, action_0, action_1, string_7, bool_10, action_2);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0005878C File Offset: 0x0005698C
		internal static NotificationManager smethod_10()
		{
			return NotificationManager.field_Private_Static_NotificationManager_0;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000587A0 File Offset: 0x000569A0
		internal static string smethod_11(GameObject gameObject_39, Transform transform_0)
		{
			return GClass84.smethod_187(gameObject_39, transform_0);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000587B4 File Offset: 0x000569B4
		internal static void smethod_12(Transform transform_0)
		{
			GClass84.smethod_1620(transform_0);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000587C8 File Offset: 0x000569C8
		internal static void smethod_13(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_817(vrcplayerApi_0);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000587DC File Offset: 0x000569DC
		internal static void smethod_14(Slider slider_0, UnityAction<float> unityAction_0)
		{
			GClass84.smethod_541(slider_0, unityAction_0);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000587F0 File Offset: 0x000569F0
		internal static bool smethod_15(Color color_0)
		{
			return color_0.r == color_0.g && color_0.r == color_0.b;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0005881C File Offset: 0x00056A1C
		internal static List<string> smethod_16(UdonBehaviour udonBehaviour_0)
		{
			List<string> list = new List<string>();
			if (udonBehaviour_0)
			{
				Dictionary<string, List<uint>>.Enumerator enumerator = udonBehaviour_0._eventTable.GetEnumerator();
				for (int i = 0; i < udonBehaviour_0._eventTable.Count; i++)
				{
					if (enumerator.MoveNext())
					{
						list.Add(enumerator.Current.key);
					}
				}
			}
			return list;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0005887C File Offset: 0x00056A7C
		internal static void smethod_17(GameObject gameObject_39, bool bool_10)
		{
			GClass84.smethod_705(gameObject_39, bool_10);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00058890 File Offset: 0x00056A90
		internal static int smethod_18(byte[] byte_0, int int_1 = 0)
		{
			int num = 0;
			int num2 = 0;
			while (num2 < 4 && num2 + int_1 < byte_0.Length)
			{
				num <<= 8;
				num |= (int)(byte_0[num2 + int_1] & byte.MaxValue);
				num2++;
			}
			return num;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x000588D4 File Offset: 0x00056AD4
		internal static string smethod_19(uint uint_0)
		{
			return GClass84.smethod_1408(uint_0);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000588E8 File Offset: 0x00056AE8
		internal static void smethod_20(VRCPlayer vrcplayer_0)
		{
			if (!(vrcplayer_0 == null))
			{
				if (GClass84.methodInfo_1 == null)
				{
					GClass84.methodInfo_1 = typeof(VRCPlayer).GetMethods().First(new Func<MethodInfo, bool>(GClass84.Class101.class101_0.method_24));
				}
				if (GClass84.methodInfo_1 == null)
				{
					GClass70.smethod_36("Can't find reload avatar method!", GClass70.Enum1.const_0);
				}
				else
				{
					try
					{
						GClass84.methodInfo_1.Invoke(vrcplayer_0, new object[]
						{
							true
						});
					}
					catch (Exception ex)
					{
						string[] array = new string[9];
						array[0] = "Exception";
						array[1] = " ";
						array[2] = "while";
						array[3] = " ";
						array[4] = "reloading";
						array[5] = " ";
						array[6] = "avatar";
						array[7] = ": ";
						int num = 8;
						Exception ex2 = ex;
						array[num] = ((ex2 != null) ? ex2.ToString() : null);
						GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x000589F8 File Offset: 0x00056BF8
		internal static void smethod_21()
		{
			for (int i = GClass84.list_50.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_50[i]);
			}
			GClass84.list_50.Clear();
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00058A3C File Offset: 0x00056C3C
		internal static string smethod_22(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_2, int_1);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00058A58 File Offset: 0x00056C58
		internal static GameObject smethod_23()
		{
			if (!GClass84.gameObject_16)
			{
				GClass84.gameObject_16 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound");
			}
			return GClass84.gameObject_16;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00058A8C File Offset: 0x00056C8C
		internal static void smethod_24()
		{
			GClass84.smethod_1419();
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00058AA0 File Offset: 0x00056CA0
		internal static void smethod_25(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, string string_7 = "Enter text....", bool bool_11 = true, Action<VRCUiPopup> action_1 = null)
		{
			GClass84.smethod_610(string_4, string_5, inputType_0, bool_10, string_6, action_0, string_7, bool_11, action_1);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00058ACC File Offset: 0x00056CCC
		internal static NeckMouseRotator smethod_26()
		{
			VRCVrCamera vrcvrCamera = GClass84.smethod_888();
			return (vrcvrCamera != null) ? vrcvrCamera.GetComponentInChildren<NeckMouseRotator>() : null;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00058AEC File Offset: 0x00056CEC
		internal static void smethod_27()
		{
			GClass84.smethod_1368();
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00058B00 File Offset: 0x00056D00
		internal static VRCPlayerApi smethod_28(Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Public_get_VRCPlayerApi_0() : null;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00058B1C File Offset: 0x00056D1C
		internal static void smethod_29(PortalInternal portalInternal_0)
		{
			GClass84.smethod_563(portalInternal_0, 0f);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00058B34 File Offset: 0x00056D34
		internal static bool smethod_30<T>(T[] gparam_0, T[] gparam_1, GClass84.Enum6 enum6_0 = GClass84.Enum6.const_0) where T : Object
		{
			bool result;
			if (gparam_1 == null || gparam_1.Length == 0 || gparam_0 == null || gparam_0.Length == 0)
			{
				result = false;
			}
			else if (enum6_0 != GClass84.Enum6.const_0)
			{
				if (enum6_0 != GClass84.Enum6.const_1)
				{
					result = false;
				}
				else
				{
					foreach (T gparam_2 in gparam_1)
					{
						if (!GClass84.smethod_1295<T>(gparam_0, gparam_2))
						{
							return false;
						}
					}
					result = true;
				}
			}
			else
			{
				foreach (T gparam_3 in gparam_1)
				{
					if (GClass84.smethod_1295<T>(gparam_0, gparam_3))
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00058BD0 File Offset: 0x00056DD0
		internal static void smethod_31(GameObject gameObject_39)
		{
			GClass84.smethod_1077(gameObject_39);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00058BE4 File Offset: 0x00056DE4
		internal static void smethod_32()
		{
			GClass84.smethod_169();
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00058BF8 File Offset: 0x00056DF8
		internal static void smethod_33(string string_4, string string_5, InputField.InputType inputType_0, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7, bool bool_10, Action<VRCUiPopup> action_2)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_InputType_String_Action_3_String_List_1_KeyCode_Text_Action_String_Boolean_Action_1_VRCUiPopup_PDM_0(string_4, string_5, inputType_0, string_6, action_0, action_1, string_7, bool_10, action_2);
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00058C24 File Offset: 0x00056E24
		internal static void smethod_34(ref HighlightsFXStandalone highlightsFXStandalone_1, Color color_0)
		{
			GClass84.smethod_1217(ref highlightsFXStandalone_1, color_0);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00058C38 File Offset: 0x00056E38
		internal static ApiAvatar smethod_35(PlayerNet playerNet_0)
		{
			return GClass84.smethod_1468(GClass84.smethod_800(playerNet_0));
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00058C54 File Offset: 0x00056E54
		internal static void smethod_36()
		{
			for (int i = GClass84.list_43.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_43[i]);
			}
			GClass84.list_43.Clear();
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00058C98 File Offset: 0x00056E98
		internal static string smethod_37(string string_4, string string_5)
		{
			return GClass84.smethod_1685(string_4, string_5);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00058CAC File Offset: 0x00056EAC
		internal static void smethod_38(string string_4)
		{
			if (!GClass84.smethod_591("avtr_********-****-****-****-************", string_4, GClass84.list_34))
			{
				GClass70.smethod_36("ChangeAvatar: Bad avatar ID!", GClass70.Enum1.const_0);
			}
			else
			{
				try
				{
					PageAvatar component = GameObject.Find("Screens").transform.Find("Avatar").GetComponent<PageAvatar>();
					component.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar
					{
						id = string_4
					};
					component.ChangeToSelectedAvatar();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36("Change" + "Avatar" + ": " + ex.Message, GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00058D50 File Offset: 0x00056F50
		internal static void smethod_39(bool bool_10)
		{
			GClass84.smethod_1727(bool_10);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00058D64 File Offset: 0x00056F64
		internal static int smethod_40(VRCPlayerApi vrcplayerApi_0)
		{
			int result;
			if (vrcplayerApi_0 == null)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_175(GClass84.smethod_86(vrcplayerApi_0));
			}
			return result;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00058D88 File Offset: 0x00056F88
		internal static MethodInfo[] smethod_41(Type type_0)
		{
			return type_0.GetMethods();
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00058DA0 File Offset: 0x00056FA0
		internal static void smethod_42(ApiAvatar apiAvatar_0, string string_4, string string_5, string string_6)
		{
			ApiAvatar apiAvatar = new ApiAvatar();
			apiAvatar.smethod_938(apiAvatar_0.id, GClass84.smethod_1372(), string_4, string_6, apiAvatar_0.assetUrl, string_5, apiAvatar_0.releaseStatus, apiAvatar_0.tags, apiAvatar_0.unityPackageUrl);
			apiAvatar.Save(new Action<ApiContainer>(GClass84.Class101.class101_0.method_27), new Action<ApiContainer>(GClass84.Class101.class101_0.method_9));
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00058E30 File Offset: 0x00057030
		internal static List<AimIK> smethod_43(GameObject gameObject_39)
		{
			List<AimIK> result;
			if (!gameObject_39)
			{
				result = new List<AimIK>();
			}
			else
			{
				List<AimIK> list = gameObject_39.GetComponents<AimIK>().ToList<AimIK>();
				list.AddRange(gameObject_39.GetComponentsInChildren<AimIK>(true));
				result = list.Distinct<AimIK>().ToList<AimIK>();
			}
			return result;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00058E78 File Offset: 0x00057078
		internal static HighlightsFXStandalone smethod_44(ref HighlightsFXStandalone highlightsFXStandalone_1)
		{
			if (!highlightsFXStandalone_1)
			{
				highlightsFXStandalone_1 = GClass84.smethod_1275();
			}
			return highlightsFXStandalone_1;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00058E9C File Offset: 0x0005709C
		internal static CursorLockMode smethod_45()
		{
			return Cursor.lockState;
		}

		// Token: 0x060010FF RID: 4351
		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string string_4);

		// Token: 0x06001100 RID: 4352 RVA: 0x00058EB0 File Offset: 0x000570B0
		internal static List<string> smethod_46<T>(in T gparam_0, int int_1 = 0, int int_2 = 0, bool bool_10 = false, bool bool_11 = true, bool bool_12 = true, bool bool_13 = true, bool bool_14 = false)
		{
			List<string> result;
			try
			{
				if (gparam_0 == null)
				{
					result = new List<string>();
				}
				else
				{
					Object @object = gparam_0 as Object;
					if (@object != null)
					{
						object obj = GClass84.smethod_308<object>(@object);
						result = GClass84.smethod_46<object>(obj, int_1, int_2, bool_10, bool_11, bool_12, bool_13, bool_14);
					}
					else
					{
						List<string> list = new List<string>();
						string text = string.Empty;
						for (int i = 0; i < int_1; i++)
						{
							text += " ";
						}
						string text2 = gparam_0 as string;
						if (text2 != null)
						{
							if (bool_10)
							{
								list.Add(text2);
							}
							else
							{
								list.Add(text + text2);
							}
						}
						else
						{
							T t = gparam_0;
							byte b;
							bool flag;
							if (t is byte)
							{
								b = (t as byte);
								flag = true;
							}
							else
							{
								flag = false;
							}
							if (flag)
							{
								if (bool_10)
								{
									list.Add(b.ToString());
								}
								else
								{
									list.Add(text + b.ToString());
								}
							}
							else
							{
								t = gparam_0;
								int num;
								bool flag2;
								if (t is int)
								{
									num = (t as int);
									flag2 = true;
								}
								else
								{
									flag2 = false;
								}
								if (flag2)
								{
									if (bool_10)
									{
										list.Add(num.ToString());
									}
									else
									{
										list.Add(text + num.ToString());
									}
								}
								else
								{
									int[][] array = gparam_0 as int[][];
									if (array != null)
									{
										if (bool_13)
										{
											for (int j = 0; j < array.Length; j++)
											{
												List<string> list2 = GClass84.smethod_46<int[]>(array[j], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
												if (list2.Count == 0)
												{
													list.Add(string.Concat(new string[]
													{
														text,
														"[",
														j.ToString(),
														"]",
														": ",
														"Null"
													}));
												}
												else if (list2.Count == 1)
												{
													list.Add(string.Concat(new string[]
													{
														text,
														"[",
														j.ToString(),
														"]",
														": ",
														list2[0]
													}));
												}
												else
												{
													list.Add(string.Concat(new string[]
													{
														text,
														"[",
														j.ToString(),
														"]",
														":"
													}));
													list.AddRange(list2);
												}
												list2.Clear();
											}
										}
										else if (bool_10)
										{
											list.Add(array.ToString());
										}
										else
										{
											list.Add(text + array.ToString());
										}
									}
									else
									{
										byte[][] array2 = gparam_0 as byte[][];
										if (array2 != null)
										{
											if (bool_13)
											{
												for (int k = 0; k < array2.Length; k++)
												{
													List<string> list3 = GClass84.smethod_46<byte[]>(array2[k], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
													if (list3.Count == 0)
													{
														list.Add(string.Concat(new string[]
														{
															text,
															"[",
															k.ToString(),
															"]",
															": ",
															"Null"
														}));
													}
													else if (list3.Count == 1)
													{
														list.Add(string.Concat(new string[]
														{
															text,
															"[",
															k.ToString(),
															"]: {",
															list3[0]
														}));
													}
													else
													{
														list.Add(string.Concat(new string[]
														{
															text,
															"[",
															k.ToString(),
															"]",
															":"
														}));
														list.AddRange(list3);
													}
													list3.Clear();
												}
											}
											else if (bool_10)
											{
												list.Add(array2.ToString());
											}
											else
											{
												list.Add(text + array2.ToString());
											}
										}
										else
										{
											object[][] array3 = gparam_0 as object[][];
											if (array3 != null)
											{
												if (bool_13)
												{
													for (int l = 0; l < array3.Length; l++)
													{
														List<string> list4 = GClass84.smethod_46<object[]>(array3[l], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
														if (list4.Count == 0)
														{
															list.Add(string.Concat(new string[]
															{
																text,
																"[",
																l.ToString(),
																"]",
																": ",
																"Null"
															}));
														}
														else if (list4.Count == 1)
														{
															list.Add(string.Concat(new string[]
															{
																text,
																"[",
																l.ToString(),
																"]",
																": ",
																list4[0]
															}));
														}
														else
														{
															list.Add(string.Concat(new string[]
															{
																text,
																"[",
																l.ToString(),
																"]",
																":"
															}));
															list.AddRange(list4);
														}
														list4.Clear();
													}
												}
												else if (bool_10)
												{
													list.Add(array3.ToString());
												}
												else
												{
													list.Add(text + array3.ToString());
												}
											}
											else
											{
												int[] array4;
												bool flag3;
												if (bool_12)
												{
													array4 = (gparam_0 as int[]);
													flag3 = (array4 != null);
												}
												else
												{
													flag3 = false;
												}
												if (flag3)
												{
													if (bool_14)
													{
														List<string> list5 = new List<string>();
														for (int m = 0; m < array4.Length; m++)
														{
															List<string> list6 = GClass84.smethod_46<int>(array4[m], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
															if (list6.Count == 0)
															{
																list5.Add("Null");
															}
															else if (list6.Count == 1)
															{
																list5.Add(list6[0]);
															}
															else
															{
																list5.Add("{ " + string.Join(", ", list6) + " }");
															}
															list6.Clear();
														}
														List<string> list7 = list;
														string[] array5 = new string[8];
														array5[0] = "new";
														array5[1] = " ";
														array5[2] = "int";
														array5[3] = "[";
														int num2 = 4;
														int num3 = list5.Count;
														array5[num2] = num3.ToString();
														array5[5] = "] { ";
														array5[6] = string.Join(", ", list5);
														array5[7] = " }";
														list7.Add(string.Concat(array5));
													}
													else
													{
														for (int n = 0; n < array4.Length; n++)
														{
															List<string> list8 = GClass84.smethod_46<int>(array4[n], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
															if (list8.Count == 0)
															{
																list.Add(string.Concat(new string[]
																{
																	text,
																	"[",
																	n.ToString(),
																	"]",
																	": ",
																	"Null"
																}));
															}
															else if (list8.Count == 1)
															{
																list.Add(string.Concat(new string[]
																{
																	text,
																	"[",
																	n.ToString(),
																	"]",
																	": ",
																	list8[0]
																}));
															}
															else
															{
																list.Add(string.Concat(new string[]
																{
																	text,
																	"[",
																	n.ToString(),
																	"]",
																	":"
																}));
																list.AddRange(list8);
															}
															list8.Clear();
														}
													}
												}
												else
												{
													byte[] array6;
													bool flag4;
													if (bool_12)
													{
														array6 = (gparam_0 as byte[]);
														flag4 = (array6 != null);
													}
													else
													{
														flag4 = false;
													}
													if (flag4)
													{
														if (bool_14)
														{
															List<string> list9 = new List<string>();
															for (int num4 = 0; num4 < array6.Length; num4++)
															{
																List<string> list10 = GClass84.smethod_46<byte>(array6[num4], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																if (list10.Count == 0)
																{
																	list9.Add("Null");
																}
																else if (list10.Count == 1)
																{
																	list9.Add(list10[0]);
																}
																else
																{
																	list9.Add("{ " + string.Join(", ", list10) + " }");
																}
																list10.Clear();
															}
															List<string> list11 = list;
															string[] array7 = new string[8];
															array7[0] = "new";
															array7[1] = " ";
															array7[2] = "byte";
															array7[3] = "[";
															int num5 = 4;
															int num3 = list9.Count;
															array7[num5] = num3.ToString();
															array7[5] = "] { ";
															array7[6] = string.Join(", ", list9);
															array7[7] = " }";
															list11.Add(string.Concat(array7));
														}
														else
														{
															for (int num6 = 0; num6 < array6.Length; num6++)
															{
																List<string> list12 = GClass84.smethod_46<byte>(array6[num6], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																if (list12.Count == 0)
																{
																	list.Add(string.Concat(new string[]
																	{
																		text,
																		"[",
																		num6.ToString(),
																		"]",
																		": ",
																		"Null"
																	}));
																}
																else if (list12.Count == 1)
																{
																	list.Add(string.Concat(new string[]
																	{
																		text,
																		"[",
																		num6.ToString(),
																		"]",
																		": ",
																		list12[0]
																	}));
																}
																else
																{
																	list.Add(string.Concat(new string[]
																	{
																		text,
																		"[",
																		num6.ToString(),
																		"]",
																		":"
																	}));
																	list.AddRange(list12);
																}
																list12.Clear();
															}
														}
													}
													else
													{
														object[] array8;
														bool flag5;
														if (bool_12)
														{
															array8 = (gparam_0 as object[]);
															flag5 = (array8 != null);
														}
														else
														{
															flag5 = false;
														}
														if (flag5)
														{
															if (bool_14)
															{
																List<string> list13 = new List<string>();
																for (int num7 = 0; num7 < array8.Length; num7++)
																{
																	List<string> list14 = GClass84.smethod_46<object>(array8[num7], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																	if (list14.Count == 0)
																	{
																		list13.Add("Null");
																	}
																	else if (list14.Count == 1)
																	{
																		list13.Add(list14[0]);
																	}
																	else
																	{
																		list13.Add("{ " + string.Join(", ", list14) + " }");
																	}
																	list14.Clear();
																}
																List<string> list15 = list;
																string[] array9 = new string[8];
																array9[0] = "new";
																array9[1] = " ";
																array9[2] = "object";
																array9[3] = "[";
																int num8 = 4;
																int num3 = list13.Count;
																array9[num8] = num3.ToString();
																array9[5] = "] { ";
																array9[6] = string.Join(", ", list13);
																array9[7] = " }";
																list15.Add(string.Concat(array9));
															}
															else
															{
																for (int num9 = 0; num9 < array8.Length; num9++)
																{
																	List<string> list16 = GClass84.smethod_46<object>(array8[num9], int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																	if (list16.Count == 0)
																	{
																		list.Add(string.Concat(new string[]
																		{
																			text,
																			"[",
																			num9.ToString(),
																			"]",
																			": ",
																			"Null"
																		}));
																	}
																	else if (list16.Count == 1)
																	{
																		list.Add(string.Concat(new string[]
																		{
																			text,
																			"[",
																			num9.ToString(),
																			"]",
																			": ",
																			list16[0]
																		}));
																	}
																	else
																	{
																		list.Add(string.Concat(new string[]
																		{
																			text,
																			"[",
																			num9.ToString(),
																			"]",
																			":"
																		}));
																		list.AddRange(list16);
																	}
																	list16.Clear();
																}
															}
														}
														else
														{
															List<object> list17;
															bool flag6;
															if (bool_12)
															{
																list17 = (gparam_0 as List<object>);
																flag6 = (list17 != null);
															}
															else
															{
																flag6 = false;
															}
															if (flag6)
															{
																if (bool_14)
																{
																	List<string> list18 = new List<string>();
																	for (int num10 = 0; num10 < list17.Count; num10++)
																	{
																		object obj = list17[num10];
																		List<string> list19 = GClass84.smethod_46<object>(obj, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																		if (list19.Count == 0)
																		{
																			list18.Add("Null");
																		}
																		else if (list19.Count == 1)
																		{
																			list18.Add(list19[0]);
																		}
																		else
																		{
																			list18.Add("{ " + string.Join(", ", list19) + " }");
																		}
																		list19.Clear();
																	}
																	list.Add(string.Concat(new string[]
																	{
																		"new",
																		" ",
																		"List",
																		"<",
																		"object",
																		"> { ",
																		string.Join(", ", list18),
																		" }"
																	}));
																}
																else
																{
																	for (int num11 = 0; num11 < list17.Count; num11++)
																	{
																		object obj = list17[num11];
																		List<string> list20 = GClass84.smethod_46<object>(obj, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																		if (list20.Count == 0)
																		{
																			list.Add(string.Concat(new string[]
																			{
																				text,
																				"[",
																				num11.ToString(),
																				"]",
																				": ",
																				"Null"
																			}));
																		}
																		else if (list20.Count == 1)
																		{
																			list.Add(string.Concat(new string[]
																			{
																				text,
																				"[",
																				num11.ToString(),
																				"]",
																				": ",
																				list20[0]
																			}));
																		}
																		else
																		{
																			list.Add(string.Concat(new string[]
																			{
																				text,
																				"[",
																				num11.ToString(),
																				"]",
																				":"
																			}));
																			list.AddRange(list20);
																		}
																		list20.Clear();
																	}
																}
															}
															else
															{
																Dictionary<byte, int> dictionary = gparam_0 as Dictionary<byte, int>;
																if (dictionary != null)
																{
																	using (Dictionary<byte, int>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
																	{
																		while (enumerator.MoveNext())
																		{
																			byte key = enumerator.Current;
																			try
																			{
																				int num3 = dictionary[key];
																				List<string> list21 = GClass84.smethod_46<int>(num3, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																				if (list21.Count == 0)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key.ToString(),
																						", ",
																						"Value",
																						" = ",
																						"Null"
																					}));
																				}
																				else if (list21.Count == 1)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key.ToString(),
																						", ",
																						"Value",
																						" = ",
																						list21[0]
																					}));
																				}
																				else
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key.ToString(),
																						", ",
																						"Value",
																						":"
																					}));
																					list.AddRange(list21);
																				}
																				list21.Clear();
																			}
																			catch (Exception ex)
																			{
																				list.Add(ex.Message);
																			}
																		}
																		goto IL_1603;
																	}
																}
																Dictionary<byte, object> dictionary2 = gparam_0 as Dictionary<byte, object>;
																if (dictionary2 != null)
																{
																	using (Dictionary<byte, object>.KeyCollection.Enumerator enumerator2 = dictionary2.Keys.GetEnumerator())
																	{
																		while (enumerator2.MoveNext())
																		{
																			byte key2 = enumerator2.Current;
																			try
																			{
																				object obj = dictionary2[key2];
																				List<string> list22 = GClass84.smethod_46<object>(obj, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																				if (list22.Count == 0)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key2.ToString(),
																						", ",
																						"Value",
																						" = ",
																						"Null"
																					}));
																				}
																				else if (list22.Count == 1)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key2.ToString(),
																						", ",
																						"Value",
																						" = ",
																						list22[0]
																					}));
																				}
																				else
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						key2.ToString(),
																						", ",
																						"Value",
																						":"
																					}));
																					list.AddRange(list22);
																				}
																				list22.Clear();
																			}
																			catch (Exception ex2)
																			{
																				list.Add(ex2.Message);
																			}
																		}
																		goto IL_1603;
																	}
																}
																Dictionary<string, object> dictionary3 = gparam_0 as Dictionary<string, object>;
																if (dictionary3 != null)
																{
																	using (Dictionary<string, object>.KeyCollection.Enumerator enumerator3 = dictionary3.Keys.GetEnumerator())
																	{
																		while (enumerator3.MoveNext())
																		{
																			string text3 = enumerator3.Current;
																			try
																			{
																				object obj = dictionary3[text3];
																				List<string> list23 = GClass84.smethod_46<object>(obj, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																				if (list23.Count == 0)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						text3,
																						", ",
																						"Value",
																						" = ",
																						"Null"
																					}));
																				}
																				else if (list23.Count == 1)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						"=",
																						text3,
																						", ",
																						"Value",
																						" = ",
																						list23[0]
																					}));
																				}
																				else
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						text3,
																						", ",
																						"Value",
																						":"
																					}));
																					list.AddRange(list23);
																				}
																				list23.Clear();
																			}
																			catch (Exception ex3)
																			{
																				list.Add(ex3.Message);
																			}
																		}
																		goto IL_1603;
																	}
																}
																Hashtable hashtable;
																bool flag7;
																if (bool_11)
																{
																	hashtable = (gparam_0 as Hashtable);
																	flag7 = (hashtable != null);
																}
																else
																{
																	flag7 = false;
																}
																if (flag7)
																{
																	using (IEnumerator enumerator4 = hashtable.Keys.GetEnumerator())
																	{
																		while (enumerator4.MoveNext())
																		{
																			object obj2 = enumerator4.Current;
																			try
																			{
																				object obj = hashtable[obj2];
																				List<string> list24 = GClass84.smethod_46<object>(obj, int_1 + int_2, int_2, true, bool_11, bool_12, bool_13, bool_14);
																				if (list24.Count == 0)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						(obj2 != null) ? obj2.ToString() : null,
																						", ",
																						"Value",
																						" = ",
																						"Null"
																					}));
																				}
																				else if (list24.Count == 1)
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						(obj2 != null) ? obj2.ToString() : null,
																						", ",
																						"Value",
																						" = ",
																						list24[0]
																					}));
																				}
																				else
																				{
																					list.Add(string.Concat(new string[]
																					{
																						text,
																						"Key",
																						" = ",
																						(obj2 != null) ? obj2.ToString() : null,
																						", ",
																						"Value",
																						":"
																					}));
																					list.AddRange(list24);
																				}
																				list24.Clear();
																			}
																			catch (Exception ex4)
																			{
																				list.Add(ex4.Message);
																			}
																		}
																		goto IL_1603;
																	}
																}
																if (bool_10)
																{
																	List<string> list25 = list;
																	t = gparam_0;
																	list25.Add(t.ToString());
																}
																else
																{
																	List<string> list26 = list;
																	string str = text;
																	t = gparam_0;
																	list26.Add(str + t.ToString());
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						IL_1603:
						result = list;
					}
				}
			}
			catch (Exception ex5)
			{
				result = new List<string>
				{
					ex5.Message
				};
			}
			return result;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0005A5BC File Offset: 0x000587BC
		internal static GameObject smethod_47(Transform transform_0, string string_4)
		{
			GameObject result;
			if (!transform_0 || string.IsNullOrEmpty(string_4))
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_1606(transform_0, string_4);
				result = ((transform != null) ? transform.gameObject : null);
			}
			return result;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0005A5F8 File Offset: 0x000587F8
		internal static void smethod_48<T>(ref T gparam_0) where T : Object
		{
			if (gparam_0 != null)
			{
				ref T ptr = ref gparam_0;
				ptr.hideFlags |= 32;
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0005A638 File Offset: 0x00058838
		internal static MethodInfo[] smethod_49(IEnumerable<Type> ienumerable_0)
		{
			return GClass84.smethod_1080(ienumerable_0).ToArray();
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0005A654 File Offset: 0x00058854
		internal static GClass84.GStruct163 smethod_50(int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = false;
			bool flag2 = false;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			GClass84.GStruct163 gstruct = new GClass84.GStruct163(int_1, int_2 - int_3);
			GClass84.GStruct163 result;
			if (int_4 <= 0)
			{
				result = gstruct;
			}
			else
			{
				int i = int_3;
				int num8 = 1 - 2 * int_3;
				float num9 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num4 = (float)Math.Cos(1.5707963267948966 - (double)num9) * (float)int_3;
					num5 = (float)Math.Sin(1.5707963267948966 - (double)num9) * (float)int_3;
				}
				if (int_4 > 90)
				{
					num6 = (float)Math.Cos(7.8539816339744828 - (double)num9) * (float)int_3;
					num7 = (float)Math.Sin(7.8539816339744828 - (double)num9) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						if (num2 == 0 && !flag2)
						{
							gstruct.int_0 = int_1 + num;
							gstruct.int_1 = int_2 - i;
						}
					}
					else if ((int_4 <= 45 && (float)num <= num4) || (int_4 > 45 && (float)i >= num5))
					{
						gstruct.int_0 = int_1 + num;
						gstruct.int_1 = int_2 - i;
						num2 = 1;
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							if (num2 == 0)
							{
								if (int_4 == 180 && !flag2)
								{
									gstruct.int_0 = int_1 + num;
									gstruct.int_1 = int_2 + i;
									flag2 = true;
									num3 = 1;
								}
								else if (num3 == 1)
								{
									return gstruct;
								}
							}
						}
						else if ((int_4 <= 135 && (float)i <= -num7) || (int_4 > 135 && (float)num >= num6))
						{
							if (!flag)
							{
								gstruct.int_0 = int_1 + num;
								gstruct.int_1 = int_2 + i;
								flag = true;
								num2 = 2;
							}
							else if (num2 == 2)
							{
								return gstruct;
							}
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							if (num2 == 0 && !flag2)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 + i;
							}
						}
						else if ((int_4 <= 225 && (float)num <= -num6) || (int_4 > 225 && (float)i >= -num7))
						{
							gstruct.int_0 = int_1 - num;
							gstruct.int_1 = int_2 + i;
							num2 = 3;
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							if (num2 == 0)
							{
								if (int_4 == 360 && !flag2)
								{
									gstruct.int_0 = int_1 - num;
									gstruct.int_1 = int_2 - i;
									flag2 = true;
									num3 = 2;
								}
								else if (num3 == 2)
								{
									return gstruct;
								}
							}
						}
						else if ((int_4 <= 315 && (float)i <= num7) || (int_4 > 315 && (float)num >= -num6))
						{
							if (!flag)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 - i;
								flag = true;
								num2 = 4;
							}
							else if (num2 == 4)
							{
								return gstruct;
							}
						}
					}
					int num10 = 2 * (num8 + i) - 1;
					if (num8 < 0 && num10 <= 0)
					{
						num8 += 2 * ++num + 1;
					}
					else if (num8 > 0 && num10 > 0)
					{
						num8 -= 2 * --i + 1;
					}
					else
					{
						num8 += 2 * (++num - i--);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005AA08 File Offset: 0x00058C08
		internal static Transform smethod_51(GameObject gameObject_39, bool bool_10 = false)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				if (bool_10)
				{
					GClass84.smethod_662(gameObject_39.transform);
				}
				result = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"Avatar"
				});
			}
			return result;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0005AA50 File Offset: 0x00058C50
		internal static string smethod_52(ConsoleColor consoleColor_0)
		{
			return GClass84.smethod_1300(consoleColor_0);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0005AA64 File Offset: 0x00058C64
		internal static Texture2D smethod_53(int int_1, int int_2, List<GClass84.Struct17> list_51)
		{
			Texture2D result;
			try
			{
				Texture2D texture2D = GClass84.smethod_1362(int_1, int_2, list_51);
				GClass84.smethod_48<Texture2D>(ref texture2D);
				result = texture2D;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0005AA9C File Offset: 0x00058C9C
		internal static void smethod_54(string string_4, Vector3 vector3_0)
		{
			GClass84.smethod_1540(string_4, vector3_0);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		internal static void smethod_55(APIUser apiuser_0)
		{
			GClass84.smethod_438(apiuser_0);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005AAC4 File Offset: 0x00058CC4
		internal static List<GameObject> smethod_56()
		{
			List<GameObject> list = new List<GameObject>();
			Scene scene_;
			List<GameObject> result;
			if (!GClass84.smethod_1676(out scene_))
			{
				result = list;
			}
			else
			{
				List<GameObject> list2 = GClass84.smethod_579(scene_);
				for (int i = list2.Count - 1; i >= 0; i--)
				{
					if (list2[i].name == "_CustomAvatar")
					{
						list.Add(list2[i]);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005AB38 File Offset: 0x00058D38
		internal static GameObject smethod_57()
		{
			if (!GClass84.gameObject_23)
			{
				GClass84.gameObject_23 = GameObject.Find(GClass84.smethod_859());
			}
			return GClass84.gameObject_23;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005AB6C File Offset: 0x00058D6C
		internal static bool smethod_58(GameObject gameObject_39, GameObject gameObject_40, bool bool_10 = false, bool bool_11 = false)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_1022(gameObject_39.transform, gameObject_40.transform, bool_10, bool_11);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0005ABA8 File Offset: 0x00058DA8
		internal static void smethod_59(Collider collider_0)
		{
			GClass84.smethod_260(collider_0);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0005ABBC File Offset: 0x00058DBC
		internal static string smethod_60(IUser iuser_0)
		{
			return GClass84.smethod_1214(iuser_0);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0005ABD0 File Offset: 0x00058DD0
		internal static void smethod_61(List<GameObject> list_51, bool bool_10)
		{
			if (list_51 != null)
			{
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					GClass84.smethod_890(list_51[i], bool_10);
				}
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0005AC08 File Offset: 0x00058E08
		internal static void smethod_62()
		{
			try
			{
				GClass84.smethod_887();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0005AC3C File Offset: 0x00058E3C
		internal static USpeaker smethod_63(Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Public_get_USpeaker_0() : null;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005AC58 File Offset: 0x00058E58
		internal static string smethod_64(GameObject gameObject_39, GameObject gameObject_40)
		{
			string result;
			if (!gameObject_39)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(gameObject_39.transform, (gameObject_40 != null) ? gameObject_40.transform : null);
			}
			return result;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005AC94 File Offset: 0x00058E94
		internal static void smethod_65(Transform transform_0, bool bool_10)
		{
			if (transform_0)
			{
				Transform transform = GClass84.smethod_981();
				if (transform)
				{
					transform.position = transform_0.position;
					if (bool_10)
					{
						transform.rotation = transform_0.rotation;
					}
				}
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		internal static bool smethod_66(VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0 && GClass84.smethod_1511(GClass84.smethod_856(vrcplayer_0));
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005AD04 File Offset: 0x00058F04
		internal static List<GameObject> smethod_67()
		{
			return VRC_SceneDescriptor.Instance.DynamicPrefabs;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0005AD20 File Offset: 0x00058F20
		internal static void smethod_68(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_1313(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005AD40 File Offset: 0x00058F40
		internal static List<Transform> smethod_69(GameObject gameObject_39)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>
				{
					gameObject_39.transform
				};
				list.AddRange(GClass84.smethod_1495(gameObject_39.transform));
				result = list;
			}
			return result;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005AD88 File Offset: 0x00058F88
		internal static void smethod_70(this Player player_0)
		{
			GClass84.smethod_1389(player_0);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0005AD9C File Offset: 0x00058F9C
		internal static void smethod_71(VRCPlayer vrcplayer_0, bool bool_10)
		{
			GClass84.smethod_715(vrcplayer_0, bool_10);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		internal static void smethod_72()
		{
			for (int i = GClass84.list_42.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_42[i]);
			}
			GClass84.list_42.Clear();
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		internal static void smethod_73(Color color_0)
		{
			GClass84.smethod_468(color_0);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005AE08 File Offset: 0x00059008
		internal static void smethod_74(GameObject gameObject_39)
		{
			GClass84.smethod_587(gameObject_39);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0005AE1C File Offset: 0x0005901C
		internal static List<string> smethod_75<T>()
		{
			return Enum.GetNames(typeof(T)).ToList<string>();
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0005AE40 File Offset: 0x00059040
		internal static void smethod_76(float float_3, float float_4, float float_5)
		{
			GClass84.smethod_1294(GClass84.smethod_210() + float_3, GClass84.smethod_552() + float_4, GClass84.smethod_354() + float_5);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005AE68 File Offset: 0x00059068
		internal static bool smethod_77(GameObject gameObject_39, VRCPlayer vrcplayer_0, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			return gameObject_39 && vrcplayer_0 && !vrcplayer_0.transform && GClass84.smethod_535(gameObject_39, GClass84.smethod_272(vrcplayer_0.transform, genum47_0), bool_10);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0005AEB0 File Offset: 0x000590B0
		internal static void smethod_78(GameObject gameObject_39)
		{
			if (gameObject_39)
			{
				GClass84.smethod_1237(gameObject_39.transform);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0005AED4 File Offset: 0x000590D4
		internal static GameObject smethod_79(PlayerNet playerNet_0)
		{
			GameObject result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1213(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0005AF00 File Offset: 0x00059100
		internal static string smethod_80(string string_4 = "")
		{
			return GClass84.smethod_1440(string_4);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0005AF14 File Offset: 0x00059114
		internal static void smethod_81()
		{
			if (File.Exists("AbyssFunctions.dll"))
			{
				try
				{
					File.Delete("AbyssFunctions.dll");
				}
				catch
				{
				}
			}
			string text = Assembly.GetExecutingAssembly().GetName().Name + "." + "Resources" + ".";
			foreach (string text2 in Assembly.GetExecutingAssembly().GetManifestResourceNames())
			{
				string text3 = text2.Substring(text.Length);
				if (text3 == "AbyssFunctions.dll")
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2))
					{
						using (MemoryStream memoryStream = new MemoryStream((int)manifestResourceStream.Length))
						{
							manifestResourceStream.CopyTo(memoryStream);
							FileStream fileStream = File.Create(text3);
							byte[] array = memoryStream.ToArray();
							fileStream.Write(array, 0, array.Length);
							fileStream.Close();
							GClass84.intptr_0 = GClass84.LoadLibrary(text3);
							if (GClass84.intptr_0 == IntPtr.Zero)
							{
								int lastWin32Error = Marshal.GetLastWin32Error();
								ConsoleColor foregroundColor = Console.ForegroundColor;
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine(string.Concat(new string[]
								{
									"[",
									text3,
									"] ",
									"Something went wrong while loading library",
									". ",
									"Error Code",
									": ",
									lastWin32Error.ToString(),
									"\n",
									"Try installing this",
									":",
									"\n",
									"https",
									"://",
									"aka.ms/vs/17/release/vc_redist.x64.exe",
									"\n",
									"Client will work incorrectly without it",
									"."
								}));
								Console.ForegroundColor = foregroundColor;
							}
							else
							{
								IntPtr procAddress = GClass84.GetProcAddress(GClass84.intptr_0, "AbsInt");
								IntPtr procAddress2 = GClass84.GetProcAddress(GClass84.intptr_0, "AbsFloat");
								try
								{
									GClass84.delegate30_0 = Marshal.GetDelegateForFunctionPointer<GClass84.Delegate30>(procAddress);
									GClass84.delegate31_0 = Marshal.GetDelegateForFunctionPointer<GClass84.Delegate31>(procAddress2);
								}
								catch (Exception value)
								{
									Console.WriteLine(value);
								}
							}
						}
					}
					return;
				}
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0005B19C File Offset: 0x0005939C
		internal static List<GameObject> smethod_82(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<AimIK>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0005B1F0 File Offset: 0x000593F0
		internal static Transform smethod_83(Transform transform_0, bool bool_10 = false)
		{
			Transform result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				if (bool_10)
				{
					GClass84.smethod_662(transform_0);
				}
				result = GClass84.smethod_836(transform_0, new List<string>
				{
					"Avatar"
				});
			}
			return result;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0005B230 File Offset: 0x00059430
		internal static VRCAvatarManager smethod_84(PlayerNet playerNet_0)
		{
			return GClass84.smethod_1416(GClass84.smethod_800(playerNet_0));
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0005B24C File Offset: 0x0005944C
		internal static int smethod_85(Player player_0)
		{
			int result;
			if (!player_0)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_175(GClass84.smethod_478(player_0));
			}
			return result;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0005B278 File Offset: 0x00059478
		internal static PlayerNet smethod_86(VRCPlayerApi vrcplayerApi_0)
		{
			PlayerNet result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1333(GClass84.smethod_840(vrcplayerApi_0));
			}
			return result;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005B29C File Offset: 0x0005949C
		internal static Color32 smethod_87(Color32 color32_0)
		{
			Color32 result;
			if (GClass84.smethod_1640(color32_0))
			{
				result = color32_0;
			}
			else
			{
				if (color32_0.r > color32_0.g)
				{
					if (color32_0.r > color32_0.b)
					{
						color32_0.g = color32_0.r;
						color32_0.b = color32_0.r;
					}
				}
				else if (color32_0.g > color32_0.b)
				{
					color32_0.r = color32_0.g;
					color32_0.b = color32_0.g;
				}
				else
				{
					color32_0.r = color32_0.b;
					color32_0.g = color32_0.b;
				}
				result = color32_0;
			}
			return result;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0005B340 File Offset: 0x00059540
		internal static List<Transform> smethod_88(List<Component> list_51)
		{
			List<Transform> list = new List<Transform>();
			List<Transform> result;
			if (list_51 == null)
			{
				result = list;
			}
			else
			{
				for (int i = 0; i < list_51.Count; i++)
				{
					if (list_51[i])
					{
						list.Add(list_51[i].transform);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0005B394 File Offset: 0x00059594
		internal static Transform smethod_89(Transform transform_0)
		{
			return GClass84.smethod_1606(transform_0, "HmdPivot");
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0005B3B0 File Offset: 0x000595B0
		internal static List<GClass84.GStruct134> smethod_90(Mesh mesh_0)
		{
			List<GClass84.GStruct134> result;
			if (!mesh_0)
			{
				result = new List<GClass84.GStruct134>();
			}
			else
			{
				List<GClass84.GStruct134> list = new List<GClass84.GStruct134>();
				for (int i = 0; i < mesh_0.blendShapeCount; i++)
				{
					list.Add(new GClass84.GStruct134(mesh_0.GetBlendShapeName(i), i));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0005B400 File Offset: 0x00059600
		internal static Transform smethod_91()
		{
			GameObject gameObject = GClass84.smethod_1652();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0005B420 File Offset: 0x00059620
		internal static Transform smethod_92()
		{
			GameObject gameObject = GClass84.smethod_929();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0005B440 File Offset: 0x00059640
		internal static List<Transform> smethod_93(List<Scene> list_51, string string_4, bool bool_10)
		{
			List<Transform> result;
			if (list_51 == null)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_1105(list_51[i], string_4, bool_10));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0005B48C File Offset: 0x0005968C
		internal static List<GameObject> smethod_94(GameObject gameObject_39)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_471(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0005B4BC File Offset: 0x000596BC
		internal static List<GameObject> smethod_95(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<FABRIK>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0005B510 File Offset: 0x00059710
		internal static void smethod_96(GameObject gameObject_39)
		{
			GClass84.smethod_78(gameObject_39);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0005B524 File Offset: 0x00059724
		internal static Transform smethod_97()
		{
			GameObject gameObject = GClass84.smethod_1589();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0005B544 File Offset: 0x00059744
		internal static void smethod_98(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.list_43.Add(MelonCoroutines.Start(GClass84.smethod_863(vrcplayerApi_0)));
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0005B568 File Offset: 0x00059768
		internal static bool smethod_99(string string_4, out float float_3)
		{
			return float.TryParse(string_4, out float_3);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0005B57C File Offset: 0x0005977C
		internal static GameObject smethod_100(GClass156 gclass156_1, float float_3, float float_4, int int_1, int int_2)
		{
			return gclass156_1.method_222(float_3, float_4, int_1, int_2, GClass156.Enum10.const_1);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0005B598 File Offset: 0x00059798
		internal static List<VRC_Trigger.TriggerType> smethod_101(VRC_Trigger vrc_Trigger_0, out List<VRC_Trigger.TriggerEvent> list_51, bool bool_10 = false)
		{
			List<VRC_Trigger.TriggerType> list = new List<VRC_Trigger.TriggerType>();
			list_51 = new List<VRC_Trigger.TriggerEvent>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType > 0)
					{
						list_51.Add(vrc_Trigger_0.Triggers[i]);
						list.Add(vrc_Trigger_0.Triggers[i].TriggerType);
					}
				}
			}
			if (bool_10 && list.Count == list_51.Count)
			{
				int j = list.Count - 1;
				IL_D4:
				while (j >= 0)
				{
					for (int k = list.Count - 1; k > j; k--)
					{
						if (list[j] == list[k])
						{
							list.RemoveAt(k);
							list_51.RemoveAt(k);
							IL_CE:
							j--;
							goto IL_D4;
						}
					}
					goto IL_CE;
				}
			}
			return list;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0005B688 File Offset: 0x00059888
		internal static VRCUiManager smethod_102()
		{
			return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0005B69C File Offset: 0x0005989C
		internal static List<GameObject> smethod_103(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<Cloth>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0005B6F0 File Offset: 0x000598F0
		internal static bool smethod_104(Quaternion quaternion_0)
		{
			return !GClass84.smethod_793(quaternion_0) && !GClass84.smethod_1170(quaternion_0);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0005B71C File Offset: 0x0005991C
		internal static VRCPlayer smethod_105()
		{
			return GClass84.smethod_367(GClass84.smethod_126());
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0005B738 File Offset: 0x00059938
		internal static Transform smethod_106(GameObject gameObject_39)
		{
			return GClass84.smethod_755(gameObject_39, "HmdPivot");
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0005B754 File Offset: 0x00059954
		internal static void smethod_107(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			if (int_4 > 0)
			{
				int i = int_3;
				int num6 = 1 - 2 * int_3;
				float num7 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num7) * (float)int_3;
					num5 = (float)Math.Cos(1.5707963267948966 - (double)num7) * (float)int_3;
				}
				if (int_4 > 90 && int_4 < 360)
				{
					num2 = (float)Math.Sin(7.8539816339744828 - (double)num7) * (float)int_3;
					num3 = (float)Math.Cos(7.8539816339744828 - (double)num7) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
					}
					else if ((int_4 <= 45 && (float)num <= num5) || (int_4 > 45 && (float)i >= num4))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
						else if ((int_4 <= 135 && (float)i <= -num2) || (int_4 > 135 && (float)num >= num3))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
						else if ((int_4 <= 225 && (float)num <= -num3) || (int_4 > 225 && (float)i >= -num2))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
						}
						else if ((int_4 <= 315 && (float)i <= num2) || (int_4 > 315 && (float)num >= -num3))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
						}
					}
					int num8 = 2 * (num6 + i) - 1;
					if (num6 < 0 && num8 <= 0)
					{
						num6 += 2 * ++num + 1;
					}
					else if (num6 > 0 && num8 > 0)
					{
						num6 -= 2 * --i + 1;
					}
					else
					{
						num6 += 2 * (++num - i--);
					}
				}
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005BA18 File Offset: 0x00059C18
		internal static T smethod_108<T>(bool bool_10, T gparam_0, T gparam_1)
		{
			T result;
			if (bool_10)
			{
				result = gparam_0;
			}
			else
			{
				result = gparam_1;
			}
			return result;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0005BA30 File Offset: 0x00059C30
		internal static void smethod_109(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			int i = int_3;
			int num2 = 1 - 2 * int_3;
			while (i >= 0)
			{
				GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_4, int_4);
				GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_4, int_4);
				GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_4, int_4);
				GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_4, int_4);
				int num3 = 2 * (num2 + i) - 1;
				if (num2 < 0 && num3 <= 0)
				{
					num2 += 2 * ++num + 1;
				}
				else if (num2 > 0 && num3 > 0)
				{
					num2 -= 2 * --i + 1;
				}
				else
				{
					num2 += 2 * (++num - i--);
				}
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0005BAF8 File Offset: 0x00059CF8
		internal static void smethod_110(Vector3 vector3_0, bool bool_10)
		{
			GClass84.smethod_1231(vector3_0, bool_10);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0005BB0C File Offset: 0x00059D0C
		internal static bool smethod_111(string string_4)
		{
			return string_4 == "1" || GClass84.smethod_362(string_4) == GClass84.smethod_362("true");
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0005BB48 File Offset: 0x00059D48
		internal static Texture2D smethod_112(Bitmap bitmap_0)
		{
			Texture2D result;
			if (bitmap_0 == null)
			{
				result = null;
			}
			else
			{
				int width = bitmap_0.Width;
				int height = bitmap_0.Height;
				Texture2D texture2D = GClass84.smethod_1130(width, height);
				Color32[] array = new Color32[width * height];
				for (int i = 0; i < height; i++)
				{
					int num = height - i - 1;
					for (int j = 0; j < width; j++)
					{
						array[num * width + j] = GClass84.smethod_720(bitmap_0.GetPixel(j, i));
					}
				}
				texture2D.SetPixels32(array);
				texture2D.Apply();
				result = texture2D;
			}
			return result;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0005BBE0 File Offset: 0x00059DE0
		internal static string smethod_113(ApiAvatar apiAvatar_0)
		{
			string result;
			if (apiAvatar_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = string.Concat(new string[]
				{
					"name",
					": ",
					apiAvatar_0.name,
					"\n",
					"description",
					": ",
					apiAvatar_0.description,
					"\n",
					"id",
					": ",
					apiAvatar_0.id,
					"\n",
					"author",
					"Name",
					": ",
					apiAvatar_0.authorName,
					"\n",
					"author",
					"Id",
					": ",
					apiAvatar_0.authorId,
					"\n",
					"release",
					"Status",
					": ",
					apiAvatar_0.releaseStatus,
					"\n",
					"asset",
					"Url",
					": ",
					apiAvatar_0.assetUrl,
					"\n",
					"image",
					"Url",
					": ",
					apiAvatar_0.imageUrl,
					"\n",
					"thumbnail",
					"Image",
					"Url",
					": ",
					apiAvatar_0.thumbnailImageUrl,
					"\n",
					"platform",
					": ",
					apiAvatar_0.platform
				});
			}
			return result;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0005BDAC File Offset: 0x00059FAC
		internal static float smethod_114()
		{
			return USpeaker.field_Internal_Static_Single_1;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0005BDC0 File Offset: 0x00059FC0
		internal static void smethod_115()
		{
			for (int i = GClass84.list_45.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_45[i]);
			}
			GClass84.list_45.Clear();
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0005BE04 File Offset: 0x0005A004
		internal static VRCUiPage smethod_116(VRCUiPage vrcuiPage_0)
		{
			return GClass84.Delegate32_0(vrcuiPage_0);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0005BE20 File Offset: 0x0005A020
		internal static void smethod_117(UiVRCList uiVRCList_0)
		{
			GClass84.smethod_487(uiVRCList_0);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005BE34 File Offset: 0x0005A034
		internal static string smethod_118(Component component_0)
		{
			return GClass84.smethod_557(component_0);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0005BE48 File Offset: 0x0005A048
		internal static GClass84.GStruct163 smethod_119(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			GClass84.GStruct163 gstruct = new GClass84.GStruct163(int_1, int_2 - int_3);
			GClass84.GStruct163 result;
			if (int_4 <= 0)
			{
				result = gstruct;
			}
			else
			{
				int i = int_3;
				int num7 = 1 - 2 * int_3;
				float num8 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num3 = (float)Math.Cos(1.5707963267948966 - (double)num8) * (float)int_3;
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num8) * (float)int_3;
				}
				if (int_4 > 90)
				{
					num5 = (float)Math.Cos(7.8539816339744828 - (double)num8) * (float)int_3;
					num6 = (float)Math.Sin(7.8539816339744828 - (double)num8) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
						if (num2 == 0 && !flag2)
						{
							gstruct.int_0 = int_1 + num;
							gstruct.int_1 = int_2 - i;
						}
					}
					else if ((int_4 <= 45 && (float)num <= num3) || (int_4 > 45 && (float)i >= num4))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
						gstruct.int_0 = int_1 + num;
						gstruct.int_1 = int_2 - i;
						num2 = 1;
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
							if (num2 == 0 && (int_4 == 180 && !flag2))
							{
								gstruct.int_0 = int_1 + num;
								gstruct.int_1 = int_2 + i;
								flag2 = true;
							}
						}
						else if ((int_4 <= 135 && (float)i <= -num6) || (int_4 > 135 && (float)num >= num5))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
							if (!flag)
							{
								gstruct.int_0 = int_1 + num;
								gstruct.int_1 = int_2 + i;
								flag = true;
								num2 = 2;
							}
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
							if (num2 == 0 && !flag2)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 + i;
							}
						}
						else if ((int_4 <= 225 && (float)num <= -num5) || (int_4 > 225 && (float)i >= -num6))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
							gstruct.int_0 = int_1 - num;
							gstruct.int_1 = int_2 + i;
							num2 = 3;
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
							if (num2 == 0 && (int_4 == 360 && !flag2))
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 - i;
								flag2 = true;
							}
						}
						else if ((int_4 <= 315 && (float)i <= num6) || (int_4 > 315 && (float)num >= -num5))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
							if (!flag)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 - i;
								flag = true;
								num2 = 4;
							}
						}
					}
					int num9 = 2 * (num7 + i) - 1;
					if (num7 < 0 && num9 <= 0)
					{
						num7 += 2 * ++num + 1;
					}
					else if (num7 > 0 && num9 > 0)
					{
						num7 -= 2 * --i + 1;
					}
					else
					{
						num7 += 2 * (++num - i--);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0005C244 File Offset: 0x0005A444
		internal static short smethod_120(PlayerNet playerNet_0)
		{
			short result;
			if (!playerNet_0)
			{
				result = 0;
			}
			else
			{
				result = playerNet_0.field_Private_Int16_0;
			}
			return result;
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0005C268 File Offset: 0x0005A468
		internal static List<T> smethod_121<T>(this List<T> list_51)
		{
			List<T> result;
			if (list_51 == null)
			{
				result = null;
			}
			else
			{
				List<T> list = new List<T>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.Add(list_51[i]);
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0005C2A8 File Offset: 0x0005A4A8
		internal static IEnumerator smethod_122()
		{
			return new GClass84.Class122(0);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0005C2BC File Offset: 0x0005A4BC
		internal static GameObject smethod_123()
		{
			if (!GClass84.gameObject_29)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_29 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_29;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0005C31C File Offset: 0x0005A51C
		internal static GClass84.GStruct169 smethod_124(int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			GClass84.GStruct169 gstruct = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int index = 0;
			int index2 = 0;
			int index3 = 0;
			int index4 = 0;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			GClass84.GStruct169 result;
			if (int_4 <= 0)
			{
				result = gstruct;
			}
			else
			{
				int i = int_3;
				int num6 = 1 - 2 * int_3;
				float num7 = GClass84.smethod_1480((float)int_4);
				float num8 = (float)(int_3 / 2);
				if (int_4 < 90)
				{
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num7) * (float)int_3;
					num5 = (float)Math.Cos(1.5707963267948966 - (double)num7) * (float)int_3;
				}
				if (int_4 > 90 && int_4 < 360)
				{
					num2 = (float)Math.Sin(7.8539816339744828 - (double)num7) * (float)int_3;
					num3 = (float)Math.Cos(7.8539816339744828 - (double)num7) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						if (!flag)
						{
							index = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value = gstruct.list_1[index];
							value.int_0++;
							gstruct.list_1[index] = value;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value2 = gstruct.list_1[index];
							value2.int_1++;
							gstruct.list_1[index] = value2;
						}
					}
					else if ((int_4 <= 45 && (float)num <= num5) || (int_4 > 45 && (float)i >= num4))
					{
						if (!flag)
						{
							index = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value3 = gstruct.list_1[index];
							value3.int_0++;
							gstruct.list_1[index] = value3;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value4 = gstruct.list_1[index];
							value4.int_1++;
							gstruct.list_1[index] = value4;
						}
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value5 = gstruct.list_1[index2];
								value5.int_0++;
								gstruct.list_1[index2] = value5;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value6 = gstruct.list_1[index2];
								value6.int_1--;
								gstruct.list_1[index2] = value6;
								value6 = gstruct.list_1[index2];
								value6.int_1++;
								gstruct.list_1[index2] = value6;
							}
						}
						else if ((int_4 <= 135 && (float)i <= -num2) || (int_4 > 135 && (float)num >= num3))
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value7 = gstruct.list_1[index2];
								value7.int_0++;
								gstruct.list_1[index2] = value7;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value8 = gstruct.list_1[index2];
								value8.int_1--;
								gstruct.list_1[index2] = value8;
								value8 = gstruct.list_1[index2];
								value8.int_1++;
								gstruct.list_1[index2] = value8;
							}
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value9 = gstruct.list_0[index3];
								value9.int_0--;
								gstruct.list_0[index3] = value9;
								value9 = gstruct.list_1[index3];
								value9.int_0++;
								gstruct.list_1[index3] = value9;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value10 = gstruct.list_0[index3];
								value10.int_1--;
								gstruct.list_0[index3] = value10;
								value10 = gstruct.list_1[index3];
								value10.int_1++;
								gstruct.list_1[index3] = value10;
							}
						}
						else if ((int_4 <= 225 && (float)num <= -num3) || (int_4 > 225 && (float)i >= -num2))
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value11 = gstruct.list_0[index3];
								value11.int_0--;
								gstruct.list_0[index3] = value11;
								value11 = gstruct.list_1[index3];
								value11.int_0++;
								gstruct.list_1[index3] = value11;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value12 = gstruct.list_0[index3];
								value12.int_1--;
								gstruct.list_0[index3] = value12;
								value12 = gstruct.list_1[index3];
								value12.int_1++;
								gstruct.list_1[index3] = value12;
							}
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							if (!flag)
							{
								index4 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value13 = gstruct.list_0[index4];
								value13.int_0--;
								gstruct.list_0[index4] = value13;
								value13 = gstruct.list_1[index4];
								value13.int_0++;
								gstruct.list_1[index4] = value13;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value14 = gstruct.list_1[index4];
								value14.int_1++;
								gstruct.list_1[index4] = value14;
							}
						}
						else if ((int_4 <= 315 && (float)i <= num2) || (int_4 > 315 && (float)num >= -num3))
						{
							if (!flag)
							{
								index4 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value15 = gstruct.list_0[index4];
								value15.int_0--;
								gstruct.list_0[index4] = value15;
								value15 = gstruct.list_1[index4];
								value15.int_0++;
								gstruct.list_1[index4] = value15;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value16 = gstruct.list_1[index4];
								value16.int_1++;
								gstruct.list_1[index4] = value16;
							}
						}
					}
					int num9 = 2 * (num6 + i) - 1;
					flag = false;
					if (num6 < 0 && num9 <= 0)
					{
						num6 += 2 * ++num + 1;
						if (flag2 || (float)num <= num8)
						{
							flag = true;
							flag2 = true;
						}
					}
					else
					{
						if (flag2)
						{
							flag2 = false;
						}
						if (num6 > 0 && num9 > 0)
						{
							num6 -= 2 * --i + 1;
							if (flag3 || (float)num >= num8)
							{
								flag = true;
								flag3 = true;
							}
						}
						else
						{
							if (flag3)
							{
								flag3 = false;
							}
							num6 += 2 * (++num - i--);
						}
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0005CC14 File Offset: 0x0005AE14
		internal static List<Transform> smethod_125(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>
				{
					transform_0
				};
				list.AddRange(GClass84.smethod_1495(transform_0));
				result = list;
			}
			return result;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0005CC50 File Offset: 0x0005AE50
		internal static Player smethod_126()
		{
			IUser user = GClass84.smethod_1704();
			if (user != null)
			{
				string text = GClass84.smethod_214(user);
				if (text == string.Empty)
				{
					return null;
				}
				Player[] array = GClass84.smethod_870();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					if (GClass84.smethod_684(array[i]) == text)
					{
						return array[i];
					}
				}
			}
			return null;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0005CCC4 File Offset: 0x0005AEC4
		internal static void smethod_127(float float_3)
		{
			List<PortalInternal> list = GClass84.smethod_1120();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				GClass84.smethod_563(list[i], float_3);
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0005CCFC File Offset: 0x0005AEFC
		internal static void smethod_128(Player player_0)
		{
			if (!player_0)
			{
				GClass70.smethod_38("Player Is Null!", GClass70.Enum1.const_0);
			}
			else if (Object.FindObjectOfType<VRC_SceneDescriptor>())
			{
				VRC_ObjectSync vrc_ObjectSync = Resources.FindObjectsOfTypeAll<VRC_ObjectSync>().FirstOrDefault(new Func<VRC_ObjectSync, bool>(GClass84.Class101.class101_0.method_4));
				if (vrc_ObjectSync)
				{
					MelonCoroutines.Start(GClass84.smethod_1483(vrc_ObjectSync.transform, player_0));
				}
				else
				{
					GClass70.smethod_38("World is invalid.", GClass70.Enum1.const_0);
				}
			}
			else
			{
				UdonBehaviour udonBehaviour = Resources.FindObjectsOfTypeAll<UdonBehaviour>().FirstOrDefault(new Func<UdonBehaviour, bool>(GClass84.Class101.class101_0.method_30));
				if (udonBehaviour)
				{
					MelonCoroutines.Start(GClass84.smethod_1483(udonBehaviour.transform, player_0));
				}
				else
				{
					GClass70.smethod_38("World is invalid.", GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
		internal static void smethod_129()
		{
			GClass84.smethod_902();
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0005CDE8 File Offset: 0x0005AFE8
		internal static GameObject smethod_130()
		{
			return GClass84.smethod_451(GClass84.smethod_460());
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0005CE04 File Offset: 0x0005B004
		internal static void smethod_131()
		{
			GClass84.smethod_1459();
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0005CE18 File Offset: 0x0005B018
		internal static VRC_EventLog.EventReplicator smethod_132()
		{
			VRC_EventLog vrc_EventLog = GClass84.smethod_1376();
			return (vrc_EventLog != null) ? vrc_EventLog.field_Internal_EventReplicator_0 : null;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0005CE38 File Offset: 0x0005B038
		internal static void smethod_133()
		{
			GClass84.smethod_302();
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0005CE4C File Offset: 0x0005B04C
		internal static Transform smethod_134(VRCPlayer vrcplayer_0)
		{
			Transform result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_662(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0005CE78 File Offset: 0x0005B078
		internal static string smethod_135()
		{
			return GClass84.smethod_656();
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0005CE8C File Offset: 0x0005B08C
		internal static void smethod_136()
		{
			for (int i = GClass84.list_47.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_47[i]);
			}
			GClass84.list_47.Clear();
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005CED0 File Offset: 0x0005B0D0
		internal static void smethod_137(Slider slider_0)
		{
			if (slider_0)
			{
				slider_0.onValueChanged = new Slider.SliderEvent();
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0005CEF4 File Offset: 0x0005B0F4
		internal static GameObject smethod_138(GameObject gameObject_39, string string_4)
		{
			GameObject result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_693(gameObject_39.transform, string_4);
				result = ((transform != null) ? transform.gameObject : null);
			}
			return result;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0005CF2C File Offset: 0x0005B12C
		private static string smethod_139(string string_4)
		{
			string result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = string.Concat(sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(string_4)).Select(new Func<byte, string>(GClass84.Class101.class101_0.method_8))).Substring(0, 16);
			}
			return result;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		internal static void smethod_140()
		{
			GClass84.smethod_328();
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
		internal static void smethod_141(float float_3, Action action_0)
		{
			GClass84.smethod_184(float_3, action_0);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0005CFC8 File Offset: 0x0005B1C8
		internal static void smethod_142(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, string string_7, bool bool_11, Action<VRCUiPopup> action_1)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_InputType_Boolean_String_Action_3_String_List_1_KeyCode_Text_String_Boolean_Action_1_VRCUiPopup_PDM_0(string_4, string_5, inputType_0, bool_10, string_6, action_0, string_7, bool_11, action_1);
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0005CFF4 File Offset: 0x0005B1F4
		internal static void smethod_143()
		{
			GClass84.smethod_36();
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0005D008 File Offset: 0x0005B208
		internal static void smethod_144(APIUser apiuser_0)
		{
			GClass84.smethod_1705(apiuser_0);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005D01C File Offset: 0x0005B21C
		internal static void smethod_145()
		{
			GClass84.smethod_1613();
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005D030 File Offset: 0x0005B230
		internal static bool smethod_146(VRCPlayer vrcplayer_0, out EnumPublicSealedva5vUnique enumPublicSealedva5vUnique_0)
		{
			return vrcplayer_0.Method_Public_Boolean_byref_EnumPublicSealedva5vUnique_0(ref enumPublicSealedva5vUnique_0);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0007A9DC File Offset: 0x00078BDC
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0005D044 File Offset: 0x0005B244
		internal static GClass52 GClass52_0
		{
			get
			{
				if (GClass84.gclass52_0 == null)
				{
					GClass84.gclass52_0 = new GClass52();
				}
				return GClass84.gclass52_0;
			}
			set
			{
				GClass84.smethod_992(value);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0005D058 File Offset: 0x0005B258
		internal static void smethod_147(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_561(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005D078 File Offset: 0x0005B278
		internal static GameObject smethod_148(VRCPlayer vrcplayer_0)
		{
			GameObject result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_172(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005D0A4 File Offset: 0x0005B2A4
		internal static string smethod_149(Transform transform_0, GameObject gameObject_39)
		{
			string result;
			if (!transform_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(transform_0, (gameObject_39 != null) ? gameObject_39.transform : null);
			}
			return result;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		internal static void smethod_150()
		{
			GClass84.list_49.Add(MelonCoroutines.Start(GClass84.smethod_1371()));
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005D0FC File Offset: 0x0005B2FC
		internal static void smethod_151(ApiAvatar apiAvatar_0, string string_4, APIUser apiuser_0, string string_5, string string_6, string string_7, string string_8, string string_9, List<string> list_51, string string_10)
		{
			GClass84.smethod_170(apiAvatar_0, string_4, apiuser_0, string_5, string_6, string_7, string_8, string_9, list_51, string_10);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005D12C File Offset: 0x0005B32C
		internal static List<Transform> smethod_152(GameObject gameObject_39)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_403(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005D15C File Offset: 0x0005B35C
		internal static void smethod_153(float float_3)
		{
			GClass84.smethod_851(float_3);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005D170 File Offset: 0x0005B370
		internal static void smethod_154(Color color_0, string string_4)
		{
			GClass84.list_35.Add(new GClass84.GStruct174(string_4, color_0, 3f));
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0005D194 File Offset: 0x0005B394
		internal static Vector3 smethod_155(Quaternion quaternion_0)
		{
			return Vector3.Normalize(quaternion_0 * Vector3.forward);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
		internal static string smethod_156(int int_1)
		{
			return GClass84.smethod_1629(int_1);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005D1C8 File Offset: 0x0005B3C8
		internal static Transform smethod_157(VRCPlayerApi vrcplayerApi_0)
		{
			Transform result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1068(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0005D1EC File Offset: 0x0005B3EC
		internal static void smethod_158()
		{
			GClass84.smethod_1696(0f);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0005D204 File Offset: 0x0005B404
		internal static bool smethod_159(List<GameObject> list_51, Transform transform_0, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null || !transform_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1035(list_51[i], transform_0, genum47_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0005D258 File Offset: 0x0005B458
		internal static string smethod_160(GameObject gameObject_39)
		{
			string result;
			if (!gameObject_39)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(gameObject_39.transform, null);
			}
			return result;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0005D288 File Offset: 0x0005B488
		internal static void smethod_161(string string_4, string string_5, string string_6, NotificationDetails notificationDetails_0)
		{
			GClass84.smethod_1703(string_4, string_5, string_6, notificationDetails_0);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		internal static void smethod_162(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			GClass84.smethod_1364(gclass156_1, int_1, int_2, int_3, int_4, int_5, int_6);
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_5);
			GClass84.GStruct163 gstruct2 = GClass84.smethod_50(int_1, int_2, int_3, (int_5 + int_4) % 360);
			if (!GClass84.GStruct163.smethod_0(gstruct, gstruct2))
			{
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, int_6);
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct2.int_0, gstruct2.int_1, int_6);
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0005D310 File Offset: 0x0005B510
		internal static byte[] smethod_163(IntPtr intptr_1, int int_1, int int_2 = 0)
		{
			byte[] array = new byte[int_1];
			for (int i = 0; i < int_1; i++)
			{
				array[i] = Marshal.ReadByte(intptr_1, int_2 + i);
			}
			return array;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0005D344 File Offset: 0x0005B544
		internal static GameObject[] smethod_164(Transform transform_0)
		{
			GameObject[] result;
			if (!transform_0)
			{
				result = new GameObject[0];
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					Transform child = transform_0.GetChild(i);
					list.Add(child.gameObject);
					list.AddRange(GClass84.smethod_471(child));
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		internal static Transform smethod_165(VRCPlayer vrcplayer_0)
		{
			Transform result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1280(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0005D3D8 File Offset: 0x0005B5D8
		internal static bool smethod_166(Transform transform_0, GameObject gameObject_39)
		{
			return gameObject_39 && GClass84.smethod_497(transform_0, gameObject_39.transform);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0005D404 File Offset: 0x0005B604
		internal static void smethod_167(string string_4, List<string> list_51)
		{
			GClass84.smethod_1073(string_4, list_51);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0005D418 File Offset: 0x0005B618
		internal static void smethod_168()
		{
			GClass84.list_46.Add(MelonCoroutines.Start(GClass84.smethod_262()));
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0005D43C File Offset: 0x0005B63C
		internal static void smethod_169()
		{
			List<GameObject> list = GClass84.smethod_589();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i])
				{
					list[i].SetActive(false);
				}
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0005D484 File Offset: 0x0005B684
		internal static void smethod_170(ApiAvatar apiAvatar_0, string string_4, APIUser apiuser_0, string string_5, string string_6, string string_7, string string_8, string string_9, List<string> list_51, string string_10)
		{
			apiAvatar_0.id = string_4;
			apiAvatar_0.authorName = GClass84.smethod_828(apiuser_0, "");
			apiAvatar_0.authorId = apiuser_0.id;
			apiAvatar_0.name = string_5;
			apiAvatar_0.assetUrl = string_7;
			apiAvatar_0.imageUrl = string_6;
			apiAvatar_0.description = string_8;
			apiAvatar_0.releaseStatus = string_9;
			apiAvatar_0.tags = list_51;
			apiAvatar_0.unityPackageUrl = string_10;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0005D4EC File Offset: 0x0005B6EC
		internal static List<GameObject> smethod_171()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<VRC_AvatarPedestal>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0005D548 File Offset: 0x0005B748
		internal static GameObject smethod_172(Transform transform_0)
		{
			GameObject result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"_AvatarMirrorClone"
					});
				}
			}
			return result;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
		internal static void smethod_173(ref string string_4, string string_5, string string_6)
		{
			if (!(string_4 == string.Empty) && !(string_5 == string.Empty))
			{
				string_4 = string_4.Replace(string_5, string_6);
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		internal static GameObject smethod_174()
		{
			if (!GClass84.gameObject_19)
			{
				GClass84.gameObject_19 = GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase");
			}
			return GClass84.gameObject_19;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0005D610 File Offset: 0x0005B810
		internal static int smethod_175(PlayerNet playerNet_0)
		{
			int result;
			if (!playerNet_0)
			{
				result = 0;
			}
			else
			{
				result = ((playerNet_0.Method_Public_get_Byte_0() != 0) ? ((int)(1000f / (float)playerNet_0.Method_Public_get_Byte_0())) : 0);
			}
			return result;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0005D648 File Offset: 0x0005B848
		internal static bool smethod_176(GameObject gameObject_39, Transform transform_0, bool bool_10 = false, bool bool_11 = false)
		{
			return gameObject_39 && transform_0 && GClass84.smethod_466(gameObject_39.transform, transform_0, bool_10, bool_11);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0005D680 File Offset: 0x0005B880
		internal static Color smethod_177(Player player_0)
		{
			return GClass84.smethod_1041(GClass84.smethod_307(GClass84.smethod_518(player_0)));
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0005D6A0 File Offset: 0x0005B8A0
		internal static void smethod_178(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			int num = 0;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			int_5 = GClass84.smethod_1551(int_5, -360, 360);
			int_5 = GClass84.smethod_108<int>(int_5 < 0, 360 + int_5, int_5);
			int_5 = GClass84.smethod_108<int>(int_5 == 360, 0, int_5);
			float num2 = (float)((int_4 + int_5) % 360);
			if (int_5 == 0)
			{
				GClass84.smethod_736(gclass156_1, int_1, int_2, int_3, int_4);
			}
			else if (int_4 > 0)
			{
				int i = int_3;
				int num3 = 1 - 2 * int_3;
				float num4 = GClass84.smethod_1480((float)int_5);
				float num5 = GClass84.smethod_1480(num2);
				float num6 = (float)Math.Cos(1.5707963267948966 - (double)num4) * (float)int_3;
				float num7 = (float)Math.Sin(1.5707963267948966 - (double)num4) * (float)int_3;
				float num8 = (float)Math.Cos(1.5707963267948966 - (double)num5) * (float)int_3;
				float num9 = (float)Math.Sin(1.5707963267948966 - (double)num5) * (float)int_3;
				float num10 = (float)Math.Cos(7.8539816339744828 - (double)num4) * (float)int_3;
				float num11 = (float)Math.Sin(7.8539816339744828 - (double)num4) * (float)int_3;
				float num12 = (float)Math.Cos(7.8539816339744828 - (double)num5) * (float)int_3;
				float num13 = (float)Math.Sin(7.8539816339744828 - (double)num5) * (float)int_3;
				while (i >= 0)
				{
					if (int_5 <= 360 && int_5 >= 90)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 90f)
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
							}
							else if (num2 > 0f && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
						}
						if ((num2 > 0f || num2 < 90f) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
						}
					}
					else if (num2 >= 90f)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
						}
					}
					else if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
					}
					if (int_5 <= 90)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 90f)
							{
								if (num2 >= 180f)
								{
									GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
								}
								else if ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12))
								{
									GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
					}
					else if (int_5 <= 360 && int_5 >= 180)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 180f)
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
							}
							else if (num2 > 90f && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
						if ((num2 > 90f || num2 < 180f) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
					}
					else if (num2 >= 180f)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
						}
					}
					else if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
					}
					if (int_5 <= 180)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 180f)
							{
								if (num2 >= 270f)
								{
									GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
								}
								else if ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13))
								{
									GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
					}
					else if (int_5 <= 360 && int_5 >= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 270f)
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
							}
							else if (num2 > 180f && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
						if ((num2 > 180f || num2 < 270f) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
					}
					else if (num2 >= 270f)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
						}
					}
					else if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
					}
					if (int_5 <= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 0f && num2 < 270f)
							{
								GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
							}
						}
						else if (num2 > 270f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
						}
						if (num2 > 270f && num2 < 360f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
						}
					}
					else if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10) && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
					{
						GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
					}
					int num14 = 2 * (num3 + i) - 1;
					if (num3 < 0 && num14 <= 0)
					{
						num3 += 2 * ++num + 1;
					}
					else if (num3 > 0 && num14 > 0)
					{
						num3 -= 2 * --i + 1;
					}
					else
					{
						num3 += 2 * (++num - i--);
					}
				}
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0005E088 File Offset: 0x0005C288
		internal static void smethod_179(Player player_0)
		{
			if (player_0)
			{
				GClass84.smethod_445(GClass84.smethod_518(player_0));
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0005E0AC File Offset: 0x0005C2AC
		internal static List<GameObject> smethod_180(GameObject gameObject_39, string string_4)
		{
			List<GameObject> list = new List<GameObject>();
			Transform transform = gameObject_39.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				GameObject gameObject = transform.GetChild(i).gameObject;
				if (gameObject.tag == string_4)
				{
					list.Add(gameObject);
				}
				else
				{
					list.AddRange(GClass84.smethod_180(gameObject, string_4));
				}
			}
			return list;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0005E110 File Offset: 0x0005C310
		internal static void smethod_181()
		{
			GClass84.smethod_1609(Color.red, "Failed to Yoink Avatar.");
			GClass70.smethod_117(ConsoleColor.DarkRed, "Failed to Yoink Avatar.", GClass70.Enum1.const_0);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0005E138 File Offset: 0x0005C338
		internal static void smethod_182(Button button_0)
		{
			if (button_0)
			{
				button_0.onClick = new Button.ButtonClickedEvent();
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0005E15C File Offset: 0x0005C35C
		internal static int smethod_183(string string_4)
		{
			int num;
			int result;
			if (int.TryParse(string_4, out num))
			{
				result = num;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0005E17C File Offset: 0x0005C37C
		internal static void smethod_184(float float_3, Action action_0)
		{
			GClass84.smethod_1524(float_3, action_0);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0005E190 File Offset: 0x0005C390
		internal static void smethod_185(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_20(vrcplayer_0);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0005E1A4 File Offset: 0x0005C3A4
		internal static void smethod_186(IUser iuser_0)
		{
			if (iuser_0 != null)
			{
				UIManagerImpl.Method_Public_Static_get_UIManagerImpl_0().Method_Public_Virtual_Final_New_Void_IUser_0(iuser_0);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0005E1C4 File Offset: 0x0005C3C4
		internal static string smethod_187(GameObject gameObject_39, Transform transform_0)
		{
			string result;
			if (!gameObject_39)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(gameObject_39.transform, transform_0);
			}
			return result;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0005E1F4 File Offset: 0x0005C3F4
		internal static List<GameObject> smethod_188(Transform transform_0, int int_1)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else if (int_1 == 1)
			{
				result = GClass84.smethod_266(transform_0);
			}
			else
			{
				result = GClass84.smethod_1082(GClass84.smethod_403(transform_0), int_1 - 1);
			}
			return result;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0005E234 File Offset: 0x0005C434
		internal static void smethod_189(bool bool_10)
		{
			GClass84.smethod_1555(bool_10);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0005E248 File Offset: 0x0005C448
		internal static void smethod_190(ApiAvatar apiAvatar_0, string string_4, string string_5, string string_6)
		{
			GClass84.smethod_42(apiAvatar_0, string_4, string_5, string_6);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0005E260 File Offset: 0x0005C460
		internal static bool smethod_191(VRCPlayerApi vrcplayerApi_0, GameObject gameObject_39)
		{
			bool result;
			if (vrcplayerApi_0 == null || !gameObject_39)
			{
				result = false;
			}
			else
			{
				Networking.SetOwner(vrcplayerApi_0, gameObject_39);
				result = true;
			}
			return result;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0005E28C File Offset: 0x0005C48C
		internal static void smethod_192<T>(ref T gparam_0, ref T gparam_1)
		{
			T t = gparam_0;
			gparam_0 = gparam_1;
			gparam_1 = t;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
		internal static List<GameObject> smethod_193(GameObject gameObject_39, int int_1)
		{
			List<GameObject> result;
			if (!gameObject_39 || int_1 < 1)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_188(gameObject_39.transform, int_1);
			}
			return result;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0005E2E8 File Offset: 0x0005C4E8
		internal static void smethod_194(Transform transform_0)
		{
			GClass84.smethod_12(transform_0);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0005E2FC File Offset: 0x0005C4FC
		internal static Transform smethod_195()
		{
			GameObject gameObject = GClass84.smethod_644();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0005E31C File Offset: 0x0005C51C
		internal static void smethod_196(float float_3, float float_4)
		{
			GClass84.smethod_202(float_3, float_4);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0005E330 File Offset: 0x0005C530
		internal static Texture2D smethod_197(string string_4)
		{
			Texture2D result;
			try
			{
				result = GClass84.smethod_112(new Bitmap(string_4));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0005E364 File Offset: 0x0005C564
		internal static void smethod_198()
		{
			List<string> list = GClass84.smethod_870().Where(new Func<Player, bool>(GClass84.Class101.class101_0.method_22)).Select(new Func<Player, ApiAvatar>(GClass84.Class101.class101_0.method_18)).Where(new Func<ApiAvatar, bool>(GClass84.Class101.class101_0.method_16)).Select(new Func<ApiAvatar, string>(GClass84.Class101.class101_0.method_15)).ToList<string>();
			Dictionary<string, AssetBundleDownload> dictionary = new Dictionary<string, AssetBundleDownload>();
			AssetBundleDownloadManager assetBundleDownloadManager = GClass84.smethod_558();
			foreach (string text in assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0.Keys)
			{
				dictionary.Add(text, assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0[text]);
			}
			foreach (string text2 in dictionary.Keys)
			{
				AssetBundleDownload assetBundleDownload = assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0[text2];
				if (!assetBundleDownload.field_Private_String_0.Contains("wrld_") && !list.Contains(text2))
				{
					assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0.Remove(text2);
					GameObject gameObject = assetBundleDownload.Method_Public_get_GameObject_0();
					if (gameObject != null)
					{
						Object.DestroyImmediate(gameObject, true);
					}
				}
			}
			dictionary.Clear();
			Resources.UnloadUnusedAssets();
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		internal static bool smethod_199()
		{
			string string_;
			bool result;
			if (GClass84.smethod_934(out string_))
			{
				MelonCoroutines.Start(GClass84.smethod_935(string_));
				result = true;
			}
			else
			{
				GClass70.smethod_38("Can't Get Avatar!", GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0005E530 File Offset: 0x0005C730
		internal static void smethod_200()
		{
			GClass84.smethod_62();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0005E544 File Offset: 0x0005C744
		internal static IEnumerator smethod_201(List<string> list_51, string string_4)
		{
			GClass84.Class111 @class = new GClass84.Class111(0);
			@class.list_0 = list_51;
			@class.string_0 = string_4;
			return @class;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0005E568 File Offset: 0x0005C768
		internal static void smethod_202(float float_3, float float_4)
		{
			GClass84.smethod_1294(GClass84.smethod_210() + float_3, GClass84.smethod_552() + float_3, GClass84.smethod_354() + float_4);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0005E590 File Offset: 0x0005C790
		internal static string smethod_203(GameObject gameObject_39)
		{
			return GClass84.smethod_160(gameObject_39);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005E5A4 File Offset: 0x0005C7A4
		internal static Color smethod_204(APIUser apiuser_0, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false)
		{
			Color result;
			if (apiuser_0 == null)
			{
				result = Color.white;
			}
			else if (bool_12 && GClass84.smethod_1511(apiuser_0))
			{
				result = Color.yellow;
			}
			else
			{
				switch (GClass84.smethod_1387(apiuser_0, false))
				{
				case GClass84.Enum5.const_1:
					result = Color.blue;
					break;
				case GClass84.Enum5.const_2:
					result = Color.green;
					break;
				case GClass84.Enum5.const_3:
					result = Color.red;
					break;
				case GClass84.Enum5.const_4:
					result = Color.magenta;
					break;
				case GClass84.Enum5.const_5:
					if (bool_10)
					{
						result = Color.yellow;
					}
					else
					{
						result = Color.magenta;
					}
					break;
				case GClass84.Enum5.const_6:
					if (bool_11)
					{
						result = Color.black;
					}
					else if (bool_10)
					{
						result = Color.yellow;
					}
					else
					{
						result = Color.magenta;
					}
					break;
				default:
					result = Color.white;
					break;
				}
			}
			return result;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0005E660 File Offset: 0x0005C860
		internal static void smethod_205(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_119(gclass156_1, int_1, int_2, int_3, int_4);
			if (gstruct.int_0 != int_1 || gstruct.int_1 != int_2 - int_3)
			{
				GClass84.smethod_1059(gclass156_1, int_1, int_2, int_1, int_2 - int_3, 0);
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, 0);
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005E6B4 File Offset: 0x0005C8B4
		internal static void smethod_206(ref string string_4, string string_5, string string_6)
		{
			GClass84.smethod_379(ref string_4, string_5, string_6);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0005E6CC File Offset: 0x0005C8CC
		internal static string smethod_207(string string_4, string string_5)
		{
			return string_4 + "." + string_5;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0005E6E8 File Offset: 0x0005C8E8
		internal static bool smethod_208(MethodBase methodBase_0, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_1123("Abyss Client_1.0.0", methodBase_0, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0005E704 File Offset: 0x0005C904
		internal static void smethod_209(string string_4, int int_1)
		{
			GameObject gameObject = GameObject.Find(string_4);
			if (!gameObject)
			{
				GClass70.smethod_38("!GO", GClass70.Enum1.const_0);
			}
			else
			{
				SkinnedMeshRenderer component = gameObject.GetComponent<SkinnedMeshRenderer>();
				if (!component)
				{
					GClass70.smethod_38("!SMR", GClass70.Enum1.const_0);
				}
				else
				{
					List<GClass84.GStruct134> list = GClass84.smethod_1728(component);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						GClass70.smethod_38(list[i].int_0.ToString() + ": " + list[i].string_0, GClass70.Enum1.const_0);
					}
					Mesh sharedMesh = component.sharedMesh;
					GClass84.smethod_321(sharedMesh, int_1);
				}
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
		internal static float smethod_210()
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			float result;
			if (locomotionInputController == null)
			{
				result = 0f;
			}
			else
			{
				result = locomotionInputController.field_Public_Single_2;
			}
			return result;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0005E7E4 File Offset: 0x0005C9E4
		internal static Transform[] smethod_211(List<Scene> list_51)
		{
			Transform[] result;
			if (list_51 == null)
			{
				result = new Transform[0];
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_725(list_51[i]));
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0005E834 File Offset: 0x0005CA34
		internal static int smethod_212(string string_4, string string_5, int int_1)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = -1;
			}
			else
			{
				result = string_4.LastIndexOf(string_5);
			}
			return result;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0005E86C File Offset: 0x0005CA6C
		internal static Texture2D smethod_213(Texture2D texture2D_0)
		{
			Color32[] array = texture2D_0.GetPixels32();
			Color32[] array2 = new Color32[array.Length];
			int width = texture2D_0.width;
			int height = texture2D_0.height;
			for (int i = 0; i < height; i++)
			{
				int num = height - i - 1;
				for (int j = 0; j < width; j++)
				{
					array2[(num + 1) * width - (j + 1)] = array[num * width + j];
				}
			}
			texture2D_0.SetPixels32(array2);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0005E900 File Offset: 0x0005CB00
		internal static string smethod_214(IUser iuser_0)
		{
			return GClass84.smethod_60(iuser_0);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0005E914 File Offset: 0x0005CB14
		internal static string smethod_215(Transform transform_0)
		{
			return GClass84.smethod_495(transform_0);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0005E928 File Offset: 0x0005CB28
		internal static List<GameObject> smethod_216(List<Scene> list_51, string string_4, bool bool_10)
		{
			List<GameObject> result;
			if (list_51 == null)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_1284(list_51[i], string_4, bool_10));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0005E974 File Offset: 0x0005CB74
		internal static bool smethod_217(Transform transform_0, Vector3 vector3_0)
		{
			return transform_0 && Vector3.Dot(Vector3.Normalize(vector3_0 - transform_0.position), transform_0.forward) > 0f;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
		internal static void smethod_218(bool bool_10)
		{
			GameObject gameObject = GClass84.smethod_130();
			if (gameObject && gameObject.activeSelf == bool_10)
			{
				gameObject.SetActive(!bool_10);
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0005E9EC File Offset: 0x0005CBEC
		internal static void smethod_219()
		{
			string text = "AbyssKey";
			string str = "Key.txt";
			bool? flag = null;
			if (Directory.Exists(text))
			{
				flag = new bool?(false);
			}
			bool? flag2 = flag;
			if ((!flag2.GetValueOrDefault() & flag2 != null) && File.Exists(text + "/" + "/" + str))
			{
				flag = new bool?(true);
			}
			flag2 = flag;
			if (flag2.GetValueOrDefault() & flag2 != null)
			{
				List<string> list = File.ReadAllLines(text + "/" + "/" + str).OfType<string>().ToList<string>();
				if (list.Count > 0)
				{
					GClass84.string_0 = list[0];
				}
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0005EAA8 File Offset: 0x0005CCA8
		internal static bool smethod_220(List<GameObject> list_51, bool bool_10 = true)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_636(list_51[i], true))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0005EAF0 File Offset: 0x0005CCF0
		internal static string smethod_221(bool bool_10 = false)
		{
			return GClass84.smethod_1303(bool_10);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0005EB04 File Offset: 0x0005CD04
		internal static void smethod_222(string string_4, bool bool_10)
		{
			CompiledMethod compiledMethod = GClass84.gclass194_0.Compile(string_4);
			if (compiledMethod != null)
			{
				try
				{
					object obj = null;
					compiledMethod.Invoke(ref obj);
					string value = (obj != null) ? obj.ToString() : null;
					if (!string.IsNullOrEmpty(value))
					{
						GClass70.smethod_38("Invoked REPL, result" + ": " + ((obj != null) ? obj.ToString() : null), GClass70.Enum1.const_0);
					}
					else
					{
						GClass70.smethod_38("Invoked REPL (no return value)", GClass70.Enum1.const_0);
					}
					return;
				}
				catch (Exception ex)
				{
					string str = "Exception invoking REPL";
					string str2 = ": ";
					Exception ex2 = ex;
					GClass70.smethod_51(str + str2 + ((ex2 != null) ? ex2.ToString() : null), GClass70.Enum1.const_0);
					return;
				}
			}
			string text = GClass194.textWriter_0.ToString();
			string[] array = text.Split(new char[]
			{
				'\n'
			});
			if (array.Length >= 2)
			{
				text = array[array.Length - 2];
			}
			GClass84.stringBuilder_0.Clear();
			if (GClass194.streamReportPrinter_0.ErrorsCount > 0)
			{
				GClass70.smethod_36("Unable to compile the code. Evaluator's last output was:\r" + "\n" + text, GClass70.Enum1.const_0);
			}
			else if (bool_10)
			{
				GClass70.smethod_38("Code compiled without errors.", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0005EC28 File Offset: 0x0005CE28
		internal static USpeaker smethod_223(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_63(GClass84.smethod_384(vrcplayer_0));
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0005EC44 File Offset: 0x0005CE44
		internal static List<GClass84.GStruct134> smethod_224(MeshFilter meshFilter_0)
		{
			List<GClass84.GStruct134> result;
			if (!meshFilter_0)
			{
				result = new List<GClass84.GStruct134>();
			}
			else
			{
				result = GClass84.smethod_90(meshFilter_0.sharedMesh);
			}
			return result;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0005EC74 File Offset: 0x0005CE74
		internal static bool smethod_225(Player player_0)
		{
			bool result;
			string string_;
			if (!player_0)
			{
				GClass70.smethod_38("Player Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else if (GClass84.smethod_1588(out string_))
			{
				GClass84.list_40.Add(GClass84.smethod_684(player_0));
				MelonCoroutines.Start(GClass84.smethod_201(GClass84.smethod_1264<string>(GClass84.list_40), string_));
				result = true;
			}
			else
			{
				GClass70.smethod_38("Can't Get Quest Avatar!", GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0005ECDC File Offset: 0x0005CEDC
		internal static void smethod_226(float float_3)
		{
			Player player = GClass84.smethod_1010();
			if (player)
			{
				MonoBehaviourPublicSimastSiofdiChSiLagrUnique component = player.GetComponent<MonoBehaviourPublicSimastSiofdiChSiLagrUnique>();
				if (component)
				{
					component.maxStepHeight = float_3;
				}
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0005ED14 File Offset: 0x0005CF14
		internal static string smethod_227(string string_4, int int_1)
		{
			return Path.Combine(GClass84.smethod_364(string_4, int_1), "__data");
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0005ED34 File Offset: 0x0005CF34
		internal static List<Transform> smethod_228(List<Scene> list_51)
		{
			List<Transform> result;
			if (list_51 == null)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_1020(list_51[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0005ED80 File Offset: 0x0005CF80
		internal static GameObject smethod_229()
		{
			if (!GClass84.gameObject_26)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_26 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_26;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
		internal static void smethod_230()
		{
			if (!GClass84.material_0)
			{
				Shader shader = Shader.Find("Hidden/Internal-Colored");
				GClass84.material_0 = new Material(shader)
				{
					hideFlags = 61
				};
				GClass84.material_0.SetInt("_SrcBlend", 5);
				GClass84.material_0.SetInt("_DstBlend", 10);
				GClass84.material_0.SetInt("_Cull", 0);
				GClass84.material_0.SetInt("_ZWrite", 0);
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0005EE58 File Offset: 0x0005D058
		internal static bool smethod_231(out Scene scene_0)
		{
			List<Scene> list = GClass84.smethod_311(true);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].name == "DontDestroyOnLoad")
				{
					scene_0 = list[i];
					return true;
				}
			}
			scene_0 = default(Scene);
			return false;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0005EEC0 File Offset: 0x0005D0C0
		internal static bool smethod_232(string string_4, Type type_0, string string_5, Type[] type_1, Type[] type_2, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			bool result;
			if (GClass84.smethod_1123(string_4, AccessTools.Method(type_0, string_5, type_1, type_2), harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
			{
				result = true;
			}
			else
			{
				string text = "Null";
				string text2 = "Null";
				string text3 = "Null";
				string text4 = "Null";
				string text5 = "Null";
				string text6 = "Null";
				if (type_0 != null)
				{
					text = type_0.Name;
				}
				if (type_1 != null)
				{
					text2 = string.Empty;
					foreach (Type type in type_1)
					{
						text2 = text2 + ", " + type.Name;
					}
					if (text2 != string.Empty)
					{
						text2 = "(" + GClass84.smethod_1204(text2, 2, -1) + ")";
					}
				}
				if (type_2 != null)
				{
					text3 = string.Empty;
					foreach (Type type2 in type_2)
					{
						text3 = text3 + ", " + type2.Name;
					}
					if (text3 != string.Empty)
					{
						text3 = "(" + GClass84.smethod_1204(text3, 2, -1) + ")";
					}
				}
				if (harmonyMethod_0 != null)
				{
					text4 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text5 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text6 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Method",
					" (",
					string_4,
					", ",
					text,
					", ",
					string_5,
					", ",
					text2,
					", ",
					text3,
					", ",
					text4,
					", ",
					text5,
					", ",
					text6,
					")"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0005F0F4 File Offset: 0x0005D2F4
		internal static GameObject smethod_233(GameObject gameObject_39)
		{
			GameObject result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"Avatar"
					});
				}
			}
			return result;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0005F154 File Offset: 0x0005D354
		internal static List<int> smethod_234(string string_4, string string_5, int int_1)
		{
			List<int> list = new List<int>();
			List<int> result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = list;
			}
			else
			{
				int num = 0;
				while (int_1 < GClass84.smethod_593(string_4))
				{
					if (string_4[int_1] == string_5[num])
					{
						num++;
						if (num == GClass84.smethod_593(string_5))
						{
							list.Add(int_1 - num);
							num = 0;
						}
					}
					else
					{
						num = 0;
					}
					int_1++;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		internal static Transform smethod_235()
		{
			GameObject gameObject = GClass84.smethod_1095();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0005F1F0 File Offset: 0x0005D3F0
		internal static void smethod_236(Renderer renderer_0, bool bool_10, ref HighlightsFXStandalone highlightsFXStandalone_1)
		{
			if (renderer_0)
			{
				if (GClass84.bool_9)
				{
					HighlightsFX.Method_Public_Static_Void_Renderer_Boolean_PDM_0(renderer_0, bool_10);
				}
				else
				{
					if (!highlightsFXStandalone_1)
					{
						GClass84.smethod_44(ref highlightsFXStandalone_1);
					}
					if (highlightsFXStandalone_1)
					{
						highlightsFXStandalone_1.Method_Public_Void_Renderer_Boolean_0(renderer_0, bool_10);
					}
				}
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0005F240 File Offset: 0x0005D440
		internal static void smethod_237(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				MelonCoroutines.Start(GClass84.smethod_1027(apiAvatar_0, GClass84.smethod_460()));
				VRCPlayer vrcplayer = GClass84.smethod_460();
				if (vrcplayer != null)
				{
					vrcplayer.Method_Internal_Void_ApiAvatar_0(apiAvatar_0);
				}
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0005F278 File Offset: 0x0005D478
		internal static string smethod_238(string string_4)
		{
			return GClass84.smethod_643(GClass84.smethod_126(), string_4);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0005F294 File Offset: 0x0005D494
		internal static string smethod_239(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_3, int_1);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
		internal static VRCUiCursor smethod_240()
		{
			VRCUiCursorManager vrcuiCursorManager = GClass84.smethod_615();
			return (vrcuiCursorManager != null) ? vrcuiCursorManager.field_Public_VRCUiCursor_0 : null;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0005F2D0 File Offset: 0x0005D4D0
		internal static void smethod_241(List<GameObject> list_51, GameObject gameObject_39)
		{
			GClass84.smethod_493(list_51, gameObject_39);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0005F2E4 File Offset: 0x0005D4E4
		internal static string smethod_242(UdonBehaviour udonBehaviour_0, int int_1)
		{
			return GClass84.smethod_522(udonBehaviour_0, int_1);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
		internal static void smethod_243(Button button_0, Action action_0)
		{
			GClass84.smethod_1464(button_0, action_0);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0005F30C File Offset: 0x0005D50C
		internal static List<GClass84.GStruct163> smethod_244(int int_1, int int_2, int int_3, int int_4)
		{
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			if (int_1 > int_3)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num2;
			int num5 = int_2;
			int num6 = int_4 - int_2;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_1; i <= int_3; i++)
			{
				list.Add(new GClass84.GStruct163(i, num5));
				num3 += num4;
				if (2 * num3 >= num)
				{
					num5 += num6;
					num3 -= num;
				}
			}
			return list;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0005F3B0 File Offset: 0x0005D5B0
		internal static bool smethod_245(string string_4)
		{
			bool result;
			if (string_4 == string.Empty)
			{
				GClass70.smethod_38("URL Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				foreach (SyncVideoPlayer syncVideoPlayer in Object.FindObjectsOfType<SyncVideoPlayer>())
				{
					if (syncVideoPlayer)
					{
						GClass84.smethod_994(syncVideoPlayer.gameObject);
						VRC_SyncVideoPlayer field_Private_VRC_SyncVideoPlayer_ = syncVideoPlayer.field_Private_VRC_SyncVideoPlayer_0;
						field_Private_VRC_SyncVideoPlayer_.Stop();
						field_Private_VRC_SyncVideoPlayer_.Clear();
						field_Private_VRC_SyncVideoPlayer_.AddURL(string_4);
						field_Private_VRC_SyncVideoPlayer_.Next();
						field_Private_VRC_SyncVideoPlayer_.Play();
					}
				}
				foreach (SyncVideoStream syncVideoStream in Object.FindObjectsOfType<SyncVideoStream>())
				{
					if (syncVideoStream)
					{
						GClass84.smethod_994(syncVideoStream.gameObject);
						VRC_SyncVideoStream field_Private_VRC_SyncVideoStream_ = syncVideoStream.field_Private_VRC_SyncVideoStream_0;
						field_Private_VRC_SyncVideoStream_.Stop();
						field_Private_VRC_SyncVideoStream_.Clear();
						field_Private_VRC_SyncVideoStream_.AddURL(string_4);
						field_Private_VRC_SyncVideoStream_.Next();
						field_Private_VRC_SyncVideoStream_.Play();
					}
				}
				foreach (VRCUrlInputField vrcurlInputField in Object.FindObjectsOfType<VRCUrlInputField>())
				{
					if (vrcurlInputField)
					{
						vrcurlInputField.text = string_4;
						vrcurlInputField.onEndEdit.Invoke(string_4);
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0005F530 File Offset: 0x0005D730
		internal static void smethod_246(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_290(GClass84.smethod_384(vrcplayer_0));
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0005F548 File Offset: 0x0005D748
		private static string smethod_247(string string_4)
		{
			return GClass84.smethod_839(string_4);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0005F55C File Offset: 0x0005D75C
		internal static void smethod_248(bool bool_10)
		{
			GameObject gameObject = GClass84.smethod_130();
			GClass84.smethod_174().SetActive(!bool_10);
			GClass84.smethod_1416(GClass84.smethod_460()).gameObject.SetActive(!bool_10);
			GClass84.smethod_558().gameObject.SetActive(!bool_10);
			if (gameObject)
			{
				gameObject.SetActive(!bool_10);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		internal static void smethod_249(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7, bool bool_11, Action<VRCUiPopup> action_2, bool bool_12)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_InputType_Boolean_String_Action_3_String_List_1_KeyCode_Text_Action_String_Boolean_Action_1_VRCUiPopup_Boolean_Int32_0(string_4, string_5, inputType_0, bool_10, string_6, action_0, action_1, string_7, bool_11, action_2, bool_12, 0);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005F5F4 File Offset: 0x0005D7F4
		internal static GameObject smethod_250()
		{
			if (!GClass84.gameObject_37)
			{
				GClass84.gameObject_37 = GClass84.smethod_1577("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote");
			}
			return GClass84.gameObject_37;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005F628 File Offset: 0x0005D828
		internal static void smethod_251()
		{
			GClass84.smethod_608();
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005F63C File Offset: 0x0005D83C
		internal static void smethod_252()
		{
			for (int i = GClass84.list_44.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_44[i]);
			}
			GClass84.list_44.Clear();
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0005F680 File Offset: 0x0005D880
		internal static GameObject smethod_253()
		{
			if (!GClass84.gameObject_22)
			{
				GClass84.gameObject_22 = GameObject.Find(GClass84.smethod_691());
			}
			return GClass84.gameObject_22;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		internal static Texture2D smethod_254(int int_1, int int_2, int int_3, Color32 color32_0, Color32 color32_1)
		{
			Texture2D result;
			try
			{
				Texture2D texture2D = GClass84.smethod_1512(int_1, int_2, int_3, color32_0, color32_1);
				GClass84.smethod_48<Texture2D>(ref texture2D);
				result = texture2D;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
		internal static void smethod_255(Vector3 vector3_0, Vector3 vector3_1, Color color_0)
		{
			if (!GClass84.material_0)
			{
				GClass84.smethod_810();
				if (!GClass84.material_0)
				{
					GClass70.smethod_36("LineMaterial is null!", GClass70.Enum1.const_0);
					return;
				}
			}
			GameObject gameObject = GameObject.Find("Camera (eye)");
			Camera camera = (gameObject != null) ? gameObject.GetComponent<Camera>() : null;
			if (!camera)
			{
				GClass70.smethod_36("C is null!", GClass70.Enum1.const_0);
			}
			else
			{
				Vector3 vector = camera.WorldToScreenPoint(vector3_0);
				vector.y = (float)Screen.height - vector.y;
				Vector3 vector2 = camera.WorldToScreenPoint(vector3_1);
				vector2.y = (float)Screen.height - vector2.y;
				if (vector.z > 0f && vector2.z > 0f)
				{
					GClass84.material_0.SetPass(0);
					GL.PushMatrix();
					GL.Begin(1);
					GL.Color(color_0);
					GL.Vertex(new Vector3(vector.x, vector.y, 0f));
					GL.Vertex(new Vector3(vector2.x, vector2.y, 0f));
					GL.End();
					GL.PopMatrix();
				}
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0005F81C File Offset: 0x0005DA1C
		internal static bool smethod_256(VRCPlayer vrcplayer_0)
		{
			EnumPublicSealedva5vUnique enumPublicSealedva5vUnique;
			return vrcplayer_0.Method_Public_Boolean_byref_EnumPublicSealedva5vUnique_0(ref enumPublicSealedva5vUnique);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0005F834 File Offset: 0x0005DA34
		internal static MenuStateController smethod_257()
		{
			GameObject gameObject = GClass84.smethod_229();
			return (gameObject != null) ? gameObject.GetComponent<MenuStateController>() : null;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0005F854 File Offset: 0x0005DA54
		internal static List<GameObject> smethod_258(List<Transform> list_51)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> result;
			if (list_51 == null)
			{
				result = list;
			}
			else
			{
				for (int i = 0; i < list_51.Count; i++)
				{
					if (list_51[i])
					{
						list.Add(list_51[i].gameObject);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0005F8A8 File Offset: 0x0005DAA8
		internal static void smethod_259(GameObject gameObject_39, bool bool_10)
		{
			if (gameObject_39)
			{
				Transform transform = gameObject_39.transform;
				if (transform && transform.childCount > 0)
				{
					for (int i = transform.childCount - 1; i >= 0; i--)
					{
						Transform child = transform.GetChild(i);
						if (child)
						{
							GClass84.smethod_890(child.gameObject, false);
						}
					}
				}
				Il2CppArrayBase<SkinnedMeshRenderer> components = gameObject_39.GetComponents<SkinnedMeshRenderer>();
				for (int j = components.Count - 1; j >= 0; j--)
				{
					GClass84.smethod_735(components[j]);
				}
				Il2CppArrayBase<MeshRenderer> components2 = gameObject_39.GetComponents<MeshRenderer>();
				for (int k = components2.Count - 1; k >= 0; k--)
				{
					GClass84.smethod_424(components2[k]);
				}
				Il2CppArrayBase<Renderer> components3 = gameObject_39.GetComponents<Renderer>();
				for (int l = components3.Count - 1; l >= 0; l--)
				{
					GClass84.smethod_6(components3[l]);
				}
				Il2CppArrayBase<MeshFilter> components4 = gameObject_39.GetComponents<MeshFilter>();
				for (int m = components4.Count - 1; m >= 0; m--)
				{
					GClass84.smethod_505(components4[m], bool_10);
				}
				Il2CppArrayBase<Animator> components5 = gameObject_39.GetComponents<Animator>();
				for (int n = components5.Count - 1; n >= 0; n--)
				{
					GClass84.smethod_1648(components5[n]);
				}
				Il2CppArrayBase<Collider> components6 = gameObject_39.GetComponents<Collider>();
				for (int num = components6.Count - 1; num >= 0; num--)
				{
					GClass84.smethod_59(components6[num]);
				}
				Il2CppArrayBase<Component> components7 = gameObject_39.GetComponents<Component>();
				for (int num2 = components7.Count - 1; num2 >= 0; num2--)
				{
					if (components7[num2] && !components7[num2].TryCast<Transform>())
					{
						GClass84.smethod_761(components7[num2]);
					}
				}
				Object.DestroyImmediate(gameObject_39, true);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		internal static void smethod_260(Collider collider_0)
		{
			GClass84.smethod_7(collider_0);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_261(Renderer renderer_0)
		{
			if (renderer_0)
			{
				Object.DestroyImmediate(renderer_0, true);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0005FABC File Offset: 0x0005DCBC
		internal static IEnumerator smethod_262()
		{
			return new GClass84.Class121(0);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005FAD0 File Offset: 0x0005DCD0
		internal static void smethod_263(SkinnedMeshRenderer skinnedMeshRenderer_0)
		{
			GClass84.smethod_1545(skinnedMeshRenderer_0);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
		internal static bool smethod_264(Type type_0, string string_4, Type[] type_1, Type[] type_2, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_1445("Abyss Client_1.0.0", type_0, string_4, type_1, type_2, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0005FB08 File Offset: 0x0005DD08
		internal static void smethod_265()
		{
			GClass84.list_45.Add(MelonCoroutines.Start(GClass84.smethod_1748()));
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0005FB2C File Offset: 0x0005DD2C
		internal static List<GameObject> smethod_266(Transform transform_0)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					list.Add(transform_0.GetChild(i).gameObject);
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0005FB7C File Offset: 0x0005DD7C
		internal static void smethod_267(GClass84.GEnum48 genum48_0, VRCPlayer vrcplayer_0, ref List<Transform> list_51, ref bool bool_10)
		{
			list_51.Clear();
			bool_10 = false;
			switch (genum48_0)
			{
			case GClass84.GEnum48.const_0:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					list_51.Add(vrcplayer_0.transform);
				}
				break;
			case GClass84.GEnum48.const_1:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					Transform transform = GClass84.smethod_89(vrcplayer_0.transform);
					if (transform)
					{
						list_51.Add(transform);
					}
				}
				break;
			case GClass84.GEnum48.const_2:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					list_51.Add(vrcplayer_0.transform);
					Transform transform2 = GClass84.smethod_89(vrcplayer_0.transform);
					if (transform2)
					{
						list_51.Add(transform2);
					}
				}
				break;
			case GClass84.GEnum48.const_3:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					list_51.Add(vrcplayer_0.transform);
				}
				break;
			case GClass84.GEnum48.const_4:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					Transform transform3 = GClass84.smethod_89(vrcplayer_0.transform);
					if (transform3)
					{
						list_51.Add(transform3);
					}
				}
				break;
			case GClass84.GEnum48.const_5:
				if (!vrcplayer_0 || !vrcplayer_0.transform)
				{
					bool_10 = true;
				}
				else
				{
					list_51.Add(vrcplayer_0.transform);
					Transform transform4 = GClass84.smethod_89(vrcplayer_0.transform);
					if (transform4)
					{
						list_51.Add(transform4);
					}
				}
				break;
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005FD54 File Offset: 0x0005DF54
		internal static Texture2D smethod_268(string string_4)
		{
			Texture2D result;
			try
			{
				Texture2D texture2D = GClass84.smethod_197(string_4);
				GClass84.smethod_48<Texture2D>(ref texture2D);
				result = texture2D;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0005FD8C File Offset: 0x0005DF8C
		internal static void smethod_269(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			GClass84.smethod_162(gclass156_1, int_1, int_2, int_3, int_4, int_5, int_6);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0005FDB0 File Offset: 0x0005DFB0
		internal static ConsoleColor smethod_270(string string_4)
		{
			uint num = Class217.smethod_0(string_4);
			if (num <= 2642369978U)
			{
				if (num <= 721696580U)
				{
					if (num <= 267312220U)
					{
						if (num != 246988314U)
						{
							if (num == 267312220U)
							{
								if (string_4 == "DarkRed")
								{
									return ConsoleColor.DarkRed;
								}
							}
						}
						else if (string_4 == "DarkGray")
						{
							return ConsoleColor.DarkGray;
						}
					}
					else if (num != 382078856U)
					{
						if (num == 721696580U)
						{
							if (string_4 == "Black")
							{
								return ConsoleColor.Black;
							}
						}
					}
					else if (string_4 == "Magenta")
					{
						return ConsoleColor.Magenta;
					}
				}
				else if (num <= 1827351814U)
				{
					if (num != 986120122U)
					{
						if (num == 1827351814U)
						{
							if (string_4 == "White")
							{
								return ConsoleColor.White;
							}
						}
					}
					else if (string_4 == "Gray")
					{
						return ConsoleColor.Gray;
					}
				}
				else if (num != 2030746984U)
				{
					if (num == 2642369978U)
					{
						if (string_4 == "DarkCyan")
						{
							return ConsoleColor.DarkCyan;
						}
					}
				}
				else if (string_4 == "DarkMagenta")
				{
					return ConsoleColor.DarkMagenta;
				}
			}
			else if (num <= 3608805453U)
			{
				if (num <= 2840840028U)
				{
					if (num != 2743015548U)
					{
						if (num == 2840840028U)
						{
							if (string_4 == "Green")
							{
								return ConsoleColor.Green;
							}
						}
					}
					else if (string_4 == "Red")
					{
						return ConsoleColor.Red;
					}
				}
				else if (num != 3381604954U)
				{
					if (num == 3608805453U)
					{
						if (string_4 == "DarkBlue")
						{
							return ConsoleColor.DarkBlue;
						}
					}
				}
				else if (string_4 == "Cyan")
				{
					return ConsoleColor.Cyan;
				}
			}
			else if (num <= 3923582957U)
			{
				if (num != 3654151273U)
				{
					if (num == 3923582957U)
					{
						if (string_4 == "Blue")
						{
							return ConsoleColor.Blue;
						}
					}
				}
				else if (string_4 == "Yellow")
				{
					return ConsoleColor.Yellow;
				}
			}
			else if (num != 3960648393U)
			{
				if (num == 3966268476U)
				{
					if (string_4 == "DarkGreen")
					{
						return ConsoleColor.DarkGreen;
					}
				}
			}
			else if (string_4 == "DarkYellow")
			{
				return ConsoleColor.DarkYellow;
			}
			return ConsoleColor.Black;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00060008 File Offset: 0x0005E208
		internal static string smethod_271(int int_1)
		{
			return GClass84.smethod_324(int_1);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0006001C File Offset: 0x0005E21C
		internal static Vector3 smethod_272(Transform transform_0, GClass84.GEnum47 genum47_0)
		{
			Vector3 result;
			if (!transform_0)
			{
				result = default(Vector3);
			}
			else
			{
				switch (genum47_0)
				{
				case GClass84.GEnum47.const_0:
					result = transform_0.position;
					break;
				case GClass84.GEnum47.const_1:
				{
					Transform transform = GClass84.smethod_89(transform_0);
					if (transform)
					{
						result = transform.position;
					}
					else
					{
						result = transform_0.position;
					}
					break;
				}
				case GClass84.GEnum47.const_2:
				{
					Transform transform2 = GClass84.smethod_89(transform_0);
					if (transform2)
					{
						result = (transform2.position + transform_0.position) / 2f;
					}
					else
					{
						result = transform_0.position;
					}
					break;
				}
				default:
					result = transform_0.position;
					break;
				}
			}
			return result;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000600CC File Offset: 0x0005E2CC
		internal static T smethod_273<T>(T gparam_0, Transform transform_0, bool bool_10) where T : Object
		{
			return gparam_0 ? Object.Instantiate<T>(gparam_0, transform_0, bool_10) : default(T);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000600FC File Offset: 0x0005E2FC
		internal static AvatarPerformanceStats smethod_274(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_966(GClass84.smethod_1416(vrcplayer_0));
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00060118 File Offset: 0x0005E318
		internal static IUser smethod_275(APIUser apiuser_0)
		{
			IUser result;
			if (apiuser_0 == null)
			{
				result = null;
			}
			else
			{
				if (GClass84.methodInfo_3 == null)
				{
					Type type = typeof(VRCPlayer).Assembly.GetTypes().First(new Func<Type, bool>(GClass84.Class101.class101_0.method_28));
					GClass84.methodInfo_3 = typeof(DataModelCache).GetMethod("Method_Public_TYPE_String_TYPE2_Boolean_0").MakeGenericMethod(new Type[]
					{
						type,
						typeof(APIUser)
					});
				}
				if (GClass84.methodInfo_3 == null)
				{
					result = null;
				}
				else
				{
					result = ((Object)GClass84.methodInfo_3.Invoke(DataModelManager.field_Private_Static_DataModelManager_0.field_Private_DataModelCache_0, new object[]
					{
						apiuser_0.id,
						apiuser_0,
						false
					})).Cast<IUser>();
				}
			}
			return result;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000601FC File Offset: 0x0005E3FC
		internal static Transform smethod_276(GameObject gameObject_39)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_836(transform, new List<string>
					{
						"_AvatarShadowClone"
					});
				}
			}
			return result;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0006025C File Offset: 0x0005E45C
		internal static string smethod_277()
		{
			return GClass84.smethod_1636();
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00060270 File Offset: 0x0005E470
		internal static void smethod_278(float float_3, float float_4)
		{
			GClass84.smethod_1348(float_3, float_4);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00060284 File Offset: 0x0005E484
		internal static GameObject smethod_279()
		{
			if (!GClass84.gameObject_34)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button/Icon", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_34 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_34;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000602E4 File Offset: 0x0005E4E4
		internal static AudioClip smethod_280(string string_4, AudioType audioType_0)
		{
			AudioClip result;
			if (GClass84.smethod_400(string_4) == 0)
			{
				result = null;
			}
			else
			{
				string_4 = GClass84.smethod_494(string_4, " ", "%20", false);
				if (GClass84.smethod_362(GClass84.smethod_1428(string_4, GClass84.smethod_593("http://"))) != "http://" && GClass84.smethod_362(GClass84.smethod_1428(string_4, GClass84.smethod_593("https://"))) != "https://")
				{
					string_4 = ("file" + "://" + string_4).Replace("\\", "/");
				}
				UnityWebRequest unityWebRequest = UnityWebRequest.Get(string_4);
				unityWebRequest.SendWebRequest();
				while (unityWebRequest.isDone)
				{
				}
				AudioClip audioClip = WebRequestWWW.InternalCreateAudioClipUsingDH(unityWebRequest.downloadHandler, unityWebRequest.url, false, false, audioType_0);
				while (!unityWebRequest.isDone || audioClip.loadState == 1)
				{
				}
				audioClip.hideFlags |= 32;
				result = audioClip;
			}
			return result;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000603D8 File Offset: 0x0005E5D8
		internal static void smethod_281(Object object_0)
		{
			GClass84.smethod_854(object_0);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000603EC File Offset: 0x0005E5EC
		internal static bool smethod_282(string string_4)
		{
			int num = GClass84.smethod_1611(string_4, ":");
			return num != -1 && GClass84.smethod_593(string_4) > num + 1 && GClass84.smethod_1369(GClass84.smethod_1428(string_4, num));
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0006042C File Offset: 0x0005E62C
		internal static IEnumerator smethod_283()
		{
			return new GClass84.Class113(0);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00060440 File Offset: 0x0005E640
		internal static void smethod_284(APIUser apiuser_0)
		{
			GClass84.smethod_767(apiuser_0);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00060454 File Offset: 0x0005E654
		internal static void smethod_285(List<Transform> list_51, Transform transform_0)
		{
			GClass84.smethod_1400(list_51, transform_0);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00060468 File Offset: 0x0005E668
		internal static Transform smethod_286(Player player_0)
		{
			Transform result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_855(player_0.transform);
			}
			return result;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00060494 File Offset: 0x0005E694
		internal static void smethod_287()
		{
			GClass84.smethod_297();
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000604A8 File Offset: 0x0005E6A8
		internal static Transform smethod_288()
		{
			Player player = GClass84.smethod_126();
			return (player != null) ? player.transform : null;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000604C8 File Offset: 0x0005E6C8
		internal static void smethod_289(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_107(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000604E4 File Offset: 0x0005E6E4
		internal static void smethod_290(Player player_0)
		{
			GClass84.smethod_971(player_0);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000604F8 File Offset: 0x0005E6F8
		internal static IEnumerator smethod_291(float float_3, Action action_0)
		{
			GClass84.Class106 @class = new GClass84.Class106(0);
			@class.float_0 = float_3;
			@class.action_0 = action_0;
			return @class;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0006051C File Offset: 0x0005E71C
		internal static Transform smethod_292()
		{
			GameObject gameObject = GClass84.smethod_57();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0006053C File Offset: 0x0005E73C
		internal static bool smethod_293(Transform transform_0, Vector3 vector3_0, bool bool_10 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (bool_10)
				{
					GClass84.smethod_636(transform_0.gameObject, true);
				}
				transform_0.position = vector3_0;
				result = true;
			}
			return result;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00060574 File Offset: 0x0005E774
		internal static IEnumerator smethod_294()
		{
			return new GClass84.Class115(0);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00060588 File Offset: 0x0005E788
		internal static void smethod_295(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_1209(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000605A4 File Offset: 0x0005E7A4
		internal static void smethod_296(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_205(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000605C0 File Offset: 0x0005E7C0
		internal static void smethod_297()
		{
			GClass84.smethod_81();
		}

		// Token: 0x060011FD RID: 4605
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool FreeLibrary(IntPtr intptr_1);

		// Token: 0x060011FE RID: 4606 RVA: 0x000605D4 File Offset: 0x0005E7D4
		internal static bool smethod_298(List<Transform> list_51, Transform transform_0, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null || !transform_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1226(list_51[i], transform_0, genum47_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00060628 File Offset: 0x0005E828
		internal static void smethod_299()
		{
			GClass84.smethod_1206(GClass84.float_0);
			try
			{
				if (Input.GetKey(306) && Input.GetKey(304))
				{
					if (Input.GetKeyDown(114))
					{
						GClass84.smethod_251();
					}
					else if (Input.GetKeyDown(118))
					{
						GClass84.smethod_1050(Clipboard.GetText(), true);
					}
				}
				GClass84.Class99 @class;
				if (GClass84.concurrentQueue_0.TryDequeue(out @class) && !@class.bool_0)
				{
					@class.action_0();
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000606C4 File Offset: 0x0005E8C4
		internal static void smethod_300(PortalInternal portalInternal_0)
		{
			GClass84.smethod_563(portalInternal_0, 1000000f);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000606DC File Offset: 0x0005E8DC
		internal static int smethod_301(Player player_0)
		{
			int result;
			if (player_0 == null)
			{
				result = -1;
			}
			else
			{
				result = player_0.Method_Public_get_Int32_0();
			}
			return result;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000606FC File Offset: 0x0005E8FC
		internal static void smethod_302()
		{
			GClass84.smethod_265();
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00060710 File Offset: 0x0005E910
		internal static string smethod_303(string string_4, string string_5, string string_6)
		{
			int num = string_4.LastIndexOf(string_5);
			string result;
			if (num == -1)
			{
				result = string_4;
			}
			else
			{
				string text = string_4.Remove(num, string_5.Length).Insert(num, string_6);
				result = text;
			}
			return result;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00060748 File Offset: 0x0005E948
		internal static void smethod_304(Notification notification_0)
		{
			GClass84.smethod_332(notification_0);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0006075C File Offset: 0x0005E95C
		internal static void smethod_305(ApiAvatar apiAvatar_0, APIUser apiuser_0, string string_4, string string_5, string string_6)
		{
			GClass84.smethod_373(apiAvatar_0, apiuser_0, string_4, string_5, string_6);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00060778 File Offset: 0x0005E978
		internal static T smethod_306<T>(byte[] byte_0)
		{
			T result;
			if (byte_0 == null)
			{
				result = default(T);
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				using (MemoryStream memoryStream = new MemoryStream(byte_0))
				{
					object obj = binaryFormatter.Deserialize(memoryStream);
					result = (T)((object)obj);
				}
			}
			return result;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000607D8 File Offset: 0x0005E9D8
		internal static bool smethod_307(APIUser apiuser_0)
		{
			return apiuser_0 != null && apiuser_0.IsOnMobile;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000607F8 File Offset: 0x0005E9F8
		internal static T smethod_308<T>(Object object_0)
		{
			return GClass84.smethod_306<T>(GClass84.smethod_1067(object_0));
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00060814 File Offset: 0x0005EA14
		internal static void smethod_309()
		{
			GClass84.smethod_1093();
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00060828 File Offset: 0x0005EA28
		internal static bool smethod_310(VRCPlayerApi vrcplayerApi_0)
		{
			return vrcplayerApi_0 != null && GClass84.smethod_1045(GClass84.smethod_831(vrcplayerApi_0));
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0006084C File Offset: 0x0005EA4C
		internal static List<Scene> smethod_311(bool bool_10 = false)
		{
			List<Scene> result;
			if (bool_10)
			{
				GameObject gameObject = new GameObject();
				Object.DontDestroyOnLoad(gameObject);
				Scene scene = gameObject.scene;
				Object.DestroyImmediate(gameObject);
				List<Scene> list = SceneManager.GetAllScenes().ToList<Scene>();
				list.Add(scene);
				result = list;
			}
			else
			{
				result = SceneManager.GetAllScenes().ToList<Scene>();
			}
			return result;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000608A0 File Offset: 0x0005EAA0
		internal static void smethod_312(float float_3)
		{
			GClass84.smethod_442(float_3);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000608B4 File Offset: 0x0005EAB4
		internal static List<string> smethod_313(List<VRC_Trigger> list_51, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < list_51.Count; i++)
			{
				if (list_51[i])
				{
					for (int j = 0; j < list_51[i].Triggers.Count; j++)
					{
						if (list_51[i].Triggers[j].TriggerType == 0)
						{
							list.Add(list_51[i].Triggers[j].Name);
						}
						else
						{
							list.Add(list_51[i].Triggers[j].TriggerType.ToString());
						}
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_661<string>(ref list);
			}
			return list;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00060988 File Offset: 0x0005EB88
		internal static List<GameObject> smethod_314()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<ParticleSystem>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000609E4 File Offset: 0x0005EBE4
		internal static string smethod_315(ConsoleColor consoleColor_0)
		{
			return GClass84.smethod_1450(consoleColor_0);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000609F8 File Offset: 0x0005EBF8
		internal static GClass84.GStruct169 smethod_316(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct169 gstruct = GClass84.smethod_124(int_1, int_2, int_3, int_4);
			GClass84.GStruct163 gstruct2 = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			GClass84.GStruct169 result;
			if (gstruct2.int_0 == int_1 && gstruct2.int_1 == int_2 - int_3)
			{
				result = gstruct;
			}
			else
			{
				GClass84.GStruct169 gstruct3 = GClass84.smethod_1429(int_1, int_2, int_1, int_2 - int_3);
				for (int i = 0; i < gstruct3.list_0.Count; i++)
				{
					gstruct.list_0.Add(gstruct3.list_0[i]);
					gstruct.list_1.Add(gstruct3.list_1[i]);
				}
				gstruct3 = GClass84.smethod_1429(int_1, int_2, gstruct2.int_0, gstruct2.int_1);
				for (int j = 0; j < gstruct3.list_0.Count; j++)
				{
					gstruct.list_0.Add(gstruct3.list_0[j]);
					gstruct.list_1.Add(gstruct3.list_1[j]);
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		internal static Transform smethod_317()
		{
			GameObject gameObject = GClass84.smethod_525();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00060B18 File Offset: 0x0005ED18
		internal static string smethod_318(byte[] byte_0, bool bool_10)
		{
			SHA256Managed sha256Managed = new SHA256Managed();
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = sha256Managed.ComputeHash(byte_0);
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			string result;
			if (bool_10)
			{
				result = stringBuilder.ToString().ToUpper();
			}
			else
			{
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00060B84 File Offset: 0x0005ED84
		internal static string smethod_319(int int_1)
		{
			return GClass84.smethod_399(int_1);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00060B98 File Offset: 0x0005ED98
		internal static Transform smethod_320()
		{
			GameObject gameObject = GClass84.smethod_325();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00060BB8 File Offset: 0x0005EDB8
		internal static void smethod_321(Mesh mesh_0, int int_1)
		{
			GClass84.smethod_388(mesh_0, int_1);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00060BCC File Offset: 0x0005EDCC
		internal static bool smethod_322(string string_4)
		{
			return !string.IsNullOrEmpty(string_4) && GClass84.smethod_593(string_4) == GClass84.smethod_593("avtr_********-****-****-****-************") && GClass84.smethod_1428(string_4, GClass84.smethod_593("avtr_")) == "avtr_";
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00060C14 File Offset: 0x0005EE14
		internal static Vector3 smethod_323(List<Vector3> list_51)
		{
			Vector3 result;
			if (list_51.Count == 0)
			{
				result = default(Vector3);
			}
			else
			{
				Vector3 vector = default(Vector3);
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					vector += list_51[i];
				}
				result = vector / (float)list_51.Count;
			}
			return result;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00060C7C File Offset: 0x0005EE7C
		internal static string smethod_324(int int_1)
		{
			return GClass84.smethod_1167(int_1);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00060C90 File Offset: 0x0005EE90
		internal static GameObject smethod_325()
		{
			if (!GClass84.gameObject_30)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_30 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_30;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00060CF0 File Offset: 0x0005EEF0
		internal static ApiWorldInstance smethod_326()
		{
			return GClass84.smethod_454(GClass84.smethod_1467());
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00060D0C File Offset: 0x0005EF0C
		internal static void smethod_327(APIUser apiuser_0)
		{
			GClass84.smethod_697(apiuser_0);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00060D20 File Offset: 0x0005EF20
		internal static void smethod_328()
		{
			Player[] array = GClass84.smethod_870();
			List<GameObject> list = GClass84.smethod_67();
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					GClass84.smethod_1060(list[j].name, array[i].transform.position);
				}
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00060D7C File Offset: 0x0005EF7C
		internal static bool smethod_329(PlayerNet playerNet_0)
		{
			return playerNet_0 && GClass84.smethod_1511(GClass84.smethod_782(playerNet_0));
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		internal static void smethod_330()
		{
			GClass84.smethod_158();
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00060DBC File Offset: 0x0005EFBC
		internal static Vector2 smethod_331(float float_3)
		{
			return GClass84.smethod_1182(GClass84.smethod_1480(float_3));
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00060DD8 File Offset: 0x0005EFD8
		internal static void smethod_332(Notification notification_0)
		{
			if (notification_0 == null)
			{
				GClass70.smethod_38("Could not accept notif bc notif is null", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38("AcceptNotification for notification", GClass70.Enum1.const_0);
				if (notification_0.details == null && notification_0.notificationType != "friendRequest")
				{
					GClass70.smethod_38("Could not accept notif bc notif details is null", GClass70.Enum1.const_0);
				}
				else
				{
					string a = notification_0.notificationType.ToLower();
					if (a == "invite")
					{
						if (notification_0.details.ContainsKey("worldId"))
						{
							string string_ = notification_0.details["worldId"].ToString();
							GClass84.smethod_704(string_);
						}
					}
					else if (a == "friendRequest")
					{
						FriendRequest.Create(notification_0.senderUserId);
					}
					else if (a == "requestInvite")
					{
						if (notification_0.details != null)
						{
							string senderUserId = notification_0.senderUserId;
							NotificationDetails notificationDetails = new NotificationDetails();
							notificationDetails["worldId"] = GClass84.smethod_1424().id + ":" + GClass84.smethod_813().instanceId;
							notificationDetails["worldName"] = GClass84.smethod_1424().name;
							GClass84.smethod_972(senderUserId, "invite", string.Empty, notificationDetails);
						}
					}
					else
					{
						Button component = GameObject.Find("UserInterface/QuickMenu/NotificationInteractMenu/AcceptButton").GetComponent<Button>();
						component.Press();
						GClass70.smethod_38("AcceptNotification/for/unknown/notification", GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00060F50 File Offset: 0x0005F150
		internal static void smethod_333(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_109(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00060F6C File Offset: 0x0005F16C
		internal static bool smethod_334(string string_4)
		{
			return string.IsNullOrEmpty(string_4) || (GClass84.smethod_593(string_4) != GClass84.smethod_593("**********") && (GClass84.smethod_593(string_4) != GClass84.smethod_593("usr_********-****-****-****-************") || GClass84.smethod_1428(string_4, GClass84.smethod_593("usr_")) != "usr_"));
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00060FC8 File Offset: 0x0005F1C8
		internal static GClass84.GStruct169 smethod_335(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct169 gstruct = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			bool flag = false;
			if (int_1 > int_3)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num2;
			int num5 = int_2;
			int num6 = int_4 - int_2;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_1; i <= int_3; i++)
			{
				if (!flag)
				{
					gstruct.method_0(new GClass84.GStruct163(i, num5), new GClass84.GStruct163(1, 1));
				}
				else
				{
					GClass84.GStruct163 value = gstruct.list_1[gstruct.list_1.Count - 1];
					value.int_0++;
					gstruct.list_1[gstruct.list_1.Count - 1] = value;
				}
				flag = true;
				num3 += num4;
				if (2 * num3 >= num)
				{
					num5 += num6;
					num3 -= num;
					flag = false;
				}
			}
			return gstruct;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000610D8 File Offset: 0x0005F2D8
		internal static void smethod_336(Mesh mesh_0)
		{
			if (mesh_0)
			{
				mesh_0.RecalculateBounds();
				mesh_0.RecalculateTangents();
				mesh_0.RecalculateNormals();
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00061104 File Offset: 0x0005F304
		internal static void smethod_337(Notification notification_0)
		{
			GClass84.smethod_304(notification_0);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00061118 File Offset: 0x0005F318
		internal static void smethod_338(bool bool_10)
		{
			GClass84.smethod_387(bool_10);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0006112C File Offset: 0x0005F32C
		internal static string smethod_339(Player player_0)
		{
			return GClass84.smethod_838(player_0);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00061140 File Offset: 0x0005F340
		internal static string smethod_340(string string_4, int int_1)
		{
			string empty;
			if (string.IsNullOrEmpty(string_4))
			{
				empty = string.Empty;
			}
			else
			{
				int num = GClass84.smethod_593(string_4);
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				while (int_1 < num)
				{
					if (string_4[int_1] == '{')
					{
						if (num2 == 0)
						{
							num4 = int_1;
						}
						num2++;
					}
					else if (string_4[int_1] == '}')
					{
						num3++;
					}
					if (num3 > num2)
					{
						if (num2 != 0)
						{
							return string.Empty;
						}
						num3 = 0;
					}
					else
					{
						if (num2 > 0 && num3 == num2)
						{
							return GClass84.smethod_1204(string_4, num4, int_1 - num4 + 1);
						}
						int_1++;
					}
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000611E8 File Offset: 0x0005F3E8
		internal static List<GClass84.GStruct135> smethod_341(Transform transform_0)
		{
			List<GClass84.GStruct135> result;
			if (!transform_0)
			{
				result = new List<GClass84.GStruct135>();
			}
			else
			{
				SkinnedMeshRenderer component = transform_0.GetComponent<SkinnedMeshRenderer>();
				if (component)
				{
					result = GClass84.smethod_347(component);
				}
				else
				{
					result = new List<GClass84.GStruct135>();
				}
			}
			return result;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00061228 File Offset: 0x0005F428
		internal static Transform smethod_342(GameObject gameObject_39, List<string> list_51)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_836(gameObject_39.transform, list_51);
			}
			return result;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00061254 File Offset: 0x0005F454
		internal static string smethod_343(string string_4, int int_1)
		{
			return GClass84.smethod_635(string_4, int_1);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00061268 File Offset: 0x0005F468
		internal static void smethod_344(string string_4, int int_1)
		{
			GClass84.smethod_209(string_4, int_1);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0006127C File Offset: 0x0005F47C
		internal static void smethod_345()
		{
			List<GameObject> list = GClass84.smethod_589();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i])
				{
					list[i].SetActive(true);
				}
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000612C4 File Offset: 0x0005F4C4
		internal static void smethod_346(List<Transform> list_51, GameObject gameObject_39)
		{
			GClass84.smethod_285(list_51, gameObject_39.transform);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000612E0 File Offset: 0x0005F4E0
		internal static List<GClass84.GStruct135> smethod_347(SkinnedMeshRenderer skinnedMeshRenderer_0)
		{
			List<GClass84.GStruct135> result;
			if (!skinnedMeshRenderer_0)
			{
				result = new List<GClass84.GStruct135>();
			}
			else
			{
				Mesh sharedMesh = skinnedMeshRenderer_0.sharedMesh;
				if (!sharedMesh)
				{
					result = new List<GClass84.GStruct135>();
				}
				else
				{
					List<GClass84.GStruct135> list = new List<GClass84.GStruct135>();
					for (int i = 0; i < sharedMesh.blendShapeCount; i++)
					{
						list.Add(new GClass84.GStruct135(sharedMesh.GetBlendShapeName(i), skinnedMeshRenderer_0.GetBlendShapeWeight(i)));
					}
					result = list;
				}
			}
			return result;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00061358 File Offset: 0x0005F558
		internal static string smethod_348(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_766(vrcplayer_0);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0006136C File Offset: 0x0005F56C
		internal static string smethod_349()
		{
			return GClass84.smethod_1156();
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00061380 File Offset: 0x0005F580
		internal static IEnumerator smethod_350()
		{
			return new GClass84.Class123(0);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00061394 File Offset: 0x0005F594
		internal static GameObject smethod_351(Transform transform_0, string string_4)
		{
			Transform transform = GClass84.smethod_693(transform_0, string_4);
			return (transform != null) ? transform.gameObject : null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000613B8 File Offset: 0x0005F5B8
		internal static void smethod_352()
		{
			GClass84.smethod_394();
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000613CC File Offset: 0x0005F5CC
		internal static bool smethod_353(Transform transform_0, GameObject gameObject_39, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			return transform_0 && gameObject_39 && GClass84.smethod_293(transform_0, GClass84.smethod_1607(gameObject_39, genum47_0), bool_10);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00061404 File Offset: 0x0005F604
		internal static float smethod_354()
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			float result;
			if (!locomotionInputController)
			{
				result = 0f;
			}
			else
			{
				result = locomotionInputController.field_Public_Single_0;
			}
			return result;
		}

		// Token: 0x06001237 RID: 4663
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool SetForegroundWindow(IntPtr intptr_1);

		// Token: 0x06001238 RID: 4664 RVA: 0x00061434 File Offset: 0x0005F634
		internal static void smethod_355(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_1310(apiAvatar_0);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00061448 File Offset: 0x0005F648
		internal static GClass84.GStruct169 smethod_356(int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.GStruct169 gstruct = GClass84.smethod_744(int_1, int_2, int_3, int_4, int_5);
			GClass84.GStruct163 gstruct2 = GClass84.smethod_50(int_1, int_2, int_3, int_5);
			GClass84.GStruct163 gstruct3 = GClass84.smethod_50(int_1, int_2, int_3, (int_5 + int_4) % 360);
			GClass84.GStruct169 result;
			if (GClass84.GStruct163.smethod_0(gstruct2, gstruct3))
			{
				result = gstruct;
			}
			else
			{
				GClass84.GStruct169 gstruct4 = GClass84.smethod_1429(int_1, int_2, gstruct2.int_0, gstruct2.int_1);
				for (int i = 0; i < gstruct4.list_0.Count; i++)
				{
					gstruct.list_0.Add(gstruct4.list_0[i]);
					gstruct.list_1.Add(gstruct4.list_1[i]);
				}
				gstruct4 = GClass84.smethod_1429(int_1, int_2, gstruct3.int_0, gstruct3.int_1);
				for (int j = 0; j < gstruct4.list_0.Count; j++)
				{
					gstruct.list_0.Add(gstruct4.list_0[j]);
					gstruct.list_1.Add(gstruct4.list_1[j]);
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00061558 File Offset: 0x0005F758
		internal static void smethod_357()
		{
			GClass84.smethod_881();
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0006156C File Offset: 0x0005F76C
		internal static string smethod_358(string string_4)
		{
			return GClass84.smethod_577(string_4);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00061580 File Offset: 0x0005F780
		internal static float smethod_359(float float_3, float float_4)
		{
			float result;
			if (float_3 > float_4)
			{
				result = float_3;
			}
			else
			{
				result = float_4;
			}
			return result;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0006159C File Offset: 0x0005F79C
		internal static string smethod_360(string string_4, int int_1)
		{
			return GClass84.smethod_1643(string_4, int_1);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000615B0 File Offset: 0x0005F7B0
		internal static Player smethod_361()
		{
			Player[] array = GClass84.smethod_870();
			Player result;
			if (array.Length == 0)
			{
				result = null;
			}
			else
			{
				result = array[GClass84.smethod_1673(array.Length)];
			}
			return result;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000615DC File Offset: 0x0005F7DC
		internal static string smethod_362(string string_4)
		{
			return GClass84.smethod_503(string_4);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000615F0 File Offset: 0x0005F7F0
		internal static List<string> smethod_363(VRC_Trigger vrc_Trigger_0, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType == 0)
					{
						list.Add(vrc_Trigger_0.Triggers[i].Name);
					}
					else
					{
						list.Add(vrc_Trigger_0.Triggers[i].TriggerType.ToString());
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_661<string>(ref list);
			}
			return list;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00061688 File Offset: 0x0005F888
		internal static GClass84.Delegate32 Delegate32_0
		{
			get
			{
				GClass84.Delegate32 result;
				if (GClass84.delegate32_0 != null)
				{
					result = GClass84.delegate32_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).Single(new Func<MethodInfo, bool>(GClass84.Class101.class101_0.method_3));
					GClass84.delegate32_0 = (GClass84.Delegate32)Delegate.CreateDelegate(typeof(GClass84.Delegate32), GClass84.smethod_102(), method);
					result = GClass84.delegate32_0;
				}
				return result;
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00061704 File Offset: 0x0005F904
		internal static string smethod_364(string string_4, int int_1)
		{
			return GClass84.smethod_343(string_4, int_1);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00061718 File Offset: 0x0005F918
		internal static void smethod_365(ApiWorld apiWorld_0, PageWorldInfo pageWorldInfo_0)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_ApiWorld_PageWorldInfo_0(apiWorld_0, pageWorldInfo_0);
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00061738 File Offset: 0x0005F938
		internal static void smethod_366(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_1413(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00061758 File Offset: 0x0005F958
		internal static VRCPlayer smethod_367(Player player_0)
		{
			return (player_0 != null) ? player_0._vrcplayer : null;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00061774 File Offset: 0x0005F974
		internal static string smethod_368(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_1055(vrcplayer_0);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00061788 File Offset: 0x0005F988
		internal static Transform smethod_369()
		{
			GameObject gameObject = GClass84.smethod_1225();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000617A8 File Offset: 0x0005F9A8
		internal static void smethod_370(string string_4)
		{
			GClass84.smethod_1031(string_4);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000617BC File Offset: 0x0005F9BC
		internal static void smethod_371(bool bool_10)
		{
			GClass84.smethod_218(bool_10);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000617D0 File Offset: 0x0005F9D0
		internal static string smethod_372(APIUser apiuser_0, string string_4)
		{
			return GClass84.smethod_1332(apiuser_0, string_4);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x000617E4 File Offset: 0x0005F9E4
		internal static void smethod_373(ApiAvatar apiAvatar_0, APIUser apiuser_0, string string_4, string string_5, string string_6)
		{
			ApiAvatar apiAvatar = new ApiAvatar();
			apiAvatar.smethod_938(apiAvatar_0.id, apiuser_0, string_4, string_6, apiAvatar_0.assetUrl, string_5, apiAvatar_0.releaseStatus, apiAvatar_0.tags, apiAvatar_0.unityPackageUrl);
			apiAvatar.Save(new Action<ApiContainer>(GClass84.Class101.class101_0.method_23), new Action<ApiContainer>(GClass84.Class101.class101_0.method_21));
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00061870 File Offset: 0x0005FA70
		internal static int smethod_374(int int_1, int int_2)
		{
			return Random.Range(int_1, int_2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00061888 File Offset: 0x0005FA88
		internal static void smethod_375(Text text_1)
		{
			if (text_1)
			{
				RectTransform component = text_1.GetComponent<RectTransform>();
				if (component)
				{
					Vector2 vector = component.anchorMin;
					vector.x = 0f;
					vector.y = 0f;
					component.anchorMin = vector;
					vector = component.anchorMax;
					vector.x = 1f;
					vector.y = 1f;
					component.anchorMax = vector;
					vector = component.offsetMin;
					vector.x = 0f;
					vector.y = -26.9f;
					component.offsetMin = vector;
					vector = component.offsetMax;
					vector.x = 0f;
					vector.y = 26.9f;
					component.offsetMax = vector;
					Vector3 anchoredPosition3D = component.anchoredPosition3D;
					anchoredPosition3D.x = 0f;
					anchoredPosition3D.y = 0f;
					component.anchoredPosition3D = anchoredPosition3D;
				}
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00061978 File Offset: 0x0005FB78
		internal static string smethod_376(int int_1)
		{
			return GClass84.smethod_22(int_1);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0006198C File Offset: 0x0005FB8C
		internal static GClass84.GStruct169 smethod_377(int int_1, int int_2, int int_3)
		{
			int num = 0;
			GClass84.GStruct169 gstruct = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int i = int_3;
			int num2 = 1 - 2 * int_3;
			float num3 = (float)(int_3 / 2);
			while (i >= 0)
			{
				if (!flag)
				{
					gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
					gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
					gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
					gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
				}
				else if (flag2)
				{
					GClass84.GStruct163 value = gstruct.list_0[gstruct.list_0.Count - 1];
					value.int_0--;
					gstruct.list_0[gstruct.list_0.Count - 1] = value;
					value = gstruct.list_0[gstruct.list_0.Count - 2];
					value.int_0--;
					gstruct.list_0[gstruct.list_0.Count - 2] = value;
					value = gstruct.list_1[gstruct.list_1.Count - 1];
					value.int_0++;
					gstruct.list_1[gstruct.list_1.Count - 1] = value;
					value = gstruct.list_1[gstruct.list_1.Count - 2];
					value.int_0++;
					gstruct.list_1[gstruct.list_1.Count - 2] = value;
					value = gstruct.list_1[gstruct.list_1.Count - 3];
					value.int_0++;
					gstruct.list_1[gstruct.list_1.Count - 3] = value;
					value = gstruct.list_1[gstruct.list_1.Count - 4];
					value.int_0++;
					gstruct.list_1[gstruct.list_1.Count - 4] = value;
				}
				else if (flag3)
				{
					GClass84.GStruct163 value2 = gstruct.list_0[gstruct.list_0.Count - 2];
					value2.int_1--;
					gstruct.list_0[gstruct.list_0.Count - 2] = value2;
					value2 = gstruct.list_0[gstruct.list_0.Count - 4];
					value2.int_1--;
					gstruct.list_0[gstruct.list_0.Count - 4] = value2;
					value2 = gstruct.list_1[gstruct.list_1.Count - 1];
					value2.int_1++;
					gstruct.list_1[gstruct.list_1.Count - 1] = value2;
					value2 = gstruct.list_1[gstruct.list_1.Count - 2];
					value2.int_1++;
					gstruct.list_1[gstruct.list_1.Count - 2] = value2;
					value2 = gstruct.list_1[gstruct.list_1.Count - 3];
					value2.int_1++;
					gstruct.list_1[gstruct.list_1.Count - 3] = value2;
					value2 = gstruct.list_1[gstruct.list_1.Count - 4];
					value2.int_1++;
					gstruct.list_1[gstruct.list_1.Count - 4] = value2;
				}
				int num4 = 2 * (num2 + i) - 1;
				flag = false;
				if (num2 < 0 && num4 <= 0)
				{
					num2 += 2 * ++num + 1;
					if (flag2 || (float)num <= num3)
					{
						flag = true;
						flag2 = true;
					}
				}
				else
				{
					if (flag2)
					{
						flag2 = false;
					}
					if (num2 > 0 && num4 > 0)
					{
						num2 -= 2 * --i + 1;
						if (flag3 || (float)num >= num3)
						{
							flag = true;
							flag3 = true;
						}
					}
					else
					{
						if (flag3)
						{
							flag3 = false;
						}
						num2 += 2 * (++num - i--);
					}
				}
			}
			return gstruct;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00061DFC File Offset: 0x0005FFFC
		internal static string smethod_378(ApiAvatar apiAvatar_0)
		{
			return GClass84.smethod_1290(apiAvatar_0);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00061E10 File Offset: 0x00060010
		internal static void smethod_379(ref string string_4, string string_5, string string_6)
		{
			GClass84.smethod_173(ref string_4, string_5, string_6);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		internal static Transform smethod_380(PlayerNet playerNet_0)
		{
			Transform result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1280(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00061E28 File Offset: 0x00060028
		internal static int smethod_381(int int_1)
		{
			int result;
			if (int_1 <= 1)
			{
				result = 0;
			}
			else
			{
				result = Random.Range(0, int_1);
			}
			return result;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00061E4C File Offset: 0x0006004C
		internal static bool smethod_382(string string_4)
		{
			Dictionary<string, List<ApiPlayerModeration>> field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_ = ModerationManager.Method_Public_Static_get_ModerationManager_PDM_0().field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_0;
			bool result;
			if (!field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_.ContainsKey(string_4))
			{
				result = false;
			}
			else
			{
				foreach (ApiPlayerModeration apiPlayerModeration in field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_[string_4])
				{
					if (apiPlayerModeration.moderationType == 5)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00061EA8 File Offset: 0x000600A8
		internal static void smethod_383(APIUser apiuser_0)
		{
			GClass84.smethod_55(apiuser_0);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00061EBC File Offset: 0x000600BC
		internal static Player smethod_384(VRCPlayer vrcplayer_0)
		{
			return (vrcplayer_0 != null) ? vrcplayer_0._player : null;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00061ED8 File Offset: 0x000600D8
		internal static string smethod_385(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_368(vrcplayer_0);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00061EEC File Offset: 0x000600EC
		internal static List<FABRIK> smethod_386(Transform transform_0)
		{
			List<FABRIK> result;
			if (!transform_0)
			{
				result = new List<FABRIK>();
			}
			else
			{
				List<FABRIK> list = transform_0.GetComponents<FABRIK>().ToList<FABRIK>();
				list.AddRange(transform_0.GetComponentsInChildren<FABRIK>(true));
				result = list.Distinct<FABRIK>().ToList<FABRIK>();
			}
			return result;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00061F34 File Offset: 0x00060134
		internal static void smethod_387(bool bool_10)
		{
			if (GClass84.methodInfo_0 == null)
			{
				GClass84.methodInfo_0 = typeof(VRCPlayer).GetMethods().First(new Func<MethodInfo, bool>(GClass84.Class101.class101_0.method_17));
			}
			if (GClass84.methodInfo_0 == null)
			{
				GClass70.smethod_36("Can't find reload all avatars method!", GClass70.Enum1.const_0);
			}
			else
			{
				VRCPlayer vrcplayer = GClass84.smethod_460();
				if (!vrcplayer)
				{
					GClass70.smethod_36("!VRCP", GClass70.Enum1.const_0);
				}
				else
				{
					GClass84.methodInfo_0.Invoke(vrcplayer, new object[]
					{
						false
					});
				}
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00061FDC File Offset: 0x000601DC
		internal static void smethod_388(Mesh mesh_0, int int_1)
		{
			GClass84.smethod_707(mesh_0, int_1);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00061FF0 File Offset: 0x000601F0
		internal static void smethod_389(AvatarPerformanceStats avatarPerformanceStats_0, AvatarPerformanceStats avatarPerformanceStats_1, bool bool_10)
		{
			GClass84.smethod_439(avatarPerformanceStats_0, avatarPerformanceStats_1, bool_10);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00062008 File Offset: 0x00060208
		internal static bool smethod_390(string string_4, Type type_0, string string_5, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			bool result;
			if (GClass84.smethod_1123(string_4, AccessTools.Property(type_0, string_5).GetMethod, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
			{
				result = true;
			}
			else
			{
				string text = "Null";
				string text2 = "Null";
				string text3 = "Null";
				string text4 = "Null";
				if (type_0 != null)
				{
					text = type_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text2 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text3 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text4 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Property",
					" (",
					string_4,
					", ",
					text,
					", ",
					string_5,
					", ",
					text2,
					", ",
					text3,
					", ",
					text4,
					")"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00062140 File Offset: 0x00060340
		internal static bool smethod_391(GameObject gameObject_39)
		{
			bool result;
			if (!gameObject_39)
			{
				result = false;
			}
			else
			{
				Camera main = Camera.main;
				result = (main && GClass84.smethod_497(main.transform, gameObject_39.transform));
			}
			return result;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00062184 File Offset: 0x00060384
		internal static Sprite smethod_392(string string_4)
		{
			Sprite result;
			if (string.IsNullOrEmpty(string_4))
			{
				result = null;
			}
			else
			{
				byte[] array = File.ReadAllBytes(string_4);
				if (array == null || array.Length == 0)
				{
					result = null;
				}
				else
				{
					Texture2D texture2D = new Texture2D(512, 512);
					if (!Il2CppImageConversionManager.LoadImage(texture2D, array))
					{
						result = null;
					}
					else
					{
						Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, 0, default(Vector4), false);
						sprite.hideFlags |= 32;
						result = sprite;
					}
				}
			}
			return result;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0006223C File Offset: 0x0006043C
		internal static Texture2D smethod_393(Texture2D texture2D_0)
		{
			Color32[] array = texture2D_0.GetPixels32();
			Color32[] array2 = new Color32[array.Length];
			int width = texture2D_0.width;
			int height = texture2D_0.height;
			for (int i = 0; i < height; i++)
			{
				int num = height - i - 1;
				for (int j = 0; j < width; j++)
				{
					array2[i * width + j] = array[num * width + j];
				}
			}
			texture2D_0.SetPixels32(array2);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000622CC File Offset: 0x000604CC
		internal static void smethod_394()
		{
			GClass84.smethod_1321();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000622E0 File Offset: 0x000604E0
		internal static List<Transform> smethod_395(GameObject gameObject_39)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_1495(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00062310 File Offset: 0x00060510
		internal static void smethod_396()
		{
			GClass84.smethod_754();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00062324 File Offset: 0x00060524
		internal static void smethod_397(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_829(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00062344 File Offset: 0x00060544
		internal static void smethod_398(bool bool_10)
		{
			VRCUiManager vrcuiManager = GClass84.smethod_102();
			if (!vrcuiManager)
			{
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00062360 File Offset: 0x00060560
		internal static string smethod_399(int int_1)
		{
			return GClass84.smethod_239(int_1);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00062374 File Offset: 0x00060574
		internal static AudioType smethod_400(string string_4)
		{
			string_4 = GClass84.smethod_362(string_4);
			AudioType result;
			if (GClass84.smethod_360(string_4, GClass84.smethod_593(".mp2")) == ".mp2" || GClass84.smethod_360(string_4, GClass84.smethod_593(".mp3")) == ".mp3")
			{
				result = 13;
			}
			else if (GClass84.smethod_360(string_4, GClass84.smethod_593(".ogg")) == ".ogg")
			{
				result = 14;
			}
			else if (GClass84.smethod_360(string_4, GClass84.smethod_593(".wav")) == ".wav")
			{
				result = 20;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00062410 File Offset: 0x00060610
		internal static void smethod_401(Player player_0)
		{
			player_0.smethod_1632(0f);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00062428 File Offset: 0x00060628
		internal static void smethod_402(string string_4, Color color_0)
		{
			GClass84.smethod_1570(string_4, color_0);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0006243C File Offset: 0x0006063C
		internal static List<Transform> smethod_403(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					list.Add(transform_0.GetChild(i));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00062488 File Offset: 0x00060688
		internal static void smethod_404(string string_4, Action action_0, Action action_1, Action action_2)
		{
			GClass84.smethod_1046(string_4, action_0, action_1, action_2);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000624A0 File Offset: 0x000606A0
		internal static bool smethod_405(Type type_0, string string_4, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_390("Abyss Client_1.0.0", type_0, string_4, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000624C0 File Offset: 0x000606C0
		internal static string smethod_406(ConsoleColor consoleColor_0)
		{
			return GClass84.smethod_52(consoleColor_0);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000624D4 File Offset: 0x000606D4
		internal static bool smethod_407(Player player_0, bool bool_10 = false)
		{
			return GClass84.smethod_1605(GClass84.smethod_367(player_0), bool_10);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000624F0 File Offset: 0x000606F0
		internal static void smethod_408()
		{
			GClass84.smethod_1530();
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00062504 File Offset: 0x00060704
		internal static void smethod_409(UiVRCList uiVRCList_0)
		{
			GClass84.smethod_1612(uiVRCList_0, new List<ApiAvatar>());
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0006251C File Offset: 0x0006071C
		internal static Transform smethod_410(PlayerNet playerNet_0)
		{
			Transform result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1427(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00062548 File Offset: 0x00060748
		internal static bool smethod_411(GameObject gameObject_39, GameObject gameObject_40, bool bool_10 = false, bool bool_11 = false)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_466(gameObject_39.transform, gameObject_40.transform, bool_10, bool_11);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00062584 File Offset: 0x00060784
		internal static T[] smethod_412<T>(List<T> list_51)
		{
			T[] result;
			if (list_51 == null || list_51.Count == 0)
			{
				result = null;
			}
			else
			{
				result = list_51.Distinct<T>().ToArray<T>();
			}
			return result;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000625B4 File Offset: 0x000607B4
		internal static string smethod_413(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_1492(vrcplayerApi_0);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000625C8 File Offset: 0x000607C8
		internal static void smethod_414()
		{
			GClass84.smethod_806();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000625DC File Offset: 0x000607DC
		internal static float smethod_415(float float_3, float float_4, float float_5)
		{
			float result;
			if (float_3 < float_4)
			{
				result = float_4;
			}
			else if (float_3 > float_5)
			{
				result = float_5;
			}
			else
			{
				result = float_3;
			}
			return result;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00062600 File Offset: 0x00060800
		internal static string smethod_416()
		{
			return GClass84.smethod_694();
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00062614 File Offset: 0x00060814
		internal static string smethod_417(int int_1)
		{
			return GClass84.smethod_758(int_1);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00062628 File Offset: 0x00060828
		internal static List<GameObject> smethod_418(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<DynamicBoneCollider>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0006267C File Offset: 0x0006087C
		internal static void smethod_419(PortalInternal portalInternal_0, float float_3)
		{
			GClass84.smethod_944(portalInternal_0, float_3);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00062690 File Offset: 0x00060890
		internal static bool smethod_420(string string_4, Type type_0, string string_5, Type[] type_1, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			bool result;
			if (GClass84.smethod_1123(string_4, AccessTools.Method(type_0, string_5, type_1, null), harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
			{
				result = true;
			}
			else
			{
				string text = "Null";
				string text2 = "Null";
				string text3 = "Null";
				string text4 = "Null";
				string text5 = "Null";
				if (type_0 != null)
				{
					text = type_0.Name;
				}
				if (type_1 != null)
				{
					text2 = string.Empty;
					foreach (Type type in type_1)
					{
						text2 = text2 + ", " + type.Name;
					}
					if (text2 != string.Empty)
					{
						text2 = "(" + GClass84.smethod_1204(text2, 2, -1) + ")";
					}
				}
				if (harmonyMethod_0 != null)
				{
					text3 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text4 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text5 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Method",
					" (",
					string_4,
					", ",
					text,
					", ",
					string_5,
					", ",
					text2,
					", ",
					text3,
					", ",
					text4,
					", ",
					text5,
					")"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00062844 File Offset: 0x00060A44
		internal static bool smethod_421(Transform transform_0, GameObject gameObject_39, bool bool_10 = false, bool bool_11 = false)
		{
			return transform_0 && gameObject_39 && GClass84.smethod_466(transform_0, gameObject_39.transform, bool_10, bool_11);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0006287C File Offset: 0x00060A7C
		internal static void smethod_422(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_1614(vrcplayerApi_0);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00062890 File Offset: 0x00060A90
		internal static bool smethod_423(Type type_0, string string_4, Type[] type_1, Type[] type_2, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_232("Abyss Client_1.0.0", type_0, string_4, type_1, type_2, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000628B4 File Offset: 0x00060AB4
		internal static void smethod_424(MeshRenderer meshRenderer_0)
		{
			GClass84.smethod_1180(meshRenderer_0);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000628C8 File Offset: 0x00060AC8
		internal static Vector3 smethod_425(Vector3[] vector3_0)
		{
			Vector3 result;
			if (vector3_0.Length == 0)
			{
				result = default(Vector3);
			}
			else
			{
				Vector3 vector = default(Vector3);
				for (int i = vector3_0.Length - 1; i >= 0; i--)
				{
					vector += vector3_0[i];
				}
				result = vector / (float)vector3_0.Length;
			}
			return result;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00062924 File Offset: 0x00060B24
		internal static void smethod_426(string string_4, string string_5, string string_6, Action action_0, string string_7, Action action_1)
		{
			GClass84.smethod_1210(string_4, string_5, string_6, action_0, string_7, action_1);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00062944 File Offset: 0x00060B44
		internal static void smethod_427(APIUser apiuser_0, Action action_0)
		{
			GClass84.smethod_1102(apiuser_0, action_0);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00062958 File Offset: 0x00060B58
		internal static GameObject smethod_428(Transform transform_0)
		{
			GameObject result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"Avatar"
					});
				}
			}
			return result;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000629B4 File Offset: 0x00060BB4
		internal static Vector3 smethod_429()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			Vector3 result;
			if (vrcplayer)
			{
				result = vrcplayer.transform.forward;
			}
			else
			{
				result = default(Vector3);
			}
			return result;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000629E8 File Offset: 0x00060BE8
		internal static void smethod_430(string string_4, int int_1)
		{
			GClass84.smethod_933(string_4, int_1);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000629FC File Offset: 0x00060BFC
		internal static void smethod_431(VRC_EventHandler vrc_EventHandler_1)
		{
			GClass84.smethod_1691(vrc_EventHandler_1);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00062A10 File Offset: 0x00060C10
		internal static void smethod_432(GameObject gameObject_39)
		{
			if (gameObject_39)
			{
				List<GameObject> list = GClass84.smethod_1185(gameObject_39);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					Object.DestroyImmediate(list[i], true);
				}
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00062A54 File Offset: 0x00060C54
		internal static void smethod_433(float float_3)
		{
			GClass84.smethod_953(float_3);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00062A68 File Offset: 0x00060C68
		internal static void smethod_434()
		{
			Random.InitState(GClass84.smethod_841() ^ Random.Range(0, 1000000000));
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00062A8C File Offset: 0x00060C8C
		internal static GameObject smethod_435(GameObject gameObject_39, string string_4)
		{
			GameObject result;
			if (!gameObject_39 || string.IsNullOrEmpty(string_4))
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_47(gameObject_39.transform, string_4);
			}
			return result;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00062AC0 File Offset: 0x00060CC0
		internal static string smethod_436(uint uint_0)
		{
			return GClass84.smethod_19(uint_0);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00062AD4 File Offset: 0x00060CD4
		internal static ApiAvatar smethod_437(GameObject gameObject_39)
		{
			ApiAvatar result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1713(gameObject_39.GetComponentInChildren<VRCAvatarManager>());
			}
			return result;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00062B00 File Offset: 0x00060D00
		internal static void smethod_438(APIUser apiuser_0)
		{
			if (apiuser_0 != null)
			{
				List<string> tags = apiuser_0.tags;
				GClass70.smethod_38(string.Concat(new string[]
				{
					GClass84.smethod_828(apiuser_0, ""),
					" Has ",
					tags.Count.ToString(),
					" ",
					"Tags",
					":"
				}), GClass70.Enum1.const_0);
				for (int i = 0; i < tags.Count; i++)
				{
					GClass70.smethod_38(tags[i], GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00062B8C File Offset: 0x00060D8C
		internal static void smethod_439(AvatarPerformanceStats avatarPerformanceStats_0, AvatarPerformanceStats avatarPerformanceStats_1, bool bool_10)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_AvatarPerformanceStats_AvatarPerformanceStats_Boolean_Boolean_0(avatarPerformanceStats_0, avatarPerformanceStats_1, bool_10, false);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00062BB0 File Offset: 0x00060DB0
		internal static Player smethod_440(PlayerNet playerNet_0)
		{
			return GClass84.smethod_384(GClass84.smethod_800(playerNet_0));
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00062BCC File Offset: 0x00060DCC
		internal static string smethod_441(int int_1)
		{
			return GClass84.smethod_1216(int_1);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00062BE0 File Offset: 0x00060DE0
		internal static void smethod_442(float float_3)
		{
			GClass84.smethod_1245(float_3);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00062BF4 File Offset: 0x00060DF4
		internal static void smethod_443()
		{
			GClass84.SetForegroundWindow(GClass84.GetConsoleWindow());
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00062C0C File Offset: 0x00060E0C
		internal static void smethod_444(GClass84.GEnum48 genum48_0, VRCPlayer vrcplayer_0, ref List<Transform> list_51, out bool bool_10)
		{
			GClass84.smethod_530(genum48_0, vrcplayer_0, ref list_51, ref bool_10);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00062C24 File Offset: 0x00060E24
		internal static void smethod_445(APIUser apiuser_0)
		{
			GClass84.smethod_144(apiuser_0);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00062C38 File Offset: 0x00060E38
		internal static void smethod_446(Button button_0, Action action_0)
		{
			if (button_0 && action_0 != null)
			{
				button_0.onClick.AddListener(action_0);
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00062C68 File Offset: 0x00060E68
		internal static void smethod_447(bool bool_10)
		{
			GClass84.smethod_189(bool_10);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00062C7C File Offset: 0x00060E7C
		internal static bool smethod_448(Transform transform_0, string string_4, bool bool_10)
		{
			bool result;
			if (!transform_0 || string_4 == string.Empty)
			{
				result = false;
			}
			else if (transform_0.parent)
			{
				if (bool_10)
				{
					if (GClass84.smethod_362(transform_0.parent.name) == GClass84.smethod_362(string_4))
					{
						return true;
					}
				}
				else if (transform_0.parent.name == string_4)
				{
					return true;
				}
				result = GClass84.smethod_1734(transform_0.parent, string_4);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00062D00 File Offset: 0x00060F00
		internal static void smethod_449(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null)
			{
				GClass84.smethod_284(GClass84.smethod_958(vrcplayerApi_0));
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00062D20 File Offset: 0x00060F20
		internal static Texture2D smethod_450(Texture2D texture2D_0)
		{
			Color[] array = texture2D_0.GetPixels();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_1044(array[i]);
			}
			texture2D_0.SetPixels(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0005AED4 File Offset: 0x000590D4
		internal static GameObject smethod_451(VRCPlayer vrcplayer_0)
		{
			GameObject result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1213(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00062D78 File Offset: 0x00060F78
		internal static void smethod_452(string string_4, string string_5, string string_6, Action action_0)
		{
			GClass84.smethod_553(string_4, string_5, string_6, action_0);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00062D90 File Offset: 0x00060F90
		internal static string smethod_453()
		{
			ApiWorld apiWorld = GClass84.smethod_1424();
			ApiWorldInstance apiWorldInstance = GClass84.smethod_813();
			string result;
			if (apiWorld != null && apiWorldInstance != null)
			{
				result = apiWorld.id + ":" + apiWorldInstance.instanceId;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00062DD8 File Offset: 0x00060FD8
		internal static ApiWorldInstance smethod_454(PageWorldInfo pageWorldInfo_0)
		{
			return (pageWorldInfo_0 != null) ? pageWorldInfo_0.field_Public_ApiWorldInstance_0 : null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00062DF4 File Offset: 0x00060FF4
		internal static void smethod_455(Player player_0, float float_3)
		{
			GClass84.smethod_63(player_0).field_Private_SimpleAudioGain_0.field_Public_Single_0 = float_3;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00062E14 File Offset: 0x00061014
		internal static Texture2D smethod_456(string string_4)
		{
			Texture2D result = GClass84.smethod_998(string_4);
			GClass84.smethod_48<Texture2D>(ref result);
			return result;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00062E34 File Offset: 0x00061034
		internal static void smethod_457()
		{
			GClass84.smethod_698();
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00062E48 File Offset: 0x00061048
		internal static bool smethod_458(PlayerNet playerNet_0)
		{
			return playerNet_0 && GClass84.smethod_764(GClass84.smethod_1525(playerNet_0));
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00062E74 File Offset: 0x00061074
		internal static VRCPlayer smethod_459(bool bool_10 = false)
		{
			List<VRCPlayer> list = GClass84.smethod_1(bool_10);
			VRCPlayer result;
			if (list.Count == 1)
			{
				result = list[0];
			}
			else if (list.Count > 1)
			{
				result = list[GClass84.smethod_1673(list.Count)];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00062EC0 File Offset: 0x000610C0
		internal static VRCPlayer smethod_460()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00062ED4 File Offset: 0x000610D4
		internal static GameObject smethod_461()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.gameObject : null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00062EF4 File Offset: 0x000610F4
		internal static string[] smethod_462<T>()
		{
			return Enum.GetNames(typeof(T)).ToArray<string>();
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00062F18 File Offset: 0x00061118
		internal static IPAddress smethod_463(this uint uint_0)
		{
			return new IPAddress(new byte[]
			{
				(byte)(uint_0 >> 24 & 255U),
				(byte)(uint_0 >> 16 & 255U),
				(byte)(uint_0 >> 8 & 255U),
				(byte)(uint_0 & 255U)
			});
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00062F68 File Offset: 0x00061168
		internal static T smethod_464<T>(this VRCPlayerApi vrcplayerApi_0) where T : Component
		{
			T result;
			if (vrcplayerApi_0 == null)
			{
				result = default(T);
			}
			else
			{
				GameObject gameObject = vrcplayerApi_0.gameObject;
				result = ((gameObject != null) ? gameObject.GetComponent<T>() : default(T));
			}
			return result;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00062FA0 File Offset: 0x000611A0
		internal static bool smethod_465(Vector3 vector3_0, GameObject gameObject_39, GameObject gameObject_40 = null)
		{
			bool result;
			if (!gameObject_39)
			{
				result = false;
			}
			else
			{
				Ray ray;
				ray..ctor(vector3_0, gameObject_39.transform.position - vector3_0);
				Il2CppStructArray<RaycastHit> il2CppStructArray = Physics.RaycastAll(ray, ray.direction.magnitude);
				if (il2CppStructArray.Length > 0)
				{
					foreach (RaycastHit raycastHit in il2CppStructArray)
					{
						if (!(raycastHit.collider.gameObject == gameObject_39) && (!gameObject_40 || !(raycastHit.collider.gameObject == gameObject_40)))
						{
							return false;
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0006306C File Offset: 0x0006126C
		internal static bool smethod_466(Transform transform_0, Transform transform_1, bool bool_10 = false, bool bool_11 = false)
		{
			bool result;
			if (!transform_0 || !transform_1)
			{
				result = false;
			}
			else
			{
				if (bool_11)
				{
					GClass84.smethod_1746(GClass84.smethod_266(transform_1), false);
				}
				List<Transform> list = GClass84.smethod_403(transform_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					GClass84.smethod_273<Transform>(list[i], transform_1, bool_10);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000630D8 File Offset: 0x000612D8
		internal static List<Transform> smethod_467(DynamicBone dynamicBone_0)
		{
			List<Transform> result;
			if (!dynamicBone_0)
			{
				result = new List<Transform>();
			}
			else
			{
				Transform root = dynamicBone_0.m_Root;
				if (!root)
				{
					result = new List<Transform>();
				}
				else
				{
					result = GClass84.smethod_805(root, dynamicBone_0.m_Exclusions.smethod_1334<Transform>());
				}
			}
			return result;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00063128 File Offset: 0x00061328
		internal static void smethod_468(Color color_0)
		{
			GClass84.smethod_1153(color_0);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0006313C File Offset: 0x0006133C
		internal static void smethod_469()
		{
			GClass84.smethod_614();
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00063150 File Offset: 0x00061350
		internal static bool smethod_470(VRCPlayerApi vrcplayerApi_0)
		{
			return vrcplayerApi_0 != null && GClass84.smethod_307(GClass84.smethod_958(vrcplayerApi_0));
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00063174 File Offset: 0x00061374
		internal static List<GameObject> smethod_471(Transform transform_0)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					Transform child = transform_0.GetChild(i);
					list.Add(child.gameObject);
					list.AddRange(GClass84.smethod_471(child));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000631D4 File Offset: 0x000613D4
		internal static void smethod_472(MethodInfo methodInfo_5)
		{
			GClass84.smethod_1538(methodInfo_5);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000631E8 File Offset: 0x000613E8
		internal static void smethod_473()
		{
			GClass84.smethod_330();
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000631FC File Offset: 0x000613FC
		internal static void smethod_474(string string_4)
		{
			GClass84.smethod_921(string_4);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0005AED4 File Offset: 0x000590D4
		internal static GameObject smethod_475(Player player_0)
		{
			GameObject result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1213(player_0.transform);
			}
			return result;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00063210 File Offset: 0x00061410
		internal static void smethod_476()
		{
			GClass84.smethod_200();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00063224 File Offset: 0x00061424
		internal static void smethod_477(string string_4, string string_5, string string_6)
		{
			GClass84.smethod_1315(string_4, string_5, string_6);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0006323C File Offset: 0x0006143C
		internal static PlayerNet smethod_478(Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Internal_get_PlayerNet_0() : null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00063258 File Offset: 0x00061458
		internal static string smethod_479()
		{
			return GClass84.smethod_781();
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0006326C File Offset: 0x0006146C
		internal static GameObject smethod_480(PlayerNet playerNet_0)
		{
			GameObject result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_603(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00063298 File Offset: 0x00061498
		internal static string smethod_481()
		{
			return "UserInterface/MenuContent/Screens/UserInfo";
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000632AC File Offset: 0x000614AC
		internal static void smethod_482(string string_4)
		{
			PageUserInfo pageUserInfo = GClass84.smethod_950();
			pageUserInfo.field_Private_APIUser_0 = new APIUser
			{
				id = string_4
			};
			if (pageUserInfo.field_Private_APIUser_0.id != GClass84.smethod_1372().id)
			{
				pageUserInfo.ToggleMute();
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000632F4 File Offset: 0x000614F4
		internal static string smethod_483(string string_4, string string_5, string string_6)
		{
			return string_5 + string_4 + string_6;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0006330C File Offset: 0x0006150C
		internal static void smethod_484(string string_4)
		{
			GClass84.smethod_1291(string_4);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00063320 File Offset: 0x00061520
		internal static string smethod_485()
		{
			return GClass84.smethod_684(GClass84.smethod_126());
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0006333C File Offset: 0x0006153C
		internal static void smethod_486(Mesh mesh_0)
		{
			if (mesh_0 && (mesh_0.name != "Cube" && mesh_0.name != "Capsule" && mesh_0.name != "Cylinder" && mesh_0.name != "Plane" && mesh_0.name != "Sphere" && mesh_0.name != "Quad"))
			{
				Object.DestroyImmediate(mesh_0, true);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000633CC File Offset: 0x000615CC
		internal static void smethod_487(UiVRCList uiVRCList_0)
		{
			GClass84.smethod_409(uiVRCList_0);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000633E0 File Offset: 0x000615E0
		internal static void smethod_488()
		{
			GClass84.list_4.Add(new Action(GClass84.smethod_915));
			GClass84.list_6.Add(new Action(GClass84.smethod_1583));
			GClass84.list_13.Add(new Action(GClass84.smethod_476));
			GClass84.list_15.Add(new Action<string, List<string>>(GClass84.smethod_1049));
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00063448 File Offset: 0x00061648
		internal static bool smethod_489(VRC_Trigger vrc_Trigger_0, string string_4)
		{
			bool result;
			if (!vrc_Trigger_0)
			{
				result = false;
			}
			else
			{
				VRC_Trigger.TriggerType triggerType = GClass84.smethod_1737(string_4);
				if (triggerType == 0)
				{
					List<string> list = GClass84.smethod_517(vrc_Trigger_0, false);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						if (list[i] == string_4)
						{
							vrc_Trigger_0.ExecuteCustomTrigger(string_4);
							return true;
						}
					}
				}
				else
				{
					List<VRC_Trigger.TriggerType> list2 = GClass84.smethod_1096(vrc_Trigger_0, false);
					for (int j = list2.Count - 1; j >= 0; j--)
					{
						if (list2[j] == triggerType)
						{
							vrc_Trigger_0.ExecuteTriggerType(triggerType);
							return true;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000634FC File Offset: 0x000616FC
		internal static bool smethod_490(Transform transform_0, string string_4)
		{
			bool result;
			if (string_4 == string.Empty)
			{
				result = false;
			}
			else
			{
				if (transform_0)
				{
					UdonBehaviour[] array = transform_0.GetComponents<UdonBehaviour>();
					for (int i = 0; i < array.Length; i++)
					{
						if (GClass84.smethod_1697(array[i], string_4))
						{
							return true;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00063558 File Offset: 0x00061758
		internal static T smethod_491<T>(T gparam_0) where T : Object
		{
			return gparam_0 ? Object.Instantiate<T>(gparam_0) : default(T);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00063588 File Offset: 0x00061788
		internal static void smethod_492(float float_3)
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			if (!(locomotionInputController == null))
			{
				GClass84.smethod_1294(GClass84.smethod_210() + float_3, GClass84.smethod_552() + float_3, GClass84.smethod_354() + float_3);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000635C0 File Offset: 0x000617C0
		internal static void smethod_493(List<GameObject> list_51, GameObject gameObject_39)
		{
			if (gameObject_39)
			{
				GClass84.smethod_1001(list_51, gameObject_39.transform);
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000635E4 File Offset: 0x000617E4
		internal static string smethod_494(string string_4, string string_5, string string_6, bool bool_10 = false)
		{
			return GClass84.smethod_1268(string_4, string_5, string_6, bool_10);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000635FC File Offset: 0x000617FC
		internal static string smethod_495(Transform transform_0)
		{
			string result;
			if (!transform_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(transform_0, null);
			}
			return result;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00063628 File Offset: 0x00061828
		internal static Transform smethod_496()
		{
			GameObject gameObject = GClass84.smethod_1398();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00063648 File Offset: 0x00061848
		internal static bool smethod_497(Transform transform_0, Transform transform_1)
		{
			return transform_1 && GClass84.smethod_217(transform_0, transform_1.position);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00063674 File Offset: 0x00061874
		internal static List<GClass84.GStruct153> smethod_498(Hashtable hashtable_0)
		{
			List<GClass84.GStruct153> list = new List<GClass84.GStruct153>();
			List<GClass84.GStruct153> result;
			if (hashtable_0 == null)
			{
				result = list;
			}
			else
			{
				foreach (object obj in hashtable_0.Keys)
				{
					try
					{
						if (obj != null)
						{
							object obj2 = hashtable_0[obj];
							if (obj2 != null)
							{
								list.Add(new GClass84.GStruct153(obj.ToString(), obj2.ToString()));
							}
							else
							{
								list.Add(new GClass84.GStruct153(obj.ToString(), string.Empty));
							}
						}
					}
					catch
					{
						list.Add(new GClass84.GStruct153("Error", "Error"));
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0006374C File Offset: 0x0006194C
		internal static string smethod_499(string string_4)
		{
			string path = GClass84.smethod_536(string_4);
			string[] files = Directory.GetFiles(path);
			for (int i = 0; i < files.Length; i++)
			{
				if (!files[i].Contains("unins") && !files[i].Contains("000") && files[i].EndsWith(".exe"))
				{
					return files[i];
				}
			}
			return string.Empty;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000637BC File Offset: 0x000619BC
		internal static string smethod_500(VRCPlayerApi vrcplayerApi_0)
		{
			string result;
			if (vrcplayerApi_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_1520(GClass84.smethod_958(vrcplayerApi_0));
			}
			return result;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000637E4 File Offset: 0x000619E4
		internal static void smethod_501<T>(List<T> list_51, T gparam_0) where T : Object
		{
			if (!(gparam_0 == null) && list_51 != null)
			{
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (list_51[i] == gparam_0)
					{
						list_51.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00063840 File Offset: 0x00061A40
		internal static void smethod_502(string string_4)
		{
			GClass84.smethod_482(string_4);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00063854 File Offset: 0x00061A54
		internal static string smethod_503(string string_4)
		{
			return GClass84.smethod_1359(string_4);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00063868 File Offset: 0x00061A68
		internal static bool smethod_504(List<Transform> list_51, bool bool_10 = true)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_796(list_51[i], true))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000638B0 File Offset: 0x00061AB0
		internal static void smethod_505(MeshFilter meshFilter_0, bool bool_10 = false)
		{
			GClass84.smethod_1338(meshFilter_0, bool_10);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000638C4 File Offset: 0x00061AC4
		internal static short smethod_506(VRCPlayer vrcplayer_0)
		{
			short result;
			if (!vrcplayer_0)
			{
				result = 0;
			}
			else
			{
				result = vrcplayer_0.Method_Public_get_Int16_0();
			}
			return result;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000638E8 File Offset: 0x00061AE8
		internal static Vector3 smethod_507(Vector2 vector2_0)
		{
			return new Vector3(vector2_0.y, vector2_0.x, 0f);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00063910 File Offset: 0x00061B10
		internal static GameObject smethod_508()
		{
			return GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot/MainModel");
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0006392C File Offset: 0x00061B2C
		internal static string smethod_509(ApiWorld apiWorld_0, string string_4)
		{
			string empty;
			if (apiWorld_0 == null || string_4 == string.Empty || apiWorld_0.instances == null)
			{
				empty = string.Empty;
			}
			else
			{
				foreach (string text in apiWorld_0.instances.Keys)
				{
					int num = GClass84.smethod_1611(text, "~");
					if (num != -1)
					{
						if (string_4 == GClass84.smethod_1428(text, num))
						{
							return text;
						}
					}
					else if (text == string_4)
					{
						return text;
					}
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000639C4 File Offset: 0x00061BC4
		internal static List<string> smethod_510(VRC_Trigger vrc_Trigger_0, out List<VRC_Trigger.TriggerEvent> list_51, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			list_51 = new List<VRC_Trigger.TriggerEvent>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType == 0)
					{
						list_51.Add(vrc_Trigger_0.Triggers[i]);
						list.Add(vrc_Trigger_0.Triggers[i].Name);
					}
					else
					{
						list_51.Add(vrc_Trigger_0.Triggers[i]);
						list.Add(vrc_Trigger_0.Triggers[i].TriggerType.ToString());
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_564<VRC_Trigger.TriggerEvent>(ref list, ref list_51);
			}
			return list;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00063A90 File Offset: 0x00061C90
		internal static void smethod_511(string string_4)
		{
			GClass84.smethod_502(string_4);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00063AA4 File Offset: 0x00061CA4
		internal static string smethod_512(string string_4)
		{
			string text = string.Empty;
			while (string_4 != string.Empty)
			{
				text += GClass84.smethod_360(string_4, 1);
				string_4 = GClass84.smethod_1428(string_4, GClass84.smethod_593(string_4) - 1);
			}
			return text;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00063AE8 File Offset: 0x00061CE8
		internal static string smethod_513(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_871(vrcplayerApi_0);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00063AFC File Offset: 0x00061CFC
		internal static Transform[] smethod_514(Transform transform_0)
		{
			Transform[] result;
			if (!transform_0)
			{
				result = new Transform[0];
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					Transform child = transform_0.GetChild(i);
					list.Add(child);
					list.AddRange(GClass84.smethod_1495(child));
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005D078 File Offset: 0x0005B278
		internal static GameObject smethod_515(Player player_0)
		{
			GameObject result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_172(player_0.transform);
			}
			return result;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00063B5C File Offset: 0x00061D5C
		internal static void smethod_516(string string_4, int int_1)
		{
			GameObject gameObject = GameObject.Find(string_4);
			if (!gameObject)
			{
				GClass70.smethod_38("!GO", GClass70.Enum1.const_0);
			}
			else
			{
				SkinnedMeshRenderer component = gameObject.GetComponent<SkinnedMeshRenderer>();
				if (!component)
				{
					GClass70.smethod_38("!SMR", GClass70.Enum1.const_0);
				}
				else
				{
					List<GClass84.GStruct134> list = GClass84.smethod_1728(component);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						GClass70.smethod_38(list[i].int_0.ToString() + ": " + list[i].string_0, GClass70.Enum1.const_0);
					}
					Mesh sharedMesh = component.sharedMesh;
					GClass84.smethod_1079(sharedMesh, int_1);
				}
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00063C10 File Offset: 0x00061E10
		internal static List<string> smethod_517(VRC_Trigger vrc_Trigger_0, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType == 0)
					{
						list.Add(vrc_Trigger_0.Triggers[i].Name);
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_661<string>(ref list);
			}
			return list;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00063C80 File Offset: 0x00061E80
		internal static APIUser smethod_518(Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Internal_get_APIUser_0() : null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00063C9C File Offset: 0x00061E9C
		internal static void smethod_519(Material material_1)
		{
			GClass84.smethod_1541(material_1);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00063CB0 File Offset: 0x00061EB0
		internal static void smethod_520(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 == null)
			{
				GClass70.smethod_36("ChangeAvatar: AA is null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.smethod_711(apiAvatar_0.id);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00063CDC File Offset: 0x00061EDC
		internal static void smethod_521(Player player_0)
		{
			GClass84.smethod_783(player_0);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00063CF0 File Offset: 0x00061EF0
		internal static string smethod_522(UdonBehaviour udonBehaviour_0, int int_1)
		{
			int num = 0;
			foreach (KeyValuePair<string, List<uint>> keyValuePair in udonBehaviour_0._eventTable)
			{
				if (num == int_1)
				{
					return keyValuePair.key;
				}
				num++;
			}
			return "<NULL>";
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00063D3C File Offset: 0x00061F3C
		internal static void smethod_523(Vector2 vector2_0, Vector2 vector2_1, Color color_0)
		{
			GClass84.smethod_1054(vector2_0, vector2_1, color_0);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00063D54 File Offset: 0x00061F54
		internal static List<Transform> smethod_524(List<DynamicBone> list_51)
		{
			List<Transform> result;
			if (list_51 == null || list_51.Count < 1)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					list.AddRange(GClass84.smethod_467(list_51[i]));
				}
				list = list.Distinct<Transform>().ToList<Transform>();
				list.RemoveAll(new Predicate<Transform>(GClass84.Class101.class101_0.method_29));
				result = list;
			}
			return result;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00063DE0 File Offset: 0x00061FE0
		internal static GameObject smethod_525()
		{
			if (!GClass84.gameObject_36)
			{
				GClass84.gameObject_36 = GClass84.smethod_1577("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local");
			}
			return GClass84.gameObject_36;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00063E14 File Offset: 0x00062014
		internal static void smethod_526()
		{
			GClass84.smethod_1696(1000000f);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00063E2C File Offset: 0x0006202C
		internal static void smethod_527()
		{
			SpawnManager spawnManager = GClass84.smethod_809();
			if (spawnManager)
			{
				List<Spawn> field_Private_List_1_Spawn_ = spawnManager.field_Private_List_1_Spawn_0;
				if (field_Private_List_1_Spawn_ != null && field_Private_List_1_Spawn_.Count > 0)
				{
					Spawn spawn = field_Private_List_1_Spawn_[GClass84.smethod_1673(field_Private_List_1_Spawn_.Count)];
					Transform transform = (spawn != null) ? spawn.transform : null;
					if (transform)
					{
						GClass84.smethod_1318(transform, true);
					}
				}
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00063E90 File Offset: 0x00062090
		internal static void smethod_528(bool bool_10)
		{
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Used",
				" ",
				"Memory",
				" ",
				"Before",
				" ",
				"Collecting",
				" ",
				"Garbage",
				": ",
				GC.GetTotalMemory(false).ToString()
			}), GClass70.Enum1.const_0);
			if (bool_10)
			{
				GClass84.smethod_357();
			}
			GC.InternalCollect(GC.MaxGeneration);
			GC.Collect(GC.MaxGeneration, 1, true, true);
			GC.Method_Internal_Static_Void_Boolean_Boolean_0(true, true);
			GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, true, true);
			GClass70.smethod_38(string.Concat(new string[]
			{
				"Used",
				" ",
				"Memory",
				" ",
				"After",
				" ",
				"Collecting",
				" ",
				"Garbage",
				": ",
				GC.GetTotalMemory(true).ToString()
			}), GClass70.Enum1.const_0);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00063FBC File Offset: 0x000621BC
		internal static void smethod_529(Color color_0, string string_4)
		{
			GClass84.smethod_154(color_0, string_4);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00063FD0 File Offset: 0x000621D0
		internal static void smethod_530(GClass84.GEnum48 genum48_0, VRCPlayer vrcplayer_0, ref List<Transform> list_51, ref bool bool_10)
		{
			GClass84.smethod_267(genum48_0, vrcplayer_0, ref list_51, ref bool_10);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00063FE8 File Offset: 0x000621E8
		internal static string smethod_531(int int_1)
		{
			return GClass84.smethod_1240(int_1);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00063FFC File Offset: 0x000621FC
		internal static void smethod_532(UiVRCList uiVRCList_0)
		{
			GClass84.smethod_1535(uiVRCList_0);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00064010 File Offset: 0x00062210
		internal static void smethod_533(string string_4, string string_5)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_Single_0(string_4, string_5, 10f);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00064034 File Offset: 0x00062234
		internal static ulong smethod_534(VRCPlayer vrcplayer_0)
		{
			ulong result;
			if (!vrcplayer_0)
			{
				result = 0UL;
			}
			else
			{
				result = vrcplayer_0.field_Private_UInt64_0;
			}
			return result;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00064060 File Offset: 0x00062260
		internal static bool smethod_535(GameObject gameObject_39, Vector3 vector3_0, bool bool_10 = false)
		{
			return gameObject_39 && GClass84.smethod_293(gameObject_39.transform, vector3_0, bool_10);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0006408C File Offset: 0x0006228C
		internal static string smethod_536(string string_4)
		{
			return GClass84.smethod_815(string_4);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x000640A0 File Offset: 0x000622A0
		internal static List<CCDIK> smethod_537(Transform transform_0)
		{
			List<CCDIK> result;
			if (!transform_0)
			{
				result = new List<CCDIK>();
			}
			else
			{
				List<CCDIK> list = transform_0.GetComponents<CCDIK>().ToList<CCDIK>();
				list.AddRange(transform_0.GetComponentsInChildren<CCDIK>(true));
				result = list.Distinct<CCDIK>().ToList<CCDIK>();
			}
			return result;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000640E8 File Offset: 0x000622E8
		internal static string smethod_538(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_413(vrcplayerApi_0);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000640FC File Offset: 0x000622FC
		internal static Color smethod_539(short short_0)
		{
			Color result;
			if (short_0 <= 100)
			{
				result = new Color(0f, 1f, 0f, 1f);
			}
			else if (short_0 < 200)
			{
				result = new Color((float)(short_0 - 100) / 100f, 1f, 0f, 1f);
			}
			else if (short_0 < 300)
			{
				result = new Color(1f, 1f - (float)(short_0 - 200) / 100f, 0f, 1f);
			}
			else if (short_0 < 400)
			{
				result = new Color(1f - (float)(short_0 - 200) / 200f, 0f, 0f, 1f);
			}
			else
			{
				result = new Color(0f, 0f, 0f, 1f);
			}
			return result;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000641E8 File Offset: 0x000623E8
		internal static List<VRC_Pickup> smethod_540()
		{
			List<VRC_Pickup> list = new List<VRC_Pickup>();
			List<GameObject> list2 = GClass84.smethod_549(false, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				VRC_Pickup component = list2[i].GetComponent<VRC_Pickup>();
				if (component)
				{
					list.Add(component);
				}
				list.AddRange(list2[i].GetComponentsInChildren<VRC_Pickup>(true));
			}
			return list;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00064250 File Offset: 0x00062450
		internal static void smethod_541(Slider slider_0, UnityAction<float> unityAction_0)
		{
			if (slider_0 && unityAction_0 != null)
			{
				slider_0.onValueChanged.AddListener(unityAction_0);
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0006427C File Offset: 0x0006247C
		internal static void smethod_542(MethodInfo methodInfo_5)
		{
			GClass84.smethod_472(methodInfo_5);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00064290 File Offset: 0x00062490
		internal static void smethod_543(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_237(apiAvatar_0);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000642A4 File Offset: 0x000624A4
		internal static void smethod_544()
		{
			GClass84.smethod_21();
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000642B8 File Offset: 0x000624B8
		internal static void smethod_545(Transform transform_0, bool bool_10)
		{
			GClass84.smethod_65(transform_0, bool_10);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000642CC File Offset: 0x000624CC
		internal static string smethod_546(ref string string_4, string string_5)
		{
			int num = GClass84.smethod_1611(string_4, string_5);
			string result;
			if (num == -1)
			{
				string text = string_4;
				string_4 = string.Empty;
				result = text;
			}
			else
			{
				string text = GClass84.smethod_1428(string_4, num);
				string_4 = GClass84.smethod_1204(string_4, num + GClass84.smethod_593(string_5), -1);
				result = text;
			}
			return result;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00064314 File Offset: 0x00062514
		internal static List<VRCPlayerApi> smethod_547(bool bool_10 = true)
		{
			List<VRCPlayerApi> result;
			if (bool_10)
			{
				result = GClass84.smethod_1239();
			}
			else
			{
				List<VRCPlayerApi> list = new List<VRCPlayerApi>();
				VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
				List<VRCPlayerApi> list2 = GClass84.smethod_1584();
				for (int i = 0; i < list.Count; i++)
				{
					if (list2[i] != null && list2[i] != vrcplayerApi)
					{
						list.Add(list2[i]);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00064388 File Offset: 0x00062588
		internal static void smethod_548(string string_4, string string_5, InputField.InputType inputType_0, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7, bool bool_10, Action<VRCUiPopup> action_2)
		{
			GClass84.smethod_33(string_4, string_5, inputType_0, string_6, action_0, action_1, string_7, bool_10, action_2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000643B4 File Offset: 0x000625B4
		internal static List<GameObject> smethod_549(bool bool_10, bool bool_11 = false, bool bool_12 = false)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1164();
			for (int i = 0; i < list2.Count; i++)
			{
				if ((bool_11 || !(list2[i].tag == "Player")) && (bool_12 || (!(list2[i].name == "PlayerManager") && !(list2[i].name == "VRC_OBJECTS") && !(list2[i].name == "SceneEventHandlerAndInstantiator"))))
				{
					list.Add(list2[i]);
					if (bool_10)
					{
						list.AddRange(GClass84.smethod_94(list2[i]));
					}
				}
			}
			return list;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000648A4 File Offset: 0x00062AA4
		internal static List<GameObject> smethod_550(List<Component> list_51)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> result;
			if (list_51 == null)
			{
				result = list;
			}
			else
			{
				for (int i = 0; i < list_51.Count; i++)
				{
					if (list_51[i])
					{
						list.Add(list_51[i].gameObject);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000648F8 File Offset: 0x00062AF8
		internal static VRCPlayer smethod_551(string string_4)
		{
			return GClass84.smethod_367(GClass84.smethod_554(string_4));
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00064914 File Offset: 0x00062B14
		internal static float smethod_552()
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			float result;
			if (!locomotionInputController)
			{
				result = 0f;
			}
			else
			{
				result = locomotionInputController.field_Public_Single_1;
			}
			return result;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00064944 File Offset: 0x00062B44
		internal static void smethod_553(string string_4, string string_5, string string_6, Action action_0)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_String_Action_Action_1_VRCUiPopup_0(string_4, string_5, string_6, action_0, null);
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0006496C File Offset: 0x00062B6C
		internal static Player smethod_554(string string_4)
		{
			Player[] array = GClass84.smethod_870();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (GClass84.smethod_684(array[i]) == string_4)
				{
					return array[i];
				}
			}
			return null;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000649B0 File Offset: 0x00062BB0
		internal static bool smethod_555(Vector3 vector3_0)
		{
			return float.IsNaN(vector3_0.x) || float.IsNaN(vector3_0.y) || float.IsNaN(vector3_0.z);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000649E8 File Offset: 0x00062BE8
		internal static bool smethod_556(GameObject gameObject_39, Transform transform_0, bool bool_10 = false)
		{
			return gameObject_39 && transform_0 && GClass84.smethod_706(gameObject_39.transform, transform_0, bool_10);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00064A20 File Offset: 0x00062C20
		internal static string smethod_557(Component component_0)
		{
			return GClass84.smethod_1633(component_0);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00064A34 File Offset: 0x00062C34
		internal static AssetBundleDownloadManager smethod_558()
		{
			return AssetBundleDownloadManager.Method_Internal_Static_get_AssetBundleDownloadManager_PDM_0();
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00064A48 File Offset: 0x00062C48
		internal static string smethod_559()
		{
			return GClass84.smethod_646();
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00064A5C File Offset: 0x00062C5C
		internal static string smethod_560(string string_4, int int_1, int int_2)
		{
			return GClass84.smethod_1155(string_4, int_1, int_2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00064A74 File Offset: 0x00062C74
		internal static void smethod_561(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, int_5);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00064AA4 File Offset: 0x00062CA4
		internal static string smethod_562(string string_4, char[] char_1)
		{
			return GClass84.smethod_594(string_4, char_1);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00064AB8 File Offset: 0x00062CB8
		internal static void smethod_563(PortalInternal portalInternal_0, float float_3)
		{
			GClass84.smethod_419(portalInternal_0, float_3);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00064ACC File Offset: 0x00062CCC
		internal static void smethod_564<T>(ref List<string> list_51, ref List<T> list_52)
		{
			if (list_51 != null && list_51.Count != 0 && list_51.Count == list_52.Count)
			{
				int i = list_51.Count - 1;
				IL_74:
				while (i >= 0)
				{
					for (int j = list_51.Count - 1; j > i; j--)
					{
						if (list_51[i].Equals(list_51[j]))
						{
							list_51.RemoveAt(j);
							list_52.RemoveAt(j);
							IL_70:
							i--;
							goto IL_74;
						}
					}
					goto IL_70;
				}
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00064B58 File Offset: 0x00062D58
		internal static void smethod_565(this ApiAvatar apiAvatar_0, string string_4, string string_5, string string_6 = "")
		{
			GClass84.smethod_190(apiAvatar_0, string_4, string_5, string_6);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00064B70 File Offset: 0x00062D70
		internal static void smethod_566(float float_3, float float_4)
		{
			GClass84.smethod_196(float_3, float_4);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00064B84 File Offset: 0x00062D84
		internal static GameObject smethod_567(VRCPlayerApi vrcplayerApi_0)
		{
			GameObject result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_685(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00064BA8 File Offset: 0x00062DA8
		internal static string smethod_568(GameObject gameObject_39, GameObject gameObject_40)
		{
			return GClass84.smethod_64(gameObject_39, gameObject_40);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00064BBC File Offset: 0x00062DBC
		internal static string smethod_569(VRCPlayer vrcplayer_0)
		{
			string result;
			if (!vrcplayer_0)
			{
				result = string.Empty;
			}
			else
			{
				ulong num = GClass84.smethod_534(vrcplayer_0);
				if (num == 0UL)
				{
					result = string.Empty;
				}
				else
				{
					string text = string.Empty;
					try
					{
						GStruct9 gstruct;
						if (GClass18.smethod_4(new GStruct22(num), out gstruct) && gstruct.uint_0 != 0U && GClass84.smethod_1192(GClass84.smethod_436(gstruct.uint_0)))
						{
							text = GClass84.smethod_436(gstruct.uint_0);
						}
					}
					catch
					{
						return string.Empty;
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00064C58 File Offset: 0x00062E58
		internal static void smethod_570()
		{
			GClass84.smethod_115();
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00064C6C File Offset: 0x00062E6C
		internal static void smethod_571(GClass156 gclass156_1, int int_1, int int_2, int int_3)
		{
			GClass84.smethod_676(gclass156_1, int_1, int_2, int_3);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00064C84 File Offset: 0x00062E84
		internal static List<Transform> smethod_572(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				List<DynamicBone> list2 = GClass84.smethod_1556(transform_0);
				for (int i = list2.Count - 1; i >= 0; i--)
				{
					DynamicBone dynamicBone = list2[i];
					if (dynamicBone)
					{
						if (!dynamicBone.m_Root || !dynamicBone.m_Root.gameObject)
						{
							list.Add(dynamicBone.transform);
							GClass84.smethod_761(dynamicBone);
						}
						else
						{
							for (int j = dynamicBone.m_Colliders.Count - 1; j >= 0; j--)
							{
								if (!dynamicBone.m_Colliders[j])
								{
									dynamicBone.m_Colliders.RemoveAt(j);
								}
							}
							for (int k = dynamicBone.m_Exclusions.Count - 1; k >= 0; k--)
							{
								if (!dynamicBone.m_Exclusions[k])
								{
									dynamicBone.m_Exclusions.RemoveAt(k);
								}
							}
							for (int l = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.Count - 1; l >= 0; l--)
							{
								if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[l] == null || !dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[l].field_Public_Transform_0)
								{
									dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.RemoveAt(l);
									for (int m = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.Count - 1; m >= 0; m--)
									{
										if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m] != null)
										{
											if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 == l)
											{
												dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 = -1;
											}
											else if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 > l)
											{
												DynamicBone.ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique objectNPrivateTrInSiVeSiQuVeSiVeSiUnique = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m];
												int field_Public_Int32_ = objectNPrivateTrInSiVeSiQuVeSiVeSiUnique.field_Public_Int32_0;
												objectNPrivateTrInSiVeSiQuVeSiVeSiUnique.field_Public_Int32_0 = field_Public_Int32_ - 1;
											}
										}
									}
								}
							}
						}
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00064EC8 File Offset: 0x000630C8
		internal static void smethod_573(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			if (int_1 > int_3)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num2;
			int num5 = int_2;
			int num6 = int_4 - int_2;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_1; i <= int_3; i++)
			{
				if (int_5 == 1)
				{
					GClass84.smethod_774(gclass156_1, (float)i, (float)num5);
				}
				else
				{
					GClass84.smethod_1015(gclass156_1, (float)i, (float)num5, int_5, int_5);
				}
				num3 += num4;
				if (2 * num3 >= num)
				{
					num5 += num6;
					num3 -= num;
				}
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00064F78 File Offset: 0x00063178
		internal static string smethod_574()
		{
			return GClass84.smethod_1411();
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00064F8C File Offset: 0x0006318C
		internal static bool smethod_575(GameObject gameObject_39, GameObject gameObject_40)
		{
			bool result;
			if (!gameObject_39 || !gameObject_40)
			{
				result = false;
			}
			else
			{
				Ray ray;
				ray..ctor(gameObject_39.transform.position, gameObject_40.transform.position - gameObject_39.transform.position);
				Il2CppStructArray<RaycastHit> il2CppStructArray = Physics.RaycastAll(ray, ray.direction.magnitude);
				if (il2CppStructArray.Length > 0)
				{
					foreach (RaycastHit raycastHit in il2CppStructArray)
					{
						if (!(raycastHit.collider.gameObject == gameObject_39) && !(raycastHit.collider.gameObject == gameObject_40))
						{
							return false;
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00065074 File Offset: 0x00063274
		internal static void smethod_576(float float_3)
		{
			GClass84.smethod_1517(float_3);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00065088 File Offset: 0x00063288
		internal static string smethod_577(string string_4)
		{
			return GClass84.smethod_618(string_4);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0006509C File Offset: 0x0006329C
		internal static bool smethod_578(string string_4, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, int int_1, float float_3)
		{
			VRC_EventHandler vrc_EventHandler = GClass84.VRC_EventHandler_0;
			bool result;
			if (!vrc_EventHandler)
			{
				result = false;
			}
			else
			{
				vrc_EventHandler.TriggerEvent(string_4, vrcBroadcastType_0, gameObject_39, int_1, float_3);
				result = true;
			}
			return result;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000650D0 File Offset: 0x000632D0
		internal static List<GameObject> smethod_579(Scene scene_0)
		{
			return scene_0.GetRootGameObjects().ToList<GameObject>();
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000650EC File Offset: 0x000632EC
		internal static bool smethod_580(Vector3 vector3_0)
		{
			return float.IsInfinity(vector3_0.x) || float.IsInfinity(vector3_0.y) || float.IsInfinity(vector3_0.z);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00065124 File Offset: 0x00063324
		internal static void smethod_581(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_654(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00065144 File Offset: 0x00063344
		internal static Texture2D smethod_582(Texture2D texture2D_0, float float_3)
		{
			Color32[] array = texture2D_0.GetPixels32();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_1651(array[i], float_3);
			}
			texture2D_0.SetPixels32(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0006519C File Offset: 0x0006339C
		internal static void smethod_583(float float_3)
		{
			GClass84.smethod_1177(float_3);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000651B0 File Offset: 0x000633B0
		internal static string smethod_584()
		{
			return GClass84.smethod_701();
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000651C4 File Offset: 0x000633C4
		internal static ApiWorld smethod_585()
		{
			return GClass84.smethod_1114(GClass84.smethod_1467());
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000651E0 File Offset: 0x000633E0
		internal static void smethod_586(Player player_0, Player player_1, Action<Player, Player, bool> action_0)
		{
			GClass84.smethod_670(player_0, player_1, action_0);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000651F8 File Offset: 0x000633F8
		internal static void smethod_587(GameObject gameObject_39)
		{
			GClass84.smethod_849(gameObject_39);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0006520C File Offset: 0x0006340C
		internal static void smethod_588(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_1112(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0006522C File Offset: 0x0006342C
		internal static List<GameObject> smethod_589()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				if (list2[i].GetComponent<VRC_Pickup>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0006528C File Offset: 0x0006348C
		internal static void smethod_590(Renderer renderer_0, bool bool_10, ref HighlightsFXStandalone highlightsFXStandalone_1)
		{
			GClass84.smethod_1702(renderer_0, bool_10, ref highlightsFXStandalone_1);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000652A4 File Offset: 0x000634A4
		internal static bool smethod_591(string string_4, string string_5, List<char> list_51)
		{
			bool result;
			if (GClass84.smethod_593(string_4) != GClass84.smethod_593(string_5))
			{
				result = false;
			}
			else
			{
				int num = GClass84.smethod_593(string_4);
				for (int i = 0; i < num; i++)
				{
					if (string_4[i] == '*')
					{
						if (!list_51.Contains(string_5[i]))
						{
							return false;
						}
					}
					else if (string_5[i] == '*')
					{
						if (!list_51.Contains(string_4[i]))
						{
							return false;
						}
					}
					else if (string_4[i] != string_5[i])
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00065344 File Offset: 0x00063544
		internal static List<GClass84.GStruct135> smethod_592(GameObject gameObject_39)
		{
			List<GClass84.GStruct135> result;
			if (!gameObject_39)
			{
				result = new List<GClass84.GStruct135>();
			}
			else
			{
				result = GClass84.smethod_341(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00065374 File Offset: 0x00063574
		internal static int smethod_593(string string_4)
		{
			return string_4.Length;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0006538C File Offset: 0x0006358C
		internal static string smethod_594(string string_4, char[] char_1)
		{
			if (char_1 == null)
			{
				char_1 = GClass193.char_10;
			}
			string result;
			if (char_1 == null || char_1.Length < 1)
			{
				result = string_4;
			}
			else
			{
				List<int> list = GClass84.smethod_932(string_4, "*");
				for (int i = list.Count - 1; i >= 0; i--)
				{
					string_4 = GClass84.smethod_1428(string_4, list[i]) + char_1[GClass84.smethod_1673(char_1.Length)].ToString() + GClass84.smethod_1204(string_4, list[i] + 1, -1);
				}
				result = string_4;
			}
			return result;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0006541C File Offset: 0x0006361C
		internal static bool smethod_595(Transform transform_0, GameObject gameObject_39, bool bool_10 = false)
		{
			return transform_0 && gameObject_39 && GClass84.smethod_706(transform_0, gameObject_39.transform, bool_10);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00065454 File Offset: 0x00063654
		internal static void smethod_596()
		{
			GClass84.smethod_150();
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00065468 File Offset: 0x00063668
		private static string smethod_597(int int_1)
		{
			return GClass84.smethod_1190(int_1);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0006547C File Offset: 0x0006367C
		internal static void smethod_598()
		{
			GClass84.smethod_145();
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00065490 File Offset: 0x00063690
		internal static void smethod_599(UiVRCList uiVRCList_0, List<ApiAvatar> list_51)
		{
			if (uiVRCList_0)
			{
				uiVRCList_0.Method_Protected_Void_List_1_T_Int32_Boolean_VRCUiContentButton_0<ApiAvatar>(list_51, 0, true, null);
				if (list_51 != null && list_51.Count > 0)
				{
					GClass84.smethod_668(uiVRCList_0, 270f);
					GClass84.smethod_532(uiVRCList_0);
				}
				else
				{
					GClass84.smethod_668(uiVRCList_0, 53f);
				}
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000654E4 File Offset: 0x000636E4
		internal static VRCPlayerApi smethod_600(GameObject gameObject_39, bool bool_10 = true)
		{
			VRCPlayerApi result;
			if (!gameObject_39)
			{
				result = null;
			}
			else if (bool_10)
			{
				result = Networking.GetOwner(gameObject_39);
			}
			else
			{
				List<VRCPlayerApi> list = GClass84.smethod_1239();
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].IsOwner(gameObject_39))
					{
						return list[i];
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0006554C File Offset: 0x0006374C
		internal static Color smethod_601(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_1041(GClass84.smethod_307(GClass84.smethod_958(vrcplayerApi_0)));
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0006556C File Offset: 0x0006376C
		internal static float smethod_602(float float_3)
		{
			return (float_3 - 32f) / 1.8f;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00065588 File Offset: 0x00063788
		internal static GameObject smethod_603(Transform transform_0)
		{
			GameObject result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"_AvatarShadowClone"
					});
				}
			}
			return result;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000655E4 File Offset: 0x000637E4
		internal static ApiAvatar smethod_604()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			ApiAvatar result;
			if (!vrcplayer)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1713(GClass84.smethod_1416(vrcplayer));
			}
			return result;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00065614 File Offset: 0x00063814
		internal static List<IK> smethod_605(GameObject gameObject_39)
		{
			List<IK> result;
			if (!gameObject_39)
			{
				result = new List<IK>();
			}
			else
			{
				List<IK> list = gameObject_39.GetComponents<IK>().ToList<IK>();
				list.AddRange(gameObject_39.GetComponentsInChildren<IK>(true));
				result = list.Distinct<IK>().ToList<IK>();
			}
			return result;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0006565C File Offset: 0x0006385C
		internal static string smethod_606(bool bool_10)
		{
			if (GClass84.string_1 == string.Empty)
			{
				try
				{
					WebRequest webRequest = WebRequest.Create("http://2371845348:59345/GetIP/");
					WebResponse response = webRequest.GetResponse();
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							GClass84.string_1 = streamReader.ReadToEnd();
						}
					}
					response.Close();
				}
				catch
				{
					if (!bool_10 && GClass84.string_1 == string.Empty)
					{
						return GClass84.smethod_221(true);
					}
				}
			}
			return GClass84.string_1;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00065720 File Offset: 0x00063920
		internal static void smethod_607()
		{
			GClass84.smethod_1000();
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00065734 File Offset: 0x00063934
		internal static void smethod_608()
		{
			GClass84.smethod_527();
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00065748 File Offset: 0x00063948
		internal static List<string> smethod_609(VRC_Trigger vrc_Trigger_0, out List<VRC_Trigger.TriggerEvent> list_51, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			list_51 = new List<VRC_Trigger.TriggerEvent>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType == 0)
					{
						list_51.Add(vrc_Trigger_0.Triggers[i]);
						list.Add(vrc_Trigger_0.Triggers[i].Name);
					}
				}
			}
			if (bool_10 && list.Count == list_51.Count)
			{
				int j = list.Count - 1;
				IL_D7:
				while (j >= 0)
				{
					for (int k = list.Count - 1; k > j; k--)
					{
						if (list[j] == list[k])
						{
							list.RemoveAt(k);
							list_51.RemoveAt(k);
							IL_D1:
							j--;
							goto IL_D7;
						}
					}
					goto IL_D1;
				}
			}
			return list;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0006583C File Offset: 0x00063A3C
		internal static void smethod_610(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, string string_7, bool bool_11, Action<VRCUiPopup> action_1)
		{
			GClass84.smethod_142(string_4, string_5, inputType_0, bool_10, string_6, action_0, string_7, bool_11, action_1);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00065868 File Offset: 0x00063A68
		internal static void smethod_611()
		{
			GClass84.smethod_570();
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0006587C File Offset: 0x00063A7C
		internal static void smethod_612(UiVRCList uiVRCList_0, float float_3)
		{
			if (uiVRCList_0)
			{
				LayoutElement component = uiVRCList_0.GetComponent<LayoutElement>();
				if (component)
				{
					component.minHeight = float_3;
				}
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000658AC File Offset: 0x00063AAC
		internal static void smethod_613(IUser iuser_0)
		{
			GClass84.smethod_1005(iuser_0);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000658C0 File Offset: 0x00063AC0
		internal static void smethod_614()
		{
			GClass84.smethod_689();
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000658D4 File Offset: 0x00063AD4
		internal static VRCUiCursorManager smethod_615()
		{
			return VRCUiCursorManager.field_Private_Static_VRCUiCursorManager_0;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000658E8 File Offset: 0x00063AE8
		internal static void smethod_616(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_899(vrcplayer_0);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000658FC File Offset: 0x00063AFC
		internal static string smethod_617(Transform transform_0, GameObject gameObject_39)
		{
			return GClass84.smethod_1745(transform_0, gameObject_39);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00065910 File Offset: 0x00063B10
		internal static string smethod_618(string string_4)
		{
			return GClass84.smethod_991(string_4, "\"");
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0006592C File Offset: 0x00063B2C
		internal static List<Transform> smethod_619(GameObject gameObject_39, int int_1)
		{
			List<Transform> result;
			if (!gameObject_39 || int_1 < 1)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_1687(gameObject_39.transform, int_1);
			}
			return result;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00065960 File Offset: 0x00063B60
		internal static void smethod_620()
		{
			GClass84.smethod_775();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00065974 File Offset: 0x00063B74
		internal static string smethod_621(Transform transform_0, Transform transform_1)
		{
			string result;
			if (!transform_0 || transform_0 == transform_1)
			{
				result = string.Empty;
			}
			else
			{
				string text = string.Empty;
				Transform parent = transform_0.parent;
				if (transform_1)
				{
					while (parent)
					{
						text = parent.name + "/" + text;
						parent = parent.parent;
						if (parent == transform_1)
						{
							return text + transform_0.name;
						}
					}
				}
				else
				{
					while (parent)
					{
						text = parent.name + "/" + text;
						parent = parent.parent;
					}
				}
				result = text + transform_0.name;
			}
			return result;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00065A24 File Offset: 0x00063C24
		internal static List<GClass84.GStruct163> smethod_622(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			return GClass84.smethod_1698(int_1, int_2, gstruct.int_0, gstruct.int_1);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00065A50 File Offset: 0x00063C50
		internal static string smethod_623(int int_1)
		{
			return GClass84.smethod_376(int_1);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00065A64 File Offset: 0x00063C64
		internal static int smethod_624(int int_1)
		{
			int result;
			if (int_1 < 0)
			{
				result = int_1 * -1;
			}
			else
			{
				result = int_1;
			}
			return result;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00065A80 File Offset: 0x00063C80
		internal static void smethod_625()
		{
			GClass84.smethod_833();
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00065A94 File Offset: 0x00063C94
		internal static void smethod_626(Text text_1)
		{
			GClass84.smethod_630(text_1);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00065AA8 File Offset: 0x00063CA8
		internal static bool smethod_627(Transform transform_0, GameObject gameObject_39, bool bool_10 = false, bool bool_11 = false)
		{
			return transform_0 && gameObject_39 && GClass84.smethod_1022(transform_0, gameObject_39.transform, bool_10, bool_11);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00065AE0 File Offset: 0x00063CE0
		internal static bool smethod_628()
		{
			bool result = false;
			List<GameObject> list = GClass84.smethod_589();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (GClass84.smethod_994(list[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00065B20 File Offset: 0x00063D20
		internal static bool smethod_629(GameObject gameObject_39)
		{
			bool result;
			if (!gameObject_39)
			{
				result = false;
			}
			else
			{
				Camera main = Camera.main;
				result = (main && GClass84.smethod_1526(main.transform.position, gameObject_39.transform, GClass84.smethod_461()));
			}
			return result;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00065B70 File Offset: 0x00063D70
		internal static void smethod_630(Text text_1)
		{
			GClass84.smethod_375(text_1);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00065B84 File Offset: 0x00063D84
		internal static void smethod_631()
		{
			GClass84.smethod_634();
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00065B98 File Offset: 0x00063D98
		internal static void smethod_632()
		{
			List<Notification> list = MonoBehaviour1PublicGaBoLi1NoObSoSoUnique.field_Private_Static_List_1_Notification_0.smethod_1334<Notification>();
			bool flag = false;
			if (list != null)
			{
				int num = list.Count - 1;
				while (num >= 0 && list[num] != null)
				{
					if (flag)
					{
						GClass70.smethod_24(string.Empty, GClass70.Enum1.const_0);
					}
					GClass70.smethod_24(list[num].notificationType, GClass70.Enum1.const_0);
					GClass70.smethod_24(list[num].message, GClass70.Enum1.const_0);
					for (int i = 0; i < list[num].details.Count; i++)
					{
						int num2 = 0;
						foreach (KeyValuePair<string, Object> keyValuePair in list[num].details)
						{
							if (num2 == i)
							{
								GClass70.smethod_24(keyValuePair.key + ": " + keyValuePair.value.ToString(), GClass70.Enum1.const_0);
							}
							num2++;
						}
						GClass70.smethod_24("<NULL>", GClass70.Enum1.const_0);
					}
					flag = true;
					num--;
				}
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00065CA8 File Offset: 0x00063EA8
		internal static Texture2D smethod_633()
		{
			int num = 1536;
			int num2 = 512;
			Texture2D texture2D = GClass84.smethod_1130(1536, 512);
			Color32[] array = new Color32[786432];
			for (int i = 0; i < num2; i++)
			{
				int num3 = num2 - i - 1;
				for (int j = 0; j < num; j++)
				{
					if (i < 256)
					{
						if (j < 256)
						{
							array[num3 * num + j] = new Color32(byte.MaxValue, (byte)GClass84.smethod_415((float)j + (float)(255 - j) * ((float)(255 - i) / 255f), 0f, 255f), (byte)(255 - i), byte.MaxValue);
						}
						else if (j < 512)
						{
							byte b = (byte)(j - 256);
							array[num3 * num + j] = new Color32((byte)GClass84.smethod_415((float)(byte.MaxValue - b) + (float)b * ((float)(255 - i) / 255f), 0f, 255f), byte.MaxValue, (byte)(255 - i), byte.MaxValue);
						}
						else if (j < 768)
						{
							byte b2 = (byte)(j - 512);
							array[num3 * num + j] = new Color32((byte)(255 - i), byte.MaxValue, (byte)GClass84.smethod_415((float)b2 + (float)(byte.MaxValue - b2) * ((float)(255 - i) / 255f), 0f, 255f), byte.MaxValue);
						}
						else if (j < 1024)
						{
							byte b3 = (byte)(j - 768);
							array[num3 * num + j] = new Color32((byte)(255 - i), (byte)GClass84.smethod_415((float)(byte.MaxValue - b3) + (float)b3 * ((float)(255 - i) / 255f), 0f, 255f), byte.MaxValue, byte.MaxValue);
						}
						else if (j < 1280)
						{
							byte b4 = (byte)(j - 1024);
							array[num3 * num + j] = new Color32((byte)GClass84.smethod_415((float)b4 + (float)(byte.MaxValue - b4) * ((float)(255 - i) / 255f), 0f, 255f), (byte)(255 - i), byte.MaxValue, byte.MaxValue);
						}
						else if (j < 1536)
						{
							byte b5 = (byte)(j - 1280);
							array[num3 * num + j] = new Color32(byte.MaxValue, (byte)(255 - i), (byte)GClass84.smethod_415((float)(byte.MaxValue - b5) + (float)b5 * ((float)(255 - i) / 255f), 0f, 255f), byte.MaxValue);
						}
					}
					else if (i < 512)
					{
						int num4 = i - 256;
						if (j < 256)
						{
							array[num3 * num + j] = new Color32((byte)(255 - num4), (byte)GClass84.smethod_415((float)j - (float)j * ((float)num4 / 255f), 0f, 255f), 0, byte.MaxValue);
						}
						else if (j < 512)
						{
							byte b6 = (byte)(j - 256);
							array[num3 * num + j] = new Color32((byte)GClass84.smethod_415((float)(byte.MaxValue - b6) - (float)(byte.MaxValue - b6) * ((float)num4 / 255f), 0f, 255f), (byte)(255 - num4), 0, byte.MaxValue);
						}
						else if (j < 768)
						{
							byte b7 = (byte)(j - 512);
							array[num3 * num + j] = new Color32(0, (byte)(255 - num4), (byte)GClass84.smethod_415((float)b7 - (float)b7 * ((float)num4 / 255f), 0f, 255f), byte.MaxValue);
						}
						else if (j < 1024)
						{
							byte b8 = (byte)(j - 768);
							array[num3 * num + j] = new Color32(0, (byte)GClass84.smethod_415((float)(byte.MaxValue - b8) - (float)(byte.MaxValue - b8) * ((float)num4 / 255f), 0f, 255f), (byte)(255 - num4), byte.MaxValue);
						}
						else if (j < 1280)
						{
							byte b9 = (byte)(j - 1024);
							array[num3 * num + j] = new Color32((byte)GClass84.smethod_415((float)b9 - (float)b9 * ((float)num4 / 255f), 0f, 255f), 0, (byte)(255 - num4), byte.MaxValue);
						}
						else if (j < 1536)
						{
							byte b10 = (byte)(j - 1280);
							array[num3 * num + j] = new Color32((byte)(255 - num4), 0, (byte)GClass84.smethod_415((float)(byte.MaxValue - b10) - (float)(byte.MaxValue - b10) * ((float)num4 / 255f), 0f, 255f), byte.MaxValue);
						}
					}
				}
			}
			texture2D.SetPixels32(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0006621C File Offset: 0x0006441C
		internal static void smethod_634()
		{
			GameObject gameObject = GClass84.smethod_229();
			if (gameObject)
			{
				Transform transform = gameObject.transform.Find("Container/Window/QMParent");
				gameObject = ((transform != null) ? transform.gameObject : null);
				if (gameObject)
				{
					List<GameObject> list = GClass84.smethod_1185(gameObject);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						if (list[i].activeSelf && (list[i].name != "BackgroundLayer01" && list[i].name != "BackgroundLayer02" && list[i].name != "MenuControllers" && list[i].name != "Modal_Alert" && list[i] != GClass84.gclass161_0.gameObject_4))
						{
							list[i].SetActive(false);
						}
					}
				}
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0006632C File Offset: 0x0006452C
		internal static string smethod_635(string string_4, int int_1)
		{
			return Path.Combine(Path.GetFullPath(GClass84.smethod_931().path), GClass84.smethod_247(string_4), GClass84.smethod_597(int_1));
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00066360 File Offset: 0x00064560
		internal static bool smethod_636(GameObject gameObject_39, bool bool_10 = true)
		{
			bool result;
			if (!gameObject_39)
			{
				result = false;
			}
			else
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
				if (GClass84.smethod_600(gameObject_39, bool_10) != vrcplayerApi)
				{
					GClass84.smethod_994(gameObject_39);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0006639C File Offset: 0x0006459C
		internal static void smethod_637(Transform transform_0, bool bool_10)
		{
			GClass84.smethod_943(transform_0, bool_10);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000663B0 File Offset: 0x000645B0
		internal static void smethod_638()
		{
			IntPtr intPtr = GClass84.FindWindow(null, "VRChat");
			if (intPtr != IntPtr.Zero)
			{
				GClass84.SetForegroundWindow(intPtr);
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000663E0 File Offset: 0x000645E0
		internal static Transform[] smethod_639(GameObject gameObject_39)
		{
			Transform[] result;
			if (!gameObject_39)
			{
				result = new Transform[0];
			}
			else
			{
				result = GClass84.smethod_514(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00066410 File Offset: 0x00064610
		internal static bool smethod_640(List<GameObject> list_51, Vector3 vector3_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_535(list_51[i], vector3_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00066458 File Offset: 0x00064658
		internal static void smethod_641()
		{
			GClass84.list_43.Add(MelonCoroutines.Start(GClass84.smethod_294()));
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0006647C File Offset: 0x0006467C
		internal static void smethod_642()
		{
			GClass84.smethod_290(GClass84.smethod_1010());
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00066494 File Offset: 0x00064694
		internal static string smethod_643(Player player_0, string string_4 = "")
		{
			return GClass84.smethod_1536(player_0, string_4);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000664A8 File Offset: 0x000646A8
		internal static GameObject smethod_644()
		{
			if (!GClass84.gameObject_35)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_35 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_35;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00066508 File Offset: 0x00064708
		internal static NetworkManager smethod_645()
		{
			return NetworkManager.field_Internal_Static_NetworkManager_0;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0006651C File Offset: 0x0006471C
		internal static string smethod_646()
		{
			return PageUserInfo.field_Internal_Static_String_1;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00066530 File Offset: 0x00064730
		internal static Transform smethod_647()
		{
			GameObject gameObject = GClass84.smethod_1298();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00066550 File Offset: 0x00064750
		internal static void smethod_648(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_1724(apiAvatar_0);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00066564 File Offset: 0x00064764
		internal static void smethod_649(Button button_0)
		{
			GClass84.smethod_182(button_0);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00066578 File Offset: 0x00064778
		internal static Player smethod_650(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_1513(GClass84.smethod_831(vrcplayerApi_0));
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00066594 File Offset: 0x00064794
		internal static void smethod_651(Vector3 vector3_0, Vector3 vector3_1, Color color_0)
		{
			GClass84.smethod_1331(vector3_0, vector3_1, color_0);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000665AC File Offset: 0x000647AC
		internal static bool smethod_652(Player player_0)
		{
			bool result;
			string string_;
			if (!player_0)
			{
				GClass70.smethod_38("Player Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else if (GClass84.smethod_934(out string_))
			{
				GClass84.list_40.Add(GClass84.smethod_684(player_0));
				MelonCoroutines.Start(GClass84.smethod_201(GClass84.smethod_1264<string>(GClass84.list_40), string_));
				result = true;
			}
			else
			{
				GClass70.smethod_38("Can't Get Avatar!", GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00066614 File Offset: 0x00064814
		internal static string smethod_653(APIUser apiuser_0)
		{
			return GClass84.smethod_1116(apiuser_0);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00066628 File Offset: 0x00064828
		internal static void smethod_654(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_861(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00066648 File Offset: 0x00064848
		internal static void smethod_655(ref string string_4, string string_5, string string_6)
		{
			GClass84.smethod_1405(ref string_4, string_5, string_6);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00066660 File Offset: 0x00064860
		internal static string smethod_656()
		{
			return "UserInterface/MenuContent/Screens/Social";
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00066674 File Offset: 0x00064874
		internal static int smethod_657(VRCPlayer vrcplayer_0)
		{
			int result;
			if (!vrcplayer_0)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_175(GClass84.smethod_1333(vrcplayer_0));
			}
			return result;
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000666A0 File Offset: 0x000648A0
		internal static Vector3 smethod_658(Vector2 vector2_0)
		{
			return new Vector3(vector2_0.x, vector2_0.y);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000666C0 File Offset: 0x000648C0
		internal static List<string> smethod_659(string string_4, string string_5)
		{
			List<string> list = new List<string>();
			List<string> result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				list.Add(string_4);
				result = list;
			}
			else
			{
				int i = 0;
				int num = 0;
				int num2 = 0;
				while (i < GClass84.smethod_593(string_4))
				{
					if (string_4[i] == string_5[num])
					{
						if (num == GClass84.smethod_593(string_5) - 1)
						{
							list.Add(GClass84.smethod_1204(string_4, num2, i - num - num2));
							num2 = i + 1;
							num = 0;
						}
						else
						{
							num++;
						}
					}
					else
					{
						num = 0;
					}
					i++;
				}
				list.Add(GClass84.smethod_1204(string_4, num2, -1));
				result = list;
			}
			return result;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00066768 File Offset: 0x00064968
		internal static AvatarPerformanceStats smethod_660()
		{
			return GClass84.smethod_274(GClass84.smethod_105());
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00066784 File Offset: 0x00064984
		internal static void smethod_661<T>(ref List<T> list_51)
		{
			if (list_51 != null && list_51.Count != 0)
			{
				list_51 = list_51.Distinct<T>().ToList<T>();
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x000667B4 File Offset: 0x000649B4
		internal static Transform smethod_662(Transform transform_0)
		{
			Transform result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_836(transform, new List<string>
					{
						"Avatar"
					});
				}
			}
			return result;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00066810 File Offset: 0x00064A10
		internal static void smethod_663(int int_1)
		{
			GClass84.smethod_726(int_1);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00066824 File Offset: 0x00064A24
		internal static List<GameObject> smethod_664()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				if (list2[i].GetComponent<VRC_Interactable>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00066884 File Offset: 0x00064A84
		internal static void smethod_665(APIUser apiuser_0)
		{
			if (apiuser_0 != null)
			{
				GClass84.smethod_1604(apiuser_0.id);
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000668A4 File Offset: 0x00064AA4
		internal static string smethod_666(Transform transform_0, Transform transform_1)
		{
			return GClass84.smethod_621(transform_0, transform_1);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000668B8 File Offset: 0x00064AB8
		internal static void smethod_667(Player player_0)
		{
			GClass84.smethod_1028(GClass84.smethod_367(player_0));
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000668D0 File Offset: 0x00064AD0
		internal static void smethod_668(UiVRCList uiVRCList_0, float float_3)
		{
			GClass84.smethod_1113(uiVRCList_0, float_3);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000668E4 File Offset: 0x00064AE4
		internal static List<Cloth> smethod_669(GameObject gameObject_39)
		{
			List<Cloth> result;
			if (!gameObject_39)
			{
				result = new List<Cloth>();
			}
			else
			{
				List<Cloth> list = gameObject_39.GetComponents<Cloth>().ToList<Cloth>();
				list.AddRange(gameObject_39.GetComponentsInChildren<Cloth>(true));
				result = list.Distinct<Cloth>().ToList<Cloth>();
			}
			return result;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0006692C File Offset: 0x00064B2C
		internal static void smethod_670(Player player_0, Player player_1, Action<Player, Player, bool> action_0)
		{
			GClass84.smethod_1344(player_0, player_1, action_0);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00066944 File Offset: 0x00064B44
		internal static List<Type> smethod_671(Assembly[] assembly_0)
		{
			List<Type> list = new List<Type>();
			foreach (Assembly assembly_ in assembly_0)
			{
				list.AddRange(GClass84.smethod_1515(assembly_));
			}
			return list;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0006697C File Offset: 0x00064B7C
		internal static void smethod_672(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_449(vrcplayerApi_0);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00066990 File Offset: 0x00064B90
		internal static void smethod_673(Renderer renderer_0, bool bool_10, HighlightsFXStandalone highlightsFXStandalone_1 = null, bool bool_11 = false)
		{
			GClass84.smethod_1591(renderer_0, bool_10, highlightsFXStandalone_1, bool_11);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000669A8 File Offset: 0x00064BA8
		internal static void smethod_674(Transform transform_0)
		{
			GClass84.smethod_1171(transform_0);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000669BC File Offset: 0x00064BBC
		internal static Vector2 smethod_675(Vector2 vector2_0)
		{
			Vector2 result;
			result..ctor(vector2_0.x, vector2_0.y);
			result.Normalize();
			return result;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000669E8 File Offset: 0x00064BE8
		internal static void smethod_676(GClass156 gclass156_1, int int_1, int int_2, int int_3)
		{
			GClass84.smethod_886(gclass156_1, int_1, int_2, int_3);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00066A00 File Offset: 0x00064C00
		internal static string smethod_677(char[] char_1, int int_1)
		{
			return GClass84.smethod_858(char_1, int_1);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00066A14 File Offset: 0x00064C14
		internal static void smethod_678(int int_1)
		{
			Application.targetFrameRate = GClass84.smethod_1690(int_1, 1);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00066A30 File Offset: 0x00064C30
		internal static void smethod_679(float float_3, float float_4, float float_5)
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			if (locomotionInputController)
			{
				locomotionInputController.field_Public_Single_2 = float_3;
				locomotionInputController.field_Public_Single_1 = float_4;
				locomotionInputController.field_Public_Single_0 = float_5;
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00066A64 File Offset: 0x00064C64
		internal static void smethod_680(ApiWorld apiWorld_0)
		{
			GClass84.smethod_852(apiWorld_0);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00066A78 File Offset: 0x00064C78
		internal static bool smethod_681(GameObject gameObject_39)
		{
			return gameObject_39 && GClass84.smethod_738(gameObject_39.transform);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00066AA4 File Offset: 0x00064CA4
		internal static FlatBufferNetworkSerializer smethod_682()
		{
			Player player = GClass84.smethod_1010();
			return (player != null) ? player.GetComponent<FlatBufferNetworkSerializer>() : null;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00066AC4 File Offset: 0x00064CC4
		internal static void smethod_683(string string_4)
		{
			GClass84.smethod_797(string_4);
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00066AD8 File Offset: 0x00064CD8
		internal static string smethod_684(Player player_0)
		{
			return GClass84.smethod_1587(player_0);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00066AEC File Offset: 0x00064CEC
		internal static GameObject smethod_685(GameObject gameObject_39)
		{
			GameObject result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1039(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
			}
			return result;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00066B28 File Offset: 0x00064D28
		internal static void smethod_686(Button button_0, Action action_0)
		{
			if (button_0)
			{
				button_0.onClick = new Button.ButtonClickedEvent();
				if (action_0 != null)
				{
					button_0.onClick.AddListener(action_0);
				}
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00066B64 File Offset: 0x00064D64
		internal static GameObject smethod_687()
		{
			if (!GClass84.gameObject_8)
			{
				GClass84.gameObject_8 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup");
			}
			return GClass84.gameObject_8;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00066B98 File Offset: 0x00064D98
		internal static void smethod_688()
		{
			GClass84.smethod_434();
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00066BAC File Offset: 0x00064DAC
		internal static void smethod_689()
		{
			Il2CppArrayBase<HighlightsFXStandalone> il2CppArrayBase = Resources.FindObjectsOfTypeAll<HighlightsFXStandalone>();
			if (il2CppArrayBase != null && il2CppArrayBase.Count > 0 && il2CppArrayBase[0])
			{
				GClass84.highlightsFXStandalone_0 = il2CppArrayBase[0];
				GClass84.gameObject_38 = GClass84.highlightsFXStandalone_0.gameObject;
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00066BFC File Offset: 0x00064DFC
		internal static Vector2 smethod_690()
		{
			Vector2 vector2_ = default(Vector2);
			vector2_.x = GClass84.smethod_790() * 2f;
			vector2_.y = GClass84.smethod_790() * 2f;
			return GClass84.smethod_675(vector2_);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00066C40 File Offset: 0x00064E40
		internal static string smethod_691()
		{
			return GClass84.smethod_574();
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00066C54 File Offset: 0x00064E54
		internal static GameObject smethod_692(VRCPlayer vrcplayer_0)
		{
			GameObject result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_428(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00066C80 File Offset: 0x00064E80
		internal static Transform smethod_693(Transform transform_0, string string_4)
		{
			return GClass84.smethod_836(transform_0, GClass84.smethod_659(string_4, "/"));
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00066CA0 File Offset: 0x00064EA0
		internal static string smethod_694()
		{
			return GClass84.smethod_1664();
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00066CB4 File Offset: 0x00064EB4
		internal static string smethod_695(string string_4)
		{
			return GClass84.smethod_1221(string_4);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00066CC8 File Offset: 0x00064EC8
		internal static APIUser smethod_696(PageUserInfo pageUserInfo_0)
		{
			return (pageUserInfo_0 != null) ? pageUserInfo_0.field_Private_APIUser_0 : null;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00066CE4 File Offset: 0x00064EE4
		internal static void smethod_697(APIUser apiuser_0)
		{
			if (apiuser_0 != null)
			{
				GClass70.smethod_24("emailVerified" + ": " + apiuser_0.emailVerified.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasPendingEmail" + ": " + apiuser_0.hasPendingEmail.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("obfuscatedPendingEmail" + ": " + apiuser_0.obfuscatedPendingEmail, GClass70.Enum1.const_0);
				GClass70.smethod_24("obfuscatedEmail" + ": " + apiuser_0.obfuscatedEmail, GClass70.Enum1.const_0);
				GClass70.smethod_24("instanceId" + ": " + apiuser_0.instanceId, GClass70.Enum1.const_0);
				GClass70.smethod_24("currentAvatarAssetUrl" + ": " + apiuser_0.currentAvatarAssetUrl, GClass70.Enum1.const_0);
				GClass70.smethod_24("worldId" + ": " + apiuser_0.worldId, GClass70.Enum1.const_0);
				GClass70.smethod_24("authToken" + ": " + apiuser_0.authToken, GClass70.Enum1.const_0);
				GClass70.smethod_24("currentAvatarThumbnailImageUrl" + ": " + apiuser_0.currentAvatarThumbnailImageUrl, GClass70.Enum1.const_0);
				GClass70.smethod_24("isFriend" + ": " + apiuser_0.isFriend.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("acceptedTOSVersion" + ": " + apiuser_0.acceptedTOSVersion.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("blob" + ": " + apiuser_0.blob, GClass70.Enum1.const_0);
				GClass70.smethod_24("displayName" + ": " + GClass84.smethod_828(apiuser_0, ""), GClass70.Enum1.const_0);
				GClass70.smethod_24("username" + ": " + apiuser_0.username, GClass70.Enum1.const_0);
				GClass70.smethod_24("bio" + ": " + apiuser_0.bio, GClass70.Enum1.const_0);
				GClass70.smethod_24("location" + ": " + apiuser_0.location, GClass70.Enum1.const_0);
				GClass70.smethod_24("currentAvatarImageUrl" + ": " + apiuser_0.currentAvatarImageUrl, GClass70.Enum1.const_0);
				GClass70.smethod_24("avatarId" + ": " + apiuser_0.avatarId, GClass70.Enum1.const_0);
				GClass70.smethod_24("statusValue" + ": " + apiuser_0.statusValue.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("unsubscribe" + ": " + apiuser_0.unsubscribe.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("friendKey" + ": " + apiuser_0.friendKey, GClass70.Enum1.const_0);
				GClass70.smethod_24("last_login" + ": " + apiuser_0.last_login, GClass70.Enum1.const_0);
				GClass70.smethod_24("developerType" + ": " + apiuser_0.developerType.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasEmail" + ": " + apiuser_0.hasEmail.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasLoggedInFromClient" + ": " + apiuser_0.hasLoggedInFromClient.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("status" + ": " + apiuser_0.status, GClass70.Enum1.const_0);
				GClass70.smethod_24("homeLocation" + ": " + apiuser_0.homeLocation, GClass70.Enum1.const_0);
				GClass70.smethod_24("canPublishAvatars" + ": " + apiuser_0.canPublishAvatars.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("canPublishWorlds" + ": " + apiuser_0.canPublishWorlds.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("isUntrusted" + ": " + apiuser_0.isUntrusted.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("isNewUser" + ": " + apiuser_0.isNewUser.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasBasicTrustLevel" + ": " + apiuser_0.hasBasicTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasKnownTrustLevel" + ": " + apiuser_0.hasKnownTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasTrustedTrustLevel" + ": " + apiuser_0.hasTrustedTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasVeteranTrustLevel" + ": " + apiuser_0.hasVeteranTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasLegendTrustLevel" + ": " + apiuser_0.hasLegendTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasNegativeTrustLevel" + ": " + apiuser_0.hasNegativeTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasVeryNegativeTrustLevel" + ": " + apiuser_0.hasVeryNegativeTrustLevel.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasFeedbackAccess" + ": " + apiuser_0.hasFeedbackAccess.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("showSocialRank" + ": " + apiuser_0.showSocialRank.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("showModTag" + ": " + apiuser_0.showModTag.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("canSetStatusOffline" + ": " + apiuser_0.canSetStatusOffline.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusIsSetToOffline" + ": " + apiuser_0.statusIsSetToOffline.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusIsSetToJoinMe" + ": " + apiuser_0.statusIsSetToJoinMe.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusIsSetToAskMe" + ": " + apiuser_0.statusIsSetToAskMe.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusIsSetToDoNotDisturb" + ": " + apiuser_0.statusIsSetToDoNotDisturb.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("canPublishAllContent" + ": " + apiuser_0.canPublishAllContent.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasSuperPowers" + ": " + apiuser_0.hasSuperPowers.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasModerationPowers" + ": " + apiuser_0.hasModerationPowers.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusDescription" + ": " + apiuser_0.statusDescription, GClass70.Enum1.const_0);
				GClass70.smethod_24("state" + ": " + apiuser_0.state, GClass70.Enum1.const_0);
				GClass70.smethod_24("allowAvatarCopying" + ": " + apiuser_0.allowAvatarCopying.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("last_platform" + ": " + apiuser_0.last_platform, GClass70.Enum1.const_0);
				GClass70.smethod_24("twoFactorAuthEnabled" + ": " + apiuser_0.twoFactorAuthEnabled.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("IsOnMobile" + ": " + apiuser_0.IsOnMobile.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasNoPowers" + ": " + apiuser_0.hasNoPowers.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasScriptingAccess" + ": " + apiuser_0.hasScriptingAccess.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasVIPAccess" + ": " + apiuser_0.hasVIPAccess.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("hasBirthday" + ": " + apiuser_0.hasBirthday.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("IsSelf" + ": " + apiuser_0.IsSelf.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("canSeeAllUsersStatus" + ": " + apiuser_0.canSeeAllUsersStatus.ToString(), GClass70.Enum1.const_0);
				GClass70.smethod_24("statusDefaultDescriptionDisplayString" + ": " + apiuser_0.statusDefaultDescriptionDisplayString, GClass70.Enum1.const_0);
				GClass70.smethod_24("_last_platform" + ": " + apiuser_0._last_platform, GClass70.Enum1.const_0);
				GClass70.smethod_24("statusDescriptionDisplayString" + ": " + apiuser_0.statusDescriptionDisplayString, GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000674A0 File Offset: 0x000656A0
		internal static void smethod_698()
		{
			GClass84.list_48.Add(MelonCoroutines.Start(GClass84.smethod_350()));
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000674C4 File Offset: 0x000656C4
		internal static void smethod_699()
		{
			foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
			{
				if (!vrc_Pickup.IsHeld && vrc_Pickup.gameObject.activeSelf && (vrc_Pickup.name.ToLower().Contains("pen") || vrc_Pickup.name.ToLower().Contains("marker")))
				{
					GClass84.smethod_994(vrc_Pickup.gameObject);
					Vector3 position = vrc_Pickup.transform.position;
					Quaternion rotation = vrc_Pickup.transform.rotation;
					Networking.RPC(0, vrc_Pickup.gameObject, "PickedUp", new Object[0]);
					new WaitForSeconds(0.01f);
					vrc_Pickup.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
					Networking.RPC(0, vrc_Pickup.gameObject, "PenDown", new Object[0]);
					for (int i = 0; i < 20; i++)
					{
						vrc_Pickup.transform.position = Vector3.negativeInfinity;
						new WaitForSeconds(0.01f);
						vrc_Pickup.transform.position = Vector3.positiveInfinity;
					}
					Networking.RPC(0, vrc_Pickup.gameObject, "PenUp", new Object[0]);
					new WaitForSeconds(0.01f);
					vrc_Pickup.transform.position = position;
					vrc_Pickup.transform.rotation = rotation;
					Networking.RPC(0, vrc_Pickup.gameObject, "Dropped", new Object[0]);
				}
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00067694 File Offset: 0x00065894
		internal static Transform smethod_700(VRCPlayerApi vrcplayerApi_0)
		{
			Transform result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_880(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000676B8 File Offset: 0x000658B8
		internal static string smethod_701()
		{
			return "UserInterface/MenuContent/Screens/Avatar";
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000676CC File Offset: 0x000658CC
		internal static List<GameObject> smethod_702(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<DynamicBone>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00067720 File Offset: 0x00065920
		internal static Player smethod_703(int int_1)
		{
			List<VRCPlayerApi> list = GClass84.smethod_1239();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].playerId == int_1)
				{
					return GClass84.smethod_831(list[i]);
				}
			}
			return null;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00067770 File Offset: 0x00065970
		internal static void smethod_704(string string_4)
		{
			GClass84.smethod_1693(string_4);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00067784 File Offset: 0x00065984
		internal static void smethod_705(GameObject gameObject_39, bool bool_10)
		{
			if (gameObject_39)
			{
				GClass84.smethod_637(gameObject_39.transform, bool_10);
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000677A8 File Offset: 0x000659A8
		internal static bool smethod_706(Transform transform_0, Transform transform_1, bool bool_10 = false)
		{
			bool result;
			if (!transform_0 || !transform_1)
			{
				result = false;
			}
			else
			{
				List<Transform> list = GClass84.smethod_403(transform_0);
				GClass84.smethod_403(transform_1);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					list[i].SetParent(transform_1, bool_10);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0006780C File Offset: 0x00065A0C
		internal static void smethod_707(Mesh mesh_0, int int_1)
		{
			if (mesh_0)
			{
				GClass70.smethod_38("0", GClass70.Enum1.const_0);
				Il2CppStructArray<Vector3> il2CppStructArray = new Il2CppStructArray<Vector3>((long)mesh_0.vertices.Length);
				Il2CppStructArray<Vector3> il2CppStructArray2 = new Il2CppStructArray<Vector3>((long)mesh_0.normals.Length);
				Il2CppStructArray<Vector3> il2CppStructArray3 = new Il2CppStructArray<Vector3>((long)mesh_0.tangents.Length);
				mesh_0.GetBlendShapeFrameVertices(int_1, mesh_0.GetBlendShapeFrameCount(int_1) - 1, il2CppStructArray, il2CppStructArray2, il2CppStructArray3);
				List<string> list = new List<string>();
				GClass70.smethod_38("1", GClass70.Enum1.const_0);
				list.Add("deltaVertices:");
				foreach (Vector3 vector in il2CppStructArray)
				{
					if (float.IsInfinity(vector.x))
					{
						GClass70.smethod_24("V.x.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector.y))
					{
						GClass70.smethod_24("V.y.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector.z))
					{
						GClass70.smethod_24("V.z.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector.x))
					{
						GClass70.smethod_24("V.x.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector.y))
					{
						GClass70.smethod_24("V.y.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector.z))
					{
						GClass70.smethod_24("V.z.IsNaN", GClass70.Enum1.const_0);
					}
					else
					{
						list.Add(vector.ToString());
					}
				}
				GClass70.smethod_38("2", GClass70.Enum1.const_0);
				list.Add("deltaNormals:");
				foreach (Vector3 vector2 in il2CppStructArray2)
				{
					if (float.IsInfinity(vector2.x))
					{
						GClass70.smethod_24("V.x.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector2.y))
					{
						GClass70.smethod_24("V.y.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector2.z))
					{
						GClass70.smethod_24("V.z.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector2.x))
					{
						GClass70.smethod_24("V.x.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector2.y))
					{
						GClass70.smethod_24("V.y.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector2.z))
					{
						GClass70.smethod_24("V.z.IsNaN", GClass70.Enum1.const_0);
					}
					else
					{
						list.Add(vector2.ToString());
					}
				}
				GClass70.smethod_38("3", GClass70.Enum1.const_0);
				list.Add("deltaTangents:");
				foreach (Vector3 vector3 in il2CppStructArray3)
				{
					if (float.IsInfinity(vector3.x))
					{
						GClass70.smethod_24("V.x.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector3.y))
					{
						GClass70.smethod_24("V.y.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsInfinity(vector3.z))
					{
						GClass70.smethod_24("V.z.IsInfinity", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector3.x))
					{
						GClass70.smethod_24("V.x.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector3.y))
					{
						GClass70.smethod_24("V.y.IsNaN", GClass70.Enum1.const_0);
					}
					else if (float.IsNaN(vector3.z))
					{
						GClass70.smethod_24("V.z.IsNaN", GClass70.Enum1.const_0);
					}
					else
					{
						list.Add(vector3.ToString());
					}
				}
				GClass70.smethod_38("4", GClass70.Enum1.const_0);
				File.WriteAllLines("BlendShapes.log", list);
				GClass70.smethod_38("5", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00067BB8 File Offset: 0x00065DB8
		internal static bool smethod_708(GameObject gameObject_39, Transform transform_0)
		{
			return gameObject_39 && transform_0 && GClass84.smethod_1493(gameObject_39.transform, transform_0);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00067BF0 File Offset: 0x00065DF0
		internal static void smethod_709(APIUser apiuser_0, Action action_0)
		{
			GClass84.smethod_427(apiuser_0, action_0);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00067C04 File Offset: 0x00065E04
		internal static string smethod_710(string string_4, string string_5)
		{
			return GClass84.smethod_1193(string_4, string_5);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00067C18 File Offset: 0x00065E18
		internal static void smethod_711(string string_4)
		{
			GClass84.smethod_976(string_4);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00067C2C File Offset: 0x00065E2C
		internal static int smethod_712(bool bool_10)
		{
			return bool_10 ? 1 : 0;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00067C44 File Offset: 0x00065E44
		internal static List<Transform> smethod_713(List<GameObject> list_51)
		{
			List<Transform> list = new List<Transform>();
			List<Transform> result;
			if (list_51 == null)
			{
				result = list;
			}
			else
			{
				for (int i = 0; i < list_51.Count; i++)
				{
					if (list_51[i])
					{
						list.Add(list_51[i].transform);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00067C98 File Offset: 0x00065E98
		internal static int smethod_714()
		{
			return GClass84.smethod_301(GClass84.smethod_822());
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00067CB4 File Offset: 0x00065EB4
		internal static void smethod_715(VRCPlayer vrcplayer_0, bool bool_10)
		{
			if (vrcplayer_0)
			{
				GClass84.smethod_1318(vrcplayer_0.transform, bool_10);
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00067CD8 File Offset: 0x00065ED8
		internal static void smethod_716(UiVRCList uiVRCList_0, List<ApiAvatar> list_51)
		{
			GClass84.smethod_599(uiVRCList_0, list_51);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00067CEC File Offset: 0x00065EEC
		internal static void smethod_717(UiAvatarList uiAvatarList_0)
		{
			GClass84.smethod_1009(uiAvatarList_0);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00067D00 File Offset: 0x00065F00
		internal static bool smethod_718(Transform transform_0, string string_4)
		{
			bool result;
			if (string_4 == string.Empty)
			{
				result = false;
			}
			else
			{
				if (transform_0)
				{
					VRC_Trigger[] array = transform_0.GetComponents<VRC_Trigger>();
					for (int i = 0; i < array.Length; i++)
					{
						if (GClass84.smethod_844(array[i], string_4))
						{
							return true;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00067D5C File Offset: 0x00065F5C
		internal static void smethod_719(string string_4)
		{
			GClass84.smethod_1402(string_4);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00067D70 File Offset: 0x00065F70
		internal static Color32 smethod_720(Color color_0)
		{
			return new Color32(color_0.R, color_0.G, color_0.B, color_0.A);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00067DA0 File Offset: 0x00065FA0
		internal static void smethod_721()
		{
			GClass84.smethod_1083();
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00067DB4 File Offset: 0x00065FB4
		internal static Texture2D smethod_722()
		{
			int num = 1536;
			Texture2D texture2D = GClass84.smethod_1130(1536, 1);
			Color32[] array = new Color32[1536];
			for (int i = 0; i < num; i++)
			{
				if (i < 256)
				{
					array[i] = new Color32(byte.MaxValue, (byte)i, 0, byte.MaxValue);
				}
				else if (i < 512)
				{
					byte b = (byte)(i - 256);
					array[i] = new Color32(byte.MaxValue - b, byte.MaxValue, 0, byte.MaxValue);
				}
				else if (i < 768)
				{
					byte b2 = (byte)(i - 512);
					array[i] = new Color32(0, byte.MaxValue, b2, byte.MaxValue);
				}
				else if (i < 1024)
				{
					byte b3 = (byte)(i - 768);
					array[i] = new Color32(0, byte.MaxValue - b3, byte.MaxValue, byte.MaxValue);
				}
				else if (i < 1280)
				{
					byte b4 = (byte)(i - 1024);
					array[i] = new Color32(b4, 0, byte.MaxValue, byte.MaxValue);
				}
				else if (i < 1536)
				{
					byte b5 = (byte)(i - 1280);
					array[i] = new Color32(byte.MaxValue, 0, byte.MaxValue - b5, byte.MaxValue);
				}
			}
			texture2D.SetPixels32(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00067F38 File Offset: 0x00066138
		internal static string smethod_723(string string_4)
		{
			return GClass84.smethod_1128(string_4);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00067F4C File Offset: 0x0006614C
		internal static IEnumerator smethod_724()
		{
			return new GClass84.Class125(0);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00067F60 File Offset: 0x00066160
		internal static Transform[] smethod_725(Scene scene_0)
		{
			List<Transform> list = new List<Transform>();
			GameObject[] array = GClass84.smethod_1297(scene_0);
			for (int i = 0; i < array.Length; i++)
			{
				Transform transform = array[i].transform;
				if (transform)
				{
					list.Add(transform);
				}
			}
			return list.ToArray();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006E890 File Offset: 0x0006CA90
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00067FB4 File Offset: 0x000661B4
		internal static VRC_EventHandler VRC_EventHandler_0
		{
			get
			{
				if (!GClass84.vrc_EventHandler_0)
				{
					VRC_EventHandler[] array = Resources.FindObjectsOfTypeAll<VRC_EventHandler>();
					if (array.Length != 0)
					{
						GClass84.vrc_EventHandler_0 = array[0];
					}
				}
				return GClass84.vrc_EventHandler_0;
			}
			set
			{
				GClass84.smethod_431(value);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00067FC8 File Offset: 0x000661C8
		internal static void smethod_726(int int_1)
		{
			GClass84.smethod_678(int_1);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00067FDC File Offset: 0x000661DC
		internal static short smethod_727(Player player_0)
		{
			short result;
			if (!player_0)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_120(GClass84.smethod_478(player_0));
			}
			return result;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00068008 File Offset: 0x00066208
		internal static QuickMenu smethod_728()
		{
			GameObject gameObject = GClass84.smethod_229();
			return (gameObject != null) ? gameObject.GetComponent<QuickMenu>() : null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00068028 File Offset: 0x00066228
		internal static GameObject smethod_729()
		{
			if (!GClass84.gameObject_3)
			{
				GClass84.gameObject_3 = GameObject.Find(GClass84.smethod_1637());
			}
			return GClass84.gameObject_3;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0006805C File Offset: 0x0006625C
		internal static void smethod_730()
		{
			GClass84.smethod_1609(Color.yellow, "Yoinked Avatar Successfully!");
			GClass70.smethod_117(ConsoleColor.DarkYellow, "Successfully Yoinked Avatar!", GClass70.Enum1.const_0);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00068084 File Offset: 0x00066284
		internal static Transform[] smethod_731(GameObject gameObject_39)
		{
			Transform[] result;
			if (!gameObject_39)
			{
				result = new Transform[0];
			}
			else
			{
				result = GClass84.smethod_1141(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000680B4 File Offset: 0x000662B4
		internal static void smethod_732(string string_4, string string_5, out string string_6)
		{
			GClass84.smethod_1285(string_4, string_5, ref string_6);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000680CC File Offset: 0x000662CC
		internal static void smethod_733()
		{
			GClass84.smethod_1433();
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000680E0 File Offset: 0x000662E0
		internal static float smethod_734(float float_3)
		{
			if (float_3 < 5f)
			{
				float_3 = 5f;
			}
			Camera.main.farClipPlane = float_3;
			return float_3;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0006810C File Offset: 0x0006630C
		internal static void smethod_735(SkinnedMeshRenderer skinnedMeshRenderer_0)
		{
			GClass84.smethod_263(skinnedMeshRenderer_0);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00068120 File Offset: 0x00066320
		internal static void smethod_736(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_289(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0006813C File Offset: 0x0006633C
		internal static Transform smethod_737()
		{
			GameObject gameObject = GClass84.smethod_1580();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0006815C File Offset: 0x0006635C
		internal static bool smethod_738(Transform transform_0)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				List<DynamicBone> list = GClass84.smethod_1556(transform_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					DynamicBone dynamicBone = list[i];
					if (dynamicBone)
					{
						if (!dynamicBone.m_Root)
						{
							GClass84.smethod_761(dynamicBone);
							flag = true;
						}
						else
						{
							for (int j = dynamicBone.m_Colliders.Count - 1; j >= 0; j--)
							{
								if (!dynamicBone.m_Colliders[j])
								{
									dynamicBone.m_Colliders.RemoveAt(j);
								}
							}
							for (int k = dynamicBone.m_Exclusions.Count - 1; k >= 0; k--)
							{
								if (!dynamicBone.m_Exclusions[k])
								{
									dynamicBone.m_Exclusions.RemoveAt(k);
								}
							}
							for (int l = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.Count - 1; l >= 0; l--)
							{
								if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[l] == null || !dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[l].field_Public_Transform_0)
								{
									dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.RemoveAt(l);
									for (int m = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0.Count - 1; m >= 0; m--)
									{
										if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m] != null)
										{
											if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 == l)
											{
												dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 = -1;
											}
											else if (dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m].field_Public_Int32_0 > l)
											{
												DynamicBone.ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique objectNPrivateTrInSiVeSiQuVeSiVeSiUnique = dynamicBone.field_Private_List_1_ObjectNPrivateTrInSiVeSiQuVeSiVeSiUnique_0[m];
												int field_Public_Int32_ = objectNPrivateTrInSiVeSiQuVeSiVeSiUnique.field_Public_Int32_0;
												objectNPrivateTrInSiVeSiQuVeSiVeSiUnique.field_Public_Int32_0 = field_Public_Int32_ - 1;
											}
										}
									}
								}
							}
						}
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00068378 File Offset: 0x00066578
		internal static VRCPlayerApi smethod_739()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.field_Private_VRCPlayerApi_0 : null;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00068398 File Offset: 0x00066598
		internal static GameObject smethod_740()
		{
			if (!GClass84.gameObject_10)
			{
				GClass84.gameObject_10 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress");
			}
			return GClass84.gameObject_10;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000683CC File Offset: 0x000665CC
		internal static int smethod_741(int int_1, int int_2)
		{
			int result;
			if (int_1 > int_2)
			{
				result = int_2;
			}
			else
			{
				result = int_1;
			}
			return result;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000683E8 File Offset: 0x000665E8
		internal static bool smethod_742(string string_4, out bool bool_10)
		{
			bool result;
			if (string_4 == "1" || GClass84.smethod_362(string_4) == GClass84.smethod_362("true"))
			{
				bool_10 = true;
				result = true;
			}
			else if (string_4 == "0" || GClass84.smethod_362(string_4) == GClass84.smethod_362("false"))
			{
				bool_10 = false;
				result = true;
			}
			else
			{
				bool_10 = false;
				result = false;
			}
			return result;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00068458 File Offset: 0x00066658
		internal static float smethod_743(Vector3 vector3_0)
		{
			return (float)Math.Sqrt((double)(vector3_0.x * vector3_0.x + vector3_0.y * vector3_0.y + vector3_0.z * vector3_0.z));
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00068498 File Offset: 0x00066698
		internal static GClass84.GStruct169 smethod_744(int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			int num = 0;
			GClass84.GStruct169 gstruct = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int index = 0;
			int index2 = 0;
			int index3 = 0;
			int index4 = 0;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			int_5 = GClass84.smethod_1551(int_5, -360, 360);
			int_5 = GClass84.smethod_108<int>(int_5 < 0, 360 + int_5, int_5);
			int_5 = GClass84.smethod_108<int>(int_5 == 360, 0, int_5);
			float num2 = (float)((int_4 + int_5) % 360);
			float num3 = (float)(int_3 / 2);
			GClass84.GStruct169 result;
			if (int_5 == 0)
			{
				result = GClass84.smethod_124(int_1, int_2, int_3, int_4);
			}
			else if (int_4 <= 0)
			{
				result = gstruct;
			}
			else
			{
				int i = int_3;
				int num4 = 1 - 2 * int_3;
				float num5 = GClass84.smethod_1480((float)int_5);
				float num6 = GClass84.smethod_1480(num2);
				float num7 = (float)Math.Cos(1.5707963267948966 - (double)num5) * (float)int_3;
				float num8 = (float)Math.Sin(1.5707963267948966 - (double)num5) * (float)int_3;
				float num9 = (float)Math.Cos(1.5707963267948966 - (double)num6) * (float)int_3;
				float num10 = (float)Math.Sin(1.5707963267948966 - (double)num6) * (float)int_3;
				float num11 = (float)Math.Cos(7.8539816339744828 - (double)num5) * (float)int_3;
				float num12 = (float)Math.Sin(7.8539816339744828 - (double)num5) * (float)int_3;
				float num13 = (float)Math.Cos(7.8539816339744828 - (double)num6) * (float)int_3;
				float num14 = (float)Math.Sin(7.8539816339744828 - (double)num6) * (float)int_3;
				while (i >= 0)
				{
					if (int_5 <= 360 && int_5 >= 90)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 90f)
							{
								if (!flag)
								{
									index = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value = gstruct.list_1[index];
									value.int_0++;
									gstruct.list_1[index] = value;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value2 = gstruct.list_1[index];
									value2.int_1++;
									gstruct.list_1[index] = value2;
								}
							}
							else if (num2 > 0f && ((num2 <= 45f && (float)num <= num9) || (num2 > 45f && (float)i >= num10)))
							{
								if (!flag)
								{
									index = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value3 = gstruct.list_1[index];
									value3.int_0++;
									gstruct.list_1[index] = value3;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value4 = gstruct.list_1[index];
									value4.int_1++;
									gstruct.list_1[index] = value4;
								}
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 45 || (float)num > num7) && (int_5 <= 45 || (float)i < num8))
						{
							if (!flag)
							{
								index = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value5 = gstruct.list_1[index];
								value5.int_0++;
								gstruct.list_1[index] = value5;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value6 = gstruct.list_1[index];
								value6.int_1++;
								gstruct.list_1[index] = value6;
							}
						}
						if ((num2 > 0f || num2 < 90f) && ((num2 <= 45f && (float)num <= num9) || (num2 > 45f && (float)i >= num10)))
						{
							if (!flag)
							{
								index = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value7 = gstruct.list_1[index];
								value7.int_0++;
								gstruct.list_1[index] = value7;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value8 = gstruct.list_1[index];
								value8.int_1++;
								gstruct.list_1[index] = value8;
							}
						}
					}
					else if (num2 >= 90f)
					{
						if ((int_5 > 45 || (float)num > num7) && (int_5 <= 45 || (float)i < num8))
						{
							if (!flag)
							{
								index = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value9 = gstruct.list_1[index];
								value9.int_0++;
								gstruct.list_1[index] = value9;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value10 = gstruct.list_1[index];
								value10.int_1++;
								gstruct.list_1[index] = value10;
							}
						}
					}
					else if ((int_5 > 45 || (float)num > num7) && (int_5 <= 45 || (float)i < num8) && ((num2 <= 45f && (float)num <= num9) || (num2 > 45f && (float)i >= num10)))
					{
						if (!flag)
						{
							index = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 - i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value11 = gstruct.list_1[index];
							value11.int_0++;
							gstruct.list_1[index] = value11;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value12 = gstruct.list_1[index];
							value12.int_1++;
							gstruct.list_1[index] = value12;
						}
					}
					if (int_5 <= 90)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 90f)
							{
								if (num2 >= 180f)
								{
									if (!flag)
									{
										index2 = gstruct.list_0.Count;
										gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
									}
									else if (flag2)
									{
										GClass84.GStruct163 value13 = gstruct.list_1[index2];
										value13.int_0++;
										gstruct.list_1[index2] = value13;
									}
									else if (flag3)
									{
										GClass84.GStruct163 value14 = gstruct.list_0[index2];
										value14.int_1--;
										gstruct.list_0[index2] = value14;
										value14 = gstruct.list_1[index2];
										value14.int_1++;
										gstruct.list_1[index2] = value14;
									}
								}
								else if ((num2 <= 135f && (float)i <= -num14) || (num2 > 135f && (float)num >= num13))
								{
									if (!flag)
									{
										index2 = gstruct.list_0.Count;
										gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
									}
									else if (flag2)
									{
										GClass84.GStruct163 value15 = gstruct.list_1[index2];
										value15.int_0++;
										gstruct.list_1[index2] = value15;
									}
									else if (flag3)
									{
										GClass84.GStruct163 value16 = gstruct.list_0[index2];
										value16.int_1--;
										gstruct.list_0[index2] = value16;
										value16 = gstruct.list_1[index2];
										value16.int_1++;
										gstruct.list_1[index2] = value16;
									}
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value17 = gstruct.list_1[index2];
								value17.int_0++;
								gstruct.list_1[index2] = value17;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value18 = gstruct.list_0[index2];
								value18.int_1--;
								gstruct.list_0[index2] = value18;
								value18 = gstruct.list_1[index2];
								value18.int_1++;
								gstruct.list_1[index2] = value18;
							}
						}
					}
					else if (int_5 <= 360 && int_5 >= 180)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 180f)
							{
								if (!flag)
								{
									index2 = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value19 = gstruct.list_1[index2];
									value19.int_0++;
									gstruct.list_1[index2] = value19;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value20 = gstruct.list_0[index2];
									value20.int_1--;
									gstruct.list_0[index2] = value20;
									value20 = gstruct.list_1[index2];
									value20.int_1++;
									gstruct.list_1[index2] = value20;
								}
							}
							else if (num2 > 90f && ((num2 <= 135f && (float)i <= -num14) || (num2 > 135f && (float)num >= num13)))
							{
								if (!flag)
								{
									index2 = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value21 = gstruct.list_1[index2];
									value21.int_0++;
									gstruct.list_1[index2] = value21;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value22 = gstruct.list_0[index2];
									value22.int_1--;
									gstruct.list_0[index2] = value22;
									value22 = gstruct.list_1[index2];
									value22.int_1++;
									gstruct.list_1[index2] = value22;
								}
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 135 || (float)i > -num12) && (int_5 <= 135 || (float)num < num11))
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value23 = gstruct.list_1[index2];
								value23.int_0++;
								gstruct.list_1[index2] = value23;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value24 = gstruct.list_0[index2];
								value24.int_1--;
								gstruct.list_0[index2] = value24;
								value24 = gstruct.list_1[index2];
								value24.int_1++;
								gstruct.list_1[index2] = value24;
							}
						}
						if ((num2 > 90f || num2 < 180f) && ((num2 <= 135f && (float)i <= -num14) || (num2 > 135f && (float)num >= num13)))
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value25 = gstruct.list_1[index2];
								value25.int_0++;
								gstruct.list_1[index2] = value25;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value26 = gstruct.list_0[index2];
								value26.int_1--;
								gstruct.list_0[index2] = value26;
								value26 = gstruct.list_1[index2];
								value26.int_1++;
								gstruct.list_1[index2] = value26;
							}
						}
					}
					else if (num2 >= 180f)
					{
						if ((int_5 > 135 || (float)i > -num12) && (int_5 <= 135 || (float)num < num11))
						{
							if (!flag)
							{
								index2 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value27 = gstruct.list_1[index2];
								value27.int_0++;
								gstruct.list_1[index2] = value27;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value28 = gstruct.list_0[index2];
								value28.int_1--;
								gstruct.list_0[index2] = value28;
								value28 = gstruct.list_1[index2];
								value28.int_1++;
								gstruct.list_1[index2] = value28;
							}
						}
					}
					else if ((int_5 > 135 || (float)i > -num12) && (int_5 <= 135 || (float)num < num11) && ((num2 <= 135f && (float)i <= -num14) || (num2 > 135f && (float)num >= num13)))
					{
						if (!flag)
						{
							index2 = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 + num, int_2 + i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value29 = gstruct.list_1[index2];
							value29.int_0++;
							gstruct.list_1[index2] = value29;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value30 = gstruct.list_0[index2];
							value30.int_1--;
							gstruct.list_0[index2] = value30;
							value30 = gstruct.list_1[index2];
							value30.int_1++;
							gstruct.list_1[index2] = value30;
						}
					}
					if (int_5 <= 180)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 180f)
							{
								if (num2 >= 270f)
								{
									if (!flag)
									{
										index3 = gstruct.list_0.Count;
										gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
									}
									else if (flag2)
									{
										GClass84.GStruct163 value31 = gstruct.list_0[index3];
										value31.int_0--;
										gstruct.list_0[index3] = value31;
										value31 = gstruct.list_1[index3];
										value31.int_0++;
										gstruct.list_1[index3] = value31;
									}
									else if (flag3)
									{
										GClass84.GStruct163 value32 = gstruct.list_0[index3];
										value32.int_1--;
										gstruct.list_0[index3] = value32;
										value32 = gstruct.list_1[index3];
										value32.int_1++;
										gstruct.list_1[index3] = value32;
									}
								}
								else if ((num2 <= 225f && (float)num <= -num13) || (num2 > 225f && (float)i >= -num14))
								{
									if (!flag)
									{
										index3 = gstruct.list_0.Count;
										gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
									}
									else if (flag2)
									{
										GClass84.GStruct163 value33 = gstruct.list_0[index3];
										value33.int_0--;
										gstruct.list_0[index3] = value33;
										value33 = gstruct.list_1[index3];
										value33.int_0++;
										gstruct.list_1[index3] = value33;
									}
									else if (flag3)
									{
										GClass84.GStruct163 value34 = gstruct.list_0[index3];
										value34.int_1--;
										gstruct.list_0[index3] = value34;
										value34 = gstruct.list_1[index3];
										value34.int_1++;
										gstruct.list_1[index3] = value34;
									}
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value35 = gstruct.list_0[index3];
								value35.int_0--;
								gstruct.list_0[index3] = value35;
								value35 = gstruct.list_1[index3];
								value35.int_0++;
								gstruct.list_1[index3] = value35;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value36 = gstruct.list_0[index3];
								value36.int_1--;
								gstruct.list_0[index3] = value36;
								value36 = gstruct.list_1[index3];
								value36.int_1++;
								gstruct.list_1[index3] = value36;
							}
						}
					}
					else if (int_5 <= 360 && int_5 >= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 270f)
							{
								if (!flag)
								{
									index3 = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value37 = gstruct.list_0[index3];
									value37.int_0--;
									gstruct.list_0[index3] = value37;
									value37 = gstruct.list_1[index3];
									value37.int_0++;
									gstruct.list_1[index3] = value37;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value38 = gstruct.list_0[index3];
									value38.int_1--;
									gstruct.list_0[index3] = value38;
									value38 = gstruct.list_1[index3];
									value38.int_1++;
									gstruct.list_1[index3] = value38;
								}
							}
							else if (num2 > 180f && ((num2 <= 225f && (float)num <= -num13) || (num2 > 225f && (float)i >= -num14)))
							{
								if (!flag)
								{
									index3 = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value39 = gstruct.list_0[index3];
									value39.int_0--;
									gstruct.list_0[index3] = value39;
									value39 = gstruct.list_1[index3];
									value39.int_0++;
									gstruct.list_1[index3] = value39;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value40 = gstruct.list_0[index3];
									value40.int_1--;
									gstruct.list_0[index3] = value40;
									value40 = gstruct.list_1[index3];
									value40.int_1++;
									gstruct.list_1[index3] = value40;
								}
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 225 || (float)num > -num11) && (int_5 <= 225 || (float)i < -num12))
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value41 = gstruct.list_0[index3];
								value41.int_0--;
								gstruct.list_0[index3] = value41;
								value41 = gstruct.list_1[index3];
								value41.int_0++;
								gstruct.list_1[index3] = value41;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value42 = gstruct.list_0[index3];
								value42.int_1--;
								gstruct.list_0[index3] = value42;
								value42 = gstruct.list_1[index3];
								value42.int_1++;
								gstruct.list_1[index3] = value42;
							}
						}
						if ((num2 > 180f || num2 < 270f) && ((num2 <= 225f && (float)num <= -num13) || (num2 > 225f && (float)i >= -num14)))
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value43 = gstruct.list_0[index3];
								value43.int_0--;
								gstruct.list_0[index3] = value43;
								value43 = gstruct.list_1[index3];
								value43.int_0++;
								gstruct.list_1[index3] = value43;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value44 = gstruct.list_0[index3];
								value44.int_1--;
								gstruct.list_0[index3] = value44;
								value44 = gstruct.list_1[index3];
								value44.int_1++;
								gstruct.list_1[index3] = value44;
							}
						}
					}
					else if (num2 >= 270f)
					{
						if ((int_5 > 225 || (float)num > -num11) && (int_5 <= 225 || (float)i < -num12))
						{
							if (!flag)
							{
								index3 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value45 = gstruct.list_0[index3];
								value45.int_0--;
								gstruct.list_0[index3] = value45;
								value45 = gstruct.list_1[index3];
								value45.int_0++;
								gstruct.list_1[index3] = value45;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value46 = gstruct.list_0[index3];
								value46.int_1--;
								gstruct.list_0[index3] = value46;
								value46 = gstruct.list_1[index3];
								value46.int_1++;
								gstruct.list_1[index3] = value46;
							}
						}
					}
					else if ((int_5 > 225 || (float)num > -num11) && (int_5 <= 225 || (float)i < -num12) && ((num2 <= 225f && (float)num <= -num13) || (num2 > 225f && (float)i >= -num14)))
					{
						if (!flag)
						{
							index3 = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 + i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value47 = gstruct.list_0[index3];
							value47.int_0--;
							gstruct.list_0[index3] = value47;
							value47 = gstruct.list_1[index3];
							value47.int_0++;
							gstruct.list_1[index3] = value47;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value48 = gstruct.list_0[index3];
							value48.int_1--;
							gstruct.list_0[index3] = value48;
							value48 = gstruct.list_1[index3];
							value48.int_1++;
							gstruct.list_1[index3] = value48;
						}
					}
					if (int_5 <= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 0f && num2 < 270f)
							{
								if (!flag)
								{
									index4 = gstruct.list_0.Count;
									gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
								}
								else if (flag2)
								{
									GClass84.GStruct163 value49 = gstruct.list_0[index4];
									value49.int_0--;
									gstruct.list_0[index4] = value49;
									value49 = gstruct.list_1[index4];
									value49.int_0++;
									gstruct.list_1[index4] = value49;
								}
								else if (flag3)
								{
									GClass84.GStruct163 value50 = gstruct.list_1[index4];
									value50.int_1++;
									gstruct.list_1[index4] = value50;
								}
							}
						}
						else if (num2 > 270f && ((num2 <= 315f && (float)i <= num14) || (num2 > 315f && (float)num >= -num13)))
						{
							if (!flag)
							{
								index4 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value51 = gstruct.list_0[index4];
								value51.int_0--;
								gstruct.list_0[index4] = value51;
								value51 = gstruct.list_1[index4];
								value51.int_0++;
								gstruct.list_1[index4] = value51;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value52 = gstruct.list_1[index4];
								value52.int_1++;
								gstruct.list_1[index4] = value52;
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 315 || (float)i > num12) && (int_5 <= 315 || (float)num < -num11))
						{
							if (!flag)
							{
								index4 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value53 = gstruct.list_0[index4];
								value53.int_0--;
								gstruct.list_0[index4] = value53;
								value53 = gstruct.list_1[index4];
								value53.int_0++;
								gstruct.list_1[index4] = value53;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value54 = gstruct.list_1[index4];
								value54.int_1++;
								gstruct.list_1[index4] = value54;
							}
						}
						if (num2 > 270f && num2 < 360f && ((num2 <= 315f && (float)i <= num14) || (num2 > 315f && (float)num >= -num13)))
						{
							if (!flag)
							{
								index4 = gstruct.list_0.Count;
								gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
							}
							else if (flag2)
							{
								GClass84.GStruct163 value55 = gstruct.list_0[index4];
								value55.int_0--;
								gstruct.list_0[index4] = value55;
								value55 = gstruct.list_1[index4];
								value55.int_0++;
								gstruct.list_1[index4] = value55;
							}
							else if (flag3)
							{
								GClass84.GStruct163 value56 = gstruct.list_1[index4];
								value56.int_1++;
								gstruct.list_1[index4] = value56;
							}
						}
					}
					else if ((int_5 > 315 || (float)i > num12) && (int_5 <= 315 || (float)num < -num11) && ((num2 <= 315f && (float)i <= num14) || (num2 > 315f && (float)num >= -num13)))
					{
						if (!flag)
						{
							index4 = gstruct.list_0.Count;
							gstruct.method_0(new GClass84.GStruct163(int_1 - num, int_2 - i), new GClass84.GStruct163(1, 1));
						}
						else if (flag2)
						{
							GClass84.GStruct163 value57 = gstruct.list_0[index4];
							value57.int_0--;
							gstruct.list_0[index4] = value57;
							value57 = gstruct.list_1[index4];
							value57.int_0++;
							gstruct.list_1[index4] = value57;
						}
						else if (flag3)
						{
							GClass84.GStruct163 value58 = gstruct.list_1[index4];
							value58.int_1++;
							gstruct.list_1[index4] = value58;
						}
					}
					int num15 = 2 * (num4 + i) - 1;
					flag = false;
					if (num4 < 0 && num15 <= 0)
					{
						num4 += 2 * ++num + 1;
						if (flag2 || (float)num <= num3)
						{
							flag = true;
							flag2 = true;
						}
					}
					else
					{
						if (flag2)
						{
							flag2 = false;
						}
						if (num4 > 0 && num15 > 0)
						{
							num4 -= 2 * --i + 1;
							if (flag3 || (float)num >= num3)
							{
								flag = true;
								flag3 = true;
							}
						}
						else
						{
							if (flag3)
							{
								flag3 = false;
							}
							num4 += 2 * (++num - i--);
						}
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0006A3F4 File Offset: 0x000685F4
		internal static APIUser smethod_745(string string_4)
		{
			return GClass84.smethod_518(GClass84.smethod_554(string_4));
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0006A410 File Offset: 0x00068610
		internal static Color smethod_746(string string_4, bool bool_10 = false)
		{
			byte b = 0;
			byte b2 = 0;
			byte b3 = 0;
			byte b4 = 0;
			Color result;
			result..ctor(0f, 0f, 0f, 0f);
			if (GClass84.smethod_1428(string_4, 1) == "#")
			{
				string_4 = GClass84.smethod_1204(string_4, 1, -1);
			}
			byte b5;
			if (bool_10)
			{
				if (GClass84.smethod_593(string_4) != 8)
				{
					return result;
				}
				b5 = 8;
			}
			else
			{
				if (GClass84.smethod_593(string_4) != 6)
				{
					return result;
				}
				b5 = 6;
			}
			for (int i = 1; i < (int)(b5 + 1); i++)
			{
				bool flag = false;
				bool flag2 = (i + 1) % 2 == 0;
				byte b6 = 0;
				for (byte b7 = 0; b7 < 10; b7 += 1)
				{
					if (!flag && GClass84.smethod_1428(string_4, 1) == b7.ToString())
					{
						b6 = b7;
						flag = true;
					}
				}
				if (!flag)
				{
					if (GClass84.smethod_1428(string_4, 1) == "a")
					{
						b6 = 10;
					}
					else if (GClass84.smethod_1428(string_4, 1) == "b")
					{
						b6 = 11;
					}
					else if (GClass84.smethod_1428(string_4, 1) == "c")
					{
						b6 = 12;
					}
					else if (GClass84.smethod_1428(string_4, 1) == "d")
					{
						b6 = 13;
					}
					else if (GClass84.smethod_1428(string_4, 1) == "e")
					{
						b6 = 14;
					}
					else if (GClass84.smethod_1428(string_4, 1) == "f")
					{
						b6 = 15;
					}
				}
				if (flag2)
				{
					b6 *= 16;
				}
				if (bool_10)
				{
					if (GClass84.smethod_593(string_4) > 6)
					{
						b += b6;
					}
					else if (GClass84.smethod_593(string_4) > 4)
					{
						b2 += b6;
					}
					else if (GClass84.smethod_593(string_4) > 2)
					{
						b3 += b6;
					}
					else
					{
						b4 += b6;
					}
				}
				else if (GClass84.smethod_593(string_4) > 4)
				{
					b += b6;
				}
				else if (GClass84.smethod_593(string_4) > 2)
				{
					b2 += b6;
				}
				else
				{
					b3 += b6;
				}
				string_4 = GClass84.smethod_1204(string_4, 1, -1);
			}
			result.r = (float)b;
			result.g = (float)b2;
			result.b = (float)b3;
			if (bool_10)
			{
				result.a = (float)b4;
			}
			else
			{
				result.a = 1f;
			}
			return result;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0006A658 File Offset: 0x00068858
		internal static int smethod_747(GameObject gameObject_39)
		{
			int result;
			if (!gameObject_39)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_1495(gameObject_39.transform).Count;
			}
			return result;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0006A688 File Offset: 0x00068888
		internal static int smethod_748(Player player_0)
		{
			int result;
			if (!player_0)
			{
				result = -1;
			}
			else
			{
				result = GClass84.smethod_1568(GClass84.smethod_28(player_0));
			}
			return result;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0006A6B4 File Offset: 0x000688B4
		internal static int smethod_749()
		{
			return DateTime.Now.Second;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0006A6D0 File Offset: 0x000688D0
		internal static List<T> smethod_750<T>(T[] gparam_0, IEqualityComparer<T> iequalityComparer_0)
		{
			List<T> result;
			if (gparam_0 == null || gparam_0.Length == 0)
			{
				result = null;
			}
			else
			{
				result = gparam_0.Distinct(iequalityComparer_0).ToList<T>();
			}
			return result;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0006A6FC File Offset: 0x000688FC
		internal static void smethod_751()
		{
			GClass84.smethod_1694();
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0006A710 File Offset: 0x00068910
		internal static bool smethod_752(VRCPlayerApi vrcplayerApi_0)
		{
			return vrcplayerApi_0 != null && GClass84.smethod_1511(GClass84.smethod_958(vrcplayerApi_0));
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0006A734 File Offset: 0x00068934
		internal static bool smethod_753(Player player_0)
		{
			return player_0 && GClass84.smethod_764(GClass84.smethod_28(player_0));
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0006A760 File Offset: 0x00068960
		internal static void smethod_754()
		{
			GClass84.smethod_1432();
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0006A774 File Offset: 0x00068974
		internal static Transform smethod_755(GameObject gameObject_39, string string_4)
		{
			Transform result;
			if (!gameObject_39 || string.IsNullOrEmpty(string_4))
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1606(gameObject_39.transform, string_4);
			}
			return result;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0006A7A8 File Offset: 0x000689A8
		internal static void smethod_756(string string_4)
		{
			GClass84.smethod_864(string_4);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0006A7BC File Offset: 0x000689BC
		internal static string smethod_757(string string_4)
		{
			return GClass84.smethod_1442(string_4);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0006A7D0 File Offset: 0x000689D0
		internal static string smethod_758(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_8, int_1);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0006A7EC File Offset: 0x000689EC
		internal static void smethod_759(string string_4)
		{
			GClass84.smethod_756(string_4);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0006A800 File Offset: 0x00068A00
		internal static Transform smethod_760(VRCPlayerApi vrcplayerApi_0)
		{
			Transform result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_276(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0006A824 File Offset: 0x00068A24
		internal static void smethod_761(Component component_0)
		{
			GClass84.smethod_959(component_0);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0006A838 File Offset: 0x00068A38
		internal static void smethod_762()
		{
			GClass84.smethod_129();
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0006A84C File Offset: 0x00068A4C
		internal static bool smethod_763(VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0 && GClass84.smethod_1045(GClass84.smethod_384(vrcplayer_0));
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0006A878 File Offset: 0x00068A78
		internal static bool smethod_764(VRCPlayerApi vrcplayerApi_0)
		{
			return vrcplayerApi_0 != null && vrcplayerApi_0.isMaster;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0006A898 File Offset: 0x00068A98
		internal static void smethod_765(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_333(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0006A8B4 File Offset: 0x00068AB4
		internal static string smethod_766(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_1089(vrcplayer_0);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0006A8C8 File Offset: 0x00068AC8
		internal static void smethod_767(APIUser apiuser_0)
		{
			GClass84.smethod_665(apiuser_0);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0006A8DC File Offset: 0x00068ADC
		internal static List<GClass84.GStruct163> smethod_768(int int_1, int int_2, int int_3, int int_4)
		{
			int num = 0;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			List<GClass84.GStruct163> result;
			if (int_4 <= 0)
			{
				result = list;
			}
			else
			{
				int i = int_3;
				int num6 = 1 - 2 * int_3;
				float num7 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num7) * (float)int_3;
					num5 = (float)Math.Cos(1.5707963267948966 - (double)num7) * (float)int_3;
				}
				if (int_4 > 90 && int_4 < 360)
				{
					num2 = (float)Math.Sin(7.8539816339744828 - (double)num7) * (float)int_3;
					num3 = (float)Math.Cos(7.8539816339744828 - (double)num7) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
					}
					else if ((int_4 <= 45 && (float)num <= num5) || (int_4 > 45 && (float)i >= num4))
					{
						list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
						else if ((int_4 <= 135 && (float)i <= -num2) || (int_4 > 135 && (float)num >= num3))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
						else if ((int_4 <= 225 && (float)num <= -num3) || (int_4 > 225 && (float)i >= -num2))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
						}
						else if ((int_4 <= 315 && (float)i <= num2) || (int_4 > 315 && (float)num >= -num3))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
						}
					}
					int num8 = 2 * (num6 + i) - 1;
					if (num6 < 0 && num8 <= 0)
					{
						num6 += 2 * ++num + 1;
					}
					else if (num6 > 0 && num8 > 0)
					{
						num6 -= 2 * --i + 1;
					}
					else
					{
						num6 += 2 * (++num - i--);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		internal static string smethod_769()
		{
			return GClass84.smethod_1064();
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0006ABC8 File Offset: 0x00068DC8
		internal static Texture2D smethod_770(Texture2D texture2D_0, Texture2D texture2D_1, bool bool_10 = false, bool bool_11 = false)
		{
			int width = texture2D_0.width;
			int height = texture2D_0.height;
			int width2 = texture2D_1.width;
			int height2 = texture2D_1.height;
			int num = GClass84.smethod_1690(width, width2);
			int num2 = GClass84.smethod_1690(height, height2);
			bool flag = false;
			if (width != num || height != num2)
			{
				texture2D_0 = GClass84.smethod_1516(texture2D_0, num, num2);
			}
			if (width2 != num || height2 != num2)
			{
				texture2D_1 = GClass84.smethod_1516(texture2D_1, num, num2);
				flag = true;
			}
			Color32[] array = texture2D_0.GetPixels32();
			Color32[] array2 = texture2D_1.GetPixels32();
			int num3 = array.Length;
			for (int i = 0; i < num3; i++)
			{
				if (bool_11)
				{
					if (array2[i].a == 0)
					{
						array[i].a = 0;
					}
					else
					{
						array[i].a = byte.MaxValue;
					}
				}
				else
				{
					array[i].a = array2[i].a;
				}
			}
			texture2D_0.SetPixels32(array);
			texture2D_0.Apply();
			if (bool_10 && (width != num || height != num2))
			{
				Texture2D texture2D = texture2D_0;
				texture2D_0 = GClass84.smethod_1516(texture2D_0, width, height);
				Object.DestroyImmediate(texture2D, true);
			}
			if (flag)
			{
				Object.DestroyImmediate(texture2D_1, true);
			}
			return texture2D_0;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0006AD20 File Offset: 0x00068F20
		internal static string smethod_771(char[] char_1, int int_1)
		{
			string text = string.Empty;
			for (int i = 0; i < int_1; i++)
			{
				text += char_1[GClass84.smethod_1673(char_1.Length)].ToString();
			}
			return text;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006AD60 File Offset: 0x00068F60
		internal static VRCPlayerApi smethod_772()
		{
			return GClass84.smethod_28(GClass84.smethod_126());
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0006AD7C File Offset: 0x00068F7C
		internal static void smethod_773(ref string string_4, string string_5, string string_6)
		{
			string_4 = GClass84.smethod_108<string>(string.IsNullOrEmpty(string_4), string_5, string_4 + string_6 + string_5);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0006ADA4 File Offset: 0x00068FA4
		internal static GameObject smethod_774(GClass156 gclass156_1, float float_3, float float_4)
		{
			return gclass156_1.method_5(float_3, float_4, GClass156.Enum10.const_1);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0006ADBC File Offset: 0x00068FBC
		internal static void smethod_775()
		{
			for (int i = GClass84.list_48.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_48[i]);
			}
			GClass84.list_48.Clear();
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0006AE00 File Offset: 0x00069000
		internal static Transform smethod_776()
		{
			GameObject gameObject = GClass84.smethod_1500();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0006AE20 File Offset: 0x00069020
		internal static void smethod_777(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_1485(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0006AE40 File Offset: 0x00069040
		internal static string smethod_778()
		{
			return GClass84.smethod_1469();
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0006AE54 File Offset: 0x00069054
		internal static void smethod_779()
		{
			GClass84.list_42.Add(MelonCoroutines.Start(GClass84.smethod_283()));
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0006AE78 File Offset: 0x00069078
		internal static void smethod_780(Player player_0)
		{
			if (GClass84.methodInfo_2 == null)
			{
				GClass84.methodInfo_2 = typeof(UserSelectionManager).GetMethods().First(new Func<MethodInfo, bool>(GClass84.Class101.class101_0.method_14));
			}
			if (GClass84.methodInfo_2 == null)
			{
				GClass70.smethod_36("Can't find select player method!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.methodInfo_2.Invoke(UserSelectionManager.Method_Public_Static_get_UserSelectionManager_PDM_0(), new object[]
				{
					GClass84.smethod_518(player_0)
				});
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0006AF04 File Offset: 0x00069104
		internal static string smethod_781()
		{
			return ApiCredentials.authToken;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0006AF18 File Offset: 0x00069118
		internal static APIUser smethod_782(PlayerNet playerNet_0)
		{
			return GClass84.smethod_518(GClass84.smethod_440(playerNet_0));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0006AF34 File Offset: 0x00069134
		internal static void smethod_783(Player player_0)
		{
			GClass84.smethod_1016(player_0);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0006AF48 File Offset: 0x00069148
		internal static GameObject smethod_784(GClass156 gclass156_1, float float_3, float float_4, int int_1, int int_2)
		{
			return gclass156_1.method_45(float_3, float_4, int_1, int_2);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0006AF64 File Offset: 0x00069164
		internal static bool smethod_785(Transform transform_0)
		{
			return transform_0 && GClass84.smethod_994(transform_0.gameObject);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0006AF90 File Offset: 0x00069190
		internal static void smethod_786(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, 0);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0006AFC0 File Offset: 0x000691C0
		internal static int smethod_787()
		{
			return GClass84.list_47.Count;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0006AFDC File Offset: 0x000691DC
		internal static void smethod_788(ApiWorld apiWorld_0)
		{
			GClass84.smethod_680(apiWorld_0);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0006AFF0 File Offset: 0x000691F0
		internal static void smethod_789()
		{
			GClass84.smethod_1211(GClass84.smethod_1372());
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0006B008 File Offset: 0x00069208
		internal static float smethod_790()
		{
			GClass84.smethod_883();
			return (float)Random.Range(0, 1000000000) / 1E+09f;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0006B030 File Offset: 0x00069230
		internal static void smethod_791(VRC_SpatialAudioSource vrc_SpatialAudioSource_0)
		{
			GClass84.smethod_1473(vrc_SpatialAudioSource_0);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0006B044 File Offset: 0x00069244
		internal static Transform smethod_792()
		{
			GameObject gameObject = GClass84.smethod_882();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0006B064 File Offset: 0x00069264
		internal static bool smethod_793(Quaternion quaternion_0)
		{
			return float.IsNaN(quaternion_0.x) || float.IsNaN(quaternion_0.y) || float.IsNaN(quaternion_0.z) || float.IsNaN(quaternion_0.w);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0006B0A8 File Offset: 0x000692A8
		internal static bool smethod_794(UdonBehaviour udonBehaviour_0, string string_4, VRCPlayerApi vrcplayerApi_0, bool bool_10 = false)
		{
			bool result;
			if (!udonBehaviour_0)
			{
				result = false;
			}
			else if (vrcplayerApi_0 == null)
			{
				GClass70.smethod_38("Target is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				if (!bool_10 && string_4.StartsWith("_"))
				{
					GClass70.smethod_38("Events starting with _ are non-targetable.", GClass70.Enum1.const_0);
				}
				try
				{
					GClass84.smethod_191(vrcplayerApi_0, udonBehaviour_0.gameObject);
				}
				catch
				{
					return false;
				}
				udonBehaviour_0.SendCustomNetworkEvent(1, string_4);
				result = true;
			}
			return result;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0006B128 File Offset: 0x00069328
		internal static bool smethod_795(string string_4, MethodBase methodBase_0, MethodInfo methodInfo_5)
		{
			bool result;
			try
			{
				result = Class203.smethod_1(string_4, methodBase_0, methodInfo_5);
			}
			catch (Exception ex)
			{
				string text = "Null";
				string text2 = "Null";
				if (methodBase_0 != null)
				{
					text = methodBase_0.Name;
				}
				if (methodInfo_5 != null)
				{
					text2 = methodInfo_5.Name;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Patching",
					" (",
					string_4,
					", ",
					text,
					", ",
					text2,
					"): ",
					ex.Message
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0006B200 File Offset: 0x00069400
		internal static bool smethod_796(Transform transform_0, bool bool_10 = true)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
				if (GClass84.smethod_1686(transform_0, bool_10) != vrcplayerApi)
				{
					GClass84.smethod_785(transform_0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0006B23C File Offset: 0x0006943C
		internal static void smethod_797(string string_4)
		{
			GClass84.smethod_1305(string_4);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0006B250 File Offset: 0x00069450
		internal static string smethod_798()
		{
			return "UserInterface/MenuContent/Screens";
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0006B264 File Offset: 0x00069464
		internal static bool smethod_799(Type type_0, string string_4, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_1302("Abyss Client_1.0.0", type_0, string_4, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0006B284 File Offset: 0x00069484
		internal static VRCPlayer smethod_800(PlayerNet playerNet_0)
		{
			return (playerNet_0 != null) ? playerNet_0._vrcPlayer : null;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0006B2A0 File Offset: 0x000694A0
		internal static string smethod_801(byte[] byte_0, bool bool_10 = false)
		{
			return GClass84.smethod_956(byte_0, bool_10);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0006B2B4 File Offset: 0x000694B4
		internal static float smethod_802(float float_3, float float_4, float float_5)
		{
			return float_4 + (float_5 - float_4) * float_3;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0006B2CC File Offset: 0x000694CC
		internal static bool smethod_803(GameObject gameObject_39, string string_4)
		{
			return gameObject_39 && GClass84.smethod_718(gameObject_39.transform, string_4);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_804(MeshRenderer meshRenderer_0)
		{
			if (meshRenderer_0)
			{
				Object.DestroyImmediate(meshRenderer_0, true);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0006B2F8 File Offset: 0x000694F8
		internal static List<Transform> smethod_805(Transform transform_0, List<Transform> list_51)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				if (list_51 == null || list_51.Count == 0)
				{
					GClass84.smethod_1495(transform_0);
				}
				List<Transform> list = new List<Transform>();
				int i = 0;
				IL_93:
				while (i < transform_0.childCount)
				{
					Transform child = transform_0.GetChild(i);
					bool flag = false;
					for (int j = 0; j < list_51.Count; j++)
					{
						if (list_51[j] == child)
						{
							flag = true;
							IL_73:
							if (!flag)
							{
								list.Add(child);
								list.AddRange(GClass84.smethod_805(child, list_51));
							}
							i++;
							goto IL_93;
						}
					}
					goto IL_73;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0006B3A8 File Offset: 0x000695A8
		internal static void smethod_806()
		{
			GClass84.smethod_632();
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0006B3BC File Offset: 0x000695BC
		internal static GameObject smethod_807()
		{
			return GameObject.Find(GClass84.smethod_349());
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0006B3D8 File Offset: 0x000695D8
		internal static Color smethod_808(Color color_0, float float_3)
		{
			float_3 %= 360f;
			Color result;
			if (GClass84.smethod_15(color_0) || float_3 == 0f)
			{
				result = color_0;
			}
			else
			{
				if (float_3 < 120f)
				{
					float float_4 = float_3 / 120f;
					color_0..ctor(GClass84.smethod_802(color_0.r, color_0.g, float_4), GClass84.smethod_802(color_0.g, color_0.b, float_4), GClass84.smethod_802(color_0.b, color_0.r, float_4), color_0.a);
				}
				else if (float_3 == 120f)
				{
					color_0..ctor(color_0.g, color_0.b, color_0.r, color_0.a);
				}
				else if (float_3 < 240f)
				{
					float float_5 = (float_3 - 120f) / 120f;
					color_0..ctor(GClass84.smethod_802(color_0.g, color_0.b, float_5), GClass84.smethod_802(color_0.b, color_0.r, float_5), GClass84.smethod_802(color_0.r, color_0.g, float_5), color_0.a);
				}
				else if (float_3 == 240f)
				{
					color_0..ctor(color_0.b, color_0.r, color_0.g, color_0.a);
				}
				else if (float_3 < 360f)
				{
					float float_6 = (float_3 - 240f) / 120f;
					color_0..ctor(GClass84.smethod_802(color_0.b, color_0.r, float_6), GClass84.smethod_802(color_0.r, color_0.g, float_6), GClass84.smethod_802(color_0.g, color_0.b, float_6), color_0.a);
				}
				result = color_0;
			}
			return result;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0006B584 File Offset: 0x00069784
		internal static SpawnManager smethod_809()
		{
			GameObject gameObject = GClass84.smethod_1225();
			return (gameObject != null) ? gameObject.GetComponent<SpawnManager>() : null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0006B5A4 File Offset: 0x000697A4
		internal static void smethod_810()
		{
			GClass84.smethod_1383();
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0006B5B8 File Offset: 0x000697B8
		internal static void smethod_811(PortalInternal portalInternal_0, float float_3)
		{
			GClass84.smethod_1023(portalInternal_0, float_3);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0006B5CC File Offset: 0x000697CC
		internal static void smethod_812(Renderer renderer_0)
		{
			GClass84.smethod_261(renderer_0);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0006B5E0 File Offset: 0x000697E0
		internal static ApiWorldInstance smethod_813()
		{
			return RoomManager.field_Internal_Static_ApiWorldInstance_0;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0006B5F4 File Offset: 0x000697F4
		internal static GameObject smethod_814()
		{
			if (!GClass84.gameObject_20)
			{
				GClass84.gameObject_20 = GameObject.Find("/VRC_OBJECTS");
			}
			return GClass84.gameObject_20;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0006B628 File Offset: 0x00069828
		internal static string smethod_815(string string_4)
		{
			return GClass84.smethod_1397(string_4);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0006B63C File Offset: 0x0006983C
		internal static bool smethod_816(string string_4)
		{
			return !string.IsNullOrEmpty(string_4) && (GClass84.smethod_593(string_4) == GClass84.smethod_593("**********") || (GClass84.smethod_593(string_4) == GClass84.smethod_593("usr_********-****-****-****-************") && GClass84.smethod_1428(string_4, GClass84.smethod_593("usr_")) == "usr_"));
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0006B698 File Offset: 0x00069898
		internal static void smethod_817(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_98(vrcplayerApi_0);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0006B6AC File Offset: 0x000698AC
		internal static void smethod_818()
		{
			GClass84.smethod_842();
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0006B6C0 File Offset: 0x000698C0
		internal static void smethod_819(GameObject gameObject_39, Color color_0)
		{
			if (gameObject_39)
			{
				if (!GClass84.material_0)
				{
					GClass84.smethod_810();
					if (!GClass84.material_0)
					{
						GClass70.smethod_36("LineMaterial is null!", GClass70.Enum1.const_0);
						return;
					}
				}
				GameObject gameObject = GameObject.Find("Camera (eye)");
				Camera camera = (gameObject != null) ? gameObject.GetComponent<Camera>() : null;
				if (!camera)
				{
					GClass70.smethod_36("C is null!", GClass70.Enum1.const_0);
				}
				else
				{
					Vector3 vector = camera.WorldToScreenPoint(gameObject_39.transform.position);
					vector.y = (float)Screen.height - vector.y;
					if (vector.z > 0f)
					{
						GClass84.material_0.SetPass(0);
						GL.PushMatrix();
						GL.Begin(1);
						GL.Color(color_0);
						GL.Vertex3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f);
						GL.Vertex(new Vector3(vector.x, vector.y, 0f));
						GL.End();
						GL.PopMatrix();
					}
				}
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0006B7D4 File Offset: 0x000699D4
		internal static void smethod_820(PortalInternal portalInternal_0)
		{
			GClass84.smethod_1714(portalInternal_0);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0006B7E8 File Offset: 0x000699E8
		internal static APIUser smethod_821()
		{
			return GClass84.smethod_518(GClass84.smethod_126());
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0006B804 File Offset: 0x00069A04
		internal static Player smethod_822()
		{
			return GClass84.smethod_1513(GClass84.smethod_1010());
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0006B820 File Offset: 0x00069A20
		internal static void smethod_823(Button button_0)
		{
			GClass84.smethod_649(button_0);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0006B834 File Offset: 0x00069A34
		internal static void smethod_824()
		{
			GClass84.smethod_620();
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0006B848 File Offset: 0x00069A48
		internal static void smethod_825<T>(ref List<T> list_51, IEqualityComparer<T> iequalityComparer_0)
		{
			if (list_51 != null && list_51.Count != 0)
			{
				list_51 = list_51.Distinct(iequalityComparer_0).ToList<T>();
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0006B878 File Offset: 0x00069A78
		internal static void smethod_826()
		{
			GClass84.smethod_1712();
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0006B88C File Offset: 0x00069A8C
		internal static int smethod_827(VRCPlayer vrcplayer_0)
		{
			int result;
			if (!vrcplayer_0)
			{
				result = -1;
			}
			else
			{
				result = GClass84.smethod_1568(GClass84.smethod_1557(vrcplayer_0));
			}
			return result;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0006B8B8 File Offset: 0x00069AB8
		internal static string smethod_828(APIUser apiuser_0, string string_4 = "")
		{
			return GClass84.smethod_372(apiuser_0, string_4);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0006B8CC File Offset: 0x00069ACC
		internal static void smethod_829(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_777(gclass156_1, int_1, int_2, int_3, int_4, int_5);
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_5);
			GClass84.GStruct163 gstruct2 = GClass84.smethod_50(int_1, int_2, int_3, (int_5 + int_4) % 360);
			if (!GClass84.GStruct163.smethod_0(gstruct, gstruct2))
			{
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, 0);
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct2.int_0, gstruct2.int_1, 0);
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0006B938 File Offset: 0x00069B38
		internal static Transform smethod_830(GameObject gameObject_39, string string_4)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_693(gameObject_39.transform, string_4);
			}
			return result;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0006B964 File Offset: 0x00069B64
		internal static Player smethod_831(VRCPlayerApi vrcplayerApi_0)
		{
			return (vrcplayerApi_0 != null) ? vrcplayerApi_0.smethod_464<Player>() : null;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0006B980 File Offset: 0x00069B80
		internal static bool smethod_832(this MethodBase methodBase_0, string string_4 = null, string string_5 = null)
		{
			bool flag = false;
			foreach (XrefInstance xrefInstance in XrefScanner.XrefScan(methodBase_0))
			{
				if (xrefInstance.Type == 1)
				{
					MethodBase methodBase = xrefInstance.TryResolve();
					if (methodBase != null)
					{
						if (!string.IsNullOrEmpty(string_4))
						{
							flag = (!string.IsNullOrEmpty(methodBase.Name) && methodBase.Name.IndexOf(string_4, StringComparison.OrdinalIgnoreCase) >= 0);
						}
						if (!string.IsNullOrEmpty(string_5))
						{
							Type reflectedType = methodBase.ReflectedType;
							flag = (!string.IsNullOrEmpty((reflectedType != null) ? reflectedType.Name : null) && methodBase.ReflectedType.Name.IndexOf(string_5, StringComparison.OrdinalIgnoreCase) >= 0);
						}
						if (flag)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0006BA80 File Offset: 0x00069C80
		internal static void smethod_833()
		{
			GClass84.smethod_219();
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0006BA94 File Offset: 0x00069C94
		internal static string smethod_834(GameObject gameObject_39, Transform transform_0)
		{
			return GClass84.smethod_11(gameObject_39, transform_0);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0006BAA8 File Offset: 0x00069CA8
		internal static Transform smethod_835()
		{
			GameObject gameObject = GClass84.smethod_250();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0006BAC8 File Offset: 0x00069CC8
		internal static Transform smethod_836(Transform transform_0, List<string> list_51)
		{
			Transform result;
			if (!transform_0 || list_51 == null || list_51.Count < 1)
			{
				result = null;
			}
			else
			{
				Transform transform = null;
				if (!string.IsNullOrEmpty(list_51[0]))
				{
					for (int i = 0; i < transform_0.childCount; i++)
					{
						Transform child = transform_0.GetChild(i);
						if (child.name == list_51[0])
						{
							transform = child;
							break;
						}
					}
				}
				if (list_51.Count == 1)
				{
					result = transform;
				}
				else
				{
					list_51.RemoveAt(0);
					Transform transform2 = GClass84.smethod_836(transform, list_51);
					result = transform2;
				}
			}
			return result;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0006BB64 File Offset: 0x00069D64
		internal static string smethod_837()
		{
			return GClass84.smethod_453();
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0006BB78 File Offset: 0x00069D78
		internal static string smethod_838(Player player_0)
		{
			string result;
			if (!player_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_1520(GClass84.smethod_518(player_0));
			}
			return result;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0006BBA8 File Offset: 0x00069DA8
		private static string smethod_839(string string_4)
		{
			return GClass84.smethod_139(string_4);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0006BBBC File Offset: 0x00069DBC
		internal static VRCPlayer smethod_840(VRCPlayerApi vrcplayerApi_0)
		{
			return (vrcplayerApi_0 != null) ? vrcplayerApi_0.smethod_464<VRCPlayer>() : null;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0006BBD8 File Offset: 0x00069DD8
		internal static int smethod_841()
		{
			DateTime now = DateTime.Now;
			return now.Hour * 3600000 + now.Minute * 60000 + now.Second * 1000 + now.Millisecond;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0006BC20 File Offset: 0x00069E20
		internal static void smethod_842()
		{
			GClass84.smethod_699();
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0006BC34 File Offset: 0x00069E34
		internal static GameObject smethod_843(Transform transform_0)
		{
			return GClass84.smethod_47(transform_0, "HmdPivot");
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0006BC50 File Offset: 0x00069E50
		internal static bool smethod_844(VRC_Trigger vrc_Trigger_0, string string_4)
		{
			bool result;
			if (!vrc_Trigger_0)
			{
				result = false;
			}
			else
			{
				bool flag = GClass84.gclass137_0.bool_3;
				GClass84.gclass137_0.bool_3 = true;
				bool flag2 = GClass84.smethod_489(vrc_Trigger_0, string_4);
				GClass84.gclass137_0.bool_3 = flag;
				result = flag2;
			}
			return result;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0006BC98 File Offset: 0x00069E98
		internal static Texture2D smethod_845(string string_4)
		{
			Texture2D result;
			try
			{
				if (string_4 == string.Empty)
				{
					result = null;
				}
				else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("http://")) == "http://" || GClass84.smethod_1428(string_4, GClass84.smethod_593("https://")) == "https://")
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_4);
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Stream responseStream = httpWebResponse.GetResponseStream();
					result = GClass84.smethod_112(new Bitmap(responseStream));
				}
				else
				{
					result = null;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0006BD40 File Offset: 0x00069F40
		internal static void smethod_846(GameObject gameObject_39)
		{
			GClass84.smethod_96(gameObject_39);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0006BD54 File Offset: 0x00069F54
		internal static bool smethod_847(string string_4, Type type_0, string string_5, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			GClass84.Class107 @class = new GClass84.Class107();
			@class.string_0 = string_5;
			bool flag = false;
			List<MethodInfo> list = type_0.GetMethods().ToList<MethodInfo>();
			Predicate<MethodInfo> match;
			if ((match = @class.predicate_0) == null)
			{
				match = (@class.predicate_0 = new Predicate<MethodInfo>(@class.method_0));
			}
			foreach (MethodInfo methodInfo in list.FindAll(match))
			{
				if (GClass84.smethod_1123(string_4, methodInfo, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
				{
					flag = true;
				}
				else
				{
					string text = "Null";
					string text2 = @class.string_0;
					string text3 = "Null";
					string text4 = "Null";
					string text5 = "Null";
					if (type_0 != null)
					{
						text = type_0.Name;
					}
					if (harmonyMethod_0 != null)
					{
						text3 = harmonyMethod_0.methodName;
					}
					if (harmonyMethod_1 != null)
					{
						text4 = harmonyMethod_1.methodName;
					}
					if (harmonyMethod_2 != null)
					{
						text5 = harmonyMethod_2.methodName;
					}
					GClass70.smethod_109(string.Concat(new string[]
					{
						"Can",
						"'",
						"t",
						" ",
						"Patch",
						" ",
						"Method",
						" \"",
						methodInfo.Name,
						"\"",
						" (",
						string_4,
						", ",
						text,
						", ",
						text2,
						", ",
						text3,
						", ",
						text4,
						", ",
						text5,
						")"
					}), GClass70.Enum1.const_0);
				}
			}
			if (!flag)
			{
				string text6 = "Null";
				string text7 = @class.string_0;
				string text8 = "Null";
				string text9 = "Null";
				string text10 = "Null";
				if (type_0 != null)
				{
					text6 = type_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text8 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text9 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text10 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Methods",
					" (",
					string_4,
					", ",
					text6,
					", ",
					text7,
					", ",
					text8,
					", ",
					text9,
					", ",
					text10,
					")"
				}), GClass70.Enum1.const_0);
			}
			return flag;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0006C04C File Offset: 0x0006A24C
		internal static void smethod_848(Player player_0)
		{
			if (player_0)
			{
				GClass84.smethod_284(GClass84.smethod_518(player_0));
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0006C070 File Offset: 0x0006A270
		internal static void smethod_849(GameObject gameObject_39)
		{
			if (gameObject_39)
			{
				gameObject_39.SetActive(false);
				gameObject_39.transform.SetParent(null);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0006C098 File Offset: 0x0006A298
		internal static Vector3 smethod_850(Vector2 vector2_0)
		{
			return new Vector3(vector2_0.y, 0f, vector2_0.x);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0006C0C0 File Offset: 0x0006A2C0
		internal static void smethod_851(float float_3)
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			if (!(locomotionInputController == null))
			{
				GClass84.smethod_1504(GClass84.smethod_1346() + float_3);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0006C0E8 File Offset: 0x0006A2E8
		internal static void smethod_852(ApiWorld apiWorld_0)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_ApiWorld_PDM_0(apiWorld_0);
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0006C108 File Offset: 0x0006A308
		internal static bool smethod_853(string string_4, Type type_0, string string_5, Type[] type_1, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			GClass84.Class109 @class = new GClass84.Class109();
			@class.string_0 = string_5;
			bool flag = false;
			List<MethodInfo> list = type_0.GetMethods().ToList<MethodInfo>();
			Predicate<MethodInfo> match;
			if ((match = @class.predicate_0) == null)
			{
				match = (@class.predicate_0 = new Predicate<MethodInfo>(@class.method_0));
			}
			foreach (MethodInfo methodInfo in list.FindAll(match))
			{
				if (GClass84.smethod_1123(string_4, methodInfo, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
				{
					flag = true;
				}
				else
				{
					string text = "Null";
					string text2 = @class.string_0;
					string text3 = "Null";
					string text4 = "Null";
					string text5 = "Null";
					string text6 = "Null";
					if (type_0 != null)
					{
						text = type_0.Name;
					}
					if (type_1 != null)
					{
						text3 = string.Empty;
						foreach (Type type in type_1)
						{
							text3 = text3 + ", " + type.Name;
						}
						if (text3 != string.Empty)
						{
							text3 = "(" + GClass84.smethod_1204(text3, 2, -1) + ")";
						}
					}
					if (harmonyMethod_0 != null)
					{
						text4 = harmonyMethod_0.methodName;
					}
					if (harmonyMethod_1 != null)
					{
						text5 = harmonyMethod_1.methodName;
					}
					if (harmonyMethod_2 != null)
					{
						text6 = harmonyMethod_2.methodName;
					}
					GClass70.smethod_109(string.Concat(new string[]
					{
						"Can",
						"'",
						"t",
						" ",
						"Patch",
						" ",
						"Method",
						" \"",
						methodInfo.Name,
						"\"",
						" (",
						string_4,
						", ",
						text,
						", ",
						text2,
						", ",
						text3,
						", ",
						text4,
						", ",
						text5,
						", ",
						text6,
						")"
					}), GClass70.Enum1.const_0);
				}
			}
			if (!flag)
			{
				string text7 = "Null";
				string text8 = @class.string_0;
				string text9 = "Null";
				string text10 = "Null";
				string text11 = "Null";
				string text12 = "Null";
				if (type_0 != null)
				{
					text7 = type_0.Name;
				}
				if (type_1 != null)
				{
					text9 = string.Empty;
					foreach (Type type2 in type_1)
					{
						text9 = text9 + ", " + type2.Name;
					}
					if (text9 != string.Empty)
					{
						text9 = "(" + GClass84.smethod_1204(text9, 2, -1) + ")";
					}
				}
				if (harmonyMethod_0 != null)
				{
					text10 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text11 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text12 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Methods",
					" ",
					"Start",
					" ",
					"With",
					" (",
					string_4,
					", ",
					text7,
					", ",
					text8,
					", ",
					text9,
					", ",
					text10,
					", ",
					text11,
					", ",
					text12,
					")"
				}), GClass70.Enum1.const_0);
			}
			return flag;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0006C524 File Offset: 0x0006A724
		internal static void smethod_854(Object object_0)
		{
			GClass84.smethod_1592(object_0);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0006C538 File Offset: 0x0006A738
		internal static Transform smethod_855(Transform transform_0)
		{
			Transform result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_693(transform_0, "ForwardDirection");
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_693(transform, "_AvatarShadowClone");
				}
			}
			return result;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0006C57C File Offset: 0x0006A77C
		internal static APIUser smethod_856(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_518(GClass84.smethod_384(vrcplayer_0));
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0006C598 File Offset: 0x0006A798
		internal static void smethod_857(Button button_0, Action action_0)
		{
			GClass84.smethod_446(button_0, action_0);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0006C5AC File Offset: 0x0006A7AC
		internal static string smethod_858(char[] char_1, int int_1)
		{
			return GClass84.smethod_771(char_1, int_1);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
		internal static string smethod_859()
		{
			return GClass84.smethod_584();
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0006C5D4 File Offset: 0x0006A7D4
		internal static string smethod_860(VRCPlayer vrcplayer_0, string string_4)
		{
			return GClass84.smethod_1615(vrcplayer_0, string_4);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0006C5E8 File Offset: 0x0006A7E8
		internal static void smethod_861(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			if (int_2 > int_4)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num;
			int num5 = int_1;
			int num6 = int_3 - int_1;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_2; i <= int_4; i++)
			{
				if (int_5 == 1)
				{
					GClass84.smethod_774(gclass156_1, (float)num5, (float)i);
				}
				else
				{
					GClass84.smethod_1015(gclass156_1, (float)num5, (float)i, int_5, int_5);
				}
				num3 += num4;
				if (2 * num3 >= num2)
				{
					num5 += num6;
					num3 -= num2;
				}
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0006C698 File Offset: 0x0006A898
		internal static void smethod_862(bool bool_10)
		{
			GClass84.smethod_528(bool_10);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0006C6AC File Offset: 0x0006A8AC
		internal static IEnumerator smethod_863(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.Class116 @class = new GClass84.Class116(0);
			@class.vrcplayerApi_0 = vrcplayerApi_0;
			return @class;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0006C6C8 File Offset: 0x0006A8C8
		internal static void smethod_864(string string_4)
		{
			Networking.Instantiate(0, string_4, GClass84.smethod_460().transform.position, new Quaternion(0f, 0f, 0f, 0.7f));
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0006C708 File Offset: 0x0006A908
		internal static void smethod_865(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_895(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0006C728 File Offset: 0x0006A928
		internal static Vector3 smethod_866(Vector2 vector2_0)
		{
			return new Vector3(0f, vector2_0.y, vector2_0.x);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0006C750 File Offset: 0x0006A950
		internal static void smethod_867(Player player_0, float float_3)
		{
			GClass84.smethod_455(player_0, float_3);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0006C764 File Offset: 0x0006A964
		internal static void smethod_868(Slider slider_0)
		{
			GClass84.smethod_1038(slider_0);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0006C778 File Offset: 0x0006A978
		internal static Type[] smethod_869(Assembly[] assembly_0, string string_4)
		{
			return GClass84.smethod_1564(assembly_0, string_4).ToArray();
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0006C794 File Offset: 0x0006A994
		internal static Player[] smethod_870()
		{
			PlayerManager playerManager = GClass84.smethod_1472();
			Player[] result;
			if (!playerManager)
			{
				result = new Player[0];
			}
			else
			{
				result = playerManager.field_Private_List_1_Player_0.ToArray();
			}
			return result;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0006C7D0 File Offset: 0x0006A9D0
		internal static string smethod_871(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_500(vrcplayerApi_0);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0006C7E4 File Offset: 0x0006A9E4
		internal static bool smethod_872(PlayerNet playerNet_0)
		{
			return playerNet_0 && GClass84.smethod_1260(GClass84.smethod_1525(playerNet_0));
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0006C810 File Offset: 0x0006AA10
		internal static Quaternion smethod_873()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			Quaternion result;
			if (vrcplayer)
			{
				result = vrcplayer.transform.rotation;
			}
			else
			{
				result = default(Quaternion);
			}
			return result;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0006C844 File Offset: 0x0006AA44
		internal static void smethod_874(List<GameObject> list_51, Transform transform_0)
		{
			GClass84.smethod_1012(list_51, transform_0);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006C858 File Offset: 0x0006AA58
		internal static void smethod_875()
		{
			GClass84.smethod_779();
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006C86C File Offset: 0x0006AA6C
		internal static Transform smethod_876()
		{
			GameObject gameObject = GClass84.smethod_123();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0006C88C File Offset: 0x0006AA8C
		internal static bool smethod_877(GameObject gameObject_39, string string_4)
		{
			return gameObject_39 && !(string_4 == string.Empty) && GClass84.smethod_1734(gameObject_39.transform, string_4);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0006C8C4 File Offset: 0x0006AAC4
		internal static List<Transform> smethod_878(List<Transform> list_51, int int_1)
		{
			List<Transform> result;
			if (list_51 == null || list_51.Count < 1)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_1687(list_51[i], int_1));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0006C91C File Offset: 0x0006AB1C
		internal static bool smethod_879(Mesh mesh_0, float float_3 = 0.01f)
		{
			bool result;
			if (!mesh_0)
			{
				result = false;
			}
			else
			{
				int count = mesh_0.vertices.Count;
				if (count >= 6)
				{
					Il2CppStructArray<Vector3> vertices = mesh_0.vertices;
					Vector3 center = mesh_0.bounds.center;
					float num = GClass84.smethod_743(center - vertices[0]);
					List<GClass84.GStruct149> list = new List<GClass84.GStruct149>
					{
						new GClass84.GStruct149(new Vector3(1f, 0f, 0f)),
						new GClass84.GStruct149(new Vector3(-1f, 0f, 0f)),
						new GClass84.GStruct149(new Vector3(0f, 1f, 0f)),
						new GClass84.GStruct149(new Vector3(0f, -1f, 0f)),
						new GClass84.GStruct149(new Vector3(0f, 0f, 1f)),
						new GClass84.GStruct149(new Vector3(0f, 0f, -1f))
					};
					bool flag = false;
					for (int i = 1; i < count; i++)
					{
						Vector3 vector3_ = vertices[i] - center;
						if (GClass84.smethod_1494(GClass84.smethod_743(vector3_) - num) > float_3)
						{
							return false;
						}
						if (!flag)
						{
							flag = true;
							for (int j = 0; j < list.Count; j++)
							{
								GClass84.GStruct149 gstruct = list[j];
								if (!gstruct.bool_0)
								{
									if (GClass84.smethod_1121(GClass84.smethod_1479(vector3_) + new Vector3(float_3, float_3, float_3), gstruct.vector3_0, GClass84.Enum7.const_3))
									{
										gstruct.bool_0 = true;
										list[j] = gstruct;
									}
									else
									{
										flag = false;
									}
								}
							}
						}
					}
					result = flag;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0006CB08 File Offset: 0x0006AD08
		internal static Transform smethod_880(GameObject gameObject_39)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
			}
			return result;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0006CB44 File Offset: 0x0006AD44
		internal static void smethod_881()
		{
			GClass84.smethod_198();
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0006CB58 File Offset: 0x0006AD58
		internal static GameObject smethod_882()
		{
			if (!GClass84.gameObject_13)
			{
				GClass84.gameObject_13 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements");
			}
			return GClass84.gameObject_13;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0006CB8C File Offset: 0x0006AD8C
		internal static void smethod_883()
		{
			GClass84.smethod_688();
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0006CBA0 File Offset: 0x0006ADA0
		internal static string smethod_884(string string_4, string string_5, string string_6)
		{
			return GClass84.smethod_1173(string_4, string_5, string_6);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
		internal static void smethod_885(PlayerNet playerNet_0)
		{
			GClass84.smethod_982(playerNet_0);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0006CBCC File Offset: 0x0006ADCC
		internal static void smethod_886(GClass156 gclass156_1, int int_1, int int_2, int int_3)
		{
			int num = 0;
			int i = int_3;
			int num2 = 1 - 2 * int_3;
			while (i >= 0)
			{
				GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 + i));
				GClass84.smethod_774(gclass156_1, (float)(int_1 + num), (float)(int_2 - i));
				GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 + i));
				GClass84.smethod_774(gclass156_1, (float)(int_1 - num), (float)(int_2 - i));
				int num3 = 2 * (num2 + i) - 1;
				if (num2 < 0 && num3 <= 0)
				{
					num2 += 2 * ++num + 1;
				}
				else if (num2 > 0 && num3 > 0)
				{
					num2 -= 2 * --i + 1;
				}
				else
				{
					num2 += 2 * (++num - i--);
				}
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0006CC84 File Offset: 0x0006AE84
		internal static void smethod_887()
		{
			GClass84.smethod_1378();
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0006CC98 File Offset: 0x0006AE98
		internal static VRCVrCamera smethod_888()
		{
			return VRCVrCamera.field_Private_Static_VRCVrCamera_0;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0006CCAC File Offset: 0x0006AEAC
		internal static Transform smethod_889(GameObject gameObject_39)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_836(transform, new List<string>
					{
						"Avatar"
					});
				}
			}
			return result;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0006CD0C File Offset: 0x0006AF0C
		internal static void smethod_890(GameObject gameObject_39, bool bool_10 = false)
		{
			GClass84.smethod_1259(gameObject_39, bool_10);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0006CD20 File Offset: 0x0006AF20
		internal static Vector3 smethod_891(List<Transform> list_51)
		{
			Vector3 result;
			if (list_51.Count == 0)
			{
				result = default(Vector3);
			}
			else
			{
				Vector3 vector = default(Vector3);
				int num = 0;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (!list_51[i])
					{
						num++;
					}
					else
					{
						vector += list_51[i].position;
					}
				}
				if (list_51.Count == num)
				{
					result = vector;
				}
				else
				{
					result = vector / (float)(list_51.Count - num);
				}
			}
			return result;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		internal static void smethod_892(Mesh mesh_0, int int_1)
		{
			GClass84.smethod_1283(mesh_0, int_1);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0006CDD0 File Offset: 0x0006AFD0
		internal static Transform smethod_893()
		{
			GameObject gameObject = GClass84.smethod_1578();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		internal static void smethod_894(float float_3)
		{
			GClass84.smethod_153(float_3);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0006CE04 File Offset: 0x0006B004
		internal static void smethod_895(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			int num = 0;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			if (int_4 > 0)
			{
				int i = int_3;
				int num6 = 1 - 2 * int_3;
				float num7 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num7) * (float)int_3;
					num5 = (float)Math.Cos(1.5707963267948966 - (double)num7) * (float)int_3;
				}
				if (int_4 > 90 && int_4 < 360)
				{
					num2 = (float)Math.Sin(7.8539816339744828 - (double)num7) * (float)int_3;
					num3 = (float)Math.Cos(7.8539816339744828 - (double)num7) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_5, int_5);
					}
					else if ((int_4 <= 45 && (float)num <= num5) || (int_4 > 45 && (float)i >= num4))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_5, int_5);
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_5, int_5);
						}
						else if ((int_4 <= 135 && (float)i <= -num2) || (int_4 > 135 && (float)num >= num3))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_5, int_5);
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_5, int_5);
						}
						else if ((int_4 <= 225 && (float)num <= -num3) || (int_4 > 225 && (float)i >= -num2))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_5, int_5);
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_5, int_5);
						}
						else if ((int_4 <= 315 && (float)i <= num2) || (int_4 > 315 && (float)num >= -num3))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_5, int_5);
						}
					}
					int num8 = 2 * (num6 + i) - 1;
					if (num6 < 0 && num8 <= 0)
					{
						num6 += 2 * ++num + 1;
					}
					else if (num6 > 0 && num8 > 0)
					{
						num6 -= 2 * --i + 1;
					}
					else
					{
						num6 += 2 * (++num - i--);
					}
				}
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0006D0E8 File Offset: 0x0006B2E8
		internal static bool smethod_896(GameObject gameObject_39, string string_4, bool bool_10)
		{
			return gameObject_39 && !(string_4 == string.Empty) && GClass84.smethod_448(gameObject_39.transform, string_4, bool_10);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0006D120 File Offset: 0x0006B320
		internal static List<Transform> smethod_897(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0 || transform_0.parent)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>
				{
					transform_0.parent
				};
				list.AddRange(GClass84.smethod_897(transform_0.parent));
				result = list;
			}
			return result;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0006D174 File Offset: 0x0006B374
		internal static bool smethod_898(GameObject gameObject_39, float float_3)
		{
			bool result;
			if (!gameObject_39)
			{
				result = false;
			}
			else
			{
				PortalInternal componentInChildren = gameObject_39.GetComponentInChildren<PortalInternal>();
				if (!componentInChildren)
				{
					result = false;
				}
				else
				{
					componentInChildren.SetTimerRPC(float.MinValue, Player.Method_Internal_Static_get_Player_0());
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0006D1BC File Offset: 0x0006B3BC
		internal static void smethod_899(VRCPlayer vrcplayer_0)
		{
			if (vrcplayer_0)
			{
				GClass84.smethod_284(GClass84.smethod_856(vrcplayer_0));
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0006D1E0 File Offset: 0x0006B3E0
		internal static List<GClass84.GStruct163> smethod_900(int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			int num = 0;
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			int_5 = GClass84.smethod_1551(int_5, -360, 360);
			int_5 = GClass84.smethod_108<int>(int_5 < 0, 360 + int_5, int_5);
			int_5 = GClass84.smethod_108<int>(int_5 == 360, 0, int_5);
			float num2 = (float)((int_4 + int_5) % 360);
			List<GClass84.GStruct163> result;
			if (int_5 == 0)
			{
				result = GClass84.smethod_768(int_1, int_2, int_3, int_4);
			}
			else if (int_4 <= 0)
			{
				result = list;
			}
			else
			{
				int i = int_3;
				int num3 = 1 - 2 * int_3;
				float num4 = GClass84.smethod_1480((float)int_5);
				float num5 = GClass84.smethod_1480(num2);
				float num6 = (float)Math.Cos(1.5707963267948966 - (double)num4) * (float)int_3;
				float num7 = (float)Math.Sin(1.5707963267948966 - (double)num4) * (float)int_3;
				float num8 = (float)Math.Cos(1.5707963267948966 - (double)num5) * (float)int_3;
				float num9 = (float)Math.Sin(1.5707963267948966 - (double)num5) * (float)int_3;
				float num10 = (float)Math.Cos(7.8539816339744828 - (double)num4) * (float)int_3;
				float num11 = (float)Math.Sin(7.8539816339744828 - (double)num4) * (float)int_3;
				float num12 = (float)Math.Cos(7.8539816339744828 - (double)num5) * (float)int_3;
				float num13 = (float)Math.Sin(7.8539816339744828 - (double)num5) * (float)int_3;
				while (i >= 0)
				{
					if (int_5 <= 360 && int_5 >= 90)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 90f)
							{
								list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
							}
							else if (num2 > 0f && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
							{
								list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
						}
						if ((num2 > 0f || num2 < 90f) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
						}
					}
					else if (num2 >= 90f)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
						}
					}
					else if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
					{
						list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
					}
					if (int_5 <= 90)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 90f)
							{
								if (num2 >= 180f)
								{
									list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
								}
								else if ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12))
								{
									list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
					}
					else if (int_5 <= 360 && int_5 >= 180)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 180f)
							{
								list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
							}
							else if (num2 > 90f && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
							{
								list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
						if ((num2 > 90f || num2 < 180f) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
					}
					else if (num2 >= 180f)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
						}
					}
					else if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
					{
						list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
					}
					if (int_5 <= 180)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 180f)
							{
								if (num2 >= 270f)
								{
									list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
								}
								else if ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13))
								{
									list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
					}
					else if (int_5 <= 360 && int_5 >= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 270f)
							{
								list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
							}
							else if (num2 > 180f && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
							{
								list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
						if ((num2 > 180f || num2 < 270f) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
					}
					else if (num2 >= 270f)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
						}
					}
					else if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
					{
						list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
					}
					if (int_5 <= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 0f && num2 < 270f)
							{
								list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
							}
						}
						else if (num2 > 270f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
						}
						if (num2 > 270f && num2 < 360f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
						}
					}
					else if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10) && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
					{
						list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
					}
					int num14 = 2 * (num3 + i) - 1;
					if (num3 < 0 && num14 <= 0)
					{
						num3 += 2 * ++num + 1;
					}
					else if (num3 > 0 && num14 > 0)
					{
						num3 -= 2 * --i + 1;
					}
					else
					{
						num3 += 2 * (++num - i--);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0006DC18 File Offset: 0x0006BE18
		internal static string smethod_901(string string_4)
		{
			return GClass84.smethod_512(string_4);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0006DC2C File Offset: 0x0006BE2C
		internal static void smethod_902()
		{
			try
			{
				GClass84.smethod_1490().Method_Public_Void_0();
			}
			catch
			{
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		internal static string smethod_903(UdonBehaviour udonBehaviour_0, int int_1)
		{
			return GClass84.smethod_242(udonBehaviour_0, int_1);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0006DC70 File Offset: 0x0006BE70
		internal static VRCMotionState smethod_904()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.GetComponent<VRCMotionState>() : null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0006DC90 File Offset: 0x0006BE90
		internal static void smethod_905(Player player_0)
		{
			GClass84.smethod_1314(player_0);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0006DCA4 File Offset: 0x0006BEA4
		internal static void smethod_906(Mesh mesh_0)
		{
			GClass84.smethod_983(mesh_0);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006DCB8 File Offset: 0x0006BEB8
		internal static GameObject[] smethod_907(GameObject gameObject_39)
		{
			GameObject[] result;
			if (!gameObject_39)
			{
				result = new GameObject[0];
			}
			else
			{
				result = GClass84.smethod_164(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0006DCE8 File Offset: 0x0006BEE8
		internal static string smethod_908(Transform transform_0, Transform transform_1)
		{
			return GClass84.smethod_666(transform_0, transform_1);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0006DCFC File Offset: 0x0006BEFC
		internal static bool smethod_909(GameObject gameObject_39, string string_4, bool bool_10 = false)
		{
			return gameObject_39 && GClass84.smethod_1258(gameObject_39.transform, string_4, bool_10);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0006DD28 File Offset: 0x0006BF28
		internal static float smethod_910(float float_3, float float_4)
		{
			float result;
			if (float_3 > float_4)
			{
				result = float_4;
			}
			else
			{
				result = float_3;
			}
			return result;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0006DD44 File Offset: 0x0006BF44
		internal static string smethod_911(ApiWorld apiWorld_0, string string_4)
		{
			return GClass84.smethod_1666(apiWorld_0, string_4);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0006DD58 File Offset: 0x0006BF58
		internal static string smethod_912(ConsoleColor consoleColor_0)
		{
			string result;
			switch (consoleColor_0)
			{
			case ConsoleColor.Black:
				result = "#000000";
				break;
			case ConsoleColor.DarkBlue:
				result = "#000080";
				break;
			case ConsoleColor.DarkGreen:
				result = "#008000";
				break;
			case ConsoleColor.DarkCyan:
				result = "#008080";
				break;
			case ConsoleColor.DarkRed:
				result = "#800000";
				break;
			case ConsoleColor.DarkMagenta:
				result = "#800080";
				break;
			case ConsoleColor.DarkYellow:
				result = "#808000";
				break;
			case ConsoleColor.Gray:
				result = "#C0C0C0";
				break;
			case ConsoleColor.DarkGray:
				result = "#808080";
				break;
			case ConsoleColor.Blue:
				result = "#0000FF";
				break;
			case ConsoleColor.Green:
				result = "#00FF00";
				break;
			case ConsoleColor.Cyan:
				result = "#00FFFF";
				break;
			case ConsoleColor.Red:
				result = "#FF0000";
				break;
			case ConsoleColor.Magenta:
				result = "#FF00FF";
				break;
			case ConsoleColor.Yellow:
				result = "#FFFF00";
				break;
			case ConsoleColor.White:
				result = "#FFFFFF";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0006DE38 File Offset: 0x0006C038
		internal static void smethod_913(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_914(vrcplayer_0);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0006DE4C File Offset: 0x0006C04C
		internal static void smethod_914(VRCPlayer vrcplayer_0)
		{
			if (vrcplayer_0)
			{
				GClass84.smethod_445(GClass84.smethod_856(vrcplayer_0));
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0006DE70 File Offset: 0x0006C070
		internal static void smethod_915()
		{
			GClass84.smethod_131();
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0006DE84 File Offset: 0x0006C084
		internal static int smethod_916(Transform transform_0)
		{
			int result;
			if (!transform_0)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				for (int i = 0; i < transform_0.childCount; i++)
				{
					num++;
					num += GClass84.smethod_916(transform_0.GetChild(i));
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0006DECC File Offset: 0x0006C0CC
		internal static T smethod_917<T>(object object_0)
		{
			return GClass84.smethod_1197<T>(GClass84.smethod_1720(object_0));
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0006DEE8 File Offset: 0x0006C0E8
		internal static void smethod_918()
		{
			for (int i = GClass84.list_46.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_46[i]);
			}
			GClass84.list_46.Clear();
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0005CE4C File Offset: 0x0005B04C
		internal static Transform smethod_919(Player player_0)
		{
			Transform result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_662(player_0.transform);
			}
			return result;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0006DF2C File Offset: 0x0006C12C
		internal static string smethod_920(GameObject gameObject_39, GameObject gameObject_40)
		{
			return GClass84.smethod_568(gameObject_39, gameObject_40);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0006DF40 File Offset: 0x0006C140
		internal static void smethod_921(string string_4)
		{
			if (string_4 == null)
			{
				GClass70.smethod_38("ID Is Null!", GClass70.Enum1.const_0);
			}
			else if (!string_4.StartsWith("avtr_"))
			{
				GClass70.smethod_38("Invalid avatar ID", GClass70.Enum1.const_0);
			}
			else
			{
				foreach (VRC_AvatarPedestal vrc_AvatarPedestal in Object.FindObjectsOfType<VRC_AvatarPedestal>())
				{
					GClass84.smethod_191(Networking.LocalPlayer, vrc_AvatarPedestal.gameObject);
					Networking.RPC(0, vrc_AvatarPedestal.gameObject, "SwitchAvatar", new Object[]
					{
						string_4
					});
				}
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0006DFEC File Offset: 0x0006C1EC
		internal static string smethod_922(string string_4, int int_1)
		{
			string result;
			if (int_1 < 1)
			{
				result = string.Empty;
			}
			else if (string_4.Length <= int_1)
			{
				result = string_4;
			}
			else
			{
				result = string_4.Substring(0, int_1);
			}
			return result;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0006E024 File Offset: 0x0006C224
		internal static Color smethod_923(Color32 color32_0)
		{
			return Color.FromArgb((int)color32_0.a, (int)color32_0.r, (int)color32_0.g, (int)color32_0.b);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0006E050 File Offset: 0x0006C250
		internal static void smethod_924(List<Transform> list_51, GameObject gameObject_39)
		{
			GClass84.smethod_346(list_51, gameObject_39);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0006E064 File Offset: 0x0006C264
		internal static void smethod_925()
		{
			GClass84.smethod_1109();
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0006E078 File Offset: 0x0006C278
		internal static void smethod_926(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7, bool bool_11, Action<VRCUiPopup> action_2, bool bool_12)
		{
			GClass84.smethod_249(string_4, string_5, inputType_0, bool_10, string_6, action_0, action_1, string_7, bool_11, action_2, bool_12);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0006251C File Offset: 0x0006071C
		internal static Transform smethod_927(Player player_0)
		{
			Transform result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1427(player_0.transform);
			}
			return result;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006E0AC File Offset: 0x0006C2AC
		internal static List<DynamicBone> smethod_928(GameObject gameObject_39)
		{
			List<DynamicBone> result;
			if (!gameObject_39)
			{
				result = new List<DynamicBone>();
			}
			else
			{
				result = GClass84.smethod_1556(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0006E0DC File Offset: 0x0006C2DC
		internal static GameObject smethod_929()
		{
			if (!GClass84.gameObject_14)
			{
				GClass84.gameObject_14 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingBackground_TealGradient");
			}
			return GClass84.gameObject_14;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0006E110 File Offset: 0x0006C310
		internal static bool smethod_930(string string_4)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.ToLower().Contains(string_4))
				{
					GClass70.smethod_127("Process", string.Concat(new string[]
					{
						"Window",
						" ",
						"Handle",
						": ",
						processes[i].MainWindowHandle.ToString()
					}), GClass70.Enum1.const_0);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0006E19C File Offset: 0x0006C39C
		private static Cache smethod_931()
		{
			return AssetBundleDownloadManager.field_Private_Static_AssetBundleDownloadManager_0.field_Private_Cache_0;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0006E1B8 File Offset: 0x0006C3B8
		internal static List<int> smethod_932(string string_4, string string_5)
		{
			List<int> list = new List<int>();
			List<int> result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = list;
			}
			else
			{
				int i = 0;
				int num = 0;
				while (i < GClass84.smethod_593(string_4))
				{
					if (string_4[i] == string_5[num])
					{
						num++;
						if (num == GClass84.smethod_593(string_5))
						{
							list.Add(i - num + 1);
							num = 0;
						}
					}
					else
					{
						num = 0;
					}
					i++;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0006E23C File Offset: 0x0006C43C
		internal static void smethod_933(string string_4, int int_1)
		{
			GClass84.smethod_516(string_4, int_1);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0006E250 File Offset: 0x0006C450
		internal static bool smethod_934(out string string_4)
		{
			bool result;
			if (GClass84.list_38.Count == 0)
			{
				string_4 = string.Empty;
				result = false;
			}
			else
			{
				string_4 = GClass84.list_38[GClass84.smethod_1673(GClass84.list_38.Count)].string_0;
				result = true;
			}
			return result;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0006E29C File Offset: 0x0006C49C
		internal static IEnumerator smethod_935(string string_4)
		{
			GClass84.Class112 @class = new GClass84.Class112(0);
			@class.string_0 = string_4;
			return @class;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
		internal static bool smethod_936(string string_4)
		{
			return string.IsNullOrEmpty(string_4) || GClass84.smethod_593(string_4) != GClass84.smethod_593("avtr_********-****-****-****-************") || GClass84.smethod_1428(string_4, GClass84.smethod_593("avtr_")) != "avtr_";
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0006E300 File Offset: 0x0006C500
		internal static bool smethod_937<T>(List<T> list_51, List<T> list_52, GClass84.Enum6 enum6_0 = GClass84.Enum6.const_0) where T : Object
		{
			bool result;
			if (list_52 == null || list_52.Count == 0 || list_51 == null || list_51.Count == 0)
			{
				result = false;
			}
			else if (enum6_0 != GClass84.Enum6.const_0)
			{
				if (enum6_0 != GClass84.Enum6.const_1)
				{
					result = false;
				}
				else
				{
					foreach (T gparam_ in list_52)
					{
						if (!GClass84.smethod_1224<T>(list_51, gparam_))
						{
							return false;
						}
					}
					result = true;
				}
			}
			else
			{
				foreach (T gparam_2 in list_52)
				{
					if (GClass84.smethod_1224<T>(list_51, gparam_2))
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		internal static void smethod_938(this ApiAvatar apiAvatar_0, string string_4, APIUser apiuser_0, string string_5, string string_6, string string_7, string string_8, string string_9, List<string> list_51, string string_10 = null)
		{
			GClass84.smethod_151(apiAvatar_0, string_4, apiuser_0, string_5, string_6, string_7, string_8, string_9, list_51, string_10);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0006E40C File Offset: 0x0006C60C
		internal static bool smethod_939(string string_4)
		{
			int num = GClass84.smethod_1611(string_4, ":");
			return num == -1 || GClass84.smethod_593(string_4) <= num + 1 || GClass84.smethod_1373(GClass84.smethod_1428(string_4, num));
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0006E44C File Offset: 0x0006C64C
		internal static float smethod_940(Vector2 vector2_0)
		{
			return (float)Math.Sqrt((double)(vector2_0.x * vector2_0.x + vector2_0.y * vector2_0.y));
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0006E480 File Offset: 0x0006C680
		internal static string smethod_941()
		{
			return GClass84.smethod_974();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0006E494 File Offset: 0x0006C694
		internal static void smethod_942(Player player_0)
		{
			GClass84.smethod_401(player_0);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		internal static void smethod_943(Transform transform_0, bool bool_10)
		{
			GClass84.smethod_1165(transform_0, bool_10);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		internal static void smethod_944(PortalInternal portalInternal_0, float float_3)
		{
			if (portalInternal_0 && portalInternal_0.gameObject)
			{
				Single single = default(Single);
				single.m_value = float_3;
				Object @object = single.BoxIl2CppObject();
				if (portalInternal_0.gameObject.activeInHierarchy && !portalInternal_0.GetComponentInParent<VRC_PortalMarker>())
				{
					Networking.RPC(7, portalInternal_0.gameObject, "SetTimerRPC", new Object[]
					{
						@object
					});
				}
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0006E53C File Offset: 0x0006C73C
		internal static GameObject smethod_945(VRCPlayerApi vrcplayerApi_0)
		{
			GameObject result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1056(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0006E560 File Offset: 0x0006C760
		internal static void smethod_946(string string_4, string string_5, InputField.InputType inputType_0, bool bool_10, string string_6, Action<string, List<KeyCode>, Text> action_0, Action action_1, string string_7 = "Enter text....", bool bool_11 = true, Action<VRCUiPopup> action_2 = null, bool bool_12 = false)
		{
			GClass84.smethod_926(string_4, string_5, inputType_0, bool_10, string_6, action_0, action_1, string_7, bool_11, action_2, bool_12);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0006E594 File Offset: 0x0006C794
		internal static bool smethod_947(VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0 && GClass84.smethod_764(GClass84.smethod_1557(vrcplayer_0));
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0006E5C0 File Offset: 0x0006C7C0
		internal static bool smethod_948(Vector3 vector3_0, Vector3 vector3_1, out Vector3 vector3_2)
		{
			Ray ray;
			ray..ctor(vector3_0, vector3_1);
			RaycastHit raycastHit;
			bool result;
			if (Physics.Raycast(ray, ref raycastHit))
			{
				vector3_2 = raycastHit.point;
				result = true;
			}
			else
			{
				vector3_2 = default(Vector3);
				result = false;
			}
			return result;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0006E5FC File Offset: 0x0006C7FC
		internal static Texture2D smethod_949(Texture2D texture2D_0, Texture2D texture2D_1, bool bool_10 = false, bool bool_11 = false)
		{
			int width = texture2D_0.width;
			int height = texture2D_0.height;
			int width2 = texture2D_1.width;
			int height2 = texture2D_1.height;
			int num = GClass84.smethod_1690(width, width2);
			int num2 = GClass84.smethod_1690(height, height2);
			bool flag = false;
			if (width != num || height != num2)
			{
				texture2D_0 = GClass84.smethod_1516(texture2D_0, num, num2);
			}
			if (width2 != num || height2 != num2)
			{
				texture2D_1 = GClass84.smethod_1516(texture2D_1, num, num2);
				flag = true;
			}
			Color[] array = texture2D_0.GetPixels();
			Color[] array2 = texture2D_1.GetPixels();
			int num3 = array.Length;
			for (int i = 0; i < num3; i++)
			{
				if (bool_11)
				{
					if (array2[i].a == 0f)
					{
						array[i].a = 0f;
					}
					else
					{
						array[i].a = 1f;
					}
				}
				else
				{
					array[i].a = array2[i].a;
				}
			}
			texture2D_0.SetPixels(array);
			texture2D_0.Apply();
			if (bool_10 && (width != num || height != num2))
			{
				Texture2D texture2D = texture2D_0;
				texture2D_0 = GClass84.smethod_1516(texture2D_0, width, height);
				Object.DestroyImmediate(texture2D, true);
			}
			if (flag)
			{
				Object.DestroyImmediate(texture2D_1, true);
			}
			return texture2D_0;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0006E75C File Offset: 0x0006C95C
		internal static PageUserInfo smethod_950()
		{
			GameObject gameObject = GClass84.smethod_1270();
			return (gameObject != null) ? gameObject.GetComponentInChildren<PageUserInfo>() : null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0006E77C File Offset: 0x0006C97C
		internal static List<Cloth> smethod_951(Transform transform_0)
		{
			List<Cloth> result;
			if (!transform_0)
			{
				result = new List<Cloth>();
			}
			else
			{
				List<Cloth> list = transform_0.GetComponents<Cloth>().ToList<Cloth>();
				list.AddRange(transform_0.GetComponentsInChildren<Cloth>(true));
				result = list.Distinct<Cloth>().ToList<Cloth>();
			}
			return result;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0006E7C4 File Offset: 0x0006C9C4
		internal static void smethod_952(Type type_0)
		{
			if (!(type_0 == null))
			{
				GClass70.smethod_24(type_0.Name, GClass70.Enum1.const_0);
				GClass70.smethod_24("{", GClass70.Enum1.const_0);
				GClass84.smethod_41(type_0).ToList<MethodInfo>().ForEach(new Action<MethodInfo>(GClass84.Class101.class101_0.method_11));
				GClass70.smethod_24("}", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0006E82C File Offset: 0x0006CA2C
		internal static void smethod_953(float float_3)
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			if (locomotionInputController)
			{
				locomotionInputController.field_Public_Single_3 = float_3;
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0006E854 File Offset: 0x0006CA54
		internal static void smethod_954(float float_3)
		{
			USpeaker.field_Internal_Static_Single_1 = float_3;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0006E868 File Offset: 0x0006CA68
		internal static void smethod_955(ApiWorld apiWorld_0, PageWorldInfo pageWorldInfo_0)
		{
			GClass84.smethod_365(apiWorld_0, pageWorldInfo_0);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0006E87C File Offset: 0x0006CA7C
		internal static string smethod_956(byte[] byte_0, bool bool_10)
		{
			return GClass84.smethod_318(byte_0, bool_10);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0006E8D0 File Offset: 0x0006CAD0
		internal static int smethod_957(string string_4, string string_5, int int_1, int int_2)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty || GClass84.smethod_593(string_4) < int_1 || int_2 < 1)
			{
				result = -1;
			}
			else
			{
				if (int_1 + int_2 > GClass84.smethod_593(string_4))
				{
					int_2 = GClass84.smethod_593(string_4) - int_1;
				}
				result = string_4.IndexOf(string_5, int_1, int_2);
			}
			return result;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0006E930 File Offset: 0x0006CB30
		internal static APIUser smethod_958(VRCPlayerApi vrcplayerApi_0)
		{
			return GClass84.smethod_518(GClass84.smethod_831(vrcplayerApi_0));
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0006E94C File Offset: 0x0006CB4C
		internal static void smethod_959(Component component_0)
		{
			GClass84.smethod_1739(component_0);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0006E960 File Offset: 0x0006CB60
		internal static string smethod_960(string string_4, int int_1, int int_2)
		{
			return GClass84.smethod_1452(string_4, int_1, int_2);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0006E978 File Offset: 0x0006CB78
		internal static void smethod_961()
		{
			GClass84.smethod_168();
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0006E98C File Offset: 0x0006CB8C
		internal static void smethod_962()
		{
			GClass84.smethod_143();
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		internal static bool smethod_963(Transform transform_0)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				Camera main = Camera.main;
				result = (main && GClass84.smethod_217(main.transform, transform_0.position));
			}
			return result;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
		internal static bool smethod_964(List<Transform> list_51)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_785(list_51[i]))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0006EA28 File Offset: 0x0006CC28
		internal static int smethod_965()
		{
			return GClass84.list_48.Count;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0006EA44 File Offset: 0x0006CC44
		internal static AvatarPerformanceStats smethod_966(VRCAvatarManager vrcavatarManager_0)
		{
			return (vrcavatarManager_0 != null) ? vrcavatarManager_0.Method_Public_get_AvatarPerformanceStats_0() : null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0006EA60 File Offset: 0x0006CC60
		internal static void smethod_967(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_980(vrcplayer_0);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0006EA74 File Offset: 0x0006CC74
		internal static Player smethod_968(GameObject gameObject_39)
		{
			GClass84.Class104 @class = new GClass84.Class104();
			@class.gameObject_0 = gameObject_39;
			Player result;
			if (!@class.gameObject_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1677().Where(new Func<Player, bool>(@class.method_0)).FirstOrDefault<Player>();
			}
			return result;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0006EAC0 File Offset: 0x0006CCC0
		internal static GameObject smethod_969(VRCPlayerApi vrcplayerApi_0)
		{
			GameObject result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_233(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0006EAE4 File Offset: 0x0006CCE4
		internal static bool smethod_970(string string_4, Type type_0, string string_5, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			GClass84.Class108 @class = new GClass84.Class108();
			@class.string_0 = string_5;
			bool flag = false;
			List<MethodInfo> list = type_0.GetMethods().ToList<MethodInfo>();
			Predicate<MethodInfo> match;
			if ((match = @class.predicate_0) == null)
			{
				match = (@class.predicate_0 = new Predicate<MethodInfo>(@class.method_0));
			}
			foreach (MethodInfo methodInfo in list.FindAll(match))
			{
				if (GClass84.smethod_1123(string_4, methodInfo, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
				{
					flag = true;
				}
				else
				{
					string text = "Null";
					string text2 = @class.string_0;
					string text3 = "Null";
					string text4 = "Null";
					string text5 = "Null";
					if (type_0 != null)
					{
						text = type_0.Name;
					}
					if (harmonyMethod_0 != null)
					{
						text3 = harmonyMethod_0.methodName;
					}
					if (harmonyMethod_1 != null)
					{
						text4 = harmonyMethod_1.methodName;
					}
					if (harmonyMethod_2 != null)
					{
						text5 = harmonyMethod_2.methodName;
					}
					GClass70.smethod_109(string.Concat(new string[]
					{
						"Can",
						"'",
						"t",
						" ",
						"Patch",
						" ",
						"Method",
						" \"",
						methodInfo.Name,
						"\"",
						" (",
						string_4,
						", ",
						text,
						", ",
						text2,
						", ",
						text3,
						", ",
						text4,
						", ",
						text5,
						")"
					}), GClass70.Enum1.const_0);
				}
			}
			if (!flag)
			{
				string text6 = "Null";
				string text7 = @class.string_0;
				string text8 = "Null";
				string text9 = "Null";
				string text10 = "Null";
				if (type_0 != null)
				{
					text6 = type_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text8 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text9 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text10 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Methods",
					" ",
					"Start",
					" ",
					"With",
					" (",
					string_4,
					", ",
					text6,
					", ",
					text7,
					", ",
					text8,
					", ",
					text9,
					", ",
					text10,
					")"
				}), GClass70.Enum1.const_0);
			}
			return flag;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0006EE00 File Offset: 0x0006D000
		internal static void smethod_971(Player player_0)
		{
			GClass84.smethod_780(player_0);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0006EE14 File Offset: 0x0006D014
		internal static void smethod_972(string string_4, string string_5, string string_6, NotificationDetails notificationDetails_0)
		{
			GClass84.smethod_161(string_4, string_5, string_6, notificationDetails_0);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0006EE2C File Offset: 0x0006D02C
		internal static string smethod_973(string string_4, string string_5, string string_6, bool bool_10)
		{
			string result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = string_4;
			}
			else if (!bool_10)
			{
				string_5 = GClass84.smethod_362(string_5);
				string text = string_4;
				string_4 = string.Empty;
				int num;
				if (!bool_10)
				{
					num = GClass84.smethod_1611(GClass84.smethod_362(text), string_5);
				}
				else
				{
					num = GClass84.smethod_1611(text, string_5);
				}
				while (num != -1)
				{
					string_4 = string_4 + GClass84.smethod_1428(text, num) + string_6;
					text = GClass84.smethod_1204(text, num + GClass84.smethod_593(string_5), -1);
					if (!bool_10)
					{
						num = GClass84.smethod_1611(GClass84.smethod_362(text), string_5);
					}
					else
					{
						num = GClass84.smethod_1611(text, string_5);
					}
				}
				string_4 = (result = string_4 + text);
			}
			else
			{
				result = string_4.Replace(string_5, string_6);
			}
			return result;
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0006EEF4 File Offset: 0x0006D0F4
		internal static string smethod_974()
		{
			return "UserInterface/MenuContent/Screens/Settings";
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0006EF08 File Offset: 0x0006D108
		internal static T smethod_975<T>(T gparam_0, Transform transform_0) where T : Object
		{
			return gparam_0 ? Object.Instantiate<T>(gparam_0, transform_0) : default(T);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0006EF38 File Offset: 0x0006D138
		internal static void smethod_976(string string_4)
		{
			GClass84.smethod_38(string_4);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0006EF4C File Offset: 0x0006D14C
		internal static string smethod_977(VRCPlayerApi vrcplayerApi_0, string string_4 = "")
		{
			return GClass84.smethod_1558(vrcplayerApi_0, string_4);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0006EF60 File Offset: 0x0006D160
		internal static void smethod_978(Color color_0, string string_4)
		{
			VRCUiManager vrcuiManager = GClass84.smethod_102();
			if (vrcuiManager)
			{
				vrcuiManager.field_Public_Text_0.color = color_0;
				vrcuiManager.Method_Public_Void_String_PDM_0(string_4);
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0006EF90 File Offset: 0x0006D190
		internal static string smethod_979()
		{
			return GClass84.smethod_837();
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		internal static void smethod_980(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_1655(vrcplayer_0);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0006EFB8 File Offset: 0x0006D1B8
		internal static Transform smethod_981()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.transform : null;
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
		internal static void smethod_982(PlayerNet playerNet_0)
		{
			GClass84.smethod_1028(GClass84.smethod_800(playerNet_0));
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
		internal static void smethod_983(Mesh mesh_0)
		{
			GClass84.smethod_336(mesh_0);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0006F004 File Offset: 0x0006D204
		internal static void smethod_984(GameObject gameObject_39)
		{
			GClass84.smethod_1689(gameObject_39);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0006F018 File Offset: 0x0006D218
		internal static long smethod_985()
		{
			return (long)(1000000000.0 * (double)Stopwatch.GetTimestamp() / (double)Stopwatch.Frequency);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0006F040 File Offset: 0x0006D240
		internal static bool smethod_986(UdonBehaviour udonBehaviour_0, string string_4, bool bool_10 = false)
		{
			bool result;
			if (!udonBehaviour_0)
			{
				result = false;
			}
			else
			{
				if (!bool_10 && string_4.StartsWith("_"))
				{
					GClass70.smethod_38("Events starting with _ are non-networkable.", GClass70.Enum1.const_0);
				}
				List<string> list = GClass84.smethod_16(udonBehaviour_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i] == string_4)
					{
						udonBehaviour_0.SendCustomNetworkEvent(0, string_4);
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0006F0BC File Offset: 0x0006D2BC
		internal static void smethod_987(bool bool_10)
		{
			GClass84.smethod_248(bool_10);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		internal static Type[] smethod_988(Assembly[] assembly_0)
		{
			return GClass84.smethod_671(assembly_0).ToArray();
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0006F0EC File Offset: 0x0006D2EC
		internal static void smethod_989(Text text_1)
		{
			if (text_1)
			{
				RectTransform component = text_1.GetComponent<RectTransform>();
				if (component)
				{
					Vector2 vector = component.anchorMin;
					vector.y = 0.5f;
					component.anchorMin = vector;
					vector = component.anchorMax;
					vector.y = 0.5f;
					component.anchorMax = vector;
					vector = component.offsetMin;
					vector.x = 0f;
					vector.y = -26.9f;
					component.offsetMin = vector;
					vector = component.offsetMax;
					vector.x = 0f;
					vector.y = 26.9f;
					component.offsetMax = vector;
					Vector3 anchoredPosition3D = component.anchoredPosition3D;
					anchoredPosition3D.x = 0f;
					anchoredPosition3D.y = 0f;
					component.anchoredPosition3D = anchoredPosition3D;
				}
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0006F1C4 File Offset: 0x0006D3C4
		internal static Transform smethod_990()
		{
			GameObject gameObject = GClass84.smethod_1649();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
		internal static string smethod_991(string string_4, string string_5)
		{
			return GClass84.smethod_1532(string_4, string_5);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		internal static void smethod_992(GClass52 gclass52_1)
		{
			GClass84.smethod_1749(gclass52_1);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0006F20C File Offset: 0x0006D40C
		internal static string smethod_993(Player player_0)
		{
			string result;
			if (!player_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_653(GClass84.smethod_518(player_0));
			}
			return result;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0006F23C File Offset: 0x0006D43C
		internal static bool smethod_994(GameObject gameObject_39)
		{
			bool result;
			if (!gameObject_39 || gameObject_39 == GClass84.smethod_461())
			{
				result = false;
			}
			else
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
				if (vrcplayerApi != null)
				{
					vrcplayerApi.TakeOwnership(gameObject_39);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0006F280 File Offset: 0x0006D480
		internal static void smethod_995(GameObject gameObject_39, Color color_0)
		{
			GClass84.smethod_1723(gameObject_39, color_0);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0006F294 File Offset: 0x0006D494
		internal static Color smethod_996(PlayerNet playerNet_0, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_204(GClass84.smethod_782(playerNet_0), bool_10, bool_11, bool_12);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0006F2B4 File Offset: 0x0006D4B4
		internal static void smethod_997(UiAvatarList uiAvatarList_0)
		{
			if (uiAvatarList_0)
			{
				GClass84.smethod_117(uiAvatarList_0);
				uiAvatarList_0.scrollRect.movementType = 1;
				uiAvatarList_0.pickers.Clear();
				Transform transform = uiAvatarList_0.transform.Find("ViewPort/Content");
				if (transform)
				{
					List<GameObject> list = GClass84.smethod_266(transform);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						Object.DestroyImmediate(list[i], true);
					}
				}
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006F334 File Offset: 0x0006D534
		internal static Texture2D smethod_998(string string_4)
		{
			return GClass84.smethod_1410(GClass84.smethod_1738(string_4));
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006F350 File Offset: 0x0006D550
		internal static void smethod_999()
		{
			GClass84.smethod_596();
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006F364 File Offset: 0x0006D564
		internal static void smethod_1000()
		{
			GClass84.smethod_345();
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006F378 File Offset: 0x0006D578
		internal static void smethod_1001(List<GameObject> list_51, Transform transform_0)
		{
			GClass84.smethod_874(list_51, transform_0);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006F38C File Offset: 0x0006D58C
		internal static bool smethod_1002()
		{
			bool result = false;
			List<GameObject> list = GClass84.smethod_589();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (GClass84.smethod_994(list[i]))
				{
					list[i].transform.position = new Vector3(0f, -1E+07f, 0f);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0006F3F0 File Offset: 0x0006D5F0
		internal static List<GClass84.GStruct163> smethod_1003(int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			List<GClass84.GStruct163> list = GClass84.smethod_900(int_1, int_2, int_3, int_4, int_5);
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_5);
			GClass84.GStruct163 gstruct2 = GClass84.smethod_50(int_1, int_2, int_3, (int_5 + int_4) % 360);
			List<GClass84.GStruct163> result;
			if (GClass84.GStruct163.smethod_0(gstruct, gstruct2))
			{
				result = list;
			}
			else
			{
				list.AddRange(GClass84.smethod_1698(int_1, int_2, gstruct.int_0, gstruct.int_1));
				list.AddRange(GClass84.smethod_1698(int_1, int_2, gstruct2.int_0, gstruct2.int_1));
				result = list;
			}
			return result;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0006F46C File Offset: 0x0006D66C
		internal static void smethod_1004(string string_4, int int_1)
		{
			GClass84.smethod_344(string_4, int_1);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0006F480 File Offset: 0x0006D680
		internal static void smethod_1005(IUser iuser_0)
		{
			GClass84.smethod_186(iuser_0);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0006F494 File Offset: 0x0006D694
		internal static string smethod_1006(string string_4, int int_1)
		{
			return GClass84.smethod_227(string_4, int_1);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
		internal static void smethod_1007(float float_3, float float_4)
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			if (locomotionInputController)
			{
				locomotionInputController.field_Public_Single_2 = float_3;
				locomotionInputController.field_Public_Single_1 = float_3;
				locomotionInputController.field_Public_Single_0 = float_4;
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0006F4DC File Offset: 0x0006D6DC
		internal static void smethod_1008(PortalInternal portalInternal_0, float float_3)
		{
			GClass84.smethod_563(portalInternal_0, 30f - float_3);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		internal static void smethod_1009(UiAvatarList uiAvatarList_0)
		{
			GClass84.smethod_997(uiAvatarList_0);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0006F50C File Offset: 0x0006D70C
		internal static Player smethod_1010()
		{
			return Player.Method_Internal_Static_get_Player_0();
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0006F520 File Offset: 0x0006D720
		internal static GClass84.GStruct163 smethod_1011(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			GClass84.GStruct163 gstruct = new GClass84.GStruct163(int_1, int_2 - int_3);
			GClass84.GStruct163 result;
			if (int_4 <= 0)
			{
				result = gstruct;
			}
			else
			{
				int i = int_3;
				int num7 = 1 - 2 * int_3;
				float num8 = GClass84.smethod_1480((float)int_4);
				if (int_4 < 90)
				{
					num3 = (float)Math.Cos(1.5707963267948966 - (double)num8) * (float)int_3;
					num4 = (float)Math.Sin(1.5707963267948966 - (double)num8) * (float)int_3;
				}
				if (int_4 > 90)
				{
					num5 = (float)Math.Cos(7.8539816339744828 - (double)num8) * (float)int_3;
					num6 = (float)Math.Sin(7.8539816339744828 - (double)num8) * (float)int_3;
				}
				while (i >= 0)
				{
					if (int_4 >= 90)
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_5, int_5);
						if (num2 == 0 && !flag2)
						{
							gstruct.int_0 = int_1 + num;
							gstruct.int_1 = int_2 - i;
						}
					}
					else if ((int_4 <= 45 && (float)num <= num3) || (int_4 > 45 && (float)i >= num4))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_5, int_5);
						gstruct.int_0 = int_1 + num;
						gstruct.int_1 = int_2 - i;
						num2 = 1;
					}
					if (int_4 > 90)
					{
						if (int_4 >= 180)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_5, int_5);
							if (num2 == 0 && (int_4 == 180 && !flag2))
							{
								gstruct.int_0 = int_1 + num;
								gstruct.int_1 = int_2 + i;
								flag2 = true;
							}
						}
						else if ((int_4 <= 135 && (float)i <= -num6) || (int_4 > 135 && (float)num >= num5))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_5, int_5);
							if (!flag)
							{
								gstruct.int_0 = int_1 + num;
								gstruct.int_1 = int_2 + i;
								flag = true;
								num2 = 2;
							}
						}
					}
					if (int_4 > 180)
					{
						if (int_4 >= 270)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_5, int_5);
							if (num2 == 0 && !flag2)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 + i;
							}
						}
						else if ((int_4 <= 225 && (float)num <= -num5) || (int_4 > 225 && (float)i >= -num6))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_5, int_5);
							gstruct.int_0 = int_1 - num;
							gstruct.int_1 = int_2 + i;
							num2 = 3;
						}
					}
					if (int_4 > 270)
					{
						if (int_4 >= 360)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_5, int_5);
							if (num2 == 0 && (int_4 == 360 && !flag2))
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 - i;
								flag2 = true;
							}
						}
						else if ((int_4 <= 315 && (float)i <= num6) || (int_4 > 315 && (float)num >= -num5))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_5, int_5);
							if (!flag)
							{
								gstruct.int_0 = int_1 - num;
								gstruct.int_1 = int_2 - i;
								flag = true;
								num2 = 4;
							}
						}
					}
					int num9 = 2 * (num7 + i) - 1;
					if (num7 < 0 && num9 <= 0)
					{
						num7 += 2 * ++num + 1;
					}
					else if (num7 > 0 && num9 > 0)
					{
						num7 -= 2 * --i + 1;
					}
					else
					{
						num7 += 2 * (++num - i--);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0006F93C File Offset: 0x0006DB3C
		internal static void smethod_1012(List<GameObject> list_51, Transform transform_0)
		{
			for (int i = 0; i < list_51.Count; i++)
			{
				if (list_51[i])
				{
					list_51[i].transform.SetParent(transform_0);
				}
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0006F97C File Offset: 0x0006DB7C
		internal static string smethod_1013<T>(int int_1)
		{
			return Enum.GetName(typeof(T), int_1);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0006F9A0 File Offset: 0x0006DBA0
		internal static bool smethod_1014(Player player_0)
		{
			return player_0 && GClass84.smethod_1511(GClass84.smethod_518(player_0));
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0006F9CC File Offset: 0x0006DBCC
		internal static GameObject smethod_1015(GClass156 gclass156_1, float float_3, float float_4, int int_1, int int_2)
		{
			return gclass156_1.method_125(float_3, float_4, int_1, int_2, GClass156.Enum10.const_1);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0006F9E8 File Offset: 0x0006DBE8
		internal static void smethod_1016(Player player_0)
		{
			if (player_0)
			{
				VRCPlayer vrcplayer_ = GClass84.smethod_367(player_0);
				APIUser apiuser_ = GClass84.smethod_518(player_0);
				try
				{
					GClass84.smethod_383(apiuser_);
					GClass84.smethod_967(vrcplayer_);
					GClass70.smethod_38(string.Concat(new string[]
					{
						GClass84.smethod_828(apiuser_, ""),
						" has ",
						"ID",
						" ",
						GClass84.smethod_1520(apiuser_)
					}), GClass70.Enum1.const_0);
					GClass70.smethod_38(string.Concat(new string[]
					{
						GClass84.smethod_828(apiuser_, ""),
						" has ",
						"Steam",
						" ",
						"ID",
						" ",
						GClass84.smethod_534(vrcplayer_).ToString()
					}), GClass70.Enum1.const_0);
					GClass70.smethod_38(string.Concat(new string[]
					{
						GClass84.smethod_828(apiuser_, ""),
						" has ",
						"User",
						" ",
						"ID",
						" ",
						GClass84.smethod_385(vrcplayer_).ToString()
					}), GClass70.Enum1.const_0);
					GClass70.smethod_38(string.Concat(new string[]
					{
						GClass84.smethod_828(apiuser_, ""),
						" has ",
						"IP",
						" ",
						GClass84.smethod_1196(vrcplayer_)
					}), GClass70.Enum1.const_0);
				}
				catch (Exception ex)
				{
					GClass70.smethod_38(ex.Message, GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0006FB7C File Offset: 0x0006DD7C
		internal static float smethod_1017(float float_3)
		{
			return (float)((double)(float_3 * 180f) / 3.1415926535897931);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0006FBA0 File Offset: 0x0006DDA0
		internal static Transform smethod_1018()
		{
			GameObject gameObject = GClass84.smethod_279();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0006FBC0 File Offset: 0x0006DDC0
		internal static bool smethod_1019(List<UdonBehaviour> list_51, string string_4)
		{
			bool result = false;
			for (int i = 0; i < list_51.Count; i++)
			{
				if (GClass84.smethod_986(list_51[i], string_4, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0006FBF8 File Offset: 0x0006DDF8
		internal static List<Transform> smethod_1020(Scene scene_0)
		{
			List<Transform> list = new List<Transform>();
			List<GameObject> list2 = GClass84.smethod_579(scene_0);
			for (int i = 0; i < list2.Count; i++)
			{
				Transform transform = list2[i].transform;
				if (transform)
				{
					list.Add(transform);
				}
			}
			return list;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006FC4C File Offset: 0x0006DE4C
		internal static void smethod_1021(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_422(vrcplayerApi_0);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0006FC60 File Offset: 0x0006DE60
		internal static bool smethod_1022(Transform transform_0, Transform transform_1, bool bool_10 = false, bool bool_11 = false)
		{
			bool result;
			if (!transform_0 || !transform_1)
			{
				result = false;
			}
			else
			{
				if (bool_11)
				{
					List<GameObject> list = GClass84.smethod_266(transform_1);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						GClass84.smethod_890(list[i], false);
					}
				}
				List<Transform> list2 = GClass84.smethod_403(transform_0);
				for (int j = list2.Count - 1; j >= 0; j--)
				{
					list2[j].SetParent(transform_1, bool_10);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0006FCF4 File Offset: 0x0006DEF4
		internal static void smethod_1023(PortalInternal portalInternal_0, float float_3)
		{
			GClass84.smethod_1008(portalInternal_0, float_3);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0006FD08 File Offset: 0x0006DF08
		internal static void smethod_1024()
		{
			GClass84.smethod_1628();
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0006FD1C File Offset: 0x0006DF1C
		internal static Transform smethod_1025()
		{
			GameObject gameObject = GClass84.smethod_229();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006FD3C File Offset: 0x0006DF3C
		internal static float smethod_1026()
		{
			return (float)Random.Range(0, 1000000000) / 1E+09f;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0006FD60 File Offset: 0x0006DF60
		internal static IEnumerator smethod_1027(ApiAvatar apiAvatar_0, VRCPlayer vrcplayer_0)
		{
			GClass84.Class102 @class = new GClass84.Class102(0);
			@class.apiAvatar_0 = apiAvatar_0;
			@class.vrcplayer_0 = vrcplayer_0;
			return @class;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0006FD84 File Offset: 0x0006DF84
		internal static void smethod_1028(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_185(vrcplayer_0);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0006FD98 File Offset: 0x0006DF98
		internal static bool smethod_1029(List<GameObject> list_51)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_994(list_51[i]))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0006FDDC File Offset: 0x0006DFDC
		internal static List<Transform> smethod_1030(GameObject gameObject_39, List<Transform> list_51)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				if (list_51 == null || list_51.Count == 0)
				{
					GClass84.smethod_395(gameObject_39);
				}
				result = GClass84.smethod_805(gameObject_39.transform, list_51);
			}
			return result;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0006FE24 File Offset: 0x0006E024
		internal static void smethod_1031(string string_4)
		{
			PageUserInfo pageUserInfo = GClass84.smethod_950();
			pageUserInfo.field_Private_APIUser_0 = new APIUser
			{
				id = string_4
			};
			if (pageUserInfo.field_Private_APIUser_0.id != GClass84.smethod_1372().id)
			{
				pageUserInfo.ToggleBlock();
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0006FE6C File Offset: 0x0006E06C
		internal static Object smethod_1032(byte[] byte_0)
		{
			Il2CppStructArray<byte> il2CppStructArray = new Il2CppStructArray<byte>((long)byte_0.Length);
			byte_0.CopyTo(il2CppStructArray, 0);
			Object @object = new Object(il2CppStructArray.Pointer);
			return new Object(@object.Pointer);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006FEAC File Offset: 0x0006E0AC
		internal static bool smethod_1033(Material material_1)
		{
			bool result;
			if (!material_1)
			{
				result = false;
			}
			else if (material_1.mainTexture)
			{
				result = false;
			}
			else
			{
				Il2CppStructArray<int> texturePropertyNameIDs = material_1.GetTexturePropertyNameIDs();
				for (int i = 0; i < texturePropertyNameIDs.Count; i++)
				{
					Texture texture = material_1.GetTexture(texturePropertyNameIDs[i]);
					if (texture)
					{
						material_1.mainTexture = texture;
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0006FF20 File Offset: 0x0006E120
		internal static GameObject[] smethod_1034(GameObject gameObject_39)
		{
			GameObject[] result;
			if (!gameObject_39)
			{
				result = new GameObject[0];
			}
			else
			{
				result = GClass84.smethod_1449(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006FF50 File Offset: 0x0006E150
		internal static bool smethod_1035(GameObject gameObject_39, Transform transform_0, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			return gameObject_39 && transform_0 && GClass84.smethod_535(gameObject_39, GClass84.smethod_272(transform_0, genum47_0), bool_10);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005CE4C File Offset: 0x0005B04C
		internal static Transform smethod_1036(PlayerNet playerNet_0)
		{
			Transform result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_662(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0006FF88 File Offset: 0x0006E188
		internal static void smethod_1037()
		{
			if (!GClass84.gameObject_0 || !GClass84.text_0 || !GClass84.gameObject_1)
			{
				GameObject gameObject = GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/AlertTextParent");
				if (gameObject)
				{
					GClass84.gameObject_0 = Object.Instantiate<GameObject>(gameObject, gameObject.transform.parent);
					GClass84.text_0 = GClass84.gameObject_0.GetComponentInChildren<Text>();
					if (GClass84.text_0)
					{
						GClass84.gameObject_1 = GClass84.text_0.gameObject;
					}
				}
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00070010 File Offset: 0x0006E210
		internal static void smethod_1038(Slider slider_0)
		{
			GClass84.smethod_137(slider_0);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00070024 File Offset: 0x0006E224
		internal static GameObject smethod_1039(Transform transform_0, List<string> list_51)
		{
			Transform transform = GClass84.smethod_836(transform_0, list_51);
			return (transform != null) ? transform.gameObject : null;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00070048 File Offset: 0x0006E248
		internal static bool smethod_1040(List<Transform> list_51, Vector3 vector3_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_293(list_51[i], vector3_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00070090 File Offset: 0x0006E290
		internal static Color smethod_1041(bool bool_10)
		{
			Color result;
			if (bool_10)
			{
				result = Color.green;
			}
			else
			{
				result = Color.blue;
			}
			return result;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000700B0 File Offset: 0x0006E2B0
		internal static Color smethod_1042(Color color_0, float float_3, float float_4)
		{
			color_0.r = GClass84.smethod_415(color_0.r, 0f, 1f);
			color_0.g = GClass84.smethod_415(color_0.g, 0f, 1f);
			color_0.b = GClass84.smethod_415(color_0.b, 0f, 1f);
			color_0.a = GClass84.smethod_415(color_0.a, 0f, 1f);
			return color_0;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00070130 File Offset: 0x0006E330
		internal static Color smethod_1043(VRCPlayer vrcplayer_0, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_204(GClass84.smethod_856(vrcplayer_0), bool_10, bool_11, bool_12);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00070150 File Offset: 0x0006E350
		internal static Color smethod_1044(Color color_0)
		{
			Color result;
			if (GClass84.smethod_15(color_0))
			{
				result = color_0;
			}
			else
			{
				if (color_0.r > color_0.g)
				{
					if (color_0.r > color_0.b)
					{
						color_0.g = color_0.r;
						color_0.b = color_0.r;
					}
				}
				else if (color_0.g > color_0.b)
				{
					color_0.r = color_0.g;
					color_0.b = color_0.g;
				}
				else
				{
					color_0.r = color_0.b;
					color_0.g = color_0.b;
				}
				result = color_0;
			}
			return result;
		}

		// Token: 0x060014EE RID: 5358
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindow(string string_4, string string_5);

		// Token: 0x060014EF RID: 5359 RVA: 0x000701F4 File Offset: 0x0006E3F4
		internal static bool smethod_1045(Player player_0)
		{
			return GClass84.smethod_1725(player_0) && !GClass84.smethod_1663(player_0);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00070218 File Offset: 0x0006E418
		internal static void smethod_1046(string string_4, Action action_0, Action action_1, Action action_2)
		{
			GClass84.Class114 @class = new GClass84.Class114();
			@class.action_0 = action_1;
			@class.action_1 = action_2;
			@class.action_2 = action_0;
			if (!GClass84.smethod_334(string_4))
			{
				GClass84.smethod_39(true);
				if (GClass84.smethod_1311(string_4))
				{
					APIUser.FetchUser(string_4, new Action<APIUser>(@class.method_0), null);
				}
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00070274 File Offset: 0x0006E474
		internal static void smethod_1047(float float_3)
		{
			GClass84.smethod_127(float_3);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00070288 File Offset: 0x0006E488
		internal static bool smethod_1048(string string_4)
		{
			return GClass84.smethod_1138(Object.FindObjectsOfType<VRC_Trigger>().ToList<VRC_Trigger>(), string_4);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000702A8 File Offset: 0x0006E4A8
		internal static void smethod_1049(string string_4, List<string> list_51)
		{
			GClass84.smethod_167(string_4, list_51);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000702BC File Offset: 0x0006E4BC
		internal static void smethod_1050(string string_4, bool bool_10 = true)
		{
			GClass84.smethod_1481(string_4, bool_10);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000702D0 File Offset: 0x0006E4D0
		internal static List<GameObject> smethod_1051()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<VRC_MirrorReflection>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0007032C File Offset: 0x0006E52C
		internal static string smethod_1052()
		{
			return string.Empty;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00070340 File Offset: 0x0006E540
		internal static int smethod_1053(string string_4, string string_5, int int_1, int int_2)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = -1;
			}
			else
			{
				int_1 = GClass84.smethod_593(string_4) - 1 - int_1;
				int num = GClass84.smethod_593(string_5) - 1;
				int_2 = GClass84.smethod_741(int_2, GClass84.smethod_593(string_4));
				while (int_1 >= int_2)
				{
					if (string_4[int_1] == string_5[num])
					{
						if (num == 0)
						{
							return int_1 - num;
						}
						num--;
					}
					else
					{
						num = GClass84.smethod_593(string_5) - 1;
					}
					int_1--;
				}
				result = -1;
			}
			return result;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000703D4 File Offset: 0x0006E5D4
		internal static void smethod_1054(Vector2 vector2_0, Vector2 vector2_1, Color color_0)
		{
			GClass84.smethod_1319(vector2_0, vector2_1, color_0);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000703EC File Offset: 0x0006E5EC
		internal static string smethod_1055(VRCPlayer vrcplayer_0)
		{
			string result;
			if (!vrcplayer_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_653(GClass84.smethod_856(vrcplayer_0));
			}
			return result;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0007041C File Offset: 0x0006E61C
		internal static GameObject smethod_1056(GameObject gameObject_39)
		{
			GameObject result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"_AvatarMirrorClone"
					});
				}
			}
			return result;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0006251C File Offset: 0x0006071C
		internal static Transform smethod_1057(VRCPlayer vrcplayer_0)
		{
			Transform result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1427(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0007047C File Offset: 0x0006E67C
		internal static void smethod_1058(Slider slider_0, UnityAction<float> unityAction_0)
		{
			if (slider_0)
			{
				slider_0.onValueChanged = new Slider.SliderEvent();
				if (unityAction_0 != null)
				{
					slider_0.onValueChanged.AddListener(unityAction_0);
				}
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000704B4 File Offset: 0x0006E6B4
		internal static void smethod_1059(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5 = 0)
		{
			GClass84.smethod_366(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000704D4 File Offset: 0x0006E6D4
		internal static void smethod_1060(string string_4, Vector3 vector3_0)
		{
			GClass84.smethod_54(string_4, vector3_0);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000704E8 File Offset: 0x0006E6E8
		internal static GameObject smethod_1061(GameObject gameObject_39)
		{
			GameObject result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_1039(transform, new List<string>
					{
						"_AvatarShadowClone"
					});
				}
			}
			return result;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00070548 File Offset: 0x0006E748
		internal static void smethod_1062(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_355(apiAvatar_0);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0007055C File Offset: 0x0006E75C
		internal static int smethod_1063()
		{
			PlayerManager playerManager = GClass84.smethod_1472();
			int result;
			if (!playerManager)
			{
				result = 0;
			}
			else
			{
				result = playerManager.field_Private_List_1_Player_0.Count;
			}
			return result;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0007058C File Offset: 0x0006E78C
		internal static string smethod_1064()
		{
			return GClass84.smethod_653(GClass84.smethod_1372());
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000705A8 File Offset: 0x0006E7A8
		internal static void smethod_1065(string string_4, string string_5)
		{
			GClass84.smethod_1533(string_4, string_5);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000705BC File Offset: 0x0006E7BC
		internal static List<GameObject> smethod_1066(GameObject gameObject_39, string string_4)
		{
			List<GameObject> list = new List<GameObject>();
			if (gameObject_39.tag == string_4)
			{
				list.Add(gameObject_39);
			}
			else
			{
				list.AddRange(GClass84.smethod_180(gameObject_39, string_4));
			}
			return list;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000705F8 File Offset: 0x0006E7F8
		internal static byte[] smethod_1067(Object object_0)
		{
			byte[] result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, object_0);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00070630 File Offset: 0x0006E830
		internal static Transform smethod_1068(GameObject gameObject_39)
		{
			Transform result;
			if (!gameObject_39)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(gameObject_39.transform, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_836(transform, new List<string>
					{
						"_AvatarMirrorClone"
					});
				}
			}
			return result;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00070690 File Offset: 0x0006E890
		internal static void smethod_1069(Player player_0)
		{
			GClass84.smethod_848(player_0);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000706A4 File Offset: 0x0006E8A4
		internal static bool Boolean_0
		{
			get
			{
				foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
				{
					if (assembly.GetName().Name == "Nocturnal")
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000706F0 File Offset: 0x0006E8F0
		internal static void smethod_1070(string string_4)
		{
			GClass84.smethod_484(string_4);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00070704 File Offset: 0x0006E904
		internal static void smethod_1071(Player player_0)
		{
			GClass84.smethod_1069(player_0);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00070718 File Offset: 0x0006E918
		internal static void smethod_1072(string string_4, string string_5, string string_6, Action action_0)
		{
			GClass84.smethod_452(string_4, string_5, string_6, action_0);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00070730 File Offset: 0x0006E930
		internal static void smethod_1073(string string_4, List<string> list_51)
		{
			if (!(GClass84.smethod_362(string_4) != GClass84.smethod_362(string.Empty)) && list_51 != null)
			{
				for (int i = 0; i < list_51.Count; i++)
				{
					try
					{
						GClass84.smethod_719(list_51[i]);
					}
					catch (Exception ex)
					{
						GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0007079C File Offset: 0x0006E99C
		internal static void smethod_1074()
		{
			GClass84.smethod_140();
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000707B0 File Offset: 0x0006E9B0
		internal static ApiAvatar smethod_1075(Player player_0)
		{
			return GClass84.smethod_1468(GClass84.smethod_367(player_0));
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000707CC File Offset: 0x0006E9CC
		internal static string smethod_1076(Component component_0, Transform transform_0)
		{
			return GClass84.smethod_1707(component_0, transform_0);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000707E0 File Offset: 0x0006E9E0
		internal static void smethod_1077(GameObject gameObject_39)
		{
			GClass84.smethod_432(gameObject_39);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000707F4 File Offset: 0x0006E9F4
		internal static List<GameObject> smethod_1078(List<Scene> list_51)
		{
			List<GameObject> result;
			if (list_51 == null)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_579(list_51[i]));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00070840 File Offset: 0x0006EA40
		internal static void smethod_1079(Mesh mesh_0, int int_1)
		{
			GClass84.smethod_892(mesh_0, int_1);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00070854 File Offset: 0x0006EA54
		internal static List<MethodInfo> smethod_1080(IEnumerable<Type> ienumerable_0)
		{
			List<MethodInfo> list = new List<MethodInfo>();
			foreach (Type type_ in ienumerable_0)
			{
				list.AddRange(GClass84.smethod_41(type_));
			}
			return list;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000708AC File Offset: 0x0006EAAC
		internal static Assembly[] smethod_1081()
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000708C8 File Offset: 0x0006EAC8
		internal static List<GameObject> smethod_1082(List<Transform> list_51, int int_1)
		{
			List<GameObject> result;
			if (list_51 == null || list_51.Count < 1)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_188(list_51[i], int_1));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00070920 File Offset: 0x0006EB20
		internal static void smethod_1083()
		{
			GClass84.smethod_488();
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00070934 File Offset: 0x0006EB34
		internal static Color smethod_1084(APIUser apiuser_0)
		{
			Color result;
			if (apiuser_0 == null)
			{
				result = new Color(0f, 0f, 0f, 1f);
			}
			else
			{
				result = VRCPlayer.Method_Public_Static_Color_APIUser_0(apiuser_0);
			}
			return result;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0007096C File Offset: 0x0006EB6C
		internal static Transform smethod_1085()
		{
			GameObject gameObject = GClass84.smethod_1624();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0007098C File Offset: 0x0006EB8C
		internal static GameObject smethod_1086()
		{
			if (!GClass84.gameObject_18)
			{
				GClass84.gameObject_18 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingBackground_TealGradient/SkyCube_Baked");
			}
			return GClass84.gameObject_18;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000709C0 File Offset: 0x0006EBC0
		internal static GameObject smethod_1087(GClass156 gclass156_1, float float_3, float float_4)
		{
			return gclass156_1.method_65(float_3, float_4);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000709D8 File Offset: 0x0006EBD8
		internal static List<VRC_PortalMarker> smethod_1088()
		{
			List<VRC_PortalMarker> list = new List<VRC_PortalMarker>();
			List<GameObject> list2 = GClass84.smethod_549(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				VRC_PortalMarker component = list2[i].GetComponent<VRC_PortalMarker>();
				if (component)
				{
					list.Add(component);
				}
				list.AddRange(list2[i].GetComponentsInChildren<VRC_PortalMarker>(true));
			}
			return list;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00070A3C File Offset: 0x0006EC3C
		internal static string smethod_1089(VRCPlayer vrcplayer_0)
		{
			string result;
			if (!vrcplayer_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_1520(GClass84.smethod_856(vrcplayer_0));
			}
			return result;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00070A6C File Offset: 0x0006EC6C
		internal static List<VRC_Interactable> smethod_1090()
		{
			List<VRC_Interactable> list = new List<VRC_Interactable>();
			List<GameObject> list2 = GClass84.smethod_549(false, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				VRC_Interactable component = list2[i].GetComponent<VRC_Interactable>();
				if (component)
				{
					list.Add(component);
				}
				list.AddRange(list2[i].GetComponentsInChildren<VRC_Interactable>(true));
			}
			return list;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00070AD4 File Offset: 0x0006ECD4
		internal static void smethod_1091(float float_3)
		{
			GClass84.smethod_226(float_3);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00070AE8 File Offset: 0x0006ECE8
		internal static void smethod_1092<T>(ref T[] gparam_0, IEqualityComparer<T> iequalityComparer_0)
		{
			if (gparam_0 != null && gparam_0.Length != 0)
			{
				gparam_0 = gparam_0.Distinct(iequalityComparer_0).ToArray<T>();
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00070B14 File Offset: 0x0006ED14
		internal static void smethod_1093()
		{
			GClass84.smethod_526();
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00070B28 File Offset: 0x0006ED28
		internal static byte smethod_1094(byte byte_0, byte byte_1, byte byte_2)
		{
			byte result;
			if (byte_0 < byte_1)
			{
				result = byte_1;
			}
			else if (byte_0 > byte_2)
			{
				result = byte_2;
			}
			else
			{
				result = byte_0;
			}
			return result;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00070B4C File Offset: 0x0006ED4C
		internal static GameObject smethod_1095()
		{
			if (!GClass84.gameObject_25)
			{
				GClass84.gameObject_25 = GameObject.Find("/UserInterface");
			}
			return GClass84.gameObject_25;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00070B80 File Offset: 0x0006ED80
		internal static List<VRC_Trigger.TriggerType> smethod_1096(VRC_Trigger vrc_Trigger_0, bool bool_10 = false)
		{
			List<VRC_Trigger.TriggerType> list = new List<VRC_Trigger.TriggerType>();
			if (vrc_Trigger_0)
			{
				for (int i = 0; i < vrc_Trigger_0.Triggers.Count; i++)
				{
					if (vrc_Trigger_0.Triggers[i].TriggerType > 0)
					{
						list.Add(vrc_Trigger_0.Triggers[i].TriggerType);
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_661<VRC_Trigger.TriggerType>(ref list);
			}
			return list;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00070BF0 File Offset: 0x0006EDF0
		internal static int smethod_1097()
		{
			return DateTime.Now.Millisecond;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x00070C0C File Offset: 0x0006EE0C
		internal static MethodInfo MethodInfo_0
		{
			get
			{
				if (GClass84.methodInfo_4 == null)
				{
					try
					{
						return GClass84.methodInfo_4 = typeof(PortalInternal).GetMethods(BindingFlags.Instance | BindingFlags.Public).Single(new Func<MethodInfo, bool>(GClass84.Class101.class101_0.method_20));
					}
					catch
					{
					}
					if (GClass84.methodInfo_4 == null)
					{
						GClass70.smethod_36("[Debug] Didnt Find Destroy Portal Method!", GClass70.Enum1.const_0);
					}
				}
				return GClass84.methodInfo_4;
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00070C98 File Offset: 0x0006EE98
		internal static void smethod_1098(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_543(apiAvatar_0);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00070CAC File Offset: 0x0006EEAC
		internal static T smethod_1099<T>(T gparam_0, Vector3 vector3_0, Quaternion quaternion_0) where T : Object
		{
			return gparam_0 ? Object.Instantiate<T>(gparam_0, vector3_0, quaternion_0) : default(T);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00070CDC File Offset: 0x0006EEDC
		internal static string smethod_1100(Component component_0, GameObject gameObject_39)
		{
			string result;
			if (!component_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(component_0.transform, (gameObject_39 != null) ? gameObject_39.transform : null);
			}
			return result;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00070D18 File Offset: 0x0006EF18
		internal static string smethod_1101(UdonBehaviour udonBehaviour_0, int int_1)
		{
			int num = 0;
			foreach (KeyValuePair<ValueTuple<string, string>, string> keyValuePair in udonBehaviour_0._symbolNameCache)
			{
				if (num == int_1)
				{
					GClass70.smethod_38(udonBehaviour_0.name, GClass70.Enum1.const_0);
					string value = keyValuePair.value;
					if (value != null)
					{
						GClass70.smethod_38(value, GClass70.Enum1.const_0);
					}
				}
				num++;
			}
			return "<NULL>";
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00070D7C File Offset: 0x0006EF7C
		internal static void smethod_1102(APIUser apiuser_0, Action action_0)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_APIUser_Action_0(apiuser_0, action_0);
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00070D9C File Offset: 0x0006EF9C
		internal static Color smethod_1103(ConsoleColor consoleColor_0)
		{
			Color result;
			switch (consoleColor_0)
			{
			case ConsoleColor.Black:
				result = new Color(0f, 0f, 0f);
				break;
			case ConsoleColor.DarkBlue:
				result = new Color(0f, 0f, 0.5f);
				break;
			case ConsoleColor.DarkGreen:
				result = new Color(0f, 0.5f, 0f);
				break;
			case ConsoleColor.DarkCyan:
				result = new Color(0f, 0.5f, 0.5f);
				break;
			case ConsoleColor.DarkRed:
				result = new Color(0.5f, 0f, 0f);
				break;
			case ConsoleColor.DarkMagenta:
				result = new Color(0.5f, 0f, 0.5f);
				break;
			case ConsoleColor.DarkYellow:
				result = new Color(0.5f, 0.5f, 0f);
				break;
			case ConsoleColor.Gray:
				result = new Color(0.75f, 0.75f, 0.75f);
				break;
			case ConsoleColor.DarkGray:
				result = new Color(0.5f, 0.5f, 0.5f);
				break;
			case ConsoleColor.Blue:
				result = new Color(0f, 0f, 1f);
				break;
			case ConsoleColor.Green:
				result = new Color(0f, 1f, 0f);
				break;
			case ConsoleColor.Cyan:
				result = new Color(0f, 1f, 1f);
				break;
			case ConsoleColor.Red:
				result = new Color(1f, 0f, 0f);
				break;
			case ConsoleColor.Magenta:
				result = new Color(1f, 0f, 1f);
				break;
			case ConsoleColor.Yellow:
				result = new Color(1f, 1f, 0f);
				break;
			case ConsoleColor.White:
				result = new Color(1f, 1f, 1f);
				break;
			default:
				result = new Color(0f, 0f, 0f);
				break;
			}
			return result;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00070F9C File Offset: 0x0006F19C
		internal static void smethod_1104(ApiWorld apiWorld_0, PageWorldInfo pageWorldInfo_0)
		{
			GClass84.smethod_955(apiWorld_0, pageWorldInfo_0);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00070FB0 File Offset: 0x0006F1B0
		internal static List<Transform> smethod_1105(Scene scene_0, string string_4, bool bool_10)
		{
			List<Transform> list = new List<Transform>();
			List<Transform> list2 = GClass84.smethod_1020(scene_0);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].tag == string_4)
				{
					list.Add(list2[i]);
				}
				else if (bool_10)
				{
					list.AddRange(GClass84.smethod_1534(list2[i], string_4));
				}
			}
			return list;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00071020 File Offset: 0x0006F220
		internal static void smethod_1106(Player player_0)
		{
			GClass84.smethod_667(player_0);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00071034 File Offset: 0x0006F234
		internal static void smethod_1107(Type type_0)
		{
			GClass84.smethod_952(type_0);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00071048 File Offset: 0x0006F248
		internal static bool smethod_1108()
		{
			return XRDevice.isPresent;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0007105C File Offset: 0x0006F25C
		internal static void smethod_1109()
		{
			GClass84.smethod_252();
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00071070 File Offset: 0x0006F270
		internal static List<DynamicBoneCollider> smethod_1110(GameObject gameObject_39)
		{
			List<DynamicBoneCollider> result;
			if (!gameObject_39)
			{
				result = new List<DynamicBoneCollider>();
			}
			else
			{
				List<DynamicBoneCollider> list = gameObject_39.GetComponents<DynamicBoneCollider>().ToList<DynamicBoneCollider>();
				list.AddRange(gameObject_39.GetComponentsInChildren<DynamicBoneCollider>(true));
				result = list.Distinct<DynamicBoneCollider>().ToList<DynamicBoneCollider>();
			}
			return result;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000710B8 File Offset: 0x0006F2B8
		internal static Color smethod_1111(Player player_0, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_204(GClass84.smethod_518(player_0), bool_10, bool_11, bool_12);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000710D8 File Offset: 0x0006F2D8
		internal static void smethod_1112(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_1011(gclass156_1, int_1, int_2, int_3, int_4, int_5);
			if (gstruct.int_0 != int_1 || gstruct.int_1 != int_2 - int_3)
			{
				GClass84.smethod_1059(gclass156_1, int_1, int_2, int_1, int_2 - int_3, int_5);
				GClass84.smethod_1059(gclass156_1, int_1, int_2, gstruct.int_0, gstruct.int_1, int_5);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00071130 File Offset: 0x0006F330
		internal static void smethod_1113(UiVRCList uiVRCList_0, float float_3)
		{
			GClass84.smethod_612(uiVRCList_0, float_3);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00071144 File Offset: 0x0006F344
		internal static ApiWorld smethod_1114(PageWorldInfo pageWorldInfo_0)
		{
			return (pageWorldInfo_0 != null) ? pageWorldInfo_0.Method_Public_get_ApiWorld_0() : null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00071160 File Offset: 0x0006F360
		internal static void smethod_1115(float float_3)
		{
			GClass84.smethod_1367(float_3);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00071174 File Offset: 0x0006F374
		internal static string smethod_1116(APIUser apiuser_0)
		{
			return GClass84.smethod_1562(apiuser_0);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00071188 File Offset: 0x0006F388
		internal static void smethod_1117()
		{
			GClass84.smethod_1653();
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0007119C File Offset: 0x0006F39C
		internal static List<GameObject> smethod_1118(GameObject gameObject_39, List<Transform> list_51)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else
			{
				if (list_51 == null || list_51.Count == 0)
				{
					GClass84.smethod_94(gameObject_39);
				}
				result = GClass84.smethod_1423(gameObject_39.transform, list_51);
			}
			return result;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000711E4 File Offset: 0x0006F3E4
		internal static bool smethod_1119(Type type_0, string string_4, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_970("Abyss Client_1.0.0", type_0, string_4, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00071204 File Offset: 0x0006F404
		internal static List<PortalInternal> smethod_1120()
		{
			List<PortalInternal> list = new List<PortalInternal>();
			List<GameObject> list2 = GClass84.smethod_549(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				PortalInternal component = list2[i].GetComponent<PortalInternal>();
				if (component)
				{
					list.Add(component);
				}
				list.AddRange(list2[i].GetComponentsInChildren<PortalInternal>(true));
			}
			return list;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00071268 File Offset: 0x0006F468
		internal static bool smethod_1121(Vector3 vector3_0, Vector3 vector3_1, GClass84.Enum7 enum7_0)
		{
			bool result;
			switch (enum7_0)
			{
			case GClass84.Enum7.const_0:
				result = (vector3_0.x > vector3_1.x || vector3_0.y > vector3_1.y || vector3_0.z > vector3_1.z);
				break;
			case GClass84.Enum7.const_1:
				result = (vector3_0.x > vector3_1.x && vector3_0.y > vector3_1.y && vector3_0.z > vector3_1.z);
				break;
			case GClass84.Enum7.const_2:
				result = (GClass84.smethod_743(vector3_0) > GClass84.smethod_743(vector3_1));
				break;
			case GClass84.Enum7.const_3:
				if (vector3_1.x > 0f)
				{
					if (vector3_0.x < vector3_1.x)
					{
						result = false;
						break;
					}
				}
				else if (vector3_1.x < 0f && vector3_0.x > vector3_1.x)
				{
					result = false;
					break;
				}
				if (vector3_1.y > 0f)
				{
					if (vector3_0.y < vector3_1.y)
					{
						result = false;
						break;
					}
				}
				else if (vector3_1.y < 0f && vector3_0.y > vector3_1.y)
				{
					result = false;
					break;
				}
				if (vector3_1.z > 0f)
				{
					if (vector3_0.z < vector3_1.z)
					{
						result = false;
						break;
					}
				}
				else if (vector3_1.z < 0f && vector3_0.z > vector3_1.z)
				{
					result = false;
					break;
				}
				result = true;
				break;
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00071400 File Offset: 0x0006F600
		internal static ApiAvatar smethod_1122()
		{
			SimpleAvatarPedestal simpleAvatarPedestal = GClass84.smethod_1131();
			return (simpleAvatarPedestal != null) ? simpleAvatarPedestal.field_Internal_ApiAvatar_0 : null;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00071420 File Offset: 0x0006F620
		internal static bool smethod_1123(string string_4, MethodBase methodBase_0, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			try
			{
				Class203.smethod_2(string_4, methodBase_0, harmonyMethod_0, harmonyMethod_1, null);
			}
			catch (Exception ex)
			{
				string text = "Null";
				string text2 = "Null";
				string text3 = "Null";
				string text4 = "Null";
				if (methodBase_0 != null)
				{
					text = methodBase_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text2 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text3 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text4 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Patching",
					" (",
					string_4,
					", ",
					text,
					", ",
					text2,
					", ",
					text3,
					", ",
					text4,
					"): ",
					ex.Message
				}), GClass70.Enum1.const_0);
				return false;
			}
			return true;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00071540 File Offset: 0x0006F740
		internal static void smethod_1124(Player player_0)
		{
			GClass84.smethod_128(player_0);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00071554 File Offset: 0x0006F754
		internal static SelectedUserMenuQM smethod_1125()
		{
			GameObject gameObject = GClass84.smethod_525();
			return (gameObject != null) ? gameObject.GetComponent<SelectedUserMenuQM>() : null;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00071574 File Offset: 0x0006F774
		internal static int smethod_1126()
		{
			return GClass84.list_50.Count;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00071590 File Offset: 0x0006F790
		internal static int smethod_1127(char char_1)
		{
			return (int)char_1;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000715A0 File Offset: 0x0006F7A0
		internal static string smethod_1128(string string_4)
		{
			return GClass84.smethod_1618(string_4);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000715B4 File Offset: 0x0006F7B4
		internal static ConsoleColor smethod_1129(byte byte_0, byte byte_1, byte byte_2)
		{
			ConsoleColor result = ConsoleColor.Black;
			double num = (double)byte_0;
			double num2 = (double)byte_1;
			double num3 = (double)byte_2;
			double num4 = double.MaxValue;
			foreach (object obj in Enum.GetValues(typeof(ConsoleColor)))
			{
				ConsoleColor consoleColor = (ConsoleColor)obj;
				string name = Enum.GetName(typeof(ConsoleColor), consoleColor);
				Color color = Color.FromName((name == "DarkYellow") ? "Orange" : name);
				double num5 = Math.Pow((double)color.R - num, 2.0) + Math.Pow((double)color.G - num2, 2.0) + Math.Pow((double)color.B - num3, 2.0);
				if (num5 == 0.0)
				{
					return consoleColor;
				}
				if (num5 < num4)
				{
					num4 = num5;
					result = consoleColor;
				}
			}
			return result;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000716E0 File Offset: 0x0006F8E0
		internal static Texture2D smethod_1130(int int_1, int int_2)
		{
			return new Texture2D(int_1, int_2);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000716F8 File Offset: 0x0006F8F8
		internal static SimpleAvatarPedestal smethod_1131()
		{
			GameObject gameObject = GClass84.smethod_508();
			return (gameObject != null) ? gameObject.GetComponent<SimpleAvatarPedestal>() : null;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00071718 File Offset: 0x0006F918
		internal static void smethod_1132()
		{
			GClass84.smethod_641();
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0007172C File Offset: 0x0006F92C
		internal static Transform smethod_1133()
		{
			GameObject gameObject = GClass84.smethod_174();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0007174C File Offset: 0x0006F94C
		internal static string smethod_1134(Component component_0, GameObject gameObject_39)
		{
			return GClass84.smethod_1100(component_0, gameObject_39);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00071760 File Offset: 0x0006F960
		internal static List<Transform> smethod_1135(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_524(GClass84.smethod_1556(transform_0));
			}
			return result;
		}

		// Token: 0x0600154C RID: 5452
		[DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_4);

		// Token: 0x0600154D RID: 5453 RVA: 0x00071790 File Offset: 0x0006F990
		internal static bool smethod_1136(Vector3 vector3_0)
		{
			return 2.14748365E+09f < vector3_0.x || 2.14748365E+09f < vector3_0.y || 2.14748365E+09f < vector3_0.z || -2.14748365E+09f > vector3_0.x || -2.14748365E+09f > vector3_0.y || -2.14748365E+09f > vector3_0.z;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000717F0 File Offset: 0x0006F9F0
		internal static GameObject[] smethod_1137(GameObject gameObject_39)
		{
			GameObject[] result;
			if (!gameObject_39)
			{
				result = new GameObject[0];
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					gameObject_39
				};
				list.AddRange(GClass84.smethod_94(gameObject_39));
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00071834 File Offset: 0x0006FA34
		internal static bool smethod_1138(List<VRC_Trigger> list_51, string string_4)
		{
			bool result = false;
			for (int i = list_51.Count - 1; i >= 0; i--)
			{
				if (GClass84.smethod_844(list_51[i], string_4))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00071870 File Offset: 0x0006FA70
		internal static void smethod_1139(Task task_0, string string_4)
		{
			GClass84.Class117 @class = new GClass84.Class117();
			@class.string_0 = string_4;
			if (task_0 != null)
			{
				task_0.ContinueWith(new Action<Task>(@class.method_0));
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000718A4 File Offset: 0x0006FAA4
		internal static int smethod_1140()
		{
			return GClass84.list_42.Count;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000718C0 File Offset: 0x0006FAC0
		internal static Transform[] smethod_1141(Transform transform_0)
		{
			Transform[] result;
			if (!transform_0)
			{
				result = new Transform[0];
			}
			else
			{
				Transform[] array = new Transform[transform_0.childCount];
				for (int i = 0; i < transform_0.childCount; i++)
				{
					array[i] = transform_0.GetChild(i);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00071910 File Offset: 0x0006FB10
		internal static GameObject[] smethod_1142()
		{
			return GClass84.smethod_1297(GClass84.smethod_1351());
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0007192C File Offset: 0x0006FB2C
		internal static List<GameObject> smethod_1143(GameObject gameObject_39)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					gameObject_39
				};
				list.AddRange(GClass84.smethod_471(gameObject_39.transform));
				result = list;
			}
			return result;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00071970 File Offset: 0x0006FB70
		internal static bool smethod_1144(MethodBase methodBase_0, MethodInfo methodInfo_5)
		{
			bool result;
			try
			{
				result = Class203.smethod_1("Abyss Client_1.0.0", methodBase_0, methodInfo_5);
			}
			catch (Exception ex)
			{
				string text = "Null";
				string text2 = "Null";
				if (methodBase_0 != null)
				{
					text = methodBase_0.Name;
				}
				if (methodInfo_5 != null)
				{
					text2 = methodInfo_5.Name;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Patching",
					" (",
					text,
					", ",
					text2,
					"): ",
					ex.Message
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00071A38 File Offset: 0x0006FC38
		internal static bool smethod_1145(string string_4, string string_5 = "", bool bool_10 = false)
		{
			bool result;
			if (string.IsNullOrEmpty(string_4))
			{
				GClass70.smethod_38("ID Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				try
				{
					HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, string.Concat(new string[]
					{
						Class4.String_0,
						"/",
						"api",
						"/",
						"authentication",
						"/",
						"login"
					}));
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					string key = "username";
					dictionary[key] = string_4;
					string key2 = "name";
					dictionary[key2] = "tupper";
					string key3 = "password";
					dictionary[key3] = string_4;
					string key4 = "loginKey";
					dictionary[key4] = "1";
					string content = Encoder.Encode(dictionary);
					httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
					HttpClient httpClient = new HttpClient();
					httpClient.DefaultRequestHeaders.Accept.Clear();
					httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("emmVRC/1.0 (Client; emmVRCClient/2.3.0, Headset; None)");
					using (HttpResponseMessage result2 = httpClient.SendAsync(httpRequestMessage).Result)
					{
						HttpStatusCode statusCode = result2.StatusCode;
						HttpStatusCode httpStatusCode = statusCode;
						if (httpStatusCode == HttpStatusCode.OK)
						{
							if (bool_10)
							{
								GClass70.smethod_38(string.Concat(new string[]
								{
									GClass84.smethod_108<string>(string_5 != string.Empty, string_4 + " (" + string_5 + ")", string_4),
									" ",
									"has",
									" ",
									"probably",
									" ",
									"not",
									" ",
									"used",
									" ",
									"emm",
									"VRC",
									" ",
									"before"
								}), GClass70.Enum1.const_0);
							}
							return false;
						}
						if (httpStatusCode != HttpStatusCode.Unauthorized)
						{
							if (bool_10)
							{
								GClass70.smethod_38(string.Concat(new string[]
								{
									"Failed",
									" ",
									"to",
									" ",
									"detect",
									" ",
									"user",
									" ",
									GClass84.smethod_108<string>(string_5 != string.Empty, string_4 + " (" + string_5 + ")", string_4),
									" ",
									"due",
									" ",
									"to",
									" (",
									result2.StatusCode.ToString(),
									") ",
									result2.ReasonPhrase
								}), GClass70.Enum1.const_0);
							}
							return false;
						}
						if (bool_10)
						{
							GClass70.smethod_38(string.Concat(new string[]
							{
								GClass84.smethod_108<string>(string_5 != string.Empty, string_4 + " (" + string_5 + ")", string_4),
								" ",
								"has",
								" ",
								"used",
								" ",
								"emm",
								"VRC",
								" ",
								"before"
							}), GClass70.Enum1.const_0);
						}
						return true;
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Exception",
						" ",
						"while",
						" ",
						"checking",
						" ",
						"for",
						" ",
						"emm",
						"VRC",
						": ",
						ex.Message
					}), GClass70.Enum1.const_0);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00071E70 File Offset: 0x00070070
		internal static void smethod_1146(bool bool_10 = false)
		{
			GClass84.smethod_338(bool_10);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00071E84 File Offset: 0x00070084
		internal static void smethod_1147()
		{
			GClass84.smethod_457();
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00071E98 File Offset: 0x00070098
		internal static Transform smethod_1148()
		{
			GameObject gameObject = GClass84.smethod_1503();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00071EB8 File Offset: 0x000700B8
		internal static List<Transform> smethod_1149(List<GameObject> list_51, int int_1)
		{
			List<Transform> result;
			if (list_51 == null || list_51.Count < 1)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_619(list_51[i], int_1));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00071F10 File Offset: 0x00070110
		internal static string smethod_1150()
		{
			return GClass84.smethod_1052();
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00071F24 File Offset: 0x00070124
		internal static void smethod_1151(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			int num = 0;
			int_4 = GClass84.smethod_1551(int_4, 0, 360);
			int_5 = GClass84.smethod_1551(int_5, -360, 360);
			int_5 = GClass84.smethod_108<int>(int_5 < 0, 360 + int_5, int_5);
			int_5 = GClass84.smethod_108<int>(int_5 == 360, 0, int_5);
			float num2 = (float)((int_4 + int_5) % 360);
			if (int_5 == 0)
			{
				GClass84.smethod_736(gclass156_1, int_1, int_2, int_3, int_4);
			}
			else if (int_4 > 0)
			{
				int i = int_3;
				int num3 = 1 - 2 * int_3;
				float num4 = GClass84.smethod_1480((float)int_5);
				float num5 = GClass84.smethod_1480(num2);
				float num6 = (float)Math.Cos(1.5707963267948966 - (double)num4) * (float)int_3;
				float num7 = (float)Math.Sin(1.5707963267948966 - (double)num4) * (float)int_3;
				float num8 = (float)Math.Cos(1.5707963267948966 - (double)num5) * (float)int_3;
				float num9 = (float)Math.Sin(1.5707963267948966 - (double)num5) * (float)int_3;
				float num10 = (float)Math.Cos(7.8539816339744828 - (double)num4) * (float)int_3;
				float num11 = (float)Math.Sin(7.8539816339744828 - (double)num4) * (float)int_3;
				float num12 = (float)Math.Cos(7.8539816339744828 - (double)num5) * (float)int_3;
				float num13 = (float)Math.Sin(7.8539816339744828 - (double)num5) * (float)int_3;
				while (i >= 0)
				{
					if (int_5 <= 360 && int_5 >= 90)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 90f)
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
							}
							else if (num2 > 0f && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
						}
						if ((num2 > 0f || num2 < 90f) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
						}
					}
					else if (num2 >= 90f)
					{
						if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
						}
					}
					else if ((int_5 > 45 || (float)num > num6) && (int_5 <= 45 || (float)i < num7) && ((num2 <= 45f && (float)num <= num8) || (num2 > 45f && (float)i >= num9)))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 - i), int_6, int_6);
					}
					if (int_5 <= 90)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 90f)
							{
								if (num2 >= 180f)
								{
									GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
								}
								else if ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12))
								{
									GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if (int_5 <= 360 && int_5 >= 180)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 180f)
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
							}
							else if (num2 > 90f && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
						}
						if ((num2 > 90f || num2 < 180f) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if (num2 >= 180f)
					{
						if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if ((int_5 > 135 || (float)i > -num11) && (int_5 <= 135 || (float)num < num10) && ((num2 <= 135f && (float)i <= -num13) || (num2 > 135f && (float)num >= num12)))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 + num), (float)(int_2 + i), int_6, int_6);
					}
					if (int_5 <= 180)
					{
						if (num2 > (float)int_5)
						{
							if (num2 > 180f)
							{
								if (num2 >= 270f)
								{
									GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
								}
								else if ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13))
								{
									GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
								}
							}
						}
						else if (num2 < (float)int_5)
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if (int_5 <= 360 && int_5 >= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 270f)
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
							}
							else if (num2 > 180f && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
							}
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
						}
						if ((num2 > 180f || num2 < 270f) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if (num2 >= 270f)
					{
						if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
						}
					}
					else if ((int_5 > 225 || (float)num > -num10) && (int_5 <= 225 || (float)i < -num11) && ((num2 <= 225f && (float)num <= -num12) || (num2 > 225f && (float)i >= -num13)))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 + i), int_6, int_6);
					}
					if (int_5 <= 270)
					{
						if (num2 < (float)int_5)
						{
							if (num2 >= 0f && num2 < 270f)
							{
								GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_6, int_6);
							}
						}
						else if (num2 > 270f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_6, int_6);
						}
					}
					else if (num2 < (float)int_5)
					{
						if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_6, int_6);
						}
						if (num2 > 270f && num2 < 360f && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
						{
							GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_6, int_6);
						}
					}
					else if ((int_5 > 315 || (float)i > num11) && (int_5 <= 315 || (float)num < -num10) && ((num2 <= 315f && (float)i <= num13) || (num2 > 315f && (float)num >= -num12)))
					{
						GClass84.smethod_1015(gclass156_1, (float)(int_1 - num), (float)(int_2 - i), int_6, int_6);
					}
					int num14 = 2 * (num3 + i) - 1;
					if (num3 < 0 && num14 <= 0)
					{
						num3 += 2 * ++num + 1;
					}
					else if (num3 > 0 && num14 > 0)
					{
						num3 -= 2 * --i + 1;
					}
					else
					{
						num3 += 2 * (++num - i--);
					}
				}
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00072984 File Offset: 0x00070B84
		internal static string smethod_1152()
		{
			return GClass84.smethod_798();
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00072998 File Offset: 0x00070B98
		internal static void smethod_1153(Color color_0)
		{
			if (!GClass84.highlightsFXStandalone_0)
			{
				GClass84.smethod_469();
			}
			if (GClass84.highlightsFXStandalone_0)
			{
				GClass84.highlightsFXStandalone_0.highlightColor = color_0;
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000729D0 File Offset: 0x00070BD0
		internal static Notification smethod_1154()
		{
			return null;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000729E0 File Offset: 0x00070BE0
		internal static string smethod_1155(string string_4, int int_1, int int_2)
		{
			return GClass84.smethod_1176(string_4, int_1, int_2);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000729F8 File Offset: 0x00070BF8
		internal static string smethod_1156()
		{
			return GClass84.smethod_1529();
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00072A0C File Offset: 0x00070C0C
		internal static ApiAvatar smethod_1157()
		{
			return GClass84.smethod_1468(GClass84.smethod_105());
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00072A28 File Offset: 0x00070C28
		internal static Color smethod_1158(PlayerNet playerNet_0)
		{
			return GClass84.smethod_1041(GClass84.smethod_307(GClass84.smethod_782(playerNet_0)));
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00072A48 File Offset: 0x00070C48
		internal static void smethod_1159(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			GClass84.smethod_1151(gclass156_1, int_1, int_2, int_3, int_4, int_5, int_6);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00072A6C File Offset: 0x00070C6C
		internal static bool smethod_1160(string string_4)
		{
			return string.IsNullOrEmpty(string_4);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00072A80 File Offset: 0x00070C80
		internal static Color32 smethod_1161(ConsoleColor consoleColor_0)
		{
			Color32 result;
			switch (consoleColor_0)
			{
			case ConsoleColor.Black:
				result = new Color32(0, 0, 0, 0);
				break;
			case ConsoleColor.DarkBlue:
				result = new Color32(0, 0, 128, byte.MaxValue);
				break;
			case ConsoleColor.DarkGreen:
				result = new Color32(0, 128, 0, byte.MaxValue);
				break;
			case ConsoleColor.DarkCyan:
				result = new Color32(0, 128, 128, byte.MaxValue);
				break;
			case ConsoleColor.DarkRed:
				result = new Color32(128, 0, 0, byte.MaxValue);
				break;
			case ConsoleColor.DarkMagenta:
				result = new Color32(128, 0, 128, byte.MaxValue);
				break;
			case ConsoleColor.DarkYellow:
				result = new Color32(128, 128, 0, byte.MaxValue);
				break;
			case ConsoleColor.Gray:
				result = new Color32(192, 192, 192, byte.MaxValue);
				break;
			case ConsoleColor.DarkGray:
				result = new Color32(128, 128, 128, byte.MaxValue);
				break;
			case ConsoleColor.Blue:
				result = new Color32(0, 0, byte.MaxValue, byte.MaxValue);
				break;
			case ConsoleColor.Green:
				result = new Color32(0, byte.MaxValue, 0, byte.MaxValue);
				break;
			case ConsoleColor.Cyan:
				result = new Color32(0, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				break;
			case ConsoleColor.Red:
				result = new Color32(byte.MaxValue, 0, 0, byte.MaxValue);
				break;
			case ConsoleColor.Magenta:
				result = new Color32(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue);
				break;
			case ConsoleColor.Yellow:
				result = new Color32(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);
				break;
			case ConsoleColor.White:
				result = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				break;
			default:
				result = new Color(0f, 0f, 0f);
				break;
			}
			return result;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00072C7C File Offset: 0x00070E7C
		internal static void smethod_1162()
		{
			GClass84.smethod_1539();
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00072C90 File Offset: 0x00070E90
		internal static string smethod_1163(string string_4)
		{
			return GClass84.smethod_1219(string_4);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00072CA4 File Offset: 0x00070EA4
		internal static List<GameObject> smethod_1164()
		{
			return GClass84.smethod_579(GClass84.smethod_1351());
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00072CC0 File Offset: 0x00070EC0
		internal static void smethod_1165(Transform transform_0, bool bool_10)
		{
			if (transform_0)
			{
				if (bool_10)
				{
					GClass84.smethod_1237(transform_0.Find("Avatar"));
					GClass84.smethod_1237(transform_0.Find("_AvatarMirrorClone"));
				}
				else
				{
					GClass84.smethod_1237(transform_0);
				}
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00072D04 File Offset: 0x00070F04
		internal static float smethod_1166(float float_3)
		{
			return float_3 * 1.8f + 32f;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00072D20 File Offset: 0x00070F20
		internal static string smethod_1167(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_0, int_1);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00072D3C File Offset: 0x00070F3C
		internal static Vector3 smethod_1168()
		{
			Vector3 vector3_ = default(Vector3);
			vector3_.x = GClass84.smethod_790() * 2f;
			vector3_.y = GClass84.smethod_790() * 2f;
			vector3_.z = GClass84.smethod_790() * 2f;
			return GClass84.smethod_1479(vector3_);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00072D90 File Offset: 0x00070F90
		internal static string smethod_1169(ref string string_4, string string_5)
		{
			return GClass84.smethod_546(ref string_4, string_5);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00072DA4 File Offset: 0x00070FA4
		internal static bool smethod_1170(Quaternion quaternion_0)
		{
			return float.IsInfinity(quaternion_0.x) || float.IsInfinity(quaternion_0.y) || float.IsInfinity(quaternion_0.z) || float.IsInfinity(quaternion_0.w);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00072DE8 File Offset: 0x00070FE8
		internal static void smethod_1171(Transform transform_0)
		{
			if (transform_0)
			{
				string[] array = new string[]
				{
					"cloth",
					"hoodie",
					"shoes",
					"pant",
					"under",
					"top",
					"belt",
					"skirt",
					"rock",
					"uniform",
					"sweater",
					"sailor",
					"drawers",
					"mesh",
					"metal",
					"slipper",
					"stocking",
					"bikini",
					"outfit",
					"chain",
					"sleeve",
					"straps",
					"suit",
					"dress",
					"mask",
					"jacket",
					"costume",
					"parker",
					"gloves",
					"shorts",
					"lower",
					"wear",
					"overall",
					"shirt",
					"choker",
					"pantsu",
					"socks",
					"harness",
					"boots",
					"bikini",
					"bottom"
				};
				string[] array2 = new string[]
				{
					"BH",
					"bra",
					"sfw",
					"9",
					"black",
					"black 5"
				};
				string[] array3 = new string[]
				{
					"_bra"
				};
				SkinnedMeshRenderer[] array4 = transform_0.GetComponentsInChildren<SkinnedMeshRenderer>();
				for (int i = array4.Length - 1; i >= 0; i--)
				{
					bool flag = false;
					for (int j = array.Length - 1; j >= 0; j--)
					{
						if (array4[i].name.ToLower().Contains(array[j].ToLower()))
						{
							foreach (Material material in array4[i].materials)
							{
								if (material && !material.name.ToLower().Contains("face".ToLower()))
								{
									flag = true;
									break;
								}
							}
						}
					}
					if (!flag)
					{
						for (int k = array2.Length - 1; k >= 0; k--)
						{
							if (array4[i].name.ToLower() == array2[k].ToLower())
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						for (int l = array3.Length - 1; l >= 0; l--)
						{
							if (array4[i].name.ToLower().EndsWith(array3[l].ToLower()))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						array4[i].forceRenderingOff = true;
					}
					else
					{
						foreach (Material material2 in array4[i].materials)
						{
							if (material2)
							{
								bool flag2;
								if (!(flag2 = flag))
								{
									for (int m = array.Length - 1; m >= 0; m--)
									{
										if (material2.name.ToLower().Contains(array[m].ToLower()))
										{
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2)
								{
									string text = material2.name;
									if (text.Length > " (Instance)".Length && text.EndsWith(" (Instance)"))
									{
										text = text.Substring(0, text.Length - " (Instance)".Length);
									}
									int n = array2.Length - 1;
									while (n >= 0)
									{
										if (!(text.ToLower() == array2[n].ToLower()))
										{
											n--;
										}
										else
										{
											flag2 = true;
											IL_40C:
											if (!flag2)
											{
												for (int num = array3.Length - 1; num >= 0; num--)
												{
													if (text.ToLower().EndsWith(array3[num].ToLower()))
													{
														flag2 = true;
														break;
													}
												}
												goto IL_448;
											}
											goto IL_448;
										}
									}
									goto IL_40C;
								}
								IL_448:
								if (!flag2 && material2.mainTexture)
								{
									for (int num2 = array.Length - 1; num2 >= 0; num2--)
									{
										if (material2.mainTexture.name.ToLower().Contains(array[num2].ToLower()))
										{
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2 && material2.mainTexture)
								{
									for (int num3 = array2.Length - 1; num3 >= 0; num3--)
									{
										if (material2.mainTexture.name.ToLower() == array2[num3].ToLower())
										{
											flag2 = true;
											break;
										}
									}
								}
								if (flag2)
								{
									Color color = material2.color;
									color.a = 0f;
									material2.color = color;
									material2.SetInt("_SrcBlend", 1);
									material2.SetInt("_DstBlend", 6);
									material2.SetInt("_ZWrite", 0);
									material2.mainTextureScale = new Vector2(0f, 0f);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000733A8 File Offset: 0x000715A8
		internal static List<GameObject> smethod_1172(Transform transform_0, string string_4)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_1066(transform_0.gameObject, string_4);
			}
			return result;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000733D8 File Offset: 0x000715D8
		internal static string smethod_1173(string string_4, string string_5, string string_6)
		{
			return GClass84.smethod_303(string_4, string_5, string_6);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000733F0 File Offset: 0x000715F0
		internal static List<CCDIK> smethod_1174(GameObject gameObject_39)
		{
			List<CCDIK> result;
			if (!gameObject_39)
			{
				result = new List<CCDIK>();
			}
			else
			{
				List<CCDIK> list = gameObject_39.GetComponents<CCDIK>().ToList<CCDIK>();
				list.AddRange(gameObject_39.GetComponentsInChildren<CCDIK>(true));
				result = list.Distinct<CCDIK>().ToList<CCDIK>();
			}
			return result;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00073438 File Offset: 0x00071638
		internal static int smethod_1175(int int_1, int int_2)
		{
			GClass84.smethod_883();
			return Random.Range(int_1, int_2);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00073454 File Offset: 0x00071654
		internal static string smethod_1176(string string_4, int int_1, int int_2)
		{
			string empty;
			if (string.IsNullOrEmpty(string_4))
			{
				empty = string.Empty;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				while (int_1 < int_2)
				{
					if (string_4[int_1] == '{')
					{
						if (num == 0)
						{
							num3 = int_1;
						}
						num++;
					}
					else if (string_4[int_1] == '}')
					{
						num2++;
					}
					if (num2 > num)
					{
						if (num != 0)
						{
							return string.Empty;
						}
						num2 = 0;
					}
					else
					{
						if (num > 0 && num2 == num)
						{
							return GClass84.smethod_1204(string_4, num3, int_1 - num3 + 1);
						}
						int_1++;
					}
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000734F0 File Offset: 0x000716F0
		internal static void smethod_1177(float float_3)
		{
			GClass84.smethod_954(float_3);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00073504 File Offset: 0x00071704
		internal static string smethod_1178(VRCPlayer vrcplayer_0, string string_4 = "")
		{
			return GClass84.smethod_860(vrcplayer_0, string_4);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00073518 File Offset: 0x00071718
		internal static Type[] smethod_1179(Assembly assembly_0, string string_4)
		{
			GClass84.Class118 @class = new GClass84.Class118();
			@class.string_0 = string_4;
			return assembly_0.GetTypes().Where(new Func<Type, bool>(@class.method_0)).ToArray<Type>();
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00073550 File Offset: 0x00071750
		internal static void smethod_1180(MeshRenderer meshRenderer_0)
		{
			GClass84.smethod_804(meshRenderer_0);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00073564 File Offset: 0x00071764
		internal static List<Transform> smethod_1181(string string_4, bool bool_10)
		{
			return GClass84.smethod_1105(GClass84.smethod_1351(), string_4, bool_10);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00073580 File Offset: 0x00071780
		internal static Vector2 smethod_1182(float float_3)
		{
			return new Vector2((float)Math.Cos((double)float_3), (float)Math.Sin((double)float_3));
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000735A4 File Offset: 0x000717A4
		internal static void smethod_1183(string string_4, string string_5)
		{
			GClass84.smethod_1407(string_4, string_5);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000735B8 File Offset: 0x000717B8
		internal static GameObject smethod_1184(GameObject gameObject_39)
		{
			return GClass84.smethod_435(gameObject_39, "HmdPivot");
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000735D4 File Offset: 0x000717D4
		internal static List<GameObject> smethod_1185(GameObject gameObject_39)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_266(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00073604 File Offset: 0x00071804
		internal static void smethod_1186(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_588(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00073624 File Offset: 0x00071824
		internal static void smethod_1187()
		{
			GClass84.smethod_181();
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00073638 File Offset: 0x00071838
		internal static void smethod_1188(string string_4, Color color_0)
		{
			GClass84.smethod_402(string_4, color_0);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0007364C File Offset: 0x0007184C
		internal static void smethod_1189(Color color_0, string string_4)
		{
			GClass84.smethod_978(color_0, string_4);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00073660 File Offset: 0x00071860
		private static string smethod_1190(int int_1)
		{
			return GClass84.smethod_1462(int_1);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00073674 File Offset: 0x00071874
		internal static string smethod_1191(UdonBehaviour udonBehaviour_0, int int_1)
		{
			return GClass84.smethod_1463(udonBehaviour_0, int_1);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00073688 File Offset: 0x00071888
		internal static bool smethod_1192(string string_4)
		{
			int[] array = string_4.Split(new string[]
			{
				"."
			}, StringSplitOptions.RemoveEmptyEntries).Select(new Func<string, int>(GClass84.Class101.class101_0.method_19)).ToArray<int>();
			return array[0] != 10 && (array[0] != 192 || array[1] != 168) && (array[0] != 172 || array[1] < 16 || array[1] > 31);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00073724 File Offset: 0x00071924
		internal static string smethod_1193(string string_4, string string_5)
		{
			return GClass84.smethod_207(string_4, string_5);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00073738 File Offset: 0x00071938
		internal static void smethod_1194(this ApiAvatar apiAvatar_0, APIUser apiuser_0, string string_4, string string_5, string string_6 = "")
		{
			GClass84.smethod_305(apiAvatar_0, apiuser_0, string_4, string_5, string_6);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00073754 File Offset: 0x00071954
		internal static void smethod_1195(VRCPlayer vrcplayer_0, bool bool_10 = false)
		{
			GClass84.smethod_71(vrcplayer_0, bool_10);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00073768 File Offset: 0x00071968
		internal static string smethod_1196(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_1461(vrcplayer_0);
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0007377C File Offset: 0x0007197C
		internal static T smethod_1197<T>(byte[] byte_0)
		{
			T result;
			if (byte_0 == null)
			{
				result = default(T);
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream(byte_0);
				object obj = binaryFormatter.Deserialize(memoryStream);
				result = (T)((object)obj);
			}
			return result;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000737C4 File Offset: 0x000719C4
		internal static int smethod_1198(string string_4, string string_5, int int_1)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty || GClass84.smethod_593(string_4) < int_1)
			{
				result = -1;
			}
			else
			{
				result = string_4.IndexOf(string_5, int_1);
			}
			return result;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00073808 File Offset: 0x00071A08
		internal static void smethod_1199(VRCPlayer vrcplayer_0, GameObject gameObject_39, string string_4, object[] object_0)
		{
			object_0 = new List<object>(object_0)
			{
				GClass84.smethod_1557(vrcplayer_0).playerId
			}.ToArray();
			Object[] array = GClass84.smethod_917<Object[]>(object_0);
			byte[] array2 = Networking.EncodeParameters(array);
			VRC_EventHandler.VrcEvent vrcEvent_ = new VRC_EventHandler.VrcEvent
			{
				EventType = 14,
				ParameterObject = gameObject_39,
				ParameterString = string_4,
				ParameterBytes = array2,
				ParameterInt = 9
			};
			GClass84.smethod_1212(vrcEvent_, 4, Networking.LocalPlayer.playerId, 0f);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00073898 File Offset: 0x00071A98
		internal static float smethod_1200(this Player player_0)
		{
			return GClass84.smethod_63(player_0).field_Private_SimpleAudioGain_0.field_Public_Single_0;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000738B8 File Offset: 0x00071AB8
		internal static bool smethod_1201(Player player_0)
		{
			bool result;
			if (!player_0)
			{
				GClass70.smethod_38("Player Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				string text = GClass84.smethod_684(player_0);
				for (int i = GClass84.list_40.Count - 1; i >= 0; i--)
				{
					if (GClass84.list_40[i] == text)
					{
						return false;
					}
				}
				GClass84.list_40.Add(text);
				result = true;
			}
			return result;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00073928 File Offset: 0x00071B28
		internal static bool smethod_1202(PlayerNet playerNet_0)
		{
			return playerNet_0 && GClass84.smethod_1045(GClass84.smethod_440(playerNet_0));
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00073954 File Offset: 0x00071B54
		internal static void smethod_1203()
		{
			GClass84.smethod_72();
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00073968 File Offset: 0x00071B68
		internal static string smethod_1204(string string_4, int int_1, int int_2 = -1)
		{
			return GClass84.smethod_960(string_4, int_1, int_2);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00073980 File Offset: 0x00071B80
		internal static List<string> smethod_1205(string string_4)
		{
			List<string> result;
			if (string.IsNullOrEmpty(string_4))
			{
				result = new List<string>();
			}
			else
			{
				List<string> list = new List<string>();
				List<int> list2 = GClass84.smethod_932(string_4, "{");
				List<int> list3 = GClass84.smethod_932(string_4, "}");
				if (list2.Count != list3.Count)
				{
					result = null;
				}
				else
				{
					int count = list3.Count;
					int num = 0;
					for (int i = 0; i < count; i++)
					{
						int num2 = list3[i] + 1;
						int num3 = num;
						while (num3 < count && list2[num3] + 1 <= num2)
						{
							num3++;
						}
						if (num3 - 1 == i)
						{
							int num4 = list2[num] + 1 + 1;
							list.Add("{" + GClass84.smethod_1204(string_4, num4, list3[num3 - 1] - num4 + 1) + "}");
							num = num3;
						}
					}
					result = list;
				}
			}
			return result;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00073A78 File Offset: 0x00071C78
		internal static void smethod_1206(float float_3)
		{
			GClass84.smethod_1115(float_3);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00073A8C File Offset: 0x00071C8C
		internal static byte[] smethod_1207(int int_1)
		{
			Random random = new Random();
			byte[] array = new byte[int_1 * 1024];
			random.NextBytes(array);
			return array;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00073AB8 File Offset: 0x00071CB8
		internal static string smethod_1208(string string_4, int int_1)
		{
			string result;
			if (int_1 < 1)
			{
				result = string.Empty;
			}
			else if (int_1 >= string_4.Length)
			{
				result = string_4;
			}
			else
			{
				result = string_4.Substring(string_4.Length - int_1);
			}
			return result;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00073AF8 File Offset: 0x00071CF8
		internal static void smethod_1209(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_786(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00073B14 File Offset: 0x00071D14
		internal static void smethod_1210(string string_4, string string_5, string string_6, Action action_0, string string_7, Action action_1)
		{
			VRCUiPopupManager vrcuiPopupManager = GClass84.smethod_1490();
			if (vrcuiPopupManager != null)
			{
				vrcuiPopupManager.Method_Public_Void_String_String_String_Action_String_Action_Action_1_VRCUiPopup_0(string_4, string_5, string_6, action_0, string_7, action_1, null);
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00073B44 File Offset: 0x00071D44
		internal static void smethod_1211(APIUser apiuser_0)
		{
			GClass84.smethod_327(apiuser_0);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00073B58 File Offset: 0x00071D58
		internal static bool smethod_1212(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, int int_1, float float_3)
		{
			VRC_EventHandler vrc_EventHandler = GClass84.VRC_EventHandler_0;
			bool result;
			if (!vrc_EventHandler)
			{
				result = false;
			}
			else
			{
				vrc_EventHandler.TriggerEvent(vrcEvent_0, vrcBroadcastType_0, int_1, float_3);
				result = true;
			}
			return result;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00073B88 File Offset: 0x00071D88
		internal static GameObject smethod_1213(Transform transform_0)
		{
			GameObject result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1039(transform_0, new List<string>
				{
					"ForwardDirection"
				});
			}
			return result;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00073BBC File Offset: 0x00071DBC
		internal static string smethod_1214(IUser iuser_0)
		{
			string result;
			if (iuser_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = iuser_0.Method_Public_Abstract_Virtual_New_get_String_0();
			}
			return result;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00073BE0 File Offset: 0x00071DE0
		internal static GameObject[] smethod_1215(bool bool_10, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_549(bool_10, bool_11, bool_12).ToArray();
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00073BFC File Offset: 0x00071DFC
		internal static string smethod_1216(int int_1)
		{
			return GClass84.smethod_1255(int_1);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00073C10 File Offset: 0x00071E10
		internal static void smethod_1217(ref HighlightsFXStandalone highlightsFXStandalone_1, Color color_0)
		{
			if (!highlightsFXStandalone_1)
			{
				highlightsFXStandalone_1 = GClass84.smethod_1275();
			}
			if (highlightsFXStandalone_1)
			{
				highlightsFXStandalone_1.highlightColor = color_0;
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00073C44 File Offset: 0x00071E44
		internal static GClass84.GStruct169 smethod_1218(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct169 gstruct = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			bool flag = false;
			if (int_2 > int_4)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num;
			int num5 = int_1;
			int num6 = int_3 - int_1;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_2; i <= int_4; i++)
			{
				if (!flag)
				{
					gstruct.method_0(new GClass84.GStruct163(num5, i), new GClass84.GStruct163(1, 1));
				}
				else
				{
					GClass84.GStruct163 value = gstruct.list_1[gstruct.list_1.Count - 1];
					value.int_1++;
					gstruct.list_1[gstruct.list_1.Count - 1] = value;
				}
				flag = true;
				num3 += num4;
				if (2 * num3 >= num2)
				{
					num5 += num6;
					num3 -= num2;
					flag = false;
				}
			}
			return gstruct;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00073D54 File Offset: 0x00071F54
		internal static string smethod_1219(string string_4)
		{
			return string_4.ToUpper();
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00073D6C File Offset: 0x00071F6C
		internal static void smethod_1220(string string_4, string string_5)
		{
			GClass84.smethod_1183(string_4, string_5);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00073D80 File Offset: 0x00071F80
		internal static string smethod_1221(string string_4)
		{
			return GClass84.smethod_499(string_4);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00073D94 File Offset: 0x00071F94
		internal static LoadBalancingClient smethod_1222()
		{
			Room room = GClass84.smethod_1250();
			return (room != null) ? room.Method_Public_get_LoadBalancingClient_0() : null;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00073DB4 File Offset: 0x00071FB4
		internal static List<AimIK> smethod_1223(Transform transform_0)
		{
			List<AimIK> result;
			if (!transform_0)
			{
				result = new List<AimIK>();
			}
			else
			{
				List<AimIK> list = transform_0.GetComponents<AimIK>().ToList<AimIK>();
				list.AddRange(transform_0.GetComponentsInChildren<AimIK>(true));
				result = list.Distinct<AimIK>().ToList<AimIK>();
			}
			return result;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00073DFC File Offset: 0x00071FFC
		internal static bool smethod_1224<T>(List<T> list_51, T gparam_0) where T : Object
		{
			bool result;
			if (gparam_0 == null || list_51 == null)
			{
				result = false;
			}
			else
			{
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (list_51[i] == gparam_0)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00073E5C File Offset: 0x0007205C
		internal static GameObject smethod_1225()
		{
			if (!GClass84.gameObject_21)
			{
				GClass84.gameObject_21 = GameObject.Find("/VRC_OBJECTS/SpawnManager");
			}
			return GClass84.gameObject_21;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00073E90 File Offset: 0x00072090
		internal static bool smethod_1226(Transform transform_0, Transform transform_1, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			return transform_0 && transform_1 && GClass84.smethod_293(transform_0, GClass84.smethod_272(transform_1, genum47_0), bool_10);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00073EC8 File Offset: 0x000720C8
		internal static List<GClass84.GStruct163> smethod_1227(int int_1, int int_2, int int_3, int int_4)
		{
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			if (int_2 > int_4)
			{
				GClass84.smethod_192<int>(ref int_1, ref int_3);
				GClass84.smethod_192<int>(ref int_2, ref int_4);
			}
			int num = GClass84.smethod_624(int_3 - int_1);
			int num2 = GClass84.smethod_624(int_4 - int_2);
			int num3 = 0;
			int num4 = num;
			int num5 = int_1;
			int num6 = int_3 - int_1;
			if (num6 > 0)
			{
				num6 = 1;
			}
			if (num6 < 0)
			{
				num6 = -1;
			}
			for (int i = int_2; i <= int_4; i++)
			{
				list.Add(new GClass84.GStruct163(num5, i));
				num3 += num4;
				if (2 * num3 >= num2)
				{
					num5 += num6;
					num3 -= num2;
				}
			}
			return list;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00073F6C File Offset: 0x0007216C
		internal static void smethod_1228(MeshFilter meshFilter_0, bool bool_10)
		{
			if (meshFilter_0)
			{
				if (bool_10)
				{
					Mesh mesh = meshFilter_0.mesh;
					if (mesh)
					{
						GClass84.smethod_1522(mesh);
					}
				}
				Object.DestroyImmediate(meshFilter_0, true);
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00073FA4 File Offset: 0x000721A4
		internal static Vector4 smethod_1229()
		{
			Vector4 vector4_ = default(Vector4);
			vector4_.x = GClass84.smethod_790() * 2f;
			vector4_.y = GClass84.smethod_790() * 2f;
			vector4_.z = GClass84.smethod_790() * 2f;
			vector4_.w = GClass84.smethod_790() * 2f;
			return GClass84.smethod_1279(vector4_);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0007400C File Offset: 0x0007220C
		internal static List<GameObject> smethod_1230()
		{
			return VRC_SceneDescriptor._instance.DynamicPrefabs.ToArray().Where(new Func<GameObject, bool>(GClass84.Class101.class101_0.method_2)).ToList<GameObject>();
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00074054 File Offset: 0x00072254
		internal static void smethod_1231(Vector3 vector3_0, bool bool_10)
		{
			Transform transform = GClass84.smethod_981();
			if (transform)
			{
				if (bool_10)
				{
					Vector3 vector = GClass84.smethod_272(transform, GClass84.GEnum47.const_0);
					Vector3 vector2 = GClass84.smethod_272(transform, GClass84.GEnum47.const_1);
					Vector3 vector3 = vector2 - vector;
					Vector3 vector4;
					if (GClass84.smethod_948(vector3_0, new Vector3(0f, -1f, 0f), out vector4))
					{
						if (GClass84.smethod_1494(vector3_0.y - vector4.y) < GClass84.smethod_1494(vector3.y))
						{
							transform.position = vector4;
						}
						else
						{
							transform.position = vector3_0 - vector3;
						}
					}
					else
					{
						transform.position = vector3_0 - vector3;
					}
				}
				else
				{
					transform.position = vector3_0;
				}
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00074108 File Offset: 0x00072308
		internal static List<GameObject> smethod_1232()
		{
			List<GameObject> list = new List<GameObject>();
			GameObject[] array = GClass84.smethod_1142();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (!(array[i].tag == "Player") && !(array[i].name == "PlayerManager") && !(array[i].name == "VRC_OBJECTS") && !(array[i].name == "SceneEventHandlerAndInstantiator"))
				{
					list.Add(array[i]);
				}
			}
			return list;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00074198 File Offset: 0x00072398
		internal static void smethod_1233<T>(List<T> list_51)
		{
			if (list_51 != null && list_51.Count != 0)
			{
				list_51.RemoveAll(new Predicate<T>(GClass84.Class103<T>.class103_0.method_0));
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_1234(Material material_1)
		{
			if (material_1)
			{
				Object.DestroyImmediate(material_1, true);
			}
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000741DC File Offset: 0x000723DC
		internal static Transform smethod_1235(string string_4)
		{
			return GClass84.smethod_1454(GClass84.smethod_659(string_4, "/"));
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000741FC File Offset: 0x000723FC
		internal static bool smethod_1236(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, float float_3)
		{
			VRC_EventHandler vrc_EventHandler = GClass84.VRC_EventHandler_0;
			bool result;
			if (!vrc_EventHandler)
			{
				result = false;
			}
			else
			{
				vrc_EventHandler.TriggerEvent(vrcEvent_0, vrcBroadcastType_0, gameObject_39, float_3);
				result = true;
			}
			return result;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0007422C File Offset: 0x0007242C
		internal static void smethod_1237(Transform transform_0)
		{
			GClass84.smethod_674(transform_0);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00074240 File Offset: 0x00072440
		internal static bool smethod_1238(string string_4, out int int_1)
		{
			return int.TryParse(string_4, out int_1);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00074254 File Offset: 0x00072454
		internal static List<VRCPlayerApi> smethod_1239()
		{
			return VRCPlayerApi.AllPlayers.smethod_1334<VRCPlayerApi>();
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00074270 File Offset: 0x00072470
		internal static string smethod_1240(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_1, int_1);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0007428C File Offset: 0x0007248C
		internal static string smethod_1241(string string_4, int int_1)
		{
			return GClass84.smethod_922(string_4, int_1);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000742A0 File Offset: 0x000724A0
		internal static void smethod_1242()
		{
			GClass84.smethod_961();
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000742B4 File Offset: 0x000724B4
		internal static Texture2D smethod_1243(Texture2D texture2D_0)
		{
			Color32[] array = texture2D_0.GetPixels32();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_87(array[i]);
			}
			texture2D_0.SetPixels32(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0007430C File Offset: 0x0007250C
		internal static void smethod_1244(Slider slider_0, UnityAction<float> unityAction_0)
		{
			GClass84.smethod_14(slider_0, unityAction_0);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00074320 File Offset: 0x00072520
		internal static void smethod_1245(float float_3)
		{
			GClass84.smethod_278(float_3, float_3 * 1.5f);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0007433C File Offset: 0x0007253C
		internal static void smethod_1246(float float_3)
		{
			Player player = GClass84.smethod_1010();
			if (player)
			{
				MonoBehaviourPublicSimastSiofdiChSiLagrUnique component = player.GetComponent<MonoBehaviourPublicSimastSiofdiChSiLagrUnique>();
				if (component)
				{
					GClass84.smethod_1261(GClass84.smethod_1699() + float_3);
				}
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00074378 File Offset: 0x00072578
		internal static GameObject smethod_1247(GClass156 gclass156_1, float float_3, float float_4, int int_1, int int_2)
		{
			return gclass156_1.method_53(float_3, float_4, int_1, int_2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00074394 File Offset: 0x00072594
		internal static Transform[] smethod_1248(GameObject gameObject_39)
		{
			Transform[] result;
			if (!gameObject_39)
			{
				result = new Transform[0];
			}
			else
			{
				List<Transform> list = new List<Transform>
				{
					gameObject_39.transform
				};
				list.AddRange(GClass84.smethod_395(gameObject_39));
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000743DC File Offset: 0x000725DC
		internal static bool smethod_1249(VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0 && GClass84.smethod_1260(GClass84.smethod_1557(vrcplayer_0));
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00074408 File Offset: 0x00072608
		internal static Room smethod_1250()
		{
			Player player = GClass84.smethod_822();
			return (player != null) ? player.Method_FamOrAssem_get_Room_0() : null;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00074428 File Offset: 0x00072628
		internal static int[] smethod_1251(IntPtr intptr_1)
		{
			byte[] array = GClass84.smethod_163(intptr_1, 24, 0);
			string text = string.Empty;
			string text2 = string.Empty;
			foreach (byte value in array)
			{
				text2 = text2 + " " + value.ToString();
				text = text + " " + Convert.ToString(value, 2).PadLeft(8, '0');
			}
			GClass70.smethod_24(GClass84.smethod_1204(text2, 1, -1), GClass70.Enum1.const_0);
			GClass70.smethod_24(GClass84.smethod_1204(text, 1, -1), GClass70.Enum1.const_0);
			int num = GClass84.smethod_18(GClass84.smethod_163(intptr_1, 4, 24), 0);
			GClass70.smethod_24(num.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_24(Convert.ToString(num, 2).PadLeft(32, '0'), GClass70.Enum1.const_0);
			int value2 = GClass84.smethod_18(GClass84.smethod_163(intptr_1, 4, 28), 0);
			GClass70.smethod_24(value2.ToString(), GClass70.Enum1.const_0);
			GClass70.smethod_24(Convert.ToString(value2, 2).PadLeft(32, '0'), GClass70.Enum1.const_0);
			num = 1;
			int[] array3 = new int[1];
			for (int j = 0; j < num; j++)
			{
				array3[j] = GClass84.smethod_18(GClass84.smethod_163(intptr_1, 4, 28 + j * 4), 0);
			}
			return array3;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00074558 File Offset: 0x00072758
		internal static GClass84.GStruct169 smethod_1252(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			return GClass84.smethod_1429(int_1, int_2, gstruct.int_0, gstruct.int_1);
		}

		// Token: 0x060015C2 RID: 5570
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr GetConsoleWindow();

		// Token: 0x060015C3 RID: 5571 RVA: 0x00074584 File Offset: 0x00072784
		internal static byte[] smethod_1253(Vector3 vector3_0)
		{
			byte[] array = new byte[12];
			Buffer.BlockCopy(BitConverter.GetBytes(vector3_0.x), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(vector3_0.y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(vector3_0.z), 0, array, 8, 4);
			return array;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000745D8 File Offset: 0x000727D8
		internal static Vector3 smethod_1254(GClass84.GEnum48 genum48_0, List<Transform> list_51, Vector3 vector3_0)
		{
			Vector3 vector;
			switch (genum48_0)
			{
			case GClass84.GEnum48.const_0:
				vector = GClass84.smethod_891(list_51);
				break;
			case GClass84.GEnum48.const_1:
				vector = GClass84.smethod_891(list_51);
				break;
			case GClass84.GEnum48.const_2:
				vector = GClass84.smethod_891(list_51);
				break;
			case GClass84.GEnum48.const_3:
				vector = GClass84.smethod_891(list_51);
				vector += vector3_0;
				break;
			case GClass84.GEnum48.const_4:
				vector = GClass84.smethod_891(list_51);
				vector += vector3_0;
				break;
			case GClass84.GEnum48.const_5:
				vector = GClass84.smethod_891(list_51);
				vector += vector3_0;
				break;
			case GClass84.GEnum48.const_6:
				vector = vector3_0;
				break;
			default:
				vector = default(Vector3);
				break;
			}
			return vector;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00074668 File Offset: 0x00072868
		internal static string smethod_1255(int int_1)
		{
			return GClass84.smethod_677(GClass193.char_9, int_1);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0006326C File Offset: 0x0006146C
		internal static GameObject smethod_1256(VRCPlayer vrcplayer_0)
		{
			GameObject result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_603(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00074684 File Offset: 0x00072884
		internal static void smethod_1257<T>(ref T[] gparam_0)
		{
			if (gparam_0 != null && gparam_0.Length != 0)
			{
				gparam_0 = gparam_0.Distinct<T>().ToArray<T>();
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000746B0 File Offset: 0x000728B0
		internal static bool smethod_1258(Transform transform_0, string string_4, bool bool_10 = false)
		{
			bool result;
			if (string_4 == string.Empty)
			{
				result = false;
			}
			else
			{
				if (transform_0)
				{
					UdonBehaviour[] array = transform_0.GetComponents<UdonBehaviour>();
					for (int i = 0; i < array.Length; i++)
					{
						if (GClass84.smethod_986(array[i], string_4, bool_10))
						{
							return true;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0007470C File Offset: 0x0007290C
		internal static void smethod_1259(GameObject gameObject_39, bool bool_10)
		{
			GClass84.smethod_259(gameObject_39, bool_10);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00074720 File Offset: 0x00072920
		internal static bool smethod_1260(VRCPlayerApi vrcplayerApi_0)
		{
			return vrcplayerApi_0 != null && vrcplayerApi_0.IsUserInVR();
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00074740 File Offset: 0x00072940
		internal static void smethod_1261(float float_3)
		{
			GClass84.smethod_1091(float_3);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00074754 File Offset: 0x00072954
		internal static void smethod_1262()
		{
			GClass84.smethod_1401();
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00074768 File Offset: 0x00072968
		internal static bool smethod_1263(Type type_0, string string_4, Type[] type_1, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_420("Abyss Client_1.0.0", type_0, string_4, type_1, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00074788 File Offset: 0x00072988
		internal static List<T> smethod_1264<T>(List<T> list_51)
		{
			List<T> list = new List<T>();
			list.AddRange(list_51);
			return list;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000747A8 File Offset: 0x000729A8
		internal static List<GameObject> smethod_1265()
		{
			List<GameObject> list = new List<GameObject>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<VRC_PortalMarker>())
				{
					list.Add(list2[i].gameObject);
				}
			}
			return list;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00074804 File Offset: 0x00072A04
		internal static void smethod_1266(Player player_0)
		{
			GClass84.smethod_1124(player_0);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00074818 File Offset: 0x00072A18
		internal static void smethod_1267(Player player_0)
		{
			GClass84.smethod_1106(player_0);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0007482C File Offset: 0x00072A2C
		internal static string smethod_1268(string string_4, string string_5, string string_6, bool bool_10)
		{
			return GClass84.smethod_973(string_4, string_5, string_6, bool_10);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00074844 File Offset: 0x00072A44
		internal static string smethod_1269()
		{
			return GClass84.smethod_479();
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00074858 File Offset: 0x00072A58
		internal static GameObject smethod_1270()
		{
			if (!GClass84.gameObject_5)
			{
				GClass84.gameObject_5 = GameObject.Find(GClass84.smethod_277());
			}
			return GClass84.gameObject_5;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0007488C File Offset: 0x00072A8C
		internal static void smethod_1271(GameObject gameObject_39, bool bool_10)
		{
			GClass84.smethod_17(gameObject_39, bool_10);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000748A0 File Offset: 0x00072AA0
		internal static GameObject smethod_1272()
		{
			if (!GClass84.gameObject_7)
			{
				GClass84.gameObject_7 = GameObject.Find("/UserInterface/MenuContent/Popups");
			}
			return GClass84.gameObject_7;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000748D4 File Offset: 0x00072AD4
		internal static int smethod_1273(PlayerNet playerNet_0)
		{
			int result;
			if (!playerNet_0)
			{
				result = -1;
			}
			else
			{
				result = GClass84.smethod_1568(GClass84.smethod_1525(playerNet_0));
			}
			return result;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00074900 File Offset: 0x00072B00
		internal static string smethod_1274(int int_1)
		{
			return GClass84.smethod_417(int_1);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00074914 File Offset: 0x00072B14
		internal static HighlightsFXStandalone smethod_1275()
		{
			if (!GClass84.gameObject_38)
			{
				GClass84.smethod_469();
			}
			HighlightsFXStandalone result;
			if (GClass84.gameObject_38)
			{
				result = GClass84.gameObject_38.AddComponent<HighlightsFXStandalone>();
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00074954 File Offset: 0x00072B54
		internal static Transform[] smethod_1276()
		{
			return GClass84.smethod_725(GClass84.smethod_1351());
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00074970 File Offset: 0x00072B70
		internal static void smethod_1277(string string_4)
		{
			GClass84.smethod_474(string_4);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00074984 File Offset: 0x00072B84
		internal static List<GameObject> smethod_1278(GameObject gameObject_39)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_1143(gameObject_39);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].GetComponent<CCDIK>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000749D8 File Offset: 0x00072BD8
		internal static Vector4 smethod_1279(Vector4 vector4_0)
		{
			return Vector4.Normalize(vector4_0);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x000749F0 File Offset: 0x00072BF0
		internal static Transform smethod_1280(Transform transform_0)
		{
			Transform result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
			}
			return result;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00074A24 File Offset: 0x00072C24
		internal static float smethod_1281(string string_4)
		{
			float num;
			float result;
			if (float.TryParse(string_4, out num))
			{
				result = num;
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00074A48 File Offset: 0x00072C48
		internal static Transform smethod_1282()
		{
			GameObject gameObject = GClass84.smethod_1272();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00074A68 File Offset: 0x00072C68
		internal static void smethod_1283(Mesh mesh_0, int int_1)
		{
			if (mesh_0)
			{
				Il2CppStructArray<Vector3> il2CppStructArray = new Il2CppStructArray<Vector3>((long)mesh_0.vertices.Length);
				Il2CppStructArray<Vector3> il2CppStructArray2 = new Il2CppStructArray<Vector3>((long)mesh_0.normals.Length);
				Il2CppStructArray<Vector3> il2CppStructArray3 = new Il2CppStructArray<Vector3>((long)mesh_0.tangents.Length);
				mesh_0.GetBlendShapeFrameVertices(int_1, mesh_0.GetBlendShapeFrameCount(int_1) - 1, il2CppStructArray, il2CppStructArray2, il2CppStructArray3);
				GClass70.smethod_24("delta" + "Vertices" + ": " + il2CppStructArray[0].ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00074AF4 File Offset: 0x00072CF4
		internal static List<GameObject> smethod_1284(Scene scene_0, string string_4, bool bool_10)
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_579(scene_0);
			for (int i = 0; i < list2.Count; i++)
			{
				if (list2[i].tag == string_4)
				{
					list.Add(list2[i]);
				}
				else if (bool_10)
				{
					list.AddRange(GClass84.smethod_180(list2[i], string_4));
				}
			}
			return list;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00074B64 File Offset: 0x00072D64
		internal static void smethod_1285(string string_4, string string_5, ref string string_6)
		{
			GClass84.smethod_1608(string_4, string_5, ref string_6);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00074B7C File Offset: 0x00072D7C
		internal static List<Transform> smethod_1286(Transform transform_0, string string_4)
		{
			List<Transform> list = new List<Transform>();
			if (transform_0.tag == string_4)
			{
				list.Add(transform_0);
			}
			else
			{
				list.AddRange(GClass84.smethod_1534(transform_0, string_4));
			}
			return list;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00074BB8 File Offset: 0x00072DB8
		internal static List<Transform> smethod_1287(GameObject gameObject_39, string string_4)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_1286(gameObject_39.transform, string_4);
			}
			return result;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00074BE8 File Offset: 0x00072DE8
		internal static void smethod_1288()
		{
			GClass84.smethod_32();
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00074BFC File Offset: 0x00072DFC
		internal static List<T> smethod_1289<T>(T[] gparam_0)
		{
			List<T> result;
			if (gparam_0 == null || gparam_0.Length == 0)
			{
				result = null;
			}
			else
			{
				result = gparam_0.Distinct<T>().ToList<T>();
			}
			return result;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00074C28 File Offset: 0x00072E28
		internal static string smethod_1290(ApiAvatar apiAvatar_0)
		{
			return GClass84.smethod_113(apiAvatar_0);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00074C3C File Offset: 0x00072E3C
		internal static void smethod_1291(string string_4)
		{
			if (!GClass84.smethod_334(string_4))
			{
				VRCUiManager vrcuiManager = GClass84.smethod_102();
				if (vrcuiManager)
				{
					vrcuiManager.Method_Public_Void_Boolean_0(true);
				}
				APIUser.FetchUser(string_4, new Action<APIUser>(GClass84.Class101.class101_0.method_5), null);
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00074C94 File Offset: 0x00072E94
		internal static AvatarPerformanceStats smethod_1292(Player player_0)
		{
			return GClass84.smethod_966(GClass84.smethod_1296(player_0));
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00074CB0 File Offset: 0x00072EB0
		internal static float smethod_1293()
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			float result;
			if (!locomotionInputController)
			{
				result = 0f;
			}
			else
			{
				result = locomotionInputController.field_Public_Single_2;
			}
			return result;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00074CE0 File Offset: 0x00072EE0
		internal static void smethod_1294(float float_3, float float_4, float float_5)
		{
			GClass84.smethod_1370(float_3, float_4, float_5);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00074CF8 File Offset: 0x00072EF8
		internal static bool smethod_1295<T>(T[] gparam_0, T gparam_1) where T : Object
		{
			bool result;
			if (gparam_1 == null || gparam_0 == null)
			{
				result = false;
			}
			else
			{
				for (int i = gparam_0.Length - 1; i >= 0; i--)
				{
					if (gparam_0[i] == gparam_1)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00074D58 File Offset: 0x00072F58
		internal static VRCAvatarManager smethod_1296(Player player_0)
		{
			return GClass84.smethod_1416(GClass84.smethod_367(player_0));
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00074D74 File Offset: 0x00072F74
		internal static GameObject[] smethod_1297(Scene scene_0)
		{
			return scene_0.GetRootGameObjects().ToArray<GameObject>();
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00074D90 File Offset: 0x00072F90
		internal static GameObject smethod_1298()
		{
			if (!GClass84.gameObject_31)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Button", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_31 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_31;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00074DF0 File Offset: 0x00072FF0
		internal static Player smethod_1299(string string_4)
		{
			foreach (Player player in GClass84.smethod_870())
			{
				if (player != null)
				{
					APIUser apiuser = GClass84.smethod_518(player);
					if (apiuser != null && apiuser.displayName == string_4)
					{
						return player;
					}
				}
			}
			return null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00074E48 File Offset: 0x00073048
		internal static string smethod_1300(ConsoleColor consoleColor_0)
		{
			string result;
			switch (consoleColor_0)
			{
			case ConsoleColor.Black:
				result = "Black";
				break;
			case ConsoleColor.DarkBlue:
				result = "DarkBlue";
				break;
			case ConsoleColor.DarkGreen:
				result = "DarkGreen";
				break;
			case ConsoleColor.DarkCyan:
				result = "DarkCyan";
				break;
			case ConsoleColor.DarkRed:
				result = "DarkRed";
				break;
			case ConsoleColor.DarkMagenta:
				result = "DarkMagenta";
				break;
			case ConsoleColor.DarkYellow:
				result = "DarkYellow";
				break;
			case ConsoleColor.Gray:
				result = "Gray";
				break;
			case ConsoleColor.DarkGray:
				result = "DarkGray";
				break;
			case ConsoleColor.Blue:
				result = "Blue";
				break;
			case ConsoleColor.Green:
				result = "Green";
				break;
			case ConsoleColor.Cyan:
				result = "Cyan";
				break;
			case ConsoleColor.Red:
				result = "Red";
				break;
			case ConsoleColor.Magenta:
				result = "Magenta";
				break;
			case ConsoleColor.Yellow:
				result = "Yellow";
				break;
			case ConsoleColor.White:
				result = "White";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00074F28 File Offset: 0x00073128
		internal static GClass84.Enum8 smethod_1301(EnumPublicSealedva5vUnique enumPublicSealedva5vUnique_0)
		{
			GClass84.Enum8 result;
			switch (enumPublicSealedva5vUnique_0)
			{
			case 0:
				result = GClass84.Enum8.const_0;
				break;
			case 1:
				result = GClass84.Enum8.const_1;
				break;
			case 2:
				result = GClass84.Enum8.const_2;
				break;
			case 3:
				result = GClass84.Enum8.const_3;
				break;
			default:
				result = GClass84.Enum8.const_0;
				break;
			}
			return result;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00074F64 File Offset: 0x00073164
		internal static bool smethod_1302(string string_4, Type type_0, string string_5, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			bool result;
			if (GClass84.smethod_1123(string_4, AccessTools.Method(type_0, string_5, null, null), harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
			{
				result = true;
			}
			else
			{
				string text = "Null";
				string text2 = "Null";
				string text3 = "Null";
				string text4 = "Null";
				if (type_0 != null)
				{
					text = type_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text2 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text3 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text4 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Method",
					" (",
					string_4,
					", ",
					text,
					", ",
					string_5,
					", ",
					text2,
					", ",
					text3,
					", ",
					text4,
					")"
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00075098 File Offset: 0x00073298
		internal static string smethod_1303(bool bool_10)
		{
			return GClass84.smethod_606(bool_10);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000750AC File Offset: 0x000732AC
		internal static void smethod_1304(string string_4, string string_5, string string_6, Action action_0, string string_7, Action action_1)
		{
			GClass84.smethod_426(string_4, string_5, string_6, action_0, string_7, action_1);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000750CC File Offset: 0x000732CC
		internal static void smethod_1305(string string_4)
		{
			if (!GClass84.hashSet_0.Contains(string_4))
			{
				GClass84.smethod_1050("using" + " " + string_4 + ";", false);
				GClass84.hashSet_0.Add(string_4);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00075110 File Offset: 0x00073310
		internal static Player smethod_1306(PlayerNet playerNet_0)
		{
			return GClass84.smethod_1513(GClass84.smethod_440(playerNet_0));
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0007512C File Offset: 0x0007332C
		internal static List<char> smethod_1307()
		{
			return CollectionExtensions.AddRangeToArray<char>(GClass193.char_1, GClass193.char_3).ToList<char>();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00075150 File Offset: 0x00073350
		internal static void smethod_1308(Slider slider_0, UnityAction<float> unityAction_0)
		{
			GClass84.smethod_1621(slider_0, unityAction_0);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00075164 File Offset: 0x00073364
		internal static GameObject smethod_1309()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			return (vrcplayer != null) ? vrcplayer.gameObject : null;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00075184 File Offset: 0x00073384
		internal static void smethod_1310(ApiAvatar apiAvatar_0)
		{
			apiAvatar_0.Delete(new Action<ApiContainer>(GClass84.Class101.class101_0.method_6), new Action<ApiContainer>(GClass84.Class101.class101_0.method_25));
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000751E0 File Offset: 0x000733E0
		internal static bool smethod_1311(string string_4)
		{
			bool result;
			if (string_4 == null || string_4 == string.Empty)
			{
				result = false;
			}
			else
			{
				APIUser apiuser = GClass84.smethod_1372();
				result = (apiuser != null && apiuser.friendIDs.Contains(string_4));
			}
			return result;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00075224 File Offset: 0x00073424
		internal static void smethod_1312(GameObject gameObject_39)
		{
			GClass84.smethod_984(gameObject_39);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00075238 File Offset: 0x00073438
		internal static void smethod_1313(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_573(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00075258 File Offset: 0x00073458
		internal static void smethod_1314(Player player_0)
		{
			GClass84.smethod_179(player_0);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0007526C File Offset: 0x0007346C
		internal static void smethod_1315(string string_4, string string_5, string string_6)
		{
			if (!GClass84.smethod_334(string_4))
			{
				NotificationManager notificationManager = GClass84.smethod_10();
				if (notificationManager)
				{
				}
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00066C54 File Offset: 0x00064E54
		internal static GameObject smethod_1316(Player player_0)
		{
			GameObject result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_428(player_0.transform);
			}
			return result;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00075294 File Offset: 0x00073494
		internal static void smethod_1317()
		{
			GClass84.smethod_24();
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000752A8 File Offset: 0x000734A8
		internal static void smethod_1318(Transform transform_0, bool bool_10 = false)
		{
			GClass84.smethod_545(transform_0, bool_10);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000752BC File Offset: 0x000734BC
		internal static void smethod_1319(Vector2 vector2_0, Vector2 vector2_1, Color color_0)
		{
			if (!GClass84.material_0)
			{
				GClass84.smethod_810();
				if (!GClass84.material_0)
				{
					GClass70.smethod_36("LineMaterial is null!", GClass70.Enum1.const_0);
					return;
				}
			}
			GClass84.material_0.SetPass(0);
			GL.PushMatrix();
			GL.Begin(1);
			GL.Color(color_0);
			GL.Vertex(new Vector3(vector2_0.x, vector2_0.y, 0f));
			GL.Vertex(new Vector3(vector2_1.x, vector2_1.y, 0f));
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00075358 File Offset: 0x00073558
		internal static void smethod_1320(List<Transform> list_51, GameObject gameObject_39)
		{
			GClass84.smethod_924(list_51, gameObject_39);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0007536C File Offset: 0x0007356C
		internal static void smethod_1321()
		{
			GClass84.list_44.Add(MelonCoroutines.Start(GClass84.smethod_1537()));
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00075390 File Offset: 0x00073590
		internal static string smethod_1322(string string_4, string string_5)
		{
			return GClass84.smethod_37(string_4, string_5);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000753A4 File Offset: 0x000735A4
		internal static bool smethod_1323(Type type_0, string string_4, Type[] type_1, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_853("Abyss Client_1.0.0", type_0, string_4, type_1, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000753C4 File Offset: 0x000735C4
		internal static string smethod_1324(GameObject gameObject_39)
		{
			return GClass84.smethod_203(gameObject_39);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000753D8 File Offset: 0x000735D8
		internal static void smethod_1325(bool bool_10)
		{
			GClass84.smethod_1339(bool_10);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000753EC File Offset: 0x000735EC
		internal static void smethod_1326(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_520(apiAvatar_0);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00075400 File Offset: 0x00073600
		internal static void smethod_1327(bool bool_10 = true)
		{
			GClass84.smethod_862(bool_10);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00075414 File Offset: 0x00073614
		internal static void smethod_1328(float float_3)
		{
			GClass84.smethod_1353(float_3);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00075428 File Offset: 0x00073628
		internal static void smethod_1329()
		{
			GClass84.smethod_875();
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0007543C File Offset: 0x0007363C
		internal static GameObject smethod_1330(List<string> list_51)
		{
			Transform transform = GClass84.smethod_1454(list_51);
			return (transform != null) ? transform.gameObject : null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00075460 File Offset: 0x00073660
		internal static void smethod_1331(Vector3 vector3_0, Vector3 vector3_1, Color color_0)
		{
			GClass84.smethod_255(vector3_0, vector3_1, color_0);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00075478 File Offset: 0x00073678
		internal static string smethod_1332(APIUser apiuser_0, string string_4)
		{
			string result;
			if (apiuser_0 == null)
			{
				result = string_4;
			}
			else
			{
				result = apiuser_0.displayName;
			}
			return result;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00075498 File Offset: 0x00073698
		internal static PlayerNet smethod_1333(VRCPlayer vrcplayer_0)
		{
			return (vrcplayer_0 != null) ? vrcplayer_0.Method_Public_get_PlayerNet_0() : null;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000754B4 File Offset: 0x000736B4
		internal static List<T> smethod_1334<T>(this List<T> list_51)
		{
			return (list_51 != null) ? list_51.ToArray().ToList<T>() : null;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000754D4 File Offset: 0x000736D4
		internal static void smethod_1335(PortalInternal portalInternal_0)
		{
			GClass84.smethod_1701(portalInternal_0);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000754E8 File Offset: 0x000736E8
		internal static void smethod_1336(float float_3)
		{
			GClass84.smethod_1246(float_3);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000754FC File Offset: 0x000736FC
		internal static void smethod_1337(UiVRCList uiVRCList_0)
		{
			if (uiVRCList_0)
			{
				GridLayoutGroup field_Private_GridLayoutGroup_ = uiVRCList_0.field_Private_GridLayoutGroup_0;
				if (field_Private_GridLayoutGroup_)
				{
					Transform transform = field_Private_GridLayoutGroup_.transform;
					if (transform)
					{
						List<Transform> list = GClass84.smethod_403(transform);
						for (int i = list.Count - 1; i >= 0; i--)
						{
							Transform transform2 = list[i].Find("RoomOutline");
							Transform transform3 = list[i].Find("GrayScaleMask");
							Transform transform4 = list[i].Find("AndroidUnavailableOverlay");
							if (transform2)
							{
								Object.DestroyImmediate(transform2.gameObject, true);
							}
							if (transform3)
							{
								Object.DestroyImmediate(transform3.gameObject, true);
							}
							if (transform4)
							{
								Object.DestroyImmediate(transform4.gameObject, true);
							}
							Transform transform5 = list[i].Find("RoomImageShape");
							if (transform5)
							{
								Image component = transform5.GetComponent<Image>();
								Mask component2 = transform5.GetComponent<Mask>();
								CanvasGroup component3 = transform5.GetComponent<CanvasGroup>();
								if (component)
								{
									Object.DestroyImmediate(component, true);
								}
								if (component2)
								{
									Object.DestroyImmediate(component2, true);
								}
								if (component3)
								{
									Object.DestroyImmediate(component3, true);
								}
								Transform transform6 = transform5.Find("RoomImage");
								if (transform6)
								{
									Transform transform7 = transform6.Find("Panel");
									if (transform7)
									{
										Vector3 localPosition = transform7.localPosition;
										localPosition.y = -80.95f;
										transform7.localPosition = localPosition;
										RectTransform component4 = transform7.GetComponent<RectTransform>();
										if (component4)
										{
											Vector2 sizeDelta = component4.sizeDelta;
											sizeDelta.x = 0f;
											component4.sizeDelta = sizeDelta;
										}
									}
								}
								Transform transform8 = transform5.Find("OverlayIcons");
								if (transform8)
								{
									Object.DestroyImmediate(transform8.gameObject, true);
								}
							}
							Transform transform9 = list[i].Find("TitleText");
							if (transform9)
							{
								Vector3 localPosition2 = transform9.localPosition;
								localPosition2.y = -76.95f;
								transform9.localPosition = localPosition2;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00075734 File Offset: 0x00073934
		internal static void smethod_1338(MeshFilter meshFilter_0, bool bool_10)
		{
			GClass84.smethod_1228(meshFilter_0, bool_10);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00075748 File Offset: 0x00073948
		internal static void smethod_1339(bool bool_10)
		{
			GClass84.smethod_1680(GClass84.smethod_459(bool_10));
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00075760 File Offset: 0x00073960
		internal static void smethod_1340(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				string assetUrl = apiAvatar_0.assetUrl;
				if (!string.IsNullOrEmpty(assetUrl))
				{
					Clipboard.SetText(assetUrl);
					GClass70.smethod_38(assetUrl, GClass70.Enum1.const_0);
					Process.Start(assetUrl);
				}
				else
				{
					GClass70.smethod_38("assetUrl Is Null!", GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000757B4 File Offset: 0x000739B4
		internal static Transform smethod_1341(VRCPlayerApi vrcplayerApi_0)
		{
			Transform result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_889(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000757D8 File Offset: 0x000739D8
		internal static string smethod_1342(Component component_0, GameObject gameObject_39)
		{
			return GClass84.smethod_1134(component_0, gameObject_39);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000757EC File Offset: 0x000739EC
		internal static void smethod_1343(VRCPlayer vrcplayer_0, GameObject gameObject_39, string string_4, object[] object_0)
		{
			GClass84.smethod_1199(vrcplayer_0, gameObject_39, string_4, object_0);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00075804 File Offset: 0x00073A04
		internal static void smethod_1344(Player player_0, Player player_1, Action<Player, Player, bool> action_0)
		{
			if (!(player_1 == null))
			{
				APIUser apiuser = GClass84.smethod_1372();
				if (apiuser != null && player_0)
				{
					APIUser apiuser2 = GClass84.smethod_518(player_0);
					if (apiuser2 != null && action_0 != null)
					{
						action_0(player_1, player_0, GClass84.smethod_653(apiuser2) == GClass84.smethod_653(apiuser));
					}
				}
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0007585C File Offset: 0x00073A5C
		internal static void smethod_1345(Mesh mesh_0)
		{
			GClass84.smethod_486(mesh_0);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00075870 File Offset: 0x00073A70
		internal static float smethod_1346()
		{
			LocomotionInputController locomotionInputController = GClass84.smethod_1487();
			float result;
			if (!locomotionInputController)
			{
				result = 0f;
			}
			else
			{
				result = locomotionInputController.field_Public_Single_3;
			}
			return result;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000758A0 File Offset: 0x00073AA0
		internal static List<GameObject> smethod_1347(List<GameObject> list_51, int int_1)
		{
			List<GameObject> result;
			if (list_51 == null || list_51.Count < 1)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_193(list_51[i], int_1));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000758F8 File Offset: 0x00073AF8
		internal static void smethod_1348(float float_3, float float_4)
		{
			GClass84.smethod_1007(float_3, float_4);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0007590C File Offset: 0x00073B0C
		internal static void smethod_1349(Task task_0, string string_4)
		{
			GClass84.smethod_1139(task_0, string_4);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00075920 File Offset: 0x00073B20
		internal static void smethod_1350(float float_3)
		{
			GClass84.smethod_1328(float_3);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00075934 File Offset: 0x00073B34
		internal static Scene smethod_1351()
		{
			return SceneManager.GetActiveScene();
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00075948 File Offset: 0x00073B48
		internal static string smethod_1352()
		{
			return GClass84.smethod_1152();
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0007595C File Offset: 0x00073B5C
		internal static void smethod_1353(float float_3)
		{
			GClass84.smethod_1696(30f - float_3);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00075978 File Offset: 0x00073B78
		internal static void smethod_1354(Type type_0)
		{
			GClass84.smethod_1107(type_0);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0007598C File Offset: 0x00073B8C
		internal static GameObject smethod_1355(VRCPlayerApi vrcplayerApi_0)
		{
			GameObject result;
			if (vrcplayerApi_0 == null)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1061(vrcplayerApi_0.gameObject);
			}
			return result;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000759B0 File Offset: 0x00073BB0
		internal static GameObject smethod_1356(string string_4, Vector3 vector3_0, Quaternion quaternion_0)
		{
			return Networking.Instantiate(0, string_4, vector3_0, quaternion_0);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000759C8 File Offset: 0x00073BC8
		internal static void smethod_1357(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_1326(apiAvatar_0);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000759DC File Offset: 0x00073BDC
		internal static List<string> smethod_1358(List<UdonBehaviour> list_51, bool bool_10 = false)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < list_51.Count; i++)
			{
				if (list_51[i])
				{
					Dictionary<string, List<uint>>.Enumerator enumerator = list_51[i]._eventTable.GetEnumerator();
					for (int j = 0; j < list_51[i]._eventTable.Count; j++)
					{
						if (enumerator.MoveNext())
						{
							list.Add(enumerator.Current.key);
						}
					}
				}
			}
			if (bool_10)
			{
				GClass84.smethod_661<string>(ref list);
			}
			return list;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00075A6C File Offset: 0x00073C6C
		internal static string smethod_1359(string string_4)
		{
			return string_4.ToLower();
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00075A84 File Offset: 0x00073C84
		internal static List<GClass84.GStruct163> smethod_1360(int int_1, int int_2, int int_3)
		{
			int num = 0;
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			int i = int_3;
			int num2 = 1 - 2 * int_3;
			while (i >= 0)
			{
				list.Add(new GClass84.GStruct163(int_1 + num, int_2 + i));
				list.Add(new GClass84.GStruct163(int_1 + num, int_2 - i));
				list.Add(new GClass84.GStruct163(int_1 - num, int_2 + i));
				list.Add(new GClass84.GStruct163(int_1 - num, int_2 - i));
				int num3 = 2 * (num2 + i) - 1;
				if (num2 < 0 && num3 <= 0)
				{
					num2 += 2 * ++num + 1;
				}
				else if (num2 > 0 && num3 > 0)
				{
					num2 -= 2 * --i + 1;
				}
				else
				{
					num2 += 2 * (++num - i--);
				}
			}
			return list;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00075B50 File Offset: 0x00073D50
		internal static bool smethod_1361(string string_4, MethodBase methodBase_0, HarmonyMethod harmonyMethod_0)
		{
			bool result;
			try
			{
				result = Class203.smethod_1(string_4, methodBase_0, harmonyMethod_0.method);
			}
			catch (Exception ex)
			{
				string text = "Null";
				string text2 = "Null";
				if (methodBase_0 != null)
				{
					text = methodBase_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text2 = harmonyMethod_0.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Patching",
					" (",
					string_4,
					", ",
					text,
					", ",
					text2,
					"): ",
					ex.Message
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00075C28 File Offset: 0x00073E28
		internal static Texture2D smethod_1362(int int_1, int int_2, List<GClass84.Struct17> list_51)
		{
			Texture2D texture2D = GClass84.smethod_1130(int_1, int_2);
			for (int i = list_51.Count - 1; i >= 0; i--)
			{
				Color32[] array = new Color32[list_51[i].int_2 * list_51[i].int_3];
				for (int j = 0; j < list_51[i].int_3; j++)
				{
					int num = list_51[i].int_3 - j - 1;
					for (int k = 0; k < list_51[i].int_2; k++)
					{
						array[num * list_51[i].int_2 + k] = list_51[i].color32_0;
					}
				}
				texture2D.SetPixels32(list_51[i].int_0, int_2 - list_51[i].int_1 - list_51[i].int_3, list_51[i].int_2, list_51[i].int_3, array);
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00075D3C File Offset: 0x00073F3C
		internal static void smethod_1363(List<GameObject> list_51, bool bool_10)
		{
			GClass84.smethod_61(list_51, bool_10);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00075D50 File Offset: 0x00073F50
		internal static void smethod_1364(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			GClass84.smethod_1159(gclass156_1, int_1, int_2, int_3, int_4, int_5, int_6);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00075D74 File Offset: 0x00073F74
		internal static void smethod_1365(Task task_0, string string_4 = null)
		{
			GClass84.smethod_1349(task_0, string_4);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00075D88 File Offset: 0x00073F88
		internal static Vector3 smethod_1366(Vector2 vector2_0)
		{
			return new Vector3(vector2_0.x, 0f, vector2_0.y);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00075DB0 File Offset: 0x00073FB0
		internal static void smethod_1367(float float_3)
		{
			if (GClass84.gameObject_0 && GClass84.text_0 && GClass84.gameObject_1)
			{
				if (GClass84.list_35.Count == 0)
				{
					GClass84.text_0.text = string.Empty;
				}
				else
				{
					GClass84.GStruct174 gstruct = GClass84.list_35[0];
					gstruct.float_0 -= float_3;
					GClass84.text_0.text = gstruct.string_0;
					float a;
					if (gstruct.float_0 < 1f)
					{
						a = gstruct.float_0;
					}
					else if (gstruct.float_1 - gstruct.float_0 < 1f)
					{
						a = gstruct.float_1 - gstruct.float_0;
					}
					else
					{
						a = 1f;
					}
					Color color_ = gstruct.color_0;
					color_.a = a;
					GClass84.text_0.color = color_;
					if (gstruct.float_0 <= 0f)
					{
						GClass84.list_35.RemoveAt(0);
					}
					else
					{
						GClass84.list_35[0] = gstruct;
					}
				}
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00075EC0 File Offset: 0x000740C0
		internal static void smethod_1368()
		{
			GClass84.smethod_1658();
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00075ED4 File Offset: 0x000740D4
		internal static bool smethod_1369(string string_4)
		{
			return !string.IsNullOrEmpty(string_4) && ((GClass84.smethod_593(string_4) == GClass84.smethod_593("wrld_********-****-****-****-************") && GClass84.smethod_1428(string_4, GClass84.smethod_593("wrld_")) == "wrld_") || (GClass84.smethod_593(string_4) == GClass84.smethod_593("wld_********-****-****-****-************") && GClass84.smethod_1428(string_4, GClass84.smethod_593("wld_")) == "wld_"));
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00075F4C File Offset: 0x0007414C
		internal static void smethod_1370(float float_3, float float_4, float float_5)
		{
			GClass84.smethod_679(float_3, float_4, float_5);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00075F64 File Offset: 0x00074164
		internal static IEnumerator smethod_1371()
		{
			return new GClass84.Class124(0);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00075F78 File Offset: 0x00074178
		internal static APIUser smethod_1372()
		{
			return APIUser.CurrentUser;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00075F8C File Offset: 0x0007418C
		internal static bool smethod_1373(string string_4)
		{
			return string.IsNullOrEmpty(string_4) || ((GClass84.smethod_593(string_4) != GClass84.smethod_593("wrld_********-****-****-****-************") || GClass84.smethod_1428(string_4, GClass84.smethod_593("wrld_")) != "wrld_") && (GClass84.smethod_593(string_4) != GClass84.smethod_593("wld_********-****-****-****-************") || GClass84.smethod_1428(string_4, GClass84.smethod_593("wld_")) != "wld_"));
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00076004 File Offset: 0x00074204
		internal static bool smethod_1374(VRCPlayer vrcplayer_0, out GClass84.Enum8 enum8_0)
		{
			EnumPublicSealedva5vUnique enumPublicSealedva5vUnique_;
			bool result = vrcplayer_0.Method_Public_Boolean_byref_EnumPublicSealedva5vUnique_0(ref enumPublicSealedva5vUnique_);
			enum8_0 = GClass84.smethod_1301(enumPublicSealedva5vUnique_);
			return result;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00076024 File Offset: 0x00074224
		internal static bool smethod_1375(byte byte_0, object object_0, RaiseEventOptions raiseEventOptions_0, SendOptions sendOptions_0)
		{
			return GClass84.smethod_1659(byte_0, GClass84.smethod_917<Object>(object_0), raiseEventOptions_0, sendOptions_0);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00076040 File Offset: 0x00074240
		internal static VRC_EventLog smethod_1376()
		{
			return VRC_EventLog.field_Internal_Static_VRC_EventLog_0;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00076054 File Offset: 0x00074254
		internal static bool smethod_1377()
		{
			string string_;
			bool result;
			if (GClass84.smethod_1588(out string_))
			{
				MelonCoroutines.Start(GClass84.smethod_935(string_));
				result = true;
			}
			else
			{
				GClass70.smethod_38("Can't Get Quest Avatar!", GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00076088 File Offset: 0x00074288
		internal static void smethod_1378()
		{
			GClass84.smethod_1037();
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0007609C File Offset: 0x0007429C
		internal static bool smethod_1379(Vector3 vector3_0, bool bool_10 = false)
		{
			bool result = false;
			List<GameObject> list = GClass84.smethod_589();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if ((bool_10 || list[i].activeInHierarchy) && GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000760F4 File Offset: 0x000742F4
		internal static Texture2D smethod_1380(Texture2D texture2D_0)
		{
			Color[] array = texture2D_0.GetPixels();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_1465(array[i]);
			}
			texture2D_0.SetPixels(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0007614C File Offset: 0x0007434C
		internal static Transform smethod_1381()
		{
			GameObject gameObject = GClass84.smethod_1434();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0007616C File Offset: 0x0007436C
		internal static string smethod_1382(APIUser apiuser_0)
		{
			string result;
			if (apiuser_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = apiuser_0.username;
			}
			return result;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00076190 File Offset: 0x00074390
		internal static void smethod_1383()
		{
			GClass84.smethod_230();
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000761A4 File Offset: 0x000743A4
		internal static List<int> smethod_1384(string string_4, string string_5, int int_1, int int_2)
		{
			List<int> list = new List<int>();
			List<int> result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = list;
			}
			else
			{
				int num = 0;
				int_2 = GClass84.smethod_741(int_2, GClass84.smethod_593(string_4));
				while (int_1 < int_2)
				{
					if (string_4[int_1] == string_5[num])
					{
						num++;
						if (num == GClass84.smethod_593(string_5))
						{
							list.Add(int_1 - num);
							num = 0;
						}
					}
					else
					{
						num = 0;
					}
					int_1++;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00076228 File Offset: 0x00074428
		internal static bool smethod_1385(Material material_1)
		{
			bool result;
			if (!material_1)
			{
				result = false;
			}
			else
			{
				material_1.renderQueue = 3000;
				result = false;
			}
			return result;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00076254 File Offset: 0x00074454
		internal static void smethod_1386(VRC_SpatialAudioSource vrc_SpatialAudioSource_0)
		{
			GClass84.smethod_791(vrc_SpatialAudioSource_0);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00076268 File Offset: 0x00074468
		internal static GClass84.Enum5 smethod_1387(APIUser apiuser_0, bool bool_10 = false)
		{
			if (apiuser_0 != null)
			{
				if (bool_10 && GClass84.smethod_1511(apiuser_0))
				{
					return GClass84.Enum5.const_7;
				}
				if (apiuser_0.tags != null && apiuser_0.tags.Count > 0)
				{
					if (apiuser_0.tags.Contains("system_trust_trusted"))
					{
						if (apiuser_0.tags.Contains("system_trust_legend"))
						{
							if (apiuser_0.tags.Contains("system_legend"))
							{
								return GClass84.Enum5.const_6;
							}
							return GClass84.Enum5.const_5;
						}
						else
						{
							if (apiuser_0.tags.Contains("system_trust_veteran"))
							{
								return GClass84.Enum5.const_4;
							}
							return GClass84.Enum5.const_3;
						}
					}
					else
					{
						if (apiuser_0.tags.Contains("system_trust_known"))
						{
							return GClass84.Enum5.const_2;
						}
						if (apiuser_0.tags.Contains("system_trust_basic"))
						{
							return GClass84.Enum5.const_1;
						}
					}
				}
			}
			return GClass84.Enum5.const_0;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00076338 File Offset: 0x00074538
		internal static Vector3 smethod_1388(byte[] byte_0, int int_1)
		{
			float num = BitConverter.ToSingle(byte_0, int_1);
			float num2 = BitConverter.ToSingle(byte_0, int_1 + 4);
			float num3 = BitConverter.ToSingle(byte_0, int_1 + 8);
			return new Vector3(num, num2, num3);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0007636C File Offset: 0x0007456C
		internal static void smethod_1389(Player player_0)
		{
			GClass84.smethod_1742(player_0);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00076380 File Offset: 0x00074580
		internal static void smethod_1390(bool bool_10 = false)
		{
			GClass84.smethod_1325(bool_10);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00076394 File Offset: 0x00074594
		internal static void smethod_1391()
		{
			GClass84.smethod_1132();
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000763A8 File Offset: 0x000745A8
		internal static Transform smethod_1392()
		{
			GameObject gameObject = GClass84.smethod_23();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000763C8 File Offset: 0x000745C8
		internal static List<GClass84.GStruct134> smethod_1393(GameObject gameObject_39)
		{
			List<GClass84.GStruct134> result;
			if (!gameObject_39)
			{
				result = new List<GClass84.GStruct134>();
			}
			else
			{
				result = GClass84.smethod_1418(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000763F8 File Offset: 0x000745F8
		internal static bool smethod_1394(MethodBase methodBase_0, HarmonyMethod harmonyMethod_0)
		{
			bool result;
			try
			{
				result = Class203.smethod_1("Abyss Client_1.0.0", methodBase_0, harmonyMethod_0.method);
			}
			catch (Exception ex)
			{
				string text = "Null";
				string text2 = "Null";
				if (methodBase_0 != null)
				{
					text = methodBase_0.Name;
				}
				if (harmonyMethod_0 != null)
				{
					text2 = harmonyMethod_0.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Patching",
					" (",
					text,
					", ",
					text2,
					"): ",
					ex.Message
				}), GClass70.Enum1.const_0);
				result = false;
			}
			return result;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000764C4 File Offset: 0x000746C4
		internal static int smethod_1395()
		{
			DateTime now = DateTime.Now;
			return now.Minute * 60000 + now.Second * 1000 + now.Millisecond;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000764FC File Offset: 0x000746FC
		internal static object[] smethod_1396(Object[] object_0)
		{
			object[] array = new object[object_0.Length];
			for (int i = 0; i < object_0.Length; i++)
			{
				array[i] = GClass84.smethod_308<object>(object_0[i]);
			}
			return array;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00076530 File Offset: 0x00074730
		internal static string smethod_1397(string string_4)
		{
			GClass84.Class126 @class = new GClass84.Class126();
			string result = string.Empty;
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			@class.registryKey_0 = registryKey.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
			if (@class.registryKey_0 != null)
			{
				IEnumerable<string> subKeyNames = @class.registryKey_0.GetSubKeyNames();
				Func<string, RegistryKey> selector;
				if ((selector = @class.func_0) == null)
				{
					selector = (@class.func_0 = new Func<string, RegistryKey>(@class.method_0));
				}
				foreach (RegistryKey registryKey2 in subKeyNames.Select(selector))
				{
					string text = registryKey2.GetValue("DisplayName") as string;
					if (text != null && text.ToLower().Contains(string_4))
					{
						result = registryKey2.GetValue("InstallLocation").ToString();
						break;
					}
				}
				@class.registryKey_0.Close();
			}
			return result;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00076630 File Offset: 0x00074830
		internal static GameObject smethod_1398()
		{
			if (!GClass84.gameObject_2)
			{
				GClass84.gameObject_2 = GameObject.Find(GClass84.smethod_1475());
			}
			return GClass84.gameObject_2;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00076664 File Offset: 0x00074864
		internal static void smethod_1399(VRCPlayerApi vrcplayerApi_0)
		{
			GClass84.smethod_672(vrcplayerApi_0);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00076678 File Offset: 0x00074878
		internal static void smethod_1400(List<Transform> list_51, Transform transform_0)
		{
			GClass84.smethod_1722(list_51, transform_0);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0007668C File Offset: 0x0007488C
		internal static void smethod_1401()
		{
			GClass84.smethod_642();
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000766A0 File Offset: 0x000748A0
		internal static void smethod_1402(string string_4)
		{
			GClass84.smethod_1626(string_4);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000766B4 File Offset: 0x000748B4
		internal static Transform smethod_1403()
		{
			return GClass84.smethod_165(GClass84.smethod_460());
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000766D0 File Offset: 0x000748D0
		internal static void smethod_1404(Color color_0, string string_4)
		{
			GClass84.smethod_1189(color_0, string_4);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000766E4 File Offset: 0x000748E4
		internal static void smethod_1405(ref string string_4, string string_5, string string_6)
		{
			GClass84.smethod_773(ref string_4, string_5, string_6);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000766FC File Offset: 0x000748FC
		internal static void smethod_1406(float float_3, float float_4, float float_5)
		{
			GClass84.smethod_76(float_3, float_4, float_5);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00076714 File Offset: 0x00074914
		internal static void smethod_1407(string string_4, string string_5)
		{
			if (!GClass84.smethod_334(string_5))
			{
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0007672C File Offset: 0x0007492C
		internal static string smethod_1408(uint uint_0)
		{
			return new IPAddress(new byte[]
			{
				(byte)(uint_0 >> 24 & 255U),
				(byte)(uint_0 >> 16 & 255U),
				(byte)(uint_0 >> 8 & 255U),
				(byte)(uint_0 & 255U)
			}).ToString();
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00076780 File Offset: 0x00074980
		internal static Transform smethod_1409()
		{
			GameObject gameObject = GClass84.smethod_740();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000767A0 File Offset: 0x000749A0
		internal static Texture2D smethod_1410(byte[] byte_0)
		{
			Texture2D result;
			if (byte_0.Length < 1)
			{
				result = null;
			}
			else
			{
				Stream stream = new MemoryStream(byte_0);
				result = GClass84.smethod_112(new Bitmap(stream));
			}
			return result;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000767D0 File Offset: 0x000749D0
		internal static string smethod_1411()
		{
			return "UserInterface/MenuContent/Screens/Worlds";
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000767E4 File Offset: 0x000749E4
		internal static void smethod_1412()
		{
			GClass84.smethod_1617();
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000767F8 File Offset: 0x000749F8
		internal static void smethod_1413(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			if (gclass156_1 != null)
			{
				int_5 = GClass84.smethod_1690(int_5, 1);
				if (int_1 == int_3)
				{
					gclass156_1.method_61((float)(int_1 - (int_5 + 1) / 2), (float)(GClass84.smethod_741(int_2, int_4) - 1));
					gclass156_1.method_227(GClass153.GClass87.texture2D_0, (float)int_5, (float)(GClass84.smethod_624(int_2 - int_4) + 1), 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
				}
				else if (int_2 == int_4)
				{
					gclass156_1.method_61((float)(GClass84.smethod_741(int_1, int_3) - 1), (float)(int_2 - (int_5 + 1) / 2));
					gclass156_1.method_227(GClass153.GClass87.texture2D_0, (float)(GClass84.smethod_624(int_1 - int_3) + 1), (float)int_5, 0f, 0f, 1f, 1f, GClass156.Enum10.const_1);
				}
				else if (GClass84.smethod_624(int_2 - int_4) > GClass84.smethod_624(int_1 - int_3))
				{
					GClass84.smethod_581(gclass156_1, int_1, int_2, int_3, int_4, int_5);
				}
				else
				{
					GClass84.smethod_68(gclass156_1, int_1, int_2, int_3, int_4, int_5);
				}
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000768F0 File Offset: 0x00074AF0
		internal static void smethod_1414(string string_4, Action action_0 = null, Action action_1 = null, Action action_2 = null)
		{
			GClass84.smethod_404(string_4, action_0, action_1, action_2);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00076908 File Offset: 0x00074B08
		internal static void smethod_1415()
		{
			GClass84.smethod_544();
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0007691C File Offset: 0x00074B1C
		internal static VRCAvatarManager smethod_1416(VRCPlayer vrcplayer_0)
		{
			return (vrcplayer_0 != null) ? vrcplayer_0.Method_Public_get_VRCAvatarManager_0() : null;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00076938 File Offset: 0x00074B38
		internal static Color smethod_1417(Color color_0)
		{
			return new Color((float)color_0.R / 255f, (float)color_0.G / 255f, (float)color_0.B / 255f, (float)color_0.A / 255f);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00076984 File Offset: 0x00074B84
		internal static List<GClass84.GStruct134> smethod_1418(Transform transform_0)
		{
			List<GClass84.GStruct134> result;
			if (!transform_0)
			{
				result = new List<GClass84.GStruct134>();
			}
			else
			{
				SkinnedMeshRenderer component = transform_0.GetComponent<SkinnedMeshRenderer>();
				if (component)
				{
					result = GClass84.smethod_1728(component);
				}
				else
				{
					MeshFilter component2 = transform_0.GetComponent<MeshFilter>();
					if (component2)
					{
						result = GClass84.smethod_224(component2);
					}
					else
					{
						result = new List<GClass84.GStruct134>();
					}
				}
			}
			return result;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000769DC File Offset: 0x00074BDC
		internal static void smethod_1419()
		{
			if (GClass84.smethod_1126() < 1)
			{
				GClass84.list_50.Add(MelonCoroutines.Start(GClass84.smethod_724()));
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00076A08 File Offset: 0x00074C08
		internal static int smethod_1420()
		{
			return GClass84.list_43.Count;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00076A24 File Offset: 0x00074C24
		internal static Transform smethod_1421()
		{
			GameObject gameObject = GClass84.smethod_1489();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00076A44 File Offset: 0x00074C44
		internal static Player smethod_1422(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_1513(GClass84.smethod_384(vrcplayer_0));
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00076A60 File Offset: 0x00074C60
		internal static List<GameObject> smethod_1423(Transform transform_0, List<Transform> list_51)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				if (list_51 == null || list_51.Count == 0)
				{
					GClass84.smethod_471(transform_0);
				}
				List<GameObject> list = new List<GameObject>();
				int i = 0;
				IL_98:
				while (i < transform_0.childCount)
				{
					Transform child = transform_0.GetChild(i);
					bool flag = false;
					for (int j = 0; j < list_51.Count; j++)
					{
						if (list_51[j] == child)
						{
							flag = true;
							IL_73:
							if (!flag)
							{
								list.Add(child.gameObject);
								list.AddRange(GClass84.smethod_1423(child, list_51));
							}
							i++;
							goto IL_98;
						}
					}
					goto IL_73;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00076B14 File Offset: 0x00074D14
		internal static ApiWorld smethod_1424()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00076B28 File Offset: 0x00074D28
		internal static void smethod_1425(AvatarPerformanceStats avatarPerformanceStats_0, AvatarPerformanceStats avatarPerformanceStats_1, bool bool_10)
		{
			GClass84.smethod_389(avatarPerformanceStats_0, avatarPerformanceStats_1, bool_10);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00076B40 File Offset: 0x00074D40
		internal static GClass84.GStruct131 smethod_1426(GameObject gameObject_39, GameObject gameObject_40 = null)
		{
			GClass84.GStruct131 result;
			if (!gameObject_39)
			{
				result = new GClass84.GStruct131(string.Empty, string.Empty);
			}
			else
			{
				string text = string.Empty;
				GameObject gameObject = null;
				if (gameObject_39.transform.parent)
				{
					gameObject = gameObject_39.transform.parent.gameObject;
				}
				if (gameObject_40)
				{
					while (gameObject != gameObject_40)
					{
						text = gameObject.name + "/" + text;
						if (gameObject.transform.parent)
						{
							gameObject = gameObject.transform.parent.gameObject;
						}
						else
						{
							gameObject = null;
						}
					}
				}
				else
				{
					while (gameObject)
					{
						text = gameObject.name + "/" + text;
						if (gameObject.transform.parent)
						{
							gameObject = gameObject.transform.parent.gameObject;
						}
						else
						{
							gameObject = null;
						}
					}
				}
				if (text.Length > 0)
				{
					text = GClass84.smethod_1428(text, text.Length - 1);
				}
				result = new GClass84.GStruct131(text, gameObject_39.name);
			}
			return result;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00076C50 File Offset: 0x00074E50
		internal static Transform smethod_1427(Transform transform_0)
		{
			Transform result;
			if (!transform_0)
			{
				result = null;
			}
			else
			{
				Transform transform = GClass84.smethod_836(transform_0, new List<string>
				{
					"ForwardDirection"
				});
				if (!transform)
				{
					result = null;
				}
				else
				{
					result = GClass84.smethod_836(transform, new List<string>
					{
						"_AvatarMirrorClone"
					});
				}
			}
			return result;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00076CAC File Offset: 0x00074EAC
		internal static string smethod_1428(string string_4, int int_1)
		{
			return GClass84.smethod_1241(string_4, int_1);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00076CC0 File Offset: 0x00074EC0
		internal static GClass84.GStruct169 smethod_1429(int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.GStruct169 result = new GClass84.GStruct169(new List<GClass84.GStruct163>(), new List<GClass84.GStruct163>());
			if (int_1 == int_3)
			{
				result.method_0(new GClass84.GStruct163(int_1, GClass84.smethod_741(int_2, int_4)), new GClass84.GStruct163(1, GClass84.smethod_624(int_2 - int_4)));
			}
			else if (int_2 == int_4)
			{
				result.method_0(new GClass84.GStruct163(GClass84.smethod_741(int_1, int_3), int_2), new GClass84.GStruct163(GClass84.smethod_624(int_1 - int_3), 1));
			}
			else
			{
				if (GClass84.smethod_624(int_2 - int_4) > GClass84.smethod_624(int_1 - int_3))
				{
					return GClass84.smethod_1218(int_1, int_2, int_3, int_4);
				}
				return GClass84.smethod_335(int_1, int_2, int_3, int_4);
			}
			return result;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00076D64 File Offset: 0x00074F64
		internal static VRCPlayerApi smethod_1430(int int_1)
		{
			List<VRCPlayerApi> list = GClass84.smethod_1239();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].playerId == int_1)
				{
					return list[i];
				}
			}
			return null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00076DB0 File Offset: 0x00074FB0
		internal static bool smethod_1431(Transform transform_0, GameObject gameObject_39)
		{
			return transform_0 && gameObject_39 && GClass84.smethod_1493(transform_0, gameObject_39.transform);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00076DE8 File Offset: 0x00074FE8
		internal static void smethod_1432()
		{
			GClass84.list_47.Add(MelonCoroutines.Start(GClass84.smethod_122()));
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00076E0C File Offset: 0x0007500C
		internal static void smethod_1433()
		{
			GClass84.smethod_443();
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00076E20 File Offset: 0x00075020
		internal static GameObject smethod_1434()
		{
			if (!GClass84.gameObject_24)
			{
				GClass84.gameObject_24 = GameObject.Find(GClass84.smethod_1352());
			}
			return GClass84.gameObject_24;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00076E54 File Offset: 0x00075054
		internal static void smethod_1435(this Player player_0)
		{
			GClass84.smethod_942(player_0);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00076E68 File Offset: 0x00075068
		internal static Texture2D smethod_1436(string string_4)
		{
			Texture2D result;
			try
			{
				Texture2D texture2D = GClass84.smethod_845(string_4);
				GClass84.smethod_48<Texture2D>(ref texture2D);
				result = texture2D;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00076EA0 File Offset: 0x000750A0
		internal static Transform smethod_1437()
		{
			GameObject gameObject = GClass84.smethod_1086();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00076EC0 File Offset: 0x000750C0
		internal static Transform smethod_1438()
		{
			GameObject gameObject = GClass84.smethod_1484();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00076EE0 File Offset: 0x000750E0
		internal static void smethod_1439(bool bool_10)
		{
			GClass84.smethod_987(bool_10);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00076EF4 File Offset: 0x000750F4
		internal static string smethod_1440(string string_4)
		{
			return GClass84.smethod_238(string_4);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00076F08 File Offset: 0x00075108
		internal static List<Transform> smethod_1441(GameObject gameObject_39, string string_4)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_1534(gameObject_39.transform, string_4);
			}
			return result;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00076F38 File Offset: 0x00075138
		internal static string smethod_1442(string string_4)
		{
			string empty;
			if (string.IsNullOrEmpty(string_4))
			{
				empty = string.Empty;
			}
			else
			{
				int i = 0;
				int num = GClass84.smethod_593(string_4);
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				while (i < num)
				{
					if (string_4[i] == '{')
					{
						if (num2 == 0)
						{
							num4 = i;
						}
						num2++;
					}
					else if (string_4[i] == '}')
					{
						num3++;
					}
					if (num3 > num2)
					{
						if (num2 != 0)
						{
							return string.Empty;
						}
						num3 = 0;
					}
					else
					{
						if (num2 > 0 && num3 == num2)
						{
							return GClass84.smethod_1204(string_4, num4, i - num4 + 1);
						}
						i++;
					}
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00076FE4 File Offset: 0x000751E4
		internal static GamelikeInputController smethod_1443()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.GetComponent<GamelikeInputController>() : null;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00077004 File Offset: 0x00075204
		internal static void smethod_1444(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_1595(vrcplayer_0);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00077018 File Offset: 0x00075218
		internal static bool smethod_1445(string string_4, Type type_0, string string_5, Type[] type_1, Type[] type_2, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			GClass84.Class110 @class = new GClass84.Class110();
			@class.string_0 = string_5;
			bool flag = false;
			List<MethodInfo> list = type_0.GetMethods().ToList<MethodInfo>();
			Predicate<MethodInfo> match;
			if ((match = @class.predicate_0) == null)
			{
				match = (@class.predicate_0 = new Predicate<MethodInfo>(@class.method_0));
			}
			foreach (MethodInfo methodInfo in list.FindAll(match))
			{
				if (GClass84.smethod_1123(string_4, methodInfo, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2))
				{
					flag = true;
				}
				else
				{
					string text = "Null";
					string text2 = @class.string_0;
					string text3 = "Null";
					string text4 = "Null";
					string text5 = "Null";
					string text6 = "Null";
					string text7 = "Null";
					if (type_0 != null)
					{
						text = type_0.Name;
					}
					if (type_1 != null)
					{
						text3 = string.Empty;
						foreach (Type type in type_1)
						{
							text3 = text3 + ", " + type.Name;
						}
						if (text3 != string.Empty)
						{
							text3 = "(" + GClass84.smethod_1204(text3, 2, -1) + ")";
						}
					}
					if (type_2 != null)
					{
						text4 = string.Empty;
						foreach (Type type2 in type_2)
						{
							text4 = text4 + ", " + type2.Name;
						}
						if (text4 != string.Empty)
						{
							text4 = "(" + GClass84.smethod_1204(text4, 2, -1) + ")";
						}
					}
					if (harmonyMethod_0 != null)
					{
						text5 = harmonyMethod_0.methodName;
					}
					if (harmonyMethod_1 != null)
					{
						text6 = harmonyMethod_1.methodName;
					}
					if (harmonyMethod_2 != null)
					{
						text7 = harmonyMethod_2.methodName;
					}
					GClass70.smethod_109(string.Concat(new string[]
					{
						"Can",
						"'",
						"t",
						" ",
						"Patch",
						" ",
						"Method",
						" \"",
						methodInfo.Name,
						"\"",
						" (",
						string_4,
						", ",
						text,
						", ",
						text2,
						", ",
						text3,
						", ",
						text4,
						", ",
						text5,
						", ",
						text6,
						", ",
						text7,
						")"
					}), GClass70.Enum1.const_0);
				}
			}
			if (!flag)
			{
				string text8 = "Null";
				string text9 = @class.string_0;
				string text10 = "Null";
				string text11 = "Null";
				string text12 = "Null";
				string text13 = "Null";
				string text14 = "Null";
				if (type_0 != null)
				{
					text8 = type_0.Name;
				}
				if (type_1 != null)
				{
					text10 = string.Empty;
					foreach (Type type3 in type_1)
					{
						text10 = text10 + ", " + type3.Name;
					}
					if (text10 != string.Empty)
					{
						text10 = "(" + GClass84.smethod_1204(text10, 2, -1) + ")";
					}
				}
				if (type_2 != null)
				{
					text11 = string.Empty;
					foreach (Type type4 in type_2)
					{
						text11 = text11 + ", " + type4.Name;
					}
					if (text11 != string.Empty)
					{
						text11 = "(" + GClass84.smethod_1204(text11, 2, -1) + ")";
					}
				}
				if (harmonyMethod_0 != null)
				{
					text12 = harmonyMethod_0.methodName;
				}
				if (harmonyMethod_1 != null)
				{
					text13 = harmonyMethod_1.methodName;
				}
				if (harmonyMethod_2 != null)
				{
					text14 = harmonyMethod_2.methodName;
				}
				GClass70.smethod_109(string.Concat(new string[]
				{
					"Can",
					"'",
					"t",
					" ",
					"Patch",
					" ",
					"Methods",
					" ",
					"Start",
					" ",
					"With",
					" (",
					string_4,
					", ",
					text8,
					", ",
					text9,
					", ",
					text10,
					", ",
					text11,
					", ",
					text12,
					", ",
					text13,
					", ",
					text14,
					")"
				}), GClass70.Enum1.const_0);
			}
			return flag;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00077530 File Offset: 0x00075730
		internal static int smethod_1446()
		{
			return GClass84.list_46.Count;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0007754C File Offset: 0x0007574C
		internal static bool smethod_1447(Type type_0, string string_4, HarmonyMethod harmonyMethod_0 = null, HarmonyMethod harmonyMethod_1 = null, HarmonyMethod harmonyMethod_2 = null)
		{
			return GClass84.smethod_847("Abyss Client_1.0.0", type_0, string_4, harmonyMethod_0, harmonyMethod_1, harmonyMethod_2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0007756C File Offset: 0x0007576C
		internal static List<GameObject> smethod_1448(Transform transform_0)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					transform_0.gameObject
				};
				list.AddRange(GClass84.smethod_471(transform_0));
				result = list;
			}
			return result;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000775B0 File Offset: 0x000757B0
		internal static GameObject[] smethod_1449(Transform transform_0)
		{
			GameObject[] result;
			if (!transform_0)
			{
				result = new GameObject[0];
			}
			else
			{
				GameObject[] array = new GameObject[transform_0.childCount];
				for (int i = 0; i < transform_0.childCount; i++)
				{
					array[i] = transform_0.GetChild(i).gameObject;
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00077604 File Offset: 0x00075804
		internal static string smethod_1450(ConsoleColor consoleColor_0)
		{
			return GClass84.smethod_912(consoleColor_0);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00077618 File Offset: 0x00075818
		internal static int smethod_1451(bool bool_10 = false)
		{
			DateTime now = DateTime.Now;
			int result;
			if (bool_10)
			{
				result = now.DayOfYear * 86400 + now.Hour * 3600 + now.Minute * 60 + now.Second;
			}
			else
			{
				result = now.Hour * 3600 + now.Minute * 60 + now.Second;
			}
			return result;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00077684 File Offset: 0x00075884
		internal static string smethod_1452(string string_4, int int_1, int int_2)
		{
			string result;
			if (int_1 >= GClass84.smethod_593(string_4) || int_2 == 0)
			{
				result = string.Empty;
			}
			else
			{
				if (int_2 > GClass84.smethod_593(string_4) - int_1)
				{
					int_2 = GClass84.smethod_593(string_4) - int_1;
				}
				if (int_2 > 0)
				{
					result = string_4.Substring(int_1, int_2);
				}
				else
				{
					result = string_4.Substring(int_1);
				}
			}
			return result;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000776DC File Offset: 0x000758DC
		internal static string smethod_1453(Transform transform_0)
		{
			return GClass84.smethod_215(transform_0);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000776F0 File Offset: 0x000758F0
		internal static Transform smethod_1454(List<string> list_51)
		{
			Transform result;
			if (list_51 == null)
			{
				result = null;
			}
			else
			{
				while (list_51.Count > 0 && string.IsNullOrEmpty(list_51[0]))
				{
					list_51.RemoveAt(0);
				}
				if (list_51.Count < 1)
				{
					result = null;
				}
				else
				{
					List<Scene> list = GClass84.smethod_311(true);
					for (int i = 0; i < list.Count; i++)
					{
						List<GameObject> list2 = GClass84.smethod_579(list[i]);
						for (int j = 0; j < list2.Count; j++)
						{
							if (list2[j].name == list_51[0])
							{
								list_51.RemoveAt(0);
								return GClass84.smethod_836(list2[j].transform, list_51);
							}
						}
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000777C4 File Offset: 0x000759C4
		internal static Shader smethod_1455()
		{
			if (!GClass84.shader_0)
			{
				GClass84.shader_0 = Shader.Find("Standard");
			}
			return GClass84.shader_0;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x000777F8 File Offset: 0x000759F8
		internal static IPAddress smethod_1456(Player player_0)
		{
			try
			{
				GStruct9 gstruct;
				if (GClass18.smethod_4(new GStruct22(GClass84.smethod_534(GClass84.smethod_367(player_0))), out gstruct) && gstruct.uint_0 != 0U && GClass84.smethod_1192(gstruct.uint_0.smethod_463().ToString()) && gstruct.uint_0.smethod_463() != null)
				{
					return gstruct.uint_0.smethod_463();
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Couldn't get ",
					GClass84.smethod_643(player_0, ""),
					"'s IP. Details",
					": ",
					ex.ToString()
				}), GClass70.Enum1.const_0);
				return null;
			}
			return null;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000778BC File Offset: 0x00075ABC
		internal static bool smethod_1457(List<GameObject> list_51, VRCPlayer vrcplayer_0, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null || !vrcplayer_0 || vrcplayer_0.transform)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_77(list_51[i], vrcplayer_0, genum47_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00077918 File Offset: 0x00075B18
		internal static bool smethod_1458(GameObject gameObject_39, string string_4)
		{
			return gameObject_39 && GClass84.smethod_490(gameObject_39.transform, string_4);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00077944 File Offset: 0x00075B44
		internal static void smethod_1459()
		{
			GClass84.int_0++;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00077960 File Offset: 0x00075B60
		internal static void smethod_1460(Renderer renderer_0, bool bool_10, HighlightsFXStandalone highlightsFXStandalone_1, bool bool_11)
		{
			if (renderer_0)
			{
				if (GClass84.bool_9 || bool_11)
				{
					HighlightsFX.Method_Public_Static_Void_Renderer_Boolean_PDM_0(renderer_0, bool_10);
				}
				else if (highlightsFXStandalone_1 != null)
				{
					highlightsFXStandalone_1.Method_Public_Void_Renderer_Boolean_0(renderer_0, bool_10);
				}
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0007799C File Offset: 0x00075B9C
		internal static string smethod_1461(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_569(vrcplayer_0);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000779B0 File Offset: 0x00075BB0
		private static string smethod_1462(int int_1)
		{
			return string.Concat(new int[]
			{
				0,
				0,
				0,
				int_1
			}.Select(new Func<int, string>(GClass84.Class101.class101_0.method_26)));
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000779F4 File Offset: 0x00075BF4
		internal static string smethod_1463(UdonBehaviour udonBehaviour_0, int int_1)
		{
			return GClass84.smethod_1101(udonBehaviour_0, int_1);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00077A08 File Offset: 0x00075C08
		internal static void smethod_1464(Button button_0, Action action_0)
		{
			GClass84.smethod_686(button_0, action_0);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00077A1C File Offset: 0x00075C1C
		internal static Color smethod_1465(Color color_0)
		{
			Color result;
			if (GClass84.smethod_15(color_0))
			{
				result = color_0;
			}
			else
			{
				float num = GClass84.smethod_415((color_0.r + color_0.g + color_0.b) / 3f, 0f, 1f);
				color_0.r = num;
				color_0.g = num;
				color_0.b = num;
				result = color_0;
			}
			return result;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00077A7C File Offset: 0x00075C7C
		internal static Transform smethod_1466()
		{
			return GClass84.smethod_134(GClass84.smethod_460());
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00077A98 File Offset: 0x00075C98
		internal static PageWorldInfo smethod_1467()
		{
			GameObject gameObject = GClass84.smethod_1649();
			return (gameObject != null) ? gameObject.GetComponentInChildren<PageWorldInfo>() : null;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00077AB8 File Offset: 0x00075CB8
		internal static ApiAvatar smethod_1468(VRCPlayer vrcplayer_0)
		{
			ApiAvatar result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1713(GClass84.smethod_1416(vrcplayer_0));
			}
			return result;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00077AE4 File Offset: 0x00075CE4
		internal static string smethod_1469()
		{
			return GClass84.smethod_485();
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00077AF8 File Offset: 0x00075CF8
		internal static Vector3 smethod_1470(Vector2 vector2_0)
		{
			return new Vector3(0f, vector2_0.x, vector2_0.y);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00077B20 File Offset: 0x00075D20
		internal static void smethod_1471(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_913(vrcplayer_0);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00077B34 File Offset: 0x00075D34
		internal static PlayerManager smethod_1472()
		{
			return PlayerManager.field_Private_Static_PlayerManager_0;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_1473(VRC_SpatialAudioSource vrc_SpatialAudioSource_0)
		{
			if (vrc_SpatialAudioSource_0)
			{
				Object.DestroyImmediate(vrc_SpatialAudioSource_0, true);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00077B48 File Offset: 0x00075D48
		internal static string smethod_1474(APIUser apiuser_0)
		{
			return GClass84.smethod_1382(apiuser_0);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00077B5C File Offset: 0x00075D5C
		internal static string smethod_1475()
		{
			return GClass84.smethod_941();
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00077B70 File Offset: 0x00075D70
		internal static GameObject smethod_1476()
		{
			return GClass84.smethod_692(GClass84.smethod_460());
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00077B8C File Offset: 0x00075D8C
		internal static void smethod_1477(List<GameObject> list_51, GameObject gameObject_39)
		{
			GClass84.smethod_241(list_51, gameObject_39);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00077BA0 File Offset: 0x00075DA0
		internal static void smethod_1478(CursorLockMode cursorLockMode_0)
		{
			GClass84.smethod_1675(cursorLockMode_0);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00077BB4 File Offset: 0x00075DB4
		internal static Vector3 smethod_1479(Vector3 vector3_0)
		{
			return Vector3.Normalize(vector3_0);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00077BCC File Offset: 0x00075DCC
		internal static float smethod_1480(float float_3)
		{
			return (float)((double)float_3 * 3.1415926535897931 / 180.0);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00077BF4 File Offset: 0x00075DF4
		internal static void smethod_1481(string string_4, bool bool_10)
		{
			GClass84.smethod_222(string_4, bool_10);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00077C08 File Offset: 0x00075E08
		internal static string smethod_1482(string string_4, int int_1)
		{
			return GClass84.smethod_340(string_4, int_1);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00077C1C File Offset: 0x00075E1C
		internal static IEnumerator smethod_1483(Transform transform_0, Player player_0)
		{
			GClass84.Class105 @class = new GClass84.Class105(0);
			@class.transform_0 = transform_0;
			@class.player_0 = player_0;
			return @class;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00077C40 File Offset: 0x00075E40
		internal static GameObject smethod_1484()
		{
			if (!GClass84.gameObject_15)
			{
				GClass84.gameObject_15 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingBackground_TealGradient/_FX_ParticleBubbles");
			}
			return GClass84.gameObject_15;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00077C74 File Offset: 0x00075E74
		internal static void smethod_1485(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_178(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00077C94 File Offset: 0x00075E94
		internal static Transform smethod_1486()
		{
			GameObject gameObject = GClass84.smethod_253();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00077CB4 File Offset: 0x00075EB4
		internal static LocomotionInputController smethod_1487()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			return (vrcplayer != null) ? vrcplayer.GetComponentInChildren<LocomotionInputController>() : null;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00077CD4 File Offset: 0x00075ED4
		internal static void smethod_1488(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_246(vrcplayer_0);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00077CE8 File Offset: 0x00075EE8
		internal static GameObject smethod_1489()
		{
			if (!GClass84.gameObject_28)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_28 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_28;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00077D48 File Offset: 0x00075F48
		internal static VRCUiPopupManager smethod_1490()
		{
			return VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0();
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00077D5C File Offset: 0x00075F5C
		internal static string smethod_1491(int int_1)
		{
			return GClass84.smethod_531(int_1);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00077D70 File Offset: 0x00075F70
		internal static string smethod_1492(VRCPlayerApi vrcplayerApi_0)
		{
			string result;
			if (vrcplayerApi_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_653(GClass84.smethod_958(vrcplayerApi_0));
			}
			return result;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00077D98 File Offset: 0x00075F98
		internal static bool smethod_1493(Transform transform_0, Transform transform_1)
		{
			return transform_0 && transform_1 && transform_0.parent && (transform_0.parent == transform_1 || GClass84.smethod_1493(transform_0.parent, transform_1));
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00077DF0 File Offset: 0x00075FF0
		internal static float smethod_1494(float float_3)
		{
			float result;
			if (float_3 < 0f)
			{
				result = float_3 * -1f;
			}
			else
			{
				result = float_3;
			}
			return result;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00077E14 File Offset: 0x00076014
		internal static List<Transform> smethod_1495(Transform transform_0)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else
			{
				List<Transform> list = new List<Transform>();
				for (int i = 0; i < transform_0.childCount; i++)
				{
					Transform child = transform_0.GetChild(i);
					list.Add(child);
					list.AddRange(GClass84.smethod_1495(child));
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00077E70 File Offset: 0x00076070
		internal static List<string> smethod_1496(UdonBehaviour udonBehaviour_0)
		{
			List<string> list = new List<string>();
			if (udonBehaviour_0)
			{
				for (int i = 0; i < udonBehaviour_0._symbolNameCache.Count; i++)
				{
					list.Add(GClass84.smethod_1191(udonBehaviour_0, i));
				}
			}
			return list;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00077EB8 File Offset: 0x000760B8
		internal static T smethod_1497<T>(int int_1)
		{
			return GClass84.smethod_1563<T>(GClass84.smethod_1013<T>(int_1));
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00077ED4 File Offset: 0x000760D4
		internal static void smethod_1498(Text text_1)
		{
			GClass84.smethod_989(text_1);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00077EE8 File Offset: 0x000760E8
		internal static void smethod_1499()
		{
			for (int i = GClass84.list_49.Count - 1; i >= 0; i--)
			{
				MelonCoroutines.Stop(GClass84.list_49[i]);
			}
			GClass84.list_49.Clear();
			GClass84.smethod_1002();
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00077F34 File Offset: 0x00076134
		internal static GameObject smethod_1500()
		{
			if (!GClass84.gameObject_17)
			{
				GClass84.gameObject_17 = GameObject.Find("/UserInterface/LoadingBackground_TealGradient_Music/LoadingSound");
			}
			return GClass84.gameObject_17;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00077F68 File Offset: 0x00076168
		internal static bool smethod_1501(Vector3 vector3_0)
		{
			return !GClass84.smethod_555(vector3_0) && !GClass84.smethod_580(vector3_0);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		internal static Transform smethod_1502(Player player_0)
		{
			Transform result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1280(player_0.transform);
			}
			return result;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00077F94 File Offset: 0x00076194
		internal static GameObject smethod_1503()
		{
			if (!GClass84.gameObject_33)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Button/Icon", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_33 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_33;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00077FF4 File Offset: 0x000761F4
		internal static void smethod_1504(float float_3)
		{
			GClass84.smethod_433(float_3);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00078008 File Offset: 0x00076208
		internal static Color32 smethod_1505(Color32 color32_0)
		{
			Color32 result;
			if (GClass84.smethod_1640(color32_0))
			{
				result = color32_0;
			}
			else
			{
				byte b = (byte)GClass84.smethod_1551((int)((color32_0.r + color32_0.g + color32_0.b) / 3), 0, 255);
				color32_0.r = b;
				color32_0.g = b;
				color32_0.b = b;
				result = color32_0;
			}
			return result;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00078060 File Offset: 0x00076260
		internal static List<GameObject> smethod_1506(GameObject gameObject_39)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_1576(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00078090 File Offset: 0x00076290
		internal static bool smethod_1507(this Player player_0)
		{
			return player_0.smethod_1200() == 0f;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000780AC File Offset: 0x000762AC
		internal static void smethod_1508(VRC_EventHandler.VrcEventType vrcEventType_0, VRC_EventHandler.VrcTargetType vrcTargetType_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, string string_4, object[] object_0, float float_3)
		{
			GClass84.smethod_1736(vrcEventType_0, vrcTargetType_0, vrcBroadcastType_0, gameObject_39, string_4, object_0, float_3);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000780D0 File Offset: 0x000762D0
		internal static bool smethod_1509(VRC_Trigger vrc_Trigger_0, string string_4, VRCPlayerApi vrcplayerApi_0)
		{
			bool result;
			if (!vrc_Trigger_0)
			{
				result = false;
			}
			else if (vrcplayerApi_0 == null)
			{
				GClass70.smethod_38("Target is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				List<VRC_Trigger.TriggerEvent> list = new List<VRC_Trigger.TriggerEvent>();
				List<VRC_EventHandler.VrcBroadcastType> list2 = new List<VRC_EventHandler.VrcBroadcastType>();
				VRC_Trigger.TriggerType triggerType = GClass84.smethod_1737(string_4);
				if (triggerType == 0)
				{
					List<VRC_Trigger.TriggerEvent> list4;
					List<string> list3 = GClass84.smethod_609(vrc_Trigger_0, out list4, false);
					int num = GClass84.smethod_741(list3.Count, list4.Count);
					for (int i = 0; i < num; i++)
					{
						if (list3[i] == string_4)
						{
							list.Add(list4[i]);
							list2.Add(list4[i].BroadcastType);
							list4[i].BroadcastType = 3;
						}
					}
				}
				else
				{
					List<VRC_Trigger.TriggerEvent> list6;
					List<VRC_Trigger.TriggerType> list5 = GClass84.smethod_101(vrc_Trigger_0, out list6, false);
					int num2 = GClass84.smethod_741(list5.Count, list6.Count);
					for (int j = 0; j < num2; j++)
					{
						if (list5[j] == triggerType)
						{
							list.Add(list6[j]);
							list2.Add(list6[j].BroadcastType);
							list6[j].BroadcastType = 3;
						}
					}
				}
				int num3 = GClass84.smethod_741(list.Count, list2.Count);
				if (num3 > 0)
				{
					bool flag = false;
					try
					{
						GClass84.smethod_191(vrcplayerApi_0, vrc_Trigger_0.gameObject);
						flag = GClass84.smethod_489(vrc_Trigger_0, string_4);
					}
					catch
					{
					}
					for (int k = 0; k < num3; k++)
					{
						list[k].BroadcastType = list2[k];
					}
					result = flag;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00078288 File Offset: 0x00076488
		internal static GameObject smethod_1510(string string_4, Vector3 vector3_0, Quaternion quaternion_0, string string_5 = "1337", int int_1 = 1)
		{
			GameObject gameObject = Networking.Instantiate(0, "Portals/PortalInternalDynamic", vector3_0, quaternion_0);
			RPC.Destination destination = 7;
			GameObject gameObject2 = gameObject;
			string text = "ConfigurePortal";
			Object[] array = new Object[3];
			array[0] = string_4;
			array[1] = string_5;
			int num = 2;
			Int32 @int = default(Int32);
			@int.m_value = int_1;
			array[num] = @int.BoxIl2CppObject();
			Networking.RPC(destination, gameObject2, text, array);
			return gameObject;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000782EC File Offset: 0x000764EC
		internal static bool smethod_1511(APIUser apiuser_0)
		{
			return apiuser_0 != null && apiuser_0.isFriend;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0007830C File Offset: 0x0007650C
		internal static Texture2D smethod_1512(int int_1, int int_2, int int_3, Color32 color32_0, Color32 color32_1)
		{
			int num = int_1 * int_2;
			Texture2D texture2D = GClass84.smethod_1130(int_1, int_2);
			Color32[] array = new Color32[num];
			int num2 = int_1 * int_3;
			int num3 = num - int_1 * int_3;
			int num4 = int_1 - int_3;
			for (int i = 0; i < array.Length; i++)
			{
				if (i < num2 || i > num3)
				{
					array[i] = color32_0;
				}
				else
				{
					int num5 = i % int_1;
					if (num5 < int_3 || num5 >= num4)
					{
						array[i] = color32_0;
					}
					else
					{
						array[i] = color32_1;
					}
				}
			}
			texture2D.SetPixels32(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000783B4 File Offset: 0x000765B4
		internal static Player smethod_1513(Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Public_get_Player_0() : null;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000783D0 File Offset: 0x000765D0
		internal static Texture2D smethod_1514(Texture2D texture2D_0, float float_3)
		{
			Color[] array = texture2D_0.GetPixels();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_808(array[i], float_3);
			}
			texture2D_0.SetPixels(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00078428 File Offset: 0x00076628
		internal static Type[] smethod_1515(Assembly assembly_0)
		{
			return assembly_0.GetTypes();
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00078440 File Offset: 0x00076640
		internal static Texture2D smethod_1516(Texture2D texture2D_0, int int_1, int int_2)
		{
			RenderTexture renderTexture = new RenderTexture(int_1, int_2, 24);
			RenderTexture.active = renderTexture;
			Graphics.Blit(texture2D_0, renderTexture);
			Texture2D texture2D = new Texture2D(int_1, int_2);
			texture2D.ReadPixels(new Rect(0f, 0f, (float)int_1, (float)int_2), 0, 0);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00078490 File Offset: 0x00076690
		internal static void smethod_1517(float float_3)
		{
			GClass84.smethod_492(float_3);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000784A4 File Offset: 0x000766A4
		internal static Transform smethod_1518()
		{
			GameObject gameObject = GClass84.smethod_807();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000784C4 File Offset: 0x000766C4
		internal static Transform[] smethod_1519(Transform transform_0)
		{
			Transform[] result;
			if (!transform_0)
			{
				result = new Transform[0];
			}
			else
			{
				List<Transform> list = new List<Transform>
				{
					transform_0
				};
				list.AddRange(GClass84.smethod_1495(transform_0));
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00078508 File Offset: 0x00076708
		internal static string smethod_1520(APIUser apiuser_0)
		{
			return GClass84.smethod_1474(apiuser_0);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0007851C File Offset: 0x0007671C
		internal static string smethod_1521(string string_4, char[] char_1 = null)
		{
			return GClass84.smethod_562(string_4, char_1);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00078530 File Offset: 0x00076730
		internal static void smethod_1522(Mesh mesh_0)
		{
			GClass84.smethod_1345(mesh_0);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00078544 File Offset: 0x00076744
		internal static string smethod_1523(string string_4, int int_1)
		{
			return GClass84.smethod_1006(string_4, int_1);
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00078558 File Offset: 0x00076758
		internal static void smethod_1524(float float_3, Action action_0)
		{
			MelonCoroutines.Start(GClass84.smethod_291(float_3, action_0));
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00078574 File Offset: 0x00076774
		internal static VRCPlayerApi smethod_1525(PlayerNet playerNet_0)
		{
			VRCPlayerApi result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_1557(GClass84.smethod_800(playerNet_0));
			}
			return result;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000785A0 File Offset: 0x000767A0
		internal static bool smethod_1526(Vector3 vector3_0, Transform transform_0, GameObject gameObject_39 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				Ray ray;
				ray..ctor(vector3_0, transform_0.position - vector3_0);
				Il2CppStructArray<RaycastHit> il2CppStructArray = Physics.RaycastAll(ray, ray.direction.magnitude);
				if (il2CppStructArray.Length > 0)
				{
					foreach (RaycastHit raycastHit in il2CppStructArray)
					{
						if (!(raycastHit.collider.transform == transform_0) && (!gameObject_39 || !(raycastHit.collider.gameObject == gameObject_39)))
						{
							return false;
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00078668 File Offset: 0x00076868
		internal static Vector3 smethod_1527()
		{
			VRCPlayer vrcplayer = GClass84.smethod_460();
			Vector3 result;
			if (vrcplayer)
			{
				result = vrcplayer.transform.position;
			}
			else
			{
				result = default(Vector3);
			}
			return result;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0007869C File Offset: 0x0007689C
		internal static string smethod_1528(string string_4)
		{
			return GClass84.smethod_1163(string_4);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000786B0 File Offset: 0x000768B0
		internal static string smethod_1529()
		{
			return "UserInterface/MenuContent/Screens/Settings_Safety";
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000786C4 File Offset: 0x000768C4
		internal static void smethod_1530()
		{
			GClass84.smethod_789();
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000786D8 File Offset: 0x000768D8
		internal static void smethod_1531<T>() where T : class
		{
			ClassInjector.RegisterTypeInIl2Cpp<T>();
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000786EC File Offset: 0x000768EC
		internal static string smethod_1532(string string_4, string string_5)
		{
			return GClass84.smethod_1631(string_4, string_5);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00078700 File Offset: 0x00076900
		internal static void smethod_1533(string string_4, string string_5)
		{
			GClass84.smethod_533(string_4, string_5);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00078714 File Offset: 0x00076914
		internal static List<Transform> smethod_1534(Transform transform_0, string string_4)
		{
			List<Transform> list = new List<Transform>();
			for (int i = 0; i < transform_0.childCount; i++)
			{
				Transform child = transform_0.GetChild(i);
				if (child.tag == string_4)
				{
					list.Add(child);
				}
				else
				{
					list.AddRange(GClass84.smethod_1534(child, string_4));
				}
			}
			return list;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0007876C File Offset: 0x0007696C
		internal static void smethod_1535(UiVRCList uiVRCList_0)
		{
			GClass84.smethod_1337(uiVRCList_0);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00078780 File Offset: 0x00076980
		internal static string smethod_1536(Player player_0, string string_4)
		{
			return GClass84.smethod_1586(player_0, string_4);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00078794 File Offset: 0x00076994
		internal static IEnumerator smethod_1537()
		{
			return new GClass84.Class119(0);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000787A8 File Offset: 0x000769A8
		internal static void smethod_1538(MethodInfo methodInfo_5)
		{
			if (!(methodInfo_5 == null))
			{
				GClass70.smethod_24(((methodInfo_5.ReturnType != null) ? methodInfo_5.ReturnType.Name : "void") + " " + methodInfo_5.Name, GClass70.Enum1.const_0);
				GClass70.smethod_24("{", GClass70.Enum1.const_0);
				try
				{
					foreach (XrefInstance xrefInstance in XrefScanner.XrefScan(methodInfo_5))
					{
						if (xrefInstance.Type == 0)
						{
							try
							{
								Object @object = xrefInstance.ReadAsObject();
								if (@object != null)
								{
									GClass70.smethod_24(@object.ToString() + " (" + xrefInstance.Type.ToString() + ")", GClass70.Enum1.const_0);
								}
							}
							catch
							{
							}
						}
						if (xrefInstance.Type == 1)
						{
							try
							{
								MethodBase methodBase = xrefInstance.TryResolve();
								if (methodBase != null)
								{
									string[] array = new string[7];
									array[0] = "(";
									int num = 1;
									Type declaringType = methodBase.DeclaringType;
									array[num] = ((declaringType != null) ? declaringType.ToString() : null);
									array[2] = ")";
									array[3] = methodBase.Name;
									array[4] = " (";
									array[5] = xrefInstance.Type.ToString();
									array[6] = ")";
									GClass70.smethod_24(string.Concat(array), GClass70.Enum1.const_0);
								}
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
				GClass70.smethod_24("}", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00078980 File Offset: 0x00076B80
		internal static void smethod_1539()
		{
			GClass84.smethod_918();
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00078994 File Offset: 0x00076B94
		internal static void smethod_1540(string string_4, Vector3 vector3_0)
		{
			Networking.Instantiate(0, string_4, vector3_0, new Quaternion(0f, 0f, 0f, 0.7f));
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x000789C4 File Offset: 0x00076BC4
		internal static void smethod_1541(Material material_1)
		{
			GClass84.smethod_1234(material_1);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00004908 File Offset: 0x00002B08
		internal static void smethod_1542()
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000789D8 File Offset: 0x00076BD8
		internal static void smethod_1543(bool bool_10)
		{
			GClass84.smethod_371(bool_10);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x000789EC File Offset: 0x00076BEC
		internal static char smethod_1544(int int_1)
		{
			return (char)int_1;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_1545(SkinnedMeshRenderer skinnedMeshRenderer_0)
		{
			if (skinnedMeshRenderer_0)
			{
				Object.DestroyImmediate(skinnedMeshRenderer_0, true);
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00078A00 File Offset: 0x00076C00
		internal static Color smethod_1546(VRCPlayer vrcplayer_0)
		{
			return GClass84.smethod_1041(GClass84.smethod_307(GClass84.smethod_856(vrcplayer_0)));
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0006496C File Offset: 0x00062B6C
		internal static Player smethod_1547(string string_4)
		{
			Player[] array = GClass84.smethod_870();
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (GClass84.smethod_684(array[i]) == string_4)
				{
					return array[i];
				}
			}
			return null;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00078A20 File Offset: 0x00076C20
		internal static InstanceAccessType smethod_1548(string string_4)
		{
			InstanceAccessType result;
			if (string_4.IndexOf("hidden", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				result = 1;
			}
			else if (string_4.IndexOf("friends", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				result = 2;
			}
			else if (string_4.IndexOf("request", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				result = 4;
			}
			else if (string_4.IndexOf("private", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				result = 3;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00078A90 File Offset: 0x00076C90
		internal static List<VRCPlayer> smethod_1549()
		{
			List<VRCPlayer> list = new List<VRCPlayer>();
			Player[] array = GClass84.smethod_870();
			for (int i = 0; i < array.Length; i++)
			{
				VRCPlayer vrcplayer = GClass84.smethod_367(array[i]);
				if (vrcplayer)
				{
					list.Add(vrcplayer);
				}
			}
			return list;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00078AD8 File Offset: 0x00076CD8
		internal static Color smethod_1550(Color color_0)
		{
			return Color.FromArgb((int)(color_0.a * 255f), (int)(color_0.r * 255f), (int)(color_0.g * 255f), (int)(color_0.b * 255f));
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00078B20 File Offset: 0x00076D20
		internal static int smethod_1551(int int_1, int int_2, int int_3)
		{
			int result;
			if (int_1 < int_2)
			{
				result = int_2;
			}
			else if (int_1 > int_3)
			{
				result = int_3;
			}
			else
			{
				result = int_1;
			}
			return result;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00078B44 File Offset: 0x00076D44
		internal static void smethod_1552(float float_3, float float_4, float float_5)
		{
			GClass84.smethod_1406(float_3, float_4, float_5);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00078B5C File Offset: 0x00076D5C
		internal static void smethod_1553()
		{
			GClass84.smethod_1187();
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00078B70 File Offset: 0x00076D70
		internal static GameObject[] smethod_1554(Transform transform_0)
		{
			GameObject[] result;
			if (!transform_0)
			{
				result = new GameObject[0];
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					transform_0.gameObject
				};
				list.AddRange(GClass84.smethod_471(transform_0));
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00078BB8 File Offset: 0x00076DB8
		internal static void smethod_1555(bool bool_10)
		{
			Transform transform = GClass84.smethod_981();
			if (transform)
			{
				Collider component = transform.GetComponent<Collider>();
				if (component)
				{
					foreach (Collider collider in Object.FindObjectsOfType<Collider>())
					{
						Physics.IgnoreCollision(component, collider, bool_10);
					}
				}
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00078C30 File Offset: 0x00076E30
		internal static List<DynamicBone> smethod_1556(Transform transform_0)
		{
			List<DynamicBone> result;
			if (!transform_0)
			{
				result = new List<DynamicBone>();
			}
			else
			{
				List<DynamicBone> list = transform_0.GetComponents<DynamicBone>().ToList<DynamicBone>();
				list.AddRange(transform_0.GetComponentsInChildren<DynamicBone>(true));
				result = list.Distinct<DynamicBone>().ToList<DynamicBone>();
			}
			return result;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00078C78 File Offset: 0x00076E78
		internal static VRCPlayerApi smethod_1557(VRCPlayer vrcplayer_0)
		{
			return (vrcplayer_0 != null) ? vrcplayer_0.Method_Public_get_VRCPlayerApi_0() : null;
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00078C94 File Offset: 0x00076E94
		internal static string smethod_1558(VRCPlayerApi vrcplayerApi_0, string string_4)
		{
			return GClass84.smethod_1593(vrcplayerApi_0, string_4);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00078CA8 File Offset: 0x00076EA8
		internal static GameObject[] smethod_1559(List<Scene> list_51)
		{
			GameObject[] result;
			if (list_51 == null)
			{
				result = new GameObject[0];
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				for (int i = 0; i < list_51.Count; i++)
				{
					list.AddRange(GClass84.smethod_1297(list_51[i]));
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_1560(Animator animator_0)
		{
			if (animator_0)
			{
				Object.DestroyImmediate(animator_0, true);
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00078CF8 File Offset: 0x00076EF8
		internal static short smethod_1561(VRCPlayerApi vrcplayerApi_0)
		{
			short result;
			if (vrcplayerApi_0 == null)
			{
				result = 0;
			}
			else
			{
				result = GClass84.smethod_506(GClass84.smethod_840(vrcplayerApi_0));
			}
			return result;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00078D1C File Offset: 0x00076F1C
		internal static string smethod_1562(APIUser apiuser_0)
		{
			string result;
			if (apiuser_0 == null)
			{
				result = string.Empty;
			}
			else
			{
				result = apiuser_0.id;
			}
			return result;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00078D40 File Offset: 0x00076F40
		internal static T smethod_1563<T>(string string_4)
		{
			return (T)((object)Enum.Parse(typeof(T), string_4, true));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00078D68 File Offset: 0x00076F68
		internal static List<Type> smethod_1564(Assembly[] assembly_0, string string_4)
		{
			List<Type> list = new List<Type>();
			foreach (Assembly assembly_ in assembly_0)
			{
				list.AddRange(GClass84.smethod_1179(assembly_, string_4));
			}
			return list;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00078DA4 File Offset: 0x00076FA4
		internal static List<GameObject> smethod_1565(string string_4, bool bool_10)
		{
			return GClass84.smethod_1284(GClass84.smethod_1351(), string_4, bool_10);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00078DC0 File Offset: 0x00076FC0
		internal static string smethod_1566(ref string string_4, string string_5 = " ")
		{
			return GClass84.smethod_1169(ref string_4, string_5);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00078DD4 File Offset: 0x00076FD4
		internal static int smethod_1567(int int_1)
		{
			int result;
			if (int_1 <= 0)
			{
				result = 0;
			}
			else if (int_1 == 1)
			{
				result = 1;
			}
			else
			{
				int num = 2;
				int num2 = 2;
				while (num >= num2 && int_1 > num)
				{
					num2 = num;
					num *= 2;
				}
				result = GClass84.smethod_1690(num, num2);
			}
			return result;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00078E20 File Offset: 0x00077020
		internal static int smethod_1568(VRCPlayerApi vrcplayerApi_0)
		{
			int result;
			if (vrcplayerApi_0 == null)
			{
				result = -1;
			}
			else
			{
				result = vrcplayerApi_0.playerId;
			}
			return result;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00078E40 File Offset: 0x00077040
		internal static List<Transform> smethod_1569(GameObject gameObject_39)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_897(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00078E70 File Offset: 0x00077070
		internal static void smethod_1570(string string_4, Color color_0)
		{
			GClass84.list_35.Add(new GClass84.GStruct174(string_4, color_0, 3f));
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00078E94 File Offset: 0x00077094
		internal static ConsoleColor smethod_1571(APIUser apiuser_0, bool bool_10 = false)
		{
			ConsoleColor result;
			if (apiuser_0 == null)
			{
				result = ConsoleColor.DarkRed;
			}
			else
			{
				switch (GClass84.smethod_1387(apiuser_0, bool_10))
				{
				case GClass84.Enum5.const_1:
					result = ConsoleColor.DarkBlue;
					break;
				case GClass84.Enum5.const_2:
					result = ConsoleColor.DarkGreen;
					break;
				case GClass84.Enum5.const_3:
					result = ConsoleColor.DarkRed;
					break;
				case GClass84.Enum5.const_4:
					result = ConsoleColor.DarkMagenta;
					break;
				case GClass84.Enum5.const_5:
					result = ConsoleColor.DarkMagenta;
					break;
				case GClass84.Enum5.const_6:
					result = ConsoleColor.DarkMagenta;
					break;
				case GClass84.Enum5.const_7:
					result = ConsoleColor.DarkYellow;
					break;
				default:
					result = ConsoleColor.DarkGray;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00078EF8 File Offset: 0x000770F8
		internal static string smethod_1572(string string_4)
		{
			return GClass84.smethod_901(string_4);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00078F0C File Offset: 0x0007710C
		internal static GameObject smethod_1573()
		{
			return GClass84.smethod_1316(GClass84.smethod_126());
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00078F28 File Offset: 0x00077128
		internal static List<Transform> smethod_1574()
		{
			List<Transform> list = new List<Transform>();
			List<Transform> list2 = GClass84.smethod_1603(true, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				if (list2[i].GetComponent<VRC_Pickup>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00078F84 File Offset: 0x00077184
		internal static void smethod_1575(VRCPlayer vrcplayer_0, GameObject gameObject_39, string string_4, params object[] object_0)
		{
			GClass84.smethod_1343(vrcplayer_0, gameObject_39, string_4, object_0);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00078F9C File Offset: 0x0007719C
		internal static List<GameObject> smethod_1576(Transform transform_0)
		{
			List<GameObject> result;
			if (!transform_0 || transform_0.parent)
			{
				result = new List<GameObject>();
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					transform_0.parent.gameObject
				};
				list.AddRange(GClass84.smethod_1576(transform_0.parent));
				result = list;
			}
			return result;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00078FF4 File Offset: 0x000771F4
		internal static GameObject smethod_1577(string string_4)
		{
			Transform transform = GClass84.smethod_1454(GClass84.smethod_659(string_4, "/"));
			return (transform != null) ? transform.gameObject : null;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00079020 File Offset: 0x00077220
		internal static GameObject smethod_1578()
		{
			if (!GClass84.gameObject_12)
			{
				GClass84.gameObject_12 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR");
			}
			return GClass84.gameObject_12;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00079054 File Offset: 0x00077254
		internal static int smethod_1579()
		{
			return GClass84.list_44.Count;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00079070 File Offset: 0x00077270
		internal static GameObject smethod_1580()
		{
			if (!GClass84.gameObject_9)
			{
				GClass84.gameObject_9 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel");
			}
			return GClass84.gameObject_9;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00060468 File Offset: 0x0005E668
		internal static Transform smethod_1581(PlayerNet playerNet_0)
		{
			Transform result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_855(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000790A4 File Offset: 0x000772A4
		internal static void smethod_1582(CursorLockMode cursorLockMode_0)
		{
			Cursor.lockState = cursorLockMode_0;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x000790B8 File Offset: 0x000772B8
		internal static void smethod_1583()
		{
			GClass84.smethod_1732();
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000790CC File Offset: 0x000772CC
		internal static List<VRCPlayerApi> smethod_1584()
		{
			return VRCPlayerApi.AllPlayers;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000790E0 File Offset: 0x000772E0
		internal static List<Transform> smethod_1585(GameObject gameObject_39)
		{
			List<Transform> result;
			if (!gameObject_39)
			{
				result = new List<Transform>();
			}
			else
			{
				result = GClass84.smethod_1135(gameObject_39.transform);
			}
			return result;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00079110 File Offset: 0x00077310
		internal static string smethod_1586(Player player_0, string string_4)
		{
			string result;
			if (!player_0)
			{
				result = string_4;
			}
			else
			{
				result = GClass84.smethod_977(player_0.Method_Public_get_VRCPlayerApi_0(), string_4);
			}
			return result;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0007913C File Offset: 0x0007733C
		internal static string smethod_1587(Player player_0)
		{
			return GClass84.smethod_993(player_0);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00079150 File Offset: 0x00077350
		internal static bool smethod_1588(out string string_4)
		{
			bool result;
			if (GClass84.list_39.Count == 0)
			{
				string_4 = string.Empty;
				result = false;
			}
			else
			{
				string_4 = GClass84.list_39[GClass84.smethod_1673(GClass84.list_39.Count)].string_0;
				result = true;
			}
			return result;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0007919C File Offset: 0x0007739C
		internal static GameObject smethod_1589()
		{
			if (!GClass84.gameObject_27)
			{
				GClass84.gameObject_27 = GameObject.Find("/UserInterface/MenuContent");
			}
			return GClass84.gameObject_27;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000791D0 File Offset: 0x000773D0
		internal static AvatarPerformanceStats smethod_1590(PlayerNet playerNet_0)
		{
			return GClass84.smethod_966(GClass84.smethod_84(playerNet_0));
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000791EC File Offset: 0x000773EC
		internal static void smethod_1591(Renderer renderer_0, bool bool_10, HighlightsFXStandalone highlightsFXStandalone_1, bool bool_11)
		{
			GClass84.smethod_1460(renderer_0, bool_10, highlightsFXStandalone_1, bool_11);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00079204 File Offset: 0x00077404
		internal static void smethod_1592(Object object_0)
		{
			if (object_0)
			{
				Object.DontDestroyOnLoad(object_0);
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00079220 File Offset: 0x00077420
		internal static string smethod_1593(VRCPlayerApi vrcplayerApi_0, string string_4)
		{
			string result;
			if (vrcplayerApi_0 == null)
			{
				result = string_4;
			}
			else
			{
				result = vrcplayerApi_0.displayName;
			}
			return result;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00079240 File Offset: 0x00077440
		internal static string smethod_1594(int int_1)
		{
			return GClass84.smethod_156(int_1);
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00079254 File Offset: 0x00077454
		internal static void smethod_1595(VRCPlayer vrcplayer_0)
		{
			if (vrcplayer_0)
			{
				GameObject gameObject = vrcplayer_0.gameObject;
				if (gameObject)
				{
					Vector3 position = gameObject.transform.position;
					Vector3 position2;
					position2..ctor(0f, 0f, 0f);
					Vector3 position3;
					position3..ctor(0f, 0f, 0f);
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Position",
						" ",
						"Of",
						" ",
						"Player",
						": ",
						"(",
						"X",
						"=",
						position.x.ToString(),
						"; ",
						"Y",
						"=",
						position.y.ToString(),
						"; ",
						"Z",
						"=",
						position.z.ToString(),
						")"
					}), GClass70.Enum1.const_0);
					GameObject[] array = GClass84.smethod_1034(gameObject);
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].name == "ForwardDirection")
						{
							GameObject[] array2 = GClass84.smethod_1034(array[i]);
							for (int j = 0; j < array2.Length; j++)
							{
								if (array2[j].name == "Avatar")
								{
									position2 = array2[j].transform.position;
									GClass70.smethod_38(string.Concat(new string[]
									{
										"Position",
										" ",
										"Of",
										" ",
										"Avatar",
										": ",
										"(",
										"X",
										"=",
										position2.x.ToString(),
										"; ",
										"Y",
										"=",
										position2.y.ToString(),
										"; ",
										"Z",
										"=",
										position2.z.ToString(),
										")"
									}), GClass70.Enum1.const_0);
									break;
								}
							}
							IL_271:
							for (int k = 0; k < array.Length; k++)
							{
								if (array[k].name == "Profile")
								{
									GameObject[] array3 = GClass84.smethod_1034(array[k]);
									for (int l = 0; l < array3.Length; l++)
									{
										if (array3[l].name == "NameTag")
										{
											position3 = array3[l].transform.position;
											GClass70.smethod_38(string.Concat(new string[]
											{
												"Position",
												" ",
												"Of",
												" ",
												"Name",
												"Tag",
												": ",
												"(",
												"X",
												"=",
												position3.x.ToString(),
												"; ",
												"Y",
												"=",
												position3.y.ToString(),
												"; ",
												"Z",
												"=",
												position3.z.ToString(),
												")"
											}), GClass70.Enum1.const_0);
											break;
										}
									}
									IL_3BF:
									Vector3 vector = position3 - position;
									GClass70.smethod_38(string.Concat(new string[]
									{
										"Difference",
										" ",
										"Between",
										" ",
										"Player",
										" ",
										"And",
										" ",
										"Name",
										"Tag",
										": ",
										"(",
										"X",
										"=",
										vector.x.ToString(),
										"; ",
										"Y",
										"=",
										vector.y.ToString(),
										"; ",
										"Z",
										"=",
										vector.z.ToString(),
										")"
									}), GClass70.Enum1.const_0);
									vector = position3 - position2;
									GClass70.smethod_38(string.Concat(new string[]
									{
										"Difference",
										" ",
										"Between",
										" ",
										"Avatar",
										" ",
										"And",
										" ",
										"Name",
										"Tag",
										": ",
										"(",
										"X",
										"=",
										vector.x.ToString(),
										"; ",
										"Y",
										"=",
										vector.y.ToString(),
										"; ",
										"Z",
										"=",
										vector.z.ToString(),
										")"
									}), GClass70.Enum1.const_0);
									return;
								}
							}
							goto IL_3BF;
						}
					}
					goto IL_271;
				}
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00079820 File Offset: 0x00077A20
		internal static string smethod_1596(string string_4, string string_5, string string_6)
		{
			return GClass84.smethod_483(string_4, string_5, string_6);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00079838 File Offset: 0x00077A38
		internal static void smethod_1597(Animator animator_0)
		{
			GClass84.smethod_1560(animator_0);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0007984C File Offset: 0x00077A4C
		internal static void smethod_1598(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_616(vrcplayer_0);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00079860 File Offset: 0x00077A60
		internal static float smethod_1599(Vector4 vector4_0)
		{
			return (float)Math.Sqrt((double)(vector4_0.x * vector4_0.x + vector4_0.y * vector4_0.y + vector4_0.z * vector4_0.z + vector4_0.w * vector4_0.w));
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0005D078 File Offset: 0x0005B278
		internal static GameObject smethod_1600(PlayerNet playerNet_0)
		{
			GameObject result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_172(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000798B0 File Offset: 0x00077AB0
		internal static string smethod_1601()
		{
			return GClass84.smethod_559();
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00066C54 File Offset: 0x00064E54
		internal static GameObject smethod_1602(PlayerNet playerNet_0)
		{
			GameObject result;
			if (!playerNet_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_428(playerNet_0.transform);
			}
			return result;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000798C4 File Offset: 0x00077AC4
		internal static List<Transform> smethod_1603(bool bool_10, bool bool_11 = false, bool bool_12 = false)
		{
			List<Transform> list = new List<Transform>();
			List<Transform> list2 = GClass84.smethod_1710();
			for (int i = 0; i < list2.Count; i++)
			{
				if ((bool_11 || !(list2[i].tag == "Player")) && (bool_12 || (!(list2[i].name == "PlayerManager") && !(list2[i].name == "VRC_OBJECTS") && !(list2[i].name == "SceneEventHandlerAndInstantiator"))))
				{
					list.Add(list2[i]);
					if (bool_10)
					{
						list.AddRange(GClass84.smethod_1495(list2[i]));
					}
				}
			}
			return list;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0007998C File Offset: 0x00077B8C
		internal static void smethod_1604(string string_4)
		{
			GClass84.smethod_370(string_4);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000799A0 File Offset: 0x00077BA0
		internal static bool smethod_1605(VRCPlayer vrcplayer_0, bool bool_10 = false)
		{
			bool result;
			if (!vrcplayer_0)
			{
				GClass70.smethod_38("VRCP Is Null!", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				result = GClass84.smethod_1145(GClass84.smethod_385(vrcplayer_0), vrcplayer_0.Method_Public_get_String_2(), bool_10);
			}
			return result;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000799DC File Offset: 0x00077BDC
		internal static Transform smethod_1606(Transform transform_0, string string_4)
		{
			Transform result;
			if (!transform_0 || string.IsNullOrEmpty(string_4))
			{
				result = null;
			}
			else
			{
				for (int i = 0; i < transform_0.childCount; i++)
				{
					Transform child = transform_0.GetChild(i);
					if (child.name == string_4)
					{
						return child;
					}
					Transform transform = GClass84.smethod_1606(child, string_4);
					if (transform)
					{
						return transform;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00079A48 File Offset: 0x00077C48
		internal static Vector3 smethod_1607(GameObject gameObject_39, GClass84.GEnum47 genum47_0)
		{
			Vector3 result;
			if (!gameObject_39)
			{
				result = default(Vector3);
			}
			else
			{
				result = GClass84.smethod_272(gameObject_39.transform, genum47_0);
			}
			return result;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00079A7C File Offset: 0x00077C7C
		internal static void smethod_1608(string string_4, string string_5, ref string string_6)
		{
			using (WebClient webClient = new WebClient())
			{
				byte[] bytes = webClient.DownloadData(string_4);
				string_6 = string_5 + "." + webClient.ResponseHeaders[HttpResponseHeader.ContentType].Split(new char[]
				{
					'/'
				})[1];
				File.WriteAllBytes(string_6, bytes);
			}
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00079AE8 File Offset: 0x00077CE8
		internal static void smethod_1609(Color color_0, string string_4)
		{
			GClass84.smethod_529(color_0, string_4);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00079AFC File Offset: 0x00077CFC
		internal static bool smethod_1610(string string_4, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, int int_1)
		{
			VRC_EventHandler vrc_EventHandler = GClass84.VRC_EventHandler_0;
			bool result;
			if (!vrc_EventHandler)
			{
				result = false;
			}
			else
			{
				vrc_EventHandler.TriggerEvent(string_4, vrcBroadcastType_0, gameObject_39, int_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00079B2C File Offset: 0x00077D2C
		internal static int smethod_1611(string string_4, string string_5)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = -1;
			}
			else
			{
				result = string_4.IndexOf(string_5);
			}
			return result;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00079B64 File Offset: 0x00077D64
		internal static void smethod_1612(UiVRCList uiVRCList_0, List<ApiAvatar> list_51)
		{
			GClass84.smethod_716(uiVRCList_0, list_51);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00079B78 File Offset: 0x00077D78
		internal static void smethod_1613()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00079B9C File Offset: 0x00077D9C
		internal static void smethod_1614(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null)
			{
				GClass84.smethod_445(GClass84.smethod_958(vrcplayerApi_0));
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00079BBC File Offset: 0x00077DBC
		internal static string smethod_1615(VRCPlayer vrcplayer_0, string string_4)
		{
			string result;
			if (!vrcplayer_0)
			{
				result = string_4;
			}
			else
			{
				result = GClass84.smethod_977(vrcplayer_0.Method_Public_get_VRCPlayerApi_0(), string_4);
			}
			return result;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00079BE8 File Offset: 0x00077DE8
		internal static void smethod_1616(float float_3)
		{
			GClass84.smethod_1336(float_3);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00079BFC File Offset: 0x00077DFC
		internal static void smethod_1617()
		{
			GClass84.smethod_1672();
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00079C10 File Offset: 0x00077E10
		internal static string smethod_1618(string string_4)
		{
			return GClass84.smethod_1718(string_4, "(", ")");
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00079C30 File Offset: 0x00077E30
		internal static List<Player> smethod_1619()
		{
			PlayerManager playerManager = GClass84.smethod_1472();
			List<Player> result;
			if (!playerManager)
			{
				result = new List<Player>();
			}
			else
			{
				result = playerManager.field_Private_List_1_Player_0;
			}
			return result;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00079C60 File Offset: 0x00077E60
		internal static void smethod_1620(Transform transform_0)
		{
			if (transform_0)
			{
				transform_0.gameObject.SetActive(false);
				transform_0.SetParent(null);
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00079C88 File Offset: 0x00077E88
		internal static void smethod_1621(Slider slider_0, UnityAction<float> unityAction_0)
		{
			GClass84.smethod_1058(slider_0, unityAction_0);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00079C9C File Offset: 0x00077E9C
		internal static List<GameObject> smethod_1622(Transform transform_0, string string_4)
		{
			List<GameObject> result;
			if (!transform_0)
			{
				result = new List<GameObject>();
			}
			else
			{
				result = GClass84.smethod_180(transform_0.gameObject, string_4);
			}
			return result;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00079CCC File Offset: 0x00077ECC
		internal static APIUser smethod_1623()
		{
			return GClass84.smethod_696(GClass84.smethod_950());
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00079CE8 File Offset: 0x00077EE8
		internal static GameObject smethod_1624()
		{
			if (!GClass84.gameObject_32)
			{
				Transform transform = GClass84.smethod_235();
				if (transform)
				{
					Transform transform2 = transform.Find(GClass84.smethod_1204("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button", GClass84.smethod_593("/UserInterface") + 1, -1));
					GClass84.gameObject_32 = ((transform2 != null) ? transform2.gameObject : null);
				}
			}
			return GClass84.gameObject_32;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00079D48 File Offset: 0x00077F48
		internal static void smethod_1625(Text text_1)
		{
			GClass84.smethod_1498(text_1);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00079D5C File Offset: 0x00077F5C
		internal static void smethod_1626(string string_4)
		{
			if (GClass84.smethod_1428(string_4, GClass84.smethod_593("CrashPlayer_Avatar_Quest(")) == "CrashPlayer_Avatar_Quest(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("CrashPlayer_Avatar_Quest("), -1);
				int num = GClass84.smethod_1611(string_4, ");");
				if (num != -1 && GClass84.smethod_1204(string_4, num + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					GClass84.smethod_225(GClass84.smethod_554(GClass84.smethod_1428(string_4, num)));
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("CrashPlayer_Avatar(")) == "CrashPlayer_Avatar(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("CrashPlayer_Avatar("), -1);
				int num2 = GClass84.smethod_1611(string_4, ");");
				if (num2 != -1 && GClass84.smethod_1204(string_4, num2 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					GClass84.smethod_652(GClass84.smethod_554(GClass84.smethod_1428(string_4, num2)));
				}
			}
			else if (string_4 == "Crash_Avatar();")
			{
				GClass84.smethod_199();
			}
			else if (string_4 == "Crash_Avatar_Quest();")
			{
				GClass84.smethod_1377();
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("EventSpam_SpawnEmojiRPC(")) == "EventSpam_SpawnEmojiRPC(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("EventSpam_SpawnEmojiRPC("), -1);
				int num3 = GClass84.smethod_1611(string_4, ");");
				if (num3 != -1 && GClass84.smethod_1204(string_4, num3 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string text = GClass84.smethod_1428(string_4, num3);
					if (text == string.Empty)
					{
						GClass84.smethod_1391();
					}
					else
					{
						GClass84.smethod_13(GClass84.smethod_1730(text));
					}
				}
			}
			else if (string_4 == "EventSpam_SpawnEmojiRPC_Stop();")
			{
				GClass84.smethod_962();
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("JoinRoom(")) == "JoinRoom(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("JoinRoom("), -1);
				int num4 = GClass84.smethod_1611(string_4, ");");
				if (num4 != -1 && GClass84.smethod_1204(string_4, num4 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num4);
					num4 = GClass84.smethod_1611(string_4, ":");
					if (num4 != -1)
					{
						GClass84.smethod_704(string_4);
					}
				}
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("ChangeAvatar(")) == "ChangeAvatar(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("ChangeAvatar("), -1);
				int num5 = GClass84.smethod_1611(string_4, ");");
				if (num5 != -1 && GClass84.smethod_1204(string_4, num5 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					GClass84.smethod_711(GClass84.smethod_1428(string_4, num5));
				}
			}
			else if (string_4 == "Respawn();")
			{
				GClass84.smethod_251();
			}
			else if (GClass84.smethod_1428(string_4, GClass84.smethod_593("TeleportTo(")) == "TeleportTo(")
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593("TeleportTo("), -1);
				int num6 = GClass84.smethod_1611(string_4, ");");
				if (num6 != -1 && GClass84.smethod_1204(string_4, num6 + GClass84.smethod_593(");"), -1) == string.Empty)
				{
					string_4 = GClass84.smethod_1428(string_4, num6);
					num6 = GClass84.smethod_1611(string_4, ",");
					if (num6 == -1)
					{
						List<int> list = GClass84.smethod_932(string_4, "|");
						float num7;
						float num8;
						float num9;
						if (list.Count == 2 && (GClass84.smethod_99(GClass84.smethod_1428(string_4, list[0]), out num7) && GClass84.smethod_99(GClass84.smethod_1204(string_4, list[0] + 1, list[1] - list[0] - 1), out num8) && GClass84.smethod_99(GClass84.smethod_1204(string_4, list[1] + 1, -1), out num9)))
						{
							GClass84.smethod_1740(new Vector3(num7, num8, num9), false);
						}
					}
					else
					{
						string string_5 = GClass84.smethod_1204(string_4, num6 + 1, -1);
						string_4 = GClass84.smethod_1428(string_4, num6);
						bool bool_;
						if (GClass84.smethod_742(string_5, out bool_))
						{
							List<int> list2 = GClass84.smethod_932(string_4, "|");
							float num10;
							float num11;
							float num12;
							if (list2.Count == 2 && (GClass84.smethod_99(GClass84.smethod_1428(string_4, list2[0]), out num10) && GClass84.smethod_99(GClass84.smethod_1204(string_4, list2[0] + 1, list2[1] - list2[0] - 1), out num11) && GClass84.smethod_99(GClass84.smethod_1204(string_4, list2[1] + 1, -1), out num12)))
							{
								GClass84.smethod_1740(new Vector3(num10, num11, num12), bool_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0007A25C File Offset: 0x0007845C
		internal static int smethod_1627()
		{
			int num = 0;
			List<GameObject> list = GClass84.smethod_56();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				Object.DestroyImmediate(list[i], true);
				num++;
			}
			return num;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0007A2A0 File Offset: 0x000784A0
		internal static void smethod_1628()
		{
			GClass84.smethod_638();
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0007A2B4 File Offset: 0x000784B4
		internal static string smethod_1629(int int_1)
		{
			string text = string.Empty;
			for (int i = 0; i < int_1; i++)
			{
				text += new Random().Next(0, int.MaxValue).ToString("X8");
			}
			return text;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0007A300 File Offset: 0x00078500
		internal static Vector3 smethod_1630()
		{
			VRCUiCursor vrcuiCursor = GClass84.smethod_240();
			Vector3 result;
			if (vrcuiCursor.gameObject.active)
			{
				result = vrcuiCursor.field_Public_Vector3_0;
			}
			else
			{
				result = Vector3.zero;
			}
			return result;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0007A330 File Offset: 0x00078530
		internal static string smethod_1631(string string_4, string string_5)
		{
			return string_5 + string_4 + string_5;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0007A348 File Offset: 0x00078548
		internal static void smethod_1632(this Player player_0, float float_3)
		{
			GClass84.smethod_867(player_0, float_3);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0007A35C File Offset: 0x0007855C
		internal static string smethod_1633(Component component_0)
		{
			string result;
			if (!component_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(component_0.transform, null);
			}
			return result;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0007A38C File Offset: 0x0007858C
		internal static void smethod_1634(PlayerNet playerNet_0)
		{
			GClass84.smethod_885(playerNet_0);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0005E834 File Offset: 0x0005CA34
		internal static int smethod_1635(string string_4, string string_5)
		{
			int result;
			if (string_4 == string.Empty || string_5 == string.Empty)
			{
				result = -1;
			}
			else
			{
				result = string_4.LastIndexOf(string_5);
			}
			return result;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0007A3A0 File Offset: 0x000785A0
		internal static string smethod_1636()
		{
			return GClass84.smethod_481();
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0007A3B4 File Offset: 0x000785B4
		internal static string smethod_1637()
		{
			return GClass84.smethod_1150();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0007A3C8 File Offset: 0x000785C8
		internal static string smethod_1638(string string_4, int int_1)
		{
			return GClass84.smethod_1482(string_4, int_1);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0007A3DC File Offset: 0x000785DC
		internal static Transform smethod_1639()
		{
			GameObject gameObject = GClass84.smethod_729();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0007A3FC File Offset: 0x000785FC
		internal static bool smethod_1640(Color32 color32_0)
		{
			return color32_0.r == color32_0.g && color32_0.r == color32_0.b;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0007A428 File Offset: 0x00078628
		internal static float smethod_1641(float float_3)
		{
			if (float_3 < 0.01f)
			{
				float_3 = 0.01f;
			}
			Camera.main.nearClipPlane = float_3;
			return float_3;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0007A454 File Offset: 0x00078654
		internal static void smethod_1642(string string_4, string string_5, string string_6)
		{
			GClass84.smethod_477(string_4, string_5, string_6);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0007A46C File Offset: 0x0007866C
		internal static string smethod_1643(string string_4, int int_1)
		{
			return GClass84.smethod_1208(string_4, int_1);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0007A480 File Offset: 0x00078680
		internal static bool smethod_1644(List<Transform> list_51, GameObject gameObject_39, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null || !gameObject_39)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_353(list_51[i], gameObject_39, genum47_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0007A4D4 File Offset: 0x000786D4
		internal static string smethod_1645()
		{
			return GClass84.smethod_769();
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0007A4E8 File Offset: 0x000786E8
		internal static Transform smethod_1646()
		{
			GameObject gameObject = GClass84.smethod_687();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0007A508 File Offset: 0x00078708
		internal static Transform smethod_1647()
		{
			GameObject gameObject = GClass84.smethod_1729();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0007A528 File Offset: 0x00078728
		internal static void smethod_1648(Animator animator_0)
		{
			GClass84.smethod_1597(animator_0);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0007A53C File Offset: 0x0007873C
		internal static GameObject smethod_1649()
		{
			if (!GClass84.gameObject_6)
			{
				GClass84.gameObject_6 = GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo");
			}
			return GClass84.gameObject_6;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0007A570 File Offset: 0x00078770
		internal static bool smethod_1650(GameObject gameObject_39, GameObject gameObject_40)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_1493(gameObject_39.transform, gameObject_40.transform);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0007A5AC File Offset: 0x000787AC
		internal static Color32 smethod_1651(Color32 color32_0, float float_3)
		{
			float_3 %= 360f;
			Color32 result;
			if (GClass84.smethod_1640(color32_0) || float_3 == 0f)
			{
				result = color32_0;
			}
			else
			{
				if (float_3 < 120f)
				{
					float float_4 = float_3 / 120f;
					color32_0 = new Color(GClass84.smethod_802((float)color32_0.r, (float)color32_0.g, float_4), GClass84.smethod_802((float)color32_0.g, (float)color32_0.b, float_4), GClass84.smethod_802((float)color32_0.b, (float)color32_0.r, float_4), (float)color32_0.a);
				}
				else if (float_3 == 120f)
				{
					color32_0 = new Color((float)color32_0.g, (float)color32_0.b, (float)color32_0.r, (float)color32_0.a);
				}
				else if (float_3 < 240f)
				{
					float float_5 = (float_3 - 120f) / 120f;
					color32_0 = new Color(GClass84.smethod_802((float)color32_0.g, (float)color32_0.b, float_5), GClass84.smethod_802((float)color32_0.b, (float)color32_0.r, float_5), GClass84.smethod_802((float)color32_0.r, (float)color32_0.g, float_5), (float)color32_0.a);
				}
				else if (float_3 == 240f)
				{
					color32_0 = new Color((float)color32_0.b, (float)color32_0.r, (float)color32_0.g, (float)color32_0.a);
				}
				else if (float_3 < 360f)
				{
					float float_6 = (float_3 - 240f) / 120f;
					color32_0 = new Color(GClass84.smethod_802((float)color32_0.b, (float)color32_0.r, float_6), GClass84.smethod_802((float)color32_0.r, (float)color32_0.g, float_6), GClass84.smethod_802((float)color32_0.g, (float)color32_0.b, float_6), (float)color32_0.a);
				}
				result = color32_0;
			}
			return result;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0007A790 File Offset: 0x00078990
		internal static GameObject smethod_1652()
		{
			if (!GClass84.gameObject_4)
			{
				GClass84.gameObject_4 = GameObject.Find(GClass84.smethod_8());
			}
			return GClass84.gameObject_4;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0007A7C4 File Offset: 0x000789C4
		internal static void smethod_1653()
		{
			GClass84.smethod_136();
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0007A7D8 File Offset: 0x000789D8
		internal static void smethod_1654()
		{
			GClass84.smethod_1203();
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0007A7EC File Offset: 0x000789EC
		internal static void smethod_1655(VRCPlayer vrcplayer_0)
		{
			if (vrcplayer_0)
			{
				try
				{
					GClass70.smethod_24("prop_String_0" + ": " + vrcplayer_0.Method_Public_get_String_2(), GClass70.Enum1.const_0);
					GClass70.smethod_24("prop_String_1" + ": " + vrcplayer_0.Method_Public_get_String_3(), GClass70.Enum1.const_0);
					GClass70.smethod_24("prop_String_2" + ": " + vrcplayer_0.Method_Public_get_String_0(), GClass70.Enum1.const_0);
					GClass70.smethod_24("prop_String_3" + ": " + vrcplayer_0.Method_Private_get_String_PDM_0(), GClass70.Enum1.const_0);
					GClass70.smethod_24("prop_String_4" + ": " + vrcplayer_0.Method_Public_get_String_1(), GClass70.Enum1.const_0);
					GClass70.smethod_24("field_Private_String_0" + ": " + vrcplayer_0.field_Private_String_0, GClass70.Enum1.const_0);
					GClass70.smethod_24("field_Private_String_1" + ": " + vrcplayer_0.field_Private_String_1, GClass70.Enum1.const_0);
					GClass70.smethod_24("field_Private_String_2" + ": " + vrcplayer_0.field_Private_String_2, GClass70.Enum1.const_0);
					string str = "field_Private_Dictionary_2_String_String_0";
					string str2 = ": ";
					Dictionary<string, string> field_Private_Dictionary_2_String_String_ = vrcplayer_0.field_Private_Dictionary_2_String_String_0;
					GClass70.smethod_24(str + str2 + ((field_Private_Dictionary_2_String_String_ != null) ? field_Private_Dictionary_2_String_String_.ToString() : null), GClass70.Enum1.const_0);
					GClass70.smethod_24("Method_Public_String_PDM_0()" + ": " + vrcplayer_0.Method_Public_String_PDM_0(), GClass70.Enum1.const_0);
					Player player = GClass84.smethod_384(vrcplayer_0);
					if (player)
					{
						GClass70.smethod_24(player.Method_Public_get_String_0(), GClass70.Enum1.const_0);
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_38(ex.Message, GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0007A96C File Offset: 0x00078B6C
		internal static string smethod_1656(Player player_0)
		{
			return GClass84.smethod_339(player_0);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0007A980 File Offset: 0x00078B80
		internal static bool smethod_1657(string string_4)
		{
			return GClass84.smethod_1019(Object.FindObjectsOfType<UdonBehaviour>().ToList<UdonBehaviour>(), string_4);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0007A9A0 File Offset: 0x00078BA0
		internal static void smethod_1658()
		{
			for (int i = 0; i < 100; i++)
			{
				GClass84.smethod_1659(5, GClass84.smethod_917<Object>(null), new RaiseEventOptions
				{
					field_Public_ReceiverGroup_0 = 0
				}, SendOptions.SendReliable);
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0007AA04 File Offset: 0x00078C04
		internal static bool smethod_1659(byte byte_0, Object object_0, RaiseEventOptions raiseEventOptions_0, SendOptions sendOptions_0)
		{
			PhotonNetwork.Method_Public_Static_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(byte_0, object_0, raiseEventOptions_0, sendOptions_0);
			return true;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0007AA1C File Offset: 0x00078C1C
		internal static List<GClass84.GStruct163> smethod_1660(int int_1, int int_2, int int_3, int int_4)
		{
			List<GClass84.GStruct163> list = GClass84.smethod_768(int_1, int_2, int_3, int_4);
			GClass84.GStruct163 gstruct = GClass84.smethod_50(int_1, int_2, int_3, int_4);
			List<GClass84.GStruct163> result;
			if (gstruct.int_0 == int_1 && gstruct.int_1 == int_2 - int_3)
			{
				result = list;
			}
			else
			{
				list.AddRange(GClass84.smethod_1698(int_1, int_2, int_1, int_2 - int_3));
				list.AddRange(GClass84.smethod_1698(int_1, int_2, gstruct.int_0, gstruct.int_1));
				result = list;
			}
			return result;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00060468 File Offset: 0x0005E668
		internal static Transform smethod_1661(VRCPlayer vrcplayer_0)
		{
			Transform result;
			if (!vrcplayer_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_855(vrcplayer_0.transform);
			}
			return result;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0007AA88 File Offset: 0x00078C88
		internal static List<FABRIK> smethod_1662(GameObject gameObject_39)
		{
			List<FABRIK> result;
			if (!gameObject_39)
			{
				result = new List<FABRIK>();
			}
			else
			{
				List<FABRIK> list = gameObject_39.GetComponents<FABRIK>().ToList<FABRIK>();
				list.AddRange(gameObject_39.GetComponentsInChildren<FABRIK>(true));
				result = list.Distinct<FABRIK>().ToList<FABRIK>();
			}
			return result;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0007AAD0 File Offset: 0x00078CD0
		internal static bool smethod_1663(Player player_0)
		{
			return player_0 && GClass84.smethod_1260(GClass84.smethod_28(player_0));
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0007AAFC File Offset: 0x00078CFC
		internal static string smethod_1664()
		{
			ApiAvatar apiAvatar = GClass84.smethod_604();
			string result;
			if (apiAvatar == null)
			{
				result = string.Empty;
			}
			else
			{
				result = apiAvatar.id;
			}
			return result;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0007AB28 File Offset: 0x00078D28
		internal static void smethod_1665(string string_4)
		{
			if (!string.IsNullOrEmpty(string_4) && !(GClass84.smethod_362(GClass84.smethod_979()) == GClass84.smethod_362(string_4)) && !GClass84.smethod_939(string_4))
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Joining",
					" ",
					"Instance",
					" ",
					string_4
				}), GClass70.Enum1.const_0);
				Networking.GoToRoom(string_4);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0007AB9C File Offset: 0x00078D9C
		internal static string smethod_1666(ApiWorld apiWorld_0, string string_4)
		{
			return GClass84.smethod_509(apiWorld_0, string_4);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0007ABB0 File Offset: 0x00078DB0
		internal static T[] smethod_1667<T>(List<T> list_51, IEqualityComparer<T> iequalityComparer_0)
		{
			T[] result;
			if (list_51 == null || list_51.Count == 0)
			{
				result = null;
			}
			else
			{
				result = list_51.Distinct(iequalityComparer_0).ToArray<T>();
			}
			return result;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0007ABE0 File Offset: 0x00078DE0
		internal static T smethod_1668<T>(T gparam_0) where T : Object
		{
			T result;
			if (gparam_0 == null)
			{
				result = default(T);
			}
			else
			{
				T t = Object.Instantiate<T>(gparam_0);
				GClass84.smethod_48<T>(ref t);
				result = t;
			}
			return result;
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0007AC18 File Offset: 0x00078E18
		internal static Color smethod_1669(int int_1)
		{
			Color result;
			if (int_1 <= 0)
			{
				result = new Color(0f, 0f, 0f, 1f);
			}
			else if (int_1 < 20)
			{
				result = new Color((float)int_1 / 20f, 0f, 0f, 1f);
			}
			else if (int_1 < 40)
			{
				result = new Color(1f, (float)(int_1 - 20) / 20f, 0f, 1f);
			}
			else if (int_1 < 60)
			{
				result = new Color(1f - (float)(int_1 - 40) / 20f, 1f, 0f, 1f);
			}
			else
			{
				result = new Color(0f, 1f, 0f, 1f);
			}
			return result;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0007ACE8 File Offset: 0x00078EE8
		internal static Texture2D smethod_1670(Texture2D texture2D_0)
		{
			Color32[] array = texture2D_0.GetPixels32();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = GClass84.smethod_1505(array[i]);
			}
			texture2D_0.SetPixels32(array);
			texture2D_0.Apply();
			return texture2D_0;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0007AD40 File Offset: 0x00078F40
		internal static bool smethod_1671(PlayerNet playerNet_0)
		{
			return playerNet_0 && GClass84.smethod_307(GClass84.smethod_782(playerNet_0));
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0007AD6C File Offset: 0x00078F6C
		internal static void smethod_1672()
		{
			ApiWorld apiWorld = GClass84.smethod_1424();
			if (apiWorld != null)
			{
				ApiWorldInstance apiWorldInstance = GClass84.smethod_813();
				List<string> list = new List<string>();
				if (apiWorldInstance != null)
				{
					list.Add(apiWorldInstance.instanceId);
				}
				ApiWorldInstance bestInstance = apiWorld.GetBestInstance(GClass84.smethod_1645(), list, false, false, 0);
				GClass84.smethod_704(apiWorld.id + ":" + bestInstance.instanceId);
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0007ADD0 File Offset: 0x00078FD0
		internal static int smethod_1673(int int_1)
		{
			int result;
			if (int_1 <= 1)
			{
				result = 0;
			}
			else
			{
				GClass84.smethod_883();
				result = Random.Range(0, int_1);
			}
			return result;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0007ADF8 File Offset: 0x00078FF8
		internal static List<GameObject> smethod_1674(GameObject gameObject_39, List<Transform> list_51)
		{
			List<GameObject> result;
			if (!gameObject_39)
			{
				result = new List<GameObject>();
			}
			else if (list_51 == null || list_51.Count == 0)
			{
				result = GClass84.smethod_1143(gameObject_39);
			}
			else
			{
				List<GameObject> list = new List<GameObject>
				{
					gameObject_39
				};
				list.AddRange(GClass84.smethod_94(gameObject_39));
				result = list;
			}
			return result;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0007AE50 File Offset: 0x00079050
		internal static void smethod_1675(CursorLockMode cursorLockMode_0)
		{
			GClass84.smethod_1582(cursorLockMode_0);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0007AE64 File Offset: 0x00079064
		internal static bool smethod_1676(out Scene scene_0)
		{
			List<Scene> list = GClass84.smethod_311(false);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].name == "HideAndDontSave")
				{
					scene_0 = list[i];
					return true;
				}
			}
			scene_0 = default(Scene);
			return false;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0007AECC File Offset: 0x000790CC
		internal static List<Player> smethod_1677()
		{
			PlayerManager playerManager = GClass84.smethod_1472();
			List<Player> result;
			if (!playerManager)
			{
				result = new List<Player>();
			}
			else
			{
				result = playerManager.field_Private_List_1_Player_0.smethod_1334<Player>();
			}
			return result;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0007AF00 File Offset: 0x00079100
		internal static Shader smethod_1678()
		{
			if (!GClass84.shader_1)
			{
				GClass84.shader_1 = Shader.Find("Diffuse");
			}
			return GClass84.shader_1;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0007AF34 File Offset: 0x00079134
		internal static Color smethod_1679(APIUser apiuser_0)
		{
			return GClass84.smethod_1041(GClass84.smethod_307(apiuser_0));
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0007AF50 File Offset: 0x00079150
		internal static void smethod_1680(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_1488(vrcplayer_0);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0007AF64 File Offset: 0x00079164
		internal static bool smethod_1681(GameObject gameObject_39, GameObject gameObject_40, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_535(gameObject_39, GClass84.smethod_1607(gameObject_40, genum47_0), bool_10);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0007AF9C File Offset: 0x0007919C
		internal static Transform smethod_1682()
		{
			GameObject gameObject = GClass84.smethod_814();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0007AFBC File Offset: 0x000791BC
		internal static void smethod_1683(ref HighlightsFXStandalone highlightsFXStandalone_1, Color color_0)
		{
			GClass84.smethod_34(ref highlightsFXStandalone_1, color_0);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0007AFD0 File Offset: 0x000791D0
		internal static bool smethod_1684(VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0 && GClass84.smethod_307(GClass84.smethod_856(vrcplayer_0));
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0007AFFC File Offset: 0x000791FC
		internal static string smethod_1685(string string_4, string string_5)
		{
			return string_4.Replace(string_5, string.Empty);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0007B018 File Offset: 0x00079218
		internal static VRCPlayerApi smethod_1686(Transform transform_0, bool bool_10 = true)
		{
			VRCPlayerApi result;
			if (!transform_0)
			{
				result = null;
			}
			else if (bool_10)
			{
				result = Networking.GetOwner(transform_0.gameObject);
			}
			else
			{
				List<VRCPlayerApi> list = GClass84.smethod_1239();
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].IsOwner(transform_0.gameObject))
					{
						return list[i];
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0007B08C File Offset: 0x0007928C
		internal static List<Transform> smethod_1687(Transform transform_0, int int_1)
		{
			List<Transform> result;
			if (!transform_0)
			{
				result = new List<Transform>();
			}
			else if (int_1 == 1)
			{
				result = GClass84.smethod_403(transform_0);
			}
			else
			{
				result = GClass84.smethod_878(GClass84.smethod_403(transform_0), int_1 - 1);
			}
			return result;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0007B0CC File Offset: 0x000792CC
		internal static bool smethod_1688<T>(List<T> list_51, T gparam_0) where T : Object
		{
			bool result;
			if (gparam_0 == null || list_51 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (list_51[i] == gparam_0)
					{
						list_51.RemoveAt(i);
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0007B134 File Offset: 0x00079334
		internal static void smethod_1689(GameObject gameObject_39)
		{
			if (gameObject_39)
			{
				foreach (Component component in gameObject_39.GetComponents<Component>())
				{
					if (component)
					{
						GClass70.smethod_38(component.ToString(), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0007B1A0 File Offset: 0x000793A0
		internal static int smethod_1690(int int_1, int int_2)
		{
			int result;
			if (int_1 > int_2)
			{
				result = int_1;
			}
			else
			{
				result = int_2;
			}
			return result;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0007B1BC File Offset: 0x000793BC
		internal static void smethod_1691(VRC_EventHandler vrc_EventHandler_1)
		{
			GClass84.vrc_EventHandler_0 = vrc_EventHandler_1;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0007B1D0 File Offset: 0x000793D0
		internal static string smethod_1692(Component component_0, Transform transform_0)
		{
			string result;
			if (!component_0)
			{
				result = string.Empty;
			}
			else
			{
				result = GClass84.smethod_908(component_0.transform, transform_0);
			}
			return result;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0007B200 File Offset: 0x00079400
		internal static void smethod_1693(string string_4)
		{
			GClass84.smethod_1665(string_4);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0007B214 File Offset: 0x00079414
		internal static void smethod_1694()
		{
			GClass84.smethod_1499();
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0007B228 File Offset: 0x00079428
		internal static void smethod_1695(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_397(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0007B248 File Offset: 0x00079448
		internal static void smethod_1696(float float_3)
		{
			GClass84.smethod_1047(float_3);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0007B25C File Offset: 0x0007945C
		internal static bool smethod_1697(UdonBehaviour udonBehaviour_0, string string_4)
		{
			bool result;
			if (!udonBehaviour_0)
			{
				result = false;
			}
			else
			{
				List<string> list = GClass84.smethod_16(udonBehaviour_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i] == string_4)
					{
						udonBehaviour_0.SendCustomEvent(string_4);
						return true;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0007B2B4 File Offset: 0x000794B4
		internal static List<GClass84.GStruct163> smethod_1698(int int_1, int int_2, int int_3, int int_4)
		{
			List<GClass84.GStruct163> list = new List<GClass84.GStruct163>();
			if (int_1 == int_3)
			{
				for (int i = GClass84.smethod_741(int_2, int_4); i <= GClass84.smethod_1690(int_2, int_4); i++)
				{
					list.Add(new GClass84.GStruct163(int_1, i));
				}
			}
			else if (int_2 == int_4)
			{
				for (int i = GClass84.smethod_741(int_1, int_3); i <= GClass84.smethod_1690(int_1, int_3); i++)
				{
					list.Add(new GClass84.GStruct163(i, int_2));
				}
			}
			else
			{
				if (GClass84.smethod_624(int_2 - int_4) > GClass84.smethod_624(int_1 - int_3))
				{
					return GClass84.smethod_1227(int_1, int_2, int_3, int_4);
				}
				return GClass84.smethod_244(int_1, int_2, int_3, int_4);
			}
			return list;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0007B35C File Offset: 0x0007955C
		internal static float smethod_1699()
		{
			Player player = GClass84.smethod_1010();
			float result;
			if (!player)
			{
				result = 0f;
			}
			else
			{
				MonoBehaviourPublicSimastSiofdiChSiLagrUnique component = player.GetComponent<MonoBehaviourPublicSimastSiofdiChSiLagrUnique>();
				if (!component)
				{
					result = 0f;
				}
				else
				{
					result = component.maxStepHeight;
				}
			}
			return result;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0007B3A4 File Offset: 0x000795A4
		internal static string smethod_1700(string string_4)
		{
			return GClass84.smethod_757(string_4);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0007B3B8 File Offset: 0x000795B8
		internal static void smethod_1701(PortalInternal portalInternal_0)
		{
			GClass84.smethod_300(portalInternal_0);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0007B3CC File Offset: 0x000795CC
		internal static void smethod_1702(Renderer renderer_0, bool bool_10, ref HighlightsFXStandalone highlightsFXStandalone_1)
		{
			GClass84.smethod_236(renderer_0, bool_10, ref highlightsFXStandalone_1);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0007B3E4 File Offset: 0x000795E4
		internal static void smethod_1703(string string_4, string string_5, string string_6, NotificationDetails notificationDetails_0)
		{
			if (!GClass84.smethod_334(string_4))
			{
				NotificationManager notificationManager = GClass84.smethod_10();
				if (notificationManager)
				{
					notificationManager.Method_Private_Void_String_String_String_NotificationDetails_0(string_4, string_5, string_6, notificationDetails_0);
				}
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0007B414 File Offset: 0x00079614
		internal static IUser smethod_1704()
		{
			SelectedUserMenuQM selectedUserMenuQM = GClass84.smethod_1125();
			return (selectedUserMenuQM != null) ? selectedUserMenuQM.field_Private_IUser_0 : null;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0007B434 File Offset: 0x00079634
		internal static void smethod_1705(APIUser apiuser_0)
		{
			if (apiuser_0 != null)
			{
				GClass84.smethod_511(apiuser_0.id);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0007B454 File Offset: 0x00079654
		internal static void smethod_1706(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			GClass84.smethod_269(gclass156_1, int_1, int_2, int_3, int_4, int_5, int_6);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0007B478 File Offset: 0x00079678
		internal static string smethod_1707(Component component_0, Transform transform_0)
		{
			return GClass84.smethod_1692(component_0, transform_0);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0007B48C File Offset: 0x0007968C
		internal static bool smethod_1708(GameObject gameObject_39, GameObject gameObject_40, bool bool_10 = false)
		{
			return gameObject_39 && gameObject_40 && GClass84.smethod_706(gameObject_39.transform, gameObject_40.transform, bool_10);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0007B4C8 File Offset: 0x000796C8
		internal static Color smethod_1709(VRCPlayerApi vrcplayerApi_0, bool bool_10 = false, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_204(GClass84.smethod_958(vrcplayerApi_0), bool_10, bool_11, bool_12);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0007B4E8 File Offset: 0x000796E8
		internal static List<Transform> smethod_1710()
		{
			return GClass84.smethod_1020(GClass84.smethod_1351());
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0007B504 File Offset: 0x00079704
		internal static USpeaker smethod_1711(PlayerNet playerNet_0)
		{
			return GClass84.smethod_63(GClass84.smethod_440(playerNet_0));
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0007B520 File Offset: 0x00079720
		internal static void smethod_1712()
		{
			GClass84.smethod_730();
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0007B534 File Offset: 0x00079734
		internal static ApiAvatar smethod_1713(VRCAvatarManager vrcavatarManager_0)
		{
			return (vrcavatarManager_0 != null) ? vrcavatarManager_0.Method_Public_get_ApiAvatar_0() : null;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0007B550 File Offset: 0x00079750
		internal static void smethod_1714(PortalInternal portalInternal_0)
		{
			GClass84.smethod_29(portalInternal_0);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0007B564 File Offset: 0x00079764
		internal static void smethod_1715(VRCPlayer vrcplayer_0)
		{
			GClass84.smethod_1444(vrcplayer_0);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0007B578 File Offset: 0x00079778
		internal static Transform[] smethod_1716(bool bool_10, bool bool_11 = false, bool bool_12 = false)
		{
			return GClass84.smethod_1603(bool_10, bool_11, bool_12).ToArray();
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0007B594 File Offset: 0x00079794
		internal static void smethod_1717()
		{
			GClass84.smethod_631();
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0007B5A8 File Offset: 0x000797A8
		internal static string smethod_1718(string string_4, string string_5, string string_6)
		{
			return GClass84.smethod_1596(string_4, string_5, string_6);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0007B5C0 File Offset: 0x000797C0
		internal static Transform smethod_1719()
		{
			GameObject gameObject = GClass84.smethod_1270();
			return (gameObject != null) ? gameObject.transform : null;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0007B5E0 File Offset: 0x000797E0
		internal static byte[] smethod_1720(object object_0)
		{
			byte[] result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, object_0);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0007B614 File Offset: 0x00079814
		internal static int smethod_1721()
		{
			return GClass84.list_45.Count;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0007B630 File Offset: 0x00079830
		internal static void smethod_1722(List<Transform> list_51, Transform transform_0)
		{
			for (int i = 0; i < list_51.Count; i++)
			{
				if (list_51[i])
				{
					list_51[i].SetParent(transform_0);
				}
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0007B66C File Offset: 0x0007986C
		internal static void smethod_1723(GameObject gameObject_39, Color color_0)
		{
			GClass84.smethod_819(gameObject_39, color_0);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0007B680 File Offset: 0x00079880
		internal static void smethod_1724(ApiAvatar apiAvatar_0)
		{
			GClass84.smethod_1340(apiAvatar_0);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0007B694 File Offset: 0x00079894
		internal static bool smethod_1725(Player player_0)
		{
			return player_0 && GClass84.smethod_307(GClass84.smethod_518(player_0));
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0007B6C0 File Offset: 0x000798C0
		internal static void smethod_1726(VRC_EventHandler.VrcEventType vrcEventType_0, VRC_EventHandler.VrcTargetType vrcTargetType_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, string string_4, object[] object_0, float float_3 = 0f)
		{
			GClass84.smethod_1508(vrcEventType_0, vrcTargetType_0, vrcBroadcastType_0, gameObject_39, string_4, object_0, float_3);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0007B6E4 File Offset: 0x000798E4
		internal static void smethod_1727(bool bool_10)
		{
			GClass84.smethod_398(bool_10);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0007B6F8 File Offset: 0x000798F8
		internal static List<GClass84.GStruct134> smethod_1728(SkinnedMeshRenderer skinnedMeshRenderer_0)
		{
			List<GClass84.GStruct134> result;
			if (!skinnedMeshRenderer_0)
			{
				result = new List<GClass84.GStruct134>();
			}
			else
			{
				result = GClass84.smethod_90(skinnedMeshRenderer_0.sharedMesh);
			}
			return result;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0007B728 File Offset: 0x00079928
		internal static GameObject smethod_1729()
		{
			if (!GClass84.gameObject_11)
			{
				GClass84.gameObject_11 = GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements");
			}
			return GClass84.gameObject_11;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0007B75C File Offset: 0x0007995C
		internal static VRCPlayerApi smethod_1730(string string_4)
		{
			return GClass84.smethod_28(GClass84.smethod_554(string_4));
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0007B778 File Offset: 0x00079978
		internal static Object[] smethod_1731(object[] object_0)
		{
			Object[] array = new Object[object_0.Length];
			for (int i = 0; i < object_0.Length; i++)
			{
				array[i] = GClass84.smethod_917<Object>(object_0[i]);
			}
			return array;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0007B7AC File Offset: 0x000799AC
		internal static void smethod_1732()
		{
			GClass84.smethod_299();
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0006326C File Offset: 0x0006146C
		internal static GameObject smethod_1733(Player player_0)
		{
			GameObject result;
			if (!player_0)
			{
				result = null;
			}
			else
			{
				result = GClass84.smethod_603(player_0.transform);
			}
			return result;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0007B7C0 File Offset: 0x000799C0
		internal static bool smethod_1734(Transform transform_0, string string_4)
		{
			return transform_0 && !(string_4 == string.Empty) && transform_0.parent && (transform_0.parent.name == string_4 || GClass84.smethod_1734(transform_0.parent, string_4));
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0007B820 File Offset: 0x00079A20
		internal static void smethod_1735(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4)
		{
			GClass84.smethod_296(gclass156_1, int_1, int_2, int_3, int_4);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0007B83C File Offset: 0x00079A3C
		internal static void smethod_1736(VRC_EventHandler.VrcEventType vrcEventType_0, VRC_EventHandler.VrcTargetType vrcTargetType_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_39, string string_4, object[] object_0, float float_3)
		{
			Object[] array = new Object[object_0.Length];
			for (int i = 0; i < object_0.Length; i++)
			{
				array[i] = GClass84.smethod_917<Object>(object_0[i]);
			}
			byte[] array2 = Networking.EncodeParameters(array);
			VRC_EventHandler.VrcEvent vrcEvent_ = new VRC_EventHandler.VrcEvent
			{
				EventType = vrcEventType_0,
				ParameterObject = gameObject_39,
				ParameterString = string_4,
				ParameterBytes = array2,
				ParameterInt = vrcTargetType_0
			};
			GClass84.smethod_1212(vrcEvent_, vrcBroadcastType_0, Networking.LocalPlayer.playerId, float_3);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0007B8C4 File Offset: 0x00079AC4
		internal static VRC_Trigger.TriggerType smethod_1737(string string_4)
		{
			uint num = Class217.smethod_0(string_4);
			if (num <= 1569604594U)
			{
				if (num <= 347315158U)
				{
					if (num <= 147811535U)
					{
						if (num != 45102970U)
						{
							if (num != 144496253U)
							{
								if (num == 147811535U)
								{
									if (string_4 == "OnEnable")
									{
										return 2;
									}
								}
							}
							else if (string_4 == "OnDrop")
							{
								return 16;
							}
						}
						else if (string_4 == "OnParticleCollision")
						{
							return 32;
						}
					}
					else if (num <= 197711276U)
					{
						if (num != 164168539U)
						{
							if (num == 197711276U)
							{
								if (string_4 == "OnDisable")
								{
									return 30;
								}
							}
						}
						else if (string_4 == "OnKeyDown")
						{
							return 13;
						}
					}
					else if (num != 233816649U)
					{
						if (num == 347315158U)
						{
							if (string_4 == "OnInteract")
							{
								return 17;
							}
						}
					}
					else if (string_4 == "OnVideoPlay")
					{
						return 28;
					}
				}
				else if (num <= 856205441U)
				{
					if (num <= 613213070U)
					{
						if (num != 354002069U)
						{
							if (num == 613213070U)
							{
								if (string_4 == "OnOwnershipTransfer")
								{
									return 31;
								}
							}
						}
						else if (string_4 == "OnNetworkReady")
						{
							return 5;
						}
					}
					else if (num != 846719484U)
					{
						if (num == 856205441U)
						{
							if (string_4 == "OnTimer")
							{
								return 10;
							}
						}
					}
					else if (string_4 == "OnExitTrigger")
					{
						return 12;
					}
				}
				else if (num <= 1410730651U)
				{
					if (num != 1386513684U)
					{
						if (num == 1410730651U)
						{
							if (string_4 == "OnVideoPause")
							{
								return 29;
							}
						}
					}
					else if (string_4 == "OnExitCollider")
					{
						return 19;
					}
				}
				else if (num != 1545173296U)
				{
					if (num == 1569604594U)
					{
						if (string_4 == "OnPickupUseUp")
						{
							return 9;
						}
					}
				}
				else if (string_4 == "OnPlayerLeft")
				{
					return 7;
				}
			}
			else if (num <= 2763705533U)
			{
				if (num <= 2642699936U)
				{
					if (num != 2189867818U)
					{
						if (num != 2252636364U)
						{
							if (num == 2642699936U)
							{
								if (string_4 == "OnVideoEnd")
								{
									return 27;
								}
							}
						}
						else if (string_4 == "OnPickup")
						{
							return 15;
						}
					}
					else if (string_4 == "OnDestroy")
					{
						return 3;
					}
				}
				else if (num <= 2713888990U)
				{
					if (num != 2660707482U)
					{
						if (num == 2713888990U)
						{
							if (string_4 == "OnEnterTrigger")
							{
								return 11;
							}
						}
					}
					else if (string_4 == "OnKeyUp")
					{
						return 14;
					}
				}
				else if (num != 2735284671U)
				{
					if (num == 2763705533U)
					{
						if (string_4 == "OnStationExited")
						{
							return 25;
						}
					}
				}
				else if (string_4 == "OnSpawn")
				{
					return 4;
				}
			}
			else if (num <= 3585102734U)
			{
				if (num <= 3106053110U)
				{
					if (num != 2888534544U)
					{
						if (num == 3106053110U)
						{
							if (string_4 == "OnEnterCollider")
							{
								return 18;
							}
						}
					}
					else if (string_4 == "OnPlayerJoined")
					{
						return 6;
					}
				}
				else if (num != 3203030114U)
				{
					if (num == 3585102734U)
					{
						if (string_4 == "OnAvatarHit")
						{
							return 23;
						}
					}
				}
				else if (string_4 == "Relay")
				{
					return 1;
				}
			}
			else if (num <= 3899234283U)
			{
				if (num != 3836056697U)
				{
					if (num == 3899234283U)
					{
						if (string_4 == "OnStationEntered")
						{
							return 24;
						}
					}
				}
				else if (string_4 == "OnDataStorageChange")
				{
					return 20;
				}
			}
			else if (num != 4253583187U)
			{
				if (num == 4253957729U)
				{
					if (string_4 == "OnVideoStart")
					{
						return 26;
					}
				}
			}
			else if (string_4 == "OnPickupUseDown")
			{
				return 8;
			}
			return 0;
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0007BD30 File Offset: 0x00079F30
		internal static byte[] smethod_1738(string string_4)
		{
			string currentDirectory = Environment.CurrentDirectory;
			if (GClass84.smethod_1428(string_4, GClass84.smethod_593(currentDirectory)) == currentDirectory)
			{
				string_4 = GClass84.smethod_1204(string_4, GClass84.smethod_593(currentDirectory), -1);
			}
			string_4 = GClass84.smethod_494(string_4, "/", ".", false);
			string_4 = GClass84.smethod_494(string_4, "\\", ".", false);
			while (GClass84.smethod_1428(string_4, 1) == ".")
			{
				string_4 = GClass84.smethod_1204(string_4, 1, -1);
			}
			string text = Assembly.GetCallingAssembly().GetName().Name + ".";
			if (GClass84.smethod_1428(string_4, GClass84.smethod_593(text)) != text)
			{
				string_4 = text + string_4;
			}
			foreach (string text2 in Assembly.GetExecutingAssembly().GetManifestResourceNames())
			{
				if (!(text2 != string_4))
				{
					byte[] result;
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2))
					{
						using (MemoryStream memoryStream = new MemoryStream((int)manifestResourceStream.Length))
						{
							manifestResourceStream.CopyTo(memoryStream);
							result = memoryStream.ToArray();
						}
					}
					return result;
				}
			}
			GClass70.smethod_36(string.Concat(new string[]
			{
				"[",
				"Error",
				"]",
				" ",
				"[",
				"Abyss",
				" ",
				"Client",
				"]",
				" ",
				"Can",
				"'",
				"t",
				" ",
				"find",
				" ",
				string_4
			}), GClass70.Enum1.const_0);
			return new byte[0];
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0005872C File Offset: 0x0005692C
		internal static void smethod_1739(Component component_0)
		{
			if (component_0)
			{
				Object.DestroyImmediate(component_0, true);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0007BF24 File Offset: 0x0007A124
		internal static void smethod_1740(Vector3 vector3_0, bool bool_10 = false)
		{
			GClass84.smethod_110(vector3_0, bool_10);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0007BF38 File Offset: 0x0007A138
		internal static bool smethod_1741(List<GameObject> list_51, GameObject gameObject_39, GClass84.GEnum47 genum47_0, bool bool_10 = false)
		{
			bool result;
			if (list_51 == null || !gameObject_39)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = list_51.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1681(list_51[i], gameObject_39, genum47_0, bool_10))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0007BF8C File Offset: 0x0007A18C
		internal static void smethod_1742(Player player_0)
		{
			player_0.smethod_1632(1f);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0007BFA4 File Offset: 0x0007A1A4
		internal static void smethod_1743(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_865(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		internal static VRCPlayerApi smethod_1744()
		{
			List<VRCPlayerApi> list = GClass84.smethod_1584();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].isMaster)
				{
					return list[i];
				}
			}
			return null;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0007C008 File Offset: 0x0007A208
		internal static string smethod_1745(Transform transform_0, GameObject gameObject_39)
		{
			return GClass84.smethod_149(transform_0, gameObject_39);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0007C01C File Offset: 0x0007A21C
		internal static void smethod_1746(List<GameObject> list_51, bool bool_10 = false)
		{
			GClass84.smethod_1363(list_51, bool_10);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0007C030 File Offset: 0x0007A230
		internal static void smethod_1747(GClass156 gclass156_1, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			GClass84.smethod_147(gclass156_1, int_1, int_2, int_3, int_4, int_5);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0007C050 File Offset: 0x0007A250
		internal static IEnumerator smethod_1748()
		{
			return new GClass84.Class120(0);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0007C064 File Offset: 0x0007A264
		internal static void smethod_1749(GClass52 gclass52_1)
		{
			GClass84.gclass52_0 = gclass52_1;
		}

		// Token: 0x04000C57 RID: 3159
		internal static GClass93 gclass93_0;

		// Token: 0x04000C58 RID: 3160
		internal static GClass161 gclass161_0;

		// Token: 0x04000C59 RID: 3161
		internal static GClass164 gclass164_0;

		// Token: 0x04000C5A RID: 3162
		internal static GClass166 gclass166_0;

		// Token: 0x04000C5B RID: 3163
		internal static GClass160 gclass160_0;

		// Token: 0x04000C5C RID: 3164
		internal static GClass143 gclass143_0;

		// Token: 0x04000C5D RID: 3165
		internal static GClass149 gclass149_0;

		// Token: 0x04000C5E RID: 3166
		internal static GClass168 gclass168_0;

		// Token: 0x04000C5F RID: 3167
		internal static GClass131 gclass131_0;

		// Token: 0x04000C60 RID: 3168
		internal static GClass145 gclass145_0;

		// Token: 0x04000C61 RID: 3169
		internal static GClass184 gclass184_0;

		// Token: 0x04000C62 RID: 3170
		internal static GClass135 gclass135_0;

		// Token: 0x04000C63 RID: 3171
		internal static GClass178 gclass178_0;

		// Token: 0x04000C64 RID: 3172
		internal static GClass181 gclass181_0;

		// Token: 0x04000C65 RID: 3173
		internal static GClass141 gclass141_0;

		// Token: 0x04000C66 RID: 3174
		internal static GClass155 gclass155_0;

		// Token: 0x04000C67 RID: 3175
		internal static GClass158 gclass158_0;

		// Token: 0x04000C68 RID: 3176
		internal static Class188 class188_0;

		// Token: 0x04000C69 RID: 3177
		internal static GClass146 gclass146_0;

		// Token: 0x04000C6A RID: 3178
		internal static GClass144 gclass144_0;

		// Token: 0x04000C6B RID: 3179
		internal static GClass132 gclass132_0;

		// Token: 0x04000C6C RID: 3180
		internal static GClass137 gclass137_0;

		// Token: 0x04000C6D RID: 3181
		internal static GClass136 gclass136_0;

		// Token: 0x04000C6E RID: 3182
		internal static GClass157 gclass157_0;

		// Token: 0x04000C6F RID: 3183
		internal static GClass140 gclass140_0;

		// Token: 0x04000C70 RID: 3184
		internal static GClass174 gclass174_0;

		// Token: 0x04000C71 RID: 3185
		internal static GClass179 gclass179_0;

		// Token: 0x04000C72 RID: 3186
		internal static GClass134 gclass134_0;

		// Token: 0x04000C73 RID: 3187
		internal static GClass185 gclass185_0;

		// Token: 0x04000C74 RID: 3188
		internal static GClass183 gclass183_0;

		// Token: 0x04000C75 RID: 3189
		internal static GClass147 gclass147_0;

		// Token: 0x04000C76 RID: 3190
		internal static GClass167 gclass167_0;

		// Token: 0x04000C77 RID: 3191
		internal static GClass177 gclass177_0;

		// Token: 0x04000C78 RID: 3192
		internal static GClass163 gclass163_0;

		// Token: 0x04000C79 RID: 3193
		internal static GClass182 gclass182_0;

		// Token: 0x04000C7A RID: 3194
		internal static GClass165 gclass165_0;

		// Token: 0x04000C7B RID: 3195
		internal static GClass117 gclass117_0;

		// Token: 0x04000C7C RID: 3196
		internal static GClass39 gclass39_0;

		// Token: 0x04000C7D RID: 3197
		internal static GClass48 gclass48_0;

		// Token: 0x04000C7E RID: 3198
		internal static GClass75 gclass75_0;

		// Token: 0x04000C7F RID: 3199
		internal static GClass180 gclass180_0;

		// Token: 0x04000C80 RID: 3200
		internal static GClass162 gclass162_0;

		// Token: 0x04000C81 RID: 3201
		internal static GClass56 gclass56_0;

		// Token: 0x04000C82 RID: 3202
		internal static GClass121 gclass121_0;

		// Token: 0x04000C83 RID: 3203
		internal static GClass153 gclass153_0;

		// Token: 0x04000C84 RID: 3204
		internal static GClass148 gclass148_0;

		// Token: 0x04000C85 RID: 3205
		internal static GClass152 gclass152_0;

		// Token: 0x04000C86 RID: 3206
		internal static GClass138 gclass138_0;

		// Token: 0x04000C87 RID: 3207
		internal static GClass150 gclass150_0;

		// Token: 0x04000C88 RID: 3208
		internal static GClass159 gclass159_0;

		// Token: 0x04000C89 RID: 3209
		internal static GClass133 gclass133_0;

		// Token: 0x04000C8A RID: 3210
		private static GClass52 gclass52_0;

		// Token: 0x04000C8B RID: 3211
		internal static StringBuilder stringBuilder_0;

		// Token: 0x04000C8C RID: 3212
		internal static GClass194 gclass194_0;

		// Token: 0x04000C8D RID: 3213
		internal static GClass156 gclass156_0;

		// Token: 0x04000C8E RID: 3214
		internal static List<Action> list_0 = new List<Action>();

		// Token: 0x04000C8F RID: 3215
		internal static List<Action<int>> list_1 = new List<Action<int>>();

		// Token: 0x04000C90 RID: 3216
		internal static List<Action<int>> list_2 = new List<Action<int>>();

		// Token: 0x04000C91 RID: 3217
		internal static List<Action> list_3 = new List<Action>();

		// Token: 0x04000C92 RID: 3218
		internal static List<Action> list_4 = new List<Action>();

		// Token: 0x04000C93 RID: 3219
		internal static List<Action> list_5 = new List<Action>();

		// Token: 0x04000C94 RID: 3220
		internal static List<Action> list_6 = new List<Action>();

		// Token: 0x04000C95 RID: 3221
		internal static List<Action> list_7 = new List<Action>();

		// Token: 0x04000C96 RID: 3222
		internal static List<Action> list_8 = new List<Action>();

		// Token: 0x04000C97 RID: 3223
		internal static List<Action> list_9 = new List<Action>();

		// Token: 0x04000C98 RID: 3224
		internal static List<Action> list_10 = new List<Action>();

		// Token: 0x04000C99 RID: 3225
		internal static List<Action> list_11 = new List<Action>();

		// Token: 0x04000C9A RID: 3226
		internal static List<Action> list_12 = new List<Action>();

		// Token: 0x04000C9B RID: 3227
		internal static List<Action> list_13 = new List<Action>();

		// Token: 0x04000C9C RID: 3228
		internal static List<Action> list_14 = new List<Action>();

		// Token: 0x04000C9D RID: 3229
		internal static List<Action<string, List<string>>> list_15 = new List<Action<string, List<string>>>();

		// Token: 0x04000C9E RID: 3230
		internal static List<Action<GameObject, GameObject>> list_16 = new List<Action<GameObject, GameObject>>();

		// Token: 0x04000C9F RID: 3231
		internal static List<Action<string, string>> list_17 = new List<Action<string, string>>();

		// Token: 0x04000CA0 RID: 3232
		internal static List<Action<string, string>> list_18 = new List<Action<string, string>>();

		// Token: 0x04000CA1 RID: 3233
		internal static List<Action<string, string>> list_19 = new List<Action<string, string>>();

		// Token: 0x04000CA2 RID: 3234
		internal static List<Action<string, string>> list_20 = new List<Action<string, string>>();

		// Token: 0x04000CA3 RID: 3235
		internal static List<Action<UdonBehaviour, string, Player>> list_21 = new List<Action<UdonBehaviour, string, Player>>();

		// Token: 0x04000CA4 RID: 3236
		internal static List<Action<UdonBehaviour, string, Player>> list_22 = new List<Action<UdonBehaviour, string, Player>>();

		// Token: 0x04000CA5 RID: 3237
		internal static List<Action<UdonBehaviour, NetworkEventTarget, string>> list_23 = new List<Action<UdonBehaviour, NetworkEventTarget, string>>();

		// Token: 0x04000CA6 RID: 3238
		internal static List<Action<UdonBehaviour, string>> list_24 = new List<Action<UdonBehaviour, string>>();

		// Token: 0x04000CA7 RID: 3239
		internal static List<Action<VRC_EventHandler.VrcEvent, VRC_EventHandler.VrcBroadcastType, int, float>> list_25 = new List<Action<VRC_EventHandler.VrcEvent, VRC_EventHandler.VrcBroadcastType, int, float>>();

		// Token: 0x04000CA8 RID: 3240
		internal static List<Action<int>> list_26 = new List<Action<int>>();

		// Token: 0x04000CA9 RID: 3241
		internal static List<Action<int>> list_27 = new List<Action<int>>();

		// Token: 0x04000CAA RID: 3242
		internal static List<Action> list_28 = new List<Action>();

		// Token: 0x04000CAB RID: 3243
		internal static List<Action> list_29 = new List<Action>();

		// Token: 0x04000CAC RID: 3244
		internal static List<Action> list_30 = new List<Action>();

		// Token: 0x04000CAD RID: 3245
		internal static List<Action> list_31 = new List<Action>();

		// Token: 0x04000CAE RID: 3246
		internal static List<Action<Object>> list_32 = new List<Action<Object>>();

		// Token: 0x04000CAF RID: 3247
		internal static List<Action<string, string, GameObject>> list_33 = new List<Action<string, string, GameObject>>();

		// Token: 0x04000CB0 RID: 3248
		internal static GClass106 gclass106_0 = new GClass106();

		// Token: 0x04000CB1 RID: 3249
		internal static Thread thread_0 = null;

		// Token: 0x04000CB2 RID: 3250
		internal static float float_0 = 0f;

		// Token: 0x04000CB3 RID: 3251
		internal static DateTime dateTime_0;

		// Token: 0x04000CB4 RID: 3252
		internal static bool bool_0 = false;

		// Token: 0x04000CB5 RID: 3253
		internal static bool bool_1 = false;

		// Token: 0x04000CB6 RID: 3254
		internal static float float_1 = 0f;

		// Token: 0x04000CB7 RID: 3255
		internal static bool bool_2 = false;

		// Token: 0x04000CB8 RID: 3256
		internal static bool bool_3 = false;

		// Token: 0x04000CB9 RID: 3257
		internal static float float_2 = 0f;

		// Token: 0x04000CBA RID: 3258
		internal static string string_0;

		// Token: 0x04000CBB RID: 3259
		internal static bool bool_4 = true;

		// Token: 0x04000CBC RID: 3260
		internal static bool bool_5 = false;

		// Token: 0x04000CBD RID: 3261
		internal static bool bool_6 = false;

		// Token: 0x04000CBE RID: 3262
		internal static char[] char_0 = "0123456789abcdef".ToArray<char>();

		// Token: 0x04000CBF RID: 3263
		internal static List<char> list_34 = "0123456789abcdef".ToList<char>();

		// Token: 0x04000CC0 RID: 3264
		private static Shader shader_0;

		// Token: 0x04000CC1 RID: 3265
		private static Shader shader_1;

		// Token: 0x04000CC2 RID: 3266
		internal static GameObject gameObject_0;

		// Token: 0x04000CC3 RID: 3267
		internal static GameObject gameObject_1;

		// Token: 0x04000CC4 RID: 3268
		internal static Text text_0;

		// Token: 0x04000CC5 RID: 3269
		internal static List<GClass84.GStruct174> list_35 = new List<GClass84.GStruct174>();

		// Token: 0x04000CC6 RID: 3270
		internal static bool bool_7 = false;

		// Token: 0x04000CC7 RID: 3271
		internal static List<GClass84.Struct16> list_36 = new List<GClass84.Struct16>
		{
			new GClass84.Struct16("wrld_5b89c79e-c340-4510-be1b-476e9fcdedcc", "Public Ban")
		};

		// Token: 0x04000CC8 RID: 3272
		internal static List<GClass84.Struct16> list_37 = new List<GClass84.Struct16>
		{
			new GClass84.Struct16("avtr_2052cc30-1e69-47ff-a82a-379004620b69", "TestSounds")
		};

		// Token: 0x04000CC9 RID: 3273
		internal static List<GClass84.Struct16> list_38 = new List<GClass84.Struct16>
		{
			new GClass84.Struct16("avtr_de8dfb36-6986-4946-a8d0-98d9552b331f", "Kawam noTwog")
		};

		// Token: 0x04000CCA RID: 3274
		internal static List<GClass84.Struct16> list_39 = new List<GClass84.Struct16>
		{
			new GClass84.Struct16("avtr_c52d4cbb-3945-417b-b41d-ebd7fe3b922c", "Primasaur")
		};

		// Token: 0x04000CCB RID: 3275
		private static IntPtr intptr_0;

		// Token: 0x04000CCC RID: 3276
		private static GClass84.Delegate30 delegate30_0;

		// Token: 0x04000CCD RID: 3277
		private static GClass84.Delegate31 delegate31_0;

		// Token: 0x04000CCE RID: 3278
		private static int int_0 = 0;

		// Token: 0x04000CCF RID: 3279
		internal static readonly ConcurrentQueue<GClass84.Class99> concurrentQueue_0 = new ConcurrentQueue<GClass84.Class99>();

		// Token: 0x04000CD0 RID: 3280
		private static GameObject gameObject_2 = null;

		// Token: 0x04000CD1 RID: 3281
		private static GameObject gameObject_3 = null;

		// Token: 0x04000CD2 RID: 3282
		private static GameObject gameObject_4 = null;

		// Token: 0x04000CD3 RID: 3283
		private static GameObject gameObject_5 = null;

		// Token: 0x04000CD4 RID: 3284
		private static GameObject gameObject_6 = null;

		// Token: 0x04000CD5 RID: 3285
		private static GameObject gameObject_7 = null;

		// Token: 0x04000CD6 RID: 3286
		private static GameObject gameObject_8 = null;

		// Token: 0x04000CD7 RID: 3287
		private static GameObject gameObject_9 = null;

		// Token: 0x04000CD8 RID: 3288
		private static GameObject gameObject_10 = null;

		// Token: 0x04000CD9 RID: 3289
		private static GameObject gameObject_11 = null;

		// Token: 0x04000CDA RID: 3290
		private static GameObject gameObject_12 = null;

		// Token: 0x04000CDB RID: 3291
		private static GameObject gameObject_13 = null;

		// Token: 0x04000CDC RID: 3292
		private static GameObject gameObject_14 = null;

		// Token: 0x04000CDD RID: 3293
		private static GameObject gameObject_15 = null;

		// Token: 0x04000CDE RID: 3294
		private static GameObject gameObject_16 = null;

		// Token: 0x04000CDF RID: 3295
		private static GameObject gameObject_17 = null;

		// Token: 0x04000CE0 RID: 3296
		private static GameObject gameObject_18 = null;

		// Token: 0x04000CE1 RID: 3297
		private static GameObject gameObject_19 = null;

		// Token: 0x04000CE2 RID: 3298
		private static GameObject gameObject_20 = null;

		// Token: 0x04000CE3 RID: 3299
		private static GameObject gameObject_21 = null;

		// Token: 0x04000CE4 RID: 3300
		private static GameObject gameObject_22 = null;

		// Token: 0x04000CE5 RID: 3301
		private static GameObject gameObject_23 = null;

		// Token: 0x04000CE6 RID: 3302
		private static GameObject gameObject_24 = null;

		// Token: 0x04000CE7 RID: 3303
		private static GameObject gameObject_25 = null;

		// Token: 0x04000CE8 RID: 3304
		private static GameObject gameObject_26 = null;

		// Token: 0x04000CE9 RID: 3305
		private static GameObject gameObject_27 = null;

		// Token: 0x04000CEA RID: 3306
		private static GameObject gameObject_28 = null;

		// Token: 0x04000CEB RID: 3307
		private static GameObject gameObject_29 = null;

		// Token: 0x04000CEC RID: 3308
		private static GameObject gameObject_30 = null;

		// Token: 0x04000CED RID: 3309
		private static GameObject gameObject_31 = null;

		// Token: 0x04000CEE RID: 3310
		private static GameObject gameObject_32 = null;

		// Token: 0x04000CEF RID: 3311
		private static GameObject gameObject_33 = null;

		// Token: 0x04000CF0 RID: 3312
		private static GameObject gameObject_34 = null;

		// Token: 0x04000CF1 RID: 3313
		private static GameObject gameObject_35 = null;

		// Token: 0x04000CF2 RID: 3314
		private static GameObject gameObject_36 = null;

		// Token: 0x04000CF3 RID: 3315
		private static GameObject gameObject_37 = null;

		// Token: 0x04000CF4 RID: 3316
		private static MethodInfo methodInfo_0;

		// Token: 0x04000CF5 RID: 3317
		private static MethodInfo methodInfo_1;

		// Token: 0x04000CF6 RID: 3318
		private static MethodInfo methodInfo_2;

		// Token: 0x04000CF7 RID: 3319
		internal static GClass84.Class100 class100_0 = new GClass84.Class100();

		// Token: 0x04000CF8 RID: 3320
		private static VRC_EventHandler vrc_EventHandler_0;

		// Token: 0x04000CF9 RID: 3321
		private static List<string> list_40 = new List<string>();

		// Token: 0x04000CFA RID: 3322
		internal static bool bool_8 = false;

		// Token: 0x04000CFB RID: 3323
		private static List<string> list_41 = new List<string>();

		// Token: 0x04000CFC RID: 3324
		private static List<object> list_42 = new List<object>();

		// Token: 0x04000CFD RID: 3325
		private static MethodInfo methodInfo_3;

		// Token: 0x04000CFE RID: 3326
		private static List<object> list_43 = new List<object>();

		// Token: 0x04000CFF RID: 3327
		private static string string_1 = string.Empty;

		// Token: 0x04000D00 RID: 3328
		private static GClass84.Delegate32 delegate32_0;

		// Token: 0x04000D01 RID: 3329
		private static MethodInfo methodInfo_4 = null;

		// Token: 0x04000D02 RID: 3330
		private static Material material_0;

		// Token: 0x04000D03 RID: 3331
		private static HashSet<string> hashSet_0 = new HashSet<string>();

		// Token: 0x04000D04 RID: 3332
		internal static readonly string[] string_2 = new string[]
		{
			"System",
			"System.Linq",
			"System.Text",
			"System.Collections.Generic",
			"UnityEngine"
		};

		// Token: 0x04000D05 RID: 3333
		private static List<object> list_44 = new List<object>();

		// Token: 0x04000D06 RID: 3334
		private static List<object> list_45 = new List<object>();

		// Token: 0x04000D07 RID: 3335
		private static List<object> list_46 = new List<object>();

		// Token: 0x04000D08 RID: 3336
		private static List<object> list_47 = new List<object>();

		// Token: 0x04000D09 RID: 3337
		private static List<object> list_48 = new List<object>();

		// Token: 0x04000D0A RID: 3338
		private static List<object> list_49 = new List<object>();

		// Token: 0x04000D0B RID: 3339
		private static List<object> list_50 = new List<object>();

		// Token: 0x04000D0C RID: 3340
		internal static GameObject gameObject_38 = null;

		// Token: 0x04000D0D RID: 3341
		internal static HighlightsFXStandalone highlightsFXStandalone_0 = null;

		// Token: 0x04000D0E RID: 3342
		internal static bool bool_9 = false;

		// Token: 0x04000D0F RID: 3343
		private const string string_3 = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall";

		// Token: 0x020001C1 RID: 449
		internal static class Class98
		{
		}

		// Token: 0x020001C2 RID: 450
		public static class GClass85
		{
			// Token: 0x060017B7 RID: 6071 RVA: 0x0007C078 File Offset: 0x0007A278
			public static void smethod_0()
			{
				GClass84.GClass85.list_0 = null;
				GClass84.GClass85.list_1 = null;
				GClass84.GClass85.string_0 = null;
				GClass84.GClass85.list_2 = null;
				GClass84.GClass85.list_3 = null;
				GClass84.GClass85.int_0 = 0;
				GClass84.GClass85.list_4 = null;
				GClass84.GClass85.list_5 = null;
				GClass84.GClass85.float_0 = 0f;
				GClass84.GClass85.list_6 = null;
				GClass84.GClass85.list_7 = null;
				GClass84.GClass85.byte_0 = 0;
				GClass84.GClass85.list_8 = null;
				GClass84.GClass85.list_9 = null;
				GClass84.GClass85.bool_0 = false;
				GClass84.GClass85.list_10 = null;
				GClass84.GClass85.list_11 = null;
				GClass84.GClass85.object_0 = null;
				GClass84.GClass85.list_12 = null;
				GClass84.GClass85.list_13 = null;
				GClass84.GClass85.gstruct139_0 = default(GClass84.GStruct139);
				GClass84.GClass85.list_14 = null;
				GClass84.GClass85.list_15 = null;
				GClass84.GClass85.vector3_0 = default(Vector3);
			}

			// Token: 0x04000D10 RID: 3344
			public static List<List<string>> list_0 = null;

			// Token: 0x04000D11 RID: 3345
			public static List<string> list_1 = null;

			// Token: 0x04000D12 RID: 3346
			public static string string_0 = null;

			// Token: 0x04000D13 RID: 3347
			public static List<List<int>> list_2 = null;

			// Token: 0x04000D14 RID: 3348
			public static List<int> list_3 = null;

			// Token: 0x04000D15 RID: 3349
			public static int int_0 = 0;

			// Token: 0x04000D16 RID: 3350
			public static List<List<float>> list_4 = null;

			// Token: 0x04000D17 RID: 3351
			public static List<float> list_5 = null;

			// Token: 0x04000D18 RID: 3352
			public static float float_0 = 0f;

			// Token: 0x04000D19 RID: 3353
			public static List<List<byte>> list_6 = null;

			// Token: 0x04000D1A RID: 3354
			public static List<byte> list_7 = null;

			// Token: 0x04000D1B RID: 3355
			public static byte byte_0 = 0;

			// Token: 0x04000D1C RID: 3356
			public static List<List<bool>> list_8 = null;

			// Token: 0x04000D1D RID: 3357
			public static List<bool> list_9 = null;

			// Token: 0x04000D1E RID: 3358
			public static bool bool_0 = false;

			// Token: 0x04000D1F RID: 3359
			public static List<List<object>> list_10 = null;

			// Token: 0x04000D20 RID: 3360
			public static List<object> list_11 = null;

			// Token: 0x04000D21 RID: 3361
			public static object object_0 = null;

			// Token: 0x04000D22 RID: 3362
			public static List<List<GClass84.GStruct139>> list_12 = null;

			// Token: 0x04000D23 RID: 3363
			public static List<GClass84.GStruct139> list_13 = null;

			// Token: 0x04000D24 RID: 3364
			public static GClass84.GStruct139 gstruct139_0 = default(GClass84.GStruct139);

			// Token: 0x04000D25 RID: 3365
			public static List<List<Vector3>> list_14 = null;

			// Token: 0x04000D26 RID: 3366
			public static List<Vector3> list_15 = null;

			// Token: 0x04000D27 RID: 3367
			public static Vector3 vector3_0 = default(Vector3);
		}

		// Token: 0x020001C3 RID: 451
		public struct GStruct131
		{
			// Token: 0x060017B8 RID: 6072 RVA: 0x0007C124 File Offset: 0x0007A324
			public static List<GClass84.GStruct131> smethod_0(List<GClass84.GStruct131> list_1, string string_1, string string_2)
			{
				for (int i = 0; i < list_1.Count; i++)
				{
					GClass84.GStruct131 gstruct = list_1[i];
					if (gstruct.string_0 == string_1)
					{
						gstruct.list_0.Add(string_2);
						list_1[i] = gstruct;
						IL_3F:
						if (i >= list_1.Count)
						{
							list_1.Add(new GClass84.GStruct131(string_1, string_2));
						}
						return list_1;
					}
				}
				goto IL_3F;
			}

			// Token: 0x060017B9 RID: 6073 RVA: 0x0007C190 File Offset: 0x0007A390
			public GStruct131(string string_1, List<string> list_1)
			{
				this.string_0 = string_1;
				this.list_0 = new List<string>();
				this.list_0.AddRange(list_1);
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x0007C1BC File Offset: 0x0007A3BC
			public GStruct131(string string_1, string string_2)
			{
				this.string_0 = string_1;
				this.list_0 = new List<string>
				{
					string_2
				};
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x0007C1E4 File Offset: 0x0007A3E4
			public static List<GClass84.GStruct131> smethod_1(List<GClass84.GStruct131> list_1, string string_1, List<string> list_2)
			{
				for (int i = 0; i < list_1.Count; i++)
				{
					GClass84.GStruct131 gstruct = list_1[i];
					if (gstruct.string_0 == string_1)
					{
						gstruct.list_0.AddRange(list_2);
						list_1[i] = gstruct;
						IL_3F:
						if (i >= list_1.Count)
						{
							list_1.Add(new GClass84.GStruct131(string_1, list_2));
						}
						return list_1;
					}
				}
				goto IL_3F;
			}

			// Token: 0x060017BC RID: 6076 RVA: 0x0007C250 File Offset: 0x0007A450
			public static List<GClass84.GStruct131> smethod_2(List<GClass84.GStruct131> list_1, GClass84.GStruct131 gstruct131_0)
			{
				return GClass84.GStruct131.smethod_1(list_1, gstruct131_0.string_0, gstruct131_0.list_0);
			}

			// Token: 0x04000D28 RID: 3368
			public string string_0;

			// Token: 0x04000D29 RID: 3369
			public List<string> list_0;
		}

		// Token: 0x020001C4 RID: 452
		public struct GStruct132
		{
			// Token: 0x060017BD RID: 6077 RVA: 0x0007C274 File Offset: 0x0007A474
			public GStruct132(int int_2, int int_3)
			{
				this.int_0 = int_2;
				this.int_1 = int_3;
			}

			// Token: 0x04000D2A RID: 3370
			public int int_0;

			// Token: 0x04000D2B RID: 3371
			public int int_1;
		}

		// Token: 0x020001C5 RID: 453
		public struct GStruct133
		{
			// Token: 0x060017BE RID: 6078 RVA: 0x0007C290 File Offset: 0x0007A490
			public GStruct133(int int_1, float float_1)
			{
				this.int_0 = int_1;
				this.float_0 = float_1;
			}

			// Token: 0x04000D2C RID: 3372
			public int int_0;

			// Token: 0x04000D2D RID: 3373
			public float float_0;
		}

		// Token: 0x020001C6 RID: 454
		public struct GStruct134
		{
			// Token: 0x060017BF RID: 6079 RVA: 0x0007C2AC File Offset: 0x0007A4AC
			public GStruct134(string string_1, int int_1)
			{
				this.string_0 = string_1;
				this.int_0 = int_1;
			}

			// Token: 0x060017C0 RID: 6080 RVA: 0x0007C2C8 File Offset: 0x0007A4C8
			public GStruct134(string string_1)
			{
				this.string_0 = string_1;
				this.int_0 = 0;
			}

			// Token: 0x04000D2E RID: 3374
			public string string_0;

			// Token: 0x04000D2F RID: 3375
			public int int_0;
		}

		// Token: 0x020001C7 RID: 455
		public struct GStruct135
		{
			// Token: 0x060017C1 RID: 6081 RVA: 0x0007C2E4 File Offset: 0x0007A4E4
			public GStruct135(string string_1)
			{
				this.string_0 = string_1;
				this.float_0 = 0f;
			}

			// Token: 0x060017C2 RID: 6082 RVA: 0x0007C304 File Offset: 0x0007A504
			public GStruct135(string string_1, float float_1)
			{
				this.string_0 = string_1;
				this.float_0 = float_1;
			}

			// Token: 0x04000D30 RID: 3376
			public string string_0;

			// Token: 0x04000D31 RID: 3377
			public float float_0;
		}

		// Token: 0x020001C8 RID: 456
		public struct GStruct136
		{
			// Token: 0x060017C3 RID: 6083 RVA: 0x0007C320 File Offset: 0x0007A520
			public GStruct136(string string_1, bool bool_1)
			{
				this.string_0 = string_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x060017C4 RID: 6084 RVA: 0x0007C33C File Offset: 0x0007A53C
			public GStruct136(string string_1)
			{
				this.string_0 = string_1;
				this.bool_0 = false;
			}

			// Token: 0x04000D32 RID: 3378
			public string string_0;

			// Token: 0x04000D33 RID: 3379
			public bool bool_0;
		}

		// Token: 0x020001C9 RID: 457
		public struct GStruct137
		{
			// Token: 0x060017C5 RID: 6085 RVA: 0x0007C358 File Offset: 0x0007A558
			public GStruct137(string string_1, object object_1)
			{
				this.string_0 = string_1;
				this.object_0 = object_1;
			}

			// Token: 0x04000D34 RID: 3380
			public string string_0;

			// Token: 0x04000D35 RID: 3381
			public object object_0;
		}

		// Token: 0x020001CA RID: 458
		public struct GStruct138
		{
			// Token: 0x060017C6 RID: 6086 RVA: 0x0007C374 File Offset: 0x0007A574
			public GStruct138(string string_1, Mesh mesh_1)
			{
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
			}

			// Token: 0x04000D36 RID: 3382
			public string string_0;

			// Token: 0x04000D37 RID: 3383
			public Mesh mesh_0;
		}

		// Token: 0x020001CB RID: 459
		public struct GStruct139
		{
			// Token: 0x060017C7 RID: 6087 RVA: 0x0007C390 File Offset: 0x0007A590
			public GStruct139(object object_2, object object_3)
			{
				this.object_0 = object_2;
				this.object_1 = object_3;
			}

			// Token: 0x04000D38 RID: 3384
			public object object_0;

			// Token: 0x04000D39 RID: 3385
			public object object_1;
		}

		// Token: 0x020001CC RID: 460
		public struct GStruct140
		{
			// Token: 0x060017C8 RID: 6088 RVA: 0x0007C3AC File Offset: 0x0007A5AC
			public GStruct140(Transform transform_1, string string_1, Mesh mesh_1)
			{
				this.transform_0 = transform_1;
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
			}

			// Token: 0x04000D3A RID: 3386
			public Transform transform_0;

			// Token: 0x04000D3B RID: 3387
			public string string_0;

			// Token: 0x04000D3C RID: 3388
			public Mesh mesh_0;
		}

		// Token: 0x020001CD RID: 461
		public struct GStruct141
		{
			// Token: 0x060017C9 RID: 6089 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
			public GStruct141(Transform transform_1, string string_1, Mesh mesh_1, bool bool_1)
			{
				this.transform_0 = transform_1;
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x04000D3D RID: 3389
			public Transform transform_0;

			// Token: 0x04000D3E RID: 3390
			public string string_0;

			// Token: 0x04000D3F RID: 3391
			public Mesh mesh_0;

			// Token: 0x04000D40 RID: 3392
			public bool bool_0;
		}

		// Token: 0x020001CE RID: 462
		public struct GStruct142
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x0007C3FC File Offset: 0x0007A5FC
			public GStruct142(Transform transform_1, string string_1, Mesh mesh_1, bool bool_1, int int_1)
			{
				this.transform_0 = transform_1;
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_1;
				this.int_0 = int_1;
			}

			// Token: 0x04000D41 RID: 3393
			public Transform transform_0;

			// Token: 0x04000D42 RID: 3394
			public string string_0;

			// Token: 0x04000D43 RID: 3395
			public Mesh mesh_0;

			// Token: 0x04000D44 RID: 3396
			public bool bool_0;

			// Token: 0x04000D45 RID: 3397
			public int int_0;
		}

		// Token: 0x020001CF RID: 463
		public struct GStruct143
		{
			// Token: 0x060017CB RID: 6091 RVA: 0x0007C430 File Offset: 0x0007A630
			public GStruct143(string string_1, Mesh mesh_1, bool bool_1, int int_1)
			{
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_1;
				this.int_0 = int_1;
			}

			// Token: 0x04000D46 RID: 3398
			public string string_0;

			// Token: 0x04000D47 RID: 3399
			public Mesh mesh_0;

			// Token: 0x04000D48 RID: 3400
			public bool bool_0;

			// Token: 0x04000D49 RID: 3401
			public int int_0;
		}

		// Token: 0x020001D0 RID: 464
		public struct GStruct144
		{
			// Token: 0x060017CC RID: 6092 RVA: 0x0007C45C File Offset: 0x0007A65C
			public GStruct144(string string_1, Mesh mesh_1, bool bool_2, bool bool_3, int int_1)
			{
				this.string_0 = string_1;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_2;
				this.bool_1 = bool_3;
				this.int_0 = int_1;
			}

			// Token: 0x04000D4A RID: 3402
			public string string_0;

			// Token: 0x04000D4B RID: 3403
			public Mesh mesh_0;

			// Token: 0x04000D4C RID: 3404
			public bool bool_0;

			// Token: 0x04000D4D RID: 3405
			public bool bool_1;

			// Token: 0x04000D4E RID: 3406
			public int int_0;
		}

		// Token: 0x020001D1 RID: 465
		public struct GStruct145
		{
			// Token: 0x060017CD RID: 6093 RVA: 0x0007C490 File Offset: 0x0007A690
			public GStruct145(string string_2, string string_3, Mesh mesh_1, bool bool_2, bool bool_3, int int_1)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_2;
				this.bool_1 = bool_3;
				this.int_0 = int_1;
			}

			// Token: 0x04000D4F RID: 3407
			public string string_0;

			// Token: 0x04000D50 RID: 3408
			public string string_1;

			// Token: 0x04000D51 RID: 3409
			public Mesh mesh_0;

			// Token: 0x04000D52 RID: 3410
			public bool bool_0;

			// Token: 0x04000D53 RID: 3411
			public bool bool_1;

			// Token: 0x04000D54 RID: 3412
			public int int_0;
		}

		// Token: 0x020001D2 RID: 466
		public struct GStruct146
		{
			// Token: 0x060017CE RID: 6094 RVA: 0x0007C4CC File Offset: 0x0007A6CC
			public GStruct146(string string_2, string string_3, Mesh mesh_1, bool bool_3, bool bool_4, bool bool_5, int int_1)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.mesh_0 = mesh_1;
				this.bool_0 = bool_3;
				this.bool_1 = bool_4;
				this.bool_2 = bool_5;
				this.int_0 = int_1;
			}

			// Token: 0x04000D55 RID: 3413
			public string string_0;

			// Token: 0x04000D56 RID: 3414
			public string string_1;

			// Token: 0x04000D57 RID: 3415
			public Mesh mesh_0;

			// Token: 0x04000D58 RID: 3416
			public bool bool_0;

			// Token: 0x04000D59 RID: 3417
			public bool bool_1;

			// Token: 0x04000D5A RID: 3418
			public bool bool_2;

			// Token: 0x04000D5B RID: 3419
			public int int_0;
		}

		// Token: 0x020001D3 RID: 467
		public struct GStruct147
		{
			// Token: 0x060017CF RID: 6095 RVA: 0x0007C510 File Offset: 0x0007A710
			public GStruct147(Transform transform_1, GClass84.GStruct143 gstruct143_0)
			{
				this.transform_0 = transform_1;
				this.list_0 = new List<GClass84.GStruct143>
				{
					gstruct143_0
				};
			}

			// Token: 0x060017D0 RID: 6096 RVA: 0x0007C538 File Offset: 0x0007A738
			public GStruct147(Transform transform_1, List<GClass84.GStruct143> list_1)
			{
				this.transform_0 = transform_1;
				this.list_0 = list_1;
			}

			// Token: 0x060017D1 RID: 6097 RVA: 0x0007C554 File Offset: 0x0007A754
			public void method_0(List<GClass84.GStruct143> list_1)
			{
				this.list_0.AddRange(list_1);
			}

			// Token: 0x060017D2 RID: 6098 RVA: 0x0007C570 File Offset: 0x0007A770
			public void method_1(GClass84.GStruct143 gstruct143_0)
			{
				this.list_0.Add(gstruct143_0);
			}

			// Token: 0x04000D5C RID: 3420
			public Transform transform_0;

			// Token: 0x04000D5D RID: 3421
			public List<GClass84.GStruct143> list_0;
		}

		// Token: 0x020001D4 RID: 468
		public struct GStruct148
		{
			// Token: 0x060017D3 RID: 6099 RVA: 0x0007C58C File Offset: 0x0007A78C
			public GStruct148(Vector2 vector2_1, bool bool_1)
			{
				this.vector2_0 = vector2_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x060017D4 RID: 6100 RVA: 0x0007C5A8 File Offset: 0x0007A7A8
			public GStruct148(Vector2 vector2_1)
			{
				this.vector2_0 = vector2_1;
				this.bool_0 = false;
			}

			// Token: 0x04000D5E RID: 3422
			internal Vector2 vector2_0;

			// Token: 0x04000D5F RID: 3423
			internal bool bool_0;
		}

		// Token: 0x020001D5 RID: 469
		public struct GStruct149
		{
			// Token: 0x060017D5 RID: 6101 RVA: 0x0007C5C4 File Offset: 0x0007A7C4
			public GStruct149(Vector3 vector3_1, bool bool_1)
			{
				this.vector3_0 = vector3_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x060017D6 RID: 6102 RVA: 0x0007C5E0 File Offset: 0x0007A7E0
			public GStruct149(Vector3 vector3_1)
			{
				this.vector3_0 = vector3_1;
				this.bool_0 = false;
			}

			// Token: 0x04000D60 RID: 3424
			public Vector3 vector3_0;

			// Token: 0x04000D61 RID: 3425
			public bool bool_0;
		}

		// Token: 0x020001D6 RID: 470
		public struct GStruct150
		{
			// Token: 0x060017D7 RID: 6103 RVA: 0x0007C5FC File Offset: 0x0007A7FC
			public GStruct150(Vector4 vector4_1, bool bool_1)
			{
				this.vector4_0 = vector4_1;
				this.bool_0 = bool_1;
			}

			// Token: 0x060017D8 RID: 6104 RVA: 0x0007C618 File Offset: 0x0007A818
			public GStruct150(Vector4 vector4_1)
			{
				this.vector4_0 = vector4_1;
				this.bool_0 = false;
			}

			// Token: 0x04000D62 RID: 3426
			public Vector4 vector4_0;

			// Token: 0x04000D63 RID: 3427
			public bool bool_0;
		}

		// Token: 0x020001D7 RID: 471
		public struct GStruct151
		{
			// Token: 0x060017D9 RID: 6105 RVA: 0x0007C634 File Offset: 0x0007A834
			public GStruct151(int int_1, VRCPlayerApi vrcplayerApi_1)
			{
				this.int_0 = int_1;
				this.vrcplayerApi_0 = vrcplayerApi_1;
			}

			// Token: 0x04000D64 RID: 3428
			public int int_0;

			// Token: 0x04000D65 RID: 3429
			public VRCPlayerApi vrcplayerApi_0;
		}

		// Token: 0x020001D8 RID: 472
		public struct GStruct152
		{
			// Token: 0x060017DA RID: 6106 RVA: 0x0007C650 File Offset: 0x0007A850
			public GStruct152(string string_1, VRCPlayerApi vrcplayerApi_1)
			{
				this.string_0 = string_1;
				this.vrcplayerApi_0 = vrcplayerApi_1;
			}

			// Token: 0x04000D66 RID: 3430
			public string string_0;

			// Token: 0x04000D67 RID: 3431
			public VRCPlayerApi vrcplayerApi_0;
		}

		// Token: 0x020001D9 RID: 473
		public struct GStruct153
		{
			// Token: 0x060017DB RID: 6107 RVA: 0x0007C66C File Offset: 0x0007A86C
			public GStruct153(string string_2, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
			}

			// Token: 0x04000D68 RID: 3432
			public string string_0;

			// Token: 0x04000D69 RID: 3433
			public string string_1;
		}

		// Token: 0x020001DA RID: 474
		public struct GStruct154
		{
			// Token: 0x060017DC RID: 6108 RVA: 0x0007C688 File Offset: 0x0007A888
			public GStruct154(string string_2, string string_3, int int_1)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.int_0 = int_1;
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x0007C6AC File Offset: 0x0007A8AC
			public GStruct154(string string_2, int int_1, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.int_0 = int_1;
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x0007C6D0 File Offset: 0x0007A8D0
			public GStruct154(int int_1, string string_2, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.int_0 = int_1;
			}

			// Token: 0x04000D6A RID: 3434
			public string string_0;

			// Token: 0x04000D6B RID: 3435
			public string string_1;

			// Token: 0x04000D6C RID: 3436
			public int int_0;
		}

		// Token: 0x020001DB RID: 475
		public struct GStruct155
		{
			// Token: 0x060017DF RID: 6111 RVA: 0x0007C6F4 File Offset: 0x0007A8F4
			public GStruct155(Text text_2, Text text_3)
			{
				this.text_0 = text_2;
				this.text_1 = text_3;
			}

			// Token: 0x04000D6D RID: 3437
			public Text text_0;

			// Token: 0x04000D6E RID: 3438
			public Text text_1;
		}

		// Token: 0x020001DC RID: 476
		public struct GStruct156
		{
			// Token: 0x060017E0 RID: 6112 RVA: 0x0007C710 File Offset: 0x0007A910
			public GStruct156(GameObject gameObject_2, GameObject gameObject_3)
			{
				this.gameObject_0 = gameObject_2;
				this.gameObject_1 = gameObject_3;
			}

			// Token: 0x04000D6F RID: 3439
			public GameObject gameObject_0;

			// Token: 0x04000D70 RID: 3440
			public GameObject gameObject_1;
		}

		// Token: 0x020001DD RID: 477
		public struct GStruct157
		{
			// Token: 0x060017E1 RID: 6113 RVA: 0x0007C72C File Offset: 0x0007A92C
			public GStruct157(GameObject gameObject_1, Vector2 vector2_1)
			{
				this.gameObject_0 = gameObject_1;
				this.vector2_0 = vector2_1;
			}

			// Token: 0x04000D71 RID: 3441
			public GameObject gameObject_0;

			// Token: 0x04000D72 RID: 3442
			public Vector2 vector2_0;
		}

		// Token: 0x020001DE RID: 478
		public struct GStruct158
		{
			// Token: 0x060017E2 RID: 6114 RVA: 0x0007C748 File Offset: 0x0007A948
			public GStruct158(GameObject gameObject_1, Vector3 vector3_1)
			{
				this.gameObject_0 = gameObject_1;
				this.vector3_0 = vector3_1;
			}

			// Token: 0x04000D73 RID: 3443
			public GameObject gameObject_0;

			// Token: 0x04000D74 RID: 3444
			public Vector3 vector3_0;
		}

		// Token: 0x020001DF RID: 479
		public struct GStruct159
		{
			// Token: 0x060017E3 RID: 6115 RVA: 0x0007C764 File Offset: 0x0007A964
			public GStruct159(Transform transform_2, Transform transform_3)
			{
				this.transform_0 = transform_2;
				this.transform_1 = transform_3;
			}

			// Token: 0x04000D75 RID: 3445
			public Transform transform_0;

			// Token: 0x04000D76 RID: 3446
			public Transform transform_1;
		}

		// Token: 0x020001E0 RID: 480
		public struct GStruct160
		{
			// Token: 0x060017E4 RID: 6116 RVA: 0x0007C780 File Offset: 0x0007A980
			public GStruct160(Color color_0)
			{
				this.list_0 = new List<Color>
				{
					color_0
				};
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
			public GStruct160(List<Color> list_1)
			{
				this.list_0 = list_1;
			}

			// Token: 0x04000D77 RID: 3447
			public List<Color> list_0;
		}

		// Token: 0x020001E1 RID: 481
		public struct GStruct161
		{
			// Token: 0x060017E6 RID: 6118 RVA: 0x0007C7B4 File Offset: 0x0007A9B4
			public GStruct161(GClass84.GStruct160 gstruct160_0)
			{
				this.list_0 = new List<GClass84.GStruct160>
				{
					gstruct160_0
				};
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x0007C7D4 File Offset: 0x0007A9D4
			public GStruct161(List<GClass84.GStruct160> list_1)
			{
				this.list_0 = list_1;
			}

			// Token: 0x04000D78 RID: 3448
			public List<GClass84.GStruct160> list_0;
		}

		// Token: 0x020001E2 RID: 482
		public struct GStruct162
		{
			// Token: 0x060017E8 RID: 6120 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
			public GStruct162(GClass84.GStruct161 gstruct161_0)
			{
				this.list_0 = new List<GClass84.GStruct161>
				{
					gstruct161_0
				};
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x0007C808 File Offset: 0x0007AA08
			public GStruct162(List<GClass84.GStruct161> list_1)
			{
				this.list_0 = list_1;
			}

			// Token: 0x04000D79 RID: 3449
			public List<GClass84.GStruct161> list_0;
		}

		// Token: 0x020001E3 RID: 483
		public struct GStruct163
		{
			// Token: 0x060017EA RID: 6122 RVA: 0x0007C81C File Offset: 0x0007AA1C
			public static bool smethod_0(GClass84.GStruct163 gstruct163_0, GClass84.GStruct163 gstruct163_1)
			{
				return gstruct163_0.int_0 == gstruct163_1.int_0 && gstruct163_0.int_1 == gstruct163_1.int_1;
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x0007C854 File Offset: 0x0007AA54
			public GStruct163(int int_2, int int_3)
			{
				this.int_0 = int_2;
				this.int_1 = int_3;
			}

			// Token: 0x060017EC RID: 6124 RVA: 0x0007C870 File Offset: 0x0007AA70
			public static bool smethod_1(GClass84.GStruct163 gstruct163_0, GClass84.GStruct163 gstruct163_1)
			{
				return gstruct163_0.int_0 != gstruct163_1.int_0 || gstruct163_0.int_1 != gstruct163_1.int_1;
			}

			// Token: 0x04000D7A RID: 3450
			public int int_0;

			// Token: 0x04000D7B RID: 3451
			public int int_1;
		}

		// Token: 0x020001E4 RID: 484
		public struct GStruct164
		{
			// Token: 0x060017ED RID: 6125 RVA: 0x0007C8A8 File Offset: 0x0007AAA8
			public GStruct164(int int_3, int int_4, int int_5)
			{
				this.int_0 = int_3;
				this.int_1 = int_4;
				this.int_2 = int_5;
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x0007C8CC File Offset: 0x0007AACC
			public static bool smethod_0(GClass84.GStruct164 gstruct164_0, GClass84.GStruct164 gstruct164_1)
			{
				return gstruct164_0.int_0 == gstruct164_1.int_0 && gstruct164_0.int_1 == gstruct164_1.int_1 && gstruct164_0.int_2 == gstruct164_1.int_2;
			}

			// Token: 0x060017EF RID: 6127 RVA: 0x0007C910 File Offset: 0x0007AB10
			public static bool smethod_1(GClass84.GStruct164 gstruct164_0, GClass84.GStruct164 gstruct164_1)
			{
				return gstruct164_0.int_0 != gstruct164_1.int_0 || gstruct164_0.int_1 != gstruct164_1.int_1 || gstruct164_0.int_2 != gstruct164_1.int_2;
			}

			// Token: 0x04000D7C RID: 3452
			public int int_0;

			// Token: 0x04000D7D RID: 3453
			public int int_1;

			// Token: 0x04000D7E RID: 3454
			public int int_2;
		}

		// Token: 0x020001E5 RID: 485
		public struct GStruct165
		{
			// Token: 0x060017F0 RID: 6128 RVA: 0x0007C954 File Offset: 0x0007AB54
			public GStruct165(int int_4, int int_5, int int_6, int int_7)
			{
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
			}

			// Token: 0x060017F1 RID: 6129 RVA: 0x0007C980 File Offset: 0x0007AB80
			public static bool smethod_0(GClass84.GStruct165 gstruct165_0, GClass84.GStruct165 gstruct165_1)
			{
				return gstruct165_0.int_0 == gstruct165_1.int_0 && gstruct165_0.int_1 == gstruct165_1.int_1 && gstruct165_0.int_2 == gstruct165_1.int_2 && gstruct165_0.int_3 == gstruct165_1.int_3;
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x0007C9D4 File Offset: 0x0007ABD4
			public static bool smethod_1(GClass84.GStruct165 gstruct165_0, GClass84.GStruct165 gstruct165_1)
			{
				return gstruct165_0.int_0 != gstruct165_1.int_0 || gstruct165_0.int_1 != gstruct165_1.int_1 || gstruct165_0.int_2 != gstruct165_1.int_2 || gstruct165_0.int_3 != gstruct165_1.int_3;
			}

			// Token: 0x04000D7F RID: 3455
			public int int_0;

			// Token: 0x04000D80 RID: 3456
			public int int_1;

			// Token: 0x04000D81 RID: 3457
			public int int_2;

			// Token: 0x04000D82 RID: 3458
			public int int_3;
		}

		// Token: 0x020001E6 RID: 486
		public struct GStruct166
		{
			// Token: 0x060017F3 RID: 6131 RVA: 0x0007CA28 File Offset: 0x0007AC28
			public GStruct166(Vector2 vector2_0, Vector2 vector2_1)
			{
				this.list_0 = new List<Vector2>
				{
					vector2_0
				};
				this.list_1 = new List<Vector2>
				{
					vector2_1
				};
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x0007CA5C File Offset: 0x0007AC5C
			public GStruct166(List<Vector2> list_2, List<Vector2> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x0007CA78 File Offset: 0x0007AC78
			public void method_0(Vector2 vector2_0, Vector2 vector2_1)
			{
				this.list_0.Add(vector2_0);
				this.list_1.Add(vector2_1);
			}

			// Token: 0x04000D83 RID: 3459
			public List<Vector2> list_0;

			// Token: 0x04000D84 RID: 3460
			public List<Vector2> list_1;
		}

		// Token: 0x020001E7 RID: 487
		public struct GStruct167
		{
			// Token: 0x060017F6 RID: 6134 RVA: 0x0007CAA0 File Offset: 0x0007ACA0
			public GStruct167(List<Vector3> list_2, List<Vector3> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x060017F7 RID: 6135 RVA: 0x0007CABC File Offset: 0x0007ACBC
			public GStruct167(Vector3 vector3_0, Vector3 vector3_1)
			{
				this.list_0 = new List<Vector3>
				{
					vector3_0
				};
				this.list_1 = new List<Vector3>
				{
					vector3_1
				};
			}

			// Token: 0x060017F8 RID: 6136 RVA: 0x0007CAF0 File Offset: 0x0007ACF0
			public void method_0(Vector3 vector3_0, Vector3 vector3_1)
			{
				this.list_0.Add(vector3_0);
				this.list_1.Add(vector3_1);
			}

			// Token: 0x04000D85 RID: 3461
			public List<Vector3> list_0;

			// Token: 0x04000D86 RID: 3462
			public List<Vector3> list_1;
		}

		// Token: 0x020001E8 RID: 488
		public struct GStruct168
		{
			// Token: 0x060017F9 RID: 6137 RVA: 0x0007CB18 File Offset: 0x0007AD18
			public GStruct168(List<Vector4> list_2, List<Vector4> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x060017FA RID: 6138 RVA: 0x0007CB34 File Offset: 0x0007AD34
			public GStruct168(Vector4 vector4_0, Vector4 vector4_1)
			{
				this.list_0 = new List<Vector4>
				{
					vector4_0
				};
				this.list_1 = new List<Vector4>
				{
					vector4_1
				};
			}

			// Token: 0x060017FB RID: 6139 RVA: 0x0007CB68 File Offset: 0x0007AD68
			public void method_0(Vector4 vector4_0, Vector4 vector4_1)
			{
				this.list_0.Add(vector4_0);
				this.list_1.Add(vector4_1);
			}

			// Token: 0x04000D87 RID: 3463
			public List<Vector4> list_0;

			// Token: 0x04000D88 RID: 3464
			public List<Vector4> list_1;
		}

		// Token: 0x020001E9 RID: 489
		public struct GStruct169
		{
			// Token: 0x060017FC RID: 6140 RVA: 0x0007CB90 File Offset: 0x0007AD90
			public GStruct169(List<GClass84.GStruct163> list_2, List<GClass84.GStruct163> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x060017FD RID: 6141 RVA: 0x0007CBAC File Offset: 0x0007ADAC
			public GStruct169(GClass84.GStruct163 gstruct163_0, GClass84.GStruct163 gstruct163_1)
			{
				this.list_0 = new List<GClass84.GStruct163>
				{
					gstruct163_0
				};
				this.list_1 = new List<GClass84.GStruct163>
				{
					gstruct163_1
				};
			}

			// Token: 0x060017FE RID: 6142 RVA: 0x0007CBE0 File Offset: 0x0007ADE0
			internal void method_0(GClass84.GStruct163 gstruct163_0, GClass84.GStruct163 gstruct163_1)
			{
				this.list_0.Add(gstruct163_0);
				this.list_1.Add(gstruct163_1);
			}

			// Token: 0x04000D89 RID: 3465
			public List<GClass84.GStruct163> list_0;

			// Token: 0x04000D8A RID: 3466
			public List<GClass84.GStruct163> list_1;
		}

		// Token: 0x020001EA RID: 490
		public struct GStruct170
		{
			// Token: 0x060017FF RID: 6143 RVA: 0x0007CC08 File Offset: 0x0007AE08
			public GStruct170(List<GClass84.GStruct164> list_2, List<GClass84.GStruct164> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x06001800 RID: 6144 RVA: 0x0007CC24 File Offset: 0x0007AE24
			public GStruct170(GClass84.GStruct164 gstruct164_0, GClass84.GStruct164 gstruct164_1)
			{
				this.list_0 = new List<GClass84.GStruct164>
				{
					gstruct164_0
				};
				this.list_1 = new List<GClass84.GStruct164>
				{
					gstruct164_1
				};
			}

			// Token: 0x06001801 RID: 6145 RVA: 0x0007CC58 File Offset: 0x0007AE58
			public void method_0(GClass84.GStruct164 gstruct164_0, GClass84.GStruct164 gstruct164_1)
			{
				this.list_0.Add(gstruct164_0);
				this.list_1.Add(gstruct164_1);
			}

			// Token: 0x04000D8B RID: 3467
			public List<GClass84.GStruct164> list_0;

			// Token: 0x04000D8C RID: 3468
			public List<GClass84.GStruct164> list_1;
		}

		// Token: 0x020001EB RID: 491
		public struct GStruct171
		{
			// Token: 0x06001802 RID: 6146 RVA: 0x0007CC80 File Offset: 0x0007AE80
			public GStruct171(List<GClass84.GStruct165> list_2, List<GClass84.GStruct165> list_3)
			{
				this.list_0 = list_2;
				this.list_1 = list_3;
			}

			// Token: 0x06001803 RID: 6147 RVA: 0x0007CC9C File Offset: 0x0007AE9C
			public GStruct171(GClass84.GStruct165 gstruct165_0, GClass84.GStruct165 gstruct165_1)
			{
				this.list_0 = new List<GClass84.GStruct165>
				{
					gstruct165_0
				};
				this.list_1 = new List<GClass84.GStruct165>
				{
					gstruct165_1
				};
			}

			// Token: 0x06001804 RID: 6148 RVA: 0x0007CCD0 File Offset: 0x0007AED0
			public void method_0(GClass84.GStruct165 gstruct165_0, GClass84.GStruct165 gstruct165_1)
			{
				this.list_0.Add(gstruct165_0);
				this.list_1.Add(gstruct165_1);
			}

			// Token: 0x04000D8D RID: 3469
			public List<GClass84.GStruct165> list_0;

			// Token: 0x04000D8E RID: 3470
			public List<GClass84.GStruct165> list_1;
		}

		// Token: 0x020001EC RID: 492
		public struct GStruct172
		{
			// Token: 0x06001805 RID: 6149 RVA: 0x0007CCF8 File Offset: 0x0007AEF8
			public static bool smethod_0(GClass84.GStruct172 gstruct172_0, GClass84.GStruct172 gstruct172_1)
			{
				return gstruct172_0.consoleColor_0 == gstruct172_1.consoleColor_0 && gstruct172_0.string_0 == gstruct172_1.string_0;
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x0007CD30 File Offset: 0x0007AF30
			public GStruct172(ConsoleColor consoleColor_1, string string_1)
			{
				this.consoleColor_0 = consoleColor_1;
				this.string_0 = string_1;
			}

			// Token: 0x06001807 RID: 6151 RVA: 0x0007CD4C File Offset: 0x0007AF4C
			public static bool smethod_1(GClass84.GStruct172 gstruct172_0, GClass84.GStruct172 gstruct172_1)
			{
				return gstruct172_0.consoleColor_0 != gstruct172_1.consoleColor_0 || !(gstruct172_0.string_0 == gstruct172_1.string_0);
			}

			// Token: 0x04000D8F RID: 3471
			public ConsoleColor consoleColor_0;

			// Token: 0x04000D90 RID: 3472
			public string string_0;
		}

		// Token: 0x020001ED RID: 493
		public struct GStruct173
		{
			// Token: 0x06001808 RID: 6152 RVA: 0x0007CD84 File Offset: 0x0007AF84
			public GStruct173(Color color_1, string string_1)
			{
				this.color_0 = color_1;
				this.string_0 = string_1;
			}

			// Token: 0x06001809 RID: 6153 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
			public static bool smethod_0(GClass84.GStruct173 gstruct173_0, GClass84.GStruct173 gstruct173_1)
			{
				return gstruct173_0.color_0 == gstruct173_1.color_0 && gstruct173_0.string_0 == gstruct173_1.string_0;
			}

			// Token: 0x0600180A RID: 6154 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
			public static bool smethod_1(GClass84.GStruct173 gstruct173_0, GClass84.GStruct173 gstruct173_1)
			{
				return !(gstruct173_0.color_0 == gstruct173_1.color_0) || !(gstruct173_0.string_0 == gstruct173_1.string_0);
			}

			// Token: 0x04000D91 RID: 3473
			public Color color_0;

			// Token: 0x04000D92 RID: 3474
			public string string_0;
		}

		// Token: 0x020001EE RID: 494
		public enum GEnum46
		{
			// Token: 0x04000D94 RID: 3476
			const_0,
			// Token: 0x04000D95 RID: 3477
			const_1,
			// Token: 0x04000D96 RID: 3478
			const_2,
			// Token: 0x04000D97 RID: 3479
			const_3,
			// Token: 0x04000D98 RID: 3480
			const_4,
			// Token: 0x04000D99 RID: 3481
			const_5,
			// Token: 0x04000D9A RID: 3482
			const_6,
			// Token: 0x04000D9B RID: 3483
			const_7,
			// Token: 0x04000D9C RID: 3484
			const_8
		}

		// Token: 0x020001EF RID: 495
		public struct GStruct174
		{
			// Token: 0x0600180B RID: 6155 RVA: 0x0007CE20 File Offset: 0x0007B020
			public GStruct174(string string_1, Color color_1, float float_2)
			{
				this.string_0 = string_1;
				this.color_0 = color_1;
				this.float_0 = float_2;
				this.float_1 = float_2;
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x0007CE4C File Offset: 0x0007B04C
			public GStruct174(string string_1, Color color_1, float float_2, float float_3)
			{
				this.string_0 = string_1;
				this.color_0 = color_1;
				this.float_0 = float_2;
				this.float_1 = float_3;
			}

			// Token: 0x04000D9D RID: 3485
			public string string_0;

			// Token: 0x04000D9E RID: 3486
			public Color color_0;

			// Token: 0x04000D9F RID: 3487
			public float float_0;

			// Token: 0x04000DA0 RID: 3488
			public float float_1;
		}

		// Token: 0x020001F0 RID: 496
		internal struct Struct16
		{
			// Token: 0x0600180D RID: 6157 RVA: 0x0007CE78 File Offset: 0x0007B078
			internal Struct16(string string_2, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
			}

			// Token: 0x04000DA1 RID: 3489
			internal string string_0;

			// Token: 0x04000DA2 RID: 3490
			internal string string_1;
		}

		// Token: 0x020001F1 RID: 497
		// (Invoke) Token: 0x06001810 RID: 6160
		internal delegate int Delegate30(int int_0);

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x06001812 RID: 6162
		internal delegate float Delegate31(float float_0);

		// Token: 0x020001F3 RID: 499
		internal enum Enum4 : byte
		{
			// Token: 0x04000DA4 RID: 3492
			const_0,
			// Token: 0x04000DA5 RID: 3493
			const_1,
			// Token: 0x04000DA6 RID: 3494
			const_2,
			// Token: 0x04000DA7 RID: 3495
			const_3
		}

		// Token: 0x020001F4 RID: 500
		internal class Class99
		{
			// Token: 0x04000DA8 RID: 3496
			internal Action action_0;

			// Token: 0x04000DA9 RID: 3497
			internal GClass84.Enum4 enum4_0;

			// Token: 0x04000DAA RID: 3498
			internal bool bool_0;
		}

		// Token: 0x020001F5 RID: 501
		internal enum Enum5
		{
			// Token: 0x04000DAC RID: 3500
			const_0,
			// Token: 0x04000DAD RID: 3501
			const_1,
			// Token: 0x04000DAE RID: 3502
			const_2,
			// Token: 0x04000DAF RID: 3503
			const_3,
			// Token: 0x04000DB0 RID: 3504
			const_4,
			// Token: 0x04000DB1 RID: 3505
			const_5,
			// Token: 0x04000DB2 RID: 3506
			const_6,
			// Token: 0x04000DB3 RID: 3507
			const_7
		}

		// Token: 0x020001F6 RID: 502
		internal enum Enum6
		{
			// Token: 0x04000DB5 RID: 3509
			const_0,
			// Token: 0x04000DB6 RID: 3510
			const_1
		}

		// Token: 0x020001F7 RID: 503
		internal class Class100 : IEqualityComparer<Object>
		{
			// Token: 0x06001817 RID: 6167 RVA: 0x0007CE94 File Offset: 0x0007B094
			public bool Equals(Object object_0, Object object_1)
			{
				return object_0 == object_1;
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x0007CEA8 File Offset: 0x0007B0A8
			public int GetHashCode(Object object_0)
			{
				return object_0.GetHashCode();
			}
		}

		// Token: 0x020001F8 RID: 504
		public enum GEnum47
		{
			// Token: 0x04000DB8 RID: 3512
			const_0,
			// Token: 0x04000DB9 RID: 3513
			const_1,
			// Token: 0x04000DBA RID: 3514
			const_2
		}

		// Token: 0x020001F9 RID: 505
		internal struct Struct17
		{
			// Token: 0x0600181A RID: 6170 RVA: 0x0007CEC0 File Offset: 0x0007B0C0
			internal Struct17(int int_4, int int_5, int int_6, int int_7, Color32 color32_1)
			{
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
				this.color32_0 = color32_1;
			}

			// Token: 0x04000DBB RID: 3515
			internal int int_0;

			// Token: 0x04000DBC RID: 3516
			internal int int_1;

			// Token: 0x04000DBD RID: 3517
			internal int int_2;

			// Token: 0x04000DBE RID: 3518
			internal int int_3;

			// Token: 0x04000DBF RID: 3519
			internal Color32 color32_0;
		}

		// Token: 0x020001FA RID: 506
		public enum GEnum48
		{
			// Token: 0x04000DC1 RID: 3521
			const_0,
			// Token: 0x04000DC2 RID: 3522
			const_1,
			// Token: 0x04000DC3 RID: 3523
			const_2,
			// Token: 0x04000DC4 RID: 3524
			const_3,
			// Token: 0x04000DC5 RID: 3525
			const_4,
			// Token: 0x04000DC6 RID: 3526
			const_5,
			// Token: 0x04000DC7 RID: 3527
			const_6
		}

		// Token: 0x020001FB RID: 507
		internal enum Enum7
		{
			// Token: 0x04000DC9 RID: 3529
			const_0,
			// Token: 0x04000DCA RID: 3530
			const_1,
			// Token: 0x04000DCB RID: 3531
			const_2,
			// Token: 0x04000DCC RID: 3532
			const_3
		}

		// Token: 0x020001FC RID: 508
		internal enum Enum8
		{
			// Token: 0x04000DCE RID: 3534
			const_0,
			// Token: 0x04000DCF RID: 3535
			const_1,
			// Token: 0x04000DD0 RID: 3536
			const_2,
			// Token: 0x04000DD1 RID: 3537
			const_3
		}

		// Token: 0x020001FD RID: 509
		// (Invoke) Token: 0x0600181C RID: 6172
		internal delegate VRCUiPage Delegate32(VRCUiPage vrcuiPage_0);

		// Token: 0x020001FE RID: 510
		[CompilerGenerated]
		[Serializable]
		private sealed class Class101
		{
			// Token: 0x0600181F RID: 6175 RVA: 0x0007CEF4 File Offset: 0x0007B0F4
			internal bool method_0(ParameterInfo parameterInfo_0)
			{
				return parameterInfo_0.IsOptional;
			}

			// Token: 0x06001820 RID: 6176 RVA: 0x0007CEF4 File Offset: 0x0007B0F4
			internal bool method_1(ParameterInfo parameterInfo_0)
			{
				return parameterInfo_0.IsOptional;
			}

			// Token: 0x06001822 RID: 6178 RVA: 0x0007CF08 File Offset: 0x0007B108
			internal bool method_2(GameObject gameObject_0)
			{
				return gameObject_0.gameObject != null;
			}

			// Token: 0x06001823 RID: 6179 RVA: 0x0007CF24 File Offset: 0x0007B124
			internal bool method_3(MethodInfo methodInfo_0)
			{
				bool result;
				if (methodInfo_0.ReturnType == typeof(VRCUiPage) && methodInfo_0.GetParameters().Length == 1 && methodInfo_0.GetParameters()[0].ParameterType == typeof(VRCUiPage))
				{
					result = XrefScanner.XrefScan(methodInfo_0).Any(new Func<XrefInstance, bool>(GClass84.Class101.class101_0.method_13));
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06001824 RID: 6180 RVA: 0x0007CFA0 File Offset: 0x0007B1A0
			internal bool method_4(VRC_ObjectSync vrc_ObjectSync_0)
			{
				return vrc_ObjectSync_0.GetComponents<Collider>().Concat(vrc_ObjectSync_0.GetComponentsInChildren<Collider>()).Any(new Func<Collider, bool>(GClass84.Class101.class101_0.method_31));
			}

			// Token: 0x06001825 RID: 6181 RVA: 0x0007CFE4 File Offset: 0x0007B1E4
			internal void method_5(APIUser apiuser_0)
			{
				GClass84.smethod_613(GClass84.smethod_275(apiuser_0));
			}

			// Token: 0x06001826 RID: 6182 RVA: 0x0007CFFC File Offset: 0x0007B1FC
			internal void method_6(ApiContainer apiContainer_0)
			{
				GClass70.smethod_38("Avatar deleted.", GClass70.Enum1.const_0);
			}

			// Token: 0x06001827 RID: 6183 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			internal bool method_7(XrefInstance xrefInstance_0)
			{
				return false;
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x0007D014 File Offset: 0x0007B214
			internal string method_8(byte byte_0)
			{
				return byte_0.ToString("X2");
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x0007D030 File Offset: 0x0007B230
			internal void method_9(ApiContainer apiContainer_0)
			{
				GClass84.smethod_1553();
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x0007D044 File Offset: 0x0007B244
			internal bool method_10(Collider collider_0)
			{
				return !collider_0.isTrigger && (1016111 >> collider_0.gameObject.layer & 1) == 1;
			}

			// Token: 0x0600182B RID: 6187 RVA: 0x0007D078 File Offset: 0x0007B278
			internal void method_11(MethodInfo methodInfo_0)
			{
				GClass84.smethod_542(methodInfo_0);
			}

			// Token: 0x0600182C RID: 6188 RVA: 0x0007D014 File Offset: 0x0007B214
			internal string method_12(byte byte_0)
			{
				return byte_0.ToString("X2");
			}

			// Token: 0x0600182D RID: 6189 RVA: 0x0007D08C File Offset: 0x0007B28C
			internal bool method_13(XrefInstance xrefInstance_0)
			{
				bool result;
				if (xrefInstance_0.Type == null)
				{
					Object @object = xrefInstance_0.ReadAsObject();
					result = (((@object != null) ? @object.ToString() : null) == "Screen Not Found - ");
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x0600182E RID: 6190 RVA: 0x0007D0C4 File Offset: 0x0007B2C4
			internal bool method_14(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name.StartsWith("Method_Public_Void_APIUser_") && !methodInfo_0.Name.Contains("_PDM_") && GClass187.smethod_1(methodInfo_0, "Method_Public_Virtual_Final_New_Void_IUser_", null);
			}

			// Token: 0x0600182F RID: 6191 RVA: 0x0007D104 File Offset: 0x0007B304
			internal string method_15(ApiAvatar apiAvatar_0)
			{
				return apiAvatar_0.assetUrl;
			}

			// Token: 0x06001830 RID: 6192 RVA: 0x0007D118 File Offset: 0x0007B318
			internal bool method_16(ApiAvatar apiAvatar_0)
			{
				return apiAvatar_0 != null;
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x0007D12C File Offset: 0x0007B32C
			internal bool method_17(MethodInfo methodInfo_0)
			{
				if (methodInfo_0.Name.StartsWith("Method_Public_Void_Boolean_") && methodInfo_0.Name.Length < 30)
				{
					if (methodInfo_0.GetParameters().All(new Func<ParameterInfo, bool>(GClass84.Class101.class101_0.method_1)))
					{
						return GClass187.smethod_1(methodInfo_0, "Method_Public_Void_", typeof(FeaturePermissionManager));
					}
				}
				return false;
			}

			// Token: 0x06001832 RID: 6194 RVA: 0x0007D1A0 File Offset: 0x0007B3A0
			internal ApiAvatar method_18(Player player_0)
			{
				return player_0.Method_Public_get_ApiAvatar_0();
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x0007D1B4 File Offset: 0x0007B3B4
			internal int method_19(string string_0)
			{
				return int.Parse(string_0);
			}

			// Token: 0x06001834 RID: 6196 RVA: 0x0007D1C8 File Offset: 0x0007B3C8
			internal bool method_20(MethodInfo methodInfo_0)
			{
				bool result;
				if (methodInfo_0.ReturnType == typeof(void) && methodInfo_0.GetParameters().Length == 0)
				{
					result = XrefScanner.XrefScan(methodInfo_0).Any(new Func<XrefInstance, bool>(GClass84.Class101.class101_0.method_7));
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06001836 RID: 6198 RVA: 0x0007D030 File Offset: 0x0007B230
			internal void method_21(ApiContainer apiContainer_0)
			{
				GClass84.smethod_1553();
			}

			// Token: 0x06001837 RID: 6199 RVA: 0x0007D244 File Offset: 0x0007B444
			internal bool method_22(Player player_0)
			{
				return player_0 != null;
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x0007D258 File Offset: 0x0007B458
			internal void method_23(ApiContainer apiContainer_0)
			{
				GClass84.smethod_826();
			}

			// Token: 0x06001839 RID: 6201 RVA: 0x0007D26C File Offset: 0x0007B46C
			internal bool method_24(MethodInfo methodInfo_0)
			{
				if (methodInfo_0.Name.StartsWith("Method_Private_Void_Boolean_") && methodInfo_0.Name.Length < 31)
				{
					if (methodInfo_0.GetParameters().Any(new Func<ParameterInfo, bool>(GClass84.Class101.class101_0.method_0)))
					{
						return GClass187.smethod_1(methodInfo_0, "ReloadAvatarNetworkedRPC", null);
					}
				}
				return false;
			}

			// Token: 0x0600183A RID: 6202 RVA: 0x0007D2D8 File Offset: 0x0007B4D8
			internal void method_25(ApiContainer apiContainer_0)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"deleting",
					" ",
					"avatar",
					": ",
					apiContainer_0.Error
				}), GClass70.Enum1.const_0);
			}

			// Token: 0x0600183B RID: 6203 RVA: 0x0007D330 File Offset: 0x0007B530
			internal string method_26(int int_0)
			{
				return string.Concat(BitConverter.GetBytes(int_0).Select(new Func<byte, string>(GClass84.Class101.class101_0.method_12)));
			}

			// Token: 0x0600183C RID: 6204 RVA: 0x0007D258 File Offset: 0x0007B458
			internal void method_27(ApiContainer apiContainer_0)
			{
				GClass84.smethod_826();
			}

			// Token: 0x0600183D RID: 6205 RVA: 0x0007D36C File Offset: 0x0007B56C
			internal bool method_28(Type type_0)
			{
				return !type_0.ContainsGenericParameters && typeof(DataModel<APIUser>).IsAssignableFrom(type_0) && Il2CppType.From(typeof(DataModel<APIUser>)).IsAssignableFrom(Il2CppType.From(type_0)) && Il2CppType.Of<IUser>().IsAssignableFrom(Il2CppType.From(type_0)) && type_0.GetProperty("prop_Observable_1_List_1_String_0") == null;
			}

			// Token: 0x0600183E RID: 6206 RVA: 0x0007D3D8 File Offset: 0x0007B5D8
			internal bool method_29(Transform transform_0)
			{
				return transform_0 == null;
			}

			// Token: 0x0600183F RID: 6207 RVA: 0x0007D3EC File Offset: 0x0007B5EC
			internal bool method_30(UdonBehaviour udonBehaviour_0)
			{
				bool result;
				if (udonBehaviour_0.SynchronizePosition)
				{
					result = udonBehaviour_0.GetComponents<Collider>().Concat(udonBehaviour_0.GetComponentsInChildren<Collider>()).Any(new Func<Collider, bool>(GClass84.Class101.class101_0.method_10));
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x0007D044 File Offset: 0x0007B244
			internal bool method_31(Collider collider_0)
			{
				return !collider_0.isTrigger && (1016111 >> collider_0.gameObject.layer & 1) == 1;
			}

			// Token: 0x04000DD2 RID: 3538
			public static readonly GClass84.Class101 class101_0 = new GClass84.Class101();

			// Token: 0x04000DD3 RID: 3539
			public static Func<ParameterInfo, bool> func_0;

			// Token: 0x04000DD4 RID: 3540
			public static Func<MethodInfo, bool> func_1;

			// Token: 0x04000DD5 RID: 3541
			public static Func<ParameterInfo, bool> func_2;

			// Token: 0x04000DD6 RID: 3542
			public static Func<MethodInfo, bool> func_3;

			// Token: 0x04000DD7 RID: 3543
			public static Func<string, int> func_4;

			// Token: 0x04000DD8 RID: 3544
			public static Func<MethodInfo, bool> func_5;

			// Token: 0x04000DD9 RID: 3545
			public static Action<ApiContainer> action_0;

			// Token: 0x04000DDA RID: 3546
			public static Action<ApiContainer> action_1;

			// Token: 0x04000DDB RID: 3547
			public static Action<ApiContainer> action_2;

			// Token: 0x04000DDC RID: 3548
			public static Action<ApiContainer> action_3;

			// Token: 0x04000DDD RID: 3549
			public static Action<ApiContainer> action_4;

			// Token: 0x04000DDE RID: 3550
			public static Action<ApiContainer> action_5;

			// Token: 0x04000DDF RID: 3551
			public static Predicate<Transform> predicate_0;

			// Token: 0x04000DE0 RID: 3552
			public static Func<Collider, bool> func_6;

			// Token: 0x04000DE1 RID: 3553
			public static Func<VRC_ObjectSync, bool> func_7;

			// Token: 0x04000DE2 RID: 3554
			public static Func<Collider, bool> func_8;

			// Token: 0x04000DE3 RID: 3555
			public static Func<UdonBehaviour, bool> func_9;

			// Token: 0x04000DE4 RID: 3556
			public static Action<APIUser> action_6;

			// Token: 0x04000DE5 RID: 3557
			public static Func<Type, bool> func_10;

			// Token: 0x04000DE6 RID: 3558
			public static Func<XrefInstance, bool> func_11;

			// Token: 0x04000DE7 RID: 3559
			public static Func<MethodInfo, bool> func_12;

			// Token: 0x04000DE8 RID: 3560
			public static Func<Player, bool> func_13;

			// Token: 0x04000DE9 RID: 3561
			public static Func<Player, ApiAvatar> func_14;

			// Token: 0x04000DEA RID: 3562
			public static Func<ApiAvatar, bool> func_15;

			// Token: 0x04000DEB RID: 3563
			public static Func<ApiAvatar, string> func_16;

			// Token: 0x04000DEC RID: 3564
			public static Func<XrefInstance, bool> func_17;

			// Token: 0x04000DED RID: 3565
			public static Func<MethodInfo, bool> func_18;

			// Token: 0x04000DEE RID: 3566
			public static Func<GameObject, bool> func_19;

			// Token: 0x04000DEF RID: 3567
			public static Action<MethodInfo> action_7;

			// Token: 0x04000DF0 RID: 3568
			public static Func<byte, string> func_20;

			// Token: 0x04000DF1 RID: 3569
			public static Func<int, string> func_21;

			// Token: 0x04000DF2 RID: 3570
			public static Func<byte, string> func_22;
		}

		// Token: 0x02000200 RID: 512
		[CompilerGenerated]
		[Serializable]
		private sealed class Class103<T>
		{
			// Token: 0x06001848 RID: 6216 RVA: 0x0007D5FC File Offset: 0x0007B7FC
			internal bool method_0(T gparam_0)
			{
				return gparam_0 == null;
			}

			// Token: 0x04000DFA RID: 3578
			public static readonly GClass84.Class103<T> class103_0 = new GClass84.Class103<T>();

			// Token: 0x04000DFB RID: 3579
			public static Predicate<T> predicate_0;
		}

		// Token: 0x02000201 RID: 513
		[CompilerGenerated]
		private sealed class Class104
		{
			// Token: 0x0600184A RID: 6218 RVA: 0x0007D614 File Offset: 0x0007B814
			internal bool method_0(Player player_0)
			{
				return GClass84.smethod_28(player_0).IsOwner(this.gameObject_0);
			}

			// Token: 0x04000DFC RID: 3580
			public GameObject gameObject_0;
		}

		// Token: 0x02000204 RID: 516
		[CompilerGenerated]
		private sealed class Class107
		{
			// Token: 0x06001856 RID: 6230 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name == this.string_0;
			}

			// Token: 0x04000E06 RID: 3590
			public string string_0;

			// Token: 0x04000E07 RID: 3591
			public Predicate<MethodInfo> predicate_0;
		}

		// Token: 0x02000205 RID: 517
		[CompilerGenerated]
		private sealed class Class108
		{
			// Token: 0x06001858 RID: 6232 RVA: 0x0007D80C File Offset: 0x0007BA0C
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return GClass84.smethod_1428(methodInfo_0.Name, GClass84.smethod_593(this.string_0)) == this.string_0;
			}

			// Token: 0x04000E08 RID: 3592
			public string string_0;

			// Token: 0x04000E09 RID: 3593
			public Predicate<MethodInfo> predicate_0;
		}

		// Token: 0x02000206 RID: 518
		[CompilerGenerated]
		private sealed class Class109
		{
			// Token: 0x0600185A RID: 6234 RVA: 0x0007D844 File Offset: 0x0007BA44
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return GClass84.smethod_1428(methodInfo_0.Name, GClass84.smethod_593(this.string_0)) == this.string_0;
			}

			// Token: 0x04000E0A RID: 3594
			public string string_0;

			// Token: 0x04000E0B RID: 3595
			public Predicate<MethodInfo> predicate_0;
		}

		// Token: 0x02000207 RID: 519
		[CompilerGenerated]
		private sealed class Class110
		{
			// Token: 0x0600185C RID: 6236 RVA: 0x0007D87C File Offset: 0x0007BA7C
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return GClass84.smethod_1428(methodInfo_0.Name, GClass84.smethod_593(this.string_0)) == this.string_0;
			}

			// Token: 0x04000E0C RID: 3596
			public string string_0;

			// Token: 0x04000E0D RID: 3597
			public Predicate<MethodInfo> predicate_0;
		}

		// Token: 0x0200020B RID: 523
		[CompilerGenerated]
		private sealed class Class114
		{
			// Token: 0x0600186D RID: 6253 RVA: 0x0007DF04 File Offset: 0x0007C104
			internal void method_0(APIUser apiuser_0)
			{
				string location = apiuser_0.location;
				if (GClass84.smethod_362(location) == GClass84.smethod_362("private"))
				{
					if (this.action_0 != null)
					{
						this.action_0();
					}
				}
				else if (GClass84.smethod_362(location) == GClass84.smethod_362("offline"))
				{
					if (this.action_1 != null)
					{
						this.action_1();
					}
				}
				else
				{
					if (this.action_2 != null)
					{
						this.action_2();
					}
					GClass84.smethod_704(location);
				}
			}

			// Token: 0x04000E21 RID: 3617
			public Action action_0;

			// Token: 0x04000E22 RID: 3618
			public Action action_1;

			// Token: 0x04000E23 RID: 3619
			public Action action_2;
		}

		// Token: 0x0200020E RID: 526
		[CompilerGenerated]
		private sealed class Class117
		{
			// Token: 0x06001878 RID: 6264 RVA: 0x0007E230 File Offset: 0x0007C430
			internal void method_0(Task task_0)
			{
				if (task_0.IsFaulted)
				{
					GClass70.smethod_36(string.Format("Free-floating Task {0}}} failed with exception: {1}", (this.string_0 == null) ? string.Empty : ("(" + this.string_0 + ")"), task_0.Exception), GClass70.Enum1.const_0);
				}
			}

			// Token: 0x04000E2D RID: 3629
			public string string_0;
		}

		// Token: 0x0200020F RID: 527
		[CompilerGenerated]
		private sealed class Class118
		{
			// Token: 0x0600187B RID: 6267 RVA: 0x0007E280 File Offset: 0x0007C480
			internal bool method_0(Type type_0)
			{
				return string.Equals(type_0.Namespace, this.string_0, StringComparison.Ordinal);
			}

			// Token: 0x04000E2E RID: 3630
			public string string_0;
		}

		// Token: 0x02000217 RID: 535
		[CompilerGenerated]
		private sealed class Class126
		{
			// Token: 0x060018A0 RID: 6304 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
			internal RegistryKey method_0(string string_0)
			{
				return this.registryKey_0.OpenSubKey(string_0);
			}

			// Token: 0x04000E5D RID: 3677
			public RegistryKey registryKey_0;

			// Token: 0x04000E5E RID: 3678
			public Func<string, RegistryKey> func_0;
		}
	}
}
