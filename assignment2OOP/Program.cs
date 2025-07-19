namespace assignment2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Person Struct

            Person[] people = new Person[3];
            people[0] = new Person { Name = "Sara", Age = 24 };
            people[1] = new Person { Name = "Mohamed", Age = 24 };
            people[2] = new Person { Name = "Ali", Age = 22 };

            // Display details of all persons
            Console.WriteLine("Person Details:");
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion
        }
    }
}
