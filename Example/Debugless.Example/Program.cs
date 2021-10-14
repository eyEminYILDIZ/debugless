using System;
using Debugless.Core;

namespace Debugless.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			var debuglessLogger = new Debugl();
			debuglessLogger.Information("Content Writed").CallInfo();
		}
	}
}
