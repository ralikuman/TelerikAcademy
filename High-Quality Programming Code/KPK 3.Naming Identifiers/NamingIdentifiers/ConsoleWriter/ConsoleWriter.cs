namespace ConsoleWriter
{
    using System;
    using System.Linq;

    public class ConsoleWriter
    {
        // CAPITAL_LETTERS for const fields
        public const int MAX_COUNT = 6;

        public static void Main()
        {
            PrintVariable variable = new PrintVariable();
            variable.PrintBooleanVariable(true);
        }

        public class PrintVariable
        {
            public void PrintBooleanVariable(bool variable)
            {
                string printValue = variable.ToString();
                Console.WriteLine(printValue);
            }
        }
    }
}
