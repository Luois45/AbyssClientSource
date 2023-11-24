using System;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using ns185;
using ns200;
using ns238;
using ns276;
using ns349;
using ns414;
using ns70;

namespace ns401
{
	// Token: 0x02000308 RID: 776
	internal class Class184 : IDisposable
	{
		// Token: 0x06004069 RID: 16489 RVA: 0x000F327C File Offset: 0x000F147C
		internal unsafe int method_0(byte[] byte_0, int int_0, int int_1)
		{
			try
			{
				this.gstream0_0.Write(byte_0, int_0, int_1);
			}
			catch (IOException ex)
			{
				GClass70.smethod_36(string.Format("Received more bytes than declared for bundle URL {0} (declared: {1})", this.string_0, Class172.smethod_9(this.intptr_0)), GClass70.Enum1.const_0);
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				this.method_5();
				fixed (byte[] array = byte_0)
				{
					byte* value;
					if (byte_0 != null && array.Length != 0)
					{
						value = &array[0];
					}
					else
					{
						value = null;
					}
					Class96.smethod_5(this.intptr_0, (IntPtr)((void*)value), int_1);
				}
				Class172.smethod_8(this);
			}
			return int_1;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x000F331C File Offset: 0x000F151C
		internal void method_1()
		{
			this.method_4();
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x000F3330 File Offset: 0x000F1530
		private void method_2()
		{
			this.method_6();
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x000F3344 File Offset: 0x000F1544
		internal void method_3()
		{
			this.method_8();
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x000F3358 File Offset: 0x000F1558
		internal void method_4()
		{
			GClass37 gclass = this.gclass37_0;
			if (gclass != null)
			{
				gclass.Dispose();
			}
			GStream0 gstream = this.gstream0_0;
			if (gstream != null)
			{
				gstream.Dispose();
			}
			MemoryMappedFile memoryMappedFile = this.memoryMappedFile_0;
			if (memoryMappedFile != null)
			{
				memoryMappedFile.Dispose();
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x000F3398 File Offset: 0x000F1598
		private void method_5()
		{
			this.method_2();
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x000F33AC File Offset: 0x000F15AC
		private unsafe void method_6()
		{
			int val = 65536;
			*(long*)((void*)(this.intptr_0 + 64)) = 0L;
			byte* ptr = this.gstream0_0.method_2() + 8;
			int i = 0;
			int num = (int)this.gstream0_0.Length;
			while (i < num)
			{
				int num2 = Math.Min(val, num - i);
				int num3 = Class96.smethod_5(this.intptr_0, (IntPtr)((void*)(ptr + i)), num2);
				i += num2;
				if (num3 != num2)
				{
					break;
				}
			}
			this.gstream0_0.method_9();
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x000F3440 File Offset: 0x000F1640
		internal long method_7()
		{
			return this.gstream0_0.Position;
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x000F345C File Offset: 0x000F165C
		internal void method_8()
		{
			this.method_10();
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x000F3470 File Offset: 0x000F1670
		public void Dispose()
		{
			this.method_1();
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000F3484 File Offset: 0x000F1684
		internal bool method_9()
		{
			bool result;
			if (this.memoryMappedFile_0 != null)
			{
				result = true;
			}
			else
			{
				int num = Class172.smethod_9(this.intptr_0);
				if (num <= 0)
				{
					result = false;
				}
				else
				{
					try
					{
						string text = "BundleVerifier-" + Guid.NewGuid().ToString();
						this.memoryMappedFile_0 = MemoryMappedFile.CreateNew(text, (long)(num + 8), MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None, HandleInheritability.None);
						this.gstream0_0 = new GStream0(this.memoryMappedFile_0);
						this.gstream0_0.SetLength((long)num);
						this.gclass37_0 = new GClass37(GClass92.string_0, text, TimeSpan.FromSeconds((double)90f), 8589934592UL, 20, 1000000);
					}
					catch (Exception arg)
					{
						GClass70.smethod_36(string.Format("Error while initializing verifier internals: {0}", arg), GClass70.Enum1.const_0);
						return false;
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x000F356C File Offset: 0x000F176C
		public Class184(IntPtr intptr_1, string string_1)
		{
			this.intptr_0 = intptr_1;
			this.string_0 = string_1;
			GClass125 gclass125_ = GClass92.gclass125_0;
			this.bool_0 = (gclass125_ != null && gclass125_.method_4(string_1));
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x000F35A8 File Offset: 0x000F17A8
		internal unsafe void method_10()
		{
			if (this.memoryMappedFile_0 == null)
			{
				Class96.smethod_8(this.intptr_0);
			}
			else
			{
				Stopwatch.StartNew();
				int? num = this.gclass37_0.method_0(TimeSpan.FromSeconds((double)90f));
				int? num2 = num;
				if (!(num2.GetValueOrDefault() == 0 & num2 != null))
				{
					GClass92.smethod_7(this.string_0);
					GClass92.gclass125_0.method_0(this.string_0);
					*(long*)((void*)(this.intptr_0 + 64)) = 0L;
					string s = "UnityFS\0";
					byte[] bytes = Encoding.UTF8.GetBytes(s);
					byte[] array;
					byte* value;
					if ((array = bytes) != null && array.Length != 0)
					{
						value = &array[0];
					}
					else
					{
						value = null;
					}
					Class96.smethod_5(this.intptr_0, (IntPtr)((void*)value), bytes.Length);
					array = null;
					Class96.smethod_8(this.intptr_0);
				}
				else
				{
					this.method_5();
					Class96.smethod_8(this.intptr_0);
				}
			}
		}

		// Token: 0x040018F3 RID: 6387
		internal readonly IntPtr intptr_0;

		// Token: 0x040018F4 RID: 6388
		private MemoryMappedFile memoryMappedFile_0;

		// Token: 0x040018F5 RID: 6389
		private GStream0 gstream0_0;

		// Token: 0x040018F6 RID: 6390
		private GClass37 gclass37_0;

		// Token: 0x040018F7 RID: 6391
		internal readonly string string_0;

		// Token: 0x040018F8 RID: 6392
		internal readonly bool bool_0;
	}
}
