using System;
using System.Runtime.InteropServices;
using ns38;

namespace ns215
{
	// Token: 0x02000187 RID: 391
	public static class GClass74
	{
		// Token: 0x06000F40 RID: 3904
		[Attribute0(2)]
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool CreateProcess(string string_0, string string_1, ref GClass74.GStruct110 gstruct110_0, ref GClass74.GStruct110 gstruct110_1, bool bool_0, GClass74.GEnum39 genum39_0, IntPtr intptr_0, string string_2, [In] ref GClass74.GStruct111 gstruct111_0, out GClass74.GStruct112 gstruct112_0);

		// Token: 0x06000F41 RID: 3905
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool SetInformationJobObject(IntPtr intptr_0, GClass74.GEnum40 genum40_0, IntPtr intptr_1, int int_1);

		// Token: 0x06000F42 RID: 3906
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool AssignProcessToJobObject(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x06000F43 RID: 3907
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int ResumeThread(IntPtr intptr_0);

		// Token: 0x06000F44 RID: 3908
		[Attribute0(2)]
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr CreateJobObject(ref GClass74.GStruct110 gstruct110_0, string string_0);

		// Token: 0x06000F45 RID: 3909
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool GetExitCodeProcess(IntPtr intptr_0, out int int_1);

		// Token: 0x06000F46 RID: 3910
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr intptr_0);

		// Token: 0x06000F47 RID: 3911
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool QueryInformationJobObject(IntPtr intptr_0, GClass74.GEnum40 genum40_0, IntPtr intptr_1, int int_1, out int int_2);

		// Token: 0x04000AE5 RID: 2789
		public const int int_0 = 259;

		// Token: 0x02000188 RID: 392
		[Flags]
		public enum GEnum39 : uint
		{
			// Token: 0x04000AE7 RID: 2791
			flag_0 = 1U,
			// Token: 0x04000AE8 RID: 2792
			flag_1 = 2U,
			// Token: 0x04000AE9 RID: 2793
			flag_2 = 4U,
			// Token: 0x04000AEA RID: 2794
			flag_3 = 8U,
			// Token: 0x04000AEB RID: 2795
			flag_4 = 16U,
			// Token: 0x04000AEC RID: 2796
			flag_5 = 512U,
			// Token: 0x04000AED RID: 2797
			flag_6 = 1024U,
			// Token: 0x04000AEE RID: 2798
			flag_7 = 2048U,
			// Token: 0x04000AEF RID: 2799
			flag_8 = 4096U,
			// Token: 0x04000AF0 RID: 2800
			flag_9 = 65536U,
			// Token: 0x04000AF1 RID: 2801
			flag_10 = 262144U,
			// Token: 0x04000AF2 RID: 2802
			flag_11 = 524288U,
			// Token: 0x04000AF3 RID: 2803
			flag_12 = 4194304U,
			// Token: 0x04000AF4 RID: 2804
			flag_13 = 16777216U,
			// Token: 0x04000AF5 RID: 2805
			flag_14 = 33554432U,
			// Token: 0x04000AF6 RID: 2806
			flag_15 = 67108864U,
			// Token: 0x04000AF7 RID: 2807
			flag_16 = 134217728U
		}

		// Token: 0x02000189 RID: 393
		public struct GStruct110
		{
			// Token: 0x04000AF8 RID: 2808
			public int int_0;

			// Token: 0x04000AF9 RID: 2809
			public IntPtr intptr_0;

			// Token: 0x04000AFA RID: 2810
			public bool bool_0;
		}

		// Token: 0x0200018A RID: 394
		public struct GStruct111
		{
			// Token: 0x04000AFB RID: 2811
			public int int_0;

			// Token: 0x04000AFC RID: 2812
			public IntPtr intptr_0;

			// Token: 0x04000AFD RID: 2813
			public IntPtr intptr_1;

			// Token: 0x04000AFE RID: 2814
			public IntPtr intptr_2;

			// Token: 0x04000AFF RID: 2815
			public int int_1;

			// Token: 0x04000B00 RID: 2816
			public int int_2;

			// Token: 0x04000B01 RID: 2817
			public int int_3;

			// Token: 0x04000B02 RID: 2818
			public int int_4;

			// Token: 0x04000B03 RID: 2819
			public int int_5;

			// Token: 0x04000B04 RID: 2820
			public int int_6;

			// Token: 0x04000B05 RID: 2821
			public int int_7;

			// Token: 0x04000B06 RID: 2822
			public int int_8;

			// Token: 0x04000B07 RID: 2823
			public short short_0;

			// Token: 0x04000B08 RID: 2824
			public short short_1;

			// Token: 0x04000B09 RID: 2825
			public IntPtr intptr_3;

			// Token: 0x04000B0A RID: 2826
			public IntPtr intptr_4;

			// Token: 0x04000B0B RID: 2827
			public IntPtr intptr_5;

			// Token: 0x04000B0C RID: 2828
			public IntPtr intptr_6;
		}

		// Token: 0x0200018B RID: 395
		public struct GStruct112
		{
			// Token: 0x04000B0D RID: 2829
			public IntPtr intptr_0;

			// Token: 0x04000B0E RID: 2830
			public IntPtr intptr_1;

			// Token: 0x04000B0F RID: 2831
			public int int_0;

			// Token: 0x04000B10 RID: 2832
			public int int_1;
		}

