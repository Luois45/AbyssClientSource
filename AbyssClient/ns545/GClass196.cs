using System;
using ns106;
using ns185;
using ns241;
using ns268;
using ns441;
using UnityEngine;

namespace ns545
{
	// Token: 0x020003A1 RID: 929
	public class GClass196
	{
		// Token: 0x06004A31 RID: 18993 RVA: 0x0011A8A8 File Offset: 0x00118AA8
		internal static bool smethod_0(Object object_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0, bool bool_1, bool bool_2)
		{
			bool result;
			if (GClass84.gclass145_0.bool_164)
			{
				result = false;
			}
			else if (!object_0)
			{
				result = false;
			}
			else
			{
				GameObject gameObject = object_0.TryCast<GameObject>();
				if (!gameObject)
				{
					result = true;
				}
				else
				{
					try
					{
						string text = GClass84.smethod_1324(gameObject);
						if (text == "AvatarPrefab" || (GClass84.smethod_1428(text, GClass84.smethod_593("prefab-id-")) == "prefab-id-" && GClass84.smethod_1611(text, "_avtr_") != -1))
						{
							if (GClass84.gclass145_0.bool_163)
							{
								return false;
							}
							if (!GClass49.smethod_0(gameObject))
							{
								return false;
							}
							if (GClass84.gclass145_0.bool_14)
							{
								GClass90.smethod_0(GClass145.Struct8.vrcavatarManager_0, gameObject, GClass145.Struct8.vrcavatarManager_0 == null, null);
							}
						}
					}
					catch (Exception ex)
					{
						string[] array = new string[10];
						array[0] = "Exception";
						array[1] = " ";
						array[2] = "when";
						array[3] = " ";
						array[4] = "Pre";
						array[5] = "Checking";
						array[6] = " ";
						array[7] = "avatar";
						array[8] = ": ";
						int num = 9;
						Exception ex2 = ex;
						array[num] = ((ex2 != null) ? ex2.ToString() : null);
						GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
					}
					result = true;
				}
			}
			return result;
		}
	}
}
