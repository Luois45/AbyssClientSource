using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns417
{
	// Token: 0x02000326 RID: 806
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	internal class Attribute2 : Attribute
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x000F7F64 File Offset: 0x000F6164
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x000F7F20 File Offset: 0x000F6120
		public int Int32_0
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				this.method_0(value);
			}
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x000F7F34 File Offset: 0x000F6134
		public Attribute2(int int_1)
		{
			this.Int32_0 = int_1;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x000F7F50 File Offset: 0x000F6150
		internal void method_0(int int_1)
		{
			this.method_1(int_1);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000F7F78 File Offset: 0x000F6178
		internal void method_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x04001995 RID: 6549
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int int_0;
	}
}
