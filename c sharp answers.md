
```md
# How to add 2 integers in c# by taking input from the user?
```


```cs


// How to add 2 integers in c# by taking input from the user.
using System;

namespace ubuntu {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Enter your number");
			int  num1  =Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("your number is :" + num1);


			Console.WriteLine("Please enter your number 2");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("your number is :" + num2);
            int sum = num1 + num2;
            Console.WriteLine("the sum of the two numbers is : " + sum );




		}
	}
}


```