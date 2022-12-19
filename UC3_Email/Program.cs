using UC3_Email;

namespace UC3_Email
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter the Email: ");
            string email = Console.ReadLine();
            bool zip = p.validate_email(email);
            if (zip)
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
        }
    }
}