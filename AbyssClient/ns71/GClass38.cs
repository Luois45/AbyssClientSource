using System;
using System.Runtime.InteropServices;
using ns119;

namespace ns71
{
	// Token: 0x0200004E RID: 78
	public class GClass38
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x000082A4 File Offset: 0x000064A4
		public GClass38(GStruct44[] gstruct44_0)
		{
			if (gstruct44_0 != null)
			{
				int num = Marshal.SizeOf(typeof(GStruct44));
				this.intptr_0 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * gstruct44_0.Length);
				this.intptr_1 = Marshal.AllocHGlobal(num * gstruct44_0.Length);
				for (int i = 0; i < gstruct44_0.Length; i++)
				{
					Marshal.StructureToPtr<GStruct44>(gstruct44_0[i], new IntPtr(this.intptr_1.ToInt64() + (long)(i * num)), false);
				}
				Marshal.WriteIntPtr(this.intptr_0, this.intptr_1);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00008344 File Offset: 0x00006544
		protected virtual void Finalize()
		{
			this.method_0();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00008358 File Offset: 0x00006558
		public static IntPtr smethod_0(GClass38 gclass38_0)
		{
			return gclass38_0.intptr_0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00008370 File Offset: 0x00006570
		void method_0()
		{
			this.method_1();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00008384 File Offset: 0x00006584
		void method_1()
		{
			try
			{
				if (this.intptr_1 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_1);
				}
				if (this.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_0);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0400012E RID: 302
		private IntPtr intptr_0;

		// Token: 0x0400012F RID: 303
		private readonly IntPtr intptr_1;
	}
}
