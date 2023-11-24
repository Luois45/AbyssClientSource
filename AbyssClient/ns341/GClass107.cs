using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ns241;
using ns441;

namespace ns341
{
	// Token: 0x020002AB RID: 683
	public class GClass107
	{
		// Token: 0x06001F94 RID: 8084 RVA: 0x000A37C4 File Offset: 0x000A19C4
		internal void method_0()
		{
			this.method_11();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000A37D8 File Offset: 0x000A19D8
		internal void method_1()
		{
			Directory.CreateDirectory("_Unreal/AntiCrash");
			List<string> list = new List<string>();
			if (!File.Exists("_Unreal/AntiCrash//WhiteListedAvatars.txt"))
			{
				this.method_36();
			}
			else
			{
				list = File.ReadAllLines("_Unreal/AntiCrash//WhiteListedAvatars.txt").OfType<string>().ToList<string>();
			}
			GClass84.smethod_661<string>(ref list);
			GClass84.smethod_1233<string>(list);
			list.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_3));
			this.list_6.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				int num = GClass84.smethod_1611(list[i], " ");
				if (num != -1)
				{
					this.list_6.Add(new GClass145.GStruct102(GClass84.smethod_1428(list[i], num), GClass84.smethod_1204(list[i], num + 1, -1)));
				}
				else
				{
					this.list_6.Add(new GClass145.GStruct102(list[i], string.Empty));
				}
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000A38DC File Offset: 0x000A1ADC
		internal void method_2()
		{
			this.method_17();
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000A38F0 File Offset: 0x000A1AF0
		internal void method_3()
		{
			if (this.method_38() && this.list_0 != null && this.list_0.Count > 0)
			{
				this.method_4();
				File.WriteAllText("_Unreal/AntiCrash//Shaders.txt", string.Join("\n", this.list_0.ToArray()));
				this.method_24();
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000A3950 File Offset: 0x000A1B50
		internal void method_4()
		{
			this.method_29();
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000A3964 File Offset: 0x000A1B64
		internal void method_5()
		{
			if (this.list_7 != null)
			{
				File.WriteAllText("_Unreal/AntiCrash//WhiteListedUsers.txt", string.Join("\n", GClass145.GStruct102.smethod_3(this.list_7).ToArray()));
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000A39A0 File Offset: 0x000A1BA0
		internal void method_6()
		{
			this.method_9();
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000A39B4 File Offset: 0x000A1BB4
		internal void method_7()
		{
			Directory.CreateDirectory("_Unreal/AntiCrash");
			List<string> list = new List<string>();
			if (!File.Exists("_Unreal/AntiCrash//BlockedAvatars.txt"))
			{
				this.method_21();
			}
			else
			{
				list = File.ReadAllLines("_Unreal/AntiCrash//BlockedAvatars.txt").OfType<string>().ToList<string>();
			}
			GClass84.smethod_661<string>(ref list);
			GClass84.smethod_1233<string>(list);
			list.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_1));
			this.list_2.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				int num = GClass84.smethod_1611(list[i], " ");
				if (num != -1)
				{
					this.list_2.Add(new GClass145.GStruct102(GClass84.smethod_1428(list[i], num), GClass84.smethod_1204(list[i], num + 1, -1)));
				}
				else
				{
					this.list_2.Add(new GClass145.GStruct102(list[i], string.Empty));
				}
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000A3AB8 File Offset: 0x000A1CB8
		internal void method_8()
		{
			this.method_5();
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000A3ACC File Offset: 0x000A1CCC
		internal void method_9()
		{
			this.method_35();
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000A3AE0 File Offset: 0x000A1CE0
		internal void method_10()
		{
			this.method_34();
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x000A3AF4 File Offset: 0x000A1CF4
		internal void method_11()
		{
			this.method_7();
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x000A3B08 File Offset: 0x000A1D08
		internal void method_12()
		{
			Directory.CreateDirectory("_Unreal/AntiCrash");
			List<string> list = new List<string>();
			if (!File.Exists("_Unreal/AntiCrash//WhiteListedUsers.txt"))
			{
				this.method_26();
			}
			else
			{
				list = File.ReadAllLines("_Unreal/AntiCrash//WhiteListedUsers.txt").OfType<string>().ToList<string>();
			}
			GClass84.smethod_661<string>(ref list);
			GClass84.smethod_1233<string>(list);
			list.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_5));
			this.list_7.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				int num = GClass84.smethod_1611(list[i], " ");
				if (num != -1)
				{
					this.list_7.Add(new GClass145.GStruct102(GClass84.smethod_1428(list[i], num), GClass84.smethod_1204(list[i], num + 1, -1)));
				}
				else
				{
					this.list_7.Add(new GClass145.GStruct102(list[i], string.Empty));
				}
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000A3C0C File Offset: 0x000A1E0C
		internal void method_13()
		{
			this.method_31();
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000A3C20 File Offset: 0x000A1E20
		internal void method_14()
		{
			this.method_33();
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000A3C34 File Offset: 0x000A1E34
		internal void method_15()
		{
			this.method_19();
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000A3C48 File Offset: 0x000A1E48
		internal void method_16()
		{
			this.method_18();
			this.method_0();
			this.method_6();
			this.method_32();
			this.method_15();
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000A3C74 File Offset: 0x000A1E74
		internal void method_17()
		{
			Directory.CreateDirectory("_Unreal/AntiCrash");
			if (!File.Exists("_Unreal/AntiCrash//Shaders.txt"))
			{
				this.method_13();
			}
			else
			{
				this.list_0 = File.ReadAllLines("_Unreal/AntiCrash//Shaders.txt").OfType<string>().ToList<string>();
			}
			this.method_24();
			GClass84.smethod_661<string>(ref this.list_0);
			GClass84.smethod_1233<string>(this.list_0);
			this.list_0.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_2));
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000A3D04 File Offset: 0x000A1F04
		internal void method_18()
		{
			this.method_2();
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000A3D18 File Offset: 0x000A1F18
		internal void method_19()
		{
			this.method_12();
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000A3D2C File Offset: 0x000A1F2C
		internal void method_20()
		{
			if (this.list_2 != null)
			{
				File.WriteAllText("_Unreal/AntiCrash//BlockedAvatars.txt", string.Join("\n", GClass145.GStruct102.smethod_3(this.list_2).ToArray()));
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000A3D68 File Offset: 0x000A1F68
		internal void method_21()
		{
			this.method_25();
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x000A3D7C File Offset: 0x000A1F7C
		internal void method_22()
		{
			this.method_39();
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000A3D90 File Offset: 0x000A1F90
		internal void method_23()
		{
			this.method_28();
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
		internal void method_24()
		{
			this.method_22();
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
		internal void method_25()
		{
			this.method_20();
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000A3DCC File Offset: 0x000A1FCC
		internal void method_26()
		{
			this.method_8();
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x000A3DE0 File Offset: 0x000A1FE0
		internal void method_27()
		{
			if (this.list_0 != null && this.list_0.Count > 1)
			{
				this.list_0.Sort();
			}
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000A3E14 File Offset: 0x000A2014
		internal void method_28()
		{
			if (this.list_6 != null)
			{
				File.WriteAllText("_Unreal/AntiCrash//WhiteListedAvatars.txt", string.Join("\n", GClass145.GStruct102.smethod_3(this.list_6).ToArray()));
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000A3E50 File Offset: 0x000A2050
		internal void method_29()
		{
			this.method_27();
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x000A3ED0 File Offset: 0x000A20D0
		internal void method_30()
		{
			this.method_1();
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000A3EE4 File Offset: 0x000A20E4
		internal void method_31()
		{
			this.method_3();
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000A3EF8 File Offset: 0x000A20F8
		internal void method_32()
		{
			this.method_30();
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000A3F0C File Offset: 0x000A210C
		internal void method_33()
		{
			if (this.list_4 != null)
			{
				File.WriteAllText("_Unreal/AntiCrash//BlockedAvatars_Authors.txt", string.Join("\n", GClass145.GStruct102.smethod_3(this.list_4).ToArray()));
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x000A3F48 File Offset: 0x000A2148
		internal void method_34()
		{
			this.method_16();
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x000A3F5C File Offset: 0x000A215C
		internal void method_35()
		{
			Directory.CreateDirectory("_Unreal/AntiCrash");
			List<string> list = new List<string>();
			if (!File.Exists("_Unreal/AntiCrash//BlockedAvatars_Authors.txt"))
			{
				this.method_37();
			}
			else
			{
				list = File.ReadAllLines("_Unreal/AntiCrash//BlockedAvatars_Authors.txt").OfType<string>().ToList<string>();
			}
			GClass84.smethod_661<string>(ref list);
			GClass84.smethod_1233<string>(list);
			list.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_0));
			this.list_4.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				int num = GClass84.smethod_1611(list[i], " ");
				if (num != -1)
				{
					this.list_4.Add(new GClass145.GStruct102(GClass84.smethod_1428(list[i], num), GClass84.smethod_1204(list[i], num + 1, -1)));
				}
				else
				{
					this.list_4.Add(new GClass145.GStruct102(list[i], string.Empty));
				}
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000A4060 File Offset: 0x000A2260
		internal void method_36()
		{
			this.method_23();
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000A4074 File Offset: 0x000A2274
		internal void method_37()
		{
			this.method_14();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000A4088 File Offset: 0x000A2288
		internal bool method_38()
		{
			GClass84.smethod_661<string>(ref this.list_0);
			GClass84.smethod_1233<string>(this.list_0);
			this.list_0.RemoveAll(new Predicate<string>(GClass107.Class170.class170_0.method_4));
			bool result;
			if (this.list_0.Count != this.list_1.Count)
			{
				result = true;
			}
			else
			{
				for (int i = 0; i < this.list_1.Count; i++)
				{
					if (this.list_0[i] != this.list_1[i])
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x000A4138 File Offset: 0x000A2338
		internal void method_39()
		{
			this.list_1.Clear();
			this.list_1.AddRange(this.list_0);
		}

		// Token: 0x04001255 RID: 4693
		public List<string> list_0 = new List<string>();

		// Token: 0x04001256 RID: 4694
		public List<string> list_1 = new List<string>();

		// Token: 0x04001257 RID: 4695
		public List<GClass145.GStruct102> list_2 = new List<GClass145.GStruct102>();

		// Token: 0x04001258 RID: 4696
		public List<GClass145.GStruct102> list_3 = new List<GClass145.GStruct102>();

		// Token: 0x04001259 RID: 4697
		public List<GClass145.GStruct102> list_4 = new List<GClass145.GStruct102>();

		// Token: 0x0400125A RID: 4698
		public List<GClass145.GStruct102> list_5 = new List<GClass145.GStruct102>();

		// Token: 0x0400125B RID: 4699
		public List<GClass145.GStruct102> list_6 = new List<GClass145.GStruct102>();

		// Token: 0x0400125C RID: 4700
		public List<GClass145.GStruct102> list_7 = new List<GClass145.GStruct102>();

		// Token: 0x020002AC RID: 684
		[CompilerGenerated]
		[Serializable]
		private sealed class Class170
		{
			// Token: 0x06001FBF RID: 8127 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_0(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x06001FC0 RID: 8128 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_1(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x06001FC2 RID: 8130 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_2(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x06001FC3 RID: 8131 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_3(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x06001FC4 RID: 8132 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_4(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x000A4164 File Offset: 0x000A2364
			internal bool method_5(string string_0)
			{
				return string_0 == string.Empty;
			}

			// Token: 0x0400125D RID: 4701
			public static readonly GClass107.Class170 class170_0 = new GClass107.Class170();

			// Token: 0x0400125E RID: 4702
			public static Predicate<string> predicate_0;

			// Token: 0x0400125F RID: 4703
			public static Predicate<string> predicate_1;

			// Token: 0x04001260 RID: 4704
			public static Predicate<string> predicate_2;

			// Token: 0x04001261 RID: 4705
			public static Predicate<string> predicate_3;

			// Token: 0x04001262 RID: 4706
			public static Predicate<string> predicate_4;

			// Token: 0x04001263 RID: 4707
			public static Predicate<string> predicate_5;
		}
	}
}
