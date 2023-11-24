using System;
using ns241;
using ns425;
using UnityEngine;

namespace ns477
{
	// Token: 0x02000336 RID: 822
	public class GClass180 : GClass130
	{
		// Token: 0x06004676 RID: 18038 RVA: 0x001080F0 File Offset: 0x001062F0
		internal void method_2()
		{
			this.method_5();
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x00108104 File Offset: 0x00106304
		public override void vmethod_19()
		{
			this.method_2();
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x00108118 File Offset: 0x00106318
		public override void vmethod_12()
		{
			this.method_3();
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x0010812C File Offset: 0x0010632C
		internal void method_3()
		{
			this.method_8();
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x00108140 File Offset: 0x00106340
		internal Vector3 method_4(GClass180.GEnum82 genum82_1)
		{
			Vector3 result;
			switch (genum82_1)
			{
			case GClass180.GEnum82.const_0:
				result = this.gameObject_3.transform.position;
				break;
			case GClass180.GEnum82.const_1:
				result = this.gameObject_3.transform.position - this.gameObject_1.transform.forward * 2f;
				break;
			case GClass180.GEnum82.const_2:
				result = this.gameObject_3.transform.position - this.gameObject_0.transform.forward * 2f;
				break;
			case GClass180.GEnum82.const_3:
				result = this.gameObject_3.transform.position - this.gameObject_2.transform.forward * 2f;
				break;
			default:
				result = this.gameObject_3.transform.position;
				break;
			}
			return result;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00108228 File Offset: 0x00106428
		public override void vmethod_23()
		{
			this.method_7();
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x0010823C File Offset: 0x0010643C
		internal void method_5()
		{
			if (this.gameObject_0 && this.gameObject_1 && this.gameObject_2)
			{
				bool flag = false;
				if (Input.GetKey(306))
				{
					if (Input.GetKeyDown(49))
					{
						this.genum82_0 = GClass180.GEnum82.const_0;
						flag = true;
					}
					else if (Input.GetKeyDown(50))
					{
						this.genum82_0 = GClass180.GEnum82.const_1;
						flag = true;
					}
					else if (Input.GetKeyDown(51))
					{
						this.genum82_0 = GClass180.GEnum82.const_2;
						flag = true;
					}
					else if (Input.GetKeyDown(52))
					{
						this.genum82_0 = GClass180.GEnum82.const_3;
						flag = true;
					}
					else if (this.genum82_0 == GClass180.GEnum82.const_3 && Input.GetKeyDown(53))
					{
						this.genum82_0 = GClass180.GEnum82.const_0;
						flag = true;
						GClass84.smethod_1740(this.gameObject_2.transform.position, true);
					}
				}
				if (Input.GetKeyDown(325))
				{
					if (this.genum82_0 == GClass180.GEnum82.const_0)
					{
						this.genum82_0 = GClass180.GEnum82.const_2;
						flag = true;
					}
					else if (this.genum82_0 == GClass180.GEnum82.const_2)
					{
						this.genum82_0 = GClass180.GEnum82.const_1;
						flag = true;
					}
					else
					{
						this.genum82_0 = GClass180.GEnum82.const_0;
						flag = true;
					}
				}
				if (flag)
				{
					this.gameObject_0.GetComponent<Camera>().enabled = false;
					this.gameObject_1.GetComponent<Camera>().enabled = false;
					this.gameObject_2.GetComponent<Camera>().enabled = false;
					this.gameObject_3.GetComponent<Camera>().enabled = false;
					switch (this.genum82_0)
					{
					case GClass180.GEnum82.const_0:
						this.gameObject_3.GetComponent<Camera>().enabled = true;
						break;
					case GClass180.GEnum82.const_1:
						this.gameObject_1.GetComponent<Camera>().enabled = true;
						this.gameObject_1.transform.position = this.method_4(this.genum82_0);
						break;
					case GClass180.GEnum82.const_2:
						this.gameObject_0.GetComponent<Camera>().enabled = true;
						this.gameObject_0.transform.position = this.method_4(this.genum82_0);
						break;
					case GClass180.GEnum82.const_3:
						this.gameObject_2.GetComponent<Camera>().enabled = true;
						this.gameObject_2.transform.position = this.method_4(this.genum82_0);
						break;
					}
				}
				GClass180.GEnum82 genum = this.genum82_0;
				GClass180.GEnum82 genum2 = genum;
				if (genum2 != GClass180.GEnum82.const_0)
				{
					float axis = Input.GetAxis("Mouse ScrollWheel");
					float num = (axis > 0f) ? this.method_6(false) : ((axis < 0f) ? (-this.method_6(false)) : 0f);
					switch (this.genum82_0)
					{
					case GClass180.GEnum82.const_1:
						this.gameObject_1.transform.position += this.gameObject_1.transform.forward * num;
						break;
					case GClass180.GEnum82.const_2:
						this.gameObject_0.transform.position += this.gameObject_0.transform.forward * num;
						break;
					case GClass180.GEnum82.const_3:
					{
						Transform transform = this.gameObject_2.transform;
						if (Input.GetKey(112))
						{
							Quaternion rotation = transform.rotation;
							rotation.x = 0f;
							rotation.y = 0f;
							rotation.z = 0f;
							rotation.w = 0f;
							transform.rotation = rotation;
						}
						transform.position += transform.forward * num;
						num = this.method_6(true) / 3f;
						if (Input.GetKey(273) || Input.GetKey(103))
						{
							transform.position += transform.forward * num;
						}
						if (Input.GetKey(274) || Input.GetKey(98))
						{
							transform.position -= transform.forward * num;
						}
						if (Input.GetKey(275) || Input.GetKey(110))
						{
							transform.position += transform.right * num;
						}
						if (Input.GetKey(276) || Input.GetKey(118))
						{
							transform.position -= transform.right * num;
						}
						if (Input.GetKey(104))
						{
							transform.position += transform.up * num;
						}
						if (Input.GetKey(102))
						{
							transform.position -= transform.up * num;
						}
						Vector3 eulerAngles = transform.rotation.eulerAngles;
						if (Input.GetKey(121))
						{
							eulerAngles.x = 0f;
							eulerAngles.y = 0f;
							eulerAngles.z = 0f;
						}
						else
						{
							num = 90f * Time.deltaTime;
							if (Input.GetKey(105))
							{
								eulerAngles.x -= num;
							}
							if (Input.GetKey(107))
							{
								eulerAngles.x += num;
							}
							if (Input.GetKey(108))
							{
								eulerAngles.y += num;
							}
							if (Input.GetKey(106))
							{
								eulerAngles.y -= num;
							}
							if (Input.GetKey(117))
							{
								eulerAngles.z += num;
							}
							if (Input.GetKey(111))
							{
								eulerAngles.z -= num;
							}
							while (eulerAngles.x < 0f)
							{
								eulerAngles.x += 360f;
							}
							while (eulerAngles.y < 0f)
							{
								eulerAngles.y += 360f;
							}
							while (eulerAngles.z < 0f)
							{
								eulerAngles.z += 360f;
							}
							eulerAngles.x %= 360f;
							eulerAngles.y %= 360f;
							eulerAngles.z %= 360f;
						}
						Quaternion rotation2 = transform.rotation;
						rotation2.eulerAngles = eulerAngles;
						transform.rotation = rotation2;
						break;
					}
					}
				}
			}
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x0010887C File Offset: 0x00106A7C
		internal float method_6(bool bool_0 = false)
		{
			float result;
			if (bool_0)
			{
				result = (Input.GetKey(303) ? (Input.GetKey(305) ? 1f : 0.3f) : (Input.GetKey(305) ? 0.01f : 0.1f));
			}
			else
			{
				result = (Input.GetKey(304) ? (Input.GetKey(306) ? 1f : 0.3f) : (Input.GetKey(306) ? 0.01f : 0.1f));
			}
			return result;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00108910 File Offset: 0x00106B10
		internal void method_7()
		{
			this.method_9();
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00108924 File Offset: 0x00106B24
		internal void method_8()
		{
			this.gameObject_3 = GameObject.Find("Camera (eye)");
			if (!this.gameObject_3)
			{
				this.gameObject_3 = GameObject.Find("CenterEyeAnchor");
			}
			if (this.gameObject_3)
			{
				GameObject gameObject = this.gameObject_3;
				Transform transform = gameObject.transform;
				GameObject gameObject2 = new GameObject("Camera_Back");
				Transform transform2 = gameObject2.transform;
				transform2.localScale = transform.localScale;
				Rigidbody rigidbody = gameObject2.AddComponent<Rigidbody>();
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
				Camera camera = gameObject2.AddComponent<Camera>();
				transform2.parent = transform;
				transform2.rotation = transform.rotation;
				transform2.position = transform.position;
				transform2.position -= transform2.forward * 2f;
				camera.fieldOfView = 60f;
				camera.nearClipPlane = 0.01f;
				this.gameObject_0 = gameObject2;
				GameObject gameObject3 = new GameObject("Camera_Front");
				Transform transform3 = gameObject3.transform;
				transform3.localScale = transform.localScale;
				Rigidbody rigidbody2 = gameObject3.AddComponent<Rigidbody>();
				rigidbody2.isKinematic = true;
				rigidbody2.useGravity = false;
				Camera camera2 = gameObject3.AddComponent<Camera>();
				transform3.parent = transform;
				transform3.rotation = transform.rotation;
				transform3.Rotate(0f, 180f, 0f);
				transform3.position = transform.position;
				transform3.position -= transform3.forward * 2f;
				camera2.fieldOfView = 60f;
				camera2.nearClipPlane = 0.01f;
				this.gameObject_1 = gameObject3;
				transform2.parent = transform;
				GameObject gameObject4 = new GameObject("Camera_Free");
				Object.DontDestroyOnLoad(gameObject4);
				Transform transform4 = gameObject4.transform;
				transform4.localScale = transform.localScale;
				Camera camera3 = gameObject4.AddComponent<Camera>();
				transform4.rotation = transform.rotation;
				transform4.position = transform.position;
				transform4.position -= transform4.forward * 2f;
				camera3.fieldOfView = 60f;
				camera3.nearClipPlane = 0.01f;
				this.gameObject_2 = gameObject4;
				this.gameObject_0.GetComponent<Camera>().enabled = false;
				this.gameObject_1.GetComponent<Camera>().enabled = false;
				this.gameObject_2.GetComponent<Camera>().enabled = false;
				this.gameObject_3.GetComponent<Camera>().enabled = true;
				this.gameObject_3.GetComponent<Camera>().allowHDR = true;
			}
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00108BD4 File Offset: 0x00106DD4
		internal void method_9()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_13.Add(new Action(this.vmethod_12));
		}

		// Token: 0x04001AB4 RID: 6836
		internal GameObject gameObject_0;

		// Token: 0x04001AB5 RID: 6837
		internal GameObject gameObject_1;

		// Token: 0x04001AB6 RID: 6838
		internal GameObject gameObject_2;

		// Token: 0x04001AB7 RID: 6839
		internal GameObject gameObject_3;

		// Token: 0x04001AB8 RID: 6840
		internal GClass180.GEnum82 genum82_0;

		// Token: 0x02000337 RID: 823
		public enum GEnum82
		{
			// Token: 0x04001ABA RID: 6842
			const_0,
			// Token: 0x04001ABB RID: 6843
			const_1,
			// Token: 0x04001ABC RID: 6844
			const_2,
			// Token: 0x04001ABD RID: 6845
			const_3
		}
	}
}
