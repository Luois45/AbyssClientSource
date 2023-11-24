using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ns220;
using ns285;
using ns352;
using ns370;
using ns373;

namespace ns363
{
	// Token: 0x020002C6 RID: 710
	public sealed class GClass114<T> : IDisposable
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x000A5F38 File Offset: 0x000A4138
		internal void method_0()
		{
			Class177.SteamAPI_UnregisterCallback(this.m_pCCallbackBase.AddrOfPinnedObject());
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000A5F58 File Offset: 0x000A4158
		internal void method_1(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			if (gdelegate18_1 == null)
			{
				throw new Exception("Callback function must not be null.");
			}
			if ((this.m_CCallbackBase.byte_2 & 1) == 1)
			{
				this.Unregister();
			}
			if (this.m_bGameServer)
			{
				this.SetGameserverFlag();
			}
			this.m_Func = gdelegate18_1;
			Class177.SteamAPI_RegisterCallback(this.m_pCCallbackBase.AddrOfPinnedObject(), Class178.smethod_0(typeof(T)));
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000A5FC4 File Offset: 0x000A41C4
		void method_2()
		{
			this.method_18();
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000A5FD8 File Offset: 0x000A41D8
		private void method_3(IntPtr intptr_1, IntPtr intptr_2)
		{
			this.method_24(intptr_1, intptr_2);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000A5FF0 File Offset: 0x000A41F0
		protected void Finalize()
		{
			this.method_2();
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000A6004 File Offset: 0x000A4204
		private void method_4()
		{
			this.method_6();
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000A6018 File Offset: 0x000A4218
		internal void method_5()
		{
			Class91 ccallbackBase = this.m_CCallbackBase;
			Class91 @class = ccallbackBase;
			@class.byte_2 |= 2;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000A603C File Offset: 0x000A423C
		private void method_6()
		{
			this.m_CallbackBaseVTable = new Class151
			{
				delegate34_0 = new Class151.Delegate34(this.OnRunCallResult),
				delegate33_0 = new Class151.Delegate33(this.OnRunCallback),
				delegate35_0 = new Class151.Delegate35(this.OnGetCallbackSizeBytes)
			};
			this.m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Class151)));
			Marshal.StructureToPtr<Class151>(this.m_CallbackBaseVTable, this.m_pVTable, false);
			this.m_CCallbackBase = new Class91
			{
				intptr_0 = this.m_pVTable,
				byte_2 = 0,
				int_0 = Class178.smethod_0(typeof(T))
			};
			this.m_pCCallbackBase = GCHandle.Alloc(this.m_CCallbackBase, GCHandleType.Pinned);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000A6100 File Offset: 0x000A4300
		internal void method_7()
		{
			this.method_22();
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000A6114 File Offset: 0x000A4314
		internal void method_8()
		{
			this.method_5();
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000A6128 File Offset: 0x000A4328
		private void method_9(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			this.method_13(gdelegate18_1);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000A613C File Offset: 0x000A433C
		internal void method_10(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			this.method_1(gdelegate18_1);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000A6150 File Offset: 0x000A4350
		public void method_11(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			this.method_10(gdelegate18_1);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000A6164 File Offset: 0x000A4364
		private void method_12(IntPtr intptr_1, IntPtr intptr_2, bool bool_2, ulong ulong_0)
		{
			this.method_14(intptr_1, intptr_2, bool_2, ulong_0);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000A6180 File Offset: 0x000A4380
		private void method_13(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			GClass114<T>.GDelegate18 gdelegate = this.m_Func;
			GClass114<T>.GDelegate18 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass114<T>.GDelegate18 value = (GClass114<T>.GDelegate18)Delegate.Remove(gdelegate2, gdelegate18_1);
				gdelegate = Interlocked.CompareExchange<GClass114<T>.GDelegate18>(ref this.m_Func, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000A61B8 File Offset: 0x000A43B8
		public static GClass114<T> smethod_0(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			return new GClass114<T>(gdelegate18_1, false);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06002098 RID: 8344 RVA: 0x000A6230 File Offset: 0x000A4430
		// (remove) Token: 0x06002096 RID: 8342 RVA: 0x000A61D0 File Offset: 0x000A43D0
		private event GClass114<T>.GDelegate18 Event_0
		{
			[CompilerGenerated]
			add
			{
				this.method_17(value);
			}
			[CompilerGenerated]
			remove
			{
				this.method_9(value);
			}
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000A61E4 File Offset: 0x000A43E4
		private void method_14(IntPtr intptr_1, IntPtr intptr_2, bool bool_2, ulong ulong_0)
		{
			try
			{
				this.m_Func((T)((object)Marshal.PtrToStructure(intptr_2, typeof(T))));
			}
			catch (Exception exception_)
			{
				GClass111.smethod_1(exception_);
			}
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000A6244 File Offset: 0x000A4444
		public static GClass114<T> smethod_1(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			return new GClass114<T>(gdelegate18_1, true);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000A625C File Offset: 0x000A445C
		private int method_15(IntPtr intptr_1)
		{
			return this.m_size;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000A6274 File Offset: 0x000A4474
		public void method_16()
		{
			this.method_8();
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000A6288 File Offset: 0x000A4488
		public GClass114(GClass114<T>.GDelegate18 gdelegate18_1, bool bool_2 = false)
		{
			this.m_pVTable = IntPtr.Zero;
			this.m_size = Marshal.SizeOf(typeof(T));
			base..ctor();
			this.m_bGameServer = bool_2;
			this.BuildCCallbackBase();
			this.Register(gdelegate18_1);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000A62D0 File Offset: 0x000A44D0
		private void method_17(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			this.method_26(gdelegate18_1);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000A62E4 File Offset: 0x000A44E4
		void method_18()
		{
			try
			{
				this.Dispose();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x000A6314 File Offset: 0x000A4514
		private void method_19()
		{
			this.method_4();
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000A6328 File Offset: 0x000A4528
		public void vmethod_0()
		{
			this.method_7();
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000A633C File Offset: 0x000A453C
		public void method_20()
		{
			this.method_21();
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000A6350 File Offset: 0x000A4550
		internal void method_21()
		{
			this.method_0();
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000A6364 File Offset: 0x000A4564
		internal void method_22()
		{
			if (!this.m_bDisposed)
			{
				GC.SuppressFinalize(this);
				this.Unregister();
				if (this.m_pVTable != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.m_pVTable);
				}
				if (this.m_pCCallbackBase.IsAllocated)
				{
					this.m_pCCallbackBase.Free();
				}
				this.m_bDisposed = true;
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000A61E4 File Offset: 0x000A43E4
		private void method_23(IntPtr intptr_1, IntPtr intptr_2)
		{
			try
			{
				this.m_Func((T)((object)Marshal.PtrToStructure(intptr_2, typeof(T))));
			}
			catch (Exception exception_)
			{
				GClass111.smethod_1(exception_);
			}
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000A63C4 File Offset: 0x000A45C4
		private void method_24(IntPtr intptr_1, IntPtr intptr_2)
		{
			this.method_23(intptr_1, intptr_2);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000A63DC File Offset: 0x000A45DC
		private void method_25(IntPtr intptr_1, IntPtr intptr_2, bool bool_2, ulong ulong_0)
		{
			this.method_12(intptr_1, intptr_2, bool_2, ulong_0);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000A63F8 File Offset: 0x000A45F8
		private void method_26(GClass114<T>.GDelegate18 gdelegate18_1)
		{
			GClass114<T>.GDelegate18 gdelegate = this.m_Func;
			GClass114<T>.GDelegate18 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass114<T>.GDelegate18 value = (GClass114<T>.GDelegate18)Delegate.Combine(gdelegate2, gdelegate18_1);
				gdelegate = Interlocked.CompareExchange<GClass114<T>.GDelegate18>(ref this.m_Func, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x040012B6 RID: 4790
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GClass114<T>.GDelegate18 gdelegate18_0;

		// Token: 0x040012B7 RID: 4791
		private Class151 class151_0;

		// Token: 0x040012B8 RID: 4792
		private IntPtr intptr_0;

		// Token: 0x040012B9 RID: 4793
		private Class91 class91_0;

		// Token: 0x040012BA RID: 4794
		private GCHandle gchandle_0;

		// Token: 0x040012BB RID: 4795
		private readonly bool bool_0;

		// Token: 0x040012BC RID: 4796
		private readonly int int_0;

		// Token: 0x040012BD RID: 4797
		private bool bool_1;

		// Token: 0x020002C7 RID: 711
		// (Invoke) Token: 0x060020A8 RID: 8360
		public delegate void GDelegate18(T gparam_0);
	}
}
