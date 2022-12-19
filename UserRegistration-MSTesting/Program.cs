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
        }
    }
}