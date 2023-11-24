using System;
using System.Collections.Generic;
using ns245;

namespace ns248
{
	// Token: 0x0200007D RID: 125
	internal class Class131 : Class128
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0000F000 File Offset: 0x0000D200
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000F018 File Offset: 0x0000D218
		internal static bool smethod_0(object object_0, out Class131 class131_0)
		{
			bool result;
			if (object_0 == null)
			{
				class131_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class131_0 = new Class131();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class131_0.method_0(text, dictionary[text]))
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
					class131_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		internal bool method_0(string string_12, object object_0)
		{
			if (string_12 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_12 == "name")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_12 == "description")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_12 == "authorId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_12 == "authorName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_12 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_12 == "assetUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_12 == "assetUrlObject")
			{
				if (Class131.Class16.smethod_0(object_0, out this.class16_0))
				{
					return true;
				}
				this.class16_0 = null;
			}
			else if (string_12 == "imageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_12 == "thumbnailImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_12 == "releaseStatus")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_12 == "version")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_12 == "featured")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_12 == "unityPackages")
			{
				List<object> list = object_0 as List<object>;
				if (list != null)
				{
					this.list_1 = new List<Class131.Class17>();
					foreach (object object_ in list)
					{
						Class131.Class17 item;
						if (!Class131.Class17.smethod_0(object_, out item))
						{
							return false;
						}
						this.list_1.Add(item);
					}
					return true;
				}
				this.list_1 = null;
			}
			else if (string_12 == "unityPackageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_12 == "unityPackageUrlObject")
			{
				if (Class131.Class19.smethod_0(object_0, out this.class19_0))
				{
					return true;
				}
				this.class19_0 = null;
			}
			else if (string_12 == "created_at")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_12 == "updated_at")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			return false;
		}

		// Token: 0x040002B7 RID: 695
		internal string string_0 = string.Empty;

		// Token: 0x040002B8 RID: 696
		internal string string_1 = string.Empty;

		// Token: 0x040002B9 RID: 697
		internal string string_2 = string.Empty;

		// Token: 0x040002BA RID: 698
		internal string string_3 = string.Empty;

		// Token: 0x040002BB RID: 699
		internal string string_4 = string.Empty;

		// Token: 0x040002BC RID: 700
		internal List<object> list_0 = new List<object>();

		// Token: 0x040002BD RID: 701
		internal string string_5 = string.Empty;

		// Token: 0x040002BE RID: 702
		public Class131.Class16 class16_0 = new Class131.Class16();

		// Token: 0x040002BF RID: 703
		internal string string_6 = string.Empty;

		// Token: 0x040002C0 RID: 704
		internal string string_7 = string.Empty;

		// Token: 0x040002C1 RID: 705
		internal string string_8 = string.Empty;

		// Token: 0x040002C2 RID: 706
		internal double double_0 = 0.0;

		// Token: 0x040002C3 RID: 707
		internal bool bool_0 = false;

		// Token: 0x040002C4 RID: 708
		internal List<Class131.Class17> list_1 = new List<Class131.Class17>();

		// Token: 0x040002C5 RID: 709
		internal string string_9 = string.Empty;

		// Token: 0x040002C6 RID: 710
		public Class131.Class19 class19_0 = new Class131.Class19();

		// Token: 0x040002C7 RID: 711
		internal string string_10 = string.Empty;

		// Token: 0x040002C8 RID: 712
		internal string string_11 = string.Empty;

		// Token: 0x0200007E RID: 126
		internal class Class16
		{
			// Token: 0x06000443 RID: 1091 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x0000F6BC File Offset: 0x0000D8BC
			internal static bool smethod_0(object object_0, out Class131.Class16 class16_0)
			{
				bool result;
				if (object_0 == null)
				{
					class16_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class16_0 = new Class131.Class16();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class16_0.method_0(text, dictionary[text]))
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
						class16_0 = null;
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x0200007F RID: 127
		internal class Class17
		{
			// Token: 0x06000446 RID: 1094 RVA: 0x0000F764 File Offset: 0x0000D964
			internal static bool smethod_0(object object_0, out Class131.Class17 class17_0)
			{
				bool result;
				if (object_0 == null)
				{
					class17_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class17_0 = new Class131.Class17();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class17_0.method_0(text, dictionary[text]))
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
						class17_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x0000F80C File Offset: 0x0000DA0C
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
				else if (string_5 == "assetUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_5 == "unityVersion")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				else if (string_5 == "unitySortNumber")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_5 == "assetVersion")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_1 = (double)object_0;
						return true;
					}
					this.double_1 = 0.0;
				}
				else if (string_5 == "platform")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_3 = (string)object_0;
						return true;
					}
					this.string_3 = string.Empty;
				}
				else if (string_5 == "created_at")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_4 = (string)object_0;
						return true;
					}
					this.string_4 = string.Empty;
				}
				else if (string_5 == "assetUrlObject")
				{
					if (Class131.Class17.Class18.smethod_0(object_0, out this.class18_0))
					{
						return true;
					}
					this.class18_0 = null;
				}
				return false;
			}

			// Token: 0x040002C9 RID: 713
			internal string string_0 = string.Empty;

			// Token: 0x040002CA RID: 714
			internal string string_1 = string.Empty;

			// Token: 0x040002CB RID: 715
			public Class131.Class17.Class18 class18_0 = new Class131.Class17.Class18();

			// Token: 0x040002CC RID: 716
			internal string string_2 = string.Empty;

			// Token: 0x040002CD RID: 717
			internal double double_0 = 0.0;

			// Token: 0x040002CE RID: 718
			internal double double_1 = 0.0;

			// Token: 0x040002CF RID: 719
			internal string string_3 = string.Empty;

			// Token: 0x040002D0 RID: 720
			internal string string_4 = string.Empty;

			// Token: 0x02000080 RID: 128
			internal class Class18
			{
				// Token: 0x06000449 RID: 1097 RVA: 0x0000D820 File Offset: 0x0000BA20
				internal bool method_0(string string_0, object object_0)
				{
					return false;
				}

				// Token: 0x0600044A RID: 1098 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
				internal static bool smethod_0(object object_0, out Class131.Class17.Class18 class18_0)
				{
					bool result;
					if (object_0 == null)
					{
						class18_0 = null;
						result = true;
					}
					else
					{
						Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
						if (dictionary != null)
						{
							class18_0 = new Class131.Class17.Class18();
							foreach (string text in dictionary.Keys)
							{
								try
								{
									if (!class18_0.method_0(text, dictionary[text]))
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
							class18_0 = null;
							result = false;
						}
					}
					return result;
				}
			}
		}

		// Token: 0x02000081 RID: 129
		internal class Class19
		{
			// Token: 0x0600044C RID: 1100 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x0000FB4C File Offset: 0x0000DD4C
			internal static bool smethod_0(object object_0, out Class131.Class19 class19_0)
			{
				bool result;
				if (object_0 == null)
				{
					class19_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class19_0 = new Class131.Class19();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class19_0.method_0(text, dictionary[text]))
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
						class19_0 = null;
						result = false;
					}
				}
				return result;
			}
		}
	}
}
