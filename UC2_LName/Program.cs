using UC2_LName;

namespace UC2_LName
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter the Last Name: ");
            string Lname = Console.ReadLine();
            bool lname = p.validate_lname(Lname);
            if (lname)
            {
                Console.WriteLine("Valid last name");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
