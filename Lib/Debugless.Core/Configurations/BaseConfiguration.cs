using System;
using Debugless.Core.Enums;

namespace Debugless.Core.Configurations
{
	public class BaseConfiguration
	{
		public static LogLevels Level { get; set; } = LogLevels.Information;
		public ConsoleColor DefaultColor { get; set; } = ConsoleColor.Blue;
	}
}