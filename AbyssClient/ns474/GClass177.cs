using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns185;
using ns241;
using ns295;
using ns302;
using ns425;
using ns440;
using ns441;
using ns444;
using ns449;
using ns459;
using ns478;
using ns56;
using ns57;
using ns59;
using ns62;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace ns474
{
	// Token: 0x0200032D RID: 813
	public class GClass177 : GClass130
	{
		// Token: 0x060041BF RID: 16831 RVA: 0x000FA0A8 File Offset: 0x000F82A8
		private void method_2()
		{
			this.method_951();
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x000FA0BC File Offset: 0x000F82BC
		private void method_3()
		{
			this.method_235(false, true);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x000FA0D4 File Offset: 0x000F82D4
		private void method_4()
		{
			this.method_520();
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x000FA0E8 File Offset: 0x000F82E8
		internal void method_5()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_345(apiAvatar.id, apiAvatar.name);
				this.method_371();
			}
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x000FA12C File Offset: 0x000F832C
		internal void method_6()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_264(apiAvatar.authorId);
				this.method_930();
			}
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x000FA16C File Offset: 0x000F836C
		private void method_7()
		{
			this.method_76(0);
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x000FA180 File Offset: 0x000F8380
		private void method_8()
		{
			this.method_1005();
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x000FA194 File Offset: 0x000F8394
		internal void method_9(int int_3)
		{
			this.method_515(int_3);
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x000FA1A8 File Offset: 0x000F83A8
		private void method_10(float float_7)
		{
			this.float_0 = float_7;
			this.method_506("Variables_Speed", false);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x000FA1C8 File Offset: 0x000F83C8
		private void method_11()
		{
			this.method_695();
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x000FA1DC File Offset: 0x000F83DC
		internal void method_12()
		{
			this.method_780();
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x000FA1F0 File Offset: 0x000F83F0
		internal void method_13()
		{
			this.method_697();
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x000FA204 File Offset: 0x000F8404
		[CompilerGenerated]
		private void method_14()
		{
			this.method_64();
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000FA218 File Offset: 0x000F8418
		internal void method_15()
		{
			this.method_448();
		}

		// Token: 0x060041CD RID: 16845 RVA: 0x000FA22C File Offset: 0x000F842C
		private void method_16()
		{
			this.method_174();
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x000FA240 File Offset: 0x000F8440
		private void method_17()
		{
			this.method_145();
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x000FA254 File Offset: 0x000F8454
		private void method_18()
		{
			this.method_779(GClass84.GEnum47.const_1);
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000FA268 File Offset: 0x000F8468
		internal void method_19()
		{
			this.method_324();
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x000FA27C File Offset: 0x000F847C
		internal void method_20()
		{
			GClass84.gclass181_0.string_1 = GClass84.smethod_105().Method_Public_get_String_2();
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x000FA2A0 File Offset: 0x000F84A0
		internal void method_21()
		{
			this.method_595();
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x000FA2B4 File Offset: 0x000F84B4
		private void method_22()
		{
			this.method_192();
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x000FA2C8 File Offset: 0x000F84C8
		internal void method_23(int int_3)
		{
			this.method_464(int_3);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x000FA2DC File Offset: 0x000F84DC
		internal void method_24()
		{
			this.method_985();
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x000FA2F0 File Offset: 0x000F84F0
		private void method_25()
		{
			this.method_559();
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x000FA304 File Offset: 0x000F8504
		internal void method_26()
		{
			this.method_201();
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x000FA318 File Offset: 0x000F8518
		[CompilerGenerated]
		private void method_27()
		{
			this.method_582();
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x000FA32C File Offset: 0x000F852C
		internal void method_28()
		{
			this.method_99();
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x000FA340 File Offset: 0x000F8540
		internal void method_29()
		{
			this.method_401();
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x000FA354 File Offset: 0x000F8554
		private void method_30()
		{
			this.method_412();
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x000FA368 File Offset: 0x000F8568
		[CompilerGenerated]
		private void method_31()
		{
			this.method_392();
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x000FA37C File Offset: 0x000F857C
		[CompilerGenerated]
		private void method_32()
		{
			this.method_570();
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x000FA390 File Offset: 0x000F8590
		private void method_33()
		{
			this.method_343(GClass144.GEnum35.const_0);
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000FA3A4 File Offset: 0x000F85A4
		internal void method_34()
		{
			this.method_650();
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000FA3B8 File Offset: 0x000F85B8
		private void method_35()
		{
			this.method_729();
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000FA3CC File Offset: 0x000F85CC
		internal void method_36()
		{
			GClass84.gclass141_0.method_120(GClass84.smethod_1309());
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000FA3EC File Offset: 0x000F85EC
		internal void method_37()
		{
			if (this.bool_2)
			{
				GClass177.gclass30_6 = new GClass30(GClass177.gclass99_22, 1f, 0f, "Get ID", new Action(this.method_627), "Get ID.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_3)
			{
				GClass177.gclass30_7 = new GClass30(GClass177.gclass99_22, 2f, 0f, "Get Steam ID", new Action(this.method_107), "Get Steam ID.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_7.method_9(false);
			}
			if (this.bool_4)
			{
				GClass177.gclass30_8 = new GClass30(GClass177.gclass99_22, 3f, 0f, "Get User ID", new Action(this.method_78), "Get User ID.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_16)
			{
				GClass177.gclass30_19 = new GClass30(GClass177.gclass99_22, 4f, 0f, "Get IP", new Action(this.method_143), "Get IP.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_19.method_9(false);
			}
			if (this.bool_5)
			{
				GClass177.gclass30_9 = new GClass30(GClass177.gclass99_22, 1f, 1f, "Get Tags", new Action(this.method_956), "Get Tags.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_7)
			{
				GClass177.gclass30_12 = new GClass30(GClass177.gclass99_22, 2f, 1f, "Get Nameplate Location", new Action(this.method_549), "Get Nameplate Location.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_11)
			{
				GClass177.gclass30_18 = new GClass30(GClass177.gclass99_22, 3f, 1f, "Get Strings", new Action(this.method_984), "Get Strings.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_21)
			{
				GClass177.gclass30_31 = new GClass30(GClass177.gclass99_22, 4f, 1f, "Log APIUser Variables", new Action(this.method_972), "Log APIUser Variables.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_14)
			{
				GClass177.gclass30_4 = new GClass30(GClass177.gclass99_22, 1f, 2f, "Copy Avatar ID", new Action(this.method_315), "Copy Avatar ID.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_15)
			{
				GClass177.gclass30_5 = new GClass30(GClass177.gclass99_22, 2f, 2f, "Copy Photon ID", new Action(this.method_959), "Copy Photon ID.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x000FA708 File Offset: 0x000F8908
		[CompilerGenerated]
		private void method_38()
		{
			this.method_709();
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000FA71C File Offset: 0x000F891C
		internal void method_39()
		{
			if (this.bool_22)
			{
				GClass177.gclass30_32 = new GClass30(GClass177.gclass99_26, 1f, 0f, "Reload Avatar", new Action(this.method_725), "Reload Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_1)
			{
				GClass177.gclass30_1 = new GClass30(GClass177.gclass99_26, 2f, 0f, "Download Avatar", new Action(this.method_161), "Download Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_10)
			{
				GClass177.gclass30_17 = new GClass30(GClass177.gclass99_26, 3f, 0f, "Modify Avatar", new Action(this.method_510), "Modify Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_12)
			{
				GClass177.gclass30_2 = new GClass30(GClass177.gclass99_26, 4f, 0f, "Force Clone Avatar", new Action(this.method_376), "Force Clone Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_18 && GClass84.gclass138_0 != null)
			{
				GClass177.gclass30_22 = new GClass30(GClass177.gclass99_26, 2f, 1f, "Reupload Avatar", new Action(this.method_243), "Reupload Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_19)
			{
				GClass177.gclass30_23 = new GClass30(GClass177.gclass99_26, 1f, 1f, "Get Avatar Info", new Action(this.method_115), "Get Avatar Info.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_13)
			{
				GClass177.gclass30_3 = new GClass30(GClass177.gclass99_26, 3f, 1f, "Clone Avatar", new Action(this.method_631), "Clone Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x000FA948 File Offset: 0x000F8B48
		internal void method_40()
		{
			this.method_870();
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x000FA95C File Offset: 0x000F8B5C
		[CompilerGenerated]
		private void method_41()
		{
			this.method_197();
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x000FA970 File Offset: 0x000F8B70
		[CompilerGenerated]
		private void method_42()
		{
			this.method_384();
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x000FA984 File Offset: 0x000F8B84
		internal void method_43()
		{
			GClass84.smethod_1028(GClass84.smethod_105());
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x000FA99C File Offset: 0x000F8B9C
		private void method_44()
		{
			this.method_454();
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x000FA9B0 File Offset: 0x000F8BB0
		internal void method_45()
		{
			this.method_172();
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x000FA9C4 File Offset: 0x000F8BC4
		private void method_46()
		{
			this.method_326();
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x000FA9D8 File Offset: 0x000F8BD8
		private void method_47()
		{
			this.method_293();
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x000FA9EC File Offset: 0x000F8BEC
		internal void method_48()
		{
			int num = GClass84.smethod_741(GClass177.list_1.Count, GClass177.list_0.Count - GClass177.int_0);
			int i;
			for (i = 0; i < num; i++)
			{
				if (i >= 0 && i < GClass177.list_0.Count)
				{
					GClass181.GStruct270 gstruct = GClass177.list_0[i + GClass177.int_0];
					GClass177.list_1[i].method_30(gstruct.string_0);
					GClass177.list_1[i].method_10(gstruct.string_1);
					GClass177.list_1[i].method_11(true);
				}
				else
				{
					GClass177.list_1[i].method_11(false);
				}
			}
			while (i < GClass177.list_1.Count)
			{
				GClass177.list_1[i].method_11(false);
				i++;
			}
			if (GClass177.int_0 <= 0)
			{
				GClass177.gclass30_136.method_9(false);
			}
			else
			{
				GClass177.gclass30_136.method_9(true);
			}
			if (GClass177.int_0 >= this.method_118())
			{
				GClass177.gclass30_135.method_9(false);
			}
			else
			{
				GClass177.gclass30_135.method_9(true);
			}
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x000FAB18 File Offset: 0x000F8D18
		internal int method_49(int int_3)
		{
			return int_3 + GClass177.int_1;
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x000FAB30 File Offset: 0x000F8D30
		private void method_50()
		{
			this.method_480();
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x000FAB44 File Offset: 0x000F8D44
		internal void method_51()
		{
			this.method_284();
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x000FAB58 File Offset: 0x000F8D58
		internal void method_52()
		{
			GClass177.gclass30_131 = new GClass30(GClass177.gclass99_20, 1f, -0.25f, 1f, 0.5f, "+9", new Action(this.method_389), "Increment Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_130 = new GClass30(GClass177.gclass99_20, 1f, 0.25f, 1f, 0.5f, "+3", new Action(this.method_987), "Increment Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_129 = new GClass30(GClass177.gclass99_20, 1f, 0.75f, 1f, 0.5f, "Speed+1", new Action(this.method_857), "Increment Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_132 = new GClass30(GClass177.gclass99_20, 1f, 1.25f, 1f, 0.5f, "Speed-1", new Action(this.method_32), "Decrement Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_133 = new GClass30(GClass177.gclass99_20, 1f, 1.75f, 1f, 0.5f, "-3", new Action(this.method_733), "Decrement Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_134 = new GClass30(GClass177.gclass99_20, 1f, 2.25f, 1f, 0.5f, "-9", new Action(this.method_783), "Decrement Fluctuations Speed 2.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_20;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_8 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x000FAD70 File Offset: 0x000F8F70
		[CompilerGenerated]
		private void method_53()
		{
			this.method_396();
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x000FAD84 File Offset: 0x000F8F84
		internal void method_54()
		{
			Player player_ = GClass84.smethod_126();
			APIUser apiuser = GClass84.smethod_821();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				string[] array = new string[7];
				array[0] = apiuser.displayName;
				array[1] = " ";
				array[2] = "has";
				array[3] = " ";
				array[4] = "IP";
				array[5] = " ";
				int num = 6;
				IPAddress ipaddress = GClass84.smethod_1456(player_);
				array[num] = ((ipaddress != null) ? ipaddress.ToString() : null);
				GClass70.smethod_38(string.Concat(array), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000FAE08 File Offset: 0x000F9008
		internal void method_55()
		{
			this.method_748();
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000FAE1C File Offset: 0x000F901C
		[CompilerGenerated]
		private void method_56()
		{
			this.method_525();
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x000FAE30 File Offset: 0x000F9030
		[CompilerGenerated]
		private void method_57()
		{
			this.method_827();
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x000FAE44 File Offset: 0x000F9044
		internal void method_58()
		{
			this.method_152();
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x000FAE58 File Offset: 0x000F9058
		private void method_59()
		{
			this.method_735();
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000FAE6C File Offset: 0x000F906C
		private void method_60(float float_7)
		{
			this.method_188(float_7);
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x000FAE80 File Offset: 0x000F9080
		private void method_61(float float_7)
		{
			this.method_422(float_7);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000FAE94 File Offset: 0x000F9094
		private void method_62()
		{
			this.method_982();
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000FAEA8 File Offset: 0x000F90A8
		private void method_63()
		{
			this.method_300(0.2f);
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000FAEC0 File Offset: 0x000F90C0
		private void method_64()
		{
			this.method_659();
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x000FAED4 File Offset: 0x000F90D4
		private void method_65()
		{
			this.method_240();
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x000FAEE8 File Offset: 0x000F90E8
		private void method_66(float float_7)
		{
			this.method_949(float_7);
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x000FAEFC File Offset: 0x000F90FC
		private void method_67()
		{
			this.method_305(-9f);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000FAF14 File Offset: 0x000F9114
		private void method_68(float float_7)
		{
			this.method_60(float_7);
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x000FAF28 File Offset: 0x000F9128
		internal void method_69(int int_3)
		{
			this.method_72(int_3);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x000FAF3C File Offset: 0x000F913C
		internal void method_70(bool bool_26 = false, bool bool_27 = false)
		{
			this.method_443(bool_26, bool_27);
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x000FAF54 File Offset: 0x000F9154
		private void method_71()
		{
			this.method_442();
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x000FAF68 File Offset: 0x000F9168
		internal void method_72(int int_3)
		{
			if (GClass177.int_1 < 0)
			{
				GClass177.int_1 = 0;
			}
			else if (GClass177.int_1 > this.method_837())
			{
				GClass177.int_1 = this.method_837();
			}
			else
			{
				GClass177.int_1 = GClass84.smethod_1551(GClass177.int_1 + int_3, 0, this.method_837());
			}
			this.method_128();
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x000FAFC4 File Offset: 0x000F91C4
		internal void method_73()
		{
			this.method_183();
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x000FAFD8 File Offset: 0x000F91D8
		[CompilerGenerated]
		private void method_74()
		{
			this.method_853();
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x000FAFEC File Offset: 0x000F91EC
		[CompilerGenerated]
		private void method_75()
		{
			this.method_512();
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x000FB000 File Offset: 0x000F9200
		internal void method_76(int int_3)
		{
			this.method_434(int_3);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x000FB014 File Offset: 0x000F9214
		private void method_77()
		{
			this.method_506("Variables_TeleportPosition", false);
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x000FB030 File Offset: 0x000F9230
		[CompilerGenerated]
		private void method_78()
		{
			this.method_463();
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x000FB044 File Offset: 0x000F9244
		private void method_79()
		{
			this.method_300(-0.2f);
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000FB05C File Offset: 0x000F925C
		[CompilerGenerated]
		private void method_80()
		{
			this.method_138();
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x000FB070 File Offset: 0x000F9270
		internal void method_81()
		{
			this.method_5();
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x000FB084 File Offset: 0x000F9284
		private void method_82()
		{
			this.method_558();
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x000FB098 File Offset: 0x000F9298
		private void method_83(float float_7)
		{
			this.method_723(float_7);
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x000FB0AC File Offset: 0x000F92AC
		[CompilerGenerated]
		private void method_84()
		{
			this.method_824();
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x000FB0C0 File Offset: 0x000F92C0
		private void method_85(float float_7)
		{
			this.method_435(float_7);
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x000FB0D4 File Offset: 0x000F92D4
		internal void method_86()
		{
			this.method_397();
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000FB0E8 File Offset: 0x000F92E8
		internal void method_87()
		{
			GClass84.gclass141_0.method_35(GClass84.smethod_1309());
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x000FB108 File Offset: 0x000F9308
		internal void method_88()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_25(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x000FB140 File Offset: 0x000F9340
		private void method_89()
		{
			this.method_208();
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x000FB154 File Offset: 0x000F9354
		private void method_90()
		{
			this.method_752(5);
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000FB168 File Offset: 0x000F9368
		private void method_91()
		{
			this.method_941();
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x000FB17C File Offset: 0x000F937C
		internal void method_92()
		{
			GClass84.smethod_1715(GClass84.smethod_105());
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x000FB194 File Offset: 0x000F9394
		private void method_93()
		{
			this.method_973();
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000FB1A8 File Offset: 0x000F93A8
		[CompilerGenerated]
		private void method_94()
		{
			this.method_452();
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000FB1BC File Offset: 0x000F93BC
		internal void method_95(int int_3)
		{
			if (GClass177.int_0 < 0)
			{
				GClass177.int_0 = 0;
			}
			else if (GClass177.int_0 > this.method_118())
			{
				GClass177.int_0 = this.method_118();
			}
			else
			{
				GClass177.int_0 = GClass84.smethod_1551(GClass177.int_0 + int_3, 0, this.method_118());
			}
			this.method_402();
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x000FB218 File Offset: 0x000F9418
		internal void method_96()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.smethod_589(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_1, this.genum35_0, GClass144.GEnum36.const_0, this.float_0, this.float_1, this.float_2, this.float_3, this.float_4, this.float_5, this.float_6);
			}
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x000FB2B0 File Offset: 0x000F94B0
		private void method_97()
		{
			this.method_112();
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x000FB2C4 File Offset: 0x000F94C4
		[CompilerGenerated]
		private void method_98()
		{
			this.method_295();
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x000FB2D8 File Offset: 0x000F94D8
		internal void method_99()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[] {",
				"Event",
				"Spam",
				"_",
				"Spawn",
				"Emoji",
				"RPC",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x000FB34C File Offset: 0x000F954C
		internal void method_100()
		{
			this.method_81();
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x000FB360 File Offset: 0x000F9560
		internal void method_101()
		{
			this.method_205();
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x000FB374 File Offset: 0x000F9574
		internal void method_102()
		{
			this.method_694();
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x000FB388 File Offset: 0x000F9588
		private void method_103()
		{
			this.method_51();
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x000FB39C File Offset: 0x000F959C
		[CompilerGenerated]
		private void method_104()
		{
			this.method_50();
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000FB3B0 File Offset: 0x000F95B0
		private void method_105()
		{
			this.method_693();
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x000FB3C4 File Offset: 0x000F95C4
		private void method_106()
		{
			this.method_186();
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x000FB3D8 File Offset: 0x000F95D8
		[CompilerGenerated]
		private void method_107()
		{
			this.method_203();
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x000FB3EC File Offset: 0x000F95EC
		private void method_108()
		{
			this.method_880();
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x000FB400 File Offset: 0x000F9600
		[CompilerGenerated]
		private void method_109()
		{
			this.method_884();
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x000FB414 File Offset: 0x000F9614
		[CompilerGenerated]
		private void method_110()
		{
			this.method_431();
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x000FB428 File Offset: 0x000F9628
		[CompilerGenerated]
		private void method_111()
		{
			this.method_141();
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x000FB43C File Offset: 0x000F963C
		internal void method_112()
		{
			this.method_955();
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x000FB450 File Offset: 0x000F9650
		internal void method_113()
		{
			GClass84.gclass141_0.method_150(GClass84.smethod_977(GClass84.smethod_772(), ""));
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x000FB478 File Offset: 0x000F9678
		private void method_114()
		{
			this.method_61(1f);
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x000FB490 File Offset: 0x000F9690
		[CompilerGenerated]
		private void method_115()
		{
			this.method_894();
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000FB4A4 File Offset: 0x000F96A4
		private void method_116()
		{
			this.method_756();
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x000FB4B8 File Offset: 0x000F96B8
		internal void method_117()
		{
			this.method_349();
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x000FB4CC File Offset: 0x000F96CC
		internal int method_118()
		{
			return GClass84.smethod_1690(GClass177.list_0.Count - GClass177.list_1.Count, 0);
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x000FB4F8 File Offset: 0x000F96F8
		internal void method_119(int int_3)
		{
			this.method_297(this.method_266(int_3));
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x000FB514 File Offset: 0x000F9714
		private void method_120()
		{
			this.method_506("Variables_OrbitType", false);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x000FB530 File Offset: 0x000F9730
		internal void method_121()
		{
			this.method_766();
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x000FB544 File Offset: 0x000F9744
		private void method_122()
		{
			this.method_11();
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x000FB558 File Offset: 0x000F9758
		[CompilerGenerated]
		private void method_123()
		{
			this.method_637();
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x000FB56C File Offset: 0x000F976C
		internal void method_124(int int_3)
		{
			if (GClass177.int_2 < 0)
			{
				GClass177.int_2 = 0;
			}
			else if (GClass177.int_2 > this.method_136())
			{
				GClass177.int_2 = this.method_136();
			}
			else
			{
				GClass177.int_2 = GClass84.smethod_1551(GClass177.int_2 + int_3, 0, this.method_136());
			}
			this.method_900();
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x000FB5C8 File Offset: 0x000F97C8
		internal void method_125()
		{
			string text = GClass84.smethod_778();
			if (string.IsNullOrEmpty(text))
			{
				GClass177.gclass30_45.method_11(false);
				GClass177.gclass30_46.method_11(false);
			}
			else if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.list_27, text, ""))
			{
				GClass177.gclass30_45.method_11(false);
				GClass177.gclass30_46.method_11(true);
			}
			else
			{
				GClass177.gclass30_45.method_11(true);
				GClass177.gclass30_46.method_11(false);
			}
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x000FB640 File Offset: 0x000F9840
		[CompilerGenerated]
		private void method_126()
		{
			this.method_904();
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x000FB654 File Offset: 0x000F9854
		internal void method_127()
		{
			this.method_420();
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x000FB668 File Offset: 0x000F9868
		internal void method_128()
		{
			this.method_344();
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x000FB67C File Offset: 0x000F987C
		[CompilerGenerated]
		private void method_129()
		{
			this.method_336();
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x000FB690 File Offset: 0x000F9890
		[CompilerGenerated]
		private void method_130()
		{
			this.method_35();
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x000FB6A4 File Offset: 0x000F98A4
		[CompilerGenerated]
		private void method_131()
		{
			this.method_689();
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x000FB6B8 File Offset: 0x000F98B8
		private void method_132()
		{
			this.method_752(6);
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x000FB6CC File Offset: 0x000F98CC
		internal void method_133()
		{
			this.method_211();
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x000FB6E0 File Offset: 0x000F98E0
		internal void method_134()
		{
			this.method_556();
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x000FB6F4 File Offset: 0x000F98F4
		private void method_135()
		{
			this.method_560();
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x000FB708 File Offset: 0x000F9908
		internal int method_136()
		{
			return GClass84.smethod_1690(GClass177.list_3.Count - GClass177.list_4.Count, 0);
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x000FB734 File Offset: 0x000F9934
		internal void method_137()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_173(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x000FB76C File Offset: 0x000F996C
		private void method_138()
		{
			this.method_450();
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x000FB780 File Offset: 0x000F9980
		private void method_139()
		{
			this.method_779(GClass84.GEnum47.const_2);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x000FB794 File Offset: 0x000F9994
		internal void method_140()
		{
			this.method_791();
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000FB7A8 File Offset: 0x000F99A8
		private void method_141()
		{
			this.method_307();
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000FB7BC File Offset: 0x000F99BC
		[CompilerGenerated]
		private void method_142()
		{
			this.method_925();
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x000FB7D0 File Offset: 0x000F99D0
		[CompilerGenerated]
		private void method_143()
		{
			this.method_319();
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x000FB7E4 File Offset: 0x000F99E4
		private void method_144(float float_7)
		{
			this.method_589(this.float_0 + float_7);
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x000FB800 File Offset: 0x000F9A00
		private void method_145()
		{
			this.method_506("Variables_Angle", false);
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x000FB81C File Offset: 0x000F9A1C
		private void method_146()
		{
			this.method_617();
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x000FB830 File Offset: 0x000F9A30
		[CompilerGenerated]
		private void method_147()
		{
			this.method_1011();
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x000FB844 File Offset: 0x000F9A44
		private void method_148()
		{
			this.method_773();
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x000FB858 File Offset: 0x000F9A58
		[CompilerGenerated]
		private void method_149()
		{
			this.method_17();
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x000FB86C File Offset: 0x000F9A6C
		[CompilerGenerated]
		private void method_150()
		{
			this.method_809();
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x000FB880 File Offset: 0x000F9A80
		[CompilerGenerated]
		private void method_151()
		{
			this.method_414();
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x000FB894 File Offset: 0x000F9A94
		internal void method_152()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_49(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x000FB8CC File Offset: 0x000F9ACC
		private void method_153()
		{
			this.method_155();
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x000FB8E0 File Offset: 0x000F9AE0
		private void method_154()
		{
			this.method_12();
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000FB8F4 File Offset: 0x000F9AF4
		internal void method_155()
		{
			this.method_747();
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x000FB908 File Offset: 0x000F9B08
		internal void method_156()
		{
			this.method_127();
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x000FB91C File Offset: 0x000F9B1C
		private void method_157()
		{
			this.method_16();
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x000FB930 File Offset: 0x000F9B30
		internal void method_158()
		{
			this.method_855();
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x000FB944 File Offset: 0x000F9B44
		internal void method_159(GClass84.GEnum47 genum47_1)
		{
			this.genum47_0 = genum47_1;
			this.method_506("Variables_TeleportPosition", false);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x000FB964 File Offset: 0x000F9B64
		[CompilerGenerated]
		private void method_160()
		{
			this.method_902();
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x000FB978 File Offset: 0x000F9B78
		[CompilerGenerated]
		private void method_161()
		{
			this.method_967();
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x000FB98C File Offset: 0x000F9B8C
		[CompilerGenerated]
		private void method_162()
		{
			this.method_562();
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x000FB9A0 File Offset: 0x000F9BA0
		[CompilerGenerated]
		private void method_163()
		{
			this.method_409();
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x000FB9B4 File Offset: 0x000F9BB4
		internal void method_164()
		{
			GClass177.gclass30_125 = new GClass30(GClass177.gclass99_19, 1f, -0.25f, 1f, 0.5f, "+9", new Action(this.method_210), "Increment Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_124 = new GClass30(GClass177.gclass99_19, 1f, 0.25f, 1f, 0.5f, "+3", new Action(this.method_222), "Increment Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_123 = new GClass30(GClass177.gclass99_19, 1f, 0.75f, 1f, 0.5f, "Speed+1", new Action(this.method_845), "Increment Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_126 = new GClass30(GClass177.gclass99_19, 1f, 1.25f, 1f, 0.5f, "Speed-1", new Action(this.method_964), "Decrement Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_127 = new GClass30(GClass177.gclass99_19, 1f, 1.75f, 1f, 0.5f, "-3", new Action(this.method_357), "Decrement Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_128 = new GClass30(GClass177.gclass99_19, 1f, 2.25f, 1f, 0.5f, "-9", new Action(this.method_57), "Decrement Fluctuations Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_19;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_7 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x000FBBCC File Offset: 0x000F9DCC
		internal void method_165()
		{
			this.method_649();
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x000FBBE0 File Offset: 0x000F9DE0
		internal void method_166()
		{
			GClass84.gclass148_0.method_64(GClass84.smethod_778());
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000FBC00 File Offset: 0x000F9E00
		private void method_167()
		{
			this.method_460();
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x000FBC14 File Offset: 0x000F9E14
		internal void method_168()
		{
			this.method_394();
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x000FBC28 File Offset: 0x000F9E28
		[CompilerGenerated]
		private void method_169()
		{
			this.method_544();
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x000FBC3C File Offset: 0x000F9E3C
		private void method_170()
		{
			this.method_687();
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x000FBC50 File Offset: 0x000F9E50
		private void method_171()
		{
			this.method_675();
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x000FBC64 File Offset: 0x000F9E64
		internal void method_172()
		{
			GClass177.gclass30_95 = new GClass30(GClass177.gclass99_14, 1f, -0.25f, 1f, 0.5f, "+0.5", new Action(this.method_441), "Increment Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_94 = new GClass30(GClass177.gclass99_14, 1f, 0.25f, 1f, 0.5f, "+0.2", new Action(this.method_250), "Increment Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_93 = new GClass30(GClass177.gclass99_14, 1f, 0.75f, 1f, 0.5f, "Speed+0.05", new Action(this.method_795), "Increment Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_96 = new GClass30(GClass177.gclass99_14, 1f, 1.25f, 1f, 0.5f, "Speed-0.05", new Action(this.method_175), "Decrement Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_97 = new GClass30(GClass177.gclass99_14, 1f, 1.75f, 1f, 0.5f, "-0.2", new Action(this.method_527), "Decrement Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_98 = new GClass30(GClass177.gclass99_14, 1f, 2.25f, 1f, 0.5f, "-0.5", new Action(this.method_867), "Decrement Speed.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_14;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_2 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x000FBE7C File Offset: 0x000FA07C
		private void method_173()
		{
			this.method_468();
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x000FBE90 File Offset: 0x000FA090
		internal void method_174()
		{
			this.method_754();
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x000FBEA4 File Offset: 0x000FA0A4
		[CompilerGenerated]
		private void method_175()
		{
			this.method_518();
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000FBEB8 File Offset: 0x000FA0B8
		private void method_176()
		{
			this.method_752(0);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x000FBECC File Offset: 0x000FA0CC
		private void method_177()
		{
			this.method_981();
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x000FBEE0 File Offset: 0x000FA0E0
		[CompilerGenerated]
		private void method_178()
		{
			this.method_677();
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000FBEF4 File Offset: 0x000FA0F4
		internal void method_179()
		{
			try
			{
				this.method_713();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000FBF2C File Offset: 0x000FA12C
		internal void method_180()
		{
			this.method_590();
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x000FBF40 File Offset: 0x000FA140
		private void method_181()
		{
			this.method_836(-9f);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x000FBF58 File Offset: 0x000FA158
		private void method_182()
		{
			this.method_404();
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000FBF6C File Offset: 0x000FA16C
		internal void method_183()
		{
			this.method_321();
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000FBF80 File Offset: 0x000FA180
		internal void method_184()
		{
			this.method_279();
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x000FBF94 File Offset: 0x000FA194
		private void method_185()
		{
			this.method_906(-9f);
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x000FBFAC File Offset: 0x000FA1AC
		private void method_186()
		{
			this.method_218(6);
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
		private void method_187()
		{
			this.method_305(9f);
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x000FBFD8 File Offset: 0x000FA1D8
		private void method_188(float float_7)
		{
			this.float_6 = float_7;
			this.method_506("Variables_FluctuationsSpeed2", false);
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x000FBFF8 File Offset: 0x000FA1F8
		[CompilerGenerated]
		private void method_189()
		{
			this.method_502();
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x000FC00C File Offset: 0x000FA20C
		private void method_190()
		{
			this.method_526();
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x000FC020 File Offset: 0x000FA220
		[CompilerGenerated]
		private void method_191()
		{
			this.method_338();
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x000FC034 File Offset: 0x000FA234
		private void method_192()
		{
			this.method_506("Variables_Fluctuations", false);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x000FC050 File Offset: 0x000FA250
		internal void method_193()
		{
			this.method_282();
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000FC064 File Offset: 0x000FA264
		private void method_194()
		{
			this.method_781();
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000FC078 File Offset: 0x000FA278
		internal void method_195()
		{
			this.method_611();
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x000FC08C File Offset: 0x000FA28C
		private void method_196()
		{
			this.method_487();
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x000FC0A0 File Offset: 0x000FA2A0
		private void method_197()
		{
			this.method_232();
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x000FC0B4 File Offset: 0x000FA2B4
		[CompilerGenerated]
		private void method_198()
		{
			this.method_93();
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x000FC0C8 File Offset: 0x000FA2C8
		[CompilerGenerated]
		private void method_199()
		{
			this.method_59();
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x000FC0DC File Offset: 0x000FA2DC
		private void method_200()
		{
			this.method_168();
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x000FC0F0 File Offset: 0x000FA2F0
		internal void method_201()
		{
			GClass84.gclass184_0.method_19(GClass84.smethod_772());
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000FC10C File Offset: 0x000FA30C
		private void method_202()
		{
			this.method_648();
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x000FC120 File Offset: 0x000FA320
		private void method_203()
		{
			this.method_462();
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x000FC134 File Offset: 0x000FA334
		internal void method_204()
		{
			this.method_458();
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x000FC148 File Offset: 0x000FA348
		internal void method_205()
		{
			this.method_688();
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x000FC15C File Offset: 0x000FA35C
		internal void method_206()
		{
			GClass84.gclass148_0.method_17(GClass84.smethod_778());
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000FC178 File Offset: 0x000FA378
		[CompilerGenerated]
		private void method_207()
		{
			this.method_714();
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000FC18C File Offset: 0x000FA38C
		private void method_208()
		{
			this.method_61(-3f);
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x000FC1A4 File Offset: 0x000FA3A4
		internal void method_209()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.smethod_637(GClass84.smethod_165(vrcplayer), true);
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000FC1D0 File Offset: 0x000FA3D0
		[CompilerGenerated]
		private void method_210()
		{
			this.method_44();
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x000FC1E4 File Offset: 0x000FA3E4
		internal void method_211()
		{
			GClass84.gclass184_0.method_12(GClass84.smethod_772());
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x000FC200 File Offset: 0x000FA400
		internal void method_212()
		{
			this.method_121();
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x000FC214 File Offset: 0x000FA414
		private void method_213()
		{
			this.method_135();
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x000FC228 File Offset: 0x000FA428
		internal void method_214(bool bool_26 = false, bool bool_27 = false)
		{
			this.method_996(bool_26, bool_27);
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000FC240 File Offset: 0x000FA440
		internal void method_215()
		{
			this.method_55();
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000FC254 File Offset: 0x000FA454
		internal void method_216()
		{
			this.method_588();
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x000FC268 File Offset: 0x000FA468
		internal void method_217()
		{
			this.method_579();
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x000FC27C File Offset: 0x000FA47C
		internal void method_218(int int_3)
		{
			this.method_9(int_3);
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x000FC290 File Offset: 0x000FA490
		private void method_219()
		{
			this.method_271();
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x000FC2A4 File Offset: 0x000FA4A4
		internal void method_220()
		{
			this.method_523();
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000FC2B8 File Offset: 0x000FA4B8
		private void method_221()
		{
			this.method_901();
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000FC2CC File Offset: 0x000FA4CC
		[CompilerGenerated]
		private void method_222()
		{
			this.method_861();
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x000FC2E0 File Offset: 0x000FA4E0
		private void method_223(float float_7)
		{
			this.float_3 = float_7;
			this.method_506("Variables_Angle", false);
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x000FC300 File Offset: 0x000FA500
		internal void method_224()
		{
			this.method_26();
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x000FC314 File Offset: 0x000FA514
		private void method_225()
		{
			this.method_868();
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x000FC328 File Offset: 0x000FA528
		[CompilerGenerated]
		private void method_226()
		{
			this.method_245();
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x000FC33C File Offset: 0x000FA53C
		private void method_227()
		{
			this.method_557();
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x000FC350 File Offset: 0x000FA550
		internal void method_228()
		{
			this.method_346();
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x000FC364 File Offset: 0x000FA564
		private void method_229()
		{
			this.method_681();
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x000FC378 File Offset: 0x000FA578
		[CompilerGenerated]
		private void method_230()
		{
			this.method_928();
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x000FC38C File Offset: 0x000FA58C
		private void method_231()
		{
			this.method_472(-3);
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x000FC3A4 File Offset: 0x000FA5A4
		private void method_232()
		{
			this.method_898(0.05f);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x000FC3BC File Offset: 0x000FA5BC
		internal void method_233()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"] {",
				"Set",
				"Parrot",
				"User",
				"ID",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x000FC43C File Offset: 0x000FA63C
		private void method_234()
		{
			this.method_13();
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000FC450 File Offset: 0x000FA650
		internal void method_235(bool bool_26 = false, bool bool_27 = false)
		{
			this.method_572(bool_26, bool_27);
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000FC468 File Offset: 0x000FA668
		internal void method_236()
		{
			this.method_504();
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x000FC47C File Offset: 0x000FA67C
		private void method_237()
		{
			this.method_574();
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000FC490 File Offset: 0x000FA690
		private void method_238()
		{
			this.method_541();
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000FC4A4 File Offset: 0x000FA6A4
		private void method_239()
		{
			this.method_529();
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000FC4B8 File Offset: 0x000FA6B8
		private void method_240()
		{
			this.method_218(3);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x000FC4CC File Offset: 0x000FA6CC
		private void method_241()
		{
			this.method_551();
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x000FC4E0 File Offset: 0x000FA6E0
		[CompilerGenerated]
		private void method_242()
		{
			this.method_244();
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000FC4F4 File Offset: 0x000FA6F4
		[CompilerGenerated]
		private void method_243()
		{
			this.method_839();
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x000FC508 File Offset: 0x000FA708
		private void method_244()
		{
			this.method_120();
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000FC51C File Offset: 0x000FA71C
		private void method_245()
		{
			this.method_744();
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x000FC530 File Offset: 0x000FA730
		private void method_246()
		{
			this.method_849();
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x000FC544 File Offset: 0x000FA744
		internal void method_247()
		{
			this.method_731();
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x000FC558 File Offset: 0x000FA758
		private void method_248()
		{
			this.method_752(2);
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x000FC56C File Offset: 0x000FA76C
		[CompilerGenerated]
		private void method_249()
		{
			this.method_320();
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x000FC580 File Offset: 0x000FA780
		[CompilerGenerated]
		private void method_250()
		{
			this.method_708();
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x000FC594 File Offset: 0x000FA794
		private void method_251()
		{
			this.method_808();
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x000FC5A8 File Offset: 0x000FA7A8
		[CompilerGenerated]
		private void method_252()
		{
			this.method_354();
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x000FC5BC File Offset: 0x000FA7BC
		internal void method_253()
		{
			new GClass33("Menu_SelectedUser_Local", "Abyss Client", "", null, null);
			GClass27 gclass = new GClass27("Menu_SelectedUser_Local");
			GClass27 gclass27_ = gclass;
			string string_ = "Actions";
			string string_2 = "Abyss Client Actions";
			Texture texture2D_ = GClass153.GClass88.texture2D_36;
			GClass177.gclass97_0 = new GClass97(gclass27_, string_, string_2, null, null, texture2D_, false);
			this.method_220();
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000FC630 File Offset: 0x000FA830
		private void method_254()
		{
			this.method_752(1);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000FC644 File Offset: 0x000FA844
		internal void method_255()
		{
			this.method_563();
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000FC658 File Offset: 0x000FA858
		[CompilerGenerated]
		private void method_256()
		{
			this.method_202();
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000FC66C File Offset: 0x000FA86C
		internal void method_257()
		{
			this.method_940();
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000FC680 File Offset: 0x000FA880
		internal void method_258()
		{
			GClass163.gclass99_78.method_12().method_3().GetComponent<Button>().onClick.Invoke();
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000FC6AC File Offset: 0x000FA8AC
		internal void method_259()
		{
			GClass177.gclass30_79 = new GClass30(GClass177.gclass99_12, 1f, 0f, "EP_Position", new Action(this.method_189), "EP_Position.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_80 = new GClass30(GClass177.gclass99_12, 2f, 0f, "EP_Head", new Action(this.method_614), "EP_Head.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_81 = new GClass30(GClass177.gclass99_12, 3f, 0f, "EP_Center", new Action(this.method_432), "EP_Center.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_12;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_0 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000FC7BC File Offset: 0x000FA9BC
		[CompilerGenerated]
		private void method_260()
		{
			this.method_931();
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000FC7D0 File Offset: 0x000FA9D0
		internal void method_261()
		{
			this.method_259();
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x000FC7E4 File Offset: 0x000FA9E4
		internal void method_262()
		{
			this.method_954();
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x000FC7F8 File Offset: 0x000FA9F8
		internal void method_263(int int_3)
		{
			this.method_124(int_3);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x000FC80C File Offset: 0x000FAA0C
		private void method_264(float float_7)
		{
			this.method_1023(float_7);
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x000FC820 File Offset: 0x000FAA20
		private void method_265()
		{
			this.method_472(3);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000FC834 File Offset: 0x000FAA34
		internal GClass181.GStruct270 method_266(int int_3)
		{
			int num = this.method_49(int_3);
			GClass181.GStruct270 result;
			if (num >= 0 && num < GClass177.list_0.Count)
			{
				result = GClass177.list_0[num];
			}
			else
			{
				result = default(GClass181.GStruct270);
			}
			return result;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x000FC878 File Offset: 0x000FAA78
		[CompilerGenerated]
		private void method_267()
		{
			this.method_328();
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000FC88C File Offset: 0x000FAA8C
		internal void method_268()
		{
			GClass177.gclass99_2 = new GClass99(GClass177.gclass99_1, 1f, 0f, "Drop Portal", "Drop Portal", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_2.method_12().method_19(new Action(this.method_405));
			GClass177.gclass99_3 = new GClass99(GClass177.gclass99_1, 2f, 0f, "New Portal Dropper", "New Portal Dropper", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_3.method_12().method_19(new Action(this.method_679));
			GClass177.gclass30_74 = new GClass30(GClass177.gclass99_1, 3f, 0f, "Set Dropper Nickname", new Action(this.method_678), "Set Dropper Nickname.", new Color?(Color.cyan), new Color?(Color.white), null);
			this.method_567();
			this.method_1016();
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000FC9BC File Offset: 0x000FABBC
		internal void method_269()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_193(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x000FC9F4 File Offset: 0x000FABF4
		internal void method_270()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass148 gclass148_ = GClass84.gclass148_0;
				string[] array = new string[10];
				array[0] = "[] {";
				array[1] = "Teleport";
				array[2] = "To";
				array[3] = "(";
				int num = 4;
				Vector3 position = transform.position;
				array[num] = position.x.ToString();
				array[5] = "|";
				int num2 = 6;
				position = transform.position;
				array[num2] = position.y.ToString();
				array[7] = "|";
				int num3 = 8;
				position = transform.position;
				array[num3] = position.z.ToString();
				array[9] = ");}";
				gclass148_.method_66(string.Concat(array));
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x000FCAA8 File Offset: 0x000FACA8
		private void method_271()
		{
			this.method_629();
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000FCABC File Offset: 0x000FACBC
		private void method_272()
		{
			this.method_702();
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000FCAD0 File Offset: 0x000FACD0
		private void method_273()
		{
			this.method_898(-0.05f);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x000FCAE8 File Offset: 0x000FACE8
		internal void method_274()
		{
			this.method_903();
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x000FCAFC File Offset: 0x000FACFC
		private void method_275()
		{
			this.method_801();
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x000FCB10 File Offset: 0x000FAD10
		internal void method_276()
		{
			this.method_825();
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x000FCB24 File Offset: 0x000FAD24
		internal void method_277(GClass181.GStruct270 gstruct270_0)
		{
			this.method_826(gstruct270_0);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x000FCB38 File Offset: 0x000FAD38
		private void method_278()
		{
			this.method_300(-0.05f);
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x000FCB50 File Offset: 0x000FAD50
		internal void method_279()
		{
			this.method_233();
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x000FCB64 File Offset: 0x000FAD64
		private void method_280()
		{
			this.method_193();
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000FCB78 File Offset: 0x000FAD78
		[CompilerGenerated]
		private void method_281()
		{
			this.method_71();
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000FCB8C File Offset: 0x000FAD8C
		internal void method_282()
		{
			this.method_88();
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000FCBA0 File Offset: 0x000FADA0
		internal void method_283()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_459(apiAvatar.authorId, apiAvatar.authorName);
				this.method_930();
			}
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000FCBE4 File Offset: 0x000FADE4
		internal void method_284()
		{
			this.method_209();
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x000FCBF8 File Offset: 0x000FADF8
		internal void method_285()
		{
			this.method_195();
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x000FCC0C File Offset: 0x000FAE0C
		internal void method_286()
		{
			this.method_615();
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000FCC20 File Offset: 0x000FAE20
		private void method_287()
		{
			this.method_34();
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000FCC34 File Offset: 0x000FAE34
		private void method_288()
		{
			this.method_752(7);
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x000FCC48 File Offset: 0x000FAE48
		private void method_289()
		{
			this.method_181();
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x000FCC5C File Offset: 0x000FAE5C
		private void method_290()
		{
			this.method_273();
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000FCC70 File Offset: 0x000FAE70
		internal void method_291()
		{
			this.method_802();
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000FCC84 File Offset: 0x000FAE84
		private void method_292()
		{
			this.method_275();
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000FCC98 File Offset: 0x000FAE98
		internal void method_293()
		{
			this.method_889();
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x000FCCAC File Offset: 0x000FAEAC
		[CompilerGenerated]
		private void method_294()
		{
			this.method_658();
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x000FCCC0 File Offset: 0x000FAEC0
		private void method_295()
		{
			this.method_82();
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x000FCCD4 File Offset: 0x000FAED4
		private void method_296()
		{
			this.method_895();
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x000FCCE8 File Offset: 0x000FAEE8
		internal void method_297(GClass181.GStruct270 gstruct270_0)
		{
			this.method_685(gstruct270_0);
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x000FCCFC File Offset: 0x000FAEFC
		[CompilerGenerated]
		private void method_298()
		{
			this.method_585();
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000FCD10 File Offset: 0x000FAF10
		internal void method_299()
		{
			this.method_705();
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x000FCD24 File Offset: 0x000FAF24
		private void method_300(float float_7)
		{
			this.method_264(float_7);
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x000FCD38 File Offset: 0x000FAF38
		internal void method_301()
		{
			this.method_1021();
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x000FCD4C File Offset: 0x000FAF4C
		internal void method_302(GClass181.GStruct270 gstruct270_0)
		{
			this.method_277(gstruct270_0);
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x000FCD60 File Offset: 0x000FAF60
		[CompilerGenerated]
		private void method_303()
		{
			this.method_106();
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x000FCD74 File Offset: 0x000FAF74
		private void method_304(float float_7)
		{
			this.method_863(this.float_4 + float_7);
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x000FCD90 File Offset: 0x000FAF90
		private void method_305(float float_7)
		{
			this.method_871(float_7);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x000FCDA4 File Offset: 0x000FAFA4
		private void method_306()
		{
			this.method_2();
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x000FCDB8 File Offset: 0x000FAFB8
		private void method_307()
		{
			this.method_921();
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x000FCDCC File Offset: 0x000FAFCC
		private void method_308()
		{
			this.method_980();
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x000FCDE0 File Offset: 0x000FAFE0
		private void method_309()
		{
			this.method_103();
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x000FCDF4 File Offset: 0x000FAFF4
		internal void method_310()
		{
			this.method_734();
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x000FCE08 File Offset: 0x000FB008
		private void method_311()
		{
			this.method_530();
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x000FCE1C File Offset: 0x000FB01C
		private void method_312()
		{
			this.method_353();
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x000FCE30 File Offset: 0x000FB030
		private void method_313()
		{
			this.method_613();
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x000FCE44 File Offset: 0x000FB044
		private void method_314()
		{
			this.method_683();
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x000FCE58 File Offset: 0x000FB058
		[CompilerGenerated]
		private void method_315()
		{
			this.method_219();
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x000FCE6C File Offset: 0x000FB06C
		private void method_316()
		{
			this.method_314();
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x000FCE80 File Offset: 0x000FB080
		internal void method_317()
		{
			this.method_543();
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x000FCE94 File Offset: 0x000FB094
		internal void method_318()
		{
			this.method_43();
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x000FCEA8 File Offset: 0x000FB0A8
		private void method_319()
		{
			this.method_565();
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000FCEBC File Offset: 0x000FB0BC
		private void method_320()
		{
			this.method_176();
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000FCED0 File Offset: 0x000FB0D0
		internal void method_321()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.gclass141_0.method_22(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_0, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000FCF60 File Offset: 0x000FB160
		private void method_322()
		{
			this.method_1006();
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x000FCF74 File Offset: 0x000FB174
		private void method_323()
		{
			this.method_906(-3f);
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x000FCF8C File Offset: 0x000FB18C
		internal void method_324()
		{
			this.method_258();
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x000FCFA0 File Offset: 0x000FB1A0
		internal void method_325()
		{
			this.method_817();
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x000FCFB4 File Offset: 0x000FB1B4
		internal void method_326()
		{
			this.method_29();
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x000FCFC8 File Offset: 0x000FB1C8
		internal void method_327()
		{
			this.method_667();
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x000FCFDC File Offset: 0x000FB1DC
		private void method_328()
		{
			this.method_234();
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x000FCFF0 File Offset: 0x000FB1F0
		internal void method_329(bool bool_26, bool bool_27)
		{
			if (!bool_26)
			{
				if (!bool_27)
				{
					GClass177.int_1 = 0;
				}
				GClass177.list_0.Clear();
				for (int i = 0; i < GClass84.gclass181_0.list_1.Count; i++)
				{
					GClass177.list_0.Add(GClass84.gclass181_0.list_1[i]);
				}
				this.method_128();
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x000FD054 File Offset: 0x000FB254
		[CompilerGenerated]
		private void method_330()
		{
			this.method_888();
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x000FD068 File Offset: 0x000FB268
		internal void method_331()
		{
			this.method_728();
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x000FD07C File Offset: 0x000FB27C
		[CompilerGenerated]
		private void method_332()
		{
			this.method_308();
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x000FD090 File Offset: 0x000FB290
		internal void method_333()
		{
			GClass84.smethod_652(GClass84.smethod_126());
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000FD0A8 File Offset: 0x000FB2A8
		private void method_334()
		{
			this.method_447();
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000FD0BC File Offset: 0x000FB2BC
		internal void method_335()
		{
			this.method_180();
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000FD0D0 File Offset: 0x000FB2D0
		private void method_336()
		{
			this.method_182();
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000FD0E4 File Offset: 0x000FB2E4
		internal void method_337()
		{
			this.method_1018();
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x000FD0F8 File Offset: 0x000FB2F8
		private void method_338()
		{
			this.method_7();
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x000FD10C File Offset: 0x000FB30C
		internal void method_339()
		{
			int num = GClass84.smethod_741(GClass177.list_2.Count, GClass177.list_0.Count - GClass177.int_1);
			int i;
			for (i = 0; i < num; i++)
			{
				if (i >= 0 && i < GClass177.list_0.Count)
				{
					GClass181.GStruct270 gstruct = GClass177.list_0[i + GClass177.int_1];
					GClass177.list_2[i].method_30(gstruct.string_0);
					GClass177.list_2[i].method_10(gstruct.string_1);
					GClass177.list_2[i].method_11(true);
				}
				else
				{
					GClass177.list_2[i].method_11(false);
				}
			}
			while (i < GClass177.list_2.Count)
			{
				GClass177.list_2[i].method_11(false);
				i++;
			}
			if (GClass177.int_1 <= 0)
			{
				GClass177.gclass30_139.method_9(false);
			}
			else
			{
				GClass177.gclass30_139.method_9(true);
			}
			if (GClass177.int_1 >= this.method_837())
			{
				GClass177.gclass30_138.method_9(false);
			}
			else
			{
				GClass177.gclass30_138.method_9(true);
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x000FD238 File Offset: 0x000FB438
		private void method_340()
		{
			this.method_948();
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000FD24C File Offset: 0x000FB44C
		private void method_341()
		{
			this.method_262();
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000FD260 File Offset: 0x000FB460
		private void method_342()
		{
			this.method_874();
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000FD274 File Offset: 0x000FB474
		internal void method_343(GClass144.GEnum35 genum35_1)
		{
			this.method_366(genum35_1);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000FD288 File Offset: 0x000FB488
		internal void method_344()
		{
			this.method_339();
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000FD29C File Offset: 0x000FB49C
		private void method_345()
		{
			this.method_114();
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000FD2B0 File Offset: 0x000FB4B0
		internal void method_346()
		{
			this.method_926();
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
		internal void method_347()
		{
			this.method_358();
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x000FD2D8 File Offset: 0x000FB4D8
		private void method_348()
		{
			this.method_395();
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x000FD2EC File Offset: 0x000FB4EC
		internal void method_349()
		{
			this.method_816();
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x000FD300 File Offset: 0x000FB500
		[CompilerGenerated]
		private void method_350()
		{
			this.method_309();
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x000FD314 File Offset: 0x000FB514
		internal void method_351()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.gclass141_0.method_177(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_0, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x000FD3A4 File Offset: 0x000FB5A4
		[CompilerGenerated]
		private void method_352()
		{
			this.method_290();
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x000FD3B8 File Offset: 0x000FB5B8
		internal void method_353()
		{
			this.method_1024();
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x000FD3CC File Offset: 0x000FB5CC
		private void method_354()
		{
			this.method_495();
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000FD3E0 File Offset: 0x000FB5E0
		private void method_355()
		{
			this.method_248();
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x000FD3F4 File Offset: 0x000FB5F4
		[CompilerGenerated]
		private void method_356()
		{
			this.method_765();
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000FD408 File Offset: 0x000FB608
		[CompilerGenerated]
		private void method_357()
		{
			this.method_413();
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000FD41C File Offset: 0x000FB61C
		internal void method_358()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"] {",
				"Set",
				"Orbit",
				"User",
				"ID",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000FD49C File Offset: 0x000FB69C
		private void method_359()
		{
			this.method_924();
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x000FD4B0 File Offset: 0x000FB6B0
		[CompilerGenerated]
		private void method_360()
		{
			this.method_854();
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x000FD4C4 File Offset: 0x000FB6C4
		internal void method_361()
		{
			this.method_286();
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000FD4D8 File Offset: 0x000FB6D8
		internal void method_362()
		{
			GClass84.smethod_1098(GClass84.smethod_1157());
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000FD4F0 File Offset: 0x000FB6F0
		[CompilerGenerated]
		private void method_363()
		{
			this.method_644();
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x000FD504 File Offset: 0x000FB704
		internal void method_364()
		{
			GClass84.gclass148_0.method_15(GClass84.smethod_778());
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000FD524 File Offset: 0x000FB724
		[CompilerGenerated]
		private void method_365()
		{
			this.method_823();
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000FD538 File Offset: 0x000FB738
		internal void method_366(GClass144.GEnum35 genum35_1)
		{
			this.method_793(genum35_1);
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000FD54C File Offset: 0x000FB74C
		private void method_367()
		{
			this.method_343(GClass144.GEnum35.const_1);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x000FD560 File Offset: 0x000FB760
		internal void method_368()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_18(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x000FD598 File Offset: 0x000FB798
		private void method_369()
		{
			this.method_381();
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x000FD5AC File Offset: 0x000FB7AC
		[CompilerGenerated]
		private void method_370()
		{
			this.method_686();
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x000FD5C0 File Offset: 0x000FB7C0
		internal void method_371()
		{
			this.method_255();
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x000FD5D4 File Offset: 0x000FB7D4
		private void method_372(float float_7)
		{
			this.method_144(float_7);
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x000FD5E8 File Offset: 0x000FB7E8
		internal void method_373()
		{
			this.method_476();
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x000FD5FC File Offset: 0x000FB7FC
		private void method_374()
		{
			this.method_978();
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x000FD610 File Offset: 0x000FB810
		private void method_375()
		{
			this.method_616(-0.05f);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x000FD628 File Offset: 0x000FB828
		[CompilerGenerated]
		private void method_376()
		{
			this.method_457();
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x000FD63C File Offset: 0x000FB83C
		private void method_377()
		{
			this.method_359();
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x000FD650 File Offset: 0x000FB850
		internal void method_378()
		{
			GClass84.smethod_967(GClass84.smethod_105());
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x000FD668 File Offset: 0x000FB868
		[CompilerGenerated]
		private void method_379()
		{
			this.method_542();
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x000FD67C File Offset: 0x000FB87C
		private void method_380(float float_7)
		{
			this.method_10(float_7);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x000FD690 File Offset: 0x000FB890
		private void method_381()
		{
			this.method_598();
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x000FD6A4 File Offset: 0x000FB8A4
		internal void method_382()
		{
			this.method_253();
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x000FD6B8 File Offset: 0x000FB8B8
		[CompilerGenerated]
		private void method_383()
		{
			this.method_355();
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x000FD6CC File Offset: 0x000FB8CC
		private void method_384()
		{
			this.method_440();
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x000FD6E0 File Offset: 0x000FB8E0
		internal void method_385()
		{
			this.method_974();
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x000FD6F4 File Offset: 0x000FB8F4
		[CompilerGenerated]
		private void method_386()
		{
			this.method_704();
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x000FD708 File Offset: 0x000FB908
		[CompilerGenerated]
		private void method_387()
		{
			this.method_342();
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x000FD71C File Offset: 0x000FB91C
		internal void method_388()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"] {",
				"Set",
				"Look",
				"At",
				"User",
				"ID",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x000FD7A4 File Offset: 0x000FB9A4
		[CompilerGenerated]
		private void method_389()
		{
			this.method_738();
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000FD7B8 File Offset: 0x000FB9B8
		private void method_390()
		{
			this.method_690();
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x000FD7CC File Offset: 0x000FB9CC
		private void method_391()
		{
			this.method_86();
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000FD7E0 File Offset: 0x000FB9E0
		private void method_392()
		{
			this.method_828();
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x000FD7F4 File Offset: 0x000FB9F4
		[CompilerGenerated]
		private void method_393()
		{
			this.method_534();
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x000FD808 File Offset: 0x000FBA08
		internal void method_394()
		{
			this.method_507();
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x000FD81C File Offset: 0x000FBA1C
		private void method_395()
		{
			this.method_616(-0.2f);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x000FD834 File Offset: 0x000FBA34
		private void method_396()
		{
			this.method_1014();
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x000FD848 File Offset: 0x000FBA48
		internal void method_397()
		{
			this.method_624();
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x000FD85C File Offset: 0x000FBA5C
		internal void method_398()
		{
			this.method_137();
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x000FD870 File Offset: 0x000FBA70
		[CompilerGenerated]
		private void method_399()
		{
			this.method_545();
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x000FD884 File Offset: 0x000FBA84
		[CompilerGenerated]
		private void method_400()
		{
			this.method_4();
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x000FD898 File Offset: 0x000FBA98
		internal void method_401()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.smethod_1379(GClass84.smethod_272(transform, this.genum47_0), false);
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x000FD8CC File Offset: 0x000FBACC
		internal void method_402()
		{
			this.method_936();
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x000FD8E0 File Offset: 0x000FBAE0
		internal void method_403()
		{
			this.method_811();
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x000FD8F4 File Offset: 0x000FBAF4
		internal void method_404()
		{
			this.method_847();
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x000FD908 File Offset: 0x000FBB08
		[CompilerGenerated]
		private void method_405()
		{
			this.method_886();
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x000FD91C File Offset: 0x000FBB1C
		internal void method_406()
		{
			if (GClass84.gclass39_0 != null)
			{
				GClass177.gclass30_0 = new GClass30(GClass177.gclass97_0, 1f, 0f, GClass84.gclass39_0.string_10, new Action(this.method_330), GClass84.gclass39_0.string_10, new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_6)
			{
				GClass177.gclass30_10 = new GClass30(GClass177.gclass97_0, 2f, 0f, "Teleport To", new Action(this.method_777), "Teleport To Player.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (this.bool_25)
			{
				GClass177.gclass30_37 = new GClass30(GClass177.gclass97_0, 3f, 0f, "Start Desync", new Action(this.method_914), "Start Desync.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_37.method_9(false);
			}
			if (GClass84.gclass93_0.bool_23 && this.bool_17)
			{
				GClass177.gclass30_20 = new GClass30(GClass177.gclass97_0, 4f, 0f, "Check For emmVRC", new Action(this.method_482), "Check For emmVRC.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			GClass177.gclass99_22 = new GClass99(GClass177.gclass97_0, 1f, 1f, "Get Information", "Get Information", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			if (GClass84.gclass184_0 != null)
			{
				GClass177.gclass99_23 = new GClass99(GClass177.gclass97_0, 2f, 1f, "Touch", "Touch", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			GClass177.gclass99_24 = new GClass99(GClass177.gclass97_0, 3f, 1f, "Crash", "Crash", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			if (GClass84.gclass148_0 != null)
			{
				GClass177.gclass99_25 = new GClass99(GClass177.gclass97_0, 4f, 1f, "Bots", "Bots", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			GClass177.gclass99_26 = new GClass99(GClass177.gclass97_0, 1f, 2f, "Avatar", "Avatar", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			if (GClass84.gclass145_0 != null)
			{
				GClass177.gclass99_27 = new GClass99(GClass177.gclass97_0, 2f, 2f, "AntiCrash", "AntiCrash", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
				GClass177.gclass99_27.method_12().method_19(new Action(this.method_276));
			}
			GClass177.gclass99_0 = new GClass99(GClass177.gclass97_0, 3f, 2f, "Functions", "A little bit of extra stuff", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass30_21 = new GClass30(GClass177.gclass97_0, 4f, 2f, "Lewd", new Action(this.method_350), "Lewd.", new Color?(Color.cyan), new Color?(Color.white), null);
			this.method_885();
			this.method_1017();
			this.method_594();
			this.method_660();
			this.method_767();
			this.method_990();
			this.method_812();
			this.method_506("All", false);
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x000FDD50 File Offset: 0x000FBF50
		internal void method_407()
		{
			this.method_371();
			this.method_930();
			this.method_247();
			this.method_671();
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x000FDD78 File Offset: 0x000FBF78
		internal void method_408(bool bool_26, bool bool_27)
		{
			if (!bool_26)
			{
				if (!bool_27)
				{
					GClass177.int_2 = 0;
				}
				GClass177.list_3.Clear();
				GClass177.list_3.AddRange(GClass84.gclass141_0.method_141());
				this.method_900();
			}
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x000FDDB8 File Offset: 0x000FBFB8
		private void method_409()
		{
			this.method_265();
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x000FDDCC File Offset: 0x000FBFCC
		private void method_410()
		{
			this.method_218(5);
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x000FDDE0 File Offset: 0x000FBFE0
		private void method_411()
		{
			this.method_770();
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000FDDF4 File Offset: 0x000FBFF4
		private void method_412()
		{
			this.method_419();
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000FDE08 File Offset: 0x000FC008
		private void method_413()
		{
			this.method_323();
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000FDE1C File Offset: 0x000FC01C
		private void method_414()
		{
			this.method_577();
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000FDE30 File Offset: 0x000FC030
		private void method_415()
		{
			this.method_616(0.05f);
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x000FDE48 File Offset: 0x000FC048
		private void method_416()
		{
			this.method_254();
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x000FDE5C File Offset: 0x000FC05C
		internal void method_417()
		{
			this.method_388();
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x000FDE70 File Offset: 0x000FC070
		internal void method_418()
		{
			this.method_706();
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000FDE84 File Offset: 0x000FC084
		internal void method_419()
		{
			this.method_417();
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x000FDE98 File Offset: 0x000FC098
		internal void method_420()
		{
			GClass177.gclass30_72 = new GClass30(GClass177.gclass99_9, 1f, 0f, "Crewmate", new Action(this.method_427), "Crewmate.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_73 = new GClass30(GClass177.gclass99_9, 2f, 0f, "Impostor", new Action(this.method_583), "Impostor.", new Color?(Color.cyan), new Color?(Color.white), null);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000FDF30 File Offset: 0x000FC130
		internal void method_421()
		{
			this.method_758();
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000FDF44 File Offset: 0x000FC144
		private void method_422(float float_7)
		{
			this.method_913(float_7);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x000FDF58 File Offset: 0x000FC158
		internal void method_423()
		{
			if (GClass84.gclass163_0 != null)
			{
				GClass84.gclass163_0.method_2006(GClass84.smethod_1573());
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x000FDF80 File Offset: 0x000FC180
		private void method_424()
		{
			this.method_836(-3f);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x000FDF98 File Offset: 0x000FC198
		internal void method_425()
		{
			this.method_54();
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x000FDFAC File Offset: 0x000FC1AC
		private void method_426()
		{
			this.method_61(9f);
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x000FDFC4 File Offset: 0x000FC1C4
		[CompilerGenerated]
		private void method_427()
		{
			this.method_883();
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x000FDFD8 File Offset: 0x000FC1D8
		internal void method_428()
		{
			int num = GClass84.smethod_741(GClass177.list_4.Count, GClass177.list_3.Count - GClass177.int_2);
			int i;
			for (i = 0; i < num; i++)
			{
				if (i >= 0 && i < GClass177.list_3.Count)
				{
					GameObject gameObject = GClass177.list_3[i + GClass177.int_2];
					if (gameObject)
					{
						GClass177.list_4[i].method_30(gameObject.name);
						GClass177.list_4[i].method_10(GClass84.smethod_1324(gameObject));
						GClass177.list_4[i].method_11(true);
					}
					else
					{
						GClass177.list_4[i].method_11(false);
					}
				}
				else
				{
					GClass177.list_4[i].method_11(false);
				}
			}
			while (i < GClass177.list_4.Count)
			{
				GClass177.list_4[i].method_11(false);
				i++;
			}
			if (GClass177.int_2 <= 0)
			{
				GClass177.gclass30_142.method_9(false);
			}
			else
			{
				GClass177.gclass30_142.method_9(true);
			}
			if (GClass177.int_2 >= this.method_136())
			{
				GClass177.gclass30_141.method_9(false);
			}
			else
			{
				GClass177.gclass30_141.method_9(true);
			}
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x000FE124 File Offset: 0x000FC324
		internal void method_429()
		{
			this.method_771();
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000FE138 File Offset: 0x000FC338
		internal void method_430()
		{
			this.method_364();
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000FE14C File Offset: 0x000FC34C
		private void method_431()
		{
			this.method_280();
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000FE160 File Offset: 0x000FC360
		[CompilerGenerated]
		private void method_432()
		{
			this.method_642();
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x000FE174 File Offset: 0x000FC374
		private void method_433()
		{
			this.method_975();
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x000FE188 File Offset: 0x000FC388
		internal void method_434(int int_3)
		{
			this.method_834(int_3);
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x000FE19C File Offset: 0x000FC39C
		private void method_435(float float_7)
		{
			this.method_846(float_7);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x000FE1B0 File Offset: 0x000FC3B0
		private void method_436()
		{
			this.method_815();
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x000FE1C4 File Offset: 0x000FC3C4
		internal void method_437()
		{
			APIUser apiuser = GClass84.smethod_821();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.smethod_1211(apiuser);
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
		internal void method_438()
		{
			GClass84.smethod_1605(GClass84.smethod_105(), true);
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x000FE20C File Offset: 0x000FC40C
		[CompilerGenerated]
		private void method_439()
		{
			this.method_944();
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000FE220 File Offset: 0x000FC420
		private void method_440()
		{
			this.method_235(false, false);
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x000FE238 File Offset: 0x000FC438
		[CompilerGenerated]
		private void method_441()
		{
			this.method_620();
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000FE24C File Offset: 0x000FC44C
		private void method_442()
		{
			this.method_214(false, true);
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000FE264 File Offset: 0x000FC464
		internal void method_443(bool bool_26, bool bool_27)
		{
			this.method_329(bool_26, bool_27);
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000FE27C File Offset: 0x000FC47C
		internal void method_444()
		{
			this.method_929();
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x000FE290 File Offset: 0x000FC490
		private void method_445()
		{
			this.method_947();
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000FE2A4 File Offset: 0x000FC4A4
		private void method_446()
		{
			this.method_361();
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000FE2B8 File Offset: 0x000FC4B8
		private void method_447()
		{
			this.method_836(3f);
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x000FE2D0 File Offset: 0x000FC4D0
		internal void method_448()
		{
			GClass177.gclass30_75 = new GClass30(GClass177.gclass99_10, 1f, 0f, "Set As Target", new Action(this.method_970), "Set As Target.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_76 = new GClass30(GClass177.gclass99_10, 2f, 0f, "Behaviours", new Action(this.method_332), "Behaviours.", new Color?(Color.cyan), new Color?(Color.white), null);
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000FE368 File Offset: 0x000FC568
		[CompilerGenerated]
		private void method_449()
		{
			this.method_625();
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x000FE37C File Offset: 0x000FC57C
		private void method_450()
		{
			this.method_752(4);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x000FE390 File Offset: 0x000FC590
		private void method_451()
		{
			this.method_788();
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x000FE3A4 File Offset: 0x000FC5A4
		private void method_452()
		{
			this.method_67();
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x000FE3B8 File Offset: 0x000FC5B8
		internal void method_453()
		{
			this.method_633();
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x000FE3CC File Offset: 0x000FC5CC
		private void method_454()
		{
			this.method_906(9f);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x000FE3E4 File Offset: 0x000FC5E4
		private void method_455()
		{
			this.method_616(0.5f);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x000FE3FC File Offset: 0x000FC5FC
		private void method_456(float float_7)
		{
			this.method_943(this.float_5 + float_7);
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x000FE418 File Offset: 0x000FC618
		private void method_457()
		{
			this.method_953();
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x000FE42C File Offset: 0x000FC62C
		internal void method_458()
		{
			this.method_548();
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x000FE440 File Offset: 0x000FC640
		private void method_459()
		{
			this.method_451();
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000FE454 File Offset: 0x000FC654
		private void method_460()
		{
			this.method_794();
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000FE468 File Offset: 0x000FC668
		internal void method_461()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_125(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x000FE4A0 File Offset: 0x000FC6A0
		private void method_462()
		{
			this.method_938();
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x000FE4B4 File Offset: 0x000FC6B4
		private void method_463()
		{
			this.method_47();
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x000FE4C8 File Offset: 0x000FC6C8
		internal void method_464(int int_3)
		{
			this.method_95(int_3);
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x000FE4DC File Offset: 0x000FC6DC
		private void method_465()
		{
			this.method_995();
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x000FE4F0 File Offset: 0x000FC6F0
		[CompilerGenerated]
		private void method_466()
		{
			this.method_489();
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x000FE504 File Offset: 0x000FC704
		private void method_467()
		{
			this.method_691();
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000FE518 File Offset: 0x000FC718
		private void method_468()
		{
			this.method_898(0.5f);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x000FE530 File Offset: 0x000FC730
		internal void method_469()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.smethod_589(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_2, this.genum35_0, GClass144.GEnum36.const_0, this.float_0, this.float_1, this.float_2, this.float_3, this.float_4, this.float_5, this.float_6);
			}
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x000FE5C8 File Offset: 0x000FC7C8
		private void method_470()
		{
			this.method_952(-3);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000FE5E0 File Offset: 0x000FC7E0
		[CompilerGenerated]
		private void method_471()
		{
			this.method_416();
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000FE5F4 File Offset: 0x000FC7F4
		internal void method_472(int int_3)
		{
			this.method_69(int_3);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x000FE608 File Offset: 0x000FC808
		internal void method_473()
		{
			string text = GClass84.smethod_378(GClass84.smethod_1157());
			GClass70.smethod_24(text, GClass70.Enum1.const_0);
			Clipboard.SetText(text);
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x000FE630 File Offset: 0x000FC830
		private void method_474()
		{
			this.method_647();
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x000FE644 File Offset: 0x000FC844
		internal void method_475()
		{
			this.method_983();
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x000FE658 File Offset: 0x000FC858
		internal void method_476()
		{
			this.method_610();
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x000FE66C File Offset: 0x000FC86C
		[CompilerGenerated]
		private void method_477()
		{
			this.method_146();
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x000FE680 File Offset: 0x000FC880
		internal void method_478()
		{
			this.method_1025();
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000FE694 File Offset: 0x000FC894
		private void method_479()
		{
			this.method_77();
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000FE6A8 File Offset: 0x000FC8A8
		private void method_480()
		{
			this.method_331();
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x000FE6BC File Offset: 0x000FC8BC
		[CompilerGenerated]
		private void method_481()
		{
			this.method_411();
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x000FE6D0 File Offset: 0x000FC8D0
		[CompilerGenerated]
		private void method_482()
		{
			this.method_171();
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x000FE6E4 File Offset: 0x000FC8E4
		private void method_483()
		{
			this.method_300(0.5f);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000FE6FC File Offset: 0x000FC8FC
		internal void method_484()
		{
			this.method_818();
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000FE710 File Offset: 0x000FC910
		[CompilerGenerated]
		private void method_485()
		{
			this.method_390();
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x000FE724 File Offset: 0x000FC924
		internal void method_486()
		{
			GClass84.gclass141_0.method_29(GClass84.smethod_1309());
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x000FE744 File Offset: 0x000FC944
		private void method_487()
		{
			this.method_500();
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000FE758 File Offset: 0x000FC958
		[CompilerGenerated]
		private void method_488()
		{
			this.method_992();
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000FE76C File Offset: 0x000FC96C
		private void method_489()
		{
			this.method_288();
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000FE780 File Offset: 0x000FC980
		private void method_490()
		{
			this.method_524();
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000FE794 File Offset: 0x000FC994
		internal void method_491()
		{
			this.method_268();
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000FE7A8 File Offset: 0x000FC9A8
		private void method_492(float float_7)
		{
			this.float_4 = float_7;
			this.method_506("Variables_Fluctuations", false);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x000FE7C8 File Offset: 0x000FC9C8
		internal void method_493()
		{
			this.method_501();
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x000FE7DC File Offset: 0x000FC9DC
		[CompilerGenerated]
		private void method_494()
		{
			this.method_62();
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x000FE7F0 File Offset: 0x000FC9F0
		private void method_495()
		{
			this.method_418();
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000FE804 File Offset: 0x000FCA04
		[CompilerGenerated]
		private void method_496()
		{
			this.method_761();
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000FE818 File Offset: 0x000FCA18
		internal void method_497()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				string id = apiAvatar.id;
				if (!string.IsNullOrEmpty(id))
				{
					if (apiAvatar.releaseStatus == "private")
					{
						GClass84.gclass39_0.method_44(apiAvatar);
					}
					else
					{
						GClass84.gclass39_0.method_38(apiAvatar);
					}
				}
			}
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x000FE87C File Offset: 0x000FCA7C
		private void method_498()
		{
			this.method_509();
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x000FE890 File Offset: 0x000FCA90
		private void method_499()
		{
			this.method_63();
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x000FE8A4 File Offset: 0x000FCAA4
		internal void method_500()
		{
			this.method_337();
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x000FE8B8 File Offset: 0x000FCAB8
		internal void method_501()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_24(GClass84.smethod_461(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_1, this.genum35_0, GClass144.GEnum36.const_0, this.float_0, this.float_1, this.float_2, this.float_3, this.float_4, this.float_5, this.float_6);
			}
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000FE950 File Offset: 0x000FCB50
		private void method_502()
		{
			this.method_602();
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x000FE964 File Offset: 0x000FCB64
		private void method_503()
		{
			this.method_835();
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000FE978 File Offset: 0x000FCB78
		internal void method_504()
		{
			this.method_87();
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x000FE98C File Offset: 0x000FCB8C
		public override void vmethod_12()
		{
			this.method_1002();
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x000FE9A0 File Offset: 0x000FCBA0
		private void method_505()
		{
			this.method_305(3f);
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x000FE9B8 File Offset: 0x000FCBB8
		internal void method_506(string string_1, bool bool_26 = false)
		{
			this.method_569(string_1, bool_26);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000FE9D0 File Offset: 0x000FCBD0
		internal void method_507()
		{
			GClass84.gclass184_0.method_8(GClass84.smethod_772());
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000FE9EC File Offset: 0x000FCBEC
		internal void method_508()
		{
			this.method_657();
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x000FEB24 File Offset: 0x000FCD24
		private void method_509()
		{
			this.method_76(4);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x000FEB38 File Offset: 0x000FCD38
		[CompilerGenerated]
		private void method_510()
		{
			this.method_969();
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x000FEB4C File Offset: 0x000FCD4C
		internal void method_511()
		{
			if (GClass84.gclass137_0 != null)
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_772();
				GClass84.gclass137_0.vrcplayerApi_0 = vrcplayerApi;
				if (vrcplayerApi != null)
				{
					GClass84.gclass163_0.method_3406(true);
				}
			}
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x000FEB88 File Offset: 0x000FCD88
		private void method_512()
		{
			this.method_433();
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x000FEB9C File Offset: 0x000FCD9C
		internal void method_513()
		{
			this.method_784();
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x000FEBB0 File Offset: 0x000FCDB0
		private void method_514()
		{
			this.method_76(5);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x000FEBC4 File Offset: 0x000FCDC4
		internal void method_515(int int_3)
		{
			this.method_302(this.method_651(int_3));
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x000FEBE0 File Offset: 0x000FCDE0
		private void method_516(float float_7)
		{
			this.method_968(float_7);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x000FEBF4 File Offset: 0x000FCDF4
		internal void method_517()
		{
			this.method_626();
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x000FEC08 File Offset: 0x000FCE08
		private void method_518()
		{
			this.method_375();
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x000FEC1C File Offset: 0x000FCE1C
		internal void method_519()
		{
			int num = GClass84.smethod_301(GClass84.smethod_1513(GClass84.smethod_126()));
			if (num != -1)
			{
				Clipboard.SetText(num.ToString());
			}
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x000FEC50 File Offset: 0x000FCE50
		private void method_520()
		{
			this.method_898(-0.2f);
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x000FEC68 File Offset: 0x000FCE68
		internal void method_521()
		{
			this.method_796();
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x000FEC7C File Offset: 0x000FCE7C
		private void method_522()
		{
			this.method_664();
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x000FEC90 File Offset: 0x000FCE90
		internal void method_523()
		{
			this.method_406();
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000FECA4 File Offset: 0x000FCEA4
		internal void method_524()
		{
			this.method_327();
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000FECB8 File Offset: 0x000FCEB8
		private void method_525()
		{
			this.method_367();
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x000FECCC File Offset: 0x000FCECC
		private void method_526()
		{
			this.method_76(3);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000FECE0 File Offset: 0x000FCEE0
		[CompilerGenerated]
		private void method_527()
		{
			this.method_348();
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000FECF4 File Offset: 0x000FCEF4
		private void method_528()
		{
			this.method_373();
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x000FED08 File Offset: 0x000FCF08
		private void method_529()
		{
			this.method_70(false, true);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x000FED20 File Offset: 0x000FCF20
		private void method_530()
		{
			this.method_898(0.2f);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x000FED38 File Offset: 0x000FCF38
		private void method_531()
		{
			this.method_662();
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000FED4C File Offset: 0x000FCF4C
		[CompilerGenerated]
		private void method_532()
		{
			this.method_25();
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x000FED60 File Offset: 0x000FCF60
		private void method_533()
		{
			this.method_424();
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x000FED74 File Offset: 0x000FCF74
		private void method_534()
		{
			this.method_772();
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x000FED88 File Offset: 0x000FCF88
		[CompilerGenerated]
		private void method_535()
		{
			this.method_377();
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x000FED9C File Offset: 0x000FCF9C
		internal void method_536()
		{
			this.method_310();
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000FEDB0 File Offset: 0x000FCFB0
		[CompilerGenerated]
		private void method_537()
		{
			this.method_1003();
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000FEDC4 File Offset: 0x000FCFC4
		internal void method_538()
		{
			GClass84.gclass141_0.method_57(GClass84.smethod_1309());
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000FEDE4 File Offset: 0x000FCFE4
		private void method_539()
		{
			this.method_682();
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x000FEDF8 File Offset: 0x000FCFF8
		internal void method_540()
		{
			this.method_378();
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x000FEE0C File Offset: 0x000FD00C
		private void method_541()
		{
			this.method_343(GClass144.GEnum35.const_2);
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x000FEE20 File Offset: 0x000FD020
		private void method_542()
		{
			this.method_872();
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x000FEE34 File Offset: 0x000FD034
		internal void method_543()
		{
			this.method_113();
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x000FEE48 File Offset: 0x000FD048
		private void method_544()
		{
			this.method_910();
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x000FEE5C File Offset: 0x000FD05C
		private void method_545()
		{
			this.method_132();
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000FEE70 File Offset: 0x000FD070
		private void method_546(float float_7)
		{
			this.float_2 = float_7;
			this.method_506("Variables_Height", false);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x000FEE90 File Offset: 0x000FD090
		[CompilerGenerated]
		private void method_547()
		{
			this.method_994();
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x000FEEA4 File Offset: 0x000FD0A4
		internal void method_548()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[] {",
				"Crash",
				"Player",
				"_",
				"Avatar",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x000FEF08 File Offset: 0x000FD108
		[CompilerGenerated]
		private void method_549()
		{
			this.method_908();
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000FEF1C File Offset: 0x000FD11C
		internal void method_550()
		{
			this.method_933();
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000FEF30 File Offset: 0x000FD130
		private void method_551()
		{
			this.method_506("Variables_FluctuationsSpeed", false);
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000FEF4C File Offset: 0x000FD14C
		[CompilerGenerated]
		private void method_552()
		{
			this.method_715();
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000FEF60 File Offset: 0x000FD160
		[CompilerGenerated]
		private void method_553()
		{
			this.method_503();
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x000FEF74 File Offset: 0x000FD174
		[CompilerGenerated]
		private void method_554()
		{
			this.method_213();
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000FEF88 File Offset: 0x000FD188
		internal void method_555()
		{
			if (GClass84.gclass148_0 != null && this.bool_24)
			{
				if (this.bool_6)
				{
					GClass177.gclass30_11 = new GClass30(GClass177.gclass99_25, 3f, 0f, "Teleport To (Bot)", new Action(this.method_618), "Teleport To Player (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
				}
				GClass177.gclass30_33 = new GClass30(GClass177.gclass99_25, 1f, 0f, "Set Owner", new Action(this.method_535), "Set Owner.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_34 = new GClass30(GClass177.gclass99_25, 1f, 1f, "Set Owner (Bot)", new Action(this.method_111), "Set Owner (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_36 = new GClass30(GClass177.gclass99_25, 2f, 0f, "Add Bot", new Action(this.method_976), "Add Bot.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_35 = new GClass30(GClass177.gclass99_25, 2f, 1f, "Remove Bot", new Action(this.method_53), "Remove Bot.", new Color?(Color.cyan), new Color?(Color.white), null);
				if (this.bool_25)
				{
					GClass177.gclass30_38 = new GClass30(GClass177.gclass99_25, 4f, 0f, "Start Desync (Bot)", new Action(this.method_98), "Start Desync (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
					GClass177.gclass30_38.method_9(false);
				}
				GClass177.gclass30_86 = new GClass30(GClass177.gclass99_25, 3f, 1f, "Orbit Player (Bot)", new Action(this.method_75), "Orbit Player (Bot)", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_87 = new GClass30(GClass177.gclass99_25, 4f, 0f, "Look At Player", new Action(this.method_820), "Look At Player.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_88 = new GClass30(GClass177.gclass99_25, 4f, 1f, "Look At Player (Bot)", new Action(this.method_958), "Look At Player (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_89 = new GClass30(GClass177.gclass99_25, 1f, 2f, "Parrot Player", new Action(this.method_745), "Parrot Player.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_90 = new GClass30(GClass177.gclass99_25, 2f, 2f, "Parrot Player (Bot)", new Action(this.method_881), "Parrot Player (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_91 = new GClass30(GClass177.gclass99_25, 3f, 2f, "Mimic Player", new Action(this.method_104), "Mimic Player.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_92 = new GClass30(GClass177.gclass99_25, 4f, 2f, "Mimic Player (Bot)", new Action(this.method_856), "Mimic Player (Bot).", new Color?(Color.cyan), new Color?(Color.white), null);
			}
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x000FF33C File Offset: 0x000FD53C
		internal void method_556()
		{
			try
			{
				if (!this.bool_0)
				{
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x000FF374 File Offset: 0x000FD574
		private void method_557()
		{
			this.method_680();
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x000FF388 File Offset: 0x000FD588
		internal void method_558()
		{
			this.method_28();
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x000FF39C File Offset: 0x000FD59C
		private void method_559()
		{
			this.method_831();
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x000FF3B0 File Offset: 0x000FD5B0
		internal void method_560()
		{
			this.method_876();
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x000FF3C4 File Offset: 0x000FD5C4
		internal void method_561()
		{
			this.method_261();
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x000FF3D8 File Offset: 0x000FD5D8
		private void method_562()
		{
			this.method_1013();
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x000FF3EC File Offset: 0x000FD5EC
		internal void method_563()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass177.gclass30_39.method_11(false);
				GClass177.gclass30_40.method_11(false);
			}
			else if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.list_21, apiAvatar.id, ""))
			{
				GClass177.gclass30_39.method_11(false);
				GClass177.gclass30_40.method_11(true);
			}
			else
			{
				GClass177.gclass30_39.method_11(true);
				GClass177.gclass30_40.method_11(false);
			}
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x000FF468 File Offset: 0x000FD668
		internal void method_564()
		{
			this.method_878();
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x000FF47C File Offset: 0x000FD67C
		private void method_565()
		{
			this.method_865();
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x000FF490 File Offset: 0x000FD690
		internal int method_566(int int_3)
		{
			return int_3 + GClass177.int_2;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000FF4A8 File Offset: 0x000FD6A8
		internal void method_567()
		{
			this.method_580();
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000FF4BC File Offset: 0x000FD6BC
		internal void method_568()
		{
			this.method_461();
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x000FF4D0 File Offset: 0x000FD6D0
		internal void method_569(string string_1, bool bool_26)
		{
			this.method_630(string_1, bool_26);
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000FF4E8 File Offset: 0x000FD6E8
		private void method_570()
		{
			this.method_717();
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x000FF4FC File Offset: 0x000FD6FC
		private void method_571()
		{
			this.method_237();
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x000FF510 File Offset: 0x000FD710
		internal void method_572(bool bool_26, bool bool_27)
		{
			this.method_724(bool_26, bool_27);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000FF528 File Offset: 0x000FD728
		internal void method_573()
		{
			GClass163.gclass99_85.method_12().method_3().GetComponent<Button>().onClick.Invoke();
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x000FF554 File Offset: 0x000FD754
		internal void method_574()
		{
			this.method_398();
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x000FF568 File Offset: 0x000FD768
		private void method_575()
		{
			this.method_638();
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x000FF57C File Offset: 0x000FD77C
		private void method_576()
		{
			this.method_100();
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x000FF590 File Offset: 0x000FD790
		private void method_577()
		{
			this.method_214(false, false);
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x000FF5A8 File Offset: 0x000FD7A8
		internal void method_578()
		{
			GClass84.smethod_1195(GClass84.smethod_105(), false);
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x000FF5C0 File Offset: 0x000FD7C0
		internal void method_579()
		{
			this.method_673();
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000FF5D4 File Offset: 0x000FD7D4
		internal void method_580()
		{
			this.method_859();
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x000FF5E8 File Offset: 0x000FD7E8
		internal void method_581()
		{
			this.method_96();
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x000FF5FC File Offset: 0x000FD7FC
		private void method_582()
		{
			this.method_899();
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000FF610 File Offset: 0x000FD810
		[CompilerGenerated]
		private void method_583()
		{
			this.method_935();
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x000FF624 File Offset: 0x000FD824
		internal void method_584()
		{
			this.method_125();
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000FF638 File Offset: 0x000FD838
		private void method_585()
		{
			this.method_33();
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000FF64C File Offset: 0x000FD84C
		[CompilerGenerated]
		private void method_586()
		{
			this.method_322();
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x000FF660 File Offset: 0x000FD860
		[CompilerGenerated]
		private void method_587()
		{
			this.method_241();
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x000FF674 File Offset: 0x000FD874
		internal void method_588()
		{
			this.method_164();
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x000FF688 File Offset: 0x000FD888
		private void method_589(float float_7)
		{
			this.method_380(float_7);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x000FF69C File Offset: 0x000FD89C
		internal void method_590()
		{
			GClass84.smethod_13(GClass84.smethod_772());
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x000FF6B4 File Offset: 0x000FD8B4
		[CompilerGenerated]
		private void method_591()
		{
			this.method_882();
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x000FF6C8 File Offset: 0x000FD8C8
		internal void method_592()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[] {",
				"Crash",
				"Player",
				"_",
				"Avatar",
				"_",
				"Quest",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x000FF73C File Offset: 0x000FD93C
		internal void method_593()
		{
			this.method_632();
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x000FF750 File Offset: 0x000FD950
		internal void method_594()
		{
			this.method_998();
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x000FF764 File Offset: 0x000FD964
		internal void method_595()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass177.gclass30_41.method_11(false);
				GClass177.gclass30_42.method_11(false);
			}
			else if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.list_23, apiAvatar.authorId, ""))
			{
				GClass177.gclass30_41.method_11(false);
				GClass177.gclass30_42.method_11(true);
			}
			else
			{
				GClass177.gclass30_41.method_11(true);
				GClass177.gclass30_42.method_11(false);
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
		internal void method_596(GameObject gameObject_0)
		{
			this.method_1020(gameObject_0);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x000FF7F4 File Offset: 0x000FD9F4
		[CompilerGenerated]
		private void method_597()
		{
			this.method_238();
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x000FF808 File Offset: 0x000FDA08
		internal void method_598()
		{
			this.method_318();
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x000FF81C File Offset: 0x000FDA1C
		internal void method_599()
		{
			this.method_473();
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x000FF830 File Offset: 0x000FDA30
		[CompilerGenerated]
		private void method_600()
		{
			this.method_499();
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000FF844 File Offset: 0x000FDA44
		internal void method_601()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass177.gclass30_43.method_11(false);
				GClass177.gclass30_44.method_11(false);
			}
			else if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.list_25, apiAvatar.id, ""))
			{
				GClass177.gclass30_43.method_11(false);
				GClass177.gclass30_44.method_11(true);
			}
			else
			{
				GClass177.gclass30_43.method_11(true);
				GClass177.gclass30_44.method_11(false);
			}
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000FF8C0 File Offset: 0x000FDAC0
		private void method_602()
		{
			this.method_779(GClass84.GEnum47.const_0);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x000FF8D4 File Offset: 0x000FDAD4
		private void method_603()
		{
			this.method_305(1f);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x000FF8EC File Offset: 0x000FDAEC
		private void method_604()
		{
			this.method_8();
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x000FF900 File Offset: 0x000FDB00
		private void method_605()
		{
			this.method_204();
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x000FF914 File Offset: 0x000FDB14
		private void method_606()
		{
			this.method_528();
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x000FF928 File Offset: 0x000FDB28
		private void method_607()
		{
			this.method_218(7);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x000FF93C File Offset: 0x000FDB3C
		[CompilerGenerated]
		private void method_608()
		{
			this.method_340();
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x000FF950 File Offset: 0x000FDB50
		[CompilerGenerated]
		private void method_609()
		{
			this.method_905();
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x000FF964 File Offset: 0x000FDB64
		internal void method_610()
		{
			APIUser apiuser = GClass84.smethod_821();
			if (apiuser == null)
			{
				GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					apiuser.displayName,
					" ",
					"has",
					" ",
					"ID",
					" ",
					GClass84.smethod_1520(apiuser)
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
		internal void method_611()
		{
			GClass177.gclass99_5 = new GClass99(GClass177.gclass99_4, 1f, 0f, "Teleport Weapons", "Teleport Weapons", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass30_53 = new GClass30(GClass177.gclass99_4, 2f, 0f, "Kill", new Action(this.method_267), "Kill.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass99_7 = new GClass99(GClass177.gclass99_4, 3f, 0f, "Set Role", "Set Role", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass30_54 = new GClass30(GClass177.gclass99_4, 4f, 0f, "Collect All Clues", new Action(this.method_129), "Collect All Clues.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_55 = new GClass30(GClass177.gclass99_4, 2f, 1f, "Auto Kill", new Action(this.method_696), "Auto Kill.", new Color?(Color.cyan), new Color?(Color.white), null);
			this.method_639();
			this.method_732();
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x000FFB58 File Offset: 0x000FDD58
		internal void method_612(int int_3)
		{
			this.method_119(int_3);
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000FFB6C File Offset: 0x000FDD6C
		private void method_613()
		{
			this.method_506("Variables_Distance", false);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000FFB88 File Offset: 0x000FDD88
		[CompilerGenerated]
		private void method_614()
		{
			this.method_636();
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x000FFB9C File Offset: 0x000FDD9C
		internal void method_615()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.gclass141_0.method_178(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_0, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x000FFC2C File Offset: 0x000FDE2C
		private void method_616(float float_7)
		{
			this.method_372(float_7);
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x000FFC40 File Offset: 0x000FDE40
		private void method_617()
		{
			this.method_343(GClass144.GEnum35.const_3);
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x000FFC54 File Offset: 0x000FDE54
		[CompilerGenerated]
		private void method_618()
		{
			this.method_945();
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x000FFC68 File Offset: 0x000FDE68
		internal void method_619()
		{
			this.method_423();
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x000FFC7C File Offset: 0x000FDE7C
		private void method_620()
		{
			this.method_455();
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x000FFC90 File Offset: 0x000FDE90
		internal void method_621()
		{
			GClass177.list_4.Clear();
			for (int i = 0; i < 10; i++)
			{
				GClass177.list_4.Add(new GClass30(GClass177.gclass99_6, 2.375f, -0.125f + 0.25f * (float)i, 3.25f, 0.25f, "Object" + i.ToString(), new Action(this.method_191), "Object" + i.ToString() + ".", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5));
			}
			GClass177.list_4[1].method_20(new Action(this.method_553));
			GClass177.list_4[2].method_20(new Action(this.method_751));
			GClass177.list_4[3].method_20(new Action(this.method_923));
			GClass177.list_4[4].method_20(new Action(this.method_797));
			GClass177.list_4[5].method_20(new Action(this.method_365));
			GClass177.list_4[6].method_20(new Action(this.method_746));
			GClass177.list_4[7].method_20(new Action(this.method_31));
			GClass177.list_4[8].method_20(new Action(this.method_645));
			GClass177.list_4[9].method_20(new Action(this.method_842));
			GClass177.gclass30_142 = new GClass30(GClass177.gclass99_6, 4.25f, 0f, 0.5f, 0.5f, "Up", new Action(this.method_123), "Up", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_141 = new GClass30(GClass177.gclass99_6, 4.25f, 2f, 0.5f, 0.5f, "Down", new Action(this.method_488), "Down", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_143 = new GClass30(GClass177.gclass99_6, 3f, -0.375f, 1f, 0.25f, "Update", new Action(this.method_151), "Update", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5);
			this.method_214(false, false);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000FFF2C File Offset: 0x000FE12C
		internal void method_622()
		{
			this.method_430();
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x000FFF40 File Offset: 0x000FE140
		internal void method_623()
		{
			this.method_813();
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x000FFF54 File Offset: 0x000FE154
		internal void method_624()
		{
			GClass84.gclass148_0.method_74(GClass84.smethod_778());
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000FFF70 File Offset: 0x000FE170
		private void method_625()
		{
			this.method_819();
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000FFF84 File Offset: 0x000FE184
		internal void method_626()
		{
			GClass177.gclass99_12 = new GClass99(GClass177.gclass99_11, 1f, 0f, "TeleportPosition", "TeleportPosition", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_12.method_12().method_19(new Action(this.method_655));
			GClass177.gclass99_13 = new GClass99(GClass177.gclass99_11, 2f, 0f, "OrbitType", "OrbitType", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_13.method_12().method_19(new Action(this.method_242));
			GClass177.gclass99_14 = new GClass99(GClass177.gclass99_11, 3f, 0f, "Speed", "Speed", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_14.method_12().method_19(new Action(this.method_608));
			GClass177.gclass99_15 = new GClass99(GClass177.gclass99_11, 4f, 0f, "Distance", "Distance", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_15.method_12().method_19(new Action(this.method_764));
			GClass177.gclass99_16 = new GClass99(GClass177.gclass99_11, 1f, 1f, "Height", "Height", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_16.method_12().method_19(new Action(this.method_799));
			GClass177.gclass99_17 = new GClass99(GClass177.gclass99_11, 2f, 1f, "Angle", "Angle", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_17.method_12().method_19(new Action(this.method_149));
			GClass177.gclass99_18 = new GClass99(GClass177.gclass99_11, 3f, 1f, "Fluctuations", "Fluctuations", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_18.method_12().method_19(new Action(this.method_722));
			GClass177.gclass99_19 = new GClass99(GClass177.gclass99_11, 4f, 1f, "FluctuationsSpeed", "FluctuationsSpeed", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_19.method_12().method_19(new Action(this.method_587));
			GClass177.gclass99_20 = new GClass99(GClass177.gclass99_11, 1f, 2f, "FluctuationsSpeed2", "FluctuationsSpeed2", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_18.method_12().method_19(new Action(this.method_260));
			this.method_561();
			this.method_917();
			this.method_634();
			this.method_646();
			this.method_721();
			this.method_217();
			this.method_805();
			this.method_216();
			this.method_484();
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00100370 File Offset: 0x000FE570
		[CompilerGenerated]
		private void method_627()
		{
			this.method_606();
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00100384 File Offset: 0x000FE584
		internal void method_628()
		{
			this.method_1022();
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00100398 File Offset: 0x000FE598
		internal void method_629()
		{
			this.method_301();
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x001003AC File Offset: 0x000FE5AC
		internal void method_630(string string_1, bool bool_26)
		{
			if (string_1 != null)
			{
				if ((string_1 == "Variables_TeleportPosition" || string_1 == "All") && (GClass177.gclass28_0 != null && (!bool_26 || GClass177.gclass28_0.method_3().activeInHierarchy)))
				{
					string string_2 = string.Empty;
					switch (this.genum47_0)
					{
					case GClass84.GEnum47.const_0:
						string_2 = "EP_Position";
						break;
					case GClass84.GEnum47.const_1:
						string_2 = "EP_Head";
						break;
					case GClass84.GEnum47.const_2:
						string_2 = "EP_Center";
						break;
					}
					GClass177.gclass28_0.method_28(string_2);
				}
				if ((string_1 == "Variables_OrbitType" || string_1 == "All") && (GClass177.gclass28_1 != null && (!bool_26 || GClass177.gclass28_1.method_3().activeInHierarchy)))
				{
					string string_3 = string.Empty;
					switch (this.genum35_0)
					{
					case GClass144.GEnum35.const_0:
						string_3 = "EOT_Rotate";
						break;
					case GClass144.GEnum35.const_1:
						string_3 = "EOT_RotateWithFluctuations";
						break;
					case GClass144.GEnum35.const_2:
						string_3 = "EOT_RotateWithGlobalFluctuations";
						break;
					case GClass144.GEnum35.const_3:
						string_3 = "EOT_RotateWithRandomFluctuations";
						break;
					}
					GClass177.gclass28_1.method_28(string_3);
				}
				if ((string_1 == "Variables_Speed" || string_1 == "All") && (GClass177.gclass28_2 != null && (!bool_26 || GClass177.gclass28_2.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_2.method_28(this.float_0.ToString());
				}
				if ((string_1 == "Variables_Distance" || string_1 == "All") && (GClass177.gclass28_3 != null && (!bool_26 || GClass177.gclass28_3.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_3.method_28(this.float_1.ToString());
				}
				if ((string_1 == "Variables_Height" || string_1 == "All") && (GClass177.gclass28_4 != null && (!bool_26 || GClass177.gclass28_4.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_4.method_28(this.float_2.ToString());
				}
				if ((string_1 == "Variables_Angle" || string_1 == "All") && (GClass177.gclass28_5 != null && (!bool_26 || GClass177.gclass28_5.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_5.method_28(this.float_3.ToString());
				}
				if ((string_1 == "Variables_Fluctuations" || string_1 == "All") && (GClass177.gclass28_6 != null && (!bool_26 || GClass177.gclass28_6.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_6.method_28(this.float_4.ToString());
				}
				if ((string_1 == "Variables_FluctuationsSpeed" || string_1 == "All") && (GClass177.gclass28_7 != null && (!bool_26 || GClass177.gclass28_7.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_7.method_28(this.float_5.ToString());
				}
				if ((string_1 == "Variables_FluctuationsSpeed2" || string_1 == "All") && (GClass177.gclass28_8 != null && (!bool_26 || GClass177.gclass28_8.method_3().activeInHierarchy)))
				{
					GClass177.gclass28_8.method_28(this.float_6.ToString());
				}
			}
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00100728 File Offset: 0x000FE928
		[CompilerGenerated]
		private void method_631()
		{
			this.method_640();
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x0010073C File Offset: 0x000FE93C
		internal void method_632()
		{
			GClass177.gclass30_59 = new GClass30(GClass177.gclass99_5, 1f, 0f, "Teleport All Weapons", new Action(this.method_130), "Teleport All Weapons.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_60 = new GClass30(GClass177.gclass99_5, 2f, 0f, "Teleport Weapons", new Action(this.method_727), "Teleport Weapons.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_61 = new GClass30(GClass177.gclass99_5, 3f, 0f, "Teleport Murderer Weapons", new Action(this.method_609), "Teleport Murderer Weapons.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass99_6 = new GClass99(GClass177.gclass99_5, 4f, 0f, "Teleport Weapon", "Teleport Weapon", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass99_6.method_12().method_19(new Action(this.method_281));
			GClass177.gclass30_62 = new GClass30(GClass177.gclass99_5, 1f, 1f, "Teleport Revolver", new Action(this.method_775), "Teleport Revolver.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_63 = new GClass30(GClass177.gclass99_5, 2f, 1f, "Teleport Unlockable Weapons", new Action(this.method_230), "Teleport Unlockable Weapons.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_64 = new GClass30(GClass177.gclass99_5, 3f, 1f, "Teleport Knives", new Action(this.method_110), "Teleport Knives.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_65 = new GClass30(GClass177.gclass99_5, 4f, 1f, "Teleport Bear Traps", new Action(this.method_160), "Teleport Bear Traps.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_66 = new GClass30(GClass177.gclass99_5, 1f, 2f, "Attach Murderer Weapons", new Action(this.method_692), "Attach Murderer Weapons.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_67 = new GClass30(GClass177.gclass99_5, 2f, 2f, "Attach Knives", new Action(this.method_776), "Attach Knives.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_68 = new GClass30(GClass177.gclass99_5, 3f, 2f, "Attach Bear Traps", new Action(this.method_586), "Attach Bear Traps.", new Color?(Color.cyan), new Color?(Color.white), null);
			this.method_623();
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x00100A60 File Offset: 0x000FEC60
		internal void method_633()
		{
			GClass84.gclass141_0.method_84(GClass84.smethod_977(GClass84.smethod_772(), ""));
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00100A88 File Offset: 0x000FEC88
		internal void method_634()
		{
			this.method_45();
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00100A9C File Offset: 0x000FEC9C
		private void method_635()
		{
			this.method_61(3f);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00100AB4 File Offset: 0x000FECB4
		private void method_636()
		{
			this.method_18();
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00100AC8 File Offset: 0x000FECC8
		private void method_637()
		{
			this.method_470();
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00100ADC File Offset: 0x000FECDC
		private void method_638()
		{
			this.method_257();
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00100AF0 File Offset: 0x000FECF0
		internal void method_639()
		{
			this.method_593();
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00100B04 File Offset: 0x000FED04
		private void method_640()
		{
			this.method_875();
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00100B18 File Offset: 0x000FED18
		internal void method_641()
		{
			this.method_39();
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00100B2C File Offset: 0x000FED2C
		private void method_642()
		{
			this.method_139();
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00100B40 File Offset: 0x000FED40
		internal void method_643()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (!vrcplayer)
			{
				GClass70.smethod_38("VRCP Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				APIUser apiuser = GClass84.smethod_821();
				if (apiuser == null)
				{
					GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					apiuser.displayName,
					" ",
					"has",
					" ",
					"User",
					" ",
					"ID",
					" ",
					GClass84.smethod_385(vrcplayer)
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00100BE0 File Offset: 0x000FEDE0
		private void method_644()
		{
			this.method_490();
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00100BF4 File Offset: 0x000FEDF4
		[CompilerGenerated]
		private void method_645()
		{
			this.method_474();
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00100C08 File Offset: 0x000FEE08
		internal void method_646()
		{
			this.method_291();
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00100C1C File Offset: 0x000FEE1C
		private void method_647()
		{
			this.method_76(8);
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00100C30 File Offset: 0x000FEE30
		public override void vmethod_23()
		{
			this.method_840();
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00100C44 File Offset: 0x000FEE44
		private void method_648()
		{
			this.method_23(-3);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00100C5C File Offset: 0x000FEE5C
		internal void method_649()
		{
			this.method_800();
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00100C70 File Offset: 0x000FEE70
		internal void method_650()
		{
			this.method_707();
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00100C84 File Offset: 0x000FEE84
		internal GClass181.GStruct270 method_651(int int_3)
		{
			int num = this.method_700(int_3);
			GClass181.GStruct270 result;
			if (num >= 0 && num < GClass177.list_0.Count)
			{
				result = GClass177.list_0[num];
			}
			else
			{
				result = default(GClass181.GStruct270);
			}
			return result;
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00100CC8 File Offset: 0x000FEEC8
		internal void method_652()
		{
			GClass177.gclass30_107 = new GClass30(GClass177.gclass99_16, 1f, -0.25f, 1f, 0.5f, "+0.5", new Action(this.method_806), "Increment Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_106 = new GClass30(GClass177.gclass99_16, 1f, 0.25f, 1f, 0.5f, "+0.2", new Action(this.method_669), "Increment Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_105 = new GClass30(GClass177.gclass99_16, 1f, 0.75f, 1f, 0.5f, "Height+0.05", new Action(this.method_41), "Increment Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_108 = new GClass30(GClass177.gclass99_16, 1f, 1.25f, 1f, 0.5f, "Height-0.05", new Action(this.method_352), "Decrement Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_109 = new GClass30(GClass177.gclass99_16, 1f, 1.75f, 1f, 0.5f, "-0.2", new Action(this.method_400), "Decrement Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_110 = new GClass30(GClass177.gclass99_16, 1f, 2.25f, 1f, 0.5f, "-0.5", new Action(this.method_965), "Decrement Height.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_16;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_4 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00100EE0 File Offset: 0x000FF0E0
		internal void method_653()
		{
			this.method_720();
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00100EF4 File Offset: 0x000FF0F4
		[CompilerGenerated]
		private void method_654()
		{
			this.method_467();
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00100F08 File Offset: 0x000FF108
		[CompilerGenerated]
		private void method_655()
		{
			this.method_479();
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00100F1C File Offset: 0x000FF11C
		private void method_656()
		{
			this.method_993();
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00100F30 File Offset: 0x000FF130
		internal void method_657()
		{
			string text = GClass84.smethod_778();
			if (string.IsNullOrEmpty(text))
			{
				GClass70.smethod_38("UserID Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_313(text);
				this.method_671();
			}
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00100F6C File Offset: 0x000FF16C
		private void method_658()
		{
			this.method_341();
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00100F80 File Offset: 0x000FF180
		private void method_659()
		{
			this.method_236();
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00100F94 File Offset: 0x000FF194
		internal void method_660()
		{
			this.method_274();
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00100FA8 File Offset: 0x000FF1A8
		private void method_661()
		{
			this.method_153();
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00100FBC File Offset: 0x000FF1BC
		private void method_662()
		{
			this.method_76(6);
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00100FD0 File Offset: 0x000FF1D0
		[CompilerGenerated]
		private void method_663()
		{
			this.method_227();
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00100FE4 File Offset: 0x000FF1E4
		internal void method_664()
		{
			this.method_513();
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00100FF8 File Offset: 0x000FF1F8
		internal void method_665()
		{
			this.method_578();
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x0010100C File Offset: 0x000FF20C
		private void method_666()
		{
			this.method_960();
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00101020 File Offset: 0x000FF220
		internal void method_667()
		{
			GClass84.GEnum48 genum48_;
			switch (this.genum47_0)
			{
			case GClass84.GEnum47.const_0:
				genum48_ = GClass84.GEnum48.const_0;
				break;
			case GClass84.GEnum47.const_1:
				genum48_ = GClass84.GEnum48.const_1;
				break;
			case GClass84.GEnum47.const_2:
				genum48_ = GClass84.GEnum48.const_2;
				break;
			default:
				return;
			}
			GClass84.gclass144_0.method_24(GClass84.smethod_461(), GClass84.smethod_105(), default(Vector3), genum48_, GClass144.GEnum34.const_0, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x0010109C File Offset: 0x000FF29C
		[CompilerGenerated]
		private void method_668()
		{
			this.method_890();
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x001010B0 File Offset: 0x000FF2B0
		[CompilerGenerated]
		private void method_669()
		{
			this.method_311();
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x001010C4 File Offset: 0x000FF2C4
		internal void method_670()
		{
			this.method_710();
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x001010D8 File Offset: 0x000FF2D8
		internal void method_671()
		{
			this.method_584();
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x001010EC File Offset: 0x000FF2EC
		private void method_672()
		{
			this.method_212();
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00101100 File Offset: 0x000FF300
		internal void method_673()
		{
			GClass177.gclass30_113 = new GClass30(GClass177.gclass99_17, 1f, -0.25f, 1f, 0.5f, "+9", new Action(this.method_485), "Increment Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_112 = new GClass30(GClass177.gclass99_17, 1f, 0.25f, 1f, 0.5f, "+3", new Action(this.method_851), "Increment Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_111 = new GClass30(GClass177.gclass99_17, 1f, 0.75f, 1f, 0.5f, "Angle+1", new Action(this.method_591), "Increment Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_114 = new GClass30(GClass177.gclass99_17, 1f, 1.25f, 1f, 0.5f, "Angle-1", new Action(this.method_654), "Decrement Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_115 = new GClass30(GClass177.gclass99_17, 1f, 1.75f, 1f, 0.5f, "-3", new Action(this.method_858), "Decrement Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_116 = new GClass30(GClass177.gclass99_17, 1f, 2.25f, 1f, 0.5f, "-9", new Action(this.method_804), "Decrement Angle.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_17;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_5 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00101318 File Offset: 0x000FF518
		private void method_674()
		{
			this.method_752(9);
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00101330 File Offset: 0x000FF530
		private void method_675()
		{
			this.method_564();
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00101344 File Offset: 0x000FF544
		internal void method_676()
		{
			this.method_508();
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00101358 File Offset: 0x000FF558
		private void method_677()
		{
			this.method_832();
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x0010136C File Offset: 0x000FF56C
		[CompilerGenerated]
		private void method_678()
		{
			this.method_753();
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00101380 File Offset: 0x000FF580
		[CompilerGenerated]
		private void method_679()
		{
			this.method_239();
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00101394 File Offset: 0x000FF594
		internal void method_680()
		{
			this.method_792();
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x001013A8 File Offset: 0x000FF5A8
		internal void method_681()
		{
			this.method_730();
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x001013BC File Offset: 0x000FF5BC
		private void method_682()
		{
			this.method_184();
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x001013D0 File Offset: 0x000FF5D0
		internal void method_683()
		{
			this.method_102();
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x001013E4 File Offset: 0x000FF5E4
		private void method_684()
		{
			this.method_774();
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x001013F8 File Offset: 0x000FF5F8
		internal void method_685(GClass181.GStruct270 gstruct270_0)
		{
			this.method_759(gstruct270_0);
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x0010140C File Offset: 0x000FF60C
		private void method_686()
		{
			this.method_91();
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00101420 File Offset: 0x000FF620
		private void method_687()
		{
			this.method_101();
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00101434 File Offset: 0x000FF634
		internal void method_688()
		{
			GClass84.gclass141_0.method_17(GClass84.smethod_977(GClass84.smethod_772(), ""));
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x0010145C File Offset: 0x000FF65C
		private void method_689()
		{
			this.method_231();
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00101470 File Offset: 0x000FF670
		private void method_690()
		{
			this.method_836(9f);
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00101488 File Offset: 0x000FF688
		private void method_691()
		{
			this.method_836(-1f);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x001014A0 File Offset: 0x000FF6A0
		[CompilerGenerated]
		private void method_692()
		{
			this.method_950();
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x001014B4 File Offset: 0x000FF6B4
		internal void method_693()
		{
			this.method_670();
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x001014C8 File Offset: 0x000FF6C8
		internal void method_694()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"] {",
				"Set",
				"Mimic",
				"User",
				"ID",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00101548 File Offset: 0x000FF748
		internal void method_695()
		{
			this.method_521();
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x0010155C File Offset: 0x000FF75C
		[CompilerGenerated]
		private void method_696()
		{
			this.method_157();
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00101570 File Offset: 0x000FF770
		internal void method_697()
		{
			this.method_486();
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00101584 File Offset: 0x000FF784
		[CompilerGenerated]
		private void method_698()
		{
			this.method_946();
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x00101598 File Offset: 0x000FF798
		internal GameObject method_699(int int_3)
		{
			int num = this.method_566(int_3);
			GameObject result;
			if (num >= 0 && num < GClass177.list_3.Count)
			{
				result = GClass177.list_3[num];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x001015D4 File Offset: 0x000FF7D4
		internal int method_700(int int_3)
		{
			return int_3 + GClass177.int_0;
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x00101640 File Offset: 0x000FF840
		private void method_701()
		{
			this.method_893();
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00101654 File Offset: 0x000FF854
		internal void method_702()
		{
			this.method_619();
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00101668 File Offset: 0x000FF868
		private void method_703(float float_7)
		{
			this.method_844(float_7);
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x0010167C File Offset: 0x000FF87C
		private void method_704()
		{
			this.method_605();
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00101690 File Offset: 0x000FF890
		internal void method_705()
		{
			this.method_762();
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x001016A4 File Offset: 0x000FF8A4
		internal void method_706()
		{
			this.method_814();
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x001016B8 File Offset: 0x000FF8B8
		internal void method_707()
		{
			Transform transform = GClass84.smethod_288();
			if (transform)
			{
				GClass84.gclass141_0.method_44(GClass84.smethod_272(transform, this.genum47_0));
			}
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x001016F0 File Offset: 0x000FF8F0
		private void method_708()
		{
			this.method_986();
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x00101704 File Offset: 0x000FF904
		private void method_709()
		{
			this.method_576();
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x00101718 File Offset: 0x000FF918
		internal void method_710()
		{
			GClass84.gclass141_0.method_132(GClass84.smethod_977(GClass84.smethod_772(), ""));
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x00101740 File Offset: 0x000FF940
		internal void method_711(GClass84.GEnum47 genum47_1)
		{
			this.method_159(genum47_1);
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x00101754 File Offset: 0x000FF954
		[CompilerGenerated]
		private void method_712()
		{
			this.method_887();
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00101768 File Offset: 0x000FF968
		internal void method_713()
		{
			this.method_382();
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x0010177C File Offset: 0x000FF97C
		private void method_714()
		{
			this.method_46();
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00101790 File Offset: 0x000FF990
		private void method_715()
		{
			this.method_674();
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x001017A4 File Offset: 0x000FF9A4
		internal void method_716()
		{
			this.method_437();
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x001017B8 File Offset: 0x000FF9B8
		private void method_717()
		{
			this.method_61(-1f);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x001017D0 File Offset: 0x000FF9D0
		internal void method_718()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (vrcplayer)
			{
				GClass84.GEnum48 genum48_;
				switch (this.genum47_0)
				{
				case GClass84.GEnum47.const_0:
					genum48_ = GClass84.GEnum48.const_0;
					break;
				case GClass84.GEnum47.const_1:
					genum48_ = GClass84.GEnum48.const_1;
					break;
				case GClass84.GEnum47.const_2:
					genum48_ = GClass84.GEnum48.const_2;
					break;
				default:
					return;
				}
				GClass84.gclass144_0.method_16(GClass84.smethod_589(), vrcplayer, default(Vector3), genum48_, GClass144.GEnum34.const_0, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x0010185C File Offset: 0x000FFA5C
		internal void method_719()
		{
			this.method_739();
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00101870 File Offset: 0x000FFA70
		internal void method_720()
		{
			this.method_538();
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x00101884 File Offset: 0x000FFA84
		internal void method_721()
		{
			this.method_1007();
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00101898 File Offset: 0x000FFA98
		[CompilerGenerated]
		private void method_722()
		{
			this.method_22();
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001018AC File Offset: 0x000FFAAC
		private void method_723(float float_7)
		{
			this.method_516(this.float_2 + float_7);
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x001018C8 File Offset: 0x000FFAC8
		internal void method_724(bool bool_26, bool bool_27)
		{
			if (!bool_26)
			{
				if (!bool_27)
				{
					GClass177.int_0 = 0;
				}
				GClass177.list_0.Clear();
				for (int i = 0; i < GClass84.gclass181_0.list_1.Count; i++)
				{
					GClass177.list_0.Add(GClass84.gclass181_0.list_1[i]);
				}
				this.method_402();
			}
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x0010192C File Offset: 0x000FFB2C
		[CompilerGenerated]
		private void method_725()
		{
			this.method_369();
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x00101940 File Offset: 0x000FFB40
		internal void method_726()
		{
			this.method_989();
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00101954 File Offset: 0x000FFB54
		[CompilerGenerated]
		private void method_727()
		{
			this.method_822();
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00101968 File Offset: 0x000FFB68
		internal void method_728()
		{
			this.method_206();
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x0010197C File Offset: 0x000FFB7C
		private void method_729()
		{
			this.method_421();
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00101990 File Offset: 0x000FFB90
		internal void method_730()
		{
			this.method_20();
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x001019A4 File Offset: 0x000FFBA4
		internal void method_731()
		{
			this.method_601();
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x001019B8 File Offset: 0x000FFBB8
		internal void method_732()
		{
			this.method_726();
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001019CC File Offset: 0x000FFBCC
		[CompilerGenerated]
		private void method_733()
		{
			this.method_89();
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x001019E0 File Offset: 0x000FFBE0
		internal void method_734()
		{
			GClass84.gclass141_0.method_206(GClass84.smethod_977(GClass84.smethod_772(), ""));
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00101A08 File Offset: 0x000FFC08
		private void method_735()
		{
			this.method_305(-1f);
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00101A20 File Offset: 0x000FFC20
		private void method_736()
		{
			this.method_866();
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00101A34 File Offset: 0x000FFC34
		private void method_737()
		{
			this.method_850();
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00101A48 File Offset: 0x000FFC48
		private void method_738()
		{
			this.method_426();
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00101A5C File Offset: 0x000FFC5C
		internal void method_739()
		{
			GClass84.gclass148_0.method_66(string.Concat(new string[]
			{
				"[",
				"Bots",
				"Manager",
				"] {",
				"Set",
				"Owner",
				"(",
				GClass84.smethod_778(),
				");}"
			}));
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00101AC8 File Offset: 0x000FFCC8
		private void method_740()
		{
			this.method_927();
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00101ADC File Offset: 0x000FFCDC
		[CompilerGenerated]
		private void method_741()
		{
			this.method_292();
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00101AF0 File Offset: 0x000FFCF0
		[CompilerGenerated]
		private void method_742()
		{
			this.method_778();
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00101B04 File Offset: 0x000FFD04
		private void method_743()
		{
			this.method_830();
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00101B18 File Offset: 0x000FFD18
		private void method_744()
		{
			this.method_305(-3f);
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00101B30 File Offset: 0x000FFD30
		[CompilerGenerated]
		private void method_745()
		{
			this.method_977();
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00101B44 File Offset: 0x000FFD44
		[CompilerGenerated]
		private void method_746()
		{
			this.method_531();
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00101B58 File Offset: 0x000FFD58
		internal void method_747()
		{
			this.method_592();
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00101B6C File Offset: 0x000FFD6C
		internal void method_748()
		{
			GClass177.gclass30_77 = new GClass30(GClass177.gclass99_21, 1f, 0f, "Set As Target", new Action(this.method_554), "Set As Target.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_78 = new GClass30(GClass177.gclass99_21, 2f, 0f, "Triggers", new Action(this.method_198), "Triggers.", new Color?(Color.cyan), new Color?(Color.white), null);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00101C04 File Offset: 0x000FFE04
		private void method_749(float float_7)
		{
			this.method_760(float_7);
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00101C18 File Offset: 0x000FFE18
		private void method_750()
		{
			this.method_550();
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00101C2C File Offset: 0x000FFE2C
		[CompilerGenerated]
		private void method_751()
		{
			this.method_656();
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00101C40 File Offset: 0x000FFE40
		internal void method_752(int int_3)
		{
			this.method_612(int_3);
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00101C54 File Offset: 0x000FFE54
		private void method_753()
		{
			this.method_229();
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00101C68 File Offset: 0x000FFE68
		internal void method_754()
		{
			this.method_763();
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00101C7C File Offset: 0x000FFE7C
		internal void method_755()
		{
			this.method_37();
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00101C90 File Offset: 0x000FFE90
		private void method_756()
		{
			this.method_73();
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00101CA4 File Offset: 0x000FFEA4
		private void method_757()
		{
			this.method_653();
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00101CB8 File Offset: 0x000FFEB8
		internal void method_758()
		{
			this.method_269();
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00101CCC File Offset: 0x000FFECC
		internal void method_759(GClass181.GStruct270 gstruct270_0)
		{
			GClass84.gclass181_0.method_14(GClass84.smethod_105().gameObject, GClass84.smethod_821(), gstruct270_0.string_1, gstruct270_0.string_2);
			this.method_70(false, true);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00101D08 File Offset: 0x000FFF08
		private void method_760(float float_7)
		{
			this.method_703(this.float_3 + float_7);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00101D24 File Offset: 0x000FFF24
		private void method_761()
		{
			this.method_187();
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00101D38 File Offset: 0x000FFF38
		internal void method_762()
		{
			GClass84.smethod_225(GClass84.smethod_126());
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00101D50 File Offset: 0x000FFF50
		internal void method_763()
		{
			GClass84.gclass141_0.method_72(GClass84.smethod_1309());
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00101D70 File Offset: 0x000FFF70
		[CompilerGenerated]
		private void method_764()
		{
			this.method_313();
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00101D84 File Offset: 0x000FFF84
		private void method_765()
		{
			this.method_148();
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00101D98 File Offset: 0x000FFF98
		internal void method_766()
		{
			GClass84.smethod_648(GClass84.smethod_1157());
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00101DB0 File Offset: 0x000FFFB0
		internal void method_767()
		{
			this.method_912();
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00101DC4 File Offset: 0x000FFFC4
		private void method_768()
		{
			this.method_483();
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00101DD8 File Offset: 0x000FFFD8
		private void method_769()
		{
			this.method_224();
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00101DEC File Offset: 0x000FFFEC
		private void method_770()
		{
			this.method_300(0.05f);
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00101E04 File Offset: 0x00100004
		internal void method_771()
		{
			this.method_1012();
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00101E18 File Offset: 0x00100018
		private void method_772()
		{
			this.method_218(1);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00101E2C File Offset: 0x0010002C
		internal void method_773()
		{
			this.method_1009();
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x00101E40 File Offset: 0x00100040
		internal void method_774()
		{
			this.method_829();
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00101E54 File Offset: 0x00100054
		[CompilerGenerated]
		private void method_775()
		{
			this.method_571();
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00101E68 File Offset: 0x00100068
		[CompilerGenerated]
		private void method_776()
		{
			this.method_116();
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00101E7C File Offset: 0x0010007C
		[CompilerGenerated]
		private void method_777()
		{
			this.method_306();
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00101E90 File Offset: 0x00100090
		private void method_778()
		{
			this.method_803();
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00101EA4 File Offset: 0x001000A4
		internal void method_779(GClass84.GEnum47 genum47_1)
		{
			this.method_711(genum47_1);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00101EB8 File Offset: 0x001000B8
		internal void method_780()
		{
			this.method_92();
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00101ECC File Offset: 0x001000CC
		private void method_781()
		{
			this.method_616(-0.5f);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00101EE4 File Offset: 0x001000E4
		[CompilerGenerated]
		private void method_782()
		{
			this.method_768();
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00101EF8 File Offset: 0x001000F8
		[CompilerGenerated]
		private void method_783()
		{
			this.method_436();
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00101F0C File Offset: 0x0010010C
		internal void method_784()
		{
			GClass84.gclass138_0.method_124();
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00101F24 File Offset: 0x00100124
		private void method_785()
		{
			this.method_536();
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x00101F38 File Offset: 0x00100138
		internal void method_786()
		{
			this.method_491();
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00101F4C File Offset: 0x0010014C
		internal void method_787()
		{
			this.method_860();
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00101F60 File Offset: 0x00100160
		internal void method_788()
		{
			this.method_478();
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00101F74 File Offset: 0x00100174
		[CompilerGenerated]
		private void method_789()
		{
			this.method_843();
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x00101F88 File Offset: 0x00100188
		internal void method_790()
		{
			if (GClass84.gclass184_0 != null && this.bool_8)
			{
				GClass177.gclass30_13 = new GClass30(GClass177.gclass99_23, 1f, 0f, "Enable Touch", new Action(this.method_370), "Enable Touch.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_14 = new GClass30(GClass177.gclass99_23, 1f, 1f, "Disable Touch", new Action(this.method_109), "Disable Touch.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (GClass84.gclass184_0 != null && this.bool_9)
			{
				GClass177.gclass30_15 = new GClass30(GClass177.gclass99_23, 2f, 0f, "Enable Touch Me", new Action(this.method_997), "Enable Touch Me.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_16 = new GClass30(GClass177.gclass99_23, 2f, 1f, "Disable Touch Me", new Action(this.method_877), "Disable Touch Me.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x001020D0 File Offset: 0x001002D0
		internal void method_791()
		{
			this.method_333();
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x001020E4 File Offset: 0x001002E4
		internal void method_792()
		{
			this.method_283();
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001020F8 File Offset: 0x001002F8
		internal void method_793(GClass144.GEnum35 genum35_1)
		{
			this.genum35_0 = genum35_1;
			this.method_506("Variables_OrbitType", false);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00102118 File Offset: 0x00100318
		internal void method_794()
		{
			this.method_716();
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x0010212C File Offset: 0x0010032C
		[CompilerGenerated]
		private void method_795()
		{
			this.method_920();
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00102140 File Offset: 0x00100340
		internal void method_796()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_241(apiAvatar.id);
				this.method_371();
			}
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00102180 File Offset: 0x00100380
		[CompilerGenerated]
		private void method_797()
		{
			this.method_498();
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00102194 File Offset: 0x00100394
		internal void method_798()
		{
			this.method_540();
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x001021A8 File Offset: 0x001003A8
		[CompilerGenerated]
		private void method_799()
		{
			this.method_701();
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x001021BC File Offset: 0x001003BC
		internal void method_800()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_387(apiAvatar.id);
				this.method_247();
			}
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001021FC File Offset: 0x001003FC
		internal void method_801()
		{
			this.method_581();
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00102210 File Offset: 0x00100410
		internal void method_802()
		{
			GClass177.gclass30_101 = new GClass30(GClass177.gclass99_15, 1f, -0.25f, 1f, 0.5f, "+0.5", new Action(this.method_782), "Increment Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_100 = new GClass30(GClass177.gclass99_15, 1f, 0.25f, 1f, 0.5f, "+0.2", new Action(this.method_600), "Increment Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_99 = new GClass30(GClass177.gclass99_15, 1f, 0.75f, 1f, 0.5f, "Distance+0.05", new Action(this.method_481), "Increment Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_102 = new GClass30(GClass177.gclass99_15, 1f, 1.25f, 1f, 0.5f, "Distance-0.05", new Action(this.method_439), "Decrement Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_103 = new GClass30(GClass177.gclass99_15, 1f, 1.75f, 1f, 0.5f, "-0.2", new Action(this.method_360), "Decrement Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_104 = new GClass30(GClass177.gclass99_15, 1f, 2.25f, 1f, 0.5f, "-0.5", new Action(this.method_668), "Decrement Distance.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_15;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_3 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x00102428 File Offset: 0x00100628
		private void method_803()
		{
			this.method_676();
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x0010243C File Offset: 0x0010063C
		[CompilerGenerated]
		private void method_804()
		{
			this.method_289();
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x00102450 File Offset: 0x00100650
		internal void method_805()
		{
			this.method_787();
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00102464 File Offset: 0x00100664
		[CompilerGenerated]
		private void method_806()
		{
			this.method_173();
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x00102478 File Offset: 0x00100678
		[CompilerGenerated]
		private void method_807()
		{
			this.method_445();
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x0010248C File Offset: 0x0010068C
		private void method_808()
		{
			this.method_906(-1f);
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001024A4 File Offset: 0x001006A4
		private void method_809()
		{
			this.method_737();
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001024B8 File Offset: 0x001006B8
		internal void method_810()
		{
			this.method_469();
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001024CC File Offset: 0x001006CC
		internal void method_811()
		{
			if (GClass84.gclass179_0 != null)
			{
				VRCPlayerApi vrcplayerApi = GClass84.smethod_772();
				GClass84.gclass179_0.vrcplayerApi_0 = vrcplayerApi;
				if (vrcplayerApi != null)
				{
					GClass84.gclass163_0.method_555(true);
				}
			}
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00102508 File Offset: 0x00100708
		internal void method_812()
		{
			this.method_979();
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x0010251C File Offset: 0x0010071C
		internal void method_813()
		{
			this.method_621();
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00102530 File Offset: 0x00100730
		internal void method_814()
		{
			GClass84.gclass141_0.method_62(GClass84.smethod_1309());
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00102550 File Offset: 0x00100750
		private void method_815()
		{
			this.method_61(-9f);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00102568 File Offset: 0x00100768
		internal void method_816()
		{
			GClass84.gclass148_0.method_68(GClass84.smethod_778());
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00102588 File Offset: 0x00100788
		internal void method_817()
		{
			GClass177.gclass30_82 = new GClass30(GClass177.gclass99_13, 1f, 0f, "EOT_Rotate", new Action(this.method_298), "EOT_Rotate.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_83 = new GClass30(GClass177.gclass99_13, 2f, 0f, "EOT_RotateWithFluctuations", new Action(this.method_56), "EOT_RotateWithFluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_84 = new GClass30(GClass177.gclass99_13, 3f, 0f, "EOT_RotateWithGlobalFluctuations", new Action(this.method_597), "EOT_RotateWithGlobalFluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_85 = new GClass30(GClass177.gclass99_13, 4f, 0f, "EOT_RotateWithRandomFluctuations", new Action(this.method_477), "EOT_RotateWithRandomFluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_13;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_1 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x001026DC File Offset: 0x001008DC
		internal void method_818()
		{
			this.method_52();
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x001026F0 File Offset: 0x001008F0
		private void method_819()
		{
			this.method_218(9);
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00102708 File Offset: 0x00100908
		[CompilerGenerated]
		private void method_820()
		{
			this.method_459();
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x0010271C File Offset: 0x0010091C
		private void method_821()
		{
			this.method_952(3);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00102730 File Offset: 0x00100930
		private void method_822()
		{
			this.method_97();
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00102744 File Offset: 0x00100944
		private void method_823()
		{
			this.method_514();
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00102758 File Offset: 0x00100958
		private void method_824()
		{
			this.method_963();
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x0010276C File Offset: 0x0010096C
		internal void method_825()
		{
			this.method_407();
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00102780 File Offset: 0x00100980
		internal void method_826(GClass181.GStruct270 gstruct270_0)
		{
			Transform transform = GClass84.smethod_105().gameObject.transform;
			GClass84.gclass181_0.method_11(gstruct270_0.string_1, transform.position, transform.forward, transform.rotation, gstruct270_0.string_2);
			this.method_235(false, true);
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x001027D0 File Offset: 0x001009D0
		private void method_827()
		{
			this.method_185();
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x001027E4 File Offset: 0x001009E4
		private void method_828()
		{
			this.method_76(7);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x001027F8 File Offset: 0x001009F8
		internal void method_829()
		{
			this.method_497();
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x0010280C File Offset: 0x00100A0C
		private void method_830()
		{
			this.method_798();
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00102820 File Offset: 0x00100A20
		internal void method_831()
		{
			this.method_493();
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00102834 File Offset: 0x00100A34
		private void method_832()
		{
			this.method_70(false, false);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x0010284C File Offset: 0x00100A4C
		internal void method_833()
		{
			this.method_362();
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00102860 File Offset: 0x00100A60
		internal void method_834(int int_3)
		{
			this.method_919(this.method_699(int_3));
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x0010287C File Offset: 0x00100A7C
		private void method_835()
		{
			this.method_76(1);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00102890 File Offset: 0x00100A90
		private void method_836(float float_7)
		{
			this.method_749(float_7);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x001028A4 File Offset: 0x00100AA4
		internal int method_837()
		{
			return GClass84.smethod_1690(GClass177.list_0.Count - GClass177.list_2.Count, 0);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x001028D0 File Offset: 0x00100AD0
		[CompilerGenerated]
		private void method_838()
		{
			this.method_170();
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x001028E4 File Offset: 0x00100AE4
		private void method_839()
		{
			this.method_522();
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x001028F8 File Offset: 0x00100AF8
		internal void method_840()
		{
			this.method_1027();
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0010290C File Offset: 0x00100B0C
		private void method_841()
		{
			this.method_635();
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00102920 File Offset: 0x00100B20
		[CompilerGenerated]
		private void method_842()
		{
			this.method_1019();
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00102934 File Offset: 0x00100B34
		private void method_843()
		{
			this.method_505();
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00102948 File Offset: 0x00100B48
		private void method_844(float float_7)
		{
			this.method_223(float_7);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x0010295C File Offset: 0x00100B5C
		[CompilerGenerated]
		private void method_845()
		{
			this.method_465();
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00102970 File Offset: 0x00100B70
		private void method_846(float float_7)
		{
			this.float_1 = float_7;
			this.method_506("Variables_Distance", false);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00102990 File Offset: 0x00100B90
		internal void method_847()
		{
			this.method_36();
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x001029A4 File Offset: 0x00100BA4
		private void method_848()
		{
			this.method_225();
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x001029B8 File Offset: 0x00100BB8
		internal void method_849()
		{
			this.method_58();
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x001029CC File Offset: 0x00100BCC
		internal void method_850()
		{
			this.method_810();
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x001029E0 File Offset: 0x00100BE0
		[CompilerGenerated]
		private void method_851()
		{
			this.method_334();
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x001029F4 File Offset: 0x00100BF4
		private void method_852(float float_7)
		{
			this.method_492(float_7);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00102A08 File Offset: 0x00100C08
		private void method_853()
		{
			this.method_90();
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00102A1C File Offset: 0x00100C1C
		private void method_854()
		{
			this.method_79();
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00102A30 File Offset: 0x00100C30
		internal void method_855()
		{
			GClass177.gclass30_69 = new GClass30(GClass177.gclass99_8, 1f, 0f, "Kill", new Action(this.method_379), "Kill.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass99_9 = new GClass99(GClass177.gclass99_8, 2f, 0f, "Set Role", "Set Role", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			GClass177.gclass30_70 = new GClass30(GClass177.gclass99_8, 3f, 0f, "Vote Out", new Action(this.method_838), "Vote Out.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_71 = new GClass30(GClass177.gclass99_8, 1f, 1f, "Auto Kill", new Action(this.method_126), "Auto Kill.", new Color?(Color.cyan), new Color?(Color.white), null);
			this.method_156();
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00102B5C File Offset: 0x00100D5C
		[CompilerGenerated]
		private void method_856()
		{
			this.method_316();
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00102B70 File Offset: 0x00100D70
		[CompilerGenerated]
		private void method_857()
		{
			this.method_345();
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00102B84 File Offset: 0x00100D84
		[CompilerGenerated]
		private void method_858()
		{
			this.method_533();
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00102B98 File Offset: 0x00100D98
		internal void method_859()
		{
			GClass177.list_1.Clear();
			for (int i = 0; i < 10; i++)
			{
				GClass177.list_1.Add(new GClass30(GClass177.gclass99_2, 2.375f, -0.125f + 0.25f * (float)i, 3.25f, 0.25f, "Object" + i.ToString(), new Action(this.method_494), "Object" + i.ToString() + ".", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5));
			}
			GClass177.list_1[1].method_20(new Action(this.method_393));
			GClass177.list_1[2].method_20(new Action(this.method_162));
			GClass177.list_1[3].method_20(new Action(this.method_1004));
			GClass177.list_1[4].method_20(new Action(this.method_712));
			GClass177.list_1[5].method_20(new Action(this.method_142));
			GClass177.list_1[6].method_20(new Action(this.method_303));
			GClass177.list_1[7].method_20(new Action(this.method_698));
			GClass177.list_1[8].method_20(new Action(this.method_169));
			GClass177.list_1[9].method_20(new Action(this.method_449));
			GClass177.gclass30_136 = new GClass30(GClass177.gclass99_2, 4.25f, 0f, 0.5f, 0.5f, "Up", new Action(this.method_256), "Up", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_135 = new GClass30(GClass177.gclass99_2, 4.25f, 2f, 0.5f, 0.5f, "Down", new Action(this.method_1000), "Down", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_137 = new GClass30(GClass177.gclass99_2, 3f, -0.375f, 1f, 0.25f, "Update", new Action(this.method_42), "Update", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5);
			this.method_235(false, false);
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00102E34 File Offset: 0x00101034
		internal void method_860()
		{
			GClass177.gclass30_119 = new GClass30(GClass177.gclass99_18, 1f, -0.25f, 1f, 0.5f, "+9", new Action(this.method_496), "Increment Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_118 = new GClass30(GClass177.gclass99_18, 1f, 0.25f, 1f, 0.5f, "+3", new Action(this.method_789), "Increment Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_117 = new GClass30(GClass177.gclass99_18, 1f, 0.75f, 1f, 0.5f, "Fluctuations+1", new Action(this.method_547), "Increment Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_120 = new GClass30(GClass177.gclass99_18, 1f, 1.25f, 1f, 0.5f, "Fluctuations-1", new Action(this.method_199), "Decrement Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_121 = new GClass30(GClass177.gclass99_18, 1f, 1.75f, 1f, 0.5f, "-3", new Action(this.method_226), "Decrement Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_122 = new GClass30(GClass177.gclass99_18, 1f, 2.25f, 1f, 0.5f, "-9", new Action(this.method_94), "Decrement Fluctuations.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass99 gclass = GClass177.gclass99_18;
			float num = 4f;
			float num2 = 2f;
			string empty = string.Empty;
			bool flag = false;
			Color? nullable_ = new Color?(Color.cyan);
			GClass177.gclass28_6 = new GClass28(gclass, num, num2, empty, flag, null, nullable_, null);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x0010304C File Offset: 0x0010124C
		private void method_861()
		{
			this.method_922();
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00103060 File Offset: 0x00101260
		internal void method_862()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar == null)
			{
				GClass70.smethod_38("AA Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.gclass145_0.method_24(apiAvatar.id, apiAvatar.name);
				this.method_247();
			}
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x001030A4 File Offset: 0x001012A4
		private void method_863(float float_7)
		{
			this.method_852(float_7);
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x001030B8 File Offset: 0x001012B8
		[CompilerGenerated]
		private void method_864()
		{
			this.method_892();
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x001030CC File Offset: 0x001012CC
		internal void method_865()
		{
			this.method_425();
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x001030E0 File Offset: 0x001012E0
		internal void method_866()
		{
			this.method_879();
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x001030F4 File Offset: 0x001012F4
		[CompilerGenerated]
		private void method_867()
		{
			this.method_194();
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00103108 File Offset: 0x00101308
		internal void method_868()
		{
			this.method_937();
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x0010311C File Offset: 0x0010131C
		private void method_869()
		{
			this.method_335();
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00103130 File Offset: 0x00101330
		internal void method_870()
		{
			if (GClass84.gclass181_0 != null)
			{
				GClass177.gclass99_1 = new GClass99(GClass177.gclass99_0, 1f, 0f, "Portal Dropper", "Portal Dropper", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			if (GClass84.gclass141_0 != null)
			{
				GClass177.gclass99_4 = new GClass99(GClass177.gclass99_0, 2f, 0f, "Murder 4", "Murder 4", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
				GClass177.gclass99_8 = new GClass99(GClass177.gclass99_0, 3f, 0f, "Among Us", "Among Us", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			GClass177.gclass30_47 = new GClass30(GClass177.gclass99_0, 4f, 0f, "Teleport Pickups", new Action(this.method_207), "Teleport Pickups.", new Color?(Color.cyan), new Color?(Color.white), null);
			if (GClass84.gclass144_0 != null)
			{
				GClass177.gclass30_48 = new GClass30(GClass177.gclass99_0, 1f, 1f, "Attach Pickups", new Action(this.method_294), "Attach Pickups.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
			if (GClass84.gclass179_0 != null)
			{
				GClass177.gclass99_10 = new GClass99(GClass177.gclass99_0, 2f, 1f, "Udon", "Udon", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			GClass177.gclass30_49 = new GClass30(GClass177.gclass99_0, 3f, 1f, "Orbit Pickups", new Action(this.method_741), "Orbit Pickups.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass99_11 = new GClass99(GClass177.gclass99_0, 4f, 1f, "Variables", "Variables", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			if (GClass84.gclass137_0 != null)
			{
				GClass177.gclass99_21 = new GClass99(GClass177.gclass99_0, 1f, 2f, "Triggers", "Triggers", new Color?(Color.cyan), new Color?(Color.white), new Color?(Color.cyan), new Color?(Color.yellow), null, false);
			}
			GClass177.gclass30_50 = new GClass30(GClass177.gclass99_0, 2f, 2f, "Attach To Player", new Action(this.method_363), "Attach To Player.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_51 = new GClass30(GClass177.gclass99_0, 3f, 2f, "Orbit Player", new Action(this.method_532), "Orbit Player.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_52 = new GClass30(GClass177.gclass99_0, 4f, 2f, "Swastika Pickups", new Action(this.method_150), "Swastika Pickups.", new Color?(Color.cyan), new Color?(Color.white), null);
			if (GClass84.gclass181_0 != null)
			{
				this.method_786();
			}
			this.method_285();
			this.method_911();
			if (GClass84.gclass179_0 != null)
			{
				this.method_915();
			}
			this.method_1026();
			if (GClass84.gclass137_0 != null)
			{
				this.method_215();
			}
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x0010351C File Offset: 0x0010171C
		private void method_871(float float_7)
		{
			this.method_304(float_7);
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00103530 File Offset: 0x00101730
		private void method_872()
		{
			this.method_317();
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00103544 File Offset: 0x00101744
		[CompilerGenerated]
		private void method_873()
		{
			this.method_666();
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00103558 File Offset: 0x00101758
		private void method_874()
		{
			this.method_140();
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x0010356C File Offset: 0x0010176C
		private void method_875()
		{
			this.method_228();
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00103580 File Offset: 0x00101780
		internal void method_876()
		{
			this.method_511();
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00103594 File Offset: 0x00101794
		[CompilerGenerated]
		private void method_877()
		{
			this.method_604();
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x001035A8 File Offset: 0x001017A8
		internal void method_878()
		{
			this.method_438();
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x001035BC File Offset: 0x001017BC
		internal void method_879()
		{
			this.method_519();
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x001035D0 File Offset: 0x001017D0
		private void method_880()
		{
			this.method_1015();
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x001035E4 File Offset: 0x001017E4
		[CompilerGenerated]
		private void method_881()
		{
			this.method_539();
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x001035F8 File Offset: 0x001017F8
		private void method_882()
		{
			this.method_934();
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x0010360C File Offset: 0x0010180C
		private void method_883()
		{
			this.method_785();
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00103620 File Offset: 0x00101820
		private void method_884()
		{
			this.method_769();
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00103634 File Offset: 0x00101834
		internal void method_885()
		{
			this.method_40();
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00103648 File Offset: 0x00101848
		private void method_886()
		{
			this.method_3();
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x0010365C File Offset: 0x0010185C
		private void method_887()
		{
			this.method_999();
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00103670 File Offset: 0x00101870
		private void method_888()
		{
			this.method_684();
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00103684 File Offset: 0x00101884
		internal void method_889()
		{
			this.method_643();
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00103698 File Offset: 0x00101898
		private void method_890()
		{
			this.method_1008();
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001036AC File Offset: 0x001018AC
		internal void method_891()
		{
			this.method_166();
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x001036C0 File Offset: 0x001018C0
		private void method_892()
		{
			this.method_757();
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x001036D4 File Offset: 0x001018D4
		private void method_893()
		{
			this.method_506("Variables_Height", false);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x001036F0 File Offset: 0x001018F0
		private void method_894()
		{
			this.method_296();
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00103704 File Offset: 0x00101904
		internal void method_895()
		{
			this.method_599();
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00103718 File Offset: 0x00101918
		[CompilerGenerated]
		private void method_896()
		{
			this.method_848();
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x0010372C File Offset: 0x0010192C
		private void method_897(float float_7)
		{
			this.method_456(float_7);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00103740 File Offset: 0x00101940
		private void method_898(float float_7)
		{
			this.method_83(float_7);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00103754 File Offset: 0x00101954
		private void method_899()
		{
			this.method_752(3);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00103768 File Offset: 0x00101968
		internal void method_900()
		{
			this.method_909();
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0010377C File Offset: 0x0010197C
		private void method_901()
		{
			this.method_117();
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x00103790 File Offset: 0x00101990
		private void method_902()
		{
			this.method_246();
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x001037A4 File Offset: 0x001019A4
		internal void method_903()
		{
			/*
An exception occurred when decompiling this method (06004548)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns474.GClass177::method_903()
 ---> System.ArgumentOutOfRangeException: Non-negative number required.
Parameter name: length
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x001039B0 File Offset: 0x00101BB0
		private void method_904()
		{
			this.method_374();
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x001039C4 File Offset: 0x00101BC4
		private void method_905()
		{
			this.method_177();
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x001039D8 File Offset: 0x00101BD8
		private void method_906(float float_7)
		{
			this.method_897(float_7);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001039EC File Offset: 0x00101BEC
		private void method_907()
		{
			this.method_736();
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00103A00 File Offset: 0x00101C00
		private void method_908()
		{
			this.method_154();
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00103A14 File Offset: 0x00101C14
		internal void method_909()
		{
			this.method_428();
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00103A28 File Offset: 0x00101C28
		private void method_910()
		{
			this.method_218(8);
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00103A3C File Offset: 0x00101C3C
		internal void method_911()
		{
			this.method_158();
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00103A50 File Offset: 0x00101C50
		internal void method_912()
		{
			this.method_555();
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00103A64 File Offset: 0x00101C64
		private void method_913(float float_7)
		{
			this.method_68(this.float_6 + float_7);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00103A80 File Offset: 0x00101C80
		[CompilerGenerated]
		private void method_914()
		{
			this.method_961();
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00103A94 File Offset: 0x00101C94
		internal void method_915()
		{
			this.method_15();
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00103AA8 File Offset: 0x00101CA8
		private void method_916()
		{
			this.method_506("Variables_FluctuationsSpeed2", false);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00103AC4 File Offset: 0x00101CC4
		internal void method_917()
		{
			this.method_325();
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00103AD8 File Offset: 0x00101CD8
		private void method_918()
		{
			this.method_200();
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00103AEC File Offset: 0x00101CEC
		internal void method_919(GameObject gameObject_0)
		{
			this.method_596(gameObject_0);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00103B00 File Offset: 0x00101D00
		private void method_920()
		{
			this.method_415();
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00103B14 File Offset: 0x00101D14
		internal void method_921()
		{
			this.method_719();
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00103B28 File Offset: 0x00101D28
		private void method_922()
		{
			this.method_906(3f);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00103B40 File Offset: 0x00101D40
		[CompilerGenerated]
		private void method_923()
		{
			this.method_190();
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00103B54 File Offset: 0x00101D54
		internal void method_924()
		{
			this.method_891();
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00103B68 File Offset: 0x00101D68
		private void method_925()
		{
			this.method_410();
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00103B7C File Offset: 0x00101D7C
		internal void method_926()
		{
			GClass84.smethod_1357(GClass84.smethod_1157());
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00103B94 File Offset: 0x00101D94
		private void method_927()
		{
			this.method_898(-0.5f);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00103BAC File Offset: 0x00101DAC
		private void method_928()
		{
			this.method_287();
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00103BC0 File Offset: 0x00101DC0
		internal void method_929()
		{
			GClass84.gclass184_0.method_23(GClass84.smethod_772());
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00103BDC File Offset: 0x00101DDC
		internal void method_930()
		{
			this.method_21();
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00103BF0 File Offset: 0x00101DF0
		private void method_931()
		{
			this.method_916();
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00103C04 File Offset: 0x00101E04
		internal void method_932()
		{
			if (GClass84.gclass145_0 != null)
			{
				if (this.bool_23)
				{
					GClass177.gclass30_39 = new GClass30(GClass177.gclass99_27, 1f, 0f, "Hide Avatar", new Action(this.method_38), "Hide Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
					GClass177.gclass30_40 = new GClass30(GClass177.gclass99_27, 1f, 0f, "UnHide Avatar", new Action(this.method_1001), "UnHide Avatar.", new Color?(Color.cyan), new Color?(Color.white), null);
					GClass177.gclass30_41 = new GClass30(GClass177.gclass99_27, 2f, 0f, "Hide Avatar By Author", new Action(this.method_663), "Hide Avatar By Author.", new Color?(Color.cyan), new Color?(Color.white), null);
					GClass177.gclass30_42 = new GClass30(GClass177.gclass99_27, 2f, 0f, "UnHide Avatar By Author", new Action(this.method_971), "UnHide Avatar By Author.", new Color?(Color.cyan), new Color?(Color.white), null);
				}
				GClass177.gclass30_43 = new GClass30(GClass177.gclass99_27, 3f, 0f, "Add Avatar To WhiteList", new Action(this.method_356), "Add Avatar To WhiteList.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_44 = new GClass30(GClass177.gclass99_27, 3f, 0f, "Remove Avatar From WhiteList", new Action(this.method_807), "Remove Avatar From WhiteList.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_45 = new GClass30(GClass177.gclass99_27, 4f, 0f, "Add User To WhiteList", new Action(this.method_896), "Add User To WhiteList.", new Color?(Color.cyan), new Color?(Color.white), null);
				GClass177.gclass30_46 = new GClass30(GClass177.gclass99_27, 4f, 0f, "Remove User From WhiteList", new Action(this.method_742), "Remove User From WhiteList.", new Color?(Color.cyan), new Color?(Color.white), null);
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00103E4C File Offset: 0x0010204C
		internal void method_933()
		{
			this.method_270();
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00103E60 File Offset: 0x00102060
		private void method_934()
		{
			this.method_836(1f);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00103E78 File Offset: 0x00102078
		private void method_935()
		{
			this.method_105();
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00103E8C File Offset: 0x0010208C
		internal void method_936()
		{
			this.method_48();
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00103EA0 File Offset: 0x001020A0
		internal void method_937()
		{
			this.method_988();
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00103EB4 File Offset: 0x001020B4
		internal void method_938()
		{
			this.method_475();
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00103EC8 File Offset: 0x001020C8
		private void method_939()
		{
			this.method_23(3);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00103EDC File Offset: 0x001020DC
		internal void method_940()
		{
			this.method_6();
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00103EF0 File Offset: 0x001020F0
		internal void method_941()
		{
			this.method_133();
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00103F04 File Offset: 0x00102104
		private void method_942()
		{
			this.method_939();
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00103F18 File Offset: 0x00102118
		private void method_943(float float_7)
		{
			this.method_66(float_7);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00103F2C File Offset: 0x0010212C
		private void method_944()
		{
			this.method_278();
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00103F40 File Offset: 0x00102140
		private void method_945()
		{
			this.method_750();
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00103F54 File Offset: 0x00102154
		private void method_946()
		{
			this.method_607();
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00103F68 File Offset: 0x00102168
		private void method_947()
		{
			this.method_165();
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00103F7C File Offset: 0x0010217C
		private void method_948()
		{
			this.method_506("Variables_Speed", false);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00103F98 File Offset: 0x00102198
		private void method_949(float float_7)
		{
			this.float_5 = float_7;
			this.method_506("Variables_FluctuationsSpeed", false);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00103FB8 File Offset: 0x001021B8
		private void method_950()
		{
			this.method_446();
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00103FCC File Offset: 0x001021CC
		internal void method_951()
		{
			this.method_665();
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00103FE0 File Offset: 0x001021E0
		internal void method_952(int int_3)
		{
			this.method_263(int_3);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00103FF4 File Offset: 0x001021F4
		private void method_953()
		{
			this.method_1010();
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00104008 File Offset: 0x00102208
		internal void method_954()
		{
			this.method_718();
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x0010401C File Offset: 0x0010221C
		internal void method_955()
		{
			this.method_368();
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00104030 File Offset: 0x00102230
		[CompilerGenerated]
		private void method_956()
		{
			this.method_196();
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00104044 File Offset: 0x00102244
		internal void method_957()
		{
			GClass84.smethod_1201(GClass84.smethod_126());
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x0010405C File Offset: 0x0010225C
		[CompilerGenerated]
		private void method_958()
		{
			this.method_30();
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00104070 File Offset: 0x00102270
		[CompilerGenerated]
		private void method_959()
		{
			this.method_907();
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00104084 File Offset: 0x00102284
		private void method_960()
		{
			this.method_752(8);
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00104098 File Offset: 0x00102298
		private void method_961()
		{
			this.method_869();
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x001040AC File Offset: 0x001022AC
		private void method_962()
		{
			this.method_299();
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x001040C0 File Offset: 0x001022C0
		private void method_963()
		{
			this.method_429();
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x001040D4 File Offset: 0x001022D4
		[CompilerGenerated]
		private void method_964()
		{
			this.method_251();
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001040E8 File Offset: 0x001022E8
		[CompilerGenerated]
		private void method_965()
		{
			this.method_740();
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x001040FC File Offset: 0x001022FC
		private void method_966()
		{
			this.method_76(9);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00104114 File Offset: 0x00102314
		private void method_967()
		{
			this.method_672();
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00104128 File Offset: 0x00102328
		public override void vmethod_24()
		{
			this.method_134();
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x0010413C File Offset: 0x0010233C
		private void method_968(float float_7)
		{
			this.method_546(float_7);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00104150 File Offset: 0x00102350
		private void method_969()
		{
			this.method_272();
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00104164 File Offset: 0x00102364
		[CompilerGenerated]
		private void method_970()
		{
			this.method_108();
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00104178 File Offset: 0x00102378
		[CompilerGenerated]
		private void method_971()
		{
			this.method_575();
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0010418C File Offset: 0x0010238C
		[CompilerGenerated]
		private void method_972()
		{
			this.method_167();
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x001041A0 File Offset: 0x001023A0
		private void method_973()
		{
			this.method_19();
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x001041B4 File Offset: 0x001023B4
		internal void method_974()
		{
			this.method_573();
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x001041C8 File Offset: 0x001023C8
		internal void method_975()
		{
			this.method_347();
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001041DC File Offset: 0x001023DC
		[CompilerGenerated]
		private void method_976()
		{
			this.method_221();
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x001041F0 File Offset: 0x001023F0
		private void method_977()
		{
			this.method_391();
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00104204 File Offset: 0x00102404
		internal void method_978()
		{
			this.method_453();
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00104218 File Offset: 0x00102418
		internal void method_979()
		{
			this.method_932();
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0010422C File Offset: 0x0010242C
		private void method_980()
		{
			this.method_385();
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00104240 File Offset: 0x00102440
		internal void method_981()
		{
			this.method_568();
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00104254 File Offset: 0x00102454
		private void method_982()
		{
			this.method_218(0);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00104268 File Offset: 0x00102468
		internal void method_983()
		{
			VRCPlayer vrcplayer = GClass84.smethod_105();
			if (!vrcplayer)
			{
				GClass70.smethod_38("VRCP Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				APIUser apiuser = GClass84.smethod_821();
				if (apiuser == null)
				{
					GClass70.smethod_38("APIU Is Null!", GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					apiuser.displayName,
					" ",
					"has",
					" ",
					"Steam",
					" ",
					"ID",
					" ",
					GClass84.smethod_534(vrcplayer).ToString()
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00104310 File Offset: 0x00102510
		[CompilerGenerated]
		private void method_984()
		{
			this.method_743();
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00104324 File Offset: 0x00102524
		internal void method_985()
		{
			GClass177.list_2.Clear();
			for (int i = 0; i < 10; i++)
			{
				GClass177.list_2.Add(new GClass30(GClass177.gclass99_3, 2.375f, -0.125f + 0.25f * (float)i, 3.25f, 0.25f, "Object" + i.ToString(), new Action(this.method_249), "Object" + i.ToString() + ".", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5));
			}
			GClass177.list_2[1].method_20(new Action(this.method_471));
			GClass177.list_2[2].method_20(new Action(this.method_383));
			GClass177.list_2[3].method_20(new Action(this.method_27));
			GClass177.list_2[4].method_20(new Action(this.method_80));
			GClass177.list_2[5].method_20(new Action(this.method_74));
			GClass177.list_2[6].method_20(new Action(this.method_399));
			GClass177.list_2[7].method_20(new Action(this.method_466));
			GClass177.list_2[8].method_20(new Action(this.method_873));
			GClass177.list_2[9].method_20(new Action(this.method_552));
			GClass177.gclass30_139 = new GClass30(GClass177.gclass99_3, 4.25f, 0f, 0.5f, 0.5f, "Up", new Action(this.method_131), "Up", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_138 = new GClass30(GClass177.gclass99_3, 4.25f, 2f, 0.5f, 0.5f, "Down", new Action(this.method_163), "Down", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_140 = new GClass30(GClass177.gclass99_3, 3f, -0.375f, 1f, 0.25f, "Update", new Action(this.method_178), "Update", new Color?(Color.cyan), new Color?(Color.white), GClass153.GClass87.texture2D_5);
			this.method_70(false, false);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x001045C0 File Offset: 0x001027C0
		private void method_986()
		{
			this.method_616(0.2f);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x001045D8 File Offset: 0x001027D8
		[CompilerGenerated]
		private void method_987()
		{
			this.method_841();
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x001045EC File Offset: 0x001027EC
		internal void method_988()
		{
			string text = GClass84.smethod_778();
			if (string.IsNullOrEmpty(text))
			{
				GClass70.smethod_38("UserID Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				string text2 = GClass84.smethod_80("");
				if (string.IsNullOrEmpty(text2))
				{
					GClass70.smethod_38("Nickname Is Null!", GClass70.Enum1.const_0);
				}
				else
				{
					GClass84.gclass145_0.method_4(text, text2);
					this.method_671();
				}
			}
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00104648 File Offset: 0x00102848
		internal void method_989()
		{
			GClass177.gclass30_56 = new GClass30(GClass177.gclass99_7, 1f, 0f, "Bystander", new Action(this.method_14), "Bystander.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_57 = new GClass30(GClass177.gclass99_7, 2f, 0f, "Murderer", new Action(this.method_252), "Murderer.", new Color?(Color.cyan), new Color?(Color.white), null);
			GClass177.gclass30_58 = new GClass30(GClass177.gclass99_7, 3f, 0f, "Detective", new Action(this.method_864), "Detective.", new Color?(Color.cyan), new Color?(Color.white), null);
			if (!GClass84.bool_7)
			{
				this.method_885();
			}
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00104734 File Offset: 0x00102934
		internal void method_990()
		{
			this.method_641();
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00104748 File Offset: 0x00102948
		[CompilerGenerated]
		private void method_991()
		{
			this.method_661();
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x0010475C File Offset: 0x0010295C
		private void method_992()
		{
			this.method_821();
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x00104770 File Offset: 0x00102970
		private void method_993()
		{
			this.method_76(2);
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x00104784 File Offset: 0x00102984
		private void method_994()
		{
			this.method_603();
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00104798 File Offset: 0x00102998
		private void method_995()
		{
			this.method_906(1f);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001047B0 File Offset: 0x001029B0
		internal void method_996(bool bool_26, bool bool_27)
		{
			this.method_408(bool_26, bool_27);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x001047C8 File Offset: 0x001029C8
		[CompilerGenerated]
		private void method_997()
		{
			this.method_918();
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x001047DC File Offset: 0x001029DC
		internal void method_998()
		{
			this.method_790();
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x001047F0 File Offset: 0x001029F0
		private void method_999()
		{
			this.method_218(4);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00104804 File Offset: 0x00102A04
		[CompilerGenerated]
		private void method_1000()
		{
			this.method_942();
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00104818 File Offset: 0x00102A18
		[CompilerGenerated]
		private void method_1001()
		{
			this.method_122();
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x0010482C File Offset: 0x00102A2C
		internal void method_1002()
		{
			this.method_179();
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00104840 File Offset: 0x00102A40
		private void method_1003()
		{
			this.method_312();
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00104854 File Offset: 0x00102A54
		[CompilerGenerated]
		private void method_1004()
		{
			this.method_65();
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00104868 File Offset: 0x00102A68
		internal void method_1005()
		{
			this.method_444();
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x0010487C File Offset: 0x00102A7C
		private void method_1006()
		{
			this.method_628();
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00104890 File Offset: 0x00102A90
		internal void method_1007()
		{
			this.method_652();
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x001048A4 File Offset: 0x00102AA4
		private void method_1008()
		{
			this.method_300(-0.5f);
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x001048BC File Offset: 0x00102ABC
		internal void method_1009()
		{
			this.method_862();
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x001048D0 File Offset: 0x00102AD0
		internal void method_1010()
		{
			this.method_833();
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x001048E4 File Offset: 0x00102AE4
		private void method_1011()
		{
			this.method_962();
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x001048F8 File Offset: 0x00102AF8
		internal void method_1012()
		{
			GClass84.smethod_1266(GClass84.smethod_126());
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00104910 File Offset: 0x00102B10
		private void method_1013()
		{
			this.method_218(2);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00104924 File Offset: 0x00102B24
		private void method_1014()
		{
			this.method_622();
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00104938 File Offset: 0x00102B38
		internal void method_1015()
		{
			this.method_403();
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0010494C File Offset: 0x00102B4C
		internal void method_1016()
		{
			this.method_24();
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00104960 File Offset: 0x00102B60
		internal void method_1017()
		{
			this.method_755();
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00104974 File Offset: 0x00102B74
		internal void method_1018()
		{
			GClass84.smethod_383(GClass84.smethod_821());
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0010498C File Offset: 0x00102B8C
		private void method_1019()
		{
			this.method_966();
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x001049A0 File Offset: 0x00102BA0
		internal void method_1020(GameObject gameObject_0)
		{
			GClass84.smethod_1035(gameObject_0, GClass84.smethod_105().transform, this.genum47_0, true);
			this.method_214(false, true);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001049D0 File Offset: 0x00102BD0
		internal void method_1021()
		{
			ApiAvatar apiAvatar = GClass84.smethod_1157();
			if (apiAvatar != null)
			{
				Clipboard.SetText(apiAvatar.id);
			}
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x001049F4 File Offset: 0x00102BF4
		internal void method_1022()
		{
			this.method_351();
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00104A08 File Offset: 0x00102C08
		private void method_1023(float float_7)
		{
			this.method_85(this.float_1 + float_7);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00104A24 File Offset: 0x00102C24
		internal void method_1024()
		{
			this.method_957();
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00104A38 File Offset: 0x00102C38
		internal void method_1025()
		{
			GClass84.gclass148_0.method_27(GClass84.smethod_778());
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00104A54 File Offset: 0x00102C54
		internal void method_1026()
		{
			this.method_517();
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x000F2720 File Offset: 0x000F0920
		internal void method_1027()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x040019A9 RID: 6569
		internal bool bool_0 = true;

		// Token: 0x040019AA RID: 6570
		internal bool bool_1 = true;

		// Token: 0x040019AB RID: 6571
		internal bool bool_2 = true;

		// Token: 0x040019AC RID: 6572
		internal bool bool_3 = false;

		// Token: 0x040019AD RID: 6573
		internal bool bool_4 = true;

		// Token: 0x040019AE RID: 6574
		internal bool bool_5 = true;

		// Token: 0x040019AF RID: 6575
		internal bool bool_6 = true;

		// Token: 0x040019B0 RID: 6576
		internal bool bool_7 = true;

		// Token: 0x040019B1 RID: 6577
		internal bool bool_8 = true;

		// Token: 0x040019B2 RID: 6578
		internal bool bool_9 = true;

		// Token: 0x040019B3 RID: 6579
		internal bool bool_10 = true;

		// Token: 0x040019B4 RID: 6580
		internal bool bool_11 = true;

		// Token: 0x040019B5 RID: 6581
		internal bool bool_12 = true;

		// Token: 0x040019B6 RID: 6582
		internal bool bool_13 = true;

		// Token: 0x040019B7 RID: 6583
		internal bool bool_14 = true;

		// Token: 0x040019B8 RID: 6584
		internal bool bool_15 = true;

		// Token: 0x040019B9 RID: 6585
		internal bool bool_16 = false;

		// Token: 0x040019BA RID: 6586
		internal bool bool_17 = true;

		// Token: 0x040019BB RID: 6587
		internal bool bool_18 = true;

		// Token: 0x040019BC RID: 6588
		internal bool bool_19 = true;

		// Token: 0x040019BD RID: 6589
		internal bool bool_20 = false;

		// Token: 0x040019BE RID: 6590
		internal bool bool_21 = true;

		// Token: 0x040019BF RID: 6591
		internal bool bool_22 = true;

		// Token: 0x040019C0 RID: 6592
		internal bool bool_23 = true;

		// Token: 0x040019C1 RID: 6593
		internal bool bool_24 = true;

		// Token: 0x040019C2 RID: 6594
		internal bool bool_25 = false;

		// Token: 0x040019C3 RID: 6595
		internal GClass84.GEnum47 genum47_0 = GClass84.GEnum47.const_2;

		// Token: 0x040019C4 RID: 6596
		internal GClass144.GEnum35 genum35_0 = GClass144.GEnum35.const_3;

		// Token: 0x040019C5 RID: 6597
		internal float float_0 = 1f;

		// Token: 0x040019C6 RID: 6598
		internal float float_1 = 1f;

		// Token: 0x040019C7 RID: 6599
		internal float float_2 = 0.5f;

		// Token: 0x040019C8 RID: 6600
		internal float float_3 = 0f;

		// Token: 0x040019C9 RID: 6601
		internal float float_4 = 45f;

		// Token: 0x040019CA RID: 6602
		internal float float_5 = 30f;

		// Token: 0x040019CB RID: 6603
		internal float float_6 = 0f;

		// Token: 0x040019CC RID: 6604
		internal static GClass97 gclass97_0;

		// Token: 0x040019CD RID: 6605
		internal static GClass28 gclass28_0;

		// Token: 0x040019CE RID: 6606
		internal static GClass28 gclass28_1;

		// Token: 0x040019CF RID: 6607
		internal static GClass28 gclass28_2;

		// Token: 0x040019D0 RID: 6608
		internal static GClass28 gclass28_3;

		// Token: 0x040019D1 RID: 6609
		internal static GClass28 gclass28_4;

		// Token: 0x040019D2 RID: 6610
		internal static GClass28 gclass28_5;

		// Token: 0x040019D3 RID: 6611
		internal static GClass28 gclass28_6;

		// Token: 0x040019D4 RID: 6612
		internal static GClass28 gclass28_7;

		// Token: 0x040019D5 RID: 6613
		internal static GClass28 gclass28_8;

		// Token: 0x040019D6 RID: 6614
		internal static GClass99 gclass99_0;

		// Token: 0x040019D7 RID: 6615
		internal static GClass99 gclass99_1;

		// Token: 0x040019D8 RID: 6616
		internal static GClass99 gclass99_2;

		// Token: 0x040019D9 RID: 6617
		internal static GClass99 gclass99_3;

		// Token: 0x040019DA RID: 6618
		internal static GClass99 gclass99_4;

		// Token: 0x040019DB RID: 6619
		internal static GClass99 gclass99_5;

		// Token: 0x040019DC RID: 6620
		internal static GClass99 gclass99_6;

		// Token: 0x040019DD RID: 6621
		internal static GClass99 gclass99_7;

		// Token: 0x040019DE RID: 6622
		internal static GClass99 gclass99_8;

		// Token: 0x040019DF RID: 6623
		internal static GClass99 gclass99_9;

		// Token: 0x040019E0 RID: 6624
		internal static GClass99 gclass99_10;

		// Token: 0x040019E1 RID: 6625
		internal static GClass99 gclass99_11;

		// Token: 0x040019E2 RID: 6626
		internal static GClass99 gclass99_12;

		// Token: 0x040019E3 RID: 6627
		internal static GClass99 gclass99_13;

		// Token: 0x040019E4 RID: 6628
		internal static GClass99 gclass99_14;

		// Token: 0x040019E5 RID: 6629
		internal static GClass99 gclass99_15;

		// Token: 0x040019E6 RID: 6630
		internal static GClass99 gclass99_16;

		// Token: 0x040019E7 RID: 6631
		internal static GClass99 gclass99_17;

		// Token: 0x040019E8 RID: 6632
		internal static GClass99 gclass99_18;

		// Token: 0x040019E9 RID: 6633
		internal static GClass99 gclass99_19;

		// Token: 0x040019EA RID: 6634
		internal static GClass99 gclass99_20;

		// Token: 0x040019EB RID: 6635
		internal static GClass99 gclass99_21;

		// Token: 0x040019EC RID: 6636
		internal static GClass99 gclass99_22;

		// Token: 0x040019ED RID: 6637
		internal static GClass99 gclass99_23;

		// Token: 0x040019EE RID: 6638
		internal static GClass99 gclass99_24;

		// Token: 0x040019EF RID: 6639
		internal static GClass99 gclass99_25;

		// Token: 0x040019F0 RID: 6640
		internal static GClass99 gclass99_26;

		// Token: 0x040019F1 RID: 6641
		internal static GClass99 gclass99_27;

		// Token: 0x040019F2 RID: 6642
		internal static GClass30 gclass30_0;

		// Token: 0x040019F3 RID: 6643
		internal static GClass30 gclass30_1;

		// Token: 0x040019F4 RID: 6644
		internal static GClass30 gclass30_2;

		// Token: 0x040019F5 RID: 6645
		internal static GClass30 gclass30_3;

		// Token: 0x040019F6 RID: 6646
		internal static GClass30 gclass30_4;

		// Token: 0x040019F7 RID: 6647
		internal static GClass30 gclass30_5;

		// Token: 0x040019F8 RID: 6648
		internal static GClass30 gclass30_6;

		// Token: 0x040019F9 RID: 6649
		internal static GClass30 gclass30_7;

		// Token: 0x040019FA RID: 6650
		internal static GClass30 gclass30_8;

		// Token: 0x040019FB RID: 6651
		internal static GClass30 gclass30_9;

		// Token: 0x040019FC RID: 6652
		internal static GClass30 gclass30_10;

		// Token: 0x040019FD RID: 6653
		internal static GClass30 gclass30_11;

		// Token: 0x040019FE RID: 6654
		internal static GClass30 gclass30_12;

		// Token: 0x040019FF RID: 6655
		internal static GClass30 gclass30_13;

		// Token: 0x04001A00 RID: 6656
		internal static GClass30 gclass30_14;

		// Token: 0x04001A01 RID: 6657
		internal static GClass30 gclass30_15;

		// Token: 0x04001A02 RID: 6658
		internal static GClass30 gclass30_16;

		// Token: 0x04001A03 RID: 6659
		internal static GClass30 gclass30_17;

		// Token: 0x04001A04 RID: 6660
		internal static GClass30 gclass30_18;

		// Token: 0x04001A05 RID: 6661
		internal static GClass30 gclass30_19;

		// Token: 0x04001A06 RID: 6662
		internal static GClass30 gclass30_20;

		// Token: 0x04001A07 RID: 6663
		internal static GClass30 gclass30_21;

		// Token: 0x04001A08 RID: 6664
		internal static GClass30 gclass30_22;

		// Token: 0x04001A09 RID: 6665
		internal static GClass30 gclass30_23;

		// Token: 0x04001A0A RID: 6666
		internal static GClass30 gclass30_24;

		// Token: 0x04001A0B RID: 6667
		internal static GClass30 gclass30_25;

		// Token: 0x04001A0C RID: 6668
		internal static GClass30 gclass30_26;

		// Token: 0x04001A0D RID: 6669
		internal static GClass30 gclass30_27;

		// Token: 0x04001A0E RID: 6670
		internal static GClass30 gclass30_28;

		// Token: 0x04001A0F RID: 6671
		internal static GClass30 gclass30_29;

		// Token: 0x04001A10 RID: 6672
		internal static GClass30 gclass30_30;

		// Token: 0x04001A11 RID: 6673
		internal static GClass30 gclass30_31;

		// Token: 0x04001A12 RID: 6674
		internal static GClass30 gclass30_32;

		// Token: 0x04001A13 RID: 6675
		internal static GClass30 gclass30_33;

		// Token: 0x04001A14 RID: 6676
		internal static GClass30 gclass30_34;

		// Token: 0x04001A15 RID: 6677
		internal static GClass30 gclass30_35;

		// Token: 0x04001A16 RID: 6678
		internal static GClass30 gclass30_36;

		// Token: 0x04001A17 RID: 6679
		internal static GClass30 gclass30_37;

		// Token: 0x04001A18 RID: 6680
		internal static GClass30 gclass30_38;

		// Token: 0x04001A19 RID: 6681
		internal static GClass30 gclass30_39;

		// Token: 0x04001A1A RID: 6682
		internal static GClass30 gclass30_40;

		// Token: 0x04001A1B RID: 6683
		internal static GClass30 gclass30_41;

		// Token: 0x04001A1C RID: 6684
		internal static GClass30 gclass30_42;

		// Token: 0x04001A1D RID: 6685
		internal static GClass30 gclass30_43;

		// Token: 0x04001A1E RID: 6686
		internal static GClass30 gclass30_44;

		// Token: 0x04001A1F RID: 6687
		internal static GClass30 gclass30_45;

		// Token: 0x04001A20 RID: 6688
		internal static GClass30 gclass30_46;

		// Token: 0x04001A21 RID: 6689
		internal static GClass30 gclass30_47;

		// Token: 0x04001A22 RID: 6690
		internal static GClass30 gclass30_48;

		// Token: 0x04001A23 RID: 6691
		internal static GClass30 gclass30_49;

		// Token: 0x04001A24 RID: 6692
		internal static GClass30 gclass30_50;

		// Token: 0x04001A25 RID: 6693
		internal static GClass30 gclass30_51;

		// Token: 0x04001A26 RID: 6694
		internal static GClass30 gclass30_52;

		// Token: 0x04001A27 RID: 6695
		internal static GClass30 gclass30_53;

		// Token: 0x04001A28 RID: 6696
		internal static GClass30 gclass30_54;

		// Token: 0x04001A29 RID: 6697
		internal static GClass30 gclass30_55;

		// Token: 0x04001A2A RID: 6698
		internal static GClass30 gclass30_56;

		// Token: 0x04001A2B RID: 6699
		internal static GClass30 gclass30_57;

		// Token: 0x04001A2C RID: 6700
		internal static GClass30 gclass30_58;

		// Token: 0x04001A2D RID: 6701
		internal static GClass30 gclass30_59;

		// Token: 0x04001A2E RID: 6702
		internal static GClass30 gclass30_60;

		// Token: 0x04001A2F RID: 6703
		internal static GClass30 gclass30_61;

		// Token: 0x04001A30 RID: 6704
		internal static GClass30 gclass30_62;

		// Token: 0x04001A31 RID: 6705
		internal static GClass30 gclass30_63;

		// Token: 0x04001A32 RID: 6706
		internal static GClass30 gclass30_64;

		// Token: 0x04001A33 RID: 6707
		internal static GClass30 gclass30_65;

		// Token: 0x04001A34 RID: 6708
		internal static GClass30 gclass30_66;

		// Token: 0x04001A35 RID: 6709
		internal static GClass30 gclass30_67;

		// Token: 0x04001A36 RID: 6710
		internal static GClass30 gclass30_68;

		// Token: 0x04001A37 RID: 6711
		internal static GClass30 gclass30_69;

		// Token: 0x04001A38 RID: 6712
		internal static GClass30 gclass30_70;

		// Token: 0x04001A39 RID: 6713
		internal static GClass30 gclass30_71;

		// Token: 0x04001A3A RID: 6714
		internal static GClass30 gclass30_72;

		// Token: 0x04001A3B RID: 6715
		internal static GClass30 gclass30_73;

		// Token: 0x04001A3C RID: 6716
		internal static GClass30 gclass30_74;

		// Token: 0x04001A3D RID: 6717
		internal static GClass30 gclass30_75;

		// Token: 0x04001A3E RID: 6718
		internal static GClass30 gclass30_76;

		// Token: 0x04001A3F RID: 6719
		internal static GClass30 gclass30_77;

		// Token: 0x04001A40 RID: 6720
		internal static GClass30 gclass30_78;

		// Token: 0x04001A41 RID: 6721
		internal static GClass30 gclass30_79;

		// Token: 0x04001A42 RID: 6722
		internal static GClass30 gclass30_80;

		// Token: 0x04001A43 RID: 6723
		internal static GClass30 gclass30_81;

		// Token: 0x04001A44 RID: 6724
		internal static GClass30 gclass30_82;

		// Token: 0x04001A45 RID: 6725
		internal static GClass30 gclass30_83;

		// Token: 0x04001A46 RID: 6726
		internal static GClass30 gclass30_84;

		// Token: 0x04001A47 RID: 6727
		internal static GClass30 gclass30_85;

		// Token: 0x04001A48 RID: 6728
		internal static GClass30 gclass30_86;

		// Token: 0x04001A49 RID: 6729
		internal static GClass30 gclass30_87;

		// Token: 0x04001A4A RID: 6730
		internal static GClass30 gclass30_88;

		// Token: 0x04001A4B RID: 6731
		internal static GClass30 gclass30_89;

		// Token: 0x04001A4C RID: 6732
		internal static GClass30 gclass30_90;

		// Token: 0x04001A4D RID: 6733
		internal static GClass30 gclass30_91;

		// Token: 0x04001A4E RID: 6734
		internal static GClass30 gclass30_92;

		// Token: 0x04001A4F RID: 6735
		internal static GClass30 gclass30_93;

		// Token: 0x04001A50 RID: 6736
		internal static GClass30 gclass30_94;

		// Token: 0x04001A51 RID: 6737
		internal static GClass30 gclass30_95;

		// Token: 0x04001A52 RID: 6738
		internal static GClass30 gclass30_96;

		// Token: 0x04001A53 RID: 6739
		internal static GClass30 gclass30_97;

		// Token: 0x04001A54 RID: 6740
		internal static GClass30 gclass30_98;

		// Token: 0x04001A55 RID: 6741
		internal static GClass30 gclass30_99;

		// Token: 0x04001A56 RID: 6742
		internal static GClass30 gclass30_100;

		// Token: 0x04001A57 RID: 6743
		internal static GClass30 gclass30_101;

		// Token: 0x04001A58 RID: 6744
		internal static GClass30 gclass30_102;

		// Token: 0x04001A59 RID: 6745
		internal static GClass30 gclass30_103;

		// Token: 0x04001A5A RID: 6746
		internal static GClass30 gclass30_104;

		// Token: 0x04001A5B RID: 6747
		internal static GClass30 gclass30_105;

		// Token: 0x04001A5C RID: 6748
		internal static GClass30 gclass30_106;

		// Token: 0x04001A5D RID: 6749
		internal static GClass30 gclass30_107;

		// Token: 0x04001A5E RID: 6750
		internal static GClass30 gclass30_108;

		// Token: 0x04001A5F RID: 6751
		internal static GClass30 gclass30_109;

		// Token: 0x04001A60 RID: 6752
		internal static GClass30 gclass30_110;

		// Token: 0x04001A61 RID: 6753
		internal static GClass30 gclass30_111;

		// Token: 0x04001A62 RID: 6754
		internal static GClass30 gclass30_112;

		// Token: 0x04001A63 RID: 6755
		internal static GClass30 gclass30_113;

		// Token: 0x04001A64 RID: 6756
		internal static GClass30 gclass30_114;

		// Token: 0x04001A65 RID: 6757
		internal static GClass30 gclass30_115;

		// Token: 0x04001A66 RID: 6758
		internal static GClass30 gclass30_116;

		// Token: 0x04001A67 RID: 6759
		internal static GClass30 gclass30_117;

		// Token: 0x04001A68 RID: 6760
		internal static GClass30 gclass30_118;

		// Token: 0x04001A69 RID: 6761
		internal static GClass30 gclass30_119;

		// Token: 0x04001A6A RID: 6762
		internal static GClass30 gclass30_120;

		// Token: 0x04001A6B RID: 6763
		internal static GClass30 gclass30_121;

		// Token: 0x04001A6C RID: 6764
		internal static GClass30 gclass30_122;

		// Token: 0x04001A6D RID: 6765
		internal static GClass30 gclass30_123;

		// Token: 0x04001A6E RID: 6766
		internal static GClass30 gclass30_124;

		// Token: 0x04001A6F RID: 6767
		internal static GClass30 gclass30_125;

		// Token: 0x04001A70 RID: 6768
		internal static GClass30 gclass30_126;

		// Token: 0x04001A71 RID: 6769
		internal static GClass30 gclass30_127;

		// Token: 0x04001A72 RID: 6770
		internal static GClass30 gclass30_128;

		// Token: 0x04001A73 RID: 6771
		internal static GClass30 gclass30_129;

		// Token: 0x04001A74 RID: 6772
		internal static GClass30 gclass30_130;

		// Token: 0x04001A75 RID: 6773
		internal static GClass30 gclass30_131;

		// Token: 0x04001A76 RID: 6774
		internal static GClass30 gclass30_132;

		// Token: 0x04001A77 RID: 6775
		internal static GClass30 gclass30_133;

		// Token: 0x04001A78 RID: 6776
		internal static GClass30 gclass30_134;

		// Token: 0x04001A79 RID: 6777
		internal static List<GClass181.GStruct270> list_0 = new List<GClass181.GStruct270>();

		// Token: 0x04001A7A RID: 6778
		internal static List<GClass30> list_1 = new List<GClass30>();

		// Token: 0x04001A7B RID: 6779
		internal static GClass30 gclass30_135;

		// Token: 0x04001A7C RID: 6780
		internal static GClass30 gclass30_136;

		// Token: 0x04001A7D RID: 6781
		internal static GClass30 gclass30_137;

		// Token: 0x04001A7E RID: 6782
		internal static int int_0 = 0;

		// Token: 0x04001A7F RID: 6783
		internal static List<GClass30> list_2 = new List<GClass30>();

		// Token: 0x04001A80 RID: 6784
		internal static GClass30 gclass30_138;

		// Token: 0x04001A81 RID: 6785
		internal static GClass30 gclass30_139;

		// Token: 0x04001A82 RID: 6786
		internal static GClass30 gclass30_140;

		// Token: 0x04001A83 RID: 6787
		internal static int int_1 = 0;

		// Token: 0x04001A84 RID: 6788
		internal static List<GameObject> list_3 = new List<GameObject>();

		// Token: 0x04001A85 RID: 6789
		internal static List<GClass30> list_4 = new List<GClass30>();

		// Token: 0x04001A86 RID: 6790
		internal static GClass30 gclass30_141;

		// Token: 0x04001A87 RID: 6791
		internal static GClass30 gclass30_142;

		// Token: 0x04001A88 RID: 6792
		internal static GClass30 gclass30_143;

		// Token: 0x04001A89 RID: 6793
		internal static int int_2 = 0;
	}
}
