using System;
using Debugless.Core;
using Debugless.Example.Models;

namespace Debugless.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			var student = new Student()
			{
				Id = 0,
				FirstName = "John",
				LastName = "Doe",
				Age = 29,
				Gender = Genders.Male,
			};

			var debugless = new Debugl();
			debugless.Information("Execution Started...");
			debugless.DumpObject(student);
			debugless.Information("Execution Finished").CallInfo();
		}
	}
}
