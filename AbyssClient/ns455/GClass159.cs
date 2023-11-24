using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using ns185;
using ns241;
using ns425;

namespace ns455
{
	// Token: 0x020002A9 RID: 681
	public class GClass159 : GClass130
	{
		// Token: 0x06001F7D RID: 8061 RVA: 0x000A2E3C File Offset: 0x000A103C
		public override void vmethod_19()
		{
			this.method_16();
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000A2E50 File Offset: 0x000A1050
		internal void method_2()
		{
			this.method_7();
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000A2E64 File Offset: 0x000A1064
		private void method_3(string string_1)
		{
			this.method_12(string_1);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000A2E78 File Offset: 0x000A1078
		internal void method_4()
		{
			this.method_2();
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000A2E8C File Offset: 0x000A108C
		internal void method_5(string string_1)
		{
			this.method_19(string.Concat(new string[]
			{
				"Pattern",
				"/",
				GClass84.string_0,
				"/",
				string_1
			}));
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		public override void vmethod_23()
		{
			this.method_13();
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x000A2EE4 File Offset: 0x000A10E4
		internal void method_6(string string_1)
		{
			this.method_19(string.Concat(new string[]
			{
				"Preset",
				"/",
				GClass84.string_0,
				"/",
				string_1
			}));
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000A2F28 File Offset: 0x000A1128
		internal void method_7()
		{
			try
			{
				string text = "2371845348:39316";
				if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
				{
					text = "http" + "://" + text;
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(string.Concat(new string[]
				{
					text,
					"/",
					"Get",
					"Qr",
					"Code",
					"/",
					GClass84.string_0
				})).GetResponse();
				string text2 = string.Empty;
				try
				{
					if (httpWebResponse.StatusCode == HttpStatusCode.OK)
					{
						StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
						try
						{
							try
							{
								text2 = streamReader.ReadToEnd();
							}
							catch
							{
								GClass70.smethod_36(string.Concat(new string[]
								{
									"Error",
									" ",
									"While",
									" ",
									"Connecting",
									" ",
									"To",
									" ",
									"Lovense",
									": ",
									text2
								}), GClass70.Enum1.const_0);
							}
							goto IL_1C4;
						}
						finally
						{
							streamReader.Close();
						}
					}
					GClass70.smethod_36(string.Concat(new string[]
					{
						"Error",
						" ",
						"While",
						" ",
						"Connecting",
						" ",
						"To",
						"Lovense",
						": ",
						httpWebResponse.StatusCode.ToString(),
						" ",
						new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()
					}), GClass70.Enum1.const_0);
					IL_1C4:;
				}
				catch
				{
					GClass70.smethod_36(string.Concat(new string[]
					{
						"Error",
						" ",
						"While",
						" ",
						"Sending",
						" ",
						"Photon",
						" ",
						"Bots",
						": ",
						text2
					}), GClass70.Enum1.const_0);
				}
				finally
				{
					httpWebResponse.Close();
				}
				if (!string.IsNullOrEmpty(text2))
				{
					GClass70.smethod_38(string.Concat(new string[]
					{
						"Lovense",
						" ",
						"Response",
						": ",
						text2
					}), GClass70.Enum1.const_0);
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"While",
					" ",
					"Sending",
					" ",
					"Photon",
					" ",
					"Bots",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x000A32A4 File Offset: 0x000A14A4
		internal void method_8(string string_1)
		{
			this.method_18(string_1);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000A32B8 File Offset: 0x000A14B8
		internal void method_9()
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].IsCompleted)
				{
					HttpWebResponse httpWebResponse = (HttpWebResponse)this.list_0[i].Result;
					this.list_0.RemoveAt(i);
					i--;
					string text = string.Empty;
					try
					{
						if (httpWebResponse.StatusCode == HttpStatusCode.OK)
						{
							StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
							try
							{
								try
								{
									text = streamReader.ReadToEnd();
								}
								catch
								{
									GClass70.smethod_36(string.Concat(new string[]
									{
										"Error",
										" ",
										"While",
										" ",
										"Connecting",
										" ",
										"To",
										" ",
										"Lovense",
										": ",
										text
									}), GClass70.Enum1.const_0);
								}
								goto IL_17B;
							}
							finally
							{
								streamReader.Close();
							}
						}
						GClass70.smethod_36(string.Concat(new string[]
						{
							"Error",
							" ",
							"While",
							" ",
							"Connecting",
							" ",
							"To",
							"Lovense",
							": ",
							httpWebResponse.StatusCode.ToString(),
							" ",
							new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd()
						}), GClass70.Enum1.const_0);
						IL_17B:;
					}
					catch
					{
						GClass70.smethod_36(string.Concat(new string[]
						{
							"Error",
							" ",
							"While",
							" ",
							"Connecting",
							" ",
							"To",
							"Lovense",
							": ",
							text
						}), GClass70.Enum1.const_0);
					}
					finally
					{
						httpWebResponse.Close();
					}
				}
			}
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000A3528 File Offset: 0x000A1728
		internal void method_10(string string_1)
		{
			this.method_5(string_1);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000A353C File Offset: 0x000A173C
		internal void method_11(string string_1)
		{
			this.method_19(string.Concat(new string[]
			{
				"Function",
				"/",
				GClass84.string_0,
				"/",
				string_1
			}));
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000A3580 File Offset: 0x000A1780
		private void method_12(string string_1)
		{
			try
			{
				string text = "2371845348:39316";
				if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
				{
					text = "http" + "://" + text;
				}
				this.list_0.Add(WebRequest.Create(text + "/" + string_1).GetResponseAsync());
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"Error",
					" ",
					"While",
					" ",
					"Sending",
					" ",
					"Photon",
					" ",
					"Bots",
					": ",
					ex.Message
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000A3670 File Offset: 0x000A1870
		internal void method_13()
		{
			this.method_20();
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000A3684 File Offset: 0x000A1884
		internal void method_14(string string_1)
		{
			this.method_6(string_1);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000A3698 File Offset: 0x000A1898
		internal void method_15(string string_1)
		{
			this.method_14(string_1);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000A3738 File Offset: 0x000A1938
		internal void method_16()
		{
			this.method_9();
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000A374C File Offset: 0x000A194C
		internal void method_17(string string_1)
		{
			this.method_10(string_1);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000A3760 File Offset: 0x000A1960
		internal void method_18(string string_1)
		{
			this.method_11(string_1);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000A3774 File Offset: 0x000A1974
		private void method_19(string string_1)
		{
			this.method_3(string_1);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000A3788 File Offset: 0x000A1988
		internal void method_20()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_4.Add(new Action(this.vmethod_10));
		}

		// Token: 0x04001250 RID: 4688
		private List<Task<WebResponse>> list_0 = new List<Task<WebResponse>>();

		// Token: 0x04001251 RID: 4689
		internal List<string> list_1 = new List<string>
		{
			"Vibrate",
			"Rotate",
			"Pump"
		};

		// Token: 0x04001252 RID: 4690
		internal int int_0 = 20;

		// Token: 0x04001253 RID: 4691
		internal List<string> list_2 = new List<string>
		{
			"pulse",
			"wave",
			"fireworks",
			"earthquake"
		};
	}
}
