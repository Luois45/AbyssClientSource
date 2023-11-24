using System;
using System.Windows.Forms;
using ns185;
using ns241;
using ns425;

namespace ns453
{
	// Token: 0x020002A1 RID: 673
	public class GClass157 : GClass130
	{
		// Token: 0x06001F4F RID: 8015 RVA: 0x000A2618 File Offset: 0x000A0818
		internal void method_2(string string_1)
		{
			this.method_6(string_1);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000A262C File Offset: 0x000A082C
		internal void method_3()
		{
			try
			{
				if (!Clipboard.ContainsText())
				{
					GClass70.smethod_38("!Clipboard.ContainsText()", GClass70.Enum1.const_0);
				}
				else
				{
					string text = Clipboard.GetText();
					if (text == null)
					{
						GClass70.smethod_38("ID Is Null!", GClass70.Enum1.const_0);
					}
					else
					{
						this.method_2(text);
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Exception",
					" ",
					"While",
					" ",
					"Set",
					"Pedestals",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000A26D8 File Offset: 0x000A08D8
		internal void method_4()
		{
			this.method_5();
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000A26EC File Offset: 0x000A08EC
		internal void method_5()
		{
			this.method_3();
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x000A2700 File Offset: 0x000A0900
		internal void method_6(string string_1)
		{
			this.method_7(string_1);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000A2714 File Offset: 0x000A0914
		internal void method_7(string string_1)
		{
			if (string_1 == null)
			{
				GClass70.smethod_38("ID Is Null!", GClass70.Enum1.const_0);
			}
			else
			{
				GClass84.smethod_1277(string_1);
			}
		}
	}
}
