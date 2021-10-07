using System;

namespace ExponentsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)

            {
                

                string result = UserInput("Hello! Welcome to the squares and cubes project! Please provide an integer.");
                int number = int.Parse(result);
                Console.WriteLine(number);

                double square = GetPower(number, 2);
                Console.WriteLine($"Your input squared: {square}");


                double cubed = GetPower(number, 3);
                Console.WriteLine($"Your input cubed: {cubed}");

                Console.WriteLine("Number Squared Cubed");
                Console.WriteLine("--------------------");
                for(var i = 1; i <= number; i++)
                {
                    double squared = GetPower(i, 2);
                    double cube = GetPower(i, 3);
                    Console.WriteLine($"{i}       {squared}       {cube}");
                }
                
                goOn = Continue();
                

            }
            

        }
        public static string UserInput(string entry)
        {
            Console.WriteLine(entry);
            string output = Console.ReadLine();
            return output;
            
        }

        public static bool Continue()
        {
            string answer = UserInput("Would you like continue? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if(answer == "n")
            {
                Console.WriteLine("Good bye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try that again");
                return Continue();
            }
        }
        
        public static double GetPower(double number, double power)
        {
            return Math.Pow(number, power);
        }


        

        
            



        
        
       


    }
}
