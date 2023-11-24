using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns185;
using ns241;
using ns425;
using ns458;
using ns459;
using ns477;
using UnityEngine;
using VRC.Animation;
using VRC.DataModel;
using VRC.SDKBase;

namespace ns426
{
	// Token: 0x02000004 RID: 4
	public class GClass131 : GClass130
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002C08 File Offset: 0x00000E08
		internal void method_2()
		{
			if (this.bool_9)
			{
				this.method_68(true);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002C24 File Offset: 0x00000E24
		internal void method_3(bool bool_16)
		{
			this.method_59(bool_16);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002C38 File Offset: 0x00000E38
		internal void method_4()
		{
			this.method_2();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002C4C File Offset: 0x00000E4C
		internal void method_5(bool bool_16)
		{
			this.method_9(bool_16);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002C60 File Offset: 0x00000E60
		internal void method_6(bool bool_16)
		{
			this.method_80(bool_16);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C74 File Offset: 0x00000E74
		internal void method_7(bool bool_16)
		{
			this.method_36(bool_16);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C88 File Offset: 0x00000E88
		internal void method_8(float float_5)
		{
			this.float_2 = GClass84.smethod_1641(float_5);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002CA4 File Offset: 0x00000EA4
		internal void method_9(bool bool_16)
		{
			this.method_82(bool_16);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002CB8 File Offset: 0x00000EB8
		internal void method_10(float float_5)
		{
			this.method_76(float_5);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CCC File Offset: 0x00000ECC
		internal void method_11(float float_5)
		{
			this.method_8(float_5);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002CE0 File Offset: 0x00000EE0
		internal void method_12(bool bool_16)
		{
			this.method_18(bool_16);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CF4 File Offset: 0x00000EF4
		internal void method_13(bool bool_16)
		{
			this.bool_11 = bool_16;
			this.method_25(bool_16);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D10 File Offset: 0x00000F10
		internal void method_14()
		{
			Camera main = Camera.main;
			if (main)
			{
				if (main.nearClipPlane != this.float_2)
				{
					this.method_46(this.float_2);
				}
				if (main.farClipPlane != this.float_3)
				{
					this.method_71(this.float_3);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D6C File Offset: 0x00000F6C
		internal void method_15(bool bool_16)
		{
			this.bool_9 = bool_16;
			this.method_68(bool_16);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D88 File Offset: 0x00000F88
		private Quaternion method_16(Vector3 vector3_0)
		{
			return new Quaternion(vector3_0.x, vector3_0.y, vector3_0.z, 0f);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public override void vmethod_24()
		{
			this.method_77();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002DC8 File Offset: 0x00000FC8
		internal void method_17()
		{
			this.method_38();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002DDC File Offset: 0x00000FDC
		internal void method_18(bool bool_16)
		{
			NeckMouseRotator neckMouseRotator = GClass84.smethod_26();
			if (neckMouseRotator)
			{
				NeckRange field_Public_NeckRange_ = neckMouseRotator.field_Public_NeckRange_0;
				if (bool_16)
				{
					field_Public_NeckRange_.field_Public_Single_0 = float.MinValue;
					field_Public_NeckRange_.field_Public_Single_1 = float.MaxValue;
					field_Public_NeckRange_.field_Public_Single_2 = 0f;
				}
				else
				{
					field_Public_NeckRange_.field_Public_Single_0 = -70f;
					field_Public_NeckRange_.field_Public_Single_1 = 80f;
					field_Public_NeckRange_.field_Public_Single_2 = 0f;
				}
				neckMouseRotator.field_Public_NeckRange_0 = field_Public_NeckRange_;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E54 File Offset: 0x00001054
		internal void method_19(float float_5)
		{
			this.method_64(float_5);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E68 File Offset: 0x00001068
		internal void method_20(float float_5)
		{
			this.method_49(float_5);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E7C File Offset: 0x0000107C
		internal void method_21(bool bool_16)
		{
			this.method_58(bool_16);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002E90 File Offset: 0x00001090
		internal void method_22(bool bool_16)
		{
			this.bool_14 = bool_16;
			if (this.bool_15)
			{
				this.method_5(false);
				this.bool_15 = false;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002EBC File Offset: 0x000010BC
		internal void method_23(float float_5)
		{
			this.method_53(float_5);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002ED0 File Offset: 0x000010D0
		internal void method_24(bool bool_16)
		{
			this.method_79(bool_16);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002EE4 File Offset: 0x000010E4
		internal void method_25(bool bool_16)
		{
			this.method_37(bool_16);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002EF8 File Offset: 0x000010F8
		internal void method_26(bool bool_16)
		{
			VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
			if (vrcplayerApi != null)
			{
				vrcplayerApi.EnablePickups(bool_16);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002F18 File Offset: 0x00001118
		internal void method_27(bool bool_16)
		{
			this.method_6(bool_16);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002F2C File Offset: 0x0000112C
		internal void method_28(bool bool_16)
		{
			this.method_52(bool_16);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F40 File Offset: 0x00001140
		private Quaternion method_29(Vector3 vector3_0, float float_5)
		{
			return new Quaternion(vector3_0.x, vector3_0.y, vector3_0.z, float_5);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002F68 File Offset: 0x00001168
		internal void method_30(float float_5)
		{
			GClass84.smethod_576(float_5);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F7C File Offset: 0x0000117C
		public override void vmethod_10()
		{
			this.method_4();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F90 File Offset: 0x00001190
		internal void method_31(bool bool_16)
		{
			this.method_35(bool_16);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002FA4 File Offset: 0x000011A4
		internal void method_32(float float_5)
		{
			GClass84.smethod_894(float_5);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002FB8 File Offset: 0x000011B8
		public override void vmethod_1()
		{
			this.method_57();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002FCC File Offset: 0x000011CC
		internal void method_33(float float_5)
		{
			this.method_67(float_5);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002FE0 File Offset: 0x000011E0
		internal void method_34(bool bool_16)
		{
			this.method_78(bool_16);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002FF4 File Offset: 0x000011F4
		internal void method_35(bool bool_16)
		{
			this.method_63(bool_16);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003008 File Offset: 0x00001208
		internal void method_36(bool bool_16)
		{
			this.bool_8 = bool_16;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000301C File Offset: 0x0000121C
		internal void method_37(bool bool_16)
		{
			this.method_26(bool_16);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003030 File Offset: 0x00001230
		internal void method_38()
		{
			try
			{
				if (GClass84.bool_4)
				{
					if (Input.GetKeyDown(270))
					{
						this.method_23(1f);
					}
					if (Input.GetKeyDown(269))
					{
						this.method_23(-1f);
					}
				}
				if (Input.GetKey(306))
				{
					if (GClass84.bool_4)
					{
						if (Input.GetKeyDown(102))
						{
							try
							{
								GClass163.gclass29_2.method_39(!this.bool_0, true);
							}
							catch (Exception ex)
							{
								this.method_5(!this.bool_0);
								GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
							}
						}
						if (Input.GetKeyDown(103))
						{
							if (this.bool_0)
							{
								try
								{
									GClass163.gclass29_4.method_39(!this.bool_2, true);
									goto IL_F7;
								}
								catch (Exception ex2)
								{
									this.method_27(!this.bool_2);
									GClass70.smethod_36(ex2.ToString(), GClass70.Enum1.const_0);
									goto IL_F7;
								}
							}
							try
							{
								GClass163.gclass29_4.method_39(false, true);
							}
							catch (Exception ex3)
							{
								GClass70.smethod_36(ex3.ToString(), GClass70.Enum1.const_0);
							}
						}
					}
					IL_F7:
					Vector3 vector3_;
					if (this.bool_5 && Input.GetKeyDown(323) && (GClass84.smethod_1424() != null && GClass84.smethod_813() != null) && GClass84.smethod_948(Camera.main.transform.position, Camera.main.transform.forward, out vector3_))
					{
						GClass84.smethod_1740(vector3_, false);
					}
				}
				if (this.bool_12)
				{
					VRCPlayer vrcplayer = GClass84.smethod_460();
					GamelikeInputController gamelikeInputController = GClass84.smethod_1443();
					if (vrcplayer && gamelikeInputController)
					{
						VRCAvatarManager vrcavatarManager = GClass84.smethod_1416(vrcplayer);
						bool key = Input.GetKey(306);
						if (Input.GetKey(308))
						{
							float y = Input.mouseScrollDelta.y;
							if (y != 0f)
							{
							}
						}
						if (Input.GetKeyDown(308) && !this.bool_13)
						{
							Transform transform = vrcavatarManager.transform;
							if (transform)
							{
								this.float_1 = transform.rotation.eulerAngles.y;
								this.bool_13 = true;
							}
						}
						if ((Input.GetKeyUp(308) || !Application.isFocused) && this.bool_13)
						{
							Transform transform2 = vrcavatarManager.transform;
							if (transform2)
							{
								transform2.rotation = vrcplayer.transform.rotation;
							}
							this.bool_13 = false;
						}
						if (this.bool_13)
						{
							Transform transform3 = vrcavatarManager.transform;
							if (transform3)
							{
								if (!key)
								{
									float num = Mathf.DeltaAngle(this.float_1, vrcplayer.transform.eulerAngles.y);
									if (Mathf.Abs(num) > 90f)
									{
										this.float_1 += (Mathf.Abs(num) - 90f) * Mathf.Sign(num);
										this.float_1 = (this.float_1 + 360f) % 360f;
									}
								}
								Quaternion rotation = transform3.rotation;
								Vector3 eulerAngles = rotation.eulerAngles;
								eulerAngles.y = this.float_1;
								rotation.eulerAngles = eulerAngles;
								transform3.rotation = rotation;
							}
						}
					}
				}
				if (this.bool_0)
				{
					VRCPlayer vrcplayer2 = GClass84.smethod_460();
					if (!vrcplayer2)
					{
						return;
					}
					Transform transform4;
					if (this.bool_1)
					{
						transform4 = vrcplayer2.transform;
					}
					else
					{
						transform4 = Camera.main.transform;
					}
					Vector3 gravity = Physics.gravity;
					if (gravity.y != 0f)
					{
						gravity.y = 0f;
						Physics.gravity = gravity;
						if (!this.bool_4)
						{
							this.bool_4 = true;
						}
					}
					Transform transform5 = vrcplayer2.transform;
					if (!transform5)
					{
						return;
					}
					float deltaTime = Time.deltaTime;
					if (Input.GetKey(113))
					{
						transform5.position -= deltaTime * transform4.up * GClass131.smethod_0();
					}
					if (Input.GetKey(101))
					{
						transform5.position += deltaTime * transform4.up * GClass131.smethod_0();
					}
					if (GClass84.smethod_1108())
					{
						float axis = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical");
						if (axis != 0f)
						{
							transform5.position += deltaTime * transform4.up * axis * GClass131.smethod_0();
						}
					}
					VRCMotionState vrcmotionState = GClass84.smethod_904();
					if (vrcmotionState != null)
					{
						vrcmotionState.Reset();
					}
				}
				else
				{
					if (this.bool_7)
					{
						if (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Single_1() == 1f)
						{
							VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
							if (vrcplayerApi != null)
							{
								Vector3 velocity = vrcplayerApi.GetVelocity();
								velocity.y = vrcplayerApi.GetJumpImpulse();
								vrcplayerApi.SetVelocity(velocity);
							}
						}
					}
					else if (this.bool_8)
					{
						VRCPlayerApi vrcplayerApi2 = GClass84.smethod_739();
						if (vrcplayerApi2 != null && (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Boolean_0() && !vrcplayerApi2.IsPlayerGrounded()))
						{
							Vector3 velocity2 = vrcplayerApi2.GetVelocity();
							velocity2.y = vrcplayerApi2.GetJumpImpulse();
							velocity2.y += 1f;
							vrcplayerApi2.SetVelocity(velocity2);
							velocity2.y -= 1f;
						}
					}
					if (this.bool_4)
					{
						Vector3 gravity2 = Physics.gravity;
						gravity2.y = this.float_0;
						Physics.gravity = gravity2;
						this.bool_4 = false;
					}
					else if (!this.bool_3)
					{
						this.float_0 = Physics.gravity.y;
						this.bool_3 = true;
					}
				}
				if (this.bool_6)
				{
					VRCPlayer vrcplayer3 = GClass84.smethod_460();
					if (!vrcplayer3)
					{
						return;
					}
					Transform transform6 = vrcplayer3.transform;
					if (!transform6)
					{
						return;
					}
					if (Input.GetKey(308))
					{
						if (Input.GetKeyDown(111))
						{
							transform6.rotation = default(Quaternion);
						}
						else if (Input.GetKey(105))
						{
							transform6.Rotate(Vector3.right, this.float_4 * GClass84.float_0);
						}
						else if (Input.GetKey(107))
						{
							transform6.Rotate(Vector3.left, this.float_4 * GClass84.float_0);
						}
						else if (Input.GetKey(108))
						{
							transform6.Rotate(Vector3.back, this.float_4 * GClass84.float_0);
						}
						else if (Input.GetKey(106))
						{
							transform6.Rotate(Vector3.forward, this.float_4 * GClass84.float_0);
						}
					}
				}
				if (this.bool_10)
				{
					this.method_69(true);
				}
			}
			catch (Exception ex4)
			{
				GClass70.smethod_36(ex4.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003760 File Offset: 0x00001960
		internal void method_39(bool bool_16)
		{
			this.method_47(bool_16);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003774 File Offset: 0x00001974
		internal void method_40(bool bool_16)
		{
			this.bool_5 = bool_16;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003788 File Offset: 0x00001988
		internal void method_41()
		{
			if (this.bool_14 && this.bool_15)
			{
				this.method_5(false);
				this.bool_15 = false;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000037B4 File Offset: 0x000019B4
		internal void method_42(float float_5)
		{
			this.method_20(float_5);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000037C8 File Offset: 0x000019C8
		internal void method_43(bool bool_16)
		{
			this.method_21(bool_16);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000037DC File Offset: 0x000019DC
		internal void method_44(bool bool_16)
		{
			this.bool_7 = bool_16;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000037F0 File Offset: 0x000019F0
		internal static GClass131.Delegate0 Delegate0_0
		{
			get
			{
				if (GClass131.methodInfo_0 == null)
				{
					GClass131.methodInfo_0 = typeof(VRCPlayer).GetMethods(BindingFlags.Instance | BindingFlags.Public).First(new Func<MethodInfo, bool>(GClass131.Class0.class0_0.method_0));
				}
				return (GClass131.Delegate0)Delegate.CreateDelegate(typeof(GClass131.Delegate0), GClass84.smethod_460(), GClass131.methodInfo_0);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003864 File Offset: 0x00001A64
		internal void method_45()
		{
			this.method_41();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003878 File Offset: 0x00001A78
		internal void method_46(float float_5)
		{
			this.method_11(float_5);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000388C File Offset: 0x00001A8C
		internal void method_47(bool bool_16)
		{
			this.method_44(bool_16);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000038A0 File Offset: 0x00001AA0
		internal static float smethod_0()
		{
			return Input.GetKey(304) ? GClass84.smethod_354() : GClass84.smethod_210();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003788 File Offset: 0x00001988
		internal void method_48()
		{
			if (this.bool_14 && this.bool_15)
			{
				this.method_5(false);
				this.bool_15 = false;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000038C8 File Offset: 0x00001AC8
		internal void method_49(float float_5)
		{
			GClass84.smethod_1261(float_5);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000038DC File Offset: 0x00001ADC
		internal void method_50(bool bool_16)
		{
			this.bool_6 = bool_16;
			if (bool_16)
			{
				GClass131.delegate0_0 = GClass131.Delegate0_0;
			}
			else
			{
				VRCPlayer vrcplayer = GClass84.smethod_460();
				if (vrcplayer)
				{
					vrcplayer.gameObject.GetComponent<CharacterController>().enabled = false;
					Quaternion localRotation = vrcplayer.transform.localRotation;
					vrcplayer.transform.localRotation = new Quaternion(0f, localRotation.y, 0f, localRotation.w);
					GClass131.delegate0_0();
					vrcplayer.gameObject.GetComponent<CharacterController>().enabled = true;
				}
				else
				{
					GClass131.delegate0_0();
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003978 File Offset: 0x00001B78
		internal void method_51(bool bool_16)
		{
			this.method_7(bool_16);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000398C File Offset: 0x00001B8C
		internal void method_52(bool bool_16)
		{
			this.method_40(bool_16);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000039A0 File Offset: 0x00001BA0
		public override void vmethod_19()
		{
			this.method_17();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000039B4 File Offset: 0x00001BB4
		internal void method_53(float float_5)
		{
			this.method_30(float_5);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000039C8 File Offset: 0x00001BC8
		internal void method_54()
		{
			this.method_83();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000039DC File Offset: 0x00001BDC
		internal void method_55(bool bool_16)
		{
			this.method_22(bool_16);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000039F0 File Offset: 0x00001BF0
		internal void method_56()
		{
			if (this.bool_14 && !this.bool_0)
			{
				this.method_5(true);
				this.bool_15 = true;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003A20 File Offset: 0x00001C20
		internal void method_57()
		{
			this.method_48();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003A34 File Offset: 0x00001C34
		internal void method_58(bool bool_16)
		{
			this.bool_1 = bool_16;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003A48 File Offset: 0x00001C48
		internal void method_59(bool bool_16)
		{
			this.method_13(bool_16);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003A5C File Offset: 0x00001C5C
		internal void method_60(bool bool_16)
		{
			this.method_61(bool_16);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003A70 File Offset: 0x00001C70
		internal void method_61(bool bool_16)
		{
			this.method_72(bool_16);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003A84 File Offset: 0x00001C84
		internal void method_62()
		{
			this.method_56();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003A98 File Offset: 0x00001C98
		internal void method_63(bool bool_16)
		{
			this.bool_10 = bool_16;
			this.method_69(bool_16);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003AB4 File Offset: 0x00001CB4
		internal void method_64(float float_5)
		{
			GClass84.smethod_1616(float_5);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003AC8 File Offset: 0x00001CC8
		internal void method_65(bool bool_16)
		{
			VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
			if (vrcplayerApi != null)
			{
				vrcplayerApi.Immobilize(bool_16);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003AE8 File Offset: 0x00001CE8
		internal void method_66(bool bool_16)
		{
			this.method_55(bool_16);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003AFC File Offset: 0x00001CFC
		internal void method_67(float float_5)
		{
			this.float_3 = GClass84.smethod_734(float_5);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003B18 File Offset: 0x00001D18
		internal void method_68(bool bool_16)
		{
			this.method_12(bool_16);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003B2C File Offset: 0x00001D2C
		public override void vmethod_23()
		{
			this.method_54();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003B40 File Offset: 0x00001D40
		internal void method_69(bool bool_16)
		{
			this.method_75(bool_16);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003B54 File Offset: 0x00001D54
		internal void method_70(float float_5)
		{
			this.method_19(float_5);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003B68 File Offset: 0x00001D68
		internal void method_71(float float_5)
		{
			this.method_33(float_5);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003B7C File Offset: 0x00001D7C
		public override void vmethod_14()
		{
			this.method_62();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003B90 File Offset: 0x00001D90
		internal void method_72(bool bool_16)
		{
			this.bool_12 = bool_16;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003BA4 File Offset: 0x00001DA4
		internal void method_73(bool bool_16)
		{
			this.method_81(bool_16);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003BB8 File Offset: 0x00001DB8
		internal void method_74(bool bool_16)
		{
			if (bool_16)
			{
				GameObject gameObject = GClass84.smethod_229();
				if (gameObject)
				{
					this.method_34(gameObject.active);
				}
			}
			else
			{
				this.method_34(false);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003BEC File Offset: 0x00001DEC
		internal void method_75(bool bool_16)
		{
			this.method_74(bool_16);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003C00 File Offset: 0x00001E00
		internal void method_76(float float_5)
		{
			this.method_32(float_5);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003C14 File Offset: 0x00001E14
		internal void method_77()
		{
			this.method_14();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003C28 File Offset: 0x00001E28
		internal void method_78(bool bool_16)
		{
			this.method_65(bool_16);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003C3C File Offset: 0x00001E3C
		internal void method_79(bool bool_16)
		{
			this.method_50(bool_16);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003C50 File Offset: 0x00001E50
		public override void vmethod_16()
		{
			this.method_45();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003C64 File Offset: 0x00001E64
		internal void method_80(bool bool_16)
		{
			this.bool_2 = bool_16;
			GClass84.smethod_447(bool_16);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003C80 File Offset: 0x00001E80
		internal void method_81(bool bool_16)
		{
			this.method_15(bool_16);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003C94 File Offset: 0x00001E94
		internal void method_82(bool bool_16)
		{
			this.bool_0 = bool_16;
			if (!bool_16)
			{
				this.method_27(false);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003D74 File Offset: 0x00001F74
		internal void method_83()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_29.Add(new Action(this.vmethod_1));
			GClass84.list_30.Add(new Action(this.vmethod_14));
			GClass84.list_31.Add(new Action(this.vmethod_16));
			GClass84.gclass180_0 = new GClass180();
			this.vmethod_4(GClass84.gclass180_0);
			GClass84.gclass162_0 = new GClass162();
			this.vmethod_4(GClass84.gclass162_0);
		}

		// Token: 0x04000019 RID: 25
		internal bool bool_0 = false;

		// Token: 0x0400001A RID: 26
		internal bool bool_1 = false;

		// Token: 0x0400001B RID: 27
		internal bool bool_2 = false;

		// Token: 0x0400001C RID: 28
		internal float float_0 = 0f;

		// Token: 0x0400001D RID: 29
		internal bool bool_3 = false;

		// Token: 0x0400001E RID: 30
		internal bool bool_4 = false;

		// Token: 0x0400001F RID: 31
		internal bool bool_5 = true;

		// Token: 0x04000020 RID: 32
		internal bool bool_6 = false;

		// Token: 0x04000021 RID: 33
		internal bool bool_7 = false;

		// Token: 0x04000022 RID: 34
		internal bool bool_8 = false;

		// Token: 0x04000023 RID: 35
		internal bool bool_9 = false;

		// Token: 0x04000024 RID: 36
		internal bool bool_10 = false;

		// Token: 0x04000025 RID: 37
		internal bool bool_11 = true;

		// Token: 0x04000026 RID: 38
		internal bool bool_12 = false;

		// Token: 0x04000027 RID: 39
		private float float_1 = 0f;

		// Token: 0x04000028 RID: 40
		private bool bool_13 = false;

		// Token: 0x04000029 RID: 41
		internal bool bool_14 = false;

		// Token: 0x0400002A RID: 42
		internal bool bool_15 = false;

		// Token: 0x0400002B RID: 43
		internal float float_2 = 0.01f;

		// Token: 0x0400002C RID: 44
		internal float float_3 = 1000f;

		// Token: 0x0400002D RID: 45
		internal float float_4 = 180f;

		// Token: 0x0400002E RID: 46
		private static GClass131.Delegate0 delegate0_0;

		// Token: 0x0400002F RID: 47
		private static MethodInfo methodInfo_0;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000092 RID: 146
		internal delegate void Delegate0();

		// Token: 0x02000006 RID: 6
		[CompilerGenerated]
		[Serializable]
		private sealed class Class0
		{
			// Token: 0x06000097 RID: 151 RVA: 0x00003E64 File Offset: 0x00002064
			internal bool method_0(MethodInfo methodInfo_0)
			{
				return methodInfo_0.ReturnType == typeof(void) && methodInfo_0.GetParameters().Length == 0 && methodInfo_0.smethod_832("get_Transform", null) && methodInfo_0.smethod_832(null, "Player") && methodInfo_0.smethod_832("Vector3_Quaternion", "VRCPlayer") && methodInfo_0.smethod_832(null, "VRCTrackingManager") && methodInfo_0.smethod_832(null, "InputStateController");
			}

			// Token: 0x04000030 RID: 48
			public static readonly GClass131.Class0 class0_0 = new GClass131.Class0();

			// Token: 0x04000031 RID: 49
			public static Func<MethodInfo, bool> func_0;
		}
	}
}
