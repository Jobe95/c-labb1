using System;


namespace Miniräknare
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            bool isFinished = false;
            Calculator calc = new Calculator();

            while (isFinished == false)
            {
                {
                    Console.WriteLine(
                    "1. Add two numbers\n" +
                    "2.Multiply two numbers\n" +
                    "3.Sum the numbers between two numbers.\n" +
                    "4.Add number to memory\n" +
                    "5.Clear memory\n" +
                    "6.Print calculator contents.\n" +
                    "7.Quit");

                    var userAnswer = Console.ReadLine();

                    switch (userAnswer)
                    {
                        case "1":
                            Console.WriteLine("Skriv in två tal för att få summan");
                            calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                            calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Summan av dina tal: {calc.SumNumbers()}");
                            break;
                        case "2":
                            Console.WriteLine("Skriv in två tal för att miltiplicera dessa");
                            calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                            calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Summan av dina tal: {calc.MultiplyNumbers()}");
                            break;
                        case "3":
                            Console.WriteLine("Skriv in två nummer och få alla nummer emellan");
                            calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                            calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Här är summan emellan dina tal {calc.SumInBetween()}");
                            break;
                        case "4":
                            Console.WriteLine("Skriv in ett nummer och spara i minnet");
                            calc.NumberInMemory = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Number successfully added tomemory {calc.NumberInMemory}");
                            break;
                        case "5":
                            calc.NumberInMemory = 0;
                            Console.WriteLine("Number in memory cleared");
                            break;
                        case "6":
                            Console.WriteLine(calc);
                            break;
                        case "7":
                            Console.WriteLine("Goodbye");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Skriv in en siffra mellan 1-7");
                            break;
                    }
                }
            }
        }
    }
}