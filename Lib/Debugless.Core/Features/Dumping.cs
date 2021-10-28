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

			// Recursively Dump Object Properties
			DebuglessDumping.RecursivelyDumpObject(objectForDump, 1);

			System.Console.WriteLine("}");

			Console.ForegroundColor = foregroundColor;
			return instance;
		}

		private static void RecursivelyDumpObject(object objectForDump, int tabCount)
		{
			var tabAsString = DebuglessDumping.GetTabsAsString(tabCount);
			var propertyInfos = objectForDump.GetType().GetProperties();

			foreach (var propertyInfo in propertyInfos)
			{
				if (propertyInfo.PropertyType == typeof(string))
				{
					var value = (string)propertyInfo.GetValue(objectForDump);
					var message = $"{tabAsString}{propertyInfo.Name}: \"{value}\"";
					System.Console.WriteLine(message);
				}
				else if (propertyInfo.PropertyType == typeof(int))
				{
					var value = (int)propertyInfo.GetValue(objectForDump);
					var message = $"{tabAsString}{propertyInfo.Name}: {value}";
					System.Console.WriteLine(message);
				}
				else if (propertyInfo.PropertyType.IsEnum)
				{
					var message = $"{tabAsString}{propertyInfo.Name}: {propertyInfo.GetValue(objectForDump)}";
					System.Console.WriteLine(message);
				}
				else if (propertyInfo.PropertyType.IsClass)
				{
					var childObject = propertyInfo.GetValue(objectForDump);
					System.Console.WriteLine($"{tabAsString}{propertyInfo.Name}:" + " {");

					// Recursively Dump Object Properties
					DebuglessDumping.RecursivelyDumpObject(childObject, tabCount + 1);

					System.Console.WriteLine($"{tabAsString}" + "}");
				}
				else
				{
					var message = $"{tabAsString}{propertyInfo.Name}: {propertyInfo.GetValue(objectForDump)}";
					System.Console.WriteLine(message);
				}
			}
		}

		private static string GetTabsAsString(int tabCount)
		{
			var tabsAsString = "";
			for (var i = 0; i < tabCount; i++)
				tabsAsString += "\t";

			return tabsAsString;
		}
	}
}
