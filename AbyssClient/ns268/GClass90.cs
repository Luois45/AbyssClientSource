using System;
using ns185;
using ns241;
using ns441;
using UnityEngine;
using VRC.Core;
using VRC.SDKBase;

namespace ns268
{
	// Token: 0x0200022B RID: 555
	public class GClass90
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x00080B54 File Offset: 0x0007ED54
		internal static void smethod_0(VRCAvatarManager vrcavatarManager_0, GameObject gameObject_0, bool bool_0, GameObject gameObject_1 = null)
		{
			GClass90.smethod_1(vrcavatarManager_0, gameObject_0, bool_0, gameObject_1);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00080B6C File Offset: 0x0007ED6C
		internal static void smethod_1(VRCAvatarManager vrcavatarManager_0, GameObject gameObject_0, bool bool_0, GameObject gameObject_1)
		{
			GClass90.smethod_2(vrcavatarManager_0, gameObject_0, bool_0, gameObject_1);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00080B84 File Offset: 0x0007ED84
		internal static void smethod_2(VRCAvatarManager vrcavatarManager_0, GameObject gameObject_0, bool bool_0, GameObject gameObject_1)
		{
			if (GClass84.gclass145_0.bool_0 && gameObject_0 && !GClass84.gclass145_0.method_211(gameObject_0))
			{
				VRCPlayer vrcplayer;
				if (bool_0)
				{
					vrcplayer = null;
				}
				else
				{
					if (!vrcavatarManager_0)
					{
						return;
					}
					vrcplayer = vrcavatarManager_0.field_Private_VRCPlayer_0;
					if (!vrcplayer)
					{
						return;
					}
					if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_219(), GClass84.smethod_385(vrcplayer), ""))
					{
						GClass84.gclass145_0.method_20(gameObject_0, true);
						return;
					}
				}
				if (!GClass84.gclass145_0.bool_15)
				{
					GClass84.gclass145_0.bool_15 = true;
				}
				string text = string.Empty;
				PipelineManager component = gameObject_0.GetComponent<PipelineManager>();
				if (component)
				{
					text = component.blueprintId;
					if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_138(), text, ""))
					{
						GClass84.gclass145_0.method_20(gameObject_0, true);
						return;
					}
				}
				bool flag = false;
				VRCPlayerApi vrcplayerApi;
				bool flag2;
				string string_;
				if (bool_0)
				{
					vrcplayerApi = null;
					flag2 = false;
					if (component)
					{
						string_ = text;
					}
					else
					{
						string_ = "Avatar";
					}
				}
				else
				{
					vrcplayerApi = vrcplayer.Method_Public_get_VRCPlayerApi_0();
					flag = false;
					if (vrcplayerApi != null)
					{
						flag2 = vrcplayerApi.isLocal;
						string_ = vrcplayerApi.displayName;
					}
					else
					{
						flag2 = (vrcplayer == GClass84.smethod_460());
						string_ = vrcplayer.Method_Public_get_String_0();
					}
					if (!flag2)
					{
						flag = GClass84.smethod_66(vrcplayer);
					}
					if (GClass84.gclass145_0.bool_3 && flag2)
					{
						GClass84.gclass145_0.method_20(gameObject_0, true);
						return;
					}
					if (GClass84.gclass145_0.bool_4 && flag)
					{
						GClass84.gclass145_0.method_20(gameObject_0, true);
						return;
					}
					if (GClass84.gclass145_0.bool_5 && GClass84.smethod_382(GClass84.smethod_385(vrcplayer)))
					{
						GClass84.gclass145_0.method_20(gameObject_0, true);
						return;
					}
				}
				Transform transform = gameObject_0.transform;
				Transform transform2 = (gameObject_1 != null) ? gameObject_1.transform : null;
				GClass84.gclass145_0.method_340(GClass84.gclass145_0.list_17);
				GClass84.gclass145_0.method_539(GClass84.gclass145_0.list_19);
				ConsoleColor consoleColor_ = GClass84.smethod_1571(GClass84.smethod_958(vrcplayerApi), true);
				if (GClass84.gclass145_0.bool_118 && ((!GClass84.gclass145_0.bool_119 || !flag2) && (!GClass84.gclass145_0.bool_120 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_491(transform, string_, consoleColor_, flag2, flag, true);
					}
					catch (Exception ex)
					{
						GClass70.smethod_36("[Error]" + " " + ex.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_96 && ((!GClass84.gclass145_0.bool_97 || !flag2) && (!GClass84.gclass145_0.bool_98 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_330(transform, string_, consoleColor_, flag2, flag, true, false);
					}
					catch (Exception ex2)
					{
						GClass70.smethod_36("[Error]" + " " + ex2.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_125 && ((!GClass84.gclass145_0.bool_126 || !flag2) && (!GClass84.gclass145_0.bool_127 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_94(transform, string_, consoleColor_, flag2, flag, true, false);
					}
					catch (Exception ex3)
					{
						GClass70.smethod_36("[Error]" + " " + ex3.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_132 && ((!GClass84.gclass145_0.bool_133 || !flag2) && (!GClass84.gclass145_0.bool_134 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_129(transform, string_, consoleColor_, flag2, flag, true, false);
					}
					catch (Exception ex4)
					{
						GClass70.smethod_36("[Error]" + " " + ex4.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_101 && ((!GClass84.gclass145_0.bool_102 || !flag2) && (!GClass84.gclass145_0.bool_103 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_462(transform, string_, consoleColor_, flag2, flag, true);
					}
					catch (Exception ex5)
					{
						GClass70.smethod_36("[Error]" + " " + ex5.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_106 && ((!GClass84.gclass145_0.bool_107 || !flag2) && (!GClass84.gclass145_0.bool_108 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_498(transform, string_, consoleColor_, flag2, flag, true);
					}
					catch (Exception ex6)
					{
						GClass70.smethod_36("[Error]" + " " + ex6.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_111 && ((!GClass84.gclass145_0.bool_112 || !flag2) && (!GClass84.gclass145_0.bool_113 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_273(transform, string_, consoleColor_, flag2, flag, true);
					}
					catch (Exception ex7)
					{
						GClass70.smethod_36("[Error]" + " " + ex7.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_67 && ((!GClass84.gclass145_0.bool_68 || !flag2) && (!GClass84.gclass145_0.bool_69 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_135(transform, string_, consoleColor_, flag2, flag, true, false, null);
					}
					catch (Exception ex8)
					{
						GClass70.smethod_36("[Error]" + " " + ex8.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_73 && ((!GClass84.gclass145_0.bool_74 || !flag2) && (!GClass84.gclass145_0.bool_75 || !flag)))
				{
					try
					{
						GClass84.gclass145_0.method_167(transform, string_, consoleColor_, flag2, flag, true);
					}
					catch (Exception ex9)
					{
						GClass70.smethod_36("[Error]" + " " + ex9.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_19)
				{
					try
					{
						GClass84.gclass145_0.method_409(transform, string_, consoleColor_, flag2, flag, true, false, transform2);
					}
					catch (Exception ex10)
					{
						GClass70.smethod_36("[Error]" + " " + ex10.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_7 || bool_0)
				{
					GClass84.gclass145_0.int_47 = 0;
					GClass84.gclass145_0.int_50 = int.MinValue;
					if (GClass84.gclass145_0.bool_87 && ((!GClass84.gclass145_0.bool_90 || !flag2) && (!GClass84.gclass145_0.bool_91 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_328(transform, string_, consoleColor_, flag2, flag, true, false, transform2);
						}
						catch (Exception ex11)
						{
							GClass70.smethod_36("[Error]" + " " + ex11.Message, GClass70.Enum1.const_0);
						}
					}
					if (GClass84.gclass145_0.bool_41 && ((!GClass84.gclass145_0.bool_42 || !flag2) && (!GClass84.gclass145_0.bool_43 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_201(transform, string_, consoleColor_, flag2, flag, true, false, null, false, null, false, transform2);
						}
						catch (Exception ex12)
						{
							GClass70.smethod_36("[Error]" + " " + ex12.Message, GClass70.Enum1.const_0);
						}
						if (GClass84.gclass145_0.bool_46)
						{
							try
							{
								GClass84.gclass145_0.method_331(transform, string_, consoleColor_, flag2, flag, true, false, null, false, null, transform2);
							}
							catch (Exception ex13)
							{
								GClass70.smethod_36("[Error]" + " " + ex13.Message, GClass70.Enum1.const_0);
							}
							GClass84.gclass145_0.method_340(GClass84.gclass145_0.list_17);
							GClass84.gclass145_0.method_539(GClass84.gclass145_0.list_19);
							if (GClass84.gclass145_0.bool_48)
							{
								try
								{
									GClass84.gclass145_0.method_60(transform, string_, consoleColor_, flag2, flag, true, false, null, transform2);
								}
								catch (Exception ex14)
								{
									GClass70.smethod_36("[Error]" + " " + ex14.Message, GClass70.Enum1.const_0);
								}
								GClass84.gclass145_0.method_340(GClass84.gclass145_0.list_17);
								GClass84.gclass145_0.method_539(GClass84.gclass145_0.list_19);
							}
						}
					}
					if (!GClass84.gclass145_0.bool_1 && GClass84.gclass145_0.bool_30 && ((!GClass84.gclass145_0.bool_34 || !flag2) && (!GClass84.gclass145_0.bool_35 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_457(transform, string_, consoleColor_, flag2, flag, true, false, transform2);
						}
						catch (Exception ex15)
						{
							GClass70.smethod_36("[Error]" + " " + ex15.Message, GClass70.Enum1.const_0);
						}
					}
					if (GClass84.gclass145_0.bool_139)
					{
						if ((GClass84.gclass145_0.bool_137 && flag2) || (GClass84.gclass145_0.bool_138 && flag))
						{
							goto IL_A07;
						}
						try
						{
							GClass84.gclass145_0.method_70(transform, string_, consoleColor_, flag2, flag, true);
							goto IL_A07;
						}
						catch (Exception ex16)
						{
							GClass70.smethod_36("[Error]" + " " + ex16.Message, GClass70.Enum1.const_0);
							goto IL_A07;
						}
					}
					if (GClass84.gclass145_0.bool_141)
					{
						if ((GClass84.gclass145_0.bool_137 && flag2) || (GClass84.gclass145_0.bool_138 && flag))
						{
							goto IL_A07;
						}
						try
						{
							GClass84.gclass145_0.method_87(transform, string_, consoleColor_, flag2, flag, true);
							goto IL_A07;
						}
						catch (Exception ex17)
						{
							GClass70.smethod_36("[Error]" + " " + ex17.Message, GClass70.Enum1.const_0);
							goto IL_A07;
						}
					}
					if (GClass84.gclass145_0.bool_146 && ((!GClass84.gclass145_0.bool_137 || !flag2) && (!GClass84.gclass145_0.bool_138 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_502(transform, string_, consoleColor_, flag2, flag, true);
						}
						catch (Exception ex18)
						{
							GClass70.smethod_36("[Error]" + " " + ex18.Message, GClass70.Enum1.const_0);
						}
					}
					IL_A07:
					if (GClass84.gclass145_0.bool_51 && ((!GClass84.gclass145_0.bool_52 || !flag2) && (!GClass84.gclass145_0.bool_53 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_406(transform, string_, consoleColor_, flag2, flag, true);
						}
						catch (Exception ex19)
						{
							GClass70.smethod_36("[Error]" + " " + ex19.Message, GClass70.Enum1.const_0);
						}
					}
					if (GClass84.gclass145_0.bool_56 && ((!GClass84.gclass145_0.bool_57 || !flag2) && (!GClass84.gclass145_0.bool_58 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_25(transform, string_, consoleColor_, flag2, flag, true);
						}
						catch (Exception ex20)
						{
							GClass70.smethod_36("[Error]" + " " + ex20.Message, GClass70.Enum1.const_0);
						}
					}
					if (GClass84.gclass145_0.bool_61 && ((!GClass84.gclass145_0.bool_62 || !flag2) && (!GClass84.gclass145_0.bool_63 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_233(transform, string_, consoleColor_, flag2, flag, true);
						}
						catch (Exception ex21)
						{
							GClass70.smethod_36("[Error]" + " " + ex21.Message, GClass70.Enum1.const_0);
						}
					}
					if (GClass84.gclass145_0.bool_78 && ((!GClass84.gclass145_0.bool_79 || !flag2) && (!GClass84.gclass145_0.bool_80 || !flag)))
					{
						try
						{
							GClass84.gclass145_0.method_45(transform, string_, consoleColor_, flag2, flag, true, false, null, false, null, null);
						}
						catch (Exception ex22)
						{
							GClass70.smethod_36("[Error]" + " " + ex22.Message, GClass70.Enum1.const_0);
						}
					}
					GClass84.gclass145_0.list_18.Clear();
					GClass84.gclass145_0.list_20.Clear();
					GClass84.gclass145_0.method_20(gameObject_0, false);
				}
			}
		}
	}
}
