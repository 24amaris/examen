namespace examen.pb1;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        Console.WriteLine("Numărul de persoane este:");
        int numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"Persoana {i + 1}:");
            Console.Write("Prenume: ");
            string firstName = Console.ReadLine();
            Console.Write("Nume de familie: ");
            string lastName = Console.ReadLine();
            Console.Write("Anul nașterii: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            people.Add(new Person(firstName, lastName, yearOfBirth));
        }

        Person oldestPerson = PersonProcessor.GetOldestPerson(people);
        if (oldestPerson != null)
        {
            Console.WriteLine($"Persoana cu vârsta cea mai mare: {oldestPerson.FirstName} {oldestPerson.LastName}, Vârstă: {oldestPerson.Age}");
        }
        else
        {
            Console.WriteLine("Nu există persoane în lista introdusă.");
        }
    }
}