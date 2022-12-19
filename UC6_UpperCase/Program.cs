using UC6_UpperCase;

namespace UC6_UpperCase
{
    public class Program
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
