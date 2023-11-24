using System;
using System.Collections.Generic;
using ns245;

namespace ns260
{
	// Token: 0x020003A2 RID: 930
	internal class Class143 : Class128
	{
		// Token: 0x06004A33 RID: 18995 RVA: 0x0011AB24 File Offset: 0x00118D24
		internal bool method_0(string string_20, object object_0)
		{
			if (string_20 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_20 == "username")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_20 == "displayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_20 == "bio")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_20 == "bioLinks")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_20 == "currentAvatarImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_20 == "currentAvatarThumbnailImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_20 == "fallbackAvatar")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_20 == "userIcon")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_20 == "profilePicOverride")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_20 == "last_platform")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_20 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_1 = (List<object>)object_0;
					return true;
				}
				this.list_1 = new List<object>();
			}
			else if (string_20 == "developerType")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_20 == "status")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			else if (string_20 == "statusDescription")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_12 = (string)object_0;
					return true;
				}
				this.string_12 = string.Empty;
			}
			else if (string_20 == "date_joined")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_13 = (string)object_0;
					return true;
				}
				this.string_13 = string.Empty;
			}
			else if (string_20 == "friendKey")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_14 = (string)object_0;
					return true;
				}
				this.string_14 = string.Empty;
			}
			else if (string_20 == "last_login")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_15 = (string)object_0;
					return true;
				}
				this.string_15 = string.Empty;
			}
			else if (string_20 == "isFriend")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_20 == "allowAvatarCopying")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_1 = (bool)object_0;
					return true;
				}
				this.bool_1 = false;
			}
			else if (string_20 == "location")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_16 = (string)object_0;
					return true;
				}
				this.string_16 = string.Empty;
			}
			else if (string_20 == "worldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_17 = (string)object_0;
					return true;
				}
				this.string_17 = string.Empty;
			}
			else if (string_20 == "instanceId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_18 = (string)object_0;
					return true;
				}
				this.string_18 = string.Empty;
			}
			else if (string_20 == "state")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_19 = (string)object_0;
					return true;
				}
				this.string_19 = string.Empty;
			}
			return false;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x0011B1C8 File Offset: 0x001193C8
		internal static bool smethod_0(object object_0, out Class143 class143_0)
		{
			bool result;
			if (object_0 == null)
			{
				class143_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class143_0 = new Class143();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class143_0.method_0(text, dictionary[text]))
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
					class143_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x0011B270 File Offset: 0x00119470
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x04001D4A RID: 7498
		internal string string_0 = string.Empty;

		// Token: 0x04001D4B RID: 7499
		internal string string_1 = string.Empty;

		// Token: 0x04001D4C RID: 7500
		internal string string_2 = string.Empty;

		// Token: 0x04001D4D RID: 7501
		internal string string_3 = string.Empty;

		// Token: 0x04001D4E RID: 7502
		internal List<object> list_0 = new List<object>();

		// Token: 0x04001D4F RID: 7503
		internal string string_4 = string.Empty;

		// Token: 0x04001D50 RID: 7504
		internal string string_5 = string.Empty;

		// Token: 0x04001D51 RID: 7505
		internal string string_6 = string.Empty;

		// Token: 0x04001D52 RID: 7506
		internal string string_7 = string.Empty;

		// Token: 0x04001D53 RID: 7507
		internal string string_8 = string.Empty;

		// Token: 0x04001D54 RID: 7508
		internal string string_9 = string.Empty;

		// Token: 0x04001D55 RID: 7509
		internal List<object> list_1 = new List<object>();

		// Token: 0x04001D56 RID: 7510
		internal string string_10 = string.Empty;

		// Token: 0x04001D57 RID: 7511
		internal string string_11 = string.Empty;

		// Token: 0x04001D58 RID: 7512
		internal string string_12 = string.Empty;

		// Token: 0x04001D59 RID: 7513
		internal string string_13 = string.Empty;

		// Token: 0x04001D5A RID: 7514
		internal string string_14 = string.Empty;

		// Token: 0x04001D5B RID: 7515
		internal string string_15 = string.Empty;

		// Token: 0x04001D5C RID: 7516
		internal bool bool_0 = false;

		// Token: 0x04001D5D RID: 7517
		internal bool bool_1 = false;

		// Token: 0x04001D5E RID: 7518
		internal string string_16 = string.Empty;

		// Token: 0x04001D5F RID: 7519
		internal string string_17 = string.Empty;

		// Token: 0x04001D60 RID: 7520
		internal string string_18 = string.Empty;

		// Token: 0x04001D61 RID: 7521
		internal string string_19 = string.Empty;
	}
}
