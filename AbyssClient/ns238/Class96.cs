using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using ns185;
using ns208;
using ns349;

namespace ns238
{
	// Token: 0x020001B5 RID: 437
	internal static class Class96
	{
		// Token: 0x06001081 RID: 4225 RVA: 0x00057764 File Offset: 0x00055964
		internal static int smethod_0(IntPtr intptr_0)
		{
			method fnptr_ = Class96.struct15_0.fnptr_3;
			return calli(System.Int32(System.IntPtr), intptr_0, fnptr_);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00057788 File Offset: 0x00055988
		internal unsafe static string smethod_1(Class80.Struct2* pStruct2_0)
		{
			return Class96.smethod_9(pStruct2_0);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0005779C File Offset: 0x0005599C
		internal static void smethod_2(IntPtr intptr_0)
		{
			Class96.smethod_7(intptr_0);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000577B0 File Offset: 0x000559B0
		internal unsafe static bool smethod_3()
		{
			string text;
			using (SHA512 sha = SHA512.Create())
			{
				using (FileStream fileStream = File.OpenRead("UnityPlayer.dll"))
				{
					text = Convert.ToBase64String(sha.ComputeHash(fileStream));
				}
			}
			ValueTuple<int, int> valueTuple;
			bool result;
			if (!Class96.dictionary_0.TryGetValue(text, out valueTuple))
			{
				GClass70.smethod_36("Unknown UnityPlayer hash: " + text, GClass70.Enum1.const_0);
				GClass70.smethod_36("Bundle verifier will not work", GClass70.Enum1.const_0);
				result = false;
			}
			else
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (processModule.FileName.Contains("UnityPlayer"))
					{
						IntPtr intPtr = processModule.BaseAddress + valueTuple.Item1;
						Class96.struct15_0 = *(Class96.Struct15*)((void*)intPtr);
						Class96.Struct15 @struct = Class96.smethod_6();
						uint uint_;
						Class96.VirtualProtect(intPtr, (UIntPtr)((ulong)((long)Marshal.SizeOf<Class96.Struct15>())), 4U, out uint_);
						*(Class96.Struct15*)((void*)intPtr) = @struct;
						Class96.VirtualProtect(intPtr, (UIntPtr)((ulong)((long)Marshal.SizeOf<Class96.Struct15>())), uint_, out uint_);
						GClass70.smethod_38("Patched ABDH vTable", GClass70.Enum1.const_0);
						IntPtr intptr_ = processModule.BaseAddress + valueTuple.Item2;
						Class80.smethod_1<Class96.Delegate25>(intptr_, out Class96.delegate25_0, new Class96.Delegate25(Class96.smethod_4), null);
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001085 RID: 4229
		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtect(IntPtr intptr_0, UIntPtr uintptr_0, uint uint_0, out uint uint_1);

		// Token: 0x06001086 RID: 4230 RVA: 0x00057958 File Offset: 0x00055B58
		private unsafe static IntPtr smethod_4(IntPtr intptr_0, Class80.Struct2* pStruct2_0, Class80.Struct2* pStruct2_1, IntPtr intptr_1, int int_0)
		{
			IntPtr intPtr = Class96.delegate25_0(intptr_0, pStruct2_0, pStruct2_1, intptr_1, int_0);
			try
			{
				Class172.smethod_10(intPtr, pStruct2_0);
			}
			catch (Exception arg)
			{
				GClass70.smethod_36(string.Format("Exception in CreateCached patch: {0}", arg), GClass70.Enum1.const_0);
			}
			return intPtr;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000579A8 File Offset: 0x00055BA8
		internal static int smethod_5(IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			method fnptr_ = Class96.struct15_0.fnptr_1;
			return calli(System.Int32(System.IntPtr,System.IntPtr,System.Int32), intptr_0, intptr_1, int_0, fnptr_);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00057A08 File Offset: 0x00055C08
		private unsafe static Class96.Struct15 smethod_6()
		{
			Class96.Struct15 result = Class96.struct15_0;
			result.fnptr_3 = (void*)Class96.smethod_11<Class96.Delegate26>(new Class96.Delegate26(Class172.smethod_5));
			result.fnptr_0 = (void*)Class96.smethod_11<Class96.Delegate28>(new Class96.Delegate28(Class172.smethod_1));
			result.fnptr_2 = (void*)Class96.smethod_11<Class96.Delegate27>(new Class96.Delegate27(Class172.smethod_2));
			result.fnptr_1 = (void*)Class96.smethod_11<Class96.Delegate29>(new Class96.Delegate29(Class172.smethod_3));
			return result;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00057A94 File Offset: 0x00055C94
		internal static void smethod_7(IntPtr intptr_0)
		{
			method fnptr_ = Class96.struct15_0.fnptr_2;
			calli(System.Void(System.IntPtr), intptr_0, fnptr_);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00057AB4 File Offset: 0x00055CB4
		internal static void smethod_8(IntPtr intptr_0)
		{
			Class96.smethod_2(intptr_0);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00057AC8 File Offset: 0x00055CC8
		internal unsafe static string smethod_9(Class80.Struct2* pStruct2_0)
		{
			return Class96.smethod_12(pStruct2_0);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00057ADC File Offset: 0x00055CDC
		internal static IntPtr smethod_10(IntPtr intptr_0, long long_0)
		{
			method fnptr_ = Class96.struct15_0.fnptr_0;
			return calli(System.IntPtr(System.IntPtr,System.Int64), intptr_0, long_0, fnptr_);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00057AFC File Offset: 0x00055CFC
		private static IntPtr smethod_11<T>(T gparam_0) where T : MulticastDelegate
		{
			Class96.list_0.Add(gparam_0);
			return Marshal.GetFunctionPointerForDelegate<T>(gparam_0);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00057B24 File Offset: 0x00055D24
		internal unsafe static string smethod_12(Class80.Struct2* pStruct2_0)
		{
			string result;
			if (pStruct2_0 == null)
			{
				result = null;
			}
			else if (pStruct2_0->long_2 == 0L)
			{
				result = string.Empty;
			}
			else
			{
				IntPtr intPtr = pStruct2_0->intptr_0;
				if (intPtr == IntPtr.Zero)
				{
					intPtr = (IntPtr)((void*)(&pStruct2_0->long_0));
				}
				result = new string((sbyte*)((void*)intPtr), 0, (int)pStruct2_0->long_2, Encoding.UTF8);
			}
			return result;
		}

		// Token: 0x04000C31 RID: 3121
		[TupleElementNames(new string[]
		{
			"VTable",
			"CreateCached"
		})]
		private static readonly Dictionary<string, ValueTuple<int, int>> dictionary_0 = new Dictionary<string, ValueTuple<int, int>>
		{
			{
				"sgZUlX3+LSHKnTiTC+nXNcdtLOTrAB1fNjBLOwDdKzCyndlFLAdL0udR4S1szTC/q5pnFhG3Kdspsj5jvwLY1A==",
				new ValueTuple<int, int>(21492056, 3403056)
			}
		};

		// Token: 0x04000C32 RID: 3122
		private static readonly List<Delegate> list_0 = new List<Delegate>();

		// Token: 0x04000C33 RID: 3123
		private static Class96.Struct15 struct15_0;

		// Token: 0x04000C34 RID: 3124
		private static Class96.Delegate25 delegate25_0;

		// Token: 0x020001B6 RID: 438
		// (Invoke) Token: 0x06001092 RID: 4242
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate IntPtr Delegate25(IntPtr intptr_0, Class80.Struct2* pStruct2_0, Class80.Struct2* pStruct2_1, IntPtr intptr_1, int int_0);

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06001095 RID: 4245
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate26(IntPtr intptr_0);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06001098 RID: 4248
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate27(IntPtr intptr_0);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x0600109D RID: 4253
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate28(IntPtr intptr_0, long long_0);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x060010A2 RID: 4258
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate29(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		// Token: 0x020001BB RID: 443
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 112)]
		private struct Struct15
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060010AC RID: 4268 RVA: 0x00057C64 File Offset: 0x00055E64
			// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00057B94 File Offset: 0x00055D94
			public unsafe method fnptr_2
			{
				get
				{
					return (void*)this.intptr_6;
				}
				set
				{
					this.intptr_6 = (IntPtr)value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00057BB0 File Offset: 0x00055DB0
			// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00057BC8 File Offset: 0x00055DC8
			public unsafe method fnptr_3
			{
				get
				{
					return (void*)this.intptr_12;
				}
				set
				{
					this.intptr_12 = (IntPtr)value;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00057BE4 File Offset: 0x00055DE4
			// (set) Token: 0x060010AD RID: 4269 RVA: 0x00057C7C File Offset: 0x00055E7C
			public unsafe method fnptr_4
			{
				get
				{
					return (void*)this.intptr_13;
				}
				set
				{
					this.intptr_13 = (IntPtr)value;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00057BFC File Offset: 0x00055DFC
			// (set) Token: 0x060010AA RID: 4266 RVA: 0x00057C30 File Offset: 0x00055E30
			public unsafe method fnptr_0
			{
				get
				{
					return (void*)this.intptr_0;
				}
				set
				{
					this.intptr_0 = (IntPtr)value;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060010AB RID: 4267 RVA: 0x00057C4C File Offset: 0x00055E4C
			// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00057C14 File Offset: 0x00055E14
			public unsafe method fnptr_1
			{
				get
				{
					return (void*)this.intptr_3;
				}
				set
				{
					this.intptr_3 = (IntPtr)value;
				}
			}

			// Token: 0x04000C35 RID: 3125
			private IntPtr intptr_0;

			// Token: 0x04000C36 RID: 3126
			private IntPtr intptr_1;

			// Token: 0x04000C37 RID: 3127
			private IntPtr intptr_2;

			// Token: 0x04000C38 RID: 3128
			private IntPtr intptr_3;

			// Token: 0x04000C39 RID: 3129
			private IntPtr intptr_4;

			// Token: 0x04000C3A RID: 3130
			private IntPtr intptr_5;

			// Token: 0x04000C3B RID: 3131
			private IntPtr intptr_6;

			// Token: 0x04000C3C RID: 3132
			private IntPtr intptr_7;

			// Token: 0x04000C3D RID: 3133
			private IntPtr intptr_8;

			// Token: 0x04000C3E RID: 3134
			private IntPtr intptr_9;

			// Token: 0x04000C3F RID: 3135
			private IntPtr intptr_10;

			// Token: 0x04000C40 RID: 3136
			private IntPtr intptr_11;

			// Token: 0x04000C41 RID: 3137
			private IntPtr intptr_12;

			// Token: 0x04000C42 RID: 3138
			private IntPtr intptr_13;
		}
	}
}
