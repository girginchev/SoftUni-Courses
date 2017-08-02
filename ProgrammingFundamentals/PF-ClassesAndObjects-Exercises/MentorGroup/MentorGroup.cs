using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {

            var input = Console.ReadLine();
            var student = new Student();
            var students = new SortedDictionary<string, Student>();

            while (input != "end of dates")
            {
                var entry = input.Split(' ');
                var name = entry[0];
                if (entry.Length > 1)
                {
                    var dates = entry[1].Split(',').Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    student = new Student();
                    student.Dates = dates;
                    if (!students.ContainsKey(name))
                    {
                        students[name] = student;
                    }
                    else
                    {
                        students[name].Dates.AddRange(dates);
                    }
                }
                else
                {
                    student = new Student();
                    students.Add(name,student);
                }
                input = Console.ReadLine();

            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                var entry = input.Split('-');
                var name = entry[0];
                if (entry.Length > 1)
                {
                    var comment = entry[1];

                    if (students.Keys.Contains(name))
                    {
                        students[name].Comments.Add(comment);
                    }

                }
                input = Console.ReadLine();
            }
            foreach (var pair in students)
            {
                Console.WriteLine($"{pair.Key}");
                Console.WriteLine("Comments:");
                foreach (var item in pair.Value.Comments)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var item in pair.Value.Dates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item:dd/MM/yyyy}");
                }
            }
        }
    }
}
