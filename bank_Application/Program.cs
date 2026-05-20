using System.ComponentModel;

namespace bank_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("========SL BANK=========");
            Console.WriteLine("========================");
            Console.WriteLine("==WELLCOME TO THE BANK==");
            Console.WriteLine("========================");

            //Question 2
            string BankName = "Sl Bank";
            string AccountHolderName = "Kumaran";
            int AccountNumber = 123456789;
            decimal Balance = 1000.000m;

            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("your current Balance: " + "$" + Balance);


            // question 3

            Console.WriteLine("Enter your name: ");
            AccountHolderName = Console.ReadLine();

            Console.WriteLine("Enter the balance Amount : ");
            Balance = decimal.Parse(Console.ReadLine());

            //question 4

            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine($"your current Balance: $ : { Balance:F2}");
            Console.Clear();



            // question 5

            int chooseMenu;
            
            Console.WriteLine(" 1) View Account \n 2) Check Balance \n 3) Deposit \n 4) Withdraw \n 5) Exit");

            Console.WriteLine("Enter the menu number: ");
            chooseMenu = int.Parse(Console.ReadLine());

            Console.Clear();



            //question 6 

            bool running = true;

            //using if-else

            while (running)
            {
                Console.WriteLine(" 1) View Account \n 2) Check Balance \n 3) Deposit \n 4) Withdraw \n 5) Exit");

                Console.WriteLine("Enter the menu number: ");
                chooseMenu = int.Parse(Console.ReadLine());

                if(chooseMenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Account Holder Name: " + AccountHolderName);
                    Console.WriteLine("Account Number : " + AccountNumber);
                    Console.WriteLine("your current Balance: " + "$" + Balance);

                }
                else if (chooseMenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Your Account balance:  " + Balance);

                }
                else if(chooseMenu == 3)
                {
                    Console.Clear();
                    decimal Amount;
                    Console.WriteLine("Enter Amount: ");
                    Amount = decimal.Parse(Console.ReadLine());
                    if(Amount <= 0)
                    {
                        Console.WriteLine("Enter valid amount");
                    }
                    else
                    {
                        Balance += Amount;
                        Console.WriteLine("Deposit successfully");
                        Console.WriteLine("Your Account New balance:  " + Balance);
                    }

                    

                }
                else if (chooseMenu == 4)
                {
                    Console.Clear();
                    decimal widthrawalAmount;
                    Console.WriteLine("Enter your widhtrawal Amount: ");
                    widthrawalAmount = decimal.Parse(Console.ReadLine());
                    if (widthrawalAmount <= Balance && widthrawalAmount > 0)
                    {
                        Balance -= widthrawalAmount;
                        Console.WriteLine("Widthrawal successfully");
                        Console.WriteLine("Your Account New balance:  " + Balance);

                    }
                    else
                    {
                        Console.WriteLine("insufficient balance");
                    }

                }
                else if (chooseMenu == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using");
                    running = false;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter correct number");
                    running = false;
                }

            }

            //using Switch

            while (running)
            {
                Console.WriteLine(" 1) View Account \n 2) Check Balance \n 3) Deposit \n 4) Withdraw \n 5) Exit");

                Console.WriteLine("Enter the menu number: ");
                chooseMenu = int.Parse(Console.ReadLine());

                switch (chooseMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Account Holder Name: " + AccountHolderName);
                        Console.WriteLine("Account Number : " + AccountNumber);
                        Console.WriteLine("your current Balance: " + "$" + Balance);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Your Account balance:  " + Balance);
                        break;

                    case 3:
                        Console.Clear();
                        decimal Amount;
                        Console.WriteLine("Enter Amounr: ");
                        Amount = decimal.Parse(Console.ReadLine());
                        Balance += Amount;
                        Console.WriteLine("Deposit successfully");
                        Console.WriteLine("Your Account New balance:  " + Balance);
                        break;

                    case 4:
                        Console.Clear();
                        decimal widthrawalAmount;
                        Console.WriteLine("Enter your widhtrawal Amount: ");
                        widthrawalAmount = decimal.Parse(Console.ReadLine());
                        if(widthrawalAmount <= Balance)
                        {
                            Balance -= widthrawalAmount;
                            Console.WriteLine("Widthrawal successfully");
                            Console.WriteLine("Your Account New balance:  " + Balance);

                        }
                        else
                        {
                            Console.WriteLine("insufficient balance");
                        }
                        break;

                    case 5: 
                        Console.Clear();
                        Console.WriteLine("Thank you for using");
                        running = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Enter correct number");
                        break;
                }
            }





        }
    }
}
