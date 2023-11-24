using System;
using ns185;
using ns241;
using ns268;
using ns441;
using UnityEngine;

namespace ns519
{
	// Token: 0x02000386 RID: 902
	public class GClass191
	{
		// Token: 0x060049DA RID: 18906 RVA: 0x00119004 File Offset: 0x00117204
		internal static void smethod_0(ref Object object_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0, bool bool_1, bool bool_2, ref Object object_1)
		{
			GClass191.smethod_1(ref object_0, vector3_0, quaternion_0, bool_0, bool_1, bool_2, ref object_1);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00119028 File Offset: 0x00117228
		internal static void smethod_1(ref Object object_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0, bool bool_1, bool bool_2, ref Object object_1)
		{
			GClass191.smethod_2(ref object_0, vector3_0, quaternion_0, bool_0, bool_1, bool_2, ref object_1);
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x0011904C File Offset: 0x0011724C
		internal static void smethod_2(ref Object object_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0, bool bool_1, bool bool_2, ref Object object_1)
		{
			if (object_0 && object_1)
			{
				GameObject gameObject;
				GameObject gameObject2;
				try
				{
					gameObject = object_0.TryCast<GameObject>();
					gameObject2 = object_1.TryCast<GameObject>();
				}
				catch
				{
					return;
				}
				if (gameObject && gameObject2)
				{
					GClass84.gclass93_0.method_193(gameObject2, gameObject);
					if (!(GClass145.Struct8.vrcavatarManager_0 == null) || GClass84.gclass145_0.bool_12 || GClass84.gclass145_0.bool_13)
					{
						string text = GClass84.smethod_1324(gameObject2);
						if (GClass145.Struct8.vrcavatarManager_0 != null && (!GClass84.gclass145_0.bool_13 || text != "AvatarUiPrefab2(Clone)"))
						{
							VRCAvatarManager vrcavatarManager_ = GClass145.Struct8.vrcavatarManager_0;
							VRCPlayer field_Private_VRCPlayer_ = vrcavatarManager_.field_Private_VRCPlayer_0;
							if (field_Private_VRCPlayer_ == null)
							{
								return;
							}
						}
						try
						{
							if (text == "AvatarPrefab(Clone)" || (GClass84.smethod_1428(text, GClass84.smethod_593("prefab-id-")) == "prefab-id-" && GClass84.smethod_1611(text, "_avtr_") != -1))
							{
								GClass90.smethod_0(GClass145.Struct8.vrcavatarManager_0, gameObject2, GClass145.Struct8.vrcavatarManager_0 == null, gameObject);
							}
						}
						catch (Exception ex)
						{
							string[] array = new string[10];
							array[0] = "Exception";
							array[1] = " ";
							array[2] = "when";
							array[3] = " ";
							array[4] = "Post";
							array[5] = "Checking";
							array[6] = " ";
							array[7] = "avatar";
							array[8] = ": ";
							int num = 9;
							Exception ex2 = ex;
							array[num] = ((ex2 != null) ? ex2.ToString() : null);
							GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
						}
					}
				}
			}
		}
	}
}