		// Token: 0x0200018C RID: 396
		public enum GEnum40
		{
			// Token: 0x04000B12 RID: 2834
			const_0 = 1,
			// Token: 0x04000B13 RID: 2835
			const_1,
			// Token: 0x04000B14 RID: 2836
			const_2,
			// Token: 0x04000B15 RID: 2837
			const_3,
			// Token: 0x04000B16 RID: 2838
			const_4,
			// Token: 0x04000B17 RID: 2839
			const_5,
			// Token: 0x04000B18 RID: 2840
			const_6,
			// Token: 0x04000B19 RID: 2841
			const_7,
			// Token: 0x04000B1A RID: 2842
			const_8,
			// Token: 0x04000B1B RID: 2843
			const_9 = 11,
			// Token: 0x04000B1C RID: 2844
			const_10,
			// Token: 0x04000B1D RID: 2845
			const_11,
			// Token: 0x04000B1E RID: 2846
			const_12,
			// Token: 0x04000B1F RID: 2847
			const_13,
			// Token: 0x04000B20 RID: 2848
			const_14 = 32,
			// Token: 0x04000B21 RID: 2849
			const_15,
			// Token: 0x04000B22 RID: 2850
			const_16
		}

		// Token: 0x0200018D RID: 397
		public struct GStruct113
		{
			// Token: 0x04000B23 RID: 2851
			public GClass74.GEnum41 genum41_0;
		}

		// Token: 0x0200018E RID: 398
		[Flags]
		public enum GEnum41
		{
			// Token: 0x04000B25 RID: 2853
			flag_0 = 1,
			// Token: 0x04000B26 RID: 2854
			flag_1 = 2,
			// Token: 0x04000B27 RID: 2855
			flag_2 = 4,
			// Token: 0x04000B28 RID: 2856
			flag_3 = 8,
			// Token: 0x04000B29 RID: 2857
			flag_4 = 16,
			// Token: 0x04000B2A RID: 2858
			flag_5 = 32,
			// Token: 0x04000B2B RID: 2859
			flag_6 = 64,
			// Token: 0x04000B2C RID: 2860
			flag_7 = 128,
			// Token: 0x04000B2D RID: 2861
			flag_8 = 255
		}

		// Token: 0x0200018F RID: 399
		public struct GStruct114
		{
			// Token: 0x04000B2E RID: 2862
			public long long_0;

			// Token: 0x04000B2F RID: 2863
			public long long_1;

			// Token: 0x04000B30 RID: 2864
			public GClass74.GEnum42 genum42_0;

			// Token: 0x04000B31 RID: 2865
			public IntPtr intptr_0;

			// Token: 0x04000B32 RID: 2866
			public IntPtr intptr_1;

			// Token: 0x04000B33 RID: 2867
			public int int_0;

			// Token: 0x04000B34 RID: 2868
			public IntPtr intptr_2;

			// Token: 0x04000B35 RID: 2869
			public int int_1;

			// Token: 0x04000B36 RID: 2870
			public int int_2;
		}

		// Token: 0x02000190 RID: 400
		public struct GStruct115
		{
			// Token: 0x04000B37 RID: 2871
			public GClass74.GStruct114 gstruct114_0;

			// Token: 0x04000B38 RID: 2872
			public GClass74.GStruct116 gstruct116_0;

			// Token: 0x04000B39 RID: 2873
			public IntPtr intptr_0;

			// Token: 0x04000B3A RID: 2874
			public IntPtr intptr_1;

			// Token: 0x04000B3B RID: 2875
			public IntPtr intptr_2;

			// Token: 0x04000B3C RID: 2876
			public IntPtr intptr_3;
		}

		// Token: 0x02000191 RID: 401
		public struct GStruct116
		{
			// Token: 0x04000B3D RID: 2877
			public ulong ulong_0;

			// Token: 0x04000B3E RID: 2878
			public ulong ulong_1;

			// Token: 0x04000B3F RID: 2879
			public ulong ulong_2;

			// Token: 0x04000B40 RID: 2880
			public ulong ulong_3;

			// Token: 0x04000B41 RID: 2881
			public ulong ulong_4;

			// Token: 0x04000B42 RID: 2882
			public ulong ulong_5;
		}

		// Token: 0x02000192 RID: 402
		[Flags]
		public enum GEnum42
		{
			// Token: 0x04000B44 RID: 2884
			flag_0 = 1,
			// Token: 0x04000B45 RID: 2885
			flag_1 = 2,
			// Token: 0x04000B46 RID: 2886
			flag_2 = 4,
			// Token: 0x04000B47 RID: 2887
			flag_3 = 8,
			// Token: 0x04000B48 RID: 2888
			flag_4 = 16,
			// Token: 0x04000B49 RID: 2889
			flag_5 = 32,
			// Token: 0x04000B4A RID: 2890
			flag_6 = 64,
			// Token: 0x04000B4B RID: 2891
			flag_7 = 128,
			// Token: 0x04000B4C RID: 2892
			flag_8 = 256,
			// Token: 0x04000B4D RID: 2893
			flag_9 = 512,
			// Token: 0x04000B4E RID: 2894
			flag_10 = 1024,
			// Token: 0x04000B4F RID: 2895
			flag_11 = 2048,
			// Token: 0x04000B50 RID: 2896
			flag_12 = 4096,
			// Token: 0x04000B51 RID: 2897
			flag_13 = 8192,
			// Token: 0x04000B52 RID: 2898
			flag_14 = 16384
		}

		// Token: 0x02000193 RID: 403
		public struct GStruct117
		{
			// Token: 0x04000B53 RID: 2899
			public long long_0;

			// Token: 0x04000B54 RID: 2900
			public GClass74.GEnum43 genum43_0;

			// Token: 0x04000B55 RID: 2901
			public byte byte_0;
		}

		// Token: 0x02000194 RID: 404
		[Flags]
		public enum GEnum43
		{
			// Token: 0x04000B57 RID: 2903
			flag_0 = 1,
			// Token: 0x04000B58 RID: 2904
			flag_1 = 2,
			// Token: 0x04000B59 RID: 2905
			flag_2 = 4
		}
	}
}
