using System;
using System.Collections.Generic;
using ns245;

namespace ns254
{
	// Token: 0x02000260 RID: 608
	internal class Class137 : Class128
	{
		// Token: 0x06001C66 RID: 7270 RVA: 0x0008E9FC File Offset: 0x0008CBFC
		internal bool method_0(string string_13, object object_0)
		{
			if (string_13 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_13 == "location")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_13 == "instanceId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_13 == "name")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_13 == "worldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_13 == "type")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_13 == "ownerId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_13 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_13 == "active")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_13 == "full")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_1 = (bool)object_0;
					return true;
				}
				this.bool_1 = false;
			}
			else if (string_13 == "n_users")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_13 == "capacity")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_1 = (double)object_0;
					return true;
				}
				this.double_1 = 0.0;
			}
			else if (string_13 == "platforms")
			{
				if (Class137.Class158.smethod_0(object_0, out this.class158_0))
				{
					return true;
				}
				this.class158_0 = null;
			}
			else if (string_13 == "shortName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_13 == "world")
			{
				if (Class137.Class157.smethod_0(object_0, out this.class157_0))
				{
					return true;
				}
				this.class157_0 = null;
			}
			else if (string_13 == "users")
			{
				List<object> list = object_0 as List<object>;
				if (list != null)
				{
					this.list_1 = new List<Class137.Class156>();
					foreach (object object_ in list)
					{
						Class137.Class156 item;
						if (!Class137.Class156.smethod_0(object_, out item))
						{
							return false;
						}
						this.list_1.Add(item);
					}
					return true;
				}
				this.list_1 = null;
			}
			else if (string_13 == "nonce")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_13 == "clientNumber")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_13 == "photonRegion")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_13 == "region")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			else if (string_13 == "canRequestInvite")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_2 = (bool)object_0;
					return true;
				}
				this.bool_2 = false;
			}
			else if (string_13 == "permanent")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_3 = (bool)object_0;
					return true;
				}
				this.bool_3 = false;
			}
			else if (string_13 == "private")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_12 = (string)object_0;
					return true;
				}
				this.string_12 = string.Empty;
			}
			return false;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0008F074 File Offset: 0x0008D274
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0008F08C File Offset: 0x0008D28C
		internal static bool smethod_0(object object_0, out Class137 class137_0)
		{
			bool result;
			if (object_0 == null)
			{
				class137_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class137_0 = new Class137();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class137_0.method_0(text, dictionary[text]))
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
					class137_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04001081 RID: 4225
		internal string string_0 = string.Empty;

		// Token: 0x04001082 RID: 4226
		internal string string_1 = string.Empty;

		// Token: 0x04001083 RID: 4227
		internal string string_2 = string.Empty;

		// Token: 0x04001084 RID: 4228
		internal string string_3 = string.Empty;

		// Token: 0x04001085 RID: 4229
		internal string string_4 = string.Empty;

		// Token: 0x04001086 RID: 4230
		internal string string_5 = string.Empty;

		// Token: 0x04001087 RID: 4231
		internal string string_6 = string.Empty;

		// Token: 0x04001088 RID: 4232
		internal List<object> list_0 = new List<object>();

		// Token: 0x04001089 RID: 4233
		internal bool bool_0 = false;

		// Token: 0x0400108A RID: 4234
		internal bool bool_1 = false;

		// Token: 0x0400108B RID: 4235
		internal double double_0 = 0.0;

		// Token: 0x0400108C RID: 4236
		internal double double_1 = 0.0;

		// Token: 0x0400108D RID: 4237
		public Class137.Class158 class158_0 = new Class137.Class158();

		// Token: 0x0400108E RID: 4238
		internal string string_7 = string.Empty;

		// Token: 0x0400108F RID: 4239
		public Class137.Class157 class157_0 = new Class137.Class157();

		// Token: 0x04001090 RID: 4240
		internal List<Class137.Class156> list_1 = new List<Class137.Class156>();

		// Token: 0x04001091 RID: 4241
		internal string string_8 = string.Empty;

		// Token: 0x04001092 RID: 4242
		internal string string_9 = string.Empty;

		// Token: 0x04001093 RID: 4243
		internal string string_10 = string.Empty;

		// Token: 0x04001094 RID: 4244
		internal string string_11 = string.Empty;

		// Token: 0x04001095 RID: 4245
		internal bool bool_2 = false;

		// Token: 0x04001096 RID: 4246
		internal bool bool_3 = false;

		// Token: 0x04001097 RID: 4247
		internal string string_12 = string.Empty;

		// Token: 0x02000261 RID: 609
		internal class Class156
		{
			// Token: 0x06001C6B RID: 7275 RVA: 0x0008F2DC File Offset: 0x0008D4DC
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
				else if (string_11 == "username")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_11 == "displayName")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				else if (string_11 == "currentAvatarImageUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_3 = (string)object_0;
						return true;
					}
					this.string_3 = string.Empty;
				}
				else if (string_11 == "currentAvatarThumbnailImageUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_4 = (string)object_0;
						return true;
					}
					this.string_4 = string.Empty;
				}
				else if (string_11 == "fallbackAvatar")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_5 = (string)object_0;
						return true;
					}
					this.string_5 = string.Empty;
				}
				else if (string_11 == "userIcon")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_6 = (string)object_0;
						return true;
					}
					this.string_6 = string.Empty;
				}
				else if (string_11 == "profilePicOverride")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_7 = (string)object_0;
						return true;
					}
					this.string_7 = string.Empty;
				}
				else if (string_11 == "last_platform")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_8 = (string)object_0;
						return true;
					}
					this.string_8 = string.Empty;
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
				else if (string_11 == "developerType")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_9 = (string)object_0;
						return true;
					}
					this.string_9 = string.Empty;
				}
				else if (string_11 == "statusDescription")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_10 = (string)object_0;
						return true;
					}
					this.string_10 = string.Empty;
				}
				else if (string_11 == "isFriend")
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

			// Token: 0x06001C6C RID: 7276 RVA: 0x0008F674 File Offset: 0x0008D874
			internal static bool smethod_0(object object_0, out Class137.Class156 class156_0)
			{
				bool result;
				if (object_0 == null)
				{
					class156_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class156_0 = new Class137.Class156();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class156_0.method_0(text, dictionary[text]))
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
						class156_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x04001098 RID: 4248
			internal string string_0 = string.Empty;

			// Token: 0x04001099 RID: 4249
			internal string string_1 = string.Empty;

			// Token: 0x0400109A RID: 4250
			internal string string_2 = string.Empty;

			// Token: 0x0400109B RID: 4251
			internal string string_3 = string.Empty;

			// Token: 0x0400109C RID: 4252
			internal string string_4 = string.Empty;

			// Token: 0x0400109D RID: 4253
			internal string string_5 = string.Empty;

			// Token: 0x0400109E RID: 4254
			internal string string_6 = string.Empty;

			// Token: 0x0400109F RID: 4255
			internal string string_7 = string.Empty;

			// Token: 0x040010A0 RID: 4256
			internal string string_8 = string.Empty;

			// Token: 0x040010A1 RID: 4257
			internal List<object> list_0 = new List<object>();

			// Token: 0x040010A2 RID: 4258
			internal string string_9 = string.Empty;

			// Token: 0x040010A3 RID: 4259
			internal string string_10 = string.Empty;

			// Token: 0x040010A4 RID: 4260
			internal bool bool_0 = false;
		}

		// Token: 0x02000262 RID: 610
		internal class Class157
		{
			// Token: 0x06001C6D RID: 7277 RVA: 0x0008F71C File Offset: 0x0008D91C
			internal static bool smethod_0(object object_0, out Class137.Class157 class157_0)
			{
				bool result;
				if (object_0 == null)
				{
					class157_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class157_0 = new Class137.Class157();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class157_0.method_0(text, dictionary[text]))
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
						class157_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x0008F7C4 File Offset: 0x0008D9C4
			internal bool method_0(string string_10, object object_0)
			{
				if (string_10 == "id")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_0 = (string)object_0;
						return true;
					}
					this.string_0 = string.Empty;
				}
				else if (string_10 == "name")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_1 = (string)object_0;
						return true;
					}
					this.string_1 = string.Empty;
				}
				else if (string_10 == "description")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_2 = (string)object_0;
						return true;
					}
					this.string_2 = string.Empty;
				}
				else if (string_10 == "authorId")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_3 = (string)object_0;
						return true;
					}
					this.string_3 = string.Empty;
				}
				else if (string_10 == "authorName")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_4 = (string)object_0;
						return true;
					}
					this.string_4 = string.Empty;
				}
				else if (string_10 == "capacity")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_10 == "imageUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_5 = (string)object_0;
						return true;
					}
					this.string_5 = string.Empty;
				}
				else if (string_10 == "thumbnailImageUrl")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_6 = (string)object_0;
						return true;
					}
					this.string_6 = string.Empty;
				}
				else if (string_10 == "releaseStatus")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_7 = (string)object_0;
						return true;
					}
					this.string_7 = string.Empty;
				}
				else if (string_10 == "version")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_1 = (double)object_0;
						return true;
					}
					this.double_1 = 0.0;
				}
				else if (string_10 == "tags")
				{
					if (object_0.GetType() == typeof(List<object>))
					{
						this.list_0 = (List<object>)object_0;
						return true;
					}
					this.list_0 = new List<object>();
				}
				else if (string_10 == "created_at")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_8 = (string)object_0;
						return true;
					}
					this.string_8 = string.Empty;
				}
				else if (string_10 == "updated_at")
				{
					if (object_0.GetType() == typeof(string))
					{
						this.string_9 = (string)object_0;
						return true;
					}
					this.string_9 = string.Empty;
				}
				return false;
			}

			// Token: 0x040010A5 RID: 4261
			internal string string_0 = string.Empty;

			// Token: 0x040010A6 RID: 4262
			internal string string_1 = string.Empty;

			// Token: 0x040010A7 RID: 4263
			internal string string_2 = string.Empty;

			// Token: 0x040010A8 RID: 4264
			internal string string_3 = string.Empty;

			// Token: 0x040010A9 RID: 4265
			internal string string_4 = string.Empty;

			// Token: 0x040010AA RID: 4266
			internal double double_0 = 0.0;

			// Token: 0x040010AB RID: 4267
			internal string string_5 = string.Empty;

			// Token: 0x040010AC RID: 4268
			internal string string_6 = string.Empty;

			// Token: 0x040010AD RID: 4269
			internal string string_7 = string.Empty;

			// Token: 0x040010AE RID: 4270
			internal double double_1 = 0.0;

			// Token: 0x040010AF RID: 4271
			internal List<object> list_0 = new List<object>();

			// Token: 0x040010B0 RID: 4272
			internal string string_8 = string.Empty;

			// Token: 0x040010B1 RID: 4273
			internal string string_9 = string.Empty;
		}

		// Token: 0x02000263 RID: 611
		internal class Class158
		{
			// Token: 0x06001C70 RID: 7280 RVA: 0x0008FC18 File Offset: 0x0008DE18
			internal static bool smethod_0(object object_0, out Class137.Class158 class158_0)
			{
				bool result;
				if (object_0 == null)
				{
					class158_0 = null;
					result = false;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class158_0 = new Class137.Class158();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class158_0.method_0(text, dictionary[text]))
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
						class158_0 = null;
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06001C72 RID: 7282 RVA: 0x0008FCF4 File Offset: 0x0008DEF4
			internal bool method_0(string string_0, object object_0)
			{
				if (string_0 == "standalonewindows")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_0 = (double)object_0;
						return true;
					}
					this.double_0 = 0.0;
				}
				else if (string_0 == "android")
				{
					if (object_0.GetType() == typeof(double))
					{
						this.double_1 = (double)object_0;
						return true;
					}
					this.double_1 = 0.0;
				}
				return false;
			}

			// Token: 0x040010B2 RID: 4274
			internal double double_0 = 0.0;

			// Token: 0x040010B3 RID: 4275
			internal double double_1 = 0.0;
		}
	}
}
