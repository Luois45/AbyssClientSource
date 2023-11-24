using System;
using System.Collections;
using System.Collections.Generic;
using ns216;
using ns241;
using ns425;
using ns449;
using ns476;
using ns482;
using ns553;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace ns445
{
	// Token: 0x02000197 RID: 407
	public class GClass149 : GClass130
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x00051F18 File Offset: 0x00050118
		private void method_2()
		{
			this.method_35();
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00051F2C File Offset: 0x0005012C
		internal void method_3(int int_5)
		{
			this.method_17(int_5);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00051F40 File Offset: 0x00050140
		internal void method_4()
		{
			if (this.bool_0)
			{
				if (this.bool_5)
				{
					if (this.bool_1 && this.list_0.Count == this.int_0)
					{
						this.list_0[0] = this.method_40(0, 0);
						this.list_0[3] = this.method_40(3, 0);
					}
					if (this.bool_2 && this.bool_3)
					{
						this.method_23();
					}
					if (this.list_1.Count == this.int_1)
					{
						this.list_1[2] = this.method_40(2, 1);
						this.list_1[3] = this.method_40(3, 1);
						this.list_1[5] = this.method_40(5, 1);
						this.list_1[7] = this.method_40(7, 1);
						this.list_1[8] = this.method_40(8, 1);
						this.list_1[10] = this.method_40(10, 1);
						this.list_1[11] = this.method_40(11, 1);
						this.list_1[12] = this.method_40(12, 1);
						this.list_1[14] = this.method_40(14, 1);
						this.list_1[15] = this.method_40(15, 1);
						this.list_1[17] = this.method_40(17, 1);
						this.list_1[18] = this.method_40(18, 1);
						this.list_1[20] = this.method_40(20, 1);
						this.list_1[21] = this.method_40(21, 1);
						this.list_1[23] = this.method_40(23, 1);
						this.list_1[25] = this.method_40(25, 1);
						this.list_1[26] = this.method_40(26, 1);
						this.list_1[27] = this.method_40(27, 1);
						this.list_1[28] = this.method_40(28, 1);
						this.list_1[29] = this.method_40(29, 1);
						this.list_1[30] = this.method_40(30, 1);
						this.list_1[31] = this.method_40(31, 1);
						this.list_1[32] = this.method_40(32, 1);
					}
				}
				if (this.bool_2)
				{
					this.method_25();
				}
				this.method_8();
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000521E0 File Offset: 0x000503E0
		internal void method_5()
		{
			this.method_19();
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000521F4 File Offset: 0x000503F4
		private void method_6()
		{
			this.method_13();
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00052208 File Offset: 0x00050408
		internal void method_7()
		{
			this.method_5();
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0005221C File Offset: 0x0005041C
		public override void vmethod_23()
		{
			this.method_31();
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00052230 File Offset: 0x00050430
		internal void method_8()
		{
			this.method_39();
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00052244 File Offset: 0x00050444
		internal string method_9(int int_5)
		{
			return this.method_36(int_5);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00052258 File Offset: 0x00050458
		private void method_10()
		{
			ApiWorld apiWorld = GClass84.smethod_1424();
			if (apiWorld != null)
			{
				this.string_2 = apiWorld.name + " | " + apiWorld.authorName;
			}
			else
			{
				this.string_2 = string.Empty;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0005229C File Offset: 0x0005049C
		internal void method_11()
		{
			if (this.bool_0)
			{
				if (this.bool_1 && this.bool_5 && this.list_0.Count == this.int_0)
				{
					this.list_0[4] = this.method_40(4, 0);
					this.list_0[5] = this.method_40(5, 0);
				}
				if (this.bool_2 && this.bool_5 && this.bool_3)
				{
					this.method_14();
				}
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00052320 File Offset: 0x00050520
		internal void method_12()
		{
			if (!this.bool_4)
			{
				this.method_7();
				this.method_42(true);
			}
			else
			{
				if (Input.GetKey(306) && !Input.GetKey(304))
				{
					if (Input.GetKeyDown(113))
					{
						this.method_42(!this.bool_5);
						this.method_48();
					}
					if (Input.GetKeyDown(101))
					{
						this.method_32(!this.bool_3);
					}
				}
				if (this.bool_5)
				{
					if (this.bool_1 && this.text_0)
					{
						this.text_0.text = string.Join("\n", this.list_0);
					}
					if (this.bool_2 && this.text_1)
					{
						if (this.bool_3)
						{
							this.text_1.text = string.Concat(new string[]
							{
								this.string_1,
								"\n",
								this.string_2,
								"\n",
								this.string_3,
								"\n",
								this.string_4,
								"\n",
								string.Join("\n", this.list_2)
							});
						}
						else
						{
							this.text_1.text = this.string_1;
						}
					}
					if (this.text_2)
					{
						this.text_2.text = string.Join("\n", this.list_1);
					}
				}
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000524A8 File Offset: 0x000506A8
		private void method_13()
		{
			this.string_1 = "'CTRL+Q' to hide | 'CTRL+E'" + (this.bool_3 ? " to close" : " to open") + " | FPS: " + GClass84.float_1.ToString();
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000524E8 File Offset: 0x000506E8
		private void method_14()
		{
			this.method_21();
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000524FC File Offset: 0x000506FC
		internal void method_15(bool bool_7)
		{
			this.bool_3 = bool_7;
			this.method_48();
			if (this.rawImage_0)
			{
				this.rawImage_0.texture = (this.bool_3 ? GClass153.GClass86.texture2D_1 : GClass153.GClass86.texture2D_0);
			}
			if (this.rawImage_2)
			{
				this.rawImage_2.texture = (this.bool_3 ? GClass153.GClass86.texture2D_1 : GClass153.GClass86.texture2D_0);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00052570 File Offset: 0x00050770
		private void method_16()
		{
			this.method_2();
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00052584 File Offset: 0x00050784
		internal void method_17(int int_5)
		{
			this.method_45(int_5);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00052598 File Offset: 0x00050798
		internal string method_18(int int_5, int int_6)
		{
			string text = string.Empty;
			string result;
			if (!this.bool_5)
			{
				result = text;
			}
			else
			{
				if (int_6 != 0)
				{
					if (int_6 == 1)
					{
						switch (int_5)
						{
						case 0:
							text += "\n\nSettings";
							break;
						case 1:
							if (this.bool_3 && GClass84.gclass132_0 != null)
							{
								text += "\nPickups Manager:";
							}
							break;
						case 2:
							if (this.bool_3 && GClass84.gclass132_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bEnabled: ",
									GClass84.gclass132_0.bool_0 ? "<color=lime>" : "<color=red>",
									GClass84.gclass132_0.bool_0.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+I)";
								}
							}
							break;
						case 3:
							if (this.bool_3 && GClass84.gclass132_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bPreventDroppingPickups: ",
									GClass84.gclass132_0.bool_3 ? "<color=lime>" : "<color=red>",
									GClass84.gclass132_0.bool_3.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+D)";
								}
							}
							break;
						case 4:
							if (this.bool_3 && GClass84.gclass181_0 != null)
							{
								text += "\nPortals Handler:";
							}
							break;
						case 5:
							if (this.bool_3 && GClass84.gclass181_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bEnabled: ",
									GClass84.gclass181_0.bool_0 ? "<color=lime>" : "<color=red>",
									GClass84.gclass181_0.bool_0.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+P)";
								}
							}
							break;
						case 6:
							if (this.bool_3 && GClass84.gclass144_0 != null)
							{
								text += "\nObjects Manager:";
							}
							break;
						case 7:
							if (this.bool_3 && GClass84.gclass144_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bEnabled: ",
									GClass84.gclass144_0.bool_0 ? "<color=lime>" : "<color=red>",
									GClass84.gclass144_0.bool_0.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+O)";
								}
							}
							break;
						case 8:
							if (this.bool_3 && GClass84.gclass144_0 != null)
							{
								text = text + "TeleportObjects.Count: " + GClass84.gclass144_0.list_0.Count.ToString();
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+T)";
								}
								text = text + "\nTeleportObjects.GO.Count: " + GClass84.gclass144_0.method_2().ToString();
							}
							break;
						case 9:
							if (this.bool_3 && GClass84.gclass179_0 != null)
							{
								text += "\nUdon Manager:";
							}
							break;
						case 10:
							if (this.bool_3 && GClass84.gclass179_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bAutoCallEvents: ",
									GClass84.gclass179_0.bool_5 ? "<color=lime>" : "<color=red>",
									GClass84.gclass179_0.bool_5.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+E)";
								}
							}
							break;
						case 11:
							if (this.bool_3 && GClass84.gclass179_0 != null)
							{
								text = text + "EventsToCall.Count: " + GClass84.gclass179_0.list_1.Count.ToString();
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+C)";
								}
							}
							break;
						case 12:
							if (this.bool_3 && GClass84.gclass179_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bAntiUdon: ",
									GClass179.bool_2 ? "<color=lime>" : "<color=red>",
									GClass179.bool_2.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+U)";
								}
							}
							break;
						case 13:
							if (this.bool_3 && GClass84.gclass137_0 != null)
							{
								text += "\nTriggers Manager:";
							}
							break;
						case 14:
							if (this.bool_3 && GClass84.gclass137_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bAutoCallEvents: ",
									GClass84.gclass137_0.bool_8 ? "<color=lime>" : "<color=red>",
									GClass84.gclass137_0.bool_8.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+Z)";
								}
							}
							break;
						case 15:
							if (this.bool_3 && GClass84.gclass137_0 != null)
							{
								text = text + "EventsToCall.Count: " + GClass84.gclass137_0.list_2.Count.ToString();
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+X)";
								}
							}
							break;
						case 16:
							if (this.bool_3 && GClass84.gclass134_0 != null)
							{
								text += "\nEvents Manager:";
							}
							break;
						case 17:
							if (this.bool_3 && GClass84.gclass134_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bAutoCallEvents: ",
									GClass84.gclass134_0.bool_3 ? "<color=lime>" : "<color=red>",
									GClass84.gclass134_0.bool_3.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+B)";
								}
							}
							break;
						case 18:
							if (this.bool_3 && GClass84.gclass134_0 != null)
							{
								text = text + "EventsToCall.Count: " + GClass84.gclass134_0.list_0.Count.ToString();
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+N)";
								}
							}
							break;
						case 19:
							if (this.bool_3)
							{
								text += "\nGetAPI:";
							}
							break;
						case 20:
							if (this.bool_3)
							{
								text = text + "ActiveEventSpam_SpawnEmojiRPC.Count: " + GClass84.smethod_1420().ToString();
							}
							break;
						case 21:
							if (this.bool_3 && GClass84.gclass185_0 != null)
							{
								text = text + "ActiveDesync.Count: " + GClass84.smethod_1126().ToString();
							}
							break;
						case 22:
							if (this.bool_3 && GClass84.gclass185_0 != null)
							{
								text += "\nPhoton Manager:";
							}
							break;
						case 23:
							if (this.bool_3 && GClass84.gclass185_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bSerialize: ",
									GClass185.bool_12 ? "<color=lime>" : "<color=red>",
									GClass185.bool_12.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (`)";
								}
							}
							break;
						case 24:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text += "\nBots Manager:";
							}
							break;
						case 25:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bEnabled: ",
									GClass84.gclass148_0.bool_0 ? "<color=lime>" : "<color=red>",
									GClass84.gclass148_0.bool_0.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+J)";
								}
							}
							break;
						case 26:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = text + "OwnerID: " + GClass84.gclass148_0.string_1;
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+K)";
								}
							}
							break;
						case 27:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bFollowOwner: ",
									GClass84.gclass148_0.bool_1 ? "<color=lime>" : "<color=red>",
									GClass84.gclass148_0.bool_1.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+F)";
								}
							}
							break;
						case 28:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = text + "OrbitUserID: " + GClass84.gclass148_0.string_2;
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+M)";
								}
							}
							break;
						case 29:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = text + "LookAtUserID: " + GClass84.gclass148_0.string_4;
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+L)";
								}
							}
							break;
						case 30:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = string.Concat(new string[]
								{
									text,
									"bHidePosition: ",
									GClass84.gclass148_0.bool_2 ? "<color=lime>" : "<color=red>",
									GClass84.gclass148_0.bool_2.ToString(),
									"</color>"
								});
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+H)";
								}
							}
							break;
						case 31:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = text + "ParrotUserID: " + GClass84.gclass148_0.string_5;
								if (GClass84.bool_4)
								{
									text += " (Ctrl+Shift+Y)";
								}
							}
							break;
						case 32:
							if (this.bool_3 && GClass84.gclass148_0 != null)
							{
								text = text + "MimicUserID: " + GClass84.gclass148_0.string_6;
							}
							break;
						}
					}
				}
				else
				{
					switch (int_5)
					{
					case 0:
						text = text + "\n'CTRL+Q' to hide        FPS: " + ((GClass84.float_1 >= 10f) ? Mathf.Floor(GClass84.float_1).ToString() : GClass84.float_1.ToString("0.00"));
						break;
					case 1:
						if (this.bool_3)
						{
							text += "                  'CTRL+E' to close";
						}
						else
						{
							text += "                  'CTRL+E' to open";
						}
						break;
					case 2:
						if (this.bool_3)
						{
							text += ((GClass84.smethod_813() != null) ? ("\nUsers in room (" + GClass84.smethod_1063().ToString() + "):\n" + this.method_20()) : string.Empty);
						}
						break;
					case 3:
						if (this.bool_3)
						{
							text += ((GClass84.smethod_813() != null) ? ("Position in world:\n" + this.method_9(0)) : string.Empty);
						}
						break;
					case 4:
						if (this.bool_3)
						{
							text += ((GClass84.smethod_813() != null) ? this.method_9(1) : string.Empty);
						}
						break;
					}
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00053228 File Offset: 0x00051428
		internal void method_19()
		{
			this.gameObject_0 = new GameObject("AbyssUICanvas");
			GClass84.smethod_281(this.gameObject_0);
			this.gameObject_0.AddComponent<Canvas>().renderMode = 0;
			this.gameObject_0.transform.position = new Vector3(0f, 0f, 0f);
			CanvasScaler canvasScaler = this.gameObject_0.AddComponent<CanvasScaler>();
			canvasScaler.uiScaleMode = 1;
			canvasScaler.referenceResolution = new Vector2((float)Screen.width, (float)Screen.height);
			if (this.bool_1)
			{
				this.gameObject_1 = new GameObject("Background");
				this.gameObject_1.AddComponent<CanvasRenderer>();
				this.rawImage_0 = this.gameObject_1.AddComponent<RawImage>();
				this.rawImage_0.texture = GClass153.GClass86.texture2D_0;
				this.gameObject_2 = new GameObject("Text");
				this.gameObject_2.AddComponent<CanvasRenderer>();
				this.gameObject_2.transform.SetParent(this.gameObject_1.transform, false);
				this.text_0 = this.gameObject_2.AddComponent<Text>();
				this.text_0.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				this.text_0.fontSize = 15;
				this.text_0.text = string.Empty;
			}
			if (this.bool_2)
			{
				this.gameObject_3 = new GameObject("AltBackground");
				this.gameObject_3.AddComponent<CanvasRenderer>();
				this.rawImage_1 = this.gameObject_3.AddComponent<RawImage>();
				this.rawImage_1.texture = null;
				this.rawImage_1.enabled = false;
				this.gameObject_4 = new GameObject("Text");
				this.gameObject_4.AddComponent<CanvasRenderer>();
				this.gameObject_4.transform.SetParent(this.gameObject_3.transform, false);
				this.text_1 = this.gameObject_4.AddComponent<Text>();
				this.text_1.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				this.text_1.fontSize = this.int_4;
				this.text_1.text = string.Empty;
			}
			this.gameObject_5 = new GameObject("Background2");
			this.gameObject_5.AddComponent<CanvasRenderer>();
			this.gameObject_5.SetActive(this.bool_6);
			this.rawImage_2 = this.gameObject_5.AddComponent<RawImage>();
			this.rawImage_2.texture = GClass153.GClass86.texture2D_0;
			this.gameObject_6 = new GameObject("Text");
			this.gameObject_6.AddComponent<CanvasRenderer>();
			this.gameObject_6.transform.SetParent(this.gameObject_5.transform, false);
			this.text_2 = this.gameObject_6.AddComponent<Text>();
			this.text_2.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
			this.text_2.fontSize = 13;
			this.text_2.text = string.Empty;
			this.gameObject_0.SetActive(false);
			this.method_38();
			this.bool_4 = true;
			if (!GClass84.bool_5)
			{
				this.method_7();
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00053534 File Offset: 0x00051734
		internal string method_20()
		{
			return this.method_47();
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00053548 File Offset: 0x00051748
		private void method_21()
		{
			this.method_10();
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0005355C File Offset: 0x0005175C
		internal void method_22(bool bool_7)
		{
			this.bool_6 = bool_7;
			if (this.gameObject_5)
			{
				this.gameObject_5.SetActive(bool_7);
			}
			GClass84.gclass75_0.bool_0 = bool_7;
			GClass75.smethod_2();
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0005359C File Offset: 0x0005179C
		private void method_23()
		{
			this.method_29();
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000535B0 File Offset: 0x000517B0
		internal void method_24()
		{
			this.method_4();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000535C4 File Offset: 0x000517C4
		private void method_25()
		{
			this.method_6();
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000535D8 File Offset: 0x000517D8
		public override void vmethod_10()
		{
			this.method_37();
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000535EC File Offset: 0x000517EC
		internal void method_26(bool bool_7)
		{
			this.bool_5 = bool_7;
			if (this.gameObject_0)
			{
				this.gameObject_0.SetActive(this.bool_5);
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00053620 File Offset: 0x00051820
		internal void method_27()
		{
			this.list_0.Clear();
			this.list_1.Clear();
			for (int i = 0; i < this.int_0; i++)
			{
				this.list_0.Add(this.method_40(i, 0));
			}
			for (int j = 0; j < this.int_1; j++)
			{
				this.list_1.Add(this.method_40(j, 1));
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00053690 File Offset: 0x00051890
		internal void method_28()
		{
			this.method_27();
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000536A4 File Offset: 0x000518A4
		private void method_29()
		{
			this.method_50();
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000536B8 File Offset: 0x000518B8
		public override void vmethod_12()
		{
			this.method_46();
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000536CC File Offset: 0x000518CC
		public override void vmethod_19()
		{
			this.method_24();
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000536E0 File Offset: 0x000518E0
		internal bool method_30()
		{
			bool result;
			try
			{
				bool flag = false;
				if (this.gameObject_1)
				{
					this.gameObject_1.transform.SetParent(this.gameObject_0.transform, false);
					this.gameObject_1.GetComponent<RectTransform>().localPosition = new Vector2(this.float_0 / 2f - (float)Screen.width / 2f, (float)Screen.height / 2f - this.float_1 / 2f);
					flag = true;
				}
				if (this.gameObject_3)
				{
					this.gameObject_3.transform.SetParent(this.gameObject_0.transform, false);
					this.gameObject_3.GetComponent<RectTransform>().localPosition = new Vector2(this.float_2 / 2f - (float)Screen.width / 2f, (float)Screen.height / 2f - this.float_3 / 2f);
					flag = true;
				}
				if (this.gameObject_5)
				{
					this.gameObject_5.transform.SetParent(this.gameObject_0.transform, false);
					this.gameObject_5.GetComponent<RectTransform>().localPosition = new Vector2(-this.float_0 / 2f + (float)Screen.width / 2f, (float)Screen.height / 2f - this.float_1 / 2f);
					flag = true;
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00053880 File Offset: 0x00051A80
		internal void method_31()
		{
			this.method_55();
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00053894 File Offset: 0x00051A94
		internal void method_32(bool bool_7)
		{
			this.method_43(bool_7);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000538A8 File Offset: 0x00051AA8
		internal string method_33(int int_5)
		{
			string text = string.Empty;
			ApiWorld apiWorld = GClass84.smethod_1424();
			string result;
			if (apiWorld == null)
			{
				result = text;
			}
			else
			{
				if (int_5 != 0)
				{
					if (int_5 == 1)
					{
						text = text + "\nWorld name:\n" + apiWorld.name;
						text = text + "\n\nWorld creator:\n" + apiWorld.authorName;
					}
				}
				else
				{
					Transform transform = GClass84.smethod_981();
					if (transform)
					{
						Vector3 position = transform.position;
						text = text + "<b><color=red>X: " + position.x.ToString() + "</color></b>\n";
						text = text + "<b><color=lime>Y: " + position.y.ToString() + "</color></b>\n";
						text = text + "<b><color=cyan>Z: " + position.z.ToString() + "</color></b>";
					}
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0005397C File Offset: 0x00051B7C
		internal void method_34(bool bool_7)
		{
			this.method_49(bool_7);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00053990 File Offset: 0x00051B90
		private void method_35()
		{
			if (this.list_2.Count > 0)
			{
				this.list_2.Clear();
			}
			this.int_2 = 0;
			if (GClass84.smethod_1424() == null || GClass84.smethod_813() == null)
			{
				this.string_4 = string.Empty;
			}
			else
			{
				Room room = GClass84.smethod_1250();
				if (room != null)
				{
					foreach (int num in room.Method_Public_get_Dictionary_2_Int32_Player_0().Keys)
					{
						if (this.int_2 == this.int_3)
						{
							this.int_2 = room.Method_Public_get_Dictionary_2_Int32_Player_0().Keys.Count;
							break;
						}
						Player player = room.Method_Public_get_Dictionary_2_Int32_Player_0()[num];
						if (player != null)
						{
							Player field_Public_Player_ = player.field_Public_Player_0;
							if (field_Public_Player_)
							{
								VRCPlayer vrcplayer = GClass84.smethod_367(field_Public_Player_);
								APIUser apiuser = GClass84.smethod_518(field_Public_Player_);
								VRCPlayerApi vrcplayerApi = GClass84.smethod_28(field_Public_Player_);
								if (apiuser != null && vrcplayer && vrcplayerApi != null)
								{
									this.list_2.Add(string.Concat(new string[]
									{
										"<color=#",
										ColorUtility.ToHtmlStringRGB(GClass84.smethod_1084(apiuser)),
										">",
										vrcplayerApi.isMaster ? "[M] " : string.Empty,
										apiuser.isFriend ? "[F] " : string.Empty,
										apiuser.displayName,
										" | ID: ",
										num.ToString(),
										" | P: ",
										GClass84.smethod_506(vrcplayer).ToString(),
										" | F: ",
										GClass84.smethod_657(vrcplayer).ToString(),
										GClass84.smethod_1260(vrcplayerApi) ? " [VR]" : string.Empty,
										GClass84.smethod_307(apiuser) ? " [Q]" : string.Empty,
										"</color>"
									}));
									this.int_2++;
								}
							}
							else if (player.field_Private_Hashtable_0.ContainsKey("user"))
							{
								Dictionary<string, object> dictionary = GClass84.smethod_308<Hashtable>(player.field_Private_Hashtable_0)["user"] as Dictionary<string, object>;
								if (dictionary != null)
								{
									List<string> list = this.list_2;
									object obj = dictionary["displayName"];
									list.Add(((obj != null) ? obj.ToString() : null) + " | ID: " + num.ToString() + " | [Invisible]");
									this.int_2++;
								}
							}
						}
					}
				}
				this.string_4 = "Users in room (" + this.int_2.ToString() + "):";
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00053C58 File Offset: 0x00051E58
		internal string method_36(int int_5)
		{
			return this.method_33(int_5);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00053C6C File Offset: 0x00051E6C
		internal void method_37()
		{
			this.method_11();
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00053C80 File Offset: 0x00051E80
		internal bool method_38()
		{
			bool result;
			try
			{
				bool flag = false;
				if (this.gameObject_1)
				{
					this.gameObject_1.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_0, this.float_1);
					if (this.gameObject_2)
					{
						this.gameObject_2.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_0 - 6f, this.float_1);
					}
					flag = true;
				}
				if (this.gameObject_3)
				{
					this.gameObject_3.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_2, this.float_3);
					if (this.gameObject_4)
					{
						this.gameObject_4.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_2 - 6f, this.float_3);
					}
					flag = true;
				}
				if (this.gameObject_5)
				{
					this.gameObject_5.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_0, this.float_1);
					if (this.gameObject_6)
					{
						this.gameObject_6.GetComponent<RectTransform>().sizeDelta = new Vector2(this.float_0 - 6f, this.float_1);
					}
					flag = true;
				}
				if (flag)
				{
					this.method_30();
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00053DF0 File Offset: 0x00051FF0
		internal void method_39()
		{
			this.method_12();
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00053E04 File Offset: 0x00052004
		internal string method_40(int int_5, int int_6 = 0)
		{
			return this.method_51(int_5, int_6);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00053E1C File Offset: 0x0005201C
		internal string method_41()
		{
			string text = string.Empty;
			if (GClass84.smethod_1424() != null)
			{
				PlayerManager playerManager = GClass84.smethod_1472();
				if (playerManager)
				{
					try
					{
						int num = 0;
						Player[] array = GClass84.smethod_870();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i])
							{
								VRCPlayerApi vrcplayerApi = GClass84.smethod_28(array[i]);
								APIUser apiuser = GClass84.smethod_518(array[i]);
								VRCPlayer vrcplayer = GClass84.smethod_367(array[i]);
								if (vrcplayerApi != null && apiuser != null && vrcplayer && num != 27)
								{
									text = string.Concat(new string[]
									{
										text,
										vrcplayerApi.isMaster ? "♕ " : "     ",
										"<color=#",
										ColorUtility.ToHtmlStringRGB(GClass84.smethod_1084(apiuser)),
										">",
										apiuser.displayName,
										"</color> - ",
										GClass84.smethod_506(vrcplayer).ToString(),
										"ms ",
										GClass84.smethod_657(vrcplayer).ToString(),
										GClass84.smethod_1260(vrcplayerApi) ? " [VR]" : string.Empty,
										GClass84.smethod_307(apiuser) ? " [Q]" : string.Empty,
										"\n"
									});
									num++;
								}
							}
						}
						return text;
					}
					catch
					{
						return text;
					}
				}
			}
			return text;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00053FC0 File Offset: 0x000521C0
		internal void method_42(bool bool_7)
		{
			this.method_53(bool_7);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00053FD4 File Offset: 0x000521D4
		internal void method_43(bool bool_7)
		{
			this.method_15(bool_7);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00053FE8 File Offset: 0x000521E8
		internal void method_44()
		{
			this.method_52();
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00053FFC File Offset: 0x000521FC
		internal void method_45(int int_5)
		{
			this.int_4 = int_5;
			if (this.text_1)
			{
				this.text_1.fontSize = int_5;
			}
			GClass84.gclass75_0.int_0 = int_5;
			GClass75.smethod_2();
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0005403C File Offset: 0x0005223C
		internal void method_46()
		{
			this.method_54();
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00054050 File Offset: 0x00052250
		internal string method_47()
		{
			return this.method_41();
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00054064 File Offset: 0x00052264
		internal void method_48()
		{
			this.method_28();
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00054078 File Offset: 0x00052278
		internal void method_49(bool bool_7)
		{
			this.method_22(bool_7);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0005408C File Offset: 0x0005228C
		public override void vmethod_24()
		{
			this.method_44();
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000540A0 File Offset: 0x000522A0
		private void method_50()
		{
			Transform transform = GClass84.smethod_981();
			if (transform)
			{
				Vector3 position = transform.position;
				this.string_3 = string.Concat(new string[]
				{
					"X: ",
					position.x.ToString(),
					" | Y: ",
					position.y.ToString(),
					" | Z: ",
					position.z.ToString()
				});
			}
			else
			{
				this.string_3 = string.Empty;
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00054128 File Offset: 0x00052328
		internal string method_51(int int_5, int int_6)
		{
			return this.method_18(int_5, int_6);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00054140 File Offset: 0x00052340
		internal void method_52()
		{
			if (this.bool_0)
			{
				if (this.bool_1 && this.bool_5 && this.list_0.Count == this.int_0)
				{
					this.list_0[2] = this.method_40(2, 0);
				}
				if (this.bool_2 && this.bool_5 && this.bool_3)
				{
					this.method_16();
				}
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000541B0 File Offset: 0x000523B0
		internal void method_53(bool bool_7)
		{
			this.method_26(bool_7);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0005427C File Offset: 0x0005247C
		internal void method_54()
		{
			new GClass197().method_1();
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00054294 File Offset: 0x00052494
		internal void method_55()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_4.Add(new Action(this.vmethod_10));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_13.Add(new Action(this.vmethod_12));
			GClass75.smethod_1();
			GClass84.gclass75_0 = GClass75.gclass75_0;
			this.int_4 = GClass84.gclass75_0.int_0;
			this.bool_6 = GClass84.gclass75_0.bool_0;
			if (this.bool_0)
			{
				this.method_48();
			}
		}

		// Token: 0x04000B67 RID: 2919
		internal bool bool_0 = true;

		// Token: 0x04000B68 RID: 2920
		internal bool bool_1 = false;

		// Token: 0x04000B69 RID: 2921
		internal bool bool_2 = true;

		// Token: 0x04000B6A RID: 2922
		internal GameObject gameObject_0;

		// Token: 0x04000B6B RID: 2923
		internal GameObject gameObject_1;

		// Token: 0x04000B6C RID: 2924
		internal RawImage rawImage_0;

		// Token: 0x04000B6D RID: 2925
		internal GameObject gameObject_2;

		// Token: 0x04000B6E RID: 2926
		internal Text text_0;

		// Token: 0x04000B6F RID: 2927
		internal GameObject gameObject_3;

		// Token: 0x04000B70 RID: 2928
		internal RawImage rawImage_1;

		// Token: 0x04000B71 RID: 2929
		internal GameObject gameObject_4;

		// Token: 0x04000B72 RID: 2930
		internal Text text_1;

		// Token: 0x04000B73 RID: 2931
		internal GameObject gameObject_5;

		// Token: 0x04000B74 RID: 2932
		internal RawImage rawImage_2;

		// Token: 0x04000B75 RID: 2933
		internal GameObject gameObject_6;

		// Token: 0x04000B76 RID: 2934
		internal Text text_2;

		// Token: 0x04000B77 RID: 2935
		internal bool bool_3 = false;

		// Token: 0x04000B78 RID: 2936
		internal bool bool_4 = false;

		// Token: 0x04000B79 RID: 2937
		internal bool bool_5 = true;

		// Token: 0x04000B7A RID: 2938
		internal List<string> list_0 = new List<string>();

		// Token: 0x04000B7B RID: 2939
		internal int int_0 = 6;

		// Token: 0x04000B7C RID: 2940
		internal List<string> list_1 = new List<string>();

		// Token: 0x04000B7D RID: 2941
		internal int int_1 = 33;

		// Token: 0x04000B7E RID: 2942
		internal float float_0 = 256f;

		// Token: 0x04000B7F RID: 2943
		internal float float_1 = 768f;

		// Token: 0x04000B80 RID: 2944
		internal float float_2 = 512f;

		// Token: 0x04000B81 RID: 2945
		internal float float_3 = 1024f;

		// Token: 0x04000B82 RID: 2946
		private string string_1;

		// Token: 0x04000B83 RID: 2947
		private string string_2;

		// Token: 0x04000B84 RID: 2948
		private string string_3;

		// Token: 0x04000B85 RID: 2949
		private string string_4;

		// Token: 0x04000B86 RID: 2950
		private List<string> list_2 = new List<string>();

		// Token: 0x04000B87 RID: 2951
		private int int_2 = 0;

		// Token: 0x04000B88 RID: 2952
		private int int_3 = 40;

		// Token: 0x04000B89 RID: 2953
		internal int int_4 = 13;

		// Token: 0x04000B8A RID: 2954
		internal bool bool_6 = true;
	}
}
