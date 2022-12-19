namespace UserRegistration_MSTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to User Registration MS testing Program");

            UserRegistration user = new UserRegistration();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            user.FirstName(firstName);

            Console.Write("Enter Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(user.LastName(LastName));
        }
    }
}