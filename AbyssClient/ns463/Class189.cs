using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ns123;
using ns185;
using ns190;
using ns233;
using ns241;
using ns425;
using ns68;
using ns99;
using UnhollowerRuntimeLib;
using UnityEngine;
using VRC;

namespace ns463
{
	// Token: 0x02000312 RID: 786
	internal class Class189 : GClass130
	{
		// Token: 0x0600409D RID: 16541 RVA: 0x000F3C84 File Offset: 0x000F1E84
		public override void vmethod_11()
		{
			this.method_2();
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x000F3C98 File Offset: 0x000F1E98
		public override void vmethod_0(string string_1, string string_2, GameObject gameObject_0)
		{
			this.method_3(string_1, string_2, gameObject_0);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x000F3CB0 File Offset: 0x000F1EB0
		internal void method_2()
		{
			this.method_9();
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x000F3CC4 File Offset: 0x000F1EC4
		public override void vmethod_23()
		{
			this.method_4();
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x000F3CD8 File Offset: 0x000F1ED8
		internal void method_3(string string_1, string string_2, GameObject gameObject_0)
		{
			this.method_7(string_1, string_2, gameObject_0);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x000F3CF0 File Offset: 0x000F1EF0
		internal static void smethod_0(GClass45 gclass45_0)
		{
			Class189.smethod_7(gclass45_0);
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x000F3D04 File Offset: 0x000F1F04
		internal void method_4()
		{
			this.method_10();
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x000F3D18 File Offset: 0x000F1F18
		internal static void smethod_1(byte byte_1, bool bool_0)
		{
			if (Class189.list_0.Count == 0 && byte_1 > 0)
			{
				Class74.smethod_12(0, new Action<byte, bool>(Class189.smethod_2));
			}
			else
			{
				Class74.smethod_12(Class189.byte_0, new Action<byte, bool>(Class189.smethod_2));
			}
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x000F3D64 File Offset: 0x000F1F64
		internal static void smethod_2(byte byte_1, bool bool_0)
		{
			Class189.smethod_8(byte_1, bool_0);
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x000F400C File Offset: 0x000F220C
		private void method_5(Player player_0, Transform transform_0, Vector3 vector3_0, Vector3 vector3_1, Struct0 struct0_0)
		{
			this.method_8(player_0, transform_0, vector3_0, vector3_1, struct0_0);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000F404C File Offset: 0x000F224C
		internal static void smethod_3(GClass45 gclass45_0)
		{
			Class189.smethod_0(gclass45_0);
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000F4060 File Offset: 0x000F2260
		internal static void smethod_4(GClass45 gclass45_0)
		{
			Class189.smethod_5(gclass45_0);
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000F4074 File Offset: 0x000F2274
		private void method_6(Player player_0, Transform transform_0, Vector3 vector3_0, Vector3 vector3_1, Struct0 struct0_0)
		{
			this.method_5(player_0, transform_0, vector3_0, vector3_1, struct0_0);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000F4094 File Offset: 0x000F2294
		internal static void smethod_5(GClass45 gclass45_0)
		{
			if (Class189.list_0.Contains(gclass45_0))
			{
				Class189.list_0.Remove(gclass45_0);
			}
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x000F40C0 File Offset: 0x000F22C0
		internal static void smethod_6(GClass45 gclass45_0)
		{
			Class189.smethod_4(gclass45_0);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x000F40D4 File Offset: 0x000F22D4
		internal void method_7(string string_1, string string_2, GameObject gameObject_0)
		{
			Player player = GClass84.smethod_1299(string_2);
			if (player == null)
			{
				GClass70.smethod_127("Lovense", string_2 + " " + "doesn't have a valid player script", GClass70.Enum1.const_8);
			}
			else if (!(GClass84.smethod_1010() != player) || (GClass55.gclass55_0.dictionary_0.ContainsKey(player.Method_Internal_get_APIUser_0().id) && GClass55.gclass55_0.dictionary_0[player.Method_Internal_get_APIUser_0().id].bool_0))
			{
				Animator componentInChildren = gameObject_0.GetComponentInChildren<Animator>();
				if (componentInChildren == null)
				{
					GClass70.smethod_127("Lovense", string_2 + " " + "doesn't have an animator", GClass70.Enum1.const_8);
				}
				else
				{
					foreach (KeyValuePair<HumanBodyBones, Struct0> keyValuePair in this.dictionary_0)
					{
						if (!keyValuePair.Value.bool_0 || !(GClass84.smethod_1010() != player))
						{
							Transform boneTransform = componentInChildren.GetBoneTransform(keyValuePair.Key);
							if (boneTransform != null)
							{
								Vector3 vector3_ = keyValuePair.Value.vector3_0 * (gameObject_0.transform.localScale.y / 2f);
								Vector3 vector3_2 = keyValuePair.Value.vector3_1 * gameObject_0.transform.localScale.y;
								this.method_6(player, boneTransform, vector3_, vector3_2, keyValuePair.Value);
							}
						}
					}
				}
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000F4278 File Offset: 0x000F2478
		internal static void smethod_7(GClass45 gclass45_0)
		{
			if (!Class189.list_0.Contains(gclass45_0))
			{
				Class189.list_0.Add(gclass45_0);
				Class74.smethod_12(Class189.byte_0, new Action<byte, bool>(Class189.smethod_2));
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000F42B4 File Offset: 0x000F24B4
		private void method_8(Player player_0, Transform transform_0, Vector3 vector3_0, Vector3 vector3_1, Struct0 struct0_0)
		{
			GameObject gameObject = GameObject.CreatePrimitive(0);
			gameObject.name = "AbyssClient Lovense Touch";
			gameObject.transform.localScale = vector3_1;
			gameObject.transform.position = transform_0.position + vector3_0;
			gameObject.transform.parent = transform_0;
			gameObject.GetComponent<Collider>().isTrigger = true;
			Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
			rigidbody.useGravity = false;
			rigidbody.isKinematic = true;
			rigidbody.constraints = 126;
			GClass45 gclass = gameObject.AddComponent<GClass45>();
			gclass.player_0 = player_0;
			gclass.struct0_0 = struct0_0;
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000F4344 File Offset: 0x000F2544
		internal static void smethod_8(byte byte_1, bool bool_0)
		{
			Class189.smethod_1(byte_1, bool_0);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x000F4358 File Offset: 0x000F2558
		internal void method_9()
		{
			if (Class74.smethod_2() && Class189.list_0.Count != 0)
			{
				float num = 0f;
				foreach (GClass45 gclass in Class189.list_0)
				{
					float num2 = Vector3.Distance(gclass.vector3_0, gclass.transform.position);
					gclass.vector3_0 = gclass.transform.position;
					if (num2 > num)
					{
						num = num2;
					}
				}
				Class189.byte_0 = (byte)(num * 50f * 20f);
			}
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x000F4414 File Offset: 0x000F2614
		internal void method_10()
		{
			GClass84.list_8.Add(new Action(this.vmethod_11));
			GClass84.list_33.Add(new Action<string, string, GameObject>(this.vmethod_0));
			GClass55.smethod_3();
			ClassInjector.RegisterTypeInIl2Cpp<GClass45>();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Class189.Class185.class185_0.method_0));
		}

		// Token: 0x0400191C RID: 6428
		private readonly Dictionary<HumanBodyBones, Struct0> dictionary_0 = new Dictionary<HumanBodyBones, Struct0>
		{
			{
				10,
				new Struct0
				{
					string_0 = "Mouth",
					bool_0 = true,
					enum3_0 = Enum3.const_2,
					vector3_0 = new Vector3(0.055f, 0.04f, 0f),
					vector3_1 = new Vector3(0.05f, 0.05f, 0.05f)
				}
			},
			{
				0,
				new Struct0
				{
					string_0 = "Pussy",
					bool_0 = true,
					enum3_0 = Enum3.const_2,
					vector3_0 = new Vector3(0f, -0.125f, 0f),
					vector3_1 = new Vector3(0.1f, 0.1f, 0.1f)
				}
			},
			{
				0,
				new Struct0
				{
					string_0 = "Ass",
					bool_0 = true,
					enum3_0 = Enum3.const_2,
					vector3_0 = new Vector3(-0.05f, -0.125f, 0f),
					vector3_1 = new Vector3(0.1f, 0.1f, 0.1f)
				}
			},
			{
				44,
				new Struct0
				{
					string_0 = "Right Finger",
					bool_0 = false,
					enum3_0 = Enum3.const_1,
					vector3_0 = Vector3.zero,
					vector3_1 = new Vector3(0.02f, 0.02f, 0.02f)
				}
			},
			{
				29,
				new Struct0
				{
					string_0 = "Left Finger",
					bool_0 = false,
					enum3_0 = Enum3.const_1,
					vector3_0 = Vector3.zero,
					vector3_1 = new Vector3(0.02f, 0.02f, 0.02f)
				}
			},
			{
				5,
				new Struct0
				{
					string_0 = "Left Foot",
					bool_0 = false,
					enum3_0 = Enum3.const_1,
					vector3_0 = Vector3.zero,
					vector3_1 = new Vector3(0.1f, 0.1f, 0.1f)
				}
			},
			{
				6,
				new Struct0
				{
					string_0 = "Right Foot",
					bool_0 = false,
					enum3_0 = Enum3.const_1,
					vector3_0 = Vector3.zero,
					vector3_1 = new Vector3(0.1f, 0.1f, 0.1f)
				}
			}
		};

		// Token: 0x0400191D RID: 6429
		private static readonly List<GClass45> list_0 = new List<GClass45>();

		// Token: 0x0400191E RID: 6430
		internal static byte byte_0 = 0;

		// Token: 0x02000313 RID: 787
		[CompilerGenerated]
		[Serializable]
		private sealed class Class185
		{
			// Token: 0x060040B6 RID: 16566 RVA: 0x0002E844 File Offset: 0x0002CA44
			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			// Token: 0x0400191F RID: 6431
			public static readonly Class189.Class185 class185_0 = new Class189.Class185();

			// Token: 0x04001920 RID: 6432
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
		}
	}
}
