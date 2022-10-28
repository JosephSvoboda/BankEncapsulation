namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();

                Console.WriteLine("Type Deposit or GetBalance.");

            var u = Console.ReadLine();
               
            if (u == "Deposit")
            {
                Console.WriteLine($"Account balance: ${bankAccount.GetBalance()}");
                Console.Write("Type in your desired amount to deposit: ");
                var i = Convert.ToInt32(Console.ReadLine());
                bankAccount.Deposit(i);
                Console.WriteLine($"New balance is: ${i}");
            }
            else if (u == "GetBalance")
            {
                Console.WriteLine(bankAccount.GetBalance());
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}
