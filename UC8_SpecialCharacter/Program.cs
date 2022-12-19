using UC8_SpecialCharacter;

namespace UC8_SpecialCharacter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            bool pwd = p.validate_pwd(password);
            if (pwd)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
