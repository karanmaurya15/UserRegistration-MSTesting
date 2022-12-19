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

            Console.Write("Enter Mobile Number with Country Code : ");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(user.MobileNumber(mobileNumber));

            Console.WriteLine("Enter Password With 1 Captial latter  and 1 numeric min  8 Characters : ");
            string password = Console.ReadLine();
            Console.WriteLine(user.Password(password));
        }
    }
}