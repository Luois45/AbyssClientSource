using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Mono.CSharp;

namespace ns526
{
	// Token: 0x0200038D RID: 909
	public class GClass194 : Evaluator, IDisposable
	{
		// Token: 0x060049F0 RID: 18928 RVA: 0x00119900 File Offset: 0x00117B00
		public void Dispose()
		{
			this.method_6();
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00119914 File Offset: 0x00117B14
		private void method_0(object sender, AssemblyLoadEventArgs e)
		{
			this.method_1(sender, e);
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0011992C File Offset: 0x00117B2C
		private void method_1(object sender, AssemblyLoadEventArgs e)
		{
			this.method_5(sender, e);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00119944 File Offset: 0x00117B44
		private static void smethod_0(Action<Assembly> action_0)
		{
			GClass194.smethod_1(action_0);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00119958 File Offset: 0x00117B58
		private static void smethod_1(Action<Assembly> action_0)
		{
			GClass194.smethod_3(action_0);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x0011996C File Offset: 0x00117B6C
		private void method_2(Assembly assembly_0)
		{
			this.method_3(assembly_0);
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00119980 File Offset: 0x00117B80
		public GClass194(TextWriter textWriter_1) : base(GClass194.smethod_2(textWriter_1))
		{
			GClass194.textWriter_0 = textWriter_1;
			GClass194.smethod_0(new Action<Assembly>(this.method_4));
			AppDomain.CurrentDomain.AssemblyLoad += this.method_0;
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00119A14 File Offset: 0x00117C14
		private static CompilerContext smethod_2(TextWriter textWriter_1)
		{
			GClass194.streamReportPrinter_0 = new StreamReportPrinter(textWriter_1);
			CompilerSettings compilerSettings = new CompilerSettings
			{
				Version = 100,
				GenerateDebugInfo = false,
				StdLib = true,
				Target = 0,
				WarningLevel = 0,
				EnhancedWarnings = false
			};
			return new CompilerContext(compilerSettings, GClass194.streamReportPrinter_0);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00119A6C File Offset: 0x00117C6C
		private static void smethod_3(Action<Assembly> action_0)
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				string name = assembly.GetName().Name;
				if (!GClass194.hashSet_0.Contains(name))
				{
					action_0(assembly);
				}
			}
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00119AB8 File Offset: 0x00117CB8
		private void method_3(Assembly assembly_0)
		{
			string name = assembly_0.GetName().Name;
			if (!(name == "completions"))
			{
				base.ReferenceAssembly(assembly_0);
			}
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x00119AE8 File Offset: 0x00117CE8
		private void method_4(Assembly assembly_0)
		{
			this.method_2(assembly_0);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00119AFC File Offset: 0x00117CFC
		private void method_5(object sender, AssemblyLoadEventArgs e)
		{
			string name = e.LoadedAssembly.GetName().Name;
			if (!GClass194.hashSet_0.Contains(name))
			{
				this.method_4(e.LoadedAssembly);
			}
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00119B34 File Offset: 0x00117D34
		internal void method_6()
		{
			this.method_7();
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00119B48 File Offset: 0x00117D48
		internal void method_7()
		{
			AppDomain.CurrentDomain.AssemblyLoad -= this.method_0;
			GClass194.textWriter_0.Dispose();
		}

		// Token: 0x04001CD9 RID: 7385
		private static readonly HashSet<string> hashSet_0 = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
		{
			"mscorlib",
			"System.Core",
			"System",
			"System.Xml"
		};

		// Token: 0x04001CDA RID: 7386
		internal static TextWriter textWriter_0;

		// Token: 0x04001CDB RID: 7387
		internal static StreamReportPrinter streamReportPrinter_0;
	}
}
