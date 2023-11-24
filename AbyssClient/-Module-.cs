using System;
using ns133;
using ns140;
using ns226;
using ns236;
using ns314;
using ns370;

// Token: 0x02000001 RID: 1
internal static class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002208 File Offset: 0x00000408
	internal static void smethod_0()
	{
		<Module>.smethod_23();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000221C File Offset: 0x0000041C
	internal static bool smethod_1()
	{
		GStruct58 gstruct58_ = GClass101.smethod_12();
		GStruct128 gstruct128_ = GClass101.smethod_11();
		bool result;
		if (GStruct128.smethod_2(gstruct128_, GStruct128.smethod_0(0)))
		{
			result = false;
		}
		else
		{
			using (GClass78.GClass79 gclass = new GClass78.GClass79("SteamClient017"))
			{
				<Module>.intptr_0 = Class177.SteamInternal_CreateInterface(gclass);
			}
			if (<Module>.intptr_0 == IntPtr.Zero)
			{
				result = false;
			}
			else
			{
				<Module>.intptr_1 = GClass57.smethod_6(gstruct58_, gstruct128_, "SteamUser019");
				if (<Module>.intptr_1 == IntPtr.Zero)
				{
					result = false;
				}
				else
				{
					<Module>.intptr_2 = GClass57.smethod_26(gstruct58_, gstruct128_, "SteamFriends015");
					if (<Module>.intptr_2 == IntPtr.Zero)
					{
						result = false;
					}
					else
					{
						<Module>.intptr_3 = GClass57.smethod_22(gstruct128_, "SteamUtils009");
						if (<Module>.intptr_3 == IntPtr.Zero)
						{
							result = false;
						}
						else
						{
							<Module>.intptr_4 = GClass57.smethod_25(gstruct58_, gstruct128_, "SteamMatchMaking009");
							if (<Module>.intptr_4 == IntPtr.Zero)
							{
								result = false;
							}
							else
							{
								<Module>.intptr_7 = GClass57.smethod_21(gstruct58_, gstruct128_, "SteamMatchMakingServers002");
								if (<Module>.intptr_7 == IntPtr.Zero)
								{
									result = false;
								}
								else
								{
									<Module>.intptr_5 = GClass57.smethod_31(gstruct58_, gstruct128_, "STEAMUSERSTATS_INTERFACE_VERSION011");
									if (<Module>.intptr_5 == IntPtr.Zero)
									{
										result = false;
									}
									else
									{
										<Module>.intptr_6 = GClass57.smethod_8(gstruct58_, gstruct128_, "STEAMAPPS_INTERFACE_VERSION008");
										if (<Module>.intptr_6 == IntPtr.Zero)
										{
											result = false;
										}
										else
										{
											<Module>.intptr_8 = GClass57.smethod_27(gstruct58_, gstruct128_, "SteamNetworking005");
											if (<Module>.intptr_8 == IntPtr.Zero)
											{
												result = false;
											}
											else
											{
												<Module>.intptr_9 = GClass57.smethod_34(gstruct58_, gstruct128_, "STEAMREMOTESTORAGE_INTERFACE_VERSION014");
												if (<Module>.intptr_9 == IntPtr.Zero)
												{
													result = false;
												}
												else
												{
													<Module>.intptr_10 = GClass57.smethod_29(gstruct58_, gstruct128_, "STEAMSCREENSHOTS_INTERFACE_VERSION003");
													if (<Module>.intptr_10 == IntPtr.Zero)
													{
														result = false;
													}
													else
													{
														<Module>.intptr_11 = GClass57.smethod_16(gstruct58_, gstruct128_, "STEAMHTTP_INTERFACE_VERSION002");
														if (<Module>.intptr_11 == IntPtr.Zero)
														{
															result = false;
														}
														else
														{
															<Module>.intptr_12 = GClass57.smethod_36(gstruct58_, gstruct128_, "SteamController006");
															if (<Module>.intptr_12 == IntPtr.Zero)
															{
																result = false;
															}
															else
															{
																<Module>.intptr_13 = GClass57.smethod_9(gstruct58_, gstruct128_, "STEAMUGC_INTERFACE_VERSION010");
																if (<Module>.intptr_13 == IntPtr.Zero)
																{
																	result = false;
																}
																else
																{
																	<Module>.intptr_14 = GClass57.smethod_10(gstruct58_, gstruct128_, "STEAMAPPLIST_INTERFACE_VERSION001");
																	if (<Module>.intptr_14 == IntPtr.Zero)
																	{
																		result = false;
																	}
																	else
																	{
																		<Module>.intptr_15 = GClass57.smethod_11(gstruct58_, gstruct128_, "STEAMMUSIC_INTERFACE_VERSION001");
																		if (<Module>.intptr_15 == IntPtr.Zero)
																		{
																			result = false;
																		}
																		else
																		{
																			<Module>.intptr_16 = GClass57.smethod_7(gstruct58_, gstruct128_, "STEAMMUSICREMOTE_INTERFACE_VERSION001");
																			if (<Module>.intptr_16 == IntPtr.Zero)
																			{
																				result = false;
																			}
																			else
																			{
																				<Module>.intptr_17 = GClass57.smethod_2(gstruct58_, gstruct128_, "STEAMHTMLSURFACE_INTERFACE_VERSION_004");
																				if (<Module>.intptr_17 == IntPtr.Zero)
																				{
																					result = false;
																				}
																				else
																				{
																					<Module>.intptr_18 = GClass57.smethod_35(gstruct58_, gstruct128_, "STEAMINVENTORY_INTERFACE_V002");
																					if (<Module>.intptr_18 == IntPtr.Zero)
																					{
																						result = false;
																					}
																					else
																					{
																						<Module>.intptr_19 = GClass57.smethod_24(gstruct58_, gstruct128_, "STEAMVIDEO_INTERFACE_V002");
																						if (<Module>.intptr_19 == IntPtr.Zero)
																						{
																							result = false;
																						}
																						else
																						{
																							<Module>.intptr_20 = GClass57.smethod_23(gstruct58_, gstruct128_, "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
																							result = !(<Module>.intptr_20 == IntPtr.Zero);
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
		return result;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000025C0 File Offset: 0x000007C0
	internal static IntPtr smethod_2()
	{
		return <Module>.intptr_0;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000025D4 File Offset: 0x000007D4
	internal static IntPtr smethod_3()
	{
		return <Module>.intptr_1;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000025E8 File Offset: 0x000007E8
	internal static IntPtr smethod_4()
	{
		return <Module>.intptr_2;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000025FC File Offset: 0x000007FC
	internal static IntPtr smethod_5()
	{
		return <Module>.intptr_3;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002610 File Offset: 0x00000810
	internal static IntPtr smethod_6()
	{
		return <Module>.intptr_4;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002624 File Offset: 0x00000824
	internal static IntPtr smethod_7()
	{
		return <Module>.intptr_5;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002638 File Offset: 0x00000838
	internal static IntPtr smethod_8()
	{
		return <Module>.intptr_6;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000264C File Offset: 0x0000084C
	internal static IntPtr smethod_9()
	{
		return <Module>.intptr_7;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002660 File Offset: 0x00000860
	internal static IntPtr smethod_10()
	{
		return <Module>.intptr_8;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002674 File Offset: 0x00000874
	internal static IntPtr smethod_11()
	{
		return <Module>.intptr_9;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002688 File Offset: 0x00000888
	internal static IntPtr smethod_12()
	{
		return <Module>.intptr_10;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000269C File Offset: 0x0000089C
	internal static IntPtr smethod_13()
	{
		return <Module>.intptr_11;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000026B0 File Offset: 0x000008B0
	internal static IntPtr smethod_14()
	{
		return <Module>.intptr_12;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000026C4 File Offset: 0x000008C4
	internal static IntPtr smethod_15()
	{
		return <Module>.intptr_13;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000026D8 File Offset: 0x000008D8
	internal static IntPtr smethod_16()
	{
		return <Module>.intptr_14;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000026EC File Offset: 0x000008EC
	internal static IntPtr smethod_17()
	{
		return <Module>.intptr_15;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002700 File Offset: 0x00000900
	internal static IntPtr smethod_18()
	{
		return <Module>.intptr_16;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002714 File Offset: 0x00000914
	internal static IntPtr smethod_19()
	{
		return <Module>.intptr_17;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002728 File Offset: 0x00000928
	internal static IntPtr smethod_20()
	{
		return <Module>.intptr_18;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000273C File Offset: 0x0000093C
	internal static IntPtr smethod_21()
	{
		return <Module>.intptr_19;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002750 File Offset: 0x00000950
	internal static IntPtr smethod_22()
	{
		return <Module>.intptr_20;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002764 File Offset: 0x00000964
	internal static void smethod_23()
	{
		<Module>.smethod_24();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002778 File Offset: 0x00000978
	internal static void smethod_24()
	{
		<Module>.intptr_0 = IntPtr.Zero;
		<Module>.intptr_1 = IntPtr.Zero;
		<Module>.intptr_2 = IntPtr.Zero;
		<Module>.intptr_3 = IntPtr.Zero;
		<Module>.intptr_4 = IntPtr.Zero;
		<Module>.intptr_5 = IntPtr.Zero;
		<Module>.intptr_6 = IntPtr.Zero;
		<Module>.intptr_7 = IntPtr.Zero;
		<Module>.intptr_8 = IntPtr.Zero;
		<Module>.intptr_9 = IntPtr.Zero;
		<Module>.intptr_11 = IntPtr.Zero;
		<Module>.intptr_10 = IntPtr.Zero;
		<Module>.intptr_15 = IntPtr.Zero;
		<Module>.intptr_12 = IntPtr.Zero;
		<Module>.intptr_13 = IntPtr.Zero;
		<Module>.intptr_14 = IntPtr.Zero;
		<Module>.intptr_15 = IntPtr.Zero;
		<Module>.intptr_16 = IntPtr.Zero;
		<Module>.intptr_17 = IntPtr.Zero;
		<Module>.intptr_18 = IntPtr.Zero;
		<Module>.intptr_19 = IntPtr.Zero;
		<Module>.intptr_20 = IntPtr.Zero;
	}

	// Token: 0x04000001 RID: 1
	private static IntPtr intptr_0;

	// Token: 0x04000002 RID: 2
	private static IntPtr intptr_1;

	// Token: 0x04000003 RID: 3
	private static IntPtr intptr_2;

	// Token: 0x04000004 RID: 4
	private static IntPtr intptr_3;

	// Token: 0x04000005 RID: 5
	private static IntPtr intptr_4;

	// Token: 0x04000006 RID: 6
	private static IntPtr intptr_5;

	// Token: 0x04000007 RID: 7
	private static IntPtr intptr_6;

	// Token: 0x04000008 RID: 8
	private static IntPtr intptr_7;

	// Token: 0x04000009 RID: 9
	private static IntPtr intptr_8;

	// Token: 0x0400000A RID: 10
	private static IntPtr intptr_9;

	// Token: 0x0400000B RID: 11
	private static IntPtr intptr_10;

	// Token: 0x0400000C RID: 12
	private static IntPtr intptr_11;

	// Token: 0x0400000D RID: 13
	private static IntPtr intptr_12;

	// Token: 0x0400000E RID: 14
	private static IntPtr intptr_13;

	// Token: 0x0400000F RID: 15
	private static IntPtr intptr_14;

	// Token: 0x04000010 RID: 16
	private static IntPtr intptr_15;

	// Token: 0x04000011 RID: 17
	private static IntPtr intptr_16;

	// Token: 0x04000012 RID: 18
	private static IntPtr intptr_17;

	// Token: 0x04000013 RID: 19
	private static IntPtr intptr_18;

	// Token: 0x04000014 RID: 20
	private static IntPtr intptr_19;

	// Token: 0x04000015 RID: 21
	private static IntPtr intptr_20;
}
