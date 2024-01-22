using System;
using examen.pb1;

namespace examen.pb1
{
	public class Person
	{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int YearOfBirth { get; set; }
			public int Age => DateTime.Now.Year - YearOfBirth;

			public Person(string firstName, string lastName, int yearOfBirth)
			{
				FirstName = firstName;
				LastName = lastName;
				YearOfBirth = yearOfBirth;
			}
	}
}