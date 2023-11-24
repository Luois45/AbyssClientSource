using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ns185;
using ns241;
using ns268;
using ns276;
using ns341;
using ns349;
using ns384;
using ns425;
using ns519;
using ns523;
using ns545;
using ns75;
using RealisticEyeMovements;
using RootMotion.FinalIK;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace ns441
{
	// Token: 0x02000150 RID: 336
	public class GClass145 : GClass130
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00032484 File Offset: 0x00030684
		private void method_2(DynamicBone dynamicBone_0, string string_3, ConsoleColor consoleColor_0, bool bool_168)
		{
			if (dynamicBone_0 && dynamicBone_0.m_Root)
			{
				if (dynamicBone_0.m_UpdateRate > this.float_11)
				{
					if (bool_168 && this.int_47 < this.int_46)
					{
						string str = string.Concat(new string[]
						{
							": ",
							dynamicBone_0.m_Root.name,
							" ",
							"Used",
							" ",
							"Too",
							" ",
							"Many",
							" ",
							"Updates",
							" ",
							"Per",
							" ",
							"Second",
							" ",
							"For",
							" ",
							"Dynamic",
							" ",
							"Bone",
							" (",
							dynamicBone_0.m_UpdateRate.ToString(),
							")",
							". ",
							"Changed",
							" ",
							"To",
							" ",
							this.float_11.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str);
						}
						this.int_47++;
					}
					dynamicBone_0.m_UpdateRate = this.float_11;
				}
				bool flag = false;
				List<Transform> list = GClass84.smethod_1687(dynamicBone_0.m_Root, this.int_30);
				int i = 0;
				IL_236:
				while (i < list.Count)
				{
					bool flag2 = true;
					foreach (Transform transform in dynamicBone_0.m_Exclusions)
					{
						if (transform == list[i])
						{
							flag2 = false;
							IL_217:
							if (flag2)
							{
								flag = true;
								dynamicBone_0.m_Exclusions.Add(list[i]);
							}
							i++;
							goto IL_236;
						}
					}
					goto IL_217;
				}
				if (flag && bool_168)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						dynamicBone_0.m_Root.name,
						" ",
						"Dynamic",
						" ",
						"Bone",
						" ",
						"Length",
						" ",
						"Is",
						" ",
						"Limited",
						" ",
						"To",
						" ",
						this.int_30.ToString()
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000327C0 File Offset: 0x000309C0
		internal void method_3(bool bool_168)
		{
			this.bool_63 = bool_168;
			this.gclass40_0.bool_50 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000327E8 File Offset: 0x000309E8
		internal bool method_4(string string_3, string string_4)
		{
			return !(string_3 == string.Empty) && this.method_465(new GClass145.GStruct102(string_3, string_4));
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00032818 File Offset: 0x00030A18
		internal void method_5(bool bool_168)
		{
			this.method_133(bool_168);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0003282C File Offset: 0x00030A2C
		private void method_6(float float_17)
		{
			this.method_93(float_17);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00032840 File Offset: 0x00030A40
		internal void method_7(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			this.method_187(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00032864 File Offset: 0x00030A64
		internal void method_8(bool bool_168)
		{
			this.method_32(bool_168);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00032878 File Offset: 0x00030A78
		internal void method_9(bool bool_168)
		{
			this.bool_53 = bool_168;
			this.gclass40_0.bool_40 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000328A0 File Offset: 0x00030AA0
		internal void method_10(bool bool_168)
		{
			this.method_290(bool_168);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000328B4 File Offset: 0x00030AB4
		internal void method_11(bool bool_168)
		{
			this.method_560(bool_168);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000328C8 File Offset: 0x00030AC8
		internal void method_12(bool bool_168)
		{
			this.method_403(bool_168);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000328DC File Offset: 0x00030ADC
		private static HarmonyMethod smethod_0(string string_3)
		{
			return new HarmonyMethod(typeof(GClass145).GetMethod(string_3, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00032904 File Offset: 0x00030B04
		internal void method_13(bool bool_168)
		{
			this.method_148(bool_168);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00032918 File Offset: 0x00030B18
		internal void method_14(bool bool_168)
		{
			this.method_534(bool_168);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0003292C File Offset: 0x00030B2C
		internal void method_15(bool bool_168)
		{
			this.method_431(bool_168);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00032940 File Offset: 0x00030B40
		internal void method_16(bool bool_168)
		{
			this.method_549(bool_168);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00032954 File Offset: 0x00030B54
		private void method_17(List<Object> list_30)
		{
			this.method_284(list_30);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00032968 File Offset: 0x00030B68
		internal unsafe void method_18()
		{
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_11.Add(new Action(this.vmethod_22));
			GClass84.list_28.Add(new Action(this.vmethod_18));
			GClass84.list_29.Add(new Action(this.vmethod_1));
			this.method_420();
			this.method_61();
			if (!this.bool_2)
			{
				try
				{
					List<MethodInfo> list = typeof(AssetManagement).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public).Where(new Func<MethodInfo, bool>(GClass145.Class85.class85_0.method_2)).ToList<MethodInfo>();
					foreach (MethodInfo methodInfo in list)
					{
						GClass145.Class82 @class = new GClass145.Class82();
						IntPtr ptr = *(IntPtr*)((void*)((IntPtr)UnhollowerUtils.GetIl2CppMethodInfoPointerFieldForGeneratedMethod(methodInfo).GetValue(null)));
						@class.delegate11_0 = null;
						GClass145.Delegate11 @delegate = new GClass145.Delegate11(@class.method_0);
						GClass145.list_0.Add(@delegate);
						MelonUtils.NativeHookAttach((IntPtr)((void*)(&ptr)), Marshal.GetFunctionPointerForDelegate<GClass145.Delegate11>(@delegate));
						@class.delegate11_0 = Marshal.GetDelegateForFunctionPointer<GClass145.Delegate11>(ptr);
					}
				}
				catch (Exception ex)
				{
					GClass145.smethod_2(ex.ToString());
				}
				try
				{
					foreach (Type type in typeof(VRCAvatarManager).GetNestedTypes())
					{
						GClass145.Class83 class2 = new GClass145.Class83();
						MethodInfo method = type.GetMethod("MoveNext");
						if (!(method == null))
						{
							PropertyInfo propertyInfo = type.GetProperties().SingleOrDefault(new Func<PropertyInfo, bool>(GClass145.Class85.class85_0.method_0));
							if (!(propertyInfo == null))
							{
								class2.int_0 = (int)IL2CPP.il2cpp_field_get_offset((IntPtr)UnhollowerUtils.GetIl2CppFieldInfoPointerFieldForGeneratedFieldAccessor(propertyInfo.GetMethod).GetValue(null));
								GClass145.Class84 class3 = new GClass145.Class84();
								class3.class83_0 = class2;
								IntPtr intPtr = *(IntPtr*)((void*)((IntPtr)UnhollowerUtils.GetIl2CppMethodInfoPointerFieldForGeneratedMethod(method).GetValue(null)));
								intPtr = XrefScannerLowLevel.JumpTargets(intPtr).First<IntPtr>();
								class3.delegate10_0 = null;
								GClass145.Delegate10 delegate2 = new GClass145.Delegate10(class3.method_0);
								GClass145.list_0.Add(delegate2);
								MelonUtils.NativeHookAttach((IntPtr)((void*)(&intPtr)), Marshal.GetFunctionPointerForDelegate<GClass145.Delegate10>(delegate2));
								class3.delegate10_0 = Marshal.GetDelegateForFunctionPointer<GClass145.Delegate10>(intPtr);
							}
						}
					}
				}
				catch (Exception ex2)
				{
					GClass145.smethod_2(ex2.ToString());
				}
				try
				{
					foreach (MethodInfo methodBase_ in typeof(FeaturePermissionManager).GetMethods().Where(new Func<MethodInfo, bool>(GClass145.Class85.class85_0.method_3)))
					{
						GClass84.smethod_208(methodBase_, null, GClass145.smethod_0("CanUseCustomAvatarPostfix"), null);
					}
				}
				catch (Exception ex3)
				{
					GClass145.smethod_2(ex3.ToString());
				}
				try
				{
					SHA512 sha = SHA512.Create();
					FileStream inputStream = File.OpenRead("UnityPlayer.dll");
					string text = Convert.ToBase64String(sha.ComputeHash(inputStream));
					ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>> valueTuple;
					if (!GClass145.dictionary_0.TryGetValue(text, out valueTuple))
					{
						GClass145.smethod_2("Unknown UnityPlayer hash" + ": " + text);
						GClass145.smethod_2("Some features will not work");
						return;
					}
					foreach (object obj in Process.GetCurrentProcess().Modules)
					{
						ProcessModule processModule = (ProcessModule)obj;
						if (processModule.FileName.Contains("UnityPlayer"))
						{
							GClass145.smethod_47<GClass145.Delegate23>(processModule, valueTuple.Item1, new GClass145.Delegate23(GClass145.smethod_8), out GClass145.delegate23_0);
							GClass145.smethod_47<GClass145.Delegate24>(processModule, valueTuple.Item2, new GClass145.Delegate24(GClass145.smethod_62), out GClass145.delegate24_0);
							GClass145.Delegate21 delegate3;
							GClass145.smethod_47<GClass145.Delegate21>(processModule, valueTuple.Item4, new GClass145.Delegate21(GClass145.smethod_40), out delegate3);
							GClass145.smethod_47<GClass145.Delegate20>(processModule, valueTuple.Item5, new GClass145.Delegate20(GClass145.smethod_6), out GClass145.delegate20_0);
							GClass145.smethod_47<GClass145.Delegate19>(processModule, valueTuple.Item6, new GClass145.Delegate19(GClass145.smethod_5), out GClass145.delegate19_0);
							GClass145.smethod_47<GClass145.Delegate22>(processModule, valueTuple.Item7, new GClass145.Delegate22(GClass145.smethod_36), out GClass145.delegate22_0);
							GClass145.smethod_47<GClass145.Delegate13>(processModule, valueTuple.Rest.Item1, new GClass145.Delegate13(GClass145.smethod_15), out GClass145.delegate13_0);
							GClass145.smethod_47<GClass145.Delegate12>(processModule, valueTuple.Rest.Item2, new GClass145.Delegate12(GClass145.smethod_30), out GClass145.delegate12_0);
							break;
						}
					}
				}
				catch (Exception ex4)
				{
					GClass145.smethod_2(ex4.ToString());
				}
				SceneManager.sceneLoaded += new Action<Scene, LoadSceneMode>(GClass145.Class85.class85_0.method_5);
				SceneManager.sceneUnloaded += new Action<Scene>(GClass145.Class85.class85_0.method_4);
				GClass84.smethod_1323(typeof(VRCAvatarManager), "Method_Public_Void_ApiAvatar_", new Type[]
				{
					typeof(ApiAvatar)
				}, GClass145.smethod_0("VRCAvatarManager_Method_Public_Void_ApiAvatar"), null, null);
				GClass84.smethod_1323(typeof(VRCAvatarManager), "Method_Private_Void_ApiAvatar_", new Type[]
				{
					typeof(ApiAvatar)
				}, GClass145.smethod_0("VRCAvatarManager_Method_Private_Void_ApiAvatar"), null, null);
				GClass84.smethod_1323(typeof(VRCAvatarManager), "Method_Private_Void_ApiAvatar_String_", new Type[]
				{
					typeof(ApiAvatar),
					typeof(string)
				}, GClass145.smethod_0("VRCAvatarManager_Method_Private_Void_ApiAvatar_String"), null, null);
				GClass84.smethod_1119(typeof(AssetBundleDownloadManager), "Method_Internal_Void_ApiAvatar_", GClass145.smethod_0("AssetBundleDownloadManager_Method_Internal_Void_ApiAvatar"), null, null);
				GClass84.smethod_1119(typeof(AssetBundleDownloadManager), "Method_Internal_Nullable_1_Int32_ApiAvatar_", GClass145.smethod_0("AssetBundleDownloadManager_Method_Internal_Nullable_1_Int32_ApiAvatar"), null, null);
				GClass84.smethod_1119(typeof(SimpleAvatarPedestal), "Method_Public_Void_ApiAvatar_", GClass145.smethod_0("SimpleAvatarPedestal_Method_Public_Void_ApiAvatar"), null, null);
				GClass84.smethod_1119(typeof(SimpleAvatarPedestal), "Method_Private_Void_IEnumerator_", GClass145.smethod_0("SimpleAvatarPedestal_IEnumerator"), null, null);
				foreach (MethodInfo methodInfo2 in typeof(AssetBundle).GetMethods(BindingFlags.Static | BindingFlags.Public))
				{
					string name = methodInfo2.Name;
					string a = name;
					if (!(a == "LoadFromFile"))
					{
						if (a == "LoadFromFile_Internal")
						{
							this.method_228(methodInfo2, "OnLoadFromFile_Internal", null);
						}
					}
					else
					{
						int num = methodInfo2.GetParameters().Length;
						int num2 = num;
						if (num2 == 1)
						{
							this.method_228(methodInfo2, "OnLoadFromFile_1", null);
						}
					}
				}
				this.method_228(typeof(AssetBundleDownload).GetMethod("Method_Private_Static_String_String_String_Int32_String_String_String_0"), "OnCreateAssetBundleDownload", null);
				this.method_228(typeof(AssetBundleDownload).GetMethod("Method_Public_InterfacePublicAbstractIDisposableAsObAsUnique_0"), "OnGetAssetBundleGetter", null);
				this.method_228(typeof(AssetBundleDownload).GetMethod("Method_Public_InterfacePublicAbstractIDisposableGaObGaUnique_0"), "OnGetGameObjectGetter", null);
				GClass145.smethod_25<GClass145.Delegate14>("UnityEngine.AssetBundle::LoadFromFileAsync_Internal", out GClass145.delegate14_0, "OnLoadFromFileAsync_Internal");
				GClass145.smethod_25<GClass145.Delegate17>("UnityEngine.AssetBundle::LoadFromMemory_Internal", out GClass145.delegate17_0, "OnLoadFromMemory_Internal");
				GClass145.smethod_25<GClass145.Delegate18>("UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal", out GClass145.delegate18_0, "OnLoadFromMemoryAsync_Internal");
				GClass145.smethod_25<GClass145.Delegate15>("UnityEngine.AssetBundle::LoadFromStreamInternal", out GClass145.delegate15_0, "OnLoadFromStream_Internal");
				GClass145.smethod_25<GClass145.Delegate16>("UnityEngine.AssetBundle::LoadFromStreamAsyncInternal", out GClass145.delegate16_0, "OnLoadFromStreamAsync_Internal");
				GClass92.smethod_5();
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000331EC File Offset: 0x000313EC
		private void method_19(Transform transform_0, Transform transform_1, ParticleSystem particleSystem_0, string string_3, ConsoleColor consoleColor_0, ref List<GClass145.GStruct99> list_30, ref int int_54, ref int int_55, ref int int_56, ref List<Object> list_31, bool bool_168, bool bool_169)
		{
			this.method_269(transform_0, transform_1, particleSystem_0, string_3, consoleColor_0, ref list_30, ref int_54, ref int_55, ref int_56, ref list_31, bool_168, bool_169);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00033228 File Offset: 0x00031428
		public override void vmethod_19()
		{
			this.method_373();
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0003323C File Offset: 0x0003143C
		internal void method_20(GameObject gameObject_0, bool bool_168 = false)
		{
			this.method_181(gameObject_0, bool_168);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00033254 File Offset: 0x00031454
		private void method_21(List<Object> list_30)
		{
			if (list_30.Count != 0)
			{
				this.list_16.AddRange(list_30);
				GClass84.smethod_661<Object>(ref this.list_16);
				GClass84.smethod_1233<Object>(this.list_16);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00033290 File Offset: 0x00031490
		private bool method_22(string string_3)
		{
			if (this.bool_155)
			{
				this.method_426(string_3);
			}
			for (int i = this.list_9.Count - 1; i >= 0; i--)
			{
				if (this.list_9[i] == string_3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000332E8 File Offset: 0x000314E8
		internal void method_23(bool bool_168)
		{
			this.method_59(bool_168);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000332FC File Offset: 0x000314FC
		internal bool method_24(string string_3, string string_4)
		{
			return !(string_3 == string.Empty) && this.method_226(new GClass145.GStruct102(string_3, string_4));
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0003332C File Offset: 0x0003152C
		internal bool method_25(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForUselessComponents();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				bool flag = this.bool_8 && bool_170 && this.bool_59 && (!bool_168 || (!this.bool_60 && !this.bool_9));
				Il2CppArrayBase<VRC_AvatarDescriptor> componentsInChildren = transform_0.GetComponentsInChildren<VRC_AvatarDescriptor>(true);
				for (int i = componentsInChildren.Count - 1; i >= 0; i--)
				{
					if (componentsInChildren[i].transform != transform_0)
					{
						GClass84.smethod_761(componentsInChildren[i]);
						num++;
					}
				}
				Il2CppArrayBase<PipelineManager> componentsInChildren2 = transform_0.GetComponentsInChildren<PipelineManager>(true);
				for (int j = componentsInChildren2.Count - 1; j >= 0; j--)
				{
					if (componentsInChildren2[j].transform != transform_0)
					{
						GClass84.smethod_761(componentsInChildren2[j]);
						num++;
					}
				}
				Il2CppArrayBase<Animator> componentsInChildren3 = transform_0.GetComponentsInChildren<Animator>(true);
				for (int k = componentsInChildren3.Count - 1; k >= 0; k--)
				{
					if (!componentsInChildren3[k].runtimeAnimatorController && componentsInChildren3[k].transform != transform_0)
					{
						GClass84.smethod_1648(componentsInChildren3[k]);
						num3++;
					}
				}
				List<MeshRenderer> list = transform_0.GetComponents<MeshRenderer>().ToList<MeshRenderer>();
				list.AddRange(transform_0.GetComponentsInChildren<MeshRenderer>(true));
				for (int l = list.Count - 1; l >= 0; l--)
				{
					if (list[l])
					{
						Il2CppArrayBase<MeshFilter> components = list[l].GetComponents<MeshFilter>();
						bool flag2 = false;
						int m = components.Count - 1;
						while (m >= 0)
						{
							if (!components[m].sharedMesh || components[m].sharedMesh.vertexCount == 0)
							{
								GClass84.smethod_505(components[m], false);
								num2++;
								m--;
							}
							else
							{
								flag2 = true;
								IL_267:
								if (!flag2)
								{
									GClass84.smethod_424(list[l]);
									num4++;
									goto IL_2AE;
								}
								if (list[l].GetSharedMaterialArray().Length == 0)
								{
									GClass84.smethod_424(list[l]);
									num9++;
									goto IL_2AE;
								}
								goto IL_2AE;
							}
						}
						goto IL_267;
					}
					IL_2AE:;
				}
				list.Clear();
				List<MeshFilter> list2 = transform_0.GetComponents<MeshFilter>().ToList<MeshFilter>();
				list2.AddRange(transform_0.GetComponentsInChildren<MeshFilter>(true));
				for (int n = list2.Count - 1; n >= 0; n--)
				{
					if (list2[n])
					{
						Il2CppArrayBase<MeshRenderer> components2 = list2[n].GetComponents<MeshRenderer>();
						if (!list2[n].sharedMesh || list2[n].sharedMesh.vertexCount == 0)
						{
							for (int num11 = components2.Count - 1; num11 >= 0; num11--)
							{
								GClass84.smethod_424(components2[num11]);
								num4++;
							}
							GClass84.smethod_505(list2[n], false);
							num2++;
						}
						else if (components2.Length == 0)
						{
							GClass84.smethod_505(list2[n], false);
							num7++;
						}
					}
				}
				list2.Clear();
				List<SkinnedMeshRenderer> list3 = transform_0.GetComponents<SkinnedMeshRenderer>().ToList<SkinnedMeshRenderer>();
				list3.AddRange(transform_0.GetComponentsInChildren<SkinnedMeshRenderer>(true));
				for (int num12 = list3.Count - 1; num12 >= 0; num12--)
				{
					if (list3[num12])
					{
						if (!list3[num12].sharedMesh)
						{
							GClass84.smethod_735(list3[num12]);
							num5++;
						}
						else if (list3[num12].GetSharedMaterialArray().Length == 0)
						{
							GClass84.smethod_735(list3[num12]);
							num8++;
						}
					}
				}
				list3.Clear();
				List<ParticleSystemRenderer> list4 = transform_0.GetComponents<ParticleSystemRenderer>().ToList<ParticleSystemRenderer>();
				list4.AddRange(transform_0.GetComponentsInChildren<ParticleSystemRenderer>(true));
				for (int num13 = list4.Count - 1; num13 >= 0; num13--)
				{
					if (list4[num13] && !list4[num13].GetComponent<ParticleSystem>())
					{
						GClass84.smethod_6(list4[num13]);
						num6++;
					}
				}
				list4.Clear();
				List<VRC_SpatialAudioSource> list5 = transform_0.GetComponents<VRC_SpatialAudioSource>().ToList<VRC_SpatialAudioSource>();
				list5.AddRange(transform_0.GetComponentsInChildren<VRC_SpatialAudioSource>(true));
				for (int num14 = list5.Count - 1; num14 >= 0; num14--)
				{
					if (list5[num14] && !list5[num14].GetComponent<AudioSource>())
					{
						GClass84.smethod_1386(list5[num14]);
						num10++;
					}
				}
				list5.Clear();
				bool flag3 = false;
				if (num > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							num.ToString(),
							" ",
							"Useless",
							" ",
							"Components",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num2 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str3 = string.Concat(new string[]
						{
							": ",
							num2.ToString(),
							" ",
							"Mesh",
							" ",
							"Filters",
							" ",
							"Without",
							" ",
							"Mesh",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str3);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num7 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str4 = string.Concat(new string[]
						{
							": ",
							num7.ToString(),
							" ",
							"Mesh",
							" ",
							"Filters",
							" ",
							"Without",
							" ",
							"Mesh",
							" ",
							"Renderer",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str4);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num3 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str5 = string.Concat(new string[]
						{
							": ",
							num3.ToString(),
							" ",
							"Animators",
							" ",
							"Without",
							" ",
							"Controller",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str5)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str5);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num4 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str6 = string.Concat(new string[]
						{
							": ",
							num4.ToString(),
							" ",
							"Mesh",
							" ",
							"Renderers",
							" ",
							"Without",
							" ",
							"Mesh",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str6)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str6);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num9 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str7 = string.Concat(new string[]
						{
							": ",
							num9.ToString(),
							" ",
							"Mesh",
							" ",
							"Renderers",
							" ",
							"Without",
							" ",
							"Materials",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str7)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str7);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num5 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str8 = string.Concat(new string[]
						{
							": ",
							num5.ToString(),
							" ",
							"Skinned",
							" ",
							"Mesh",
							" ",
							"Renderers",
							" ",
							"Without",
							" ",
							"Mesh",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str8)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str8);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num8 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str9 = string.Concat(new string[]
						{
							": ",
							num8.ToString(),
							" ",
							"Skinned",
							" ",
							"Mesh",
							" ",
							"Renderers",
							" ",
							"Without",
							" ",
							"Materials",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str9)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str9);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num6 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str10 = string.Concat(new string[]
						{
							": ",
							num6.ToString(),
							" ",
							"Particle",
							" ",
							"System",
							" ",
							"Renderers",
							" ",
							"Without",
							" ",
							"Particle",
							" ",
							"System",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str10)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str10);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				if (num10 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str11 = string.Concat(new string[]
						{
							": ",
							num10.ToString(),
							" ",
							"VRC",
							"_",
							"Spatial",
							"Audio",
							"Sources",
							" ",
							"Without",
							" ",
							"Audio",
							"Source",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str11)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str11);
						}
						this.int_47++;
					}
					flag3 = true;
				}
				result = flag3;
			}
			return result;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00034280 File Offset: 0x00032480
		internal void method_26(bool bool_168)
		{
			this.method_547(bool_168);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00034294 File Offset: 0x00032494
		internal bool method_27(GClass145.GStruct102 gstruct102_0)
		{
			for (int i = this.list_23.Count - 1; i >= 0; i--)
			{
				if (this.list_23[i].string_0 == gstruct102_0.string_0)
				{
					return false;
				}
			}
			this.list_23.Add(gstruct102_0);
			this.gclass107_0.list_4 = this.list_23;
			this.gclass107_0.method_37();
			return true;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0003430C File Offset: 0x0003250C
		internal void method_28(bool bool_168)
		{
			this.method_404(bool_168);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00034320 File Offset: 0x00032520
		internal void method_29(bool bool_168)
		{
			this.method_53(bool_168);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00034334 File Offset: 0x00032534
		internal void method_30(bool bool_168)
		{
			this.bool_99 = bool_168;
			this.gclass40_0.bool_78 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0003435C File Offset: 0x0003255C
		internal void method_31(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, bool bool_171, Transform transform_1)
		{
			this.method_399(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, bool_171, transform_1);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00034388 File Offset: 0x00032588
		internal void method_32(bool bool_168)
		{
			this.bool_97 = bool_168;
			this.gclass40_0.bool_76 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000343B0 File Offset: 0x000325B0
		internal static void smethod_1(IntPtr intptr_2, IntPtr intptr_3, byte byte_0)
		{
			GClass145.smethod_13(intptr_2, intptr_3, byte_0);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000343C8 File Offset: 0x000325C8
		internal void method_33(bool bool_168)
		{
			this.method_256(bool_168);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000343DC File Offset: 0x000325DC
		internal void method_34(bool bool_168)
		{
			this.method_337(bool_168);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000343F0 File Offset: 0x000325F0
		internal void method_35(bool bool_168)
		{
			this.bool_92 = bool_168;
			this.gclass40_0.bool_73 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00034418 File Offset: 0x00032618
		internal void method_36(bool bool_168)
		{
			this.bool_127 = bool_168;
			this.gclass40_0.bool_102 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00034440 File Offset: 0x00032640
		internal bool method_37(Transform transform_0, string string_3, ConsoleColor consoleColor_0, ref int int_54, ref int int_55, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170 && !bool_171)
				{
					string str = ": LimitChildren();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool flag = this.bool_8 && bool_170 && this.bool_99 && (!bool_168 || (!this.bool_100 && !this.bool_9));
				int i = transform_0.childCount;
				if (i > 0)
				{
					if (i > this.int_29)
					{
						int_54 += i - this.int_29;
						while (i > this.int_29)
						{
							i--;
							Transform child = transform_0.GetChild(i);
							int_55 += GClass84.smethod_916(child);
							Object.DestroyImmediate(child.gameObject, true);
						}
					}
					while (i > 0)
					{
						i--;
						this.method_37(transform_0.GetChild(i), string_3, consoleColor_0, ref int_54, ref int_55, bool_168, bool_169, bool_170, true);
					}
				}
				if (int_54 > 0 || int_55 > 0)
				{
					if (flag && !bool_171)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							int_54.ToString(),
							" ",
							"Objects",
							" ",
							"With",
							" ",
							int_55.ToString(),
							" ",
							"Children",
							" ",
							"Were",
							" ",
							"Removed",
							" ",
							"By",
							" ",
							"Children",
							"Limiter"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00034688 File Offset: 0x00032888
		internal bool method_38(Transform transform_0, string string_3, ConsoleColor consoleColor_0, ref int int_54, ref int int_55, bool bool_168 = false, bool bool_169 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_168 && !bool_169)
				{
					string str = ": LimitChildren_Preliminary();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool flag = this.bool_8 && bool_168 && this.bool_95;
				int i = transform_0.childCount;
				if (i > 0)
				{
					if (i > this.int_28)
					{
						int_54 += i - this.int_28;
						while (i > this.int_28)
						{
							i--;
							Transform child = transform_0.GetChild(i);
							int_55 += GClass84.smethod_916(child);
							Object.DestroyImmediate(child.gameObject, true);
						}
					}
					while (i > 0)
					{
						i--;
						this.method_38(transform_0.GetChild(i), string_3, consoleColor_0, ref int_54, ref int_55, bool_168, true);
					}
				}
				if (int_54 > 0 || int_55 > 0)
				{
					if (flag && !bool_169)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							int_54.ToString(),
							" ",
							"Objects",
							" ",
							"With",
							" ",
							int_55.ToString(),
							" ",
							"Children",
							" ",
							"Were",
							" ",
							"Removed",
							" ",
							"By",
							" ",
							"Preliminary",
							" ",
							"Children",
							"Limiter"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000348C0 File Offset: 0x00032AC0
		internal void method_39(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForColliderCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				SphereCollider[] array = transform_0.GetComponentsInChildren<SphereCollider>(true);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					if (array[i].radius > 1000f)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Radius",
							" ",
							"Of",
							" ",
							"Sphere",
							" ",
							"Collider",
							" (",
							array[i].radius.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						array[i].radius = 1000f;
					}
				}
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00034AA8 File Offset: 0x00032CA8
		internal List<GameObject> method_40()
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = GClass84.smethod_549(false, false, false);
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				if (list2[i].GetComponent<PipelineManager>() && list2[i].GetComponent<VRC_AvatarDescriptor>())
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00034B18 File Offset: 0x00032D18
		internal void method_41(bool bool_168)
		{
			this.method_342(bool_168);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00034B2C File Offset: 0x00032D2C
		internal GClass84.GStruct132 method_42(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168 = false, bool bool_169 = false)
		{
			GClass84.GStruct132 result;
			if (!transform_0)
			{
				result = new GClass84.GStruct132(0, 0);
			}
			else
			{
				if (this.bool_10 && bool_168 && !bool_169)
				{
					string str = ": LimitObjects_Preliminary();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				GClass84.GStruct132 gstruct = new GClass84.GStruct132(0, 0);
				bool flag = this.bool_8 && bool_168 && this.bool_124;
				List<GameObject> list = new List<GameObject>();
				if (transform_0.childCount > this.int_34)
				{
					Transform[] array = GClass84.smethod_1141(transform_0);
					List<GClass84.GStruct132> list2 = new List<GClass84.GStruct132>();
					int num = 1;
					for (int i = 0; i < array.Length; i++)
					{
						int num2 = GClass84.smethod_916(array[i]);
						if (num2 >= this.int_35)
						{
							bool flag2 = false;
							int count = list2.Count;
							int j = 0;
							while (j < count)
							{
								GClass84.GStruct132 gstruct2 = list2[j];
								if (num2 != gstruct2.int_0)
								{
									j++;
								}
								else
								{
									if (gstruct2.int_1 > this.int_34)
									{
										flag2 = true;
									}
									else
									{
										gstruct2.int_1++;
										list2[j] = gstruct2;
									}
									IL_1BC:
									if (j == count)
									{
										list2.Add(new GClass84.GStruct132(num2, 1));
									}
									if (flag2)
									{
										gstruct.int_0++;
										gstruct.int_1 += num2;
										list.Add(array[i].gameObject);
										goto IL_275;
									}
									if (num > this.int_36)
									{
										gstruct.int_0++;
										gstruct.int_1 += num2;
										list.Add(array[i].gameObject);
										goto IL_275;
									}
									num++;
									GClass84.GStruct132 gstruct3 = this.method_42(array[i], string_3, consoleColor_0, bool_168, true);
									gstruct.int_0 += gstruct3.int_0;
									gstruct.int_1 += gstruct3.int_1;
									goto IL_275;
								}
							}
							goto IL_1BC;
						}
						if (num > this.int_36)
						{
							gstruct.int_0++;
							gstruct.int_1 += num2;
							list.Add(array[i].gameObject);
						}
						else
						{
							num++;
							GClass84.GStruct132 gstruct4 = this.method_42(array[i], string_3, consoleColor_0, bool_168, true);
							gstruct.int_0 += gstruct4.int_0;
							gstruct.int_1 += gstruct4.int_1;
						}
						IL_275:;
					}
				}
				else
				{
					for (int k = 0; k < transform_0.childCount; k++)
					{
						GClass84.GStruct132 gstruct5 = this.method_42(transform_0.GetChild(k), string_3, consoleColor_0, bool_168, true);
						gstruct.int_0 += gstruct5.int_0;
						gstruct.int_1 += gstruct5.int_1;
					}
				}
				if (list.Count > 0)
				{
					this.method_283(list, true);
				}
				list.Clear();
				if ((gstruct.int_0 > 0 || gstruct.int_1 > 0) && flag && !bool_169)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						gstruct.int_0.ToString(),
						" ",
						"Objects",
						" ",
						"With",
						" ",
						gstruct.int_1.ToString(),
						" ",
						"Children",
						" ",
						"Were",
						" ",
						"Removed",
						" ",
						"By",
						" ",
						"Preliminary",
						" ",
						"Object",
						"Limiter"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00034F68 File Offset: 0x00033168
		internal void method_43(bool bool_168)
		{
			this.bool_57 = bool_168;
			this.gclass40_0.bool_44 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00034F90 File Offset: 0x00033190
		internal static void smethod_2(string string_3)
		{
			GClass145.smethod_42(string_3);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00034FA4 File Offset: 0x000331A4
		private void method_44()
		{
			try
			{
				if (!this.bool_47)
				{
					if (this.list_2.Count > 0)
					{
						bool flag = true;
						for (int i = 0; i < this.list_2.Count; i++)
						{
							if (!this.list_2[i].bool_3)
							{
								this.list_2[i] = this.method_535(this.list_2[i]);
								if (!this.list_2[i].bool_3)
								{
									flag = false;
								}
							}
						}
						if (flag)
						{
							this.list_2.Clear();
						}
					}
					else if (this.list_3.Count > 0)
					{
						bool flag2 = true;
						for (int j = 0; j < this.list_3.Count; j++)
						{
							if (!this.list_3[j].bool_2)
							{
								this.list_3[j] = this.method_390(this.list_3[j]);
								if (!this.list_3[j].bool_2)
								{
									flag2 = false;
								}
							}
						}
						if (flag2)
						{
							this.list_3.Clear();
						}
					}
				}
				List<VRCPlayerApi> list = GClass84.smethod_1584();
				for (int k = list.Count - 1; k >= 0; k--)
				{
					GameObject gameObject = list[k].gameObject;
					if (gameObject)
					{
						bool flag3 = false;
						bool isLocal;
						if (!(isLocal = list[k].isLocal))
						{
							flag3 = GClass84.smethod_752(list[k]);
						}
						if ((!this.bool_3 || !isLocal) && (!this.bool_4 || !flag3) && (!GClass84.gclass145_0.bool_5 || !GClass84.smethod_382(GClass84.smethod_538(list[k]))))
						{
							Transform transform = GClass84.smethod_889(gameObject);
							Transform transform2 = GClass84.smethod_1068(gameObject);
							Transform transform3 = GClass84.smethod_276(gameObject);
							Transform transform4 = null;
							List<Transform> list2 = null;
							if (transform && !this.method_197(transform))
							{
								if (this.bool_6)
								{
									transform4 = transform;
								}
								else
								{
									this.method_82(transform, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, true, list[k], null);
								}
							}
							if (transform2)
							{
								if (this.bool_37)
								{
									Object.DestroyImmediate(transform2, true);
								}
								else
								{
									if (transform2.gameObject.active == this.bool_36)
									{
										transform2.gameObject.SetActive(!this.bool_36);
									}
									if (!this.method_197(transform2))
									{
										if (this.bool_6)
										{
											if (list2 == null)
											{
												list2 = new List<Transform>();
											}
											list2.Add(transform2);
										}
										else
										{
											this.method_82(transform2, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, false, list[k], null);
										}
									}
								}
							}
							if (transform3)
							{
								if (this.bool_39)
								{
									Object.DestroyImmediate(transform3, true);
								}
								else
								{
									if (transform3.gameObject.active == this.bool_38)
									{
										transform3.gameObject.SetActive(!this.bool_38);
									}
									if (!this.method_197(transform3))
									{
										if (this.bool_6)
										{
											if (list2 == null)
											{
												list2 = new List<Transform>();
											}
											list2.Add(transform3);
										}
										else
										{
											this.method_82(transform3, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, false, list[k], null);
										}
									}
								}
							}
							if (this.bool_6)
							{
								if (transform4)
								{
									if (list2 != null && list2.Count > 0)
									{
										this.method_214(transform4, list2, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, list[k], null);
									}
									else
									{
										this.method_82(transform4, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, true, list[k], null);
									}
								}
								else if (list2 != null && list2.Count > 0)
								{
									if (list2.Count > 1)
									{
										transform4 = list2[0];
										list2.RemoveAt(0);
										this.method_214(transform4, list2, list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, list[k], null);
									}
									else
									{
										this.method_82(list2[0], list[k].displayName, GClass84.smethod_1571(GClass84.smethod_958(list[k]), true), isLocal, flag3, false, list[k], null);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass145.smethod_2(ex.ToString());
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000354E8 File Offset: 0x000336E8
		internal List<string> method_45(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false, Transform transform_1 = null, bool bool_172 = false, List<Transform> list_30 = null, List<Transform> list_31 = null)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> result;
			if (!transform_0)
			{
				result = list;
			}
			else
			{
				if (this.bool_10 && bool_170 && !bool_172)
				{
					string str = ": CheckForUselessObjects();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				if (!transform_1)
				{
					transform_1 = transform_0;
				}
				if (list_30 == null)
				{
					list_30 = new List<Transform>();
				}
				bool flag = this.bool_8 && bool_170 && this.bool_81 && (!bool_168 || (!this.bool_82 && !this.bool_9));
				if (!transform_0)
				{
					result = list;
				}
				else
				{
					if (!bool_172)
					{
						this.int_51 = 0;
						list_31 = GClass84.smethod_1135(transform_0);
						list_30.Clear();
						List<SkinnedMeshRenderer> list3 = transform_0.GetComponents<SkinnedMeshRenderer>().ToList<SkinnedMeshRenderer>();
						list3.AddRange(transform_0.GetComponentsInChildren<SkinnedMeshRenderer>(true));
						GClass84.smethod_661<SkinnedMeshRenderer>(ref list3);
						for (int i = list3.Count - 1; i >= 0; i--)
						{
							if (list3[i])
							{
								list_30.AddRange(list3[i].bones);
							}
						}
						list3.Clear();
						List<ScaleConstraint> list4 = transform_0.GetComponents<ScaleConstraint>().ToList<ScaleConstraint>();
						list4.AddRange(transform_0.GetComponentsInChildren<ScaleConstraint>(true));
						GClass84.smethod_661<ScaleConstraint>(ref list4);
						for (int j = list4.Count - 1; j >= 0; j--)
						{
							if (list4[j])
							{
								for (int k = 0; k < list4[j].sourceCount; k++)
								{
									ConstraintSource source = list4[j].GetSource(k);
									if (source != null)
									{
										list_31.Add(source.sourceTransform);
									}
								}
							}
						}
						list4.Clear();
						List<ParentConstraint> list5 = transform_0.GetComponents<ParentConstraint>().ToList<ParentConstraint>();
						list5.AddRange(transform_0.GetComponentsInChildren<ParentConstraint>(true));
						GClass84.smethod_661<ParentConstraint>(ref list5);
						for (int l = list5.Count - 1; l >= 0; l--)
						{
							if (list5[l])
							{
								for (int m = 0; m < list5[l].sourceCount; m++)
								{
									ConstraintSource source2 = list5[l].GetSource(m);
									if (source2 != null)
									{
										list_31.Add(source2.sourceTransform);
									}
								}
							}
						}
						list5.Clear();
						List<EyeAndHeadAnimator> list6 = transform_0.GetComponents<EyeAndHeadAnimator>().ToList<EyeAndHeadAnimator>();
						list6.AddRange(transform_0.GetComponentsInChildren<EyeAndHeadAnimator>(true));
						GClass84.smethod_661<EyeAndHeadAnimator>(ref list6);
						for (int n = list6.Count - 1; n >= 0; n--)
						{
							list_31.Add(list6[n].headBoneNonMecanimXform);
							list_31.Add(list6[n].field_Private_Transform_1);
							list_31.Add(list6[n].field_Private_Transform_0);
							list_31.Add(list6[n].Method_Public_get_Transform_0());
							list_31.Add(list6[n].field_Private_Transform_10);
							list_31.Add(list6[n].field_Private_Transform_2);
							list_31.Add(list6[n].field_Private_Transform_4);
							list_31.Add(list6[n].field_Private_Transform_3);
							list_31.Add(list6[n].field_Private_Transform_5);
							list_31.Add(list6[n].field_Private_Transform_6);
							list_31.Add(list6[n].field_Private_Transform_7);
							list_31.Add(list6[n].field_Private_Transform_8);
							list_31.Add(list6[n].field_Private_Transform_9);
							list_31.AddRange(list6[n].field_Private_ArrayOf_Transform_0);
						}
						list6.Clear();
						List<PoseRecorder> list7 = transform_0.GetComponents<PoseRecorder>().ToList<PoseRecorder>();
						list7.AddRange(transform_0.GetComponentsInChildren<PoseRecorder>(true));
						GClass84.smethod_661<PoseRecorder>(ref list7);
						for (int num = list7.Count - 1; num >= 0; num--)
						{
							list_31.AddRange(list7[num].field_Public_ArrayOf_Transform_0);
							list_31.Add(list7[num].field_Internal_Transform_0);
						}
						list7.Clear();
						List<IKSolverTrigonometric> list8 = transform_0.GetComponents<IKSolverTrigonometric>().ToList<IKSolverTrigonometric>();
						list8.AddRange(transform_0.GetComponentsInChildren<IKSolverTrigonometric>(true));
						GClass84.smethod_661<IKSolverTrigonometric>(ref list8);
						for (int num2 = list8.Count - 1; num2 >= 0; num2--)
						{
							list_31.Add(list8[num2].target);
							if (list8[num2].bone1 != null)
							{
								list_31.Add(list8[num2].bone1.transform);
							}
							if (list8[num2].bone2 != null)
							{
								list_31.Add(list8[num2].bone2.transform);
							}
							if (list8[num2].bone3 != null)
							{
								list_31.Add(list8[num2].bone3.transform);
							}
						}
						list8.Clear();
						List<IKSolverHeuristic> list9 = transform_0.GetComponents<IKSolverHeuristic>().ToList<IKSolverHeuristic>();
						list9.AddRange(transform_0.GetComponentsInChildren<IKSolverHeuristic>(true));
						GClass84.smethod_661<IKSolverHeuristic>(ref list9);
						for (int num3 = list9.Count - 1; num3 >= 0; num3--)
						{
							list_31.Add(list9[num3].target);
							foreach (IKSolver.Bone bone in list9[num3].bones)
							{
								list_31.Add(bone.transform);
							}
						}
						list9.Clear();
						List<IKSolver> list10 = transform_0.GetComponents<IKSolver>().ToList<IKSolver>();
						list10.AddRange(transform_0.GetComponentsInChildren<IKSolver>(true));
						GClass84.smethod_661<IKSolver>(ref list10);
						for (int num4 = list10.Count - 1; num4 >= 0; num4--)
						{
							list_31.Add(list10[num4].root);
							List<IKSolver.Point> list11 = list10[num4].GetPoints().ToList<IKSolver.Point>();
							for (int num5 = list11.Count - 1; num5 >= 0; num5--)
							{
								list_31.Add(list11[num5].transform);
							}
						}
						list10.Clear();
						List<VRIK> list12 = transform_0.GetComponents<VRIK>().ToList<VRIK>();
						list12.AddRange(transform_0.GetComponentsInChildren<VRIK>(true));
						GClass84.smethod_661<VRIK>(ref list12);
						for (int num6 = list12.Count - 1; num6 >= 0; num6--)
						{
							VRIK.References references = list12[num6].references;
							if (references != null)
							{
								list_31.AddRange(references.GetTransforms());
								list_31.Add(references.leftHand);
								list_31.Add(references.rightToes);
								list_31.Add(references.rightFoot);
								list_31.Add(references.rightCalf);
								list_31.Add(references.rightThigh);
								list_31.Add(references.leftToes);
								list_31.Add(references.leftFoot);
								list_31.Add(references.leftCalf);
								list_31.Add(references.leftThigh);
								list_31.Add(references.rightHand);
								list_31.Add(references.rightForearm);
								list_31.Add(references.rightUpperArm);
								list_31.Add(references.leftForearm);
								list_31.Add(references.leftUpperArm);
								list_31.Add(references.leftShoulder);
								list_31.Add(references.head);
								list_31.Add(references.neck);
								list_31.Add(references.chest);
								list_31.Add(references.spine);
								list_31.Add(references.pelvis);
								list_31.Add(references.root);
								list_31.Add(references.rightShoulder);
							}
							IKSolverVR solver = list12[num6].solver;
							if (solver != null)
							{
								list_31.AddRange(solver.solverTransforms);
								IKSolverVR.Spine spine = solver.spine;
								IKSolverVR.Arm leftArm = solver.leftArm;
								IKSolverVR.Arm rightArm = solver.rightArm;
								IKSolverVR.Leg leftLeg = solver.leftLeg;
								IKSolverVR.Leg rightLeg = solver.rightLeg;
								IKSolverVR.Leg[] array = solver.legs;
								IKSolverVR.Arm[] array2 = solver.arms;
								if (spine != null)
								{
									list_31.Add(spine.headTarget);
									list_31.Add(spine.pelvisTarget);
									list_31.Add(spine.chestGoal);
								}
								if (leftArm != null)
								{
									list_31.Add(leftArm.target);
									list_31.Add(leftArm.bendGoal);
								}
								if (rightArm != null)
								{
									list_31.Add(rightArm.target);
									list_31.Add(rightArm.bendGoal);
								}
								if (leftLeg != null)
								{
									list_31.Add(leftLeg.bendGoal);
									list_31.Add(leftLeg.target);
								}
								if (rightLeg != null)
								{
									list_31.Add(rightLeg.bendGoal);
									list_31.Add(rightLeg.target);
								}
								for (int num7 = array.Length - 1; num7 >= 0; num7--)
								{
									if (array[num7] != null)
									{
										list_31.Add(array[num7].bendGoal);
										list_31.Add(array[num7].target);
									}
								}
								for (int num8 = array2.Length - 1; num8 >= 0; num8--)
								{
									if (array2[num8] != null)
									{
										list_31.Add(array2[num8].target);
										list_31.Add(array2[num8].bendGoal);
									}
								}
							}
						}
						list12.Clear();
						List<CCDIK> list13 = transform_0.GetComponents<CCDIK>().ToList<CCDIK>();
						list13.AddRange(transform_0.GetComponentsInChildren<CCDIK>(true));
						GClass84.smethod_661<CCDIK>(ref list13);
						for (int num9 = list13.Count - 1; num9 >= 0; num9--)
						{
							IKSolverCCD solver2 = list13[num9].solver;
							if (solver2 != null)
							{
								list_31.Add(solver2.target);
								IKSolver.Bone[] array3 = solver2.bones;
								for (int num10 = array3.Length - 1; num10 >= 0; num10--)
								{
									if (array3[num10] != null)
									{
										list_31.Add(array3[num10].transform);
									}
								}
							}
						}
						list13.Clear();
						List<LimbIK> list14 = transform_0.GetComponents<LimbIK>().ToList<LimbIK>();
						list14.AddRange(transform_0.GetComponentsInChildren<LimbIK>(true));
						GClass84.smethod_661<LimbIK>(ref list14);
						for (int num11 = list14.Count - 1; num11 >= 0; num11--)
						{
							list_31.Add(list14[num11].field_Public_Transform_0);
							list_31.Add(list14[num11].field_Public_Transform_1);
							list_31.Add(list14[num11].field_Public_Transform_2);
						}
						list14.Clear();
						List<LimbIK> list15 = transform_0.GetComponents<LimbIK>().ToList<LimbIK>();
						list15.AddRange(transform_0.GetComponentsInChildren<LimbIK>(true));
						GClass84.smethod_661<LimbIK>(ref list15);
						for (int num12 = list15.Count - 1; num12 >= 0; num12--)
						{
							IKSolverLimb solver3 = list15[num12].solver;
							if (solver3 != null)
							{
								list_31.Add(solver3.bendGoal);
								list_31.Add(solver3.target);
								if (solver3.bone1 != null)
								{
									list_31.Add(solver3.bone1.transform);
								}
								if (solver3.bone2 != null)
								{
									list_31.Add(solver3.bone2.transform);
								}
								if (solver3.bone3 != null)
								{
									list_31.Add(solver3.bone3.transform);
								}
							}
						}
						list15.Clear();
						List<Animator> list16 = transform_0.GetComponents<Animator>().ToList<Animator>();
						list16.AddRange(transform_0.GetComponentsInChildren<Animator>(true));
						GClass84.smethod_661<Animator>(ref list16);
						string[] array4 = GClass84.smethod_462<HumanBodyBones>();
						for (int num13 = list16.Count - 1; num13 >= 0; num13--)
						{
							for (int num14 = 0; num14 < array4.Length - 1; num14++)
							{
								HumanBodyBones humanBodyBones = GClass84.smethod_1563<HumanBodyBones>(array4[num14]);
								Transform boneTransform = list16[num13].GetBoneTransform(humanBodyBones);
								if (boneTransform)
								{
									list_31.Add(boneTransform);
								}
							}
						}
						list16.Clear();
						GClass84.smethod_661<Transform>(ref list_30);
						GClass84.smethod_1233<Transform>(list_30);
						list_31.AddRange(list_30);
						GClass84.smethod_661<Transform>(ref list_31);
						GClass84.smethod_1233<Transform>(list_31);
					}
					Transform[] array5 = GClass84.smethod_1141(transform_0);
					for (int num15 = 0; num15 < array5.Length; num15++)
					{
						if (array5[num15])
						{
							if (bool_171)
							{
								list2.AddRange(this.method_45(array5[num15], string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1, true, list_30, list_31));
							}
							else
							{
								this.method_45(array5[num15], string_3, consoleColor_0, bool_168, bool_169, bool_170, false, transform_1, true, list_30, list_31);
							}
						}
					}
					if (bool_172 && transform_0.childCount == 0 && (!GClass84.smethod_1224<Transform>(list_30, transform_0.parent) && !GClass84.smethod_1224<Transform>(list_31, transform_0)))
					{
						Il2CppArrayBase<Component> components = transform_0.GetComponents<Component>();
						if (components.Count < 3)
						{
							int num16 = components.Length - 1;
							while (num16 >= 0 && (!components[num16] || !(components[num16] != transform_0) || components[num16].TryCast<NetworkMetadata>()))
							{
								num16--;
							}
							if (num16 < 0 && (transform_0.name != "HmdPivot" && (transform_0.parent != transform_1 || (transform_0.name != this.string_1 && transform_0.name != GClass84.gclass93_0.string_0))))
							{
								if (bool_171)
								{
									list.Add(GClass84.smethod_908(transform_0, transform_1));
								}
								if (this.bool_83)
								{
									if (bool_171)
									{
										GClass145.smethod_22(list[list.Count - 1]);
									}
									else
									{
										GClass145.smethod_22(GClass84.smethod_908(transform_0, transform_1));
									}
								}
								GClass84.smethod_890(transform_0.gameObject, false);
								this.int_51++;
							}
						}
					}
					if (bool_171)
					{
						list.AddRange(list2);
						list2.Clear();
					}
					if (!bool_172)
					{
						if (this.int_51 > 0)
						{
							while (GClass84.smethod_738(transform_0))
							{
								if (bool_171)
								{
									List<string> list17 = this.method_45(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1, true, list_30, list_31);
									if (list17.Count == 0)
									{
										break;
									}
									list.AddRange(list17);
									list17.Clear();
								}
								else
								{
									this.method_45(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, false, transform_1, true, list_30, list_31);
								}
							}
							if (flag)
							{
								string str2 = string.Concat(new string[]
								{
									": ",
									this.int_51.ToString(),
									" ",
									"Useless",
									" ",
									"Objects",
									" ",
									"Were",
									" ",
									"Removed"
								});
								if (this.bool_11)
								{
									GClass145.smethod_14(new List<GClass84.GStruct172>
									{
										new GClass84.GStruct172(consoleColor_0, string_3),
										new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
									});
								}
								else
								{
									GClass145.smethod_22(string_3 + str2);
								}
							}
						}
						this.int_51 = 0;
					}
					result = list;
				}
			}
			return result;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000364D8 File Offset: 0x000346D8
		internal void method_46(bool bool_168)
		{
			this.method_262(bool_168);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000364EC File Offset: 0x000346EC
		internal void method_47(bool bool_168)
		{
			this.method_325(bool_168);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00036500 File Offset: 0x00034700
		internal void method_48(bool bool_168)
		{
			this.method_319(bool_168);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00036514 File Offset: 0x00034714
		private Mesh method_49(Transform transform_0, Transform transform_1, string string_3, GClass145.Enum2 enum2_0, out bool bool_168, out bool bool_169, out string string_4, bool bool_170 = false)
		{
			if (transform_1)
			{
				if (!string.IsNullOrEmpty(string_3))
				{
					for (int i = this.list_19.Count - 1; i >= 0; i--)
					{
						if (this.list_19[i].string_0 == string_3 && this.list_19[i].int_0 == (int)enum2_0 && this.list_19[i].bool_2 == bool_170)
						{
							bool_168 = this.list_19[i].bool_0;
							bool_169 = this.list_19[i].bool_0;
							string_4 = this.list_19[i].string_1;
							return this.list_19[i].mesh_0;
						}
					}
					transform_0 = GClass84.smethod_693(transform_1, string_3);
				}
				else
				{
					transform_0 = transform_1;
				}
			}
			bool_168 = false;
			bool_169 = false;
			if (transform_0)
			{
				Mesh mesh = null;
				if (enum2_0 == GClass145.Enum2.const_0)
				{
					MeshFilter component = transform_0.GetComponent<MeshFilter>();
					if (component)
					{
						if (bool_170)
						{
							mesh = component.mesh;
						}
						else
						{
							mesh = component.sharedMesh;
						}
						if (mesh)
						{
							if (bool_170)
							{
								bool_168 = true;
								goto IL_1E0;
							}
							goto IL_1E0;
						}
					}
					string_4 = string.Empty;
					this.list_19.Add(new GClass84.GStruct146(string_3, string_4, mesh, bool_168, bool_169, bool_170, (int)enum2_0));
					return null;
				}
				if (enum2_0 != GClass145.Enum2.const_1)
				{
					string_4 = string.Empty;
					this.list_19.Add(new GClass84.GStruct146(string_3, string_4, mesh, bool_168, bool_169, bool_170, (int)enum2_0));
					return null;
				}
				SkinnedMeshRenderer component2 = transform_0.GetComponent<SkinnedMeshRenderer>();
				if (component2)
				{
					mesh = component2.sharedMesh;
					if (mesh)
					{
						goto IL_1E0;
					}
				}
				string_4 = string.Empty;
				this.list_19.Add(new GClass84.GStruct146(string_3, string_4, mesh, bool_168, bool_169, bool_170, (int)enum2_0));
				return null;
				IL_1E0:
				string_4 = mesh.name;
				for (int j = 0; j < this.list_17.Count; j++)
				{
					if (this.list_17[j].string_0 == string_4)
					{
						bool_169 = this.list_17[j].bool_0;
						IL_232:
						if (j == this.list_17.Count)
						{
							if (string_4.ToLower() == GClass193.string_4 || GClass84.smethod_879(mesh, 0.01f))
							{
								bool_169 = true;
							}
							else
							{
								bool_169 = false;
							}
							this.list_17.Add(new GClass84.GStruct136(string_4, bool_169));
						}
						this.list_19.Add(new GClass84.GStruct146(string_3, string_4, mesh, bool_168, bool_169, bool_170, (int)enum2_0));
						return mesh;
					}
				}
				goto IL_232;
			}
			string_4 = string.Empty;
			return null;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000367F8 File Offset: 0x000349F8
		internal void method_50(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForCorruptedMesh();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				int num = 0;
				List<MeshFilter> list = transform_0.GetComponents<MeshFilter>().ToList<MeshFilter>();
				list.AddRange(transform_0.GetComponentsInChildren<MeshFilter>(true));
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].sharedMesh && !list[i].sharedMesh.isReadable)
					{
						Object.DestroyImmediate(list[i].sharedMesh);
						num++;
					}
				}
				List<SkinnedMeshRenderer> list2 = transform_0.GetComponents<SkinnedMeshRenderer>().ToList<SkinnedMeshRenderer>();
				list2.AddRange(transform_0.GetComponentsInChildren<SkinnedMeshRenderer>(true));
				for (int j = list2.Count - 1; j >= 0; j--)
				{
					if (list2[j].sharedMesh && !list2[j].sharedMesh.isReadable)
					{
						Object.DestroyImmediate(list2[j].sharedMesh);
						num++;
					}
				}
				if (num > 0)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						"Removed",
						" ",
						num.ToString(),
						" ",
						"Corrupted",
						" ",
						"Meshes"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000369E4 File Offset: 0x00034BE4
		internal void method_51(Transform transform_0, string string_3)
		{
			this.method_308(transform_0, string_3);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000369FC File Offset: 0x00034BFC
		internal void method_52(bool bool_168)
		{
			this.bool_46 = bool_168;
			this.gclass40_0.bool_34 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00036A24 File Offset: 0x00034C24
		internal void method_53(bool bool_168)
		{
			this.method_382(bool_168);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00036A38 File Offset: 0x00034C38
		internal void method_54(bool bool_168)
		{
			this.bool_145 = bool_168;
			this.gclass40_0.bool_24 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00036A60 File Offset: 0x00034C60
		internal void method_55(bool bool_168)
		{
			this.method_229(bool_168);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00036A74 File Offset: 0x00034C74
		internal void method_56(bool bool_168)
		{
			this.method_474(bool_168);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00036A88 File Offset: 0x00034C88
		internal void method_57(bool bool_168)
		{
			this.method_106(bool_168);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00036A9C File Offset: 0x00034C9C
		internal void method_58(bool bool_168)
		{
			this.method_9(bool_168);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00036AB0 File Offset: 0x00034CB0
		internal void method_59(bool bool_168)
		{
			this.method_123(bool_168);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00036AC4 File Offset: 0x00034CC4
		internal bool method_60(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false, Transform transform_1 = null, Transform transform_2 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170 && !bool_171)
				{
					string str = ": CheckForSimilarObjects_Smart2();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				if (!transform_1)
				{
					transform_1 = transform_0;
				}
				bool flag = this.bool_8 && bool_170 && this.bool_49 && (!bool_168 || (!this.bool_50 && !this.bool_9));
				List<GameObject> list = new List<GameObject>();
				List<Object> list2 = new List<Object>();
				if (transform_0.childCount > 0)
				{
					bool flag2 = true;
					Transform[] array = GClass84.smethod_1141(transform_0);
					int i = 0;
					while (i < array.Length)
					{
						if (this.int_50 < this.int_49)
						{
							if (!this.method_60(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1, transform_2))
							{
								flag2 = false;
							}
							i++;
						}
						else
						{
							this.bool_156 = false;
							flag2 = false;
							IL_120:
							if (!flag2)
							{
								return false;
							}
							goto IL_12F;
						}
					}
					goto IL_120;
				}
				IL_12F:
				if (transform_0.GetComponent<ParticleSystem>())
				{
					result = false;
				}
				else if (!transform_0.parent)
				{
					result = false;
				}
				else
				{
					bool flag3 = false;
					MeshFilter component = transform_0.GetComponent<MeshFilter>();
					SkinnedMeshRenderer skinnedMeshRenderer = null;
					bool flag4 = false;
					string empty = string.Empty;
					Mesh mesh = null;
					bool flag5 = false;
					List<GClass84.GStruct134> list3 = new List<GClass84.GStruct134>();
					if (component)
					{
						mesh = this.method_49(transform_0, transform_2, GClass84.smethod_908(transform_0, transform_1), GClass145.Enum2.const_0, out flag5, out flag4, out empty, false);
					}
					else if (!this.bool_44)
					{
						skinnedMeshRenderer = transform_0.GetComponent<SkinnedMeshRenderer>();
						if (skinnedMeshRenderer)
						{
							mesh = this.method_49(transform_0, transform_2, GClass84.smethod_908(transform_0, transform_1), GClass145.Enum2.const_1, out flag5, out flag4, out empty, false);
						}
					}
					if (mesh)
					{
						Il2CppArrayBase<Renderer> components = transform_0.GetComponents<Renderer>();
						for (int j = 0; j < components.Count; j++)
						{
							if (!components[j].TryCast<ParticleSystemRenderer>() && !components[j].TryCast<LineRenderer>() && !components[j].TryCast<TrailRenderer>())
							{
								Il2CppReferenceArray<Material> sharedMaterialArray = components[j].GetSharedMaterialArray();
								int length = sharedMaterialArray.Length;
								if (length == 0)
								{
									if (transform_0.childCount == 0)
									{
										transform_0.gameObject.SetActive(false);
									}
									components[j].enabled = false;
								}
								else if (flag3)
								{
									components[j].enabled = false;
									if (length > 0)
									{
										components[j].SetMaterialArray(new Il2CppReferenceArray<Material>(0L));
									}
								}
								else
								{
									bool flag6 = false;
									if (length == 1)
									{
										flag6 = true;
									}
									else
									{
										int num = 1;
										while (num < length && !(sharedMaterialArray[0].name != sharedMaterialArray[num].name))
										{
											num++;
										}
										if (num == length)
										{
											flag6 = true;
										}
									}
									if (flag6)
									{
										MeshFilter component2 = transform_0.parent.GetComponent<MeshFilter>();
										bool flag7 = false;
										string empty2 = string.Empty;
										if (component2)
										{
											bool flag8;
											this.method_49(transform_0.parent, transform_2, GClass84.smethod_908(transform_0.parent, transform_1), GClass145.Enum2.const_0, out flag8, out flag7, out empty2, false);
										}
										else
										{
											SkinnedMeshRenderer component3 = transform_0.parent.GetComponent<SkinnedMeshRenderer>();
											if (component3)
											{
												bool flag8;
												this.method_49(transform_0.parent, transform_2, GClass84.smethod_908(transform_0.parent, transform_1), GClass145.Enum2.const_1, out flag8, out flag7, out empty2, false);
											}
										}
										bool flag9 = false;
										if (empty == empty2)
										{
											Vector3 vector;
											vector..ctor(0f, 0f, 0f);
											if (vector == transform_0.localPosition || (this.int_5 > 0 && this.method_209(vector, transform_0.localPosition, this.int_5, this.int_6, this.float_2, this.float_3, this.float_4)))
											{
												Quaternion quaternion;
												quaternion..ctor(0f, 0f, 0f, 1f);
												if ((flag4 && flag7) || quaternion == transform_0.localRotation)
												{
													Vector3 vector2;
													vector2..ctor(1f, 1f, 1f);
													if (vector2 == transform_0.localScale || (this.int_7 > 0 && this.method_209(vector2, transform_0.localScale, this.int_7, this.int_8, this.float_5, this.float_6, this.float_7)))
													{
														flag9 = true;
													}
												}
											}
										}
										if (!flag9)
										{
											break;
										}
										Il2CppArrayBase<Renderer> components2 = transform_0.parent.GetComponents<Renderer>();
										for (int k = 0; k < components2.Count; k++)
										{
											if (!components2[k].TryCast<ParticleSystemRenderer>() && !components2[k].TryCast<LineRenderer>() && !components2[k].TryCast<TrailRenderer>())
											{
												Il2CppReferenceArray<Material> sharedMaterialArray2 = components2[k].GetSharedMaterialArray();
												if (sharedMaterialArray2.Length == length)
												{
													int num2 = 0;
													while (num2 < length && !(sharedMaterialArray[0].name != sharedMaterialArray2[num2].name))
													{
														num2++;
													}
													if (num2 == length)
													{
														int l = 0;
														while (l < list3.Count)
														{
															GClass84.GStruct134 gstruct = list3[l];
															if (!(gstruct.string_0 == empty))
															{
																l++;
															}
															else
															{
																if (gstruct.int_0 >= this.int_9)
																{
																	transform_0.gameObject.SetActive(false);
																	components[j].enabled = false;
																	flag3 = true;
																}
																else
																{
																	gstruct.int_0++;
																	list3[l] = gstruct;
																}
																IL_5EE:
																if (l == list3.Count)
																{
																	list3.Add(new GClass84.GStruct134(empty, 1));
																	goto IL_60A;
																}
																goto IL_60A;
															}
														}
														goto IL_5EE;
													}
												}
											}
											IL_60A:;
										}
										if (flag3)
										{
											break;
										}
									}
								}
							}
						}
					}
					if (flag3)
					{
						if (flag && this.int_47 < this.int_46)
						{
							string str2 = string.Concat(new string[]
							{
								": ",
								transform_0.name,
								" ",
								"Is",
								" ",
								"Similar",
								" ",
								"To",
								" ",
								"Parent",
								" ",
								transform_0.parent.name,
								". ",
								"Was",
								" ",
								"Destroyed"
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str2);
							}
							this.int_47++;
						}
						this.int_50++;
						if (flag5)
						{
							list2.Add(mesh);
						}
						else if (skinnedMeshRenderer)
						{
							skinnedMeshRenderer.sharedMesh = null;
						}
						GClass84.smethod_194(transform_0);
						list.Add(transform_0.gameObject);
						if (list.Count > 0)
						{
							this.method_283(list, false);
						}
						list.Clear();
						if (list2.Count > 0)
						{
							this.method_17(list2);
						}
						list2.Clear();
						result = true;
					}
					else
					{
						if (list.Count > 0)
						{
							this.method_283(list, true);
						}
						list.Clear();
						if (list2.Count > 0)
						{
							this.method_17(list2);
						}
						list2.Clear();
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000372BC File Offset: 0x000354BC
		private void method_61()
		{
			this.method_400();
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000372D0 File Offset: 0x000354D0
		internal void method_62(int int_54)
		{
			this.method_336(int_54);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000372E4 File Offset: 0x000354E4
		internal void method_63(bool bool_168)
		{
			this.method_553(bool_168);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000372F8 File Offset: 0x000354F8
		internal void method_64(bool bool_168)
		{
			this.bool_138 = bool_168;
			this.gclass40_0.bool_22 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00037320 File Offset: 0x00035520
		private static string smethod_3(IntPtr intptr_2)
		{
			return GClass145.smethod_34(intptr_2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00037334 File Offset: 0x00035534
		internal void method_65(bool bool_168)
		{
			this.method_514(bool_168);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00037348 File Offset: 0x00035548
		internal void method_66(bool bool_168)
		{
			this.method_430(bool_168);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0003735C File Offset: 0x0003555C
		internal void method_67(bool bool_168)
		{
			this.method_180(bool_168);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00037370 File Offset: 0x00035570
		internal void method_68(bool bool_168)
		{
			this.method_255(bool_168);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00037384 File Offset: 0x00035584
		internal void method_69(bool bool_168)
		{
			this.bool_111 = bool_168;
			this.gclass40_0.bool_90 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000373AC File Offset: 0x000355AC
		internal bool method_70(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForCustomShaders();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				string a = string.Empty;
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_140 && (!bool_168 || (!this.bool_152 && !this.bool_9));
				bool flag2 = false;
				List<Object> list = new List<Object>();
				for (int i = 0; i < array.Length; i++)
				{
					Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
					list.AddRange(components);
					for (int j = 0; j < components.Count; j++)
					{
						Il2CppReferenceArray<Material> materialArray = components[j].GetMaterialArray();
						list.AddRange(materialArray);
						for (int k = 0; k < materialArray.Count; k++)
						{
							if (materialArray[k].shader.name != "Standard")
							{
								if (flag && this.int_47 < this.int_46)
								{
									string text = string.Concat(new string[]
									{
										": ",
										array[i].name,
										" ",
										"Had",
										" ",
										"Custom",
										" ",
										"Shader",
										" ",
										materialArray[k].shader.name,
										". ",
										"Changed",
										" ",
										"To",
										" ",
										"Standard"
									});
									if (a != text)
									{
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, text)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + text);
										}
										a = text;
									}
									this.int_47++;
								}
								materialArray[k].shader = GClass84.smethod_1455();
								if (this.bool_150)
								{
									GClass84.smethod_1033(materialArray[k]);
								}
								flag2 = true;
							}
						}
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00037668 File Offset: 0x00035868
		internal void method_71(bool bool_168)
		{
			this.method_543(bool_168);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0003767C File Offset: 0x0003587C
		private void method_72(GameObject gameObject_0, bool bool_168)
		{
			if (gameObject_0)
			{
				if (bool_168)
				{
					GClass84.smethod_74(gameObject_0);
				}
				this.list_16.AddRange(GClass84.smethod_94(gameObject_0));
				this.list_16.Add(gameObject_0);
				GClass84.smethod_661<Object>(ref this.list_16);
				GClass84.smethod_1233<Object>(this.list_16);
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000376D0 File Offset: 0x000358D0
		internal void method_73(bool bool_168)
		{
			this.method_349(bool_168);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000376E4 File Offset: 0x000358E4
		internal bool method_74(GameObject gameObject_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			return this.method_233((gameObject_0 != null) ? gameObject_0.transform : null, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0003770C File Offset: 0x0003590C
		internal void method_75(bool bool_168)
		{
			this.bool_78 = bool_168;
			this.gclass40_0.bool_64 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00037734 File Offset: 0x00035934
		internal void method_76(int int_54)
		{
			this.method_130(int_54);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00037748 File Offset: 0x00035948
		internal void method_77(bool bool_168)
		{
			this.method_303(bool_168);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0003775C File Offset: 0x0003595C
		internal void method_78(bool bool_168)
		{
			this.method_473(bool_168);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00037770 File Offset: 0x00035970
		internal void method_79(bool bool_168)
		{
			this.method_194(bool_168);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00037784 File Offset: 0x00035984
		internal void method_80(bool bool_168)
		{
			this.method_392(bool_168);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00037798 File Offset: 0x00035998
		internal void method_81(bool bool_168)
		{
			this.bool_137 = bool_168;
			this.gclass40_0.bool_21 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000377C0 File Offset: 0x000359C0
		private void method_82(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, VRCPlayerApi vrcplayerApi_0 = null, Transform transform_1 = null)
		{
			this.method_281(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, vrcplayerApi_0, transform_1);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000377EC File Offset: 0x000359EC
		internal void method_83(bool bool_168)
		{
			this.bool_135 = bool_168;
			this.gclass40_0.bool_108 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00037814 File Offset: 0x00035A14
		internal void method_84(bool bool_168)
		{
			this.method_10(bool_168);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00037828 File Offset: 0x00035A28
		internal void method_85(bool bool_168)
		{
			this.method_55(bool_168);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0003783C File Offset: 0x00035A3C
		internal void method_86(bool bool_168)
		{
			this.method_177(bool_168);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00037850 File Offset: 0x00035A50
		internal bool method_87(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForWhiteShaders();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				string a = string.Empty;
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_145 && (!bool_168 || (!this.bool_152 && !this.bool_9));
				bool flag2 = false;
				List<Object> list = new List<Object>();
				for (int i = 0; i < array.Length; i++)
				{
					Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
					list.AddRange(components);
					for (int j = 0; j < components.Count; j++)
					{
						Il2CppReferenceArray<Material> materialArray = components[j].GetMaterialArray();
						list.AddRange(materialArray);
						for (int k = 0; k < materialArray.Count; k++)
						{
							if (materialArray[k].shader && !this.method_22(materialArray[k].shader.name))
							{
								if (flag && this.int_47 < this.int_46)
								{
									string text = string.Concat(new string[]
									{
										": ",
										array[i].name,
										" ",
										"Had",
										" ",
										"Not",
										" ",
										"White",
										" ",
										"Shader",
										" ",
										materialArray[k].shader.name,
										". ",
										"Changed",
										" ",
										"To",
										" ",
										"Standard"
									});
									if (a != text)
									{
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, text)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + text);
										}
										a = text;
									}
									this.int_47++;
								}
								materialArray[k].shader = GClass84.smethod_1455();
								if (this.bool_150)
								{
									GClass84.smethod_1033(materialArray[k]);
								}
								if (this.bool_151)
								{
									GClass84.smethod_1385(materialArray[k]);
								}
								flag2 = true;
							}
						}
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00037B4C File Offset: 0x00035D4C
		internal void method_88(bool bool_168)
		{
			this.bool_102 = bool_168;
			this.gclass40_0.bool_81 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00037B74 File Offset: 0x00035D74
		internal void method_89(bool bool_168)
		{
			this.method_238(bool_168);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00037B88 File Offset: 0x00035D88
		private unsafe static void smethod_4(IntPtr intptr_2, float* pFloat_0, byte* pByte_0)
		{
			GClass145.delegate24_0(intptr_2, pFloat_0, pByte_0);
			if (!GClass145.bool_167 && (*pFloat_0 <= -3.402823E+07f || *pFloat_0 >= 3.402823E+07f))
			{
				if (!float.IsNaN(*pFloat_0) && !float.IsInfinity(*pFloat_0) && pByte_0 != null)
				{
					string[] array = GClass145.string_2;
					int i = 0;
					IL_9C:
					while (i < array.Length)
					{
						string text = array[i];
						for (int j = 0; j < text.Length; j++)
						{
							if (pByte_0[j] == 0 || (char)pByte_0[j] != text[j])
							{
								i++;
								goto IL_9C;
							}
						}
						return;
					}
				}
				*pFloat_0 = 0f;
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00037C40 File Offset: 0x00035E40
		internal void method_90(bool bool_168)
		{
			this.bool_87 = bool_168;
			this.gclass40_0.bool_70 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00037C68 File Offset: 0x00035E68
		internal void method_91(bool bool_168)
		{
			this.method_475(bool_168);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00037C7C File Offset: 0x00035E7C
		internal void method_92(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			this.method_418(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00037CA0 File Offset: 0x00035EA0
		private void method_93(float float_17)
		{
			this.float_14 += float_17;
			if (this.float_14 >= (float)this.int_48)
			{
				this.method_526();
				this.float_14 = 0f;
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00037CE0 File Offset: 0x00035EE0
		internal GClass84.GStruct132 method_94(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false)
		{
			GClass84.GStruct132 result;
			if (!transform_0)
			{
				result = new GClass84.GStruct132(0, 0);
			}
			else
			{
				if (this.bool_10 && bool_170 && !bool_171)
				{
					string str = ": LimitObjects();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				GClass84.GStruct132 gstruct = new GClass84.GStruct132(0, 0);
				bool flag = this.bool_8 && bool_170 && this.bool_128 && (!bool_168 || (!this.bool_129 && !this.bool_9));
				List<GameObject> list = new List<GameObject>();
				if (transform_0.childCount > this.int_37)
				{
					Transform[] array = GClass84.smethod_1141(transform_0);
					List<GClass84.GStruct132> list2 = new List<GClass84.GStruct132>();
					int num = 1;
					for (int i = 0; i < array.Length; i++)
					{
						int num2 = GClass84.smethod_916(array[i]);
						if (num2 >= this.int_38)
						{
							bool flag2 = false;
							int count = list2.Count;
							int j = 0;
							while (j < count)
							{
								GClass84.GStruct132 gstruct2 = list2[j];
								if (num2 != gstruct2.int_0)
								{
									j++;
								}
								else
								{
									if (gstruct2.int_1 > this.int_37)
									{
										flag2 = true;
									}
									else
									{
										gstruct2.int_1++;
										list2[j] = gstruct2;
									}
									IL_1DA:
									if (j == count)
									{
										list2.Add(new GClass84.GStruct132(num2, 1));
									}
									if (flag2)
									{
										gstruct.int_0++;
										gstruct.int_1 += num2;
										list.Add(array[i].gameObject);
										goto IL_297;
									}
									if (num > this.int_39)
									{
										gstruct.int_0++;
										gstruct.int_1 += num2;
										list.Add(array[i].gameObject);
										goto IL_297;
									}
									num++;
									GClass84.GStruct132 gstruct3 = this.method_94(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true);
									gstruct.int_0 += gstruct3.int_0;
									gstruct.int_1 += gstruct3.int_1;
									goto IL_297;
								}
							}
							goto IL_1DA;
						}
						if (num > this.int_39)
						{
							gstruct.int_0++;
							gstruct.int_1 += num2;
							list.Add(array[i].gameObject);
						}
						else
						{
							num++;
							GClass84.GStruct132 gstruct4 = this.method_94(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true);
							gstruct.int_0 += gstruct4.int_0;
							gstruct.int_1 += gstruct4.int_1;
						}
						IL_297:;
					}
				}
				else
				{
					for (int k = 0; k < transform_0.childCount; k++)
					{
						GClass84.GStruct132 gstruct5 = this.method_94(transform_0.GetChild(k), string_3, consoleColor_0, bool_168, bool_169, bool_170, true);
						gstruct.int_0 += gstruct5.int_0;
						gstruct.int_1 += gstruct5.int_1;
					}
				}
				if (list.Count > 0)
				{
					this.method_283(list, true);
				}
				list.Clear();
				if ((gstruct.int_0 > 0 || gstruct.int_1 > 0) && flag && !bool_171)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						gstruct.int_0.ToString(),
						" ",
						"Objects",
						" ",
						"With",
						" ",
						gstruct.int_1.ToString(),
						" ",
						"Children",
						" ",
						"Were",
						" ",
						"Removed",
						" ",
						"By",
						" ",
						"Object",
						"Limiter"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00038130 File Offset: 0x00036330
		internal void method_95(bool bool_168)
		{
			this.bool_33 = bool_168;
			this.gclass40_0.bool_16 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00038158 File Offset: 0x00036358
		internal void method_96(bool bool_168)
		{
			this.method_401(bool_168);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0003816C File Offset: 0x0003636C
		internal void method_97(bool bool_168)
		{
			this.bool_62 = bool_168;
			this.gclass40_0.bool_49 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00038194 File Offset: 0x00036394
		internal void method_98(bool bool_168)
		{
			this.method_184(bool_168);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000381A8 File Offset: 0x000363A8
		internal void method_99(bool bool_168)
		{
			this.method_47(bool_168);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000381BC File Offset: 0x000363BC
		internal void method_100(bool bool_168)
		{
			this.method_304(bool_168);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000381D0 File Offset: 0x000363D0
		internal void method_101(bool bool_168)
		{
			this.method_398(bool_168);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000381E4 File Offset: 0x000363E4
		internal void method_102(bool bool_168)
		{
			this.method_460(bool_168);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000381F8 File Offset: 0x000363F8
		internal void method_103(bool bool_168)
		{
			this.method_48(bool_168);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0003820C File Offset: 0x0003640C
		internal void method_104(bool bool_168)
		{
			this.bool_93 = bool_168;
			this.gclass40_0.bool_74 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00038234 File Offset: 0x00036434
		internal void method_105(bool bool_168)
		{
			this.method_3(bool_168);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00038248 File Offset: 0x00036448
		internal void method_106(bool bool_168)
		{
			this.method_107(bool_168);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0003825C File Offset: 0x0003645C
		internal void method_107(bool bool_168)
		{
			this.bool_100 = bool_168;
			this.gclass40_0.bool_79 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00038284 File Offset: 0x00036484
		internal void method_108(Transform transform_0)
		{
			this.method_166(transform_0);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00038298 File Offset: 0x00036498
		internal void method_109(bool bool_168)
		{
			this.method_165(bool_168);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000382AC File Offset: 0x000364AC
		internal void method_110(bool bool_168)
		{
			this.method_540(bool_168);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000382C0 File Offset: 0x000364C0
		internal void method_111(bool bool_168)
		{
			this.method_239(bool_168);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000382D4 File Offset: 0x000364D4
		internal void method_112(bool bool_168)
		{
			this.method_101(bool_168);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000382E8 File Offset: 0x000364E8
		internal void method_113(bool bool_168)
		{
			this.method_448(bool_168);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000382FC File Offset: 0x000364FC
		private static void smethod_5(IntPtr intptr_2, long long_0, long long_1)
		{
			GClass145.smethod_43(intptr_2, long_0, long_1);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00038314 File Offset: 0x00036514
		private void method_114(float float_17)
		{
			if (this.list_12.Count > 0)
			{
				for (int i = 0; i < this.list_12.Count; i++)
				{
					GClass145.Struct6 @struct = this.list_12[i];
					if (@struct.gameObject_0 == null)
					{
						this.list_12.RemoveAt(i);
						i--;
					}
					else if (@struct.gameObject_0.transform && @struct.gameObject_0.transform.parent && @struct.gameObject_0.transform.parent.name == "ForwardDirection")
					{
						this.list_12.RemoveAt(i);
						i--;
					}
					else
					{
						@struct.float_0 += float_17;
						if (@struct.float_0 >= (float)this.int_43)
						{
							GClass84.smethod_890(@struct.gameObject_0, false);
							this.list_12.RemoveAt(i);
							i--;
						}
						else
						{
							this.list_12[i] = @struct;
						}
					}
				}
				if (this.list_12.Count <= 0)
				{
					this.list_12.Clear();
				}
			}
			this.float_13 += float_17;
			if (this.float_13 >= (float)this.int_42)
			{
				this.method_372();
				this.float_13 = 0f;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0003847C File Offset: 0x0003667C
		private void method_115(GameObject gameObject_0, bool bool_168)
		{
			this.method_72(gameObject_0, bool_168);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00038494 File Offset: 0x00036694
		internal void method_116(bool bool_168)
		{
			this.method_171(bool_168);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000384A8 File Offset: 0x000366A8
		internal void method_117(bool bool_168)
		{
			this.bool_61 = bool_168;
			this.gclass40_0.bool_48 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000384D0 File Offset: 0x000366D0
		internal void method_118(bool bool_168)
		{
			this.method_516(bool_168);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000384E4 File Offset: 0x000366E4
		internal void method_119(bool bool_168)
		{
			this.bool_40 = bool_168;
			this.gclass40_0.bool_17 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003850C File Offset: 0x0003670C
		internal void method_120(Transform transform_0, string string_3)
		{
			this.method_50(transform_0, string_3);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00038524 File Offset: 0x00036724
		internal void method_121(bool bool_168)
		{
			this.bool_68 = bool_168;
			this.gclass40_0.bool_55 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003854C File Offset: 0x0003674C
		internal void method_122(bool bool_168)
		{
			this.bool_91 = bool_168;
			this.gclass40_0.bool_72 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00038574 File Offset: 0x00036774
		internal void method_123(bool bool_168)
		{
			this.bool_77 = bool_168;
			this.gclass40_0.bool_63 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0003859C File Offset: 0x0003679C
		internal void method_124(bool bool_168)
		{
			this.method_493(bool_168);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000385B0 File Offset: 0x000367B0
		internal void method_125(bool bool_168)
		{
			this.bool_162 = bool_168;
			this.gclass40_0.bool_112 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000385D8 File Offset: 0x000367D8
		private void method_126(MethodBase methodBase_0, string string_3, string string_4)
		{
			this.method_343(methodBase_0, string_3, string_4);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000385F0 File Offset: 0x000367F0
		internal void method_127(GameObject gameObject_0, List<GameObject> list_30, bool bool_168)
		{
			if (list_30 != null && list_30.Count != 0)
			{
				this.method_20(gameObject_0, false);
				for (int i = list_30.Count - 1; i >= 0; i--)
				{
					GameObject gameObject = list_30[i];
					this.method_176((gameObject != null) ? gameObject.transform : null);
				}
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00038648 File Offset: 0x00036848
		internal void method_128(bool bool_168)
		{
			this.bool_114 = bool_168;
			this.gclass40_0.bool_93 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00038670 File Offset: 0x00036870
		internal GClass84.GStruct132 method_129(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false)
		{
			GClass84.GStruct132 result;
			if (!transform_0)
			{
				result = new GClass84.GStruct132(0, 0);
			}
			else
			{
				if (this.bool_10 && bool_170 && !bool_171)
				{
					string str = ": LimitObjectsName();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				GClass84.GStruct132 gstruct = new GClass84.GStruct132(0, 0);
				bool flag = this.bool_8 && bool_170 && this.bool_135 && (!bool_168 || (!this.bool_136 && !this.bool_9));
				List<GameObject> list = new List<GameObject>();
				if (transform_0.childCount > this.int_41)
				{
					Transform[] array = GClass84.smethod_1141(transform_0);
					List<GClass84.GStruct134> list2 = new List<GClass84.GStruct134>();
					int i = 0;
					while (i < array.Length)
					{
						if (GClass84.smethod_360(array[i].name, 1) == ")")
						{
							int num = GClass84.smethod_1635(array[i].name, "(");
							int num2;
							if (num > 0 && GClass84.smethod_593(array[i].name) - num > 2 && GClass84.smethod_1238(GClass84.smethod_1204(array[i].name, num + 1, GClass84.smethod_593(array[i].name) - num - 2), out num2))
							{
								string text = GClass84.smethod_1428(array[i].name, num);
								if (GClass84.smethod_360(text, 1) == " ")
								{
									text = GClass84.smethod_1428(text, GClass84.smethod_593(text) - 1);
								}
								int count = list2.Count;
								int j = 0;
								while (j < count)
								{
									GClass84.GStruct134 gstruct2 = list2[j];
									if (!(gstruct2.string_0 == text))
									{
										j++;
									}
									else
									{
										if (gstruct2.int_0 >= this.int_41)
										{
											gstruct.int_0++;
											gstruct.int_1 += GClass84.smethod_916(array[i]);
											list.Add(array[i].gameObject);
										}
										else
										{
											gstruct2.int_0++;
											list2[j] = gstruct2;
										}
										IL_234:
										if (j == count)
										{
											list2.Add(new GClass84.GStruct134(text, 1));
											goto IL_3BF;
										}
										goto IL_3BF;
									}
								}
								goto IL_234;
							}
							goto IL_36E;
						}
						else
						{
							int num3 = GClass84.smethod_1635(array[i].name, "_");
							int num2;
							if (num3 > 0 && GClass84.smethod_593(array[i].name) - num3 > 1 && GClass84.smethod_1238(GClass84.smethod_1204(array[i].name, num3 + 1, -1), out num2))
							{
								string b = GClass84.smethod_1428(array[i].name, num3);
								int count2 = list2.Count;
								int k = 0;
								while (k < count2)
								{
									GClass84.GStruct134 gstruct3 = list2[k];
									if (!(gstruct3.string_0 == b))
									{
										k++;
									}
									else
									{
										if (gstruct3.int_0 >= this.int_41)
										{
											gstruct.int_0++;
											gstruct.int_1 += GClass84.smethod_916(array[i]);
											list.Add(array[i].gameObject);
										}
										else
										{
											gstruct3.int_0++;
											list2[k] = gstruct3;
										}
										IL_355:
										if (k == count2)
										{
											list2.Add(new GClass84.GStruct134(b, 1));
											goto IL_3BF;
										}
										goto IL_3BF;
									}
								}
								goto IL_355;
							}
							goto IL_36E;
						}
						IL_3BF:
						i++;
						continue;
						IL_36E:
						list2.Add(new GClass84.GStruct134(array[i].name, 1));
						GClass84.GStruct132 gstruct4 = this.method_129(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true);
						gstruct.int_0 += gstruct4.int_0;
						gstruct.int_1 += gstruct4.int_1;
						goto IL_3BF;
					}
				}
				else
				{
					for (int l = 0; l < transform_0.childCount; l++)
					{
						GClass84.GStruct132 gstruct5 = this.method_129(transform_0.GetChild(l), string_3, consoleColor_0, bool_168, bool_169, bool_170, true);
						gstruct.int_0 += gstruct5.int_0;
						gstruct.int_1 += gstruct5.int_1;
					}
				}
				if (list.Count > 0)
				{
					this.method_283(list, true);
				}
				list.Clear();
				if ((gstruct.int_0 > 0 || gstruct.int_1 > 0) && flag && !bool_171)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						gstruct.int_0.ToString(),
						" ",
						"Objects",
						" ",
						"With",
						" ",
						gstruct.int_1.ToString(),
						" ",
						"Children",
						" ",
						"Were",
						" ",
						"Removed",
						" ",
						"By",
						" ",
						"Object",
						"Name",
						"Limiter"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00038BF0 File Offset: 0x00036DF0
		internal void method_130(int int_54)
		{
			this.int_46 = int_54;
			this.gclass40_0.int_1 = int_54;
			GClass40.smethod_1();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00038C18 File Offset: 0x00036E18
		internal void method_131(bool bool_168)
		{
			this.bool_10 = bool_168;
			this.gclass40_0.bool_9 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00038C40 File Offset: 0x00036E40
		private void method_132()
		{
			this.method_208();
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00038C54 File Offset: 0x00036E54
		internal void method_133(bool bool_168)
		{
			this.method_267(bool_168);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00038C68 File Offset: 0x00036E68
		internal void method_134(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_168)
				{
					string str = ": LimitChildrenGeneration_Preliminary();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				List<Transform> list = GClass84.smethod_1687(transform_0, this.int_32);
				bool flag = this.bool_8 && bool_168 && this.bool_117;
				for (int i = list.Count - 1; i >= 0; i--)
				{
					GClass84.smethod_890(list[i].gameObject, false);
				}
				if (list.Count > 0 && flag)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						list.Count.ToString(),
						" ",
						"Children",
						" ",
						"Generations",
						" ",
						"Were",
						" ",
						"Limited",
						" ",
						"To",
						" ",
						this.int_32.ToString()
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00038E08 File Offset: 0x00037008
		internal void method_135(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = true, Transform transform_1 = null)
		{
			this.method_198(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, bool_171, transform_1);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00038E34 File Offset: 0x00037034
		internal void method_136(bool bool_168)
		{
			this.bool_66 = bool_168;
			this.gclass40_0.bool_53 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00038E5C File Offset: 0x0003705C
		private static void smethod_6(IntPtr intptr_2)
		{
			GClass145.smethod_10(intptr_2);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00038E70 File Offset: 0x00037070
		internal void method_137(bool bool_168)
		{
			this.method_232(bool_168);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00038E84 File Offset: 0x00037084
		internal List<GClass145.GStruct102> method_138()
		{
			List<GClass145.GStruct102> list = new List<GClass145.GStruct102>();
			list.AddRange(this.list_25);
			if (this.bool_159)
			{
				list.AddRange(this.list_26);
			}
			return list;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00038EBC File Offset: 0x000370BC
		internal void method_139(bool bool_168)
		{
			this.bool_60 = bool_168;
			this.gclass40_0.bool_47 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00038EE4 File Offset: 0x000370E4
		internal bool method_140(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.int_24 > 0 || this.int_25 > 0)
				{
					if (this.bool_10 && bool_170)
					{
						string str = ": LimitMeshes_Preliminary();";
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str);
						}
					}
					Transform[] array = GClass84.smethod_1519(transform_0);
					List<GClass145.GStruct100> list = new List<GClass145.GStruct100>();
					bool flag = this.bool_8 && bool_170 && this.bool_92 && (!bool_168 || (!this.bool_93 && !this.bool_9));
					bool result2 = false;
					List<Object> list2 = new List<Object>();
					for (int i = 0; i < array.Length; i++)
					{
						if (this.int_50 >= this.int_49)
						{
							this.bool_156 = false;
							IL_5B8:
							if (list2.Count > 0)
							{
								this.method_248(transform_0, list2);
							}
							return result2;
						}
						MeshFilter component = array[i].GetComponent<MeshFilter>();
						SkinnedMeshRenderer skinnedMeshRenderer = null;
						Mesh mesh = null;
						bool flag2 = false;
						GClass145.GStruct100 gstruct = default(GClass145.GStruct100);
						bool flag3 = false;
						if (component)
						{
							list2.Add(component);
							mesh = component.sharedMesh;
							if (mesh)
							{
								flag2 = true;
							}
						}
						else if (!this.bool_88)
						{
							skinnedMeshRenderer = array[i].GetComponent<SkinnedMeshRenderer>();
							if (skinnedMeshRenderer)
							{
								list2.Add(skinnedMeshRenderer);
								if (!this.bool_89 || skinnedMeshRenderer.bones.Length < 1)
								{
									mesh = skinnedMeshRenderer.sharedMesh;
									if (mesh)
									{
										flag2 = true;
									}
								}
							}
						}
						if (flag2)
						{
							bool flag4 = false;
							bool flag5 = false;
							string name = mesh.name;
							int count = mesh.vertices.Count;
							int num = mesh.triangles.Count / 3;
							int j = list.Count - 1;
							while (j >= 0)
							{
								GClass145.GStruct100 gstruct2 = list[j];
								if (!(gstruct2.string_0 == name) || gstruct2.int_0 != count || gstruct2.int_1 != num)
								{
									j--;
								}
								else
								{
									if (this.int_24 > 0 && count > this.int_24 - gstruct2.int_2)
									{
										flag5 = true;
										gstruct = gstruct2;
									}
									else if (this.int_25 > 0 && num > this.int_25 - gstruct2.int_1)
									{
										flag5 = true;
										gstruct = gstruct2;
									}
									else
									{
										gstruct2.int_2 += count;
										gstruct2.int_3 += num;
										list[j] = gstruct2;
										flag4 = true;
									}
									IL_28C:
									if (flag5)
									{
										if (flag && this.int_47 < this.int_46)
										{
											string str2 = string.Concat(new string[]
											{
												": ",
												array[i].name,
												" ",
												"Used",
												" ",
												"Mesh",
												" ",
												name,
												" (",
												count.ToString(),
												" ",
												"Vertices",
												", ",
												num.ToString(),
												" ",
												"Triangles",
												") ",
												"And",
												" ",
												"Was",
												" ",
												"Removed",
												". ",
												"This",
												" ",
												"Mesh",
												" ",
												"Limited",
												" ",
												"By",
												" ",
												gstruct.int_2.ToString(),
												" ",
												"Vertices",
												" ",
												"And",
												" ",
												gstruct.int_3.ToString(),
												" ",
												"Triangles"
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str2);
											}
											this.int_47++;
										}
										this.int_50++;
										if (flag3)
										{
											GClass84.smethod_1522(mesh);
											GClass84.smethod_505(component, false);
											Il2CppArrayBase<MeshRenderer> components = array[i].GetComponents<MeshRenderer>();
											if (components.Count > 0 && !array[i].GetComponent<MeshFilter>())
											{
												for (int k = components.Count - 1; k >= 0; k--)
												{
													GClass84.smethod_424(components[k]);
												}
												goto IL_59D;
											}
											goto IL_59D;
										}
										else if (component)
										{
											component.sharedMesh = null;
											GClass84.smethod_505(component, false);
											Il2CppArrayBase<MeshRenderer> components2 = array[i].GetComponents<MeshRenderer>();
											if (components2.Count > 0 && !array[i].GetComponent<MeshFilter>())
											{
												for (int l = components2.Count - 1; l >= 0; l--)
												{
													GClass84.smethod_424(components2[l]);
												}
												goto IL_59D;
											}
											goto IL_59D;
										}
										else
										{
											if (skinnedMeshRenderer)
											{
												skinnedMeshRenderer.sharedMesh = null;
												GClass84.smethod_735(skinnedMeshRenderer);
												goto IL_59D;
											}
											goto IL_59D;
										}
									}
									else
									{
										if (!flag4)
										{
											list.Add(new GClass145.GStruct100(name, count, num, count, num));
											goto IL_59D;
										}
										goto IL_59D;
									}
								}
							}
							goto IL_28C;
						}
						IL_59D:;
					}
					goto IL_5B8;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000394C4 File Offset: 0x000376C4
		internal void method_141(bool bool_168)
		{
			this.bool_83 = bool_168;
			this.gclass40_0.bool_69 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000394EC File Offset: 0x000376EC
		internal void method_142(bool bool_168)
		{
			this.method_136(bool_168);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00039500 File Offset: 0x00037700
		internal void method_143(bool bool_168)
		{
			this.method_213(bool_168);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00039514 File Offset: 0x00037714
		private void method_144()
		{
			GClass40.smethod_6();
			this.gclass40_0 = GClass40.gclass40_0;
			this.bool_0 = this.gclass40_0.bool_0;
			this.bool_1 = this.gclass40_0.bool_1;
			this.bool_2 = this.gclass40_0.bool_2;
			this.bool_6 = this.gclass40_0.bool_3;
			this.bool_3 = this.gclass40_0.bool_4;
			this.bool_4 = this.gclass40_0.bool_5;
			this.bool_5 = this.gclass40_0.bool_6;
			this.bool_8 = this.gclass40_0.bool_7;
			this.bool_9 = this.gclass40_0.bool_8;
			this.bool_10 = this.gclass40_0.bool_9;
			this.bool_11 = this.gclass40_0.bool_10;
			GClass145.bool_165 = this.gclass40_0.bool_11;
			this.gclass107_0 = new GClass107();
			this.gclass107_0.method_10();
			this.list_13 = this.gclass107_0.list_0;
			this.list_21 = this.gclass107_0.list_2;
			this.list_23 = this.gclass107_0.list_4;
			this.list_25 = this.gclass107_0.list_6;
			this.list_27 = this.gclass107_0.list_7;
			this.bool_7 = this.gclass40_0.bool_12;
			this.bool_30 = this.gclass40_0.bool_13;
			this.bool_34 = this.gclass40_0.bool_14;
			this.bool_35 = this.gclass40_0.bool_15;
			this.bool_33 = this.gclass40_0.bool_16;
			this.bool_40 = this.gclass40_0.bool_17;
			this.bool_146 = this.gclass40_0.bool_18;
			this.bool_141 = this.gclass40_0.bool_19;
			this.bool_139 = this.gclass40_0.bool_20;
			this.bool_137 = this.gclass40_0.bool_21;
			this.bool_138 = this.gclass40_0.bool_22;
			this.bool_149 = this.gclass40_0.bool_23;
			this.bool_145 = this.gclass40_0.bool_24;
			this.bool_140 = this.gclass40_0.bool_25;
			this.bool_152 = this.gclass40_0.bool_26;
			this.bool_155 = this.gclass40_0.bool_27;
			this.bool_150 = this.gclass40_0.bool_28;
			this.bool_41 = this.gclass40_0.bool_29;
			this.bool_42 = this.gclass40_0.bool_30;
			this.bool_43 = this.gclass40_0.bool_31;
			this.bool_48 = this.gclass40_0.bool_32;
			this.bool_47 = this.gclass40_0.bool_33;
			this.bool_46 = this.gclass40_0.bool_34;
			this.bool_45 = this.gclass40_0.bool_35;
			this.bool_49 = this.gclass40_0.bool_36;
			this.bool_50 = this.gclass40_0.bool_37;
			this.bool_51 = this.gclass40_0.bool_38;
			this.bool_52 = this.gclass40_0.bool_39;
			this.bool_53 = this.gclass40_0.bool_40;
			this.bool_54 = this.gclass40_0.bool_41;
			this.bool_55 = this.gclass40_0.bool_42;
			this.bool_56 = this.gclass40_0.bool_43;
			this.bool_57 = this.gclass40_0.bool_44;
			this.bool_58 = this.gclass40_0.bool_45;
			this.bool_59 = this.gclass40_0.bool_46;
			this.bool_60 = this.gclass40_0.bool_47;
			this.bool_61 = this.gclass40_0.bool_48;
			this.bool_62 = this.gclass40_0.bool_49;
			this.bool_63 = this.gclass40_0.bool_50;
			this.bool_64 = this.gclass40_0.bool_51;
			this.bool_65 = this.gclass40_0.bool_52;
			this.bool_66 = this.gclass40_0.bool_53;
			this.bool_67 = this.gclass40_0.bool_54;
			this.bool_68 = this.gclass40_0.bool_55;
			this.bool_69 = this.gclass40_0.bool_56;
			this.bool_70 = this.gclass40_0.bool_57;
			this.bool_71 = this.gclass40_0.bool_58;
			this.int_20 = this.gclass40_0.int_0;
			this.bool_73 = this.gclass40_0.bool_59;
			this.bool_74 = this.gclass40_0.bool_60;
			this.bool_75 = this.gclass40_0.bool_61;
			this.bool_76 = this.gclass40_0.bool_62;
			this.bool_77 = this.gclass40_0.bool_63;
			this.bool_78 = this.gclass40_0.bool_64;
			this.bool_79 = this.gclass40_0.bool_65;
			this.bool_80 = this.gclass40_0.bool_66;
			this.bool_81 = this.gclass40_0.bool_67;
			this.bool_82 = this.gclass40_0.bool_68;
			this.bool_83 = this.gclass40_0.bool_69;
			this.bool_87 = this.gclass40_0.bool_70;
			this.bool_90 = this.gclass40_0.bool_71;
			this.bool_91 = this.gclass40_0.bool_72;
			this.bool_92 = this.gclass40_0.bool_73;
			this.bool_93 = this.gclass40_0.bool_74;
			this.bool_96 = this.gclass40_0.bool_75;
			this.bool_97 = this.gclass40_0.bool_76;
			this.bool_98 = this.gclass40_0.bool_77;
			this.bool_99 = this.gclass40_0.bool_78;
			this.bool_100 = this.gclass40_0.bool_79;
			this.bool_101 = this.gclass40_0.bool_80;
			this.bool_102 = this.gclass40_0.bool_81;
			this.bool_103 = this.gclass40_0.bool_82;
			this.bool_104 = this.gclass40_0.bool_83;
			this.bool_105 = this.gclass40_0.bool_84;
			this.bool_106 = this.gclass40_0.bool_85;
			this.bool_107 = this.gclass40_0.bool_86;
			this.bool_108 = this.gclass40_0.bool_87;
			this.bool_109 = this.gclass40_0.bool_88;
			this.bool_110 = this.gclass40_0.bool_89;
			this.bool_111 = this.gclass40_0.bool_90;
			this.bool_112 = this.gclass40_0.bool_91;
			this.bool_113 = this.gclass40_0.bool_92;
			this.bool_114 = this.gclass40_0.bool_93;
			this.bool_115 = this.gclass40_0.bool_94;
			this.bool_118 = this.gclass40_0.bool_95;
			this.bool_119 = this.gclass40_0.bool_96;
			this.bool_120 = this.gclass40_0.bool_97;
			this.bool_121 = this.gclass40_0.bool_98;
			this.bool_122 = this.gclass40_0.bool_99;
			this.bool_125 = this.gclass40_0.bool_100;
			this.bool_126 = this.gclass40_0.bool_101;
			this.bool_127 = this.gclass40_0.bool_102;
			this.bool_128 = this.gclass40_0.bool_103;
			this.bool_129 = this.gclass40_0.bool_104;
			this.bool_132 = this.gclass40_0.bool_105;
			this.bool_133 = this.gclass40_0.bool_106;
			this.bool_134 = this.gclass40_0.bool_107;
			this.bool_135 = this.gclass40_0.bool_108;
			this.bool_136 = this.gclass40_0.bool_109;
			this.int_46 = this.gclass40_0.int_1;
			this.bool_154 = this.gclass40_0.bool_110;
			this.bool_161 = this.gclass40_0.bool_111;
			this.bool_162 = this.gclass40_0.bool_112;
			this.bool_163 = this.gclass40_0.bool_113;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00039D50 File Offset: 0x00037F50
		internal void method_145()
		{
			this.method_333();
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00039D64 File Offset: 0x00037F64
		internal void method_146(GameObject gameObject_0, List<GameObject> list_30, bool bool_168)
		{
			this.method_127(gameObject_0, list_30, bool_168);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00039D7C File Offset: 0x00037F7C
		internal void method_147(bool bool_168)
		{
			this.method_557(bool_168);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00039D90 File Offset: 0x00037F90
		private static bool smethod_7(ApiAvatar apiAvatar_0)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22("VRCAvatarManager_Private_ApiAvatar" + ": " + apiAvatar_0.id);
				}
				else
				{
					GClass145.smethod_22("VRCAvatarManager_Private_ApiAvatar()");
				}
			}
			return !GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, "")));
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00039E28 File Offset: 0x00038028
		internal void method_148(bool bool_168)
		{
			this.method_410(bool_168);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00039E3C File Offset: 0x0003803C
		internal void method_149(bool bool_168)
		{
			this.bool_48 = bool_168;
			this.gclass40_0.bool_32 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00039E64 File Offset: 0x00038064
		internal void method_150(bool bool_168)
		{
			this.method_394(bool_168);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00039E78 File Offset: 0x00038078
		internal void method_151(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitFinalIK();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool flag = this.bool_8 && bool_170 && this.bool_114 && (!bool_168 || (!this.bool_115 && !this.bool_9));
				List<Object> list = new List<Object>();
				List<AimIK> list2 = GClass84.smethod_1223(transform_0);
				list.AddRange(list2);
				for (int i = 0; i < list2.Count; i++)
				{
					IKSolverAim solver = list2[i].solver;
					if (solver != null && solver.maxIterations > this.int_31)
					{
						if (flag)
						{
							string str2 = string.Concat(new string[]
							{
								": ",
								list2[i].gameObject.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Iterations",
								" ",
								"Per",
								" ",
								"Second",
								" ",
								"For",
								" ",
								"AimIK",
								" (",
								solver.maxIterations.ToString(),
								")",
								". ",
								"Changed",
								" ",
								"To",
								" ",
								this.int_31.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str2);
							}
						}
						solver.maxIterations = this.int_31;
					}
				}
				List<FABRIK> list3 = GClass84.smethod_386(transform_0);
				list.AddRange(list3);
				for (int j = 0; j < list3.Count; j++)
				{
					IKSolverFABRIK solver2 = list3[j].solver;
					if (solver2 != null && solver2.maxIterations > this.int_31)
					{
						if (flag)
						{
							string str3 = string.Concat(new string[]
							{
								": ",
								list3[j].gameObject.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Iterations",
								" ",
								"Per",
								" ",
								"Second",
								" ",
								"For",
								" ",
								"AimIK",
								" (",
								solver2.maxIterations.ToString(),
								")",
								". ",
								"Changed",
								" ",
								"To",
								" ",
								this.int_31.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str3);
							}
						}
						solver2.maxIterations = this.int_31;
					}
				}
				List<CCDIK> list4 = GClass84.smethod_537(transform_0);
				list.AddRange(list4);
				for (int k = 0; k < list4.Count; k++)
				{
					IKSolverCCD solver3 = list4[k].solver;
					if (solver3 != null && solver3.maxIterations > this.int_31)
					{
						if (flag)
						{
							string str4 = string.Concat(new string[]
							{
								": ",
								list4[k].gameObject.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Iterations",
								" ",
								"Per",
								" ",
								"Second",
								" ",
								"For",
								" ",
								"AimIK",
								" (",
								solver3.maxIterations.ToString(),
								")",
								". ",
								"Changed",
								" ",
								"To",
								" ",
								this.int_31.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str4);
							}
						}
						solver3.maxIterations = this.int_31;
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0003A46C File Offset: 0x0003866C
		internal void method_152(bool bool_168)
		{
			this.method_439(bool_168);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0003A480 File Offset: 0x00038680
		internal void method_153(bool bool_168)
		{
			this.method_380(bool_168);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0003A494 File Offset: 0x00038694
		internal void method_154(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForRigidBodyCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				Rigidbody[] array = transform_0.GetComponentsInChildren<Rigidbody>(true);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					if (array[i].drag > 1000f)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Drag",
							" ",
							"Of",
							" ",
							"Rigidbody",
							" (",
							array[i].drag.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						array[i].drag = 1000f;
					}
					if (array[i].angularDrag > 1000f)
					{
						string str3 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Angular",
							" ",
							"Drag",
							" ",
							"Of",
							" ",
							"Rigidbody",
							" (",
							array[i].angularDrag.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str3);
						}
						array[i].angularDrag = 1000f;
					}
					if (array[i].maxDepenetrationVelocity > 1000f)
					{
						string str4 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Max",
							" ",
							"Depenetration",
							" ",
							"Velocity",
							" ",
							"Of",
							" ",
							"Rigidbody",
							" (",
							array[i].maxDepenetrationVelocity.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str4);
						}
						array[i].maxDepenetrationVelocity = 1000f;
					}
					if (array[i].inertiaTensor.x > 1000f || array[i].inertiaTensor.y > 1000f || array[i].inertiaTensor.z > 1000f)
					{
						Vector3 inertiaTensor = array[i].inertiaTensor;
						if (inertiaTensor.x > 1000f)
						{
							inertiaTensor.x = 1000f;
						}
						if (inertiaTensor.x < -1000f)
						{
							inertiaTensor.x = -1000f;
						}
						if (inertiaTensor.y > 1000f)
						{
							inertiaTensor.y = 1000f;
						}
						if (inertiaTensor.y < -1000f)
						{
							inertiaTensor.y = -1000f;
						}
						if (inertiaTensor.z > 1000f)
						{
							inertiaTensor.z = 1000f;
						}
						if (inertiaTensor.z < -1000f)
						{
							inertiaTensor.z = -1000f;
						}
						string str5 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Inertiar",
							" ",
							"Tensor",
							" ",
							"Of",
							" ",
							"Rigidbody",
							" (",
							array[i].inertiaTensor.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							inertiaTensor.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str5)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str5);
						}
						array[i].angularDrag = 1000f;
					}
				}
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0003AB54 File Offset: 0x00038D54
		internal void method_155(bool bool_168)
		{
			this.method_464(bool_168);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0003AB68 File Offset: 0x00038D68
		private void method_156(Object object_0)
		{
			if (object_0)
			{
				this.list_16.Add(object_0);
				GClass84.smethod_661<Object>(ref this.list_16);
				GClass84.smethod_1233<Object>(this.list_16);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0003ABA4 File Offset: 0x00038DA4
		private static IntPtr smethod_8(IntPtr intptr_2, IntPtr intptr_3)
		{
			IntPtr result;
			if (!GClass145.bool_166)
			{
				result = IntPtr.Zero;
			}
			else
			{
				if (GClass145.delegate23_0 == null)
				{
					GClass145.delegate23_0 = Marshal.GetDelegateForFunctionPointer<GClass145.Delegate23>(GClass145.intptr_0);
				}
				result = GClass145.delegate23_0(intptr_2, intptr_3);
			}
			return result;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003ABF0 File Offset: 0x00038DF0
		private static bool smethod_9(ApiAvatar apiAvatar_0)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22("AssetBundleDownloadManager_Method_Internal_Void_ApiAvatar" + ": " + apiAvatar_0.id);
					string id = apiAvatar_0.id;
					if (id != string.Empty)
					{
						GClass145.smethod_22("AssetBundleDownloadManager_Method_Internal_Void_ApiAvatar" + ": " + apiAvatar_0.id);
					}
				}
				else
				{
					GClass145.smethod_22("AssetBundleDownloadManager_Method_Internal_Void_ApiAvatar()");
				}
			}
			bool result;
			if (apiAvatar_0 != null)
			{
				GClass84.gclass39_0.method_64(apiAvatar_0);
				GClass84.gclass39_0.method_45(apiAvatar_0);
				result = (!GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, ""))));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0003ACDC File Offset: 0x00038EDC
		internal void method_157(bool bool_168)
		{
			this.bool_120 = bool_168;
			this.gclass40_0.bool_97 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0003AD04 File Offset: 0x00038F04
		private void method_158(Transform transform_0, Transform transform_1, ParticleSystem particleSystem_0, string string_3, ConsoleColor consoleColor_0, ref List<GClass145.GStruct99> list_30, ref int int_54, ref int int_55, ref int int_56, ref List<Object> list_31, bool bool_168 = true, bool bool_169 = false)
		{
			this.method_19(transform_0, transform_1, particleSystem_0, string_3, consoleColor_0, ref list_30, ref int_54, ref int_55, ref int_56, ref list_31, bool_168, bool_169);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0003AD40 File Offset: 0x00038F40
		internal void method_159(bool bool_168)
		{
			this.method_470(bool_168);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0003AD54 File Offset: 0x00038F54
		internal void method_160(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168)
		{
			this.method_134(transform_0, string_3, consoleColor_0, bool_168);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0003AD70 File Offset: 0x00038F70
		private static void smethod_10(IntPtr intptr_2)
		{
			GClass145.smethod_11(intptr_2);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003AD84 File Offset: 0x00038F84
		internal void method_161(bool bool_168)
		{
			this.bool_134 = bool_168;
			this.gclass40_0.bool_107 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0003ADAC File Offset: 0x00038FAC
		internal void method_162(bool bool_168)
		{
			this.bool_133 = bool_168;
			this.gclass40_0.bool_106 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0003ADD4 File Offset: 0x00038FD4
		internal void method_163(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			this.method_151(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		internal void method_164(bool bool_168)
		{
			this.bool_76 = bool_168;
			this.gclass40_0.bool_62 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0003AE20 File Offset: 0x00039020
		internal void method_165(bool bool_168)
		{
			GClass145.bool_165 = bool_168;
			this.gclass40_0.bool_11 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0003AE44 File Offset: 0x00039044
		internal void method_166(Transform transform_0)
		{
			if (transform_0)
			{
				new GameObject(this.string_1)
				{
					transform = 
					{
						parent = transform_0,
						localPosition = new Vector3(0f, 0f, 0f),
						localRotation = new Quaternion(0f, 0f, 0f, 0f)
					}
				}.SetActive(false);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0003AEC0 File Offset: 0x000390C0
		internal bool method_167(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitLights();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_76 && (!bool_168 || (!this.bool_77 && !this.bool_9));
				List<Object> list = new List<Object>();
				int num = 1;
				int num2 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					Light component = array[i].GetComponent<Light>();
					if (component)
					{
						if (num > this.int_22)
						{
							num2++;
							if (array[i].childCount > 0)
							{
								GClass84.smethod_761(component);
							}
							else
							{
								GClass84.smethod_890(array[i].gameObject, false);
							}
						}
						else
						{
							if (component.intensity > (float)this.int_23)
							{
								if (flag && this.int_47 < this.int_46)
								{
									string str2 = string.Concat(new string[]
									{
										": ",
										array[i].name,
										" ",
										"Used",
										" ",
										"Light",
										" ",
										"Intensity",
										" ",
										component.intensity.ToString(),
										". ",
										"Changed",
										" ",
										"To",
										" ",
										this.int_23.ToString()
									});
									if (this.bool_11)
									{
										GClass145.smethod_14(new List<GClass84.GStruct172>
										{
											new GClass84.GStruct172(consoleColor_0, string_3),
											new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
										});
									}
									else
									{
										GClass145.smethod_22(string_3 + str2);
									}
									this.int_47++;
								}
								component.intensity = (float)this.int_23;
							}
							num++;
							list.Add(component);
						}
					}
				}
				if (num2 > 0 && flag && this.int_47 < this.int_46)
				{
					string str3 = string.Concat(new string[]
					{
						": ",
						"Lights",
						" ",
						"Were",
						" ",
						"Limited",
						" ",
						"By",
						" ",
						this.int_22.ToString(),
						". ",
						num2.ToString(),
						" ",
						"Lights",
						" ",
						"Were",
						" ",
						"Destroyed"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str3);
					}
					this.int_47++;
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				result = (num2 > 0);
			}
			return result;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0003B258 File Offset: 0x00039458
		internal void method_168(bool bool_168)
		{
			this.method_119(bool_168);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0003B26C File Offset: 0x0003946C
		internal void method_169(bool bool_168)
		{
			this.method_131(bool_168);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0003B280 File Offset: 0x00039480
		private unsafe static void smethod_11(IntPtr intptr_2)
		{
			if (GClass145.int_53 > 0)
			{
				void* ptr = (void*)(intptr_2 + 48);
				*(byte*)ptr = (*(byte*)ptr & 239);
			}
			GClass145.delegate20_0(intptr_2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0003B2BC File Offset: 0x000394BC
		public override void vmethod_22()
		{
			this.method_145();
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0003B2D0 File Offset: 0x000394D0
		internal void method_170(bool bool_168)
		{
			this.method_125(bool_168);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0003B2E4 File Offset: 0x000394E4
		internal void method_171(bool bool_168)
		{
			this.bool_58 = bool_168;
			this.gclass40_0.bool_45 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0003B30C File Offset: 0x0003950C
		internal void method_172(bool bool_168)
		{
			this.method_161(bool_168);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0003B320 File Offset: 0x00039520
		private void method_173()
		{
			this.method_44();
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003B334 File Offset: 0x00039534
		public override void vmethod_23()
		{
			this.method_350();
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0003B348 File Offset: 0x00039548
		private static string smethod_12(IntPtr intptr_2)
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(intptr_2)).ToString();
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0003B368 File Offset: 0x00039568
		internal void method_174(bool bool_168)
		{
			this.method_97(bool_168);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0003B37C File Offset: 0x0003957C
		internal void method_175(bool bool_168)
		{
			this.bool_129 = bool_168;
			this.gclass40_0.bool_104 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003B3A4 File Offset: 0x000395A4
		internal void method_176(Transform transform_0)
		{
			this.method_108(transform_0);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003B3B8 File Offset: 0x000395B8
		internal static void smethod_13(IntPtr intptr_2, IntPtr intptr_3, byte byte_0)
		{
			GClass145.smethod_33(intptr_2, intptr_3, byte_0);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003B3D0 File Offset: 0x000395D0
		internal static void smethod_14(List<GClass84.GStruct172> list_30)
		{
			GClass145.smethod_58(list_30);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003B3E4 File Offset: 0x000395E4
		internal void method_177(bool bool_168)
		{
			this.method_494(bool_168);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003B3F8 File Offset: 0x000395F8
		internal void method_178(bool bool_168)
		{
			this.method_28(bool_168);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003B40C File Offset: 0x0003960C
		internal void method_179(bool bool_168)
		{
			this.bool_43 = bool_168;
			this.gclass40_0.bool_31 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003B434 File Offset: 0x00039634
		internal void method_180(bool bool_168)
		{
			this.bool_149 = bool_168;
			this.gclass40_0.bool_23 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003B45C File Offset: 0x0003965C
		private unsafe static IntPtr smethod_15(ref IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6)
		{
			IntPtr intPtr = GClass145.delegate13_0(ref intptr_2, intptr_3, intptr_4, intptr_5, intptr_6);
			IntPtr result;
			if (intptr_2 == IntPtr.Zero || GClass145.stack_0 == null || GClass145.stack_0.Count == 0)
			{
				result = intPtr;
			}
			else
			{
				IntPtr intPtr2 = *(IntPtr*)((void*)intptr_2);
				GClass145.Struct12* ptr = (GClass145.Struct12*)((void*)GClass145.stack_0.Peek());
				GClass145.Struct11* pStruct11_ = ptr->pStruct11_0;
				IntPtr intPtr3 = IL2CPP.il2cpp_class_from_type(pStruct11_->intptr_1);
				if (IL2CPP.il2cpp_class_is_assignable_from(intPtr3, intPtr2))
				{
					result = intPtr;
				}
				else
				{
					string text = Marshal.PtrToStringAnsi(pStruct11_->intptr_0);
					GClass145.smethod_22(string.Concat(new string[]
					{
						"While deserializing field of type ",
						GClass145.smethod_3(intPtr3),
						" named ",
						text,
						" we got an object of type ",
						GClass145.smethod_3(intPtr2)
					}));
					intptr_2 = IntPtr.Zero;
					result = intPtr;
				}
			}
			return result;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0003B540 File Offset: 0x00039740
		internal void method_181(GameObject gameObject_0, bool bool_168)
		{
			this.method_531(gameObject_0, bool_168);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003B558 File Offset: 0x00039758
		private void method_182(GameObject gameObject_0, bool bool_168 = true)
		{
			this.method_115(gameObject_0, bool_168);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003B570 File Offset: 0x00039770
		private static bool smethod_16(AssetBundleDownload assetBundleDownload_0)
		{
			if (assetBundleDownload_0.field_Private_ContentType_0 == 1 && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), assetBundleDownload_0.field_Private_String_0, ""))
			{
				assetBundleDownload_0.field_Private_String_0 = "avtr_c38a1615-5bf5-42b4-84eb-a8b6c37cbd11";
				assetBundleDownload_0.field_Private_String_1 = "https://0.0.0.0/blocked.dat";
			}
			return true;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003B5BC File Offset: 0x000397BC
		internal void method_183(bool bool_168)
		{
			this.method_104(bool_168);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003B5D0 File Offset: 0x000397D0
		internal void method_184(bool bool_168)
		{
			this.bool_139 = bool_168;
			this.gclass40_0.bool_20 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003B5F8 File Offset: 0x000397F8
		internal void method_185(bool bool_168)
		{
			this.method_300(bool_168);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0003B77C File Offset: 0x0003997C
		internal void method_186(bool bool_168)
		{
			this.method_65(bool_168);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003B790 File Offset: 0x00039990
		internal void method_187(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitChildrenGeneration();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				List<Transform> list = GClass84.smethod_1687(transform_0, this.int_33);
				bool flag = this.bool_8 && bool_170 && this.bool_121 && (!bool_168 || (!this.bool_122 && !this.bool_9));
				for (int i = list.Count - 1; i >= 0; i--)
				{
					GClass84.smethod_890(list[i].gameObject, false);
				}
				if (list.Count > 0 && flag)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						list.Count.ToString(),
						" ",
						"Children",
						" ",
						"Generations",
						" ",
						"Were",
						" ",
						"Limited",
						" ",
						"To",
						" ",
						this.int_33.ToString()
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003B94C File Offset: 0x00039B4C
		internal void method_188(bool bool_168)
		{
			this.bool_50 = bool_168;
			this.gclass40_0.bool_37 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003B974 File Offset: 0x00039B74
		internal void method_189(bool bool_168)
		{
			this.method_260(bool_168);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003B988 File Offset: 0x00039B88
		internal void method_190(List<GClass84.GStruct146> list_30)
		{
			this.method_423(list_30);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003B99C File Offset: 0x00039B9C
		internal void method_191(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForBlendShapeCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				SkinnedMeshRenderer[] array = transform_0.GetComponentsInChildren<SkinnedMeshRenderer>(true);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					Mesh sharedMesh = array[i].sharedMesh;
					if (sharedMesh)
					{
						List<GClass84.GStruct134> list = GClass84.smethod_90(sharedMesh);
						for (int j = list.Count - 1; j >= 0; j--)
						{
							if (list[j].string_0 == "Key 56 - Reverted")
							{
								string str2 = string.Concat(new string[]
								{
									": ",
									array[i].name,
									" ",
									"Had",
									" ",
									"Malicious",
									" ",
									"Blend",
									" ",
									"Shapes",
									". ",
									"Removed",
									" ",
									"Blend",
									" ",
									"Shapes"
								});
								if (this.bool_11)
								{
									GClass145.smethod_14(new List<GClass84.GStruct172>
									{
										new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
										new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
									});
								}
								else
								{
									GClass145.smethod_22(string_3 + str2);
								}
								sharedMesh.ClearBlendShapes();
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003BB6C File Offset: 0x00039D6C
		private unsafe static void smethod_17(GClass145.Struct14* pStruct14_1, long long_0)
		{
			/*
An exception occurred when decompiling this method (06000C76)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns441.GClass145::smethod_17(ns441.GClass145/Struct14*,System.Int64)
 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.SubstituteTypeArgs(TypeSig type, TypeSig typeContext, IMethod method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 977
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.GetFieldType(IField field) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 969
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 433
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003BBDC File Offset: 0x00039DDC
		internal void method_192(bool bool_168)
		{
			this.method_75(bool_168);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003BBF0 File Offset: 0x00039DF0
		private static IntPtr smethod_18()
		{
			return IntPtr.Zero;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003BC04 File Offset: 0x00039E04
		internal bool method_193(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, Transform transform_1 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10)
				{
					string str = ": LimitScale();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				List<Transform> list = GClass84.smethod_125(transform_0);
				bool flag = false;
				for (int i = list.Count - 1; i >= 0; i--)
				{
					Vector3 lossyScale = list[i].lossyScale;
					Vector3 localScale = list[i].localScale;
					bool flag2 = false;
					if (lossyScale.x > this.float_1)
					{
						localScale.x = this.float_1 * (localScale.x / lossyScale.x);
						lossyScale.x = this.float_1;
						flag2 = true;
					}
					else if (lossyScale.x < -this.float_1)
					{
						localScale.x = -this.float_1 * (localScale.x / lossyScale.x);
						lossyScale.x = -this.float_1;
						flag2 = true;
					}
					if (lossyScale.y > this.float_1)
					{
						localScale.y = this.float_1 * (localScale.y / lossyScale.y);
						lossyScale.y = this.float_1;
						flag2 = true;
					}
					else if (lossyScale.y < -this.float_1)
					{
						localScale.y = -this.float_1 * (localScale.y / lossyScale.y);
						lossyScale.y = -this.float_1;
						flag2 = true;
					}
					if (lossyScale.z > this.float_1)
					{
						localScale.z = this.float_1 * (localScale.z / lossyScale.z);
						lossyScale.z = this.float_1;
						flag2 = true;
					}
					else if (lossyScale.z < -this.float_1)
					{
						localScale.z = -this.float_1 * (localScale.z / lossyScale.z);
						lossyScale.z = -this.float_1;
						flag2 = true;
					}
					if (flag2)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							list[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Scale",
							" ",
							list[i].lossyScale.ToString(),
							". ",
							"Limited",
							" ",
							"To",
							" ",
							lossyScale.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						list[i].localScale = localScale;
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003BF58 File Offset: 0x0003A158
		internal void method_194(bool bool_168)
		{
			this.bool_67 = bool_168;
			this.gclass40_0.bool_54 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003BF80 File Offset: 0x0003A180
		internal void method_195(bool bool_168)
		{
			this.bool_5 = bool_168;
			this.gclass40_0.bool_6 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
		internal void method_196(bool bool_168)
		{
			this.bool_11 = bool_168;
			this.gclass40_0.bool_10 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003BFD0 File Offset: 0x0003A1D0
		internal bool method_197(Transform transform_0)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				for (int i = transform_0.childCount - 1; i >= 0; i--)
				{
					if (transform_0.GetChild(i).name == this.string_1)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003C024 File Offset: 0x0003A224
		internal void method_198(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, bool bool_171, Transform transform_1)
		{
			this.method_296(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, bool_171, transform_1);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003C050 File Offset: 0x0003A250
		internal void method_199(bool bool_168)
		{
			this.bool_55 = bool_168;
			this.gclass40_0.bool_42 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003C078 File Offset: 0x0003A278
		internal void method_200(GameObject gameObject_0, List<GameObject> list_30, bool bool_168 = false)
		{
			this.method_146(gameObject_0, list_30, bool_168);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003C090 File Offset: 0x0003A290
		private static IntPtr smethod_19(IntPtr intptr_2, uint uint_0, uint uint_1)
		{
			return GClass145.delegate15_0(intptr_2, uint_0, uint_1);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003C0AC File Offset: 0x0003A2AC
		private static IEnumerator smethod_20()
		{
			return new GClass145.Class86(0);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003C0C0 File Offset: 0x0003A2C0
		internal List<string> method_201(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false, Transform transform_1 = null, bool bool_172 = false, Transform transform_2 = null, bool bool_173 = true, Transform transform_3 = null)
		{
			List<string> list = new List<string>();
			if (transform_0)
			{
				if (this.bool_10 && bool_170 && !bool_172)
				{
					string str = ": CheckForSimilarObjects();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				if (!transform_2)
				{
					transform_2 = transform_0;
				}
				if (bool_171 && !transform_1)
				{
					transform_1 = transform_0;
				}
				if (!bool_172)
				{
					if (this.list_17 == null)
					{
						this.list_17 = new List<GClass84.GStruct136>();
					}
					else
					{
						this.list_17.Clear();
					}
					this.list_17.AddRange(this.list_18);
					if (this.list_19 == null)
					{
						this.list_19 = new List<GClass84.GStruct146>();
					}
					else
					{
						this.list_19.Clear();
					}
					this.list_19.AddRange(this.list_20);
				}
				Transform[] array = GClass84.smethod_1141(transform_0);
				List<GClass145.GStruct101> list2 = new List<GClass145.GStruct101>();
				bool flag = this.bool_8 && bool_170 && this.bool_49 && (!bool_168 || (!this.bool_50 && !this.bool_9));
				List<Object> list3 = new List<Object>();
				List<GameObject> list4 = new List<GameObject>();
				List<Object> list5 = new List<Object>();
				for (int i = 0; i < array.Length; i++)
				{
					if (this.int_50 >= this.int_49)
					{
						this.bool_156 = false;
						IL_A6F:
						if (list3.Count > 0)
						{
							if (bool_172)
							{
								this.list_15.AddRange(list3);
								list3.Clear();
							}
							else
							{
								if (this.list_15.Count > 0)
								{
									list3.AddRange(this.list_15);
									this.list_15.Clear();
								}
								this.method_248(transform_0, list3);
							}
						}
						if (list4.Count > 0)
						{
							this.method_283(list4, false);
						}
						list4.Clear();
						if (list5.Count > 0)
						{
							this.method_17(list5);
						}
						list5.Clear();
						if (list2 != null)
						{
							list2.Clear();
						}
						return list;
					}
					if (array[i].childCount > 0)
					{
						if (bool_171)
						{
							list.AddRange(this.method_201(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1, true, transform_2, bool_173, transform_3));
						}
						else
						{
							this.method_201(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, false, transform_1, true, transform_2, bool_173, transform_3);
						}
					}
					else if (!array[i].GetComponent<ParticleSystem>())
					{
						MeshFilter component = array[i].GetComponent<MeshFilter>();
						SkinnedMeshRenderer skinnedMeshRenderer = null;
						bool flag2 = false;
						string empty = string.Empty;
						Mesh mesh = null;
						int num = 0;
						bool flag3 = false;
						if (component)
						{
							mesh = this.method_49(array[i], transform_3, GClass84.smethod_908(array[i], transform_2), GClass145.Enum2.const_0, out flag3, out flag2, out empty, false);
							if (mesh)
							{
								num = mesh.subMeshCount;
								if (bool_173)
								{
									list3.Add(mesh);
								}
							}
						}
						else if (!this.bool_44)
						{
							skinnedMeshRenderer = array[i].GetComponent<SkinnedMeshRenderer>();
							if (skinnedMeshRenderer)
							{
								mesh = this.method_49(array[i], transform_3, GClass84.smethod_908(array[i], transform_2), GClass145.Enum2.const_1, out flag3, out flag2, out empty, false);
								if (mesh)
								{
									num = mesh.subMeshCount;
								}
							}
						}
						if (mesh)
						{
							List<GClass145.GStruct101> list6 = new List<GClass145.GStruct101>();
							bool flag4 = false;
							bool flag5 = false;
							for (int j = list2.Count - 1; j >= 0; j--)
							{
								if (empty == list2[j].string_0 && (list2[j].transform_0.position == array[i].position || (this.int_5 > 0 && this.method_209(list2[j].transform_0.position, array[i].position, this.int_5, this.int_6, this.float_2, this.float_3, this.float_4))) && ((flag2 && list2[j].bool_0) || list2[j].transform_0.rotation == array[i].rotation) && (list2[j].transform_0.lossyScale == array[i].lossyScale || (this.int_7 > 0 && this.method_209(list2[j].transform_0.lossyScale, array[i].lossyScale, this.int_7, this.int_8, this.float_5, this.float_6, this.float_7))))
								{
									list6.Add(list2[j]);
								}
							}
							if (list6.Count <= 0)
							{
								Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
								for (int k = 0; k < components.Count; k++)
								{
									if (!components[k].TryCast<ParticleSystemRenderer>() && !components[k].TryCast<LineRenderer>() && !components[k].TryCast<TrailRenderer>())
									{
										Il2CppReferenceArray<Material> sharedMaterialArray = components[k].GetSharedMaterialArray();
										if (sharedMaterialArray.Length == 0)
										{
											if (array[i].childCount == 0)
											{
												array[i].gameObject.SetActive(false);
											}
											components[k].enabled = false;
										}
										else
										{
											if (this.bool_45 && sharedMaterialArray.Length > 1)
											{
												Material material = null;
												bool flag6 = false;
												int num2 = GClass84.smethod_741(sharedMaterialArray.Length, num);
												for (int l = 1; l < num2; l++)
												{
													if (material)
													{
														if (material.name != sharedMaterialArray[l].name)
														{
															flag6 = true;
															IL_554:
															if (!flag6)
															{
																flag5 = true;
																goto IL_563;
															}
															goto IL_563;
														}
													}
													else
													{
														material = sharedMaterialArray[l];
													}
												}
												goto IL_554;
											}
											flag5 = true;
										}
									}
									IL_563:;
								}
								if (flag5)
								{
									list2.Add(new GClass145.GStruct101(array[i], flag2, empty, num, 1, list2.Count));
								}
							}
							else
							{
								Transform transform = null;
								Il2CppArrayBase<Renderer> components2 = array[i].GetComponents<Renderer>();
								for (int m = 0; m < components2.Count; m++)
								{
									if (!components2[m].TryCast<ParticleSystemRenderer>() && !components2[m].TryCast<LineRenderer>() && !components2[m].TryCast<TrailRenderer>())
									{
										Il2CppReferenceArray<Material> sharedMaterialArray2 = components2[m].GetSharedMaterialArray();
										int length = sharedMaterialArray2.Length;
										if (flag4)
										{
											components2[m].enabled = false;
											if (length > 0)
											{
												components2[m].SetMaterialArray(new Il2CppReferenceArray<Material>(0L));
											}
										}
										else if (length == 0)
										{
											if (array[i].childCount == 0)
											{
												array[i].gameObject.SetActive(false);
											}
											components2[m].enabled = false;
										}
										else
										{
											for (int n = 0; n < list6.Count; n++)
											{
												if (num == list6[n].int_0)
												{
													Il2CppArrayBase<Renderer> components3 = list6[n].transform_0.GetComponents<Renderer>();
													for (int num3 = 0; num3 < components3.Count; num3++)
													{
														if (!components3[num3].TryCast<ParticleSystemRenderer>() && !components3[num3].TryCast<LineRenderer>() && !components3[num3].TryCast<TrailRenderer>())
														{
															Il2CppReferenceArray<Material> sharedMaterialArray3 = components3[num3].GetSharedMaterialArray();
															if (sharedMaterialArray3.Length > 0)
															{
																int num4 = GClass84.smethod_741(length, sharedMaterialArray3.Length);
																if (num4 > num)
																{
																	num4 = num;
																}
																int num5 = 0;
																while (num5 < num4 && !(sharedMaterialArray2[num5].name != sharedMaterialArray3[num5].name))
																{
																	num5++;
																}
																if (num4 == num5)
																{
																	if (list6[n].int_1 < this.int_9)
																	{
																		GClass145.GStruct101 gstruct = list6[n];
																		gstruct.int_1++;
																		list6[n] = gstruct;
																		list2[gstruct.int_2] = gstruct;
																	}
																	else
																	{
																		array[i].gameObject.SetActive(false);
																		components2[m].enabled = false;
																		flag4 = true;
																		transform = list6[n].transform_0;
																		IL_81D:
																		if (!flag4)
																		{
																			goto IL_821;
																		}
																		goto IL_837;
																	}
																}
															}
														}
													}
													goto IL_81D;
												}
												IL_821:;
											}
											IL_837:
											if (!flag4)
											{
												if (this.bool_45 && length > 1)
												{
													Material material2 = null;
													bool flag7 = false;
													int num6 = GClass84.smethod_741(sharedMaterialArray2.Length, num);
													for (int num7 = 1; num7 < num6; num7++)
													{
														if (material2)
														{
															if (material2.name != sharedMaterialArray2[num7].name)
															{
																flag7 = true;
																IL_8B0:
																if (!flag7)
																{
																	flag5 = true;
																	goto IL_8BF;
																}
																goto IL_8BF;
															}
														}
														else
														{
															material2 = sharedMaterialArray2[num7];
														}
													}
													goto IL_8B0;
												}
												flag5 = true;
											}
										}
									}
									IL_8BF:;
								}
								if (list6 != null)
								{
									list6.Clear();
								}
								if (flag4)
								{
									if (bool_171)
									{
										list.Add(GClass84.smethod_908(array[i], transform_1));
									}
									if (flag && this.int_47 < this.int_46)
									{
										string str2 = string.Concat(new string[]
										{
											": ",
											array[i].name,
											" ",
											"Is",
											" ",
											"Similar",
											" ",
											"To",
											" ",
											transform.name,
											". ",
											"Was",
											" ",
											"Destroyed"
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str2);
										}
										this.int_47++;
									}
									if (flag3)
									{
										list5.Add(mesh);
									}
									else if (skinnedMeshRenderer)
									{
										skinnedMeshRenderer.sharedMesh = null;
									}
									GClass84.smethod_194(array[i]);
									list4.Add(array[i].gameObject);
									this.int_50++;
								}
								else if (flag5)
								{
									list2.Add(new GClass145.GStruct101(array[i], flag2, empty, num, 1, list2.Count));
								}
							}
						}
					}
				}
				goto IL_A6F;
			}
			return list;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003CBDC File Offset: 0x0003ADDC
		internal void method_202(bool bool_168)
		{
			this.method_185(bool_168);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
		private static bool smethod_21(string string_3, string string_4, int int_54, string string_5, string string_6, string string_7, ref string string_8)
		{
			bool result;
			if (string_7 == "vrca" && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), string_4, ""))
			{
				string_8 = null;
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003CC3C File Offset: 0x0003AE3C
		internal void method_203(bool bool_168)
		{
			this.method_169(bool_168);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0003CC50 File Offset: 0x0003AE50
		internal void method_204(bool bool_168)
		{
			this.bool_121 = bool_168;
			this.gclass40_0.bool_98 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0003CC78 File Offset: 0x0003AE78
		internal void method_205(bool bool_168)
		{
			this.method_128(bool_168);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		internal void method_206(bool bool_168)
		{
			this.method_113(bool_168);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0003CCA0 File Offset: 0x0003AEA0
		internal void method_207(bool bool_168)
		{
			this.method_258(bool_168);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0003CCB4 File Offset: 0x0003AEB4
		private void method_208()
		{
			try
			{
				for (int i = this.list_14.Count - 1; i >= 0; i--)
				{
					GClass145.Struct7 @struct = this.list_14[i];
					if (!@struct.object_0)
					{
						this.method_17(@struct.list_0);
						@struct.list_0.Clear();
						this.list_14.RemoveAt(i);
					}
				}
			}
			catch (Exception ex)
			{
				GClass145.smethod_2(ex.Message);
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0003CD44 File Offset: 0x0003AF44
		private bool method_209(Vector3 vector3_0, Vector3 vector3_1, int int_54, int int_55, float float_17 = 0f, float float_18 = 0f, float float_19 = 0f)
		{
			bool result;
			if (vector3_1 == vector3_0)
			{
				result = true;
			}
			else if (float_19 > 0f && GClass84.smethod_1494(vector3_0.x - vector3_1.x) <= float_19 && GClass84.smethod_1494(vector3_0.y - vector3_1.y) <= float_19 && GClass84.smethod_1494(vector3_0.z - vector3_1.z) <= float_19)
			{
				result = true;
			}
			else
			{
				int num = 1;
				int num2;
				int num3;
				int num4;
				int num5;
				int num6;
				int num7;
				if (int_54 > 0)
				{
					while (int_54 > 0)
					{
						num *= 10;
						int_54--;
					}
					num2 = (int)(vector3_0.x * (float)num);
					num3 = (int)(vector3_0.y * (float)num);
					num4 = (int)(vector3_0.z * (float)num);
					num5 = (int)(vector3_1.x * (float)num);
					num6 = (int)(vector3_1.y * (float)num);
					num7 = (int)(vector3_1.z * (float)num);
				}
				else
				{
					num2 = (int)vector3_0.x;
					num3 = (int)vector3_0.y;
					num4 = (int)vector3_0.z;
					num5 = (int)vector3_1.x;
					num6 = (int)vector3_1.y;
					num7 = (int)vector3_1.z;
				}
				if (float_18 > 0f)
				{
					int num8;
					if (num > 0)
					{
						num8 = (int)(float_18 * (float)num);
					}
					else
					{
						num8 = (int)float_18;
					}
					if (num2 > num8 && num5 > num8 && (num3 > num8 && num6 > num8) && (num4 > num8 && num7 > num8))
					{
						return true;
					}
				}
				result = ((int_55 > 0 && GClass84.smethod_624(num2 - num5) <= int_55 && GClass84.smethod_624(num3 - num6) <= int_55 && GClass84.smethod_624(num4 - num7) <= int_55) || (float_17 > 0f && (float)GClass84.smethod_624(num2 - num5) <= (float)GClass84.smethod_1690(num2, num5) * float_17 && (float)GClass84.smethod_624(num3 - num6) <= (float)GClass84.smethod_1690(num3, num6) * float_17 && (float)GClass84.smethod_624(num2 - num7) <= (float)GClass84.smethod_1690(num4, num7) * float_17));
			}
			return result;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0003CF68 File Offset: 0x0003B168
		internal void method_210(bool bool_168)
		{
			this.method_80(bool_168);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0003CF7C File Offset: 0x0003B17C
		internal static void smethod_22(string string_3)
		{
			GClass145.smethod_31(string_3);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_23(string string_3, ref AssetBundle assetBundle_0)
		{
			return true;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0003CF90 File Offset: 0x0003B190
		internal bool method_211(GameObject gameObject_0)
		{
			return gameObject_0 && this.method_197(gameObject_0.transform);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0003CFBC File Offset: 0x0003B1BC
		internal void method_212(bool bool_168)
		{
			this.method_486(bool_168);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		internal void method_213(bool bool_168)
		{
			this.method_157(bool_168);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		private static void smethod_24(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
		{
			if (GClass145.stack_0 == null)
			{
				GClass145.stack_0 = new Stack<IntPtr>();
			}
			GClass145.stack_0.Push(intptr_2);
			try
			{
				GClass145.delegate12_0(intptr_2, intptr_3, intptr_4);
			}
			finally
			{
				GClass145.stack_0.Pop();
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0003D038 File Offset: 0x0003B238
		private void method_214(Transform transform_0, List<Transform> list_30, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, VRCPlayerApi vrcplayerApi_0 = null, Transform transform_1 = null)
		{
			this.method_318(transform_0, list_30, string_3, consoleColor_0, bool_168, bool_169, vrcplayerApi_0, transform_1);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0003D064 File Offset: 0x0003B264
		internal void method_215(Transform transform_0, string string_3)
		{
			this.method_191(transform_0, string_3);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0003D07C File Offset: 0x0003B27C
		private void method_216(Object object_0, Object object_1)
		{
			if (object_0 && object_1)
			{
				for (int i = this.list_14.Count - 1; i >= 0; i--)
				{
					if (this.list_14[i].object_0 == object_0)
					{
						GClass145.Struct7 @struct = this.list_14[i];
						@struct.list_0.Add(object_1);
						GClass84.smethod_661<Object>(ref @struct.list_0);
						GClass84.smethod_1233<Object>(@struct.list_0);
						return;
					}
				}
				this.list_14.Add(new GClass145.Struct7(object_0, object_1));
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0003D11C File Offset: 0x0003B31C
		private void method_217(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, VRCPlayerApi vrcplayerApi_0, Transform transform_1)
		{
			if (transform_0)
			{
				if (vrcplayerApi_0 != null && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_219(), GClass84.smethod_538(vrcplayerApi_0), ""))
				{
					this.method_440(transform_0, true);
				}
				else
				{
					PipelineManager component = transform_0.GetComponent<PipelineManager>();
					if (component && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_138(), component.blueprintId, ""))
					{
						this.method_440(transform_0, true);
					}
					else
					{
						this.int_47 = 0;
						this.list_18.Clear();
						this.list_20.Clear();
						if (!this.bool_15)
						{
							if (this.bool_118 && ((!this.bool_119 || !bool_168) && (!this.bool_120 || !bool_169)))
							{
								try
								{
									this.method_491(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
								}
								catch (Exception ex)
								{
									GClass145.smethod_2("[Error]" + " " + ex.Message);
								}
							}
							if (this.bool_96 && ((!this.bool_97 || !bool_168) && (!this.bool_98 || !bool_169)))
							{
								try
								{
									this.method_330(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
								}
								catch (Exception ex2)
								{
									GClass145.smethod_2("[Error]" + " " + ex2.Message);
								}
							}
							if (this.bool_125 && ((!this.bool_126 || !bool_168) && (!this.bool_127 || !bool_169)))
							{
								try
								{
									this.method_94(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
								}
								catch (Exception ex3)
								{
									GClass145.smethod_2("[Error]" + " " + ex3.Message);
								}
							}
							if (this.bool_132 && ((!this.bool_133 || !bool_168) && (!this.bool_134 || !bool_169)))
							{
								try
								{
									this.method_129(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
								}
								catch (Exception ex4)
								{
									GClass145.smethod_2("[Error]" + " " + ex4.Message);
								}
							}
							if (this.bool_101 && ((!this.bool_102 || !bool_168) && (!this.bool_103 || !bool_169)))
							{
								try
								{
									this.method_462(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
								}
								catch (Exception ex5)
								{
									GClass145.smethod_2("[Error]" + " " + ex5.Message);
								}
							}
							if (this.bool_106 && ((!this.bool_107 || !bool_168) && (!this.bool_108 || !bool_169)))
							{
								try
								{
									this.method_498(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
								}
								catch (Exception ex6)
								{
									GClass145.smethod_2("[Error]" + " " + ex6.Message);
								}
							}
							if (this.bool_111 && ((!this.bool_112 || !bool_168) && (!this.bool_113 || !bool_169)))
							{
								try
								{
									this.method_273(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
								}
								catch (Exception ex7)
								{
									GClass145.smethod_2("[Error]" + " " + ex7.Message);
								}
							}
							if (this.bool_67 && ((!this.bool_68 || !bool_168) && (!this.bool_69 || !bool_169)))
							{
								try
								{
									this.method_135(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, null);
								}
								catch (Exception ex8)
								{
									GClass145.smethod_2("[Error]" + " " + ex8.Message);
								}
							}
							if (this.bool_73 && ((!this.bool_74 || !bool_168) && (!this.bool_75 || !bool_169)))
							{
								try
								{
									this.method_167(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
								}
								catch (Exception ex9)
								{
									GClass145.smethod_2("[Error]" + " " + ex9.Message);
								}
							}
						}
						if (this.bool_87 && ((!this.bool_90 || !bool_168) && (!this.bool_91 || !bool_169)))
						{
							try
							{
								this.method_328(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1);
							}
							catch (Exception ex10)
							{
								GClass145.smethod_2("[Error]" + " " + ex10.Message);
							}
						}
						if (this.bool_41)
						{
							if (this.bool_46)
							{
								this.list_2.Add(new GClass145.Struct3(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, null, this.int_47));
								this.method_176(transform_0);
								return;
							}
							if ((!this.bool_42 || !bool_168) && (!this.bool_43 || !bool_169))
							{
								try
								{
									this.method_201(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, false, null, false, null, true, transform_1);
								}
								catch (Exception ex11)
								{
									GClass145.smethod_2("[Error]" + " " + ex11.Message);
								}
								this.method_340(this.list_17);
								this.method_539(this.list_19);
							}
						}
						if (this.bool_30 && ((!this.bool_34 || !bool_168) && (!this.bool_35 || !bool_169)))
						{
							try
							{
								this.method_457(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1);
							}
							catch (Exception ex12)
							{
								GClass145.smethod_2("[Error]" + " " + ex12.Message);
							}
							this.method_340(this.list_17);
							this.method_539(this.list_19);
						}
						if (this.bool_139)
						{
							if ((this.bool_137 && bool_168) || (this.bool_138 && bool_169))
							{
								goto IL_66E;
							}
							try
							{
								this.method_70(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
								goto IL_66E;
							}
							catch (Exception ex13)
							{
								GClass145.smethod_2("[Error]" + " " + ex13.Message);
								goto IL_66E;
							}
						}
						if (this.bool_141)
						{
							if ((this.bool_137 && bool_168) || (this.bool_138 && bool_169))
							{
								goto IL_66E;
							}
							try
							{
								this.method_87(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
								goto IL_66E;
							}
							catch (Exception ex14)
							{
								GClass145.smethod_2("[Error]" + " " + ex14.Message);
								goto IL_66E;
							}
						}
						if (this.bool_146 && ((!this.bool_137 || !bool_168) && (!this.bool_138 || !bool_169)))
						{
							try
							{
								this.method_502(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
							}
							catch (Exception ex15)
							{
								GClass145.smethod_2("[Error]" + " " + ex15.Message);
							}
						}
						IL_66E:
						if (this.bool_51 && ((!this.bool_52 || !bool_168) && (!this.bool_53 || !bool_169)))
						{
							try
							{
								this.method_406(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
							}
							catch (Exception ex16)
							{
								GClass145.smethod_2("[Error]" + " " + ex16.Message);
							}
						}
						if (this.bool_56 && ((!this.bool_57 || !bool_168) && (!this.bool_58 || !bool_169)))
						{
							try
							{
								this.method_25(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
							}
							catch (Exception ex17)
							{
								GClass145.smethod_2("[Error]" + " " + ex17.Message);
							}
						}
						if (this.bool_61 && ((!this.bool_62 || !bool_168) && (!this.bool_63 || !bool_169)))
						{
							try
							{
								this.method_233(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
							}
							catch (Exception ex18)
							{
								GClass145.smethod_2("[Error]" + " " + ex18.Message);
							}
						}
						if (this.bool_78 && ((!this.bool_79 || !bool_168) && (!this.bool_80 || !bool_169)))
						{
							try
							{
								this.method_45(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, false, null, false, null, null);
							}
							catch (Exception ex19)
							{
								GClass145.smethod_2("[Error]" + " " + ex19.Message);
							}
						}
						if (this.int_47 >= this.int_46)
						{
							string str = string.Concat(new string[]
							{
								": ",
								"Log",
								" ",
								"Was",
								" ",
								"Limited",
								" ",
								"By",
								" ",
								this.int_47.ToString(),
								" ",
								"Lines"
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str);
							}
							this.int_47++;
						}
						this.list_18.Clear();
						this.list_20.Clear();
						this.method_176(transform_0);
					}
				}
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0003DAE4 File Offset: 0x0003BCE4
		internal void method_218(bool bool_168)
		{
			this.bool_105 = bool_168;
			this.gclass40_0.bool_84 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0003DB0C File Offset: 0x0003BD0C
		internal List<GClass145.GStruct102> method_219()
		{
			List<GClass145.GStruct102> list = new List<GClass145.GStruct102>();
			list.AddRange(this.list_27);
			if (this.bool_160)
			{
				list.AddRange(this.list_28);
			}
			return list;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0003DB44 File Offset: 0x0003BD44
		private void method_220()
		{
			this.method_322();
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0003DB58 File Offset: 0x0003BD58
		internal void method_221(bool bool_168)
		{
			this.bool_75 = bool_168;
			this.gclass40_0.bool_61 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0003DB80 File Offset: 0x0003BD80
		internal void method_222(bool bool_168)
		{
			this.method_221(bool_168);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0003DB94 File Offset: 0x0003BD94
		internal void method_223()
		{
			if (this.bool_0)
			{
				if (!this.bool_7 || !this.bool_15)
				{
					this.method_363();
				}
				this.method_257();
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003DBD0 File Offset: 0x0003BDD0
		internal void method_224(bool bool_168)
		{
			this.method_242(bool_168);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0003DBE4 File Offset: 0x0003BDE4
		internal void method_225()
		{
			this.method_542();
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0003DBF8 File Offset: 0x0003BDF8
		internal bool method_226(GClass145.GStruct102 gstruct102_0)
		{
			for (int i = this.list_25.Count - 1; i >= 0; i--)
			{
				if (this.list_25[i].string_0 == gstruct102_0.string_0)
				{
					return false;
				}
			}
			this.list_25.Add(gstruct102_0);
			this.gclass107_0.list_6 = this.list_25;
			this.gclass107_0.method_36();
			return true;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003DC70 File Offset: 0x0003BE70
		private unsafe static void smethod_25<T>(string string_3, out T gparam_0, string string_4) where T : MulticastDelegate
		{
			IntPtr intPtr = IL2CPP.il2cpp_resolve_icall(string_3);
			if (intPtr == IntPtr.Zero)
			{
				GClass70.smethod_51("ICall " + string_3 + " was not found, not patching", GClass70.Enum1.const_0);
				gparam_0 = default(T);
			}
			else
			{
				MethodInfo method = typeof(GClass145).GetMethod(string_4, BindingFlags.Static | BindingFlags.NonPublic);
				IntPtr functionPointer = method.MethodHandle.GetFunctionPointer();
				MelonUtils.NativeHookAttach((IntPtr)((void*)(&intPtr)), functionPointer);
				gparam_0 = Marshal.GetDelegateForFunctionPointer<T>(intPtr);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		internal void method_227(bool bool_168)
		{
			this.method_111(bool_168);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0003DD04 File Offset: 0x0003BF04
		private void method_228(MethodBase methodBase_0, string string_3 = null, string string_4 = null)
		{
			this.method_126(methodBase_0, string_3, string_4);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0003DD1C File Offset: 0x0003BF1C
		internal void method_229(bool bool_168)
		{
			this.bool_51 = bool_168;
			this.gclass40_0.bool_38 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CA5 RID: 3237
		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtect(IntPtr intptr_2, UIntPtr uintptr_0, uint uint_0, out uint uint_1);

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0003DD44 File Offset: 0x0003BF44
		internal void method_230(bool bool_168)
		{
			this.method_359(bool_168);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0003DD58 File Offset: 0x0003BF58
		internal void method_231(bool bool_168)
		{
			this.method_365(bool_168);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0003DD6C File Offset: 0x0003BF6C
		internal void method_232(bool bool_168)
		{
			this.bool_98 = bool_168;
			this.gclass40_0.bool_77 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0003DD94 File Offset: 0x0003BF94
		internal static void smethod_26(string string_3)
		{
			GClass70.smethod_38(string_3, GClass70.Enum1.const_2);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0003DDA8 File Offset: 0x0003BFA8
		internal bool method_233(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForIdenticalComponents();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_64 && (!bool_168 || (!this.bool_65 && !this.bool_9));
				List<Object> list = new List<Object>();
				List<DynamicBone> list2 = new List<DynamicBone>();
				List<LimbIK> list3 = new List<LimbIK>();
				for (int i = 0; i < array.Length; i++)
				{
					Il2CppArrayBase<Component> components = array[i].GetComponents<Component>();
					for (int j = 0; j < components.Length; j++)
					{
						if (components[j])
						{
							DynamicBone dynamicBone = components[j].TryCast<DynamicBone>();
							if (dynamicBone)
							{
								int k = 0;
								while (k < list2.Count)
								{
									DynamicBone dynamicBone2 = list2[k];
									if (!dynamicBone2 || !(dynamicBone.m_Root == dynamicBone2.m_Root))
									{
										k++;
									}
									else
									{
										if (this.bool_66)
										{
											GClass145.smethod_22(string.Concat(new string[]
											{
												"DB",
												":",
												" ",
												GClass84.smethod_1076(dynamicBone, transform_0),
												" ",
												"Is",
												" ",
												"Identical",
												" ",
												"To",
												" ",
												GClass84.smethod_1076(dynamicBone2, transform_0)
											}));
										}
										GClass84.smethod_761(dynamicBone);
										num2++;
										IL_1D7:
										if (k == list2.Count)
										{
											list2.Add(dynamicBone);
											goto IL_52E;
										}
										goto IL_52E;
									}
								}
								goto IL_1D7;
							}
							LimbIK limbIK = components[j].TryCast<LimbIK>();
							if (limbIK)
							{
								IKSolverLimb solver = limbIK.solver;
								if (solver != null)
								{
									for (int l = 0; l < list3.Count; l++)
									{
										LimbIK limbIK2 = list3[l];
										if (limbIK2)
										{
											IKSolverLimb solver2 = limbIK2.solver;
											if (solver2 != null && (solver.bendGoal == solver2.bendGoal && solver.target == solver2.target && solver.bone1 != null == (solver2.bone1 != null) && solver.bone2 != null == (solver2.bone2 != null) && solver.bone3 != null == (solver2.bone3 != null) && (solver.bone1 == null || !(solver.bone1.transform != solver2.bone1.transform))) && (solver.bone2 == null || !(solver.bone2.transform != solver2.bone2.transform)) && (solver.bone3 == null || !(solver.bone3.transform != solver2.bone3.transform)))
											{
												if (this.bool_66)
												{
													GClass145.smethod_22(string.Concat(new string[]
													{
														"FIKLIK",
														":",
														" ",
														GClass84.smethod_1076(limbIK, transform_0),
														" ",
														"Is",
														" ",
														"Identical",
														" ",
														"To",
														" ",
														GClass84.smethod_1076(limbIK2, transform_0)
													}));
												}
												GClass84.smethod_761(limbIK);
												num3++;
												IL_3F3:
												if (l == list3.Count)
												{
													list3.Add(limbIK);
													goto IL_52E;
												}
												goto IL_52E;
											}
										}
									}
									goto IL_3F3;
								}
							}
							int m = 0;
							while (m < j)
							{
								if (!components[m] || !(components[j].ToString() == components[m].ToString()))
								{
									m++;
								}
								else
								{
									if (this.bool_66)
									{
										GClass145.smethod_22(string.Concat(new string[]
										{
											GClass84.smethod_908(array[i], transform_0),
											": ",
											components[j].ToString(),
											" ",
											"Is",
											" ",
											"Identical",
											" ",
											"To",
											" ",
											components[m].ToString()
										}));
									}
									GClass84.smethod_761(components[j]);
									num++;
									IL_4FE:
									if (m == j && !components[j].TryCast<Transform>())
									{
										list.Add(components[j]);
										goto IL_52E;
									}
									goto IL_52E;
								}
							}
							goto IL_4FE;
						}
						IL_52E:;
					}
				}
				bool flag2 = false;
				if (num > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							num.ToString(),
							" ",
							"Identical",
							" ",
							"Components",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						this.int_47++;
					}
					flag2 = true;
				}
				if (num2 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str3 = string.Concat(new string[]
						{
							": ",
							num2.ToString(),
							" ",
							"Identical",
							" ",
							"Dynamic",
							" ",
							"Bones",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str3);
						}
						this.int_47++;
					}
					flag2 = true;
				}
				if (num3 > 0)
				{
					if (flag && this.int_47 < this.int_46)
					{
						string str4 = string.Concat(new string[]
						{
							": ",
							num3.ToString(),
							" ",
							"Identical",
							" ",
							"Limb",
							" ",
							"IK",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str4);
						}
						this.int_47++;
					}
					flag2 = true;
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
		internal void method_234()
		{
			this.method_490();
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
		internal void method_235(bool bool_168)
		{
			this.bool_80 = bool_168;
			this.gclass40_0.bool_66 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0003E5FC File Offset: 0x0003C7FC
		internal void method_236(Transform transform_0, string string_3)
		{
			this.method_314(transform_0, string_3);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0003E614 File Offset: 0x0003C814
		internal void method_237(int int_54)
		{
			this.method_62(int_54);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0003E628 File Offset: 0x0003C828
		internal void method_238(bool bool_168)
		{
			this.method_122(bool_168);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0003E63C File Offset: 0x0003C83C
		internal void method_239(bool bool_168)
		{
			this.bool_128 = bool_168;
			this.gclass40_0.bool_103 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0003E664 File Offset: 0x0003C864
		private static void smethod_27(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
		{
			GClass145.smethod_24(intptr_2, intptr_3, intptr_4);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0003E67C File Offset: 0x0003C87C
		internal void method_240(bool bool_168)
		{
			this.method_379(bool_168);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003E690 File Offset: 0x0003C890
		internal bool method_241(string string_3)
		{
			for (int i = this.list_21.Count - 1; i >= 0; i--)
			{
				if (this.list_21[i].string_0 == string_3)
				{
					this.list_21.RemoveAt(i);
					this.gclass107_0.list_2 = this.list_21;
					this.gclass107_0.method_21();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003E704 File Offset: 0x0003C904
		private static bool smethod_28(ApiAvatar apiAvatar_0)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22("SimpleAvatarPedestal_Method_Public_Void_ApiAvatar" + ": " + apiAvatar_0.id);
				}
				else
				{
					GClass145.smethod_22("SimpleAvatarPedestal_Method_Public_Void_ApiAvatar()");
				}
			}
			return true;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003E748 File Offset: 0x0003C948
		internal void method_242(bool bool_168)
		{
			this.bool_122 = bool_168;
			this.gclass40_0.bool_99 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0003E770 File Offset: 0x0003C970
		private static bool smethod_29(ApiAvatar apiAvatar_0)
		{
			if (GClass145.bool_165 && apiAvatar_0 != null)
			{
				GClass145.smethod_22("AssetBundleDownloadManager_Method_Internal_Nullable_1_Int32_ApiAvatar" + ": " + apiAvatar_0.id);
			}
			return apiAvatar_0 != null && !GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, "")));
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003E80C File Offset: 0x0003CA0C
		internal void method_243(bool bool_168)
		{
			this.method_354(bool_168);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0003E820 File Offset: 0x0003CA20
		internal void method_244(bool bool_168)
		{
			this.method_295(bool_168);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003E834 File Offset: 0x0003CA34
		internal void method_245(Transform transform_0, string string_3)
		{
			this.method_334(transform_0, string_3);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003E84C File Offset: 0x0003CA4C
		internal void method_246(bool bool_168)
		{
			this.bool_73 = bool_168;
			this.gclass40_0.bool_59 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003E874 File Offset: 0x0003CA74
		private static void smethod_30(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
		{
			GClass145.smethod_27(intptr_2, intptr_3, intptr_4);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003E88C File Offset: 0x0003CA8C
		internal static void smethod_31(string string_3)
		{
			GClass145.smethod_26(string_3);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
		internal void method_247(bool bool_168)
		{
			this.method_195(bool_168);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003E8B4 File Offset: 0x0003CAB4
		private void method_248(Object object_0, List<Object> list_30)
		{
			this.method_277(object_0, list_30);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003E8CC File Offset: 0x0003CACC
		private void method_249(GClass84.GStruct146 gstruct146_0)
		{
			this.method_407(gstruct146_0);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003E8E0 File Offset: 0x0003CAE0
		internal void method_250(bool bool_168)
		{
			this.method_168(bool_168);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		internal bool method_251(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168 = false, bool bool_169 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				result = this.method_38(transform_0, string_3, consoleColor_0, ref num, ref num2, bool_168, bool_169);
			}
			return result;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003E928 File Offset: 0x0003CB28
		internal void method_252(bool bool_168)
		{
			this.method_35(bool_168);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0003E93C File Offset: 0x0003CB3C
		internal void method_253(int int_54)
		{
			this.method_76(int_54);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0003E950 File Offset: 0x0003CB50
		internal void method_254(bool bool_168)
		{
			this.method_362(bool_168);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0003E964 File Offset: 0x0003CB64
		internal void method_255(bool bool_168)
		{
			this.bool_59 = bool_168;
			this.gclass40_0.bool_46 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0003E98C File Offset: 0x0003CB8C
		internal void method_256(bool bool_168)
		{
			this.method_524(bool_168);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003B570 File Offset: 0x00039770
		private static bool smethod_32(AssetBundleDownload assetBundleDownload_0)
		{
			if (assetBundleDownload_0.field_Private_ContentType_0 == 1 && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), assetBundleDownload_0.field_Private_String_0, ""))
			{
				assetBundleDownload_0.field_Private_String_0 = "avtr_c38a1615-5bf5-42b4-84eb-a8b6c37cbd11";
				assetBundleDownload_0.field_Private_String_1 = "https://0.0.0.0/blocked.dat";
			}
			return true;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
		private void method_257()
		{
			this.method_132();
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		internal void method_258(bool bool_168)
		{
			this.method_30(bool_168);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		internal void method_259(bool bool_168)
		{
			this.method_274(bool_168);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0003E9DC File Offset: 0x0003CBDC
		internal unsafe static void smethod_33(IntPtr intptr_2, IntPtr intptr_3, byte byte_0)
		{
			byte* ptr = default(byte*);
			intptr_3 += 8953744;
			uint uint_;
			GClass145.VirtualProtect_1(intptr_3, 64U, 64U, out uint_);
			ptr = (byte*)intptr_3.ToPointer();
			*ptr = byte_0;
			uint num;
			GClass145.VirtualProtect_1(intptr_3, 64U, uint_, out num);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0003EA24 File Offset: 0x0003CC24
		internal void method_260(bool bool_168)
		{
			this.bool_118 = bool_168;
			this.gclass40_0.bool_95 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		internal void method_261(bool bool_168)
		{
			this.bool_90 = bool_168;
			this.gclass40_0.bool_71 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0003EA74 File Offset: 0x0003CC74
		internal void method_262(bool bool_168)
		{
			this.bool_108 = bool_168;
			this.gclass40_0.bool_87 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0003EA9C File Offset: 0x0003CC9C
		internal void method_263(bool bool_168)
		{
			this.method_405(bool_168);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
		internal bool method_264(string string_3)
		{
			for (int i = this.list_23.Count - 1; i >= 0; i--)
			{
				if (this.list_23[i].string_0 == string_3)
				{
					this.list_23.RemoveAt(i);
					this.gclass107_0.list_2 = this.list_23;
					this.gclass107_0.method_37();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003EB24 File Offset: 0x0003CD24
		internal void method_265(bool bool_168)
		{
			this.bool_141 = bool_168;
			this.gclass40_0.bool_19 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0003EB4C File Offset: 0x0003CD4C
		internal void method_266(bool bool_168)
		{
			this.method_555(bool_168);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003EB60 File Offset: 0x0003CD60
		internal void method_267(bool bool_168)
		{
			this.bool_81 = bool_168;
			this.gclass40_0.bool_67 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0003EB88 File Offset: 0x0003CD88
		internal void method_268()
		{
			if (this.bool_0)
			{
				if (this.bool_47)
				{
					if (this.list_2.Count > 0)
					{
						bool flag = true;
						for (int i = 0; i < this.list_2.Count; i++)
						{
							if (!this.list_2[i].bool_3)
							{
								this.list_2[i] = this.method_535(this.list_2[i]);
								if (!this.list_2[i].bool_3)
								{
									flag = false;
								}
							}
						}
						if (flag)
						{
							this.list_2.Clear();
						}
					}
					if (this.list_3.Count > 0)
					{
						bool flag2 = true;
						for (int j = 0; j < this.list_3.Count; j++)
						{
							if (!this.list_3[j].bool_2)
							{
								this.list_3[j] = this.method_390(this.list_3[j]);
								if (!this.list_3[j].bool_2)
								{
									flag2 = false;
								}
							}
						}
						if (flag2)
						{
							this.list_3.Clear();
						}
					}
				}
				if (GClass84.float_0 > 0f)
				{
					if (this.bool_153)
					{
						this.method_522(GClass84.float_0);
					}
					if (this.bool_155)
					{
						this.method_503(GClass84.float_0);
					}
				}
				this.method_444();
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003ED04 File Offset: 0x0003CF04
		private void method_269(Transform transform_0, Transform transform_1, ParticleSystem particleSystem_0, string string_3, ConsoleColor consoleColor_0, ref List<GClass145.GStruct99> list_30, ref int int_54, ref int int_55, ref int int_56, ref List<Object> list_31, bool bool_168, bool bool_169)
		{
			if (particleSystem_0)
			{
				if (int_54 <= this.int_20)
				{
					list_31.Add(particleSystem_0);
					int num = this.int_10;
					Transform parent = transform_1.parent;
					ParticleSystemRenderer component = transform_1.GetComponent<ParticleSystemRenderer>();
					if (component)
					{
						list_31.Add(component);
						if (component.minParticleSize >= this.float_8)
						{
							component.minParticleSize = this.float_8;
							num = this.int_11;
						}
						if (component.maxParticleSize >= this.float_8)
						{
							component.maxParticleSize = this.float_8;
							num = this.int_11;
						}
					}
					bool flag = false;
					bool flag2 = false;
					int num2 = 0;
					int num3 = 0;
					ParticleSystem.MainModule main = particleSystem_0.main;
					if (main != null && main.ringBufferMode > 0)
					{
						if (bool_169 && this.int_47 < this.int_46)
						{
							string str = string.Concat(new string[]
							{
								": ",
								transform_1.name,
								" ",
								"Used",
								" ",
								"Ring",
								" ",
								"Buffer",
								" ",
								"Mode",
								" ",
								main.ringBufferMode.ToString(),
								". ",
								"Changed",
								" ",
								"To",
								" ",
								0.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str);
							}
							this.int_47++;
						}
						main.ringBufferMode = 0;
					}
					if (particleSystem_0.maxParticles >= this.int_16 || (main != null && main.maxParticles >= this.int_16))
					{
						if (main != null)
						{
							num2 = GClass84.smethod_1690(particleSystem_0.maxParticles, main.maxParticles);
						}
						else
						{
							num2 = particleSystem_0.maxParticles;
						}
						bool flag3 = false;
						ParticleSystem.EmissionModule emission = particleSystem_0.emission;
						int burstCount = emission.burstCount;
						int num4 = 0;
						for (int i = 0; i < burstCount; i++)
						{
							ParticleSystem.Burst burst = particleSystem_0.emission.GetBurst(i);
							if (burst != null)
							{
								if (burst.count.constantMin < (float)this.int_16 && burst.count.constantMax < (float)this.int_16)
								{
									float num5 = GClass84.smethod_359(main.startLifetime.constantMin, main.startLifetime.constantMax) / burst.repeatInterval;
									if (burst.cycleCount > 0)
									{
										num5 = GClass84.smethod_910(num5, (float)burst.cycleCount);
									}
									int num6 = (int)GClass84.smethod_359(burst.count.constantMin, burst.count.constantMax);
									if (num6 <= 0)
									{
										goto IL_484;
									}
									if ((float)(2147483647 / num6) >= num5)
									{
										int num7 = (int)((float)num6 * num5);
										if (this.int_16 - num4 >= num7)
										{
											num4 += num7;
											if (num4 < this.int_16)
											{
												goto IL_484;
											}
											num3 = num4;
											flag3 = true;
										}
										else
										{
											if (2147483647 - num4 < num7)
											{
												num3 = int.MaxValue;
											}
											else
											{
												num3 = num4 + num7;
											}
											flag3 = true;
										}
									}
									else
									{
										num3 = int.MaxValue;
										flag3 = true;
									}
								}
								else
								{
									num3 = (int)GClass84.smethod_359(burst.count.constantMin, burst.count.constantMax);
									flag3 = true;
								}
								IL_4F2:
								if (!flag3)
								{
									int num8 = (int)particleSystem_0.emissionRate;
									if (particleSystem_0.startLifetime <= 0f)
									{
										num8 = 0;
									}
									else if (particleSystem_0.startLifetime > 0f && 2.14748365E+09f / particleSystem_0.startLifetime > (float)num8)
									{
										num8 = (int)((float)num8 * particleSystem_0.startLifetime);
									}
									else
									{
										num8 = int.MaxValue;
									}
									if (particleSystem_0.emission != null)
									{
										int num9 = (int)GClass84.smethod_359(particleSystem_0.emission.rateOverTime.constantMin, particleSystem_0.emission.rateOverTime.constantMax);
										num9 = (int)((float)num9 * particleSystem_0.startLifetime);
										if (num8 < num9)
										{
											num8 = num9;
										}
									}
									num4 += num8;
									if (num4 >= this.int_16)
									{
										num3 = num4;
										flag3 = true;
									}
								}
								if (flag3)
								{
									flag = true;
									particleSystem_0.maxParticles = 10;
									if (main != null)
									{
										main.maxParticles = 10;
										goto IL_64A;
									}
									goto IL_64A;
								}
								else
								{
									flag2 = true;
									particleSystem_0.maxParticles = num;
									if (main != null)
									{
										main.maxParticles = num;
										goto IL_64A;
									}
									goto IL_64A;
								}
							}
							IL_484:;
						}
						goto IL_4F2;
					}
					if (particleSystem_0.maxParticles > num)
					{
						num2 = particleSystem_0.maxParticles;
						particleSystem_0.maxParticles = num;
						flag2 = true;
					}
					if (main != null && main.maxParticles > num)
					{
						if (num2 < main.maxParticles)
						{
							num2 = main.maxParticles;
						}
						main.maxParticles = num;
						flag2 = true;
					}
					IL_64A:
					if (flag)
					{
						if (bool_169 && this.int_47 < this.int_46)
						{
							string str2 = string.Concat(new string[]
							{
								": ",
								transform_1.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Particles",
								" (",
								num2.ToString(),
								") ",
								"With",
								" ",
								"Emission",
								" ",
								num3.ToString(),
								". ",
								"Changed",
								" ",
								"Maximum",
								" ",
								"Particles",
								" ",
								"To",
								" ",
								"10"
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str2);
							}
							this.int_47++;
						}
					}
					else if (flag2)
					{
						if (bool_169 && this.int_47 < this.int_46)
						{
							string str3 = string.Concat(new string[]
							{
								": ",
								transform_1.name,
								" ",
								"Used",
								" ",
								num2.ToString(),
								" ",
								"Particles",
								". ",
								"Changed",
								" ",
								"Maximum",
								" ",
								"Particles",
								" ",
								"To",
								" ",
								num.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str3);
							}
							this.int_47++;
						}
						if (this.bool_72)
						{
							int num10 = (int)particleSystem_0.emissionRate;
							if (particleSystem_0.startLifetime <= 0f)
							{
								num10 = 0;
							}
							else if (2.14748365E+09f / particleSystem_0.startLifetime > (float)num10)
							{
								num10 = (int)((float)num10 * particleSystem_0.startLifetime);
							}
							else
							{
								num10 = int.MaxValue;
							}
							if (particleSystem_0.emission != null)
							{
								int num11 = (int)GClass84.smethod_359(particleSystem_0.emission.rateOverTime.constantMin, particleSystem_0.emission.rateOverTime.constantMax);
								num11 = (int)((float)num11 * particleSystem_0.startLifetime);
								if (num10 < num11)
								{
									num10 = num11;
								}
							}
							if (num10 >= num)
							{
								int num12 = 0;
								if (particleSystem_0.startLifetime > 0f)
								{
									num12 = (int)GClass84.smethod_359((float)num / particleSystem_0.startLifetime, 1f);
								}
								particleSystem_0.emissionRate = (float)num12;
								if (particleSystem_0.emission != null)
								{
									particleSystem_0.emission.rateOverTime.constantMin = (float)num12;
									particleSystem_0.emission.rateOverTime.constantMax = (float)num12;
								}
							}
						}
					}
					if (this.int_17 > 0)
					{
						ParticleSystem.CollisionModule collision = particleSystem_0.collision;
						if (collision != null && collision.enabled)
						{
							if (collision.maxCollisionShapes > this.int_17)
							{
								if (bool_169 && this.int_47 < this.int_46)
								{
									string str4 = string.Concat(new string[]
									{
										": ",
										transform_1.name,
										" ",
										"Used",
										" ",
										"Too",
										" ",
										"Many",
										" ",
										"Collision",
										" ",
										"Shapes",
										" (",
										collision.maxCollisionShapes.ToString(),
										")",
										". ",
										"Changed",
										" ",
										"To",
										" ",
										this.int_17.ToString()
									});
									if (this.bool_11)
									{
										GClass145.smethod_14(new List<GClass84.GStruct172>
										{
											new GClass84.GStruct172(consoleColor_0, string_3),
											new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
										});
									}
									else
									{
										GClass145.smethod_22(string_3 + str4);
									}
									this.int_47++;
								}
								collision.maxCollisionShapes = this.int_17;
							}
							if (collision.radiusScale > this.float_9)
							{
								if (bool_169 && this.int_47 < this.int_46)
								{
									string str5 = string.Concat(new string[]
									{
										": ",
										transform_1.name,
										" ",
										"Used",
										" ",
										"Too",
										" ",
										"Huge",
										" ",
										"Radius",
										" ",
										"Scale",
										" (",
										collision.radiusScale.ToString(),
										")",
										". ",
										"Changed",
										" ",
										"To",
										" ",
										this.float_9.ToString()
									});
									if (this.bool_11)
									{
										GClass145.smethod_14(new List<GClass84.GStruct172>
										{
											new GClass84.GStruct172(consoleColor_0, string_3),
											new GClass84.GStruct172(ConsoleColor.DarkGray, str5)
										});
									}
									else
									{
										GClass145.smethod_22(string_3 + str5);
									}
									this.int_47++;
								}
								collision.radiusScale = this.float_9;
							}
							if (collision.colliderForce > this.float_10)
							{
								if (bool_169 && this.int_47 < this.int_46)
								{
									string str6 = string.Concat(new string[]
									{
										": ",
										transform_1.name,
										" ",
										"Used",
										" ",
										"Too",
										" ",
										"Huge",
										" ",
										"Collider",
										" ",
										"Force",
										" (",
										collision.colliderForce.ToString(),
										")",
										". ",
										"Changed",
										" ",
										"To",
										this.float_10.ToString()
									});
									if (this.bool_11)
									{
										GClass145.smethod_14(new List<GClass84.GStruct172>
										{
											new GClass84.GStruct172(consoleColor_0, string_3),
											new GClass84.GStruct172(ConsoleColor.DarkGray, str6)
										});
									}
									else
									{
										GClass145.smethod_22(string_3 + str6);
									}
									this.int_47++;
								}
								collision.colliderForce = this.float_10;
							}
						}
					}
					if ((this.int_18 > 0 || this.int_19 > 0) && (component && component.enabled && component.renderMode == 4))
					{
						Mesh mesh = component.mesh;
						if (mesh)
						{
							if (bool_168)
							{
								list_31.Add(mesh);
							}
							flag2 = false;
							if (main != null)
							{
								num2 = GClass84.smethod_1690(particleSystem_0.maxParticles, main.maxParticles);
								num3 = GClass84.smethod_1690(particleSystem_0.maxParticles, main.maxParticles);
							}
							else
							{
								num2 = particleSystem_0.maxParticles;
								num3 = particleSystem_0.maxParticles;
							}
							string empty = string.Empty;
							bool flag4 = false;
							if (this.int_18 > 0)
							{
								int count = mesh.vertices.Count;
								if (count > 0)
								{
									int num13 = (int)((float)this.int_18 / (float)count);
									if (num13 == 0)
									{
										int num14 = this.int_18;
										Il2CppStructArray<Vector3> il2CppStructArray = new Il2CppStructArray<Vector3>((long)num14);
										Il2CppStructArray<Vector3> vertices = mesh.vertices;
										for (int j = 0; j < num14; j++)
										{
											il2CppStructArray[j] = vertices[j];
										}
										mesh.vertices = il2CppStructArray;
										flag4 = true;
										num13 = 1;
										if (mesh.normals.Count > this.int_18)
										{
											Il2CppStructArray<Vector3> il2CppStructArray2 = new Il2CppStructArray<Vector3>((long)num14);
											Il2CppStructArray<Vector3> normals = mesh.normals;
											for (int k = 0; k < num14; k++)
											{
												il2CppStructArray2[k] = normals[k];
											}
											mesh.normals = il2CppStructArray2;
										}
										if (bool_169 && this.int_47 < this.int_46)
										{
											string[] array = new string[25];
											array[0] = ": ";
											array[1] = transform_1.name;
											array[2] = " ";
											array[3] = "Used";
											array[4] = " ";
											array[5] = "Too";
											array[6] = " ";
											array[7] = "Many";
											array[8] = " ";
											array[9] = "Vertices";
											array[10] = " (";
											array[11] = count.ToString();
											array[12] = ")";
											array[13] = ". ";
											array[14] = "Changed";
											array[15] = " ";
											array[16] = "Count";
											array[17] = " ";
											array[18] = "Of";
											array[19] = " ";
											array[20] = "Vertices";
											array[21] = " ";
											array[22] = "To";
											array[23] = " ";
											int num15 = 24;
											int num16 = num14;
											array[num15] = num16.ToString();
											string str7 = string.Concat(array);
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str7)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str7);
											}
											this.int_47++;
										}
									}
									bool flag5 = false;
									if (particleSystem_0.maxParticles > num13)
									{
										particleSystem_0.maxParticles = num13;
										flag2 = true;
										GClass84.smethod_655(ref empty, count.ToString() + " " + "Vertices", ", ");
										flag5 = true;
										if (num3 > num13)
										{
											num3 = num13;
										}
									}
									if (main != null && main.maxParticles > num13)
									{
										main.maxParticles = num13;
										flag2 = true;
										if (!flag5)
										{
											GClass84.smethod_655(ref empty, count.ToString() + " " + "Vertices", ", ");
										}
										if (num3 > num13)
										{
											num3 = num13;
										}
									}
								}
							}
							if (this.int_19 > 0)
							{
								int num17 = mesh.triangles.Count / 3;
								if (num17 > 0)
								{
									int num18 = (int)((float)this.int_19 / (float)num17);
									if (num18 == 0)
									{
										int num19 = this.int_19 * 3;
										Il2CppStructArray<int> il2CppStructArray3 = new Il2CppStructArray<int>((long)num19);
										Il2CppStructArray<int> triangles = mesh.triangles;
										for (int l = 0; l < num19; l++)
										{
											il2CppStructArray3[l] = triangles[l];
										}
										mesh.triangles = il2CppStructArray3;
										flag4 = true;
										num18 = 1;
										if (bool_169 && this.int_47 < this.int_46)
										{
											string str8 = string.Concat(new string[]
											{
												": ",
												transform_1.name,
												" ",
												"Used",
												" ",
												"Too",
												" ",
												"Many",
												" ",
												"Triangles",
												" (",
												num17.ToString(),
												")",
												". ",
												"Changed",
												" ",
												"Count",
												" ",
												"Of",
												" ",
												"Triangles",
												" ",
												"To",
												" ",
												num19.ToString()
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str8)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str8);
											}
											this.int_47++;
										}
									}
									bool flag6 = false;
									if (particleSystem_0.maxParticles > num18)
									{
										particleSystem_0.maxParticles = num18;
										flag2 = true;
										GClass84.smethod_655(ref empty, num17.ToString() + " " + "Triangles", ", ");
										flag6 = true;
										if (num3 > num18)
										{
											num3 = num18;
										}
									}
									if (main != null && main.maxParticles > num18)
									{
										main.maxParticles = num18;
										flag2 = true;
										if (!flag6)
										{
											GClass84.smethod_655(ref empty, num17.ToString() + " " + "Triangles", ", ");
										}
										if (num3 > num18)
										{
											num3 = num18;
										}
									}
									if (flag2 && !flag6)
									{
										GClass84.smethod_655(ref empty, num17.ToString() + " " + "Triangles", ", ");
									}
								}
							}
							if (flag4)
							{
								GClass84.smethod_906(mesh);
							}
							if (flag2 && bool_169 && this.int_47 < this.int_46)
							{
								string str9 = string.Concat(new string[]
								{
									": ",
									transform_1.name,
									" ",
									"Used",
									" ",
									num2.ToString(),
									" ",
									"Particles",
									" ",
									"With",
									" ",
									"Heavy",
									" ",
									"Mesh",
									" (",
									empty,
									")",
									". ",
									"Changed",
									" ",
									"Maximum",
									" ",
									"Particles",
									" ",
									"To",
									" ",
									num3.ToString()
								});
								if (this.bool_11)
								{
									GClass145.smethod_14(new List<GClass84.GStruct172>
									{
										new GClass84.GStruct172(consoleColor_0, string_3),
										new GClass84.GStruct172(ConsoleColor.DarkGray, str9)
									});
								}
								else
								{
									GClass145.smethod_22(string_3 + str9);
								}
								this.int_47++;
							}
						}
					}
					ParticleSystem.TrailModule trails = particleSystem_0.trails;
					if (trails != null && trails.enabled && trails.mode == 1 && trails.ribbonCount > this.int_21)
					{
						if (bool_169 && this.int_47 < this.int_46)
						{
							string str10 = string.Concat(new string[]
							{
								": ",
								transform_1.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Ribbons",
								" (",
								trails.ribbonCount.ToString(),
								")",
								". ",
								"Changed",
								" ",
								"To",
								" ",
								this.int_21.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str10)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str10);
							}
							this.int_47++;
						}
						trails.ribbonCount = this.int_21;
					}
					ParticleSystem.SubEmittersModule subEmitters = particleSystem_0.subEmitters;
					if (subEmitters != null && subEmitters.enabled)
					{
						for (int m = 0; m < subEmitters.subEmittersCount; m++)
						{
							ParticleSystem subEmitterSystem = particleSystem_0.subEmitters.GetSubEmitterSystem(m);
							if (subEmitterSystem)
							{
								Transform transform = subEmitterSystem.transform;
								if (transform && !GClass84.smethod_1493(transform.parent, transform_0))
								{
									if (bool_169 && this.int_47 < this.int_46)
									{
										string str11 = string.Concat(new string[]
										{
											": ",
											transform_1.name,
											" ",
											"Tried",
											" ",
											"To",
											" ",
											"Bypass",
											" ",
											"AntiCrash",
											" ",
											"With",
											" ",
											"Hidden",
											" ",
											"ParticleSystem",
											"! ",
											"Checking",
											"..."
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str11)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str11);
										}
										this.int_47++;
									}
									this.method_158(transform_0, subEmitterSystem.transform, subEmitterSystem, string_3, consoleColor_0, ref list_30, ref int_54, ref int_55, ref int_56, ref list_31, bool_168, bool_169);
								}
							}
						}
					}
					GClass145.GStruct99 gstruct = new GClass145.GStruct99(transform_1, parent, particleSystem_0, component, 0);
					int n = 0;
					while (n < list_30.Count)
					{
						GClass145.GStruct99 gstruct2 = list_30[n];
						if (!GClass145.GStruct99.smethod_0(gstruct, gstruct2, false))
						{
							if (gstruct.transform_1 && gstruct2.transform_1)
							{
								Transform parent2 = gstruct.transform_1.parent;
								Transform parent3 = gstruct2.transform_1.parent;
								if (parent2 && parent2 == parent3 && GClass145.GStruct99.smethod_0(gstruct, gstruct2, true))
								{
									int_56++;
									if ((this.int_15 < 0 || int_56 <= this.int_15) && gstruct2.int_0 < this.int_14)
									{
										gstruct2.int_0++;
										list_30[n] = gstruct2;
										break;
									}
									if (bool_169 && this.int_47 < this.int_46)
									{
										string str12 = string.Concat(new string[]
										{
											": ",
											GClass84.smethod_908(transform_1, parent2),
											" ",
											"Had",
											" ",
											"Similar",
											" ",
											"Particle",
											" ",
											"System",
											" ",
											"To",
											" ",
											GClass84.smethod_908(gstruct2.transform_0, parent2),
											" ",
											"And",
											" ",
											"Was",
											" ",
											"Destroyed"
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str12)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str12);
										}
										this.int_47++;
									}
									if (transform_1.childCount > 0)
									{
										if (subEmitters == null)
										{
											GClass84.smethod_761(particleSystem_0);
											break;
										}
										if (!subEmitters.enabled)
										{
											GClass84.smethod_761(particleSystem_0);
											break;
										}
										List<Transform> list = new List<Transform>();
										for (int num20 = 0; num20 < subEmitters.subEmittersCount; num20++)
										{
											ParticleSystem subEmitterSystem2 = particleSystem_0.subEmitters.GetSubEmitterSystem(num20);
											if (subEmitterSystem2)
											{
												Transform transform2 = subEmitterSystem2.transform;
												if (transform2 && transform2.parent == transform_1)
												{
													int num21 = 0;
													while (num21 < list.Count && !(list[num21] == transform2))
													{
														num21++;
													}
													if (num21 == list.Count)
													{
														list.Add(transform2);
													}
												}
											}
										}
										if (list.Count != transform_1.childCount)
										{
											GClass84.smethod_761(particleSystem_0);
											break;
										}
									}
									GClass84.smethod_761(particleSystem_0);
									List<ParticleSystem> list2 = transform_1.GetComponentsInChildren<ParticleSystem>().ToList<ParticleSystem>();
									for (int num22 = list2.Count - 1; num22 >= 0; num22--)
									{
										GClass84.smethod_761(list2[num22]);
									}
									break;
								}
							}
							n++;
							continue;
						}
						int_55++;
						if ((this.int_13 < 0 || int_55 <= this.int_13) && gstruct2.int_0 < this.int_12)
						{
							gstruct2.int_0++;
							list_30[n] = gstruct2;
						}
						else
						{
							if (bool_169 && this.int_47 < this.int_46)
							{
								string str13 = string.Concat(new string[]
								{
									": ",
									transform_1.name,
									" ",
									"Had",
									" ",
									"Similar",
									" ",
									"Particle",
									" ",
									"System",
									" ",
									"To",
									" ",
									gstruct2.transform_0.name,
									" ",
									"And",
									" ",
									"Was",
									" ",
									"Destroyed"
								});
								if (this.bool_11)
								{
									GClass145.smethod_14(new List<GClass84.GStruct172>
									{
										new GClass84.GStruct172(consoleColor_0, string_3),
										new GClass84.GStruct172(ConsoleColor.DarkGray, str13)
									});
								}
								else
								{
									GClass145.smethod_22(string_3 + str13);
								}
								this.int_47++;
							}
							if (transform_1.childCount > 0)
							{
								if (subEmitters == null || !subEmitters.enabled)
								{
									GClass84.smethod_761(particleSystem_0);
									break;
								}
								List<Transform> list3 = new List<Transform>();
								for (int num23 = 0; num23 < subEmitters.subEmittersCount; num23++)
								{
									ParticleSystem subEmitterSystem3 = particleSystem_0.subEmitters.GetSubEmitterSystem(num23);
									if (subEmitterSystem3)
									{
										Transform transform3 = subEmitterSystem3.transform;
										if (transform3 && transform3.parent == transform_1)
										{
											int num24 = 0;
											while (num24 < list3.Count && !(list3[num24] == transform3))
											{
												num24++;
											}
											if (num24 == list3.Count)
											{
												list3.Add(transform3);
											}
										}
									}
								}
								if (list3.Count != transform_1.childCount)
								{
									GClass84.smethod_761(particleSystem_0);
									break;
								}
							}
							GClass84.smethod_761(particleSystem_0);
							List<ParticleSystem> list4 = transform_1.GetComponentsInChildren<ParticleSystem>().ToList<ParticleSystem>();
							for (int num25 = list4.Count - 1; num25 >= 0; num25--)
							{
								GClass84.smethod_761(list4[num25]);
							}
						}
						IL_1EE6:
						if (n == list_30.Count)
						{
							int_54++;
							list_30.Add(gstruct);
							return;
						}
						return;
					}
					goto IL_1EE6;
				}
				if (bool_169 && this.int_47 < this.int_46)
				{
					string str14 = string.Concat(new string[]
					{
						": ",
						"Particle",
						" ",
						"Systems",
						" ",
						"Were",
						" ",
						"Limited",
						" ",
						"By",
						" ",
						this.int_20.ToString(),
						". ",
						transform_1.name,
						" ",
						"Was",
						" ",
						"Destroyed"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str14)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str14);
					}
					this.int_47++;
				}
				GClass84.smethod_761(particleSystem_0);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00040C18 File Offset: 0x0003EE18
		internal void method_270(bool bool_168)
		{
			this.bool_112 = bool_168;
			this.gclass40_0.bool_91 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00040C40 File Offset: 0x0003EE40
		internal void method_271(Transform transform_0, string string_3)
		{
			this.method_461(transform_0, string_3);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00040C58 File Offset: 0x0003EE58
		internal void method_272(bool bool_168)
		{
			this.method_447(bool_168);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00040C6C File Offset: 0x0003EE6C
		internal void method_273(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			this.method_163(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00040C90 File Offset: 0x0003EE90
		private static string smethod_34(IntPtr intptr_2)
		{
			return GClass145.smethod_12(intptr_2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00040CA4 File Offset: 0x0003EEA4
		internal void method_274(bool bool_168)
		{
			this.method_64(bool_168);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00040CB8 File Offset: 0x0003EEB8
		internal void method_275(bool bool_168)
		{
			this.bool_49 = bool_168;
			this.gclass40_0.bool_36 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00040CE0 File Offset: 0x0003EEE0
		internal void method_276(bool bool_168)
		{
			this.method_96(bool_168);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00040CF4 File Offset: 0x0003EEF4
		private void method_277(Object object_0, List<Object> list_30)
		{
			this.method_298(object_0, list_30);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00040D0C File Offset: 0x0003EF0C
		internal void method_278(bool bool_168)
		{
			this.method_427(bool_168);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00040D20 File Offset: 0x0003EF20
		internal void method_279(bool bool_168)
		{
			this.method_324(bool_168);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00040D34 File Offset: 0x0003EF34
		internal void method_280(bool bool_168)
		{
			this.method_252(bool_168);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00040D48 File Offset: 0x0003EF48
		private void method_281(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, VRCPlayerApi vrcplayerApi_0, Transform transform_1)
		{
			this.method_217(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, vrcplayerApi_0, transform_1);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00040D74 File Offset: 0x0003EF74
		private void method_282(Object object_0, Object object_1)
		{
			this.method_364(object_0, object_1);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00040D8C File Offset: 0x0003EF8C
		private void method_283(List<GameObject> list_30, bool bool_168 = true)
		{
			this.method_339(list_30, bool_168);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		private static IntPtr smethod_35(IntPtr intptr_2, uint uint_0)
		{
			return GClass145.delegate18_0(intptr_2, uint_0);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00040DC0 File Offset: 0x0003EFC0
		private void method_284(List<Object> list_30)
		{
			this.method_21(list_30);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00040DD4 File Offset: 0x0003EFD4
		internal void method_285()
		{
			Class172.bool_0 = false;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00040DEC File Offset: 0x0003EFEC
		internal void method_286(bool bool_168)
		{
			this.method_422(bool_168);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00040E00 File Offset: 0x0003F000
		private unsafe static void smethod_36(GClass145.Struct14* pStruct14_1, long long_0)
		{
			GClass145.smethod_48(pStruct14_1, long_0);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00040E14 File Offset: 0x0003F014
		internal void method_287(bool bool_168)
		{
			this.method_438(bool_168);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00040E28 File Offset: 0x0003F028
		internal bool method_288(GClass145.GStruct102 gstruct102_0)
		{
			for (int i = this.list_21.Count - 1; i >= 0; i--)
			{
				if (this.list_21[i].string_0 == gstruct102_0.string_0)
				{
					return false;
				}
			}
			this.list_21.Add(gstruct102_0);
			this.gclass107_0.list_2 = this.list_21;
			this.gclass107_0.method_21();
			return true;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00040EA0 File Offset: 0x0003F0A0
		internal void method_289(bool bool_168)
		{
			this.method_69(bool_168);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		internal void method_290(bool bool_168)
		{
			this.bool_110 = bool_168;
			this.gclass40_0.bool_89 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00040EDC File Offset: 0x0003F0DC
		internal void method_291(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitDynamicBones();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool bool_171 = this.bool_8 && bool_170 && this.bool_104 && (!bool_168 || (!this.bool_105 && !this.bool_9));
				List<Object> list = new List<Object>();
				List<DynamicBone> list2 = GClass84.smethod_1556(transform_0);
				list.AddRange(list2);
				for (int i = 0; i < list2.Count; i++)
				{
					this.method_521(list2[i], string_3, consoleColor_0, bool_171);
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		internal void method_292(bool bool_168)
		{
			this.method_56(bool_168);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00040FDC File Offset: 0x0003F1DC
		internal void method_293(bool bool_168)
		{
			this.method_471(bool_168);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00040FF0 File Offset: 0x0003F1F0
		internal void method_294(bool bool_168)
		{
			this.method_370(bool_168);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00041004 File Offset: 0x0003F204
		internal void method_295(bool bool_168)
		{
			this.bool_71 = bool_168;
			this.gclass40_0.bool_58 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0004102C File Offset: 0x0003F22C
		internal void method_296(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, bool bool_171, Transform transform_1)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitParticles();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool bool_172 = this.bool_8 && bool_170 && this.bool_70 && (!bool_168 || (!this.bool_71 && !this.bool_9));
				List<Object> list = new List<Object>();
				List<GClass145.GStruct99> list2 = new List<GClass145.GStruct99>();
				int num = 1;
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i])
					{
						this.method_158(transform_0, array[i], array[i].GetComponent<ParticleSystem>(), string_3, consoleColor_0, ref list2, ref num, ref num2, ref num3, ref list, bool_171, bool_172);
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				if (list2 != null)
				{
					list2.Clear();
				}
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00041148 File Offset: 0x0003F348
		internal void method_297(bool bool_168)
		{
			this.method_265(bool_168);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0004115C File Offset: 0x0003F35C
		private void method_298(Object object_0, List<Object> list_30)
		{
			if (object_0 && list_30.Count != 0)
			{
				for (int i = this.list_14.Count - 1; i >= 0; i--)
				{
					if (this.list_14[i].object_0 == object_0)
					{
						GClass145.Struct7 @struct = this.list_14[i];
						@struct.list_0.AddRange(list_30);
						GClass84.smethod_661<Object>(ref @struct.list_0);
						GClass84.smethod_1233<Object>(@struct.list_0);
						list_30.Clear();
						return;
					}
				}
				this.list_14.Add(new GClass145.Struct7(object_0, list_30));
				list_30.Clear();
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00041208 File Offset: 0x0003F408
		internal void method_299(bool bool_168)
		{
			this.method_536(bool_168);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0004121C File Offset: 0x0003F41C
		internal void method_300(bool bool_168)
		{
			this.bool_164 = bool_168;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00041230 File Offset: 0x0003F430
		internal void method_301(bool bool_168)
		{
			this.bool_132 = bool_168;
			this.gclass40_0.bool_105 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00041258 File Offset: 0x0003F458
		internal void method_302(bool bool_168)
		{
			this.method_289(bool_168);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00041C1C File Offset: 0x0003FE1C
		internal void method_303(bool bool_168)
		{
			this.method_261(bool_168);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00041C30 File Offset: 0x0003FE30
		internal void method_304(bool bool_168)
		{
			this.method_199(bool_168);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00041C44 File Offset: 0x0003FE44
		private void method_305(GClass84.GStruct146 gstruct146_0)
		{
			this.method_249(gstruct146_0);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00041C58 File Offset: 0x0003FE58
		internal void method_306(bool bool_168)
		{
			this.bool_103 = bool_168;
			this.gclass40_0.bool_82 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00041C80 File Offset: 0x0003FE80
		internal void method_307(Transform transform_0, string string_3)
		{
			this.method_215(transform_0, string_3);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00041C98 File Offset: 0x0003FE98
		internal static void smethod_37(IntPtr intptr_2, IntPtr intptr_3, bool bool_168)
		{
			GClass145.smethod_39(intptr_2, intptr_3, bool_168);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00041CB0 File Offset: 0x0003FEB0
		internal void method_308(Transform transform_0, string string_3)
		{
			this.method_467(transform_0, string_3);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00041CC8 File Offset: 0x0003FEC8
		internal void method_309(bool bool_168)
		{
			this.method_41(bool_168);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00041CDC File Offset: 0x0003FEDC
		internal static void smethod_38(List<GClass84.GStruct172> list_30)
		{
			GClass70.smethod_115(list_30, GClass70.Enum1.const_2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00041CF0 File Offset: 0x0003FEF0
		internal static void smethod_39(IntPtr intptr_2, IntPtr intptr_3, bool bool_168)
		{
			GClass145.smethod_52(intptr_2, intptr_3, bool_168);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00041D08 File Offset: 0x0003FF08
		internal void method_310(bool bool_168)
		{
			this.method_386(bool_168);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00041D1C File Offset: 0x0003FF1C
		internal void method_311(bool bool_168)
		{
			this.method_141(bool_168);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00041D30 File Offset: 0x0003FF30
		internal void method_312()
		{
			List<GameObject> list = this.method_40();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				GClass84.smethod_890(list[i], false);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00041D6C File Offset: 0x0003FF6C
		internal bool method_313(string string_3)
		{
			for (int i = this.list_27.Count - 1; i >= 0; i--)
			{
				if (this.list_27[i].string_0 == string_3)
				{
					this.list_27.RemoveAt(i);
					this.gclass107_0.list_7 = this.list_27;
					this.gclass107_0.method_26();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00041DE0 File Offset: 0x0003FFE0
		internal void method_314(Transform transform_0, string string_3)
		{
			this.method_550(transform_0, string_3);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00041DF8 File Offset: 0x0003FFF8
		internal void method_315(bool bool_168)
		{
			this.method_329(bool_168);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00041E0C File Offset: 0x0004000C
		internal void method_316(bool bool_168)
		{
			this.method_338(bool_168);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00041E20 File Offset: 0x00040020
		internal void method_317(bool bool_168)
		{
			this.method_36(bool_168);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00041E34 File Offset: 0x00040034
		public override void vmethod_10()
		{
			this.method_466();
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00041E48 File Offset: 0x00040048
		private void method_318(Transform transform_0, List<Transform> list_30, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, VRCPlayerApi vrcplayerApi_0, Transform transform_1)
		{
			this.method_529(transform_0, list_30, string_3, consoleColor_0, bool_168, bool_169, vrcplayerApi_0, transform_1);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00041E74 File Offset: 0x00040074
		internal void method_319(bool bool_168)
		{
			this.bool_6 = bool_168;
			this.gclass40_0.bool_3 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00041E9C File Offset: 0x0004009C
		internal void method_320(bool bool_168)
		{
			this.method_311(bool_168);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00041EB0 File Offset: 0x000400B0
		internal void method_321(bool bool_168)
		{
			this.bool_79 = bool_168;
			this.gclass40_0.bool_65 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00041ED8 File Offset: 0x000400D8
		private void method_322()
		{
			List<GameObject> list = GClass84.smethod_549(false, false, false);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (list[i].GetComponent<PipelineManager>() && list[i].GetComponent<VRC_AvatarDescriptor>())
				{
					int num = this.list_12.Count - 1;
					while (num >= 0 && !(this.list_12[num].gameObject_0 == list[i]))
					{
						num--;
					}
					if (num >= 0)
					{
						this.list_12.Add(new GClass145.Struct6(list[i]));
					}
				}
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00041F94 File Offset: 0x00040194
		private unsafe static long smethod_40(GClass145.Struct13* pStruct13_0)
		{
			long result;
			try
			{
				result = GClass145.smethod_50(pStruct13_0, new HashSet<IntPtr>());
			}
			catch (Exception ex)
			{
				string[] array = new string[10];
				array[0] = "Exception";
				array[1] = " ";
				array[2] = "in";
				array[3] = " ";
				array[4] = "Count";
				array[5] = "Nodes";
				array[6] = " ";
				array[7] = "patch";
				array[8] = ": ";
				int num = 9;
				Exception ex2 = ex;
				array[num] = ((ex2 != null) ? ex2.ToString() : null);
				GClass145.smethod_2(string.Concat(array));
				result = 1L;
			}
			return result;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00042038 File Offset: 0x00040238
		internal void method_323(bool bool_168)
		{
			this.method_546(bool_168);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0004204C File Offset: 0x0004024C
		internal void method_324(bool bool_168)
		{
			this.method_204(bool_168);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00042060 File Offset: 0x00040260
		internal void method_325(bool bool_168)
		{
			this.bool_74 = bool_168;
			this.gclass40_0.bool_60 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00042088 File Offset: 0x00040288
		internal void method_326(bool bool_168)
		{
			this.method_183(bool_168);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0004209C File Offset: 0x0004029C
		internal void method_327()
		{
			this.method_551();
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000420B0 File Offset: 0x000402B0
		internal bool method_328(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = true, Transform transform_1 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.int_26 > 0 || this.int_27 > 0)
				{
					if (this.bool_10 && bool_170)
					{
						string str = ": LimitMeshes();";
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str);
						}
					}
					Transform[] array = GClass84.smethod_1519(transform_0);
					List<GClass145.GStruct100> list = new List<GClass145.GStruct100>();
					bool flag = this.bool_8 && bool_170 && this.bool_92 && (!bool_168 || (!this.bool_93 && !this.bool_9));
					bool result2 = false;
					List<Object> list2 = new List<Object>();
					for (int i = 0; i < array.Length; i++)
					{
						if (this.int_50 >= this.int_49)
						{
							this.bool_156 = false;
							IL_A25:
							if (list2.Count > 0)
							{
								this.method_248(transform_0, list2);
							}
							return result2;
						}
						MeshFilter component = array[i].GetComponent<MeshFilter>();
						SkinnedMeshRenderer skinnedMeshRenderer = null;
						Mesh mesh = null;
						GClass145.GStruct100 gstruct = default(GClass145.GStruct100);
						bool flag2 = false;
						string empty = string.Empty;
						if (component)
						{
							list2.Add(component);
							bool flag3;
							mesh = this.method_49(array[i], transform_1, GClass84.smethod_908(array[i], transform_0), GClass145.Enum2.const_0, out flag2, out flag3, out empty, false);
						}
						else if (!this.bool_88)
						{
							skinnedMeshRenderer = array[i].GetComponent<SkinnedMeshRenderer>();
							if (skinnedMeshRenderer)
							{
								list2.Add(skinnedMeshRenderer);
								if (!this.bool_89 || skinnedMeshRenderer.bones.Length < 1)
								{
									bool flag3;
									mesh = this.method_49(array[i], transform_1, GClass84.smethod_908(array[i], transform_0), GClass145.Enum2.const_1, out flag2, out flag3, out empty, false);
								}
							}
						}
						if (mesh)
						{
							bool flag4 = false;
							bool flag5 = false;
							int count = mesh.vertices.Count;
							int num = mesh.triangles.Count / 3;
							int j = list.Count - 1;
							while (j >= 0)
							{
								GClass145.GStruct100 gstruct2 = list[j];
								if (!(gstruct2.string_0 == empty) || gstruct2.int_0 != count || gstruct2.int_1 != num)
								{
									j--;
								}
								else
								{
									if (this.int_26 > 0 && count > this.int_26 - gstruct2.int_2)
									{
										flag5 = true;
										gstruct = gstruct2;
									}
									else if (this.int_27 > 0 && num > this.int_27 - gstruct2.int_1)
									{
										flag5 = true;
										gstruct = gstruct2;
									}
									else
									{
										gstruct2.int_2 += count;
										gstruct2.int_3 += num;
										list[j] = gstruct2;
										flag4 = true;
									}
									IL_2A2:
									if (flag5)
									{
										if (flag && this.int_47 < this.int_46)
										{
											string str2 = string.Concat(new string[]
											{
												": ",
												array[i].name,
												" ",
												"Used",
												" ",
												"Mesh",
												" ",
												empty,
												" (",
												count.ToString(),
												" ",
												"Vertices",
												", ",
												num.ToString(),
												" ",
												"Triangles",
												") ",
												"And",
												" ",
												"Was",
												" ",
												"Removed",
												". ",
												"This",
												" ",
												"Mesh",
												" ",
												"Limited",
												" ",
												"By",
												" ",
												gstruct.int_2.ToString(),
												" ",
												"Vertices",
												" ",
												"And",
												" ",
												gstruct.int_3.ToString(),
												" ",
												"Triangles"
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str2);
											}
											this.int_47++;
										}
										this.int_50++;
										if (flag2)
										{
											GClass84.smethod_1522(mesh);
											GClass84.smethod_505(component, false);
											Il2CppArrayBase<MeshRenderer> components = array[i].GetComponents<MeshRenderer>();
											if (components.Count > 0 && !array[i].GetComponent<MeshFilter>())
											{
												for (int k = components.Count - 1; k >= 0; k--)
												{
													GClass84.smethod_424(components[k]);
												}
												goto IL_A0A;
											}
											goto IL_A0A;
										}
										else if (component)
										{
											component.sharedMesh = null;
											GClass84.smethod_505(component, false);
											Il2CppArrayBase<MeshRenderer> components2 = array[i].GetComponents<MeshRenderer>();
											if (components2.Count > 0 && !array[i].GetComponent<MeshFilter>())
											{
												for (int l = components2.Count - 1; l >= 0; l--)
												{
													GClass84.smethod_424(components2[l]);
												}
												goto IL_A0A;
											}
											goto IL_A0A;
										}
										else
										{
											if (skinnedMeshRenderer)
											{
												skinnedMeshRenderer.sharedMesh = null;
												GClass84.smethod_735(skinnedMeshRenderer);
												goto IL_A0A;
											}
											goto IL_A0A;
										}
									}
									else
									{
										if (!flag4)
										{
											int num2 = count;
											int num3 = num;
											bool flag6 = false;
											if (this.int_26 > 0 && count > this.int_26)
											{
												num2 = this.int_26;
												Il2CppStructArray<Vector3> il2CppStructArray = new Il2CppStructArray<Vector3>((long)num2);
												Il2CppStructArray<Vector3> vertices = mesh.vertices;
												for (int m = 0; m < num2; m++)
												{
													il2CppStructArray[m] = vertices[m];
												}
												mesh.vertices = il2CppStructArray;
												flag6 = true;
												if (mesh.normals.Count > this.int_26)
												{
													Il2CppStructArray<Vector3> il2CppStructArray2 = new Il2CppStructArray<Vector3>((long)num2);
													Il2CppStructArray<Vector3> normals = mesh.normals;
													for (int n = 0; n < num2; n++)
													{
														il2CppStructArray2[n] = normals[n];
													}
													mesh.normals = il2CppStructArray2;
												}
												if (flag && this.int_47 < this.int_46)
												{
													string str3 = string.Concat(new string[]
													{
														": ",
														array[i].name,
														" ",
														"Used",
														" ",
														"Mesh",
														" ",
														empty,
														" ",
														"With",
														" ",
														"Too",
														" ",
														"Many",
														" ",
														"Vertices",
														" (",
														count.ToString(),
														") ",
														"And",
														" ",
														"Was",
														" ",
														"Limited",
														" ",
														"To",
														" ",
														this.int_26.ToString(),
														" ",
														"Vertices"
													});
													if (this.bool_11)
													{
														GClass145.smethod_14(new List<GClass84.GStruct172>
														{
															new GClass84.GStruct172(consoleColor_0, string_3),
															new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
														});
													}
													else
													{
														GClass145.smethod_22(string_3 + str3);
													}
													this.int_47++;
												}
											}
											if (this.int_27 > 0 && num > this.int_27)
											{
												num3 = this.int_27 * 3;
												Il2CppStructArray<int> il2CppStructArray3 = new Il2CppStructArray<int>((long)num3);
												Il2CppStructArray<int> triangles = mesh.triangles;
												for (int num4 = 0; num4 < num3; num4++)
												{
													il2CppStructArray3[num4] = triangles[num4];
												}
												num3 /= 3;
												mesh.triangles = il2CppStructArray3;
												flag6 = true;
												if (flag && this.int_47 < this.int_46)
												{
													string str4 = string.Concat(new string[]
													{
														": ",
														array[i].name,
														" ",
														"Used",
														" ",
														"Mesh",
														" ",
														empty,
														" ",
														"With",
														" ",
														"Too",
														" ",
														"Many",
														" ",
														"Triangles",
														" (",
														num.ToString(),
														") ",
														"And",
														" ",
														"Was",
														" ",
														"Limited",
														" ",
														"To",
														" ",
														this.int_27.ToString(),
														" ",
														"Triangles"
													});
													if (this.bool_11)
													{
														GClass145.smethod_14(new List<GClass84.GStruct172>
														{
															new GClass84.GStruct172(consoleColor_0, string_3),
															new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
														});
													}
													else
													{
														GClass145.smethod_22(string_3 + str4);
													}
													this.int_47++;
												}
											}
											if (flag6)
											{
												GClass84.smethod_906(mesh);
											}
											list.Add(new GClass145.GStruct100(empty, count, num, num2, num3));
											goto IL_A0A;
										}
										goto IL_A0A;
									}
								}
							}
							goto IL_2A2;
						}
						IL_A0A:;
					}
					goto IL_A25;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00042AFC File Offset: 0x00040CFC
		internal void method_329(bool bool_168)
		{
			this.bool_56 = bool_168;
			this.gclass40_0.bool_43 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00042B24 File Offset: 0x00040D24
		internal bool method_330(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				result = this.method_37(transform_0, string_3, consoleColor_0, ref num, ref num2, bool_168, bool_169, bool_170, bool_171);
			}
			return result;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00042B5C File Offset: 0x00040D5C
		internal List<string> method_331(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = false, Transform transform_1 = null, bool bool_172 = false, Transform transform_2 = null, Transform transform_3 = null)
		{
			List<string> list = new List<string>();
			if (transform_0)
			{
				if (this.bool_10 && bool_170 && !bool_172)
				{
					string str = ": CheckForSimilarObjects_Smart();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				if (!transform_2)
				{
					transform_2 = transform_0;
				}
				if (bool_171 && !transform_1)
				{
					transform_1 = transform_0;
				}
				if (!bool_172)
				{
					if (this.list_17 == null)
					{
						this.list_17 = new List<GClass84.GStruct136>();
					}
					else
					{
						this.list_17.Clear();
					}
					this.list_17.AddRange(this.list_18);
					if (this.list_19 == null)
					{
						this.list_19 = new List<GClass84.GStruct146>();
					}
					else
					{
						this.list_19.Clear();
					}
					this.list_19.AddRange(this.list_20);
				}
				Transform[] array = GClass84.smethod_1141(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_49 && (!bool_168 || (!this.bool_50 && !this.bool_9));
				List<GameObject> list2 = new List<GameObject>();
				List<Object> list3 = new List<Object>();
				List<GClass84.GStruct134> list4 = new List<GClass84.GStruct134>();
				for (int i = 0; i < array.Length; i++)
				{
					if (this.int_50 >= this.int_49)
					{
						this.bool_156 = false;
						IL_980:
						if (list2.Count > 0)
						{
							this.method_283(list2, false);
						}
						list2.Clear();
						if (list3.Count > 0)
						{
							this.method_17(list3);
						}
						list3.Clear();
						return list;
					}
					if (array[i].childCount > 0)
					{
						if (bool_171)
						{
							list.AddRange(this.method_331(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, true, transform_1, true, transform_2, transform_3));
						}
						else
						{
							this.method_331(array[i], string_3, consoleColor_0, bool_168, bool_169, bool_170, false, transform_1, true, transform_2, transform_3);
						}
					}
					else if (!array[i].GetComponent<ParticleSystem>() && array[i].parent && array[i].parent.parent && array[i].parent.parent.childCount >= 2)
					{
						bool flag2 = false;
						Transform transform = null;
						MeshFilter component = array[i].GetComponent<MeshFilter>();
						SkinnedMeshRenderer skinnedMeshRenderer = null;
						bool flag3 = false;
						string empty = string.Empty;
						Mesh mesh = null;
						bool flag4 = false;
						if (component)
						{
							mesh = this.method_49(array[i], transform_3, GClass84.smethod_908(array[i], transform_2), GClass145.Enum2.const_0, out flag4, out flag3, out empty, false);
						}
						else if (!this.bool_44)
						{
							skinnedMeshRenderer = array[i].GetComponent<SkinnedMeshRenderer>();
							if (skinnedMeshRenderer)
							{
								mesh = this.method_49(array[i], transform_3, GClass84.smethod_908(array[i], transform_2), GClass145.Enum2.const_1, out flag4, out flag3, out empty, false);
							}
						}
						if (mesh)
						{
							Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
							for (int j = 0; j < components.Count; j++)
							{
								if (!components[j].TryCast<ParticleSystemRenderer>() && !components[j].TryCast<LineRenderer>() && !components[j].TryCast<TrailRenderer>())
								{
									Il2CppReferenceArray<Material> sharedMaterialArray = components[j].GetSharedMaterialArray();
									int length = sharedMaterialArray.Length;
									if (length == 0)
									{
										if (array[i].parent.parent.childCount == 0)
										{
											array[i].gameObject.SetActive(false);
										}
										components[j].enabled = false;
									}
									else if (flag2)
									{
										components[j].enabled = false;
										if (length > 0)
										{
											components[j].SetMaterialArray(new Il2CppReferenceArray<Material>(0L));
										}
									}
									else
									{
										bool flag5 = false;
										if (length == 1)
										{
											flag5 = true;
										}
										else
										{
											int num = 1;
											while (num < length && !(sharedMaterialArray[0].name != sharedMaterialArray[num].name))
											{
												num++;
											}
											if (num == length)
											{
												flag5 = true;
											}
										}
										if (flag5)
										{
											int num2 = 0;
											while (num2 < array[i].parent.parent.childCount && !(array[i].parent.parent.GetChild(num2) == array[i].parent))
											{
												num2++;
											}
											if (num2 == 0)
											{
												break;
											}
											for (int k = 0; k < num2; k++)
											{
												Transform child = array[i].parent.parent.GetChild(k);
												for (int l = 0; l < child.childCount; l++)
												{
													Transform child2 = child.GetChild(l);
													MeshFilter component2 = child2.GetComponent<MeshFilter>();
													bool flag6 = false;
													string empty2 = string.Empty;
													if (component2)
													{
														bool flag7;
														this.method_49(child2, transform_3, GClass84.smethod_908(child2, transform_2), GClass145.Enum2.const_0, out flag7, out flag6, out empty2, false);
													}
													else
													{
														SkinnedMeshRenderer component3 = child2.GetComponent<SkinnedMeshRenderer>();
														if (component3)
														{
															bool flag7;
															this.method_49(child2, transform_3, GClass84.smethod_908(child2, transform_2), GClass145.Enum2.const_1, out flag7, out flag6, out empty2, false);
														}
													}
													bool flag8 = false;
													if (empty == empty2 && (child2.position == array[i].position || (this.int_5 > 0 && this.method_209(child2.position, array[i].position, this.int_5, this.int_6, this.float_2, this.float_3, this.float_4))) && ((flag3 && flag6) || child2.rotation == array[i].rotation) && (child2.lossyScale == array[i].lossyScale || (this.int_7 > 0 && this.method_209(child2.lossyScale, array[i].lossyScale, this.int_7, this.int_8, this.float_5, this.float_6, this.float_7))))
													{
														flag8 = true;
													}
													if (flag8)
													{
														Il2CppArrayBase<Renderer> components2 = child2.GetComponents<Renderer>();
														for (int m = 0; m < components2.Count; m++)
														{
															if (!components2[m].TryCast<ParticleSystemRenderer>() && !components2[m].TryCast<LineRenderer>() && !components2[m].TryCast<TrailRenderer>())
															{
																Il2CppReferenceArray<Material> sharedMaterialArray2 = components2[m].GetSharedMaterialArray();
																if (sharedMaterialArray2.Length == length)
																{
																	int num3 = 0;
																	while (num3 < length && !(sharedMaterialArray[0].name != sharedMaterialArray2[num3].name))
																	{
																		num3++;
																	}
																	if (num3 == length)
																	{
																		int n = 0;
																		while (n < list4.Count)
																		{
																			GClass84.GStruct134 gstruct = list4[n];
																			if (!(gstruct.string_0 == empty))
																			{
																				n++;
																			}
																			else
																			{
																				if (gstruct.int_0 >= this.int_9)
																				{
																					array[i].gameObject.SetActive(false);
																					components[j].enabled = false;
																					flag2 = true;
																					transform = child2;
																				}
																				else
																				{
																					gstruct.int_0++;
																					list4[n] = gstruct;
																				}
																				IL_728:
																				if (n == list4.Count)
																				{
																					list4.Add(new GClass84.GStruct134(empty, 1));
																					goto IL_744;
																				}
																				goto IL_744;
																			}
																		}
																		goto IL_728;
																	}
																}
																IL_744:
																if (flag2)
																{
																	break;
																}
															}
														}
														if (flag2)
														{
															break;
														}
													}
												}
												if (flag2)
												{
													break;
												}
											}
										}
									}
								}
							}
							if (flag2)
							{
								if (bool_171)
								{
									list.Add(GClass84.smethod_908(array[i], transform_1));
								}
								if (flag && this.int_47 < this.int_46)
								{
									string str2 = string.Concat(new string[]
									{
										": ",
										array[i].parent.parent.name,
										"/",
										array[i].parent.name,
										"/",
										array[i].name,
										" ",
										"Is",
										" ",
										"Similar",
										" ",
										"To",
										" ",
										array[i].parent.parent.name,
										"/",
										transform.parent.name,
										"/",
										transform.name,
										". ",
										"Was",
										" ",
										"Destroyed"
									});
									if (this.bool_11)
									{
										GClass145.smethod_14(new List<GClass84.GStruct172>
										{
											new GClass84.GStruct172(consoleColor_0, string_3),
											new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
										});
									}
									else
									{
										GClass145.smethod_22(string_3 + str2);
									}
									this.int_47++;
								}
								if (flag4)
								{
									list3.Add(mesh);
								}
								else if (skinnedMeshRenderer)
								{
									skinnedMeshRenderer.sharedMesh = null;
								}
								GClass84.smethod_194(array[i]);
								list2.Add(array[i].gameObject);
								this.int_50++;
							}
						}
					}
				}
				goto IL_980;
			}
			return list;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00043524 File Offset: 0x00041724
		private static bool smethod_41(IEnumerator ienumerator_0)
		{
			if (GClass145.bool_165)
			{
				if (ienumerator_0 != null)
				{
					GClass145.smethod_22("SimpleAvatarPedestal_IEnumerator" + ": " + ienumerator_0.ToString());
				}
				else
				{
					GClass145.smethod_22("SimpleAvatarPedestal_IEnumerator()");
				}
			}
			return !GClass84.gclass145_0.bool_163;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00043578 File Offset: 0x00041778
		internal void method_332(bool bool_168)
		{
			this.method_519(bool_168);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0004358C File Offset: 0x0004178C
		internal void method_333()
		{
			GClass92.smethod_3();
			if (this.bool_155)
			{
				this.method_526();
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000435AC File Offset: 0x000417AC
		internal void method_334(Transform transform_0, string string_3)
		{
			this.method_360(transform_0, string_3);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000435C4 File Offset: 0x000417C4
		internal void method_335(bool bool_168)
		{
			this.method_505(bool_168);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000435D8 File Offset: 0x000417D8
		internal void method_336(int int_54)
		{
			this.int_20 = int_54;
			this.gclass40_0.int_0 = int_54;
			GClass40.smethod_1();
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00043600 File Offset: 0x00041800
		internal void method_337(bool bool_168)
		{
			this.method_506(bool_168);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00043614 File Offset: 0x00041814
		internal void method_338(bool bool_168)
		{
			this.bool_106 = bool_168;
			this.gclass40_0.bool_85 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0004363C File Offset: 0x0004183C
		private void method_339(List<GameObject> list_30, bool bool_168)
		{
			this.method_344(list_30, bool_168);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00043654 File Offset: 0x00041854
		internal void method_340(List<GClass84.GStruct136> list_30)
		{
			this.method_468(list_30);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00043668 File Offset: 0x00041868
		internal void method_341(bool bool_168)
		{
			this.bool_96 = bool_168;
			this.gclass40_0.bool_75 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00043690 File Offset: 0x00041890
		internal static void smethod_42(string string_3)
		{
			GClass145.smethod_57(string_3);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000436A4 File Offset: 0x000418A4
		internal void method_342(bool bool_168)
		{
			this.bool_47 = bool_168;
			this.gclass40_0.bool_33 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000436CC File Offset: 0x000418CC
		private void method_343(MethodBase methodBase_0, string string_3, string string_4)
		{
			GClass84.smethod_208(methodBase_0, (string_3 == null) ? null : new HarmonyMethod(typeof(GClass145).GetMethod(string_3, BindingFlags.Static | BindingFlags.NonPublic)), (string_4 == null) ? null : new HarmonyMethod(typeof(GClass145).GetMethod(string_4, BindingFlags.Static | BindingFlags.NonPublic)), null);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0004371C File Offset: 0x0004191C
		private void method_344(List<GameObject> list_30, bool bool_168)
		{
			if (list_30.Count != 0)
			{
				for (int i = list_30.Count - 1; i >= 0; i--)
				{
					if (list_30[i])
					{
						if (bool_168)
						{
							GClass84.smethod_74(list_30[i]);
						}
						this.list_16.AddRange(GClass84.smethod_94(list_30[i]));
						this.list_16.Add(list_30[i]);
					}
				}
				GClass84.smethod_661<Object>(ref this.list_16);
				GClass84.smethod_1233<Object>(this.list_16);
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000437AC File Offset: 0x000419AC
		internal bool method_345(string string_3, string string_4)
		{
			return !(string_3 == string.Empty) && this.method_288(new GClass145.GStruct102(string_3, string_4));
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000437DC File Offset: 0x000419DC
		internal void method_346(bool bool_168)
		{
			this.method_179(bool_168);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000437F0 File Offset: 0x000419F0
		internal void method_347(bool bool_168)
		{
			this.method_552(bool_168);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00043804 File Offset: 0x00041A04
		private static void smethod_43(IntPtr intptr_2, long long_0, long long_1)
		{
			GClass145.smethod_63(intptr_2, long_0, long_1);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0004381C File Offset: 0x00041A1C
		internal void method_348(bool bool_168)
		{
			this.method_476(bool_168);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00043830 File Offset: 0x00041A30
		internal void method_349(bool bool_168)
		{
			this.method_188(bool_168);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00043844 File Offset: 0x00041A44
		internal void method_350()
		{
			this.method_18();
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00043858 File Offset: 0x00041A58
		internal void method_351(bool bool_168)
		{
			this.bool_69 = bool_168;
			this.gclass40_0.bool_56 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00043880 File Offset: 0x00041A80
		internal void method_352(bool bool_168)
		{
			this.method_346(bool_168);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00043894 File Offset: 0x00041A94
		internal void method_353(bool bool_168)
		{
			this.method_499(bool_168);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000438A8 File Offset: 0x00041AA8
		internal void method_354(bool bool_168)
		{
			this.bool_34 = bool_168;
			this.gclass40_0.bool_14 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000438D0 File Offset: 0x00041AD0
		internal void method_355(bool bool_168)
		{
			this.method_518(bool_168);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000438E4 File Offset: 0x00041AE4
		private void method_356(GClass84.GStruct136 gstruct136_0)
		{
			this.method_436(gstruct136_0);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000438F8 File Offset: 0x00041AF8
		internal void method_357(bool bool_168)
		{
			this.method_294(bool_168);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0004390C File Offset: 0x00041B0C
		internal void method_358(bool bool_168)
		{
			this.method_105(bool_168);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00043920 File Offset: 0x00041B20
		internal void method_359(bool bool_168)
		{
			this.method_270(bool_168);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00043934 File Offset: 0x00041B34
		internal void method_360(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForSoundCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				List<AudioSource> list = transform_0.GetComponents<AudioSource>().ToList<AudioSource>();
				list.AddRange(transform_0.GetComponentsInChildren<AudioSource>(true));
				if (list.Count > this.int_0)
				{
					int num = list.Count - this.int_0;
					for (int i = list.Count - 1; i >= this.int_0; i--)
					{
						Object.DestroyImmediate(list[i]);
						list.RemoveAt(i);
					}
					string str2 = string.Concat(new string[]
					{
						": ",
						"Removed",
						" ",
						num.ToString(),
						" ",
						"Audio",
						"Sources"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				int num2 = 0;
				for (int j = list.Count - 1; j >= this.int_0; j--)
				{
					if (GClass84.smethod_1428(list[j].name, GClass84.smethod_593("malformed ")) == "malformed ")
					{
						Object.DestroyImmediate(list[j]);
						list.RemoveAt(j);
						num2++;
					}
				}
				if (num2 > 0)
				{
					string str3 = string.Concat(new string[]
					{
						": ",
						"Removed",
						" ",
						num2.ToString(),
						" ",
						"Malicious",
						" ",
						"Audio",
						"Sources"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str3);
					}
				}
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00043B94 File Offset: 0x00041D94
		internal GClass84.GStruct132 method_361(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168 = false, bool bool_169 = false)
		{
			GClass84.GStruct132 result;
			if (!transform_0)
			{
				result = new GClass84.GStruct132(0, 0);
			}
			else
			{
				if (this.bool_10 && bool_168 && !bool_169)
				{
					string str = ": LimitObjectsName_Preliminary();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				GClass84.GStruct132 gstruct = new GClass84.GStruct132(0, 0);
				bool flag = this.bool_8 && bool_168 && this.bool_131;
				List<GameObject> list = new List<GameObject>();
				if (transform_0.childCount > this.int_40)
				{
					Transform[] array = GClass84.smethod_1141(transform_0);
					List<GClass84.GStruct134> list2 = new List<GClass84.GStruct134>();
					int i = 0;
					while (i < array.Length)
					{
						if (GClass84.smethod_360(array[i].name, 1) == ")")
						{
							int num = GClass84.smethod_1635(array[i].name, "(");
							int num2;
							if (num > 0 && GClass84.smethod_593(array[i].name) - num > 2 && GClass84.smethod_1238(GClass84.smethod_1204(array[i].name, num + 1, GClass84.smethod_593(array[i].name) - num - 2), out num2))
							{
								string text = GClass84.smethod_1428(array[i].name, num);
								if (GClass84.smethod_360(text, 1) == " ")
								{
									text = GClass84.smethod_1428(text, GClass84.smethod_593(text) - 1);
								}
								int count = list2.Count;
								int j = 0;
								while (j < count)
								{
									GClass84.GStruct134 gstruct2 = list2[j];
									if (!(gstruct2.string_0 == text))
									{
										j++;
									}
									else
									{
										if (gstruct2.int_0 >= this.int_40)
										{
											gstruct.int_0++;
											gstruct.int_1 += GClass84.smethod_916(array[i]);
											list.Add(array[i].gameObject);
										}
										else
										{
											gstruct2.int_0++;
											list2[j] = gstruct2;
										}
										IL_217:
										if (j == count)
										{
											list2.Add(new GClass84.GStruct134(text, 1));
											goto IL_39E;
										}
										goto IL_39E;
									}
								}
								goto IL_217;
							}
							goto IL_351;
						}
						else
						{
							int num3 = GClass84.smethod_1635(array[i].name, "_");
							int num2;
							if (num3 > 0 && GClass84.smethod_593(array[i].name) - num3 > 1 && GClass84.smethod_1238(GClass84.smethod_1204(array[i].name, num3 + 1, -1), out num2))
							{
								string b = GClass84.smethod_1428(array[i].name, num3);
								int count2 = list2.Count;
								int k = 0;
								while (k < count2)
								{
									GClass84.GStruct134 gstruct3 = list2[k];
									if (!(gstruct3.string_0 == b))
									{
										k++;
									}
									else
									{
										if (gstruct3.int_0 >= this.int_40)
										{
											gstruct.int_0++;
											gstruct.int_1 += GClass84.smethod_916(array[i]);
											list.Add(array[i].gameObject);
										}
										else
										{
											gstruct3.int_0++;
											list2[k] = gstruct3;
										}
										IL_338:
										if (k == count2)
										{
											list2.Add(new GClass84.GStruct134(b, 1));
											goto IL_39E;
										}
										goto IL_39E;
									}
								}
								goto IL_338;
							}
							goto IL_351;
						}
						IL_39E:
						i++;
						continue;
						IL_351:
						list2.Add(new GClass84.GStruct134(array[i].name, 1));
						GClass84.GStruct132 gstruct4 = this.method_361(array[i], string_3, consoleColor_0, bool_168, true);
						gstruct.int_0 += gstruct4.int_0;
						gstruct.int_1 += gstruct4.int_1;
						goto IL_39E;
					}
				}
				else
				{
					for (int l = 0; l < transform_0.childCount; l++)
					{
						GClass84.GStruct132 gstruct5 = this.method_361(transform_0.GetChild(l), string_3, consoleColor_0, bool_168, true);
						gstruct.int_0 += gstruct5.int_0;
						gstruct.int_1 += gstruct5.int_1;
					}
				}
				if (list.Count > 0)
				{
					this.method_283(list, true);
				}
				list.Clear();
				if ((gstruct.int_0 > 0 || gstruct.int_1 > 0) && flag && !bool_169)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						gstruct.int_0.ToString(),
						" ",
						"Objects",
						" ",
						"With",
						" ",
						gstruct.int_1.ToString(),
						" ",
						"Children",
						" ",
						"Were",
						" ",
						"Removed",
						" ",
						"By",
						" ",
						"Preliminary",
						" ",
						"Object",
						"Name",
						"Limiter"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00044104 File Offset: 0x00042304
		internal void method_362(bool bool_168)
		{
			this.bool_154 = bool_168;
			this.gclass40_0.bool_110 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0004412C File Offset: 0x0004232C
		private void method_363()
		{
			this.method_173();
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00044140 File Offset: 0x00042340
		private static void smethod_44(ref bool bool_168)
		{
			GClass145.smethod_61(ref bool_168);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00044154 File Offset: 0x00042354
		private void method_364(Object object_0, Object object_1)
		{
			this.method_216(object_0, object_1);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0004416C File Offset: 0x0004236C
		internal void method_365(bool bool_168)
		{
			this.method_196(bool_168);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00044180 File Offset: 0x00042380
		internal void method_366(bool bool_168)
		{
			this.method_192(bool_168);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00044194 File Offset: 0x00042394
		internal void method_367(bool bool_168)
		{
			this.method_11(bool_168);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000441A8 File Offset: 0x000423A8
		internal void method_368(bool bool_168)
		{
			this.method_383(bool_168);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000441BC File Offset: 0x000423BC
		internal void method_369()
		{
			this.method_508();
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x000441D0 File Offset: 0x000423D0
		internal void method_370(bool bool_168)
		{
			this.bool_54 = bool_168;
			this.gclass40_0.bool_41 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000441F8 File Offset: 0x000423F8
		internal void method_371(bool bool_168)
		{
			this.method_368(bool_168);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004420C File Offset: 0x0004240C
		private static IntPtr smethod_45(IntPtr intptr_2, uint uint_0)
		{
			return GClass145.delegate17_0(intptr_2, uint_0);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00044228 File Offset: 0x00042428
		private void method_372()
		{
			this.method_220();
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0004423C File Offset: 0x0004243C
		private static bool smethod_46(ApiAvatar apiAvatar_0, float float_17)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22(string.Concat(new string[]
					{
						"VRCAvatarManager_ApiAvatar_InterfacePublicAbstractGaGaUnique",
						": ",
						apiAvatar_0.id,
						", ",
						float_17.ToString()
					}));
				}
				else
				{
					GClass145.smethod_22("VRCAvatarManager_ApiAvatar_InterfacePublicAbstractGaGaUnique()");
				}
			}
			return !GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, "")));
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000442F8 File Offset: 0x000424F8
		internal void method_373()
		{
			this.method_268();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0004430C File Offset: 0x0004250C
		internal void method_374(bool bool_168)
		{
			this.method_247(bool_168);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00044320 File Offset: 0x00042520
		internal void method_375(bool bool_168)
		{
			this.method_137(bool_168);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00044334 File Offset: 0x00042534
		internal void method_376(bool bool_168)
		{
			this.method_416(bool_168);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00044348 File Offset: 0x00042548
		internal void method_377()
		{
			this.gclass107_0.method_13();
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00044360 File Offset: 0x00042560
		internal void method_378()
		{
			this.method_285();
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00044374 File Offset: 0x00042574
		internal unsafe static void smethod_47<T>(ProcessModule processModule_0, int int_54, T gparam_0, out T gparam_1) where T : MulticastDelegate
		{
			gparam_1 = default(T);
			if (int_54 != 0)
			{
				IntPtr ptr = processModule_0.BaseAddress + int_54;
				GClass145.list_0.Add(gparam_0);
				MelonUtils.NativeHookAttach((IntPtr)((void*)(&ptr)), Marshal.GetFunctionPointerForDelegate<T>(gparam_0));
				gparam_1 = Marshal.GetDelegateForFunctionPointer<T>(ptr);
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000443CC File Offset: 0x000425CC
		internal void method_379(bool bool_168)
		{
			this.bool_52 = bool_168;
			this.gclass40_0.bool_39 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000443F4 File Offset: 0x000425F4
		internal void method_380(bool bool_168)
		{
			this.method_246(bool_168);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00044408 File Offset: 0x00042608
		internal void method_381(bool bool_168)
		{
			this.method_272(bool_168);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0004441C File Offset: 0x0004261C
		internal void method_382(bool bool_168)
		{
			this.bool_35 = bool_168;
			this.gclass40_0.bool_15 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00044444 File Offset: 0x00042644
		internal void method_383(bool bool_168)
		{
			this.bool_9 = bool_168;
			this.gclass40_0.bool_8 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0004446C File Offset: 0x0004266C
		internal void method_384(bool bool_168)
		{
			this.method_52(bool_168);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00044480 File Offset: 0x00042680
		internal void method_385(bool bool_168)
		{
			this.method_254(bool_168);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00044494 File Offset: 0x00042694
		internal void method_386(bool bool_168)
		{
			this.method_301(bool_168);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000444A8 File Offset: 0x000426A8
		internal bool method_387(string string_3)
		{
			for (int i = this.list_25.Count - 1; i >= 0; i--)
			{
				if (this.list_25[i].string_0 == string_3)
				{
					this.list_25.RemoveAt(i);
					this.gclass107_0.list_6 = this.list_25;
					this.gclass107_0.method_36();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0004451C File Offset: 0x0004271C
		internal void method_388(bool bool_168)
		{
			this.method_118(bool_168);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00044530 File Offset: 0x00042730
		internal bool method_389(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, Transform transform_1 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10)
				{
					string str = ": CheckForAnimatorCrash();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				PipelineManager component = transform_0.GetComponent<PipelineManager>();
				bool flag = false;
				if (component)
				{
					int i = this.list_1.Count - 1;
					while (i >= 0 && !(this.list_1[i] == component.blueprintId))
					{
						i--;
					}
					if (i >= 0)
					{
						List<Animator> list = transform_0.GetComponents<Animator>().ToList<Animator>();
						list.AddRange(transform_0.GetComponentsInChildren<Animator>());
						GClass84.smethod_661<Animator>(ref list);
						for (i = list.Count - 1; i >= 0; i--)
						{
							list[i].enabled = false;
							flag = true;
						}
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00044648 File Offset: 0x00042848
		private GClass145.Struct4 method_390(GClass145.Struct4 struct4_0)
		{
			GClass145.Struct4 result;
			if (struct4_0.bool_2)
			{
				result = struct4_0;
			}
			else
			{
				this.int_47 = struct4_0.int_1;
				if (struct4_0.int_0 == 0)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if ((!this.bool_42 || !struct4_0.bool_0) && (!this.bool_43 || !struct4_0.bool_1))
					{
						List<string> list;
						try
						{
							list = this.method_201(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, true, null, false, null, true, struct4_0.transform_1);
						}
						catch (Exception ex)
						{
							list = new List<string>();
							GClass145.smethod_2("[Error]" + " " + ex.Message);
						}
						if (list.Count > 0)
						{
							List<GameObject> list2 = new List<GameObject>();
							for (int i = struct4_0.list_0.Count - 1; i >= 0; i--)
							{
								for (int j = list.Count - 1; j >= 0; j--)
								{
									GameObject gameObject = GClass84.smethod_351(struct4_0.list_0[i], list[j]);
									if (gameObject)
									{
										list2.Add(gameObject);
									}
								}
							}
							if (list2.Count > 0)
							{
								this.method_283(list2, true);
								list2.Clear();
							}
							list.Clear();
						}
					}
					struct4_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct4_0.int_0++;
					}
				}
				if (struct4_0.int_0 == 1)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if ((!this.bool_42 || !struct4_0.bool_0) && (!this.bool_43 || !struct4_0.bool_1))
					{
						this.list_18.AddRange(struct4_0.list_1);
						this.list_20.AddRange(struct4_0.list_2);
						List<string> list3;
						try
						{
							list3 = this.method_331(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, true, null, false, null, struct4_0.transform_1);
						}
						catch (Exception ex2)
						{
							list3 = new List<string>();
							GClass145.smethod_2("[Error]" + " " + ex2.Message);
						}
						this.method_340(this.list_17);
						struct4_0.list_1.Clear();
						struct4_0.list_1.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct4_0.list_2.Clear();
						struct4_0.list_2.AddRange(this.list_20);
						this.list_20.Clear();
						if (list3.Count > 0)
						{
							List<GameObject> list4 = new List<GameObject>();
							for (int k = struct4_0.list_0.Count - 1; k >= 0; k--)
							{
								for (int l = list3.Count - 1; l >= 0; l--)
								{
									GameObject gameObject2 = GClass84.smethod_351(struct4_0.list_0[k], list3[l]);
									if (gameObject2)
									{
										list4.Add(gameObject2);
									}
								}
							}
							if (list4.Count > 0)
							{
								this.method_283(list4, true);
								list4.Clear();
							}
							list3.Clear();
						}
					}
					struct4_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct4_0.int_0++;
					}
				}
				else if (struct4_0.int_0 == 2)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if (this.bool_48 && ((!this.bool_42 || !struct4_0.bool_0) && (!this.bool_43 || !struct4_0.bool_1)))
					{
						this.list_18.AddRange(struct4_0.list_1);
						this.list_20.AddRange(struct4_0.list_2);
						try
						{
							this.method_60(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, false, null, struct4_0.transform_1);
						}
						catch (Exception ex3)
						{
							GClass145.smethod_2("[Error]" + " " + ex3.Message);
						}
						this.method_340(this.list_17);
						struct4_0.list_1.Clear();
						struct4_0.list_1.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct4_0.list_2.Clear();
						struct4_0.list_2.AddRange(this.list_20);
						this.list_20.Clear();
						for (int num = struct4_0.list_0.Count - 1; num >= 0; num--)
						{
							this.int_50 = 0;
							this.list_18.AddRange(struct4_0.list_1);
							this.list_20.AddRange(struct4_0.list_2);
							try
							{
								this.method_60(struct4_0.list_0[num], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false, false, null, struct4_0.transform_1);
							}
							catch (Exception ex4)
							{
								GClass145.smethod_2("[Error]" + " " + ex4.Message);
							}
							this.method_340(this.list_17);
							struct4_0.list_1.Clear();
							struct4_0.list_1.AddRange(this.list_18);
							this.list_18.Clear();
							this.method_539(this.list_19);
							struct4_0.list_2.Clear();
							struct4_0.list_2.AddRange(this.list_20);
							this.list_20.Clear();
						}
					}
					struct4_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct4_0.int_0++;
					}
				}
				else if (struct4_0.int_0 == 3)
				{
					if (this.bool_30 && ((!this.bool_34 || !struct4_0.bool_0) && (!this.bool_35 || !struct4_0.bool_1)))
					{
						this.list_18.AddRange(struct4_0.list_1);
						this.list_20.AddRange(struct4_0.list_2);
						try
						{
							if (this.method_457(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, true, struct4_0.transform_1))
							{
								for (int m = struct4_0.list_0.Count - 1; m >= 0; m--)
								{
									this.method_457(struct4_0.list_0[m], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false, true, struct4_0.transform_1);
								}
							}
						}
						catch (Exception ex5)
						{
							GClass145.smethod_2("[Error]" + " " + ex5.Message);
						}
						this.method_340(this.list_17);
						struct4_0.list_1.Clear();
						struct4_0.list_1.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct4_0.list_2.Clear();
						struct4_0.list_2.AddRange(this.list_20);
						this.list_20.Clear();
					}
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				else if (struct4_0.int_0 == 4)
				{
					if (this.bool_139)
					{
						if ((this.bool_137 && struct4_0.bool_0) || (this.bool_138 && struct4_0.bool_1))
						{
							goto IL_9EF;
						}
						try
						{
							if (this.method_70(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int n = struct4_0.list_0.Count - 1; n >= 0; n--)
								{
									this.method_70(struct4_0.list_0[n], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
							goto IL_9EF;
						}
						catch (Exception ex6)
						{
							GClass145.smethod_2("[Error]" + " " + ex6.Message);
							goto IL_9EF;
						}
					}
					if (this.bool_141)
					{
						if ((this.bool_137 && struct4_0.bool_0) || (this.bool_138 && struct4_0.bool_1))
						{
							goto IL_9EF;
						}
						try
						{
							if (this.method_87(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int num2 = struct4_0.list_0.Count - 1; num2 >= 0; num2--)
								{
									this.method_87(struct4_0.list_0[num2], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
							goto IL_9EF;
						}
						catch (Exception ex7)
						{
							GClass145.smethod_2("[Error]" + " " + ex7.Message);
							goto IL_9EF;
						}
					}
					if (this.bool_146 && ((!this.bool_137 || !struct4_0.bool_0) && (!this.bool_138 || !struct4_0.bool_1)))
					{
						try
						{
							if (this.method_502(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int num3 = struct4_0.list_0.Count - 1; num3 >= 0; num3--)
								{
									this.method_502(struct4_0.list_0[num3], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
						}
						catch (Exception ex8)
						{
							GClass145.smethod_2("[Error]" + " " + ex8.Message);
						}
					}
					IL_9EF:
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				else if (struct4_0.int_0 == 5)
				{
					if (this.bool_51 && ((!this.bool_52 || !struct4_0.bool_0) && (!this.bool_53 || !struct4_0.bool_1)))
					{
						try
						{
							if (this.method_406(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int num4 = struct4_0.list_0.Count - 1; num4 >= 0; num4--)
								{
									this.method_406(struct4_0.list_0[num4], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
						}
						catch (Exception ex9)
						{
							GClass145.smethod_2("[Error]" + " " + ex9.Message);
						}
					}
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				else if (struct4_0.int_0 == 6)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if (this.bool_87 && ((!this.bool_90 || !struct4_0.bool_0) && (!this.bool_91 || !struct4_0.bool_1)))
					{
						try
						{
							this.method_328(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, true, struct4_0.transform_1);
						}
						catch (Exception ex10)
						{
							GClass145.smethod_2("[Error]" + " " + ex10.Message);
						}
						for (int num5 = struct4_0.list_0.Count - 1; num5 >= 0; num5--)
						{
							this.int_50 = 0;
							try
							{
								this.method_328(struct4_0.list_0[num5], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false, true, struct4_0.transform_1);
							}
							catch (Exception ex11)
							{
								GClass145.smethod_2("[Error]" + " " + ex11.Message);
							}
						}
					}
					struct4_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct4_0.int_0++;
					}
				}
				else if (struct4_0.int_0 == 7)
				{
					if (this.bool_56 && ((!this.bool_57 || !struct4_0.bool_0) && (!this.bool_58 || !struct4_0.bool_1)))
					{
						try
						{
							if (this.method_25(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int num6 = struct4_0.list_0.Count - 1; num6 >= 0; num6--)
								{
									this.method_25(struct4_0.list_0[num6], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
						}
						catch (Exception ex12)
						{
							GClass145.smethod_2("[Error]" + " " + ex12.Message);
						}
					}
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				else if (struct4_0.int_0 == 8)
				{
					if (this.bool_61 && ((!this.bool_62 || !struct4_0.bool_0) && (!this.bool_63 || !struct4_0.bool_1)))
					{
						try
						{
							if (this.method_233(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true))
							{
								for (int num7 = struct4_0.list_0.Count - 1; num7 >= 0; num7--)
								{
									this.method_233(struct4_0.list_0[num7], struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, false);
								}
							}
						}
						catch (Exception ex13)
						{
							GClass145.smethod_2("[Error]" + " " + ex13.Message);
						}
					}
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				else if (struct4_0.int_0 == 9)
				{
					if (this.bool_78 && ((!this.bool_79 || !struct4_0.bool_0) && (!this.bool_80 || !struct4_0.bool_1)))
					{
						List<string> list5;
						try
						{
							list5 = this.method_45(struct4_0.transform_0, struct4_0.string_0, struct4_0.consoleColor_0, struct4_0.bool_0, struct4_0.bool_1, true, true, null, false, null, null);
						}
						catch (Exception ex14)
						{
							list5 = new List<string>();
							GClass145.smethod_2("[Error]" + " " + ex14.Message);
						}
						if (list5.Count > 0)
						{
							for (int num8 = struct4_0.list_0.Count - 1; num8 >= 0; num8--)
							{
								for (int num9 = list5.Count - 1; num9 >= 0; num9--)
								{
									GameObject gameObject3 = GClass84.smethod_351(struct4_0.list_0[num8], list5[num9]);
									if (gameObject3)
									{
										Object.DestroyImmediate(gameObject3, true);
									}
								}
							}
							list5.Clear();
						}
					}
					struct4_0.int_1 = this.int_47;
					struct4_0.int_0++;
				}
				if (struct4_0.int_0 == 10)
				{
					if (this.int_47 >= this.int_46)
					{
						string str = string.Concat(new string[]
						{
							": ",
							"Log",
							" ",
							"Was",
							" ",
							"Limited",
							" ",
							"By",
							" ",
							this.int_47.ToString(),
							" ",
							"Lines"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(struct4_0.consoleColor_0, struct4_0.string_0),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str)
							});
						}
						else
						{
							GClass145.smethod_22(struct4_0.string_0 + str);
						}
						this.int_47++;
					}
					struct4_0.bool_2 = true;
				}
				result = struct4_0;
			}
			return result;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00045778 File Offset: 0x00043978
		internal void method_391(bool bool_168)
		{
			this.method_95(bool_168);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0004578C File Offset: 0x0004398C
		internal void method_392(bool bool_168)
		{
			this.bool_1 = bool_168;
			this.gclass40_0.bool_1 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000457B4 File Offset: 0x000439B4
		internal void method_393(bool bool_168)
		{
			this.method_102(bool_168);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000457C8 File Offset: 0x000439C8
		internal void method_394(bool bool_168)
		{
			this.method_351(bool_168);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000457DC File Offset: 0x000439DC
		internal void method_395(bool bool_168)
		{
			this.method_315(bool_168);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000457F0 File Offset: 0x000439F0
		private void method_396()
		{
			this.method_433();
			this.method_369();
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004580C File Offset: 0x00043A0C
		private void method_397(DynamicBone dynamicBone_0, string string_3, ConsoleColor consoleColor_0, bool bool_168)
		{
			this.method_2(dynamicBone_0, string_3, consoleColor_0, bool_168);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00045828 File Offset: 0x00043A28
		public override void vmethod_1()
		{
			this.method_378();
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0004583C File Offset: 0x00043A3C
		internal void method_398(bool bool_168)
		{
			this.bool_136 = bool_168;
			this.gclass40_0.bool_109 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00045864 File Offset: 0x00043A64
		internal void method_399(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170, bool bool_171, Transform transform_1)
		{
			if (transform_0)
			{
				if (this.bool_10)
				{
					string str = ": CheckForNullMeshes();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool flag = this.bool_8 && this.bool_20;
				List<Object> list = new List<Object>();
				int num = 0;
				List<MeshFilter> list2 = transform_0.GetComponents<MeshFilter>().ToList<MeshFilter>();
				list2.AddRange(transform_0.GetComponentsInChildren<MeshFilter>(true));
				for (int i = list2.Count - 1; i >= 0; i--)
				{
					bool flag2;
					bool flag3;
					string text;
					Mesh mesh = this.method_49(list2[i].transform, transform_1, GClass84.smethod_908(list2[i].transform, transform_0), GClass145.Enum2.const_0, out flag2, out flag3, out text, false);
					if (mesh && mesh.vertexCount == 0)
					{
						if (flag2)
						{
							GClass84.smethod_1522(mesh);
						}
						num++;
						Il2CppArrayBase<MeshRenderer> components = list2[i].GetComponents<MeshRenderer>();
						GClass84.smethod_505(list2[i], false);
						if (components.Count > 0 && !components[0].GetComponent<MeshFilter>())
						{
							for (int j = components.Count - 1; j >= 0; j--)
							{
								GClass84.smethod_424(components[j]);
							}
						}
					}
				}
				if (num > 0 && flag)
				{
					string str2 = string.Concat(new string[]
					{
						": ",
						num.ToString(),
						" ",
						"Mesh",
						"Filters",
						" ",
						"Had",
						" ",
						"Null",
						" ",
						"Mesh",
						". ",
						"Removed",
						" ",
						"Meshes"
					});
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str2);
					}
				}
				list.AddRange(list2);
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00045AD8 File Offset: 0x00043CD8
		private void method_400()
		{
			this.method_396();
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00045AEC File Offset: 0x00043CEC
		internal void method_401(bool bool_168)
		{
			this.bool_45 = bool_168;
			this.gclass40_0.bool_35 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00045B14 File Offset: 0x00043D14
		internal void method_402(bool bool_168)
		{
			this.bool_0 = bool_168;
			this.gclass40_0.bool_0 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00045B3C File Offset: 0x00043D3C
		internal void method_403(bool bool_168)
		{
			this.bool_126 = bool_168;
			this.gclass40_0.bool_101 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00045B64 File Offset: 0x00043D64
		private unsafe static void smethod_48(GClass145.Struct14* pStruct14_1, long long_0)
		{
			GClass145.smethod_17(pStruct14_1, long_0);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00045B78 File Offset: 0x00043D78
		private unsafe static void smethod_49(IntPtr intptr_2, float* pFloat_0, byte* pByte_0)
		{
			GClass145.smethod_4(intptr_2, pFloat_0, pByte_0);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00045B90 File Offset: 0x00043D90
		private unsafe static long smethod_50(GClass145.Struct13* pStruct13_0, HashSet<IntPtr> hashSet_0)
		{
			long result;
			if (pStruct13_0 == null)
			{
				result = 1L;
			}
			else
			{
				long long_ = pStruct13_0->long_0;
				long num = 1L;
				if (long_ <= 0L)
				{
					result = num;
				}
				else
				{
					hashSet_0.Add((IntPtr)((void*)pStruct13_0));
					GClass145.Struct13** ppStruct13_ = pStruct13_0->ppStruct13_0;
					if (ppStruct13_ == null)
					{
						pStruct13_0->long_0 = 0L;
						result = num;
					}
					else
					{
						int num2 = 0;
						while ((long)num2 < long_)
						{
							GClass145.Struct13* ptr = *(IntPtr*)(ppStruct13_ + (IntPtr)num2 * (IntPtr)sizeof(GClass145.Struct13*) / (IntPtr)sizeof(GClass145.Struct13*));
							if (hashSet_0.Contains((IntPtr)((void*)ptr)))
							{
								ref GClass145.Struct13 ptr2 = ref *ptr;
								pStruct13_0->long_0 = 0L;
								ptr2.long_0 = 0L;
								ptr->long_0 = 0L;
								return num;
							}
							num += GClass145.smethod_50(ptr, hashSet_0);
							num2++;
						}
						result = num;
					}
				}
			}
			return result;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00045C84 File Offset: 0x00043E84
		internal void method_404(bool bool_168)
		{
			this.bool_146 = bool_168;
			this.gclass40_0.bool_18 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00045CAC File Offset: 0x00043EAC
		private static void smethod_51(ref bool bool_168)
		{
			try
			{
				if (GClass145.Struct10.bool_0 && GClass145.Struct10.apiAvatar_0 != null)
				{
					if (GClass84.gclass145_0.bool_163)
					{
						bool_168 = false;
					}
					else
					{
						ApiAvatar apiAvatar_ = GClass145.Struct10.apiAvatar_0;
						VRCAvatarManager vrcavatarManager_ = GClass145.Struct10.vrcavatarManager_0;
						VRCPlayer field_Private_VRCPlayer_ = vrcavatarManager_.field_Private_VRCPlayer_0;
						if (!(field_Private_VRCPlayer_ == null))
						{
							Player player = field_Private_VRCPlayer_.Method_Public_get_Player_0();
							APIUser apiuser = (player != null) ? player.Method_Internal_get_APIUser_0() : null;
							if (apiuser != null)
							{
								string id = apiuser.id;
								if (GClass84.gclass145_0.bool_161 || !GClass84.smethod_1311(id))
								{
									if (!GClass84.gclass145_0.bool_162 || !GClass84.smethod_382(id))
									{
										if (GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_.authorId, "") || GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_.id, ""))
										{
											GClass145.smethod_22(string.Concat(new string[]
											{
												"Hiding",
												" ",
												"avatar",
												" ",
												"on",
												" ",
												apiuser.displayName,
												" ",
												"because",
												" ",
												"it",
												" ",
												"or",
												" ",
												"its",
												" ",
												"author",
												" ",
												"is",
												" ",
												"hidden"
											}));
											bool_168 = false;
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				string[] array = new string[11];
				array[0] = "Exception";
				array[1] = " ";
				array[2] = "in";
				array[3] = " ";
				array[4] = "Can";
				array[5] = "Use";
				array[6] = "Custom";
				array[7] = "Avatar";
				array[8] = "Patch";
				array[9] = ": ";
				int num = 10;
				Exception ex2 = ex;
				array[num] = ((ex2 != null) ? ex2.ToString() : null);
				GClass145.smethod_2(string.Concat(array));
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00045F08 File Offset: 0x00044108
		internal void method_405(bool bool_168)
		{
			this.method_414(bool_168);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00045F1C File Offset: 0x0004411C
		internal bool method_406(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForColliders();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				int num = 0;
				List<Collider> list = transform_0.GetComponents<Collider>().ToList<Collider>();
				list.AddRange(transform_0.GetComponentsInChildren<Collider>(true));
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i])
					{
						list[i].enabled = false;
						GClass84.smethod_59(list[i]);
						num++;
					}
				}
				bool flag = false;
				if (num > 0)
				{
					if (this.bool_8 && bool_170 && this.bool_54 && (!bool_168 || (!this.bool_55 && !this.bool_9)) && this.int_47 < this.int_46)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							num.ToString(),
							" ",
							"Colliders",
							" ",
							"Were",
							" ",
							"Removed"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						this.int_47++;
					}
					flag = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000460E0 File Offset: 0x000442E0
		private void method_407(GClass84.GStruct146 gstruct146_0)
		{
			for (int i = this.list_20.Count - 1; i >= 0; i--)
			{
				if (this.list_20[i].string_0 == gstruct146_0.string_0)
				{
					return;
				}
			}
			this.list_20.Add(gstruct146_0);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00046134 File Offset: 0x00044334
		internal void method_408(bool bool_168)
		{
			this.method_58(bool_168);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00046148 File Offset: 0x00044348
		internal static void smethod_52(IntPtr intptr_2, IntPtr intptr_3, bool bool_168)
		{
			GClass145.smethod_1(intptr_2, intptr_3, bool_168 ? 204 : 144);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0004616C File Offset: 0x0004436C
		internal void method_409(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = true, Transform transform_1 = null)
		{
			this.method_31(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170, bool_171, transform_1);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00046198 File Offset: 0x00044398
		internal void method_410(bool bool_168)
		{
			this.bool_101 = bool_168;
			this.gclass40_0.bool_80 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000461C0 File Offset: 0x000443C0
		private static IntPtr smethod_53(IntPtr intptr_2, uint uint_0, ulong ulong_0)
		{
			return GClass145.delegate14_0(intptr_2, uint_0, ulong_0);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000461DC File Offset: 0x000443DC
		internal void method_411(bool bool_168)
		{
			this.method_68(bool_168);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000461F0 File Offset: 0x000443F0
		internal void method_412(bool bool_168)
		{
			this.method_297(bool_168);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00046204 File Offset: 0x00044404
		internal void method_413(bool bool_168)
		{
			this.method_496(bool_168);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00046218 File Offset: 0x00044418
		internal void method_414(bool bool_168)
		{
			this.bool_2 = bool_168;
			this.gclass40_0.bool_2 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00046240 File Offset: 0x00044440
		internal void method_415(bool bool_168)
		{
			this.method_109(bool_168);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00046254 File Offset: 0x00044454
		internal void method_416(bool bool_168)
		{
			this.method_175(bool_168);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00046268 File Offset: 0x00044468
		internal void method_417()
		{
			this.list_10.Clear();
			this.list_10.AddRange(this.list_7);
			if (this.bool_147)
			{
				this.list_10.AddRange(this.list_5);
			}
			if (this.bool_148)
			{
				this.list_10.AddRange(this.list_6);
			}
			this.list_11.Clear();
			this.list_10.AddRange(this.list_8);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000462E0 File Offset: 0x000444E0
		internal void method_418(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			if (transform_0)
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitCloth();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				bool flag = this.bool_8 && bool_170 && this.bool_109 && (!bool_168 || (!this.bool_110 && !this.bool_9));
				List<Object> list = new List<Object>();
				List<Cloth> list2 = GClass84.smethod_951(transform_0);
				list.AddRange(list2);
				for (int i = 0; i < list2.Count; i++)
				{
					if (list2[i].clothSolverFrequency > this.float_12)
					{
						if (flag)
						{
							string str2 = string.Concat(new string[]
							{
								": ",
								list2[i].gameObject.name,
								" ",
								"Used",
								" ",
								"Too",
								" ",
								"Many",
								" ",
								"Updates",
								" ",
								"Per",
								" ",
								"Second",
								" ",
								"For",
								" ",
								"Cloth",
								" (",
								list2[i].clothSolverFrequency.ToString(),
								")",
								". ",
								"Changed",
								" ",
								"To",
								" ",
								this.float_12.ToString()
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str2);
							}
						}
						list2[i].clothSolverFrequency = this.float_12;
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004654C File Offset: 0x0004474C
		internal void method_419()
		{
			this.method_377();
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00046560 File Offset: 0x00044760
		private void method_420()
		{
			this.method_532();
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00046574 File Offset: 0x00044774
		private bool method_421(string string_3)
		{
			if (this.bool_155)
			{
				this.method_426(string_3);
			}
			for (int i = this.list_10.Count - 1; i >= 0; i--)
			{
				if (this.list_10[i] == string_3)
				{
					return true;
				}
			}
			string text = string_3.ToLower();
			for (int j = this.list_11.Count - 1; j >= 0; j--)
			{
				if (text.Contains(this.list_11[j].ToLower()))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00046614 File Offset: 0x00044814
		internal void method_422(bool bool_168)
		{
			this.bool_70 = bool_168;
			this.gclass40_0.bool_57 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0004663C File Offset: 0x0004483C
		internal void method_423(List<GClass84.GStruct146> list_30)
		{
			for (int i = list_30.Count - 1; i >= 0; i--)
			{
				this.method_305(list_30[i]);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00046670 File Offset: 0x00044870
		internal void method_424(bool bool_168)
		{
			this.method_174(bool_168);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00046684 File Offset: 0x00044884
		private void method_425(GClass84.GStruct136 gstruct136_0)
		{
			for (int i = this.list_18.Count - 1; i >= 0; i--)
			{
				if (this.list_18[i].string_0 == gstruct136_0.string_0 && this.list_18[i].bool_0 == gstruct136_0.bool_0)
				{
					return;
				}
			}
			this.list_18.Add(gstruct136_0);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000466F8 File Offset: 0x000448F8
		internal bool method_426(string string_3)
		{
			bool result;
			if (string_3 == null || string_3 == string.Empty)
			{
				result = false;
			}
			else
			{
				for (int i = this.list_13.Count - 1; i >= 0; i--)
				{
					if (this.list_13[i] == string_3)
					{
						return false;
					}
				}
				this.list_13.Add(string_3);
				result = true;
			}
			return result;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00046760 File Offset: 0x00044960
		internal void method_427(bool bool_168)
		{
			this.method_83(bool_168);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00046774 File Offset: 0x00044974
		private void method_428(Object object_0)
		{
			this.method_500(object_0);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00046788 File Offset: 0x00044988
		internal void method_429(bool bool_168)
		{
			this.method_286(bool_168);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0004679C File Offset: 0x0004499C
		internal void method_430(bool bool_168)
		{
			this.method_54(bool_168);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000467B0 File Offset: 0x000449B0
		internal void method_431(bool bool_168)
		{
			this.method_90(bool_168);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000467C4 File Offset: 0x000449C4
		internal void method_432()
		{
			MelonCoroutines.Start(GClass145.smethod_20());
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000467DC File Offset: 0x000449DC
		internal void method_433()
		{
			this.method_327();
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000467F0 File Offset: 0x000449F0
		internal void method_434(bool bool_168)
		{
			this.method_243(bool_168);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00046804 File Offset: 0x00044A04
		internal void method_435()
		{
			GClass40.smethod_2();
			GClass40.smethod_1();
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004681C File Offset: 0x00044A1C
		private void method_436(GClass84.GStruct136 gstruct136_0)
		{
			this.method_425(gstruct136_0);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00046830 File Offset: 0x00044A30
		internal void method_437(bool bool_168)
		{
			this.method_124(bool_168);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00046844 File Offset: 0x00044A44
		private static bool smethod_54(ApiAvatar apiAvatar_0, string string_3)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22(string.Concat(new string[]
					{
						"VRCAvatarManager_ApiAvatar_String",
						": ",
						apiAvatar_0.id,
						", ",
						string_3
					}));
				}
				else
				{
					GClass145.smethod_22("VRCAvatarManager_ApiAvatar_String()");
				}
			}
			return !GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, "")));
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000468F8 File Offset: 0x00044AF8
		internal void method_438(bool bool_168)
		{
			this.bool_104 = bool_168;
			this.gclass40_0.bool_83 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00046920 File Offset: 0x00044B20
		internal void method_439(bool bool_168)
		{
			this.bool_150 = bool_168;
			this.gclass40_0.bool_28 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00046948 File Offset: 0x00044B48
		internal void method_440(Transform transform_0, bool bool_168 = false)
		{
			this.method_446(transform_0, bool_168);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00046960 File Offset: 0x00044B60
		internal void method_441(bool bool_168)
		{
			this.method_240(bool_168);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00046974 File Offset: 0x00044B74
		internal void method_442(bool bool_168)
		{
			this.method_222(bool_168);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0003C090 File Offset: 0x0003A290
		private static IntPtr smethod_55(IntPtr intptr_2, uint uint_0, uint uint_1)
		{
			return GClass145.delegate15_0(intptr_2, uint_0, uint_1);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00046988 File Offset: 0x00044B88
		internal void method_443(Transform transform_0, bool bool_168)
		{
			if (transform_0)
			{
				this.method_176(transform_0);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x000469A8 File Offset: 0x00044BA8
		private void method_444()
		{
			this.method_530();
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000469BC File Offset: 0x00044BBC
		internal void method_445(bool bool_168)
		{
			this.bool_140 = bool_168;
			this.gclass40_0.bool_25 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000469E4 File Offset: 0x00044BE4
		internal void method_446(Transform transform_0, bool bool_168)
		{
			this.method_443(transform_0, bool_168);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000469FC File Offset: 0x00044BFC
		internal void method_447(bool bool_168)
		{
			this.bool_155 = bool_168;
			this.gclass40_0.bool_27 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00046A24 File Offset: 0x00044C24
		internal void method_448(bool bool_168)
		{
			this.bool_82 = bool_168;
			this.gclass40_0.bool_68 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00046A4C File Offset: 0x00044C4C
		internal void method_449(Transform transform_0, string string_3)
		{
			this.method_39(transform_0, string_3);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00046A64 File Offset: 0x00044C64
		private void method_450()
		{
			if (this.list_16.Count == 0)
			{
				if (this.int_52 > 0)
				{
					if (this.bool_8 && this.bool_154 && this.int_52 >= this.int_45)
					{
						GClass145.smethod_22(string.Concat(new string[]
						{
							this.int_52.ToString(),
							" ",
							"Objects",
							" ",
							"Were",
							" ",
							"Destroyed"
						}));
					}
					this.int_52 = 0;
				}
			}
			else
			{
				int num = GClass84.smethod_741(this.list_16.Count, this.int_44);
				for (int i = 0; i < num; i++)
				{
					try
					{
						if (this.list_16[i] && (this.list_16[i].name != "Cube" && this.list_16[i].name != "Capsule" && this.list_16[i].name != "Cylinder" && this.list_16[i].name != "Plane" && this.list_16[i].name != "Sphere" && this.list_16[i].name != "Quad"))
						{
							Object.DestroyImmediate(this.list_16[i], true);
							this.int_52++;
						}
					}
					catch (Exception ex)
					{
						GClass145.smethod_2(ex.ToString());
					}
				}
				this.list_16.RemoveRange(0, num);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00046C64 File Offset: 0x00044E64
		internal void method_451()
		{
			this.method_234();
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00046C78 File Offset: 0x00044E78
		private string method_452(MethodBase methodBase_0)
		{
			return this.method_558(methodBase_0);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00046C8C File Offset: 0x00044E8C
		internal void method_453(bool bool_168)
		{
			this.method_445(bool_168);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00046CA0 File Offset: 0x00044EA0
		internal void method_454(bool bool_168)
		{
			this.method_224(bool_168);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static bool smethod_56(string string_3, int int_54, ulong ulong_0, ref AssetBundle assetBundle_0)
		{
			return true;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00046CB4 File Offset: 0x00044EB4
		internal void method_455(bool bool_168)
		{
			this.method_116(bool_168);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00046CC8 File Offset: 0x00044EC8
		internal void method_456(bool bool_168)
		{
			this.method_316(bool_168);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00046CDC File Offset: 0x00044EDC
		internal bool method_457(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, bool bool_171 = true, Transform transform_1 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": LimitMaterials();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				if (this.list_17 == null)
				{
					this.list_17 = new List<GClass84.GStruct136>();
				}
				else
				{
					this.list_17.Clear();
				}
				this.list_17.AddRange(this.list_18);
				if (this.list_19 == null)
				{
					this.list_19 = new List<GClass84.GStruct146>();
				}
				else
				{
					this.list_19.Clear();
				}
				this.list_19.AddRange(this.list_20);
				Transform[] array = GClass84.smethod_1519(transform_0);
				List<GClass145.Struct5> list = new List<GClass145.Struct5>();
				bool flag = this.bool_8 && bool_170 && this.bool_33 && (!bool_168 || (!this.bool_40 && !this.bool_9));
				bool flag2 = false;
				List<Object> list2 = new List<Object>();
				for (int i = 0; i < array.Length; i++)
				{
					MeshFilter component = array[i].GetComponent<MeshFilter>();
					SkinnedMeshRenderer skinnedMeshRenderer = null;
					bool flag3 = false;
					string empty = string.Empty;
					Mesh mesh = null;
					int num = 0;
					bool flag4 = false;
					if (component)
					{
						mesh = this.method_49(array[i], transform_1, GClass84.smethod_908(array[i], transform_0), GClass145.Enum2.const_0, out flag4, out flag3, out empty, false);
						if (mesh)
						{
							num = mesh.subMeshCount;
							if (bool_171)
							{
								list2.Add(mesh);
							}
						}
					}
					else
					{
						skinnedMeshRenderer = array[i].GetComponent<SkinnedMeshRenderer>();
						if (skinnedMeshRenderer)
						{
							mesh = this.method_49(array[i], transform_1, GClass84.smethod_908(array[i], transform_0), GClass145.Enum2.const_1, out flag4, out flag3, out empty, false);
							if (mesh)
							{
								num = mesh.subMeshCount;
							}
						}
					}
					Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
					list2.AddRange(components);
					bool flag5 = false;
					for (int j = 0; j < components.Count; j++)
					{
						Il2CppReferenceArray<Material> il2CppReferenceArray = components[j].GetSharedMaterialArray();
						int length = il2CppReferenceArray.Length;
						if (flag5)
						{
							components[j].enabled = false;
							if (length > 0)
							{
								components[j].SetMaterialArray(new Il2CppReferenceArray<Material>(0L));
							}
						}
						else
						{
							if (!mesh)
							{
								if ((!components[j].TryCast<ParticleSystemRenderer>() || !array[i].GetComponent<ParticleSystem>()) && !components[j].TryCast<LineRenderer>() && !components[j].TryCast<TrailRenderer>())
								{
									if (length > 0)
									{
										if (flag && this.int_47 < this.int_46)
										{
											string str2 = string.Concat(new string[]
											{
												": ",
												array[i].name,
												" Had ",
												length.ToString(),
												" ",
												"Materials",
												" ",
												"Without",
												" ",
												"Mesh",
												". ",
												"Removed",
												" ",
												"Materials"
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str2);
											}
											this.int_47++;
										}
										components[j].SetMaterialArray(new Il2CppReferenceArray<Material>(0L));
										flag2 = true;
										goto IL_EF5;
									}
									goto IL_EF5;
								}
							}
							else if (!array[i].GetComponent<ParticleSystem>() && this.bool_32)
							{
								if (num == 1)
								{
									if (length > 1)
									{
										if (flag && this.int_47 < this.int_46)
										{
											string str3 = string.Concat(new string[]
											{
												": ",
												array[i].name,
												" Had ",
												length.ToString(),
												" ",
												"Materials",
												", ",
												"But",
												" ",
												"Mesh",
												" ",
												"Supports",
												" ",
												"1",
												" ",
												"Material",
												". ",
												"Reduced",
												" ",
												"To",
												" ",
												"One",
												" ",
												"Material"
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str3);
											}
											this.int_47++;
										}
										Renderer renderer = components[j];
										Il2CppReferenceArray<Material> il2CppReferenceArray2 = new Il2CppReferenceArray<Material>(1L);
										il2CppReferenceArray2[0] = il2CppReferenceArray[0];
										renderer.SetMaterialArray(il2CppReferenceArray2);
										flag2 = true;
										goto IL_EF5;
									}
								}
								else if (length > num)
								{
									if (flag && this.int_47 < this.int_46)
									{
										string str4 = string.Concat(new string[]
										{
											": ",
											array[i].name,
											" Had ",
											length.ToString(),
											" ",
											"Materials",
											", ",
											"But",
											" ",
											"Mesh",
											" ",
											"Supports",
											" ",
											num.ToString(),
											" ",
											"Materials",
											". ",
											"Reduced",
											" ",
											"To",
											" ",
											num.ToString(),
											" ",
											"Materials"
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str4);
										}
										this.int_47++;
									}
									Il2CppReferenceArray<Material> il2CppReferenceArray3 = new Il2CppReferenceArray<Material>((long)num);
									for (int k = 0; k < num; k++)
									{
										il2CppReferenceArray3[k] = il2CppReferenceArray[k];
									}
									components[j].SetMaterialArray(il2CppReferenceArray3);
									il2CppReferenceArray = il2CppReferenceArray3;
									flag2 = true;
								}
							}
							if (length >= this.int_2)
							{
								flag2 = true;
								int l = 0;
								while (l < list.Count)
								{
									GClass145.Struct5 @struct = list[l];
									if (@struct.int_3 != num || !(@struct.transform_0.parent == array[i].parent) || !(empty == @struct.string_0) || (!(@struct.transform_0.position == array[i].position) && (this.int_5 <= 0 || !this.method_209(@struct.transform_0.position, array[i].position, this.int_5, this.int_6, this.float_2, this.float_3, this.float_4))) || ((!flag3 || !@struct.bool_0) && !(@struct.transform_0.rotation == array[i].rotation)) || (!(@struct.transform_0.lossyScale == array[i].lossyScale) && (this.int_7 <= 0 || !this.method_209(@struct.transform_0.lossyScale, array[i].lossyScale, this.int_7, this.int_8, this.float_5, this.float_6, this.float_7))))
									{
										l++;
									}
									else
									{
										@struct.int_1++;
										if (@struct.int_1 > this.int_4)
										{
											@struct.int_2++;
											array[i].gameObject.SetActive(false);
											components[j].enabled = false;
											flag5 = true;
										}
										list[l] = @struct;
										IL_8D6:
										if (flag5)
										{
											goto IL_EF5;
										}
										if (l == list.Count)
										{
											list.Add(new GClass145.Struct5(array[i], length, 1, 0, flag3, empty, num));
										}
										Renderer renderer2 = components[j];
										Il2CppReferenceArray<Material> il2CppReferenceArray4 = new Il2CppReferenceArray<Material>(1L);
										il2CppReferenceArray4[0] = il2CppReferenceArray[0];
										renderer2.SetMaterialArray(il2CppReferenceArray4);
										if (flag && this.int_47 < this.int_46)
										{
											string str5 = string.Concat(new string[]
											{
												": ",
												array[i].name,
												" ",
												"Had",
												" ",
												"Lots",
												" ",
												"Of",
												" ",
												"Materials",
												" (",
												length.ToString(),
												")",
												". ",
												"Reduced",
												" ",
												"To",
												" ",
												"One",
												" ",
												"Material"
											});
											if (this.bool_11)
											{
												GClass145.smethod_14(new List<GClass84.GStruct172>
												{
													new GClass84.GStruct172(consoleColor_0, string_3),
													new GClass84.GStruct172(ConsoleColor.DarkGray, str5)
												});
											}
											else
											{
												GClass145.smethod_22(string_3 + str5);
											}
											this.int_47++;
											goto IL_EF5;
										}
										goto IL_EF5;
									}
								}
								goto IL_8D6;
							}
							if (length > this.int_1)
							{
								Il2CppReferenceArray<Material> il2CppReferenceArray5 = new Il2CppReferenceArray<Material>((long)this.int_1);
								int num2 = 0;
								bool flag6 = !this.bool_31;
								flag2 = true;
								int num3 = 0;
								while (num3 < il2CppReferenceArray.Count && num2 < this.int_1)
								{
									if (!flag6 && num2 > 0 && il2CppReferenceArray5[num2 - 1] && il2CppReferenceArray5[num2 - 1].name != il2CppReferenceArray[num3].name)
									{
										flag6 = true;
									}
									il2CppReferenceArray5[num2] = il2CppReferenceArray[num3];
									num2++;
									num3++;
								}
								if (flag6)
								{
									components[j].SetMaterialArray(il2CppReferenceArray5);
									if (flag && this.int_47 < this.int_46)
									{
										string str6 = string.Concat(new string[]
										{
											": ",
											array[i].name,
											" Had ",
											length.ToString(),
											" ",
											"Materials",
											". ",
											"Reduced",
											" ",
											"To",
											" ",
											this.int_1.ToString()
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str6)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str6);
										}
										this.int_47++;
									}
								}
								else
								{
									Renderer renderer3 = components[j];
									Il2CppReferenceArray<Material> il2CppReferenceArray6 = new Il2CppReferenceArray<Material>(1L);
									il2CppReferenceArray6[0] = il2CppReferenceArray5[0];
									renderer3.SetMaterialArray(il2CppReferenceArray6);
									if (flag && this.int_47 < this.int_46)
									{
										string str7 = string.Concat(new string[]
										{
											": ",
											array[i].name,
											" Had ",
											il2CppReferenceArray5.Length.ToString(),
											" ",
											"Identical",
											" ",
											"Materials",
											". ",
											"Reduced",
											" ",
											"To",
											" ",
											"One",
											" ",
											"Material"
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str7)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str7);
										}
										this.int_47++;
									}
								}
							}
							else if (this.int_3 > 0 && length >= this.int_3 && length > 1 && !array[i].GetComponent<ParticleSystem>())
							{
								int num4 = 1;
								while (num4 < this.int_3 && !(il2CppReferenceArray[0].name != il2CppReferenceArray[num4].name))
								{
									num4++;
								}
								if (num4 == this.int_3)
								{
									Renderer renderer4 = components[j];
									Il2CppReferenceArray<Material> il2CppReferenceArray7 = new Il2CppReferenceArray<Material>(1L);
									il2CppReferenceArray7[0] = il2CppReferenceArray[0];
									renderer4.SetMaterialArray(il2CppReferenceArray7);
									flag2 = true;
									if (flag && this.int_47 < this.int_46)
									{
										string str8 = string.Concat(new string[]
										{
											": ",
											array[i].name,
											" Had ",
											length.ToString(),
											" ",
											"Identical",
											" ",
											"Materials",
											". ",
											"Reduced",
											" ",
											"To",
											" ",
											"One",
											" ",
											"Material"
										});
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, str8)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + str8);
										}
										this.int_47++;
									}
								}
							}
						}
						IL_EF5:;
					}
					if (flag5)
					{
						if (flag4)
						{
							GClass84.smethod_1522(mesh);
						}
						else if (component)
						{
							component.sharedMesh = null;
						}
						else if (skinnedMeshRenderer)
						{
							skinnedMeshRenderer.sharedMesh = null;
						}
						GClass84.smethod_890(array[i].gameObject, false);
					}
				}
				if (list2.Count > 0)
				{
					this.method_248(transform_0, list2);
				}
				if (flag)
				{
					for (int m = list.Count - 1; m >= 0; m--)
					{
						if (list[m].int_2 > 0 && this.int_47 < this.int_46)
						{
							string str9 = string.Concat(new string[]
							{
								": ",
								list[m].int_2.ToString(),
								" ",
								"Objects",
								" ",
								"Had",
								" ",
								"Lots",
								" ",
								"Of",
								" ",
								"Materials",
								" ",
								"And",
								" ",
								"Similar",
								" ",
								"To",
								" ",
								list[m].transform_0.name,
								". ",
								"Was",
								" ",
								"Destroyed",
								" ",
								"Because",
								" ",
								"Of",
								" ",
								"The",
								" ",
								"Same",
								" ",
								"Objects"
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str9)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str9);
							}
							this.int_47++;
						}
					}
				}
				if (list != null)
				{
					list.Clear();
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00047E60 File Offset: 0x00046060
		internal void method_458(bool bool_168)
		{
			this.method_355(bool_168);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00047E74 File Offset: 0x00046074
		internal bool method_459(string string_3, string string_4)
		{
			return !(string_3 == string.Empty) && this.method_27(new GClass145.GStruct102(string_3, string_4));
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00047EA4 File Offset: 0x000460A4
		internal void method_460(bool bool_168)
		{
			this.bool_107 = bool_168;
			this.gclass40_0.bool_86 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00047ECC File Offset: 0x000460CC
		internal void method_461(Transform transform_0, string string_3)
		{
			this.method_154(transform_0, string_3);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00047EE4 File Offset: 0x000460E4
		internal void method_462(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			this.method_510(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00047F08 File Offset: 0x00046108
		internal void method_463(bool bool_168)
		{
			this.bool_64 = bool_168;
			this.gclass40_0.bool_51 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00047F30 File Offset: 0x00046130
		internal void method_464(bool bool_168)
		{
			this.method_164(bool_168);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00047F44 File Offset: 0x00046144
		internal bool method_465(GClass145.GStruct102 gstruct102_0)
		{
			for (int i = this.list_27.Count - 1; i >= 0; i--)
			{
				if (this.list_27[i].string_0 == gstruct102_0.string_0)
				{
					return false;
				}
			}
			this.list_27.Add(gstruct102_0);
			this.gclass107_0.list_6 = this.list_27;
			this.gclass107_0.method_26();
			return true;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00047FBC File Offset: 0x000461BC
		internal void method_466()
		{
			this.method_223();
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00047FD0 File Offset: 0x000461D0
		internal void method_467(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForShaderNameCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				int num = 0;
				List<Renderer> list = transform_0.GetComponents<Renderer>().ToList<Renderer>();
				list.AddRange(transform_0.GetComponentsInChildren<Renderer>(true));
				for (int i = list.Count - 1; i >= 0; i--)
				{
					for (int j = 0; j < list[i].sharedMaterials.Count; j++)
					{
						if (list[i].sharedMaterials[j])
						{
							Shader shader = list[i].sharedMaterials[j].shader;
							if (shader && shader.name.Length > 250)
							{
								shader.name = GClass84.smethod_1428(shader.name, 250);
								num++;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004810C File Offset: 0x0004630C
		internal void method_468(List<GClass84.GStruct136> list_30)
		{
			this.method_561(list_30);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00048120 File Offset: 0x00046320
		internal List<GClass145.GStruct102> method_469()
		{
			List<GClass145.GStruct102> list = new List<GClass145.GStruct102>();
			list.AddRange(this.list_21);
			if (this.bool_157)
			{
				list.AddRange(this.list_22);
			}
			return list;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00048158 File Offset: 0x00046358
		internal void method_470(bool bool_168)
		{
			this.method_511(bool_168);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0004816C File Offset: 0x0004636C
		internal void method_471(bool bool_168)
		{
			this.method_275(bool_168);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00048180 File Offset: 0x00046380
		internal void method_472(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168 = false)
		{
			this.method_160(transform_0, string_3, consoleColor_0, bool_168);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0004819C File Offset: 0x0004639C
		internal void method_473(bool bool_168)
		{
			this.method_484(bool_168);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000481B0 File Offset: 0x000463B0
		internal void method_474(bool bool_168)
		{
			this.bool_163 = bool_168;
			this.gclass40_0.bool_113 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000481D8 File Offset: 0x000463D8
		internal void method_475(bool bool_168)
		{
			this.method_527(bool_168);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000481EC File Offset: 0x000463EC
		internal void method_476(bool bool_168)
		{
			this.method_121(bool_168);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00048200 File Offset: 0x00046400
		private void method_477(float float_17)
		{
			this.method_114(float_17);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00048214 File Offset: 0x00046414
		internal void method_478(bool bool_168)
		{
			this.method_323(bool_168);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00048228 File Offset: 0x00046428
		internal void method_479(bool bool_168)
		{
			this.method_98(bool_168);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0004823C File Offset: 0x0004643C
		internal void method_480(bool bool_168)
		{
			this.method_147(bool_168);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00048250 File Offset: 0x00046450
		internal void method_481(bool bool_168)
		{
			this.method_189(bool_168);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00048264 File Offset: 0x00046464
		internal List<GClass145.GStruct102> method_482()
		{
			List<GClass145.GStruct102> list = new List<GClass145.GStruct102>();
			list.AddRange(this.list_23);
			if (this.bool_158)
			{
				list.AddRange(this.list_24);
			}
			return list;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0004829C File Offset: 0x0004649C
		internal bool method_483(GameObject gameObject_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			return this.method_25((gameObject_0 != null) ? gameObject_0.transform : null, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x000482C4 File Offset: 0x000464C4
		internal void method_484(bool bool_168)
		{
			this.bool_30 = bool_168;
			this.gclass40_0.bool_13 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000482EC File Offset: 0x000464EC
		private string method_485(MethodBase methodBase_0)
		{
			string arg = string.Join(",", methodBase_0.GetParameters().Select(new Func<ParameterInfo, string>(GClass145.Class85.class85_0.method_1)));
			return string.Format("{0}.{1}({2})", methodBase_0.DeclaringType, methodBase_0.Name, arg);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00048348 File Offset: 0x00046548
		internal void method_486(bool bool_168)
		{
			this.method_162(bool_168);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0004835C File Offset: 0x0004655C
		internal void method_487(Transform transform_0, string string_3)
		{
			this.method_449(transform_0, string_3);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00048374 File Offset: 0x00046574
		internal void method_488(bool bool_168)
		{
			this.method_46(bool_168);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00048388 File Offset: 0x00046588
		internal void method_489(bool bool_168)
		{
			this.method_391(bool_168);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0004839C File Offset: 0x0004659C
		internal void method_490()
		{
			this.gclass107_0.method_4();
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000483B4 File Offset: 0x000465B4
		internal void method_491(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			this.method_7(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000483D8 File Offset: 0x000465D8
		internal void method_492(bool bool_168)
		{
			this.method_67(bool_168);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000483EC File Offset: 0x000465EC
		internal void method_493(bool bool_168)
		{
			this.bool_113 = bool_168;
			this.gclass40_0.bool_92 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00048414 File Offset: 0x00046614
		internal void method_494(bool bool_168)
		{
			this.bool_7 = bool_168;
			this.gclass40_0.bool_12 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0004843C File Offset: 0x0004663C
		internal void method_495()
		{
			this.method_432();
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00048450 File Offset: 0x00046650
		internal void method_496(bool bool_168)
		{
			this.method_117(bool_168);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00048464 File Offset: 0x00046664
		internal void method_497(bool bool_168)
		{
			this.method_8(bool_168);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00048478 File Offset: 0x00046678
		internal void method_498(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			this.method_92(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0004849C File Offset: 0x0004669C
		internal void method_499(bool bool_168)
		{
			this.method_321(bool_168);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000484B0 File Offset: 0x000466B0
		private void method_500(Object object_0)
		{
			this.method_156(object_0);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000484C4 File Offset: 0x000466C4
		internal void method_501(bool bool_168)
		{
			this.method_88(bool_168);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000484D8 File Offset: 0x000466D8
		internal bool method_502(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10 && bool_170)
				{
					string str = ": CheckForBlackShaders();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				string a = string.Empty;
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = this.bool_8 && bool_170 && this.bool_149 && (!bool_168 || (!this.bool_152 && !this.bool_9));
				bool flag2 = false;
				List<Object> list = new List<Object>();
				for (int i = 0; i < array.Length; i++)
				{
					Il2CppArrayBase<Renderer> components = array[i].GetComponents<Renderer>();
					list.AddRange(components);
					for (int j = 0; j < components.Count; j++)
					{
						Il2CppReferenceArray<Material> materialArray = components[j].GetMaterialArray();
						list.AddRange(materialArray);
						for (int k = 0; k < materialArray.Count; k++)
						{
							if (materialArray[k].shader && this.method_421(materialArray[k].shader.name))
							{
								if (flag && this.int_47 < this.int_46)
								{
									string text = string.Concat(new string[]
									{
										": ",
										array[i].name,
										" ",
										"Had",
										" ",
										"Black",
										" ",
										"Shader",
										" ",
										materialArray[k].shader.name,
										". ",
										"Changed",
										" ",
										"To",
										" ",
										"Standard"
									});
									if (a != text)
									{
										if (this.bool_11)
										{
											GClass145.smethod_14(new List<GClass84.GStruct172>
											{
												new GClass84.GStruct172(consoleColor_0, string_3),
												new GClass84.GStruct172(ConsoleColor.DarkGray, text)
											});
										}
										else
										{
											GClass145.smethod_22(string_3 + text);
										}
										a = text;
									}
									this.int_47++;
								}
								materialArray[k].shader = GClass84.smethod_1455();
								if (this.bool_150)
								{
									GClass84.smethod_1033(materialArray[k]);
								}
								if (this.bool_151)
								{
									GClass84.smethod_1385(materialArray[k]);
								}
								flag2 = true;
							}
						}
					}
				}
				if (list.Count > 0)
				{
					this.method_248(transform_0, list);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000487BC File Offset: 0x000469BC
		internal static void smethod_57(string string_3)
		{
			GClass70.smethod_36(string_3, GClass70.Enum1.const_2);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000487D0 File Offset: 0x000469D0
		private void method_503(float float_17)
		{
			this.method_6(float_17);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000487E4 File Offset: 0x000469E4
		internal void method_504(bool bool_168)
		{
			this.method_79(bool_168);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000487F8 File Offset: 0x000469F8
		internal void method_505(bool bool_168)
		{
			this.method_402(bool_168);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0004880C File Offset: 0x00046A0C
		internal void method_506(bool bool_168)
		{
			this.bool_152 = bool_168;
			this.gclass40_0.bool_26 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00048834 File Offset: 0x00046A34
		internal void method_507(bool bool_168)
		{
			this.method_317(bool_168);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00048848 File Offset: 0x00046A48
		internal void method_508()
		{
			this.method_417();
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0004885C File Offset: 0x00046A5C
		internal static void smethod_58(List<GClass84.GStruct172> list_30)
		{
			GClass145.smethod_38(list_30);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00048870 File Offset: 0x00046A70
		internal void method_509(bool bool_168)
		{
			this.method_244(bool_168);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00048884 File Offset: 0x00046A84
		internal void method_510(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170)
		{
			this.method_291(transform_0, string_3, consoleColor_0, bool_168, bool_169, bool_170);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000488A8 File Offset: 0x00046AA8
		internal void method_511(bool bool_168)
		{
			this.bool_65 = bool_168;
			this.gclass40_0.bool_52 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000488D0 File Offset: 0x00046AD0
		internal void method_512(bool bool_168)
		{
			this.method_172(bool_168);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000488E4 File Offset: 0x00046AE4
		internal void method_513(bool bool_168)
		{
			this.method_152(bool_168);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000488F8 File Offset: 0x00046AF8
		internal void method_514(bool bool_168)
		{
			this.bool_41 = bool_168;
			this.gclass40_0.bool_29 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00048920 File Offset: 0x00046B20
		internal void method_515(bool bool_168)
		{
			this.method_548(bool_168);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00048934 File Offset: 0x00046B34
		internal void method_516(bool bool_168)
		{
			this.bool_125 = bool_168;
			this.gclass40_0.bool_100 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0004895C File Offset: 0x00046B5C
		private static IntPtr smethod_59(IntPtr intptr_2, Vector3 vector3_0, Quaternion quaternion_0, byte byte_0, byte byte_1, byte byte_2, IntPtr intptr_3, GClass145.Delegate11 delegate11_0)
		{
			IntPtr result;
			try
			{
				if (intptr_2 == IntPtr.Zero)
				{
					result = intptr_2;
				}
				else
				{
					Object @object = new Object(intptr_2);
					if (!GClass196.smethod_0(@object, vector3_0, quaternion_0, byte_0 == 1, byte_1 == 1, byte_2 == 1))
					{
						result = IntPtr.Zero;
					}
					else
					{
						IntPtr intPtr = delegate11_0(intptr_2, vector3_0, quaternion_0, byte_0, byte_1, byte_2, intptr_3);
						Object object2 = new Object(intPtr);
						GClass84.gclass93_0.method_162(object2);
						GClass191.smethod_0(ref @object, vector3_0, quaternion_0, byte_0 == 1, byte_1 == 1, byte_2 == 1, ref object2);
						if (intPtr == IntPtr.Zero)
						{
							result = intPtr;
						}
						else
						{
							GameObject gameObject = object2.TryCast<GameObject>();
							if (intptr_2 == IntPtr.Zero || (GClass145.Struct8.vrcavatarManager_0 == null && !GClass84.gclass145_0.bool_12 && !GClass84.gclass145_0.bool_13))
							{
								result = intPtr;
							}
							else
							{
								GameObject gameObject2 = @object.TryCast<GameObject>();
								if (gameObject2 == null)
								{
									result = intPtr;
								}
								else
								{
									string text = GClass84.smethod_1324(gameObject);
									if (GClass145.Struct8.vrcavatarManager_0 != null && (!GClass84.gclass145_0.bool_13 || text != "AvatarUiPrefab2(Clone)"))
									{
										VRCAvatarManager vrcavatarManager_ = GClass145.Struct8.vrcavatarManager_0;
										VRCPlayer field_Private_VRCPlayer_ = vrcavatarManager_.field_Private_VRCPlayer_0;
										if (field_Private_VRCPlayer_ == null)
										{
											return intPtr;
										}
									}
									try
									{
										if (text == "AvatarPrefab(Clone)" || (GClass84.smethod_1428(text, GClass84.smethod_593("prefab-id-")) == "prefab-id-" && GClass84.smethod_1611(text, "_avtr_") != -1) || text == "_CustomAvatar(Clone)")
										{
											GClass90.smethod_0(GClass145.Struct8.vrcavatarManager_0, gameObject, GClass145.Struct8.vrcavatarManager_0 == null, null);
										}
									}
									catch (Exception ex)
									{
										string[] array = new string[9];
										array[0] = "Exception";
										array[1] = " ";
										array[2] = "when";
										array[3] = " ";
										array[4] = "cleaning";
										array[5] = " ";
										array[6] = "avatar";
										array[7] = ": ";
										int num = 8;
										Exception ex2 = ex;
										array[num] = ((ex2 != null) ? ex2.ToString() : null);
										GClass145.smethod_2(string.Concat(array));
									}
									result = intPtr;
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				string[] array2 = new string[9];
				array2[0] = "Exception";
				array2[1] = " ";
				array2[2] = "while";
				array2[3] = " ";
				array2[4] = "instantiating";
				array2[5] = " ";
				array2[6] = "object";
				array2[7] = ": ";
				int num2 = 8;
				Exception ex4 = ex3;
				array2[num2] = ((ex4 != null) ? ex4.ToString() : null);
				GClass145.smethod_2(string.Concat(array2));
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00048C2C File Offset: 0x00046E2C
		internal void method_517()
		{
			this.method_312();
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00048C40 File Offset: 0x00046E40
		public override void vmethod_18()
		{
			this.method_495();
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00048C54 File Offset: 0x00046E54
		internal void method_518(bool bool_168)
		{
			this.bool_109 = bool_168;
			this.gclass40_0.bool_88 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00048C7C File Offset: 0x00046E7C
		internal void method_519(bool bool_168)
		{
			this.method_218(bool_168);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00048C90 File Offset: 0x00046E90
		internal bool method_520(Transform transform_0, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, bool bool_170 = false, Transform transform_1 = null)
		{
			bool result;
			if (!transform_0)
			{
				result = false;
			}
			else
			{
				if (this.bool_10)
				{
					string str = ": LimitPosition();";
					if (this.bool_11)
					{
						GClass145.smethod_14(new List<GClass84.GStruct172>
						{
							new GClass84.GStruct172(consoleColor_0, string_3),
							new GClass84.GStruct172(ConsoleColor.DarkGray, str)
						});
					}
					else
					{
						GClass145.smethod_22(string_3 + str);
					}
				}
				Transform[] array = GClass84.smethod_1519(transform_0);
				bool flag = false;
				for (int i = array.Length - 1; i >= 0; i--)
				{
					Vector3 position = array[i].position;
					bool flag2 = false;
					if (float.IsNaN(position.x) || float.IsInfinity(position.x))
					{
						position.x = 0f;
						flag2 = true;
					}
					else if (position.x > this.float_0)
					{
						position.x = this.float_0;
						flag2 = true;
					}
					else if (position.x < -this.float_0)
					{
						position.x = -this.float_0;
						flag2 = true;
					}
					if (float.IsNaN(position.y) || float.IsInfinity(position.y))
					{
						position.y = 0f;
						flag2 = true;
					}
					else if (position.y > this.float_0)
					{
						position.y = this.float_0;
						flag2 = true;
					}
					else if (position.y < -this.float_0)
					{
						position.y = -this.float_0;
						flag2 = true;
					}
					if (float.IsNaN(position.z) || float.IsInfinity(position.z))
					{
						position.z = 0f;
						flag2 = true;
					}
					else if (position.z > this.float_0)
					{
						position.z = this.float_0;
						flag2 = true;
					}
					else if (position.z < -this.float_0)
					{
						position.z = -this.float_0;
						flag2 = true;
					}
					if (flag2)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Position",
							" ",
							array[i].position.ToString(),
							". ",
							"Limited",
							" ",
							"To",
							" ",
							position.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(consoleColor_0, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						array[i].position = position;
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00048FA0 File Offset: 0x000471A0
		private void method_521(DynamicBone dynamicBone_0, string string_3, ConsoleColor consoleColor_0, bool bool_168 = false)
		{
			this.method_397(dynamicBone_0, string_3, consoleColor_0, bool_168);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00048FBC File Offset: 0x000471BC
		private void method_522(float float_17)
		{
			this.method_477(float_17);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00048FD0 File Offset: 0x000471D0
		internal void method_523(bool bool_168)
		{
			this.method_71(bool_168);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00048FE4 File Offset: 0x000471E4
		internal void method_524(bool bool_168)
		{
			this.bool_8 = bool_168;
			this.gclass40_0.bool_7 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0004900C File Offset: 0x0004720C
		internal void method_525(bool bool_168)
		{
			this.method_142(bool_168);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00049020 File Offset: 0x00047220
		internal void method_526()
		{
			this.method_419();
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00049034 File Offset: 0x00047234
		internal void method_527(bool bool_168)
		{
			this.bool_3 = bool_168;
			this.gclass40_0.bool_4 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0004905C File Offset: 0x0004725C
		internal void method_528(bool bool_168)
		{
			this.method_384(bool_168);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00049070 File Offset: 0x00047270
		private void method_529(Transform transform_0, List<Transform> list_30, string string_3, ConsoleColor consoleColor_0, bool bool_168, bool bool_169, VRCPlayerApi vrcplayerApi_0, Transform transform_1)
		{
			if (transform_0)
			{
				if (vrcplayerApi_0 != null && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_219(), GClass84.smethod_538(vrcplayerApi_0), ""))
				{
					this.method_440(transform_0, true);
					for (int i = list_30.Count - 1; i >= 0; i--)
					{
						this.method_440(list_30[i], true);
					}
				}
				else
				{
					PipelineManager component = transform_0.GetComponent<PipelineManager>();
					if (component && GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_138(), component.blueprintId, ""))
					{
						this.method_440(transform_0, true);
						for (int j = list_30.Count - 1; j >= 0; j--)
						{
							this.method_440(list_30[j], true);
						}
					}
					else
					{
						this.int_47 = 0;
						if (!this.bool_15)
						{
							if (this.bool_118 && ((!this.bool_119 || !bool_168) && (!this.bool_120 || !bool_169)))
							{
								try
								{
									this.method_491(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
									for (int k = list_30.Count - 1; k >= 0; k--)
									{
										this.method_491(list_30[k], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								catch (Exception ex)
								{
									GClass145.smethod_2("[Error]" + " " + ex.Message);
								}
							}
							if (this.bool_96 && ((!this.bool_97 || !bool_168) && (!this.bool_98 || !bool_169)))
							{
								try
								{
									this.method_330(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
									for (int l = list_30.Count - 1; l >= 0; l--)
									{
										this.method_330(list_30[l], string_3, consoleColor_0, bool_168, bool_169, false, false);
									}
								}
								catch (Exception ex2)
								{
									GClass145.smethod_2("[Error]" + " " + ex2.Message);
								}
							}
							if (this.bool_125 && ((!this.bool_126 || !bool_168) && (!this.bool_127 || !bool_169)))
							{
								try
								{
									this.method_94(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
									for (int m = list_30.Count - 1; m >= 0; m--)
									{
										this.method_94(list_30[m], string_3, consoleColor_0, bool_168, bool_169, false, false);
									}
								}
								catch (Exception ex3)
								{
									GClass145.smethod_2("[Error]" + " " + ex3.Message);
								}
							}
							if (this.bool_132 && ((!this.bool_133 || !bool_168) && (!this.bool_134 || !bool_169)))
							{
								try
								{
									this.method_129(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, false);
									for (int n = list_30.Count - 1; n >= 0; n--)
									{
										this.method_129(list_30[n], string_3, consoleColor_0, bool_168, bool_169, false, false);
									}
								}
								catch (Exception ex4)
								{
									GClass145.smethod_2("[Error]" + " " + ex4.Message);
								}
							}
							if (this.bool_101 && ((!this.bool_102 || !bool_168) && (!this.bool_103 || !bool_169)))
							{
								try
								{
									this.method_462(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
									for (int num = list_30.Count - 1; num >= 0; num--)
									{
										this.method_462(list_30[num], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								catch (Exception ex5)
								{
									GClass145.smethod_2("[Error]" + " " + ex5.Message);
								}
							}
							if (this.bool_106 && ((!this.bool_107 || !bool_168) && (!this.bool_108 || !bool_169)))
							{
								try
								{
									this.method_498(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
									for (int num2 = list_30.Count - 1; num2 >= 0; num2--)
									{
										this.method_498(list_30[num2], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								catch (Exception ex6)
								{
									GClass145.smethod_2("[Error]" + " " + ex6.Message);
								}
							}
							if (this.bool_111 && ((!this.bool_112 || !bool_168) && (!this.bool_113 || !bool_169)))
							{
								try
								{
									this.method_273(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
									for (int num3 = list_30.Count - 1; num3 >= 0; num3--)
									{
										this.method_273(list_30[num3], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								catch (Exception ex7)
								{
									GClass145.smethod_2("[Error]" + " " + ex7.Message);
								}
							}
							if (this.bool_67 && ((!this.bool_68 || !bool_168) && (!this.bool_69 || !bool_169)))
							{
								try
								{
									this.method_135(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, null);
									for (int num4 = list_30.Count - 1; num4 >= 0; num4--)
									{
										this.method_135(list_30[num4], string_3, consoleColor_0, bool_168, bool_169, false, true, null);
									}
								}
								catch (Exception ex8)
								{
									GClass145.smethod_2("[Error]" + " " + ex8.Message);
								}
							}
							if (this.bool_73 && ((!this.bool_74 || !bool_168) && (!this.bool_75 || !bool_169)))
							{
								try
								{
									this.method_167(transform_0, string_3, consoleColor_0, bool_168, bool_169, true);
									for (int num5 = list_30.Count - 1; num5 >= 0; num5--)
									{
										this.method_167(list_30[num5], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								catch (Exception ex9)
								{
									GClass145.smethod_2("[Error]" + " " + ex9.Message);
								}
							}
						}
						if (this.bool_87 && ((!this.bool_90 || !bool_168) && (!this.bool_91 || !bool_169)))
						{
							try
							{
								this.method_328(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, transform_1);
							}
							catch (Exception ex10)
							{
								GClass145.smethod_2("[Error]" + " " + ex10.Message);
							}
							for (int num6 = list_30.Count - 1; num6 >= 0; num6--)
							{
								try
								{
									this.method_328(list_30[num6], string_3, consoleColor_0, bool_168, bool_169, false, true, transform_1);
								}
								catch (Exception ex11)
								{
									GClass145.smethod_2("[Error]" + " " + ex11.Message);
								}
							}
						}
						if (this.bool_41)
						{
							if (this.bool_46)
							{
								this.list_3.Add(new GClass145.Struct4(transform_0, list_30, string_3, consoleColor_0, bool_168, bool_169, transform_1, this.int_47));
								this.method_176(transform_0);
								for (int num7 = list_30.Count - 1; num7 >= 0; num7--)
								{
									this.method_176(list_30[num7]);
								}
								return;
							}
							if ((!this.bool_42 || !bool_168) && (!this.bool_43 || !bool_169))
							{
								this.bool_156 = true;
								this.int_50 = 0;
								List<string> list;
								try
								{
									list = this.method_201(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, null, false, null, true, transform_1);
								}
								catch (Exception ex12)
								{
									list = new List<string>();
									GClass145.smethod_2("[Error]" + " " + ex12.Message);
								}
								this.method_340(this.list_17);
								this.method_539(this.list_19);
								if (list.Count > 0)
								{
									List<GameObject> list2 = new List<GameObject>();
									for (int num8 = list_30.Count - 1; num8 >= 0; num8--)
									{
										for (int num9 = list.Count - 1; num9 >= 0; num9--)
										{
											GameObject gameObject = GClass84.smethod_351(list_30[num8], list[num9]);
											if (gameObject)
											{
												list2.Add(gameObject);
											}
										}
									}
									if (list2.Count > 0)
									{
										this.method_283(list2, true);
										list2.Clear();
									}
									list.Clear();
								}
							}
						}
						if (this.bool_30 && ((!this.bool_34 || !bool_168) && (!this.bool_35 || !bool_169)))
						{
							this.method_340(this.list_17);
							this.method_539(this.list_19);
							try
							{
								if (this.method_457(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, transform_1))
								{
									for (int num10 = list_30.Count - 1; num10 >= 0; num10--)
									{
										this.method_457(list_30[num10], string_3, consoleColor_0, bool_168, bool_169, false, true, transform_1);
									}
								}
							}
							catch (Exception ex13)
							{
								GClass145.smethod_2("[Error]" + " " + ex13.Message);
							}
						}
						if (this.bool_139)
						{
							if ((this.bool_137 && bool_168) || (this.bool_138 && bool_169))
							{
								goto IL_AC1;
							}
							try
							{
								if (this.method_70(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num11 = list_30.Count - 1; num11 >= 0; num11--)
									{
										this.method_70(list_30[num11], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								goto IL_AC1;
							}
							catch (Exception ex14)
							{
								GClass145.smethod_2("[Error]" + " " + ex14.Message);
								goto IL_AC1;
							}
						}
						if (this.bool_141)
						{
							if ((this.bool_137 && bool_168) || (this.bool_138 && bool_169))
							{
								goto IL_AC1;
							}
							try
							{
								if (this.method_87(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num12 = list_30.Count - 1; num12 >= 0; num12--)
									{
										this.method_87(list_30[num12], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
								goto IL_AC1;
							}
							catch (Exception ex15)
							{
								GClass145.smethod_2("[Error]" + " " + ex15.Message);
								goto IL_AC1;
							}
						}
						if (this.bool_146 && ((!this.bool_137 || !bool_168) && (!this.bool_138 || !bool_169)))
						{
							try
							{
								if (this.method_502(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num13 = list_30.Count - 1; num13 >= 0; num13--)
									{
										this.method_502(list_30[num13], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
							}
							catch (Exception ex16)
							{
								GClass145.smethod_2("[Error]" + " " + ex16.Message);
							}
						}
						IL_AC1:
						if (this.bool_51 && ((!this.bool_52 || !bool_168) && (!this.bool_53 || !bool_169)))
						{
							try
							{
								if (this.method_406(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num14 = list_30.Count - 1; num14 >= 0; num14--)
									{
										this.method_406(list_30[num14], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
							}
							catch (Exception ex17)
							{
								GClass145.smethod_2("[Error]" + " " + ex17.Message);
							}
						}
						if (this.bool_56 && ((!this.bool_57 || !bool_168) && (!this.bool_58 || !bool_169)))
						{
							try
							{
								if (this.method_25(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num15 = list_30.Count - 1; num15 >= 0; num15--)
									{
										this.method_25(list_30[num15], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
							}
							catch (Exception ex18)
							{
								GClass145.smethod_2("[Error]" + " " + ex18.Message);
							}
						}
						if (this.bool_61 && ((!this.bool_62 || !bool_168) && (!this.bool_63 || !bool_169)))
						{
							try
							{
								if (this.method_233(transform_0, string_3, consoleColor_0, bool_168, bool_169, true))
								{
									for (int num16 = list_30.Count - 1; num16 >= 0; num16--)
									{
										this.method_233(list_30[num16], string_3, consoleColor_0, bool_168, bool_169, false);
									}
								}
							}
							catch (Exception ex19)
							{
								GClass145.smethod_2("[Error]" + " " + ex19.Message);
							}
						}
						if (this.bool_78 && ((!this.bool_79 || !bool_168) && (!this.bool_80 || !bool_169)))
						{
							List<string> list3;
							try
							{
								list3 = this.method_45(transform_0, string_3, consoleColor_0, bool_168, bool_169, true, true, null, false, null, null);
							}
							catch (Exception ex20)
							{
								list3 = new List<string>();
								GClass145.smethod_2("[Error]" + " " + ex20.Message);
							}
							if (list3.Count > 0)
							{
								for (int num17 = list_30.Count - 1; num17 >= 0; num17--)
								{
									for (int num18 = list3.Count - 1; num18 >= 0; num18--)
									{
										GameObject gameObject2 = GClass84.smethod_351(list_30[num17], list3[num18]);
										if (gameObject2)
										{
											Object.DestroyImmediate(gameObject2, true);
										}
									}
								}
								list3.Clear();
							}
						}
						if (this.int_47 >= this.int_46)
						{
							string str = string.Concat(new string[]
							{
								": ",
								"Log",
								" ",
								"Was",
								" ",
								"Limited",
								" ",
								"By",
								" ",
								this.int_47.ToString(),
								" ",
								"Lines"
							});
							if (this.bool_11)
							{
								GClass145.smethod_14(new List<GClass84.GStruct172>
								{
									new GClass84.GStruct172(consoleColor_0, string_3),
									new GClass84.GStruct172(ConsoleColor.DarkGray, str)
								});
							}
							else
							{
								GClass145.smethod_22(string_3 + str);
							}
							this.int_47++;
						}
						this.list_18.Clear();
						this.list_20.Clear();
						this.method_176(transform_0);
						for (int num19 = list_30.Count - 1; num19 >= 0; num19--)
						{
							this.method_176(list_30[num19]);
						}
					}
				}
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00049FEC File Offset: 0x000481EC
		private void method_530()
		{
			this.method_450();
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0004A000 File Offset: 0x00048200
		internal void method_531(GameObject gameObject_0, bool bool_168)
		{
			if (gameObject_0)
			{
				this.method_176((gameObject_0 != null) ? gameObject_0.transform : null);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0004A02C File Offset: 0x0004822C
		private void method_532()
		{
			this.method_144();
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0004A040 File Offset: 0x00048240
		internal void method_533(bool bool_168)
		{
			this.method_170(bool_168);
		}

		// Token: 0x06000DFC RID: 3580
		[DllImport("kernel32.dll", EntryPoint = "VirtualProtect", SetLastError = true)]
		internal static extern bool VirtualProtect_1(IntPtr intptr_2, uint uint_0, uint uint_1, out uint uint_2);

		// Token: 0x06000DFD RID: 3581 RVA: 0x0004A054 File Offset: 0x00048254
		internal void method_534(bool bool_168)
		{
			this.method_463(bool_168);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0004A068 File Offset: 0x00048268
		private GClass145.Struct3 method_535(GClass145.Struct3 struct3_0)
		{
			GClass145.Struct3 result;
			if (struct3_0.bool_3)
			{
				result = struct3_0;
			}
			else
			{
				this.int_47 = struct3_0.int_1;
				if (struct3_0.int_0 == 0)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if ((!this.bool_42 || !struct3_0.bool_0) && (!this.bool_43 || !struct3_0.bool_1))
					{
						this.list_18.AddRange(struct3_0.list_0);
						this.list_20.AddRange(struct3_0.list_1);
						try
						{
							this.method_201(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2, false, null, false, null, true, struct3_0.transform_1);
						}
						catch (Exception ex)
						{
							GClass145.smethod_2("[Error]" + " " + ex.Message);
						}
						this.method_340(this.list_17);
						struct3_0.list_0.Clear();
						struct3_0.list_0.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct3_0.list_1.Clear();
						struct3_0.list_1.AddRange(this.list_20);
						this.list_20.Clear();
					}
					struct3_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct3_0.int_0++;
					}
				}
				else if (struct3_0.int_0 == 1)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if ((!this.bool_42 || !struct3_0.bool_0) && (!this.bool_43 || !struct3_0.bool_1))
					{
						this.list_18.AddRange(struct3_0.list_0);
						this.list_20.AddRange(struct3_0.list_1);
						try
						{
							this.method_331(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2, false, null, false, null, struct3_0.transform_1);
						}
						catch (Exception ex2)
						{
							GClass145.smethod_2("[Error]" + " " + ex2.Message);
						}
						this.method_340(this.list_17);
						struct3_0.list_0.Clear();
						struct3_0.list_0.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct3_0.list_1.Clear();
						struct3_0.list_1.AddRange(this.list_20);
						this.list_20.Clear();
					}
					struct3_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct3_0.int_0++;
					}
				}
				else if (struct3_0.int_0 == 2)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					if (this.bool_48 && ((!this.bool_42 || !struct3_0.bool_0) && (!this.bool_43 || !struct3_0.bool_1)))
					{
						this.list_18.AddRange(struct3_0.list_0);
						this.list_20.AddRange(struct3_0.list_1);
						try
						{
							this.method_60(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2, false, null, struct3_0.transform_1);
						}
						catch (Exception ex3)
						{
							GClass145.smethod_2("[Error]" + " " + ex3.Message);
						}
						this.method_340(this.list_17);
						struct3_0.list_0.Clear();
						struct3_0.list_0.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct3_0.list_1.Clear();
						struct3_0.list_1.AddRange(this.list_20);
						this.list_20.Clear();
					}
					struct3_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct3_0.int_0++;
					}
				}
				else if (struct3_0.int_0 == 3)
				{
					if (this.bool_30 && ((!this.bool_34 || !struct3_0.bool_0) && (!this.bool_35 || !struct3_0.bool_1)))
					{
						this.list_18.AddRange(struct3_0.list_0);
						this.list_20.AddRange(struct3_0.list_1);
						try
						{
							this.method_457(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2, true, struct3_0.transform_1);
						}
						catch (Exception ex4)
						{
							GClass145.smethod_2("[Error]" + " " + ex4.Message);
						}
						this.method_340(this.list_17);
						struct3_0.list_0.Clear();
						struct3_0.list_0.AddRange(this.list_18);
						this.list_18.Clear();
						this.method_539(this.list_19);
						struct3_0.list_1.Clear();
						struct3_0.list_1.AddRange(this.list_20);
						this.list_20.Clear();
					}
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				else if (struct3_0.int_0 == 4)
				{
					if (this.bool_139)
					{
						if ((this.bool_137 && struct3_0.bool_0) || (this.bool_138 && struct3_0.bool_1))
						{
							goto IL_6E7;
						}
						try
						{
							this.method_70(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
							goto IL_6E7;
						}
						catch (Exception ex5)
						{
							GClass145.smethod_2("[Error]" + " " + ex5.Message);
							goto IL_6E7;
						}
					}
					if (this.bool_141)
					{
						if ((this.bool_137 && struct3_0.bool_0) || (this.bool_138 && struct3_0.bool_1))
						{
							goto IL_6E7;
						}
						try
						{
							this.method_87(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
							goto IL_6E7;
						}
						catch (Exception ex6)
						{
							GClass145.smethod_2("[Error]" + " " + ex6.Message);
							goto IL_6E7;
						}
					}
					if (this.bool_146 && ((!this.bool_137 || !struct3_0.bool_0) && (!this.bool_138 || !struct3_0.bool_1)))
					{
						try
						{
							this.method_502(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
						}
						catch (Exception ex7)
						{
							GClass145.smethod_2("[Error]" + " " + ex7.Message);
						}
					}
					IL_6E7:
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				else if (struct3_0.int_0 == 5)
				{
					if (this.bool_51 && ((!this.bool_52 || !struct3_0.bool_0) && (!this.bool_53 || !struct3_0.bool_1)))
					{
						try
						{
							this.method_406(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
						}
						catch (Exception ex8)
						{
							GClass145.smethod_2("[Error]" + " " + ex8.Message);
						}
					}
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				else if (struct3_0.int_0 == 6)
				{
					this.bool_156 = true;
					this.int_50 = 0;
					struct3_0.int_1 = this.int_47;
					if (this.bool_156)
					{
						struct3_0.int_0++;
					}
				}
				else if (struct3_0.int_0 == 7)
				{
					if (this.bool_56 && ((!this.bool_57 || !struct3_0.bool_0) && (!this.bool_58 || !struct3_0.bool_1)))
					{
						try
						{
							this.method_25(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
						}
						catch (Exception ex9)
						{
							GClass145.smethod_2("[Error]" + " " + ex9.Message);
						}
					}
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				else if (struct3_0.int_0 == 8)
				{
					if (this.bool_61 && ((!this.bool_62 || !struct3_0.bool_0) && (!this.bool_63 || !struct3_0.bool_1)))
					{
						try
						{
							this.method_233(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2);
						}
						catch (Exception ex10)
						{
							GClass145.smethod_2("[Error]" + " " + ex10.Message);
						}
					}
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				else if (struct3_0.int_0 == 9)
				{
					if (this.bool_78 && ((!this.bool_79 || !struct3_0.bool_0) && (!this.bool_80 || !struct3_0.bool_1)))
					{
						try
						{
							this.method_45(struct3_0.transform_0, struct3_0.string_0, struct3_0.consoleColor_0, struct3_0.bool_0, struct3_0.bool_1, struct3_0.bool_2, false, null, false, null, null);
						}
						catch (Exception ex11)
						{
							GClass145.smethod_2("[Error]" + " " + ex11.Message);
						}
					}
					struct3_0.int_1 = this.int_47;
					struct3_0.int_0++;
				}
				if (struct3_0.int_0 == 10)
				{
					if (this.int_47 >= this.int_46)
					{
						string str = string.Concat(new string[]
						{
							": ",
							"Log",
							" ",
							"Was",
							" ",
							"Limited",
							" ",
							"By",
							" ",
							this.int_47.ToString(),
							" ",
							"Lines"
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(struct3_0.consoleColor_0, struct3_0.string_0),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str)
							});
						}
						else
						{
							GClass145.smethod_22(struct3_0.string_0 + str);
						}
						this.int_47++;
					}
					struct3_0.bool_3 = true;
				}
				result = struct3_0;
			}
			return result;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0004ABF0 File Offset: 0x00048DF0
		internal void method_536(bool bool_168)
		{
			this.method_149(bool_168);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0004AC04 File Offset: 0x00048E04
		internal void method_537(Transform transform_0, string string_3)
		{
			this.method_120(transform_0, string_3);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0004AC1C File Offset: 0x00048E1C
		internal void method_538(bool bool_168)
		{
			this.method_347(bool_168);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0004AC30 File Offset: 0x00048E30
		private static bool smethod_60(ApiAvatar apiAvatar_0)
		{
			if (GClass145.bool_165)
			{
				if (apiAvatar_0 != null)
				{
					GClass145.smethod_22("VRCAvatarManager_Public_ApiAvatar" + ": " + apiAvatar_0.id);
				}
				else
				{
					GClass145.smethod_22("VRCAvatarManager_Public_ApiAvatar()");
				}
			}
			return !GClass84.gclass145_0.bool_163 && (apiAvatar_0 == null || (!GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_482(), apiAvatar_0.authorId, "") && !GClass145.GStruct102.smethod_2(GClass84.gclass145_0.method_469(), apiAvatar_0.id, "")));
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004ACC8 File Offset: 0x00048EC8
		internal void method_539(List<GClass84.GStruct146> list_30)
		{
			this.method_190(list_30);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004ACDC File Offset: 0x00048EDC
		internal void method_540(bool bool_168)
		{
			this.method_81(bool_168);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004ACF0 File Offset: 0x00048EF0
		internal void method_541(bool bool_168)
		{
			this.method_12(bool_168);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004AD04 File Offset: 0x00048F04
		internal void method_542()
		{
			this.method_435();
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004AD18 File Offset: 0x00048F18
		internal void method_543(bool bool_168)
		{
			this.bool_4 = bool_168;
			this.gclass40_0.bool_5 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0004AD40 File Offset: 0x00048F40
		private static void smethod_61(ref bool bool_168)
		{
			GClass145.smethod_51(ref bool_168);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0004AD54 File Offset: 0x00048F54
		internal void method_544(bool bool_168)
		{
			this.method_501(bool_168);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0004AD68 File Offset: 0x00048F68
		internal void method_545(bool bool_168)
		{
			this.method_205(bool_168);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0004AD7C File Offset: 0x00048F7C
		internal void method_546(bool bool_168)
		{
			this.bool_115 = bool_168;
			this.gclass40_0.bool_94 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0004ADA4 File Offset: 0x00048FA4
		internal void method_547(bool bool_168)
		{
			this.method_43(bool_168);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0004ADB8 File Offset: 0x00048FB8
		internal void method_548(bool bool_168)
		{
			this.method_341(bool_168);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0004ADCC File Offset: 0x00048FCC
		internal void method_549(bool bool_168)
		{
			this.method_306(bool_168);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0004ADE0 File Offset: 0x00048FE0
		internal void method_550(Transform transform_0, string string_3)
		{
			if (this.bool_10)
			{
				string str = ": CheckForSpringJointCrash();";
				if (this.bool_11)
				{
					GClass145.smethod_14(new List<GClass84.GStruct172>
					{
						new GClass84.GStruct172(GClass84.smethod_1571(null, true), string_3),
						new GClass84.GStruct172(ConsoleColor.DarkGray, str)
					});
				}
				else
				{
					GClass145.smethod_22(string_3 + str);
				}
			}
			if (transform_0)
			{
				SpringJoint[] array = transform_0.GetComponentsInChildren<SpringJoint>(true);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					if (array[i].spring > 1000f)
					{
						string str2 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Spring",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].spring.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str2)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str2);
						}
						array[i].spring = 1000f;
					}
					if (array[i].damper > 1000f)
					{
						string str3 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Damper",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].damper.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str3)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str3);
						}
						array[i].damper = 1000f;
					}
					if (array[i].minDistance > 1000f)
					{
						string str4 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Min",
							" ",
							"Distance",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].minDistance.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str4)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str4);
						}
						array[i].minDistance = 1000f;
					}
					if (array[i].maxDistance > 1000f)
					{
						string str5 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Max",
							" ",
							"Distance",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].maxDistance.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str5)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str5);
						}
						array[i].maxDistance = 1000f;
					}
					if (array[i].tolerance > 1000f)
					{
						string str6 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Tolerance",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].tolerance.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str6)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str6);
						}
						array[i].tolerance = 1000f;
					}
					if (array[i].connectedMassScale > 1000f)
					{
						string str7 = string.Concat(new string[]
						{
							": ",
							array[i].name,
							" ",
							"Had",
							" ",
							"Too",
							" ",
							"Big",
							" ",
							"Connected",
							" ",
							"Mass",
							" ",
							"Scale",
							" ",
							"Of",
							" ",
							"Spring",
							" ",
							"Joint",
							" (",
							array[i].connectedMassScale.ToString(),
							"). ",
							"Decreased",
							" ",
							"To",
							" ",
							1000.ToString()
						});
						if (this.bool_11)
						{
							GClass145.smethod_14(new List<GClass84.GStruct172>
							{
								new GClass84.GStruct172(ConsoleColor.DarkRed, string_3),
								new GClass84.GStruct172(ConsoleColor.DarkGray, str7)
							});
						}
						else
						{
							GClass145.smethod_22(string_3 + str7);
						}
						array[i].connectedMassScale = 1000f;
					}
				}
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0004B6AC File Offset: 0x000498AC
		private unsafe static void smethod_62(IntPtr intptr_2, float* pFloat_0, byte* pByte_0)
		{
			GClass145.smethod_49(intptr_2, pFloat_0, pByte_0);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0004B6C4 File Offset: 0x000498C4
		internal void method_551()
		{
			this.list_9.Clear();
			this.list_9.AddRange(new string[]
			{
				"Laptop's Convection Glow",
				"Standard",
				"Standard (Specular setup)",
				"#Milku/ToonV2",
				".poiyomi/• Poiyomi Toon •",
				".poiyomi/★ Poiyomi Pro ★",
				".poiyomi/Patreon/Dissolve",
				".poiyomi/Patreon/EyeFx",
				".poiyomi/Patreon/Particle2/Cutout",
				".poiyomi/Patreon/Particle2/Transparent",
				".poiyomi/Patreon/ShatterWave2",
				".poiyomi/Patreon/Slime",
				".poiyomi/Patreon/Standard/Cutout",
				".poiyomi/Pro/Cutout",
				".poiyomi/Pro/Opaque",
				".poiyomi/Pro/Outlines Cutout",
				".poiyomi/Pro/Transparent",
				".poiyomi/Toon/Advanced/Cutout",
				".poiyomi/Toon/Advanced/Opaque",
				".poiyomi/Toon/Advanced/Outlines Cutout",
				".poiyomi/Toon/Advanced/Outlines Transparent",
				".poiyomi/Toon/Advanced/Transparent",
				".poiyomi/Toon/Cutout",
				".poiyomi/Toon/Default/Cutout",
				".poiyomi/Toon/Default/Opaque",
				".poiyomi/Toon/Default/outlines Cutout",
				".poiyomi/Toon/Default/outlines Transparent",
				".poiyomi/Toon/Default/Transparent",
				".poiyomi/Toon/Extras/Cutout",
				".poiyomi/Toon/Opaque",
				".poiyomi/Toon/OutlineOpaque",
				".poiyomi/Toon/Outlines Cutout",
				".poiyomi/Toon/Simple/Cutout",
				".poiyomi/Toon/Simple/Transparent",
				".poiyomi/Toon/Transparent",
				".poiyomi/Toon-2.0.2/opaque",
				".poiyomi/Toon-2.0.3/opaque",
				".poiyomi/Master/Default/Opaque",
				".poiyomi/Master/Opaque",
				".poiyomi/Master/Transparent",
				".Viridios./Rimlight",
				"_Unreal's Shaders/Custom/AddMul",
				"_Unreal's Shaders/Custom/AddMul_FixedMask",
				"_Unreal's Shaders/Custom/AniviaSmoke",
				"_Unreal's Shaders/ikita/Eye I found",
				"_Unreal's Shaders/ikita/Eye I found 3000",
				"_Unreal's Shaders/ikita/Freeze Frame",
				"_Unreal's Shaders/ikita/Glitch 3000",
				"_Unreal's Shaders/ikita/Glitch2",
				"_Unreal's Shaders/ikita/ikitas Toon",
				"_Unreal's Shaders/ikita/ikitas Toon Camo",
				"_Unreal's Shaders/ikita/ikita Metallic 2",
				"_Unreal's Shaders/ikita/Particle Additive HDR",
				"_Unreal's Shaders/ikita/Particle Fresnel 2",
				"_Unreal's Shaders/ikita/screenShake",
				"_Unreal's Shaders/MatCap/Vertex/Textured Multiply",
				"_Unreal's Shaders/Particle Dissolve/Additive",
				"_Unreal's Shaders/Particles/Additive Intensify",
				"_Unreal's Shaders/QFX/IFX/Cutout/AlphaBlendNoiseCutout",
				"_Unreal's Shaders/QFX/IFX/Cutout/CutoutAlignment",
				"_Unreal's Shaders/QFX/IFX/Cutout/GlowCutout",
				"_Unreal's Shaders/QFX/IFX/Cutout/GlowCutout_Hard",
				"_Unreal's Shaders/QFX/IFX/Cutout/GlowCutout_Soft",
				"_Unreal's Shaders/QFX/IFX/Distortion/SphereDistortion",
				"_Unreal's Shaders/QFX/IFX/Particle/Alpha Blended Soft Tex",
				"_Unreal's Shaders/QFX/IFX/Particle/Particle HDR",
				"_Unreal's Shaders/QFX/IFX/Particle/Particle HDR No Soft",
				"_Unreal's Shaders/QFX/IFX/Trail/Curve",
				"_Unreal's Shaders/QFX/SFX/Beam/Energy Beam",
				"_Unreal's Shaders/QFX/SFX/Mask/AdjustMask",
				"_Unreal's Shaders/QFX/SFX/Mask/AlphaBlendMask",
				"_Unreal's Shaders/QFX/SFX/Particle/Particle HDR",
				"_Unreal's Shaders/Shader Forge/cyberpunk",
				"_Unreal's Shaders/Shader Forge/screenShakeN",
				"_Unreal's Shaders/Sine VFX/MeshEnchantAlphaBlended",
				"_Unreal's Shaders/Sine VFX/V3DLasers/SmartWaveParticle",
				"_Unreal's Shaders/Slash/AnimBlended",
				"_Unreal's Shaders/Slash/BlendDistortionCutout",
				"_Unreal's Shaders/Unlit/Add",
				"_Unreal's Shaders/VacuumShaders/The Amazing Wireframe/Physically Based/Addative/ZWrite/Wire Only",
				"AdultLink/HoloShield",
				"arktoon/_Extra/EmissiveFreak/FadeRefracted",
				"arktoon/_Extra/EmissiveFreak/Opaque",
				"arktoon/AlphaCutout",
				"arktoon/Fade",
				"arktoon/FadeRefracted",
				"arktoon/Opaque",
				"Cartoon FX/Mobile Particles Additive Alpha8",
				"Cartoon FX/Particles Additive Alpha8",
				"Ciconia Studio/Double Sided/Emissive/Diffuse",
				"Corpse/Lazer v1.5",
				"Corpse/Uber Particle v1.5",
				"CubedParadox/Flat Lit Toon",
				"CubedParadox/Flat Lit Toon (Silent)",
				"CubedParadox/Flat Lit Toon 3000",
				"CubedParadox/Flat Lit Toon Distance Fade",
				"CubedParadox/Flat Lit Toon Lite",
				"CubedParadox/Flat Lit Toon Lite Cutout",
				"CubedParadox/Flat Lit Toon Lite Fade",
				"CubedParadox/Flat Lit Toon Lite Transparent",
				"CubedParadox/Unit Shadowed",
				"Custom/AddMul",
				"Custom/AddMul_FixedMask",
				"Custom/AniviaSmoke",
				"Custom/Avatar Shaders/Fur Shader (Advance)",
				"Custom/Avatar Shaders/Fur Shader (Simple)",
				"Custom/SurfaceShader_VC",
				"Decal/particle decalsilent",
				"Doppels shaders/Dope Toon Shader",
				"Doppels shaders/MetallicFX",
				"Doppels shaders/MetallicFX v5.0",
				"Doppels shaders/MetallicFX v5.11",
				"Effects/FPS_Pack/AlphaBlended",
				"ERB/Particles/Add_CenterGlow",
				"ERB/Particles/Blend_CenterGlow",
				"FX/Flare",
				"FX/Gem",
				"FX/Laser Beam Hard Edges",
				"Glomee/Sine VFX/StartSphereV2Rainbow",
				"Hidden/VacuumShaders/The Amazing Wireframe/Physically Based/Addative/ZWrite/Wire Only",
				"HOTATE/FakeBloom",
				"JetDog's Prefabs/sprite sheat",
				"ikita/Eye I found",
				"ikita/Eye I found 3000",
				"ikita/Freeze Frame",
				"ikita/Glitch 3000",
				"ikita/Glitch2",
				"ikita/ikitas Toon",
				"ikita/ikitas Toon Camo",
				"ikita/ikita Metallic 2",
				"ikita/Particle Additive HDR",
				"ikita/Particle Fresnel 2",
				"ikita/screenShake",
				"KriptoFX/ME/Particle",
				"KriptoFX/ME/Slime",
				"KriptoFX/RFX4/Decal/DistortMaskMobile",
				"KriptoFX/RFX4/DistortionParticles",
				"KriptoFX/RFX4/Lava",
				"KriptoFX/RFX4/Particle",
				"Legacy Shaders/Bumped Diffuse",
				"Legacy Shaders/Bumped Specular",
				"Legacy Shaders/Decal",
				"Legacy Shaders/Diffuse",
				"Legacy Shaders/Diffuse Detail",
				"Legacy Shaders/Particles/Additive",
				"Legacy Shaders/Particles/Additive (Soft)",
				"Legacy Shaders/Particles/Alpha Blended",
				"Legacy Shaders/Particles/Alpha Blended Premultiply",
				"Legacy Shaders/Particles/Multiply (Double)",
				"Legacy Shaders/Particles/VertexLit Blended",
				"Legacy Shaders/Self-Illumin/Bumped Diffuse",
				"Legacy Shaders/Self-Illumin/Diffuse",
				"Legacy Shaders/Self-Illumin/Specular",
				"Legacy Shaders/Transparent/Bumped Diffuse",
				"Legacy Shaders/Transparent/Cutout/Diffuse",
				"Legacy Shaders/Transparent/Cutout/Soft Edge Unlit",
				"Legacy Shaders/Transparent/Cutout/VertexLit",
				"Legacy Shaders/Transparent/Diffuse",
				"Legacy Shaders/Transparent/VertexLit",
				"MatCap/Vertex/Textured Lit",
				"MatCap/Vertex/Textured Multiply",
				"MK/Glow/Selective/Illumin/Diffuse",
				"MK/Glow/Selective/Transparent/Diffuse",
				"MMS3/Mnmrshader3",
				"MMS3/Mnmrshader3_Cutout",
				"MMS3/Mnmrshader3_Outline",
				"MMS3/Mnmrshader3_Transparent",
				"Mobile/Bumped Diffuse",
				"Mobile/Bumped Specular",
				"Mobile/Particles/Additive",
				"Mobile/Particles/Alpha Blended",
				"Mobile/Particles/Multiply",
				"Mobile/Unlit (Supports Lightmap)",
				"Mochie/Mochie's Toon Shader (Cutout)",
				"Neitri/Clock V1",
				"Neitri/Clock V2",
				"Neitri/Clock V3",
				"Neitri/Clock V4",
				"NEK0/AVA/ Normal Shader v1",
				"NoeNoe/NoeNoe Overlay Shader (Opaque)",
				"Okami/Dither RimLight",
				"Particle Dissolve/Additive",
				"Particles/Additive",
				"Particles/Additive (Soft)",
				"Particles/Additive Intensify",
				"Particles/AdditivePro",
				"Particles/Alpha Blended",
				"Particles/Alpha Blended Premultiply",
				"Particles/Multiply",
				"Particles/Priority Alpha Blended",
				"Particles/Standard Surface",
				"Particles/Standard Unlit",
				"Particles/VertexLit Blended",
				"poipoi/Master/Opaque",
				"poiyomi/NoeNoePoi",
				"QFX/IFX/Cutout/AlphaBlendNoiseCutout",
				"QFX/IFX/Cutout/CutoutAlignment",
				"QFX/IFX/Cutout/GlowCutout",
				"QFX/IFX/Cutout/GlowCutout_Hard",
				"QFX/IFX/Cutout/GlowCutout_Soft",
				"QFX/IFX/Distortion/SphereDistortion",
				"QFX/IFX/Particle/Alpha Blended Soft Tex",
				"QFX/IFX/Particle/Particle HDR",
				"QFX/IFX/Particle/Particle HDR No Soft",
				"QFX/IFX/Trail/Curve",
				"QFX/SFX/Beam/Energy Beam",
				"QFX/SFX/Mask/AdjustMask",
				"QFX/SFX/Mask/AlphaBlendMask",
				"QFX/SFX/Particle/Particle HDR",
				"Raliv/Orifice",
				"Raliv/Penetrator",
				"Rollthered/Fire",
				"Sci-Fi/SSFS/Base",
				"SFHologram/HologramShader",
				"Shader Forge/cyberpunk",
				"Shader Forge/cyberpunkv2",
				"Shader Forge/hair",
				"Shader Forge/screenShakeN",
				"Shader Fur/Xiexe_Fur",
				"ShaderMan/PlasmaGlobe",
				"Shinigami/VHS v1.2",
				"Sine VFX/MeshEnchantAlphaBlended",
				"Sine VFX/V3DLasers/SmartWaveParticle",
				"Slash/AnimBlended",
				"Slash/BlendDistortionCutout",
				"Snail/Marker",
				"Sprites/Default",
				"Sunao Shader/Cutout",
				"Sunao Shader/Opaque",
				"Sunao Shader/Transparent",
				"UI/Default",
				"UI/Unlit/Detail",
				"UI/Unlit/Transparent",
				"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather",
				"UnityChanToonShader/Toon_DoubleShadeWithFeather",
				"UnityChanToonShader/Toon_DoubleShadeWithFeather_TransClipping",
				"UnityChanToonShader/Toon_ShadingGradeMap_TransClipping",
				"Unlit/Add",
				"Unlit/Color",
				"Unlit/Texture",
				"Unlit/Transparent",
				"Unlit/Transparent Cutout",
				"VRChat/Mobile/Bumped Diffuse",
				"VRChat/Mobile/Bumped Mapped Specular",
				"VRChat/Mobile/Diffuse",
				"VRChat/Mobile/Lightmapped",
				"VRChat/Mobile/MatCap Lit",
				"VRChat/Mobile/Particles/Additive",
				"VRChat/Mobile/Particles/Alpha Blended",
				"VRChat/Mobile/Particles/Multiply",
				"VRChat/Mobile/Standard Lite",
				"VRChat/Mobile/Toon Lit",
				"VRChat/Panosphere",
				"VRChat/PanosphereV2",
				"VRChat/PC/Toon Lit",
				"VRChat/PC/Toon Lit Cutout",
				"VRChat/Sprites/Default",
				"VTS/AnalogClock",
				"WFX/Additive Alpha8",
				"WFX/Additive (Soft) Alpha8",
				"WFX/Multiply Soft Tint",
				"WFX/Scroll/Alpha Blended",
				"WFX/Scroll/Smoke",
				"Xiexe/Toon/XSToon",
				"Xiexe/Toon2.0/XSToon2.0",
				"Xiexe/Toon2.0/XSToon2.0_Cutout",
				"Xiexe/Toon2.0/XSToon2.0_Dithered",
				"Xiexe/Toon2.0/XSToon2.0_Fade",
				"Xiexe/Toon2.0/XSToon2.0_Orifice",
				"Xiexe/Toon2.0/XSToon2.0_Outlined",
				"Xiexe/Toon2.0/XSToon2.0_Penetrator",
				"Xiexe/Toon2.0/XSToon2.0_Transparent",
				"Xiexe/XSBoner/Bones",
				"Xiexe/XSFur",
				"ZFS Shaders/ZFS_3D_Free",
				"ZFS Shaders/ZFS_Flat_Free"
			});
			if (!GClass84.bool_2)
			{
				this.method_433();
			}
			if (this.bool_142)
			{
				this.list_9.AddRange(this.list_4);
			}
			if (this.bool_143)
			{
				this.list_9.AddRange(this.list_5);
			}
			if (this.bool_144)
			{
				this.list_9.AddRange(this.list_6);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
		internal void method_552(bool bool_168)
		{
			this.bool_161 = bool_168;
			this.gclass40_0.bool_111 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0004C2DC File Offset: 0x0004A4DC
		internal void method_553(bool bool_168)
		{
			this.method_235(bool_168);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		internal void method_554()
		{
			this.method_517();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0004C304 File Offset: 0x0004A504
		private static void smethod_63(IntPtr intptr_2, long long_0, long long_1)
		{
			GClass145.int_53++;
			try
			{
				GClass145.delegate19_0(intptr_2, long_0, long_1);
			}
			finally
			{
				GClass145.int_53--;
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0004C34C File Offset: 0x0004A54C
		internal void method_555(bool bool_168)
		{
			this.method_139(bool_168);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0004C360 File Offset: 0x0004A560
		internal void method_556(bool bool_168)
		{
			this.method_453(bool_168);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0004C374 File Offset: 0x0004A574
		internal void method_557(bool bool_168)
		{
			this.bool_119 = bool_168;
			this.gclass40_0.bool_96 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0004C39C File Offset: 0x0004A59C
		private string method_558(MethodBase methodBase_0)
		{
			return this.method_485(methodBase_0);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		internal void method_559(bool bool_168)
		{
			this.method_287(bool_168);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
		internal void method_560(bool bool_168)
		{
			this.bool_42 = bool_168;
			this.gclass40_0.bool_30 = bool_168;
			GClass40.smethod_1();
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		internal void method_561(List<GClass84.GStruct136> list_30)
		{
			for (int i = list_30.Count - 1; i >= 0; i--)
			{
				this.method_356(list_30[i]);
			}
		}

		// Token: 0x0400090B RID: 2315
		private static List<object> list_0 = new List<object>();

		// Token: 0x0400090C RID: 2316
		private static readonly GClass119<GClass145.Struct9> gclass119_0 = new GClass119<GClass145.Struct9>(GClass145.Struct9.IComparer_0);

		// Token: 0x0400090D RID: 2317
		internal bool bool_0 = true;

		// Token: 0x0400090E RID: 2318
		internal bool bool_1 = true;

		// Token: 0x0400090F RID: 2319
		internal bool bool_2 = false;

		// Token: 0x04000910 RID: 2320
		internal bool bool_3 = false;

		// Token: 0x04000911 RID: 2321
		internal bool bool_4 = false;

		// Token: 0x04000912 RID: 2322
		internal bool bool_5 = false;

		// Token: 0x04000913 RID: 2323
		internal bool bool_6 = true;

		// Token: 0x04000914 RID: 2324
		internal bool bool_7 = true;

		// Token: 0x04000915 RID: 2325
		internal bool bool_8 = true;

		// Token: 0x04000916 RID: 2326
		internal bool bool_9 = true;

		// Token: 0x04000917 RID: 2327
		internal bool bool_10 = false;

		// Token: 0x04000918 RID: 2328
		internal bool bool_11 = true;

		// Token: 0x04000919 RID: 2329
		internal bool bool_12 = true;

		// Token: 0x0400091A RID: 2330
		internal bool bool_13 = true;

		// Token: 0x0400091B RID: 2331
		internal bool bool_14 = false;

		// Token: 0x0400091C RID: 2332
		internal bool bool_15 = false;

		// Token: 0x0400091D RID: 2333
		internal bool bool_16 = true;

		// Token: 0x0400091E RID: 2334
		internal bool bool_17 = true;

		// Token: 0x0400091F RID: 2335
		internal bool bool_18 = true;

		// Token: 0x04000920 RID: 2336
		internal int int_0 = 100;

		// Token: 0x04000921 RID: 2337
		internal bool bool_19 = true;

		// Token: 0x04000922 RID: 2338
		internal bool bool_20 = true;

		// Token: 0x04000923 RID: 2339
		internal bool bool_21 = true;

		// Token: 0x04000924 RID: 2340
		internal bool bool_22 = true;

		// Token: 0x04000925 RID: 2341
		internal bool bool_23 = true;

		// Token: 0x04000926 RID: 2342
		internal bool bool_24 = true;

		// Token: 0x04000927 RID: 2343
		internal bool bool_25 = true;

		// Token: 0x04000928 RID: 2344
		internal List<string> list_1 = new List<string>
		{
			"avtr_da4e38cd-f172-4016-9600-7ba6fc298add"
		};

		// Token: 0x04000929 RID: 2345
		internal bool bool_26 = true;

		// Token: 0x0400092A RID: 2346
		internal float float_0 = 10000f;

		// Token: 0x0400092B RID: 2347
		internal bool bool_27 = false;

		// Token: 0x0400092C RID: 2348
		internal bool bool_28 = true;

		// Token: 0x0400092D RID: 2349
		internal float float_1 = 1000f;

		// Token: 0x0400092E RID: 2350
		internal bool bool_29 = false;

		// Token: 0x0400092F RID: 2351
		internal bool bool_30 = true;

		// Token: 0x04000930 RID: 2352
		internal bool bool_31 = true;

		// Token: 0x04000931 RID: 2353
		internal bool bool_32 = true;

		// Token: 0x04000932 RID: 2354
		internal bool bool_33 = true;

		// Token: 0x04000933 RID: 2355
		internal bool bool_34 = false;

		// Token: 0x04000934 RID: 2356
		internal bool bool_35 = false;

		// Token: 0x04000935 RID: 2357
		internal bool bool_36 = false;

		// Token: 0x04000936 RID: 2358
		internal bool bool_37 = false;

		// Token: 0x04000937 RID: 2359
		internal bool bool_38 = false;

		// Token: 0x04000938 RID: 2360
		internal bool bool_39 = true;

		// Token: 0x04000939 RID: 2361
		internal int int_1 = 80;

		// Token: 0x0400093A RID: 2362
		internal int int_2 = 150;

		// Token: 0x0400093B RID: 2363
		internal int int_3 = 30;

		// Token: 0x0400093C RID: 2364
		internal int int_4 = 1;

		// Token: 0x0400093D RID: 2365
		internal string string_1 = "LimitedAlready_";

		// Token: 0x0400093E RID: 2366
		internal bool bool_40 = false;

		// Token: 0x0400093F RID: 2367
		internal int int_5 = 3;

		// Token: 0x04000940 RID: 2368
		internal int int_6 = 5;

		// Token: 0x04000941 RID: 2369
		internal float float_2 = 0f;

		// Token: 0x04000942 RID: 2370
		internal float float_3 = 0f;

		// Token: 0x04000943 RID: 2371
		internal float float_4 = 0.01f;

		// Token: 0x04000944 RID: 2372
		internal int int_7 = 3;

		// Token: 0x04000945 RID: 2373
		internal int int_8 = 5;

		// Token: 0x04000946 RID: 2374
		internal float float_5 = 0.01f;

		// Token: 0x04000947 RID: 2375
		internal float float_6 = 100f;

		// Token: 0x04000948 RID: 2376
		internal float float_7 = 0f;

		// Token: 0x04000949 RID: 2377
		internal bool bool_41 = true;

		// Token: 0x0400094A RID: 2378
		internal bool bool_42 = false;

		// Token: 0x0400094B RID: 2379
		internal bool bool_43 = false;

		// Token: 0x0400094C RID: 2380
		internal bool bool_44 = true;

		// Token: 0x0400094D RID: 2381
		internal bool bool_45 = true;

		// Token: 0x0400094E RID: 2382
		internal bool bool_46 = true;

		// Token: 0x0400094F RID: 2383
		internal bool bool_47 = true;

		// Token: 0x04000950 RID: 2384
		internal bool bool_48 = true;

		// Token: 0x04000951 RID: 2385
		internal bool bool_49 = true;

		// Token: 0x04000952 RID: 2386
		internal bool bool_50 = false;

		// Token: 0x04000953 RID: 2387
		internal int int_9 = 2;

		// Token: 0x04000954 RID: 2388
		internal bool bool_51 = false;

		// Token: 0x04000955 RID: 2389
		internal bool bool_52 = false;

		// Token: 0x04000956 RID: 2390
		internal bool bool_53 = false;

		// Token: 0x04000957 RID: 2391
		internal bool bool_54 = true;

		// Token: 0x04000958 RID: 2392
		internal bool bool_55 = false;

		// Token: 0x04000959 RID: 2393
		internal bool bool_56 = true;

		// Token: 0x0400095A RID: 2394
		internal bool bool_57 = false;

		// Token: 0x0400095B RID: 2395
		internal bool bool_58 = false;

		// Token: 0x0400095C RID: 2396
		internal bool bool_59 = true;

		// Token: 0x0400095D RID: 2397
		internal bool bool_60 = false;

		// Token: 0x0400095E RID: 2398
		internal bool bool_61 = true;

		// Token: 0x0400095F RID: 2399
		internal bool bool_62 = false;

		// Token: 0x04000960 RID: 2400
		internal bool bool_63 = false;

		// Token: 0x04000961 RID: 2401
		internal bool bool_64 = true;

		// Token: 0x04000962 RID: 2402
		internal bool bool_65 = false;

		// Token: 0x04000963 RID: 2403
		internal bool bool_66 = false;

		// Token: 0x04000964 RID: 2404
		internal bool bool_67 = true;

		// Token: 0x04000965 RID: 2405
		internal bool bool_68 = false;

		// Token: 0x04000966 RID: 2406
		internal bool bool_69 = false;

		// Token: 0x04000967 RID: 2407
		internal bool bool_70 = true;

		// Token: 0x04000968 RID: 2408
		internal bool bool_71 = false;

		// Token: 0x04000969 RID: 2409
		internal int int_10 = 5000;

		// Token: 0x0400096A RID: 2410
		internal float float_8 = 1f;

		// Token: 0x0400096B RID: 2411
		internal int int_11 = 2500;

		// Token: 0x0400096C RID: 2412
		internal int int_12 = 0;

		// Token: 0x0400096D RID: 2413
		internal int int_13 = 0;

		// Token: 0x0400096E RID: 2414
		internal int int_14 = 2;

		// Token: 0x0400096F RID: 2415
		internal int int_15 = -1;

		// Token: 0x04000970 RID: 2416
		internal int int_16 = 100000;

		// Token: 0x04000971 RID: 2417
		internal int int_17 = 256;

		// Token: 0x04000972 RID: 2418
		internal float float_9 = 5f;

		// Token: 0x04000973 RID: 2419
		internal float float_10 = 100f;

		// Token: 0x04000974 RID: 2420
		internal int int_18 = 250000;

		// Token: 0x04000975 RID: 2421
		internal int int_19 = 500000;

		// Token: 0x04000976 RID: 2422
		internal int int_20 = 500;

		// Token: 0x04000977 RID: 2423
		internal int int_21 = 100000;

		// Token: 0x04000978 RID: 2424
		internal bool bool_72 = true;

		// Token: 0x04000979 RID: 2425
		internal bool bool_73 = true;

		// Token: 0x0400097A RID: 2426
		internal bool bool_74 = false;

		// Token: 0x0400097B RID: 2427
		internal bool bool_75 = false;

		// Token: 0x0400097C RID: 2428
		internal bool bool_76 = true;

		// Token: 0x0400097D RID: 2429
		internal bool bool_77 = false;

		// Token: 0x0400097E RID: 2430
		internal int int_22 = 30;

		// Token: 0x0400097F RID: 2431
		internal int int_23 = 10;

		// Token: 0x04000980 RID: 2432
		internal bool bool_78 = true;

		// Token: 0x04000981 RID: 2433
		internal bool bool_79 = false;

		// Token: 0x04000982 RID: 2434
		internal bool bool_80 = false;

		// Token: 0x04000983 RID: 2435
		internal bool bool_81 = true;

		// Token: 0x04000984 RID: 2436
		internal bool bool_82 = false;

		// Token: 0x04000985 RID: 2437
		internal bool bool_83 = false;

		// Token: 0x04000986 RID: 2438
		internal bool bool_84 = true;

		// Token: 0x04000987 RID: 2439
		internal bool bool_85 = true;

		// Token: 0x04000988 RID: 2440
		internal bool bool_86 = true;

		// Token: 0x04000989 RID: 2441
		internal int int_24 = 1000000;

		// Token: 0x0400098A RID: 2442
		internal int int_25 = 2000000;

		// Token: 0x0400098B RID: 2443
		internal bool bool_87 = true;

		// Token: 0x0400098C RID: 2444
		internal bool bool_88 = false;

		// Token: 0x0400098D RID: 2445
		internal bool bool_89 = true;

		// Token: 0x0400098E RID: 2446
		internal bool bool_90 = false;

		// Token: 0x0400098F RID: 2447
		internal bool bool_91 = false;

		// Token: 0x04000990 RID: 2448
		internal bool bool_92 = true;

		// Token: 0x04000991 RID: 2449
		internal bool bool_93 = false;

		// Token: 0x04000992 RID: 2450
		internal int int_26 = 100000;

		// Token: 0x04000993 RID: 2451
		internal int int_27 = 200000;

		// Token: 0x04000994 RID: 2452
		internal bool bool_94 = true;

		// Token: 0x04000995 RID: 2453
		internal int int_28 = 300;

		// Token: 0x04000996 RID: 2454
		internal bool bool_95 = true;

		// Token: 0x04000997 RID: 2455
		internal bool bool_96 = true;

		// Token: 0x04000998 RID: 2456
		internal bool bool_97 = false;

		// Token: 0x04000999 RID: 2457
		internal bool bool_98 = false;

		// Token: 0x0400099A RID: 2458
		internal int int_29 = 250;

		// Token: 0x0400099B RID: 2459
		internal bool bool_99 = true;

		// Token: 0x0400099C RID: 2460
		internal bool bool_100 = false;

		// Token: 0x0400099D RID: 2461
		internal bool bool_101 = true;

		// Token: 0x0400099E RID: 2462
		internal bool bool_102 = false;

		// Token: 0x0400099F RID: 2463
		internal bool bool_103 = false;

		// Token: 0x040009A0 RID: 2464
		internal float float_11 = 60f;

		// Token: 0x040009A1 RID: 2465
		internal int int_30 = 50;

		// Token: 0x040009A2 RID: 2466
		internal bool bool_104 = true;

		// Token: 0x040009A3 RID: 2467
		internal bool bool_105 = false;

		// Token: 0x040009A4 RID: 2468
		internal bool bool_106 = true;

		// Token: 0x040009A5 RID: 2469
		internal bool bool_107 = false;

		// Token: 0x040009A6 RID: 2470
		internal bool bool_108 = false;

		// Token: 0x040009A7 RID: 2471
		internal float float_12 = 120f;

		// Token: 0x040009A8 RID: 2472
		internal bool bool_109 = true;

		// Token: 0x040009A9 RID: 2473
		internal bool bool_110 = false;

		// Token: 0x040009AA RID: 2474
		internal bool bool_111 = true;

		// Token: 0x040009AB RID: 2475
		internal bool bool_112 = false;

		// Token: 0x040009AC RID: 2476
		internal bool bool_113 = false;

		// Token: 0x040009AD RID: 2477
		internal int int_31 = 4;

		// Token: 0x040009AE RID: 2478
		internal bool bool_114 = true;

		// Token: 0x040009AF RID: 2479
		internal bool bool_115 = false;

		// Token: 0x040009B0 RID: 2480
		internal bool bool_116 = true;

		// Token: 0x040009B1 RID: 2481
		internal int int_32 = 150;

		// Token: 0x040009B2 RID: 2482
		internal bool bool_117 = true;

		// Token: 0x040009B3 RID: 2483
		internal bool bool_118 = true;

		// Token: 0x040009B4 RID: 2484
		internal bool bool_119 = false;

		// Token: 0x040009B5 RID: 2485
		internal bool bool_120 = false;

		// Token: 0x040009B6 RID: 2486
		internal int int_33 = 100;

		// Token: 0x040009B7 RID: 2487
		internal bool bool_121 = true;

		// Token: 0x040009B8 RID: 2488
		internal bool bool_122 = false;

		// Token: 0x040009B9 RID: 2489
		internal bool bool_123 = true;

		// Token: 0x040009BA RID: 2490
		internal int int_34 = 10;

		// Token: 0x040009BB RID: 2491
		internal int int_35 = 20;

		// Token: 0x040009BC RID: 2492
		internal int int_36 = 300;

		// Token: 0x040009BD RID: 2493
		internal bool bool_124 = true;

		// Token: 0x040009BE RID: 2494
		internal bool bool_125 = true;

		// Token: 0x040009BF RID: 2495
		internal bool bool_126 = false;

		// Token: 0x040009C0 RID: 2496
		internal bool bool_127 = false;

		// Token: 0x040009C1 RID: 2497
		internal int int_37 = 10;

		// Token: 0x040009C2 RID: 2498
		internal int int_38 = 20;

		// Token: 0x040009C3 RID: 2499
		internal int int_39 = 250;

		// Token: 0x040009C4 RID: 2500
		internal bool bool_128 = true;

		// Token: 0x040009C5 RID: 2501
		internal bool bool_129 = false;

		// Token: 0x040009C6 RID: 2502
		internal bool bool_130 = true;

		// Token: 0x040009C7 RID: 2503
		internal int int_40 = 128;

		// Token: 0x040009C8 RID: 2504
		internal bool bool_131 = true;

		// Token: 0x040009C9 RID: 2505
		internal bool bool_132 = true;

		// Token: 0x040009CA RID: 2506
		internal bool bool_133 = false;

		// Token: 0x040009CB RID: 2507
		internal bool bool_134 = false;

		// Token: 0x040009CC RID: 2508
		internal int int_41 = 96;

		// Token: 0x040009CD RID: 2509
		internal bool bool_135 = true;

		// Token: 0x040009CE RID: 2510
		internal bool bool_136 = false;

		// Token: 0x040009CF RID: 2511
		private List<GClass145.Struct3> list_2 = new List<GClass145.Struct3>();

		// Token: 0x040009D0 RID: 2512
		private List<GClass145.Struct4> list_3 = new List<GClass145.Struct4>();

		// Token: 0x040009D1 RID: 2513
		internal List<string> list_4 = new List<string>
		{
			"_Unreal's Shaders/Sine VFX/DistortionSpherePS High",
			"_Unreal's Shaders/Sine VFX/StartSphereV4",
			"Moons/Static/Lit",
			"SineVFX/StartSphere",
			"Sine VFX/DistortionSpherePS High",
			"Sine VFX/MeshEnchantAlphaBlended",
			"Sine VFX/StartSphere",
			"Sine VFX/StartSphereV2",
			"Sine VFX/StartSphereV3",
			"Sine VFX/StartSphereV4",
			"Sine VFX/StartSphereV5",
			"ZalgoBLYAT/ZalgoShader_v2"
		};

		// Token: 0x040009D2 RID: 2514
		internal List<string> list_5 = new List<string>
		{
			"Custom/Multi-Shader/StarNest"
		};

		// Token: 0x040009D3 RID: 2515
		internal List<string> list_6 = new List<string>
		{
			".NEK0/Screen/Radial Blurr Zoom",
			"DocMe/BeautifulShaderv0.21",
			"Huyami/Ultrashader",
			"Leviant's Shaders/ScreenSpace Ubershader v2.7",
			"Leviant's Shaders/ScreenSpace Ubershader v2.7.3",
			"Leviant's Shaders/UberShader v2.9",
			"Magic3000/ScreenSpace",
			"Magic3000/ScreenSpacePub",
			"Magic3000/RGB-Glitch",
			"NEK0/Screen/Fade Screen v1",
			"VoidyShaders/Cave"
		};

		// Token: 0x040009D4 RID: 2516
		internal List<string> list_7 = new List<string>
		{
			".Star/Bacon",
			".Woofaa/Medusa",
			"Custom/Custom",
			"DistanceBased",
			"Knuckles_Gang/Free Crash",
			"Kyran/E  G  G",
			"Medusa Crash/Standard",
			"onion",
			"Pretty",
			"Sprythu/Why is my screen black"
		};

		// Token: 0x040009D5 RID: 2517
		internal List<string> list_8 = new List<string>
		{
			"Crash"
		};

		// Token: 0x040009D6 RID: 2518
		internal List<string> list_9 = new List<string>();

		// Token: 0x040009D7 RID: 2519
		internal List<string> list_10 = new List<string>();

		// Token: 0x040009D8 RID: 2520
		internal List<string> list_11 = new List<string>();

		// Token: 0x040009D9 RID: 2521
		internal bool bool_137 = false;

		// Token: 0x040009DA RID: 2522
		internal bool bool_138 = false;

		// Token: 0x040009DB RID: 2523
		internal bool bool_139 = false;

		// Token: 0x040009DC RID: 2524
		internal bool bool_140 = true;

		// Token: 0x040009DD RID: 2525
		internal bool bool_141 = true;

		// Token: 0x040009DE RID: 2526
		internal bool bool_142 = true;

		// Token: 0x040009DF RID: 2527
		internal bool bool_143 = true;

		// Token: 0x040009E0 RID: 2528
		internal bool bool_144 = false;

		// Token: 0x040009E1 RID: 2529
		internal bool bool_145 = true;

		// Token: 0x040009E2 RID: 2530
		internal bool bool_146 = false;

		// Token: 0x040009E3 RID: 2531
		internal bool bool_147 = false;

		// Token: 0x040009E4 RID: 2532
		internal bool bool_148 = true;

		// Token: 0x040009E5 RID: 2533
		internal bool bool_149 = true;

		// Token: 0x040009E6 RID: 2534
		internal bool bool_150 = true;

		// Token: 0x040009E7 RID: 2535
		internal bool bool_151 = true;

		// Token: 0x040009E8 RID: 2536
		internal bool bool_152 = false;

		// Token: 0x040009E9 RID: 2537
		internal bool bool_153 = true;

		// Token: 0x040009EA RID: 2538
		private List<GClass145.Struct6> list_12 = new List<GClass145.Struct6>();

		// Token: 0x040009EB RID: 2539
		internal int int_42 = 10;

		// Token: 0x040009EC RID: 2540
		internal int int_43 = 120;

		// Token: 0x040009ED RID: 2541
		internal float float_13 = 0f;

		// Token: 0x040009EE RID: 2542
		internal int int_44 = 250;

		// Token: 0x040009EF RID: 2543
		internal bool bool_154 = true;

		// Token: 0x040009F0 RID: 2544
		internal int int_45 = 100;

		// Token: 0x040009F1 RID: 2545
		internal int int_46 = 3000;

		// Token: 0x040009F2 RID: 2546
		internal int int_47 = 0;

		// Token: 0x040009F3 RID: 2547
		internal GClass40 gclass40_0;

		// Token: 0x040009F4 RID: 2548
		internal GClass107 gclass107_0;

		// Token: 0x040009F5 RID: 2549
		internal bool bool_155 = true;

		// Token: 0x040009F6 RID: 2550
		internal List<string> list_13;

		// Token: 0x040009F7 RID: 2551
		internal int int_48 = 300;

		// Token: 0x040009F8 RID: 2552
		internal float float_14 = 0f;

		// Token: 0x040009F9 RID: 2553
		internal int int_49 = 1500;

		// Token: 0x040009FA RID: 2554
		internal int int_50 = 0;

		// Token: 0x040009FB RID: 2555
		internal bool bool_156 = false;

		// Token: 0x040009FC RID: 2556
		internal int int_51 = 0;

		// Token: 0x040009FD RID: 2557
		private List<GClass145.Struct7> list_14 = new List<GClass145.Struct7>();

		// Token: 0x040009FE RID: 2558
		private List<Object> list_15 = new List<Object>();

		// Token: 0x040009FF RID: 2559
		private List<Object> list_16 = new List<Object>();

		// Token: 0x04000A00 RID: 2560
		private int int_52 = 0;

		// Token: 0x04000A01 RID: 2561
		internal List<GClass84.GStruct136> list_17 = new List<GClass84.GStruct136>();

		// Token: 0x04000A02 RID: 2562
		internal List<GClass84.GStruct136> list_18 = new List<GClass84.GStruct136>();

		// Token: 0x04000A03 RID: 2563
		internal List<GClass84.GStruct146> list_19 = new List<GClass84.GStruct146>();

		// Token: 0x04000A04 RID: 2564
		internal List<GClass84.GStruct146> list_20 = new List<GClass84.GStruct146>();

		// Token: 0x04000A05 RID: 2565
		internal List<GClass145.GStruct102> list_21;

		// Token: 0x04000A06 RID: 2566
		internal List<GClass145.GStruct102> list_22 = new List<GClass145.GStruct102>();

		// Token: 0x04000A07 RID: 2567
		internal bool bool_157 = true;

		// Token: 0x04000A08 RID: 2568
		internal List<GClass145.GStruct102> list_23;

		// Token: 0x04000A09 RID: 2569
		internal List<GClass145.GStruct102> list_24 = new List<GClass145.GStruct102>();

		// Token: 0x04000A0A RID: 2570
		internal bool bool_158 = true;

		// Token: 0x04000A0B RID: 2571
		internal List<GClass145.GStruct102> list_25;

		// Token: 0x04000A0C RID: 2572
		internal List<GClass145.GStruct102> list_26 = new List<GClass145.GStruct102>();

		// Token: 0x04000A0D RID: 2573
		internal bool bool_159 = true;

		// Token: 0x04000A0E RID: 2574
		internal List<GClass145.GStruct102> list_27;

		// Token: 0x04000A0F RID: 2575
		internal List<GClass145.GStruct102> list_28 = new List<GClass145.GStruct102>();

		// Token: 0x04000A10 RID: 2576
		internal bool bool_160 = true;

		// Token: 0x04000A11 RID: 2577
		internal bool bool_161 = true;

		// Token: 0x04000A12 RID: 2578
		internal bool bool_162 = false;

		// Token: 0x04000A13 RID: 2579
		internal bool bool_163 = false;

		// Token: 0x04000A14 RID: 2580
		internal bool bool_164 = false;

		// Token: 0x04000A15 RID: 2581
		internal static bool bool_165 = true;

		// Token: 0x04000A16 RID: 2582
		internal static List<GClass84.GStruct134> list_29 = new List<GClass84.GStruct134>();

		// Token: 0x04000A17 RID: 2583
		[ThreadStatic]
		private static Stack<IntPtr> stack_0;

		// Token: 0x04000A18 RID: 2584
		private static GClass145.Delegate12 delegate12_0;

		// Token: 0x04000A19 RID: 2585
		private static GClass145.Delegate13 delegate13_0;

		// Token: 0x04000A1A RID: 2586
		private static GClass145.Delegate14 delegate14_0;

		// Token: 0x04000A1B RID: 2587
		private static GClass145.Delegate15 delegate15_0;

		// Token: 0x04000A1C RID: 2588
		private static GClass145.Delegate16 delegate16_0;

		// Token: 0x04000A1D RID: 2589
		private static GClass145.Delegate17 delegate17_0;

		// Token: 0x04000A1E RID: 2590
		private static GClass145.Delegate18 delegate18_0;

		// Token: 0x04000A1F RID: 2591
		private static GClass145.Delegate19 delegate19_0;

		// Token: 0x04000A20 RID: 2592
		[ThreadStatic]
		private static int int_53;

		// Token: 0x04000A21 RID: 2593
		private static GClass145.Delegate20 delegate20_0;

		// Token: 0x04000A22 RID: 2594
		private static GClass145.Delegate22 delegate22_0;

		// Token: 0x04000A23 RID: 2595
		[ThreadStatic]
		private unsafe static GClass145.Struct14* pStruct14_0;

		// Token: 0x04000A24 RID: 2596
		internal static bool bool_166 = true;

		// Token: 0x04000A25 RID: 2597
		internal static bool bool_167 = true;

		// Token: 0x04000A26 RID: 2598
		private static GClass145.Delegate23 delegate23_0;

		// Token: 0x04000A27 RID: 2599
		private static IntPtr intptr_0;

		// Token: 0x04000A28 RID: 2600
		private static GClass145.Delegate24 delegate24_0;

		// Token: 0x04000A29 RID: 2601
		private static IntPtr intptr_1;

		// Token: 0x04000A2A RID: 2602
		private const float float_15 = 3.402823E+07f;

		// Token: 0x04000A2B RID: 2603
		private const float float_16 = -3.402823E+07f;

		// Token: 0x04000A2C RID: 2604
		private static readonly string[] string_2 = new string[]
		{
			"m_BreakForce",
			"m_BreakTorque",
			"collisionSphereDistance",
			"maxDistance",
			"inSlope",
			"outSlope"
		};

		// Token: 0x04000A2D RID: 2605
		[TupleElementNames(new string[]
		{
			"ProduceMixer",
			"TransferFloat",
			"AssetBundle",
			"CountNodes",
			"DebugAssert",
			"ReaderOOB",
			"ReallocateString",
			"TransferMonoObject",
			"TransferUEObjectSBR",
			null,
			null
		})]
		private static readonly Dictionary<string, ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>> dictionary_0 = new Dictionary<string, ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>>
		{
			{
				"aCEmIwSIcjYriBQDFjQlpTNNW1/kA8Wlbkqelmt1USOMB09cnKwK7QWyOulz9d7DEYJh4+vO0Ldv8gdH+dZCrg==",
				new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>(4822976, 881440, 6087252, 0, 0, 0, 0, new ValueTuple<int, int>(0, 0))
			},
			{
				"5dkhl/dWeTREXhHCIkZK17mzZkbjhTKlxb+IUSk+YaWzZrrV+G+M0ekTOEGjZ4dJuB4O3nU/oE3dycXWeJq9uA==",
				new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>(11011680, 817984, 0, 0, 0, 0, 0, new ValueTuple<int, int>(0, 0))
			},
			{
				"MV6xP7theydao4ENbGi6BbiBxdZsgGOBo/WrPSeIqh6A/E00NImjUNZn+gL+ZxzpVbJms7nUb6zluLL3+aIcfg==",
				new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>(11019088, 818768, 14513915, 0, 0, 0, 0, new ValueTuple<int, int>(0, 0))
			},
			{
				"ccZ4F7iE7a78kWdXdMekJzP7/ktzS5jOOS8IOITxa1C5Jg2TKxC0/ywY8F0o9I1vZHsxAO4eh7G2sOGzsR/+uQ==",
				new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>(11023376, 818816, 14521675, 0, 0, 0, 0, new ValueTuple<int, int>(0, 0))
			},
			{
				"sgZUlX3+LSHKnTiTC+nXNcdtLOTrAB1fNjBLOwDdKzCyndlFLAdL0udR4S1szTC/q5pnFhG3Kdspsj5jvwLY1A==",
				new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int, int>>(11035248, 819760, 14533227, 14625264, 14532032, 8101552, 813552, new ValueTuple<int, int>(9245024, 9329872))
			}
		};

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x06000E1F RID: 3615
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate10(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x06000E22 RID: 3618
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate11(IntPtr intptr_0, Vector3 vector3_0, Quaternion quaternion_0, byte byte_0, byte byte_1, byte byte_2, IntPtr intptr_1);

		// Token: 0x02000153 RID: 339
		public struct GStruct99
		{
			// Token: 0x06000E25 RID: 3621 RVA: 0x0004C420 File Offset: 0x0004A620
			public static bool smethod_0(GClass145.GStruct99 gstruct99_0, GClass145.GStruct99 gstruct99_1, bool bool_0 = false)
			{
				bool result;
				if (!bool_0 && gstruct99_0.transform_1 != gstruct99_1.transform_1)
				{
					result = false;
				}
				else
				{
					if (gstruct99_0.transform_0 && gstruct99_1.transform_0)
					{
						if (gstruct99_0.transform_0.position != gstruct99_1.transform_0.position)
						{
							return false;
						}
						if (gstruct99_0.transform_0.rotation != gstruct99_1.transform_0.rotation)
						{
							return false;
						}
					}
					if (gstruct99_0.particleSystem_0)
					{
						if (!gstruct99_1.particleSystem_0)
						{
							return false;
						}
						if (!GClass145.GStruct99.smethod_1(gstruct99_0.particleSystem_0, gstruct99_1.particleSystem_0))
						{
							return false;
						}
					}
					else if (gstruct99_1.particleSystem_0)
					{
						return false;
					}
					if (gstruct99_0.particleSystemRenderer_0)
					{
						if (!gstruct99_1.particleSystemRenderer_0)
						{
							return false;
						}
						if (!GClass145.GStruct99.smethod_2(gstruct99_0.particleSystemRenderer_0, gstruct99_1.particleSystemRenderer_0))
						{
							return false;
						}
					}
					else if (gstruct99_1.particleSystemRenderer_0)
					{
						return false;
					}
					result = true;
				}
				return result;
			}

			// Token: 0x06000E26 RID: 3622 RVA: 0x0004C548 File Offset: 0x0004A748
			public static bool smethod_1(ParticleSystem particleSystem_1, ParticleSystem particleSystem_2)
			{
				bool result;
				if (!particleSystem_1)
				{
					result = !particleSystem_2;
				}
				else if (!particleSystem_2)
				{
					result = false;
				}
				else
				{
					ParticleSystem.MainModule main = particleSystem_1.main;
					ParticleSystem.MainModule main2 = particleSystem_2.main;
					if (main != null)
					{
						if (main2 == null)
						{
							return false;
						}
						ParticleSystem.MinMaxGradient startColor = main.startColor;
						ParticleSystem.MinMaxGradient startColor2 = main2.startColor;
						if (startColor != null)
						{
							if (startColor2 == null)
							{
								return false;
							}
							if (startColor.mode != startColor2.mode)
							{
								return false;
							}
							switch (startColor.mode)
							{
							case 0:
								if (startColor.color != startColor2.color)
								{
									return false;
								}
								break;
							case 1:
								if (startColor.gradient != startColor2.gradient)
								{
									return false;
								}
								break;
							case 2:
								if (startColor.colorMin != startColor2.colorMin)
								{
									return false;
								}
								if (startColor.colorMax != startColor2.colorMax)
								{
									return false;
								}
								break;
							case 3:
								if (startColor.gradientMin != startColor2.gradientMin)
								{
									return false;
								}
								if (startColor.gradientMax != startColor2.gradientMax)
								{
									return false;
								}
								break;
							case 4:
								return false;
							}
						}
						else if (startColor2 != null)
						{
							return false;
						}
						if (main.maxParticles != main2.maxParticles)
						{
							return false;
						}
						if (main.playOnAwake != main2.playOnAwake)
						{
							return false;
						}
						if (main.loop != main2.loop)
						{
							return false;
						}
						ParticleSystem.MinMaxCurve startDelay = main.startDelay;
						ParticleSystem.MinMaxCurve startDelay2 = main2.startDelay;
						if (startDelay != null)
						{
							if (startDelay2 == null)
							{
								return false;
							}
							if (startDelay.constantMin != startDelay2.constantMin)
							{
								return false;
							}
							if (startDelay.constantMax != startDelay2.constantMax)
							{
								return false;
							}
						}
						else if (startDelay2 != null)
						{
							return false;
						}
						ParticleSystem.MinMaxCurve startLifetime = main.startLifetime;
						ParticleSystem.MinMaxCurve startLifetime2 = main2.startLifetime;
						if (startLifetime != null)
						{
							if (startLifetime2 == null)
							{
								return false;
							}
							if (startLifetime.constantMin != startLifetime2.constantMin)
							{
								return false;
							}
							if (startLifetime.constantMax != startLifetime2.constantMax)
							{
								return false;
							}
						}
						else if (startLifetime2 != null)
						{
							return false;
						}
					}
					else if (main2 != null)
					{
						return false;
					}
					if (particleSystem_1.playOnAwake != particleSystem_2.playOnAwake)
					{
						result = false;
					}
					else if (particleSystem_1.loop != particleSystem_2.loop)
					{
						result = false;
					}
					else if (particleSystem_1.startDelay != particleSystem_2.startDelay)
					{
						result = false;
					}
					else
					{
						ParticleSystem.EmissionModule emission = particleSystem_1.emission;
						ParticleSystem.EmissionModule emission2 = particleSystem_2.emission;
						int burstCount = emission.burstCount;
						int burstCount2 = emission2.burstCount;
						if (burstCount != burstCount2)
						{
							result = false;
						}
						else
						{
							for (int i = 0; i < burstCount; i++)
							{
								ParticleSystem.Burst burst = emission.GetBurst(i);
								ParticleSystem.Burst burst2 = emission2.GetBurst(i);
								if (burst != null)
								{
									if (burst2 == null)
									{
										return false;
									}
									ParticleSystem.MinMaxCurve count = burst.count;
									ParticleSystem.MinMaxCurve count2 = burst2.count;
									if (count != null)
									{
										if (count2 == null)
										{
											return false;
										}
										if (count.constantMin != count2.constantMin)
										{
											return false;
										}
										if (count.constantMax != count2.constantMax)
										{
											return false;
										}
									}
									else if (count2 != null)
									{
										return false;
									}
								}
								else if (burst2 != null)
								{
									return false;
								}
							}
							ParticleSystem.ShapeModule shape = particleSystem_1.shape;
							ParticleSystem.ShapeModule shape2 = particleSystem_2.shape;
							if (shape != null)
							{
								if (shape2 == null)
								{
									return false;
								}
								if (shape.enabled != shape2.enabled)
								{
									return false;
								}
								if (shape.enabled)
								{
									if (shape.shapeType != shape2.shapeType)
									{
										return false;
									}
									if (shape.radius != shape2.radius)
									{
										return false;
									}
									if (shape.position != shape2.position)
									{
										return false;
									}
									if (shape.rotation != shape2.rotation)
									{
										return false;
									}
									if (shape.scale != shape2.scale)
									{
										return false;
									}
								}
							}
							else if (shape2 != null)
							{
								return false;
							}
							ParticleSystem.SubEmittersModule subEmitters = particleSystem_1.subEmitters;
							ParticleSystem.SubEmittersModule subEmitters2 = particleSystem_2.subEmitters;
							if (subEmitters != null)
							{
								if (subEmitters2 == null)
								{
									return false;
								}
								if (subEmitters.enabled != subEmitters2.enabled)
								{
									return false;
								}
								if (subEmitters.enabled)
								{
									if (subEmitters.subEmittersCount != subEmitters2.subEmittersCount)
									{
										return false;
									}
									for (int j = 0; j < subEmitters.subEmittersCount; j++)
									{
										if (subEmitters.GetSubEmitterSystem(j) != subEmitters2.GetSubEmitterSystem(j))
										{
											ParticleSystem subEmitterSystem = subEmitters.GetSubEmitterSystem(j);
											ParticleSystem subEmitterSystem2 = subEmitters2.GetSubEmitterSystem(j);
											if (subEmitterSystem)
											{
												if (!subEmitterSystem2)
												{
													return false;
												}
												Transform transform = subEmitterSystem.transform;
												Transform transform2 = subEmitterSystem2.transform;
												if (transform.name != transform2.name)
												{
													return false;
												}
												if (!transform.IsChildOf(particleSystem_1.transform) || !transform2.IsChildOf(particleSystem_2.transform))
												{
													return false;
												}
												if (GClass84.smethod_908(transform, particleSystem_1.transform) != GClass84.smethod_908(transform2, particleSystem_2.transform))
												{
													return false;
												}
											}
											else if (subEmitterSystem2)
											{
												return false;
											}
										}
									}
								}
							}
							else if (subEmitters2 != null)
							{
								return false;
							}
							result = true;
						}
					}
				}
				return result;
			}

			// Token: 0x06000E27 RID: 3623 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
			public GStruct99(Transform transform_2, Transform transform_3, ParticleSystem particleSystem_1, ParticleSystemRenderer particleSystemRenderer_1, int int_1 = 0)
			{
				this.transform_0 = transform_2;
				this.transform_1 = transform_3;
				this.particleSystem_0 = particleSystem_1;
				this.particleSystemRenderer_0 = particleSystemRenderer_1;
				this.int_0 = int_1;
			}

			// Token: 0x06000E28 RID: 3624 RVA: 0x0004CC14 File Offset: 0x0004AE14
			public static bool smethod_2(ParticleSystemRenderer particleSystemRenderer_1, ParticleSystemRenderer particleSystemRenderer_2)
			{
				bool result;
				if (!particleSystemRenderer_1)
				{
					result = !particleSystemRenderer_2;
				}
				else if (!particleSystemRenderer_2)
				{
					result = false;
				}
				else if (particleSystemRenderer_1.renderMode != particleSystemRenderer_2.renderMode)
				{
					result = false;
				}
				else
				{
					if (particleSystemRenderer_1.renderMode == 4)
					{
						if (particleSystemRenderer_1.mesh)
						{
							if (!particleSystemRenderer_2.mesh)
							{
								return false;
							}
							if (particleSystemRenderer_1.mesh.name != particleSystemRenderer_2.mesh.name)
							{
								return false;
							}
						}
						else if (particleSystemRenderer_2.mesh)
						{
							return false;
						}
					}
					Il2CppReferenceArray<Material> sharedMaterialArray = particleSystemRenderer_1.GetSharedMaterialArray();
					Il2CppReferenceArray<Material> sharedMaterialArray2 = particleSystemRenderer_2.GetSharedMaterialArray();
					int count = sharedMaterialArray.Count;
					if (count != sharedMaterialArray2.Count)
					{
						result = false;
					}
					else
					{
						for (int i = 0; i < count; i++)
						{
							if (sharedMaterialArray[i])
							{
								if (!sharedMaterialArray2[i])
								{
									return false;
								}
								if (sharedMaterialArray[i].name != sharedMaterialArray2[i].name)
								{
									return false;
								}
							}
							else if (sharedMaterialArray2[i])
							{
								return false;
							}
						}
						result = true;
					}
				}
				return result;
			}

			// Token: 0x04000A2E RID: 2606
			public Transform transform_0;

			// Token: 0x04000A2F RID: 2607
			public Transform transform_1;

			// Token: 0x04000A30 RID: 2608
			public ParticleSystem particleSystem_0;

			// Token: 0x04000A31 RID: 2609
			public ParticleSystemRenderer particleSystemRenderer_0;

			// Token: 0x04000A32 RID: 2610
			public int int_0;
		}

		// Token: 0x02000154 RID: 340
		public struct GStruct100
		{
			// Token: 0x06000E29 RID: 3625 RVA: 0x0004CD78 File Offset: 0x0004AF78
			public GStruct100(string string_1, int int_4, int int_5)
			{
				this.string_0 = string_1;
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_4;
				this.int_3 = int_5;
			}

			// Token: 0x06000E2A RID: 3626 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
			public GStruct100(string string_1, int int_4, int int_5, int int_6, int int_7)
			{
				this.string_0 = string_1;
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
			}

			// Token: 0x04000A33 RID: 2611
			public string string_0;

			// Token: 0x04000A34 RID: 2612
			public int int_0;

			// Token: 0x04000A35 RID: 2613
			public int int_1;

			// Token: 0x04000A36 RID: 2614
			public int int_2;

			// Token: 0x04000A37 RID: 2615
			public int int_3;
		}

		// Token: 0x02000155 RID: 341
		public struct GStruct101
		{
			// Token: 0x06000E2B RID: 3627 RVA: 0x0004CDDC File Offset: 0x0004AFDC
			public GStruct101(Transform transform_1, bool bool_1 = false, string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
			{
				this.transform_0 = transform_1;
				this.bool_0 = bool_1;
				this.string_0 = string_1;
				this.int_0 = int_3;
				this.int_1 = int_4;
				this.int_2 = int_5;
			}

			// Token: 0x04000A38 RID: 2616
			public Transform transform_0;

			// Token: 0x04000A39 RID: 2617
			public bool bool_0;

			// Token: 0x04000A3A RID: 2618
			public string string_0;

			// Token: 0x04000A3B RID: 2619
			public int int_0;

			// Token: 0x04000A3C RID: 2620
			public int int_1;

			// Token: 0x04000A3D RID: 2621
			public int int_2;
		}

		// Token: 0x02000156 RID: 342
		private struct Struct3
		{
			// Token: 0x06000E2C RID: 3628 RVA: 0x0004CE18 File Offset: 0x0004B018
			public Struct3(Transform transform_2, string string_1, ConsoleColor consoleColor_1, bool bool_4, bool bool_5, bool bool_6, Transform transform_3 = null, int int_2 = 0)
			{
				this.transform_0 = transform_2;
				this.string_0 = string_1;
				this.consoleColor_0 = consoleColor_1;
				this.bool_0 = bool_4;
				this.bool_1 = bool_5;
				this.bool_2 = bool_6;
				this.transform_1 = transform_3;
				this.list_0 = new List<GClass84.GStruct136>();
				this.list_1 = new List<GClass84.GStruct146>();
				this.int_0 = 0;
				this.bool_3 = false;
				this.int_1 = int_2;
			}

			// Token: 0x04000A3E RID: 2622
			public Transform transform_0;

			// Token: 0x04000A3F RID: 2623
			public string string_0;

			// Token: 0x04000A40 RID: 2624
			public ConsoleColor consoleColor_0;

			// Token: 0x04000A41 RID: 2625
			public bool bool_0;

			// Token: 0x04000A42 RID: 2626
			public bool bool_1;

			// Token: 0x04000A43 RID: 2627
			public bool bool_2;

			// Token: 0x04000A44 RID: 2628
			public Transform transform_1;

			// Token: 0x04000A45 RID: 2629
			public List<GClass84.GStruct136> list_0;

			// Token: 0x04000A46 RID: 2630
			public List<GClass84.GStruct146> list_1;

			// Token: 0x04000A47 RID: 2631
			public int int_0;

			// Token: 0x04000A48 RID: 2632
			public bool bool_3;

			// Token: 0x04000A49 RID: 2633
			public int int_1;
		}

		// Token: 0x02000157 RID: 343
		private struct Struct4
		{
			// Token: 0x06000E2D RID: 3629 RVA: 0x0004CE88 File Offset: 0x0004B088
			public Struct4(Transform transform_2, List<Transform> list_3, string string_1, ConsoleColor consoleColor_1, bool bool_3, bool bool_4, Transform transform_3 = null, int int_2 = 0)
			{
				this.transform_0 = transform_2;
				this.list_0 = list_3;
				this.string_0 = string_1;
				this.consoleColor_0 = consoleColor_1;
				this.bool_0 = bool_3;
				this.bool_1 = bool_4;
				this.transform_1 = transform_3;
				this.list_1 = new List<GClass84.GStruct136>();
				this.list_2 = new List<GClass84.GStruct146>();
				this.int_0 = 0;
				this.bool_2 = false;
				this.int_1 = int_2;
			}

			// Token: 0x04000A4A RID: 2634
			public Transform transform_0;

			// Token: 0x04000A4B RID: 2635
			public List<Transform> list_0;

			// Token: 0x04000A4C RID: 2636
			public string string_0;

			// Token: 0x04000A4D RID: 2637
			public ConsoleColor consoleColor_0;

			// Token: 0x04000A4E RID: 2638
			public bool bool_0;

			// Token: 0x04000A4F RID: 2639
			public bool bool_1;

			// Token: 0x04000A50 RID: 2640
			public Transform transform_1;

			// Token: 0x04000A51 RID: 2641
			public List<GClass84.GStruct136> list_1;

			// Token: 0x04000A52 RID: 2642
			public List<GClass84.GStruct146> list_2;

			// Token: 0x04000A53 RID: 2643
			public int int_0;

			// Token: 0x04000A54 RID: 2644
			public bool bool_2;

			// Token: 0x04000A55 RID: 2645
			public int int_1;
		}

		// Token: 0x02000158 RID: 344
		private struct Struct5
		{
			// Token: 0x06000E2E RID: 3630 RVA: 0x0004CEF8 File Offset: 0x0004B0F8
			public Struct5(Transform transform_1, int int_4, int int_5, bool bool_1 = false, string string_1 = "", int int_6 = 0)
			{
				this = new GClass145.Struct5(transform_1, int_4, int_5, 0, bool_1, string_1, int_6);
			}

			// Token: 0x06000E2F RID: 3631 RVA: 0x0004CF18 File Offset: 0x0004B118
			public Struct5(Transform transform_1, int int_4, int int_5, int int_6, bool bool_1 = false, string string_1 = "", int int_7 = 0)
			{
				this.transform_0 = transform_1;
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.bool_0 = bool_1;
				this.string_0 = string_1;
				this.int_3 = int_7;
			}

			// Token: 0x04000A56 RID: 2646
			public Transform transform_0;

			// Token: 0x04000A57 RID: 2647
			public int int_0;

			// Token: 0x04000A58 RID: 2648
			public int int_1;

			// Token: 0x04000A59 RID: 2649
			public int int_2;

			// Token: 0x04000A5A RID: 2650
			public bool bool_0;

			// Token: 0x04000A5B RID: 2651
			public string string_0;

			// Token: 0x04000A5C RID: 2652
			public int int_3;
		}

		// Token: 0x02000159 RID: 345
		private struct Struct6
		{
			// Token: 0x06000E30 RID: 3632 RVA: 0x0004CF5C File Offset: 0x0004B15C
			public Struct6(GameObject gameObject_1)
			{
				this.gameObject_0 = gameObject_1;
				this.bool_0 = false;
				this.float_0 = 0f;
			}

			// Token: 0x04000A5D RID: 2653
			public GameObject gameObject_0;

			// Token: 0x04000A5E RID: 2654
			public bool bool_0;

			// Token: 0x04000A5F RID: 2655
			public float float_0;
		}

		// Token: 0x0200015A RID: 346
		private struct Struct7
		{
			// Token: 0x06000E31 RID: 3633 RVA: 0x0004CF84 File Offset: 0x0004B184
			public Struct7(Object object_1, Object object_2)
			{
				this.object_0 = object_1;
				this.list_0 = new List<Object>
				{
					object_2
				};
			}

			// Token: 0x06000E32 RID: 3634 RVA: 0x0004CFAC File Offset: 0x0004B1AC
			public Struct7(Object object_1, List<Object> list_1)
			{
				this.object_0 = object_1;
				this.list_0 = new List<Object>();
				this.list_0.AddRange(list_1);
			}

			// Token: 0x04000A60 RID: 2656
			public Object object_0;

			// Token: 0x04000A61 RID: 2657
			public List<Object> list_0;
		}

		// Token: 0x0200015B RID: 347
		public struct GStruct102
		{
			// Token: 0x06000E33 RID: 3635 RVA: 0x0004CFD8 File Offset: 0x0004B1D8
			public static int smethod_0(List<GClass145.GStruct102> list_0, string string_2 = "", string string_3 = "")
			{
				if (string_2 != string.Empty)
				{
					for (int i = 0; i < list_0.Count; i++)
					{
						GClass145.GStruct102 gstruct = list_0[i];
						if (gstruct.string_0 == string_2)
						{
							return i;
						}
					}
				}
				else if (string_3 != string.Empty)
				{
					for (int j = 0; j < list_0.Count; j++)
					{
						GClass145.GStruct102 gstruct2 = list_0[j];
						if (gstruct2.string_1 == string_3)
						{
							return j;
						}
					}
				}
				return -1;
			}

			// Token: 0x06000E34 RID: 3636 RVA: 0x0004D06C File Offset: 0x0004B26C
			public GStruct102(string string_2, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
			}

			// Token: 0x06000E35 RID: 3637 RVA: 0x0004D088 File Offset: 0x0004B288
			public static string smethod_1(GClass145.GStruct102 gstruct102_0)
			{
				return gstruct102_0.string_0 + " " + gstruct102_0.string_1;
			}

			// Token: 0x06000E36 RID: 3638 RVA: 0x0004D0B0 File Offset: 0x0004B2B0
			public static bool smethod_2(List<GClass145.GStruct102> list_0, string string_2 = "", string string_3 = "")
			{
				if (string_2 != string.Empty)
				{
					for (int i = list_0.Count - 1; i >= 0; i--)
					{
						if (list_0[i].string_0 == string_2)
						{
							return true;
						}
					}
				}
				else if (string_3 != string.Empty)
				{
					for (int j = list_0.Count - 1; j >= 0; j--)
					{
						if (list_0[j].string_1 == string_3)
						{
							return true;
						}
					}
				}
				return false;
			}

			// Token: 0x06000E37 RID: 3639 RVA: 0x0004D144 File Offset: 0x0004B344
			public static List<string> smethod_3(List<GClass145.GStruct102> list_0)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < list_0.Count; i++)
				{
					list.Add(GClass145.GStruct102.smethod_1(list_0[i]));
				}
				return list;
			}

			// Token: 0x04000A62 RID: 2658
			public string string_0;

			// Token: 0x04000A63 RID: 2659
			public string string_1;
		}

		// Token: 0x0200015C RID: 348
		internal readonly struct Struct8 : IDisposable
		{
			// Token: 0x06000E38 RID: 3640 RVA: 0x0004D180 File Offset: 0x0004B380
			public Struct8(VRCAvatarManager vrcavatarManager_2)
			{
				this.vrcavatarManager_1 = GClass145.Struct8.vrcavatarManager_0;
				GClass145.Struct8.vrcavatarManager_0 = vrcavatarManager_2;
			}

			// Token: 0x06000E39 RID: 3641 RVA: 0x0004D1A0 File Offset: 0x0004B3A0
			public void Dispose()
			{
				GClass145.Struct8.vrcavatarManager_0 = this.vrcavatarManager_1;
			}

			// Token: 0x04000A64 RID: 2660
			internal static VRCAvatarManager vrcavatarManager_0;

			// Token: 0x04000A65 RID: 2661
			private readonly VRCAvatarManager vrcavatarManager_1;
		}

		// Token: 0x0200015D RID: 349
		private readonly struct Struct9
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
			public int Int32_0
			{
				get
				{
					return this.int_1 + this.int_0;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0004D1D4 File Offset: 0x0004B3D4
			public static IComparer<GClass145.Struct9> IComparer_0 { get; } = new GClass145.Struct9.Class81();

			// Token: 0x06000E3C RID: 3644 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
			public Struct9(GameObject gameObject_1, int int_2)
			{
				this.gameObject_0 = gameObject_1;
				this.int_1 = int_2;
				this.bool_0 = gameObject_1.activeSelf;
				this.int_0 = gameObject_1.transform.childCount;
			}

			// Token: 0x04000A66 RID: 2662
			public readonly GameObject gameObject_0;

			// Token: 0x04000A67 RID: 2663
			public readonly bool bool_0;

			// Token: 0x04000A68 RID: 2664
			public readonly int int_0;

			// Token: 0x04000A69 RID: 2665
			public readonly int int_1;

			// Token: 0x04000A6A RID: 2666
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private static readonly IComparer<GClass145.Struct9> icomparer_0;

			// Token: 0x0200015E RID: 350
			private sealed class Class81 : IComparer<GClass145.Struct9>
			{
				// Token: 0x06000E3E RID: 3646 RVA: 0x0004D238 File Offset: 0x0004B438
				public int Compare(GClass145.Struct9 struct9_0, GClass145.Struct9 struct9_1)
				{
					int num = -struct9_0.bool_0.CompareTo(struct9_1.bool_0);
					int result;
					if (num != 0)
					{
						result = num;
					}
					else
					{
						result = struct9_0.Int32_0.CompareTo(struct9_1.Int32_0);
					}
					return result;
				}
			}
		}

		// Token: 0x0200015F RID: 351
		private struct Struct10 : IDisposable
		{
			// Token: 0x06000E40 RID: 3648 RVA: 0x0004D27C File Offset: 0x0004B47C
			public Struct10(VRCAvatarManager vrcavatarManager_1, ApiAvatar apiAvatar_1)
			{
				GClass145.Struct10.vrcavatarManager_0 = vrcavatarManager_1;
				GClass145.Struct10.apiAvatar_0 = apiAvatar_1;
				GClass145.Struct10.bool_0 = true;
			}

			// Token: 0x06000E41 RID: 3649 RVA: 0x0004D29C File Offset: 0x0004B49C
			public void Dispose()
			{
				GClass145.Struct10.apiAvatar_0 = null;
				GClass145.Struct10.vrcavatarManager_0 = null;
				GClass145.Struct10.bool_0 = false;
			}

			// Token: 0x04000A6B RID: 2667
			internal static bool bool_0;

			// Token: 0x04000A6C RID: 2668
			internal static VRCAvatarManager vrcavatarManager_0;

			// Token: 0x04000A6D RID: 2669
			internal static ApiAvatar apiAvatar_0;
		}

		// Token: 0x02000160 RID: 352
		internal struct Struct11
		{
			// Token: 0x04000A6E RID: 2670
			public IntPtr intptr_0;

			// Token: 0x04000A6F RID: 2671
			public IntPtr intptr_1;

			// Token: 0x04000A70 RID: 2672
			public IntPtr intptr_2;

			// Token: 0x04000A71 RID: 2673
			public int int_0;

			// Token: 0x04000A72 RID: 2674
			public uint uint_0;
		}

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x06000E44 RID: 3652
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate12(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x06000E48 RID: 3656
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate13(ref IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4);

		// Token: 0x02000163 RID: 355
		private struct Struct12
		{
			// Token: 0x04000A73 RID: 2675
			public unsafe GClass145.Struct11* pStruct11_0;
		}

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x06000E4A RID: 3658
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate14(IntPtr intptr_0, uint uint_0, ulong ulong_0);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x06000E4F RID: 3663
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate15(IntPtr intptr_0, uint uint_0, uint uint_1);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x06000E52 RID: 3666
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate16(IntPtr intptr_0, uint uint_0, uint uint_1);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x06000E58 RID: 3672
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate17(IntPtr intptr_0, uint uint_0);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x06000E5C RID: 3676
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate18(IntPtr intptr_0, uint uint_0);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x06000E60 RID: 3680
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate19(IntPtr intptr_0, long long_0, long long_1);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x06000E64 RID: 3684
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate20(IntPtr intptr_0);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x06000E67 RID: 3687
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate long Delegate21(GClass145.Struct13* pStruct13_0);

		// Token: 0x0200016C RID: 364
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		private struct Struct13
		{
			// Token: 0x04000A74 RID: 2676
			[FieldOffset(112)]
			public unsafe GClass145.Struct13** ppStruct13_0;

			// Token: 0x04000A75 RID: 2677
			[FieldOffset(128)]
			public long long_0;
		}

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x06000E6A RID: 3690
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate void Delegate22(GClass145.Struct14* pStruct14_0, long long_0);

		// Token: 0x0200016E RID: 366
		private struct Struct14
		{
			// Token: 0x04000A76 RID: 2678
			public IntPtr intptr_0;

			// Token: 0x04000A77 RID: 2679
			public long long_0;

			// Token: 0x04000A78 RID: 2680
			public long long_1;

			// Token: 0x04000A79 RID: 2681
			public long long_2;
		}

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x06000E70 RID: 3696
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate23(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000E72 RID: 3698
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate void Delegate24(IntPtr intptr_0, float* pFloat_0, byte* pByte_0);

		// Token: 0x02000171 RID: 369
		private enum Enum2
		{
			// Token: 0x04000A7B RID: 2683
			const_0,
			// Token: 0x04000A7C RID: 2684
			const_1
		}

		// Token: 0x02000172 RID: 370
		[CompilerGenerated]
		private sealed class Class82
		{
			// Token: 0x06000E77 RID: 3703 RVA: 0x0004D2BC File Offset: 0x0004B4BC
			internal IntPtr method_0(IntPtr intptr_0, Vector3 vector3_0, Quaternion quaternion_0, byte byte_0, byte byte_1, byte byte_2, IntPtr intptr_1)
			{
				return GClass145.smethod_59(intptr_0, vector3_0, quaternion_0, byte_0, byte_1, byte_2, intptr_1, this.delegate11_0);
			}

			// Token: 0x04000A7D RID: 2685
			public GClass145.Delegate11 delegate11_0;
		}

		// Token: 0x02000173 RID: 371
		[CompilerGenerated]
		private sealed class Class83
		{
			// Token: 0x04000A7E RID: 2686
			public int int_0;
		}

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		private sealed class Class84
		{
			// Token: 0x06000E7A RID: 3706 RVA: 0x0004D2E0 File Offset: 0x0004B4E0
			internal unsafe void method_0(IntPtr intptr_0, IntPtr intptr_1)
			{
				IntPtr intPtr = *(IntPtr*)((void*)(intptr_0 + this.class83_0.int_0 - 16));
				using (new GClass145.Struct8(new VRCAvatarManager(intPtr)))
				{
					this.delegate10_0(intptr_0, intptr_1);
				}
			}

			// Token: 0x04000A7F RID: 2687
			public GClass145.Delegate10 delegate10_0;

			// Token: 0x04000A80 RID: 2688
			public GClass145.Class83 class83_0;
		}

		// Token: 0x02000175 RID: 373
		[CompilerGenerated]
		[Serializable]
		private sealed class Class85
		{
			// Token: 0x06000E7B RID: 3707 RVA: 0x0004D348 File Offset: 0x0004B548
			internal bool method_0(PropertyInfo propertyInfo_0)
			{
				return propertyInfo_0.PropertyType == typeof(VRCAvatarManager);
			}

			// Token: 0x06000E7C RID: 3708 RVA: 0x0004D36C File Offset: 0x0004B56C
			internal string method_1(ParameterInfo parameterInfo_0)
			{
				return parameterInfo_0.ParameterType.ToString();
			}

			// Token: 0x06000E7D RID: 3709 RVA: 0x0004D384 File Offset: 0x0004B584
			internal bool method_2(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name.StartsWith("Method_Public_Static_Object_Object_Vector3_Quaternion_Boolean_Boolean_Boolean_") && methodInfo_0.GetParameters().Length == 6;
			}

			// Token: 0x06000E7E RID: 3710 RVA: 0x0004D3B4 File Offset: 0x0004B5B4
			internal bool method_3(MethodInfo methodInfo_0)
			{
				return methodInfo_0.Name.StartsWith("Method_Public_Boolean_APIUser_byref_EnumPublicSealedva5vUnique_") && methodInfo_0.GetCustomAttribute<CallerCountAttribute>().Count > 0;
			}

			// Token: 0x06000E80 RID: 3712 RVA: 0x0004D3FC File Offset: 0x0004B5FC
			internal void method_4(Scene scene_0)
			{
				if (scene_0.buildIndex == -1)
				{
					GClass145.bool_166 = true;
					GClass145.bool_167 = true;
				}
			}

			// Token: 0x06000E82 RID: 3714 RVA: 0x0004D424 File Offset: 0x0004B624
			internal void method_5(Scene scene_0, LoadSceneMode loadSceneMode_0)
			{
				if (scene_0.buildIndex == -1)
				{
					GClass145.bool_166 = false;
					GClass145.bool_167 = false;
				}
			}

			// Token: 0x04000A81 RID: 2689
			public static readonly GClass145.Class85 class85_0 = new GClass145.Class85();

			// Token: 0x04000A82 RID: 2690
			public static Func<MethodInfo, bool> func_0;

			// Token: 0x04000A83 RID: 2691
			public static Func<PropertyInfo, bool> func_1;

			// Token: 0x04000A84 RID: 2692
			public static Func<MethodInfo, bool> func_2;

			// Token: 0x04000A85 RID: 2693
			public static Action<Scene, LoadSceneMode> action_0;

			// Token: 0x04000A86 RID: 2694
			public static Action<Scene> action_1;

			// Token: 0x04000A87 RID: 2695
			public static Func<ParameterInfo, string> func_3;
		}
	}
}
