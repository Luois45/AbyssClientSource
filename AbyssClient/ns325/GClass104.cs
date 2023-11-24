using System;
using ns167;
using ns299;

namespace ns325
{
	// Token: 0x02000285 RID: 645
	public sealed class GClass104 : IDisposable
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x00093A20 File Offset: 0x00091C20
		internal void method_0(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			this.gclass98_0.method_4(nullable_0, nullable_1, bool_0, bool_1, bool_2);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00093A40 File Offset: 0x00091C40
		internal void method_1()
		{
			this.method_3();
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00093A54 File Offset: 0x00091C54
		public int? method_2(TimeSpan timeSpan_0)
		{
			return this.gclass65_0.method_3(timeSpan_0);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00093A70 File Offset: 0x00091C70
		internal void method_3()
		{
			this.gclass65_0.method_10();
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00093A88 File Offset: 0x00091C88
		public void method_4()
		{
			this.method_1();
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00093A9C File Offset: 0x00091C9C
		public void method_5(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			this.method_6(nullable_0, nullable_1, bool_0, bool_1, bool_2);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00093ABC File Offset: 0x00091CBC
		internal void method_6(TimeSpan? nullable_0, ulong? nullable_1, bool bool_0, bool bool_1, bool bool_2)
		{
			this.method_0(nullable_0, nullable_1, bool_0, bool_1, bool_2);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00093ADC File Offset: 0x00091CDC
		internal void method_7()
		{
			this.method_8();
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00093AF0 File Offset: 0x00091CF0
		public GClass104(string string_0, string string_1)
		{
			this.gclass98_0 = new GClass98();
			try
			{
				string string_2 = string.Concat(new string[]
				{
					"\"",
					string_0.Replace("\"", string.Empty),
					"\"",
					" ",
					string_1
				});
				this.gclass65_0 = new GClass65(string_2, this.gclass98_0);
			}
			catch
			{
				this.gclass98_0.Dispose();
				throw;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00093B7C File Offset: 0x00091D7C
		public void Dispose()
		{
			this.method_7();
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00093B90 File Offset: 0x00091D90
		internal void method_8()
		{
			this.gclass98_0.Dispose();
			this.gclass65_0.Dispose();
		}

		// Token: 0x040011A8 RID: 4520
		private readonly GClass98 gclass98_0;

		// Token: 0x040011A9 RID: 4521
		private readonly GClass65 gclass65_0;
	}
}
