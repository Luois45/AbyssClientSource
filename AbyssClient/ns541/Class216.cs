using System;
using System.Collections;
using UnityEngine;

namespace ns541
{
	// Token: 0x0200039C RID: 924
	internal class Class216 : MonoBehaviour
	{
		// Token: 0x06004A0B RID: 18955 RVA: 0x00119C9C File Offset: 0x00117E9C
		private void method_0()
		{
			this.method_3();
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00119CB0 File Offset: 0x00117EB0
		private void method_1()
		{
			this.method_14();
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00119CC4 File Offset: 0x00117EC4
		private Vector3 method_2(Vector3 vector3_6)
		{
			return base.gameObject.transform.TransformPoint(vector3_6);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x00119CE4 File Offset: 0x00117EE4
		private void method_3()
		{
			if (this.float_4 != this.float_0)
			{
				this.float_4 = this.float_0;
				for (int i = 0; i < this.vector3_5.Length; i++)
				{
					this.vector3_5[i] = this.vector3_5[i].normalized * this.float_0;
				}
			}
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x00119D50 File Offset: 0x00117F50
		private void method_4()
		{
			this.method_7();
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x00119D64 File Offset: 0x00117F64
		private void method_5()
		{
			if (this.float_3 != this.float_1)
			{
				this.float_3 = this.float_1;
				for (int i = 0; i < this.vector3_2.Length; i++)
				{
					this.vector3_3[i] = this.vector3_2[i].normalized * this.float_1;
				}
			}
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00119DD0 File Offset: 0x00117FD0
		private void method_6()
		{
			Renderer component = base.gameObject.GetComponent<Renderer>();
			if (component != null)
			{
				component.enabled = this.bool_0;
			}
			if (this.int_0 > 3)
			{
				this.material_0.SetPass(0);
				GL.Color(this.color_0);
				if (this.float_2 == 1f)
				{
					GL.Begin(4);
					if (this.bool_1)
					{
						for (int i = 0; i < this.int_0; i++)
						{
							GL.Vertex(this.method_2(this.vector3_0[i]));
							GL.Vertex(this.method_2(this.vector3_1[i]));
						}
					}
					if (this.float_0 > 0f)
					{
						this.method_10();
						for (int j = 0; j < this.vector3_5.Length; j++)
						{
							Vector3 vector = this.method_2(this.vector3_4[j]);
							GL.Vertex(vector);
							GL.Vertex(vector + this.vector3_5[j]);
						}
					}
					if (this.float_1 > 0f)
					{
						this.method_1();
						for (int k = 0; k < this.vector3_2.Length; k++)
						{
							Vector3 vector2 = this.method_2(this.vector3_2[k]);
							GL.Vertex(vector2);
							GL.Vertex(vector2 + this.vector3_3[k]);
						}
					}
				}
				else
				{
					GL.Begin(3);
					for (int l = 0; l < this.int_0; l++)
					{
						this.method_11(this.method_2(this.vector3_0[l]), this.method_2(this.vector3_1[l]));
					}
					if (this.float_1 > 0f)
					{
						this.method_1();
						for (int m = 0; m < this.vector3_2.Length; m++)
						{
							Vector3 vector3 = this.method_2(this.vector3_2[m]);
							this.method_11(vector3, vector3 + this.vector3_3[m]);
						}
					}
					if (this.float_0 > 0f)
					{
						this.method_10();
						for (int n = 0; n < this.vector3_5.Length; n++)
						{
							Vector3 vector4 = this.method_2(this.vector3_4[n]);
							this.method_11(vector4, vector4 + this.vector3_5[n]);
						}
					}
				}
				GL.End();
			}
			else
			{
				MonoBehaviour.print("No lines");
			}
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0011A078 File Offset: 0x00118278
		private void method_7()
		{
			this.method_6();
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x0011A08C File Offset: 0x0011828C
		private void method_8()
		{
			this.method_9();
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x0011A150 File Offset: 0x00118350
		private void method_9()
		{
			this.method_15();
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x0011A164 File Offset: 0x00118364
		private void method_10()
		{
			this.method_0();
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x0011A178 File Offset: 0x00118378
		private void method_11(Vector3 vector3_6, Vector3 vector3_7)
		{
			this.method_12(vector3_6, vector3_7);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x0011A190 File Offset: 0x00118390
		private void method_12(Vector3 vector3_6, Vector3 vector3_7)
		{
			this.method_13(vector3_6, vector3_7);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x0011A1A8 File Offset: 0x001183A8
		private void method_13(Vector3 vector3_6, Vector3 vector3_7)
		{
			float num = 1f / (float)Screen.width * this.float_2 * 0.5f;
			Vector3 vector = Camera.main.transform.position - (vector3_7 + vector3_6) / 2f;
			Vector3 vector2 = vector3_7 - vector3_6;
			Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * num;
			GL.Vertex(vector3_6 - vector3);
			GL.Vertex(vector3_6 + vector3);
			GL.Vertex(vector3_7 + vector3);
			GL.Vertex(vector3_7 - vector3);
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x0011A244 File Offset: 0x00118444
		private void method_14()
		{
			this.method_5();
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x0011A258 File Offset: 0x00118458
		private void method_15()
		{
			if (this.material_0 == null)
			{
				this.material_0 = new Material("Shader \"Lines/Colored Blended\" {SubShader { Pass {   BindChannels { Bind \"Color\",color }   Blend SrcAlpha OneMinusSrcAlpha   ZWrite on Cull Off Fog { Mode Off }} } }");
			}
			this.material_0.hideFlags = 61;
			this.material_0.shader.hideFlags = 61;
			MeshFilter component = base.gameObject.GetComponent<MeshFilter>();
			this.vector3_2 = component.mesh.vertices;
			this.vector3_3 = new Vector3[this.vector3_2.Length];
			int[] array = component.mesh.triangles;
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			ArrayList arrayList3 = new ArrayList();
			ArrayList arrayList4 = new ArrayList();
			int num = 0;
			while (num + 2 < array.Length)
			{
				Vector3 vector = this.vector3_2[array[num]];
				Vector3 vector2 = this.vector3_2[array[num + 1]];
				Vector3 vector3 = this.vector3_2[array[num + 2]];
				bool[] array2 = new bool[3];
				for (int i = 0; i < this.int_0; i++)
				{
					if (arrayList[i].Equals(vector))
					{
						if (arrayList2[i].Equals(vector2))
						{
							array2[0] = true;
						}
						else if (arrayList2[i].Equals(vector3))
						{
							array2[2] = true;
						}
					}
					else if (arrayList[i].Equals(vector2))
					{
						if (arrayList2[i].Equals(vector))
						{
							array2[0] = true;
						}
						else if (arrayList2[i].Equals(vector3))
						{
							array2[1] = true;
						}
					}
					else if (arrayList[i].Equals(vector3))
					{
						if (arrayList2[i].Equals(vector))
						{
							array2[2] = true;
						}
						else if (arrayList2[i].Equals(vector2))
						{
							array2[1] = true;
						}
					}
				}
				if (!array2[0])
				{
					arrayList.Add(vector);
					arrayList2.Add(vector2);
					this.int_0++;
				}
				else
				{
					this.int_1++;
				}
				if (!array2[1])
				{
					arrayList.Add(vector2);
					arrayList2.Add(vector3);
					this.int_0++;
				}
				else
				{
					this.int_1++;
				}
				if (!array2[2])
				{
					arrayList.Add(vector3);
					arrayList2.Add(vector);
					this.int_0++;
				}
				else
				{
					this.int_1++;
				}
				arrayList3.Add((vector + vector2 + vector3) * 0.333333343f);
				arrayList4.Add(Vector3.Cross(vector2 - vector, vector3 - vector).normalized);
				num += 3;
			}
			this.vector3_0 = (Vector3[])arrayList.ToArray(typeof(Vector3));
			arrayList.Clear();
			this.vector3_1 = (Vector3[])arrayList2.ToArray(typeof(Vector3));
			arrayList2.Clear();
			this.vector3_4 = (Vector3[])arrayList3.ToArray(typeof(Vector3));
			arrayList3.Clear();
			this.vector3_5 = (Vector3[])arrayList4.ToArray(typeof(Vector3));
			arrayList4.Clear();
		}

		// Token: 0x04001D29 RID: 7465
		internal bool bool_0 = true;

		// Token: 0x04001D2A RID: 7466
		internal bool bool_1 = true;

		// Token: 0x04001D2B RID: 7467
		internal float float_0 = 1f;

		// Token: 0x04001D2C RID: 7468
		internal float float_1 = 1f;

		// Token: 0x04001D2D RID: 7469
		internal float float_2 = 1f;

		// Token: 0x04001D2E RID: 7470
		internal Color color_0 = new Color(0f, 1f, 1f);

		// Token: 0x04001D2F RID: 7471
		internal Color color_1 = new Color(0f, 0.5f, 0.5f);

		// Token: 0x04001D30 RID: 7472
		internal bool bool_2 = true;

		// Token: 0x04001D31 RID: 7473
		internal bool bool_3 = true;

		// Token: 0x04001D32 RID: 7474
		internal bool bool_4 = true;

		// Token: 0x04001D33 RID: 7475
		internal int int_0 = 0;

		// Token: 0x04001D34 RID: 7476
		internal int int_1 = 0;

		// Token: 0x04001D35 RID: 7477
		private Vector3[] vector3_0;

		// Token: 0x04001D36 RID: 7478
		private Vector3[] vector3_1;

		// Token: 0x04001D37 RID: 7479
		private Vector3[] vector3_2;

		// Token: 0x04001D38 RID: 7480
		private Vector3[] vector3_3;

		// Token: 0x04001D39 RID: 7481
		private Vector3[] vector3_4;

		// Token: 0x04001D3A RID: 7482
		private Vector3[] vector3_5;

		// Token: 0x04001D3B RID: 7483
		internal Material material_0;

		// Token: 0x04001D3C RID: 7484
		private float float_3 = 0f;

		// Token: 0x04001D3D RID: 7485
		private float float_4 = 0f;
	}
}
