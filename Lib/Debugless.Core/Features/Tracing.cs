using System;
using System.Runtime.CompilerServices;

namespace Debugless.Core
{
	public static class DebuglessTracing
	{
		public static Debugl CallInfo(this Debugl instance, [CallerMemberName] string caller = "", [CallerFilePath] string file = "", [CallerLineNumber] int lineNumber = 0)
		{
			var foregroundColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Magenta;

			var relativeFilePath = file?.Replace(Environment.CurrentDirectory, "");

			System.Console.WriteLine($"Call Info: File='{relativeFilePath}' | Method='{caller}' | Line Number='{lineNumber}'");

			Console.ForegroundColor = foregroundColor;
			return instance;
		}
	}
}
