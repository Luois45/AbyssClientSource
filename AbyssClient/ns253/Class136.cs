using System;
using System.Collections.Generic;
using ns245;

namespace ns253
{
	// Token: 0x0200024E RID: 590
	internal class Class136 : Class128
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x0008AC74 File Offset: 0x00088E74
		internal bool method_0(string string_3, object object_0)
		{
			if (string_3 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_3 == "type")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_3 == "favoriteId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_3 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			return false;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0008AD94 File Offset: 0x00088F94
		internal static bool smethod_0(object object_0, out Class136 class136_0)
		{
			bool result;
			if (object_0 == null)
			{
				class136_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class136_0 = new Class136();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class136_0.method_0(text, dictionary[text]))
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
					class136_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0008AE3C File Offset: 0x0008903C
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x04000FAB RID: 4011
		internal string string_0 = string.Empty;

		// Token: 0x04000FAC RID: 4012
		internal string string_1 = string.Empty;

		// Token: 0x04000FAD RID: 4013
		internal string string_2 = string.Empty;

		// Token: 0x04000FAE RID: 4014
		internal List<object> list_0 = new List<object>();
	}
}
