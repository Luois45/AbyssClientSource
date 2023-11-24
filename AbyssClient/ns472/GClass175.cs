using System;
using ns241;
using ns449;
using ns452;
using ns466;
using ns468;
using ns470;
using UnityEngine;

namespace ns472
{
	// Token: 0x0200029C RID: 668
	public class GClass175 : GClass169
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x000A0518 File Offset: 0x0009E718
		internal void method_8(int int_0)
		{
			this.method_9(int_0);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00021B80 File Offset: 0x0001FD80
		internal void method_9(int int_0)
		{
			base.vmethod_8(int_0);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000A05A8 File Offset: 0x0009E7A8
		public override void vmethod_9()
		{
			this.method_29();
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000A05BC File Offset: 0x0009E7BC
		public override void vmethod_15()
		{
			this.method_41();
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00021C84 File Offset: 0x0001FE84
		internal void method_10()
		{
			base.vmethod_31();
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000A05D0 File Offset: 0x0009E7D0
		internal void method_11()
		{
			this.method_31();
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000A05E4 File Offset: 0x0009E7E4
		public override void vmethod_10()
		{
			this.method_40();
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		public override void vmethod_29()
		{
			this.method_16();
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000A060C File Offset: 0x0009E80C
		public override void vmethod_22()
		{
			this.method_22();
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000A0620 File Offset: 0x0009E820
		internal void method_12()
		{
			if (!GClass173.smethod_1(this.gclass173_0, null) && this.gclass173_0.gclass176_0.Single_0 < this.gclass173_0.float_3 && this.gclass173_0.float_3 - this.gclass173_0.gclass176_0.Single_0 <= this.gclass173_0.float_4 && this.gclass173_0.float_3 - this.gclass173_0.gclass176_0.Single_0 > 0f)
			{
				float num = (this.gclass173_0.gclass176_0.Single_0 - (this.gclass173_0.float_3 - this.gclass173_0.float_4)) / this.gclass173_0.float_4 * 2f;
				if ((double)num > 0.5)
				{
					num = 0.5f - GClass84.smethod_359(num - 1.5f, 0f);
				}
				this.gclass156_0.method_2(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				this.gclass156_0.method_61(this.float_6, this.float_7);
				this.gclass156_0.method_227(GClass153.GClass87.texture2D_1, this.gclass156_0.float_4, this.gclass156_0.float_5 * num, 0f, 0f, (float)GClass153.GClass87.texture2D_1.width, (float)GClass153.GClass87.texture2D_1.height, GClass156.Enum10.const_1);
				this.gclass156_0.method_61(this.float_6, this.float_7 + this.gclass156_0.float_5 * (1f - num));
				this.gclass156_0.method_227(GClass153.GClass87.texture2D_1, this.gclass156_0.float_4, this.gclass156_0.float_5 * num, 0f, 0f, (float)GClass153.GClass87.texture2D_1.width, (float)GClass153.GClass87.texture2D_1.height, GClass156.Enum10.const_1);
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000A0808 File Offset: 0x0009EA08
		internal void method_13(int int_0)
		{
			this.method_38(int_0);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x000A081C File Offset: 0x0009EA1C
		public override void vmethod_24()
		{
			this.method_34();
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000A0830 File Offset: 0x0009EA30
		internal void method_14()
		{
			this.method_32();
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00021DA0 File Offset: 0x0001FFA0
		internal void method_15()
		{
			base.vmethod_24();
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000A0844 File Offset: 0x0009EA44
		internal void method_16()
		{
			this.method_27();
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00021B94 File Offset: 0x0001FD94
		internal void method_17()
		{
			base.vmethod_22();
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000A0858 File Offset: 0x0009EA58
		internal void method_18()
		{
			base.vmethod_19();
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			this.float_4 = this.gclass156_0.float_4 / 640f;
			this.float_5 = this.gclass156_0.float_5 / 480f;
			if (GClass173.smethod_0(this.gclass173_0, null))
			{
				string string_;
				Texture texture;
				if (this.gclass173_0.bool_3)
				{
					if (!this.gclass173_0.bool_0)
					{
						this.method_23();
						return;
					}
					string_ = "Eyes Status: ";
					this.gclass156_0.method_134(string_, ref num, ref num3);
					this.gclass156_0.method_61(this.float_6, this.gclass156_0.float_5 / 4f + this.float_7);
					this.gclass156_0.method_2(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					this.gclass156_0.method_61(num + this.float_6, this.gclass156_0.float_5 / 4f + this.float_7);
					this.gclass156_0.color_0.b = GClass84.smethod_415(this.gclass173_0.float_2 * 2f - 1f, 0f, 1f);
					this.gclass156_0.color_0.g = GClass84.smethod_415(this.gclass173_0.float_2 * 4f - 1f, 0f, 1f);
					texture = GClass153.GClass87.texture2D_0;
					this.gclass156_0.method_227(texture, this.gclass156_0.float_4 / 6f * this.gclass173_0.float_2, num3, 0f, 0f, (float)texture.width, (float)texture.height, GClass156.Enum10.const_1);
				}
				if (this.gclass173_0.bool_6)
				{
					float float_ = this.gclass156_0.float_0;
					float num5 = this.gclass156_0.float_1;
					this.gclass156_0.float_0 = 1.25f;
					this.gclass156_0.float_1 = 1.25f;
					float num6 = 0f;
					float num7 = this.gclass173_0.float_7 / this.gclass173_0.float_10;
					float num8 = this.gclass173_0.float_5 / this.gclass173_0.float_10;
					this.gclass156_0.method_134(string.Concat(new string[]
					{
						"Lungs Condition: ",
						string.Format("{0:0.00}", 100),
						"%, Oxygen: ",
						string.Format("{0:0.00}", 100),
						"%"
					}), ref num, ref num3);
					num4 += num3;
					string_ = "Lungs Condition: ";
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					num6 += num2;
					this.gclass156_0.method_2(0, byte.MaxValue, 0, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = string.Format("{0:0.00}", 100);
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					string_ = string.Format("{0:0.00}", num7 * 100f);
					num6 += num2;
					this.gclass156_0.method_2(0, byte.MaxValue, 0, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = "%";
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					num6 += num2;
					this.gclass156_0.method_2(0, byte.MaxValue, 0, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = ", ";
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					num6 += num2;
					this.gclass156_0.method_2(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = "Oxygen: ";
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					num6 += num2;
					this.gclass156_0.method_2(100, 150, 200, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = string.Format("{0:0.00}", 100);
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					string_ = string.Format("{0:0.00}", num8 * 100f);
					num6 += num2;
					this.gclass156_0.method_2(100, 150, 200, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					string_ = "%";
					this.gclass156_0.method_61(this.gclass156_0.float_4 / 2f - num / 2f + num6 + this.float_6, num4 - num3 / 2f + this.float_7);
					this.gclass156_0.method_134(string_, ref num2, ref num3);
					num6 += num2;
					this.gclass156_0.method_2(100, 150, 200, this.byte_0);
					this.gclass156_0.method_146(string_, false);
					this.gclass156_0.float_0 = float_;
					this.gclass156_0.float_1 = num5;
				}
				texture = this.gstruct218_0.texture_0;
				Color color_ = this.gclass156_0.color_0;
				this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_0.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_0.float_2 + this.float_7);
				this.gclass156_0.color_0 = this.gstruct218_0.color_0[0];
				this.gclass156_0.method_107(texture, (float)texture.width * this.gstruct218_0.float_0 * this.float_3 * this.float_4 * this.float_1, (float)texture.height * this.gstruct218_0.float_0 * this.float_3 * this.float_5 * this.float_1, GClass156.Enum10.const_2);
				this.gclass156_0.color_0 = color_;
				this.gclass156_0.float_0 = this.gclass156_0.float_4 / 1024f;
				this.gclass156_0.float_1 = this.gclass156_0.float_0;
				texture = this.gstruct218_1.texture_0;
				string_ = this.gclass173_0.int_2.ToString();
				if (texture != null)
				{
					this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_1.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_1.float_2 + this.float_7);
					color_ = this.gclass156_0.color_0;
					this.gclass156_0.color_0 = this.gstruct218_1.color_0[0];
					this.gclass156_0.method_227(texture, (float)(texture.height / (texture.height / 64)) * this.gstruct218_1.float_0 * this.float_3 * this.float_5 * this.float_1, (float)(texture.height / (texture.height / 64)) * this.gstruct218_1.float_0 * this.float_3 * this.float_5 * this.float_1, 0f, 0f, (float)texture.width, (float)texture.height, GClass156.Enum10.const_1);
					this.gclass156_0.color_0 = color_;
				}
				this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct219_0.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct219_0.float_2 + this.float_7);
				this.gclass156_0.color_0 = this.gstruct219_0.color_0[0];
				this.gclass156_0.method_146(string_, false);
				this.gclass156_0.float_0 = 1f;
				this.gclass156_0.float_1 = 1f;
				texture = this.gstruct218_2.texture_0;
				color_ = this.gclass156_0.color_0;
				this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_2.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_2.float_2 + this.float_7);
				this.gclass156_0.color_0 = this.gstruct218_2.color_0[0];
				this.gclass156_0.method_107(texture, (float)texture.width * this.gstruct218_2.float_0 * this.float_3 * this.float_4 * this.float_1, (float)texture.height * this.gstruct218_2.float_0 * this.float_3 * this.float_5 * this.float_1, GClass156.Enum10.const_2);
				this.gclass156_0.color_0 = color_;
				this.gclass156_0.float_0 = this.gclass156_0.float_4 / 1024f;
				this.gclass156_0.float_1 = this.gclass156_0.float_0;
				texture = this.gstruct218_3.texture_0;
				string_ = ((int)this.gclass173_0.float_1).ToString();
				if (texture != null)
				{
					this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_3.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_3.float_2 + this.float_7);
					color_ = this.gclass156_0.color_0;
					this.gclass156_0.color_0 = this.gstruct218_3.color_0[0];
					this.gclass156_0.method_227(texture, (float)(texture.height / (texture.height / 64)) * this.gstruct218_3.float_0 * this.float_3 * this.float_5 * this.float_1, (float)(texture.height / (texture.height / 64)) * this.gstruct218_3.float_0 * this.float_3 * this.float_5 * this.float_1, 0f, 0f, (float)texture.width, (float)texture.height, GClass156.Enum10.const_1);
					this.gclass156_0.color_0 = color_;
				}
				this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct219_1.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct219_1.float_2 + this.float_7);
				this.gclass156_0.color_0 = this.gstruct219_1.color_0[0];
				this.gclass156_0.method_146(string_, false);
				this.gclass156_0.float_0 = 1f;
				this.gclass156_0.float_1 = 1f;
				if (this.gclass173_0.bool_11)
				{
					texture = this.gstruct218_4.texture_0;
					color_ = this.gclass156_0.color_0;
					this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_4.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_4.float_2 + this.float_7);
					this.gclass156_0.color_0 = this.gstruct218_4.color_0[0];
					this.gclass156_0.method_107(texture, (float)texture.width * this.gstruct218_4.float_0 * 1.25f * this.float_3 * this.float_4 * this.float_1, (float)texture.height * this.gstruct218_4.float_0 * this.float_3 * this.float_5 * this.float_1, GClass156.Enum10.const_2);
					this.gclass156_0.color_0 = color_;
					this.gclass156_0.float_0 = this.gclass156_0.float_4 / 1024f;
					this.gclass156_0.float_1 = this.gclass156_0.float_0;
					texture = this.gclass173_0.list_1[this.gclass173_0.int_4];
					string_ = string.Format("{0:0.00}", this.gclass173_0.float_20);
					if (texture != null)
					{
						this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct218_5.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct218_5.float_2 + this.float_7);
						color_ = this.gclass156_0.color_0;
						this.gclass156_0.color_0 = this.gstruct218_5.color_0[0];
						this.gclass156_0.method_227(texture, (float)(texture.height / (texture.height / 64)) * this.gstruct218_5.float_0 * this.float_3 * this.float_5 * this.float_1, (float)(texture.height / (texture.height / 64)) * this.gstruct218_5.float_0 * this.float_3 * this.float_5 * this.float_1, 0f, 0f, (float)texture.width, (float)texture.height, GClass156.Enum10.const_1);
						this.gclass156_0.color_0 = color_;
					}
					this.gclass156_0.method_61(this.gclass156_0.float_4 * this.gstruct219_2.float_1 + this.float_6, this.gclass156_0.float_5 * this.gstruct219_2.float_2 + this.float_7);
					this.gclass156_0.color_0 = this.gstruct219_2.color_0[0];
					this.gclass156_0.method_146(string_, false);
					this.gclass156_0.float_0 = 1f;
					this.gclass156_0.float_1 = 1f;
				}
				Vector3 vector = default(Vector3);
				Quaternion quaternion_ = default(Quaternion);
				this.gclass156_0.method_159(ref vector, ref quaternion_);
				color_ = this.gclass156_0.color_0;
				this.gclass156_0.method_2(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				this.gclass156_0.method_21(0, 0, (int)(this.gclass156_0.float_5 / 4f), (int)(this.gclass156_0.float_5 / 4f), null, vector - GClass84.smethod_155(quaternion_) * 2f, quaternion_, 0, false);
				this.gclass156_0.color_0 = color_;
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000A18B4 File Offset: 0x0009FAB4
		public override void vmethod_23()
		{
			this.method_24();
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		internal void method_19()
		{
			this.method_18();
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000A18DC File Offset: 0x0009FADC
		internal void method_20()
		{
			this.method_25();
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		internal void method_21()
		{
			base.vmethod_10();
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000A18F0 File Offset: 0x0009FAF0
		public override void vmethod_27(int int_0)
		{
			this.method_13(int_0);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000A1904 File Offset: 0x0009FB04
		internal void method_22()
		{
			this.method_17();
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000A1918 File Offset: 0x0009FB18
		public override void vmethod_11()
		{
			this.method_33();
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000A192C File Offset: 0x0009FB2C
		internal void method_23()
		{
			this.method_28();
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000A1940 File Offset: 0x0009FB40
		public override void vmethod_25()
		{
			this.method_20();
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000A1954 File Offset: 0x0009FB54
		internal void method_24()
		{
			this.method_45();
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00021E7C File Offset: 0x0002007C
		internal void method_25()
		{
			base.vmethod_25();
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00021E40 File Offset: 0x00020040
		internal void method_26()
		{
			base.vmethod_9();
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000A1968 File Offset: 0x0009FB68
		internal void method_27()
		{
			base.vmethod_29();
			GClass175.GStruct218 gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = GClass153.GClass87.texture2D_5;
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 128,
				int_3 = 64
			};
			gstruct.float_0 = 0.35f;
			gstruct.float_1 = 0.015f;
			gstruct.float_2 = 0.935f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array = new Color[2];
			int num = 0;
			Color color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 255f;
			color.a = 0.5019608f;
			array[num] = color;
			int num2 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 0.5019608f;
			array[num2] = color;
			gstruct.color_0 = array;
			this.gstruct218_0 = gstruct;
			gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = GClass153.GClass87.gstruct177_0.texture2D_0;
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 64,
				int_3 = 64
			};
			gstruct.float_0 = 0.16f;
			gstruct.float_1 = 0.021f;
			gstruct.float_2 = 0.947f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array2 = new Color[2];
			int num3 = 0;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array2[num3] = color;
			int num4 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array2[num4] = color;
			gstruct.color_0 = array2;
			this.gstruct218_1 = gstruct;
			GClass175.GStruct219 gstruct2 = default(GClass175.GStruct219);
			gstruct2.genum80_0 = GClass169.GEnum80.const_5;
			gstruct2.float_0 = 0.3f;
			gstruct2.float_1 = 0.0425f;
			gstruct2.float_2 = 0.95f;
			Color[] array3 = new Color[2];
			int num5 = 0;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array3[num5] = color;
			int num6 = 1;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array3[num6] = color;
			gstruct2.color_0 = array3;
			this.gstruct219_0 = gstruct2;
			gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = GClass153.GClass87.texture2D_5;
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 128,
				int_3 = 64
			};
			gstruct.float_0 = 0.35f;
			gstruct.float_1 = 0.085f;
			gstruct.float_2 = 0.935f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array4 = new Color[2];
			int num7 = 0;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 0.5019608f;
			array4[num7] = color;
			int num8 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 0.5019608f;
			array4[num8] = color;
			gstruct.color_0 = array4;
			this.gstruct218_2 = gstruct;
			gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = GClass153.GClass87.gstruct177_0.texture2D_1;
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 64,
				int_3 = 64
			};
			gstruct.float_0 = 0.2f;
			gstruct.float_1 = 0.09f;
			gstruct.float_2 = 0.945f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array5 = new Color[2];
			int num9 = 0;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array5[num9] = color;
			int num10 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array5[num10] = color;
			gstruct.color_0 = array5;
			this.gstruct218_3 = gstruct;
			gstruct2 = default(GClass175.GStruct219);
			gstruct2.genum80_0 = GClass169.GEnum80.const_5;
			gstruct2.float_0 = 0.3f;
			gstruct2.float_1 = 0.115f;
			gstruct2.float_2 = 0.95f;
			Color[] array6 = new Color[2];
			int num11 = 0;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array6[num11] = color;
			int num12 = 1;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array6[num12] = color;
			gstruct2.color_0 = array6;
			this.gstruct219_1 = gstruct2;
			gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = GClass153.GClass87.texture2D_5;
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 128,
				int_3 = 64
			};
			gstruct.float_0 = 0.35f;
			gstruct.float_1 = 0.155f;
			gstruct.float_2 = 0.935f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array7 = new Color[2];
			int num13 = 0;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 0.5019608f;
			array7[num13] = color;
			int num14 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 0.5019608f;
			array7[num14] = color;
			gstruct.color_0 = array7;
			this.gstruct218_4 = gstruct;
			gstruct = default(GClass175.GStruct218);
			gstruct.texture_0 = this.gclass173_0.list_1[0];
			gstruct.genum80_0 = GClass169.GEnum80.const_5;
			gstruct.gstruct259_0 = new GClass169.GStruct259
			{
				int_2 = 256,
				int_3 = 256
			};
			gstruct.float_0 = 0.28f;
			gstruct.float_1 = 0.16f;
			gstruct.float_2 = 0.941f;
			gstruct.genum64_0 = GClass175.GEnum64.const_4;
			gstruct.float_3 = 1f;
			Color[] array8 = new Color[2];
			int num15 = 0;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array8[num15] = color;
			int num16 = 1;
			color = default(Color);
			color.b = 1f;
			color.g = 1f;
			color.r = 1f;
			color.a = 1f;
			array8[num16] = color;
			gstruct.color_0 = array8;
			this.gstruct218_5 = gstruct;
			gstruct2 = default(GClass175.GStruct219);
			gstruct2.genum80_0 = GClass169.GEnum80.const_5;
			gstruct2.float_0 = 0.3f;
			gstruct2.float_1 = 0.1875f;
			gstruct2.float_2 = 0.946f;
			Color[] array9 = new Color[2];
			int num17 = 0;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array9[num17] = color;
			int num18 = 1;
			color = default(Color);
			color.b = 0.2509804f;
			color.g = 0.2509804f;
			color.r = 1f;
			color.a = 1f;
			array9[num18] = color;
			gstruct2.color_0 = array9;
			this.gstruct219_2 = gstruct2;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x000A2234 File Offset: 0x000A0434
		public override void vmethod_8(int int_0)
		{
			this.method_8(int_0);
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000A2248 File Offset: 0x000A0448
		internal void method_28()
		{
			this.method_12();
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000A225C File Offset: 0x000A045C
		internal void method_29()
		{
			this.method_26();
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000A2270 File Offset: 0x000A0470
		public override void vmethod_31()
		{
			this.method_43();
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000A2284 File Offset: 0x000A0484
		public override void vmethod_28()
		{
			this.method_30();
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x000A2298 File Offset: 0x000A0498
		internal void method_30()
		{
			this.method_37();
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x000A22AC File Offset: 0x000A04AC
		public override void vmethod_19()
		{
			this.method_19();
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00021E04 File Offset: 0x00020004
		internal void method_31()
		{
			base.vmethod_12();
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x000A22C0 File Offset: 0x000A04C0
		public override void vmethod_12()
		{
			this.method_11();
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000A22D4 File Offset: 0x000A04D4
		internal void method_32()
		{
			this.method_44();
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000A22E8 File Offset: 0x000A04E8
		internal void method_33()
		{
			this.method_39();
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x000A22FC File Offset: 0x000A04FC
		internal void method_34()
		{
			this.method_15();
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00021DF0 File Offset: 0x0001FFF0
		internal void method_35()
		{
			base.vmethod_26();
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000A2310 File Offset: 0x000A0510
		public override void vmethod_26()
		{
			this.method_42();
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		internal void method_36()
		{
			base.vmethod_15();
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00021BA8 File Offset: 0x0001FDA8
		internal void method_37()
		{
			base.vmethod_28();
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00021C48 File Offset: 0x0001FE48
		internal void method_38(int int_0)
		{
			base.vmethod_27(int_0);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00021E68 File Offset: 0x00020068
		internal void method_39()
		{
			base.vmethod_11();
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x000A2324 File Offset: 0x000A0524
		internal void method_40()
		{
			this.method_21();
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000A2338 File Offset: 0x000A0538
		internal void method_41()
		{
			this.method_36();
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000A234C File Offset: 0x000A054C
		internal void method_42()
		{
			this.method_35();
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x000A2360 File Offset: 0x000A0560
		internal void method_43()
		{
			this.method_10();
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x000A2374 File Offset: 0x000A0574
		internal void method_44()
		{
			this.gclass156_0.method_61(this.float_6, this.float_7);
			this.gclass156_0.method_2(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			this.gclass156_0.method_227(GClass153.GClass87.texture2D_1, this.gclass156_0.float_4, this.gclass156_0.float_5, 0f, 0f, (float)GClass153.GClass87.texture2D_1.width, (float)GClass153.GClass87.texture2D_1.height, GClass156.Enum10.const_1);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000A2400 File Offset: 0x000A0600
		internal void method_45()
		{
			this.gclass156_0 = new GClass156();
			this.vmethod_4(this.gclass156_0);
			base.vmethod_23();
		}

		// Token: 0x040011EC RID: 4588
		internal GClass156 gclass156_0;

		// Token: 0x040011ED RID: 4589
		internal GClass171 gclass171_0 = null;

		// Token: 0x040011EE RID: 4590
		internal GClass173 gclass173_0 = null;

		// Token: 0x040011EF RID: 4591
		internal float float_1 = 1f;

		// Token: 0x040011F0 RID: 4592
		internal float float_2 = 255f;

		// Token: 0x040011F1 RID: 4593
		internal float float_3 = 1f;

		// Token: 0x040011F2 RID: 4594
		internal float float_4 = 1f;

		// Token: 0x040011F3 RID: 4595
		internal float float_5 = 1f;

		// Token: 0x040011F4 RID: 4596
		internal byte byte_0 = 200;

		// Token: 0x040011F5 RID: 4597
		internal float float_6 = 0f;

		// Token: 0x040011F6 RID: 4598
		internal float float_7 = 0f;

		// Token: 0x040011F7 RID: 4599
		internal GClass175.GStruct218 gstruct218_0;

		// Token: 0x040011F8 RID: 4600
		internal GClass175.GStruct218 gstruct218_1;

		// Token: 0x040011F9 RID: 4601
		internal GClass175.GStruct219 gstruct219_0;

		// Token: 0x040011FA RID: 4602
		internal GClass175.GStruct218 gstruct218_2;

		// Token: 0x040011FB RID: 4603
		internal GClass175.GStruct218 gstruct218_3;

		// Token: 0x040011FC RID: 4604
		internal GClass175.GStruct219 gstruct219_1;

		// Token: 0x040011FD RID: 4605
		internal GClass175.GStruct218 gstruct218_4;

		// Token: 0x040011FE RID: 4606
		internal GClass175.GStruct218 gstruct218_5;

		// Token: 0x040011FF RID: 4607
		internal GClass175.GStruct219 gstruct219_2;

		// Token: 0x0200029D RID: 669
		public enum GEnum64
		{
			// Token: 0x04001201 RID: 4609
			const_0,
			// Token: 0x04001202 RID: 4610
			const_1,
			// Token: 0x04001203 RID: 4611
			const_2,
			// Token: 0x04001204 RID: 4612
			const_3,
			// Token: 0x04001205 RID: 4613
			const_4
		}

		// Token: 0x0200029E RID: 670
		public struct GStruct218
		{
			// Token: 0x06001F4A RID: 8010 RVA: 0x000A242C File Offset: 0x000A062C
			public GStruct218(Texture texture_1, GClass169.GEnum80 genum80_1, GClass169.GStruct259 gstruct259_1, float float_4, GClass84.GEnum46 genum46_1, float float_5, float float_6, int int_2, int int_3, GClass175.GEnum64 genum64_1, float float_7, Color color_1, Color color_2)
			{
				this.texture_0 = texture_1;
				this.genum80_0 = genum80_1;
				this.gstruct259_0 = gstruct259_1;
				this.float_0 = float_4;
				this.genum46_0 = genum46_1;
				this.float_1 = float_5;
				this.float_2 = float_6;
				this.int_0 = int_2;
				this.int_1 = int_3;
				this.genum64_0 = genum64_1;
				this.float_3 = float_7;
				this.color_0 = new Color[]
				{
					color_1,
					color_2
				};
			}

			// Token: 0x06001F4B RID: 8011 RVA: 0x000A24AC File Offset: 0x000A06AC
			public GStruct218(Texture texture_1, GClass169.GEnum80 genum80_1, GClass169.GStruct259 gstruct259_1, float float_4, float float_5, float float_6, GClass175.GEnum64 genum64_1, float float_7, Color color_1, Color color_2)
			{
				this.texture_0 = texture_1;
				this.genum80_0 = genum80_1;
				this.gstruct259_0 = gstruct259_1;
				this.float_0 = float_4;
				this.genum46_0 = GClass84.GEnum46.const_0;
				this.float_1 = float_5;
				this.float_2 = float_6;
				this.int_0 = 0;
				this.int_1 = 0;
				this.genum64_0 = genum64_1;
				this.float_3 = float_7;
				this.color_0 = new Color[]
				{
					color_1,
					color_2
				};
			}

			// Token: 0x04001206 RID: 4614
			public Texture texture_0;

			// Token: 0x04001207 RID: 4615
			public GClass169.GEnum80 genum80_0;

			// Token: 0x04001208 RID: 4616
			public GClass169.GStruct259 gstruct259_0;

			// Token: 0x04001209 RID: 4617
			public float float_0;

			// Token: 0x0400120A RID: 4618
			public GClass84.GEnum46 genum46_0;

			// Token: 0x0400120B RID: 4619
			public float float_1;

			// Token: 0x0400120C RID: 4620
			public float float_2;

			// Token: 0x0400120D RID: 4621
			public int int_0;

			// Token: 0x0400120E RID: 4622
			public int int_1;

			// Token: 0x0400120F RID: 4623
			public GClass175.GEnum64 genum64_0;

			// Token: 0x04001210 RID: 4624
			public float float_3;

			// Token: 0x04001211 RID: 4625
			public Color[] color_0;
		}

		// Token: 0x0200029F RID: 671
		public struct GStruct219
		{
			// Token: 0x06001F4C RID: 8012 RVA: 0x000A252C File Offset: 0x000A072C
			public GStruct219(GClass169.GEnum80 genum80_1, int int_5, float float_3, GClass84.GEnum46 genum46_1, float float_4, float float_5, int int_6, int int_7, Color color_1, Color color_2, int int_8, int int_9)
			{
				this.genum80_0 = genum80_1;
				this.int_0 = int_5;
				this.float_0 = float_3;
				this.genum46_0 = genum46_1;
				this.float_1 = float_4;
				this.float_2 = float_5;
				this.int_1 = int_6;
				this.int_2 = int_7;
				this.color_0 = new Color[]
				{
					color_1,
					color_2
				};
				this.int_3 = int_8;
				this.int_4 = int_9;
			}

			// Token: 0x06001F4D RID: 8013 RVA: 0x000A25A4 File Offset: 0x000A07A4
			public GStruct219(GClass169.GEnum80 genum80_1, float float_3, float float_4, float float_5, Color color_1, Color color_2)
			{
				this.genum80_0 = genum80_1;
				this.int_0 = 0;
				this.float_0 = float_3;
				this.genum46_0 = GClass84.GEnum46.const_0;
				this.float_1 = float_4;
				this.float_2 = float_5;
				this.int_1 = 0;
				this.int_2 = 0;
				this.color_0 = new Color[]
				{
					color_1,
					color_2
				};
				this.int_3 = 0;
				this.int_4 = 0;
			}

			// Token: 0x04001212 RID: 4626
			public GClass169.GEnum80 genum80_0;

			// Token: 0x04001213 RID: 4627
			public int int_0;

			// Token: 0x04001214 RID: 4628
			public float float_0;

			// Token: 0x04001215 RID: 4629
			public GClass84.GEnum46 genum46_0;

			// Token: 0x04001216 RID: 4630
			public float float_1;

			// Token: 0x04001217 RID: 4631
			public float float_2;

			// Token: 0x04001218 RID: 4632
			public int int_1;

			// Token: 0x04001219 RID: 4633
			public int int_2;

			// Token: 0x0400121A RID: 4634
			public Color[] color_0;

			// Token: 0x0400121B RID: 4635
			public int int_3;

			// Token: 0x0400121C RID: 4636
			public int int_4;
		}
	}
}
