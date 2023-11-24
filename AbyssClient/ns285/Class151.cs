using System;
using System.Runtime.InteropServices;

namespace ns285
{
	// Token: 0x02000249 RID: 585
	[StructLayout(LayoutKind.Sequential)]
	internal class Class151
	{
		// Token: 0x04000FA6 RID: 4006
		private const CallingConvention callingConvention_0 = CallingConvention.ThisCall;

		// Token: 0x04000FA7 RID: 4007
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public Class151.Delegate34 delegate34_0;

		// Token: 0x04000FA8 RID: 4008
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public Class151.Delegate33 delegate33_0;

		// Token: 0x04000FA9 RID: 4009
		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public Class151.Delegate35 delegate35_0;

		// Token: 0x0200024A RID: 586
		// (Invoke) Token: 0x06001B4C RID: 6988
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void Delegate33(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x06001B52 RID: 6994
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void Delegate34(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.I1)] bool bool_0, ulong ulong_0);

		// Token: 0x0200024C RID: 588
		// (Invoke) Token: 0x06001B56 RID: 6998
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate int Delegate35(IntPtr intptr_0);
	}
}
