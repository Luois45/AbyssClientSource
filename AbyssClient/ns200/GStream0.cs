using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace ns200
{
	// Token: 0x02000141 RID: 321
	public class GStream0 : Stream
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		internal void method_0(long long_0)
		{
			this.method_5(long_0);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00013260 File Offset: 0x00011460
		internal void method_1(long long_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		public GStream0(MemoryMappedFile memoryMappedFile_0)
		{
			this.memoryMappedViewAccessor_0 = memoryMappedFile_0.CreateViewAccessor();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		public override void Write(byte[] byte_0, int int_1, int int_2)
		{
			this.method_10(byte_0, int_1, int_2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002E700 File Offset: 0x0002C900
		internal unsafe byte* method_2()
		{
			byte* result = null;
			this.memoryMappedViewAccessor_0.SafeMemoryMappedViewHandle.AcquirePointer(ref result);
			return result;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002E728 File Offset: 0x0002C928
		public override void SetLength(long long_0)
		{
			this.method_0(long_0);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0002E73C File Offset: 0x0002C93C
		internal void method_3(long long_0)
		{
			this.method_1(long_0);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0002E750 File Offset: 0x0002C950
		public override long Position
		{
			get
			{
				return (long)this.int_0;
			}
			set
			{
				this.method_3(value);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00013260 File Offset: 0x00011460
		public override long Seek(long long_0, SeekOrigin seekOrigin_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002E764 File Offset: 0x0002C964
		internal void method_4()
		{
			this.memoryMappedViewAccessor_0.SafeMemoryMappedViewHandle.ReleasePointer();
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002E784 File Offset: 0x0002C984
		internal void method_5(long long_0)
		{
			this.memoryMappedViewAccessor_0.Write(0L, (int)long_0);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0002E7A8 File Offset: 0x0002C9A8
		public override long Length
		{
			get
			{
				return this.Position;
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00013260 File Offset: 0x00011460
		public override int Read(byte[] byte_0, int int_1, int int_2)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
		void method_6(bool bool_0)
		{
			this.method_7(bool_0);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002E7E4 File Offset: 0x0002C9E4
		void method_7(bool bool_0)
		{
			base.Dispose(bool_0);
			if (bool_0)
			{
				this.memoryMappedViewAccessor_0.Dispose();
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002E808 File Offset: 0x0002CA08
		protected virtual void vmethod_0(bool bool_0)
		{
			this.method_6(bool_0);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002E81C File Offset: 0x0002CA1C
		internal void method_8()
		{
			this.method_4();
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002E830 File Offset: 0x0002CA30
		internal void method_9()
		{
			this.method_8();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002E844 File Offset: 0x0002CA44
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002E854 File Offset: 0x0002CA54
		internal void method_10(byte[] byte_0, int int_1, int int_2)
		{
			this.method_11(byte_0, int_1, int_2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002E86C File Offset: 0x0002CA6C
		internal void method_11(byte[] byte_0, int int_1, int int_2)
		{
			if ((long)(int_2 + this.int_0) > this.memoryMappedViewAccessor_0.Capacity - 8L)
			{
				throw new IOException(string.Format("Stream is full (capacity {0}, requires {1}", this.memoryMappedViewAccessor_0.Capacity, int_2 + this.int_0));
			}
			this.memoryMappedViewAccessor_0.WriteArray<byte>((long)(this.int_0 + 8), byte_0, int_1, int_2);
			this.int_0 += int_2;
			Interlocked.MemoryBarrier();
			this.memoryMappedViewAccessor_0.Write(4L, this.int_0);
		}

		// Token: 0x040008B8 RID: 2232
		private readonly MemoryMappedViewAccessor memoryMappedViewAccessor_0;

		// Token: 0x040008B9 RID: 2233
		private int int_0;
	}
}
