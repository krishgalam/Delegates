using System;

namespace DelegatesDemo
{
    public delegate void DepositDelegate(int amount);
    public delegate string GetBalanceDelegate(string customerId);

    public class Program
    {
        static void Main(string[] args)
        {
            // Method Calling
            DelegateClass cls = new DelegateClass();
            
            cls.DepositAmount(1000);
            var result = DelegateClass.GetBalance("hari341");
            Console.WriteLine(result);

            // Using Delegate

            //DepositDelegate depositDelegate = new DepositDelegate(cls.DepositAmount);  Works well

            // Simplified flow
            DepositDelegate depositDelegate = cls.DepositAmount;

            // depositDelegate(1000); // works 
            depositDelegate.Invoke(1000); // works as well  

            GetBalanceDelegate getBalanceDelegate = DelegateClass.GetBalance;

            //getBalanceDelegate.Invoke("hari341");
            getBalanceDelegate("hari341");


            // MultiCastDelgate Demo
            MultiCastDelegateClass multiCastDelegateObj = new MultiCastDelegateClass();
            Calculate calculate = multiCastDelegateObj.Area;
            calculate += multiCastDelegateObj.Perimeter;

            // Here it execute both in sequence
            calculate.Invoke(100, 200);

            calculate.Invoke(12, 24);




        }

        // Call DepositAmount Method with out delegate

       
        
        
    }


    public class DelegateClass
    {

        public void DepositAmount(int amount)
        {
            Console.WriteLine("Amount Deposited " + amount);
        }

        public static string GetBalance(string customerId)
        {
            return string.Format("Amount Available for customer Id {0}  10000", customerId);
        }
    }
}
