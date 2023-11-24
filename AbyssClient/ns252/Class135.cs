using System;
using System.Collections.Generic;
using ns245;

namespace ns252
{
	// Token: 0x02000245 RID: 581
	internal class Class135 : Class128
	{
		// Token: 0x06001B41 RID: 6977 RVA: 0x00089AEC File Offset: 0x00087CEC
		internal override object vmethod_0()
		{
			return this.string_0;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00089B04 File Offset: 0x00087D04
		internal bool method_0(string string_27, object object_0)
		{
			if (string_27 == "id")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_0 = (string)object_0;
					return true;
				}
				this.string_0 = string.Empty;
			}
			else if (string_27 == "username")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_1 = (string)object_0;
					return true;
				}
				this.string_1 = string.Empty;
			}
			else if (string_27 == "displayName")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_2 = (string)object_0;
					return true;
				}
				this.string_2 = string.Empty;
			}
			else if (string_27 == "bio")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_3 = (string)object_0;
					return true;
				}
				this.string_3 = string.Empty;
			}
			else if (string_27 == "bioLinks")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_0 = (List<object>)object_0;
					return true;
				}
				this.list_0 = new List<object>();
			}
			else if (string_27 == "profilePicOverride")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_4 = (string)object_0;
					return true;
				}
				this.string_4 = string.Empty;
			}
			else if (string_27 == "statusDescription")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_5 = (string)object_0;
					return true;
				}
				this.string_5 = string.Empty;
			}
			else if (string_27 == "pastDisplayNames")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_1 = (List<object>)object_0;
					return true;
				}
				this.list_1 = new List<object>();
			}
			else if (string_27 == "hasEmail")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_0 = (bool)object_0;
					return true;
				}
				this.bool_0 = false;
			}
			else if (string_27 == "hasPendingEmail")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_1 = (bool)object_0;
					return true;
				}
				this.bool_1 = false;
			}
			else if (string_27 == "obfuscatedEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_6 = (string)object_0;
					return true;
				}
				this.string_6 = string.Empty;
			}
			else if (string_27 == "obfuscatedPendingEmail")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_7 = (string)object_0;
					return true;
				}
				this.string_7 = string.Empty;
			}
			else if (string_27 == "emailVerified")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_2 = (bool)object_0;
					return true;
				}
				this.bool_2 = false;
			}
			else if (string_27 == "hasBirthday")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_3 = (bool)object_0;
					return true;
				}
				this.bool_3 = false;
			}
			else if (string_27 == "unsubscribe")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_4 = (bool)object_0;
					return true;
				}
				this.bool_4 = false;
			}
			else if (string_27 == "statusHistory")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_2 = (List<object>)object_0;
					return true;
				}
				this.list_2 = new List<object>();
			}
			else if (string_27 == "statusFirstTime")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_5 = (bool)object_0;
					return true;
				}
				this.bool_5 = false;
			}
			else if (string_27 == "friends")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_3 = (List<object>)object_0;
					return true;
				}
				this.list_3 = new List<object>();
			}
			else if (string_27 == "friendGroupNames")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_4 = (List<object>)object_0;
					return true;
				}
				this.list_4 = new List<object>();
			}
			else if (string_27 == "currentAvatarImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_8 = (string)object_0;
					return true;
				}
				this.string_8 = string.Empty;
			}
			else if (string_27 == "currentAvatarThumbnailImageUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_9 = (string)object_0;
					return true;
				}
				this.string_9 = string.Empty;
			}
			else if (string_27 == "fallbackAvatar")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_10 = (string)object_0;
					return true;
				}
				this.string_10 = string.Empty;
			}
			else if (string_27 == "currentAvatar")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_11 = (string)object_0;
					return true;
				}
				this.string_11 = string.Empty;
			}
			else if (string_27 == "currentAvatarAssetUrl")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_12 = (string)object_0;
					return true;
				}
				this.string_12 = string.Empty;
			}
			else if (string_27 == "accountDeletionDate")
			{
				if (Class135.Class149.smethod_0(object_0, out this.class149_0))
				{
					return true;
				}
				this.class149_0 = null;
			}
			else if (string_27 == "acceptedTOSVersion")
			{
				if (object_0.GetType() == typeof(double))
				{
					this.double_0 = (double)object_0;
					return true;
				}
				this.double_0 = 0.0;
			}
			else if (string_27 == "steamId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_13 = (string)object_0;
					return true;
				}
				this.string_13 = string.Empty;
			}
			else if (string_27 == "steamDetails")
			{
				if (Class135.Class150.smethod_0(object_0, out this.class150_0))
				{
					return true;
				}
				this.class150_0 = null;
			}
			else if (string_27 == "oculusId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_14 = (string)object_0;
					return true;
				}
				this.string_14 = string.Empty;
			}
			else if (string_27 == "hasLoggedInFromClient")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_6 = (bool)object_0;
					return true;
				}
				this.bool_6 = false;
			}
			else if (string_27 == "homeLocation")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_15 = (string)object_0;
					return true;
				}
				this.string_15 = string.Empty;
			}
			else if (string_27 == "twoFactorAuthEnabled")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_7 = (bool)object_0;
					return true;
				}
				this.bool_7 = false;
			}
			else if (string_27 == "state")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_16 = (string)object_0;
					return true;
				}
				this.string_16 = string.Empty;
			}
			else if (string_27 == "tags")
			{
				if (object_0.GetType() == typeof(List<object>))
				{
					this.list_5 = (List<object>)object_0;
					return true;
				}
				this.list_5 = new List<object>();
			}
			else if (string_27 == "developerType")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_17 = (string)object_0;
					return true;
				}
				this.string_17 = string.Empty;
			}
			else if (string_27 == "last_login")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_18 = (string)object_0;
					return true;
				}
				this.string_18 = string.Empty;
			}
			else if (string_27 == "last_platform")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_19 = (string)object_0;
					return true;
				}
				this.string_19 = string.Empty;
			}
			else if (string_27 == "allowAvatarCopying")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_8 = (bool)object_0;
					return true;
				}
				this.bool_8 = false;
			}
			else if (string_27 == "status")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_20 = (string)object_0;
					return true;
				}
				this.string_20 = string.Empty;
			}
			else if (string_27 == "date_joined")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_21 = (string)object_0;
					return true;
				}
				this.string_21 = string.Empty;
			}
			else if (string_27 == "isFriend")
			{
				if (object_0.GetType() == typeof(bool))
				{
					this.bool_9 = (bool)object_0;
					return true;
				}
				this.bool_9 = false;
			}
			else if (string_27 == "friendKey")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_22 = (string)object_0;
					return true;
				}
				this.string_22 = string.Empty;
			}
			else if (string_27 == "worldId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_23 = (string)object_0;
					return true;
				}
				this.string_23 = string.Empty;
			}
			else if (string_27 == "instanceId")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_24 = (string)object_0;
					return true;
				}
				this.string_24 = string.Empty;
			}
			else if (string_27 == "location")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_25 = (string)object_0;
					return true;
				}
				this.string_25 = string.Empty;
			}
			else if (string_27 == "userIcon")
			{
				if (object_0.GetType() == typeof(string))
				{
					this.string_26 = (string)object_0;
					return true;
				}
				this.string_26 = string.Empty;
			}
			return false;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0008A774 File Offset: 0x00088974
		internal static bool smethod_0(object object_0, out Class135 class135_0)
		{
			bool result;
			if (object_0 == null)
			{
				class135_0 = null;
				result = false;
			}
			else
			{
				Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
				if (dictionary != null)
				{
					class135_0 = new Class135();
					foreach (string text in dictionary.Keys)
					{
						try
						{
							if (!class135_0.method_0(text, dictionary[text]))
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
					class135_0 = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000F72 RID: 3954
		internal string string_0 = string.Empty;

		// Token: 0x04000F73 RID: 3955
		internal string string_1 = string.Empty;

		// Token: 0x04000F74 RID: 3956
		internal string string_2 = string.Empty;

		// Token: 0x04000F75 RID: 3957
		internal string string_3 = string.Empty;

		// Token: 0x04000F76 RID: 3958
		internal List<object> list_0 = new List<object>();

		// Token: 0x04000F77 RID: 3959
		internal string string_4 = string.Empty;

		// Token: 0x04000F78 RID: 3960
		internal string string_5 = string.Empty;

		// Token: 0x04000F79 RID: 3961
		internal List<object> list_1 = new List<object>();

		// Token: 0x04000F7A RID: 3962
		internal bool bool_0 = false;

		// Token: 0x04000F7B RID: 3963
		internal bool bool_1 = false;

		// Token: 0x04000F7C RID: 3964
		internal string string_6 = string.Empty;

		// Token: 0x04000F7D RID: 3965
		internal string string_7 = string.Empty;

		// Token: 0x04000F7E RID: 3966
		internal bool bool_2 = false;

		// Token: 0x04000F7F RID: 3967
		internal bool bool_3 = false;

		// Token: 0x04000F80 RID: 3968
		internal bool bool_4 = false;

		// Token: 0x04000F81 RID: 3969
		internal List<object> list_2 = new List<object>();

		// Token: 0x04000F82 RID: 3970
		internal bool bool_5 = false;

		// Token: 0x04000F83 RID: 3971
		internal List<object> list_3 = new List<object>();

		// Token: 0x04000F84 RID: 3972
		internal List<object> list_4 = new List<object>();

		// Token: 0x04000F85 RID: 3973
		internal string string_8 = string.Empty;

		// Token: 0x04000F86 RID: 3974
		internal string string_9 = string.Empty;

		// Token: 0x04000F87 RID: 3975
		internal string string_10 = string.Empty;

		// Token: 0x04000F88 RID: 3976
		internal string string_11 = string.Empty;

		// Token: 0x04000F89 RID: 3977
		internal string string_12 = string.Empty;

		// Token: 0x04000F8A RID: 3978
		public Class135.Class149 class149_0 = null;

		// Token: 0x04000F8B RID: 3979
		internal double double_0 = 0.0;

		// Token: 0x04000F8C RID: 3980
		internal string string_13 = string.Empty;

		// Token: 0x04000F8D RID: 3981
		public Class135.Class150 class150_0 = null;

		// Token: 0x04000F8E RID: 3982
		internal string string_14 = string.Empty;

		// Token: 0x04000F8F RID: 3983
		internal bool bool_6 = false;

		// Token: 0x04000F90 RID: 3984
		internal string string_15 = string.Empty;

		// Token: 0x04000F91 RID: 3985
		internal bool bool_7 = false;

		// Token: 0x04000F92 RID: 3986
		internal string string_16 = string.Empty;

		// Token: 0x04000F93 RID: 3987
		internal List<object> list_5 = new List<object>();

		// Token: 0x04000F94 RID: 3988
		internal string string_17 = string.Empty;

		// Token: 0x04000F95 RID: 3989
		internal string string_18 = string.Empty;

		// Token: 0x04000F96 RID: 3990
		internal string string_19 = string.Empty;

		// Token: 0x04000F97 RID: 3991
		internal bool bool_8 = false;

		// Token: 0x04000F98 RID: 3992
		internal string string_20 = string.Empty;

		// Token: 0x04000F99 RID: 3993
		internal string string_21 = string.Empty;

		// Token: 0x04000F9A RID: 3994
		internal bool bool_9 = false;

		// Token: 0x04000F9B RID: 3995
		internal string string_22 = string.Empty;

		// Token: 0x04000F9C RID: 3996
		internal string string_23 = string.Empty;

		// Token: 0x04000F9D RID: 3997
		internal string string_24 = string.Empty;

		// Token: 0x04000F9E RID: 3998
		internal string string_25 = string.Empty;

		// Token: 0x04000F9F RID: 3999
		internal string string_26 = string.Empty;

		// Token: 0x02000246 RID: 582
		internal class Class149
		{
			// Token: 0x06001B45 RID: 6981 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x06001B46 RID: 6982 RVA: 0x0008AA00 File Offset: 0x00088C00
			internal static bool smethod_0(object object_0, out Class135.Class149 class149_0)
			{
				bool result;
				if (object_0 == null)
				{
					class149_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class149_0 = new Class135.Class149();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class149_0.method_0(text, dictionary[text]))
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
						class149_0 = null;
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x02000247 RID: 583
		internal class Class150
		{
			// Token: 0x06001B48 RID: 6984 RVA: 0x0000D820 File Offset: 0x0000BA20
			internal bool method_0(string string_0, object object_0)
			{
				return false;
			}

			// Token: 0x06001B49 RID: 6985 RVA: 0x0008AAA8 File Offset: 0x00088CA8
			internal static bool smethod_0(object object_0, out Class135.Class150 class150_0)
			{
				bool result;
				if (object_0 == null)
				{
					class150_0 = null;
					result = true;
				}
				else
				{
					Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
					if (dictionary != null)
					{
						class150_0 = new Class135.Class150();
						foreach (string text in dictionary.Keys)
						{
							try
							{
								if (!class150_0.method_0(text, dictionary[text]))
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
						class150_0 = null;
						result = false;
					}
				}
				return result;
			}
		}
	}
}
