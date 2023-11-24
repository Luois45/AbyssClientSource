using System;
using System.Runtime.InteropServices;
using ns215;

namespace ns299
{
	// Token: 0x02000267 RID: 615
	public sealed class GClass98 : IDisposable
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x0008FD8C File Offset: 0x0008DF8C
		private void method_0()
		{
			this.method_6();
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0008FDA0 File Offset: 0x0008DFA0
		internal void method_1()
		{
			this.method_2();
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0008FDB4 File Offset: 0x0008DFB4
		internal void method_2()
		{
			this.method_5();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
		void method_3()
		{
			this.method_8();
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0008FDE4 File Offset: 0x0008DFE4
		public void method_4(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			this.method_7(nullable_0, nullable_1, bool_0, bool_1, bool_2);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0008FE04 File Offset: 0x0008E004
		private void method_5()
		{
			this.method_0();
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0008FE18 File Offset: 0x0008E018
		public void Dispose()
		{
			this.method_1();
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0008FE2C File Offset: 0x0008E02C
		private void method_6()
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				GClass74.CloseHandle(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0008FE64 File Offset: 0x0008E064
		public GClass98()
		{
			GClass74.GStruct110 gstruct = default(GClass74.GStruct110);
			this.intptr_0 = GClass74.CreateJobObject(ref gstruct, null);
			if (this.intptr_0 == IntPtr.Zero)
			{
				throw new ApplicationException("Unable to create job object");
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0008FEAC File Offset: 0x0008E0AC
		internal void method_7(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			this.method_9(nullable_0, nullable_1, bool_0, bool_1, bool_2);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0008FECC File Offset: 0x0008E0CC
		void method_8()
		{
			try
			{
				this.method_5();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x0008FEFC File Offset: 0x0008E0FC
		internal IntPtr IntPtr_0
		{
			get
			{
				return this.intptr_0;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0008FF10 File Offset: 0x0008E110
		protected void Finalize()
		{
			this.method_3();
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0008FF24 File Offset: 0x0008E124
		internal unsafe void method_9(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			GClass74.GStruct115 gstruct = default(GClass74.GStruct115);
			if (nullable_0 != null)
			{
				gstruct.gstruct114_0.genum42_0 = (gstruct.gstruct114_0.genum42_0 | GClass74.GEnum42.flag_1);
				gstruct.gstruct114_0.long_0 = nullable_0.Value.Ticks;
			}
			if (nullable_1 != null)
			{
				gstruct.gstruct114_0.genum42_0 = (gstruct.gstruct114_0.genum42_0 | GClass74.GEnum42.flag_8);
				gstruct.intptr_0 = (IntPtr)((long)nullable_1.Value);
			}
			if (!bool_2)
			{
				gstruct.gstruct114_0.int_0 = 1;
				gstruct.gstruct114_0.genum42_0 = (gstruct.gstruct114_0.genum42_0 | GClass74.GEnum42.flag_3);
			}
			gstruct.gstruct114_0.genum42_0 = (gstruct.gstruct114_0.genum42_0 | GClass74.GEnum42.flag_13);
			GClass74.SetInformationJobObject(this.intptr_0, GClass74.GEnum40.const_8, (IntPtr)((void*)(&gstruct)), Marshal.SizeOf<GClass74.GStruct115>());
			if (!bool_1)
			{
				GClass74.GStruct113 gstruct2 = new GClass74.GStruct113
				{
					genum41_0 = GClass74.GEnum41.flag_8
				};
				GClass74.SetInformationJobObject(this.intptr_0, GClass74.GEnum40.const_3, (IntPtr)((void*)(&gstruct2)), Marshal.SizeOf<GClass74.GStruct113>());
			}
			if (!bool_0)
			{
				GClass74.GStruct117 gstruct3 = new GClass74.GStruct117
				{
					genum43_0 = (GClass74.GEnum43.flag_0 | GClass74.GEnum43.flag_1),
					long_0 = 0L
				};
				GClass74.SetInformationJobObject(this.intptr_0, GClass74.GEnum40.const_14, (IntPtr)((void*)(&gstruct3)), Marshal.SizeOf<GClass74.GStruct117>());
			}
		}

		// Token: 0x040010C1 RID: 4289
		private IntPtr intptr_0;
	}
}
