using System;
using System.Diagnostics;
using System.Security.Cryptography;
using ns425;

namespace ns446
{
	// Token: 0x020001A4 RID: 420
	public class GClass150 : GClass130
	{
		// Token: 0x06000FC4 RID: 4036 RVA: 0x00054660 File Offset: 0x00052860
		internal long method_2()
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = this.int_0; i < this.int_1; i++)
			{
				Convert.ToBase64String(this.sha256_0.ComputeHash(BitConverter.GetBytes(i)));
				Convert.ToBase64String(this.md5_0.ComputeHash(BitConverter.GetBytes(i)));
			}
			stopwatch.Stop();
			return (long)this.int_2 / stopwatch.ElapsedMilliseconds;
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000546D0 File Offset: 0x000528D0
		internal long method_3()
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = this.int_0; i < this.int_1; i++)
			{
				Convert.ToBase64String(this.sha256_0.ComputeHash(BitConverter.GetBytes(i)));
			}
			stopwatch.Stop();
			return (long)this.int_2 / stopwatch.ElapsedMilliseconds;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00054770 File Offset: 0x00052970
		internal long method_4()
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = this.int_0; i < this.int_1; i++)
			{
				Convert.ToBase64String(this.md5_0.ComputeHash(BitConverter.GetBytes(i)));
			}
			stopwatch.Stop();
			return (long)this.int_2 / stopwatch.ElapsedMilliseconds;
		}

		// Token: 0x04000BB5 RID: 2997
		private SHA256 sha256_0 = SHA256.Create();

		// Token: 0x04000BB6 RID: 2998
		private MD5 md5_0 = MD5.Create();

		// Token: 0x04000BB7 RID: 2999
		private int int_0 = 0;

		// Token: 0x04000BB8 RID: 3000
		private int int_1 = 1000000;

		// Token: 0x04000BB9 RID: 3001
		private int int_2 = 100000000;
	}
}
