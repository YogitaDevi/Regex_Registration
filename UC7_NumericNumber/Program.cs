using UC7_NumericNumber;

namespace UC7_NumericNumber
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
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
