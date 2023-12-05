using System;

namespace Tymakov13
{
    internal class BankTransaction
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
        }
        private DateTime time;
    
        public DateTime Time
        {
            get { return time; }
        }
       
        internal BankTransaction(double balance)
        {
            this.balance = balance;
            time = DateTime.Now;
        }
      
        public string Print()
        {
            return $"Операция на сумму: {balance} Перевод сделан в {time}";
        }
    }
}