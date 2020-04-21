using System;

namespace Lab1_4_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            string answer = "Yes";

            while (answer == "Yes")
            { 
            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("Area:" + area);

            double perimiter = (length * 2) + (width * 2);
            Console.WriteLine("Perimeter:" + perimiter);

             Console.Write("Enter Height: ");
             double height = double.Parse(Console.ReadLine());

             double volume = (length * width * height);

             Console.WriteLine("Volume: " + volume);

            Console.WriteLine("Continue Yes/No");
            answer = Console.ReadLine();

            }
            
        }
    }
}
