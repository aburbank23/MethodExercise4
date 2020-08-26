using System;

namespace MethodExercise4
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {

            var momAndPups = Sum(1, 5);
            Console.WriteLine($"There is a total of {momAndPups}!!!");


            Console.WriteLine($"Hello! My name is Computer. What's yours?");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Well, {firstName}, that's a wonderful name.");
            Console.WriteLine($"Could you tell me what you enjoy doing most?");
            var activity = Console.ReadLine();

            Console.WriteLine($"Cool! What do you love most about it?");
            var loveMost = Console.ReadLine();

            Console.WriteLine($"That makes me happy! Thank you for your time.");
        }
    }
}
