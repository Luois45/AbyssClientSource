using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using ns165;
using ns185;
using ns241;
using ns425;
using ns490;
using RealisticEyeMovements;
using RootMotion.FinalIK;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.Animations;
using VRC;
using VRC.SDKBase;
using VRC.SDKBase.Validation.Performance;

namespace ns475
{
	// Token: 0x0200032E RID: 814
	public class GClass178 : GClass130
	{
		// Token: 0x060045C6 RID: 17862 RVA: 0x00104A68 File Offset: 0x00102C68
		internal string[] method_2(GClass178.Enum12 enum12_0)
		{
			string[] result;
			if (enum12_0 == GClass178.Enum12.const_1)
			{
				result = new string[]
				{
					"HomeTheatre_Room/GameObject",
					"House/Reflection Probe GROUP"
				};
			}
			else
			{
				result = new string[0];
			}
			return result;
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00104A9C File Offset: 0x00102C9C
		internal void method_3(GameObject gameObject_0)
		{
			if (gameObject_0)
			{
				Transform transform = gameObject_0.transform.Find("PortalGraphics/PortalFringe");
				if (transform)
				{
					transform.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00104ADC File Offset: 0x00102CDC
		internal void method_4(GClass178.Enum12 enum12_0)
		{
			this.method_72(enum12_0);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00104AF0 File Offset: 0x00102CF0
		internal void method_5()
		{
			List<GameObject> list = GClass84.smethod_1265();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Object.Destroy(list[i]);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					list.Count.ToString(),
					" ",
					"Portals",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00104B88 File Offset: 0x00102D88
		internal void method_6()
		{
			this.method_18();
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00104B9C File Offset: 0x00102D9C
		internal void method_7()
		{
			List<GameObject> list = GClass84.smethod_1051();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Object.Destroy(list[i]);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					list.Count.ToString(),
					" ",
					"Mirrors",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00104C34 File Offset: 0x00102E34
		internal void method_8()
		{
			this.method_87();
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00104C48 File Offset: 0x00102E48
		internal void method_9()
		{
			this.method_36();
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00104C5C File Offset: 0x00102E5C
		internal void method_10()
		{
			this.method_77();
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00104C70 File Offset: 0x00102E70
		internal void method_11()
		{
			this.method_37();
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00104C84 File Offset: 0x00102E84
		internal void method_12()
		{
			this.method_73();
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00104C98 File Offset: 0x00102E98
		internal void method_13()
		{
			this.method_82();
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00104CAC File Offset: 0x00102EAC
		internal void method_14()
		{
			this.method_86();
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00104CC0 File Offset: 0x00102EC0
		internal void method_15()
		{
			this.method_71();
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00104CD4 File Offset: 0x00102ED4
		internal void method_16()
		{
			List<GameObject> list = GClass84.smethod_1265();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(false);
			}
			list.Clear();
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00104D10 File Offset: 0x00102F10
		internal void method_17(GClass178.Enum12 enum12_0)
		{
			string[] array = this.method_2(enum12_0);
			for (int i = 0; i < array.Length; i++)
			{
				GameObject gameObject = GameObject.Find(array[i]);
				if (!gameObject)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						array[i],
						" ",
						"Is",
						" ",
						"Not",
						" ",
						"Found"
					}), GClass70.Enum1.const_0);
				}
				Object.DestroyImmediate(gameObject, true);
			}
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00104D98 File Offset: 0x00102F98
		internal void method_18()
		{
			this.method_44();
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00104DAC File Offset: 0x00102FAC
		internal void method_19()
		{
			this.method_46();
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00104DC0 File Offset: 0x00102FC0
		internal void method_20(GameObject gameObject_0)
		{
			this.method_43(gameObject_0);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00104DD4 File Offset: 0x00102FD4
		internal List<Transform> method_21()
		{
			List<Transform> list = new List<Transform>();
			GameObject[] array = GClass84.smethod_1215(false, false, false);
			for (int i = 0; i < array.Length; i++)
			{
				List<VRC_Trigger> list2 = array[i].GetComponents<VRC_Trigger>().ToList<VRC_Trigger>();
				list2.AddRange(array[i].GetComponentsInChildren<VRC_Trigger>(true));
				GClass84.smethod_661<VRC_Trigger>(ref list2);
				foreach (VRC_Trigger vrc_Trigger in list2)
				{
					if (vrc_Trigger)
					{
						foreach (VRC_Trigger.TriggerEvent triggerEvent in vrc_Trigger.Triggers)
						{
							foreach (VRC_EventHandler.VrcEvent vrcEvent in triggerEvent.Events)
							{
								for (int j = 0; j < vrcEvent.ParameterObjects.Length; j++)
								{
									GameObject gameObject = vrcEvent.ParameterObjects[j];
									if (gameObject)
									{
										Transform transform = gameObject.transform;
										if (transform)
										{
											list.Add(transform);
										}
									}
								}
							}
						}
					}
				}
				list2.Clear();
				List<VRCStation> list3 = array[i].GetComponents<VRCStation>().ToList<VRCStation>();
				list3.AddRange(array[i].GetComponentsInChildren<VRCStation>(true));
				GClass84.smethod_661<VRCStation>(ref list3);
				foreach (VRCStation vrcstation in list3)
				{
					if (vrcstation)
					{
						list.Add(vrcstation.stationEnterPlayerLocation);
						list.Add(vrcstation.stationExitPlayerLocation);
					}
				}
				list3.Clear();
				List<VRC_AvatarPedestal> list4 = array[i].GetComponents<VRC_AvatarPedestal>().ToList<VRC_AvatarPedestal>();
				list4.AddRange(array[i].GetComponentsInChildren<VRC_AvatarPedestal>(true));
				GClass84.smethod_661<VRC_AvatarPedestal>(ref list4);
				foreach (VRC_AvatarPedestal vrc_AvatarPedestal in list4)
				{
					if (vrc_AvatarPedestal)
					{
						list.Add(vrc_AvatarPedestal.Placement);
					}
				}
				list4.Clear();
			}
			GClass84.smethod_661<Transform>(ref list);
			GClass84.smethod_1233<Transform>(list);
			return list;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00105038 File Offset: 0x00103238
		internal string[] method_22(GClass178.Enum12 enum12_0)
		{
			string[] result;
			if (enum12_0 == GClass178.Enum12.const_1)
			{
				result = new string[]
				{
					"House/Paintings",
					"House/Paintings/mH_Painting02",
					"House/Paintings/mH_Painting05 (2)",
					"House/Paintings/mH_Painting01 (7)",
					"House/Paintings/mH_Painting01 (5)",
					"House/Paintings/mH_Painting01 (6)",
					"PatreonStuff",
					"Posters"
				};
			}
			else
			{
				result = new string[0];
			}
			return result;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x0010509C File Offset: 0x0010329C
		internal void method_23()
		{
			List<GameObject> list = GClass84.smethod_314();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(true);
			}
			list.Clear();
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x001050D8 File Offset: 0x001032D8
		internal void method_24()
		{
			List<ReflectionProbe> list = this.method_79();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Object.DestroyImmediate(list[i], true);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					list.Count.ToString(),
					" ",
					"Reflection",
					" ",
					"Probes",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00105184 File Offset: 0x00103384
		internal void method_25()
		{
			List<GameObject> list = GClass84.smethod_171();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(false);
			}
			list.Clear();
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001051C0 File Offset: 0x001033C0
		internal void method_26(GClass178.Enum12 enum12_0)
		{
			string[] array = this.method_22(enum12_0);
			for (int i = 0; i < array.Length; i++)
			{
				GameObject gameObject = GameObject.Find(array[i]);
				if (!gameObject)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						array[i],
						" ",
						"Is",
						" ",
						"Not",
						" ",
						"Found"
					}), GClass70.Enum1.const_0);
				}
				Object.DestroyImmediate(gameObject, true);
			}
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00105248 File Offset: 0x00103448
		internal string[] method_27(GClass178.Enum12 enum12_0)
		{
			string[] result;
			if (enum12_0 == GClass178.Enum12.const_1)
			{
				result = new string[]
				{
					"ChangelogUI",
					"HomeTheatre_Room/Seating",
					"House/Prop GROUP/Interior/Downstairs Closet/mH_LightSwitch (9)",
					"House/Prop GROUP/Interior/Front Visiting Room/mH_LightSwitch (6)",
					"House/Prop GROUP/Interior/Garage/mH_LightSwitch (7)",
					"House/Prop GROUP/Interior/Half Bathroom/mH_HandSoap",
					"House/Prop GROUP/Interior/Half Bathroom/mH_LotionBottle",
					"House/Prop GROUP/Interior/Half Bathroom/mH_ToiletPaper",
					"House/Prop GROUP/Interior/Half Bathroom/Towel Rack GROUP",
					"House/Prop GROUP/Interior/Kids Room/Book Set 04 GROUP",
					"House/Prop GROUP/Interior/Kids Room/Book Set 1 GROUP",
					"House/Prop GROUP/Interior/Kids Room/mH_Abacus",
					"House/Prop GROUP/Interior/Kids Room/mH_AcVent",
					"House/Prop GROUP/Interior/Kids Room/mH_BookSet04_Pen",
					"House/Prop GROUP/Interior/Kids Room/mH_JournalBook",
					"House/Prop GROUP/Interior/Kids Room/mH_LightSwitch (11)",
					"House/Prop GROUP/Interior/Kids Room/mH_NightLight",
					"House/Prop GROUP/Interior/Kids Room/mH_PowerOutlet",
					"House/Prop GROUP/Interior/Kitchen/FMGP_PRE_Bowl_of_Apples_1024",
					"House/Prop GROUP/Interior/Kitchen/FMGP_PRE_Bowl_of_Bananas_1024",
					"House/Prop GROUP/Interior/Kitchen/mH_PowerOutlet",
					"House/Prop GROUP/Interior/Kitchen/mH_PowerOutlet (1)",
					"House/Prop GROUP/Interior/Kitchen/PRE_PRO_Washing_liquid",
					"House/Prop GROUP/Interior/Kitchen/PRE_PRO_Condiment_01",
					"House/Prop GROUP/Interior/Kitchen/PRE_PRO_Condiment_02",
					"House/Prop GROUP/Interior/Kitchen/PRE_PRO_Pepper_shaker_01",
					"House/Prop GROUP/Interior/Kitchen/PRE_PRO_Salt_shaker_01",
					"House/Prop GROUP/Interior/Main Room/Book Set 04 GROUP",
					"House/Prop GROUP/Interior/Main Room/BookSet1 GROUP",
					"House/Prop GROUP/Interior/Main Room/Lightswitch GROUP",
					"House/Prop GROUP/Interior/Main Room/mH_AcVent",
					"House/Prop GROUP/Interior/Main Room/mH_PowerOutlet",
					"House/Prop GROUP/Interior/Master Bathroom/Bottle GROUP",
					"House/Prop GROUP/Interior/Master Bathroom/Towel Rack GROUP",
					"House/Prop GROUP/Interior/Master Bathroom/mH_AcVent",
					"House/Prop GROUP/Interior/Master Bathroom/mH_LightSwitch (2)",
					"House/Prop GROUP/Interior/Master Bathroom/mH_LotionBottle",
					"House/Prop GROUP/Interior/Master Bathroom/mH_LotionBottle (1)",
					"House/Prop GROUP/Interior/Master Bathroom/mH_PowerOutlet",
					"House/Prop GROUP/Interior/Master Bathroom/mH_PowerOutlet (1)",
					"House/Prop GROUP/Interior/Master Bathroom/mH_StackedRocks",
					"House/Prop GROUP/Interior/Master Bathroom/mH_ToiletPaper",
					"House/Prop GROUP/Interior/Master Bathroom/mH_Tray",
					"House/Prop GROUP/Interior/Master Bedroom/lightswitch GROUP",
					"House/Prop GROUP/Interior/Master Bedroom/mH_AcVent",
					"House/Prop GROUP/Interior/Office/Book Set 04 GROUP",
					"House/Prop GROUP/Interior/Office/BookSet1 GROUP",
					"House/Prop GROUP/Interior/Office/mH_AcVent",
					"House/Prop GROUP/Interior/Office/mH_Corkboard",
					"House/Prop GROUP/Interior/Office/mH_LightSwitch (12)",
					"House/Prop GROUP/Interior/Office/mH_PowerOutlet",
					"House/Prop GROUP/Interior/Office/mH_JournalBook",
					"House/Prop GROUP/Interior/Office/Open Book GROUP",
					"House/Prop GROUP/Interior/Upstairs Closet/mH_AcVent"
				};
			}
			else
			{
				result = new string[0];
			}
			return result;
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00105450 File Offset: 0x00103650
		internal void method_28()
		{
			this.method_25();
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00105464 File Offset: 0x00103664
		internal void method_29(GClass178.Enum12 enum12_0)
		{
			this.method_26(enum12_0);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00105478 File Offset: 0x00103678
		internal void method_30()
		{
			this.method_92();
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x0010548C File Offset: 0x0010368C
		internal string[] method_31(GClass178.Enum12 enum12_0)
		{
			string[] result;
			if (enum12_0 == GClass178.Enum12.const_1)
			{
				result = new string[]
				{
					"VRCChairs",
					"House/Prop GROUP/Interior/Main Room/mH_Chair03/VRCChair",
					"House/Prop GROUP/Interior/Main Room/Chair 03/mH_Chair03 (1)/VRCChair",
					"House/Prop GROUP/Interior/Main Room/Chair 03/mH_Chair03 (2)/VRCChair",
					"House/Prop GROUP/Interior/Main Room/Chair 03/mH_Chair03 (3)/VRCChair",
					"House/Prop GROUP/Interior/Main Room/Chair 03/mH_Chair03 (4)/VRCChair",
					"House/Prop GROUP/Interior/Main Room/Chair 03/mH_Chair03 (5)/VRCChair"
				};
			}
			else
			{
				result = new string[0];
			}
			return result;
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x001054E8 File Offset: 0x001036E8
		internal void method_32()
		{
			this.method_56();
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x001054FC File Offset: 0x001036FC
		internal void method_33()
		{
			this.method_7();
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00105510 File Offset: 0x00103710
		internal void method_34(bool bool_2)
		{
			this.method_51(bool_2);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00105524 File Offset: 0x00103724
		internal void method_35()
		{
			GameObject gameObject = GClass84.smethod_1733(GClass84.smethod_1010());
			if (gameObject)
			{
				Object.DestroyImmediate(gameObject, true);
			}
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x0010554C File Offset: 0x0010374C
		internal void method_36()
		{
			List<ReflectionProbe> list = this.method_79();
			if (list.Count > 0)
			{
				List<GameObject> list2 = new List<GameObject>();
				for (int i = 0; i < list.Count; i++)
				{
					list2.Add(list[i].gameObject);
				}
				GClass84.smethod_661<GameObject>(ref list2);
				GClass84.smethod_1233<GameObject>(list2);
				for (int j = 0; j < list2.Count; j++)
				{
					GClass70.smethod_38(GClass84.smethod_1324(list2[j]), GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					list.Count.ToString(),
					" ",
					"Reflection",
					" ",
					"Probes"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x0010562C File Offset: 0x0010382C
		internal void method_37()
		{
			this.method_24();
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00105640 File Offset: 0x00103840
		internal void method_38()
		{
			this.method_50();
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00105654 File Offset: 0x00103854
		internal void method_39()
		{
			this.method_91();
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00105668 File Offset: 0x00103868
		internal void method_40(GClass178.Enum12 enum12_0)
		{
			this.method_90(enum12_0);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x001056A4 File Offset: 0x001038A4
		internal void method_41(GClass178.Enum12 enum12_0)
		{
			this.method_95(enum12_0);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x001056B8 File Offset: 0x001038B8
		internal List<string> method_42(GameObject gameObject_0, bool bool_2 = false, bool bool_3 = true, GameObject gameObject_1 = null, bool bool_4 = false, List<Transform> list_0 = null, List<Transform> list_1 = null, List<Transform> list_2 = null)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> result;
			if (!gameObject_0)
			{
				result = list;
			}
			else
			{
				if (!gameObject_1)
				{
					gameObject_1 = gameObject_0;
				}
				if (list_0 == null)
				{
					list_0 = new List<Transform>();
				}
				Transform transform = gameObject_0.transform;
				if (!bool_4)
				{
					this.int_0 = 0;
					list_1 = GClass84.smethod_1135(transform);
					list_0.Clear();
					List<SkinnedMeshRenderer> list3 = gameObject_0.GetComponents<SkinnedMeshRenderer>().ToList<SkinnedMeshRenderer>();
					list3.AddRange(gameObject_0.GetComponentsInChildren<SkinnedMeshRenderer>(true));
					GClass84.smethod_661<SkinnedMeshRenderer>(ref list3);
					foreach (SkinnedMeshRenderer skinnedMeshRenderer in list3)
					{
						if (skinnedMeshRenderer)
						{
							list_0.AddRange(skinnedMeshRenderer.bones);
						}
					}
					list3.Clear();
					List<ScaleConstraint> list4 = gameObject_0.GetComponents<ScaleConstraint>().ToList<ScaleConstraint>();
					list4.AddRange(gameObject_0.GetComponentsInChildren<ScaleConstraint>(true));
					GClass84.smethod_661<ScaleConstraint>(ref list4);
					foreach (ScaleConstraint scaleConstraint in list4)
					{
						if (scaleConstraint)
						{
							for (int i = 0; i < scaleConstraint.sourceCount; i++)
							{
								ConstraintSource source = scaleConstraint.GetSource(i);
								if (source != null)
								{
									list_0.Add(source.sourceTransform);
								}
							}
						}
					}
					list4.Clear();
					List<ParentConstraint> list5 = gameObject_0.GetComponents<ParentConstraint>().ToList<ParentConstraint>();
					list5.AddRange(gameObject_0.GetComponentsInChildren<ParentConstraint>(true));
					GClass84.smethod_661<ParentConstraint>(ref list5);
					foreach (ParentConstraint parentConstraint in list5)
					{
						if (parentConstraint)
						{
							for (int j = 0; j < parentConstraint.sourceCount; j++)
							{
								ConstraintSource source2 = parentConstraint.GetSource(j);
								if (source2 != null)
								{
									list_0.Add(source2.sourceTransform);
								}
							}
						}
					}
					list5.Clear();
					List<EyeAndHeadAnimator> list6 = gameObject_0.GetComponents<EyeAndHeadAnimator>().ToList<EyeAndHeadAnimator>();
					list6.AddRange(gameObject_0.GetComponentsInChildren<EyeAndHeadAnimator>(true));
					GClass84.smethod_661<EyeAndHeadAnimator>(ref list6);
					foreach (EyeAndHeadAnimator eyeAndHeadAnimator in list6)
					{
						list_1.Add(eyeAndHeadAnimator.headBoneNonMecanimXform);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_1);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_0);
						list_1.Add(eyeAndHeadAnimator.Method_Public_get_Transform_0());
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_10);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_2);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_4);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_3);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_5);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_6);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_7);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_8);
						list_1.Add(eyeAndHeadAnimator.field_Private_Transform_9);
						list_1.AddRange(eyeAndHeadAnimator.field_Private_ArrayOf_Transform_0);
					}
					list6.Clear();
					List<PoseRecorder> list7 = gameObject_0.GetComponents<PoseRecorder>().ToList<PoseRecorder>();
					list7.AddRange(gameObject_0.GetComponentsInChildren<PoseRecorder>(true));
					GClass84.smethod_661<PoseRecorder>(ref list7);
					foreach (PoseRecorder poseRecorder in list7)
					{
						list_1.AddRange(poseRecorder.field_Public_ArrayOf_Transform_0);
						list_1.Add(poseRecorder.field_Internal_Transform_0);
					}
					list7.Clear();
					List<IKSolverTrigonometric> list8 = transform.GetComponents<IKSolverTrigonometric>().ToList<IKSolverTrigonometric>();
					list8.AddRange(transform.GetComponentsInChildren<IKSolverTrigonometric>(true));
					GClass84.smethod_661<IKSolverTrigonometric>(ref list8);
					foreach (IKSolverTrigonometric iksolverTrigonometric in list8)
					{
						list_1.Add(iksolverTrigonometric.target);
						if (iksolverTrigonometric.bone1 != null)
						{
							list_1.Add(iksolverTrigonometric.bone1.transform);
						}
						if (iksolverTrigonometric.bone2 != null)
						{
							list_1.Add(iksolverTrigonometric.bone2.transform);
						}
						if (iksolverTrigonometric.bone3 != null)
						{
							list_1.Add(iksolverTrigonometric.bone3.transform);
						}
					}
					list8.Clear();
					List<IKSolverHeuristic> list9 = transform.GetComponents<IKSolverHeuristic>().ToList<IKSolverHeuristic>();
					list9.AddRange(transform.GetComponentsInChildren<IKSolverHeuristic>(true));
					GClass84.smethod_661<IKSolverHeuristic>(ref list9);
					foreach (IKSolverHeuristic iksolverHeuristic in list9)
					{
						list_1.Add(iksolverHeuristic.target);
						foreach (IKSolver.Bone bone in iksolverHeuristic.bones)
						{
							list_1.Add(bone.transform);
						}
					}
					list9.Clear();
					List<IKSolver> list10 = transform.GetComponents<IKSolver>().ToList<IKSolver>();
					list10.AddRange(transform.GetComponentsInChildren<IKSolver>(true));
					GClass84.smethod_661<IKSolver>(ref list10);
					foreach (IKSolver iksolver in list10)
					{
						list_1.Add(iksolver.root);
						List<IKSolver.Point> list11 = iksolver.GetPoints().ToList<IKSolver.Point>();
						foreach (IKSolver.Point point in list11)
						{
							list_1.Add(point.transform);
						}
					}
					list10.Clear();
					List<VRIK> list12 = transform.GetComponents<VRIK>().ToList<VRIK>();
					list12.AddRange(transform.GetComponentsInChildren<VRIK>(true));
					GClass84.smethod_661<VRIK>(ref list12);
					foreach (VRIK vrik in list12)
					{
						VRIK.References references = vrik.references;
						if (references != null)
						{
							list_1.AddRange(references.GetTransforms());
							list_1.Add(references.leftHand);
							list_1.Add(references.rightToes);
							list_1.Add(references.rightFoot);
							list_1.Add(references.rightCalf);
							list_1.Add(references.rightThigh);
							list_1.Add(references.leftToes);
							list_1.Add(references.leftFoot);
							list_1.Add(references.leftCalf);
							list_1.Add(references.leftThigh);
							list_1.Add(references.rightHand);
							list_1.Add(references.rightForearm);
							list_1.Add(references.rightUpperArm);
							list_1.Add(references.leftForearm);
							list_1.Add(references.leftUpperArm);
							list_1.Add(references.leftShoulder);
							list_1.Add(references.head);
							list_1.Add(references.neck);
							list_1.Add(references.chest);
							list_1.Add(references.spine);
							list_1.Add(references.pelvis);
							list_1.Add(references.root);
							list_1.Add(references.rightShoulder);
						}
						IKSolverVR solver = vrik.solver;
						if (solver != null)
						{
							list_1.AddRange(solver.solverTransforms);
							IKSolverVR.Spine spine = solver.spine;
							IKSolverVR.Arm leftArm = solver.leftArm;
							IKSolverVR.Arm rightArm = solver.rightArm;
							IKSolverVR.Leg leftLeg = solver.leftLeg;
							IKSolverVR.Leg rightLeg = solver.rightLeg;
							IKSolverVR.Leg[] array = solver.legs;
							IKSolverVR.Arm[] array2 = solver.arms;
							if (spine != null)
							{
								list_1.Add(spine.headTarget);
								list_1.Add(spine.pelvisTarget);
								list_1.Add(spine.chestGoal);
							}
							if (leftArm != null)
							{
								list_1.Add(leftArm.target);
								list_1.Add(leftArm.bendGoal);
							}
							if (rightArm != null)
							{
								list_1.Add(rightArm.target);
								list_1.Add(rightArm.bendGoal);
							}
							if (leftLeg != null)
							{
								list_1.Add(leftLeg.bendGoal);
								list_1.Add(leftLeg.target);
							}
							if (rightLeg != null)
							{
								list_1.Add(rightLeg.bendGoal);
								list_1.Add(rightLeg.target);
							}
							foreach (IKSolverVR.Leg leg in array)
							{
								if (leg != null)
								{
									list_1.Add(leg.bendGoal);
									list_1.Add(leg.target);
								}
							}
							foreach (IKSolverVR.Arm arm in array2)
							{
								if (arm != null)
								{
									list_1.Add(arm.target);
									list_1.Add(arm.bendGoal);
								}
							}
						}
					}
					list12.Clear();
					List<CCDIK> list13 = transform.GetComponents<CCDIK>().ToList<CCDIK>();
					list13.AddRange(transform.GetComponentsInChildren<CCDIK>(true));
					GClass84.smethod_661<CCDIK>(ref list13);
					foreach (CCDIK ccdik in list13)
					{
						IKSolverCCD solver2 = ccdik.solver;
						if (solver2 != null)
						{
							list_1.Add(solver2.target);
							IKSolver.Bone[] array5 = solver2.bones;
							foreach (IKSolver.Bone bone2 in array5)
							{
								if (bone2 != null)
								{
									list_1.Add(bone2.transform);
								}
							}
						}
					}
					list13.Clear();
					List<LimbIK> list14 = transform.GetComponents<LimbIK>().ToList<LimbIK>();
					list14.AddRange(transform.GetComponentsInChildren<LimbIK>(true));
					GClass84.smethod_661<LimbIK>(ref list14);
					foreach (LimbIK limbIK in list14)
					{
						list_1.Add(limbIK.field_Public_Transform_0);
						list_1.Add(limbIK.field_Public_Transform_1);
						list_1.Add(limbIK.field_Public_Transform_2);
					}
					list14.Clear();
					List<LimbIK> list15 = transform.GetComponents<LimbIK>().ToList<LimbIK>();
					list15.AddRange(transform.GetComponentsInChildren<LimbIK>(true));
					GClass84.smethod_661<LimbIK>(ref list15);
					foreach (LimbIK limbIK2 in list15)
					{
						IKSolverLimb solver3 = limbIK2.solver;
						if (solver3 != null)
						{
							list_1.Add(solver3.bendGoal);
							list_1.Add(solver3.target);
							if (solver3.bone1 != null)
							{
								list_1.Add(solver3.bone1.transform);
							}
							if (solver3.bone2 != null)
							{
								list_1.Add(solver3.bone2.transform);
							}
							if (solver3.bone3 != null)
							{
								list_1.Add(solver3.bone3.transform);
							}
						}
					}
					list15.Clear();
					List<Animator> list16 = transform.GetComponents<Animator>().ToList<Animator>();
					list16.AddRange(transform.GetComponentsInChildren<Animator>(true));
					GClass84.smethod_661<Animator>(ref list16);
					List<string> list17 = GClass84.smethod_75<HumanBodyBones>();
					foreach (Animator animator in list16)
					{
						for (int n = 0; n < list17.Count - 1; n++)
						{
							HumanBodyBones humanBodyBones = GClass84.smethod_1563<HumanBodyBones>(list17[n]);
							Transform boneTransform = animator.GetBoneTransform(humanBodyBones);
							if (boneTransform)
							{
								list_1.Add(boneTransform);
							}
						}
					}
					list16.Clear();
					GClass84.smethod_661<Transform>(ref list_0);
					GClass84.smethod_1233<Transform>(list_0);
					GClass84.smethod_661<Transform>(ref list_1);
					GClass84.smethod_1233<Transform>(list_1);
				}
				Transform[] array7 = GClass84.smethod_1141(transform);
				for (int num = 0; num < array7.Length; num++)
				{
					if (array7[num])
					{
						if (bool_2)
						{
							list2.AddRange(this.method_42(array7[num].gameObject, true, bool_3, gameObject_1, true, list_0, list_1, list_2));
						}
						else
						{
							this.method_42(array7[num].gameObject, false, bool_3, gameObject_1, true, list_0, list_1, list_2);
						}
					}
				}
				if (bool_4 && transform.childCount == 0 && (!GClass84.smethod_1224<Transform>(list_0, transform) && !GClass84.smethod_1224<Transform>(list_0, transform.parent) && !GClass84.smethod_1224<Transform>(list_1, transform) && !GClass84.smethod_1224<Transform>(list_2, transform)))
				{
					Il2CppArrayBase<Component> components = gameObject_0.GetComponents<Component>();
					if (components.Count < 3)
					{
						bool flag = true;
						foreach (Component component in components)
						{
							if (component && component != transform && !component.TryCast<NetworkMetadata>())
							{
								flag = false;
								break;
							}
						}
						if (flag && gameObject_0.name != "HmdPivot")
						{
							if (bool_2)
							{
								list.Add(GClass84.smethod_920(gameObject_0, gameObject_1));
							}
							if (bool_3)
							{
								GClass84.smethod_890(gameObject_0, false);
							}
							this.int_0++;
						}
					}
				}
				if (bool_2)
				{
					list.AddRange(list2);
					list2.Clear();
				}
				if (!bool_4)
				{
					if (this.int_0 > 0)
					{
						while (GClass84.smethod_681(gameObject_0))
						{
							if (bool_2)
							{
								List<string> list18 = this.method_42(gameObject_0, true, bool_3, gameObject_1, true, list_0, list_1, list_2);
								if (list18.Count == 0)
								{
									break;
								}
								list.AddRange(list18);
								list18.Clear();
							}
							else
							{
								this.method_42(gameObject_0, false, bool_3, gameObject_1, true, list_0, list_1, list_2);
							}
						}
					}
					this.int_1 = this.int_0;
					this.int_0 = 0;
				}
				result = list;
			}
			return result;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x0010661C File Offset: 0x0010481C
		internal void method_43(GameObject gameObject_0)
		{
			this.method_3(gameObject_0);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00106630 File Offset: 0x00104830
		internal void method_44()
		{
			List<GameObject> list = GClass84.smethod_1051();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					GClass70.smethod_38(GClass84.smethod_1324(list[i]), GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					list.Count.ToString(),
					" ",
					"Mirrors"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x001066BC File Offset: 0x001048BC
		private static HarmonyMethod smethod_0(string string_1)
		{
			return new HarmonyMethod(typeof(GClass178).GetMethod(string_1, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x001066E4 File Offset: 0x001048E4
		internal void method_45()
		{
			this.method_13();
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x001066F8 File Offset: 0x001048F8
		internal void method_46()
		{
			this.method_5();
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x0010670C File Offset: 0x0010490C
		internal void method_47()
		{
			List<GameObject> list = GClass84.smethod_171();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(true);
			}
			list.Clear();
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00106748 File Offset: 0x00104948
		internal void method_48()
		{
			this.method_57();
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x0010675C File Offset: 0x0010495C
		internal void method_49()
		{
			this.method_81();
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00106770 File Offset: 0x00104970
		internal void method_50()
		{
			GameObject[] array = GClass84.smethod_1215(false, false, false);
			int num = 0;
			List<Transform> list = this.method_21();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].name != "VRC_OBJECTS")
				{
					this.method_42(array[i], false, true, null, false, null, null, list);
					num += this.int_1;
				}
			}
			list.Clear();
			if (num > 0)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					num.ToString(),
					" ",
					"Useless",
					" ",
					"Objects",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00106838 File Offset: 0x00104A38
		internal void method_51(bool bool_2)
		{
			this.bool_1 = bool_2;
			this.gclass188_0.bool_1 = bool_2;
			GClass188.smethod_2();
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00106860 File Offset: 0x00104A60
		internal void method_52()
		{
			this.method_33();
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00106874 File Offset: 0x00104A74
		internal void method_53()
		{
			this.method_15();
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00106888 File Offset: 0x00104A88
		internal void method_54(bool bool_2)
		{
			this.method_94(bool_2);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0010689C File Offset: 0x00104A9C
		internal void method_55()
		{
			this.method_30();
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x001068B0 File Offset: 0x00104AB0
		public override void vmethod_6(GameObject gameObject_0, GameObject gameObject_1)
		{
			this.method_64(gameObject_0, gameObject_1);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x001068C8 File Offset: 0x00104AC8
		internal void method_56()
		{
			this.method_23();
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x001068DC File Offset: 0x00104ADC
		internal void method_57()
		{
			this.method_66();
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x001068F0 File Offset: 0x00104AF0
		internal void method_58()
		{
			this.method_9();
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00106904 File Offset: 0x00104B04
		internal void method_59(bool bool_2)
		{
			this.method_34(bool_2);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00106918 File Offset: 0x00104B18
		internal void method_60()
		{
			List<GameObject> list = GClass84.smethod_1265();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					GClass70.smethod_38(GClass84.smethod_1324(list[i]), GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					list.Count.ToString(),
					" ",
					"Portals"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x001069A4 File Offset: 0x00104BA4
		internal void method_61(GClass178.Enum12 enum12_0)
		{
			this.method_29(enum12_0);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x001069B8 File Offset: 0x00104BB8
		internal void method_62()
		{
			this.method_60();
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x001069CC File Offset: 0x00104BCC
		internal void method_63(GClass178.Enum12 enum12_0)
		{
			string[] array = this.method_31(enum12_0);
			for (int i = 0; i < array.Length; i++)
			{
				GameObject gameObject = GameObject.Find(array[i]);
				if (!gameObject)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						array[i],
						" ",
						"Is",
						" ",
						"Not",
						" ",
						"Found"
					}), GClass70.Enum1.const_0);
				}
				Object.DestroyImmediate(gameObject, true);
			}
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00106A54 File Offset: 0x00104C54
		internal void method_64(GameObject gameObject_0, GameObject gameObject_1)
		{
			this.method_69(gameObject_0, gameObject_1);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x00106A6C File Offset: 0x00104C6C
		internal void method_65()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_16.Add(new Action<GameObject, GameObject>(this.vmethod_6));
			GClass188.smethod_4();
			GClass64.smethod_1();
			this.gclass188_0 = GClass188.gclass188_0;
			GClass178.bool_0 = this.gclass188_0.bool_0;
			this.bool_1 = this.gclass188_0.bool_1;
			try
			{
				GClass84.smethod_799(typeof(PerformanceScannerSet), "RunPerformanceScanEnumerator", GClass178.smethod_0("CalculatePerformance"), null, null);
			}
			catch (Exception ex)
			{
				ConsoleColor consoleColor_ = ConsoleColor.DarkRed;
				string str = "Failed to patch Performance Scanners";
				string str2 = ": ";
				Exception ex2 = ex;
				GClass70.smethod_117(consoleColor_, str + str2 + ((ex2 != null) ? ex2.ToString() : null), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00106B38 File Offset: 0x00104D38
		public override void vmethod_23()
		{
			this.method_93();
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00106B4C File Offset: 0x00104D4C
		internal void method_66()
		{
			GameObject[] array = GClass84.smethod_1215(false, false, false);
			int num = 0;
			List<Transform> list = this.method_21();
			for (int i = 0; i < array.Length; i++)
			{
				string name = array[i].name;
				if (!(name == "VRC_OBJECTS"))
				{
					List<string> list2 = this.method_42(array[i], true, false, null, false, null, null, list);
					for (int j = 0; j < list2.Count; j++)
					{
						GClass70.smethod_38(name + "/" + list2[j], GClass70.Enum1.const_0);
					}
					list2.Clear();
					num += this.int_1;
				}
			}
			list.Clear();
			if (num > 0)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					num.ToString(),
					" ",
					"Useless",
					" ",
					"Objects"
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00106C40 File Offset: 0x00104E40
		internal void method_67()
		{
			this.method_62();
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00106C54 File Offset: 0x00104E54
		private static bool smethod_1()
		{
			return GClass178.bool_0;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00106C68 File Offset: 0x00104E68
		internal void method_68()
		{
			this.method_28();
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00106C7C File Offset: 0x00104E7C
		internal void method_69(GameObject gameObject_0, GameObject gameObject_1)
		{
			if (gameObject_0 && (gameObject_0.name == "PortalInternal(Clone)" || gameObject_0.name == "PortalInternalDynamic(Clone)") && this.bool_1)
			{
				this.method_20(gameObject_0);
			}
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00106CCC File Offset: 0x00104ECC
		internal void method_70()
		{
			this.method_35();
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00106CE0 File Offset: 0x00104EE0
		internal void method_71()
		{
			List<GameObject> list = GClass84.smethod_171();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					GClass70.smethod_38(GClass84.smethod_1324(list[i]), GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					list.Count.ToString(),
					" ",
					"Avatar",
					" ",
					"Pedestals"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00106D7C File Offset: 0x00104F7C
		public override void vmethod_10()
		{
			this.method_70();
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00106D90 File Offset: 0x00104F90
		internal void method_72(GClass178.Enum12 enum12_0)
		{
			this.method_63(enum12_0);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00106DA4 File Offset: 0x00104FA4
		internal void method_73()
		{
			this.method_16();
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00106DB8 File Offset: 0x00104FB8
		internal void method_74()
		{
			List<GameObject> list = GClass84.smethod_314();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Object.Destroy(list[i]);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					list.Count.ToString(),
					" ",
					"Particles",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00106E50 File Offset: 0x00105050
		internal void method_75()
		{
			this.method_38();
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00106E64 File Offset: 0x00105064
		internal void method_76()
		{
			this.method_74();
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x00106E78 File Offset: 0x00105078
		internal void method_77()
		{
			List<GameObject> list = GClass84.smethod_314();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					GClass70.smethod_38(GClass84.smethod_1324(list[i]), GClass70.Enum1.const_0);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Found",
					" ",
					list.Count.ToString(),
					" ",
					"Particles"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00106F04 File Offset: 0x00105104
		internal void method_78()
		{
			this.method_10();
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00106F18 File Offset: 0x00105118
		internal List<ReflectionProbe> method_79()
		{
			List<ReflectionProbe> list = new List<ReflectionProbe>();
			List<GameObject> list2 = GClass84.smethod_549(false, false, false);
			for (int i = 0; i < list2.Count; i++)
			{
				list.AddRange(list2[i].GetComponents<ReflectionProbe>());
				list.AddRange(list2[i].GetComponentsInChildren<ReflectionProbe>(true));
			}
			list2.Clear();
			GClass84.smethod_661<ReflectionProbe>(ref list);
			return list;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00106F80 File Offset: 0x00105180
		internal void method_80(bool bool_2)
		{
			GClass178.bool_0 = bool_2;
			this.gclass188_0.bool_0 = bool_2;
			GClass188.smethod_2();
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00106FA4 File Offset: 0x001051A4
		internal void method_81()
		{
			this.method_47();
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00106FB8 File Offset: 0x001051B8
		internal void method_82()
		{
			List<GameObject> list = GClass84.smethod_1051();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(true);
			}
			list.Clear();
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00106FF4 File Offset: 0x001051F4
		internal void method_83()
		{
			this.method_39();
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00107008 File Offset: 0x00105208
		internal void method_84(GClass178.Enum12 enum12_0)
		{
			this.method_41(enum12_0);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x0010701C File Offset: 0x0010521C
		internal void method_85()
		{
			this.method_14();
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00107030 File Offset: 0x00105230
		internal void method_86()
		{
			List<GameObject> list = GClass84.smethod_171();
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Object.Destroy(list[i]);
				}
				GClass70.smethod_38(string.Concat(new string[]
				{
					list.Count.ToString(),
					" ",
					"Avatar",
					" ",
					"Pedestals",
					" ",
					"Were",
					" ",
					"Removed"
				}), GClass70.Enum1.const_0);
				list.Clear();
			}
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x001070DC File Offset: 0x001052DC
		internal void method_87()
		{
			this.method_89();
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x001070F0 File Offset: 0x001052F0
		internal void method_88()
		{
			this.method_76();
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00107104 File Offset: 0x00105304
		internal void method_89()
		{
			List<GameObject> list = GClass84.smethod_1265();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(true);
			}
			list.Clear();
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00107140 File Offset: 0x00105340
		internal void method_90(GClass178.Enum12 enum12_0)
		{
			this.method_17(enum12_0);
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00107154 File Offset: 0x00105354
		internal void method_91()
		{
			List<GameObject> list = GClass84.smethod_314();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(false);
			}
			list.Clear();
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00107190 File Offset: 0x00105390
		internal void method_92()
		{
			List<GameObject> list = GClass84.smethod_1051();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(false);
			}
			list.Clear();
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x001071CC File Offset: 0x001053CC
		internal void method_93()
		{
			this.method_65();
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x001071E0 File Offset: 0x001053E0
		internal void method_94(bool bool_2)
		{
			this.method_80(bool_2);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x001071F4 File Offset: 0x001053F4
		internal void method_95(GClass178.Enum12 enum12_0)
		{
			string[] array = this.method_27(enum12_0);
			for (int i = 0; i < array.Length; i++)
			{
				GameObject gameObject = GameObject.Find(array[i]);
				if (!gameObject)
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						array[i],
						" ",
						"Is",
						" ",
						"Not",
						" ",
						"Found"
					}), GClass70.Enum1.const_0);
				}
				Object.DestroyImmediate(gameObject, true);
			}
		}

		// Token: 0x04001A8A RID: 6794
		internal static bool bool_0;

		// Token: 0x04001A8B RID: 6795
		internal int int_0 = 0;

		// Token: 0x04001A8C RID: 6796
		internal int int_1 = 0;

		// Token: 0x04001A8D RID: 6797
		internal GClass188 gclass188_0;

		// Token: 0x04001A8E RID: 6798
		internal bool bool_1 = true;

		// Token: 0x0200032F RID: 815
		internal enum Enum12
		{
			// Token: 0x04001A90 RID: 6800
			const_0,
			// Token: 0x04001A91 RID: 6801
			const_1
		}
	}
}
