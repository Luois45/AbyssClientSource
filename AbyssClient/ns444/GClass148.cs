using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using ns153;
using ns185;
using ns241;
using ns418;
using ns425;
using ns440;
using Transmtn.DTO.Notifications;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.Networking;

namespace ns444
{
	// Token: 0x0200017D RID: 381
	public class GClass148 : GClass130
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x0004E41C File Offset: 0x0004C61C
		internal void method_2()
		{
			this.method_4();
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0004E430 File Offset: 0x0004C630
		internal void method_3(bool bool_6)
		{
			this.method_13(bool_6);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0004E444 File Offset: 0x0004C644
		public virtual void vmethod_26(string string_7)
		{
			this.method_54(string_7);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0004E458 File Offset: 0x0004C658
		internal void method_4()
		{
			this.method_67();
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0004E46C File Offset: 0x0004C66C
		internal void method_5()
		{
			this.method_58();
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0004E480 File Offset: 0x0004C680
		private bool method_6()
		{
			bool result;
			if (GClass84.smethod_1424() == null)
			{
				Transform transform = GClass84.smethod_1409();
				Transform transform2 = (transform != null) ? transform.Find("GoButton") : null;
				if (transform2)
				{
					GameObject gameObject = transform2.gameObject;
					if (gameObject && gameObject.activeInHierarchy)
					{
						Button component = gameObject.GetComponent<Button>();
						if (component)
						{
							component.Press();
						}
					}
				}
				this.float_3 = 0f;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0004E500 File Offset: 0x0004C700
		internal void method_7(string string_7, string string_8)
		{
			if (GClass84.smethod_362(this.string_1) == GClass84.smethod_362(string_7))
			{
				this.float_4 = 0f;
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0004E530 File Offset: 0x0004C730
		private void method_8(float float_13)
		{
			this.method_23(float_13);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0004E544 File Offset: 0x0004C744
		private void method_9()
		{
			this.method_21();
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0004E558 File Offset: 0x0004C758
		private void method_10(float float_13 = 0f)
		{
			this.method_8(float_13);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0004E56C File Offset: 0x0004C76C
		internal void method_11(bool bool_6)
		{
			this.method_30(bool_6);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0004E580 File Offset: 0x0004C780
		internal void method_12(bool bool_6)
		{
			this.method_44(bool_6);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0004E594 File Offset: 0x0004C794
		internal void method_13(bool bool_6)
		{
			this.method_47(bool_6);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0004E5A8 File Offset: 0x0004C7A8
		private void method_14()
		{
			this.method_43();
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0004E5BC File Offset: 0x0004C7BC
		internal bool method_15(string string_7)
		{
			bool result = false;
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				if (this.list_0[i].string_1 == string_7)
				{
					this.list_0.RemoveAt(i);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0004E610 File Offset: 0x0004C810
		internal void method_16(string string_7, string string_8)
		{
			if (GClass84.smethod_362(this.string_1) == GClass84.smethod_362(string_7))
			{
				this.float_4 = this.float_1;
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0004E644 File Offset: 0x0004C844
		public override void vmethod_7(string string_7, string string_8)
		{
			this.method_57(string_7, string_8);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0004E65C File Offset: 0x0004C85C
		internal void method_17(string string_7)
		{
			this.method_71(string_7);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0004E670 File Offset: 0x0004C870
		private void method_18()
		{
			this.method_60();
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0004E684 File Offset: 0x0004C884
		private void method_19()
		{
			this.method_77();
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0004E698 File Offset: 0x0004C898
		private void method_20()
		{
			this.float_7 = this.float_8 + (this.float_9 - this.float_8) * GClass84.smethod_790();
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0004E6C8 File Offset: 0x0004C8C8
		private void method_21()
		{
			GClass84.smethod_1414(this.string_1, null, null, null);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0004E610 File Offset: 0x0004C810
		internal void method_22(string string_7, string string_8)
		{
			if (GClass84.smethod_362(this.string_1) == GClass84.smethod_362(string_7))
			{
				this.float_4 = this.float_1;
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0004E6E4 File Offset: 0x0004C8E4
		private void method_23(float float_13)
		{
			this.float_4 += float_13;
			if (this.float_4 >= this.float_1)
			{
				GClass84.gclass152_0.method_50(this.string_1, null, null, new Action(this.method_83));
				this.float_4 = 0f;
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0004E73C File Offset: 0x0004C93C
		internal void method_24(string string_7)
		{
			this.method_29(string_7);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0004E750 File Offset: 0x0004C950
		private void method_25()
		{
			GClass84.gclass144_0.method_25(GClass84.smethod_461());
			this.string_3 = string.Empty;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0004E778 File Offset: 0x0004C978
		private void method_26()
		{
			Transform transform = GClass84.smethod_981();
			if (transform)
			{
				Vector3 position = transform.position;
				position.x = (float)(1000000000 * (GClass84.smethod_1673(2) * 2 - 1));
				position.y = 1E+09f;
				position.z = (float)(1000000000 * (GClass84.smethod_1673(2) * 2 - 1));
				transform.position = position;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0004E7E0 File Offset: 0x0004C9E0
		internal void method_27(string string_7)
		{
			this.method_38(string_7);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		private void method_28(string string_7)
		{
			this.method_80(string_7);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004E808 File Offset: 0x0004CA08
		internal void method_29(string string_7)
		{
			try
			{
				if (GClass84.gclass152_0 != null && GClass84.gclass152_0.bool_5)
				{
					GClass84.gclass152_0.method_13(string.Concat(new string[]
					{
						"Send",
						"Command",
						": ",
						"Command",
						": ",
						string_7
					}));
				}
				else
				{
					string str = "Command" + ": " + string_7;
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						string text = this.list_0[i].string_2;
						if (GClass84.smethod_362(GClass84.smethod_1428(text, GClass84.smethod_593("http://"))) != GClass84.smethod_362("http://"))
						{
							text = "http" + "://" + text;
						}
						string text2 = text + "/" + str;
						GClass70.smethod_38(text2, GClass70.Enum1.const_0);
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text2);
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						Stream responseStream = httpWebResponse.GetResponseStream();
						new StreamReader(responseStream);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0004E954 File Offset: 0x0004CB54
		internal void method_30(bool bool_6)
		{
			GClass61.gclass61_0.bool_0 = bool_6;
			GClass61.smethod_4();
			this.bool_1 = bool_6;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0004E978 File Offset: 0x0004CB78
		internal void method_31()
		{
			this.method_48();
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0004E98C File Offset: 0x0004CB8C
		internal void method_32()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0004E9A4 File Offset: 0x0004CBA4
		private void method_33()
		{
			this.method_59();
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		internal void method_34()
		{
			this.method_82();
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		public override void vmethod_23()
		{
			this.method_52();
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		internal void method_35(string string_7)
		{
			this.method_51(string_7);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
		private void method_36()
		{
			if (this.bool_3)
			{
				if (this.list_1.Count == 0)
				{
					this.method_79(false);
				}
				else if (!this.method_6())
				{
					int num = GClass84.smethod_841();
					if (this.float_3 == 0f || this.float_3 > (float)num)
					{
						this.float_3 = (float)num;
					}
					if (this.bool_4)
					{
						if (this.float_12 > (float)num)
						{
							this.float_12 = (float)num;
						}
						if (this.float_12 + this.float_10 * 1000f < (float)num)
						{
							if (!this.bool_5 && GClass84.smethod_1369(this.apiWorld_0.id))
							{
								this.bool_5 = true;
							}
							else
							{
								this.method_65(this.int_1 + 1);
								if (this.int_1 < 0)
								{
									this.method_79(false);
									return;
								}
								this.apiWorld_0.id = this.list_2[this.int_1].string_0;
							}
							if (GClass84.smethod_1373(this.apiWorld_0.id))
							{
								this.method_79(false);
							}
						}
					}
					else if (this.float_7 < GClass84.float_2)
					{
						while (this.list_3.Count > 0)
						{
							if (this.list_3[0].int_0 >= this.int_2)
							{
								GClass84.smethod_704(this.list_3[0].string_0 + ":" + this.list_3[0].string_1);
								this.method_14();
								this.list_3.RemoveAt(0);
								this.bool_5 = false;
								return;
							}
							this.list_3.RemoveAt(0);
						}
						this.bool_4 = true;
					}
				}
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004EBCC File Offset: 0x0004CDCC
		internal void method_37(string string_7, string string_8)
		{
			this.method_7(string_7, string_8);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0004EBE4 File Offset: 0x0004CDE4
		internal void method_38(string string_7)
		{
			this.method_49(string_7);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0004EBF8 File Offset: 0x0004CDF8
		internal void method_39(string string_7, string string_8)
		{
			this.method_22(string_7, string_8);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0004EC10 File Offset: 0x0004CE10
		internal void method_40(string string_7, string string_8)
		{
			this.method_76(string_7, string_8);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0004EC28 File Offset: 0x0004CE28
		private void method_41()
		{
			if (!GClass84.smethod_334(this.string_1) && !this.method_6())
			{
				int num = GClass84.smethod_841();
				if (this.float_2 >= GClass84.float_2)
				{
					this.float_4 = this.float_1;
				}
				else
				{
					this.method_33();
					if (GClass84.bool_0)
					{
						bool flag = true;
						Player[] array = GClass84.smethod_870();
						int i = array.Length - 1;
						while (i >= 0)
						{
							if (!(GClass84.smethod_684(array[i]) == this.string_1))
							{
								i--;
							}
							else
							{
								flag = false;
								IL_92:
								if (!flag)
								{
									return;
								}
								List<Notification> list = MonoBehaviour1PublicGaBoLi1NoObSoSoUnique.field_Private_Static_List_1_Notification_0.smethod_1334<Notification>();
								if (list != null)
								{
									for (int j = list.Count - 1; j >= 0; j--)
									{
										if (list[j].senderUserId == this.string_1 && list[j].notificationType == Notification.NotificationType.Invite)
										{
											GClass84.smethod_337(list[j]);
										}
									}
								}
								if (!this.bool_1)
								{
									return;
								}
								if (this.int_0 > num)
								{
									this.int_0 = num;
									return;
								}
								if ((float)(num - this.int_0) > this.float_0 * 1000f)
								{
									this.method_10(GClass84.smethod_359((float)(num - this.int_0) / 1000f, 0f));
									this.int_0 = num;
									return;
								}
								return;
							}
						}
						goto IL_92;
					}
				}
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0004ED98 File Offset: 0x0004CF98
		private void method_42()
		{
			if (!string.IsNullOrEmpty(this.string_2))
			{
				Player[] array = GClass84.smethod_870();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					if (GClass84.smethod_684(array[i]) == this.string_2)
					{
						GameObject gameObject_ = GClass84.smethod_461();
						if (!GClass84.gclass144_0.method_22(gameObject_))
						{
							GClass84.gclass144_0.method_24(gameObject_, GClass84.smethod_367(array[i]), default(Vector3), GClass84.GEnum48.const_0, GClass144.GEnum34.const_1, GClass144.GEnum35.const_0, GClass144.GEnum36.const_0, this.float_6, this.float_5, 0f, 0f, 0f, 0f, 0f);
							this.string_3 = this.string_2;
						}
					}
				}
				if (!string.IsNullOrEmpty(this.string_3) && this.string_3 != this.string_2)
				{
					this.method_62();
				}
			}
			else if (!string.IsNullOrEmpty(this.string_3))
			{
				this.method_62();
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0004EE9C File Offset: 0x0004D09C
		private void method_43()
		{
			this.method_20();
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
		internal void method_44(bool bool_6)
		{
			this.bool_3 = bool_6;
			if (bool_6)
			{
				this.method_34();
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		internal void method_45()
		{
			this.method_72();
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		private void method_46()
		{
			this.method_25();
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0004F3DC File Offset: 0x0004D5DC
		internal void method_47(bool bool_6)
		{
			this.bool_2 = bool_6;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
		internal void method_48()
		{
			if (!string.IsNullOrEmpty(this.string_6))
			{
				FlatBufferNetworkSerializer flatBufferNetworkSerializer = GClass84.smethod_682();
				if (flatBufferNetworkSerializer)
				{
					flatBufferNetworkSerializer.enabled = false;
				}
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0004F424 File Offset: 0x0004D624
		internal void method_49(string string_7)
		{
			this.string_4 = string_7;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0004F438 File Offset: 0x0004D638
		internal void method_50(bool bool_6)
		{
			this.method_11(bool_6);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0004F44C File Offset: 0x0004D64C
		internal void method_51(string string_7)
		{
			this.string_2 = string_7;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004F460 File Offset: 0x0004D660
		internal void method_52()
		{
			this.method_85();
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0004F474 File Offset: 0x0004D674
		internal void method_53()
		{
			GClass61.gclass61_0.string_0 = string.Empty;
			GClass61.smethod_4();
			this.string_1 = string.Empty;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
		internal void method_54(string string_7)
		{
			this.method_69(string_7);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0004F4B4 File Offset: 0x0004D6B4
		internal void method_55(string string_7)
		{
			this.method_35(string_7);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0004F4C8 File Offset: 0x0004D6C8
		internal void method_56(string string_7)
		{
			this.string_6 = string_7;
			FlatBufferNetworkSerializer flatBufferNetworkSerializer = GClass84.smethod_682();
			if (flatBufferNetworkSerializer)
			{
				flatBufferNetworkSerializer.enabled = string.IsNullOrEmpty(string_7);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0004F4F8 File Offset: 0x0004D6F8
		internal void method_57(string string_7, string string_8)
		{
			this.method_16(string_7, string_8);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0004F510 File Offset: 0x0004D710
		internal void method_58()
		{
			if (GClass84.bool_4 && Input.GetKey(306) && Input.GetKey(304))
			{
				if (Input.GetKeyDown(106))
				{
					this.bool_0 = !this.bool_0;
				}
				if (Input.GetKeyDown(107))
				{
					this.method_34();
				}
				if (Input.GetKeyDown(108))
				{
					this.method_27(string.Empty);
				}
				if (Input.GetKeyDown(109))
				{
					this.method_55(string.Empty);
				}
				if (Input.GetKeyDown(104))
				{
					this.method_3(!this.bool_2);
				}
				if (Input.GetKeyDown(102))
				{
					this.method_50(!this.bool_1);
				}
				if (Input.GetKeyDown(121))
				{
					this.method_74(string.Empty);
				}
			}
			if (!this.bool_0)
			{
				if (this.string_3 != string.Empty)
				{
					this.method_62();
				}
			}
			else
			{
				if (this.bool_2)
				{
					if (this.string_3 != string.Empty)
					{
						this.method_62();
					}
					this.method_18();
				}
				this.method_84(this.string_4);
				if (GClass84.smethod_334(this.string_2) && this.string_3 != string.Empty)
				{
					this.method_62();
				}
				this.method_19();
				this.method_75();
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0004F660 File Offset: 0x0004D860
		private void method_59()
		{
			this.method_42();
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0004F674 File Offset: 0x0004D874
		private void method_60()
		{
			this.method_26();
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0004F688 File Offset: 0x0004D888
		internal void method_61(string string_7)
		{
			this.string_5 = string_7;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0004F69C File Offset: 0x0004D89C
		private void method_62()
		{
			this.method_46();
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		private void method_63(int int_3)
		{
			this.method_78(int_3);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0004F6C4 File Offset: 0x0004D8C4
		internal bool method_64(string string_7)
		{
			bool result;
			if (GClass84.smethod_334(string_7) || GClass84.smethod_653(GClass84.smethod_1372()) == string_7)
			{
				this.method_34();
				result = false;
			}
			else
			{
				GClass61.gclass61_0.string_0 = string_7;
				GClass61.smethod_4();
				this.string_1 = string_7;
				this.method_79(false);
				result = true;
			}
			return result;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0004F71C File Offset: 0x0004D91C
		private void method_65(int int_3)
		{
			this.method_63(int_3);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0004F730 File Offset: 0x0004D930
		internal void method_66(string string_7)
		{
			this.method_24(string_7);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004F744 File Offset: 0x0004D944
		internal void method_67()
		{
			for (int i = this.list_0.Count - 1; i >= 0; i--)
			{
				GClass70.smethod_24(string.Concat(new string[]
				{
					this.list_0[i].string_0,
					" ",
					this.list_0[i].string_1,
					" ",
					this.list_0[i].string_2
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		public override void vmethod_5(string string_7, string string_8)
		{
			this.method_40(string_7, string_8);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0004F7E4 File Offset: 0x0004D9E4
		internal bool method_68(string string_7)
		{
			GClass148.Class88 @class = new GClass148.Class88();
			@class.gclass148_0 = this;
			@class.string_0 = string_7;
			if (!GClass84.smethod_334(@class.string_0) && !(GClass84.smethod_653(GClass84.smethod_1372()) == @class.string_0) && GClass84.smethod_1311(@class.string_0))
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					if (this.list_0[i].string_1 == @class.string_0)
					{
						IL_11B:
						return false;
					}
				}
				try
				{
					GClass148.Class89 class2 = new GClass148.Class89();
					class2.class88_0 = @class;
					class2.string_0 = string.Empty;
					class2.string_1 = string.Empty;
					class2.string_2 = string.Empty;
					APIUser.FetchUser(class2.class88_0.string_0, new Action<APIUser>(class2.method_0), null);
					this.list_0.Add(new GClass148.GStruct105(class2.string_0, class2.class88_0.string_0, class2.string_2));
					return true;
				}
				catch
				{
					return false;
				}
				goto IL_11B;
			}
			return false;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0004F920 File Offset: 0x0004DB20
		public override void vmethod_2(string string_7, string string_8)
		{
			this.method_37(string_7, string_8);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0004F938 File Offset: 0x0004DB38
		internal void method_69(string string_7)
		{
			if (!(string_7 == string.Empty))
			{
				if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetOwner(")) == "SetOwner(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetOwner("), -1);
					int num = GClass84.smethod_1611(string_7, ");");
					if (num != -1 && GClass84.smethod_1204(string_7, num + GClass84.smethod_593(");"), -1) == string.Empty)
					{
						this.method_64(GClass84.smethod_1428(string_7, num));
					}
				}
				else if (string_7 == "ClearOwner();")
				{
					this.method_34();
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("bEnabled=")) == "bEnabled=")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("bEnabled="), -1);
					int num2 = GClass84.smethod_1611(string_7, ";");
					bool flag;
					if (num2 != -1 && GClass84.smethod_1204(string_7, num2 + GClass84.smethod_593(";"), -1) == string.Empty && GClass84.smethod_742(GClass84.smethod_1428(string_7, num2), out flag))
					{
						this.bool_0 = flag;
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetFollowOwner(")) == "SetFollowOwner(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetFollowOwner("), -1);
					int num3 = GClass84.smethod_1611(string_7, ");");
					bool bool_;
					if (num3 != -1 && GClass84.smethod_1204(string_7, num3 + GClass84.smethod_593(");"), -1) == string.Empty && GClass84.smethod_742(GClass84.smethod_1428(string_7, num3), out bool_))
					{
						this.method_50(bool_);
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetOrbitUserID(")) == "SetOrbitUserID(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetOrbitUserID("), -1);
					int num4 = GClass84.smethod_1611(string_7, ");");
					if (num4 != -1 && GClass84.smethod_1204(string_7, num4 + GClass84.smethod_593(");"), -1) == string.Empty)
					{
						this.method_55(GClass84.smethod_1428(string_7, num4));
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetLookAtUserID(")) == "SetLookAtUserID(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetLookAtUserID("), -1);
					int num5 = GClass84.smethod_1611(string_7, ");");
					if (num5 != -1 && GClass84.smethod_1204(string_7, num5 + GClass84.smethod_593(");"), -1) == string.Empty)
					{
						this.method_27(GClass84.smethod_1428(string_7, num5));
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetParrotUserID(")) == "SetParrotUserID(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetParrotUserID("), -1);
					int num6 = GClass84.smethod_1611(string_7, ");");
					if (num6 != -1 && GClass84.smethod_1204(string_7, num6 + GClass84.smethod_593(");"), -1) == string.Empty)
					{
						this.method_74(GClass84.smethod_1428(string_7, num6));
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetMimicUserID(")) == "SetMimicUserID(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetMimicUserID("), -1);
					int num7 = GClass84.smethod_1611(string_7, ");");
					if (num7 != -1 && GClass84.smethod_1204(string_7, num7 + GClass84.smethod_593(");"), -1) == string.Empty)
					{
						this.method_17(GClass84.smethod_1428(string_7, num7));
					}
				}
				else if (GClass84.smethod_1428(string_7, GClass84.smethod_593("SetHidePosition(")) == "SetHidePosition(")
				{
					string_7 = GClass84.smethod_1204(string_7, GClass84.smethod_593("SetHidePosition("), -1);
					int num8 = GClass84.smethod_1611(string_7, ");");
					bool bool_2;
					if (num8 != -1 && GClass84.smethod_1204(string_7, num8 + GClass84.smethod_593(");"), -1) == string.Empty && GClass84.smethod_742(GClass84.smethod_1428(string_7, num8), out bool_2))
					{
						this.method_3(bool_2);
					}
				}
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		private IEnumerator method_70(string string_7)
		{
			GClass148.Class90 @class = new GClass148.Class90(0);
			@class.gclass148_0 = this;
			@class.string_0 = string_7;
			return @class;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
		internal void method_71(string string_7)
		{
			this.method_56(string_7);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		public override void vmethod_19()
		{
			this.method_5();
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0004FDC8 File Offset: 0x0004DFC8
		internal void method_72()
		{
			this.method_32();
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0004FDDC File Offset: 0x0004DFDC
		internal void method_73(string string_7)
		{
			this.method_61(string_7);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0004FDF0 File Offset: 0x0004DFF0
		internal void method_74(string string_7)
		{
			this.method_73(string_7);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0004FE04 File Offset: 0x0004E004
		private void method_75()
		{
			this.method_81();
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004E610 File Offset: 0x0004C810
		internal void method_76(string string_7, string string_8)
		{
			if (GClass84.smethod_362(this.string_1) == GClass84.smethod_362(string_7))
			{
				this.float_4 = this.float_1;
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004FE18 File Offset: 0x0004E018
		private void method_77()
		{
			this.method_41();
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0004FE2C File Offset: 0x0004E02C
		private void method_78(int int_3)
		{
			this.int_1 = int_3 % this.list_1.Count;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004FE4C File Offset: 0x0004E04C
		internal void method_79(bool bool_6)
		{
			this.method_12(bool_6);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004FE60 File Offset: 0x0004E060
		private void method_80(string string_7)
		{
			if (!GClass84.smethod_334(string_7))
			{
				Transform transform = GClass84.smethod_981();
				if (transform)
				{
					Player player = GClass84.smethod_554(string_7);
					if (player)
					{
						Vector3 vector = player.transform.position;
						vector.y = transform.position.y;
						transform.LookAt(vector);
						NeckMouseRotator neckMouseRotator = GClass84.smethod_26();
						if (neckMouseRotator)
						{
							GameObject gameObject = new GameObject();
							if (gameObject)
							{
								try
								{
									vector = GClass84.smethod_272(player.transform, GClass84.GEnum47.const_1);
									float num = Vector2.Angle(new Vector2(GClass84.smethod_940(new Vector2(neckMouseRotator.transform.position.x - vector.x, neckMouseRotator.transform.position.z - vector.z)), neckMouseRotator.transform.position.y - vector.y), Vector2.right);
									neckMouseRotator.field_Private_Vector3_0 = new Vector3((vector.y < neckMouseRotator.transform.position.y) ? (-num) : num, 0f, 0f);
								}
								catch (Exception ex)
								{
									string[] array = new string[11];
									array[0] = "Exception";
									array[1] = " ";
									array[2] = "While";
									array[3] = " ";
									array[4] = "Looking";
									array[5] = " ";
									array[6] = "At";
									array[7] = " ";
									array[8] = "Player";
									array[9] = ": ";
									int num2 = 10;
									Exception ex2 = ex;
									array[num2] = ((ex2 != null) ? ex2.ToString() : null);
									GClass70.smethod_36(string.Concat(array), GClass70.Enum1.const_0);
								}
								Object.DestroyImmediate(gameObject, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00050020 File Offset: 0x0004E220
		private void method_81()
		{
			this.method_36();
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00050034 File Offset: 0x0004E234
		internal void method_82()
		{
			this.method_53();
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00050048 File Offset: 0x0004E248
		public override void vmethod_10()
		{
			this.method_31();
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0005005C File Offset: 0x0004E25C
		[CompilerGenerated]
		private void method_83()
		{
			this.method_9();
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00050070 File Offset: 0x0004E270
		private void method_84(string string_7)
		{
			this.method_28(string_7);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00050084 File Offset: 0x0004E284
		public override void vmethod_20(string string_7, string string_8)
		{
			this.method_39(string_7, string_8);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0005009C File Offset: 0x0004E29C
		internal void method_85()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
			GClass84.list_15.Add(new Action<string, List<string>>(this.vmethod_17));
			GClass84.list_17.Add(new Action<string, string>(this.vmethod_5));
			GClass84.list_18.Add(new Action<string, string>(this.vmethod_20));
			GClass84.list_19.Add(new Action<string, string>(this.vmethod_7));
			GClass84.list_20.Add(new Action<string, string>(this.vmethod_2));
			this.string_0 = "BotsManager";
			GClass61.smethod_1();
			this.string_1 = GClass61.gclass61_0.string_0;
			this.bool_1 = GClass61.gclass61_0.bool_0;
		}

		// Token: 0x04000A9D RID: 2717
		internal bool bool_0 = true;

		// Token: 0x04000A9E RID: 2718
		internal string string_1 = string.Empty;

		// Token: 0x04000A9F RID: 2719
		internal float float_0 = 1f;

		// Token: 0x04000AA0 RID: 2720
		internal float float_1 = 10f;

		// Token: 0x04000AA1 RID: 2721
		internal float float_2 = 10f;

		// Token: 0x04000AA2 RID: 2722
		internal float float_3 = 0f;

		// Token: 0x04000AA3 RID: 2723
		internal float float_4;

		// Token: 0x04000AA4 RID: 2724
		internal int int_0;

		// Token: 0x04000AA5 RID: 2725
		internal bool bool_1 = true;

		// Token: 0x04000AA6 RID: 2726
		internal string string_2 = string.Empty;

		// Token: 0x04000AA7 RID: 2727
		private string string_3 = string.Empty;

		// Token: 0x04000AA8 RID: 2728
		internal float float_5 = 1f;

		// Token: 0x04000AA9 RID: 2729
		internal float float_6 = 0.5f;

		// Token: 0x04000AAA RID: 2730
		internal string string_4 = string.Empty;

		// Token: 0x04000AAB RID: 2731
		internal bool bool_2 = false;

		// Token: 0x04000AAC RID: 2732
		internal string string_5 = string.Empty;

		// Token: 0x04000AAD RID: 2733
		internal string string_6 = string.Empty;

		// Token: 0x04000AAE RID: 2734
		internal List<GClass148.GStruct105> list_0 = new List<GClass148.GStruct105>();

		// Token: 0x04000AAF RID: 2735
		internal List<GClass148.GStruct106> list_1 = new List<GClass148.GStruct106>
		{
			new GClass148.GStruct106("wrld_9da1349e-470b-47fd-a9b5-bd57d49255e2", 25, "Spirits of the Sea 海の幽霊"),
			new GClass148.GStruct106("wrld_d29bb0d0-d268-42dc-8365-926f9d485505", 24, "Midnight Rooftop"),
			new GClass148.GStruct106("wrld_fae3fa95-bc18-46f0-af57-f0c97c0ca90a", 24, "The room of the rain"),
			new GClass148.GStruct106("wrld_4a65ba53-d8df-40a7-b67d-30c63bff0e95", 30, "Drinking Night"),
			new GClass148.GStruct106("wrld_e9a31011-8401-4b72-af0f-0d7595328c0c", 24, "Summer Solitude"),
			new GClass148.GStruct106("wrld_1252c162-3dfe-4790-b2d4-b1ff8c05530e", 30, "World Festi-VR Core"),
			new GClass148.GStruct106("wrld_6caf5200-70e1-46c2-b043-e3c4abe69e0f", 40, "The Great Pug"),
			new GClass148.GStruct106("wrld_c269a2e7-4688-4d81-9228-0391dea729e2", 18, "A Quiet Loft"),
			new GClass148.GStruct106("wrld_fac11e5f-1c73-4436-8936-a70b80961c5a", 20, "Rest and Sleep 寝る"),
			new GClass148.GStruct106("wrld_1c04a5cf-9fa2-4b68-842d-e04ef4faf33e", 40, "MOVIE ＆ CHILL （34‚000 Movies ＆ Shows）"),
			new GClass148.GStruct106("wrld_1b3b3259-0a1f-4311-984e-826abab6f481", 28, "Just B Club"),
			new GClass148.GStruct106("wrld_b02e2bbe-c0c4-46f9-aca2-1d0133eb374f", 25, "VRChat 한국어 튜토리얼（VRChat Korean Tutorial）"),
			new GClass148.GStruct106("wrld_bf51e60f-f372-48b1-a757-88ba8331d926", 20, "［JP］ Tutorial world"),
			new GClass148.GStruct106("wrld_d319c58a-dcec-47de-b5fc-21200116462c", 30, "FBT Heaven"),
			new GClass148.GStruct106("wrld_92bf5258-6dd3-4c7d-87da-7ae3c9ecf574", 20, "Sala Pak Jai"),
			new GClass148.GStruct106("wrld_c5303565-4b52-45b1-b2e7-5da1f99de2a6", 30, "Spanish Garden"),
			new GClass148.GStruct106("wrld_b155ff30-0bbf-486c-afc5-e7a05145387b", 40, "VirtualFurence Convention Hotel Estrel Berlin"),
			new GClass148.GStruct106("wrld_c591c76e-0ac2-413d-969e-b243ae943ace", 20, "Furry Talk and Chill"),
			new GClass148.GStruct106("wrld_cfb86e57-6227-4a00-b47e-43fd3f1bb105", 25, "UA High School - My Hero Academia"),
			new GClass148.GStruct106("wrld_c51677d1-dca4-42a2-a749-03d7b0f1a4e8", 40, "Never Have I Ever˸ Automated"),
			new GClass148.GStruct106("wrld_e5c30b56-efa8-42d5-a8d4-a2cca2bf3403", 30, "Just H Party 2.0"),
			new GClass148.GStruct106("wrld_566ff86a-bd70-4037-9bd5-7bba189e9267", 30, "5 Пятёрочка Russian"),
			new GClass148.GStruct106("wrld_6b77c061-a1bf-48eb-b107-c4d944490198", 16, "McDonald's"),
			new GClass148.GStruct106("wrld_20912bcb-2d65-4f85-a73e-86ebc44c94b6", 30, "［ Roleplay ］WIP ~ Five Nights at Freddy's 2 ~ V26.75 ［fnaf］"),
			new GClass148.GStruct106("wrld_6a10cd2b-7b72-4bb8-b2c5-3b9c11998efb", 24, "Genshin Impact Avatar World"),
			new GClass148.GStruct106("wrld_5e778b1b-88c7-4f44-8ff3-a3f289816fd0", 15, "Experimental ASL World （Udon）"),
			new GClass148.GStruct106("wrld_740c3481-9d4b-446e-8bb7-c94b00c53801", 40, "The Spider-Lair"),
			new GClass148.GStruct106("wrld_e0434a34-2f64-4e89-99da-8e3b4a86ffe4", 32, "NL Chess Club v0.9.1"),
			new GClass148.GStruct106("wrld_3c155837-d64a-47e3-a489-7418bfc1757b", 20, "Draw Your Weaponǃ"),
			new GClass148.GStruct106("wrld_b0624bf0-2d72-4e1d-aadc-59e4f72260ae", 18, "中文吧 ChineseBar Beta 3.19［CN＼HK＼TW］"),
			new GClass148.GStruct106("wrld_bd8aad50-b6ce-40e8-8b04-3221411e6bdd", 30, "Campamento Spanish 2.0 - Remix"),
			new GClass148.GStruct106("wrld_65ce4a4b-f66f-4844-adfe-072663394514", 32, "FurHub˸ The Furry Hub"),
			new GClass148.GStruct106("wrld_7730e944-0083-4400-857b-4dd32264d195", 32, "FurLounge"),
			new GClass148.GStruct106("wrld_831d080e-5577-4234-b436-0c1dec75b145", 40, "Club B33"),
			new GClass148.GStruct106("wrld_eeb5cb79-f78f-4a5b-a0be-e31a87c39303", 25, "Panaginip"),
			new GClass148.GStruct106("wrld_02cb84c8-446a-484b-b52b-2c1777e55f8d", 40, "Japan Street 0.198"),
			new GClass148.GStruct106("wrld_8ef393c0-a985-4d7e-90f0-33ab10d41ee3", 40, "Avatar Testingǃǃ"),
			new GClass148.GStruct106("wrld_94ef6736-f998-4099-b456-b3a444734013", 32, "Open Mic Night"),
			new GClass148.GStruct106("wrld_7e10376a-29b6-43af-ac5d-6eb72732e90c", 32, "Void Club"),
			new GClass148.GStruct106("wrld_c8c1c373-dd05-4095-a5f9-57cc1e2dcc33", 40, "Squid Game RL⁄GL")
		};

		// Token: 0x04000AB0 RID: 2736
		internal bool bool_3 = false;

		// Token: 0x04000AB1 RID: 2737
		internal List<GClass84.GStruct153> list_2 = new List<GClass84.GStruct153>();

		// Token: 0x04000AB2 RID: 2738
		internal int int_1 = 0;

		// Token: 0x04000AB3 RID: 2739
		internal int int_2 = 10;

		// Token: 0x04000AB4 RID: 2740
		internal float float_7 = 30f;

		// Token: 0x04000AB5 RID: 2741
		internal float float_8 = 45f;

		// Token: 0x04000AB6 RID: 2742
		internal float float_9 = 60f;

		// Token: 0x04000AB7 RID: 2743
		internal float float_10 = 10f;

		// Token: 0x04000AB8 RID: 2744
		internal float float_11 = 900f;

		// Token: 0x04000AB9 RID: 2745
		private float float_12 = 0f;

		// Token: 0x04000ABA RID: 2746
		private bool bool_4 = false;

		// Token: 0x04000ABB RID: 2747
		private bool bool_5 = false;

		// Token: 0x04000ABC RID: 2748
		private ApiWorld apiWorld_0 = new ApiWorld();

		// Token: 0x04000ABD RID: 2749
		private List<GClass84.GStruct154> list_3 = new List<GClass84.GStruct154>();

		// Token: 0x0200017E RID: 382
		public struct GStruct105
		{
			// Token: 0x06000F29 RID: 3881 RVA: 0x00050164 File Offset: 0x0004E364
			public GStruct105(string string_3, string string_4, string string_5)
			{
				this.string_0 = string_3;
				this.string_1 = string_4;
				this.string_2 = string_5;
			}

			// Token: 0x04000ABE RID: 2750
			public string string_0;

			// Token: 0x04000ABF RID: 2751
			public string string_1;

			// Token: 0x04000AC0 RID: 2752
			public string string_2;
		}

		// Token: 0x0200017F RID: 383
		public struct GStruct106
		{
			// Token: 0x06000F2A RID: 3882 RVA: 0x00050188 File Offset: 0x0004E388
			public GStruct106(string string_2, int int_1, string string_3)
			{
				this.string_0 = string_2;
				this.int_0 = int_1;
				this.string_1 = string_3;
			}

			// Token: 0x04000AC1 RID: 2753
			public string string_0;

			// Token: 0x04000AC2 RID: 2754
			public int int_0;

			// Token: 0x04000AC3 RID: 2755
			public string string_1;
		}

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		private sealed class Class88
		{
			// Token: 0x04000AC4 RID: 2756
			public GClass148 gclass148_0;

			// Token: 0x04000AC5 RID: 2757
			public string string_0;
		}

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		private sealed class Class89
		{
			// Token: 0x06000F2C RID: 3884 RVA: 0x000501AC File Offset: 0x0004E3AC
			internal void method_0(APIUser apiuser_0)
			{
				this.string_0 = GClass84.smethod_828(apiuser_0, "");
				this.string_1 = apiuser_0.statusDescription;
				if (this.string_1 != string.Empty)
				{
					if (GClass84.gclass152_0 != null && GClass84.gclass152_0.bool_1)
					{
						if (GClass84.gclass152_0.string_1 != string.Empty)
						{
							this.string_2 = Class186.smethod_9(this.string_1, GClass84.gclass152_0.string_1, GClass84.gclass152_0.bool_2);
						}
						else
						{
							this.string_2 = Class186.smethod_21(this.string_1);
						}
					}
					else
					{
						this.string_2 = this.string_1;
					}
				}
				for (int i = 0; i < this.class88_0.gclass148_0.list_0.Count; i++)
				{
					GClass148.GStruct105 gstruct = this.class88_0.gclass148_0.list_0[i];
					if (gstruct.string_1 == this.class88_0.string_0)
					{
						gstruct.string_0 = this.string_0;
						gstruct.string_2 = this.string_2;
						this.class88_0.gclass148_0.list_0[i] = gstruct;
					}
				}
			}

			// Token: 0x04000AC6 RID: 2758
			public string string_0;

			// Token: 0x04000AC7 RID: 2759
			public string string_1;

			// Token: 0x04000AC8 RID: 2760
			public string string_2;

			// Token: 0x04000AC9 RID: 2761
			public GClass148.Class88 class88_0;
		}
	}
}
