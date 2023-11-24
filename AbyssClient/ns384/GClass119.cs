using System;
using System.Collections.Generic;

namespace ns384
{
	// Token: 0x020002EA RID: 746
	public class GClass119<T>
	{
		// Token: 0x06003F67 RID: 16231 RVA: 0x000EF8F4 File Offset: 0x000EDAF4
		private void method_0(int int_0)
		{
			this.method_10(int_0);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x000EF908 File Offset: 0x000EDB08
		private void method_1(int int_0, int int_1)
		{
			T value = this.list_0[int_0];
			T value2 = this.list_0[int_1];
			this.list_0[int_0] = value2;
			this.list_0[int_1] = value;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x000EF94C File Offset: 0x000EDB4C
		private void method_2(int int_0, int int_1)
		{
			this.method_5(int_0, int_1);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x000EF964 File Offset: 0x000EDB64
		private void method_3(int int_0)
		{
			this.method_0(int_0);
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000EF978 File Offset: 0x000EDB78
		public void method_4(T gparam_0)
		{
			this.method_7(gparam_0);
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x000EF98C File Offset: 0x000EDB8C
		private void method_5(int int_0, int int_1)
		{
			this.method_1(int_0, int_1);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x000EF9A4 File Offset: 0x000EDBA4
		public T method_6()
		{
			T result;
			if (this.list_0.Count == 0)
			{
				result = default(T);
			}
			else
			{
				result = this.list_0[0];
			}
			return result;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x000EF9DC File Offset: 0x000EDBDC
		public int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x000EF9F4 File Offset: 0x000EDBF4
		internal void method_7(T gparam_0)
		{
			this.method_13(gparam_0);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x000EFA08 File Offset: 0x000EDC08
		public T method_8()
		{
			T result;
			if (this.list_0.Count == 0)
			{
				result = default(T);
			}
			else
			{
				this.Swap(0, this.list_0.Count - 1);
				T t = this.list_0[this.list_0.Count - 1];
				this.list_0.RemoveAt(this.list_0.Count - 1);
				this.SiftDown(0);
				result = t;
			}
			return result;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x000EFA80 File Offset: 0x000EDC80
		private void method_9(int int_0)
		{
			this.method_11(int_0);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x000EFA94 File Offset: 0x000EDC94
		public GClass119(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
			this.list_0 = new List<T>();
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x000EFABC File Offset: 0x000EDCBC
		private void method_10(int int_0)
		{
			if (int_0 != 0)
			{
				int num = (int_0 - 1) / 2;
				int num2 = this.icomparer_0.Compare(this.list_0[int_0], this.list_0[num]);
				if (num2 < 0)
				{
					this.Swap(int_0, num);
					this.SiftUp(num);
				}
			}
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x000EFB10 File Offset: 0x000EDD10
		private void method_11(int int_0)
		{
			int num = int_0 * 2 + 1;
			int num2 = int_0 * 2 + 2;
			if (num < this.list_0.Count)
			{
				T t = this.list_0[num];
				if (num2 >= this.list_0.Count)
				{
					int num3 = this.icomparer_0.Compare(this.list_0[int_0], t);
					if (num3 > 0)
					{
						this.Swap(int_0, num);
					}
				}
				else
				{
					T y = this.list_0[num2];
					int num4 = this.icomparer_0.Compare(this.list_0[int_0], t);
					int num5 = this.icomparer_0.Compare(this.list_0[int_0], y);
					if (num4 > 0 || num5 > 0)
					{
						int num6 = this.icomparer_0.Compare(t, y);
						if (num6 > 0)
						{
							this.Swap(int_0, num2);
							this.SiftDown(num2);
						}
						else
						{
							this.Swap(int_0, num);
							this.SiftDown(num);
						}
					}
				}
			}
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x000EFC18 File Offset: 0x000EDE18
		private void method_12(int int_0)
		{
			this.method_9(int_0);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x000EFC2C File Offset: 0x000EDE2C
		internal void method_13(T gparam_0)
		{
			this.list_0.Add(gparam_0);
			this.SiftUp(this.list_0.Count - 1);
		}

		// Token: 0x04001874 RID: 6260
		private readonly List<T> list_0;

		// Token: 0x04001875 RID: 6261
		private readonly IComparer<T> icomparer_0;
	}
}
