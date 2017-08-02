namespace InstructionSet
{
    using System;
    public class InstructionSet
    {
        public static void Main()
        {
            string operationCode = Console.ReadLine();
            long result = 0;
            while (operationCode != "END")
            {
                string[] codeArgs = operationCode.Split(' ');


                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }
                Console.WriteLine(result);
                operationCode = Console.ReadLine();
            }
        }
    }
}
