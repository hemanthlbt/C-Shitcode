using System;
namespace bunty {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("please enter your marks");
            int marks  = Convert.ToInt32(Console.ReadLine());

            if (marks>=90) {
                Console.WriteLine("A+");
            } 

            else if (marks >= 80) {
                Console.WriteLine("b+");
            }

            else {
                Console.WriteLine("pass");
            }
        }
    }
}