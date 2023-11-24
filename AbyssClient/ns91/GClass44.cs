using System;
using System.Runtime.InteropServices;
using ns226;

namespace ns91
{
	// Token: 0x0200006E RID: 110
	public class GClass44
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		public static IntPtr smethod_0(GClass44 gclass44_0)
		{
			return gclass44_0.gchandle_0.AddrOfPinnedObject();
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		private void method_0(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			this.method_8(intptr_1, intptr_2, intptr_3);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		private void method_1(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			this.gdelegate11_0(GClass78.smethod_0(intptr_2), GClass78.smethod_0(intptr_3));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000EC14 File Offset: 0x0000CE14
		private void method_2(IntPtr intptr_1)
		{
			this.method_9(intptr_1);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000EC28 File Offset: 0x0000CE28
		private void method_3(IntPtr intptr_1)
		{
			this.gdelegate12_0();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000EC40 File Offset: 0x0000CE40
		private void method_4(IntPtr intptr_1)
		{
			this.gdelegate13_0();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000EC58 File Offset: 0x0000CE58
		void method_5()
		{
			this.method_10();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public GClass44(GClass44.GDelegate11 gdelegate11_1, GClass44.GDelegate12 gdelegate12_1, GClass44.GDelegate13 gdelegate13_1)
		{
			if (gdelegate11_1 == null || gdelegate12_1 == null || gdelegate13_1 == null)
			{
				throw new ArgumentNullException();
			}
			this.gdelegate11_0 = gdelegate11_1;
			this.gdelegate12_0 = gdelegate12_1;
			this.gdelegate13_0 = gdelegate13_1;
			this.class14_0 = new GClass44.Class14
			{
				gdelegate14_0 = new GClass44.GDelegate14(this.method_0),
				gdelegate15_0 = new GClass44.GDelegate15(this.method_6),
				gdelegate16_0 = new GClass44.GDelegate16(this.method_2)
			};
			this.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GClass44.Class14)));
			Marshal.StructureToPtr<GClass44.Class14>(this.class14_0, this.intptr_0, false);
			this.gchandle_0 = GCHandle.Alloc(this.intptr_0, GCHandleType.Pinned);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000ED30 File Offset: 0x0000CF30
		private void method_6(IntPtr intptr_1)
		{
			this.method_7(intptr_1);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000ED44 File Offset: 0x0000CF44
		protected virtual void Finalize()
		{
			this.method_5();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000ED58 File Offset: 0x0000CF58
		private void method_7(IntPtr intptr_1)
		{
			this.method_3(intptr_1);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		private void method_8(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			this.method_1(intptr_1, intptr_2, intptr_3);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000ED84 File Offset: 0x0000CF84
		private void method_9(IntPtr intptr_1)
		{
			this.method_4(intptr_1);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000ED98 File Offset: 0x0000CF98
		void method_10()
		{
			try
			{
				if (this.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_0);
				}
				if (this.gchandle_0.IsAllocated)
				{
					this.gchandle_0.Free();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x04000284 RID: 644
		private readonly GClass44.Class14 class14_0;

		// Token: 0x04000285 RID: 645
		private readonly IntPtr intptr_0;

		// Token: 0x04000286 RID: 646
		private GCHandle gchandle_0;

		// Token: 0x04000287 RID: 647
		private readonly GClass44.GDelegate11 gdelegate11_0;

		// Token: 0x04000288 RID: 648
		private readonly GClass44.GDelegate12 gdelegate12_0;

		// Token: 0x04000289 RID: 649
		private readonly GClass44.GDelegate13 gdelegate13_0;

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000421 RID: 1057
		public delegate void GDelegate11(string string_0, string string_1);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000424 RID: 1060
		public delegate void GDelegate12();

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000429 RID: 1065
		public delegate void GDelegate13();

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600042D RID: 1069
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate14(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000431 RID: 1073
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate15(IntPtr intptr_0);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000433 RID: 1075
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate16(IntPtr intptr_0);

		// Token: 0x02000075 RID: 117
		[StructLayout(LayoutKind.Sequential)]
		private class Class14
		{
			// Token: 0x0400028A RID: 650
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass44.GDelegate14 gdelegate14_0;

			// Token: 0x0400028B RID: 651
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass44.GDelegate15 gdelegate15_0;

			// Token: 0x0400028C RID: 652
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass44.GDelegate16 gdelegate16_0;
		}
	}
}
