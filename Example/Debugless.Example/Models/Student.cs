using System;

namespace Debugless.Example.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Genders Gender { get; set; }

		public Parent Parent { get; set; }
	}

	public class Parent
	{
		public string NameSurname { get; set; }
		public string TelephoneNumber { get; set; }
	}

	public enum Genders
	{
		Male,
		Female,
	}
}
