using System;
using MelonLoader.TinyJSON;

namespace ns524
{
	// Token: 0x0200038B RID: 907
	internal class Class215
	{
		// Token: 0x060049EB RID: 18923 RVA: 0x001198A8 File Offset: 0x00117AA8
		internal static string smethod_0(Variant variant_0)
		{
			return Class215.smethod_3(variant_0);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x001198BC File Offset: 0x00117ABC
		internal static string smethod_1(Variant variant_0)
		{
			return Class215.smethod_0(variant_0);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x001198D0 File Offset: 0x00117AD0
		internal static Variant smethod_2(string string_0)
		{
			return Decoder.Decode(string_0);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x001198E8 File Offset: 0x00117AE8
		internal static string smethod_3(Variant variant_0)
		{
			return Encoder.Encode(variant_0);
		}
	}
}
