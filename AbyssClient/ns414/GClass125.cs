using System;
using System.Collections.Concurrent;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ns185;
using ns356;
using ns38;

namespace ns414
{
	// Token: 0x0200031A RID: 794
	[Attribute0(1)]
	[Attribute1(0)]
	public class GClass125 : IDisposable
	{
		// Token: 0x060040E1 RID: 16609 RVA: 0x000F6860 File Offset: 0x000F4A60
		public void method_0(string string_0)
		{
			this.method_1(string_0);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x000F6874 File Offset: 0x000F4A74
		internal void method_1(string string_0)
		{
			this.method_8(string_0);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000F6888 File Offset: 0x000F4A88
		internal void method_2()
		{
			FileStream fileStream = this.fileStream_0;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x000F68A8 File Offset: 0x000F4AA8
		internal void method_3()
		{
			this.method_2();
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x000F68BC File Offset: 0x000F4ABC
		public void Dispose()
		{
			this.method_3();
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x000F68D0 File Offset: 0x000F4AD0
		public bool method_4(string string_0)
		{
			return this.concurrentDictionary_0.ContainsKey(GClass125.Struct32.smethod_1(string_0));
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x000F68F0 File Offset: 0x000F4AF0
		[Attribute0(2)]
		public GClass125(string string_0)
		{
			if (string_0 != null)
			{
				this.fileStream_0 = new FileStream(string_0, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				byte[] array = new byte[32];
				long num = this.fileStream_0.Length / 32L;
				int num2 = 0;
				while ((long)num2 < num)
				{
					int num3 = this.fileStream_0.Read(array, 0, array.Length);
					if (num3 != array.Length)
					{
						GClass70.smethod_36(string.Format("Failure to read {0} bytes from cached bad URL file", array.Length), GClass70.Enum1.const_0);
						this.fileStream_0.Position = 0L;
						break;
					}
					this.concurrentDictionary_0[GClass125.Struct32.smethod_4(array, 0)] = true;
					num2++;
				}
			}
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x000F69B4 File Offset: 0x000F4BB4
		internal void method_5()
		{
			this.concurrentDictionary_0.Clear();
			if (this.fileStream_0 != null)
			{
				lock (this)
				{
					this.fileStream_0.Position = 0L;
					this.fileStream_0.SetLength(0L);
				}
			}
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x000F6A28 File Offset: 0x000F4C28
		internal void method_6()
		{
			this.method_5();
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x000F6A3C File Offset: 0x000F4C3C
		public void method_7()
		{
			this.method_6();
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x000F6A50 File Offset: 0x000F4C50
		internal void method_8(string string_0)
		{
			GClass125.Struct32 key = GClass125.Struct32.smethod_1(string_0);
			if (this.concurrentDictionary_0.TryAdd(key, true) && this.fileStream_0 != null)
			{
				if (GClass125.byte_0 == null)
				{
					GClass125.byte_0 = new byte[32];
				}
				key.method_0(GClass125.byte_0);
				lock (this)
				{
					this.fileStream_0.Write(GClass125.byte_0, 0, GClass125.byte_0.Length);
					this.fileStream_0.Flush(true);
				}
			}
		}

		// Token: 0x04001936 RID: 6454
		private readonly ConcurrentDictionary<GClass125.Struct32, bool> concurrentDictionary_0 = new ConcurrentDictionary<GClass125.Struct32, bool>();

		// Token: 0x04001937 RID: 6455
		[Attribute1(2)]
		private readonly FileStream fileStream_0;

		// Token: 0x04001938 RID: 6456
		private const int int_0 = 32;

		// Token: 0x04001939 RID: 6457
		[Attribute1(2)]
		[ThreadStatic]
		private static byte[] byte_0;

		// Token: 0x0200031B RID: 795
		[Attribute1(0)]
		private readonly struct Struct32 : IEquatable<GClass125.Struct32>
		{
			// Token: 0x060040EC RID: 16620 RVA: 0x000F6AF0 File Offset: 0x000F4CF0
			public static bool smethod_0(GClass125.Struct32 struct32_0, GClass125.Struct32 struct32_1)
			{
				return !struct32_0.Equals(struct32_1);
			}

			// Token: 0x060040ED RID: 16621 RVA: 0x000F6B08 File Offset: 0x000F4D08
			public static GClass125.Struct32 smethod_1(string string_0)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_0);
				return GClass125.Struct32.smethod_3(bytes, 0, bytes.Length);
			}

			// Token: 0x060040EE RID: 16622 RVA: 0x000F6B30 File Offset: 0x000F4D30
			public override bool Equals(object object_0)
			{
				bool result;
				if (object_0 is GClass125.Struct32)
				{
					GClass125.Struct32 struct32_ = (GClass125.Struct32)object_0;
					result = this.Equals(struct32_);
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x060040EF RID: 16623 RVA: 0x000F6B58 File Offset: 0x000F4D58
			public Struct32(long long_4, long long_5, long long_6, long long_7)
			{
				this.long_0 = long_4;
				this.long_1 = long_5;
				this.long_2 = long_6;
				this.long_3 = long_7;
			}

			// Token: 0x060040F0 RID: 16624 RVA: 0x000F6B84 File Offset: 0x000F4D84
			public static bool smethod_2(GClass125.Struct32 struct32_0, GClass125.Struct32 struct32_1)
			{
				return struct32_0.Equals(struct32_1);
			}

			// Token: 0x060040F1 RID: 16625 RVA: 0x000F6B9C File Offset: 0x000F4D9C
			public unsafe void method_0(byte[] byte_0)
			{
				if (byte_0.Length < 32)
				{
					throw new ArgumentException(string.Format("Buffer too small ({0}, need {1})", byte_0.Length, 32));
				}
				fixed (byte[] array = byte_0)
				{
					byte* ptr;
					if (byte_0 != null && array.Length != 0)
					{
						ptr = &array[0];
					}
					else
					{
						ptr = null;
					}
					*(GClass125.Struct32*)ptr = this;
				}
			}

			// Token: 0x060040F2 RID: 16626 RVA: 0x000F6BF8 File Offset: 0x000F4DF8
			public static GClass125.Struct32 smethod_3(byte[] byte_0, int int_0, int int_1)
			{
				SHA256 sha = SHA256.Create();
				byte[] byte_ = sha.ComputeHash(byte_0, int_0, int_1);
				return GClass125.Struct32.smethod_4(byte_, 0);
			}

			// Token: 0x060040F3 RID: 16627 RVA: 0x000F6C20 File Offset: 0x000F4E20
			public override int GetHashCode()
			{
				int num = this.long_0.GetHashCode();
				num = (num * 397 ^ this.long_1.GetHashCode());
				num = (num * 397 ^ this.long_2.GetHashCode());
				return num * 397 ^ this.long_3.GetHashCode();
			}

			// Token: 0x060040F4 RID: 16628 RVA: 0x000F6C84 File Offset: 0x000F4E84
			public bool Equals(GClass125.Struct32 struct32_0)
			{
				return this.long_0 == struct32_0.long_0 && this.long_1 == struct32_0.long_1 && this.long_2 == struct32_0.long_2 && this.long_3 == struct32_0.long_3;
			}

			// Token: 0x060040F5 RID: 16629 RVA: 0x000F6CCC File Offset: 0x000F4ECC
			public static GClass125.Struct32 smethod_4(byte[] byte_0, int int_0 = 0)
			{
				if (int_0 + 32 > byte_0.Length)
				{
					throw new IndexOutOfRangeException(string.Format("Out of range: {0} available, offset={1}", byte_0.Length, int_0));
				}
				return new GClass125.Struct32(BitConverter.ToInt64(byte_0, int_0), BitConverter.ToInt64(byte_0, int_0 + 8), BitConverter.ToInt64(byte_0, int_0 + 16), BitConverter.ToInt64(byte_0, int_0 + 24));
			}

			// Token: 0x0400193A RID: 6458
			public readonly long long_0;

			// Token: 0x0400193B RID: 6459
			public readonly long long_1;

			// Token: 0x0400193C RID: 6460
			public readonly long long_2;

			// Token: 0x0400193D RID: 6461
			public readonly long long_3;
		}
	}
}
