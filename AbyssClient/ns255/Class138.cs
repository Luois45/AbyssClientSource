using System;
using System.Collections.Generic;
using ns245;

namespace ns255
{
	// Token: 0x0200026A RID: 618
	internal class Class138 : Class128
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x00090074 File Offset: 0x0008E274
		internal bool method_0(string string_3, object object_0)
		{
			if (string_3 == "error")
			{
				if (Class138.Class159.smethod_0(object_0, out this.class159_0))
				{
					return true;
				}
				this.class159_0 = null;
			}
			else if (string_3 == "target")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_3 == "reason")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_3 == "expires")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_3 == "isPermanent")
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

		// Token: 0x06001C83 RID: 7299 RVA: 0x00090204 File Offset: 0x0008E404
		internal override object vmethod_0()
		{
			return null;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00090214 File Offset: 0x0008E414
		internal static bool smethod_0(object object_0, out Class138 class138_0)
		{
			bool result;
			if (object_0 == null)
			{
				class138_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class138_0 = new Class138();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class138_0.method_0(text, dictionary[text]))
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
					class138_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x040010CF RID: 4303
		internal Class138.Class159 class159_0 = new Class138.Class159();

		// Token: 0x040010D0 RID: 4304
		internal string string_0 = string.Empty;

		// Token: 0x040010D1 RID: 4305
		internal string string_1 = string.Empty;

		// Token: 0x040010D2 RID: 4306
		internal string string_2 = string.Empty;

		// Token: 0x040010D3 RID: 4307
		internal bool bool_0 = false;

		// Token: 0x0200026B RID: 619
		internal class Class159
		{
			// Token: 0x06001C85 RID: 7301 RVA: 0x000902BC File Offset: 0x0008E4BC
			internal static bool smethod_0(object object_0, out Class138.Class159 class159_0)
			{
				bool result;
				if (object_0 == null)
				{
					class159_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class159_0 = new Class138.Class159();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class159_0.method_0(text, dictionary[text]))
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
						class159_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06001C86 RID: 7302 RVA: 0x00090364 File Offset: 0x0008E564
			internal bool method_0(string string_1, object object_0)
			{
				if (string_1 == "message")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_1 == "status_code")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				return false;
			}

			// Token: 0x040010D4 RID: 4308
			internal string string_0 = string.Empty;

			// Token: 0x040010D5 RID: 4309
			internal double double_0 = 0.0;
		}
	}
}
