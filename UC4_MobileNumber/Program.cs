using UC4_MobileNumber;

namespace UC4_MobileNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter the Mobile Number: ");
            string Number = Console.ReadLine();
            bool number = p.validate_Number(Number);
            if (number)
            {
                Console.WriteLine("valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number");
            }
        }
    }
}
