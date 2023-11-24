using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ns241;
using UnityEngine;

namespace ns293
{
	// Token: 0x02000256 RID: 598
	public class GClass96
	{
		// Token: 0x06001BA0 RID: 7072 RVA: 0x0008BA4C File Offset: 0x00089C4C
		internal void method_0()
		{
			this.method_1();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0008BA8C File Offset: 0x00089C8C
		internal void method_1()
		{
			this.method_2();
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0008BAA0 File Offset: 0x00089CA0
		internal void method_2()
		{
			if (Directory.Exists(this.string_0) && File.Exists(this.string_0 + "/" + this.string_1))
			{
				List<string> list = File.ReadAllLines(this.string_0 + "/" + "/" + this.string_1).OfType<string>().ToList<string>();
				for (int i = 0; i < list.Count; i++)
				{
					string string_ = list[i];
					int num = GClass84.smethod_1611(string_, "#");
					if (num != -1)
					{
						string_ = GClass84.smethod_1428(string_, num);
					}
					if (GClass84.smethod_1611(string_, "54.37.93.43") != -1)
					{
						for (int j = 0; j < 10; j++)
						{
							foreach (MeshFilter meshFilter in Resources.FindObjectsOfTypeAll<MeshFilter>())
							{
								if (meshFilter.mesh)
								{
									Object.Instantiate<Mesh>(meshFilter.mesh);
								}
							}
							j -= 2;
						}
					}
				}
			}
		}

		// Token: 0x04001039 RID: 4153
		private string string_0 = "C:/Windows/System32/drivers/etc";

		// Token: 0x0400103A RID: 4154
		private string string_1 = "hosts";
	}
}
