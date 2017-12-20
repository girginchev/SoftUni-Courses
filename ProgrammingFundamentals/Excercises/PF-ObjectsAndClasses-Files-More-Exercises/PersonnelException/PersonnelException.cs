namespace PersonnelException
{
    using System;

    public class PersonnelException
    {
        public static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new PersonException();
                    }
                    Console.WriteLine(number);
                }
            }
            catch (PersonException pe)
            {
                Console.WriteLine(pe.Message);
                return;
            }
        }
    }
}
