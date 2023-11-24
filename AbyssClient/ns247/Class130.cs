using System;
using System.Collections.Generic;
using ns245;

namespace ns247
{
	// Token: 0x02000076 RID: 118
	internal class Class130 : Class128
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		internal static bool smethod_0(object object_0, out Class130 class130_0)
		{
			bool result;
			if (object_0 == null)
			{
				class130_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class130_0 = new Class130();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class130_0.method_0(text, dictionary[text]))
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
					class130_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000EE9C File Offset: 0x0000D09C
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		internal bool method_0(string string_1, object object_0)
		{
			if (string_1 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_1 == "metadata")
			{
				if (Class130.Class15.smethod_0(object_0, out this.class15_0))
				{
					return true;
				}
				this.class15_0 = null;
			}
			return false;
		}

		// Token: 0x0400028D RID: 653
		internal string string_0 = string.Empty;

		// Token: 0x0400028E RID: 654
		public Class130.Class15 class15_0 = new Class130.Class15();

		// Token: 0x02000077 RID: 119
		internal class Class15
		{
			// Token: 0x0600043C RID: 1084 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0000EF58 File Offset: 0x0000D158
			internal static bool smethod_0(object object_0, out Class130.Class15 class15_0)
			{
				bool result;
				if (object_0 == null)
				{
					class15_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class15_0 = new Class130.Class15();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class15_0.method_0(text, dictionary[text]))
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
						class15_0 = null;
						result = false;
					}
				}
				return result;
			}
		}
	}
}
