using System;
using System.Collections.Generic;
using ns185;
using ns241;
using ns293;
using ns425;
using UnityEngine;

namespace ns440
{
	// Token: 0x02000142 RID: 322
	public class GClass144 : GClass130
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x0002E90C File Offset: 0x0002CB0C
		internal int method_2()
		{
			int num = 0;
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				num += this.list_0[i].list_0.Count;
			}
			return num;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002E954 File Offset: 0x0002CB54
		internal bool method_3(GClass144.GStruct93 gstruct93_0)
		{
			bool result = false;
			for (int i = gstruct93_0.list_3.Count - 1; i >= 0; i--)
			{
				GameObject gameObject = gstruct93_0.list_3[i];
				if (gameObject)
				{
					Object.DestroyImmediate(gameObject);
					result = true;
				}
			}
			gstruct93_0.list_3.Clear();
			gstruct93_0.list_4.Clear();
			gstruct93_0.list_2.Clear();
			gstruct93_0.list_5.Clear();
			gstruct93_0.list_6.Clear();
			gstruct93_0.list_7.Clear();
			return result;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		internal void method_4()
		{
			this.method_18();
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		internal void method_5()
		{
			this.method_23();
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002EA08 File Offset: 0x0002CC08
		public override void vmethod_12()
		{
			this.method_20();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		internal bool method_6(List<GameObject> list_1)
		{
			bool result;
			if (list_1 == null)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < list_1.Count; i++)
				{
					if (this.method_25(list_1[i]))
					{
						flag = true;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		internal bool method_7(int int_0)
		{
			bool result;
			if (int_0 < 0 || int_0 >= this.list_0.Count)
			{
				result = false;
			}
			else
			{
				this.method_3(this.list_0[int_0]);
				this.method_13(this.list_0[int_0]);
				this.method_27(this.list_0[int_0]);
				this.list_0.RemoveAt(int_0);
				result = true;
			}
			return result;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		internal void method_8()
		{
			new GClass96().method_0();
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002EB10 File Offset: 0x0002CD10
		internal void method_9()
		{
			this.method_29();
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002EB24 File Offset: 0x0002CD24
		public override void vmethod_23()
		{
			this.method_11();
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002EB38 File Offset: 0x0002CD38
		internal void method_10(bool bool_1)
		{
			this.method_17(bool_1);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002EB4C File Offset: 0x0002CD4C
		internal void method_11()
		{
			this.method_31();
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002EB60 File Offset: 0x0002CD60
		internal void method_12(bool bool_1)
		{
			this.method_10(bool_1);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002EB74 File Offset: 0x0002CD74
		internal bool method_13(GClass144.GStruct93 gstruct93_0)
		{
			bool result = false;
			if (gstruct93_0.gameObject_1)
			{
				Object.DestroyImmediate(gstruct93_0.gameObject_1);
				result = true;
			}
			return result;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002EBA0 File Offset: 0x0002CDA0
		public override void vmethod_19()
		{
			this.method_4();
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
		internal bool method_14(Transform transform_0, VRCPlayer vrcplayer_0, Vector3 vector3_0, GClass84.GEnum48 genum48_0 = GClass84.GEnum48.const_0, GClass144.GEnum34 genum34_0 = GClass144.GEnum34.const_0, GClass144.GEnum35 genum35_0 = GClass144.GEnum35.const_0, GClass144.GEnum36 genum36_0 = GClass144.GEnum36.const_0, float float_0 = 0f, float float_1 = 0f, float float_2 = 0f, float float_3 = 0f, float float_4 = 0f, float float_5 = 0f, float float_6 = 0f)
		{
			return transform_0 && this.method_24(transform_0.gameObject, vrcplayer_0, vector3_0, genum48_0, genum34_0, genum35_0, genum36_0, float_0, float_1, float_2, float_3, float_4, float_5, float_6);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
		internal void method_15(float float_0, float float_1, ref float float_2, ref bool bool_1)
		{
			this.method_19(float_0, float_1, ref float_2, ref bool_1);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002EC14 File Offset: 0x0002CE14
		internal bool method_16(List<GameObject> list_1, VRCPlayer vrcplayer_0, Vector3 vector3_0, GClass84.GEnum48 genum48_0 = GClass84.GEnum48.const_0, GClass144.GEnum34 genum34_0 = GClass144.GEnum34.const_0, GClass144.GEnum35 genum35_0 = GClass144.GEnum35.const_0, GClass144.GEnum36 genum36_0 = GClass144.GEnum36.const_0, float float_0 = 0f, float float_1 = 0f, float float_2 = 0f, float float_3 = 0f, float float_4 = 0f, float float_5 = 0f, float float_6 = 0f)
		{
			bool result;
			if (list_1.Count == 0 || !vrcplayer_0)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_1029(list_1);
				this.method_6(list_1);
				this.list_0.Add(new GClass144.GStruct93(list_1, vrcplayer_0, vector3_0, genum48_0, genum34_0, genum35_0, genum36_0, float_0, float_1, float_2, float_3, float_4, float_5, float_6));
				result = true;
			}
			return result;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002EC78 File Offset: 0x0002CE78
		internal void method_17(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		internal void method_18()
		{
			if (GClass84.bool_4)
			{
				if (Input.GetKey(306) && Input.GetKey(304))
				{
					if (Input.GetKeyDown(111))
					{
						this.method_12(!this.bool_0);
					}
					if (Input.GetKeyDown(116))
					{
						this.method_5();
					}
				}
				if (Input.GetKeyDown(27) || (GClass84.smethod_1108() && (Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickHorizontal") != 0f || Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") != 0f || Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickHorizontal") != 0f || Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical") != 0f)))
				{
					this.method_25(GClass84.smethod_461());
				}
			}
			if (this.bool_0)
			{
				try
				{
					for (int i = 0; i < this.list_0.Count; i++)
					{
						GClass144.GStruct93 gstruct = this.list_0[i];
						for (int j = gstruct.list_0.Count - 1; j >= 0; j--)
						{
							if (!gstruct.list_0[j])
							{
								gstruct.list_0.RemoveAt(j);
							}
						}
						if (gstruct.list_0.Count == 0)
						{
							this.method_7(i);
							i--;
						}
						else
						{
							bool flag = false;
							if (gstruct.genum48_0 != GClass84.GEnum48.const_6)
							{
								if (gstruct.list_1.Count == 0)
								{
									flag = true;
								}
								else
								{
									for (int k = gstruct.list_1.Count - 1; k >= 0; k--)
									{
										if (!gstruct.list_1[k])
										{
											flag = true;
											break;
										}
									}
								}
							}
							if (flag)
							{
								bool flag2;
								GClass84.smethod_444(gstruct.genum48_0, gstruct.vrcplayer_0, ref gstruct.list_1, out flag2);
								if (flag2)
								{
									this.list_0.RemoveAt(i);
									i--;
									goto IL_A45;
								}
							}
							switch (gstruct.genum34_0)
							{
							case GClass144.GEnum34.const_0:
							{
								Vector3 vector3_ = GClass84.smethod_1254(gstruct.genum48_0, gstruct.list_1, gstruct.vector3_0);
								GClass84.smethod_640(gstruct.list_0, vector3_, false);
								break;
							}
							case GClass144.GEnum34.const_1:
							{
								gstruct.gameObject_0.transform.position = GClass84.smethod_1254(gstruct.genum48_0, gstruct.list_1, gstruct.vector3_0) + new Vector3(0f, gstruct.float_2, 0f);
								if (gstruct.list_3.Count != gstruct.list_0.Count)
								{
									this.method_21(i);
									gstruct = this.list_0[i];
								}
								int count = gstruct.list_3.Count;
								switch (gstruct.genum35_0)
								{
								case GClass144.GEnum35.const_0:
									for (int l = 0; l < count; l++)
									{
										Vector2 value = gstruct.list_4[l];
										value.x = 0f;
										value.y = 0f;
										gstruct.list_4[l] = value;
										gstruct.list_2[l] = 0f;
										gstruct.list_5[l] = false;
									}
									gstruct.float_8 = 0f;
									break;
								case GClass144.GEnum35.const_1:
								{
									float value2 = gstruct.list_2[0];
									bool value3 = gstruct.list_5[0];
									this.method_15(gstruct.float_5, gstruct.float_6 * GClass84.float_0, ref value2, ref value3);
									for (int m = 0; m < count; m++)
									{
										Vector2 value4 = gstruct.list_4[m];
										value4.x = 0f;
										value4.y = 0f;
										gstruct.list_4[m] = value4;
										gstruct.list_2[m] = value2;
										gstruct.list_5[m] = value3;
									}
									gstruct.float_8 = 0f;
									break;
								}
								case GClass144.GEnum35.const_2:
									for (int n = 0; n < count; n++)
									{
										Vector2 value5 = gstruct.list_4[n];
										value5.x = 0f;
										value5.y = 0f;
										gstruct.list_4[n] = value5;
										gstruct.list_2[n] = 0f;
										gstruct.list_5[n] = false;
									}
									this.method_15(gstruct.float_5, gstruct.float_6 * GClass84.float_0, ref gstruct.float_8, ref gstruct.bool_0);
									break;
								case GClass144.GEnum35.const_3:
									for (int num = 0; num < count; num++)
									{
										float value6 = gstruct.list_2[num];
										bool value7 = gstruct.list_5[num];
										this.method_15(gstruct.float_5, gstruct.list_7[num] * GClass84.float_0, ref value6, ref value7);
										Vector2 value8 = gstruct.list_4[num];
										value8.x = 0f;
										value8.y = 0f;
										gstruct.list_4[num] = value8;
										gstruct.list_2[num] = value6;
										gstruct.list_5[num] = value7;
									}
									gstruct.float_8 = 0f;
									break;
								}
								gstruct.float_4 += gstruct.float_0 * 360f * GClass84.float_0;
								gstruct.float_4 %= 360f;
								Quaternion rotation = gstruct.gameObject_0.transform.rotation;
								rotation.eulerAngles = new Vector3(gstruct.float_8, gstruct.float_4, 0f);
								gstruct.gameObject_0.transform.rotation = rotation;
								GameObject gameObject_ = gstruct.gameObject_1;
								if (gameObject_)
								{
									for (int num2 = 0; num2 < count; num2++)
									{
										GameObject gameObject = gstruct.list_3[num2];
										if (gameObject)
										{
											Vector2 vector = gstruct.list_4[num2];
											Quaternion localRotation = gameObject.transform.localRotation;
											localRotation.eulerAngles = new Vector3(vector.x + gstruct.list_2[num2], gstruct.list_6[num2], vector.y + gstruct.float_3);
											gameObject.transform.localRotation = localRotation;
											gameObject_.transform.SetParent(gameObject.transform);
											gameObject_.transform.localPosition = new Vector3(0f, 0f, gstruct.float_1);
											gameObject_.transform.localRotation = default(Quaternion);
											gameObject_.transform.localScale = new Vector3(1f, 1f, 1f);
											GClass84.smethod_535(gstruct.list_0[num2], gameObject_.transform.position, false);
										}
									}
								}
								break;
							}
							case GClass144.GEnum34.const_2:
							{
								gstruct.gameObject_0.transform.position = GClass84.smethod_1254(gstruct.genum48_0, gstruct.list_1, gstruct.vector3_0) + new Vector3(0f, gstruct.float_2, 0f);
								int count2 = gstruct.list_0.Count;
								gstruct.float_4 += gstruct.float_0 * 360f * GClass84.float_0;
								gstruct.float_4 %= 360f;
								Quaternion rotation2 = gstruct.gameObject_0.transform.rotation;
								rotation2.eulerAngles = new Vector3(gstruct.float_8, gstruct.float_4, gstruct.float_3);
								gstruct.gameObject_0.transform.rotation = rotation2;
								if (gstruct.genum36_0 == GClass144.GEnum36.const_0)
								{
									int num3 = count2 / 2;
									int num4 = num3 / 2;
									int num5 = num4 / 2;
									float float_ = gstruct.float_1;
									GameObject gameObject_2 = gstruct.gameObject_1;
									if (gameObject_2)
									{
										gameObject_2.transform.SetParent(gstruct.gameObject_0.transform);
										for (int num6 = 0; num6 < count2; num6++)
										{
											Vector3 localPosition;
											if (num6 < num3)
											{
												if (num6 < num4)
												{
													localPosition..ctor(0f, (float)(num6 - num5) / (float)num4 * float_, 0f);
												}
												else
												{
													localPosition..ctor(((float)num6 - (float)num4 - (float)(num4 / 2)) / (float)num4 * float_, 0f, 0f);
												}
											}
											else
											{
												int num7 = num6 - num3;
												if (num7 < num4)
												{
													if (num7 <= num5)
													{
														localPosition..ctor(float_ / 2f, (float)(num7 - num5) / (float)num4 * float_, 0f);
													}
													else
													{
														localPosition..ctor(-float_ / 2f, (float)(num7 - num5) / (float)num4 * float_, 0f);
													}
												}
												else
												{
													num7 -= num4;
													if (num7 <= num5)
													{
														localPosition..ctor((float)(num7 - num5) / (float)num4 * float_, -float_ / 2f, 0f);
													}
													else
													{
														localPosition..ctor((float)(num7 - num5) / (float)num4 * float_, float_ / 2f, 0f);
													}
												}
											}
											gameObject_2.transform.localPosition = localPosition;
											gameObject_2.transform.localRotation = default(Quaternion);
											gameObject_2.transform.localScale = new Vector3(1f, 1f, 1f);
											GClass84.smethod_535(gstruct.list_0[num6], gameObject_2.transform.position, false);
											Rigidbody component = gstruct.list_0[num6].GetComponent<Rigidbody>();
											if (component)
											{
												component.velocity = new Vector3(0f, 0f, 0f);
											}
										}
									}
								}
								break;
							}
							}
							this.list_0[i] = gstruct;
						}
						IL_A45:;
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002F728 File Offset: 0x0002D928
		internal void method_19(float float_0, float float_1, ref float float_2, ref bool bool_1)
		{
			this.method_28(float_0, float_1, ref float_2, ref bool_1);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002F744 File Offset: 0x0002D944
		internal void method_20()
		{
			this.method_8();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0002F758 File Offset: 0x0002D958
		internal bool method_21(int int_0)
		{
			bool result;
			if (int_0 < 0 || int_0 >= this.list_0.Count)
			{
				result = false;
			}
			else
			{
				GClass144.GStruct93 gstruct = this.list_0[int_0];
				this.method_3(gstruct);
				gstruct.gameObject_0.transform.rotation.SetEulerAngles(0f, 0f, 0f);
				int count = gstruct.list_0.Count;
				for (int i = 0; i < count; i++)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.SetParent(gstruct.gameObject_0.transform);
					gameObject.transform.localPosition = default(Vector3);
					gstruct.list_3.Add(gameObject);
					gstruct.list_4.Add(new Vector3(0f, 0f));
					gstruct.list_2.Add(0f);
					gstruct.list_5.Add(false);
					gstruct.list_6.Add((float)i / (float)count * 360f);
					gstruct.list_7.Add(GClass84.smethod_910(gstruct.float_6, gstruct.float_7) + GClass84.smethod_1494(gstruct.float_6 - gstruct.float_7) * GClass84.smethod_790());
				}
				this.list_0[int_0] = gstruct;
				result = true;
			}
			return result;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0002F8C0 File Offset: 0x0002DAC0
		internal bool method_22(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < this.list_0.Count; i++)
				{
					for (int j = 0; j < this.list_0[i].list_0.Count; j++)
					{
						if (this.list_0[i].list_0[j] == gameObject_0)
						{
							return true;
						}
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0002F940 File Offset: 0x0002DB40
		internal void method_23()
		{
			this.method_30();
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002F954 File Offset: 0x0002DB54
		internal bool method_24(GameObject gameObject_0, VRCPlayer vrcplayer_0, Vector3 vector3_0, GClass84.GEnum48 genum48_0 = GClass84.GEnum48.const_0, GClass144.GEnum34 genum34_0 = GClass144.GEnum34.const_0, GClass144.GEnum35 genum35_0 = GClass144.GEnum35.const_0, GClass144.GEnum36 genum36_0 = GClass144.GEnum36.const_0, float float_0 = 0f, float float_1 = 0f, float float_2 = 0f, float float_3 = 0f, float float_4 = 0f, float float_5 = 0f, float float_6 = 0f)
		{
			bool result;
			if (!gameObject_0 || !vrcplayer_0)
			{
				result = false;
			}
			else
			{
				GClass84.smethod_994(gameObject_0);
				this.method_25(gameObject_0);
				this.list_0.Add(new GClass144.GStruct93(new List<GameObject>
				{
					gameObject_0
				}, vrcplayer_0, vector3_0, genum48_0, genum34_0, genum35_0, genum36_0, float_0, float_1, float_2, float_3, float_4, float_5, float_6));
				result = true;
			}
			return result;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		internal bool method_25(GameObject gameObject_0)
		{
			bool result;
			if (!gameObject_0)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					for (int j = this.list_0[i].list_0.Count - 1; j >= 0; j--)
					{
						if (this.list_0[i].list_0[j] == gameObject_0)
						{
							flag = true;
							this.list_0[i].list_0.RemoveAt(j);
						}
					}
					if (this.list_0[i].list_0.Count == 0)
					{
						this.list_0.RemoveAt(i);
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002FA98 File Offset: 0x0002DC98
		public override void vmethod_24()
		{
			this.method_9();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002FAAC File Offset: 0x0002DCAC
		internal bool method_26(List<Transform> list_1, VRCPlayer vrcplayer_0, Vector3 vector3_0, GClass84.GEnum48 genum48_0 = GClass84.GEnum48.const_0, GClass144.GEnum34 genum34_0 = GClass144.GEnum34.const_0, GClass144.GEnum35 genum35_0 = GClass144.GEnum35.const_0, GClass144.GEnum36 genum36_0 = GClass144.GEnum36.const_0, float float_0 = 0f, float float_1 = 0f, float float_2 = 0f, float float_3 = 0f, float float_4 = 0f, float float_5 = 0f, float float_6 = 0f)
		{
			return list_1.Count != 0 && this.method_16(GClass84.smethod_258(list_1), vrcplayer_0, vector3_0, genum48_0, genum34_0, genum35_0, genum36_0, float_0, float_1, float_2, float_3, float_4, float_5, float_6);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		internal bool method_27(GClass144.GStruct93 gstruct93_0)
		{
			bool result = false;
			if (gstruct93_0.gameObject_0)
			{
				Object.DestroyImmediate(gstruct93_0.gameObject_0);
				result = true;
			}
			return result;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		internal void method_28(float float_0, float float_1, ref float float_2, ref bool bool_1)
		{
			for (;;)
			{
				if ((bool_1 && float_1 > 0f) || (!bool_1 && float_1 < 0f))
				{
					float num = float_0 - float_2;
					if (GClass84.smethod_1494(float_1) <= num)
					{
						break;
					}
					float_1 -= num;
					float_2 += num * (float)(GClass84.smethod_712(bool_1) * 2 - 1);
					bool_1 = !bool_1;
				}
				else
				{
					float num2 = -float_0 - float_2;
					if (-GClass84.smethod_1494(float_1) >= num2)
					{
						goto IL_B0;
					}
					float_1 -= num2;
					float_2 += num2 * (float)(GClass84.smethod_712(bool_1) * 2 - 1);
					bool_1 = !bool_1;
				}
			}
			float_2 += float_1 * (float)(GClass84.smethod_712(bool_1) * 2 - 1);
			return;
			IL_B0:
			float_2 += float_1 * (float)(GClass84.smethod_712(bool_1) * 2 - 1);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		internal void method_29()
		{
			if (this.bool_0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					GClass84.smethod_220(this.list_0[i].list_0, true);
				}
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002FC40 File Offset: 0x0002DE40
		internal void method_30()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				this.method_7(i);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002FC74 File Offset: 0x0002DE74
		internal void method_31()
		{
			GClass84.list_3.Add(new Action(this.vmethod_24));
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x040008BA RID: 2234
		internal bool bool_0 = true;

		// Token: 0x040008BB RID: 2235
		internal List<GClass144.GStruct93> list_0 = new List<GClass144.GStruct93>();

		// Token: 0x02000143 RID: 323
		public enum GEnum34
		{
			// Token: 0x040008BD RID: 2237
			const_0,
			// Token: 0x040008BE RID: 2238
			const_1,
			// Token: 0x040008BF RID: 2239
			const_2
		}

		// Token: 0x02000144 RID: 324
		public enum GEnum35
		{
			// Token: 0x040008C1 RID: 2241
			const_0,
			// Token: 0x040008C2 RID: 2242
			const_1,
			// Token: 0x040008C3 RID: 2243
			const_2,
			// Token: 0x040008C4 RID: 2244
			const_3
		}

		// Token: 0x02000145 RID: 325
		public enum GEnum36
		{
			// Token: 0x040008C6 RID: 2246
			const_0
		}

		// Token: 0x02000146 RID: 326
		public struct GStruct93
		{
			// Token: 0x06000B6C RID: 2924 RVA: 0x0002FCC8 File Offset: 0x0002DEC8
			public GStruct93(List<GameObject> list_8, VRCPlayer vrcplayer_1, Vector3 vector3_1, GClass84.GEnum48 genum48_1 = GClass84.GEnum48.const_0, GClass144.GEnum34 genum34_1 = GClass144.GEnum34.const_0, GClass144.GEnum35 genum35_1 = GClass144.GEnum35.const_0, GClass144.GEnum36 genum36_1 = GClass144.GEnum36.const_0, float float_9 = 0f, float float_10 = 0f, float float_11 = 0f, float float_12 = 0f, float float_13 = 0f, float float_14 = 0f, float float_15 = 0f)
			{
				this.list_0 = list_8;
				this.genum48_0 = genum48_1;
				this.genum34_0 = genum34_1;
				this.genum35_0 = genum35_1;
				this.genum36_0 = genum36_1;
				this.vrcplayer_0 = vrcplayer_1;
				this.vector3_0 = vector3_1;
				this.float_0 = float_9;
				this.float_1 = float_10;
				this.float_2 = float_11;
				this.float_3 = float_12;
				this.float_4 = 0f;
				this.float_5 = float_13;
				this.float_6 = float_14;
				this.float_7 = float_15;
				this.list_1 = new List<Transform>();
				this.float_8 = 0f;
				this.list_2 = new List<float>();
				this.gameObject_0 = new GameObject("Orbit");
				GClass84.smethod_281(this.gameObject_0);
				this.gameObject_1 = new GameObject("TempGameObject");
				this.gameObject_1.transform.SetParent(this.gameObject_0.transform);
				this.list_3 = new List<GameObject>();
				this.list_4 = new List<Vector2>();
				this.bool_0 = false;
				this.list_5 = new List<bool>();
				this.list_6 = new List<float>();
				this.list_7 = new List<float>();
			}

			// Token: 0x040008C7 RID: 2247
			public List<GameObject> list_0;

			// Token: 0x040008C8 RID: 2248
			public GClass84.GEnum48 genum48_0;

			// Token: 0x040008C9 RID: 2249
			public GClass144.GEnum34 genum34_0;

			// Token: 0x040008CA RID: 2250
			public GClass144.GEnum35 genum35_0;

			// Token: 0x040008CB RID: 2251
			public GClass144.GEnum36 genum36_0;

			// Token: 0x040008CC RID: 2252
			public VRCPlayer vrcplayer_0;

			// Token: 0x040008CD RID: 2253
			public Vector3 vector3_0;

			// Token: 0x040008CE RID: 2254
			public float float_0;

			// Token: 0x040008CF RID: 2255
			public float float_1;

			// Token: 0x040008D0 RID: 2256
			public float float_2;

			// Token: 0x040008D1 RID: 2257
			public float float_3;

			// Token: 0x040008D2 RID: 2258
			public float float_4;

			// Token: 0x040008D3 RID: 2259
			public float float_5;

			// Token: 0x040008D4 RID: 2260
			public float float_6;

			// Token: 0x040008D5 RID: 2261
			public float float_7;

			// Token: 0x040008D6 RID: 2262
			public List<Transform> list_1;

			// Token: 0x040008D7 RID: 2263
			public float float_8;

			// Token: 0x040008D8 RID: 2264
			public List<float> list_2;

			// Token: 0x040008D9 RID: 2265
			public GameObject gameObject_0;

			// Token: 0x040008DA RID: 2266
			public GameObject gameObject_1;

			// Token: 0x040008DB RID: 2267
			public List<GameObject> list_3;

			// Token: 0x040008DC RID: 2268
			public List<Vector2> list_4;

			// Token: 0x040008DD RID: 2269
			public bool bool_0;

			// Token: 0x040008DE RID: 2270
			public List<bool> list_5;

			// Token: 0x040008DF RID: 2271
			public List<float> list_6;

			// Token: 0x040008E0 RID: 2272
			public List<float> list_7;
		}
	}
}
