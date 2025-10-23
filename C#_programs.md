//fizzbuzz;
//Print the numbers from 1 to 30.
//Print fizz if the number is divisable by 3.
//Print buzz if the number is divisable by 5.
//Print fizzbuzz if the number is divisable by both the numbers.

using System;
namespace hemanth{
    class PublicClass{
        static void Main(string[] args){
            Console.WriteLine("fizzbuzz Program!");
            for (int num =1; num<=100; num++) {
                if ( num  % 3==0 && num % 5==0) {
                    Console.WriteLine("Fizzbuzz");
                }
                else if(num % 3==0) {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5==0){
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(num);
                }
                }
            }
    }
}



