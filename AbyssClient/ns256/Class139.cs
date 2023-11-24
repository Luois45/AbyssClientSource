using System;
using System.Collections.Generic;
using ns245;

namespace ns256
{
	// Token: 0x0200032C RID: 812
	internal class Class139 : Class128
	{
		// Token: 0x060041BB RID: 16827 RVA: 0x000F9F20 File Offset: 0x000F8120
		internal static bool smethod_0(object object_0, out Class139 class139_0)
		{
			bool result;
			if (object_0 == null)
			{
				class139_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class139_0 = new Class139();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class139_0.method_0(text, dictionary[text]))
							{
								return false;
							}
						}
						catch
						{
							return false;
						}
					}
					result = true;
				}
				else
				{
					class139_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x000F9FC8 File Offset: 0x000F81C8
		internal override object vmethod_0()
		{
			return this.double_0;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000F9FE4 File Offset: 0x000F81E4
		internal bool method_0(string string_1, object object_0)
		{
			if (string_1 == "version")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_1 == "token")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			return false;
		}

		// Token: 0x040019A7 RID: 6567
		internal double double_0 = 0.0;

		// Token: 0x040019A8 RID: 6568
		internal string string_0 = string.Empty;
	}
}
