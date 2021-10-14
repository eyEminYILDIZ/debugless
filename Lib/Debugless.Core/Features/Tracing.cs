using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Debugless.Core.Constants;

namespace Debugless.Core
{
	public static class DebuglessTracing
	{
		public static Debugl CallInfo(this Debugl instance, [CallerMemberName] string caller = "", [CallerFilePath] string file = "", [CallerLineNumber] int lineNumber = 0)
		{
			var foregroundColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Blue;

			System.Console.WriteLine($"{ConstantTexts.LogPrefix} [{DateTime.Now.ToShortDateString()}-{DateTime.Now.ToShortTimeString()}] [Call Info]: File='{file}' | Method='{caller}' | Line Number='{lineNumber}'");

			Console.ForegroundColor = foregroundColor;
			return instance;
		}
	}
}
