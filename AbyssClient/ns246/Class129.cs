using System;
using System.Collections.Generic;
using ns245;

namespace ns246
{
	// Token: 0x02000065 RID: 101
	internal class Class129 : Class128
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		internal static bool smethod_0(object object_0, out Class129 class129_0)
		{
			bool result;
			if (object_0 == null)
			{
				class129_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class129_0 = new Class129();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class129_0.method_0(text, dictionary[text]))
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
					class129_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000CD64 File Offset: 0x0000AF64
		internal bool method_0(string string_17, object object_0)
		{
			if (string_17 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_17 == "name")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_17 == "description")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_17 == "featured")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_17 == "authorId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_17 == "authorName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_17 == "capacity")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_17 == "imageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_17 == "thumbnailImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_17 == "assetUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_17 == "assetUrlObject")
			{
				if (Class129.Class8.smethod_0(object_0, out this.class8_0))
				{
					return true;
				}
				this.class8_0 = null;
			}
			else if (string_17 == "pluginUrlObject")
			{
				if (Class129.Class9.smethod_0(object_0, out this.class9_0))
				{
					return true;
				}
				this.class9_0 = null;
			}
			else if (string_17 == "unityPackageUrlObject")
			{
				if (Class129.Class10.smethod_0(object_0, out this.class10_0))
				{
					return true;
				}
				this.class10_0 = null;
			}
			else if (string_17 == "namespace")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_17 == "releaseStatus")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_17 == "version")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_1 = (double)object_0;
					return true;
				}
				this.double_1 = 0.0;
			}
			else if (string_17 == "organization")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_17 == "previewYoutubeId")
			{
				if (object_0 == null)
				{
					this.string_11 = string.Empty;
					return true;
				}
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			else if (string_17 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_17 == "favorites")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_2 = (double)object_0;
					return true;
				}
				this.double_2 = 0.0;
			}
			else if (string_17 == "created_at")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_12 = (string)object_0;
					return true;
				}
				this.string_12 = string.Empty;
			}
			else if (string_17 == "updated_at")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_13 = (string)object_0;
					return true;
				}
				this.string_13 = string.Empty;
			}
			else if (string_17 == "publicationDate")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_14 = (string)object_0;
					return true;
				}
				this.string_14 = string.Empty;
			}
			else if (string_17 == "labsPublicationDate")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_15 = (string)object_0;
					return true;
				}
				this.string_15 = string.Empty;
			}
			else if (string_17 == "visits")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_3 = (double)object_0;
					return true;
				}
				this.double_3 = 0.0;
			}
			else if (string_17 == "unityPackages")
			{
				List<object> list = object_0 as List<object>;
				if (list != null)
				{
					this.list_1 = new List<Class129.Class11>();
					foreach (object object_ in list)
					{
						Class129.Class11 item;
						if (!Class129.Class11.smethod_0(object_, out item))
						{
							return false;
						}
						this.list_1.Add(item);
					}
					return true;
				}
				this.list_1 = null;
			}
			else if (string_17 == "popularity")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_4 = (double)object_0;
					return true;
				}
				this.double_4 = 0.0;
			}
			else if (string_17 == "heat")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_5 = (double)object_0;
					return true;
				}
				this.double_5 = 0.0;
			}
			else if (string_17 == "occupants")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_6 = (double)object_0;
					return true;
				}
				this.double_6 = 0.0;
			}
			else if (string_17 == "publicOccupants")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_7 = (double)object_0;
					return true;
				}
				this.double_7 = 0.0;
			}
			else if (string_17 == "privateOccupants")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_8 = (double)object_0;
					return true;
				}
				this.double_8 = 0.0;
			}
			else if (string_17 == "instances")
			{
				if (object_0 == null)
				{
					this.list_2 = new List<List<object>>();
					return true;
				}
				List<object> list2 = object_0 as List<object>;
				if (list2 != null)
				{
					this.list_2 = new List<List<object>>();
					if (list2 != null)
					{
						foreach (object obj in list2)
						{
							List<object> list3 = obj as List<object>;
							if (list3 != null)
							{
								this.list_2.Add(list3);
							}
						}
					}
					return true;
				}
				this.list_2 = null;
			}
			else if (string_17 == "isSecure")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_1 = (bool)object_0;
					return true;
				}
				this.bool_1 = false;
			}
			else if (string_17 == "favoriteId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_16 = (string)object_0;
					return true;
				}
				this.string_16 = string.Empty;
			}
			return false;
		}

		// Token: 0x04000246 RID: 582
		internal string string_0 = string.Empty;

		// Token: 0x04000247 RID: 583
		internal string string_1 = string.Empty;

		// Token: 0x04000248 RID: 584
		internal string string_2 = string.Empty;

		// Token: 0x04000249 RID: 585
		internal bool bool_0 = false;

		// Token: 0x0400024A RID: 586
		internal string string_3 = string.Empty;

		// Token: 0x0400024B RID: 587
		internal string string_4 = string.Empty;

		// Token: 0x0400024C RID: 588
		internal double double_0 = 0.0;

		// Token: 0x0400024D RID: 589
		internal string string_5 = string.Empty;

		// Token: 0x0400024E RID: 590
		internal string string_6 = string.Empty;

		// Token: 0x0400024F RID: 591
		internal string string_7 = string.Empty;

		// Token: 0x04000250 RID: 592
		public Class129.Class8 class8_0 = new Class129.Class8();

		// Token: 0x04000251 RID: 593
		public Class129.Class9 class9_0 = new Class129.Class9();

		// Token: 0x04000252 RID: 594
		public Class129.Class10 class10_0 = new Class129.Class10();

		// Token: 0x04000253 RID: 595
		internal string string_8 = string.Empty;

		// Token: 0x04000254 RID: 596
		internal string string_9 = string.Empty;

		// Token: 0x04000255 RID: 597
		internal double double_1 = 0.0;

		// Token: 0x04000256 RID: 598
		internal string string_10 = string.Empty;

		// Token: 0x04000257 RID: 599
		internal string string_11 = string.Empty;

		// Token: 0x04000258 RID: 600
		internal List<object> list_0 = new List<object>();

		// Token: 0x04000259 RID: 601
		internal double double_2 = 0.0;

		// Token: 0x0400025A RID: 602
		internal string string_12 = string.Empty;

		// Token: 0x0400025B RID: 603
		internal string string_13 = string.Empty;

		// Token: 0x0400025C RID: 604
		internal string string_14 = string.Empty;

		// Token: 0x0400025D RID: 605
		internal string string_15 = string.Empty;

		// Token: 0x0400025E RID: 606
		internal double double_3 = 0.0;

		// Token: 0x0400025F RID: 607
		internal List<Class129.Class11> list_1 = new List<Class129.Class11>();

		// Token: 0x04000260 RID: 608
		internal double double_4 = 0.0;

		// Token: 0x04000261 RID: 609
		internal double double_5 = 0.0;

		// Token: 0x04000262 RID: 610
		internal double double_6 = 0.0;

		// Token: 0x04000263 RID: 611
		internal double double_7 = 0.0;

		// Token: 0x04000264 RID: 612
		internal double double_8 = 0.0;

		// Token: 0x04000265 RID: 613
		internal List<List<object>> list_2 = new List<List<object>>();

		// Token: 0x04000266 RID: 614
		internal bool bool_1 = false;

		// Token: 0x04000267 RID: 615
		internal string string_16 = string.Empty;

		// Token: 0x02000066 RID: 102
		internal class Class8
		{
			// Token: 0x060003DA RID: 986 RVA: 0x0000D778 File Offset: 0x0000B978
			internal static bool smethod_0(object object_0, out Class129.Class8 class8_0)
			{
				bool result;
				if (object_0 == null)
				{
					class8_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class8_0 = new Class129.Class8();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class8_0.method_0(text, dictionary[text]))
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
						class8_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}
		}

		// Token: 0x02000067 RID: 103
		internal class Class9
		{
			// Token: 0x060003DD RID: 989 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x0000D830 File Offset: 0x0000BA30
			internal static bool smethod_0(object object_0, out Class129.Class9 class9_0)
			{
				bool result;
				if (object_0 == null)
				{
					class9_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class9_0 = new Class129.Class9();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class9_0.method_0(text, dictionary[text]))
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
						class9_0 = null;
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x02000068 RID: 104
		internal class Class10
		{
			// Token: 0x060003E0 RID: 992 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			internal static bool smethod_0(object object_0, out Class129.Class10 class10_0)
			{
				bool result;
				if (object_0 == null)
				{
					class10_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class10_0 = new Class129.Class10();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class10_0.method_0(text, dictionary[text]))
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
						class10_0 = null;
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x02000069 RID: 105
		internal class Class11
		{
			// Token: 0x060003E3 RID: 995 RVA: 0x0000D980 File Offset: 0x0000BB80
			internal static bool smethod_0(object object_0, out Class129.Class11 class11_0)
			{
				bool result;
				if (object_0 == null)
				{
					class11_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class11_0 = new Class129.Class11();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class11_0.method_0(text, dictionary[text]))
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
						class11_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0000DA28 File Offset: 0x0000BC28
			internal bool method_0(string string_6, object object_0)
			{
				if (string_6 == "id")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_6 == "assetUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_6 == "assetUrlObject")
				{
					if (Class129.Class11.Class13.smethod_0(object_0, out this.class13_0))
					{
						return true;
					}
					this.class13_0 = null;
				}
				else if (string_6 == "pluginUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				else if (string_6 == "pluginUrlObject")
				{
					if (Class129.Class11.Class12.smethod_0(object_0, out this.class12_0))
					{
						return true;
					}
					this.class12_0 = null;
				}
				else if (string_6 == "unityVersion")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_3 = (string)object_0;
						return true;
					}
					this.string_3 = string.Empty;
				}
				else if (string_6 == "unitySortNumber")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_6 == "assetVersion")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_1 = (double)object_0;
						return true;
					}
					this.double_1 = 0.0;
				}
				else if (string_6 == "platform")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_4 = (string)object_0;
						return true;
					}
					this.string_4 = string.Empty;
				}
				else if (string_6 == "created_at")
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

			// Token: 0x04000268 RID: 616
			internal string string_0 = string.Empty;

			// Token: 0x04000269 RID: 617
			internal string string_1 = string.Empty;

			// Token: 0x0400026A RID: 618
			public Class129.Class11.Class13 class13_0 = new Class129.Class11.Class13();

			// Token: 0x0400026B RID: 619
			internal string string_2 = string.Empty;

			// Token: 0x0400026C RID: 620
			public Class129.Class11.Class12 class12_0 = new Class129.Class11.Class12();

			// Token: 0x0400026D RID: 621
			internal string string_3 = string.Empty;

			// Token: 0x0400026E RID: 622
			internal double double_0 = 0.0;

			// Token: 0x0400026F RID: 623
			internal double double_1 = 0.0;

			// Token: 0x04000270 RID: 624
			internal string string_4 = string.Empty;

			// Token: 0x04000271 RID: 625
			internal string string_5 = string.Empty;

			// Token: 0x0200006A RID: 106
			internal class Class12
			{
				// Token: 0x060003E6 RID: 998 RVA: 0x0000DD54 File Offset: 0x0000BF54
				internal static bool smethod_0(object object_0, out Class129.Class11.Class12 class12_0)
				{
					bool result;
					if (object_0 == null)
					{
						class12_0 = null;
						result = true;
					}
					else
					{
						Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
						if (dictionary != null)
						{
							class12_0 = new Class129.Class11.Class12();
							foreach (string text in dictionary.Keys)
							{
								try
								{
									if (!class12_0.method_0(text, dictionary[text]))
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
							class12_0 = null;
							result = false;
						}
					}
					return result;
				}

				// Token: 0x060003E7 RID: 999 RVA: 0x0000D820 File Offset: 0x0000BA20
				internal bool method_0(string string_0, object object_0)
				{
					return false;
				}
			}

			// Token: 0x0200006B RID: 107
			internal class Class13
			{
				// Token: 0x060003E9 RID: 1001 RVA: 0x0000D820 File Offset: 0x0000BA20
				internal bool method_0(string string_0, object object_0)
				{
					return false;
				}

				// Token: 0x060003EA RID: 1002 RVA: 0x0000DDFC File Offset: 0x0000BFFC
				internal static bool smethod_0(object object_0, out Class129.Class11.Class13 class13_0)
				{
					bool result;
					if (object_0 == null)
					{
						class13_0 = null;
						result = true;
					}
					else
					{
						Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
						if (dictionary != null)
						{
							class13_0 = new Class129.Class11.Class13();
							foreach (string text in dictionary.Keys)
							{
								try
								{
									if (!class13_0.method_0(text, dictionary[text]))
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
							class13_0 = null;
							result = false;
						}
					}
					return result;
				}
			}
		}
	}
}
