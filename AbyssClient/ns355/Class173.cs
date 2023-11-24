using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using ns121;
using ns185;

namespace ns355
{
	// Token: 0x020002BC RID: 700
	internal class Class173
	{
		// Token: 0x0600203F RID: 8255 RVA: 0x000A53F0 File Offset: 0x000A35F0
		[CompilerGenerated]
		private void method_0()
		{
			this.method_8();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000A5404 File Offset: 0x000A3604
		internal void method_1(int int_0)
		{
			this.method_6(int_0);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000A5418 File Offset: 0x000A3618
		void method_2()
		{
			try
			{
				this.method_3();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000A5448 File Offset: 0x000A3648
		internal void method_3()
		{
			this.method_11();
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000A545C File Offset: 0x000A365C
		internal void method_4()
		{
			for (;;)
			{
				try
				{
					if (this.tcpListener_0 == null)
					{
						break;
					}
					TcpClient parameter = this.tcpListener_0.AcceptTcpClient();
					Thread thread = new Thread(new ParameterizedThreadStart(Class173.smethod_1));
					thread.Start(parameter);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000A54B8 File Offset: 0x000A36B8
		internal void method_5()
		{
			this.method_9();
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000A54CC File Offset: 0x000A36CC
		protected virtual void Finalize()
		{
			this.method_7();
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000A54E0 File Offset: 0x000A36E0
		internal void method_6(int int_0)
		{
			this.method_14(int_0);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000A54F4 File Offset: 0x000A36F4
		void method_7()
		{
			this.method_2();
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000A5508 File Offset: 0x000A3708
		internal Class173(int int_0)
		{
			this.method_1(int_0);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000A552C File Offset: 0x000A372C
		private void method_8()
		{
			this.method_10();
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000A5558 File Offset: 0x000A3758
		internal void method_9()
		{
			this.method_4();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000A556C File Offset: 0x000A376C
		private void method_10()
		{
			this.method_5();
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000A5580 File Offset: 0x000A3780
		private static void smethod_0(object object_0)
		{
			Class173.smethod_2(object_0);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000A5594 File Offset: 0x000A3794
		internal void method_11()
		{
			this.method_13();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000A55A8 File Offset: 0x000A37A8
		internal bool method_12()
		{
			return this.bool_0;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000A55BC File Offset: 0x000A37BC
		internal void method_13()
		{
			foreach (Thread thread in Class173.list_0)
			{
				thread.Abort();
			}
			Class173.list_0.Clear();
			if (this.tcpListener_0 != null)
			{
				this.tcpListener_0.Stop();
				this.tcpListener_0 = null;
				GClass70.smethod_38("Server Is Down!", GClass70.Enum1.const_0);
			}
			this.bool_0 = false;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000A5648 File Offset: 0x000A3848
		private static void smethod_1(object object_0)
		{
			Class173.smethod_0(object_0);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000A565C File Offset: 0x000A385C
		private static void smethod_2(object object_0)
		{
			try
			{
				new Class48((TcpClient)object_0);
			}
			catch (Exception ex)
			{
				GClass70.smethod_38(string.Concat(new string[]
				{
					"[",
					"Error",
					"]",
					" ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000A56C8 File Offset: 0x000A38C8
		internal void method_14(int int_0)
		{
			if (this.method_12())
			{
				this.method_3();
			}
			try
			{
				this.tcpListener_0 = new TcpListener(IPAddress.Any, int_0);
				this.tcpListener_0.Start();
				this.bool_0 = true;
				GClass70.smethod_38(string.Concat(new string[]
				{
					"Server",
					" ",
					"Is",
					" ",
					"Up",
					"! ",
					"Port",
					" ",
					"Is",
					" ",
					int_0.ToString()
				}), GClass70.Enum1.const_0);
				Thread thread = new Thread(new ThreadStart(this.method_0));
				thread.Start();
				Class173.list_0.Add(thread);
			}
			catch (Exception ex)
			{
				try
				{
					if (this.tcpListener_0 != null)
					{
						this.tcpListener_0.Stop();
					}
				}
				catch
				{
				}
				this.tcpListener_0 = null;
				GClass70.smethod_36(ex.Message, GClass70.Enum1.const_0);
			}
		}

		// Token: 0x04001299 RID: 4761
		private TcpListener tcpListener_0;

		// Token: 0x0400129A RID: 4762
		private bool bool_0 = false;

		// Token: 0x0400129B RID: 4763
		private static List<Thread> list_0 = new List<Thread>();
	}
}
