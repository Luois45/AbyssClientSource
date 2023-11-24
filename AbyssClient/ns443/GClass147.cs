using System;
using System.Runtime.CompilerServices;
using ns185;
using ns241;
using ns425;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.UI;

namespace ns443
{
	// Token: 0x02000179 RID: 377
	public class GClass147 : GClass130
	{
		// Token: 0x06000E90 RID: 3728 RVA: 0x0004D5BC File Offset: 0x0004B7BC
		private void method_2()
		{
			if (Time.time > this.float_0)
			{
				this.float_0 = Time.time + 30f;
				Il2CppArrayBase<UiUserList> il2CppArrayBase = Resources.FindObjectsOfTypeAll<UiUserList>();
				if (il2CppArrayBase != null)
				{
					for (int i = 0; i < il2CppArrayBase.Count; i++)
					{
						UiUserList uiUserList = il2CppArrayBase[i];
						if (uiUserList)
						{
							uiUserList.Method_Public_Void_1();
							uiUserList.Method_Public_Void_0();
						}
					}
				}
			}
			else
			{
				float num = this.float_0 - Time.time;
				GClass70.smethod_38(string.Concat(new string[]
				{
					"API Call Is On Cooldown! Please Wait",
					" ",
					Math.Floor((double)num).ToString(),
					" ",
					"Seconds Before Trying Again!"
				}), GClass70.Enum1.const_0);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0004D680 File Offset: 0x0004B880
		internal void method_3()
		{
			this.method_6();
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0004D694 File Offset: 0x0004B894
		public override void vmethod_23()
		{
			this.method_8();
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0004D6A8 File Offset: 0x0004B8A8
		[CompilerGenerated]
		private void method_4()
		{
			this.method_10();
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0004D6BC File Offset: 0x0004B8BC
		public void method_5()
		{
			this.method_3();
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0004D6D0 File Offset: 0x0004B8D0
		internal void method_6()
		{
			GameObject gameObject = GameObject.Find(string.Concat(new string[]
			{
				GClass84.smethod_8(),
				"/",
				"Current",
				" ",
				"Status",
				"/",
				"Status",
				"Button"
			}));
			if (gameObject)
			{
				GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject.transform.GetComponentInChildren<Button>().gameObject);
				if (gameObject2)
				{
					gameObject2.name = "SocialRefreshButton";
					gameObject2.transform.localPosition += new Vector3(1255f, 0f, 0f);
					gameObject2.GetComponentInChildren<Text>().text = "Refresh";
					GClass84.smethod_243(gameObject2.GetComponentInChildren<Button>(), new Action(this.method_4));
					GameObject gameObject3 = GameObject.Find(string.Concat(new string[]
					{
						GClass84.smethod_8(),
						"/",
						"Current",
						" ",
						"Status"
					}));
					gameObject2.transform.SetParent(gameObject3.transform, false);
					this.bool_1 = true;
				}
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0004D810 File Offset: 0x0004BA10
		public override void vmethod_19()
		{
			this.method_9();
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0004D824 File Offset: 0x0004BA24
		internal void method_7()
		{
			if (this.bool_0 && !this.bool_1)
			{
				this.method_5();
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0004D84C File Offset: 0x0004BA4C
		internal void method_8()
		{
			this.method_11();
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0004D860 File Offset: 0x0004BA60
		internal void method_9()
		{
			this.method_7();
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0004D874 File Offset: 0x0004BA74
		private void method_10()
		{
			this.method_2();
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0004D888 File Offset: 0x0004BA88
		internal void method_11()
		{
			GClass84.list_6.Add(new Action(this.vmethod_19));
		}

		// Token: 0x04000A8C RID: 2700
		public bool bool_0 = true;

		// Token: 0x04000A8D RID: 2701
		public bool bool_1 = false;

		// Token: 0x04000A8E RID: 2702
		public float float_0 = 0f;
	}
}
