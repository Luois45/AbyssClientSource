using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;
using ns309;
using ns381;

namespace ns226
{
	// Token: 0x020001A0 RID: 416
	public class GClass78
	{
		// Token: 0x06000FB5 RID: 4021 RVA: 0x0005433C File Offset: 0x0005253C
		public static string smethod_0(IntPtr intptr_0)
		{
			return GClass78.smethod_8(intptr_0);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00054350 File Offset: 0x00052550
		public static void smethod_1()
		{
			GClass78.smethod_9();
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00054364 File Offset: 0x00052564
		public static void smethod_2()
		{
			GClass78.smethod_7();
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00054378 File Offset: 0x00052578
		internal static void smethod_3()
		{
			if (<Module>.smethod_2() == IntPtr.Zero && !<Module>.smethod_1())
			{
				throw new InvalidOperationException("Steamworks is not initialized.");
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000543B0 File Offset: 0x000525B0
		internal static string smethod_4(IntPtr intptr_0)
		{
			string result;
			if (intptr_0 == IntPtr.Zero)
			{
				result = null;
			}
			else
			{
				int num = 0;
				while (Marshal.ReadByte(intptr_0, num) > 0)
				{
					num++;
				}
				if (num == 0)
				{
					result = string.Empty;
				}
				else
				{
					byte[] array = new byte[num];
					Marshal.Copy(intptr_0, array, 0, array.Length);
					result = Encoding.UTF8.GetString(array);
				}
			}
			return result;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00004908 File Offset: 0x00002B08
		public static void smethod_5()
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00054410 File Offset: 0x00052610
		internal static void smethod_6()
		{
			if (Class180.smethod_10() == IntPtr.Zero && !Class180.smethod_1())
			{
				throw new InvalidOperationException("Steamworks GameServer is not initialized.");
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00054448 File Offset: 0x00052648
		internal static void smethod_7()
		{
			GClass78.smethod_6();
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0005445C File Offset: 0x0005265C
		internal static string smethod_8(IntPtr intptr_0)
		{
			return GClass78.smethod_4(intptr_0);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00054470 File Offset: 0x00052670
		internal static void smethod_9()
		{
			GClass78.smethod_3();
		}

		// Token: 0x020001A1 RID: 417
		public class GClass79 : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x06000FC0 RID: 4032 RVA: 0x00054484 File Offset: 0x00052684
			public GClass79(string string_0) : base(true)
			{
				if (string_0 == null)
				{
					base.SetHandle(IntPtr.Zero);
				}
				else
				{
					byte[] array = new byte[Encoding.UTF8.GetByteCount(string_0) + 1];
					Encoding.UTF8.GetBytes(string_0, 0, string_0.Length, array, 0);
					IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
					Marshal.Copy(array, 0, intPtr, array.Length);
					base.SetHandle(intPtr);
				}
			}

			// Token: 0x06000FC1 RID: 4033 RVA: 0x000544F0 File Offset: 0x000526F0
			protected virtual bool vmethod_0()
			{
				if (!this.IsInvalid)
				{
					Marshal.FreeHGlobal(this.handle);
				}
				return true;
			}
		}

		// Token: 0x020001A2 RID: 418
		public class GClass80
		{
			// Token: 0x06000FC2 RID: 4034 RVA: 0x00054514 File Offset: 0x00052714
			public GClass80(IList<string> ilist_0)
			{
				if (ilist_0 == null)
				{
					this.intptr_2 = IntPtr.Zero;
				}
				else
				{
					this.intptr_0 = new IntPtr[ilist_0.Count];
					for (int i = 0; i < ilist_0.Count; i++)
					{
						byte[] array = new byte[Encoding.UTF8.GetByteCount(ilist_0[i]) + 1];
						Encoding.UTF8.GetBytes(ilist_0[i], 0, ilist_0[i].Length, array, 0);
						this.intptr_0[i] = Marshal.AllocHGlobal(array.Length);
						Marshal.Copy(array, 0, this.intptr_0[i], array.Length);
					}
					this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * this.intptr_0.Length);
					GStruct205 gstruct = new GStruct205
					{
						intptr_0 = this.intptr_1,
						int_0 = this.intptr_0.Length
					};
					Marshal.Copy(this.intptr_0, 0, gstruct.intptr_0, this.intptr_0.Length);
					this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GStruct205)));
					Marshal.StructureToPtr<GStruct205>(gstruct, this.intptr_2, false);
				}
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x00054648 File Offset: 0x00052848
			public static IntPtr smethod_0(GClass78.GClass80 gclass80_0)
			{
				return gclass80_0.intptr_2;
			}

			// Token: 0x04000BAE RID: 2990
			private readonly IntPtr[] intptr_0;

			// Token: 0x04000BAF RID: 2991
			private readonly IntPtr intptr_1;

			// Token: 0x04000BB0 RID: 2992
			private IntPtr intptr_2;
		}
	}
}
