using System;
using System.Collections.Generic;
using ns245;

namespace ns257
{
	// Token: 0x0200033E RID: 830
	internal class Class140 : Class128
	{
		// Token: 0x060046BC RID: 18108 RVA: 0x001090FC File Offset: 0x001072FC
		internal static bool smethod_0(object object_0, out Class140 class140_0)
		{
			bool result;
			if (object_0 == null)
			{
				class140_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class140_0 = new Class140();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class140_0.method_0(text, dictionary[text]))
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
					class140_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x001091A4 File Offset: 0x001073A4
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x001091BC File Offset: 0x001073BC
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
			else if (string_7 == "type")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_7 == "sourceUserId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_7 == "sourceDisplayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_7 == "targetUserId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_7 == "targetDisplayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_7 == "created")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			return false;
		}

		// Token: 0x04001AE6 RID: 6886
		internal string string_0 = string.Empty;

		// Token: 0x04001AE7 RID: 6887
		internal string string_1 = string.Empty;

		// Token: 0x04001AE8 RID: 6888
		internal string string_2 = string.Empty;

		// Token: 0x04001AE9 RID: 6889
		internal string string_3 = string.Empty;

		// Token: 0x04001AEA RID: 6890
		internal string string_4 = string.Empty;

		// Token: 0x04001AEB RID: 6891
		internal string string_5 = string.Empty;

		// Token: 0x04001AEC RID: 6892
		internal string string_6 = string.Empty;
	}
}
