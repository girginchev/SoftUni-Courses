using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            var excellentStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var studentsAsString = Console.ReadLine().Split().ToList();
                var name = studentsAsString[0];
                var grades = studentsAsString.Skip(1).Select(double.Parse).ToList();
                var students = new Student();
                students.Name = name;
                students.Grades = grades;
                
                if (students.AverageGrade >= 5.0)
                {
                    excellentStudents.Add(students);
                }
            }

            foreach (var item in excellentStudents.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade:F2}");
            }
        }
    }
}
