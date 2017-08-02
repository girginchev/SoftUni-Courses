namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
    public class OrderByAge
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();
            while (input != "End")
            {
                var tokens = input.Split();
                var name = tokens[0];
                var id = tokens[1];
                var age = int.Parse(tokens[2]);
                var person = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };
                people.Add(person);
                input = Console.ReadLine();
            }
            foreach (var p in people.OrderBy(p=>p.Age))
            {
                Console.WriteLine($"{p.Name} with ID: {p.ID} is {p.Age} years old.");
            }
        }
    }
}
