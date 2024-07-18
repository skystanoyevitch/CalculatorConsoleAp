using System.Text.RegularExpressions;
using System.Xml.XPath;
namespace CalculatorProgram;




class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine($"-----------------------\n");

        Calculator calculator = new();

        while (!endApp)
        {
            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput1 = Console.ReadLine();
            }


            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput2 = Console.ReadLine();
            }


            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string? op = Console.ReadLine();


            if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
            {
                Console.WriteLine($"Error: Unrecognized Input");

            }

            else
            {
                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
            }
            Console.WriteLine("------------------------\n");


            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }

        return;
    }
}














// double num1 = 0; double num2 = 0;





// Console.WriteLine($"Type another number and then press enter");
// num1 = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"Type another number, and then press enter");
// num2 = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"Choose and Option from the following list:");
// Console.WriteLine($"\ta - Add");
// Console.WriteLine($"\ts - Substract");
// Console.WriteLine($"\tm - Multiply");
// Console.WriteLine($"\td - Devide");
// Console.WriteLine($"Your Option? ");



// switch (Console.ReadLine())
// {
//     case "a":
//         Console.WriteLine($"Your Result: {num1} + {num2} = " + (num1 + num2));
//         break;
//     case "s":
//         Console.WriteLine($"Your Result: {num1} - {num2} = " + (num1 - num2));

//         break;
//     case "m":
//         Console.WriteLine($"Your Result: {num1} * {num2} = " + (num1 * num2));

//         break;
//     case "d":
//         while (num2 == 0)
//         {
//             Console.WriteLine($"Enter a non-zero divisor");
//             num2 = Convert.ToDouble(Console.ReadLine());

//         }
//         Console.WriteLine($"Your Result: {num1} / {num2} = " + (num1 / num2));
//         break;
// }

// Console.Write($"Press any key to close the console app...");
// Console.ReadKey();










