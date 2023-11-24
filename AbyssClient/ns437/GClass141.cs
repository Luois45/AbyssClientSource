using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using ns185;
using ns241;
using ns425;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

namespace ns437
{
	// Token: 0x02000119 RID: 281
	public class GClass141 : GClass130
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00023470 File Offset: 0x00021670
		internal List<GameObject> method_2()
		{
			List<GameObject> list = new List<GameObject>
			{
				this.method_87()
			};
			list.AddRange(this.method_112());
			return list;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000234A0 File Offset: 0x000216A0
		internal GameObject method_3(string string_13)
		{
			string a = this.method_195(string_13);
			if (a != string.Empty)
			{
				GameObject gameObject = this.method_73();
				if (gameObject)
				{
					return GClass84.smethod_138(gameObject, a);
				}
			}
			return null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000234E4 File Offset: 0x000216E4
		internal bool method_4(string string_13)
		{
			GameObject gameObject = this.method_179(string_13);
			return gameObject && GClass84.gclass179_0.method_43(gameObject.GetComponent<UdonBehaviour>(), "SyncKill", 0.5f, true, false, false, null);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00023528 File Offset: 0x00021728
		internal void method_5()
		{
			this.method_147();
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0002353C File Offset: 0x0002173C
		internal void method_6()
		{
			this.method_45();
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00023550 File Offset: 0x00021750
		internal void method_7(bool bool_11)
		{
			this.method_192(bool_11);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00023564 File Offset: 0x00021764
		internal void method_8(bool bool_11)
		{
			this.method_128(bool_11);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00023578 File Offset: 0x00021778
		internal List<GameObject> method_9()
		{
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < this.string_8.Length; i++)
			{
				GameObject gameObject = GameObject.Find(this.string_8[i]);
				if (gameObject)
				{
					list.Add(gameObject);
				}
			}
			return list;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000235C4 File Offset: 0x000217C4
		internal void method_10()
		{
			this.method_69();
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000235D8 File Offset: 0x000217D8
		internal void method_11()
		{
			this.method_176();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000235EC File Offset: 0x000217EC
		internal bool method_12()
		{
			return GClass84.smethod_909(this.method_209(), "SyncVictoryM", false);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002360C File Offset: 0x0002180C
		internal void method_13()
		{
			this.method_129();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00023620 File Offset: 0x00021820
		internal bool method_14()
		{
			return GClass84.gclass179_0.method_18("SyncOpenL");
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002363C File Offset: 0x0002183C
		internal void method_15()
		{
			GClass84.smethod_1683(ref this.highlightsFXStandalone_0, this.color_0);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_1, this.color_1);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_2, this.color_2);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_3, this.color_3);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_4, this.color_4);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_5, this.color_5);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_6, this.color_6);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_7, this.color_7);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_8, this.color_8);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_9, this.color_9);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_10, this.color_10);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_11, this.color_11);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_12, this.color_12);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_13, this.color_13);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_14, this.color_14);
			GClass84.smethod_1683(ref this.highlightsFXStandalone_15, this.color_15);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002375C File Offset: 0x0002195C
		internal void method_16()
		{
			this.method_182();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00023770 File Offset: 0x00021970
		internal bool method_17(string string_13)
		{
			return GClass84.smethod_909(this.method_3(string_13), "SyncVotedOut", false);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00023790 File Offset: 0x00021990
		internal bool method_18(Vector3 vector3_0)
		{
			bool result = false;
			List<GameObject> list = this.method_30();
			for (int i = 0; i < list.Count; i++)
			{
				if (GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000237CC File Offset: 0x000219CC
		internal bool method_19()
		{
			this.list_20.Clear();
			List<GameObject> list = this.method_178();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					this.list_20.AddRange(list[i].GetComponentsInChildren<MeshRenderer>());
				}
			}
			return this.list_20.Count > 0;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00023834 File Offset: 0x00021A34
		internal bool method_20()
		{
			this.list_21.Clear();
			List<GameObject> list = this.method_9();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					GameObject gameObject = GClass84.smethod_138(list[i], "Recoil Anim/Recoil/geo");
					if (!gameObject)
					{
						gameObject = GClass84.smethod_138(list[i], "Intact/frag geo");
					}
					if (gameObject)
					{
						this.list_21.Add(gameObject.GetComponent<MeshRenderer>());
					}
				}
			}
			return this.list_21.Count > 0;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000238D0 File Offset: 0x00021AD0
		internal void method_21()
		{
			this.method_70();
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000238E4 File Offset: 0x00021AE4
		internal List<GameObject> method_22()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Weapons");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				List<GameObject> list2 = GClass84.smethod_94(gameObject);
				for (int i = 0; i < list2.Count; i++)
				{
					for (int j = 0; j < this.string_6.Length; j++)
					{
						if (GClass84.smethod_1428(list2[i].name, GClass84.smethod_593(this.string_6[j])) == this.string_6[j])
						{
							list.Add(list2[i]);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00023984 File Offset: 0x00021B84
		internal bool method_23(string string_13)
		{
			return GClass84.smethod_909(this.method_179(string_13), "SyncAssignD", false);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000239A4 File Offset: 0x00021BA4
		internal void method_24(GameObject gameObject_9)
		{
			this.method_187(gameObject_9);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000239B8 File Offset: 0x00021BB8
		internal bool method_25(Vector3 vector3_0)
		{
			bool result = false;
			List<GameObject> list = this.method_22();
			for (int i = 0; i < list.Count; i++)
			{
				if (GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000239F4 File Offset: 0x00021BF4
		internal void method_26(bool bool_11)
		{
			this.method_181(bool_11);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00023A08 File Offset: 0x00021C08
		internal void method_27(bool bool_11)
		{
			this.method_102(bool_11);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00023A1C File Offset: 0x00021C1C
		internal bool method_28()
		{
			return GClass84.gclass179_0.method_18("ResetDoor");
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00023A38 File Offset: 0x00021C38
		internal bool method_29(GameObject gameObject_9)
		{
			return GClass84.smethod_909(this.method_210(gameObject_9), "SyncKill", false);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00023A58 File Offset: 0x00021C58
		internal List<GameObject> method_30()
		{
			List<GameObject> list = this.method_9();
			list.AddRange(this.method_157());
			return list;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00023A7C File Offset: 0x00021C7C
		internal void method_31()
		{
			this.method_66();
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00023A90 File Offset: 0x00021C90
		internal List<GameObject> method_32()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Snakes/Snake/Snake Geo/snake");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				List<GameObject> list2 = GClass84.smethod_94(gameObject);
				for (int i = 0; i < list2.Count; i++)
				{
					for (int j = this.string_12.Length - 1; j >= 0; j--)
					{
						if (GClass84.smethod_1428(list2[i].name, GClass84.smethod_593(this.string_12[j])) == this.string_12[j])
						{
							list.Add(list2[i]);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00023B38 File Offset: 0x00021D38
		internal void method_33(bool bool_11)
		{
			this.bool_5 = bool_11;
			for (int i = this.list_12.Count - 1; i >= 0; i--)
			{
				if (this.list_12[i])
				{
					GClass84.smethod_590(this.list_12[i], false, ref this.highlightsFXStandalone_1);
				}
			}
			this.list_11.Clear();
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00023BA4 File Offset: 0x00021DA4
		internal void method_34()
		{
			this.method_86();
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00023BB8 File Offset: 0x00021DB8
		internal bool method_35(GameObject gameObject_9)
		{
			return GClass84.smethod_909(this.method_210(gameObject_9), "SyncAssignB", false);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00023BD8 File Offset: 0x00021DD8
		internal List<GameObject> method_36()
		{
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < this.string_5.Length; i++)
			{
				GameObject gameObject = GameObject.Find(this.string_5[i]);
				if (gameObject)
				{
					list.Add(gameObject);
				}
			}
			return list;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00023C24 File Offset: 0x00021E24
		internal void method_37()
		{
			this.list_1.Clear();
			this.list_2.Clear();
			this.list_3.Clear();
			int i = 0;
			while (i < this.string_1.Length)
			{
				GameObject gameObject = GameObject.Find(this.string_1[i]);
				if (gameObject)
				{
					GameObject gameObject2 = GameObject.Find(this.string_1[i] + this.string_2);
					if (gameObject2)
					{
						this.list_1.Add(gameObject);
						this.list_2.Add(gameObject2);
						GameObject gameObject3 = new GameObject();
						gameObject3.transform.parent = gameObject.transform;
						gameObject3.transform.localPosition = gameObject2.transform.localPosition;
						gameObject3.transform.localRotation = gameObject2.transform.localRotation;
						gameObject3.transform.localScale = gameObject2.transform.localScale;
						gameObject3.AddComponent<MeshFilter>();
						gameObject3.AddComponent<MeshRenderer>();
						MeshFilter component = gameObject3.GetComponent<MeshFilter>();
						MeshRenderer component2 = gameObject3.GetComponent<MeshRenderer>();
						component.mesh = gameObject2.GetComponent<MeshFilter>().mesh;
						component2.material = Object.Instantiate<Material>(gameObject2.GetComponent<MeshRenderer>().material);
						component2.enabled = false;
						gameObject3.name = gameObject2.name + "_" + "ESP";
						this.list_3.Add(gameObject3);
						i++;
						continue;
					}
					this.list_1.Clear();
					this.list_2.Clear();
					this.list_3.Clear();
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Murder",
						"2",
						"_",
						"Get",
						"Clues",
						"(): ",
						this.string_1[i],
						this.string_2,
						" ",
						"Not",
						" ",
						"Found",
						"!"
					}), GClass70.Enum1.const_0);
					this.bool_0 = false;
				}
				else
				{
					this.list_1.Clear();
					this.list_2.Clear();
					this.list_3.Clear();
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Murder",
						"2",
						"_",
						"Get",
						"Clues",
						"(): ",
						this.string_1[i],
						" ",
						"Not",
						" ",
						"Found",
						"!"
					}), GClass70.Enum1.const_0);
					this.bool_0 = false;
				}
				return;
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00023EEC File Offset: 0x000220EC
		internal void method_38()
		{
			this.method_6();
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00023F00 File Offset: 0x00022100
		internal void method_39()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				if (!this.list_0[i])
				{
					this.list_0.RemoveAt(i);
				}
				else
				{
					this.list_0[i].enabled = true;
				}
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00023F60 File Offset: 0x00022160
		internal bool method_40()
		{
			this.list_25.Clear();
			List<GameObject> list = this.method_202();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					this.list_25.Add(list[i].GetComponent<MeshRenderer>());
				}
			}
			list = this.method_198();
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j])
				{
					this.list_25.Add(list[j].GetComponent<SkinnedMeshRenderer>());
				}
			}
			return this.list_25.Count > 0;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00024010 File Offset: 0x00022210
		internal void method_41()
		{
			this.method_80();
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00024024 File Offset: 0x00022224
		internal void method_42(bool bool_11)
		{
			this.bool_0 = bool_11;
			for (int i = this.list_4.Count - 1; i >= 0; i--)
			{
				if (this.list_4[i])
				{
					GClass84.smethod_590(this.list_4[i], false, ref this.highlightsFXStandalone_0);
				}
			}
			this.list_4.Clear();
			for (int j = this.list_6.Count - 1; j >= 0; j--)
			{
				if (this.list_6[j])
				{
					GClass84.smethod_590(this.list_6[j], false, ref this.highlightsFXStandalone_0);
				}
			}
			this.list_6.Clear();
			for (int k = this.list_8.Count - 1; k >= 0; k--)
			{
				if (this.list_8[k])
				{
					GClass84.smethod_590(this.list_8[k], false, ref this.highlightsFXStandalone_0);
				}
			}
			this.list_8.Clear();
			if (this.bool_0)
			{
				this.method_106();
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00024150 File Offset: 0x00022350
		internal bool method_43()
		{
			this.list_24.Clear();
			List<GameObject> list = this.method_2();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					this.list_24.Add(list[i].GetComponent<MeshRenderer>());
				}
			}
			return this.list_24.Count > 0;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000241B8 File Offset: 0x000223B8
		internal bool method_44(Vector3 vector3_0)
		{
			bool result = false;
			List<GameObject> list = this.method_157();
			for (int i = 0; i < list.Count; i++)
			{
				if (GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000241F4 File Offset: 0x000223F4
		internal void method_45()
		{
			if (!this.gameObject_1)
			{
				if (!this.gameObject_0)
				{
					this.gameObject_0 = GameObject.Find("/Game Logic/Game Canvas/Game In Progress/Player List");
				}
				if (!this.gameObject_0)
				{
					this.list_13.Clear();
					this.list_16.Clear();
					this.list_15.Clear();
					this.gameObject_1 = null;
					GClass70.smethod_38("HackForAmongUs(): AmongUs_PlayerList Not Found!", GClass70.Enum1.const_0);
					this.bool_7 = false;
					return;
				}
				this.gameObject_1 = GClass84.smethod_138(this.gameObject_0, "Player List Group");
				if (!this.gameObject_1)
				{
					this.list_13.Clear();
					this.list_16.Clear();
					this.list_15.Clear();
					GClass70.smethod_38("HackForAmongUs(): AmongUs_PlayerListGroup Not Found!", GClass70.Enum1.const_0);
					this.bool_7 = false;
					return;
				}
			}
			this.list_13.Clear();
			this.list_16.Clear();
			GClass84.smethod_1233<MeshRenderer>(this.list_15);
			if (this.gameObject_1.activeInHierarchy)
			{
				GameObject[] array = GClass84.smethod_1034(this.gameObject_1);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] && array[i].activeInHierarchy)
					{
						Transform transform = GClass84.smethod_830(array[i], "Player Name Text");
						if (transform)
						{
							Text component = transform.GetComponent<Text>();
							if (component)
							{
								string text = component.text;
								Image component2 = array[i].GetComponent<Image>();
								if (component2 && (component2.m_Color.r > component2.m_Color.g && component2.m_Color.r > component2.m_Color.b))
								{
									this.list_16.Add(text);
								}
								int num = GClass84.smethod_1635(array[i].name, " ");
								if (num != -1)
								{
									this.list_14.Add(new GClass84.GStruct153(GClass84.smethod_1204(array[i].name, num + 1, -1), text));
								}
							}
						}
					}
				}
				List<VRCPlayerApi> allPlayers = VRCPlayerApi.AllPlayers;
				for (int j = 0; j < allPlayers.Count; j++)
				{
					Transform transform2 = allPlayers[j].gameObject.transform.FindChild("SelectRegion");
					MeshRenderer meshRenderer = null;
					if (transform2)
					{
						meshRenderer = transform2.GetComponent<MeshRenderer>();
					}
					if (this.list_16.Contains(allPlayers[j].displayName))
					{
						this.list_13.Add(allPlayers[j]);
						if (meshRenderer)
						{
							GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_2);
							GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_3);
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_15, meshRenderer))
							{
								this.list_15.Add(meshRenderer);
							}
						}
					}
					else if (meshRenderer)
					{
						GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_2);
						GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_3);
						if (!GClass84.smethod_1224<MeshRenderer>(this.list_15, meshRenderer))
						{
							this.list_15.Add(meshRenderer);
						}
					}
				}
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00024544 File Offset: 0x00022744
		internal void method_46()
		{
			int num = 0;
			while (num < this.list_7.Count && this.list_7[num])
			{
				VRC_Trigger component = this.list_7[num].GetComponent<VRC_Trigger>();
				if (!component)
				{
					break;
				}
				foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
				{
					if (triggerEvent.TriggerType == 0 && triggerEvent.Name == "FireCooldown")
					{
						triggerEvent.AfterSeconds = 0f;
					}
				}
				num++;
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000245F4 File Offset: 0x000227F4
		internal void method_47()
		{
			this.list_8.Clear();
			for (int i = 0; i < this.list_7.Count; i++)
			{
				if (this.list_7[i])
				{
					MeshRenderer componentInChildren = this.list_7[i].GetComponentInChildren<MeshRenderer>();
					if (componentInChildren)
					{
						this.list_8.Add(componentInChildren);
					}
				}
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00024660 File Offset: 0x00022860
		internal void method_48()
		{
			this.method_203();
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00024674 File Offset: 0x00022874
		internal bool method_49(Vector3 vector3_0)
		{
			bool result = false;
			List<GameObject> list = this.method_177();
			for (int i = 0; i < list.Count; i++)
			{
				if (GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000246B0 File Offset: 0x000228B0
		internal void method_50()
		{
			this.method_34();
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000246C4 File Offset: 0x000228C4
		internal string method_51(string string_13)
		{
			return this.method_211(string_13);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000246D8 File Offset: 0x000228D8
		internal void method_52(Transform transform_0)
		{
			if (transform_0)
			{
				this.method_24(transform_0.gameObject);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000246FC File Offset: 0x000228FC
		internal GameObject method_53()
		{
			if (!this.gameObject_8)
			{
				this.gameObject_8 = GameObject.Find("/Udon/Teleports");
			}
			return this.gameObject_8;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00024734 File Offset: 0x00022934
		internal string method_54(string string_13)
		{
			return this.method_100(string_13);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00024748 File Offset: 0x00022948
		internal void method_55()
		{
			this.method_78();
			if (this.bool_10)
			{
				this.method_135();
			}
			if (this.bool_9)
			{
				this.method_172();
			}
			if (this.list_17.Count == 0 || !this.list_17[0])
			{
				this.method_143();
			}
			if (this.list_18.Count == 0 || !this.list_18[0])
			{
				this.method_154();
			}
			if (this.list_19.Count == 0 || !this.list_19[0])
			{
				this.method_77();
			}
			if (this.list_20.Count == 0 || !this.list_20[0])
			{
				this.method_19();
			}
			if (this.list_21.Count == 0 || !this.list_21[0])
			{
				this.method_20();
			}
			if (this.list_22.Count == 0 || !this.list_22[0])
			{
				this.method_207();
			}
			if (this.list_23.Count == 0 || !this.list_23[0])
			{
				this.method_60();
			}
			if (this.list_24.Count == 0 || !this.list_24[0])
			{
				this.method_43();
			}
			if (this.list_25.Count == 0 || !this.list_25[0])
			{
				this.method_40();
			}
			if (this.list_26.Count == 0 || !this.list_26[0])
			{
				this.method_138();
			}
			for (int i = this.list_17.Count - 1; i >= 0; i--)
			{
				if (this.list_17[i])
				{
					GClass84.smethod_590(this.list_17[i], true, ref this.highlightsFXStandalone_4);
				}
			}
			for (int j = this.list_18.Count - 1; j >= 0; j--)
			{
				if (this.list_18[j])
				{
					GClass84.smethod_590(this.list_18[j], true, ref this.highlightsFXStandalone_9);
				}
			}
			for (int k = this.list_19.Count - 1; k >= 0; k--)
			{
				if (this.list_19[k])
				{
					GClass84.smethod_590(this.list_19[k], true, ref this.highlightsFXStandalone_10);
				}
			}
			for (int l = this.list_21.Count - 1; l >= 0; l--)
			{
				if (this.list_21[l])
				{
					GClass84.smethod_590(this.list_21[l], true, ref this.highlightsFXStandalone_11);
				}
			}
			for (int m = this.list_22.Count - 1; m >= 0; m--)
			{
				if (this.list_22[m])
				{
					GClass84.smethod_590(this.list_22[m], true, ref this.highlightsFXStandalone_12);
				}
			}
			for (int n = this.list_24.Count - 1; n >= 0; n--)
			{
				if (this.list_24[n])
				{
					GClass84.smethod_590(this.list_24[n], true, ref this.highlightsFXStandalone_13);
				}
			}
			for (int num = this.list_25.Count - 1; num >= 0; num--)
			{
				if (this.list_25[num])
				{
					GClass84.smethod_590(this.list_25[num], true, ref this.highlightsFXStandalone_14);
				}
			}
			for (int num2 = this.list_26.Count - 1; num2 >= 0; num2--)
			{
				if (this.list_26[num2] && !this.list_26[num2].activeSelf)
				{
					this.list_26[num2].SetActive(true);
				}
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00024BD0 File Offset: 0x00022DD0
		internal void method_56()
		{
			this.method_15();
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00024BE4 File Offset: 0x00022DE4
		internal bool method_57(GameObject gameObject_9)
		{
			return GClass84.smethod_909(this.method_210(gameObject_9), "SyncAssignD", false);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00024C04 File Offset: 0x00022E04
		internal void method_58()
		{
			this.method_161();
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00024C18 File Offset: 0x00022E18
		internal void method_59()
		{
			GameObject gameObject = this.method_191();
			if (!gameObject)
			{
				GClass70.smethod_38("Murder4_KillEveryone(): Murder4_PlayerNodesNot Found!", GClass70.Enum1.const_0);
			}
			bool flag = false;
			Transform[] array = GClass84.smethod_731(gameObject);
			for (int i = 0; i < array.Length; i++)
			{
				UdonBehaviour component = array[i].GetComponent<UdonBehaviour>();
				if (component)
				{
					List<string> list = GClass84.smethod_16(component);
					for (int j = 0; j < list.Count; j++)
					{
						if (list[j] == "SyncKill" && GClass84.smethod_986(component, list[j], false))
						{
							flag = true;
						}
					}
				}
			}
			if (!flag)
			{
				GClass70.smethod_38("Murder4_KillEveryone(): Something Went Wrong!", GClass70.Enum1.const_0);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00024CD0 File Offset: 0x00022ED0
		internal bool method_60()
		{
			this.list_23.Clear();
			List<GameObject> list = this.method_30();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					GameObject gameObject = GClass84.smethod_138(list[i], "Recoil Anim/Recoil/geo");
					if (!gameObject)
					{
						gameObject = GClass84.smethod_138(list[i], "Intact/frag geo");
					}
					if (gameObject)
					{
						this.list_23.Add(gameObject.GetComponent<MeshRenderer>());
					}
				}
			}
			return this.list_23.Count > 0;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00024D6C File Offset: 0x00022F6C
		internal bool method_61(string string_13)
		{
			return GClass84.smethod_909(this.method_179(string_13), "SyncCluesFinished", false);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00024D8C File Offset: 0x00022F8C
		internal bool method_62(GameObject gameObject_9)
		{
			return GClass84.smethod_909(this.method_210(gameObject_9), "SyncAssignM", false);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00024DAC File Offset: 0x00022FAC
		internal void method_63(Transform transform_0)
		{
			this.method_76(transform_0);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00024DC0 File Offset: 0x00022FC0
		internal bool method_64()
		{
			return GClass84.gclass179_0.method_18("SyncOpen");
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00024DDC File Offset: 0x00022FDC
		internal void method_65(bool bool_11)
		{
			this.bool_1 = bool_11;
			for (int i = 0; i < this.list_7.Count; i++)
			{
				if (this.list_7[i])
				{
					Collider component = this.list_7[i].GetComponent<Collider>();
					if (component)
					{
						this.list_0.Add(component);
					}
				}
			}
			for (int j = 0; j < this.list_5.Count; j++)
			{
				if (this.list_5[j])
				{
					Collider component2 = this.list_5[j].GetComponent<Collider>();
					if (component2)
					{
						this.list_0.Add(component2);
					}
				}
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00024EA4 File Offset: 0x000230A4
		internal void method_66()
		{
			this.method_163();
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00024EB8 File Offset: 0x000230B8
		internal bool method_67(string string_13)
		{
			return GClass84.smethod_909(this.method_179(string_13), "SyncKill", false);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00024ED8 File Offset: 0x000230D8
		internal bool method_68()
		{
			return GClass84.gclass179_0.method_18("SyncClose");
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00024EF4 File Offset: 0x000230F4
		internal void method_69()
		{
			GameObject gameObject = this.method_73();
			if (!gameObject)
			{
				GClass70.smethod_38("AmongUs_KillEveryone(): AmongUs_PlayerNodes Not Found!", GClass70.Enum1.const_0);
			}
			else
			{
				Transform[] array = GClass84.smethod_731(gameObject);
				bool flag = false;
				for (int i = 0; i < array.Length; i--)
				{
					UdonBehaviour component = array[i].GetComponent<UdonBehaviour>();
					if (component)
					{
						List<string> list = GClass84.smethod_16(component);
						for (int j = 0; j < list.Count; j++)
						{
							if (list[j] == "Btn_Kill" && GClass84.smethod_986(component, list[j], false))
							{
								flag = true;
							}
						}
					}
				}
				if (!flag)
				{
					GClass70.smethod_38("AmongUs_KillEveryone(): Something Went Wrong!", GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00024FB0 File Offset: 0x000231B0
		internal void method_70()
		{
			this.method_144();
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00024FC4 File Offset: 0x000231C4
		internal void method_71()
		{
			this.list_10.Clear();
			for (int i = 0; i < this.list_9.Count; i++)
			{
				if (this.list_9[i])
				{
					List<MeshRenderer> list = this.list_9[i].GetComponents<MeshRenderer>().ToList<MeshRenderer>();
					list.AddRange(this.list_9[i].GetComponentsInChildren<MeshRenderer>(true));
					for (int j = 0; j < list.Count; j++)
					{
						this.list_10.Add(list[j]);
					}
				}
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00025060 File Offset: 0x00023260
		internal bool method_72(GameObject gameObject_9)
		{
			GameObject gameObject = this.method_210(gameObject_9);
			return gameObject && GClass84.gclass179_0.method_43(gameObject.GetComponent<UdonBehaviour>(), "SyncKill", 0.5f, true, false, false, null);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000250A4 File Offset: 0x000232A4
		internal GameObject method_73()
		{
			if (!this.gameObject_3)
			{
				this.gameObject_3 = GameObject.Find("/Game Logic/Player Nodes");
			}
			return this.gameObject_3;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000250DC File Offset: 0x000232DC
		internal void method_74()
		{
			this.method_168();
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000250F0 File Offset: 0x000232F0
		internal void method_75()
		{
			this.method_92();
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00025104 File Offset: 0x00023304
		internal void method_76(Transform transform_0)
		{
			this.method_52(transform_0);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00025118 File Offset: 0x00023318
		internal bool method_77()
		{
			this.list_19.Clear();
			List<GameObject> list = this.method_177();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					this.list_19.AddRange(list[i].GetComponentsInChildren<MeshRenderer>());
				}
			}
			return this.list_19.Count > 0;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00025180 File Offset: 0x00023380
		internal void method_78()
		{
			this.method_107();
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00025194 File Offset: 0x00023394
		public override void vmethod_23()
		{
			this.method_162();
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000251A8 File Offset: 0x000233A8
		internal void method_79(bool bool_11)
		{
			this.method_8(bool_11);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000251BC File Offset: 0x000233BC
		internal void method_80()
		{
			for (int i = 0; i < this.list_27.Count; i++)
			{
				if (!this.list_27[i])
				{
					this.list_27.RemoveAt(i);
					i--;
				}
				else
				{
					this.list_27[i].pickupable = true;
				}
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0002521C File Offset: 0x0002341C
		internal void method_81()
		{
			this.method_167();
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00025230 File Offset: 0x00023430
		internal void method_82()
		{
			this.method_166();
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00025244 File Offset: 0x00023444
		internal void method_83()
		{
			if (this.bool_0)
			{
				this.method_106();
			}
			if (this.bool_8)
			{
				this.method_13();
			}
			if (this.bool_1)
			{
				this.method_16();
			}
			if (this.bool_2)
			{
				this.method_99();
			}
			if (this.bool_7)
			{
				this.method_38();
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00025298 File Offset: 0x00023498
		internal bool method_84(string string_13)
		{
			GameObject gameObject = this.method_3(string_13);
			return gameObject && GClass84.gclass179_0.method_43(gameObject.GetComponent<UdonBehaviour>(), "Btn_Kill", 0.5f, true, false, false, null);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000252DC File Offset: 0x000234DC
		internal void method_85()
		{
			for (int i = 0; i < this.list_7.Count; i++)
			{
				this.method_24(this.list_7[i]);
				this.method_63(GClass84.smethod_830(this.list_7[i], "ResetPickup"));
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00025330 File Offset: 0x00023530
		internal void method_86()
		{
			this.list_4.Clear();
			for (int i = 0; i < this.list_3.Count; i++)
			{
				if (this.list_3[i])
				{
					MeshRenderer componentInChildren = this.list_3[i].GetComponentInChildren<MeshRenderer>();
					if (componentInChildren)
					{
						this.list_4.Add(componentInChildren);
					}
				}
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002539C File Offset: 0x0002359C
		internal GameObject method_87()
		{
			return GameObject.Find("Game Logic/Polaroids Unlock Camera/FlashCamera/camera geo");
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000253B8 File Offset: 0x000235B8
		internal void method_88(bool bool_11)
		{
			this.method_65(bool_11);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000253CC File Offset: 0x000235CC
		internal string method_89(string string_13)
		{
			return this.method_54(string_13);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000253E0 File Offset: 0x000235E0
		internal void method_90()
		{
			this.list_5.Clear();
			for (int i = 0; i < this.string_3.Length; i++)
			{
				GameObject gameObject = GameObject.Find(this.string_3[i]);
				if (!gameObject)
				{
					this.list_5.Clear();
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Murder",
						"2",
						"_",
						"Get",
						"Knives",
						"(): ",
						this.string_3[i],
						" ",
						"Not",
						" ",
						"Found",
						"!"
					}), GClass70.Enum1.const_0);
					this.bool_0 = false;
					return;
				}
				this.list_5.Add(gameObject);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000254C4 File Offset: 0x000236C4
		internal void method_91(bool bool_11)
		{
			this.method_136(bool_11);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000254D8 File Offset: 0x000236D8
		internal void method_92()
		{
			this.list_11.Clear();
			GameObject[] array = GClass84.smethod_1142();
			for (int i = 0; i < array.Length; i++)
			{
				VRC_Trigger component = array[i].GetComponent<VRC_Trigger>();
				if (this.method_121(component))
				{
					this.list_11.Add(component.gameObject);
				}
				else
				{
					VRC_Trigger[] array2 = array[i].GetComponentsInChildren<VRC_Trigger>(true);
					for (int j = 0; j < array2.Length; j++)
					{
						if (this.method_121(array2[j]))
						{
							this.list_11.Add(array2[j].gameObject);
						}
					}
				}
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00025574 File Offset: 0x00023774
		internal void method_93()
		{
			if (this.list_1.Count == 0 || !this.list_1[0] || this.list_2.Count == 0 || !this.list_2[0] || this.list_3.Count == 0 || !this.list_3[0])
			{
				this.method_171();
			}
			if (this.list_4.Count == 0 || !this.list_4[0])
			{
				this.method_50();
			}
			if (this.list_5.Count == 0 || !this.list_5[0])
			{
				this.method_74();
			}
			if (this.list_6.Count == 0 || !this.list_6[0])
			{
				this.method_21();
			}
			if (this.list_7.Count == 0 || !this.list_7[0])
			{
				this.method_152();
			}
			if (this.list_8.Count == 0 || !this.list_8[0])
			{
				this.method_204();
			}
			for (int i = this.list_4.Count - 1; i >= 0; i--)
			{
				if (this.list_4[i])
				{
					GClass84.smethod_590(this.list_4[i], true, ref this.highlightsFXStandalone_0);
				}
			}
			for (int j = this.list_6.Count - 1; j >= 0; j--)
			{
				if (this.list_6[j])
				{
					GClass84.smethod_590(this.list_6[j], true, ref this.highlightsFXStandalone_0);
				}
			}
			for (int k = this.list_8.Count - 1; k >= 0; k--)
			{
				if (this.list_8[k])
				{
					GClass84.smethod_590(this.list_8[k], true, ref this.highlightsFXStandalone_0);
				}
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000257BC File Offset: 0x000239BC
		internal bool method_94()
		{
			return GClass84.smethod_909(this.method_151(), "SyncVictoryB", false);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000257DC File Offset: 0x000239DC
		internal void method_95()
		{
			this.method_46();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000257F0 File Offset: 0x000239F0
		internal void method_96()
		{
			this.method_75();
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00025804 File Offset: 0x00023A04
		internal string method_97(string string_13)
		{
			return this.method_104(string_13);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00025818 File Offset: 0x00023A18
		internal void method_98()
		{
			this.method_82();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002582C File Offset: 0x00023A2C
		internal void method_99()
		{
			this.method_126();
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00025840 File Offset: 0x00023A40
		internal string method_100(string string_13)
		{
			string text = this.method_51(string_13);
			string result;
			if (text != string.Empty)
			{
				result = string.Concat(new string[]
				{
					"Player",
					" ",
					"Node",
					" ",
					text
				});
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0002589C File Offset: 0x00023A9C
		internal string method_101(string string_13)
		{
			return this.method_156(string_13);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000258B0 File Offset: 0x00023AB0
		internal void method_102(bool bool_11)
		{
			this.bool_3 = bool_11;
			for (int i = this.list_10.Count - 1; i >= 0; i--)
			{
				if (this.list_10[i])
				{
					GClass84.smethod_590(this.list_10[i], false, ref this.highlightsFXStandalone_1);
				}
			}
			this.list_9.Clear();
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0002591C File Offset: 0x00023B1C
		internal void method_103(bool bool_11)
		{
			this.method_201(bool_11);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00025930 File Offset: 0x00023B30
		internal string method_104(string string_13)
		{
			string text = this.method_188(string_13);
			string result;
			if (text != string.Empty)
			{
				result = string.Concat(new string[]
				{
					"Player",
					" ",
					"Node",
					" ",
					text
				});
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0002598C File Offset: 0x00023B8C
		internal void method_105()
		{
			this.method_81();
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000259A0 File Offset: 0x00023BA0
		internal void method_106()
		{
			this.method_115();
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000259B4 File Offset: 0x00023BB4
		internal void method_107()
		{
			this.method_149();
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000259C8 File Offset: 0x00023BC8
		internal string method_108(string string_13)
		{
			for (int i = this.list_28.Count - 1; i >= 0; i--)
			{
				if (string_13 == this.list_28[i].string_0)
				{
					return this.list_28[i].string_1;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00025A28 File Offset: 0x00023C28
		internal void method_109()
		{
			this.method_11();
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00025A3C File Offset: 0x00023C3C
		internal void method_110()
		{
			this.method_153();
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00025A50 File Offset: 0x00023C50
		internal void method_111()
		{
			this.method_47();
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00025A64 File Offset: 0x00023C64
		internal List<GameObject> method_112()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Polaroids Unlock Camera");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				List<GameObject> list2 = GClass84.smethod_94(gameObject);
				for (int i = 0; i < list2.Count; i++)
				{
					for (int j = 0; j < this.string_10.Length; j++)
					{
						if (GClass84.smethod_1428(list2[i].name, GClass84.smethod_593(this.string_10[j])) == this.string_10[j])
						{
							list.Add(list2[i]);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00025B04 File Offset: 0x00023D04
		internal void method_113()
		{
			this.method_158();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00025B18 File Offset: 0x00023D18
		internal List<GameObject> method_114()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Snakes/SnakeDispenser");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				List<GameObject> list2 = GClass84.smethod_94(gameObject);
				for (int i = 0; i < list2.Count; i++)
				{
					for (int j = 0; j < this.string_11.Length; j++)
					{
						if (GClass84.smethod_1428(list2[i].name, GClass84.smethod_593(this.string_11[j])) == this.string_11[j])
						{
							list.Add(list2[i]);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00025BB8 File Offset: 0x00023DB8
		internal void method_115()
		{
			this.method_93();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00025BCC File Offset: 0x00023DCC
		internal void method_116()
		{
			this.list_9.Clear();
			GameObject[] array = GClass84.smethod_1142();
			for (int i = 0; i < array.Length; i++)
			{
				VRC_Pickup component = array[i].GetComponent<VRC_Pickup>();
				if (this.method_133(component))
				{
					if (array[i].GetComponent<MeshRenderer>() || array[i].GetComponentInChildren<MeshRenderer>())
					{
						this.list_9.Add(component.gameObject);
					}
				}
				else
				{
					VRC_Pickup[] array2 = array[i].GetComponentsInChildren<VRC_Pickup>(true);
					for (int j = 0; j < array2.Length; j++)
					{
						if (this.method_133(array2[j]))
						{
							this.list_9.Add(array2[j].gameObject);
						}
					}
				}
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00025C90 File Offset: 0x00023E90
		internal void method_117(bool bool_11)
		{
			this.method_33(bool_11);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00025CA4 File Offset: 0x00023EA4
		internal void method_118()
		{
			this.method_71();
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00025CB8 File Offset: 0x00023EB8
		internal bool method_119(List<GameObject> list_30, VRC_Pickup.PickupHand pickupHand_0 = 2)
		{
			VRCPlayerApi vrcplayerApi = GClass84.smethod_739();
			if (list_30.Count > 0 && vrcplayerApi != null)
			{
				GameObject gameObject = list_30[GClass84.smethod_1673(list_30.Count)];
				if (gameObject)
				{
					VRC_Pickup component = gameObject.GetComponent<VRC_Pickup>();
					if (component)
					{
						vrcplayerApi.SetPickupInHand(component, pickupHand_0);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00025D1C File Offset: 0x00023F1C
		internal bool method_120(GameObject gameObject_9)
		{
			return GClass84.smethod_909(this.method_210(gameObject_9), "SyncCluesFinished", false);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00025D3C File Offset: 0x00023F3C
		internal bool method_121(VRC_Trigger vrc_Trigger_0)
		{
			if (vrc_Trigger_0)
			{
				bool flag = false;
				foreach (VRC_Trigger.TriggerEvent triggerEvent in vrc_Trigger_0.Triggers)
				{
					if (triggerEvent != null && triggerEvent.TriggerType == 17)
					{
						flag = true;
						IL_47:
						return flag && (!vrc_Trigger_0.GetComponent<VRC_Pickup>() && (vrc_Trigger_0.GetComponent<MeshRenderer>() || vrc_Trigger_0.GetComponentInChildren<MeshRenderer>(true)));
					}
				}
				goto IL_47;
			}
			return false;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00025DD0 File Offset: 0x00023FD0
		internal void method_122()
		{
			this.method_95();
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00025DE4 File Offset: 0x00023FE4
		internal bool method_123()
		{
			return GClass84.smethod_909(this.method_151(), "SyncAbort", false);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00025E04 File Offset: 0x00024004
		internal void method_124(bool bool_11)
		{
			this.method_103(bool_11);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00025E18 File Offset: 0x00024018
		internal bool method_125(Vector3 vector3_0)
		{
			bool result = false;
			List<GameObject> list = this.method_178();
			for (int i = 0; i < list.Count; i++)
			{
				if (GClass84.smethod_535(list[i], vector3_0, true))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00025E54 File Offset: 0x00024054
		internal void method_126()
		{
			this.method_145();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00025E68 File Offset: 0x00024068
		internal bool method_127()
		{
			return GClass84.smethod_909(this.method_209(), "SyncVictoryB", false);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00025E88 File Offset: 0x00024088
		internal void method_128(bool bool_11)
		{
			GameObject gameObject = this.method_73();
			if (!gameObject)
			{
				GClass70.smethod_38("AmongUs_KillByFarDistance(): AmongUs_PlayerNodes Not Found!", GClass70.Enum1.const_0);
			}
			else
			{
				Transform[] array = GClass84.smethod_731(gameObject);
				bool flag = false;
				for (int i = 0; i < array.Length; i--)
				{
					UdonBehaviour component = array[i].GetComponent<UdonBehaviour>();
					if (component)
					{
						component.proximity = (float)GClass84.smethod_108<int>(bool_11, 1000, 2);
						flag = true;
					}
					Transform transform = GClass84.smethod_693(array[i], "Player Kill Button");
					if (transform)
					{
						component = transform.GetComponent<UdonBehaviour>();
						if (component)
						{
							component.proximity = (float)GClass84.smethod_108<int>(bool_11, 1000, 3);
							flag = true;
						}
					}
				}
				if (!flag)
				{
					GClass70.smethod_38("AmongUs_KillByFarDistance(): Something Went Wrong!", GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00025F50 File Offset: 0x00024150
		internal void method_129()
		{
			this.method_55();
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00025F64 File Offset: 0x00024164
		internal void method_130()
		{
			this.method_10();
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00025F78 File Offset: 0x00024178
		internal bool method_131()
		{
			return this.method_119(this.method_30(), 2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00025F94 File Offset: 0x00024194
		internal bool method_132(string string_13)
		{
			return GClass84.smethod_909(this.method_3(string_13), "SyncAssignM", false);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00025FB4 File Offset: 0x000241B4
		internal bool method_133(VRC_Pickup vrc_Pickup_0)
		{
			return vrc_Pickup_0 && (vrc_Pickup_0.GetComponent<MeshRenderer>() || vrc_Pickup_0.GetComponentInChildren<MeshRenderer>());
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00025FF4 File Offset: 0x000241F4
		internal void method_134()
		{
			if (this.list_7.Count >= 2)
			{
				GameObject gameObject = this.list_7[1];
				if (gameObject)
				{
					VRC_Trigger component = gameObject.GetComponent<VRC_Trigger>();
					if (component)
					{
						foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
						{
							if (triggerEvent.TriggerType == 8)
							{
								component.ExecuteTriggerType(8);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00026074 File Offset: 0x00024274
		internal void method_135()
		{
			this.method_48();
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00026478 File Offset: 0x00024678
		internal void method_136(bool bool_11)
		{
			this.method_208(bool_11);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002648C File Offset: 0x0002468C
		internal bool method_137()
		{
			return GClass84.smethod_909(this.method_151(), "SyncVictoryM", false);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000264AC File Offset: 0x000246AC
		internal bool method_138()
		{
			this.list_26.Clear();
			for (int i = 0; i < this.string_8.Length; i++)
			{
				GameObject gameObject = GameObject.Find(string.Concat(new string[]
				{
					this.string_8[i],
					"/",
					"Recoil",
					" ",
					"Anim",
					"/",
					"Recoil",
					"/",
					"Laser",
					" ",
					"Sight"
				}));
				if (gameObject)
				{
					this.list_26.Add(gameObject);
				}
			}
			return this.list_26.Count > 0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00026570 File Offset: 0x00024770
		internal void method_139()
		{
			this.method_118();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00026584 File Offset: 0x00024784
		internal void method_140(bool bool_11)
		{
			this.method_117(bool_11);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00026598 File Offset: 0x00024798
		internal List<GameObject> method_141()
		{
			List<GameObject> list = this.method_30();
			list.AddRange(this.method_178());
			return list;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000265BC File Offset: 0x000247BC
		internal void method_142(bool bool_11)
		{
			this.method_197(bool_11);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000265D0 File Offset: 0x000247D0
		internal bool method_143()
		{
			this.list_17.Clear();
			List<GameObject> list = this.method_36();
			for (int i = 0; i < list.Count; i++)
			{
				this.list_17.AddRange(list[i].GetComponentsInChildren<MeshRenderer>(true));
			}
			return this.list_17.Count > 0;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00026628 File Offset: 0x00024828
		internal void method_144()
		{
			this.list_6.Clear();
			for (int i = 0; i < this.list_5.Count; i++)
			{
				if (this.list_5[i])
				{
					MeshRenderer componentInChildren = this.list_5[i].GetComponentInChildren<MeshRenderer>();
					if (componentInChildren)
					{
						this.list_6.Add(componentInChildren);
					}
				}
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00026694 File Offset: 0x00024894
		internal void method_145()
		{
			if (this.bool_3)
			{
				if (this.list_9.Count == 0 || !this.list_9[0])
				{
					this.method_110();
				}
				if (this.list_10.Count == 0 || !this.list_10[0])
				{
					this.method_139();
				}
				for (int i = this.list_10.Count - 1; i >= 0; i--)
				{
					if (this.list_10[i])
					{
						if (this.bool_4 || this.list_10[i].gameObject.activeInHierarchy)
						{
							GClass84.smethod_590(this.list_10[i], true, ref this.highlightsFXStandalone_1);
						}
						else
						{
							GClass84.smethod_590(this.list_10[i], false, ref this.highlightsFXStandalone_1);
						}
					}
				}
			}
			if (this.bool_5)
			{
				if (this.list_11.Count == 0 || !this.list_11[0])
				{
					this.method_96();
				}
				if (this.list_12.Count == 0 || !this.list_12[0])
				{
					this.method_109();
				}
				for (int j = this.list_12.Count - 1; j >= 0; j--)
				{
					if (this.list_12[j])
					{
						if (this.bool_6 || this.list_12[j].gameObject.activeInHierarchy)
						{
							GClass84.smethod_590(this.list_12[j], true, ref this.highlightsFXStandalone_1);
						}
						else
						{
							GClass84.smethod_590(this.list_12[j], false, ref this.highlightsFXStandalone_1);
						}
					}
				}
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00026880 File Offset: 0x00024A80
		internal bool method_146(string string_13)
		{
			return GClass84.smethod_909(this.method_179(string_13), "SyncAssignB", false);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000268A0 File Offset: 0x00024AA0
		internal void method_147()
		{
			this.method_56();
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000268B4 File Offset: 0x00024AB4
		internal void method_148(bool bool_11)
		{
			this.method_88(bool_11);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000268C8 File Offset: 0x00024AC8
		internal void method_149()
		{
			if (!this.gameObject_5)
			{
				if (!this.gameObject_4)
				{
					this.gameObject_4 = GameObject.Find("Game Logic/Game Canvas/Game In Progress/Player List");
				}
				if (!this.gameObject_4)
				{
					this.list_28.Clear();
					this.list_29.Clear();
					this.gameObject_5 = null;
					GClass70.smethod_38("HackForMurder4_GetInfo(): Murder4_PlayerList Not Found!", GClass70.Enum1.const_0);
					this.bool_8 = false;
					return;
				}
				this.gameObject_5 = GClass84.smethod_138(this.gameObject_4, "Player List Group");
				if (!this.gameObject_5)
				{
					this.list_28.Clear();
					this.list_29.Clear();
					GClass70.smethod_38("HackForMurder4_GetInfo(): Murder4_PlayerListGroup Not Found!", GClass70.Enum1.const_0);
					this.bool_8 = false;
					return;
				}
			}
			if (this.gameObject_5.activeInHierarchy)
			{
				GameObject[] array = GClass84.smethod_1034(this.gameObject_5);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] && array[i].activeInHierarchy)
					{
						Transform transform = GClass84.smethod_830(array[i], "Player Name Text");
						if (transform)
						{
							Text component = transform.GetComponent<Text>();
							if (component)
							{
								string text = component.text;
								Image component2 = array[i].GetComponent<Image>();
								int num = GClass84.smethod_1635(array[i].name, " ");
								if (num != -1)
								{
									string b = GClass84.smethod_1204(array[i].name, num + 1, -1);
									GClass141.Enum0 @enum = GClass141.Enum0.const_0;
									if (component2)
									{
										if (component2.m_Color.r > 0f && component2.m_Color.g > 0f && component2.m_Color.b > 0f)
										{
											if (component2.m_Color.r > component2.m_Color.g && component2.m_Color.r > component2.m_Color.b)
											{
												@enum = GClass141.Enum0.const_2;
											}
											else if (component2.m_Color.b > component2.m_Color.r && component2.m_Color.b > component2.m_Color.g)
											{
												if (component2.m_Color.g > 0.5f)
												{
													@enum = GClass141.Enum0.const_1;
												}
												else
												{
													@enum = GClass141.Enum0.const_3;
												}
											}
										}
										else
										{
											@enum = GClass141.Enum0.const_0;
										}
									}
									int j;
									for (j = 0; j < this.list_28.Count; j++)
									{
										if (this.list_28[j].string_1 == b)
										{
											GClass141.Struct1 value = this.list_28[j];
											value.string_0 = text;
											value.enum0_0 = @enum;
											this.list_28[j] = value;
										}
									}
									if (j == this.list_28.Count)
									{
										this.list_28.Add(new GClass141.Struct1(text, b, @enum));
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00026BEC File Offset: 0x00024DEC
		internal bool method_150(string string_13)
		{
			return GClass84.smethod_909(this.method_3(string_13), "Btn_Kill", false);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00026C0C File Offset: 0x00024E0C
		internal GameObject method_151()
		{
			if (!this.gameObject_6)
			{
				this.gameObject_6 = GameObject.Find("/Game Logic");
			}
			return this.gameObject_6;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00026C44 File Offset: 0x00024E44
		internal void method_152()
		{
			this.method_58();
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00026C58 File Offset: 0x00024E58
		internal void method_153()
		{
			this.method_116();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00026C6C File Offset: 0x00024E6C
		internal bool method_154()
		{
			this.list_18.Clear();
			List<GameObject> list = this.method_22();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					this.list_18.AddRange(list[i].GetComponentsInChildren<MeshRenderer>());
				}
			}
			return this.list_18.Count > 0;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00026CD4 File Offset: 0x00024ED4
		internal void method_155()
		{
			this.method_5();
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00026CE8 File Offset: 0x00024EE8
		internal string method_156(string string_13)
		{
			for (int i = this.list_14.Count - 1; i >= 0; i++)
			{
				if (string_13 == this.list_14[i].string_1)
				{
					return this.list_14[i].string_0;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00026D48 File Offset: 0x00024F48
		internal List<GameObject> method_157()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Weapons/Unlockables");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				for (int i = 0; i < this.string_9.Length; i++)
				{
					GameObject gameObject2 = GClass84.smethod_138(gameObject, this.string_9[i]);
					if (gameObject2)
					{
						list.Add(gameObject2);
					}
				}
			}
			return list;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00026DAC File Offset: 0x00024FAC
		internal void method_158()
		{
			this.method_59();
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00026DC0 File Offset: 0x00024FC0
		internal void method_159()
		{
			this.method_37();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00026DD4 File Offset: 0x00024FD4
		internal void method_160(bool bool_11)
		{
			this.bool_8 = bool_11;
			for (int i = this.list_17.Count - 1; i >= 0; i--)
			{
				if (this.list_17[i])
				{
					GClass84.smethod_590(this.list_17[i], false, ref this.highlightsFXStandalone_4);
				}
			}
			this.list_17.Clear();
			for (int j = this.list_18.Count - 1; j >= 0; j--)
			{
				if (this.list_18[j])
				{
					GClass84.smethod_590(this.list_18[j], false, ref this.highlightsFXStandalone_9);
				}
			}
			this.list_18.Clear();
			for (int k = this.list_19.Count - 1; k >= 0; k--)
			{
				if (this.list_19[k])
				{
					GClass84.smethod_590(this.list_19[k], false, ref this.highlightsFXStandalone_10);
				}
			}
			this.list_19.Clear();
			this.list_20.Clear();
			for (int l = this.list_21.Count - 1; l >= 0; l--)
			{
				if (this.list_21[l])
				{
					GClass84.smethod_590(this.list_21[l], false, ref this.highlightsFXStandalone_11);
				}
			}
			this.list_21.Clear();
			for (int m = this.list_22.Count - 1; m >= 0; m--)
			{
				if (this.list_22[m])
				{
					GClass84.smethod_590(this.list_22[m], false, ref this.highlightsFXStandalone_12);
				}
			}
			this.list_22.Clear();
			this.list_23.Clear();
			for (int n = this.list_24.Count - 1; n >= 0; n--)
			{
				if (this.list_24[n])
				{
					GClass84.smethod_590(this.list_24[n], false, ref this.highlightsFXStandalone_13);
				}
			}
			this.list_24.Clear();
			for (int num = this.list_25.Count - 1; num >= 0; num--)
			{
				if (this.list_25[num])
				{
					GClass84.smethod_590(this.list_25[num], false, ref this.highlightsFXStandalone_14);
				}
			}
			this.list_25.Clear();
			for (int num2 = this.list_26.Count - 1; num2 >= 0; num2--)
			{
				if (this.list_26[num2] && this.list_26[num2].activeSelf)
				{
					this.list_26[num2].SetActive(false);
				}
			}
			this.list_26.Clear();
			if (this.bool_8)
			{
				this.method_13();
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000270F4 File Offset: 0x000252F4
		internal void method_161()
		{
			this.list_7.Clear();
			for (int i = 0; i < this.string_4.Length; i++)
			{
				GameObject gameObject = GameObject.Find(this.string_4[i]);
				if (!gameObject)
				{
					this.list_7.Clear();
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Murder",
						"2",
						"_",
						"Get",
						"Guns",
						"(): ",
						this.string_4[i],
						" ",
						"Not",
						" ",
						"Found",
						"!"
					}), GClass70.Enum1.const_0);
					this.bool_0 = false;
					return;
				}
				this.list_7.Add(gameObject);
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000271D8 File Offset: 0x000253D8
		internal void method_162()
		{
			this.method_212();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000271EC File Offset: 0x000253EC
		internal void method_163()
		{
			GameObject gameObject = GameObject.Find("/Murder Logic 3");
			if (gameObject)
			{
				Transform transform = GClass84.smethod_830(gameObject, "Death");
				if (transform)
				{
					VRC_Trigger component = transform.GetComponent<VRC_Trigger>();
					if (component)
					{
						foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
						{
							for (int i = 0; i < triggerEvent.Events.Count; i++)
							{
								VRC_EventHandler.VrcEvent vrcEvent = triggerEvent.Events[i];
								if (vrcEvent.EventType == 15 && vrcEvent.ParameterString == "Drop All Weapons")
								{
									triggerEvent.Events.RemoveAt(i);
									i--;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000272C4 File Offset: 0x000254C4
		internal bool method_164()
		{
			return GClass84.gclass179_0.method_18("SyncLock");
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000272E0 File Offset: 0x000254E0
		internal bool method_165()
		{
			return GClass84.smethod_909(this.method_209(), "SyncAbort", false);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00027300 File Offset: 0x00025500
		internal void method_166()
		{
			GameObject gameObject = GameObject.Find("/Murder Logic 3");
			if (gameObject)
			{
				Transform transform = GClass84.smethod_830(gameObject, "Reset Game");
				if (transform)
				{
					VRC_Trigger component = transform.gameObject.GetComponent<VRC_Trigger>();
					if (component)
					{
						foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
						{
							for (int i = 0; i < triggerEvent.Events.Count; i++)
							{
								VRC_EventHandler.VrcEvent vrcEvent = triggerEvent.Events[i];
								if (vrcEvent.EventType == 15 && vrcEvent.ParameterString == "Drop All Weapons")
								{
									triggerEvent.Events.RemoveAt(i);
									i--;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000273DC File Offset: 0x000255DC
		internal void method_167()
		{
			if (this.list_7.Count >= 1)
			{
				GameObject gameObject = this.list_7[0];
				if (gameObject)
				{
					VRC_Trigger component = gameObject.GetComponent<VRC_Trigger>();
					if (component)
					{
						foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
						{
							if (triggerEvent.TriggerType == 8)
							{
								component.ExecuteTriggerType(8);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002745C File Offset: 0x0002565C
		internal void method_168()
		{
			this.method_90();
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00027470 File Offset: 0x00025670
		internal void method_169(bool bool_11)
		{
			this.method_27(bool_11);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00027484 File Offset: 0x00025684
		internal bool method_170()
		{
			return GClass84.gclass179_0.method_18("SyncUnlockL");
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000274A0 File Offset: 0x000256A0
		internal void method_171()
		{
			this.method_159();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000274B4 File Offset: 0x000256B4
		internal void method_172()
		{
			this.method_41();
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000274C8 File Offset: 0x000256C8
		public override void vmethod_12()
		{
			this.method_155();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000274DC File Offset: 0x000256DC
		internal bool method_173(Vector3 vector3_0)
		{
			bool result = false;
			if (GClass84.smethod_640(this.method_9(), vector3_0, true))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00027500 File Offset: 0x00025700
		internal void method_174()
		{
			this.method_85();
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00027514 File Offset: 0x00025714
		internal void method_175(bool bool_11)
		{
			this.method_183(bool_11);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00027528 File Offset: 0x00025728
		internal void method_176()
		{
			this.list_12.Clear();
			for (int i = 0; i < this.list_11.Count; i++)
			{
				if (this.list_11[i])
				{
					List<MeshRenderer> list = this.list_11[i].GetComponents<MeshRenderer>().ToList<MeshRenderer>();
					list.AddRange(this.list_11[i].GetComponentsInChildren<MeshRenderer>(true));
					for (int j = 0; j < list.Count; j++)
					{
						this.list_12.Add(list[j]);
					}
				}
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000275C4 File Offset: 0x000257C4
		internal List<GameObject> method_177()
		{
			GameObject gameObject = GameObject.Find("Game Logic/Weapons");
			List<GameObject> list = new List<GameObject>();
			if (gameObject)
			{
				List<GameObject> list2 = GClass84.smethod_94(gameObject);
				for (int i = 0; i < list2.Count; i++)
				{
					for (int j = 0; j < this.string_7.Length; j++)
					{
						if (GClass84.smethod_1428(list2[i].name, GClass84.smethod_593(this.string_7[j])) == this.string_7[j])
						{
							list.Add(list2[i]);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00027664 File Offset: 0x00025864
		internal List<GameObject> method_178()
		{
			List<GameObject> list = this.method_22();
			list.AddRange(this.method_177());
			return list;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00027688 File Offset: 0x00025888
		internal GameObject method_179(string string_13)
		{
			string a = this.method_89(string_13);
			if (a != string.Empty)
			{
				GameObject gameObject = this.method_191();
				if (gameObject)
				{
					return GClass84.smethod_138(gameObject, a);
				}
			}
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000276CC File Offset: 0x000258CC
		internal void method_180(bool bool_11)
		{
			this.method_7(bool_11);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000276E0 File Offset: 0x000258E0
		internal void method_181(bool bool_11)
		{
			this.method_189(bool_11);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000276F4 File Offset: 0x000258F4
		internal void method_182()
		{
			this.method_39();
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00027708 File Offset: 0x00025908
		internal void method_183(bool bool_11)
		{
			this.method_160(bool_11);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002771C File Offset: 0x0002591C
		internal bool method_184()
		{
			return GClass84.gclass179_0.method_18("SyncBreakL");
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00027738 File Offset: 0x00025938
		internal void method_185()
		{
			this.method_134();
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002774C File Offset: 0x0002594C
		internal void method_186()
		{
			this.method_185();
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00027760 File Offset: 0x00025960
		internal void method_187(GameObject gameObject_9)
		{
			this.method_194(gameObject_9);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00027774 File Offset: 0x00025974
		internal string method_188(string string_13)
		{
			return this.method_101(string_13);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00027788 File Offset: 0x00025988
		internal void method_189(bool bool_11)
		{
			this.bool_9 = bool_11;
			if (!bool_11)
			{
				this.list_27.Clear();
			}
			else
			{
				List<GameObject> list = this.method_178();
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i])
					{
						VRC_Pickup component = list[i].GetComponent<VRC_Pickup>();
						if (component)
						{
							this.list_27.Add(component);
						}
					}
				}
				list = this.method_9();
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j])
					{
						VRC_Pickup component2 = list[j].GetComponent<VRC_Pickup>();
						if (component2)
						{
							this.list_27.Add(component2);
						}
					}
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00027854 File Offset: 0x00025A54
		internal bool method_190(int int_0)
		{
			return GClass84.smethod_1458(this.method_53(), string.Concat(new string[]
			{
				"_",
				"Teleport",
				"To",
				"Bedroom",
				"Inside",
				int_0.ToString()
			}));
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000278AC File Offset: 0x00025AAC
		internal GameObject method_191()
		{
			if (!this.gameObject_7)
			{
				this.gameObject_7 = GameObject.Find("/Game Logic/Player Nodes");
			}
			return this.gameObject_7;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000278E4 File Offset: 0x00025AE4
		internal void method_192(bool bool_11)
		{
			this.bool_7 = bool_11;
			for (int i = this.list_15.Count - 1; i >= 0; i--)
			{
				if (this.list_15[i])
				{
					GClass84.smethod_590(this.list_15[i], false, ref this.highlightsFXStandalone_2);
					GClass84.smethod_590(this.list_15[i], false, ref this.highlightsFXStandalone_3);
				}
			}
			this.list_15.Clear();
			if (this.bool_7)
			{
				this.method_38();
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00027974 File Offset: 0x00025B74
		internal bool method_193(Vector3 vector3_0)
		{
			return this.method_18(vector3_0) && this.method_125(vector3_0);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00027994 File Offset: 0x00025B94
		internal void method_194(GameObject gameObject_9)
		{
			if (gameObject_9)
			{
				VRC_Trigger component = gameObject_9.GetComponent<VRC_Trigger>();
				if (component)
				{
					foreach (VRC_Trigger.TriggerEvent triggerEvent in component.Triggers)
					{
						for (int i = 0; i < triggerEvent.Events.Count; i++)
						{
							VRC_EventHandler.VrcEvent vrcEvent = triggerEvent.Events[i];
							if (vrcEvent.EventType == 14 && vrcEvent.ParameterString == "Drop")
							{
								triggerEvent.Events.RemoveAt(i);
								i--;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00027A40 File Offset: 0x00025C40
		internal string method_195(string string_13)
		{
			return this.method_97(string_13);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00027A54 File Offset: 0x00025C54
		internal void method_196()
		{
			this.method_83();
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00027A68 File Offset: 0x00025C68
		internal void method_197(bool bool_11)
		{
			this.method_42(bool_11);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00027A7C File Offset: 0x00025C7C
		internal List<GameObject> method_198()
		{
			return this.method_32();
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00027A94 File Offset: 0x00025C94
		internal void method_199()
		{
			this.method_174();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00027AA8 File Offset: 0x00025CA8
		internal bool method_200(string string_13)
		{
			return GClass84.smethod_909(this.method_179(string_13), "SyncAssignM", false);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00027AC8 File Offset: 0x00025CC8
		internal void method_201(bool bool_11)
		{
			GameObject gameObject = GameObject.Find("/Murder Logic 3");
			if (gameObject)
			{
				GameObject gameObject2 = GClass84.smethod_138(gameObject, "Death");
				if (gameObject2)
				{
					gameObject2.SetActive(!bool_11);
				}
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00027B0C File Offset: 0x00025D0C
		internal List<GameObject> method_202()
		{
			return this.method_114();
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00027B24 File Offset: 0x00025D24
		public override void vmethod_24()
		{
			this.method_196();
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00027B38 File Offset: 0x00025D38
		internal void method_203()
		{
			GClass84.smethod_1233<MeshRenderer>(this.list_29);
			List<VRCPlayerApi> allPlayers = VRCPlayerApi.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Transform transform = allPlayers[i].gameObject.transform.FindChild("SelectRegion");
				MeshRenderer meshRenderer = null;
				if (transform)
				{
					meshRenderer = transform.GetComponent<MeshRenderer>();
				}
				if (meshRenderer)
				{
					int j = 0;
					while (j < this.list_28.Count)
					{
						if (!(this.list_28[j].string_0 == allPlayers[i].displayName))
						{
							j++;
						}
						else
						{
							switch (this.list_28[j].enum0_0)
							{
							case GClass141.Enum0.const_0:
								GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_5);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_6);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_7);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_8);
								break;
							case GClass141.Enum0.const_1:
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_5);
								GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_6);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_7);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_8);
								break;
							case GClass141.Enum0.const_2:
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_5);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_6);
								GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_7);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_8);
								break;
							case GClass141.Enum0.const_3:
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_5);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_6);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_7);
								GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_8);
								break;
							}
							if (!GClass84.smethod_1224<MeshRenderer>(this.list_29, meshRenderer))
							{
								this.list_29.Add(meshRenderer);
							}
							IL_1C3:
							if (j == this.list_28.Count)
							{
								GClass84.smethod_590(meshRenderer, true, ref this.highlightsFXStandalone_5);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_6);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_7);
								GClass84.smethod_590(meshRenderer, false, ref this.highlightsFXStandalone_8);
								goto IL_208;
							}
							goto IL_208;
						}
					}
					goto IL_1C3;
				}
				IL_208:;
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00027D60 File Offset: 0x00025F60
		internal void method_204()
		{
			this.method_111();
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00027D74 File Offset: 0x00025F74
		internal bool method_205()
		{
			return this.method_119(this.method_178(), 2);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00027D90 File Offset: 0x00025F90
		internal bool method_206(string string_13)
		{
			return GClass84.smethod_909(this.method_3(string_13), "SyncAssignB", false);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00027DB0 File Offset: 0x00025FB0
		internal bool method_207()
		{
			this.list_22.Clear();
			List<GameObject> list = this.method_157();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i])
				{
					GameObject gameObject = GClass84.smethod_138(list[i], "Recoil Anim/Recoil/geo");
					if (!gameObject)
					{
						gameObject = GClass84.smethod_138(list[i], "Intact/frag geo");
					}
					if (gameObject)
					{
						this.list_22.Add(gameObject.GetComponent<MeshRenderer>());
					}
				}
			}
			return this.list_22.Count > 0;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00027E4C File Offset: 0x0002604C
		internal void method_208(bool bool_11)
		{
			this.bool_10 = bool_11;
			for (int i = this.list_29.Count - 1; i >= 0; i--)
			{
				if (this.list_29[i])
				{
					GClass84.smethod_590(this.list_29[i], false, ref this.highlightsFXStandalone_5);
					GClass84.smethod_590(this.list_29[i], false, ref this.highlightsFXStandalone_6);
					GClass84.smethod_590(this.list_29[i], false, ref this.highlightsFXStandalone_7);
					GClass84.smethod_590(this.list_29[i], false, ref this.highlightsFXStandalone_8);
				}
			}
			this.list_29.Clear();
			if (this.bool_10)
			{
				this.method_135();
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00027F10 File Offset: 0x00026110
		internal GameObject method_209()
		{
			if (!this.gameObject_2)
			{
				this.gameObject_2 = GameObject.Find("/Game Logic");
			}
			return this.gameObject_2;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00027F48 File Offset: 0x00026148
		internal GameObject method_210(GameObject gameObject_9)
		{
			if (gameObject_9)
			{
				GameObject gameObject = this.method_191();
				if (gameObject)
				{
					GameObject gameObject2 = null;
					float num = 0f;
					GameObject[] array = GClass84.smethod_1034(gameObject);
					for (int i = 0; i < array.Length; i++)
					{
						CapsuleCollider component = array[i].GetComponent<CapsuleCollider>();
						if (component && component.enabled)
						{
							Vector3 center = component.center;
							center.y -= component.height / 2f;
							float num2 = GClass84.smethod_743(gameObject_9.transform.position - center);
							if ((!gameObject2 || num > num2) && num2 < 1f)
							{
								gameObject2 = array[i];
								num = num2;
							}
						}
					}
					return gameObject2;
				}
			}
			return null;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002802C File Offset: 0x0002622C
		internal string method_211(string string_13)
		{
			return this.method_108(string_13);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00028040 File Offset: 0x00026240
		internal void method_212()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_25.Add(new Action<VRC_EventHandler.VrcEvent, VRC_EventHandler.VrcBroadcastType, int, float>(this.vmethod_3));
			GClass84.list_13.Add(new Action(this.vmethod_12));
			this.color_0.r = GClass84.gclass117_0.float_71;
			this.color_0.g = GClass84.gclass117_0.float_72;
			this.color_0.b = GClass84.gclass117_0.float_73;
			this.color_1.r = GClass84.gclass117_0.float_74;
			this.color_1.g = GClass84.gclass117_0.float_75;
			this.color_1.b = GClass84.gclass117_0.float_76;
			this.color_2.r = GClass84.gclass117_0.float_77;
			this.color_2.g = GClass84.gclass117_0.float_78;
			this.color_2.b = GClass84.gclass117_0.float_79;
			this.color_3.r = GClass84.gclass117_0.float_80;
			this.color_3.g = GClass84.gclass117_0.float_81;
			this.color_3.b = GClass84.gclass117_0.float_82;
			this.color_5.r = GClass84.gclass117_0.float_86;
			this.color_5.g = GClass84.gclass117_0.float_87;
			this.color_5.b = GClass84.gclass117_0.float_88;
			this.color_6.r = GClass84.gclass117_0.float_89;
			this.color_6.g = GClass84.gclass117_0.float_90;
			this.color_6.b = GClass84.gclass117_0.float_91;
			this.color_7.r = GClass84.gclass117_0.float_92;
			this.color_7.g = GClass84.gclass117_0.float_93;
			this.color_7.b = GClass84.gclass117_0.float_94;
			this.color_8.r = GClass84.gclass117_0.float_95;
			this.color_8.g = GClass84.gclass117_0.float_96;
			this.color_8.b = GClass84.gclass117_0.float_97;
			this.color_9.r = GClass84.gclass117_0.float_98;
			this.color_9.g = GClass84.gclass117_0.float_99;
			this.color_9.b = GClass84.gclass117_0.float_100;
			this.color_10.r = GClass84.gclass117_0.float_101;
			this.color_10.g = GClass84.gclass117_0.float_102;
			this.color_10.b = GClass84.gclass117_0.float_103;
			this.color_11.r = GClass84.gclass117_0.float_104;
			this.color_11.g = GClass84.gclass117_0.float_105;
			this.color_11.b = GClass84.gclass117_0.float_106;
			this.color_12.r = GClass84.gclass117_0.float_107;
			this.color_12.g = GClass84.gclass117_0.float_108;
			this.color_12.b = GClass84.gclass117_0.float_109;
			this.color_13.r = GClass84.gclass117_0.float_110;
			this.color_13.g = GClass84.gclass117_0.float_111;
			this.color_13.b = GClass84.gclass117_0.float_112;
			this.color_14.r = GClass84.gclass117_0.float_113;
			this.color_14.g = GClass84.gclass117_0.float_114;
			this.color_14.b = GClass84.gclass117_0.float_115;
			this.color_15.r = GClass84.gclass117_0.float_116;
			this.color_15.g = GClass84.gclass117_0.float_117;
			this.color_15.b = GClass84.gclass117_0.float_118;
		}

		// Token: 0x040006B9 RID: 1721
		internal Color color_0 = Color.cyan;

		// Token: 0x040006BA RID: 1722
		internal Color color_1 = Color.magenta;

		// Token: 0x040006BB RID: 1723
		internal Color color_2 = Color.cyan;

		// Token: 0x040006BC RID: 1724
		internal Color color_3 = Color.magenta;

		// Token: 0x040006BD RID: 1725
		internal Color color_4 = Color.white;

		// Token: 0x040006BE RID: 1726
		internal Color color_5 = Color.white;

		// Token: 0x040006BF RID: 1727
		internal Color color_6 = Color.cyan;

		// Token: 0x040006C0 RID: 1728
		internal Color color_7 = Color.magenta;

		// Token: 0x040006C1 RID: 1729
		internal Color color_8 = Color.blue;

		// Token: 0x040006C2 RID: 1730
		internal Color color_9 = Color.red;

		// Token: 0x040006C3 RID: 1731
		internal Color color_10 = Color.red;

		// Token: 0x040006C4 RID: 1732
		internal Color color_11 = Color.blue;

		// Token: 0x040006C5 RID: 1733
		internal Color color_12 = Color.cyan;

		// Token: 0x040006C6 RID: 1734
		internal Color color_13 = Color.white;

		// Token: 0x040006C7 RID: 1735
		internal Color color_14 = Color.magenta;

		// Token: 0x040006C8 RID: 1736
		internal Color color_15 = Color.red;

		// Token: 0x040006C9 RID: 1737
		internal HighlightsFXStandalone highlightsFXStandalone_0;

		// Token: 0x040006CA RID: 1738
		internal HighlightsFXStandalone highlightsFXStandalone_1;

		// Token: 0x040006CB RID: 1739
		internal HighlightsFXStandalone highlightsFXStandalone_2;

		// Token: 0x040006CC RID: 1740
		internal HighlightsFXStandalone highlightsFXStandalone_3;

		// Token: 0x040006CD RID: 1741
		internal HighlightsFXStandalone highlightsFXStandalone_4;

		// Token: 0x040006CE RID: 1742
		internal HighlightsFXStandalone highlightsFXStandalone_5;

		// Token: 0x040006CF RID: 1743
		internal HighlightsFXStandalone highlightsFXStandalone_6;

		// Token: 0x040006D0 RID: 1744
		internal HighlightsFXStandalone highlightsFXStandalone_7;

		// Token: 0x040006D1 RID: 1745
		internal HighlightsFXStandalone highlightsFXStandalone_8;

		// Token: 0x040006D2 RID: 1746
		internal HighlightsFXStandalone highlightsFXStandalone_9;

		// Token: 0x040006D3 RID: 1747
		internal HighlightsFXStandalone highlightsFXStandalone_10;

		// Token: 0x040006D4 RID: 1748
		internal HighlightsFXStandalone highlightsFXStandalone_11;

		// Token: 0x040006D5 RID: 1749
		internal HighlightsFXStandalone highlightsFXStandalone_12;

		// Token: 0x040006D6 RID: 1750
		internal HighlightsFXStandalone highlightsFXStandalone_13;

		// Token: 0x040006D7 RID: 1751
		internal HighlightsFXStandalone highlightsFXStandalone_14;

		// Token: 0x040006D8 RID: 1752
		internal HighlightsFXStandalone highlightsFXStandalone_15;

		// Token: 0x040006D9 RID: 1753
		internal bool bool_0 = false;

		// Token: 0x040006DA RID: 1754
		internal bool bool_1 = false;

		// Token: 0x040006DB RID: 1755
		internal List<Collider> list_0 = new List<Collider>();

		// Token: 0x040006DC RID: 1756
		private string[] string_1 = new string[]
		{
			"/Murder Logic 3/ClueCollecting/Clues/Clue",
			"/Murder Logic 3/ClueCollecting/Clues/Clue (1)",
			"/Murder Logic 3/ClueCollecting/Clues/Clue (2)",
			"/Murder Logic 3/ClueCollecting/Clues/Clue (3)"
		};

		// Token: 0x040006DD RID: 1757
		private string string_2 = "/Clue hidden/Clue interact";

		// Token: 0x040006DE RID: 1758
		internal List<GameObject> list_1 = new List<GameObject>();

		// Token: 0x040006DF RID: 1759
		internal List<GameObject> list_2 = new List<GameObject>();

		// Token: 0x040006E0 RID: 1760
		internal List<GameObject> list_3 = new List<GameObject>();

		// Token: 0x040006E1 RID: 1761
		internal List<MeshRenderer> list_4 = new List<MeshRenderer>();

		// Token: 0x040006E2 RID: 1762
		private string[] string_3 = new string[]
		{
			"/Murder Logic 3/Weapons/Knife",
			"/Murder Logic 3/Weapons/Knife (1)",
			"/Murder Logic 3/Weapons/Knife (2)",
			"/Murder Logic 3/Weapons/Knife (5)",
			"/Murder Logic 3/Weapons/Knife (6)",
			"/Murder Logic 3/Weapons/Knife (7)",
			"/Murder Logic 3/Weapons/Knife (8)"
		};

		// Token: 0x040006E3 RID: 1763
		internal List<GameObject> list_5 = new List<GameObject>();

		// Token: 0x040006E4 RID: 1764
		internal List<MeshRenderer> list_6 = new List<MeshRenderer>();

		// Token: 0x040006E5 RID: 1765
		private string[] string_4 = new string[]
		{
			"/Murder Logic 3/Weapons/Gun Revolver/Gun Revolverpickup",
			"/Murder Logic 3/Weapons/Gun Silenced/Gun Silencedpickup"
		};

		// Token: 0x040006E6 RID: 1766
		internal List<GameObject> list_7 = new List<GameObject>();

		// Token: 0x040006E7 RID: 1767
		internal List<MeshRenderer> list_8 = new List<MeshRenderer>();

		// Token: 0x040006E8 RID: 1768
		internal bool bool_2 = false;

		// Token: 0x040006E9 RID: 1769
		internal bool bool_3 = false;

		// Token: 0x040006EA RID: 1770
		internal bool bool_4 = false;

		// Token: 0x040006EB RID: 1771
		internal bool bool_5 = false;

		// Token: 0x040006EC RID: 1772
		internal bool bool_6 = false;

		// Token: 0x040006ED RID: 1773
		internal List<GameObject> list_9 = new List<GameObject>();

		// Token: 0x040006EE RID: 1774
		internal List<MeshRenderer> list_10 = new List<MeshRenderer>();

		// Token: 0x040006EF RID: 1775
		internal List<GameObject> list_11 = new List<GameObject>();

		// Token: 0x040006F0 RID: 1776
		internal List<MeshRenderer> list_12 = new List<MeshRenderer>();

		// Token: 0x040006F1 RID: 1777
		internal bool bool_7 = false;

		// Token: 0x040006F2 RID: 1778
		internal GameObject gameObject_0 = null;

		// Token: 0x040006F3 RID: 1779
		internal GameObject gameObject_1 = null;

		// Token: 0x040006F4 RID: 1780
		internal List<VRCPlayerApi> list_13 = new List<VRCPlayerApi>();

		// Token: 0x040006F5 RID: 1781
		internal List<GClass84.GStruct153> list_14 = new List<GClass84.GStruct153>();

		// Token: 0x040006F6 RID: 1782
		internal List<MeshRenderer> list_15 = new List<MeshRenderer>();

		// Token: 0x040006F7 RID: 1783
		internal List<string> list_16 = new List<string>();

		// Token: 0x040006F8 RID: 1784
		internal GameObject gameObject_2 = null;

		// Token: 0x040006F9 RID: 1785
		internal GameObject gameObject_3 = null;

		// Token: 0x040006FA RID: 1786
		internal bool bool_8 = false;

		// Token: 0x040006FB RID: 1787
		internal bool bool_9 = false;

		// Token: 0x040006FC RID: 1788
		private string[] string_5 = new string[]
		{
			"/Game Logic/Clues",
			"/Game Logic/Clues (xmas)"
		};

		// Token: 0x040006FD RID: 1789
		internal List<Renderer> list_17 = new List<Renderer>();

		// Token: 0x040006FE RID: 1790
		private string[] string_6 = new string[]
		{
			"Knife"
		};

		// Token: 0x040006FF RID: 1791
		private string[] string_7 = new string[]
		{
			"Bear Trap"
		};

		// Token: 0x04000700 RID: 1792
		private string[] string_8 = new string[]
		{
			"Game Logic/Weapons/Revolver"
		};

		// Token: 0x04000701 RID: 1793
		private string[] string_9 = new string[]
		{
			"Luger (0)",
			"Luger (1)",
			"Shotgun (0)",
			"Frag (0)"
		};

		// Token: 0x04000702 RID: 1794
		private string[] string_10 = new string[]
		{
			"Polaroid"
		};

		// Token: 0x04000703 RID: 1795
		private string[] string_11 = new string[]
		{
			"snake crate geo"
		};

		// Token: 0x04000704 RID: 1796
		private string[] string_12 = new string[]
		{
			"snake"
		};

		// Token: 0x04000705 RID: 1797
		internal List<Renderer> list_18 = new List<Renderer>();

		// Token: 0x04000706 RID: 1798
		internal List<Renderer> list_19 = new List<Renderer>();

		// Token: 0x04000707 RID: 1799
		internal List<Renderer> list_20 = new List<Renderer>();

		// Token: 0x04000708 RID: 1800
		internal List<Renderer> list_21 = new List<Renderer>();

		// Token: 0x04000709 RID: 1801
		internal List<Renderer> list_22 = new List<Renderer>();

		// Token: 0x0400070A RID: 1802
		internal List<Renderer> list_23 = new List<Renderer>();

		// Token: 0x0400070B RID: 1803
		internal List<Renderer> list_24 = new List<Renderer>();

		// Token: 0x0400070C RID: 1804
		internal List<Renderer> list_25 = new List<Renderer>();

		// Token: 0x0400070D RID: 1805
		internal List<GameObject> list_26 = new List<GameObject>();

		// Token: 0x0400070E RID: 1806
		internal List<VRC_Pickup> list_27 = new List<VRC_Pickup>();

		// Token: 0x0400070F RID: 1807
		internal bool bool_10 = false;

		// Token: 0x04000710 RID: 1808
		internal GameObject gameObject_4 = null;

		// Token: 0x04000711 RID: 1809
		internal GameObject gameObject_5 = null;

		// Token: 0x04000712 RID: 1810
		internal List<GClass141.Struct1> list_28 = new List<GClass141.Struct1>();

		// Token: 0x04000713 RID: 1811
		internal List<MeshRenderer> list_29 = new List<MeshRenderer>();

		// Token: 0x04000714 RID: 1812
		internal GameObject gameObject_6 = null;

		// Token: 0x04000715 RID: 1813
		internal GameObject gameObject_7 = null;

		// Token: 0x04000716 RID: 1814
		internal GameObject gameObject_8 = null;

		// Token: 0x0200011A RID: 282
		internal enum Enum0
		{
			// Token: 0x04000718 RID: 1816
			const_0,
			// Token: 0x04000719 RID: 1817
			const_1,
			// Token: 0x0400071A RID: 1818
			const_2,
			// Token: 0x0400071B RID: 1819
			const_3
		}

		// Token: 0x0200011B RID: 283
		internal struct Struct1
		{
			// Token: 0x06000998 RID: 2456 RVA: 0x00028444 File Offset: 0x00026644
			public Struct1(string string_2 = "", string string_3 = "", GClass141.Enum0 enum0_1 = GClass141.Enum0.const_0)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
				this.enum0_0 = enum0_1;
			}

			// Token: 0x0400071C RID: 1820
			public string string_0;

			// Token: 0x0400071D RID: 1821
			public string string_1;

			// Token: 0x0400071E RID: 1822
			public GClass141.Enum0 enum0_0;
		}
	}
}
