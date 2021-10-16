﻿using System;
using Debugless.Core;

namespace Debugless.Example.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Genders Gender { get; set; }
	}

	public enum Genders
	{
		Male,
		Female,
	}
}