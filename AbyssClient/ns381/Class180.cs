using System;
using ns140;
using ns226;
using ns232;
using ns236;
using ns313;
using ns370;

namespace ns381
{
	// Token: 0x020002E7 RID: 743
	internal static class Class180
	{
		// Token: 0x06003F59 RID: 16217 RVA: 0x000EF5F8 File Offset: 0x000ED7F8
		internal static IntPtr smethod_0()
		{
			return Class180.intptr_2;
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x000EF60C File Offset: 0x000ED80C
		internal static bool smethod_1()
		{
			GStruct58 gstruct58_ = GClass82.smethod_1();
			GStruct128 gstruct128_ = GClass82.smethod_10();
			bool result;
			if (GStruct128.smethod_2(gstruct128_, GStruct128.smethod_0(0)))
			{
				result = false;
			}
			else
			{
				using (GClass78.GClass79 gclass = new GClass78.GClass79("SteamClient017"))
				{
					Class180.intptr_0 = Class177.SteamInternal_CreateInterface(gclass);
				}
				if (Class180.intptr_0 == IntPtr.Zero)
				{
					result = false;
				}
				else
				{
					Class180.intptr_1 = GClass100.smethod_11(gstruct58_, gstruct128_, "SteamGameServer012");
					if (Class180.intptr_1 == IntPtr.Zero)
					{
						result = false;
					}
					else
					{
						Class180.intptr_2 = GClass100.smethod_16(gstruct128_, "SteamUtils009");
						if (Class180.intptr_2 == IntPtr.Zero)
						{
							result = false;
						}
						else
						{
							Class180.intptr_3 = GClass100.smethod_34(gstruct58_, gstruct128_, "SteamNetworking005");
							if (Class180.intptr_3 == IntPtr.Zero)
							{
								result = false;
							}
							else
							{
								Class180.intptr_4 = GClass100.smethod_9(gstruct58_, gstruct128_, "SteamGameServerStats001");
								if (Class180.intptr_4 == IntPtr.Zero)
								{
									result = false;
								}
								else
								{
									Class180.intptr_5 = GClass100.smethod_25(gstruct58_, gstruct128_, "STEAMHTTP_INTERFACE_VERSION002");
									if (Class180.intptr_5 == IntPtr.Zero)
									{
										result = false;
									}
									else
									{
										Class180.intptr_6 = GClass100.smethod_31(gstruct58_, gstruct128_, "STEAMINVENTORY_INTERFACE_V002");
										if (Class180.intptr_6 == IntPtr.Zero)
										{
											result = false;
										}
										else
										{
											Class180.intptr_7 = GClass100.smethod_21(gstruct58_, gstruct128_, "STEAMUGC_INTERFACE_VERSION010");
											if (Class180.intptr_7 == IntPtr.Zero)
											{
												result = false;
											}
											else
											{
												Class180.intptr_8 = GClass100.smethod_10(gstruct58_, gstruct128_, "STEAMAPPS_INTERFACE_VERSION008");
												result = !(Class180.intptr_8 == IntPtr.Zero);
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

		// Token: 0x06003F5B RID: 16219 RVA: 0x000EF7C4 File Offset: 0x000ED9C4
		internal static void smethod_2()
		{
			Class180.smethod_3();
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x000EF7D8 File Offset: 0x000ED9D8
		internal static void smethod_3()
		{
			Class180.smethod_12();
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x000EF7EC File Offset: 0x000ED9EC
		internal static IntPtr smethod_4()
		{
			return Class180.intptr_8;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000EF800 File Offset: 0x000EDA00
		internal static IntPtr smethod_5()
		{
			return Class180.intptr_7;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x000EF814 File Offset: 0x000EDA14
		internal static IntPtr smethod_6()
		{
			return Class180.intptr_6;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x000EF828 File Offset: 0x000EDA28
		internal static IntPtr smethod_7()
		{
			return Class180.intptr_3;
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000EF83C File Offset: 0x000EDA3C
		internal static IntPtr smethod_8()
		{
			return Class180.intptr_4;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x000EF850 File Offset: 0x000EDA50
		internal static IntPtr smethod_9()
		{
			return Class180.intptr_5;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x000EF864 File Offset: 0x000EDA64
		internal static IntPtr smethod_10()
		{
			return Class180.intptr_0;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x000EF878 File Offset: 0x000EDA78
		internal static IntPtr smethod_11()
		{
			return Class180.intptr_1;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000EF88C File Offset: 0x000EDA8C
		internal static void smethod_12()
		{
			Class180.intptr_0 = IntPtr.Zero;
			Class180.intptr_1 = IntPtr.Zero;
			Class180.intptr_2 = IntPtr.Zero;
			Class180.intptr_3 = IntPtr.Zero;
			Class180.intptr_4 = IntPtr.Zero;
			Class180.intptr_5 = IntPtr.Zero;
			Class180.intptr_6 = IntPtr.Zero;
			Class180.intptr_7 = IntPtr.Zero;
			Class180.intptr_8 = IntPtr.Zero;
		}

		// Token: 0x0400185D RID: 6237
		private static IntPtr intptr_0;

		// Token: 0x0400185E RID: 6238
		private static IntPtr intptr_1;

		// Token: 0x0400185F RID: 6239
		private static IntPtr intptr_2;

		// Token: 0x04001860 RID: 6240
		private static IntPtr intptr_3;

		// Token: 0x04001861 RID: 6241
		private static IntPtr intptr_4;

		// Token: 0x04001862 RID: 6242
		private static IntPtr intptr_5;

		// Token: 0x04001863 RID: 6243
		private static IntPtr intptr_6;

		// Token: 0x04001864 RID: 6244
		private static IntPtr intptr_7;

		// Token: 0x04001865 RID: 6245
		private static IntPtr intptr_8;
	}
}
