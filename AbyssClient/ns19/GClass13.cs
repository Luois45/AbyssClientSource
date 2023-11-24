using System;
using System.Runtime.InteropServices;
using ns226;

namespace ns19
{
	// Token: 0x02000010 RID: 16
	public class GClass13
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00004D04 File Offset: 0x00002F04
		void method_0()
		{
			this.method_10();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004D18 File Offset: 0x00002F18
		private void method_1(IntPtr intptr_1, IntPtr intptr_2, int int_0, float float_0)
		{
			this.method_9(intptr_1, intptr_2, int_0, float_0);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004D34 File Offset: 0x00002F34
		private void method_2(IntPtr intptr_1)
		{
			this.method_8(intptr_1);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004D48 File Offset: 0x00002F48
		private void method_3(IntPtr intptr_1)
		{
			this.gdelegate2_0();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004D60 File Offset: 0x00002F60
		private void method_4(IntPtr intptr_1, IntPtr intptr_2, int int_0, float float_0)
		{
			this.method_1(intptr_1, intptr_2, int_0, float_0);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004D7C File Offset: 0x00002F7C
		public GClass13(GClass13.GDelegate0 gdelegate0_1, GClass13.GDelegate1 gdelegate1_1, GClass13.GDelegate2 gdelegate2_1)
		{
			if (gdelegate0_1 == null || gdelegate1_1 == null || gdelegate2_1 == null)
			{
				throw new ArgumentNullException();
			}
			this.gdelegate0_0 = gdelegate0_1;
			this.gdelegate1_0 = gdelegate1_1;
			this.gdelegate2_0 = gdelegate2_1;
			this.class1_0 = new GClass13.Class1
			{
				gdelegate3_0 = new GClass13.GDelegate3(this.method_4),
				gdelegate4_0 = new GClass13.GDelegate4(this.method_7),
				gdelegate5_0 = new GClass13.GDelegate5(this.method_6)
			};
			this.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GClass13.Class1)));
			Marshal.StructureToPtr<GClass13.Class1>(this.class1_0, this.intptr_0, false);
			this.gchandle_0 = GCHandle.Alloc(this.intptr_0, GCHandleType.Pinned);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004E40 File Offset: 0x00003040
		private void method_5(IntPtr intptr_1)
		{
			this.method_3(intptr_1);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004E54 File Offset: 0x00003054
		private void method_6(IntPtr intptr_1)
		{
			this.method_5(intptr_1);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004E68 File Offset: 0x00003068
		private void method_7(IntPtr intptr_1)
		{
			this.method_2(intptr_1);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004E7C File Offset: 0x0000307C
		private void method_8(IntPtr intptr_1)
		{
			this.gdelegate1_0();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004E94 File Offset: 0x00003094
		private void method_9(IntPtr intptr_1, IntPtr intptr_2, int int_0, float float_0)
		{
			this.gdelegate0_0(GClass78.smethod_0(intptr_2), int_0, float_0);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004EB8 File Offset: 0x000030B8
		public static IntPtr smethod_0(GClass13 gclass13_0)
		{
			return gclass13_0.gchandle_0.AddrOfPinnedObject();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004ED4 File Offset: 0x000030D4
		protected virtual void Finalize()
		{
			this.method_0();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004EE8 File Offset: 0x000030E8
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

		// Token: 0x04000060 RID: 96
		private readonly GClass13.Class1 class1_0;

		// Token: 0x04000061 RID: 97
		private readonly IntPtr intptr_0;

		// Token: 0x04000062 RID: 98
		private GCHandle gchandle_0;

		// Token: 0x04000063 RID: 99
		private readonly GClass13.GDelegate0 gdelegate0_0;

		// Token: 0x04000064 RID: 100
		private readonly GClass13.GDelegate1 gdelegate1_0;

		// Token: 0x04000065 RID: 101
		private readonly GClass13.GDelegate2 gdelegate2_0;

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000EF RID: 239
		public delegate void GDelegate0(string string_0, int int_0, float float_0);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000F3 RID: 243
		public delegate void GDelegate1();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000F9 RID: 249
		public delegate void GDelegate2();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000FB RID: 251
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate3(IntPtr intptr_0, IntPtr intptr_1, int int_0, float float_0);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000101 RID: 257
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate4(IntPtr intptr_0);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000105 RID: 261
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void GDelegate5(IntPtr intptr_0);

		// Token: 0x02000017 RID: 23
		[StructLayout(LayoutKind.Sequential)]
		private class Class1
		{
			// Token: 0x04000066 RID: 102
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass13.GDelegate3 gdelegate3_0;

			// Token: 0x04000067 RID: 103
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass13.GDelegate4 gdelegate4_0;

			// Token: 0x04000068 RID: 104
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass13.GDelegate5 gdelegate5_0;
		}
	}
}
