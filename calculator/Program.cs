using System;
namespace bunty {
    class Public {
        static void Main(string[] args) {
            string value;

            do {
                int result;
                Console.WriteLine("Enter numner one");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number two");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your symbol(+,-,*,/):");
                string Symbol = Console.ReadLine();

                switch (Symbol) {
                    case "+" :
                    result = n1 + n2;
                    Console.WriteLine("Addition = "+result);
                    break;

                    case "-" :
                    result = n1-n2;
                    Console.WriteLine("Subtraction  = "+result);
                    break;

                    case "*" :
                    result = n1*n2;
                    Console.WriteLine("multiplication = "+result);
                    break;

                    case "/": 
                    result = n1/n2;
                    Console.WriteLine("division = "+result);
                    break;

                    default:
                    Console.WriteLine("Invalid number");
                    break;
                }

                // Console.ReadLine();
                Console.WriteLine("Do you want to continue");
                value  = Console.ReadLine();
            }

            while (value =="y" || value == "y");
        }
    }
}