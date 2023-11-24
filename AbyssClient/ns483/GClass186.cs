using System;
using System.IO;
using Newtonsoft.Json;

namespace ns483
{
	// Token: 0x0200033A RID: 826
	public class GClass186
	{
		// Token: 0x060046A7 RID: 18087 RVA: 0x00108E44 File Offset: 0x00107044
		internal static void smethod_0()
		{
			GClass186.smethod_3();
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x00108E58 File Offset: 0x00107058
		internal static void smethod_1()
		{
			GClass186.smethod_2();
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x00108E6C File Offset: 0x0010706C
		internal static void smethod_2()
		{
			Directory.CreateDirectory("_Unreal/PatchManager_Config");
			if (!File.Exists("_Unreal/PatchManager_Config//config.json"))
			{
				GClass186.gclass186_0 = new GClass186();
				GClass186.smethod_0();
			}
			else
			{
				GClass186.gclass186_0 = JsonConvert.DeserializeObject<GClass186>(File.ReadAllText("_Unreal/PatchManager_Config//config.json"));
				if (GClass186.gclass186_0 == null)
				{
					GClass186.gclass186_0 = new GClass186();
				}
				GClass186.smethod_0();
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00108F64 File Offset: 0x00107164
		internal static void smethod_3()
		{
			GClass186.smethod_5();
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x00108F78 File Offset: 0x00107178
		internal static void smethod_4()
		{
			GClass186.smethod_1();
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00108F8C File Offset: 0x0010718C
		internal static void smethod_5()
		{
			if (GClass186.gclass186_0 != null)
			{
				File.WriteAllText("_Unreal/PatchManager_Config//config.json", JsonConvert.SerializeObject(GClass186.gclass186_0, 1));
			}
		}

		// Token: 0x04001AC5 RID: 6853
		internal static GClass186 gclass186_0;

		// Token: 0x04001AC6 RID: 6854
		[JsonProperty("bQuestSpoof")]
		public bool bool_0 = false;

		// Token: 0x04001AC7 RID: 6855
		[JsonProperty("bHWIDSpoof")]
		public bool bool_1 = false;

		// Token: 0x04001AC8 RID: 6856
		[JsonProperty("HardwareID")]
		public string string_0 = string.Empty;

		// Token: 0x04001AC9 RID: 6857
		[JsonProperty("bDisableVRCLogging")]
		public bool bool_2 = false;

		// Token: 0x04001ACA RID: 6858
		[JsonProperty("bEarlyAdopterSpoof")]
		public bool bool_3 = true;

		// Token: 0x04001ACB RID: 6859
		[JsonProperty("bSupporterSpoof")]
		public bool bool_4 = true;

		// Token: 0x04001ACC RID: 6860
		[JsonProperty("bCanSeeAllUsersStatusSpoof")]
		public bool bool_5 = true;

		// Token: 0x04001ACD RID: 6861
		[JsonProperty("bCanSetStatusOfflineSpoof")]
		public bool bool_6 = false;

		// Token: 0x04001ACE RID: 6862
		[JsonProperty("bHasModerationPowersSpoof")]
		public bool bool_7 = false;

		// Token: 0x04001ACF RID: 6863
		[JsonProperty("bHasScriptingAccessSpoof")]
		public bool bool_8 = false;

		// Token: 0x04001AD0 RID: 6864
		[JsonProperty("bHasNoPowersSpoof")]
		public bool bool_9 = false;

		// Token: 0x04001AD1 RID: 6865
		[JsonProperty("bHasSuperPowersSpoof")]
		public bool bool_10 = false;

		// Token: 0x04001AD2 RID: 6866
		[JsonProperty("bHasVIPAccessSpoof")]
		public bool bool_11 = false;

		// Token: 0x04001AD3 RID: 6867
		[JsonProperty("bOfflineSpoof")]
		public bool bool_12 = false;

		// Token: 0x04001AD4 RID: 6868
		[JsonProperty("bMasterSpoof")]
		public bool bool_13 = false;

		// Token: 0x04001AD5 RID: 6869
		[JsonProperty("bAntiInstanceLock")]
		public bool bool_14 = true;

		// Token: 0x04001AD6 RID: 6870
		[JsonProperty("bUsePortalEnterConfirmation")]
		public bool bool_15 = true;
	}
}
