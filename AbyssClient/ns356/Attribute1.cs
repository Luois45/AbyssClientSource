using System;
using System.Runtime.CompilerServices;
using ns521;

namespace ns356
{
	// Token: 0x020002BD RID: 701
	[CompilerGenerated]
	[Attribute3]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class Attribute1 : Attribute
	{
		// Token: 0x06002054 RID: 8276 RVA: 0x000A57E8 File Offset: 0x000A39E8
		public Attribute1(byte byte_1)
		{
			this.byte_0 = new byte[]
			{
				byte_1
			};
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x000A580C File Offset: 0x000A3A0C
		public Attribute1(byte[] byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x0400129C RID: 4764
		public readonly byte[] byte_0;
	}
}
