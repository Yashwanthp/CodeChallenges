using System;

namespace MyATMMachine
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the amount to withdraw");

            //long amounttowithdraw = Int64.TryParse(Console.ReadLine(),out valid);

            try
            {
                var amounttowithdraw = Int64.Parse(Console.ReadLine());

                Console.WriteLine(":" + amounttowithdraw);

                ICashDispenser cd = new MyCashDispenser();
                IDisplay dis = new MyDisplay();
                IAtmMachine a = new MyAtmMachine(cd, dis, amounttowithdraw);

                a.WithdrawCash(amounttowithdraw);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter valid amount.");
            }



        }
    }


}
