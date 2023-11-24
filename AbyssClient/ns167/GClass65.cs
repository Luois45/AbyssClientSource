using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using ns215;
using ns299;
using ns38;

namespace ns167
{
	// Token: 0x02000111 RID: 273
	public sealed class GClass65 : IDisposable
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x000228B4 File Offset: 0x00020AB4
		private void method_0(bool bool_0)
		{
			this.method_9();
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000228C8 File Offset: 0x00020AC8
		internal void method_1()
		{
			this.method_2(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000228E4 File Offset: 0x00020AE4
		private void method_2(bool bool_0)
		{
			this.method_13(bool_0);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000228F8 File Offset: 0x00020AF8
		[Attribute0(1)]
		public GClass65(string string_0, GClass98 gclass98_0) : this(string_0)
		{
			GClass74.AssignProcessToJobObject(gclass98_0.IntPtr_0, this.intptr_0);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00022920 File Offset: 0x00020B20
		public int? method_3(TimeSpan timeSpan_0)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			int num;
			for (;;)
			{
				GClass74.GetExitCodeProcess(this.intptr_0, out num);
				if (num != 259)
				{
					break;
				}
				Thread.Sleep(33);
				if (!(stopwatch.Elapsed < timeSpan_0))
				{
					goto IL_41;
				}
			}
			return new int?(num);
			IL_41:
			return null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0002297C File Offset: 0x00020B7C
		[Attribute0(1)]
		public GClass65(string string_0)
		{
			GClass74.GStruct110 gstruct = default(GClass74.GStruct110);
			GClass74.GStruct112 gstruct2 = default(GClass74.GStruct112);
			GClass74.GStruct111 gstruct3 = new GClass74.GStruct111
			{
				int_0 = Marshal.SizeOf<GClass74.GStruct111>()
			};
			if (!GClass74.CreateProcess(null, string_0, ref gstruct, ref gstruct, false, GClass74.GEnum39.flag_2 | GClass74.GEnum39.flag_16, IntPtr.Zero, null, ref gstruct3, out gstruct2))
			{
				throw new ArgumentException("Can't create process");
			}
			this.intptr_0 = gstruct2.intptr_0;
			this.intptr_1 = gstruct2.intptr_1;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000229FC File Offset: 0x00020BFC
		void method_4()
		{
			this.method_5();
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00022A10 File Offset: 0x00020C10
		void method_5()
		{
			try
			{
				this.method_2(false);
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00022A40 File Offset: 0x00020C40
		protected void Finalize()
		{
			this.method_4();
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00022A54 File Offset: 0x00020C54
		public int? method_6()
		{
			int num;
			GClass74.GetExitCodeProcess(this.intptr_0, out num);
			int? result;
			if (num != 259)
			{
				result = new int?(num);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00022A90 File Offset: 0x00020C90
		internal void method_7()
		{
			this.method_14();
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00022AA4 File Offset: 0x00020CA4
		public void Dispose()
		{
			this.method_12();
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00022AB8 File Offset: 0x00020CB8
		private void method_8()
		{
			this.method_11();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00022ACC File Offset: 0x00020CCC
		private void method_9()
		{
			this.method_8();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00022AE0 File Offset: 0x00020CE0
		public void method_10()
		{
			this.method_7();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00022AF4 File Offset: 0x00020CF4
		private void method_11()
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				GClass74.CloseHandle(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
			if (this.intptr_1 != IntPtr.Zero)
			{
				GClass74.CloseHandle(this.intptr_1);
			}
			this.intptr_1 = IntPtr.Zero;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00022B54 File Offset: 0x00020D54
		internal void method_12()
		{
			this.method_1();
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00022B68 File Offset: 0x00020D68
		private void method_13(bool bool_0)
		{
			this.method_0(bool_0);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00022B7C File Offset: 0x00020D7C
		internal void method_14()
		{
			if (Interlocked.CompareExchange(ref this.int_0, 1, 0) != 0)
			{
				throw new ApplicationException("Already started");
			}
			GClass74.ResumeThread(this.intptr_1);
		}

		// Token: 0x0400069F RID: 1695
		private IntPtr intptr_0;

		// Token: 0x040006A0 RID: 1696
		private IntPtr intptr_1;

		// Token: 0x040006A1 RID: 1697
		private int int_0;
	}
}
