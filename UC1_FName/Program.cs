using UC1_FName;

namespace UC1_FName
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter the First Name: ");
            string fname = Console.ReadLine();
            bool name = p.validate_fname(fname);
            if (name)
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
    }
}
