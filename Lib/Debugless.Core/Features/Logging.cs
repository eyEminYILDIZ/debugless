using System;
using Debugless.Core.Constants;

namespace Debugless.Core
{
	public static class DebuglessLogging
	{
		public static Debugl Information(this Debugl instance, string content, bool condition = true)
		{
			if (!condition)
				return instance;

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
