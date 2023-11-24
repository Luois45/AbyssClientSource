using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns185;

namespace ns339
{
	// Token: 0x020002A7 RID: 679
	public class GClass106
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x000A2C5C File Offset: 0x000A0E5C
		internal GClass106.GStruct223 method_0()
		{
			return new GClass106.GStruct223(this.queue_0);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000A2C78 File Offset: 0x000A0E78
		internal void method_1()
		{
			this.method_3();
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000A2C8C File Offset: 0x000A0E8C
		internal void method_2()
		{
			this.method_1();
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000A2CC0 File Offset: 0x000A0EC0
		internal void method_3()
		{
			if (this.queue_0.Count != 0)
			{
				Queue<Action> obj = this.queue_0;
				List<Action> list;
				lock (obj)
				{
					list = this.queue_0.ToList<Action>();
					this.queue_0.Clear();
				}
				foreach (Action action in list)
				{
					try
					{
						action();
					}
					catch (Exception ex)
					{
						string[] array = new string[7];
						array[0] = "Exception";
						array[1] = " ";
						array[2] = "in";
						array[3] = " ";
						array[4] = "task";
						array[5] = ": ";
						int num = 6;
						Exception ex2 = ex;
						array[num] = ((ex2 != null) ? ex2.ToString() : null);
						GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
					}
				}
			}
		}

		// Token: 0x0400124E RID: 4686
		private readonly Queue<Action> queue_0 = new Queue<Action>();

		// Token: 0x020002A8 RID: 680
		public readonly struct GStruct223 : INotifyCompletion
		{
			// Token: 0x06001F79 RID: 8057 RVA: 0x000A2DC8 File Offset: 0x000A0FC8
			public GClass106.GStruct223 method_0()
			{
				return this;
			}

			// Token: 0x06001F7A RID: 8058 RVA: 0x000A2DE0 File Offset: 0x000A0FE0
			public GStruct223(Queue<Action> queue_1)
			{
				this.queue_0 = queue_1;
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
			public bool Boolean_0
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x000A2DF4 File Offset: 0x000A0FF4
			public void OnCompleted(Action action_0)
			{
				Queue<Action> obj = this.queue_0;
				lock (obj)
				{
					this.queue_0.Enqueue(action_0);
				}
			}

			// Token: 0x0400124F RID: 4687
			private readonly Queue<Action> queue_0;
		}
	}
}
