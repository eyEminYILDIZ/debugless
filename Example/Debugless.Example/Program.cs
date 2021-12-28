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
				BirthDate = DateTime.SpecifyKind(DateTime.Parse("1994.01.01 10:00:00"), DateTimeKind.Local),
				Gender = Genders.Male,
				Parent = new Parent()
				{
					NameSurname = "Marry Chann",
					TelephoneNumber = "+1234567890"
				}
			};

			var debugless = new Debugl();
			debugless.Information("Execution Started...");
			debugless.DumpObject(student).CallInfo();
			debugless.Information("Execution Finished").CallInfo();
		}
	}
}
