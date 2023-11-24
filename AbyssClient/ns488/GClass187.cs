using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnhollowerRuntimeLib.XrefScans;

namespace ns488
{
	// Token: 0x0200034D RID: 845
	public static class GClass187
	{
		// Token: 0x0600471B RID: 18203 RVA: 0x0010D49C File Offset: 0x0010B69C
		internal static bool smethod_0(MethodInfo methodInfo_0, string string_0)
		{
			GClass187.Class201 @class = new GClass187.Class201();
			@class.string_0 = string_0;
			try
			{
				return XrefScanner.XrefScan(methodInfo_0).Where(new Func<XrefInstance, bool>(@class.method_0)).Any<XrefInstance>();
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0010D4EC File Offset: 0x0010B6EC
		internal static bool smethod_1(MethodInfo methodInfo_0, string string_0, Type type_0 = null)
		{
			foreach (XrefInstance xrefInstance in XrefScanner.UsedBy(methodInfo_0))
			{
				if (xrefInstance.Type == 1)
				{
					try
					{
						if ((type_0 == null || xrefInstance.TryResolve().DeclaringType == type_0) && xrefInstance.TryResolve().Name.Contains(string_0))
						{
							return true;
						}
					}
					catch
					{
					}
				}
			}
			return false;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0010D590 File Offset: 0x0010B790
		internal static bool smethod_2(MethodInfo methodInfo_0, string string_0, Type type_0 = null)
		{
			foreach (XrefInstance xrefInstance in XrefScanner.XrefScan(methodInfo_0))
			{
				if (xrefInstance.Type == 1)
				{
					try
					{
						if ((type_0 == null || xrefInstance.TryResolve().DeclaringType == type_0) && xrefInstance.TryResolve().Name.Contains(string_0))
						{
							return true;
						}
					}
					catch
					{
					}
				}
			}
			return false;
		}

		// Token: 0x0200034E RID: 846
		[CompilerGenerated]
		private sealed class Class201
		{
			// Token: 0x0600471F RID: 18207 RVA: 0x0010D634 File Offset: 0x0010B834
			internal bool method_0(XrefInstance xrefInstance_0)
			{
				return xrefInstance_0.Type == null && xrefInstance_0.ReadAsObject().ToString().Contains(this.string_0);
			}

			// Token: 0x04001B80 RID: 7040
			public string string_0;
		}
	}
}
