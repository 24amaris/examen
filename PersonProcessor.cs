using System;
using examen.pb1;

namespace examen.pb1
{
	public static class PersonProcessor
	{
		public static Person GetOldestPerson(List<Person>people)
		{

            Person oldest = null;
            foreach (var person in people)
            {
                if (oldest == null || person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return oldest;
        }
	}
}