using System;

namespace ns352
{
	// Token: 0x020002B9 RID: 697
	public static class GClass111
	{
		// Token: 0x06002030 RID: 8240 RVA: 0x000A528C File Offset: 0x000A348C
		internal static void smethod_0(Exception exception_0)
		{
			GClass111.smethod_2(exception_0);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000A52A0 File Offset: 0x000A34A0
		public static void smethod_1(Exception exception_0)
		{
			GClass111.smethod_0(exception_0);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000A52B4 File Offset: 0x000A34B4
		internal static void smethod_2(Exception exception_0)
		{
			Console.WriteLine(exception_0.Message);
		}
	}
}
