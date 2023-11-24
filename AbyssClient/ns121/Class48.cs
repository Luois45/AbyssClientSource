using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using ns185;
using ns241;
using ns550;

namespace ns121
{
	// Token: 0x020000BE RID: 190
	internal class Class48
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00019178 File Offset: 0x00017378
		private void method_0(TcpClient tcpClient_0)
		{
			string text = GClass84.smethod_979();
			if (text == string.Empty)
			{
				text = "Error";
			}
			string s = string.Concat(new string[]
			{
				"HTTP/1.1 200\nContent-type: text/html\nContent-Length",
				":",
				text.Length.ToString(),
				"\n",
				"\n",
				text
			});
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			tcpClient_0.GetStream().Write(bytes, 0, bytes.Length);
			tcpClient_0.Close();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00019204 File Offset: 0x00017404
		private void method_1(TcpClient tcpClient_0)
		{
			this.method_3(tcpClient_0);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00019218 File Offset: 0x00017418
		private void method_2(TcpClient tcpClient_0, int int_0)
		{
			this.method_4(tcpClient_0, int_0);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00019230 File Offset: 0x00017430
		private void method_3(TcpClient tcpClient_0)
		{
			this.method_0(tcpClient_0);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00019244 File Offset: 0x00017444
		private void method_4(TcpClient tcpClient_0, int int_0)
		{
			this.method_5(tcpClient_0, int_0);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001925C File Offset: 0x0001745C
		internal Class48(TcpClient tcpClient_0)
		{
			string text = string.Empty;
			byte[] array = new byte[1024];
			try
			{
				int count;
				while ((count = tcpClient_0.GetStream().Read(array, 0, array.Length)) > 0)
				{
					text += Encoding.ASCII.GetString(array, 0, count);
					if (text.IndexOf("\r\n\r\n") >= 0 || text.Length > 4096)
					{
						break;
					}
				}
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(string.Concat(new string[]
				{
					"[",
					"Error",
					"]",
					" ",
					ex.Message
				}), GClass70.Enum1.const_0);
				try
				{
					this.method_2(tcpClient_0, 500);
				}
				catch (Exception ex2)
				{
					GClass70.smethod_36(string.Concat(new string[]
					{
						"[",
						"Error",
						"]",
						" ",
						ex2.Message
					}), GClass70.Enum1.const_0);
				}
				return;
			}
			Match match = Regex.Match(text, "^\\w+\\s+([^\\s\\?]+)[^\\s]*\\s+HTTP/.*|");
			if (match == Match.Empty)
			{
				this.method_2(tcpClient_0, 400);
			}
			else
			{
				string text2 = match.Groups[1].Value;
				text2 = Uri.UnescapeDataString(text2);
				GClass70.smethod_38(text2, GClass70.Enum1.const_0);
				GClass84.gclass93_0.method_174(text, text2);
				if (text2 == "/GetInstance();")
				{
					this.method_1(tcpClient_0);
				}
				else if (text2.IndexOf("..") >= 0)
				{
					this.method_2(tcpClient_0, 400);
				}
				else
				{
					if (text2.EndsWith("/"))
					{
						text2 = text2 + "index" + "." + "html";
					}
					string path = "www" + "/" + text2;
					if (!File.Exists(path))
					{
						this.method_2(tcpClient_0, 404);
					}
					else
					{
						string text3 = text2.Substring(text2.LastIndexOf('.'));
						string text4 = string.Empty;
						string text5 = text3;
						string text6 = text5;
						uint num = Class217.smethod_0(text6);
						if (num <= 1384894805U)
						{
							if (num <= 1128223456U)
							{
								if (num != 754654932U)
								{
									if (num != 1128223456U)
									{
										goto IL_34B;
									}
									if (!(text6 == ".png"))
									{
										goto IL_34B;
									}
									goto IL_322;
								}
								else if (!(text6 == ".html"))
								{
									goto IL_34B;
								}
							}
							else if (num != 1293625206U)
							{
								if (num != 1384894805U)
								{
									goto IL_34B;
								}
								if (!(text6 == ".gif"))
								{
									goto IL_34B;
								}
								goto IL_322;
							}
							else
							{
								if (text6 == ".js")
								{
									text4 = "text/javascript";
									goto IL_382;
								}
								goto IL_34B;
							}
						}
						else if (num <= 2641099312U)
						{
							if (num != 1388056268U)
							{
								if (num != 2641099312U)
								{
									goto IL_34B;
								}
								if (!(text6 == ".htm"))
								{
									goto IL_34B;
								}
							}
							else
							{
								if (text6 == ".jpg")
								{
									text4 = "image/jpeg";
									goto IL_382;
								}
								goto IL_34B;
							}
						}
						else if (num != 2702274340U)
						{
							if (num != 4178554255U)
							{
								goto IL_34B;
							}
							if (text6 == ".jpeg")
							{
								goto IL_322;
							}
							goto IL_34B;
						}
						else
						{
							if (!(text6 == ".css"))
							{
								goto IL_34B;
							}
							text4 = "text/stylesheet";
							goto IL_382;
						}
						text4 = "text/html";
						goto IL_382;
						IL_322:
						text4 = "image" + "/" + text3.Substring(1);
						goto IL_382;
						IL_34B:
						if (text3.Length > 1)
						{
							text4 = "application" + "/" + text3.Substring(1);
						}
						else
						{
							text4 = "application/unknown";
						}
						IL_382:
						FileStream fileStream;
						try
						{
							fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
						}
						catch (Exception)
						{
							this.method_2(tcpClient_0, 500);
							return;
						}
						string s = string.Concat(new string[]
						{
							"HTTP/1.1 200 OK",
							"\n",
							"Content-Type",
							": ",
							text4,
							"\n",
							"Content-Length",
							": ",
							fileStream.Length.ToString(),
							"\n",
							"\n"
						});
						byte[] bytes = Encoding.ASCII.GetBytes(s);
						tcpClient_0.GetStream().Write(bytes, 0, bytes.Length);
						while (fileStream.Position < fileStream.Length)
						{
							int count = fileStream.Read(array, 0, array.Length);
							tcpClient_0.GetStream().Write(array, 0, count);
						}
						fileStream.Close();
						tcpClient_0.Close();
					}
				}
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00019700 File Offset: 0x00017900
		private void method_5(TcpClient tcpClient_0, int int_0)
		{
			string str = int_0.ToString();
			string str2 = " ";
			HttpStatusCode httpStatusCode = (HttpStatusCode)int_0;
			string text = str + str2 + httpStatusCode.ToString();
			string text2 = "<html><body><h1>" + text + "</h1></body></html>";
			string s = string.Concat(new string[]
			{
				"HTTP/1.1 ",
				text,
				"\nContent-type: text/html\nContent-Length",
				":",
				text2.Length.ToString(),
				"\n",
				"\n",
				text2
			});
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			tcpClient_0.GetStream().Write(bytes, 0, bytes.Length);
			tcpClient_0.Close();
		}
	}
}
