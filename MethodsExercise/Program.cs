using System.Net.Security;

namespace MethodsExercise
{
    public class Program
    {
        public static void GatheringUsersInfo()
        {
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
            
            
        }
    }
}
