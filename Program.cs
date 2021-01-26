using System;

namespace New_VSCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Average Calculator"; 
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.BackgroundColor = ConsoleColor.Black; 
          
          
           double num01;
           double num02; 
           double numb03; 


           Console.Write("Input a number: ");

           num01 = Convert.ToDouble( Console.ReadLine()  );

           Console.Write("Input a second number:");

           num02 = Convert.ToDouble( Console.ReadLine() );

           Console.Write("Insert a third number: ");

           numb03 = Convert.ToDouble( Console.ReadLine( ));

            double result = (num01 + num02 + numb03) / 3; 
            Console.WriteLine("The result is " + result );

            Console.ReadKey(); 
        }
    }
}
