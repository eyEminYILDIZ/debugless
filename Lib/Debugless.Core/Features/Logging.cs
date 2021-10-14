using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Debugless.Core.Constants;

namespace Debugless.Core
{
	public static class DebuglessLogging
	{
		public static Debugl Information(this Debugl instance, string content)
		{
			// backgroundColor = Console.BackgroundColor;
			var foregroundColor = Console.ForegroundColor;

			//Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;

			System.Console.WriteLine($"{ConstantTexts.LogPrefix} [{DateTime.Now.ToShortDateString()}-{DateTime.Now.ToShortTimeString()}] [Info. Log]: {content}");

			//Console.BackgroundColor = backgroundColor;
			Console.ForegroundColor = foregroundColor;

			return instance;
		}
	}
}
