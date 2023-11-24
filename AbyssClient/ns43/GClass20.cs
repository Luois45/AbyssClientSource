using System;
using System.Runtime.InteropServices;
using ns229;

namespace ns43
{
	// Token: 0x0200002F RID: 47
	public class GClass20
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00006784 File Offset: 0x00004984
		protected virtual void Finalize()
		{
			this.method_4();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00006798 File Offset: 0x00004998
		public GClass20(GClass20.GDelegate6 gdelegate6_1, GClass20.GDelegate7 gdelegate7_1)
		{
			if (gdelegate6_1 == null || gdelegate7_1 == null)
			{
				throw new ArgumentNullException();
			}
			this.gdelegate6_0 = gdelegate6_1;
			this.gdelegate7_0 = gdelegate7_1;
			this.class2_0 = new GClass20.Class2
			{
				delegate1_0 = new GClass20.Delegate1(this.method_0),
				delegate2_0 = new GClass20.Delegate2(this.method_5)
			};
			this.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GClass20.Class2)));
			Marshal.StructureToPtr<GClass20.Class2>(this.class2_0, this.intptr_0, false);
			this.gchandle_0 = GCHandle.Alloc(this.intptr_0, GCHandleType.Pinned);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00006840 File Offset: 0x00004A40
		private void method_0(IntPtr intptr_1, GClass81 gclass81_0)
		{
			this.method_3(intptr_1, gclass81_0);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006858 File Offset: 0x00004A58
		private void method_1(IntPtr intptr_1)
		{
			this.gdelegate7_0();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006870 File Offset: 0x00004A70
		public static IntPtr smethod_0(GClass20 gclass20_0)
		{
			return gclass20_0.gchandle_0.AddrOfPinnedObject();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000688C File Offset: 0x00004A8C
		private void method_2(IntPtr intptr_1)
		{
			this.method_1(intptr_1);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000068A0 File Offset: 0x00004AA0
		private void method_3(IntPtr intptr_1, GClass81 gclass81_0)
		{
			this.method_6(intptr_1, gclass81_0);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000068B8 File Offset: 0x00004AB8
		void method_4()
		{
			this.method_7();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000068CC File Offset: 0x00004ACC
		private void method_5(IntPtr intptr_1)
		{
			this.method_2(intptr_1);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000068E0 File Offset: 0x00004AE0
		private void method_6(IntPtr intptr_1, GClass81 gclass81_0)
		{
			this.gdelegate6_0(gclass81_0);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000068FC File Offset: 0x00004AFC
		void method_7()
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

		// Token: 0x040000B9 RID: 185
		private readonly GClass20.Class2 class2_0;

		// Token: 0x040000BA RID: 186
		private readonly IntPtr intptr_0;

		// Token: 0x040000BB RID: 187
		private GCHandle gchandle_0;

		// Token: 0x040000BC RID: 188
		private readonly GClass20.GDelegate6 gdelegate6_0;

		// Token: 0x040000BD RID: 189
		private readonly GClass20.GDelegate7 gdelegate7_0;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001D6 RID: 470
		public delegate void GDelegate6(GClass81 gclass81_0);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001DA RID: 474
		public delegate void GDelegate7();

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001DE RID: 478
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void Delegate1(IntPtr intptr_0, GClass81 gclass81_0);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001E1 RID: 481
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void Delegate2(IntPtr intptr_0);

		// Token: 0x02000034 RID: 52
		[StructLayout(LayoutKind.Sequential)]
		private class Class2
		{
			// Token: 0x040000BE RID: 190
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass20.Delegate1 delegate1_0;

			// Token: 0x040000BF RID: 191
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass20.Delegate2 delegate2_0;
		}
	}
}
