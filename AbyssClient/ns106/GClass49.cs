using System;
using ns185;
using ns241;
using UnityEngine;
using VRC.Core;

namespace ns106
{
	// Token: 0x02000090 RID: 144
	public class GClass49
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x00011680 File Offset: 0x0000F880
		internal static bool smethod_0(GameObject gameObject_0)
		{
			Transform transform = gameObject_0.transform;
			PipelineManager component = gameObject_0.GetComponent<PipelineManager>();
			string string_;
			if (component)
			{
				string_ = component.blueprintId;
			}
			else
			{
				string_ = "Avatar";
			}
			ConsoleColor consoleColor_ = GClass84.smethod_1571(null, true);
			if (GClass84.gclass145_0.bool_16)
			{
				try
				{
					GClass84.gclass145_0.method_537(transform, string_);
				}
				catch (Exception ex)
				{
					GClass70.smethod_36("[Error]" + " " + ex.Message, GClass70.Enum1.const_0);
				}
			}
			if (GClass84.gclass145_0.bool_17)
			{
				try
				{
					GClass84.gclass145_0.method_51(transform, string_);
				}
				catch (Exception ex2)
				{
					GClass70.smethod_36("[Error]" + " " + ex2.Message, GClass70.Enum1.const_0);
				}
			}
			bool result;
			if (!GClass84.gclass145_0.bool_1)
			{
				result = true;
			}
			else
			{
				if (GClass84.gclass145_0.bool_18)
				{
					try
					{
						GClass84.gclass145_0.method_245(transform, string_);
					}
					catch (Exception ex3)
					{
						GClass70.smethod_36("[Error]" + " " + ex3.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_116)
				{
					try
					{
						GClass84.gclass145_0.method_472(transform, string_, consoleColor_, true);
					}
					catch (Exception ex4)
					{
						GClass70.smethod_36("[Error]" + " " + ex4.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_94)
				{
					try
					{
						GClass84.gclass145_0.method_251(transform, string_, consoleColor_, true, false);
					}
					catch (Exception ex5)
					{
						GClass70.smethod_36("[Error]" + " " + ex5.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_123)
				{
					try
					{
						GClass84.gclass145_0.method_42(transform, string_, consoleColor_, true, false);
					}
					catch (Exception ex6)
					{
						GClass70.smethod_36("[Error]" + " " + ex6.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_130)
				{
					try
					{
						GClass84.gclass145_0.method_361(transform, string_, consoleColor_, true, false);
					}
					catch (Exception ex7)
					{
						GClass70.smethod_36("[Error]" + " " + ex7.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_84)
				{
					try
					{
						GClass84.gclass145_0.method_140(transform, string_, consoleColor_, false, false, true);
					}
					catch (Exception ex8)
					{
						GClass70.smethod_36("[Error]" + " " + ex8.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_21)
				{
					try
					{
						GClass84.gclass145_0.method_307(transform, string_);
					}
					catch (Exception ex9)
					{
						GClass70.smethod_36("[Error]" + " " + ex9.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_22)
				{
					try
					{
						GClass84.gclass145_0.method_271(transform, string_);
					}
					catch (Exception ex10)
					{
						GClass70.smethod_36("[Error]" + " " + ex10.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_23)
				{
					try
					{
						GClass84.gclass145_0.method_236(transform, string_);
					}
					catch (Exception ex11)
					{
						GClass70.smethod_36("[Error]" + " " + ex11.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_24)
				{
					try
					{
						GClass84.gclass145_0.method_487(transform, string_);
					}
					catch (Exception ex12)
					{
						GClass70.smethod_36("[Error]" + " " + ex12.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_25)
				{
					try
					{
						GClass84.gclass145_0.method_389(transform, string_, consoleColor_, false, false, true, null);
					}
					catch (Exception ex13)
					{
						GClass70.smethod_36("[Error]" + " " + ex13.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_26)
				{
					try
					{
						GClass84.gclass145_0.method_520(transform, string_, consoleColor_, false, false, true, null);
					}
					catch (Exception ex14)
					{
						GClass70.smethod_36("[Error]" + " " + ex14.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_28)
				{
					try
					{
						GClass84.gclass145_0.method_193(transform, string_, consoleColor_, false, false, true, null);
					}
					catch (Exception ex15)
					{
						GClass70.smethod_36("[Error]" + " " + ex15.Message, GClass70.Enum1.const_0);
					}
				}
				if (GClass84.gclass145_0.bool_30)
				{
					try
					{
						GClass84.gclass145_0.method_457(transform, string_, consoleColor_, false, false, true, false, null);
					}
					catch (Exception ex16)
					{
						GClass70.smethod_36("[Error]" + " " + ex16.Message, GClass70.Enum1.const_0);
					}
				}
				result = true;
			}
			return result;
		}
	}
}
