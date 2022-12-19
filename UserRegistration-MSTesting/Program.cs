namespace UserRegistration_MSTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to User Registration MS testing Program\n");

            UserRegistration user = new UserRegistration();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine(user.FirstName(firstName));

            Console.Write("Enter Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(user.LastName(LastName));

            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            Console.WriteLine(user.EmailId(email));
        }
    }
}