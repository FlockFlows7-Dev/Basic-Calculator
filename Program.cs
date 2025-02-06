using System;

class Program
{
    public static void Main(string[] args)
    {

        double FirstNum;
        double SecondNum;
        double sum;
        string operation;

        while (true)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("Enter first number");
            FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter Second number");
            SecondNum = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("(+)(-)(*)(/)");
            operation = Console.ReadLine();
            if (operation == "+")
            {
                sum = FirstNum + SecondNum;
                Console.WriteLine(sum);
                AskToContinue();
            }
            else if (operation == "-")
            {
                sum = FirstNum - SecondNum;
                Console.WriteLine(sum);
                AskToContinue();
            }
            else if (operation == "*")
            {
                sum = FirstNum * SecondNum;
                Console.WriteLine(sum);
                AskToContinue();
            }
            else if (operation == "/")
            {
                if (SecondNum == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    AskToContinue();
                }
                else
                {
                    sum = FirstNum / SecondNum;
                    Console.WriteLine("Result: " + sum);
                    AskToContinue();
                }
            }
        }
    }

    static void AskToContinue()
    {
        Console.WriteLine("Would you like to keep using the calculator? (Press enter for Yes.)");
        Console.ReadLine();
        Console.Clear();
    }
}