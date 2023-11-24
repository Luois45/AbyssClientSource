using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns217;
using ns241;
using VRC.Core;

namespace ns73
{
	// Token: 0x02000051 RID: 81
	public class GClass39
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000085DC File Offset: 0x000067DC
		internal void method_0(GClass76 gclass76_0)
		{
			this.method_18(gclass76_0);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000885C File Offset: 0x00006A5C
		internal void method_1()
		{
			this.method_28();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008870 File Offset: 0x00006A70
		internal void method_2()
		{
			this.method_79();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00008884 File Offset: 0x00006A84
		internal void method_3()
		{
			string text = string.Concat(new string[]
			{
				"Max",
				"Random",
				"Avatars",
				": ",
				this.int_0.ToString()
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Max",
				"Last",
				"Avatars",
				": ",
				this.int_1.ToString()
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Max",
				"Last",
				"Friend",
				"Avatars",
				": ",
				this.int_3.ToString()
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Max",
				"Last",
				"Own",
				"Avatars",
				": ",
				this.int_2.ToString()
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Interval",
				"Of",
				"Saving",
				"Avatars",
				": ",
				this.int_4.ToString()
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Favorites",
				"Name",
				": ",
				this.string_8
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Private",
				"Favorites",
				"Name",
				": ",
				this.string_9
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Add",
				"Favorite",
				": ",
				this.string_10
			});
			text = string.Concat(new string[]
			{
				text,
				"\n",
				"Remove",
				"Favorite",
				": ",
				this.string_11
			});
			File.WriteAllText(GClass39.string_1, text);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008AF4 File Offset: 0x00006CF4
		internal void method_4(GClass76 gclass76_0)
		{
			if (this.list_3 == null)
			{
				this.list_3 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_3, gclass76_0);
			if (num == -1)
			{
				this.list_3.Insert(0, gclass76_0);
				this.bool_3 = true;
			}
			else if (num > 0)
			{
				GClass76.smethod_2(this.list_3, gclass76_0, false);
				this.list_3.Insert(0, gclass76_0);
				this.bool_3 = true;
			}
			if (this.list_3.Count > this.int_2)
			{
				this.list_3.RemoveRange(this.int_2, this.list_3.Count - this.int_2);
				this.bool_3 = true;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00008BA8 File Offset: 0x00006DA8
		internal void method_5(ApiAvatar apiAvatar_0)
		{
			this.method_82(apiAvatar_0);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008BBC File Offset: 0x00006DBC
		internal void method_6()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_5))
			{
				this.method_50();
			}
			else
			{
				this.list_3 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_5));
				if (this.list_3 == null)
				{
					this.list_3 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008C1C File Offset: 0x00006E1C
		internal void method_7(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_73(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008C3C File Offset: 0x00006E3C
		internal void method_8()
		{
			this.method_22();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008C50 File Offset: 0x00006E50
		internal void method_9()
		{
			if (this.bool_1 && this.list_1.Count > 0)
			{
				this.list_1.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_0));
				for (int i = this.list_1.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_1[i].string_0, "\"") != -1)
					{
						this.list_1[i].string_0 = GClass84.smethod_494(this.list_1[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_1[i].string_1, "\"") != -1)
					{
						this.list_1[i].string_1 = GClass84.smethod_494(this.list_1[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_3, JsonConvert.SerializeObject(this.list_1, 1));
				this.bool_1 = false;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00008D90 File Offset: 0x00006F90
		internal void method_10(GClass76 gclass76_0)
		{
			if (this.list_2 == null)
			{
				this.list_2 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_2, gclass76_0);
			if (num == -1)
			{
				this.list_2.Insert(0, gclass76_0);
				this.bool_2 = true;
			}
			else if (num > 0)
			{
				GClass76.smethod_2(this.list_2, gclass76_0, false);
				this.list_2.Insert(0, gclass76_0);
				this.bool_2 = true;
			}
			if (this.list_2.Count > this.int_3)
			{
				this.list_2.RemoveRange(this.int_3, this.list_2.Count - this.int_3);
				this.bool_2 = true;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008E44 File Offset: 0x00007044
		internal void method_11(ApiAvatar apiAvatar_0)
		{
			this.method_15(apiAvatar_0);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008E58 File Offset: 0x00007058
		internal void method_12()
		{
			this.method_24();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00008E6C File Offset: 0x0000706C
		internal bool method_13(string string_12)
		{
			bool result;
			if (GClass76.smethod_13(this.list_4, string_12, false))
			{
				this.bool_4 = true;
				this.method_69();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00008E9C File Offset: 0x0000709C
		internal void method_14(GClass76 gclass76_0)
		{
			this.method_46(gclass76_0);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008EB0 File Offset: 0x000070B0
		internal void method_15(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_21(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008ED0 File Offset: 0x000070D0
		internal void method_16()
		{
			this.method_48();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008EE4 File Offset: 0x000070E4
		internal void method_17(GClass76 gclass76_0)
		{
			this.method_65(gclass76_0);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008EF8 File Offset: 0x000070F8
		internal void method_18(GClass76 gclass76_0)
		{
			this.method_20(gclass76_0);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008F0C File Offset: 0x0000710C
		internal void method_19(GClass76 gclass76_0)
		{
			this.method_54(gclass76_0);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00008F20 File Offset: 0x00007120
		internal void method_20(GClass76 gclass76_0)
		{
			if (this.list_1 == null)
			{
				this.list_1 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_1, gclass76_0);
			if (num == -1)
			{
				this.list_1.Insert(0, gclass76_0);
				this.bool_1 = true;
			}
			else if (num > 0)
			{
				GClass76.smethod_2(this.list_1, gclass76_0, false);
				this.list_1.Insert(0, gclass76_0);
				this.bool_1 = true;
			}
			if (this.list_1.Count > this.int_1)
			{
				this.list_1.RemoveRange(this.int_1, this.list_1.Count - this.int_1);
				this.bool_1 = true;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00008FD4 File Offset: 0x000071D4
		internal void method_21(GClass76 gclass76_0)
		{
			this.method_19(gclass76_0);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00008FE8 File Offset: 0x000071E8
		internal void method_22()
		{
			if (this.bool_3 && this.list_3.Count > 0)
			{
				this.list_3.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_4));
				for (int i = this.list_3.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_3[i].string_0, "\"") != -1)
					{
						this.list_3[i].string_0 = GClass84.smethod_494(this.list_3[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_3[i].string_1, "\"") != -1)
					{
						this.list_3[i].string_1 = GClass84.smethod_494(this.list_3[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_5, JsonConvert.SerializeObject(this.list_3, 1));
				this.bool_3 = false;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009128 File Offset: 0x00007328
		internal void method_23()
		{
			this.method_81();
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000913C File Offset: 0x0000733C
		internal void method_24()
		{
			this.method_43();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00009150 File Offset: 0x00007350
		internal void method_25()
		{
			this.method_61();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009164 File Offset: 0x00007364
		internal void method_26()
		{
			if (this.bool_2 && this.list_2.Count > 0)
			{
				this.list_2.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_2));
				for (int i = this.list_2.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_2[i].string_0, "\"") != -1)
					{
						this.list_2[i].string_0 = GClass84.smethod_494(this.list_2[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_2[i].string_1, "\"") != -1)
					{
						this.list_2[i].string_1 = GClass84.smethod_494(this.list_2[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_4, JsonConvert.SerializeObject(this.list_2, 1));
				this.bool_2 = false;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000092A4 File Offset: 0x000074A4
		internal List<GClass76> method_27(int int_5)
		{
			List<GClass76> list = new List<GClass76>();
			List<GClass76> list2 = new List<GClass76>();
			list2.AddRange(this.list_0);
			int num = 0;
			while (num < int_5 && list2.Count > 0)
			{
				int index = GClass84.smethod_1673(list2.Count);
				list.Add(list2[index]);
				list2.RemoveAt(index);
				num++;
			}
			list2.Clear();
			return list;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00009310 File Offset: 0x00007510
		internal void method_28()
		{
			this.method_63();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00009324 File Offset: 0x00007524
		internal void method_29()
		{
			this.method_71();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00009338 File Offset: 0x00007538
		internal void method_30(ApiAvatar apiAvatar_0)
		{
			this.method_75(apiAvatar_0);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000934C File Offset: 0x0000754C
		internal void method_31()
		{
			this.method_80();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00009360 File Offset: 0x00007560
		internal void method_32()
		{
			this.method_53();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00009374 File Offset: 0x00007574
		internal void method_33(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_51(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00009394 File Offset: 0x00007594
		internal void method_34()
		{
			this.method_23();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000093A8 File Offset: 0x000075A8
		internal void method_35()
		{
			this.method_41();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000093BC File Offset: 0x000075BC
		internal void method_36(ApiAvatar apiAvatar_0)
		{
			this.method_66(apiAvatar_0);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000093D0 File Offset: 0x000075D0
		internal void method_37()
		{
			if (this.bool_4 && this.list_4.Count > 0)
			{
				this.list_4.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_3));
				for (int i = this.list_4.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_4[i].string_0, "\"") != -1)
					{
						this.list_4[i].string_0 = GClass84.smethod_494(this.list_4[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_4[i].string_1, "\"") != -1)
					{
						this.list_4[i].string_1 = GClass84.smethod_494(this.list_4[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_6, JsonConvert.SerializeObject(this.list_4, 1));
				this.bool_4 = false;
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00009510 File Offset: 0x00007710
		internal void method_38(ApiAvatar apiAvatar_0)
		{
			this.method_68(apiAvatar_0);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00009524 File Offset: 0x00007724
		internal void method_39()
		{
			this.method_49();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00009538 File Offset: 0x00007738
		internal void method_40()
		{
			this.method_62();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000954C File Offset: 0x0000774C
		internal void method_41()
		{
			this.method_57();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00009560 File Offset: 0x00007760
		internal void method_42(GClass76 gclass76_0)
		{
			this.method_4(gclass76_0);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00009574 File Offset: 0x00007774
		internal void method_43()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_7))
			{
				this.method_16();
			}
			else
			{
				this.list_5 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_7));
				if (this.list_5 == null)
				{
					this.list_5 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000095D4 File Offset: 0x000077D4
		internal void method_44(ApiAvatar apiAvatar_0)
		{
			this.method_11(apiAvatar_0);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000095E8 File Offset: 0x000077E8
		internal void method_45(ApiAvatar apiAvatar_0)
		{
			this.method_30(apiAvatar_0);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000095FC File Offset: 0x000077FC
		internal void method_46(GClass76 gclass76_0)
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_0, gclass76_0);
			if (num == -1)
			{
				this.list_0.Insert(0, gclass76_0);
				this.bool_0 = true;
			}
			else if (GClass76.smethod_12(this.list_0[num], gclass76_0))
			{
				this.list_0[num] = gclass76_0;
				this.bool_0 = true;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00009670 File Offset: 0x00007870
		internal bool method_47(string string_12)
		{
			bool result;
			if (GClass76.smethod_13(this.list_5, string_12, false))
			{
				this.bool_5 = true;
				this.method_16();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000096A0 File Offset: 0x000078A0
		internal void method_48()
		{
			this.method_77();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000096B4 File Offset: 0x000078B4
		internal void method_49()
		{
			this.method_9();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000096C8 File Offset: 0x000078C8
		internal void method_50()
		{
			this.method_8();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000096DC File Offset: 0x000078DC
		internal void method_51(GClass76 gclass76_0)
		{
			this.method_42(gclass76_0);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000096F0 File Offset: 0x000078F0
		internal void method_52(ApiAvatar apiAvatar_0)
		{
			this.method_5(apiAvatar_0);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009704 File Offset: 0x00007904
		internal void method_53()
		{
			this.method_6();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00009718 File Offset: 0x00007918
		internal void method_54(GClass76 gclass76_0)
		{
			if (this.list_5 == null)
			{
				this.list_5 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_5, gclass76_0);
			if (num == -1)
			{
				this.list_5.Insert(0, gclass76_0);
				this.bool_5 = true;
				this.method_16();
			}
			else if (num > 0)
			{
				GClass76.smethod_2(this.list_5, gclass76_0, false);
				this.list_5.Insert(0, gclass76_0);
				this.bool_5 = true;
				this.method_16();
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00009798 File Offset: 0x00007998
		internal void method_55(ApiAvatar apiAvatar_0)
		{
			this.method_83(apiAvatar_0);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000097AC File Offset: 0x000079AC
		internal void method_56()
		{
			this.method_74();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000097C0 File Offset: 0x000079C0
		internal void method_57()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_2))
			{
				this.method_76();
			}
			else
			{
				this.list_0 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_2));
				if (this.list_0 == null)
				{
					this.list_0 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00009820 File Offset: 0x00007A20
		internal void method_58(GClass76 gclass76_0)
		{
			this.method_60(gclass76_0);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00009834 File Offset: 0x00007A34
		internal void method_59()
		{
			this.method_37();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00009848 File Offset: 0x00007A48
		internal void method_60(GClass76 gclass76_0)
		{
			this.method_10(gclass76_0);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000985C File Offset: 0x00007A5C
		internal void method_61()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_6))
			{
				this.method_69();
			}
			else
			{
				this.list_4 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_6));
				if (this.list_4 == null)
				{
					this.list_4 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000098BC File Offset: 0x00007ABC
		internal void method_62()
		{
			this.method_70();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000098D0 File Offset: 0x00007AD0
		internal void method_63()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_4))
			{
				this.method_56();
			}
			else
			{
				this.list_2 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_4));
				if (this.list_2 == null)
				{
					this.list_2 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00009930 File Offset: 0x00007B30
		internal void method_64(ApiAvatar apiAvatar_0)
		{
			this.method_55(apiAvatar_0);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00009944 File Offset: 0x00007B44
		internal void method_65(GClass76 gclass76_0)
		{
			if (this.list_4 == null)
			{
				this.list_4 = new List<GClass76>();
			}
			int num = GClass76.smethod_1(this.list_4, gclass76_0);
			if (num == -1)
			{
				this.list_4.Insert(0, gclass76_0);
				this.bool_4 = true;
				this.method_69();
			}
			else if (num > 0)
			{
				GClass76.smethod_2(this.list_4, gclass76_0, false);
				this.list_4.Insert(0, gclass76_0);
				this.bool_4 = true;
				this.method_69();
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000099C4 File Offset: 0x00007BC4
		internal void method_66(ApiAvatar apiAvatar_0)
		{
			this.method_33(apiAvatar_0);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000099D8 File Offset: 0x00007BD8
		internal void method_67(GClass76 gclass76_0)
		{
			this.method_14(gclass76_0);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000099EC File Offset: 0x00007BEC
		internal void method_68(ApiAvatar apiAvatar_0)
		{
			this.method_7(apiAvatar_0);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00009A00 File Offset: 0x00007C00
		internal void method_69()
		{
			this.method_59();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00009A14 File Offset: 0x00007C14
		internal void method_70()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_1))
			{
				this.method_29();
			}
			else
			{
				string[] array = File.ReadAllLines(GClass39.string_1);
				foreach (string text in array)
				{
					if (GClass84.smethod_1428(text, GClass84.smethod_593("MaxRandomAvatars: ")) == "MaxRandomAvatars: ")
					{
						this.int_0 = GClass84.smethod_183(GClass84.smethod_1204(text, GClass84.smethod_593("MaxRandomAvatars: "), -1));
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("MaxLastAvatars: ")) == "MaxLastAvatars: ")
					{
						this.int_1 = GClass84.smethod_183(GClass84.smethod_1204(text, GClass84.smethod_593("MaxLastAvatars: "), -1));
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("MaxLastFriendAvatars: ")) == "MaxLastFriendAvatars: ")
					{
						this.int_3 = GClass84.smethod_183(GClass84.smethod_1204(text, GClass84.smethod_593("MaxLastFriendAvatars: "), -1));
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("MaxLastOwnAvatars: ")) == "MaxLastOwnAvatars: ")
					{
						this.int_2 = GClass84.smethod_183(GClass84.smethod_1204(text, GClass84.smethod_593("MaxLastOwnAvatars: "), -1));
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("IntervalOfSavingAvatars: ")) == "IntervalOfSavingAvatars: ")
					{
						this.int_4 = GClass84.smethod_183(GClass84.smethod_1204(text, GClass84.smethod_593("IntervalOfSavingAvatars: "), -1));
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("FavoritesName: ")) == "FavoritesName: ")
					{
						this.string_8 = GClass84.smethod_1204(text, GClass84.smethod_593("FavoritesName: "), -1);
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("PrivateFavoritesName: ")) == "PrivateFavoritesName: ")
					{
						this.string_9 = GClass84.smethod_1204(text, GClass84.smethod_593("PrivateFavoritesName: "), -1);
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("AddFavorite: ")) == "AddFavorite: ")
					{
						this.string_10 = GClass84.smethod_1204(text, GClass84.smethod_593("AddFavorite: "), -1);
					}
					else if (GClass84.smethod_1428(text, GClass84.smethod_593("RemoveFavorite: ")) == "RemoveFavorite: ")
					{
						this.string_11 = GClass84.smethod_1204(text, GClass84.smethod_593("RemoveFavorite: "), -1);
					}
				}
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00009C84 File Offset: 0x00007E84
		internal void method_71()
		{
			this.method_3();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00009C98 File Offset: 0x00007E98
		internal void method_72()
		{
			Directory.CreateDirectory(GClass39.string_0);
			if (!File.Exists(GClass39.string_3))
			{
				this.method_39();
			}
			else
			{
				this.list_1 = JsonConvert.DeserializeObject<List<GClass76>>(File.ReadAllText(GClass39.string_3));
				if (this.list_1 == null)
				{
					this.list_1 = new List<GClass76>();
					this.method_76();
				}
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00009CF8 File Offset: 0x00007EF8
		internal void method_73(GClass76 gclass76_0)
		{
			this.method_17(gclass76_0);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00009D0C File Offset: 0x00007F0C
		internal void method_74()
		{
			this.method_26();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00009D20 File Offset: 0x00007F20
		internal void method_75(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_0(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00009D40 File Offset: 0x00007F40
		internal void method_76()
		{
			this.method_2();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00009D54 File Offset: 0x00007F54
		internal void method_77()
		{
			if (this.bool_5 && this.list_5.Count > 0)
			{
				this.list_5.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_5));
				for (int i = this.list_5.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_5[i].string_0, "\"") != -1)
					{
						this.list_5[i].string_0 = GClass84.smethod_494(this.list_5[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_5[i].string_1, "\"") != -1)
					{
						this.list_5[i].string_1 = GClass84.smethod_494(this.list_5[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_7, JsonConvert.SerializeObject(this.list_5, 1));
				this.bool_5 = false;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00009E94 File Offset: 0x00008094
		internal void method_78()
		{
			this.method_25();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00009EA8 File Offset: 0x000080A8
		internal void method_79()
		{
			if (this.bool_0 && this.list_0.Count > 0)
			{
				this.list_0.RemoveAll(new Predicate<GClass76>(GClass39.Class6.class6_0.method_1));
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					if (GClass84.smethod_1611(this.list_0[i].string_0, "\"") != -1)
					{
						this.list_0[i].string_0 = GClass84.smethod_494(this.list_0[i].string_0, "\"", string.Empty, true);
					}
					if (GClass84.smethod_1611(this.list_0[i].string_1, "\"") != -1)
					{
						this.list_0[i].string_1 = GClass84.smethod_494(this.list_0[i].string_1, "\"", string.Empty, true);
					}
				}
				File.WriteAllText(GClass39.string_2, JsonConvert.SerializeObject(this.list_0, 1));
				this.bool_0 = false;
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00009FE8 File Offset: 0x000081E8
		internal void method_80()
		{
			this.method_72();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00009FFC File Offset: 0x000081FC
		internal void method_81()
		{
			this.method_76();
			this.method_39();
			this.method_56();
			this.method_50();
			this.method_69();
			this.method_16();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000A030 File Offset: 0x00008230
		internal void method_82(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_58(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000A050 File Offset: 0x00008250
		internal void method_83(ApiAvatar apiAvatar_0)
		{
			if (apiAvatar_0 != null)
			{
				this.method_67(new GClass76(apiAvatar_0));
			}
		}

		// Token: 0x04000133 RID: 307
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/SavedAvatars");

		// Token: 0x04000134 RID: 308
		internal static string string_1 = GClass39.string_0 + "/" + "config" + ".txt";

		// Token: 0x04000135 RID: 309
		internal static string string_2 = GClass39.string_0 + "/" + "Avatars" + ".json";

		// Token: 0x04000136 RID: 310
		internal static string string_3 = string.Concat(new string[]
		{
			GClass39.string_0,
			"/",
			"Last",
			"Avatars",
			".json"
		});

		// Token: 0x04000137 RID: 311
		internal static string string_4 = string.Concat(new string[]
		{
			GClass39.string_0,
			"/",
			"Last",
			"Friend",
			"Avatars",
			".json"
		});

		// Token: 0x04000138 RID: 312
		internal static string string_5 = string.Concat(new string[]
		{
			GClass39.string_0,
			"/",
			"Last",
			"Own",
			"Avatars",
			".json"
		});

		// Token: 0x04000139 RID: 313
		internal static string string_6 = string.Concat(new string[]
		{
			GClass39.string_0,
			"/",
			"Favorite",
			"Avatars",
			".json"
		});

		// Token: 0x0400013A RID: 314
		internal static string string_7 = string.Concat(new string[]
		{
			GClass39.string_0,
			"/",
			"Favorite",
			"Private",
			"Avatars",
			".json"
		});

		// Token: 0x0400013B RID: 315
		public List<GClass76> list_0 = new List<GClass76>();

		// Token: 0x0400013C RID: 316
		public List<GClass76> list_1 = new List<GClass76>();

		// Token: 0x0400013D RID: 317
		public List<GClass76> list_2 = new List<GClass76>();

		// Token: 0x0400013E RID: 318
		public List<GClass76> list_3 = new List<GClass76>();

		// Token: 0x0400013F RID: 319
		public List<GClass76> list_4 = new List<GClass76>();

		// Token: 0x04000140 RID: 320
		public List<GClass76> list_5 = new List<GClass76>();

		// Token: 0x04000141 RID: 321
		public bool bool_0 = false;

		// Token: 0x04000142 RID: 322
		public bool bool_1 = false;

		// Token: 0x04000143 RID: 323
		public bool bool_2 = false;

		// Token: 0x04000144 RID: 324
		public bool bool_3 = false;

		// Token: 0x04000145 RID: 325
		public bool bool_4 = false;

		// Token: 0x04000146 RID: 326
		public bool bool_5 = false;

		// Token: 0x04000147 RID: 327
		public int int_0 = 100;

		// Token: 0x04000148 RID: 328
		public int int_1 = 500;

		// Token: 0x04000149 RID: 329
		public int int_2 = 100;

		// Token: 0x0400014A RID: 330
		public int int_3 = 250;

		// Token: 0x0400014B RID: 331
		public int int_4 = 300;

		// Token: 0x0400014C RID: 332
		public string string_8 = "Local_Favorites";

		// Token: 0x0400014D RID: 333
		public string string_9 = "Local_Private_Favorites";

		// Token: 0x0400014E RID: 334
		public string string_10 = "+Favorite";

		// Token: 0x0400014F RID: 335
		public string string_11 = "-Favorite";

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		[Serializable]
		private sealed class Class6
		{
			// Token: 0x0600030C RID: 780 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_0(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x0600030D RID: 781 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_1(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x0600030F RID: 783 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_2(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_3(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_4(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x06000313 RID: 787 RVA: 0x0000A070 File Offset: 0x00008270
			internal bool method_5(GClass76 gclass76_0)
			{
				return gclass76_0.string_2 == string.Empty;
			}

			// Token: 0x04000150 RID: 336
			public static readonly GClass39.Class6 class6_0 = new GClass39.Class6();

			// Token: 0x04000151 RID: 337
			public static Predicate<GClass76> predicate_0;

			// Token: 0x04000152 RID: 338
			public static Predicate<GClass76> predicate_1;

			// Token: 0x04000153 RID: 339
			public static Predicate<GClass76> predicate_2;

			// Token: 0x04000154 RID: 340
			public static Predicate<GClass76> predicate_3;

			// Token: 0x04000155 RID: 341
			public static Predicate<GClass76> predicate_4;

			// Token: 0x04000156 RID: 342
			public static Predicate<GClass76> predicate_5;
		}
	}
}
