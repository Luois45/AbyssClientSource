using System;
using System.Collections.Generic;
using ns245;

namespace ns250
{
	// Token: 0x02000120 RID: 288
	internal class Class133 : Class128
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x00028710 File Offset: 0x00026910
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00028728 File Offset: 0x00026928
		internal bool method_0(string string_7, object object_0)
		{
			if (string_7 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_7 == "ownerId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_7 == "ownerDisplayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_7 == "name")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_7 == "displayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_7 == "type")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_7 == "visibility")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_7 == "tags")
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

		// Token: 0x060009AC RID: 2476 RVA: 0x00028964 File Offset: 0x00026B64
		internal static bool smethod_0(object object_0, out Class133 class133_0)
		{
			bool result;
			if (object_0 == null)
			{
				class133_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class133_0 = new Class133();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class133_0.method_0(text, dictionary[text]))
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
					class133_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0400072B RID: 1835
		internal string string_0 = string.Empty;

		// Token: 0x0400072C RID: 1836
		internal string string_1 = string.Empty;

		// Token: 0x0400072D RID: 1837
		internal string string_2 = string.Empty;

		// Token: 0x0400072E RID: 1838
		internal string string_3 = string.Empty;

		// Token: 0x0400072F RID: 1839
		internal string string_4 = string.Empty;

		// Token: 0x04000730 RID: 1840
		internal string string_5 = string.Empty;

		// Token: 0x04000731 RID: 1841
		internal string string_6 = string.Empty;

		// Token: 0x04000732 RID: 1842
		internal List<object> list_0 = new List<object>();
	}
}
