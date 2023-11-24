using System;
using System.Collections.Generic;
using Il2CppSystem.Collections.Generic;
using ns185;
using ns241;
using ns425;
using UnityEngine;
using VRC.SDKBase;

namespace ns481
{
	// Token: 0x02000377 RID: 887
	public class GClass184 : GClass130
	{
		// Token: 0x06004904 RID: 18692 RVA: 0x001143D8 File Offset: 0x001125D8
		internal void method_2()
		{
			this.method_35();
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x001143EC File Offset: 0x001125EC
		internal void method_3()
		{
			this.method_42();
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00114400 File Offset: 0x00112600
		internal void method_4(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00114414 File Offset: 0x00112614
		internal bool method_5(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				List<GameObject> list = GClass84.smethod_1185(gameObject_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].name == this.string_2)
					{
						Object.Destroy(list[i]);
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x0011447C File Offset: 0x0011267C
		internal void method_6(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_31(gameObject_0, string_3, bool_2);
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x00114494 File Offset: 0x00112694
		internal void method_7()
		{
			this.method_3();
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x001144A8 File Offset: 0x001126A8
		internal void method_8(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_30(vrcplayerApi_0);
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x001144BC File Offset: 0x001126BC
		public override void vmethod_23()
		{
			this.method_26();
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x001144D0 File Offset: 0x001126D0
		internal void method_9(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_41(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001144E8 File Offset: 0x001126E8
		internal void method_10(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_38(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00114500 File Offset: 0x00112700
		internal void method_11(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null && !vrcplayerApi_0.isLocal)
			{
				GameObject gameObject = vrcplayerApi_0.gameObject;
				if (gameObject)
				{
					GameObject gameObject2 = GClass84.smethod_969(vrcplayerApi_0);
					GameObject gameObject3 = GClass84.smethod_945(vrcplayerApi_0);
					GameObject gameObject4 = GClass84.smethod_1355(vrcplayerApi_0);
					if (gameObject2 && this.method_25(gameObject2))
					{
						this.method_24(gameObject2, vrcplayerApi_0.displayName, true);
					}
					if (gameObject3 && this.method_25(gameObject3))
					{
						this.method_24(gameObject3, vrcplayerApi_0.displayName, false);
					}
					if (gameObject4 && this.method_25(gameObject4))
					{
						this.method_24(gameObject4, vrcplayerApi_0.displayName, false);
					}
				}
			}
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x001145A8 File Offset: 0x001127A8
		internal void method_12(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_14(vrcplayerApi_0);
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x001145BC File Offset: 0x001127BC
		internal void method_13(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00114608 File Offset: 0x00112808
		internal void method_14(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_18(vrcplayerApi_0);
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x0011461C File Offset: 0x0011281C
		internal void method_15(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && !this.method_40(gameObject_0))
			{
				new GameObject
				{
					transform = 
					{
						parent = gameObject_0.transform
					},
					name = this.string_1
				}.SetActive(false);
				List<DynamicBone> list = GClass84.smethod_928(gameObject_0);
				if (list != null && list.Count > 0)
				{
					List<DynamicBoneCollider> list2 = GClass84.smethod_1110(GClass84.smethod_1476());
					if (list2 != null && list2.Count > 0)
					{
						for (int i = list.Count - 1; i >= 0; i--)
						{
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								list[i].m_Colliders.Add(list2[j]);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001146FC File Offset: 0x001128FC
		internal void method_16(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_6(gameObject_0, string_3, bool_2);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00114714 File Offset: 0x00112914
		internal void method_17(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_29(gameObject_0, string_3, bool_2);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0011472C File Offset: 0x0011292C
		internal void method_18(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null && !vrcplayerApi_0.isLocal)
			{
				GameObject gameObject = vrcplayerApi_0.gameObject;
				if (gameObject)
				{
					GameObject gameObject2 = GClass84.smethod_969(vrcplayerApi_0);
					GameObject gameObject3 = GClass84.smethod_945(vrcplayerApi_0);
					GameObject gameObject4 = GClass84.smethod_1355(vrcplayerApi_0);
					if (gameObject2 && !this.method_40(gameObject2))
					{
						this.method_10(gameObject2, vrcplayerApi_0.displayName, true);
					}
					if (gameObject3 && !this.method_40(gameObject3))
					{
						this.method_10(gameObject3, vrcplayerApi_0.displayName, false);
					}
					if (gameObject4 && !this.method_40(gameObject4))
					{
						this.method_10(gameObject4, vrcplayerApi_0.displayName, false);
					}
				}
			}
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x001147DC File Offset: 0x001129DC
		internal void method_19(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_27(vrcplayerApi_0);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001147F0 File Offset: 0x001129F0
		internal void method_20(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && this.method_25(gameObject_0))
			{
				List<DynamicBone> list = GClass84.smethod_928(GClass84.smethod_1476());
				if (list != null && list.Count > 0)
				{
					List<DynamicBoneCollider> list2 = GClass84.smethod_1110(gameObject_0);
					if (list2 != null && list2.Count > 0)
					{
						for (int i = list.Count - 1; i >= 0; i--)
						{
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								list[i].m_Colliders.Remove(list2[j]);
							}
						}
						this.method_5(gameObject_0);
					}
				}
			}
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x001148B0 File Offset: 0x00112AB0
		internal void method_21(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_44(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x001148C8 File Offset: 0x00112AC8
		internal void method_22(bool bool_2)
		{
			this.method_34(bool_2);
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x001148DC File Offset: 0x00112ADC
		internal void method_23(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_47(vrcplayerApi_0);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x001148F0 File Offset: 0x00112AF0
		internal void method_24(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_45(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x00114908 File Offset: 0x00112B08
		internal bool method_25(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				List<GameObject> list = GClass84.smethod_1185(gameObject_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].name == this.string_2)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00114964 File Offset: 0x00112B64
		internal void method_26()
		{
			this.method_48();
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00114978 File Offset: 0x00112B78
		internal void method_27(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_36(vrcplayerApi_0);
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x0011498C File Offset: 0x00112B8C
		public override void vmethod_10()
		{
			this.method_2();
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x001149A0 File Offset: 0x00112BA0
		internal void method_28(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null && !vrcplayerApi_0.isLocal)
			{
				GameObject gameObject = vrcplayerApi_0.gameObject;
				if (gameObject)
				{
					GameObject gameObject2 = GClass84.smethod_969(vrcplayerApi_0);
					GameObject gameObject3 = GClass84.smethod_945(vrcplayerApi_0);
					GameObject gameObject4 = GClass84.smethod_1355(vrcplayerApi_0);
					if (gameObject2 && !this.method_25(gameObject2))
					{
						this.method_39(gameObject2, vrcplayerApi_0.displayName, true);
					}
					if (gameObject3 && !this.method_25(gameObject3))
					{
						this.method_39(gameObject3, vrcplayerApi_0.displayName, false);
					}
					if (gameObject4 && !this.method_25(gameObject4))
					{
						this.method_39(gameObject4, vrcplayerApi_0.displayName, false);
					}
				}
			}
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00114A50 File Offset: 0x00112C50
		internal void method_29(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_43(gameObject_0, string_3, bool_2);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00114A68 File Offset: 0x00112C68
		internal void method_30(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_28(vrcplayerApi_0);
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00114A7C File Offset: 0x00112C7C
		internal void method_31(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && !this.method_40(gameObject_0))
			{
				this.method_10(gameObject_0, string_3, bool_2);
			}
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00114AA8 File Offset: 0x00112CA8
		internal void method_32(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && !this.method_25(gameObject_0))
			{
				this.method_39(gameObject_0, string_3, bool_2);
			}
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00114AD4 File Offset: 0x00112CD4
		internal void method_33(bool bool_2)
		{
			this.method_46(bool_2);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00114AE8 File Offset: 0x00112CE8
		internal void method_34(bool bool_2)
		{
			this.method_13(bool_2);
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00114AFC File Offset: 0x00112CFC
		internal void method_35()
		{
			if (this.bool_0 || this.bool_1)
			{
				try
				{
					this.method_7();
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00114B44 File Offset: 0x00112D44
		internal void method_36(VRCPlayerApi vrcplayerApi_0)
		{
			if (vrcplayerApi_0 != null && !vrcplayerApi_0.isLocal)
			{
				GameObject gameObject = vrcplayerApi_0.gameObject;
				if (gameObject)
				{
					GameObject gameObject2 = GClass84.smethod_969(vrcplayerApi_0);
					GameObject gameObject3 = GClass84.smethod_945(vrcplayerApi_0);
					GameObject gameObject4 = GClass84.smethod_1355(vrcplayerApi_0);
					if (gameObject2 && this.method_40(gameObject2))
					{
						this.method_17(gameObject2, vrcplayerApi_0.displayName, true);
					}
					if (gameObject3 && this.method_40(gameObject3))
					{
						this.method_17(gameObject3, vrcplayerApi_0.displayName, false);
					}
					if (gameObject4 && this.method_40(gameObject4))
					{
						this.method_17(gameObject4, vrcplayerApi_0.displayName, false);
					}
				}
			}
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00114BEC File Offset: 0x00112DEC
		internal bool method_37(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				List<GameObject> list = GClass84.smethod_1185(gameObject_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].name == this.string_1)
					{
						Object.Destroy(list[i]);
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00114C54 File Offset: 0x00112E54
		internal void method_38(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_15(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00114C6C File Offset: 0x00112E6C
		internal void method_39(GameObject gameObject_0, string string_3, bool bool_2 = false)
		{
			this.method_21(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00114C84 File Offset: 0x00112E84
		internal bool method_40(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				List<GameObject> list = GClass84.smethod_1185(gameObject_0);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					if (list[i].name == this.string_1)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00114CE0 File Offset: 0x00112EE0
		internal void method_41(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_32(gameObject_0, string_3, bool_2);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00114CF8 File Offset: 0x00112EF8
		internal void method_42()
		{
			List<VRCPlayerApi> list = GClass84.smethod_1584();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (!list[i].isLocal)
				{
					GameObject gameObject = list[i].gameObject;
					if (gameObject)
					{
						GameObject gameObject2 = GClass84.smethod_969(list[i]);
						GameObject gameObject3 = GClass84.smethod_945(list[i]);
						GameObject gameObject4 = GClass84.smethod_1355(list[i]);
						if (gameObject2)
						{
							if (this.bool_0 && !this.method_40(gameObject2))
							{
								this.method_16(gameObject2, list[i].displayName, true);
							}
							if (this.bool_1 && !this.method_25(gameObject2))
							{
								this.method_9(gameObject2, list[i].displayName, true);
							}
						}
						if (gameObject3)
						{
							if (this.bool_0 && !this.method_40(gameObject3))
							{
								this.method_16(gameObject3, list[i].displayName, false);
							}
							if (this.bool_1 && !this.method_25(gameObject3))
							{
								this.method_9(gameObject3, list[i].displayName, false);
							}
						}
						if (gameObject4)
						{
							if (this.bool_0 && !this.method_40(gameObject4))
							{
								this.method_16(gameObject4, list[i].displayName, false);
							}
							if (this.bool_1 && !this.method_25(gameObject4))
							{
								this.method_9(gameObject4, list[i].displayName, false);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00114EA4 File Offset: 0x001130A4
		internal void method_43(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && this.method_40(gameObject_0))
			{
				List<DynamicBone> list = GClass84.smethod_928(gameObject_0);
				if (list != null && list.Count > 0)
				{
					List<DynamicBoneCollider> list2 = GClass84.smethod_1110(GClass84.smethod_1476());
					if (list2 != null && list2.Count > 0)
					{
						for (int i = list.Count - 1; i >= 0; i--)
						{
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								list[i].m_Colliders.Remove(list2[j]);
							}
						}
						this.method_37(gameObject_0);
					}
				}
			}
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00114F64 File Offset: 0x00113164
		internal void method_44(GameObject gameObject_0, string string_3, bool bool_2)
		{
			if (gameObject_0 && !this.method_25(gameObject_0))
			{
				new GameObject
				{
					transform = 
					{
						parent = gameObject_0.transform
					},
					name = this.string_2
				}.SetActive(false);
				List<DynamicBone> list = GClass84.smethod_928(GClass84.smethod_1476());
				if (list != null && list.Count > 0)
				{
					List<DynamicBoneCollider> list2 = GClass84.smethod_1110(gameObject_0);
					if (list2 != null && list2.Count > 0)
					{
						for (int i = list.Count - 1; i >= 0; i--)
						{
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								list[i].m_Colliders.Add(list2[j]);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00115044 File Offset: 0x00113244
		internal void method_45(GameObject gameObject_0, string string_3, bool bool_2)
		{
			this.method_20(gameObject_0, string_3, bool_2);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0011505C File Offset: 0x0011325C
		internal void method_46(bool bool_2)
		{
			this.method_4(bool_2);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00115070 File Offset: 0x00113270
		internal void method_47(VRCPlayerApi vrcplayerApi_0)
		{
			this.method_11(vrcplayerApi_0);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00115084 File Offset: 0x00113284
		internal void method_48()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
		}

		// Token: 0x04001C39 RID: 7225
		internal string string_1 = "TouchIsEnabledAlready_";

		// Token: 0x04001C3A RID: 7226
		internal string string_2 = "TouchMeIsEnabledAlready_";

		// Token: 0x04001C3B RID: 7227
		internal bool bool_0 = false;

		// Token: 0x04001C3C RID: 7228
		internal bool bool_1 = false;
	}
}
