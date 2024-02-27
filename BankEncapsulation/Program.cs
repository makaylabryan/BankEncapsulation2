namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine($"How much would you like to deposit?");
            var depositAmount = double.Parse(Console.ReadLine());

            myAccount.Deposit(depositAmount);

            Console.WriteLine($"Your balance is ${myAccount.GetBalance()}");
        }
    }
}
