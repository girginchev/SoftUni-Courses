using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var lines = File.ReadAllText(@"../../input.txt").Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var students = new List<Student>();
            foreach (var line in lines)
            {
                var tokens = line.Split();
                var name = tokens[0];
                var grades = new List<double>();
                for (int i = 1; i < tokens.Length; i++)
                {
                    grades.Add(double.Parse(tokens[i]));
                }
                var student = new Student()
                {
                    Name = name,
                    Grades = grades
                };
                students.Add(student);
            }
            foreach (var student in students.OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade))
            {
                if (student.AverageGrade >= 5.00)
                {
                    var restult = string.Format($"{student.Name} - {student.AverageGrade:F2}{Environment.NewLine}");
                    File.AppendAllText(@"..\..\result.txt", restult);
                }

            }
        }
    }
}
