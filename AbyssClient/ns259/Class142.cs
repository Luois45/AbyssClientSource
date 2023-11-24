using System;
using System.Collections.Generic;
using ns245;

namespace ns259
{
	// Token: 0x02000353 RID: 851
	internal class Class142 : Class128
	{
		// Token: 0x06004758 RID: 18264 RVA: 0x0010E304 File Offset: 0x0010C504
		internal static bool smethod_0(object object_0, out Class142 class142_0)
		{
			bool result;
			if (object_0 == null)
			{
				class142_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class142_0 = new Class142();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class142_0.method_0(text, dictionary[text]))
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
					class142_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x0010E410 File Offset: 0x0010C610
		internal bool method_0(string string_4, object object_0)
		{
			if (string_4 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_4 == "slot")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_4 == "message")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_4 == "messageType")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_4 == "updatedAt")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_4 == "remainingCooldownMinutes")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_1 = (double)object_0;
					return true;
				}
				this.double_1 = 0.0;
			}
			else if (string_4 == "canbeUpdated")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			return false;
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x0010E608 File Offset: 0x0010C808
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x04001B95 RID: 7061
		internal string string_0 = string.Empty;

		// Token: 0x04001B96 RID: 7062
		internal double double_0 = 0.0;

		// Token: 0x04001B97 RID: 7063
		internal string string_1 = string.Empty;

		// Token: 0x04001B98 RID: 7064
		internal string string_2 = string.Empty;

		// Token: 0x04001B99 RID: 7065
		internal string string_3 = string.Empty;

		// Token: 0x04001B9A RID: 7066
		internal double double_1 = 0.0;

		// Token: 0x04001B9B RID: 7067
		internal bool bool_0 = false;
	}
}
