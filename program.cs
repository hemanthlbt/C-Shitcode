using System;
namespace bunty {
	class Public {
		static void Main(string[] args) {
			int i = 1;
			Console.WriteLine("Please choose your number");
			for (i=1;i<11;i++) {
				Console.WriteLine("NUMBER : " + i);
			}

			long  choose  = long.Parse(Console.ReadLine());

			if (choose  == 10) {
				Console.WriteLine("you've selected the number 10");

			}

			if (choose == 6305559662) {
				Console.WriteLine("Are you Hemanth kumar??");	
			}

			// Console.ReadLine();

			if (Console.ReadLine() == "yes") {
				Console.WriteLine("Welcome MR.Hemanth kumar");
			}

			else {
				Console.WriteLine("Invaled Entry");
			}
		}
	}
}