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
using ns387;

namespace ns409
{
	// Token: 0x02000310 RID: 784
	public sealed class GClass123<T> : IDisposable
	{
		// Token: 0x06004076 RID: 16502 RVA: 0x000F36AC File Offset: 0x000F18AC
		private int method_0(IntPtr intptr_1)
		{
			return this.m_size;
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000F36C4 File Offset: 0x000F18C4
		private void method_1(IntPtr intptr_1, IntPtr intptr_2)
		{
			this.method_24(intptr_1, intptr_2);
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000F36DC File Offset: 0x000F18DC
		internal void method_2()
		{
			if (GStruct241.smethod_3(this.m_hAPICall, GStruct241.gstruct241_0))
			{
				Class177.SteamAPI_UnregisterCallResult(this.m_pCCallbackBase.AddrOfPinnedObject(), GStruct241.smethod_1(this.m_hAPICall));
				this.m_hAPICall = GStruct241.gstruct241_0;
			}
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000F3724 File Offset: 0x000F1924
		public static GClass123<T> smethod_0(GClass123<T>.GDelegate20 gdelegate20_1 = null)
		{
			return new GClass123<T>(gdelegate20_1);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000F373C File Offset: 0x000F193C
		internal void method_3(GStruct241 gstruct241_1, GClass123<T>.GDelegate20 gdelegate20_1)
		{
			this.method_16(gstruct241_1, gdelegate20_1);
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x000F3754 File Offset: 0x000F1954
		internal void method_4()
		{
			this.method_10();
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x000F3768 File Offset: 0x000F1968
		internal void method_5()
		{
			if (!this.m_bDisposed)
			{
				GC.SuppressFinalize(this);
				this.Cancel();
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

		// Token: 0x0600407D RID: 16509 RVA: 0x000F37C8 File Offset: 0x000F19C8
		private void method_6(IntPtr intptr_1, IntPtr intptr_2)
		{
			this.method_1(intptr_1, intptr_2);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x000F37E0 File Offset: 0x000F19E0
		private void method_7(IntPtr intptr_1, IntPtr intptr_2, bool bool_1, ulong ulong_0)
		{
			this.method_21(intptr_1, intptr_2, bool_1, ulong_0);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600408F RID: 16527 RVA: 0x000F3AA4 File Offset: 0x000F1CA4
		// (remove) Token: 0x0600407F RID: 16511 RVA: 0x000F37FC File Offset: 0x000F19FC
		private event GClass123<T>.GDelegate20 Event_0
		{
			[CompilerGenerated]
			add
			{
				this.method_15(value);
			}
			[CompilerGenerated]
			remove
			{
				this.method_17(value);
			}
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x000F3810 File Offset: 0x000F1A10
		public void method_8(GStruct241 gstruct241_1, GClass123<T>.GDelegate20 gdelegate20_1 = null)
		{
			this.method_3(gstruct241_1, gdelegate20_1);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000F3828 File Offset: 0x000F1A28
		protected void Finalize()
		{
			this.method_20();
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000F383C File Offset: 0x000F1A3C
		private void method_9()
		{
			this.method_23();
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x000F3850 File Offset: 0x000F1A50
		internal void method_10()
		{
			Class91 ccallbackBase = this.m_CCallbackBase;
			Class91 @class = ccallbackBase;
			@class.byte_2 |= 2;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x000F3874 File Offset: 0x000F1A74
		public void method_11()
		{
			this.method_25();
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x000F3888 File Offset: 0x000F1A88
		internal void method_12()
		{
			this.method_5();
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x000F389C File Offset: 0x000F1A9C
		private void method_13()
		{
			this.m_CallbackBaseVTable = new Class151
			{
				delegate33_0 = new Class151.Delegate33(this.OnRunCallback),
				delegate34_0 = new Class151.Delegate34(this.OnRunCallResult),
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

		// Token: 0x06004087 RID: 16519 RVA: 0x000F3960 File Offset: 0x000F1B60
		private void method_14(IntPtr intptr_1, IntPtr intptr_2, bool bool_1, ulong ulong_0)
		{
			this.method_7(intptr_1, intptr_2, bool_1, ulong_0);
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x000F397C File Offset: 0x000F1B7C
		private void method_15(GClass123<T>.GDelegate20 gdelegate20_1)
		{
			this.method_27(gdelegate20_1);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x000F3990 File Offset: 0x000F1B90
		internal void method_16(GStruct241 gstruct241_1, GClass123<T>.GDelegate20 gdelegate20_1)
		{
			if (gdelegate20_1 != null)
			{
				this.m_Func = gdelegate20_1;
			}
			if (this.m_Func == null)
			{
				throw new Exception("CallResult function was null, you must either set it in the CallResult Constructor or via Set()");
			}
			if (GStruct241.smethod_3(this.m_hAPICall, GStruct241.gstruct241_0))
			{
				Class177.SteamAPI_UnregisterCallResult(this.m_pCCallbackBase.AddrOfPinnedObject(), GStruct241.smethod_1(this.m_hAPICall));
			}
			this.m_hAPICall = gstruct241_1;
			if (GStruct241.smethod_3(gstruct241_1, GStruct241.gstruct241_0))
			{
				Class177.SteamAPI_RegisterCallResult(this.m_pCCallbackBase.AddrOfPinnedObject(), GStruct241.smethod_1(gstruct241_1));
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x000F3A18 File Offset: 0x000F1C18
		private void method_17(GClass123<T>.GDelegate20 gdelegate20_1)
		{
			this.method_26(gdelegate20_1);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x000F3A2C File Offset: 0x000F1C2C
		public void vmethod_0()
		{
			this.method_12();
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x000F3A40 File Offset: 0x000F1C40
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

		// Token: 0x0600408D RID: 16525 RVA: 0x000F3A70 File Offset: 0x000F1C70
		public bool method_19()
		{
			return GStruct241.smethod_3(this.m_hAPICall, GStruct241.gstruct241_0);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x000F3A90 File Offset: 0x000F1C90
		void method_20()
		{
			this.method_18();
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000F3AB8 File Offset: 0x000F1CB8
		private void method_21(IntPtr intptr_1, IntPtr intptr_2, bool bool_1, ulong ulong_0)
		{
			if (GStruct241.smethod_2(GStruct241.smethod_0(ulong_0), this.m_hAPICall))
			{
				this.m_hAPICall = GStruct241.gstruct241_0;
				try
				{
					this.m_Func((T)((object)Marshal.PtrToStructure(intptr_2, typeof(T))), bool_1);
				}
				catch (Exception exception_)
				{
					GClass111.smethod_1(exception_);
				}
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000F3B20 File Offset: 0x000F1D20
		public void method_22()
		{
			this.method_4();
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x000F3B34 File Offset: 0x000F1D34
		public GStruct241 GStruct241_0
		{
			get
			{
				return this.m_hAPICall;
			}
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000F3B4C File Offset: 0x000F1D4C
		private void method_23()
		{
			this.method_13();
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x000F3B60 File Offset: 0x000F1D60
		private void method_24(IntPtr intptr_1, IntPtr intptr_2)
		{
			this.m_hAPICall = GStruct241.gstruct241_0;
			try
			{
				this.m_Func((T)((object)Marshal.PtrToStructure(intptr_2, typeof(T))), false);
			}
			catch (Exception exception_)
			{
				GClass111.smethod_1(exception_);
			}
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x000F3BB4 File Offset: 0x000F1DB4
		public GClass123(GClass123<T>.GDelegate20 gdelegate20_1 = null)
		{
			this.m_pVTable = IntPtr.Zero;
			this.m_hAPICall = GStruct241.gstruct241_0;
			this.m_size = Marshal.SizeOf(typeof(T));
			base..ctor();
			this.m_Func = gdelegate20_1;
			this.BuildCCallbackBase();
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x000F3C00 File Offset: 0x000F1E00
		internal void method_25()
		{
			this.method_2();
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x000F3C14 File Offset: 0x000F1E14
		private void method_26(GClass123<T>.GDelegate20 gdelegate20_1)
		{
			GClass123<T>.GDelegate20 gdelegate = this.m_Func;
			GClass123<T>.GDelegate20 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass123<T>.GDelegate20 value = (GClass123<T>.GDelegate20)Delegate.Remove(gdelegate2, gdelegate20_1);
				gdelegate = Interlocked.CompareExchange<GClass123<T>.GDelegate20>(ref this.m_Func, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x000F3C4C File Offset: 0x000F1E4C
		private void method_27(GClass123<T>.GDelegate20 gdelegate20_1)
		{
			GClass123<T>.GDelegate20 gdelegate = this.m_Func;
			GClass123<T>.GDelegate20 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass123<T>.GDelegate20 value = (GClass123<T>.GDelegate20)Delegate.Combine(gdelegate2, gdelegate20_1);
				gdelegate = Interlocked.CompareExchange<GClass123<T>.GDelegate20>(ref this.m_Func, value, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}

		// Token: 0x04001914 RID: 6420
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GClass123<T>.GDelegate20 gdelegate20_0;

		// Token: 0x04001915 RID: 6421
		private Class151 class151_0;

		// Token: 0x04001916 RID: 6422
		private IntPtr intptr_0;

		// Token: 0x04001917 RID: 6423
		private Class91 class91_0;

		// Token: 0x04001918 RID: 6424
		private GCHandle gchandle_0;

		// Token: 0x04001919 RID: 6425
		private GStruct241 gstruct241_0;

		// Token: 0x0400191A RID: 6426
		private readonly int int_0;

		// Token: 0x0400191B RID: 6427
		private bool bool_0;

		// Token: 0x02000311 RID: 785
		// (Invoke) Token: 0x0600409A RID: 16538
		public delegate void GDelegate20(T gparam_0, bool bool_0);
	}
}
