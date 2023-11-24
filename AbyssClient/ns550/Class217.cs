using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns550
{
	// Token: 0x020003A7 RID: 935
	[CompilerGenerated]
	internal sealed class Class217
	{
		// Token: 0x06004A36 RID: 18998 RVA: 0x0011B288 File Offset: 0x00119488
		internal static uint smethod_0(string string_0)
		{
			uint num;
			if (string_0 != null)
			{
				num = 2166136261U;
				for (int i = 0; i < string_0.Length; i++)
				{
					num = ((uint)string_0[i] ^ num) * 16777619U;
				}
			}
			return num;
		}

		// Token: 0x04001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		internal static readonly Class217.Struct38 struct38_0;

		// Token: 0x04001D9D RID: 7581 RVA: 0x00002090 File Offset: 0x00000290
		internal static readonly Class217.Struct37 struct37_0;

		// Token: 0x04001D9E RID: 7582 RVA: 0x000020C0 File Offset: 0x000002C0
		internal static readonly Class217.Struct40 struct40_0;

		// Token: 0x04001D9F RID: 7583 RVA: 0x00002110 File Offset: 0x00000310
		internal static readonly Class217.Struct37 struct37_1;

		// Token: 0x04001DA0 RID: 7584 RVA: 0x00002140 File Offset: 0x00000340
		internal static readonly Class217.Struct37 struct37_2;

		// Token: 0x04001DA1 RID: 7585 RVA: 0x00002170 File Offset: 0x00000370
		internal static readonly Class217.Struct39 struct39_0;

		// Token: 0x04001DA2 RID: 7586 RVA: 0x000021B0 File Offset: 0x000003B0
		internal static readonly Class217.Struct37 struct37_3;

		// Token: 0x04001DA3 RID: 7587 RVA: 0x000021E0 File Offset: 0x000003E0
		internal static readonly Class217.Struct36 struct36_0;

		// Token: 0x020003A8 RID: 936
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 37)]
		private struct Struct36
		{
		}

		// Token: 0x020003A9 RID: 937
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 46)]
		private struct Struct37
		{
		}

		// Token: 0x020003AA RID: 938
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 59)]
		private struct Struct38
		{
		}

		// Token: 0x020003AB RID: 939
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 61)]
		private struct Struct39
		{
		}

		// Token: 0x020003AC RID: 940
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 78)]
		private struct Struct40
		{
		}
	}
}
