using System;

namespace MethodExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
                    
            //Write out story using string interpolation with the returned variables
            Console.WriteLine($"Hi my name is {FName()}, and I love the color {FColor()}.  " +
            $"My favorite animal is a {Animal()} because they are so loyal.  " +
            $"My favorite music band is {Band()}, because they're music usually fits my mood.");

            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Subtract(20, 3));
            Console.WriteLine(Multiply(10, 5));
            Console.WriteLine(Divide(66, 3));
            Console.WriteLine(Modulus(100, 3));
        }

        public static string FName()
        {
            Console.WriteLine("What is your name?");
            string fName = Console.ReadLine();
            return fName;
        }

        public static string FColor()
        {
            Console.WriteLine("What is your favorie color?");

            string color = Console.ReadLine();

            return color;
        }

        public static string Animal()
        {
            Console.WriteLine("What is your favorite animal?");

            string animal = Console.ReadLine();
            return animal;
        }
        
        public static string Band()
        {
            Console.WriteLine("What is your favorite band?");

            string band = Console.ReadLine();
            return band;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }


    
}
