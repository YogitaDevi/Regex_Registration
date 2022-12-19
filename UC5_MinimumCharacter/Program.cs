using UC5_MinimumCharacter;

namespace UC5_MinimumCharacter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            bool pwd = p.validate_pwd(password);
            if (pwd)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
