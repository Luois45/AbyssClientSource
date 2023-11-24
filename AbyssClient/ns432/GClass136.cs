using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns241;
using ns275;
using ns425;
using UnityEngine;

namespace ns432
{
	// Token: 0x020000CF RID: 207
	public class GClass136 : GClass130
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x0001B3BC File Offset: 0x000195BC
		public override void vmethod_10()
		{
			this.method_8();
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001B3D0 File Offset: 0x000195D0
		internal bool method_2(GClass136.GStruct52 gstruct52_0)
		{
			foreach (GClass136.GStruct52 gstruct in this.list_0)
			{
				if (gstruct.string_0 == gstruct52_0.string_0 && gstruct.string_1 == gstruct52_0.string_1 && gstruct.int_0 == gstruct52_0.int_0 && gstruct.int_1 == gstruct52_0.int_1 && gstruct.int_2 == gstruct52_0.int_2)
				{
					return false;
				}
			}
			this.list_0.Add(gstruct52_0);
			return true;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001B4B4 File Offset: 0x000196B4
		internal void method_3()
		{
			this.method_9();
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public GClass136.GStruct52 method_4(int int_0, int int_1, int int_2)
		{
			return new GClass136.GStruct52("Restart Time!", "%Time% Seconds Before Restart", int_0, int_1, int_2, new Action(GClass136.Class50.class50_0.method_0));
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001B508 File Offset: 0x00019708
		internal void method_5(bool bool_0)
		{
			this.method_16(bool_0);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001B51C File Offset: 0x0001971C
		internal void method_6()
		{
			if (this.float_0 != -1f)
			{
				float num = (float)GClass84.smethod_1451(true) - this.float_0;
				for (int i = 0; i < this.list_0.Count; i++)
				{
					GClass136.GStruct52 gstruct = this.list_0[i];
					if (!gstruct.bool_0 && (float)gstruct.int_0 <= num)
					{
						this.method_14(gstruct);
						gstruct.bool_0 = true;
						this.list_0[i] = gstruct;
					}
					else if ((float)gstruct.int_0 > num)
					{
						int num2 = gstruct.int_0 - gstruct.int_1;
						int int_ = gstruct.int_2;
						int num3 = num2;
						while ((float)num3 <= num)
						{
							if (num3 > gstruct.int_3)
							{
								this.method_10(gstruct, (float)gstruct.int_0 - num);
								gstruct.int_3 = (int)num;
								this.list_0[i] = gstruct;
							}
							num3 += int_;
						}
					}
				}
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001B620 File Offset: 0x00019820
		internal void method_7(bool bool_0)
		{
			this.method_5(bool_0);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001B634 File Offset: 0x00019834
		internal void method_8()
		{
			this.method_6();
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001B648 File Offset: 0x00019848
		internal void method_9()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass91.smethod_1();
			this.float_0 = (float)GClass84.smethod_1451(true);
			if (GClass91.gclass91_0.bool_0)
			{
				this.method_2(this.method_12());
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001B698 File Offset: 0x00019898
		internal bool method_10(GClass136.GStruct52 gstruct52_0, float float_1)
		{
			GClass84.smethod_1188(GClass84.smethod_494(gstruct52_0.string_1, "%Time%", ((int)float_1).ToString(), false), Color.white);
			return true;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001B6CC File Offset: 0x000198CC
		internal bool method_11(string string_1, string string_2, int int_0, int int_1, int int_2)
		{
			bool result = false;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass136.GStruct52 gstruct = this.list_0[i];
				if (gstruct.string_0 == string_1 && gstruct.string_1 == string_2 && gstruct.int_0 == int_0 && gstruct.int_1 == int_1 && gstruct.int_2 == int_2)
				{
					this.list_0.RemoveAt(i);
					i--;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001B754 File Offset: 0x00019954
		public GClass136.GStruct52 method_12()
		{
			return this.method_4(3600, 300, 30);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001B778 File Offset: 0x00019978
		public override void vmethod_23()
		{
			this.method_3();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001B78C File Offset: 0x0001998C
		internal bool method_13(string string_1, string string_2, int int_0, int int_1, int int_2, Action action_0)
		{
			foreach (GClass136.GStruct52 gstruct in this.list_0)
			{
				if (gstruct.string_0 == string_1 && gstruct.string_1 == string_2 && gstruct.int_0 == int_0 && gstruct.int_1 == int_1 && gstruct.int_2 == int_2)
				{
					return false;
				}
			}
			this.list_0.Add(new GClass136.GStruct52(string_1, string_2, int_0, int_1, int_2, action_0));
			return true;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001B838 File Offset: 0x00019A38
		internal bool method_14(GClass136.GStruct52 gstruct52_0)
		{
			GClass84.smethod_1188(gstruct52_0.string_0, Color.red);
			if (gstruct52_0.action_0 != null)
			{
				gstruct52_0.action_0();
			}
			return true;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001B86C File Offset: 0x00019A6C
		internal bool method_15(GClass136.GStruct52 gstruct52_0)
		{
			bool result = false;
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass136.GStruct52 gstruct = this.list_0[i];
				if (gstruct.string_0 == gstruct52_0.string_0 && gstruct.string_1 == gstruct52_0.string_1 && gstruct.int_0 == gstruct52_0.int_0 && gstruct.int_1 == gstruct52_0.int_1 && gstruct.int_2 == gstruct52_0.int_2)
				{
					this.list_0.RemoveAt(i);
					i--;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001B90C File Offset: 0x00019B0C
		internal void method_16(bool bool_0)
		{
			GClass91.gclass91_0.bool_0 = bool_0;
			GClass91.smethod_0();
			if (GClass91.gclass91_0.bool_0)
			{
				this.method_2(this.method_12());
			}
			else
			{
				this.method_15(this.method_12());
			}
		}

		// Token: 0x0400050E RID: 1294
		internal float float_0 = -1f;

		// Token: 0x0400050F RID: 1295
		internal List<GClass136.GStruct52> list_0 = new List<GClass136.GStruct52>();

		// Token: 0x020000D0 RID: 208
		public struct GStruct52
		{
			// Token: 0x060006C6 RID: 1734 RVA: 0x0001B954 File Offset: 0x00019B54
			public GStruct52(string string_2, string string_3, int int_4, int int_5, int int_6, Action action_1)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.action_0 = action_1;
				this.int_3 = 0;
				this.bool_0 = false;
			}

			// Token: 0x04000510 RID: 1296
			public string string_0;

			// Token: 0x04000511 RID: 1297
			public string string_1;

			// Token: 0x04000512 RID: 1298
			public int int_0;

			// Token: 0x04000513 RID: 1299
			public int int_1;

			// Token: 0x04000514 RID: 1300
			public int int_2;

			// Token: 0x04000515 RID: 1301
			public Action action_0;

			// Token: 0x04000516 RID: 1302
			public int int_3;

			// Token: 0x04000517 RID: 1303
			public bool bool_0;
		}

		// Token: 0x020000D1 RID: 209
		[CompilerGenerated]
		[Serializable]
		private sealed class Class50
		{
			// Token: 0x060006C7 RID: 1735 RVA: 0x0001B99C File Offset: 0x00019B9C
			internal void method_0()
			{
				string dataPath = Application.dataPath;
				List<int> list = GClass84.smethod_932(Application.dataPath, "/");
				Process.Start(GClass84.smethod_1428(dataPath, list[list.Count - 1]) + "/" + "VRChat" + ".exe", "--no-vr");
				Application.Quit();
			}

			// Token: 0x04000518 RID: 1304
			public static readonly GClass136.Class50 class50_0 = new GClass136.Class50();

			// Token: 0x04000519 RID: 1305
			public static Action action_0;
		}
	}
}
