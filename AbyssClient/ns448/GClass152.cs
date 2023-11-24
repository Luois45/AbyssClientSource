using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using ns185;
using ns241;
using ns365;
using ns418;
using ns425;
using VRC.Core;

namespace ns448
{
	// Token: 0x020001AC RID: 428
	public class GClass152 : GClass130
	{
		// Token: 0x0600100F RID: 4111 RVA: 0x0005534C File Offset: 0x0005354C
		internal void method_2()
		{
			this.method_6();
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00055360 File Offset: 0x00053560
		internal void method_3()
		{
			this.method_71();
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00055374 File Offset: 0x00053574
		internal void method_4()
		{
			this.method_63();
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00055388 File Offset: 0x00053588
		private string method_5()
		{
			return this.method_38();
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0005539C File Offset: 0x0005359C
		internal void method_6()
		{
			this.method_55();
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000553B0 File Offset: 0x000535B0
		internal void method_7(int int_1)
		{
			this.method_76(int_1);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000553C4 File Offset: 0x000535C4
		internal void method_8(string string_6)
		{
			this.method_20(string_6);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000553D8 File Offset: 0x000535D8
		internal void method_9()
		{
			this.method_58();
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000553EC File Offset: 0x000535EC
		internal void method_10()
		{
			this.method_19();
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00055400 File Offset: 0x00053600
		public virtual void vmethod_26(string string_6)
		{
			this.method_54(string_6);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00055414 File Offset: 0x00053614
		internal void method_11()
		{
			this.method_72();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00055428 File Offset: 0x00053628
		internal void method_12(string string_6)
		{
			this.method_57(string_6);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0005543C File Offset: 0x0005363C
		internal void method_13(string string_6)
		{
			this.method_12(string_6);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00055450 File Offset: 0x00053650
		internal void method_14(string string_6)
		{
			if (!(string_6 == string.Empty))
			{
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0005546C File Offset: 0x0005366C
		internal void method_15(bool bool_8)
		{
			this.method_49(bool_8);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00055480 File Offset: 0x00053680
		internal void method_16(object object_1)
		{
			GClass152.Class92 @class = new GClass152.Class92();
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.gclass152_0 = this;
			@class.object_0 = object_1;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0.Start<GClass152.Class92>(ref @class);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000554C0 File Offset: 0x000536C0
		internal void method_17()
		{
			this.method_27();
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000554D4 File Offset: 0x000536D4
		public override void vmethod_23()
		{
			this.method_37();
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000554E8 File Offset: 0x000536E8
		internal void method_18(GClass152.GEnum45 genum45_1)
		{
			switch (genum45_1)
			{
			case GClass152.GEnum45.const_1:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator = Class186.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class186.Struct33 @struct = enumerator.Current;
						if (@struct.enum11_0 == Class186.Enum11.const_0)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_CC;
				}
				IL_AE:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_CC:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_AE;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_2:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator2 = Class186.list_0.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Class186.Struct33 struct2 = enumerator2.Current;
						if (struct2.enum11_0 == Class186.Enum11.const_3)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_184;
				}
				IL_166:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_184:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_166;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_3:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator3 = Class186.list_0.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						Class186.Struct33 struct3 = enumerator3.Current;
						if (struct3.enum11_0 == Class186.Enum11.const_4)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_23C;
				}
				IL_21E:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_23C:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_21E;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_4:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator4 = Class186.list_0.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						Class186.Struct33 struct4 = enumerator4.Current;
						if (struct4.enum11_0 == Class186.Enum11.const_3 || struct4.enum11_0 == Class186.Enum11.const_4)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_301;
				}
				IL_2E3:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_301:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_2E3;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_5:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator5 = Class186.list_0.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						Class186.Struct33 struct5 = enumerator5.Current;
						if (struct5.enum11_0 == Class186.Enum11.const_0 || struct5.enum11_0 == Class186.Enum11.const_3)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_3C5;
				}
				IL_3A7:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_3C5:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_3A7;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_6:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator6 = Class186.list_0.GetEnumerator())
				{
					while (enumerator6.MoveNext())
					{
						Class186.Struct33 struct6 = enumerator6.Current;
						if (struct6.enum11_0 == Class186.Enum11.const_0 || struct6.enum11_0 == Class186.Enum11.const_4)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_489;
				}
				IL_46B:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_489:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_46B;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_7:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator7 = Class186.list_0.GetEnumerator())
				{
					while (enumerator7.MoveNext())
					{
						Class186.Struct33 struct7 = enumerator7.Current;
						if (struct7.enum11_0 == Class186.Enum11.const_0 || struct7.enum11_0 == Class186.Enum11.const_3 || struct7.enum11_0 == Class186.Enum11.const_4)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_557;
				}
				IL_539:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_557:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_539;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_8:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator8 = Class186.list_0.GetEnumerator())
				{
					while (enumerator8.MoveNext())
					{
						Class186.Struct33 struct8 = enumerator8.Current;
						if (struct8.enum11_0 != Class186.Enum11.const_0)
						{
							goto IL_5B6;
						}
						if (struct8.int_0 != 1)
						{
							goto IL_5B6;
						}
						bool flag = true;
						IL_5C0:
						if (flag)
						{
							this.string_1 += "1";
							continue;
						}
						this.string_1 += "0";
						continue;
						IL_5B6:
						flag = (struct8.enum11_0 == Class186.Enum11.const_3);
						goto IL_5C0;
					}
					goto IL_627;
				}
				IL_609:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_627:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_609;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_9:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator9 = Class186.list_0.GetEnumerator())
				{
					while (enumerator9.MoveNext())
					{
						Class186.Struct33 struct9 = enumerator9.Current;
						if (struct9.enum11_0 != Class186.Enum11.const_0)
						{
							goto IL_686;
						}
						if (struct9.int_0 != 1)
						{
							goto IL_686;
						}
						bool flag2 = true;
						IL_690:
						if (flag2)
						{
							this.string_1 += "1";
							continue;
						}
						this.string_1 += "0";
						continue;
						IL_686:
						flag2 = (struct9.enum11_0 == Class186.Enum11.const_4);
						goto IL_690;
					}
					goto IL_6F7;
				}
				IL_6D9:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_6F7:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_6D9;
				}
				this.bool_2 = true;
				break;
			case GClass152.GEnum45.const_10:
				this.string_1 = string.Empty;
				using (List<Class186.Struct33>.Enumerator enumerator10 = Class186.list_0.GetEnumerator())
				{
					while (enumerator10.MoveNext())
					{
						Class186.Struct33 struct10 = enumerator10.Current;
						if ((struct10.enum11_0 == Class186.Enum11.const_0 && struct10.int_0 == 1) || struct10.enum11_0 == Class186.Enum11.const_3 || struct10.enum11_0 == Class186.Enum11.const_4)
						{
							this.string_1 += "1";
						}
						else
						{
							this.string_1 += "0";
						}
					}
					goto IL_7CF;
				}
				IL_7B1:
				this.string_1 = GClass84.smethod_1428(this.string_1, GClass84.smethod_593(this.string_1) - 1);
				IL_7CF:
				if (GClass84.smethod_360(this.string_1, 1) == "0")
				{
					goto IL_7B1;
				}
				this.bool_2 = true;
				break;
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00055D60 File Offset: 0x00053F60
		internal void method_19()
		{
			for (;;)
			{
				this.method_21();
				Thread.Sleep((int)(this.float_0 * 1000f));
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00055D88 File Offset: 0x00053F88
		internal void method_20(string string_6)
		{
			this.method_80(string_6);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00055D9C File Offset: 0x00053F9C
		[DebuggerStepThrough]
		internal void method_21()
		{
			this.method_73();
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00055DB0 File Offset: 0x00053FB0
		internal void method_22(bool bool_8)
		{
			this.method_52(bool_8);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00055DC4 File Offset: 0x00053FC4
		internal void method_23(int int_1)
		{
			this.method_7(int_1);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00055DD8 File Offset: 0x00053FD8
		internal void method_24(bool bool_8)
		{
			GClass115.gclass115_0.bool_1 = bool_8;
			GClass115.smethod_4();
			this.bool_5 = bool_8;
			if (GClass84.gclass93_0.method_88())
			{
				if (bool_8)
				{
					this.method_11();
				}
				else
				{
					this.method_68();
				}
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00055E1C File Offset: 0x0005401C
		internal void method_25()
		{
			this.method_34();
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00055E30 File Offset: 0x00054030
		internal void method_26(string string_6)
		{
			this.method_41(string_6);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00055E44 File Offset: 0x00054044
		internal void method_27()
		{
			string text = GClass84.smethod_1645();
			if (!string.IsNullOrEmpty(text))
			{
				string text2;
				if (this.bool_6)
				{
					text2 = "AddBot";
				}
				else
				{
					text2 = "AddUser";
				}
				this.string_5 = GClass84.smethod_979();
				this.method_75(string.Concat(new string[]
				{
					"[] {",
					text2,
					"(",
					GClass84.smethod_828(GClass84.smethod_1372(), ""),
					",",
					text,
					",",
					this.string_2,
					":",
					this.int_0.ToString(),
					",",
					this.string_5,
					");}"
				}));
				if (this.bool_7)
				{
					Thread.Sleep((int)(this.float_0 * 1000f));
					bool flag = false;
					object obj = this.object_0;
					lock (obj)
					{
						if (this.thread_0 == null)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.method_25();
					}
				}
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00055F74 File Offset: 0x00054174
		internal void method_28()
		{
			if (this.bool_5)
			{
				if (this.string_5 != GClass84.smethod_979())
				{
					this.method_11();
				}
				if (GClass84.gclass93_0.method_88())
				{
				}
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00055FB4 File Offset: 0x000541B4
		internal void method_29(bool bool_8)
		{
			this.method_36(bool_8);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00055FC8 File Offset: 0x000541C8
		private string method_30()
		{
			return this.method_5();
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00055FDC File Offset: 0x000541DC
		public override void vmethod_10()
		{
			this.method_64();
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00055FF0 File Offset: 0x000541F0
		internal void method_31()
		{
			if (!this.bool_4)
			{
				if (this.bool_3)
				{
					APIUser apiuser = GClass84.smethod_1372();
					if (apiuser != null && apiuser.id != string.Empty)
					{
						this.method_70();
						this.bool_4 = true;
					}
				}
				else
				{
					this.bool_4 = true;
				}
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00056044 File Offset: 0x00054244
		internal void method_32()
		{
			Thread thread = new Thread(new ThreadStart(this.method_21));
			thread.Start();
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0005606C File Offset: 0x0005426C
		internal void method_33()
		{
			this.method_77();
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00056080 File Offset: 0x00054280
		internal void method_34()
		{
			this.method_69();
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00056094 File Offset: 0x00054294
		public override void vmethod_22()
		{
			this.method_74();
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000560A8 File Offset: 0x000542A8
		internal void method_35()
		{
			GClass152.Class93 @class = new GClass152.Class93();
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.gclass152_0 = this;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0.Start<GClass152.Class93>(ref @class);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000560E4 File Offset: 0x000542E4
		internal void method_36(bool bool_8)
		{
			this.method_24(bool_8);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000560F8 File Offset: 0x000542F8
		internal void method_37()
		{
			this.method_81();
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0005610C File Offset: 0x0005430C
		private string method_38()
		{
			string text = this.string_3;
			if (this.string_4 != string.Empty)
			{
				text = text + "/" + this.string_4;
			}
			if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
			{
				text = "http" + "://" + text;
			}
			return text;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00056180 File Offset: 0x00054380
		internal void method_39(GClass152.GEnum45 genum45_1)
		{
			this.method_43(genum45_1);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00056194 File Offset: 0x00054394
		internal void method_40(object object_1)
		{
			this.method_16(object_1);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00056254 File Offset: 0x00054454
		internal void method_41(string string_6)
		{
			this.method_62(string_6);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00056268 File Offset: 0x00054468
		internal void method_42(object object_1)
		{
			this.method_56("Command" + ":" + " " + ((object_1 != null) ? object_1.ToString() : null));
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0005629C File Offset: 0x0005449C
		internal void method_43(GClass152.GEnum45 genum45_1)
		{
			this.method_18(genum45_1);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000562B0 File Offset: 0x000544B0
		internal void method_44()
		{
			this.method_65();
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000562C4 File Offset: 0x000544C4
		internal void method_45()
		{
			this.method_66();
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000562D8 File Offset: 0x000544D8
		internal void method_46(string string_6)
		{
			this.method_78(string_6);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000562EC File Offset: 0x000544EC
		internal void method_47(bool bool_8)
		{
			this.method_22(bool_8);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00056300 File Offset: 0x00054500
		internal void method_48()
		{
			this.method_4();
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00056314 File Offset: 0x00054514
		internal void method_49(bool bool_8)
		{
			this.method_61(bool_8);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00056328 File Offset: 0x00054528
		internal bool method_50(string string_6, Action action_0 = null, Action action_1 = null, Action action_2 = null)
		{
			bool result;
			if (!this.bool_5)
			{
				if (action_2 != null)
				{
					action_2();
				}
				result = false;
			}
			else
			{
				try
				{
					string text = this.method_30();
					WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
					{
						text,
						"/",
						"Get",
						"Instance",
						"ID",
						"(",
						string_6,
						");"
					}));
					WebResponse response = webRequest.GetResponse();
					string text2 = string.Empty;
					using (Stream responseStream = response.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							text2 = streamReader.ReadToEnd();
						}
					}
					response.Close();
					if (GClass84.smethod_1428(text2, GClass84.smethod_593("wrld_")) == "wrld_")
					{
						if (action_0 != null)
						{
							action_0();
						}
						GClass84.smethod_704(text2);
						return true;
					}
					if (GClass84.smethod_362(text2) == GClass84.smethod_362(string.Empty))
					{
						if (action_1 != null)
						{
							action_1();
						}
					}
					else if (GClass84.smethod_362(text2) == GClass84.smethod_362("error") && action_2 != null)
					{
						action_2();
					}
				}
				catch
				{
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000564CC File Offset: 0x000546CC
		internal void method_51()
		{
			this.method_9();
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000564E0 File Offset: 0x000546E0
		internal void method_52(bool bool_8)
		{
			GClass115.gclass115_0.bool_2 = bool_8;
			GClass115.smethod_4();
			this.bool_6 = bool_8;
			if (GClass84.gclass93_0.method_88())
			{
				this.method_11();
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00056518 File Offset: 0x00054718
		internal void method_53()
		{
			this.method_10();
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0005652C File Offset: 0x0005472C
		internal void method_54(string string_6)
		{
			this.method_14(string_6);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00056540 File Offset: 0x00054740
		internal void method_55()
		{
			this.method_45();
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00056554 File Offset: 0x00054754
		[DebuggerStepThrough]
		internal void method_56(object object_1)
		{
			this.method_40(object_1);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00056568 File Offset: 0x00054768
		internal void method_57(string string_6)
		{
			this.method_75(string_6);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0005657C File Offset: 0x0005477C
		internal void method_58()
		{
			object obj = this.object_0;
			lock (obj)
			{
				if (this.thread_0 != null)
				{
					this.thread_0.Abort();
				}
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x000565CC File Offset: 0x000547CC
		internal void method_59(string string_6)
		{
			this.method_46(string_6);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x000565E0 File Offset: 0x000547E0
		internal void method_60(object object_1)
		{
			this.method_42(object_1);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x000565F4 File Offset: 0x000547F4
		internal void method_61(bool bool_8)
		{
			GClass115.gclass115_0.bool_0 = bool_8;
			GClass115.smethod_4();
			this.bool_3 = bool_8;
			if (bool_8)
			{
				this.method_70();
			}
			else
			{
				this.method_4();
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0005662C File Offset: 0x0005482C
		internal void method_62(string string_6)
		{
			GClass115.gclass115_0.string_1 = string_6;
			GClass115.smethod_4();
			this.string_3 = string_6;
			if (GClass84.gclass93_0.method_88())
			{
				this.method_11();
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00056664 File Offset: 0x00054864
		internal void method_63()
		{
			this.method_67();
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00056678 File Offset: 0x00054878
		internal void method_64()
		{
			this.method_28();
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0005668C File Offset: 0x0005488C
		internal void method_65()
		{
			this.method_17();
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x000566A0 File Offset: 0x000548A0
		public override void vmethod_19()
		{
			this.method_79();
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x000566B4 File Offset: 0x000548B4
		internal void method_66()
		{
			string text;
			if (this.bool_6)
			{
				text = "RemoveBot";
			}
			else
			{
				text = "RemoveUser";
			}
			this.method_75(string.Concat(new string[]
			{
				"[] {",
				text,
				"(",
				GClass84.smethod_1645(),
				");}"
			}));
			if (this.bool_7)
			{
				this.method_51();
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0005671C File Offset: 0x0005491C
		internal void method_67()
		{
			if (GClass84.gclass93_0.method_88())
			{
				this.method_68();
			}
			GClass84.gclass93_0.method_23();
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00056748 File Offset: 0x00054948
		internal void method_68()
		{
			this.method_2();
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0005675C File Offset: 0x0005495C
		internal void method_69()
		{
			this.method_51();
			object obj = this.object_0;
			lock (obj)
			{
				this.thread_0 = new Thread(new ThreadStart(this.method_53));
				this.thread_0.Start();
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000567C0 File Offset: 0x000549C0
		internal void method_70()
		{
			this.method_3();
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000567D4 File Offset: 0x000549D4
		internal void method_71()
		{
			if (!GClass84.gclass93_0.method_88())
			{
				APIUser apiuser = GClass84.smethod_1372();
				if (apiuser != null && !(apiuser.id == string.Empty))
				{
					GClass84.gclass93_0.method_220(this.int_0);
					if (this.string_2 == string.Empty)
					{
						this.string_2 = GClass84.smethod_221(false);
						GClass70.smethod_38("Got IP!", GClass70.Enum1.const_0);
					}
					if (this.bool_5)
					{
						this.method_11();
					}
					else
					{
						string statusDescription = apiuser.statusDescription;
						string text = string.Empty;
						try
						{
							if (statusDescription != string.Empty)
							{
								if (this.bool_1)
								{
									if (this.string_1 != string.Empty)
									{
										text = Class186.smethod_9(statusDescription, this.string_1, this.bool_2);
									}
									else
									{
										text = Class186.smethod_21(statusDescription);
									}
								}
								else
								{
									text = statusDescription;
								}
							}
						}
						catch
						{
							text = string.Empty;
						}
						string text2 = this.string_2 + ":" + this.int_0.ToString();
						if (text != text2)
						{
							GClass70.smethod_38(text + "!=" + text2, GClass70.Enum1.const_0);
							GClass70.smethod_38(text, GClass70.Enum1.const_0);
							GClass70.smethod_38(text2, GClass70.Enum1.const_0);
							try
							{
								if (this.bool_1)
								{
									if (this.string_1 != string.Empty)
									{
										text = Class186.smethod_11(text2, this.string_1, this.bool_2);
									}
									else
									{
										text = Class186.smethod_23(text2);
									}
								}
								else
								{
									text = text2;
								}
								GClass70.smethod_38("Updating Status...", GClass70.Enum1.const_0);
								throw new Exception("Fix Required!");
							}
							catch (Exception ex)
							{
								GClass70.smethod_38(string.Concat(new string[]
								{
									"Can",
									"'",
									"t",
									" ",
									"Update",
									" ",
									"Status",
									"!",
									" ",
									ex.Message
								}), GClass70.Enum1.const_0);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000569F0 File Offset: 0x00054BF0
		internal void method_72()
		{
			this.method_44();
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00056A04 File Offset: 0x00054C04
		internal void method_73()
		{
			this.method_35();
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00056A18 File Offset: 0x00054C18
		internal void method_74()
		{
			this.method_48();
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00056A2C File Offset: 0x00054C2C
		internal void method_75(object object_1)
		{
			this.method_60(object_1);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00056A40 File Offset: 0x00054C40
		internal void method_76(int int_1)
		{
			GClass115.gclass115_0.int_0 = int_1;
			GClass115.smethod_4();
			this.int_0 = int_1;
			this.method_4();
			if (this.bool_3)
			{
				this.method_70();
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00056A78 File Offset: 0x00054C78
		internal void method_77()
		{
			this.method_32();
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00056A8C File Offset: 0x00054C8C
		internal void method_78(string string_6)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(this.method_56));
			thread.Start(string_6);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00056AB4 File Offset: 0x00054CB4
		internal void method_79()
		{
			this.method_31();
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00056AC8 File Offset: 0x00054CC8
		internal void method_80(string string_6)
		{
			GClass115.gclass115_0.string_2 = string_6;
			GClass115.smethod_4();
			this.string_4 = string_6;
			if (GClass84.gclass93_0.method_88())
			{
				this.method_11();
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00056B00 File Offset: 0x00054D00
		internal void method_81()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_11.Add(new Action(this.vmethod_22));
			GClass84.list_15.Add(new Action<string, List<string>>(this.vmethod_17));
			GClass115.smethod_0();
			this.bool_3 = GClass115.gclass115_0.bool_0;
			this.int_0 = GClass115.gclass115_0.int_0;
			this.bool_5 = GClass115.gclass115_0.bool_1;
			this.string_3 = GClass115.gclass115_0.string_1;
			this.string_4 = GClass115.gclass115_0.string_2;
			this.bool_6 = GClass115.gclass115_0.bool_2;
			this.method_39(this.genum45_0);
		}

		// Token: 0x04000BDC RID: 3036
		internal bool bool_0 = true;

		// Token: 0x04000BDD RID: 3037
		internal GClass152.GEnum45 genum45_0 = GClass152.GEnum45.const_10;

		// Token: 0x04000BDE RID: 3038
		internal bool bool_1 = true;

		// Token: 0x04000BDF RID: 3039
		internal string string_1 = "3";

		// Token: 0x04000BE0 RID: 3040
		internal bool bool_2 = false;

		// Token: 0x04000BE1 RID: 3041
		internal bool bool_3 = false;

		// Token: 0x04000BE2 RID: 3042
		internal int int_0 = 30651;

		// Token: 0x04000BE3 RID: 3043
		internal string string_2 = string.Empty;

		// Token: 0x04000BE4 RID: 3044
		internal bool bool_4 = false;

		// Token: 0x04000BE5 RID: 3045
		internal bool bool_5 = false;

		// Token: 0x04000BE6 RID: 3046
		internal string string_3 = string.Empty;

		// Token: 0x04000BE7 RID: 3047
		internal string string_4 = string.Empty;

		// Token: 0x04000BE8 RID: 3048
		internal bool bool_6 = false;

		// Token: 0x04000BE9 RID: 3049
		internal string string_5 = string.Empty;

		// Token: 0x04000BEA RID: 3050
		internal bool bool_7 = false;

		// Token: 0x04000BEB RID: 3051
		internal float float_0 = 1f;

		// Token: 0x04000BEC RID: 3052
		private object object_0 = new object();

		// Token: 0x04000BED RID: 3053
		private Thread thread_0;

		// Token: 0x020001AD RID: 429
		public enum GEnum45
		{
			// Token: 0x04000BEF RID: 3055
			const_0,
			// Token: 0x04000BF0 RID: 3056
			const_1,
			// Token: 0x04000BF1 RID: 3057
			const_2,
			// Token: 0x04000BF2 RID: 3058
			const_3,
			// Token: 0x04000BF3 RID: 3059
			const_4,
			// Token: 0x04000BF4 RID: 3060
			const_5,
			// Token: 0x04000BF5 RID: 3061
			const_6,
			// Token: 0x04000BF6 RID: 3062
			const_7,
			// Token: 0x04000BF7 RID: 3063
			const_8,
			// Token: 0x04000BF8 RID: 3064
			const_9,
			// Token: 0x04000BF9 RID: 3065
			const_10
		}
	}
}
