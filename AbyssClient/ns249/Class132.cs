using System;
using System.Collections.Generic;
using ns245;

namespace ns249
{
	// Token: 0x0200008A RID: 138
	internal class Class132 : Class128
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x00010AFC File Offset: 0x0000ECFC
		internal static bool smethod_0(object object_0, out Class132 class132_0)
		{
			bool result;
			if (object_0 == null)
			{
				class132_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class132_0 = new Class132();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class132_0.method_0(text, dictionary[text]))
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
					class132_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		internal bool method_0(string string_5, object object_0)
		{
			if (string_5 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_5 == "name")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_5 == "ownerId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_5 == "mimeType")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_5 == "extension")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_5 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_5 == "versions")
			{
				List<object> list = object_0 as List<object>;
				if (list != null)
				{
					this.list_1 = new List<Class132.Class20>();
					foreach (object object_ in list)
					{
						Class132.Class20 item;
						if (!Class132.Class20.smethod_0(object_, out item))
						{
							return false;
						}
						this.list_1.Add(item);
					}
					return true;
				}
				this.list_1 = null;
			}
			return false;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00010E48 File Offset: 0x0000F048
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x040002ED RID: 749
		internal string string_0 = string.Empty;

		// Token: 0x040002EE RID: 750
		internal string string_1 = string.Empty;

		// Token: 0x040002EF RID: 751
		internal string string_2 = string.Empty;

		// Token: 0x040002F0 RID: 752
		internal string string_3 = string.Empty;

		// Token: 0x040002F1 RID: 753
		internal string string_4 = string.Empty;

		// Token: 0x040002F2 RID: 754
		internal List<object> list_0 = new List<object>();

		// Token: 0x040002F3 RID: 755
		internal List<Class132.Class20> list_1 = new List<Class132.Class20>();

		// Token: 0x0200008B RID: 139
		internal class Class20
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x00010E60 File Offset: 0x0000F060
			internal bool method_0(string string_2, object object_0)
			{
				if (string_2 == "version")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_2 == "status")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_2 == "created_at")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_2 == "deleted")
				{
					if (object_0.GetType() == typeof(bool))
					{
						this.bool_0 = (bool)object_0;
						return true;
					}
					this.bool_0 = false;
				}
				else if (string_2 == "file")
				{
					if (Class132.Class20.Class21.smethod_0(object_0, out this.class21_0))
					{
						return true;
					}
					this.class21_0 = null;
				}
				else if (string_2 == "delta")
				{
					if (Class132.Class20.Class21.smethod_0(object_0, out this.class21_1))
					{
						return true;
					}
					this.class21_1 = null;
				}
				else if (string_2 == "signature")
				{
					if (Class132.Class20.Class21.smethod_0(object_0, out this.class21_2))
					{
						return true;
					}
					this.class21_2 = null;
				}
				return false;
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00011000 File Offset: 0x0000F200
			internal static bool smethod_0(object object_0, out Class132.Class20 class20_0)
			{
				bool result;
				if (object_0 == null)
				{
					class20_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class20_0 = new Class132.Class20();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class20_0.method_0(text, dictionary[text]))
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
						class20_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x040002F4 RID: 756
			internal double double_0 = 0.0;

			// Token: 0x040002F5 RID: 757
			internal string string_0 = string.Empty;

			// Token: 0x040002F6 RID: 758
			internal string string_1 = string.Empty;

			// Token: 0x040002F7 RID: 759
			internal bool bool_0 = false;

			// Token: 0x040002F8 RID: 760
			internal Class132.Class20.Class21 class21_0 = null;

			// Token: 0x040002F9 RID: 761
			internal Class132.Class20.Class21 class21_1 = null;

			// Token: 0x040002FA RID: 762
			internal Class132.Class20.Class21 class21_2 = null;

			// Token: 0x0200008C RID: 140
			internal class Class21
			{
				// Token: 0x0600049F RID: 1183 RVA: 0x000110FC File Offset: 0x0000F2FC
				internal bool method_0(string string_6, object object_0)
				{
					if (string_6 == "fileName")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_0 = (string)object_0;
							return true;
						}
						this.string_0 = string.Empty;
					}
					else if (string_6 == "url")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_1 = (string)object_0;
							return true;
						}
						this.string_1 = string.Empty;
					}
					else if (string_6 == "md5")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_2 = string.Empty;
							return true;
						}
						this.string_2 = string.Empty;
					}
					else if (string_6 == "sizeInBytes")
					{
						if (object_0.GetType() == typeof(double))
						{
							this.double_0 = (double)object_0;
							return true;
						}
						this.double_0 = 0.0;
					}
					else if (string_6 == "status")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_3 = (string)object_0;
							return true;
						}
						this.string_3 = string.Empty;
					}
					else if (string_6 == "category")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_4 = (string)object_0;
							return true;
						}
						this.string_4 = string.Empty;
					}
					else if (string_6 == "uploadId")
					{
						if (object_0.GetType() == typeof(string))
						{
							this.string_5 = (string)object_0;
							return true;
						}
						this.string_5 = string.Empty;
					}
					return false;
				}

				// Token: 0x060004A0 RID: 1184 RVA: 0x000112F4 File Offset: 0x0000F4F4
				internal static bool smethod_0(object object_0, out Class132.Class20.Class21 class21_0)
				{
					bool result;
					if (object_0 == null)
					{
						class21_0 = null;
						result = false;
					}
					else
					{
						Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
						if (dictionary != null)
						{
							class21_0 = new Class132.Class20.Class21();
							foreach (string text in dictionary.Keys)
							{
								try
								{
									if (!class21_0.method_0(text, dictionary[text]))
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
							class21_0 = null;
							result = false;
						}
					}
					return result;
				}

				// Token: 0x040002FB RID: 763
				internal string string_0 = string.Empty;

				// Token: 0x040002FC RID: 764
				internal string string_1 = string.Empty;

				// Token: 0x040002FD RID: 765
				internal string string_2 = string.Empty;

				// Token: 0x040002FE RID: 766
				internal double double_0 = 0.0;

				// Token: 0x040002FF RID: 767
				internal string string_3 = string.Empty;

				// Token: 0x04000300 RID: 768
				internal string string_4 = string.Empty;

				// Token: 0x04000301 RID: 769
				internal string string_5 = string.Empty;
			}
		}
	}
}
