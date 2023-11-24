using System;
using System.Runtime.InteropServices;
using System.Text;
using ns269;
using ns54;

namespace ns229
{
	// Token: 0x020001A7 RID: 423
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 372)]
	public class GClass81
	{
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00054E70 File Offset: 0x00053070
		internal void method_0(string string_0)
		{
			this.byte_3 = Encoding.UTF8.GetBytes(string_0 + "\0");
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00054E98 File Offset: 0x00053098
		internal string method_1()
		{
			return Encoding.UTF8.GetString(this.byte_1, 0, Array.IndexOf<byte>(this.byte_1, 0));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00054EC4 File Offset: 0x000530C4
		internal void method_2(string string_0)
		{
			this.byte_1 = Encoding.UTF8.GetBytes(string_0 + "\0");
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00054EEC File Offset: 0x000530EC
		public void method_3(string string_0)
		{
			this.method_10(string_0);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00054F00 File Offset: 0x00053100
		internal void method_4(string string_0)
		{
			this.byte_2 = Encoding.UTF8.GetBytes(string_0 + "\0");
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00054F28 File Offset: 0x00053128
		internal string method_5()
		{
			return Encoding.UTF8.GetString(this.byte_4, 0, Array.IndexOf<byte>(this.byte_4, 0));
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00054F54 File Offset: 0x00053154
		public void method_6(string string_0)
		{
			this.method_17(string_0);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00054F68 File Offset: 0x00053168
		public string method_7()
		{
			return this.method_9();
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00054F7C File Offset: 0x0005317C
		public void method_8(string string_0)
		{
			this.method_14(string_0);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00054F90 File Offset: 0x00053190
		internal string method_9()
		{
			return this.method_5();
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00054FA4 File Offset: 0x000531A4
		internal void method_10(string string_0)
		{
			this.method_2(string_0);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00054FB8 File Offset: 0x000531B8
		internal string method_11()
		{
			return this.method_13();
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00054FCC File Offset: 0x000531CC
		public string method_12()
		{
			return this.method_11();
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00054FE0 File Offset: 0x000531E0
		internal string method_13()
		{
			string result;
			if (this.byte_3[0] == 0)
			{
				result = this.gstruct184_0.method_17();
			}
			else
			{
				result = Encoding.UTF8.GetString(this.byte_3, 0, Array.IndexOf<byte>(this.byte_3, 0));
			}
			return result;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00055028 File Offset: 0x00053228
		internal void method_14(string string_0)
		{
			this.method_4(string_0);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0005503C File Offset: 0x0005323C
		public void method_15(string string_0)
		{
			this.method_20(string_0);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00055050 File Offset: 0x00053250
		public void method_16(string string_0)
		{
			this.method_21(string_0);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00055064 File Offset: 0x00053264
		internal void method_17(string string_0)
		{
			this.method_0(string_0);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00055078 File Offset: 0x00053278
		internal string method_18()
		{
			return this.method_23();
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0005508C File Offset: 0x0005328C
		internal void method_19(string string_0)
		{
			this.byte_4 = Encoding.UTF8.GetBytes(string_0 + "\0");
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000550B4 File Offset: 0x000532B4
		internal void method_20(string string_0)
		{
			this.method_25(string_0);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000550C8 File Offset: 0x000532C8
		internal void method_21(string string_0)
		{
			this.method_19(string_0);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000550DC File Offset: 0x000532DC
		public string method_22()
		{
			return this.method_18();
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000550F0 File Offset: 0x000532F0
		internal string method_23()
		{
			return Encoding.UTF8.GetString(this.byte_2, 0, Array.IndexOf<byte>(this.byte_2, 0));
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0005511C File Offset: 0x0005331C
		internal string method_24()
		{
			return this.method_29();
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00055130 File Offset: 0x00053330
		internal void method_25(string string_0)
		{
			this.byte_0 = Encoding.UTF8.GetBytes(string_0 + "\0");
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00055158 File Offset: 0x00053358
		internal string method_26()
		{
			return this.method_1();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0005516C File Offset: 0x0005336C
		public string method_27()
		{
			return this.method_24();
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00055180 File Offset: 0x00053380
		public string method_28()
		{
			return this.method_26();
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00055194 File Offset: 0x00053394
		internal string method_29()
		{
			return Encoding.UTF8.GetString(this.byte_0, 0, Array.IndexOf<byte>(this.byte_0, 0));
		}

		// Token: 0x04000BBE RID: 3006
		public GStruct184 gstruct184_0;

		// Token: 0x04000BBF RID: 3007
		public int int_0;

		// Token: 0x04000BC0 RID: 3008
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_0;

		// Token: 0x04000BC1 RID: 3009
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_1;

		// Token: 0x04000BC2 RID: 3010
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] byte_0;

		// Token: 0x04000BC3 RID: 3011
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] byte_1;

		// Token: 0x04000BC4 RID: 3012
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] byte_2;

		// Token: 0x04000BC5 RID: 3013
		public uint uint_0;

		// Token: 0x04000BC6 RID: 3014
		public int int_1;

		// Token: 0x04000BC7 RID: 3015
		public int int_2;

		// Token: 0x04000BC8 RID: 3016
		public int int_3;

		// Token: 0x04000BC9 RID: 3017
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_2;

		// Token: 0x04000BCA RID: 3018
		[MarshalAs(UnmanagedType.I1)]
		public bool bool_3;

		// Token: 0x04000BCB RID: 3019
		public uint uint_1;

		// Token: 0x04000BCC RID: 3020
		public int int_4;

		// Token: 0x04000BCD RID: 3021
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] byte_3;

		// Token: 0x04000BCE RID: 3022
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] byte_4;

		// Token: 0x04000BCF RID: 3023
		public GStruct22 gstruct22_0;
	}
}
