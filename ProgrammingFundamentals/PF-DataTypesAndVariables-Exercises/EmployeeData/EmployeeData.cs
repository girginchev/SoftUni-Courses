namespace EmployeeData
{
    using System;
    class EmployeeData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personelID = long.Parse(Console.ReadLine());
            int employeeUniqueNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personelID}");
            Console.WriteLine($"Unique Employee number: {employeeUniqueNumber}");
        }
    }
}
