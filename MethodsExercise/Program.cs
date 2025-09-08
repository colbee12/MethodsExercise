using System.Net.Security;

namespace MethodsExercise
{
    public class Program
    {
        public static void GatheringUsersInfo()
        {
            //gathering user info for story
            Console.WriteLine("what's your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"hello, {username}");
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"what is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"what is your band?");
            string band = Console.ReadLine();
            Console.WriteLine($"your name is {username}. your favorite coler is {color}. your favorite animal is {animal}. your favorite band is {band}");
            Console.WriteLine("Thanks for playing!");
        }
        static void Main(string[] args)
        {
           GatheringUsersInfo();
            
            Console.WriteLine(AddTwoNums(20,20));
            Console.WriteLine(SubtractTwoNums(34,64));
            Console.WriteLine(DivideTwoNums(200,20));
            Console.WriteLine(MultiplyTwoNums(30,3));
        }

        public static int AddTwoNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractTwoNums(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int MultiplyTwoNums(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int DivideTwoNums(int num1, int num2)
        {
            return num1 / num2;
        }
        
    }
}
