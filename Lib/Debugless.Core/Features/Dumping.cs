using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Debugless.Core.Constants;

namespace Debugless.Core
{
	public static class DebuglessDumping
	{
		public static Debugl DumpObject(this Debugl instance, object objectForDump)
		{
			var foregroundColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Blue;

			var className = objectForDump.GetType().FullName;
			System.Console.WriteLine($"{ConstantTexts.LogPrefix} [{DateTime.Now.ToShortDateString()}-{DateTime.Now.ToShortTimeString()}] [Obj. Dump]: {className}");

			Console.ForegroundColor = ConsoleColor.Green;
			System.Console.WriteLine("{");

			var propertyInfos = objectForDump.GetType().GetProperties();
			foreach (var propertyInfo in propertyInfos)
			{
				if (propertyInfo.PropertyType == typeof(string))
				{
					var message = $"\t{propertyInfo.Name}: \"{(string)propertyInfo.GetValue(objectForDump)}\"";
					System.Console.WriteLine(message);
				}
				else
				{
					var message = $"\t{propertyInfo.Name}: {propertyInfo.GetValue(objectForDump)}";
					System.Console.WriteLine(message);
				}
			}

			System.Console.WriteLine("}");

			Console.ForegroundColor = foregroundColor;
			return instance;
		}
	}
}
