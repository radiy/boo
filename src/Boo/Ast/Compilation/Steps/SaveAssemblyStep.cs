using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Boo.Ast;
using Boo.Ast.Compilation;

namespace Boo.Ast.Compilation.Steps
{
	public class SaveAssemblyStep : AbstractCompilerStep
	{
		public override void Run()
		{
			if (_context.Errors.Count > 0)
			{
				return;
			}
			
			AssemblyBuilder builder = AssemblySetupStep.GetAssemblyBuilder(_context);
			builder.Save(Path.GetFileName(CompilerParameters.OutputAssembly));
		}	
	}
}
