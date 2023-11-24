using System;
using ns417;

namespace ns373
{
	// Token: 0x020002DD RID: 733
	internal class Class178
	{
		// Token: 0x060024F5 RID: 9461 RVA: 0x000AD7FC File Offset: 0x000AB9FC
		public static int smethod_0(Type type_0)
		{
			object[] customAttributes = type_0.GetCustomAttributes(typeof(Attribute2), false);
			int num = 0;
			if (0 >= customAttributes.Length)
			{
				throw new Exception("Callback number not found for struct " + ((type_0 != null) ? type_0.ToString() : null));
			}
			return ((Attribute2)customAttributes[num]).Int32_0;
		}
	}
}
