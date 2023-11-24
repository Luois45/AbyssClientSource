using System;
using System.Collections.Generic;
using ns245;

namespace ns251
{
	// Token: 0x0200021A RID: 538
	internal class Class134 : Class128
	{
		// Token: 0x060018AE RID: 6318 RVA: 0x0007F400 File Offset: 0x0007D600
		internal bool method_0(string string_11, object object_0)
		{
			if (string_11 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_11 == "type")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_11 == "reason")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_11 == "commenterId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_11 == "commenterName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_11 == "contentId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_11 == "contentType")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_11 == "contentVersion")
			{
				if (object_0 == null)
				{
					this.string_7 = string.Empty;
					return true;
				}
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_11 == "contentName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_11 == "contentAuthorId")
			{
				if (object_0 == null)
				{
					this.string_9 = string.Empty;
					return true;
				}
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_11 == "contentAuthorName")
			{
				if (object_0 == null)
				{
					this.string_10 = string.Empty;
					return true;
				}
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_11 == "tags")
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

		// Token: 0x060018AF RID: 6319 RVA: 0x0007F79C File Offset: 0x0007D99C
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007F7B4 File Offset: 0x0007D9B4
		internal static bool smethod_0(object object_0, out Class134 class134_0)
		{
			bool result;
			if (object_0 == null)
			{
				class134_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class134_0 = new Class134();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class134_0.method_0(text, dictionary[text]))
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
					class134_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000E64 RID: 3684
		internal string string_0 = string.Empty;

		// Token: 0x04000E65 RID: 3685
		internal string string_1 = string.Empty;

		// Token: 0x04000E66 RID: 3686
		internal string string_2 = string.Empty;

		// Token: 0x04000E67 RID: 3687
		internal string string_3 = string.Empty;

		// Token: 0x04000E68 RID: 3688
		internal string string_4 = string.Empty;

		// Token: 0x04000E69 RID: 3689
		internal string string_5 = string.Empty;

		// Token: 0x04000E6A RID: 3690
		internal string string_6 = string.Empty;

		// Token: 0x04000E6B RID: 3691
		internal string string_7 = string.Empty;

		// Token: 0x04000E6C RID: 3692
		internal string string_8 = string.Empty;

		// Token: 0x04000E6D RID: 3693
		internal string string_9 = string.Empty;

		// Token: 0x04000E6E RID: 3694
		internal string string_10 = string.Empty;

		// Token: 0x04000E6F RID: 3695
		internal List<object> list_0 = new List<object>();
	}
}
