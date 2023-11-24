using System;
using ns185;
using ns190;
using ns233;
using ns241;
using ns463;
using ns68;
using UnityEngine;
using VRC;

namespace ns99
{
	// Token: 0x02000084 RID: 132
	public class GClass45 : MonoBehaviour
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public void method_0(Collider collider_0)
		{
			this.method_3(collider_0);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000FC08 File Offset: 0x0000DE08
		internal void method_1(Collider collider_0)
		{
			this.method_5(collider_0);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		public void method_2(Collider collider_0)
		{
			this.method_1(collider_0);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000FC30 File Offset: 0x0000DE30
		internal void method_3(Collider collider_0)
		{
			this.method_4(collider_0);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000FC44 File Offset: 0x0000DE44
		public GClass45(IntPtr intptr_0) : base(intptr_0)
		{
			this.player_0 = GClass84.smethod_1010();
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000FC70 File Offset: 0x0000DE70
		internal void method_4(Collider collider_0)
		{
			if (Class74.smethod_2() && this.struct0_0.enum3_0 == Enum3.const_2 && !(GClass84.smethod_1010() != this.player_0))
			{
				GClass45 component = collider_0.GetComponent<GClass45>();
				if (component != null)
				{
					Class189.smethod_6(this);
					GClass70.smethod_127("Lovense", string.Concat(new string[]
					{
						component.player_0.Method_Public_get_VRCPlayerApi_0().displayName,
						" ",
						"stopped",
						" ",
						"touching",
						" ",
						"your",
						" ",
						this.struct0_0.string_0
					}), GClass70.Enum1.const_8);
				}
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		internal void method_5(Collider collider_0)
		{
			if (Class74.smethod_2() && this.struct0_0.enum3_0 == Enum3.const_2 && !(GClass84.smethod_1010() != this.player_0))
			{
				GClass45 component = collider_0.GetComponent<GClass45>();
				if (component != null)
				{
					Class189.smethod_3(this);
					GClass70.smethod_127("Lovense", string.Concat(new string[]
					{
						component.player_0.Method_Public_get_VRCPlayerApi_0().displayName,
						" ",
						"started",
						" ",
						"touching",
						" ",
						"your",
						" ",
						this.struct0_0.string_0
					}), GClass70.Enum1.const_8);
				}
			}
		}

		// Token: 0x040002D7 RID: 727
		internal Player player_0;

		// Token: 0x040002D8 RID: 728
		internal Struct0 struct0_0;

		// Token: 0x040002D9 RID: 729
		internal Vector3 vector3_0 = Vector3.zero;
	}
}
