using System;
using System.Runtime.InteropServices;
using ns386;
using ns88;

namespace ns46
{
	// Token: 0x02000037 RID: 55
	public class GClass22
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00006AAC File Offset: 0x00004CAC
		private void method_0(IntPtr intptr_1, GStruct240 gstruct240_0, GEnum9 genum9_0)
		{
			this.gdelegate10_0(gstruct240_0, genum9_0);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private void method_1(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.method_6(intptr_1, gstruct240_0, int_0);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00006AE0 File Offset: 0x00004CE0
		private void method_2(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.method_3(intptr_1, gstruct240_0, int_0);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006AF8 File Offset: 0x00004CF8
		private void method_3(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.gdelegate9_0(gstruct240_0, int_0);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00006B14 File Offset: 0x00004D14
		private void method_4(IntPtr intptr_1, GStruct240 gstruct240_0, GEnum9 genum9_0)
		{
			this.method_9(intptr_1, gstruct240_0, genum9_0);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00006B2C File Offset: 0x00004D2C
		public static IntPtr smethod_0(GClass22 gclass22_0)
		{
			return gclass22_0.gchandle_0.AddrOfPinnedObject();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00006B48 File Offset: 0x00004D48
		private void method_5(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.method_1(intptr_1, gstruct240_0, int_0);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00006B60 File Offset: 0x00004D60
		protected virtual void Finalize()
		{
			this.method_7();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00006B74 File Offset: 0x00004D74
		private void method_6(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.gdelegate8_0(gstruct240_0, int_0);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00006B90 File Offset: 0x00004D90
		public GClass22(GClass22.GDelegate8 gdelegate8_1, GClass22.GDelegate9 gdelegate9_1, GClass22.GDelegate10 gdelegate10_1)
		{
			if (gdelegate8_1 == null || gdelegate9_1 == null || gdelegate10_1 == null)
			{
				throw new ArgumentNullException();
			}
			this.gdelegate8_0 = gdelegate8_1;
			this.gdelegate9_0 = gdelegate9_1;
			this.gdelegate10_0 = gdelegate10_1;
			this.class3_0 = new GClass22.Class3
			{
				delegate3_0 = new GClass22.Delegate3(this.method_5),
				delegate4_0 = new GClass22.Delegate4(this.method_8),
				delegate5_0 = new GClass22.Delegate5(this.method_4)
			};
			this.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GClass22.Class3)));
			Marshal.StructureToPtr<GClass22.Class3>(this.class3_0, this.intptr_0, false);
			this.gchandle_0 = GCHandle.Alloc(this.intptr_0, GCHandleType.Pinned);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00006C54 File Offset: 0x00004E54
		void method_7()
		{
			this.method_10();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00006C68 File Offset: 0x00004E68
		private void method_8(IntPtr intptr_1, GStruct240 gstruct240_0, int int_0)
		{
			this.method_2(intptr_1, gstruct240_0, int_0);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00006C80 File Offset: 0x00004E80
		private void method_9(IntPtr intptr_1, GStruct240 gstruct240_0, GEnum9 genum9_0)
		{
			this.method_0(intptr_1, gstruct240_0, genum9_0);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00006C98 File Offset: 0x00004E98
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

		// Token: 0x040000D3 RID: 211
		private readonly GClass22.Class3 class3_0;

		// Token: 0x040000D4 RID: 212
		private readonly IntPtr intptr_0;

		// Token: 0x040000D5 RID: 213
		private GCHandle gchandle_0;

		// Token: 0x040000D6 RID: 214
		private readonly GClass22.GDelegate8 gdelegate8_0;

		// Token: 0x040000D7 RID: 215
		private readonly GClass22.GDelegate9 gdelegate9_0;

		// Token: 0x040000D8 RID: 216
		private readonly GClass22.GDelegate10 gdelegate10_0;

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001FD RID: 509
		public delegate void GDelegate8(GStruct240 gstruct240_0, int int_0);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000201 RID: 513
		public delegate void GDelegate9(GStruct240 gstruct240_0, int int_0);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000203 RID: 515
		public delegate void GDelegate10(GStruct240 gstruct240_0, GEnum9 genum9_0);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000208 RID: 520
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void Delegate3(IntPtr intptr_0, GStruct240 gstruct240_0, int int_0);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600020D RID: 525
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void Delegate4(IntPtr intptr_0, GStruct240 gstruct240_0, int int_0);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000210 RID: 528
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void Delegate5(IntPtr intptr_0, GStruct240 gstruct240_0, GEnum9 genum9_0);

		// Token: 0x0200003E RID: 62
		[StructLayout(LayoutKind.Sequential)]
		private class Class3
		{
			// Token: 0x040000D9 RID: 217
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass22.Delegate3 delegate3_0;

			// Token: 0x040000DA RID: 218
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass22.Delegate4 delegate4_0;

			// Token: 0x040000DB RID: 219
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public GClass22.Delegate5 delegate5_0;
		}
	}
}
