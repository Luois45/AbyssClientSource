using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns185;
using ns21;
using ns241;
using ns425;
using ns45;
using UnityEngine;
using VRC.Core;

namespace ns478
{
	// Token: 0x0200035A RID: 858
	public class GClass181 : GClass130
	{
		// Token: 0x060047AE RID: 18350 RVA: 0x0010F4FC File Offset: 0x0010D6FC
		internal bool method_2(GClass181.GStruct270 gstruct270_0)
		{
			this.list_1.Add(gstruct270_0);
			this.method_27();
			return true;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x0010F51C File Offset: 0x0010D71C
		internal bool method_3(GClass181.Struct34 struct34_0)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (struct34_0.method_0(this.list_0[i]))
				{
					this.list_0.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x0010F56C File Offset: 0x0010D76C
		internal bool method_4(string string_2, string string_3, string string_4)
		{
			GClass181.Class206 @class = new GClass181.Class206();
			@class.string_0 = string_3;
			return this.list_1.FindIndex(new Predicate<GClass181.GStruct270>(@class.method_0)) == -1 && this.method_2(new GClass181.GStruct270(string_2, @class.string_0, string_4));
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x0010F5C0 File Offset: 0x0010D7C0
		internal bool method_5(GClass181.Struct34 struct34_0)
		{
			GameObject gameObject_ = struct34_0.gameObject_0;
			bool result;
			if (!gameObject_)
			{
				result = false;
			}
			else
			{
				Transform transform = gameObject_.transform;
				result = (transform && this.method_15(struct34_0.string_0, transform.position, transform.forward, struct34_0.float_1, transform.rotation, struct34_0.string_1));
			}
			return result;
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x0010F6A0 File Offset: 0x0010D8A0
		public override void vmethod_23()
		{
			this.method_18();
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x0010F6B4 File Offset: 0x0010D8B4
		internal bool method_6(GClass181.GStruct270 gstruct270_0, bool bool_8)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				GClass181.GStruct270 gstruct = this.list_1[i];
				if (gstruct270_0.method_0(gstruct))
				{
					gstruct.bool_0 = bool_8;
					this.list_1[i] = gstruct;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0010F70C File Offset: 0x0010D90C
		internal void method_7(bool bool_8 = false)
		{
			this.method_22(bool_8);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0010F720 File Offset: 0x0010D920
		internal void method_8(string string_2)
		{
			this.method_13(string_2);
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x0010F734 File Offset: 0x0010D934
		internal bool method_9(string string_2, string string_3)
		{
			GClass181.Class205 @class = new GClass181.Class205();
			@class.string_0 = string_3;
			return this.list_1.FindIndex(new Predicate<GClass181.GStruct270>(@class.method_0)) == -1 && this.method_2(new GClass181.GStruct270(string_2, @class.string_0, ""));
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0010F78C File Offset: 0x0010D98C
		internal void method_10()
		{
			GClass21.gclass21_0.list_0 = this.list_1;
			GClass21.smethod_3();
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0010F7B0 File Offset: 0x0010D9B0
		internal bool method_11(string string_2, Vector3 vector3_0, Vector3 vector3_1, Quaternion quaternion_0, string string_3)
		{
			return this.method_15(string_2, vector3_0, vector3_1, this.float_0, quaternion_0, string_3);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0010F7D0 File Offset: 0x0010D9D0
		internal void method_12()
		{
			this.method_10();
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0010F7E4 File Offset: 0x0010D9E4
		internal void method_13(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0010F7F8 File Offset: 0x0010D9F8
		internal bool method_14(GameObject gameObject_0 = null, APIUser apiuser_0 = null, string string_2 = "", string string_3 = "1337")
		{
			this.list_0.Add(new GClass181.Struct34(gameObject_0, apiuser_0, string_2, string_3, 1f, this.float_0));
			return true;
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x0010F828 File Offset: 0x0010DA28
		internal bool method_15(string string_2, Vector3 vector3_0, Vector3 vector3_1, float float_1, Quaternion quaternion_0, string string_3)
		{
			string text = string.Empty;
			if (this.bool_5)
			{
				for (int i = 0; i < 1000; i++)
				{
					text += "\n";
				}
			}
			else if (this.bool_3)
			{
				for (int j = 0; j < 16; j++)
				{
					text += "\n";
				}
			}
			else if (this.bool_4)
			{
				text += "\r";
			}
			if (this.bool_2)
			{
				text += "\a";
			}
			if (text == string.Empty && !this.bool_1)
			{
				text = string_3;
			}
			int int_ = this.bool_7 ? int.MinValue : 1;
			GameObject gameObject = GClass84.smethod_1510(string_2, vector3_0 + vector3_1 * float_1, quaternion_0, text, int_);
			bool result;
			if (!gameObject)
			{
				result = false;
			}
			else
			{
				if (this.bool_6)
				{
					GClass84.smethod_898(gameObject, float.MinValue);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0010F928 File Offset: 0x0010DB28
		internal void method_16(bool bool_8)
		{
			this.method_25(GClass84.smethod_108<string>(bool_8, GClass181.list_2[GClass84.smethod_1673(GClass181.list_2.Count)], string.Empty));
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0010F960 File Offset: 0x0010DB60
		internal bool method_17(int int_0)
		{
			bool result;
			if (int_0 < 0 || int_0 >= this.list_1.Count)
			{
				result = false;
			}
			else
			{
				this.list_1.RemoveAt(int_0);
				this.method_27();
				result = true;
			}
			return result;
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0010F9A0 File Offset: 0x0010DBA0
		internal void method_18()
		{
			this.method_30();
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0010F9B4 File Offset: 0x0010DBB4
		public override void vmethod_19()
		{
			this.method_19();
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0010F9C8 File Offset: 0x0010DBC8
		internal void method_19()
		{
			this.method_20();
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0010F9DC File Offset: 0x0010DBDC
		internal void method_20()
		{
			if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304) && Input.GetKeyDown(112))
			{
				this.bool_0 = !this.bool_0;
			}
			if (this.bool_0)
			{
				try
				{
					int num = GClass84.smethod_841();
					for (int i = 0; i < this.list_0.Count; i++)
					{
						GClass181.Struct34 @struct = this.list_0[i];
						if (@struct.bool_0)
						{
							if (!@struct.gameObject_0)
							{
								this.list_0.RemoveAt(i);
								i--;
							}
							else if ((float)num >= @struct.float_2 + @struct.float_0 * 1000f && this.method_5(@struct))
							{
								@struct.float_2 = (float)num;
								this.list_0[i] = @struct;
							}
						}
					}
				}
				catch (Exception ex)
				{
					GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
				}
			}
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0010FB00 File Offset: 0x0010DD00
		internal bool method_21(GClass181.Struct34 struct34_0, bool bool_8)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass181.Struct34 @struct = this.list_0[i];
				if (struct34_0.method_0(@struct))
				{
					@struct.bool_0 = bool_8;
					this.list_0[i] = @struct;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0010FB58 File Offset: 0x0010DD58
		internal void method_22(bool bool_8)
		{
			this.method_16(bool_8);
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0010FB6C File Offset: 0x0010DD6C
		internal bool method_23(GameObject gameObject_0 = null, APIUser apiuser_0 = null, string string_2 = "", string string_3 = "1337", float float_1 = 5f, float float_2 = 2f)
		{
			this.list_0.Add(new GClass181.Struct34(gameObject_0, apiuser_0, string_2, string_3, float_1, float_2));
			return true;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0010FC1C File Offset: 0x0010DE1C
		internal bool method_24(GClass181.GStruct270 gstruct270_0)
		{
			for (int i = 0; i < this.list_1.Count; i++)
			{
				if (gstruct270_0.method_0(this.list_1[i]))
				{
					return this.method_17(i);
				}
			}
			return false;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0010FC64 File Offset: 0x0010DE64
		internal void method_25(string string_2)
		{
			this.method_8(string_2);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x0010FC78 File Offset: 0x0010DE78
		internal bool method_26(GameObject gameObject_0 = null, APIUser apiuser_0 = null, string string_2 = "", string string_3 = "1337", float float_1 = 5f)
		{
			this.list_0.Add(new GClass181.Struct34(gameObject_0, apiuser_0, string_2, string_3, float_1, this.float_0));
			return true;
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x0010FCA4 File Offset: 0x0010DEA4
		internal void method_27()
		{
			this.method_12();
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0010FCB8 File Offset: 0x0010DEB8
		internal bool method_28(int int_0, bool bool_8)
		{
			bool result;
			if (int_0 < 0 || int_0 >= this.list_1.Count)
			{
				result = false;
			}
			else
			{
				GClass181.GStruct270 value = this.list_1[int_0];
				value.bool_0 = bool_8;
				this.list_1[int_0] = value;
				this.method_27();
				result = true;
			}
			return result;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x0010FD10 File Offset: 0x0010DF10
		internal bool method_29(GameObject gameObject_0 = null, APIUser apiuser_0 = null, string string_2 = "")
		{
			this.list_0.Add(new GClass181.Struct34(gameObject_0, apiuser_0, string_2, "1337", 1f, this.float_0));
			return true;
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x0010FD44 File Offset: 0x0010DF44
		internal void method_30()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			try
			{
				this.method_7(true);
				GClass21.smethod_1();
				this.list_1 = GClass21.gclass21_0.list_0;
				new GClass14().method_0();
			}
			catch (Exception ex)
			{
				GClass70.smethod_36(ex.ToString(), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x04001BAB RID: 7083
		internal List<GClass181.Struct34> list_0 = new List<GClass181.Struct34>();

		// Token: 0x04001BAC RID: 7084
		internal List<GClass181.GStruct270> list_1 = new List<GClass181.GStruct270>();

		// Token: 0x04001BAD RID: 7085
		internal bool bool_0 = true;

		// Token: 0x04001BAE RID: 7086
		internal float float_0 = 2f;

		// Token: 0x04001BAF RID: 7087
		internal string string_1 = string.Empty;

		// Token: 0x04001BB0 RID: 7088
		internal bool bool_1 = false;

		// Token: 0x04001BB1 RID: 7089
		internal bool bool_2 = false;

		// Token: 0x04001BB2 RID: 7090
		internal bool bool_3 = false;

		// Token: 0x04001BB3 RID: 7091
		internal bool bool_4 = false;

		// Token: 0x04001BB4 RID: 7092
		internal bool bool_5 = false;

		// Token: 0x04001BB5 RID: 7093
		internal bool bool_6 = false;

		// Token: 0x04001BB6 RID: 7094
		internal bool bool_7 = false;

		// Token: 0x04001BB7 RID: 7095
		internal static List<string> list_2 = new List<string>
		{
			"Trash Collector",
			"Trash Bin",
			"Recycling Center",
			"George Floyd",
			"George Folyd Sends Regards",
			"abyssvr.chat VRC Crackers R US",
			"Believe In Yourself",
			"Join VRChat: discord.gg/vrchat",
			"_Unreal Was Here",
			"Imagine Using Emm VRC"
		};

		// Token: 0x0200035B RID: 859
		internal struct Struct34
		{
			// Token: 0x060047CF RID: 18383 RVA: 0x0010FDB0 File Offset: 0x0010DFB0
			public bool method_0(GClass181.Struct34 struct34_0)
			{
				return struct34_0.gameObject_0 == this.gameObject_0 && struct34_0.string_0 == this.string_0 && struct34_0.string_1 == this.string_1 && struct34_0.float_0 == this.float_0;
			}

			// Token: 0x060047D0 RID: 18384 RVA: 0x0010FE08 File Offset: 0x0010E008
			public Struct34(GameObject gameObject_1 = null, APIUser apiuser_0 = null, string string_3 = "", string string_4 = "1337", float float_3 = 1f, float float_4 = 2f)
			{
				this.gameObject_0 = gameObject_1;
				this.string_0 = string_3;
				this.string_1 = string_4;
				this.float_0 = float_3;
				this.float_1 = float_4;
				this.bool_0 = true;
				this.float_2 = 0f;
				if (apiuser_0 != null)
				{
					this.string_2 = apiuser_0.displayName;
				}
				else
				{
					this.string_2 = string.Empty;
				}
			}

			// Token: 0x04001BB8 RID: 7096
			public GameObject gameObject_0;

			// Token: 0x04001BB9 RID: 7097
			public string string_0;

			// Token: 0x04001BBA RID: 7098
			public string string_1;

			// Token: 0x04001BBB RID: 7099
			public float float_0;

			// Token: 0x04001BBC RID: 7100
			public float float_1;

			// Token: 0x04001BBD RID: 7101
			public float float_2;

			// Token: 0x04001BBE RID: 7102
			public bool bool_0;

			// Token: 0x04001BBF RID: 7103
			public string string_2;
		}

		// Token: 0x0200035C RID: 860
		public struct GStruct270
		{
			// Token: 0x060047D1 RID: 18385 RVA: 0x0010FE6C File Offset: 0x0010E06C
			public static bool smethod_0(GClass181.GStruct270 gstruct270_0, GClass181.GStruct270 gstruct270_1)
			{
				return gstruct270_0.string_0 == gstruct270_1.string_0 && gstruct270_0.string_1 == gstruct270_1.string_1;
			}

			// Token: 0x060047D2 RID: 18386 RVA: 0x0010FEA0 File Offset: 0x0010E0A0
			public bool method_0(GClass181.GStruct270 gstruct270_0)
			{
				return gstruct270_0.string_0 == this.string_0 && gstruct270_0.string_1 == this.string_1;
			}

			// Token: 0x060047D3 RID: 18387 RVA: 0x0010FED4 File Offset: 0x0010E0D4
			public GStruct270(string string_3 = "", string string_4 = "", string string_5 = "")
			{
				this.string_0 = string_3;
				this.string_1 = string_4;
				this.string_2 = string_5;
				this.bool_0 = true;
			}

			// Token: 0x04001BC0 RID: 7104
			public string string_0;

			// Token: 0x04001BC1 RID: 7105
			public string string_1;

			// Token: 0x04001BC2 RID: 7106
			public string string_2;

			// Token: 0x04001BC3 RID: 7107
			public bool bool_0;
		}

		// Token: 0x0200035D RID: 861
		[CompilerGenerated]
		private sealed class Class205
		{
			// Token: 0x060047D5 RID: 18389 RVA: 0x0010FF00 File Offset: 0x0010E100
			internal bool method_0(GClass181.GStruct270 gstruct270_0)
			{
				return gstruct270_0.string_1 == this.string_0;
			}

			// Token: 0x04001BC4 RID: 7108
			public string string_0;
		}

		// Token: 0x0200035E RID: 862
		[CompilerGenerated]
		private sealed class Class206
		{
			// Token: 0x060047D7 RID: 18391 RVA: 0x0010FF20 File Offset: 0x0010E120
			internal bool method_0(GClass181.GStruct270 gstruct270_0)
			{
				return gstruct270_0.string_1 == this.string_0;
			}

			// Token: 0x04001BC5 RID: 7109
			public string string_0;
		}
	}
}
